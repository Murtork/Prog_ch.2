namespace Lab1_Bobrov
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
            this.label_first = new System.Windows.Forms.Label();
            this.SetDomino1 = new System.Windows.Forms.Button();
            this.SetDomino2 = new System.Windows.Forms.Button();
            this.BoxDomino1 = new System.Windows.Forms.TextBox();
            this.BoxDomino2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelResult = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_second = new System.Windows.Forms.Label();
            this.ButtonTest = new System.Windows.Forms.Button();
            this.LabelTurn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_first
            // 
            this.label_first.AutoSize = true;
            this.label_first.Location = new System.Drawing.Point(92, 31);
            this.label_first.Name = "label_first";
            this.label_first.Size = new System.Drawing.Size(28, 13);
            this.label_first.TabIndex = 0;
            this.label_first.Text = "( --- )";
            this.label_first.Click += new System.EventHandler(this.label1_Click);
            // 
            // SetDomino1
            // 
            this.SetDomino1.Location = new System.Drawing.Point(453, 97);
            this.SetDomino1.Name = "SetDomino1";
            this.SetDomino1.Size = new System.Drawing.Size(75, 23);
            this.SetDomino1.TabIndex = 1;
            this.SetDomino1.Text = "Домино1";
            this.SetDomino1.UseVisualStyleBackColor = true;
            this.SetDomino1.Click += new System.EventHandler(this.SetDomino1_Click);
            // 
            // SetDomino2
            // 
            this.SetDomino2.Location = new System.Drawing.Point(453, 135);
            this.SetDomino2.Name = "SetDomino2";
            this.SetDomino2.Size = new System.Drawing.Size(75, 23);
            this.SetDomino2.TabIndex = 2;
            this.SetDomino2.Text = "Домино2";
            this.SetDomino2.UseVisualStyleBackColor = true;
            this.SetDomino2.Click += new System.EventHandler(this.SetDomino2_Click);
            // 
            // BoxDomino1
            // 
            this.BoxDomino1.Location = new System.Drawing.Point(376, 42);
            this.BoxDomino1.Name = "BoxDomino1";
            this.BoxDomino1.Size = new System.Drawing.Size(25, 20);
            this.BoxDomino1.TabIndex = 3;
            // 
            // BoxDomino2
            // 
            this.BoxDomino2.Location = new System.Drawing.Point(436, 42);
            this.BoxDomino2.Name = "BoxDomino2";
            this.BoxDomino2.Size = new System.Drawing.Size(24, 20);
            this.BoxDomino2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ручная установка значений домино\r\n(от 1 до 6)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Установить значения для...:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Результат операции:";
            // 
            // LabelResult
            // 
            this.LabelResult.AutoSize = true;
            this.LabelResult.Location = new System.Drawing.Point(303, 203);
            this.LabelResult.Name = "LabelResult";
            this.LabelResult.Size = new System.Drawing.Size(25, 13);
            this.LabelResult.TabIndex = 8;
            this.LabelResult.Text = "___";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Значения:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "1 домино";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(177, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "2 домино";
            // 
            // label_second
            // 
            this.label_second.AutoSize = true;
            this.label_second.Location = new System.Drawing.Point(177, 31);
            this.label_second.Name = "label_second";
            this.label_second.Size = new System.Drawing.Size(28, 13);
            this.label_second.TabIndex = 11;
            this.label_second.Text = "( --- )";
            // 
            // ButtonTest
            // 
            this.ButtonTest.Location = new System.Drawing.Point(59, 135);
            this.ButtonTest.Name = "ButtonTest";
            this.ButtonTest.Size = new System.Drawing.Size(106, 23);
            this.ButtonTest.TabIndex = 13;
            this.ButtonTest.Text = "Проверить Ход";
            this.ButtonTest.UseVisualStyleBackColor = true;
            this.ButtonTest.Click += new System.EventHandler(this.ButtonTest_Click);
            // 
            // LabelTurn
            // 
            this.LabelTurn.AutoSize = true;
            this.LabelTurn.Location = new System.Drawing.Point(68, 173);
            this.LabelTurn.Name = "LabelTurn";
            this.LabelTurn.Size = new System.Drawing.Size(16, 13);
            this.LabelTurn.TabIndex = 14;
            this.LabelTurn.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 270);
            this.Controls.Add(this.LabelTurn);
            this.Controls.Add(this.ButtonTest);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label_second);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LabelResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BoxDomino2);
            this.Controls.Add(this.BoxDomino1);
            this.Controls.Add(this.SetDomino2);
            this.Controls.Add(this.SetDomino1);
            this.Controls.Add(this.label_first);
            this.Name = "Form1";
            this.Text = "Lab1 Bobrov";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_first;
        private System.Windows.Forms.Button SetDomino1;
        private System.Windows.Forms.Button SetDomino2;
        private System.Windows.Forms.TextBox BoxDomino1;
        private System.Windows.Forms.TextBox BoxDomino2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LabelResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_second;
        private System.Windows.Forms.Button ButtonTest;
        private System.Windows.Forms.Label LabelTurn;
    }
}

