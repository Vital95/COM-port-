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
            DateTime localDate = DateTime.Now;
            if (ValidateData(data))
            {
                
                Data goodData = new Data();
                char[] delimiterChars = {','};
                string[] words = data.Split(delimiterChars);
                int i = 0;
                int[] q = new int[words.Length];
                foreach (string s in words)
                {
                    if (int.TryParse(data, out q[i]))
                        i++;
                }
                goodData.Id = q[1];
                goodData.Status = q[2];
                goodData.Value = q[3];
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

        private bool ValidateData(String data)
        {
            System.Text.RegularExpressions.Regex rgx = new System.Text.RegularExpressions.Regex(@"[A][,][0 - 9]{ 1,2}[,]\d{1}[,]\d{1,3}[#]");
            return rgx.IsMatch(data);
        }
    }
}
