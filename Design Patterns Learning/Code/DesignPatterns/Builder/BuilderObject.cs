namespace Builder
{
    public abstract class BuilderObject
    {
        public abstract void Build();
        public abstract ProductObject GetResult();
    }
}