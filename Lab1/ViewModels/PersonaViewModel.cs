using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
using System.Linq;
using Lab1.Models;
using Lab1.Views;

namespace Lab1.ViewModels
{
    public class PersonaViewModel : INotifyPropertyChanged
    {
        #region Singleton

        private static PersonaViewModel instance = null;


        public PersonaViewModel()
        {
            InitClass();
            InitCommands();
        }

        public static PersonaViewModel GetInstance()
        {
            if (instance == null)
                instance = new PersonaViewModel();

            return instance;
        }

        public static void DeleteInstance()
        {
            if (instance != null)
                instance = null;
        }

        #endregion


        #region Instancias

        private PersonaModel _PersonaActual { get; set; }

        public PersonaModel PersonaActual
        {
            get
            {
                return _PersonaActual;
            }
            set
            {
                _PersonaActual = value;
                OnPropertyChanged("PersonaActual");
            }
        }

        private Ventas _VentaActual = new Ventas();
        public Ventas VentaActual {
            get{
                return _VentaActual;
            }
            set{
                _VentaActual = value;
                OnPropertyChanged("VentaActual");
            }
        }

        private ObservableCollection<PersonaModel> _lstPersonas = new ObservableCollection<PersonaModel>();

        public ObservableCollection<PersonaModel> lstPersonas
        {
            get
            {
                return _lstPersonas;
            }
            set
            {
                _lstPersonas = value;
                OnPropertyChanged("lstPersonas");
            }
        }

        public ICommand VerPersonaCommand { get; set; }
        public ICommand EnterNuevaVentaCommand { get; set; }
        public ICommand AgregarNuevaVentaCommand { get; set; }
        public ICommand EditarVentaCommand { get; set; }

        #endregion

        #region Methods

        private void VerPersona(int id)
        {
            PersonaActual = lstPersonas.Where(x => x.ID == id).FirstOrDefault();

            //App.Current.MainPage = new UsuarioDetalle();

            ((MasterDetailPage)App.Current.MainPage).Detail.Navigation.PushAsync(new UsuarioDetalle());
        }

        private void NuevaVenta()
        {
            VentaActual = new Ventas();
            ((MasterDetailPage)App.Current.MainPage).Detail.Navigation.PushAsync(new NuevaVentaView());
        }

        private void AgregarVenta(){ //Como hago para que cuando se haga el POP, aparezca la nueva venta de una vez?
            int index = PersonaActual.lstVentas.FindIndex(f => f == VentaActual);
            if (index < 0)
            {
                PersonaActual.lstVentas.Add(VentaActual);
            }

            OnPropertyChanged("PersonaActual.lstVentas");
            ((MasterDetailPage)App.Current.MainPage).Detail.Navigation.PopAsync();

        }

        private void EditarVenta(int id){
            VentaActual = PersonaActual.lstVentas.Find(x => x.ID == id);
            ((MasterDetailPage)App.Current.MainPage).Detail.Navigation.PushAsync(new NuevaVentaView());
        }

        #endregion


        private async void InitClass()
        {
            lstPersonas = await PersonaModel.ObtenerPersonas();
        }

        private void InitCommands()
        {

            VerPersonaCommand = new Command<int>(VerPersona);
            EnterNuevaVentaCommand = new Command(NuevaVenta);
            AgregarNuevaVentaCommand = new Command(AgregarVenta);
            EditarVentaCommand = new Command<int>(EditarVenta);
        }

        #region INotifyPropertyChange Interface

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));

        }

        #endregion
    }
}
