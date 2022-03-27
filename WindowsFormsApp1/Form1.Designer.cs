namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Encrypt = new System.Windows.Forms.Button();
            this.Decrypt = new System.Windows.Forms.Button();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.textBoxСoefficientVector = new System.Windows.Forms.TextBox();
            this.textBoxInitializationVector = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxKeyStream = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCipherText = new System.Windows.Forms.TextBox();
            this.Clear = new System.Windows.Forms.Button();
            this.stringSequence = new System.Windows.Forms.RadioButton();
            this.bitSequence = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // Encrypt
            // 
            this.Encrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Encrypt.Location = new System.Drawing.Point(284, 120);
            this.Encrypt.Name = "Encrypt";
            this.Encrypt.Size = new System.Drawing.Size(144, 31);
            this.Encrypt.TabIndex = 1;
            this.Encrypt.Text = "Зашифровать";
            this.Encrypt.UseVisualStyleBackColor = true;
            this.Encrypt.Click += new System.EventHandler(this.Encrypt_Click);
            // 
            // Decrypt
            // 
            this.Decrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Decrypt.Location = new System.Drawing.Point(284, 168);
            this.Decrypt.Name = "Decrypt";
            this.Decrypt.Size = new System.Drawing.Size(144, 31);
            this.Decrypt.TabIndex = 2;
            this.Decrypt.Text = "Расшифровать";
            this.Decrypt.UseVisualStyleBackColor = true;
            this.Decrypt.Click += new System.EventHandler(this.Decrypt_Click);
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMessage.Location = new System.Drawing.Point(12, 28);
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(201, 26);
            this.textBoxMessage.TabIndex = 5;
            // 
            // textBoxСoefficientVector
            // 
            this.textBoxСoefficientVector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxСoefficientVector.Location = new System.Drawing.Point(12, 80);
            this.textBoxСoefficientVector.Name = "textBoxСoefficientVector";
            this.textBoxСoefficientVector.Size = new System.Drawing.Size(201, 26);
            this.textBoxСoefficientVector.TabIndex = 6;
            // 
            // textBoxInitializationVector
            // 
            this.textBoxInitializationVector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInitializationVector.Location = new System.Drawing.Point(12, 133);
            this.textBoxInitializationVector.Name = "textBoxInitializationVector";
            this.textBoxInitializationVector.Size = new System.Drawing.Size(201, 26);
            this.textBoxInitializationVector.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Исходное сообщение";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Вектор коэффициентов";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(9, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Вектор инициализации";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(9, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ключевой поток";
            // 
            // textBoxKeyStream
            // 
            this.textBoxKeyStream.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxKeyStream.Location = new System.Drawing.Point(12, 184);
            this.textBoxKeyStream.Name = "textBoxKeyStream";
            this.textBoxKeyStream.Size = new System.Drawing.Size(201, 26);
            this.textBoxKeyStream.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(9, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Шифротекст";
            // 
            // textBoxCipherText
            // 
            this.textBoxCipherText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCipherText.Location = new System.Drawing.Point(12, 236);
            this.textBoxCipherText.Name = "textBoxCipherText";
            this.textBoxCipherText.Size = new System.Drawing.Size(201, 26);
            this.textBoxCipherText.TabIndex = 13;
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clear.Location = new System.Drawing.Point(284, 222);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(144, 31);
            this.Clear.TabIndex = 15;
            this.Clear.Text = "Очистка";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // stringSequence
            // 
            this.stringSequence.AutoSize = true;
            this.stringSequence.Checked = true;
            this.stringSequence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stringSequence.Location = new System.Drawing.Point(238, 52);
            this.stringSequence.Name = "stringSequence";
            this.stringSequence.Size = new System.Drawing.Size(277, 24);
            this.stringSequence.TabIndex = 16;
            this.stringSequence.TabStop = true;
            this.stringSequence.Text = "Строковая последовательность";
            this.stringSequence.UseVisualStyleBackColor = true;
            // 
            // bitSequence
            // 
            this.bitSequence.AutoSize = true;
            this.bitSequence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bitSequence.Location = new System.Drawing.Point(238, 75);
            this.bitSequence.Name = "bitSequence";
            this.bitSequence.Size = new System.Drawing.Size(260, 24);
            this.bitSequence.TabIndex = 17;
            this.bitSequence.TabStop = true;
            this.bitSequence.Text = "Битовая последовательность";
            this.bitSequence.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 293);
            this.Controls.Add(this.bitSequence);
            this.Controls.Add(this.stringSequence);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxCipherText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxKeyStream);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxInitializationVector);
            this.Controls.Add(this.textBoxСoefficientVector);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.Decrypt);
            this.Controls.Add(this.Encrypt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Encrypt;
        private System.Windows.Forms.Button Decrypt;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.TextBox textBoxСoefficientVector;
        private System.Windows.Forms.TextBox textBoxInitializationVector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxKeyStream;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCipherText;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.RadioButton stringSequence;
        private System.Windows.Forms.RadioButton bitSequence;
    }
}

