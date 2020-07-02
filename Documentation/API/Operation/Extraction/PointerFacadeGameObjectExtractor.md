# Class PointerFacadeGameObjectExtractor

Extracts and emits the GameObject found in relation to the Source.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Methods]
  * [DoExtract(ObjectPointer.EventData)]
  * [DoExtract(SurfaceData)]
  * [Extract(ObjectPointer.EventData)]
  * [Extract(SurfaceData)]
  * [ExtractValue()]
  * [SetSource(ObjectPointer.EventData)]
  * [SetSource(SurfaceData)]

## Details

##### Inheritance

* System.Object
* PointerFacadeGameObjectExtractor

##### Namespace

* [Tilia.Indicators.ObjectPointers.Operation.Extraction]

##### Syntax

```
public class PointerFacadeGameObjectExtractor : ComponentGameObjectExtractor
```

### Methods

#### DoExtract(ObjectPointer.EventData)

Extracts the Source GameObject from the given ObjectPointer.EventData payload data.

##### Declaration

```
public virtual void DoExtract(ObjectPointer.EventData data)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| ObjectPointer.EventData | data | The ObjectPointer.EventData payload data to extract from. |

#### DoExtract(SurfaceData)

Extracts the Source GameObject from the given SurfaceData payload data.

##### Declaration

```
public virtual void DoExtract(SurfaceData data)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| SurfaceData | data | The SurfaceData payload data to extract from. |

#### Extract(ObjectPointer.EventData)

Extracts the Source GameObject from the given ObjectPointer.EventData payload data.

##### Declaration

```
public virtual GameObject Extract(ObjectPointer.EventData data)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| ObjectPointer.EventData | data | The ObjectPointer.EventData payload data to extract from. |

##### Returns

| Type | Description |
| --- | --- |
| GameObject | The Source GameObject within the ObjectPointer.EventData. |

#### Extract(SurfaceData)

Extracts the Source GameObject from the given SurfaceData payload data.

##### Declaration

```
public virtual GameObject Extract(SurfaceData data)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| SurfaceData | data | The SurfaceData payload data to extract from. |

##### Returns

| Type | Description |
| --- | --- |
| GameObject | The Source GameObject within the SurfaceData. |

#### ExtractValue()

##### Declaration

```
protected override GameObject ExtractValue()
```

##### Returns

| Type | Description |
| --- | --- |
| GameObject | n/a |

#### SetSource(ObjectPointer.EventData)

Sets the Source based on given ObjectPointer.EventData.

##### Declaration

```
public virtual void SetSource(ObjectPointer.EventData source)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| ObjectPointer.EventData | source | The data that contains the source transform. |

#### SetSource(SurfaceData)

Sets the Source based on given SurfaceData.

##### Declaration

```
public virtual void SetSource(SurfaceData source)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| SurfaceData | source | The data that contains the source transform. |

[Tilia.Indicators.ObjectPointers.Operation.Extraction]: README.md
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Methods]: #Methods
[DoExtract(ObjectPointer.EventData)]: #DoExtractObjectPointer.EventData
[DoExtract(SurfaceData)]: #DoExtractSurfaceData
[Extract(ObjectPointer.EventData)]: #ExtractObjectPointer.EventData
[Extract(SurfaceData)]: #ExtractSurfaceData
[ExtractValue()]: #ExtractValue
[SetSource(ObjectPointer.EventData)]: #SetSourceObjectPointer.EventData
[SetSource(SurfaceData)]: #SetSourceSurfaceData
