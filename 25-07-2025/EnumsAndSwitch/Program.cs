namespace EnumsAndSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            List<Todo> tasks = new List<Todo>()
            {
                new Todo { EstimatedHours = 2, Description = "Write project proposal", Status = Status.NotStarted },
                new Todo { EstimatedHours = 3, Description = "Develop login module", Status = Status.InProgress },
                new Todo { EstimatedHours = 1, Description = "Test payment gateway", Status = Status.Completed },
                new Todo { EstimatedHours = 4, Description = "Design database schema", Status = Status.NotStarted },
                new Todo { EstimatedHours = 2, Description = "Fix UI bugs in dashboard", Status = Status.InProgress },
                new Todo { EstimatedHours = 3, Description = "Write API documentation", Status = Status.Completed },
                new Todo { EstimatedHours = 5, Description = "Integrate third-party API", Status = Status.InProgress },
                new Todo { EstimatedHours = 1, Description = "Review pull requests", Status = Status.Completed },
                new Todo { EstimatedHours = 2, Description = "Deploy app to server", Status = Status.NotStarted },
                new Todo { EstimatedHours = 3, Description = "Prepare project demo", Status = Status.InProgress },
                new Todo { EstimatedHours = 2, Description = "Conduct user testing", Status = Status.NotStarted },
                new Todo { EstimatedHours = 1, Description = "Send progress report to client", Status = Status.Completed }
            };
            PrintAssessment(tasks);
        }



        private static void PrintAssessment(List<Todo> todos)
        {
            foreach(var todo in todos)
            {
                switch (todo.Status)
                {
                    case Status.Completed:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        break;
                    case Status.NotStarted:
                        Console.WriteLine("Start ASAP:");
                        break;
                    case Status.Deleted:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        break;
                    case Status.InProgress:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                        Console.WriteLine("Hey Anyaa");

                }

            }
        }
        class Todo
        {
            public int EstimatedHours { get; set; }
            public string Description { get; set; }
            public Status Status { get; set; }
        }

        enum Status
        {
            NotStarted,
            InProgress,
            Completed,
            Deleted
        }
    }
}
