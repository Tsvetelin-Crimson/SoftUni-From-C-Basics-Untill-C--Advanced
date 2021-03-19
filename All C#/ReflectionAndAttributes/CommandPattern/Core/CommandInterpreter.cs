using CommandPattern.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

namespace CommandPattern.Core
{
    public class CommandInterpreter : ICommandInterpreter
    {
        private readonly string CommandPostfix = "Command";
        public string Read(string args)
        {
            string[] tokens = args.Split();
            string commandName = tokens[0];
            string commandFullName = commandName + CommandPostfix;
            Type commandType = Assembly
                .GetCallingAssembly()
                .GetTypes()
                .Where(k => k.GetInterfaces().Any(k => k.Name == nameof(ICommand)))
                .FirstOrDefault(k => k.Name == commandFullName);
            if (commandType == null)
            {
                throw new InvalidOperationException("Command does not exist!");
            }
            ICommand command = Activator.CreateInstance(commandType) as ICommand;

            string res = command.Execute(tokens.Skip(1).ToArray());
            ;
            return res;
        }
    }
}
