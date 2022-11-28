namespace Learning.CSharp
{
    internal class BikeRepository
    {
        public BikeRepository()
        {
        }

        public IEnumerable<object> Bikes { get; internal set; }
    }
}