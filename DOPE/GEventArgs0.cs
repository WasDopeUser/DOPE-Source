using System;
using System.Windows.Forms;

public class GEventArgs0 : EventArgs
{
	internal GEventArgs0(GEnum13 genum13_1, Keys keys_1)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		this.genum13_0 = genum13_1;
		this.keys_0 = keys_1;
	}

	public GEnum13 method_0()
	{
		return this.genum13_0;
	}

	public Keys Key
	{
		get
		{
			return this.keys_0;
		}
	}

	private GEnum13 genum13_0;

	private Keys keys_0;
}
