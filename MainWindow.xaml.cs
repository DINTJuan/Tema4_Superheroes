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
        private List<Superheroes> listaSuperheroes;
        public MainWindow()
        {
            InitializeComponent();
            listaSuperheroes = Superheroes.GetSamples();
            superheroeDockPanel.DataContext = listaSuperheroes.FirstOrDefault<Superheroes>();
            actualTextBlock.Text = "1";
            totalTextBlock.Text = listaSuperheroes.Count.ToString();
        }

        private void ImagenIzquierda_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            int num = int.Parse(actualTextBlock.Text);
            if (num <= 1)
                return;
            superheroeDockPanel.DataContext = listaSuperheroes[num - 2];
            actualTextBlock.Text = (num - 1).ToString();
        }

        private void ImagenDerecha_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            int index = int.Parse(actualTextBlock.Text);
            if (index >= this.listaSuperheroes.Count)
                return;
            superheroeDockPanel.DataContext = listaSuperheroes[index];
            actualTextBlock.Text = (index + 1).ToString();
        }
    }
}
