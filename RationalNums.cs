using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov_14
{
    public class RationalNums
    {
        public int Top { get; set; }
        private int bottom;
        public int Bottom
        {
            get { return bottom; }
            set
            {
                if (value == 0)
                {
                    throw new DivideByZeroException("На ноль делить нельзя!");
                }
                else
                {
                    bottom = value;
                }
            }
        }
        public RationalNums(int top, int bottom)
        {
            Top = top;
            Bottom = bottom;
        }
        public RationalNums()
        {
        }
        public static bool operator ==(RationalNums r1, RationalNums r2)
        {
            if ((double)r1.Top / r1.Bottom == (double)r2.Top / r2.Bottom)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(RationalNums r1, RationalNums r2)
        {
            if ((double)r1.Top / r1.Bottom == (double)r2.Top / r2.Bottom)
            {
                return false;
            }
            return true;
        }
        public static bool operator >(RationalNums r1, RationalNums r2)
        {
            if ((double)r1.Top / r1.Bottom > (double)r2.Top / r2.Bottom)
            {
                return true;
            }
            return false;
        }
        public static bool operator <(RationalNums r1, RationalNums r2)
        {
            if ((double)r1.Top / r1.Bottom < (double)r2.Top / r2.Bottom)
            {
                return true;
            }
            return false;
        }
        public static bool operator >=(RationalNums r1, RationalNums r2)
        {
            if ((double)r1.Top / r1.Bottom >= (double)r2.Top / r2.Bottom)
            {
                return true;
            }
            return false;
        }
        public static bool operator <=(RationalNums r1, RationalNums r2)
        {
            if ((double)r1.Top / r1.Bottom <= (double)r2.Top / r2.Bottom)
            {
                return true;
            }
            return false;
        }
        public static RationalNums operator +(RationalNums r1, RationalNums r2)
        {
            RationalNums r3 = new RationalNums();
            r3.Top = r1.Top * r2.Bottom + r2.Top * r1.Bottom;
            r3.Bottom = r1.Bottom * r2.Bottom;
            return r3;
        }
        public static RationalNums operator -(RationalNums r1, RationalNums r2)
        {
            RationalNums r3 = new RationalNums();
            r3.Top = r1.Top * r2.Bottom - r2.Top * r1.Bottom;
            r3.Bottom = r1.Bottom * r2.Bottom;
            return r3;
        }
        public static RationalNums operator *(RationalNums r1, RationalNums r2)
        {
            return new RationalNums(r1.Top * r2.Top, r1.Bottom * r2.Bottom);
        }
        public static RationalNums operator /(RationalNums r1, RationalNums r2)
        {
            return new RationalNums(r1.Top * r2.Bottom, r1.Bottom * r2.Top);
        }
        public static RationalNums operator %(RationalNums r1, RationalNums r2)
        {
            RationalNums r3 = new RationalNums();
            r3.Top = r1.Top * r2.Bottom + r2.Top * r1.Bottom;
            r3.Bottom = r1.Bottom * r2.Bottom;
            return r3;
        }
        public static RationalNums operator ++(RationalNums r1)
        {
            return new RationalNums(r1.Top + r1.Bottom, r1.Bottom);
        }
        public static RationalNums operator --(RationalNums r1)
        {
            return new RationalNums(r1.Top - r1.Bottom, r1.Bottom);
        }
        public static implicit operator RationalNums(int x)
        {
            return new RationalNums(x, 1);
        }
        public static explicit operator int(RationalNums r)
        {
            return r.Top / r.Bottom;
        }
        public static explicit operator double(RationalNums r)
        {
            return (double)r.Top / r.Bottom;
        }
        public override string ToString()
        {
            return $"{Top}/{Bottom}";
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if (obj is RationalNums r1)
            {
                return r1 == this;
            }
            return base.Equals(obj);
        }
    }
}
