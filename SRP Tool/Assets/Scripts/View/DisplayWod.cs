using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayWod : MonoBehaviour
{
    [SerializeField]
    private Transform wordBox;
    [SerializeField]
    private Button wordButton;

    public void WordsPopulation(List<string> wordList)
    {
        foreach(Transform child in wordBox)
        {
            Destroy(child.gameObject);
        }
        foreach(var word in wordList)
        {
            var button = Instantiate(wordButton, wordBox);
            button.GetComponentInChildren<Text>().text = word;
        }
    }
}
