using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Master.instance.eatDel +=DogEat;
	}
	
	private void DogEat()
	{
		Debug.Log("Master Allow Dog Eat,Dog Crow WangWangWang And Run");
	}
}
