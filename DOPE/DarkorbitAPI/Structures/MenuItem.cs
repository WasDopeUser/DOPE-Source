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

		internal void method_0(GClass262 gclass262_0)
		{
			this.Id = gclass262_0.Id;
			this.Available = gclass262_0.wkAjkMgydL;
			this.Buyable = gclass262_0.bool_1;
			this.CounterValue = gclass262_0.double_1;
			this.MaxCounterValue = gclass262_0.double_0;
			this.LootId = gclass262_0.string_0;
			this.Activatable = gclass262_0.bool_2;
			this.Visible = gclass262_0.Visible;
			this.Blocked = gclass262_0.bool_0;
			this.Selected = gclass262_0.bool_3;
		}

		internal void method_1(GClass263 gclass263_0)
		{
			this.Activatable = gclass263_0.bool_0;
			this.NextUsable = DateTimeOffset.Now.AddMilliseconds(gclass263_0.double_0);
		}

		public MenuItem()
		{
			Class8.xDph7tozmh5WD();
			base..ctor();
		}
	}
}
