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
            if (textBoxMessage == null || textBoxСoefficientVector == null || textBoxInitializationVector == null)
            {
                MessageBox.Show("Не введены исходные данные", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (stringSequence.Checked)
                CaseStringSequence();

            else if (bitSequence.Checked)
                CaseBitSequence();

            while (keyStream.Length != message.Length)
                BitCalculations(initializationVector, coefficientVector);

            for (int i = 0; i < keyStream.Length; i++)
                textBoxKeyStream.Text = string.Concat(textBoxKeyStream.Text, keyStream[i] ? "1" : "0");

            result = keyStream.Xor(message);
            stringResult = parseUtils.BitArrayToString(result);
            textBoxCipherText.Text = stringResult;
        }

        private void Decrypt_Click(object sender, EventArgs e)
        {
            if (textBoxCipherText == null || textBoxСoefficientVector == null || textBoxInitializationVector == null)
            {
                MessageBox.Show("Не введены исходные данные", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (stringSequence.Checked)
                CaseStringSequence();

            else if (bitSequence.Checked)
                CaseBitSequence();

            while (keyStream.Length != result.Length)
                BitCalculations(initializationVector, coefficientVector);

            for (int i = 0; i < keyStream.Length; i++)
                textBoxKeyStream.Text = string.Concat(textBoxKeyStream.Text, keyStream[i] ? "1" : "0");

            message = keyStream.Xor(result);
            stringResult = parseUtils.BitArrayToString(message);
            textBoxMessage.Text = stringResult;
        }

        private void CaseStringSequence()
        {
            message = parseUtils.TextBoxStringToBites(textBoxMessage);
            result = parseUtils.TextBoxStringToBites(textBoxCipherText);
            coefficientVector = parseUtils.TextBoxStringToBites(textBoxСoefficientVector);
            initializationVector = parseUtils.TextBoxStringToBites(textBoxInitializationVector);
            keyStream = parseUtils.TextBoxStringToBites(textBoxInitializationVector);
        }

        private void CaseBitSequence()
        {
            isText = false;
            message = parseUtils.CharSymbolToBoolSymbol(message, textBoxMessage);
            result = parseUtils.CharSymbolToBoolSymbol(result, textBoxCipherText);
            coefficientVector = parseUtils.CharSymbolToBoolSymbol(coefficientVector, textBoxСoefficientVector);
            initializationVector = parseUtils.CharSymbolToBoolSymbol(initializationVector, textBoxInitializationVector);
            keyStream = parseUtils.CharSymbolToBoolSymbol(keyStream, textBoxInitializationVector);
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
