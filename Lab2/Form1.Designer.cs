namespace Lab2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_XOR = new System.Windows.Forms.Button();
            this.button_clean = new System.Windows.Forms.Button();
            this.textBox_P = new System.Windows.Forms.TextBox();
            this.textBox_Key = new System.Windows.Forms.TextBox();
            this.textBox_C = new System.Windows.Forms.TextBox();
            this.label_S1 = new System.Windows.Forms.Label();
            this.label_S2 = new System.Windows.Forms.Label();
            this.label_S3 = new System.Windows.Forms.Label();
            this.label_S11 = new System.Windows.Forms.Label();
            this.label_S22 = new System.Windows.Forms.Label();
            this.label_S33 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_S333 = new System.Windows.Forms.Label();
            this.label_S222 = new System.Windows.Forms.Label();
            this.label_S111 = new System.Windows.Forms.Label();
            this.textBox_CC = new System.Windows.Forms.TextBox();
            this.textBox_KK = new System.Windows.Forms.TextBox();
            this.textBox_PP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "P=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Key=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "C=";
            // 
            // button_XOR
            // 
            this.button_XOR.Location = new System.Drawing.Point(312, 353);
            this.button_XOR.Name = "button_XOR";
            this.button_XOR.Size = new System.Drawing.Size(75, 23);
            this.button_XOR.TabIndex = 3;
            this.button_XOR.Text = "XOR";
            this.button_XOR.UseVisualStyleBackColor = true;
            this.button_XOR.Click += new System.EventHandler(this.Button_XOR_Click);
            // 
            // button_clean
            // 
            this.button_clean.Location = new System.Drawing.Point(174, 353);
            this.button_clean.Name = "button_clean";
            this.button_clean.Size = new System.Drawing.Size(84, 23);
            this.button_clean.TabIndex = 4;
            this.button_clean.Text = "Прибрати";
            this.button_clean.UseVisualStyleBackColor = true;
            this.button_clean.Click += new System.EventHandler(this.Button_clean_Click);
            // 
            // textBox_P
            // 
            this.textBox_P.Location = new System.Drawing.Point(110, 57);
            this.textBox_P.Name = "textBox_P";
            this.textBox_P.Size = new System.Drawing.Size(100, 22);
            this.textBox_P.TabIndex = 5;
            // 
            // textBox_Key
            // 
            this.textBox_Key.Location = new System.Drawing.Point(110, 97);
            this.textBox_Key.Name = "textBox_Key";
            this.textBox_Key.Size = new System.Drawing.Size(100, 22);
            this.textBox_Key.TabIndex = 6;
            // 
            // textBox_C
            // 
            this.textBox_C.Location = new System.Drawing.Point(110, 143);
            this.textBox_C.Name = "textBox_C";
            this.textBox_C.Size = new System.Drawing.Size(100, 22);
            this.textBox_C.TabIndex = 7;
            // 
            // label_S1
            // 
            this.label_S1.AutoSize = true;
            this.label_S1.Location = new System.Drawing.Point(378, 60);
            this.label_S1.Name = "label_S1";
            this.label_S1.Size = new System.Drawing.Size(21, 16);
            this.label_S1.TabIndex = 8;
            this.label_S1.Text = "16";
            // 
            // label_S2
            // 
            this.label_S2.AutoSize = true;
            this.label_S2.Location = new System.Drawing.Point(378, 97);
            this.label_S2.Name = "label_S2";
            this.label_S2.Size = new System.Drawing.Size(21, 16);
            this.label_S2.TabIndex = 9;
            this.label_S2.Text = "16";
            // 
            // label_S3
            // 
            this.label_S3.AutoSize = true;
            this.label_S3.Location = new System.Drawing.Point(378, 143);
            this.label_S3.Name = "label_S3";
            this.label_S3.Size = new System.Drawing.Size(21, 16);
            this.label_S3.TabIndex = 10;
            this.label_S3.Text = "16";
            // 
            // label_S11
            // 
            this.label_S11.AutoSize = true;
            this.label_S11.Location = new System.Drawing.Point(309, 60);
            this.label_S11.Name = "label_S11";
            this.label_S11.Size = new System.Drawing.Size(21, 16);
            this.label_S11.TabIndex = 11;
            this.label_S11.Text = "10";
            // 
            // label_S22
            // 
            this.label_S22.AutoSize = true;
            this.label_S22.Location = new System.Drawing.Point(309, 97);
            this.label_S22.Name = "label_S22";
            this.label_S22.Size = new System.Drawing.Size(21, 16);
            this.label_S22.TabIndex = 12;
            this.label_S22.Text = "10";
            // 
            // label_S33
            // 
            this.label_S33.AutoSize = true;
            this.label_S33.Location = new System.Drawing.Point(309, 143);
            this.label_S33.Name = "label_S33";
            this.label_S33.Size = new System.Drawing.Size(21, 16);
            this.label_S33.TabIndex = 13;
            this.label_S33.Text = "10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(309, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "10";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(378, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "16";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(250, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "2";
            // 
            // label_S333
            // 
            this.label_S333.AutoSize = true;
            this.label_S333.Location = new System.Drawing.Point(250, 143);
            this.label_S333.Name = "label_S333";
            this.label_S333.Size = new System.Drawing.Size(14, 16);
            this.label_S333.TabIndex = 19;
            this.label_S333.Text = "2";
            // 
            // label_S222
            // 
            this.label_S222.AutoSize = true;
            this.label_S222.Location = new System.Drawing.Point(250, 97);
            this.label_S222.Name = "label_S222";
            this.label_S222.Size = new System.Drawing.Size(14, 16);
            this.label_S222.TabIndex = 18;
            this.label_S222.Text = "2";
            // 
            // label_S111
            // 
            this.label_S111.AutoSize = true;
            this.label_S111.Location = new System.Drawing.Point(250, 60);
            this.label_S111.Name = "label_S111";
            this.label_S111.Size = new System.Drawing.Size(14, 16);
            this.label_S111.TabIndex = 17;
            this.label_S111.Text = "2";
            // 
            // textBox_CC
            // 
            this.textBox_CC.Location = new System.Drawing.Point(436, 54);
            this.textBox_CC.Name = "textBox_CC";
            this.textBox_CC.Size = new System.Drawing.Size(100, 22);
            this.textBox_CC.TabIndex = 25;
            // 
            // textBox_KK
            // 
            this.textBox_KK.Location = new System.Drawing.Point(436, 94);
            this.textBox_KK.Name = "textBox_KK";
            this.textBox_KK.Size = new System.Drawing.Size(100, 22);
            this.textBox_KK.TabIndex = 24;
            // 
            // textBox_PP
            // 
            this.textBox_PP.Location = new System.Drawing.Point(436, 143);
            this.textBox_PP.Name = "textBox_PP";
            this.textBox_PP.Size = new System.Drawing.Size(100, 22);
            this.textBox_PP.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(565, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "=C";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(565, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "=Key";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(565, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "=P";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 424);
            this.Controls.Add(this.textBox_CC);
            this.Controls.Add(this.textBox_KK);
            this.Controls.Add(this.textBox_PP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label_S333);
            this.Controls.Add(this.label_S222);
            this.Controls.Add(this.label_S111);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_S33);
            this.Controls.Add(this.label_S22);
            this.Controls.Add(this.label_S11);
            this.Controls.Add(this.label_S3);
            this.Controls.Add(this.label_S2);
            this.Controls.Add(this.label_S1);
            this.Controls.Add(this.textBox_C);
            this.Controls.Add(this.textBox_Key);
            this.Controls.Add(this.textBox_P);
            this.Controls.Add(this.button_clean);
            this.Controls.Add(this.button_XOR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_XOR;
        private System.Windows.Forms.Button button_clean;
        private System.Windows.Forms.TextBox textBox_P;
        private System.Windows.Forms.TextBox textBox_Key;
        private System.Windows.Forms.TextBox textBox_C;
        private System.Windows.Forms.Label label_S1;
        private System.Windows.Forms.Label label_S2;
        private System.Windows.Forms.Label label_S3;
        private System.Windows.Forms.Label label_S11;
        private System.Windows.Forms.Label label_S22;
        private System.Windows.Forms.Label label_S33;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_S333;
        private System.Windows.Forms.Label label_S222;
        private System.Windows.Forms.Label label_S111;
        private System.Windows.Forms.TextBox textBox_CC;
        private System.Windows.Forms.TextBox textBox_KK;
        private System.Windows.Forms.TextBox textBox_PP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

