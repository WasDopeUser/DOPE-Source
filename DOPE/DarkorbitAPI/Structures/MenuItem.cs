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

		internal void method_0(GClass276 gclass276_0)
		{
			this.Id = gclass276_0.Id;
			this.Available = gclass276_0.nNnToDkky9;
			this.Buyable = gclass276_0.bool_0;
			this.CounterValue = gclass276_0.double_1;
			this.MaxCounterValue = gclass276_0.double_0;
			this.LootId = gclass276_0.string_0;
			this.Activatable = gclass276_0.bool_2;
			this.Visible = gclass276_0.Visible;
			this.Blocked = gclass276_0.bool_1;
			this.Selected = gclass276_0.bool_3;
		}

		internal void method_1(GClass277 gclass277_0)
		{
			this.Activatable = gclass277_0.bool_0;
			this.NextUsable = DateTimeOffset.Now.AddMilliseconds(gclass277_0.double_0);
		}

		public MenuItem()
		{
			Class13.lOBHd9Nzn7x2T();
			base..ctor();
		}
	}
}
