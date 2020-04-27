using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oops.BL;
namespace Oops.BLTests
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void FullNameValid()
		{
			//Arrange
			Customer customer = new Customer
			{
				FirstName = "Hello",
				LastName = "Unknown"
			};

			var expected = "Unknown, Hello";
			//Act

			var actual = customer.Name;
			//Assert
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void FirstNameIsEmpty()
		{
			//Arrange
			Customer customer = new Customer
			{
				LastName = "BOBO"
			};
			var expected = "BOBO";
			//Act
			var actual = customer.Name;
			//Assert
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void LastNameIsEmpty()
		{
			//Arrange
			Customer customer = new Customer
			{
				FirstName = "Lester"
			};
			var expected = "Lester";

			//Act
			var actual = customer.Name;

			//Assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void VerifyInstanceCount()
		{
			Customer customer1 = new Customer();
			Customer customer2 = new Customer();
			Customer customer3 = new Customer();
			var expected = 3;
			var actual = Customer.InstanceCount;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ValidateValid()
		{
			Customer customer = new Customer();
			customer.LastName = "Hero";
			customer.EmailAddress = "test@test.com";
			bool expected = true;

			bool actual = customer.Validate();

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ValidateMissingLastName()
		{
			Customer customer = new Customer();
			customer.EmailAddress = "test@test.com";

			bool expected = false;
			bool actual = customer.Validate();

			Assert.AreEqual(actual, expected);
		}

		[TestMethod]
		public void ValidateMissingEmailAddress()
		{
			Customer customer = new Customer();
			customer.LastName = "WhatHappened";
			bool expected = false;

			bool actual = customer.Validate();
			Assert.AreEqual(actual, expected);
		}
	}
}
