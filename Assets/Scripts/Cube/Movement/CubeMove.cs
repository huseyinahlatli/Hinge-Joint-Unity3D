using UnityEngine;

namespace Cube.Movement
{
    public class CubeMove : MonoBehaviour, ICube
    {
        [SerializeField] private float moveSpeed = 3.0f;
        public float Horizontal { get; set; }
        public float Vertical { get; set; }
        public float Speed { get; set; }

        void Update() => Movement();

        public void Movement()
        {
            Horizontal = Input.GetAxisRaw("Horizontal");
            Vertical = Input.GetAxisRaw("Vertical");
            Speed = moveSpeed * Time.deltaTime;

            transform.Translate
            (
                new Vector3(Horizontal, 0, Vertical) * Speed, 
                Space.World
            );
        }
    }
}

