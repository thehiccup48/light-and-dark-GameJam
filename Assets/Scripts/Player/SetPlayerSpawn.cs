using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPlayerSpawn : MonoBehaviour
{
    GameObject player;
    int playerSpawnRef;
    [SerializeField] private GameObject[] playerSpawns;
    Rigidbody2D _rb;
    void Start()
    {
        player = GameObject.Find("Player");
        _rb = player.GetComponent<Rigidbody2D>();
        _rb.bodyType = RigidbodyType2D.Dynamic;
        playerSpawnRef = player.GetComponent<PlayerLife>().PlayerSpawnRef();
        player.transform.position = playerSpawns[playerSpawnRef].transform.position;
    }
}
