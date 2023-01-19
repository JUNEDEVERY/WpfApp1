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
        // инициаилизуем наши "типо переменные, находящиеся на main window xaml"
        public static string tbFirst;
        public static string tbSecond;

        // создаем лист, с данными, которые будут использоваться в комбобоксе в качестве выбранного элемента. такая же аналогия со знаками. взависимости от выбранного эл-та ко-кса меняется знак
        public static List<string> cmbOperation = new List<string>() { "Сложение", "Умножение", "Деление", "Вычитание" };
        public static List<string> tbSign = new List<string>() { "+", "*", "/", "-" };


        public static TextBlock tbSignText = new TextBlock();
        public static TextBlock tbResult = new TextBlock();


        public static int tbSignOperation // передаем знак из листа tbsign
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
                        case 0: // кейсы - айдишники выбранного  элементы комбобокса
                            tbResult.Text = Convert.ToString(firstVariable + secondVariable);

                            break;
                        case 1:
                            tbResult.Text = Convert.ToString(firstVariable * secondVariable);

                            break;
                        case 2:
                            if (secondVariable == 0)
                            {
                                tbResult.Text = "Вы что? Делить на 0 нельзя";

                            }
                            else
                            {
                                tbResult.Text = Convert.ToString(firstVariable / secondVariable);
                            }
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
