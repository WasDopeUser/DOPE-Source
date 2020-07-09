using System;
using System.Runtime.CompilerServices;

public abstract class GClass852<B55TS4TBZ5Z3aU79BOG> : GInterface7 where B55TS4TBZ5Z3aU79BOG : GInterface7
{
	[CompilerGenerated]
	public virtual B55TS4TBZ5Z3aU79BOG vmethod_0()
	{
		return this.gparam_0;
	}

	[CompilerGenerated]
	public virtual void vmethod_1(B55TS4TBZ5Z3aU79BOG DJ305OTR3fqbj8iFe68)
	{
		this.gparam_0 = DJ305OTR3fqbj8iFe68;
	}

	public virtual void imethod_0(byte[] byte_0, int int_0, int int_1)
	{
		B55TS4TBZ5Z3aU79BOG b55TS4TBZ5Z3aU79BOG = this.vmethod_0();
		if (b55TS4TBZ5Z3aU79BOG == null)
		{
			return;
		}
		b55TS4TBZ5Z3aU79BOG.imethod_0(byte_0, int_0, int_1);
	}

	public virtual void imethod_1(byte[] byte_0, int int_0, int int_1)
	{
		B55TS4TBZ5Z3aU79BOG b55TS4TBZ5Z3aU79BOG = this.vmethod_0();
		if (b55TS4TBZ5Z3aU79BOG == null)
		{
			return;
		}
		b55TS4TBZ5Z3aU79BOG.imethod_1(byte_0, int_0, int_1);
	}

	public virtual void imethod_2()
	{
		B55TS4TBZ5Z3aU79BOG b55TS4TBZ5Z3aU79BOG = this.vmethod_0();
		if (b55TS4TBZ5Z3aU79BOG == null)
		{
			return;
		}
		b55TS4TBZ5Z3aU79BOG.imethod_2();
	}

	protected GClass852()
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
	}

	[CompilerGenerated]
	private B55TS4TBZ5Z3aU79BOG gparam_0;
}
