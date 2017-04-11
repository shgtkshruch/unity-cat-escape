using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour {

	GameObject hpGage;

	// Use this for initialization
	void Start () {
		this.hpGage = GameObject.Find ("hpGage");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void DecreseHp () {
		this.hpGage.GetComponent <Image> ().fillAmount -= 0.1f;
	}
}
