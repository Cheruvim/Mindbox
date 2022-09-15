namespace Mindbox 
{
    /// <summary>
    /// Базовый класс для фигур.
    /// </summary>
    public abstract class BaseFigure : IFigure 
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="BaseFigure" />.
        /// </summary>
        protected BaseFigure()
        {
            // Могут потребоваться какие-нибудь зависимости и тд.
        }
        
        /// <inheritdoc/>
        public abstract double СalculateArea();
    }
}
