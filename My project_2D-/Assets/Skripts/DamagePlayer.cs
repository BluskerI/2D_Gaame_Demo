using UnityEngine;

public class DamagePlayer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D otherCollider)
    {

        if (otherCollider.GetComponent<PlayerMovement>() != null)
        {
            otherCollider.gameObject.GetComponent<HeartsSystem>().DamagePlayer();
        }

        var transformPosition = otherCollider.GetComponent<PlayerMovement>().getPozition();
        otherCollider.transform.position = transformPosition.position;
    }
}
