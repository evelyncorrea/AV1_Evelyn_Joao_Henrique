using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(LerpTest))]

public class LerpTextEditor : Editor {

	public override void OnInspectorGUI(){

		LerpTest lerpTest = target as LerpTest;

		EditorGUILayout.LabelField ("LerpText", EditorStyles.boldLabel);

		lerpTest.max =   
		EditorGUILayout.FloatField ("Max Value", lerpTest.max);

		lerpTest.min = 
		EditorGUILayout.FloatField ("Min Value", lerpTest.min);

		if (lerpTest.min > lerpTest.max) {
			Debug.Log ("You can't insert a minimum value bigger than the maximum!");
			lerpTest.min = lerpTest.max - 1;	
		}
		if (lerpTest.min <= 0) { lerpTest.min = 0; }

		lerpTest.t = EditorGUILayout.Slider ("Volume", lerpTest.t, 0, 1);

		float x = Mathf.Lerp (lerpTest.min, lerpTest.max, lerpTest.t);

		x = EditorGUILayout.FloatField ("New Value", x);
	}
}