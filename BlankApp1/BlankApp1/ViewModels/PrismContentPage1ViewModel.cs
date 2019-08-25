using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace BlankApp1.ViewModels
{
    public class PrismContentPage1ViewModel : BindableBase
    {
        private ImageSource _image;
        public ImageSource Image
        {
            get { return _image; }
            set { SetProperty(ref _image, value); }
        }
        public PrismContentPage1ViewModel()
        {
            Image = ImageSource.FromResource("BlankApp1.Images.test.jpg");
        }
    }
}
