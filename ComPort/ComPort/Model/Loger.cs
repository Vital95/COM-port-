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

        static public String GetPortName()
        {
            
            StreamReader reader = new StreamReader("port.txt");
            String name = reader.ReadLine();
            return name;


        }

        static public String GetSpeed()
        {
            StreamReader reader = new StreamReader("speed.txt");
            String speed = reader.ReadLine();
            reader.Close();
            return speed;
        }

        static public void SetPortName(String name)
        {
            StreamWriter writer = new StreamWriter("port.txt");
            writer.WriteLine(name);
            writer.Close();
        }
    }
}
