﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

namespace ConcurrencyModel
{
    using System.Data.Entity.DataAnnotations.Schema;

    [ComplexType]
    public class SponsorDetails
    {
        public int Days { get; set; }
        public decimal Space { get; set; }
    }
}
