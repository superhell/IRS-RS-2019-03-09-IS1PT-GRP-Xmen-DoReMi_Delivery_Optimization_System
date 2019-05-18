using CsvHelper;
using Sys.Tool;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoReMiVRP
{
    public partial class SummaryForm : Form
    {
        

        public SummaryForm()
        {
            InitializeComponent();
            this.MaximizeBox = false;
          
        }

        private void FormEntry_Load(object sender, EventArgs e)
        {
            txtResult.Text = "";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            ShowResult();
           
        }

        private void ShowResult()
        {
            string Message = "";
            System.Text.StringBuilder sb;
            int i = 1;
            int TotalQuantity = 0;

            foreach (var obj in Sys.Tool.KmeansCluster.Routes)
            {
                sb = new System.Text.StringBuilder();
               
                Route item = (Route)obj.Value;
                sb.Append ("Route group " + i.ToString() + ":\n" + "Total distance for all routes: "+item.TotalDistance.ToString() + "km, Total load capacity: " + item.TotalLoadCapcity.ToString() + "\n");
                sb.Append("Total capacity of all assigned trucks: " + item.TotalTruckCapacity.ToString() + ", Capacity usage percentage: " + item.CapacityUsagePercentage.ToString() + "%\n" );
                sb.Append("********************************************************\n");

                txtResult.Text += sb.ToString();
                SortedDictionary<double, RouteData> data = (SortedDictionary<double, RouteData>)item.Data;
                i += 1;

                //foreach(var o in data)
                //{
                //    RouteData _routedata = (RouteData)o.Value;
                //     foreach(var item2 in (ArrayList ) _routedata.Truck.Route)
                //    {
                //        ClusterData d = (ClusterData)item2;
                //        TotalQuantity += (int)d.Quantity;
                //    }
                   
                //}

            }
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}