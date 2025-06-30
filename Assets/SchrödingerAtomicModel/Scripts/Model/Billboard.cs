using UnityEngine;

public class BillboardFaceCamera : MonoBehaviour
{
    void LateUpdate()
    {
        if (Camera.main == null) return;

        // Direcci�n desde el cartel hasta la c�mara
        Vector3 direction = transform.position - Camera.main.transform.position;

        // Asegura que el eje 'up' se mantenga correctamente
        transform.rotation = Quaternion.LookRotation(direction, Vector3.up);
    }
}
