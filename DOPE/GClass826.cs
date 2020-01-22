using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using DOPE.Common;
using DOPE.Common.Models;
using DOPE.Common.Models.Bot;

public class GClass826 : GClass824
{
	public MapProfile CollectProfile
	{
		[CompilerGenerated]
		get
		{
			return this.mapProfile_1;
		}
		[CompilerGenerated]
		protected set
		{
			if (object.Equals(this.mapProfile_1, value))
			{
				return;
			}
			this.mapProfile_1 = value;
			this.method_0(Class10.propertyChangedEventArgs_10);
		}
	}

	public MapProfile SellProfile
	{
		[CompilerGenerated]
		get
		{
			return this.mapProfile_2;
		}
		[CompilerGenerated]
		protected set
		{
			if (object.Equals(this.mapProfile_2, value))
			{
				return;
			}
			this.mapProfile_2 = value;
			this.method_0(Class10.propertyChangedEventArgs_52);
		}
	}

	public GClass826(GClass822 gclass822_1)
	{
		Class13.plZSWFPzBWWEZ();
		this.bool_0 = true;
		base..ctor(gclass822_1, "Palladium", int.MinValue);
		this.gclass840_0 = new GClass840(gclass822_1);
		this.gclass841_0 = new GClass841(gclass822_1);
	}

	public override MapProfile UpdateProfile(BotProfile botProfile_1)
	{
		MapProfile collectProfile;
		if (botProfile_1 == null)
		{
			collectProfile = null;
		}
		else
		{
			List<MapProfile> maps = botProfile_1.Maps;
			if (maps == null)
			{
				collectProfile = null;
			}
			else
			{
				collectProfile = maps.FirstOrDefault(new Func<MapProfile, bool>(GClass826.<>c.<>c_0.method_0));
			}
		}
		this.CollectProfile = collectProfile;
		if (this.CollectProfile != null)
		{
			this.SellProfile = DataUtils.DeepClone<MapProfile>(this.CollectProfile);
			this.SellProfile.TargetMap = TargetMap.P52;
			MapProfile sellProfile = this.SellProfile;
			this.SellProfile.Collector = false;
			sellProfile.Hunter = false;
			this.CollectProfile.CollectPalladium = true;
		}
		return this.CollectProfile;
	}

	public override GClass835 GetBehavior()
	{
		int mapId = base.Context.Map.MapId;
		if (mapId == 93)
		{
			return this.gclass840_0;
		}
		if (mapId == 92)
		{
			return this.gclass841_0;
		}
		return base.GetBehavior();
	}

	public override int UpdatePriority()
	{
		if (this.CollectProfile != null)
		{
			AccountSettings account = base.C.Account;
			if (((account != null) ? account.HangarPalladiumSell : null) != null)
			{
				AccountSettings account2 = base.C.Account;
				if (((account2 != null) ? account2.HangarPalladiumCollect : null) != null)
				{
					return base.UpdatePriority();
				}
			}
		}
		return int.MinValue;
	}

	public override void UpdateState()
	{
		base.UpdateState();
		if (base.State == ModuleState.Started && base.C.Hero.CargoCapacity > 1)
		{
			string activeHangarName = base.Context.Game.Web.Equipment.ActiveHangarName;
			if (activeHangarName != null)
			{
				if (activeHangarName == base.Context.Account.HangarPalladiumCollect)
				{
					this.bool_0 = (base.C.Hero.FreeCargo > 50);
					return;
				}
				this.bool_0 = this.CheckStopped();
			}
		}
	}

	protected override void OnStopping()
	{
		base.OnStopping();
		this.bool_0 = false;
	}

	public override void ClearStats()
	{
		base.ClearStats();
		this.bool_0 = true;
	}

	public override bool CheckStopped()
	{
		return base.Context.Hero.ResourcePalladium < 15.0;
	}

	public override MapProfile GetMapProfile()
	{
		if (base.Context.Account.HangarPalladiumCollect == base.Context.Account.HangarPalladiumSell)
		{
			if (!this.bool_0)
			{
				return this.SellProfile;
			}
			return this.CollectProfile;
		}
		else
		{
			if (!(base.Context.Game.Web.Equipment.ActiveHangarName == base.Context.Account.HangarPalladiumSell))
			{
				return this.CollectProfile;
			}
			return this.SellProfile;
		}
	}

	public override string ToString()
	{
		return "Palladium " + (this.bool_0 ? "collector" : "seller");
	}

	public override bool ShouldChangeHangar(out string string_1)
	{
		string_1 = (this.bool_0 ? base.C.Account.HangarPalladiumCollect : base.C.Account.HangarPalladiumSell);
		return string_1 != null;
	}

	public readonly GClass840 gclass840_0;

	public readonly GClass841 gclass841_0;

	[CompilerGenerated]
	private MapProfile mapProfile_1;

	[CompilerGenerated]
	private MapProfile mapProfile_2;

	public bool bool_0;
}
