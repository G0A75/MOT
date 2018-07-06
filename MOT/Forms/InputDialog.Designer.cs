namespace MOT.Forms
{
    partial class InputDialog
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
            this.tbInput = new VisualPlus.Toolkit.Controls.Editors.VisualTextBox();
            this.btOK = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
            this.SuspendLayout();
            // 
            // tbInput
            // 
            this.tbInput.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.tbInput.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.tbInput.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.tbInput.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.tbInput.Border.HoverVisible = true;
            this.tbInput.Border.Rounding = 6;
            this.tbInput.Border.Thickness = 1;
            this.tbInput.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.tbInput.Border.Visible = true;
            this.tbInput.ButtonBorder.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.tbInput.ButtonBorder.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.tbInput.ButtonBorder.HoverVisible = true;
            this.tbInput.ButtonBorder.Rounding = 6;
            this.tbInput.ButtonBorder.Thickness = 1;
            this.tbInput.ButtonBorder.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.tbInput.ButtonBorder.Visible = true;
            this.tbInput.ButtonColor.Disabled = System.Drawing.Color.Empty;
            this.tbInput.ButtonColor.Enabled = System.Drawing.Color.Empty;
            this.tbInput.ButtonColor.Hover = System.Drawing.Color.Empty;
            this.tbInput.ButtonColor.Pressed = System.Drawing.Color.Empty;
            this.tbInput.ButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInput.ButtonIndent = 3;
            this.tbInput.ButtonText = "visualButton";
            this.tbInput.ButtonVisible = false;
            this.tbInput.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.tbInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbInput.ImageSize = new System.Drawing.Size(16, 16);
            this.tbInput.ImageVisible = false;
            this.tbInput.ImageWidth = 35;
            this.tbInput.Location = new System.Drawing.Point(12, 12);
            this.tbInput.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.tbInput.Name = "tbInput";
            this.tbInput.PasswordChar = '\0';
            this.tbInput.ReadOnly = false;
            this.tbInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbInput.Size = new System.Drawing.Size(247, 25);
            this.tbInput.TabIndex = 0;
            this.tbInput.TextBoxWidth = 237;
            textStyle1.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle1.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle1.Hover = System.Drawing.Color.Empty;
            textStyle1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.tbInput.TextStyle = textStyle1;
            this.tbInput.Watermark.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tbInput.Watermark.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.tbInput.Watermark.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.tbInput.Watermark.Text = "Enter your input...";
            this.tbInput.Watermark.Visible = true;
            this.tbInput.TextChanged += new System.EventHandler(this.TbInput_TextChanged);
            // 
            // btOK
            // 
            this.btOK.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btOK.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.btOK.BackColorState.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btOK.BackColorState.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btOK.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btOK.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.btOK.Border.HoverVisible = true;
            this.btOK.Border.Rounding = 6;
            this.btOK.Border.Thickness = 1;
            this.btOK.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.btOK.Border.Visible = true;
            this.btOK.Enabled = false;
            this.btOK.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btOK.Image = null;
            this.btOK.Location = new System.Drawing.Point(184, 43);
            this.btOK.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 25);
            this.btOK.TabIndex = 1;
            this.btOK.Text = "OK";
            this.btOK.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btOK.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.btOK.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle2.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle2.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle2.Hover = System.Drawing.Color.Empty;
            textStyle2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btOK.TextStyle = textStyle2;
            this.btOK.Click += new System.EventHandler(this.BtOK_Click);
            // 
            // InputDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 81);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.tbInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InputDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "InputDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private VisualPlus.Toolkit.Controls.Interactivity.VisualButton btOK;
        private VisualPlus.Toolkit.Controls.Editors.VisualTextBox tbInput;
    }
}