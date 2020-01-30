using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DarkorbitAPI.CommonStructures;

public class GClass796 : GClass792
{
	[CompilerGenerated]
	public GClass803 method_0()
	{
		return this.gclass803_0;
	}

	[CompilerGenerated]
	private void method_1(GClass803 gclass803_2)
	{
		this.gclass803_0 = gclass803_2;
	}

	[CompilerGenerated]
	public GClass803 method_2()
	{
		return this.gclass803_1;
	}

	[CompilerGenerated]
	private void method_3(GClass803 gclass803_2)
	{
		this.gclass803_1 = gclass803_2;
	}

	public override void imethod_1()
	{
	}

	public override void imethod_0(byte[] byte_0, int int_0, int int_1)
	{
		this.method_2().vmethod_0(byte_0, int_0, int_1);
	}

	public override void UmklIaSsoWi(byte[] byte_0, int int_0, int int_1)
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
		this.method_1(new GClass803(new Vector<uint>(vector), new Vector<uint>(vector2)));
		this.method_3(new GClass803(new Vector<uint>(vector), new Vector<uint>(vector2)));
	}

	public GClass796()
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
	}

	[CompilerGenerated]
	private GClass803 gclass803_0;

	[CompilerGenerated]
	private GClass803 gclass803_1;
}
