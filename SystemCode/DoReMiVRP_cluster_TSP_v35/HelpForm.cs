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
    public partial class HelpForm : Form
    {
        

        public HelpForm()
        {
            InitializeComponent();
            this.MaximizeBox = false;
          
        }

        private void FormEntry_Load(object sender, EventArgs e)
        {
           
          

           

            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
           
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}