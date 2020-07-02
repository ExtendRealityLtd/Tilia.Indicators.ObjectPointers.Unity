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
  * [RaycastRules]
  * [SelectionAction]
  * [SelectionMethod]
  * [TargetValidity]
* [Methods]
  * [Activate()]
  * [Deactivate()]
  * [OnAfterActivationActionChange()]
  * [OnAfterFollowSourceChange()]
  * [OnAfterRaycastRulesChange()]
  * [OnAfterSelectionActionChange()]
  * [OnAfterSelectionMethodChange()]
  * [OnAfterTargetValidityChange()]
  * [Select()]

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

#### RaycastRules

Allows to optionally define the rules for the raycast of the pointer beam elements.

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

#### TargetValidity

Allows to optionally determine targets based on the set rules.

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
[RaycastRules]: #RaycastRules
[SelectionAction]: #SelectionAction
[SelectionMethod]: #SelectionMethod
[TargetValidity]: #TargetValidity
[Methods]: #Methods
[Activate()]: #Activate
[Deactivate()]: #Deactivate
[OnAfterActivationActionChange()]: #OnAfterActivationActionChange
[OnAfterFollowSourceChange()]: #OnAfterFollowSourceChange
[OnAfterRaycastRulesChange()]: #OnAfterRaycastRulesChange
[OnAfterSelectionActionChange()]: #OnAfterSelectionActionChange
[OnAfterSelectionMethodChange()]: #OnAfterSelectionMethodChange
[OnAfterTargetValidityChange()]: #OnAfterTargetValidityChange
[Select()]: #Select
