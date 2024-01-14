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
    public partial class UI_StaffInfo : Form
    {
        public UI_StaffInfo()
        {
            InitializeComponent();
            update_Staff();
        }
        private void update_Staff()
        {
            List<User> staffs = User.getListUserInfoRoleStaff(Program.workingBranchId);
            if (staffs == null || staffs.Count == 0)
            {
                MessageBox.Show(
                    "Không có dữ liệu!",
                    "Không có dữ liệu!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                this.dgv_staff = null;
                this.dgv_staff.Rows.Clear();
                return;
            }
            this.dgv_staff.DataSource = null;
            this.dgv_staff.Rows.Clear();
            foreach (User staff in staffs)
            {

                this.dgv_staff.Rows.Add(
                    staff.id,
                    staff.full_name,
                    (staff.gender == true ? "Nữ" : "Nam"),
                    staff.date_of_birth,
                    staff.email,
                    staff.phone_number,
                    staff.permanent_address,
                    staff.working_branch_id

                );
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            int idx = Program.previousForm.Count - 1;
            Form prvForm = Program.previousForm[idx];
            Program.previousForm.RemoveAt(idx);
            prvForm.Show();
            this.Hide();
        }

        private void btn_Update_Click(object sender, EventArgs e)
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
            var selectedRow = this.dgv_staff.SelectedRows;

            if (selectedRow.Count == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn nhân viên cần chỉnh sửa!",
                    "Thông báo!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            int idx = this.dgv_staff.SelectedRows[0].Index;
            int staff_id = Convert.ToInt32(this.dgv_staff.Rows[idx].Cells[0].Value);

            Popup_UpdateStaff popup_update_staff = new Popup_UpdateStaff(staff_id);
            popup_update_staff.ShowDialog();
            update_Staff();
            this.dgv_staff.Rows[idx].Selected = true;

        }

        private void btn_Add_Click(object sender, EventArgs e)
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

            Popup_AddStaff ui = new Popup_AddStaff();
            ui.ShowDialog();

            update_Staff();
        }

        private void dgv_staff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
