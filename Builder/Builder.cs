namespace Builder
{
    public abstract class Builder
    {
        public abstract void Build();

        public abstract ProductObject GetResult();
    }
}