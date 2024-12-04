using HouseMateLink;

public class Task
{
    public int TaskID { get; set; }
    public int UserID { get; set; }
    public DateTime TaskDate { get; set; }
    public bool IsDone { get; set; }
    public TaskTypeEnum TaskType { get; set; }  

    public Task(int taskId, int userId, DateTime taskDate, bool isDone, TaskTypeEnum taskType)
    {
        TaskID = taskId;
        UserID = userId;
        TaskDate = taskDate;
        IsDone = isDone;
        TaskType = taskType;
    }
}