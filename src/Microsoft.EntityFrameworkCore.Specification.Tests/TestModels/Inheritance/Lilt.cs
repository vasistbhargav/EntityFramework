// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.EntityFrameworkCore.Specification.Tests.TestModels.Inheritance
{
    public class Lilt : Drink, ISugary
    {
        public int SugarGrams { get; set; }
        public int Carbination { get; set; }
    }
}
