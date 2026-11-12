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

    public string GetDisplayText()
    {
        if (_isHidden)
        {
            string hiddenWord = "";

            foreach (char letter in _text)
            {
                if (char.IsLetter(letter))
                {
                    hiddenWord += "_";
                }
                else
                {
                    hiddenWord += letter;
                }
            }

            return hiddenWord;
        }
        else
        {
            return _text;
        }
    }

}