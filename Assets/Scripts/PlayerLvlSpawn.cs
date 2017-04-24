using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLvlSpawn : MonoBehaviour {

    void OnLevelWasLoaded(int thisLevel)
    {
        transform.position = GameObject.FindWithTag("SpawnPoint").transform.position;
    }
}
