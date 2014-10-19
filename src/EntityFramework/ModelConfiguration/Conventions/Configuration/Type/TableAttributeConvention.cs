// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

namespace System.Data.Entity.ModelConfiguration.Conventions
{
    using System.Data.Entity.DataAnnotations.Schema;
    using System.Data.Entity.ModelConfiguration.Configuration;
    using System.Data.Entity.ModelConfiguration.Configuration.Types;
    using System.Data.Entity.Utilities;

    /// <summary>
    /// Convention to process instances of <see cref="TableAttribute" /> found on types in the model.
    /// </summary>
    public class TableAttributeConvention :
        TypeAttributeConfigurationConvention<TableAttribute>
    {
        /// <inheritdoc />
        public override void Apply(ConventionTypeConfiguration configuration, TableAttribute attribute)
        {
            Check.NotNull(configuration, "configuration");
            Check.NotNull(attribute, "attribute");

            if (string.IsNullOrWhiteSpace(attribute.Schema))
            {
                configuration.ToTable(attribute.Name);
            }
            else
            {
                configuration.ToTable(attribute.Name, attribute.Schema);
            }
        }
    }
}
