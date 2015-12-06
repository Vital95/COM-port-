using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComPort
{
    class Controller
    {

        Model model;

        public Controller()
        {
            model = new Model();
        }

        public void ChoisePortHandler(object sender, EventArgs e)
        {
            try
            {
                model.OpenConnection((sender as ToolStripMenuItem).Text);
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError(ex.Message);
            }
        }

        public String[] GetComPorts()
        {
            return model.GetPortList();
        }


    }
}
