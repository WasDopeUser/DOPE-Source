using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DarkorbitAPI.CommonStructures;

public class GClass799 : GClass793
{
	[CompilerGenerated]
	public GClass806 method_0()
	{
		return this.YtGootqtmBO;
	}

	[CompilerGenerated]
	private void method_1(GClass806 gclass806_1)
	{
		this.YtGootqtmBO = gclass806_1;
	}

	[CompilerGenerated]
	public GClass806 method_2()
	{
		return this.gclass806_0;
	}

	[CompilerGenerated]
	private void method_3(GClass806 gclass806_1)
	{
		this.gclass806_0 = gclass806_1;
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
		this.method_1(new GClass806(new Vector<uint>(vector2), new Vector<uint>(vector)));
		this.method_3(new GClass806(vector2, vector));
	}

	public GClass799()
	{
		Class13.igxcIukzfpare();
		base..ctor();
	}

	[CompilerGenerated]
	private GClass806 YtGootqtmBO;

	[CompilerGenerated]
	private GClass806 gclass806_0;
}
