namespace SalaryManager
{
    partial class EditEmpyeeForm
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
            this.EditEF_Save_Button = new MaterialSkin.Controls.MaterialButton();
            this.EditEF_Cancel_Button = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // EditEF_Save_Button
            // 
            this.EditEF_Save_Button.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.EditEF_Save_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EditEF_Save_Button.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.EditEF_Save_Button.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.EditEF_Save_Button.Depth = 0;
            this.EditEF_Save_Button.HighEmphasis = true;
            this.EditEF_Save_Button.Icon = null;
            this.EditEF_Save_Button.Location = new System.Drawing.Point(481, 618);
            this.EditEF_Save_Button.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.EditEF_Save_Button.MouseState = MaterialSkin.MouseState.HOVER;
            this.EditEF_Save_Button.Name = "EditEF_Save_Button";
            this.EditEF_Save_Button.NoAccentTextColor = System.Drawing.Color.Empty;
            this.EditEF_Save_Button.Size = new System.Drawing.Size(64, 36);
            this.EditEF_Save_Button.TabIndex = 0;
            this.EditEF_Save_Button.Text = "保存";
            this.EditEF_Save_Button.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.EditEF_Save_Button.UseAccentColor = false;
            this.EditEF_Save_Button.UseVisualStyleBackColor = true;
            this.EditEF_Save_Button.Click += new System.EventHandler(this.EditEF_Save_Button_Click);
            // 
            // EditEF_Cancel_Button
            // 
            this.EditEF_Cancel_Button.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.EditEF_Cancel_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EditEF_Cancel_Button.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.EditEF_Cancel_Button.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.EditEF_Cancel_Button.Depth = 0;
            this.EditEF_Cancel_Button.HighEmphasis = true;
            this.EditEF_Cancel_Button.Icon = null;
            this.EditEF_Cancel_Button.Location = new System.Drawing.Point(562, 618);
            this.EditEF_Cancel_Button.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.EditEF_Cancel_Button.MouseState = MaterialSkin.MouseState.HOVER;
            this.EditEF_Cancel_Button.Name = "EditEF_Cancel_Button";
            this.EditEF_Cancel_Button.NoAccentTextColor = System.Drawing.Color.Empty;
            this.EditEF_Cancel_Button.Size = new System.Drawing.Size(64, 36);
            this.EditEF_Cancel_Button.TabIndex = 1;
            this.EditEF_Cancel_Button.Text = "取消";
            this.EditEF_Cancel_Button.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.EditEF_Cancel_Button.UseAccentColor = false;
            this.EditEF_Cancel_Button.UseVisualStyleBackColor = true;
            this.EditEF_Cancel_Button.Click += new System.EventHandler(this.EditEF_Cancel_Button_Click);
            // 
            // EditEmpyeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 675);
            this.Controls.Add(this.EditEF_Cancel_Button);
            this.Controls.Add(this.EditEF_Save_Button);
            this.Name = "EditEmpyeeForm";
            this.Text = "EditEmpyeeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton EditEF_Save_Button;
        private MaterialSkin.Controls.MaterialButton EditEF_Cancel_Button;
    }
}