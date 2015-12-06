using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace ComPort
{
    class Parser
    {
        public Data GetParesedData(String data)
        {
            char[] delimiterChars = {'\n', '\t', '\r' };
            string[] words = data.Split(delimiterChars);
            string newData="";
            foreach (string s in words)
            {
                newData += s;
            }
            DateTime localDate = DateTime.Now;
            if (ValidateData(newData))
            {

                Data goodData;
                char[] delimiterChars1 = { ',', '\n', '\t', '\r', '#' };
                string[] words1 = newData.Split(delimiterChars1);
                string[] words2 = new string[words1.Length-1];
                int q = 0;
                for(; q< words1.Length - 1; q++)
                { 
                    words2[q] = words1[q];
                }
                int i = 0;
                int[] z = new int[words2.Length];
                foreach (string s in words2)
                {
                    if (int.TryParse(s, out z[i]))
                        i++;
                }
                
                String time1 = localDate.ToShortDateString().ToString();
                String time2 = localDate.ToShortTimeString().ToString();

                String sum = data + " " + time1 + " " + time2;
                goodData = new Data(z[2],z[1],z[0],sum);
                return goodData;
                
            }
            else
            {
                
                Data badData = null;
                return badData;
            }
        }

        private bool ValidateData(string data)
        {
            char[] delimiterChars = { '\n', '\t', '\r' };
            string[] words = data.Split(delimiterChars);
            string newData = "";
            foreach (string s in words)
            {
                newData += s;
            }
            //System.Text.RegularExpressions.Regex rgx = new System.Text.RegularExpressions.Regex(@"[A][,][0 - 9]{ 1,2}[,]\d{1}[,]\d{1,3}[#]");
            //return rgx.IsMatch(newData);

            //Match m = Regex.Match(newData, @"[A][,][0 - 9]{ 1,2}[,]\d{1}[,]\d{1,3}[#]");
            //Match m = Regex.Match(newData, "[A][,][0-9]{1,2}[,][0-9][,][0-9]{1,3}[#]");
            
            Match m = Regex.Match(newData, "[A][,](([0-9]|[0-1][0-5]))[,][0-9][,][0-9]{1,3}[#]");
            if (m.Success)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
