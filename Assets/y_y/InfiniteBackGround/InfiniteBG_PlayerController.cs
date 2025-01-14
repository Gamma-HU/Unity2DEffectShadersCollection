using UnityEngine;

public class InfiniteBG_PlayerController : MonoBehaviour
{
    public float speed = 1f;
    private Vector3 pos;

    // Update is called once per frame
    void Update()
    {
        pos = transform.position;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            pos = pos + Vector3.up * speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            pos = pos + Vector3.down * speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            pos = pos + Vector3.right * speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            pos = pos + Vector3.left * speed * Time.deltaTime;
        }

        this.transform.position = pos;
    }
}
