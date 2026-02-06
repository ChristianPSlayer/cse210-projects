using System;

public class Word
{
    private string _text;
    private bool _isHidden;


    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }

    public void Show()
    {
        _isHidden = false;
    }
    public string GetDisplayText()
    {
        if (_isHidden)
        {

            return "___";
        }
        else
        {
            return _text;
        }
    }
}

