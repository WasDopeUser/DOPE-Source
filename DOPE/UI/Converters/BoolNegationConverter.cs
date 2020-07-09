using System;
using System.Globalization;
using System.Windows.Data;

namespace DOPE.UI.Converters
{
	[ValueConversion(typeof(bool), typeof(bool))]
	public class BoolNegationConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return !(bool)value;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return !(bool)value;
		}

		public BoolNegationConverter()
		{
			Class13.lOBHd9Nzn7x2T();
			base..ctor();
		}
	}
}
