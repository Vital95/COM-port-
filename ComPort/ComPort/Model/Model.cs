using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComPort
{
    class Model
    {
        #region Events
        public event EventHandler<MessageEventArgs> recvMessage;
        #endregion
        WorkWithPort workWithPort;

        public Model()
        {
            workWithPort = new WorkWithPort();
            workWithPort.recvMessage += RecvMessage;
        }

        public String[] GetPortList()
        {
            return workWithPort.GetPortList();
        }

        public void OpenConnection(String portName)
        {
            try
            {
                workWithPort.CreateConnection(portName);
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private void RecvMessage(object sender, MessageEventArgs e)
        {
            if(recvMessage != null)
            {
                recvMessage(this, e);
            }
        }
    }

}
