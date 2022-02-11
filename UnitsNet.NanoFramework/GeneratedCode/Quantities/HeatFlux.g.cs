//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add UnitDefinitions\MyQuantity.json and run generate-code.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using UnitsNet.Units;

namespace UnitsNet
{
    /// <inheritdoc />
    /// <summary>
    ///     Heat flux is the flow of energy per unit of area per unit of time
    /// </summary>
    public struct  HeatFlux
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly HeatFluxUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public HeatFluxUnit Unit => _unit;
        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public HeatFlux(double value, HeatFluxUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static HeatFluxUnit BaseUnit { get; } = HeatFluxUnit.WattPerSquareMeter;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static HeatFlux MaxValue { get; } = new HeatFlux(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static HeatFlux MinValue { get; } = new HeatFlux(double.MinValue, BaseUnit);
        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static HeatFlux Zero { get; } = new HeatFlux(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="HeatFluxUnit.BtuPerHourSquareFoot"/>
        /// </summary>
        public double BtusPerHourSquareFoot => As(HeatFluxUnit.BtuPerHourSquareFoot);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="HeatFluxUnit.BtuPerMinuteSquareFoot"/>
        /// </summary>
        public double BtusPerMinuteSquareFoot => As(HeatFluxUnit.BtuPerMinuteSquareFoot);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="HeatFluxUnit.BtuPerSecondSquareFoot"/>
        /// </summary>
        public double BtusPerSecondSquareFoot => As(HeatFluxUnit.BtuPerSecondSquareFoot);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="HeatFluxUnit.BtuPerSecondSquareInch"/>
        /// </summary>
        public double BtusPerSecondSquareInch => As(HeatFluxUnit.BtuPerSecondSquareInch);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="HeatFluxUnit.CaloriePerSecondSquareCentimeter"/>
        /// </summary>
        public double CaloriesPerSecondSquareCentimeter => As(HeatFluxUnit.CaloriePerSecondSquareCentimeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="HeatFluxUnit.CentiwattPerSquareMeter"/>
        /// </summary>
        public double CentiwattsPerSquareMeter => As(HeatFluxUnit.CentiwattPerSquareMeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="HeatFluxUnit.DeciwattPerSquareMeter"/>
        /// </summary>
        public double DeciwattsPerSquareMeter => As(HeatFluxUnit.DeciwattPerSquareMeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="HeatFluxUnit.KilocaloriePerHourSquareMeter"/>
        /// </summary>
        public double KilocaloriesPerHourSquareMeter => As(HeatFluxUnit.KilocaloriePerHourSquareMeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="HeatFluxUnit.KilocaloriePerSecondSquareCentimeter"/>
        /// </summary>
        public double KilocaloriesPerSecondSquareCentimeter => As(HeatFluxUnit.KilocaloriePerSecondSquareCentimeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="HeatFluxUnit.KilowattPerSquareMeter"/>
        /// </summary>
        public double KilowattsPerSquareMeter => As(HeatFluxUnit.KilowattPerSquareMeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="HeatFluxUnit.MicrowattPerSquareMeter"/>
        /// </summary>
        public double MicrowattsPerSquareMeter => As(HeatFluxUnit.MicrowattPerSquareMeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="HeatFluxUnit.MilliwattPerSquareMeter"/>
        /// </summary>
        public double MilliwattsPerSquareMeter => As(HeatFluxUnit.MilliwattPerSquareMeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="HeatFluxUnit.NanowattPerSquareMeter"/>
        /// </summary>
        public double NanowattsPerSquareMeter => As(HeatFluxUnit.NanowattPerSquareMeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="HeatFluxUnit.PoundForcePerFootSecond"/>
        /// </summary>
        public double PoundsForcePerFootSecond => As(HeatFluxUnit.PoundForcePerFootSecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="HeatFluxUnit.PoundPerSecondCubed"/>
        /// </summary>
        public double PoundsPerSecondCubed => As(HeatFluxUnit.PoundPerSecondCubed);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="HeatFluxUnit.WattPerSquareFoot"/>
        /// </summary>
        public double WattsPerSquareFoot => As(HeatFluxUnit.WattPerSquareFoot);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="HeatFluxUnit.WattPerSquareInch"/>
        /// </summary>
        public double WattsPerSquareInch => As(HeatFluxUnit.WattPerSquareInch);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="HeatFluxUnit.WattPerSquareMeter"/>
        /// </summary>
        public double WattsPerSquareMeter => As(HeatFluxUnit.WattPerSquareMeter);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="HeatFlux"/> from <see cref="HeatFluxUnit.BtuPerHourSquareFoot"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static HeatFlux FromBtusPerHourSquareFoot(double btusperhoursquarefoot) => new HeatFlux(btusperhoursquarefoot, HeatFluxUnit.BtuPerHourSquareFoot);

        /// <summary>
        ///     Creates a <see cref="HeatFlux"/> from <see cref="HeatFluxUnit.BtuPerMinuteSquareFoot"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static HeatFlux FromBtusPerMinuteSquareFoot(double btusperminutesquarefoot) => new HeatFlux(btusperminutesquarefoot, HeatFluxUnit.BtuPerMinuteSquareFoot);

        /// <summary>
        ///     Creates a <see cref="HeatFlux"/> from <see cref="HeatFluxUnit.BtuPerSecondSquareFoot"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static HeatFlux FromBtusPerSecondSquareFoot(double btuspersecondsquarefoot) => new HeatFlux(btuspersecondsquarefoot, HeatFluxUnit.BtuPerSecondSquareFoot);

        /// <summary>
        ///     Creates a <see cref="HeatFlux"/> from <see cref="HeatFluxUnit.BtuPerSecondSquareInch"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static HeatFlux FromBtusPerSecondSquareInch(double btuspersecondsquareinch) => new HeatFlux(btuspersecondsquareinch, HeatFluxUnit.BtuPerSecondSquareInch);

        /// <summary>
        ///     Creates a <see cref="HeatFlux"/> from <see cref="HeatFluxUnit.CaloriePerSecondSquareCentimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static HeatFlux FromCaloriesPerSecondSquareCentimeter(double caloriespersecondsquarecentimeter) => new HeatFlux(caloriespersecondsquarecentimeter, HeatFluxUnit.CaloriePerSecondSquareCentimeter);

        /// <summary>
        ///     Creates a <see cref="HeatFlux"/> from <see cref="HeatFluxUnit.CentiwattPerSquareMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static HeatFlux FromCentiwattsPerSquareMeter(double centiwattspersquaremeter) => new HeatFlux(centiwattspersquaremeter, HeatFluxUnit.CentiwattPerSquareMeter);

        /// <summary>
        ///     Creates a <see cref="HeatFlux"/> from <see cref="HeatFluxUnit.DeciwattPerSquareMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static HeatFlux FromDeciwattsPerSquareMeter(double deciwattspersquaremeter) => new HeatFlux(deciwattspersquaremeter, HeatFluxUnit.DeciwattPerSquareMeter);

        /// <summary>
        ///     Creates a <see cref="HeatFlux"/> from <see cref="HeatFluxUnit.KilocaloriePerHourSquareMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static HeatFlux FromKilocaloriesPerHourSquareMeter(double kilocaloriesperhoursquaremeter) => new HeatFlux(kilocaloriesperhoursquaremeter, HeatFluxUnit.KilocaloriePerHourSquareMeter);

        /// <summary>
        ///     Creates a <see cref="HeatFlux"/> from <see cref="HeatFluxUnit.KilocaloriePerSecondSquareCentimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static HeatFlux FromKilocaloriesPerSecondSquareCentimeter(double kilocaloriespersecondsquarecentimeter) => new HeatFlux(kilocaloriespersecondsquarecentimeter, HeatFluxUnit.KilocaloriePerSecondSquareCentimeter);

        /// <summary>
        ///     Creates a <see cref="HeatFlux"/> from <see cref="HeatFluxUnit.KilowattPerSquareMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static HeatFlux FromKilowattsPerSquareMeter(double kilowattspersquaremeter) => new HeatFlux(kilowattspersquaremeter, HeatFluxUnit.KilowattPerSquareMeter);

        /// <summary>
        ///     Creates a <see cref="HeatFlux"/> from <see cref="HeatFluxUnit.MicrowattPerSquareMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static HeatFlux FromMicrowattsPerSquareMeter(double microwattspersquaremeter) => new HeatFlux(microwattspersquaremeter, HeatFluxUnit.MicrowattPerSquareMeter);

        /// <summary>
        ///     Creates a <see cref="HeatFlux"/> from <see cref="HeatFluxUnit.MilliwattPerSquareMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static HeatFlux FromMilliwattsPerSquareMeter(double milliwattspersquaremeter) => new HeatFlux(milliwattspersquaremeter, HeatFluxUnit.MilliwattPerSquareMeter);

        /// <summary>
        ///     Creates a <see cref="HeatFlux"/> from <see cref="HeatFluxUnit.NanowattPerSquareMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static HeatFlux FromNanowattsPerSquareMeter(double nanowattspersquaremeter) => new HeatFlux(nanowattspersquaremeter, HeatFluxUnit.NanowattPerSquareMeter);

        /// <summary>
        ///     Creates a <see cref="HeatFlux"/> from <see cref="HeatFluxUnit.PoundForcePerFootSecond"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static HeatFlux FromPoundsForcePerFootSecond(double poundsforceperfootsecond) => new HeatFlux(poundsforceperfootsecond, HeatFluxUnit.PoundForcePerFootSecond);

        /// <summary>
        ///     Creates a <see cref="HeatFlux"/> from <see cref="HeatFluxUnit.PoundPerSecondCubed"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static HeatFlux FromPoundsPerSecondCubed(double poundspersecondcubed) => new HeatFlux(poundspersecondcubed, HeatFluxUnit.PoundPerSecondCubed);

        /// <summary>
        ///     Creates a <see cref="HeatFlux"/> from <see cref="HeatFluxUnit.WattPerSquareFoot"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static HeatFlux FromWattsPerSquareFoot(double wattspersquarefoot) => new HeatFlux(wattspersquarefoot, HeatFluxUnit.WattPerSquareFoot);

        /// <summary>
        ///     Creates a <see cref="HeatFlux"/> from <see cref="HeatFluxUnit.WattPerSquareInch"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static HeatFlux FromWattsPerSquareInch(double wattspersquareinch) => new HeatFlux(wattspersquareinch, HeatFluxUnit.WattPerSquareInch);

        /// <summary>
        ///     Creates a <see cref="HeatFlux"/> from <see cref="HeatFluxUnit.WattPerSquareMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static HeatFlux FromWattsPerSquareMeter(double wattspersquaremeter) => new HeatFlux(wattspersquaremeter, HeatFluxUnit.WattPerSquareMeter);


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="HeatFluxUnit" /> to <see cref="HeatFlux" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>HeatFlux unit value.</returns>
        public static HeatFlux From(double value, HeatFluxUnit fromUnit)
        {
            return new HeatFlux(value, fromUnit);
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(HeatFluxUnit unit) => GetValueAs(unit);

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public HeatFlux ToUnit(HeatFluxUnit unit)
        {
            var convertedValue = GetValueAs(unit);
            return new HeatFlux(convertedValue, unit);
        }

        /// <summary>
        ///     Converts the current value + unit to the base unit.
        ///     This is typically the first step in converting from one unit to another.
        /// </summary>
        /// <returns>The value in the base unit representation.</returns>
        private double GetValueInBaseUnit()
        {
            return Unit switch
            {
                HeatFluxUnit.BtuPerHourSquareFoot => _value * 3.15459075,
                HeatFluxUnit.BtuPerMinuteSquareFoot => _value * 1.89275445e2,
                HeatFluxUnit.BtuPerSecondSquareFoot => _value * 1.13565267e4,
                HeatFluxUnit.BtuPerSecondSquareInch => _value * 1.63533984e6,
                HeatFluxUnit.CaloriePerSecondSquareCentimeter => _value * 4.1868e4,
                HeatFluxUnit.CentiwattPerSquareMeter => (_value) * 1e-2d,
                HeatFluxUnit.DeciwattPerSquareMeter => (_value) * 1e-1d,
                HeatFluxUnit.KilocaloriePerHourSquareMeter => _value * 1.163,
                HeatFluxUnit.KilocaloriePerSecondSquareCentimeter => (_value * 4.1868e4) * 1e3d,
                HeatFluxUnit.KilowattPerSquareMeter => (_value) * 1e3d,
                HeatFluxUnit.MicrowattPerSquareMeter => (_value) * 1e-6d,
                HeatFluxUnit.MilliwattPerSquareMeter => (_value) * 1e-3d,
                HeatFluxUnit.NanowattPerSquareMeter => (_value) * 1e-9d,
                HeatFluxUnit.PoundForcePerFootSecond => _value * 1.459390293720636e1,
                HeatFluxUnit.PoundPerSecondCubed => _value * 4.5359237e-1,
                HeatFluxUnit.WattPerSquareFoot => _value * 1.07639e1,
                HeatFluxUnit.WattPerSquareInch => _value * 1.5500031e3,
                HeatFluxUnit.WattPerSquareMeter => _value,
                _ => throw new NotImplementedException($"Can not convert {Unit} to base units.")
            };
        }

        private double GetValueAs(HeatFluxUnit unit)
        {
            if (Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            return unit switch
            {
                HeatFluxUnit.BtuPerHourSquareFoot => baseUnitValue / 3.15459075,
                HeatFluxUnit.BtuPerMinuteSquareFoot => baseUnitValue / 1.89275445e2,
                HeatFluxUnit.BtuPerSecondSquareFoot => baseUnitValue / 1.13565267e4,
                HeatFluxUnit.BtuPerSecondSquareInch => baseUnitValue / 1.63533984e6,
                HeatFluxUnit.CaloriePerSecondSquareCentimeter => baseUnitValue / 4.1868e4,
                HeatFluxUnit.CentiwattPerSquareMeter => (baseUnitValue) / 1e-2d,
                HeatFluxUnit.DeciwattPerSquareMeter => (baseUnitValue) / 1e-1d,
                HeatFluxUnit.KilocaloriePerHourSquareMeter => baseUnitValue / 1.163,
                HeatFluxUnit.KilocaloriePerSecondSquareCentimeter => (baseUnitValue / 4.1868e4) / 1e3d,
                HeatFluxUnit.KilowattPerSquareMeter => (baseUnitValue) / 1e3d,
                HeatFluxUnit.MicrowattPerSquareMeter => (baseUnitValue) / 1e-6d,
                HeatFluxUnit.MilliwattPerSquareMeter => (baseUnitValue) / 1e-3d,
                HeatFluxUnit.NanowattPerSquareMeter => (baseUnitValue) / 1e-9d,
                HeatFluxUnit.PoundForcePerFootSecond => baseUnitValue / 1.459390293720636e1,
                HeatFluxUnit.PoundPerSecondCubed => baseUnitValue / 4.5359237e-1,
                HeatFluxUnit.WattPerSquareFoot => baseUnitValue / 1.07639e1,
                HeatFluxUnit.WattPerSquareInch => baseUnitValue / 1.5500031e3,
                HeatFluxUnit.WattPerSquareMeter => baseUnitValue,
                _ => throw new NotImplementedException($"Can not convert {Unit} to {unit}.")
            };
        }

        #endregion

    }
}

