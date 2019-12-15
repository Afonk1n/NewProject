using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewProject
{
    public partial class Form1 : Form
    {
        public static int id;
        int notuser = 0;
        
        public Form1()
        {
            
            InitializeComponent();
            timer1.Interval = 5000;
            timer2.Interval = 5000;
            dataGridView1.ColumnCount = 8;           
            dataGridView1.Rows.Insert(0, "AfonkinM", "123", "Афонькин", "Максим", "Артемович", "ПрК 17-1", 2, 0);
            dataGridView1.Rows.Insert(1, "ZakirovaR", "321", "Закирова", "Регина", "Артуровна", "Педагог", 1, 1);
            dataGridView1.Rows.Insert(2, "admin", "1", "Admin", "Moder", "-", "-", 3, 2);           
        }

        private void Button1_Click(object sender, EventArgs e)
        {                     
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                string log = dataGridView1[0, i].Value.ToString();
                string pass = dataGridView1[1, i].Value.ToString();
                if ((textBox1.Text == log) && (textBox2.Text == pass))
                {
                    timer1.Enabled = true;
                    timer1.Start();
                    notuser++;
                    id = i;
                    
                }
            }
            if (notuser == 0)
            {
                label4.Text = "Неверный логин или пароль";
                timer2.Enabled = true;
                timer2.Start();
            }

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {           
            Form2 secondForm = new Form2(this, id);
            secondForm.Show();
            this.Hide();           
            timer1.Stop();
            timer1.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label4.Text = "";
            timer2.Stop();
            timer2.Enabled = false;
        }
    }
}
