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
        public Form1()
        {
            InitializeComponent();
            dataGridView1.ColumnCount = 5;
            dataGridView1.RowCount = 3;
            dataGridView1.Rows.Insert(0, "Афонькин", "Максим", "Артемович", "ПрК 17-1", 1);
            

        }
        
    }
}
