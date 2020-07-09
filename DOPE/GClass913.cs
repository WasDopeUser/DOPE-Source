using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;
using DarkorbitAPI.Structures;

public class GClass913 : GClass905
{
	private GClass897 Module { get; }

	public GClass913(GClass890 gclass890_1, GClass897 gclass897_1)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor(gclass890_1);
		this.Module = gclass897_1;
	}

	public override bool vmethod_18(GClass892 gclass892_0)
	{
		return gclass892_0 == this.Module;
	}

	public override bool vmethod_7(NpcShip npcShip_0)
	{
		NpcUtils.NpcType type = npcShip_0.Type;
		NpcUtils.NpcClass npcClass = (type != null) ? type.Class : null;
		return (npcClass == NpcUtils.N_Cubikon || Vector2.Distance(this.Module.BestSpawn, npcShip_0.Position) < 800f) && (npcClass != NpcUtils.N_Protegit || !this.method_24()) && base.vmethod_7(npcShip_0);
	}

	public override bool vmethod_12(Collectible collectible_0)
	{
		return Vector2.Distance(this.Module.BestSpawn, collectible_0.Position) < 800f && base.vmethod_12(collectible_0);
	}

	protected override IEnumerable<Vector2> vmethod_22()
	{
		IEnumerator<Vector2> enumerator = this.method_26().GetEnumerator();
		for (;;)
		{
			try
			{
				IL_52:
				if (!enumerator.MoveNext())
				{
					break;
				}
				goto IL_88;
				IL_4A:
				goto IL_52;
			}
			finally
			{
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			break;
			IL_88:
			Vector2 vector = enumerator.Current;
			yield return vector;
			goto IL_4A;
		}
		enumerator = null;
		yield return this.Module.BestSpawn;
		yield break;
		yield break;
	}

	[CompilerGenerated]
	public bool method_24()
	{
		return this.bool_3;
	}

	[CompilerGenerated]
	public void method_25(bool bool_4)
	{
		this.bool_3 = bool_4;
	}

	public override void Update()
	{
		base.Update();
		DateTimeOffset left = DateTimeOffset.Now.AddSeconds(30.0);
		this.method_25(left >= this.Module.BestSpawnTime);
	}

	[DebuggerHidden]
	[CompilerGenerated]
	private IEnumerable<Vector2> method_26()
	{
		return base.vmethod_22();
	}

	[CompilerGenerated]
	private readonly GClass897 gclass897_0;

	[CompilerGenerated]
	private bool bool_3;
}
