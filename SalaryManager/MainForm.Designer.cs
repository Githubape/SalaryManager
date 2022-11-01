namespace SalaryManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TabControl_Top = new MaterialSkin.Controls.MaterialTabControl();
            this.rsgl = new System.Windows.Forms.TabPage();
            this.gzgl = new System.Windows.Forms.TabPage();
            this.cgsz = new System.Windows.Forms.TabPage();
            this.rsgl_Tab = new MaterialSkin.Controls.MaterialTabControl();
            this.jsjdgl = new System.Windows.Forms.TabPage();
            this.bdls = new System.Windows.Forms.TabPage();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.TabControl_Top.SuspendLayout();
            this.rsgl.SuspendLayout();
            this.rsgl_Tab.SuspendLayout();
            this.bdls.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl_Top
            // 
            this.TabControl_Top.Controls.Add(this.rsgl);
            this.TabControl_Top.Controls.Add(this.gzgl);
            this.TabControl_Top.Controls.Add(this.cgsz);
            this.TabControl_Top.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TabControl_Top.Depth = 0;
            this.TabControl_Top.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TabControl_Top.Location = new System.Drawing.Point(-4, 67);
            this.TabControl_Top.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabControl_Top.Multiline = true;
            this.TabControl_Top.Name = "TabControl_Top";
            this.TabControl_Top.SelectedIndex = 0;
            this.TabControl_Top.Size = new System.Drawing.Size(1130, 561);
            this.TabControl_Top.TabIndex = 0;
            // 
            // rsgl
            // 
            this.rsgl.Controls.Add(this.materialTabSelector1);
            this.rsgl.Controls.Add(this.rsgl_Tab);
            this.rsgl.Location = new System.Drawing.Point(4, 26);
            this.rsgl.Name = "rsgl";
            this.rsgl.Padding = new System.Windows.Forms.Padding(3);
            this.rsgl.Size = new System.Drawing.Size(1122, 531);
            this.rsgl.TabIndex = 0;
            this.rsgl.Text = "人事管理";
            this.rsgl.UseVisualStyleBackColor = true;
            this.rsgl.Click += new System.EventHandler(this.rsgl_Click);
            // 
            // gzgl
            // 
            this.gzgl.Location = new System.Drawing.Point(4, 26);
            this.gzgl.Name = "gzgl";
            this.gzgl.Padding = new System.Windows.Forms.Padding(3);
            this.gzgl.Size = new System.Drawing.Size(1122, 531);
            this.gzgl.TabIndex = 2;
            this.gzgl.Text = "工资管理";
            this.gzgl.UseVisualStyleBackColor = true;
            this.gzgl.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // cgsz
            // 
            this.cgsz.Location = new System.Drawing.Point(4, 26);
            this.cgsz.Name = "cgsz";
            this.cgsz.Padding = new System.Windows.Forms.Padding(3);
            this.cgsz.Size = new System.Drawing.Size(1122, 531);
            this.cgsz.TabIndex = 3;
            this.cgsz.Text = "常规设置";
            this.cgsz.UseVisualStyleBackColor = true;
            // 
            // rsgl_Tab
            // 
            this.rsgl_Tab.Controls.Add(this.jsjdgl);
            this.rsgl_Tab.Controls.Add(this.bdls);
            this.rsgl_Tab.Depth = 0;
            this.rsgl_Tab.Location = new System.Drawing.Point(269, 90);
            this.rsgl_Tab.MouseState = MaterialSkin.MouseState.HOVER;
            this.rsgl_Tab.Multiline = true;
            this.rsgl_Tab.Name = "rsgl_Tab";
            this.rsgl_Tab.SelectedIndex = 0;
            this.rsgl_Tab.Size = new System.Drawing.Size(807, 384);
            this.rsgl_Tab.TabIndex = 0;
            // 
            // jsjdgl
            // 
            this.jsjdgl.Location = new System.Drawing.Point(4, 26);
            this.jsjdgl.Name = "jsjdgl";
            this.jsjdgl.Padding = new System.Windows.Forms.Padding(3);
            this.jsjdgl.Size = new System.Drawing.Size(799, 354);
            this.jsjdgl.TabIndex = 0;
            this.jsjdgl.Text = "晋升晋档管理";
            this.jsjdgl.UseVisualStyleBackColor = true;
            // 
            // bdls
            // 
            this.bdls.Controls.Add(this.materialTextBox1);
            this.bdls.Location = new System.Drawing.Point(4, 26);
            this.bdls.Name = "bdls";
            this.bdls.Padding = new System.Windows.Forms.Padding(3);
            this.bdls.Size = new System.Drawing.Size(799, 354);
            this.bdls.TabIndex = 1;
            this.bdls.Text = "变动历史";
            this.bdls.UseVisualStyleBackColor = true;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.rsgl_Tab;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Font = new System.Drawing.Font("思源黑体 CN Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 0);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1122, 47);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Font = new System.Drawing.Font("思源黑体 CN Regular", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox1.LeadingIcon = null;
            this.materialTextBox1.Location = new System.Drawing.Point(127, 131);
            this.materialTextBox1.MaxLength = 50;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(615, 50);
            this.materialTextBox1.TabIndex = 0;
            this.materialTextBox1.Text = "";
            this.materialTextBox1.TrailingIcon = null;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 634);
            this.Controls.Add(this.TabControl_Top);
            this.DrawerBackgroundWithAccent = true;
            this.DrawerTabControl = this.TabControl_Top;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(100, 50);
            this.Name = "MainForm";
            this.Text = "工资结算助手";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TabControl_Top.ResumeLayout(false);
            this.rsgl.ResumeLayout(false);
            this.rsgl_Tab.ResumeLayout(false);
            this.bdls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage rsgl;
        private System.Windows.Forms.TabPage gzgl;
        private System.Windows.Forms.TabPage cgsz;
        private MaterialSkin.Controls.MaterialTabControl TabControl_Top;
        private MaterialSkin.Controls.MaterialTabControl rsgl_Tab;
        private System.Windows.Forms.TabPage jsjdgl;
        private System.Windows.Forms.TabPage bdls;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
    }
}