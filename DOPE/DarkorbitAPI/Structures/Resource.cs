using System;

namespace DarkorbitAPI.Structures
{
	public class Resource : Collectible
	{
		public Resource(int int_0, int int_1, uint uint_0, string string_0)
		{
			Class13.igxcIukzfpare();
			base..ctor(int_0, int_1, uint_0.ToString(), string_0);
		}

		public uint ResourceId { get; set; }

		public override GEnum6 CollectibleType
		{
			get
			{
				if (this.ResourceId != 8U)
				{
					return (GEnum6)1;
				}
				return (GEnum6)2;
			}
		}

		public override string Type
		{
			get
			{
				return this.ResourceId.ToString();
			}
			set
			{
				uint resourceId;
				if (uint.TryParse(value, out resourceId))
				{
					this.ResourceId = resourceId;
				}
			}
		}
	}
}
