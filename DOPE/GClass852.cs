using System;

public class GClass852<QpHKL22pmvc8t9PK061> : GClass851<QpHKL22pmvc8t9PK061> where QpHKL22pmvc8t9PK061 : GInterface7
{
	public GClass852()
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		this.gclass850_0 = new GClass850(null);
		this.gclass850_1 = new GClass850(null);
	}

	public void method_0(byte[] byte_0)
	{
		this.gclass850_0.method_0(byte_0);
		this.gclass850_1.method_0(byte_0);
	}

	public override void imethod_1(byte[] byte_0, int int_0, int int_1)
	{
		base.imethod_1(byte_0, int_0, int_1);
		this.gclass850_1.method_2(byte_0, int_0, int_1);
	}

	public override void imethod_0(byte[] byte_0, int int_0, int int_1)
	{
		this.gclass850_0.method_2(byte_0, int_0, int_1);
		base.imethod_0(byte_0, int_0, int_1);
	}

	private GClass850 gclass850_0;

	private GClass850 gclass850_1;
}
