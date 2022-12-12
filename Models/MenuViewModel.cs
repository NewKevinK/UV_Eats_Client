using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using UV_Eats_Client.Logic;
using UV_Eats_Client.Client;
using Newtonsoft.Json;

namespace UV_Eats_Client.Models
{
    public class MenuViewModel : INotifyPropertyChanged
    {
        // PantallaInicial pantallaInicial = new PantallaInicial(auth);
        //PantallaInicial pantallaInicial = new PantallaInicial();
        API API = new API();
        public MenuViewModel(string token)
        {
            MenuDAB = new ObservableCollection<Menu>();
            // string tkn = pantallaInicial.TokenMenu();
            dynamic respuestaMenu = API.GetToken("https://uveatsapi-production.up.railway.app/api/Menu/", token);
            List<Menu> menuJson = JsonConvert.DeserializeObject<List<Menu>>(respuestaMenu.Content);
            for (int i=0; i < menuJson.Count; i++) {
                //MenuDAB.Add(new Menu() menuJson[i]);
                MenuDAB.Insert(i,menuJson[i]);
            }
           
        }

        private ObservableCollection<Menu> _menuDAB;

        public ObservableCollection<Menu> MenuDAB
        {
            get
            {
                return _menuDAB;
            }
            set
            {
                _menuDAB = value;
                NotifyPropertyChanged("MenuDAB");
            }
        }


        private Menu _selectedMenuDAB;

        public Menu SelectedMenuDAB
        {
            get
            {
                return _selectedMenuDAB;
            }
            set
            {
                _selectedMenuDAB = value;
                NotifyPropertyChanged("SelectedMenuDAB");
            }
        }

        public void Delete()
        {
            //System.Collections.Generic.List<ExperienciaEducativa> newItems = ExperienciasEducativasDAB.ToList();
            //newItems.Remove(SelectedExperienciaEducativaDAB);
            //ExperienciasEducativasDAB = new ObservableCollection<ExperienciaEducativa>(newItems);
            MenuDAB.Remove(SelectedMenuDAB);
            SelectedMenuDAB = MenuDAB[0];
        }

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion INotifyPropertyChanged


    }
}
