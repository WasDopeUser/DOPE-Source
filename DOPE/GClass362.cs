using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass362 : GClass359, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 17040;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 2;
		}
	}

	public GClass362(string string_0 = "")
	{
		Class8.xDph7tozmh5WD();
		this.eOhYfSlLi0 = "";
		base..ctor();
		this.eOhYfSlLi0 = string_0;
	}

	public override int vmethod_0()
	{
		return 17040;
	}

	public override int vmethod_1()
	{
		return 2;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.eOhYfSlLi0 = binaryStream_0.smethod_2();
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(17040);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_3(this.eOhYfSlLi0);
	}

	public string eOhYfSlLi0;
}
