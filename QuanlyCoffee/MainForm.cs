using QuanlyCoffee.DAO;
using QuanlyCoffee.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlyCoffee
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            loadTable();
            displayFoodCategory();
        }
        //load table
        void loadTable() 
        {
            List<TablePlace> tableList = TablePlaceDAO.Instance.GetAllTablePlaces();

            foreach (TablePlace tablePlace in tableList) 
            {
                Button button = new Button() { Width = TablePlace.width, Height = TablePlace.height};
                button.Text = tablePlace.Table_name + Environment.NewLine + tablePlace.Stat;
                button.Tag = tablePlace;
                listViewOrder.Tag = tablePlace;
                button.Click += btn_Click;
                switch (tablePlace.Stat) 
                {
                    case "Trống":
                        button.BackColor = Color.White;
                        break;
                    case "Có người":
                        button.BackColor = Color.LightYellow;
                        break; 
                    default:
                        break;
                }

                flowPnlTable.Controls.Add(button); 
            }
        }

        //reload table

        void reloadTable() 
        {
            flowPnlTable.Controls.Clear();
            List<TablePlace> tableList = TablePlaceDAO.Instance.GetAllTablePlaces();

            foreach (TablePlace tablePlace in tableList)
            {
                Button button = new Button() { Width = TablePlace.width, Height = TablePlace.height };
                button.Text = tablePlace.Table_name + Environment.NewLine + tablePlace.Stat;
                button.Tag = tablePlace;
                listViewOrder.Tag = tablePlace;
                button.Click += btn_Click;
                switch (tablePlace.Stat)
                {
                    case "Trống":
                        button.BackColor = Color.White;
                        break;
                    case "Có người":
                        button.BackColor = Color.LightYellow;
                        break;
                    default:
                        break;
                }

                flowPnlTable.Controls.Add(button);
            }
        }
        

        //Hien thi hoa don

        void showOrders(TablePlace tablePlace) 
        {
            listViewOrder.Items.Clear();
            List<CustomerOrder> customerOrdersList = CustomerOrderDAO.getInstance.GetUnPayCustomerOrders(tablePlace);

            //change culture to Viet Nam
            CultureInfo culture = new CultureInfo("vi-VN");

            //add data to list view
            int total = 0;
            foreach(CustomerOrder customerOrder in customerOrdersList) 
            {
                ListViewItem listViewItem = new ListViewItem(customerOrder.FoodName.ToString());
                listViewItem.SubItems.Add(customerOrder.Price.ToString("c", culture));
                listViewItem.SubItems.Add(customerOrder.Quantity.ToString());
                listViewItem.SubItems.Add(customerOrder.TotalPrice.ToString("c", culture));
                total += customerOrder.TotalPrice;
                listViewOrder.Items.Add(listViewItem);
            }
            txbTotalPrice.Text = total.ToString("c", culture);

        }

        //Hiển thị danh mục thực phẩm

        void displayFoodCategory()
        {
            List<FoodCategory> categoryList = FoodCategoryDAO.Instance.getAllCategory();
            listCategory.DataSource = categoryList;
            listCategory.DisplayMember = "category_name";
        }

        //hiển thị thực phẩm theo danh mục
        void displayFoodByCategory(FoodCategory foodCategory) 
        {
            List<Food> foodList = FoodDAO.getInstance.getFoodListByCategory(foodCategory);
            listFood.DataSource = foodList;
            listFood.DisplayMember = "food_name";
        }
        //start event-------------------------------------------------------------------------------------------------

        void btn_Click(object sender,EventArgs e) 
        {
            TablePlace tablePlace = ((sender as Button).Tag) as TablePlace;
            listViewOrder.Tag = tablePlace;
            showOrders(tablePlace);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void listOrders_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panelTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaffProfileForm staffProfileForm = new StaffProfileForm();
            this.Hide();
            staffProfileForm.ShowDialog();
            this.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Management managementForm = new Management();
            this.Hide();
            managementForm.ShowDialog();
            this.Show();
        }

        private void listOrder_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //hiển thị món
        private void listCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;

            //kiem tra category != null
            if (comboBox.SelectedItem == null)
                return;

            FoodCategory foodCategory = comboBox.SelectedItem as FoodCategory;

            displayFoodByCategory(foodCategory);
        }

        //thêm món
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            //lấy ra bàn đang được chọn qua thẻ tag của button
            TablePlace tablePlace = listViewOrder.Tag as TablePlace;
            Food food = listFood.SelectedItem as Food;
            Order order = OrderDAO.getInstance.getUnpayOrderByTable(tablePlace);
            int quantity = (int)numericFoodQuantity.Value;
            // kiểm tra hoá đơn đã tồn tại chưa thông qua đối tượng TablePlace (bàn trống)
            //- chưa tồn tại:
            if (order == null) 
            {
                //--add hoá đơn và chi tiết hoá đơn mới
                string newOrderID = OrderDAO.getInstance.insertAndReturnOrderID(IsWorkingStaff.staff_id, tablePlace);
                Order newOrder = OrderDAO.getInstance.GetOrderById(newOrderID);
                bool rowChangedOrder = false;

                if (newOrder != null) 
                    rowChangedOrder =  OrderDetailDAO.getInstance.insertOrderDetailsByOrder(newOrder , food ,quantity);
                if(rowChangedOrder)
                    TablePlaceDAO.Instance.updateCheckInTableStatus(tablePlace);
            }
                //đã tồn tại
            else 
            {
                //-- kiểm tra mã món ăn thêm vào chi tiết hoá đơn đã tồn tại chưa
                OrderDetails orderDetails = OrderDetailDAO.getInstance.GetOrderDetailsByFoodAndOrderID(food , order);// lấy ra chi tiết hoá đơn
                // chưa tồn tại:
                if(orderDetails == null) 
                    OrderDetailDAO.getInstance.insertOrderDetailsByOrder(order, food, quantity); // thêm mới:
                // đã tồn tại
                else 
                    OrderDetailDAO.getInstance.updateFoodQuantityByOrderDetailsID(orderDetails , quantity); //cập nhật lại số lượng và giá tiền

            }
            showOrders(tablePlace);
            MessageBox.Show("Thêm món thành công");
            reloadTable();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            //lấy ra bàn đang được chọn qua thẻ tag của list view
            TablePlace tablePlace = listViewOrder.Tag as TablePlace;

            //lấy ra hoá đơn chưa thanh toán theo bàn
            Order order = OrderDAO.getInstance.getUnpayOrderByTable(tablePlace);

            //kiểm tra hoá đơn
            if (order == null)
            {
                MessageBox.Show("Chưa có hoá đơn để thanh toán");
                return;
            }
            if(MessageBox.Show("Thanh toán hoá đơn cho bàn " + tablePlace.Table_name + " ?","notice",
                                MessageBoxButtons.OKCancel)==System.Windows.Forms.DialogResult.OK)
            {
                OrderDAO.getInstance.updateOrderStatusAndCheckOutDate(order);
                TablePlaceDAO.Instance.updateCheckOutTableStatus(tablePlace);
            }

            showOrders(tablePlace);
            reloadTable();
        }

        private void txbTotalPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            IsWorkingStaff.staff_id = null;
            this.Close();
        }


        //end event-------------------------------------------------------------------------------------------------
    }
}
