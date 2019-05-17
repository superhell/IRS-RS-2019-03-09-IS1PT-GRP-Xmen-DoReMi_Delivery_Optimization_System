namespace DoReMiVRP
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
            this.panel13 = new System.Windows.Forms.Panel();
            this.lblSolution = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.lblResult = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.maproutegraph = new ZedGraph.ZedGraphControl();
            this.panelSide = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cboClusterSize = new System.Windows.Forms.ComboBox();
            this.chkBWMap = new System.Windows.Forms.CheckBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSetCoordinates = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtXY = new System.Windows.Forms.TextBox();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.txtPoint2 = new System.Windows.Forms.TextBox();
            this.txtPoint1 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.btnHelp = new DoReMiVRP.ButtonX();
            this.btnView = new DoReMiVRP.ButtonX();
            this.btnEntry = new DoReMiVRP.ButtonX();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelspace = new System.Windows.Forms.Panel();
            this.panelBlock = new System.Windows.Forms.Panel();
            this.btnReset = new DoReMiVRP.ShapedButton();
            this.BtnKMeans = new DoReMiVRP.ShapedButton();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnClose = new DoReMiVRP.ShapedButton();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.lbVersion = new System.Windows.Forms.Label();
            this.WindowTextLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.MinButton = new DoReMiVRP.ButtonZ();
            this.MaxButton = new DoReMiVRP.MinMaxButton();
            this.CloseButton = new DoReMiVRP.ButtonZ();
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
            this.buttonZ2 = new DoReMiVRP.ButtonZ();
            this.panel1.SuspendLayout();
            this.panelgraph.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panelSide.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelspace.SuspendLayout();
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
            this.mapgraph.Location = new System.Drawing.Point(0, 67);
            this.mapgraph.Name = "mapgraph";
            this.mapgraph.ScrollGrace = 0D;
            this.mapgraph.ScrollMaxX = 0D;
            this.mapgraph.ScrollMaxY = 0D;
            this.mapgraph.ScrollMaxY2 = 0D;
            this.mapgraph.ScrollMinX = 0D;
            this.mapgraph.ScrollMinY = 0D;
            this.mapgraph.ScrollMinY2 = 0D;
            this.mapgraph.Size = new System.Drawing.Size(1076, 658);
            this.mapgraph.TabIndex = 23;
            this.mapgraph.UseExtendedPrintDialog = true;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(212)))), ((int)(((byte)(236)))));
            this.panel9.Controls.Add(this.panel13);
            this.panel9.Controls.Add(this.panel12);
            this.panel9.Controls.Add(this.lblResult);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1076, 67);
            this.panel9.TabIndex = 22;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(212)))), ((int)(((byte)(236)))));
            this.panel13.Controls.Add(this.lblSolution);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel13.Location = new System.Drawing.Point(0, 32);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(1076, 30);
            this.panel13.TabIndex = 38;
            // 
            // lblSolution
            // 
            this.lblSolution.AutoSize = true;
            this.lblSolution.BackColor = System.Drawing.Color.Transparent;
            this.lblSolution.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolution.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.lblSolution.Location = new System.Drawing.Point(14, 6);
            this.lblSolution.Name = "lblSolution";
            this.lblSolution.Size = new System.Drawing.Size(68, 18);
            this.lblSolution.TabIndex = 31;
            this.lblSolution.Text = "Solution:";
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.ProgressBar);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel12.Location = new System.Drawing.Point(0, 62);
            this.panel12.Margin = new System.Windows.Forms.Padding(1);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1076, 5);
            this.panel12.TabIndex = 36;
            // 
            // ProgressBar
            // 
            this.ProgressBar.BackColor = System.Drawing.Color.DarkGray;
            this.ProgressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ProgressBar.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.ProgressBar.Location = new System.Drawing.Point(0, 1);
            this.ProgressBar.Margin = new System.Windows.Forms.Padding(0);
            this.ProgressBar.MarqueeAnimationSpeed = 0;
            this.ProgressBar.Maximum = 10;
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(1076, 4);
            this.ProgressBar.Step = 1;
            this.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ProgressBar.TabIndex = 32;
            this.toolTip1.SetToolTip(this.ProgressBar, "Iteration progress...");
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.lblResult.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblResult.Location = new System.Drawing.Point(14, 7);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(59, 18);
            this.lblResult.TabIndex = 30;
            this.lblResult.Text = "Result: ";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(212)))), ((int)(((byte)(236)))));
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
            this.panelSide.Controls.Add(this.panel11);
            this.panelSide.Controls.Add(this.chkBWMap);
            this.panelSide.Controls.Add(this.panel6);
            this.panelSide.Controls.Add(this.txtPoint2);
            this.panelSide.Controls.Add(this.txtPoint1);
            this.panelSide.Controls.Add(this.panel4);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Location = new System.Drawing.Point(0, 64);
            this.panelSide.Name = "panelSide";
            this.panelSide.Padding = new System.Windows.Forms.Padding(6);
            this.panelSide.Size = new System.Drawing.Size(160, 762);
            this.panelSide.TabIndex = 42;
            // 
            // panel11
            // 
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel11.Controls.Add(this.label4);
            this.panel11.Controls.Add(this.cboClusterSize);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel11.Location = new System.Drawing.Point(6, 520);
            this.panel11.Name = "panel11";
            this.panel11.Padding = new System.Windows.Forms.Padding(4, 4, 4, 16);
            this.panel11.Size = new System.Drawing.Size(148, 67);
            this.panel11.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(4, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "No. of Route Clusters:";
            // 
            // cboClusterSize
            // 
            this.cboClusterSize.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cboClusterSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClusterSize.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboClusterSize.FormattingEnabled = true;
            this.cboClusterSize.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5"});
            this.cboClusterSize.Location = new System.Drawing.Point(4, 24);
            this.cboClusterSize.Name = "cboClusterSize";
            this.cboClusterSize.Size = new System.Drawing.Size(138, 25);
            this.cboClusterSize.TabIndex = 31;
            // 
            // chkBWMap
            // 
            this.chkBWMap.AutoSize = true;
            this.chkBWMap.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chkBWMap.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBWMap.ForeColor = System.Drawing.Color.Silver;
            this.chkBWMap.Location = new System.Drawing.Point(6, 587);
            this.chkBWMap.Name = "chkBWMap";
            this.chkBWMap.Size = new System.Drawing.Size(148, 20);
            this.chkBWMap.TabIndex = 22;
            this.chkBWMap.Text = "Black &&  White Map";
            this.chkBWMap.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.txtSetCoordinates);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.txtXY);
            this.panel6.Controls.Add(this.txtFinal);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(6, 607);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(148, 149);
            this.panel6.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(10, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 33;
            this.label6.Text = "Coordinates:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(9, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "Selected Map\'s";
            // 
            // txtSetCoordinates
            // 
            this.txtSetCoordinates.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSetCoordinates.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSetCoordinates.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSetCoordinates.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtSetCoordinates.Location = new System.Drawing.Point(9, 126);
            this.txtSetCoordinates.Name = "txtSetCoordinates";
            this.txtSetCoordinates.ReadOnly = true;
            this.txtSetCoordinates.Size = new System.Drawing.Size(134, 15);
            this.txtSetCoordinates.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(8, 45);
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
            this.label1.Location = new System.Drawing.Point(8, 5);
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
            this.txtXY.Location = new System.Drawing.Point(8, 27);
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
            this.txtFinal.Location = new System.Drawing.Point(8, 66);
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
            this.panel4.Location = new System.Drawing.Point(6, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(148, 109);
            this.panel4.TabIndex = 20;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.panelRight.Controls.Add(this.btnHelp);
            this.panelRight.Controls.Add(this.btnView);
            this.panelRight.Controls.Add(this.btnEntry);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(1238, 64);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(160, 762);
            this.panelRight.TabIndex = 43;
            // 
            // btnHelp
            // 
            this.btnHelp.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnHelp.ChangeColorMouseHC = true;
            this.btnHelp.DisplayText = "Help";
            this.btnHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.White;
            this.btnHelp.Location = new System.Drawing.Point(0, 70);
            this.btnHelp.MouseClickColor1 = System.Drawing.Color.Black;
            this.btnHelp.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(160, 35);
            this.btnHelp.TabIndex = 31;
            this.btnHelp.Text = "Help";
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.TextLocation_X = 24;
            this.btnHelp.TextLocation_Y = 6;
            this.btnHelp.UseVisualStyleBackColor = true;
            // 
            // btnView
            // 
            this.btnView.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnView.ChangeColorMouseHC = true;
            this.btnView.DisplayText = "Summary";
            this.btnView.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.Color.White;
            this.btnView.Location = new System.Drawing.Point(0, 35);
            this.btnView.MouseClickColor1 = System.Drawing.Color.Black;
            this.btnView.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(160, 35);
            this.btnView.TabIndex = 29;
            this.btnView.Text = "Summary";
            this.btnView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnView.TextLocation_X = 24;
            this.btnView.TextLocation_Y = 6;
            this.btnView.UseVisualStyleBackColor = true;
            // 
            // btnEntry
            // 
            this.btnEntry.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnEntry.ChangeColorMouseHC = true;
            this.btnEntry.DisplayText = "Order Entry";
            this.btnEntry.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntry.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntry.ForeColor = System.Drawing.Color.White;
            this.btnEntry.Location = new System.Drawing.Point(0, 0);
            this.btnEntry.MouseClickColor1 = System.Drawing.Color.Black;
            this.btnEntry.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnEntry.Name = "btnEntry";
            this.btnEntry.Size = new System.Drawing.Size(160, 35);
            this.btnEntry.TabIndex = 27;
            this.btnEntry.Text = "Order Entry";
            this.btnEntry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntry.TextLocation_X = 24;
            this.btnEntry.TextLocation_Y = 6;
            this.btnEntry.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.panel3.Controls.Add(this.panelspace);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 826);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1398, 72);
            this.panel3.TabIndex = 41;
            // 
            // panelspace
            // 
            this.panelspace.Controls.Add(this.panelBlock);
            this.panelspace.Controls.Add(this.btnReset);
            this.panelspace.Controls.Add(this.BtnKMeans);
            this.panelspace.Controls.Add(this.panel10);
            this.panelspace.Controls.Add(this.btnClose);
            this.panelspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelspace.Location = new System.Drawing.Point(0, 0);
            this.panelspace.Name = "panelspace";
            this.panelspace.Padding = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.panelspace.Size = new System.Drawing.Size(1398, 72);
            this.panelspace.TabIndex = 12;
            // 
            // panelBlock
            // 
            this.panelBlock.Location = new System.Drawing.Point(690, 8);
            this.panelBlock.Name = "panelBlock";
            this.panelBlock.Size = new System.Drawing.Size(298, 58);
            this.panelBlock.TabIndex = 35;
            this.panelBlock.Visible = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.ButtonShape = DoReMiVRP.ShapedButton.ButtonsShapes.RoundRect;
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
            this.btnReset.Location = new System.Drawing.Point(994, 8);
            this.btnReset.MouseClickColor1 = System.Drawing.Color.Black;
            this.btnReset.MouseClickColor2 = System.Drawing.Color.Black;
            this.btnReset.MouseHoverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnReset.MouseHoverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnReset.Name = "btnReset";
            this.btnReset.ShowButtontext = true;
            this.btnReset.Size = new System.Drawing.Size(110, 56);
            this.btnReset.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnReset.TabIndex = 41;
            this.btnReset.TextLocation_X = 35;
            this.btnReset.TextLocation_Y = 18;
            this.btnReset.Transparent1 = 250;
            this.btnReset.Transparent2 = 250;
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // BtnKMeans
            // 
            this.BtnKMeans.BackColor = System.Drawing.Color.Transparent;
            this.BtnKMeans.ButtonShape = DoReMiVRP.ShapedButton.ButtonsShapes.RoundRect;
            this.BtnKMeans.ButtonText = "Run Process";
            this.BtnKMeans.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnKMeans.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))));
            this.BtnKMeans.FlatAppearance.BorderSize = 0;
            this.BtnKMeans.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnKMeans.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnKMeans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnKMeans.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnKMeans.ForeColor = System.Drawing.Color.White;
            this.BtnKMeans.GradientAngle = 90;
            this.BtnKMeans.Location = new System.Drawing.Point(1104, 8);
            this.BtnKMeans.MouseClickColor1 = System.Drawing.Color.Black;
            this.BtnKMeans.MouseClickColor2 = System.Drawing.Color.Black;
            this.BtnKMeans.MouseHoverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(30)))));
            this.BtnKMeans.MouseHoverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(80)))));
            this.BtnKMeans.Name = "BtnKMeans";
            this.BtnKMeans.ShowButtontext = true;
            this.BtnKMeans.Size = new System.Drawing.Size(152, 56);
            this.BtnKMeans.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(70)))), ((int)(((byte)(190)))));
            this.BtnKMeans.TabIndex = 40;
            this.BtnKMeans.TextLocation_X = 30;
            this.BtnKMeans.TextLocation_Y = 18;
            this.BtnKMeans.Transparent1 = 250;
            this.BtnKMeans.Transparent2 = 250;
            this.BtnKMeans.UseVisualStyleBackColor = false;
            // 
            // panel10
            // 
            this.panel10.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel10.Location = new System.Drawing.Point(1256, 8);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(29, 56);
            this.panel10.TabIndex = 39;
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
            this.btnClose.Location = new System.Drawing.Point(1285, 8);
            this.btnClose.MouseClickColor1 = System.Drawing.Color.Black;
            this.btnClose.MouseClickColor2 = System.Drawing.Color.Black;
            this.btnClose.MouseHoverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnClose.MouseHoverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnClose.Name = "btnClose";
            this.btnClose.ShowButtontext = true;
            this.btnClose.Size = new System.Drawing.Size(110, 56);
            this.btnClose.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnClose.TabIndex = 36;
            this.btnClose.TextLocation_X = 35;
            this.btnClose.TextLocation_Y = 18;
            this.btnClose.Transparent1 = 250;
            this.btnClose.Transparent2 = 250;
            this.btnClose.UseVisualStyleBackColor = false;
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
            this.lbVersion.Text = "Version 3.5";
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
            this.MaxButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MaxButton.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.MaxButton.CFormState = DoReMiVRP.MinMaxButton.CustomFormState.Normal;
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
            // buttonZ2
            // 
            this.buttonZ2.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.buttonZ2.DisplayText = "_";
            this.buttonZ2.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonZ2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZ2.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZ2.ForeColor = System.Drawing.Color.White;
            this.buttonZ2.Location = new System.Drawing.Point(86, 0);
            this.buttonZ2.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.buttonZ2.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            this.buttonZ2.Name = "buttonZ2";
            this.buttonZ2.Size = new System.Drawing.Size(31, 36);
            this.buttonZ2.TabIndex = 2;
            this.buttonZ2.Text = "_";
            this.buttonZ2.TextLocation_X = 6;
            this.buttonZ2.TextLocation_Y = -20;
            this.buttonZ2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1400, 900);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panelgraph.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panelSide.ResumeLayout(false);
            this.panelSide.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panelspace.ResumeLayout(false);
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
       
      
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label WindowTextLabel;
        private System.Windows.Forms.Panel panel2;
       
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
        private System.Windows.Forms.Panel panelspace;
       
        private ZedGraph.ZedGraphControl maproutegraph;
        private System.Windows.Forms.Label lbVersion;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label3;
        private ShapedButton BtnGMM;
      

        private ButtonX btnEntry;
        private System.Windows.Forms.CheckBox chkBWMap;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboClusterSize;
        private System.Windows.Forms.Panel panelBlock;
        private System.Windows.Forms.Panel panel5;
        private ButtonX btnView;
        private ButtonX btnHelp;
        private ShapedButton btnReset;
        private ShapedButton BtnKMeans;
        private System.Windows.Forms.Panel panel10;
        private ShapedButton btnClose;
        private ButtonZ buttonZ2;
        private ButtonZ CloseButton;
        private ButtonZ MinButton;
        private MinMaxButton MaxButton;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label lblSolution;
        private System.Windows.Forms.TextBox txtSetCoordinates;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}