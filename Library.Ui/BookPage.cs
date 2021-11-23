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
    public partial class BookPage : Form
    {
       
        private IBookService _bookService;
        private ICategoryService _categoryService;
        private IAuthorService _authorService;
        public BookPage()
        {
            InitializeComponent();
            _bookService = InstanceFactory.GetInstance<IBookService>();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
            _authorService = InstanceFactory.GetInstance<IAuthorService>();
            
        }
        private void LoadCategories()
        {
            cbCategoryName.DataSource = _categoryService.GetAll();
            cbCategoryName.DisplayMember = "CategoryName";
            cbCategoryName.ValueMember = "CategoryID";

            cbCategoryUpdate.DataSource = _categoryService.GetAll();
            cbCategoryUpdate.DisplayMember = "CategoryName";
            cbCategoryUpdate.ValueMember = "CategoryID";
        }

        private void LoadAuthors()
        {
            cbAuthorName.DataSource = _authorService.GetAll();
            cbAuthorName.DisplayMember = "FullName";
            cbAuthorName.ValueMember = "AuthorID";

            cbAuthorUpdate.DataSource = _authorService.GetAll();
            cbAuthorUpdate.DisplayMember = "FullName";
            cbAuthorUpdate.ValueMember = "AuthorID";
        }

        private void LoadBooks()
        {
            dgvList.DataSource = _bookService.GetAll();
        }
        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBookyNameUpdate.Text = dgvList.CurrentRow.Cells[1].Value.ToString();
            txtShelfNumberUpdate.Text = dgvList.CurrentRow.Cells[2].Value.ToString();
            cbCategoryUpdate.SelectedValue = dgvList.CurrentRow.Cells[3].Value;
            cbAuthorUpdate.SelectedValue = dgvList.CurrentRow.Cells[4].Value;

        }

        private void btnBookAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _bookService.Add(new Book()
                {
                    AuthorID=Convert.ToInt32(cbAuthorName.SelectedValue),
                    BookName=txtBookNameAdd.Text,
                    CategoryID=Convert.ToInt32(cbCategoryName.SelectedValue),
                    ShelfNumber=txtShelfNumber.Text
                });
                LoadBooks();
                MessageBox.Show("Ekleme işlemi başarılı");
                Cleaner.CleanForm(this.Controls);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnBookUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _bookService.Update(new Book()
                {
                    BookID = Convert.ToInt32(dgvList.CurrentRow.Cells[0].Value),
                    BookName = txtBookyNameUpdate.Text,
                    ShelfNumber = txtShelfNumberUpdate.Text,
                    CategoryID = Convert.ToInt32(dgvList.CurrentRow.Cells[3].Value),
                    AuthorID = Convert.ToInt32(dgvList.CurrentRow.Cells[4].Value)
                });
                LoadBooks();
                MessageBox.Show("Güncelleme işlemi başarılı");
                Cleaner.CleanForm(this.Controls);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnBookDelete_Click(object sender, EventArgs e)
        {
            try
            {
                _bookService.Delete(new Book()
                {
                    BookID=Convert.ToInt32(dgvList.CurrentRow.Cells[0].Value)
                });
                MessageBox.Show("Silme işlemi başarılı");
                LoadBooks();
                Cleaner.CleanForm(this.Controls);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void BookPage_Load(object sender, EventArgs e)
        {
            LoadAuthors();
            LoadCategories();
            LoadBooks();
            cbAuthorName.SelectedIndex = -1;
            cbCategoryName.SelectedIndex = -1;
            cbCategoryUpdate.SelectedIndex = -1;
            cbAuthorUpdate.SelectedIndex = -1;

            

            

        }
    }
}
