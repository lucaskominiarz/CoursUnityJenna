using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

namespace _playground.Week01
{
    public class CubeBehavior : MonoBehaviour
    {
        public GameObject cube;

        [SerializeField] private GameObject cube1;

        private GameObject _cube2;
        private InputSystem_Actions _inputSystem;

        private void Awake()
        {
            _inputSystem = new InputSystem_Actions();
            _inputSystem.Player.Enable();
            _inputSystem.Player.Jump.performed += Jumping;
            _inputSystem.Player.Jump.canceled += (InputAction.CallbackContext ctx) => StopAllCoroutines();
        }

        private void Start()
        {
            Debug.Log("start");
            _cube2 = gameObject;
            //StartCoroutine(MyCubeCoroutine());
        }

        private void Update()
        {
            /*
             Vector3 cubePosition = cube1.transform.position;
            cubePosition.y += 1f * Time.deltaTime;
            cube1.transform.position = cubePosition;
            */
        }

        private IEnumerator MyCubeCoroutine()
        {
            Vector3 cubePosition = cube1.transform.position;
            while (true)
            {
                cubePosition.y += 1f * Time.deltaTime;
                cube1.transform.position = cubePosition;
                yield return null;
            }
        }

        private void Jumping(InputAction.CallbackContext ctx)
        {
            StartCoroutine(MyCubeCoroutine());
        }
    }
}