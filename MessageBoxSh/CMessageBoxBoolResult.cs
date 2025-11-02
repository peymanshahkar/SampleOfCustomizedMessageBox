using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MessageBoxSh
{
    public static class CMessageBoxBoolResult
    {
        public static bool Show(string message, string title)
        {
            if (CMessageBox.Show(message, title) == DialogResult.Yes)
            {
                return true;
            }
            return false;
        }
        public static bool Show(string message, string title,MessageBoxButtons buttons)
        {
           
            DialogResult result = CMessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes || result == DialogResult.OK)
            {
                return true;
            }
            return false;
        }

        public static bool Show(string message, string title, MessageBoxButtons buttons,MessageBoxSh.MessageBoxIcon messageBoxIcon)
        {
            DialogResult result = CMessageBox.Show(message, title, buttons,messageBoxIcon);
            if (result == DialogResult.Yes || result == DialogResult.OK)
            {
                return true;
            }
            return false;
        }


    }
}
