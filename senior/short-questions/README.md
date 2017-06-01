## Question #1:

Without modifying the Sparta class, write some code that makes MakeItReturnFalse return false.

```
public class Sparta : Place
{
    public bool MakeItReturnFalse()
    {
        return this is Sparta;
    }
}
```
Calling as following:

```
Sparta s = new Sparta();
s.MakeItReturnFalse();
```

## Solution
```
public class Place
{
    public interface Sparta { }
}
```

Source: https://stackoverflow.com/questions/44120947/this-is-sparta-or-is-it?newsletter=1&nlcode=432%7c1b17
