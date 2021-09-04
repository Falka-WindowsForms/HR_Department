using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HR_Department
{
    public partial class Form1 : Form
    {
        string path1;
        string path2;
        XDocument doc1;
        XDocument doc2;
        string photoPath;
        public Form1()
        {
            InitializeComponent();
            path1 = @"..\..\Data\Data\Departments.xml";
            path2 = @"..\..\Data\Data\Employees.xml";
            doc1 = XDocument.Load(path1);
            doc2 = XDocument.Load(path2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var deps = doc1.Element("root").Elements("department").ToList();
            foreach(var dep in deps)
                dep_list.Items.Add(dep.Attribute("name").Value);
            if(dep_list.Items.Count>0)
                dep_list.SelectedIndex = 0;
        }

        private void add_dep_button_Click(object sender, EventArgs e)
        {
            string name = dep_name_textbox.Text;
            if (String.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Department name is null", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                foreach(string item in dep_list.Items)
                {
                    if (item == name)
                    {
                        MessageBox.Show("Department is already added", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                dep_list.Items.Add(name);
                doc1.Element("root").Add(
                    new XElement("department",
                    new XAttribute("name", name)));
                doc1.Save(path1);
                dep_name_textbox.Clear();
                MessageBox.Show("Department added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void delete_dep_button_Click(object sender, EventArgs e)
        {
            if (dep_list.Items.Count > 0)
            {
                string name = dep_list.Items.ToString();
               // dep_list.Items.RemoveAt(dep_list.SelectedIndex);
                //doc1.Element("root").Remove();
            }
            else
            {
                MessageBox.Show("Departments is empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dep_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            employees_list.Items.Clear();
            string dep_name = dep_list.SelectedItem.ToString();
            var emps = doc2.Element("root").Elements("employee")
                .Where(emp => emp.Attribute("dep_name").Value == dep_name).ToList();
            foreach (var emp in emps)
            {
                employees_list.Items.Add(emp.Attribute("name").Value);
            }
        }

        private void employees_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            string emp_name = employees_list.SelectedItem.ToString();
            var emp = doc2.Element("root").Elements("employee")
                .Where(x => x.Attribute("name").Value == emp_name)
                .FirstOrDefault();
            if (emp != null){ 
            
                string image_path = $"..\\..\\Data\\Images\\{emp.Attribute("photo").Value}";
                try
                {
                    emp_photo.Image = Image.FromFile(image_path);
                }
                catch
                {
                    emp_photo.Image = Image.FromFile(@"..\..\Images\profile.png");
                }
                try
                {
                    emp_name_textbox.Text = emp.Attribute("name").Value;
                    emp_birthday_datepick.Value = DateTime.Parse(emp.Attribute("birth").Value);
                    emp_address_textbox.Text = emp.Attribute("addr").Value;
                    emp_phone_textbox.Text = emp.Attribute("phone").Value;
                    emp_postition_textbox.Text = emp.Attribute("pos").Value;
                    emp_email_textbox.Text = emp.Attribute("email").Value;
                    emp_salary_numeric.Value = int.Parse(emp.Attribute("sal").Value);
                }
                catch
                {
                    MessageBox.Show("Load error");
                }
            }
        }

        private void add_emp_photo_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Jpeg files (*.jpg)|*.jpg|PNG files (*.png)|*.png|All files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                photoPath = ofd.FileName;
                emp_photo.Image = Image.FromFile(photoPath);
            }
        }
    }   
}
