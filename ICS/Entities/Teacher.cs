﻿// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
//

namespace ICS.DAL.Entities;

public record Teacher : User
{
    public new required string Login { get; set; }

    public ICollection<SubjectTeacher> Subjects { get; set; }
}
