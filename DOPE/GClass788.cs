using System;

public class GClass788<ghEAOUNDZWZXVADC39O> : GClass787<ghEAOUNDZWZXVADC39O> where ghEAOUNDZWZXVADC39O : GInterface7
{
	public GClass788()
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		this.gclass786_0 = new GClass786(null);
		this.gclass786_1 = new GClass786(null);
	}

	public void method_0(byte[] byte_0)
	{
		this.gclass786_0.method_0(byte_0);
		this.gclass786_1.method_0(byte_0);
	}

	public override void imethod_0(byte[] byte_0, int int_0, int int_1)
	{
		base.imethod_0(byte_0, int_0, int_1);
		this.gclass786_1.method_2(byte_0, int_0, int_1);
	}

	public override void UmklIaSsoWi(byte[] byte_0, int int_0, int int_1)
	{
		this.gclass786_0.method_2(byte_0, int_0, int_1);
		base.UmklIaSsoWi(byte_0, int_0, int_1);
	}

	private GClass786 gclass786_0;

	private GClass786 gclass786_1;
}
