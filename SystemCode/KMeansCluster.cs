using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accord.Controls;
using Accord.MachineLearning;
using ZedGraph;
using Accord.Math;
using static Sys.Tool.Truck;
using System.Drawing;

namespace Sys.Tool
{
    public class KmeansCluster
    {
        public static Hashtable[] CityDataObjects;  // 4 sets of cities
        public static ArrayList CityList = new ArrayList();
        public static ArrayList[] ClusteredObjects;
        public static ArrayList[] PreviousClusteredObjects;

        public static int ClusterCount = 1;
        public static SortedDictionary<double, Route> Routes = new SortedDictionary<double, Route> ();
        public static Route Route = new Route();
        public static int RouteIterationMax = 10; //Set to 10, to remain as a constant
        public static int RouteIterationCount = 0;
        public static  int[] classifications;
        public static bool IsMapDataEdited=false;

        private static string MapFilename = "";

        private static string ApplicationPath()
        {
            return AppDomain.CurrentDomain.BaseDirectory;
        }

        public static void ResetClusteredObjects()
        {
            PreviousClusteredObjects = new ArrayList[ClusterCount];

            Sys.Tool.Serialization.SerializeObject(ClusteredObjects, "clusteredobjects" +  ".xml");
            for (int x = 0; x < ClusterCount; x++)
            {
                //Sys.Tool.Serialization.SerializeObject(ClusteredObjects[x], "clusteredobjects_" + x.ToString() +".xml");
                ClusteredObjects[x].Clear();
            }
            //for (int x = 0; x < ClusterCount; x++)
            //{
            //    PreviousClusteredObjects[x] = (ArrayList)Sys.Tool.Serialization.DeSerializeObject("clusteredobjects_" + x.ToString() + ".xml");
            //}
                  

            PreviousClusteredObjects = (ArrayList[])Sys.Tool.Serialization.DeSerializeObject("clusteredobjects" + ".xml");
           


        }


        public static void SetUpMap(string MapFile, int NumofClusters)
        {
            try
            {
                MapFilename = MapFile;
                CityList.Clear();
                ClusterCount = NumofClusters;
                CityDataObjects = new Hashtable[NumofClusters];
                ClusteredObjects = new ArrayList[NumofClusters];


                for (int x = 0; x < NumofClusters; x++)
                {
                    ClusteredObjects[x] = new ArrayList();
                }


                float AveCityPerCluster = 0;
                string[] items;
                string data = "";

                System.IO.StreamReader sr = new System.IO.StreamReader(MapFile);
                data = sr.ReadLine();//skip first row, header row
                data = sr.ReadLine();

                while (data != null)
                {
                    CityList.Add(data);
                    data = sr.ReadLine();
                }
                AveCityPerCluster = (float)CityList.Count / (float)NumofClusters;
                int m = CityList.Count % NumofClusters;
                //Ensure all cities distributed between the number of clusters for K-Means computation later
                AveCityPerCluster = (float)Math.Round(AveCityPerCluster, 0);
                AveCityPerCluster += m;

                int j = 0;
                int i = 1;

                CityDataObjects[j] = new Hashtable();

                foreach (string item in CityList)
                {

                    if (i <= AveCityPerCluster)
                    {
                        items = item.Split(',');
                        CityData city = new CityData(items[0], float.Parse(items[1]), float.Parse(items[2]), float.Parse(items[3]));
                        //Console.WriteLine(i.ToString() + " - " +city.CityName);
                        CityDataObjects[j].Add(items[0], city);
                        i += 1;
                    }
                    else {
                        j += 1; i = 1; CityDataObjects[j] = new Hashtable();
                        items = item.Split(',');
                        CityData city = new CityData(items[0], float.Parse(items[1]), float.Parse(items[2]), float.Parse(items[3]));
                        //Console.WriteLine(i.ToString() + " - " + city.CityName);
                        CityDataObjects[j].Add(items[0], city);
                    }

                }


            }
            catch (Exception e)
            {
                throw e;
            }
            // 

        }



