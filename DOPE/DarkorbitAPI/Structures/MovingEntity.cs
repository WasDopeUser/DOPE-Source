using System;
using System.Numerics;

namespace DarkorbitAPI.Structures
{
	public abstract class MovingEntity : Entity
	{
		protected MovingEntity(int int_0, int int_1)
		{
			Class13.lOBHd9Nzn7x2T();
			base..ctor(int_0, int_1);
		}

		private protected DateTime MovementStarted { protected get; private set; }

		public DateTime LastUpdated { get; private set; }

		public bool IsIdle
		{
			get
			{
				return this.LastUpdated.Cooldown(30000);
			}
		}

		private protected Vector2 StartPosition { protected get; private set; }

		public float TemporarySpeed { get; private set; }

		public int TimeToTargetLeft
		{
			get
			{
				return this._timeLeft;
			}
		}

		public Vector2? TargetPosition { get; protected set; }

		public double TimeToTarget { get; private set; }

		public override Vector2 Position
		{
			get
			{
				this.method_7();
				return new Vector2((float)this._posX, (float)this._posY);
			}
		}

		public override int PosX
		{
			get
			{
				this.method_7();
				return this._posX;
			}
			protected set
			{
				this.Reset();
				this._posX = value;
			}
		}

		public override int PosY
		{
			get
			{
				this.method_7();
				return this._posY;
			}
			protected set
			{
				this.Reset();
				this._posY = value;
			}
		}

		public void Reset()
		{
			this.method_7();
			this.TargetPosition = null;
		}

		protected void method_0(GClass228 gclass228_0)
		{
			if (!(this is Hero))
			{
				return;
			}
			if (gclass228_0.int_0 == gclass228_0.int_1)
			{
			}
		}

		public virtual bool CanMove
		{
			get
			{
				return true;
			}
		}

		public Vector2 method_1(int int_0)
		{
			DateTime dateTime = DateTime.Now.AddMilliseconds((double)int_0);
			double value = 0.0;
			Vector2? vector = null;
			Vector2 vector2 = default(Vector2);
			object syncRoot = this.SyncRoot;
			Vector2 startPosition;
			DateTime movementStarted;
			lock (syncRoot)
			{
				vector = this.TargetPosition;
				if (vector == null || int_0 == 0)
				{
					return this.Position;
				}
				vector2 = vector.Value;
				startPosition = this.StartPosition;
				movementStarted = this.MovementStarted;
				value = this.TimeToTarget;
			}
			if (dateTime >= movementStarted.AddMilliseconds(value))
			{
				return vector2;
			}
			double num = (dateTime - movementStarted).TotalMilliseconds / this.TimeToTarget;
			return new Vector2((float)((int)((double)startPosition.X + (double)(vector2.X - startPosition.X) * num)), (float)((int)((double)startPosition.Y + (double)(vector2.Y - startPosition.Y) * num)));
		}

		public int method_2(int int_0, int int_1, int int_2)
		{
			DateTime now = DateTime.Now;
			object syncRoot = this.SyncRoot;
			lock (syncRoot)
			{
				this.Reset();
				this.TimeToTarget = (double)int_2;
				this.StartPosition = new Vector2((float)this._posX, (float)this._posY);
				this.TargetPosition = new Vector2?(new Vector2((float)int_0, (float)int_1));
				this._lastTarget = this.TargetPosition;
				this.TemporarySpeed = Vector2.Distance(this.StartPosition, this.TargetPosition.Value) * 1000f / (float)int_2;
				this.LastUpdated = now;
				this.MovementStarted = now;
			}
			return int_2;
		}

		public static int smethod_0(int int_0, int int_1, int int_2, int int_3, float float_0)
		{
			return (int)Math.Round((double)(Vector2.Distance(new Vector2((float)int_0, (float)int_1), new Vector2((float)int_2, (float)int_3)) * 1000f / float_0));
		}

		public int method_3(int int_0, int int_1, float float_0)
		{
			return (int)Math.Round((double)(Vector2.Distance(this.Position, new Vector2((float)int_0, (float)int_1)) * 1000f / float_0));
		}

		public int method_4(int int_0, int int_1, int int_2)
		{
			if (int_2 == 0)
			{
				object syncRoot = this.SyncRoot;
				lock (syncRoot)
				{
					this.Reset();
				}
				return 0;
			}
			return this.method_2(int_0, int_1, this.method_3(int_0, int_1, (float)int_2 * 0.97f));
		}

		public void method_5(int int_0, int int_1, int int_2, int int_3, int int_4)
		{
			object syncRoot = this.SyncRoot;
			lock (syncRoot)
			{
				this.Reset();
				this._posX = int_0;
				this._posY = int_1;
				this.method_4(int_2, int_3, int_4);
			}
		}

		protected void method_6()
		{
			this.method_7();
			if (this.TargetPosition != null)
			{
				Vector2 value = this.TargetPosition.Value;
				this.method_2((int)(value.X + ((float)this._posX - value.X) * 2f), (int)(value.Y + ((float)this._posY - value.Y) * 2f), this._timeLeft);
			}
		}

		public void method_7()
		{
			object syncRoot = this.SyncRoot;
			lock (syncRoot)
			{
				Vector2? targetPosition = this.TargetPosition;
				this._timeLeft = 0;
				if (targetPosition != null)
				{
					DateTime now = DateTime.Now;
					Vector2 value = targetPosition.Value;
					double totalMilliseconds = (now - this.MovementStarted).TotalMilliseconds;
					if (totalMilliseconds > this.TimeToTarget)
					{
						this._posX = (int)value.X;
						this._posY = (int)value.Y;
						this.TargetPosition = null;
						this.TemporarySpeed = 0f;
					}
					else
					{
						this._timeLeft = (int)(this.MovementStarted.AddMilliseconds(this.TimeToTarget) - now).TotalMilliseconds;
						float num = value.X - this.StartPosition.X;
						double num2 = (double)(value.Y - this.StartPosition.Y);
						double num3 = (double)num / this.TimeToTarget;
						double num4 = num2 / this.TimeToTarget;
						this._posX = (int)((double)this.StartPosition.X + num3 * totalMilliseconds);
						this._posY = (int)((double)this.StartPosition.Y + num4 * totalMilliseconds);
						this.LastUpdated = now;
					}
				}
			}
		}

		public override void vmethod_0(out int int_0, out int int_1, out int int_2, out int int_3, out int int_4)
		{
			this.method_7();
			int_0 = this._posX;
			int_1 = this._posY;
			if (this.TargetPosition == null)
			{
				int_2 = int_0;
				int_3 = int_1;
				int_4 = 0;
				return;
			}
			int_2 = (int)this.TargetPosition.Value.X;
			int_3 = (int)this.TargetPosition.Value.Y;
			int_4 = this._timeLeft;
		}

		private int _timeLeft;

		protected Vector2? _lastTarget;
	}
}
