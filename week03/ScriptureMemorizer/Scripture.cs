/*
Scripture keeps track of both the reference and the text
 of a scripture. Can hide words and get the rendered display 
 of the text.
*/

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        // Create Word objects for each one and put them in the list.
        foreach (string word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }

    // I'm not completely sure about the need of creating a secondary method to manage the list
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        // Create a temporary list made of only visible words
        List<Word> visibleWords = _words.Where(w => !w.IsHidden()).ToList();

        // When there are only a few words left, I need to make sure I won't try to hide more than words in the list.
        int wordsToHide = Math.Min(numberToHide, visibleWords.Count);

        for (int i = 0; i < wordsToHide; i++)
        {
            int idx = random.Next(0, visibleWords.Count);
            visibleWords[idx].Hide();
            visibleWords.RemoveAt(idx); // prevents repeated hiding
        }
    }
   

    public string GetDisplayText()
    {
        string referenceText = _reference.GetDisplayText();

        foreach (Word word in _words)
        {
            referenceText += " " + word.GetDisplayText();
        }

        return referenceText;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {   // if any of the words is not hidden, return false.
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

}