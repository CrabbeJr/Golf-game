using UnityEngine;

public class golfBall_behaviour : MonoBehaviour
{

    private Rigidbody2D rb;

    /*these three vectors are used to track where the player is aiming.*/
    private Vector2 initAim, finalAim, realAim;
    


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    private void OnMouseDown()
    {
            initAim = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            Debug.Log(initAim);
    }

    private void OnMouseUp()
    {
        finalAim = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        realAim = initAim - finalAim;
        Debug.Log(finalAim);
        Debug.Log(realAim);
        rb.AddForce(realAim);
    }
}
