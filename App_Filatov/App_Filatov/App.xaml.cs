﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Filatov
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Valgusfoor2();
        }


        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
