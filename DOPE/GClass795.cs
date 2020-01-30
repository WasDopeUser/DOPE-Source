using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DarkorbitAPI.CommonStructures;

public class GClass795 : GClass792
{
	[CompilerGenerated]
	public GClass802 method_0()
	{
		return this.gclass802_0;
	}

	[CompilerGenerated]
	private void method_1(GClass802 gclass802_2)
	{
		this.gclass802_0 = gclass802_2;
	}

	[CompilerGenerated]
	public GClass802 method_2()
	{
		return this.gclass802_1;
	}

	[CompilerGenerated]
	private void method_3(GClass802 gclass802_2)
	{
		this.gclass802_1 = gclass802_2;
	}

	public override void imethod_1()
	{
	}

	public override void imethod_0(byte[] byte_0, int int_0, int int_1)
	{
		this.method_2().CoXlIiUqGgZ(byte_0, int_0, int_1);
	}

	public override void UmklIaSsoWi(byte[] byte_0, int int_0, int int_1)
	{
		this.method_0().CoXlIiUqGgZ(byte_0, int_0, int_1);
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
		this.method_1(new GClass802(new ByteArray(byteArray), new ByteArray(byteArray2)));
		this.method_3(new GClass802(byteArray, byteArray2));
	}

	public GClass795()
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
	}

	[CompilerGenerated]
	private GClass802 gclass802_0;

	[CompilerGenerated]
	private GClass802 gclass802_1;
}
