﻿using eStudioLjepote.Mobile.Models;
using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eStudioLjepote.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        List<HomeMenuItem> menuItems;
        public MenuPage()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.Profil, Title="Moj profil" },
               new HomeMenuItem {Id = MenuItemType.Usluge, Title="Usluge" },
                new HomeMenuItem {Id = MenuItemType.Proizvodi, Title="Proizvodi" },
              
                  new HomeMenuItem {Id = MenuItemType.Rezervacija, Title="Rezervacija"},
                  new HomeMenuItem {Id = MenuItemType.Odjava, Title="Odjava"}



            };

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                await RootPage.NavigateFromMenu(id);
            };
        }
    }
}