﻿namespace SalaryManager
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
            this.bhss = new MaterialSkin.Controls.MaterialTextBox();
            this.Add_Btn = new MaterialSkin.Controls.MaterialButton();
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
            this.xmss = new MaterialSkin.Controls.MaterialTextBox();
            this.Search_Btn = new MaterialSkin.Controls.MaterialButton();
            this.gzss = new MaterialSkin.Controls.MaterialTextBox();
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
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 0);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1219, 32);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
            this.materialTabSelector1.Click += new System.EventHandler(this.materialTabSelector1_Click_2);
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
            this.jsjdgl.Controls.Add(this.gzss);
            this.jsjdgl.Controls.Add(this.Search_Btn);
            this.jsjdgl.Controls.Add(this.xmss);
            this.jsjdgl.Controls.Add(this.bhss);
            this.jsjdgl.Controls.Add(this.Add_Btn);
            this.jsjdgl.Controls.Add(this.materialListView1);
            this.jsjdgl.Location = new System.Drawing.Point(4, 26);
            this.jsjdgl.Name = "jsjdgl";
            this.jsjdgl.Padding = new System.Windows.Forms.Padding(3);
            this.jsjdgl.Size = new System.Drawing.Size(1199, 547);
            this.jsjdgl.TabIndex = 0;
            this.jsjdgl.Text = "人员信息";
            // 
            // bhss
            // 
            this.bhss.BackColor = System.Drawing.SystemColors.Window;
            this.bhss.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bhss.Depth = 0;
            this.bhss.Font = new System.Drawing.Font("思源黑体 CN Regular", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.bhss.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bhss.LeadingIcon = null;
            this.bhss.Location = new System.Drawing.Point(157, 26);
            this.bhss.MaxLength = 100;
            this.bhss.MouseState = MaterialSkin.MouseState.OUT;
            this.bhss.Multiline = false;
            this.bhss.Name = "bhss";
            this.bhss.Size = new System.Drawing.Size(230, 36);
            this.bhss.TabIndex = 3;
            this.bhss.Text = "";
            this.bhss.TrailingIcon = null;
            this.bhss.UseTallSize = false;
            this.bhss.TextChanged += new System.EventHandler(this.materialTextBox2_TextChanged);
            // 
            // Add_Btn
            // 
            this.Add_Btn.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.Add_Btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Add_Btn.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.Add_Btn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Add_Btn.Depth = 0;
            this.Add_Btn.HighEmphasis = true;
            this.Add_Btn.Icon = null;
            this.Add_Btn.Location = new System.Drawing.Point(66, 27);
            this.Add_Btn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Add_Btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.Add_Btn.Name = "Add_Btn";
            this.Add_Btn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Add_Btn.Size = new System.Drawing.Size(64, 36);
            this.Add_Btn.TabIndex = 1;
            this.Add_Btn.Text = "添加";
            this.Add_Btn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Add_Btn.UseAccentColor = false;
            this.Add_Btn.UseVisualStyleBackColor = true;
            this.Add_Btn.Click += new System.EventHandler(this.materialButton1_Click);
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
            this.materialListView1.Location = new System.Drawing.Point(6, 138);
            this.materialListView1.MinimumSize = new System.Drawing.Size(200, 100);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(1161, 100);
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
            // xmss
            // 
            this.xmss.BackColor = System.Drawing.SystemColors.Window;
            this.xmss.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.xmss.Depth = 0;
            this.xmss.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.xmss.ForeColor = System.Drawing.SystemColors.Window;
            this.xmss.LeadingIcon = null;
            this.xmss.Location = new System.Drawing.Point(651, 27);
            this.xmss.Margin = new System.Windows.Forms.Padding(0);
            this.xmss.MaxLength = 100;
            this.xmss.MouseState = MaterialSkin.MouseState.OUT;
            this.xmss.Multiline = false;
            this.xmss.Name = "xmss";
            this.xmss.Size = new System.Drawing.Size(164, 36);
            this.xmss.TabIndex = 4;
            this.xmss.Text = "";
            this.xmss.TrailingIcon = null;
            this.xmss.UseTallSize = false;
            // 
            // Search_Btn
            // 
            this.Search_Btn.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.Search_Btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Search_Btn.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.Search_Btn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Search_Btn.Depth = 0;
            this.Search_Btn.HighEmphasis = true;
            this.Search_Btn.Icon = null;
            this.Search_Btn.Location = new System.Drawing.Point(848, 26);
            this.Search_Btn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Search_Btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.Search_Btn.Name = "Search_Btn";
            this.Search_Btn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Search_Btn.Size = new System.Drawing.Size(64, 36);
            this.Search_Btn.TabIndex = 5;
            this.Search_Btn.Text = "搜索";
            this.Search_Btn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Search_Btn.UseAccentColor = false;
            this.Search_Btn.UseVisualStyleBackColor = true;
            // 
            // gzss
            // 
            this.gzss.BackColor = System.Drawing.SystemColors.Window;
            this.gzss.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gzss.Depth = 0;
            this.gzss.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gzss.ForeColor = System.Drawing.SystemColors.Window;
            this.gzss.LeadingIcon = null;
            this.gzss.Location = new System.Drawing.Point(419, 26);
            this.gzss.Margin = new System.Windows.Forms.Padding(0);
            this.gzss.MaxLength = 100;
            this.gzss.MouseState = MaterialSkin.MouseState.OUT;
            this.gzss.Multiline = false;
            this.gzss.Name = "gzss";
            this.gzss.Size = new System.Drawing.Size(203, 36);
            this.gzss.TabIndex = 6;
            this.gzss.Text = "";
            this.gzss.TrailingIcon = null;
            this.gzss.UseTallSize = false;
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
            this.jsjdgl.PerformLayout();
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
        private MaterialSkin.Controls.MaterialTextBox bhss;
        private MaterialSkin.Controls.MaterialButton Add_Btn;
        private MaterialSkin.Controls.MaterialTextBox xmss;
        private MaterialSkin.Controls.MaterialButton Search_Btn;
        private MaterialSkin.Controls.MaterialTextBox gzss;
    }
}