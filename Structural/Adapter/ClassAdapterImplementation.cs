using Adapter;
using Adapter.ExternalSystemData;

namespace ClassAdapter
{
    public class CityAdapter : ExternalSystem, ICityAdapter
    {   
        public City GetCity()
        {
            var cityFromExternalSystem = base.GetCity();

            return new City($"{cityFromExternalSystem.Name} - {cityFromExternalSystem.NickName}", cityFromExternalSystem.Inhabitants);
        }
    }
}
