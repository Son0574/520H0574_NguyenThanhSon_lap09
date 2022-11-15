using StudentServiceLib;

namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_KetquaA()
        {
            Student s = new Student();
            s.Id = 1;
            s.Name =   "Khoa";
            s.Score = 9;
            s.Age = 19;

            char letter = s.getLetterScore();
            Assert.AreEqual(s.getLetterScore(), 'A');
        }

        [TestMethod]
        public void Test_KetquaB()
        {
            Student s = new Student();
            s.Id = 2;
            s.Name = "Khoa";
            s.Score = 7;
            s.Age = 19;

            char letter = s.getLetterScore();
            Assert.AreEqual(s.getLetterScore(), 'B');
        }

        [TestMethod]
        public void Test_KetquaC()
        {
            Student s = new Student();
            s.Id = 3;
            s.Name = "Khoa";
            s.Score = 5;
            s.Age = 19;

            char letter = s.getLetterScore();
            Assert.AreEqual(s.getLetterScore(), 'C');
        }

        [TestMethod]
        public void Test_KetquaD()
        {
            Student s = new Student();
            s.Id = 4;
            s.Name = "Khoa";
            s.Score = 4;
            s.Age = 19;

            char letter = s.getLetterScore();
            Assert.AreEqual(s.getLetterScore(), 'D');
        }
    }
}