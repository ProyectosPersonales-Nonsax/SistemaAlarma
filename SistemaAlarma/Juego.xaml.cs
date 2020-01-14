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
using System.Windows.Shapes;

namespace SistemaAlarma
{
    /// <summary>
    /// Lógica de interacción para Juego.xaml
    /// </summary>
    public partial class Juego : Window
    {
        public Juego()
        {
            InitializeComponent();

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Random seed = new Random();
                    Grid g = new Grid();
                    TextBox tb = new TextBox();
                    Viewbox vb = new Viewbox();
                    vb.Child = tb;
                    g.Children.Add(vb);
                    tb.Text = seed.Next(1, 10).ToString();
                    g.Background = Brushes.DarkGreen;
                    g.Margin = new Thickness(1);
                    g.Tag = i + j;
                    Grid.SetColumn(g, i);
                    Grid.SetRow(g, j);
                    sudoku.Children.Add(g);
                }
            }
        }
    }
}
