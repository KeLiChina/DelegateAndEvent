using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LambdaDemo : MonoBehaviour {

	private List<string> names = new List<string>();
	void Start () {
		names.Add("李小龙");
		names.Add("李国豪");
		names.Add("马云");
		names.Add("马化腾");
		// ShowList();
		// FindName();
		List<string> temp = names.FindAll((string name) => name.StartsWith("李"));
		// for (int i = 0; i < temp.Count; i++)
		// {
		// 	Debug.Log("Name: " + temp[i] );
		// }
		names.RemoveAll(name => name.StartsWith("李"));
		ShowList();
	}
	private void ShowList()
	{
		for (int i = 0; i < names.Count; i++)
		{
			Debug.Log("Name: " + names[i] );
		}
	}
	private void FindName()
	{
		List<string> temp = new List<string>();
		for (int i = 0; i < names.Count; i++)
		{
			if (names[i].StartsWith("李"))
			{
				temp.Add(names[i]);
			}
		}
		for (int i = 0; i < temp.Count; i++)
		{
			Debug.Log("Li " + temp[i]);
		}
	}

}
