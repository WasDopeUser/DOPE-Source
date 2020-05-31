using System;

public class GClass804<zkuBAww34br3qbhrKUN> : GClass803<zkuBAww34br3qbhrKUN> where zkuBAww34br3qbhrKUN : GInterface7
{
	public GClass804()
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		this.gclass802_0 = new GClass802(null);
		this.gclass802_1 = new GClass802(null);
	}

	public void method_0(byte[] byte_0)
	{
		this.gclass802_0.method_0(byte_0);
		this.gclass802_1.method_0(byte_0);
	}

	public override void imethod_1(byte[] byte_0, int int_0, int int_1)
	{
		base.imethod_1(byte_0, int_0, int_1);
		this.gclass802_1.method_2(byte_0, int_0, int_1);
	}

	public override void imethod_0(byte[] byte_0, int int_0, int int_1)
	{
		this.gclass802_0.method_2(byte_0, int_0, int_1);
		base.imethod_0(byte_0, int_0, int_1);
	}

	private GClass802 gclass802_0;

	private GClass802 gclass802_1;
}
