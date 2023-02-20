using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VIN_LIB;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckVIN_CorrectLengthVin() // Проверка поведения логики, если введена правильная длина VIN кода
        {
            Assert.IsTrue(Class1.CheckVIN("DA123543214345234"));
        }

        [TestMethod]
        public void CheckVIN_WrongLengthVin() // Проверка поведения логики, если введена неправильная длина VIN кода
        {
            Assert.IsFalse(Class1.CheckVIN("DA14345234"));
        }

        [TestMethod]
        public void CheckVIN_ReturnTypeIsBool() // Метод должен вернуть тип данных bool
        {
            Assert.IsInstanceOfType(Class1.CheckVIN("DA14345234"), typeof(bool));
        }

        [TestMethod]
        public void CheckVIN_ReturnTypeIsNotString() // Метод не должен вернуть тип данных string
        {
            Assert.IsNotInstanceOfType(Class1.CheckVIN("DA14345234"), typeof(string));
        }

        [TestMethod]
        public void CheckVIN_NullExceptionHandling() // Проверка выдачи исключения, если передать значение null (сложный)
        {
            Assert.ThrowsException<AssertFailedException>(() => Assert.ThrowsException<SystemException>(() => Class1.CheckVIN(null)));
        }

        [TestMethod]
        public void CheckVIN_EmptyStrokeExceptionHandling() // Проверка выдачи исключения, если передать пустую строку (сложный)
        {
            Assert.ThrowsException<AssertFailedException>(() => Assert.ThrowsException<SystemException>(() => Class1.CheckVIN("")));
        }

        [TestMethod]
        public void GetVINCountry_ReturnAfrica()
        {
            Assert.IsTrue(Class1.GetVINCountry("AAAWD") == "Африка");
        }

        [TestMethod]
        public void GetVINCountry_ReturnEurope()
        {
            Assert.AreEqual(Class1.GetVINCountry("SAWDA123"), "Европа");
        }

        [TestMethod]
        public void GetVINCountry_ReturnedTypeIsString() // Метод должен вернуть тип данных string
        {
            Assert.IsInstanceOfType(Class1.GetVINCountry(""), typeof(string));
        }

        [TestMethod]
        public void GetVINCountry_ReturnedTypeIsNotInt() // Метод не должен вернуть тип данных int
        {
            Assert.IsNotInstanceOfType(Class1.GetVINCountry(""), typeof(int));
        }

        [TestMethod]
        public void GetVINCountry_ReturnUndefinedCountry() // Проверка поведения метода, если передать символ, который не прописан в логике
        {
            Assert.AreEqual(Class1.GetVINCountry("O"), "Не определено");
        }

        [TestMethod]
        public void GetVINCountry_NullExceptionHandling() // Проверка выдачи исключения, если передать значение null (сложный)
        {
            Assert.ThrowsException<AssertFailedException>(() => Assert.ThrowsException<SystemException>(() => Class1.GetVINCountry(null)));
        }

        [TestMethod]
        public void GetVINCountry_EmptyStrokeExceptionHandling()  // Проверка выдачи исключения, если передать пустую строку (сложный)
        {
            Assert.ThrowsException<AssertFailedException>(() => Assert.ThrowsException<SystemException>(() => Class1.GetVINCountry("")));
        }

        [TestMethod]
        public void GetVINCountry_IsNotExceptionWithCorrectVin()  // Проверка выдачи исключения, если передать корректное значение (сложный)
        {
            Assert.ThrowsException<AssertFailedException>(() => Assert.ThrowsException<SystemException>(() => Class1.GetVINCountry("DA123543214345234")));
        }

        [TestMethod]
        public void GetVINCountry_ReturnedAnswerIsNotNull() // Проверка на возвращаемое значение, которое не должно быть null
        {
            Assert.IsNotNull(Class1.GetVINCountry("%$@#$$@@!"));
        }
    }
}
