using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace CurseWork1
{
    public partial class EditRegisterStudentcs : Form
    {
        private DataGridViewRow selectedRow;
        private string filePath = "register_student_data.txt";

        public EditRegisterStudentcs(DataGridViewRow selectedRow)
        {
            InitializeComponent();

            if (selectedRow == null)
            {
                throw new ArgumentNullException(nameof(selectedRow), "Избраният ред не може да бъде нула.");
            }

            this.selectedRow = selectedRow;


            tb_Fname.Text = selectedRow.Cells["FName"].Value.ToString();
            tb_Sname.Text = selectedRow.Cells["Sname"].Value.ToString();
            tb_Fcn.Text = selectedRow.Cells["Faculty"].Value.ToString();
            tb_Specialty.Text = selectedRow.Cells["Specialty"].Value.ToString();
            tb_Course.Text = selectedRow.Cells["Course"].Value.ToString();
            tb_Group.Text = selectedRow.Cells["Group"].Value.ToString();
            tb_FacultyNumber.Text = selectedRow.Cells["Faculty number"].Value.ToString();
        }

        private void bt_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tb_Fname.Text) ||
               string.IsNullOrWhiteSpace(tb_Sname.Text) ||
               string.IsNullOrWhiteSpace(tb_Fcn.Text) ||
               string.IsNullOrWhiteSpace(tb_Specialty.Text) ||
               string.IsNullOrWhiteSpace(tb_Course.Text) ||
               string.IsNullOrWhiteSpace(tb_Group.Text) ||
               string.IsNullOrWhiteSpace(tb_FacultyNumber.Text))

                {
                    MessageBox.Show("Моля попълнете празните полета.");
                    return;
                }

                if (!IsValidFacultyNumber(tb_FacultyNumber.Text) || tb_FacultyNumber.Text.Length != 10)
                {
                    MessageBox.Show("Факултетния номер трябва да е с точно 10 цифри.");
                    return;
                }

                selectedRow.Cells["Fname"].Value = tb_Fname.Text;
                selectedRow.Cells["Sname"].Value = tb_Sname.Text;
                selectedRow.Cells["Faculty"].Value = tb_Fcn.Text;
                selectedRow.Cells["Specialty"].Value = tb_Specialty.Text;
                selectedRow.Cells["Course"].Value = tb_Course.Text;
                selectedRow.Cells["Group"].Value = tb_Group.Text;
                selectedRow.Cells["Faculty number"].Value = tb_FacultyNumber.Text;


                UpdateStudentData(selectedRow.Index, tb_Fname.Text, tb_Sname.Text, tb_Fcn.Text, tb_Specialty.Text, tb_Course.Text, tb_Group.Text, tb_FacultyNumber.Text);

                MessageBox.Show("Данните за студнтите са актуализирани успешно.");


                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Възникна грешка: {ex.Message}");
            }

        }

        private bool IsValidFacultyNumber(string input)
        {
            
            return Regex.IsMatch(input, @"^\d{10}$");
        }

        private void UpdateStudentData(int rowIndex, string fname, string sname, string fcn, string speciality, string cource, string group, string fnumber)
        {

            string[] lines = File.ReadAllLines(filePath);


            string updatedRow = $"{fname},{sname},{fcn},{speciality},{cource},{group},{fnumber}";


            lines[rowIndex] = updatedRow;


            File.WriteAllLines(filePath, lines);
        }

        private void bt_Add_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void bt_Add_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void EditRegisterStudentcs_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (textBox != null)
            {
                if (e.KeyChar == (char)Keys.Up)
                {

                    SelectNextControl(textBox, false, true, true, true);
                    e.Handled = true;
                }
                else if (e.KeyChar == (char)Keys.Down)
                {

                    SelectNextControl(textBox, true, true, true, true);
                    e.Handled = true;
                }
                else if (e.KeyChar == (char)Keys.Left)
                {

                    if (textBox.SelectionStart > 0)
                    {
                        textBox.SelectionStart--;
                        textBox.SelectionLength = 0;
                    }
                    e.Handled = true;
                }
                else if (e.KeyChar == (char)Keys.Right)
                {

                    if (textBox.SelectionStart < textBox.Text.Length)
                    {
                        textBox.SelectionStart++;
                        textBox.SelectionLength = 0;
                    }
                    e.Handled = true;
                }
            }
        }
    }


}
