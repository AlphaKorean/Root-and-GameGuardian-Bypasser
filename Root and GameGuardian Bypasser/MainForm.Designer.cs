namespace 좀비고_보안_우회
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lbAlpha = new MaterialSkin.Controls.MaterialLabel();
            this.btnBypassOff = new MaterialSkin.Controls.MaterialButton();
            this.btnBypassOn = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // lbAlpha
            // 
            this.lbAlpha.AutoSize = true;
            this.lbAlpha.Depth = 0;
            this.lbAlpha.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbAlpha.Location = new System.Drawing.Point(12, 9);
            this.lbAlpha.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbAlpha.Name = "lbAlpha";
            this.lbAlpha.Size = new System.Drawing.Size(108, 19);
            this.lbAlpha.TabIndex = 2;
            this.lbAlpha.Text = "Made By Alpha";
            // 
            // btnBypassOff
            // 
            this.btnBypassOff.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBypassOff.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBypassOff.Depth = 0;
            this.btnBypassOff.HighEmphasis = true;
            this.btnBypassOff.Icon = null;
            this.btnBypassOff.Location = new System.Drawing.Point(12, 89);
            this.btnBypassOff.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBypassOff.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBypassOff.Name = "btnBypassOff";
            this.btnBypassOff.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBypassOff.Size = new System.Drawing.Size(119, 36);
            this.btnBypassOff.TabIndex = 3;
            this.btnBypassOff.Text = "보안 우회 Off";
            this.btnBypassOff.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBypassOff.UseAccentColor = false;
            this.btnBypassOff.UseVisualStyleBackColor = true;
            this.btnBypassOff.Click += new System.EventHandler(this.btnBypassOff_Click);
            // 
            // btnBypassOn
            // 
            this.btnBypassOn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBypassOn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBypassOn.Depth = 0;
            this.btnBypassOn.HighEmphasis = true;
            this.btnBypassOn.Icon = null;
            this.btnBypassOn.Location = new System.Drawing.Point(12, 41);
            this.btnBypassOn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBypassOn.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBypassOn.Name = "btnBypassOn";
            this.btnBypassOn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBypassOn.Size = new System.Drawing.Size(113, 36);
            this.btnBypassOn.TabIndex = 3;
            this.btnBypassOn.Text = "보안 우회 On";
            this.btnBypassOn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBypassOn.UseAccentColor = false;
            this.btnBypassOn.UseVisualStyleBackColor = true;
            this.btnBypassOn.Click += new System.EventHandler(this.btnBypassOn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(150, 140);
            this.Controls.Add(this.btnBypassOn);
            this.Controls.Add(this.btnBypassOff);
            this.Controls.Add(this.lbAlpha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(166, 179);
            this.MinimumSize = new System.Drawing.Size(166, 179);
            this.Name = "MainForm";
            this.Text = "Game Security Bypass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel lbAlpha;
        private MaterialSkin.Controls.MaterialButton btnBypassOff;
        private MaterialSkin.Controls.MaterialButton btnBypassOn;
    }
}