using HouseMateLink;

public class Task
{
    public int TaskID { get; set; }
    public string TaskDescription { get; set; }
    public int UserID { get; set; }
    public DateTime TaskDate { get; set; }
    public bool IsDone { get; set; }
    public TaskTypeEnum TaskType { get; set; }  

    public Task(int taskId, string taskDescription, int userId, DateTime taskDate, bool isDone, TaskTypeEnum taskType)
    {
        TaskID = taskId;
        TaskDescription = taskDescription;
        UserID = userId;
        TaskDate = taskDate;
        IsDone = isDone;
        TaskType = taskType;
    }
}