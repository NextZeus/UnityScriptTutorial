using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(ButtonScript))]
public class ButtonScriptEditor : Editor {
    public override void OnInspectorGUI(){
        DrawDefaultInspector();

        ButtonScript myScript = (ButtonScript)target;

        if(GUILayout.Button("Build Object")){
            myScript.BuildObject();
        }
    }

}
