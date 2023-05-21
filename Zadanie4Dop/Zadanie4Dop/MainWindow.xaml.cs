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

namespace Zadanie4Dop
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

        private void BtnOK_Click(object sender, RoutedEventArgs e)
        {
            int A = int.Parse(TbNumberA.Text);
            int B = int.Parse(TbNumberB.Text);
            int C = int.Parse(TbNumberC.Text);



            int numSquares = (A / C) * (B / C);
            int freeArea = A * B - numSquares * C * C;

            TextBlockAnswer.Text = $"Количество квадратов:{ numSquares} \n Площадь незанятой части:{freeArea} ";
        }
    }
}
