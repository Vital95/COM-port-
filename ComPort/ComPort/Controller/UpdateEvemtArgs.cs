using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComPort
{
    class UpdateEventArgs : EventArgs
    {
        private List<Data> info;

        public UpdateEventArgs(List<Data> info)
        {
            this.info = info;
        }
        public List<Data> Info
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
