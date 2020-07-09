using System;

public static class GClass880
{
	public static string smethod_0(string string_1)
	{
		return string.Format(GClass880.string_0, string_1);
	}

	public static string smethod_1(string string_1, string string_2 = null)
	{
		if (string_2 == null)
		{
			return GClass880.smethod_0(string_1) + "/indexInternal.es";
		}
		return GClass880.smethod_0(string_1) + "/indexInternal.es?action=" + string_2;
	}

	public static string smethod_2(string string_1)
	{
		return GClass880.smethod_1(string_1, "internalMapRevolution");
	}

	public static string Maps(string server)
	{
		return GClass880.smethod_0(server) + "/spacemap/xml/maps.php";
	}

	public static string smethod_3()
	{
		return "https://powerofdark.space/static/maps.xml";
	}

	public static string smethod_4(string string_1)
	{
		return GClass880.smethod_1(string_1, "externalLogout");
	}

	public static string smethod_5(string string_1)
	{
		return GClass880.smethod_0(string_1) + "/ajax/shop.php";
	}

	public static string smethod_6(string string_1, string string_2, string string_3, string string_4 = "init")
	{
		return string.Concat(new string[]
		{
			GClass880.smethod_0(string_1),
			"/flashinput/galaxyGates.php?userID=",
			string_2,
			"&action=",
			string_4,
			"&sid=",
			string_3
		});
	}

	public static string smethod_7(string string_1)
	{
		return GClass880.smethod_0(string_1) + "/flashAPI/dailyLogin.php?doBook=1";
	}

	public static string smethod_8(string string_1)
	{
		return GClass880.smethod_0(string_1) + "/ajax/instances.php";
	}

	public static string smethod_9(string string_1)
	{
		return GClass880.smethod_0(string_1) + "/flashAPI/inventory.php";
	}

	public static string smethod_10(string string_1)
	{
		return GClass880.smethod_1(string_1, "internalNanoTechFactory");
	}

	public static string smethod_11(string string_1)
	{
		return GClass880.smethod_0(string_1) + "/ajax/nanotechFactory.php";
	}

	public static string smethod_12()
	{
		return "https://powerofdark.space/static/ui.txt";
	}

	// Note: this type is marked as 'beforefieldinit'.
	static GClass880()
	{
		Class13.lOBHd9Nzn7x2T();
		GClass880.string_0 = "https://{0}.darkorbit.com";
	}

	public static string string_0;
}
