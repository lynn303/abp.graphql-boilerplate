using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace abp.graphql-boilerplate.Localization
{
    public static class graphql-boilerplateLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(graphql-boilerplateConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(graphql-boilerplateLocalizationConfigurer).GetAssembly(),
                        "abp.graphql-boilerplate.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
