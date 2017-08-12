using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MPLabel : MonoBehaviour {

	private Transform m_Transform;
	private UILabel mpLabel;

	void Start () {
		m_Transform = gameObject.GetComponent<Transform>();
		mpLabel = m_Transform.FindChild("Label").GetComponent<UILabel>();
		PlayerController.instance.mpDel +=UpdateMP;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	private void UpdateMP(float value)
	{
		mpLabel.text = value.ToString();
	}
}
