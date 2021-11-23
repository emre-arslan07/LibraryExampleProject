using Library.BLL.Abstract;
using Library.BLL.DependencyResolver.Ninject;
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
    public partial class MainPage : Form
    {
        private IAuthorService _authorService;
        private ICategoryService _categoryService;
        private IBookService _bookService;
        public MainPage()
        {
            InitializeComponent();
            _authorService = InstanceFactory.GetInstance<IAuthorService>();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
            _bookService = InstanceFactory.GetInstance<IBookService>();

        }

        private void LoadCategories()
        {
            cbCategory.DataSource = _categoryService.GetAll();
            cbCategory.DisplayMember = "CategoryName";
            cbCategory.ValueMember = "CategoryID";
        }

        private void LoadAuthors()
        {
            cbAuthorSearch.DataSource = _authorService.GetAll();
            cbAuthorSearch.DisplayMember = "FullName";
            cbAuthorSearch.ValueMember = "AuthorID";
        }

        private void LoadBooks()
        {
            dgvList.DataSource = _bookService.GetAll();
            dgvList.Columns[0].Visible = false;
            dgvList.Columns[3].Visible = false;
            dgvList.Columns[4].Visible = false;

        }

        private void txtBookName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBookName.Text))
            {
                LoadBooks();
            }
            else
            {
                dgvList.DataSource = _bookService.GetBookByBookName(txtBookName.Text);
            }
        }

        private void btnBookProcess_Click(object sender, EventArgs e)
        {
            BookPage bookPage = new BookPage();
            bookPage.Show();
        }

        private void btnAuthorProcess_Click(object sender, EventArgs e)
        {
            AuthorPage authorPage = new AuthorPage();
            authorPage.ShowDialog();

        }

        private void btnCategoryProcess_Click(object sender, EventArgs e)
        {
            CategoryPage categoryPage = new CategoryPage();
            categoryPage.Show();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadAuthors();
            cbAuthorSearch.SelectedIndex = -1;
            cbCategory.SelectedIndex = -1;
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbCategory.SelectedIndex==-1)
                {
                    LoadBooks();
                }
                else
                {
                    dgvList.DataSource = _bookService.GetBookByCategoryID(Convert.ToInt32(cbCategory.SelectedValue));
                }
            }
            catch { }
        }

        private void cbAuthorSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbAuthorSearch.SelectedIndex == -1)
                {
                    LoadBooks();
                }
                else
                {
                    dgvList.DataSource = _bookService.GetBookByAuthorId(Convert.ToInt32(cbAuthorSearch.SelectedValue));
                }
            }
            catch { }
        }
    }
}
