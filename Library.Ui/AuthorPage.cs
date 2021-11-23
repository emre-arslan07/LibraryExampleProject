using Library.BLL.Abstract;
using Library.BLL.DependencyResolver.Ninject;
using Library.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Ui
{
    public partial class AuthorPage : Form
    {
        IAuthorService _authorService;
        public AuthorPage()
        {
            InitializeComponent();
            _authorService = InstanceFactory.GetInstance<IAuthorService>();
        }
        void LoadAuthors()
        {
            dgvList.DataSource = _authorService.GetAll();
        }
        private void btnBookAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _authorService.Add(new Author()
                {
                    AuthorName = txtAuthorName.Text,
                    AuthorLastName = txtAuthorLastName.Text,
                    BirthDate = Convert.ToDateTime(dtpDatetime.Value),
                    Email = txtMail.Text
                });
                LoadAuthors();
                MessageBox.Show("Ekleme işlemi başarılı");
                Cleaner.CleanForm(this.Controls);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnAuthorUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _authorService.Update(new Author()
                {
                    AuthorID = Convert.ToInt32(dgvList.CurrentRow.Cells[0].Value),
                    AuthorName = txtAuthorNameUpdate.Text,
                    AuthorLastName = txtAuthorLastNameUpdate.Text,
                    BirthDate = dtpBrithdateUpdate.Value,
                    Email = txtMailUpdate.Text
                });
                MessageBox.Show("Güncelleme işlemi başarılı");
                LoadAuthors();
                Cleaner.CleanForm(this.Controls);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnAuthorDelete_Click(object sender, EventArgs e)
        {
            try
            {
                _authorService.Delete(new Author()
                {
                    AuthorID = Convert.ToInt32(dgvList.CurrentRow.Cells[0].Value)
                });
                MessageBox.Show("Silme işlemi başarılı");
                LoadAuthors();
                Cleaner.CleanForm(this.Controls);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAuthorNameUpdate.Text = dgvList.CurrentRow.Cells[1].Value.ToString();
            txtAuthorLastNameUpdate.Text = dgvList.CurrentRow.Cells[2].Value.ToString();
            dtpBrithdateUpdate.Value = Convert.ToDateTime(dgvList.CurrentRow.Cells[3].Value);
            txtMailUpdate.Text = dgvList.CurrentRow.Cells[4].Value.ToString();
        }

        private void AuthorPage_Load_1(object sender, EventArgs e)
        {
            LoadAuthors();
        }
    }
}
