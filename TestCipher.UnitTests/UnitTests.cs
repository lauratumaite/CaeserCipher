using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CaeserCipher;

namespace TestCipher.UnitTests
{
    [TestClass]
    public class UnitTests
    {

        [TestMethod]
        public void TestEncryptionShift3()
        {
            int shift = 3;
            string input = "Hello!";
            string expectedOutput = "Khoor!";

            var result = Cipher.Encipher(input, shift);

            Assert.AreEqual(expectedOutput, result);
        }

        [TestMethod]
        public void TestEncryptionShift4()
        {
            int shift = 4;
            string input = "vagsud567$%&bhs VGHJV";
            string expectedOutput = "zekwyh$%&flw ZKLNZ"; //false result

            var result = Cipher.Encipher(input, shift);

            Assert.AreEqual(expectedOutput, result);
        }

        [TestMethod]
        public void TestEncryptionShift10()
        {
            int shift = 10;
            string input = "dsbhsbsdf";
            string expectedOutput = "nclrclcnp";

            var result = Cipher.Encipher(input, shift);

            Assert.AreEqual(expectedOutput, result);
        }

        [TestMethod]
        public void TestDecryptionShift3()
        {
            int shift = 3;
            string input = "Khoor!";
            string expectedOutput = "Hello!";

            var result = Cipher.Decipher(input, shift);

            Assert.AreEqual(expectedOutput, result);
        }

        [TestMethod]
        public void TestDecryptionShift25()
        {
            int shift = 25;
            string input = "ghv gv$bjh@cgf^lkn$";
            string expectedOutput = "hiw hw$cki@dhg^mlo$";

            var result = Cipher.Decipher(input, shift);

            Assert.AreEqual(expectedOutput, result);
        }

        [TestMethod]
        public void TestDecryptionShift8()
        {
            int shift = 8;
            string input = "bbsdhjbshihsd BHJVIYVUGVGV";
            string expectedOutput = "ttkvzbtkzazkv TZBNAQNMYNYN";

            var result = Cipher.Decipher(input, shift);

            Assert.AreEqual(expectedOutput, result);
        }
    }
}
