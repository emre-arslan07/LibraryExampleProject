namespace Library.Ui
{
    partial class AuthorPage
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
            this.gbAuthorAdd = new System.Windows.Forms.GroupBox();
            this.dtpDatetime = new System.Windows.Forms.DateTimePicker();
            this.txtAuthorLastName = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblBirthdate = new System.Windows.Forms.Label();
            this.btnAuthorAdd = new System.Windows.Forms.Button();
            this.lblAuthorName = new System.Windows.Forms.Label();
            this.txtAuthorName = new System.Windows.Forms.TextBox();
            this.lblAuthorLastName = new System.Windows.Forms.Label();
            this.btnAuthorDelete = new System.Windows.Forms.Button();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.gbAuthorUpdate = new System.Windows.Forms.GroupBox();
            this.dtpBrithdateUpdate = new System.Windows.Forms.DateTimePicker();
            this.txtAuthorLastNameUpdate = new System.Windows.Forms.TextBox();
            this.txtMailUpdate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAuthorUpdate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAuthorNameUpdate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbAuthorAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.gbAuthorUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAuthorAdd
            // 
            this.gbAuthorAdd.Controls.Add(this.dtpDatetime);
            this.gbAuthorAdd.Controls.Add(this.txtAuthorLastName);
            this.gbAuthorAdd.Controls.Add(this.txtMail);
            this.gbAuthorAdd.Controls.Add(this.lblMail);
            this.gbAuthorAdd.Controls.Add(this.lblBirthdate);
            this.gbAuthorAdd.Controls.Add(this.btnAuthorAdd);
            this.gbAuthorAdd.Controls.Add(this.lblAuthorName);
            this.gbAuthorAdd.Controls.Add(this.txtAuthorName);
            this.gbAuthorAdd.Controls.Add(this.lblAuthorLastName);
            this.gbAuthorAdd.Location = new System.Drawing.Point(34, 35);
            this.gbAuthorAdd.Name = "gbAuthorAdd";
            this.gbAuthorAdd.Size = new System.Drawing.Size(327, 229);
            this.gbAuthorAdd.TabIndex = 14;
            this.gbAuthorAdd.TabStop = false;
            this.gbAuthorAdd.Text = "Yazar Ekleme";
            // 
            // dtpDatetime
            // 
            this.dtpDatetime.Location = new System.Drawing.Point(121, 118);
            this.dtpDatetime.Name = "dtpDatetime";
            this.dtpDatetime.Size = new System.Drawing.Size(167, 22);
            this.dtpDatetime.TabIndex = 15;
            // 
            // txtAuthorLastName
            // 
            this.txtAuthorLastName.Location = new System.Drawing.Point(121, 78);
            this.txtAuthorLastName.Name = "txtAuthorLastName";
            this.txtAuthorLastName.Size = new System.Drawing.Size(167, 22);
            this.txtAuthorLastName.TabIndex = 16;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(121, 146);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(167, 22);
            this.txtMail.TabIndex = 8;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(23, 149);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(46, 17);
            this.lblMail.TabIndex = 7;
            this.lblMail.Text = "Email:";
            // 
            // lblBirthdate
            // 
            this.lblBirthdate.AutoSize = true;
            this.lblBirthdate.Location = new System.Drawing.Point(23, 118);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.Size = new System.Drawing.Size(92, 17);
            this.lblBirthdate.TabIndex = 5;
            this.lblBirthdate.Text = "Doğum tarihi:";
            // 
            // btnAuthorAdd
            // 
            this.btnAuthorAdd.Location = new System.Drawing.Point(189, 174);
            this.btnAuthorAdd.Name = "btnAuthorAdd";
            this.btnAuthorAdd.Size = new System.Drawing.Size(99, 34);
            this.btnAuthorAdd.TabIndex = 2;
            this.btnAuthorAdd.Text = "Ekle";
            this.btnAuthorAdd.UseVisualStyleBackColor = true;
            this.btnAuthorAdd.Click += new System.EventHandler(this.btnBookAdd_Click);
            // 
            // lblAuthorName
            // 
            this.lblAuthorName.AutoSize = true;
            this.lblAuthorName.Location = new System.Drawing.Point(23, 49);
            this.lblAuthorName.Name = "lblAuthorName";
            this.lblAuthorName.Size = new System.Drawing.Size(73, 17);
            this.lblAuthorName.TabIndex = 3;
            this.lblAuthorName.Text = "Yazar Adı:";
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.Location = new System.Drawing.Point(121, 44);
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.Size = new System.Drawing.Size(167, 22);
            this.txtAuthorName.TabIndex = 1;
            // 
            // lblAuthorLastName
            // 
            this.lblAuthorLastName.AutoSize = true;
            this.lblAuthorLastName.Location = new System.Drawing.Point(23, 81);
            this.lblAuthorLastName.Name = "lblAuthorLastName";
            this.lblAuthorLastName.Size = new System.Drawing.Size(97, 17);
            this.lblAuthorLastName.TabIndex = 0;
            this.lblAuthorLastName.Text = "Yazar SoyAdı:";
            // 
            // btnAuthorDelete
            // 
            this.btnAuthorDelete.Location = new System.Drawing.Point(826, 208);
            this.btnAuthorDelete.Name = "btnAuthorDelete";
            this.btnAuthorDelete.Size = new System.Drawing.Size(94, 46);
            this.btnAuthorDelete.TabIndex = 13;
            this.btnAuthorDelete.Text = "Sil";
            this.btnAuthorDelete.UseVisualStyleBackColor = true;
            this.btnAuthorDelete.Click += new System.EventHandler(this.btnAuthorDelete_Click);
            // 
            // dgvList
            // 
            this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Location = new System.Drawing.Point(34, 292);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowHeadersWidth = 51;
            this.dgvList.RowTemplate.Height = 24;
            this.dgvList.Size = new System.Drawing.Size(951, 203);
            this.dgvList.TabIndex = 11;
            this.dgvList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellClick);
            // 
            // gbAuthorUpdate
            // 
            this.gbAuthorUpdate.Controls.Add(this.dtpBrithdateUpdate);
            this.gbAuthorUpdate.Controls.Add(this.txtAuthorLastNameUpdate);
            this.gbAuthorUpdate.Controls.Add(this.txtMailUpdate);
            this.gbAuthorUpdate.Controls.Add(this.label1);
            this.gbAuthorUpdate.Controls.Add(this.label2);
            this.gbAuthorUpdate.Controls.Add(this.btnAuthorUpdate);
            this.gbAuthorUpdate.Controls.Add(this.label3);
            this.gbAuthorUpdate.Controls.Add(this.txtAuthorNameUpdate);
            this.gbAuthorUpdate.Controls.Add(this.label4);
            this.gbAuthorUpdate.Location = new System.Drawing.Point(465, 35);
            this.gbAuthorUpdate.Name = "gbAuthorUpdate";
            this.gbAuthorUpdate.Size = new System.Drawing.Size(327, 229);
            this.gbAuthorUpdate.TabIndex = 15;
            this.gbAuthorUpdate.TabStop = false;
            this.gbAuthorUpdate.Text = "Yazar Güncelleme";
            // 
            // dtpBrithdateUpdate
            // 
            this.dtpBrithdateUpdate.Location = new System.Drawing.Point(121, 118);
            this.dtpBrithdateUpdate.Name = "dtpBrithdateUpdate";
            this.dtpBrithdateUpdate.Size = new System.Drawing.Size(167, 22);
            this.dtpBrithdateUpdate.TabIndex = 15;
            // 
            // txtAuthorLastNameUpdate
            // 
            this.txtAuthorLastNameUpdate.Location = new System.Drawing.Point(121, 78);
            this.txtAuthorLastNameUpdate.Name = "txtAuthorLastNameUpdate";
            this.txtAuthorLastNameUpdate.Size = new System.Drawing.Size(167, 22);
            this.txtAuthorLastNameUpdate.TabIndex = 16;
            // 
            // txtMailUpdate
            // 
            this.txtMailUpdate.Location = new System.Drawing.Point(121, 146);
            this.txtMailUpdate.Name = "txtMailUpdate";
            this.txtMailUpdate.Size = new System.Drawing.Size(167, 22);
            this.txtMailUpdate.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Doğum tarihi:";
            // 
            // btnAuthorUpdate
            // 
            this.btnAuthorUpdate.Location = new System.Drawing.Point(189, 174);
            this.btnAuthorUpdate.Name = "btnAuthorUpdate";
            this.btnAuthorUpdate.Size = new System.Drawing.Size(99, 34);
            this.btnAuthorUpdate.TabIndex = 2;
            this.btnAuthorUpdate.Text = "Güncelle";
            this.btnAuthorUpdate.UseVisualStyleBackColor = true;
            this.btnAuthorUpdate.Click += new System.EventHandler(this.btnAuthorUpdate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Yazar Adı:";
            // 
            // txtAuthorNameUpdate
            // 
            this.txtAuthorNameUpdate.Location = new System.Drawing.Point(121, 44);
            this.txtAuthorNameUpdate.Name = "txtAuthorNameUpdate";
            this.txtAuthorNameUpdate.Size = new System.Drawing.Size(167, 22);
            this.txtAuthorNameUpdate.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Yazar SoyAdı:";
            // 
            // AuthorPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 580);
            this.Controls.Add(this.gbAuthorUpdate);
            this.Controls.Add(this.gbAuthorAdd);
            this.Controls.Add(this.btnAuthorDelete);
            this.Controls.Add(this.dgvList);
            this.Name = "AuthorPage";
            this.Text = "AuthorPage";
            this.Load += new System.EventHandler(this.AuthorPage_Load_1);
            this.gbAuthorAdd.ResumeLayout(false);
            this.gbAuthorAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.gbAuthorUpdate.ResumeLayout(false);
            this.gbAuthorUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAuthorAdd;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblBirthdate;
        private System.Windows.Forms.Button btnAuthorAdd;
        private System.Windows.Forms.Label lblAuthorName;
        private System.Windows.Forms.TextBox txtAuthorName;
        private System.Windows.Forms.Label lblAuthorLastName;
        private System.Windows.Forms.Button btnAuthorDelete;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.TextBox txtAuthorLastName;
        private System.Windows.Forms.DateTimePicker dtpDatetime;
        private System.Windows.Forms.GroupBox gbAuthorUpdate;
        private System.Windows.Forms.DateTimePicker dtpBrithdateUpdate;
        private System.Windows.Forms.TextBox txtAuthorLastNameUpdate;
        private System.Windows.Forms.TextBox txtMailUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAuthorUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAuthorNameUpdate;
        private System.Windows.Forms.Label label4;
    }
}