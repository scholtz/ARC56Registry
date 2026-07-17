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

namespace Arc56.Generated.algorandfoundation.puya.StructArrayUInt64_ba9b7e56
{


    public class StructArrayUInt64Proxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public StructArrayUInt64Proxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class StructWithArrayU64 : AVMObjectType
            {
                public ulong A { get; set; }

                public ulong[] Arr { get; set; }

                public ulong B { get; set; }

                public byte[][] Padding { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vA.From(A);
                    ret.AddRange(vA.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vArr = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64[]");
                    vArr.From(Arr);
                    ret.AddRange(vArr.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vB.From(B);
                    ret.AddRange(vB.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPadding = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[4096][]");
                    vPadding.From(Padding);
                    ret.AddRange(vPadding.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static StructWithArrayU64 Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new StructWithArrayU64();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vA.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueA = vA.ToValue();
                    if (valueA is ulong vAValue) { ret.A = vAValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vArr = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64[]");
                    count = vArr.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueArr = vArr.ToValue();
                    if (valueArr is ulong[] vArrValue) { ret.Arr = vArrValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vB.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueB = vB.ToValue();
                    if (valueB is ulong vBValue) { ret.B = vBValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPadding = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[4096][]");
                    count = vPadding.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePadding = vPadding.ToValue();
                    if (valuePadding is byte[][] vPaddingValue) { ret.Padding = vPaddingValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as StructWithArrayU64);
                }
                public bool Equals(StructWithArrayU64? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(StructWithArrayU64 left, StructWithArrayU64 right)
                {
                    return EqualityComparer<StructWithArrayU64>.Default.Equals(left, right);
                }
                public static bool operator !=(StructWithArrayU64 left, StructWithArrayU64 right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        public async Task Bootstrap(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 190, 199, 109, 135 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Bootstrap_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 190, 199, 109, 135 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task Append(ulong value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 52, 40, 255, 234 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Append_Transactions(ulong value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 52, 40, 255, 234 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="array"> </param>
        public async Task Concat(ulong[] array, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 89, 73, 206, 93 };
            var arrayAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); arrayAbi.From(array);

            var result = await base.CallApp(new List<object> { abiHandle, arrayAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Concat_Transactions(ulong[] array, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 89, 73, 206, 93 };
            var arrayAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); arrayAbi.From(array);

            return await base.MakeTransactionList(new List<object> { abiHandle, arrayAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> Pop(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 37, 161, 66 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Pop_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 37, 161, 66 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="idx"> </param>
        public async Task<ulong> Get(ulong idx, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 180, 54, 156, 54 };
            var idxAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); idxAbi.From(idx);

            var result = await base.CallApp(new List<object> { abiHandle, idxAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Get_Transactions(ulong idx, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 180, 54, 156, 54 };
            var idxAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); idxAbi.From(idx);

            return await base.MakeTransactionList(new List<object> { abiHandle, idxAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="idx"> </param>
        /// <param name="value"> </param>
        public async Task Set(ulong idx, ulong value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 206, 209, 189, 198 };
            var idxAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); idxAbi.From(idx);
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, idxAbi, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Set_Transactions(ulong idx, ulong value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 206, 209, 189, 198 };
            var idxAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); idxAbi.From(idx);
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, idxAbi, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="expected"> </param>
        public async Task Verify(ulong[] expected, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 49, 122, 62, 3 };
            var expectedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); expectedAbi.From(expected);

            var result = await base.CallApp(new List<object> { abiHandle, expectedAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Verify_Transactions(ulong[] expected, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 49, 122, 62, 3 };
            var expectedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); expectedAbi.From(expected);

            return await base.MakeTransactionList(new List<object> { abiHandle, expectedAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU3RydWN0QXJyYXlVSW50NjQiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiU3RydWN0V2l0aEFycmF5VTY0IjpbeyJuYW1lIjoiYSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJhcnIiLCJ0eXBlIjoidWludDY0W10ifSx7Im5hbWUiOiJiIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InBhZGRpbmciLCJ0eXBlIjoiYnl0ZVs0MDk2XVtdIn1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImJvb3RzdHJhcCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcHBlbmQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY29uY2F0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NFtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXJyYXkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicG9wIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImlkeCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpZHgiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InZlcmlmeSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjRbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImV4cGVjdGVkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMzE3XSwiZXJyb3JNZXNzYWdlIjoiY2Fubm90IHBvcCBmcm9tIGVtcHR5IGFycmF5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTQ1XSwiZXJyb3JNZXNzYWdlIjoiZXhwZWN0ZWQgYm94IGxlbmd0aCA+NDA5NiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMyMiwzMzEsNDA5LDQxOCw0NTAsNDYxLDUxMSw1MjBdLCJlcnJvck1lc3NhZ2UiOiJpbmRleCBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjczLDQ3MF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI4NCw0NzldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PHVpbnQ2ND4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNDYsMzk5LDQzMiw0NDFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUE0SURJZ01TQXlNQ0EwTURrMkNpQWdJQ0JpZVhSbFkySnNiMk5ySUNKaWIzZ2lJREI0TVRVeFpqZGpOelVLSUNBZ0lDOHZJR3hoY21kbFgySnZlRjl2Y0dWeVlYUnBiMjV6TDNOMGNuVmpkRjloY25KaGVWOTFhVzUwTmpRdWNIazZNVGNLSUNBZ0lDOHZJR05zWVhOeklGTjBjblZqZEVGeWNtRjVWVWx1ZERZMEtFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzRnVG5WdFFYQndRWEpuY3dvZ0lDQWdZbm9nYldGcGJsOWZYMkZzWjI5d2VWOWtaV1poZFd4MFgyTnlaV0YwWlVBeE5nb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMENpQWdJQ0J3ZFhOb1lubDBaWE56SURCNFltVmpOelprT0RjZ01IZ3pOREk0Wm1abFlTQXdlRFU1TkRsalpUVmtJREI0WWpneU5XRXhORElnTUhoaU5ETTJPV016TmlBd2VHTmxaREZpWkdNMklEQjRNekUzWVRObE1ETWdMeThnYldWMGFHOWtJQ0ppYjI5MGMzUnlZWEFvS1hadmFXUWlMQ0J0WlhSb2IyUWdJbUZ3Y0dWdVpDaDFhVzUwTmpRcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWTI5dVkyRjBLSFZwYm5RMk5GdGRLWFp2YVdRaUxDQnRaWFJvYjJRZ0luQnZjQ2dwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0puWlhRb2RXbHVkRFkwS1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpYzJWMEtIVnBiblEyTkN4MWFXNTBOalFwZG05cFpDSXNJRzFsZEdodlpDQWlkbVZ5YVdaNUtIVnBiblEyTkZ0ZEtYWnZhV1FpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCaWIyOTBjM1J5WVhBZ1lYQndaVzVrSUdOdmJtTmhkQ0J3YjNBZ1oyVjBJSE5sZENCMlpYSnBabmtLSUNBZ0lHVnljZ29LYldGcGJsOWZYMkZzWjI5d2VWOWtaV1poZFd4MFgyTnlaV0YwWlVBeE5qb0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQWhDaUFnSUNBbUpnb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z1gzQjFlV0ZmYkdsaUxtSnZlRjloY21NMExtSnZlRjlrZVc1aGJXbGpYMkZ5Y21GNVgyTnZibU5oZEY5bWFYaGxaQ2hpYjNoZmEyVjVPaUJpZVhSbGN5d2dZWEp5WVhsZmIyWm1jMlYwT2lCMWFXNTBOalFzSUc1bGQxOXBkR1Z0YzE5aWVYUmxjem9nWW5sMFpYTXNJRzVsZDE5cGRHVnRjMTlqYjNWdWREb2dkV2x1ZERZMExDQm1hWGhsWkY5bGJHVnRaVzUwWDNOcGVtVTZJSFZwYm5RMk5Da2dMVDRnZG05cFpEb0tZbTk0WDJSNWJtRnRhV05mWVhKeVlYbGZZMjl1WTJGMFgyWnBlR1ZrT2dvZ0lDQWdjSEp2ZEc4Z05TQXdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUVUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE5Bb2dJQ0FnYVc1MFkxOHhJQzh2SURJS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQmlkRzlwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFVLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJSEJ2Y0FvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lDb0tJQ0FnSUNzS0lDQWdJR1p5WVcxbFgyUnBaeUF0TlFvZ0lDQWdjM2RoY0FvZ0lDQWdZbTk0WDNKbGMybDZaUW9nSUNBZ1pIVndDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUNzS0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFVLSUNBZ0lHWnlZVzFsWDJScFp5QXROQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JpYjNoZmNtVndiR0ZqWlFvZ0lDQWdabkpoYldWZlpHbG5JQzAwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnYzNkaGNBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0FxQ2lBZ0lDQXJDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUVUtJQ0FnSUhOM1lYQUtJQ0FnSUhCMWMyaHBiblFnTUFvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQmliM2hmYzNCc2FXTmxDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QmZjSFY1WVY5c2FXSXVZbTk0WDJGeVl6UXVZbTk0WDNWd1pHRjBaVjl2Wm1aelpYUmZhVzVqS0dKdmVGOXJaWGs2SUdKNWRHVnpMQ0J2Wm1aelpYUTZJSFZwYm5RMk5Dd2dkbUZzZFdVNklIVnBiblEyTkNrZ0xUNGdkbTlwWkRvS1ltOTRYM1Z3WkdGMFpWOXZabVp6WlhSZmFXNWpPZ29nSUNBZ2NISnZkRzhnTXlBd0NpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdhVzUwWTE4eElDOHZJRElLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNCaWRHOXBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUNzS0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JpYjNoZmNtVndiR0ZqWlFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnZEdWemRGOWpZWE5sY3k1c1lYSm5aVjlpYjNoZmIzQmxjbUYwYVc5dWN5NXpkSEoxWTNSZllYSnlZWGxmZFdsdWREWTBMbE4wY25WamRFRnljbUY1VlVsdWREWTBMbUp2YjNSemRISmhjRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21KdmIzUnpkSEpoY0RvS0lDQWdJQzh2SUd4aGNtZGxYMkp2ZUY5dmNHVnlZWFJwYjI1ekwzTjBjblZqZEY5aGNuSmhlVjkxYVc1ME5qUXVjSGs2TWpNS0lDQWdJQzh2SUhObGJHWXVZbTk0TG5aaGJIVmxJRDBnVTNSeWRXTjBWMmwwYUVGeWNtRjVWVFkwS0FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWW05NElnb2dJQ0FnTHk4Z2JHRnlaMlZmWW05NFgyOXdaWEpoZEdsdmJuTXZjM1J5ZFdOMFgyRnljbUY1WDNWcGJuUTJOQzV3ZVRveU15MHlPQW9nSUNBZ0x5OGdjMlZzWmk1aWIzZ3VkbUZzZFdVZ1BTQlRkSEoxWTNSWGFYUm9RWEp5WVhsVk5qUW9DaUFnSUNBdkx5QWdJQ0FnWVQxVlNXNTBOalFvTVNrc0NpQWdJQ0F2THlBZ0lDQWdZWEp5UFVGeWNtRjVWVFkwS0Nrc0NpQWdJQ0F2THlBZ0lDQWdZajFWU1c1ME5qUW9NaWtzQ2lBZ0lDQXZMeUFnSUNBZ2NHRmtaR2x1WnoxTVlYSm5aVUo1ZEdWektDa3NDaUFnSUNBdkx5QXBDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lDOHZJR3hoY21kbFgySnZlRjl2Y0dWeVlYUnBiMjV6TDNOMGNuVmpkRjloY25KaGVWOTFhVzUwTmpRdWNIazZNak1LSUNBZ0lDOHZJSE5sYkdZdVltOTRMblpoYkhWbElEMGdVM1J5ZFdOMFYybDBhRUZ5Y21GNVZUWTBLQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZbTk0SWdvZ0lDQWdMeThnYkdGeVoyVmZZbTk0WDI5d1pYSmhkR2x2Ym5NdmMzUnlkV04wWDJGeWNtRjVYM1ZwYm5RMk5DNXdlVG95TXkweU9Bb2dJQ0FnTHk4Z2MyVnNaaTVpYjNndWRtRnNkV1VnUFNCVGRISjFZM1JYYVhSb1FYSnlZWGxWTmpRb0NpQWdJQ0F2THlBZ0lDQWdZVDFWU1c1ME5qUW9NU2tzQ2lBZ0lDQXZMeUFnSUNBZ1lYSnlQVUZ5Y21GNVZUWTBLQ2tzQ2lBZ0lDQXZMeUFnSUNBZ1lqMVZTVzUwTmpRb01pa3NDaUFnSUNBdkx5QWdJQ0FnY0dGa1pHbHVaejFNWVhKblpVSjVkR1Z6S0Nrc0NpQWdJQ0F2THlBcENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01EQXdNREF3TURBd01EQXdNREF4TURBeE5EQXdNREF3TURBd01EQXdNREF3TURJd01ERTJNREF3TURBd01EQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJR3hoY21kbFgySnZlRjl2Y0dWeVlYUnBiMjV6TDNOMGNuVmpkRjloY25KaGVWOTFhVzUwTmpRdWNIazZNamtLSUNBZ0lDOHZJSE5sYkdZdVltOTRMblpoYkhWbExuQmhaR1JwYm1jdVlYQndaVzVrS0VKNWRHVnpOREE1TmlncEtRb2dJQ0FnYVc1MFl5QTBJQzh2SURRd09UWUtJQ0FnSUdKNlpYSnZDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmliM2dpQ2lBZ0lDQndkWE5vYVc1MElERTRDaUFnSUNCcGJuUmpYekVnTHk4Z01nb2dJQ0FnWW05NFgyVjRkSEpoWTNRS0lDQWdJR0owYjJrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1KdmVDSUtJQ0FnSUhOM1lYQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lHbHVkR01nTkNBdkx5QTBNRGsyQ2lBZ0lDQmpZV3hzYzNWaUlHSnZlRjlrZVc1aGJXbGpYMkZ5Y21GNVgyTnZibU5oZEY5bWFYaGxaQW9nSUNBZ0x5OGdiR0Z5WjJWZlltOTRYMjl3WlhKaGRHbHZibk12YzNSeWRXTjBYMkZ5Y21GNVgzVnBiblEyTkM1d2VUb3lOUW9nSUNBZ0x5OGdZWEp5UFVGeWNtRjVWVFkwS0Nrc0NpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01EQXdDaUFnSUNBdkx5QnNZWEpuWlY5aWIzaGZiM0JsY21GMGFXOXVjeTl6ZEhKMVkzUmZZWEp5WVhsZmRXbHVkRFkwTG5CNU9qTXdDaUFnSUNBdkx5QnpaV3htTG5abGNtbG1lU2hCY25KaGVWVTJOQ2dwS1FvZ0lDQWdZMkZzYkhOMVlpQjBaWE4wWDJOaGMyVnpMbXhoY21kbFgySnZlRjl2Y0dWeVlYUnBiMjV6TG5OMGNuVmpkRjloY25KaGVWOTFhVzUwTmpRdVUzUnlkV04wUVhKeVlYbFZTVzUwTmpRdWRtVnlhV1o1Q2lBZ0lDQndiM0FLSUNBZ0lDOHZJR3hoY21kbFgySnZlRjl2Y0dWeVlYUnBiMjV6TDNOMGNuVmpkRjloY25KaGVWOTFhVzUwTmpRdWNIazZNakVLSUNBZ0lDOHZJRUJ3ZFdKc2FXTUtJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBYMk5oYzJWekxteGhjbWRsWDJKdmVGOXZjR1Z5WVhScGIyNXpMbk4wY25WamRGOWhjbkpoZVY5MWFXNTBOalF1VTNSeWRXTjBRWEp5WVhsVlNXNTBOalF1WVhCd1pXNWtXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWVhCd1pXNWtPZ29nSUNBZ0x5OGdiR0Z5WjJWZlltOTRYMjl3WlhKaGRHbHZibk12YzNSeWRXTjBYMkZ5Y21GNVgzVnBiblEyTkM1d2VUb3pNZ29nSUNBZ0x5OGdRSEIxWW14cFl3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdiR0Z5WjJWZlltOTRYMjl3WlhKaGRHbHZibk12YzNSeWRXTjBYMkZ5Y21GNVgzVnBiblEyTkM1d2VUb3pOQW9nSUNBZ0x5OGdjMlZzWmk1aWIzZ3VkbUZzZFdVdVlYSnlMbUZ3Y0dWdVpDaDJZV3gxWlNrS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1KdmVDSUtJQ0FnSUhCMWMyaHBiblFnTVRnS0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQmpZV3hzYzNWaUlHSnZlRjkxY0dSaGRHVmZiMlptYzJWMFgybHVZd29nSUNBZ1lubDBaV05mTUNBdkx5QWlZbTk0SWdvZ0lDQWdhVzUwWTE4eklDOHZJREl3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdZMkZzYkhOMVlpQmliM2hmWkhsdVlXMXBZMTloY25KaGVWOWpiMjVqWVhSZlptbDRaV1FLSUNBZ0lDOHZJR3hoY21kbFgySnZlRjl2Y0dWeVlYUnBiMjV6TDNOMGNuVmpkRjloY25KaGVWOTFhVzUwTmpRdWNIazZNeklLSUNBZ0lDOHZJRUJ3ZFdKc2FXTUtJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBYMk5oYzJWekxteGhjbWRsWDJKdmVGOXZjR1Z5WVhScGIyNXpMbk4wY25WamRGOWhjbkpoZVY5MWFXNTBOalF1VTNSeWRXTjBRWEp5WVhsVlNXNTBOalF1WTI5dVkyRjBXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWTI5dVkyRjBPZ29nSUNBZ0x5OGdiR0Z5WjJWZlltOTRYMjl3WlhKaGRHbHZibk12YzNSeWRXTjBYMkZ5Y21GNVgzVnBiblEyTkM1d2VUb3pOZ29nSUNBZ0x5OGdRSEIxWW14cFl3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb2FXNTBJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJQ29LSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh4SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBekNpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHgxYVc1ME5qUStDaUFnSUNBdkx5QnNZWEpuWlY5aWIzaGZiM0JsY21GMGFXOXVjeTl6ZEhKMVkzUmZZWEp5WVhsZmRXbHVkRFkwTG5CNU9qTTRDaUFnSUNBdkx5QnpaV3htTG1KdmVDNTJZV3gxWlM1aGNuSXVaWGgwWlc1a0tHRnljbUY1S1FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVltOTRJZ29nSUNBZ2NIVnphR2x1ZENBeE9Bb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmpZV3hzYzNWaUlHSnZlRjkxY0dSaGRHVmZiMlptYzJWMFgybHVZd29nSUNBZ1lubDBaV05mTUNBdkx5QWlZbTk0SWdvZ0lDQWdhVzUwWTE4eklDOHZJREl3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lHTmhiR3h6ZFdJZ1ltOTRYMlI1Ym1GdGFXTmZZWEp5WVhsZlkyOXVZMkYwWDJacGVHVmtDaUFnSUNBdkx5QnNZWEpuWlY5aWIzaGZiM0JsY21GMGFXOXVjeTl6ZEhKMVkzUmZZWEp5WVhsZmRXbHVkRFkwTG5CNU9qTTJDaUFnSUNBdkx5QkFjSFZpYkdsakNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRGOWpZWE5sY3k1c1lYSm5aVjlpYjNoZmIzQmxjbUYwYVc5dWN5NXpkSEoxWTNSZllYSnlZWGxmZFdsdWREWTBMbE4wY25WamRFRnljbUY1VlVsdWREWTBMbkJ2Y0Z0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuQnZjRG9LSUNBZ0lDOHZJR3hoY21kbFgySnZlRjl2Y0dWeVlYUnBiMjV6TDNOMGNuVmpkRjloY25KaGVWOTFhVzUwTmpRdWNIazZORElLSUNBZ0lDOHZJSEpsZEhWeWJpQnpaV3htTG1KdmVDNTJZV3gxWlM1aGNuSXVjRzl3S0NrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1KdmVDSUtJQ0FnSUdsdWRHTmZNeUF2THlBeU1Bb2dJQ0FnYVc1MFkxOHhJQzh2SURJS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQmlkRzlwQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNBdElDOHZJRzl1SUdWeWNtOXlPaUJqWVc1dWIzUWdjRzl3SUdaeWIyMGdaVzF3ZEhrZ1lYSnlZWGtLSUNBZ0lHUjFjQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0E4Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzVrWlhnZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUNvS0lDQWdJSEIxYzJocGJuUWdNaklLSUNBZ0lDc0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltSnZlQ0lLSUNBZ0lITjNZWEFLSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNCaWIzaGZaWGgwY21GamRDQXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2diM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWW05NElnb2dJQ0FnY0hWemFHbHVkQ0F4T0FvZ0lDQWdhVzUwWTE4eElDOHZJRElLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnNZWEpuWlY5aWIzaGZiM0JsY21GMGFXOXVjeTl6ZEhKMVkzUmZZWEp5WVhsZmRXbHVkRFkwTG5CNU9qUXlDaUFnSUNBdkx5QnlaWFIxY200Z2MyVnNaaTVpYjNndWRtRnNkV1V1WVhKeUxuQnZjQ2dwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ0xRb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJQzh2SUd4aGNtZGxYMkp2ZUY5dmNHVnlZWFJwYjI1ekwzTjBjblZqZEY5aGNuSmhlVjkxYVc1ME5qUXVjSGs2TkRJS0lDQWdJQzh2SUhKbGRIVnliaUJ6Wld4bUxtSnZlQzUyWVd4MVpTNWhjbkl1Y0c5d0tDa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltSnZlQ0lLSUNBZ0lIQjFjMmhwYm5RZ01UZ0tJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZbTk0WDNKbGNHeGhZMlVLSUNBZ0lDOHZJR3hoY21kbFgySnZlRjl2Y0dWeVlYUnBiMjV6TDNOMGNuVmpkRjloY25KaGVWOTFhVzUwTmpRdWNIazZORElLSUNBZ0lDOHZJSEpsZEhWeWJpQnpaV3htTG1KdmVDNTJZV3gxWlM1aGNuSXVjRzl3S0NrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1KdmVDSUtJQ0FnSUdsdWRHTmZNeUF2THlBeU1Bb2dJQ0FnYVc1MFkxOHhJQzh2SURJS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQmlkRzlwQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWkhWd0NpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdMeThnYkdGeVoyVmZZbTk0WDI5d1pYSmhkR2x2Ym5NdmMzUnlkV04wWDJGeWNtRjVYM1ZwYm5RMk5DNXdlVG8wTWdvZ0lDQWdMeThnY21WMGRYSnVJSE5sYkdZdVltOTRMblpoYkhWbExtRnljaTV3YjNBb0tRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVltOTRJZ29nSUNBZ2FXNTBZMTh6SUM4dklESXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0p2ZUY5eVpYQnNZV05sQ2lBZ0lDQXZMeUJzWVhKblpWOWliM2hmYjNCbGNtRjBhVzl1Y3k5emRISjFZM1JmWVhKeVlYbGZkV2x1ZERZMExuQjVPalF5Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdjMlZzWmk1aWIzZ3VkbUZzZFdVdVlYSnlMbkJ2Y0NncENpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdLZ29nSUNBZ2NIVnphR2x1ZENBeU1nb2dJQ0FnS3dvZ0lDQWdMeThnYkdGeVoyVmZZbTk0WDI5d1pYSmhkR2x2Ym5NdmMzUnlkV04wWDJGeWNtRjVYM1ZwYm5RMk5DNXdlVG8wTWdvZ0lDQWdMeThnY21WMGRYSnVJSE5sYkdZdVltOTRMblpoYkhWbExtRnljaTV3YjNBb0tRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVltOTRJZ29nSUNBZ2MzZGhjQW9nSUNBZ0x5OGdiR0Z5WjJWZlltOTRYMjl3WlhKaGRHbHZibk12YzNSeWRXTjBYMkZ5Y21GNVgzVnBiblEyTkM1d2VUbzBNZ29nSUNBZ0x5OGdjbVYwZFhKdUlITmxiR1l1WW05NExuWmhiSFZsTG1GeWNpNXdiM0FvS1FvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlQW9nSUNBZ1ltOTRYM053YkdsalpRb2dJQ0FnTHk4Z2JHRnlaMlZmWW05NFgyOXdaWEpoZEdsdmJuTXZjM1J5ZFdOMFgyRnljbUY1WDNWcGJuUTJOQzV3ZVRvME1nb2dJQ0FnTHk4Z2NtVjBkWEp1SUhObGJHWXVZbTk0TG5aaGJIVmxMbUZ5Y2k1d2IzQW9LUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZbTk0SWdvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnY0c5d0NpQWdJQ0F2THlCc1lYSm5aVjlpYjNoZmIzQmxjbUYwYVc5dWN5OXpkSEoxWTNSZllYSnlZWGxmZFdsdWREWTBMbkI1T2pReUNpQWdJQ0F2THlCeVpYUjFjbTRnYzJWc1ppNWliM2d1ZG1Gc2RXVXVZWEp5TG5CdmNDZ3BDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnTFFvZ0lDQWdMeThnYkdGeVoyVmZZbTk0WDI5d1pYSmhkR2x2Ym5NdmMzUnlkV04wWDJGeWNtRjVYM1ZwYm5RMk5DNXdlVG8wTWdvZ0lDQWdMeThnY21WMGRYSnVJSE5sYkdZdVltOTRMblpoYkhWbExtRnljaTV3YjNBb0tRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVltOTRJZ29nSUNBZ2MzZGhjQW9nSUNBZ1ltOTRYM0psYzJsNlpRb2dJQ0FnTHk4Z2JHRnlaMlZmWW05NFgyOXdaWEpoZEdsdmJuTXZjM1J5ZFdOMFgyRnljbUY1WDNWcGJuUTJOQzV3ZVRvME1Bb2dJQ0FnTHk4Z1FIQjFZbXhwWXdvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSZlkyRnpaWE11YkdGeVoyVmZZbTk0WDI5d1pYSmhkR2x2Ym5NdWMzUnlkV04wWDJGeWNtRjVYM1ZwYm5RMk5DNVRkSEoxWTNSQmNuSmhlVlZKYm5RMk5DNW5aWFJiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwblpYUTZDaUFnSUNBdkx5QnNZWEpuWlY5aWIzaGZiM0JsY21GMGFXOXVjeTl6ZEhKMVkzUmZZWEp5WVhsZmRXbHVkRFkwTG5CNU9qUTBDaUFnSUNBdkx5QkFjSFZpYkdsakNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnNZWEpuWlY5aWIzaGZiM0JsY21GMGFXOXVjeTl6ZEhKMVkzUmZZWEp5WVhsZmRXbHVkRFkwTG5CNU9qUTJDaUFnSUNBdkx5QnlaWFIxY200Z2MyVnNaaTVpYjNndWRtRnNkV1V1WVhKeVcybGtlRjBLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUp2ZUNJS0lDQWdJR2x1ZEdOZk15QXZMeUF5TUFvZ0lDQWdhVzUwWTE4eElDOHZJRElLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNCaWRHOXBDaUFnSUNCa2FXY2dNUW9nSUNBZ1Bnb2dJQ0FnWVhOelpYSjBJQzh2SUdsdVpHVjRJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQXFDaUFnSUNCd2RYTm9hVzUwSURJeUNpQWdJQ0FyQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0ppYjNnaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdZbTk0WDJWNGRISmhZM1FnTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUM4dklHeGhjbWRsWDJKdmVGOXZjR1Z5WVhScGIyNXpMM04wY25WamRGOWhjbkpoZVY5MWFXNTBOalF1Y0hrNk5EUUtJQ0FnSUM4dklFQndkV0pzYVdNS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMFgyTmhjMlZ6TG14aGNtZGxYMkp2ZUY5dmNHVnlZWFJwYjI1ekxuTjBjblZqZEY5aGNuSmhlVjkxYVc1ME5qUXVVM1J5ZFdOMFFYSnlZWGxWU1c1ME5qUXVjMlYwVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2MyVjBPZ29nSUNBZ0x5OGdiR0Z5WjJWZlltOTRYMjl3WlhKaGRHbHZibk12YzNSeWRXTjBYMkZ5Y21GNVgzVnBiblEyTkM1d2VUbzBPQW9nSUNBZ0x5OGdRSEIxWW14cFl3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdMeThnYkdGeVoyVmZZbTk0WDI5d1pYSmhkR2x2Ym5NdmMzUnlkV04wWDJGeWNtRjVYM1ZwYm5RMk5DNXdlVG8xTUFvZ0lDQWdMeThnYzJWc1ppNWliM2d1ZG1Gc2RXVXVZWEp5VzJsa2VGMGdQU0IyWVd4MVpRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVltOTRJZ29nSUNBZ2FXNTBZMTh6SUM4dklESXdDaUFnSUNCcGJuUmpYekVnTHk4Z01nb2dJQ0FnWW05NFgyVjRkSEpoWTNRS0lDQWdJR0owYjJrS0lDQWdJR1JwWnlBeUNpQWdJQ0ErQ2lBZ0lDQmhjM05sY25RZ0x5OGdhVzVrWlhnZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ2MzZGhjQW9nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUNvS0lDQWdJSEIxYzJocGJuUWdNaklLSUNBZ0lDc0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltSnZlQ0lLSUNBZ0lITjNZWEFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWW05NFgzSmxjR3hoWTJVZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lDOHZJR3hoY21kbFgySnZlRjl2Y0dWeVlYUnBiMjV6TDNOMGNuVmpkRjloY25KaGVWOTFhVzUwTmpRdWNIazZORGdLSUNBZ0lDOHZJRUJ3ZFdKc2FXTUtJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBYMk5oYzJWekxteGhjbWRsWDJKdmVGOXZjR1Z5WVhScGIyNXpMbk4wY25WamRGOWhjbkpoZVY5MWFXNTBOalF1VTNSeWRXTjBRWEp5WVhsVlNXNTBOalF1ZG1WeWFXWjVXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LZG1WeWFXWjVPZ29nSUNBZ0x5OGdiR0Z5WjJWZlltOTRYMjl3WlhKaGRHbHZibk12YzNSeWRXTjBYMkZ5Y21GNVgzVnBiblEyTkM1d2VUbzFNZ29nSUNBZ0x5OGdRSEIxWW14cFl3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb2FXNTBJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBNENpQWdJQ0FxQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEhWcGJuUTJORDRLSUNBZ0lHTmhiR3h6ZFdJZ2RHVnpkRjlqWVhObGN5NXNZWEpuWlY5aWIzaGZiM0JsY21GMGFXOXVjeTV6ZEhKMVkzUmZZWEp5WVhsZmRXbHVkRFkwTGxOMGNuVmpkRUZ5Y21GNVZVbHVkRFkwTG5abGNtbG1lUW9nSUNBZ2NHOXdDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkRjlqWVhObGN5NXNZWEpuWlY5aWIzaGZiM0JsY21GMGFXOXVjeTV6ZEhKMVkzUmZZWEp5WVhsZmRXbHVkRFkwTGxOMGNuVmpkRUZ5Y21GNVZVbHVkRFkwTG5abGNtbG1lU2hsZUhCbFkzUmxaRG9nWW5sMFpYTXBJQzArSUdKNWRHVnpPZ3AwWlhOMFgyTmhjMlZ6TG14aGNtZGxYMkp2ZUY5dmNHVnlZWFJwYjI1ekxuTjBjblZqZEY5aGNuSmhlVjkxYVc1ME5qUXVVM1J5ZFdOMFFYSnlZWGxWU1c1ME5qUXVkbVZ5YVdaNU9nb2dJQ0FnTHk4Z2JHRnlaMlZmWW05NFgyOXdaWEpoZEdsdmJuTXZjM1J5ZFdOMFgyRnljbUY1WDNWcGJuUTJOQzV3ZVRvMU1pMDFNd29nSUNBZ0x5OGdRSEIxWW14cFl3b2dJQ0FnTHk4Z1pHVm1JSFpsY21sbWVTaHpaV3htTENCbGVIQmxZM1JsWkRvZ1FYSnlZWGxWTmpRcElDMCtJRTV2Ym1VNkNpQWdJQ0J3Y205MGJ5QXhJREVLSUNBZ0lDOHZJR3hoY21kbFgySnZlRjl2Y0dWeVlYUnBiMjV6TDNOMGNuVmpkRjloY25KaGVWOTFhVzUwTmpRdWNIazZOVFFLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpaV3htTG1KdmVDNTJZV3gxWlM1aGNuSWdQVDBnWlhod1pXTjBaV1FLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUp2ZUNJS0lDQWdJR2x1ZEdOZk15QXZMeUF5TUFvZ0lDQWdhVzUwWTE4eElDOHZJRElLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNCaWRHOXBDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnS2dvZ0lDQWdhVzUwWTE4eElDOHZJRElLSUNBZ0lDc0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltSnZlQ0lLSUNBZ0lHbHVkR05mTXlBdkx5QXlNQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUJzWVhKblpWOWliM2hmYjNCbGNtRjBhVzl1Y3k5emRISjFZM1JmWVhKeVlYbGZkV2x1ZERZMExuQjVPalUxQ2lBZ0lDQXZMeUJoYzNObGNuUWdjMlZzWmk1aWIzZ3VkbUZzZFdVdVlTQTlQU0F4Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0ppYjNnaUNpQWdJQ0J3ZFhOb2FXNTBJREFLSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNCaWIzaGZaWGgwY21GamRDQXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2diM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdZblJ2YVFvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJR3hoY21kbFgySnZlRjl2Y0dWeVlYUnBiMjV6TDNOMGNuVmpkRjloY25KaGVWOTFhVzUwTmpRdWNIazZOVFlLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpaV3htTG1KdmVDNTJZV3gxWlM1aUlEMDlJRElLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUp2ZUNJS0lDQWdJSEIxYzJocGJuUWdNVEFLSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNCaWIzaGZaWGgwY21GamRDQXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2diM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdZblJ2YVFvZ0lDQWdhVzUwWTE4eElDOHZJRElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJR3hoY21kbFgySnZlRjl2Y0dWeVlYUnBiMjV6TDNOMGNuVmpkRjloY25KaGVWOTFhVzUwTmpRdWNIazZOVGNLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpaV3htTG1KdmVDNTJZV3gxWlM1d1lXUmthVzVuTG14bGJtZDBhQ0E5UFNBeENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKaWIzZ2lDaUFnSUNCd2RYTm9hVzUwSURFNENpQWdJQ0JwYm5Salh6RWdMeThnTWdvZ0lDQWdZbTk0WDJWNGRISmhZM1FLSUNBZ0lHSjBiMmtLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUp2ZUNJS0lDQWdJSE4zWVhBS0lDQWdJR2x1ZEdOZk1TQXZMeUF5Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQW9nSUNBZ1luUnZhUW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklHeGhjbWRsWDJKdmVGOXZjR1Z5WVhScGIyNXpMM04wY25WamRGOWhjbkpoZVY5MWFXNTBOalF1Y0hrNk5UZ0tJQ0FnSUM4dklHRnpjMlZ5ZENCelpXeG1MbUp2ZUM1c1pXNW5kR2dnUGlBME1EazJMQ0FpWlhod1pXTjBaV1FnWW05NElHeGxibWQwYUNBK05EQTVOaUlLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUp2ZUNJS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUhCdmNBb2dJQ0FnYVc1MFl5QTBJQzh2SURRd09UWUtJQ0FnSUQ0S0lDQWdJR0Z6YzJWeWRDQXZMeUJsZUhCbFkzUmxaQ0JpYjNnZ2JHVnVaM1JvSUQ0ME1EazJDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUhKbGRITjFZZ289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRkNBSUJGSUFnSmdJRFltOTRCQlVmZkhVeEcwRUFRREVaRkVReEdFU0NCd1MreDIySEJEUW8vK29FV1VuT1hRUzRKYUZDQkxRMm5EWUV6dEc5eGdReGVqNEROaG9BamdjQVd3Q1hBTE1BM2dFd0FWRUJlQUF4R1JReEdCUVFRNG9GQUl2N2kvd2p1aGVMKzcxSWkvNkwvd3NJaS90TTAwbUwvZ2dXVndZQ2kvdUwvRThDdTR2OEl3aE1pLzhMQ0l2N1RJRUFpLzNTaVlvREFJdjlpLzRqdWhlTC93Z1dWd1lDaS8yTC9rOEN1NGtvdkVnb2dCZ0FBQUFBQUFBQUFRQVVBQUFBQUFBQUFBSUFGZ0FBQUFDL0lRU3ZLSUVTSTdvWEtFeFBBaVFoQklqL2ZJQUNBQUNJQVBwSUpFTTJHZ0ZKRlNJU1JCY1dLSUVTSW9qL21pZ2xUd0lrSW9qL1dDUkROaG9CU1lFQVdVa2lDMGtqQ0VzREZSSkVUd0pYQWdBb2dSSlBBNGovY0NnbFR3SlBBeUtJL3kwa1F5Z2xJN29YU1NRSlNVOENERVFpQzRFV0NDaE1Jcm9vZ1JJanVoY2lDUlpYQmdJb2dSSlBBcnNvSlNPNkZ5UUpTUlpYQmdJb0pVOEN1eUlMZ1JZSUtFd2lnQURTS0wxSUlna29UTk1wVEZDd0pFTTJHZ0ZKRlNJU1JCY29KU082RjBzQkRVUWlDNEVXQ0NoTUlyb3BURkN3SkVNMkdnRkpGU0lTUkJjMkdnSkpGU0lTUkNnbEk3b1hTd0lOUkV3aUM0RVdDQ2hNVHdLN0pFTTJHZ0ZKZ1FCWklnc2pDRXNCRlJKRWlBQURTQ1JEaWdFQktDVWp1aGNpQ3lNSUtDVlBBcnFML3hKRUtJRUFJcm9YSkJKRUtJRUtJcm9YSXhKRUtJRVNJN29YS0V3anVoY2tFa1FvdlVnaEJBMUVpLytKIiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo5OSwibWlub3IiOjk5LCJwYXRjaCI6OTksImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
