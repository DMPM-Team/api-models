using System;
using System.Collections.Generic;
using System.Text;

namespace DMPackageManager.Api.Models {
    /// <summary>
    /// Base model for all package related API responses
    /// </summary>
    class PackageBase {
        /// <summary>
        /// Name of the package
        /// </summary>
        public string package_name { get; set; }

        /// <summary>
        /// Package version
        /// </summary>
        public Version package_version { get; set; }

        /// <summary>
        /// UTC timestamp of when this package was first released
        /// </summary>
        public DateTime release_date { get; set; }

        /// <summary>
        /// UTC timestamp of when this package was last updated
        /// </summary>
        public DateTime update_date { get; set; }
    }
}
