﻿namespace DO;

/// <summary>
/// Task Entity represents a task with all its props
/// </summary>
/// 
/// <param name="task_id">unique ID of task  </param>
/// <param name="description">description of the task</param>
/// <param name="nickname">Short name of the task</param>
/// <param name="milestone">boolean flag, true if the task has a milestone</param>
/// <param name="production_date">production date of the task</param>
/// <param name="start_date"> the date of starting the task</param>
/// <param name="final_date">the final date of ending the task</param>
/// <param name="estimated_start"> the estimated date of starting the task</param>
/// <param name="actual_end">the actual date of ending the task</param>
/// <param name="product">description of the product</param>
/// <param name="remarks">remarks on the task</param>
/// <param name="engineer">the id of the task's engineer</param>
/// <param name="level">the task dificulty level </param>
/// 
public record Task
(
    int task_id,
    string description,
    Level level,
    DateTime production_date,
    DateTime estimated_end ,
    bool milestone = false,
    DateTime? start_date = null,
    DateTime? final_date = null,
    DateTime? actual_end = null,
    string? nickname = "",
    string? product="",
    string? remarks="",
    int? engineer=null
)
{
    public Task() : this(0, "", 0, DateTime.MinValue, DateTime.MinValue) { }
}

