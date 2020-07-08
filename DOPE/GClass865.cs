using System;
using DarkorbitAPI.CommonStructures;

public static class GClass865
{
	public static GClass858 smethod_0(DollConfig dollConfig_0)
	{
		GClass858 gclass;
		switch (dollConfig_0.DollId)
		{
		case 1:
			gclass = new GClass864();
			break;
		case 2:
			gclass = new GClass863();
			break;
		case 3:
			gclass = new GClass862();
			break;
		case 4:
			gclass = new GClass861();
			break;
		case 5:
			gclass = new GClass860();
			break;
		case 6:
			gclass = new GClass859();
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
