using System.Collections;
using UnityEngine;
using UnityEditor;


[CustomEditor(typeof(Level))]
public class LevelEditor : Editor {

    public override void OnInspectorGUI(){
        Level myTarget = (Level)target;
        myTarget.experience = EditorGUILayout.IntField("Experience", myTarget.experience);
        EditorGUILayout.LabelField("Level", myTarget.level.ToString());
    }
}
