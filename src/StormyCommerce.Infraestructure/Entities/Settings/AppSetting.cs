namespace StormyCommerce.Core.Entities.Settings
{
    //copy/paste to avoid break the app
    public class AppSettings : EntityBaseWithTypedId<string>
    {
        public AppSettings(string id)
        {
            Id = id;
        }

        public string Value { get; set; }
        public string Module { get; set; }        
        public bool IsVisibleInCommonSettingPage { get; set; }
    }
}
