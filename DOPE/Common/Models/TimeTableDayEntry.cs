using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace DOPE.Common.Models
{
	[Guid("D5226792-3A9E-4762-AC1B-CDC08F9D4286")]
	[DataContract]
	public class TimeTableDayEntry
	{
		[DataMember(Order = 1)]
		public List<string> Schedule { get; set; }

		public void Fill()
		{
			if (this.Schedule == null)
			{
				this.Schedule = new List<string>();
			}
			for (int i = 0; i < 24; i++)
			{
				if (this.Schedule.Count <= i)
				{
					this.Schedule.Add(null);
				}
			}
			this.Schedule = this.Schedule.Take(24).ToList<string>();
		}
	}
}
