using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DarkorbitAPI.CommonStructures;

public class GClass785 : GClass781
{
	[CompilerGenerated]
	public GClass792 method_0()
	{
		return this.gclass792_0;
	}

	[CompilerGenerated]
	private void ivazqjrfMn(GClass792 gclass792_2)
	{
		this.gclass792_0 = gclass792_2;
	}

	[CompilerGenerated]
	public GClass792 method_1()
	{
		return this.gclass792_1;
	}

	[CompilerGenerated]
	private void method_2(GClass792 gclass792_2)
	{
		this.gclass792_1 = gclass792_2;
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
		this.method_0().vmethod_0(byte_0, int_0, int_1);
	}

	public override void Init(List<byte[]> list_0)
	{
		if (list_0.Count != 2)
		{
			throw new Exception();
		}
		Vector<uint> vector = new Vector<uint>();
		Vector<uint> vector2 = new Vector<uint>();
		foreach (byte item in list_0[0])
		{
			vector.Add((uint)item);
		}
		foreach (byte item2 in list_0[1])
		{
			vector2.Add((uint)item2);
		}
		if (vector.Length != 12)
		{
			Vector<uint> vector3 = vector2;
			Vector<uint> vector4 = vector;
			vector = vector3;
			vector2 = vector4;
		}
		this.ivazqjrfMn(new GClass792(new Vector<uint>(vector), new Vector<uint>(vector2)));
		this.method_2(new GClass792(new Vector<uint>(vector), new Vector<uint>(vector2)));
	}

	public GClass785()
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
	}

	[CompilerGenerated]
	private GClass792 gclass792_0;

	[CompilerGenerated]
	private GClass792 gclass792_1;
}
