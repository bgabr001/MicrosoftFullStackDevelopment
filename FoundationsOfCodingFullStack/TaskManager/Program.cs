class TaskManager
{
    static List<string> tasks = new List<string>();
    static List<bool> tastStatus = new List<bool>();

    static void Main(string[] args)
    {
       while(true)
        {
            Console.WriteLine();
            Console.WriteLine("Task Manager");
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. View Tasks");
            Console.WriteLine("3. Mark Task as Completed");
            Console.WriteLine("4. Exit");
            Console.WriteLine();

            Console.Write("Select an option: ");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    AddTask();
                    break;
                case 2:
                    ViewTasks();
                    break;
                case 3:
                    MarkTaskAsCompleted();
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }       

    }

    static void AddTask()
    {
        Console.Write("Enter task description: ");
        string task = Console.ReadLine();
        tasks.Add(task);
        tastStatus.Add(false);
        Console.WriteLine("Task added successfully.");
    }
    static void MarkTaskAsCompleted()
    {
        Console.Write("Enter task number to mark as completed: ");
        int taskNumber = int.Parse(Console.ReadLine());

        if (taskNumber > 0 && taskNumber <= tasks.Count)
        {
            tastStatus[taskNumber - 1] = true;
            Console.WriteLine("Task marked as completed.");
        }
        else
        {
            Console.WriteLine("Invalid task number.");
        }
    }

    static void ViewTasks()
    {
        Console.WriteLine("Tasks:");
        for (int i = 0; i < tasks.Count; i++)
        {
            string status = tastStatus[i] ? "Completed" : "Pending";
            Console.WriteLine($"{i + 1}. {tasks[i]} - {status}");
        }
    }

}