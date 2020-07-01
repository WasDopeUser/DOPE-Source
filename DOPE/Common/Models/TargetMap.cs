using System;
using System.ComponentModel.DataAnnotations.Schema;
using DarkorbitAPI.Packets.Static;

namespace DOPE.Common.Models
{
	public enum TargetMap
	{
		[Map("None")]
		None,
		[Map("X-1", ByFaction = 1)]
		X1,
		[Map("X-2", ByFaction = 2)]
		X2,
		[Map("X-3", ByFaction = 3)]
		X3,
		[Map("X-4", ByFaction = 4)]
		X4,
		[Map("X-5", ByFaction = 5)]
		X5 = 17,
		[Map("X-6", ByFaction = 6)]
		X6,
		[Map("X-7", ByFaction = 7)]
		X7,
		[Map("X-8", ByFaction = 8)]
		X8,
		[Map("GG Alpha", Gate = (GEnum5)51)]
		GG_Alpha = 51,
		[Map("GG Beta", Gate = (GEnum5)52)]
		GG_Beta,
		[Map("GG Gamma", Gate = (GEnum5)53)]
		GG_Gamma,
		[Map("GG Delta", Gate = (GEnum5)55)]
		GG_Delta = 55,
		[Map("GG Epsilon", Gate = (GEnum5)70)]
		GG_Epsilon = 70,
		[Map("GG Zeta", Gate = (GEnum5)71)]
		GG_Zeta,
		[Map("GG Kappa", Gate = (GEnum5)74)]
		GG_Kappa = 74,
		[Map("GG Lambda", Gate = (GEnum5)75)]
		GG_Lambda,
		[Map("GG Kronos", Gate = (GEnum5)76)]
		GG_Kronos,
		[NotMapped]
		[Map("GG VoT", Gate = (GEnum5)227)]
		GG_VoT = 227,
		[NotMapped]
		[Map("GG QZ", Gate = (GEnum5)229)]
		GG_QZ = 229,
		[Map("GG ColdWave", Gate = (GEnum5)77)]
		[NotMapped]
		GG_ColdWave = 77,
		[Map("GG Kuiper", Gate = (GEnum5)300)]
		GG_Kuiper = 300,
		[Map("4-1")]
		W41 = 13,
		[Map("4-2")]
		W42,
		[Map("4-3")]
		W43,
		[Map("4-4")]
		W44,
		[Map("4-5")]
		W45 = 29,
		[Map("5-1")]
		[NotMapped]
		P51 = 91,
		[Map("5-2")]
		P52,
		[Map("5-3")]
		[NotMapped]
		P53,
		[Map("BL-1")]
		BL1 = 306,
		[Map("BL-2")]
		BL2,
		[Map("BL-3")]
		BL3,
		[NotMapped]
		[Map("FL ATLAS A", MapGroup = MapGroup.FrozenLabyrinth)]
		FL_ATLAS_A = 430,
		[Map("Payload Escort", MapGroup = MapGroup.PayloadEscort)]
		[NotMapped]
		PayloadEscort
	}
}
