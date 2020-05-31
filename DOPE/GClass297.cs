using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass297 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 12114;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass297(int int_1 = 0, int int_2 = 0)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		this.oIheiDaqGn = int_1;
		this.int_0 = int_2;
	}

	public virtual int vmethod_0()
	{
		return 12114;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.oIheiDaqGn = binaryStream_0.smethod_0();
		this.oIheiDaqGn = (this.oIheiDaqGn << 14 | U.smethod_0(this.oIheiDaqGn, 18));
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 13 | U.smethod_0(this.int_0, 19));
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(12114);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.oIheiDaqGn, 14) | this.oIheiDaqGn << 18);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 13) | this.int_0 << 19);
	}

	public int oIheiDaqGn;

	public int int_0;
}
