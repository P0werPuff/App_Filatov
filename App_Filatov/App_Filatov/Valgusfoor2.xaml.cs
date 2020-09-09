using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Filatov
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Valgusfoor2 : ContentPage
    {
        Label punane, kollane, roheline;
        Frame pun, kol, roh;
        Button sisse, valja;
        bool sisse_valja;
        private int clicked1;
        private object rohaline;

        public Valgusfoor2()
        {
            //InitializeComponent();
            Label red = new Label()
            {
                Text = "  Red  ",
                TextColor = Color.Red,
                FontSize = 18
            };
            Frame punframe = new Frame()
            {
                BackgroundColor = Color.Gray,
                Content = red,
                CornerRadius = 90,
                Padding = 50,
                HorizontalOptions = LayoutOptions.Center
            };
            Label yellow = new Label()
            {
                Text = "Yellow",
                TextColor = Color.Yellow,
                FontSize = 18

            };
            Frame kolframe = new Frame()
            {
                BackgroundColor = Color.Gray,
                Content = yellow,
                CornerRadius = 90,
                Padding = 50,
                HorizontalOptions = LayoutOptions.Center
            };
            Label green = new Label()
            {
                Text = "Green ",
                TextColor = Color.Green,
                FontSize = 18

            };
            Frame rohframe = new Frame()
            {
                BackgroundColor = Color.Gray,
                Content = green,
                CornerRadius = 90,
                Padding = 50,
                HorizontalOptions = LayoutOptions.Center
            };
            Button bt1 = new Button()
            {
                Text = "On",
                HorizontalOptions = LayoutOptions.Start
            };
            Button bt2 = new Button()
            {
                Text = "off",
                HorizontalOptions = LayoutOptions.End
            };
            StackLayout stackLayout2 = new StackLayout()
            {
                Children = { bt1, bt2 }
            };
            StackLayout stackLayout = new StackLayout()
            {
                Children = { punframe, kolframe, rohframe, stackLayout2 }
            };
            stackLayout2.Orientation = StackOrientation.Horizontal;
            stackLayout2.Margin = new Thickness(90, 0, 0, 0);

            bt1.Clicked += bt1_Clicked;
            bt2.Clicked += bt2_Clicked;

            Content = stackLayout;
             
            var tap = new TapGestureRecognizer();
            tap.Tapped += Tap_Tapped;
            punframe.GestureRecognizers.Add(tap);
        }

        private async void bt1_Clicked(object sender, EventArgs e)
        {
           pun.BackgroundColor = Color.Red;
           pun.BorderColor = Color.WhiteSmoke;
           sisse_valja = false;
           for (int i = 0; i < 100; i++)
           {
               punane.FontSize++;
               await Task.Run(() => Thread.Sleep(1000));//Пауза в 1 сек
           }
            
        }
        private async void bt2_Clicked(object sender, EventArgs e)
        {
           pun.BackgroundColor = Color.Gray;
           pun.BorderColor = Color.WhiteSmoke;
           sisse_valja = true;
            for (int i = 0; i <100; i++)
            {
                punane.FontSize++; 
                await Task.Run(() => Thread.Sleep(1000));
            }
        } 
        private void Tap_Tapped(object sender, EventArgs e)
        {
            Frame fr = sender as Frame;
            if (fr == pun)
            {
                if (clicked1 == 0) {pun.Text = "Seisa ja oota!!!";}
                else if (fr == pun) {punane.Text = "Punane";}
            }
            else if (fr == kol)
            {
                if (clicked1 == 0) {kol.Text = "Pole palju jäänud";}
                else if (fr == kol) {kollane.Text = "Kollane";}
            }
            else if (fr == roh)
            {
                if (clicked1 == 0) { roh.Text = "Minne";}
                else if (fr == roh) {rohaline.Text = "Rohaline";}
            }

        }

    }
}