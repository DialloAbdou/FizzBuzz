using FizzBuzz.Services;
using FluentAssertions;
using Xunit;

namespace FizzBuzzTest.Services
{
    public class FizzBuzzServiceTest
    {
        FizzBuzzService service;
        public FizzBuzzServiceTest()
        {
            service = new FizzBuzzService();
        }
        [Fact]
        public void getFizzBuzz_should_return_Fizz_when_value_divisible_by_three()
        {
            // Arrange
            var expected = "Fizz";
            //Act
            var result = service.GetFizzBuzz(3);
            // using fluenAssert
            result.Should().Be(expected);
            //Assert
            Assert.Equal(expected, result);
        }
        [Fact]
        public void getFizzBuzz_should_return_BuZZ_when_value_divisible_by_five()
        {
            // 1. Arrange => Préparer mon environnement
            //2. Act => Executer la methode ou l'unite business dont je teste
            var result = service.GetFizzBuzz(5);
            //3. Assert => je verifie suite à l'execution ma methode ou l'unite bussiness j'ai le resultat attendu
            // using fluent
            result.Should().NotBeEmpty();
            result.Should().Contain("Buzz");
            Assert.Equal("Buzz", result);
        }

        [Fact]
        public void getFizzBuzz_should_return_FIzzBuZ_when_value_divisible_by_Three_And_Five()
        {
            // 1. Arrange => Préparer mon environnement
            //2. Act => Executer la methode ou l'unite business dont je teste
            var result = service.GetFizzBuzz(15);
            //3. Assert => je verifie suite à l'execution ma methode ou l'unite bussiness j'ai le resultat attendu
            result.Should().NotBeEmpty();
            result.Should().Contain("FizzBuzz");
            Assert.Equal("FizzBuzz", result);
        }

        [Fact (Skip="ignorer ce test")]
        public void getFizzBuzz_should_return_2_if_2_Passed()
        {
            // 1. Arrange => Préparer mon environnement

            //2. Act => Executer la methode ou l'unite business dont je teste
            var result = service.GetFizzBuzz(2);
            //3. Assert => je verifie suite à l'execution ma methode ou l'unite bussiness j'ai le resultat attendu
            Assert.Equal("2", result);
        }


        [Theory]
        [InlineData(15, "1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz")]
        [InlineData(6, "1 2 Fizz 4 Buzz Fizz")]
        public void GetFizzBuzzPhrase_should_return_FizzBuzzPhrase(int max, string expectedData)
        {
            // 1. Arrange => Préparer mon environnement

            //2. Act => Executer la methode ou l'unite business dont je teste
            var result = service.GetFizzBuzzPhrase(max);
            //3. Assert => je verifie suite à l'execution ma methode ou l'unite bussiness j'ai le resultat attendu
            result.Should().Be(expectedData);
            Assert.Equal(expectedData, result);
        }

        [Fact]
        public void GetFizzBuzzPhrase_should_ThrowArgumentException_When_Max_Is_lowerOrEqual_To_Zero()
        {
            // Arrange
            // Act
            Action act =()=> service.GetFizzBuzzPhrase(-20);
            act.Should().Throw<ArgumentException>();
            //var except = Assert.Throws<ArgumentException>(() => service.GetFizzBuzzPhrase(-20));
            // Assert
            //Assert.Equal("max", except.ParamName);
        }

    }
}
