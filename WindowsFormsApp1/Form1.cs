using System;
using System.Collections;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private BitArray keyStream; // Ключевой поток
        private BitArray coefficientVector; // Вектор коэффициентов
        private BitArray initializationVector; // Вектор инициализации
        private BitArray message; // Исходное сообщение
        private BitArray result; // Зашифрованное сообщение
        private ParseUtils parseUtils = new ParseUtils();
        private string stringResult;
        static public bool isText;

        public Form1()
        {
            InitializeComponent();
            isText = true;
        }

        private void Encrypt_Click(object sender, EventArgs e)
        {
            AlgorithmicPart(textBoxMessage, textBoxCipherText, message, result, 0);
        }

        private void Decrypt_Click(object sender, EventArgs e)
        {
            AlgorithmicPart(textBoxCipherText, textBoxMessage, result, message, 1);
        }

        private void IsNullInputData(TextBox textBox)
        {
            if (textBox.Text == "" || textBoxСoefficientVector.Text == "" || textBoxInitializationVector.Text == "")
            {
                MessageBox.Show("Не введены исходные данные", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void AlgorithmicPart(TextBox textBoxIn, TextBox textBoxOut, BitArray bitArrayIn, BitArray bitArrayOut, int operationType)
        {
            IsNullInputData(textBoxIn);
            if (stringSequence.Checked)
                bitArrayIn = CaseStringSequence(bitArrayIn, operationType);
            else if (bitSequence.Checked)
                bitArrayIn = CaseBitSequence(bitArrayIn, operationType);
            while (keyStream.Length != bitArrayIn.Length)
                BitCalculations(initializationVector, coefficientVector);
            for (int i = 0; i < keyStream.Length; i++)
                textBoxKeyStream.Text = string.Concat(textBoxKeyStream.Text, keyStream[i] ? "1" : "0");
            bitArrayOut = keyStream.Xor(bitArrayIn);
            stringResult = parseUtils.BitArrayToString(bitArrayOut);
            textBoxOut.Text = stringResult;
        }
        private BitArray CaseStringSequence(BitArray bitArray, int operationType)
        {
            coefficientVector = parseUtils.TextBoxStringToBites(textBoxСoefficientVector);
            initializationVector = parseUtils.TextBoxStringToBites(textBoxInitializationVector);
            keyStream = parseUtils.TextBoxStringToBites(textBoxInitializationVector);
            if (operationType == 0)
            {
                message = parseUtils.TextBoxStringToBites(textBoxMessage);
                bitArray = message;
            }
            else if (operationType == 1)
            {
                result = parseUtils.TextBoxStringToBites(textBoxCipherText);
                bitArray = result;
            }
            return bitArray;
        }

        private BitArray CaseBitSequence(BitArray bitArray, int operationType)
        {
            isText = false;
            coefficientVector = parseUtils.CharSymbolToBoolSymbol(coefficientVector, textBoxСoefficientVector);
            initializationVector = parseUtils.CharSymbolToBoolSymbol(initializationVector, textBoxInitializationVector);
            keyStream = parseUtils.CharSymbolToBoolSymbol(keyStream, textBoxInitializationVector);
            if (operationType == 0)
            {
                message = parseUtils.CharSymbolToBoolSymbol(message, textBoxMessage);
                bitArray = message;
            }
            else if (operationType == 1)
            {
                result = parseUtils.CharSymbolToBoolSymbol(result, textBoxCipherText);
                bitArray = result;
            }
            return bitArray;
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            textBoxMessage.Text = "";
            textBoxСoefficientVector.Text = "";
            textBoxInitializationVector.Text = "";
            textBoxKeyStream.Text = "";
            textBoxCipherText.Text = "";
            isText = true;
        }

        private void BitCalculations(BitArray bitArrayFirst, BitArray bitArraySecond)
        {
            BitArray bitArrayResult = bitArrayFirst.And(bitArraySecond);
            bool bitInArray = bitArrayResult[0];

            for (int i = 1; i < bitArrayResult.Length; i++)
                bitInArray = bitInArray ^ bitArrayResult[i];

            keyStream.Length = keyStream.Length + 1;
            keyStream.Set(keyStream.Length - 1, bitInArray);
            bool[] keyStreamBoolArray = new bool[keyStream.Length];
            keyStream.CopyTo(keyStreamBoolArray, 0);
            bool[] coefficientVectorBoolArray = new bool[coefficientVector.Length];

            Array.Copy(keyStreamBoolArray, keyStream.Length - coefficientVector.Length, coefficientVectorBoolArray, 0, coefficientVector.Length);

            initializationVector = new BitArray(coefficientVectorBoolArray);
        }
    }
}
