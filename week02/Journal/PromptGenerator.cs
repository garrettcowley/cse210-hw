using System;

class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "What are you grateful for today?",
        "What was an interesting event that happened today?",
        "What did you learn today?",
        "Who did you talk to today?",
        "What do you need to get off of your chest?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int list = random.Next(_prompts.Count);
        return _prompts[list];
    }
}
