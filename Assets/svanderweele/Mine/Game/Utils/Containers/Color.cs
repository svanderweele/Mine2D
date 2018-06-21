namespace svanderweele.Mine.Game.Utils.Containers
{
    public class Color
    {
        public float r;
        public float g;
        public float b;
        public float a;
        public static Color white = new Color(1.0f, 1.0f, 1.0f ,1.0f);

        public Color()
        {
            this.r = white.r;
            this.g = white.g;
            this.b = white.b;
            this.a = white.a;
        }

        public Color(float r, float g, float b, float a)
        {
            this.r = r;
            this.g = g;
            this.b = b;
            this.a = a;
        }
    }
}