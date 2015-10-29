using UnityEngine;
using System.Collections;

public class checkpoint : MonoBehaviour {
    private bool passed = false;

    void OnTriggerEnter2D (Collider2D other) {
        passed = true;
        Debug.Log("passed the checkpoint");
    }

    public bool YouPassedTheCheckpoint () {
        bool temp = passed;
        passed = false;
        return temp;
    }
}
