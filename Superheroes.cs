using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema4_Superheroes
{
    class Superheroes : INotifyPropertyChanged
    {
        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; NotifyPropertyChanged("Nombre"); }

        }
        private string imagen;
        public string Imagen
        {
            get { return imagen; }
            set { imagen = value; NotifyPropertyChanged("Nombre"); }

        }
        private bool vengador;
        public bool Vengador
        {
            get { return vengador; }
            set { vengador = value; NotifyPropertyChanged("Nombre"); }

        }
        private bool xmen;
        public bool Xmen
        {
            get { return xmen; }
            set { xmen = value; NotifyPropertyChanged("Nombre"); }

        }
        private bool heroe;
        public bool Heroe
        {
            get { return heroe; }
            set { heroe = value; NotifyPropertyChanged("Nombre"); }

        }


        public Superheroes()
        {
        }

        public Superheroes(string nombre, string imagen, bool vengador, bool xmen, bool heroe)
        {
            Nombre = nombre;
            Imagen = imagen;
            Vengador = vengador;
            Xmen = xmen;
            Heroe = heroe;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public static List<Superheroes> GetSamples()
        {
            List<Superheroes> ejemplos = new List<Superheroes>();

            Superheroes ironman = new Superheroes("Ironman", @"https://dossierinteractivo.com/wp-content/uploads/2021/01/Iron-Man.png", true, false, true);
            Superheroes kingpin = new Superheroes("Kingpin", @"https://www.comicbasics.com/wp-content/uploads/2017/09/Kingpin.jpg", false, false, false);
            Superheroes spiderman = new Superheroes("Spiderman", @"https://wipy.tv/wp-content/uploads/2019/08/destino-de-%E2%80%98Spider-Man%E2%80%99-en-los-Comics.jpg", true, true, true);

            ejemplos.Add(ironman);
            ejemplos.Add(kingpin);
            ejemplos.Add(spiderman);

            return ejemplos;
        }
    }
}
