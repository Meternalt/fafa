using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if ((comboBox1.Text == "Бегун") && (textBox2.Text == "123"))
            {
                Form8 bmenu = new Form8();
                bmenu.Show();
                this.Hide();
            }
            else
                if ((comboBox1.Text== "Координатор") && (textBox2.Text=="124"))
                    {
                Form7 rco = new Form7();
                rco.Show();
                this.Hide();
            }
            else
                if ((comboBox1.Text == "Администратор") && (textBox2.Text == "789"))
            {
                Radmin radm = new Radmin();
                radm.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Glavnoe main = new Glavnoe();
            main.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