        public static Truck ProcessVehicleAssignment(System.Drawing.Color ClusterColor, ref VehiclePlan VP)
        {
            float TotalCapacity = 0.0f;
            int index = -1;

            //locate the right cluster data array
            for (int j = 0; j < ClusterCount; j++)
            {
               if (( (ClusterData)ClusteredObjects[j][0]).Color == ClusterColor)
                {
                    index = j; break;
                }
            }

            //get total weight
            foreach (var item in ClusteredObjects[index])
            {
                ClusterData data = (ClusterData)item;
                TotalCapacity += data.Quantity;
                  
            }

            Truck truck = new Truck(0, EnumTruckType.None, "", "");
            foreach (var obj in VP.Trucks)
            {
                truck = (Truck)obj.Value;

                if(truck.Assigned == false)
                {
                    int w = truck.Capacity;
                    if (w > (int)TotalCapacity)
                    {
                        truck.Route = ClusteredObjects[index];
                        truck.Assigned = true;
                        truck.LoadCapacity = (int)TotalCapacity;
                        
                        break;
                    }
                }
               
            }

            return truck;
        }


        public static CityData GetCityData(float X, float Y)
        {
            CityData item = null;
            bool result = false;

            for (int j = 0; j < ClusterCount; j++)
            {
                foreach (System.Collections.DictionaryEntry obj in CityDataObjects[j])
                {
                    item = (CityData)obj.Value;
                    if (item.X == X && item.Y == Y)
                    {
                        result = true;
                    }
                }
                if (result) break;
            }
            return item;

        }


    }

    [Serializable]
    public class VehiclePlan
    {

        public SortedDictionary<float, Truck> Trucks;

        private int _VehicleCount = 6; //Max 6
        public int VehicleCount { get { return _VehicleCount; } }

        public VehiclePlan(int VehicleCount)
        {
            _VehicleCount = VehicleCount;
            Trucks = new SortedDictionary<float, Truck>();
        }

        public void Add(int Number, EnumTruckType TruckType, string DriverName, string LicenseNo)
        {
            if (Trucks.Count == _VehicleCount) throw new Exception("Maximum trucks available is " + _VehicleCount.ToString() + ".");
            Truck T = new Truck(Number, TruckType, DriverName, LicenseNo);
            Trucks.Add(T.Capacity + (float)Number / 100.0f, T);
        }
        public void ClearAssignment()
        {
            foreach (var obj in Trucks)
            {
                Truck item = (Truck)obj.Value;
                item.Assigned = false;
            }

        }
    }

    [Serializable]
    public class Truck
    {
        public enum EnumTruckType
        {
            None=0,
            Class4 = 1,
            Class5 = 2,
            Class6 = 3,
            Class7 = 4,
            Class8 = 5,
            Class9 = 6
        }

        public int LoadCapacity = 0;
        public bool Assigned = false;
        public object Route = null; //contain the final route data

        public string DriverName { get; set; }
        public string LicenseNo { get; set; }
        public int Number { get; set; }
        public EnumTruckType TruckType = EnumTruckType.Class7;
        
        private int _Capacity=0;
        public int Capacity { get { return _Capacity; }  }

    public Truck(int Number, EnumTruckType TruckType, string DriverName,  string LicenseNo)
        {
            this.Number = Number;
            this.TruckType = TruckType;
            this.DriverName = DriverName;
            this.LicenseNo = LicenseNo;
            if (TruckType == EnumTruckType.Class4) _Capacity = 2500;
            if (TruckType == EnumTruckType.Class5) _Capacity = 3000;
            if (TruckType == EnumTruckType.Class6) _Capacity = 3500;
            if (TruckType == EnumTruckType.Class7) _Capacity = 4000;
            if (TruckType == EnumTruckType.Class8) _Capacity = 5500;
            if (TruckType == EnumTruckType.Class9) _Capacity = 7500;
        }
 
              


    }

    [Serializable]
    public class CityData
    {
        public string CityName { get; set; }
        public float X { get; set; }
        public float Y { get; set; }
        public float Quantity { get; set; }

        public CityData(string CityName, float X, float Y, float Quantity)
        {
            this.Quantity = Quantity;
            this.CityName = CityName;
            this.X = X;
            this.Y = Y;
        }

