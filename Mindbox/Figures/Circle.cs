namespace Mindbox.Figures 
{
    using Exeptions;
    using static System.Math;

    public class Circle : BaseFigure
    {
        private readonly double _radius;

        public Circle(double radius) : base()
        {
            if (radius <= Constants.RequiredAccuracy)
                throw new ParametersException($"Радиус должен быть больше погрешности ({Constants.RequiredAccuracy}).");

            _radius = radius;
        }
        
        public override double СalculateArea()
        {
            var s = PI * _radius * _radius;
            return s;
        }
    }
}
