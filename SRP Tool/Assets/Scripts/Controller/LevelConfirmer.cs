using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelConfirmer : MonoBehaviour
{
    [SerializeField]
    private LevelData currentLevelData;

    public void SelectionValidation(List<int> selectedIndices)
    {
        if(new HashSet<int>(selectedIndices).SetEquals(currentLevelData.correctWordIndices))
        {
            TriggerLevelSuccess();
        }
    }

    private void TriggerLevelSuccess()
    {
        Debug.Log("Level Solved!");
        // Trigger associated animation or action here
    }
}
