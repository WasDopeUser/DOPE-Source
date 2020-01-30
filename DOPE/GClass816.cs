using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DOPE.Common.Models.Bot.Stats;

public class GClass816 : StatisticsCategory
{
	public Dictionary<string, int> Count
	{
		[CompilerGenerated]
		get
		{
			return this.dictionary_0;
		}
		[CompilerGenerated]
		private set
		{
			if (object.Equals(this.dictionary_0, value))
			{
				return;
			}
			this.dictionary_0 = value;
			this.<>OnPropertyChanged(Class10.Count);
		}
	}

	public GClass816(string string_0, Dictionary<string, int> dictionary_1)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor(string_0, new string[]
		{
			"Name",
			"Count"
		}, null);
		this.Count = dictionary_1;
	}

	public override void Rebuild()
	{
	}

	public override void Update()
	{
		Dictionary<string, int> count = this.Count;
		lock (count)
		{
			foreach (KeyValuePair<string, int> keyValuePair in this.Count)
			{
				GClass816.<>c__DisplayClass6_0 CS$<>8__locals1 = new GClass816.<>c__DisplayClass6_0();
				CS$<>8__locals1.string_0 = this.Key + "_" + keyValuePair.Key;
				RowEntry rowEntry = (RowEntry)base.GetOrAdd(CS$<>8__locals1.string_0, new Func<IRowEntry>(CS$<>8__locals1.method_0));
				(rowEntry.Cells[1] as VariableValue<string>).Value = string.Format("{0:N0}", keyValuePair.Value);
				rowEntry.Order = -keyValuePair.Value;
			}
		}
		base.Update();
	}

	[CompilerGenerated]
	private Dictionary<string, int> dictionary_0;
}
