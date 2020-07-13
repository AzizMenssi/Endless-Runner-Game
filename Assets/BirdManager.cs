
using UnityEngine;
using System.Collections.Generic;

public class BirdManager : MonoBehaviour
{
    public List<Transform> cactus;
    public float speed = 0.5f;
    public float yOffset = 0.25f;
   
    // Update is called once per frame
    void Update()
    {
        transform.position -= Vector3.right * speed * Time.deltaTime;
        foreach (Transform T in cactus) {
            if (Camera.main.WorldToViewportPoint(T.position).x < 0)
            {
                T.position = Camera.main.ViewportToWorldPoint(new Vector3(1, 0)) + Vector3.right * Random.Range(2, 6) + Vector3.up * yOffset + Vector3.forward * 10 + Vector3.up* Random.Range(-1, 16);
            }
        }
    }
}
