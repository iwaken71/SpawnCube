using UnityEngine;
using System.Collections;

public class GameScript : MonoBehaviour {

	public Vector3 pos = Vector3.zero;
	public GameObject cube;

	public int x = 0, z = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Spawn(){
		Instantiate (cube, pos, Quaternion.identity);
	}

	public void Spawnx(){
		GameObject obj = new GameObject ("1");
		for(int i = 0 ;i < z; i++){
			for(int j = 0; j < x; j++){
				
				GameObject obj2 =  Instantiate(cube,pos + new Vector3(j,0,i),Quaternion.identity) as GameObject;
				obj2.transform.parent = obj.transform;

			}

		}

	}
}
