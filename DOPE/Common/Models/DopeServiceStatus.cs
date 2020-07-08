using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace DOPE.Common.Models
{
	[DataContract]
	[Guid("CB97D19B-EABB-4D5B-A517-D914CC96AA76")]
	public class DopeServiceStatus
	{
		[DataMember(Order = 1)]
		public bool EnabledGG { get; set; }

		[DataMember(Order = 2)]
		public Dictionary<string, string> Versions { get; set; }

		[DataMember(Order = 3)]
		public List<string> BreakingNews { get; set; }

		[DataMember(Order = 4)]
		public bool ClientOutOfDate { get; set; }

		[DataMember(Order = 5)]
		public bool ProtocolOutOfDate { get; set; }

		public DopeServiceStatus()
		{
			this.Versions = new Dictionary<string, string>();
			this.BreakingNews = new List<string>();
		}

		public DopeServiceStatus(DopeServiceStatus status)
		{
			this.EnabledGG = status.EnabledGG;
			this.Versions = status.Versions;
			this.ProtocolOutOfDate = status.ProtocolOutOfDate;
			this.BreakingNews = new List<string>(status.BreakingNews);
		}
	}
}
