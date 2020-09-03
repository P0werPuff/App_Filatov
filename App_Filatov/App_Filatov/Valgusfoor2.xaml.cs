using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Filatov
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Valgusfoor2 : ContentPage
    {
        public Valgusfoor2()
        {
            //InitializeComponent();
            Label punane = new Label()
            {
                Text = "Punane",
                TextColor = Color.Red,
                FontSize = 18,
                FontAttributes = FontAttributes.Bold
            };
            Frame pun = new Frame()
            {
                BackgroundColor = Color.Gray,
                Content = punane,
                CornerRadius = 90,
                Padding = 50,
                Margin = new Thickness(80, 0, 80, 0)
            };
            Label kollane = new Label()
            {
                Text = "Kollane",
                TextColor = Color.Yellow,
                FontSize = 18,
                FontAttributes = FontAttributes.Bold
            };
            Frame kol = new Frame()
            {
                BackgroundColor = Color.Gray,
                Content = kollane,
                CornerRadius = 90,
                Padding = 50,
                Margin = new Thickness(80, 0, 80, 0)
            };
            Label roheline = new Label()
            {
                Text = "Roheline",
                TextColor = Color.Green,
                FontSize = 18,
                FontAttributes = FontAttributes.Bold
            };
            Frame roh = new Frame()
            {
                BackgroundColor = Color.Gray,
                Content = roheline,
                CornerRadius = 90,
                Padding = 50,
                Margin = new Thickness(80, 0, 80, 0)
            };
            Button btn1 = new Button()
            {
                Text = "On",
                HorizontalOptions = LayoutOptions.EndAndExpand
            };
            Button btn2 = new Button()
            {
                Text = "Off",
                HorizontalOptions = LayoutOptions.StartAndExpand{

                


            StackLayout stackLayout = new StackLayout()
            {
                Children = { punane, kollane, roheline }
            };
            stackLayout.Orientation = StackOrientation.Horizontal;
            Content = stackLayout;


        }
    }
}