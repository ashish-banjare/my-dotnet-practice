using System;

namespace Application
{
      class Program
      {
            static void Main(string[] args)
            {
                  System.Console.WriteLine("Welcome to this my todo app!");
                  Console.WriteLine("Type 'Help' for a description of actions");
                  Console.WriteLine("Type 'Quit' to exit the application");

                  Todo app = new Todo(new TodoList());

                  while (true)
                  {
                        System.Console.Write(">");
                        string? command = Console.ReadLine();
                        System.Console.WriteLine(command);
                        app.DoAction(command ?? "");
                  }
            }
      }
}