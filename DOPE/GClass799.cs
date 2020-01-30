﻿using System;
using DarkorbitAPI.CommonStructures;

public static class GClass799
{
	public static GClass792 smethod_0(DollConfig dollConfig_0)
	{
		GClass792 gclass;
		switch (dollConfig_0.DollId)
		{
		case 1:
			gclass = new GClass798();
			break;
		case 2:
			gclass = new GClass797();
			break;
		case 3:
			gclass = new GClass796();
			break;
		case 4:
			gclass = new GClass795();
			break;
		case 5:
			gclass = new GClass794();
			break;
		case 6:
			gclass = new GClass793();
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
