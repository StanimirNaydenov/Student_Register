namespace CurseWork1
{
    partial class EditStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditStudent));
            this.label5 = new System.Windows.Forms.Label();
            this.bt_Add = new System.Windows.Forms.Button();
            this.tb_Adr = new System.Windows.Forms.TextBox();
            this.tb_Egn = new System.Windows.Forms.TextBox();
            this.tb_Fname = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_City = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lemon", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(356, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(264, 26);
            this.label5.TabIndex = 24;
            this.label5.Text = "Лични данни на студент";
            // 
            // bt_Add
            // 
            this.bt_Add.BackColor = System.Drawing.Color.Chartreuse;
            this.bt_Add.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_Add.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_Add.Location = new System.Drawing.Point(409, 382);
            this.bt_Add.Name = "bt_Add";
            this.bt_Add.Size = new System.Drawing.Size(148, 31);
            this.bt_Add.TabIndex = 21;
            this.bt_Add.Text = "Запиши";
            this.bt_Add.UseVisualStyleBackColor = false;
            this.bt_Add.Click += new System.EventHandler(this.bt_Add_Click);
            this.bt_Add.MouseEnter += new System.EventHandler(this.bt_Add_MouseEnter);
            this.bt_Add.MouseLeave += new System.EventHandler(this.bt_Add_MouseLeave);
            // 
            // tb_Adr
            // 
            this.tb_Adr.Location = new System.Drawing.Point(387, 332);
            this.tb_Adr.Name = "tb_Adr";
            this.tb_Adr.Size = new System.Drawing.Size(198, 22);
            this.tb_Adr.TabIndex = 20;
            this.tb_Adr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Adr_KeyPress);
            // 
            // tb_Egn
            // 
            this.tb_Egn.Location = new System.Drawing.Point(387, 231);
            this.tb_Egn.Name = "tb_Egn";
            this.tb_Egn.Size = new System.Drawing.Size(198, 22);
            this.tb_Egn.TabIndex = 19;
            this.tb_Egn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Egn_KeyPress);
            // 
            // tb_Fname
            // 
            this.tb_Fname.Location = new System.Drawing.Point(387, 177);
            this.tb_Fname.Name = "tb_Fname";
            this.tb_Fname.Size = new System.Drawing.Size(198, 22);
            this.tb_Fname.TabIndex = 18;
            this.tb_Fname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Fname_KeyPress);
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(387, 115);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(198, 22);
            this.tb_Name.TabIndex = 17;
            this.tb_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Name_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(96, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "ЕГН:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(96, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 23);
            this.label4.TabIndex = 15;
            this.label4.Text = "Адресна регистрация:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(96, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Фамилия:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(96, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Име:";
            // 
            // tb_City
            // 
            this.tb_City.Location = new System.Drawing.Point(387, 277);
            this.tb_City.Name = "tb_City";
            this.tb_City.Size = new System.Drawing.Size(198, 22);
            this.tb_City.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(96, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 23);
            this.label6.TabIndex = 42;
            this.label6.Text = "Град:";
            // 
            // EditStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(842, 477);
            this.Controls.Add(this.tb_City);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
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
            this.Name = "EditStudent";
            this.Text = "EditStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_Add;
        private System.Windows.Forms.TextBox tb_Adr;
        private System.Windows.Forms.TextBox tb_Egn;
        private System.Windows.Forms.TextBox tb_Fname;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_City;
        private System.Windows.Forms.Label label6;
    }
}