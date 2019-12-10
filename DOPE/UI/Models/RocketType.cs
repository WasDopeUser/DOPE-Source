using System;

namespace DOPE.UI.Models
{
	public enum RocketType
	{
		Default,
		None,
		[GAttribute70("ammunition_rocket_r-310")]
		R_310,
		[GAttribute70("ammunition_rocket_plt-2026")]
		PLT_2026,
		[GAttribute70("ammunition_rocket_plt-2021")]
		PLT_2021,
		[GAttribute70("ammunition_rocket_plt-3030")]
		PLT_3030
	}
}
