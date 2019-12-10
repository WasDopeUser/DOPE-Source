using System;

public class GClass777<TskYdMJTD6rBh8tCq0D> : GClass776<TskYdMJTD6rBh8tCq0D> where TskYdMJTD6rBh8tCq0D : GInterface6
{
	public GClass777()
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.gclass775_0 = new GClass775(null);
		this.gclass775_1 = new GClass775(null);
	}

	public void method_0(byte[] byte_0)
	{
		this.gclass775_0.method_0(byte_0);
		this.gclass775_1.method_0(byte_0);
	}

	public override void imethod_1(byte[] byte_0, int int_0, int int_1)
	{
		base.imethod_1(byte_0, int_0, int_1);
		this.gclass775_1.method_2(byte_0, int_0, int_1);
	}

	public override void imethod_0(byte[] byte_0, int int_0, int int_1)
	{
		this.gclass775_0.method_2(byte_0, int_0, int_1);
		base.imethod_0(byte_0, int_0, int_1);
	}

	private GClass775 gclass775_0;

	private GClass775 gclass775_1;
}
