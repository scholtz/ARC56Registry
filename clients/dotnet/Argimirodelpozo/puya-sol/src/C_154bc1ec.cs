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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.C_154bc1ec
{


    public class CProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public CProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class S : AVMObjectType
            {
                public byte[] B { get; set; }

                public ushort[] A { get; set; }

                public ushort U { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vB.From(B);
                    ret.AddRange(vB.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint16[]");
                    vA.From(A);
                    ret.AddRange(vA.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vU = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint16");
                    vU.From(U);
                    ret.AddRange(vU.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static S Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new S();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vB.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueB = vB.ToValue();
                    if (valueB is byte[] vBValue) { ret.B = vBValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint16[]");
                    count = vA.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueA = vA.ToValue();
                    if (valueA is ushort[] vAValue) { ret.A = vAValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vU = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint16");
                    count = vU.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueU = vU.ToValue();
                    if (valueU is ushort vUValue) { ret.U = vUValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as S);
                }
                public bool Equals(S? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(S left, S right)
                {
                    return EqualityComparer<S>.Default.Equals(left, right);
                }
                public static bool operator !=(S left, S right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        public async Task PostInit(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 186, 204, 73, 227 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> PostInit_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 186, 204, 73, 227 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.S> FromMemory(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 185, 250, 128, 78 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.S.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> FromMemory_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 185, 250, 128, 78 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.S> FromState(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 192, 177, 7, 164 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.S.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> FromState_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 192, 177, 7, 164 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.S> FromStorage(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 79, 31, 65, 45 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.S.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> FromStorage_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 79, 31, 65, 45 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="sCalldata"> S</param>
        public async Task<Structs.S> FromCalldata(Structs.S sCalldata, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 227, 142, 142, 169 };

            var result = await base.CallApp(new List<object> { abiHandle, sCalldata }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.S.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> FromCalldata_Transactions(Structs.S sCalldata, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 227, 142, 142, 169 };

            return await base.MakeTransactionList(new List<object> { abiHandle, sCalldata }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQyIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJTIjpbeyJuYW1lIjoiYiIsInR5cGUiOiJieXRlW10ifSx7Im5hbWUiOiJhIiwidHlwZSI6InVpbnQxNltdIn0seyJuYW1lIjoidSIsInR5cGUiOiJ1aW50MTYifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiX19wb3N0SW5pdCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJmcm9tX21lbW9yeSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiIoYnl0ZVtdLHVpbnQxNltdLHVpbnQxNikiLCJzdHJ1Y3QiOiJTIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZnJvbV9zdGF0ZSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiIoYnl0ZVtdLHVpbnQxNltdLHVpbnQxNikiLCJzdHJ1Y3QiOiJTIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZnJvbV9zdG9yYWdlIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6IihieXRlW10sdWludDE2W10sdWludDE2KSIsInN0cnVjdCI6IlMiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJmcm9tX2NhbGxkYXRhIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6IihieXRlW10sdWludDE2W10sdWludDE2KSIsInN0cnVjdCI6IlMiLCJuYW1lIjoic0NhbGxkYXRhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6IihieXRlW10sdWludDE2W10sdWludDE2KSIsInN0cnVjdCI6IlMiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MSwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzExMDZdLCJlcnJvck1lc3NhZ2UiOiJfX3Bvc3RJbml0IGFscmVhZHkgY2FsbGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjg4LDMxNF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMyMV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBTIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjgwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCB0YWlsIHBvaW50ZXIgYXQgaW5kZXggMCBvZiAoKGxlbit1aW50OFtdKSwobGVuK3VpbnQxNltdKSx1aW50MTYpIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzAzXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCB0YWlsIHBvaW50ZXIgYXQgaW5kZXggMSBvZiAoKGxlbit1aW50OFtdKSwobGVuK3VpbnQxNltdKSx1aW50MTYpIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjczLDI5NV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdHVwbGUgZW5jb2RpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMzQsNTE2LDcxMyw5MTBdLCJlcnJvck1lc3NhZ2UiOiJub3QgcGF5YWJsZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2ZEdWemRITXZjMjlzYVdScGRIa3RjMlZ0WVc1MGFXTXRkR1Z6ZEhNdmRHVnpkSE12YzNSeWRXTjBjeTlqYjNCNVgzTjFZbk4wY25WamRIVnlaWE5mZEc5ZmJXRndjR2x1Wnk1emIyd3VReTVoY0hCeWIzWmhiRjl3Y205bmNtRnRLQ2tnTFQ0Z2RXbHVkRFkwT2dwdFlXbHVPZ29nSUNBZ2FXNTBZMkpzYjJOcklESWdNQ0EySURFS0lDQWdJR0o1ZEdWallteHZZMnNnTUhnd01EQTJJREI0Tm1SbFl6UTVNVFprWkRJNFptTTBZekV3WkRjNFpUSTROMk5oTldRNVkyTTFNV1ZsTVdGbE56TmpZbVprWlRBNFl6WmlNemN6TWpSalltWmhZV000WW1NMUlDSnpJaUF3ZURBd01EWXdNREE0TURBd01EQXdNREF3TURBd0lEQjRObVE1TWpZM1pETmtZbVZrT0RBeU9UUXhORGd6WmpGaFptRXlZVFppWXpZNFpHVTFaalkxTXpFeU9HRmpZVGxpWmpFME5qRmpOV1F3WVROaFpETTJaV1F5SURCNE5tUTJOalk0TjJGaFpHWTROakppWkRjM05tTTRabU14T0dJNFpUbG1PR1V5TURBNE9UY3hORGcxTm1WbE1qTXpZak01TURKaE5Ua3haREJrTldZeU9USTFJREI0TVRVeFpqZGpOelVnSWw5ZlkzUnZjbDl3Wlc1a2FXNW5JZ29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHSjVkR1Z6SUNJaUNpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdOREE1TmdvZ0lDQWdZbnBsY204S0lDQWdJR1IxY0FvZ0lDQWdjM1J2Y21VZ05Rb2dJQ0FnYzNSdmNtVWdNQW9nSUNBZ2JHOWhaQ0F3Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNRGd3Q2lBZ0lDQnlaWEJzWVdObE1pQTJOQW9nSUNBZ2MzUnZjbVVnTUFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKdWVpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNZ29nSUNBZ1lubDBaV01nTnlBdkx5QWlYMTlqZEc5eVgzQmxibVJwYm1jaUNpQWdJQ0JwYm5Salh6TWdMeThnTVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR2x1ZEdOZk15QXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjRZbUZqWXpRNVpUTWdNSGhpT1daaE9EQTBaU0F3ZUdNd1lqRXdOMkUwSURCNE5HWXhaalF4TW1RZ01IaGxNemhsT0dWaE9TQXZMeUJ0WlhSb2IyUWdJbDlmY0c5emRFbHVhWFFvS1hadmFXUWlMQ0J0WlhSb2IyUWdJbVp5YjIxZmJXVnRiM0o1S0Nrb1lubDBaVnRkTEhWcGJuUXhObHRkTEhWcGJuUXhOaWtpTENCdFpYUm9iMlFnSW1aeWIyMWZjM1JoZEdVb0tTaGllWFJsVzEwc2RXbHVkREUyVzEwc2RXbHVkREUyS1NJc0lHMWxkR2h2WkNBaVpuSnZiVjl6ZEc5eVlXZGxLQ2tvWW5sMFpWdGRMSFZwYm5ReE5sdGRMSFZwYm5ReE5pa2lMQ0J0WlhSb2IyUWdJbVp5YjIxZlkyRnNiR1JoZEdFb0tHSjVkR1ZiWFN4MWFXNTBNVFpiWFN4MWFXNTBNVFlwS1NoaWVYUmxXMTBzZFdsdWRERTJXMTBzZFdsdWRERTJLU0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUcxaGFXNWZYMTl3YjNOMFNXNXBkRjl5YjNWMFpVQTFJRzFoYVc1ZlpuSnZiVjl0WlcxdmNubGZjbTkxZEdWQU5pQnRZV2x1WDJaeWIyMWZjM1JoZEdWZmNtOTFkR1ZBTnlCdFlXbHVYMlp5YjIxZmMzUnZjbUZuWlY5eWIzVjBaVUE0SUcxaGFXNWZabkp2YlY5allXeHNaR0YwWVY5eWIzVjBaVUE1Q2lBZ0lDQmxjbklLQ20xaGFXNWZabkp2YlY5allXeHNaR0YwWVY5eWIzVjBaVUE1T2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURVS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQmthV2NnTVFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lIUjFjR3hsSUdWdVkyOWthVzVuQ2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnTlFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdOZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUhSaGFXd2djRzlwYm5SbGNpQmhkQ0JwYm1SbGVDQXdJRzltSUNnb2JHVnVLM1ZwYm5RNFcxMHBMQ2hzWlc0cmRXbHVkREUyVzEwcExIVnBiblF4TmlrS0lDQWdJR1JwWnlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JrYVdjZ01nb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUhCMWMyaHBiblFnT0FvZ0lDQWdLd29nSUNBZ1pHbG5JRElLSUNBZ0lHbHVkR05mTUNBdkx5QXlDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCMGRYQnNaU0JsYm1OdlpHbHVad29nSUNBZ1pIVndDaUFnSUNCaWRYSjVJRFVLSUNBZ0lHUjFjQW9nSUNBZ1pHbG5JRElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCMFlXbHNJSEJ2YVc1MFpYSWdZWFFnYVc1a1pYZ2dNU0J2WmlBb0tHeGxiaXQxYVc1ME9GdGRLU3dvYkdWdUszVnBiblF4Tmx0ZEtTeDFhVzUwTVRZcENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lITjNZWEFLSUNBZ0lHUnBaeUF6Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dOZ29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF5Q2lBZ0lDQXFDaUFnSUNCcGJuUmpYekFnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdLd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1V3b2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdKNklHMWhhVzVmZEdWeWJtRnllVjltWVd4elpVQXhOUW9nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTXlBdkx5QXhDaUFnSUNBdENpQWdJQ0JuZEhodWN5QkJiVzkxYm5RS0NtMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQXhOam9LSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCdWIzUWdjR0Y1WVdKc1pRb2dJQ0FnWW5sMFpXTWdOQ0F2THlBd2VEWmtPVEkyTjJRelpHSmxaRGd3TWprME1UUTRNMll4WVdaaE1tRTJZbU0yT0dSbE5XWTJOVE14TWpoaFkyRTVZbVl4TkRZeFl6VmtNR0V6WVdRek5tVmtNZ29nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZbmwwWldOZk15QXZMeUF3ZURBd01EWXdNREE0TURBd01EQXdNREF3TURBd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklESUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNCa2FXY2dNZ29nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ1pHbG5JRFVLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTXdvZ0lDQWdaR2xuSURVS0lDQWdJR1JwWnlBMUNpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdWNGRISmhZM1FnTkNBeUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTmdvZ0lDQWdLd29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3dNREEyQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdNSGcyWkRreU5qZGtNMlJpWldRNE1ESTVOREUwT0RObU1XRm1ZVEpoTm1Kak5qaGtaVFZtTmpVek1USTRZV05oT1dKbU1UUTJNV00xWkRCaE0yRmtNelpsWkRJS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnWW5sMFpXTWdOQ0F2THlBd2VEWmtPVEkyTjJRelpHSmxaRGd3TWprME1UUTRNMll4WVdaaE1tRTJZbU0yT0dSbE5XWTJOVE14TWpoaFkyRTVZbVl4TkRZeFl6VmtNR0V6WVdRek5tVmtNZ29nSUNBZ1pHbG5JREVLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdhVzUwWTE4d0lDOHZJRElLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQmthV2NnTWdvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdjM2RoY0FvZ0lDQWdaWGgwY21GamRDQTBJRElLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTJDaUFnSUNBckNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURBd01EWUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBMENpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z01IZzJaRGt5Tmpka00yUmlaV1E0TURJNU5ERTBPRE5tTVdGbVlUSmhObUpqTmpoa1pUVm1OalV6TVRJNFlXTmhPV0ptTVRRMk1XTTFaREJoTTJGa016WmxaRElLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdZbmwwWldNZ05DQXZMeUF3ZURaa09USTJOMlF6WkdKbFpEZ3dNamswTVRRNE0yWXhZV1poTW1FMlltTTJPR1JsTldZMk5UTXhNamhoWTJFNVltWXhORFl4WXpWa01HRXpZV1F6Tm1Wa01nb2dJQ0FnWkdsbklERUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklESUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNCa2FXY2dNZ29nSUNBZ1pHbG5JRElLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdaR2xuSURJS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWTI5MlpYSWdNd29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmxlSFJ5WVdOMElEUWdNZ29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEWUtJQ0FnSUNzS0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TURBd05nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFl5QTBJQzh2SURCNE5tUTVNalkzWkROa1ltVmtPREF5T1RReE5EZ3paakZoWm1FeVlUWmlZelk0WkdVMVpqWTFNekV5T0dGallUbGlaakUwTmpGak5XUXdZVE5oWkRNMlpXUXlDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdNSGcyWkRreU5qZGtNMlJpWldRNE1ESTVOREUwT0RObU1XRm1ZVEpoTm1Kak5qaGtaVFZtTmpVek1USTRZV05oT1dKbU1UUTJNV00xWkRCaE0yRmtNelpsWkRJS0lDQWdJR1JwWnlBeENpQWdJQ0JpYjNoZmNIVjBDaUFnSUNCaWVYUmxZeUEySUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYek1nTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBTVRVNkNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZaUJ0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBTVRZS0NtMWhhVzVmWm5KdmJWOXpkRzl5WVdkbFgzSnZkWFJsUURnNkNpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnWW5vZ2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFESXdDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh6SUM4dklERUtJQ0FnSUMwS0lDQWdJR2QwZUc1eklFRnRiM1Z1ZEFvS2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFESXhPZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUc1dmRDQndZWGxoWW14bENpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE5tUmxZelE1TVRaa1pESTRabU0wWXpFd1pEYzRaVEk0TjJOaE5XUTVZMk0xTVdWbE1XRmxOek5qWW1aa1pUQTRZelppTXpjek1qUmpZbVpoWVdNNFltTTFDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmllWFJsWTE4eklDOHZJREI0TURBd05qQXdNRGd3TURBd01EQXdNREF3TURBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUdScFp5QXlDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCaWVYUmxZMTh5SUM4dklDSnpJZ29nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZbmwwWldOZk15QXZMeUF3ZURBd01EWXdNREE0TURBd01EQXdNREF3TURBd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCa2FXY2dNUW9nSUNBZ2FXNTBZMTh3SUM4dklESUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHVjRkSEpoWTNRZ05DQXlDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z05nb2dJQ0FnS3dvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd3TURBMkNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnMlpHVmpORGt4Tm1Sa01qaG1ZelJqTVRCa056aGxNamczWTJFMVpEbGpZelV4WldVeFlXVTNNMk5pWm1SbE1EaGpObUl6TnpNeU5HTmlabUZoWXpoaVl6VUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlRFprWldNME9URTJaR1F5T0daak5HTXhNR1EzT0dVeU9EZGpZVFZrT1dOak5URmxaVEZoWlRjelkySm1aR1V3T0dNMllqTTNNekkwWTJKbVlXRmpPR0pqTlFvZ0lDQWdaR2xuSURFS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUdKNWRHVmpYeklnTHk4Z0luTWlDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmllWFJsWTE4eklDOHZJREI0TURBd05qQXdNRGd3TURBd01EQXdNREF3TURBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR1JwWnlBeUNpQWdJQ0JwYm5Salh6QWdMeThnTWdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR1JwWnlBekNpQWdJQ0JqYjNabGNpQXlDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHVjRkSEpoWTNRZ05DQXlDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z05nb2dJQ0FnS3dvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd3TURBMkNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnMlpHVmpORGt4Tm1Sa01qaG1ZelJqTVRCa056aGxNamczWTJFMVpEbGpZelV4WldVeFlXVTNNMk5pWm1SbE1EaGpObUl6TnpNeU5HTmlabUZoWXpoaVl6VUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlRFprWldNME9URTJaR1F5T0daak5HTXhNR1EzT0dVeU9EZGpZVFZrT1dOak5URmxaVEZoWlRjelkySm1aR1V3T0dNMllqTTNNekkwWTJKbVlXRmpPR0pqTlFvZ0lDQWdaR2xuSURFS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURJS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0JrYVdjZ01nb2dJQ0FnWkdsbklESUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ1pHbG5JRElLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ1kyOTJaWElnTWdvZ0lDQWdZMjkyWlhJZ013b2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdZbmwwWldOZk1pQXZMeUFpY3lJS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdKNWRHVmpYek1nTHk4Z01IZ3dNREEyTURBd09EQXdNREF3TURBd01EQXdNQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjMlZzWldOMENpQWdJQ0JsZUhSeVlXTjBJRFFnTWdvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRFlLSUNBZ0lDc0tJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1EQXdOZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRObVJsWXpRNU1UWmtaREk0Wm1NMFl6RXdaRGM0WlRJNE4yTmhOV1E1WTJNMU1XVmxNV0ZsTnpOalltWmtaVEE0WXpaaU16Y3pNalJqWW1aaFlXTTRZbU0xQ2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnMlpHVmpORGt4Tm1Sa01qaG1ZelJqTVRCa056aGxNamczWTJFMVpEbGpZelV4WldVeFlXVTNNMk5pWm1SbE1EaGpObUl6TnpNeU5HTmlabUZoWXpoaVl6VUtJQ0FnSUdScFp5QXhDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQmllWFJsWXlBMklDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpNZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU1qQTZDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWWlCdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU1qRUtDbTFoYVc1ZlpuSnZiVjl6ZEdGMFpWOXliM1YwWlVBM09nb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdKNklHMWhhVzVmZEdWeWJtRnllVjltWVd4elpVQXlOUW9nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTXlBdkx5QXhDaUFnSUNBdENpQWdJQ0JuZEhodWN5QkJiVzkxYm5RS0NtMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQXlOam9LSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCdWIzUWdjR0Y1WVdKc1pRb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEWmtaV00wT1RFMlpHUXlPR1pqTkdNeE1HUTNPR1V5T0RkallUVmtPV05qTlRGbFpURmhaVGN6WTJKbVpHVXdPR00yWWpNM016STBZMkptWVdGak9HSmpOUW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZbmwwWldOZk15QXZMeUF3ZURBd01EWXdNREE0TURBd01EQXdNREF3TURBd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklESUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNCa2FXY2dNZ29nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ1lubDBaV05mTWlBdkx5QWljeUlLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhnd01EQTJNREF3T0RBd01EQXdNREF3TURBd01Bb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ1pHbG5JREVLSUNBZ0lHbHVkR05mTUNBdkx5QXlDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmxlSFJ5WVdOMElEUWdNZ29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEWUtJQ0FnSUNzS0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TURBd05nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE5tUmxZelE1TVRaa1pESTRabU0wWXpFd1pEYzRaVEk0TjJOaE5XUTVZMk0xTVdWbE1XRmxOek5qWW1aa1pUQTRZelppTXpjek1qUmpZbVpoWVdNNFltTTFDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGcyWkdWak5Ea3hObVJrTWpobVl6UmpNVEJrTnpobE1qZzNZMkUxWkRsall6VXhaV1V4WVdVM00yTmlabVJsTURoak5tSXpOek15TkdOaVptRmhZemhpWXpVS0lDQWdJR1JwWnlBeENpQWdJQ0JpYjNoZmNIVjBDaUFnSUNCaWVYUmxZMTh5SUM4dklDSnpJZ29nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZbmwwWldOZk15QXZMeUF3ZURBd01EWXdNREE0TURBd01EQXdNREF3TURBd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklESUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JrYVdjZ01nb2dJQ0FnYVc1MFkxOHdJQzh2SURJS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JrYVdjZ013b2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmxlSFJ5WVdOMElEUWdNZ29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEWUtJQ0FnSUNzS0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TURBd05nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE5tUmxZelE1TVRaa1pESTRabU0wWXpFd1pEYzRaVEk0TjJOaE5XUTVZMk0xTVdWbE1XRmxOek5qWW1aa1pUQTRZelppTXpjek1qUmpZbVpoWVdNNFltTTFDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGcyWkdWak5Ea3hObVJrTWpobVl6UmpNVEJrTnpobE1qZzNZMkUxWkRsall6VXhaV1V4WVdVM00yTmlabVJsTURoak5tSXpOek15TkdOaVptRmhZemhpWXpVS0lDQWdJR1JwWnlBeENpQWdJQ0JpYjNoZmNIVjBDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBeUNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnWkdsbklESUtJQ0FnSUdScFp5QXlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHUnBaeUF5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR052ZG1WeUlETUtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR0o1ZEdWalh6SWdMeThnSW5NaUNpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRNREF3TmpBd01EZ3dNREF3TURBd01EQXdNREFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnWlhoMGNtRmpkQ0EwSURJS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUEyQ2lBZ0lDQXJDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEQXdNRFlLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlRFprWldNME9URTJaR1F5T0daak5HTXhNR1EzT0dVeU9EZGpZVFZrT1dOak5URmxaVEZoWlRjelkySm1aR1V3T0dNMllqTTNNekkwWTJKbVlXRmpPR0pqTlFvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE5tUmxZelE1TVRaa1pESTRabU0wWXpFd1pEYzRaVEk0TjJOaE5XUTVZMk0xTVdWbE1XRmxOek5qWW1aa1pUQTRZelppTXpjek1qUmpZbVpoWVdNNFltTTFDaUFnSUNCa2FXY2dNUW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdZbmwwWldNZ05pQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eklDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFESTFPZ29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdJZ2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFESTJDZ3B0WVdsdVgyWnliMjFmYldWdGIzSjVYM0p2ZFhSbFFEWTZDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ1lub2diV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRRE13Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4eklDOHZJREVLSUNBZ0lDMEtJQ0FnSUdkMGVHNXpJRUZ0YjNWdWRBb0tiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRRE14T2dvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklHNXZkQ0J3WVhsaFlteGxDaUFnSUNCaWVYUmxZMTh5SUM4dklDSnpJZ29nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZbmwwWldOZk15QXZMeUF3ZURBd01EWXdNREE0TURBd01EQXdNREF3TURBd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdNSGcyWkRZMk5qZzNZV0ZrWmpnMk1tSmtOemMyWXpobVl6RTRZamhsT1dZNFpUSXdNRGc1TnpFME9EVTJaV1V5TXpOaU16a3dNbUUxT1RGa01HUTFaakk1TWpVS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdKNWRHVmpYek1nTHk4Z01IZ3dNREEyTURBd09EQXdNREF3TURBd01EQXdNQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjMlZzWldOMENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF5Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdaR2xuSURJS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR1JwWnlBeUNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR1JwWnlBekNpQWdJQ0JwYm5Salh6QWdMeThnTWdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR1JwWnlBMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR1Y0ZEhKaFkzUWdOQ0F5Q2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdOZ29nSUNBZ0t3b2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnd01EQTJDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldNZ05TQXZMeUF3ZURaa05qWTJPRGRoWVdSbU9EWXlZbVEzTnpaak9HWmpNVGhpT0dVNVpqaGxNakF3T0RrM01UUTROVFpsWlRJek0ySXpPVEF5WVRVNU1XUXdaRFZtTWpreU5Rb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNCaWVYUmxZeUExSUM4dklEQjRObVEyTmpZNE4yRmhaR1k0TmpKaVpEYzNObU00Wm1NeE9HSTRaVGxtT0dVeU1EQTRPVGN4TkRnMU5tVmxNak16WWpNNU1ESmhOVGt4WkRCa05XWXlPVEkxQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnWkdsbklESUtJQ0FnSUd4bGJnb2dJQ0FnWkdsbklETUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JrYVdjZ01nb2dJQ0FnYVc1MFkxOHdJQzh2SURJS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JrYVdjZ013b2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmxlSFJ5WVdOMElEUWdNZ29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEWUtJQ0FnSUNzS0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TURBd05nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFl5QTFJQzh2SURCNE5tUTJOalk0TjJGaFpHWTROakppWkRjM05tTTRabU14T0dJNFpUbG1PR1V5TURBNE9UY3hORGcxTm1WbE1qTXpZak01TURKaE5Ua3haREJrTldZeU9USTFDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdNSGcyWkRZMk5qZzNZV0ZrWmpnMk1tSmtOemMyWXpobVl6RTRZamhsT1dZNFpUSXdNRGc1TnpFME9EVTJaV1V5TXpOaU16a3dNbUUxT1RGa01HUTFaakk1TWpVS0lDQWdJR1JwWnlBeENpQWdJQ0JpYjNoZmNIVjBDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBeUNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnWkdsbklESUtJQ0FnSUdScFp5QXlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHUnBaeUF5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR052ZG1WeUlETUtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1pYaDBjbUZqZENBMElESUtJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBMkNpQWdJQ0FyQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREF3TURZS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldNZ05TQXZMeUF3ZURaa05qWTJPRGRoWVdSbU9EWXlZbVEzTnpaak9HWmpNVGhpT0dVNVpqaGxNakF3T0RrM01UUTROVFpsWlRJek0ySXpPVEF5WVRVNU1XUXdaRFZtTWpreU5Rb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNCaWVYUmxZeUExSUM4dklEQjRObVEyTmpZNE4yRmhaR1k0TmpKaVpEYzNObU00Wm1NeE9HSTRaVGxtT0dVeU1EQTRPVGN4TkRnMU5tVmxNak16WWpNNU1ESmhOVGt4WkRCa05XWXlPVEkxQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnWW5sMFpXTWdOaUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHpJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRRE13T2dvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHSWdiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRRE14Q2dwdFlXbHVYMTlmY0c5emRFbHVhWFJmY205MWRHVkFOVG9LSUNBZ0lHSjVkR1ZqSURjZ0x5OGdJbDlmWTNSdmNsOXdaVzVrYVc1bklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUUtJQ0FnSUdGemMyVnlkQ0F2THlCZlgzQnZjM1JKYm1sMElHRnNjbVZoWkhrZ1kyRnNiR1ZrQ2lBZ0lDQmllWFJsWXlBM0lDOHZJQ0pmWDJOMGIzSmZjR1Z1WkdsdVp5SUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnY0hWemFHSjVkR1Z6SUNKdElnb2dJQ0FnYVc1MFkxOHdJQzh2SURJS0lDQWdJR0p2ZUY5amNtVmhkR1VLSUNBZ0lIQnZjQW9nSUNBZ1lubDBaV05mTWlBdkx5QWljeUlLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhnd01EQTJNREF3T0RBd01EQXdNREF3TURBd01Bb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXlDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1pHbG5JRElLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lITjNZWEFLSUNBZ0lHVjRkSEpoWTNRZ05DQXlDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNREEyTURBd1lnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNREF6TmpZMlpqWm1DaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldOZk1pQXZMeUFpY3lJS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWN5SUtJQ0FnSUdScFp5QXhDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ1pHbG5JREVLSUNBZ0lHbHVkR05mTUNBdkx5QXlDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ1pHbG5JRElLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lITjNZWEFLSUNBZ0lHVjRkSEpoWTNRZ05DQXlDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z05nb2dJQ0FnS3dvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd3TURBMkNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TURBeU1EQXdaREF3TUdVS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWN5SUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ1lubDBaV05mTWlBdkx5QWljeUlLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF5Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdaR2xuSURJS0lDQWdJR1JwWnlBeUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITjFZbk4wY21sdVp6TUtJQ0FnSUdScFp5QXlDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHTnZkbVZ5SURNS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z05nb2dJQ0FnS3dvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd3TURBMkNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdNVFVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYeklnTHk4Z0luTWlDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbk1pQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0JwYm5Salh6TWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dmRHVnpkSE12YzI5c2FXUnBkSGt0YzJWdFlXNTBhV010ZEdWemRITXZkR1Z6ZEhNdmMzUnlkV04wY3k5amIzQjVYM04xWW5OMGNuVmpkSFZ5WlhOZmRHOWZiV0Z3Y0dsdVp5NXpiMnd1UXk1amJHVmhjbDl6ZEdGMFpWOXdjbTluY21GdEtDa2dMVDRnZFdsdWREWTBPZ3B0WVdsdU9nb2dJQ0FnY0hWemFHbHVkQ0F4Q2lBZ0lDQnlaWFIxY200SyJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQUVBZ0FHQVNZSUFnQUdJVzNzU1JiZEtQeE1FTmVPS0h5bDJjeFI3aHJuUEwvZUNNYXpjeVRMK3F5THhRRnpDZ0FHQUFnQUFBQUFBQUFoYlpKbjA5dnRnQ2xCU0Q4YStpcHJ4bzNsOWxNU2lzcWI4VVljWFFvNjAyN1NJVzFtYUhxdCtHSzlkMnlQd1l1T240NGdDSmNVaFc3aU03T1FLbGtkRFY4cEpRUVZIM3gxRGw5ZlkzUnZjbDl3Wlc1a2FXNW5JMG1BQUVtQmdDQ3ZTVFVGTlFBMEFJQWdBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUlCY1FEVUFNUmhBQUFZbkJ5Vm5KVU14R1JSRU1SaEVnZ1VFdXN4SjR3UzUrb0JPQk1DeEI2UUVUeDlCTFFUampvNnBOaG9BamdVRFNnSjlBYmdBOHdBQkFEWWFBVWxGQlVrVlN3RWpXVWxGQlVra0VrUkxBa3hMQWxJaldZRUlDRXNDSWxsSlJRVkpTd0lTUkU4RFRFc0RVa2xGQmlOWklnc2lDQWdTUkRFV1FRQ3RNUllsQ1RnSUZFUW5CTDRyVGdKTlNTSlpTd0VWU3dKT0FsSkxCVWxPQTBzRlN3VlNUd0pYQkFKTEFSVWtDQlpYQmdJb1RGQk1VRXhRVEZBbkJMeElKd1JMQWI5SkkxbExBU0paU3dKT0FsSk1Wd1FDU3dFVkpBZ1dWd1lDS0V4UVRGQk1VRXNFVUNjRXZFZ25CRXNCdjBraVdVc0JGVXNDU3dKUEFsSkxBaU5aVGdKT0ExSlBBbGNFQWtzQkZTUUlGbGNHQWloTVVFeFFURkJNVUNjRXZFZ25CRXNCdnljR1RGQ3dKVU1qUXY5Vk1SWkJBTHd4RmlVSk9BZ1VSQ20rSzA0Q1RVa2lXVXNCRlVzQ1RnSlNLcjRyVGdKTlNTTlpTd0VpV1ZKUEFsY0VBa3NCRlNRSUZsY0dBaWhNVUV4UVRGQk1VQ204U0NsTEFiOHF2aXRPQWsxSklsbExBUlZTU3dFaldVc0NJbGxMQTA0Q1VrOENWd1FDU3dFVkpBZ1dWd1lDS0V4UVRGQk1VRXhRS2J4SUtVc0J2MGtpV1VzQkZVc0NTd0pQQWxKTEFpTlpUZ0pPQTFJcXZpdE9BazFYQkFKTEFSVWtDQlpYQmdJb1RGQk1VRXhRVEZBcHZFZ3BTd0cvSndaTVVMQWxReU5DLzBZeEZrRUF2REVXSlFrNENCUkVLYjRyVGdKTlNTSlpTd0VWU3dKT0FsSXF2aXRPQWsxSkkxbExBU0paVWs4Q1Z3UUNTd0VWSkFnV1Z3WUNLRXhRVEZCTVVFeFFLYnhJS1VzQnZ5cStLMDRDVFVraVdVc0JGVkpMQVNOWlN3SWlXVXNEVGdKU1R3SlhCQUpMQVJVa0NCWlhCZ0lvVEZCTVVFeFFURkFwdkVncFN3Ry9TU0paU3dFVlN3SkxBazhDVWtzQ0kxbE9BazREVWlxK0swNENUVmNFQWtzQkZTUUlGbGNHQWloTVVFeFFURkJNVUNtOFNDbExBYjhuQmt4UXNDVkRJMEwvUmpFV1FRREVNUllsQ1RnSUZFUXF2aXRPQWswbkJiNHJUZ0pOU1NKWlN3RVZTd0pPQWxKTEFpTlpTd01pV1VzRVR3SkxBbEpQQTFjRUFrc0JGU1FJRmxjR0FpaE1VRXhRVEZCUEFsQW5CYnhJSndWTEFiOUxBaFZMQTA4RFR3SlNTd0VqV1VzQ0lsbExBMDRDVWs4Q1Z3UUNTd0VWSkFnV1Z3WUNLRXhRVEZCTVVFeFFKd1c4U0NjRlN3Ry9TU0paU3dFVlN3SkxBazhDVWtzQ0kxbE9BazREVWs4Q1Z3UUNTd0VWSkFnV1Z3WUNLRXhRVEZCTVVFeFFKd1c4U0NjRlN3Ry9Kd1pNVUxBbFF5TkMvejRuQjJSRUp3Y2paNEFCYlNLNVNDcStLMDRDVFVraVdVc0JGVXNDVGdKU1RGY0VBb0FFQUFZQUMweFFnQVVBQTJadmIxQk1VQ3E4U0NwTEFiOUpJMWxMQVNKWlN3Sk9BbEpNVndRQ1N3RVZKQWdXVndZQ0tFeFFURkJNVUlBR0FBSUFEUUFPVUNxOFNDcExBYjlKSWxsTEFSVkxBa3NDVHdKU1N3SWpXVTRDVGdOU1NSVWtDQlpYQmdJb1RGQ0FBZ0FWVUV4UVRGQXF2RWdxVEw4bFF3PT0iLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo4LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
