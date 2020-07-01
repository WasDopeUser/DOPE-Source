using System;
using System.Linq;
using DarkorbitAPI.CommonStructures;

public abstract class GClass854 : GClass852<GInterface7>
{
	public static byte[] smethod_0(string string_0)
	{
		GClass854.<>c__DisplayClass0_0 CS$<>8__locals1 = new GClass854.<>c__DisplayClass0_0();
		CS$<>8__locals1.string_0 = string_0;
		return Enumerable.Range(0, CS$<>8__locals1.string_0.Length).Where(new Func<int, bool>(GClass854.<>c.<>c_0.method_0)).Select(new Func<int, byte>(CS$<>8__locals1.method_0)).ToArray<byte>();
	}

	public abstract void vmethod_2(byte[] byte_0);

	public override void imethod_0(byte[] byte_0, int int_0, int int_1)
	{
		base.imethod_0(byte_0, int_0, int_1);
	}

	public override void imethod_1(byte[] byte_0, int int_0, int int_1)
	{
		base.imethod_1(byte_0, int_0, int_1);
	}

	public abstract void vmethod_3(DollConfig dollConfig_0, Action action_0);

	public abstract byte[] vmethod_4();

	protected GClass854()
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
	}
}
