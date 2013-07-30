// Type: Telerik.Charting.StringToAngleRangeConverter
// Assembly: Telerik.Windows.Controls.Chart, Version=2013.1.219.2040, Culture=neutral, PublicKeyToken=5803cfa389c90ce7
// Assembly location: C:\Program Files (x86)\Telerik\RadControls for Windows Phone 7 Q1 2013\Binaries\WindowsPhone\Telerik.Windows.Controls.Chart.dll

using System;
using System.ComponentModel;
using System.Globalization;

namespace Charting
{
  /// <summary>
  /// Converts a string to an AngleRange object.
  /// 
  /// </summary>
  public class StringToAngleRangeConverter : TypeConverter
  {
    public StringToAngleRangeConverter()
    {
      base.\u002Ector();
    }

    /// <summary>
    /// Returns whether the type converter can convert an object from the specified type to the type of this converter.
    /// 
    /// </summary>
    /// <param name="context">An object that provides a format context.</param><param name="sourceType">The type you want to convert from.</param>
    /// <returns>
    /// true if this converter can perform the conversion; otherwise, false.
    /// 
    /// </returns>
    public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
    {
      return sourceType == typeof (string);
    }

    /// <summary>
    /// Converts from the specified value to the intended conversion type of the converter.
    /// 
    /// </summary>
    /// <param name="context">An object that provides a format context.</param><param name="culture">The <see cref="T:System.Globalization.CultureInfo"/> to use as the current culture.</param><param name="value">The value to convert to the type of this converter.</param>
    /// <returns>
    /// The converted value.
    /// </returns>
    public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
    {
      string[] strArray = ((string) value).Split(new char[1]
      {
        ','
      });
      if (strArray.Length != 2)
        throw new ArgumentException("The value of the AngleRange property must be of the form: startAngle, sweepAngle");
      double result1 = 0.0;
      double result2 = 0.0;
      if (!double.TryParse(strArray[0], out result1))
        throw new ArgumentException("StartAngle is not a valid double value.");
      if (!double.TryParse(strArray[1], out result2))
        throw new ArgumentException("SweepAngle is not a valid double value.");
      else
        return (object) new AngleRange(result1, result2);
    }
  }
}
