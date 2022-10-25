using System.Collections.Generic;
using Cube.Movement;
using Unity.VisualScripting;
using UnityEngine;

namespace Cube.Hinge
{
    public class CubeHingeJoint : MonoBehaviour
    {
        [SerializeField] private List<CubeItem> cubes = new List<CubeItem>();
        [SerializeField] private CubeItem cubePrefab;
        
        private void Start()
        {
            CreateCube();
        }

        private void CreateCube()
        {
            var yAxis = 1.1f;

            for (var i = 0; i < 6; i++)
            {
                var cube = Instantiate(cubePrefab, transform);
                cube.name = "Cube " + (i + 1);
                cubes.Add(cube);
                cube.transform.localPosition = new Vector3(0.0f, yAxis, 0.0f);
                yAxis += 1.1f;
            }

            for (var i = 0; i < cubes.Count; i++)
            {
                if (i + 1 < cubes.Count)
                    cubes[i].GetComponent<HingeJoint>().connectedBody = cubes[i + 1].GetComponent<Rigidbody>();

                if (i == 0)
                {
                    cubes[i].GetComponent<Rigidbody>().isKinematic = true;
                    cubes[i].AddComponent<CubeMove>();
                }
            }
            
            Destroy(cubes[^1].GetComponent<HingeJoint>());
        }
    }
}
