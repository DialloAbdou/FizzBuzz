using FizzBuzz.Services;

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
            Assert.Equal("Buzz", result);
        }

        [Fact]
        public void getFizzBuzz_should_return_FIzzBuZ_when_value_divisible_by_Three_And_Five()
        {
            // 1. Arrange => Préparer mon environnement
            //2. Act => Executer la methode ou l'unite business dont je teste
            var result = service.GetFizzBuzz(15);
            //3. Assert => je verifie suite à l'execution ma methode ou l'unite bussiness j'ai le resultat attendu
            Assert.Equal("FizzBuzz", result);
        }

        [Fact]
        public void getFizzBuzz_should_return_2_if_2_Passed()
        {
            // 1. Arrange => Préparer mon environnement

            //2. Act => Executer la methode ou l'unite business dont je teste
            var result = service.GetFizzBuzz(2);
            //3. Assert => je verifie suite à l'execution ma methode ou l'unite bussiness j'ai le resultat attendu
            Assert.Equal("2", result);
        }


        [Fact]
        public void GetFizzBuzzPhrase_should_return_FizzBuzzPhrase()
        {
            // 1. Arrange => Préparer mon environnement

            //2. Act => Executer la methode ou l'unite business dont je teste
            var result = service.GetFizzBuzzPhrase(15);
            //3. Assert => je verifie suite à l'execution ma methode ou l'unite bussiness j'ai le resultat attendu
            Assert.Equal("1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz", result);
        }

    }
}
