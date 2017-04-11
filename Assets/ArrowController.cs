using UnityEngine;
using System.Collections;

public class ArrowController : MonoBehaviour {

	GameObject player;

	// Use this for initialization
	void Start () {
		this.player = GameObject.Find("player");
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (0, -0.1f, 0);

		if (transform.position.y < -5.0f) {
			Destroy (gameObject);
		}

		Vector2 p1 = transform.position; // 矢の中心座標
		Vector2 p2 = this.player.transform.position; // プイレイヤーの中心座標
		Vector2 dir = p1 - p2;
		float d = dir.magnitude;
		float r1 = 0.5f; // 矢の半径
		float r2 = 1.0f; // プレイヤーの半径

		if (d < r1 + r2) {
			Destroy (gameObject);

			GameObject director = GameObject.Find("GameDirector");
			director.GetComponent<GameDirector> ().DecreseHp();
		}
	}
}
