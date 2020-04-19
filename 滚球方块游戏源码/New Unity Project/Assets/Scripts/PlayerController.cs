using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rigidbodyPlayer;
    public float speed;
	private int count;
	public Text countText;
	public Text winText;
	public AudioSource audio;

    void Start()
    {
		winText.text = "";
        rigidbodyPlayer = GetComponent<Rigidbody>();
		count = 0;
		countText.text = "Score : " + count.ToString();
		audio = GetComponent<AudioSource> ();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal,0.0f,moveVertical);

        rigidbodyPlayer.AddForce(movement*speed);
		if(this.transform.localPosition.y<0){
			Application.LoadLevel (0);
		}
		
		 if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Home))
        {
            Application.Quit();
        }  
    }
	
	
	void OnTriggerEnter(Collider other)
{
    if (other.gameObject.CompareTag("PickUp"))
    {
        other.gameObject.SetActive(false);
		count++;
        			audio.mute = false;
			audio.Play ();
		countText.text = "Score : " + count.ToString();
    }


	if (count >= 8)
{
    winText.text = "You Win!";
}
}
}




