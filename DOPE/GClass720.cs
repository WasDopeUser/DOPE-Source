﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass720 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 281;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 16;
		}
	}

	public GClass720(int int_3 = 0, int int_4 = 0, int int_5 = 0, int int_6 = 0)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		this.int_0 = int_3;
		this.yfaNauvnAR = int_4;
		this.int_1 = int_5;
		this.int_2 = int_6;
	}

	public virtual int vmethod_0()
	{
		return 281;
	}

	public virtual int vmethod_1()
	{
		return 16;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 2 | U.smethod_0(this.int_0, 30));
		this.yfaNauvnAR = binaryStream_0.smethod_0();
		this.yfaNauvnAR = (U.smethod_0(this.yfaNauvnAR, 13) | this.yfaNauvnAR << 19);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 5) | this.int_1 << 27);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 2) | this.int_2 << 30);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(281);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 2) | this.int_0 << 30);
		binaryStream_0.smethod_4(this.yfaNauvnAR << 13 | U.smethod_0(this.yfaNauvnAR, 19));
		binaryStream_0.smethod_4(this.int_1 << 5 | U.smethod_0(this.int_1, 27));
		binaryStream_0.smethod_4(this.int_2 << 2 | U.smethod_0(this.int_2, 30));
	}

	public int int_0;

	public int yfaNauvnAR;

	public int int_1;

	public int int_2;
}
