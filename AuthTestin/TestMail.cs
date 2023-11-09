using NUnit.Framework;
using System.Text.RegularExpressions;

namespace AuthTesting
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestMail()
        {
            // Arrange
            string mailValido = "usuario@example.com";
            string mailInvalido = "usuario@example";

            // Act
            bool resultadoValido = MailValido(mailValido);
            bool resultadoInvalido = MailValido(mailInvalido);

            // Assert
            Assert.IsTrue(resultadoValido);
            Assert.IsFalse(resultadoInvalido);
        }

        public bool MailValido(string mail)
        {
            string patron = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(mail, patron);
        }
    }
}
