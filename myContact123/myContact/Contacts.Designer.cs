namespace myContact
{
    partial class Contacts
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contacts));
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ContactName = new TextBox();
            label4 = new Label();
            ContactSurname = new TextBox();
            label5 = new Label();
            ContactPhoneNumber = new TextBox();
            label6 = new Label();
            ContactEmail = new TextBox();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            AddBtn = new Button();
            ContactList = new Guna.UI2.WinForms.Guna2DataGridView();
            pictureBox2 = new PictureBox();
            label7 = new Label();
            label8 = new Label();
            DeleteBtn = new Button();
            tb_search = new TextBox();
            search_button = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ContactList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)search_button).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkCyan;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-50, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1112, 75);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(519, 27);
            label1.Name = "label1";
            label1.Size = new Size(111, 29);
            label1.TabIndex = 0;
            label1.Text = "myClass";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkCyan;
            label2.Location = new Point(424, 87);
            label2.Name = "label2";
            label2.Size = new Size(240, 29);
            label2.TabIndex = 1;
            label2.Text = "Manage Your Class";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkCyan;
            label3.Location = new Point(47, 190);
            label3.Margin = new Padding(0, 10, 0, 0);
            label3.Name = "label3";
            label3.Size = new Size(149, 25);
            label3.TabIndex = 6;
            label3.Text = "Student Name";
            // 
            // ContactName
            // 
            ContactName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ContactName.Location = new Point(47, 209);
            ContactName.Margin = new Padding(0, 10, 0, 0);
            ContactName.Name = "ContactName";
            ContactName.Size = new Size(247, 35);
            ContactName.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkCyan;
            label4.Location = new Point(47, 252);
            label4.Margin = new Padding(0, 10, 0, 0);
            label4.Name = "label4";
            label4.Size = new Size(180, 25);
            label4.TabIndex = 8;
            label4.Text = "Student Surname";
            // 
            // ContactSurname
            // 
            ContactSurname.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ContactSurname.Location = new Point(47, 271);
            ContactSurname.Margin = new Padding(0, 10, 0, 0);
            ContactSurname.Name = "ContactSurname";
            ContactSurname.Size = new Size(247, 35);
            ContactSurname.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkCyan;
            label5.Location = new Point(47, 315);
            label5.Margin = new Padding(0, 10, 0, 0);
            label5.Name = "label5";
            label5.Size = new Size(236, 25);
            label5.TabIndex = 10;
            label5.Text = "Student Phone Number";
            // 
            // ContactPhoneNumber
            // 
            ContactPhoneNumber.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ContactPhoneNumber.Location = new Point(47, 334);
            ContactPhoneNumber.Margin = new Padding(0, 10, 0, 0);
            ContactPhoneNumber.Name = "ContactPhoneNumber";
            ContactPhoneNumber.Size = new Size(247, 35);
            ContactPhoneNumber.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkCyan;
            label6.Location = new Point(49, 378);
            label6.Margin = new Padding(0, 10, 0, 0);
            label6.Name = "label6";
            label6.Size = new Size(146, 25);
            label6.TabIndex = 12;
            label6.Text = "Student Email";
            // 
            // ContactEmail
            // 
            ContactEmail.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ContactEmail.Location = new Point(47, 397);
            ContactEmail.Margin = new Padding(0, 10, 0, 0);
            ContactEmail.Name = "ContactEmail";
            ContactEmail.Size = new Size(247, 35);
            ContactEmail.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkCyan;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 576);
            panel2.Name = "panel2";
            panel2.Size = new Size(1029, 24);
            panel2.TabIndex = 13;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.kisspng_computer_icons_google_account_icon_design_login_5afc02dade3123_8372574215264652429101;
            pictureBox1.Location = new Point(77, 87);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.CornflowerBlue;
            AddBtn.FlatStyle = FlatStyle.Flat;
            AddBtn.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            AddBtn.Location = new Point(47, 456);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(104, 45);
            AddBtn.TabIndex = 16;
            AddBtn.Text = "ADD";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // ContactList
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            ContactList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            ContactList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            ContactList.ColumnHeadersHeight = 4;
            ContactList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            ContactList.DefaultCellStyle = dataGridViewCellStyle3;
            ContactList.GridColor = Color.FromArgb(231, 229, 255);
            ContactList.Location = new Point(340, 209);
            ContactList.Name = "ContactList";
            ContactList.RowHeadersVisible = false;
            ContactList.RowHeadersWidth = 62;
            ContactList.RowTemplate.Height = 25;
            ContactList.Size = new Size(654, 292);
            ContactList.TabIndex = 18;
            ContactList.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            ContactList.ThemeStyle.AlternatingRowsStyle.Font = null;
            ContactList.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            ContactList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            ContactList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            ContactList.ThemeStyle.BackColor = Color.White;
            ContactList.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            ContactList.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            ContactList.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            ContactList.ThemeStyle.HeaderStyle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ContactList.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            ContactList.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            ContactList.ThemeStyle.HeaderStyle.Height = 4;
            ContactList.ThemeStyle.ReadOnly = false;
            ContactList.ThemeStyle.RowsStyle.BackColor = Color.White;
            ContactList.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            ContactList.ThemeStyle.RowsStyle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ContactList.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            ContactList.ThemeStyle.RowsStyle.Height = 25;
            ContactList.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            ContactList.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            ContactList.CellContentClick += ContactList_CellContentClick;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(826, 87);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(39, 39);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(871, 97);
            label7.Name = "label7";
            label7.Size = new Size(87, 29);
            label7.TabIndex = 20;
            label7.Text = "Logout";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.DarkCyan;
            label8.Location = new Point(340, 183);
            label8.Margin = new Padding(0, 10, 0, 0);
            label8.Name = "label8";
            label8.Size = new Size(107, 25);
            label8.TabIndex = 21;
            label8.Text = "Class List";
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.CornflowerBlue;
            DeleteBtn.FlatStyle = FlatStyle.Flat;
            DeleteBtn.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteBtn.Location = new Point(153, 456);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(130, 45);
            DeleteBtn.TabIndex = 22;
            DeleteBtn.Text = "DELETE";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // tb_search
            // 
            tb_search.Location = new Point(779, 177);
            tb_search.Name = "tb_search";
            tb_search.Size = new Size(215, 35);
            tb_search.TabIndex = 23;
            tb_search.TextChanged += tb_search_TextChanged;
            // 
            // search_button
            // 
            search_button.Image = (Image)resources.GetObject("search_button.Image");
            search_button.Location = new Point(747, 177);
            search_button.Name = "search_button";
            search_button.Size = new Size(26, 26);
            search_button.SizeMode = PictureBoxSizeMode.StretchImage;
            search_button.TabIndex = 24;
            search_button.TabStop = false;
            search_button.Click += search_button_Click_1;
            // 
            // Contacts
            // 
            AutoScaleDimensions = new SizeF(14F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1029, 600);
            Controls.Add(search_button);
            Controls.Add(tb_search);
            Controls.Add(DeleteBtn);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(pictureBox2);
            Controls.Add(ContactList);
            Controls.Add(AddBtn);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(label6);
            Controls.Add(ContactEmail);
            Controls.Add(label5);
            Controls.Add(ContactPhoneNumber);
            Controls.Add(label4);
            Controls.Add(ContactSurname);
            Controls.Add(label3);
            Controls.Add(ContactName);
            Controls.Add(label2);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Contacts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Contacts";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ContactList).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)search_button).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox ContactName;
        private Label label4;
        private TextBox ContactSurname;
        private Label label5;
        private TextBox ContactPhoneNumber;
        private Label label6;
        private TextBox ContactEmail;
        private Panel panel2;
        private PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button AddBtn;
        private Guna.UI2.WinForms.Guna2DataGridView ContactList;
        private PictureBox pictureBox2;
        private Label label7;
        private Label label8;
        private Button DeleteBtn;
        private TextBox textBox1;
        private PictureBox pictureBox3;
        private TextBox tb_search;
        private PictureBox search_button;
    }
}