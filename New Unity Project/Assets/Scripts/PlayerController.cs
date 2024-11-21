using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    [SerializeField] Transform playerCamera = null;
    [SerializeField] float mouseSensitivity = 3.5f;

    public float walkSpeed = 300f;

    //[SerializeField] bool lockCursor = true;

    float cameraPitch = 0.0f;

    bool Paused = false;
    public Button pauseButton;

    CharacterController controller = null;

    //движение камеры, он отключен

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        pauseButton.onClick.AddListener(Button_Click);

        // Cursor.lockState = CursorLockMode.Locked;
        // Cursor.visible = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!Paused)
            {
                Pause();
            }
            else
            {
                Resume();
            }
        }
        else if (!Paused)
        {
            Resume();
        }
    }

    void Resume()
    {
        Paused = false;

        //Cursor.lockState = CursorLockMode.Locked;
     //   Cursor.visible = false;

        UpdateMouseLook();
        UpdateMovement();
    }

    void Pause()
    {
        Paused = true;

       // Cursor.lockState = CursorLockMode.None;
        //Cursor.visible = true;
    }

    void Button_Click()
    {
        if (!Paused)
        {
            Pause();
        }
        else
        {
            Resume();
        }
    }

    void UpdateMouseLook()
    {
        if (Input.GetMouseButton(0))
        {
            Vector2 mouseDelta = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));

            cameraPitch -= mouseDelta.y * mouseSensitivity;

            cameraPitch = Mathf.Clamp(cameraPitch, -90.0f, 90.0f);
            playerCamera.localEulerAngles = Vector3.right * cameraPitch;
            transform.Rotate(Vector3.up * mouseDelta.x * mouseSensitivity);
        }
    }

    void UpdateMovement()
    {
        Vector2 inputDir = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        inputDir.Normalize();

        Vector3 velocity = (transform.forward * inputDir.y + transform.right * inputDir.x)*walkSpeed;

        controller.Move(velocity * Time.deltaTime);
    }
}
