using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {

	void Start () {
		int[] a = { 1, 2, 3, 4, 5 };
		for(int i = 0; i < a.Length; i++) {
			Debug.Log(a[4 - i]);
				}
	}
	// Update is called once per frame
	void Update () {
	
	}
}
