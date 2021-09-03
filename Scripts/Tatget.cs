using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tatget : MonoBehaviour
{

    public GameManger gameManger;
    // Start is called before the first frame update
    void Start()
    {
       
        gameManger = GameObject.Find("GameManager").GetComponent<GameManger>();
        Destroy(gameObject, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        gameManger.IncrementScore();
       
        Destroy(gameObject);
    }
}
