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

namespace Arc56.Generated.Marshal_AM.x500_algorand.X500Settler_d1c5aeb5
{


    public class X500SettlerProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public X500SettlerProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class SettleBatchArgCalls : AVMObjectType
            {
                public byte[] Field0 { get; set; }

                public Algorand.Address Field1 { get; set; }

                public byte[] Field2 { get; set; }

                public ulong Field3 { get; set; }

                public ulong Field4 { get; set; }

                public uint Field5 { get; set; }

                public bool Field6 { get; set; }

                public byte Field7 { get; set; }

                public ulong Field8 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[16]");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[16]");
                    vField2.From(Field2);
                    ret.AddRange(vField2.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField3.From(Field3);
                    ret.AddRange(vField3.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField4.From(Field4);
                    ret.AddRange(vField4.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField5 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint32");
                    vField5.From(Field5);
                    ret.AddRange(vField5.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField6 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vField6.From(Field6);
                    ret.AddRange(vField6.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField7 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vField7.From(Field7);
                    ret.AddRange(vField7.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField8 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField8.From(Field8);
                    ret.AddRange(vField8.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static SettleBatchArgCalls Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new SettleBatchArgCalls();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[16]");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is byte[] vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is Algorand.Address vField1Value) { ret.Field1 = vField1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[16]");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is byte[] vField2Value) { ret.Field2 = vField2Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField3 = vField3.ToValue();
                    if (valueField3 is ulong vField3Value) { ret.Field3 = vField3Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField4.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField4 = vField4.ToValue();
                    if (valueField4 is ulong vField4Value) { ret.Field4 = vField4Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField5 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint32");
                    count = vField5.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField5 = vField5.ToValue();
                    if (valueField5 is uint vField5Value) { ret.Field5 = vField5Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField6 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField6.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField6 = vField6.ToValue();
                    if (valueField6 is bool vField6Value) { ret.Field6 = vField6Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField7 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vField7.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField7 = vField7.ToValue();
                    if (valueField7 is byte vField7Value) { ret.Field7 = vField7Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField8 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField8.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField8 = vField8.ToValue();
                    if (valueField8 is ulong vField8Value) { ret.Field8 = vField8Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as SettleBatchArgCalls);
                }
                public bool Equals(SettleBatchArgCalls? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(SettleBatchArgCalls left, SettleBatchArgCalls right)
                {
                    return EqualityComparer<SettleBatchArgCalls>.Default.Equals(left, right);
                }
                public static bool operator !=(SettleBatchArgCalls left, SettleBatchArgCalls right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="poolAppId"> </param>
        /// <param name="authority"> </param>
        public async Task Init(ulong poolAppId, Algorand.Address authority, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 56, 173, 170, 34 };
            var poolAppIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); poolAppIdAbi.From(poolAppId);
            var authorityAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); authorityAbi.From(authority);

            var result = await base.CallApp(new List<object> { abiHandle, poolAppIdAbi, authorityAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Init_Transactions(ulong poolAppId, Algorand.Address authority, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 56, 173, 170, 34 };
            var poolAppIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); poolAppIdAbi.From(poolAppId);
            var authorityAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); authorityAbi.From(authority);

            return await base.MakeTransactionList(new List<object> { abiHandle, poolAppIdAbi, authorityAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="calls"> SettleBatchArgCalls</param>
        public async Task SettleBatch(Structs.SettleBatchArgCalls[] calls, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 152, 200, 36, 37 };
            var callsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.SettleBatchArgCalls>(x => Structs.SettleBatchArgCalls.Parse(x)) { IsFixedLength = false, FixedLength = 0 }; callsAbi.From(calls);

            var result = await base.CallApp(new List<object> { abiHandle, callsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SettleBatch_Transactions(Structs.SettleBatchArgCalls[] calls, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 152, 200, 36, 37 };
            var callsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.SettleBatchArgCalls>(x => Structs.SettleBatchArgCalls.Parse(x)) { IsFixedLength = false, FixedLength = 0 }; callsAbi.From(calls);

            return await base.MakeTransactionList(new List<object> { abiHandle, callsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="callId"> </param>
        public async Task<bool> IsSettled(byte[] callId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 205, 46, 141, 120 };
            var callIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(16, "byte"); callIdAbi.From(callId);

            var result = await base.SimApp(new List<object> { abiHandle, callIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsSettled_Transactions(byte[] callId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 205, 46, 141, 120 };
            var callIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(16, "byte"); callIdAbi.From(callId);

            return await base.MakeTransactionList(new List<object> { abiHandle, callIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiWDUwMFNldHRsZXIiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiU2V0dGxlQmF0Y2hBcmdDYWxscyI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJ1aW50OFsxNl0ifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6ImZpZWxkMiIsInR5cGUiOiJ1aW50OFsxNl0ifSx7Im5hbWUiOiJmaWVsZDMiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQ0IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkNSIsInR5cGUiOiJ1aW50MzIifSx7Im5hbWUiOiJmaWVsZDYiLCJ0eXBlIjoiYm9vbCJ9LHsibmFtZSI6ImZpZWxkNyIsInR5cGUiOiJ1aW50OCJ9LHsibmFtZSI6ImZpZWxkOCIsInR5cGUiOiJ1aW50NjQifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiaW5pdCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwb29sQXBwSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhdXRob3JpdHkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0dGxlX2JhdGNoIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6Iih1aW50OFsxNl0sYWRkcmVzcyx1aW50OFsxNl0sdWludDY0LHVpbnQ2NCx1aW50MzIsYm9vbCx1aW50OCx1aW50NjQpW10iLCJzdHJ1Y3QiOiJTZXR0bGVCYXRjaEFyZ0NhbGxzIiwibmFtZSI6ImNhbGxzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImlzX3NldHRsZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMTZdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FsbElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjIsImJ5dGVzIjoxfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsxMjhdLCJlcnJvck1lc3NhZ2UiOiJhbHJlYWR5IGluaXRpYWxpemVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjMxXSwiZXJyb3JNZXNzYWdlIjoiYWxyZWFkeSBzZXR0bGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTI2LDE2MywxNzAsMjQzXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgR2xvYmFsU3RhdGUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTkxXSwiZXJyb3JNZXNzYWdlIjoiaW5kZXggYWNjZXNzIGlzIG91dCBvZiBib3VuZHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudHVwbGU8YXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMTY+LGFjY291bnQsYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMTY+LHVpbnQ2NCx1aW50NjQsYXJjNC51aW50MzIsYm9vbCxhcmM0LnVpbnQ4LHVpbnQ2ND4+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjk4XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDE2PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyMl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjRdLCJlcnJvck1lc3NhZ2UiOiJub3QgaW5pdGlhbGl6ZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNzJdLCJlcnJvck1lc3NhZ2UiOiJub3Qgc2V0dGxlciBhdXRob3JpdHkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01DQXhJRGswQ2lBZ0lDQmllWFJsWTJKc2IyTnJJQ0pwYm1sMGFXRnNhWHBsWkNJZ0luQnZiMnhCY0hBaUlDSnpaWFIwYkdWeVFYVjBhRzl5YVhSNUlpQWljeUlLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpYm5vZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFESUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OVlOVEF3VTJWMGRHeGxjaTVoYkdkdkxuUnpPak0yQ2lBZ0lDQXZMeUJwYm1sMGFXRnNhWHBsWkNBOUlFZHNiMkpoYkZOMFlYUmxQR0p2YjJ4bFlXNCtLSHNnYVc1cGRHbGhiRlpoYkhWbE9pQm1ZV3h6WlNCOUtUc0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltbHVhWFJwWVd4cGVtVmtJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDZ3B0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpvS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5WU5UQXdVMlYwZEd4bGNpNWhiR2R2TG5Sek9qTXpDaUFnSUNBdkx5QmxlSEJ2Y25RZ1pHVm1ZWFZzZENCamJHRnpjeUJZTlRBd1UyVjBkR3hsY2lCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0JpZWlCdFlXbHVYMTlmWVd4bmIzUnpYMTh1WkdWbVlYVnNkRU55WldGMFpVQXhNZ29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjRNemhoWkdGaE1qSWdNSGc1T0dNNE1qUXlOU0F3ZUdOa01tVTRaRGM0SUM4dklHMWxkR2h2WkNBaWFXNXBkQ2gxYVc1ME5qUXNZV1JrY21WemN5bDJiMmxrSWl3Z2JXVjBhRzlrSUNKelpYUjBiR1ZmWW1GMFkyZ29LSFZwYm5RNFd6RTJYU3hoWkdSeVpYTnpMSFZwYm5RNFd6RTJYU3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblF6TWl4aWIyOXNMSFZwYm5RNExIVnBiblEyTkNsYlhTbDJiMmxrSWl3Z2JXVjBhRzlrSUNKcGMxOXpaWFIwYkdWa0tIVnBiblE0V3pFMlhTbGliMjlzSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ2FXNXBkQ0J6WlhSMGJHVkNZWFJqYUNCcGMxTmxkSFJzWldRS0lDQWdJR1Z5Y2dvS2JXRnBibDlmWDJGc1oyOTBjMTlmTG1SbFptRjFiSFJEY21WaGRHVkFNVEk2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12V0RVd01GTmxkSFJzWlhJdVlXeG5ieTUwY3pvek13b2dJQ0FnTHk4Z1pYaHdiM0owSUdSbFptRjFiSFFnWTJ4aGMzTWdXRFV3TUZObGRIUnNaWElnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSVFvZ0lDQWdKaVlLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJR052Ym5SeVlXTjBjeTlZTlRBd1UyVjBkR3hsY2k1aGJHZHZMblJ6T2pwWU5UQXdVMlYwZEd4bGNpNXBibWwwVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2FXNXBkRG9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlZTlRBd1UyVjBkR3hsY2k1aGJHZHZMblJ6T2pRd0NpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2dibUZ0WlRvZ0ltbHVhWFFpSUgwcENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDFnMU1EQlRaWFIwYkdWeUxtRnNaMjh1ZEhNNk5ESUtJQ0FnSUM4dklHRnpjMlZ5ZENnaGRHaHBjeTVwYm1sMGFXRnNhWHBsWkM1MllXeDFaU3dnSW1Gc2NtVmhaSGtnYVc1cGRHbGhiR2w2WldRaUtUc0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCamIyNTBjbUZqZEhNdldEVXdNRk5sZEhSc1pYSXVZV3huYnk1MGN6b3pOZ29nSUNBZ0x5OGdhVzVwZEdsaGJHbDZaV1FnUFNCSGJHOWlZV3hUZEdGMFpUeGliMjlzWldGdVBpaDdJR2x1YVhScFlXeFdZV3gxWlRvZ1ptRnNjMlVnZlNrN0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKcGJtbDBhV0ZzYVhwbFpDSUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OVlOVEF3VTJWMGRHeGxjaTVoYkdkdkxuUnpPalF5Q2lBZ0lDQXZMeUJoYzNObGNuUW9JWFJvYVhNdWFXNXBkR2xoYkdsNlpXUXVkbUZzZFdVc0lDSmhiSEpsWVdSNUlHbHVhWFJwWVd4cGVtVmtJaWs3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUdGc2NtVmhaSGtnYVc1cGRHbGhiR2w2WldRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5WU5UQXdVMlYwZEd4bGNpNWhiR2R2TG5Sek9qTTBDaUFnSUNBdkx5QndiMjlzUVhCd0lEMGdSMnh2WW1Gc1UzUmhkR1U4UVhCd2JHbGpZWFJwYjI0K0tDazdDaUFnSUNCaWVYUmxZMTh4SUM4dklDSndiMjlzUVhCd0lnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwxZzFNREJUWlhSMGJHVnlMbUZzWjI4dWRITTZORE1LSUNBZ0lDOHZJSFJvYVhNdWNHOXZiRUZ3Y0M1MllXeDFaU0E5SUhCdmIyeEJjSEJKWkRzS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlZTlRBd1UyVjBkR3hsY2k1aGJHZHZMblJ6T2pNMUNpQWdJQ0F2THlCelpYUjBiR1Z5UVhWMGFHOXlhWFI1SUQwZ1IyeHZZbUZzVTNSaGRHVThRV05qYjNWdWRENG9LVHNLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbk5sZEhSc1pYSkJkWFJvYjNKcGRIa2lDaUFnSUNBdkx5QmpiMjUwY21GamRITXZXRFV3TUZObGRIUnNaWEl1WVd4bmJ5NTBjem8wTkFvZ0lDQWdMeThnZEdocGN5NXpaWFIwYkdWeVFYVjBhRzl5YVhSNUxuWmhiSFZsSUQwZ1lYVjBhRzl5YVhSNU93b2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OVlOVEF3VTJWMGRHeGxjaTVoYkdkdkxuUnpPak0yQ2lBZ0lDQXZMeUJwYm1sMGFXRnNhWHBsWkNBOUlFZHNiMkpoYkZOMFlYUmxQR0p2YjJ4bFlXNCtLSHNnYVc1cGRHbGhiRlpoYkhWbE9pQm1ZV3h6WlNCOUtUc0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltbHVhWFJwWVd4cGVtVmtJZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMWcxTURCVFpYUjBiR1Z5TG1Gc1oyOHVkSE02TkRVS0lDQWdJQzh2SUhSb2FYTXVhVzVwZEdsaGJHbDZaV1F1ZG1Gc2RXVWdQU0IwY25WbE93b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdldEVXdNRk5sZEhSc1pYSXVZV3huYnk1MGN6bzBNQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUc1aGJXVTZJQ0pwYm1sMElpQjlLUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklHTnZiblJ5WVdOMGN5OVlOVEF3VTJWMGRHeGxjaTVoYkdkdkxuUnpPanBZTlRBd1UyVjBkR3hsY2k1elpYUjBiR1ZDWVhSamFGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbk5sZEhSc1pVSmhkR05vT2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDFnMU1EQlRaWFIwYkdWeUxtRnNaMjh1ZEhNNk5EZ0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ1WVcxbE9pQWljMlYwZEd4bFgySmhkR05vSWlCOUtRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd2JpQXlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JwYm5Salh6SWdMeThnT1RRS0lDQWdJQ29LSUNBZ0lIQjFjMmhwYm5RZ01nb2dJQ0FnS3dvZ0lDQWdjM2RoY0FvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MGRYQnNaVHhoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBeE5qNHNZV05qYjNWdWRDeGhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F4Tmo0c2RXbHVkRFkwTEhWcGJuUTJOQ3hoY21NMExuVnBiblF6TWl4aWIyOXNMR0Z5WXpRdWRXbHVkRGdzZFdsdWREWTBQajRLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlZTlRBd1UyVjBkR3hsY2k1aGJHZHZMblJ6T2pVd0NpQWdJQ0F2THlCaGMzTmxjblFvZEdocGN5NXBibWwwYVdGc2FYcGxaQzUyWVd4MVpTd2dJbTV2ZENCcGJtbDBhV0ZzYVhwbFpDSXBPd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OVlOVEF3VTJWMGRHeGxjaTVoYkdkdkxuUnpPak0yQ2lBZ0lDQXZMeUJwYm1sMGFXRnNhWHBsWkNBOUlFZHNiMkpoYkZOMFlYUmxQR0p2YjJ4bFlXNCtLSHNnYVc1cGRHbGhiRlpoYkhWbE9pQm1ZV3h6WlNCOUtUc0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltbHVhWFJwWVd4cGVtVmtJZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMWcxTURCVFpYUjBiR1Z5TG1Gc1oyOHVkSE02TlRBS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxtbHVhWFJwWVd4cGVtVmtMblpoYkhWbExDQWlibTkwSUdsdWFYUnBZV3hwZW1Wa0lpazdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnWVhOelpYSjBJQzh2SUc1dmRDQnBibWwwYVdGc2FYcGxaQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMWcxTURCVFpYUjBiR1Z5TG1Gc1oyOHVkSE02TlRFS0lDQWdJQzh2SUdGemMyVnlkQ2hVZUc0dWMyVnVaR1Z5SUQwOVBTQjBhR2x6TG5ObGRIUnNaWEpCZFhSb2IzSnBkSGt1ZG1Gc2RXVXNJQ0p1YjNRZ2MyVjBkR3hsY2lCaGRYUm9iM0pwZEhraUtUc0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12V0RVd01GTmxkSFJzWlhJdVlXeG5ieTUwY3pvek5Rb2dJQ0FnTHk4Z2MyVjBkR3hsY2tGMWRHaHZjbWwwZVNBOUlFZHNiMkpoYkZOMFlYUmxQRUZqWTI5MWJuUStLQ2s3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0p6WlhSMGJHVnlRWFYwYUc5eWFYUjVJZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMWcxTURCVFpYUjBiR1Z5TG1Gc1oyOHVkSE02TlRFS0lDQWdJQzh2SUdGemMyVnlkQ2hVZUc0dWMyVnVaR1Z5SUQwOVBTQjBhR2x6TG5ObGRIUnNaWEpCZFhSb2IzSnBkSGt1ZG1Gc2RXVXNJQ0p1YjNRZ2MyVjBkR3hsY2lCaGRYUm9iM0pwZEhraUtUc0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRzV2ZENCelpYUjBiR1Z5SUdGMWRHaHZjbWwwZVFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDFnMU1EQlRaWFIwYkdWeUxtRnNaMjh1ZEhNNk5UTUtJQ0FnSUM4dklHWnZjaUFvYkdWMElHa2dQU0JWYVc1ME5qUW9NQ2s3SUdrZ1BDQmpZV3hzY3k1c1pXNW5kR2c3SUdrZ1BTQnBJQ3NnVldsdWREWTBLREVwS1NCN0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvS2MyVjBkR3hsUW1GMFkyaGZkMmhwYkdWZmRHOXdRREk2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12V0RVd01GTmxkSFJzWlhJdVlXeG5ieTUwY3pvMU13b2dJQ0FnTHk4Z1ptOXlJQ2hzWlhRZ2FTQTlJRlZwYm5RMk5DZ3dLVHNnYVNBOElHTmhiR3h6TG14bGJtZDBhRHNnYVNBOUlHa2dLeUJWYVc1ME5qUW9NU2twSUhzS0lDQWdJR1IxY0FvZ0lDQWdaR2xuSURJS0lDQWdJRHdLSUNBZ0lHSjZJSE5sZEhSc1pVSmhkR05vWDJGbWRHVnlYM2RvYVd4bFFEVUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OVlOVEF3VTJWMGRHeGxjaTVoYkdkdkxuUnpPalUwTFRVMUNpQWdJQ0F2THlCamIyNXpkQ0JqWVd4c0lEMGdZMnh2Ym1Vb1kyRnNiSE5iYVYwcE93b2dJQ0FnTHk4Z1kyOXVjM1FnYzJ4MVp5QTlJR05zYjI1bEtHTmhiR3hiTUYwcE93b2dJQ0FnWkdsbklESUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVc1MFkxOHlJQzh2SURrMENpQWdJQ0FxQ2lBZ0lDQnBiblJqWHpJZ0x5OGdPVFFLSUNBZ0lHVjRkSEpoWTNReklDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQmhZMk5sYzNNZ2FYTWdiM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdaSFZ3Q2lBZ0lDQmxlSFJ5WVdOMElEQWdNVFlLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlZTlRBd1UyVjBkR3hsY2k1aGJHZHZMblJ6T2pVMkNpQWdJQ0F2THlCamIyNXpkQ0JoWjJWdWRDQTlJR05oYkd4Yk1WMDdDaUFnSUNCa2FXY2dNUW9nSUNBZ1pYaDBjbUZqZENBeE5pQXpNZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMWcxTURCVFpYUjBiR1Z5TG1Gc1oyOHVkSE02TlRjS0lDQWdJQzh2SUdOdmJuTjBJR05oYkd4SlpDQTlJR05zYjI1bEtHTmhiR3hiTWwwcE93b2dJQ0FnWkdsbklESUtJQ0FnSUdWNGRISmhZM1FnTkRnZ01UWUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OVlOVEF3VTJWMGRHeGxjaTVoYkdkdkxuUnpPalU0Q2lBZ0lDQXZMeUJqYjI1emRDQndjbVZ0YVhWdElEMGdZMkZzYkZzelhUc0tJQ0FnSUdScFp5QXpDaUFnSUNCbGVIUnlZV04wSURZMElEZ0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OVlOVEF3VTJWMGRHeGxjaTVoYkdkdkxuUnpPalU1Q2lBZ0lDQXZMeUJqYjI1emRDQnlaV1oxYm1RZ1BTQmpZV3hzV3pSZE93b2dJQ0FnWkdsbklEUUtJQ0FnSUdWNGRISmhZM1FnTnpJZ09Bb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwxZzFNREJUWlhSMGJHVnlMbUZzWjI4dWRITTZOakFLSUNBZ0lDOHZJR052Ym5OMElHSnlaV0ZqYUNBOUlHTmhiR3hiTmwwN0NpQWdJQ0IxYm1OdmRtVnlJRFVLSUNBZ0lIQjFjMmhwYm5RZ05qY3lDaUFnSUNCblpYUmlhWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlZTlRBd1UyVjBkR3hsY2k1aGJHZHZMblJ6T2pNNENpQWdJQ0F2THlCelpYUjBiR1ZrUTJGc2JITWdQU0JDYjNoTllYQThRMkZzYkVsa01UWXNJR0p2YjJ4bFlXNCtLSHNnYTJWNVVISmxabWw0T2lBaWN5SWdmU2s3Q2lBZ0lDQmllWFJsWTE4eklDOHZJQ0p6SWdvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlZTlRBd1UyVjBkR3hsY2k1aGJHZHZMblJ6T2pZeUNpQWdJQ0F2THlCaGMzTmxjblFvSVhSb2FYTXVjMlYwZEd4bFpFTmhiR3h6S0dOaGJHeEpaQ2t1WlhocGMzUnpMQ0FpWVd4eVpXRmtlU0J6WlhSMGJHVmtJaWs3Q2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJR0ZzY21WaFpIa2djMlYwZEd4bFpBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwxZzFNREJUWlhSMGJHVnlMbUZzWjI4dWRITTZOalF0TmprS0lDQWdJQzh2SUdGaWFVTmhiR3dvZXdvZ0lDQWdMeThnSUNCdFpYUm9iMlE2SUZnMU1EQlFiMjlzTG5CeWIzUnZkSGx3WlM1aGNIQnNlVk5sZEhSc1pXMWxiblFzQ2lBZ0lDQXZMeUFnSUdGd2NFbGtPaUIwYUdsekxuQnZiMnhCY0hBdWRtRnNkV1VzQ2lBZ0lDQXZMeUFnSUdGeVozTTZJRnR6YkhWbkxDQmhaMlZ1ZEN3Z2NISmxiV2wxYlN3Z2NtVm1kVzVrTENCaWNtVmhZMmhkTEFvZ0lDQWdMeThnSUNCbVpXVTZJREFzQ2lBZ0lDQXZMeUI5S1RzS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlZTlRBd1UyVjBkR3hsY2k1aGJHZHZMblJ6T2pZM0NpQWdJQ0F2THlCaGNtZHpPaUJiYzJ4MVp5d2dZV2RsYm5Rc0lIQnlaVzFwZFcwc0lISmxablZ1WkN3Z1luSmxZV05vWFN3S0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCelpYUmlhWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlZTlRBd1UyVjBkR3hsY2k1aGJHZHZMblJ6T2pZMkNpQWdJQ0F2THlCaGNIQkpaRG9nZEdocGN5NXdiMjlzUVhCd0xuWmhiSFZsTEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlZTlRBd1UyVjBkR3hsY2k1aGJHZHZMblJ6T2pNMENpQWdJQ0F2THlCd2IyOXNRWEJ3SUQwZ1IyeHZZbUZzVTNSaGRHVThRWEJ3YkdsallYUnBiMjQrS0NrN0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKd2IyOXNRWEJ3SWdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDFnMU1EQlRaWFIwYkdWeUxtRnNaMjh1ZEhNNk5qWUtJQ0FnSUM4dklHRndjRWxrT2lCMGFHbHpMbkJ2YjJ4QmNIQXVkbUZzZFdVc0NpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdldEVXdNRk5sZEhSc1pYSXVZV3huYnk1MGN6bzJOQzAyT1FvZ0lDQWdMeThnWVdKcFEyRnNiQ2g3Q2lBZ0lDQXZMeUFnSUcxbGRHaHZaRG9nV0RVd01GQnZiMnd1Y0hKdmRHOTBlWEJsTG1Gd2NHeDVVMlYwZEd4bGJXVnVkQ3dLSUNBZ0lDOHZJQ0FnWVhCd1NXUTZJSFJvYVhNdWNHOXZiRUZ3Y0M1MllXeDFaU3dLSUNBZ0lDOHZJQ0FnWVhKbmN6b2dXM05zZFdjc0lHRm5aVzUwTENCd2NtVnRhWFZ0TENCeVpXWjFibVFzSUdKeVpXRmphRjBzQ2lBZ0lDQXZMeUFnSUdabFpUb2dNQ3dLSUNBZ0lDOHZJSDBwT3dvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TVdWaFpXUmxNVGtnTHk4Z2JXVjBhRzlrSUNKaGNIQnNlVjl6WlhSMGJHVnRaVzUwS0hWcGJuUTRXekUyWFN4aFpHUnlaWE56TEhWcGJuUTJOQ3gxYVc1ME5qUXNZbTl2YkNsMmIybGtJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJSFZ1WTI5MlpYSWdOUW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCd2RYTm9hVzUwSURZZ0x5OGdZWEJ3YkFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMWcxTURCVFpYUjBiR1Z5TG1Gc1oyOHVkSE02TmpnS0lDQWdJQzh2SUdabFpUb2dNQ3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMWcxTURCVFpYUjBiR1Z5TG1Gc1oyOHVkSE02TmpRdE5qa0tJQ0FnSUM4dklHRmlhVU5oYkd3b2V3b2dJQ0FnTHk4Z0lDQnRaWFJvYjJRNklGZzFNREJRYjI5c0xuQnliM1J2ZEhsd1pTNWhjSEJzZVZObGRIUnNaVzFsYm5Rc0NpQWdJQ0F2THlBZ0lHRndjRWxrT2lCMGFHbHpMbkJ2YjJ4QmNIQXVkbUZzZFdVc0NpQWdJQ0F2THlBZ0lHRnlaM002SUZ0emJIVm5MQ0JoWjJWdWRDd2djSEpsYldsMWJTd2djbVZtZFc1a0xDQmljbVZoWTJoZExBb2dJQ0FnTHk4Z0lDQm1aV1U2SURBc0NpQWdJQ0F2THlCOUtUc0tJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdldEVXdNRk5sZEhSc1pYSXVZV3huYnk1MGN6bzNNUW9nSUNBZ0x5OGdkR2hwY3k1elpYUjBiR1ZrUTJGc2JITW9ZMkZzYkVsa0tTNTJZV3gxWlNBOUlIUnlkV1U3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2FYUnZZZ29nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDFnMU1EQlRaWFIwYkdWeUxtRnNaMjh1ZEhNNk5UTUtJQ0FnSUM4dklHWnZjaUFvYkdWMElHa2dQU0JWYVc1ME5qUW9NQ2s3SUdrZ1BDQmpZV3hzY3k1c1pXNW5kR2c3SUdrZ1BTQnBJQ3NnVldsdWREWTBLREVwS1NCN0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdLd29nSUNBZ1lpQnpaWFIwYkdWQ1lYUmphRjkzYUdsc1pWOTBiM0JBTWdvS2MyVjBkR3hsUW1GMFkyaGZZV1owWlhKZmQyaHBiR1ZBTlRvS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5WU5UQXdVMlYwZEd4bGNpNWhiR2R2TG5Sek9qUTRDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnYm1GdFpUb2dJbk5sZEhSc1pWOWlZWFJqYUNJZ2ZTa0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCamIyNTBjbUZqZEhNdldEVXdNRk5sZEhSc1pYSXVZV3huYnk1MGN6bzZXRFV3TUZObGRIUnNaWEl1YVhOVFpYUjBiR1ZrVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2FYTlRaWFIwYkdWa09nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwxZzFNREJUWlhSMGJHVnlMbUZzWjI4dWRITTZOelVLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCdVlXMWxPaUFpYVhOZmMyVjBkR3hsWkNJc0lISmxZV1J2Ym14NU9pQjBjblZsSUgwcENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQXhOZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNVFkrQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12V0RVd01GTmxkSFJzWlhJdVlXeG5ieTUwY3pvek9Bb2dJQ0FnTHk4Z2MyVjBkR3hsWkVOaGJHeHpJRDBnUW05NFRXRndQRU5oYkd4SlpERTJMQ0JpYjI5c1pXRnVQaWg3SUd0bGVWQnlaV1pwZURvZ0luTWlJSDBwT3dvZ0lDQWdZbmwwWldOZk15QXZMeUFpY3lJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwxZzFNREJUWlhSMGJHVnlMbUZzWjI4dWRITTZOemdLSUNBZ0lDOHZJSEpsZEhWeWJpQjBhR2x6TG5ObGRIUnNaV1JEWVd4c2N5aGpZV3hzU1dRcExtVjRhWE4wY3pzS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMWcxTURCVFpYUjBiR1Z5TG1Gc1oyOHVkSE02TnpVS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2V5QnVZVzFsT2lBaWFYTmZjMlYwZEd4bFpDSXNJSEpsWVdSdmJteDVPaUIwY25WbElIMHBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlYwWW1sMENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200SyIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVLSUNBZ0lISmxkSFZ5YmdvPSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QURBQUZlSmdRTGFXNXBkR2xoYkdsNlpXUUhjRzl2YkVGd2NCQnpaWFIwYkdWeVFYVjBhRzl5YVhSNUFYTXhHRUFBQXlnaVp6RWJRUUFrTVJrVVJERVlSSUlEQkRpdHFpSUVtTWdrSlFUTkxvMTROaG9BamdNQUNRQXVBTU1BTVJrVU1SZ1VFRU0yR2dGSkZZRUlFa1FYTmhvQ1NSV0JJQkpFSWlobFJCUkVLVThDWnlwTVp5Z2paeU5ETmhvQlJ3SWlXVWxPQWlRTGdRSUlUQlVTUkNJb1pVUkVNUUFpS21WRUVrUWlTVXNDREVFQWEwc0NWd0lBU3dFa0N5UllTVmNBRUVzQlZ4QWdTd0pYTUJCTEExZEFDRXNFVjBnSVR3V0JvQVZUSzA4RVVFbTlSUUVVUkxHQUFRQWlUd05VSWlsbFJMSVlnQVFlcnQ0WnNocFBCYklhVHdTeUdrOERzaHBQQXJJYXNocUJCcklRSXJJQnN5TVd2eU1JUXYrT0kwTTJHZ0ZKRllFUUVrUXJURkM5UlFHQUFRQWlUd0pVZ0FRVkgzeDFURkN3STBNPSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjksInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
