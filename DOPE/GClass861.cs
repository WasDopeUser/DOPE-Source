using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DarkorbitAPI.CommonStructures;

public class GClass861 : GClass858
{
	[CompilerGenerated]
	public GClass868 XduwcinXdfh()
	{
		return this.gclass868_0;
	}

	[CompilerGenerated]
	private void method_0(GClass868 gclass868_2)
	{
		this.gclass868_0 = gclass868_2;
	}

	[CompilerGenerated]
	public GClass868 method_1()
	{
		return this.gclass868_1;
	}

	[CompilerGenerated]
	private void method_2(GClass868 gclass868_2)
	{
		this.gclass868_1 = gclass868_2;
	}

	public override void imethod_2()
	{
	}

	public override void imethod_1(byte[] byte_0, int int_0, int int_1)
	{
		this.method_1().vmethod_0(byte_0, int_0, int_1);
	}

	public override void imethod_0(byte[] byte_0, int int_0, int int_1)
	{
		this.XduwcinXdfh().vmethod_0(byte_0, int_0, int_1);
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
		this.method_0(new GClass868(new ByteArray(byteArray), new ByteArray(byteArray2)));
		this.method_2(new GClass868(byteArray, byteArray2));
	}

	public GClass861()
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
	}

	[CompilerGenerated]
	private GClass868 gclass868_0;

	[CompilerGenerated]
	private GClass868 gclass868_1;
}
