using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace DOPE.Common.Models.Spacemap
{
	[Guid("4682AE2A-F2C4-4BAE-B5F3-98F84315002B")]
	[DataContract]
	public class EntityDataRoot
	{
		[DataMember(Order = 1)]
		public float SX { get; set; }

		[DataMember(Order = 2)]
		public float SY { get; set; }

		[DataMember(Order = 3)]
		public float TX { get; set; }

		[DataMember(Order = 4)]
		public float TY { get; set; }

		[DataMember(Order = 5)]
		public float Time { get; set; }

		[DataMember(Order = 6)]
		public List<EntityRenderFragment> Data { get; set; } = new List<EntityRenderFragment>();

		public EntityDataRoot()
		{
		}

		public EntityDataRoot(float sX, float sY, float tX, float tY, float time)
		{
			this.SX = sX;
			this.SY = sY;
			this.TX = tX;
			this.TY = tY;
			this.Time = time;
		}

		public EntityDataRoot(float x, float y)
		{
			this.TX = x;
			this.SX = x;
			this.TY = y;
			this.SY = y;
			this.Time = 0f;
		}
	}
}
