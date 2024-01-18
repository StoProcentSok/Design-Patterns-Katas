using Adapter;
using Adapter.ExternalSystemData;

namespace ClassAdapter
{
    //Adapting target
    public interface ICityAdapter
    {
        City GetCity();
    }

    public class CityAdapter : ExternalSystem, ICityAdapter
    {   
        public City GetCity()
        {
            var cityFromExternalSystem = base.GetCity();

            return new City($"{cityFromExternalSystem.Name} - {cityFromExternalSystem.NickName}", cityFromExternalSystem.Inhabitants);
        }
    }
}
