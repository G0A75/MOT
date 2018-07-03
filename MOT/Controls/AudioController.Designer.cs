namespace MOT.Controls
{
    partial class AudioController
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

        #region Component Designer generated code

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
            this.btPlay = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
            this.lCurrent = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
            this.lDurationTotal = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
            this.tbTimeLine = new System.Windows.Forms.TrackBar();
            this.lTitle = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
            this.pbVolume = new VisualPlus.Toolkit.Controls.DataVisualization.VisualProgressBar();
            this.visualLabel1 = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
            ((System.ComponentModel.ISupportInitialize)(this.tbTimeLine)).BeginInit();
            this.SuspendLayout();
            // 
            // btPlay
            // 
            this.btPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btPlay.Border.Visible = false;
            this.btPlay.Enabled = false;
            this.btPlay.Font = new System.Drawing.Font("Webdings", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btPlay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btPlay.Image = null;
            this.btPlay.Location = new System.Drawing.Point(508, 20);
            this.btPlay.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.btPlay.Name = "btPlay";
            this.btPlay.Size = new System.Drawing.Size(53, 45);
            this.btPlay.TabIndex = 0;
            this.btPlay.Text = "4";
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
            // lCurrent
            // 
            this.lCurrent.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lCurrent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lCurrent.Location = new System.Drawing.Point(3, 122);
            this.lCurrent.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.lCurrent.Name = "lCurrent";
            this.lCurrent.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.lCurrent.Outline = false;
            this.lCurrent.OutlineColor = System.Drawing.Color.Red;
            this.lCurrent.OutlineLocation = new System.Drawing.Point(0, 0);
            this.lCurrent.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lCurrent.ReflectionSpacing = 0;
            this.lCurrent.ShadowColor = System.Drawing.Color.Black;
            this.lCurrent.ShadowDirection = 315;
            this.lCurrent.ShadowLocation = new System.Drawing.Point(0, 0);
            this.lCurrent.ShadowOpacity = 100;
            this.lCurrent.Size = new System.Drawing.Size(75, 23);
            this.lCurrent.TabIndex = 3;
            this.lCurrent.Text = "00 : 00 : 00";
            this.lCurrent.TextAlignment = System.Drawing.StringAlignment.Center;
            this.lCurrent.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle2.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle2.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle2.Hover = System.Drawing.Color.Empty;
            textStyle2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.lCurrent.TextStyle = textStyle2;
            // 
            // lDurationTotal
            // 
            this.lDurationTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lDurationTotal.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lDurationTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lDurationTotal.Location = new System.Drawing.Point(486, 122);
            this.lDurationTotal.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.lDurationTotal.Name = "lDurationTotal";
            this.lDurationTotal.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.lDurationTotal.Outline = false;
            this.lDurationTotal.OutlineColor = System.Drawing.Color.Red;
            this.lDurationTotal.OutlineLocation = new System.Drawing.Point(0, 0);
            this.lDurationTotal.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lDurationTotal.ReflectionSpacing = 0;
            this.lDurationTotal.ShadowColor = System.Drawing.Color.Black;
            this.lDurationTotal.ShadowDirection = 315;
            this.lDurationTotal.ShadowLocation = new System.Drawing.Point(0, 0);
            this.lDurationTotal.ShadowOpacity = 100;
            this.lDurationTotal.Size = new System.Drawing.Size(75, 23);
            this.lDurationTotal.TabIndex = 4;
            this.lDurationTotal.Text = "00 : 00 : 00";
            this.lDurationTotal.TextAlignment = System.Drawing.StringAlignment.Center;
            this.lDurationTotal.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle3.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle3.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle3.Hover = System.Drawing.Color.Empty;
            textStyle3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.lDurationTotal.TextStyle = textStyle3;
            // 
            // tbTimeLine
            // 
            this.tbTimeLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTimeLine.BackColor = System.Drawing.Color.Gainsboro;
            this.tbTimeLine.Enabled = false;
            this.tbTimeLine.Location = new System.Drawing.Point(3, 71);
            this.tbTimeLine.Maximum = 1;
            this.tbTimeLine.Name = "tbTimeLine";
            this.tbTimeLine.Size = new System.Drawing.Size(558, 45);
            this.tbTimeLine.TabIndex = 5;
            this.tbTimeLine.Scroll += new System.EventHandler(this.TbTimeLine_Scroll);
            // 
            // lTitle
            // 
            this.lTitle.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lTitle.Location = new System.Drawing.Point(22, 25);
            this.lTitle.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.lTitle.Name = "lTitle";
            this.lTitle.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.lTitle.Outline = false;
            this.lTitle.OutlineColor = System.Drawing.Color.Red;
            this.lTitle.OutlineLocation = new System.Drawing.Point(0, 0);
            this.lTitle.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lTitle.ReflectionSpacing = 0;
            this.lTitle.ShadowColor = System.Drawing.Color.Black;
            this.lTitle.ShadowDirection = 315;
            this.lTitle.ShadowLocation = new System.Drawing.Point(0, 0);
            this.lTitle.ShadowOpacity = 100;
            this.lTitle.Size = new System.Drawing.Size(458, 32);
            this.lTitle.TabIndex = 6;
            this.lTitle.Text = "Open audio...";
            this.lTitle.TextAlignment = System.Drawing.StringAlignment.Near;
            this.lTitle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle4.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle4.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle4.Hover = System.Drawing.Color.Empty;
            textStyle4.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.lTitle.TextStyle = textStyle4;
            // 
            // pbVolume
            // 
            this.pbVolume.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pbVolume.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.pbVolume.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.pbVolume.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.pbVolume.Border.HoverVisible = true;
            this.pbVolume.Border.Rounding = 6;
            this.pbVolume.Border.Thickness = 1;
            this.pbVolume.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.pbVolume.Border.Visible = true;
            this.pbVolume.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.pbVolume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pbVolume.Hatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pbVolume.Hatch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pbVolume.Hatch.Size = new System.Drawing.Size(2, 2);
            this.pbVolume.Hatch.Style = System.Drawing.Drawing2D.HatchStyle.DarkDownwardDiagonal;
            this.pbVolume.Hatch.Visible = true;
            this.pbVolume.LargeChange = 5;
            this.pbVolume.Location = new System.Drawing.Point(139, 123);
            this.pbVolume.MarqueeWidth = 20;
            this.pbVolume.Maximum = 100;
            this.pbVolume.Minimum = 0;
            this.pbVolume.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.pbVolume.Name = "pbVolume";
            this.pbVolume.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.pbVolume.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(136)))), ((int)(((byte)(45)))));
            this.pbVolume.ProgressImage = null;
            this.pbVolume.Size = new System.Drawing.Size(100, 20);
            this.pbVolume.SmallChange = 1;
            this.pbVolume.Style = System.Windows.Forms.ProgressBarStyle.Blocks;
            this.pbVolume.TabIndex = 7;
            this.pbVolume.Text = "visualProgressBar1";
            textStyle5.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle5.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle5.Hover = System.Drawing.Color.Empty;
            textStyle5.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.pbVolume.TextStyle = textStyle5;
            this.pbVolume.Value = 0;
            this.pbVolume.ValueAlignment = System.Drawing.StringAlignment.Center;
            // 
            // visualLabel1
            // 
            this.visualLabel1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.visualLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualLabel1.Location = new System.Drawing.Point(84, 122);
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
            this.visualLabel1.Size = new System.Drawing.Size(49, 23);
            this.visualLabel1.TabIndex = 8;
            this.visualLabel1.Text = "Volume:";
            this.visualLabel1.TextAlignment = System.Drawing.StringAlignment.Near;
            this.visualLabel1.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle6.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle6.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle6.Hover = System.Drawing.Color.Empty;
            textStyle6.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.visualLabel1.TextStyle = textStyle6;
            // 
            // AudioController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.visualLabel1);
            this.Controls.Add(this.pbVolume);
            this.Controls.Add(this.lTitle);
            this.Controls.Add(this.tbTimeLine);
            this.Controls.Add(this.lDurationTotal);
            this.Controls.Add(this.lCurrent);
            this.Controls.Add(this.btPlay);
            this.Name = "AudioController";
            this.Size = new System.Drawing.Size(564, 155);
            ((System.ComponentModel.ISupportInitialize)(this.tbTimeLine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VisualPlus.Toolkit.Controls.Interactivity.VisualButton btPlay;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualLabel lCurrent;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualLabel lDurationTotal;
        private System.Windows.Forms.TrackBar tbTimeLine;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualLabel lTitle;
        private VisualPlus.Toolkit.Controls.DataVisualization.VisualProgressBar pbVolume;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualLabel visualLabel1;
    }
}
