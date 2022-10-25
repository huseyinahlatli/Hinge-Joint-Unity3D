using UnityEngine;

namespace Cube.Hinge
{
    public class CubeItem : MonoBehaviour
    {
        private Rigidbody Rigidbody { get; set; }

        private HingeJoint HingeJoint { get; set; }

        private void Start()
        {
            InitComponents();
        }

        private void InitComponents()
        {
            Rigidbody = GetComponent<Rigidbody>();
            HingeJoint = GetComponent<HingeJoint>();
        }
    }
}