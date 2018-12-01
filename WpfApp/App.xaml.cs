using Csla.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp
{
  /// <summary>
  /// Interaction logic for App.xaml
  /// </summary>
  public partial class App : Application
  {
    public App()
    {
      new CslaConfiguration()
        .DataPortal().DefaultProxy(typeof(Csla.DataPortalClient.HttpProxy).AssemblyQualifiedName,
        "http://localhost:32771/api/DataPortal/");
    }
  }
}
