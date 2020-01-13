using System;

namespace DarkorbitAPI.Structures
{
	public class Gate : Entity, IInteractible
	{
		public MapUtils.PortalEdge Edge
		{
			get
			{
				MapUtils.PortalEdge result;
				if (!MapUtils.Portals.TryGetValue(this.Id, out result))
				{
					return null;
				}
				return result;
			}
		}

		public int Type { get; set; }

		public int Id { get; set; }

		public int FactionId { get; set; }

		public bool Activatable { get; set; }

		public bool Activated { get; set; }

		public Gate(int int_0, int int_1, int int_2, int int_3, int int_4)
		{
			Class13.tMHx78BzgCM8j();
			base..ctor(int_0, int_1);
			this.Type = int_4;
			this.Id = int_3;
			this.FactionId = int_2;
		}
	}
}
