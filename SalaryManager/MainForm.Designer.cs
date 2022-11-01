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
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.rsgl_Tab = new MaterialSkin.Controls.MaterialTabControl();
            this.jsjdgl = new System.Windows.Forms.TabPage();
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bdls = new System.Windows.Forms.TabPage();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gzgl = new System.Windows.Forms.TabPage();
            this.cgsz = new System.Windows.Forms.TabPage();
            this.TabControl_Top.SuspendLayout();
            this.rsgl.SuspendLayout();
            this.rsgl_Tab.SuspendLayout();
            this.jsjdgl.SuspendLayout();
            this.bdls.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl_Top
            // 
            this.TabControl_Top.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.TabControl_Top.Controls.Add(this.rsgl);
            this.TabControl_Top.Controls.Add(this.gzgl);
            this.TabControl_Top.Controls.Add(this.cgsz);
            this.TabControl_Top.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TabControl_Top.Depth = 0;
            this.TabControl_Top.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TabControl_Top.Location = new System.Drawing.Point(6, 67);
            this.TabControl_Top.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabControl_Top.Multiline = true;
            this.TabControl_Top.Name = "TabControl_Top";
            this.TabControl_Top.SelectedIndex = 0;
            this.TabControl_Top.Size = new System.Drawing.Size(1214, 637);
            this.TabControl_Top.TabIndex = 0;
            // 
            // rsgl
            // 
            this.rsgl.Controls.Add(this.materialTabSelector1);
            this.rsgl.Controls.Add(this.rsgl_Tab);
            this.rsgl.Location = new System.Drawing.Point(4, 4);
            this.rsgl.Name = "rsgl";
            this.rsgl.Padding = new System.Windows.Forms.Padding(3);
            this.rsgl.Size = new System.Drawing.Size(1206, 607);
            this.rsgl.TabIndex = 0;
            this.rsgl.Text = "人事管理";
            this.rsgl.UseVisualStyleBackColor = true;
            this.rsgl.Click += new System.EventHandler(this.rsgl_Click);
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.rsgl_Tab;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Font = new System.Drawing.Font("思源黑体 CN Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector1.Location = new System.Drawing.Point(-13, -4);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1219, 32);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // rsgl_Tab
            // 
            this.rsgl_Tab.Controls.Add(this.jsjdgl);
            this.rsgl_Tab.Controls.Add(this.bdls);
            this.rsgl_Tab.Controls.Add(this.tabPage1);
            this.rsgl_Tab.Depth = 0;
            this.rsgl_Tab.Location = new System.Drawing.Point(3, 34);
            this.rsgl_Tab.MouseState = MaterialSkin.MouseState.HOVER;
            this.rsgl_Tab.Multiline = true;
            this.rsgl_Tab.Name = "rsgl_Tab";
            this.rsgl_Tab.SelectedIndex = 0;
            this.rsgl_Tab.Size = new System.Drawing.Size(1207, 577);
            this.rsgl_Tab.TabIndex = 0;
            // 
            // jsjdgl
            // 
            this.jsjdgl.Controls.Add(this.materialListView1);
            this.jsjdgl.Location = new System.Drawing.Point(4, 26);
            this.jsjdgl.Name = "jsjdgl";
            this.jsjdgl.Padding = new System.Windows.Forms.Padding(3);
            this.jsjdgl.Size = new System.Drawing.Size(1199, 547);
            this.jsjdgl.TabIndex = 0;
            this.jsjdgl.Text = "人员信息";
            this.jsjdgl.UseVisualStyleBackColor = true;
            // 
            // materialListView1
            // 
            this.materialListView1.AutoSizeTable = false;
            this.materialListView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.materialListView1.Depth = 0;
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.HideSelection = false;
            this.materialListView1.Location = new System.Drawing.Point(0, 96);
            this.materialListView1.MinimumSize = new System.Drawing.Size(200, 100);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(1196, 451);
            this.materialListView1.TabIndex = 0;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            this.materialListView1.SelectedIndexChanged += new System.EventHandler(this.materialListView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "编号";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "姓名";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "性别";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "银行卡号";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "组";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "工种";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "入职时间";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 120;
            // 
            // bdls
            // 
            this.bdls.Controls.Add(this.materialTextBox1);
            this.bdls.Location = new System.Drawing.Point(4, 26);
            this.bdls.Name = "bdls";
            this.bdls.Padding = new System.Windows.Forms.Padding(3);
            this.bdls.Size = new System.Drawing.Size(1199, 547);
            this.bdls.TabIndex = 1;
            this.bdls.Text = "变动历史";
            this.bdls.UseVisualStyleBackColor = true;
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
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1199, 547);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "晋档管理";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gzgl
            // 
            this.gzgl.Location = new System.Drawing.Point(4, 4);
            this.gzgl.Name = "gzgl";
            this.gzgl.Padding = new System.Windows.Forms.Padding(3);
            this.gzgl.Size = new System.Drawing.Size(1206, 607);
            this.gzgl.TabIndex = 2;
            this.gzgl.Text = "工资管理";
            this.gzgl.UseVisualStyleBackColor = true;
            this.gzgl.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // cgsz
            // 
            this.cgsz.Location = new System.Drawing.Point(4, 4);
            this.cgsz.Name = "cgsz";
            this.cgsz.Padding = new System.Windows.Forms.Padding(3);
            this.cgsz.Size = new System.Drawing.Size(1206, 607);
            this.cgsz.TabIndex = 3;
            this.cgsz.Text = "常规设置";
            this.cgsz.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1219, 701);
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
            this.jsjdgl.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage tabPage1;
        private MaterialSkin.Controls.MaterialListView materialListView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}