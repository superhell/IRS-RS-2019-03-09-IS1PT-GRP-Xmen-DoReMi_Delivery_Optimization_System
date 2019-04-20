using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accord.Controls;
using Accord.MachineLearning;
using static Sys.Tool.Truck;

namespace Sys.Tool
{
    public class KmeansCluster
    {
        public static Hashtable[] CityDataObjects;  // 4 sets of cities
        public static ArrayList CityList = new ArrayList();
        public static ArrayList[] ClusteredObjects;
        public static int ClusterCount = 1;

        private static string ApplicationPath()
        {
            return AppDomain.CurrentDomain.BaseDirectory;
        }

        public static void ResetClusteredObjects()
        {
            for (int x = 0; x < ClusterCount; x++)
            {
                ClusteredObjects[x].Clear();
            }
        }


        public static void SetUpMap(string MapFile, int NumofClusters)
        {
            try
            {

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

    public class Truck
    {
        public enum EnumTruckType
        {
            None=0,
            Class6 = 1,
            Class7 = 2,
            Class8 = 3
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
            if (TruckType == EnumTruckType.Class6) _Capacity = 3000;
            if (TruckType == EnumTruckType.Class7) _Capacity = 5000;
            if (TruckType == EnumTruckType.Class8) _Capacity = 7000;
        }
 
              


    }
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
    public class ClusterData
    {
        public System.Drawing.Color Color { get; set; }
        public float X { get; set; }
        public float Y { get; set; }
        public float Quantity { get; set; }

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


}


