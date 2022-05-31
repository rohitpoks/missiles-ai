using UnityEngine;

public class CollisionGameObjectExample : MonoBehaviour
{
    //Detect collisions between the GameObjects with Colliders attached
    void OnCollisionEnter2D(Collision2D collision)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.name == "Missile(Clone)")
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            collision.gameObject.SetActive(false);
            
            //return true;
        }

        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        /*if (collision.gameObject.tag == "Respawn")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            Debug.Log("Collision");
            //return true;
        }*/

        //return false;
    }
    
    /*private void OnEnable()
    {
        Invoke("Destroy", 10f);    //destroy after 10s
        rb=GetComponent<Rigidbody>();
        rb.useGravity=false;
        SpawnMissile();
    }*/
    
	/*private void Destroy(GameObject x )
    {
        x.SetActive(false);	
    }*/
    
}