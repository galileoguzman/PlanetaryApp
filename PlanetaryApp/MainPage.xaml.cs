﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PlanetaryApp
{
    public partial class MainPage : ContentPage
    {
        // POJO - OBJECT CLASS
        public class Planet
        {
            public string Name { get; set; }
            public string Distance { get; set; }
        }

        public MainPage()
        {
            InitializeComponent();

            initController();
        }

        public void initController()
        {
                var planets = new ObservableCollection<Planet>() {
                    new Planet
                    {
                     Name = "Mercury",
                     Distance = "Distance from Earth: 77 million kilometers"
                    },
                    new Planet
                    {
                     Name = "Venus",
                     Distance = "Distance from Earth: 261 million kilometers"
                    },
                    new Planet
                    {
                     Name = "Earth",
                     Distance = "Distance from Sun: 149.6 million kilometers"
                    },
                    new Planet
                     {
                      Name = "Mars",
                      Distance = "Distance from Earth: 54.6 million kilometers"
                     },
                     new Planet
                      {
                       Name = "Jupiter",
                       Distance = "Distance from Earth: 588 million kilometers"
                      },
                     new Planet
                      {
                       Name = "Saturn",
                       Distance = "Distance from Earth: 1.2 billion kilometers"
                      },
                      new Planet
                      {
                       Name = "Uranus",
                       Distance = "Distance from Earth: 2.6 billion kilometers"
                      },
                      new Planet
                      {
                       Name = "Neptune",
                       Distance = "Distance from Earth: 4.3 billon kilometers"
                      }};
            // Set the PlanetList Item to our ListView to display the items
            planetsListView.ItemsSource = planets;
        }

    }
}
