using Pradeep_DotNet_Developer.Debugging;

namespace Pradeep_DotNet_Developer
{
    public class Pradeep_DotNet_DeveloperConsts
    {
        public const string LocalizationSourceName = "Pradeep_DotNet_Developer";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "b0d90b646d1f4ac5a1a42b46354a70c9";
    }
}
