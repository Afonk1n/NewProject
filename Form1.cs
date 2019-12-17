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
            dataGridView1.Rows.Insert(1, "ZakirovaR", "123", "Закирова", "Регина", "Артуровна", "Педагог", 1, 1);
            dataGridView1.Rows.Insert(2, "admin", "123", "Фатюшкин", "Андрей", "Алексеевич", "Администратор", 3, 2);           
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {                     
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                string log = dataGridView1[0, i].Value.ToString();
                string pass = dataGridView1[1, i].Value.ToString();
                if ((bunifuTextBox1.Text == log) && (bunifuTextBox2.Text == pass))
                {
                    timer1.Enabled = true;
                    timer1.Start();
                    notuser++;
                    id = i;
                    
                }
            }
            if (notuser == 0)
            {
                timer2.Enabled = true;
                timer2.Start();
                bunifuTextBox1.BorderColorIdle = Color.FromArgb(255, 128, 128);
                bunifuTextBox1.PlaceholderForeColor = Color.FromArgb(255, 128, 128);
                bunifuTextBox2.BorderColorIdle = Color.FromArgb(255, 128, 128);
                bunifuTextBox2.PlaceholderForeColor = Color.FromArgb(255, 128, 128);
                label4.Visible = true;
                label4.Text = "Неверный логин или пароль";
            }

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
            bunifuTextBox1.BorderColorIdle = Color.FromArgb(255, 128, 128);
            bunifuTextBox1.PlaceholderForeColor = Color.FromArgb(240, 240, 240);
            bunifuTextBox2.BorderColorIdle = Color.FromArgb(255, 128, 128);
            bunifuTextBox2.PlaceholderForeColor = Color.FromArgb(240, 240, 240);
            timer2.Stop();
            timer2.Enabled = false;
        }

        //-------------------------Кнопки формы-------------------------//
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(189, 56, 56);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(45, 50, 121);
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox2.BackColor = Color.FromArgb(60, 64, 137);
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.FromArgb(45, 50, 121);
        }
        //-------------------------Кнопки формы-------------------------//
    }
}
