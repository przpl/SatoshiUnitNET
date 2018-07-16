# SatoshiUnitNET

[![][nuget-img]][nuget]

[nuget]:     https://www.nuget.org/packages/SatoshiUnitNET/
[nuget-img]: https://badge.fury.io/nu/satoshiunit.svg

## Usage

Create instance:
```cs
using SatoshiUnitNET;

var sat = new SatoshiUnit(100); // 100 satoshis
```

or use creation methods:
```cs
var sat = SatoshiUnit.FromSatoshis(1); // 1 satoshi
var sat = SatoshiUnit.FromFinnies(1); // 10 satoshis
var sat = SatoshiUnit.FromMicrobitcoins(1); // 100 satoshis
var sat = SatoshiUnit.FromMilibitcoins(1); // 100,000 satoshis
var sat = SatoshiUnit.FromCentibitcoins(1); // 1,000,000 satoshis
var sat = SatoshiUnit.FromDecibitcoins(1); // 10,000,000 satoshis
var sat = SatoshiUnit.FromBitcoins(1); // 100,000,000 satoshis
```

Get or set value by any unit:
```cs
var sat = new SatoshiUnit(100);
sat.Satoshis // get or set by satoshis (sat)
sat.Finnies // get or set by finnies
sat.Microbitcoins // get or set by microbitcoins (uBTC)
sat.Milibitcoins // get or set by milibitcoins (mBTC)
sat.Centibitcoins // get or set by centibitcoins (cBTC)
sat.Decibitcoins // get or set by decibitcoins (dBTC)
sat.Bitcoins // get or set by bitcoins (BTC)
```

## Other features

Class implements IComparable, IComparable<T> and IEquatable<T> interfaces. It also supports following operators: +, -, *, /, ==, !=, <, <=, > and >=.
