namespace CurseWork1
{
    partial class StudentRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentRegister));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.началоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заМенToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.доToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.регистрацияНаСтудентToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.доходиНаСтудентToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_Delete = new System.Windows.Forms.Button();
            this.bt_Edit = new System.Windows.Forms.Button();
            this.bt_Add = new System.Windows.Forms.Button();
            this.tb_Specialty = new System.Windows.Forms.TextBox();
            this.tb_Fcn = new System.Windows.Forms.TextBox();
            this.tb_Sname = new System.Windows.Forms.TextBox();
            this.tb_Fname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_Course = new System.Windows.Forms.TextBox();
            this.tb_Group = new System.Windows.Forms.TextBox();
            this.tb_FacultyNumber = new System.Windows.Forms.TextBox();
            this.bt_Exit = new System.Windows.Forms.Button();
            this.bt_Refresh = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.bt_DelleteAll = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.началоToolStripMenuItem,
            this.заМенToolStripMenuItem,
            this.доToolStripMenuItem,
            this.регистрацияНаСтудентToolStripMenuItem,
            this.доходиНаСтудентToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1456, 37);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // началоToolStripMenuItem
            // 
            this.началоToolStripMenuItem.Font = new System.Drawing.Font("Fugaz One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.началоToolStripMenuItem.Name = "началоToolStripMenuItem";
            this.началоToolStripMenuItem.Size = new System.Drawing.Size(101, 33);
            this.началоToolStripMenuItem.Text = "Начало";
            this.началоToolStripMenuItem.Click += new System.EventHandler(this.началоToolStripMenuItem_Click);
            // 
            // заМенToolStripMenuItem
            // 
            this.заМенToolStripMenuItem.Font = new System.Drawing.Font("Fugaz One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.заМенToolStripMenuItem.Name = "заМенToolStripMenuItem";
            this.заМенToolStripMenuItem.Size = new System.Drawing.Size(96, 33);
            this.заМенToolStripMenuItem.Text = "За мен";
            this.заМенToolStripMenuItem.Click += new System.EventHandler(this.заМенToolStripMenuItem_Click);
            // 
            // доToolStripMenuItem
            // 
            this.доToolStripMenuItem.Font = new System.Drawing.Font("Fugaz One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.доToolStripMenuItem.Name = "доToolStripMenuItem";
            this.доToolStripMenuItem.Size = new System.Drawing.Size(358, 33);
            this.доToolStripMenuItem.Text = "Въвеждане на данни на студенти";
            this.доToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.доToolStripMenuItem.Click += new System.EventHandler(this.доToolStripMenuItem_Click);
            // 
            // регистрацияНаСтудентToolStripMenuItem
            // 
            this.регистрацияНаСтудентToolStripMenuItem.Font = new System.Drawing.Font("Fugaz One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.регистрацияНаСтудентToolStripMenuItem.Name = "регистрацияНаСтудентToolStripMenuItem";
            this.регистрацияНаСтудентToolStripMenuItem.Size = new System.Drawing.Size(277, 33);
            this.регистрацияНаСтудентToolStripMenuItem.Text = "Регистрация на студенти";
            this.регистрацияНаСтудентToolStripMenuItem.Click += new System.EventHandler(this.регистрацияНаСтудентToolStripMenuItem_Click);
            // 
            // доходиНаСтудентToolStripMenuItem
            // 
            this.доходиНаСтудентToolStripMenuItem.Font = new System.Drawing.Font("Fugaz One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.доходиНаСтудентToolStripMenuItem.Name = "доходиНаСтудентToolStripMenuItem";
            this.доходиНаСтудентToolStripMenuItem.Size = new System.Drawing.Size(357, 33);
            this.доходиНаСтудентToolStripMenuItem.Text = "Изчисляване доходи на студенти";
            this.доходиНаСтудентToolStripMenuItem.Click += new System.EventHandler(this.доходиНаСтудентToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(62, 592);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(932, 261);
            this.dataGridView1.TabIndex = 17;
            // 
            // bt_Delete
            // 
            this.bt_Delete.BackColor = System.Drawing.Color.Red;
            this.bt_Delete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_Delete.Location = new System.Drawing.Point(981, 397);
            this.bt_Delete.Name = "bt_Delete";
            this.bt_Delete.Size = new System.Drawing.Size(340, 59);
            this.bt_Delete.TabIndex = 28;
            this.bt_Delete.Text = "Изтрите избран запис";
            this.bt_Delete.UseVisualStyleBackColor = false;
            this.bt_Delete.Click += new System.EventHandler(this.bt_Delete_Click);
            this.bt_Delete.MouseEnter += new System.EventHandler(this.bt_Delete_MouseEnter);
            this.bt_Delete.MouseLeave += new System.EventHandler(this.bt_Delete_MouseLeave);
            // 
            // bt_Edit
            // 
            this.bt_Edit.BackColor = System.Drawing.Color.DarkOrange;
            this.bt_Edit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_Edit.Location = new System.Drawing.Point(981, 231);
            this.bt_Edit.Name = "bt_Edit";
            this.bt_Edit.Size = new System.Drawing.Size(340, 59);
            this.bt_Edit.TabIndex = 27;
            this.bt_Edit.Text = "Корекция на данни";
            this.bt_Edit.UseVisualStyleBackColor = false;
            this.bt_Edit.Click += new System.EventHandler(this.bt_Edit_Click);
            this.bt_Edit.MouseEnter += new System.EventHandler(this.bt_Edit_MouseEnter);
            this.bt_Edit.MouseLeave += new System.EventHandler(this.bt_Edit_MouseLeave);
            // 
            // bt_Add
            // 
            this.bt_Add.BackColor = System.Drawing.Color.Chartreuse;
            this.bt_Add.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_Add.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_Add.Location = new System.Drawing.Point(981, 151);
            this.bt_Add.Name = "bt_Add";
            this.bt_Add.Size = new System.Drawing.Size(340, 59);
            this.bt_Add.TabIndex = 26;
            this.bt_Add.Text = "Запиши";
            this.bt_Add.UseVisualStyleBackColor = false;
            this.bt_Add.Click += new System.EventHandler(this.bt_Add_Click);
            this.bt_Add.MouseEnter += new System.EventHandler(this.bt_Add_MouseEnter);
            this.bt_Add.MouseLeave += new System.EventHandler(this.bt_Add_MouseLeave);
            // 
            // tb_Specialty
            // 
            this.tb_Specialty.Location = new System.Drawing.Point(42, 397);
            this.tb_Specialty.Name = "tb_Specialty";
            this.tb_Specialty.Size = new System.Drawing.Size(198, 22);
            this.tb_Specialty.TabIndex = 25;
            this.tb_Specialty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StudentRegister_KeyPress_1);
            // 
            // tb_Fcn
            // 
            this.tb_Fcn.Location = new System.Drawing.Point(604, 268);
            this.tb_Fcn.Name = "tb_Fcn";
            this.tb_Fcn.Size = new System.Drawing.Size(198, 22);
            this.tb_Fcn.TabIndex = 24;
            this.tb_Fcn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StudentRegister_KeyPress_1);
            // 
            // tb_Sname
            // 
            this.tb_Sname.Location = new System.Drawing.Point(327, 268);
            this.tb_Sname.Name = "tb_Sname";
            this.tb_Sname.Size = new System.Drawing.Size(198, 22);
            this.tb_Sname.TabIndex = 23;
            this.tb_Sname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StudentRegister_KeyPress_1);
            // 
            // tb_Fname
            // 
            this.tb_Fname.Location = new System.Drawing.Point(42, 268);
            this.tb_Fname.Name = "tb_Fname";
            this.tb_Fname.Size = new System.Drawing.Size(198, 22);
            this.tb_Fname.TabIndex = 22;
            this.tb_Fname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StudentRegister_KeyPress_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(598, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 33);
            this.label3.TabIndex = 21;
            this.label3.Text = "Факултет:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(36, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 33);
            this.label4.TabIndex = 20;
            this.label4.Text = "Специалност:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(321, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 33);
            this.label2.TabIndex = 19;
            this.label2.Text = "Фамилия:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(36, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 33);
            this.label1.TabIndex = 18;
            this.label1.Text = "Име:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(321, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 33);
            this.label5.TabIndex = 29;
            this.label5.Text = "Курс:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(598, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 33);
            this.label6.TabIndex = 30;
            this.label6.Text = "Група:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(36, 476);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(219, 33);
            this.label7.TabIndex = 31;
            this.label7.Text = "Факултетен номер:";
            // 
            // tb_Course
            // 
            this.tb_Course.Location = new System.Drawing.Point(312, 397);
            this.tb_Course.Name = "tb_Course";
            this.tb_Course.Size = new System.Drawing.Size(198, 22);
            this.tb_Course.TabIndex = 32;
            this.tb_Course.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StudentRegister_KeyPress_1);
            // 
            // tb_Group
            // 
            this.tb_Group.Location = new System.Drawing.Point(589, 397);
            this.tb_Group.Name = "tb_Group";
            this.tb_Group.Size = new System.Drawing.Size(198, 22);
            this.tb_Group.TabIndex = 33;
            this.tb_Group.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StudentRegister_KeyPress_1);
            // 
            // tb_FacultyNumber
            // 
            this.tb_FacultyNumber.Location = new System.Drawing.Point(42, 533);
            this.tb_FacultyNumber.Name = "tb_FacultyNumber";
            this.tb_FacultyNumber.Size = new System.Drawing.Size(198, 22);
            this.tb_FacultyNumber.TabIndex = 34;
            // 
            // bt_Exit
            // 
            this.bt_Exit.BackColor = System.Drawing.Color.Red;
            this.bt_Exit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_Exit.Location = new System.Drawing.Point(1109, 746);
            this.bt_Exit.Name = "bt_Exit";
            this.bt_Exit.Size = new System.Drawing.Size(174, 68);
            this.bt_Exit.TabIndex = 35;
            this.bt_Exit.Text = "Затвори";
            this.bt_Exit.UseVisualStyleBackColor = false;
            this.bt_Exit.Click += new System.EventHandler(this.bt_Exit_Click);
            this.bt_Exit.MouseEnter += new System.EventHandler(this.bt_Exit_MouseEnter);
            this.bt_Exit.MouseLeave += new System.EventHandler(this.bt_Exit_MouseLeave);
            // 
            // bt_Refresh
            // 
            this.bt_Refresh.BackColor = System.Drawing.Color.Chartreuse;
            this.bt_Refresh.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_Refresh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_Refresh.Location = new System.Drawing.Point(981, 317);
            this.bt_Refresh.Name = "bt_Refresh";
            this.bt_Refresh.Size = new System.Drawing.Size(340, 63);
            this.bt_Refresh.TabIndex = 36;
            this.bt_Refresh.Text = "Обнови";
            this.bt_Refresh.UseVisualStyleBackColor = false;
            this.bt_Refresh.Click += new System.EventHandler(this.bt_Refresh_Click);
            this.bt_Refresh.MouseEnter += new System.EventHandler(this.bt_Refresh_MouseEnter);
            this.bt_Refresh.MouseLeave += new System.EventHandler(this.bt_Refresh_MouseLeave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(552, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(318, 33);
            this.label8.TabIndex = 37;
            this.label8.Text = "Регистрация на студент";
            // 
            // bt_DelleteAll
            // 
            this.bt_DelleteAll.BackColor = System.Drawing.Color.Red;
            this.bt_DelleteAll.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_DelleteAll.Location = new System.Drawing.Point(981, 485);
            this.bt_DelleteAll.Name = "bt_DelleteAll";
            this.bt_DelleteAll.Size = new System.Drawing.Size(340, 59);
            this.bt_DelleteAll.TabIndex = 38;
            this.bt_DelleteAll.Text = "Изтрите всички записи";
            this.bt_DelleteAll.UseVisualStyleBackColor = false;
            this.bt_DelleteAll.Click += new System.EventHandler(this.bt_DelleteAll_Click);
            this.bt_DelleteAll.MouseEnter += new System.EventHandler(this.bt_DelleteAll_MouseEnter);
            this.bt_DelleteAll.MouseLeave += new System.EventHandler(this.bt_DelleteAll_MouseLeave);
            // 
            // StudentRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1456, 1044);
            this.Controls.Add(this.bt_DelleteAll);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bt_Refresh);
            this.Controls.Add(this.bt_Exit);
            this.Controls.Add(this.tb_FacultyNumber);
            this.Controls.Add(this.tb_Group);
            this.Controls.Add(this.tb_Course);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bt_Delete);
            this.Controls.Add(this.bt_Edit);
            this.Controls.Add(this.bt_Add);
            this.Controls.Add(this.tb_Specialty);
            this.Controls.Add(this.tb_Fcn);
            this.Controls.Add(this.tb_Sname);
            this.Controls.Add(this.tb_Fname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StudentRegister";
            this.Text = "StudentRegister";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StudentRegister_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StudentRegister_KeyPress_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem началоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem доToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заМенToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem регистрацияНаСтудентToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem доходиНаСтудентToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_Delete;
        private System.Windows.Forms.Button bt_Edit;
        private System.Windows.Forms.Button bt_Add;
        private System.Windows.Forms.TextBox tb_Specialty;
        private System.Windows.Forms.TextBox tb_Fcn;
        private System.Windows.Forms.TextBox tb_Sname;
        private System.Windows.Forms.TextBox tb_Fname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_Course;
        private System.Windows.Forms.TextBox tb_Group;
        private System.Windows.Forms.TextBox tb_FacultyNumber;
        private System.Windows.Forms.Button bt_Exit;
        private System.Windows.Forms.Button bt_Refresh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bt_DelleteAll;
    }
}