
namespace oneGUI
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
            this.txtMaxNum = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.outMaxNum = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дано трехзначное число.Не прибегая к исполь-\r\nзованию строк вывести наибольшую из" +
    " его цифр. ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите трехзначное число:";
            // 
            // txtMaxNum
            // 
            this.txtMaxNum.Location = new System.Drawing.Point(209, 41);
            this.txtMaxNum.Name = "txtMaxNum";
            this.txtMaxNum.Size = new System.Drawing.Size(144, 22);
            this.txtMaxNum.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(342, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Найти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // outMaxNum
            // 
            this.outMaxNum.AutoSize = true;
            this.outMaxNum.Location = new System.Drawing.Point(12, 78);
            this.outMaxNum.Name = "outMaxNum";
            this.outMaxNum.Size = new System.Drawing.Size(58, 17);
            this.outMaxNum.TabIndex = 4;
            this.outMaxNum.Text = "Вывод: \r\n";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(267, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 29);
            this.button2.TabIndex = 5;
            this.button2.Text = "Очистить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 159);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.outMaxNum);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtMaxNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "MaxNumber";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaxNum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label outMaxNum;
        private System.Windows.Forms.Button button2;
    }
}

