// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/playerControl.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerController : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerController()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""playerControl"",
    ""maps"": [
        {
            ""name"": ""fly"",
            ""id"": ""00eb7c9d-0ae9-4d2f-90dc-a67ad82257b4"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""6b6fcfc6-f426-4016-8b94-771b68fb2c11"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""c27ba47d-ec24-41ac-adb7-894af8aa10de"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""speed_boost"",
                    ""type"": ""Button"",
                    ""id"": ""fa733c64-792f-491a-bf05-7308c6e65877"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Change_ammo"",
                    ""type"": ""Button"",
                    ""id"": ""456444ce-008f-409c-85ae-9f9db33eb036"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Change_ammo_touch"",
                    ""type"": ""PassThrough"",
                    ""id"": ""f2baf56d-65d0-4bcc-ba4d-c08765f50529"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move_touch"",
                    ""type"": ""PassThrough"",
                    ""id"": ""44307cde-f86a-4350-b5ef-36a6f401f7ae"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move_touch_end"",
                    ""type"": ""PassThrough"",
                    ""id"": ""66080343-9d59-473b-a724-128a9d31da37"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""turn"",
                    ""id"": ""f419c133-84d5-4521-aa5d-d88eaa14148c"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""72eae00b-c794-4fff-b9c2-132682905049"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""1d75c6db-abc5-4a72-9082-a97d46c9db6b"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""161a3580-c600-4913-b379-721753fb54dc"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""3ddbde03-2954-40c1-a2b9-59062e533bc7"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""dfb6ea1b-1f04-42a8-85f8-742b18e589fb"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7dc6605a-e6cc-41b4-9e71-a7f5ae36ece6"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""03984c5a-ad68-48dd-a184-90911098934e"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""93c7503d-8e1c-447e-a3ff-1688d3fdc5b3"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Change_ammo"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""97ba301f-8d59-41af-bbd2-6d900d1ddb2d"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Change_ammo"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6c940854-0ff0-40fa-8eba-47185b96fa98"",
                    ""path"": ""<Touchscreen>/press"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Computer;Mobile Phone"",
                    ""action"": ""Change_ammo_touch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0c0b7c30-7403-405f-be51-9df72f661cd5"",
                    ""path"": ""<Touchscreen>/primaryTouch/phase"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mobile Phone"",
                    ""action"": ""Move_touch_end"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1fb1045a-651f-432b-9430-5e69b901939a"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""speed_boost"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0d9e41ef-aad8-4150-8e1c-f301700d1e6c"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""speed_boost"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bead6ae7-1f71-4f9d-9fa3-eb60b979d124"",
                    ""path"": ""<Mouse>/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move_touch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Computer"",
            ""bindingGroup"": ""Computer"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Mobile Phone"",
            ""bindingGroup"": ""Mobile Phone"",
            ""devices"": [
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // fly
        m_fly = asset.FindActionMap("fly", throwIfNotFound: true);
        m_fly_Move = m_fly.FindAction("Move", throwIfNotFound: true);
        m_fly_Shoot = m_fly.FindAction("Shoot", throwIfNotFound: true);
        m_fly_speed_boost = m_fly.FindAction("speed_boost", throwIfNotFound: true);
        m_fly_Change_ammo = m_fly.FindAction("Change_ammo", throwIfNotFound: true);
        m_fly_Change_ammo_touch = m_fly.FindAction("Change_ammo_touch", throwIfNotFound: true);
        m_fly_Move_touch = m_fly.FindAction("Move_touch", throwIfNotFound: true);
        m_fly_Move_touch_end = m_fly.FindAction("Move_touch_end", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // fly
    private readonly InputActionMap m_fly;
    private IFlyActions m_FlyActionsCallbackInterface;
    private readonly InputAction m_fly_Move;
    private readonly InputAction m_fly_Shoot;
    private readonly InputAction m_fly_speed_boost;
    private readonly InputAction m_fly_Change_ammo;
    private readonly InputAction m_fly_Change_ammo_touch;
    private readonly InputAction m_fly_Move_touch;
    private readonly InputAction m_fly_Move_touch_end;
    public struct FlyActions
    {
        private @PlayerController m_Wrapper;
        public FlyActions(@PlayerController wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_fly_Move;
        public InputAction @Shoot => m_Wrapper.m_fly_Shoot;
        public InputAction @speed_boost => m_Wrapper.m_fly_speed_boost;
        public InputAction @Change_ammo => m_Wrapper.m_fly_Change_ammo;
        public InputAction @Change_ammo_touch => m_Wrapper.m_fly_Change_ammo_touch;
        public InputAction @Move_touch => m_Wrapper.m_fly_Move_touch;
        public InputAction @Move_touch_end => m_Wrapper.m_fly_Move_touch_end;
        public InputActionMap Get() { return m_Wrapper.m_fly; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(FlyActions set) { return set.Get(); }
        public void SetCallbacks(IFlyActions instance)
        {
            if (m_Wrapper.m_FlyActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_FlyActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_FlyActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_FlyActionsCallbackInterface.OnMove;
                @Shoot.started -= m_Wrapper.m_FlyActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_FlyActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_FlyActionsCallbackInterface.OnShoot;
                @speed_boost.started -= m_Wrapper.m_FlyActionsCallbackInterface.OnSpeed_boost;
                @speed_boost.performed -= m_Wrapper.m_FlyActionsCallbackInterface.OnSpeed_boost;
                @speed_boost.canceled -= m_Wrapper.m_FlyActionsCallbackInterface.OnSpeed_boost;
                @Change_ammo.started -= m_Wrapper.m_FlyActionsCallbackInterface.OnChange_ammo;
                @Change_ammo.performed -= m_Wrapper.m_FlyActionsCallbackInterface.OnChange_ammo;
                @Change_ammo.canceled -= m_Wrapper.m_FlyActionsCallbackInterface.OnChange_ammo;
                @Change_ammo_touch.started -= m_Wrapper.m_FlyActionsCallbackInterface.OnChange_ammo_touch;
                @Change_ammo_touch.performed -= m_Wrapper.m_FlyActionsCallbackInterface.OnChange_ammo_touch;
                @Change_ammo_touch.canceled -= m_Wrapper.m_FlyActionsCallbackInterface.OnChange_ammo_touch;
                @Move_touch.started -= m_Wrapper.m_FlyActionsCallbackInterface.OnMove_touch;
                @Move_touch.performed -= m_Wrapper.m_FlyActionsCallbackInterface.OnMove_touch;
                @Move_touch.canceled -= m_Wrapper.m_FlyActionsCallbackInterface.OnMove_touch;
                @Move_touch_end.started -= m_Wrapper.m_FlyActionsCallbackInterface.OnMove_touch_end;
                @Move_touch_end.performed -= m_Wrapper.m_FlyActionsCallbackInterface.OnMove_touch_end;
                @Move_touch_end.canceled -= m_Wrapper.m_FlyActionsCallbackInterface.OnMove_touch_end;
            }
            m_Wrapper.m_FlyActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @speed_boost.started += instance.OnSpeed_boost;
                @speed_boost.performed += instance.OnSpeed_boost;
                @speed_boost.canceled += instance.OnSpeed_boost;
                @Change_ammo.started += instance.OnChange_ammo;
                @Change_ammo.performed += instance.OnChange_ammo;
                @Change_ammo.canceled += instance.OnChange_ammo;
                @Change_ammo_touch.started += instance.OnChange_ammo_touch;
                @Change_ammo_touch.performed += instance.OnChange_ammo_touch;
                @Change_ammo_touch.canceled += instance.OnChange_ammo_touch;
                @Move_touch.started += instance.OnMove_touch;
                @Move_touch.performed += instance.OnMove_touch;
                @Move_touch.canceled += instance.OnMove_touch;
                @Move_touch_end.started += instance.OnMove_touch_end;
                @Move_touch_end.performed += instance.OnMove_touch_end;
                @Move_touch_end.canceled += instance.OnMove_touch_end;
            }
        }
    }
    public FlyActions @fly => new FlyActions(this);
    private int m_ComputerSchemeIndex = -1;
    public InputControlScheme ComputerScheme
    {
        get
        {
            if (m_ComputerSchemeIndex == -1) m_ComputerSchemeIndex = asset.FindControlSchemeIndex("Computer");
            return asset.controlSchemes[m_ComputerSchemeIndex];
        }
    }
    private int m_MobilePhoneSchemeIndex = -1;
    public InputControlScheme MobilePhoneScheme
    {
        get
        {
            if (m_MobilePhoneSchemeIndex == -1) m_MobilePhoneSchemeIndex = asset.FindControlSchemeIndex("Mobile Phone");
            return asset.controlSchemes[m_MobilePhoneSchemeIndex];
        }
    }
    public interface IFlyActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnSpeed_boost(InputAction.CallbackContext context);
        void OnChange_ammo(InputAction.CallbackContext context);
        void OnChange_ammo_touch(InputAction.CallbackContext context);
        void OnMove_touch(InputAction.CallbackContext context);
        void OnMove_touch_end(InputAction.CallbackContext context);
    }
}
