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

namespace Arc56.Generated.akita_protocol.akita_sc.SunsetContract_f250607f
{


    public class SunsetContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public SunsetContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class CloseOutArgCloses : AVMObjectType
            {
                public Algorand.Address Field0 { get; set; }

                public ulong Field1 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static CloseOutArgCloses Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new CloseOutArgCloses();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is Algorand.Address vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is ulong vField1Value) { ret.Field1 = vField1Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as CloseOutArgCloses);
                }
                public bool Equals(CloseOutArgCloses? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(CloseOutArgCloses left, CloseOutArgCloses right)
                {
                    return EqualityComparer<CloseOutArgCloses>.Default.Equals(left, right);
                }
                public static bool operator !=(CloseOutArgCloses left, CloseOutArgCloses right)
                {
                    return !(left == right);
                }

            }

            public class ReclaimWalletEscrowsArgReclaims : AVMObjectType
            {
                public string Field0 { get; set; }

                public ulong Field1 { get; set; }

                public ulong Field2 { get; set; }

                public bool Field3 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField0.From(Field0);
                    stringRef[ret.Count] = vField0.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField2.From(Field2);
                    ret.AddRange(vField2.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vField3.From(Field3);
                    ret.AddRange(vField3.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ReclaimWalletEscrowsArgReclaims Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new ReclaimWalletEscrowsArgReclaims();
                    uint count = 0;
                    var indexField0 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField0.Decode(bytes.Skip(indexField0 + prefixOffset).ToArray());
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is string vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is ulong vField1Value) { ret.Field1 = vField1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is ulong vField2Value) { ret.Field2 = vField2Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField3 = vField3.ToValue();
                    if (valueField3 is bool vField3Value) { ret.Field3 = vField3Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ReclaimWalletEscrowsArgReclaims);
                }
                public bool Equals(ReclaimWalletEscrowsArgReclaims? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ReclaimWalletEscrowsArgReclaims left, ReclaimWalletEscrowsArgReclaims right)
                {
                    return EqualityComparer<ReclaimWalletEscrowsArgReclaims>.Default.Equals(left, right);
                }
                public static bool operator !=(ReclaimWalletEscrowsArgReclaims left, ReclaimWalletEscrowsArgReclaims right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="closeRemainderTo"> </param>
        public async Task Delete(Algorand.Address closeRemainderTo, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 171, 139, 33, 58 };
            var closeRemainderToAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); closeRemainderToAbi.From(closeRemainderTo);

            var result = await base.CallApp(new List<object> { abiHandle, closeRemainderToAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Delete_Transactions(Algorand.Address closeRemainderTo, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 171, 139, 33, 58 };
            var closeRemainderToAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); closeRemainderToAbi.From(closeRemainderTo);

            return await base.MakeTransactionList(new List<object> { abiHandle, closeRemainderToAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="boxes"> </param>
        public async Task DeleteBoxes(byte[][] boxes, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 152, 253, 101, 167 };
            var boxesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>>("byte[]"); boxesAbi.From(boxes);

            var result = await base.CallApp(new List<object> { abiHandle, boxesAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DeleteBoxes_Transactions(byte[][] boxes, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 152, 253, 101, 167 };
            var boxesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>>("byte[]"); boxesAbi.From(boxes);

            return await base.MakeTransactionList(new List<object> { abiHandle, boxesAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="closes"> CloseOutArgCloses</param>
        public async Task CloseOut(Structs.CloseOutArgCloses[] closes, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 150, 37, 234, 217 };
            var closesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.CloseOutArgCloses>(x => Structs.CloseOutArgCloses.Parse(x)) { IsFixedLength = false, FixedLength = 0 }; closesAbi.From(closes);

            var result = await base.CallApp(new List<object> { abiHandle, closesAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CloseOut_Transactions(Structs.CloseOutArgCloses[] closes, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 150, 37, 234, 217 };
            var closesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.CloseOutArgCloses>(x => Structs.CloseOutArgCloses.Parse(x)) { IsFixedLength = false, FixedLength = 0 }; closesAbi.From(closes);

            return await base.MakeTransactionList(new List<object> { abiHandle, closesAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="assets"> </param>
        public async Task DeleteAssets(ulong[] assets, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 199, 216, 16, 20 };
            var assetsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); assetsAbi.From(assets);

            var result = await base.CallApp(new List<object> { abiHandle, assetsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DeleteAssets_Transactions(ulong[] assets, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 199, 216, 16, 20 };
            var assetsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); assetsAbi.From(assets);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="escrowFactory"> </param>
        /// <param name="escrowIds"> </param>
        public async Task DeleteEscrows(ulong escrowFactory, ulong[] escrowIds, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 20, 22, 126, 231 };
            var escrowFactoryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); escrowFactoryAbi.From(escrowFactory);
            var escrowIdsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); escrowIdsAbi.From(escrowIds);

            var result = await base.CallApp(new List<object> { abiHandle, escrowFactoryAbi, escrowIdsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DeleteEscrows_Transactions(ulong escrowFactory, ulong[] escrowIds, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 20, 22, 126, 231 };
            var escrowFactoryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); escrowFactoryAbi.From(escrowFactory);
            var escrowIdsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); escrowIdsAbi.From(escrowIds);

            return await base.MakeTransactionList(new List<object> { abiHandle, escrowFactoryAbi, escrowIdsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="wallet"> </param>
        /// <param name="reclaims"> ReclaimWalletEscrowsArgReclaims</param>
        public async Task ReclaimWalletEscrows(ulong wallet, Structs.ReclaimWalletEscrowsArgReclaims[] reclaims, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 217, 135, 15, 93 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var reclaimsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.ReclaimWalletEscrowsArgReclaims>(x => Structs.ReclaimWalletEscrowsArgReclaims.Parse(x)) { IsFixedLength = false, FixedLength = 0 }; reclaimsAbi.From(reclaims);

            var result = await base.CallApp(new List<object> { abiHandle, walletAbi, reclaimsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ReclaimWalletEscrows_Transactions(ulong wallet, Structs.ReclaimWalletEscrowsArgReclaims[] reclaims, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 217, 135, 15, 93 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var reclaimsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.ReclaimWalletEscrowsArgReclaims>(x => Structs.ReclaimWalletEscrowsArgReclaims.Parse(x)) { IsFixedLength = false, FixedLength = 0 }; reclaimsAbi.From(reclaims);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletAbi, reclaimsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU3Vuc2V0Q29udHJhY3QiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiQ2xvc2VPdXRBcmdDbG9zZXMiOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJ1aW50NjQifV0sIlJlY2xhaW1XYWxsZXRFc2Nyb3dzQXJnUmVjbGFpbXMiOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMiIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDMiLCJ0eXBlIjoiYm9vbCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJkZWxldGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNsb3NlUmVtYWluZGVyVG8iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJEZWxldGVBcHBsaWNhdGlvbiJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImRlbGV0ZUJveGVzIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYm94ZXMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2xvc2VPdXQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKGFkZHJlc3MsdWludDY0KVtdIiwic3RydWN0IjoiQ2xvc2VPdXRBcmdDbG9zZXMiLCJuYW1lIjoiY2xvc2VzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImRlbGV0ZUFzc2V0cyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjRbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0cyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJkZWxldGVFc2Nyb3dzIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImVzY3Jvd0ZhY3RvcnkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NFtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZXNjcm93SWRzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlY2xhaW1XYWxsZXRFc2Nyb3dzIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6IndhbGxldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiKHN0cmluZyx1aW50NjQsdWludDY0LGJvb2wpW10iLCJzdHJ1Y3QiOiJSZWNsYWltV2FsbGV0RXNjcm93c0FyZ1JlY2xhaW1zIiwibmFtZSI6InJlY2xhaW1zIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbNjgwXSwiZXJyb3JNZXNzYWdlIjoiRVJSOmVyck5kYW8iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyOTcsNDI4XSwiZXJyb3JNZXNzYWdlIjoiaW5kZXggYWNjZXNzIGlzIG91dCBvZiBib3VuZHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMzBdLCJlcnJvck1lc3NhZ2UiOiJpbmRleCBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTg3LDUwMV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgZW5jb2RpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTgsMjAxLDI2MiwzMzEsMzk1LDQ3Miw1MjhdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNDJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFzc2V0PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIxOF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8Ynl0ZXM+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjc0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxzbWFydF9jb250cmFjdHMvc3Vuc2V0L3R5cGVzLnRzOjpBc3NldENsb3NlUGFyYW1zPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU0NF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8c21hcnRfY29udHJhY3RzL3N1bnNldC90eXBlcy50czo6V2FsbGV0RXNjcm93UmVjbGFpbT4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MDZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PHVpbnQ2ND4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzg3LDQ2NF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUyNF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdGFpbCBwb2ludGVyIGF0IGluZGV4IDAgb2YgKChsZW4rdXRmOFtdKSx1aW50NjQsdWludDY0LGJvb2wxKSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUwOV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdGFpbCBwb2ludGVyIGZvciAobGVuKygobGVuK3V0ZjhbXSksdWludDY0LHVpbnQ2NCxib29sMSlbXSkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxOTVdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHRhaWwgcG9pbnRlciBmb3IgKGxlbisobGVuK3VpbnQ4W10pW10pIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTE5XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCB0dXBsZSBlbmNvZGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6ImNibG9ja3MifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV6Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDaU53Y21GbmJXRWdZWFYwYjNOaGJIUWdabUZzYzJVS0NpOHZJRUJoYkdkdmNtRnVaR1p2ZFc1a1lYUnBiMjR2WVd4bmIzSmhibVF0ZEhsd1pYTmpjbWx3ZEM5aGNtTTBMMmx1WkdWNExtUXVkSE02T2tOdmJuUnlZV04wTG1Gd2NISnZkbUZzVUhKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXdJREVnTWlBNENpQWdJQ0JpZVhSbFkySnNiMk5ySUZSTlVFeGZVMVZPVTBWVVgwTkJURXhGVWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04xYm5ObGRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXpMVEUwQ2lBZ0lDQXZMeUJBWTI5dWRISmhZM1FvZXlCaGRtMVdaWEp6YVc5dU9pQXhNeUI5S1FvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklGTjFibk5sZEVOdmJuUnlZV04wSUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR0o2SUcxaGFXNWZYMTloYkdkdmRITmZYeTVrWldaaGRXeDBRM0psWVhSbFFERTBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IaGhZamhpTWpFellTQXZMeUJ0WlhSb2IyUWdJbVJsYkdWMFpTaGhaR1J5WlhOektYWnZhV1FpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCdFlXbHVYMlJsYkdWMFpWOXliM1YwWlVBekNncHRZV2x1WDNOM2FYUmphRjlqWVhObFgyNWxlSFJBTkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZFc1elpYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNeTB4TkFvZ0lDQWdMeThnUUdOdmJuUnlZV04wS0hzZ1lYWnRWbVZ5YzJsdmJqb2dNVE1nZlNrS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QlRkVzV6WlhSRGIyNTBjbUZqZENCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdjSFZ6YUdKNWRHVnpjeUF3ZURrNFptUTJOV0UzSURCNE9UWXlOV1ZoWkRrZ01IaGpOMlE0TVRBeE5DQXdlREUwTVRZM1pXVTNJREI0WkRrNE56Qm1OV1FnTHk4Z2JXVjBhRzlrSUNKa1pXeGxkR1ZDYjNobGN5aGllWFJsVzExYlhTbDJiMmxrSWl3Z2JXVjBhRzlrSUNKamJHOXpaVTkxZENnb1lXUmtjbVZ6Y3l4MWFXNTBOalFwVzEwcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWkdWc1pYUmxRWE56WlhSektIVnBiblEyTkZ0ZEtYWnZhV1FpTENCdFpYUm9iMlFnSW1SbGJHVjBaVVZ6WTNKdmQzTW9kV2x1ZERZMExIVnBiblEyTkZ0ZEtYWnZhV1FpTENCdFpYUm9iMlFnSW5KbFkyeGhhVzFYWVd4c1pYUkZjMk55YjNkektIVnBiblEyTkN3b2MzUnlhVzVuTEhWcGJuUTJOQ3gxYVc1ME5qUXNZbTl2YkNsYlhTbDJiMmxrSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ1pHVnNaWFJsUW05NFpYTWdZMnh2YzJWUGRYUWdaR1ZzWlhSbFFYTnpaWFJ6SUdSbGJHVjBaVVZ6WTNKdmQzTWdjbVZqYkdGcGJWZGhiR3hsZEVWelkzSnZkM01LSUNBZ0lHVnljZ29LYldGcGJsOWtaV3hsZEdWZmNtOTFkR1ZBTXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZFc1elpYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNd29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUdGc2JHOTNRV04wYVc5dWN6b2dXeWRFWld4bGRHVkJjSEJzYVdOaGRHbHZiaWRkSUgwcENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCd2RYTm9hVzUwSURVZ0x5OGdSR1ZzWlhSbFFYQndiR2xqWVhScGIyNEtJQ0FnSUQwOUNpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0ppWUtJQ0FnSUdGemMyVnlkQW9nSUNBZ1lpQmtaV3hsZEdVS0NtMWhhVzVmWDE5aGJHZHZkSE5mWHk1a1pXWmhkV3gwUTNKbFlYUmxRREUwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04xYm5ObGRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXpMVEUwQ2lBZ0lDQXZMeUJBWTI5dWRISmhZM1FvZXlCaGRtMVdaWEp6YVc5dU9pQXhNeUI5S1FvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklGTjFibk5sZEVOdmJuUnlZV04wSUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNFS0lDQWdJQ1ltQ2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJmY0hWNVlWOXNhV0l1WVhKak5DNWtlVzVoYldsalgyRnljbUY1WDNKbFlXUmZaSGx1WVcxcFkxOWxiR1Z0Wlc1MEtHRnljbUY1T2lCaWVYUmxjeXdnYVc1a1pYZzZJSFZwYm5RMk5Da2dMVDRnWW5sMFpYTTZDbVI1Ym1GdGFXTmZZWEp5WVhsZmNtVmhaRjlrZVc1aGJXbGpYMlZzWlcxbGJuUTZDaUFnSUNCd2NtOTBieUF5SURFS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0FxQ2lBZ0lDQmthV2NnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR1JwWnlBeUNpQWdJQ0JzWlc0S0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJQ29LSUNBZ0lHUnBaeUExQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJQzBLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjFibk5sZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwVGRXNXpaWFJEYjI1MGNtRmpkQzVrWld4bGRHVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BrWld4bGRHVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzVnVjMlYwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpNS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2V5QmhiR3h2ZDBGamRHbHZibk02SUZzblJHVnNaWFJsUVhCd2JHbGpZWFJwYjI0blhTQjlLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMWJuTmxkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakkxQ2lBZ0lDQXZMeUIwYUdsekxtRjFkR2dvS1FvZ0lDQWdZMkZzYkhOMVlpQmhkWFJvQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1Z1YzJWMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qWUtJQ0FnSUM4dklHbDBlRzR1Y0dGNWJXVnVkQ2g3SUdOc2IzTmxVbVZ0WVdsdVpHVnlWRzhnZlNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRMnh2YzJWU1pXMWhhVzVrWlhKVWJ3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRXNXpaWFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TXdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lHRnNiRzkzUVdOMGFXOXVjem9nV3lkRVpXeGxkR1ZCY0hCc2FXTmhkR2x2YmlkZElIMHBDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMWJuTmxkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBUZFc1elpYUkRiMjUwY21GamRDNWtaV3hsZEdWQ2IzaGxjMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21SbGJHVjBaVUp2ZUdWek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMWJuTmxkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakk1Q2lBZ0lDQXZMeUJrWld4bGRHVkNiM2hsY3loaWIzaGxjem9nWW5sMFpYTmJYU2s2SUhadmFXUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JwYm5Salh6SWdMeThnTWdvZ0lDQWdLZ29nSUNBZ2MzZGhjQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb0taR1ZzWlhSbFFtOTRaWE5mWm05eVgyaGxZV1JsY2tBeE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMWJuTmxkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakk1Q2lBZ0lDQXZMeUJrWld4bGRHVkNiM2hsY3loaWIzaGxjem9nWW5sMFpYTmJYU2s2SUhadmFXUWdld29nSUNBZ1pIVndDaUFnSUNCa2FXY2dOUW9nSUNBZ1BBb2dJQ0FnWW5vZ1pHVnNaWFJsUW05NFpYTmZZV1owWlhKZlptOXlRRFFLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUNvS0lDQWdJR1JwWnlBeUNpQWdJQ0JrZFhBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnWlc1amIyUnBibWNLSUNBZ0lHUjFjQW9nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlEUUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0IwWVdsc0lIQnZhVzUwWlhJZ1ptOXlJQ2hzWlc0cktHeGxiaXQxYVc1ME9GdGRLVnRkS1FvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQXJDaUFnSUNBckNpQWdJQ0JqYjNabGNpQXlDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdZaUJrWld4bGRHVkNiM2hsYzE5bWIzSmZhR1ZoWkdWeVFERUtDbVJsYkdWMFpVSnZlR1Z6WDJGbWRHVnlYMlp2Y2tBME9nb2dJQ0FnY0c5d0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNWdWMyVjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNamtLSUNBZ0lDOHZJR1JsYkdWMFpVSnZlR1Z6S0dKdmVHVnpPaUJpZVhSbGMxdGRLVG9nZG05cFpDQjdDaUFnSUNCemQyRndDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlubDBaWE0rQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1Z1YzJWMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16QUtJQ0FnSUM4dklIUm9hWE11WVhWMGFDZ3BDaUFnSUNCallXeHNjM1ZpSUdGMWRHZ0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRXNXpaWFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TVFvZ0lDQWdMeThnWm05eUlDaHNaWFFnYVRvZ2RXbHVkRFkwSUQwZ01Ec2dhU0E4SUdKdmVHVnpMbXhsYm1kMGFEc2dhU3NyS1NCN0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvS1pHVnNaWFJsUW05NFpYTmZkMmhwYkdWZmRHOXdRRFk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1Z1YzJWMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16RUtJQ0FnSUM4dklHWnZjaUFvYkdWMElHazZJSFZwYm5RMk5DQTlJREE3SUdrZ1BDQmliM2hsY3k1c1pXNW5kR2c3SUdrckt5a2dld29nSUNBZ1pIVndDaUFnSUNCa2FXY2dNd29nSUNBZ1BBb2dJQ0FnWkhWd0NpQWdJQ0JpZWlCa1pXeGxkR1ZDYjNobGMxOWhablJsY2w5M2FHbHNaVUE0Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzVrWlhnZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnS2dvZ0lDQWdaR2xuSURJS0lDQWdJR1IxY0FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ1pIVndNZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNBckNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjFibk5sZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNeUNpQWdJQ0F2THlCdmNDNUNiM2d1WkdWc1pYUmxLR0p2ZUdWelcybGRLUW9nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjFibk5sZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNeENpQWdJQ0F2THlCbWIzSWdLR3hsZENCcE9pQjFhVzUwTmpRZ1BTQXdPeUJwSUR3Z1ltOTRaWE11YkdWdVozUm9PeUJwS3lzcElIc0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0FyQ2lBZ0lDQmlJR1JsYkdWMFpVSnZlR1Z6WDNkb2FXeGxYM1J2Y0VBMkNncGtaV3hsZEdWQ2IzaGxjMTloWm5SbGNsOTNhR2xzWlVBNE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMWJuTmxkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakk1Q2lBZ0lDQXZMeUJrWld4bGRHVkNiM2hsY3loaWIzaGxjem9nWW5sMFpYTmJYU2s2SUhadmFXUWdld29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRXNXpaWFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VTNWdWMyVjBRMjl1ZEhKaFkzUXVZMnh2YzJWUGRYUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BqYkc5elpVOTFkRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkVzV6WlhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek5nb2dJQ0FnTHk4Z1kyeHZjMlZQZFhRb1kyeHZjMlZ6T2lCQmMzTmxkRU5zYjNObFVHRnlZVzF6VzEwcE9pQjJiMmxrSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0c0Z01nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjSFZ6YUdsdWRDQTBNQW9nSUNBZ0tnb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJQ3NLSUNBZ0lITjNZWEFLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBITnRZWEowWDJOdmJuUnlZV04wY3k5emRXNXpaWFF2ZEhsd1pYTXVkSE02T2tGemMyVjBRMnh2YzJWUVlYSmhiWE0rQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1Z1YzJWMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16Y0tJQ0FnSUM4dklIUm9hWE11WVhWMGFDZ3BDaUFnSUNCallXeHNjM1ZpSUdGMWRHZ0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRXNXpaWFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96T0FvZ0lDQWdMeThnWm05eUlDaHNaWFFnYVRvZ2RXbHVkRFkwSUQwZ01Ec2dhU0E4SUdOc2IzTmxjeTVzWlc1bmRHZzdJR2tyS3lrZ2V3b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0NtTnNiM05sVDNWMFgzZG9hV3hsWDNSdmNFQXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjFibk5sZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNNENpQWdJQ0F2THlCbWIzSWdLR3hsZENCcE9pQjFhVzUwTmpRZ1BTQXdPeUJwSUR3Z1kyeHZjMlZ6TG14bGJtZDBhRHNnYVNzcktTQjdDaUFnSUNCa2RYQUtJQ0FnSUdScFp5QXlDaUFnSUNBOENpQWdJQ0JpZWlCamJHOXpaVTkxZEY5aFpuUmxjbDkzYUdsc1pVQTFDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzVnVjMlYwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXprS0lDQWdJQzh2SUdOdmJuTjBJSHNnWVhOelpYUkRiRzl6WlZSdkxDQjRabVZ5UVhOelpYUWdmU0E5SUdOc2IyNWxLR05zYjNObGMxdHBYU2tLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ1pHbG5JREVLSUNBZ0lIQjFjMmhwYm5RZ05EQUtJQ0FnSUNvS0lDQWdJSEIxYzJocGJuUWdOREFLSUNBZ0lHVjRkSEpoWTNReklDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQmhZMk5sYzNNZ2FYTWdiM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdaSFZ3Q2lBZ0lDQmxlSFJ5WVdOMElEQWdNeklLSUNBZ0lITjNZWEFLSUNBZ0lIQjFjMmhwYm5RZ016SUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzVnVjMlYwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRBS0lDQWdJQzh2SUdsMGVHNHVZWE56WlhSVWNtRnVjMlpsY2loN0lHRnpjMlYwUTJ4dmMyVlVieXdnZUdabGNrRnpjMlYwSUgwcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRmhtWlhKQmMzTmxkQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjM05sZEVOc2IzTmxWRzhLSUNBZ0lIQjFjMmhwYm5RZ05Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjFibk5sZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNNENpQWdJQ0F2THlCbWIzSWdLR3hsZENCcE9pQjFhVzUwTmpRZ1BTQXdPeUJwSUR3Z1kyeHZjMlZ6TG14bGJtZDBhRHNnYVNzcktTQjdDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdZaUJqYkc5elpVOTFkRjkzYUdsc1pWOTBiM0JBTWdvS1kyeHZjMlZQZFhSZllXWjBaWEpmZDJocGJHVkFOVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkVzV6WlhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek5nb2dJQ0FnTHk4Z1kyeHZjMlZQZFhRb1kyeHZjMlZ6T2lCQmMzTmxkRU5zYjNObFVHRnlZVzF6VzEwcE9pQjJiMmxrSUhzS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1Z1YzJWMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9sTjFibk5sZEVOdmJuUnlZV04wTG1SbGJHVjBaVUZ6YzJWMGMxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbVJsYkdWMFpVRnpjMlYwY3pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZFc1elpYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBOQW9nSUNBZ0x5OGdaR1ZzWlhSbFFYTnpaWFJ6S0dGemMyVjBjem9nUVhOelpYUmJYU2s2SUhadmFXUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndiaUF5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnS2dvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lDc0tJQ0FnSUhOM1lYQUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGemMyVjBQZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjFibk5sZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRMUNpQWdJQ0F2THlCMGFHbHpMbUYxZEdnb0tRb2dJQ0FnWTJGc2JITjFZaUJoZFhSb0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNWdWMyVjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORFlLSUNBZ0lDOHZJR1p2Y2lBb2JHVjBJR2s2SUhWcGJuUTJOQ0E5SURBN0lHa2dQQ0JoYzNObGRITXViR1Z1WjNSb095QnBLeXNwSUhzS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2dwa1pXeGxkR1ZCYzNObGRITmZkMmhwYkdWZmRHOXdRREk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1Z1YzJWMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5EWUtJQ0FnSUM4dklHWnZjaUFvYkdWMElHazZJSFZwYm5RMk5DQTlJREE3SUdrZ1BDQmhjM05sZEhNdWJHVnVaM1JvT3lCcEt5c3BJSHNLSUNBZ0lHUjFjQW9nSUNBZ1pHbG5JRElLSUNBZ0lEd0tJQ0FnSUdKNklHUmxiR1YwWlVGemMyVjBjMTloWm5SbGNsOTNhR2xzWlVBMUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNWdWMyVjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORGNLSUNBZ0lDOHZJR2wwZUc0dVlYTnpaWFJEYjI1bWFXY29leUJqYjI1bWFXZEJjM05sZERvZ1lYTnpaWFJ6VzJsZElIMHBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0JrYVdjZ01nb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdLZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRMjl1Wm1sblFYTnpaWFFLSUNBZ0lIQjFjMmhwYm5RZ013b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjFibk5sZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRMkNpQWdJQ0F2THlCbWIzSWdLR3hsZENCcE9pQjFhVzUwTmpRZ1BTQXdPeUJwSUR3Z1lYTnpaWFJ6TG14bGJtZDBhRHNnYVNzcktTQjdDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdZaUJrWld4bGRHVkJjM05sZEhOZmQyaHBiR1ZmZEc5d1FESUtDbVJsYkdWMFpVRnpjMlYwYzE5aFpuUmxjbDkzYUdsc1pVQTFPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjFibk5sZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRMENpQWdJQ0F2THlCa1pXeGxkR1ZCYzNObGRITW9ZWE56WlhSek9pQkJjM05sZEZ0ZEtUb2dkbTlwWkNCN0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04xYm5ObGRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcFRkVzV6WlhSRGIyNTBjbUZqZEM1a1pXeGxkR1ZGYzJOeWIzZHpXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWkdWc1pYUmxSWE5qY205M2N6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRXNXpaWFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xTVFvZ0lDQWdMeThnWkdWc1pYUmxSWE5qY205M2N5aGxjMk55YjNkR1lXTjBiM0o1T2lCQmNIQnNhV05oZEdsdmJpd2daWE5qY205M1NXUnpPaUIxYVc1ME5qUmJYU2s2SUhadmFXUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3YmlBeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ0tnb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJQ3NLSUNBZ0lITjNZWEFLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBIVnBiblEyTkQ0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZFc1elpYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFNZ29nSUNBZ0x5OGdkR2hwY3k1aGRYUm9LQ2tLSUNBZ0lHTmhiR3h6ZFdJZ1lYVjBhQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjFibk5sZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVekNpQWdJQ0F2THlCbWIzSWdLR3hsZENCcE9pQjFhVzUwTmpRZ1BTQXdPeUJwSUR3Z1pYTmpjbTkzU1dSekxteGxibWQwYURzZ2FTc3JLU0I3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9LWkdWc1pYUmxSWE5qY205M2MxOTNhR2xzWlY5MGIzQkFNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkVzV6WlhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU13b2dJQ0FnTHk4Z1ptOXlJQ2hzWlhRZ2FUb2dkV2x1ZERZMElEMGdNRHNnYVNBOElHVnpZM0p2ZDBsa2N5NXNaVzVuZEdnN0lHa3JLeWtnZXdvZ0lDQWdaSFZ3Q2lBZ0lDQmthV2NnTWdvZ0lDQWdQQW9nSUNBZ1lub2daR1ZzWlhSbFJYTmpjbTkzYzE5aFpuUmxjbDkzYUdsc1pVQTFDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzVnVjMlYwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRRdE5UY0tJQ0FnSUM4dklHRmlhVU5oYkd3OGRIbHdaVzltSUVWelkzSnZkMFpoWTNSdmNua3VjSEp2ZEc5MGVYQmxMbVJsYkdWMFpUNG9ld29nSUNBZ0x5OGdJQ0JoY0hCSlpEb2daWE5qY205M1JtRmpkRzl5ZVN3S0lDQWdJQzh2SUNBZ1lYSm5jem9nVzJWelkzSnZkMGxrYzF0cFhWMHNDaUFnSUNBdkx5QjlLUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMWJuTmxkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalUyQ2lBZ0lDQXZMeUJoY21kek9pQmJaWE5qY205M1NXUnpXMmxkWFN3S0lDQWdJR1JwWnlBeUNpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdaR2xuSURFS0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQXFDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnWlhoMGNtRmpkRE1nTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUdGalkyVnpjeUJwY3lCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCa2FXY2dOQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1Z1YzJWMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5UUXROVGNLSUNBZ0lDOHZJR0ZpYVVOaGJHdzhkSGx3Wlc5bUlFVnpZM0p2ZDBaaFkzUnZjbmt1Y0hKdmRHOTBlWEJsTG1SbGJHVjBaVDRvZXdvZ0lDQWdMeThnSUNCaGNIQkpaRG9nWlhOamNtOTNSbUZqZEc5eWVTd0tJQ0FnSUM4dklDQWdZWEpuY3pvZ1cyVnpZM0p2ZDBsa2MxdHBYVjBzQ2lBZ0lDQXZMeUI5S1FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0T0dFek9XVTNPV1lnTHk4Z2JXVjBhRzlrSUNKa1pXeGxkR1VvZFdsdWREWTBLWFp2YVdRaUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJSEIxYzJocGJuUWdOaUF2THlCaGNIQnNDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1Z1YzJWMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5UTUtJQ0FnSUM4dklHWnZjaUFvYkdWMElHazZJSFZwYm5RMk5DQTlJREE3SUdrZ1BDQmxjMk55YjNkSlpITXViR1Z1WjNSb095QnBLeXNwSUhzS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCaUlHUmxiR1YwWlVWelkzSnZkM05mZDJocGJHVmZkRzl3UURJS0NtUmxiR1YwWlVWelkzSnZkM05mWVdaMFpYSmZkMmhwYkdWQU5Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRXNXpaWFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xTVFvZ0lDQWdMeThnWkdWc1pYUmxSWE5qY205M2N5aGxjMk55YjNkR1lXTjBiM0o1T2lCQmNIQnNhV05oZEdsdmJpd2daWE5qY205M1NXUnpPaUIxYVc1ME5qUmJYU2s2SUhadmFXUWdld29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRXNXpaWFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VTNWdWMyVjBRMjl1ZEhKaFkzUXVjbVZqYkdGcGJWZGhiR3hsZEVWelkzSnZkM05iY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dweVpXTnNZV2x0VjJGc2JHVjBSWE5qY205M2N6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRXNXpaWFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTVFvZ0lDQWdMeThnY21WamJHRnBiVmRoYkd4bGRFVnpZM0p2ZDNNb2QyRnNiR1YwT2lCQmNIQnNhV05oZEdsdmJpd2djbVZqYkdGcGJYTTZJRmRoYkd4bGRFVnpZM0p2ZDFKbFkyeGhhVzFiWFNrNklIWnZhV1FnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd2JpQXlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JwYm5Salh6SWdMeThnTWdvZ0lDQWdLZ29nSUNBZ2MzZGhjQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb0tjbVZqYkdGcGJWZGhiR3hsZEVWelkzSnZkM05mWm05eVgyaGxZV1JsY2tBeE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMWJuTmxkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPall4Q2lBZ0lDQXZMeUJ5WldOc1lXbHRWMkZzYkdWMFJYTmpjbTkzY3loM1lXeHNaWFE2SUVGd2NHeHBZMkYwYVc5dUxDQnlaV05zWVdsdGN6b2dWMkZzYkdWMFJYTmpjbTkzVW1WamJHRnBiVnRkS1RvZ2RtOXBaQ0I3Q2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUExQ2lBZ0lDQThDaUFnSUNCaWVpQnlaV05zWVdsdFYyRnNiR1YwUlhOamNtOTNjMTloWm5SbGNsOW1iM0pBTkFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNZ29nSUNBZ0tnb2dJQ0FnWkdsbklESUtJQ0FnSUdSMWNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCbGJtTnZaR2x1WndvZ0lDQWdaSFZ3Q2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdOQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUhSaGFXd2djRzlwYm5SbGNpQm1iM0lnS0d4bGJpc29LR3hsYml0MWRHWTRXMTBwTEhWcGJuUTJOQ3gxYVc1ME5qUXNZbTl2YkRFcFcxMHBDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdaR2xuSURFS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQjBkWEJzWlNCbGJtTnZaR2x1WndvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElERTVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnZEdGcGJDQndiMmx1ZEdWeUlHRjBJR2x1WkdWNElEQWdiMllnS0Noc1pXNHJkWFJtT0Z0ZEtTeDFhVzUwTmpRc2RXbHVkRFkwTEdKdmIyd3hLUW9nSUNBZ2MzZGhjQW9nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lIQjFjMmhwYm5RZ01qRUtJQ0FnSUNzS0lDQWdJQ3NLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCaUlISmxZMnhoYVcxWFlXeHNaWFJGYzJOeWIzZHpYMlp2Y2w5b1pXRmtaWEpBTVFvS2NtVmpiR0ZwYlZkaGJHeGxkRVZ6WTNKdmQzTmZZV1owWlhKZlptOXlRRFE2Q2lBZ0lDQndiM0J1SURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZFc1elpYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJNUW9nSUNBZ0x5OGdjbVZqYkdGcGJWZGhiR3hsZEVWelkzSnZkM01vZDJGc2JHVjBPaUJCY0hCc2FXTmhkR2x2Yml3Z2NtVmpiR0ZwYlhNNklGZGhiR3hsZEVWelkzSnZkMUpsWTJ4aGFXMWJYU2s2SUhadmFXUWdld29nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUNzS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHh6YldGeWRGOWpiMjUwY21GamRITXZjM1Z1YzJWMEwzUjVjR1Z6TG5Sek9qcFhZV3hzWlhSRmMyTnliM2RTWldOc1lXbHRQZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjFibk5sZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZeUNpQWdJQ0F2THlCMGFHbHpMbUYxZEdnb0tRb2dJQ0FnWTJGc2JITjFZaUJoZFhSb0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNWdWMyVjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOak1LSUNBZ0lDOHZJR1p2Y2lBb2JHVjBJR2s2SUhWcGJuUTJOQ0E5SURBN0lHa2dQQ0J5WldOc1lXbHRjeTVzWlc1bmRHZzdJR2tyS3lrZ2V3b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0NuSmxZMnhoYVcxWFlXeHNaWFJGYzJOeWIzZHpYM2RvYVd4bFgzUnZjRUEyT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04xYm5ObGRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWXpDaUFnSUNBdkx5Qm1iM0lnS0d4bGRDQnBPaUIxYVc1ME5qUWdQU0F3T3lCcElEd2djbVZqYkdGcGJYTXViR1Z1WjNSb095QnBLeXNwSUhzS0lDQWdJR1IxY0FvZ0lDQWdaR2xuSURJS0lDQWdJRHdLSUNBZ0lHSjZJSEpsWTJ4aGFXMVhZV3hzWlhSRmMyTnliM2R6WDJGbWRHVnlYM2RvYVd4bFFEa0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRXNXpaWFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTmdvZ0lDQWdMeThnWVhOelpYUTZJSEpsWTJ4aGFXMHVZWE56WlhRc0NpQWdJQ0JrYVdjZ01nb2dJQ0FnWkhWd0NpQWdJQ0JrYVdjZ01nb2dJQ0FnWTJGc2JITjFZaUJrZVc1aGJXbGpYMkZ5Y21GNVgzSmxZV1JmWkhsdVlXMXBZMTlsYkdWdFpXNTBDaUFnSUNCbGVIUnlZV04wSURJZ09Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMWJuTmxkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalkzQ2lBZ0lDQXZMeUJoYlc5MWJuUTZJSEpsWTJ4aGFXMHVZVzF2ZFc1MExBb2dJQ0FnWkdsbklERUtJQ0FnSUdScFp5QXpDaUFnSUNCallXeHNjM1ZpSUdSNWJtRnRhV05mWVhKeVlYbGZjbVZoWkY5a2VXNWhiV2xqWDJWc1pXMWxiblFLSUNBZ0lHVjRkSEpoWTNRZ01UQWdPQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjFibk5sZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZNENpQWdJQ0F2THlCamJHOXpaVTkxZERvZ2NtVmpiR0ZwYlM1amJHOXpaVTkxZEN3S0lDQWdJR1JwWnlBeUNpQWdJQ0JrYVdjZ05Bb2dJQ0FnWTJGc2JITjFZaUJrZVc1aGJXbGpYMkZ5Y21GNVgzSmxZV1JmWkhsdVlXMXBZMTlsYkdWdFpXNTBDaUFnSUNCd2RYTm9hVzUwSURFME5Bb2dJQ0FnWjJWMFltbDBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzVnVjMlYwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpVdE5qa0tJQ0FnSUM4dklHTnZibk4wSUhkaGJHeGxkRkpsWTJ4aGFXMXpPaUJGYzJOeWIzZFNaV05zWVdsdFcxMGdQU0JiZXdvZ0lDQWdMeThnSUNCaGMzTmxkRG9nY21WamJHRnBiUzVoYzNObGRDd0tJQ0FnSUM4dklDQWdZVzF2ZFc1ME9pQnlaV05zWVdsdExtRnRiM1Z1ZEN3S0lDQWdJQzh2SUNBZ1kyeHZjMlZQZFhRNklISmxZMnhoYVcwdVkyeHZjMlZQZFhRc0NpQWdJQ0F2THlCOVhRb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TUFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnYzJWMFltbDBDaUFnSUNCamIyNWpZWFFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TURFS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMWJuTmxkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamN3TFRjekNpQWdJQ0F2THlCaFltbERZV3hzUEhSNWNHVnZaaUJCWW5OMGNtRmpkR1ZrUVdOamIzVnVkQzV3Y205MGIzUjVjR1V1WVhKak5UaGZjbVZqYkdGcGJUNG9ld29nSUNBZ0x5OGdJQ0JoY0hCSlpEb2dkMkZzYkdWMExBb2dJQ0FnTHk4Z0lDQmhjbWR6T2lCYmNtVmpiR0ZwYlM1bGMyTnliM2NzSUhkaGJHeGxkRkpsWTJ4aGFXMXpYU3dLSUNBZ0lDOHZJSDBwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzVnVjMlYwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnpJS0lDQWdJQzh2SUdGeVozTTZJRnR5WldOc1lXbHRMbVZ6WTNKdmR5d2dkMkZzYkdWMFVtVmpiR0ZwYlhOZExBb2dJQ0FnYzNkaGNBb2dJQ0FnWkdsbklESUtJQ0FnSUdOaGJHeHpkV0lnWkhsdVlXMXBZMTloY25KaGVWOXlaV0ZrWDJSNWJtRnRhV05mWld4bGJXVnVkQW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR1JwWnlBMUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRXNXpaWFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zTUMwM013b2dJQ0FnTHk4Z1lXSnBRMkZzYkR4MGVYQmxiMllnUVdKemRISmhZM1JsWkVGalkyOTFiblF1Y0hKdmRHOTBlWEJsTG1GeVl6VTRYM0psWTJ4aGFXMCtLSHNLSUNBZ0lDOHZJQ0FnWVhCd1NXUTZJSGRoYkd4bGRDd0tJQ0FnSUM4dklDQWdZWEpuY3pvZ1czSmxZMnhoYVcwdVpYTmpjbTkzTENCM1lXeHNaWFJTWldOc1lXbHRjMTBzQ2lBZ0lDQXZMeUI5S1FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0WldKaFpqRTBZVEFnTHk4Z2JXVjBhRzlrSUNKaGNtTTFPRjl5WldOc1lXbHRLSE4wY21sdVp5d29kV2x1ZERZMExIVnBiblEyTkN4aWIyOXNLVnRkS1hadmFXUWlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQndkWE5vYVc1MElEWWdMeThnWVhCd2JBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjFibk5sZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZekNpQWdJQ0F2THlCbWIzSWdLR3hsZENCcE9pQjFhVzUwTmpRZ1BTQXdPeUJwSUR3Z2NtVmpiR0ZwYlhNdWJHVnVaM1JvT3lCcEt5c3BJSHNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBckNpQWdJQ0JpSUhKbFkyeGhhVzFYWVd4c1pYUkZjMk55YjNkelgzZG9hV3hsWDNSdmNFQTJDZ3B5WldOc1lXbHRWMkZzYkdWMFJYTmpjbTkzYzE5aFpuUmxjbDkzYUdsc1pVQTVPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjFibk5sZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZeENpQWdJQ0F2THlCeVpXTnNZV2x0VjJGc2JHVjBSWE5qY205M2N5aDNZV3hzWlhRNklFRndjR3hwWTJGMGFXOXVMQ0J5WldOc1lXbHRjem9nVjJGc2JHVjBSWE5qY205M1VtVmpiR0ZwYlZ0ZEtUb2dkbTlwWkNCN0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04xYm5ObGRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcFRkVzV6WlhSRGIyNTBjbUZqZEM1aGRYUm9LQ2tnTFQ0Z2RtOXBaRG9LWVhWMGFEb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRXNXpaWFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94T0FvZ0lDQWdMeThnS0ZSNGJpNXpaVzVrWlhJZ1BUMDlJRWRzYjJKaGJDNWpjbVZoZEc5eVFXUmtjbVZ6Y3lCOGZDQlVlRzR1YzJWdVpHVnlJRDA5UFNCemRXNXpaWFJEWVd4c1pYSXBMQW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWjJ4dlltRnNJRU55WldGMGIzSkJaR1J5WlhOekNpQWdJQ0E5UFFvZ0lDQWdZbTU2SUdGMWRHaGZZbTl2YkY5MGNuVmxRRElLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdKNWRHVmpYekFnTHk4Z1ZFMVFURjlUVlU1VFJWUmZRMEZNVEVWU0NpQWdJQ0E5UFFvZ0lDQWdZbm9nWVhWMGFGOWliMjlzWDJaaGJITmxRRE1LQ21GMWRHaGZZbTl2YkY5MGNuVmxRREk2Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9LWVhWMGFGOWliMjlzWDIxbGNtZGxRRFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1Z1YzJWMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UY3RNakFLSUNBZ0lDOHZJR3h2WjJkbFpFRnpjMlZ5ZENnS0lDQWdJQzh2SUNBZ0tGUjRiaTV6Wlc1a1pYSWdQVDA5SUVkc2IySmhiQzVqY21WaGRHOXlRV1JrY21WemN5QjhmQ0JVZUc0dWMyVnVaR1Z5SUQwOVBTQnpkVzV6WlhSRFlXeHNaWElwTEFvZ0lDQWdMeThnSUNCbGNuSk9iM1JCYTJsMFlVUmhid29nSUNBZ0x5OGdLUW9nSUNBZ1ltNTZJR0YxZEdoZllXWjBaWEpmWVhOelpYSjBRRFlLSUNBZ0lIQjFjMmhpZVhSbGN5QWlSVkpTT21WeWNrNWtZVzhpQ2lBZ0lDQnNiMmNLSUNBZ0lHVnljaUF2THlCRlVsSTZaWEp5VG1SaGJ3b0tZWFYwYUY5aFpuUmxjbDloYzNObGNuUkFOam9LSUNBZ0lISmxkSE4xWWdvS1lYVjBhRjlpYjI5c1gyWmhiSE5sUURNNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZaUJoZFhSb1gySnZiMnhmYldWeVoyVkFOQW89IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXpDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENpTndjbUZuYldFZ1lYVjBiM05oYkhRZ1ptRnNjMlVLQ2k4dklFQmhiR2R2Y21GdVpHWnZkVzVrWVhScGIyNHZZV3huYjNKaGJtUXRkSGx3WlhOamNtbHdkQzlpWVhObExXTnZiblJ5WVdOMExtUXVkSE02T2tKaGMyVkRiMjUwY21GamRDNWpiR1ZoY2xOMFlYUmxVSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJEU0FFQUFFQ0NDWUJBREViUVpRQmdBU3JpeUU2TmhvQWpnRUFNakVaRkVReEdFU0NCUVNZL1dXbkJKWWw2dGtFeDlnUUZBUVVGbjduQk5tSEQxMDJHZ0NPQlFCV0FMMEJBZ0U1QVlZQU1SbUJCUkl4R0JCRVFtUXhHUlF4R0JRUVE0b0NBWXYrVndJQWkvNGlXWXYvSkF0TEFreFpTd0lWaS84akNFa2tDMHNGVEZsUEJFOENDVTFTaVRZYUFVa1ZnU0FTUklqNkI3R3lDU095RUNLeUFiTWpRellhQVVraVdVbE9BaVFMVEVrVlRnSlhBZ0FpU1VzRkRFRkFTU1FMU3dKSlR3SlpTVThGU1U0RUVrUkxBUlZTSWxra0NBaE9BaU1JUWtkSVRDUUlUd0lTUklqWUJpSkpTd01NU1VFd1JFa2tDMHNDU1U4Q1dVcFpKQWhZVndJQXZFZ2pDRUk1STBNMkdnRkhBaUpaU1U0Q2dTZ0xKQWhNRlJKRWlPZ0ZJa2xMQWd4QlRFc0NWd0lBU3dHQktBdUJLRmhKVndBZ1RJRWdXN0d5RWJJVmdRU3lFQ0t5QWJNakNFSlRJME0yR2dGSEFpSlpTVTRDSlFza0NFd1ZFa1NJNEFRaVNVc0NERUV5c1VzQ1Z3SUFTd0VsQzF1eUlZRURzaEFpc2dHekl3aENPU05ETmhvQlNSVWxFa1FYTmhvQ1J3SWlXVWxPQWlVTEpBaE1GUkpFaU9BRElrbExBZ3hCVExGTEFsY0NBRXNCSlFzbFdFc0VzaGlBQklvNTU1K3lHcklhZ1FheUVDS3lBYk1qQ0VKVEkwTTJHZ0ZKRlNVU1JCYzJHZ0pIQWlKWlNVNENKQXRNU1JWT0FsY0NBQ0pKU3dVTVFWeEpKQXRMQWtsUEFsbEpUd1ZKVGdRU1JFc0JGVkpKRlVzQklsbEpnUk1TUkV4U0lsbUJGUWdJVGdJakNFSmpSZ0lrQ0JKRWlNd0JJa2xMQWd4QnVBRkxBa2xMQW9pekIxY0NDRXNCU3dPSXh3ZFhDZ2hMQWtzRWlOc0hnWkFCVTA0Q1VJQUJBQ0pQQTFSUWdBSUFBVXhRc1V4TEFvaVRDRWtpV1VzQkZWSkxCYklZZ0FUcnJ4U2dzaHF5R3JJYWdRYXlFQ0t5QWJNakNFSy9BU05ETVFBeUNSSkFEREVBS0JKQkppTkFIb0FMUlZKU09tVnljazVrWVcrd0FJa2lRaVU9IiwiY2xlYXIiOiJEWUVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6MTAsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7IlNVTlNFVF9DQUxMRVIiOnsidHlwZSI6ImFkZHJlc3MiLCJ2YWx1ZSI6bnVsbH19LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
