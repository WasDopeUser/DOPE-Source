using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass306 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 3530;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 2;
		}
	}

	public GClass306(string string_1 = "", GClass187 gclass187_0 = null)
	{
		Class13.F93tSdiz1aNIA();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
		if (gclass187_0 == null)
		{
			this.MueDpmlwuN = new GClass187(0, 0, 0, "", 0, false);
			return;
		}
		this.MueDpmlwuN = gclass187_0;
	}

	public virtual int vmethod_0()
	{
		return 3530;
	}

	public virtual int vmethod_1()
	{
		return 2;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
		this.MueDpmlwuN = (GClass187)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.MueDpmlwuN != null)
		{
			this.MueDpmlwuN.imethod_0(binaryStream_0);
		}
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(3530);
		binaryStream_0.smethod_3(this.string_0);
		if (this.MueDpmlwuN != null)
		{
			this.MueDpmlwuN.imethod_1(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public string string_0;

	public GClass187 MueDpmlwuN;
}
