using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CharacterGen.Tests
{
    [TestFixture]
    public class CharacterGenTests
    {
        [TestFixture]
        public class GivenACharacterGen
        {
            private CharacterGen _characterGen;

            [OneTimeSetUp]
            public void WhenCreating()
            {
                _characterGen = new CharacterGen();
            }

            [Test]
            public void ThenTheRightObjectIsCreated()
            {
                Assert.That(_characterGen.GetType(), Is.EqualTo(typeof(CharacterGen)));
            }
        }
    }
}
