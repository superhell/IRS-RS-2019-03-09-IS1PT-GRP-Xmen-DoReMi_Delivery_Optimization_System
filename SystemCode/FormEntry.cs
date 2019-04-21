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

        public FormEntry()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.EntryList.CellValidating += new
            DataGridViewCellValidatingEventHandler(dataGridView1_CellValidating);
            this.EntryList.CellEndEdit += new
                DataGridViewCellEventHandler(dataGridView1_CellEndEdit);
        }

        private void FormEntry_Load(object sender, EventArgs e)
        {
            result = LoadCsvFile(FileName);
            this.lblInfo.Text = "";

            this.EntryList.DataSource = result;
            this.EntryList.Columns[0].ReadOnly = true;
            this.EntryList.Columns[1].ReadOnly = true;
            this.EntryList.Columns[2].ReadOnly = true;

            this.EntryList.Columns[1].Visible = false;
            this.EntryList.Columns[2].Visible = false;

            this.EntryList.Columns[0].Width = 300;
            this.EntryList.Columns[3].Width = 73;

            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
           
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
                        X = csv.GetField<double>(1),
                        Y = csv.GetField<double>(2),
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
    }
}