using System;
using NUnit.Framework;

namespace IntXLib.Test
{
	
	public class CustomAlphabetTest
	{
		[Test]
		public void AlphabetNull()
		{
		    Assert.Throws<ArgumentNullException>(() => IntX.Parse("", 20, null));
		}

		[Test]
		public void AlphabetShort()
		{
		    Assert.Throws<ArgumentException>(() => IntX.Parse("", 20, "1234"));
		}

		[Test]
		public void AlphabetRepeatingChars()
		{
		    Assert.Throws<ArgumentException>(() => IntX.Parse("", 20, "0123456789ABCDEFGHIJ0"));
		}
		
		[Test]
		public void Parse()
		{
			Assert.AreEqual(19 * 20 + 18, (int)IntX.Parse("JI", 20, "0123456789ABCDEFGHIJ"));
		}

		[Test]
		public void ToStringTest()
		{
			Assert.AreEqual("JI", new IntX(19 * 20 + 18).ToString(20, "0123456789ABCDEFGHIJ"));
		}
	}
}
