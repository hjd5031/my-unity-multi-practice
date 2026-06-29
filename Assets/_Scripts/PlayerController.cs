using Unity.Netcode;
using UnityEngine;

public class PlayerController : NetworkBehaviour
{
    [SerializeField]
    private MyPlayerInput m_PlayerInput;
    
    
    
    [SerializeField]
    
    private AgentMover m_AgentMover;

    [SerializeField]
    private InteractionDetector m_InteractionDetector;

    public override void OnNetworkSpawn()
    {
        base.OnNetworkSpawn();
        m_InteractionDetector.Initialize(IsOwner);
    }

    private void Update()
    {
        if (IsOwner == false)
        {
            return;
        }
        Vector2 movementInput = m_PlayerInput.MovementInput;
        m_AgentMover.Move(movementInput);
    }
}
