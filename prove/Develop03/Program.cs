using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Scripture scripture = new Scripture("John 3:16", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");
        Console.WriteLine (scripture);

        while (!scripture.allWordsHidden())
        {
            Console.Clear();
            scripture.hideRandomWord();
            scripture.Display();
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");
            string userInput = Console.ReadLine();
            if (userInput.ToLower() == "quit")
                break;
        }
    }
}

public class Reference 
{
    private string referenceText;

    public Reference (string text){
        referenceText = text;
    }
    public string getReferenceText(){
        return referenceText;

    }
}

public class Word 
{
    private string text;
    public bool isHidden;

    public Word (string text){

        this.text = text;
        isHidden = false;
    }
    public string getText (){

        return isHidden ? "____" : text;
    }
    public void hide (){

        isHidden = true;
    }
}

public class Scripture 
{
    private Reference reference;
    private List<Word> words;
    private int hiddenWordsCount;

    public Scripture (string referenceText, string scriptureText){

        reference = new Reference (referenceText);
        words = scriptureText.Split(' ').Select(word => new Word(word)).ToList();
        hiddenWordsCount = 0;
    }
    public bool allWordsHidden (){

        return hiddenWordsCount == words.Count;
    }

    public void hideRandomWord () {

        if (allWordsHidden()) return;

        Random random = new Random ();
        int index;
        do
        {
            index = random.Next(words.Count);
        } while (words[index].isHidden);

        words[index].hide();
        hiddenWordsCount ++;
    }
     public void Display() {
        Console.WriteLine(reference.getReferenceText());
        foreach (Word word in words)
        {
            Console.Write(word.getText() + " ");
        }
    }
}