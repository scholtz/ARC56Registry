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

namespace Arc56.Generated.algorandfoundation.puya.TemplateVariablesContract_36dfb5d4
{


    public class TemplateVariablesContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public TemplateVariablesContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class AStruct : AVMObjectType
            {
                public ulong A { get; set; }

                public ulong B { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vA.From(A);
                    ret.AddRange(vA.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vB.From(B);
                    ret.AddRange(vB.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static AStruct Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new AStruct();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vA.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueA = vA.ToValue();
                    if (valueA is ulong vAValue) { ret.A = vAValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vB.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueB = vB.ToValue();
                    if (valueB is ulong vBValue) { ret.B = vBValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as AStruct);
                }
                public bool Equals(AStruct? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(AStruct left, AStruct right)
                {
                    return EqualityComparer<AStruct>.Default.Equals(left, right);
                }
                public static bool operator !=(AStruct left, AStruct right)
                {
                    return !(left == right);
                }

            }

            public class ATuple : AVMObjectType
            {
                public ulong A { get; set; }

                public ulong B { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vA.From(A);
                    ret.AddRange(vA.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vB.From(B);
                    ret.AddRange(vB.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ATuple Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new ATuple();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vA.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueA = vA.ToValue();
                    if (valueA is ulong vAValue) { ret.A = vAValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vB.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueB = vB.ToValue();
                    if (valueB is ulong vBValue) { ret.B = vBValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ATuple);
                }
                public bool Equals(ATuple? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ATuple left, ATuple right)
                {
                    return EqualityComparer<ATuple>.Default.Equals(left, right);
                }
                public static bool operator !=(ATuple left, ATuple right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<byte[]> GetBytes(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 47, 202, 221, 246 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> GetBytes_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 47, 202, 221, 246 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt512> GetBigUint(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 55, 246, 76, 243 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> GetBigUint_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 55, 246, 76, 243 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.ATuple> GetANamedTuple(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 37, 252, 177, 177 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.ATuple.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetANamedTuple_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 37, 252, 177, 177 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.AStruct> GetATuple(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 149, 253, 138, 209 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.AStruct.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetATuple_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 149, 253, 138, 209 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.AStruct> GetAStruct(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 180, 206, 250, 57 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.AStruct.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetAStruct_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 180, 206, 250, 57 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiVGVtcGxhdGVWYXJpYWJsZXNDb250cmFjdCIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJBU3RydWN0IjpbeyJuYW1lIjoiYSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJiIiwidHlwZSI6InVpbnQ2NCJ9XSwiQVR1cGxlIjpbeyJuYW1lIjoiYSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJiIiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJnZXRfYnl0ZXMiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfYmlnX3VpbnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDUxMiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2FfbmFtZWRfdHVwbGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiQVR1cGxlIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2FfdHVwbGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiQVN0cnVjdCIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9hX3N0cnVjdCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJBU3RydWN0IiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbIkRlbGV0ZUFwcGxpY2F0aW9uIiwiVXBkYXRlQXBwbGljYXRpb24iXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsxNzddLCJlcnJvck1lc3NhZ2UiOiJvdmVyZmxvdyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXhJRFkwSUZSTlVFeGZSRVZNUlZSQlFreEZJRlJOVUV4ZlZWQkVRVlJCUWt4RkNpQWdJQ0JpZVhSbFkySnNiMk5ySURCNE1UVXhaamRqTnpVZ1ZFMVFURjlUVDAxRlgwSlpWRVZUSUZSTlVFeGZVMDlOUlY5Q1NVZGZWVWxPVkNCVVRWQk1YMDVCVFVWRVgxUlZVRXhGSUZSTlVFeGZWRlZRVEVVZ1ZFMVFURjlUVkZKVlExUUtJQ0FnSUM4dklIUmxiWEJzWVhSbFgzWmhjbWxoWW14bGN5OWpiMjUwY21GamRDNXdlVG94TndvZ0lDQWdMeThnWTJ4aGMzTWdWR1Z0Y0d4aGRHVldZWEpwWVdKc1pYTkRiMjUwY21GamRDaGhjbU0wTGtGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNGdUblZ0UVhCd1FYSm5jd29nSUNBZ1lub2diV0ZwYmw5aVlYSmxYM0p2ZFhScGJtZEFNVElLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2NIVnphR0o1ZEdWemN5QXdlREptWTJGa1pHWTJJREI0TXpkbU5qUmpaak1nTUhneU5XWmpZakZpTVNBd2VEazFabVE0WVdReElEQjRZalJqWldaaE16a2dMeThnYldWMGFHOWtJQ0puWlhSZllubDBaWE1vS1dKNWRHVmJYU0lzSUcxbGRHaHZaQ0FpWjJWMFgySnBaMTkxYVc1MEtDbDFhVzUwTlRFeUlpd2diV1YwYUc5a0lDSm5aWFJmWVY5dVlXMWxaRjkwZFhCc1pTZ3BLSFZwYm5RMk5DeDFhVzUwTmpRcElpd2diV1YwYUc5a0lDSm5aWFJmWVY5MGRYQnNaU2dwS0hWcGJuUTJOQ3gxYVc1ME5qUXBJaXdnYldWMGFHOWtJQ0puWlhSZllWOXpkSEoxWTNRb0tTaDFhVzUwTmpRc2RXbHVkRFkwS1NJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHZGxkRjlpZVhSbGN5Qm5aWFJmWW1sblgzVnBiblFnWjJWMFgyRmZibUZ0WldSZmRIVndiR1VnWjJWMFgyRmZkSFZ3YkdVZ1oyVjBYMkZmYzNSeWRXTjBDZ3B0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRjNkNpQWdJQ0F2THlCMFpXMXdiR0YwWlY5MllYSnBZV0pzWlhNdlkyOXVkSEpoWTNRdWNIazZNVGNLSUNBZ0lDOHZJR05zWVhOeklGUmxiWEJzWVhSbFZtRnlhV0ZpYkdWelEyOXVkSEpoWTNRb1lYSmpOQzVCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnWlhKeUNncHRZV2x1WDJKaGNtVmZjbTkxZEdsdVowQXhNam9LSUNBZ0lDOHZJSFJsYlhCc1lYUmxYM1poY21saFlteGxjeTlqYjI1MGNtRmpkQzV3ZVRveE53b2dJQ0FnTHk4Z1kyeGhjM01nVkdWdGNHeGhkR1ZXWVhKcFlXSnNaWE5EYjI1MGNtRmpkQ2hoY21NMExrRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0J6ZDJsMFkyZ2diV0ZwYmw5ZlgyRnNaMjl3ZVY5a1pXWmhkV3gwWDJOeVpXRjBaVUF4TXlCdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1UY2diV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREUzSUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeE55QnRZV2x1WDI5dVgzVndaR0YwWlVBeE5DQnRZV2x1WDI5dVgyUmxiR1YwWlVBeE5Rb2dJQ0FnWlhKeUNncHRZV2x1WDI5dVgyUmxiR1YwWlVBeE5Ub0tJQ0FnSUM4dklIUmxiWEJzWVhSbFgzWmhjbWxoWW14bGN5OWpiMjUwY21GamRDNXdlVG96TVFvZ0lDQWdMeThnUUdGeVl6UXVZbUZ5WlcxbGRHaHZaQ2hoYkd4dmQxOWhZM1JwYjI1elBWc2lSR1ZzWlhSbFFYQndiR2xqWVhScGIyNGlYU2tLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklIUmxiWEJzWVhSbFgzWmhjbWxoWW14bGN5OWpiMjUwY21GamRDNXdlVG96TXdvZ0lDQWdMeThnWVhOelpYSjBJRlJsYlhCc1lYUmxWbUZ5VzFWSmJuUTJORjBvSWtSRlRFVlVRVUpNUlNJcENpQWdJQ0JwYm5Salh6SWdMeThnVkUxUVRGOUVSVXhGVkVGQ1RFVUtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdkR1Z0Y0d4aGRHVmZkbUZ5YVdGaWJHVnpMMk52Ym5SeVlXTjBMbkI1T2pNeENpQWdJQ0F2THlCQVlYSmpOQzVpWVhKbGJXVjBhRzlrS0dGc2JHOTNYMkZqZEdsdmJuTTlXeUpFWld4bGRHVkJjSEJzYVdOaGRHbHZiaUpkS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDl2Ymw5MWNHUmhkR1ZBTVRRNkNpQWdJQ0F2THlCMFpXMXdiR0YwWlY5MllYSnBZV0pzWlhNdlkyOXVkSEpoWTNRdWNIazZNamNLSUNBZ0lDOHZJRUJoY21NMExtSmhjbVZ0WlhSb2IyUW9ZV3hzYjNkZllXTjBhVzl1Y3oxYklsVndaR0YwWlVGd2NHeHBZMkYwYVc5dUlsMHBDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCMFpXMXdiR0YwWlY5MllYSnBZV0pzWlhNdlkyOXVkSEpoWTNRdWNIazZNamtLSUNBZ0lDOHZJR0Z6YzJWeWRDQlVaVzF3YkdGMFpWWmhjbHRpYjI5c1hTZ2lWVkJFUVZSQlFreEZJaWtLSUNBZ0lHbHVkR05mTXlBdkx5QlVUVkJNWDFWUVJFRlVRVUpNUlFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCMFpXMXdiR0YwWlY5MllYSnBZV0pzWlhNdlkyOXVkSEpoWTNRdWNIazZNamNLSUNBZ0lDOHZJRUJoY21NMExtSmhjbVZ0WlhSb2IyUW9ZV3hzYjNkZllXTjBhVzl1Y3oxYklsVndaR0YwWlVGd2NHeHBZMkYwYVc5dUlsMHBDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgxOWZZV3huYjNCNVgyUmxabUYxYkhSZlkzSmxZWFJsUURFek9nb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDRUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1JmWTJGelpYTXVkR1Z0Y0d4aGRHVmZkbUZ5YVdGaWJHVnpMbU52Ym5SeVlXTjBMbFJsYlhCc1lYUmxWbUZ5YVdGaWJHVnpRMjl1ZEhKaFkzUXVaMlYwWDJKNWRHVnpXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWjJWMFgySjVkR1Z6T2dvZ0lDQWdMeThnZEdWdGNHeGhkR1ZmZG1GeWFXRmliR1Z6TDJOdmJuUnlZV04wTG5CNU9qSXdDaUFnSUNBdkx5QnlaWFIxY200Z2MyVnNaaTV5WldObGFYWmxYM1poYkhWbEtGUmxiWEJzWVhSbFZtRnlXMEo1ZEdWelhTZ2lVMDlOUlY5Q1dWUkZVeUlwS1FvZ0lDQWdZbmwwWldOZk1TQXZMeUJVVFZCTVgxTlBUVVZmUWxsVVJWTUtJQ0FnSUM4dklIUmxiWEJzWVhSbFgzWmhjbWxoWW14bGN5OWpiMjUwY21GamRDNXdlVG94T0FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkRjlqWVhObGN5NTBaVzF3YkdGMFpWOTJZWEpwWVdKc1pYTXVZMjl1ZEhKaFkzUXVWR1Z0Y0d4aGRHVldZWEpwWVdKc1pYTkRiMjUwY21GamRDNW5aWFJmWW1sblgzVnBiblJiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwblpYUmZZbWxuWDNWcGJuUTZDaUFnSUNBdkx5QjBaVzF3YkdGMFpWOTJZWEpwWVdKc1pYTXZZMjl1ZEhKaFkzUXVjSGs2TWpRS0lDQWdJQzh2SUhnZ1BTQlVaVzF3YkdGMFpWWmhjbHRDYVdkVlNXNTBYU2dpVTA5TlJWOUNTVWRmVlVsT1ZDSXBDaUFnSUNCaWVYUmxZMTh5SUM4dklGUk5VRXhmVTA5TlJWOUNTVWRmVlVsT1ZBb2dJQ0FnTHk4Z2RHVnRjR3hoZEdWZmRtRnlhV0ZpYkdWekwyTnZiblJ5WVdOMExuQjVPakkxQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdWVWx1ZERVeE1paDRLUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBMk5Bb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2ZG1WeVpteHZkd29nSUNBZ2FXNTBZMTh4SUM4dklEWTBDaUFnSUNCaWVtVnlid29nSUNBZ1lud0tJQ0FnSUM4dklIUmxiWEJzWVhSbFgzWmhjbWxoWW14bGN5OWpiMjUwY21GamRDNXdlVG95TWdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wWDJOaGMyVnpMblJsYlhCc1lYUmxYM1poY21saFlteGxjeTVqYjI1MGNtRmpkQzVVWlcxd2JHRjBaVlpoY21saFlteGxjME52Ym5SeVlXTjBMbWRsZEY5aFgyNWhiV1ZrWDNSMWNHeGxXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWjJWMFgyRmZibUZ0WldSZmRIVndiR1U2Q2lBZ0lDQXZMeUIwWlcxd2JHRjBaVjkyWVhKcFlXSnNaWE12WTI5dWRISmhZM1F1Y0hrNk16a0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQXZMeUIwWlcxd2JHRjBaVjkyWVhKcFlXSnNaWE12WTI5dWRISmhZM1F1Y0hrNk5ERUtJQ0FnSUM4dklISmxkSFZ5YmlCVVpXMXdiR0YwWlZaaGNsdEJWSFZ3YkdWZEtDSk9RVTFGUkY5VVZWQk1SU0lwQ2lBZ0lDQmllWFJsWTE4eklDOHZJRlJOVUV4ZlRrRk5SVVJmVkZWUVRFVUtJQ0FnSUM4dklIUmxiWEJzWVhSbFgzWmhjbWxoWW14bGN5OWpiMjUwY21GamRDNXdlVG96T1FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1JmWTJGelpYTXVkR1Z0Y0d4aGRHVmZkbUZ5YVdGaWJHVnpMbU52Ym5SeVlXTjBMbFJsYlhCc1lYUmxWbUZ5YVdGaWJHVnpRMjl1ZEhKaFkzUXVaMlYwWDJGZmRIVndiR1ZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwblpYUmZZVjkwZFhCc1pUb0tJQ0FnSUM4dklIUmxiWEJzWVhSbFgzWmhjbWxoWW14bGN5OWpiMjUwY21GamRDNXdlVG8wTXdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUM4dklIUmxiWEJzWVhSbFgzWmhjbWxoWW14bGN5OWpiMjUwY21GamRDNXdlVG8wTlFvZ0lDQWdMeThnY21WMGRYSnVJRlJsYlhCc1lYUmxWbUZ5VzNSMWNHeGxXMVZKYm5RMk5Dd2dWVWx1ZERZMFhWMG9JbFJWVUV4Rklpa0tJQ0FnSUdKNWRHVmpJRFFnTHk4Z1ZFMVFURjlVVlZCTVJRb2dJQ0FnTHk4Z2RHVnRjR3hoZEdWZmRtRnlhV0ZpYkdWekwyTnZiblJ5WVdOMExuQjVPalF6Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkRjlqWVhObGN5NTBaVzF3YkdGMFpWOTJZWEpwWVdKc1pYTXVZMjl1ZEhKaFkzUXVWR1Z0Y0d4aGRHVldZWEpwWVdKc1pYTkRiMjUwY21GamRDNW5aWFJmWVY5emRISjFZM1JiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwblpYUmZZVjl6ZEhKMVkzUTZDaUFnSUNBdkx5QjBaVzF3YkdGMFpWOTJZWEpwWVdKc1pYTXZZMjl1ZEhKaFkzUXVjSGs2TkRjS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNBdkx5QjBaVzF3YkdGMFpWOTJZWEpwWVdKc1pYTXZZMjl1ZEhKaFkzUXVjSGs2TkRrS0lDQWdJQzh2SUhKbGRIVnliaUJVWlcxd2JHRjBaVlpoY2x0QlUzUnlkV04wWFNnaVUxUlNWVU5VSWlrS0lDQWdJR0o1ZEdWaklEVWdMeThnVkUxUVRGOVRWRkpWUTFRS0lDQWdJQzh2SUhSbGJYQnNZWFJsWDNaaGNtbGhZbXhsY3k5amIyNTBjbUZqZEM1d2VUbzBOd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnbz0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQVVBQUFDWUdCQlVmZkhVQUFCQUFBQUFBQUFBQUF3QUFBQUFBQUFBRUVBQUFBQUFBQUFBQkFBQUFBQUFBQUFJUUFBQUFBQUFBQUFVQUFBQUFBQUFBQmpFYlFRQXlNUmtVUkRFWVJJSUZCQy9LM2ZZRU4vWk04d1FsL0xHeEJKWDlpdEVFdE03Nk9UWWFBSTRGQUNRQU13QkNBRWdBVHdBeEdZMEdBQS8vNy8vdi8rOEFDQUFCQURFWVJDUkVJa014R0VRbFJDSkRNUmdVUXlsSkZSWlhCZ0pNVUNoTVVMQWlReXBKRlNNT1JDT3ZxeWhNVUxBaVF5Z3JVTEFpUXlnbkJGQ3dJa01vSndWUXNDSkQiLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjk5LCJtaW5vciI6OTksInBhdGNoIjo5OSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6eyJERUxFVEFCTEUiOnsidHlwZSI6IkFWTVVpbnQ2NCIsInZhbHVlIjoiQUFBQUFBQUFBQUE9In0sIlVQREFUQUJMRSI6eyJ0eXBlIjoiQVZNVWludDY0IiwidmFsdWUiOiJBQUFBQUFBQUFBQT0ifSwiU09NRV9CWVRFUyI6eyJ0eXBlIjoiQVZNQnl0ZXMiLCJ2YWx1ZSI6IiJ9LCJTT01FX0JJR19VSU5UIjp7InR5cGUiOiJBVk1CeXRlcyIsInZhbHVlIjoiIn0sIk5BTUVEX1RVUExFIjp7InR5cGUiOiJBVHVwbGUiLCJ2YWx1ZSI6IkFBQUFBQUFBQUFNQUFBQUFBQUFBQkE9PSJ9LCJUVVBMRSI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQpIiwidmFsdWUiOiJBQUFBQUFBQUFBRUFBQUFBQUFBQUFnPT0ifSwiU1RSVUNUIjp7InR5cGUiOiJBU3RydWN0IiwidmFsdWUiOiJBQUFBQUFBQUFBVUFBQUFBQUFBQUJnPT0ifX0sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
