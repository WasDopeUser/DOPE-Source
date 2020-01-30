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
		[GAttribute70("ammunition_laser_sab-50")]
		[IgnoreDataMember]
		SAB_50
	}
}
