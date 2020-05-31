using System;
using DarkorbitAPI.CommonStructures;

public static class GClass815
{
	public static GClass808 smethod_0(DollConfig dollConfig_0)
	{
		GClass808 gclass;
		switch (dollConfig_0.DollId)
		{
		case 1:
			gclass = new GClass814();
			break;
		case 2:
			gclass = new GClass813();
			break;
		case 3:
			gclass = new GClass812();
			break;
		case 4:
			gclass = new GClass811();
			break;
		case 5:
			gclass = new GClass810();
			break;
		case 6:
			gclass = new GClass809();
			break;
		default:
			gclass = null;
			break;
		}
		if (gclass != null)
		{
			gclass.Init(dollConfig_0.Keys);
		}
		return gclass;
	}
}
