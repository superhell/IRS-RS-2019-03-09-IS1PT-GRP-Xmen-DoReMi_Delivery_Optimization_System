namespace CustomWindowsForm
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelgraph = new System.Windows.Forms.Panel();
            this.mapgraph = new ZedGraph.ZedGraphControl();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.maproutegraph = new ZedGraph.ZedGraphControl();
            this.panelSide = new System.Windows.Forms.Panel();
            this.chkBWMap = new System.Windows.Forms.CheckBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtXY = new System.Windows.Forms.TextBox();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.txtPoint2 = new System.Windows.Forms.TextBox();
            this.txtPoint1 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelspace1 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.lbVersion = new System.Windows.Forms.Label();
            this.WindowTextLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.LeftTopPanel = new System.Windows.Forms.Panel();
            this.RightTopPanel = new System.Windows.Forms.Panel();
            this.LeftBottomPanel = new System.Windows.Forms.Panel();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.TopBorderPanel = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.RightBottomPanel = new System.Windows.Forms.Panel();
            this.help_button = new CustomWindowsForm.ButtonX();
            this.run_button = new CustomWindowsForm.ButtonX();
            this.view_button = new CustomWindowsForm.ButtonX();
            this.edit_button = new CustomWindowsForm.ButtonX();
            this.file_button = new CustomWindowsForm.ButtonX();
            this.HelpBtn = new CustomWindowsForm.ShapedButton();
            this.BtnGMM = new CustomWindowsForm.ShapedButton();
            this.btnReset = new CustomWindowsForm.ShapedButton();
            this.shapedButton1 = new CustomWindowsForm.ShapedButton();
            this.BtnKMeans = new CustomWindowsForm.ShapedButton();
            this.CloseBtn = new CustomWindowsForm.ShapedButton();
            this.MinButton = new CustomWindowsForm.ButtonZ();
            this.MaxButton = new CustomWindowsForm.MinMaxButton();
            this.CloseButton = new CustomWindowsForm.ButtonZ();
            this.panel1.SuspendLayout();
            this.panelgraph.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panelSide.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelspace1.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panelgraph);
            this.panel1.Controls.Add(this.panelSide);
            this.panel1.Controls.Add(this.panelRight);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.TopPanel);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.LeftTopPanel);
            this.panel1.Controls.Add(this.RightTopPanel);
            this.panel1.Controls.Add(this.LeftBottomPanel);
            this.panel1.Controls.Add(this.BottomPanel);
            this.panel1.Controls.Add(this.LeftPanel);
            this.panel1.Controls.Add(this.RightPanel);
            this.panel1.Controls.Add(this.TopBorderPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1400, 900);
            this.panel1.TabIndex = 0;
            // 
            // panelgraph
            // 
            this.panelgraph.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelgraph.Controls.Add(this.mapgraph);
            this.panelgraph.Controls.Add(this.panel9);
            this.panelgraph.Controls.Add(this.panel8);
            this.panelgraph.Controls.Add(this.maproutegraph);
            this.panelgraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelgraph.Location = new System.Drawing.Point(160, 64);
            this.panelgraph.Name = "panelgraph";
            this.panelgraph.Size = new System.Drawing.Size(1078, 762);
            this.panelgraph.TabIndex = 45;
            // 
            // mapgraph
            // 
            this.mapgraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapgraph.Location = new System.Drawing.Point(0, 35);
            this.mapgraph.Name = "mapgraph";
            this.mapgraph.ScrollGrace = 0D;
            this.mapgraph.ScrollMaxX = 0D;
            this.mapgraph.ScrollMaxY = 0D;
            this.mapgraph.ScrollMaxY2 = 0D;
            this.mapgraph.ScrollMinX = 0D;
            this.mapgraph.ScrollMinY = 0D;
            this.mapgraph.ScrollMinY2 = 0D;
            this.mapgraph.Size = new System.Drawing.Size(1076, 690);
            this.mapgraph.TabIndex = 23;
            this.mapgraph.UseExtendedPrintDialog = true;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.DarkGray;
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1076, 35);
            this.panel9.TabIndex = 22;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.DarkGray;
            this.panel8.Controls.Add(this.label3);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(0, 725);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1076, 35);
            this.panel8.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(11, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "Scale:  0.048647128049 units = 1km";
            // 
            // maproutegraph
            // 
            this.maproutegraph.Location = new System.Drawing.Point(22, 65);
            this.maproutegraph.Name = "maproutegraph";
            this.maproutegraph.ScrollGrace = 0D;
            this.maproutegraph.ScrollMaxX = 0D;
            this.maproutegraph.ScrollMaxY = 0D;
            this.maproutegraph.ScrollMaxY2 = 0D;
            this.maproutegraph.ScrollMinX = 0D;
            this.maproutegraph.ScrollMinY = 0D;
            this.maproutegraph.ScrollMinY2 = 0D;
            this.maproutegraph.Size = new System.Drawing.Size(1076, 690);
            this.maproutegraph.TabIndex = 24;
            this.maproutegraph.UseExtendedPrintDialog = true;
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelSide.Controls.Add(this.chkBWMap);
            this.panelSide.Controls.Add(this.panel6);
            this.panelSide.Controls.Add(this.txtPoint2);
            this.panelSide.Controls.Add(this.txtPoint1);
            this.panelSide.Controls.Add(this.panel4);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Location = new System.Drawing.Point(0, 64);
            this.panelSide.Name = "panelSide";
            this.panelSide.Padding = new System.Windows.Forms.Padding(4);
            this.panelSide.Size = new System.Drawing.Size(160, 762);
            this.panelSide.TabIndex = 42;
            // 
            // chkBWMap
            // 
            this.chkBWMap.AutoSize = true;
            this.chkBWMap.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chkBWMap.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBWMap.ForeColor = System.Drawing.Color.Silver;
            this.chkBWMap.Location = new System.Drawing.Point(4, 624);
            this.chkBWMap.Name = "chkBWMap";
            this.chkBWMap.Size = new System.Drawing.Size(152, 20);
            this.chkBWMap.TabIndex = 22;
            this.chkBWMap.Text = "Black &&  White Map";
            this.chkBWMap.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.txtXY);
            this.panel6.Controls.Add(this.txtFinal);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(4, 644);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(152, 114);
            this.panel6.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(8, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "Coordinates:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "Map Size:";
            // 
            // txtXY
            // 
            this.txtXY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtXY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtXY.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXY.ForeColor = System.Drawing.Color.Silver;
            this.txtXY.Location = new System.Drawing.Point(8, 33);
            this.txtXY.Name = "txtXY";
            this.txtXY.Size = new System.Drawing.Size(134, 15);
            this.txtXY.TabIndex = 26;
            // 
            // txtFinal
            // 
            this.txtFinal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtFinal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFinal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinal.ForeColor = System.Drawing.Color.Silver;
            this.txtFinal.Location = new System.Drawing.Point(8, 79);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(134, 15);
            this.txtFinal.TabIndex = 29;
            // 
            // txtPoint2
            // 
            this.txtPoint2.Location = new System.Drawing.Point(14, 345);
            this.txtPoint2.Name = "txtPoint2";
            this.txtPoint2.Size = new System.Drawing.Size(100, 20);
            this.txtPoint2.TabIndex = 28;
            this.txtPoint2.Visible = false;
            // 
            // txtPoint1
            // 
            this.txtPoint1.Location = new System.Drawing.Point(14, 319);
            this.txtPoint1.Name = "txtPoint1";
            this.txtPoint1.Size = new System.Drawing.Size(100, 20);
            this.txtPoint1.TabIndex = 27;
            this.txtPoint1.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(152, 109);
            this.panel4.TabIndex = 20;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.panelRight.Controls.Add(this.help_button);
            this.panelRight.Controls.Add(this.run_button);
            this.panelRight.Controls.Add(this.view_button);
            this.panelRight.Controls.Add(this.edit_button);
            this.panelRight.Controls.Add(this.file_button);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(1238, 64);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(160, 762);
            this.panelRight.TabIndex = 43;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.panel3.Controls.Add(this.panelspace1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 826);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1398, 72);
            this.panel3.TabIndex = 41;
            // 
            // panelspace1
            // 
            this.panelspace1.Controls.Add(this.HelpBtn);
            this.panelspace1.Controls.Add(this.panel10);
            this.panelspace1.Controls.Add(this.BtnGMM);
            this.panelspace1.Controls.Add(this.btnReset);
            this.panelspace1.Controls.Add(this.shapedButton1);
            this.panelspace1.Controls.Add(this.BtnKMeans);
            this.panelspace1.Controls.Add(this.CloseBtn);
            this.panelspace1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelspace1.Location = new System.Drawing.Point(0, 0);
            this.panelspace1.Name = "panelspace1";
            this.panelspace1.Padding = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.panelspace1.Size = new System.Drawing.Size(1398, 72);
            this.panelspace1.TabIndex = 12;
            // 
            // panel10
            // 
            this.panel10.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel10.Location = new System.Drawing.Point(735, 8);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(32, 56);
            this.panel10.TabIndex = 20;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.TopPanel.Controls.Add(this.lbVersion);
            this.TopPanel.Controls.Add(this.WindowTextLabel);
            this.TopPanel.Controls.Add(this.panel2);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1398, 64);
            this.TopPanel.TabIndex = 40;
            // 
            // lbVersion
            // 
            this.lbVersion.AutoSize = true;
            this.lbVersion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVersion.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbVersion.Location = new System.Drawing.Point(551, 27);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(73, 16);
            this.lbVersion.TabIndex = 21;
            this.lbVersion.Text = "Version 1.2";
            // 
            // WindowTextLabel
            // 
            this.WindowTextLabel.AutoSize = true;
            this.WindowTextLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindowTextLabel.ForeColor = System.Drawing.Color.White;
            this.WindowTextLabel.Location = new System.Drawing.Point(28, 21);
            this.WindowTextLabel.Name = "WindowTextLabel";
            this.WindowTextLabel.Size = new System.Drawing.Size(506, 24);
            this.WindowTextLabel.TabIndex = 1;
            this.WindowTextLabel.Text = "DoReMi Vehicle Route  Planner Management System";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1234, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(164, 64);
            this.panel2.TabIndex = 20;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.MinButton);
            this.panel5.Controls.Add(this.MaxButton);
            this.panel5.Controls.Add(this.CloseButton);
            this.panel5.Location = new System.Drawing.Point(16, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(148, 36);
            this.panel5.TabIndex = 8;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Location = new System.Drawing.Point(281, 77);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(2, 751);
            this.panel7.TabIndex = 39;
            // 
            // LeftTopPanel
            // 
            this.LeftTopPanel.BackColor = System.Drawing.Color.Black;
            this.LeftTopPanel.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.LeftTopPanel.Location = new System.Drawing.Point(-1, -1);
            this.LeftTopPanel.Name = "LeftTopPanel";
            this.LeftTopPanel.Size = new System.Drawing.Size(20, 2);
            this.LeftTopPanel.TabIndex = 38;
            // 
            // RightTopPanel
            // 
            this.RightTopPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RightTopPanel.BackColor = System.Drawing.Color.Black;
            this.RightTopPanel.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.RightTopPanel.Location = new System.Drawing.Point(1397, 1);
            this.RightTopPanel.Name = "RightTopPanel";
            this.RightTopPanel.Size = new System.Drawing.Size(2, 20);
            this.RightTopPanel.TabIndex = 37;
            // 
            // LeftBottomPanel
            // 
            this.LeftBottomPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LeftBottomPanel.BackColor = System.Drawing.Color.Black;
            this.LeftBottomPanel.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.LeftBottomPanel.Location = new System.Drawing.Point(-1, 897);
            this.LeftBottomPanel.Name = "LeftBottomPanel";
            this.LeftBottomPanel.Size = new System.Drawing.Size(15, 2);
            this.LeftBottomPanel.TabIndex = 36;
            // 
            // BottomPanel
            // 
            this.BottomPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BottomPanel.BackColor = System.Drawing.Color.Black;
            this.BottomPanel.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.BottomPanel.Location = new System.Drawing.Point(14, 897);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(1362, 2);
            this.BottomPanel.TabIndex = 33;
            // 
            // LeftPanel
            // 
            this.LeftPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LeftPanel.BackColor = System.Drawing.Color.Black;
            this.LeftPanel.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.LeftPanel.Location = new System.Drawing.Point(-1, 19);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(2, 857);
            this.LeftPanel.TabIndex = 32;
            // 
            // RightPanel
            // 
            this.RightPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RightPanel.BackColor = System.Drawing.Color.Black;
            this.RightPanel.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.RightPanel.Location = new System.Drawing.Point(1397, 21);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(2, 857);
            this.RightPanel.TabIndex = 31;
            // 
            // TopBorderPanel
            // 
            this.TopBorderPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TopBorderPanel.BackColor = System.Drawing.Color.Black;
            this.TopBorderPanel.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.TopBorderPanel.Location = new System.Drawing.Point(19, -1);
            this.TopBorderPanel.Name = "TopBorderPanel";
            this.TopBorderPanel.Size = new System.Drawing.Size(1360, 2);
            this.TopBorderPanel.TabIndex = 30;
            // 
            // RightBottomPanel
            // 
            this.RightBottomPanel.BackColor = System.Drawing.Color.Black;
            this.RightBottomPanel.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.RightBottomPanel.Location = new System.Drawing.Point(1579, 897);
            this.RightBottomPanel.Name = "RightBottomPanel";
            this.RightBottomPanel.Size = new System.Drawing.Size(19, 2);
            this.RightBottomPanel.TabIndex = 34;
            // 
            // help_button
            // 
            this.help_button.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.help_button.ChangeColorMouseHC = true;
            this.help_button.DisplayText = "Help";
            this.help_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.help_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.help_button.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.help_button.ForeColor = System.Drawing.Color.White;
            this.help_button.Location = new System.Drawing.Point(0, 140);
            this.help_button.MouseClickColor1 = System.Drawing.Color.Black;
            this.help_button.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.help_button.Name = "help_button";
            this.help_button.Size = new System.Drawing.Size(160, 35);
            this.help_button.TabIndex = 30;
            this.help_button.Text = "Help";
            this.help_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.help_button.TextLocation_X = 24;
            this.help_button.TextLocation_Y = 6;
            this.help_button.UseVisualStyleBackColor = true;
            // 
            // run_button
            // 
            this.run_button.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.run_button.ChangeColorMouseHC = true;
            this.run_button.DisplayText = "Run";
            this.run_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.run_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.run_button.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.run_button.ForeColor = System.Drawing.Color.White;
            this.run_button.Location = new System.Drawing.Point(0, 105);
            this.run_button.MouseClickColor1 = System.Drawing.Color.Black;
            this.run_button.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.run_button.Name = "run_button";
            this.run_button.Size = new System.Drawing.Size(160, 35);
            this.run_button.TabIndex = 29;
            this.run_button.Text = "Run";
            this.run_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.run_button.TextLocation_X = 24;
            this.run_button.TextLocation_Y = 6;
            this.run_button.UseVisualStyleBackColor = true;
            // 
            // view_button
            // 
            this.view_button.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.view_button.ChangeColorMouseHC = true;
            this.view_button.DisplayText = "View";
            this.view_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.view_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.view_button.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_button.ForeColor = System.Drawing.Color.White;
            this.view_button.Location = new System.Drawing.Point(0, 70);
            this.view_button.MouseClickColor1 = System.Drawing.Color.Black;
            this.view_button.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.view_button.Name = "view_button";
            this.view_button.Size = new System.Drawing.Size(160, 35);
            this.view_button.TabIndex = 28;
            this.view_button.Text = "View";
            this.view_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.view_button.TextLocation_X = 24;
            this.view_button.TextLocation_Y = 6;
            this.view_button.UseVisualStyleBackColor = true;
            // 
            // edit_button
            // 
            this.edit_button.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.edit_button.ChangeColorMouseHC = true;
            this.edit_button.DisplayText = "Edit";
            this.edit_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.edit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_button.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_button.ForeColor = System.Drawing.Color.White;
            this.edit_button.Location = new System.Drawing.Point(0, 35);
            this.edit_button.MouseClickColor1 = System.Drawing.Color.Black;
            this.edit_button.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(160, 35);
            this.edit_button.TabIndex = 27;
            this.edit_button.Text = "Edit";
            this.edit_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.edit_button.TextLocation_X = 24;
            this.edit_button.TextLocation_Y = 6;
            this.edit_button.UseVisualStyleBackColor = true;
            // 
            // file_button
            // 
            this.file_button.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.file_button.ChangeColorMouseHC = true;
            this.file_button.DisplayText = "File";
            this.file_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.file_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.file_button.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.file_button.ForeColor = System.Drawing.Color.White;
            this.file_button.Location = new System.Drawing.Point(0, 0);
            this.file_button.MouseClickColor1 = System.Drawing.Color.Black;
            this.file_button.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.file_button.Name = "file_button";
            this.file_button.Size = new System.Drawing.Size(160, 35);
            this.file_button.TabIndex = 26;
            this.file_button.Text = "File";
            this.file_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.file_button.TextLocation_X = 24;
            this.file_button.TextLocation_Y = 6;
            this.file_button.UseVisualStyleBackColor = true;
            // 
            // HelpBtn
            // 
            this.HelpBtn.BackColor = System.Drawing.Color.Transparent;
            this.HelpBtn.ButtonShape = CustomWindowsForm.ShapedButton.ButtonsShapes.RoundRect;
            this.HelpBtn.ButtonText = "Help";
            this.HelpBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.HelpBtn.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))));
            this.HelpBtn.FlatAppearance.BorderSize = 0;
            this.HelpBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.HelpBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.HelpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HelpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpBtn.ForeColor = System.Drawing.Color.White;
            this.HelpBtn.GradientAngle = 90;
            this.HelpBtn.Location = new System.Drawing.Point(590, 8);
            this.HelpBtn.MouseClickColor1 = System.Drawing.Color.Black;
            this.HelpBtn.MouseClickColor2 = System.Drawing.Color.Black;
            this.HelpBtn.MouseHoverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(30)))));
            this.HelpBtn.MouseHoverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(80)))));
            this.HelpBtn.Name = "HelpBtn";
            this.HelpBtn.ShowButtontext = true;
            this.HelpBtn.Size = new System.Drawing.Size(145, 56);
            this.HelpBtn.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(70)))), ((int)(((byte)(190)))));
            this.HelpBtn.TabIndex = 21;
            this.HelpBtn.Text = "HelpText";
            this.HelpBtn.TextLocation_X = 51;
            this.HelpBtn.TextLocation_Y = 18;
            this.HelpBtn.Transparent1 = 250;
            this.HelpBtn.Transparent2 = 250;
            this.HelpBtn.UseVisualStyleBackColor = false;
            // 
            // BtnGMM
            // 
            this.BtnGMM.BackColor = System.Drawing.Color.Transparent;
            this.BtnGMM.ButtonShape = CustomWindowsForm.ShapedButton.ButtonsShapes.RoundRect;
            this.BtnGMM.ButtonText = "Use Gaussian MM";
            this.BtnGMM.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnGMM.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BtnGMM.FlatAppearance.BorderSize = 0;
            this.BtnGMM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnGMM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnGMM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGMM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGMM.ForeColor = System.Drawing.Color.White;
            this.BtnGMM.GradientAngle = 90;
            this.BtnGMM.Location = new System.Drawing.Point(767, 8);
            this.BtnGMM.MouseClickColor1 = System.Drawing.Color.Black;
            this.BtnGMM.MouseClickColor2 = System.Drawing.Color.Black;
            this.BtnGMM.MouseHoverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnGMM.MouseHoverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnGMM.Name = "BtnGMM";
            this.BtnGMM.ShowButtontext = true;
            this.BtnGMM.Size = new System.Drawing.Size(200, 56);
            this.BtnGMM.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BtnGMM.TabIndex = 17;
            this.BtnGMM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGMM.TextLocation_X = 32;
            this.BtnGMM.TextLocation_Y = 18;
            this.BtnGMM.Transparent1 = 250;
            this.BtnGMM.Transparent2 = 250;
            this.BtnGMM.UseVisualStyleBackColor = false;
            this.BtnGMM.Visible = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.ButtonShape = CustomWindowsForm.ShapedButton.ButtonsShapes.RoundRect;
            this.btnReset.ButtonText = "Reset";
            this.btnReset.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnReset.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.GradientAngle = 90;
            this.btnReset.Location = new System.Drawing.Point(967, 8);
            this.btnReset.MouseClickColor1 = System.Drawing.Color.Black;
            this.btnReset.MouseClickColor2 = System.Drawing.Color.Black;
            this.btnReset.MouseHoverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnReset.MouseHoverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnReset.Name = "btnReset";
            this.btnReset.ShowButtontext = true;
            this.btnReset.Size = new System.Drawing.Size(136, 56);
            this.btnReset.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnReset.TabIndex = 16;
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.TextLocation_X = 44;
            this.btnReset.TextLocation_Y = 18;
            this.btnReset.Transparent1 = 250;
            this.btnReset.Transparent2 = 250;
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // shapedButton1
            // 
            this.shapedButton1.BackColor = System.Drawing.Color.Transparent;
            this.shapedButton1.ButtonShape = CustomWindowsForm.ShapedButton.ButtonsShapes.Circle;
            this.shapedButton1.ButtonText = "+";
            this.shapedButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.shapedButton1.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.shapedButton1.FlatAppearance.BorderSize = 0;
            this.shapedButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.shapedButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.shapedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shapedButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shapedButton1.ForeColor = System.Drawing.Color.White;
            this.shapedButton1.GradientAngle = 90;
            this.shapedButton1.Location = new System.Drawing.Point(3, 8);
            this.shapedButton1.MouseClickColor1 = System.Drawing.Color.Black;
            this.shapedButton1.MouseClickColor2 = System.Drawing.Color.Black;
            this.shapedButton1.MouseHoverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.shapedButton1.MouseHoverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.shapedButton1.Name = "shapedButton1";
            this.shapedButton1.ShowButtontext = true;
            this.shapedButton1.Size = new System.Drawing.Size(59, 56);
            this.shapedButton1.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.shapedButton1.TabIndex = 6;
            this.shapedButton1.TextLocation_X = 14;
            this.shapedButton1.TextLocation_Y = 7;
            this.shapedButton1.Transparent1 = 250;
            this.shapedButton1.Transparent2 = 250;
            this.shapedButton1.UseVisualStyleBackColor = false;
            // 
            // BtnKMeans
            // 
            this.BtnKMeans.BackColor = System.Drawing.Color.Transparent;
            this.BtnKMeans.ButtonShape = CustomWindowsForm.ShapedButton.ButtonsShapes.RoundRect;
            this.BtnKMeans.ButtonText = "Use K Means";
            this.BtnKMeans.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnKMeans.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BtnKMeans.FlatAppearance.BorderSize = 0;
            this.BtnKMeans.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnKMeans.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnKMeans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnKMeans.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnKMeans.ForeColor = System.Drawing.Color.White;
            this.BtnKMeans.GradientAngle = 90;
            this.BtnKMeans.Location = new System.Drawing.Point(1103, 8);
            this.BtnKMeans.MouseClickColor1 = System.Drawing.Color.Black;
            this.BtnKMeans.MouseClickColor2 = System.Drawing.Color.Black;
            this.BtnKMeans.MouseHoverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnKMeans.MouseHoverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnKMeans.Name = "BtnKMeans";
            this.BtnKMeans.ShowButtontext = true;
            this.BtnKMeans.Size = new System.Drawing.Size(156, 56);
            this.BtnKMeans.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BtnKMeans.TabIndex = 10;
            this.BtnKMeans.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnKMeans.TextLocation_X = 24;
            this.BtnKMeans.TextLocation_Y = 18;
            this.BtnKMeans.Transparent1 = 250;
            this.BtnKMeans.Transparent2 = 250;
            this.BtnKMeans.UseVisualStyleBackColor = false;
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.Transparent;
            this.CloseBtn.ButtonShape = CustomWindowsForm.ShapedButton.ButtonsShapes.RoundRect;
            this.CloseBtn.ButtonText = "Close";
            this.CloseBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseBtn.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CloseBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBtn.ForeColor = System.Drawing.Color.White;
            this.CloseBtn.GradientAngle = 90;
            this.CloseBtn.Location = new System.Drawing.Point(1259, 8);
            this.CloseBtn.MouseClickColor1 = System.Drawing.Color.Black;
            this.CloseBtn.MouseClickColor2 = System.Drawing.Color.Black;
            this.CloseBtn.MouseHoverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.CloseBtn.MouseHoverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.ShowButtontext = true;
            this.CloseBtn.Size = new System.Drawing.Size(136, 56);
            this.CloseBtn.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.CloseBtn.TabIndex = 9;
            this.CloseBtn.TextLocation_X = 44;
            this.CloseBtn.TextLocation_Y = 18;
            this.CloseBtn.Transparent1 = 250;
            this.CloseBtn.Transparent2 = 250;
            this.CloseBtn.UseVisualStyleBackColor = false;
            // 
            // MinButton
            // 
            this.MinButton.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.MinButton.DisplayText = "_";
            this.MinButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinButton.ForeColor = System.Drawing.Color.White;
            this.MinButton.Location = new System.Drawing.Point(55, 0);
            this.MinButton.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(160)))));
            this.MinButton.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.MinButton.Name = "MinButton";
            this.MinButton.Size = new System.Drawing.Size(31, 36);
            this.MinButton.TabIndex = 10;
            this.MinButton.Text = "_";
            this.MinButton.TextLocation_X = 6;
            this.MinButton.TextLocation_Y = -20;
            this.MinButton.UseVisualStyleBackColor = true;
            // 
            // MaxButton
            // 
            this.MaxButton.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.MaxButton.CFormState = CustomWindowsForm.MinMaxButton.CustomFormState.Normal;
            this.MaxButton.DisplayText = "_";
            this.MaxButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MaxButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaxButton.ForeColor = System.Drawing.Color.White;
            this.MaxButton.Location = new System.Drawing.Point(86, 0);
            this.MaxButton.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(160)))));
            this.MaxButton.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.MaxButton.Name = "MaxButton";
            this.MaxButton.Size = new System.Drawing.Size(31, 36);
            this.MaxButton.TabIndex = 9;
            this.MaxButton.Text = "minMaxButton1";
            this.MaxButton.TextLocation_X = 8;
            this.MaxButton.TextLocation_Y = 6;
            this.MaxButton.UseVisualStyleBackColor = true;
            // 
            // CloseButton
            // 
            this.CloseButton.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.CloseButton.DisplayText = "X";
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(117, 0);
            this.CloseButton.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(160)))));
            this.CloseButton.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(31, 36);
            this.CloseButton.TabIndex = 8;
            this.CloseButton.Text = "X";
            this.CloseButton.TextLocation_X = 6;
            this.CloseButton.TextLocation_Y = 1;
            this.CloseButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1400, 900);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panelgraph.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panelSide.ResumeLayout(false);
            this.panelSide.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panelspace1.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        // 
        // graph
        // 



        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelgraph;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panel3;
        private ShapedButton CloseBtn;
        private ShapedButton shapedButton1;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label WindowTextLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private ButtonZ MinButton;
        private MinMaxButton MaxButton;
        private ButtonZ CloseButton;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel LeftTopPanel;
        private System.Windows.Forms.Panel RightTopPanel;
        private System.Windows.Forms.Panel LeftBottomPanel;
        private System.Windows.Forms.Panel RightBottomPanel;
        private System.Windows.Forms.Panel RightBottomPanel_1;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Panel RightPanel;
        private System.Windows.Forms.Panel TopBorderPanel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtXY;
        private System.Windows.Forms.TextBox txtPoint1;
        private System.Windows.Forms.TextBox txtPoint2;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.Panel panel8;
        private ZedGraph.ZedGraphControl mapgraph;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panelspace1;
        private ShapedButton BtnKMeans;
        private ZedGraph.ZedGraphControl maproutegraph;
        private System.Windows.Forms.Label lbVersion;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label3;
        private ShapedButton BtnGMM;
        private ShapedButton btnReset;
        private ShapedButton HelpBtn;
        private System.Windows.Forms.Panel panel10;
        private ButtonX help_button;
        private ButtonX run_button;
        private ButtonX view_button;
        private ButtonX edit_button;
        private ButtonX file_button;
        private System.Windows.Forms.CheckBox chkBWMap;
    }
}