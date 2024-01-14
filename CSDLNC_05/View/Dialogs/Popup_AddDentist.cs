using CSDLNC_05.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSDLNC_05.View.Dialogs
{
    public partial class Popup_AddDentist : Form
    {
        public Popup_AddDentist()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Popup_AddDentist_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            string username = this.txt_username.Text;
            string password = this.txt_password.Text;   
            string fullname = this.txt_fullname.Text;
            string phonenum = this.txt_PhoneNum.Text;
            string email = this.txt_email.Text;
            string address = this.txt_Address.Text;
            string cert = this.txtbox_cert.Text;
            bool gender = false;
            DateTime dob = this.dt_dob.Value;
            if (cb_GenderMale.Checked==true) { gender = true; }
            User user = new User(-1, username, password,fullname,dob,phonenum,email,address,gender,Program.workingBranchId);

            bool result = User.AddDentist(user, cert);
            if (result)
            {
                MessageBox.Show(
                    "Thêm thông tin nha sĩ thành công!",
                    "Thành công!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return;
            }
            else
            {
                MessageBox.Show(
                    "Thêm thông tin nha sĩ không thành công!",
                    "Thất bại!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }
        }
    }
}
