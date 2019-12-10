using System;
using System.Collections.Generic;

namespace DOPE.Common.Models.Bot.Stats
{
	public interface IRowEntry
	{
		string Group { get; }

		int Order { get; set; }

		string Key { get; }

		IReadOnlyList<IValueWrapper<string>> Cells { get; }

		void ForEach(Action<IValueWrapper<string>> action);
	}
}
