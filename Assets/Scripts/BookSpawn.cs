using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookSpawn : MonoBehaviour {

    public Transform prefab;
    private int maxbooks;
	// Use this for initialization
	void Start () {
        maxbooks = 20;

        for (int i = 0; i <= maxbooks; i++) {
            Instantiate(prefab, new Vector2(i * 2.0F, 0), Quaternion.identity);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
