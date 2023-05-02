namespace Tilia.Indicators.ObjectPointers
{
    using UnityEngine;
    using Zinnia.Action;
    using Zinnia.Cast;
    using Zinnia.Data.Attribute;
    using Zinnia.Extension;
    using Zinnia.Pointer;
    using Zinnia.Tracking.Follow;

    /// <summary>
    /// Sets up the Pointer Prefab based on the provided user settings.
    /// </summary>
    public class PointerConfigurator : MonoBehaviour
    {
        #region Facade Settings
        [Header("Facade Settings")]
        [Tooltip("The public facade.")]
        [SerializeField]
        [Restricted]
        private PointerFacade facade;
        /// <summary>
        /// The public facade.
        /// </summary>
        public PointerFacade Facade
        {
            get
            {
                return facade;
            }
            set
            {
                facade = value;
            }
        }
        #endregion

        #region Pointer Settings
        [Header("Pointer Settings")]
        [Tooltip("The ObjectPointer component for the Pointer.")]
        [SerializeField]
        [Restricted]
        private ObjectPointer objectPointer;
        /// <summary>
        /// The <see cref="ObjectPointer"/> component for the Pointer.
        /// </summary>
        public ObjectPointer ObjectPointer
        {
            get
            {
                return objectPointer;
            }
            set
            {
                objectPointer = value;
            }
        }
        #endregion

        #region Object Follow Settings
        [Header("Object Follow Settings")]
        [Tooltip("The ObjectFollower component for the Pointer.")]
        [SerializeField]
        [Restricted]
        private ObjectFollower objectFollow;
        /// <summary>
        /// The <see cref="ObjectFollower"/> component for the Pointer.
        /// </summary>
        public ObjectFollower ObjectFollow
        {
            get
            {
                return objectFollow;
            }
            set
            {
                objectFollow = value;
            }
        }
        #endregion

        #region Cast Settings
        [Header("Cast Settings")]
        [Tooltip("The PointsCast component for the Pointer.")]
        [SerializeField]
        [Restricted]
        private PointsCast caster;
        /// <summary>
        /// The <see cref="PointsCast"/> component for the Pointer.
        /// </summary>
        public PointsCast Caster
        {
            get
            {
                return caster;
            }
            set
            {
                caster = value;
            }
        }
        #endregion

        #region Action Settings
        [Header("Action Settings")]
        [Tooltip("The BooleanAction that will activate/deactivate the pointer.")]
        [SerializeField]
        [Restricted]
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
            }
        }
        [Tooltip("The BooleanAction that initiates the pointer selection when the action is activated.")]
        [SerializeField]
        [Restricted]
        private BooleanAction selectOnActivatedAction;
        /// <summary>
        /// The <see cref="BooleanAction"/> that initiates the pointer selection when the action is activated.
        /// </summary>
        public BooleanAction SelectOnActivatedAction
        {
            get
            {
                return selectOnActivatedAction;
            }
            set
            {
                selectOnActivatedAction = value;
            }
        }
        [Tooltip("The BooleanAction that initiates the pointer selection when the action is deactivated.")]
        [SerializeField]
        [Restricted]
        private BooleanAction selectOnDeactivatedAction;
        /// <summary>
        /// The <see cref="BooleanAction"/> that initiates the pointer selection when the action is deactivated.
        /// </summary>
        public BooleanAction SelectOnDeactivatedAction
        {
            get
            {
                return selectOnDeactivatedAction;
            }
            set
            {
                selectOnDeactivatedAction = value;
            }
        }
        #endregion

        /// <summary>
        /// Configures the target validity based on the facade settings.
        /// </summary>
        public virtual void ConfigureTargetValidity()
        {
            Caster.TargetValidity = Facade.TargetValidity;
        }

        /// <summary>
        /// Configures the target point validity based on the facade settings.
        /// </summary>
        public virtual void ConfigureTargetPointValidity()
        {
            Caster.TargetPointValidity = Facade.TargetPointValidity;
        }

        /// <summary>
        /// Configures the physics RayCast rules based on the facade settings.
        /// </summary>
        public virtual void ConfigureRaycastRules()
        {
            Caster.PhysicsCast = Facade.RaycastRules;
        }

        /// <summary>
        /// Configures the cursor lock threshold based on the facade settings.
        /// </summary>
        public virtual void ConfigureCursorLockThreshold()
        {
            Caster.CursorLockThreshold = Facade.CursorLockThreshold;
        }

        /// <summary>
        /// Configures the transition duration based on the facade settings.
        /// </summary>
        public virtual void ConfigureTransitionDuration()
        {
            Caster.TransitionDuration = Facade.TransitionDuration;
        }

        /// <summary>
        /// Configures the object follow sources based on the facade settings.
        /// </summary>
        public virtual void ConfigureFollowSources()
        {
            ObjectFollow.Sources.RunWhenActiveAndEnabled(() => SetFollowSource());
        }

        /// <summary>
        /// Configures the selection action on the facade settings.
        /// </summary>
        public virtual void ConfigureSelectionAction()
        {
            SelectOnActivatedAction.RunWhenActiveAndEnabled(() => SetSelectionAction());
        }

        /// <summary>
        /// Configures the activation action based on the facade settings.
        /// </summary>
        public virtual void ConfigureActivationAction()
        {
            ActivationAction.RunWhenActiveAndEnabled(() => SetActivationAction());
        }

        /// <summary>
        /// Configures the selection type based on the facade settings.
        /// </summary>
        public virtual void ConfigureSelectionType()
        {
            ActivationAction.gameObject.SetActive(false);
            switch (Facade.SelectionMethod)
            {
                case PointerFacade.SelectionType.SelectOnActivate:
                    SelectOnActivatedAction.gameObject.SetActive(true);
                    SelectOnDeactivatedAction.gameObject.SetActive(false);
                    break;
                case PointerFacade.SelectionType.SelectOnDeactivate:
                    SelectOnActivatedAction.gameObject.SetActive(false);
                    SelectOnDeactivatedAction.gameObject.SetActive(true);
                    break;
            }
            ConfigureSelectionAction();
            ConfigureActivationAction();
            ActivationAction.gameObject.SetActive(true);
        }

        /// <summary>
        /// Emits the Activated event.
        /// </summary>
        /// <param name="eventData">The data to emit.</param>
        public virtual void EmitActivated(ObjectPointer.EventData eventData)
        {
            Facade.Activated?.Invoke(eventData);
        }

        /// <summary>
        /// Emits the Deactivated event.
        /// </summary>
        /// <param name="eventData">The data to emit.</param>
        public virtual void EmitDeactivated(ObjectPointer.EventData eventData)
        {
            Facade.Deactivated?.Invoke(eventData);
        }

        /// <summary>
        /// Emits the Entered event.
        /// </summary>
        /// <param name="eventData">The data to emit.</param>
        public virtual void EmitEntered(ObjectPointer.EventData eventData)
        {
            if (!IsValidHover(eventData))
            {
                return;
            }

            Facade.Entered?.Invoke(eventData);
        }

        /// <summary>
        /// Emits the Exited event.
        /// </summary>
        /// <param name="eventData">The data to emit.</param>
        public virtual void EmitExited(ObjectPointer.EventData eventData)
        {
            if (!IsValidHover(eventData))
            {
                return;
            }

            Facade.Exited?.Invoke(eventData);
        }

        /// <summary>
        /// Emits the HoverChanged event.
        /// </summary>
        /// <param name="eventData">The data to emit.</param>
        public virtual void EmitHoverChanged(ObjectPointer.EventData eventData)
        {
            if (!IsValidHover(eventData))
            {
                return;
            }

            Facade.HoverChanged?.Invoke(eventData);
        }

        /// <summary>
        /// Emits the Selected event.
        /// </summary>
        /// <param name="eventData">The data to emit.</param>
        public virtual void EmitSelected(ObjectPointer.EventData eventData)
        {
            Facade.Selected?.Invoke(eventData);
        }

        protected virtual void OnEnable()
        {
            ConfigureTargetValidity();
            ConfigureTargetPointValidity();
            ConfigureRaycastRules();
            ConfigureFollowSources();
            ConfigureSelectionType();
            ConfigureCursorLockThreshold();
            ConfigureTransitionDuration();
        }

        /// <summary>
        /// Sets the follow source.
        /// </summary>
        protected virtual void SetFollowSource()
        {
            ObjectFollow.Sources.Clear();
            if (Facade.FollowSource != null)
            {
                ObjectFollow.Sources.Add(Facade.FollowSource);
            }
        }

        /// <summary>
        /// Sets the activation action.
        /// </summary>
        protected virtual void SetActivationAction()
        {
            ActivationAction.ClearSources();
            if (Facade.ActivationAction != null)
            {
                ActivationAction.AddSource(Facade.ActivationAction);
            }
        }

        /// <summary>
        /// Sets the selection action.
        /// </summary>
        protected virtual void SetSelectionAction()
        {
            SelectOnActivatedAction.ClearSources();
            SelectOnDeactivatedAction.ClearSources();
            if (Facade.SelectionAction != null)
            {
                SelectOnActivatedAction.AddSource(Facade.SelectionAction);
                SelectOnDeactivatedAction.AddSource(Facade.SelectionAction);
            }
        }

        /// <summary>
        /// Determines whether the current event data is hovering over a valid target.
        /// </summary>
        /// <param name="eventData">The hover data.</param>
        /// <returns>Whether the hover data is valid.</returns>
        protected virtual bool IsValidHover(ObjectPointer.EventData eventData)
        {
            return eventData != null &&
                eventData.CurrentPointsCastData != null &&
                eventData.CurrentPointsCastData.HitData != null &&
                eventData.CurrentPointsCastData.HitData.Value.transform != null &&
                Facade.HoverValidity.Accepts(eventData.CurrentPointsCastData.HitData.Value.transform.gameObject);
        }
    }
}