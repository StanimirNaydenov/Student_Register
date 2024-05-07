namespace CurseWork1
{
    partial class StudentInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentInfo));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Fname = new System.Windows.Forms.TextBox();
            this.tb_Egn = new System.Windows.Forms.TextBox();
            this.tb_Adr = new System.Windows.Forms.TextBox();
            this.bt_Add = new System.Windows.Forms.Button();
            this.bt_Edit = new System.Windows.Forms.Button();
            this.bt_Exit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_Delete = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.началоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заМенToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.доToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.регистрацияНаСтудентToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.доходиНаСтудентToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bt_Refresh = new System.Windows.Forms.Button();
            this.bt_DelleteAll = new System.Windows.Forms.Button();
            this.tb_City = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(45, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Име:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(378, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Фамилия:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(378, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(249, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "Адресна регистрация:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(658, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 33);
            this.label3.TabIndex = 4;
            this.label3.Text = "ЕГН:";
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(51, 209);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(198, 22);
            this.tb_Name.TabIndex = 5;
            this.tb_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Name_KeyPress);
            // 
            // tb_Fname
            // 
            this.tb_Fname.Location = new System.Drawing.Point(384, 209);
            this.tb_Fname.Name = "tb_Fname";
            this.tb_Fname.Size = new System.Drawing.Size(198, 22);
            this.tb_Fname.TabIndex = 6;
            this.tb_Fname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Fname_KeyPress);
            // 
            // tb_Egn
            // 
            this.tb_Egn.Location = new System.Drawing.Point(664, 209);
            this.tb_Egn.Name = "tb_Egn";
            this.tb_Egn.Size = new System.Drawing.Size(198, 22);
            this.tb_Egn.TabIndex = 7;
            this.tb_Egn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Egn_KeyPress);
            // 
            // tb_Adr
            // 
            this.tb_Adr.Location = new System.Drawing.Point(384, 311);
            this.tb_Adr.Name = "tb_Adr";
            this.tb_Adr.Size = new System.Drawing.Size(198, 22);
            this.tb_Adr.TabIndex = 8;
            this.tb_Adr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Adr_KeyPress);
            // 
            // bt_Add
            // 
            this.bt_Add.BackColor = System.Drawing.Color.Chartreuse;
            this.bt_Add.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_Add.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_Add.Location = new System.Drawing.Point(683, 321);
            this.bt_Add.Name = "bt_Add";
            this.bt_Add.Size = new System.Drawing.Size(293, 59);
            this.bt_Add.TabIndex = 9;
            this.bt_Add.Text = "Запиши";
            this.bt_Add.UseVisualStyleBackColor = false;
            this.bt_Add.Click += new System.EventHandler(this.bt_Add_Click);
            this.bt_Add.MouseEnter += new System.EventHandler(this.bt_Add_MouseEnter);
            this.bt_Add.MouseLeave += new System.EventHandler(this.bt_Add_MouseLeave);
            // 
            // bt_Edit
            // 
            this.bt_Edit.BackColor = System.Drawing.Color.DarkOrange;
            this.bt_Edit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_Edit.Location = new System.Drawing.Point(1036, 321);
            this.bt_Edit.Name = "bt_Edit";
            this.bt_Edit.Size = new System.Drawing.Size(293, 59);
            this.bt_Edit.TabIndex = 10;
            this.bt_Edit.Text = "Корекция на данни";
            this.bt_Edit.UseVisualStyleBackColor = false;
            this.bt_Edit.Click += new System.EventHandler(this.bt_Edit_Click);
            this.bt_Edit.MouseEnter += new System.EventHandler(this.bt_Edit_MouseEnter);
            this.bt_Edit.MouseLeave += new System.EventHandler(this.bt_Edit_MouseLeave);
            // 
            // bt_Exit
            // 
            this.bt_Exit.BackColor = System.Drawing.Color.Red;
            this.bt_Exit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_Exit.Location = new System.Drawing.Point(1144, 647);
            this.bt_Exit.Name = "bt_Exit";
            this.bt_Exit.Size = new System.Drawing.Size(174, 68);
            this.bt_Exit.TabIndex = 11;
            this.bt_Exit.Text = "Затвори";
            this.bt_Exit.UseVisualStyleBackColor = false;
            this.bt_Exit.Click += new System.EventHandler(this.bt_Exit_Click);
            this.bt_Exit.MouseEnter += new System.EventHandler(this.bt_Exit_MouseEnter);
            this.bt_Exit.MouseLeave += new System.EventHandler(this.bt_Exit_MouseLeave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(504, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(307, 33);
            this.label5.TabIndex = 12;
            this.label5.Text = "Лични данни на студент";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 377);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(602, 338);
            this.dataGridView1.TabIndex = 13;
            // 
            // bt_Delete
            // 
            this.bt_Delete.BackColor = System.Drawing.Color.Red;
            this.bt_Delete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_Delete.Location = new System.Drawing.Point(683, 417);
            this.bt_Delete.Name = "bt_Delete";
            this.bt_Delete.Size = new System.Drawing.Size(293, 59);
            this.bt_Delete.TabIndex = 14;
            this.bt_Delete.Text = "Изтрите";
            this.bt_Delete.UseVisualStyleBackColor = false;
            this.bt_Delete.Click += new System.EventHandler(this.bt_Delete_Click);
            this.bt_Delete.MouseEnter += new System.EventHandler(this.bt_Delete_MouseEnter);
            this.bt_Delete.MouseLeave += new System.EventHandler(this.bt_Delete_MouseLeave);
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
            this.menuStrip1.Size = new System.Drawing.Size(1350, 37);
            this.menuStrip1.TabIndex = 15;
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
            // bt_Refresh
            // 
            this.bt_Refresh.BackColor = System.Drawing.Color.Chartreuse;
            this.bt_Refresh.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_Refresh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_Refresh.Location = new System.Drawing.Point(860, 521);
            this.bt_Refresh.Name = "bt_Refresh";
            this.bt_Refresh.Size = new System.Drawing.Size(335, 63);
            this.bt_Refresh.TabIndex = 16;
            this.bt_Refresh.Text = "Обнови";
            this.bt_Refresh.UseVisualStyleBackColor = false;
            this.bt_Refresh.Click += new System.EventHandler(this.bt_Refresh_Click);
            this.bt_Refresh.MouseEnter += new System.EventHandler(this.bt_Refresh_MouseEnter);
            this.bt_Refresh.MouseLeave += new System.EventHandler(this.bt_Refresh_MouseLeave);
            // 
            // bt_DelleteAll
            // 
            this.bt_DelleteAll.BackColor = System.Drawing.Color.Red;
            this.bt_DelleteAll.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_DelleteAll.Location = new System.Drawing.Point(1036, 417);
            this.bt_DelleteAll.Name = "bt_DelleteAll";
            this.bt_DelleteAll.Size = new System.Drawing.Size(293, 59);
            this.bt_DelleteAll.TabIndex = 39;
            this.bt_DelleteAll.Text = "Изтрите всички записи";
            this.bt_DelleteAll.UseVisualStyleBackColor = false;
            this.bt_DelleteAll.Click += new System.EventHandler(this.bt_DelleteAll_Click);
            this.bt_DelleteAll.MouseEnter += new System.EventHandler(this.bt_DelleteAll_MouseEnter);
            this.bt_DelleteAll.MouseLeave += new System.EventHandler(this.bt_DelleteAll_MouseLeave);
            // 
            // tb_City
            // 
            this.tb_City.Location = new System.Drawing.Point(51, 311);
            this.tb_City.Name = "tb_City";
            this.tb_City.Size = new System.Drawing.Size(198, 22);
            this.tb_City.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(45, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 33);
            this.label6.TabIndex = 40;
            this.label6.Text = "Град:";
            // 
            // StudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1350, 738);
            this.Controls.Add(this.tb_City);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bt_DelleteAll);
            this.Controls.Add(this.bt_Refresh);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.bt_Delete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bt_Exit);
            this.Controls.Add(this.bt_Edit);
            this.Controls.Add(this.bt_Add);
            this.Controls.Add(this.tb_Adr);
            this.Controls.Add(this.tb_Egn);
            this.Controls.Add(this.tb_Fname);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StudentInfo";
            this.Text = "StudentInfo";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StudentInfo_KeyDown_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_Fname;
        private System.Windows.Forms.TextBox tb_Egn;
        private System.Windows.Forms.TextBox tb_Adr;
        private System.Windows.Forms.Button bt_Add;
        private System.Windows.Forms.Button bt_Edit;
        private System.Windows.Forms.Button bt_Exit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_Delete;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem началоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem доToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заМенToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem регистрацияНаСтудентToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem доходиНаСтудентToolStripMenuItem;
        private System.Windows.Forms.Button bt_Refresh;
        private System.Windows.Forms.Button bt_DelleteAll;
        private System.Windows.Forms.TextBox tb_City;
        private System.Windows.Forms.Label label6;
    }
}