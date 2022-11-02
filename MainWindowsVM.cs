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

        public MainWindowsVM()
        {
            contadorActual = 1;
        }
    }
}
