using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace MarsRoverKata.Test
{
	[TestFixture]
	public class CommandRunnerTest
	{
		private List<string> _actionResults;
		private CommandRunner _commandRunner;


		[SetUp]
		public void Setup()
		{
			_commandRunner = new CommandRunner();
			_actionResults = new List<string>();
		}


		[Test]
		public void Add_then_Run_with_one_command_should_invoke_the_action()
		{
			_commandRunner.Add('f', Action1);
			_commandRunner.Run("f");

			Assert.AreEqual("Action1", _actionResults.First());
		}


		[Test]
		public void Add_then_Run_with_multiple_commands_should_invoke_the_actions()
		{
			_commandRunner.Add('f', Action1);
			_commandRunner.Run("fff");

			Assert.AreEqual(3, _actionResults.Count());
		}


		[Test]
		[ExpectedException(typeof(Exception))]
		public void Run_with_unknown_command_should_throw_exception()
		{
			_commandRunner.Run("ffg");
		}


		public void Action1()
		{
			_actionResults.Add("Action1");
		}


	}
}

