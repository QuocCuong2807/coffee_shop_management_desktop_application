using QuanlyCoffee.DAO;
using QuanlyCoffee.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlyCoffee
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txbTaikhoan.Text;
            string passWord = txbPassword.Text;

            if (logIn(userName, passWord)) 
            {
                MainForm mainForm = new MainForm();
                this.Hide();
                mainForm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu");
            }
        }

        bool logIn(string userName, string passWord) 
        {
            Staff staff = StaffDAO.getInstance.logIn(userName, passWord);
            if(staff != null) 
            {
                //lưu username của nhân viên trong ca vào static class IsWorkingStaff
                IsWorkingStaff.staff_id = staff.Staff_username;
                return true;
            }
            return false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Đồng ý thoát?", "notice", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                e.Cancel = true;
        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
