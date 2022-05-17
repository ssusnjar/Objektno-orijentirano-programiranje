namespace WindowsFormsApp1
{
    partial class Proizvodi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Proizvodi));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cijena = new System.Windows.Forms.MaskedTextBox();
            this.kolicina = new System.Windows.Forms.MaskedTextBox();
            this.odabir = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Broj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaprod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ukupno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.imeprod = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.Menu;
            this.label1.Location = new System.Drawing.Point(44, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 28);
            this.label1.TabIndex = 12;
            this.label1.Text = "CIJENA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.Menu;
            this.label2.Location = new System.Drawing.Point(44, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 28);
            this.label2.TabIndex = 13;
            this.label2.Text = "KOLIČINA";
            // 
            // cijena
            // 
            this.cijena.BackColor = System.Drawing.SystemColors.Menu;
            this.cijena.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.cijena.Location = new System.Drawing.Point(262, 252);
            this.cijena.Name = "cijena";
            this.cijena.Size = new System.Drawing.Size(120, 22);
            this.cijena.TabIndex = 15;
            this.cijena.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.cijena_MaskInputRejected);
            // 
            // kolicina
            // 
            this.kolicina.BackColor = System.Drawing.SystemColors.Menu;
            this.kolicina.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.kolicina.Location = new System.Drawing.Point(262, 301);
            this.kolicina.Name = "kolicina";
            this.kolicina.Size = new System.Drawing.Size(120, 22);
            this.kolicina.TabIndex = 16;
            // 
            // odabir
            // 
            this.odabir.FormattingEnabled = true;
            this.odabir.Location = new System.Drawing.Point(262, 152);
            this.odabir.Name = "odabir";
            this.odabir.Size = new System.Drawing.Size(120, 24);
            this.odabir.TabIndex = 17;
            this.odabir.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.Menu;
            this.label3.Location = new System.Drawing.Point(44, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 28);
            this.label3.TabIndex = 18;
            this.label3.Text = "ODABERITE ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Broj,
            this.prodime,
            this.cijenaprod,
            this.kol,
            this.ukupno});
            this.dataGridView1.Location = new System.Drawing.Point(451, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(820, 262);
            this.dataGridView1.TabIndex = 20;
            // 
            // Broj
            // 
            this.Broj.HeaderText = "Broj";
            this.Broj.MinimumWidth = 6;
            this.Broj.Name = "Broj";
            this.Broj.Width = 125;
            // 
            // prodime
            // 
            this.prodime.HeaderText = "Ime proizvoda";
            this.prodime.MinimumWidth = 6;
            this.prodime.Name = "prodime";
            this.prodime.Width = 125;
            // 
            // cijenaprod
            // 
            this.cijenaprod.HeaderText = "Cijenaproizvoda";
            this.cijenaprod.MinimumWidth = 6;
            this.cijenaprod.Name = "cijenaprod";
            this.cijenaprod.Width = 125;
            // 
            // kol
            // 
            this.kol.HeaderText = "Kolicina";
            this.kol.MinimumWidth = 6;
            this.kol.Name = "kol";
            this.kol.Width = 125;
            // 
            // ukupno
            // 
            this.ukupno.HeaderText = "Ukupno";
            this.ukupno.MinimumWidth = 6;
            this.ukupno.Name = "ukupno";
            this.ukupno.Width = 125;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.SystemColors.Menu;
            this.button1.Location = new System.Drawing.Point(89, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 39);
            this.button1.TabIndex = 22;
            this.button1.Text = "DODAJ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.SystemColors.Menu;
            this.button2.Location = new System.Drawing.Point(451, 477);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(247, 56);
            this.button2.TabIndex = 23;
            this.button2.Text = "SPREMI RAČUN";
            this.button2.UseMnemonic = false;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.ForeColor = System.Drawing.SystemColors.Menu;
            this.button3.Location = new System.Drawing.Point(1014, 477);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(219, 56);
            this.button3.TabIndex = 24;
            this.button3.Text = "IZLAZ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.ForeColor = System.Drawing.SystemColors.Menu;
            this.button4.Location = new System.Drawing.Point(734, 477);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(247, 56);
            this.button4.TabIndex = 25;
            this.button4.Text = "ISPIŠI RAČUN";
            this.button4.UseMnemonic = false;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.Menu;
            this.label6.Location = new System.Drawing.Point(44, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 28);
            this.label6.TabIndex = 11;
            this.label6.Text = "IME PROIZVODA";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // imeprod
            // 
            this.imeprod.BackColor = System.Drawing.SystemColors.Menu;
            this.imeprod.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.imeprod.Location = new System.Drawing.Point(262, 200);
            this.imeprod.Name = "imeprod";
            this.imeprod.Size = new System.Drawing.Size(120, 22);
            this.imeprod.TabIndex = 14;
            this.imeprod.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.korisnickoime_MaskInputRejected);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1240, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // Proizvodi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1333, 659);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.odabir);
            this.Controls.Add(this.kolicina);
            this.Controls.Add(this.cijena);
            this.Controls.Add(this.imeprod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Proizvodi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Proizvodi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox cijena;
        private System.Windows.Forms.MaskedTextBox kolicina;
        private System.Windows.Forms.ComboBox odabir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Broj;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodime;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaprod;
        private System.Windows.Forms.DataGridViewTextBoxColumn kol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ukupno;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox imeprod;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}