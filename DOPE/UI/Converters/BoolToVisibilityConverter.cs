using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace DOPE.UI.Converters
{
	[ValueConversion(typeof(bool), typeof(Visibility))]
	public sealed class BoolToVisibilityConverter : IValueConverter
	{
		public Visibility TrueValue { get; set; }

		public Visibility FalseValue { get; set; }

		public BoolToVisibilityConverter()
		{
			Class13.NP5bWyNzLwONS();
			base..ctor();
			this.TrueValue = Visibility.Visible;
			this.FalseValue = Visibility.Collapsed;
		}

		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (!(value is bool))
			{
				return null;
			}
			return ((bool)value) ? this.TrueValue : this.FalseValue;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (object.Equals(value, this.TrueValue))
			{
				return true;
			}
			if (object.Equals(value, this.FalseValue))
			{
				return false;
			}
			return null;
		}
	}
}
