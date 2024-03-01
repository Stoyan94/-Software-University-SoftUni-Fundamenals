


string[] words = Console.ReadLine()
          .Split(' ', StringSplitOptions.RemoveEmptyEntries)
          .ToArray();
decimal sum = 0;

foreach (string word in words)
{
    sum += CalculateSingleWordSum(word);
}


Console.WriteLine($"{sum:f2}");

decimal CalculateSingleWordSum(string word)
{   
    decimal sum = 0;

    //The first letter and the last letter are not part of the number (-2)
    char firstLetter = word[0];
    char lastLetter = word[word.Length - 1];
    int num = int.Parse(word.Substring(1,word.Length-2));

    int firstLetterPos = GetAlphabeticalPositionOfCharacter(firstLetter);
    int lastLetterPos = GetAlphabeticalPositionOfCharacter(lastLetter);

    if (firstLetterPos == -1 || lastLetterPos == -1)
    {
        return 0m;
    }

    if (char.IsUpper(firstLetter))
    {
        sum = (decimal)num / firstLetterPos;
    }
    else if (char.IsLower(firstLetter))
    {
        sum = (decimal)num * firstLetterPos;
    }

    if (char.IsUpper(lastLetter))
    {
        sum -= lastLetterPos;
    }
    else if(char.IsLower(lastLetter))
    {
        sum += lastLetterPos;
    }

    return 1;
}

int GetAlphabeticalPositionOfCharacter(char firstLetter)
{
    throw new NotImplementedException();
}