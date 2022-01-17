﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using System.Diagnostics;

namespace AcceptanceTest.Tests.UnitTests.SanityTests
{
    public class SanityUnitTest
    {
      
        [Fact, TestPriority(2)]
        public void Test1()
        {
            //Test3Called = true;

            //Assert.True(Test1Called);
            //Assert.True(Test2ACalled);
            //Assert.True(Test2BCalled);
            Console.WriteLine("second test1");
            Debug.WriteLine("second test1");
        }

        [Trait("Category", "Sanity")]
        [Fact]
        public void Test3()
        {
            //Test3Called = true;

            //Assert.True(Test1Called);
            //Assert.True(Test2ACalled);
            //Assert.True(Test2BCalled);
            Console.WriteLine("third test3");
            Debug.WriteLine("third test3");
        }

        [Fact, TestPriority(1)]
        public void Test2()
        {
            //Test3Called = true;

            //Assert.True(Test1Called);
            //Assert.True(Test2ACalled);
            //Assert.True(Test2BCalled);
            Console.WriteLine("first test2");
            Debug.WriteLine("first test2");
        }
    }
}
