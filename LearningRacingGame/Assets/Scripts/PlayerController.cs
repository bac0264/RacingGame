using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Tốc độ của xe

    public float speed;
    public float turnSpeed;
    public float horizontalInput;

    public float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        // Start dùng để khởi tạo trước lúc vào game

        speed = 20;
        turnSpeed = 15;
    }

    // Update is called once per frame
    void Update()
    {
        // Cập nhật run-time trong game.
        
        // Lấy thông số khi nhấn vào nút trái/phải
        horizontalInput = Input.GetAxis("Horizontal");
        
        // Lấy thông số khi nhấn vào nút tiến/lùi
        forwardInput = Input.GetAxis("Vertical");
        
        // Di chuyển xe dựa vào forward input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
       
        // Xoay xe dựa vào horizon input
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}
