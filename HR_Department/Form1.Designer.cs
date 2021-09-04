
namespace HR_Department
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.employees_list = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.delete_dep_button = new System.Windows.Forms.Button();
            this.save_dep_button = new System.Windows.Forms.Button();
            this.add_dep_button = new System.Windows.Forms.Button();
            this.dep_name_textbox = new System.Windows.Forms.TextBox();
            this.dep_list = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.add_emp_button = new System.Windows.Forms.Button();
            this.save_emp_button = new System.Windows.Forms.Button();
            this.delete_emp_button = new System.Windows.Forms.Button();
            this.clear_emp_button = new System.Windows.Forms.Button();
            this.emp_salary_numeric = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.emp_postition_textbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.emp_email_textbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.emp_phone_textbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.emp_address_textbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.emp_birthday_datepick = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.emp_name_textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.delete_emp_photo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.add_emp_photo = new System.Windows.Forms.Button();
            this.emp_photo = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emp_salary_numeric)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emp_photo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.employees_list);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.delete_dep_button);
            this.groupBox1.Controls.Add(this.save_dep_button);
            this.groupBox1.Controls.Add(this.add_dep_button);
            this.groupBox1.Controls.Add(this.dep_name_textbox);
            this.groupBox1.Controls.Add(this.dep_list);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 642);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employees";
            // 
            // employees_list
            // 
            this.employees_list.Font = new System.Drawing.Font("MS Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.employees_list.FormattingEnabled = true;
            this.employees_list.ItemHeight = 27;
            this.employees_list.Location = new System.Drawing.Point(16, 232);
            this.employees_list.Name = "employees_list";
            this.employees_list.ScrollAlwaysVisible = true;
            this.employees_list.Size = new System.Drawing.Size(302, 355);
            this.employees_list.TabIndex = 7;
            this.employees_list.SelectedIndexChanged += new System.EventHandler(this.employees_list_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Employees list";
            // 
            // delete_dep_button
            // 
            this.delete_dep_button.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete_dep_button.Location = new System.Drawing.Point(230, 146);
            this.delete_dep_button.Name = "delete_dep_button";
            this.delete_dep_button.Size = new System.Drawing.Size(88, 42);
            this.delete_dep_button.TabIndex = 5;
            this.delete_dep_button.Text = "Delete";
            this.delete_dep_button.UseVisualStyleBackColor = true;
            this.delete_dep_button.Click += new System.EventHandler(this.delete_dep_button_Click);
            // 
            // save_dep_button
            // 
            this.save_dep_button.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save_dep_button.Location = new System.Drawing.Point(118, 146);
            this.save_dep_button.Name = "save_dep_button";
            this.save_dep_button.Size = new System.Drawing.Size(88, 42);
            this.save_dep_button.TabIndex = 4;
            this.save_dep_button.Text = "Save";
            this.save_dep_button.UseVisualStyleBackColor = true;
            this.save_dep_button.Click += new System.EventHandler(this.save_dep_button_Click);
            // 
            // add_dep_button
            // 
            this.add_dep_button.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_dep_button.Location = new System.Drawing.Point(7, 146);
            this.add_dep_button.Name = "add_dep_button";
            this.add_dep_button.Size = new System.Drawing.Size(88, 42);
            this.add_dep_button.TabIndex = 3;
            this.add_dep_button.Text = "Add";
            this.add_dep_button.UseVisualStyleBackColor = true;
            this.add_dep_button.Click += new System.EventHandler(this.add_dep_button_Click);
            // 
            // dep_name_textbox
            // 
            this.dep_name_textbox.Location = new System.Drawing.Point(7, 102);
            this.dep_name_textbox.Name = "dep_name_textbox";
            this.dep_name_textbox.Size = new System.Drawing.Size(311, 27);
            this.dep_name_textbox.TabIndex = 2;
            // 
            // dep_list
            // 
            this.dep_list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dep_list.FormattingEnabled = true;
            this.dep_list.Location = new System.Drawing.Point(7, 67);
            this.dep_list.Name = "dep_list";
            this.dep_list.Size = new System.Drawing.Size(311, 28);
            this.dep_list.TabIndex = 1;
            this.dep_list.SelectedIndexChanged += new System.EventHandler(this.dep_list_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Departments list";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.add_emp_button);
            this.groupBox2.Controls.Add(this.save_emp_button);
            this.groupBox2.Controls.Add(this.delete_emp_button);
            this.groupBox2.Controls.Add(this.clear_emp_button);
            this.groupBox2.Controls.Add(this.emp_salary_numeric);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.emp_postition_textbox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.emp_email_textbox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.emp_phone_textbox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.emp_address_textbox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.emp_birthday_datepick);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.emp_name_textbox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(694, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 642);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information";
            // 
            // add_emp_button
            // 
            this.add_emp_button.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_emp_button.Location = new System.Drawing.Point(0, 548);
            this.add_emp_button.Name = "add_emp_button";
            this.add_emp_button.Size = new System.Drawing.Size(81, 42);
            this.add_emp_button.TabIndex = 31;
            this.add_emp_button.Text = "Add";
            this.add_emp_button.UseVisualStyleBackColor = true;
            this.add_emp_button.Click += new System.EventHandler(this.add_emp_button_Click);
            // 
            // save_emp_button
            // 
            this.save_emp_button.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save_emp_button.Location = new System.Drawing.Point(0, 594);
            this.save_emp_button.Name = "save_emp_button";
            this.save_emp_button.Size = new System.Drawing.Size(268, 42);
            this.save_emp_button.TabIndex = 30;
            this.save_emp_button.Text = "Save";
            this.save_emp_button.UseVisualStyleBackColor = true;
            this.save_emp_button.Click += new System.EventHandler(this.save_emp_button_Click);
            // 
            // delete_emp_button
            // 
            this.delete_emp_button.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete_emp_button.Location = new System.Drawing.Point(183, 548);
            this.delete_emp_button.Name = "delete_emp_button";
            this.delete_emp_button.Size = new System.Drawing.Size(85, 42);
            this.delete_emp_button.TabIndex = 29;
            this.delete_emp_button.Text = "Delete";
            this.delete_emp_button.UseVisualStyleBackColor = true;
            this.delete_emp_button.Click += new System.EventHandler(this.delete_emp_button_Click);
            // 
            // clear_emp_button
            // 
            this.clear_emp_button.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clear_emp_button.Location = new System.Drawing.Point(89, 548);
            this.clear_emp_button.Name = "clear_emp_button";
            this.clear_emp_button.Size = new System.Drawing.Size(85, 42);
            this.clear_emp_button.TabIndex = 28;
            this.clear_emp_button.Text = "Clear";
            this.clear_emp_button.UseVisualStyleBackColor = true;
            this.clear_emp_button.Click += new System.EventHandler(this.clear_emp_button_Click);
            // 
            // emp_salary_numeric
            // 
            this.emp_salary_numeric.Location = new System.Drawing.Point(106, 490);
            this.emp_salary_numeric.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.emp_salary_numeric.Name = "emp_salary_numeric";
            this.emp_salary_numeric.Size = new System.Drawing.Size(117, 27);
            this.emp_salary_numeric.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS Gothic", 13.8F);
            this.label10.Location = new System.Drawing.Point(6, 489);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 24);
            this.label10.TabIndex = 23;
            this.label10.Text = "Salary:";
            // 
            // emp_postition_textbox
            // 
            this.emp_postition_textbox.Location = new System.Drawing.Point(6, 447);
            this.emp_postition_textbox.Name = "emp_postition_textbox";
            this.emp_postition_textbox.Size = new System.Drawing.Size(258, 27);
            this.emp_postition_textbox.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS Gothic", 13.8F);
            this.label9.Location = new System.Drawing.Point(6, 420);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 24);
            this.label9.TabIndex = 21;
            this.label9.Text = "Position";
            // 
            // emp_email_textbox
            // 
            this.emp_email_textbox.Location = new System.Drawing.Point(6, 373);
            this.emp_email_textbox.Name = "emp_email_textbox";
            this.emp_email_textbox.Size = new System.Drawing.Size(258, 27);
            this.emp_email_textbox.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Gothic", 13.8F);
            this.label8.Location = new System.Drawing.Point(6, 346);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 24);
            this.label8.TabIndex = 19;
            this.label8.Text = "E-mail";
            // 
            // emp_phone_textbox
            // 
            this.emp_phone_textbox.Location = new System.Drawing.Point(6, 302);
            this.emp_phone_textbox.Name = "emp_phone_textbox";
            this.emp_phone_textbox.Size = new System.Drawing.Size(258, 27);
            this.emp_phone_textbox.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Gothic", 13.8F);
            this.label7.Location = new System.Drawing.Point(6, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 24);
            this.label7.TabIndex = 17;
            this.label7.Text = "Phone";
            // 
            // emp_address_textbox
            // 
            this.emp_address_textbox.Location = new System.Drawing.Point(6, 231);
            this.emp_address_textbox.Name = "emp_address_textbox";
            this.emp_address_textbox.Size = new System.Drawing.Size(258, 27);
            this.emp_address_textbox.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Gothic", 13.8F);
            this.label6.Location = new System.Drawing.Point(6, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "Address";
            // 
            // emp_birthday_datepick
            // 
            this.emp_birthday_datepick.CalendarFont = new System.Drawing.Font("MS Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emp_birthday_datepick.Location = new System.Drawing.Point(10, 161);
            this.emp_birthday_datepick.Name = "emp_birthday_datepick";
            this.emp_birthday_datepick.Size = new System.Drawing.Size(258, 27);
            this.emp_birthday_datepick.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Gothic", 13.8F);
            this.label5.Location = new System.Drawing.Point(6, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Birthday date";
            // 
            // emp_name_textbox
            // 
            this.emp_name_textbox.Location = new System.Drawing.Point(10, 82);
            this.emp_name_textbox.Name = "emp_name_textbox";
            this.emp_name_textbox.Size = new System.Drawing.Size(258, 27);
            this.emp_name_textbox.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Gothic", 13.8F);
            this.label4.Location = new System.Drawing.Point(6, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Name, Surname";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.delete_emp_photo);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.add_emp_photo);
            this.groupBox3.Controls.Add(this.emp_photo);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(324, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(370, 642);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Photo";
            // 
            // delete_emp_photo
            // 
            this.delete_emp_photo.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete_emp_photo.Location = new System.Drawing.Point(190, 588);
            this.delete_emp_photo.Name = "delete_emp_photo";
            this.delete_emp_photo.Size = new System.Drawing.Size(149, 42);
            this.delete_emp_photo.TabIndex = 10;
            this.delete_emp_photo.Text = "Delete";
            this.delete_emp_photo.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Gothic", 13.8F);
            this.label3.Location = new System.Drawing.Point(6, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Employee photo";
            // 
            // add_emp_photo
            // 
            this.add_emp_photo.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_emp_photo.Location = new System.Drawing.Point(28, 588);
            this.add_emp_photo.Name = "add_emp_photo";
            this.add_emp_photo.Size = new System.Drawing.Size(156, 42);
            this.add_emp_photo.TabIndex = 8;
            this.add_emp_photo.Text = "Add";
            this.add_emp_photo.UseVisualStyleBackColor = true;
            this.add_emp_photo.Click += new System.EventHandler(this.add_emp_photo_Click);
            // 
            // emp_photo
            // 
            this.emp_photo.Image = global::HR_Department.Properties.Resources.profile;
            this.emp_photo.Location = new System.Drawing.Point(6, 67);
            this.emp_photo.Name = "emp_photo";
            this.emp_photo.Size = new System.Drawing.Size(358, 515);
            this.emp_photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.emp_photo.TabIndex = 0;
            this.emp_photo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(974, 642);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "HR Department control tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emp_salary_numeric)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emp_photo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox dep_list;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button delete_dep_button;
        private System.Windows.Forms.Button save_dep_button;
        private System.Windows.Forms.Button add_dep_button;
        private System.Windows.Forms.TextBox dep_name_textbox;
        private System.Windows.Forms.ListBox employees_list;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button delete_emp_photo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button add_emp_photo;
        private System.Windows.Forms.PictureBox emp_photo;
        private System.Windows.Forms.TextBox emp_phone_textbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox emp_address_textbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker emp_birthday_datepick;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox emp_name_textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox emp_postition_textbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox emp_email_textbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button add_emp_button;
        private System.Windows.Forms.Button save_emp_button;
        private System.Windows.Forms.Button delete_emp_button;
        private System.Windows.Forms.Button clear_emp_button;
        private System.Windows.Forms.NumericUpDown emp_salary_numeric;
    }
}

