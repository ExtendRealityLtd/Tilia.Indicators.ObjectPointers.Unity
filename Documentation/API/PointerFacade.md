# Class PointerFacade

The public interface into the Pointer Prefab.

##### Inheritance

* System.Object
* PointerFacade

###### **Namespace**: [Tilia.Indicators.ObjectPointers]

##### Syntax

```
public class PointerFacade : MonoBehaviour
```

### Fields

#### Activated

Emitted when the ObjectPointer becomes active.

##### Declaration

```
public ObjectPointer.UnityEvent Activated
```

##### Field Value

| Type | Description |
| --- | --- |
| ObjectPointer.UnityEvent | n/a |

#### Deactivated

Emitted when the ObjectPointer is deactivated.

##### Declaration

```
public ObjectPointer.UnityEvent Deactivated
```

##### Field Value

| Type | Description |
| --- | --- |
| ObjectPointer.UnityEvent | n/a |

#### Entered

Emitted when the ObjectPointer collides with a new target.

##### Declaration

```
public ObjectPointer.UnityEvent Entered
```

##### Field Value

| Type | Description |
| --- | --- |
| ObjectPointer.UnityEvent | n/a |

#### Exited

Emitted when the ObjectPointer stops colliding with an existing target.

##### Declaration

```
public ObjectPointer.UnityEvent Exited
```

##### Field Value

| Type | Description |
| --- | --- |
| ObjectPointer.UnityEvent | n/a |

#### HoverChanged

Emitted when the ObjectPointer changes its hovering position over an existing target.

##### Declaration

```
public ObjectPointer.UnityEvent HoverChanged
```

##### Field Value

| Type | Description |
| --- | --- |
| ObjectPointer.UnityEvent | n/a |

#### Selected

Emitted whenever ObjectPointer.Select is called.

##### Declaration

```
public ObjectPointer.UnityEvent Selected
```

##### Field Value

| Type | Description |
| --- | --- |
| ObjectPointer.UnityEvent | n/a |

### Properties

#### ActivationAction

The BooleanAction that will activate/deactivate the pointer.

##### Declaration

```
public BooleanAction ActivationAction { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| BooleanAction | n/a |

#### Configuration

The linked Internal Setup.

##### Declaration

```
public PointerConfigurator Configuration { get; protected set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [PointerConfigurator] | n/a |

#### FollowSource

The source for the pointer origin to follow.

##### Declaration

```
public GameObject FollowSource { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| GameObject | n/a |

#### RaycastRules

Allows to optionally define the rules for the raycast of the pointer beam elements.

##### Declaration

```
public PhysicsCast RaycastRules { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| PhysicsCast | n/a |

#### SelectionAction

The BooleanAction that initiates the pointer selection.

##### Declaration

```
public BooleanAction SelectionAction { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| BooleanAction | n/a |

#### SelectionMethod

The action moment when to initiate the select action.

##### Declaration

```
public PointerFacade.SelectionType SelectionMethod { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [PointerFacade.SelectionType] | n/a |

#### TargetValidity

Allows to optionally determine targets based on the set rules.

##### Declaration

```
public RuleContainer TargetValidity { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| RuleContainer | n/a |

### Methods

#### Activate()

The Activate method turns on the ObjectPointer.

##### Declaration

```
public virtual void Activate()
```

#### Deactivate()

The Deactivate method turns off the ObjectPointer.

##### Declaration

```
public virtual void Deactivate()
```

#### OnAfterActivationActionChange()

Called after [ActivationAction] has been changed.

##### Declaration

```
protected virtual void OnAfterActivationActionChange()
```

#### OnAfterFollowSourceChange()

Called after [FollowSource] has been changed.

##### Declaration

```
protected virtual void OnAfterFollowSourceChange()
```

#### OnAfterRaycastRulesChange()

Called after [RaycastRules] has been changed.

##### Declaration

```
protected virtual void OnAfterRaycastRulesChange()
```

#### OnAfterSelectionActionChange()

Called after [SelectionAction] has been changed.

##### Declaration

```
protected virtual void OnAfterSelectionActionChange()
```

#### OnAfterSelectionMethodChange()

Called after [SelectionMethod] has been changed.

##### Declaration

```
protected virtual void OnAfterSelectionMethodChange()
```

#### OnAfterTargetValidityChange()

Called after [TargetValidity] has been changed.

##### Declaration

```
protected virtual void OnAfterTargetValidityChange()
```

#### Select()

Gets the current ObjectPointer state and emits it through [Selected].

##### Declaration

```
public virtual void Select()
```

[Tilia.Indicators.ObjectPointers]: README.md
[PointerConfigurator]: PointerConfigurator.md
[PointerFacade.SelectionType]: PointerFacade.SelectionType.md
[ActivationAction]: PointerFacade.md#ActivationAction
[FollowSource]: PointerFacade.md#FollowSource
[RaycastRules]: PointerFacade.md#RaycastRules
[SelectionAction]: PointerFacade.md#SelectionAction
[SelectionMethod]: PointerFacade.md#SelectionMethod
[TargetValidity]: PointerFacade.md#TargetValidity
[Selected]: PointerFacade.md#Selected