using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace Pradeep_DotNet_Developer.Localization
{
    public static class Pradeep_DotNet_DeveloperLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(Pradeep_DotNet_DeveloperConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(Pradeep_DotNet_DeveloperLocalizationConfigurer).GetAssembly(),
                        "Pradeep_DotNet_Developer.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
