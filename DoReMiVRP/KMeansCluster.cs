using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accord.Controls;
using Accord.MachineLearning;

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

        public static void  ResetClusteredObjects()
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
                        CityData city = new CityData(items[0], float.Parse(items[1]), float.Parse(items[2]));
                        //Console.WriteLine(i.ToString() + " - " +city.CityName);
                        CityDataObjects[j].Add(items[0], city);
                        i += 1;
                    }
                    else {
                        j += 1; i = 1; CityDataObjects[j] = new Hashtable();
                        items = item.Split(',');
                        CityData city = new CityData(items[0], float.Parse(items[1]), float.Parse(items[2]));
                        Console.WriteLine(i.ToString() + " - " + city.CityName);
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

      

    }

    public class CityData
    {
        public string CityName { get; set; }
        public float X { get; set; }
        public float Y { get; set; }

        public CityData(string CityName, float X, float Y)
        {
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

        public ClusterData(System.Drawing.Color color, float X, float Y)
        {
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


