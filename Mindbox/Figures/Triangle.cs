namespace Mindbox.Figures 
{
    using Exeptions;
    using System;
    using static System.Math;

    /// <summary>
    /// Выполняет расчета для треугольника.
    /// </summary>
    public class Triangle : BaseFigure 
    {
        /// <summary>
        /// Первая сторона.
        /// </summary>
        private readonly double _firstSide;
        
        /// <summary>
        /// Вторая сторона.
        /// </summary>
        private readonly double _secondSide;
        
        /// <summary>
        /// Третья сторона.
        /// </summary>
        private readonly double _thirdSide;

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Triangle" />.
        /// </summary>
        /// <param name="firstSide">Первая сторона.</param>
        /// <param name="secondSide">Вторая сторона.</param>
        /// <param name="thirdSide">Третья сторона.</param>
        public Triangle(double firstSide, double secondSide, double thirdSide) : base()
        {
            if (firstSide + secondSide < thirdSide || firstSide + thirdSide < secondSide || secondSide + thirdSide < secondSide)
                throw new ParametersException($"Треуголькик со сторонами {firstSide}, {secondSide} и {thirdSide} существовать не может.");
            
            if (firstSide <= Constants.RequiredAccuracy || secondSide <= Constants.RequiredAccuracy || thirdSide <= Constants.RequiredAccuracy)
                throw new ParametersException($"Все стороны треугольника должны быть больше погрешности ({Constants.RequiredAccuracy}).");

            
            _firstSide = firstSide;
            _secondSide = secondSide;
            _thirdSide = thirdSide;
        }

        /// <inheritdoc/>
        public override double СalculateArea()
        {
            var p = (_firstSide + _secondSide + _thirdSide) / 2;
            var s = Sqrt(p * (p - _firstSide) * (p - _secondSide) * (p - _thirdSide));
            return s;
        }

        /// <summary>
        /// Проверяет, является ли триугольник прямоугольынм.
        /// </summary>
        /// <returns>Является ли триугольник прямоугольынм</returns>
        public bool IsRightTriangle()
        {
            var max = Max(_firstSide, Max(_secondSide, _thirdSide));
            //// Числа с плавующей точкой не идеально точные и на 10**(-6) могут начать искажать результат
            var condition = Math.Abs(Pow(max, 2) * 2 - (Pow(_firstSide, 2) + Pow(_secondSide, 2) + Pow(_thirdSide, 2))) < Constants.RequiredAccuracy;
            
            return condition;
        }
    }
}
