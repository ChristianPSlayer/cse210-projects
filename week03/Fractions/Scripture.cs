using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] splitWords = text.Split(' ');
        foreach (string w in splitWords)
        {
            _words.Add(new Word(w));
        }


    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        List<Word> visibleWords = _words.Where(w => !w.IsHidden()).ToList();


        int count = Math.Min(numberToHide, visibleWords.Count);

         for (int i = 0; i < count; i++)
    {
        int indexAzar = random.Next(visibleWords.Count);
        visibleWords[indexAzar].Hide();
        visibleWords.RemoveAt(indexAzar);
    }
}
                
            
    
 public bool isCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }
       
    public string GetDisplayText()
    {
        string text = "";
        foreach(Word w in _words)
        {
            text += w.GetDisplayText() + " ";

        }
        return $"{_reference.GetDisplayText()} - {text}";
    }
}