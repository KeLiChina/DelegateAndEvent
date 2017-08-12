using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonTest : MonoBehaviour {

	private Person<string,int> ps = new Person<string,int>();
	private Person<float,string> ps2 = new Person<float,string>();
	void Start () {
		ps.age = 10;
		ps.info = "IamKIKI";
		ps.name = "forestli";
		ps.mes = 5;
		ps2.age = 10;
		ps2.name = "li";
		ps2.info = 5f;
		ps2.mes = "what?";
		ps.ShowPerson();
		ps2.ShowPerson();

		Debug.Log( ps.ShowInfo());
		Debug.Log(ps.ShowName<string>(ps.name));
		
	}
	

}
