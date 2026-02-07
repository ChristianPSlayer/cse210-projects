using System;

public class Comment
{
   
    public string _name;
    public string _text;
    public string _date; 

    
    public Comment(string name, string text, string date)
    {
        _name = name;
        _text = text;
        _date = date;
    }

   
    public string GetDisplayText()
    {
        
        return $"{_name} ({_date}): \"{_text}\"";
    }
}