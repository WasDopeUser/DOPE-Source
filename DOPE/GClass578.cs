﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass578 : GClass573, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 27439;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 5;
		}
	}

	public GClass578(string string_0 = "", bool bool_0 = false)
	{
		Class8.xDph7tozmh5WD();
		base..ctor(string_0);
		this.Value = bool_0;
	}

	public override int vmethod_0()
	{
		return 27439;
	}

	public override int vmethod_1()
	{
		return 5;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.Value = binaryStream_0.ReadBoolean();
		binaryStream_0.smethod_1();
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(27439);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.WriteBoolean(this.Value);
		binaryStream_0.smethod_5(-34);
	}

	public bool Value;
}