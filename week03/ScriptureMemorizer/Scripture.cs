using System;
using System.Collections.Generic;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        foreach (string wordText in text.Split(' '))
        {
            _words.Add(new Word(wordText));
        }
    }

    public void HideRandomWords(int numberToHide)
{
    Random random = new Random();
    List<Word> visibleWords = _words.FindAll(word => !word.IsHidden());

    for (int i = 0; i < numberToHide && visibleWords.Count > 0; i++)
    {
        int index = random.Next(visibleWords.Count);
        visibleWords[index].Hide();
        visibleWords.RemoveAt(index); 
    }
}

    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText() + " ";
        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }
        return displayText.Trim();
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}