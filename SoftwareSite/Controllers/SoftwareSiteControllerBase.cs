using System.Web.Mvc;
using static Emdat.SoftwareSite.DataAccess.DataContext;

namespace Emdat.SoftwareSite.Controllers
{
    public enum EmdatEnvironment
    {
        US,
        UK,
        Canada
    }

    public class SoftwareSiteControllerBase : Controller
    {
        protected EmdatEnvironment EmdatEnvironment
        {
            get
            {
                var authority = HttpContext.Request.Url.Authority?.ToLowerInvariant();

                if (!string.IsNullOrEmpty(authority))
                {
                    if (authority.EndsWith(".co.uk"))
                    {
                        return EmdatEnvironment.UK;
                    }
                    else if (authority.EndsWith(".ca"))
                    {
                        return EmdatEnvironment.Canada;
                    }
                }

                return EmdatEnvironment.US;
            }
        }

        protected string GetInstallerFileName(GetLatestApplicationVersionsRow version)
        {
            switch (EmdatEnvironment)
            {
                case EmdatEnvironment.Canada:
                {
                    return version.InstallerFileNameCanada;
                }
                case EmdatEnvironment.UK:
                {
                    return version.InstallerFileNameUK;
                }
                default:
                {
                    return version.InstallerFileName;
                }
            }
        }

        protected string GetInstallerFileNameMsi(GetLatestApplicationVersionsRow version)
        {
            switch (EmdatEnvironment)
            {
                case EmdatEnvironment.Canada:
                {
                    return version.InstallerFileNameCanadaMsi;
                }
                case EmdatEnvironment.UK:
                {
                    return version.InstallerFileNameUKMsi;
                }
                default:
                {
                    return version.InstallerFileNameMsi;
                }
            }
        }
    }
}