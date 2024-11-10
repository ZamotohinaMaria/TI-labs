namespace Lab1_ZamotohinaMaria_6411
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.statisticShennon = new System.Windows.Forms.Label();
            this.buttonDecodeShennon = new System.Windows.Forms.Button();
            this.buttonCodeShennon = new System.Windows.Forms.Button();
            this.probabilitiesShennon = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxShennonCode = new System.Windows.Forms.TextBox();
            this.textBoxShennonFIO = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.statisticHaffman = new System.Windows.Forms.Label();
            this.buttonDecodeHaffman = new System.Windows.Forms.Button();
            this.buttonCodeHaffman = new System.Windows.Forms.Button();
            this.probabilitiesHaffman = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxHaffmanCode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxHaffmanFIO = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.statisticArithmetic = new System.Windows.Forms.Label();
            this.buttonDecodeArithmetic = new System.Windows.Forms.Button();
            this.buttonCodeArithmetic = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxArithmeticCode = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxArithmeticFIO = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Firebrick;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(549, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 34);
            this.label1.TabIndex = 5;
            this.label1.Text = "ФИО";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1177, 744);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.statisticShennon);
            this.tabPage1.Controls.Add(this.buttonDecodeShennon);
            this.tabPage1.Controls.Add(this.buttonCodeShennon);
            this.tabPage1.Controls.Add(this.probabilitiesShennon);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBoxShennonCode);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBoxShennonFIO);
            this.tabPage1.Location = new System.Drawing.Point(4, 35);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1169, 705);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Кодирование Шеннона-Фанно";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // statisticShennon
            // 
            this.statisticShennon.AutoSize = true;
            this.statisticShennon.Location = new System.Drawing.Point(467, 589);
            this.statisticShennon.Name = "statisticShennon";
            this.statisticShennon.Size = new System.Drawing.Size(411, 78);
            this.statisticShennon.TabIndex = 13;
            this.statisticShennon.Text = "Объем строки: X байт\r\nОбъем закодированной строки: X байт\r\nСжатие: X%";
            // 
            // buttonDecodeShennon
            // 
            this.buttonDecodeShennon.AutoSize = true;
            this.buttonDecodeShennon.BackColor = System.Drawing.Color.Brown;
            this.buttonDecodeShennon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDecodeShennon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDecodeShennon.Location = new System.Drawing.Point(852, 380);
            this.buttonDecodeShennon.Name = "buttonDecodeShennon";
            this.buttonDecodeShennon.Size = new System.Drawing.Size(229, 56);
            this.buttonDecodeShennon.TabIndex = 12;
            this.buttonDecodeShennon.Text = "Декодировать";
            this.buttonDecodeShennon.UseVisualStyleBackColor = false;
            this.buttonDecodeShennon.Click += new System.EventHandler(this.btn_DecodingShennonFanno);
            // 
            // buttonCodeShennon
            // 
            this.buttonCodeShennon.AutoSize = true;
            this.buttonCodeShennon.BackColor = System.Drawing.Color.Brown;
            this.buttonCodeShennon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCodeShennon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCodeShennon.Location = new System.Drawing.Point(852, 287);
            this.buttonCodeShennon.Name = "buttonCodeShennon";
            this.buttonCodeShennon.Size = new System.Drawing.Size(229, 56);
            this.buttonCodeShennon.TabIndex = 11;
            this.buttonCodeShennon.Text = "Закодировать";
            this.buttonCodeShennon.UseVisualStyleBackColor = false;
            this.buttonCodeShennon.Click += new System.EventHandler(this.btn_CodingShennonFanno);
            // 
            // probabilitiesShennon
            // 
            this.probabilitiesShennon.AcceptsTab = true;
            this.probabilitiesShennon.BackColor = System.Drawing.Color.Linen;
            this.probabilitiesShennon.Location = new System.Drawing.Point(76, 342);
            this.probabilitiesShennon.Name = "probabilitiesShennon";
            this.probabilitiesShennon.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.probabilitiesShennon.Size = new System.Drawing.Size(323, 325);
            this.probabilitiesShennon.TabIndex = 10;
            this.probabilitiesShennon.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Brown;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(79, 287);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(320, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "Порядок Вероятностей";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Firebrick;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(549, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 34);
            this.label2.TabIndex = 7;
            this.label2.Text = "Код";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxShennonCode
            // 
            this.textBoxShennonCode.BackColor = System.Drawing.Color.Linen;
            this.textBoxShennonCode.Location = new System.Drawing.Point(58, 170);
            this.textBoxShennonCode.Multiline = true;
            this.textBoxShennonCode.Name = "textBoxShennonCode";
            this.textBoxShennonCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxShennonCode.Size = new System.Drawing.Size(1048, 89);
            this.textBoxShennonCode.TabIndex = 6;
            this.textBoxShennonCode.Text = "-";
            this.textBoxShennonCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxShennonFIO
            // 
            this.textBoxShennonFIO.BackColor = System.Drawing.Color.Linen;
            this.textBoxShennonFIO.Location = new System.Drawing.Point(287, 76);
            this.textBoxShennonFIO.Name = "textBoxShennonFIO";
            this.textBoxShennonFIO.Size = new System.Drawing.Size(577, 32);
            this.textBoxShennonFIO.TabIndex = 4;
            this.textBoxShennonFIO.Text = "Замотохина Мария Андреевна";
            this.textBoxShennonFIO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.statisticHaffman);
            this.tabPage2.Controls.Add(this.buttonDecodeHaffman);
            this.tabPage2.Controls.Add(this.buttonCodeHaffman);
            this.tabPage2.Controls.Add(this.probabilitiesHaffman);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.textBoxHaffmanCode);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.textBoxHaffmanFIO);
            this.tabPage2.Location = new System.Drawing.Point(4, 35);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1169, 705);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Кодирование по Хаффману";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // statisticHaffman
            // 
            this.statisticHaffman.AutoSize = true;
            this.statisticHaffman.Location = new System.Drawing.Point(467, 591);
            this.statisticHaffman.Name = "statisticHaffman";
            this.statisticHaffman.Size = new System.Drawing.Size(411, 78);
            this.statisticHaffman.TabIndex = 22;
            this.statisticHaffman.Text = "Объем строки: Х байт\r\nОбъем закодированной строки: Х байт\r\nСжатие: X%";
            // 
            // buttonDecodeHaffman
            // 
            this.buttonDecodeHaffman.AutoSize = true;
            this.buttonDecodeHaffman.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonDecodeHaffman.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDecodeHaffman.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDecodeHaffman.Location = new System.Drawing.Point(852, 382);
            this.buttonDecodeHaffman.Name = "buttonDecodeHaffman";
            this.buttonDecodeHaffman.Size = new System.Drawing.Size(229, 56);
            this.buttonDecodeHaffman.TabIndex = 21;
            this.buttonDecodeHaffman.Text = "Декодировать";
            this.buttonDecodeHaffman.UseVisualStyleBackColor = false;
            this.buttonDecodeHaffman.Click += new System.EventHandler(this.btn_DecodingHaffman);
            // 
            // buttonCodeHaffman
            // 
            this.buttonCodeHaffman.AutoSize = true;
            this.buttonCodeHaffman.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonCodeHaffman.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCodeHaffman.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCodeHaffman.Location = new System.Drawing.Point(852, 289);
            this.buttonCodeHaffman.Name = "buttonCodeHaffman";
            this.buttonCodeHaffman.Size = new System.Drawing.Size(229, 56);
            this.buttonCodeHaffman.TabIndex = 20;
            this.buttonCodeHaffman.Text = "Закодировать";
            this.buttonCodeHaffman.UseVisualStyleBackColor = false;
            this.buttonCodeHaffman.Click += new System.EventHandler(this.btn_CodingHaffman);
            // 
            // probabilitiesHaffman
            // 
            this.probabilitiesHaffman.AcceptsTab = true;
            this.probabilitiesHaffman.BackColor = System.Drawing.Color.Linen;
            this.probabilitiesHaffman.Location = new System.Drawing.Point(76, 344);
            this.probabilitiesHaffman.Name = "probabilitiesHaffman";
            this.probabilitiesHaffman.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.probabilitiesHaffman.Size = new System.Drawing.Size(323, 325);
            this.probabilitiesHaffman.TabIndex = 19;
            this.probabilitiesHaffman.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkGreen;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(79, 289);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(320, 32);
            this.label6.TabIndex = 18;
            this.label6.Text = "Порядок Вероятностей";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkGreen;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(549, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 34);
            this.label7.TabIndex = 17;
            this.label7.Text = "Код";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxHaffmanCode
            // 
            this.textBoxHaffmanCode.BackColor = System.Drawing.Color.Linen;
            this.textBoxHaffmanCode.Location = new System.Drawing.Point(60, 165);
            this.textBoxHaffmanCode.Multiline = true;
            this.textBoxHaffmanCode.Name = "textBoxHaffmanCode";
            this.textBoxHaffmanCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxHaffmanCode.Size = new System.Drawing.Size(1048, 82);
            this.textBoxHaffmanCode.TabIndex = 16;
            this.textBoxHaffmanCode.Text = "-";
            this.textBoxHaffmanCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkGreen;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(549, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 34);
            this.label8.TabIndex = 15;
            this.label8.Text = "ФИО";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxHaffmanFIO
            // 
            this.textBoxHaffmanFIO.BackColor = System.Drawing.Color.Linen;
            this.textBoxHaffmanFIO.Location = new System.Drawing.Point(287, 78);
            this.textBoxHaffmanFIO.Name = "textBoxHaffmanFIO";
            this.textBoxHaffmanFIO.Size = new System.Drawing.Size(577, 32);
            this.textBoxHaffmanFIO.TabIndex = 14;
            this.textBoxHaffmanFIO.Text = "Замотохина Мария Андреевна";
            this.textBoxHaffmanFIO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.statisticArithmetic);
            this.tabPage3.Controls.Add(this.buttonDecodeArithmetic);
            this.tabPage3.Controls.Add(this.buttonCodeArithmetic);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.textBoxArithmeticCode);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.textBoxArithmeticFIO);
            this.tabPage3.Location = new System.Drawing.Point(4, 35);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1169, 705);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Арифметическое кодирование";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // statisticArithmetic
            // 
            this.statisticArithmetic.AutoSize = true;
            this.statisticArithmetic.Location = new System.Drawing.Point(52, 454);
            this.statisticArithmetic.Name = "statisticArithmetic";
            this.statisticArithmetic.Size = new System.Drawing.Size(411, 78);
            this.statisticArithmetic.TabIndex = 22;
            this.statisticArithmetic.Text = "Объем строки: X байт\r\nОбъем закодированной строки: X байт\r\nСжатие: X%";
            // 
            // buttonDecodeArithmetic
            // 
            this.buttonDecodeArithmetic.AutoSize = true;
            this.buttonDecodeArithmetic.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonDecodeArithmetic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDecodeArithmetic.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonDecodeArithmetic.Location = new System.Drawing.Point(851, 379);
            this.buttonDecodeArithmetic.Name = "buttonDecodeArithmetic";
            this.buttonDecodeArithmetic.Size = new System.Drawing.Size(229, 56);
            this.buttonDecodeArithmetic.TabIndex = 21;
            this.buttonDecodeArithmetic.Text = "Декодировать";
            this.buttonDecodeArithmetic.UseVisualStyleBackColor = false;
            this.buttonDecodeArithmetic.Click += new System.EventHandler(this.btn_DecodeArithmetic);
            // 
            // buttonCodeArithmetic
            // 
            this.buttonCodeArithmetic.AutoSize = true;
            this.buttonCodeArithmetic.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonCodeArithmetic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCodeArithmetic.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonCodeArithmetic.Location = new System.Drawing.Point(851, 286);
            this.buttonCodeArithmetic.Name = "buttonCodeArithmetic";
            this.buttonCodeArithmetic.Size = new System.Drawing.Size(229, 56);
            this.buttonCodeArithmetic.TabIndex = 20;
            this.buttonCodeArithmetic.Text = "Закодировать";
            this.buttonCodeArithmetic.UseVisualStyleBackColor = false;
            this.buttonCodeArithmetic.Click += new System.EventHandler(this.btn_CodeArithmetic);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(548, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 34);
            this.label9.TabIndex = 17;
            this.label9.Text = "Код";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxArithmeticCode
            // 
            this.textBoxArithmeticCode.BackColor = System.Drawing.Color.Linen;
            this.textBoxArithmeticCode.Location = new System.Drawing.Point(57, 169);
            this.textBoxArithmeticCode.Multiline = true;
            this.textBoxArithmeticCode.Name = "textBoxArithmeticCode";
            this.textBoxArithmeticCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxArithmeticCode.Size = new System.Drawing.Size(1048, 89);
            this.textBoxArithmeticCode.TabIndex = 16;
            this.textBoxArithmeticCode.Text = "-";
            this.textBoxArithmeticCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(548, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 34);
            this.label10.TabIndex = 15;
            this.label10.Text = "ФИО";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxArithmeticFIO
            // 
            this.textBoxArithmeticFIO.BackColor = System.Drawing.Color.Linen;
            this.textBoxArithmeticFIO.Location = new System.Drawing.Point(286, 75);
            this.textBoxArithmeticFIO.Name = "textBoxArithmeticFIO";
            this.textBoxArithmeticFIO.Size = new System.Drawing.Size(577, 32);
            this.textBoxArithmeticFIO.TabIndex = 14;
            this.textBoxArithmeticFIO.Text = "Замотохина Мария Андреевна";
            this.textBoxArithmeticFIO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 744);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxShennonCode;
        private System.Windows.Forms.TextBox textBoxShennonFIO;
        private System.Windows.Forms.Button buttonCodeShennon;
        private System.Windows.Forms.Button buttonDecodeShennon;
        private System.Windows.Forms.Label statisticShennon;
        private System.Windows.Forms.Label statisticHaffman;
        private System.Windows.Forms.Button buttonDecodeHaffman;
        private System.Windows.Forms.Button buttonCodeHaffman;
        private System.Windows.Forms.RichTextBox probabilitiesHaffman;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxHaffmanCode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxHaffmanFIO;
        private System.Windows.Forms.RichTextBox probabilitiesShennon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label statisticArithmetic;
        private System.Windows.Forms.Button buttonDecodeArithmetic;
        private System.Windows.Forms.Button buttonCodeArithmetic;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxArithmeticCode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxArithmeticFIO;
    }
}

