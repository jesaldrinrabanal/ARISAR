using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController controller;
    private Animator anim;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    [SerializeField]
    private float playerSpeed = 2.0f;
    public float turnsmooth = 3f;
    public AudioSource walk;
    float turnSmoothVelocity;

    private Player playerInput;
    private void Awake()
    {
        playerInput = new Player();
        
    }

    private void OnEnable()
    {
        playerInput.Enable();
    }
    private void OnDisable()
    {
        playerInput.Disable();
    }
    

    private void Start()
    {
        controller = GetComponent<CharacterController>();
        anim = GetComponentInChildren<Animator>();
    }

    void Update()
    {
      
      
        Vector2 movementInput = playerInput.PlayerMain.Move.ReadValue<Vector2>();
        Vector3 move = new Vector3(movementInput.x, 0f, movementInput.y).normalized;



        if (move.magnitude >= 0.1f)
        {
            Run();
            float targetAngle = Mathf.Atan2(move.x, move.z) * Mathf.Rad2Deg;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnsmooth);
            transform.rotation = Quaternion.Euler(0f, targetAngle, 0f);
            controller.Move(move * playerSpeed * Time.deltaTime);
        }
        else
        {
            anim.SetBool("Run", false);
            walk.enabled = false;
        }



    }
    private void Run()
    {
        walk.enabled = true;
        anim.SetBool("Run", true);
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("OBJECT DETECTED");
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Finish"))
        {
            Destroy(other.gameObject);
            
        }
    }
}
