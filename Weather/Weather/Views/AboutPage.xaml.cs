﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Weather.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
            sunnyGif.Source =  $"https://media0.giphy.com/media/vNg01outFUVhyKGiB2/giphy.gif";
        }
    }
}
