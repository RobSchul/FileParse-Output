using IntegerFile;
using System;
using System.Collections.Generic;
using Xunit;

namespace IntegerFileTests
{
    public class IntegerFileTests
    {
        [Fact]
        public void TestFileReadFailure()
        {
            try
            {
                FileReader fl = new FileReader();
                fl.FileRead(@"C:\Users\rober\Desktop\FormFree\IntegerFile\IntegerFile\TestFiles\TestFile2.txt");
            }
            catch(Exception e)
            {
                if (e.Message.Equals("Error with file, please check input file"))
                {
                    Assert.True(true);
                }
                else { 
                    Assert.True(false);
                }
            }

        }

        [Fact]
        public void TestFileReadPass()
        {
            try
            {
                FileReader fl = new FileReader();
               var list =  fl.FileRead(@"C:\Users\rober\Desktop\FormFree\IntegerFile\IntegerFile\TestFiles\TestFile1.txt");
               
                if(list.Count > 1)
                {
                    Assert.True(true);
                }
                else
                {
                    Assert.True(false);
                }

            }
            catch (Exception e)
            {
                Assert.True(false);
            }

        }

        [Fact]
        public void TestPrimeFactorsOut()
        {
            try
            {
                PrimeFactors pF = new PrimeFactors();
                var output = pF.PrimeFactorsOut(228);

                if(output.Length > 1)
                {
                    Assert.True(true);
                }
                else
                {
                    Assert.True(false);
                }

            }
            catch (Exception e)
            {
                Assert.True(false);
            }

        }


        [Fact]
        public void TestPrimeFactorsOutLists()
        {
            try
            {
                PrimeFactors pF = new PrimeFactors();
                LinkedList<int> list = new LinkedList<int>();
                list.AddLast(228);
                list.AddLast(189);
                list.AddLast(300);
                list.AddLast(39847);

                var output = pF.PrimeFactorsOut(list);

                if (output.Length > 1)
                {
                    Assert.True(true);
                }
                else
                {
                    Assert.True(false);
                }

            }
            catch (Exception e)
            {
                Assert.True(false);
            }

        }



    }
}
