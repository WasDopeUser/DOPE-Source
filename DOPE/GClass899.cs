using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using DarkorbitAPI;
using DarkorbitAPI.Structures;
using DOPE.Common;
using DOPE.Common.Models;
using DOPE.Common.Models.Bot;
using DOPE.Core;
using DOPE.UI.Models;

public class GClass899 : GClass894
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
			this.method_0(Class10.propertyChangedEventArgs_23);
		}
	}

	public GClass899(GClass889 gclass889_1, TargetMap targetMap_1)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor(gclass889_1, targetMap_1, "G", int.MinValue);
		this.GalaxyGateType = MapUtils.smethod_10((int)targetMap_1);
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

	private void method_1(Map map_0, Ship ship_0, bool bool_0)
	{
		GClass903 behavior = base.C.Behavior;
		if (ship_0.IsNpc)
		{
			GClass913 gclass = behavior as GClass913;
			if (gclass != null)
			{
				gclass.method_38(false);
			}
		}
	}

	private void method_2(Map map_0, Ship ship_0)
	{
		GClass903 behavior = base.C.Behavior;
		if (ship_0.IsNpc)
		{
			GClass913 gclass = behavior as GClass913;
			if (gclass != null && !gclass.method_37())
			{
				bool flag = map_0.Ships.Count(new Func<KeyValuePair<int, Ship>, bool>(GClass899.<>c.<>c_0.method_0)) == 1;
				gclass.method_38(flag);
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
		GClass922 mainController = base.C.MainController;
		bool? flag;
		if (mainController == null)
		{
			flag = null;
		}
		else
		{
			Controller parent = mainController.Parent;
			if (parent == null)
			{
				flag = null;
			}
			else
			{
				DopeServiceStatus serviceStatus = parent.ServiceStatus;
				flag = ((serviceStatus != null) ? new bool?(serviceStatus.EnabledGG) : null);
			}
		}
		bool? flag2 = flag;
		if (flag2.GetValueOrDefault() && this.vmethod_0())
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
				int_2 = base.C.MapProfile.TargetMap.Resolve(base.C.Hero.FactionId);
				return true;
			}
		}
		int_2 = MapUtils.smethod_12(1, base.C.Hero.FactionId);
		return true;
	}

	[CompilerGenerated]
	private GEnum5 genum5_0;
}
