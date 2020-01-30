﻿using Prism.Mvvm;
using System.Collections.ObjectModel;
using Yacaa.Shared.Navigation;
using Yacaa.Shared.ViewModels;

namespace Yacaa.Modules.Accounting.Menu
{
    public class PartnerInteractionViewModel : BaseViewModel
    {
        public ObservableCollection<ExpanderItem> ExpanderItems { get; }
        public NavigationItem SelectedItem { get; set; }

        public PartnerInteractionViewModel()
        {
            ExpanderItems = GenerateItems();
        }

        private static ObservableCollection<ExpanderItem> GenerateItems()
        {
            return new ObservableCollection<ExpanderItem>()
            {
                new ExpanderItem(Shared.Strings.Views.PartnerInteraction.Label, new ObservableCollection<NavigationItem>()
                {
                    new NavigationItem(Shared.Strings.Views.PartnerInteraction.Contracts, "Contracts"),
                    new NavigationItem(Shared.Strings.Views.PartnerInteraction.Agreements, "Agreements"),
                    new NavigationItem(Shared.Strings.Views.PartnerInteraction.RequestAdmission, "RequestAdmission"),
                    new NavigationItem(Shared.Strings.Views.PartnerInteraction.RequestRelocation, "RequestRelocation"),
                    new NavigationItem(Shared.Strings.Views.PartnerInteraction.RequestShipment, "RequestShipment"),
                })
            };
        }
    }
}