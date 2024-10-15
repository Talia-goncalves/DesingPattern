using System;
using System.IO;
using System.Text.Json;

public class GameSaver
{
    public void Save(GameMemento memento, string filePath)
    {
        var options = new JsonSerializerOptions
        {
            WriteIndented = true 
        };

        string jsonString = JsonSerializer.Serialize(memento, options);
        File.WriteAllText(filePath, jsonString);
    }

    public GameMemento Load(string filePath)
    {
        string jsonString = File.ReadAllText(filePath);
        return JsonSerializer.Deserialize<GameMemento>(jsonString);
    }
}
