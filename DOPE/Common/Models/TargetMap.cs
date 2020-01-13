using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DOPE.Common.Models
{
	public enum TargetMap
	{
		[Display(Name = "None")]
		None,
		[Display(Name = "X-1")]
		X1,
		[Display(Name = "X-2")]
		X2,
		[Display(Name = "X-3")]
		X3,
		[Display(Name = "X-4")]
		X4,
		[Display(Name = "X-5")]
		X5 = 17,
		[Display(Name = "X-6")]
		X6,
		[Display(Name = "X-7")]
		X7,
		[Display(Name = "X-8")]
		X8,
		[Display(Name = "GG Alpha")]
		GG_Alpha = 51,
		[Display(Name = "GG Beta")]
		GG_Beta,
		[Display(Name = "GG Gamma")]
		GG_Gamma,
		[Display(Name = "GG Delta")]
		GG_Delta = 55,
		[Display(Name = "GG Epsilon")]
		GG_Epsilon = 70,
		[Display(Name = "GG Zeta")]
		GG_Zeta,
		[Display(Name = "GG Kappa")]
		GG_Kappa = 74,
		[Display(Name = "GG Lambda")]
		GG_Lambda,
		[Display(Name = "GG Kronos")]
		GG_Kronos,
		[NotMapped]
		[Display(Name = "GG VoT")]
		GG_VoT = 227,
		[NotMapped]
		[Display(Name = "GG QZ")]
		GG_QZ = 229,
		[NotMapped]
		[Display(Name = "GG Cold Wave")]
		GG_ColdWave = 77,
		[Display(Name = "GG Kuiper")]
		GG_Kuiper = 300,
		[Display(Name = "4-1")]
		W41 = 13,
		[Display(Name = "4-2")]
		W42,
		[Display(Name = "4-3")]
		W43,
		[Display(Name = "4-4")]
		W44,
		[Display(Name = "4-5")]
		W45 = 29,
		[Display(Name = "5-1")]
		[NotMapped]
		P51 = 91,
		[Display(Name = "5-2")]
		P52,
		[Display(Name = "5-3")]
		[NotMapped]
		P53,
		[Display(Name = "BL-1")]
		BL1 = 306,
		[Display(Name = "BL-2")]
		BL2,
		[Display(Name = "BL-3")]
		BL3,
		[NotMapped]
		[Display(Name = "FL ATLAS A")]
		FL_ATLAS_A = 430
	}
}
