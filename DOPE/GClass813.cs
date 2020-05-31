using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DarkorbitAPI.CommonStructures;

public class GClass813 : GClass808
{
	[CompilerGenerated]
	public GClass820 method_0()
	{
		return this.gclass820_0;
	}

	[CompilerGenerated]
	private void method_1(GClass820 gclass820_2)
	{
		this.gclass820_0 = gclass820_2;
	}

	[CompilerGenerated]
	public GClass820 method_2()
	{
		return this.gclass820_1;
	}

	[CompilerGenerated]
	private void method_3(GClass820 gclass820_2)
	{
		this.gclass820_1 = gclass820_2;
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
		this.method_1(new GClass820(new Vector<uint>(vector), new Vector<uint>(vector2)));
		this.method_3(new GClass820(vector, vector2));
	}

	public GClass813()
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
	}

	[CompilerGenerated]
	private GClass820 gclass820_0;

	[CompilerGenerated]
	private GClass820 gclass820_1;
}
