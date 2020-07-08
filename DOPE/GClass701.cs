using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass701 : GClass700, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 6120;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass701(int int_0 = 0, int int_1 = 0)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		this.lcdJlrdihm = int_1;
		this.MapId = int_0;
	}

	public override int vmethod_0()
	{
		return 6120;
	}

	public override int vmethod_1()
	{
		return 4;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		base.imethod_1(binaryStream_0);
		this.lcdJlrdihm = (int)binaryStream_0.smethod_1();
		this.MapId = binaryStream_0.smethod_0();
		this.MapId = (U.smethod_0(this.MapId, 12) | this.MapId << 20);
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(6120);
		base.imethod_2(binaryStream_0);
		binaryStream_0.smethod_7(this.lcdJlrdihm);
		binaryStream_0.smethod_4(this.MapId << 12 | U.smethod_0(this.MapId, 20));
	}

	public int lcdJlrdihm;

	public int MapId;
}
