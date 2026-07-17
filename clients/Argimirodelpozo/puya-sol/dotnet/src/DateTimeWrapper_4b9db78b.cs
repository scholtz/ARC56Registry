using System;
using Algorand;
using Algorand.Algod;
using Algorand.Algod.Model;
using Algorand.Algod.Model.Transactions;
using AVM.ClientGenerator;
using AVM.ClientGenerator.Core;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AVM.ClientGenerator.ABI.ARC56;
using Algorand.AVM.ClientGenerator.ABI.ARC56;

namespace Arc56.Generated.Argimirodelpozo.puya_sol.DateTimeWrapper_4b9db78b
{


    public class DateTimeWrapperProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public DateTimeWrapperProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class EpochDayToDateReturn : AVMObjectType
            {
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Year { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Month { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Day { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vYear = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vYear.From(Year);
                    ret.AddRange(vYear.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMonth = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vMonth.From(Month);
                    ret.AddRange(vMonth.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDay = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vDay.From(Day);
                    ret.AddRange(vDay.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static EpochDayToDateReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new EpochDayToDateReturn();
                    uint count = 0;
                    var vYear = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vYear.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Year = vYear;
                    var vMonth = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vMonth.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Month = vMonth;
                    var vDay = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vDay.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Day = vDay;
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as EpochDayToDateReturn);
                }
                public bool Equals(EpochDayToDateReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(EpochDayToDateReturn left, EpochDayToDateReturn right)
                {
                    return EqualityComparer<EpochDayToDateReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(EpochDayToDateReturn left, EpochDayToDateReturn right)
                {
                    return !(left == right);
                }

            }

            public class TimestampToDateReturn : AVMObjectType
            {
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Year { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Month { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Day { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vYear = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vYear.From(Year);
                    ret.AddRange(vYear.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMonth = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vMonth.From(Month);
                    ret.AddRange(vMonth.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDay = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vDay.From(Day);
                    ret.AddRange(vDay.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static TimestampToDateReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new TimestampToDateReturn();
                    uint count = 0;
                    var vYear = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vYear.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Year = vYear;
                    var vMonth = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vMonth.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Month = vMonth;
                    var vDay = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vDay.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Day = vDay;
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as TimestampToDateReturn);
                }
                public bool Equals(TimestampToDateReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(TimestampToDateReturn left, TimestampToDateReturn right)
                {
                    return EqualityComparer<TimestampToDateReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(TimestampToDateReturn left, TimestampToDateReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="year"> </param>
        /// <param name="month"> </param>
        /// <param name="day"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> DateToEpochDay(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 year, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 month, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 day, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 220, 31, 8, 48 };

            var result = await base.SimApp(new List<object> { abiHandle, year, month, day }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> DateToEpochDay_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 year, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 month, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 day, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 220, 31, 8, 48 };

            return await base.MakeTransactionList(new List<object> { abiHandle, year, month, day }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="epochDay"> </param>
        public async Task<Structs.EpochDayToDateReturn> EpochDayToDate(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 epochDay, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 106, 0, 184, 37 };

            var result = await base.SimApp(new List<object> { abiHandle, epochDay }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.EpochDayToDateReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> EpochDayToDate_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 epochDay, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 106, 0, 184, 37 };

            return await base.MakeTransactionList(new List<object> { abiHandle, epochDay }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="year"> </param>
        /// <param name="month"> </param>
        /// <param name="day"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> DateToTimestamp(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 year, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 month, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 day, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 58, 62, 66, 67 };

            var result = await base.SimApp(new List<object> { abiHandle, year, month, day }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> DateToTimestamp_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 year, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 month, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 day, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 58, 62, 66, 67 };

            return await base.MakeTransactionList(new List<object> { abiHandle, year, month, day }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="timestamp"> </param>
        public async Task<Structs.TimestampToDateReturn> TimestampToDate(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 timestamp, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 18, 103, 0, 200 };

            var result = await base.SimApp(new List<object> { abiHandle, timestamp }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.TimestampToDateReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> TimestampToDate_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 timestamp, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 18, 103, 0, 200 };

            return await base.MakeTransactionList(new List<object> { abiHandle, timestamp }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="year"> </param>
        public async Task<bool> IsLeapYear(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 year, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 30, 36, 23, 205 };

            var result = await base.SimApp(new List<object> { abiHandle, year }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsLeapYear_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 year, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 30, 36, 23, 205 };

            return await base.MakeTransactionList(new List<object> { abiHandle, year }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="year"> </param>
        /// <param name="month"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> DaysInMonth(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 year, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 month, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 116, 214, 15 };

            var result = await base.SimApp(new List<object> { abiHandle, year, month }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> DaysInMonth_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 year, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 month, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 116, 214, 15 };

            return await base.MakeTransactionList(new List<object> { abiHandle, year, month }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="timestamp"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> Weekday(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 timestamp, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 127, 9, 228, 242 };

            var result = await base.SimApp(new List<object> { abiHandle, timestamp }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> Weekday_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 timestamp, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 127, 9, 228, 242 };

            return await base.MakeTransactionList(new List<object> { abiHandle, timestamp }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Constructor Bare Action
        ///</summary>
        public async Task CreateApplication(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.CreateApplication)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 0, 193, 250, 21 };

            var result = await base.CallApp(new List<object> { }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.CreateApplication)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 0, 193, 250, 21 };

            return await base.MakeTransactionList(new List<object> { }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRGF0ZVRpbWVXcmFwcGVyIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7ImVwb2NoRGF5VG9EYXRlUmV0dXJuIjpbeyJuYW1lIjoieWVhciIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoibW9udGgiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6ImRheSIsInR5cGUiOiJ1aW50MjU2In1dLCJ0aW1lc3RhbXBUb0RhdGVSZXR1cm4iOlt7Im5hbWUiOiJ5ZWFyIiwidHlwZSI6InVpbnQyNTYifSx7Im5hbWUiOiJtb250aCIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoiZGF5IiwidHlwZSI6InVpbnQyNTYifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiZGF0ZVRvRXBvY2hEYXkiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InllYXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtb250aCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRheSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImVwb2NoRGF5VG9EYXRlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJlcG9jaERheSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDI1Nix1aW50MjU2LHVpbnQyNTYpIiwic3RydWN0IjoiZXBvY2hEYXlUb0RhdGVSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImRhdGVUb1RpbWVzdGFtcCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoieWVhciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1vbnRoIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGF5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGltZXN0YW1wVG9EYXRlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0aW1lc3RhbXAiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQyNTYsdWludDI1Nix1aW50MjU2KSIsInN0cnVjdCI6InRpbWVzdGFtcFRvRGF0ZVJldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaXNMZWFwWWVhciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoieWVhciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImRheXNJbk1vbnRoIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ5ZWFyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibW9udGgiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ3ZWVrZGF5IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0aW1lc3RhbXAiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzgwNSw4MTMsODIxLDg1MSw5MDgsOTE2LDkyNCw5NTQsMTAxMSwxMDQwLDEwNDgsMTA3OF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQyNTYiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4MzQsODY1LDg3OCw4OTAsOTM3LDk2OCw5ODEsOTkzLDEwNjEsMTA5MV0sImVycm9yTWVzc2FnZSI6Im92ZXJmbG93IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZjMjlzWVdSNUwyRjFlQzEzY21Gd2NHVnljeTEwYnkxa1pYQnNiM2t2UkdGMFpWUnBiV1ZYY21Gd2NHVnlMbk52YkM1RVlYUmxWR2x0WlZkeVlYQndaWEl1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXpNaUF4SURBZ01qQXdNQ0E0TmpRd01Bb2dJQ0FnWW5sMFpXTmliRzlqYXlBd2VEQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQ0F3ZUNBd2VEQXhJREI0TVRVeFpqZGpOelVnTUhnd015QXdlREF4T1RBZ01IZ3dNVFprSURCNE1ESXpZV0l4SURCNE1EWTRNVEF4SURCNFpqUm1aaUF3ZURBek1ERWdNSGd3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdPREF3SURCNE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd05Bb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSnVlaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFESTZDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUhCMWMyaGllWFJsYzNNZ01IaGtZekZtTURnek1DQXdlRFpoTURCaU9ESTFJREI0TTJFelpUUXlORE1nTUhneE1qWTNNREJqT0NBd2VERmxNalF4TjJOa0lEQjRNalEzTkdRMk1HWWdNSGczWmpBNVpUUm1NaUF2THlCdFpYUm9iMlFnSW1SaGRHVlViMFZ3YjJOb1JHRjVLSFZwYm5ReU5UWXNkV2x1ZERJMU5peDFhVzUwTWpVMktYVnBiblF5TlRZaUxDQnRaWFJvYjJRZ0ltVndiMk5vUkdGNVZHOUVZWFJsS0hWcGJuUXlOVFlwS0hWcGJuUXlOVFlzZFdsdWRESTFOaXgxYVc1ME1qVTJLU0lzSUcxbGRHaHZaQ0FpWkdGMFpWUnZWR2x0WlhOMFlXMXdLSFZwYm5ReU5UWXNkV2x1ZERJMU5peDFhVzUwTWpVMktYVnBiblF5TlRZaUxDQnRaWFJvYjJRZ0luUnBiV1Z6ZEdGdGNGUnZSR0YwWlNoMWFXNTBNalUyS1NoMWFXNTBNalUyTEhWcGJuUXlOVFlzZFdsdWRESTFOaWtpTENCdFpYUm9iMlFnSW1selRHVmhjRmxsWVhJb2RXbHVkREkxTmlsaWIyOXNJaXdnYldWMGFHOWtJQ0prWVhselNXNU5iMjUwYUNoMWFXNTBNalUyTEhWcGJuUXlOVFlwZFdsdWRESTFOaUlzSUcxbGRHaHZaQ0FpZDJWbGEyUmhlU2gxYVc1ME1qVTJLWFZwYm5ReU5UWWlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0JrWVhSbFZHOUZjRzlqYUVSaGVTQmxjRzlqYUVSaGVWUnZSR0YwWlNCa1lYUmxWRzlVYVcxbGMzUmhiWEFnZEdsdFpYTjBZVzF3Vkc5RVlYUmxJR2x6VEdWaGNGbGxZWElnWkdGNWMwbHVUVzl1ZEdnZ2QyVmxhMlJoZVFvZ0lDQWdaWEp5Q2dvS0x5OGdYM0IxZVdGZmJHbGlMblYwYVd3dVpXNXpkWEpsWDJKMVpHZGxkQ2h5WlhGMWFYSmxaRjlpZFdSblpYUTZJSFZwYm5RMk5Dd2dabVZsWDNOdmRYSmpaVG9nZFdsdWREWTBLU0F0UGlCMmIybGtPZ3BsYm5OMWNtVmZZblZrWjJWME9nb2dJQ0FnY0hKdmRHOGdNaUF3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lIQjFjMmhwYm5RZ01UQUtJQ0FnSUNzS0NtVnVjM1Z5WlY5aWRXUm5aWFJmZDJocGJHVmZkRzl3UURFNkNpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdaMnh2WW1Gc0lFOXdZMjlrWlVKMVpHZGxkQW9nSUNBZ1Bnb2dJQ0FnWW5vZ1pXNXpkWEpsWDJKMVpHZGxkRjloWm5SbGNsOTNhR2xzWlVBMkNpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQndkWE5vYVc1MElEWWdMeThnWVhCd2JBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdjSFZ6YUdsdWRDQTFJQzh2SUVSbGJHVjBaVUZ3Y0d4cFkyRjBhVzl1Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdZbmwwWldNZ09DQXZMeUF3ZURBMk9ERXdNUW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJ5YjNaaGJGQnliMmR5WVcwS0lDQWdJR0o1ZEdWaklEZ2dMeThnTUhnd05qZ3hNREVLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMEtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYzNkcGRHTm9JR1Z1YzNWeVpWOWlkV1JuWlhSZmMzZHBkR05vWDJOaGMyVmZNRUF6SUdWdWMzVnlaVjlpZFdSblpYUmZjM2RwZEdOb1gyTmhjMlZmTVVBMENncGxibk4xY21WZlluVmtaMlYwWDNOM2FYUmphRjlqWVhObFgyNWxlSFJBTlRvS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQmlJR1Z1YzNWeVpWOWlkV1JuWlhSZmQyaHBiR1ZmZEc5d1FERUtDbVZ1YzNWeVpWOWlkV1JuWlhSZmMzZHBkR05vWDJOaGMyVmZNVUEwT2dvZ0lDQWdaMnh2WW1Gc0lFMXBibFI0YmtabFpRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdJZ1pXNXpkWEpsWDJKMVpHZGxkRjl6ZDJsMFkyaGZZMkZ6WlY5dVpYaDBRRFVLQ21WdWMzVnlaVjlpZFdSblpYUmZjM2RwZEdOb1gyTmhjMlZmTUVBek9nb2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0JpSUdWdWMzVnlaVjlpZFdSblpYUmZjM2RwZEdOb1gyTmhjMlZmYm1WNGRFQTFDZ3BsYm5OMWNtVmZZblZrWjJWMFgyRm1kR1Z5WDNkb2FXeGxRRFk2Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZjMjlzWVdSNUwyRjFlQzEzY21Gd2NHVnljeTEwYnkxa1pYQnNiM2t2UkdGMFpWUnBiV1ZYY21Gd2NHVnlMbk52YkM1RVlYUmxWR2x0WlV4cFlpNWtZWFJsVkc5RmNHOWphRVJoZVNoNVpXRnlPaUJpZVhSbGN5d2diVzl1ZEdnNklHSjVkR1Z6TENCa1lYazZJR0o1ZEdWektTQXRQaUJpZVhSbGN6b0tSR0YwWlZScGJXVk1hV0l1WkdGMFpWUnZSWEJ2WTJoRVlYazZDaUFnSUNCd2NtOTBieUF6SURFS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURBeE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWWlzS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZbmwwWldNZ05DQXZMeUF3ZURBekNpQWdJQ0JpUEFvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZUFvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURBeENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdZaTBLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd3TVRBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0lsQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJQzB6Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREE1Q2lBZ0lDQmlLd29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZaVVLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREJqQ2lBZ0lDQmlKUW9nSUNBZ1lubDBaV01nT1NBdkx5QXdlR1kwWm1ZS0lDQWdJR0lxQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpSlFvZ0lDQWdZbmwwWldNZ01UQWdMeThnTUhnd016QXhDaUFnSUNCaUt3b2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lpVUtJQ0FnSUdKNWRHVmpJREV4SUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EZ3dNQW9nSUNBZ1lpOEtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWWlzS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnd01UQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdJbENpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR0o1ZEdWaklEVWdMeThnTUhnd01Ua3dDaUFnSUNCaUpRb2dJQ0FnWkhWd0NpQWdJQ0JpZVhSbFl5QTJJQzh2SURCNE1ERTJaQW9nSUNBZ1lpb0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3dNVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHSWxDaUFnSUNCa2FXY2dNUW9nSUNBZ1lubDBaV01nTVRJZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREEwQ2lBZ0lDQmlMd29nSUNBZ1lpc0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3dNVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHSWxDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0lyQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpSlFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURBeE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWWlzS0lDQWdJSE4zWVhBS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURZMENpQWdJQ0JpTHdvZ0lDQWdZaTBLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd3TVRBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0lsQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHSjVkR1ZqSURVZ0x5OGdNSGd3TVRrd0NpQWdJQ0JpTHdvZ0lDQWdZbmwwWldNZ055QXZMeUF3ZURBeU0yRmlNUW9nSUNBZ1lpb0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3dNVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHSWxDaUFnSUNCaUt3b2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lpVUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3dNVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHSXJDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dZV1poTm1RS0lDQWdJR0l0Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpSlFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM052YkdGa2VTOWhkWGd0ZDNKaGNIQmxjbk10ZEc4dFpHVndiRzk1TDBSaGRHVlVhVzFsVjNKaGNIQmxjaTV6YjJ3dVJHRjBaVlJwYldWTWFXSXVaWEJ2WTJoRVlYbFViMFJoZEdVb1pYQnZZMmhFWVhrNklHSjVkR1Z6S1NBdFBpQmllWFJsY3l3Z1lubDBaWE1zSUdKNWRHVnpPZ3BFWVhSbFZHbHRaVXhwWWk1bGNHOWphRVJoZVZSdlJHRjBaVG9LSUNBZ0lIQnliM1J2SURFZ013b2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd1lXWmhObU1LSUNBZ0lHSXJDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNREV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmlKUW9nSUNBZ1pIVndDaUFnSUNCbWNtRnRaVjlpZFhKNUlDMHhDaUFnSUNCaWVYUmxZeUEzSUM4dklEQjRNREl6WVdJeENpQWdJQ0JpSlFvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGc0WldGakNpQWdJQ0JpTHdvZ0lDQWdaR2xuSURFS0lDQWdJR0lyQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpSlFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURBeE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWWlzS0lDQWdJR1JwWnlBeENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd05XSTBDaUFnSUNCaUx3b2dJQ0FnWWkwS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnd01UQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdJbENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1ERXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaUt3b2dJQ0FnWkdsbklERUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXlNMkZpTUFvZ0lDQWdZajA5Q2lBZ0lDQmllWFJsWTE4eElDOHZJREI0Q2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TURFS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQmlMUW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZaVVLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdNSGd3TVRaa0NpQWdJQ0JpTHdvZ0lDQWdjM2RoY0FvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURBeE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWWlzS0lDQWdJR0o1ZEdWaklEWWdMeThnTUhnd01UWmtDaUFnSUNCa2FXY2dNZ29nSUNBZ1lpb0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3dNVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHSWxDaUFnSUNCd2RYTm9hVzUwSURnS0lDQWdJR0o2WlhKdkNpQWdJQ0JrYVdjZ013b2dJQ0FnWW5sMFpXTWdNVElnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQTBDaUFnSUNCaUx3b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmlLd29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZaVVLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd3TVRBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0lyQ2lBZ0lDQmthV2NnTXdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TmpRS0lDQWdJR0l2Q2lBZ0lDQmlMUW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZaVVLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWWkwS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnd01UQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdJbENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd05Rb2dJQ0FnWkdsbklERUtJQ0FnSUdJcUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1ERXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaUpRb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1ESUtJQ0FnSUdJckNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1ERXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaUpRb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE9Ua0tJQ0FnSUdJdkNpQWdJQ0J6ZDJGd0NpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1ERXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaUt3b2dJQ0FnWkdsbklERUtJQ0FnSUdKNWRHVmpJRGtnTHk4Z01IaG1OR1ptQ2lBZ0lDQmlLZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZaVVLSUNBZ0lHSjVkR1ZqSURFd0lDOHZJREI0TURNd01Rb2dJQ0FnWWlzS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnd01UQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdJbENpQWdJQ0JpZVhSbFl5QXhNU0F2THlBd2VEQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBNE1EQUtJQ0FnSUdJdkNpQWdJQ0JpTFFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURBeE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWWlVS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhnd01Rb2dJQ0FnWWlzS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnd01UQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdJbENpQWdJQ0JqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURnS0lDQWdJQzBLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TXpBME1EVXdOakEzTURnd09UQmhNR0l3WXpBeE1ESXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZbmwwWldNZ055QXZMeUF3ZURBeU0yRmlNUW9nSUNBZ1lpOEtJQ0FnSUdKNWRHVmpJRFVnTHk4Z01IZ3dNVGt3Q2lBZ0lDQmlLZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZaVVLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWWlzS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnd01UQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdJbENpQWdJQ0JrYVdjZ01Rb2dJQ0FnWW5sMFpXTWdOQ0F2THlBd2VEQXpDaUFnSUNCaVBBb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VBb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VEQXhDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnWWlzS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnd01UQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdJbENpQWdJQ0J6ZDJGd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lISmxkSE4xWWdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OXpiMnhoWkhrdllYVjRMWGR5WVhCd1pYSnpMWFJ2TFdSbGNHeHZlUzlFWVhSbFZHbHRaVmR5WVhCd1pYSXVjMjlzTGtSaGRHVlVhVzFsVEdsaUxtUmhkR1ZVYjFScGJXVnpkR0Z0Y0NoNVpXRnlPaUJpZVhSbGN5d2diVzl1ZEdnNklHSjVkR1Z6TENCa1lYazZJR0o1ZEdWektTQXRQaUJpZVhSbGN6b0tSR0YwWlZScGJXVk1hV0l1WkdGMFpWUnZWR2x0WlhOMFlXMXdPZ29nSUNBZ2NISnZkRzhnTXlBeENpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpZV3hzYzNWaUlFUmhkR1ZVYVcxbFRHbGlMbVJoZEdWVWIwVndiMk5vUkdGNUNpQWdJQ0JwYm5SaklEUWdMeThnT0RZME1EQUtJQ0FnSUdsMGIySUtJQ0FnSUdJcUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1ERXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaUpRb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDNOdmJHRmtlUzloZFhndGQzSmhjSEJsY25NdGRHOHRaR1Z3Ykc5NUwwUmhkR1ZVYVcxbFYzSmhjSEJsY2k1emIyd3VSR0YwWlZScGJXVk1hV0l1ZEdsdFpYTjBZVzF3Vkc5RVlYUmxLSFJwYldWemRHRnRjRG9nWW5sMFpYTXBJQzArSUdKNWRHVnpMQ0JpZVhSbGN5d2dZbmwwWlhNNkNrUmhkR1ZVYVcxbFRHbGlMblJwYldWemRHRnRjRlJ2UkdGMFpUb0tJQ0FnSUhCeWIzUnZJREVnTXdvZ0lDQWdhVzUwWXlBMElDOHZJRGcyTkRBd0NpQWdJQ0JwZEc5aUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJSE4zWVhBS0lDQWdJR0l2Q2lBZ0lDQmtkWEFLSUNBZ0lHTmhiR3h6ZFdJZ1JHRjBaVlJwYldWTWFXSXVaWEJ2WTJoRVlYbFViMFJoZEdVS0lDQWdJSEJ2Y0c0Z013b2dJQ0FnWkhWd0NpQWdJQ0JqWVd4c2MzVmlJRVJoZEdWVWFXMWxUR2xpTG1Wd2IyTm9SR0Y1Vkc5RVlYUmxDaUFnSUNCd2IzQnVJRElLSUNBZ0lITjNZWEFLSUNBZ0lHUjFjQW9nSUNBZ1kyRnNiSE4xWWlCRVlYUmxWR2x0WlV4cFlpNWxjRzlqYUVSaGVWUnZSR0YwWlFvZ0lDQWdjRzl3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0J3YjNBS0lDQWdJR05oYkd4emRXSWdSR0YwWlZScGJXVk1hV0l1WlhCdlkyaEVZWGxVYjBSaGRHVUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lIQnZjRzRnTWdvZ0lDQWdjbVYwYzNWaUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM052YkdGa2VTOWhkWGd0ZDNKaGNIQmxjbk10ZEc4dFpHVndiRzk1TDBSaGRHVlVhVzFsVjNKaGNIQmxjaTV6YjJ3dVJHRjBaVlJwYldWTWFXSXVhWE5NWldGd1dXVmhjaWg1WldGeU9pQmllWFJsY3lrZ0xUNGdkV2x1ZERZME9ncEVZWFJsVkdsdFpVeHBZaTVwYzB4bFlYQlpaV0Z5T2dvZ0lDQWdjSEp2ZEc4Z01TQXhDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VERTVDaUFnSUNCaUpRb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VBb2dJQ0FnWWowOUNpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNENpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1ERUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlZzWldOMENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd1l3b2dJQ0FnWWlvS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnd01UQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdJbENpQWdJQ0JpZVhSbFl5QTBJQzh2SURCNE1ETUtJQ0FnSUdJckNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1ERXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaUpRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JpSmdvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZUFvZ0lDQWdZajA5Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZjMjlzWVdSNUwyRjFlQzEzY21Gd2NHVnljeTEwYnkxa1pYQnNiM2t2UkdGMFpWUnBiV1ZYY21Gd2NHVnlMbk52YkM1RVlYUmxWR2x0WlV4cFlpNWtZWGx6U1c1TmIyNTBhQ2g1WldGeU9pQmllWFJsY3l3Z2JXOXVkR2c2SUdKNWRHVnpLU0F0UGlCaWVYUmxjem9LUkdGMFpWUnBiV1ZNYVdJdVpHRjVjMGx1VFc5dWRHZzZDaUFnSUNCd2NtOTBieUF5SURFS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZMkZzYkhOMVlpQkVZWFJsVkdsdFpVeHBZaTVwYzB4bFlYQlpaV0Z5Q2lBZ0lDQndkWE5vYVc1MElEZ0tJQ0FnSUdKNlpYSnZDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnT0FvZ0lDQWdMUW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TVdZeFl6Rm1NV1V4WmpGbE1XWXhaakZsTVdZeFpURm1NREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lITjNZWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TWdvZ0lDQWdZajA5Q2lBZ0lDQmllWFJsWTE4eElDOHZJREI0Q2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TURFS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0Q2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TURFS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ2MyVnNaV04wQ2lBZ0lDQmlKZ29nSUNBZ1lpc0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3dNVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHSWxDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmMyOXNZV1I1TDJGMWVDMTNjbUZ3Y0dWeWN5MTBieTFrWlhCc2Iza3ZSR0YwWlZScGJXVlhjbUZ3Y0dWeUxuTnZiQzVFWVhSbFZHbHRaVXhwWWk1M1pXVnJaR0Y1S0hScGJXVnpkR0Z0Y0RvZ1lubDBaWE1wSUMwK0lHSjVkR1Z6T2dwRVlYUmxWR2x0WlV4cFlpNTNaV1ZyWkdGNU9nb2dJQ0FnY0hKdmRHOGdNU0F4Q2lBZ0lDQnBiblJqSURRZ0x5OGdPRFkwTURBS0lDQWdJR2wwYjJJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdjM2RoY0FvZ0lDQWdZaThLSUNBZ0lIQjFjMmhwYm5RZ013b2dJQ0FnYVhSdllnb2dJQ0FnWWlzS0lDQWdJSEIxYzJocGJuUWdOd29nSUNBZ2FYUnZZZ29nSUNBZ1lpVUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0JwZEc5aUNpQWdJQ0JpS3dvZ0lDQWdjbVYwYzNWaUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM052YkdGa2VTOWhkWGd0ZDNKaGNIQmxjbk10ZEc4dFpHVndiRzk1TDBSaGRHVlVhVzFsVjNKaGNIQmxjaTV6YjJ3dVJHRjBaVlJwYldWWGNtRndjR1Z5TG1SaGRHVlViMFZ3YjJOb1JHRjVXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWkdGMFpWUnZSWEJ2WTJoRVlYazZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblF5TlRZS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWRESTFOZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTWpVMkNpQWdJQ0JwYm5Salh6TWdMeThnTWpBd01Bb2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJR05oYkd4emRXSWdaVzV6ZFhKbFgySjFaR2RsZEFvZ0lDQWdZMkZzYkhOMVlpQkVZWFJsVkdsdFpVeHBZaTVrWVhSbFZHOUZjRzlqYUVSaGVRb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JpZW1WeWJ3b2dJQ0FnWW53S0lDQWdJR0o1ZEdWalh6TWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZjMjlzWVdSNUwyRjFlQzEzY21Gd2NHVnljeTEwYnkxa1pYQnNiM2t2UkdGMFpWUnBiV1ZYY21Gd2NHVnlMbk52YkM1RVlYUmxWR2x0WlZkeVlYQndaWEl1WlhCdlkyaEVZWGxVYjBSaGRHVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BsY0c5amFFUmhlVlJ2UkdGMFpUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkREkxTmdvZ0lDQWdhVzUwWTE4eklDOHZJREl3TURBS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQmpZV3hzYzNWaUlHVnVjM1Z5WlY5aWRXUm5aWFFLSUNBZ0lHTmhiR3h6ZFdJZ1JHRjBaVlJwYldWTWFXSXVaWEJ2WTJoRVlYbFViMFJoZEdVS0lDQWdJR1JwWnlBeUNpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JpZW1WeWJ3b2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmthV2NnTVFvZ0lDQWdZbndLSUNBZ0lHUnBaeUF6Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCa2FXY2dNZ29nSUNBZ1lud0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JRElLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JpZkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM052YkdGa2VTOWhkWGd0ZDNKaGNIQmxjbk10ZEc4dFpHVndiRzk1TDBSaGRHVlVhVzFsVjNKaGNIQmxjaTV6YjJ3dVJHRjBaVlJwYldWWGNtRndjR1Z5TG1SaGRHVlViMVJwYldWemRHRnRjRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21SaGRHVlViMVJwYldWemRHRnRjRG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERJMU5nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBNalUyQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5ReU5UWUtJQ0FnSUdsdWRHTmZNeUF2THlBeU1EQXdDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnWTJGc2JITjFZaUJsYm5OMWNtVmZZblZrWjJWMENpQWdJQ0JqWVd4c2MzVmlJRVJoZEdWVWFXMWxUR2xpTG1SaGRHVlViMVJwYldWemRHRnRjQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2ZG1WeVpteHZkd29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCaWVtVnlid29nSUNBZ1lud0tJQ0FnSUdKNWRHVmpYek1nTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12YzI5c1lXUjVMMkYxZUMxM2NtRndjR1Z5Y3kxMGJ5MWtaWEJzYjNrdlJHRjBaVlJwYldWWGNtRndjR1Z5TG5OdmJDNUVZWFJsVkdsdFpWZHlZWEJ3WlhJdWRHbHRaWE4wWVcxd1ZHOUVZWFJsVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2RHbHRaWE4wWVcxd1ZHOUVZWFJsT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME1qVTJDaUFnSUNCcGJuUmpYek1nTHk4Z01qQXdNQW9nSUNBZ2FXNTBZMTh5SUM4dklEQUtJQ0FnSUdOaGJHeHpkV0lnWlc1emRYSmxYMkoxWkdkbGRBb2dJQ0FnWTJGc2JITjFZaUJFWVhSbFZHbHRaVXhwWWk1MGFXMWxjM1JoYlhCVWIwUmhkR1VLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmllbVZ5YndvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCa2FXY2dNUW9nSUNBZ1lud0tJQ0FnSUdScFp5QXpDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2ZG1WeVpteHZkd29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JrYVdjZ01nb2dJQ0FnWW53S0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklESUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmlmQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWTE4eklDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzTnZiR0ZrZVM5aGRYZ3RkM0poY0hCbGNuTXRkRzh0WkdWd2JHOTVMMFJoZEdWVWFXMWxWM0poY0hCbGNpNXpiMnd1UkdGMFpWUnBiV1ZYY21Gd2NHVnlMbWx6VEdWaGNGbGxZWEpiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwcGMweGxZWEJaWldGeU9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBNalUyQ2lBZ0lDQnBiblJqWHpNZ0x5OGdNakF3TUFvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lHTmhiR3h6ZFdJZ1pXNXpkWEpsWDJKMVpHZGxkQW9nSUNBZ1kyRnNiSE4xWWlCRVlYUmxWR2x0WlV4cFlpNXBjMHhsWVhCWlpXRnlDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNQW9nSUNBZ2FXNTBZMTh5SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlYwWW1sMENpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM052YkdGa2VTOWhkWGd0ZDNKaGNIQmxjbk10ZEc4dFpHVndiRzk1TDBSaGRHVlVhVzFsVjNKaGNIQmxjaTV6YjJ3dVJHRjBaVlJwYldWWGNtRndjR1Z5TG1SaGVYTkpiazF2Ym5Sb1czSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taR0Y1YzBsdVRXOXVkR2c2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5ReU5UWUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkREkxTmdvZ0lDQWdhVzUwWTE4eklDOHZJREl3TURBS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQmpZV3hzYzNWaUlHVnVjM1Z5WlY5aWRXUm5aWFFLSUNBZ0lHTmhiR3h6ZFdJZ1JHRjBaVlJwYldWTWFXSXVaR0Y1YzBsdVRXOXVkR2dLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1lucGxjbThLSUNBZ0lHSjhDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDNOdmJHRmtlUzloZFhndGQzSmhjSEJsY25NdGRHOHRaR1Z3Ykc5NUwwUmhkR1ZVYVcxbFYzSmhjSEJsY2k1emIyd3VSR0YwWlZScGJXVlhjbUZ3Y0dWeUxuZGxaV3RrWVhsYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDNaV1ZyWkdGNU9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBNalUyQ2lBZ0lDQnBiblJqWHpNZ0x5OGdNakF3TUFvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lHTmhiR3h6ZFdJZ1pXNXpkWEpsWDJKMVpHZGxkQW9nSUNBZ1kyRnNiSE4xWWlCRVlYUmxWR2x0WlV4cFlpNTNaV1ZyWkdGNUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR0o2WlhKdkNpQWdJQ0JpZkFvZ0lDQWdZbmwwWldOZk15QXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12YzI5c1lXUjVMMkYxZUMxM2NtRndjR1Z5Y3kxMGJ5MWtaWEJzYjNrdlJHRjBaVlJwYldWWGNtRndjR1Z5TG5OdmJDNUVZWFJsVkdsdFpWZHlZWEJ3WlhJdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFGSUFFQTBBK0Fvd1VtRFNFQkFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQVFFRUZSOThkUUVEQWdHUUFnRnRBd0k2c1FNR2dRRUM5UDhDQXdFZ0FBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFDQUFnQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBUXhHRUFBQWlORE1Sa1VSREVZUklJSEJOd2ZDREFFYWdDNEpRUTZQa0pEQkJKbkFNZ0VIaVFYelFRa2ROWVBCSDhKNVBJMkdnQ09Cd0pKQW5jQ3NBTGVBeGNETkFOYUFJb0NBSXYrZ1FvSWl3QXlEQTFCQUNxeGdRYXlFSUVGc2hrbkNMSWVKd2l5SDR2L2pRSUFDd0FFczBMLzJ6SUFzZ0ZDLy9Va3NnRkMvKytKaWdNQmkvMG9vSXYrSndTa0tTcFBBazJoS0txTS9ZditnQUVKb0NpcWdBRU1xaWNKb3lpcUp3cWdLS29uQzZLTC82QW9xb3Y5SndXcVNTY0dveWlxU3dFbkRLS2dLS3BQQXFBb3FpaWdUSUFCWktLaEtLcUwvU2NGb2ljSG95aXFvQ2lxS0tDQUF3cjZiYUVvcW9tS0FRT0wvNEFEQ3Zwc29DaXFTWXovSndlcVNZQUNqcXlpU3dHZ0tLb29vRXNCZ0FJRnRLS2hLS29vb0VzQmdBTUNPckNvS1NwUEFrMmhLS29uQnFKTUtLQW5Ca3NDb3lpcWdRaXZTd01uREtKUEFxQW9xaWlnU3dPQUFXU2lvU2lxVHdKTW9TaXFnQUVGU3dHaktLcUFBUUtnS0txQUFabWlUQ2lnU3dFbkNhTW9xaWNLb0NpcUp3dWlvU2lxS3FBb3FrNENVRWtWZ1FnSlc0QWdBd1FGQmdjSUNRb0xEQUVDQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFCTUkxaUwveWNIb2ljRm95aXFUd09nS0twTEFTY0VwQ2txVHdKTm9DaXFURThDaVlvREFZdjlpLzZMLzRqK3BpRUVGcU1vcW9tS0FRTWhCQmFMLzB5aVNZaisvMFlEU1lqKytVWUNURW1JL3ZKSVRnSklpUDdyVGdKR0FvbUtBUUdMLzRBQkdhb3BxQ2txVHdKTmdBRU1veWlxSndTZ0tLcUwvNndwcUltS0FnR0wvb2ovMTRFSXI0di9VRWtWZ1FnSlc0QWdBQjhjSHg0ZkhoOGZIaDhlSHdBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFCTUkxaUwvNEFCQXFncEtrOENUU2txVHdSTnJLQW9xb21LQVFFaEJCYUwvMHlpZ1FNV29JRUhGcW9qRnFDSk5ob0JTUlVpRWtRMkdnSkpGU0lTUkRZYUEwa1ZJaEpFSlNTSS9adUkvZE5KRlNJT1JDS3ZxeXRNVUxBalF6WWFBVWtWSWhKRUpTU0kvWDJJL2lOTEFoVWlEa1FpcjA4RFN3R3JTd01WSWc1RVR3TkxBcXRRU3dJVklnNUVUZ0tyVUN0TVVMQWpRellhQVVrVkloSkVOaG9DU1JVaUVrUTJHZ05KRlNJU1JDVWtpUDAwaVA2NlNSVWlEa1FpcjZzclRGQ3dJME0yR2dGSkZTSVNSQ1VraVAwV2lQNnZTd0lWSWc1RUlxOVBBMHNCcTBzREZTSU9SRThEU3dLclVFc0NGU0lPUkU0Q3ExQXJURkN3STBNMkdnRkpGU0lTUkNVa2lQemRpUDZkZ0FFQUpFOENWQ3RNVUxBalF6WWFBVWtWSWhKRU5ob0NTUlVpRWtRbEpJajh1SWorbVVrVklnNUVJcStySzB4UXNDTkROaG9CU1JVaUVrUWxKSWo4bW9qK3lVa1ZJZzVFSXErcksweFFzQ05EIiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6NywicGF0Y2giOjEsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
