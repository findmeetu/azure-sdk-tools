// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

namespace Microsoft.WindowsAzure.Commands.SqlDatabase.Services.Server
{
    using System;
    using System.Collections.ObjectModel;
    using System.Linq;

    /// <summary>
    /// The <see cref="ServiceObjective"/> extensions
    /// </summary>
    public partial class ServiceObjective
    {
        /// <summary>
        /// Gets or sets the context from which this object was constructed.
        /// </summary>
        public IServerDataServiceContext Context;

        internal void LoadExtraProperties(IServerDataServiceContext context)
        {
            try
            {
                // Fill in the context property
                this.Context = context;

                // Fill in the service objective Dimension Settings
                this.Context.LoadProperty(this, "DimensionSettings");
            }
            catch
            {
                // Ignore exceptions when loading extra properties, for backward compatibility.
            }
        }
    }
}