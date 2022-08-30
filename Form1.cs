using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            int[] myArray = new int[] { 0, 1, 2, 3, 13, 8, 5 };
            int largest = int.MinValue;
            int second = int.MinValue;
            foreach (int i in myArray)
            {
                if (i > largest)
                {
                    second = largest;
                    largest = i;
                }
                else if (i > second)
                {
                    second = i;
                }
            }

            int l = second;
        }
        private void toolStripMenuCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxTerminal.SelectedText))
            {
                Clipboard.SetText(textBoxTerminal.Text);
            }
            else
            {

            }
        }

        private void textBoxTerminal_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (string.IsNullOrEmpty(textBoxTerminal.SelectedText))
                {
                    textBoxTerminal.ContextMenuStrip = new ContextMenuStrip();
                }
                else
                {
                    textBoxTerminal.ContextMenuStrip = this.contextMenuStrip;
                }
            }
        }

        private void textBoxTerminal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                e.Handled = true; // Prevent Delete key being used in text box
            }
            else if ((e.KeyCode == Keys.Left) || (e.KeyCode == Keys.Right) || (e.KeyCode == Keys.Up) || (e.KeyCode == Keys.Down))
            {
                // Allow cursor keys in middle of text box
                e.Handled = false;
            }

        }

        private void textBoxTerminal_KeyPress(object sender, KeyPressEventArgs e)
        {
            string response = "None";
            if (e.KeyChar == '\b')
            {
                if (textBoxTerminal.SelectionStart != textBoxTerminal.Text.Length)
                {
                    e.Handled = true; // Ignore backspace if it is not at the end of the text box
                }
                // Send backspace character to RT for it to delete characters received
                else if (true)//!_controlSystemDebugger.LockSendBackspace(ref response))
                {
                    //DisconnectedDebugger(); // If we have failed to send then the interface is disconnected
                }
                else
                {
                    // We have sent the character to the RT for it to delete the character received
                    // If the RT echoed the backspace, handle backspace character in TextBox control for it to delete the last character
                    e.Handled = !(response == " ");
                }
            }
            else
            {
                if ((e.KeyChar == '\r') || (!char.IsControl(e.KeyChar)))
                {
                    // if Return or not a control key then send it to the RT
                    //if (true)//_controlSystemDebugger.LockCommandAndResponse(e.KeyChar.ToString(), ref response))
                    {
                       // AppendTerminalResponse(response);
                    }
                    //else
                    {
                        //DisconnectedDebugger();
                    }
                }
                e.Handled = false; // Do not send character into TextBox control we have handled it here
            }

        }
    }
}
