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
using System.Windows.Shapes;

namespace WPFHello
{
  /// <summary>
  /// Interaction logic for About.xaml
  /// </summary>
  public partial class About : Window
  {
    public About()
    {
      InitializeComponent();
      ShowName("no name is given");
    }
    public About(string nimi)
    {
      InitializeComponent();
      ShowName(nimi);
    }

    private void ShowName(string nimi)
    {
      tbName.Text = nimi;
    }
  }
}
