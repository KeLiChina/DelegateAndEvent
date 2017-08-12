using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log(MapManager.instance.count);
		MapManager.instance.count = 100;
		Debug.Log(MapManager.instance.count);
		Debug.Log(XMLManager.Instance.name + ">>>XML") ;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
