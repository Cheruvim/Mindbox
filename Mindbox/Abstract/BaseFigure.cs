namespace Mindbox 
{
    public abstract class BaseFigure : IFigure 
    {
        protected BaseFigure()
        {
            // Могут потребоваться какие-нибудь зависимости и тд.
        }
        
        public abstract double СalculateArea();
    }
}
