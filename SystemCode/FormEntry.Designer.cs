namespace DoReMiVRP
{
    partial class FormEntry
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEntry));
            this.EntryList = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbXYDisplay = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRestore = new DoReMiVRP.ShapedButton();
            this.btnUpdateXY = new DoReMiVRP.ShapedButton();
            this.btnSave = new DoReMiVRP.ShapedButton();
            this.btnClose = new DoReMiVRP.ShapedButton();
            ((System.ComponentModel.ISupportInitialize)(this.EntryList)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.cmdPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // EntryList
            // 
            this.EntryList.AllowUserToResizeColumns = false;
            this.EntryList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.EntryList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.EntryList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EntryList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.EntryList.ColumnHeadersHeight = 30;
            this.EntryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EntryList.DefaultCellStyle = dataGridViewCellStyle3;
            this.EntryList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EntryList.Location = new System.Drawing.Point(10, 10);
            this.EntryList.Margin = new System.Windows.Forms.Padding(2);
            this.EntryList.Name = "EntryList";
            this.EntryList.RowTemplate.Height = 24;
            this.EntryList.Size = new System.Drawing.Size(696, 435);
            this.EntryList.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.panel4);
            this.panel6.Controls.Add(this.panel3);
            this.panel6.Controls.Add(this.TopPanel);
            this.panel6.Controls.Add(this.cmdPanel);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(718, 625);
            this.panel6.TabIndex = 26;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.EntryList);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 53);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10);
            this.panel4.Size = new System.Drawing.Size(716, 455);
            this.panel4.TabIndex = 24;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.lbXYDisplay);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lblInfo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 508);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(716, 48);
            this.panel3.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label3.Location = new System.Drawing.Point(7, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(303, 18);
            this.label3.TabIndex = 35;
            this.label3.Text = "Current Selected Map\'s XY Coorindates : ";
            // 
            // lbXYDisplay
            // 
            this.lbXYDisplay.AutoSize = true;
            this.lbXYDisplay.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbXYDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lbXYDisplay.Location = new System.Drawing.Point(313, 24);
            this.lbXYDisplay.Name = "lbXYDisplay";
            this.lbXYDisplay.Size = new System.Drawing.Size(40, 18);
            this.lbXYDisplay.TabIndex = 34;
            this.lbXYDisplay.Text = "        ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(482, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "Min Order Qty: 100, Max order Qty: 500";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblInfo.Location = new System.Drawing.Point(1, 1);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(106, 19);
            this.lblInfo.TabIndex = 31;
            this.lblInfo.Text = "Information :";
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.TopPanel.Controls.Add(this.label1);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(716, 60);
            this.TopPanel.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(24, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 24);
            this.label1.TabIndex = 30;
            this.label1.Text = "City Order Entry";
            // 
            // cmdPanel
            // 
            this.cmdPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.cmdPanel.Controls.Add(this.btnRestore);
            this.cmdPanel.Controls.Add(this.btnUpdateXY);
            this.cmdPanel.Controls.Add(this.btnSave);
            this.cmdPanel.Controls.Add(this.panel2);
            this.cmdPanel.Controls.Add(this.btnClose);
            this.cmdPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cmdPanel.Location = new System.Drawing.Point(0, 556);
            this.cmdPanel.Name = "cmdPanel";
            this.cmdPanel.Padding = new System.Windows.Forms.Padding(6);
            this.cmdPanel.Size = new System.Drawing.Size(716, 67);
            this.cmdPanel.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(580, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(20, 55);
            this.panel2.TabIndex = 27;
            // 
            // btnRestore
            // 
            this.btnRestore.BackColor = System.Drawing.Color.Transparent;
            this.btnRestore.ButtonShape = DoReMiVRP.ShapedButton.ButtonsShapes.RoundRect;
            this.btnRestore.ButtonText = "Restore";
            this.btnRestore.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRestore.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnRestore.FlatAppearance.BorderSize = 0;
            this.btnRestore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRestore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestore.ForeColor = System.Drawing.Color.White;
            this.btnRestore.GradientAngle = 90;
            this.btnRestore.Location = new System.Drawing.Point(114, 6);
            this.btnRestore.MouseClickColor1 = System.Drawing.Color.Black;
            this.btnRestore.MouseClickColor2 = System.Drawing.Color.Black;
            this.btnRestore.MouseHoverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnRestore.MouseHoverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.ShowButtontext = true;
            this.btnRestore.Size = new System.Drawing.Size(110, 55);
            this.btnRestore.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnRestore.TabIndex = 30;
            this.btnRestore.TextLocation_X = 26;
            this.btnRestore.TextLocation_Y = 18;
            this.btnRestore.Transparent1 = 250;
            this.btnRestore.Transparent2 = 250;
            this.btnRestore.UseVisualStyleBackColor = false;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnUpdateXY
            // 
            this.btnUpdateXY.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateXY.ButtonShape = DoReMiVRP.ShapedButton.ButtonsShapes.RoundRect;
            this.btnUpdateXY.ButtonText = "Update Coordinates";
            this.btnUpdateXY.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnUpdateXY.EndColor = System.Drawing.Color.SteelBlue;
            this.btnUpdateXY.FlatAppearance.BorderSize = 0;
            this.btnUpdateXY.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnUpdateXY.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnUpdateXY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateXY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateXY.ForeColor = System.Drawing.Color.White;
            this.btnUpdateXY.GradientAngle = 90;
            this.btnUpdateXY.Location = new System.Drawing.Point(224, 6);
            this.btnUpdateXY.MouseClickColor1 = System.Drawing.Color.Black;
            this.btnUpdateXY.MouseClickColor2 = System.Drawing.Color.Black;
            this.btnUpdateXY.MouseHoverColor1 = System.Drawing.Color.SteelBlue;
            this.btnUpdateXY.MouseHoverColor2 = System.Drawing.Color.SteelBlue;
            this.btnUpdateXY.Name = "btnUpdateXY";
            this.btnUpdateXY.ShowButtontext = true;
            this.btnUpdateXY.Size = new System.Drawing.Size(204, 55);
            this.btnUpdateXY.StartColor = System.Drawing.Color.SteelBlue;
            this.btnUpdateXY.TabIndex = 29;
            this.btnUpdateXY.TextLocation_X = 32;
            this.btnUpdateXY.TextLocation_Y = 18;
            this.btnUpdateXY.Transparent1 = 250;
            this.btnUpdateXY.Transparent2 = 250;
            this.btnUpdateXY.UseVisualStyleBackColor = false;
            this.btnUpdateXY.Click += new System.EventHandler(this.btnUpdateXY_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.ButtonShape = DoReMiVRP.ShapedButton.ButtonsShapes.RoundRect;
            this.btnSave.ButtonText = "Save Entry";
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSave.EndColor = System.Drawing.Color.DarkGreen;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.GradientAngle = 90;
            this.btnSave.Location = new System.Drawing.Point(428, 6);
            this.btnSave.MouseClickColor1 = System.Drawing.Color.Black;
            this.btnSave.MouseClickColor2 = System.Drawing.Color.Black;
            this.btnSave.MouseHoverColor1 = System.Drawing.Color.DarkGreen;
            this.btnSave.MouseHoverColor2 = System.Drawing.Color.DarkGreen;
            this.btnSave.Name = "btnSave";
            this.btnSave.ShowButtontext = true;
            this.btnSave.Size = new System.Drawing.Size(152, 55);
            this.btnSave.StartColor = System.Drawing.Color.DarkGreen;
            this.btnSave.TabIndex = 28;
            this.btnSave.TextLocation_X = 32;
            this.btnSave.TextLocation_Y = 18;
            this.btnSave.Transparent1 = 250;
            this.btnSave.Transparent2 = 250;
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.ButtonShape = DoReMiVRP.ShapedButton.ButtonsShapes.RoundRect;
            this.btnClose.ButtonText = "Close";
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.GradientAngle = 90;
            this.btnClose.Location = new System.Drawing.Point(600, 6);
            this.btnClose.MouseClickColor1 = System.Drawing.Color.Black;
            this.btnClose.MouseClickColor2 = System.Drawing.Color.Black;
            this.btnClose.MouseHoverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnClose.MouseHoverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnClose.Name = "btnClose";
            this.btnClose.ShowButtontext = true;
            this.btnClose.Size = new System.Drawing.Size(110, 55);
            this.btnClose.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnClose.TabIndex = 10;
            this.btnClose.TextLocation_X = 32;
            this.btnClose.TextLocation_Y = 18;
            this.btnClose.Transparent1 = 250;
            this.btnClose.Transparent2 = 250;
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // FormEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 625);
            this.ControlBox = false;
            this.Controls.Add(this.panel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormEntry";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormEntry";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormEntry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EntryList)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.cmdPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView EntryList;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel cmdPanel;
        private System.Windows.Forms.Label label1;
        private DoReMiVRP.ShapedButton btnClose;
        private DoReMiVRP.ShapedButton btnSave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        internal System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Panel panel4;
        internal System.Windows.Forms.Label label2;
        private ShapedButton btnUpdateXY;
        internal System.Windows.Forms.Label lbXYDisplay;
        internal System.Windows.Forms.Label label3;
        private ShapedButton btnRestore;
    }
}