using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace Emdat.SoftwareSite.Models
{
    public class InSyncViewModel : ApplicationViewModel
    {
        public string SupportedRecorderWarning { get; set; }
    }

    public class ApplicationViewModel
    {
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
    }
}