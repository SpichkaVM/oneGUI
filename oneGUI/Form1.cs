using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oneGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.button1.Click += new System.EventHandler(this.button1_Click);
            txtMaxNum.Text = Properties.Settings.Default.a.ToString();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) button1.PerformClick();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            try
            {
                outMaxNum.Text = "Вывод: \n";
                a = int.Parse(this.txtMaxNum.Text);
                var outmessege = Logic.Max(a);
                outMaxNum.Text += outmessege;
                Properties.Settings.Default.a = a;
            }
            catch(FormatException) {
                outMaxNum.Text = "Вывод: \nВведит трехзначное число! ";
            }
            
            Properties.Settings.Default.Save();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                txtMaxNum.Clear();
            
        }

    }
    public class Logic
    {
        public static string Max(int a)
        {
            a = Math.Abs(a);
            int max = 0;
            int b = 0;
            int q = a % 10, g = (a / 10) % 10;

            string outmessege = "";
            string str = "";

            if ((a > 99) && (a < 1000))//проверка на ввод
            {
                while (a != 0) //цикл пока наше число не равно нулю
                {
                    b = a % 10;//Работам с последней цифрой
                    if (b > max)//Условие для проверки максимального числа
                    {
                        max = b;
                    }
                    a = a / 10;//Убираем последнюю цифру
                }
                if ((q == g) && (g == b))//проверка если числа равны
                {
                    outmessege = "Максимального числа нет, числа равны";
                }
                else
                {
                    outmessege = "Максимальное число: ";
                    str = max.ToString();//Переводим наше максимальное число в тип string для возвращения из функции;
                }
            }
            else
            {
                outmessege = "Введите трехзначное число! ";
            }
            return (outmessege + str);
        }
    }
}
