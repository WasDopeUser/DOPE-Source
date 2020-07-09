using System;
using System.Runtime.Serialization;

namespace DOPE.UI.Models
{
	public enum LaserType
	{
		Default,
		[GAttribute70("ammunition_laser_lcb-10")]
		LCB_10,
		[GAttribute70("ammunition_laser_mcb-25")]
		MCB_25,
		[GAttribute70("ammunition_laser_mcb-50")]
		MCB_50,
		[GAttribute70("ammunition_laser_ucb-100")]
		UCB_100,
		[GAttribute70("ammunition_laser_job-100")]
		JOB_100,
		[GAttribute70("ammunition_laser_a-bl")]
		A_BL,
		[GAttribute70("ammunition_laser_rb-214")]
		RB_214,
		[GAttribute70("ammunition_laser_idb-125")]
		IDB_125,
		[GAttribute70("ammunition_laser_emaa-20")]
		EMAA_20,
		[IgnoreDataMember]
		[GAttribute70("ammunition_laser_sab-50")]
		SAB_50
	}
}
