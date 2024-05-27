using UnityEngine;
using Photon.Pun;
public class CubeMovement : MonoBehaviourPunCallbacks
{
    public float speed = 5.0f;

    // Update is called once per frame
    void Update()
    {
        // Get input from arrow keys
         if (photonView.IsMine){
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Create a movement vector
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        // Apply the movement to the cube
        transform.Translate(movement * speed * Time.deltaTime, Space.World);
    }
    }
}

