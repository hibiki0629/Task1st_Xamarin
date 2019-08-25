using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlankApp1.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public DelegateCommand Button1_clicked { get; private set; }
        public DelegateCommand Button2_clicked { get; private set; }
        public DelegateCommand Button3_clicked { get; private set; }
        public DelegateCommand Button4_clicked { get; private set; }
        public DelegateCommand Button5_clicked { get; private set; }
        public DelegateCommand Button6_clicked { get; private set; }

        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
            Button1_clicked = new DelegateCommand(() => navigationService.NavigateAsync("PrismContentPage"));
            Button2_clicked = new DelegateCommand(() => navigationService.NavigateAsync("StackLayoutPage"));
            Button3_clicked = new DelegateCommand(() => navigationService.NavigateAsync("PrismContentPage1"));
            Button4_clicked = new DelegateCommand(() => navigationService.NavigateAsync("PrismContentPage2"));
            Button5_clicked = new DelegateCommand(() => navigationService.NavigateAsync("PrismContentPage3"));
            Button6_clicked = new DelegateCommand(() => navigationService.NavigateAsync("PrismContentPage4"));
        }
    }
}
