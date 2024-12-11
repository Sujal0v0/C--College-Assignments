using System;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

namespace HelloWorld
{
  //Log Book
  public class Logger
  {
    private List<string> logs;
    public Logger()
    {
      logs = new List<string>();
    }
    //Add logs
    public void AddLog(string message)
    {
      logs.Add(message);
    }
    //Display Logs
    public void DisplayLog()
    {
      Console.WriteLine("Log Entries: ");
      foreach (var log in logs)
      {
        Console.WriteLine(log);
      }
    }
  }


  public class ToDoList
  {
    private Logger logger;
    public List<string> MyList { get; set; }
    public ToDoList()
    {
      this.MyList = new List<string>();
      this.logger = new Logger();
    }
    //Add task
    public void AddToList(string task)
    {
      MyList.Add(task);
      logger.AddLog($"Added task: {task}");
      Console.WriteLine($"Task '{task}' was added to todo list.");
    }

    //Display task
    public void DisplayTasks()
    {
      Console.WriteLine("Todo List:");
      foreach (var task in MyList)
      {
        Console.WriteLine($"-> {task}");
      }
    }

    //Display log
    public void DisplayLogs()
    {
      logger.DisplayLog();
    }
  }
  class Program
  {
    static void Main(string[] args)
    {

      //   Console.Write("Enter your name: ");
      //   string name= Console.ReadLine();
      //   Console.WriteLine("Your name is "+name);

      // Console.Write("Enter a number: ");
      // int i = int.Parse(Console.ReadLine());
      // Console.WriteLine("The number is: " + i);
      // Console.WriteLine(i % 2 == 0 ? "It is even" : "It is odd");
      // Console.WriteLine(i > 0 ? "It is positive" : "It is negative");


      //Todo list console application
      //?allow to exit
      //?allow to add items
      //?allow to view items
      //?allow to remove items
      Console.WriteLine("This is a TODO list (By: Sujal Bajracharya)");
      var todoList = new ToDoList();

      // Adding tasks (books in this case)
      todoList.AddToList("Study C#.");
      todoList.AddToList("Do Tailwind.");
      todoList.AddToList("Do React.");

      // Displaying the tasks
      todoList.DisplayTasks();

      // Displaying the logs of added tasks
      todoList.DisplayLogs();
    }
  }
}