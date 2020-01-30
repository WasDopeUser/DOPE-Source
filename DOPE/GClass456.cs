using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass456 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 25756;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 16;
		}
	}

	public GClass456(double double_1 = 0.0, double double_2 = 0.0)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		this.qCkoiUmZd6 = double_1;
		this.double_0 = double_2;
	}

	public virtual int vmethod_0()
	{
		return 25756;
	}

	public virtual int vmethod_1()
	{
		return 16;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.qCkoiUmZd6 = binaryStream_0.ReadDouble();
		this.double_0 = binaryStream_0.ReadDouble();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(25756);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteDouble(this.qCkoiUmZd6);
		binaryStream_0.WriteDouble(this.double_0);
	}

	public double qCkoiUmZd6;

	public double double_0;
}
