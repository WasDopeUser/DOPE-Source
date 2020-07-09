using System;
using DarkorbitAPI;

namespace DOPE.Common.Models
{
	public interface IPErkavaBotController
	{
		GameManager Game { get; }

		string GameServer { get; }

		void DetachPErkava();

		bool AttachPErkava(GClass239 obj);
	}
}
