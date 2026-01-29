using System;

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