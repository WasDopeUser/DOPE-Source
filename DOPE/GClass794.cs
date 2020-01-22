using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DarkorbitAPI.CommonStructures;

public class GClass794 : GClass791
{
	[CompilerGenerated]
	public GClass801 method_0()
	{
		return this.gclass801_0;
	}

	[CompilerGenerated]
	private void method_1(GClass801 gclass801_2)
	{
		this.gclass801_0 = gclass801_2;
	}

	[CompilerGenerated]
	public GClass801 method_2()
	{
		return this.gclass801_1;
	}

	[CompilerGenerated]
	private void method_3(GClass801 gclass801_2)
	{
		this.gclass801_1 = gclass801_2;
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
		this.method_1(new GClass801(new ByteArray(byteArray), new ByteArray(byteArray2)));
		this.method_3(new GClass801(byteArray, byteArray2));
	}

	public GClass794()
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
	}

	[CompilerGenerated]
	private GClass801 gclass801_0;

	[CompilerGenerated]
	private GClass801 gclass801_1;
}
