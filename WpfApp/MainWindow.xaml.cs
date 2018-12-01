﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
    }

    private async void DoTest(object sender, RoutedEventArgs e)
    {
      try
      {
        var obj = await Csla.DataPortal.CreateAsync<BusinessLibrary.PersonEdit>();
        this.output.Text = obj.Name;
      }
      catch (Exception ex)
      {
        this.output.Text = ex.ToString();
      }
    }
  }
}
