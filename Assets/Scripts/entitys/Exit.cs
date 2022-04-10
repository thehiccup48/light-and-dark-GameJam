using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    public string wereDoIGo;
    public int playerSpawn;
    public string WereDoIGo()
    {
        return wereDoIGo;
    }
    
    public int PlayerSpawn()
    {
        return playerSpawn;
    }
}
