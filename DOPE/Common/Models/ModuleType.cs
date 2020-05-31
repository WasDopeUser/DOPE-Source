using System;
using System.ComponentModel.DataAnnotations;

namespace DOPE.Common.Models
{
	public enum ModuleType
	{
		Default,
		Palladium,
		Cubikons,
		[Display(Name = "Frozen Labirynth")]
		FrozenLabirynth,
		[Display(Name = "Quarantine Zone")]
		QuarantineZone,
		[Display(Name = "Payload Escort")]
		PayloadEscort
	}
}
