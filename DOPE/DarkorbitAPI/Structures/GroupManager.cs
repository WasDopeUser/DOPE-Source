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
		internal void method_0(GClass246 gclass246_0)
		{
			Vector2 value = new Vector2((float)gclass246_0.int_0, (float)gclass246_0.int_2);
			foreach (GroupManager.GroupMember groupMember in this.caKbcCjAjJ())
			{
				if (Vector2.Distance(groupMember.Position, value) < 1200f)
				{
					groupMember.LastPinged = DateTimeOffset.Now;
				}
			}
		}

		public bool method_1(int int_0)
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
				this.method_11(Class5.IsOwner);
				this.method_11(Class5.Hero);
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
				this.method_11(Class5.InviteList);
				this.method_11(Class5.propertyChangedEventArgs_35);
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
				this.method_11(Class5.MemberList);
				this.method_11(Class5.propertyChangedEventArgs_72);
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
				this.method_11(Class5.IsOwner);
				this.method_11(Class5.propertyChangedEventArgs_44);
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
				this.method_11(Class5.IsOwner);
				this.method_11(Class5.propertyChangedEventArgs_77);
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
				this.method_11(Class5.Id);
			}
		}

		public GroupManager(Hero hero_0)
		{
			Class13.xnk8ImWzpOt04();
			base..ctor();
			this.Hero = hero_0;
			this.Invites = new ConcurrentDictionary<int, GroupManager.GroupInvite>();
			this.Members = new ConcurrentDictionary<int, GroupManager.GroupMember>();
		}

		private void method_2()
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

		public void method_3(GClass194 gclass194_0)
		{
			this.Invites[gclass194_0.FromId] = new GroupManager.GroupInvite(gclass194_0, gclass194_0.int_0 == this.Hero.Id);
			this.method_2();
			EventHandler<GClass194> inviteAdded = this.InviteAdded;
			if (inviteAdded == null)
			{
				return;
			}
			inviteAdded(this, gclass194_0);
		}

		public void method_4(GClass212 gclass212_0)
		{
			GroupManager.GroupInvite groupInvite;
			if (this.Invites.TryRemove(gclass212_0.FromId, out groupInvite))
			{
				this.method_2();
				EventHandler<GClass212> inviteRemoved = this.InviteRemoved;
				if (inviteRemoved == null)
				{
					return;
				}
				inviteRemoved(this, gclass212_0);
			}
		}

		public void method_5(GClass193 gclass193_0)
		{
			GroupManager.GroupMember groupMember;
			if (!this.Members.TryGetValue(gclass193_0.Id, out groupMember))
			{
				groupMember = (this.Members[gclass193_0.Id] = new GroupManager.GroupMember());
			}
			groupMember.method_1(gclass193_0);
			this.method_2();
		}

		public void method_6(GClass192 gclass192_0)
		{
			this.Clear();
			this.OwnerId = gclass192_0.int_1;
			this.IsInitialized = true;
			foreach (GClass193 gclass193_ in gclass192_0.vector_0)
			{
				this.method_5(gclass193_);
			}
		}

		public void method_7(GClass210 gclass210_0)
		{
			GroupManager.GroupMember groupMember;
			if (this.Members.TryGetValue(gclass210_0.int_0, out groupMember))
			{
				groupMember.method_2(gclass210_0);
			}
		}

		public void method_8(GClass191 gclass191_0)
		{
			this.Clear();
		}

		public void method_9(GClass213 gclass213_0)
		{
			this.OwnerId = gclass213_0.int_0;
		}

		public void method_10(GClass211 gclass211_0)
		{
			GroupManager.GroupMember groupMember;
			this.Members.TryRemove(gclass211_0.int_1, out groupMember);
			if (gclass211_0.int_1 == this.Hero.Id)
			{
				this.Clear();
				return;
			}
			this.method_2();
		}

		public void Clear()
		{
			this.IsInitialized = false;
			this.Invites.Clear();
			this.Members.Clear();
			this.method_2();
		}

		public IEnumerable<GroupManager.GroupMember> caKbcCjAjJ()
		{
			GroupManager.<>c__DisplayClass45_0 CS$<>8__locals1 = new GroupManager.<>c__DisplayClass45_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.hPos = this.Hero.Position;
			CS$<>8__locals1.map = this.Hero.Game.Map.MapId;
			return this.Members.Values.Where(new Func<GroupManager.GroupMember, bool>(CS$<>8__locals1.method_0)).OrderBy(new Func<GroupManager.GroupMember, float>(CS$<>8__locals1.method_1));
		}

		public event EventHandler<GClass194> InviteAdded;

		public event EventHandler<GClass212> InviteRemoved;

		public event PropertyChangedEventHandler PropertyChanged;

		[GeneratedCode("PropertyChanged.Fody", "3.2.3.0")]
		[DebuggerNonUserCode]
		protected void method_11(PropertyChangedEventArgs propertyChangedEventArgs_0)
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
					this.method_6(Class5.Id);
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
					this.method_6(Class5.Name);
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
					this.method_6(Class5.propertyChangedEventArgs_44);
				}
			}

			public GClass203 Location
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
					this.method_6(Class5.propertyChangedEventArgs_78);
					this.method_6(Class5.MapId);
					this.method_6(Class5.propertyChangedEventArgs_69);
				}
			}

			public override Vector2 Position
			{
				get
				{
					if (this.Location != null)
					{
						return new Vector2((float)this.Location.int_1, (float)this.Location.int_0);
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
					GClass203 location = this.Location;
					if (location == null)
					{
						return 0;
					}
					return location.MapId;
				}
			}

			public GClass197 ShipInfo
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
					this.method_6(Class5.propertyChangedEventArgs_101);
				}
			}

			public GClass204 Target
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
					this.method_6(Class5.propertyChangedEventArgs_105);
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
					this.method_6(Class5.propertyChangedEventArgs_22);
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
					this.method_6(Class5.propertyChangedEventArgs_39);
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
					this.method_6(Class5.propertyChangedEventArgs_36);
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
					this.method_6(Class5.propertyChangedEventArgs_42);
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
					this.method_6(Class5.propertyChangedEventArgs_59);
				}
			}

			public event PropertyChangedEventHandler PropertyChanged;

			public bool method_0(out GClass204 gclass204_0)
			{
				gclass204_0 = this.Target;
				return gclass204_0 != null && gclass204_0.gclass206_0.int_0 > 0;
			}

			public GroupMember()
			{
				Class13.xnk8ImWzpOt04();
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

			public void method_1(GClass193 gclass193_0)
			{
				this.Clear();
				this.IsInitialized = true;
				this.method_3(gclass193_0.gclass203_0);
				this.Id = gclass193_0.Id;
				this.Name = gclass193_0.Name;
				this.method_4(gclass193_0.gclass204_0);
				this.IsCloaked = gclass193_0.bool_1;
				this.IsActive = !gclass193_0.bool_3;
				this.method_5(gclass193_0.gclass200_0);
			}

			public void method_2(GClass210 gclass210_0)
			{
				foreach (GClass196 gclass196_ in gclass210_0.vector_0)
				{
					this.MnvbuhtktE(gclass196_);
				}
			}

			public void MnvbuhtktE(GClass196 gclass196_0)
			{
				GClass203 gclass = gclass196_0 as GClass203;
				if (gclass != null)
				{
					this.method_3(gclass);
					return;
				}
				GClass204 gclass2 = gclass196_0 as GClass204;
				if (gclass2 != null)
				{
					this.method_4(gclass2);
					return;
				}
				GClass200 gclass3 = gclass196_0 as GClass200;
				if (gclass3 != null)
				{
					this.method_5(gclass3);
					return;
				}
				GClass201 gclass4 = gclass196_0 as GClass201;
				if (gclass4 != null)
				{
					this.IsFighting = gclass4.bool_0;
					return;
				}
				GClass205 gclass5 = gclass196_0 as GClass205;
				if (gclass5 != null)
				{
					this.IsActive = !gclass5.bool_0;
				}
			}

			public void method_3(GClass203 gclass203_0)
			{
				this.Location = gclass203_0;
			}

			public void method_4(GClass204 gclass204_0)
			{
				this.Target = gclass204_0;
			}

			public void method_5(GClass200 gclass200_0)
			{
				this.FactionId = gclass200_0.int_0;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("PropertyChanged.Fody", "3.2.3.0")]
			protected void method_6(PropertyChangedEventArgs propertyChangedEventArgs_0)
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

			public GroupInvite(GClass194 gclass194_0, bool bool_0)
			{
				Class13.xnk8ImWzpOt04();
				base..ctor();
				this.FromId = gclass194_0.FromId;
				this.FromName = gclass194_0.FromName;
				this.ToId = gclass194_0.int_0;
				this.ToName = gclass194_0.string_0;
				this.ToMe = bool_0;
			}
		}
	}
}
