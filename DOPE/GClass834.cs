using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass834 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -22529;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 9;
		}
	}

	public GClass834(int int_2 = 0, int int_3 = 0, bool bool_0 = false)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		this.ofVgXrngqk = bool_0;
		this.int_0 = int_3;
		this.int_1 = int_2;
	}

	public virtual int vmethod_0()
	{
		return -22529;
	}

	public virtual int vmethod_1()
	{
		return 9;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.ofVgXrngqk = binaryStream_0.ReadBoolean();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 15 | U.smethod_0(this.int_0, 17));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 13) | this.int_1 << 19);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-22529);
		binaryStream_0.WriteBoolean(this.ofVgXrngqk);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 15) | this.int_0 << 17);
		binaryStream_0.smethod_4(this.int_1 << 13 | U.smethod_0(this.int_1, 19));
	}

	public bool ofVgXrngqk;

	public int int_0;

	public int int_1;
}
