// GENERATED AUTOMATICALLY FROM 'Assets/InputAction/PersoControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PersoControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PersoControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PersoControls"",
    ""maps"": [
        {
            ""name"": ""MoveHit"",
            ""id"": ""d3a23ce5-29c2-476c-b52d-0a9bf762f9ce"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""29084b74-97bb-4c2d-afc2-33e925976438"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Hit"",
                    ""type"": ""Button"",
                    ""id"": ""2ec3e856-11dc-48b4-9d1d-93f01702afab"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""af9bdfcd-f540-4e27-9ade-ba3d80adb8d8"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""2c933017-0593-4ddf-95ee-c2b83a01303b"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""5e9b41ed-c4e6-48a0-8fee-2e379fb9be3e"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e66b0d16-f654-4b09-a445-cc017b1e9e6b"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""e1f12c3f-3fe4-4f63-961b-658645877427"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""255c1fa8-f02c-4b31-a77e-265c051955e3"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Hit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // MoveHit
        m_MoveHit = asset.FindActionMap("MoveHit", throwIfNotFound: true);
        m_MoveHit_Move = m_MoveHit.FindAction("Move", throwIfNotFound: true);
        m_MoveHit_Hit = m_MoveHit.FindAction("Hit", throwIfNotFound: true);
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

    // MoveHit
    private readonly InputActionMap m_MoveHit;
    private IMoveHitActions m_MoveHitActionsCallbackInterface;
    private readonly InputAction m_MoveHit_Move;
    private readonly InputAction m_MoveHit_Hit;
    public struct MoveHitActions
    {
        private @PersoControls m_Wrapper;
        public MoveHitActions(@PersoControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_MoveHit_Move;
        public InputAction @Hit => m_Wrapper.m_MoveHit_Hit;
        public InputActionMap Get() { return m_Wrapper.m_MoveHit; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MoveHitActions set) { return set.Get(); }
        public void SetCallbacks(IMoveHitActions instance)
        {
            if (m_Wrapper.m_MoveHitActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_MoveHitActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_MoveHitActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_MoveHitActionsCallbackInterface.OnMove;
                @Hit.started -= m_Wrapper.m_MoveHitActionsCallbackInterface.OnHit;
                @Hit.performed -= m_Wrapper.m_MoveHitActionsCallbackInterface.OnHit;
                @Hit.canceled -= m_Wrapper.m_MoveHitActionsCallbackInterface.OnHit;
            }
            m_Wrapper.m_MoveHitActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Hit.started += instance.OnHit;
                @Hit.performed += instance.OnHit;
                @Hit.canceled += instance.OnHit;
            }
        }
    }
    public MoveHitActions @MoveHit => new MoveHitActions(this);
    public interface IMoveHitActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnHit(InputAction.CallbackContext context);
    }
}
