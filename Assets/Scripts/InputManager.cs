using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.InputSystem.OnScreen;
public class InputManager : MonoBehaviour
{
    public PlayerController playerControl;
    public OnScreenButton OnSButton;
    playerMovement m_playerMovement;
    shooting m_shooting;
    void Awake()
    {
        float move_touch = 0.0f;
        m_playerMovement= gameObject.GetComponent<playerMovement>();
        m_shooting = gameObject.GetComponent<shooting>();

        playerControl = new PlayerController();
        OnSButton = new OnScreenButton();
        // OnSButton.OnPointerUp.performed += ctx => Debug.Log("Pressed");
        playerControl.fly.Move.performed  += ctx => PlayerMove(ctx.ReadValue<float>());
        playerControl.fly.Move.canceled   += ctx => PlayerMove(ctx.ReadValue<float>());

        // playerControl.fly.Move_touch.performed   += ctx => {
        //                                                 // PlayerMove(ctx.ReadValue<Vector2>().x);
        //                                                 move_touch = 2;
        //                                                 if(ctx.ReadValue<float>() < Screen.width/2)
        //                                                 {
        //                                                     PlayerMove(- move_touch);
        //                                                 }
        //                                                 else
        //                                                 {
        //                                                     PlayerMove(move_touch);
        //                                                 }
        //                                                 // move_touch -= Time.deltaTime;
        //                                                 Debug.Log("pressed");
        //                                             } ; 
        // playerControl.fly.Move_touch_end.canceled   += ctx => {
        //                                                 // PlayerMove(ctx.ReadValue<Vector2>().x);
                                                        
        //                                                 PlayerMove(0.0f);
        //                                                 Debug.Log("cancelled");
        //                                             } ; 


        playerControl.fly.Change_ammo.performed  += ctx => m_shooting.changeAmmo = true;
        // playerControl.fly.Change_ammo_touch.performed  += ctx => m_shooting.changeAmmo = true;
        
        playerControl.fly.Shoot.performed += ctx => m_shooting.shoot = true;
        playerControl.fly.Shoot.canceled  += ctx => m_shooting.shoot = false;

        playerControl.fly.speed_boost.performed += ctx => m_playerMovement.speedBoost = true;
        playerControl.fly.speed_boost.canceled  += ctx => m_playerMovement.speedBoost = false;
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
        m_shooting.shoot = inputShoot;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
