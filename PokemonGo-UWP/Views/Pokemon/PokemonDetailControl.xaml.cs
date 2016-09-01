﻿using POGOProtos.Settings.Master;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Template10.Mvvm;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace PokemonGo_UWP.Views
{
    public sealed partial class PokemonDetailControl : UserControl
    {
        public PokemonDetailControl()
        {
            this.InitializeComponent();
        }

        #region Dependency Propertys

        public static readonly DependencyProperty FavoritePokemonCommandProperty = 
            DependencyProperty.Register(nameof(FavoritePokemonCommand), typeof(DelegateCommand), typeof(PokemonDetailControl),
                new PropertyMetadata(null));

        public static readonly DependencyProperty RenamePokemonCommandProperty =
            DependencyProperty.Register(nameof(RenamePokemonCommand), typeof(DelegateCommand), typeof(PokemonDetailControl),
                new PropertyMetadata(null));

        public static readonly DependencyProperty PowerUpPokemonCommandProperty =
            DependencyProperty.Register(nameof(PowerUpPokemonCommand), typeof(DelegateCommand), typeof(PokemonDetailControl),
                new PropertyMetadata(null));

        public static readonly DependencyProperty EvolvePokemonCommandProperty =
            DependencyProperty.Register(nameof(EvolvePokemonCommand), typeof(DelegateCommand), typeof(PokemonDetailControl),
                new PropertyMetadata(null));

        public static readonly DependencyProperty PokemonExtraDataProperty =
            DependencyProperty.Register(nameof(PokemonExtraData), typeof(DelegateCommand), typeof(PokemonDetailControl),
                new PropertyMetadata(null));

        public DelegateCommand FavoritePokemonCommand
        {
            get { return (DelegateCommand)GetValue(FavoritePokemonCommandProperty); }
            set { SetValue(FavoritePokemonCommandProperty, value); }
        }

        public DelegateCommand RenamePokemonCommand
        {
            get { return (DelegateCommand)GetValue(RenamePokemonCommandProperty); }
            set { SetValue(RenamePokemonCommandProperty, value); }
        }

        public DelegateCommand PowerUpPokemonCommand
        {
            get { return (DelegateCommand)GetValue(PowerUpPokemonCommandProperty); }
            set { SetValue(PowerUpPokemonCommandProperty, value); }
        }

        public DelegateCommand EvolvePokemonCommand
        {
            get { return (DelegateCommand)GetValue(EvolvePokemonCommandProperty); }
            set { SetValue(EvolvePokemonCommandProperty, value); }
        }

        public PokemonSettings PokemonExtraData
        {
            get { return (PokemonSettings)GetValue(PokemonExtraDataProperty); }
            set { SetValue(PokemonExtraDataProperty, value); }
        }

        #endregion
    }
}
