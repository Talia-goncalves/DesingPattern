using System.IO;
using System.Text.Json;

public class GameSaver
{
    public void Save(GameMemento memento, string filePath)
    {
        string json = JsonSerializer.Serialize(memento);
        File.WriteAllText(filePath, json);
    }

    public GameMemento Load(string filePath)
    {
        string json = File.ReadAllText(filePath);
        return JsonSerializer.Deserialize<GameMemento>(json);
    }
}
