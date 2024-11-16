using UnityEditor;
using UnityEngine;

public class LevelEditor : EditorWindow
{
    private LevelData levelData;

    [MenuItem("Tools/Level Editor")]
    public static void ShowWindow()
    {
        GetWindow<LevelEditor>("Level Editor");
    }

    private void OnGUI()
    {
        levelData = (LevelData)EditorGUILayout.ObjectField("Level Data", levelData, typeof(LevelData), false);

        if (levelData != null)
        {
            levelData.levelName = EditorGUILayout.TextField("Level Name", levelData.levelName);

            EditorGUILayout.LabelField("Words:");
            for (int i = 0; i < levelData.wordsList.Count; i++)
                levelData.wordsList[i] = EditorGUILayout.TextField($"Word {i + 1}", levelData.wordsList[i]);

            if (GUILayout.Button("Add Word"))
                levelData.wordsList.Add("");

            levelData.neededAnimation = (AnimationClip)EditorGUILayout.ObjectField("Animation", levelData.neededAnimation, typeof(AnimationClip), false);

            if (GUI.changed)
                EditorUtility.SetDirty(levelData);
        }
    }
}
