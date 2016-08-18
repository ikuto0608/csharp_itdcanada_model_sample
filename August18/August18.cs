﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace August18
{
    public partial class August18 : Form
    {
        ADODB.Connection adoConnection = new ADODB.Connection();
        ADODB.Recordset adoRecordset = new ADODB.Recordset();
        String connectString = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=C:/Users/ikuto.yata/Documents/August18.accdb";

        public August18()
        {
            InitializeComponent();
        }

        private void August18_Load(object sender, EventArgs e)
        {
            displayStudents();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string[] forms = getForms();
            Student student = new Student(0, forms[1], forms[2], forms[3], Convert.ToInt32(forms[4]), forms[5]);
            student.save();

            displayStudents();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            displayStudents();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (TextBox tbx in this.Controls.OfType<TextBox>())
            {
                tbx.Clear();
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            string[] forms = getForms();

            Student student = new Student(Convert.ToInt32(forms[0]), forms[1], forms[2], forms[3], Convert.ToInt32(forms[4]), forms[5]);
            student.save();

            displayStudents();
        }

        private void resultLv_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ListViewItem item = resultLv.FocusedItem;
            idTbx.Text = item.SubItems[0].Text;
            firstNameTbx.Text = item.SubItems[1].Text;
            lastNameTbx.Text = item.SubItems[2].Text;
            addressTbx.Text = item.SubItems[3].Text;
            phoneTbx.Text = item.SubItems[4].Text;
            programTbx.Text = item.SubItems[5].Text;
        }

        private void displayStudents()
        {
            resultLv.Clear();

            for (int i = 0; i < Student.PROPERTY_NAMES.Length; i++)
            {
                resultLv.Columns.Add(Student.PROPERTY_NAMES[i], 80, HorizontalAlignment.Left);
            }

            List<Student> students = Student.all();
            foreach (Student student in students)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(student.ID));
                item.SubItems.Add(student.FirstName);
                item.SubItems.Add(student.LastName);
                item.SubItems.Add(student.Address);
                item.SubItems.Add(Convert.ToString(student.Phone));
                item.SubItems.Add(student.Program);

                resultLv.Items.Add(item);
            }

        }

        private string[] getForms()
        {
            string[] forms = new string[6];
            forms[0] = idTbx.Text;
            forms[1] = firstNameTbx.Text;
            forms[2] = lastNameTbx.Text;
            forms[3] = addressTbx.Text;
            forms[4] = phoneTbx.Text;
            forms[5] = programTbx.Text;

            return forms;
        }
    }
}
