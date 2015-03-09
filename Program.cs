using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayFilter
{
    class Program
    {
        /// <summary>
        /// This enum demonstrates how enum options could be designed to represent
        /// different commands required by the program. You need not use this enum
        /// (or any enum at all) in your program if you would rather not.
        /// </summary>
        enum Command
        {
            /// <summary>
            /// List all birthdays occurring in a given month.
            /// </summary>
            Month,

            /// <summary>
            /// List all birthdays which will occur over the summer.
            /// </summary>
            Summer,

            /// <summary>
            /// List all students who are turning a given age this year.
            /// </summary>
            Year,

            /// <summary>
            /// List students who share birth months.
            /// </summary>
            Shared,

            /// <summary>
            /// List students who share exact birthdays.
            /// </summary>
            SharedExact,
        }

        /// <summary>
        /// This program is intended to help teachers filter student birthdays so that they can better 
        /// plan parties and celebrations throughout the school year. Intended functionality includes:
        /// 
        /// - List birthdays in a given month
        /// - List summer birthdays
        /// - List "important" birthdays (e.g. "all kids turning sixteen")
        /// - List shared birthdays
        /// 
        /// Nominal parameters include:
        /// 
        /// - file containing birthdays in a `name|date` format
        /// - command indicating which of the above options is to be executed
        /// 
        /// Work has been started already. You only need to fill in the missing pieces.
        /// </summary>
        static void Main(string[] args)
        {
            // Check to ensure we've been given the right number of arguments
            if (args.Length != 2 || ValidateCommand(args[0]) || ValidateFile(args[1]))
            {
                Console.WriteLine("USAGE: program COMMAND FILE");
                return;
            }

            /* Your solution
             * =============
             * 
             * This assignment is fairly complex, including several distinct problems which can be
             * attacked individually. My recommendation is that you divide and conquer here, attacking
             * each problem individually rather than all at once.
             * 
             * 1.   Start with your user input: lay out how you will validate commands and file paths, 
             *      and then determine how you will handle branching (the use of different code paths 
             *      for different conditions) based on the command supplied to the program. Try printing 
             *      a specific message for each code path.
             *      
             * 2.   Consider how your program will model the required data, in this case a list of 
             *      students and their birth dates. A simple class would be more than sufficient, e.g.
             *      
             *          class StudentBirthday
             *          {
             *              string Name { get; set; }
             *              DateTime Date { get; set; }
             *          }
             *      
             *      ...but an even simpler solution might be preferable in some cases. When you deterine
             *      how your data should be represented, try parsing everything into your chosen form
             *      and then printing it to the screen. If you make use of a class, consider overriding 
             *      the ToString() method for this purpose.
             *      
             * 3.   Implement the assigned command functions one by one. Keep their unique code as separate 
             *      as possible so that changes to one function do not impact another, possibly finished, 
             *      function. At the same time, consider where a given function might be shared universally, 
             *      in which case it would be wise to combine two functions into a single, shared function 
             *      so that fixes and modifications don't need to be repeated.
             *      
             * A basic framework for your solution has already been provided, but you need not actally 
             * follow what has been laid out.
             * */

            // Below is a non-working template for the program. You may use it for reference,
            // or you may delete it and go another direction entirely.
            Command command = ParseCommand(args[0]);
            IEnumerable<string> output = GetCommandOutput(command, args[1]);

            foreach (var line in output)
            {
                Console.WriteLine(line);
            }
        }

        /// <summary>
        /// Validates the input provided for a birthday filtering operation. These operations are 
        /// listed above, but the exact mechanism by which these operations will be identified has 
        /// not been determined.
        /// </summary>
        /// <param name="input">command line argument representing the chosen command</param>
        /// <returns>boolean value indicating the validity of the supplied command</returns>
        static bool ValidateCommand(string input)
        {
            // TODO: fix this value
            return false;
        }

        /// <summary>
        /// Validates the input provided for a file to be filtered by our birthday filtering app.
        /// </summary>
        /// <param name="input">command line argument representing the chosen filename</param>
        /// <returns>boolean value indicating the validity of the supplied filename</returns>
        static bool ValidateFile(string input)
        {
            // TODO: fix this value
            return false;
        }

        /// <summary>
        /// Parses arbitrary string input into an enum of type Command, defined above. As 
        /// implemented, should throw an exception if a command cannot be parsed. Currently
        /// just throws a NotImplementedException.
        /// </summary>
        /// <param name="input">command line argument representing the chosen command</param>
        /// <returns>enum value of type Command</returns>
        static Command ParseCommand(string input)
        {
            throw new NotImplementedException("todo: implement ParseCommand()");
        }

        /// <summary>
        /// Returns the output for a given command/filename combination. The output should
        /// differ for each command supplied, as defined by the spec above (although 
        /// not necessarily based on the Command enum). If you choose not to use the 
        /// Command enum, it will be necessary to change the signature for this method.
        /// Of course, this method could be discarded entirely should you so choose.
        /// </summary>
        /// <param name="command"></param>
        /// <param name="inputFilePath"></param>
        /// <returns></returns>
        static IEnumerable<string> GetCommandOutput(Command command, string inputFilePath)
        {
            var value = Enumerable.Empty<string>();

            // Were this method actually implemented, we would do some work in each of these
            // case options to set the return value to something other than Enumerable.Empty.
            switch (command)
            {
                case Command.Month: break;
                case Command.Shared: break;
                case Command.SharedExact: break;
                case Command.Summer: break;
                case Command.Year: break;
            }

            return value;
        }
    }
}
