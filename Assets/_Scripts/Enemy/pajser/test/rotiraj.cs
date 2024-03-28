using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class rotiraj : MonoBehaviour {

    private bool movingForward = true;  // Flag to indicate the direction of movement

    public Transform sP;
    public Transform eP;
    public Vector3 startPoint;      // Starting point of the ellipsoid
    public Vector3 endPoint;        // Ending point of the ellipsoid
    public float speed = 1.0f;      // Speed of movement
    public float rotationSpeed = 50.0f;  // Speed of rotation

    private Vector3 centerPoint;    // Center point of the ellipsoid
    private Vector3 semiAxes;       // Semi-axes of the ellipsoid
    private float elapsedTime;      // Time elapsed since the movement started

    void Start()
    {
        startPoint = sP.position;
        endPoint = eP.position;
        // Calculate center point and semi-axes of the ellipsoid
        centerPoint = (startPoint + endPoint) * 0.5f;
        semiAxes = (endPoint - startPoint) * 0.5f;
    }

    void Update()
    {
        startPoint = sP.position;
        endPoint = eP.position;
        // Calculate center point and semi-axes of the ellipsoid
        centerPoint = (startPoint + endPoint) * 0.5f;
        semiAxes = (endPoint - startPoint) * 0.5f;
        // Calculate time elapsed since the movement started
        elapsedTime += Time.deltaTime;

        // Calculate position along the ellipsoid path
        Vector3 newPosition = CalculateEllipsoidPosition(centerPoint, semiAxes, elapsedTime);

        // Update the position of the object
        transform.position = newPosition;

        // Rotate the object
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);

        // Check if the object reaches the end point or the start point
        if (elapsedTime >= speed || elapsedTime <= 0)
        {
            // Reverse the direction of movement
            movingForward = !movingForward;
            elapsedTime = movingForward ? 0 : speed;
        }
    }

    // Function to calculate position along the ellipsoid
    private Vector3 CalculateEllipsoidPosition(Vector3 center, Vector3 semiAxes, float time)
    {
        // Calculate angle based on time and speed
        float angle = time / speed * Mathf.PI * 2;

        // Calculate position along the ellipsoid path
        float x = center.x + semiAxes.x * Mathf.Cos(angle);
        float y = center.y + semiAxes.y * Mathf.Sin(angle);
        float z = center.z + semiAxes.z * Mathf.Sin(angle);

        return new Vector3(x, y, z);
    }
}
