using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LevelData", menuName = "Puzzle/LevelData", order = 1)]
public class LevelData : ScriptableObject
{
    public string levelName;   
    public List<string> wordsList;
    public List<int> correctWordIndices;
    public AnimationClip neededAnimation; // Animation to play upon solving
}
