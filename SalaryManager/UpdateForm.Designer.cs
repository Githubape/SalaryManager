namespace SalaryManager
{
    partial class UpdateForm
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
            this.EditPostSave_Button = new MaterialSkin.Controls.MaterialButton();
            this.EditPostCencal_Button = new MaterialSkin.Controls.MaterialButton();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // EditPostSave_Button
            // 
            this.EditPostSave_Button.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.EditPostSave_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EditPostSave_Button.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.EditPostSave_Button.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.EditPostSave_Button.Depth = 0;
            this.EditPostSave_Button.HighEmphasis = true;
            this.EditPostSave_Button.Icon = null;
            this.EditPostSave_Button.Location = new System.Drawing.Point(314, 425);
            this.EditPostSave_Button.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.EditPostSave_Button.MouseState = MaterialSkin.MouseState.HOVER;
            this.EditPostSave_Button.Name = "EditPostSave_Button";
            this.EditPostSave_Button.NoAccentTextColor = System.Drawing.Color.Empty;
            this.EditPostSave_Button.Size = new System.Drawing.Size(79, 36);
            this.EditPostSave_Button.TabIndex = 0;
            this.EditPostSave_Button.Text = "确定更改";
            this.EditPostSave_Button.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.EditPostSave_Button.UseAccentColor = false;
            this.EditPostSave_Button.UseVisualStyleBackColor = true;
            // 
            // EditPostCencal_Button
            // 
            this.EditPostCencal_Button.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.EditPostCencal_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EditPostCencal_Button.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.EditPostCencal_Button.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.EditPostCencal_Button.Depth = 0;
            this.EditPostCencal_Button.HighEmphasis = true;
            this.EditPostCencal_Button.Icon = null;
            this.EditPostCencal_Button.Location = new System.Drawing.Point(401, 425);
            this.EditPostCencal_Button.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.EditPostCencal_Button.MouseState = MaterialSkin.MouseState.HOVER;
            this.EditPostCencal_Button.Name = "EditPostCencal_Button";
            this.EditPostCencal_Button.NoAccentTextColor = System.Drawing.Color.Empty;
            this.EditPostCencal_Button.Size = new System.Drawing.Size(64, 36);
            this.EditPostCencal_Button.TabIndex = 1;
            this.EditPostCencal_Button.Text = "取消";
            this.EditPostCencal_Button.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.EditPostCencal_Button.UseAccentColor = false;
            this.EditPostCencal_Button.UseVisualStyleBackColor = true;
            this.EditPostCencal_Button.Click += new System.EventHandler(this.EditPostCencal_Button_Click);
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Font = new System.Drawing.Font("思源黑体 CN Regular", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox1.Hint = "姓名";
            this.materialTextBox1.LeadingIcon = null;
            this.materialTextBox1.Location = new System.Drawing.Point(32, 109);
            this.materialTextBox1.MaxLength = 50;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(76, 50);
            this.materialTextBox1.TabIndex = 2;
            this.materialTextBox1.Text = "";
            this.materialTextBox1.TrailingIcon = null;
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 470);
            this.Controls.Add(this.materialTextBox1);
            this.Controls.Add(this.EditPostCencal_Button);
            this.Controls.Add(this.EditPostSave_Button);
            this.Name = "UpdateForm";
            this.Text = "晋档管理";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton EditPostSave_Button;
        private MaterialSkin.Controls.MaterialButton EditPostCencal_Button;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
    }
}