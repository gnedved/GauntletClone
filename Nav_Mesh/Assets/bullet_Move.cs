using UnityEngine;
using System.Collections;

public class bullet_Move : MonoBehaviour {
    public float speed = 15.0f;
	// Use this for initialization
	void Awake () {
        

	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        
	}
    void OnCollisionEnter(Collision col)
    {
        if ((col.gameObject.tag != "enemy") || (col.gameObject.tag != "Spawner"))
            Debug.Log("Destroy");
        Destroy(this.gameObject);
    }
}