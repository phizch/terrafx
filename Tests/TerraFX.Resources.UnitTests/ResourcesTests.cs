// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System.Globalization;
using NUnit.Framework;

namespace TerraFX.UnitTests
{
    /// <summary>Provides a set of tests covering the <see cref="Resources" /> static class.</summary>
    [TestFixture(Author = "Tanner Gooding", TestOf = typeof(Resources))]
    public static class ResourcesTests
    {
        #region Static Property Tests
        /// <summary>Provides validation of the <see cref="Resources.ArgumentExceptionForInvalidTypeMessage" /> static property.</summary>
        [TestCase("en", "{0} is an instance of {1}")]
        public static void ArgumentExceptionForInvalidTypeMessageTest(string cultureName, string expectedMessage)
        {
            Resources.Culture = CultureInfo.GetCultureInfo(cultureName);

            Assert.That(Resources.ArgumentExceptionForInvalidTypeMessage,
                Is.EqualTo(expectedMessage)
            );
        }

        /// <summary>Provides validation of the <see cref="Resources.ArgumentNullExceptionMessage" /> static property.</summary>
        [TestCase("en", "{0} is null")]
        public static void ArgumentNullExceptionMessageTest(string cultureName, string expectedMessage)
        {
            Resources.Culture = CultureInfo.GetCultureInfo(cultureName);

            Assert.That(Resources.ArgumentNullExceptionMessage,
                Is.EqualTo(expectedMessage)
            );
        }

        /// <summary>Provides validation of the <see cref="Resources.ArgumentOutOfRangeExceptionMessage" /> static property.</summary>
        [TestCase("en", "{0} has a value of {1}")]
        public static void ArgumentOutOfRangeExceptionMessageTest(string cultureName, string expectedMessage)
        {
            Resources.Culture = CultureInfo.GetCultureInfo(cultureName);

            Assert.That(Resources.ArgumentOutOfRangeExceptionMessage,
                Is.EqualTo(expectedMessage)
            );
        }

        /// <summary>Provides validation of the <see cref="Resources.Culture" /> static property.</summary>
        [TestCase("en")]
        public static void CultureTest(string cultureName)
        {
            var culture = CultureInfo.GetCultureInfo(cultureName);
            Resources.Culture = culture;

            Assert.That(Resources.Culture,
                Is.EqualTo(culture)
            );
        }

        /// <summary>Provides validation of the <see cref="Resources.ResourceManager" /> static field.</summary>
        [Test]
        public static void ResourceManagerTest()
        {
            Assert.That(Resources.ResourceManager,
                Is.Not.Null
            );
        }
        #endregion
    }
}