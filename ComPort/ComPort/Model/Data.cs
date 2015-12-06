using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComPort
{
    public class Data
    {
        public int value;
        public int status;
        public int id;
        private String outInfo;

        public int Value
        {
            get
            {
                return value;
            }
            set
            {
                value = Value;
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
                status = Status;
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
                id = Id;
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
