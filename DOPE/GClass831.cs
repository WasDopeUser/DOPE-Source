using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using DarkorbitAPI;
using DarkorbitAPI.Structures;
using DOPE.Common;
using DOPE.Common.Models;
using DOPE.Common.Models.Bot;
using DOPE.UI.Models;

public class GClass831 : GClass827
{
	public GEnum5 GalaxyGateType
	{
		[CompilerGenerated]
		get
		{
			return this.genum5_0;
		}
		[CompilerGenerated]
		set
		{
			if (this.genum5_0 == value)
			{
				return;
			}
			this.genum5_0 = value;
			this.method_0(Class10.propertyChangedEventArgs_21);
		}
	}

	public GClass831(GClass822 gclass822_1, TargetMap targetMap_1)
	{
		Class13.tMHx78BzgCM8j();
		base..ctor(gclass822_1, targetMap_1, "G", int.MinValue);
		this.GalaxyGateType = MapUtils.smethod_8((int)targetMap_1);
	}

	protected override void OnBind()
	{
		base.OnBind();
		base.C.Game.Map.ShipCreated += this.method_2;
		base.C.Game.Map.ShipDestroyed += this.method_1;
	}

	protected override void OnUnbind()
	{
		base.OnUnbind();
		base.C.Game.Map.ShipCreated -= this.method_2;
		base.C.Game.Map.ShipDestroyed -= this.method_1;
	}

	private void method_1(Map map_0, Ship ship_0)
	{
		GClass835 behavior = base.C.Behavior;
		if (ship_0.IsNpc)
		{
			GClass844 gclass = behavior as GClass844;
			if (gclass != null)
			{
				gclass.method_31(false);
			}
		}
	}

	private void method_2(Map map_0, Ship ship_0)
	{
		GClass835 behavior = base.C.Behavior;
		if (ship_0.IsNpc)
		{
			GClass844 gclass = behavior as GClass844;
			if (gclass != null && !gclass.method_30())
			{
				bool flag = map_0.Ships.Count(new Func<KeyValuePair<int, Ship>, bool>(GClass831.<>c.<>c_0.method_0)) == 1;
				gclass.method_31(flag);
				if (flag)
				{
					base.Log.Info("New wave -- {ship}", ship_0.Name);
				}
			}
		}
	}

	public override bool CheckStopped()
	{
		return !base.C.Map.IsGG;
	}

	protected virtual bool vmethod_0()
	{
		DarkOrbitWebAPI.GalaxyGatesInfo ggInfo = base.Context.Game.Web.GgInfo;
		DarkOrbitWebAPI.jumpgateGate jumpgateGate = (ggInfo != null) ? ggInfo.GetGate(this.GalaxyGateType) : null;
		if (jumpgateGate == null)
		{
			return false;
		}
		MapProfile mapProfile = base.MapProfile;
		SelectedNpcModel selectedNpcModel = (mapProfile != null) ? mapProfile.GetModel(Ship.Default, base.Context.Map, new int?((int)base.Map), 0) : null;
		if (selectedNpcModel != null && selectedNpcModel.Enabled)
		{
			if (jumpgateGate.prepared)
			{
				if (base.Context.Account.JumpGGLastLife || jumpgateGate.livesLeft != 1)
				{
					return true;
				}
			}
			return false;
		}
		return false;
	}

	public override int UpdatePriority()
	{
		int result = base.UpdatePriority();
		DopeServiceStatus serviceStatus = base.C.MainController.Parent.ServiceStatus;
		if (serviceStatus != null && serviceStatus.EnabledGG && this.vmethod_0())
		{
			return result;
		}
		return int.MinValue;
	}

	public virtual bool vmethod_1()
	{
		int mapId = base.Context.Map.MapId;
		GEnum5 galaxyGateType = this.GalaxyGateType;
		DarkOrbitWebAPI.GalaxyGatesInfo ggInfo = base.Context.Game.Web.GgInfo;
		if (((ggInfo != null) ? ggInfo.GetGate(galaxyGateType) : null) == null)
		{
			return false;
		}
		MapProfile mapProfile = base.MapProfile;
		SelectedNpcModel selectedNpcModel = (mapProfile != null) ? mapProfile.GetModel(Ship.Default, base.Context.Map, new int?(mapId), 0) : null;
		return selectedNpcModel != null && mapProfile.NpcWhitelist.LastOrDefault<SelectedNpcModel>() == selectedNpcModel;
	}

	public virtual SelectedNpcModel vmethod_2(Ship ship_0)
	{
		MapProfile mapProfile = base.MapProfile;
		if (mapProfile == null)
		{
			return null;
		}
		return mapProfile.GetModel(Ship.Default, base.C.Map, null, 0);
	}

	public override bool TrySwitchMap(out int int_2)
	{
		if (!base.C.IsStopping)
		{
			if (base.State == ModuleState.Started)
			{
				int_2 = MapUtils.smethod_0(base.C.MapProfile.TargetMap.GetName(), base.C.Hero.FactionId);
				return true;
			}
		}
		int_2 = MapUtils.smethod_10(1, base.C.Hero.FactionId);
		return true;
	}

	[CompilerGenerated]
	private GEnum5 genum5_0;
}
