using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema4_Superheroes
{
    class MainWindowsVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        

        private Superheroes HeroeActual
        {
            get { return HeroeActual; }
            set
            {
                HeroeActual = value;
                NotifyPropertyChanged("HeroeActual");
            }
        }
        private int contadorActual
        {
            get { return contadorActual; }
            set
            {
                contadorActual = value;
                NotifyPropertyChanged("contadorActual");
            }
            
        }
        private int totalHeroes
        {
            get { return totalHeroes; }
            set
            {
                totalHeroes = value;
                NotifyPropertyChanged("totalHeroes");
            }
        }

        List<Superheroes> lista;
        public MainWindowsVM()
        {
            lista = Superheroes.GetSamples();
            contadorActual = 1;
            HeroeActual = lista[contadorActual - 1];
            totalHeroes = lista.Count;
        }

        public void Avanzar()
        {
            contadorActual++;
            HeroeActual = lista[contadorActual - 1];
        }

        public void Retoceder()
        {
            contadorActual--;
            HeroeActual = lista[contadorActual - 1];
        }
    }
}
