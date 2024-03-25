// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("TrueCoders is awesome!!!");

// var num = 3;
// if(num % 3 == 0 && num % 5 == 0){
//     Console.WriteLine("Fizzbuzz");
// }
// else if(num % 3 == 0){
//     Console.WriteLine("fizz");
// }
// else if(num % 5 == 0)
// {
//     Console.WriteLine("buzz");
// }

public string FizzBuzz(int number)
{
    //store answer in variable
    string answer = "";

    //return word fizz if number is divisible by 3
    if(number % 3 == 0)
    {
        answer = "fizz";
    }
    //return word fizz if number is divisible by 5
    if(number % 5 == 0)
    {
        //this will if divisible by 5 or concatenate both fizzbuzz if divisible by 3 & 5
        answer += "buzz";
    }
    return answer;
}// end FizzBuzz method












