using System;
using UnityEngine;

public class WordSelectController : MonoBehaviour
{
    [SerializeField]
    private Action<int> OnSelectionOfWords;  //notifies word selection

    public void HandlingSelection(int wordIndex)
    {
        OnSelectionOfWords?.Invoke(wordIndex);
    }
}
