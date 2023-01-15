using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Поиск_общих_в_массиве
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        Raschet_Class RCL = new Raschet_Class();
        int[] A = { 5, 544, 65, 84, -7 }; int[] B = { 5, 678, 544, 97, -9 }; int res = 0;
        public void Result_Btn_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < B.Length; j++)
                {
                    if (A[i] == B[i])
                    {
                        res++;
                    }
                }
            }
            if (res > 0)
            {
                Result_Lb.Content = "Результат: Массивы А и В пересекаются!";
            }
            else
                Result_Lb.Content = "Результат: Массивы А и В не пересекаются!";
        }

        public static class Resultation
        {
             
        }
    }
}
