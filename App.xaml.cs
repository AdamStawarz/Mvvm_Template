using Mvvm_Template.Models;
using Mvvm_Template.ViewModels;
using Mvvm_Template.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Mvvm_Template
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {

            var view = new View();                              //Tworzę moje "View"
            var viewmodel = new ViewModel();                    //Tworzę moj "ViewModel"
            view.DataContext = viewmodel;                       //Łącze moje View z ViewModel


            var win = new Window();                             //Wyświetlam okno z moim View
            win.Title = "Tytuł";
            win.SizeToContent = SizeToContent.WidthAndHeight;
            win.Content = view;
            win.ShowDialog();
        }
    }
}
