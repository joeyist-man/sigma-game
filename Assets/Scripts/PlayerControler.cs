using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float horizontalinput;
    public float speed = 10.0f;
    public float xRange = 10;

    public GameObject projectilePrefab;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // sigma if statements to make bounderys
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        horizontalinput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * horizontalinput * Time.deltaTime * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
         Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
