namespace Library.Ui
{
    partial class MainPage
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
            this.gbProcess = new System.Windows.Forms.GroupBox();
            this.btnCategoryProcess = new System.Windows.Forms.Button();
            this.btnAuthorProcess = new System.Windows.Forms.Button();
            this.btnBookProcess = new System.Windows.Forms.Button();
            this.gbSearchByBookName = new System.Windows.Forms.GroupBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.lblBook = new System.Windows.Forms.Label();
            this.gbSearchByCategory = new System.Windows.Forms.GroupBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.gbSearchByAuthorName = new System.Windows.Forms.GroupBox();
            this.cbAuthorSearch = new System.Windows.Forms.ComboBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.gbProcess.SuspendLayout();
            this.gbSearchByBookName.SuspendLayout();
            this.gbSearchByCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.gbSearchByAuthorName.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbProcess
            // 
            this.gbProcess.Controls.Add(this.btnCategoryProcess);
            this.gbProcess.Controls.Add(this.btnAuthorProcess);
            this.gbProcess.Controls.Add(this.btnBookProcess);
            this.gbProcess.Location = new System.Drawing.Point(911, 12);
            this.gbProcess.Name = "gbProcess";
            this.gbProcess.Size = new System.Drawing.Size(281, 193);
            this.gbProcess.TabIndex = 8;
            this.gbProcess.TabStop = false;
            this.gbProcess.Text = "İşlemler";
            // 
            // btnCategoryProcess
            // 
            this.btnCategoryProcess.Location = new System.Drawing.Point(62, 115);
            this.btnCategoryProcess.Name = "btnCategoryProcess";
            this.btnCategoryProcess.Size = new System.Drawing.Size(160, 33);
            this.btnCategoryProcess.TabIndex = 2;
            this.btnCategoryProcess.Text = "Kategori İşlemleri";
            this.btnCategoryProcess.UseVisualStyleBackColor = true;
            this.btnCategoryProcess.Click += new System.EventHandler(this.btnCategoryProcess_Click);
            // 
            // btnAuthorProcess
            // 
            this.btnAuthorProcess.Location = new System.Drawing.Point(62, 79);
            this.btnAuthorProcess.Name = "btnAuthorProcess";
            this.btnAuthorProcess.Size = new System.Drawing.Size(160, 33);
            this.btnAuthorProcess.TabIndex = 1;
            this.btnAuthorProcess.Text = "Yazar İşlemleri";
            this.btnAuthorProcess.UseVisualStyleBackColor = true;
            this.btnAuthorProcess.Click += new System.EventHandler(this.btnAuthorProcess_Click);
            // 
            // btnBookProcess
            // 
            this.btnBookProcess.Location = new System.Drawing.Point(62, 40);
            this.btnBookProcess.Name = "btnBookProcess";
            this.btnBookProcess.Size = new System.Drawing.Size(160, 33);
            this.btnBookProcess.TabIndex = 0;
            this.btnBookProcess.Text = "Kitap İşlemleri";
            this.btnBookProcess.UseVisualStyleBackColor = true;
            this.btnBookProcess.Click += new System.EventHandler(this.btnBookProcess_Click);
            // 
            // gbSearchByBookName
            // 
            this.gbSearchByBookName.Controls.Add(this.txtBookName);
            this.gbSearchByBookName.Controls.Add(this.lblBook);
            this.gbSearchByBookName.Location = new System.Drawing.Point(485, 12);
            this.gbSearchByBookName.Name = "gbSearchByBookName";
            this.gbSearchByBookName.Size = new System.Drawing.Size(275, 83);
            this.gbSearchByBookName.TabIndex = 7;
            this.gbSearchByBookName.TabStop = false;
            this.gbSearchByBookName.Text = "Kitap Adına Göre Ara";
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(89, 35);
            this.txtBookName.Multiline = true;
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(163, 24);
            this.txtBookName.TabIndex = 3;
            this.txtBookName.TextChanged += new System.EventHandler(this.txtBookName_TextChanged);
            // 
            // lblBook
            // 
            this.lblBook.AutoSize = true;
            this.lblBook.Location = new System.Drawing.Point(15, 38);
            this.lblBook.Name = "lblBook";
            this.lblBook.Size = new System.Drawing.Size(68, 17);
            this.lblBook.TabIndex = 2;
            this.lblBook.Text = "Kitap Adı:";
            // 
            // gbSearchByCategory
            // 
            this.gbSearchByCategory.Controls.Add(this.cbCategory);
            this.gbSearchByCategory.Controls.Add(this.lblCategory);
            this.gbSearchByCategory.Location = new System.Drawing.Point(27, 12);
            this.gbSearchByCategory.Name = "gbSearchByCategory";
            this.gbSearchByCategory.Size = new System.Drawing.Size(329, 130);
            this.gbSearchByCategory.TabIndex = 6;
            this.gbSearchByCategory.TabStop = false;
            this.gbSearchByCategory.Text = "Kitap Türüne Göre Ara";
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(86, 35);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(166, 24);
            this.cbCategory.TabIndex = 2;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(15, 38);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(65, 17);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Kategori:";
            // 
            // dgvList
            // 
            this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Location = new System.Drawing.Point(27, 263);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowHeadersWidth = 51;
            this.dgvList.RowTemplate.Height = 24;
            this.dgvList.Size = new System.Drawing.Size(1165, 356);
            this.dgvList.TabIndex = 5;
            // 
            // gbSearchByAuthorName
            // 
            this.gbSearchByAuthorName.Controls.Add(this.cbAuthorSearch);
            this.gbSearchByAuthorName.Controls.Add(this.lblAuthor);
            this.gbSearchByAuthorName.Location = new System.Drawing.Point(485, 146);
            this.gbSearchByAuthorName.Name = "gbSearchByAuthorName";
            this.gbSearchByAuthorName.Size = new System.Drawing.Size(275, 83);
            this.gbSearchByAuthorName.TabIndex = 9;
            this.gbSearchByAuthorName.TabStop = false;
            this.gbSearchByAuthorName.Text = "Yazar Adına Göre Ara";
            // 
            // cbAuthorSearch
            // 
            this.cbAuthorSearch.FormattingEnabled = true;
            this.cbAuthorSearch.Location = new System.Drawing.Point(94, 35);
            this.cbAuthorSearch.Name = "cbAuthorSearch";
            this.cbAuthorSearch.Size = new System.Drawing.Size(166, 24);
            this.cbAuthorSearch.TabIndex = 3;
            this.cbAuthorSearch.SelectedIndexChanged += new System.EventHandler(this.cbAuthorSearch_SelectedIndexChanged);
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(15, 38);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(73, 17);
            this.lblAuthor.TabIndex = 2;
            this.lblAuthor.Text = "Yazar Adı:";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 631);
            this.Controls.Add(this.gbSearchByAuthorName);
            this.Controls.Add(this.gbProcess);
            this.Controls.Add(this.gbSearchByBookName);
            this.Controls.Add(this.gbSearchByCategory);
            this.Controls.Add(this.dgvList);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.gbProcess.ResumeLayout(false);
            this.gbSearchByBookName.ResumeLayout(false);
            this.gbSearchByBookName.PerformLayout();
            this.gbSearchByCategory.ResumeLayout(false);
            this.gbSearchByCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.gbSearchByAuthorName.ResumeLayout(false);
            this.gbSearchByAuthorName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbProcess;
        private System.Windows.Forms.Button btnCategoryProcess;
        private System.Windows.Forms.Button btnAuthorProcess;
        private System.Windows.Forms.Button btnBookProcess;
        private System.Windows.Forms.GroupBox gbSearchByBookName;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label lblBook;
        private System.Windows.Forms.GroupBox gbSearchByCategory;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.GroupBox gbSearchByAuthorName;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.ComboBox cbAuthorSearch;
    }
}