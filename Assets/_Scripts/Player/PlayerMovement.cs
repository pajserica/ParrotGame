using UnityEngine;

    

public class PlayerMovement : MonoBehaviour 
{

    [SerializeField] private float moveSpeed = 7f; 
    private PlayerInput playerInput;

    void Awake(){
        playerInput = GetComponent<PlayerInput>();
    }
    
    public void Move(){
        Vector2 inputVector = playerInput.GetMovementVectorNormalized();

        Vector3 moveDir = new Vector3(inputVector.x, 0f, inputVector.y);

        float moveDistance = moveSpeed * Time.deltaTime;
        float playerRadius = .5f;
        float playerHeight = 2f;
        bool canMove = !Physics.CapsuleCast(transform.position, transform.position + Vector3.up * playerHeight, playerRadius, moveDir, moveDistance);

        if (canMove)
            transform.position += moveDir * moveSpeed * Time.deltaTime;
        else{

            Vector3 moveDirX = new Vector3(moveDir.x, 0, 0).normalized;
            canMove = !Physics.CapsuleCast(transform.position, transform.position + Vector3.up * playerHeight, playerRadius, moveDirX, moveDistance);

            if (canMove)
                moveDir = moveDirX;
            else{
                Vector3 moveDirZ = new Vector3(0, 0, moveDir.z).normalized;
                canMove = !Physics.CapsuleCast(transform.position, transform.position + Vector3.up * playerHeight, playerRadius, moveDirZ, moveDistance);

                if (canMove)
                    moveDir = moveDirZ;
                else {

                }
            }

        }


        float rotateSpeed = 10f;
        Quaternion targetRotation = Quaternion.Euler(moveDir);

        // Smoothly rotate the object towards the desired direction
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * rotateSpeed);
        
    }
    
}