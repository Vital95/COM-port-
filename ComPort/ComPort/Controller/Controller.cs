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

        public event EventHandler<UpdateEventArgs> ViewUpdeteHandler;

        public Controller()
        {
            model = new Model();
            model.recvMessage += recvMessage;
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

        private void recvMessage(object sender, MessageEventArgs e)
        {
            if (ViewUpdeteHandler != null)
            {
                ViewUpdeteHandler(this, new UpdateEventArgs(Parser.GetParesedData(e.Message)));
            }
        }


    }
}
