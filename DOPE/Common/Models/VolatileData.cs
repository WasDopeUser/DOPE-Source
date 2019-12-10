using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace DOPE.Common.Models
{
	[DataContract]
	[Guid("057F555B-E0F8-4B7A-AA84-D48C61BFD8AB")]
	public class VolatileData
	{
		[DataMember(Order = 1)]
		public DateTimeOffset LastUpdated { get; set; }

		[DataMember(Order = 2)]
		public List<string> Hangars { get; set; }

		[DataMember(Order = 3)]
		public string ActiveHangar { get; set; }

		public VolatileData Fill()
		{
			DateTimeOffset dateTimeOffset = DateTimeOffset.Parse("2019-01-01");
			if (this.LastUpdated < dateTimeOffset)
			{
				this.LastUpdated = dateTimeOffset;
			}
			List<string> hangars = this.Hangars;
			return this;
		}

		public bool CheckConstraints()
		{
			if (this.Hangars != null)
			{
				if (this.Hangars.Count > 200)
				{
					return false;
				}
				using (List<string>.Enumerator enumerator = this.Hangars.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						string text = enumerator.Current;
						if (text != null && text.Length > 64)
						{
							return false;
						}
					}
					goto IL_63;
				}
				bool result;
				return result;
			}
			IL_63:
			string activeHangar = this.ActiveHangar;
			return activeHangar == null || activeHangar.Length <= 64;
		}
	}
}
