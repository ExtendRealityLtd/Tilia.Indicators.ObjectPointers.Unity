namespace Tilia.Indicators.ObjectPointers
{
    using UnityEngine;
    using Zinnia.Action;
    using Zinnia.Cast;
    using Zinnia.Data.Attribute;
    using Zinnia.Extension;
    using Zinnia.Pointer;
    using Zinnia.Rule;

    /// <summary>
    /// The public interface into the Pointer Prefab.
    /// </summary>
    public class PointerFacade : MonoBehaviour
    {
        /// <summary>
        /// The pointer selection type.
        /// </summary>
        public enum SelectionType
        {
            /// <summary>
            /// Initiates the select action when the selection action is activated (e.g. button pressed).
            /// </summary>
            SelectOnActivate,
            /// <summary>
            /// Initiates the select action when the selection action is deactivated (e.g. button released).
            /// </summary>
            SelectOnDeactivate
        }

        #region Pointer Settings
        [Header("Pointer Settings")]
        [Tooltip("The source for the pointer origin to follow.")]
        [SerializeField]
        private GameObject followSource;
        /// <summary>
        /// The source for the pointer origin to follow.
        /// </summary>
        public GameObject FollowSource
        {
            get
            {
                return followSource;
            }
            set
            {
                followSource = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterFollowSourceChange();
                }
            }
        }
        [Tooltip("The BooleanAction that will activate/deactivate the pointer.")]
        [SerializeField]
        private BooleanAction activationAction;
        /// <summary>
        /// The <see cref="BooleanAction"/> that will activate/deactivate the pointer.
        /// </summary>
        public BooleanAction ActivationAction
        {
            get
            {
                return activationAction;
            }
            set
            {
                activationAction = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterActivationActionChange();
                }
            }
        }
        [Tooltip("The BooleanAction that initiates the pointer selection.")]
        [SerializeField]
        private BooleanAction selectionAction;
        /// <summary>
        /// The <see cref="BooleanAction"/> that initiates the pointer selection.
        /// </summary>
        public BooleanAction SelectionAction
        {
            get
            {
                return selectionAction;
            }
            set
            {
                selectionAction = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterSelectionActionChange();
                }
            }
        }
        [Tooltip("The action moment when to initiate the select action.")]
        [SerializeField]
        private SelectionType selectionMethod = SelectionType.SelectOnActivate;
        /// <summary>
        /// The action moment when to initiate the select action.
        /// </summary>
        public SelectionType SelectionMethod
        {
            get
            {
                return selectionMethod;
            }
            set
            {
                selectionMethod = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterSelectionMethodChange();
                }
            }
        }
        #endregion

        #region Restriction Settings
        [Header("Restriction Settings")]
        [Tooltip("Allows to optionally determine targets based on the set rules.")]
        [SerializeField]
        private RuleContainer hoverValidity;
        /// <summary>
        /// Allows to optionally determine targets based on the set rules.
        /// </summary>
        public RuleContainer HoverValidity
        {
            get
            {
                return hoverValidity;
            }
            set
            {
                hoverValidity = value;
            }
        }
        [Tooltip("Allows to optionally determine selection targets based on the set rules.")]
        [SerializeField]
        private RuleContainer targetValidity;
        /// <summary>
        /// Allows to optionally determine selection targets based on the set rules.
        /// </summary>
        public RuleContainer TargetValidity
        {
            get
            {
                return targetValidity;
            }
            set
            {
                targetValidity = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterTargetValidityChange();
                }
            }
        }
        [Tooltip("Allows to optionally determine a specific selection target point based on the set rules.")]
        [SerializeField]
        private RuleContainer targetPointValidity;
        /// <summary>
        /// Allows to optionally determine a specific selection target point based on the set rules.
        /// </summary>
        public RuleContainer TargetPointValidity
        {
            get
            {
                return targetPointValidity;
            }
            set
            {
                targetPointValidity = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterTargetPointValidityChange();
                }
            }
        }
        [Tooltip("Allows to optionally define the rules for the RayCast of the pointer beam elements.")]
        [SerializeField]
        private PhysicsCast raycastRules;
        /// <summary>
        /// Allows to optionally define the rules for the RayCast of the pointer beam elements.
        /// </summary>
        public PhysicsCast RaycastRules
        {
            get
            {
                return raycastRules;
            }
            set
            {
                raycastRules = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterRaycastRulesChange();
                }
            }
        }
        #endregion

        #region Pointer Events
        /// <summary>
        /// Emitted when the <see cref="ObjectPointer"/> becomes active.
        /// </summary>
        [Header("Pointer Events")]
        public ObjectPointer.UnityEvent Activated = new ObjectPointer.UnityEvent();
        /// <summary>
        /// Emitted when the <see cref="ObjectPointer"/> is deactivated.
        /// </summary>
        public ObjectPointer.UnityEvent Deactivated = new ObjectPointer.UnityEvent();
        /// <summary>
        /// Emitted when the <see cref="ObjectPointer"/> collides with a new target.
        /// </summary>
        public ObjectPointer.UnityEvent Entered = new ObjectPointer.UnityEvent();
        /// <summary>
        /// Emitted when the <see cref="ObjectPointer"/> stops colliding with an existing target.
        /// </summary>
        public ObjectPointer.UnityEvent Exited = new ObjectPointer.UnityEvent();
        /// <summary>
        /// Emitted when the <see cref="ObjectPointer"/> changes its hovering position over an existing target.
        /// </summary>
        public ObjectPointer.UnityEvent HoverChanged = new ObjectPointer.UnityEvent();
        /// <summary>
        /// Emitted whenever <see cref="ObjectPointer.Select"/> is called.
        /// </summary>
        public ObjectPointer.UnityEvent Selected = new ObjectPointer.UnityEvent();
        #endregion

        #region Reference Settings
        [Header("Reference Settings")]
        [Tooltip("The linked Internal Setup.")]
        [SerializeField]
        [Restricted]
        private PointerConfigurator configuration;
        /// <summary>
        /// The linked Internal Setup.
        /// </summary>
        public PointerConfigurator Configuration
        {
            get
            {
                return configuration;
            }
            protected set
            {
                configuration = value;
            }
        }
        #endregion

        /// <summary>
        /// Clears <see cref="FollowSource"/>.
        /// </summary>
        public virtual void ClearFollowSource()
        {
            if (!this.IsValidState())
            {
                return;
            }

            FollowSource = default;
        }

        /// <summary>
        /// Clears <see cref="ActivationAction"/>.
        /// </summary>
        public virtual void ClearActivationAction()
        {
            if (!this.IsValidState())
            {
                return;
            }

            ActivationAction = default;
        }

        /// <summary>
        /// Clears <see cref="SelectionAction"/>.
        /// </summary>
        public virtual void ClearSelectionAction()
        {
            if (!this.IsValidState())
            {
                return;
            }

            SelectionAction = default;
        }

        /// <summary>
        /// Clears <see cref="TargetValidity"/>.
        /// </summary>
        public virtual void ClearTargetValidity()
        {
            if (!this.IsValidState())
            {
                return;
            }

            TargetValidity = default;
        }

        /// <summary>
        /// Clears <see cref="TargetPointValidity"/>.
        /// </summary>
        public virtual void ClearTargetPointValidity()
        {
            if (!this.IsValidState())
            {
                return;
            }

            TargetPointValidity = default;
        }

        /// <summary>
        /// Clears <see cref="RaycastRules"/>.
        /// </summary>
        public virtual void ClearRaycastRules()
        {
            if (!this.IsValidState())
            {
                return;
            }

            RaycastRules = default;
        }

        /// <summary>
        /// Sets <see cref="SelectionMethod"/>.
        /// </summary>
        /// <param name="selectionMethodIndex">The index of the <see cref="SelectionType"/>.</param>
        public virtual void SetSelectionMethod(int selectionMethodIndex)
        {
            SelectionMethod = EnumExtensions.GetByIndex<SelectionType>(selectionMethodIndex);
        }

        /// <summary>
        /// The Activate method turns on the <see cref="ObjectPointer"/>.
        /// </summary>
        public virtual void Activate()
        {
            if (!this.IsValidState())
            {
                return;
            }

            Configuration.ObjectPointer.Activate();
        }

        /// <summary>
        /// The Deactivate method turns off the <see cref="ObjectPointer"/>.
        /// </summary>
        public virtual void Deactivate()
        {
            Configuration.ObjectPointer.Deactivate();
        }

        /// <summary>
        /// Gets the current <see cref="ObjectPointer"/> state and emits it through <see cref="Selected"/>.
        /// </summary>
        public virtual void Select()
        {
            if (!this.IsValidState())
            {
                return;
            }

            Configuration.ObjectPointer.Select();
        }

        /// <summary>
        /// Called after <see cref="FollowSource"/> has been changed.
        /// </summary>
        protected virtual void OnAfterFollowSourceChange()
        {
            Configuration.ConfigureFollowSources();
        }

        /// <summary>
        /// Called after <see cref="ActivationAction"/> has been changed.
        /// </summary>
        protected virtual void OnAfterActivationActionChange()
        {
            Configuration.ConfigureActivationAction();
        }

        /// <summary>
        /// Called after <see cref="SelectionAction"/> has been changed.
        /// </summary>
        protected virtual void OnAfterSelectionActionChange()
        {
            Configuration.ConfigureSelectionAction();
        }

        /// <summary>
        /// Called after <see cref="SelectionMethod"/> has been changed.
        /// </summary>
        protected virtual void OnAfterSelectionMethodChange()
        {
            Configuration.ConfigureSelectionType();
        }

        /// <summary>
        /// Called after <see cref="TargetValidity"/> has been changed.
        /// </summary>
        protected virtual void OnAfterTargetValidityChange()
        {
            Configuration.ConfigureTargetValidity();
        }

        /// <summary>
        /// Called after <see cref="TargetPointValidity"/> has been changed.
        /// </summary>
        protected virtual void OnAfterTargetPointValidityChange()
        {
            Configuration.ConfigureTargetPointValidity();
        }

        /// <summary>
        /// Called after <see cref="RaycastRules"/> has been changed.
        /// </summary>
        protected virtual void OnAfterRaycastRulesChange()
        {
            Configuration.ConfigureRaycastRules();
        }
    }
}