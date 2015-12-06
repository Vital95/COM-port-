using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComPort
{
    class Data
    {
        private int value;
        private int status;
        private int id;
        private String outInfo;

        public int Value
        {
            get
            {
                return value;
            }
            set
            {
                this.value = Value;
            }
        }

        public int Status
        {
            get
            {
                return status;
            }
            set
            {
                this.status = Status;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                this.id = Id;
            }
        }

        public String OutInfo
        {
            get
            {
                return outInfo;
            }
            set
            {
                this.outInfo = OutInfo;
            }
        }
    }
}
