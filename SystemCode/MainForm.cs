using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accord.Controls;
using Accord.MachineLearning;
using Accord.Math;
using Accord.Statistics.Distributions.Multivariate;
 
using Sys.Tool;
using ZedGraph;

namespace DoReMiVRP
{
    public partial class MainForm : Form
    {

        bool isTopPanelDragged = false;
        bool isLeftPanelDragged = false;
        bool isRightPanelDragged = false;
        bool isBottomPanelDragged = false;
        bool isTopBorderPanelDragged = false;

        bool isRightBottomPanelDragged = false;
        bool isLeftBottomPanelDragged = false;
        bool isRightTopPanelDragged = false;
        bool isLeftTopPanelDragged = false;

        bool isWindowMaximized = false;
      

        Point offset;
        Size _normalWindowSize;
        Point _normalWindowLocation = Point.Empty;

        // Visually distinct colors used in the pie graphics
        ColorSequenceCollection colors = new ColorSequenceCollection();
        int k; // the number of clusters assumed present in the data
        double[][] observations; // the data points containing the mixture
        KMeans kmeans;
        int ClusterCount = 4;
        double[][][] data;
        bool IsBlackWhite = false;
        bool IsProcessStarted = false;

        GeneticAlgorithm GA = new GeneticAlgorithm();
        Sys.Tool.VehiclePlan VehiclePlan = new Sys.Tool.VehiclePlan(6);

        public MainForm()
        {
            InitializeComponent();

            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            this.TopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseUp);

