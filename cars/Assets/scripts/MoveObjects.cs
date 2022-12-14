using UnityEngine;

public class MoveObjects : MonoBehaviour {

    public float speed = 1.5f;
   
    void FixedUpdate() {
        transform.Translate(Vector3.forward * speed *  Time.deltaTime);

        if(transform.position.y < -6)
            Destroy(gameObject);            
    }
}
