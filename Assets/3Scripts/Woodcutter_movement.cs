using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Woodcutter_movement : MonoBehaviour
{
    // Start is called before the first frame update
    private CharacterController controller;
    private Animator anim;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    [SerializeField]
    private float playerSpeed = 2.0f;
    public float turnsmooth = 3f;
    float turnSmoothVelocity;
    public GameObject control;
    public GameObject finish;
    private Player playerInput;
    public GameObject tagalogsbukas;
    public GameObject tagalogsarado;
    public AudioSource walking;
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
            walking.enabled = false;
        }



    }
    private void Run()
    {
        walking.enabled = true;
        anim.SetBool("Run", true);
    }
 
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Finish"))
        {
            anim.Play("Digging");
            Destroy(other.gameObject);
            control.gameObject.SetActive(false);
            finish.gameObject.SetActive(true);
            //BUKAS
            tagalogsbukas.gameObject.SetActive(true);
            //SARADO
            tagalogsarado.gameObject.SetActive(false);
        }
    }
}
