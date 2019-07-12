namespace DesignPatterns
{
    public class Prototype : IPrototype<Prototype>
    {
        public int LadoX { get; set; }
        public int LadoY { get; set; }

        public Prototype(int x, int y)
        {
            this.LadoX = x;
            this.LadoY = y;
        }

        public Prototype clone()
        {
            return new Prototype(this.LadoX, this.LadoY);
        }

        public override string ToString()
        {
            return "Lado X = " + LadoX.ToString() + ", Lado Y = " + LadoY.ToString();
        }
    }
}
