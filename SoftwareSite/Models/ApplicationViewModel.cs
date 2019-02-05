using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace Emdat.SoftwareSite.Models
{
    public class ToolsViewModel
    {
        public IEnumerable<Tool> Tools { get; set; }
    }

    public class Tool
    {
        public string Name { get; set; }
        public string InstallerPath { get; set; }
        public string InstallerFileName { get; set; }
        public string ManualPdfFileName { get; set; }
        public string ManualWordFileName { get; set; }
    }

    public class MobileViewModel
    {
        public string Description { get; set; }
        public IEnumerable<HyperLink> ManualLinks { get; set; }
    }

    public class InScribeViewModel : ApplicationViewModel
    {
        public IEnumerable<HyperLink> TrainingFileLinks { get; set; }
    }

    public class InSyncViewModel : ApplicationViewModel
    {
        public string SupportedRecorderWarning { get; set; }
    }

    public class ApplicationViewModel
    {
        public string ApplicationName { get; set; }
        public string ApplicationCode { get; set; }
        public string SupportedOperatingSystemWarning { get; set; }
        public ApplicationVersions VersionInformation { get; set; }
        public IEnumerable<HyperLink> AdditionalLinks { get; set; }
    }
    public class ApplicationVersions
    {
        public IEnumerable<ApplicationVersion> Versions { get; set; }
        public bool ShowVersionHistory { get; set; }
    }

    public class ApplicationVersion
    {
        public string MajorVersionNumber { get; set; }
        public string VersionNumber { get; set; }
        public string InstallerFileName { get; set; }
        public string InstallerFileNameMsi { get; set; }
        public string ManualPdfFileName { get; set; }
        public string ManualWordFileName { get; set; }
        public IEnumerable<string> ReleaseNotes { get; set; }
    }
}