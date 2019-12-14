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
            dataGridView1.ColumnCount = 7;
            dataGridView1.Rows.Insert(0, "AfonkinM", "123", "Афонькин", "Максим", "Артемович", "ПрК 17-1", 2);
            dataGridView1.Rows.Insert(1, "ZakirovaR", "321", "Закирова", "Регина", "Артуровна", "Педагог", 1);
            dataGridView1.Rows.Insert(2, "FatushkinA", "123", "Фатюшкин", "Андрей", "-", "ПрК 17-1", 2);
        }
    }
}
