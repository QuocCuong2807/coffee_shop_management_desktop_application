using QuanlyCoffee.DAO;
using QuanlyCoffee.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QuanlyCoffee
{
    public partial class Management : Form
    {
        BindingSource category_list = new BindingSource();
        BindingSource food_list = new BindingSource();
        BindingSource table_list = new BindingSource();

        public Management()
        {
            InitializeComponent();
            showList();

        }

        void showList()
        {
            dataGridViewFoodCategory.DataSource = category_list;
            dataGridViewFood.DataSource = food_list;
            dataGridViewTable.DataSource = table_list;
            showFoodCategory();
            showFoodList();
            showTableList();
            foodBinding();
            categoryBinding();
            tableBinding();
        }


        //start show data grid view
        void showFoodCategory() 
        {
            category_list.DataSource = FoodCategoryDAO.Instance.getAllCategory();
        }

        void showFoodList() 
        {
            food_list.DataSource = FoodDAO.getInstance.getAllFood();
        }

        void showTableList()
        {
            table_list.DataSource = TablePlaceDAO.Instance.GetAllTablePlaces();
        }
        //end show data grid view


        //start Binding
        void foodBinding() 
        {
            txbFoodName.DataBindings.Add(new Binding("Text", dataGridViewFood.DataSource, "food_name"));
            numericPrice.DataBindings.Add(new Binding("Value", dataGridViewFood.DataSource, "price"));
            displayCategoryName();
        }

        void displayCategoryName() 
        {
            cbCategory.DataSource = FoodCategoryDAO.Instance.getAllCategory();
            cbCategory.DisplayMember = "category_name";
        }

        void categoryBinding() 
        {
            txbCategoryName.DataBindings.Add(new Binding("Text", dataGridViewFoodCategory.DataSource, "category_name"));
        }

        void tableBinding() 
        {
            txbTableName.DataBindings.Add(new Binding("Text", dataGridViewTable.DataSource, "table_name"));
        }

        //end Binding

        void reloadCategoryList()
        {
            dataGridViewFoodCategory.Rows.Clear();
            category_list.DataSource = FoodCategoryDAO.Instance.getAllCategory();
            dataGridViewFoodCategory.DataSource = category_list;
        }

        void reloadTableList() 
        {
            dataGridViewTable.Rows.Clear();
            table_list.DataSource = TablePlaceDAO.Instance.GetAllTablePlaces();
            dataGridViewTable.DataSource = table_list;
        }


        //start event
        private void tabFood_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txbFoodName_TextChanged(object sender, EventArgs e)
        {
            if(dataGridViewFood.SelectedCells.Count > 0) 
            {
                int id = (int)dataGridViewFood.SelectedCells[0].OwningRow.Cells["categoryId"].Value;

                FoodCategory category = FoodCategoryDAO.Instance.GetById(id);

                cbCategory.SelectedItem = category;

                int index = -1;

                for(int i = 0; i< cbCategory.Items.Count; i++) 
                {
                    FoodCategory temp_category = cbCategory.Items[i] as FoodCategory;

                    if (temp_category.Category_id == category.Category_id)
                    {
                        index = i; break;
                    }
                }
                cbCategory.SelectedIndex = index;
            }
        }

        // thêm danh mục mới
        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string category_name = txbCategoryName.Text.ToString();

            int rowChanged = 0;

            if(MessageBox.Show("Thêm mới với dữ liệu đã nhập ?","notice", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                rowChanged = FoodCategoryDAO.Instance.addNewCategory(category_name);
            }

            if(rowChanged > 0) 
            {
                MessageBox.Show("Thêm thành công");
                reloadCategoryList();
            }
            else 
                MessageBox.Show("Thêm thất bại");


        }

        // xoá danh mục đang chọn
        private void btnRemoveCategory_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridViewFoodCategory.SelectedCells[0].OwningRow.Cells["category_id"].Value;

            FoodCategory category = FoodCategoryDAO.Instance.GetById(id);

            int rowChanged = 0;

            if (MessageBox.Show("Bạn có chắc chắn muốn xoá ?", "notice", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                rowChanged = FoodCategoryDAO.Instance.deleteCategory(category);
            }

            if (rowChanged > 0)
            {
                MessageBox.Show("Xoá thành công");
                reloadCategoryList();
            }
            else
                MessageBox.Show("Xoá thất bại");
        }

        // cập nhật thông tin danh mục
        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            string name = txbCategoryName.Text.ToString();

            int id = (int)dataGridViewFoodCategory.SelectedCells[0].OwningRow.Cells["category_id"].Value;

            int rowChanged = 0;
            if (MessageBox.Show("Cập nhật danh mục ?", "notice", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                rowChanged = FoodCategoryDAO.Instance.updateCategory(name, id);
            }

            if (rowChanged > 0)
            {
                MessageBox.Show("Cập nhật thành công");
                reloadCategoryList();
            }
            else
                MessageBox.Show("Cập nhật thất bại");
        }


        // thêm món mới
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            FoodCategory category = cbCategory.SelectedItem as FoodCategory;
            int category_id = category.Category_id; 
            string food_name = txbFoodName.Text.ToString();
            int price = (int)numericPrice.Value;

            int rowChanged = 0;
            if (MessageBox.Show("Thêm món mới ?", "notice", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                rowChanged = FoodDAO.getInstance.insertFood(new Food(food_name, price, category_id));
            }

            if (rowChanged > 0)
            {
                MessageBox.Show("Thêm thành công");
            }
            else
                MessageBox.Show("Thêm thất bại");


        }

        private void btnRemoveFood_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridViewFood.SelectedCells[0].OwningRow.Cells["food_id"].Value;

            Food food = FoodDAO.getInstance.getFoodById(id);

            int rowChanged = 0;
            if (MessageBox.Show("Xoá món hiện tại ?", "notice", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                rowChanged = FoodDAO.getInstance.deleteFood(food);
            }

            if (rowChanged > 0)
            {
                MessageBox.Show("Xoá thành công");
            }
            else
                MessageBox.Show("Xoá thất bại");
        }

        //xem món ăn
        private void btnView_Click(object sender, EventArgs e)
        {
            food_list.DataSource = FoodDAO.getInstance.getAllFood();
        }

        private void btnUpdateFood_Click(object sender, EventArgs e)
        {
            string food_name = txbFoodName.Text.ToString();
            FoodCategory category = cbCategory.SelectedItem as FoodCategory;
            int category_id = category.Category_id;
            int price = (int)numericPrice.Value;

            int id = (int)dataGridViewFood.SelectedCells[0].OwningRow.Cells["food_id"].Value;

            int rowChanged = 0;
            if (MessageBox.Show("Cập nhật món hiện tại ?", "notice", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                rowChanged = FoodDAO.getInstance.updateFood(new Food(id, food_name, price, category_id));
            }

            if (rowChanged > 0)
            {
                MessageBox.Show("Cập nhật thành công");
            }
            else
                MessageBox.Show("Cập nhật thất bại");
        }

        //thêm bàn mới
        private void btnAddTable_Click(object sender, EventArgs e)
        {
            string name = txbTableName.Text.ToString();
            int rowChanged = 0;
            if (MessageBox.Show("Thêm bàn mới ?", "notice", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                rowChanged = TablePlaceDAO.Instance.insertNewTable(name);
            }

            if (rowChanged > 0) 
            {
                MessageBox.Show("Thêm thành công");
                reloadTableList();
            }
            else
                MessageBox.Show("Thất bại!");

        }

        private void btnRemoveTable_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridViewTable.SelectedCells[0].OwningRow.Cells["table_id"].Value;
            int rowChanged = 0;
            if (MessageBox.Show("Xoá bàn hiện tại ?", "notice", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                rowChanged = TablePlaceDAO.Instance.deleteTable(id);
            }

            if (rowChanged > 0)
            {
                MessageBox.Show("Xoá thành công");
                reloadTableList();
            }
            else
                MessageBox.Show("Thất bại!");
        }

        //cập nhật tên bàn
        private void updateTable_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridViewTable.SelectedCells[0].OwningRow.Cells["table_id"].Value;
            string name = txbTableName.Text.ToString();
            string stat = "Trống";

            int rowChanged = 0;
            if (MessageBox.Show("Cập nhật bàn hiện tại ?", "notice", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                rowChanged = TablePlaceDAO.Instance.updataTable(new TablePlace(id, name, stat));
            }

            if (rowChanged > 0)
            {
                MessageBox.Show("Cập nhật thành công");
                reloadTableList();
            }
            else
                MessageBox.Show("Thất bại!");

        }
        //end event
    }
}
