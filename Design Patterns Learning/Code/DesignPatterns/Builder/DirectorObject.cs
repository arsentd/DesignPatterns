namespace Builder
{
    public class DirectorObject
    {
        public void Construct(BuilderObject builder)
        {
            builder.Build();
        }
    }
}