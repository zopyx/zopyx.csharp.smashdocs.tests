﻿using System;
using Xunit;

namespace SMASHDOCsTests
{

	public class UnitTest1
	{
		[Fact]
		public void Test1()
		{

			Assert.Equal(4, 2+2);
		}

		[Fact]
		public void Test2()
		{

			Assert.Equal(4,4);
		}


		[Fact]
		public void Test3()
		{

			Assert.Equal(4, 4);
		}

	}
}
