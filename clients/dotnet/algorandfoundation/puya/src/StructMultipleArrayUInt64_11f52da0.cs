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

namespace Arc56.Generated.algorandfoundation.puya.StructMultipleArrayUInt64_11f52da0
{


    public class StructMultipleArrayUInt64Proxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public StructMultipleArrayUInt64Proxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class StructWithMultipleArrays : AVMObjectType
            {
                public ulong A { get; set; }

                public ulong[] Arr1 { get; set; }

                public ulong[] Arr2 { get; set; }

                public ulong[] Arr3 { get; set; }

                public ulong B { get; set; }

                public byte[][] Padding { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vA.From(A);
                    ret.AddRange(vA.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vArr1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64[]");
                    vArr1.From(Arr1);
                    ret.AddRange(vArr1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vArr2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64[]");
                    vArr2.From(Arr2);
                    ret.AddRange(vArr2.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vArr3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64[]");
                    vArr3.From(Arr3);
                    ret.AddRange(vArr3.Encode());
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

                public static StructWithMultipleArrays Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new StructWithMultipleArrays();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vA.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueA = vA.ToValue();
                    if (valueA is ulong vAValue) { ret.A = vAValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vArr1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64[]");
                    count = vArr1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueArr1 = vArr1.ToValue();
                    if (valueArr1 is ulong[] vArr1Value) { ret.Arr1 = vArr1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vArr2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64[]");
                    count = vArr2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueArr2 = vArr2.ToValue();
                    if (valueArr2 is ulong[] vArr2Value) { ret.Arr2 = vArr2Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vArr3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64[]");
                    count = vArr3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueArr3 = vArr3.ToValue();
                    if (valueArr3 is ulong[] vArr3Value) { ret.Arr3 = vArr3Value; }
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
                    return Equals(obj as StructWithMultipleArrays);
                }
                public bool Equals(StructWithMultipleArrays? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(StructWithMultipleArrays left, StructWithMultipleArrays right)
                {
                    return EqualityComparer<StructWithMultipleArrays>.Default.Equals(left, right);
                }
                public static bool operator !=(StructWithMultipleArrays left, StructWithMultipleArrays right)
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU3RydWN0TXVsdGlwbGVBcnJheVVJbnQ2NCIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJTdHJ1Y3RXaXRoTXVsdGlwbGVBcnJheXMiOlt7Im5hbWUiOiJhIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImFycjEiLCJ0eXBlIjoidWludDY0W10ifSx7Im5hbWUiOiJhcnIyIiwidHlwZSI6InVpbnQ2NFtdIn0seyJuYW1lIjoiYXJyMyIsInR5cGUiOiJ1aW50NjRbXSJ9LHsibmFtZSI6ImIiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoicGFkZGluZyIsInR5cGUiOiJieXRlWzQwOTZdW10ifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiYm9vdHN0cmFwIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFwcGVuZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjb25jYXQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0W10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcnJheSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJwb3AiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiaWR4IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImlkeCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidmVyaWZ5IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NFtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZXhwZWN0ZWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls2MzUsNjkzLDc1MV0sImVycm9yTWVzc2FnZSI6ImNhbm5vdCBwb3AgZnJvbSBlbXB0eSBhcnJheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExNzVdLCJlcnJvck1lc3NhZ2UiOiJleHBlY3RlZCBib3ggbGVuZ3RoID40MDk2IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzAxXSwiZXJyb3JNZXNzYWdlIjoiaW5kZXggYWNjZXNzIGlzIG91dCBvZiBib3VuZHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2NDAsNjQ5LDY5OCw3MTAsNzU2LDc2OCw4MTMsODI1LDg0Myw4NTIsODc0LDg4Myw5MjQsOTM4LDk1OSw5NjksOTg4LDk5OCwxMTQxLDExNTBdLCJlcnJvck1lc3NhZ2UiOiJpbmRleCBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjY4LDQ4Nyw1NTEsNTk4LDEwMDddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0OTgsMTAxNl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8dWludDY0PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM4OSw4MDIsOTAzLDkxMl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXlJRGdnTVNBeE1pQTBNRGsyQ2lBZ0lDQmllWFJsWTJKc2IyTnJJQ0ppYjNnaUlEQjRNVFV4Wmpkak56VWdNSGd3TmpneE1ERUtJQ0FnSUM4dklHeGhjbWRsWDJKdmVGOXZjR1Z5WVhScGIyNXpMM04wY25WamRGOXRkV3gwYVhCc1pWOWhjbkpoZVY5MWFXNTBOalF1Y0hrNk16SUtJQ0FnSUM4dklHTnNZWE56SUZOMGNuVmpkRTExYkhScGNHeGxRWEp5WVhsVlNXNTBOalFvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCaWVpQnRZV2x1WDE5ZllXeG5iM0I1WDJSbFptRjFiSFJmWTNKbFlYUmxRREUyQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFLSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGhpWldNM05tUTROeUF3ZURNME1qaG1abVZoSURCNE5UazBPV05sTldRZ01IaGlPREkxWVRFME1pQXdlR0kwTXpZNVl6TTJJREI0WTJWa01XSmtZellnTUhnek1UZGhNMlV3TXlBdkx5QnRaWFJvYjJRZ0ltSnZiM1J6ZEhKaGNDZ3BkbTlwWkNJc0lHMWxkR2h2WkNBaVlYQndaVzVrS0hWcGJuUTJOQ2wyYjJsa0lpd2diV1YwYUc5a0lDSmpiMjVqWVhRb2RXbHVkRFkwVzEwcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpY0c5d0tDbDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0ltZGxkQ2gxYVc1ME5qUXBkV2x1ZERZMElpd2diV1YwYUc5a0lDSnpaWFFvZFdsdWREWTBMSFZwYm5RMk5DbDJiMmxrSWl3Z2JXVjBhRzlrSUNKMlpYSnBabmtvZFdsdWREWTBXMTBwZG05cFpDSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JR0p2YjNSemRISmhjQ0JoY0hCbGJtUWdZMjl1WTJGMElIQnZjQ0JuWlhRZ2MyVjBJSFpsY21sbWVRb2dJQ0FnWlhKeUNncHRZV2x1WDE5ZllXeG5iM0I1WDJSbFptRjFiSFJmWTNKbFlYUmxRREUyT2dvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNFS0lDQWdJQ1ltQ2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJmY0hWNVlWOXNhV0l1WW05NFgyRnlZelF1WW05NFgyUjVibUZ0YVdOZllYSnlZWGxmY0c5d1gyWnBlR1ZrWDNOcGVtVW9ZbTk0WDJ0bGVUb2dZbmwwWlhNc0lHRnljbUY1WDI5bVpuTmxkRG9nZFdsdWREWTBMQ0JtYVhobFpGOWllWFJsWDNOcGVtVTZJSFZwYm5RMk5Da2dMVDRnZG05cFpEb0tZbTk0WDJSNWJtRnRhV05mWVhKeVlYbGZjRzl3WDJacGVHVmtYM05wZW1VNkNpQWdJQ0J3Y205MGJ5QXpJREFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCcGJuUmpYekFnTHk4Z01nb2dJQ0FnWW05NFgyVjRkSEpoWTNRS0lDQWdJR0owYjJrS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCa2RYQUtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaWIzaGZjbVZ3YkdGalpRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JwYm5Salh6QWdMeThnTWdvZ0lDQWdLd29nSUNBZ2MzZGhjQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNBcUNpQWdJQ0FyQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lITjNZWEFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRDaUFnSUNCaWIzaGZjM0JzYVdObENpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUhCdmNBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0F0Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lITjNZWEFLSUNBZ0lHSnZlRjl5WlhOcGVtVUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklGOXdkWGxoWDJ4cFlpNWliM2hmWVhKak5DNWliM2hmWkhsdVlXMXBZMTloY25KaGVWOWpiMjVqWVhSZlptbDRaV1FvWW05NFgydGxlVG9nWW5sMFpYTXNJR0Z5Y21GNVgyOW1abk5sZERvZ2RXbHVkRFkwTENCdVpYZGZhWFJsYlhOZllubDBaWE02SUdKNWRHVnpMQ0J1WlhkZmFYUmxiWE5mWTI5MWJuUTZJSFZwYm5RMk5Dd2dabWw0WldSZlpXeGxiV1Z1ZEY5emFYcGxPaUIxYVc1ME5qUXBJQzArSUhadmFXUTZDbUp2ZUY5a2VXNWhiV2xqWDJGeWNtRjVYMk52Ym1OaGRGOW1hWGhsWkRvS0lDQWdJSEJ5YjNSdklEVWdNQW9nSUNBZ1puSmhiV1ZmWkdsbklDMDFDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUUUtJQ0FnSUdsdWRHTmZNQ0F2THlBeUNpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdZblJ2YVFvZ0lDQWdabkpoYldWZlpHbG5JQzAxQ2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0J3YjNBS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQXFDaUFnSUNBckNpQWdJQ0JtY21GdFpWOWthV2NnTFRVS0lDQWdJSE4zWVhBS0lDQWdJR0p2ZUY5eVpYTnBlbVVLSUNBZ0lHUjFjQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNBckNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdabkpoYldWZlpHbG5JQzAxQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWW05NFgzSmxjR3hoWTJVS0lDQWdJR1p5WVcxbFgyUnBaeUF0TkFvZ0lDQWdhVzUwWTE4d0lDOHZJRElLSUNBZ0lDc0tJQ0FnSUhOM1lYQUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnS2dvZ0lDQWdLd29nSUNBZ1puSmhiV1ZmWkdsbklDMDFDaUFnSUNCemQyRndDaUFnSUNCd2RYTm9hVzUwSURBS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdZbTk0WDNOd2JHbGpaUW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdYM0IxZVdGZmJHbGlMbUp2ZUY5aGNtTTBMbUp2ZUY5MWNHUmhkR1ZmYjJabWMyVjBYMlJsWXloaWIzaGZhMlY1T2lCaWVYUmxjeXdnYjJabWMyVjBPaUIxYVc1ME5qUXNJSFpoYkhWbE9pQjFhVzUwTmpRcElDMCtJSFp2YVdRNkNtSnZlRjkxY0dSaGRHVmZiMlptYzJWMFgyUmxZem9LSUNBZ0lIQnliM1J2SURNZ01Bb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR2x1ZEdOZk1DQXZMeUF5Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQW9nSUNBZ1luUnZhUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNBdENpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWW05NFgzSmxjR3hoWTJVS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUY5d2RYbGhYMnhwWWk1aWIzaGZZWEpqTkM1aWIzaGZkWEJrWVhSbFgyOW1abk5sZEY5cGJtTW9ZbTk0WDJ0bGVUb2dZbmwwWlhNc0lHOW1abk5sZERvZ2RXbHVkRFkwTENCMllXeDFaVG9nZFdsdWREWTBLU0F0UGlCMmIybGtPZ3BpYjNoZmRYQmtZWFJsWDI5bVpuTmxkRjlwYm1NNkNpQWdJQ0J3Y205MGJ5QXpJREFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCcGJuUmpYekFnTHk4Z01nb2dJQ0FnWW05NFgyVjRkSEpoWTNRS0lDQWdJR0owYjJrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdLd29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHSnZlRjl5WlhCc1lXTmxDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QjBaWE4wWDJOaGMyVnpMbXhoY21kbFgySnZlRjl2Y0dWeVlYUnBiMjV6TG5OMGNuVmpkRjl0ZFd4MGFYQnNaVjloY25KaGVWOTFhVzUwTmpRdWFXNWpYMkZ5Y21GNUtHRnljam9nWW5sMFpYTXNJR2x1WXpvZ2RXbHVkRFkwS1NBdFBpQmllWFJsY3l3Z1lubDBaWE02Q21sdVkxOWhjbkpoZVRvS0lDQWdJQzh2SUd4aGNtZGxYMkp2ZUY5dmNHVnlZWFJwYjI1ekwzTjBjblZqZEY5dGRXeDBhWEJzWlY5aGNuSmhlVjkxYVc1ME5qUXVjSGs2T1RNdE9UUUtJQ0FnSUM4dklFQnpkV0p5YjNWMGFXNWxDaUFnSUNBdkx5QmtaV1lnYVc1algyRnljbUY1S0dGeWNqb2dRWEp5WVhsVk5qUXNJR2x1WXpvZ1ZVbHVkRFkwS1NBdFBpQkJjbkpoZVZVMk5Eb0tJQ0FnSUhCeWIzUnZJRElnTWdvZ0lDQWdMeThnYkdGeVoyVmZZbTk0WDI5d1pYSmhkR2x2Ym5NdmMzUnlkV04wWDIxMWJIUnBjR3hsWDJGeWNtRjVYM1ZwYm5RMk5DNXdlVG81TmdvZ0lDQWdMeThnWm05eUlHbGtlQ0JwYmlCMWNtRnVaMlVvYm1WM0xteGxibWQwYUNrNkNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJSEIxYzJocGJuUWdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0J3ZFhOb2FXNTBJREFLQ21sdVkxOWhjbkpoZVY5bWIzSmZhR1ZoWkdWeVFERTZDaUFnSUNBdkx5QnNZWEpuWlY5aWIzaGZiM0JsY21GMGFXOXVjeTl6ZEhKMVkzUmZiWFZzZEdsd2JHVmZZWEp5WVhsZmRXbHVkRFkwTG5CNU9qazJDaUFnSUNBdkx5Qm1iM0lnYVdSNElHbHVJSFZ5WVc1blpTaHVaWGN1YkdWdVozUm9LVG9LSUNBZ0lHUjFjQW9nSUNBZ1pHbG5JRE1LSUNBZ0lEd0tJQ0FnSUdKNklHbHVZMTloY25KaGVWOWhablJsY2w5bWIzSkFOQW9nSUNBZ0x5OGdiR0Z5WjJWZlltOTRYMjl3WlhKaGRHbHZibk12YzNSeWRXTjBYMjExYkhScGNHeGxYMkZ5Y21GNVgzVnBiblEyTkM1d2VUbzVOd29nSUNBZ0x5OGdibVYzVzJsa2VGMGdLejBnYVc1akNpQWdJQ0J6ZDJGd0NpQWdJQ0JrZFhBS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQmthV2NnTWdvZ0lDQWdhVzUwWTE4eElDOHZJRGdLSUNBZ0lDb0tJQ0FnSUhOM1lYQUtJQ0FnSUdScFp5QXhDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNBckNpQWdJQ0JwZEc5aUNpQWdJQ0J6ZDJGd0NpQWdJQ0JwYm5Salh6QWdMeThnTWdvZ0lDQWdLd29nSUNBZ2MzZGhjQW9nSUNBZ2NtVndiR0ZqWlRNZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHRmpZMlZ6Y3lCcGN5QnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQXZMeUJzWVhKblpWOWliM2hmYjNCbGNtRjBhVzl1Y3k5emRISjFZM1JmYlhWc2RHbHdiR1ZmWVhKeVlYbGZkV2x1ZERZMExuQjVPamsyQ2lBZ0lDQXZMeUJtYjNJZ2FXUjRJR2x1SUhWeVlXNW5aU2h1WlhjdWJHVnVaM1JvS1RvS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCaUlHbHVZMTloY25KaGVWOW1iM0pmYUdWaFpHVnlRREVLQ21sdVkxOWhjbkpoZVY5aFpuUmxjbDltYjNKQU5Eb0tJQ0FnSUhCdmNBb2dJQ0FnTHk4Z2JHRnlaMlZmWW05NFgyOXdaWEpoZEdsdmJuTXZjM1J5ZFdOMFgyMTFiSFJwY0d4bFgyRnljbUY1WDNWcGJuUTJOQzV3ZVRvNU9Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUc1bGR3b2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSFJsYzNSZlkyRnpaWE11YkdGeVoyVmZZbTk0WDI5d1pYSmhkR2x2Ym5NdWMzUnlkV04wWDIxMWJIUnBjR3hsWDJGeWNtRjVYM1ZwYm5RMk5DNVRkSEoxWTNSTmRXeDBhWEJzWlVGeWNtRjVWVWx1ZERZMExtSnZiM1J6ZEhKaGNGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbUp2YjNSemRISmhjRG9LSUNBZ0lDOHZJR3hoY21kbFgySnZlRjl2Y0dWeVlYUnBiMjV6TDNOMGNuVmpkRjl0ZFd4MGFYQnNaVjloY25KaGVWOTFhVzUwTmpRdWNIazZNemdLSUNBZ0lDOHZJSE5sYkdZdVltOTRMblpoYkhWbElEMGdVM1J5ZFdOMFYybDBhRTExYkhScGNHeGxRWEp5WVhsektBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVltOTRJZ29nSUNBZ0x5OGdiR0Z5WjJWZlltOTRYMjl3WlhKaGRHbHZibk12YzNSeWRXTjBYMjExYkhScGNHeGxYMkZ5Y21GNVgzVnBiblEyTkM1d2VUb3pPQzAwTlFvZ0lDQWdMeThnYzJWc1ppNWliM2d1ZG1Gc2RXVWdQU0JUZEhKMVkzUlhhWFJvVFhWc2RHbHdiR1ZCY25KaGVYTW9DaUFnSUNBdkx5QWdJQ0FnWVQxVlNXNTBOalFvTVNrc0NpQWdJQ0F2THlBZ0lDQWdZWEp5TVQxQmNuSmhlVlUyTkNncExBb2dJQ0FnTHk4Z0lDQWdJR0Z5Y2pJOVFYSnlZWGxWTmpRb0tTd0tJQ0FnSUM4dklDQWdJQ0JoY25JelBVRnljbUY1VlRZMEtDa3NDaUFnSUNBdkx5QWdJQ0FnWWoxVlNXNTBOalFvTWlrc0NpQWdJQ0F2THlBZ0lDQWdjR0ZrWkdsdVp6MU1ZWEpuWlVKNWRHVnpLQ2tzQ2lBZ0lDQXZMeUFwQ2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJQzh2SUd4aGNtZGxYMkp2ZUY5dmNHVnlZWFJwYjI1ekwzTjBjblZqZEY5dGRXeDBhWEJzWlY5aGNuSmhlVjkxYVc1ME5qUXVjSGs2TXpnS0lDQWdJQzh2SUhObGJHWXVZbTk0TG5aaGJIVmxJRDBnVTNSeWRXTjBWMmwwYUUxMWJIUnBjR3hsUVhKeVlYbHpLQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZbTk0SWdvZ0lDQWdMeThnYkdGeVoyVmZZbTk0WDI5d1pYSmhkR2x2Ym5NdmMzUnlkV04wWDIxMWJIUnBjR3hsWDJGeWNtRjVYM1ZwYm5RMk5DNXdlVG96T0MwME5Rb2dJQ0FnTHk4Z2MyVnNaaTVpYjNndWRtRnNkV1VnUFNCVGRISjFZM1JYYVhSb1RYVnNkR2x3YkdWQmNuSmhlWE1vQ2lBZ0lDQXZMeUFnSUNBZ1lUMVZTVzUwTmpRb01Ta3NDaUFnSUNBdkx5QWdJQ0FnWVhKeU1UMUJjbkpoZVZVMk5DZ3BMQW9nSUNBZ0x5OGdJQ0FnSUdGeWNqSTlRWEp5WVhsVk5qUW9LU3dLSUNBZ0lDOHZJQ0FnSUNCaGNuSXpQVUZ5Y21GNVZUWTBLQ2tzQ2lBZ0lDQXZMeUFnSUNBZ1lqMVZTVzUwTmpRb01pa3NDaUFnSUNBdkx5QWdJQ0FnY0dGa1pHbHVaejFNWVhKblpVSjVkR1Z6S0Nrc0NpQWdJQ0F2THlBcENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01EQXdNREF3TURBd01EQXdNREF4TURBeE9EQXdNV0V3TURGak1EQXdNREF3TURBd01EQXdNREF3TWpBd01XVXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QnNZWEpuWlY5aWIzaGZiM0JsY21GMGFXOXVjeTl6ZEhKMVkzUmZiWFZzZEdsd2JHVmZZWEp5WVhsZmRXbHVkRFkwTG5CNU9qUTJDaUFnSUNBdkx5QnpaV3htTG1KdmVDNTJZV3gxWlM1d1lXUmthVzVuTG1Gd2NHVnVaQ2hDZVhSbGN6UXdPVFlvS1NrS0lDQWdJR2x1ZEdNZ05DQXZMeUEwTURrMkNpQWdJQ0JpZW1WeWJ3b2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVltOTRJZ29nSUNBZ2NIVnphR2x1ZENBeU1nb2dJQ0FnYVc1MFkxOHdJQzh2SURJS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQmlkRzlwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0ppYjNnaUNpQWdJQ0J6ZDJGd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCcGJuUmpJRFFnTHk4Z05EQTVOZ29nSUNBZ1kyRnNiSE4xWWlCaWIzaGZaSGx1WVcxcFkxOWhjbkpoZVY5amIyNWpZWFJmWm1sNFpXUUtJQ0FnSUM4dklHeGhjbWRsWDJKdmVGOXZjR1Z5WVhScGIyNXpMM04wY25WamRGOXRkV3gwYVhCc1pWOWhjbkpoZVY5MWFXNTBOalF1Y0hrNk5EQUtJQ0FnSUM4dklHRnljakU5UVhKeVlYbFZOalFvS1N3S0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd01EQUtJQ0FnSUM4dklHeGhjbWRsWDJKdmVGOXZjR1Z5WVhScGIyNXpMM04wY25WamRGOXRkV3gwYVhCc1pWOWhjbkpoZVY5MWFXNTBOalF1Y0hrNk5EY0tJQ0FnSUM4dklITmxiR1l1ZG1WeWFXWjVLRUZ5Y21GNVZUWTBLQ2twQ2lBZ0lDQmpZV3hzYzNWaUlIUmxjM1JmWTJGelpYTXViR0Z5WjJWZlltOTRYMjl3WlhKaGRHbHZibk11YzNSeWRXTjBYMjExYkhScGNHeGxYMkZ5Y21GNVgzVnBiblEyTkM1VGRISjFZM1JOZFd4MGFYQnNaVUZ5Y21GNVZVbHVkRFkwTG5abGNtbG1lUW9nSUNBZ2NHOXdDaUFnSUNBdkx5QnNZWEpuWlY5aWIzaGZiM0JsY21GMGFXOXVjeTl6ZEhKMVkzUmZiWFZzZEdsd2JHVmZZWEp5WVhsZmRXbHVkRFkwTG5CNU9qTTJDaUFnSUNBdkx5QkFjSFZpYkdsakNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRGOWpZWE5sY3k1c1lYSm5aVjlpYjNoZmIzQmxjbUYwYVc5dWN5NXpkSEoxWTNSZmJYVnNkR2x3YkdWZllYSnlZWGxmZFdsdWREWTBMbE4wY25WamRFMTFiSFJwY0d4bFFYSnlZWGxWU1c1ME5qUXVZWEJ3Wlc1a1czSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZWEJ3Wlc1a09nb2dJQ0FnTHk4Z2JHRnlaMlZmWW05NFgyOXdaWEpoZEdsdmJuTXZjM1J5ZFdOMFgyMTFiSFJwY0d4bFgyRnljbUY1WDNWcGJuUTJOQzV3ZVRvME9Rb2dJQ0FnTHk4Z1FIQjFZbXhwWXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2JHRnlaMlZmWW05NFgyOXdaWEpoZEdsdmJuTXZjM1J5ZFdOMFgyMTFiSFJwY0d4bFgyRnljbUY1WDNWcGJuUTJOQzV3ZVRvMU1Rb2dJQ0FnTHk4Z2MyVnNaaTVpYjNndWRtRnNkV1V1WVhKeU1TNWhjSEJsYm1Rb2RtRnNkV1VwQ2lBZ0lDQmtkWEFLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUp2ZUNJS0lDQWdJSEIxYzJocGJuUWdNVEFLSUNBZ0lHbHVkR05mTVNBdkx5QTRDaUFnSUNCallXeHNjM1ZpSUdKdmVGOTFjR1JoZEdWZmIyWm1jMlYwWDJsdVl3b2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVltOTRJZ29nSUNBZ2FXNTBZMTh6SUM4dklERXlDaUFnSUNCcGJuUmpYekVnTHk4Z09Bb2dJQ0FnWTJGc2JITjFZaUJpYjNoZmRYQmtZWFJsWDI5bVpuTmxkRjlwYm1NS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1KdmVDSUtJQ0FnSUhCMWMyaHBiblFnTWpJS0lDQWdJR2x1ZEdOZk1TQXZMeUE0Q2lBZ0lDQmpZV3hzYzNWaUlHSnZlRjkxY0dSaGRHVmZiMlptYzJWMFgybHVZd29nSUNBZ1lubDBaV05mTUNBdkx5QWlZbTk0SWdvZ0lDQWdjSFZ6YUdsdWRDQXlOQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdhVzUwWTE4eElDOHZJRGdLSUNBZ0lHTmhiR3h6ZFdJZ1ltOTRYMlI1Ym1GdGFXTmZZWEp5WVhsZlkyOXVZMkYwWDJacGVHVmtDaUFnSUNBdkx5QnNZWEpuWlY5aWIzaGZiM0JsY21GMGFXOXVjeTl6ZEhKMVkzUmZiWFZzZEdsd2JHVmZZWEp5WVhsZmRXbHVkRFkwTG5CNU9qVXlDaUFnSUNBdkx5QnpaV3htTG1KdmVDNTJZV3gxWlM1aGNuSXlMbUZ3Y0dWdVpDaDJZV3gxWlNBcklERXBDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0FyQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0ppYjNnaUNpQWdJQ0J3ZFhOb2FXNTBJREV3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNZ29nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUdKMGIya0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltSnZlQ0lLSUNBZ0lHbHVkR05mTXlBdkx5QXhNZ29nSUNBZ2FXNTBZMTh4SUM4dklEZ0tJQ0FnSUdOaGJHeHpkV0lnWW05NFgzVndaR0YwWlY5dlptWnpaWFJmYVc1akNpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKaWIzZ2lDaUFnSUNCd2RYTm9hVzUwSURJeUNpQWdJQ0JwYm5Salh6RWdMeThnT0FvZ0lDQWdZMkZzYkhOMVlpQmliM2hmZFhCa1lYUmxYMjltWm5ObGRGOXBibU1LSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUp2ZUNJS0lDQWdJSE4zWVhBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUdsdWRHTmZNU0F2THlBNENpQWdJQ0JqWVd4c2MzVmlJR0p2ZUY5a2VXNWhiV2xqWDJGeWNtRjVYMk52Ym1OaGRGOW1hWGhsWkFvZ0lDQWdMeThnYkdGeVoyVmZZbTk0WDI5d1pYSmhkR2x2Ym5NdmMzUnlkV04wWDIxMWJIUnBjR3hsWDJGeWNtRjVYM1ZwYm5RMk5DNXdlVG8xTXdvZ0lDQWdMeThnYzJWc1ppNWliM2d1ZG1Gc2RXVXVZWEp5TXk1aGNIQmxibVFvZG1Gc2RXVWdLeUF5S1FvZ0lDQWdhVzUwWTE4d0lDOHZJRElLSUNBZ0lDc0tJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltSnZlQ0lLSUNBZ0lHbHVkR05mTXlBdkx5QXhNZ29nSUNBZ2FXNTBZMTh3SUM4dklESUtJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0JpZEc5cENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKaWIzZ2lDaUFnSUNCd2RYTm9hVzUwSURJeUNpQWdJQ0JwYm5Salh6RWdMeThnT0FvZ0lDQWdZMkZzYkhOMVlpQmliM2hmZFhCa1lYUmxYMjltWm5ObGRGOXBibU1LSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUp2ZUNJS0lDQWdJSE4zWVhBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUdsdWRHTmZNU0F2THlBNENpQWdJQ0JqWVd4c2MzVmlJR0p2ZUY5a2VXNWhiV2xqWDJGeWNtRjVYMk52Ym1OaGRGOW1hWGhsWkFvZ0lDQWdMeThnYkdGeVoyVmZZbTk0WDI5d1pYSmhkR2x2Ym5NdmMzUnlkV04wWDIxMWJIUnBjR3hsWDJGeWNtRjVYM1ZwYm5RMk5DNXdlVG8wT1FvZ0lDQWdMeThnUUhCMVlteHBZd29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1JmWTJGelpYTXViR0Z5WjJWZlltOTRYMjl3WlhKaGRHbHZibk11YzNSeWRXTjBYMjExYkhScGNHeGxYMkZ5Y21GNVgzVnBiblEyTkM1VGRISjFZM1JOZFd4MGFYQnNaVUZ5Y21GNVZVbHVkRFkwTG1OdmJtTmhkRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21OdmJtTmhkRG9LSUNBZ0lDOHZJR3hoY21kbFgySnZlRjl2Y0dWeVlYUnBiMjV6TDNOMGNuVmpkRjl0ZFd4MGFYQnNaVjloY25KaGVWOTFhVzUwTmpRdWNIazZOVFVLSUNBZ0lDOHZJRUJ3ZFdKc2FXTUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0F3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNU0F2THlBNENpQWdJQ0FxQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ013b2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4ZFdsdWREWTBQZ29nSUNBZ0x5OGdiR0Z5WjJWZlltOTRYMjl3WlhKaGRHbHZibk12YzNSeWRXTjBYMjExYkhScGNHeGxYMkZ5Y21GNVgzVnBiblEyTkM1d2VUbzFOd29nSUNBZ0x5OGdjMlZzWmk1aWIzZ3VkbUZzZFdVdVlYSnlNUzVsZUhSbGJtUW9ZWEp5WVhrcENpQWdJQ0JrYVdjZ01nb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1KdmVDSUtJQ0FnSUhCMWMyaHBiblFnTVRBS0lDQWdJR1JwWnlBekNpQWdJQ0JqWVd4c2MzVmlJR0p2ZUY5MWNHUmhkR1ZmYjJabWMyVjBYMmx1WXdvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWW05NElnb2dJQ0FnYVc1MFkxOHpJQzh2SURFeUNpQWdJQ0JrYVdjZ013b2dJQ0FnWTJGc2JITjFZaUJpYjNoZmRYQmtZWFJsWDI5bVpuTmxkRjlwYm1NS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1KdmVDSUtJQ0FnSUhCMWMyaHBiblFnTWpJS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1kyRnNiSE4xWWlCaWIzaGZkWEJrWVhSbFgyOW1abk5sZEY5cGJtTUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltSnZlQ0lLSUNBZ0lIQjFjMmhwYm5RZ01qUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCcGJuUmpYekVnTHk4Z09Bb2dJQ0FnWTJGc2JITjFZaUJpYjNoZlpIbHVZVzFwWTE5aGNuSmhlVjlqYjI1allYUmZabWw0WldRS0lDQWdJQzh2SUd4aGNtZGxYMkp2ZUY5dmNHVnlZWFJwYjI1ekwzTjBjblZqZEY5dGRXeDBhWEJzWlY5aGNuSmhlVjkxYVc1ME5qUXVjSGs2TlRnS0lDQWdJQzh2SUhObGJHWXVZbTk0TG5aaGJIVmxMbUZ5Y2pJdVpYaDBaVzVrS0dsdVkxOWhjbkpoZVNoaGNuSmhlU3dnVlVsdWREWTBLREVwS1NrS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQmpZV3hzYzNWaUlHbHVZMTloY25KaGVRb2dJQ0FnWkdsbklERUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lIQjFjMmhwYm5RZ01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdPQW9nSUNBZ0tnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVltOTRJZ29nSUNBZ2NIVnphR2x1ZENBeE1Bb2dJQ0FnYVc1MFkxOHdJQzh2SURJS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQmlkRzlwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0ppYjNnaUNpQWdJQ0JwYm5Salh6TWdMeThnTVRJS0lDQWdJR1JwWnlBekNpQWdJQ0JqWVd4c2MzVmlJR0p2ZUY5MWNHUmhkR1ZmYjJabWMyVjBYMmx1WXdvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWW05NElnb2dJQ0FnY0hWemFHbHVkQ0F5TWdvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCallXeHNjM1ZpSUdKdmVGOTFjR1JoZEdWZmIyWm1jMlYwWDJsdVl3b2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVltOTRJZ29nSUNBZ2MzZGhjQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHbHVkR05mTVNBdkx5QTRDaUFnSUNCallXeHNjM1ZpSUdKdmVGOWtlVzVoYldsalgyRnljbUY1WDJOdmJtTmhkRjltYVhobFpBb2dJQ0FnTHk4Z2JHRnlaMlZmWW05NFgyOXdaWEpoZEdsdmJuTXZjM1J5ZFdOMFgyMTFiSFJwY0d4bFgyRnljbUY1WDNWcGJuUTJOQzV3ZVRvMU9Rb2dJQ0FnTHk4Z2MyVnNaaTVpYjNndWRtRnNkV1V1WVhKeU15NWxlSFJsYm1Rb2FXNWpYMkZ5Y21GNUtHRnljbUY1TENCVlNXNTBOalFvTWlrcEtRb2dJQ0FnYVc1MFkxOHdJQzh2SURJS0lDQWdJR05oYkd4emRXSWdhVzVqWDJGeWNtRjVDaUFnSUNCd2IzQUtJQ0FnSUdSMWNBb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJSE4zWVhBS0lDQWdJSEIxYzJocGJuUWdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6RWdMeThnT0FvZ0lDQWdLZ29nSUNBZ1lubDBaV05mTUNBdkx5QWlZbTk0SWdvZ0lDQWdhVzUwWTE4eklDOHZJREV5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNZ29nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUdKMGIya0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltSnZlQ0lLSUNBZ0lIQjFjMmhwYm5RZ01qSUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZMkZzYkhOMVlpQmliM2hmZFhCa1lYUmxYMjltWm5ObGRGOXBibU1LSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUp2ZUNJS0lDQWdJSE4zWVhBS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JwYm5Salh6RWdMeThnT0FvZ0lDQWdZMkZzYkhOMVlpQmliM2hmWkhsdVlXMXBZMTloY25KaGVWOWpiMjVqWVhSZlptbDRaV1FLSUNBZ0lDOHZJR3hoY21kbFgySnZlRjl2Y0dWeVlYUnBiMjV6TDNOMGNuVmpkRjl0ZFd4MGFYQnNaVjloY25KaGVWOTFhVzUwTmpRdWNIazZOVFVLSUNBZ0lDOHZJRUJ3ZFdKc2FXTUtJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBYMk5oYzJWekxteGhjbWRsWDJKdmVGOXZjR1Z5WVhScGIyNXpMbk4wY25WamRGOXRkV3gwYVhCc1pWOWhjbkpoZVY5MWFXNTBOalF1VTNSeWRXTjBUWFZzZEdsd2JHVkJjbkpoZVZWSmJuUTJOQzV3YjNCYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHdiM0E2Q2lBZ0lDQXZMeUJzWVhKblpWOWliM2hmYjNCbGNtRjBhVzl1Y3k5emRISjFZM1JmYlhWc2RHbHdiR1ZmWVhKeVlYbGZkV2x1ZERZMExuQjVPall6Q2lBZ0lDQXZMeUJ5WlhOMWJIUWdQU0J6Wld4bUxtSnZlQzUyWVd4MVpTNWhjbkl4TG5CdmNDZ3BDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmliM2dpQ2lBZ0lDQndkWE5vYVc1MElESTBDaUFnSUNCcGJuUmpYekFnTHk4Z01nb2dJQ0FnWW05NFgyVjRkSEpoWTNRS0lDQWdJR0owYjJrS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lDMGdMeThnYjI0Z1pYSnliM0k2SUdOaGJtNXZkQ0J3YjNBZ1puSnZiU0JsYlhCMGVTQmhjbkpoZVFvZ0lDQWdaSFZ3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUR3S0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm1SbGVDQnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQnBiblJqWHpFZ0x5OGdPQW9nSUNBZ0tnb2dJQ0FnY0hWemFHbHVkQ0F5TmdvZ0lDQWdLd29nSUNBZ1lubDBaV05mTUNBdkx5QWlZbTk0SWdvZ0lDQWdjM2RoY0FvZ0lDQWdhVzUwWTE4eElDOHZJRGdLSUNBZ0lHSnZlRjlsZUhSeVlXTjBJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0J2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0JrZFhBS0lDQWdJR0owYjJrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1KdmVDSUtJQ0FnSUhCMWMyaHBiblFnTVRBS0lDQWdJR2x1ZEdOZk1TQXZMeUE0Q2lBZ0lDQmpZV3hzYzNWaUlHSnZlRjkxY0dSaGRHVmZiMlptYzJWMFgyUmxZd29nSUNBZ1lubDBaV05mTUNBdkx5QWlZbTk0SWdvZ0lDQWdhVzUwWTE4eklDOHZJREV5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdPQW9nSUNBZ1kyRnNiSE4xWWlCaWIzaGZkWEJrWVhSbFgyOW1abk5sZEY5a1pXTUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltSnZlQ0lLSUNBZ0lIQjFjMmhwYm5RZ01qSUtJQ0FnSUdsdWRHTmZNU0F2THlBNENpQWdJQ0JqWVd4c2MzVmlJR0p2ZUY5MWNHUmhkR1ZmYjJabWMyVjBYMlJsWXdvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWW05NElnb2dJQ0FnY0hWemFHbHVkQ0F5TkFvZ0lDQWdhVzUwWTE4eElDOHZJRGdLSUNBZ0lHTmhiR3h6ZFdJZ1ltOTRYMlI1Ym1GdGFXTmZZWEp5WVhsZmNHOXdYMlpwZUdWa1gzTnBlbVVLSUNBZ0lDOHZJR3hoY21kbFgySnZlRjl2Y0dWeVlYUnBiMjV6TDNOMGNuVmpkRjl0ZFd4MGFYQnNaVjloY25KaGVWOTFhVzUwTmpRdWNIazZOalFLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpaV3htTG1KdmVDNTJZV3gxWlM1aGNuSXlMbkJ2Y0NncElEMDlJSEpsYzNWc2RDQXJJREVLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUp2ZUNJS0lDQWdJSEIxYzJocGJuUWdNVEFLSUNBZ0lHbHVkR05mTUNBdkx5QXlDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnWW5SdmFRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVltOTRJZ29nSUNBZ1pHbG5JREVLSUNBZ0lHbHVkR05mTUNBdkx5QXlDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnWW5SdmFRb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdMU0F2THlCdmJpQmxjbkp2Y2pvZ1kyRnVibTkwSUhCdmNDQm1jbTl0SUdWdGNIUjVJR0Z5Y21GNUNpQWdJQ0JrZFhBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1BBb2dJQ0FnWVhOelpYSjBJQzh2SUdsdVpHVjRJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5Salh6QWdMeThnTWdvZ0lDQWdLd29nSUNBZ2MzZGhjQW9nSUNBZ2FXNTBZMTh4SUM4dklEZ0tJQ0FnSUNvS0lDQWdJQ3NLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUp2ZUNJS0lDQWdJSE4zWVhBS0lDQWdJR2x1ZEdOZk1TQXZMeUE0Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQ0F2THlCdmJpQmxjbkp2Y2pvZ2FXNWtaWGdnYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnWW5SdmFRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVltOTRJZ29nSUNBZ2FXNTBZMTh6SUM4dklERXlDaUFnSUNCcGJuUmpYekVnTHk4Z09Bb2dJQ0FnWTJGc2JITjFZaUJpYjNoZmRYQmtZWFJsWDI5bVpuTmxkRjlrWldNS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1KdmVDSUtJQ0FnSUhCMWMyaHBiblFnTWpJS0lDQWdJR2x1ZEdOZk1TQXZMeUE0Q2lBZ0lDQmpZV3hzYzNWaUlHSnZlRjkxY0dSaGRHVmZiMlptYzJWMFgyUmxZd29nSUNBZ1lubDBaV05mTUNBdkx5QWlZbTk0SWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCcGJuUmpYekVnTHk4Z09Bb2dJQ0FnWTJGc2JITjFZaUJpYjNoZlpIbHVZVzFwWTE5aGNuSmhlVjl3YjNCZlptbDRaV1JmYzJsNlpRb2dJQ0FnWkdsbklERUtJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0FyQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUJzWVhKblpWOWliM2hmYjNCbGNtRjBhVzl1Y3k5emRISjFZM1JmYlhWc2RHbHdiR1ZmWVhKeVlYbGZkV2x1ZERZMExuQjVPalkxQ2lBZ0lDQXZMeUJoYzNObGNuUWdjMlZzWmk1aWIzZ3VkbUZzZFdVdVlYSnlNeTV3YjNBb0tTQTlQU0J5WlhOMWJIUWdLeUF5Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0ppYjNnaUNpQWdJQ0JwYm5Salh6TWdMeThnTVRJS0lDQWdJR2x1ZEdOZk1DQXZMeUF5Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQW9nSUNBZ1luUnZhUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZbTk0SWdvZ0lDQWdaR2xuSURFS0lDQWdJR2x1ZEdOZk1DQXZMeUF5Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQW9nSUNBZ1luUnZhUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnTFNBdkx5QnZiaUJsY25KdmNqb2dZMkZ1Ym05MElIQnZjQ0JtY205dElHVnRjSFI1SUdGeWNtRjVDaUFnSUNCa2RYQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdQQW9nSUNBZ1lYTnpaWEowSUM4dklHbHVaR1Y0SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUdScFp5QXhDaUFnSUNCcGJuUmpYekFnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdjM2RoY0FvZ0lDQWdhVzUwWTE4eElDOHZJRGdLSUNBZ0lDb0tJQ0FnSUNzS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1KdmVDSUtJQ0FnSUhOM1lYQUtJQ0FnSUdsdWRHTmZNU0F2THlBNENpQWdJQ0JpYjNoZlpYaDBjbUZqZENBdkx5QnZiaUJsY25KdmNqb2dhVzVrWlhnZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ1luUnZhUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZbTk0SWdvZ0lDQWdjSFZ6YUdsdWRDQXlNZ29nSUNBZ2FXNTBZMTh4SUM4dklEZ0tJQ0FnSUdOaGJHeHpkV0lnWW05NFgzVndaR0YwWlY5dlptWnpaWFJmWkdWakNpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKaWIzZ2lDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR2x1ZEdOZk1TQXZMeUE0Q2lBZ0lDQmpZV3hzYzNWaUlHSnZlRjlrZVc1aGJXbGpYMkZ5Y21GNVgzQnZjRjltYVhobFpGOXphWHBsQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z2JHRnlaMlZmWW05NFgyOXdaWEpoZEdsdmJuTXZjM1J5ZFdOMFgyMTFiSFJwY0d4bFgyRnljbUY1WDNWcGJuUTJOQzV3ZVRvMk1Rb2dJQ0FnTHk4Z1FIQjFZbXhwWXdvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSZlkyRnpaWE11YkdGeVoyVmZZbTk0WDI5d1pYSmhkR2x2Ym5NdWMzUnlkV04wWDIxMWJIUnBjR3hsWDJGeWNtRjVYM1ZwYm5RMk5DNVRkSEoxWTNSTmRXeDBhWEJzWlVGeWNtRjVWVWx1ZERZMExtZGxkRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21kbGREb0tJQ0FnSUM4dklHeGhjbWRsWDJKdmVGOXZjR1Z5WVhScGIyNXpMM04wY25WamRGOXRkV3gwYVhCc1pWOWhjbkpoZVY5MWFXNTBOalF1Y0hrNk5qZ0tJQ0FnSUM4dklFQndkV0pzYVdNS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklHeGhjbWRsWDJKdmVGOXZjR1Z5WVhScGIyNXpMM04wY25WamRGOXRkV3gwYVhCc1pWOWhjbkpoZVY5MWFXNTBOalF1Y0hrNk56QUtJQ0FnSUM4dklISmxjM1ZzZENBOUlITmxiR1l1WW05NExuWmhiSFZsTG1GeWNqRmJhV1I0WFFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWW05NElnb2dJQ0FnY0hWemFHbHVkQ0F5TkFvZ0lDQWdhVzUwWTE4d0lDOHZJRElLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNCaWRHOXBDaUFnSUNCa2FXY2dNUW9nSUNBZ1Bnb2dJQ0FnWVhOelpYSjBJQzh2SUdsdVpHVjRJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eElDOHZJRGdLSUNBZ0lDb0tJQ0FnSUhCMWMyaHBiblFnTWpZS0lDQWdJR1JwWnlBeENpQWdJQ0FyQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0ppYjNnaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JwYm5Salh6RWdMeThnT0FvZ0lDQWdZbTk0WDJWNGRISmhZM1FnTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUdSMWNBb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2JHRnlaMlZmWW05NFgyOXdaWEpoZEdsdmJuTXZjM1J5ZFdOMFgyMTFiSFJwY0d4bFgyRnljbUY1WDNWcGJuUTJOQzV3ZVRvM01Rb2dJQ0FnTHk4Z1lYTnpaWEowSUhObGJHWXVZbTk0TG5aaGJIVmxMbUZ5Y2pKYmFXUjRYU0E5UFNCeVpYTjFiSFFnS3lBeENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKaWIzZ2lDaUFnSUNCd2RYTm9hVzUwSURFd0NpQWdJQ0JwYm5Salh6QWdMeThnTWdvZ0lDQWdZbTk0WDJWNGRISmhZM1FLSUNBZ0lHSjBiMmtLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUp2ZUNJS0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5Salh6QWdMeThnTWdvZ0lDQWdZbTk0WDJWNGRISmhZM1FLSUNBZ0lHSjBiMmtLSUNBZ0lHUnBaeUExQ2lBZ0lDQStDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNWtaWGdnYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnYVc1MFkxOHdJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF6Q2lBZ0lDQXJDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmliM2dpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdPQW9nSUNBZ1ltOTRYMlY0ZEhKaFkzUWdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJR0owYjJrS0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdLd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdiR0Z5WjJWZlltOTRYMjl3WlhKaGRHbHZibk12YzNSeWRXTjBYMjExYkhScGNHeGxYMkZ5Y21GNVgzVnBiblEyTkM1d2VUbzNNZ29nSUNBZ0x5OGdZWE56WlhKMElITmxiR1l1WW05NExuWmhiSFZsTG1GeWNqTmJhV1I0WFNBOVBTQnlaWE4xYkhRZ0t5QXlDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmliM2dpQ2lBZ0lDQnBiblJqWHpNZ0x5OGdNVElLSUNBZ0lHbHVkR05mTUNBdkx5QXlDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnWW5SdmFRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVltOTRJZ29nSUNBZ1pHbG5JREVLSUNBZ0lHbHVkR05mTUNBdkx5QXlDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnWW5SdmFRb2dJQ0FnZFc1amIzWmxjaUExQ2lBZ0lDQStDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNWtaWGdnYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnYVc1MFkxOHdJQzh2SURJS0lDQWdJQ3NLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnS3dvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWW05NElnb2dJQ0FnYzNkaGNBb2dJQ0FnYVc1MFkxOHhJQzh2SURnS0lDQWdJR0p2ZUY5bGVIUnlZV04wSUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCaWRHOXBDaUFnSUNCemQyRndDaUFnSUNCcGJuUmpYekFnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnYkdGeVoyVmZZbTk0WDI5d1pYSmhkR2x2Ym5NdmMzUnlkV04wWDIxMWJIUnBjR3hsWDJGeWNtRjVYM1ZwYm5RMk5DNXdlVG8yT0FvZ0lDQWdMeThnUUhCMVlteHBZd29nSUNBZ1lubDBaV05mTVNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1JmWTJGelpYTXViR0Z5WjJWZlltOTRYMjl3WlhKaGRHbHZibk11YzNSeWRXTjBYMjExYkhScGNHeGxYMkZ5Y21GNVgzVnBiblEyTkM1VGRISjFZM1JOZFd4MGFYQnNaVUZ5Y21GNVZVbHVkRFkwTG5ObGRGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbk5sZERvS0lDQWdJQzh2SUd4aGNtZGxYMkp2ZUY5dmNHVnlZWFJwYjI1ekwzTjBjblZqZEY5dGRXeDBhWEJzWlY5aGNuSmhlVjkxYVc1ME5qUXVjSGs2TnpVS0lDQWdJQzh2SUVCd2RXSnNhV01LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdSMWNBb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2JHRnlaMlZmWW05NFgyOXdaWEpoZEdsdmJuTXZjM1J5ZFdOMFgyMTFiSFJwY0d4bFgyRnljbUY1WDNWcGJuUTJOQzV3ZVRvM053b2dJQ0FnTHk4Z2MyVnNaaTVpYjNndWRtRnNkV1V1WVhKeU1WdHBaSGhkSUQwZ2RtRnNkV1VLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUp2ZUNJS0lDQWdJSEIxYzJocGJuUWdNalFLSUNBZ0lHbHVkR05mTUNBdkx5QXlDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnWW5SdmFRb2dJQ0FnWkdsbklETUtJQ0FnSUQ0S0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm1SbGVDQnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQmthV2NnTWdvZ0lDQWdhVzUwWTE4eElDOHZJRGdLSUNBZ0lDb0tJQ0FnSUhCMWMyaHBiblFnTWpZS0lDQWdJR1JwWnlBeENpQWdJQ0FyQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0ppYjNnaUNpQWdJQ0J6ZDJGd0NpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHSnZlRjl5WlhCc1lXTmxJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0J2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0F2THlCc1lYSm5aVjlpYjNoZmIzQmxjbUYwYVc5dWN5OXpkSEoxWTNSZmJYVnNkR2x3YkdWZllYSnlZWGxmZFdsdWREWTBMbkI1T2pjNENpQWdJQ0F2THlCelpXeG1MbUp2ZUM1MllXeDFaUzVoY25JeVcybGtlRjBnUFNCMllXeDFaU0FySURFS0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdLd29nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTUNBdkx5QWlZbTk0SWdvZ0lDQWdjSFZ6YUdsdWRDQXhNQW9nSUNBZ2FXNTBZMTh3SUM4dklESUtJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0JpZEc5cENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKaWIzZ2lDaUFnSUNCa2FXY2dNUW9nSUNBZ2FXNTBZMTh3SUM4dklESUtJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0JpZEc5cENpQWdJQ0JrYVdjZ05Rb2dJQ0FnUGdvZ0lDQWdZWE56WlhKMElDOHZJR2x1WkdWNElHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lHbHVkR05mTUNBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01nb2dJQ0FnS3dvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWW05NElnb2dJQ0FnYzNkaGNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmliM2hmY21Wd2JHRmpaU0F2THlCdmJpQmxjbkp2Y2pvZ2FXNWtaWGdnYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnTHk4Z2JHRnlaMlZmWW05NFgyOXdaWEpoZEdsdmJuTXZjM1J5ZFdOMFgyMTFiSFJwY0d4bFgyRnljbUY1WDNWcGJuUTJOQzV3ZVRvM09Rb2dJQ0FnTHk4Z2MyVnNaaTVpYjNndWRtRnNkV1V1WVhKeU0xdHBaSGhkSUQwZ2RtRnNkV1VnS3lBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JwYm5Salh6QWdMeThnTWdvZ0lDQWdLd29nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTUNBdkx5QWlZbTk0SWdvZ0lDQWdhVzUwWTE4eklDOHZJREV5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNZ29nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUdKMGIya0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltSnZlQ0lLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNZ29nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUdKMGIya0tJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdQZ29nSUNBZ1lYTnpaWEowSUM4dklHbHVaR1Y0SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUdsdWRHTmZNQ0F2THlBeUNpQWdJQ0FyQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUNzS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1KdmVDSUtJQ0FnSUhOM1lYQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZbTk0WDNKbGNHeGhZMlVnTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUM4dklHeGhjbWRsWDJKdmVGOXZjR1Z5WVhScGIyNXpMM04wY25WamRGOXRkV3gwYVhCc1pWOWhjbkpoZVY5MWFXNTBOalF1Y0hrNk56VUtJQ0FnSUM4dklFQndkV0pzYVdNS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMFgyTmhjMlZ6TG14aGNtZGxYMkp2ZUY5dmNHVnlZWFJwYjI1ekxuTjBjblZqZEY5dGRXeDBhWEJzWlY5aGNuSmhlVjkxYVc1ME5qUXVVM1J5ZFdOMFRYVnNkR2x3YkdWQmNuSmhlVlZKYm5RMk5DNTJaWEpwWm5sYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDJaWEpwWm5rNkNpQWdJQ0F2THlCc1lYSm5aVjlpYjNoZmIzQmxjbUYwYVc5dWN5OXpkSEoxWTNSZmJYVnNkR2x3YkdWZllYSnlZWGxmZFdsdWREWTBMbkI1T2pneENpQWdJQ0F2THlCQWNIVmliR2xqQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eElDOHZJRGdLSUNBZ0lDb0tJQ0FnSUdsdWRHTmZNQ0F2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhkV2x1ZERZMFBnb2dJQ0FnWTJGc2JITjFZaUIwWlhOMFgyTmhjMlZ6TG14aGNtZGxYMkp2ZUY5dmNHVnlZWFJwYjI1ekxuTjBjblZqZEY5dGRXeDBhWEJzWlY5aGNuSmhlVjkxYVc1ME5qUXVVM1J5ZFdOMFRYVnNkR2x3YkdWQmNuSmhlVlZKYm5RMk5DNTJaWEpwWm5rS0lDQWdJSEJ2Y0FvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSZlkyRnpaWE11YkdGeVoyVmZZbTk0WDI5d1pYSmhkR2x2Ym5NdWMzUnlkV04wWDIxMWJIUnBjR3hsWDJGeWNtRjVYM1ZwYm5RMk5DNVRkSEoxWTNSTmRXeDBhWEJzWlVGeWNtRjVWVWx1ZERZMExuWmxjbWxtZVNobGVIQmxZM1JsWkRvZ1lubDBaWE1wSUMwK0lHSjVkR1Z6T2dwMFpYTjBYMk5oYzJWekxteGhjbWRsWDJKdmVGOXZjR1Z5WVhScGIyNXpMbk4wY25WamRGOXRkV3gwYVhCc1pWOWhjbkpoZVY5MWFXNTBOalF1VTNSeWRXTjBUWFZzZEdsd2JHVkJjbkpoZVZWSmJuUTJOQzUyWlhKcFpuazZDaUFnSUNBdkx5QnNZWEpuWlY5aWIzaGZiM0JsY21GMGFXOXVjeTl6ZEhKMVkzUmZiWFZzZEdsd2JHVmZZWEp5WVhsZmRXbHVkRFkwTG5CNU9qZ3hMVGd5Q2lBZ0lDQXZMeUJBY0hWaWJHbGpDaUFnSUNBdkx5QmtaV1lnZG1WeWFXWjVLSE5sYkdZc0lHVjRjR1ZqZEdWa09pQkJjbkpoZVZVMk5Da2dMVDRnVG05dVpUb0tJQ0FnSUhCeWIzUnZJREVnTVFvS2RHVnpkRjlqWVhObGN5NXNZWEpuWlY5aWIzaGZiM0JsY21GMGFXOXVjeTV6ZEhKMVkzUmZiWFZzZEdsd2JHVmZZWEp5WVhsZmRXbHVkRFkwTGxOMGNuVmpkRTExYkhScGNHeGxRWEp5WVhsVlNXNTBOalF1ZG1WeWFXWjVYM2RvYVd4bFgzUnZjRUEyT2dvZ0lDQWdjSFZ6YUdsdWRDQXlNREV3Q2lBZ0lDQm5iRzlpWVd3Z1QzQmpiMlJsUW5Wa1oyVjBDaUFnSUNBK0NpQWdJQ0JpZWlCMFpYTjBYMk5oYzJWekxteGhjbWRsWDJKdmVGOXZjR1Z5WVhScGIyNXpMbk4wY25WamRGOXRkV3gwYVhCc1pWOWhjbkpoZVY5MWFXNTBOalF1VTNSeWRXTjBUWFZzZEdsd2JHVkJjbkpoZVZWSmJuUTJOQzUyWlhKcFpubGZZV1owWlhKZmQyaHBiR1ZBTVRFS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lIQjFjMmhwYm5RZ05pQXZMeUJoY0hCc0NpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQndkWE5vYVc1MElEVWdMeThnUkdWc1pYUmxRWEJ3YkdsallYUnBiMjRLSUNBZ0lHbDBlRzVmWm1sbGJHUWdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TURZNE1UQXhDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjSEp2ZG1Gc1VISnZaM0poYlFvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURBMk9ERXdNUW9nSUNBZ2FYUjRibDltYVdWc1pDQkRiR1ZoY2xOMFlYUmxVSEp2WjNKaGJRb2dJQ0FnY0hWemFHbHVkQ0F3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lHSWdkR1Z6ZEY5allYTmxjeTVzWVhKblpWOWliM2hmYjNCbGNtRjBhVzl1Y3k1emRISjFZM1JmYlhWc2RHbHdiR1ZmWVhKeVlYbGZkV2x1ZERZMExsTjBjblZqZEUxMWJIUnBjR3hsUVhKeVlYbFZTVzUwTmpRdWRtVnlhV1o1WDNkb2FXeGxYM1J2Y0VBMkNncDBaWE4wWDJOaGMyVnpMbXhoY21kbFgySnZlRjl2Y0dWeVlYUnBiMjV6TG5OMGNuVmpkRjl0ZFd4MGFYQnNaVjloY25KaGVWOTFhVzUwTmpRdVUzUnlkV04wVFhWc2RHbHdiR1ZCY25KaGVWVkpiblEyTkM1MlpYSnBabmxmWVdaMFpYSmZkMmhwYkdWQU1URTZDaUFnSUNBdkx5QnNZWEpuWlY5aWIzaGZiM0JsY21GMGFXOXVjeTl6ZEhKMVkzUmZiWFZzZEdsd2JHVmZZWEp5WVhsZmRXbHVkRFkwTG5CNU9qZzBDaUFnSUNBdkx5QmhjM05sY25RZ2MyVnNaaTVpYjNndWRtRnNkV1V1WVhKeU1TQTlQU0JsZUhCbFkzUmxaQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZbTk0SWdvZ0lDQWdjSFZ6YUdsdWRDQXlOQW9nSUNBZ2FXNTBZMTh3SUM4dklESUtJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0JpZEc5cENpQWdJQ0JwYm5Salh6RWdMeThnT0FvZ0lDQWdLZ29nSUNBZ2FXNTBZMTh3SUM4dklESUtJQ0FnSUNzS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1KdmVDSUtJQ0FnSUhCMWMyaHBiblFnTWpRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z2JHRnlaMlZmWW05NFgyOXdaWEpoZEdsdmJuTXZjM1J5ZFdOMFgyMTFiSFJwY0d4bFgyRnljbUY1WDNWcGJuUTJOQzV3ZVRvNE5Rb2dJQ0FnTHk4Z1lYTnpaWEowSUhObGJHWXVZbTk0TG5aaGJIVmxMbUZ5Y2pJZ1BUMGdhVzVqWDJGeWNtRjVLR1Y0Y0dWamRHVmtMQ0JWU1c1ME5qUW9NU2twQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0ppYjNnaUNpQWdJQ0J3ZFhOb2FXNTBJREV3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNZ29nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUdKMGIya0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltSnZlQ0lLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNZ29nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUdKMGIya0tJQ0FnSUdsdWRHTmZNU0F2THlBNENpQWdJQ0FxQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVltOTRJZ29nSUNBZ1kyOTJaWElnTWdvZ0lDQWdZbTk0WDJWNGRISmhZM1FLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUdOaGJHeHpkV0lnYVc1algyRnljbUY1Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJQzB4Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUJzWVhKblpWOWliM2hmYjNCbGNtRjBhVzl1Y3k5emRISjFZM1JmYlhWc2RHbHdiR1ZmWVhKeVlYbGZkV2x1ZERZMExuQjVPamcyQ2lBZ0lDQXZMeUJoYzNObGNuUWdjMlZzWmk1aWIzZ3VkbUZzZFdVdVlYSnlNeUE5UFNCcGJtTmZZWEp5WVhrb1pYaHdaV04wWldRc0lGVkpiblEyTkNneUtTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltSnZlQ0lLSUNBZ0lHbHVkR05mTXlBdkx5QXhNZ29nSUNBZ2FXNTBZMTh3SUM4dklESUtJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0JpZEc5cENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKaWIzZ2lDaUFnSUNCa2FXY2dNUW9nSUNBZ2FXNTBZMTh3SUM4dklESUtJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0JpZEc5cENpQWdJQ0JwYm5Salh6RWdMeThnT0FvZ0lDQWdLZ29nSUNBZ2FXNTBZMTh3SUM4dklESUtJQ0FnSUNzS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1KdmVDSUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdsdWRHTmZNQ0F2THlBeUNpQWdJQ0JqWVd4c2MzVmlJR2x1WTE5aGNuSmhlUW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXRNUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdiR0Z5WjJWZlltOTRYMjl3WlhKaGRHbHZibk12YzNSeWRXTjBYMjExYkhScGNHeGxYMkZ5Y21GNVgzVnBiblEyTkM1d2VUbzROd29nSUNBZ0x5OGdZWE56WlhKMElITmxiR1l1WW05NExuWmhiSFZsTG1FZ1BUMGdNUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZbTk0SWdvZ0lDQWdjSFZ6YUdsdWRDQXdDaUFnSUNCcGJuUmpYekVnTHk4Z09Bb2dJQ0FnWW05NFgyVjRkSEpoWTNRZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lHSjBiMmtLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QnNZWEpuWlY5aWIzaGZiM0JsY21GMGFXOXVjeTl6ZEhKMVkzUmZiWFZzZEdsd2JHVmZZWEp5WVhsZmRXbHVkRFkwTG5CNU9qZzRDaUFnSUNBdkx5QmhjM05sY25RZ2MyVnNaaTVpYjNndWRtRnNkV1V1WWlBOVBTQXlDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmliM2dpQ2lBZ0lDQndkWE5vYVc1MElERTBDaUFnSUNCcGJuUmpYekVnTHk4Z09Bb2dJQ0FnWW05NFgyVjRkSEpoWTNRZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lHSjBiMmtLSUNBZ0lHbHVkR05mTUNBdkx5QXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QnNZWEpuWlY5aWIzaGZiM0JsY21GMGFXOXVjeTl6ZEhKMVkzUmZiWFZzZEdsd2JHVmZZWEp5WVhsZmRXbHVkRFkwTG5CNU9qZzVDaUFnSUNBdkx5QmhjM05sY25RZ2MyVnNaaTVpYjNndWRtRnNkV1V1Y0dGa1pHbHVaeTVzWlc1bmRHZ2dQVDBnTVFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWW05NElnb2dJQ0FnY0hWemFHbHVkQ0F5TWdvZ0lDQWdhVzUwWTE4d0lDOHZJRElLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNCaWRHOXBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmliM2dpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNZ29nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUdKMGIya0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCc1lYSm5aVjlpYjNoZmIzQmxjbUYwYVc5dWN5OXpkSEoxWTNSZmJYVnNkR2x3YkdWZllYSnlZWGxmZFdsdWREWTBMbkI1T2prd0NpQWdJQ0F2THlCaGMzTmxjblFnYzJWc1ppNWliM2d1YkdWdVozUm9JRDRnTkRBNU5pd2dJbVY0Y0dWamRHVmtJR0p2ZUNCc1pXNW5kR2dnUGpRd09UWWlDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmliM2dpQ2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0J3YjNBS0lDQWdJR2x1ZEdNZ05DQXZMeUEwTURrMkNpQWdJQ0ErQ2lBZ0lDQmhjM05sY25RZ0x5OGdaWGh3WldOMFpXUWdZbTk0SUd4bGJtZDBhQ0ErTkRBNU5nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0J5WlhSemRXSUsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFGQWdnQkRJQWdKZ01EWW05NEJCVWZmSFVEQm9FQk1SdEJBRUF4R1JSRU1SaEVnZ2NFdnNkdGh3UTBLUC9xQkZsSnpsMEV1Q1doUWdTME5wdzJCTTdSdmNZRU1YbytBellhQUk0SEFONEJJZ0dGQWhjQ3Z3TWtBNDBBTVJrVU1SZ1VFRU9LQXdDTC9ZditJcm9YSkFsSkZsY0dBb3Y5aS81UEFydUwvaUlJVEl2L0N3aUwvVXlMLzRBQTBvdjl2VWlML3dtTC9VelRpWW9GQUl2N2kvd2l1aGVMKzcxSWkvNkwvd3NJaS90TTAwbUwvZ2dXVndZQ2kvdUwvRThDdTR2OElnaE1pLzhMQ0l2N1RJRUFpLzNTaVlvREFJdjlpLzRpdWhlTC93a1dWd1lDaS8yTC9rOEN1NG1LQXdDTC9ZditJcm9YaS84SUZsY0dBb3Y5aS81UEFydUppZ0lDaS82QkFGbUwvb0VBU1VzRERFRUFIRXhKVndJQVN3SWpDMHhMQVZ1TC93Z1dUQ0lJVEYxTUpBaEMvOTFJaS81UEFva292RWdvZ0NBQUFBQUFBQUFBQVFBWUFCb0FIQUFBQUFBQUFBQUNBQjRBQUFBQUFBQUFBTDhoQks4b2dSWWl1aGNvVEU4Q0pDRUVpUDhtZ0FJQUFJZ0NoRWdrUXpZYUFVa1ZJeEpFRjBrV0tJRUtJNGovWENnbEk0ai9WaWlCRmlPSS8wOG9nUmhQQWlRamlQN3pTU1FJRmlpQkNpSzZGeWdsSTRqL05TaUJGaU9JL3k0b1RFOENKQ09JL3RNaUNCWW9KU0s2RnlpQkZpT0kveFlvVEU4Q0pDT0kvcnNrUXpZYUFVbUJBRmxKSXd0SklnaExBeFVTUkVzQ1Z3SUFLSUVLU3dPSS91d29KVXNEaVA3bEtJRVdUd09JL3Qwb2dSaFBBazhESTRqK2dDU0kvdWRMQVZjQ0FFOENnUUJaU1NNTEtJRUtJcm9YS0NWTEE0ait0Q2lCRms4RGlQNnNLRXhQQTA4REk0aitVQ0tJL3JkSVNWY0NBRXlCQUZsSkl3c29KU0s2RnlpQkZrOERpUDZGS0V4UEEwOERJNGorS1NSREtJRVlJcm9YU1NRSlNVOENERVFqQzRFYUNDaE1JN3BKRnlpQkNpT0kva0FvSlNPSS9qb29nUllqaVA0ektJRVlJNGo5dmlpQkNpSzZGeWhMQVNLNkYwa2tDVWxQQWd4RVN3RWlDRXdqQ3dnb1RDTzZGeWdsSTRqK0JTaUJGaU9JL2Y0b1R3SWppUDJKU3dFa0NCSkVLQ1VpdWhjb1N3RWl1aGRKSkFsSlR3SU1SRXNCSWdoTUl3c0lLRXdqdWhjb2dSWWppUDNLS0U4Q0k0ajlWVXdpQ0JKRUtVeFFzQ1JETmhvQlNSVWpFa1FYS0lFWUlyb1hTd0VOUkVrakM0RWFTd0VJS0V3anVra1hLSUVLSXJvWEtFc0JJcm9YU3dVTlJDSUlTd01JS0V3anVoZExBU1FJRWtRb0pTSzZGeWhMQVNLNkYwOEZEVVFpQ0U4RENDaE1JN29YVENJSUVrUXBURkN3SkVNMkdnRkpGU01TUkJjMkdnSkpGU01TUkVrWEtJRVlJcm9YU3dNTlJFc0NJd3VCR2tzQkNDaE1Ud1M3U3dFa0NCWW9nUW9pdWhjb1N3RWl1aGRMQlExRUlnaExBZ2dvVEU4Q3Uwd2lDQllvSlNLNkZ5aExBU0s2RjA4RURVUWlDRThDQ0NoTVR3SzdKRU0yR2dGSmdRQlpJd3NpQ0VzQkZSSkVpQUFEU0NSRGlnRUJnZG9QTWd3TlFRQVhzWUVHc2hDQkJiSVpLckllS3JJZmdRQ3lBYk5DLytBb2dSZ2l1aGNqQ3lJSUtJRVlUd0s2aS84U1JDaUJDaUs2RnloTEFTSzZGeU1MSWdnb1RnSzZpLzhraVB5MWpQOFNSQ2dsSXJvWEtFc0JJcm9YSXdzaUNDaE9BcnFML3lLSS9KaU0veEpFS0lFQUk3b1hKQkpFS0lFT0k3b1hJaEpFS0lFV0lyb1hLRXdpdWhja0VrUW92VWdoQkExRWkvK0oiLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjk5LCJtaW5vciI6OTksInBhdGNoIjo5OSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
