using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DOPE.Common.Models.Bot.Stats;

public class GClass833 : StatisticsCategory
{
	public Dictionary<string, GClass833.GStruct0> DeathLog
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
			this.<>OnPropertyChanged(Class10.propertyChangedEventArgs_17);
		}
	}

	public GClass833(Dictionary<string, GClass833.GStruct0> dictionary_1)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor("Deaths", new string[]
		{
			"Killer",
			"Count",
			"LastDeath"
		}, null);
		this.DeathLog = dictionary_1;
	}

	public void method_0(string string_0)
	{
		Dictionary<string, GClass833.GStruct0> deathLog = this.DeathLog;
		lock (deathLog)
		{
			GClass833.GStruct0 value;
			this.DeathLog.TryGetValue(string_0, out value);
			value.Count++;
			value.dateTimeOffset_0 = DateTimeOffset.Now;
			this.DeathLog[string_0] = value;
		}
	}

	public override void Rebuild()
	{
	}

	public override void Update()
	{
		Dictionary<string, GClass833.GStruct0> deathLog = this.DeathLog;
		lock (deathLog)
		{
			foreach (KeyValuePair<string, GClass833.GStruct0> keyValuePair in this.DeathLog)
			{
				GClass833.<>c__DisplayClass8_0 CS$<>8__locals1 = new GClass833.<>c__DisplayClass8_0();
				CS$<>8__locals1.string_0 = this.Key + "_" + keyValuePair.Key;
				RowEntry rowEntry = (RowEntry)base.GetOrAdd(CS$<>8__locals1.string_0, new Func<IRowEntry>(CS$<>8__locals1.AkrHmfhPviQ));
				(rowEntry.Cells[1] as VariableValue<string>).Value = string.Format("{0:N0}", keyValuePair.Value.Count);
				(rowEntry.Cells[2] as VariableValue<string>).Value = string.Format("{0}", keyValuePair.Value.dateTimeOffset_0);
				rowEntry.Order = keyValuePair.Value.Count;
			}
		}
		base.Update();
	}

	[CompilerGenerated]
	private Dictionary<string, GClass833.GStruct0> dictionary_0;

	public struct GStruct0
	{
		public int Count;

		public DateTimeOffset dateTimeOffset_0;
	}
}
