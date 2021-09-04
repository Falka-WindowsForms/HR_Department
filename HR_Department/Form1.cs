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
                DialogResult res = MessageBox.Show("Delete department?", "Confirm action", MessageBoxButtons.YesNo);
                if (res != DialogResult.Yes)
                    return;
                string name = dep_list.SelectedItem.ToString();
                dep_list.Items.Remove(name);
                employees_list.Items.Clear();
                doc1.Element("root").Elements("department").Where(emp => emp.Attribute("name").Value == name).Remove();
                doc1.Save(path1);
                res = MessageBox.Show("Delete department employees?", "Confirm action", MessageBoxButtons.YesNo);
                if (res != DialogResult.Yes)
                    return;
                doc2.Element("root").Elements("employee").Where(emp => emp.Attribute("dep_name").Value == name).Remove();
                doc2.Save(path2);
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
            if (employees_list.SelectedIndex<0 || employees_list.SelectedItem == null)
                return;
            string emp_name = employees_list.SelectedItem.ToString();
            var emp = doc2.Element("root").Elements("employee")
                .Where(x => x.Attribute("name").Value == emp_name)
                .FirstOrDefault();
            if (emp != null){
                    
                //string image_path = $"..\\..\\Data\\Images\\{emp.Attribute("photo").Value}";
                string image_path = $"{emp.Attribute("photo").Value}";
                try
                {
                    photoPath = image_path;
                    emp_photo.Image = Image.FromFile(image_path);
                }
                catch
                {
                    photoPath = (@"..\..\Images\profile.png");
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

        private void save_dep_button_Click(object sender, EventArgs e)
        {
            if(dep_list.SelectedIndex != -1)
            {
                if (dep_name_textbox.Text == "")
                    MessageBox.Show("Department name can`t be null");
                else
                {
                    string oldName = dep_list.SelectedItem.ToString();
                    XElement item = doc1.Element("root").Elements("department").Where(emp => emp.Attribute("name").Value == dep_list.SelectedItem.ToString()).SingleOrDefault();
                    item.Attribute("name").Value = dep_name_textbox.Text;
                    doc1.Save(path1);
                    DialogResult result = MessageBox.Show("Transfer employees to another department?", "Confirm action", MessageBoxButtons.YesNo);
                    item = null;
                    if (result == DialogResult.Yes)
                    {
                            var items = doc2.Element("root").Elements("employee").Where(emp => emp.Attribute("dep_name").Value == oldName);
                        foreach (var element in items)
                        {
                            element.SetAttributeValue("dep_name", dep_name_textbox.Text);
                        }
                        doc2.Save(path2);
                    }

                    dep_list.Items[dep_list.SelectedIndex] = dep_name_textbox.Text;
                    dep_name_textbox.Clear();
                }
            }
        }

        private void clear_emp_button_Click(object sender, EventArgs e)
        {
            photoPath = (@"..\..\Images\profile.png");
            emp_photo.Image = Image.FromFile(@"..\..\Images\profile.png");
            emp_name_textbox.Clear();
            emp_birthday_datepick.Value = DateTime.Now;
            emp_email_textbox.Clear();
            emp_postition_textbox.Clear();
            emp_salary_numeric.Value = 0;
            emp_postition_textbox.Clear();
            emp_phone_textbox.Clear();
            emp_address_textbox.Clear();
            employees_list.SelectedIndex = -1;
        }

        private void add_emp_button_Click(object sender, EventArgs e)
        {
            employees_list.Items.Add(emp_name_textbox.Text);
            doc2.Element("root").Add(
                    new XElement("employee",
                    new XAttribute("dep_name", dep_list.SelectedItem.ToString()),
                    new XAttribute("name", emp_name_textbox.Text),
                    new XAttribute("birth", emp_birthday_datepick.Value.ToString()),
                    new XAttribute("addr",emp_address_textbox.Text),
                    new XAttribute("phone",emp_phone_textbox.Text),
                    new XAttribute("email",emp_email_textbox.Text),
                    new XAttribute("pos",emp_postition_textbox.Text),
                    new XAttribute("sal",emp_salary_numeric.Value.ToString()),
                    new XAttribute("photo",photoPath.ToString())
                    )) ;
            doc2.Save(path2);
            MessageBox.Show("Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }   
}
