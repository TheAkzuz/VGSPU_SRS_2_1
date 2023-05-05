using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRS_1_trinagle
{
    public partial class Form1 : Form
    {
        // Объявляю переменные, которые отвечают за стороны треугольника и итог
        double a = 0;
        double b = 0;
        double c = 0;
        string itog = "";
        public Form1()
        {
 
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // А принимает значение, которое мы вели с текст бокса, которое мв конвертировали
            // с стринг на дабле
            //И так по аналогии б и с
            a = Convert.ToDouble (textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            b = Convert.ToDouble(textBox2.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            c = Convert.ToDouble(textBox3.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Проверяем, существует ли треугольник
            if (a+b>c && a+c>b && c+b>a)
            {
                //Если он есть, то к итогу пишем, что он есть.
                // И находим площадь и периметр, но пока не заносим их в итог
                itog = "треугольник существует\n";
                double p = a + b + c;
                double pp = p/2;
                double s = Math.Sqrt(pp * (pp - a) * (pp - b) * (pp - c));
                //если флаг включен на первом чек боесе, то в итог заносим периметр
                //также и площадь
                if (checkBox1.Checked == true)
                {
                    
                    itog = itog + "Периметр = " + Convert.ToString (p) + "\n";

                }

                if (checkBox2.Checked == true) 
                {
                    itog = itog + "Площадь = " + Convert.ToString(s) + "\n"; ;                
                }


            }
            //если нет, то итог в итог пишем то, что снизу
            else
            {
                itog = "Треугольник не сущетсвует\nдальнейшие вычисление\n не возможны";
            }
            // после всего, что мы сделали выше, мы выводим в лейбел 6 наш итог
            label6.Text = itog;
        }
    }
}
