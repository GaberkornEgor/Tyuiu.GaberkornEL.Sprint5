using Tyuiu.GaberkornEL.Sprint5.Task6.V11.Lib;
using System.IO;
namespace Tyuiu.GaberkornEL.Sprint5.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\Ymir\Downloads\Sprint5Task6\InPutDataFileTask6V11.txt";

            var res = ds.LoadFromDataFile(path);
            int wait = 3;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void TestMethod2()
        {
            string path = @"C:\Users\Ymir\Downloads\Sprint5Task6\InPutDataFileTask6V11.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}