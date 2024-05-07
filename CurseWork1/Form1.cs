using OfficeOpenXml;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.KeyDown += Form1_KeyDown;
        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Сигурни ли сте, че искате да напуснете приложението?", "Изход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

           
            if (result == DialogResult.Yes)
            {
              
                this.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            string url = "https://uni-plovdiv.bg/";

            
            System.Diagnostics.Process.Start(url);
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
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
            if (Application.OpenForms.OfType<Form1>().Any())
            {
                MessageBox.Show("Вече сте на началната страница.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                Form1 home = new Form1();
                home.ShowDialog();
            }
        }

        private void доToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            StudentInfo studentInfo = new StudentInfo();
            studentInfo.ShowDialog();

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

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                
                this.Close();
            }
        }
    }
}
