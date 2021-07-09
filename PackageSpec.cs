using System;
using System.Collections.Generic;
using System.Text;

namespace DMPackageManager.Api.Models {
    /// <summary>
    /// Package specification to be returned by the API
    /// </summary>
    public class PackageSpec {
        /// <summary>
        /// Name of the package
        /// </summary>
        public string package_name { get; set; }

        /// <summary>
        /// Description of the package
        /// </summary>
        public string package_desc { get; set; }

        /// <summary>
        /// Latest version of the package
        /// </summary>
        public string latest_version { get; set; }

        /// <summary>
        /// UTC timestamp of when this package was first released
        /// </summary>
        public DateTime release_date { get; set; }

        /// <summary>
        /// UTC timestamp of when this package was last updated
        /// </summary>
        public DateTime update_date { get; set; }

        /// <summary>
        /// List of all versions this package has available
        /// </summary>
        public List<string> all_versions { get; set; }
    }
}
