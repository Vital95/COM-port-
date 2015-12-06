using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ComPort
{
    static public class Loger
    {
        static public void SetLog(String data)
        {
            StreamWriter file = new StreamWriter("Log.txt");
            file.WriteLine(data);

            file.Close();
        }
    }
}
