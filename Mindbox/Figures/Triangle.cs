namespace Mindbox.Figures 
{
    using Exeptions;
    using System;
    using static System.Math;

    public class Triangle : BaseFigure {
        private readonly double _firstSide;
        private readonly double _secondSide;
        private readonly double _thirdSide;

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

        public override double СalculateArea()
        {
            var p = (_firstSide + _secondSide + _thirdSide) / 2;
            var s = Sqrt(p * (p - _firstSide) * (p - _secondSide) * (p - _thirdSide));
            return s;
        }

        public bool IsRightTriangle()
        {
            var max = Max(_firstSide, Max(_secondSide, _thirdSide));
            //// Числа с плавующей точкой не идеально точные и на 10**(-6) могут начать искажать результат
            var condition = Math.Abs(Pow(max, 2) * 2 - (Pow(_firstSide, 2) + Pow(_secondSide, 2) + Pow(_thirdSide, 2))) < Constants.RequiredAccuracy;
            
            return condition;
        }
    }
}