        public void Clear()
        {
            this.CityName = "";
            this.X = 0.0f;
            this.Y = 0.0f;
        }
    }

    [Serializable]
    public class ClusterData
    {
        public System.Drawing.Color Color { get; set; }
        public float X { get; set; }
        public float Y { get; set; }
        public float Quantity { get; set; }

        public ClusterData() { }

        public ClusterData(System.Drawing.Color color, float X, float Y, float Quantity)
        {
            this.Quantity = Quantity;
            this.Color = color;
            this.X = X;
            this.Y = Y;
        }

        public void Clear()
        {
            this.Color = System.Drawing.Color.Transparent;
            this.X = 0.0f;
            this.Y = 0.0f;
        }

    }

    [Serializable]
    public class Route
    {
        public   float TotalDistance = 0.0f;
        public   int TotalLoadCapcity = 0;
        public   int TotalTruckCapacity = 0;
        public   float CapacityUsagePercentage = 0.0f;
        //public   Hashtable Data = new Hashtable(); //this will contain each cluster path coordinates array, and cluster color

        public  SortedDictionary<double, RouteData> Data = new SortedDictionary<double, RouteData>() ;

     
        public  int RouteRunCount = 0;
        public  int ClusterCount;
        public  bool IsReadyToDraw = false;
        public  bool IsBetterSolution = false;
        public bool IsComplete = false;
 

        public Route()
        {     
        }



        public  void DrawRoutes(ZedGraphControl zgc)
        {
            if (!IsReadyToDraw) return;

            IsReadyToDraw = false;

            GraphPane myPane = zgc.GraphPane;
            System.Drawing.Color color;

            try
            {
                foreach (var obj in Data)
                {
                    RouteData item = (RouteData)obj.Value;
                    color = item.ClusterColor;
                    LineItem curve;

                    double[] x = item.path.GetColumn(0);
                    double[] y = item.path.GetColumn(1);

                    curve = myPane.AddCurve("", x, y, color, SymbolType.Plus);
                    curve.Line.Width = 2.5F;

                    //*********************************
                    double xp = x[6];
                    double yp = y[6];
                    int xf = 1; int yf = 1;
                    if (xp < 0) xf = -1; xp = xp - 0.25f * xf; if (xp < -7.0f) xp = -7.0f; if (xp > 4.0f) xp = 4.0f;
                    if (yp < 0) yf = -1; yp = yp + 0.25f * xf;

                    TextObj text = new TextObj("Total Distance: " + item.Distance.ToString() + "km, \r\nDriver: " + item.Truck.DriverName + "\r\n Load: " + item.Truck.LoadCapacity.ToString() + "\r\n Capacity: " + item.Truck.Capacity.ToString() + "\r\n Truck: " + item.Truck.TruckType.ToString(), xp, yp);
                    // tell Zedgraph to use user scale units for locating the TextObj
                    text.Location.CoordinateFrame = CoordType.AxisXYScale;
                    text.FontSpec.Size = 6;
                    // AlignH the left-center of the text to the specified point
                    text.Location.AlignH = x[4] > 0 ? AlignH.Left : AlignH.Right;
                    text.Location.AlignV = AlignV.Center;
                    text.FontSpec.Border.IsVisible = true;


                    text.FontSpec.Fill.Color = Color.FromArgb(220, 255, 255, 255);
                    text.FontSpec.Border.Color = Color.DarkGray;
                    text.FontSpec.Border.Width = 1;

                    text.FontSpec.Angle = 0;
                    text.FontSpec.Fill.IsVisible = true;
                    // add the TextObj to the list
                    myPane.GraphObjList.Add(text);

                }
            }
            catch (Exception e)
            {
                throw e;
            }
            zgc.Invalidate();
        }

