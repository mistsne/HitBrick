using UnityEngine;

public class FireBullet : MonoBehaviour {

    public GameObject bullet;
    public float speed = 25f;

	// Use this for initialization
	void Start () {
        Debug.Log("Game Start");
	}
	
	// Update is called once per frame
	void Update () {
		
        if (Input.GetMouseButton(0)) {
            GameObject b = GameObject.Instantiate(bullet, transform.position, transform.rotation);
            Rigidbody rgd = b.GetComponent<Rigidbody>();
            rgd.velocity = transform.forward * speed;
        }
	}
}
