using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComPort
{
    static class MessageHelper
    {
        public static void ShowMessage(string message)
        {
            MessageBox.Show(message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ShowExclamation(string exclamation)
        {
            MessageBox.Show(exclamation, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static void ShowError(string error)
        {
            MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
