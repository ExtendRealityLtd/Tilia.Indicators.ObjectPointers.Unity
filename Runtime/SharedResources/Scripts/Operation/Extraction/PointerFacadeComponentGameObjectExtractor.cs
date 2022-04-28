namespace Tilia.Indicators.ObjectPointers.Operation.Extraction
{
    using UnityEngine;
    using Zinnia.Cast;
    using Zinnia.Data.Operation.Extraction;
    using Zinnia.Extension;
    using Zinnia.Pointer;

    /// <summary>
    /// Extracts and emits the selected <see cref="Component"/> residing <see cref="GameObject"/> from the <see cref="Source"/>.
    /// </summary>
    public class PointerFacadeComponentGameObjectExtractor : ComponentGameObjectExtractor
    {
        /// <summary>
        /// The Pointer Component to be extracted.
        /// </summary>
        public enum PointerComponentType
        {
            /// <summary>
            /// The pointer <see cref="PointsCast"/>.
            /// </summary>
            Caster,
            /// <summary>
            /// The <see cref="PointerElement"/> that represents the Origin.
            /// </summary>
            PointerElementOrigin,
            /// <summary>
            /// The <see cref="PointerElement"/> that represents the Repeated Segment.
            /// </summary>
            PointerElementRepeatedSegment,
            /// <summary>
            /// The <see cref="PointerElement"/> that represents the Destination.
            /// </summary>
            PointerElementDestination
        }

        [Tooltip("The PointerComponentType to extract from the Source.")]
        [SerializeField]
        private PointerComponentType pointerComponent = PointerComponentType.Caster;
        /// <summary>
        /// The <see cref="PointerComponentType"/> to extract from the <see cref="Source"/>.
        /// </summary>
        public PointerComponentType PointerComponent
        {
            get
            {
                return pointerComponent;
            }
            set
            {
                pointerComponent = value;
            }
        }

        /// <inheritdoc />
        protected override GameObject ExtractValue()
        {
            if (Source == null || Source.GetType() != typeof(PointerFacade))
            {
                return null;
            }

            PointerFacade pointerSource = (PointerFacade)Source;

            switch (PointerComponent)
            {
                case PointerComponentType.Caster:
                    return pointerSource.Configuration.Caster.gameObject;
                case PointerComponentType.PointerElementOrigin:
                    return pointerSource.Configuration.ObjectPointer.Origin.gameObject;
                case PointerComponentType.PointerElementRepeatedSegment:
                    return pointerSource.Configuration.ObjectPointer.RepeatedSegment.gameObject;
                case PointerComponentType.PointerElementDestination:
                    return pointerSource.Configuration.ObjectPointer.Destination.gameObject;
                default:
                    return null;
            }
        }

        /// <summary>
        /// Sets the <see cref="Source"/> based on a given <see cref="GameObject"/>.
        /// </summary>
        /// <param name="source">The data that contains the <see cref="PointerFacade"/> component.</param>
        public virtual void SetSource(GameObject source)
        {
            if (!this.IsValidState())
            {
                return;
            }

            Source = source.TryGetComponent<PointerFacade>();
        }
    }
}