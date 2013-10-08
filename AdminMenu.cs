using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Orchard.Localization;
using Orchard.Security;
using Orchard.UI.Navigation;

namespace Jacky.Crawler
{
    public class AdminMenu:INavigationProvider
    {
        public Localizer T { get; set; }

        public string MenuName
        {
            get { return "admin"; }
        }

        public void GetNavigation(NavigationBuilder builder) {
            builder.Add(T("Crawler"), "10", item => item.Action("Index", "Admin", new {area = "Jacky.Crawler"}).Permission(StandardPermissions.SiteOwner));
        }
    }
}