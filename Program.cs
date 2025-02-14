using LIST_AND_DICTIONATY;


// 1. Create an instance of the ListOperations class:
//ListExercise listExercise = new ListExercise();
var listExercise = new ListExercise();
// 2. Create a list of integers:
List <int> myNumbers = new List<int> () {1, 2, 3, 4 ,5, 3};
 // 3. Call the methods on the instance, passing the list:
int sum = ListExercise.SumLists(myNumbers);
Console.WriteLine($"Sum:{sum}");