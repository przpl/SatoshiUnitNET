using System;

namespace SatoshiUnitNET
{
    public class SatoshiUnit : IComparable, IComparable<SatoshiUnit>, IEquatable<SatoshiUnit>
    {
        /// <summary>
        /// How many satoshis (sat) are in one bitcoin.
        /// </summary>
        public const int SatoshisPerBitcoin = 100000000;

        /// <summary>
        /// How many finnies are in one bitcoin.
        /// </summary>
        public const int FinniesPerBitcoin = SatoshisPerBitcoin / SATOSHIS_PER_FINNEY; // 10000000

        /// <summary>
        /// How many microbitcoins (uBTC) are in one bitcoin.
        /// </summary>
        public const int MicroPerBitcoin = SatoshisPerBitcoin / SATOSHIS_PER_MICRO; // 1000000

        /// <summary>
        /// How many millibitcoins (mBTC) are in one bitcoin.
        /// </summary>
        public const int MilliPerBitcoin = SatoshisPerBitcoin / SATOSHIS_PER_MILI; // 1000

        /// <summary>
        /// How many centibitcoins (cBTC) are in one bitcoin.
        /// </summary>
        public const int CentiPerBitcoin = SatoshisPerBitcoin / SATOSHIS_PER_CENTI; // 100

        /// <summary>
        /// How many decibitcoins (dBTC) are in one bitcoin.
        /// </summary>
        public const int DeciiPerBitcoin = SatoshisPerBitcoin / SATOSHIS_PER_DECI; // 10

        /// <summary>
        /// How many bitcoins are there in total supply.
        /// </summary>
        public const decimal TotalSupplyInBitcoins = 20999999.9769m;

        /// <summary>
        /// Represents the smallest possible number of stored satoshis.
        /// </summary>
        public static decimal MinValue => decimal.MinValue;

        /// <summary>
        /// Represents the largest possible number of stored satoshis.
        /// </summary>
        public static decimal MaxValue => decimal.MaxValue;

        public decimal Satoshis {
            get
            {
                return _satoshis;
            }
            set
            {
                _satoshis = Math.Round(value, 0);
            }
        }

        public decimal Finnies
        {
            get
            {
                return Satoshis / SATOSHIS_PER_FINNEY;
            }
            set
            {
                Satoshis = value * SATOSHIS_PER_FINNEY;
            }
        }

        /// <summary>
        /// uBTC
        /// </summary>
        public decimal Microbitcoins
        {
            get
            {
                return Satoshis / SATOSHIS_PER_MICRO;
            }
            set
            {
                Satoshis = value * SATOSHIS_PER_MICRO;
            }
        }

        /// <summary>
        /// mBTC
        /// </summary>
        public decimal Milibitcoins
        {
            get
            {
                return Satoshis / SATOSHIS_PER_MILI;
            }
            set
            {
                Satoshis = value * SATOSHIS_PER_MILI;
            }
        }

        /// <summary>
        /// cBTC
        /// </summary>
        public decimal Centibitcoins
        {
            get
            {
                return Satoshis / SATOSHIS_PER_CENTI;
            }
            set
            {
                Satoshis = value * SATOSHIS_PER_CENTI;
            }
        }

        /// <summary>
        /// dBTC
        /// </summary>
        public decimal Decibitcoins
        {
            get
            {
                return Satoshis / SATOSHIS_PER_DECI;
            }
            set
            {
                Satoshis = value * SATOSHIS_PER_DECI;
            }
        }

        /// <summary>
        /// BTC
        /// </summary>
        public decimal Bitcoins
        {
            get
            {
                return Satoshis / SatoshisPerBitcoin;
            }
            set
            {
                Satoshis = value * SatoshisPerBitcoin;
            }
        }

        private const int SATOSHIS_PER_FINNEY = 10;
        private const int SATOSHIS_PER_MICRO = 100;
        private const int SATOSHIS_PER_MILI = 100000;
        private const int SATOSHIS_PER_CENTI = 1000000;
        private const int SATOSHIS_PER_DECI = 10000000;

