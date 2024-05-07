using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurseWork1
{
    public partial class ForMe : Form
    {
        public ForMe()
        {
            InitializeComponent();
        }

        private void доToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            StudentInfo studentInfo = new StudentInfo();
            studentInfo.ShowDialog();

            this.Show();
        }

        private void началоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void заМенToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ForMe>().Any())
            {
                MessageBox.Show("Вече сте на прозореца за мен.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                ForMe forMe = new ForMe();
                forMe.ShowDialog();
            }
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://github.com/StanimirNaydenov/Book-shop";

            
            System.Diagnostics.Process.Start(url);
        }

        private void ForMe_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.viber_изображение_2021_08_20_12_31_09_044;

            // Създаване на елиптична рамка
            GraphicsPath ellipsePath = new GraphicsPath();
            ellipsePath.AddEllipse(0, 0, pictureBox1.Width, pictureBox1.Height);

            // Настройване на рамката на PictureBox да бъде елиптична
            pictureBox1.Region = new Region(ellipsePath);
        }

        private void bt_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_Close_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void bt_Close_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
    }
}
