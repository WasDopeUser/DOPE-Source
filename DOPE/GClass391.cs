using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass391 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 30735;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass391(GClass425 gclass425_1 = null, bool bool_2 = false, bool bool_3 = false, string string_1 = "")
	{
		Class13.nIxas2ezryi9b();
		this.string_0 = "";
		base..ctor();
		if (gclass425_1 == null)
		{
			this.gclass425_0 = new GClass425(0U);
		}
		else
		{
			this.gclass425_0 = gclass425_1;
		}
		this.bool_1 = bool_2;
		this.bool_0 = bool_3;
		this.string_0 = string_1;
	}

	public virtual int vmethod_0()
	{
		return 30735;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.string_0 = binaryStream_0.smethod_2();
		this.bool_1 = binaryStream_0.ReadBoolean();
		binaryStream_0.smethod_1();
		this.gclass425_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass425);
		this.gclass425_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(30735);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.WriteBoolean(this.bool_1);
		binaryStream_0.smethod_7(2904);
		this.gclass425_0.imethod_2(binaryStream_0);
	}

	public bool bool_0;

	public string string_0;

	public bool bool_1;

	public GClass425 gclass425_0;
}
