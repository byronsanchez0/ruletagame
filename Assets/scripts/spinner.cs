
//using System.Collections;
//using UnityEngine;

//public class DragDetection : MonoBehaviour
//{

//    [SerializeField]
//    private float minimumDistance = .2f;
//    private float maximumTime = 1f;
//    [SerializeField, Range(0f, 1f)]
//    private float directionThreshold = .9f;
//    [SerializeField]
//    private GameObject trail;

//    private InputManager inputManager;

//    private Vector2 startPosition;
//    private float startTime;
//    private Vector2 endPosition;
//    private float endTime;

//    private Coroutine coroutine;

//    private void Awake()
//    {
//        inputManager = InputManager.Instance;
//    }

//    private void OnEnable()
//    {
//        inputManager.OnStartTouch += SwipeStart;
//        inputManager.OnEndTouch += SwipeEnd;


//    }

//    private void OnDisable()
//    {
//        inputManager.OnStartTouch -= SwipeStart;
//        inputManager.OnEndTouch -= SwipeEnd;
//    }

//    private void SwipeStart(Vector2 position)
//    {
//        startPosition = position;
//        trail.SetActive(true);
//        trail.transform.position = position;
//        coroutine = StartCoroutine(Trail());
//    }

//    private IEnumerator Trail()
//    {
//        while (true)
//        {
//            trail.transform.position = inputManager.PrimaryPosition();
//            yield return null;
//        }
//    }


//    private void SwipeEnd(Vector2 position)
//    {
//        Debug.Log("aqui e muere");
//        trail.SetActive(false);
//        StopCoroutine(coroutine);
//        Debug.Log("aqui OTRA VE  muere");
//        endPosition = position;
//        DetectDrag();
//    }



//    private void DetectDrag()
//    {
//        if (Vector3.Distance(startPosition, endPosition) >= minimumDistance)
//        {
//            Debug.DrawLine(startPosition, endPosition, Color.red, 5f);
//            Vector3 direction = endPosition - startPosition;
//            Vector2 direction2D = new Vector2(direction.x, direction.y).normalized;
//            DragDirection(direction2D);
//        }
//    }

//    private void DragDirection(Vector2 direction)
//    {
//        if (Vector2.Dot(Vector2.up, direction) > directionThreshold)
//        {
//            Debug.Log("Swipe Up");
//        }
//        else if (Vector2.Dot(Vector2.down, direction) > directionThreshold)
//        {
//            Debug.Log("Swipe down");
//        }
//        else if (Vector2.Dot(Vector2.left, direction) > directionThreshold)
//        {
//            Debug.Log("Swipe left");
//        }
//        else if (Vector2.Dot(Vector2.right, direction) > directionThreshold)
//        {
//            Debug.Log("Swipe right");
//        }
//    }
//}
