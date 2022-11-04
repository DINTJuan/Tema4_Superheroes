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

namespace Tema4_Superheroes
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainWindowsVM vm;
        public MainWindow()
        {
            InitializeComponent();
            vm = new MainWindowsVM();
            this.DataContext = vm;
        }

        private void ImagenIzquierda_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            vm.Retoceder();
        }

        private void ImagenDerecha_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            vm.Avanzar();
        }
    }
}
