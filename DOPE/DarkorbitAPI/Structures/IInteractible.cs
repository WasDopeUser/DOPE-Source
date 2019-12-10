using System;

namespace DarkorbitAPI.Structures
{
	public interface IInteractible
	{
		int Id { get; }

		bool Activatable { get; set; }

		bool Activated { get; set; }
	}
}
