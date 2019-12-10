using System;
using System.Collections.Concurrent;
using System.Numerics;

namespace DarkorbitAPI.Structures
{
	public class GroupManager
	{
		public Hero Hero { get; private set; }

		public ConcurrentDictionary<int, GClass185> Invites { get; private set; }

		public ConcurrentDictionary<int, GroupManager.GroupMember> Members { get; private set; }

		public bool IsInitialized { get; private set; }

		public int OwnerId { get; set; }

		public bool IsOwner
		{
			get
			{
				return this.IsInitialized && this.Hero.Id == this.OwnerId;
			}
		}

		public int Id { get; set; }

		public GroupManager(Hero hero_0)
		{
			Class8.xDph7tozmh5WD();
			base..ctor();
			this.Hero = hero_0;
			this.Invites = new ConcurrentDictionary<int, GClass185>();
			this.Members = new ConcurrentDictionary<int, GroupManager.GroupMember>();
		}

		internal void method_0(GClass185 gclass185_0)
		{
			this.Invites[gclass185_0.int_0] = gclass185_0;
			EventHandler<GClass185> inviteAdded = this.InviteAdded;
			if (inviteAdded == null)
			{
				return;
			}
			inviteAdded(this, gclass185_0);
		}

		internal void method_1(GClass203 gclass203_0)
		{
			GClass185 gclass;
			if (this.Invites.TryRemove(gclass203_0.int_1, out gclass))
			{
				EventHandler<GClass203> inviteRemoved = this.InviteRemoved;
				if (inviteRemoved == null)
				{
					return;
				}
				inviteRemoved(this, gclass203_0);
			}
		}

		internal void method_2(GClass184 gclass184_0)
		{
			GroupManager.GroupMember groupMember;
			if (!this.Members.TryGetValue(gclass184_0.Id, out groupMember))
			{
				groupMember = new GroupManager.GroupMember();
			}
			groupMember.method_1(gclass184_0);
		}

		internal void method_3(GClass183 gclass183_0)
		{
			this.Clear();
			this.OwnerId = gclass183_0.int_0;
			this.IsInitialized = true;
			foreach (GClass184 gclass184_ in gclass183_0.vector_0)
			{
				this.method_2(gclass184_);
			}
		}

		internal void zqvcnxOcgC(GClass201 gclass201_0)
		{
			GroupManager.GroupMember groupMember;
			if (this.Members.TryGetValue(gclass201_0.int_0, out groupMember))
			{
				groupMember.method_2(gclass201_0);
			}
		}

		internal void method_4(GClass182 gclass182_0)
		{
			this.Clear();
		}

		internal void method_5(GClass202 gclass202_0)
		{
			GroupManager.GroupMember groupMember;
			this.Members.TryRemove(gclass202_0.int_0, out groupMember);
		}

		internal void method_6(GClass204 gclass204_0)
		{
			this.OwnerId = gclass204_0.int_0;
		}

		public void Clear()
		{
			this.IsInitialized = false;
			this.Invites.Clear();
			this.Members.Clear();
		}

		public event EventHandler<GClass185> InviteAdded;

		public event EventHandler<GClass203> InviteRemoved;

		public class GroupMember : Entity
		{
			public int Id { get; set; }

			public string Name { get; set; }

			public bool IsInitialized { get; set; }

			public GClass193 Location { get; set; }

			public override Vector2 Position
			{
				get
				{
					if (this.Location != null)
					{
						return new Vector2((float)this.Location.int_2, (float)this.Location.int_1);
					}
					return default(Vector2);
				}
			}

			public override int PosX
			{
				get
				{
					return (int)this.Position.X;
				}
			}

			public override int PosY
			{
				get
				{
					return (int)this.Position.Y;
				}
			}

			public int MapId
			{
				get
				{
					GClass193 location = this.Location;
					if (location == null)
					{
						return 0;
					}
					return location.int_0;
				}
			}

			public GClass188 ShipInfo { get; set; }

			public GClass194 Target { get; set; }

			public int FactionId { get; set; }

			public bool IsCloaked { get; set; }

			public bool IsActive { get; set; }

			public bool method_0(out GClass194 gclass194_0)
			{
				gclass194_0 = this.Target;
				return gclass194_0 != null && gclass194_0.gclass195_0.uint_0 > 0U;
			}

			public GroupMember()
			{
				Class8.xDph7tozmh5WD();
				base..ctor(0, 0);
			}

			public void Clear()
			{
				this.Id = 0;
				this.Name = null;
				this.IsInitialized = false;
				this.Location = null;
				this.ShipInfo = null;
				this.Target = null;
			}

			public void method_1(GClass184 gclass184_0)
			{
				this.Clear();
				this.IsInitialized = true;
				this.method_4(gclass184_0.gclass193_0);
				this.Id = gclass184_0.Id;
				this.Name = gclass184_0.Name;
				this.method_5(gclass184_0.gclass194_0);
				this.IsCloaked = gclass184_0.bool_0;
				this.IsActive = gclass184_0.bool_3;
				this.method_6(gclass184_0.gclass191_0);
			}

			public void method_2(GClass201 gclass201_0)
			{
				foreach (GClass187 gclass187_ in gclass201_0.vector_0)
				{
					this.method_3(gclass187_);
				}
			}

			public void method_3(GClass187 gclass187_0)
			{
				GClass193 gclass = gclass187_0 as GClass193;
				if (gclass != null)
				{
					this.method_4(gclass);
					return;
				}
				GClass194 gclass2 = gclass187_0 as GClass194;
				if (gclass2 != null)
				{
					this.method_5(gclass2);
					return;
				}
				GClass191 gclass3 = gclass187_0 as GClass191;
				if (gclass3 != null)
				{
					this.method_6(gclass3);
				}
			}

			public void method_4(GClass193 gclass193_0)
			{
				this.Location = gclass193_0;
			}

			public void method_5(GClass194 gclass194_0)
			{
				this.Target = gclass194_0;
			}

			public void method_6(GClass191 gclass191_0)
			{
				this.FactionId = (int)gclass191_0.uint_0;
			}
		}
	}
}