            this.TopBorderPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBorderPanel_MouseDown);
            this.TopBorderPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopBorderPanel_MouseMove);
            this.TopBorderPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopBorderPanel_MouseUp);

            this.RightPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RightPanel_MouseDown);
            this.RightPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RightPanel_MouseMove);
            this.RightPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RightPanel_MouseUp);

            this.LeftPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LeftPanel_MouseDown);
            this.LeftPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LeftPanel_MouseMove);
            this.LeftPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LeftPanel_MouseUp);

            this.BottomPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BottomPanel_MouseDown);
            this.BottomPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BottomPanel_MouseMove);
            this.BottomPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BottomPanel_MouseUp);

            this.RightBottomPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RightBottomPanel_MouseDown);
            this.RightBottomPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RightBottomPanel_MouseMove);
            this.RightBottomPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RightBottomPanel_MouseUp);

            this.btnClose.MouseClick += BtnClose_MouseClick;
            this.MaxButton.MouseClick += MaxButton_MouseClick;
            this.MinButton.MouseClick +=  MinButton_MouseClick;
            this.CloseButton.MouseClick += CloseButton_MouseClick;


            this.BtnKMeans.Click += new System.EventHandler(this.BtnKMeans_Click);
         
            this.btnReset.Click += BtnReset_Click;
            this.chkBWMap.CheckedChanged += new System.EventHandler(this.chkBWMap_CheckedChanged);
            this.btnEntry.Click += new System.EventHandler(this.btnEntry_Click);
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);

            this.mapgraph.MouseMove += Mapgraph_MouseMove;
            this.mapgraph.Click += Mapgraph_Click;

            cboClusterSize.SelectedIndexChanged += CboClusterSize_SelectedIndexChanged;

            this.panelRight.Width = 220; //must not be changed
            this.panelSide.Width = 160; //must not be changed
            this.Width = 1400; //must not be changed
            this.Height = 900; //must not be changed
        

            //Show mapgraph size
            txtXY.Text = mapgraph.Width.ToString() + "," + mapgraph.Height.ToString();
            lblResult.Text = "";
            lblResult.Visible = true;
            lblSolution.Text = "";
            lblSolution.Visible = true;

            this.ProgressBar.Value = 0;
            this.ProgressBar.Minimum = 0;
            int n = Sys.Tool.KmeansCluster.RouteIterationMax;
            this.ProgressBar.Maximum = n;
            cboClusterSize.SelectedIndex =2;

            SetupVehiclePlan();
        }

         

        private void CboClusterSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckDropDownClusterNo();
        }

        private void CheckDropDownClusterNo()
        {
            try
            {
                if (cboClusterSize.Text == "") { cboClusterSize.Text = "4"; }
                if (cboClusterSize.Text.Trim() == "0") { cboClusterSize.Text = "4"; }
                this.ClusterCount = int.Parse(cboClusterSize.Text);
            }
            catch (Exception e)
            {
                cboClusterSize.Text = "4"; this.ClusterCount = 4;
            }
        }
        private void CloseButton_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

  
       

        private void BtnReset_Click(object sender, EventArgs e)
        {
            Init();
        }

        private void Mapgraph_MouseMove(object sender, MouseEventArgs e)
        {
            var x = ((MouseEventArgs)e).X;
            var y = ((MouseEventArgs)e).Y;
            SetCoordinates(x, y);
        }


        private void chkBWMap_CheckedChanged(object sender, EventArgs e)
        {
           
            IsBlackWhite = (chkBWMap.Checked == true);
           
            SetBackgroundImage();
          

        }

        private void Mapgraph_Click(object sender, EventArgs e)
        {
            var x = ((MouseEventArgs)e).X  ;
            var y = ((MouseEventArgs)e).Y  ;

            SetCoordinates(x, y);

        }

        private void SetCoordinates(int x, int y)
        {
            //1420, 760
            //cartesian coordinates
            //X -> -10 to 0 to +10
            //Y -> -10 to 0 to +10

            float mx = 0;
            float my = 0;

            if (mapgraph.Width > 1076)
            {
                x = x - 82;
                y = y - 3 - 36;
                mx = (1482.0f / 2.0f);
                my = (762.0f / 2.0f);
            }
            else
            {
                x = x - 65;
                y = y - 35;
                mx = (986.0f / 2.0f);
                my = (604.0f / 2.0f);
            }


            float fx = 10.0f / mx;
            float fy = 10.0f / my;
            int xdirection = 1;
            int ydirection = 1;

            if (x < mx) xdirection = -1;
            if (y > my) ydirection = -1;

            float x1 = Math.Abs((mx - (float)x)) * fx * xdirection;
            float y1 = Math.Abs((my - (float)y)) * fy * ydirection;

            txtFinal.Text = x1.ToString() + ", " + y1.ToString();
            //txtXY.Text = x.ToString() + "," + y.ToString();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Init();
            GA.OnIterationLoop += GA_OnIterationLoop;
        }

        private void SetupVehiclePlan()
        {
            VehiclePlan.Add(1, Truck.EnumTruckType.Class4, "Tim J. Kelly", "EF6334K");
            VehiclePlan.Add(2, Truck.EnumTruckType.Class5, "Thomas S. Matthhew", "BG4409");
            VehiclePlan.Add(3, Truck.EnumTruckType.Class6, "Williams Barley", "KJJ3319");

            VehiclePlan.Add(4, Truck.EnumTruckType.Class7, "John Joe D.", "HT67852");
            VehiclePlan.Add(5, Truck.EnumTruckType.Class8, "Bill Dale", "KV4587");
            VehiclePlan.Add(6, Truck.EnumTruckType.Class9, "Jimmy K Lee", "BT7679");
        }
        private void Init()
        {
             
          
            k = this.ClusterCount;

            Sys.Tool.KmeansCluster.Route.ClusterCount = ClusterCount;

            lblResult.Text = "";
            lblSolution.Text = "";
            ProgressBar.Value = 0;
            Sys.Tool.KmeansCluster.RouteIterationCount = 0;
            Sys.Tool.KmeansCluster.Routes.Clear();

           GenerateMapData();

            mapgraph.GraphPane.Chart.Fill.IsVisible = true;
            mapgraph.GraphPane.Legend.IsVisible = false; // must not be turned on
            mapgraph.GraphPane.Legend.FontSpec.Size = 9.0f;
            mapgraph.GraphPane.Legend.Position = LegendPos.BottomCenter;

            mapgraph.GraphPane.Chart.Fill.Color = Color.Transparent;
            mapgraph.GraphPane.Title.IsVisible = true;

            mapgraph.GraphPane.XAxis.AxisGap = 0;
            mapgraph.GraphPane.YAxis.AxisGap = 0;

            mapgraph.GraphPane.XAxis.IsVisible = true;
            mapgraph.GraphPane.YAxis.IsVisible = true;

            mapgraph.GraphPane.Chart.Fill.IsVisible = false;
            mapgraph.IsEnableZoom = false;

            mapgraph.GraphPane.XAxis.MajorGrid.IsVisible = true;
            mapgraph.GraphPane.YAxis.MajorGrid.IsVisible = true;
            mapgraph.GraphPane.XAxis.MinorGrid.IsVisible = true;
            mapgraph.GraphPane.YAxis.MinorGrid.IsVisible = true;

            //clear all previous distance measurements
            mapgraph.GraphPane.GraphObjList.Clear();

        }

        private void GA_OnIterationLoop(EventArgsIterationLoop obj)
        {
            //Event is raised for every GA iteration
            //A 2 dimensional double array is the result you will get here
            //
            //Take the path array and draw a closed line on mapgraph control (zedgraph)

       
            CreateClusteredLines(mapgraph, obj.path, obj.color);

        }

        private void GenerateMapData()
        {
            k = ClusterCount;

            //double[][][] data = new double[k][][];
            data = new double[k][][];

            Sys.Tool.KmeansCluster.SetUpMap("iowa_map.txt",ClusterCount); // do not use, I will be working on this - Chad

            for (int i = 0; i < k; i++)
            {
                //**************************************************************************
                //Not required
                //**************************************************************************
                // Create random centroid to place the Gaussian distribution
                //double[] mean = Vector.Random(2, -6.0, +6.0);

                // Create random covariance matrix for the distribution
                //double[,] covariance = Accord.Statistics.Tools.RandomCovariance(2, -5, 5);

                // Create the Gaussian distribution
                //var gaussian = new MultivariateNormalDistribution(mean, covariance);
                //**************************************************************************

                //txtPoint1.Text =  data[0][0][0].ToString() + ", " +  data[0][0][1].ToString();
                //txtPoint2.Text = data[0][1][0].ToString() + ", " + data[0][1][1].ToString();

                int j = 0;
                //Load map data from file.
                int c = Sys.Tool.KmeansCluster.CityDataObjects[i].Count;
                data[i] = new double[c][];
                for (int h = 0; h < (c); h++)
                {
                    data[i][h] = new double[2];
                }
                foreach (System.Collections.DictionaryEntry item in Sys.Tool.KmeansCluster.CityDataObjects[i])
                {                                   
                    Sys.Tool.CityData obj = (Sys.Tool.CityData)item.Value;
                    data[i][j][0] = obj.X; data[i][j][1] = obj.Y;
                    j += 1;
                }
            }

            // Join the generated data
            observations = Matrix.Stack(data);

            // Update the scatter plot
            CreateScatterplot(mapgraph, observations, ClusterCount,true);

            // Forget previous initialization
            kmeans = null;

            //System.Drawing.Image img = System.Drawing.Bitmap.FromFile("iowa.png");
            //TextureBrush texBrush = new TextureBrush(img);
            //mapgraph.GraphPane.Fill = new Fill(texBrush);
        }

        private void SetBackgroundImage()
        {
            string file = "iowa.png";
            if (IsBlackWhite) { file="iowa_bw.png"; } 
            System.Drawing.Image img = System.Drawing.Bitmap.FromFile(file);
            TextureBrush texBrush = new TextureBrush(img);
            mapgraph.GraphPane.Fill = new Fill(texBrush);
            mapgraph.Invalidate();
        }

        //*************************************************************
        //This will not be used for the project
        //*************************************************************
        /// <summary>
        ///   Estimates Gaussian distributions from the data.
        /// </summary>
        /// 
        private void btnCompute_Click(object sender, EventArgs e)
        {
            // Create a new Gaussian Mixture Model
            var gmm = new GaussianMixtureModel(k);

            // If available, initialize with k-means
            if (kmeans != null)
                gmm.Initialize(kmeans);

            // Compute the model
            GaussianClusterCollection clustering = gmm.Learn(observations);

            // Classify all instances in mixture data
            //int[] classifications = clustering.Decide(observations);
            Sys.Tool.KmeansCluster.classifications = clustering.Decide(observations);
            // Draw the classifications
            updateGraph(Sys.Tool.KmeansCluster.classifications);
        }
        //*************************************************************
        
        /// <summary>
        ///   Initializes the Gaussian Mixture Models using K-Means
        ///   parameters as an initial parameter guess.
        /// </summary>
        /// 
        private void StartProcess( string message)
        {
            // Creates and computes a new 
            // K-Means clustering algorithm:

           // GenerateMapData();

            k = this.ClusterCount;
            Sys.Tool.KmeansCluster.Route.ClusterCount = ClusterCount;

            //***********************************************
            //Reset 
            //***********************************************
            //all drawings
            CreateScatterplot(mapgraph, observations, ClusterCount, false);
            //Vehicle assignment
            VehiclePlan.ClearAssignment();
            //***********************************************

            kmeans = new KMeans(ClusterCount);

            KMeansClusterCollection clustering = kmeans.Learn(observations);

            // Classify all instances in mixture data
            // int[] classifications = clustering.Decide(observations

            Sys.Tool.KmeansCluster.classifications = clustering.Decide(observations);
            

            // Draw the classifications
            updateGraph(Sys.Tool.KmeansCluster.classifications);

            //Use GA to find the continuous path for each cluster
            //for each cluster data, GA.LoadMap and Start() processing
            //For each iteration completed, an event is fired and the UI thread will draw updates on mapgraph

            //clear all previous distance measurements
            mapgraph.GraphPane.GraphObjList.Clear();

            foreach (var obj in Sys.Tool.KmeansCluster.ClusteredObjects)
            {
                
                    GA.LoadMap(obj);
                    GA.Start();
               
                
            }
           
        }




        private void updateGraph(int[] classifications)
        {
            // Paint the clusters accordingly
            for (int i = 0; i < k + 1; i++)
                mapgraph.GraphPane.CurveList[i].Clear();

            Sys.Tool.KmeansCluster.ResetClusteredObjects();

            for (int j = 0; j < observations.Length; j++)
            {
                int c = classifications[j];

                CurveItem Item = mapgraph.GraphPane.CurveList[c + 1];

                double[] point = observations[j];
                Item.AddPoint(point[0], point[1]);


                //Make sure to add the main city centre into each cluster
                //The main city centre is the first record in the city data file.
                ArrayList CityList = Sys.Tool.KmeansCluster.CityList;
                string[] data = CityList[0].ToString().Split(',');


                //*************************************************************************
                // Store clustered points for creating the final TSP
                // Depot - center point, weight  not required
                //*************************************************************************
                if (Item.Color == Color.FromArgb(0, 0, 51)) {
                    Item.Color = Color.OrangeRed;
                    //Store city centre for each cluster
                    ClusterData obj = new ClusterData(Item.Color, float.Parse(data[1]), float.Parse(data[2]),0 );
                    Sys.Tool.KmeansCluster.ClusteredObjects[c].Add(obj);
                }
                if (Item.Color == Color.FromArgb(0, 0, 255)) {
                    Item.Color = Color.Blue;
                    //Store city centre for each cluster
                    ClusterData obj = new ClusterData(Item.Color, float.Parse(data[1]), float.Parse(data[2]),0 );
                    Sys.Tool.KmeansCluster.ClusteredObjects[c].Add(obj);
                }
                if (Item.Color == Color.FromArgb(255, 0, 0)) {
                    Item.Color = Color.DarkRed;
                    //Store city centre for each cluster
                    ClusterData obj = new ClusterData(Item.Color, float.Parse(data[1]), float.Parse(data[2]),0 );
                    Sys.Tool.KmeansCluster.ClusteredObjects[c].Add(obj);
                }
                if (Item.Color == Color.FromArgb(0, 255, 0)) {
                    Item.Color = Color.Green;
                    //Store city centre for each cluster
                    ClusterData obj = new ClusterData(Item.Color, float.Parse(data[1]), float.Parse(data[2]),0 );
                    Sys.Tool.KmeansCluster.ClusteredObjects[c].Add(obj);
                }
                if (Item.Color == Color.FromArgb(255, 0, 182))
                {
                    Item.Color = Color.DeepPink;
                    //Store city centre for each cluster
                    ClusterData obj = new ClusterData(Item.Color, float.Parse(data[1]), float.Parse(data[2]), 0);
                    Sys.Tool.KmeansCluster.ClusteredObjects[c].Add(obj);
                }
                //*************************************************************************




                //***************
                if (Item.Color == Color.OrangeRed)
                {
                    float x = (float)point[0]; float y = (float)point[1];
                    CityData C = Sys.Tool.KmeansCluster.GetCityData(x, y);
                    ClusterData obj = new ClusterData(Item.Color, x, y, C.Quantity);
                    Sys.Tool.KmeansCluster.ClusteredObjects[c].Add(obj);
                }
                if (Item.Color == Color.Blue)
                {
                    float x = (float)point[0]; float y = (float)point[1];
                    CityData C = Sys.Tool.KmeansCluster.GetCityData(x, y);
                    ClusterData obj = new ClusterData(Item.Color,x, y, C.Quantity);
                    Sys.Tool.KmeansCluster.ClusteredObjects[c].Add(obj);
                }

                if (Item.Color == Color.DarkRed)
                {
                    float x = (float)point[0]; float y = (float)point[1];
                    CityData C = Sys.Tool.KmeansCluster.GetCityData(x, y);
                    ClusterData obj = new ClusterData(Item.Color, x, y, C.Quantity);
                    Sys.Tool.KmeansCluster.ClusteredObjects[c].Add(obj);
                }
                if (Item.Color == Color.Green)
                {
                    float x = (float)point[0]; float y = (float)point[1];
                    CityData C = Sys.Tool.KmeansCluster.GetCityData(x, y);
                    ClusterData obj = new ClusterData(Item.Color,x, y, C.Quantity);
                    Sys.Tool.KmeansCluster.ClusteredObjects[c].Add(obj);
                }
                if (Item.Color == Color.DeepPink)
                {
                    float x = (float)point[0]; float y = (float)point[1];
                    CityData C = Sys.Tool.KmeansCluster.GetCityData(x, y);
                    ClusterData obj = new ClusterData(Item.Color, x, y, C.Quantity);
                    Sys.Tool.KmeansCluster.ClusteredObjects[c].Add(obj);
                }
                //*************************************************************************
            }

            mapgraph.Invalidate();
        }


        public void CreateScatterplot(ZedGraphControl zgc, double[][] graph, int n, bool IsLoadBackground=false)
        {

            GraphPane myPane = zgc.GraphPane;
            myPane.CurveList.Clear();

            // Set graph pane object
            myPane.Title.IsVisible = true;
            myPane.Title.Text = "Route Plan by Group";
            myPane.Title.FontSpec.Size = 10.0f;
             
            myPane.XAxis.Title.Text = "";
            myPane.YAxis.Title.Text = "";

            myPane.Margin.All = 1;
            myPane.XAxis.Scale.Max = 10;
            myPane.XAxis.Scale.Min = -10;
            myPane.YAxis.Scale.Max = 10;
            myPane.YAxis.Scale.Min = -10;
            myPane.XAxis.IsAxisSegmentVisible = false;
            myPane.YAxis.IsAxisSegmentVisible = false;
            myPane.YAxis.IsVisible = false;
            myPane.XAxis.IsVisible = false;
            myPane.Border.IsVisible = false;


            //System.Drawing.Image img = System.Drawing.Bitmap.FromFile("iowa.png");
            //TextureBrush texBrush = new TextureBrush(img);
            //myPane.Fill = new Fill(texBrush);
            myPane.Chart.Fill.IsVisible = false;

            // Create mixture pairs
            PointPairList list = new PointPairList();
            for (int i = 0; i < graph.Length; i++)
                list.Add(graph[i][0], graph[i][1]);


            // Add the curve for the mixture points
            LineItem myCurve = myPane.AddCurve("Mixture", list, Color.Gray, SymbolType.Diamond);
            myCurve.Line.IsVisible = false;
            myCurve.Symbol.Border.IsVisible = false;
            myCurve.Symbol.Fill = new Fill(Color.SlateBlue);

            for (int i = 0; i < n; i++)
            {
                // Add curves for the clusters to be detected
                Color color = colors[i];
                myCurve = myPane.AddCurve("D" + (i + 1), new PointPairList(), color, SymbolType.Diamond);
                myCurve.Line.IsVisible = false;
                myCurve.Symbol.Border.IsVisible = false;
                myCurve.Symbol.Fill = new Fill(color);
            }

            // Fill the background of the chart rect and pane
            //myPane.Fill = new Fill(Color.WhiteSmoke);
            if (IsLoadBackground)
            {
                SetBackgroundImage();
                //System.Drawing.Image img = System.Drawing.Bitmap.FromFile("iowa.png");
                //TextureBrush texBrush = new TextureBrush(img);
                //mapgraph.GraphPane.Fill = new Fill(texBrush);
            }
         

            zgc.AxisChange();
            zgc.Invalidate();

            mapgraph.GraphPane.Chart.Fill.IsVisible = true;
            mapgraph.GraphPane.Legend.IsVisible = false; // must not be turned on
            mapgraph.GraphPane.Legend.FontSpec.Size = 9.0f;
            mapgraph.GraphPane.Legend.Position = LegendPos.BottomCenter;

            mapgraph.GraphPane.Chart.Fill.Color = Color.Transparent;
            mapgraph.GraphPane.Title.IsVisible = true;

            mapgraph.GraphPane.XAxis.AxisGap = 0;
            mapgraph.GraphPane.YAxis.AxisGap = 0;

            mapgraph.GraphPane.XAxis.IsVisible = true;
            mapgraph.GraphPane.YAxis.IsVisible = true;

            mapgraph.GraphPane.Chart.Fill.IsVisible = false;
            mapgraph.IsEnableZoom = false;

            mapgraph.GraphPane.XAxis.MajorGrid.IsVisible = true;
            mapgraph.GraphPane.YAxis.MajorGrid.IsVisible = true;
            mapgraph.GraphPane.XAxis.MinorGrid.IsVisible = true;
            mapgraph.GraphPane.YAxis.MinorGrid.IsVisible = true;

        }

        public void  CreateClusteredLines(ZedGraphControl zgc, double[,] path, Color color)
        {

           

            double distance = GA.CalculateTotalDistanceInKm(path);
            distance = Math.Round(distance, 2);
            Truck truck = Sys.Tool.KmeansCluster.ProcessVehicleAssignment(color, ref VehiclePlan);

            RouteData data = new RouteData();
            data.ClusterColor = color;
            data.path = path;
            data.Truck = truck;
            data.Distance = distance;

            

                Sys.Tool.KmeansCluster.Route.AddRoute(data);

                if (Sys.Tool.KmeansCluster.Route.IsComplete)
                {
                //CapacityUsagePercentage
                Sys.Tool.KmeansCluster.Route.CapacityUsagePercentage = ((float)Sys.Tool.KmeansCluster.Route.TotalLoadCapcity / (float)Sys.Tool.KmeansCluster.Route.TotalTruckCapacity) * 100;
                Sys.Tool.KmeansCluster.Route.CapacityUsagePercentage = (float)Math.Round(Sys.Tool.KmeansCluster.Route.CapacityUsagePercentage, 2);


                Sys.Tool.KmeansCluster.Routes.Add(Sys.Tool.KmeansCluster.Route.TotalDistance,
                      Sys.Tool.KmeansCluster.Route);




                if (Sys.Tool.KmeansCluster.Route.IsBetterSolution)
                {
                    Sys.Tool.Serialization.SerializeObject(Sys.Tool.KmeansCluster.classifications, "classifications.dat");
                    Sys.Tool.Serialization.SerializeObject(Sys.Tool.KmeansCluster.Route, "route.dat");

                    UpdateReult();
                }
                else
                {
                    Sys.Tool.KmeansCluster.classifications = (int[])Sys.Tool.Serialization.DeSerializeObject("classifications.dat");
                    this.updateGraph(Sys.Tool.KmeansCluster.classifications); //reset back to previous one
                  
                    Sys.Tool.KmeansCluster.ClusteredObjects = Sys.Tool.KmeansCluster.PreviousClusteredObjects;
                    //Reset Route container
                    Sys.Tool.KmeansCluster.Route = new Route();
                    Sys.Tool.KmeansCluster.Route.ClusterCount = this.ClusterCount;
                    Sys.Tool.KmeansCluster.Route = (Sys.Tool.Route)Sys.Tool.Serialization.DeSerializeObject("route.dat");


                    UpdateReult();
                }


                if (Sys.Tool.KmeansCluster.Route.IsReadyToDraw) Sys.Tool.KmeansCluster.Route.DrawRoutes(zgc);


                //Reset Route container
                Sys.Tool.KmeansCluster.Route = new Route();
                Sys.Tool.KmeansCluster.Route.ClusterCount = this.ClusterCount;



                System.Threading.Thread.Sleep(10);
                System.Windows.Forms.Application.DoEvents();


                }


            System.Threading.Thread.Sleep(1);
            System.Windows.Forms.Application.DoEvents();

            //if (Sys.Tool.KmeansCluster.RouteIterationCount == 10)
            //{                
               
            //}
          
            

            //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++



          
        }

        public void UpdateResultLabel(string message)
        {
            lblResult.Text = message;
            ProgressBar.Value += 1;

            lblSolution.Visible = true;
            lblSolution.Text = "Best solution: " + Sys.Tool.KmeansCluster.Route.TotalDistance.ToString() + " km, Load: " + Sys.Tool.KmeansCluster.Route.TotalLoadCapcity.ToString() + ", Total truck capacity: " + Sys.Tool.KmeansCluster.Route.TotalTruckCapacity.ToString() + ", Capacity usage percentage: " + Sys.Tool.KmeansCluster.Route.CapacityUsagePercentage.ToString() + "%";


            System.Threading.Thread.Sleep(0);
            System.Windows.Forms.Application.DoEvents();

 

            //string Distance;
            //string Load;
            //string Cap;
            //string CapPercent;

            //Distance = Sys.Tool.KmeansCluster.Route.TotalDistance.ToString();
            //Load = Sys.Tool.KmeansCluster.Route.TotalLoadCapcity.ToString();
            //Cap = Sys.Tool.KmeansCluster.Route.TotalTruckCapacity.ToString();
            //CapPercent = Sys.Tool.KmeansCluster.Route.CapacityUsagePercentage.ToString();


            // lblSolution.Text = "Best solution: " + Distance + " km, Load: " + Load + ", Total truck capacity: " + Cap +  ", Capacity usage percentage: " + CapPercent + "%";
        }
        private void UpdateReult()
        {

            string Message = "";
            try
            {
                

                if (Sys.Tool.KmeansCluster.RouteIterationCount < Sys.Tool.KmeansCluster.RouteIterationMax &&
                    Sys.Tool.KmeansCluster.Route.IsBetterSolution == false)
                {
                    Message = "Iteration: " + Sys.Tool.KmeansCluster.RouteIterationCount.ToString() + " , processing next iteration...";
                    if (InvokeRequired)
                    {
                        this.Invoke(new Action<string>(UpdateResultLabel), new object[] { Message });
                        return;
                    } else
                    {
                        lblResult.Text = Message;
                    }
                }

                if (Sys.Tool.KmeansCluster.RouteIterationCount < Sys.Tool.KmeansCluster.RouteIterationMax &&  
                    Sys.Tool.KmeansCluster.Route.IsBetterSolution)
                {
                    Message = "Iteration: " + Sys.Tool.KmeansCluster.RouteIterationCount.ToString() + " , current solution is better, processing next iteration...";
                    if (InvokeRequired)
                    {
                        this.Invoke(new Action<string>(UpdateResultLabel), new object[] { Message });
                        return;
                    }
                    else
                    {
                        lblResult.Text = Message;
                    }
                    
                }

                if (Sys.Tool.KmeansCluster.RouteIterationCount == Sys.Tool.KmeansCluster.RouteIterationMax)
                {
                    Message = "Iteration: " + Sys.Tool.KmeansCluster.RouteIterationCount.ToString() + ". Process is complete. The result below is the best solution.";
                    if (InvokeRequired)
                    {
                        this.Invoke(new Action<string>(UpdateResultLabel), new object[] { Message });
                        return;
                    }
                    else
                    {
                        lblResult.Text = Message;
                    }
                }
   
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        private void TopBorderPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isTopBorderPanelDragged = true;
            }
            else
            {
                isTopBorderPanelDragged = false;
            }
        }


        private void TopBorderPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Y < this.Location.Y)
            {
                if (isTopBorderPanelDragged)
                {
                    if (this.Height < 50)
                    {
                        this.Height = 50;
                        isTopBorderPanelDragged = false;
                    }
                    else
                    {
                        this.Location = new Point(this.Location.X, this.Location.Y + e.Y);
                        this.Height = this.Height - e.Y;
                    }
                }
            }
        }


        private void TopBorderPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isTopBorderPanelDragged = false;
        }



        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isTopPanelDragged = true;
                Point pointStartPosition = this.PointToScreen(new Point(e.X, e.Y));
                offset = new Point();
                offset.X = this.Location.X - pointStartPosition.X;
                offset.Y = this.Location.Y - pointStartPosition.Y;
            }
            else
            {
                isTopPanelDragged = false;
            }
            if (e.Clicks == 2)
            {
                isTopPanelDragged = false;
                MaxButton_MouseClick(sender, e);
            }
        }

        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isTopPanelDragged)
            {
                Point newPoint = TopPanel.PointToScreen(new Point(e.X, e.Y));
                newPoint.Offset(offset);
                this.Location = newPoint;

                if (this.Location.X > 2 || this.Location.Y > 2)
                {
                    if (this.WindowState == FormWindowState.Maximized)
                    {
                        this.Location = _normalWindowLocation;
                        this.Size = _normalWindowSize;
                        toolTip1.SetToolTip(MaxButton, "Maximize");
                        MaxButton.CFormState = MinMaxButton.CustomFormState.Normal;
                        isWindowMaximized = false;
                    }
                }
            }
        }


        private void TopPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isTopPanelDragged = false;
            if (this.Location.Y <= 5)
            {
                if (!isWindowMaximized)
                {
                    _normalWindowSize = this.Size;
                    _normalWindowLocation = this.Location;

                    Rectangle rect = Screen.PrimaryScreen.WorkingArea;
                    this.Location = new Point(0, 0);
                    this.Size = new System.Drawing.Size(rect.Width, rect.Height);
                    toolTip1.SetToolTip(MaxButton, "Restore Down");
                    MaxButton.CFormState = MinMaxButton.CustomFormState.Maximize;
                    isWindowMaximized = true;
                }
            }
        }



        private void LeftPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.Location.X <= 0 || e.X < 0)
            {
                isLeftPanelDragged = false;
                this.Location = new Point(10, this.Location.Y);
            }
            else
            {
                if (e.Button == MouseButtons.Left)
                {
                    isLeftPanelDragged = true;
                }
                else
                {
                    isLeftPanelDragged = false;
                }
            }
        }

        private void LeftPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X < this.Location.X)
            {
                if (isLeftPanelDragged)
                {
                    if (this.Width < 100)
                    {
                        this.Width = 100;
                        isLeftPanelDragged = false;
                    }
                    else
                    {
                        this.Location = new Point(this.Location.X + e.X, this.Location.Y);
                        this.Width = this.Width - e.X;
                    }
                }
            }
        }

        private void LeftPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isLeftPanelDragged = false;
        }



        private void RightPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isRightPanelDragged = true;
            }
            else
            {
                isRightPanelDragged = false;
            }
        }

        private void RightPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isRightPanelDragged)
            {
                if (this.Width < 100)
                {
                    this.Width = 100;
                    isRightPanelDragged = false;
                }
                else
                {
                    this.Width = this.Width + e.X;
                }
            }
        }

        private void RightPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isRightPanelDragged = false;
        }



        private void BottomPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isBottomPanelDragged = true;
            }
            else
            {
                isBottomPanelDragged = false;
            }
        }

        private void BottomPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isBottomPanelDragged)
            {
                if (this.Height < 50)
                {
                    this.Height = 50;
                    isBottomPanelDragged = false;
                }
                else
                {
                    this.Height = this.Height + e.Y;
                }
            }
        }

        private void BottomPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isBottomPanelDragged = false;
        }


        private void MinButton_MouseClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MaxButton_MouseClick(object sender, EventArgs e)
        {
            if (isWindowMaximized)
            {
                this.Location = _normalWindowLocation;
                this.Size = _normalWindowSize;
                toolTip1.SetToolTip(MaxButton, "Maximize");
                MaxButton.CFormState = MinMaxButton.CustomFormState.Normal;
                isWindowMaximized = false;
            }
            else
            {
                _normalWindowSize = this.Size;
                _normalWindowLocation = this.Location;

                Rectangle rect = Screen.PrimaryScreen.WorkingArea;
                this.Location = new Point(0, 0);
                this.Size = new System.Drawing.Size(rect.Width, rect.Height);
                toolTip1.SetToolTip(MaxButton, "Restore Down");
                MaxButton.CFormState = MinMaxButton.CustomFormState.Maximize;
                isWindowMaximized = true;
            }
        }

       



        private void RightBottomPanel_MouseDown(object sender, MouseEventArgs e)
        {
            isRightBottomPanelDragged = true;
        }

        private void RightBottomPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isRightBottomPanelDragged)
            {
                if (this.Width < 100 || this.Height < 50)
                {
                    this.Width = 100;
                    this.Height = 50;
                    isRightBottomPanelDragged = false;
                }
                else
                {
                    this.Width = this.Width + e.X;
                    this.Height = this.Height + e.Y;
                }
            }
        }


        private void RightBottomPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isRightBottomPanelDragged = false;
        }






        private void LeftBottomPanel_MouseDown(object sender, MouseEventArgs e)
        {
            isLeftBottomPanelDragged = true;
        }

        private void LeftBottomPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X < this.Location.X)
            {
                if (isLeftBottomPanelDragged || this.Height < 50)
                {
                    if (this.Width < 100)
                    {
                        this.Width = 100;
                        this.Height = 50;
                        isLeftBottomPanelDragged = false;
                    }
                    else
                    {
                        this.Location = new Point(this.Location.X + e.X, this.Location.Y);
                        this.Width = this.Width - e.X;
                        this.Height = this.Height + e.Y;
                    }
                }
            }
        }

        private void LeftBottomPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isLeftBottomPanelDragged = false;
        }



        private void RightTopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            isRightTopPanelDragged = true;
        }

        private void RightTopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Y < this.Location.Y || e.X < this.Location.X)
            {
                if (isRightTopPanelDragged)
                {
                    if (this.Height < 50 || this.Width < 100)
                    {
                        this.Height = 50;
                        this.Width = 100;
                        isRightTopPanelDragged = false;
                    }
                    else
                    {
                        this.Location = new Point(this.Location.X, this.Location.Y + e.Y);
                        this.Height = this.Height - e.Y;
                        this.Width = this.Width + e.X;
                    }
                }
            }
        }

        private void RightTopPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isRightTopPanelDragged = false;
        }






        private void LeftTopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            isLeftTopPanelDragged = true;
        }

        private void LeftTopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X < this.Location.X || e.Y < this.Location.Y)
            {
                if (isLeftTopPanelDragged)
                {
                    if (this.Width < 100 || this.Height < 50)
                    {
                        this.Width = 100;
                        this.Height = 100;
                        isLeftTopPanelDragged = false;
                    }
                    else
                    {
                        this.Location = new Point(this.Location.X + e.X, this.Location.Y);
                        this.Width = this.Width - e.X;
                        this.Location = new Point(this.Location.X, this.Location.Y + e.Y);
                        this.Height = this.Height - e.Y;
                    }
                }
            }

        }

        private void LeftTopPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isLeftTopPanelDragged = false;
        }









        private void file_button_Click(object sender, EventArgs e)
        {
            btnEntry.BZBackColor = Color.Black;
            btnEntry.ChangeColorMouseHC = false;
           // edit_button.BZBackColor = Color.FromArgb(60, 60, 60);
            btnView.BZBackColor = Color.FromArgb(60, 60, 60);
           // run_button.BZBackColor = Color.FromArgb(60, 60, 60);
            btnHelp.BZBackColor = Color.FromArgb(60, 60, 60);
          //  edit_button.ChangeColorMouseHC = true;
            btnView.ChangeColorMouseHC = true;
          //  run_button.ChangeColorMouseHC = true;
            btnHelp.ChangeColorMouseHC = true;
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
          //  edit_button.BZBackColor = Color.Black;
          //  edit_button.ChangeColorMouseHC = false;
            btnEntry.BZBackColor = Color.FromArgb(60, 60, 60);
            btnView.BZBackColor = Color.FromArgb(60, 60, 60);
          //  run_button.BZBackColor = Color.FromArgb(60, 60, 60);
            btnHelp.BZBackColor = Color.FromArgb(60, 60, 60);
            btnEntry.ChangeColorMouseHC = true;
            btnView.ChangeColorMouseHC = true;
          //  run_button.ChangeColorMouseHC = true;
            btnHelp.ChangeColorMouseHC = true;
        }

        private void view_button_Click(object sender, EventArgs e)
        {
            btnView.BZBackColor = Color.Black;
            btnView.ChangeColorMouseHC = false;
            btnEntry.BZBackColor = Color.FromArgb(60, 60, 60);
          //  edit_button.BZBackColor = Color.FromArgb(60, 60, 60);
          //  run_button.BZBackColor = Color.FromArgb(60, 60, 60);
            btnHelp.BZBackColor = Color.FromArgb(60, 60, 60);
            btnEntry.ChangeColorMouseHC = true;
          //  edit_button.ChangeColorMouseHC = true;
         //   run_button.ChangeColorMouseHC = true;
            btnHelp.ChangeColorMouseHC = true;
        }

        private void run_button_Click(object sender, EventArgs e)
        {
           // run_button.BZBackColor = Color.Black;
          //  run_button.ChangeColorMouseHC = false;
            btnEntry.BZBackColor = Color.FromArgb(60, 60, 60);
          //  edit_button.BZBackColor = Color.FromArgb(60, 60, 60);
            btnView.BZBackColor = Color.FromArgb(60, 60, 60);
            btnHelp.BZBackColor = Color.FromArgb(60, 60, 60);
            btnEntry.ChangeColorMouseHC = true;
           // edit_button.ChangeColorMouseHC = true;
            btnView.ChangeColorMouseHC = true;
            btnHelp.ChangeColorMouseHC = true;
        }

        private void help_button_Click(object sender, EventArgs e)
        {
            btnHelp.BZBackColor = Color.Black;
            btnHelp.ChangeColorMouseHC = false;
            btnEntry.BZBackColor = Color.FromArgb(60, 60, 60);
           // edit_button.BZBackColor = Color.FromArgb(60, 60, 60);
            btnView.BZBackColor = Color.FromArgb(60, 60, 60);
           // run_button.BZBackColor = Color.FromArgb(60, 60, 60);
            btnEntry.ChangeColorMouseHC = true;
           // edit_button.ChangeColorMouseHC = true;
            btnView.ChangeColorMouseHC = true;
          //  run_button.ChangeColorMouseHC = true;
        }






        private void WindowTextLabel_MouseDown(object sender, MouseEventArgs e)
        {
            TopPanel_MouseDown(sender, e);
        }

        private void WindowTextLabel_MouseMove(object sender, MouseEventArgs e)
        {
            TopPanel_MouseMove(sender, e);
        }

        private void WindowTextLabel_MouseUp(object sender, MouseEventArgs e)
        {
            TopPanel_MouseUp(sender, e);
        }


        private void BtnKMeans_Click(object sender, EventArgs e)
        {

           


            if (IsProcessStarted == false)
            {
                IsProcessStarted = true;

             
                //System.Threading.Thread.Sleep(0);
                System.Windows.Forms.Application.DoEvents();
                panelBlock.Visible = true;
                panelRight.Enabled = false;
                
                if (lblResult.Text.Trim() !="") Init();


                var worker = new BackgroundWorker();
                worker.DoWork += new DoWorkEventHandler(Start_Job);
                worker.RunWorkerCompleted += Worker_RunWorkerCompleted;

                worker.RunWorkerAsync();
            }
            
        }

       

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            IsProcessStarted = false;
            panelRight.Enabled = true;
            panelBlock.Visible = false;

   

        }

        void Start_Job(object sender, DoWorkEventArgs e)
        {
           

            int n = Sys.Tool.KmeansCluster.RouteIterationMax;
            for (int i = 0; i < n; i++)
            {
                //this.BeginInvoke(new Action<string>(StartProcess), new object[] { message };
                StartProcess("");
                System.Threading.Thread.Sleep(200);
                System.Windows.Forms.Application.DoEvents();

            }
            

        }
        private void BtnClose_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
        private void BtnGMM_Click(object sender, EventArgs e)
        {
            btnCompute_Click(sender, e);
        }

        private void btnEntry_Click(object sender, EventArgs e)
        {
            FormEntry Entry = new FormEntry();
            this.AddOwnedForm(Entry);
            Entry.ShowDialog(this);

            if (Sys.Tool.KmeansCluster.IsMapDataEdited)
            {
                //reset map
                Init();
            }
           

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            SummaryForm Summary = new SummaryForm();
            this.AddOwnedForm(Summary);
            Summary.ShowDialog(this);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            HelpForm Help = new HelpForm();
            this.AddOwnedForm(Help);
            Help.ShowDialog(this);
        }

      
    }
}
