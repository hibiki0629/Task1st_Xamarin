using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlankApp1.ViewModels
{
    public class PrismContentPage6ViewModel : BindableBase
    {
        private bool _toggle;
        public bool toggle
        {
            get { return _toggle; }
            set { SetProperty(ref _toggle, value); }
        }

        private double _Value;
        public double Value
        {
            get { return _Value; }
            set
            {
                SetProperty(ref _Value,value);
                ValueChack();
            }
        }

        public PrismContentPage6ViewModel()
        {

        }

        private void ValueChack()
        {
            if(Value == 100)
            {
                toggle = true;
            }
            else
            {
                toggle = false;
            }

        }
    }
}
