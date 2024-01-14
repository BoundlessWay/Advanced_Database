namespace CSDLNC_05.View.Dialogs
{
    partial class Popup_AddDentist
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dt_dob = new DateTimePicker();
            label7 = new Label();
            txt_Address = new TextBox();
            cb_GenderFemale = new CheckBox();
            cb_GenderMale = new CheckBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txt_email = new TextBox();
            txt_PhoneNum = new TextBox();
            txt_fullname = new TextBox();
            label1 = new Label();
            btn_OK = new Button();
            txt_username = new TextBox();
            txt_password = new TextBox();
            label9 = new Label();
            label10 = new Label();
            lb_cert = new Label();
            txtbox_cert = new TextBox();
            SuspendLayout();
            // 
            // dt_dob
            // 
            dt_dob.Location = new Point(149, 179);
            dt_dob.Margin = new Padding(3, 2, 3, 2);
            dt_dob.Name = "dt_dob";
            dt_dob.Size = new Size(219, 23);
            dt_dob.TabIndex = 51;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(65, 280);
            label7.Name = "label7";
            label7.Size = new Size(46, 15);
            label7.TabIndex = 48;
            label7.Text = "Địa chỉ ";
            // 
            // txt_Address
            // 
            txt_Address.Location = new Point(148, 278);
            txt_Address.Margin = new Padding(3, 2, 3, 2);
            txt_Address.Name = "txt_Address";
            txt_Address.Size = new Size(195, 23);
            txt_Address.TabIndex = 47;
            // 
            // cb_GenderFemale
            // 
            cb_GenderFemale.AutoSize = true;
            cb_GenderFemale.Location = new Point(243, 152);
            cb_GenderFemale.Margin = new Padding(3, 2, 3, 2);
            cb_GenderFemale.Name = "cb_GenderFemale";
            cb_GenderFemale.Size = new Size(45, 19);
            cb_GenderFemale.TabIndex = 46;
            cb_GenderFemale.Text = "Nữ ";
            cb_GenderFemale.UseVisualStyleBackColor = true;
            // 
            // cb_GenderMale
            // 
            cb_GenderMale.AutoSize = true;
            cb_GenderMale.Location = new Point(148, 152);
            cb_GenderMale.Margin = new Padding(3, 2, 3, 2);
            cb_GenderMale.Name = "cb_GenderMale";
            cb_GenderMale.Size = new Size(52, 19);
            cb_GenderMale.TabIndex = 45;
            cb_GenderMale.Text = "Nam";
            cb_GenderMale.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(65, 153);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 44;
            label6.Text = "Giới tính ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(73, 246);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 43;
            label5.Text = "Email ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 214);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 42;
            label4.Text = "Số điện thoại ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 179);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 41;
            label3.Text = "Ngày sinh";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 124);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 40;
            label2.Text = "Họ và tên ";
            // 
            // txt_email
            // 
            txt_email.Location = new Point(148, 244);
            txt_email.Margin = new Padding(3, 2, 3, 2);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(195, 23);
            txt_email.TabIndex = 39;
            // 
            // txt_PhoneNum
            // 
            txt_PhoneNum.Location = new Point(148, 208);
            txt_PhoneNum.Margin = new Padding(3, 2, 3, 2);
            txt_PhoneNum.Name = "txt_PhoneNum";
            txt_PhoneNum.Size = new Size(195, 23);
            txt_PhoneNum.TabIndex = 38;
            // 
            // txt_fullname
            // 
            txt_fullname.Location = new Point(148, 122);
            txt_fullname.Margin = new Padding(3, 2, 3, 2);
            txt_fullname.Name = "txt_fullname";
            txt_fullname.Size = new Size(195, 23);
            txt_fullname.TabIndex = 37;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(136, 14);
            label1.Name = "label1";
            label1.Size = new Size(137, 30);
            label1.TabIndex = 36;
            label1.Text = "Thêm nha sĩ";
            // 
            // btn_OK
            // 
            btn_OK.Location = new Point(161, 381);
            btn_OK.Margin = new Padding(3, 2, 3, 2);
            btn_OK.Name = "btn_OK";
            btn_OK.Size = new Size(97, 33);
            btn_OK.TabIndex = 35;
            btn_OK.Text = "Xác nhận";
            btn_OK.UseVisualStyleBackColor = true;
            btn_OK.Click += btn_OK_Click;
            // 
            // txt_username
            // 
            txt_username.Location = new Point(149, 53);
            txt_username.Margin = new Padding(3, 2, 3, 2);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(193, 23);
            txt_username.TabIndex = 52;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(149, 90);
            txt_password.Margin = new Padding(3, 2, 3, 2);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(193, 23);
            txt_password.TabIndex = 53;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(37, 58);
            label9.Name = "label9";
            label9.Size = new Size(85, 15);
            label9.TabIndex = 55;
            label9.Text = "Tên đăng nhập";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(58, 92);
            label10.Name = "label10";
            label10.Size = new Size(57, 15);
            label10.TabIndex = 56;
            label10.Text = "Mật khẩu";
            // 
            // lb_cert
            // 
            lb_cert.AutoSize = true;
            lb_cert.Location = new Point(66, 312);
            lb_cert.Name = "lb_cert";
            lb_cert.Size = new Size(62, 15);
            lb_cert.TabIndex = 57;
            lb_cert.Text = "Chứng chỉ";
            // 
            // txtbox_cert
            // 
            txtbox_cert.Location = new Point(148, 309);
            txtbox_cert.Margin = new Padding(3, 2, 3, 2);
            txtbox_cert.Name = "txtbox_cert";
            txtbox_cert.Size = new Size(195, 23);
            txtbox_cert.TabIndex = 58;
            // 
            // Popup_AddDentist
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 441);
            Controls.Add(txtbox_cert);
            Controls.Add(lb_cert);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Controls.Add(dt_dob);
            Controls.Add(label7);
            Controls.Add(txt_Address);
            Controls.Add(cb_GenderFemale);
            Controls.Add(cb_GenderMale);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_email);
            Controls.Add(txt_PhoneNum);
            Controls.Add(txt_fullname);
            Controls.Add(label1);
            Controls.Add(btn_OK);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Popup_AddDentist";
            Text = "Popup_AddDentist";
            Load += Popup_AddDentist_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dt_dob;
        private Label label7;
        private TextBox txt_Address;
        private CheckBox cb_gender2;
        private CheckBox cb_gender1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txt_email;
        private TextBox txt_PhoneNum;
        private TextBox txt_fullname;
        private Label label1;
        private Button btn_OK;
        private TextBox txt_username;
        private TextBox txt_password;
        private Label label9;
        private Label label10;
        private CheckBox cb_GenderFemale;
        private CheckBox cb_GenderMale;
        private Label lb_cert;
        private TextBox txtbox_cert;
    }
}