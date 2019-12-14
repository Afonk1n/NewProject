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
            }
            else
            {
                label3.Visible = true;
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
    }
}
