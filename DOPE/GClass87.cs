using System;
using System.Runtime.CompilerServices;

public class GClass87 : GInterface1
{
	[CompilerGenerated]
	public GInterface0 imethod_0()
	{
		return this.ginterface0_0;
	}

	[CompilerGenerated]
	public void imethod_1(GInterface0 ginterface0_1)
	{
		this.ginterface0_0 = ginterface0_1;
	}

	public string Type { get; set; }

	public string Name { get; }

	public GClass87(GInterface0 ginterface0_1)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		this.Name = "ServerCommandNotification" + ginterface0_1.Id.ToString();
		this.imethod_1(ginterface0_1);
	}

	[CompilerGenerated]
	private GInterface0 ginterface0_0;

	[CompilerGenerated]
	private string string_0;

	[CompilerGenerated]
	private readonly string string_1;
}
