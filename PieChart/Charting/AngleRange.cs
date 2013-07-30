// Type: Telerik.Charting.AngleRange
// Assembly: Telerik.Windows.Controls.Chart, Version=2013.1.219.2040, Culture=neutral, PublicKeyToken=5803cfa389c90ce7
// Assembly location: C:\Program Files (x86)\Telerik\RadControls for Windows Phone 7 Q1 2013\Binaries\WindowsPhone\Telerik.Windows.Controls.Chart.dll

using System;
using System.ComponentModel;

namespace Charting
{
    /// <summary>
    /// Represents a structure that defines the starting and sweeping angles of an ellipse Arc.
    /// 
    /// </summary>
    [TypeConverter(typeof(StringToAngleRangeConverter))]
    public struct AngleRange
    {
        /// <summary>
        /// The default structure value with its starting angle set to 0 and its sweep angle set to 360.
        /// 
        /// </summary>
        public static readonly AngleRange Default;
        internal double startAngle;
        internal double sweepAngle;

        /// <summary>
        /// Gets or sets start angle from which the arc starts.
        /// 
        /// </summary>
        public double StartAngle
        {
            get
            {
                return this.startAngle;
            }
            set
            {
                if (value < 0.0 || value > 360.0)
                    throw new ArgumentOutOfRangeException("value");
                this.startAngle = value;
            }
        }

        /// <summary>
        /// Gets or sets the angle that defines the length of the Arc.
        /// 
        /// </summary>
        public double SweepAngle
        {
            get
            {
                return this.sweepAngle;
            }
            set
            {
                if (value < 0.0 || value > 360.0)
                    throw new ArgumentOutOfRangeException("value");
                this.sweepAngle = value;
            }
        }

        static AngleRange()
        {
            AngleRange.Default = new AngleRange(0.0, 360.0);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Telerik.Charting.AngleRange"/> struct.
        /// 
        /// </summary>
        /// <param name="startAngle">The start angle.</param><param name="sweepAngle">The sweep angle.</param>
        public AngleRange(double startAngle, double sweepAngle)
        {
            this.startAngle = startAngle;
            this.sweepAngle = sweepAngle;
        }

        /// <summary>
        /// Implements the operator ==.
        /// 
        /// </summary>
        /// <param name="r1">The first range.</param><param name="r2">The second range.</param>
        /// <returns>
        /// The result of the operator.
        /// </returns>
        public static bool operator ==(AngleRange r1, AngleRange r2)
        {
            if (r1.startAngle == r2.startAngle)
                return r1.sweepAngle == r2.sweepAngle;
            else
                return false;
        }

        /// <summary>
        /// Implements the operator !=.
        /// 
        /// </summary>
        /// <param name="r1">The first range.</param><param name="r2">The second range.</param>
        /// <returns>
        /// The result of the operator.
        /// </returns>
        public static bool operator !=(AngleRange r1, AngleRange r2)
        {
            return !(r1 == r2);
        }

        /// <summary>
        /// Determines whether the specified <see cref="T:System.Object"/> is equal to this instance.
        /// 
        /// </summary>
        /// <param name="obj">The <see cref="T:System.Object"/> to compare with this instance.</param>
        /// <returns>
        /// <c>true</c> if the specified <see cref="T:System.Object"/> is equal to this instance; otherwise, <c>false</c>.
        /// 
        /// </returns>
        public override bool Equals(object obj)
        {
            if (obj is AngleRange)
                return (AngleRange)obj == this;
            else
                return false;
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.
        /// 
        /// </returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
