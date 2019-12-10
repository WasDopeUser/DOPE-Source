using System;
using DarkorbitAPI.CommonStructures;

public static class GClass788
{
	public static GClass781 smethod_0(DollConfig dollConfig_0)
	{
		GClass781 gclass;
		switch (dollConfig_0.DollId)
		{
		case 1:
			gclass = new GClass787();
			break;
		case 2:
			gclass = new GClass786();
			break;
		case 3:
			gclass = new GClass785();
			break;
		case 4:
			gclass = new GClass784();
			break;
		case 5:
			gclass = new GClass783();
			break;
		case 6:
			gclass = new GClass782();
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
