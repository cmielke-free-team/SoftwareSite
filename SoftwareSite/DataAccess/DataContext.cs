using System.Collections.Generic;
using System.Linq;

namespace Emdat.SoftwareSite.DataAccess
{
    public class DataContext
    {
        public class GetApplicationRow
        {
            public string Name { get; set; }
            public string SupportedOperatingSystemWarning { get; set; }
        }

        public IEnumerable<GetApplicationRow> GetApplication(string applicationCode)
        {
            switch (applicationCode)
            {
                case "InSync":
                {
                    return new List<GetApplicationRow>
                    {
                        new GetApplicationRow
                        {
                            Name = "InSync",
                            SupportedOperatingSystemWarning = "Support is only available for products running on Windows 8.1 and later operating systems."
                        }
                    };
                }
                case "InScribe":
                {
                    return new List<GetApplicationRow>
                    {
                        new GetApplicationRow
                        {
                            Name = "InScribe",
                            SupportedOperatingSystemWarning = "Support is only available for products running on Windows 8.1 and later operating systems."
                        }
                    };
                }
                case "ShadowLink":
                {
                    return new List<GetApplicationRow>
                    {
                        new GetApplicationRow
                        {
                            Name = "ShadowLink",
                            SupportedOperatingSystemWarning = "Support is only available for products running on Windows 8.1 and later operating systems."
                        }
                    };
                }
                case "ShadowPrint":
                {
                    return new List<GetApplicationRow>
                    {
                        new GetApplicationRow
                        {
                            Name = "ShadowPrint",
                            SupportedOperatingSystemWarning = "Support is only available for products running on Windows 8.1 and later operating systems."
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
            public string InstallerFileNameUK { get; set; }
            public string InstallerFileNameUKMsi { get; set; }
            public string InstallerFileNameCanada { get; set; }
            public string InstallerFileNameCanadaMsi { get; set; }
            public string ManualPdfFileName { get; set; }
            public string ManualWordFileName { get; set; }
        }

        public IEnumerable<GetLatestApplicationVersionsRow> GetLatestApplicationVersions(string applicationCode)
        {
            switch (applicationCode)
            {
                case "InSync":
                {
                    return new List<GetLatestApplicationVersionsRow>
                    {
                        new GetLatestApplicationVersionsRow
                        {
                            InstallerFileName = "InSyncSetup_6_9_20016_24954.exe",
                            InstallerFileNameMsi = "InSyncSetup_6_9_20016_24954.msi",
                            InstallerFileNameCanada = "InSyncSetup_6_9_20016_24954.exe",
                            InstallerFileNameCanadaMsi = "InSyncSetup_6_9_20016_24954.msi",
                            InstallerFileNameUK = "InSyncSetup_6_9_20016_24954.exe",
                            InstallerFileNameUKMsi = "InSyncSetup_6_9_20016_24954.msi",
                            MajorVersionNumber = "6",
                            ManualPdfFileName = "eScription One InSync Manual February 2019 .pdf",
                            VersionNumber = "6.9.20016"
                        },
                        new GetLatestApplicationVersionsRow
                        {
                            InstallerFileName = "InSyncSetup_6_8_20016_19611.exe",
                            InstallerFileNameMsi = "InSyncSetup_6_8_20016_19611.msi",
                            InstallerFileNameCanada = "InSyncSetup_6_8_20016_19611.exe",
                            InstallerFileNameCanadaMsi = "InSyncSetup_6_8_20016_19611.msi",
                            InstallerFileNameUK = "InSyncSetup_6_8_20016_19611.exe",
                            InstallerFileNameUKMsi = "InSyncSetup_6_8_20016_19611.msi",
                            MajorVersionNumber = "6",
                            ManualPdfFileName = "eScription One InSync Manual February 2019 .pdf",
                            VersionNumber = "6.8.20016"
                        }
                    };
                }
                case "InScribe":
                {
                    return new List<GetLatestApplicationVersionsRow>
                    {
                        new GetLatestApplicationVersionsRow
                        {
                            InstallerFileName = "InScribeSetup_7_2_20007_19765.exe",
                            InstallerFileNameMsi = "InScribeSetup_7_2_20007_19765.msi",
                            InstallerFileNameCanada = "InScribeSetup_7_2_20007_19765.exe",
                            InstallerFileNameCanadaMsi = "InScribeSetup_7_2_20007_19765.msi",
                            InstallerFileNameUK = "InScribeSetup_7_2_20007_19765.exe",
                            InstallerFileNameUKMsi = "InScribeSetup_7_2_20007_19765.msi",
                            MajorVersionNumber = "7",
                            ManualPdfFileName = "eScription One InScribe Manual February 2019.pdf",
                            VersionNumber = "7.2.20007"
                        },
                        new GetLatestApplicationVersionsRow
                        {
                            InstallerFileName = "InScribeSetup_7_1_19260_25829.exe",
                            InstallerFileNameMsi = "InScribeSetup_7_1_19260_25829.msi",
                            InstallerFileNameCanada = "InScribeSetup_7_1_19260_25829.exe",
                            InstallerFileNameCanadaMsi = "InScribeSetup_7_1_19260_25829.msi",
                            InstallerFileNameUK = "InScribeSetup_7_1_19260_25829.exe",
                            InstallerFileNameUKMsi = "InScribeSetup_7_1_19260_25829.msi",
                            MajorVersionNumber = "7",
                            ManualPdfFileName = "eScription One InScribe Manual February 2019.pdf",
                            VersionNumber = "7.1.19260"
                        },
                        new GetLatestApplicationVersionsRow
                        {
                            InstallerFileName = "InScribeSetup_6_16_19071_37797.exe",
                            InstallerFileNameMsi = "InScribeSetup_6_16_19071_37797.msi",
                            InstallerFileNameCanada = "InScribeSetup_6_16_19071_37797.exe",
                            InstallerFileNameCanadaMsi = "InScribeSetup_6_16_19071_37797.msi",
                            InstallerFileNameUK = "InScribeSetup_6_16_19071_37797.exe",
                            InstallerFileNameUKMsi = "InScribeSetup_6_16_19071_37797.msi",
                            MajorVersionNumber = "6",
                            ManualPdfFileName = "eScription One InScribe Manual February 2019.pdf",
                            VersionNumber = "6.16.19071"
                        }
                    };
                }
                case "ShadowLink":
                {
                    return new List<GetLatestApplicationVersionsRow>
                    {
                        new GetLatestApplicationVersionsRow
                        {
                            InstallerFileName = "ShadowLinkSetup_2_8_19070_34621.exe",
                            InstallerFileNameCanada = "ShadowLinkSetup_2_8_19070_34621.exe",
                            InstallerFileNameUK = "ShadowLinkSetup_2_8_19070_34621.exe",
                            MajorVersionNumber = "2",
                            ManualPdfFileName = "eScription One ShadowLink Manual Jan 2019.pdf",
                            VersionNumber = "2.8"
                        }
                    };
                }
                case "ShadowPrint":
                {
                    return new List<GetLatestApplicationVersionsRow>
                    {
                        new GetLatestApplicationVersionsRow
                        {
                            InstallerFileName = "ShadowPrintSetup_2_3_19161_30614.exe",
                            InstallerFileNameCanada = "ShadowPrintSetup_2_3_19161_30614.exe",
                            InstallerFileNameUK = "ShadowPrintSetup_2_3_19161_30614.exe",
                            MajorVersionNumber = "2",
                            ManualPdfFileName = "eScription One ShadowPrint Manual February 2019.pdf",
                            VersionNumber = "2.3"
                        }
                    };
                }
                case "PrintAgent":
                {
                    return new List<GetLatestApplicationVersionsRow>
                    {
                        new GetLatestApplicationVersionsRow
                        {
                            InstallerFileName = "EsOnePrint_1_1_34.exe",
                            MajorVersionNumber = "1",
                            VersionNumber = "1.1.34"
                        }
                    };
                }
                default:
                {
                    return Enumerable.Empty<GetLatestApplicationVersionsRow>();
                }
            }
        }

        public class GetApplicationVersionsRow
        {
            public string VersionNumber { get; set; }
            public IEnumerable<string> ReleaseNotes { get; set; }
        }

        public IEnumerable<GetApplicationVersionsRow> GetApplicationVersions(string applicationCode)
        {
            switch (applicationCode)
            {
                case "InSync":
                {
                    return new List<GetApplicationVersionsRow>
                    {
                        new GetApplicationVersionsRow
                        {
                            VersionNumber = "6.9.20016",
                            ReleaseNotes = new List<string>
                            {
                                "Added hold-to-record option for PowerMic."
                            }
                        },
                        new GetApplicationVersionsRow
                        {
                            VersionNumber = "6.8.20016",
                            ReleaseNotes = new List<string>
                            {
                                "Introduced new login screen.",
                                "Added support for Australia."
                            }
                        },
                        new GetApplicationVersionsRow
                        {
                            VersionNumber = "6.7.19070",
                            ReleaseNotes = new List<string>
                            {
                                "Updated user interface.",
                                "Added support for new regions."
                            }
                        },
                        new GetApplicationVersionsRow
                        {
                            VersionNumber = "6.6.18304",
                            ReleaseNotes = new List<string>
                            {
                                "Added functionality to remember window size and position.",
                                "Added option to launch application in main window.",
                                "Added new foot pedal options."
                            }
                        },
                        new GetApplicationVersionsRow
                        {
                            VersionNumber = "6.5.18255",
                            ReleaseNotes = new List<string>
                            {
                                "Security updates."
                            }
                        },
                        new GetApplicationVersionsRow
                        {
                            VersionNumber = "6.4.18163",
                            ReleaseNotes = new List<string>
                            {
                                "Added TLS 1.2 support for Windows 7 and Windows Server 2008 R2."
                            }
                        },
                        new GetApplicationVersionsRow
                        {
                            VersionNumber = "6.3.18149",
                            ReleaseNotes = new List<string>
                            {
                                "Added functionality to stop recording, save the dictation to disk and notify the user when a dictation reaches the maximum recording length of 90 minutes.",
                                "Updated installer to inform user that .NET Framework 4.7 is required.",
                                "Resolved issue with time stamp not appearing for new dictations."
                            }
                        },
                        new GetApplicationVersionsRow
                        {
                            VersionNumber = "6.2.18113",
                            ReleaseNotes = new List<string>
                            {
                                "Added ability to validate email address.",
                                "Resolved issue preventing cursor from initially appearing in search field when recording a dictation."
                            }
                        },
                        new GetApplicationVersionsRow
                        {
                            VersionNumber = "6.1.18022",
                            ReleaseNotes = new List<string>
                            {
                                "Added native support for TLS 1.2."
                            }
                        },
                        new GetApplicationVersionsRow
                        {
                            VersionNumber = "6.0.17080",
                            ReleaseNotes = new List<string>
                            {
                                "Dictation Log auto-refreshes every 5 minutes and can be manually refreshed.",
                                "Account Number and Order number columns added to the Dictation Log.",
                                "Updated Record tab:",
                                "-  Patient search relocated to Dictator, Document Type, Location section.",
                                "-  Appointment searches will be initiated after patient search.",
                                "-  Order grid added.",
                                "Support added for Philips 9370 and 9380.",
                                "PowerMic Updates:",
                                "-  Configuration can be personalized.",
                                "-  Patient search is initiated upon scan.",
                                "Support added for USB foot pedals."
                            }
                        }
                    };
                }
                case "InScribe":
                {
                    return new List<GetApplicationVersionsRow>
                    {
                        new GetApplicationVersionsRow
                        {
                            VersionNumber = "7.2.20007",
                            ReleaseNotes = new List<string>
                            {
                                "Introduced new login page.",
                                "Introduced skip silence feature.",
                                "Added button to Data tab and shortcut key to insert associate data into transcription text.",
                                "Added keyboard shortcut support for prior dictation playback.",
                                "Added support for the Australia region.",
                                "Resolved paragraph, lists and table formatting issues.",
                                "Resolved cursor focus issues.",
                                "Resolved issue with failure to restore AutoText files.",
                                "Resolved spacing differences in Preview.",
                                "Resolved issue with \"Can Print Tran\" setting not being honored.",
                            }
                        },
                        new GetApplicationVersionsRow
                        {
                            VersionNumber = "7.1.19260",
                            ReleaseNotes = new List<string>
                            {
                                "Enhanced Prior Transcriptions window to allow viewing multiple priors at once.",
                                "Added ability to listen to dictations for prior transcriptions.",
                                "Updated dictionaries.",
                                "Added keyboard shortcut import / export feature to allow customization of keyboard shortcuts.",
                                "Resolved issues with Ctrl + Arrow key navigation.",
                                "Resolved issues with formatting in template fields and copied text from prior transcriptions.",
                                "Resolved issues with Continue / Set Numbering."
                            }
                        },
                        new GetApplicationVersionsRow
                        {
                            VersionNumber = "7.0.19205",
                            ReleaseNotes = new List<string>
                            {
                                "Resolved issue with invalid Benchmark KB credentials being saved.",
                                "Resolved issue with spell check getting stuck between two words.",
                                "Resolved issue with incorrect cursor placement after auto capitalization.",
                                "Resolved issue with Benchmark KB associate search not returning results.",
                                "Resolved issue with cursor not moving to next field upon F1 key press.",
                                "Resolved issue with QT text highlighting being removed when navigating document.",
                                "Resolved issue with not being able to insert dictation templates with tables.",
                            }
                        },
                        new GetApplicationVersionsRow
                        {
                            VersionNumber = "7.0.19176",
                            ReleaseNotes = new List<string>
                            {
                                "Added option to skip flagged words in spell checker.",
                                "Resolved issue with spell checker \"Change All\" option removing flag for all misspelled words.",
                                "Resolved issue with disabled table borders appearing in editor and delivered document."
                            }
                        },
                        new GetApplicationVersionsRow
                        {
                            VersionNumber = "7.0.19149",
                            ReleaseNotes = new List<string>
                            {
                                "Enhanced experience when editing structured documents.",
                                "Command shortcuts can be added to the ribbon menu.",
                                "Users can assign ShadowScribe section actions to function keys.",
                                "Users can specify specialty when searching for associates.",
                                "MT notes are displayed before visit selection window appears.",
                                "Dictation template window displays a preview of the dictation template."
                            }
                        },
                        new GetApplicationVersionsRow
                        {
                            VersionNumber = "6.16.19060",
                            ReleaseNotes = new List<string>
                            {
                                "Updated user interface.",
                                "Added support for new regions."
                            }
                        },
                        new GetApplicationVersionsRow
                        {
                            VersionNumber = "6.15.18212",
                            ReleaseNotes = new List<string>
                            {
                                "Resolved issue with AutoText deleting text."
                            }
                        },
                        new GetApplicationVersionsRow
                        {
                            VersionNumber = "6.14.18191",
                            ReleaseNotes = new List<string>
                            {
                                "Resolved issue with login failing on Windows Server 2008 and 2016."
                            }
                        },
                        new GetApplicationVersionsRow
                        {
                            VersionNumber = "6.13.18163.28298",
                            ReleaseNotes = new List<string>
                            {
                                "Added TLS 1.2 support for Windows 7 and Windows Server 2008 R2."
                            }
                        },
                        new GetApplicationVersionsRow
                        {
                            VersionNumber = "6.12.18141.26330",
                            ReleaseNotes = new List<string>
                            {
                                "Updated installer to inform user that .NET Framework 4.7 is required."
                            }
                        },
                        new GetApplicationVersionsRow
                        {
                            VersionNumber = "6.11.18130.25037",
                            ReleaseNotes = new List<string>
                            {
                                "Supports workstation policy enforcement.",
                                "Resolved issue with AutoText deleting text."
                            }
                        },
                        new GetApplicationVersionsRow
                        {
                            VersionNumber = "6.10.18078.23929",
                            ReleaseNotes = new List<string>
                            {
                                "Added ability to verify email address.",
                                "Resolved issue with login failing due to spaces in username or company code."
                            }
                        },
                        new GetApplicationVersionsRow
                        {
                            VersionNumber = "6.9.18036.21569",
                            ReleaseNotes = new List<string>
                            {
                                "Added ability to edit MT email address.",
                                "Resolved issue with forgot password link."
                            }
                        },
                        new GetApplicationVersionsRow
                        {
                            VersionNumber = "6.8.18009.17133",
                            ReleaseNotes = new List<string>
                            {
                                "Resolved issue with manually assigned jobs being automatically checked in.",
                                "Resolved issue with appointment data not clearing when changing orders.",
                                "Resolved issue with DOB not saving without tabbing out of field.",
                                "Resolved issue with InScribe crashing when converting Daylight Savings Time.",
                                "Resolved issue with incorrect number of jobs downloading.",
                                "Resolved issue with training files not loading when date separator is a decimal.",
                                "Resolved issue with dictation time stamp not placed in comments in split dictations.",
                                "Added playback volume shortcuts (Ctrl+Shift+8 and Ctrl+Shift+9).",
                                "Added Patient Age to demographics (requires configuration).",
                                "Enhanced shortcuts viewer to allow filtering and view only favorites.",
                                "Expanded UK Dictionary.",
                                "Added native support for TLS 1.2."
                            }
                        },
                        new GetApplicationVersionsRow
                        {
                            VersionNumber = "6.7.17171.21975",
                            ReleaseNotes = new List<string>
                            {
                                "Resolved issue with blank Print Preview after Windows updates."
                            }
                        },
                        new GetApplicationVersionsRow
                        {
                            VersionNumber = "6.7.16342.19464",
                            ReleaseNotes = new List<string>
                            {
                                "Resolved issue with original default demographic labels not being used.",
                                "Resolved issue with disabled table editing buttons.",
                                "Resolved issue with transcription text being deleted upon print preview.",
                                "Resolved issue with InScribe crashing due to lost focus.",
                                "Resolved issue with prompts for fields.",
                                "Resolved issue with associate type setting.",
                                "Resolved issue with date dictated and admit/discharge date time zone conversions.",
                                "Resolved issue with the cursor not moving on Enter key press.",
                                "Resolved issue with auto-CCs only being added to first job.",
                                "Added better visibility to selected list items that are not in focus.",
                                "Added more medical words to the default dictionaries."
                            }
                        }

                    };
                }
                default:
                {
                    return Enumerable.Empty<GetApplicationVersionsRow>();
                }
            }
        }

        public class GetToolsRow
        {
            public string Name { get; set; }
            public string InstallerPath { get; set; }
            public string InstallerFileName { get; set; }
            public string ManualPdfFileName { get; set; }
            public string ManualWordFileName { get; set; }
        }

        public IEnumerable<GetToolsRow> GetTools()
        {
            return new List<GetToolsRow>
            {
                new GetToolsRow
                {
                    InstallerPath = "Runtime",
                    InstallerFileName = "RuntimeComponents.exe",
                    Name = "Runtime Components"
                },
                new GetToolsRow
                {
                    InstallerPath = "Runtime",
                    InstallerFileName = "RuntimeComponents.msi",
                    Name = "Runtime Components (MSI)"
                },
                new GetToolsRow
                {
                    InstallerPath = "Download",
                    InstallerFileName = "AutoCorrect_AutoText.exe",
                    ManualPdfFileName = "eScription One Word AutoCorrect to InScribe May 2019.pdf",
                    Name = "Word AutoCorrect to InScribe AutoText Converter"
                },
                new GetToolsRow
                {
                    InstallerPath = "Download",
                    InstallerFileName = "CSV_AutoText_Converter.exe",
                    ManualPdfFileName = "eScription One CSV Autotext Converter May 2019.pdf",
                    Name = "CSV to InScribe AutoText Converter"
                }
            };
        }
    }
}