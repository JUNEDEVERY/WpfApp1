using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    public static class Model
    {

        public static string tbFirst;
        public static string tbSecond;

        public static List<string> cmbOperation = new List<string>() { "Сложение", "Умножение", "Деление", "Вычитание" };
        public static List<string> tbSign = new List<string>() { "+", "*", "/", "-" };


        public static TextBlock tbSignText = new TextBlock();
        public static TextBlock tbResult = new TextBlock();


        public static int tbSignOperation
        {
            set => tbSignText.Text = tbSign[value];



        }
        public static int tbOperationResult
        {
            set
            {
                try
                {
                    double firstVariable = Convert.ToDouble(tbFirst);
                    double secondVariable = Convert.ToDouble(tbSecond);

                    switch (value)
                    {
                        case 0:
                            tbResult.Text = Convert.ToString(firstVariable + secondVariable);

                            break;
                        case 1:
                            tbResult.Text = Convert.ToString(firstVariable * secondVariable);

                            break;
                        case 2:
                            tbResult.Text = Convert.ToString(firstVariable / secondVariable);

                            break;
                        case 3:
                            tbResult.Text = Convert.ToString(firstVariable - secondVariable);

                            break;


                    }
                }
                catch
                {
                    MessageBox.Show("Что - то пошло не так", "Попробуйте еще раз", MessageBoxButton.OK, MessageBoxImage.Error);
                }


            }
        }
    }
}
