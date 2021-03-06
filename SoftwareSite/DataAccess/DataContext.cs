﻿using System.Collections.Generic;
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
                            SupportedOperatingSystemWarning = "Support is only available for products running on Windows 10 and later operating systems."
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
                            SupportedOperatingSystemWarning = "Support is only available for products running on Windows 10 and later operating systems."
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
                            SupportedOperatingSystemWarning = "Support is only available for products running on Windows 10 and later operating systems."
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
                            SupportedOperatingSystemWarning = "Support is only available for products running on Windows 10 and later operating systems."
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
                            InstallerFileName = "InSyncSetup_6_11_20329_29723.exe",
                            InstallerFileNameMsi = "InSyncSetup_6_11_20329_29723.msi",
                            InstallerFileNameCanada = "InSyncSetup_6_11_20329_29723.exe",
                            InstallerFileNameCanadaMsi = "InSyncSetup_6_11_20329_29723.msi",
                            InstallerFileNameUK = "InSyncSetup_6_11_20329_29723.exe",
                            InstallerFileNameUKMsi = "InSyncSetup_6_11_20329_29723.msi",
                            MajorVersionNumber = "6",
                            ManualPdfFileName = "eScription One InSync Manual November 2020.pdf",
                            VersionNumber = "6.11.20329"
                        },                                            
                    };
                    }
                case "InScribe":
                    {
                        return new List<GetLatestApplicationVersionsRow>
                    {
                        new GetLatestApplicationVersionsRow
                        {
                            InstallerFileName = "InScribeSetup_7_4_21005_42873.exe",
                            InstallerFileNameMsi = "InScribeSetup_7_4_21005_42873.msi",
                            InstallerFileNameCanada = "InScribeSetup_7_4_21005_42873.exe",
                            InstallerFileNameCanadaMsi = "InScribeSetup_7_4_21005_42873.msi",
                            InstallerFileNameUK = "InScribeSetup_7_4_21005_42873.exe",
                            InstallerFileNameUKMsi = "InScribeSetup_7_4_21005_42873.msi",
                            MajorVersionNumber = "7",
                            ManualPdfFileName = "eScription One InScribe Manual January 2020.pdf",
                            VersionNumber = "7.4.21005"
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
                            ManualPdfFileName = "eScription One InScribe Manual January 2020.pdf",
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
                            ManualPdfFileName = "eScription One InScribe Manual January 2020.pdf",
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
                            InstallerFileName = "ShadowLinkSetup_2_9_20041_19823.exe",
                            InstallerFileNameCanada = "ShadowLinkSetup_2_9_20041_19823.exe",
                            InstallerFileNameUK = "ShadowLinkSetup_2_9_20041_19823.exe",
                            MajorVersionNumber = "2",
                            ManualPdfFileName = "eScription One ShadowLink Manual November 2020.pdf",
                            VersionNumber = "2.9"
                        }
                    };
                    }
                case "ShadowPrint":
                    {
                        return new List<GetLatestApplicationVersionsRow>
                    {
                        new GetLatestApplicationVersionsRow
                        {
                            InstallerFileName = "ShadowPrintSetup_2_4_20038_26641.exe",
                            InstallerFileNameCanada = "ShadowPrintSetup_2_4_20038_26641.exe",
                            InstallerFileNameUK = "ShadowPrintSetup_2_4_20038_26641.exe",
                            MajorVersionNumber = "2",
                            ManualPdfFileName = "eScription One ShadowPrint Manual November 2020.pdf",
                            VersionNumber = "2.4"
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
                            VersionNumber = "6.11.20329",
                            ReleaseNotes = new List<string>
                            {
                                "Prompt for Action, Place on Hold, and Queue options have been added for handling incoming PACS requests when using the XML method for PACS integration.",
                                "A Reject option has been added to the Prompt for Action dialog for clients using the port method for PACS integration.",
                                "Users can disable search for PACS appointments when using PACS (port or XML method).",
                                "The My Favorites and default lists for Document Types and Locations now appear in alphabetical order.",
                                "Select All / Deselect All buttons have been added, allowing users to select / deselect all Favorite Document Types and Locations at once.",
                                "InSync now supports plug and play for Olympus RecMic and Philips SpeechMike microphones, as well as new configuration screens for button /event customization if desired.",
                                "Fixed an issue where dictation upload would not successfully resume after the upload was interrupted."
                            }
                        },
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
                            VersionNumber = "7.4.21005",
                            ReleaseNotes = new List<string>
                            {
                               "Enhanced Transcription Log window.",
                               "Resolved copy/paste issues in list.",
                               "Resolved job upload issue when the next job fails to load.",
                               "Resolved issue with text from prior transcription being copied with justified format.",
                               "Renamed Company Name label to Business Name in Associate Details window.",
                               "Corrected the status message for repooled/invalidated job when the next job fails to load.",
                            }
                        },
                        new GetApplicationVersionsRow
                        {
                            VersionNumber = "7.3.20294",
                            ReleaseNotes = new List<string>
                            {
                               "Added support for Waveform control.",
                               "Changed dictation details keyboard jump key assignment to Q.",
                               "Decreased number of lines scrolled when using mouse wheel.",
                               "Deprecated external media player.",
                               "Enforced read-only fields in demographics.",
                               "Enhanced pool window.",
                               "Resolved issue with company field in associate and patient addresses not adhering to configuration setting.",
                               "Resolved issue with cursor and demographics not being visible when the editor is maximized and patient demographic keyboard shortcuts are used.",
                               "Resolved issue with dictation playback not starting at designated time stamp when a time stamp is first in a list item.",
                               "Resolved issue with document type changing when appended, irrespective of configuration settings.",
                               "Resolved issue with first letter of AutoText expansions automatically capitalizing.",
                               "Resolved issue with font changing after splitting a transcription.",
                               "Resolved issue with multiple patient associates not being retained upon upload.",
                               "Resolved issue with prior transcription dictation playback not stopping when when Prior Transcriptions list is refreshed.",
                               "Resolved issue with spell check stuck on Ignored words.",
                               "Resolved issue with structured jobs not being completed when alternate time stamp format is enabled.",
                               "Resolved issue with table losing properties when loading document and dictation templates.",
                               "Resolved issue with table widths being inaccurately represented in editor and preview transcription.",
                               "Resolved issue with the table being copied when copying table text from prior transcription.",
                               "Resolved job upload issue during next action if next job fails to load.",
                               "Resolved spacing and formatting issues in lists.",
                               "Updated 2020 Stedman's Dictionary (requires a Benchmark KB subscription).",
                               "Updated Copy Dictation and Copy Dictation and Header window titles and button texts for clarification.",
                               "Updated Preview Transcription to match the spacing in the editor.",
                            }
                        },
                        new GetApplicationVersionsRow
                        {
                            VersionNumber = "7.3.20086",
                            ReleaseNotes = new List<string>
                            {
                                "Added support for WAV playback in InScribe.",
                                "Added Time code validation checks in InScribe.",
                                "Added shortcut tip on Ratings tab.",
                                "Added support for cut, copy and paste shortcut keys in the comment box.",
                                "Resolved issue with spell check stuck on words in a list.",
                                "Resolved issue with the table being copied when copying table text in unstructured documents.",
                                "Resolved issue inaccurate dictation time stamps after one hour mark.",
                                "Resolved issues with tab key not working in CC panel and related fields.",
                                "Resolved issue with auto capitalization when deleting or replacing a highlighted period.",
                                "Resolved indentation formatting issues within document templates.",
                                "Resolved issues with numbering in nested lists.",
                                "Resolved issue with list items being deleted when using Backspace.",
                                "Removed duplicate CTRL+E shortcut for ASR Enhanced shortcuts.",
                                "Fixed issues related to Prior Transcriptions.",
                            }
                        },
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