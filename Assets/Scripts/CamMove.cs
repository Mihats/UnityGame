
using UnityEngine;

public class CamMove : MonoBehaviour
{
    public GameObject hero;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(0, hero.transform.position.y, -10f);
    }
}
