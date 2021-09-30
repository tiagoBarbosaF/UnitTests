﻿using System;

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
		public void IsOddChecker_InputOddNumber_ReturnTrue( int a )
		{
			// Arrange
			Calculator calculator = new();
			// Act
			bool isOdd = calculator.IsOddNumber( a );
			//Assert
			Assert.That( isOdd, Is.EqualTo( true ) );
			Assert.IsTrue( isOdd );
		}

		[Test]
		[TestCase( 10, ExpectedResult = false )]
		[TestCase( 11, ExpectedResult = true )]
		public bool IsOddChecker_InputNumber_ReturnTrueIfOdd( int a )
		{
			Calculator calc = new();
			return calc.IsOddNumber( a );
		}

		[Test]
		[TestCase( 5.4, 10.5 )] // 15.9
		[TestCase( 5.43, 10.53 )] // 15.93
		[TestCase( 5.49, 10.59 )] // 16.08
		public void AddNumbersDouble_InputTRwoDouble_GetCOrrectAddition( double a, double b )
		{
			// Arrange
			Calculator calc = new();
			// Act
			double result = calc.AddNumbersDouble( a, b );
			// Assert
			Assert.AreEqual( 15.9, result, .2 );
		}
	}
}
