// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ShareInfoElement
    {
        /// <summary>
        /// Initializes a new instance of the ShareInfoElement class.
        /// </summary>
        public ShareInfoElement()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ShareInfoElement class.
        /// </summary>
        /// <param name="vmUri">A relative URI containing the ID of the VM that
        /// has the disk attached.</param>
        public ShareInfoElement(string vmUri = default(string))
        {
            VmUri = vmUri;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets a relative URI containing the ID of the VM that has the disk
        /// attached.
        /// </summary>
        [JsonProperty(PropertyName = "vmUri")]
        public string VmUri { get; private set; }

    }
}
