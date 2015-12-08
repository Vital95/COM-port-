using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComPort
{
    public partial class Form1 : Form
    {
        private Controller control = new Controller();

        private List<Color> color = new List<Color>();

        public Form1()
        {
            
            InitializeComponent();
            control.ViewUpdeteHandler += UpdateDataGridHandler;
            control.UpdateLabel += UpdateLabel;
            #region badone
            color.Add(Color.Transparent);
            color.Add(Color.Brown);
            color.Add(Color.Red);
            color.Add(Color.Orange);
            color.Add(Color.Yellow);
            color.Add(Color.Green);
            color.Add(Color.Blue);
            color.Add(Color.Purple);
            color.Add(Color.Gray);
            color.Add(Color.White);
            #endregion
        }

        public class Color1
        {
            
        }

        private void UpdateDataGridHandler(object sender, UpdateEventArgs e)
        {
            UpdateDataGrid(e.Info);
        }

        private void UpdateDataGrid(List<Data> dataMas)
        {
            if (dataMas == null) { return; }
            foreach (Data data in dataMas)
            {
                if(data == null)
                {
                    return;
                }
                if (InvokeRequired)
                {
                    Action action = () =>
                    {
                        if (data.Id - 3 <= 0)
                        {
                            if (this.dataGridView1.Rows[0].Cells[data.Id].Value != null)
                            {
                                if (data.Status != Parser.GetStatus(this.dataGridView1.Rows[0].Cells[data.Id].Value.ToString()))
                                {
                                    SystemSounds.Asterisk.Play();

                                };
                            }
                            try
                            {
                                this.dataGridView1.Rows[0].Cells[data.Id].Value = data.OutInfo;
                                this.dataGridView1.Rows[0].Cells[data.Id].Style.BackColor = color[data.Status];
                            }
                            catch (Exception e) { }

                        }
                        else
                        {
                            if (data.Id - 4 >= 0 && data.Id - 7 <= 0)
                            {
                                if (this.dataGridView1.Rows[1].Cells[data.Id - 4].Value != null)
                                {
                                    if (data.Status != Parser.GetStatus(this.dataGridView1.Rows[1].Cells[data.Id - 4].Value.ToString()))
                                    {
                                        SystemSounds.Asterisk.Play();

                                    };
                                }

                                try
                                {
                                    this.dataGridView1.Rows[1].Cells[data.Id - 4].Value = data.OutInfo;
                                    this.dataGridView1.Rows[1].Cells[data.Id - 4].Style.BackColor = color[data.Status];
                                }
                                catch (Exception ex) { }
                            }
                            else
                            {
                                if (data.Id - 8 >= 0 && data.Id - 11 <= 0)
                                {
                                    if (this.dataGridView1.Rows[2].Cells[data.Id - 8].Value != null)
                                    {
                                        if (data.Status != Parser.GetStatus(this.dataGridView1.Rows[2].Cells[data.Id - 8].Value.ToString()))
                                        {
                                            SystemSounds.Asterisk.Play();

                                        };
                                    }
                                    try
                                    {
                                        this.dataGridView1.Rows[2].Cells[data.Id - 8].Value = data.OutInfo;
                                        this.dataGridView1.Rows[2].Cells[data.Id - 8].Style.BackColor = color[data.Status];
                                    }
                                    catch (Exception e) { }

                                }
                                else
                                {
                                    if (data.Id - 12 >= 0 && data.Id - 15 <= 0)
                                    {
                                        if (this.dataGridView1.Rows[3].Cells[data.Id - 12].Value != null)
                                        {
                                            if (data.Status != Parser.GetStatus(this.dataGridView1.Rows[3].Cells[data.Id - 12].Value.ToString()))
                                            {
                                                 SystemSounds.Asterisk.Play();
                                            };
                                        }
                                        try
                                        {
                                            this.dataGridView1.Rows[3].Cells[data.Id - 12].Value = data.OutInfo;
                                            this.dataGridView1.Rows[3].Cells[data.Id - 12].Style.BackColor = color[data.Status];
                                        }
                                        catch (Exception e) { }
                                    }
                                }
                            }
                        }

                    };
                    Invoke(action);
                }
                else
                {
                    if(data == null)
                    {
                        return;
                    }
                    if (data.Id - 3 <= 0)
                    {
                        if (this.dataGridView1.Rows[0].Cells[data.Id].Value != null)
                        {
                            if (data.Status != Parser.GetStatus(this.dataGridView1.Rows[0].Cells[data.Id].Value.ToString()))
                            {
                                SystemSounds.Asterisk.Play();

                            };
                        }
                        this.dataGridView1.Rows[0].Cells[data.Id].Value = data.OutInfo;
                        this.dataGridView1.Rows[0].Cells[data.Id].Style.BackColor = color[data.Status];
                    }
                    else
                    {
                        if (data.Id - 4 >= 0 && data.Id - 7 <= 0)
                        {
                            if (this.dataGridView1.Rows[1].Cells[data.Id - 4].Value != null)
                            {
                                if (data.Status != Parser.GetStatus(this.dataGridView1.Rows[1].Cells[data.Id - 4].Value.ToString()))
                                {
                                    SystemSounds.Asterisk.Play();

                                };
                            }
                            this.dataGridView1.Rows[1].Cells[data.Id - 4].Value = data.OutInfo;
                            this.dataGridView1.Rows[1].Cells[data.Id - 4].Style.BackColor = color[data.Status];
                        }
                        else
                        {
                            if (data.Id - 8 >= 0 && data.Id - 11 <= 0)
                            {
                                if (this.dataGridView1.Rows[2].Cells[data.Id - 8].Value != null)
                                {
                                    if (data.Status != Parser.GetStatus(this.dataGridView1.Rows[2].Cells[data.Id - 8].Value.ToString()))
                                    {
                                        SystemSounds.Asterisk.Play();

                                    };
                                }
                                this.dataGridView1.Rows[2].Cells[data.Id - 8].Value = data.OutInfo;
                                this.dataGridView1.Rows[2].Cells[data.Id - 8].Style.BackColor = color[data.Status];
                            }
                            else
                            {
                                if (data.Id - 12 >= 0 && data.Id - 15 <= 0)
                                {
                                    if (this.dataGridView1.Rows[3].Cells[data.Id - 12].Value != null)
                                    {
                                        if (data.Status != Parser.GetStatus(this.dataGridView1.Rows[3].Cells[data.Id - 12].Value.ToString()))
                                        {
                                            SystemSounds.Asterisk.Play();
                                        };
                                    }
                                    this.dataGridView1.Rows[3].Cells[data.Id - 12].Value = data.OutInfo;
                                    this.dataGridView1.Rows[3].Cells[data.Id - 12].Style.BackColor = color[data.Status];
                                }
                            }
                        }
                    }
                }
            }
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
            try
            {
                label1.Text = "Port : " + Loger.GetPortName();
            }
            catch (Exception ex) { }
            String[] comPortsSet = control.GetComPorts();
            GenerationOfCheckPorts(comPortsSet);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                this.dataGridView1.Rows[i].Height = dataGridView1.Size.Height / 4;
            }
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

        private void UpdateLabel(object sender, MessageEventArgs e)
        {
            if (InvokeRequired)
            {
                Action action = () =>
                {
                    label1.Text = e.Message;
                };
                Invoke(action);
            }
        }
    }
}
