namespace OOPDecoraorCSharp
{
    public abstract class DecoratorFactory : ICarComponent
    {
        protected ICarComponent component;
        //only derived classes can have access to it
        public DecoratorFactory(ICarComponent component) => this.component = component;
        //virtual function can be overriden in the derived classes but not defined

        public virtual string Drive() => component.Drive();



    }
}
