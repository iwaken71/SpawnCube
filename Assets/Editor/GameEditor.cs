using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(GameScript))]
public class GameEditor : Editor {
	

	public override void OnInspectorGUI(){

		DrawDefaultInspector ();
		GameScript myScript = (GameScript)target;
		//EditorGUILayout.IntField("x",)


		if (GUILayout.Button ("Spawnx")) {
			myScript.Spawnx ();

		}
			


		//myScript.pos = new Vector3 (x,y,z);


	}



}
