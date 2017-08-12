using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPLabel : MonoBehaviour {

	private Transform m_Transform;
	private UILabel hpLabel;

	void Start () {
		m_Transform = gameObject.GetComponent<Transform>();
		hpLabel = m_Transform.FindChild("Label").GetComponent<UILabel>();
		PlayerController.instance.hpDel += UpdateHP;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	private void UpdateHP(int value)
	{
		hpLabel.text = value.ToString();
	}
}
