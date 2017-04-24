using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleport : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player") {
            DontDestroyOnLoad(coll.gameObject);
            SceneManager.LoadScene("Lvl2");
        }
    }
}
