using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Destroyer : MonoBehaviour
{
    public AudioClip CoinSound;
    public AudioClip CoinCap;
    public AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    
    private void Update()
    {
        if (ScoreTextScript.coinAmount >= 5)
        {
            audioSource.PlayOneShot(CoinCap);
        }       
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Coin")
        {
            GetComponent<AudioSource>().Play();
            audioSource.PlayOneShot(CoinSound);
            ScoreTextScript.coinAmount += 1;     
            Destroy(col.gameObject);
            

        }
        if (col.gameObject.tag == "Door")
        {
            if (ScoreTextScript.coinAmount >= 5)
            {
                SceneManager.LoadScene("Winner");
            }

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            GetComponent<AudioSource>().Play();
            audioSource.PlayOneShot(CoinSound);
            ScoreTextScript.coinAmount += 1;
            Destroy(collision.gameObject);
            

        }
        if(collision.gameObject.tag == "Door")
        {
            if(ScoreTextScript.coinAmount >= 5)
            {
                SceneManager.LoadScene("Winner");
            }

        }
    }
    

}
  

