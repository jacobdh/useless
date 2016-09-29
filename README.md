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

## FactoryFactory

Use FactoryFactory to create a factory for any type you want.

```
var intFactoryFactory = new FactoryFactory<int>();
var myIntFactory = intFactoryFactory.Create();

var int1 = myIntFactory.Create();
var int2 = myIntFactory.Create();
```
