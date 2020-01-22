using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

namespace MtkeutgfChvicmSfwvH
{
	public class GClass191 : GInterface0
	{
		short GInterface0.Id
		{
			get
			{
				return 13774;
			}
		}

		int GInterface0.SizeBytes
		{
			get
			{
				return 4;
			}
		}

		public GClass191(int int_0 = 0)
		{
			Class13.plZSWFPzBWWEZ();
			base..ctor();
			this.Id = int_0;
		}

		public virtual int vmethod_0()
		{
			return 13774;
		}

		public virtual int vmethod_1()
		{
			return 4;
		}

		public virtual void imethod_1(BinaryStream binaryStream_0)
		{
			this.Id = binaryStream_0.smethod_0();
			this.Id = (U.smethod_0(this.Id, 8) | this.Id << 24);
			binaryStream_0.smethod_1();
		}

		public virtual void imethod_2(BinaryStream binaryStream_0)
		{
			binaryStream_0.smethod_7(13774);
			this.vmethod_2(binaryStream_0);
		}

		protected virtual void vmethod_2(BinaryStream binaryStream_0)
		{
			binaryStream_0.smethod_4(this.Id << 8 | U.smethod_0(this.Id, 24));
			binaryStream_0.smethod_7(-32281);
		}

		public int Id;
	}
}
