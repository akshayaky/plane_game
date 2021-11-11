using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using  UnityEngine.InputSystem.OnScreen;
using UnityEngine.InputSystem.EnhancedTouch;
// using Input = UnityEngine.InputSystem;
// using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;
public class InputManager : UnityEngine.MonoBehaviour
{
    public PlayerController playerControl;
    // public OnScreenButton OnSButton;
    playerMovement m_playerMovement;
    shooting m_shooting;
    void Awake()
    {
        // EnhancedTouchSupport.Enable();
        float move_touch = 0.0f;
        m_playerMovement= gameObject.GetComponent<playerMovement>();
        m_shooting = gameObject.GetComponent<shooting>();

        playerControl = new PlayerController();
        // OnSButton = new OnScreenButton();
        // OnSButton.OnPointerUp.performed += ctx => Debug.Log("Pressed");
        playerControl.fly.Move.performed  += ctx => PlayerMove(ctx.ReadValue<float>());
        playerControl.fly.Move.canceled   += ctx => PlayerMove(ctx.ReadValue<float>());

        playerControl.fly.Move_touch.performed   += ctx => {

                                                        move_touch = 2;
                                                        float delta_x = ctx.ReadValue<float>();
                                                        if(delta_x == 0)
                                                        {
                                                            PlayerMove(0.0f);
                                                        }
                                                        else if(ctx.ReadValue<float>() < 0)
                                                        {
                                                            PlayerMove(- move_touch);
                                                        }
                                                        else
                                                        {
                                                            PlayerMove(move_touch);
                                                        }
                                                    } ; 
        // playerControl.fly.Move_touch.canceled   += ctx => {
        //                                                 // PlayerMove(ctx.ReadValue<Vector2>().x);
                                                        
        //                                                 PlayerMove(0.0f);
        //                                                 // Debug.Log("cancelled");
        //                                             } ; 


        playerControl.fly.Change_ammo.performed  += ctx => m_shooting.ChangeAmmo((int)Math.Ceiling(ctx.ReadValue<float>()));
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

#if UNITY_ANDROID

    void FixedUpdate()
    {
        
        for (int i = 0; i < Input.touchCount; ++i)
        {
            UnityEngine.Touch touch = Input.GetTouch(i);
            // switch ((touch.position.x,touch.position.y))
            // {
            //     case (1, "hello", false):
            //         break;
            //     case (2, "world", false):
            //         break;
            //     case (2, "hello", false):
            //         break;
            // }
            if (touch.phase != TouchPhase.Ended)
            {
                if(touch.position.y < UnityEngine.Screen.height/2)
                {
                    if(touch.position.x < UnityEngine.Screen.width/2)
                    {
                        PlayerMove(- 2.0f);
                    }
                    else
                    {
                        PlayerMove(2.0f);
                    }
                }
                else
                {
                    if(touch.position.x > UnityEngine.Screen.width/2)
                    {
                        m_shooting.changeAmmo = 1;
                    }
                    else
                    {
                        m_shooting.shoot = true;
                    }
                }
            }
            else
            {
                // Debug.Log(activeTouch.delta.y);
                // if(touch.delta.y < 0)
                // {
                //     m_playerMovement.speedBoost = true;
                // }
                // Debug.Log("Ended");
                PlayerMove(0.0f);
                m_shooting.shoot = false;
                m_shooting.changeAmmo = 0;
                // Input.multiTouchEnabled = true;

            }
        }
    }

#endif
}
