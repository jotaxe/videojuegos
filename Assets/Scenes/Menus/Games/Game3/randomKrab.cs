using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomKrab2 : MonoBehaviour
{
    public GameObject krabsState;
    public float[] positionX;
    public float[] positionY;

    private Rigidbody2D rb;
    private Animator anim = null;
    public Vector3 center;

    // Game Rules 

    public int hitTimes = 0;
    public float timeToFinish = 30f;

    public float elapsedTime = 0f;
    public float duration = 2f; // repeticiones del gameobject 

    // Use this for initialization

    //positionX= [ -11.42, -3.78, 3.66, 11.3 ]; 
    //positionY= [ 2.52, , 0.44, -1.64, -3.67 ]; 
    //void Start()
    //{
    //    Vector3 respawnPos = center + new Vector2

    //}

	private void OnTriggerEnter(Collider hit)
	{
        if(hit.gameObject.CompareTag("respawnZone")){
            
        }
	}
}
