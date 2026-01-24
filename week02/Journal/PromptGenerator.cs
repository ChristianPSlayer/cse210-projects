using System;
using System.Collections.Generic;


public class PromptGenerator
{
    public List<string> _prompt = new List<string>();

    public PromptGenerator()
    {   //in the construction add questions to the List
        _prompt.Add("Waht is yuor favorite Language Programming");
        _prompt.Add("what is your favorite soccer player");
        _prompt.Add("what is the best day of your life");
        _prompt.Add("what is your favorite scripture");
        _prompt.Add("How do you live the gospel every day?");
    }

    public string GetRamdomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompt.Count);
        return _prompt[index];
    }
}