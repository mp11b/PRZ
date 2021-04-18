# Assignment-5-mp11b
## Refactoring
Refactoring was done on these parts of the code:

1) Class RestCountries: The "response.EnsureSuccessStatusCode()" method of line 44 was replaced by the bulean "response.IsSuccessStatusCode", so that the program would not crash when an incorrect request was made to the api, such as making a request to the API of a country that does not exist. This causes that if the API response is wrong, a null is returned.
2) Class CalculateStatistics: This class was refactored since within it requests to the API were made, which made the calls to the API many or unnecessary in some parts. So I decided that the requests to the api should be done outside of this class. Also doing this made it easier for me to perform unit tests.
3) Class PrintCountriesInfo: This class was already refatorized to be able to test if the printed outputs in console were correct. Methods were created that returned strings with the responses instead of printing directly. I also facilitate testing.

## Test
In this assignment, 5 unit tests were carried out:

1) CorrectCompareDensityCountries(): This test verifies if the delivered result is the country with the highest density. In this case, it was specifically testified that the user came to the same country and printed the correct result regardless of this.This is testified in case the user makes that mistake when trying to compare the same country.
2) CorrectCalculateTotalPopulation():This test verifies that the result delivered from the sum of the total population works correctly when delivering the information to the user. This was tested in order to verify that the function worked correctly.
3) CorrectCalculateAveragePoputionCountries(): This test verifies if the average of a list of countries is well calculated. This to corroborate that the functionality of delivering the average of all countries works correctly.
4) CorrectOutputStatisticAreaCountry():This test verifies if the output provided by the PrintStatisticCountry () function correctly prints the statistics regardless of the country entered. It is important to test it because it is necessary to know if the output that the user reads is correct.
5) CorrectOutputNullListInTotalPopulationCountries(): As mentioned in the refactoring part, a method of the RestCountries class was modified so that the response of an erroneous request to the API was null. Due to this, in the test it verified that the program would not crash if the list it received was null and an error message entered.
