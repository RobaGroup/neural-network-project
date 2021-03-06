﻿using static NeuralNetworkProject.LoadData;

namespace NeuralNetworkProject
{
    partial class LoadData
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
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem2 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem3 = new Telerik.WinControls.UI.RadListDataItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadData));
            this.Network_creat = new Telerik.WinControls.UI.RadButton();
            this.BP = new Telerik.WinControls.UI.RadPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LoadData_btn = new Telerik.WinControls.UI.RadButton();
            this.Algorithm = new Telerik.WinControls.UI.RadDropDownList();
            this.EpochsNum = new System.Windows.Forms.NumericUpDown();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.momentum = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.AddNewLayer = new Telerik.WinControls.UI.RadButton();
            this.Train = new Telerik.WinControls.UI.RadButton();
            this.Epochs = new Telerik.WinControls.UI.RadLabel();
            this.epochs_num = new System.Windows.Forms.NumericUpDown();
            this.LoadData_dlg = new System.Windows.Forms.OpenFileDialog();
            this.office2010BlackTheme1 = new Telerik.WinControls.Themes.Office2010BlackTheme();
            this.radDiagram1 = new Telerik.WinControls.UI.RadDiagram();
            this.layers2 = new NeuralNetworkProject.Layer_ctrl();
            this.layers1 = new NeuralNetworkProject.Layer_ctrl();
            this.radTrackBar1 = new Telerik.WinControls.UI.RadTrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.Network_creat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BP)).BeginInit();
            this.BP.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoadData_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Algorithm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpochsNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.momentum)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddNewLayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Train)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Epochs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epochs_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDiagram1)).BeginInit();
            this.radDiagram1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTrackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // Network_creat
            // 
            this.Network_creat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Network_creat.Location = new System.Drawing.Point(0, 233);
            this.Network_creat.Name = "Network_creat";
            this.Network_creat.Size = new System.Drawing.Size(250, 24);
            this.Network_creat.TabIndex = 7;
            this.Network_creat.Text = "Create Network";
            this.Network_creat.ThemeName = "Office2010Black";
            this.Network_creat.Click += new System.EventHandler(this.Network_creat_Click);
            // 
            // BP
            // 
            this.BP.BackColor = System.Drawing.Color.LightSalmon;
            this.BP.Controls.Add(this.panel2);
            this.BP.Controls.Add(this.panel1);
            this.BP.Controls.Add(this.Train);
            this.BP.Dock = System.Windows.Forms.DockStyle.Left;
            this.BP.Location = new System.Drawing.Point(0, 0);
            this.BP.Name = "BP";
            this.BP.Size = new System.Drawing.Size(277, 438);
            this.BP.TabIndex = 4;
            this.BP.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.BP.ThemeName = "Office2010Black";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LoadData_btn);
            this.panel2.Controls.Add(this.Algorithm);
            this.panel2.Controls.Add(this.EpochsNum);
            this.panel2.Controls.Add(this.radLabel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(277, 137);
            this.panel2.TabIndex = 11;
            // 
            // LoadData_btn
            // 
            this.LoadData_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.LoadData_btn.Location = new System.Drawing.Point(0, 0);
            this.LoadData_btn.Name = "LoadData_btn";
            this.LoadData_btn.Size = new System.Drawing.Size(277, 37);
            this.LoadData_btn.TabIndex = 5;
            this.LoadData_btn.Text = "Load Data";
            this.LoadData_btn.ThemeName = "Office2010Black";
            this.LoadData_btn.Click += new System.EventHandler(this.LoadData_btn_Click);
            // 
            // Algorithm
            // 
            radListDataItem1.Text = "BackProbagation";
            radListDataItem2.Text = "BackProbagation with Momentum";
            radListDataItem3.Text = "Simple Perceptron";
            this.Algorithm.Items.Add(radListDataItem1);
            this.Algorithm.Items.Add(radListDataItem2);
            this.Algorithm.Items.Add(radListDataItem3);
            this.Algorithm.Location = new System.Drawing.Point(37, 99);
            this.Algorithm.Name = "Algorithm";
            this.Algorithm.Size = new System.Drawing.Size(197, 20);
            this.Algorithm.TabIndex = 3;
            this.Algorithm.Text = "Choose Algorithm";
            this.Algorithm.ThemeName = "Office2010Black";
            this.Algorithm.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.Algorithem_SelectedIndexChanged);
            // 
            // EpochsNum
            // 
            this.EpochsNum.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.EpochsNum.Location = new System.Drawing.Point(113, 58);
            this.EpochsNum.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.EpochsNum.Name = "EpochsNum";
            this.EpochsNum.Size = new System.Drawing.Size(68, 22);
            this.EpochsNum.TabIndex = 1;
            this.EpochsNum.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.EpochsNum.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.radLabel1.Location = new System.Drawing.Point(66, 58);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(43, 18);
            this.radLabel1.TabIndex = 10;
            this.radLabel1.Text = "Epochs";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.radLabel2);
            this.panel1.Controls.Add(this.momentum);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.AddNewLayer);
            this.panel1.Controls.Add(this.Network_creat);
            this.panel1.Location = new System.Drawing.Point(12, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 257);
            this.panel1.TabIndex = 0;
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.radLabel2.Location = new System.Drawing.Point(25, 3);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(69, 18);
            this.radLabel2.TabIndex = 11;
            this.radLabel2.Text = "Momentum";
            // 
            // momentum
            // 
            this.momentum.DecimalPlaces = 4;
            this.momentum.Enabled = false;
            this.momentum.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.momentum.Location = new System.Drawing.Point(100, 1);
            this.momentum.Name = "momentum";
            this.momentum.Size = new System.Drawing.Size(69, 22);
            this.momentum.TabIndex = 11;
            this.momentum.Value = new decimal(new int[] {
            9,
            0,
            0,
            65536});
            this.momentum.ValueChanged += new System.EventHandler(this.momentum_ValueChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.LightSalmon;
            this.flowLayoutPanel1.Controls.Add(this.layers2);
            this.flowLayoutPanel1.Controls.Add(this.layers1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 40);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(250, 165);
            this.flowLayoutPanel1.TabIndex = 8;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // AddNewLayer
            // 
            this.AddNewLayer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddNewLayer.Location = new System.Drawing.Point(0, 209);
            this.AddNewLayer.Name = "AddNewLayer";
            this.AddNewLayer.Size = new System.Drawing.Size(250, 24);
            this.AddNewLayer.TabIndex = 9;
            this.AddNewLayer.Text = "Add New Layer";
            this.AddNewLayer.ThemeName = "Office2010Black";
            this.AddNewLayer.Click += new System.EventHandler(this.AddNewLayer_Click);
            // 
            // Train
            // 
            this.Train.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Train.Location = new System.Drawing.Point(0, 404);
            this.Train.Name = "Train";
            this.Train.Size = new System.Drawing.Size(277, 34);
            this.Train.TabIndex = 2;
            this.Train.Text = "Train";
            this.Train.ThemeName = "Office2010Black";
            this.Train.Click += new System.EventHandler(this.Train_Click);
            // 
            // Epochs
            // 
            this.Epochs.Location = new System.Drawing.Point(583, 419);
            this.Epochs.Name = "Epochs";
            this.Epochs.Size = new System.Drawing.Size(42, 18);
            this.Epochs.TabIndex = 3;
            this.Epochs.Text = "Epochs";
            // 
            // epochs_num
            // 
            this.epochs_num.Location = new System.Drawing.Point(407, 417);
            this.epochs_num.Name = "epochs_num";
            this.epochs_num.Size = new System.Drawing.Size(104, 20);
            this.epochs_num.TabIndex = 2;
            this.epochs_num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LoadData_dlg
            // 
            this.LoadData_dlg.DefaultExt = "txt";
            this.LoadData_dlg.DereferenceLinks = false;
            this.LoadData_dlg.Filter = "Text files (*.txt)|*.txt|Excel files (*.csv)|*.csv|All files (*.*)|*.*";
            this.LoadData_dlg.Title = "Open Dataset File";
            this.LoadData_dlg.FileOk += new System.ComponentModel.CancelEventHandler(this.LoadData_dlg_FileOk);
            // 
            // radDiagram1
            // 
            this.radDiagram1.BackColor = System.Drawing.Color.Gray;
            this.radDiagram1.Controls.Add(this.radTrackBar1);
            this.radDiagram1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radDiagram1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radDiagram1.IsBackgroundSurfaceVisible = false;
            this.radDiagram1.Location = new System.Drawing.Point(277, 0);
            this.radDiagram1.Name = "radDiagram1";
            this.radDiagram1.SerializedXml = resources.GetString("radDiagram1.SerializedXml");
            this.radDiagram1.Size = new System.Drawing.Size(484, 438);
            this.radDiagram1.TabIndex = 9;
            this.radDiagram1.Text = "radDiagram1";
            this.radDiagram1.ThemeName = "ControlDefault";
            this.radDiagram1.Zoom = 0.9D;
            this.radDiagram1.Click += new System.EventHandler(this.radDiagram1_Click);
            ((Telerik.WinControls.UI.RadDiagramElement)(this.radDiagram1.GetChildAt(0))).ActiveTool = Telerik.Windows.Diagrams.Core.MouseTool.PanTool;
            ((Telerik.WinControls.UI.RadDiagramElement)(this.radDiagram1.GetChildAt(0))).ConnectionBridge = Telerik.Windows.Diagrams.Core.BridgeType.None;
            ((Telerik.WinControls.UI.RadDiagramElement)(this.radDiagram1.GetChildAt(0))).Zoom = 0.9D;
            ((Telerik.WinControls.UI.RadDiagramElement)(this.radDiagram1.GetChildAt(0))).IsBackgroundSurfaceVisible = false;
            ((Telerik.WinControls.UI.RadDiagramElement)(this.radDiagram1.GetChildAt(0))).BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            ((Telerik.WinControls.UI.RadDiagramElement)(this.radDiagram1.GetChildAt(0))).BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            ((Telerik.WinControls.UI.RadDiagramElement)(this.radDiagram1.GetChildAt(0))).BorderColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            ((Telerik.WinControls.UI.RadDiagramElement)(this.radDiagram1.GetChildAt(0))).BorderColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            ((Telerik.WinControls.UI.RadDiagramElement)(this.radDiagram1.GetChildAt(0))).BorderInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            ((Telerik.WinControls.UI.RadDiagramElement)(this.radDiagram1.GetChildAt(0))).BorderInnerColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            ((Telerik.WinControls.UI.RadDiagramElement)(this.radDiagram1.GetChildAt(0))).BorderInnerColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            ((Telerik.WinControls.UI.RadDiagramElement)(this.radDiagram1.GetChildAt(0))).BorderInnerColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            ((Telerik.WinControls.UI.RadDiagramElement)(this.radDiagram1.GetChildAt(0))).BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            ((Telerik.WinControls.UI.RadDiagramElement)(this.radDiagram1.GetChildAt(0))).BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            ((Telerik.WinControls.UI.RadDiagramElement)(this.radDiagram1.GetChildAt(0))).BackColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            ((Telerik.WinControls.UI.RadDiagramElement)(this.radDiagram1.GetChildAt(0))).NumberOfColors = 2;
            ((Telerik.WinControls.UI.RadDiagramElement)(this.radDiagram1.GetChildAt(0))).HorizontalLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            ((Telerik.WinControls.UI.RadDiagramElement)(this.radDiagram1.GetChildAt(0))).BorderLeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            ((Telerik.WinControls.UI.RadDiagramElement)(this.radDiagram1.GetChildAt(0))).BorderTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            ((Telerik.WinControls.UI.RadDiagramElement)(this.radDiagram1.GetChildAt(0))).BorderRightColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            ((Telerik.WinControls.UI.RadDiagramElement)(this.radDiagram1.GetChildAt(0))).BorderBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            ((Telerik.WinControls.UI.RadDiagramElement)(this.radDiagram1.GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            // 
            // layers2
            // 
            this.layers2.Location = new System.Drawing.Point(3, 3);
            this.layers2.Name = "layers2";
            this.layers2.Size = new System.Drawing.Size(244, 33);
            this.layers2.TabIndex = 1;
            this.layers2.Load += new System.EventHandler(this.layers2_Load);
            // 
            // layers1
            // 
            this.layers1.Location = new System.Drawing.Point(3, 42);
            this.layers1.Name = "layers1";
            this.layers1.Size = new System.Drawing.Size(244, 33);
            this.layers1.TabIndex = 0;
            // 
            // radTrackBar1
            // 
            this.radTrackBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radTrackBar1.Location = new System.Drawing.Point(130, 365);
            this.radTrackBar1.Name = "radTrackBar1";
            this.radTrackBar1.ShowButtons = true;
            this.radTrackBar1.Size = new System.Drawing.Size(241, 25);
            this.radTrackBar1.SnapMode = Telerik.WinControls.UI.TrackBarSnapModes.None;
            this.radTrackBar1.TabIndex = 10;
            this.radTrackBar1.Text = "radTrackBar1";
            this.radTrackBar1.ThemeName = "VisualStudio2012Dark";
            this.radTrackBar1.ThumbSize = new System.Drawing.Size(14, 14);
            this.radTrackBar1.TickStyle = Telerik.WinControls.Enumerations.TickStyles.TopLeft;
            this.radTrackBar1.ValueChanged += new System.EventHandler(this.radTrackBar1_ValueChanged);
            // 
            // LoadData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 438);
            this.Controls.Add(this.radDiagram1);
            this.Controls.Add(this.Epochs);
            this.Controls.Add(this.BP);
            this.Controls.Add(this.epochs_num);
            this.Name = "LoadData";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "LoadData";
            this.ThemeName = "Office2010Black";
            this.Load += new System.EventHandler(this.LoadData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Network_creat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BP)).EndInit();
            this.BP.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoadData_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Algorithm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpochsNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.momentum)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AddNewLayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Train)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Epochs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epochs_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDiagram1)).EndInit();
            this.radDiagram1.ResumeLayout(false);
            this.radDiagram1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTrackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton Network_creat;
        private Telerik.WinControls.UI.RadPanel BP;
        private Telerik.WinControls.UI.RadLabel Epochs;
        private System.Windows.Forms.NumericUpDown epochs_num;
        private Telerik.WinControls.UI.RadDropDownList Algorithm;
        private Telerik.WinControls.UI.RadButton LoadData_btn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Layer_ctrl layers2;
        private Layer_ctrl layers1;
        public System.Windows.Forms.OpenFileDialog LoadData_dlg;
        private Telerik.WinControls.UI.RadButton AddNewLayer;
        private Telerik.WinControls.Themes.Office2010BlackTheme office2010BlackTheme1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private System.Windows.Forms.NumericUpDown EpochsNum;
        private System.Windows.Forms.Panel panel1;
        private Telerik.WinControls.UI.RadButton Train;
        private System.Windows.Forms.Panel panel2;
        private Telerik.WinControls.UI.RadDiagram radDiagram1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private System.Windows.Forms.NumericUpDown momentum;
        private Telerik.WinControls.UI.RadTrackBar radTrackBar1;
    }
}
