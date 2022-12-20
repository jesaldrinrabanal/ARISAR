using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OldManControl : MonoBehaviour
{
    private CharacterController controller;
    private Animator anim;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    [SerializeField]
    private float playerSpeed = 2.0f;
    public float turnsmooth = 3f;
    float turnSmoothVelocity;
    public GameObject carrychest;
    public GameObject carrychest2;
    public GameObject FINISH;
    public GameObject control;
    public GameObject chest;
    public GameObject tagalogsbukas;
    public GameObject tagalogsarado;
    public bool holding = false;
    
    public AudioSource walking;
    
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



        if (move.magnitude >= 0.1f && holding ==false)
        {
            Walk();
            float targetAngle = Mathf.Atan2(move.x, move.z) * Mathf.Rad2Deg;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnsmooth);
            transform.rotation = Quaternion.Euler(0f, targetAngle, 0f);
            controller.Move(move * playerSpeed * Time.deltaTime);
        }
        else if (move.magnitude >= 0.1f && holding == true)
        {
            Carry();
            float targetAngle = Mathf.Atan2(move.x, move.z) * Mathf.Rad2Deg;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnsmooth);
            transform.rotation = Quaternion.Euler(0f, targetAngle, 0f);
            controller.Move(move * playerSpeed * Time.deltaTime);
        }
        else if (move.magnitude <= 0.1f && holding == true)
        {
            IdleC();
        }
        else if (move.magnitude <= 0.1f && holding == false)
        {
            walking.enabled = false;
            anim.SetBool("Walk", false);
        }
       





    }


    private void IdleC()
    {
        walking.enabled = false;
        anim.SetBool("Carry", false);
    }
    private void Carry()
    {
        walking.enabled = true;
        anim.SetBool("Carry", true);
    }
    private void Walk()
    {
        walking.enabled = true;
        anim.SetBool("Walk", true);
    }
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Finish"))
        {

            Destroy(other.gameObject);
            holding = true;
            Debug.Log("Holding true");
            carrychest.gameObject.SetActive(true);
            carrychest2.gameObject.SetActive(true);

        }
        else if (other.gameObject.tag.Equals("Finish2"))
        {
            carrychest.gameObject.SetActive(false);
            control.gameObject.SetActive(false);
            holding = false;
            FINISH.gameObject.SetActive(true);
            chest.gameObject.SetActive(true);
            //BUKAS
            tagalogsbukas.gameObject.SetActive(true);
            //SARADO
            tagalogsarado.gameObject.SetActive(false);
        }
    }
}

