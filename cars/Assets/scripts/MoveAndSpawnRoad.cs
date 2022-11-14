using UnityEngine;
using UnityEditor;

public class MoveAndSpawnRoad : MonoBehaviour{

    public float speed = 1.5f;
    public GameObject road;

    void Update() {
        transform.Translate(Vector3.down * speed * Time.deltaTime);

        if(transform.position.y < -8f){
            Instantiate(road, new Vector3(0f, 7.61f, 0f), Quaternion.identity);
            Destroy(gameObject);
        }
        
    }
}
