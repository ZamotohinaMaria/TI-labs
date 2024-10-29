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
            System.Windows.Forms.Label label1;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.shennonStatistic = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.probabilitiesShennon = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_ShennonCode = new System.Windows.Forms.TextBox();
            this.textBox_ShennonFIO = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.haffmanStatistic = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.probabilitiesHaffman = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_HaffmanCode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_HaffmanFIO = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Firebrick;
            label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label1.Enabled = false;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            label1.Location = new System.Drawing.Point(528, 28);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(82, 34);
            label1.TabIndex = 5;
            label1.Text = "ФИО";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.tabPage1.Controls.Add(this.shennonStatistic);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.probabilitiesShennon);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBox_ShennonCode);
            this.tabPage1.Controls.Add(label1);
            this.tabPage1.Controls.Add(this.textBox_ShennonFIO);
            this.tabPage1.Location = new System.Drawing.Point(4, 35);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1169, 705);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Кодирование Шеннона-Фанно";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // shennonStatistic
            // 
            this.shennonStatistic.AutoSize = true;
            this.shennonStatistic.Location = new System.Drawing.Point(446, 584);
            this.shennonStatistic.Name = "shennonStatistic";
            this.shennonStatistic.Size = new System.Drawing.Size(411, 78);
            this.shennonStatistic.TabIndex = 13;
            this.shennonStatistic.Text = "Объем строки: X байт\r\nОбъем закодированной строки: X байт\r\nСжатие: X%";
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.Brown;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(831, 375);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(229, 56);
            this.button2.TabIndex = 12;
            this.button2.Text = "Декодировать";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btn_DecodingShennonFanno);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Brown;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(831, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 56);
            this.button1.TabIndex = 11;
            this.button1.Text = "Закодировать";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btn_CodingShennonFanno);
            // 
            // probabilitiesShennon
            // 
            this.probabilitiesShennon.AcceptsTab = true;
            this.probabilitiesShennon.BackColor = System.Drawing.Color.Linen;
            this.probabilitiesShennon.Location = new System.Drawing.Point(55, 337);
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
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(58, 282);
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
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(528, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 34);
            this.label2.TabIndex = 7;
            this.label2.Text = "Код";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_ShennonCode
            // 
            this.textBox_ShennonCode.BackColor = System.Drawing.Color.Linen;
            this.textBox_ShennonCode.Location = new System.Drawing.Point(37, 165);
            this.textBox_ShennonCode.Multiline = true;
            this.textBox_ShennonCode.Name = "textBox_ShennonCode";
            this.textBox_ShennonCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_ShennonCode.Size = new System.Drawing.Size(1048, 89);
            this.textBox_ShennonCode.TabIndex = 6;
            this.textBox_ShennonCode.Text = "-";
            this.textBox_ShennonCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_ShennonFIO
            // 
            this.textBox_ShennonFIO.BackColor = System.Drawing.Color.Linen;
            this.textBox_ShennonFIO.Location = new System.Drawing.Point(266, 71);
            this.textBox_ShennonFIO.Name = "textBox_ShennonFIO";
            this.textBox_ShennonFIO.Size = new System.Drawing.Size(577, 32);
            this.textBox_ShennonFIO.TabIndex = 4;
            this.textBox_ShennonFIO.Text = "Замотохина Мария Андреевна";
            this.textBox_ShennonFIO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.haffmanStatistic);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.probabilitiesHaffman);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.textBox_HaffmanCode);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.textBox_HaffmanFIO);
            this.tabPage2.Location = new System.Drawing.Point(4, 35);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1169, 705);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Кодирование по Хаффману";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // haffmanStatistic
            // 
            this.haffmanStatistic.AutoSize = true;
            this.haffmanStatistic.Location = new System.Drawing.Point(467, 591);
            this.haffmanStatistic.Name = "haffmanStatistic";
            this.haffmanStatistic.Size = new System.Drawing.Size(411, 78);
            this.haffmanStatistic.TabIndex = 22;
            this.haffmanStatistic.Text = "Объем строки: Х байт\r\nОбъем закодированной строки: Х байт\r\nСжатие: X%";
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.BackColor = System.Drawing.Color.DarkGreen;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(852, 382);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(229, 56);
            this.button3.TabIndex = 21;
            this.button3.Text = "Декодировать";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btn_DecodingHaffman);
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.BackColor = System.Drawing.Color.DarkGreen;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(852, 289);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(229, 56);
            this.button4.TabIndex = 20;
            this.button4.Text = "Закодировать";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.btn_CodingHaffman);
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
            // textBox_HaffmanCode
            // 
            this.textBox_HaffmanCode.BackColor = System.Drawing.Color.Linen;
            this.textBox_HaffmanCode.Location = new System.Drawing.Point(60, 165);
            this.textBox_HaffmanCode.Multiline = true;
            this.textBox_HaffmanCode.Name = "textBox_HaffmanCode";
            this.textBox_HaffmanCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_HaffmanCode.Size = new System.Drawing.Size(1048, 82);
            this.textBox_HaffmanCode.TabIndex = 16;
            this.textBox_HaffmanCode.Text = "-";
            this.textBox_HaffmanCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // textBox_HaffmanFIO
            // 
            this.textBox_HaffmanFIO.BackColor = System.Drawing.Color.Linen;
            this.textBox_HaffmanFIO.Location = new System.Drawing.Point(287, 78);
            this.textBox_HaffmanFIO.Name = "textBox_HaffmanFIO";
            this.textBox_HaffmanFIO.Size = new System.Drawing.Size(577, 32);
            this.textBox_HaffmanFIO.TabIndex = 14;
            this.textBox_HaffmanFIO.Text = "Замотохина Мария Андреевна";
            this.textBox_HaffmanFIO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 35);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1169, 705);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Арифметическое кодирование";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_ShennonCode;
        private System.Windows.Forms.TextBox textBox_ShennonFIO;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label shennonStatistic;
        private System.Windows.Forms.Label haffmanStatistic;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RichTextBox probabilitiesHaffman;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_HaffmanCode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_HaffmanFIO;
        private System.Windows.Forms.RichTextBox probabilitiesShennon;
    }
}

