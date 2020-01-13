using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass422 : GClass421, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 7753;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 25;
		}
	}

	public GClass422(string string_2 = "", bool bool_1 = false, GClass359 gclass359_1 = null, string string_3 = "", int int_3 = 0, int int_4 = 0, int int_5 = 0, int int_6 = 0, bool bool_2 = false, GClass359 gclass359_2 = null)
	{
		Class13.tMHx78BzgCM8j();
		this.string_1 = "";
		base..ctor(string_2, bool_1, gclass359_1);
		this.string_1 = string_3;
		this.int_0 = int_3;
		this.int_2 = int_4;
		this.Width = int_5;
		this.int_1 = int_6;
		this.bool_0 = bool_2;
		if (gclass359_2 == null)
		{
			this.gclass359_0 = new GClass359(null);
			return;
		}
		this.gclass359_0 = gclass359_2;
	}

	public override int vmethod_0()
	{
		return 7753;
	}

	public override int vmethod_1()
	{
		return 25;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 3 | U.smethod_0(this.int_0, 29));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 5) | this.int_1 << 27);
		this.Width = binaryStream_0.smethod_0();
		this.Width = (this.Width << 5 | U.smethod_0(this.Width, 27));
		this.bool_0 = binaryStream_0.ReadBoolean();
		binaryStream_0.smethod_1();
		this.gclass359_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass359);
		this.gclass359_0.imethod_1(binaryStream_0);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 7 | U.smethod_0(this.int_2, 25));
		this.string_1 = binaryStream_0.smethod_2();
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(7753);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 3) | this.int_0 << 29);
		binaryStream_0.smethod_4(this.int_1 << 5 | U.smethod_0(this.int_1, 27));
		binaryStream_0.smethod_4(U.smethod_0(this.Width, 5) | this.Width << 27);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_7(964);
		this.gclass359_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 7) | this.int_2 << 25);
		binaryStream_0.smethod_3(this.string_1);
	}

	public int int_0;

	public int int_1;

	public int Width;

	public bool bool_0;

	public GClass359 gclass359_0;

	public int int_2;

	public string string_1;
}
