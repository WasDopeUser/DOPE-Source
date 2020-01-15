using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;
using DarkorbitAPI.Structures;

public class GClass843 : GClass836
{
	private GClass829 Module { get; }

	public GClass843(GClass822 gclass822_1, GClass829 gclass829_1)
	{
		Class13.nIxas2ezryi9b();
		base..ctor(gclass822_1);
		this.Module = gclass829_1;
	}

	public override bool vmethod_18(GClass824 gclass824_0)
	{
		return gclass824_0 == this.Module;
	}

	public override bool vmethod_8(NpcShip npcShip_0)
	{
		NpcUtils.NpcType type = npcShip_0.Type;
		NpcUtils.NpcClass npcClass = (type != null) ? type.Class : null;
		return (npcClass == NpcUtils.N_Cubikon || Vector2.Distance(this.Module.BestSpawn, npcShip_0.Position) < 800f) && (npcClass != NpcUtils.N_Protegit || !this.method_21()) && base.vmethod_8(npcShip_0);
	}

	public override bool vmethod_13(Collectible collectible_0)
	{
		return Vector2.Distance(this.Module.BestSpawn, collectible_0.Position) < 800f && base.vmethod_13(collectible_0);
	}

	protected override IEnumerable<Vector2> vmethod_22()
	{
		IEnumerator<Vector2> enumerator = this.method_23().GetEnumerator();
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
	public bool method_21()
	{
		return this.bool_2;
	}

	[CompilerGenerated]
	public void method_22(bool bool_3)
	{
		this.bool_2 = bool_3;
	}

	public override void Update()
	{
		base.Update();
		DateTimeOffset left = DateTimeOffset.Now.AddSeconds(30.0);
		this.method_22(left >= this.Module.BestSpawnTime);
	}

	[DebuggerHidden]
	[CompilerGenerated]
	private IEnumerable<Vector2> method_23()
	{
		return base.vmethod_22();
	}

	[CompilerGenerated]
	private readonly GClass829 gclass829_0;

	[CompilerGenerated]
	private bool bool_2;
}
