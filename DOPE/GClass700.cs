using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass700 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 25802;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass700(int int_1 = 0, int int_2 = 0, double double_0 = 0.0)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		this.jIcyvNbAbm = int_1;
		this.int_0 = int_2;
		this.JprySeaWmS = double_0;
	}

	public virtual int vmethod_0()
	{
		return 25802;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.jIcyvNbAbm = binaryStream_0.smethod_0();
		this.jIcyvNbAbm = (this.jIcyvNbAbm << 9 | U.smethod_0(this.jIcyvNbAbm, 23));
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 5) | this.int_0 << 27);
		this.JprySeaWmS = (double)binaryStream_0.smethod_10();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(25802);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.jIcyvNbAbm, 9) | this.jIcyvNbAbm << 23);
		binaryStream_0.smethod_4(this.int_0 << 5 | U.smethod_0(this.int_0, 27));
		binaryStream_0.smethod_9(this.JprySeaWmS);
	}

	public int jIcyvNbAbm;

	public int int_0;

	public double JprySeaWmS;
}
