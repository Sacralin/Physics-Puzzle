//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Inputs/PuzzleInputs.inputactions
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

public partial class @PuzzleInputs: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PuzzleInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PuzzleInputs"",
    ""maps"": [
        {
            ""name"": ""PuzzleControls"",
            ""id"": ""445a4f4d-bb8a-4a1f-8bf2-bb322cad1143"",
            ""actions"": [
                {
                    ""name"": ""RotateCounterClockwise"",
                    ""type"": ""Button"",
                    ""id"": ""71c0c219-f998-494e-869c-8e1510a44305"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""RotateClockwise"",
                    ""type"": ""Button"",
                    ""id"": ""861b1fd0-4c34-4d91-9cf7-6cb8b72dc21c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""0bf5b581-fa3c-46ba-9e7f-cb9020869cff"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Exit"",
                    ""type"": ""Button"",
                    ""id"": ""31219829-052b-4260-ab78-91f16270dfb3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""35a59e45-225f-49c0-be01-cda3754b94d6"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateCounterClockwise"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f28177e7-5667-4963-a53d-90ca750e8e4c"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateClockwise"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fcc88c05-a177-4fae-8dac-cdfce1db23b0"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ec64e03f-6461-4dc4-9b1e-95745361c2ac"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Exit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PuzzleControls
        m_PuzzleControls = asset.FindActionMap("PuzzleControls", throwIfNotFound: true);
        m_PuzzleControls_RotateCounterClockwise = m_PuzzleControls.FindAction("RotateCounterClockwise", throwIfNotFound: true);
        m_PuzzleControls_RotateClockwise = m_PuzzleControls.FindAction("RotateClockwise", throwIfNotFound: true);
        m_PuzzleControls_Interact = m_PuzzleControls.FindAction("Interact", throwIfNotFound: true);
        m_PuzzleControls_Exit = m_PuzzleControls.FindAction("Exit", throwIfNotFound: true);
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

    // PuzzleControls
    private readonly InputActionMap m_PuzzleControls;
    private List<IPuzzleControlsActions> m_PuzzleControlsActionsCallbackInterfaces = new List<IPuzzleControlsActions>();
    private readonly InputAction m_PuzzleControls_RotateCounterClockwise;
    private readonly InputAction m_PuzzleControls_RotateClockwise;
    private readonly InputAction m_PuzzleControls_Interact;
    private readonly InputAction m_PuzzleControls_Exit;
    public struct PuzzleControlsActions
    {
        private @PuzzleInputs m_Wrapper;
        public PuzzleControlsActions(@PuzzleInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @RotateCounterClockwise => m_Wrapper.m_PuzzleControls_RotateCounterClockwise;
        public InputAction @RotateClockwise => m_Wrapper.m_PuzzleControls_RotateClockwise;
        public InputAction @Interact => m_Wrapper.m_PuzzleControls_Interact;
        public InputAction @Exit => m_Wrapper.m_PuzzleControls_Exit;
        public InputActionMap Get() { return m_Wrapper.m_PuzzleControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PuzzleControlsActions set) { return set.Get(); }
        public void AddCallbacks(IPuzzleControlsActions instance)
        {
            if (instance == null || m_Wrapper.m_PuzzleControlsActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PuzzleControlsActionsCallbackInterfaces.Add(instance);
            @RotateCounterClockwise.started += instance.OnRotateCounterClockwise;
            @RotateCounterClockwise.performed += instance.OnRotateCounterClockwise;
            @RotateCounterClockwise.canceled += instance.OnRotateCounterClockwise;
            @RotateClockwise.started += instance.OnRotateClockwise;
            @RotateClockwise.performed += instance.OnRotateClockwise;
            @RotateClockwise.canceled += instance.OnRotateClockwise;
            @Interact.started += instance.OnInteract;
            @Interact.performed += instance.OnInteract;
            @Interact.canceled += instance.OnInteract;
            @Exit.started += instance.OnExit;
            @Exit.performed += instance.OnExit;
            @Exit.canceled += instance.OnExit;
        }

        private void UnregisterCallbacks(IPuzzleControlsActions instance)
        {
            @RotateCounterClockwise.started -= instance.OnRotateCounterClockwise;
            @RotateCounterClockwise.performed -= instance.OnRotateCounterClockwise;
            @RotateCounterClockwise.canceled -= instance.OnRotateCounterClockwise;
            @RotateClockwise.started -= instance.OnRotateClockwise;
            @RotateClockwise.performed -= instance.OnRotateClockwise;
            @RotateClockwise.canceled -= instance.OnRotateClockwise;
            @Interact.started -= instance.OnInteract;
            @Interact.performed -= instance.OnInteract;
            @Interact.canceled -= instance.OnInteract;
            @Exit.started -= instance.OnExit;
            @Exit.performed -= instance.OnExit;
            @Exit.canceled -= instance.OnExit;
        }

        public void RemoveCallbacks(IPuzzleControlsActions instance)
        {
            if (m_Wrapper.m_PuzzleControlsActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPuzzleControlsActions instance)
        {
            foreach (var item in m_Wrapper.m_PuzzleControlsActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PuzzleControlsActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PuzzleControlsActions @PuzzleControls => new PuzzleControlsActions(this);
    public interface IPuzzleControlsActions
    {
        void OnRotateCounterClockwise(InputAction.CallbackContext context);
        void OnRotateClockwise(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnExit(InputAction.CallbackContext context);
    }
}
