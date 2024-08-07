Random random = new Random();
Console.WriteLine("enter s to Start or e to End");
string start = Console.ReadLine().ToLower().Trim();

do
{
    Console.Clear();
    Console.WriteLine("Would you like to play? (Y/N)");

    
    if (ShouldPlay())
    {
        PlayGame();
    }

    void PlayGame()
    {
        var play = true;

        while (play)
        {
            var target = random.Next(1, 5);
            var roll = random.Next(1, 6);

            Console.WriteLine($"Roll a number greater than {target} to win!");
            Console.WriteLine($"You rolled a {roll}");
            Console.WriteLine(WinOrLose(target, roll));
            Console.WriteLine("\nPlay again? (Y/N)");

            play = ShouldPlay();
        }
    }

    string WinOrLose(int target, int roll)
    {
        string result = "";

        if (target < roll)
            result = "you won";
        else result = "you lost";

        return result;
    }
    bool ShouldPlay()
    {
        bool playf = false;
        string userinput = Console.ReadLine().ToUpper().Trim();
        if (userinput == "Y")
        {
            playf = true;
        }
        else if (userinput == "E")
        {
            start = "end";
        }
       
        return playf;

    }

}while(start!="end");