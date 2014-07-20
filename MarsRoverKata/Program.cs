using System;
using Castle.Windsor;
using Castle.Windsor.Installer;

namespace MarsRoverKata
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//var container = new WindsorContainer();
			//container.Install(FromAssembly.This());

			ICoordinateMover mover = new CoordinateMover();
			ICommandRunner runner = new CommandRunner();

			IRover rover = new Rover(mover, runner);

			rover.Position = new Coordinates(0, 0, 'N');

			rover.ReceiveCommands("f");
		}
	}
}
