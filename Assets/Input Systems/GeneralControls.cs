//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Input Systems/GeneralControls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @GeneralControls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @GeneralControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GeneralControls"",
    ""maps"": [
        {
            ""name"": ""Chicken Action Map"",
            ""id"": ""20fb2251-8d79-42da-87dc-bef01375916c"",
            ""actions"": [
                {
                    ""name"": ""Lay Egg"",
                    ""type"": ""Button"",
                    ""id"": ""3f73bbf5-fdfc-48c9-b5b2-613503670ea8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Chicken Move"",
                    ""type"": ""Value"",
                    ""id"": ""60b176f8-caa9-4a3b-ad33-844d5982f9ef"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""415428c3-a6a1-4266-919c-9b8186bcbb16"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Lay Egg"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e4e728ed-da1c-4d2a-91be-d8be213c9b70"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Chicken Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Chicken Action Map
        m_ChickenActionMap = asset.FindActionMap("Chicken Action Map", throwIfNotFound: true);
        m_ChickenActionMap_LayEgg = m_ChickenActionMap.FindAction("Lay Egg", throwIfNotFound: true);
        m_ChickenActionMap_ChickenMove = m_ChickenActionMap.FindAction("Chicken Move", throwIfNotFound: true);
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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Chicken Action Map
    private readonly InputActionMap m_ChickenActionMap;
    private IChickenActionMapActions m_ChickenActionMapActionsCallbackInterface;
    private readonly InputAction m_ChickenActionMap_LayEgg;
    private readonly InputAction m_ChickenActionMap_ChickenMove;
    public struct ChickenActionMapActions
    {
        private @GeneralControls m_Wrapper;
        public ChickenActionMapActions(@GeneralControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @LayEgg => m_Wrapper.m_ChickenActionMap_LayEgg;
        public InputAction @ChickenMove => m_Wrapper.m_ChickenActionMap_ChickenMove;
        public InputActionMap Get() { return m_Wrapper.m_ChickenActionMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ChickenActionMapActions set) { return set.Get(); }
        public void SetCallbacks(IChickenActionMapActions instance)
        {
            if (m_Wrapper.m_ChickenActionMapActionsCallbackInterface != null)
            {
                @LayEgg.started -= m_Wrapper.m_ChickenActionMapActionsCallbackInterface.OnLayEgg;
                @LayEgg.performed -= m_Wrapper.m_ChickenActionMapActionsCallbackInterface.OnLayEgg;
                @LayEgg.canceled -= m_Wrapper.m_ChickenActionMapActionsCallbackInterface.OnLayEgg;
                @ChickenMove.started -= m_Wrapper.m_ChickenActionMapActionsCallbackInterface.OnChickenMove;
                @ChickenMove.performed -= m_Wrapper.m_ChickenActionMapActionsCallbackInterface.OnChickenMove;
                @ChickenMove.canceled -= m_Wrapper.m_ChickenActionMapActionsCallbackInterface.OnChickenMove;
            }
            m_Wrapper.m_ChickenActionMapActionsCallbackInterface = instance;
            if (instance != null)
            {
                @LayEgg.started += instance.OnLayEgg;
                @LayEgg.performed += instance.OnLayEgg;
                @LayEgg.canceled += instance.OnLayEgg;
                @ChickenMove.started += instance.OnChickenMove;
                @ChickenMove.performed += instance.OnChickenMove;
                @ChickenMove.canceled += instance.OnChickenMove;
            }
        }
    }
    public ChickenActionMapActions @ChickenActionMap => new ChickenActionMapActions(this);
    public interface IChickenActionMapActions
    {
        void OnLayEgg(InputAction.CallbackContext context);
        void OnChickenMove(InputAction.CallbackContext context);
    }
}
