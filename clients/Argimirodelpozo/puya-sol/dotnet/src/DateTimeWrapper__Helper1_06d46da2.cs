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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.DateTimeWrapper__Helper1_06d46da2
{


    //
    // Helper contract 1 for DateTimeWrapper
    //
    public class DateTimeWrapper__Helper1Proxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public DateTimeWrapper__Helper1Proxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class Tuple : AVMObjectType
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

                public static Tuple Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Tuple();
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
                    return Equals(obj as Tuple);
                }
                public bool Equals(Tuple? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Tuple left, Tuple right)
                {
                    return EqualityComparer<Tuple>.Default.Equals(left, right);
                }
                public static bool operator !=(Tuple left, Tuple right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///@dev Returns (`year`,`month`,`day`) from the given unix timestamp.
        /// Note: Inputs outside the supported ranges result in undefined behavior.
        /// Use {isSupportedTimestamp} to check if the inputs are supported.
        ///</summary>
        /// <param name="timestamp"> </param>
        public async Task<Structs.Tuple> DateTimeLibTimestampToDate(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 timestamp, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 131, 78, 121, 246 };

            var result = await base.SimApp(new List<object> { abiHandle, timestamp }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.Tuple.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> DateTimeLibTimestampToDate_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 timestamp, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 131, 78, 121, 246 };

            return await base.MakeTransactionList(new List<object> { abiHandle, timestamp }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@dev Returns (`year`,`month`,`day`) from the number of days since 1970-01-01.
        /// Note: Inputs outside the supported ranges result in undefined behavior.
        /// Use {isSupportedDays} to check if the inputs is supported.
        ///</summary>
        /// <param name="epochDay"> </param>
        public async Task<Structs.Tuple> DateTimeLibEpochDayToDate(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 epochDay, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 202, 13, 48, 237 };

            var result = await base.SimApp(new List<object> { abiHandle, epochDay }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.Tuple.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> DateTimeLibEpochDayToDate_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 epochDay, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 202, 13, 48, 237 };

            return await base.MakeTransactionList(new List<object> { abiHandle, epochDay }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@dev Returns the weekday from the unix timestamp.
        /// Monday: 1, Tuesday: 2, ....., Sunday: 7.
        ///</summary>
        /// <param name="timestamp"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> DateTimeLibWeekday(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 timestamp, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 203, 200, 103, 155 };

            var result = await base.SimApp(new List<object> { abiHandle, timestamp }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> DateTimeLibWeekday_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 timestamp, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 203, 200, 103, 155 };

            return await base.MakeTransactionList(new List<object> { abiHandle, timestamp }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="o"> </param>
        /// <param name="p"> </param>
        /// <param name="s"> </param>
        public async Task Init(ulong o, ulong p, byte[] s, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 169, 110, 249, 137 };
            var oAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); oAbi.From(o);
            var pAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); pAbi.From(p);
            var sAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); sAbi.From(s);

            var result = await base.CallApp(new List<object> { abiHandle, oAbi, pAbi, sAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Init_Transactions(ulong o, ulong p, byte[] s, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 169, 110, 249, 137 };
            var oAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); oAbi.From(o);
            var pAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); pAbi.From(p);
            var sAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); sAbi.From(s);

            return await base.MakeTransactionList(new List<object> { abiHandle, oAbi, pAbi, sAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRGF0ZVRpbWVXcmFwcGVyX19IZWxwZXIxIiwiZGVzYyI6IkhlbHBlciBjb250cmFjdCAxIGZvciBEYXRlVGltZVdyYXBwZXIiLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsidHVwbGUiOlt7Im5hbWUiOiJ5ZWFyIiwidHlwZSI6InVpbnQyNTYifSx7Im5hbWUiOiJtb250aCIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoiZGF5IiwidHlwZSI6InVpbnQyNTYifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiRGF0ZVRpbWVMaWIudGltZXN0YW1wVG9EYXRlIiwiZGVzYyI6IkBkZXYgUmV0dXJucyAoYHllYXJgLGBtb250aGAsYGRheWApIGZyb20gdGhlIGdpdmVuIHVuaXggdGltZXN0YW1wLlxuIE5vdGU6IElucHV0cyBvdXRzaWRlIHRoZSBzdXBwb3J0ZWQgcmFuZ2VzIHJlc3VsdCBpbiB1bmRlZmluZWQgYmVoYXZpb3IuXG4gVXNlIHtpc1N1cHBvcnRlZFRpbWVzdGFtcH0gdG8gY2hlY2sgaWYgdGhlIGlucHV0cyBhcmUgc3VwcG9ydGVkLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidGltZXN0YW1wIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50MjU2LHVpbnQyNTYsdWludDI1NikiLCJzdHJ1Y3QiOiJ0dXBsZSIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiRGF0ZVRpbWVMaWIuZXBvY2hEYXlUb0RhdGUiLCJkZXNjIjoiQGRldiBSZXR1cm5zIChgeWVhcmAsYG1vbnRoYCxgZGF5YCkgZnJvbSB0aGUgbnVtYmVyIG9mIGRheXMgc2luY2UgMTk3MC0wMS0wMS5cbiBOb3RlOiBJbnB1dHMgb3V0c2lkZSB0aGUgc3VwcG9ydGVkIHJhbmdlcyByZXN1bHQgaW4gdW5kZWZpbmVkIGJlaGF2aW9yLlxuIFVzZSB7aXNTdXBwb3J0ZWREYXlzfSB0byBjaGVjayBpZiB0aGUgaW5wdXRzIGlzIHN1cHBvcnRlZC4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImVwb2NoRGF5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50MjU2LHVpbnQyNTYsdWludDI1NikiLCJzdHJ1Y3QiOiJ0dXBsZSIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiRGF0ZVRpbWVMaWIud2Vla2RheSIsImRlc2MiOiJAZGV2IFJldHVybnMgdGhlIHdlZWtkYXkgZnJvbSB0aGUgdW5peCB0aW1lc3RhbXAuXG4gTW9uZGF5OiAxLCBUdWVzZGF5OiAyLCAuLi4uLiwgU3VuZGF5OiA3LiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidGltZXN0YW1wIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiX19pbml0X18iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MiwiYnl0ZXMiOjF9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzgwN10sImVycm9yTWVzc2FnZSI6ImhlbHBlcjogYWxyZWFkeSBpbml0aWFsaXplZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUwMSw2MDUsNzA5XSwiZXJyb3JNZXNzYWdlIjoiaGVscGVyOiBtdXN0IGJlIGNhbGxlZCBpbiBncm91cCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUxNSw2MTksNzIzXSwiZXJyb3JNZXNzYWdlIjoiaGVscGVyOiBzZW5kZXIgbWlzbWF0Y2giLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MDgsNjEyLDcxNl0sImVycm9yTWVzc2FnZSI6ImhlbHBlcjogdW5hdXRob3JpemVkIGNhbGxlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUzMCw2MzQsNzM4XSwiZXJyb3JNZXNzYWdlIjoiaGVscGVyOiB3cm9uZyBwcmV2IGNodW5rIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTQxLDY0NSw3NDldLCJlcnJvck1lc3NhZ2UiOiJoZWxwZXI6IHdyb25nIHByZXYgbWV0aG9kIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzkzXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODAwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ5MSw1OTUsNjk5XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDI1NiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc3Niw3ODVdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NTEsNTY0LDU3Niw2NTUsNjY4LDY4MCw3NThdLCJlcnJvck1lc3NhZ2UiOiJvdmVyZmxvdyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12YzI5c1lXUjVMMkYxZUMxM2NtRndjR1Z5Y3kxMGJ5MWtaWEJzYjNrdlJHRjBaVlJwYldWWGNtRndjR1Z5TG5OdmJDNUVZWFJsVkdsdFpWZHlZWEJ3WlhKZlgwaGxiSEJsY2pFdVgxOXdkWGxoWDJGeVl6UmZjbTkxZEdWeVgxOG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ016SWdNU0E0SURJZ09EWTBNREFLSUNBZ0lHSjVkR1ZqWW14dlkyc2dNSGd3TVRBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBZ0ltOGlJQ0p3SWlBaWN5SWdNSGd3TVNBd2VERTFNV1kzWXpjMUlEQjRNREl6WVdJeElEQjRNREUyWkFvZ0lDQWdZaUJmWDNCMWVXRmZZWEpqTkY5eWIzVjBaWEpmWHdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OXpiMnhoWkhrdllYVjRMWGR5WVhCd1pYSnpMWFJ2TFdSbGNHeHZlUzlFWVhSbFZHbHRaVmR5WVhCd1pYSXVjMjlzTGtSaGRHVlVhVzFsVEdsaUxtVndiMk5vUkdGNVZHOUVZWFJsS0dWd2IyTm9SR0Y1T2lCaWVYUmxjeWtnTFQ0Z1lubDBaWE1zSUdKNWRHVnpMQ0JpZVhSbGN6b0tSR0YwWlZScGJXVk1hV0l1WlhCdlkyaEVZWGxVYjBSaGRHVTZDaUFnSUNCd2NtOTBieUF4SURNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TUdGbVlUWmpDaUFnSUNCaUt3b2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lpVUtJQ0FnSUdSMWNBb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBdE1Rb2dJQ0FnWW5sMFpXTWdOaUF2THlBd2VEQXlNMkZpTVFvZ0lDQWdZaVVLSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRPR1ZoWXdvZ0lDQWdZaThLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmlLd29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZaVVLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd3TVRBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0lyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURWaU5Bb2dJQ0FnWWk4S0lDQWdJR0l0Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpSlFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURBeE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWWlzS0lDQWdJR1JwWnlBeENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01qTmhZakFLSUNBZ0lHSTlQUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRDaUFnSUNCaWVYUmxZeUEwSUM4dklEQjRNREVLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWc1pXTjBDaUFnSUNCaUxRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lpVUtJQ0FnSUdKNWRHVmpJRGNnTHk4Z01IZ3dNVFprQ2lBZ0lDQmlMd29nSUNBZ2MzZGhjQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZaXNLSUNBZ0lHSjVkR1ZqSURjZ0x5OGdNSGd3TVRaa0NpQWdJQ0JrYVdjZ01nb2dJQ0FnWWlvS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnd01UQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdJbENpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdZbnBsY204S0lDQWdJR1JwWnlBekNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBMENpQWdJQ0JpTHdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaUt3b2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lpVUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3dNVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHSXJDaUFnSUNCa2FXY2dNd29nSUNBZ2NIVnphR0o1ZEdWeklEQjROalFLSUNBZ0lHSXZDaUFnSUNCaUxRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lpVUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZaTBLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd3TVRBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0lsQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TlFvZ0lDQWdaR2xuSURFS0lDQWdJR0lxQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpSlFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURJS0lDQWdJR0lyQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpSlFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0T1RrS0lDQWdJR0l2Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpS3dvZ0lDQWdaR2xuSURFS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZUdZMFptWUtJQ0FnSUdJcUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1ERXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaUpRb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1ETXdNUW9nSUNBZ1lpc0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3dNVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHSWxDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd09EQXdDaUFnSUNCaUx3b2dJQ0FnWWkwS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnd01UQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdJbENpQWdJQ0JpZVhSbFl5QTBJQzh2SURCNE1ERUtJQ0FnSUdJckNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1ERXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaUpRb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUMwS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd016QTBNRFV3TmpBM01EZ3dPVEJoTUdJd1l6QXhNREl3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0J6ZDJGd0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWW5sMFpXTWdOaUF2THlBd2VEQXlNMkZpTVFvZ0lDQWdZaThLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF4T1RBS0lDQWdJR0lxQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpSlFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCaUt3b2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lpVUtJQ0FnSUdScFp5QXhDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNd29nSUNBZ1lqd0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VBb2dJQ0FnWW5sMFpXTWdOQ0F2THlBd2VEQXhDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnWWlzS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnd01UQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdJbENpQWdJQ0J6ZDJGd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lISmxkSE4xWWdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OXpiMnhoWkhrdllYVjRMWGR5WVhCd1pYSnpMWFJ2TFdSbGNHeHZlUzlFWVhSbFZHbHRaVmR5WVhCd1pYSXVjMjlzTGtSaGRHVlVhVzFsVEdsaUxuUnBiV1Z6ZEdGdGNGUnZSR0YwWlNoMGFXMWxjM1JoYlhBNklHSjVkR1Z6S1NBdFBpQmllWFJsY3l3Z1lubDBaWE1zSUdKNWRHVnpPZ3BFWVhSbFZHbHRaVXhwWWk1MGFXMWxjM1JoYlhCVWIwUmhkR1U2Q2lBZ0lDQndjbTkwYnlBeElETUtJQ0FnSUdsdWRHTWdOQ0F2THlBNE5qUXdNQW9nSUNBZ2FYUnZZZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCemQyRndDaUFnSUNCaUx3b2dJQ0FnWkhWd0NpQWdJQ0JqWVd4c2MzVmlJRVJoZEdWVWFXMWxUR2xpTG1Wd2IyTm9SR0Y1Vkc5RVlYUmxDaUFnSUNCd2IzQnVJRE1LSUNBZ0lHUjFjQW9nSUNBZ1kyRnNiSE4xWWlCRVlYUmxWR2x0WlV4cFlpNWxjRzlqYUVSaGVWUnZSR0YwWlFvZ0lDQWdjRzl3YmlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JrZFhBS0lDQWdJR05oYkd4emRXSWdSR0YwWlZScGJXVk1hV0l1WlhCdlkyaEVZWGxVYjBSaGRHVUtJQ0FnSUhCdmNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2NHOXdDaUFnSUNCallXeHNjM1ZpSUVSaGRHVlVhVzFsVEdsaUxtVndiMk5vUkdGNVZHOUVZWFJsQ2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0J3YjNCdUlESUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5emIyeGhaSGt2WVhWNExYZHlZWEJ3WlhKekxYUnZMV1JsY0d4dmVTOUVZWFJsVkdsdFpWZHlZWEJ3WlhJdWMyOXNMa1JoZEdWVWFXMWxUR2xpTG5kbFpXdGtZWGtvZEdsdFpYTjBZVzF3T2lCaWVYUmxjeWtnTFQ0Z1lubDBaWE02Q2tSaGRHVlVhVzFsVEdsaUxuZGxaV3RrWVhrNkNpQWdJQ0J3Y205MGJ5QXhJREVLSUNBZ0lHbHVkR01nTkNBdkx5QTROalF3TUFvZ0lDQWdhWFJ2WWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmlMd29nSUNBZ2NIVnphR2x1ZENBekNpQWdJQ0JwZEc5aUNpQWdJQ0JpS3dvZ0lDQWdjSFZ6YUdsdWRDQTNDaUFnSUNCcGRHOWlDaUFnSUNCaUpRb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJR2wwYjJJS0lDQWdJR0lyQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZjMjlzWVdSNUwyRjFlQzEzY21Gd2NHVnljeTEwYnkxa1pYQnNiM2t2UkdGMFpWUnBiV1ZYY21Gd2NHVnlMbk52YkM1RVlYUmxWR2x0WlZkeVlYQndaWEpmWDBobGJIQmxjakV1WDE5d2RYbGhYMkZ5WXpSZmNtOTFkR1Z5WDE4b0tTQXRQaUIxYVc1ME5qUTZDbDlmY0hWNVlWOWhjbU0wWDNKdmRYUmxjbDlmT2dvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR0o2SUY5ZmNIVjVZVjloY21NMFgzSnZkWFJsY2w5ZlgxOWZZbUZ5WlY5amNtVmhkR1ZmWDBBeE1Bb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMENpQWdJQ0J3ZFhOb1lubDBaWE56SURCNE9ETTBaVGM1WmpZZ01IaGpZVEJrTXpCbFpDQXdlR05pWXpnMk56bGlJREI0WVRrMlpXWTVPRGtnTHk4Z2JXVjBhRzlrSUNKRVlYUmxWR2x0WlV4cFlpNTBhVzFsYzNSaGJYQlViMFJoZEdVb2RXbHVkREkxTmlrb2RXbHVkREkxTml4MWFXNTBNalUyTEhWcGJuUXlOVFlwSWl3Z2JXVjBhRzlrSUNKRVlYUmxWR2x0WlV4cFlpNWxjRzlqYUVSaGVWUnZSR0YwWlNoMWFXNTBNalUyS1NoMWFXNTBNalUyTEhWcGJuUXlOVFlzZFdsdWRESTFOaWtpTENCdFpYUm9iMlFnSWtSaGRHVlVhVzFsVEdsaUxuZGxaV3RrWVhrb2RXbHVkREkxTmlsMWFXNTBNalUySWl3Z2JXVjBhRzlrSUNKZlgybHVhWFJmWHloMWFXNTBOalFzZFdsdWREWTBMR0o1ZEdWYlhTbDJiMmxrSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDNOdmJHRmtlUzloZFhndGQzSmhjSEJsY25NdGRHOHRaR1Z3Ykc5NUwwUmhkR1ZVYVcxbFYzSmhjSEJsY2k1emIyd3VSR0YwWlZScGJXVlhjbUZ3Y0dWeVgxOUlaV3h3WlhJeExrUmhkR1ZVYVcxbFRHbGlMblJwYldWemRHRnRjRlJ2UkdGMFpWdHliM1YwYVc1blhTQXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmMyOXNZV1I1TDJGMWVDMTNjbUZ3Y0dWeWN5MTBieTFrWlhCc2Iza3ZSR0YwWlZScGJXVlhjbUZ3Y0dWeUxuTnZiQzVFWVhSbFZHbHRaVmR5WVhCd1pYSmZYMGhsYkhCbGNqRXVSR0YwWlZScGJXVk1hV0l1WlhCdlkyaEVZWGxVYjBSaGRHVmJjbTkxZEdsdVoxMGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzTnZiR0ZrZVM5aGRYZ3RkM0poY0hCbGNuTXRkRzh0WkdWd2JHOTVMMFJoZEdWVWFXMWxWM0poY0hCbGNpNXpiMnd1UkdGMFpWUnBiV1ZYY21Gd2NHVnlYMTlJWld4d1pYSXhMa1JoZEdWVWFXMWxUR2xpTG5kbFpXdGtZWGxiY205MWRHbHVaMTBnWDE5cGJtbDBYMThLSUNBZ0lHVnljZ29LWDE5d2RYbGhYMkZ5WXpSZmNtOTFkR1Z5WDE5ZlgxOWlZWEpsWDJOeVpXRjBaVjlmUURFd09nb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDRUtJQ0FnSUNZbUNpQWdJQ0J5WlhSMWNtNEtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12YzI5c1lXUjVMMkYxZUMxM2NtRndjR1Z5Y3kxMGJ5MWtaWEJzYjNrdlJHRjBaVlJwYldWWGNtRndjR1Z5TG5OdmJDNUVZWFJsVkdsdFpWZHlZWEJ3WlhKZlgwaGxiSEJsY2pFdVJHRjBaVlJwYldWTWFXSXVkR2x0WlhOMFlXMXdWRzlFWVhSbFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzTnZiR0ZrZVM5aGRYZ3RkM0poY0hCbGNuTXRkRzh0WkdWd2JHOTVMMFJoZEdWVWFXMWxWM0poY0hCbGNpNXpiMnd1UkdGMFpWUnBiV1ZYY21Gd2NHVnlYMTlJWld4d1pYSXhMa1JoZEdWVWFXMWxUR2xpTG5ScGJXVnpkR0Z0Y0ZSdlJHRjBaVnR5YjNWMGFXNW5YVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERJMU5nb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWJ5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBDaUFnSUNCaWVpQXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmMyOXNZV1I1TDJGMWVDMTNjbUZ3Y0dWeWN5MTBieTFrWlhCc2Iza3ZSR0YwWlZScGJXVlhjbUZ3Y0dWeUxuTnZiQzVFWVhSbFZHbHRaVmR5WVhCd1pYSmZYMGhsYkhCbGNqRXVSR0YwWlZScGJXVk1hV0l1ZEdsdFpYTjBZVzF3Vkc5RVlYUmxXM0p2ZFhScGJtZGRYMkZtZEdWeVgybG1YMlZzYzJWQU5Rb2dJQ0FnWjJ4dlltRnNJRWR5YjNWd1UybDZaUW9nSUNBZ2FXNTBZMTh6SUM4dklESUtJQ0FnSUQ0OUNpQWdJQ0JoYzNObGNuUWdMeThnYUdWc2NHVnlPaUJ0ZFhOMElHSmxJR05oYkd4bFpDQnBiaUJuY205MWNBb2dJQ0FnWjNSNGJpQXdJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0o1ZEdWalh6RWdMeThnSW04aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRBb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJvWld4d1pYSTZJSFZ1WVhWMGFHOXlhWHBsWkNCallXeHNaWElLSUNBZ0lHZDBlRzRnTUNCVFpXNWtaWElLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYUdWc2NHVnlPaUJ6Wlc1a1pYSWdiV2x6YldGMFkyZ0tJQ0FnSUdKNWRHVmpYeklnTHk4Z0luQWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkQW9nSUNBZ1lub2dMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzTnZiR0ZrZVM5aGRYZ3RkM0poY0hCbGNuTXRkRzh0WkdWd2JHOTVMMFJoZEdWVWFXMWxWM0poY0hCbGNpNXpiMnd1UkdGMFpWUnBiV1ZYY21Gd2NHVnlYMTlJWld4d1pYSXhMa1JoZEdWVWFXMWxUR2xpTG5ScGJXVnpkR0Z0Y0ZSdlJHRjBaVnR5YjNWMGFXNW5YVjloWm5SbGNsOXBabDlsYkhObFFEVUtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaM1I0Ym5NZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lubDBaV05mTWlBdkx5QWljQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHaGxiSEJsY2pvZ2QzSnZibWNnY0hKbGRpQmphSFZ1YXdvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCbmRIaHVjMkVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbk1pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5Qm9aV3h3WlhJNklIZHliMjVuSUhCeVpYWWdiV1YwYUc5a0Nnb3ZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmMyOXNZV1I1TDJGMWVDMTNjbUZ3Y0dWeWN5MTBieTFrWlhCc2Iza3ZSR0YwWlZScGJXVlhjbUZ3Y0dWeUxuTnZiQzVFWVhSbFZHbHRaVmR5WVhCd1pYSmZYMGhsYkhCbGNqRXVSR0YwWlZScGJXVk1hV0l1ZEdsdFpYTjBZVzF3Vkc5RVlYUmxXM0p2ZFhScGJtZGRYMkZtZEdWeVgybG1YMlZzYzJWQU5Ub0tJQ0FnSUdSMWNBb2dJQ0FnWTJGc2JITjFZaUJFWVhSbFZHbHRaVXhwWWk1MGFXMWxjM1JoYlhCVWIwUmhkR1VLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmllbVZ5YndvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCa2FXY2dNUW9nSUNBZ1lud0tJQ0FnSUdScFp5QXpDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2ZG1WeVpteHZkd29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JrYVdjZ01nb2dJQ0FnWW53S0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklESUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmlmQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWXlBMUlDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzTnZiR0ZrZVM5aGRYZ3RkM0poY0hCbGNuTXRkRzh0WkdWd2JHOTVMMFJoZEdWVWFXMWxWM0poY0hCbGNpNXpiMnd1UkdGMFpWUnBiV1ZYY21Gd2NHVnlYMTlJWld4d1pYSXhMa1JoZEdWVWFXMWxUR2xpTG1Wd2IyTm9SR0Y1Vkc5RVlYUmxXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM052YkdGa2VTOWhkWGd0ZDNKaGNIQmxjbk10ZEc4dFpHVndiRzk1TDBSaGRHVlVhVzFsVjNKaGNIQmxjaTV6YjJ3dVJHRjBaVlJwYldWWGNtRndjR1Z5WDE5SVpXeHdaWEl4TGtSaGRHVlVhVzFsVEdsaUxtVndiMk5vUkdGNVZHOUVZWFJsVzNKdmRYUnBibWRkT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME1qVTJDaUFnSUNCaWVYUmxZMTh4SUM4dklDSnZJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFFLSUNBZ0lHSjZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OXpiMnhoWkhrdllYVjRMWGR5WVhCd1pYSnpMWFJ2TFdSbGNHeHZlUzlFWVhSbFZHbHRaVmR5WVhCd1pYSXVjMjlzTGtSaGRHVlVhVzFsVjNKaGNIQmxjbDlmU0dWc2NHVnlNUzVFWVhSbFZHbHRaVXhwWWk1bGNHOWphRVJoZVZSdlJHRjBaVnR5YjNWMGFXNW5YVjloWm5SbGNsOXBabDlsYkhObFFEVUtJQ0FnSUdkc2IySmhiQ0JIY205MWNGTnBlbVVLSUNBZ0lHbHVkR05mTXlBdkx5QXlDaUFnSUNBK1BRb2dJQ0FnWVhOelpYSjBJQzh2SUdobGJIQmxjam9nYlhWemRDQmlaU0JqWVd4c1pXUWdhVzRnWjNKdmRYQUtJQ0FnSUdkMGVHNGdNQ0JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKdklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYUdWc2NHVnlPaUIxYm1GMWRHaHZjbWw2WldRZ1kyRnNiR1Z5Q2lBZ0lDQm5kSGh1SURBZ1UyVnVaR1Z5Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdobGJIQmxjam9nYzJWdVpHVnlJRzFwYzIxaGRHTm9DaUFnSUNCaWVYUmxZMTh5SUM4dklDSndJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFFLSUNBZ0lHSjZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OXpiMnhoWkhrdllYVjRMWGR5WVhCd1pYSnpMWFJ2TFdSbGNHeHZlUzlFWVhSbFZHbHRaVmR5WVhCd1pYSXVjMjlzTGtSaGRHVlVhVzFsVjNKaGNIQmxjbDlmU0dWc2NHVnlNUzVFWVhSbFZHbHRaVXhwWWk1bGNHOWphRVJoZVZSdlJHRjBaVnR5YjNWMGFXNW5YVjloWm5SbGNsOXBabDlsYkhObFFEVUtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaM1I0Ym5NZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lubDBaV05mTWlBdkx5QWljQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHaGxiSEJsY2pvZ2QzSnZibWNnY0hKbGRpQmphSFZ1YXdvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCbmRIaHVjMkVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbk1pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5Qm9aV3h3WlhJNklIZHliMjVuSUhCeVpYWWdiV1YwYUc5a0Nnb3ZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmMyOXNZV1I1TDJGMWVDMTNjbUZ3Y0dWeWN5MTBieTFrWlhCc2Iza3ZSR0YwWlZScGJXVlhjbUZ3Y0dWeUxuTnZiQzVFWVhSbFZHbHRaVmR5WVhCd1pYSmZYMGhsYkhCbGNqRXVSR0YwWlZScGJXVk1hV0l1WlhCdlkyaEVZWGxVYjBSaGRHVmJjbTkxZEdsdVoxMWZZV1owWlhKZmFXWmZaV3h6WlVBMU9nb2dJQ0FnWkhWd0NpQWdJQ0JqWVd4c2MzVmlJRVJoZEdWVWFXMWxUR2xpTG1Wd2IyTm9SR0Y1Vkc5RVlYUmxDaUFnSUNCa2FXY2dNZ29nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1lucGxjbThLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWkdsbklERUtJQ0FnSUdKOENpQWdJQ0JrYVdjZ013b2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdaR2xuSURJS0lDQWdJR0o4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBeUNpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1lud0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV01nTlNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5emIyeGhaSGt2WVhWNExYZHlZWEJ3WlhKekxYUnZMV1JsY0d4dmVTOUVZWFJsVkdsdFpWZHlZWEJ3WlhJdWMyOXNMa1JoZEdWVWFXMWxWM0poY0hCbGNsOWZTR1ZzY0dWeU1TNUVZWFJsVkdsdFpVeHBZaTUzWldWclpHRjVXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM052YkdGa2VTOWhkWGd0ZDNKaGNIQmxjbk10ZEc4dFpHVndiRzk1TDBSaGRHVlVhVzFsVjNKaGNIQmxjaTV6YjJ3dVJHRjBaVlJwYldWWGNtRndjR1Z5WDE5SVpXeHdaWEl4TGtSaGRHVlVhVzFsVEdsaUxuZGxaV3RrWVhsYmNtOTFkR2x1WjEwNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUXlOVFlLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbThpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEFvZ0lDQWdZbm9nTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM052YkdGa2VTOWhkWGd0ZDNKaGNIQmxjbk10ZEc4dFpHVndiRzk1TDBSaGRHVlVhVzFsVjNKaGNIQmxjaTV6YjJ3dVJHRjBaVlJwYldWWGNtRndjR1Z5WDE5SVpXeHdaWEl4TGtSaGRHVlVhVzFsVEdsaUxuZGxaV3RrWVhsYmNtOTFkR2x1WjExZllXWjBaWEpmYVdaZlpXeHpaVUExQ2lBZ0lDQm5iRzlpWVd3Z1IzSnZkWEJUYVhwbENpQWdJQ0JwYm5Salh6TWdMeThnTWdvZ0lDQWdQajBLSUNBZ0lHRnpjMlZ5ZENBdkx5Qm9aV3h3WlhJNklHMTFjM1FnWW1VZ1kyRnNiR1ZrSUdsdUlHZHliM1Z3Q2lBZ0lDQm5kSGh1SURBZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lubDBaV05mTVNBdkx5QWlieUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHaGxiSEJsY2pvZ2RXNWhkWFJvYjNKcGVtVmtJR05oYkd4bGNnb2dJQ0FnWjNSNGJpQXdJRk5sYm1SbGNnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5Qm9aV3h3WlhJNklITmxibVJsY2lCdGFYTnRZWFJqYUFvZ0lDQWdZbmwwWldOZk1pQXZMeUFpY0NJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMENpQWdJQ0JpZWlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12YzI5c1lXUjVMMkYxZUMxM2NtRndjR1Z5Y3kxMGJ5MWtaWEJzYjNrdlJHRjBaVlJwYldWWGNtRndjR1Z5TG5OdmJDNUVZWFJsVkdsdFpWZHlZWEJ3WlhKZlgwaGxiSEJsY2pFdVJHRjBaVlJwYldWTWFXSXVkMlZsYTJSaGVWdHliM1YwYVc1blhWOWhablJsY2w5cFpsOWxiSE5sUURVS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1ozUjRibk1nUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWNDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdobGJIQmxjam9nZDNKdmJtY2djSEpsZGlCamFIVnVhd29nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBdENpQWdJQ0JuZEhodWMyRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUdKNWRHVmpYek1nTHk4Z0luTWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCb1pXeHdaWEk2SUhkeWIyNW5JSEJ5WlhZZ2JXVjBhRzlrQ2dvdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12YzI5c1lXUjVMMkYxZUMxM2NtRndjR1Z5Y3kxMGJ5MWtaWEJzYjNrdlJHRjBaVlJwYldWWGNtRndjR1Z5TG5OdmJDNUVZWFJsVkdsdFpWZHlZWEJ3WlhKZlgwaGxiSEJsY2pFdVJHRjBaVlJwYldWTWFXSXVkMlZsYTJSaGVWdHliM1YwYVc1blhWOWhablJsY2w5cFpsOWxiSE5sUURVNkNpQWdJQ0JrZFhBS0lDQWdJR05oYkd4emRXSWdSR0YwWlZScGJXVk1hV0l1ZDJWbGEyUmhlUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2ZG1WeVpteHZkd29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCaWVtVnlid29nSUNBZ1lud0tJQ0FnSUdKNWRHVmpJRFVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12YzI5c1lXUjVMMkYxZUMxM2NtRndjR1Z5Y3kxMGJ5MWtaWEJzYjNrdlJHRjBaVlJwYldWWGNtRndjR1Z5TG5OdmJDNUVZWFJsVkdsdFpWZHlZWEJ3WlhKZlgwaGxiSEJsY2pFdVgxOXBibWwwWDE5YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGZYMmx1YVhSZlh6b0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6TWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWJ5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnYUdWc2NHVnlPaUJoYkhKbFlXUjVJR2x1YVhScFlXeHBlbVZrQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0p2SWdvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ1lubDBaV05mTWlBdkx5QWljQ0lLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUdKNWRHVmpYek1nTHk4Z0luTWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZjMjlzWVdSNUwyRjFlQzEzY21Gd2NHVnljeTEwYnkxa1pYQnNiM2t2UkdGMFpWUnBiV1ZYY21Gd2NHVnlMbk52YkM1RVlYUmxWR2x0WlZkeVlYQndaWEpmWDBobGJIQmxjakV1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQUZJQUVJQW9DakJTWUlJUUVBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBRnZBWEFCY3dFQkJCVWZmSFVEQWpxeEFnRnRRZ0ZuaWdFRGkvK0FBd3I2YktBb3FrbU0veWNHcWttQUFvNnNva3NCb0NpcUtLQkxBWUFDQmJTaW9TaXFLS0JMQVlBREFqcXdxSUFBSndSUEFrMmhLS29uQjZKTUtLQW5CMHNDb3lpcUpLOUxBNEFnQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBU2lUd0tnS0tvb29Fc0RnQUZrb3FFb3FrOENUS0VvcW9BQkJVc0JveWlxZ0FFQ29DaXFnQUdab2t3b29Fc0JnQUwwLzZNb3FvQUNBd0dnS0txQUlBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQWdBb3FFb3FpY0VvQ2lxVGdKUVNSVWtDVnVBSUFNRUJRWUhDQWtLQ3d3QkFnQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFUQ05ZaS84bkJxS0FBZ0dRb3lpcVR3T2dLS3BMQVlBQkE2U0FBQ2NFVHdKTm9DaXFURThDaVlvQkF5RUVGb3YvVEtKSmlQN0lSZ05KaVA3Q1JnSk1TWWordTBoT0FraUkvclJPQWtZQ2lZb0JBU0VFRm92L1RLS0JBeGFnZ1FjV3FpTVdvSWt4RzBFQUt6RVpGRVF4R0VTQ0JBU0RUbm4yQk1vTk1PMEV5OGhubXdTcGJ2bUpOaG9BamdRQUNRQnhBTmtCSmdBeEdSUXhHQlFRUXpZYUFVa1ZJaEpFS1dSQkFDMHlCQ1VQUkRNQUdDbGtFa1F6QUFBeEFCSkVLbVJCQUJVeEZpTUpPQmdxWkJKRU1SWWpDVGthQUN0a0VrUkppUDlOU3dJVklnNUVJcTlQQTBzQnEwc0RGU0lPUkU4RFN3S3JVRXNDRlNJT1JFNENxMUFuQlV4UXNDTkROaG9CU1JVaUVrUXBaRUVBTFRJRUpROUVNd0FZS1dRU1JETUFBREVBRWtRcVpFRUFGVEVXSXdrNEdDcGtFa1F4RmlNSk9Sb0FLMlFTUkVtSS9idExBaFVpRGtRaXIwOERTd0dyU3dNVklnNUVUd05MQXF0UVN3SVZJZzVFVGdLclVDY0ZURkN3STBNMkdnRkpGU0lTUkNsa1FRQXRNZ1FsRDBRekFCZ3BaQkpFTXdBQU1RQVNSQ3BrUVFBVk1SWWpDVGdZS21RU1JERVdJd2s1R2dBclpCSkVTWWorcEVrVklnNUVJcStySndWTVVMQWpRellhQVVrVkpCSkVGellhQWtrVkpCSkVGellhQTBtQkFGa2xDRXNCRlJKRVZ3SUFLV1FVUkNsUEEyY3FUd0puSzB4bkkwTT0iLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo3LCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
