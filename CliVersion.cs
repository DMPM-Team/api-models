using System;
using System.Collections.Generic;
using System.Text;

namespace DMPackageManager.Api.Models {
    /// <summary>
    /// Simple class to get the latest version of the CLI. Used by the CLI client to see if an update is available
    /// </summary>
    public class CliVersion {
        /// <summary>
        /// Get the latest version of the CLI
        /// </summary>
        public string latest_version { get; set; }
    }
}
