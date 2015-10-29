using UnityEngine;
using System.Collections;

public class FinishLine : MonoBehaviour
{
    private GameObject checkpoint;
    private int lapNumber = 1;

    // Use this for initialization
    void Start () {
        checkpoint = GameObject.FindGameObjectWithTag("Checkpoint");
    }

    // Update is called once per frame
    void Update () {

    }

    void OnTriggerEnter2D (Collider2D other) {

        if (checkpoint.GetComponent<checkpoint>().YouPassedTheCheckpoint()) {
            lapNumber++;
        }
    }

    void OnGUI () {
        GUI.Label(new Rect(15, 15, 200, 200), lapNumber.ToString());
    }
}
