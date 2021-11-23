namespace Library.Ui
{
    partial class BookPage
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
            this.btnBookDelete = new System.Windows.Forms.Button();
            this.gbCategoryUpdate = new System.Windows.Forms.GroupBox();
            this.btnBookUpdate = new System.Windows.Forms.Button();
            this.lblBookUpdate = new System.Windows.Forms.Label();
            this.txtBookyNameUpdate = new System.Windows.Forms.TextBox();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.gbBookAdd = new System.Windows.Forms.GroupBox();
            this.txtShelfNumber = new System.Windows.Forms.TextBox();
            this.lblShelfNumber = new System.Windows.Forms.Label();
            this.cbCategoryName = new System.Windows.Forms.ComboBox();
            this.lblCategoryAdd = new System.Windows.Forms.Label();
            this.cbAuthorName = new System.Windows.Forms.ComboBox();
            this.lblAuthorName = new System.Windows.Forms.Label();
            this.btnBookAdd = new System.Windows.Forms.Button();
            this.txtBookNameAdd = new System.Windows.Forms.TextBox();
            this.lblBookName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtShelfNumberUpdate = new System.Windows.Forms.TextBox();
            this.cbCategoryUpdate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbAuthorUpdate = new System.Windows.Forms.ComboBox();
            this.lblAuthorUpdate = new System.Windows.Forms.Label();
            this.gbCategoryUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.gbBookAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBookDelete
            // 
            this.btnBookDelete.Location = new System.Drawing.Point(821, 208);
            this.btnBookDelete.Name = "btnBookDelete";
            this.btnBookDelete.Size = new System.Drawing.Size(94, 46);
            this.btnBookDelete.TabIndex = 9;
            this.btnBookDelete.Text = "Sil";
            this.btnBookDelete.UseVisualStyleBackColor = true;
            this.btnBookDelete.Click += new System.EventHandler(this.btnBookDelete_Click);
            // 
            // gbCategoryUpdate
            // 
            this.gbCategoryUpdate.Controls.Add(this.cbCategoryUpdate);
            this.gbCategoryUpdate.Controls.Add(this.label1);
            this.gbCategoryUpdate.Controls.Add(this.cbAuthorUpdate);
            this.gbCategoryUpdate.Controls.Add(this.lblAuthorUpdate);
            this.gbCategoryUpdate.Controls.Add(this.label2);
            this.gbCategoryUpdate.Controls.Add(this.txtShelfNumberUpdate);
            this.gbCategoryUpdate.Controls.Add(this.btnBookUpdate);
            this.gbCategoryUpdate.Controls.Add(this.lblBookUpdate);
            this.gbCategoryUpdate.Controls.Add(this.txtBookyNameUpdate);
            this.gbCategoryUpdate.Location = new System.Drawing.Point(478, 35);
            this.gbCategoryUpdate.Name = "gbCategoryUpdate";
            this.gbCategoryUpdate.Size = new System.Drawing.Size(303, 229);
            this.gbCategoryUpdate.TabIndex = 8;
            this.gbCategoryUpdate.TabStop = false;
            this.gbCategoryUpdate.Text = "Kitap Güncelle";
            // 
            // btnBookUpdate
            // 
            this.btnBookUpdate.Location = new System.Drawing.Point(205, 173);
            this.btnBookUpdate.Name = "btnBookUpdate";
            this.btnBookUpdate.Size = new System.Drawing.Size(92, 46);
            this.btnBookUpdate.TabIndex = 4;
            this.btnBookUpdate.Text = "Kaydet";
            this.btnBookUpdate.UseVisualStyleBackColor = true;
            this.btnBookUpdate.Click += new System.EventHandler(this.btnBookUpdate_Click);
            // 
            // lblBookUpdate
            // 
            this.lblBookUpdate.AutoSize = true;
            this.lblBookUpdate.Location = new System.Drawing.Point(10, 44);
            this.lblBookUpdate.Name = "lblBookUpdate";
            this.lblBookUpdate.Size = new System.Drawing.Size(68, 17);
            this.lblBookUpdate.TabIndex = 3;
            this.lblBookUpdate.Text = "Kitap Adı:";
            // 
            // txtBookyNameUpdate
            // 
            this.txtBookyNameUpdate.Location = new System.Drawing.Point(114, 42);
            this.txtBookyNameUpdate.Name = "txtBookyNameUpdate";
            this.txtBookyNameUpdate.Size = new System.Drawing.Size(160, 22);
            this.txtBookyNameUpdate.TabIndex = 3;
            // 
            // dgvList
            // 
            this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Location = new System.Drawing.Point(29, 292);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowHeadersWidth = 51;
            this.dgvList.RowTemplate.Height = 24;
            this.dgvList.Size = new System.Drawing.Size(951, 203);
            this.dgvList.TabIndex = 6;
            this.dgvList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellClick);
            // 
            // gbBookAdd
            // 
            this.gbBookAdd.Controls.Add(this.txtShelfNumber);
            this.gbBookAdd.Controls.Add(this.lblShelfNumber);
            this.gbBookAdd.Controls.Add(this.cbCategoryName);
            this.gbBookAdd.Controls.Add(this.lblCategoryAdd);
            this.gbBookAdd.Controls.Add(this.cbAuthorName);
            this.gbBookAdd.Controls.Add(this.lblAuthorName);
            this.gbBookAdd.Controls.Add(this.btnBookAdd);
            this.gbBookAdd.Controls.Add(this.txtBookNameAdd);
            this.gbBookAdd.Controls.Add(this.lblBookName);
            this.gbBookAdd.Location = new System.Drawing.Point(29, 35);
            this.gbBookAdd.Name = "gbBookAdd";
            this.gbBookAdd.Size = new System.Drawing.Size(327, 229);
            this.gbBookAdd.TabIndex = 10;
            this.gbBookAdd.TabStop = false;
            this.gbBookAdd.Text = "Kitap Ekleme";
            // 
            // txtShelfNumber
            // 
            this.txtShelfNumber.Location = new System.Drawing.Point(121, 146);
            this.txtShelfNumber.Name = "txtShelfNumber";
            this.txtShelfNumber.Size = new System.Drawing.Size(167, 22);
            this.txtShelfNumber.TabIndex = 8;
            // 
            // lblShelfNumber
            // 
            this.lblShelfNumber.AutoSize = true;
            this.lblShelfNumber.Location = new System.Drawing.Point(23, 149);
            this.lblShelfNumber.Name = "lblShelfNumber";
            this.lblShelfNumber.Size = new System.Drawing.Size(98, 17);
            this.lblShelfNumber.TabIndex = 7;
            this.lblShelfNumber.Text = "Raf Numarası:";
            // 
            // cbCategoryName
            // 
            this.cbCategoryName.FormattingEnabled = true;
            this.cbCategoryName.Location = new System.Drawing.Point(121, 83);
            this.cbCategoryName.Name = "cbCategoryName";
            this.cbCategoryName.Size = new System.Drawing.Size(167, 24);
            this.cbCategoryName.TabIndex = 6;
            // 
            // lblCategoryAdd
            // 
            this.lblCategoryAdd.AutoSize = true;
            this.lblCategoryAdd.Location = new System.Drawing.Point(23, 86);
            this.lblCategoryAdd.Name = "lblCategoryAdd";
            this.lblCategoryAdd.Size = new System.Drawing.Size(65, 17);
            this.lblCategoryAdd.TabIndex = 5;
            this.lblCategoryAdd.Text = "Kategori:";
            // 
            // cbAuthorName
            // 
            this.cbAuthorName.FormattingEnabled = true;
            this.cbAuthorName.Location = new System.Drawing.Point(121, 116);
            this.cbAuthorName.Name = "cbAuthorName";
            this.cbAuthorName.Size = new System.Drawing.Size(167, 24);
            this.cbAuthorName.TabIndex = 4;
            // 
            // lblAuthorName
            // 
            this.lblAuthorName.AutoSize = true;
            this.lblAuthorName.Location = new System.Drawing.Point(23, 119);
            this.lblAuthorName.Name = "lblAuthorName";
            this.lblAuthorName.Size = new System.Drawing.Size(73, 17);
            this.lblAuthorName.TabIndex = 3;
            this.lblAuthorName.Text = "Yazar Adı:";
            // 
            // btnBookAdd
            // 
            this.btnBookAdd.Location = new System.Drawing.Point(189, 174);
            this.btnBookAdd.Name = "btnBookAdd";
            this.btnBookAdd.Size = new System.Drawing.Size(99, 34);
            this.btnBookAdd.TabIndex = 2;
            this.btnBookAdd.Text = "Ekle";
            this.btnBookAdd.UseVisualStyleBackColor = true;
            this.btnBookAdd.Click += new System.EventHandler(this.btnBookAdd_Click);
            // 
            // txtBookNameAdd
            // 
            this.txtBookNameAdd.Location = new System.Drawing.Point(121, 44);
            this.txtBookNameAdd.Name = "txtBookNameAdd";
            this.txtBookNameAdd.Size = new System.Drawing.Size(167, 22);
            this.txtBookNameAdd.TabIndex = 1;
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Location = new System.Drawing.Point(23, 47);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(68, 17);
            this.lblBookName.TabIndex = 0;
            this.lblBookName.Text = "Kitap Adı:";
            // 
            // label2
            // 
            this.label2.AccessibleName = "lblShelfName";
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Raf Numarası:";
            // 
            // txtShelfNumberUpdate
            // 
            this.txtShelfNumberUpdate.AccessibleName = "lblShelfName";
            this.txtShelfNumberUpdate.Location = new System.Drawing.Point(114, 146);
            this.txtShelfNumberUpdate.Name = "txtShelfNumberUpdate";
            this.txtShelfNumberUpdate.Size = new System.Drawing.Size(160, 22);
            this.txtShelfNumberUpdate.TabIndex = 8;
            // 
            // cbCategoryUpdate
            // 
            this.cbCategoryUpdate.FormattingEnabled = true;
            this.cbCategoryUpdate.Location = new System.Drawing.Point(114, 80);
            this.cbCategoryUpdate.Name = "cbCategoryUpdate";
            this.cbCategoryUpdate.Size = new System.Drawing.Size(161, 24);
            this.cbCategoryUpdate.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Kategori:";
            // 
            // cbAuthorUpdate
            // 
            this.cbAuthorUpdate.FormattingEnabled = true;
            this.cbAuthorUpdate.Location = new System.Drawing.Point(114, 113);
            this.cbAuthorUpdate.Name = "cbAuthorUpdate";
            this.cbAuthorUpdate.Size = new System.Drawing.Size(161, 24);
            this.cbAuthorUpdate.TabIndex = 10;
            // 
            // lblAuthorUpdate
            // 
            this.lblAuthorUpdate.AutoSize = true;
            this.lblAuthorUpdate.Location = new System.Drawing.Point(10, 116);
            this.lblAuthorUpdate.Name = "lblAuthorUpdate";
            this.lblAuthorUpdate.Size = new System.Drawing.Size(73, 17);
            this.lblAuthorUpdate.TabIndex = 9;
            this.lblAuthorUpdate.Text = "Yazar Adı:";
            // 
            // BookPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 568);
            this.Controls.Add(this.gbBookAdd);
            this.Controls.Add(this.btnBookDelete);
            this.Controls.Add(this.gbCategoryUpdate);
            this.Controls.Add(this.dgvList);
            this.Name = "BookPage";
            this.Text = "BookPage";
            this.Load += new System.EventHandler(this.BookPage_Load);
            this.gbCategoryUpdate.ResumeLayout(false);
            this.gbCategoryUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.gbBookAdd.ResumeLayout(false);
            this.gbBookAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBookDelete;
        private System.Windows.Forms.GroupBox gbCategoryUpdate;
        private System.Windows.Forms.Button btnBookUpdate;
        private System.Windows.Forms.Label lblBookUpdate;
        private System.Windows.Forms.TextBox txtBookyNameUpdate;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.GroupBox gbBookAdd;
        private System.Windows.Forms.TextBox txtShelfNumber;
        private System.Windows.Forms.Label lblShelfNumber;
        private System.Windows.Forms.ComboBox cbCategoryName;
        private System.Windows.Forms.Label lblCategoryAdd;
        private System.Windows.Forms.ComboBox cbAuthorName;
        private System.Windows.Forms.Label lblAuthorName;
        private System.Windows.Forms.Button btnBookAdd;
        private System.Windows.Forms.TextBox txtBookNameAdd;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.ComboBox cbCategoryUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbAuthorUpdate;
        private System.Windows.Forms.Label lblAuthorUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtShelfNumberUpdate;
    }
}