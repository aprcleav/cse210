public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _mood;

    public Entry(string date, string mood, string prompt, string input)
    // Stores data for each entry
    {
        _date = date;
        _mood = mood;
        _promptText = prompt;
        _entryText = input;
        
    }

    public override string ToString()
    // Converts each entry to type string and returns the string
    {
        return $"Date: {_date} - Mood: {_mood} - Prompt: {_promptText} \n{_entryText}";
    }

}