using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaryTextConverter
{
    public partial class BinaryTextConverter : Form
    {
        public BinaryTextConverter()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void reverseTextBoxes()
        {
            if (BinaryTextBox.Text == "Binary:")
            {
                BinaryTextBox.Text = "Text:";
                TextTextBox.Text = "Binary:";
            }
            else
            {
                BinaryTextBox.Text = "Binary:";
                TextTextBox.Text = "Text:";
            }
            InputTextBox.Text = OutputTextBox.Text;
            OutputTextBox.Text = "";

        }

        private void ReverseButton_Click(object sender, EventArgs e)
        {
            reverseTextBoxes();
        }
        public Byte[] GetBytesFromBinaryString(String binary)
        {
            var list = new List<Byte>();

            for (int i = 0; i < binary.Length; i += 8)
            {
                
                String t = binary.Substring(i, 8);
                
                list.Add(Convert.ToByte(t, 2));
            }

            return list.ToArray();
        }
        bool HasNonASCIIChars(string str)
        {
            return (System.Text.Encoding.UTF8.GetByteCount(str) != str.Length);
        }
        public static byte[] ConvertToByteArray(string str, Encoding encoding)
        {
            return encoding.GetBytes(str);
        }
        public static String ToBinary(Byte[] data)
        {
            return string.Join(" ", data.Select(byt => Convert.ToString(byt, 2).PadLeft(8, '0')));
        }
        private void ConvertButton_Click(object sender, EventArgs e)
        {
            if (BinaryTextBox.Text == "Binary:")
            {
                string userInput = InputTextBox.Text;
                string[] subs = userInput.Split(' ');
                string result = "";
                foreach (var sub in subs)
                {
                    if (sub.Length < 8)
                    {
                        OutputTextBox.Text = "Invalid binary string";
                        return;
                    }

                    var data = GetBytesFromBinaryString(sub);
                    var text = Encoding.ASCII.GetString(data);
                    bool isNotAscii = HasNonASCIIChars(text);
                    if (isNotAscii)
                    {
                        OutputTextBox.Text = "Invalid binary string";
                        return;
                    }
                    else
                    {
                        string newResult = text;
                        result = string.Join(" ", result, newResult);
                    }

                }
                OutputTextBox.Text = result;
                return;
            }
           else
            {
                var binary = ToBinary(ConvertToByteArray(InputTextBox.Text, Encoding.ASCII));
                OutputTextBox.Text = binary;
            }
        }
    }
}
