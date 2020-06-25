using UnityEngine;

public class ClickToMove : MonoBehaviour
{
    public LayerMask clickableLayer;
    public float speed = 4.5f;

	Vector2 targetPosition;

	void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (Physics2D.OverlapPoint(mousePosition, clickableLayer) != null)
            {
                targetPosition = mousePosition;
            }
        }

        if(!TargetReached())
           MoveToTarget();
    }

    bool TargetReached()
    {
        return Vector2.Distance(targetPosition, new Vector2(transform.position.x, transform.position.y)) < 0.01f;
    }

    void MoveToTarget()
    {
        Vector2 movementDirection = targetPosition - new Vector2(transform.position.x, transform.position.y);

        transform.Translate(movementDirection * Time.deltaTime * speed);
    }
}
