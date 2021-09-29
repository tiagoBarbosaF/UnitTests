using System;

using NUnit.Framework;

namespace Sparky
{
	[TestFixture]
	public class CalculatorNUnitTests
	{
		[Test]
		public void AddNumbers_InputTwoInt_GetCorrectAddition()
		{
			// Arrange
			Calculator calc = new();
			// Act
			int result = calc.AddNumbers( 10, 20 );
			// Assert
			Assert.AreEqual( 30, result );
		}

		[Test]
		public void IsOddChecker_InputEvenNumber_ReturnFalse()
		{
			// Arrange
			Calculator calculator = new();
			// Act
			bool isOdd = calculator.IsOddNumber( 10 );
			//Assert
			Assert.That( isOdd, Is.EqualTo( false ) );
			Assert.IsFalse( isOdd );
		}

		[Test]
		[TestCase( 11 )]
		[TestCase( 13 )]
		public void IsOddChecker_InputOffNumber_ReturnTrue( int a )
		{
			// Arrange
			Calculator calculator = new();
			// Act
			bool isOdd = calculator.IsOddNumber( a );
			//Assert
			Assert.That( isOdd, Is.EqualTo( true ) );
			Assert.IsTrue( isOdd );
		}
	}
}
