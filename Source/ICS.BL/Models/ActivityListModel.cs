﻿using ICS.DAL.Entities;

namespace ICS.BL.Models;

public record ActivityListModel : ModelBase
{
    public required ActivityType Type { get; set; }
    public required string SubjectAbbr { get; set; }
    public required Room AcrivityRoom { get; set; }
    public required DateTime StartDate { get; set; }
    public required DateTime EndDate { get; set; }

    public static ActivityListModel Empty => new()
    {
        Id = Guid.NewGuid(),
        Type = default,
        SubjectAbbr = String.Empty,
        AcrivityRoom = default,
        StartDate = default,
        EndDate = default
    };
}
