using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using UnitBoilerplate.Sandbox.Classes.Cases;

namespace UnitTestBoilerplate.SelfTest.Cases
{
	[TestClass]
	public class NotInjectedClassTests
	{
		private MockRepository mockRepository;



		[TestInitialize]
		public void TestInitialize()
		{
			this.mockRepository = new MockRepository(MockBehavior.Strict);


		}

		private NotInjectedClass CreateNotInjectedClass()
		{
			return new NotInjectedClass();
		}

		[TestMethod]
		public void TestMethod1()
		{
			// Arrange
			var notInjectedClass = this.CreateNotInjectedClass();

			// Act


			// Assert
			Assert.Fail();
			this.mockRepository.VerifyAll();
		}
	}
}
