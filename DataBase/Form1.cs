using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
        }
        private bool isChanged = false;
        private bool IsEngLetter(char a)
        {
            if (char.IsLetter(a))
            {
                if ((a >= 'a') && (a <= 'z') || (a >= 'A') && (a <= 'Z'))
                {
                    return true;
                }
            }
            return false;
                
        }
        private void firstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!IsEngLetter(e.KeyChar))
            {
                e.KeyChar = char.MinValue;
            }
        }

        private void phoneNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
                e.KeyChar = char.MinValue;
        }

        private void lastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!IsEngLetter(e.KeyChar))
            {
                e.KeyChar = char.MinValue;
            }
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (!CheckForm())
            {
                MessageBox.Show("Fill all the mandatory fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Your form has been saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool CheckForm()
        {
            if ((!isChanged) || (phoneNum.Text.Length != 7))
            {
                phoneNum.BackColor = Color.Red;
                return false;
            }

            if (firstName.Text.Length < 2)
            {
                firstName.BackColor = Color.Red;
                return false;
            }

            if (lastName.Text.Length < 2)
            {
                lastName.BackColor = Color.Red;
                return false;
            }

            if (zipCode.Text.Length < 5)
            {
                zipCode.BackColor = Color.Red;
                return false;
            }
            return true;
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            isChanged = true;
        }
    }
}
