﻿using Prism;
using Prism.Ioc;
using BlankApp1.ViewModels;
using BlankApp1.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace BlankApp1
{
    public partial class App
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<PrismContentPage, PrismContentPageViewModel>();
            containerRegistry.RegisterForNavigation<StackLayoutPage, StackLayoutPageViewModel>();
            containerRegistry.RegisterForNavigation<PrismContentPage1, PrismContentPage1ViewModel>();
            containerRegistry.RegisterForNavigation<PrismContentPage2, PrismContentPage2ViewModel>();
            containerRegistry.RegisterForNavigation<PrismContentPage3, PrismContentPage3ViewModel>();
            containerRegistry.RegisterForNavigation<PrismContentPage4, PrismContentPage4ViewModel>();
            containerRegistry.RegisterForNavigation<PrismContentPage5, PrismContentPage5ViewModel>();
            containerRegistry.RegisterForNavigation<PrismContentPage6, PrismContentPage6ViewModel>();
        }
    }
}
