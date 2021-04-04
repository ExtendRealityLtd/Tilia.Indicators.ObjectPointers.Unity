# Adding A Straight Pointer

> * Level: Beginner
>
> * Reading Time: 5 minutes
>
> * Checked with: Unity 2018.3.14f1

## Introduction

The Straight Pointer prefab casts a straight line from an origin point to the maximum specified length or until the Pointer beam collides with a valid target.

When a Straight Pointer is colliding with a valid GameObject, a Selection Action can occur which emits an event containing data about the GameObject that the Straight Pointer is currently colliding with.

A Straight Pointer is useful for picking out a location with precision, especially when attached to a controller.

We’ll set up a Straight Pointer on a controller that can be activated and deactivated on a button press.

## Prerequisites

* [Add the Tilia.CameraRigs.SpatialSimulator.Unity -> CameraRigs.SpatialSimulator] prefab to the scene hierarchy.
* [Add the Tilia.Input.UnityInputManager -> Input.UnityInputManager.ButtonAction] prefab to the scene hierarchy.
* [Install the Tilia.Indicators.ObjectPointers.Unity] package dependency in to your [Unity] project.

## Let's Start

### Step 1

Add a `Indicators.ObjectPointers.Straight` prefab to the Unity project hierarchy by selecting `GameObject -> Tilia -> Prefabs -> Indicators -> ObjectPointers-> Indicators.ObjectPointers.Straight` from the Unity main top menu.

### Step 2

The `Follow Source` property on the `Pointer Facade` component determines what GameObject the Pointer should follow in the scene.

If we want the Pointer to follow the Right Controller GameObject then we drag and drop the `CameraRigs.TrackedAlias -> Aliases -> RightControllerAlias` GameObject into the `Follow Source` property on the `Pointer Facade` component within the `Indicators.ObjectPointers.Straight` GameObject.

![Drag And Drop Right Controller Alias As Pointer Follow Source](assets/images/DragAndDropRightControllerAliasAsPointerFollowSource.png)

### Step 3

The Straight Pointer will be deactivated by default so we need a way of activating and deactivating the Pointer beam. This is done by hooking up a `Boolean Action` that will activate the Pointer when it emits `true` and deactivate the Pointer when it emits `false`.

Any `Boolean Action` can be used to perform the activation/deactivation of the Pointer but in this instance we’re going to use the `Input.UnityInputManager.ButtonAction` that is already in the scene. The existing `Boolean Action` will emit `true` when the `Space` key is pressed and will emit `false` when the `Space` key is released.

Drag and drop the `Input.UnityInputManager.ButtonAction` GameObject into the `Activation Action` property on the `Pointer Facade` component.

![Drag And Drop Boolean Action Onto Activation Action](assets/images/DragAndDropBooleanActionOntoActivationAction.png)

### Done

We won’t use any of the other `Pointer Facade` properties for now as we have all we need for a Straight Pointer to be activated when the `Space` key is pressed and it will point in a straight line in whatever direction the Right Controller is pointing.

Play the Unity scene and press the `Space` key and the Straight Pointer will emit a beam from the controller pointing in the forward direction of the controller. Notice how the Straight Pointer beam has two states when it is activated:

* `Valid Collision` - The Straight Pointer is colliding with a valid GameObject and displays as a green line.
* `Invalid/No Collision` - The Straight Pointer is not colliding with any valid GameObject and displays as a red line.

![Straight Pointer Activated In Scene](assets/images/StraightPointerActivatedInScene.png)

[Add the Tilia.CameraRigs.SpatialSimulator.Unity -> CameraRigs.SpatialSimulator]: https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/blob/master/Documentation/HowToGuides/AddingATrackedAlias/README.md
[Add the Tilia.Input.UnityInputManager -> Input.UnityInputManager.ButtonAction]: https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputManager/blob/master/Documentation/HowToGuides/UsingTheUnityButtonAction/README.md
[Install the Tilia.Indicators.ObjectPointers.Unity]: ../Installation/README.md
[Unity]: https://unity3d.com/