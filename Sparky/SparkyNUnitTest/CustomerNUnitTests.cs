using System;

using NUnit.Framework;

namespace Sparky
{
	[TestFixture]
	public class CustomerNUnitTests
	{
		[Test]
		public void Combine_InputFirstAndLastName_ReturnFullName()
		{
			//Arrange
			var customer = new Customer();
			//Act
			string fullName = customer.GreetAndCombineNames( "Tiago", "Barbosa" );
			//Assert
			Assert.That( fullName, Is.EqualTo( "Hello, Tiago Barbosa" ) );
		}
	}
}
