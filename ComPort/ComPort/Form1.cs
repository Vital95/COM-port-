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

        private Controller control = new Controller();
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
            for (int i = 0; i < 4; i++)
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

        private void chosePortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String[] comPortsSet = control.GetComPorts();
            GenerationOfCheckPorts(comPortsSet);
        }

        private void GenerationOfCheckPorts(String [] ports)
        {
            chosePortToolStripMenuItem.DropDownItems.Clear();
            foreach (String s in ports)
            {
                ToolStripMenuItem menuItem = new ToolStripMenuItem();
                menuItem.Text = s;
                menuItem.Click += control.ChoisePortHandler;
                menuItem.Click += OutPort;

                menuItem.Size = new System.Drawing.Size(180, 22);
                menuItem.Name = s;
                chosePortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                menuItem});
            }
        }

        private void OutPort(object sender, EventArgs e)
        {
            label1.Text = "Port : " + (sender as ToolStripMenuItem).Text;
        }
    }
}
