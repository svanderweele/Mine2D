using UnityEngine;

namespace svanderweele.Mine.Game.Utils.Math
{
    public class Vector2
    {
        public float x;
        public float y;

        public Vector2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public override bool Equals(object obj)
        {
            var b = obj as Vector2;
            return this.x == b.x && this.y == b.y;
        }

        protected bool Equals(Vector2 other)
        {
            return x.Equals(other.x) && y.Equals(other.y);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (x.GetHashCode() * 397) ^ y.GetHashCode();
            }
        }
    }
}