using System;
using System.Windows.Forms;
using System.Text;
using System.Collections;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private BitArray z, iv, c, m, r;
        bool text = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1 == null || textBox2 == null || textBox3 == null)
            { MessageBox.Show("Не введены исходные данные", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (radioButton1.Checked == true)
            {
                m = ToBites(textBox1);
                c = ToBites(textBox2);
                iv = ToBites(textBox3);
                z = ToBites(textBox3);
            }
            else if (radioButton1.Checked == true)
            {
                text = false;
                char[] c = textBox1.Text.ToCharArray();
                char[] c1 = textBox2.Text.ToCharArray();
                char[] c2 = textBox3.Text.ToCharArray();
                m = new BitArray(c.Length);
                this.c = new BitArray(c1.Length);
                iv = new BitArray(c2.Length);
                z = new BitArray(c2.Length);
                for (int i = 0; i < m.Length; i++)
                {
                    if (c[i] == '1')
                        m[i] = true;
                    else m[i] = false;
                }
                for (int i = 0; i < this.c.Length; i++)
                {
                    if (c1[i] == '1')
                        this.c[i] = true;
                    else this.c[i] = false;
                }
                for (int i = 0; i < iv.Length; i++)
                {
                    if (c2[i] == '1')
                    { iv[i] = true; z[i] = true; }
                    else { iv[i] = false; z[i] = false; }
                }
            }
            while (z.Length != m.Length)
                Action(iv, c);
            for (int i = 0; i < z.Length; i++)
                textBox4.Text = string.Concat(textBox4.Text, z[i] ? "1" : "0");
            r = z.Xor(m);
            string res1 = ToString(r);
            textBox5.Text = res1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox5 == null || textBox2 == null || textBox3 == null)
            { MessageBox.Show("Не введены исходные данные", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (radioButton1.Checked == true)
            {
                r = ToBites(textBox5);
                c = ToBites(textBox2);
                iv = ToBites(textBox3);
                z = ToBites(textBox3);
            }
            else if (radioButton1.Checked == true)
            {
                text = false;
                char[] c = textBox5.Text.ToCharArray();
                char[] c1 = textBox2.Text.ToCharArray();
                char[] c2 = textBox3.Text.ToCharArray();
                r = new BitArray(c.Length);
                this.c = new BitArray(c1.Length);
                iv = new BitArray(c2.Length);
                z = new BitArray(c2.Length);
                for (int i = 0; i < r.Length; i++)
                {
                    if (c[i] == '1')
                        r[i] = true;
                    else r[i] = false;
                }
                for (int i = 0; i < this.c.Length; i++)
                {
                    if (c1[i] == '1')
                        this.c[i] = true;
                    else this.c[i] = false;
                }
                for (int i = 0; i < iv.Length; i++)
                {
                    if (c2[i] == '1')
                    { iv[i] = true; z[i] = true; }
                    else { iv[i] = false; z[i] = false; }
                }
            }
            while (z.Length != r.Length)
                Action(iv, c);
            for (int i = 0; i < z.Length; i++)
                textBox4.Text = string.Concat(textBox4.Text, z[i] ? "1" : "0");
            m = z.Xor(r);
            string res1 = ToString(m);
            textBox1.Text = res1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = ""; textBox4.Text = ""; textBox5.Text = ""; text = true;
        }

        BitArray ToBites(TextBox textBox)
        {
            byte[] b = Encoding.UTF8.GetBytes(textBox.Text); BitArray bitArray = new BitArray(b);
            return bitArray;
        }

        string ToString(BitArray bitArray)
        {
            string result = "";
            //bitArray.ToString();
            if (text == true)
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

        public static byte[] BitArrayToBytes(BitArray bitarray)
        {
            if (bitarray.Length == 0)
            {
                throw new ArgumentException("must have at least length 1", "bitarray");
            }

            int num_bytes = bitarray.Length / 8;

            if (bitarray.Length % 8 != 0)
            {
                num_bytes += 1;
            }

            var bytes = new byte[num_bytes];
            bitarray.CopyTo(bytes, 0);
            return bytes;
        }

        void Action(BitArray bitArray1, BitArray bitArray2)
        {
            BitArray res = bitArray1.And(bitArray2);
            bool r = res[0];
            for (int i = 1; i < res.Length; i++)
                r = r ^ res[i];
            z.Length = z.Length + 1;
            z.Set(z.Length - 1, r);
            int len = z.Length;
            bool[] gamma_new = new bool[len];
            z.CopyTo(gamma_new, 0);
            bool[] beta_new = new bool[c.Length];
            Array.Copy(gamma_new, z.Length - c.Length, beta_new, 0, c.Length);
            iv = new BitArray(beta_new);
        }
    }
}
