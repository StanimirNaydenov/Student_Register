using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurseWork1
{
    public partial class StudentRegister : Form
    {
        private string filePath = "register_student_data.txt";

        public StudentRegister()
        {
            InitializeComponent();
            LoadData();
            this.KeyDown += StudentRegister_KeyDown;


        }


        private void LoadData()
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);

                dataGridView1.ColumnCount = 7;
                dataGridView1.Columns[0].Name = "Fname";
                dataGridView1.Columns[1].Name = "Sname";
                dataGridView1.Columns[2].Name = "Faculty";
                dataGridView1.Columns[3].Name = "Specialty";
                dataGridView1.Columns[4].Name = "Course";
                dataGridView1.Columns[5].Name = "Group";
                dataGridView1.Columns[6].Name = "Faculty number";

                foreach (string line in lines)
                {
                    string[] data = line.Split(',');
                    dataGridView1.Rows.Add(data);
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show($"Файлът не е намерен: {ex.FileName}");
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Възникна грешка при четене на файла: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Възникна неочаквана грешка: {ex.Message}");
            }
        }

        private void bt_Add_Click(object sender, EventArgs e)
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

            string studentData = tb_Fname.Text + "," + tb_Sname.Text + "," + tb_Fcn.Text + "," + tb_Specialty.Text + "," + tb_Course.Text + "," + tb_Group.Text + "," + tb_FacultyNumber.Text;


            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine(studentData);
            }

            tb_Fname.Clear();
            tb_Sname.Clear();
            tb_Fcn.Clear();
            tb_Specialty.Clear();
            tb_Course.Clear();
            tb_Group.Clear();
            tb_FacultyNumber.Clear();

            dataGridView1.Refresh();

            MessageBox.Show("Данните за студентите са добавени успешно.");
        }

       

        private bool IsValidFacultyNumber(string input)
        {
            
            return Regex.IsMatch(input, @"^\d{10}$");
        }

        private void bt_Refresh_Click(object sender, EventArgs e)
        {
            LoadData1();
        }

        private void LoadData1()
        {
            try
            {

                string[] lines = File.ReadAllLines(filePath);


                dataGridView1.Rows.Clear();


                foreach (string line in lines)
                {
                    string[] data = line.Split(',');
                    dataGridView1.Rows.Add(data);
                }


                MessageBox.Show("Данните са презаредени успешно.");
            }
            catch (Exception ex)
            {
                
                MessageBox.Show($"Грешка при зареждане на данните: {ex.Message}");
            }
        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_Edit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];


                EditRegisterStudentcs editRegisterStudentcs = new EditRegisterStudentcs(selectedRow);
                editRegisterStudentcs.ShowDialog();


                LoadData();
            }
            else
            {
                MessageBox.Show("Моля, изберете студент за редактиране.");
            }
        }

        private void bt_Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Сигурни ли сте, че искате да изтриете този ред?", "Потвърждение", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                       
                        dataGridView1.Rows.Remove(row);

                      
                        DeleteRowFromFile(row);
                    }
                    MessageBox.Show("Редът е изтрит успешно.");
                }
            }
            else
            {
                MessageBox.Show("Моля, изберете ред за изтриване.");
            }
        }


        private void DeleteRowFromFile(DataGridViewRow row)
        {
            try
            {
                
                string[] lines = File.ReadAllLines(filePath);

                
                var remainingLines = lines.Where(line =>
                {
                    string[] data = line.Split(',');
                    return !String.Equals(data[0], row.Cells[0].Value.ToString(), StringComparison.OrdinalIgnoreCase) ||
                           !String.Equals(data[1], row.Cells[1].Value.ToString(), StringComparison.OrdinalIgnoreCase) ||
                           !String.Equals(data[2], row.Cells[2].Value.ToString(), StringComparison.OrdinalIgnoreCase) ||
                           !String.Equals(data[3], row.Cells[3].Value.ToString(), StringComparison.OrdinalIgnoreCase) ||
                           !String.Equals(data[4], row.Cells[4].Value.ToString(), StringComparison.OrdinalIgnoreCase) ||
                           !String.Equals(data[5], row.Cells[5].Value.ToString(), StringComparison.OrdinalIgnoreCase) ||
                           !String.Equals(data[6], row.Cells[6].Value.ToString(), StringComparison.OrdinalIgnoreCase);
                });


                File.WriteAllLines(filePath, remainingLines);

                MessageBox.Show("Редът е изтрит от файла успешно.");
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show($"Файлът не е намерен:: {ex.FileName}");
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Възникна грешка при четене/запис на файла: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Възникна неочаквана грешка: {ex.Message}");
            }
        }

        private void bt_DelleteAll_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Сигурни ли сте, че искате да изтриете всички записи?", "Потвърждение", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    File.WriteAllText(filePath, string.Empty);
                  
                    LoadData();
                    MessageBox.Show("Всички записи са изтрити успешно.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Възникна грешка при изтриване на записите: {ex.Message}");
                }
            }
        }

        private void bt_Add_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void bt_Add_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void bt_Edit_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void bt_Edit_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void bt_Refresh_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void bt_Refresh_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void bt_Delete_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void bt_Delete_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void bt_DelleteAll_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void bt_DelleteAll_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void bt_Exit_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void bt_Exit_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void началоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void доToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            StudentInfo student = new StudentInfo();    
            student.ShowDialog();

            this.Show();
        }

        private void заМенToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            ForMe forMe = new ForMe();
            forMe.ShowDialog();

            this.Show();
        }

        private void регистрацияНаСтудентToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<StudentRegister>().Any())
            {
                MessageBox.Show("Вече сте на прозореца за регистрация на студент.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                StudentRegister studentRegister = new StudentRegister();
                studentRegister.ShowDialog();
            }
        }

        private void доходиНаСтудентToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            CalculationOfStudentIncome calculationOfStudentIncome = new CalculationOfStudentIncome();   
            calculationOfStudentIncome.ShowDialog();
        }

      

        private void StudentRegister_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void StudentRegister_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                
                this.Close();
            }
        }
    }
}

