using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurseWork1
{
    public partial class EditStudent : Form
    {
        private DataGridViewRow selectedRow;
        private string filePath = "student_data.txt";

        public EditStudent(DataGridViewRow selectedRow)
        {
            InitializeComponent();

            if (selectedRow == null)
            {
                throw new ArgumentNullException(nameof(selectedRow), "Избраният ред не може да бъде нула.");
            }

            this.selectedRow = selectedRow;
  
            
            tb_Name.Text = selectedRow.Cells["FName"].Value.ToString();
            tb_Fname.Text = selectedRow.Cells["Surname"].Value.ToString();
            tb_Egn.Text = selectedRow.Cells["EGN"].Value.ToString();
            tb_City.Text = selectedRow.Cells["City"].Value.ToString();
            tb_Adr.Text = selectedRow.Cells["Address"].Value.ToString();


        }

        private void bt_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tb_Name.Text) ||
                    string.IsNullOrWhiteSpace(tb_Fname.Text) ||
                    string.IsNullOrWhiteSpace(tb_Egn.Text) ||
                    string.IsNullOrWhiteSpace(tb_City.Text) ||
                    string.IsNullOrWhiteSpace(tb_Adr.Text))
                {
                    MessageBox.Show("Моля, попълнете всички полета.");
                    return;
                }

               
                if (!IsValidFacultyNumber(tb_Egn.Text) || tb_Egn.Text.Length != 10)
                {
                    MessageBox.Show("EGN-то трябва да е с дължина 10 знака.");
                    return;
                }


                selectedRow.Cells["FName"].Value = tb_Name.Text;
                selectedRow.Cells["Surname"].Value = tb_Fname.Text;
                selectedRow.Cells["EGN"].Value = tb_Egn.Text;
                selectedRow.Cells["City"].Value = tb_City.Text;
                selectedRow.Cells["Address"].Value = tb_Adr.Text;

                UpdateStudentData(selectedRow.Index, tb_Name.Text, tb_Fname.Text, tb_Egn.Text, tb_City.Text, tb_Adr.Text);

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

        private void UpdateStudentData(int rowIndex, string name, string surname, string egn, string city, string address)
        {
            
            string[] lines = File.ReadAllLines(filePath);

            
            string updatedRow = $"{name},{surname},{egn},{city},{address}";

          
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

        private void tb_Name_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tb_Fname_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tb_Egn_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tb_Adr_KeyPress(object sender, KeyPressEventArgs e)
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

