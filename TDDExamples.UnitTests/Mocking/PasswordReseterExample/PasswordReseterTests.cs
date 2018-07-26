
using System.Security.Cryptography.X509Certificates;
using Moq;
using NUnit.Framework;
using TDDExamples.Mocking;
using TDDExamples.Mocking.PasswordReseterExample;

namespace TDDExamples.UnitTests.Mocking.PasswordReseterExample
{
    public class PasswordReseterTests
    {
        private string _somePassword;

        [Test]
        public void WhenResetingAPasswordItShouldUpdateThePassworAndSendAnEmail()
        {
            //Arrange
            var sut = new PasswordReseter();
            var username = "AcidBurnz";
            var IDB = new Mock<IDB>();
            var ec = new Mock<IEmail>();

            IDB.Setup(i => i.SavePassword(username)).Returns(_somePassword);

            //Act
            var newPassword = sut.ResetPasswordSaveAndEmail(username);


            //Assert
            IDB.Verify(i => i.SavePassword(username));
            ec.Verify(e => e.Send(_somePassword));
        }
    }

    public interface IEmail
    {
        void Send(string password);
    }

    public interface IDB
    {
        string SavePassword(string username);

    }
}