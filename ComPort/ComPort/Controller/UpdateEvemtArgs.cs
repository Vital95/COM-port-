using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComPort
{
    class UpdateEventArgs : EventArgs
    {
        private Data[] info;

        public UpdateEventArgs(Data[] info)
        {
            this.info = info;
        }
        public Data[] Info
        {
            get
            {
                return info;
            }
            set
            {
                this.info = Info;
            }
        }
    }
}
