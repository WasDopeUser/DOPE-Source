using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using DarkorbitAPI.Structures;

namespace DOPE.Common.Models.Bot
{
	[Guid("9EB44B2F-6E4B-4E0C-B015-3C4E1265CF14")]
	[DataContract]
	public class BotSummaryViewModel
	{
		[DataMember(Order = 1)]
		public double Credits { get; set; }

		[DataMember(Order = 2)]
		public double Uridium { get; set; }

		[DataMember(Order = 3)]
		public double EarnedCredits { get; set; }

		[DataMember(Order = 4)]
		public double EarnedUridium { get; set; }

		[DataMember(Order = 5)]
		public double CreditsPerHour { get; set; }

		[DataMember(Order = 6)]
		public double UridiumPerHour { get; set; }

		[DataMember(Order = 7)]
		public string Uptime { get; set; }

		[DataMember(Order = 8)]
		public int DeathCount { get; set; }

		public BotSummaryViewModel()
		{
		}

		public BotSummaryViewModel(Hero hero, BotStats stats, TimeSpan uptime)
		{
			DateTime now = DateTime.Now;
			this.Credits = hero.Credits;
			this.Uridium = hero.Uridium;
			this.EarnedCredits = stats.EarnedCredits;
			this.EarnedUridium = stats.EarnedUridium;
			this.CreditsPerHour = stats.EarnedCredits / (uptime.TotalSeconds + 1.0) * 3600.0;
			this.UridiumPerHour = stats.EarnedUridium / (uptime.TotalSeconds + 1.0) * 3600.0;
			this.Uptime = uptime.ToString("hh\\:mm\\:ss");
			this.DeathCount = stats.Deaths;
		}
	}
}
