using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Proizvodi : Form
    {
        public Proizvodi()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            imeprod.Text = odabir.Text;
            if (imeprod.Text == "voda") cijena.Text = "10";
            if (imeprod.Text == "meso") cijena.Text = "30";
            if (imeprod.Text == "jogurt") cijena.Text = "6";
            if (imeprod.Text == "cokolada") cijena.Text = "12";
            if (imeprod.Text == "mlijeko") cijena.Text = "18";
            if (imeprod.Text == "kruh") cijena.Text = "8";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Proizvodi_Load(object sender, EventArgs e)
        {
            odabir.Items.Add("voda");
            odabir.Items.Add("meso");
            odabir.Items.Add("jogurt");
            odabir.Items.Add("cokolada");
            odabir.Items.Add("mlijeko");
            odabir.Items.Add("kruh");
        }
        int n = 0;
        private void button1_Click(object sender, EventArgs e)
        {
           
            if (imeprod.Text==""||kolicina.Text=="")
            {
                MessageBox.Show("Molimo popunite podatke!");
            }
            else
            {
                DataGridViewRow novired = new DataGridViewRow();
                novired.CreateCells(dataGridView1);
                novired.Cells[0].Value = n + 1;
                
                novired.Cells[1].Value = imeprod.Text;
                novired.Cells[2].Value = cijena.Text;
                novired.Cells[3].Value = kolicina.Text;
                novired.Cells[4].Value = Convert.ToInt32(cijena.Text) * Convert.ToInt32(kolicina.Text);
                dataGridView1.Rows.Add(novired);
                n++;
            }
        }

        private void korisnickoime_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

         private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog ime = new SaveFileDialog();
            if (ime.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path = ime.FileName;
                TextWriter writer = new StreamWriter(File.Create(path));
                for(int i=0;i< dataGridView1.Rows.Count-1;i++)
                {
                    for(int j=0;j< dataGridView1.Columns.Count;j++)
                    {
                        writer.Write(dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t");
                    }
                    writer.WriteLine("");
                }
                writer.Close();
                MessageBox.Show("Račun uspiješno spremljen");
            }

                
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string file = null;
            Form3 P = new Form3(this);
           
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                file = dlg.FileName;
            }
            P.richTextBox1.Text=File.ReadAllText(file);
            P.ShowDialog();
        }

        private void cijena_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.WindowState=FormWindowState.Minimized;
        }
    }
}
