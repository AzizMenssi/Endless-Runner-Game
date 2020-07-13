
using UnityEngine;

public class GroundScroll : MonoBehaviour
{
    public GameObject ground1, ground2;
    public float speed = 1;

   
    // Update is called once per frame
    void Update()
    {
        ground1.transform.position -= new Vector3(1, 0, 0)*speed*Time.deltaTime;
        ground2.transform.position -= new Vector3(1, 0, 0)*speed*Time.deltaTime;
        if (Camera.main.WorldToViewportPoint(ground1.transform.position).x < 0)
        {
            ground1.transform.position = new Vector3(Camera.main.ViewportToWorldPoint(new Vector3(1, 0)).x+25, ground1.transform.position.y);
        }
        if (Camera.main.WorldToViewportPoint(ground2.transform.position).x < 0)
        {
            ground2.transform.position = new Vector3(Camera.main.ViewportToWorldPoint(new Vector3(1, 0)).x + 25, ground2.transform.position.y);
        }
    }
}
