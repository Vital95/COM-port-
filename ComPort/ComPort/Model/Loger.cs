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
            StreamWriter sw = File.AppendText("Log.txt");
            sw.WriteLine(data);
            sw.Close();
        }
    }
}
