namespace Library.Ui
{
    partial class CategoryPage
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
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.gbCategoryAdd = new System.Windows.Forms.GroupBox();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.lblCategoryAdd = new System.Windows.Forms.Label();
            this.txtCategoryNameUpdate = new System.Windows.Forms.TextBox();
            this.gbCategoryUpdate = new System.Windows.Forms.GroupBox();
            this.btnUpdateCategory = new System.Windows.Forms.Button();
            this.lblCategoryUpdate = new System.Windows.Forms.Label();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.gbCategoryAdd.SuspendLayout();
            this.gbCategoryUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvList
            // 
            this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Location = new System.Drawing.Point(12, 160);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowHeadersWidth = 51;
            this.dgvList.RowTemplate.Height = 24;
            this.dgvList.Size = new System.Drawing.Size(951, 203);
            this.dgvList.TabIndex = 0;
            this.dgvList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellClick);
            // 
            // gbCategoryAdd
            // 
            this.gbCategoryAdd.Controls.Add(this.btnAddCategory);
            this.gbCategoryAdd.Controls.Add(this.txtCategoryName);
            this.gbCategoryAdd.Controls.Add(this.lblCategoryAdd);
            this.gbCategoryAdd.Location = new System.Drawing.Point(67, 12);
            this.gbCategoryAdd.Name = "gbCategoryAdd";
            this.gbCategoryAdd.Size = new System.Drawing.Size(338, 142);
            this.gbCategoryAdd.TabIndex = 1;
            this.gbCategoryAdd.TabStop = false;
            this.gbCategoryAdd.Text = "Kategori Ekleme";
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(240, 90);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(92, 46);
            this.btnAddCategory.TabIndex = 5;
            this.btnAddCategory.Text = "Kaydet";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(131, 54);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(150, 22);
            this.txtCategoryName.TabIndex = 4;
            // 
            // lblCategoryAdd
            // 
            this.lblCategoryAdd.AutoSize = true;
            this.lblCategoryAdd.Location = new System.Drawing.Point(15, 57);
            this.lblCategoryAdd.Name = "lblCategoryAdd";
            this.lblCategoryAdd.Size = new System.Drawing.Size(89, 17);
            this.lblCategoryAdd.TabIndex = 3;
            this.lblCategoryAdd.Text = "Kategori Adı:";
            // 
            // txtCategoryNameUpdate
            // 
            this.txtCategoryNameUpdate.Location = new System.Drawing.Point(114, 42);
            this.txtCategoryNameUpdate.Name = "txtCategoryNameUpdate";
            this.txtCategoryNameUpdate.Size = new System.Drawing.Size(160, 22);
            this.txtCategoryNameUpdate.TabIndex = 3;
            // 
            // gbCategoryUpdate
            // 
            this.gbCategoryUpdate.Controls.Add(this.btnUpdateCategory);
            this.gbCategoryUpdate.Controls.Add(this.lblCategoryUpdate);
            this.gbCategoryUpdate.Controls.Add(this.txtCategoryNameUpdate);
            this.gbCategoryUpdate.Location = new System.Drawing.Point(508, 12);
            this.gbCategoryUpdate.Name = "gbCategoryUpdate";
            this.gbCategoryUpdate.Size = new System.Drawing.Size(303, 142);
            this.gbCategoryUpdate.TabIndex = 4;
            this.gbCategoryUpdate.TabStop = false;
            this.gbCategoryUpdate.Text = "Kategori Güncelle";
            // 
            // btnUpdateCategory
            // 
            this.btnUpdateCategory.Location = new System.Drawing.Point(199, 86);
            this.btnUpdateCategory.Name = "btnUpdateCategory";
            this.btnUpdateCategory.Size = new System.Drawing.Size(92, 46);
            this.btnUpdateCategory.TabIndex = 4;
            this.btnUpdateCategory.Text = "Güncelle";
            this.btnUpdateCategory.UseVisualStyleBackColor = true;
            this.btnUpdateCategory.Click += new System.EventHandler(this.btnUpdateCategory_Click);
            // 
            // lblCategoryUpdate
            // 
            this.lblCategoryUpdate.AutoSize = true;
            this.lblCategoryUpdate.Location = new System.Drawing.Point(6, 45);
            this.lblCategoryUpdate.Name = "lblCategoryUpdate";
            this.lblCategoryUpdate.Size = new System.Drawing.Size(89, 17);
            this.lblCategoryUpdate.TabIndex = 3;
            this.lblCategoryUpdate.Text = "Kategori Adı:";
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Location = new System.Drawing.Point(862, 98);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(94, 46);
            this.btnDeleteCategory.TabIndex = 5;
            this.btnDeleteCategory.Text = "Sil";
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // CategoryPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 411);
            this.Controls.Add(this.btnDeleteCategory);
            this.Controls.Add(this.gbCategoryUpdate);
            this.Controls.Add(this.gbCategoryAdd);
            this.Controls.Add(this.dgvList);
            this.Name = "CategoryPage";
            this.Text = "CategoryPage";
            this.Load += new System.EventHandler(this.CategoryPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.gbCategoryAdd.ResumeLayout(false);
            this.gbCategoryAdd.PerformLayout();
            this.gbCategoryUpdate.ResumeLayout(false);
            this.gbCategoryUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.GroupBox gbCategoryAdd;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Label lblCategoryAdd;
        private System.Windows.Forms.TextBox txtCategoryNameUpdate;
        private System.Windows.Forms.GroupBox gbCategoryUpdate;
        private System.Windows.Forms.Button btnUpdateCategory;
        private System.Windows.Forms.Label lblCategoryUpdate;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnAddCategory;
    }
}