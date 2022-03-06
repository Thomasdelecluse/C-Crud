
namespace Entreprise_app
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.mobilefixetxt = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.addressetxt = new System.Windows.Forms.TextBox();
            this.mobiletxt = new System.Windows.Forms.TextBox();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.searchBx = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.u_mobiletxt = new System.Windows.Forms.MaskedTextBox();
            this.u_mobilef = new System.Windows.Forms.MaskedTextBox();
            this.u_email = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.servicetxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.villetxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.u_addressetxt = new System.Windows.Forms.TextBox();
            this.IDTXT = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.u_nametxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.emailtxt);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.mobilefixetxt);
            this.groupBox1.Controls.Add(this.btn_save);
            this.groupBox1.Controls.Add(this.addressetxt);
            this.groupBox1.Controls.Add(this.mobiletxt);
            this.groupBox1.Controls.Add(this.nametxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 236);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ajouter salariés ";
            this.groupBox1.Visible = Program.isAdmin;
            // 
            // emailtxt
            // 
            this.emailtxt.Location = new System.Drawing.Point(142, 159);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(330, 27);
            this.emailtxt.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 159);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 20);
            this.label11.TabIndex = 8;
            this.label11.Text = "Email :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 20);
            this.label10.TabIndex = 7;
            this.label10.Text = "Mobile fixe :";
            // 
            // mobilefixetxt
            // 
            this.mobilefixetxt.Location = new System.Drawing.Point(142, 126);
            this.mobilefixetxt.Name = "mobilefixetxt";
            this.mobilefixetxt.Size = new System.Drawing.Size(330, 27);
            this.mobilefixetxt.TabIndex = 6;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_save.Location = new System.Drawing.Point(312, 201);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(119, 29);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "Sauvegarder";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // addressetxt
            // 
            this.addressetxt.Location = new System.Drawing.Point(142, 64);
            this.addressetxt.Multiline = true;
            this.addressetxt.Name = "addressetxt";
            this.addressetxt.Size = new System.Drawing.Size(330, 27);
            this.addressetxt.TabIndex = 5;
            // 
            // mobiletxt
            // 
            this.mobiletxt.Location = new System.Drawing.Point(142, 95);
            this.mobiletxt.Name = "mobiletxt";
            this.mobiletxt.Size = new System.Drawing.Size(330, 27);
            this.mobiletxt.TabIndex = 4;
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(142, 33);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(330, 27);
            this.nametxt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prenom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mobile Portable :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.searchBx);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(547, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1223, 616);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Données Salariés";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GrayText;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1171, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // searchBx
            // 
            this.searchBx.Location = new System.Drawing.Point(1030, 17);
            this.searchBx.Name = "searchBx";
            this.searchBx.Size = new System.Drawing.Size(145, 27);
            this.searchBx.TabIndex = 2;
            this.searchBx.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 50);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1176, 547);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox3.Controls.Add(this.u_mobiletxt);
            this.groupBox3.Controls.Add(this.u_mobilef);
            this.groupBox3.Controls.Add(this.u_email);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.servicetxt);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.villetxt);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.u_addressetxt);
            this.groupBox3.Controls.Add(this.IDTXT);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.u_nametxt);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(12, 392);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(485, 331);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Supprimer ou Modifier";
            this.groupBox3.Visible = Program.isAdmin;
            // 
            // u_mobiletxt
            // 
            this.u_mobiletxt.Location = new System.Drawing.Point(143, 94);
            this.u_mobiletxt.Mask = "00 00 00 00 00";
            this.u_mobiletxt.Name = "u_mobiletxt";
            this.u_mobiletxt.Size = new System.Drawing.Size(336, 27);
            this.u_mobiletxt.TabIndex = 7;
            // 
            // u_mobilef
            // 
            this.u_mobilef.Location = new System.Drawing.Point(143, 126);
            this.u_mobilef.Mask = "00 00 00 00 00";
            this.u_mobilef.Name = "u_mobilef";
            this.u_mobilef.Size = new System.Drawing.Size(335, 27);
            this.u_mobilef.TabIndex = 3;
            // 
            // u_email
            // 
            this.u_email.Location = new System.Drawing.Point(143, 160);
            this.u_email.Name = "u_email";
            this.u_email.Size = new System.Drawing.Size(335, 27);
            this.u_email.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 162);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 20);
            this.label13.TabIndex = 15;
            this.label13.Text = "Email :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 129);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 20);
            this.label12.TabIndex = 14;
            this.label12.Text = "Mobile fixe :";
            // 
            // servicetxt
            // 
            this.servicetxt.Location = new System.Drawing.Point(143, 228);
            this.servicetxt.Multiline = true;
            this.servicetxt.Name = "servicetxt";
            this.servicetxt.Size = new System.Drawing.Size(335, 29);
            this.servicetxt.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Service :";
            // 
            // villetxt
            // 
            this.villetxt.Location = new System.Drawing.Point(143, 193);
            this.villetxt.Multiline = true;
            this.villetxt.Name = "villetxt";
            this.villetxt.Size = new System.Drawing.Size(335, 29);
            this.villetxt.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Ville :";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.Location = new System.Drawing.Point(360, 296);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 29);
            this.button2.TabIndex = 9;
            this.button2.Text = "Supprimer";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(235, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "Modifier";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // u_addressetxt
            // 
            this.u_addressetxt.Location = new System.Drawing.Point(143, 59);
            this.u_addressetxt.Multiline = true;
            this.u_addressetxt.Name = "u_addressetxt";
            this.u_addressetxt.Size = new System.Drawing.Size(335, 29);
            this.u_addressetxt.TabIndex = 8;
            // 
            // IDTXT
            // 
            this.IDTXT.AutoSize = true;
            this.IDTXT.Location = new System.Drawing.Point(21, 262);
            this.IDTXT.Name = "IDTXT";
            this.IDTXT.Size = new System.Drawing.Size(31, 20);
            this.IDTXT.TabIndex = 6;
            this.IDTXT.Text = "ID :";
            this.IDTXT.Click += new System.EventHandler(this.label7_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Prenom :";
            // 
            // u_nametxt
            // 
            this.u_nametxt.Location = new System.Drawing.Point(143, 26);
            this.u_nametxt.Name = "u_nametxt";
            this.u_nametxt.Size = new System.Drawing.Size(335, 27);
            this.u_nametxt.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Nom :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mobile portable :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(90)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(-5, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1790, 90);
            this.panel1.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(17, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(52, 46);
            this.button3.TabIndex = 1;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(516, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(353, 45);
            this.label7.TabIndex = 0;
            this.label7.Text = "Formulaire Entreprise";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1782, 753);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label IDTXT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox addressetxt;
        private System.Windows.Forms.TextBox mobiletxt;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox u_addressetxt;
        private System.Windows.Forms.TextBox u_nametxt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox searchBx;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox villetxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox servicetxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox mobilefixetxt;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox u_email;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox u_mobilef;
        private System.Windows.Forms.MaskedTextBox u_mobiletxt;
    }
}

