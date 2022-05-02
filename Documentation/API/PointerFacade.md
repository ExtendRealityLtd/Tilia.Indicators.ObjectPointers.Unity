# Class PointerFacade

The public interface into the Pointer Prefab.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Fields]
  * [Activated]
  * [Deactivated]
  * [Entered]
  * [Exited]
  * [HoverChanged]
  * [Selected]
* [Properties]
  * [ActivationAction]
  * [Configuration]
  * [FollowSource]
  * [HoverValidity]
  * [RaycastRules]
  * [SelectionAction]
  * [SelectionMethod]
  * [TargetPointValidity]
  * [TargetValidity]
* [Methods]
  * [Activate()]
  * [ClearActivationAction()]
  * [ClearFollowSource()]
  * [ClearRaycastRules()]
  * [ClearSelectionAction()]
  * [ClearTargetPointValidity()]
  * [ClearTargetValidity()]
  * [Deactivate()]
  * [OnAfterActivationActionChange()]
  * [OnAfterFollowSourceChange()]
  * [OnAfterRaycastRulesChange()]
  * [OnAfterSelectionActionChange()]
  * [OnAfterSelectionMethodChange()]
  * [OnAfterTargetPointValidityChange()]
  * [OnAfterTargetValidityChange()]
  * [Select()]
  * [SetSelectionMethod(Int32)]

## Details

##### Inheritance

* System.Object
* PointerFacade

##### Namespace

* [Tilia.Indicators.ObjectPointers]

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

#### Deactivated

Emitted when the ObjectPointer is deactivated.

##### Declaration

```
public ObjectPointer.UnityEvent Deactivated
```

#### Entered

Emitted when the ObjectPointer collides with a new target.

##### Declaration

```
public ObjectPointer.UnityEvent Entered
```

#### Exited

Emitted when the ObjectPointer stops colliding with an existing target.

##### Declaration

```
public ObjectPointer.UnityEvent Exited
```

#### HoverChanged

Emitted when the ObjectPointer changes its hovering position over an existing target.

##### Declaration

```
public ObjectPointer.UnityEvent HoverChanged
```

#### Selected

Emitted whenever ObjectPointer.Select is called.

##### Declaration

```
public ObjectPointer.UnityEvent Selected
```

### Properties

#### ActivationAction

The BooleanAction that will activate/deactivate the pointer.

##### Declaration

```
public BooleanAction ActivationAction { get; set; }
```

#### Configuration

The linked Internal Setup.

##### Declaration

```
public PointerConfigurator Configuration { get; protected set; }
```

#### FollowSource

The source for the pointer origin to follow.

##### Declaration

```
public GameObject FollowSource { get; set; }
```

#### HoverValidity

Allows to optionally determine targets based on the set rules.

##### Declaration

```
public RuleContainer HoverValidity { get; set; }
```

#### RaycastRules

Allows to optionally define the rules for the RayCast of the pointer beam elements.

##### Declaration

```
public PhysicsCast RaycastRules { get; set; }
```

#### SelectionAction

The BooleanAction that initiates the pointer selection.

##### Declaration

```
public BooleanAction SelectionAction { get; set; }
```

#### SelectionMethod

The action moment when to initiate the select action.

##### Declaration

```
public PointerFacade.SelectionType SelectionMethod { get; set; }
```

#### TargetPointValidity

Allows to optionally determine a specific selection target point based on the set rules.

##### Declaration

```
public RuleContainer TargetPointValidity { get; set; }
```

#### TargetValidity

Allows to optionally determine selection targets based on the set rules.

##### Declaration

```
public RuleContainer TargetValidity { get; set; }
```

### Methods

#### Activate()

The Activate method turns on the ObjectPointer.

##### Declaration

```
public virtual void Activate()
```

#### ClearActivationAction()

Clears [ActivationAction].

##### Declaration

```
public virtual void ClearActivationAction()
```

#### ClearFollowSource()

Clears [FollowSource].

