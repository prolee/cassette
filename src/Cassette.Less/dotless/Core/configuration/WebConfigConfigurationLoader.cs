namespace dotless.Core.configuration
{
    using System.Configuration;

    class WebConfigConfigurationLoader
    {
        public DotlessConfiguration GetConfiguration()
        {
            var webconfig = (DotlessConfiguration)ConfigurationManager.GetSection("dotless");
            
            if (webconfig == null)
                return DotlessConfiguration.DefaultWeb;

            webconfig.Web = true;

            return webconfig;
        }
    }
}