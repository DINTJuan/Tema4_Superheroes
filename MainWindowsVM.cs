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

        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private Superheroes heroeActual;
        public Superheroes HeroeActual
        {
            get { return heroeActual; }
            set
            {
                heroeActual = value;
                NotifyPropertyChanged("HeroeActual");
            }
        }
        private int contadorActual;

        public int ContadorActual
        {
            get { return contadorActual; }
            set
            {
                contadorActual = value;
                NotifyPropertyChanged("contadorActual");
            }
            
        }

        private int totalHeroes;
        public int TotalHeroes
        {
            get { return totalHeroes; }
            set
            {
                totalHeroes = value;
                NotifyPropertyChanged("totalHeroes");
            }
        }

        readonly List<Superheroes> lista;
        public MainWindowsVM()
        {
            lista = Superheroes.GetSamples();
            ContadorActual = 1;
            HeroeActual = lista[contadorActual - 1];
            TotalHeroes = lista.Count;
        }

        public void Avanzar()
        {
            ContadorActual++;
            HeroeActual = lista[contadorActual - 1];
        }

        public void Retoceder()
        {
            ContadorActual--;
            HeroeActual = lista[contadorActual - 1];
        }
    }
}
