using System;
using System.Threading.Tasks;
using DarkorbitAPI;

public class GClass9 : GInterface4
{
	public void Run(GClass235 e)
	{
		GClass9.<>c__DisplayClass0_0 CS$<>8__locals1 = new GClass9.<>c__DisplayClass0_0();
		CS$<>8__locals1.gclass235_0 = e;
		CS$<>8__locals1.connectionManager_0 = ConnectionManager.Instance.Value;
		Task.Run(new Func<Task>(CS$<>8__locals1.method_0));
	}

	public GClass9()
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
	}
}
