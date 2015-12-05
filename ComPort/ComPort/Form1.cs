using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComPort
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.dataGridView1.ColumnCount = 4;
            this.dataGridView1.RowCount = 4;
            this.dataGridView1.AutoSize = true;       
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ClearSelection();
            this.dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
           
            for(int i = 0; i<4; i++)
            {
                this.dataGridView1.Columns[i].Width = dataGridView1.Size.Width / 4;
                this.dataGridView1.Rows[i].Height = dataGridView1.Size.Height / 4;

            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                this.dataGridView1.Rows[i].Height = dataGridView1.Size.Height / 4;
            }
        }
    }
}
