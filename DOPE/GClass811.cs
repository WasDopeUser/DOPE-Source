using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DarkorbitAPI.CommonStructures;

public class GClass811 : GClass808
{
	[CompilerGenerated]
	public GClass818 method_0()
	{
		return this.gclass818_0;
	}

	[CompilerGenerated]
	private void method_1(GClass818 gclass818_2)
	{
		this.gclass818_0 = gclass818_2;
	}

	[CompilerGenerated]
	public GClass818 method_2()
	{
		return this.gclass818_1;
	}

	[CompilerGenerated]
	private void method_3(GClass818 gclass818_2)
	{
		this.gclass818_1 = gclass818_2;
	}

	public override void imethod_2()
	{
	}

	public override void imethod_1(byte[] byte_0, int int_0, int int_1)
	{
		this.method_2().vmethod_0(byte_0, int_0, int_1);
	}

	public override void imethod_0(byte[] byte_0, int int_0, int int_1)
	{
		this.method_0().vmethod_0(byte_0, int_0, int_1);
	}

	public override void Init(List<byte[]> list_0)
	{
		if (list_0.Count != 2)
		{
			throw new Exception();
		}
		ByteArray byteArray = new ByteArray();
		ByteArray byteArray2 = new ByteArray();
		foreach (byte value in list_0[0])
		{
			byteArray.Memory.WriteByte(value);
		}
		foreach (byte value2 in list_0[1])
		{
			byteArray2.Memory.WriteByte(value2);
		}
		byteArray.Memory.Position = 0L;
		byteArray2.Memory.Position = 0L;
		this.method_1(new GClass818(new ByteArray(byteArray), new ByteArray(byteArray2)));
		this.method_3(new GClass818(byteArray, byteArray2));
	}

	public GClass811()
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
	}

	[CompilerGenerated]
	private GClass818 gclass818_0;

	[CompilerGenerated]
	private GClass818 gclass818_1;
}
