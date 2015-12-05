using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComPort
{
    public class MessageEventArgs : EventArgs
    {
        private String message;

        public MessageEventArgs(String message)
        {
            this.message = message;
        }

        public String Message
        {
            get
            {
                return message;
            }
        }
    }
}
