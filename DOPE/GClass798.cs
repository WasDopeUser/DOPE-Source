using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DarkorbitAPI.CommonStructures;

public class GClass798 : GClass792
{
	[CompilerGenerated]
	public GClass805 method_0()
	{
		return this.gclass805_0;
	}

	[CompilerGenerated]
	private void method_1(GClass805 gclass805_2)
	{
		this.gclass805_0 = gclass805_2;
	}

	[CompilerGenerated]
	public GClass805 method_2()
	{
		return this.gclass805_1;
	}

	[CompilerGenerated]
	private void method_3(GClass805 gclass805_2)
	{
		this.gclass805_1 = gclass805_2;
	}

	public override void imethod_1()
	{
	}

	public override void imethod_0(byte[] byte_0, int int_0, int int_1)
	{
		this.method_2().PlllIjfyZu3(byte_0, int_0, int_1);
	}

	public override void UmklIaSsoWi(byte[] byte_0, int int_0, int int_1)
	{
		this.method_0().PlllIjfyZu3(byte_0, int_0, int_1);
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
		this.method_1(new GClass805(new Vector<uint>(vector2), new Vector<uint>(vector)));
		this.method_3(new GClass805(vector2, vector));
	}

	public GClass798()
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
	}

	[CompilerGenerated]
	private GClass805 gclass805_0;

	[CompilerGenerated]
	private GClass805 gclass805_1;
}
