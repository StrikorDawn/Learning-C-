using System;
using System.Collections.Generic;
using System.ComponentModel;

public class Prompt
{
    private List<string> _promptList = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What good did you do?",
        "Did you have any moments to 'Think Celestial' today?",
        "What's something you are proud of today?"

    };

    public string DisplayRandomPrompt()
    {
        int _promptNumber = _promptList.Count - 1;
        Random _randomGenerator = new Random();
        int _prompt = _randomGenerator.Next(_promptNumber);
        Console.WriteLine(_promptList[_prompt]);
        return _promptList[_prompt];
    }
}