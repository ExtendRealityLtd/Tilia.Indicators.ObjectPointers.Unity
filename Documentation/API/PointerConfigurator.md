# Class PointerConfigurator

Sets up the Pointer Prefab based on the provided user settings.

##### Inheritance

* System.Object
* PointerConfigurator

###### **Namespace**: [Tilia.Indicators.ObjectPointers]

##### Syntax

```
public class PointerConfigurator : MonoBehaviour
```

### Properties

#### ActivationAction

The BooleanAction that will activate/deactivate the pointer.

##### Declaration

```
public BooleanAction ActivationAction { get; protected set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| BooleanAction | n/a |

#### Caster

The PointsCast component for the Pointer.

##### Declaration

```
public PointsCast Caster { get; protected set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| PointsCast | n/a |

#### Facade

The public facade.

##### Declaration

```
public PointerFacade Facade { get; protected set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [PointerFacade] | n/a |

#### ObjectFollow

The ObjectFollower component for the Pointer.

##### Declaration

```
public ObjectFollower ObjectFollow { get; protected set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| ObjectFollower | n/a |

#### ObjectPointer

The [ObjectPointer] component for the Pointer.

##### Declaration

```
public ObjectPointer ObjectPointer { get; protected set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| ObjectPointer | n/a |

#### SelectOnActivatedAction

The BooleanAction that initiates the pointer selection when the action is activated.

##### Declaration

```
public BooleanAction SelectOnActivatedAction { get; protected set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| BooleanAction | n/a |

#### SelectOnDeactivatedAction

The BooleanAction that initiates the pointer selection when the action is deactivated.

##### Declaration

```
public BooleanAction SelectOnDeactivatedAction { get; protected set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| BooleanAction | n/a |

### Methods

#### ConfigureActivationAction()

Configures the activation action based on the facade settings.

##### Declaration

```
public virtual void ConfigureActivationAction()
```

#### ConfigureFollowSources()

Configures the object follow sources based on the facade settings.

##### Declaration

```
public virtual void ConfigureFollowSources()
```

#### ConfigureRaycastRules()

Configures the physics raycast rules based on the facade settings.

##### Declaration

```
public virtual void ConfigureRaycastRules()
```

#### ConfigureSelectionAction()

Configures the selection action on the facade settings.

##### Declaration

```
public virtual void ConfigureSelectionAction()
```

#### ConfigureSelectionType()

Configures the selection type based on the facade settings.

##### Declaration

```
public virtual void ConfigureSelectionType()
```

#### ConfigureTargetValidity()

Configures the target validity based on the facade settings.

##### Declaration

```
public virtual void ConfigureTargetValidity()
```

#### EmitActivated(ObjectPointer.EventData)

Emits the Activated event.

##### Declaration

```
public virtual void EmitActivated(ObjectPointer.EventData eventData)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| ObjectPointer.EventData | eventData | The data to emit. |

#### EmitDeactivated(ObjectPointer.EventData)

Emits the Deactivated event.

##### Declaration

```
public virtual void EmitDeactivated(ObjectPointer.EventData eventData)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| ObjectPointer.EventData | eventData | The data to emit. |

#### EmitEntered(ObjectPointer.EventData)

Emits the Entered event.

##### Declaration

```
public virtual void EmitEntered(ObjectPointer.EventData eventData)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| ObjectPointer.EventData | eventData | The data to emit. |

#### EmitExited(ObjectPointer.EventData)

Emits the Exited event.

##### Declaration

```
public virtual void EmitExited(ObjectPointer.EventData eventData)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| ObjectPointer.EventData | eventData | The data to emit. |

#### EmitHoverChanged(ObjectPointer.EventData)

Emits the HoverChanged event.

##### Declaration

```
public virtual void EmitHoverChanged(ObjectPointer.EventData eventData)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| ObjectPointer.EventData | eventData | The data to emit. |

#### EmitSelected(ObjectPointer.EventData)

Emits the Selected event.

##### Declaration

```
public virtual void EmitSelected(ObjectPointer.EventData eventData)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| ObjectPointer.EventData | eventData | The data to emit. |

#### OnEnable()

##### Declaration

```
protected virtual void OnEnable()
```

[Tilia.Indicators.ObjectPointers]: README.md
[PointerFacade]: PointerFacade.md
[ObjectPointer]: PointerConfigurator.md#ObjectPointer