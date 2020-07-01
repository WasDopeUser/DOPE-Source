using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass515 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 6016;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 22;
		}
	}

	public GClass515(int int_4 = 0, int int_5 = 0, string string_1 = "", GClass656 gclass656_0 = null, GClass781 gclass781_1 = null, int int_6 = 0, int int_7 = 0, int int_8 = 0)
	{
		Class13.F93tSdiz1aNIA();
		this.string_0 = "";
		base..ctor();
		this.int_0 = int_4;
		this.int_1 = int_5;
		this.string_0 = string_1;
		if (gclass656_0 == null)
		{
			this.Progress = new GClass656(0, 0.0, 0.0, "", "", null, false);
		}
		else
		{
			this.Progress = gclass656_0;
		}
		if (gclass781_1 == null)
		{
			this.gclass781_0 = new GClass781(null);
		}
		else
		{
			this.gclass781_0 = gclass781_1;
		}
		this.int_2 = int_6;
		this.int_3 = int_7;
		this.uxjbarkRbl = int_8;
	}

	public virtual int vmethod_0()
	{
		return 6016;
	}

	public virtual int vmethod_1()
	{
		return 22;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 4 | U.smethod_0(this.int_0, 28));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 14 | U.smethod_0(this.int_1, 18));
		this.string_0 = binaryStream_0.smethod_2();
		this.Progress = (GClass656)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.Progress != null)
		{
			this.Progress.imethod_0(binaryStream_0);
		}
		this.gclass781_0 = (GClass781)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass781_0 != null)
		{
			this.gclass781_0.imethod_0(binaryStream_0);
		}
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 1) | this.int_2 << 31);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 5) | this.int_3 << 27);
		this.uxjbarkRbl = binaryStream_0.smethod_0();
		this.uxjbarkRbl = (U.smethod_0(this.uxjbarkRbl, 10) | this.uxjbarkRbl << 22);
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(6016);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 4) | this.int_0 << 28);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 14) | this.int_1 << 18);
		binaryStream_0.smethod_3(this.string_0);
		if (this.Progress != null)
		{
			this.Progress.imethod_1(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass781_0 != null)
		{
			this.gclass781_0.imethod_1(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_4(this.int_2 << 1 | U.smethod_0(this.int_2, 31));
		binaryStream_0.smethod_4(this.int_3 << 5 | U.smethod_0(this.int_3, 27));
		binaryStream_0.smethod_4(this.uxjbarkRbl << 10 | U.smethod_0(this.uxjbarkRbl, 22));
	}

	public int int_0;

	public int int_1;

	public string string_0;

	public GClass656 Progress;

	public GClass781 gclass781_0;

	public int int_2;

	public int int_3;

	public int uxjbarkRbl;
}
