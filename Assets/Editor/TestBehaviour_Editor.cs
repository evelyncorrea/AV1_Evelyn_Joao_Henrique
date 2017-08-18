using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(TestBehaviour))]

public class TestBehaviourEditor : Editor {

	int Tomate;

	public override void OnInspectorGUI(){

		//base.OnInspectorGUI ();

		TestBehaviour testBehaviour = target as TestBehaviour;
 
		EditorGUILayout.LabelField ("BATATA", EditorStyles.boldLabel);

		for (int i = 0; i < testBehaviour.array.Length; i++) {
			testBehaviour.array[i] = EditorGUILayout.IntField ("Elemento " + i, testBehaviour.array[i]);
		}

		/*testBehaviour.LookAtTarget = 
		EditorGUILayout.ObjectField ("Target", testBehaviour.LookAtTarget, typeof(Transform), true) as Transform;

		testBehaviour.propriedade = 
		EditorGUILayout.IntField ("Tomate", testBehaviour.propriedade);

		testBehaviour.texto = 
		EditorGUILayout.TextArea (testBehaviour.texto);

		testBehaviour.volume = 
		EditorGUILayout.Slider ("Volume", testBehaviour.volume, 0.0f, 1);*/

		if (GUILayout.Button ("RESETAR TRASFORMER")) {
			testBehaviour.DoSomething ();
		} 

	}
}
