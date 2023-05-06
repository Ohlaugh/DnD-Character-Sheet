using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DnD_Character_Sheet.HelperClasses
{
  public class NotifyProperty : INotifyPropertyChanged
  {
    #region IPropertyChanged

    public event PropertyChangedEventHandler PropertyChanged;
    protected void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    #endregion IPropertyChanged
  }
}
