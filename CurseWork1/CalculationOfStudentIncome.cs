using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurseWork1
{
    public partial class CalculationOfStudentIncome : Form
    {
        public CalculationOfStudentIncome()
        {
            InitializeComponent();

            this.KeyDown += CalculationOfStudentIncome_KeyDown;
        }

        private void bt_Sum_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(tb_income.Text, out decimal income))
            {
                MessageBox.Show("Моля, въведете валидна сума за доходите.");
                return;
            }

            if (!decimal.TryParse(tb_fee.Text, out decimal applicationFee))
            {
                MessageBox.Show("Моля, въведете валидна сума за таксата за кандидатстване.");
                return;
            }

            
            decimal scholarship = 0;

            
            if (!string.IsNullOrWhiteSpace(tb_scholarship.Text))
            {
                if (!decimal.TryParse(tb_scholarship.Text, out scholarship))
                {
                    MessageBox.Show("Моля, въведете валидна сума за стипендиите.");
                    return;
                }
            }

            
            decimal total = income + scholarship - applicationFee;

            
            tb_Total.Text = total.ToString();
        }

        private bool scholarshipQuestionAsked = false;

        private void tb_scholarship_Click(object sender, EventArgs e)
        {
            if (!scholarshipQuestionAsked) 
            {
                DialogResult result = MessageBox.Show("Получавате ли стипендия?", "Въпрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes) 
                {
                    tb_scholarship.Visible = true; 
                    
                }
                else 
                {
                    tb_scholarship.Visible = false; 
                    
                }

                scholarshipQuestionAsked = true; 
            }
        }

        private void bt_Clear_Click(object sender, EventArgs e)
        {
            string selectedText = comboBox1.Text;

            
            tb_income.Clear();
            tb_scholarship.Clear();
            tb_fee.Clear();
            tb_Total.Clear();

            
            comboBox1.Items.Clear();

            
            foreach (var item in comboBoxItems)
            {
                comboBox1.Items.Add(item);
            }

            
            comboBox1.SelectedItem = "Изберете вида стипендия";
        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private List<string> comboBoxItems = new List<string>();

        private void CalculationOfStudentIncome_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("1. Успех");
            comboBox1.Items.Add("2. Европейски проекти");
            comboBox1.Items.Add("3. Социални");
            comboBox1.Items.Add("4. С един родител/настойник");

            
            foreach (var item in comboBox1.Items)
            {
                comboBoxItems.Add(item.ToString());
            }
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
            this.Hide();

            StudentRegister studentRegister = new StudentRegister();
            studentRegister.ShowDialog();

            this.Show();
        }

        private void доходиНаСтудентToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<CalculationOfStudentIncome>().Any())
            {
                MessageBox.Show("Вече сте на прозореца за изчисляване на доходи на студент.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                
                CalculationOfStudentIncome calculationOfStudentIncome = new CalculationOfStudentIncome();
                calculationOfStudentIncome.ShowDialog();
            }
        }

        private void bt_Sum_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void bt_Sum_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void bt_Clear_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void bt_Clear_MouseLeave(object sender, EventArgs e)
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

        private void CalculationOfStudentIncome_KeyPress(object sender, KeyPressEventArgs e)
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

        private void CalculationOfStudentIncome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                
                this.Close();
            }
        }
    }
}
