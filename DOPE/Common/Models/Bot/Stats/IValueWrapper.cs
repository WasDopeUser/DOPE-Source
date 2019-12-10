using System;
using System.ComponentModel;

namespace DOPE.Common.Models.Bot.Stats
{
	public interface IValueWrapper<T> : INotifyPropertyChanged
	{
		T Value { get; }
	}
}
