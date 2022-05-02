# Class PointerConfigurator

Sets up the Pointer Prefab based on the provided user settings.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Properties]
  * [ActivationAction]
  * [Caster]
  * [Facade]
  * [ObjectFollow]
  * [ObjectPointer]
  * [SelectOnActivatedAction]
  * [SelectOnDeactivatedAction]
* [Methods]
  * [ConfigureActivationAction()]
  * [ConfigureFollowSources()]
  * [ConfigureRaycastRules()]
  * [ConfigureSelectionAction()]
  * [ConfigureSelectionType()]
  * [ConfigureTargetPointValidity()]
  * [ConfigureTargetValidity()]
  * [EmitActivated(ObjectPointer.EventData)]
  * [EmitDeactivated(ObjectPointer.EventData)]
  * [EmitEntered(ObjectPointer.EventData)]
  * [EmitExited(ObjectPointer.EventData)]
  * [EmitHoverChanged(ObjectPointer.EventData)]
  * [EmitSelected(ObjectPointer.EventData)]
  * [IsValidHover(ObjectPointer.EventData)]
  * [OnEnable()]

## Details

##### Inheritance

* System.Object
* PointerConfigurator

##### Namespace

* [Tilia.Indicators.ObjectPointers]

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

#### Caster

The PointsCast component for the Pointer.

##### Declaration

```
public PointsCast Caster { get; protected set; }
```

#### Facade

The public facade.

##### Declaration

```
public PointerFacade Facade { get; protected set; }
```

#### ObjectFollow

The ObjectFollower component for the Pointer.

##### Declaration

```
public ObjectFollower ObjectFollow { get; protected set; }
```

#### ObjectPointer

The [ObjectPointer] component for the Pointer.

##### Declaration

```
public ObjectPointer ObjectPointer { get; protected set; }
```

#### SelectOnActivatedAction

The BooleanAction that initiates the pointer selection when the action is activated.

##### Declaration

```
public BooleanAction SelectOnActivatedAction { get; protected set; }
```

#### SelectOnDeactivatedAction

The BooleanAction that initiates the pointer selection when the action is deactivated.

##### Declaration

```
public BooleanAction SelectOnDeactivatedAction { get; protected set; }
```

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

Configures the physics RayCast rules based on the facade settings.

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

#### ConfigureTargetPointValidity()

Configures the target point validity based on the facade settings.

##### Declaration

```
public virtual void ConfigureTargetPointValidity()
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

#### IsValidHover(ObjectPointer.EventData)

Determines whether the current event data is hovering over a valid target.

##### Declaration

```
protected virtual bool IsValidHover(ObjectPointer.EventData eventData)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| ObjectPointer.EventData | eventData | The hover data. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | Whether the hover data is valid. |

#### OnEnable()

##### Declaration

```
protected virtual void OnEnable()
```

[Tilia.Indicators.ObjectPointers]: README.md
[PointerFacade]: PointerFacade.md
[ObjectPointer]: PointerConfigurator.md#ObjectPointer
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Properties]: #Properties
[ActivationAction]: #ActivationAction
[Caster]: #Caster
[Facade]: #Facade
[ObjectFollow]: #ObjectFollow
[ObjectPointer]: #ObjectPointer
[SelectOnActivatedAction]: #SelectOnActivatedAction
[SelectOnDeactivatedAction]: #SelectOnDeactivatedAction
[Methods]: #Methods
[ConfigureActivationAction()]: #ConfigureActivationAction
[ConfigureFollowSources()]: #ConfigureFollowSources
[ConfigureRaycastRules()]: #ConfigureRaycastRules
[ConfigureSelectionAction()]: #ConfigureSelectionAction
[ConfigureSelectionType()]: #ConfigureSelectionType
[ConfigureTargetPointValidity()]: #ConfigureTargetPointValidity
[ConfigureTargetValidity()]: #ConfigureTargetValidity
[EmitActivated(ObjectPointer.EventData)]: #EmitActivatedObjectPointer.EventData
[EmitDeactivated(ObjectPointer.EventData)]: #EmitDeactivatedObjectPointer.EventData
[EmitEntered(ObjectPointer.EventData)]: #EmitEnteredObjectPointer.EventData
[EmitExited(ObjectPointer.EventData)]: #EmitExitedObjectPointer.EventData
[EmitHoverChanged(ObjectPointer.EventData)]: #EmitHoverChangedObjectPointer.EventData
[EmitSelected(ObjectPointer.EventData)]: #EmitSelectedObjectPointer.EventData
[IsValidHover(ObjectPointer.EventData)]: #IsValidHoverObjectPointer.EventData
[OnEnable()]: #OnEnable
