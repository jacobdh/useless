# Useless

Useless stuff that you should use, but less.

## NullFactory

You can create fresh nulls super efficiently like this:

```
var myNull = new NullFactory().Create();
var myTypedNull = new NullFactory().Create<MyClass>();
```

## Tripleton

Use Tripleton to create a class that can only ever have three instances.
You will be (psuedo)randomly returned one of the three instances. According to
my rough calculations, this class is three times better than a Singleton.

```
class MyTripleton : Tripleton<MyTripleton>
{
}

MyTripleton aRandomInstance = MyTripleton.Instance;
MyTripleton anotherRandomInstance = MyTripleton.Instance;
```
