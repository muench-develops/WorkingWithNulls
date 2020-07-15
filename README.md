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

---

## String and Null Value

---

- String is a reference type
- String can be set to null, empty or only whitespace
- You can use the methods: string.isNullOrEmpty or string.isNullOrWhiteSpace to check rather a string is empty, null or only whitespaces

---

## Nullable\<T>

---

- With .HasValue we can check if a value is given
- With .Value we can get the value
- With .GetValueOrDefault() we can get the value or set an default value if the value is null

### Conversion (implicit and explicit)

- You can convert from T into Nullable\<T> without futher problems, because you can't loose any dataa from the concersion:

```csharp
int i = 42;
int? j = i;
```

- But if you try:

```csharp
int? i = 42;
int j = i; //Error, because you can loose data

//you need to cast explicit:
int g = (int) i; // No error should appear
```
