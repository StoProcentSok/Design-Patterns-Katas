using Adapter;
using Adapter.ExternalSystemData;

namespace ObjectAdapter
{
    public class CityAdapter : ICityAdapter
    {
        public ExternalSystem ExternalSystem { get; private set; } = new();
        public City GetCity()
        {
            var cityFromExternalSystem = this.ExternalSystem.GetCity();

            return new City($"{cityFromExternalSystem.Name} - {cityFromExternalSystem.NickName}", cityFromExternalSystem.Inhabitants);
        }
    }
}
