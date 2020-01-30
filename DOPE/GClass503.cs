using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass503 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 5488;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 22;
		}
	}

	public GClass503(int int_4 = 0, int int_5 = 0, string string_1 = "", GClass615 gclass615_0 = null, GClass721 gclass721_1 = null, int int_6 = 0, int int_7 = 0, int int_8 = 0)
	{
		Class13.Gj4N3WdzaR1LY();
		this.string_0 = "";
		base..ctor();
		this.ihkOeFsmmO = int_4;
		this.int_2 = int_5;
		this.string_0 = string_1;
		if (gclass615_0 == null)
		{
			this.Progress = new GClass615(0, 0.0, 0.0, "", "", null, false);
		}
		else
		{
			this.Progress = gclass615_0;
		}
		if (gclass721_1 == null)
		{
			this.gclass721_0 = new GClass721(null);
		}
		else
		{
			this.gclass721_0 = gclass721_1;
		}
		this.int_0 = int_6;
		this.int_1 = int_7;
		this.int_3 = int_8;
	}

	public virtual int vmethod_0()
	{
		return 5488;
	}

	public virtual int vmethod_1()
	{
		return 22;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 16 | U.smethod_0(this.int_0, 16));
		this.gclass721_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass721);
		this.gclass721_0.imethod_1(binaryStream_0);
		this.Progress = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass615);
		this.Progress.imethod_1(binaryStream_0);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 9 | U.smethod_0(this.int_1, 23));
		this.ihkOeFsmmO = binaryStream_0.smethod_0();
		this.ihkOeFsmmO = (this.ihkOeFsmmO << 11 | U.smethod_0(this.ihkOeFsmmO, 21));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 9) | this.int_2 << 23);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 16 | U.smethod_0(this.int_3, 16));
		this.string_0 = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(5488);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 16) | this.int_0 << 16);
		this.gclass721_0.imethod_2(binaryStream_0);
		this.Progress.imethod_2(binaryStream_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 9) | this.int_1 << 23);
		binaryStream_0.smethod_4(U.smethod_0(this.ihkOeFsmmO, 11) | this.ihkOeFsmmO << 21);
		binaryStream_0.smethod_4(this.int_2 << 9 | U.smethod_0(this.int_2, 23));
		binaryStream_0.smethod_4(U.smethod_0(this.int_3, 16) | this.int_3 << 16);
		binaryStream_0.smethod_3(this.string_0);
	}

	public int int_0;

	public GClass721 gclass721_0;

	public GClass615 Progress;

	public int int_1;

	public int ihkOeFsmmO;

	public int int_2;

	public int int_3;

	public string string_0;
}
