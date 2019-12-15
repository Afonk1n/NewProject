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
            dataGridView2.Rows.Insert(1, "ZakirovaR", "321", "Закирова", "Регина", "Артуровна", "Педагог", 1, 1);
            dataGridView2.Rows.Insert(2, "FatushkinA", "123", "Фатюшкин", "Андрей", "-", "ПрК 17-1", 2, 2);
            string name = dataGridView2.Rows[id].Cells[2].Value.ToString();
            string surname = dataGridView2.Rows[id].Cells[3].Value.ToString();
            label1.Text = name + " " + surname;
            if (Convert.ToInt32(dataGridView2.Rows[id].Cells[6].Value) == 2)
            {
                label2.Visible = true;
                label2.Text = "Группа: " + dataGridView2.Rows[id].Cells[5].Value.ToString();
                label10.Visible = true;
            }
            else
            {
                label3.Visible = true;
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


        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Label4_Click(object sender, EventArgs e)
        {
            if (label5.Visible == false)
            {
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
            }
            else
            {
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
            }
        }

        //Ссылки------------------------------------------------
        private void Label6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://vk.com/vestimpk");
        }

        private void Label7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://newlms.magtu.ru/course/view.php?id=26619");
        }

        private void Label5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://newlms.magtu.ru/");
        }

        private void Label8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://newlms.magtu.ru/mod/folder/view.php?id=219213");
        }

        private void Label9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://newlms.magtu.ru/mod/folder/view.php?id=219250");
        }
    }
}
