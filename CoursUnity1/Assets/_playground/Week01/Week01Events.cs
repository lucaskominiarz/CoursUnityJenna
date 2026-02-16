using UnityEngine;
using UnityEngine.Events;

namespace _playground.Week01
{
    public class Week01Events : MonoBehaviour
    {
        [SerializeField] private UnityEvent manageCubes;

        private void Start()
        {
            manageCubes.AddListener(SomethingToDo);
            manageCubes.Invoke();
        }

        private void SomethingToDo()
        {
            Debug.Log("Here");
        }
    }
}