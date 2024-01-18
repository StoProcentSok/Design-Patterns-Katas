using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class ObjectAdapterImplementation
    {
    }


    public class CityFromExternalSystem
    {
        public string Name { get; private set; }
        public string NickName { get; private set; }
        public int Inhabitants { get; private set; }

        public CityFromExternalSystem(string name, string nickName, int inhabitants)
        {
            this.Name = name;
            this.NickName = nickName;
            this.Inhabitants = inhabitants;
        }
    }


    //adaptee:
    public class ExternalSystem
    {
        public CityFromExternalSystem GetCity()
        {
            return new CityFromExternalSystem("Antwerp", "'t Stad", 500000);
        }
    }

    public class City
    {
        public string FullName { get; private set; }
        public long Inhabitants { get; private set; }

        public City(string fullName, long inhabitants)
        {
            this.FullName = fullName;
            this.Inhabitants= inhabitants;
        }
    }


    //Adapting target
    public interface ICityAdapter
    {
        City GetCity();
    }

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
