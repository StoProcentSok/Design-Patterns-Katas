namespace Adapter
{
    public class City
    {
        public string FullName { get; private set; }
        public long Inhabitants { get; private set; }

        public City(string fullName, long inhabitants)
        {
            this.FullName = fullName;
            this.Inhabitants = inhabitants;
        }
    }
}
