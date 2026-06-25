using Unity.Netcode;
using UnityEngine;

public class PlayerController : NetworkBehaviour
{
    [SerializeField]
    private MyPlayerInput m_PlayerInput;
    
    
    
    [SerializeField]
    
    private AgentMover m_AgentMover;



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
