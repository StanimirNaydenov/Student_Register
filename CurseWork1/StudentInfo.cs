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
    public partial class StudentInfo : Form
    {
   
        private string filePath = "student_data.txt";
        

        public StudentInfo()
        {
            InitializeComponent();

            this.KeyDown += StudentInfo_KeyDown_1;
            LoadData();

        }

        private void LoadData()
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);

                dataGridView1.ColumnCount = 5;
                dataGridView1.Columns[0].Name = "FName";
                dataGridView1.Columns[1].Name = "Surname";
                dataGridView1.Columns[2].Name = "EGN";
                dataGridView1.Columns[3].Name = "City";
                dataGridView1.Columns[4].Name = "Address";

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
            if (string.IsNullOrWhiteSpace(tb_Name.Text) ||
                string.IsNullOrWhiteSpace(tb_Fname.Text) ||
                string.IsNullOrWhiteSpace(tb_Egn.Text) ||
                string.IsNullOrWhiteSpace(tb_City.Text) ||
                string.IsNullOrWhiteSpace(tb_Adr.Text))
            {
                MessageBox.Show("Моля попълнете празните полета.");
                return;
            }

            if (!IsValidFacultyNumber(tb_Egn.Text) || tb_Egn.Text.Length != 10)
            {
                MessageBox.Show("EGN-то трябва да е с дължина 10 знака.");
                return;
            }

            string studentData = tb_Name.Text + "," + tb_Fname.Text + "," + tb_Egn.Text + "," + tb_City.Text + "," + tb_Adr.Text;

       
            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine(studentData);
            }

            tb_Name.Clear();
            tb_Fname.Clear();
            tb_Egn.Clear();
            tb_City.Clear();
            tb_Adr.Clear();

            dataGridView1.Refresh();

            MessageBox.Show("Данните за студентите са добавени успешно.");
        }


        private bool IsValidFacultyNumber(string input)
        {
            
            return Regex.IsMatch(input, @"^\d{10}$");
        }

        private void bt_Edit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
               
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

               
                EditStudent editForm = new EditStudent(selectedRow);
                editForm.ShowDialog();

                
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
                           !String.Equals(data[4], row.Cells[4].Value.ToString(), StringComparison.OrdinalIgnoreCase);
                });

                File.WriteAllLines(filePath, remainingLines);

                MessageBox.Show("Студентът е изтрит успешно.");
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

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void началоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void доToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<StudentInfo>().Any())
            {
                MessageBox.Show("Вече сте на прозореца за лични данни на студент.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                StudentInfo studentInfo = new StudentInfo();
                studentInfo.ShowDialog();
            }

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
            this.Hide();

            StudentRegister register = new StudentRegister();
            register.ShowDialog();

            this.Show();
        }

        private void доходиНаСтудентToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            CalculationOfStudentIncome calculationOfStudentIncome = new CalculationOfStudentIncome();
            calculationOfStudentIncome.ShowDialog();

            this.Show();
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

        private void bt_Delete_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void bt_Delete_MouseLeave(object sender, EventArgs e)
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

        private void bt_Refresh_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void bt_Refresh_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
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

        private void bt_DelleteAll_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void bt_DelleteAll_MouseLeave(object sender, EventArgs e)
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
                    // Навигация нагоре
                    SelectNextControl(textBox, false, true, true, true);
                    e.Handled = true; // Предотвратява стандартното поведение на клавиша
                }
                else if (e.KeyChar == (char)Keys.Down)
                {
                    // Навигация надолу
                    SelectNextControl(textBox, true, true, true, true);
                    e.Handled = true; // Предотвратява стандартното поведение на клавиша
                }
                else if (e.KeyChar == (char)Keys.Left)
                {
                    // Навигация наляво
                    if (textBox.SelectionStart > 0)
                    {
                        textBox.SelectionStart--;
                        textBox.SelectionLength = 0;
                    }
                    e.Handled = true; // Предотвратява стандартното поведение на клавиша
                }
                else if (e.KeyChar == (char)Keys.Right)
                {
                    // Навигация надясно
                    if (textBox.SelectionStart < textBox.Text.Length)
                    {
                        textBox.SelectionStart++;
                        textBox.SelectionLength = 0;
                    }
                    e.Handled = true; // Предотвратява стандартното поведение на клавиша
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
                    // Навигация нагоре
                    SelectNextControl(textBox, false, true, true, true);
                    e.Handled = true; // Предотвратява стандартното поведение на клавиша
                }
                else if (e.KeyChar == (char)Keys.Down)
                {
                    // Навигация надолу
                    SelectNextControl(textBox, true, true, true, true);
                    e.Handled = true; // Предотвратява стандартното поведение на клавиша
                }
                else if (e.KeyChar == (char)Keys.Left)
                {
                    // Навигация наляво
                    if (textBox.SelectionStart > 0)
                    {
                        textBox.SelectionStart--;
                        textBox.SelectionLength = 0;
                    }
                    e.Handled = true; // Предотвратява стандартното поведение на клавиша
                }
                else if (e.KeyChar == (char)Keys.Right)
                {
                    // Навигация надясно
                    if (textBox.SelectionStart < textBox.Text.Length)
                    {
                        textBox.SelectionStart++;
                        textBox.SelectionLength = 0;
                    }
                    e.Handled = true; // Предотвратява стандартното поведение на клавиша
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

        private void StudentInfo_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                
                this.Close();
            }
        }

        
    }
}
