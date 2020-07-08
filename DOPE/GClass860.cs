using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DarkorbitAPI.CommonStructures;

public class GClass860 : GClass858
{
	[CompilerGenerated]
	public GClass867 method_0()
	{
		return this.gclass867_0;
	}

	[CompilerGenerated]
	private void method_1(GClass867 gclass867_2)
	{
		this.gclass867_0 = gclass867_2;
	}

	[CompilerGenerated]
	public GClass867 method_2()
	{
		return this.gclass867_1;
	}

	[CompilerGenerated]
	private void method_3(GClass867 gclass867_2)
	{
		this.gclass867_1 = gclass867_2;
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
		this.method_1(new GClass867(new Vector<uint>(vector2), new Vector<uint>(vector)));
		this.method_3(new GClass867(vector2, vector));
	}

	public GClass860()
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
	}

	[CompilerGenerated]
	private GClass867 gclass867_0;

	[CompilerGenerated]
	private GClass867 gclass867_1;
}
