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
			foreach (GroupManager.GroupMember groupMember in this.method_11())
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
				this.method_12(Class5.IsOwner);
				this.method_12(Class5.Hero);
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
				this.method_12(Class5.InviteList);
				this.method_12(Class5.propertyChangedEventArgs_37);
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
				this.method_12(Class5.MemberList);
				this.method_12(Class5.propertyChangedEventArgs_75);
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
				this.method_12(Class5.IsOwner);
				this.method_12(Class5.propertyChangedEventArgs_46);
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
				this.method_12(Class5.IsOwner);
				this.method_12(Class5.propertyChangedEventArgs_80);
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
				this.method_12(Class5.Id);
			}
		}

		public GroupManager(Hero hero_0)
		{
			Class13.F93tSdiz1aNIA();
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

		public void method_3(GClass195 gclass195_0)
		{
			this.Invites[gclass195_0.FromId] = new GroupManager.GroupInvite(gclass195_0, gclass195_0.int_0 == this.Hero.Id);
			this.method_2();
			EventHandler<GClass195> inviteAdded = this.InviteAdded;
			if (inviteAdded == null)
			{
				return;
			}
			inviteAdded(this, gclass195_0);
		}

		public void method_4(GClass213 gclass213_0)
		{
			GroupManager.GroupInvite groupInvite;
			if (this.Invites.TryRemove(gclass213_0.FromId, out groupInvite))
			{
				this.method_2();
				EventHandler<GClass213> inviteRemoved = this.InviteRemoved;
				if (inviteRemoved == null)
				{
					return;
				}
				inviteRemoved(this, gclass213_0);
			}
		}

		public void method_5(GClass194 gclass194_0)
		{
			GroupManager.GroupMember groupMember;
			if (!this.Members.TryGetValue(gclass194_0.Id, out groupMember))
			{
				groupMember = (this.Members[gclass194_0.Id] = new GroupManager.GroupMember());
			}
			groupMember.method_1(gclass194_0);
			this.method_2();
		}

		public void method_6(GClass193 gclass193_0)
		{
			this.Clear();
			this.OwnerId = gclass193_0.wJhiBiqCgE;
			this.IsInitialized = true;
			foreach (GClass194 gclass194_ in gclass193_0.vector_0)
			{
				this.method_5(gclass194_);
			}
		}

		public void method_7(GClass211 gclass211_0)
		{
			GroupManager.GroupMember groupMember;
			if (this.Members.TryGetValue(gclass211_0.int_0, out groupMember))
			{
				groupMember.method_2(gclass211_0);
			}
		}

		public void method_8(GClass192 gclass192_0)
		{
			this.Clear();
		}

		public void method_9(GClass214 gclass214_0)
		{
			this.OwnerId = gclass214_0.int_0;
		}

		public void method_10(GClass212 gclass212_0)
		{
			GroupManager.GroupMember groupMember;
			this.Members.TryRemove(gclass212_0.int_1, out groupMember);
			if (gclass212_0.int_1 == this.Hero.Id)
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

		public IEnumerable<GroupManager.GroupMember> method_11()
		{
			GroupManager.<>c__DisplayClass45_0 CS$<>8__locals1 = new GroupManager.<>c__DisplayClass45_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.hPos = this.Hero.Position;
			CS$<>8__locals1.map = this.Hero.Game.Map.MapId;
			return this.Members.Values.Where(new Func<GroupManager.GroupMember, bool>(CS$<>8__locals1.method_0)).OrderBy(new Func<GroupManager.GroupMember, float>(CS$<>8__locals1.method_1));
		}

		public event EventHandler<GClass195> InviteAdded;

		public event EventHandler<GClass213> InviteRemoved;

		public event PropertyChangedEventHandler PropertyChanged;

		[GeneratedCode("PropertyChanged.Fody", "3.2.3.0")]
		[DebuggerNonUserCode]
		protected void method_12(PropertyChangedEventArgs propertyChangedEventArgs_0)
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
					this.method_7(Class5.propertyChangedEventArgs_46);
				}
			}

			public GClass204 Location
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
					this.method_7(Class5.propertyChangedEventArgs_81);
					this.method_7(Class5.MapId);
					this.method_7(Class5.propertyChangedEventArgs_71);
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
					GClass204 location = this.Location;
					if (location == null)
					{
						return 0;
					}
					return location.MapId;
				}
			}

			public GClass198 ShipInfo
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
					this.method_7(Class5.propertyChangedEventArgs_104);
				}
			}

			public GClass205 Target
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
					this.method_7(Class5.propertyChangedEventArgs_109);
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
					this.method_7(Class5.propertyChangedEventArgs_24);
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
					this.method_7(Class5.propertyChangedEventArgs_41);
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
					this.method_7(Class5.propertyChangedEventArgs_38);
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
					this.method_7(Class5.propertyChangedEventArgs_44);
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
					this.method_7(Class5.propertyChangedEventArgs_61);
				}
			}

			public event PropertyChangedEventHandler PropertyChanged;

			public bool method_0(out GClass205 gclass205_0)
			{
				gclass205_0 = this.Target;
				return gclass205_0 != null && gclass205_0.gclass207_0.int_0 > 0;
			}

			public GroupMember()
			{
				Class13.F93tSdiz1aNIA();
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

			public void method_1(GClass194 gclass194_0)
			{
				this.Clear();
				this.IsInitialized = true;
				this.method_4(gclass194_0.gclass204_0);
				this.Id = gclass194_0.Id;
				this.Name = gclass194_0.Name;
				this.method_5(gclass194_0.gclass205_0);
				this.IsCloaked = gclass194_0.bool_2;
				this.IsActive = !gclass194_0.bool_4;
				this.method_6(gclass194_0.gclass201_0);
			}

			public void method_2(GClass211 gclass211_0)
			{
				foreach (GClass197 gclass197_ in gclass211_0.vector_0)
				{
					this.method_3(gclass197_);
				}
			}

			public void method_3(GClass197 gclass197_0)
			{
				GClass204 gclass = gclass197_0 as GClass204;
				if (gclass != null)
				{
					this.method_4(gclass);
					return;
				}
				GClass205 gclass2 = gclass197_0 as GClass205;
				if (gclass2 != null)
				{
					this.method_5(gclass2);
					return;
				}
				GClass201 gclass3 = gclass197_0 as GClass201;
				if (gclass3 != null)
				{
					this.method_6(gclass3);
					return;
				}
				GClass202 gclass4 = gclass197_0 as GClass202;
				if (gclass4 != null)
				{
					this.IsFighting = gclass4.bool_0;
					return;
				}
				GClass206 gclass5 = gclass197_0 as GClass206;
				if (gclass5 != null)
				{
					this.IsActive = !gclass5.bool_0;
				}
			}

			public void method_4(GClass204 gclass204_0)
			{
				this.Location = gclass204_0;
			}

			public void method_5(GClass205 gclass205_0)
			{
				this.Target = gclass205_0;
			}

			public void method_6(GClass201 gclass201_0)
			{
				this.FactionId = gclass201_0.int_0;
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

			public GroupInvite(GClass195 gclass195_0, bool bool_0)
			{
				Class13.F93tSdiz1aNIA();
				base..ctor();
				this.FromId = gclass195_0.FromId;
				this.FromName = gclass195_0.FromName;
				this.ToId = gclass195_0.int_0;
				this.ToName = gclass195_0.string_0;
				this.ToMe = bool_0;
			}
		}
	}
}
