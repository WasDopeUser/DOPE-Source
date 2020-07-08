using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DarkorbitAPI.CommonStructures;

public class GClass863 : GClass858
{
	[CompilerGenerated]
	public GClass870 method_0()
	{
		return this.gclass870_0;
	}

	[CompilerGenerated]
	private void method_1(GClass870 gclass870_2)
	{
		this.gclass870_0 = gclass870_2;
	}

	[CompilerGenerated]
	public GClass870 method_2()
	{
		return this.gclass870_1;
	}

	[CompilerGenerated]
	private void method_3(GClass870 gclass870_2)
	{
		this.gclass870_1 = gclass870_2;
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
		this.method_1(new GClass870(new Vector<uint>(vector), new Vector<uint>(vector2)));
		this.method_3(new GClass870(vector, vector2));
	}

	public GClass863()
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
	}

	[CompilerGenerated]
	private GClass870 gclass870_0;

	[CompilerGenerated]
	private GClass870 gclass870_1;
}
