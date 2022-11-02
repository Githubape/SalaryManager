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
            this.gzss = new MaterialSkin.Controls.MaterialTextBox();
            this.Search_Btn = new MaterialSkin.Controls.MaterialButton();
            this.xmss = new MaterialSkin.Controls.MaterialTextBox();
            this.bhss = new MaterialSkin.Controls.MaterialTextBox();
            this.Add_Btn = new MaterialSkin.Controls.MaterialButton();
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.List1Header_Eid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.List1Header_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.List1Header_Sex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.List1Header_BankAccount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.List1Header_Egroup = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.List1Header_Etype = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.List1Header_EntryTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.List1Header_WorkType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.List1Header_Post = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.List1Header_PostOrder = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.List1Header_PostLevel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.List1Header_QualificationLevel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.List1Header_DutyTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.List1Header_ServiceLength = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.List1Header_OnlyChild = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.List1Header_OnlychildAllowance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.List1Header_IsHard = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.List1Header_HardshipAllowance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.List1Header_IsEdge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.List1Header_EdgeAllowance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.List1Header_MealAllowance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.List1Header_PostWage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.List1Header_PostBonus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.List1Header_PostTransportation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.List1Header_HousingAllowance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.List1Header_HeatingAllowance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bdls = new System.Windows.Forms.TabPage();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gzgl = new System.Windows.Forms.TabPage();
            this.cgsz = new System.Windows.Forms.TabPage();
            this.Edit_Button = new MaterialSkin.Controls.MaterialButton();
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
            this.jsjdgl.Controls.Add(this.Edit_Button);
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
            // gzss
            // 
            this.gzss.BackColor = System.Drawing.SystemColors.Window;
            this.gzss.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gzss.Depth = 0;
            this.gzss.Font = new System.Drawing.Font("思源黑体 CN Regular", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
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
            // xmss
            // 
            this.xmss.BackColor = System.Drawing.SystemColors.Window;
            this.xmss.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.xmss.Depth = 0;
            this.xmss.Font = new System.Drawing.Font("思源黑体 CN Regular", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
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
            this.List1Header_Eid,
            this.List1Header_Name,
            this.List1Header_Sex,
            this.List1Header_BankAccount,
            this.List1Header_Egroup,
            this.List1Header_Etype,
            this.List1Header_EntryTime,
            this.List1Header_WorkType,
            this.List1Header_Post,
            this.List1Header_PostOrder,
            this.List1Header_PostLevel,
            this.List1Header_QualificationLevel,
            this.List1Header_DutyTime,
            this.List1Header_ServiceLength,
            this.List1Header_OnlyChild,
            this.List1Header_OnlychildAllowance,
            this.List1Header_IsHard,
            this.List1Header_HardshipAllowance,
            this.List1Header_IsEdge,
            this.List1Header_EdgeAllowance,
            this.List1Header_MealAllowance,
            this.List1Header_PostWage,
            this.List1Header_PostBonus,
            this.List1Header_PostTransportation,
            this.List1Header_HousingAllowance,
            this.List1Header_HeatingAllowance});
            this.materialListView1.Depth = 0;
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.HideSelection = false;
            this.materialListView1.Location = new System.Drawing.Point(6, 85);
            this.materialListView1.MinimumSize = new System.Drawing.Size(200, 100);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(1161, 373);
            this.materialListView1.TabIndex = 0;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            this.materialListView1.SelectedIndexChanged += new System.EventHandler(this.materialListView1_SelectedIndexChanged);
            // 
            // List1Header_Eid
            // 
            this.List1Header_Eid.Text = "编号";
            // 
            // List1Header_Name
            // 
            this.List1Header_Name.Text = "姓名";
            this.List1Header_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // List1Header_Sex
            // 
            this.List1Header_Sex.Text = "性别";
            this.List1Header_Sex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // List1Header_BankAccount
            // 
            this.List1Header_BankAccount.Text = "银行卡号";
            this.List1Header_BankAccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // List1Header_Egroup
            // 
            this.List1Header_Egroup.Text = "组";
            this.List1Header_Egroup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // List1Header_Etype
            // 
            this.List1Header_Etype.Text = "工种";
            this.List1Header_Etype.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // List1Header_EntryTime
            // 
            this.List1Header_EntryTime.Text = "入职时间";
            this.List1Header_EntryTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.List1Header_EntryTime.Width = 120;
            // 
            // List1Header_WorkType
            // 
            this.List1Header_WorkType.Text = "工种";
            // 
            // List1Header_Post
            // 
            this.List1Header_Post.Text = "职位";
            // 
            // List1Header_PostOrder
            // 
            this.List1Header_PostOrder.Text = "岗序";
            // 
            // List1Header_PostLevel
            // 
            this.List1Header_PostLevel.Text = "岗级";
            // 
            // List1Header_QualificationLevel
            // 
            this.List1Header_QualificationLevel.Text = "资格等级";
            // 
            // List1Header_DutyTime
            // 
            this.List1Header_DutyTime.Text = "入职时间";
            // 
            // List1Header_ServiceLength
            // 
            this.List1Header_ServiceLength.Text = "工龄";
            // 
            // List1Header_OnlyChild
            // 
            this.List1Header_OnlyChild.Text = "独生子女";
            // 
            // List1Header_OnlychildAllowance
            // 
            this.List1Header_OnlychildAllowance.Text = "独生子女津贴";
            // 
            // List1Header_IsHard
            // 
            this.List1Header_IsHard.Text = "艰难岗位";
            // 
            // List1Header_HardshipAllowance
            // 
            this.List1Header_HardshipAllowance.Text = "艰难岗位津贴";
            // 
            // List1Header_IsEdge
            // 
            this.List1Header_IsEdge.Text = "边缘地区";
            // 
            // List1Header_EdgeAllowance
            // 
            this.List1Header_EdgeAllowance.Text = "边缘地区津贴";
            // 
            // List1Header_MealAllowance
            // 
            this.List1Header_MealAllowance.Text = "餐饮补助";
            // 
            // List1Header_PostWage
            // 
            this.List1Header_PostWage.Text = "基础工资";
            // 
            // List1Header_PostBonus
            // 
            this.List1Header_PostBonus.Text = "职位奖金";
            // 
            // List1Header_PostTransportation
            // 
            this.List1Header_PostTransportation.Text = "交通费";
            // 
            // List1Header_HousingAllowance
            // 
            this.List1Header_HousingAllowance.Text = "住房补贴";
            // 
            // List1Header_HeatingAllowance
            // 
            this.List1Header_HeatingAllowance.Text = "取暖补贴";
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
            // Edit_Button
            // 
            this.Edit_Button.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.Edit_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Edit_Button.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.Edit_Button.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Edit_Button.Depth = 0;
            this.Edit_Button.HighEmphasis = true;
            this.Edit_Button.Icon = null;
            this.Edit_Button.Location = new System.Drawing.Point(939, 492);
            this.Edit_Button.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Edit_Button.MouseState = MaterialSkin.MouseState.HOVER;
            this.Edit_Button.Name = "Edit_Button";
            this.Edit_Button.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Edit_Button.Size = new System.Drawing.Size(64, 36);
            this.Edit_Button.TabIndex = 7;
            this.Edit_Button.Text = "编辑";
            this.Edit_Button.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Edit_Button.UseAccentColor = false;
            this.Edit_Button.UseVisualStyleBackColor = true;
            this.Edit_Button.Click += new System.EventHandler(this.Edit_Button_Click);
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
        private System.Windows.Forms.ColumnHeader List1Header_Eid;
        private System.Windows.Forms.ColumnHeader List1Header_Name;
        private System.Windows.Forms.ColumnHeader List1Header_Sex;
        private System.Windows.Forms.ColumnHeader List1Header_BankAccount;
        private System.Windows.Forms.ColumnHeader List1Header_Egroup;
        private System.Windows.Forms.ColumnHeader List1Header_Etype;
        private System.Windows.Forms.ColumnHeader List1Header_EntryTime;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox2;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialMultiLineTextBox materialMultiLineTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ColumnHeader List1Header_WorkType;
        private System.Windows.Forms.ColumnHeader List1Header_Post;
        private System.Windows.Forms.ColumnHeader List1Header_PostOrder;
        private System.Windows.Forms.ColumnHeader List1Header_PostLevel;
        private System.Windows.Forms.ColumnHeader List1Header_QualificationLevel;
        private System.Windows.Forms.ColumnHeader List1Header_DutyTime;
        private System.Windows.Forms.ColumnHeader List1Header_ServiceLength;
        private System.Windows.Forms.ColumnHeader List1Header_OnlyChild;
        private System.Windows.Forms.ColumnHeader List1Header_OnlychildAllowance;
        private System.Windows.Forms.ColumnHeader List1Header_IsHard;
        private System.Windows.Forms.ColumnHeader List1Header_HardshipAllowance;
        private System.Windows.Forms.ColumnHeader List1Header_IsEdge;
        private System.Windows.Forms.ColumnHeader List1Header_EdgeAllowance;
        private System.Windows.Forms.ColumnHeader List1Header_MealAllowance;
        private System.Windows.Forms.ColumnHeader List1Header_PostWage;
        private System.Windows.Forms.ColumnHeader List1Header_PostBonus;
        private System.Windows.Forms.ColumnHeader List1Header_PostTransportation;
        private System.Windows.Forms.ColumnHeader List1Header_HousingAllowance;
        private System.Windows.Forms.ColumnHeader List1Header_HeatingAllowance;
        private MaterialSkin.Controls.MaterialTextBox bhss;
        private MaterialSkin.Controls.MaterialButton Add_Btn;
        private MaterialSkin.Controls.MaterialTextBox xmss;
        private MaterialSkin.Controls.MaterialButton Search_Btn;
        private MaterialSkin.Controls.MaterialTextBox gzss;
        private MaterialSkin.Controls.MaterialButton Edit_Button;
    }
}