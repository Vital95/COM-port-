using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.IO.Ports;

namespace ComPort
{
    class WorkWithPort
    {

        #region Events
        public event EventHandler<MessageEventArgs> recvMessage;
        #endregion
        private SerialPort port = new SerialPort();

        public String[] GetPortList()
        {
            return SerialPort.GetPortNames();
        }

        public void CreateConnection(String portName, int speed)
        {
            try
            {
                if (!port.IsOpen)
                {
                    port.PortName = portName;
                    port.BaudRate = speed;
                    port.DataReceived += DataReceivedHandler;
                    port.Open();
                }
                else
                {
                    if(port.PortName != portName)
                    {
                        port.Close();
                        port.PortName = portName;
                        port.BaudRate = 280;
                        port.DataReceived += DataReceivedHandler;
                        port.Open();
                    }
                }
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            String indata = sp.ReadExisting();
            if (recvMessage != null)
            {
                recvMessage(this, new MessageEventArgs(indata));
            }
        }

        ~WorkWithPort()
        {
            if (port.IsOpen)
            {
                Loger.SetPortName(port.PortName);
                port.Close();
            }
        }
    }
}
