using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass277 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 11434;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 19;
		}
	}

	public GClass277(string string_0 = "", GClass753 gclass753_1 = null, double double_2 = 0.0, double double_3 = 0.0, bool bool_1 = false)
	{
		Class13.Gj4N3WdzaR1LY();
		this.Id = "";
		base..ctor();
		this.Id = string_0;
		if (gclass753_1 == null)
		{
			this.gclass753_0 = new GClass753(0U);
		}
		else
		{
			this.gclass753_0 = gclass753_1;
		}
		this.double_1 = double_2;
		this.double_0 = double_3;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 11434;
	}

	public virtual int vmethod_1()
	{
		return 19;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass753_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass753);
		this.gclass753_0.imethod_1(binaryStream_0);
		this.double_0 = binaryStream_0.ReadDouble();
		this.double_1 = binaryStream_0.ReadDouble();
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.Id = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(11434);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass753_0.imethod_2(binaryStream_0);
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.WriteDouble(this.double_1);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_3(this.Id);
	}

	public GClass753 gclass753_0;

	public double double_0;

	public double double_1;

	public bool bool_0;

	public string Id;
}
