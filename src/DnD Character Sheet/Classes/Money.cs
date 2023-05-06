using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using LC = DnD_Character_Sheet.Constants;
using LIB = DnD_Character_Sheet.Library;

namespace DnD_Character_Sheet.Classes
{
  public class Money : INotifyPropertyChanged
  {
    #region Private Members

    private int m_Copper = 0;
    private int m_Silver = 0;
    private int m_Electrum = 0;
    private int m_Gold = 0;
    private int m_Platinum = 0;

    #endregion Private Members

    public int Copper
    {
      get { return m_Copper; }

      set
      {
        if (value != m_Copper)
        {
          m_Copper = value;
          NotifyPropertyChanged();
        }
      }
    }
    public int Silver
    {
      get { return m_Silver; }

      set
      {
        if (value != m_Silver)
        {
          m_Silver = value;
          NotifyPropertyChanged();
        }
      }
    }
    public int Electrum
    {
      get { return m_Electrum; }

      set
      {
        if (value != m_Electrum)
        {
          m_Electrum = value;
          NotifyPropertyChanged();
        }
      }
    }
    public int Gold
    {
      get { return m_Gold; }

      set
      {
        if (value != m_Gold)
        {
          m_Gold = value;
          NotifyPropertyChanged();
        }
      }
    }
    public int Platinum
    {
      get { return m_Platinum; }

      set
      {
        if (value != m_Platinum)
        {
          m_Platinum = value;
          NotifyPropertyChanged();
        }
      }
    }

    #region Public Methods

    /// <summary>
    /// This method converts the currency provided
    /// </summary>
    /// <param name="CurrencyFrom">Currency Converting From</param>
    /// <param name="CurrencyTo">Currency Converting To</param>
    /// <param name="value">Value of Currency that is being converted</param>
    public static void Convert(string CurrencyFrom, string CurrencyTo, int value)
    {
      switch (CurrencyFrom)
      {
        case LC.Copper:
          {
            LIB.MainCharacterInfo.Money.Copper -= value;
            switch (CurrencyTo)
            {
              case LC.Silver:
                {
                  LIB.MainCharacterInfo.Money.Silver += value / 10;
                  LIB.MainCharacterInfo.Money.Copper += value % 10;
                  break;
                }
              case LC.Electrum:
                {
                  LIB.MainCharacterInfo.Money.Electrum += value / 50;
                  LIB.MainCharacterInfo.Money.Copper += value % 50;
                  break;
                }
              case LC.Gold:
                {
                  LIB.MainCharacterInfo.Money.Gold += value / 100;
                  LIB.MainCharacterInfo.Money.Copper += value % 100;
                  break;
                }
              case LC.Platinum:
                {
                  LIB.MainCharacterInfo.Money.Platinum += value / 1000;
                  LIB.MainCharacterInfo.Money.Copper += value % 1000;
                  break;
                }
              default:
                LIB.MainCharacterInfo.Money.Copper += value;
                break;
            }
            break;
          }
        case LC.Silver:
          {
            LIB.MainCharacterInfo.Money.Silver -= value;
            switch (CurrencyTo)
            {
              case LC.Copper:
                {
                  LIB.MainCharacterInfo.Money.Copper += value * 10;
                  break;
                }
              case LC.Electrum:
                {
                  LIB.MainCharacterInfo.Money.Electrum += value / 5;
                  LIB.MainCharacterInfo.Money.Silver += value % 5;
                  break;
                }
              case LC.Gold:
                {
                  LIB.MainCharacterInfo.Money.Gold += value / 10;
                  LIB.MainCharacterInfo.Money.Silver += value % 10;
                  break;
                }
              case LC.Platinum:
                {
                  LIB.MainCharacterInfo.Money.Platinum += value / 100;
                  LIB.MainCharacterInfo.Money.Silver += value % 100;
                  break;
                }
              default:
                LIB.MainCharacterInfo.Money.Silver += value;
                break;
            }
            break;
          }
        case LC.Electrum:
          {
            LIB.MainCharacterInfo.Money.Electrum -= value;
            switch (CurrencyTo)
            {
              case LC.Copper:
                {
                  LIB.MainCharacterInfo.Money.Copper += value * 50;
                  break;
                }
              case LC.Silver:
                {
                  LIB.MainCharacterInfo.Money.Silver += value * 5;
                  break;
                }
              case LC.Gold:
                {
                  LIB.MainCharacterInfo.Money.Gold += value / 2;
                  LIB.MainCharacterInfo.Money.Electrum += value % 2;
                  break;
                }
              case LC.Platinum:
                {
                  LIB.MainCharacterInfo.Money.Platinum += value / 20;
                  LIB.MainCharacterInfo.Money.Electrum += value % 20;
                  break;
                }
              default:
                LIB.MainCharacterInfo.Money.Electrum += value;
                break;
            }
            break;
          }
        case LC.Gold:
          {
            LIB.MainCharacterInfo.Money.Gold -= value;
            switch (CurrencyTo)
            {
              case LC.Copper:
                {
                  LIB.MainCharacterInfo.Money.Copper += value * 100;
                  break;
                }
              case LC.Silver:
                {
                  LIB.MainCharacterInfo.Money.Silver += value * 10;
                  break;
                }
              case LC.Electrum:
                {
                  LIB.MainCharacterInfo.Money.Electrum += value * 2;
                  break;
                }
              case LC.Platinum:
                {
                  LIB.MainCharacterInfo.Money.Platinum += value / 10;
                  LIB.MainCharacterInfo.Money.Gold += value % 10;
                  break;
                }
              default:
                LIB.MainCharacterInfo.Money.Gold += value;
                break;
            }
            break;
          }
        case LC.Platinum:
          {
            switch (CurrencyTo)
            {
              case LC.Copper:
                {
                  LIB.MainCharacterInfo.Money.Copper += value * 1000;
                  break;
                }
              case LC.Silver:
                {
                  LIB.MainCharacterInfo.Money.Silver += value * 100;
                  break;
                }
              case LC.Electrum:
                {
                  LIB.MainCharacterInfo.Money.Electrum += value * 20;
                  break;
                }
              case LC.Gold:
                {
                  LIB.MainCharacterInfo.Money.Gold += value * 10;
                  break;
                }
              default:
                break;
            }
            break;
          }
        default:
          break;
      }
    }

    #endregion Public Methods

    #region IPropertyChanged

    public event PropertyChangedEventHandler PropertyChanged;
    private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    #endregion IPropertyChanged
  }
}
