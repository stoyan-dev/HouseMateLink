using HouseMateLink;

public class Task
{
    //public int TaskID { get; }
    public string Username { get; set; }
    public DateTime TaskDate { get; set; }
    public TaskTypeEnum TaskType { get; set; }  

    public Task(string username, DateTime taskDate, TaskTypeEnum taskType)
    {  
        this.Username = username;
        this.TaskDate = taskDate;
        this.TaskType = taskType;
    }
}