using System;
using System.Windows.Forms;

public class GEventArgs0 : EventArgs
{
	internal GEventArgs0(GEnum9 genum9_1, Keys keys_1)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.genum9_0 = genum9_1;
		this.keys_0 = keys_1;
	}

	public GEnum9 method_0()
	{
		return this.genum9_0;
	}

	public Keys Key
	{
		get
		{
			return this.keys_0;
		}
	}

	private GEnum9 genum9_0;

	private Keys keys_0;
}
