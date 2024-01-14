using CSDLNC_05.Controllers;
using CSDLNC_05.View.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSDLNC_05.View
{
    public partial class UI_DentistInfo : Form
    {
        public UI_DentistInfo()
        {
            InitializeComponent();
            update_Dentist();

        }
        private void update_Dentist()
        {
            List<User> dentists = User.getListUserInfoRoleDentist(Program.workingBranchId);
            if (dentists == null || dentists.Count == 0)
            {
                MessageBox.Show(
                    "Không có dữ liệu!",
                    "Không có dữ liệu!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                this.dgv_dentist = null;
                this.dgv_dentist.Rows.Clear();
                return;
            }
            this.dgv_dentist.DataSource = null;
            this.dgv_dentist.Rows.Clear();
            foreach (User dentist in dentists)
            {

                this.dgv_dentist.Rows.Add(
                    dentist.id,
                    dentist.full_name,
                    (dentist.gender == true ? "Nam" : "Nữ"),
                    dentist.date_of_birth,
                    dentist.email,
                    dentist.phone_number,
                    dentist.permanent_address,
                    dentist.working_branch_id

                );
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user_role = Program.currentUserRole;
            if (user_role != "ADMIN")
            {
                MessageBox.Show(
                    "Chỉ admin mới có quyền thêm",
                    "Thông báo!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            Popup_AddDentist popup_add_dentist = new Popup_AddDentist();
            popup_add_dentist.ShowDialog();

            update_Dentist();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int idx = Program.previousForm.Count - 1;
            Form prvForm = Program.previousForm[idx];
            Program.previousForm.RemoveAt(idx);
            prvForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {


        }

        private string searchContent = "";
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            searchContent = txt_Search.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string user_role = Program.currentUserRole;
            if (user_role != "ADMIN")
            {
                MessageBox.Show(
                    "Chỉ admin mới có quyền sửa",
                    "Thông báo!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            var selectedRow = this.dgv_dentist.SelectedRows;

            if (selectedRow.Count == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn nha sĩ cần chỉnh sửa!",
                    "Thông báo!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            int idx = this.dgv_dentist.SelectedRows[0].Index;
            int dentist_id = Convert.ToInt32(this.dgv_dentist.Rows[idx].Cells[0].Value);

            Popup_UpdateDentist popup_update_dentist = new Popup_UpdateDentist(dentist_id);
            popup_update_dentist.ShowDialog();
            update_Dentist();
            this.dgv_dentist.Rows[idx].Selected = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void dgv_dentist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UI_DentistInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
