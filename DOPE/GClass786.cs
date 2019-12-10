using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DarkorbitAPI.CommonStructures;

public class GClass786 : GClass781
{
	[CompilerGenerated]
	public GClass793 method_0()
	{
		return this.gclass793_0;
	}

	[CompilerGenerated]
	private void method_1(GClass793 gclass793_2)
	{
		this.gclass793_0 = gclass793_2;
	}

	[CompilerGenerated]
	public GClass793 method_2()
	{
		return this.gclass793_1;
	}

	[CompilerGenerated]
	private void method_3(GClass793 gclass793_2)
	{
		this.gclass793_1 = gclass793_2;
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
		this.method_1(new GClass793(new Vector<uint>(vector), new Vector<uint>(vector2)));
		this.method_3(new GClass793(vector, vector2));
	}

	public GClass786()
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
	}

	[CompilerGenerated]
	private GClass793 gclass793_0;

	[CompilerGenerated]
	private GClass793 gclass793_1;
}
