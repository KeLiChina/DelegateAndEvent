using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XMLManager  {
	public string name = "like";
	private static XMLManager instance;
	private XMLManager(){}
	public static XMLManager Instance
	{
		get
		{
			if ( instance == null)
			{
				instance = new XMLManager();
			}
			return instance;
		}
	}
}
