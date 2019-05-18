using CsvHelper;
using System;
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
    public partial class FormEntry : Form
    {
        private List<CityItem> result = null;
        private String FileName = @"iowa_map.txt";
        private string OriginalFile = @"iowa_map.bak";
        private bool isTopPanelDragged = false;
        Point offset;
        Point _normalWindowLocation = Point.Empty;

        public FormEntry()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.EntryList.CellValidating += new
            DataGridViewCellValidatingEventHandler(dataGridView1_CellValidating);
            this.EntryList.CellEndEdit += new
                DataGridViewCellEventHandler(dataGridView1_CellEndEdit);

            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            this.TopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseUp);
        }

        private void FormEntry_Load(object sender, EventArgs e)
        {
            
            btnUpdateXY.Visible = (DoReMiVRP.CityLocation.X != 0 && DoReMiVRP.CityLocation.Y != 0);
            if (DoReMiVRP.CityLocation.X != 0 && DoReMiVRP.CityLocation.Y != 0)
            {
                lbXYDisplay.Text = DoReMiVRP.CityLocation.X.ToString() + ", " + DoReMiVRP.CityLocation.Y.ToString();
            }

            SetupGridview();

            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
           
        }

        private void SetupGridview()
        {
            result = LoadCsvFile(FileName);
            this.lblInfo.Text = "";


            this.EntryList.DataSource = result;
            this.EntryList.Columns[0].ReadOnly = true;
            this.EntryList.Columns[1].ReadOnly = true;
            this.EntryList.Columns[2].ReadOnly = true;

            this.EntryList.Columns[1].Visible = true;
            this.EntryList.Columns[2].Visible = true;

            this.EntryList.Columns[0].Width = 300;
            this.EntryList.Columns[3].Width = 73;
            this.EntryList.Refresh();
        }

        private List<CityItem> LoadCsvFile(String filePath)
        {
            var records = new List<CityItem>();
            using (var reader = new StreamReader(FileName))
            using (var csv = new CsvReader(reader))
            {
                csv.Read();
                csv.ReadHeader();
                while (csv.Read())
                {
                    var record = new CityItem
                    {
                        City = csv.GetField<String>(0),
                        X = csv.GetField<float>(1),
                        Y = csv.GetField<float>(2),
                        Order = csv.GetField<int>(3),
                    };
                    records.Add(record);
                }
            }
            return records;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
          
            

            UpdateMessage("Saving city orders...");
            System.Windows.Forms.Application.DoEvents();
            System.Threading.Thread.Sleep(500);
           
            cmdPanel.Enabled = false;
            try
            {
                using (var writer = new StreamWriter(FileName))
                using (var csv = new CsvWriter(writer))
                {
                    csv.WriteRecords(result);
                }

                Sys.Tool.KmeansCluster.IsMapDataEdited = true;
                UpdateMessage("City orders successfully saved. Map will be reset.");
                System.Threading.Thread.Sleep(200);
                System.Windows.Forms.Application.DoEvents();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { btnSave.Enabled = true; cmdPanel.Enabled=true; }
            System.Threading.Thread.Sleep(500);

        }

        private void UpdateInfoLabel(string Message)
        {
            lblInfo.Text = Message;
        }

        private void UpdateMessage(string Message)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(UpdateInfoLabel), new object[] { Message });
                return;
            }
            else
            {
                lblInfo.Text = Message;
            }
        }


        private void dataGridView1_CellValidating(object sender,
        DataGridViewCellValidatingEventArgs e)
        {
            string headerText =
                EntryList.Columns[e.ColumnIndex].HeaderText;

            // Abort validation if cell is not in the CompanyName column.
            if (!headerText.Equals("Order")) return;

            String content = e.FormattedValue.ToString();
            // Confirm that the cell is not empty.
            if (string.IsNullOrEmpty(content))
            {
                EntryList.Rows[e.RowIndex].ErrorText =
                    "Order can not be empty";
                e.Cancel = true;
                return;
            }
            int weight = -1;

            bool bIsOk = Int32.TryParse(content, out weight);
            if (!bIsOk)
            {
                EntryList.Rows[e.RowIndex].ErrorText =
                     "value of order is not int";
                e.Cancel = true;
                return;
            }

            if (weight < 0)
            {
                EntryList.Rows[e.RowIndex].ErrorText =
              "value of order can not be negative";
                e.Cancel = true;
                return;
            }

            if (weight > 500)
            {
                EntryList.Rows[e.RowIndex].ErrorText =
              "maximum value of order is 500";
                e.Cancel = true;
                return;
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Clear the row error in case the user presses ESC.
            EntryList.Rows[e.RowIndex].ErrorText = String.Empty;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdateXY_Click(object sender, EventArgs e)
        {
            //DoReMiVRP.Program.App.txtse
            result = (List<DoReMiVRP.CityItem>)this.EntryList.DataSource;

            //Debug print test
            //string c = result[this.EntryList.CurrentCell.RowIndex].City;
            //string x = result[this.EntryList.CurrentCell.RowIndex].X.ToString();
            //string y = result[this.EntryList.CurrentCell.RowIndex].Y.ToString();
            //lbXYDisplay.Text = c + ", " + x + ", " + y;

            //Update the selected row with the current selected screen map's location point
            result[this.EntryList.CurrentCell.RowIndex].X = DoReMiVRP.CityLocation.X;
            result[this.EntryList.CurrentCell.RowIndex].Y = DoReMiVRP.CityLocation.Y;
            this.EntryList.DataSource = result;
            this.EntryList.Refresh();
            DoReMiVRP.CityLocation.IsUtilized = true;
            DoReMiVRP.CityLocation.X = 0;
            DoReMiVRP.CityLocation.Y = 0;
            btnUpdateXY.Visible = false;

            btnSave_Click(btnUpdateXY, null);

        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            System.IO.File.Copy(OriginalFile, FileName, true);
            SetupGridview();
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
 
                    }
                }
            }
        }


        private void TopPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isTopPanelDragged = false;
            if (this.Location.Y <= 5)
            {
                
            }
        }
    }
}