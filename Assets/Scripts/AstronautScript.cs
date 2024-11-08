using UnityEngine;

public class AstronautScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;
    public bool isAstronautAlive = true;

    public float astronautDeadZone;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && isAstronautAlive)
        {
            myRigidbody.linearVelocity = Vector2.up * flapStrength;
        }
        if (transform.position.y > astronautDeadZone || transform.position.y < -astronautDeadZone)
        {
            logic.gameOver();
            isAstronautAlive = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        isAstronautAlive = false;
    }
}
