namespace SalaryManager
{
    partial class ImportExcelDataForm
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
            this.importExcelData_ListView = new MaterialSkin.Controls.MaterialListView();
            this.DatableHeader_Eid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DatableHeader_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // importExcelData_ListView
            // 
            this.importExcelData_ListView.AutoSizeTable = false;
            this.importExcelData_ListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.importExcelData_ListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.importExcelData_ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DatableHeader_Eid,
            this.DatableHeader_Name});
            this.importExcelData_ListView.Depth = 0;
            this.importExcelData_ListView.FullRowSelect = true;
            this.importExcelData_ListView.HideSelection = false;
            this.importExcelData_ListView.Location = new System.Drawing.Point(6, 135);
            this.importExcelData_ListView.MinimumSize = new System.Drawing.Size(200, 100);
            this.importExcelData_ListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.importExcelData_ListView.MouseState = MaterialSkin.MouseState.OUT;
            this.importExcelData_ListView.Name = "importExcelData_ListView";
            this.importExcelData_ListView.OwnerDraw = true;
            this.importExcelData_ListView.Size = new System.Drawing.Size(1131, 100);
            this.importExcelData_ListView.TabIndex = 0;
            this.importExcelData_ListView.UseCompatibleStateImageBehavior = false;
            this.importExcelData_ListView.View = System.Windows.Forms.View.Details;
            this.importExcelData_ListView.SelectedIndexChanged += new System.EventHandler(this.importExcelData_ListView_SelectedIndexChanged);
            // 
            // DatableHeader_Eid
            // 
            this.DatableHeader_Eid.Text = "编号";
            this.DatableHeader_Eid.Width = 80;
            // 
            // DatableHeader_Name
            // 
            this.DatableHeader_Name.Text = "姓名";
            this.DatableHeader_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ImportExcelDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 502);
            this.Controls.Add(this.importExcelData_ListView);
            this.Name = "ImportExcelDataForm";
            this.Text = "从Excel中导入数据";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView importExcelData_ListView;
        private System.Windows.Forms.ColumnHeader DatableHeader_Eid;
        private System.Windows.Forms.ColumnHeader DatableHeader_Name;
    }
}