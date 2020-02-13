using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DOPE.Common.Models.Bot.Stats;

public class GClass817 : StatisticsCategory
{
	public Dictionary<string, int> Count
	{
		[CompilerGenerated]
		get
		{
			return this.WqvoffXkxZs;
		}
		[CompilerGenerated]
		private set
		{
			if (object.Equals(this.WqvoffXkxZs, value))
			{
				return;
			}
			this.WqvoffXkxZs = value;
			this.<>OnPropertyChanged(Class10.Count);
		}
	}

	public GClass817(string string_0, Dictionary<string, int> dictionary_0)
	{
		Class13.igxcIukzfpare();
		base..ctor(string_0, new string[]
		{
			"Name",
			"Count"
		}, null);
		this.Count = dictionary_0;
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
				GClass817.<>c__DisplayClass6_0 CS$<>8__locals1 = new GClass817.<>c__DisplayClass6_0();
				CS$<>8__locals1.string_0 = this.Key + "_" + keyValuePair.Key;
				RowEntry rowEntry = (RowEntry)base.GetOrAdd(CS$<>8__locals1.string_0, new Func<IRowEntry>(CS$<>8__locals1.method_0));
				(rowEntry.Cells[1] as VariableValue<string>).Value = string.Format("{0:N0}", keyValuePair.Value);
				rowEntry.Order = -keyValuePair.Value;
			}
		}
		base.Update();
	}

	[CompilerGenerated]
	private Dictionary<string, int> WqvoffXkxZs;
}
