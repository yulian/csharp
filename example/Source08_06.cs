using UnityEngine;

public class CharacterMove: MonoBehaviour {
  public float speed = 10.0 F;
  public float jumpSpeed = 8.0 F;
  public float gravity = 20.0 F;
  private Vector3 moveDirection = Vector3.zero;
  
  void Update() {
    CharacterController controller = GetComponent < CharacterController > ();
    
    if (controller.isGrounded) {
      float x = Input.GetAxis("Horizontal");
      float z = Input.GetAxis("Vertical");
      moveDirection = new Vector3(x, 0, z);
      moveDirection = transform.TransformDirection(moveDirection);
      moveDirection *= speed;
      
      if (Input.GetButton("Jump"))
        moveDirection.y = jumpSpeed;
    }
    
    moveDirection.y -= gravity * Time.deltaTime;
    controller.Move(moveDirection * Time.deltaTime);
  }
}
