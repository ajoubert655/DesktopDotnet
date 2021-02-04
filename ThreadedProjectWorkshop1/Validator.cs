using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadedProjectWorkshop1
{
    class Validator
    {
        public static bool IsProvided(TextBox textBox, string name)
        {
            bool isValid = true;
            if(textBox.Text == "")
            {
                isValid = false;
                MessageBox.Show(name + " are required");
                textBox.Focus();
            }
            return isValid;
        }
        public static bool IsPresent(TextBox textBox)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(textBox.Tag + " is a required field.", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }
    }
}
