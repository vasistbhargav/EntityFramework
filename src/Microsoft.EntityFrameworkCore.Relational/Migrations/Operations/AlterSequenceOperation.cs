// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using JetBrains.Annotations;

namespace Microsoft.EntityFrameworkCore.Migrations.Operations
{
    public class AlterSequenceOperation : SequenceOperation
    {
        public virtual string Schema { get; [param: CanBeNull] set; }
        public virtual string Name { get; [param: NotNull] set; }
        public virtual SequenceOperation OldSequence { get; [param: NotNull] set; } = new SequenceOperation();
    }
}
