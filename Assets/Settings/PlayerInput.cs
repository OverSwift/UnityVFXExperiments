// GENERATED AUTOMATICALLY FROM 'Assets/Settings/PlayerInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class PlayerInput : IInputActionCollection, IDisposable
{
    private InputActionAsset asset;
    public PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""KnightInput"",
            ""id"": ""d2a0227e-f879-4de6-8929-2003ac13ca47"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""4b114659-dd5b-4d64-a2fb-52ea4aab7582"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""ad1ee635-9cd8-47db-b0a2-b23b54b01ecd"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""Button"",
                    ""id"": ""572ca56b-567d-4099-adb3-696d7fe7d951"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""ef5678db-5cda-4e05-b43a-e54cb0c691bd"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Negative"",
                    ""id"": ""60efe623-3487-4072-a250-4bfe2261fb70"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Positive"",
                    ""id"": ""4c7d1636-b85e-4845-9df5-431fa780a35f"",
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
                    ""id"": ""eb6cff69-3def-4df5-aa6b-6cb31531783c"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9ab1c08e-38a2-4d22-a73e-3a9421c37c88"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // KnightInput
        m_KnightInput = asset.FindActionMap("KnightInput", throwIfNotFound: true);
        m_KnightInput_Move = m_KnightInput.FindAction("Move", throwIfNotFound: true);
        m_KnightInput_Jump = m_KnightInput.FindAction("Jump", throwIfNotFound: true);
        m_KnightInput_Run = m_KnightInput.FindAction("Run", throwIfNotFound: true);
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

    // KnightInput
    private readonly InputActionMap m_KnightInput;
    private IKnightInputActions m_KnightInputActionsCallbackInterface;
    private readonly InputAction m_KnightInput_Move;
    private readonly InputAction m_KnightInput_Jump;
    private readonly InputAction m_KnightInput_Run;
    public struct KnightInputActions
    {
        private PlayerInput m_Wrapper;
        public KnightInputActions(PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_KnightInput_Move;
        public InputAction @Jump => m_Wrapper.m_KnightInput_Jump;
        public InputAction @Run => m_Wrapper.m_KnightInput_Run;
        public InputActionMap Get() { return m_Wrapper.m_KnightInput; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(KnightInputActions set) { return set.Get(); }
        public void SetCallbacks(IKnightInputActions instance)
        {
            if (m_Wrapper.m_KnightInputActionsCallbackInterface != null)
            {
                Move.started -= m_Wrapper.m_KnightInputActionsCallbackInterface.OnMove;
                Move.performed -= m_Wrapper.m_KnightInputActionsCallbackInterface.OnMove;
                Move.canceled -= m_Wrapper.m_KnightInputActionsCallbackInterface.OnMove;
                Jump.started -= m_Wrapper.m_KnightInputActionsCallbackInterface.OnJump;
                Jump.performed -= m_Wrapper.m_KnightInputActionsCallbackInterface.OnJump;
                Jump.canceled -= m_Wrapper.m_KnightInputActionsCallbackInterface.OnJump;
                Run.started -= m_Wrapper.m_KnightInputActionsCallbackInterface.OnRun;
                Run.performed -= m_Wrapper.m_KnightInputActionsCallbackInterface.OnRun;
                Run.canceled -= m_Wrapper.m_KnightInputActionsCallbackInterface.OnRun;
            }
            m_Wrapper.m_KnightInputActionsCallbackInterface = instance;
            if (instance != null)
            {
                Move.started += instance.OnMove;
                Move.performed += instance.OnMove;
                Move.canceled += instance.OnMove;
                Jump.started += instance.OnJump;
                Jump.performed += instance.OnJump;
                Jump.canceled += instance.OnJump;
                Run.started += instance.OnRun;
                Run.performed += instance.OnRun;
                Run.canceled += instance.OnRun;
            }
        }
    }
    public KnightInputActions @KnightInput => new KnightInputActions(this);
    public interface IKnightInputActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
    }
}
