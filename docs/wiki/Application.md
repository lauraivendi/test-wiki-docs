<a name='assembly'></a>
# Application

## Contents

- [SomeClass](#T-Application-SomeClass 'Application.SomeClass')
  - [SomeFunction(parameter1,parameter2)](#M-Application-SomeClass-SomeFunction-System-String,System-Double- 'Application.SomeClass.SomeFunction(System.String,System.Double)')
  - [SomeOtherFunction(parameter1,parameter2)](#M-Application-SomeClass-SomeOtherFunction-System-Int32,System-Single- 'Application.SomeClass.SomeOtherFunction(System.Int32,System.Single)')

<a name='T-Application-SomeClass'></a>
## SomeClass `type`

##### Namespace

Application

##### Summary

This is some class

<a name='M-Application-SomeClass-SomeFunction-System-String,System-Double-'></a>
### SomeFunction(parameter1,parameter2) `method`

##### Summary

Some function with params `parameter1` and `parameter2`.

##### Returns

void.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| parameter1 | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A string. |
| parameter2 | [System.Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') | A double. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.OverflowException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.OverflowException 'System.OverflowException') | Thrown when one parameter is max
and the other is greater than 0. |

##### Example

```
SomeFunction("some string", 123.45);
```

<a name='M-Application-SomeClass-SomeOtherFunction-System-Int32,System-Single-'></a>
### SomeOtherFunction(parameter1,parameter2) `method`

##### Summary

Some function with params `parameter1` and `parameter2`.

##### Returns

void.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| parameter1 | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | An int. |
| parameter2 | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | A float. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.OverflowException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.OverflowException 'System.OverflowException') | Thrown when one parameter is max
and the other is greater than 0. |

##### Example

```
SomeFunction(3, 123.45);
```
