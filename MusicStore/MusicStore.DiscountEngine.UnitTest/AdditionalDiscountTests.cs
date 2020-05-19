using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcMusicStore.Models;

namespace MusicStore.DiscountEngine.UnitTest
{
	[TestClass]
	public class AdditionalDiscountTests
	{
		[TestMethod]
		public void Buy_Two_Rock_Albums_Get_20_Percent_Off()
		{
			var cart = new List<Cart>();
			cart.Add(NewCartItem("Rock","Rock001",1M,1));
			cart.Add(NewCartItem("Rock", "Rock002", 1M, 1));

			var actual = Engine.GetDiscountForCartItems(cart);

			Assert.AreEqual(20, actual);
		}

		[TestMethod]
		public   void Buy_Rock_and_Metal_Album_Get_5_Percent_Discount()
		{
			//Arrange
			var cart = new List<Cart>();
			cart.Add(NewCartItem("Rock", "Rock001", 1M, 1));
			cart.Add(NewCartItem("Metal", "Metal001", 1M, 1));

			//Act
			var actual = Engine.GetDiscountForCartItems(cart);

			// Assert
			Assert.AreEqual(5, actual);

		}

		private static Cart NewCartItem( string genreName,string title, decimal price, int count )
		{
			var genre = new Genre() { Name = genreName };
			var album = new Album() { Price = price, Genre = genre, Title = title };

			return new Cart() { Album = album, Count = count};
		}
	}
}
