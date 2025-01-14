using UnityEngine;

public class InfiniteBackGround : MonoBehaviour
{
    float posZ = 0;

    private void LateUpdate()
    {
        Vector3 pos = Camera.main.transform.position;
        pos.z = posZ;
        transform.position = pos;
    }
}