##### Declaration

```
public virtual void ClearFollowSource()
```

#### ClearRaycastRules()

Clears [RaycastRules].

##### Declaration

```
public virtual void ClearRaycastRules()
```

#### ClearSelectionAction()

Clears [SelectionAction].

##### Declaration

```
public virtual void ClearSelectionAction()
```

#### ClearTargetPointValidity()

Clears [TargetPointValidity].

##### Declaration

```
public virtual void ClearTargetPointValidity()
```

#### ClearTargetValidity()

Clears [TargetValidity].

##### Declaration

```
public virtual void ClearTargetValidity()
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

#### OnAfterTargetPointValidityChange()

Called after [TargetPointValidity] has been changed.

##### Declaration

```
protected virtual void OnAfterTargetPointValidityChange()
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

#### SetSelectionMethod(Int32)

Sets [SelectionMethod].

##### Declaration

```
public virtual void SetSelectionMethod(int selectionMethodIndex)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | selectionMethodIndex | The index of the [PointerFacade.SelectionType]. |

[Tilia.Indicators.ObjectPointers]: README.md
[PointerConfigurator]: PointerConfigurator.md
[ActivationAction]: PointerFacade.md#ActivationAction
[FollowSource]: PointerFacade.md#FollowSource
[RaycastRules]: PointerFacade.md#RaycastRules
[SelectionAction]: PointerFacade.md#SelectionAction
[TargetPointValidity]: PointerFacade.md#TargetPointValidity
[TargetValidity]: PointerFacade.md#TargetValidity
[ActivationAction]: PointerFacade.md#ActivationAction
[FollowSource]: PointerFacade.md#FollowSource
[RaycastRules]: PointerFacade.md#RaycastRules
[SelectionAction]: PointerFacade.md#SelectionAction
[SelectionMethod]: PointerFacade.md#SelectionMethod
[TargetPointValidity]: PointerFacade.md#TargetPointValidity
[TargetValidity]: PointerFacade.md#TargetValidity
[Selected]: PointerFacade.md#Selected
[SelectionMethod]: PointerFacade.md#SelectionMethod
[PointerFacade.SelectionType]: PointerFacade.SelectionType.md
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Fields]: #Fields
[Activated]: #Activated
[Deactivated]: #Deactivated
[Entered]: #Entered
[Exited]: #Exited
[HoverChanged]: #HoverChanged
[Selected]: #Selected
[Properties]: #Properties
[ActivationAction]: #ActivationAction
[Configuration]: #Configuration
[FollowSource]: #FollowSource
[HoverValidity]: #HoverValidity
[RaycastRules]: #RaycastRules
[SelectionAction]: #SelectionAction
[SelectionMethod]: #SelectionMethod
[TargetPointValidity]: #TargetPointValidity
[TargetValidity]: #TargetValidity
[Methods]: #Methods
[Activate()]: #Activate
[ClearActivationAction()]: #ClearActivationAction
[ClearFollowSource()]: #ClearFollowSource
[ClearRaycastRules()]: #ClearRaycastRules
[ClearSelectionAction()]: #ClearSelectionAction
[ClearTargetPointValidity()]: #ClearTargetPointValidity
[ClearTargetValidity()]: #ClearTargetValidity
[Deactivate()]: #Deactivate
[OnAfterActivationActionChange()]: #OnAfterActivationActionChange
[OnAfterFollowSourceChange()]: #OnAfterFollowSourceChange
[OnAfterRaycastRulesChange()]: #OnAfterRaycastRulesChange
[OnAfterSelectionActionChange()]: #OnAfterSelectionActionChange
[OnAfterSelectionMethodChange()]: #OnAfterSelectionMethodChange
[OnAfterTargetPointValidityChange()]: #OnAfterTargetPointValidityChange
[OnAfterTargetValidityChange()]: #OnAfterTargetValidityChange
[Select()]: #Select
[SetSelectionMethod(Int32)]: #SetSelectionMethodInt32
