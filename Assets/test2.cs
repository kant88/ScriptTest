using UnityEngine;
using System.Collections;

public class Boss{
	private int mp = 53;
	public void Magic(){
		if (this.mp >= 5) {
			this.mp -= 5;
			Debug.Log ("魔法攻撃をした。残りMPは" + this.mp);
		} else {
			Debug.Log ("MPが足りないため魔法が使えない。");
		}
	}
}


public class test2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
			Boss lastboss = new Boss ();
		for(int i = 0;i<15;i++){	
			lastboss.Magic ();
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
