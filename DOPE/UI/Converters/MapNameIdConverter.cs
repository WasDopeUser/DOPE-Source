using System;
using System.Globalization;
using System.Windows.Data;
using DarkorbitAPI.Structures;

namespace DOPE.UI.Converters
{
	[ValueConversion(typeof(int), typeof(string))]
	public class MapNameIdConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return MapUtils.smethod_3((int)value);
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			int num;
			if (MapUtils.MapIdByName.TryGetValue((string)value, out num))
			{
				return num;
			}
			return "unknown";
		}

		public MapNameIdConverter()
		{
			Class13.Gj4N3WdzaR1LY();
			base..ctor();
		}
	}
}
