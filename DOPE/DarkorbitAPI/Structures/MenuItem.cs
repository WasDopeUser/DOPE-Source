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

		internal void method_0(GClass275 gclass275_0)
		{
			this.Id = gclass275_0.Id;
			this.Available = gclass275_0.bool_1;
			this.Buyable = gclass275_0.bool_0;
			this.CounterValue = gclass275_0.double_1;
			this.MaxCounterValue = gclass275_0.double_0;
			this.LootId = gclass275_0.string_0;
			this.Activatable = gclass275_0.bool_3;
			this.Visible = gclass275_0.Visible;
			this.Blocked = gclass275_0.bool_2;
			this.Selected = gclass275_0.bool_4;
		}

		internal void method_1(GClass276 gclass276_0)
		{
			this.Activatable = gclass276_0.bool_0;
			this.NextUsable = DateTimeOffset.Now.AddMilliseconds(gclass276_0.double_0);
		}

		public MenuItem()
		{
			Class13.xnk8ImWzpOt04();
			base..ctor();
		}
	}
}
