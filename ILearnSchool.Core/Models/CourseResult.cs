﻿namespace ILearnSchool.Core.Models;

public class CourseResult
{
    public int Id { get; set; }
    public double Grade { get; set; }

    public int CourseId { get; set; }
    public Course Course { get; set; } = null!;
    public int TraineeId { get; set; }
    public Trainee Trainee { get; set; } = null!;
}
