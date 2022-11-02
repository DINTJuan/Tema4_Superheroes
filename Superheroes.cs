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
        public string Nombre
        {
            get { return Nombre; }
            set { Nombre = value; NotifyPropertyChanged("Nombre"); }

        }
        public string Imagen
        {
            get { return Imagen; }
            set { Imagen = value; NotifyPropertyChanged("Nombre"); }

        }
        public bool Vengador
        {
            get { return Vengador; }
            set { Vengador = value; NotifyPropertyChanged("Nombre"); }

        }
        public bool Xmen
        {
            get { return Xmen; }
            set { Xmen = value; NotifyPropertyChanged("Nombre"); }

        }
        public bool Heroe
        {
            get { return Heroe; }
            set { Heroe = value; NotifyPropertyChanged("Nombre"); }

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
