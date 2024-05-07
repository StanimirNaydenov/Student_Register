namespace CurseWork1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bt_Exit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.началоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заМенToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.доToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.регистрацияНаСтудентToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.доходиНаСтудентToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_Exit
            // 
            this.bt_Exit.BackColor = System.Drawing.Color.Red;
            this.bt_Exit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_Exit.Location = new System.Drawing.Point(1271, 694);
            this.bt_Exit.Name = "bt_Exit";
            this.bt_Exit.Size = new System.Drawing.Size(163, 59);
            this.bt_Exit.TabIndex = 1;
            this.bt_Exit.Text = "Изход";
            this.bt_Exit.UseVisualStyleBackColor = false;
            this.bt_Exit.Click += new System.EventHandler(this.bt_Exit_Click);
            this.bt_Exit.MouseEnter += new System.EventHandler(this.bt_Exit_MouseEnter);
            this.bt_Exit.MouseLeave += new System.EventHandler(this.bt_Exit_MouseLeave);
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
            this.menuStrip1.Size = new System.Drawing.Size(1513, 37);
            this.menuStrip1.TabIndex = 2;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(644, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Начало";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(568, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(829, 479);
            this.label2.TabIndex = 4;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CurseWork1.Properties.Resources.plovdivski_universitet_paisij_hilendarski_02;
            this.pictureBox1.Location = new System.Drawing.Point(30, 170);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(487, 432);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1513, 775);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_Exit);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bt_Exit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem доToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заМенToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem регистрацияНаСтудентToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem доходиНаСтудентToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem началоToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

