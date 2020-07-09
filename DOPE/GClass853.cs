using System;

public class GClass853<VCcNnJTrT4KWeMkpetT> : GClass852<VCcNnJTrT4KWeMkpetT> where VCcNnJTrT4KWeMkpetT : GInterface7
{
	public GClass853()
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		this.gclass851_0 = new GClass851(null);
		this.gclass851_1 = new GClass851(null);
	}

	public void method_0(byte[] byte_0)
	{
		this.gclass851_0.method_0(byte_0);
		this.gclass851_1.method_0(byte_0);
	}

	public override void imethod_1(byte[] byte_0, int int_0, int int_1)
	{
		base.imethod_1(byte_0, int_0, int_1);
		this.gclass851_1.method_2(byte_0, int_0, int_1);
	}

	public override void imethod_0(byte[] byte_0, int int_0, int int_1)
	{
		this.gclass851_0.method_2(byte_0, int_0, int_1);
		base.imethod_0(byte_0, int_0, int_1);
	}

	private GClass851 gclass851_0;

	private GClass851 gclass851_1;
}
