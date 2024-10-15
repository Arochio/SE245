String runProgram = "Y";
while(runProgram == "Y") {
    String userInput;
    Console.Write("Enter your String: ");
    userInput = Console.ReadLine();
    for(var i = userInput.Length - 1; i >= 0; i -= 2) {
        Console.Write(userInput[i]);
    }
    Console.Write("Would you like to run the program again? [Y/N]: ");
    runProgram = Console.ReadLine().ToUpper();
}