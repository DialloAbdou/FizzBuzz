using FizzBuzz.Services;

namespace FizzBuzzTest.Services
{
    public class FizzBuzzServiceTest
    {
        [Fact]
        public void getFizzBuzz_should_return_Fizz_when_value_divisible_by_three()
        {
            // Arrange
            var service = new FizzBuzzService();
            var expected = "Fizz";
            //Act
            var result = service.getFizzBuzz(3);
            //Assert
            Assert.Equal(expected, result);
        }
        [Fact]
        public void getFizzBuzz_should_return_BuZZ_when_value_divisible_by_five()
        {
            // 1. Arrange => Préparer mon environnement
            var service = new FizzBuzzService();

            //2. Act => Executer la methode ou l'unite business dont je teste
            var result = service.getFizzBuzz(5);
            //3. Assert => je verifie suite à l'execution ma methode ou l'unite bussiness j'ai le resultat attendu
            Assert.Equal("Buzz", result);
        }

        [Fact]
        public void getFizzBuzz_should_return_FIzzBuZ_when_value_divisible_by_Three_And_Five()
        {
            // 1. Arrange => Préparer mon environnement
            var service = new FizzBuzzService();

            //2. Act => Executer la methode ou l'unite business dont je teste
            var result = service.getFizzBuzz(30);
            //3. Assert => je verifie suite à l'execution ma methode ou l'unite bussiness j'ai le resultat attendu
            Assert.Equal("FizzBuzz", result);
        }

        [Fact]
        public void getFizzBuzz_should_return_2_if_2_Passed()
        {
            // 1. Arrange => Préparer mon environnement
            var service = new FizzBuzzService();

            //2. Act => Executer la methode ou l'unite business dont je teste
            var result = service.getFizzBuzz(2);
            //3. Assert => je verifie suite à l'execution ma methode ou l'unite bussiness j'ai le resultat attendu
            Assert.Equal("2", result);
        }

    }
}
