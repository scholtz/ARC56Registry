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

namespace Arc56.Generated.algorandfoundation.puya.StructArrayBoolContract_ff7a806d
{


    //
    // Dynamic arrays of bool are bit packed, so in-place box operations must
    //    work in bits rather than bytes, and only update trailing head offsets by the
    //    number of bytes actually added or removed.
    //
    //    The bool members either side of the array are not packed with each other (the
    //    array's head pointer sits between them), so each occupies its own byte and must
    //    be left undisturbed as the array is resized.
    //
    public class StructArrayBoolContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public StructArrayBoolContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class StructWithArrayBool : AVMObjectType
            {
                public byte[][] Padding { get; set; }

                public bool A { get; set; }

                public bool[] Arr { get; set; }

                public bool B { get; set; }

                public ulong[] Trailing { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPadding = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[4096][]");
                    vPadding.From(Padding);
                    ret.AddRange(vPadding.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vA.From(A);
                    ret.AddRange(vA.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vArr = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool[]");
                    vArr.From(Arr);
                    ret.AddRange(vArr.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vB.From(B);
                    ret.AddRange(vB.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTrailing = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64[]");
                    vTrailing.From(Trailing);
                    ret.AddRange(vTrailing.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static StructWithArrayBool Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new StructWithArrayBool();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPadding = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[4096][]");
                    count = vPadding.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePadding = vPadding.ToValue();
                    if (valuePadding is byte[][] vPaddingValue) { ret.Padding = vPaddingValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vA.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueA = vA.ToValue();
                    if (valueA is bool vAValue) { ret.A = vAValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vArr = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool[]");
                    count = vArr.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueArr = vArr.ToValue();
                    if (valueArr is bool[] vArrValue) { ret.Arr = vArrValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vB.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueB = vB.ToValue();
                    if (valueB is bool vBValue) { ret.B = vBValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTrailing = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64[]");
                    count = vTrailing.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTrailing = vTrailing.ToValue();
                    if (valueTrailing is ulong[] vTrailingValue) { ret.Trailing = vTrailingValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as StructWithArrayBool);
                }
                public bool Equals(StructWithArrayBool? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(StructWithArrayBool left, StructWithArrayBool right)
                {
                    return EqualityComparer<StructWithArrayBool>.Default.Equals(left, right);
                }
                public static bool operator !=(StructWithArrayBool left, StructWithArrayBool right)
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
        public async Task Append(bool value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 59, 68, 100, 182 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Append_Transactions(bool value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 59, 68, 100, 182 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="array"> </param>
        public async Task Concat(bool[] array, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 234, 89, 205, 201 };
            var arrayAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Bool>("bool"); arrayAbi.From(array);

            var result = await base.CallApp(new List<object> { abiHandle, arrayAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Concat_Transactions(bool[] array, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 234, 89, 205, 201 };
            var arrayAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Bool>("bool"); arrayAbi.From(array);

            return await base.MakeTransactionList(new List<object> { abiHandle, arrayAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<bool> Pop(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 202, 106, 200, 170 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Pop_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 202, 106, 200, 170 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="idx"> </param>
        public async Task<bool> Get(ulong idx, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 229, 50, 123, 178 };
            var idxAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); idxAbi.From(idx);

            var result = await base.CallApp(new List<object> { abiHandle, idxAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Get_Transactions(ulong idx, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 229, 50, 123, 178 };
            var idxAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); idxAbi.From(idx);

            return await base.MakeTransactionList(new List<object> { abiHandle, idxAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="idx"> </param>
        /// <param name="value"> </param>
        public async Task Set(ulong idx, bool value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 33, 4, 76, 72 };
            var idxAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); idxAbi.From(idx);
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, idxAbi, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Set_Transactions(ulong idx, bool value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 33, 4, 76, 72 };
            var idxAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); idxAbi.From(idx);
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, idxAbi, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="expected"> </param>
        public async Task Verify(bool[] expected, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 177, 112, 40, 17 };
            var expectedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Bool>("bool"); expectedAbi.From(expected);

            var result = await base.CallApp(new List<object> { abiHandle, expectedAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Verify_Transactions(bool[] expected, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 177, 112, 40, 17 };
            var expectedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Bool>("bool"); expectedAbi.From(expected);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU3RydWN0QXJyYXlCb29sQ29udHJhY3QiLCJkZXNjIjoiRHluYW1pYyBhcnJheXMgb2YgYm9vbCBhcmUgYml0IHBhY2tlZCwgc28gaW4tcGxhY2UgYm94IG9wZXJhdGlvbnMgbXVzdFxuICAgIHdvcmsgaW4gYml0cyByYXRoZXIgdGhhbiBieXRlcywgYW5kIG9ubHkgdXBkYXRlIHRyYWlsaW5nIGhlYWQgb2Zmc2V0cyBieSB0aGVcbiAgICBudW1iZXIgb2YgYnl0ZXMgYWN0dWFsbHkgYWRkZWQgb3IgcmVtb3ZlZC5cblxuICAgIFRoZSBib29sIG1lbWJlcnMgZWl0aGVyIHNpZGUgb2YgdGhlIGFycmF5IGFyZSBub3QgcGFja2VkIHdpdGggZWFjaCBvdGhlciAodGhlXG4gICAgYXJyYXkncyBoZWFkIHBvaW50ZXIgc2l0cyBiZXR3ZWVuIHRoZW0pLCBzbyBlYWNoIG9jY3VwaWVzIGl0cyBvd24gYnl0ZSBhbmQgbXVzdFxuICAgIGJlIGxlZnQgdW5kaXN0dXJiZWQgYXMgdGhlIGFycmF5IGlzIHJlc2l6ZWQuIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IlN0cnVjdFdpdGhBcnJheUJvb2wiOlt7Im5hbWUiOiJwYWRkaW5nIiwidHlwZSI6ImJ5dGVbNDA5Nl1bXSJ9LHsibmFtZSI6ImEiLCJ0eXBlIjoiYm9vbCJ9LHsibmFtZSI6ImFyciIsInR5cGUiOiJib29sW10ifSx7Im5hbWUiOiJiIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJ0cmFpbGluZyIsInR5cGUiOiJ1aW50NjRbXSJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJib290c3RyYXAiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXBwZW5kIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjb25jYXQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYm9vbFtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXJyYXkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicG9wIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpZHgiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImlkeCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InZlcmlmeSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJib29sW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJleHBlY3RlZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzUyMl0sImVycm9yTWVzc2FnZSI6ImNhbm5vdCBwb3AgZnJvbSBlbXB0eSBhcnJheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU1Nyw2ODksNzU4XSwiZXJyb3JNZXNzYWdlIjoiaW5kZXggYWNjZXNzIGlzIG91dCBvZiBib3VuZHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MjcsNTUyLDY2OSw2ODQsNzM3LDc2Niw4MjYsODM1XSwiZXJyb3JNZXNzYWdlIjoiaW5kZXggb3V0IG9mIGJvdW5kcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ2NCw3NzQsODg3XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDI2LDcxOV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmJvb2wiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NzcsNzg2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxib29sPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY1Miw3MTBdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDhdLCJlcnJvck1lc3NhZ2UiOiJtYXggYXJyYXkgbGVuZ3RoIGV4Y2VlZGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODk4XSwiZXJyb3JNZXNzYWdlIjoidW5leHBlY3RlZCBib3ggc2l6ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXlJREVnT0NBd0lEUXdPVFlLSUNBZ0lHSjVkR1ZqWW14dlkyc2dJbUp2ZUNJZ01IZ3dNQ0F3ZURFMU1XWTNZemMxQ2lBZ0lDQXZMeUJzWVhKblpWOWliM2hmYjNCbGNtRjBhVzl1Y3k5emRISjFZM1JmWVhKeVlYbGZZbTl2YkM1d2VUb3hPQW9nSUNBZ0x5OGdZMnhoYzNNZ1UzUnlkV04wUVhKeVlYbENiMjlzUTI5dWRISmhZM1FvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCaWVpQnRZV2x1WDE5ZllXeG5iM0I1WDJSbFptRjFiSFJmWTNKbFlYUmxRREUyQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFLSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGhpWldNM05tUTROeUF3ZUROaU5EUTJOR0kySURCNFpXRTFPV05rWXprZ01IaGpZVFpoWXpoaFlTQXdlR1UxTXpJM1ltSXlJREI0TWpFd05EUmpORGdnTUhoaU1UY3dNamd4TVNBdkx5QnRaWFJvYjJRZ0ltSnZiM1J6ZEhKaGNDZ3BkbTlwWkNJc0lHMWxkR2h2WkNBaVlYQndaVzVrS0dKdmIyd3BkbTlwWkNJc0lHMWxkR2h2WkNBaVkyOXVZMkYwS0dKdmIyeGJYU2wyYjJsa0lpd2diV1YwYUc5a0lDSndiM0FvS1dKdmIyd2lMQ0J0WlhSb2IyUWdJbWRsZENoMWFXNTBOalFwWW05dmJDSXNJRzFsZEdodlpDQWljMlYwS0hWcGJuUTJOQ3hpYjI5c0tYWnZhV1FpTENCdFpYUm9iMlFnSW5abGNtbG1lU2hpYjI5c1cxMHBkbTlwWkNJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHSnZiM1J6ZEhKaGNDQmhjSEJsYm1RZ1kyOXVZMkYwSUhCdmNDQm5aWFFnYzJWMElIWmxjbWxtZVFvZ0lDQWdaWEp5Q2dwdFlXbHVYMTlmWVd4bmIzQjVYMlJsWm1GMWJIUmZZM0psWVhSbFFERTJPZ29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQ0VLSUNBZ0lDWW1DaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QmZjSFY1WVY5c2FXSXVZbTk0WDJGeVl6UXVZbTk0WDNWd1pHRjBaVjl2Wm1aelpYUmZhVzVqS0dKdmVGOXJaWGs2SUdKNWRHVnpMQ0J2Wm1aelpYUTZJSFZwYm5RMk5Dd2dkbUZzZFdVNklIVnBiblEyTkNrZ0xUNGdkbTlwWkRvS1ltOTRYM1Z3WkdGMFpWOXZabVp6WlhSZmFXNWpPZ29nSUNBZ2NISnZkRzhnTXlBd0NpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdhVzUwWTE4d0lDOHZJRElLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNCaWRHOXBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUNzS0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JpYjNoZmNtVndiR0ZqWlFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnWDNCMWVXRmZiR2xpTG1KdmVGOWhjbU0wTG1KdmVGOWtlVzVoYldsalgyRnljbUY1WDJOdmJtTmhkRjlpYVhSektHSnZlRjlyWlhrNklHSjVkR1Z6TENCaGNuSmhlVjl2Wm1aelpYUTZJSFZwYm5RMk5Dd2dibVYzWDJsMFpXMXpYMko1ZEdWek9pQmllWFJsY3l3Z2JtVjNYMmwwWlcxelgyTnZkVzUwT2lCMWFXNTBOalFzSUhKbFlXUmZjM1JsY0RvZ2RXbHVkRFkwS1NBdFBpQjFhVzUwTmpRNkNtSnZlRjlrZVc1aGJXbGpYMkZ5Y21GNVgyTnZibU5oZEY5aWFYUnpPZ29nSUNBZ2NISnZkRzhnTlNBeENpQWdJQ0JtY21GdFpWOWthV2NnTFRVS0lDQWdJR1p5WVcxbFgyUnBaeUF0TkFvZ0lDQWdhVzUwWTE4d0lDOHZJRElLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNCaWRHOXBDaUFnSUNCa2RYQnVJRElLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ0t3b2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaHBiblFnTmpVMU16VUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYldGNElHRnljbUY1SUd4bGJtZDBhQ0JsZUdObFpXUmxaQW9nSUNBZ1puSmhiV1ZmWkdsbklDMDBDaUFnSUNCcGJuUmpYekFnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdZMjkyWlhJZ013b2dJQ0FnYzNkaGNBb2dJQ0FnY0hWemFHbHVkQ0EzQ2lBZ0lDQXJDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnTHdvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBMUNpQWdJQ0J6ZDJGd0NpQWdJQ0J3ZFhOb2FXNTBJRGNLSUNBZ0lDc0tJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0F2Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQXRDaUFnSUNCa2RYQUtJQ0FnSUdKNklHSnZlRjlrZVc1aGJXbGpYMkZ5Y21GNVgyTnZibU5oZEY5aWFYUnpYMkZtZEdWeVgybG1YMlZzYzJWQU1nb2dJQ0FnWm5KaGJXVmZaR2xuSUMwMUNpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCd2IzQUtJQ0FnSUdScFp5QXhDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lDc0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE5Rb2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzSmxjMmw2WlFvZ0lDQWdaR2xuSURNS0lDQWdJR1p5WVcxbFgyUnBaeUF3Q2lBZ0lDQXJDaUFnSUNCemQyRndDaUFnSUNCaWVtVnlid29nSUNBZ1puSmhiV1ZmWkdsbklDMDFDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR2x1ZEdOZk15QXZMeUF3Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdKdmVGOXpjR3hwWTJVS0NtSnZlRjlrZVc1aGJXbGpYMkZ5Y21GNVgyTnZibU5oZEY5aWFYUnpYMkZtZEdWeVgybG1YMlZzYzJWQU1qb0tJQ0FnSUdScFp5QXhDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnWm5KaGJXVmZaR2xuSUMwMUNpQWdJQ0JtY21GdFpWOWthV2NnTFRRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1ltOTRYM0psY0d4aFkyVUtJQ0FnSUdsdWRHTmZNeUF2THlBd0NpQWdJQ0J6ZDJGd0NpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHTnZkbVZ5SURJS0NtSnZlRjlrZVc1aGJXbGpYMkZ5Y21GNVgyTnZibU5oZEY5aWFYUnpYM2RvYVd4bFgzUnZjRUF6T2dvZ0lDQWdaR2xuSURJS0lDQWdJR1JwWnlBMENpQWdJQ0E4Q2lBZ0lDQmllaUJpYjNoZlpIbHVZVzFwWTE5aGNuSmhlVjlqYjI1allYUmZZbWwwYzE5aFpuUmxjbDkzYUdsc1pVQTVDaUFnSUNCa2FXY2dNZ29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnTHdvZ0lDQWdaR2xuSURZS0lDQWdJQ3NLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTlFvZ0lDQWdjM2RoY0FvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lDVUtJQ0FnSUdOdmRtVnlJRFVLSUNBZ0lHWnlZVzFsWDJScFp5QXROUW9nSUNBZ2MzZGhjQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0JqYjNabGNpQTFDZ3BpYjNoZlpIbHVZVzFwWTE5aGNuSmhlVjlqYjI1allYUmZZbWwwYzE5M2FHbHNaVjkwYjNCQU5Ub0tJQ0FnSUdScFp5QTBDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUEFvZ0lDQWdZbm9nWW05NFgyUjVibUZ0YVdOZllYSnlZWGxmWTI5dVkyRjBYMkpwZEhOZllXWjBaWEpmZDJocGJHVkFPQW9nSUNBZ1pHbG5JRElLSUNBZ0lHUnBaeUEzQ2lBZ0lDQThDaUFnSUNCaWVpQmliM2hmWkhsdVlXMXBZMTloY25KaGVWOWpiMjVqWVhSZlltbDBjMTloWm5SbGNsOTNhR2xzWlVBNENpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQm5aWFJpYVhRS0lDQWdJSFZ1WTI5MlpYSWdOZ29nSUNBZ2RXNWpiM1psY2lBMkNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlETUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlYwWW1sMENpQWdJQ0JqYjNabGNpQTFDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdZMjkyWlhJZ05Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNBckNpQWdJQ0J6ZDJGd0NpQWdJQ0JpSUdKdmVGOWtlVzVoYldsalgyRnljbUY1WDJOdmJtTmhkRjlpYVhSelgzZG9hV3hsWDNSdmNFQTFDZ3BpYjNoZlpIbHVZVzFwWTE5aGNuSmhlVjlqYjI1allYUmZZbWwwYzE5aFpuUmxjbDkzYUdsc1pVQTRPZ29nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0J3YjNBS0lDQWdJR1p5WVcxbFgyUnBaeUF0TlFvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCMWJtTnZkbVZ5SURVS0lDQWdJR0p2ZUY5eVpYQnNZV05sQ2lBZ0lDQmlJR0p2ZUY5a2VXNWhiV2xqWDJGeWNtRjVYMk52Ym1OaGRGOWlhWFJ6WDNkb2FXeGxYM1J2Y0VBekNncGliM2hmWkhsdVlXMXBZMTloY25KaGVWOWpiMjVqWVhSZlltbDBjMTloWm5SbGNsOTNhR2xzWlVBNU9nb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NpQWdJQ0J5WlhSemRXSUtDZ292THlCMFpYTjBYMk5oYzJWekxteGhjbWRsWDJKdmVGOXZjR1Z5WVhScGIyNXpMbk4wY25WamRGOWhjbkpoZVY5aWIyOXNMbE4wY25WamRFRnljbUY1UW05dmJFTnZiblJ5WVdOMExtSnZiM1J6ZEhKaGNGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbUp2YjNSemRISmhjRG9LSUNBZ0lDOHZJR3hoY21kbFgySnZlRjl2Y0dWeVlYUnBiMjV6TDNOMGNuVmpkRjloY25KaGVWOWliMjlzTG5CNU9qTXlDaUFnSUNBdkx5QnpaV3htTG1KdmVDNTJZV3gxWlNBOUlGTjBjblZqZEZkcGRHaEJjbkpoZVVKdmIyd29DaUFnSUNCaWVYUmxZMTh3SUM4dklDSmliM2dpQ2lBZ0lDQXZMeUJzWVhKblpWOWliM2hmYjNCbGNtRjBhVzl1Y3k5emRISjFZM1JmWVhKeVlYbGZZbTl2YkM1d2VUb3pNaTB6T0FvZ0lDQWdMeThnYzJWc1ppNWliM2d1ZG1Gc2RXVWdQU0JUZEhKMVkzUlhhWFJvUVhKeVlYbENiMjlzS0FvZ0lDQWdMeThnSUNBZ0lIQmhaR1JwYm1jOVRHRnlaMlZDZVhSbGN5Z3BMQW9nSUNBZ0x5OGdJQ0FnSUdFOVJtRnNjMlVzQ2lBZ0lDQXZMeUFnSUNBZ1lYSnlQVUZ5Y21GNVFtOXZiQ2dwTEFvZ0lDQWdMeThnSUNBZ0lHSTlWSEoxWlN3S0lDQWdJQzh2SUNBZ0lDQjBjbUZwYkdsdVp6MUJjbkpoZVZ0VlNXNTBOalJkS0NoVlNXNTBOalFvTkRJcExDa3BMQW9nSUNBZ0x5OGdLUW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJzWVhKblpWOWliM2hmYjNCbGNtRjBhVzl1Y3k5emRISjFZM1JmWVhKeVlYbGZZbTl2YkM1d2VUb3pNZ29nSUNBZ0x5OGdjMlZzWmk1aWIzZ3VkbUZzZFdVZ1BTQlRkSEoxWTNSWGFYUm9RWEp5WVhsQ2IyOXNLQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZbTk0SWdvZ0lDQWdMeThnYkdGeVoyVmZZbTk0WDI5d1pYSmhkR2x2Ym5NdmMzUnlkV04wWDJGeWNtRjVYMkp2YjJ3dWNIazZNekl0TXpnS0lDQWdJQzh2SUhObGJHWXVZbTk0TG5aaGJIVmxJRDBnVTNSeWRXTjBWMmwwYUVGeWNtRjVRbTl2YkNnS0lDQWdJQzh2SUNBZ0lDQndZV1JrYVc1blBVeGhjbWRsUW5sMFpYTW9LU3dLSUNBZ0lDOHZJQ0FnSUNCaFBVWmhiSE5sTEFvZ0lDQWdMeThnSUNBZ0lHRnljajFCY25KaGVVSnZiMndvS1N3S0lDQWdJQzh2SUNBZ0lDQmlQVlJ5ZFdVc0NpQWdJQ0F2THlBZ0lDQWdkSEpoYVd4cGJtYzlRWEp5WVhsYlZVbHVkRFkwWFNnb1ZVbHVkRFkwS0RReUtTd3BLU3dLSUNBZ0lDOHZJQ2tLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TURnd01EQXdNR0U0TURBd01HTXdNREF3TURBd01EQXdNREV3TURBd01EQXdNREF3TURBd01ESmhDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJzWVhKblpWOWliM2hmYjNCbGNtRjBhVzl1Y3k5emRISjFZM1JmWVhKeVlYbGZZbTl2YkM1d2VUb3pPUW9nSUNBZ0x5OGdjMlZzWmk1aWIzZ3VkbUZzZFdVdWNHRmtaR2x1Wnk1aGNIQmxibVFvUW5sMFpYTTBNRGsyS0NrcENpQWdJQ0JwYm5SaklEUWdMeThnTkRBNU5nb2dJQ0FnWW5wbGNtOEtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltSnZlQ0lLSUNBZ0lIQjFjMmhwYm5RZ013b2dJQ0FnYVc1MFl5QTBJQzh2SURRd09UWUtJQ0FnSUdOaGJHeHpkV0lnWW05NFgzVndaR0YwWlY5dlptWnpaWFJmYVc1akNpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKaWIzZ2lDaUFnSUNCd2RYTm9hVzUwSURZS0lDQWdJR2x1ZEdNZ05DQXZMeUEwTURrMkNpQWdJQ0JqWVd4c2MzVmlJR0p2ZUY5MWNHUmhkR1ZmYjJabWMyVjBYMmx1WXdvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWW05NElnb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJR2x1ZEdOZk1DQXZMeUF5Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdiR0Z5WjJWZlltOTRYMjl3WlhKaGRHbHZibk12YzNSeWRXTjBYMkZ5Y21GNVgySnZiMnd1Y0hrNk16a0tJQ0FnSUM4dklITmxiR1l1WW05NExuWmhiSFZsTG5CaFpHUnBibWN1WVhCd1pXNWtLRUo1ZEdWek5EQTVOaWdwS1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWW05NElnb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ2NHOXdDaUFnSUNBdkx5QnNZWEpuWlY5aWIzaGZiM0JsY21GMGFXOXVjeTl6ZEhKMVkzUmZZWEp5WVhsZlltOXZiQzV3ZVRvek9Rb2dJQ0FnTHk4Z2MyVnNaaTVpYjNndWRtRnNkV1V1Y0dGa1pHbHVaeTVoY0hCbGJtUW9RbmwwWlhNME1EazJLQ2twQ2lBZ0lDQnBiblJqSURRZ0x5OGdOREE1TmdvZ0lDQWdLd29nSUNBZ0x5OGdiR0Z5WjJWZlltOTRYMjl3WlhKaGRHbHZibk12YzNSeWRXTjBYMkZ5Y21GNVgySnZiMnd1Y0hrNk16a0tJQ0FnSUM4dklITmxiR1l1WW05NExuWmhiSFZsTG5CaFpHUnBibWN1WVhCd1pXNWtLRUo1ZEdWek5EQTVOaWdwS1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWW05NElnb2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzSmxjMmw2WlFvZ0lDQWdaSFZ3Q2lBZ0lDQXZMeUJzWVhKblpWOWliM2hmYjNCbGNtRjBhVzl1Y3k5emRISjFZM1JmWVhKeVlYbGZZbTl2YkM1d2VUb3pPUW9nSUNBZ0x5OGdjMlZzWmk1aWIzZ3VkbUZzZFdVdWNHRmtaR2x1Wnk1aGNIQmxibVFvUW5sMFpYTTBNRGsyS0NrcENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdLd29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUM4dklHeGhjbWRsWDJKdmVGOXZjR1Z5WVhScGIyNXpMM04wY25WamRGOWhjbkpoZVY5aWIyOXNMbkI1T2pNNUNpQWdJQ0F2THlCelpXeG1MbUp2ZUM1MllXeDFaUzV3WVdSa2FXNW5MbUZ3Y0dWdVpDaENlWFJsY3pRd09UWW9LU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUp2ZUNJS0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdKdmVGOXlaWEJzWVdObENpQWdJQ0F2THlCc1lYSm5aVjlpYjNoZmIzQmxjbUYwYVc5dWN5OXpkSEoxWTNSZllYSnlZWGxmWW05dmJDNXdlVG96T1FvZ0lDQWdMeThnYzJWc1ppNWliM2d1ZG1Gc2RXVXVjR0ZrWkdsdVp5NWhjSEJsYm1Rb1FubDBaWE0wTURrMktDa3BDaUFnSUNCcGJuUmpJRFFnTHk4Z05EQTVOZ29nSUNBZ0tnb2dJQ0FnY0hWemFHbHVkQ0F4TUFvZ0lDQWdLd29nSUNBZ0x5OGdiR0Z5WjJWZlltOTRYMjl3WlhKaGRHbHZibk12YzNSeWRXTjBYMkZ5Y21GNVgySnZiMnd1Y0hrNk16a0tJQ0FnSUM4dklITmxiR1l1WW05NExuWmhiSFZsTG5CaFpHUnBibWN1WVhCd1pXNWtLRUo1ZEdWek5EQTVOaWdwS1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWW05NElnb2dJQ0FnYzNkaGNBb2dJQ0FnYVc1MFkxOHpJQzh2SURBS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1ltOTRYM053YkdsalpRb2dJQ0FnTHk4Z2JHRnlaMlZmWW05NFgyOXdaWEpoZEdsdmJuTXZjM1J5ZFdOMFgyRnljbUY1WDJKdmIyd3VjSGs2TXpVS0lDQWdJQzh2SUdGeWNqMUJjbkpoZVVKdmIyd29LU3dLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TURBS0lDQWdJQzh2SUd4aGNtZGxYMkp2ZUY5dmNHVnlZWFJwYjI1ekwzTjBjblZqZEY5aGNuSmhlVjlpYjI5c0xuQjVPalF3Q2lBZ0lDQXZMeUJ6Wld4bUxuWmxjbWxtZVNoQmNuSmhlVUp2YjJ3b0tTa0tJQ0FnSUdOaGJHeHpkV0lnZEdWemRGOWpZWE5sY3k1c1lYSm5aVjlpYjNoZmIzQmxjbUYwYVc5dWN5NXpkSEoxWTNSZllYSnlZWGxmWW05dmJDNVRkSEoxWTNSQmNuSmhlVUp2YjJ4RGIyNTBjbUZqZEM1MlpYSnBabmtLSUNBZ0lIQnZjQW9nSUNBZ0x5OGdiR0Z5WjJWZlltOTRYMjl3WlhKaGRHbHZibk12YzNSeWRXTjBYMkZ5Y21GNVgySnZiMnd1Y0hrNk16QUtJQ0FnSUM4dklFQndkV0pzYVdNS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMFgyTmhjMlZ6TG14aGNtZGxYMkp2ZUY5dmNHVnlZWFJwYjI1ekxuTjBjblZqZEY5aGNuSmhlVjlpYjI5c0xsTjBjblZqZEVGeWNtRjVRbTl2YkVOdmJuUnlZV04wTG1Gd2NHVnVaRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21Gd2NHVnVaRG9LSUNBZ0lDOHZJR3hoY21kbFgySnZlRjl2Y0dWeVlYUnBiMjV6TDNOMGNuVmpkRjloY25KaGVWOWliMjlzTG5CNU9qUXlDaUFnSUNBdkx5QkFjSFZpYkdsakNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WW05dmJBb2dJQ0FnYVc1MFkxOHpJQzh2SURBS0lDQWdJR2RsZEdKcGRBb2dJQ0FnTHk4Z2JHRnlaMlZmWW05NFgyOXdaWEpoZEdsdmJuTXZjM1J5ZFdOMFgyRnljbUY1WDJKdmIyd3VjSGs2TkRRS0lDQWdJQzh2SUhObGJHWXVZbTk0TG5aaGJIVmxMbUZ5Y2k1aGNIQmxibVFvZG1Gc2RXVXBDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNREFLSUNBZ0lHbHVkR05mTXlBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sZEdKcGRBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVltOTRJZ29nSUNBZ2NIVnphR2x1ZENBekNpQWdJQ0JwYm5Salh6QWdMeThnTWdvZ0lDQWdZbTk0WDJWNGRISmhZM1FLSUNBZ0lHSjBiMmtLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUp2ZUNJS0lDQWdJSE4zWVhBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUdSMWNBb2dJQ0FnWTJGc2JITjFZaUJpYjNoZlpIbHVZVzFwWTE5aGNuSmhlVjlqYjI1allYUmZZbWwwY3dvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWW05NElnb2dJQ0FnY0hWemFHbHVkQ0EyQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOaGJHeHpkV0lnWW05NFgzVndaR0YwWlY5dlptWnpaWFJmYVc1akNpQWdJQ0F2THlCc1lYSm5aVjlpYjNoZmIzQmxjbUYwYVc5dWN5OXpkSEoxWTNSZllYSnlZWGxmWW05dmJDNXdlVG8wTWdvZ0lDQWdMeThnUUhCMVlteHBZd29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1JmWTJGelpYTXViR0Z5WjJWZlltOTRYMjl3WlhKaGRHbHZibk11YzNSeWRXTjBYMkZ5Y21GNVgySnZiMnd1VTNSeWRXTjBRWEp5WVhsQ2IyOXNRMjl1ZEhKaFkzUXVZMjl1WTJGMFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZMjl1WTJGME9nb2dJQ0FnTHk4Z2JHRnlaMlZmWW05NFgyOXdaWEpoZEdsdmJuTXZjM1J5ZFdOMFgyRnljbUY1WDJKdmIyd3VjSGs2TkRZS0lDQWdJQzh2SUVCd2RXSnNhV01LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh6SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQTNDaUFnSUNBckNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdMd29nSUNBZ2FXNTBZMTh3SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeUNpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhpYjI5c1Bnb2dJQ0FnTHk4Z2JHRnlaMlZmWW05NFgyOXdaWEpoZEdsdmJuTXZjM1J5ZFdOMFgyRnljbUY1WDJKdmIyd3VjSGs2TkRnS0lDQWdJQzh2SUhObGJHWXVZbTk0TG5aaGJIVmxMbUZ5Y2k1bGVIUmxibVFvWVhKeVlYa3BDaUFnSUNCemQyRndDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVltOTRJZ29nSUNBZ2NIVnphR2x1ZENBekNpQWdJQ0JwYm5Salh6QWdMeThnTWdvZ0lDQWdZbTk0WDJWNGRISmhZM1FLSUNBZ0lHSjBiMmtLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUp2ZUNJS0lDQWdJSE4zWVhBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdZMkZzYkhOMVlpQmliM2hmWkhsdVlXMXBZMTloY25KaGVWOWpiMjVqWVhSZlltbDBjd29nSUNBZ1lubDBaV05mTUNBdkx5QWlZbTk0SWdvZ0lDQWdjSFZ6YUdsdWRDQTJDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR05oYkd4emRXSWdZbTk0WDNWd1pHRjBaVjl2Wm1aelpYUmZhVzVqQ2lBZ0lDQXZMeUJzWVhKblpWOWliM2hmYjNCbGNtRjBhVzl1Y3k5emRISjFZM1JmWVhKeVlYbGZZbTl2YkM1d2VUbzBOZ29nSUNBZ0x5OGdRSEIxWW14cFl3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUmZZMkZ6WlhNdWJHRnlaMlZmWW05NFgyOXdaWEpoZEdsdmJuTXVjM1J5ZFdOMFgyRnljbUY1WDJKdmIyd3VVM1J5ZFdOMFFYSnlZWGxDYjI5c1EyOXVkSEpoWTNRdWNHOXdXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LY0c5d09nb2dJQ0FnTHk4Z2JHRnlaMlZmWW05NFgyOXdaWEpoZEdsdmJuTXZjM1J5ZFdOMFgyRnljbUY1WDJKdmIyd3VjSGs2TlRJS0lDQWdJQzh2SUhKbGRIVnliaUJ6Wld4bUxtSnZlQzUyWVd4MVpTNWhjbkl1Y0c5d0tDa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltSnZlQ0lLSUNBZ0lIQjFjMmhwYm5RZ013b2dJQ0FnYVc1MFkxOHdJQzh2SURJS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQmlkRzlwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0ppYjNnaUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVc1MFkxOHdJQzh2SURJS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQmlkRzlwQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBdElDOHZJRzl1SUdWeWNtOXlPaUJqWVc1dWIzUWdjRzl3SUdaeWIyMGdaVzF3ZEhrZ1lYSnlZWGtLSUNBZ0lHUjFjQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0E4Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzVrWlhnZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ1pHbG5JREVLSUNBZ0lHbHVkR05mTUNBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJQzhLSUNBZ0lDc0tJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNd29nSUNBZ1pHbG5JREVLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBbENpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdOdmRtVnlJRFVLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUp2ZUNJS0lDQWdJSE4zWVhBS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQ0F2THlCdmJpQmxjbkp2Y2pvZ2FXNWtaWGdnYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnWkdsbklERUtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E4Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzVrWlhnZ1lXTmpaWE56SUdseklHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lHUnBaeUF4Q2lBZ0lDQm5aWFJpYVhRS0lDQWdJR052ZG1WeUlETUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0F2THlCc1lYSm5aVjlpYjNoZmIzQmxjbUYwYVc5dWN5OXpkSEoxWTNSZllYSnlZWGxmWW05dmJDNXdlVG8xTWdvZ0lDQWdMeThnY21WMGRYSnVJSE5sYkdZdVltOTRMblpoYkhWbExtRnljaTV3YjNBb0tRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVltOTRJZ29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHSnZlRjl5WlhCc1lXTmxDaUFnSUNCaWJub2djRzl3WDJGbWRHVnlYMmxtWDJWc2MyVkFNd29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J3YjNBS0lDQWdJQzh2SUd4aGNtZGxYMkp2ZUY5dmNHVnlZWFJwYjI1ekwzTjBjblZqZEY5aGNuSmhlVjlpYjI5c0xuQjVPalV5Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdjMlZzWmk1aWIzZ3VkbUZzZFdVdVlYSnlMbkJ2Y0NncENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKaWIzZ2lDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGdLSUNBZ0lHSnZlRjl6Y0d4cFkyVUtJQ0FnSUM4dklHeGhjbWRsWDJKdmVGOXZjR1Z5WVhScGIyNXpMM04wY25WamRGOWhjbkpoZVY5aWIyOXNMbkI1T2pVeUNpQWdJQ0F2THlCeVpYUjFjbTRnYzJWc1ppNWliM2d1ZG1Gc2RXVXVZWEp5TG5CdmNDZ3BDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmliM2dpQ2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0J3YjNBS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXRDaUFnSUNBdkx5QnNZWEpuWlY5aWIzaGZiM0JsY21GMGFXOXVjeTl6ZEhKMVkzUmZZWEp5WVhsZlltOXZiQzV3ZVRvMU1nb2dJQ0FnTHk4Z2NtVjBkWEp1SUhObGJHWXVZbTk0TG5aaGJIVmxMbUZ5Y2k1d2IzQW9LUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZbTk0SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZbTk0WDNKbGMybDZaUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtDbkJ2Y0Y5aFpuUmxjbDlwYm14cGJtVmtYMTl3ZFhsaFgyeHBZaTVpYjNoZllYSmpOQzVpYjNoZlpIbHVZVzFwWTE5aGNuSmhlVjl3YjNCZlltbDBRRFE2Q2lBZ0lDQXZMeUJzWVhKblpWOWliM2hmYjNCbGNtRjBhVzl1Y3k5emRISjFZM1JmWVhKeVlYbGZZbTl2YkM1d2VUbzFNZ29nSUNBZ0x5OGdjbVYwZFhKdUlITmxiR1l1WW05NExuWmhiSFZsTG1GeWNpNXdiM0FvS1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWW05NElnb2dJQ0FnY0hWemFHbHVkQ0EyQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNZ29nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUdKMGIya0tJQ0FnSUhOM1lYQUtJQ0FnSUMwS0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQXZMeUJzWVhKblpWOWliM2hmYjNCbGNtRjBhVzl1Y3k5emRISjFZM1JmWVhKeVlYbGZZbTl2YkM1d2VUbzFNZ29nSUNBZ0x5OGdjbVYwZFhKdUlITmxiR1l1WW05NExuWmhiSFZsTG1GeWNpNXdiM0FvS1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWW05NElnb2dJQ0FnY0hWemFHbHVkQ0EyQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdKdmVGOXlaWEJzWVdObENpQWdJQ0F2THlCc1lYSm5aVjlpYjNoZmIzQmxjbUYwYVc5dWN5OXpkSEoxWTNSZllYSnlZWGxmWW05dmJDNXdlVG8xTUFvZ0lDQWdMeThnUUhCMVlteHBZd29nSUNBZ1lubDBaV05mTVNBdkx5QXdlREF3Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6WlhSaWFYUUtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbkJ2Y0Y5aFpuUmxjbDlwWmw5bGJITmxRRE02Q2lBZ0lDQXZMeUJzWVhKblpWOWliM2hmYjNCbGNtRjBhVzl1Y3k5emRISjFZM1JmWVhKeVlYbGZZbTl2YkM1d2VUbzFNZ29nSUNBZ0x5OGdjbVYwZFhKdUlITmxiR1l1WW05NExuWmhiSFZsTG1GeWNpNXdiM0FvS1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWW05NElnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JwYm5Salh6TWdMeThnTUFvZ0lDQWdjMlYwWW1sMENpQWdJQ0F2THlCc1lYSm5aVjlpYjNoZmIzQmxjbUYwYVc5dWN5OXpkSEoxWTNSZllYSnlZWGxmWW05dmJDNXdlVG8xTWdvZ0lDQWdMeThnY21WMGRYSnVJSE5sYkdZdVltOTRMblpoYkhWbExtRnljaTV3YjNBb0tRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVltOTRJZ29nSUNBZ1kyOTJaWElnTWdvZ0lDQWdZbTk0WDNKbGNHeGhZMlVLSUNBZ0lHbHVkR05mTXlBdkx5QXdDaUFnSUNBdkx5QnNZWEpuWlY5aWIzaGZiM0JsY21GMGFXOXVjeTl6ZEhKMVkzUmZZWEp5WVhsZlltOXZiQzV3ZVRvMU1nb2dJQ0FnTHk4Z2NtVjBkWEp1SUhObGJHWXVZbTk0TG5aaGJIVmxMbUZ5Y2k1d2IzQW9LUW9nSUNBZ1lpQndiM0JmWVdaMFpYSmZhVzVzYVc1bFpGOWZjSFY1WVY5c2FXSXVZbTk0WDJGeVl6UXVZbTk0WDJSNWJtRnRhV05mWVhKeVlYbGZjRzl3WDJKcGRFQTBDZ29LTHk4Z2RHVnpkRjlqWVhObGN5NXNZWEpuWlY5aWIzaGZiM0JsY21GMGFXOXVjeTV6ZEhKMVkzUmZZWEp5WVhsZlltOXZiQzVUZEhKMVkzUkJjbkpoZVVKdmIyeERiMjUwY21GamRDNW5aWFJiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwblpYUTZDaUFnSUNBdkx5QnNZWEpuWlY5aWIzaGZiM0JsY21GMGFXOXVjeTl6ZEhKMVkzUmZZWEp5WVhsZlltOXZiQzV3ZVRvMU5Bb2dJQ0FnTHk4Z1FIQjFZbXhwWXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2JHRnlaMlZmWW05NFgyOXdaWEpoZEdsdmJuTXZjM1J5ZFdOMFgyRnljbUY1WDJKdmIyd3VjSGs2TlRZS0lDQWdJQzh2SUhKbGRIVnliaUJ6Wld4bUxtSnZlQzUyWVd4MVpTNWhjbkpiYVdSNFhRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVltOTRJZ29nSUNBZ2NIVnphR2x1ZENBekNpQWdJQ0JwYm5Salh6QWdMeThnTWdvZ0lDQWdZbTk0WDJWNGRISmhZM1FLSUNBZ0lHSjBiMmtLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUp2ZUNJS0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5Salh6QWdMeThnTWdvZ0lDQWdZbTk0WDJWNGRISmhZM1FLSUNBZ0lHSjBiMmtLSUNBZ0lHUnBaeUF5Q2lBZ0lDQStDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNWtaWGdnYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnYVc1MFkxOHdJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ0x3b2dJQ0FnS3dvZ0lDQWdjM2RoY0FvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lDVUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltSnZlQ0lLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJR0p2ZUY5bGVIUnlZV04wSUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCa2FXY2dNUW9nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUR3S0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm1SbGVDQmhZMk5sYzNNZ2FYTWdiM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdjM2RoY0FvZ0lDQWdaMlYwWW1sMENpQWdJQ0F2THlCc1lYSm5aVjlpYjNoZmIzQmxjbUYwYVc5dWN5OXpkSEoxWTNSZllYSnlZWGxmWW05dmJDNXdlVG8xTkFvZ0lDQWdMeThnUUhCMVlteHBZd29nSUNBZ1lubDBaV05mTVNBdkx5QXdlREF3Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6WlhSaWFYUUtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBYMk5oYzJWekxteGhjbWRsWDJKdmVGOXZjR1Z5WVhScGIyNXpMbk4wY25WamRGOWhjbkpoZVY5aWIyOXNMbE4wY25WamRFRnljbUY1UW05dmJFTnZiblJ5WVdOMExuTmxkRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25ObGREb0tJQ0FnSUM4dklHeGhjbWRsWDJKdmVGOXZjR1Z5WVhScGIyNXpMM04wY25WamRGOWhjbkpoZVY5aWIyOXNMbkI1T2pVNENpQWdJQ0F2THlCQWNIVmliR2xqQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WW05dmJBb2dJQ0FnYVc1MFkxOHpJQzh2SURBS0lDQWdJR2RsZEdKcGRBb2dJQ0FnTHk4Z2JHRnlaMlZmWW05NFgyOXdaWEpoZEdsdmJuTXZjM1J5ZFdOMFgyRnljbUY1WDJKdmIyd3VjSGs2TmpBS0lDQWdJQzh2SUhObGJHWXVZbTk0TG5aaGJIVmxMbUZ5Y2x0cFpIaGRJRDBnZG1Gc2RXVUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltSnZlQ0lLSUNBZ0lIQjFjMmhwYm5RZ013b2dJQ0FnYVc1MFkxOHdJQzh2SURJS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQmlkRzlwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0ppYjNnaUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVc1MFkxOHdJQzh2SURJS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQmlkRzlwQ2lBZ0lDQmthV2NnTXdvZ0lDQWdQZ29nSUNBZ1lYTnpaWEowSUM4dklHbHVaR1Y0SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUdsdWRHTmZNQ0F2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTWdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lDOEtJQ0FnSUNzS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUNVS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1KdmVDSUtJQ0FnSUdScFp5QXlDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnWW05NFgyVjRkSEpoWTNRS0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdQQW9nSUNBZ1lYTnpaWEowSUM4dklHbHVaR1Y0SUdGalkyVnpjeUJwY3lCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCemQyRndDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJSE5sZEdKcGRBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVltOTRJZ29nSUNBZ1kyOTJaWElnTWdvZ0lDQWdZbTk0WDNKbGNHeGhZMlVnTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUM4dklHeGhjbWRsWDJKdmVGOXZjR1Z5WVhScGIyNXpMM04wY25WamRGOWhjbkpoZVY5aWIyOXNMbkI1T2pVNENpQWdJQ0F2THlCQWNIVmliR2xqQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEY5allYTmxjeTVzWVhKblpWOWliM2hmYjNCbGNtRjBhVzl1Y3k1emRISjFZM1JmWVhKeVlYbGZZbTl2YkM1VGRISjFZM1JCY25KaGVVSnZiMnhEYjI1MGNtRmpkQzUyWlhKcFpubGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AyWlhKcFpuazZDaUFnSUNBdkx5QnNZWEpuWlY5aWIzaGZiM0JsY21GMGFXOXVjeTl6ZEhKMVkzUmZZWEp5WVhsZlltOXZiQzV3ZVRvMk1nb2dJQ0FnTHk4Z1FIQjFZbXhwWXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnY0hWemFHbHVkQ0EzQ2lBZ0lDQXJDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnTHdvZ0lDQWdhVzUwWTE4d0lDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aWIyOXNQZ29nSUNBZ1kyRnNiSE4xWWlCMFpYTjBYMk5oYzJWekxteGhjbWRsWDJKdmVGOXZjR1Z5WVhScGIyNXpMbk4wY25WamRGOWhjbkpoZVY5aWIyOXNMbE4wY25WamRFRnljbUY1UW05dmJFTnZiblJ5WVdOMExuWmxjbWxtZVFvZ0lDQWdjRzl3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEY5allYTmxjeTVzWVhKblpWOWliM2hmYjNCbGNtRjBhVzl1Y3k1emRISjFZM1JmWVhKeVlYbGZZbTl2YkM1VGRISjFZM1JCY25KaGVVSnZiMnhEYjI1MGNtRmpkQzUyWlhKcFpua29aWGh3WldOMFpXUTZJR0o1ZEdWektTQXRQaUJpZVhSbGN6b0tkR1Z6ZEY5allYTmxjeTVzWVhKblpWOWliM2hmYjNCbGNtRjBhVzl1Y3k1emRISjFZM1JmWVhKeVlYbGZZbTl2YkM1VGRISjFZM1JCY25KaGVVSnZiMnhEYjI1MGNtRmpkQzUyWlhKcFpuazZDaUFnSUNBdkx5QnNZWEpuWlY5aWIzaGZiM0JsY21GMGFXOXVjeTl6ZEhKMVkzUmZZWEp5WVhsZlltOXZiQzV3ZVRvMk1pMDJNd29nSUNBZ0x5OGdRSEIxWW14cFl3b2dJQ0FnTHk4Z1pHVm1JSFpsY21sbWVTaHpaV3htTENCbGVIQmxZM1JsWkRvZ1FYSnlZWGxDYjI5c0tTQXRQaUJPYjI1bE9nb2dJQ0FnY0hKdmRHOGdNU0F4Q2lBZ0lDQXZMeUJzWVhKblpWOWliM2hmYjNCbGNtRjBhVzl1Y3k5emRISjFZM1JmWVhKeVlYbGZZbTl2YkM1d2VUbzJOQW9nSUNBZ0x5OGdZWE56WlhKMElITmxiR1l1WW05NExuWmhiSFZsTG1GeWNpQTlQU0JsZUhCbFkzUmxaQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZbTk0SWdvZ0lDQWdjSFZ6YUdsdWRDQXpDaUFnSUNCcGJuUmpYekFnTHk4Z01nb2dJQ0FnWW05NFgyVjRkSEpoWTNRS0lDQWdJR0owYjJrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1KdmVDSUtJQ0FnSUdScFp5QXhDaUFnSUNCcGJuUmpYekFnTHk4Z01nb2dJQ0FnWW05NFgyVjRkSEpoWTNRS0lDQWdJR0owYjJrS0lDQWdJSEIxYzJocGJuUWdOd29nSUNBZ0t3b2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJQzhLSUNBZ0lHbHVkR05mTUNBdkx5QXlDaUFnSUNBckNpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKaWIzZ2lDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QnNZWEpuWlY5aWIzaGZiM0JsY21GMGFXOXVjeTl6ZEhKMVkzUmZZWEp5WVhsZlltOXZiQzV3ZVRvMk5Rb2dJQ0FnTHk4Z1lYTnpaWEowSUc1dmRDQnpaV3htTG1KdmVDNTJZV3gxWlM1aENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKaWIzZ2lDaUFnSUNCcGJuUmpYekFnTHk4Z01nb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJR0p2ZUY5bGVIUnlZV04wSUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCcGJuUmpYek1nTHk4Z01Bb2dJQ0FnWjJWMFltbDBDaUFnSUNBaENpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklHeGhjbWRsWDJKdmVGOXZjR1Z5WVhScGIyNXpMM04wY25WamRGOWhjbkpoZVY5aWIyOXNMbkI1T2pZMkNpQWdJQ0F2THlCaGMzTmxjblFnYzJWc1ppNWliM2d1ZG1Gc2RXVXVZZ29nSUNBZ1lubDBaV05mTUNBdkx5QWlZbTk0SWdvZ0lDQWdjSFZ6YUdsdWRDQTFDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnWW05NFgyVjRkSEpoWTNRZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lHbHVkR05mTXlBdkx5QXdDaUFnSUNCblpYUmlhWFFLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnYkdGeVoyVmZZbTk0WDI5d1pYSmhkR2x2Ym5NdmMzUnlkV04wWDJGeWNtRjVYMkp2YjJ3dWNIazZOamNLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpaV3htTG1KdmVDNTJZV3gxWlM1d1lXUmthVzVuTG14bGJtZDBhQ0E5UFNBeENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKaWIzZ2lDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnYVc1MFkxOHdJQzh2SURJS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQmlkRzlwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdiR0Z5WjJWZlltOTRYMjl3WlhKaGRHbHZibk12YzNSeWRXTjBYMkZ5Y21GNVgySnZiMnd1Y0hrNk5qZ0tJQ0FnSUM4dklHRnpjMlZ5ZENCelpXeG1MbUp2ZUM1MllXeDFaUzUwY21GcGJHbHVaeUE5UFNCQmNuSmhlVnRWU1c1ME5qUmRLQ2hWU1c1ME5qUW9ORElwTENrcENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKaWIzZ2lDaUFnSUNCd2RYTm9hVzUwSURZS0lDQWdJR2x1ZEdOZk1DQXZMeUF5Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQW9nSUNBZ1luUnZhUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZbTk0SWdvZ0lDQWdaR2xuSURFS0lDQWdJR2x1ZEdOZk1DQXZMeUF5Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQW9nSUNBZ1luUnZhUW9nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUNvS0lDQWdJR2x1ZEdOZk1DQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmliM2dpQ2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBd01UQXdNREF3TURBd01EQXdNREF3TW1FS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUd4aGNtZGxYMkp2ZUY5dmNHVnlZWFJwYjI1ekwzTjBjblZqZEY5aGNuSmhlVjlpYjI5c0xuQjVPamN3TFRjMkNpQWdJQ0F2THlBaklIQmhaR1JwYm1jNklESWdkSFZ3YkdVZ2FHVmhaQ0J2Wm1aelpYUWdLeUF5SUd4bGJtZDBhQ0JvWldGa1pYSWdLeUEwTURrMklHUmhkR0VnUFNBME1UQXdJR0o1ZEdWekNpQWdJQ0F2THlBaklHRTZJREVnWW5sMFpTQmliMjlzSUNoallXNG5kQ0J3WVdOcktRb2dJQ0FnTHk4Z0l5Qmhjbkk2SURJZ0tHOW1abk5sZENrZ0t5QXlJQ2hzWlc1bmRHZ3BJQ3NnY0dGamEyVmtJR0p2YjJ3Z1pHRjBZUW9nSUNBZ0x5OGdJeUJpT2lBeElHSjVkR1VnWW05dmJDQW9jMkZ0WlNCaGN5QmhLUW9nSUNBZ0x5OGdJeUIwY21GcGJHbHVaem9nTWlBb2IyWm1jMlYwS1NBcklESWdLR3hsYm1kMGFDa2dLeUE0SUNodmJtVWdkV2x1ZERZMEtTQTlJREV5SUdKNWRHVnpDaUFnSUNBdkx5QWpJSFJ2ZEdGc0lHSjVkR1Z6YVhwbElEMGdOREV4T0NBcklIZG9ZWFJsZG1WeUlIUm9aU0J3WVdOclpXUWdZbTl2YkNCa1lYUmhJR2x6Q2lBZ0lDQXZMeUJoYzNObGNuUWdjMlZzWmk1aWIzZ3ViR1Z1WjNSb0lEMDlJRFF4TVRnZ0t5QW9aWGh3WldOMFpXUXViR1Z1WjNSb0lDc2dOeWtnTHk4Z09Dd2dJblZ1Wlhod1pXTjBaV1FnWW05NElITnBlbVVpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0ppYjNnaUNpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCd2IzQUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYVc1MFkxOHpJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lIQjFjMmhwYm5RZ053b2dJQ0FnS3dvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lDOEtJQ0FnSUhCMWMyaHBiblFnTkRFeE9Bb2dJQ0FnS3dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QjFibVY0Y0dWamRHVmtJR0p2ZUNCemFYcGxDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUhKbGRITjFZZ289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRkFnRUlBSUFnSmdNRFltOTRBUUFFRlI5OGRURWJRUUJBTVJrVVJERVlSSUlIQkw3SGJZY0VPMFJrdGdUcVdjM0pCTXBxeUtvRTVUSjdzZ1FoQkV4SUJMRndLQkUyR2dDT0J3RHBBVWtCY1FHaUFpc0NaUUtuQURFWkZERVlGQkJEaWdNQWkvMkwvaUs2RjR2L0NCWlhCZ0tML1l2K1R3SzdpWW9GQVl2N2kvd2l1aGRIQW92K0NFbE9Ba21CLy84RERrU0wvQ0lJVGdOTWdRY0lKQXBKVGdWTWdRY0lKQXBNQ1VsQkFCMkwrNzFJU3dGSlRnSUlpL3RNMDBzRGl3QUlUSytMKzA4Q0pVOEQwa3NCRmxjR0FvdjdpL3hQQXJzbFRFOEVUZ0pMQWtzRURFRUFXRXNDU1NRS1N3WUlTVTRGVENRWVRnV0wrMHdqdWs0RlN3UWtERUVBTFVzQ1N3Y01RUUFsaS8xUEFrbE9BbE5QQms4R1NVNERUd0pVVGdVakNFNEVUd0lqQ0U0Q2kvOElURUwvekU4RVNJdjdUd1JQQmJ0Qy82Q01BSWtvdkVnb2dCWUFDQUFBQ29BQURBQUFBQUFBQVFBQUFBQUFBQUFxdnlFRXJ5aUJBeUVFaVA3NEtJRUdJUVNJL3ZBb0pDSzZGeWk5U0NFRUNDaE0wMGtqQ0JaWEJnSW9KRThDdXlFRUM0RUtDQ2hNSlU4RDBvQUNBQUNJQVhsSUkwTTJHZ0ZKRlNNU1JDVlRLU1ZQQWxRb2dRTWl1aGNvVEU4Q0kwbUkvcnNvZ1FaUEFvaittaU5ETmhvQlNTVlpTWUVIQ0NRS0lnaExBaFVTUkV4WEFnQW9nUU1pdWhjb1RFOENUd01qaVA2S0tJRUdUd0tJL21ralF5aUJBeUs2RnloTEFTSzZGMGtqQ1VsUEFneEVTd0VpQ0VzQkpBb0lTVTREU3dFa0dFbE9BazRGS0V3anVrc0JKQXhFU3dGVFRnTk1GbGNHQWloUEEwOEN1MEFBTUU4Q1NDaFBBaU9BQU5Jb3ZVZ2pDU2hNMHlNb2dRWWl1aGRNQ1JaWEJnSW9nUVpQQXJzcEpVOENWQ3BNVUxBalF5aFBBa2xPQWlPNlR3TWxWQ2hPQXJzbFF2L1BOaG9CU1JVa0VrUVhLSUVESXJvWEtFc0JJcm9YU3dJTlJDSUlTd0VrQ2doTUpCZ29Ud0lqdWtzQkpBeEVURk1wSlU4Q1ZDcE1VTEFqUXpZYUFVa1ZKQkpFRnpZYUFra1ZJeEpFSlZNb2dRTWl1aGNvU3dFaXVoZExBdzFFSWdoTEFpUUtDRThDSkJnb1N3SWp1a3NCSkF4RVRFOERWQ2hPQXJzalF6WWFBVWtsV1lFSENDUUtJZ2hMQVJVU1JJZ0FBMGdqUTRvQkFTaUJBeUs2RnloTEFTSzZGNEVIQ0NRS0lnZ29UZ0s2aS84U1JDZ2lJN29sVXhSRUtJRUZJN29sVTBRb0pDSzZGeU1TUkNpQkJpSzZGeWhMQVNLNkZ5UUxJZ2dvVGdLNmdBb0FBUUFBQUFBQUFBQXFFa1FvdlVpTC95VlpnUWNJSkFxQmxpQUlFa1NMLzRrPSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6OTksIm1pbm9yIjo5OSwicGF0Y2giOjk5LCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
