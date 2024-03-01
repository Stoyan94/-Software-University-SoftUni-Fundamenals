


string word = Console.ReadLine();

string commands;

while ((commands = Console.ReadLine()) != "Decode")
{
    string[] cmdArs = commands.Split("|").ToArray();

    string command = cmdArs[0];


    if (command == "ChangeAll")
    {
        string letterToSwap = cmdArs[1];
        string putThisLeeter = cmdArs[2];
       
        word = word.Replace(letterToSwap, putThisLeeter);
    }
    else if (command == "Insert")
    {
        int indexInsert = int.Parse(cmdArs[1]);
        string letterInser = cmdArs[2];

       word = word.Insert(indexInsert, letterInser);
    } 
    else if (command == "Move")
    {
        int countIndexMove = int.Parse(cmdArs[1]);

        string moveThis = word.Substring(0, countIndexMove);

        word = word.Remove(0, countIndexMove);

        word = word.Insert(word.Length, moveThis);
    }
}

Console.WriteLine($"The decrypted message is: {word}");