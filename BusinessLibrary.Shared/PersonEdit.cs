using System;
using System.Collections.Generic;
using System.Text;
using Csla;

namespace BusinessLibrary
{
  [Serializable]
  public class PersonEdit : BusinessBase<PersonEdit>
  {
    public static readonly PropertyInfo<string> NameProperty = RegisterProperty<string>(c => c.Name);
    public string Name
    {
      get { return GetProperty(NameProperty); }
      set { SetProperty(NameProperty, value); }
    }

    protected override void DataPortal_Create()
    {
      base.DataPortal_Create();
      using (BypassPropertyChecks)
      {
        Name = "Rocky";
      }
    }
  }
}
