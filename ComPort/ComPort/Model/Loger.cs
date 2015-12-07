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
            String name = null;
            try
            {
                StreamReader reader = new StreamReader("port.txt");
                name = reader.ReadLine();
                reader.Close();
            }
            catch(Exception e)
            {
                SetPortName("");
            }
            return name;
        }

        static public String GetSpeed()
        {
            String speed = null;
            try
            {
                StreamReader reader = new StreamReader("speed.txt");
                speed = reader.ReadLine();
                reader.Close();
            }
            catch(Exception e)
            {
                speed = "115200";
                CreateSpeedFile("115200");
            }
            return speed;
        }

        static public void SetPortName(String name)
        {
            StreamWriter writer = new StreamWriter("port.txt");
            writer.WriteLine(name);
            writer.Close();
        }

        static private void CreateSpeedFile(String speed)
        {
            StreamWriter writer = new StreamWriter("speed.txt");
            writer.WriteLine(speed);
            writer.Close();
        }
    }
}
