using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Emdat.SoftwareSite.DataAccess
{
    public class DataContext
    {
        public class GetApplicationRow
        {
            public string SupportedOperatingSystemWarning { get; set; }
        }

        public IEnumerable<GetApplicationRow> GetApplication(string programCode)
        {
            switch (programCode)
            {
                case "InSync":
                {
                    return new List<GetApplicationRow>
                    {
                        new GetApplicationRow
                        {
                            SupportedOperatingSystemWarning = "Support is only available for products running on Windows 7 and later operating systems."
                        }
                    };
                }
                default:
                {
                    return Enumerable.Empty<GetApplicationRow>();
                }
            }
        }

        public class GetLatestApplicationVersionsRow
        {
            public string MajorVersionNumber { get; set; }
            public string VersionNumber { get; set; }
            public string InstallerFileName { get; set; }
            public string InstallerFileNameMsi { get; set; }
            public string ManualPdfFileName { get; set; }
            public string ManualWordFileName { get; set; }
        }

        public IEnumerable<GetLatestApplicationVersionsRow> GetLatestApplicationVersions(string programCode)
        {
            switch(programCode)
            {
                case "InSync":
                {
                    return new List<GetLatestApplicationVersionsRow>
                    {
                        new GetLatestApplicationVersionsRow
                        {
                            InstallerFileName = "InSyncSetup_v6.6.18304.exe",
                            InstallerFileNameMsi = "InSyncSetup_v6.6.18304.msi",
                            MajorVersionNumber = "6",
                            ManualPdfFileName = "InSync6 Manual.pdf",
                            ManualWordFileName = "InSync6 Manual.docx",
                            VersionNumber = "6.6.18304"
                        }
                    };
                }
                default:
                {
                    return Enumerable.Empty<GetLatestApplicationVersionsRow>();
                }
            }
        }
    }
}