using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlankApp1.ViewModels
{
    public class PrismContentPage5ViewModel : BindableBase
    {
        private bool _flg;
        public bool flg
        {
            get { return _flg; }
            set { SetProperty(ref _flg, value); }
        }

        public DelegateCommand CangeButton_Click { get; private set; }

        public PrismContentPage5ViewModel()
        {
            CangeButton_Click = new DelegateCommand(() => flgChange());
        }

        private void flgChange()
        {
            if(flg)
            {
                flg = false;
            }
            else
            {
                flg = true;
            }
        }
    }
}
