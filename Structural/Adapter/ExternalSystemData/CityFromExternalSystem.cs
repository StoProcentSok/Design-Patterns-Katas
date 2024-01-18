namespace Adapter.ExternalSystemData
{
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
}
