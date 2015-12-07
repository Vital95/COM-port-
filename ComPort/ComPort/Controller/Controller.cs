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

        private Model model;
        private int speed;

        public event EventHandler<UpdateEventArgs> ViewUpdeteHandler;
        public event EventHandler<MessageEventArgs> UpdateLabel;

        public Controller()
        {
            model = new Model();
            model.recvMessage += recvMessage;
        }

        public void ChoisePortHandler(object sender, EventArgs e)
        {
            try
            {
                if(this.speed < 0)
                {
                    this.speed = 115200;
                }
                model.OpenConnection((sender as ToolStripMenuItem).Text, speed);
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError(ex.Message);
            }
        }

        public String[] GetComPorts()
        {
            String name = Loger.GetPortName();
            String speed = Loger.GetSpeed();
            String[] portNames = model.GetPortList();

            int iSpeed = Parser.GetSpeed(speed);
            if(iSpeed > 0)
            {
                this.speed = iSpeed; ;
            }

            if (name != null)
            {
                foreach(String port in portNames)
                {
                    if(port == name)
                    {
                        if(UpdateLabel != null)
                        {
                            UpdateLabel(this, new MessageEventArgs(name));
                        }
                       
                        if (iSpeed > 0)
                        {
                            model.OpenConnection(name, iSpeed);
                        }
                    }
                }
               
                 
            }
            return portNames;
        }

        private void recvMessage(object sender, MessageEventArgs e)
        {
            if (ViewUpdeteHandler != null)
            {
                ViewUpdeteHandler(this, new UpdateEventArgs(Parser.GetAllParsedData(e.Message)));
            }
        }


    }
}
