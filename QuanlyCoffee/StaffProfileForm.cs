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
    public partial class StaffProfileForm : Form
    {
        public StaffProfileForm()
        {
            InitializeComponent();
            showProfile();
        }

        void showProfile() 
        {
            txbFullName.Text = StaffDAO.getInstance.getStaffName(IsWorkingStaff.staff_id);
            txbRoll.Text = StaffDAO.getInstance.getStaffRole(IsWorkingStaff.staff_id);
        }

        private void txbFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
