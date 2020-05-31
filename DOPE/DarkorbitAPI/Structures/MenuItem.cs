using System;

namespace DarkorbitAPI.Structures
{
	public class MenuItem
	{
		public bool Available { get; set; }

		public bool Buyable { get; set; }

		public double CounterValue { get; set; }

		public double MaxCounterValue { get; set; }

		public string LootId { get; set; }

		public bool Activatable { get; set; }

		public bool Visible { get; set; }

		public bool Blocked { get; set; }

		public bool Selected { get; set; }

		public string Id { get; set; }

		public DateTimeOffset NextUsable { get; set; }

		internal void method_0(GClass280 gclass280_0)
		{
			this.Id = gclass280_0.Id;
			this.Available = gclass280_0.bool_0;
			this.Buyable = gclass280_0.bool_3;
			this.CounterValue = gclass280_0.double_0;
			this.MaxCounterValue = gclass280_0.double_1;
			this.LootId = gclass280_0.string_0;
			this.Activatable = gclass280_0.bool_4;
			this.Visible = gclass280_0.Visible;
			this.Blocked = gclass280_0.bool_2;
			this.Selected = gclass280_0.bool_1;
		}

		internal void mhHuxbGpkw(GClass281 gclass281_0)
		{
			this.Activatable = gclass281_0.bool_0;
			this.NextUsable = DateTimeOffset.Now.AddMilliseconds(gclass281_0.cYhjMitRnR);
		}

		public MenuItem()
		{
			Class13.NP5bWyNzLwONS();
			base..ctor();
		}
	}
}
