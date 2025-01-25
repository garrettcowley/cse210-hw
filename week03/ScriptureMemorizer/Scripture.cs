using System;

class Scripture
{
    private Reference _reference;
    private Word[] _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] wordsArray = text.Split(' ');
        _words = new Word[wordsArray.Length];
        for (int i = 0; i < wordsArray.Length; i++)
        {
            _words[i] = new Word(wordsArray[i]);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int hiddenCount = 0;
        while (hiddenCount < numberToHide)
        {
            int index = random.Next(_words.Length);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hiddenCount++;
            }
        }
    }

    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText() + "\n";
        foreach (var word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }
        return displayText.Trim();
    }

    public bool IsCompletelyHidden()
    {
        foreach (var word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}
