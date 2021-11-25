using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comida
{
    class MainWindowVM : INotifyPropertyChanged
    {
        private ObservableCollection<Plato> listaPlatos;

        public ObservableCollection<Plato> ListaPlatos
        {
            get { return listaPlatos; }
            set
            {
                listaPlatos = value;
                NotifyPropertyChanger("ListaPlatos");
            }
        }

        private List<String> tipoComida;

        public List<String> TipoComida
        {
            get { return tipoComida; }
            set
            {
                tipoComida = value;
                NotifyPropertyChanger("TipoComida");
            }
        }

        private Plato platoActual;

        public Plato PlatoActual
        {
            get { return platoActual; }
            set
            {
                platoActual = value;
                NotifyPropertyChanger("PlatoActual");
            }
        }


        public MainWindowVM()
        {
            TipoComida = new List<string> { "China", "Americana", "Mexicana" };
            listaPlatos = Plato.GetSamples("assets");
            PlatoActual = ListaPlatos[0];
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanger(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
