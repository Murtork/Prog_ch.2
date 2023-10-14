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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Domino dom1 = new Domino();
        Domino dom2 = new Domino();

        public MainWindow()
        {
            InitializeComponent();
        }


        private void Button_SetDom1_Click(object sender, RoutedEventArgs e)
        {
            dom1.SetEdges();
            label_first.Content = Domino.ReturnEdges(dom1.edge1, dom1.edge2);
        }

        private void Button_SetDom2_Click(object sender, RoutedEventArgs e)
        {
            dom2.SetEdges();
            label_second.Content = Domino.ReturnEdges(dom2.edge1, dom2.edge2);
        }

        private void Button_HandSet1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // dom1.edge1 = int.Parse(BoxDomino1.Text); ;
                int edg1 = int.Parse(TextBox1.Text);
                int edg2 = int.Parse(TextBox2.Text);
                if ((0 < edg1) & (edg1 < 7) & (0 < edg2) & (edg2 < 7))
                {
                    Domino.HandySetDomino(dom1, edg1, edg2);
                    Label_Result_Text.Content = "Успешно!";
                    label_first.Content = Domino.ReturnEdges(dom1.edge1, dom1.edge2);
                }
                else
                {
                    Label_Result_Text.Content = "Значения вне диапазона [1;6]";
                }
            }
            catch
            {
                Label_Result_Text.Content = "Ошибка";
            }
        }

        private void Button_HandSet2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int edg1 = int.Parse(TextBox1.Text);
                int edg2 = int.Parse(TextBox2.Text);
                if ((0 < edg1) & (edg1 < 7) & (0 < edg2) & (edg2 < 7))
                {
                    Domino.HandySetDomino(dom2, edg1, edg2);
                    Label_Result_Text.Content = "Успешно!";
                    label_second.Content = Domino.ReturnEdges(dom2.edge1, dom2.edge2);
                }
                else
                {
                    Label_Result_Text.Content = "Значения вне диапазона [1;6]";
                }
            }
            catch
            {
                Label_Result_Text.Content = "Ошибка!";
            }
        }

        private void buttonResult_Click(object sender, RoutedEventArgs e)
        {
            Label_Final_Result.Content = Domino.TestThisTurn(dom1, dom2);
        }


        public class Domino
        {
            private int _edge1;
            public int edge1
            {
                get { return _edge1; }
                set { if (value > 0 && value < 7) _edge1 = value; }
            }
            public int _edge2;
            public int edge2
            {
                get { return _edge2; }
                set { if (value > 0 && value < 7) _edge2 = value; }
            }

            public void SetEdges()
            {
                Random rand = new Random();
                this.edge1 = rand.Next(1, 6);
                this.edge2 = rand.Next(1, 6);
            }

            public static string ReturnEdges(int edge1, int edge2)
            {
                string st = edge1 + ", " + edge2;
                return st;
            }

            public static void HandySetDomino(Domino d, int edge1, int edge2)
            {
                d.edge1 = edge1;
                d.edge2 = edge2;
            }

            public static string TestThisTurn(Domino d, Domino d2)
            {
                string result;
                if ((d.edge1 == d2.edge1) || (d.edge1 == d2.edge2) || (d.edge2 == d2.edge2) || (d.edge2 == d2.edge1))
                    if ((d.edge1 > 0) & (d.edge1 < 7) & (d.edge2 > 0) & (d.edge2 < 7) & (d2.edge1 > 0) & (d2.edge1 < 7) & (d2.edge2 > 0) & (d2.edge2 < 7))
                    {
                        result = "У этих домино ход существует!";
                    }
                    else
                    {
                        result = "Неправильные или отсутствующие знач. домино";
                    }
                else
                {
                    result = "Хода у этих домино нету";
                }

                return result;
            }

        }

       
    }
}
