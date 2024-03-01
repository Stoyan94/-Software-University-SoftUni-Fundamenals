

int songsCount = int.Parse(Console.ReadLine());

Dictionary<string, Dictionary<string, string>> dataTable = new Dictionary<string, Dictionary<string, string>>();

for (int i = 0; i < songsCount; i++)
{
    string[] piecesInfo = Console.ReadLine().Split("|").ToArray();

    string songName = piecesInfo[0];
    string creator = piecesInfo[1];
    string key = piecesInfo[2];


    if (!dataTable.ContainsKey(songName))
    {
        dataTable.Add(songName, new Dictionary<string, string>()
        {
            {"composer", creator},
            {"key", key},
        });
    }


}

string commands;

while ((commands = Console.ReadLine()) != "Stop")
{
    string[] cmdArgs = commands.Split("|").ToArray();

    string command = cmdArgs[0];
    string songName = cmdArgs[1];

    if (command == "Add")
    {      
        string creator = cmdArgs[2];
        string key = cmdArgs[3];

        if (dataTable.ContainsKey(songName))
        {
            Console.WriteLine($"{songName} is already in the collection!");
        }
        else
        {
            dataTable.Add(songName, new Dictionary<string, string>()
        {
            {"composer", creator},
            {"key", key},
        });
            Console.WriteLine($"{songName} by {creator} in {key} added to the collection!");
        }
    }    
    else if (command == "Remove")
    {
        if (dataTable.ContainsKey(songName))
        {
            dataTable.Remove(songName);
            Console.WriteLine($"Successfully removed {songName}!");

        }
        else
        {
            Console.WriteLine($"Invalid operation! {songName} does not exist in the collection.");
        }
    } 
    else if (command == "ChangeKey")
    {
        string newKey = cmdArgs[2];

        if (dataTable.ContainsKey(songName))
        {
            dataTable[songName]["key"] = newKey;
            Console.WriteLine($"Changed the key of {songName} to {newKey}!");
        }
        else 
        {
            Console.WriteLine($"Invalid operation! {songName} does not exist in the collection.");
        }
    }
}


foreach (var item in dataTable)
{
    Console.WriteLine($"{item.Key} -> Composer: {item.Value["composer"]}, Key: {item.Value["key"]}");
}
