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
            VisualPlus.Structure.TextStyle textStyle4 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle5 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle6 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle7 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle1 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle2 = new VisualPlus.Structure.TextStyle();
            this.visualCheckedListBox1 = new VisualPlus.Toolkit.Controls.DataManagement.VisualCheckedListBox();
            this.btPlay = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
            this.btLoadFolder = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
            this.btStop = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.visualLabelVolume = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
            this.visualLabel1 = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
            this.timeElapsed = new System.Windows.Forms.Timer(this.components);
            this.seekBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seekBar)).BeginInit();
            this.SuspendLayout();
            // 
            // visualCheckedListBox1
            // 
            this.visualCheckedListBox1.AlternateColors = true;
            this.visualCheckedListBox1.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.visualCheckedListBox1.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.visualCheckedListBox1.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.visualCheckedListBox1.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.visualCheckedListBox1.Border.HoverVisible = true;
            this.visualCheckedListBox1.Border.Rounding = 6;
            this.visualCheckedListBox1.Border.Thickness = 1;
            this.visualCheckedListBox1.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.visualCheckedListBox1.Border.Visible = true;
            this.visualCheckedListBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.visualCheckedListBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualCheckedListBox1.FormatString = "";
            this.visualCheckedListBox1.HorizontalExtent = 0;
            this.visualCheckedListBox1.HorizontalScrollbar = false;
            this.visualCheckedListBox1.ItemNormal = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.visualCheckedListBox1.ItemSelected = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.visualCheckedListBox1.Location = new System.Drawing.Point(493, 12);
            this.visualCheckedListBox1.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualCheckedListBox1.Name = "visualCheckedListBox1";
            this.visualCheckedListBox1.SelectionMode = System.Windows.Forms.SelectionMode.One;
            this.visualCheckedListBox1.Size = new System.Drawing.Size(635, 370);
            this.visualCheckedListBox1.TabIndex = 0;
            this.visualCheckedListBox1.Text = "visualCheckedListBox1";
            textStyle4.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle4.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle4.Hover = System.Drawing.Color.Empty;
            textStyle4.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.visualCheckedListBox1.TextStyle = textStyle4;
            this.visualCheckedListBox1.SelectedIndexChanged += new System.EventHandler(this.VisualCheckedListBox1_SelectedIndexChanged);
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
            textStyle5.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle5.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle5.Hover = System.Drawing.Color.Empty;
            textStyle5.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btPlay.TextStyle = textStyle5;
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
            this.btLoadFolder.Location = new System.Drawing.Point(493, 388);
            this.btLoadFolder.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.btLoadFolder.Name = "btLoadFolder";
            this.btLoadFolder.Size = new System.Drawing.Size(140, 45);
            this.btLoadFolder.TabIndex = 2;
            this.btLoadFolder.Text = "Load Music";
            this.btLoadFolder.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btLoadFolder.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.btLoadFolder.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle6.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle6.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle6.Hover = System.Drawing.Color.Empty;
            textStyle6.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btLoadFolder.TextStyle = textStyle6;
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
            textStyle7.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle7.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle7.Hover = System.Drawing.Color.Empty;
            textStyle7.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btStop.TextStyle = textStyle7;
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
            textStyle1.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle1.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle1.Hover = System.Drawing.Color.Empty;
            textStyle1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.visualLabelVolume.TextStyle = textStyle1;
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
            textStyle2.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle2.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle2.Hover = System.Drawing.Color.Empty;
            textStyle2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.visualLabel1.TextStyle = textStyle2;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 555);
            this.Controls.Add(this.seekBar);
            this.Controls.Add(this.visualLabel1);
            this.Controls.Add(this.visualLabelVolume);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btLoadFolder);
            this.Controls.Add(this.btPlay);
            this.Controls.Add(this.visualCheckedListBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seekBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VisualPlus.Toolkit.Controls.DataManagement.VisualCheckedListBox visualCheckedListBox1;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualButton btPlay;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualButton btLoadFolder;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualButton btStop;
        private System.Windows.Forms.TrackBar trackBar1;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualLabel visualLabelVolume;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualLabel visualLabel1;
        private System.Windows.Forms.Timer timeElapsed;
        private System.Windows.Forms.TrackBar seekBar;
    }
}

