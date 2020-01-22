using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using DOPE.Common.Models.Spacemap;

namespace DOPE.Common.Models.Bot
{
	[Guid("CB44A59A-26FF-4C77-AC01-03D14DAAA767")]
	[DataContract]
	public class BotDetailedViewModel
	{
		[DataMember(Order = 1)]
		public MapViewData Spacemap { get; set; }

		[DataMember(Order = 2)]
		public string BotId { get; set; }

		[DataMember(Order = 3)]
		public BotSummaryViewModel Summary { get; set; }
	}
}
