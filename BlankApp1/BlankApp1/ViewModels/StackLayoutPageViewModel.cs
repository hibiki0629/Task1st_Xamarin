using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlankApp1.ViewModels
{
    public class StackLayoutPageViewModel : BindableBase
    {
        public DelegateCommand ButtonClick { get; private set; }

        private string _Text;
        public string Text
        {
            get { return _Text; }
            set { SetProperty(ref _Text, value); }
        }

        public StackLayoutPageViewModel()
        {
            Text = "Xamarin.Forms";
            ButtonClick = new DelegateCommand(() => TextChange());
        }

        private void TextChange()
        {
            Text = "HelloWorld";
        }
    }
}
