using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace DarkorbitAPI.Structures
{
	public class GroupManager : INotifyPropertyChanged
	{
		internal void method_0(GClass250 gclass250_0)
		{
			Vector2 value = new Vector2((float)gclass250_0.int_0, (float)gclass250_0.int_1);
			foreach (GroupManager.GroupMember groupMember in this.method_9())
			{
				if (Vector2.Distance(groupMember.Position, value) < 1200f)
				{
					groupMember.LastPinged = DateTimeOffset.Now;
				}
			}
		}

		public bool jYrndIqmin(int int_0)
		{
			return this.Members.ContainsKey(int_0);
		}

		public Hero Hero
		{
			[CompilerGenerated]
			get
			{
				return this.<Hero>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<Hero>k__BackingField, value))
				{
					return;
				}
				this.<Hero>k__BackingField = value;
				this.method_10(Class5.IsOwner);
				this.method_10(Class5.Hero);
			}
		}

		public ConcurrentDictionary<int, GroupManager.GroupInvite> Invites
		{
			[CompilerGenerated]
			get
			{
				return this.<Invites>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<Invites>k__BackingField, value))
				{
					return;
				}
				this.<Invites>k__BackingField = value;
				this.method_10(Class5.InviteList);
				this.method_10(Class5.GwcHdqZicy3);
			}
		}

		public ConcurrentDictionary<int, GroupManager.GroupMember> Members
		{
			[CompilerGenerated]
			get
			{
				return this.<Members>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<Members>k__BackingField, value))
				{
					return;
				}
				this.<Members>k__BackingField = value;
				this.method_10(Class5.MemberList);
				this.method_10(Class5.propertyChangedEventArgs_71);
			}
		}

		public ICollection<GroupManager.GroupMember> MemberList
		{
			get
			{
				return this.Members.Values;
			}
		}

		public ICollection<GroupManager.GroupInvite> InviteList
		{
			get
			{
				return this.Invites.Values.Where(new Func<GroupManager.GroupInvite, bool>(GroupManager.<>c.<>9.method_0)).ToList<GroupManager.GroupInvite>();
			}
		}

		public bool IsInitialized
		{
			[CompilerGenerated]
			get
			{
				return this.<IsInitialized>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (this.<IsInitialized>k__BackingField == value)
				{
					return;
				}
				this.<IsInitialized>k__BackingField = value;
				this.method_10(Class5.IsOwner);
				this.method_10(Class5.propertyChangedEventArgs_43);
			}
		}

		public int OwnerId
		{
			[CompilerGenerated]
			get
			{
				return this.<OwnerId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<OwnerId>k__BackingField == value)
				{
					return;
				}
				this.<OwnerId>k__BackingField = value;
				this.method_10(Class5.IsOwner);
				this.method_10(Class5.propertyChangedEventArgs_76);
			}
		}

		public bool IsOwner
		{
			get
			{
				return this.IsInitialized && this.Hero.Id == this.OwnerId;
			}
		}

		public int Id
		{
			[CompilerGenerated]
			get
			{
				return this.<Id>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Id>k__BackingField == value)
				{
					return;
				}
				this.<Id>k__BackingField = value;
				this.method_10(Class5.Id);
			}
		}

		public GroupManager(Hero hero_0)
		{
			Class13.NP5bWyNzLwONS();
			base..ctor();
			this.Hero = hero_0;
			this.Invites = new ConcurrentDictionary<int, GroupManager.GroupInvite>();
			this.Members = new ConcurrentDictionary<int, GroupManager.GroupMember>();
		}

		private void method_1()
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new PropertyChangedEventArgs("InviteList"));
			}
			PropertyChangedEventHandler propertyChanged2 = this.PropertyChanged;
			if (propertyChanged2 == null)
			{
				return;
			}
			propertyChanged2(this, new PropertyChangedEventArgs("MemberList"));
		}

		public void method_2(GClass196 gclass196_0)
		{
			this.Invites[gclass196_0.FromId] = new GroupManager.GroupInvite(gclass196_0, gclass196_0.int_0 == this.Hero.Id);
			this.method_1();
			EventHandler<GClass196> inviteAdded = this.InviteAdded;
			if (inviteAdded == null)
			{
				return;
			}
			inviteAdded(this, gclass196_0);
		}

		public void iZanvyDsIr(GClass214 gclass214_0)
		{
			GroupManager.GroupInvite groupInvite;
			if (this.Invites.TryRemove(gclass214_0.FromId, out groupInvite))
			{
				this.method_1();
				EventHandler<GClass214> inviteRemoved = this.InviteRemoved;
				if (inviteRemoved == null)
				{
					return;
				}
				inviteRemoved(this, gclass214_0);
			}
		}

		public void method_3(GClass195 gclass195_0)
		{
			GroupManager.GroupMember groupMember;
			if (!this.Members.TryGetValue(gclass195_0.Id, out groupMember))
			{
				groupMember = (this.Members[gclass195_0.Id] = new GroupManager.GroupMember());
			}
			groupMember.method_1(gclass195_0);
			this.method_1();
		}

		public void method_4(GClass194 gclass194_0)
		{
			this.Clear();
			this.OwnerId = gclass194_0.int_0;
			this.IsInitialized = true;
			foreach (GClass195 gclass195_ in gclass194_0.vector_0)
			{
				this.method_3(gclass195_);
			}
		}

		public void method_5(GClass212 gclass212_0)
		{
			GroupManager.GroupMember groupMember;
			if (this.Members.TryGetValue(gclass212_0.int_0, out groupMember))
			{
				groupMember.method_2(gclass212_0);
			}
		}

		public void method_6(GClass193 gclass193_0)
		{
			this.Clear();
		}

		public void method_7(GClass213 gclass213_0)
		{
			GroupManager.GroupMember groupMember;
			this.Members.TryRemove(gclass213_0.int_0, out groupMember);
			if (gclass213_0.int_0 == this.Hero.Id)
			{
				this.Clear();
				return;
			}
			this.method_1();
		}

		public void method_8(GClass215 gclass215_0)
		{
			this.OwnerId = gclass215_0.int_0;
		}

		public void Clear()
		{
			this.IsInitialized = false;
			this.Invites.Clear();
			this.Members.Clear();
			this.method_1();
		}

		public IEnumerable<GroupManager.GroupMember> method_9()
		{
			GroupManager.<>c__DisplayClass45_0 CS$<>8__locals1 = new GroupManager.<>c__DisplayClass45_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.hPos = this.Hero.Position;
			CS$<>8__locals1.map = this.Hero.Game.Map.MapId;
			return this.Members.Values.Where(new Func<GroupManager.GroupMember, bool>(CS$<>8__locals1.method_0)).OrderBy(new Func<GroupManager.GroupMember, float>(CS$<>8__locals1.method_1));
		}

		public event EventHandler<GClass196> InviteAdded;

		public event EventHandler<GClass214> InviteRemoved;

		public event PropertyChangedEventHandler PropertyChanged;

		[DebuggerNonUserCode]
		[GeneratedCode("PropertyChanged.Fody", "3.2.3.0")]
		protected void method_10(PropertyChangedEventArgs propertyChangedEventArgs_0)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, propertyChangedEventArgs_0);
			}
		}

		public class GroupMember : Entity, INotifyPropertyChanged
		{
			public int Id
			{
				[CompilerGenerated]
				get
				{
					return this.<Id>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					if (this.<Id>k__BackingField == value)
					{
						return;
					}
					this.<Id>k__BackingField = value;
					this.method_7(Class5.Id);
				}
			}

			public string Name
			{
				[CompilerGenerated]
				get
				{
					return this.<Name>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					if (string.Equals(this.<Name>k__BackingField, value, StringComparison.Ordinal))
					{
						return;
					}
					this.<Name>k__BackingField = value;
					this.method_7(Class5.Name);
				}
			}

			public bool IsInitialized
			{
				[CompilerGenerated]
				get
				{
					return this.<IsInitialized>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					if (this.<IsInitialized>k__BackingField == value)
					{
						return;
					}
					this.<IsInitialized>k__BackingField = value;
					this.method_7(Class5.propertyChangedEventArgs_43);
				}
			}

			public GClass205 Location
			{
				[CompilerGenerated]
				get
				{
					return this.<Location>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					if (object.Equals(this.<Location>k__BackingField, value))
					{
						return;
					}
					this.<Location>k__BackingField = value;
					this.method_7(Class5.propertyChangedEventArgs_77);
					this.method_7(Class5.MapId);
					this.method_7(Class5.propertyChangedEventArgs_67);
				}
			}

			public override Vector2 Position
			{
				get
				{
					if (this.Location != null)
					{
						return new Vector2((float)this.Location.int_0, (float)this.Location.ByBszpfmUm);
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
					GClass205 location = this.Location;
					if (location == null)
					{
						return 0;
					}
					return location.MapId;
				}
			}

			public GClass199 ShipInfo
			{
				[CompilerGenerated]
				get
				{
					return this.<ShipInfo>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					if (object.Equals(this.<ShipInfo>k__BackingField, value))
					{
						return;
					}
					this.<ShipInfo>k__BackingField = value;
					this.method_7(Class5.propertyChangedEventArgs_100);
				}
			}

			public GClass206 Target
			{
				[CompilerGenerated]
				get
				{
					return this.<Target>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					if (object.Equals(this.<Target>k__BackingField, value))
					{
						return;
					}
					this.<Target>k__BackingField = value;
					this.method_7(Class5.propertyChangedEventArgs_105);
				}
			}

			public int FactionId
			{
				[CompilerGenerated]
				get
				{
					return this.<FactionId>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					if (this.<FactionId>k__BackingField == value)
					{
						return;
					}
					this.<FactionId>k__BackingField = value;
					this.method_7(Class5.propertyChangedEventArgs_23);
				}
			}

			public bool IsCloaked
			{
				[CompilerGenerated]
				get
				{
					return this.<IsCloaked>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					if (this.<IsCloaked>k__BackingField == value)
					{
						return;
					}
					this.<IsCloaked>k__BackingField = value;
					this.method_7(Class5.propertyChangedEventArgs_38);
				}
			}

			public bool IsActive
			{
				[CompilerGenerated]
				get
				{
					return this.<IsActive>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					if (this.<IsActive>k__BackingField == value)
					{
						return;
					}
					this.<IsActive>k__BackingField = value;
					this.method_7(Class5.propertyChangedEventArgs_35);
				}
			}

			public bool IsFighting
			{
				[CompilerGenerated]
				get
				{
					return this.<IsFighting>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					if (this.<IsFighting>k__BackingField == value)
					{
						return;
					}
					this.<IsFighting>k__BackingField = value;
					this.method_7(Class5.propertyChangedEventArgs_41);
				}
			}

			public DateTimeOffset LastPinged
			{
				[CompilerGenerated]
				get
				{
					return this.<LastPinged>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					if (DateTimeOffset.Equals(this.<LastPinged>k__BackingField, value))
					{
						return;
					}
					this.<LastPinged>k__BackingField = value;
					this.method_7(Class5.propertyChangedEventArgs_57);
				}
			}

			public event PropertyChangedEventHandler PropertyChanged;

			public bool method_0(out GClass206 gclass206_0)
			{
				gclass206_0 = this.Target;
				return gclass206_0 != null && gclass206_0.gclass208_0.uint_0 > 0U;
			}

			public GroupMember()
			{
				Class13.NP5bWyNzLwONS();
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

			public void method_1(GClass195 gclass195_0)
			{
				this.Clear();
				this.IsInitialized = true;
				this.method_4(gclass195_0.gclass205_0);
				this.Id = gclass195_0.Id;
				this.Name = gclass195_0.Name;
				this.method_5(gclass195_0.gclass206_0);
				this.IsCloaked = gclass195_0.bool_2;
				this.IsActive = !gclass195_0.bool_0;
				this.method_6(gclass195_0.gclass202_0);
			}

			public void method_2(GClass212 gclass212_0)
			{
				foreach (GClass198 gclass198_ in gclass212_0.vector_0)
				{
					this.method_3(gclass198_);
				}
			}

			public void method_3(GClass198 gclass198_0)
			{
				GClass205 gclass = gclass198_0 as GClass205;
				if (gclass != null)
				{
					this.method_4(gclass);
					return;
				}
				GClass206 gclass2 = gclass198_0 as GClass206;
				if (gclass2 != null)
				{
					this.method_5(gclass2);
					return;
				}
				GClass202 gclass3 = gclass198_0 as GClass202;
				if (gclass3 != null)
				{
					this.method_6(gclass3);
					return;
				}
				GClass203 gclass4 = gclass198_0 as GClass203;
				if (gclass4 != null)
				{
					this.IsFighting = gclass4.bool_0;
					return;
				}
				GClass207 gclass5 = gclass198_0 as GClass207;
				if (gclass5 != null)
				{
					this.IsActive = !gclass5.bool_0;
				}
			}

			public void method_4(GClass205 gclass205_0)
			{
				this.Location = gclass205_0;
			}

			public void method_5(GClass206 gclass206_0)
			{
				this.Target = gclass206_0;
			}

			public void method_6(GClass202 gclass202_0)
			{
				this.FactionId = (int)gclass202_0.uint_0;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("PropertyChanged.Fody", "3.2.3.0")]
			protected void method_7(PropertyChangedEventArgs propertyChangedEventArgs_0)
			{
				PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
				if (propertyChanged != null)
				{
					propertyChanged(this, propertyChangedEventArgs_0);
				}
			}
		}

		public class GroupInvite
		{
			public string FromName { get; private set; }

			public int FromId { get; private set; }

			public string ToName { get; private set; }

			public int ToId { get; private set; }

			public bool ToMe { get; private set; }

			public GroupInvite(GClass196 gclass196_0, bool bool_0)
			{
				Class13.NP5bWyNzLwONS();
				base..ctor();
				this.FromId = gclass196_0.FromId;
				this.FromName = gclass196_0.FromName;
				this.ToId = gclass196_0.int_0;
				this.ToName = gclass196_0.string_0;
				this.ToMe = bool_0;
			}
		}
	}
}
