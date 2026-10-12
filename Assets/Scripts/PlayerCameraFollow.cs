using UnityEngine;

public class PlayerCameraFollow : MonoBehaviour
{
	[SerializeField] private Transform player;
	[SerializeField] private Vector3 offset;

	private void LateUpdate()
	{
		if (player != null)
		{
			transform.position = player.position + offset;
		}
	}
}