        public  void AddRoute(RouteData routedata)
        {
             int RouteIterationMax = Sys.Tool.KmeansCluster.RouteIterationMax;
             int RouteIterationCount = Sys.Tool.KmeansCluster.RouteIterationCount;

            if (RouteIterationCount <= RouteIterationMax)
            {
                if (RouteRunCount == 0) {  IsComplete = false; }
               if ( IsComplete == true) IsReadyToDraw = true; // always draw first set
               

                RouteRunCount += 1;
                TotalDistance += (float)routedata.Distance;

                TotalLoadCapcity += routedata.Truck.LoadCapacity;
                TotalTruckCapacity += routedata.Truck.Capacity;
                Data.Add(routedata.Distance, routedata);

                if (RouteRunCount == ClusterCount) //all clustered data is processed, check if the current solution is better
                {
                    //CalculateCapacityPercentage();

                    RouteRunCount = 0;
                    IsReadyToDraw = true;
                    
                    IsComplete = true;
                    // At calling parent, this will be checked to decide if each iteration is complete.
                    //An iteration is complete  if all clustered data is processed 
                    //(1 full cycle - if the starting cluster count is 4, a complete iteration would be after processing 4 clustered data

                    //Check if solution is better and update the graph display
                    //IsBetterSolution

                    IsBetterSolution = false;

                     if (Sys.Tool.KmeansCluster.Routes.Count>0)
                    {
                        //Get the previous route
                        Route PrevRoute;
                        //double key = Sys.Tool.KmeansCluster.Routes.ElementAt(Sys.Tool.KmeansCluster.RouteIterationCount-1).Key; //Cannot take previous record.

                        double key = Sys.Tool.KmeansCluster.Routes.ElementAt(0).Key; //*** Must take the record with the smallest total distance
                        PrevRoute = (Route)Sys.Tool.KmeansCluster.Routes[key];
                        //The first element (Route) is the always containing the route with the least total route distance for 1 colored clustered route

             
                        PrevRoute = (Route)Sys.Tool.KmeansCluster.Routes.Values.First();
                 
                         

                        //Compare the previous route with current one
                        float CurrentCapPercentage = ((float)TotalLoadCapcity / (float)TotalTruckCapacity) * 100.0f;
                        CurrentCapPercentage = (float) Math.Round(CurrentCapPercentage,2);

                        bool resultFound = false;

                       
                        //Case 1
                        if (PrevRoute.TotalDistance > this.TotalDistance)
                        {

                            if (CurrentCapPercentage > PrevRoute.CapacityUsagePercentage)
                            {
                                //Current overall routes is better then the previous iteration
                                IsReadyToDraw = true;
                                IsBetterSolution = true; //Tag as better solution   
                                resultFound = true;
                            }
                        }

                        //Case 2
                        if (PrevRoute.TotalDistance > this.TotalDistance && resultFound == false)
                        {
                            if (CurrentCapPercentage <= PrevRoute.CapacityUsagePercentage)
                            {
                                //Current overall routes is better then the previous iteration
                                IsReadyToDraw = true;
                                IsBetterSolution = true; //Tag as better solution
                               
                            }

                        }

                    }

                    Sys.Tool.KmeansCluster.RouteIterationCount += 1;
                    if (Sys.Tool.KmeansCluster.RouteIterationCount == 1) IsBetterSolution = true; //always draw first iteration
                }
               
            }

        }

        public void CalculateCapacityPercentage()
        {
            this.TotalTruckCapacity = 0;
            this.TotalLoadCapcity = 0;

            foreach(var obj in Data)
            {
                RouteData item = (RouteData)obj.Value;
                this.TotalTruckCapacity += item.Truck.Capacity;
                this.TotalLoadCapcity += item.Truck.LoadCapacity; 
            }
            this.CapacityUsagePercentage = ((float)this.TotalLoadCapcity / (float)this.TotalTruckCapacity) * 100;
            this.CapacityUsagePercentage = (float)Math.Round(this.CapacityUsagePercentage, 2);

        }

        public  void Clear()
        {
            TotalDistance = 0.0f;
            TotalLoadCapcity = 0;
            TotalTruckCapacity = 0;
            CapacityUsagePercentage = 0.0f;
            Data = new SortedDictionary<double, RouteData>();
            RouteRunCount = 0;           
            IsReadyToDraw = false;
            IsBetterSolution = false;
        }

        

    }

    [Serializable]
    public class RouteData
    {
        public double[,] path;
        public System.Drawing.Color  ClusterColor;
        public double Distance;
        public  Truck Truck;
    }


}


