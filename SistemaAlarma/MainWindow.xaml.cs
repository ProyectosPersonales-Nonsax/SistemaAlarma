using System;
using System.Diagnostics;
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

namespace SistemaAlarma
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Inicial.Text = "";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Process p = new Process();
            //p.StartInfo.FileName = "C:/Users/alumno/Desktop/Reproductor.exe";
            //p.Start();
            //p.WaitForExit();
            //Holo.Text = "Funciona!!";

            Juego juego = new Juego();
            juego.Owner = this;
            juego.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            juego.Show();

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
