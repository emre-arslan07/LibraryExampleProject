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
    public partial class CategoryPage : Form
    {
        private ICategoryService _categoryService;
        public CategoryPage()
        {
            InitializeComponent();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
        }

        public void LoadCategories()
        {
            dgvList.DataSource = _categoryService.GetAll();

        }
        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCategoryNameUpdate.Text = dgvList.CurrentRow.Cells[1].Value.ToString();
        }

        private void CategoryPage_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                _categoryService.Delete(new Category()
                {
                    CategoryID=Convert.ToInt32(dgvList.CurrentRow.Cells[0].Value)
                });
                LoadCategories();
                MessageBox.Show("Silme işlemi Başarılı");
                Cleaner.CleanForm(this.Controls);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            
            try
            {
                _categoryService.Add(new Category()
                {
                    CategoryName = txtCategoryName.Text
                });
                
                MessageBox.Show("Ekleme işlemi başarılı");
                Cleaner.CleanForm(this.Controls);
                LoadCategories();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            try
            {
                _categoryService.Update(new Category()
                {
                    CategoryID = Convert.ToInt32(dgvList.CurrentRow.Cells[0].Value),
                    CategoryName = txtCategoryNameUpdate.Text
                });
                MessageBox.Show("Güncelleme işlemi başarılı");
                Cleaner.CleanForm(this.Controls);
                LoadCategories();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
