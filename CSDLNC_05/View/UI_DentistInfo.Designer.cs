namespace CSDLNC_05.View
{
    partial class UI_DentistInfo
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
            btn_Add = new Button();
            btn_update = new Button();
            txt_Search = new TextBox();
            btn_Search = new Button();
            label1 = new Label();
            btn_Back = new Button();
            dgv_dentist = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgv_dentist).BeginInit();
            SuspendLayout();
            // 
            // btn_Add
            // 
            btn_Add.Location = new Point(10, 50);
            btn_Add.Margin = new Padding(3, 2, 3, 2);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(63, 22);
            btn_Add.TabIndex = 1;
            btn_Add.Text = "Add";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += button1_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(84, 50);
            btn_update.Margin = new Padding(3, 2, 3, 2);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(63, 22);
            btn_update.TabIndex = 3;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += button3_Click;
            // 
            // txt_Search
            // 
            txt_Search.Location = new Point(133, 9);
            txt_Search.Margin = new Padding(3, 2, 3, 2);
            txt_Search.Name = "txt_Search";
            txt_Search.Size = new Size(364, 23);
            txt_Search.TabIndex = 4;
            txt_Search.TextChanged += textBox1_TextChanged;
            // 
            // btn_Search
            // 
            btn_Search.BackColor = SystemColors.ActiveCaption;
            btn_Search.FlatStyle = FlatStyle.Popup;
            btn_Search.ForeColor = SystemColors.Desktop;
            btn_Search.Location = new Point(502, 9);
            btn_Search.Margin = new Padding(3, 2, 3, 2);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(68, 20);
            btn_Search.TabIndex = 5;
            btn_Search.Text = "Search";
            btn_Search.UseVisualStyleBackColor = false;
            btn_Search.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 14);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 6;
            label1.Text = "Nha sĩ";
            // 
            // btn_Back
            // 
            btn_Back.Location = new Point(0, 1);
            btn_Back.Margin = new Padding(3, 2, 3, 2);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(66, 22);
            btn_Back.TabIndex = 7;
            btn_Back.Text = "Quay lại";
            btn_Back.UseVisualStyleBackColor = true;
            btn_Back.Click += button5_Click;
            // 
            // dgv_dentist
            // 
            dgv_dentist.AllowUserToAddRows = false;
            dgv_dentist.AllowUserToDeleteRows = false;
            dgv_dentist.AllowUserToResizeColumns = false;
            dgv_dentist.AllowUserToResizeRows = false;
            dgv_dentist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_dentist.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dgv_dentist.BackgroundColor = SystemColors.ControlLightLight;
            dgv_dentist.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dgv_dentist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_dentist.Columns.AddRange(new DataGridViewColumn[] { Column1, Column3, Column8, Column2, Column4, Column5, Column6, Column7 });
            dgv_dentist.Location = new Point(0, 76);
            dgv_dentist.Margin = new Padding(3, 2, 3, 2);
            dgv_dentist.MultiSelect = false;
            dgv_dentist.Name = "dgv_dentist";
            dgv_dentist.ReadOnly = true;
            dgv_dentist.RowHeadersVisible = false;
            dgv_dentist.RowHeadersWidth = 51;
            dgv_dentist.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgv_dentist.RowTemplate.Height = 29;
            dgv_dentist.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_dentist.Size = new Size(762, 280);
            dgv_dentist.TabIndex = 20;
            dgv_dentist.CellContentClick += dgv_dentist_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Fullname";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.HeaderText = "Gender";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Date of Birth";
            Column2.MinimumWidth = 3;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Email";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Phone Number";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "Address";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.HeaderText = "working branch";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // UI_DentistInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(766, 354);
            Controls.Add(dgv_dentist);
            Controls.Add(btn_Back);
            Controls.Add(label1);
            Controls.Add(btn_Search);
            Controls.Add(txt_Search);
            Controls.Add(btn_update);
            Controls.Add(btn_Add);
            ForeColor = SystemColors.Desktop;
            Margin = new Padding(3, 2, 3, 2);
            Name = "UI_DentistInfo";
            Text = "UI_DentistInfo";
            Load += UI_DentistInfo_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_dentist).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_Add;
        private Button btn_update;
        private TextBox txt_Search;
        private Button btn_Search;
        private Label label1;
        private Button btn_Back;
        private DataGridView dgv_dentist;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
    }
}