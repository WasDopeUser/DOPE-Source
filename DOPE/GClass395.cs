﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass395 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 127;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass395(GClass428 gclass428_1 = null, bool bool_2 = false, bool bool_3 = false, string string_1 = "")
	{
		Class13.xnk8ImWzpOt04();
		this.string_0 = "";
		base..ctor();
		if (gclass428_1 == null)
		{
			this.gclass428_0 = new GClass428(0);
		}
		else
		{
			this.gclass428_0 = gclass428_1;
		}
		this.bool_0 = bool_2;
		this.bool_1 = bool_3;
		this.string_0 = string_1;
	}

	public virtual int vmethod_0()
	{
		return 127;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass428_0 = (GClass428)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass428_0 != null)
		{
			this.gclass428_0.imethod_1(binaryStream_0);
		}
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.bool_1 = binaryStream_0.ReadBoolean();
		this.string_0 = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(127);
		if (this.gclass428_0 != null)
		{
			this.gclass428_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.WriteBoolean(this.bool_1);
		binaryStream_0.smethod_3(this.string_0);
	}

	public GClass428 gclass428_0;

	public bool bool_0;

	public bool bool_1;

	public string string_0;
}
