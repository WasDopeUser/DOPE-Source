using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DarkorbitAPI.CommonStructures;

public class GClass862 : GClass858
{
	[CompilerGenerated]
	public GClass869 BqtwchaxMpG()
	{
		return this.gclass869_0;
	}

	[CompilerGenerated]
	private void method_0(GClass869 gclass869_2)
	{
		this.gclass869_0 = gclass869_2;
	}

	[CompilerGenerated]
	public GClass869 method_1()
	{
		return this.gclass869_1;
	}

	[CompilerGenerated]
	private void method_2(GClass869 gclass869_2)
	{
		this.gclass869_1 = gclass869_2;
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
		this.BqtwchaxMpG().vmethod_0(byte_0, int_0, int_1);
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
		this.method_0(new GClass869(new Vector<uint>(vector), new Vector<uint>(vector2)));
		this.method_2(new GClass869(new Vector<uint>(vector), new Vector<uint>(vector2)));
	}

	public GClass862()
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
	}

	[CompilerGenerated]
	private GClass869 gclass869_0;

	[CompilerGenerated]
	private GClass869 gclass869_1;
}
