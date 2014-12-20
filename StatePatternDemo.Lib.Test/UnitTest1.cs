using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StatePattern.Lib.Test
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var monitor = new StateMonitor();
			Assert.IsNotNull(monitor);
			monitor.State.PrintState();
			monitor.ChangeColor(Colors.Green);
			monitor.ShouldBlink(false);
			monitor.State.PrintState();
			monitor.ShouldBlink(true);
			monitor.State.PrintState();
			monitor.ChangeColor(Colors.Red);
			monitor.ShouldBlink(false);
			monitor.State.PrintState();
		}
	}
}
