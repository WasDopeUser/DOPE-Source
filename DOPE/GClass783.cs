using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DarkorbitAPI.CommonStructures;

public class GClass783 : GClass781
{
	[CompilerGenerated]
	public GClass790 method_0()
	{
		return this.gclass790_0;
	}

	[CompilerGenerated]
	private void method_1(GClass790 gclass790_2)
	{
		this.gclass790_0 = gclass790_2;
	}

	[CompilerGenerated]
	public GClass790 method_2()
	{
		return this.gclass790_1;
	}

	[CompilerGenerated]
	private void method_3(GClass790 gclass790_2)
	{
		this.gclass790_1 = gclass790_2;
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
		this.method_1(new GClass790(new Vector<uint>(vector2), new Vector<uint>(vector)));
		this.method_3(new GClass790(vector2, vector));
	}

	public GClass783()
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
	}

	[CompilerGenerated]
	private GClass790 gclass790_0;

	[CompilerGenerated]
	private GClass790 gclass790_1;
}
