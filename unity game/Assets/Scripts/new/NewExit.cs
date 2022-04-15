using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewExit : MonoBehaviour
{
    public string sceneToLoad;
    public string exitName;
    
    float fadeSpeed = 0.5f;
    bool shouldIBlackOut = false;

    GameObject blackOut;
    Color blackOutColor;
    private void Start()
    {
        blackOut = GameObject.Find("black out");
        blackOutColor = blackOut.GetComponent<SpriteRenderer>().color;
    }

    private void Update()
    {
        if (shouldIBlackOut)
        {
            BlackOut();
        }
        if (blackOutColor.a > 1)
        {
            PlayerPrefs.SetString("LastExitName", exitName);
            SceneManager.LoadScene(sceneToLoad);
        }
    }

    void BlackOut()
    {
        blackOutColor.a += fadeSpeed * Time.deltaTime;
        blackOut.GetComponent<SpriteRenderer>().color = blackOutColor;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            shouldIBlackOut = true;
            GameObject.Find("Player").GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
        }
    }
}
