using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour {

	// Use this for initialization
	public GameObject login,create;

	void Start () {
		login.transform.localScale = new Vector3(0f,0f,0f);
		create.transform.localScale = new Vector3(0f,0f,0f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void showLogin()
	{
		
		login.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
		Debug.Log ("check login");
	}
	public void showCreateFamily()
	{

		create.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
		Debug.Log ("check create family");
	}
}
