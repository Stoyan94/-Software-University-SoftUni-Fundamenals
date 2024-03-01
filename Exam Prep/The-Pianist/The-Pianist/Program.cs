

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

    if (command == "Add")
    {
        string songName = cmdArgs[0];
        string creator = cmdArgs[1];
        string key = cmdArgs[2];


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
        }
    }
    
    else if (command == "Remove")
    {

    } 
    else if (command == "ChangeKey")
    {

    }
}
