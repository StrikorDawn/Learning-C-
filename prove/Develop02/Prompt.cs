using System;
using System.Collections.Generic;
using System.ComponentModel;

public class Prompt
{
    private List<string> _promptList = new List<string>()
    {
        "How are you feeling?",
        "What was your favorite part of the day?",
        "What good did you do?",
        "How did you see the Lord's hand in your day?",
        ""
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