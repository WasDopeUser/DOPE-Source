using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass353 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 15119;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 13;
		}
	}

	public GClass353(int int_3 = 0, int int_4 = 0, bool bool_1 = false, int int_5 = 0, GClass318 gclass318_0 = null)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.int_0 = int_3;
		this.int_1 = int_4;
		this.bool_0 = bool_1;
		this.int_2 = int_5;
		if (gclass318_0 == null)
		{
			this.PbrhOtnwtn = new GClass318(0U);
			return;
		}
		this.PbrhOtnwtn = gclass318_0;
	}

	public virtual int vmethod_0()
	{
		return 15119;
	}

	public virtual int vmethod_1()
	{
		return 13;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 2 | U.smethod_0(this.int_0, 30));
		binaryStream_0.smethod_1();
		this.PbrhOtnwtn = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass318);
		this.PbrhOtnwtn.imethod_1(binaryStream_0);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 11 | U.smethod_0(this.int_1, 21));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 1 | U.smethod_0(this.int_2, 31));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(15119);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 2) | this.int_0 << 30);
		binaryStream_0.smethod_7(-14129);
		this.PbrhOtnwtn.imethod_2(binaryStream_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 11) | this.int_1 << 21);
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 1) | this.int_2 << 31);
	}

	public bool bool_0;

	public int int_0;

	public GClass318 PbrhOtnwtn;

	public int int_1;

	public int int_2;
}