        private decimal _satoshis;

        public SatoshiUnit(decimal satoshis)
        {
            Satoshis = satoshis;
        }

        #region Constructor methods
        public static SatoshiUnit FromSatoshis(decimal satoshis)
        {
            return new SatoshiUnit(satoshis);
        }

        public static SatoshiUnit FromFinnies(decimal finnies)
        {
            return new SatoshiUnit(0) { Finnies = finnies };
        }

        public static SatoshiUnit FromMicrobitcoins(decimal uBTC)
        {
            return new SatoshiUnit(0) { Microbitcoins = uBTC };
        }

        public static SatoshiUnit FromMilibitcoins(decimal mBTC)
        {
            return new SatoshiUnit(0) { Milibitcoins = mBTC };
        }

        public static SatoshiUnit FromCentibitcoins(decimal cBTC)
        {
            return new SatoshiUnit(0) { Centibitcoins = cBTC };
        }

        public static SatoshiUnit FromDecibitcoins(decimal dBTC)
        {
            return new SatoshiUnit(0) { Decibitcoins = dBTC };
        }

        public static SatoshiUnit FromBitcoins(decimal BTC)
        {
            return new SatoshiUnit(0) { Bitcoins = BTC };
        }
        #endregion

        #region Interface implementations
        public int CompareTo(object value)
        {
            if (value == null)
                return 1;
            if (!(value is SatoshiUnit))
                throw new ArgumentException("Compared object must be type of SatoshiUnit.");
            decimal s = ((SatoshiUnit)value).Satoshis;
            if (Satoshis > s)
                return 1;
            if (Satoshis < s)
                return -1;
            return 0;
        }

        public int CompareTo(SatoshiUnit other)
        {
            if (other == null)
                return 1;
            decimal s = other.Satoshis;
            if (Satoshis > s)
                return 1;
            if (Satoshis < s)
                return -1;
            return 0;
        }

        public override bool Equals(object value)
        {
            if (value is TimeSpan)
                return Satoshis == ((SatoshiUnit)value).Satoshis;
            return false;
        }

        public bool Equals(SatoshiUnit other)
        {
            return Satoshis == other.Satoshis;
        }
        #endregion

        #region Operators
        public static SatoshiUnit operator +(SatoshiUnit s1, SatoshiUnit s2)
        {
            return new SatoshiUnit(s1.Satoshis + s2.Satoshis);
        }

        public static SatoshiUnit operator -(SatoshiUnit s1, SatoshiUnit s2)
        {
            return new SatoshiUnit(s1.Satoshis - s2.Satoshis);
        }

        public static SatoshiUnit operator *(SatoshiUnit s1, SatoshiUnit s2)
        {
            return new SatoshiUnit(s1.Satoshis * s2.Satoshis);
        }

        public static SatoshiUnit operator /(SatoshiUnit s1, SatoshiUnit s2)
        {
            return new SatoshiUnit(s1.Satoshis / s2.Satoshis);
        }

        public static bool operator ==(SatoshiUnit s1, SatoshiUnit s2)
        {
            return s1.Satoshis == s2.Satoshis;
        }

        public static bool operator !=(SatoshiUnit s1, SatoshiUnit s2)
        {
            return s1.Satoshis != s2.Satoshis;
        }

        public static bool operator <(SatoshiUnit s1, SatoshiUnit s2)
        {
            return s1.Satoshis < s2.Satoshis;
        }

        public static bool operator <=(SatoshiUnit s1, SatoshiUnit s2)
        {
            return s1.Satoshis <= s2.Satoshis;
        }

        public static bool operator >(SatoshiUnit s1, SatoshiUnit s2)
        {
            return s1.Satoshis > s2.Satoshis;
        }

        public static bool operator >=(SatoshiUnit s1, SatoshiUnit s2)
        {
            return s1.Satoshis >= s2.Satoshis;
        }
        #endregion
    }
}
