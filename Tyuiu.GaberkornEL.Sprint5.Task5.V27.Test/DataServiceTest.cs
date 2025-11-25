using Tyuiu.GaberkornEL.Sprint5.Task5.V27.Lib;
namespace Tyuiu.GaberkornEL.Sprint5.Task5.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\Ymir\Downloads\Sprint5Task5\InPutDataFileTask5V27.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            Assert.AreEqual(true, fileExist);

        }
    }
}