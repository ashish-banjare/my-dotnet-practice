using System;
using System.Collections.Generic;

namespace Application
{
      public class Todo : ITodo
      {
            public ITodoList _list;
            private readonly string HelpString = "To add elements to the todo list type:\n"
                                    + "Add <Description of what should be done>\n"
                                    + "To mark element as done type:\nDo #<Id of todo element>\n"
                                    + "Print all remaining to-dos type:\nPrint\n"
                                    + "To exit the application type:\nQuit";
            private readonly string InfoFormatString = "INFO: {0}";

            // private static List<string> ActionVerbs = new List<string>(new string[] { "ADD", "DO" }); //Shorthand
            // Step 1: Declare the private static field
            private static List<string> ActionVerbs;
            private static List<string> IncompleteDescription;

            // Step 2: Initialize the field in a static constructor
            static Todo()
            {
                  // Create a new string array with the action verbs
                  string[] actionVerbsArray = new string[] { "ADD", "DO" };
                  string[] incompleteDescArr = new string[] { "\"\"", "''", "\"", "'" };

                  // Use the array to create a new List<string>
                  ActionVerbs = new List<string>(actionVerbsArray);
                  IncompleteDescription = new List<string>(incompleteDescArr);
            }

            public Todo(ITodoList list)
            {
                  _list = list;
            }

            public void DoAction(string action)
            {
                  System.Console.WriteLine(action);
                  string[] args = action.Split(" ", 2);

                  string verb = args[0].ToUpper();

                  if (ActionVerbs.Contains(verb) && (args.Length < 2 || args[1].Trim().Length < 1))
                  {
                        System.Console.WriteLine(string.Format(InfoFormatString, $"{verb} is missing second argument."));
                        return;
                  }

                  if (ActionVerbs.Contains(verb) && IncompleteDescription.Contains(args[1]))
                  {
                        System.Console.WriteLine(string.Format(InfoFormatString, $"{args[1]} is a incomplete description."));
                        return;
                  }
                  System.Console.WriteLine(args);

                  switch (verb)
                  {
                        case "ADD":
                              _list.AddElement(args[1]);
                              break;
                        case "DO":
                              string RemoveHashTag = args[1].Replace("#", string.Empty);
                              _list.DoElement(RemoveHashTag);
                              break;
                        case "PRINT":
                              _list.PrintElement();
                              break;
                        case "HELP":
                              Console.WriteLine(HelpString);
                              break;
                        case "QUIT":
                              System.Environment.Exit(1);
                              break;
                        default:
                              System.Console.WriteLine("Unkown action. Type 'Help' for available actions.");
                              break;
                  }

            }
      }
}