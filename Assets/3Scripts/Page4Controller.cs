using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Page4Controller : MonoBehaviour
{
    private CharacterController controller;
    private Animator anim;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    [SerializeField]
    private float playerSpeed = 2.0f;
    public float turnsmooth = 3f;
    float turnSmoothVelocity;
    private int foodcount;
    public GameObject poster;
    public GameObject joystickimage;
    public GameObject smoke;
    public AudioSource eatsound;
    private FourPlayer playerInput;
    public GameObject farmboy;
    Animator otherAnimator;
    public AudioSource chickenwalk;

    public GameObject tagalogsbukas;
    public GameObject tagalogsarado;
    private void Awake()
    {
        playerInput = new FourPlayer();
        otherAnimator = farmboy.GetComponent<Animator>();
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
            anim.SetBool("Eat", false);
        }
        else
        {
            anim.SetBool("Run", false);
            chickenwalk.enabled = false;
        }

        if(foodcount == 8)
        {
            poster.gameObject.SetActive(true);
            anim.SetBool("Run",true);
            playerSpeed = 0f;
            joystickimage.SetActive(false);
            otherAnimator.SetBool("Cheer", true);

            //BUKAS
            tagalogsbukas.gameObject.SetActive(true);
            //SARADO
            tagalogsarado.gameObject.SetActive(false);
        }
    }
    private void Run()
    {
        chickenwalk.enabled = true;
        anim.SetBool("Run", true);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Food"))
        {
            Destroy(other.gameObject);
            GameObject explosion = Instantiate(smoke, transform.position, transform.rotation);
            foodcount++;     
            anim.SetBool("Eat", true);
            eatsound.Play();
        }
    }
}