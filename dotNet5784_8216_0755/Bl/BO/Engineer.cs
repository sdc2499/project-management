﻿namespace BO;
/// <summary>
/// Engineer Entity represents a logical Engineer with all its props
/// </summary>
/// <param name="engineer_id">unique id of the engineer</param>
/// <param name="name">name of the engineer</param>
/// <param name="email"> the engineer mail adress</param>
/// <param name="degree">the engineer degree </param>
/// <param name="task">the engineer current task </param>
/// /// <param name="is_active">check if the engnieer is active</param>
/// <param name="cost_per_hour"> cost per hour of the engineer </param>
public class Engineer
{
    public int engineer_id { get; init;}
    public required string name { get; set;}
    public required string email { get; set;}
    public BO.Level degree { get; set;}
    public int cost_per_hour { get; set; }
    public bool is_active  { get; set; }
    public TaskInEngineer? task{ get; set; }   
}
