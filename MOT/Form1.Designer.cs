namespace MOT
{
    partial class Form1
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
            VisualPlus.Structure.TextStyle textStyle1 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle2 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle3 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle4 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle5 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle6 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle7 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle8 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle9 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle10 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle11 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle12 = new VisualPlus.Structure.TextStyle();
            this.btPlay = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
            this.btLoadFolder = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
            this.btStop = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.visualLabelVolume = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
            this.visualLabel1 = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
            this.timeElapsed = new System.Windows.Forms.Timer(this.components);
            this.seekBar = new System.Windows.Forms.TrackBar();
            this.visualListBox1 = new VisualPlus.Toolkit.Controls.DataManagement.VisualListBox();
            this.visualLabelPlaylist = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
            this.visualBtAddNewPlaylist = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
            this.visualBtDeletePlaylist = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
            this.visualBtRenamePlaylist = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
            this.visualBtLoadPlaylist = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
            this.visualPlayListTabs = new VisualPlus.Toolkit.Controls.Navigation.VisualTabControl();
            this.visualTextBoxAddPlaylist = new VisualPlus.Toolkit.Controls.Editors.VisualTextBox();
            this.visualTabPage1 = new VisualPlus.Toolkit.Child.VisualTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seekBar)).BeginInit();
            this.visualPlayListTabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // btPlay
            // 
            this.btPlay.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btPlay.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.btPlay.BackColorState.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btPlay.BackColorState.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btPlay.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btPlay.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.btPlay.Border.HoverVisible = true;
            this.btPlay.Border.Rounding = 6;
            this.btPlay.Border.Thickness = 1;
            this.btPlay.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.btPlay.Border.Visible = true;
            this.btPlay.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btPlay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btPlay.Image = null;
            this.btPlay.Location = new System.Drawing.Point(679, 422);
            this.btPlay.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.btPlay.Name = "btPlay";
            this.btPlay.Size = new System.Drawing.Size(140, 45);
            this.btPlay.TabIndex = 1;
            this.btPlay.Text = "Play";
            this.btPlay.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btPlay.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.btPlay.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle1.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle1.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle1.Hover = System.Drawing.Color.Empty;
            textStyle1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btPlay.TextStyle = textStyle1;
            this.btPlay.Click += new System.EventHandler(this.BtPlay_Click);
            // 
            // btLoadFolder
            // 
            this.btLoadFolder.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btLoadFolder.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.btLoadFolder.BackColorState.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btLoadFolder.BackColorState.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btLoadFolder.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btLoadFolder.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.btLoadFolder.Border.HoverVisible = true;
            this.btLoadFolder.Border.Rounding = 6;
            this.btLoadFolder.Border.Thickness = 1;
            this.btLoadFolder.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.btLoadFolder.Border.Visible = true;
            this.btLoadFolder.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btLoadFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btLoadFolder.Image = null;
            this.btLoadFolder.Location = new System.Drawing.Point(502, 404);
            this.btLoadFolder.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.btLoadFolder.Name = "btLoadFolder";
            this.btLoadFolder.Size = new System.Drawing.Size(140, 45);
            this.btLoadFolder.TabIndex = 2;
            this.btLoadFolder.Text = "Load Music";
            this.btLoadFolder.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btLoadFolder.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.btLoadFolder.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle2.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle2.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle2.Hover = System.Drawing.Color.Empty;
            textStyle2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btLoadFolder.TextStyle = textStyle2;
            this.btLoadFolder.Click += new System.EventHandler(this.BtLoadFolder_Click);
            // 
            // btStop
            // 
            this.btStop.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btStop.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.btStop.BackColorState.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btStop.BackColorState.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btStop.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btStop.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.btStop.Border.HoverVisible = true;
            this.btStop.Border.Rounding = 6;
            this.btStop.Border.Thickness = 1;
            this.btStop.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.btStop.Border.Visible = true;
            this.btStop.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btStop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btStop.Image = null;
            this.btStop.Location = new System.Drawing.Point(867, 422);
            this.btStop.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(140, 45);
            this.btStop.TabIndex = 3;
            this.btStop.Text = "Stop";
            this.btStop.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btStop.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.btStop.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle3.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle3.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle3.Hover = System.Drawing.Color.Empty;
            textStyle3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btStop.TextStyle = textStyle3;
            this.btStop.Click += new System.EventHandler(this.BtStop_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(493, 498);
            this.trackBar1.Maximum = 200;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(180, 45);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.Value = 30;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // visualLabelVolume
            // 
            this.visualLabelVolume.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.visualLabelVolume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualLabelVolume.Location = new System.Drawing.Point(530, 461);
            this.visualLabelVolume.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualLabelVolume.Name = "visualLabelVolume";
            this.visualLabelVolume.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.visualLabelVolume.Outline = false;
            this.visualLabelVolume.OutlineColor = System.Drawing.Color.Red;
            this.visualLabelVolume.OutlineLocation = new System.Drawing.Point(0, 0);
            this.visualLabelVolume.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualLabelVolume.ReflectionSpacing = 0;
            this.visualLabelVolume.ShadowColor = System.Drawing.Color.Black;
            this.visualLabelVolume.ShadowDirection = 315;
            this.visualLabelVolume.ShadowLocation = new System.Drawing.Point(0, 0);
            this.visualLabelVolume.ShadowOpacity = 100;
            this.visualLabelVolume.Size = new System.Drawing.Size(75, 23);
            this.visualLabelVolume.TabIndex = 5;
            this.visualLabelVolume.Text = "visualLabel1";
            this.visualLabelVolume.TextAlignment = System.Drawing.StringAlignment.Near;
            this.visualLabelVolume.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle4.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle4.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle4.Hover = System.Drawing.Color.Empty;
            textStyle4.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.visualLabelVolume.TextStyle = textStyle4;
            // 
            // visualLabel1
            // 
            this.visualLabel1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.visualLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualLabel1.Location = new System.Drawing.Point(987, 492);
            this.visualLabel1.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualLabel1.Name = "visualLabel1";
            this.visualLabel1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.visualLabel1.Outline = false;
            this.visualLabel1.OutlineColor = System.Drawing.Color.Red;
            this.visualLabel1.OutlineLocation = new System.Drawing.Point(0, 0);
            this.visualLabel1.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualLabel1.ReflectionSpacing = 0;
            this.visualLabel1.ShadowColor = System.Drawing.Color.Black;
            this.visualLabel1.ShadowDirection = 315;
            this.visualLabel1.ShadowLocation = new System.Drawing.Point(0, 0);
            this.visualLabel1.ShadowOpacity = 100;
            this.visualLabel1.Size = new System.Drawing.Size(75, 23);
            this.visualLabel1.TabIndex = 6;
            this.visualLabel1.Text = "visualLabel1";
            this.visualLabel1.TextAlignment = System.Drawing.StringAlignment.Near;
            this.visualLabel1.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle5.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle5.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle5.Hover = System.Drawing.Color.Empty;
            textStyle5.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.visualLabel1.TextStyle = textStyle5;
            // 
            // timeElapsed
            // 
            this.timeElapsed.Interval = 1000;
            this.timeElapsed.Tick += new System.EventHandler(this.timeElapsed_Tick);
            // 
            // seekBar
            // 
            this.seekBar.Location = new System.Drawing.Point(708, 498);
            this.seekBar.Maximum = 1;
            this.seekBar.Name = "seekBar";
            this.seekBar.Size = new System.Drawing.Size(231, 45);
            this.seekBar.TabIndex = 7;
            this.seekBar.Scroll += new System.EventHandler(this.seekBar_Scroll);
            // 
            // visualListBox1
            // 
            this.visualListBox1.AlternateColors = false;
            this.visualListBox1.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.visualListBox1.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.visualListBox1.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.visualListBox1.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.visualListBox1.Border.HoverVisible = true;
            this.visualListBox1.Border.Rounding = 6;
            this.visualListBox1.Border.Thickness = 1;
            this.visualListBox1.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.visualListBox1.Border.Visible = true;
            this.visualListBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.visualListBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualListBox1.ItemAlternate = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(13)))));
            this.visualListBox1.ItemHeight = 18;
            this.visualListBox1.ItemLineAlignment = System.Drawing.StringAlignment.Center;
            this.visualListBox1.ItemNormal = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.visualListBox1.Items.AddRange(new object[] {
            "All Music"});
            this.visualListBox1.ItemSelected = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.visualListBox1.Location = new System.Drawing.Point(12, 63);
            this.visualListBox1.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualListBox1.Name = "visualListBox1";
            this.visualListBox1.Size = new System.Drawing.Size(379, 370);
            this.visualListBox1.TabIndex = 8;
            this.visualListBox1.Text = "visualListBox1";
            textStyle6.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle6.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle6.Hover = System.Drawing.Color.Empty;
            textStyle6.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.visualListBox1.TextStyle = textStyle6;
            // 
            // visualLabelPlaylist
            // 
            this.visualLabelPlaylist.Font = new System.Drawing.Font("Courier New", 30F);
            this.visualLabelPlaylist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualLabelPlaylist.Location = new System.Drawing.Point(66, 12);
            this.visualLabelPlaylist.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualLabelPlaylist.Name = "visualLabelPlaylist";
            this.visualLabelPlaylist.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.visualLabelPlaylist.Outline = false;
            this.visualLabelPlaylist.OutlineColor = System.Drawing.Color.Red;
            this.visualLabelPlaylist.OutlineLocation = new System.Drawing.Point(0, 0);
            this.visualLabelPlaylist.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualLabelPlaylist.ReflectionSpacing = 0;
            this.visualLabelPlaylist.ShadowColor = System.Drawing.Color.Black;
            this.visualLabelPlaylist.ShadowDirection = 315;
            this.visualLabelPlaylist.ShadowLocation = new System.Drawing.Point(0, 0);
            this.visualLabelPlaylist.ShadowOpacity = 100;
            this.visualLabelPlaylist.Size = new System.Drawing.Size(263, 45);
            this.visualLabelPlaylist.TabIndex = 9;
            this.visualLabelPlaylist.Text = "Play Lists";
            this.visualLabelPlaylist.TextAlignment = System.Drawing.StringAlignment.Near;
            this.visualLabelPlaylist.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle7.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle7.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle7.Hover = System.Drawing.Color.Empty;
            textStyle7.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.visualLabelPlaylist.TextStyle = textStyle7;
            // 
            // visualBtAddNewPlaylist
            // 
            this.visualBtAddNewPlaylist.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.visualBtAddNewPlaylist.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.visualBtAddNewPlaylist.BackColorState.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.visualBtAddNewPlaylist.BackColorState.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.visualBtAddNewPlaylist.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.visualBtAddNewPlaylist.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.visualBtAddNewPlaylist.Border.HoverVisible = true;
            this.visualBtAddNewPlaylist.Border.Rounding = 6;
            this.visualBtAddNewPlaylist.Border.Thickness = 1;
            this.visualBtAddNewPlaylist.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.visualBtAddNewPlaylist.Border.Visible = true;
            this.visualBtAddNewPlaylist.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.visualBtAddNewPlaylist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualBtAddNewPlaylist.Image = null;
            this.visualBtAddNewPlaylist.Location = new System.Drawing.Point(12, 439);
            this.visualBtAddNewPlaylist.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualBtAddNewPlaylist.Name = "visualBtAddNewPlaylist";
            this.visualBtAddNewPlaylist.Size = new System.Drawing.Size(80, 45);
            this.visualBtAddNewPlaylist.TabIndex = 10;
            this.visualBtAddNewPlaylist.Text = "Add Playlist";
            this.visualBtAddNewPlaylist.TextAlignment = System.Drawing.StringAlignment.Center;
            this.visualBtAddNewPlaylist.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.visualBtAddNewPlaylist.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle8.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle8.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle8.Hover = System.Drawing.Color.Empty;
            textStyle8.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.visualBtAddNewPlaylist.TextStyle = textStyle8;
            this.visualBtAddNewPlaylist.Click += new System.EventHandler(this.visualBtAddNewPlaylist_Click);
            // 
            // visualBtDeletePlaylist
            // 
            this.visualBtDeletePlaylist.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.visualBtDeletePlaylist.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.visualBtDeletePlaylist.BackColorState.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.visualBtDeletePlaylist.BackColorState.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.visualBtDeletePlaylist.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.visualBtDeletePlaylist.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.visualBtDeletePlaylist.Border.HoverVisible = true;
            this.visualBtDeletePlaylist.Border.Rounding = 6;
            this.visualBtDeletePlaylist.Border.Thickness = 1;
            this.visualBtDeletePlaylist.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.visualBtDeletePlaylist.Border.Visible = true;
            this.visualBtDeletePlaylist.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.visualBtDeletePlaylist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualBtDeletePlaylist.Image = null;
            this.visualBtDeletePlaylist.Location = new System.Drawing.Point(98, 439);
            this.visualBtDeletePlaylist.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualBtDeletePlaylist.Name = "visualBtDeletePlaylist";
            this.visualBtDeletePlaylist.Size = new System.Drawing.Size(86, 45);
            this.visualBtDeletePlaylist.TabIndex = 11;
            this.visualBtDeletePlaylist.Text = "Delete Playlist";
            this.visualBtDeletePlaylist.TextAlignment = System.Drawing.StringAlignment.Center;
            this.visualBtDeletePlaylist.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.visualBtDeletePlaylist.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle9.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle9.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle9.Hover = System.Drawing.Color.Empty;
            textStyle9.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.visualBtDeletePlaylist.TextStyle = textStyle9;
            this.visualBtDeletePlaylist.Click += new System.EventHandler(this.visualBtDeletePlaylist_Click);
            // 
            // visualBtRenamePlaylist
            // 
            this.visualBtRenamePlaylist.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.visualBtRenamePlaylist.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.visualBtRenamePlaylist.BackColorState.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.visualBtRenamePlaylist.BackColorState.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.visualBtRenamePlaylist.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.visualBtRenamePlaylist.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.visualBtRenamePlaylist.Border.HoverVisible = true;
            this.visualBtRenamePlaylist.Border.Rounding = 6;
            this.visualBtRenamePlaylist.Border.Thickness = 1;
            this.visualBtRenamePlaylist.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.visualBtRenamePlaylist.Border.Visible = true;
            this.visualBtRenamePlaylist.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.visualBtRenamePlaylist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualBtRenamePlaylist.Image = null;
            this.visualBtRenamePlaylist.Location = new System.Drawing.Point(190, 439);
            this.visualBtRenamePlaylist.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualBtRenamePlaylist.Name = "visualBtRenamePlaylist";
            this.visualBtRenamePlaylist.Size = new System.Drawing.Size(90, 45);
            this.visualBtRenamePlaylist.TabIndex = 12;
            this.visualBtRenamePlaylist.Text = "Rename Playlist";
            this.visualBtRenamePlaylist.TextAlignment = System.Drawing.StringAlignment.Center;
            this.visualBtRenamePlaylist.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.visualBtRenamePlaylist.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle10.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle10.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle10.Hover = System.Drawing.Color.Empty;
            textStyle10.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.visualBtRenamePlaylist.TextStyle = textStyle10;
            this.visualBtRenamePlaylist.Click += new System.EventHandler(this.visualBtRenamePlaylist_Click);
            // 
            // visualBtLoadPlaylist
            // 
            this.visualBtLoadPlaylist.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.visualBtLoadPlaylist.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.visualBtLoadPlaylist.BackColorState.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.visualBtLoadPlaylist.BackColorState.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.visualBtLoadPlaylist.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.visualBtLoadPlaylist.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.visualBtLoadPlaylist.Border.HoverVisible = true;
            this.visualBtLoadPlaylist.Border.Rounding = 6;
            this.visualBtLoadPlaylist.Border.Thickness = 1;
            this.visualBtLoadPlaylist.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.visualBtLoadPlaylist.Border.Visible = true;
            this.visualBtLoadPlaylist.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.visualBtLoadPlaylist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualBtLoadPlaylist.Image = null;
            this.visualBtLoadPlaylist.Location = new System.Drawing.Point(286, 439);
            this.visualBtLoadPlaylist.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualBtLoadPlaylist.Name = "visualBtLoadPlaylist";
            this.visualBtLoadPlaylist.Size = new System.Drawing.Size(95, 45);
            this.visualBtLoadPlaylist.TabIndex = 13;
            this.visualBtLoadPlaylist.Text = "Load Playlist";
            this.visualBtLoadPlaylist.TextAlignment = System.Drawing.StringAlignment.Center;
            this.visualBtLoadPlaylist.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.visualBtLoadPlaylist.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle11.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle11.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle11.Hover = System.Drawing.Color.Empty;
            textStyle11.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.visualBtLoadPlaylist.TextStyle = textStyle11;
            // 
            // visualPlayListTabs
            // 
            this.visualPlayListTabs.Controls.Add(this.visualTabPage1);
            this.visualPlayListTabs.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.visualPlayListTabs.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.visualPlayListTabs.ItemSize = new System.Drawing.Size(100, 25);
            this.visualPlayListTabs.Location = new System.Drawing.Point(482, 0);
            this.visualPlayListTabs.MinimumSize = new System.Drawing.Size(144, 85);
            this.visualPlayListTabs.Name = "visualPlayListTabs";
            this.visualPlayListTabs.SelectedIndex = 0;
            this.visualPlayListTabs.SelectorAlignment = System.Windows.Forms.TabAlignment.Top;
            this.visualPlayListTabs.SelectorSpacing = 10;
            this.visualPlayListTabs.SelectorThickness = 4;
            this.visualPlayListTabs.SelectorType = VisualPlus.Toolkit.Controls.Navigation.VisualTabControl.SelectorTypes.Arrow;
            this.visualPlayListTabs.SelectorVisible = false;
            this.visualPlayListTabs.Separator = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(222)))), ((int)(((byte)(220)))));
            this.visualPlayListTabs.SeparatorSpacing = 2;
            this.visualPlayListTabs.SeparatorThickness = 2F;
            this.visualPlayListTabs.Size = new System.Drawing.Size(634, 398);
            this.visualPlayListTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.visualPlayListTabs.State = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualPlayListTabs.TabIndex = 14;
            this.visualPlayListTabs.TabMenu = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(73)))));
            this.visualPlayListTabs.TabSelector = System.Drawing.Color.Green;
            this.visualPlayListTabs.TextRendering = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // visualTextBoxAddPlaylist
            // 
            this.visualTextBoxAddPlaylist.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.visualTextBoxAddPlaylist.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.visualTextBoxAddPlaylist.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.visualTextBoxAddPlaylist.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.visualTextBoxAddPlaylist.Border.HoverVisible = true;
            this.visualTextBoxAddPlaylist.Border.Rounding = 6;
            this.visualTextBoxAddPlaylist.Border.Thickness = 1;
            this.visualTextBoxAddPlaylist.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.visualTextBoxAddPlaylist.Border.Visible = true;
            this.visualTextBoxAddPlaylist.ButtonBorder.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.visualTextBoxAddPlaylist.ButtonBorder.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.visualTextBoxAddPlaylist.ButtonBorder.HoverVisible = true;
            this.visualTextBoxAddPlaylist.ButtonBorder.Rounding = 6;
            this.visualTextBoxAddPlaylist.ButtonBorder.Thickness = 1;
            this.visualTextBoxAddPlaylist.ButtonBorder.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.visualTextBoxAddPlaylist.ButtonBorder.Visible = true;
            this.visualTextBoxAddPlaylist.ButtonColor.Disabled = System.Drawing.Color.Empty;
            this.visualTextBoxAddPlaylist.ButtonColor.Enabled = System.Drawing.Color.Empty;
            this.visualTextBoxAddPlaylist.ButtonColor.Hover = System.Drawing.Color.Empty;
            this.visualTextBoxAddPlaylist.ButtonColor.Pressed = System.Drawing.Color.Empty;
            this.visualTextBoxAddPlaylist.ButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visualTextBoxAddPlaylist.ButtonIndent = 3;
            this.visualTextBoxAddPlaylist.ButtonText = "visualButton";
            this.visualTextBoxAddPlaylist.ButtonVisible = false;
            this.visualTextBoxAddPlaylist.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.visualTextBoxAddPlaylist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualTextBoxAddPlaylist.ImageSize = new System.Drawing.Size(16, 16);
            this.visualTextBoxAddPlaylist.ImageVisible = false;
            this.visualTextBoxAddPlaylist.ImageWidth = 35;
            this.visualTextBoxAddPlaylist.Location = new System.Drawing.Point(369, 213);
            this.visualTextBoxAddPlaylist.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualTextBoxAddPlaylist.Name = "visualTextBoxAddPlaylist";
            this.visualTextBoxAddPlaylist.PasswordChar = '\0';
            this.visualTextBoxAddPlaylist.ReadOnly = false;
            this.visualTextBoxAddPlaylist.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.visualTextBoxAddPlaylist.Size = new System.Drawing.Size(236, 25);
            this.visualTextBoxAddPlaylist.TabIndex = 15;
            this.visualTextBoxAddPlaylist.TextBoxWidth = 226;
            textStyle12.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle12.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle12.Hover = System.Drawing.Color.Empty;
            textStyle12.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.visualTextBoxAddPlaylist.TextStyle = textStyle12;
            this.visualTextBoxAddPlaylist.Visible = false;
            this.visualTextBoxAddPlaylist.Watermark.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.visualTextBoxAddPlaylist.Watermark.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.visualTextBoxAddPlaylist.Watermark.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.visualTextBoxAddPlaylist.Watermark.Text = "Watermark text";
            this.visualTextBoxAddPlaylist.Watermark.Visible = false;
            // 
            // visualTabPage1
            // 
            this.visualTabPage1.BackColor = System.Drawing.Color.Transparent;
            this.visualTabPage1.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.visualTabPage1.Border.Rounding = 6;
            this.visualTabPage1.Border.Thickness = 1;
            this.visualTabPage1.Border.Type = VisualPlus.Enumerators.ShapeType.Rectangle;
            this.visualTabPage1.Border.Visible = false;
            this.visualTabPage1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.visualTabPage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(181)))), ((int)(((byte)(187)))));
            this.visualTabPage1.HeaderImage = null;
            this.visualTabPage1.Image = null;
            this.visualTabPage1.ImageSize = new System.Drawing.Size(16, 16);
            this.visualTabPage1.Location = new System.Drawing.Point(4, 29);
            this.visualTabPage1.Name = "visualTabPage1";
            this.visualTabPage1.Size = new System.Drawing.Size(626, 365);
            this.visualTabPage1.TabHover = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.visualTabPage1.TabIndex = 1;
            this.visualTabPage1.TabNormal = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(73)))));
            this.visualTabPage1.TabSelected = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(76)))), ((int)(((byte)(88)))));
            this.visualTabPage1.Text = "visualTabPage1";
            this.visualTabPage1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.visualTabPage1.TextImageRelation = VisualPlus.Toolkit.Child.VisualTabPage.TextImageRelations.Text;
            this.visualTabPage1.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.visualTabPage1.TextSelected = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(220)))), ((int)(((byte)(227)))));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 555);
            this.Controls.Add(this.visualTextBoxAddPlaylist);
            this.Controls.Add(this.visualPlayListTabs);
            this.Controls.Add(this.visualBtLoadPlaylist);
            this.Controls.Add(this.visualBtRenamePlaylist);
            this.Controls.Add(this.visualBtDeletePlaylist);
            this.Controls.Add(this.visualBtAddNewPlaylist);
            this.Controls.Add(this.visualLabelPlaylist);
            this.Controls.Add(this.visualListBox1);
            this.Controls.Add(this.seekBar);
            this.Controls.Add(this.visualLabel1);
            this.Controls.Add(this.visualLabelVolume);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btLoadFolder);
            this.Controls.Add(this.btPlay);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seekBar)).EndInit();
            this.visualPlayListTabs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private VisualPlus.Toolkit.Controls.Interactivity.VisualButton btPlay;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualButton btLoadFolder;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualButton btStop;
        private System.Windows.Forms.TrackBar trackBar1;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualLabel visualLabelVolume;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualLabel visualLabel1;
        private System.Windows.Forms.Timer timeElapsed;
        private System.Windows.Forms.TrackBar seekBar;
        private VisualPlus.Toolkit.Controls.DataManagement.VisualListBox visualListBox1;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualLabel visualLabelPlaylist;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualButton visualBtAddNewPlaylist;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualButton visualBtDeletePlaylist;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualButton visualBtRenamePlaylist;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualButton visualBtLoadPlaylist;
        private VisualPlus.Toolkit.Controls.Navigation.VisualTabControl visualPlayListTabs;
        private VisualPlus.Toolkit.Controls.Editors.VisualTextBox visualTextBoxAddPlaylist;
        private VisualPlus.Toolkit.Child.VisualTabPage visualTabPage1;
    }
}

