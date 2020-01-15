using System;

public class GClass787<bVK79uPDWomPqefgqF0> : GClass786<bVK79uPDWomPqefgqF0> where bVK79uPDWomPqefgqF0 : GInterface7
{
	public GClass787()
	{
		Class13.nIxas2ezryi9b();
		base..ctor();
		this.gclass785_0 = new GClass785(null);
		this.gclass785_1 = new GClass785(null);
	}

	public void method_0(byte[] byte_0)
	{
		this.gclass785_0.method_0(byte_0);
		this.gclass785_1.method_0(byte_0);
	}

	public override void imethod_1(byte[] byte_0, int int_0, int int_1)
	{
		base.imethod_1(byte_0, int_0, int_1);
		this.gclass785_1.method_2(byte_0, int_0, int_1);
	}

	public override void imethod_0(byte[] byte_0, int int_0, int int_1)
	{
		this.gclass785_0.method_2(byte_0, int_0, int_1);
		base.imethod_0(byte_0, int_0, int_1);
	}

	private GClass785 gclass785_0;

	private GClass785 gclass785_1;
}
