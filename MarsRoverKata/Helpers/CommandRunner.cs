using System;
using System.Collections.Generic;

namespace MarsRoverKata
{
	public interface ICommandRunner
	{
		void Add(char command, Action action);
		void Run(string commands);
	}


	public class CommandRunner : ICommandRunner
	{
		private IDictionary<char, Action> _actions;


		public CommandRunner ()
		{
			_actions = new Dictionary<char, Action>();
		}


		public void Add(char command, Action action)
		{
			_actions[command] = action;
		}


		public void Run(string commands)
		{
			foreach(char command in commands)
			{
				if(!_actions.ContainsKey(command))
					throw new Exception("Command not found");

				_actions[command].Invoke();
			}
		}
	}
}

