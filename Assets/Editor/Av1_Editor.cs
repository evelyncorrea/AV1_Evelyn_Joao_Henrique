using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Av1))]

public class Av1_Editor : Editor {

	public override void OnInspectorGUI(){
		Av1 av1 = target as Av1;

		for (int i = 0; i < av1.lista.Count; i++) {
			av1.lista[i].value = EditorGUILayout.IntField ("Elemento " + i, av1.lista[i].value);
            av1.lista[i].key = EditorGUILayout.TextField("pao ", av1.lista[i].key);
		}
        
		if (GUILayout.Button ("Adicionar elemento")) {
            av1.lista.Add(new Av1.Entry());
		}
        if (GUILayout.Button("Remover elemento")) 
        {
            av1.lista.Remove(av1.lista[av1.lista.Count - 1]);
        }
    }
}