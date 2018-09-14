using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramFlow
{
    /// <summary>
    /// Defines methods that demonstrate decision and looping structures.
    /// </summary>
    public static class Flow
    {
        /// <summary>
        /// Returns the inverse value for a boolean.
        /// </summary>
        /// <param name="value">The <see cref="bool"/> value to invert.</param>
        /// <returns><b>true</b> if <paramref name="value"/> is <b>false</b>; <b>false</b> if <paramref name="value"/> is <b>true</b>.</returns>
        public static bool InvertBoolean(bool value)
        {
			// TODO: Fix this method so it passes all associated tests.
			if (value == true)
			{
				value = false;
			}
			else if (value == false)
			{
				value = true;
			}
            return value;
        }

        /// <summary>
        /// Returns the correct <see cref="DriverAction"/> value for each <see cref="LightColor"/> using an if-else statement.
        /// </summary>
        /// <param name="value">The <see cref="LightColor"/> for which to return a <see cref="DriverAction"/>.</param>
        /// <returns>The correct <see cref="DriverAction"/> value.</returns>
        public static DriverAction DriveSafelyIfElse(LightColor color)
        {
			// TODO: Fix this method so it passes all associated tests. An if-else statement must be used to return the correct values.
			if (color == LightColor.Green)
			{
				return (DriverAction)2;
			}
			else if (color == LightColor.Yellow)
			{
				return (DriverAction)3;
			}
			else if (color == LightColor.Red)
			{
				return (DriverAction)1;
			}
			else
			{
				return (DriverAction)0;
			}            
        }
        /// <summary>
        /// Returns the correct <see cref="DriverAction"/> value for each <see cref="LightColor"/> using a switch statement.
        /// </summary>
        /// <param name="value">The <see cref="LightColor"/> for which to return a <see cref="DriverAction"/>.</param>
        /// <returns>The correct <see cref="DriverAction"/> value.</returns>
        public static DriverAction DriveSafelySwitch(LightColor color)
        {
			// TODO: Fix this method so it passes all associated tests. A switch statement must be used to return the correct values.
			switch (color)
			{
				case LightColor.Red:
					return (DriverAction)1;
				case LightColor.Yellow:
					return (DriverAction)3;
				case LightColor.Green:
					return (DriverAction)2;
				default:
					return 0;
			}
        }
        /// <summary>
        /// Returns the sum of the specified numbers using a for loop.
        /// </summary>
        /// <param name="values">The values to aggregate.</param>
        /// <returns>The sum of the numbers.</returns>
        public static long ForSum(int[] values)
        {
			int total = 0;
			// TODO: Fix this method so it passes all associated tests. A for loop must be used to calculate the sum.
			for (int amount = 0; amount < values.Length; amount++)
			{
				total += values[amount];
			}
			return total;
        }

        /// <summary>
        /// Returns the sum of the specified numbers using a foreach loop.
        /// </summary>
        /// <param name="values">The values to aggregate.</param>
        /// <returns>The sum of the numbers.</returns>
        public static long ForEachSum(int[] values)
        {
			int secondTotal = 0;
			// TODO: Fix this method so it passes all associated tests. A foreach loop must be used to calculate the sum.
			foreach (int number in values)
			{
				secondTotal += number;
			}
			return secondTotal;
        }
    }
}
