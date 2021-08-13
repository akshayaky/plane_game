using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public PlayerController playerControl;
    playerMovement m_playerMovement;
    shooting m_shooting;
    void Awake()
    {
        m_playerMovement= gameObject.GetComponent<playerMovement>();
        m_shooting = gameObject.GetComponent<shooting>();

        playerControl = new PlayerController();
        playerControl.fly.Move.performed  += ctx => PlayerMove(ctx.ReadValue<float>());
        playerControl.fly.Move.canceled   += ctx => PlayerMove(ctx.ReadValue<float>());

        playerControl.fly.Change_ammo.performed  += 
                                        ctx => 
                                        {
                                           m_shooting.changeAmmo = true;
                                        };
        playerControl.fly.Shoot.performed += 
                                        ctx => 
                                        {
                                           m_shooting.shoot = true;
                                        };
        playerControl.fly.Shoot.canceled  += 
                                        ctx => 
                                        {
                                            m_shooting.shoot = false;
                                        };
    }

    private void OnEnable()
    {
        playerControl.fly.Enable();
    }

    private void OnDisable()
    {
        playerControl.fly.Disable();
    }


    void PlayerMove(float inputTilt)
    {
        m_playerMovement.tilt = inputTilt;
    }

    void Shoot(bool inputShoot)
    {
        Debug.Log(inputShoot);
        m_shooting.shoot = inputShoot;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
