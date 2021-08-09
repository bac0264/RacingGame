using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Tốc độ của xe

    private float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        // Start dùng để khởi tạo trước lúc vào game

        speed = 20;
    }

    // Update is called once per frame
    void Update()
    {
        // Cập nhật run-time trong game.

        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
