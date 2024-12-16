using HouseMateLink;

public class Task
{
    public int TaskID { get; }
    public int UserID { get; set; }
    public DateTime TaskDate { get; set; }
    public bool IsDone { get; set; }
    public TaskTypeEnum TaskType { get; set; }  

    public Task(int id,int userId, DateTime taskDate, bool isDone, TaskTypeEnum taskType)
    {
        this.TaskID = id;   
        UserID = userId;
        TaskDate = taskDate;
        IsDone = isDone;
        TaskType = taskType;
    }
}