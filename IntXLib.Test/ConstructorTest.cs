using System;
using NUnit.Framework;

namespace IntXLib.Test
{
	
	public class ConstructorTest
	{
		[Test]
		public void DefaultCtor()
		{
			new IntX();
		}
		
		[Test]
		public void IntCtor()
		{
			new IntX(7);
		}
		
		[Test]
		public void UIntCtor()
		{
			new IntX(uint.MaxValue);
		}
		
		[Test]
		public void IntArrayCtor()
		{
			new IntX(new uint[] { 1, 2, 3 }, true);
		}
		
		[Test]
		public void IntArrayNullCtor()
		{
		    Assert.Throws<ArgumentNullException>(()=> new IntX(null, false));
		}
	}
}
