using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlankApp1.ViewModels
{
    public class PrismContentPage4ViewModel : BindableBase
    {
        public DelegateCommand Button7_clicked { get; private set; }
        public DelegateCommand Button8_clicked { get; private set; }

        public PrismContentPage4ViewModel(INavigationService navigationService)
        {
            Button7_clicked = new DelegateCommand(() => navigationService.NavigateAsync("PrismContentPage5"));
            Button8_clicked = new DelegateCommand(() => navigationService.NavigateAsync("PrismContentPage6"));
        }
    }
}
