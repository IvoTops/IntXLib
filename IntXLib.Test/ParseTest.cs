using System;
using NUnit.Framework;

namespace IntXLib.Test
{
	
	public class ParseTest
	{
		[Test]
		public void Zero()
		{
			IntX int1 = IntX.Parse("0");
			Assert.IsTrue(int1 == 0);
		}
		
		[Test]
		public void WhiteSpace()
		{
			IntX int1 = IntX.Parse("  7 ");
			Assert.IsTrue(int1 == 7);
		}
		
		[Test]
		public void Sign()
		{
			IntX int1 = IntX.Parse("-7");
			Assert.IsTrue(int1 == -7);
			int1 = IntX.Parse("+7");
			Assert.IsTrue(int1 == 7);
		}
		
		[Test]
		public void Base()
		{
			IntX int1 = IntX.Parse("abcdef", 16);
			Assert.IsTrue(int1 == 0xabcdef);
			int1 = IntX.Parse("100", 8);
			Assert.IsTrue(int1 == 64);
			int1 = IntX.Parse("0100");
			Assert.IsTrue(int1 == 64);
			int1 = IntX.Parse("0100000000000");
			Assert.IsTrue(int1 == 0x200000000UL);
			int1 = IntX.Parse("0xabcdef");
			Assert.IsTrue(int1 == 0xabcdef);
			int1 = IntX.Parse("0XABCDEF");
			Assert.IsTrue(int1 == 0xabcdef);
			int1 = IntX.Parse("020000000000");
			Assert.IsTrue(int1 == 0x80000000);
		}
		
		[Test]
		public void Null()
		{
		    Assert.Throws<ArgumentNullException>(() => IntX.Parse(null));
		}
		
		[Test]
		public void InvalidFormat()
		{
		    Assert.Throws<FormatException>(() => IntX.Parse("-123-"));
		}
		
		[Test]
		public void InvalidFormat2()
		{
		    Assert.Throws<FormatException>(() => IntX.Parse("abc"));
		}
		
		[Test]
		public void InvalidFormat3()
		{
		    Assert.Throws<FormatException>(() => IntX.Parse("987", 2));
		}
		
		[Test]
		public void BigDec()
		{
			IntX intX = IntX.Parse("34589238954389567586547689234723587070897800300450823748275895896384753238944985");
			Assert.AreEqual(intX.ToString(), "34589238954389567586547689234723587070897800300450823748275895896384753238944985");
		}
	}
}
