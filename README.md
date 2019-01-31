# Introduction 
This repository contains the MVC web app for the software site.

# Updating Application Versions
The installers themselves are currently still located in the `Emdat Website` repository.

To add a new version for an existing application:
1. Add the installer .exe and .msi to `$/WebSite/Software/Emdat WebSite/files`
2. Update `$/Software/SoftwareSite/DataAccess/DataContext.cs`
    1. Update the InstallerName properties in `GetLatestApplicationVersions`, if you are adding a new major version that should be shown along side the current version then add a new row to this result set.
    2. Add a new row to `GetApplicationVersions` with the change log entries