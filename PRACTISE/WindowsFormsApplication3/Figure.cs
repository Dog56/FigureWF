namespace FiguresWF
{
    internal  class Figure
    {
        public  double Square();

        public virtual double Perimetr { get { return 0; } }

        public override string ToString()
        {
            return "Simple Figure";
        }
    }
}
