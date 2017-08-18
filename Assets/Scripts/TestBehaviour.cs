using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestBehaviour : MonoBehaviour {

	public Transform LookAtTarget;
	public float volume = 0.5f;

	public int propriedade;
	public string texto;

	public int[] array = new int[]{1,2,3,4,5};

	public void DoSomething(){
		Debug.Log ("K");
		transform.localPosition = Vector3.zero;
		transform.LookAt (LookAtTarget);

	}
}