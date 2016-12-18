using Mvvm_Template.Models;
using System.Windows.Input;
using Mvvm_Template.Helpers;
using System.Windows;

namespace Mvvm_Template.ViewModels
{
    public class ViewModel : ViewModelBase
    {

        #region konstruktory
        public ViewModel()
        {

            var model = new ConfigModel();              // Jeśli chcę ustawić jakis properties w klasie ConfigModel w moim Modelu --> Tworzę nowy obiekt klasy ConfigModel
            model.Properties = "sadasd";                // poprzez nowy obiekt(instancję klasy) mogę dostać się to jej właściwości (propertiesów)
            MojeUstawienia = model;                     // Aktualizuje moj properties


            RRR = "Karol rulexxx";                      //Propertiesy mogę tworzyć i przechowywaś także w ViewModel na własne potrzeby

            HiButtonCommand = new RelayCommand(HiButtonCommandExecute);         //Tworzę nowy Button//
        }
        #endregion

        #region Przyciski

        // Do nowego przycisku należy stworzyc properties i "ciało" przycisku gdzie wykonywana jest akcja

        public ICommand HiButtonCommand { get; set; }
        private void HiButtonCommandExecute(object obj)
        {
            MessageBox.Show("Good");

        }

        #endregion

        #region Properties


        //Dzięki temu Propertiesowi mogę operować na wszystkich properties-ach z klasy ConfigModel w moim Modelu. Przydatne do serializacji
        private ConfigModel _MojeUstawienia;
        public ConfigModel MojeUstawienia
        {
            get
            {
                return _MojeUstawienia;
            }
            set
            {
                _MojeUstawienia = value;
                OnPropertyChanged("MojeUstawienia");
            }
        }


        //Propertiesy mogę tworzyć i przechowywaś także w ViewModel na własne potrzeby
        private string rrr;
        public string RRR
        {
            get
            {
                return rrr;
            }
            set
            {
                rrr = value;
                OnPropertyChanged("RRR");
            }
        }
        #endregion

    }
}
