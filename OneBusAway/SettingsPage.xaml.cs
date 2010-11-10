﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using OneBusAway.WP7.ViewModel;

namespace OneBusAway.WP7.View
{
    public partial class SettingsPage : AViewPage
    {
        private SettingsVM viewModel;

        public SettingsPage()
            : base()
        {
            InitializeComponent();
            base.Initialize();

            this.Loaded += new RoutedEventHandler(SettingsPage_Loaded);

            viewModel = Resources["ViewModel"] as SettingsVM;
        }

        void SettingsPage_Loaded(object sender, RoutedEventArgs e)
        {
            // Add the event handlers here instead of in XAML so they aren't called when the initial
            // selection is made on page load
            ReportUsageTs.Click += new EventHandler<RoutedEventArgs>(ReportUsageTs_Click);
            DefaultPivotLp.SelectionChanged += new SelectionChangedEventHandler(DefaultPivotLp_SelectionChanged);
        }

        // Methods overridden for analytics purposes
        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
        }

        // Methods overridden for analytics purposes
        protected override void OnNavigatedFrom(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedFrom(e);
        }

        private void appbar_clear_history_Click(object sender, EventArgs e)
        {
            viewModel.Clear();
        }

        // Created for analytics
        private void DefaultPivotLp_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        // Created for analytics
        private void ReportUsageTs_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}