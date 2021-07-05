using System;
using System.Collections.Generic;
using System.Text;

namespace DMPackageManager.Api.Models {
    class PackageByVersion : PackageBase {
        /// <summary>
        /// Changelog for this version of the package
        /// </summary>
        public string changelog { get; set; }

        /// <summary>
        /// Latest version of this package. You can compare this to the <see cref="package_version"/> field to check if the package is the latest version.
        /// </summary>
        public Version latest_version { get; set; }

        /// <summary>
        /// Is this version deemed "vulnerable" and should the user update ASAP?
        /// </summary>
        public bool version_vulnerable { get; set; }
    }
}
