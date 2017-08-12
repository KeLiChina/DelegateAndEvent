using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Master.instance.eatDel +=CatEat;
	}
	
	private void CatEat()
	{
		Debug.Log("Master Allow Cat Eat,Cat Crow MiaoMiaoMiao And Run");
	}
}
