using UnityEngine;
using System.Collections;

public class FollowTouch : MonoBehaviour {

   

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Stationary || touch.phase == TouchPhase.Moved)
            {
                Vector3 touchPosition = Camera.main.ScreenToWorldPoint(new Vector2(touch.position.x, touch.position.y));
                transform.rotation = Quaternion.LookRotation(Vector3.forward, touchPosition - transform.position);

                //transform.position = Vector2.Lerp(transform.position, touchPosition, Time.deltaTime);
                GetComponent<Rigidbody2D>().MovePosition(Vector2.Lerp(transform.position, touchPosition, Time.deltaTime));
            }
            
        }

        
	}
    

}
