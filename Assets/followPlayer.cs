using UnityEngine;
using System.Collections;

public class followPlayer : MonoBehaviour
{
    private GameObject player;

    // Use this for initialization
    void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update () {
        Vector3 pos = gameObject.transform.position;
        pos.x = player.transform.position.x;
        pos.y = player.transform.position.y;
        pos.z = transform.position.z;
        gameObject.transform.position = pos;
    }
}
