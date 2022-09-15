namespace Mindbox.Figures 
{
    using Exeptions;
    using static System.Math;

    /// <summary>
    /// Выполняет расчета для круга.
    /// </summary>
    public class Circle : BaseFigure
    {
        /// <summary>
        /// Радиус круга
        /// </summary>
        private readonly double _radius;

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Circle" />.
        /// </summary>
        /// <param name="radius">Радиус круга.</param>
        public Circle(double radius) : base()
        {
            if (radius <= Constants.RequiredAccuracy)
                throw new ParametersException($"Радиус должен быть больше погрешности ({Constants.RequiredAccuracy}).");

            _radius = radius;
        }
        
        /// <inheritdoc/>
        public override double СalculateArea()
        {
            var s = PI * _radius * _radius;
            return s;
        }
    }
}
