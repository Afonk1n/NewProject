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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
           
                     
        }
        public Form2(Form1 form1, int id)
        {
            InitializeComponent();
            dataGridView2.ColumnCount = 8;

            dataGridView2.Rows.Insert(0, "AfonkinM", "123", "Афонькин", "Максим", "Артемович", "ПрК 17-1", 2, 0);
            dataGridView2.Rows.Insert(1, "ZakirovaR", "123", "Закирова", "Регина", "Артуровна", "Педагог", 1, 1);
            dataGridView2.Rows.Insert(2, "admin", "123", "Фатюшкин", "Андрей", "-", "Администратор", 3, 2);
            string name = dataGridView2.Rows[id].Cells[2].Value.ToString();
            string surname = dataGridView2.Rows[id].Cells[3].Value.ToString();
            label1.Text = name + "\n  " + surname;
            if (Convert.ToInt32(dataGridView2.Rows[id].Cells[6].Value) == 2) //student
            {
                label2.Enabled = true;
                label2.Visible = true;
                label2.Text = "Группа: " + dataGridView2.Rows[id].Cells[5].Value.ToString();
                pictureBox3.Image = Image.FromFile("data/avatarmale2.png");
                label3.Visible = true;
                bunifuTextBox1.Visible = false;
                bunifuTextBox2.Visible = false;
                bunifuTextBox3.Visible = false;
            }
            else
            {
                if(Convert.ToInt32(dataGridView2.Rows[id].Cells[6].Value) == 3) //admin
                {
                    pictureBox3.Image = Image.FromFile("data/avatarmale.png");
                    label2.Text = "" + dataGridView2.Rows[id].Cells[5].Value.ToString();
                    label2.Enabled = true;
                    label2.Visible = true;
                    label11.Visible = false;
                    bunifuDatePicker1.Visible = false;
                    label2.ForeColor = Color.FromArgb(255, 128, 128);
                    label2.Location = new Point(63, 282);

                    bunifuTextBox1.Visible = true;
                    bunifuTextBox1.Enabled = true;
                    bunifuTextBox1.Size = new Size(337, 80);
                    bunifuTextBox2.Visible = true;
                    bunifuTextBox2.Enabled = true;
                    bunifuTextBox2.Size = new Size(337, 80);
                    bunifuTextBox3.Visible = true;
                    bunifuTextBox3.Enabled = true;
                    bunifuTextBox3.Size = new Size(337, 80);
                    label15.Visible = true;
                    label15.Enabled = true;
                    label16.Visible = true;
                    label16.Enabled = true;
                    label17.Visible = true;
                    label17.Enabled = true;
                    label4.Visible = false;
                    label4.Enabled = false;
                }
            }

            DateTime startdate = new DateTime(2019, 09, 01);
            int s=Convert.ToInt32((DateTime.Now.Date - startdate).Days);
            double numberWeek = s / 7;
            int number =Convert.ToInt32(Math.Floor(numberWeek));
            
            if (number%2==0)
            {
                label11.Text = "Чётная неделя";
            }
            else
            {
                label11.Text = "Нечётная неделя";
            }
            //label2.Text = "" + dataGridView2.Rows[id].Cells[5].Value.ToString();
        }

        //-------------------------Админка-------------------------//
        private void label15_Click(object sender, EventArgs e)
         {
            label12.Text = bunifuTextBox3.Text;
         }
        private void label16_Click(object sender, EventArgs e)
        {
            label13.Text = bunifuTextBox2.Text;
        }

        private void label17_Click(object sender, EventArgs e)
        {
            label14.Text = bunifuTextBox1.Text;
        }

        //-------------------------Админка-------------------------//

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

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form1 firstForm = new Form1();
            firstForm.Show();
            this.Close();
        }
    }
}
