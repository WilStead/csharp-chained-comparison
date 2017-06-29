# csharp-chained-comparison
This package allows chaining comparison operations with C# (e.g. `x < y < z`).

Any basic CLR type can be compared, with the only caveats being that you need to cast the first operand as a "`ChainComparator`", and all the types must match. If you need to perform any casting or boxing, do so before performing the chained comparison.

Here are a few examples:
* `(ChainComparator)1 < 2 > 0` is `true`
* `(ChainComparator)(short)1 < (short)2 < (short)3` is `true`
* `(ChainComparator)(decimal)1.1 <= (decimal)1.1 == (decimal)1.1 != (decimal)5.4` is `true`
* `(ChainComparator)'a' < 'b' < 'c'` is `true`
* `(ChainComparator)'z' < 'b' < 'c'` is `false`
* `(ChainComparator)"Hello" < "World" > "!" == "!"` is `true`
* `(ChainComparator)(short)1 < 2` throws an `ArgumentException`
To perform this comparison, try this:
```c#
short s = 1;
int boxedS = s;
var result = (ChainComparator)boxedS < 2;
// result will equal true
```

## How do I get this?
NuGet package coming soon...

For now just download, build, and include the .dll.

## Credit
Thanks to [Robbie Vanbrabant](https://github.com/robbiev) who was responsible for the original work from which this project was forked.
