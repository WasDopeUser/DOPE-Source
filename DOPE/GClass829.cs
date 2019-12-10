using System;
using System.Runtime.CompilerServices;
using NLog;

public abstract class GClass829 : GInterface8
{
	public GClass810 Context { get; }

	public Logger Log { get; set; }

	[CompilerGenerated]
	public DateTimeOffset method_0()
	{
		return this.dateTimeOffset_0;
	}

	[CompilerGenerated]
	public void method_1(DateTimeOffset dateTimeOffset_1)
	{
		this.dateTimeOffset_0 = dateTimeOffset_1;
	}

	public abstract int Cooldown { get; }

	public GClass829(GClass810 gclass810_1, string string_0)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.Context = gclass810_1;
		this.Log = this.Context.uhYieiJtWf2("BackgroundLogic-" + string_0);
	}

	void GInterface8.Execute()
	{
		this.bool_0 = true;
		try
		{
			this.Execute();
		}
		catch (Exception ex)
		{
			this.Log.Error("Error executing background task {exception}", ex.ToString());
		}
		finally
		{
			this.bool_0 = false;
			this.method_1(DateTimeOffset.Now);
		}
	}

	public abstract void Execute();

	public abstract bool vmethod_0();

	bool GInterface8.J1PPSKVTUK8()
	{
		return !this.bool_0 && this.method_0().Cooldown(this.Cooldown) && this.vmethod_0();
	}

	public virtual void imethod_1()
	{
		this.method_1(DateTimeOffset.MinValue);
	}

	[CompilerGenerated]
	private readonly GClass810 gclass810_0;

	[CompilerGenerated]
	private Logger lycirFySfg9;

	[CompilerGenerated]
	private DateTimeOffset dateTimeOffset_0;

	private volatile bool bool_0;
}
