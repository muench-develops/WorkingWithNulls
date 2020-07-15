# WorkingWithNulls

## Reference and Value Types

---

Value Type: An object by itself\
Reference Type: Points to an object\

| Value Type                                   | Reference Type                      |
| -------------------------------------------- | ----------------------------------- |
| C# struct                                    | C# class                            |
| Independet copies                            | Single shared instance              |
| Changing value does not affect other objects | Changing value affects all pointers |
| Holding information                          | Points to information               |

---

- Value types cannot be null, but reference types can be null.

If you want to use Value types with null, there are two ways for doing that:

- "Magic Numbers" : fixed values for representing null
- Nullable\<T>
