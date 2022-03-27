using System;
using System.Text;
using System.Collections;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class ParseUtils
    {
        public BitArray CharSymbolToBoolSymbol(BitArray bitArray, TextBox textBox)
        {
            char[] charArray = textBox.Text.ToCharArray();
            bitArray = new BitArray(charArray.Length);

            for (int i = 0; i < bitArray.Length; i++)
                bitArray[i] = charArray[i] == '1';

            return bitArray;
        }

        public BitArray TextBoxStringToBites(TextBox textBox)
        {
            byte[] b = Encoding.UTF8.GetBytes(textBox.Text);
            BitArray bitArray = new BitArray(b);

            return bitArray;
        }

        public string BitArrayToString(BitArray bitArray)
        {
            string result = "";

            if (Form1.isText == true)
            {
                byte[] b = BitArrayToBytes(bitArray);
                result = Encoding.UTF8.GetString(b);
            }

            else
            {
                for (int i = 0; i < bitArray.Length; i++)
                    result = string.Concat(result, bitArray[i] ? "1" : "0");
            }

            return result;
        }

        public byte[] BitArrayToBytes(BitArray bitArray)
        {
            if (bitArray.Length == 0)
            {
                throw new ArgumentException("must have at least length 1", "bitarray");
            }

            int numOfBytes = bitArray.Length / 8;

            if (bitArray.Length % 8 != 0)
            {
                numOfBytes += 1;
            }

            var bytes = new byte[numOfBytes];
            bitArray.CopyTo(bytes, 0);

            return bytes;
        }
    }
}
