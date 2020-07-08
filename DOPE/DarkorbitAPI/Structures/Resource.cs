using System;

namespace DarkorbitAPI.Structures
{
	public class Resource : Collectible
	{
		public Resource(int int_0, int int_1, int int_2, string string_0)
		{
			Class13.xnk8ImWzpOt04();
			base..ctor(int_0, int_1, int_2.ToString(), string_0);
		}

		public int ResourceId { get; set; }

		public override GEnum6 CollectibleType
		{
			get
			{
				if (this.ResourceId != 8)
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
				int resourceId;
				if (int.TryParse(value, out resourceId))
				{
					this.ResourceId = resourceId;
				}
			}
		}
	}
}
