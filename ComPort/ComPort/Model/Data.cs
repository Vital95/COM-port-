using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComPort
{
    public class Data
    {
        private int value;
        private int status;
        private int id;
        private String outInfo;

        public Data(int value,int status, int id, String outInfo)
        {
            this.value = value;
            this.status = status;
            this.id = id;
            this.outInfo = outInfo;
        }

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
