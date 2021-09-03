using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManger : MonoBehaviour
{
    public Button restbutton;
    new AudioSource audio;
    public GameObject target;
    private float maxXpos = 8f;
    private float maxYpos = 4f;
    public Text scoreText;
    int score = 0;

    bool win = false;
    public GameObject winText;
    // Start is called before the first frame update
    void Start()
    {
        // restbutton = GetComponent<Button>();
        Debug.Log("заое");
        InvokeRepeating(nameof(Spawn), 1f, 2f);
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (win)
        {
            CancelInvoke(nameof(Spawn));
           
        }
    }
    void Spawn()
    {
        
        float randomX = Random.Range(-maxXpos, maxYpos);
        float randomY = Random.Range(-maxYpos, maxYpos);
        Vector3 randomPos = new Vector3(randomX, randomY, 0);
      Instantiate(target, randomPos, Quaternion.identity);
    }

   public void IncrementScore()
    {
        // GetComponent<AudioSource>().Play();
        audio.Play();
        score++;
        scoreText.text = score.ToString();

        if (score >= 10)
        {
            win = true;
            winText.SetActive(true);
           restbutton.gameObject.SetActive(true);
        }
    }

    public void RestarGame()
    {
        SceneManager.LoadScene("Game");
    }
}
