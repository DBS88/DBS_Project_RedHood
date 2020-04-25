using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTrigger : MonoBehaviour {


    private BoxCollider2D playerCollider;

    [SerializeField]
    private BoxCollider2D platformCollider;

    [SerializeField]
    private BoxCollider2D platformTrigger;

	// Use this for initialization
	void Start ()
    {
        // This is for the player to walk through a platform instead of beings stopped by the collider. One collider for the trigger and one for the collision.
        playerCollider = GameObject.Find("CharacterRH").GetComponent<BoxCollider2D>();
        Physics2D.IgnoreCollision(platformCollider, platformTrigger, true);
	}
	
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "CharacterRH")
        {
		    Physics2D.IgnoreCollision(platformCollider, playerCollider, true);
	    }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name == "CharacterRH")
        {
            Physics2D.IgnoreCollision(platformCollider, playerCollider, false);
        }
    }
}
