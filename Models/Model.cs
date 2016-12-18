using Mvvm_Template.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Mvvm_Template.Models
{
    public class ConfigModel : ViewModelBase
    {

        #region constructors
        public ConfigModel()
        {

        }

        #endregion

        #region Properties
        private string _Properties;

        public string Properties
        {
            get
            {
                return _Properties;
            }
            set
            {
                _Properties = value;
                OnPropertyChanged("Properties");
            }
        }
        #endregion
    }
}
