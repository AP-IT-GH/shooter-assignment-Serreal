using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnHit : MonoBehaviour
{
    public AudioClip audio;
    public GameObject particles;
    public GameObject _canvas;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            Instantiate(particles, transform.position, transform.rotation);
            if (audio)
            {
                if (gameObject.GetComponent<AudioSource>())
                {
                    gameObject.GetComponent<AudioSource>().PlayOneShot(audio);
                } else
                {
                    AudioSource.PlayClipAtPoint(audio, transform.position);
                }
            }
            Destroy(gameObject);
            string[] text = _canvas.GetComponent<Text>().text.Split(' ');
            int coins = int.Parse(text[1]) + 1;
            string newText = text[0] + " " + coins.ToString();
            _canvas.GetComponent<Text>().text = newText;
        }
    }
}
