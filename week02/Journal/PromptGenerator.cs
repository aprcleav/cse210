public class PromptGenerator
{
    public List<string> _prompts = new List<string> { "Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "If I had one thing I could do over today, what would it be?", "What are you grateful for today?", "What new skill would you love to learn?", "What did you learn today?", "What does kindness mean to you?" };

    public string GetRandomPrompt()
    // Gets a random prompt from the list of promtps and returns it
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }
}