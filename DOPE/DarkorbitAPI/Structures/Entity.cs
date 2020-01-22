using System;
using System.Numerics;

namespace DarkorbitAPI.Structures
{
	public abstract class Entity
	{
		public virtual int PosX
		{
			get
			{
				return this._posX;
			}
			protected set
			{
				this._posX = value;
			}
		}

		public virtual int PosY
		{
			get
			{
				return this._posY;
			}
			protected set
			{
				this._posY = value;
			}
		}

		public virtual Vector2 Position
		{
			get
			{
				return new Vector2((float)this.PosX, (float)this.PosY);
			}
		}

		protected Entity(int int_0, int int_1)
		{
			Class13.plZSWFPzBWWEZ();
			this.SyncRoot = new object();
			base..ctor();
			this._posX = int_0;
			this._posY = int_1;
		}

		public virtual void vmethod_0(out int int_0, out int int_1, out int int_2, out int int_3, out int int_4)
		{
			int_0 = (int_2 = this.PosX);
			int_1 = (int_3 = this.PosY);
			int_4 = 0;
		}

		protected readonly object SyncRoot;

		protected int _posX;

		protected int _posY;
	}
}
