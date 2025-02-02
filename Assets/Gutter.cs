using UnityEngine;

public class Gutter : MonoBehaviour
{
    private void OnTriggerEnter(Collider triggeredBody)
    {
        if (triggeredBody.CompareTag("Balll"))
        {
            // get the rigid body of the ball
            Rigidbody ballRigidBody = triggeredBody.GetComponent<Rigidbody>();

            // store the velocity magnitude before resettting the velocity
            float velocityMagnitude = ballRigidBody.linearVelocity.magnitude;

            //reset both linear & angular velocity of the ball
            ballRigidBody.linearVelocity = Vector3.zero;
            ballRigidBody.angularVelocity = Vector3.zero;

            // Adding force in the forward direction of the gutter
            ballRigidBody.AddForce(transform.forward * velocityMagnitude, ForceMode.VelocityChange);
        }
    }
}
