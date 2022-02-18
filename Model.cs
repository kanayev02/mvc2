using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace mvc
{
    class Model
    {
        static float a = 0;
        static float b = 0;
        static float rezultat = 0;
        public static List<string> DataList = new List<string> { "Умножение", "Сложение", "Деление", "Вычитание" };
        static int index = 0;

        public static TextBlock Ravno;

        public static float PervoeChislo
        {
            set
            {
                a = value;
            }
        }
        public static float VtoroeChislo
        {
            set
            {
                b = value;
            }
        }
        public static int ComboIndex
        {
            set
            {
                index = value;
            }
        }
        public static string Rezultat
        {
            get
            {
                switch (index)
                {
                    case 0:
                        rezultat = a * b;
                        return Ravno.Text = rezultat.ToString();
                    case 1:
                        rezultat = a + b;
                        return Ravno.Text = rezultat.ToString();
                    case 2:
                        rezultat = a / b;
                        return Ravno.Text = rezultat.ToString();
                    case 3:
                        rezultat = a - b;
                        return Ravno.Text = rezultat.ToString();
                    default:
                        return "ошибка";
                }
            }
        }
    }
}

