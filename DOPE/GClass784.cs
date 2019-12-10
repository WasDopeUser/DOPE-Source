using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DarkorbitAPI.CommonStructures;

public class GClass784 : GClass781
{
	[CompilerGenerated]
	public GClass791 method_0()
	{
		return this.gclass791_0;
	}

	[CompilerGenerated]
	private void method_1(GClass791 gclass791_2)
	{
		this.gclass791_0 = gclass791_2;
	}

	[CompilerGenerated]
	public GClass791 method_2()
	{
		return this.gclass791_1;
	}

	[CompilerGenerated]
	private void method_3(GClass791 gclass791_2)
	{
		this.gclass791_1 = gclass791_2;
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
		this.method_1(new GClass791(new ByteArray(byteArray), new ByteArray(byteArray2)));
		this.method_3(new GClass791(byteArray, byteArray2));
	}

	public GClass784()
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
	}

	[CompilerGenerated]
	private GClass791 gclass791_0;

	[CompilerGenerated]
	private GClass791 gclass791_1;
}
