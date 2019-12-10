using System;

namespace DarkorbitAPI.Structures
{
	public class Collectible : Entity
	{
		public virtual string Type { get; set; }

		public string Hash { get; set; }

		public Collectible(int int_0, int int_1, string string_0, string string_1)
		{
			Class8.xDph7tozmh5WD();
			base..ctor(int_0, int_1);
			this.Type = string_0;
			this.Hash = string_1;
		}

		public virtual GEnum6 CollectibleType
		{
			get
			{
				return GClass89.smethod_0(this.Type);
			}
		}
	}
}
