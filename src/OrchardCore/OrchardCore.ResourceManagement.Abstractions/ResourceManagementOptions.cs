namespace OrchardCore.ResourceManagement
{
    public class ResourceManagementOptions
    {
        public bool UseCdn { get; set; }

        public string CdnBaseUrl { get; set; }

        public bool DebugMode { get; set; }

        public string Culture { get; set; }

        public bool AppendVersion { get; set; }

        /// <summary>
        /// The prefix path that is used when a url starts with "~/".
        /// </summary>
        public string ContentBasePath { get; set; }
    }
}
