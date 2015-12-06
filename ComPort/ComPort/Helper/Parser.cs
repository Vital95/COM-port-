using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            if (!ValidateData(newData))
            {
                
                Data goodData = new Data();
                char[] delimiterChars1 = { ',', '\n', '\t', '\r' };
                string[] words1 = data.Split(delimiterChars);
                int i = 0;
                int[] q = new int[words.Length];
                foreach (string s in words1)
                {
                    if (int.TryParse(newData, out q[i]))
                        i++;
                }
                goodData.Id = q[0];
                goodData.Status = q[1];
                goodData.Value = q[2];
                String time = localDate.ToString();

                goodData.OutInfo = data + time;
                return goodData;
            }
            else
            {
                Data badData = new Data();
                badData = null;
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
            System.Text.RegularExpressions.Regex rgx = new System.Text.RegularExpressions.Regex(@"[A][,][0 - 9]{ 1,2}[,]\d{1}[,]\d{1,3}[#]");
            return rgx.IsMatch(newData);
        }
    }
}
