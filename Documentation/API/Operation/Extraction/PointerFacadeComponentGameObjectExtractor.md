# Class PointerFacadeComponentGameObjectExtractor

Extracts and emits the selected Component residing GameObject from the Source.

##### Inheritance

* System.Object
* PointerFacadeComponentGameObjectExtractor

###### **Namespace**: [Tilia.Indicators.ObjectPointers.Operation.Extraction]

##### Syntax

```
public class PointerFacadeComponentGameObjectExtractor : ComponentGameObjectExtractor
```

### Properties

#### PointerComponent

The [PointerFacadeComponentGameObjectExtractor.PointerComponentType] to extract from the Source.

##### Declaration

```
public PointerFacadeComponentGameObjectExtractor.PointerComponentType PointerComponent { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [PointerFacadeComponentGameObjectExtractor.PointerComponentType] | n/a |

### Methods

#### ExtractValue()

##### Declaration

```
protected override GameObject ExtractValue()
```

##### Returns

| Type | Description |
| --- | --- |
| GameObject | n/a |

#### SetSource(GameObject)

Sets the Source based on a given GameObject.

##### Declaration

```
public virtual void SetSource(GameObject source)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| GameObject | source | The data that contains the [PointerFacade] component. |

[Tilia.Indicators.ObjectPointers.Operation.Extraction]: README.md
[PointerFacadeComponentGameObjectExtractor.PointerComponentType]: PointerFacadeComponentGameObjectExtractor.PointerComponentType.md
[PointerFacadeComponentGameObjectExtractor.PointerComponentType]: PointerFacadeComponentGameObjectExtractor.PointerComponentType.md
[PointerFacade]: Tilia.Indicators.ObjectPointers.PointerFacade.md