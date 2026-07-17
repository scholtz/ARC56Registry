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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU3Vuc2V0Q29udHJhY3QiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiQ2xvc2VPdXRBcmdDbG9zZXMiOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJ1aW50NjQifV0sIlJlY2xhaW1XYWxsZXRFc2Nyb3dzQXJnUmVjbGFpbXMiOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMiIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDMiLCJ0eXBlIjoiYm9vbCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJkZWxldGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNsb3NlUmVtYWluZGVyVG8iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJEZWxldGVBcHBsaWNhdGlvbiJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImRlbGV0ZUJveGVzIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYm94ZXMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2xvc2VPdXQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKGFkZHJlc3MsdWludDY0KVtdIiwic3RydWN0IjoiQ2xvc2VPdXRBcmdDbG9zZXMiLCJuYW1lIjoiY2xvc2VzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImRlbGV0ZUFzc2V0cyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjRbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0cyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJkZWxldGVFc2Nyb3dzIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImVzY3Jvd0ZhY3RvcnkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NFtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZXNjcm93SWRzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlY2xhaW1XYWxsZXRFc2Nyb3dzIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6IndhbGxldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiKHN0cmluZyx1aW50NjQsdWludDY0LGJvb2wpW10iLCJzdHJ1Y3QiOiJSZWNsYWltV2FsbGV0RXNjcm93c0FyZ1JlY2xhaW1zIiwibmFtZSI6InJlY2xhaW1zIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbNzMzXSwiZXJyb3JNZXNzYWdlIjoiRVJSOk5EQU8iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMTgsNDYzXSwiZXJyb3JNZXNzYWdlIjoiaW5kZXggYWNjZXNzIGlzIG91dCBvZiBib3VuZHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNDJdLCJlcnJvck1lc3NhZ2UiOiJpbmRleCBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTkxLDU0MV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgZW5jb2RpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjEsMjA1LDI3OSwzNTUsNDI2LDUxMSw1NjhdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNjZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFzc2V0PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIyNV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8Ynl0ZXM+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjkxXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxzbWFydF9jb250cmFjdHMvc3Vuc2V0L3R5cGVzLnRzOjpBc3NldENsb3NlUGFyYW1zPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU4OV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8c21hcnRfY29udHJhY3RzL3N1bnNldC90eXBlcy50czo6V2FsbGV0RXNjcm93UmVjbGFpbT4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MzddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PHVpbnQ2ND4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzhdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDE4LDUwM10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU2NF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdGFpbCBwb2ludGVyIGF0IGluZGV4IDAgb2YgKChsZW4rdXRmOFtdKSx1aW50NjQsdWludDY0LGJvb2wxKSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU0OV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdGFpbCBwb2ludGVyIGZvciAobGVuKygobGVuK3V0ZjhbXSksdWludDY0LHVpbnQ2NCxib29sMSlbXSkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxOTldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHRhaWwgcG9pbnRlciBmb3IgKGxlbisobGVuK3VpbnQ4W10pW10pIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTU5XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCB0dXBsZSBlbmNvZGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6ImNibG9ja3MifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTUNBeElESWdPQW9nSUNBZ1lubDBaV05pYkc5amF5QWlJaUJVVFZCTVgxTlZUbE5GVkY5RFFVeE1SVklLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkVzV6WlhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1Rb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRk4xYm5ObGRFTnZiblJ5WVdOMElHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUdKNklHMWhhVzVmWDE5aGJHZHZkSE5mWHk1a1pXWmhkV3gwUTNKbFlYUmxRREUwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGhoWWpoaU1qRXpZU0F2THlCdFpYUm9iMlFnSW1SbGJHVjBaU2hoWkdSeVpYTnpLWFp2YVdRaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQnRZV2x1WDJSbGJHVjBaVjl5YjNWMFpVQXpDZ3B0WVdsdVgzTjNhWFJqYUY5allYTmxYMjVsZUhSQU5Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRXNXpaWFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TVFvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklGTjFibk5sZEVOdmJuUnlZV04wSUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQndkWE5vWW5sMFpYTnpJREI0T1RobVpEWTFZVGNnTUhnNU5qSTFaV0ZrT1NBd2VHTTNaRGd4TURFMElEQjRNVFF4TmpkbFpUY2dNSGhrT1RnM01HWTFaQ0F2THlCdFpYUm9iMlFnSW1SbGJHVjBaVUp2ZUdWektHSjVkR1ZiWFZ0ZEtYWnZhV1FpTENCdFpYUm9iMlFnSW1Oc2IzTmxUM1YwS0NoaFpHUnlaWE56TEhWcGJuUTJOQ2xiWFNsMmIybGtJaXdnYldWMGFHOWtJQ0prWld4bGRHVkJjM05sZEhNb2RXbHVkRFkwVzEwcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWkdWc1pYUmxSWE5qY205M2N5aDFhVzUwTmpRc2RXbHVkRFkwVzEwcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpY21WamJHRnBiVmRoYkd4bGRFVnpZM0p2ZDNNb2RXbHVkRFkwTENoemRISnBibWNzZFdsdWREWTBMSFZwYm5RMk5DeGliMjlzS1Z0ZEtYWnZhV1FpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCa1pXeGxkR1ZDYjNobGN5QmpiRzl6WlU5MWRDQmtaV3hsZEdWQmMzTmxkSE1nWkdWc1pYUmxSWE5qY205M2N5QnlaV05zWVdsdFYyRnNiR1YwUlhOamNtOTNjd29nSUNBZ1pYSnlDZ3B0WVdsdVgyUmxiR1YwWlY5eWIzVjBaVUF6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04xYm5ObGRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSXdDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnWVd4c2IzZEJZM1JwYjI1ek9pQmJKMFJsYkdWMFpVRndjR3hwWTJGMGFXOXVKMTBnZlNrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUhCMWMyaHBiblFnTlNBdkx5QkVaV3hsZEdWQmNIQnNhV05oZEdsdmJnb2dJQ0FnUFQwS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBbUpnb2dJQ0FnWVhOelpYSjBDaUFnSUNCaUlHUmxiR1YwWlFvS2JXRnBibDlmWDJGc1oyOTBjMTlmTG1SbFptRjFiSFJEY21WaGRHVkFNVFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1Z1YzJWMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1URUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJUZFc1elpYUkRiMjUwY21GamRDQmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQWhDaUFnSUNBbUpnb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z1gzQjFlV0ZmYkdsaUxtRnlZelF1WkhsdVlXMXBZMTloY25KaGVWOXlaV0ZrWDJSNWJtRnRhV05mWld4bGJXVnVkQ2hoY25KaGVUb2dZbmwwWlhNc0lHbHVaR1Y0T2lCMWFXNTBOalFwSUMwK0lHSjVkR1Z6T2dwa2VXNWhiV2xqWDJGeWNtRjVYM0psWVdSZlpIbHVZVzFwWTE5bGJHVnRaVzUwT2dvZ0lDQWdjSEp2ZEc4Z01pQXhDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNZ29nSUNBZ0tnb2dJQ0FnWkdsbklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCa2FXY2dNZ29nSUNBZ2JHVnVDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0FyQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNBcUNpQWdJQ0JrYVdjZ05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNBdENpQWdJQ0J6Wld4bFkzUUtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZFc1elpYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZVM1Z1YzJWMFEyOXVkSEpoWTNRdVpHVnNaWFJsVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1pHVnNaWFJsT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04xYm5ObGRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSXdDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnWVd4c2IzZEJZM1JwYjI1ek9pQmJKMFJsYkdWMFpVRndjR3hwWTJGMGFXOXVKMTBnZlNrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkVzV6WlhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU1nb2dJQ0FnTHk4Z2RHaHBjeTVoZFhSb0tDa0tJQ0FnSUdOaGJHeHpkV0lnWVhWMGFBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMWJuTmxkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl6Q2lBZ0lDQXZMeUJwZEhodUxuQmhlVzFsYm5Rb2V5QmpiRzl6WlZKbGJXRnBibVJsY2xSdklIMHBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVOc2IzTmxVbVZ0WVdsdVpHVnlWRzhLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1Z1YzJWMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qQUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJoYkd4dmQwRmpkR2x2Ym5NNklGc25SR1ZzWlhSbFFYQndiR2xqWVhScGIyNG5YU0I5S1FvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkVzV6WlhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlUzVnVjMlYwUTI5dWRISmhZM1F1WkdWc1pYUmxRbTk0WlhOYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGtaV3hsZEdWQ2IzaGxjem9LSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJaUlLSUNBZ0lHUjFjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjFibk5sZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJMkNpQWdJQ0F2THlCa1pXeGxkR1ZDYjNobGN5aGliM2hsY3pvZ1lubDBaWE5iWFNrNklIWnZhV1FnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnS2dvZ0lDQWdjM2RoY0FvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lITjNZWEFLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb0taR1ZzWlhSbFFtOTRaWE5mWm05eVgyaGxZV1JsY2tBeE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMWJuTmxkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakkyQ2lBZ0lDQXZMeUJrWld4bGRHVkNiM2hsY3loaWIzaGxjem9nWW5sMFpYTmJYU2s2SUhadmFXUWdld29nSUNBZ1pIVndDaUFnSUNCa2FXY2dOUW9nSUNBZ1BBb2dJQ0FnWW5vZ1pHVnNaWFJsUW05NFpYTmZZV1owWlhKZlptOXlRRFFLSUNBZ0lHUjFjRzRnTWdvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lDb0tJQ0FnSUdScFp5QXpDaUFnSUNCa2RYQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ1pXNWpiMlJwYm1jS0lDQWdJR1IxY0FvZ0lDQWdaR2xuSURjS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ05Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJSFJoYVd3Z2NHOXBiblJsY2lCbWIzSWdLR3hsYmlzb2JHVnVLM1ZwYm5RNFcxMHBXMTBwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lDc0tJQ0FnSUNzS0lDQWdJR0oxY25rZ05Rb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZaUJrWld4bGRHVkNiM2hsYzE5bWIzSmZhR1ZoWkdWeVFERUtDbVJsYkdWMFpVSnZlR1Z6WDJGbWRHVnlYMlp2Y2tBME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMWJuTmxkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakkyQ2lBZ0lDQXZMeUJrWld4bGRHVkNiM2hsY3loaWIzaGxjem9nWW5sMFpYTmJYU2s2SUhadmFXUWdld29nSUNBZ1pHbG5JRE1LSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ013b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdKNWRHVnpQZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjFibk5sZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJM0NpQWdJQ0F2THlCbWIzSWdLR3hsZENCcE9pQjFhVzUwTmpRZ1BTQXdPeUJwSUR3Z1ltOTRaWE11YkdWdVozUm9PeUJwS3lzcElIc0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZFhKNUlEY0tDbVJsYkdWMFpVSnZlR1Z6WDNkb2FXeGxYM1J2Y0VBMk9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMWJuTmxkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakkzQ2lBZ0lDQXZMeUJtYjNJZ0tHeGxkQ0JwT2lCMWFXNTBOalFnUFNBd095QnBJRHdnWW05NFpYTXViR1Z1WjNSb095QnBLeXNwSUhzS0lDQWdJR1JwWnlBMkNpQWdJQ0JrYVdjZ05Rb2dJQ0FnUEFvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURjS0lDQWdJR0o2SUdSbGJHVjBaVUp2ZUdWelgyRm1kR1Z5WDNkb2FXeGxRRGdLSUNBZ0lHUnBaeUExQ2lBZ0lDQmhjM05sY25RZ0x5OGdhVzVrWlhnZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ1pHbG5JRFlLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUNvS0lDQWdJR1JwWnlBekNpQWdJQ0JrZFhBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lHUjFjRElLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkVzV6WlhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU9Bb2dJQ0FnTHk4Z2IzQXVRbTk0TG1SbGJHVjBaU2hpYjNobGMxdHBYU2tLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkVzV6WlhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU53b2dJQ0FnTHk4Z1ptOXlJQ2hzWlhRZ2FUb2dkV2x1ZERZMElEMGdNRHNnYVNBOElHSnZlR1Z6TG14bGJtZDBhRHNnYVNzcktTQjdDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdZblZ5ZVNBM0NpQWdJQ0JpSUdSbGJHVjBaVUp2ZUdWelgzZG9hV3hsWDNSdmNFQTJDZ3BrWld4bGRHVkNiM2hsYzE5aFpuUmxjbDkzYUdsc1pVQTRPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjFibk5sZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJMkNpQWdJQ0F2THlCa1pXeGxkR1ZDYjNobGN5aGliM2hsY3pvZ1lubDBaWE5iWFNrNklIWnZhV1FnZXdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkVzV6WlhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlUzVnVjMlYwUTI5dWRISmhZM1F1WTJ4dmMyVlBkWFJiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwamJHOXpaVTkxZERvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZFc1elpYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pNZ29nSUNBZ0x5OGdZMnh2YzJWUGRYUW9ZMnh2YzJWek9pQkJjM05sZEVOc2IzTmxVR0Z5WVcxelcxMHBPaUIyYjJsa0lIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNHNGdNZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnY0hWemFHbHVkQ0EwTUFvZ0lDQWdLZ29nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUNzS0lDQWdJSE4zWVhBS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkVzV6WlhRdmRIbHdaWE11ZEhNNk9rRnpjMlYwUTJ4dmMyVlFZWEpoYlhNK0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNWdWMyVjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNek1LSUNBZ0lDOHZJSFJvYVhNdVlYVjBhQ2dwQ2lBZ0lDQmpZV3hzYzNWaUlHRjFkR2dLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkVzV6WlhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek5Bb2dJQ0FnTHk4Z1ptOXlJQ2hzWlhRZ2FUb2dkV2x1ZERZMElEMGdNRHNnYVNBOElHTnNiM05sY3k1c1pXNW5kR2c3SUdrckt5a2dld29nSUNBZ2FXNTBZMTh3SUM4dklEQUtDbU5zYjNObFQzVjBYM2RvYVd4bFgzUnZjRUF5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04xYm5ObGRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTBDaUFnSUNBdkx5Qm1iM0lnS0d4bGRDQnBPaUIxYVc1ME5qUWdQU0F3T3lCcElEd2dZMnh2YzJWekxteGxibWQwYURzZ2FTc3JLU0I3Q2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQThDaUFnSUNCaWVpQmpiRzl6WlU5MWRGOWhablJsY2w5M2FHbHNaVUExQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1Z1YzJWMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16VUtJQ0FnSUM4dklHTnZibk4wSUhzZ1lYTnpaWFJEYkc5elpWUnZMQ0I0Wm1WeVFYTnpaWFFnZlNBOUlHTnNiMjVsS0dOc2IzTmxjMXRwWFNrS0lDQWdJR1JwWnlBeUNpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdaR2xuSURFS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnY0hWemFHbHVkQ0EwTUFvZ0lDQWdLZ29nSUNBZ2NIVnphR2x1ZENBME1Bb2dJQ0FnWlhoMGNtRmpkRE1nTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUdGalkyVnpjeUJwY3lCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCa2RYQUtJQ0FnSUdWNGRISmhZM1FnTUNBek1nb2dJQ0FnYzNkaGNBb2dJQ0FnY0hWemFHbHVkQ0F6TWdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZFc1elpYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pOZ29nSUNBZ0x5OGdhWFI0Ymk1aGMzTmxkRlJ5WVc1elptVnlLSHNnWVhOelpYUkRiRzl6WlZSdkxDQjRabVZ5UVhOelpYUWdmU2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUdsMGVHNWZabWxsYkdRZ1dHWmxja0Z6YzJWMENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGemMyVjBRMnh2YzJWVWJ3b2dJQ0FnY0hWemFHbHVkQ0EwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNWdWMyVjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNelFLSUNBZ0lDOHZJR1p2Y2lBb2JHVjBJR2s2SUhWcGJuUTJOQ0E5SURBN0lHa2dQQ0JqYkc5elpYTXViR1Z1WjNSb095QnBLeXNwSUhzS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCaWRYSjVJREVLSUNBZ0lHSWdZMnh2YzJWUGRYUmZkMmhwYkdWZmRHOXdRRElLQ21Oc2IzTmxUM1YwWDJGbWRHVnlYM2RvYVd4bFFEVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzVnVjMlYwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpJS0lDQWdJQzh2SUdOc2IzTmxUM1YwS0dOc2IzTmxjem9nUVhOelpYUkRiRzl6WlZCaGNtRnRjMXRkS1RvZ2RtOXBaQ0I3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjFibk5sZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwVGRXNXpaWFJEYjI1MGNtRmpkQzVrWld4bGRHVkJjM05sZEhOYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGtaV3hsZEdWQmMzTmxkSE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1Z1YzJWMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5EQUtJQ0FnSUM4dklHUmxiR1YwWlVGemMyVjBjeWhoYzNObGRITTZJRUZ6YzJWMFcxMHBPaUIyYjJsa0lIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNHNGdNZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJQ29LSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNBckNpQWdJQ0J6ZDJGd0NpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoYzNObGRENEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRXNXpaWFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTVFvZ0lDQWdMeThnZEdocGN5NWhkWFJvS0NrS0lDQWdJR05oYkd4emRXSWdZWFYwYUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04xYm5ObGRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUXlDaUFnSUNBdkx5Qm1iM0lnS0d4bGRDQnBPaUIxYVc1ME5qUWdQU0F3T3lCcElEd2dZWE56WlhSekxteGxibWQwYURzZ2FTc3JLU0I3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9LWkdWc1pYUmxRWE56WlhSelgzZG9hV3hsWDNSdmNFQXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjFibk5sZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pReUNpQWdJQ0F2THlCbWIzSWdLR3hsZENCcE9pQjFhVzUwTmpRZ1BTQXdPeUJwSUR3Z1lYTnpaWFJ6TG14bGJtZDBhRHNnYVNzcktTQjdDaUFnSUNCa2RYQUtJQ0FnSUdScFp5QXlDaUFnSUNBOENpQWdJQ0JpZWlCa1pXeGxkR1ZCYzNObGRITmZZV1owWlhKZmQyaHBiR1ZBTlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04xYm5ObGRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUXpDaUFnSUNBdkx5QnBkSGh1TG1GemMyVjBRMjl1Wm1sbktIc2dZMjl1Wm1sblFYTnpaWFE2SUdGemMyVjBjMXRwWFNCOUtTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdaR2xuSURJS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQmthV2NnTVFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdLZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRMjl1Wm1sblFYTnpaWFFLSUNBZ0lIQjFjMmhwYm5RZ013b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjFibk5sZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pReUNpQWdJQ0F2THlCbWIzSWdLR3hsZENCcE9pQjFhVzUwTmpRZ1BTQXdPeUJwSUR3Z1lYTnpaWFJ6TG14bGJtZDBhRHNnYVNzcktTQjdDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JpSUdSbGJHVjBaVUZ6YzJWMGMxOTNhR2xzWlY5MGIzQkFNZ29LWkdWc1pYUmxRWE56WlhSelgyRm1kR1Z5WDNkb2FXeGxRRFU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1Z1YzJWMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5EQUtJQ0FnSUM4dklHUmxiR1YwWlVGemMyVjBjeWhoYzNObGRITTZJRUZ6YzJWMFcxMHBPaUIyYjJsa0lIc0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNWdWMyVjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPbE4xYm5ObGRFTnZiblJ5WVdOMExtUmxiR1YwWlVWelkzSnZkM05iY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwa1pXeGxkR1ZGYzJOeWIzZHpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjFibk5sZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRM0NpQWdJQ0F2THlCa1pXeGxkR1ZGYzJOeWIzZHpLR1Z6WTNKdmQwWmhZM1J2Y25rNklFRndjR3hwWTJGMGFXOXVMQ0JsYzJOeWIzZEpaSE02SUhWcGJuUTJORnRkS1RvZ2RtOXBaQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhCdUlESUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQXFDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdjM2RoY0FvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhkV2x1ZERZMFBnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMWJuTmxkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalE0Q2lBZ0lDQXZMeUIwYUdsekxtRjFkR2dvS1FvZ0lDQWdZMkZzYkhOMVlpQmhkWFJvQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1Z1YzJWMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5Ea0tJQ0FnSUM4dklHWnZjaUFvYkdWMElHazZJSFZwYm5RMk5DQTlJREE3SUdrZ1BDQmxjMk55YjNkSlpITXViR1Z1WjNSb095QnBLeXNwSUhzS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2dwa1pXeGxkR1ZGYzJOeWIzZHpYM2RvYVd4bFgzUnZjRUF5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04xYm5ObGRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUTVDaUFnSUNBdkx5Qm1iM0lnS0d4bGRDQnBPaUIxYVc1ME5qUWdQU0F3T3lCcElEd2daWE5qY205M1NXUnpMbXhsYm1kMGFEc2dhU3NyS1NCN0NpQWdJQ0JrZFhBS0lDQWdJR1JwWnlBeUNpQWdJQ0E4Q2lBZ0lDQmllaUJrWld4bGRHVkZjMk55YjNkelgyRm1kR1Z5WDNkb2FXeGxRRFVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkVzV6WlhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU1DMDFNd29nSUNBZ0x5OGdZV0pwUTJGc2JEeDBlWEJsYjJZZ1JYTmpjbTkzUm1GamRHOXllUzV3Y205MGIzUjVjR1V1WkdWc1pYUmxQaWg3Q2lBZ0lDQXZMeUFnSUdGd2NFbGtPaUJsYzJOeWIzZEdZV04wYjNKNUxBb2dJQ0FnTHk4Z0lDQmhjbWR6T2lCYlpYTmpjbTkzU1dSelcybGRYU3dLSUNBZ0lDOHZJSDBwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzVnVjMlYwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRJS0lDQWdJQzh2SUdGeVozTTZJRnRsYzJOeWIzZEpaSE5iYVYxZExBb2dJQ0FnWkdsbklESUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnS2dvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lHVjRkSEpoWTNReklDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQmhZMk5sYzNNZ2FYTWdiM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdaR2xuSURVS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMWJuTmxkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalV3TFRVekNpQWdJQ0F2THlCaFltbERZV3hzUEhSNWNHVnZaaUJGYzJOeWIzZEdZV04wYjNKNUxuQnliM1J2ZEhsd1pTNWtaV3hsZEdVK0tIc0tJQ0FnSUM4dklDQWdZWEJ3U1dRNklHVnpZM0p2ZDBaaFkzUnZjbmtzQ2lBZ0lDQXZMeUFnSUdGeVozTTZJRnRsYzJOeWIzZEpaSE5iYVYxZExBb2dJQ0FnTHk4Z2ZTa0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEaGhNemxsTnpsbUlDOHZJRzFsZEdodlpDQWlaR1ZzWlhSbEtIVnBiblEyTkNsMmIybGtJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCd2RYTm9hVzUwSURZZ0x5OGdZWEJ3YkFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMWJuTmxkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalE1Q2lBZ0lDQXZMeUJtYjNJZ0tHeGxkQ0JwT2lCMWFXNTBOalFnUFNBd095QnBJRHdnWlhOamNtOTNTV1J6TG14bGJtZDBhRHNnYVNzcktTQjdDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JpSUdSbGJHVjBaVVZ6WTNKdmQzTmZkMmhwYkdWZmRHOXdRRElLQ21SbGJHVjBaVVZ6WTNKdmQzTmZZV1owWlhKZmQyaHBiR1ZBTlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZFc1elpYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBOd29nSUNBZ0x5OGdaR1ZzWlhSbFJYTmpjbTkzY3lobGMyTnliM2RHWVdOMGIzSjVPaUJCY0hCc2FXTmhkR2x2Yml3Z1pYTmpjbTkzU1dSek9pQjFhVzUwTmpSYlhTazZJSFp2YVdRZ2V3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZFc1elpYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZVM1Z1YzJWMFEyOXVkSEpoWTNRdWNtVmpiR0ZwYlZkaGJHeGxkRVZ6WTNKdmQzTmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B5WldOc1lXbHRWMkZzYkdWMFJYTmpjbTkzY3pvS0lDQWdJR0o1ZEdWalh6QWdMeThnSWlJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZFc1elpYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFOd29nSUNBZ0x5OGdjbVZqYkdGcGJWZGhiR3hsZEVWelkzSnZkM01vZDJGc2JHVjBPaUJCY0hCc2FXTmhkR2x2Yml3Z2NtVmpiR0ZwYlhNNklGZGhiR3hsZEVWelkzSnZkMUpsWTJ4aGFXMWJYU2s2SUhadmFXUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3YmlBeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNZ29nSUNBZ0tnb2dJQ0FnYzNkaGNBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSE4zWVhBS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9LY21WamJHRnBiVmRoYkd4bGRFVnpZM0p2ZDNOZlptOXlYMmhsWVdSbGNrQXhPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjFibk5sZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVM0NpQWdJQ0F2THlCeVpXTnNZV2x0VjJGc2JHVjBSWE5qY205M2N5aDNZV3hzWlhRNklFRndjR3hwWTJGMGFXOXVMQ0J5WldOc1lXbHRjem9nVjJGc2JHVjBSWE5qY205M1VtVmpiR0ZwYlZ0ZEtUb2dkbTlwWkNCN0NpQWdJQ0JrZFhBS0lDQWdJR1JwWnlBMUNpQWdJQ0E4Q2lBZ0lDQmllaUJ5WldOc1lXbHRWMkZzYkdWMFJYTmpjbTkzYzE5aFpuUmxjbDltYjNKQU5Bb2dJQ0FnWkhWd2JpQXlDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnS2dvZ0lDQWdaR2xuSURNS0lDQWdJR1IxY0FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JsYm1OdlpHbHVad29nSUNBZ1pIVndDaUFnSUNCa2FXY2dOd29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUEwQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2RHRnBiQ0J3YjJsdWRHVnlJR1p2Y2lBb2JHVnVLeWdvYkdWdUszVjBaamhiWFNrc2RXbHVkRFkwTEhWcGJuUTJOQ3hpYjI5c01TbGJYU2tLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lITjFZbk4wY21sdVp6TUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJSFIxY0d4bElHVnVZMjlrYVc1bkNpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdNVGtLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCMFlXbHNJSEJ2YVc1MFpYSWdZWFFnYVc1a1pYZ2dNQ0J2WmlBb0tHeGxiaXQxZEdZNFcxMHBMSFZwYm5RMk5DeDFhVzUwTmpRc1ltOXZiREVwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdjSFZ6YUdsdWRDQXlNUW9nSUNBZ0t3b2dJQ0FnS3dvZ0lDQWdZblZ5ZVNBMUNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdLd29nSUNBZ1luVnllU0F4Q2lBZ0lDQmlJSEpsWTJ4aGFXMVhZV3hzWlhSRmMyTnliM2R6WDJadmNsOW9aV0ZrWlhKQU1Rb0tjbVZqYkdGcGJWZGhiR3hsZEVWelkzSnZkM05mWVdaMFpYSmZabTl5UURRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNWdWMyVjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVGNLSUNBZ0lDOHZJSEpsWTJ4aGFXMVhZV3hzWlhSRmMyTnliM2R6S0hkaGJHeGxkRG9nUVhCd2JHbGpZWFJwYjI0c0lISmxZMnhoYVcxek9pQlhZV3hzWlhSRmMyTnliM2RTWldOc1lXbHRXMTBwT2lCMmIybGtJSHNLSUNBZ0lHUnBaeUF6Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklETUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4emJXRnlkRjlqYjI1MGNtRmpkSE12YzNWdWMyVjBMM1I1Y0dWekxuUnpPanBYWVd4c1pYUkZjMk55YjNkU1pXTnNZV2x0UGdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04xYm5ObGRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVTRDaUFnSUNBdkx5QjBhR2x6TG1GMWRHZ29LUW9nSUNBZ1kyRnNiSE4xWWlCaGRYUm9DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzVnVjMlYwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRrS0lDQWdJQzh2SUdadmNpQW9iR1YwSUdrNklIVnBiblEyTkNBOUlEQTdJR2tnUENCeVpXTnNZV2x0Y3k1c1pXNW5kR2c3SUdrckt5a2dld29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKMWNua2dPQW9LY21WamJHRnBiVmRoYkd4bGRFVnpZM0p2ZDNOZmQyaHBiR1ZmZEc5d1FEWTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzVnVjMlYwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRrS0lDQWdJQzh2SUdadmNpQW9iR1YwSUdrNklIVnBiblEyTkNBOUlEQTdJR2tnUENCeVpXTnNZV2x0Y3k1c1pXNW5kR2c3SUdrckt5a2dld29nSUNBZ1pHbG5JRGNLSUNBZ0lHUnBaeUExQ2lBZ0lDQThDaUFnSUNCaWVpQnlaV05zWVdsdFYyRnNiR1YwUlhOamNtOTNjMTloWm5SbGNsOTNhR2xzWlVBNUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNWdWMyVjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOaklLSUNBZ0lDOHZJR0Z6YzJWME9pQnlaV05zWVdsdExtRnpjMlYwTEFvZ0lDQWdaR2xuSURVS0lDQWdJR1IxY0FvZ0lDQWdaR2xuSURrS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ013b2dJQ0FnWTJGc2JITjFZaUJrZVc1aGJXbGpYMkZ5Y21GNVgzSmxZV1JmWkhsdVlXMXBZMTlsYkdWdFpXNTBDaUFnSUNCbGVIUnlZV04wSURJZ09Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMWJuTmxkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPall6Q2lBZ0lDQXZMeUJoYlc5MWJuUTZJSEpsWTJ4aGFXMHVZVzF2ZFc1MExBb2dJQ0FnWkdsbklERUtJQ0FnSUdScFp5QXpDaUFnSUNCallXeHNjM1ZpSUdSNWJtRnRhV05mWVhKeVlYbGZjbVZoWkY5a2VXNWhiV2xqWDJWc1pXMWxiblFLSUNBZ0lHVjRkSEpoWTNRZ01UQWdPQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjFibk5sZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZMENpQWdJQ0F2THlCamJHOXpaVTkxZERvZ2NtVmpiR0ZwYlM1amJHOXpaVTkxZEN3S0lDQWdJR1JwWnlBeUNpQWdJQ0JrYVdjZ05Bb2dJQ0FnWTJGc2JITjFZaUJrZVc1aGJXbGpYMkZ5Y21GNVgzSmxZV1JmWkhsdVlXMXBZMTlsYkdWdFpXNTBDaUFnSUNCd2RYTm9hVzUwSURFME5Bb2dJQ0FnWjJWMFltbDBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzVnVjMlYwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpFdE5qVUtJQ0FnSUM4dklHTnZibk4wSUhkaGJHeGxkRkpsWTJ4aGFXMXpPaUJGYzJOeWIzZFNaV05zWVdsdFcxMGdQU0JiZXdvZ0lDQWdMeThnSUNCaGMzTmxkRG9nY21WamJHRnBiUzVoYzNObGRDd0tJQ0FnSUM4dklDQWdZVzF2ZFc1ME9pQnlaV05zWVdsdExtRnRiM1Z1ZEN3S0lDQWdJQzh2SUNBZ1kyeHZjMlZQZFhRNklISmxZMnhoYVcwdVkyeHZjMlZQZFhRc0NpQWdJQ0F2THlCOVhRb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TUFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnYzJWMFltbDBDaUFnSUNCamIyNWpZWFFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TURFS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMWJuTmxkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalkyTFRZNUNpQWdJQ0F2THlCaFltbERZV3hzUEhSNWNHVnZaaUJCWW5OMGNtRmpkR1ZrUVdOamIzVnVkQzV3Y205MGIzUjVjR1V1WVhKak5UaGZjbVZqYkdGcGJUNG9ld29nSUNBZ0x5OGdJQ0JoY0hCSlpEb2dkMkZzYkdWMExBb2dJQ0FnTHk4Z0lDQmhjbWR6T2lCYmNtVmpiR0ZwYlM1bGMyTnliM2NzSUhkaGJHeGxkRkpsWTJ4aGFXMXpYU3dLSUNBZ0lDOHZJSDBwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzVnVjMlYwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpnS0lDQWdJQzh2SUdGeVozTTZJRnR5WldOc1lXbHRMbVZ6WTNKdmR5d2dkMkZzYkdWMFVtVmpiR0ZwYlhOZExBb2dJQ0FnYzNkaGNBb2dJQ0FnWkdsbklESUtJQ0FnSUdOaGJHeHpkV0lnWkhsdVlXMXBZMTloY25KaGVWOXlaV0ZrWDJSNWJtRnRhV05mWld4bGJXVnVkQW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR1JwWnlBNUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRXNXpaWFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTmkwMk9Rb2dJQ0FnTHk4Z1lXSnBRMkZzYkR4MGVYQmxiMllnUVdKemRISmhZM1JsWkVGalkyOTFiblF1Y0hKdmRHOTBlWEJsTG1GeVl6VTRYM0psWTJ4aGFXMCtLSHNLSUNBZ0lDOHZJQ0FnWVhCd1NXUTZJSGRoYkd4bGRDd0tJQ0FnSUM4dklDQWdZWEpuY3pvZ1czSmxZMnhoYVcwdVpYTmpjbTkzTENCM1lXeHNaWFJTWldOc1lXbHRjMTBzQ2lBZ0lDQXZMeUI5S1FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0WldKaFpqRTBZVEFnTHk4Z2JXVjBhRzlrSUNKaGNtTTFPRjl5WldOc1lXbHRLSE4wY21sdVp5d29kV2x1ZERZMExIVnBiblEyTkN4aWIyOXNLVnRkS1hadmFXUWlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQndkWE5vYVc1MElEWWdMeThnWVhCd2JBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjFibk5sZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVNUNpQWdJQ0F2THlCbWIzSWdLR3hsZENCcE9pQjFhVzUwTmpRZ1BTQXdPeUJwSUR3Z2NtVmpiR0ZwYlhNdWJHVnVaM1JvT3lCcEt5c3BJSHNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBckNpQWdJQ0JpZFhKNUlEZ0tJQ0FnSUdJZ2NtVmpiR0ZwYlZkaGJHeGxkRVZ6WTNKdmQzTmZkMmhwYkdWZmRHOXdRRFlLQ25KbFkyeGhhVzFYWVd4c1pYUkZjMk55YjNkelgyRm1kR1Z5WDNkb2FXeGxRRGs2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1Z1YzJWMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5UY0tJQ0FnSUM4dklISmxZMnhoYVcxWFlXeHNaWFJGYzJOeWIzZHpLSGRoYkd4bGREb2dRWEJ3YkdsallYUnBiMjRzSUhKbFkyeGhhVzF6T2lCWFlXeHNaWFJGYzJOeWIzZFNaV05zWVdsdFcxMHBPaUIyYjJsa0lIc0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNWdWMyVjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPbE4xYm5ObGRFTnZiblJ5WVdOMExtRjFkR2dvS1NBdFBpQjJiMmxrT2dwaGRYUm9PZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjFibk5sZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMUNpQWdJQ0F2THlBb1ZIaHVMbk5sYm1SbGNpQTlQVDBnUjJ4dlltRnNMbU55WldGMGIzSkJaR1J5WlhOeklIeDhJRlI0Ymk1elpXNWtaWElnUFQwOUlITjFibk5sZEVOaGJHeGxjaWtzQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCbmJHOWlZV3dnUTNKbFlYUnZja0ZrWkhKbGMzTUtJQ0FnSUQwOUNpQWdJQ0JpYm5vZ1lYVjBhRjlpYjI5c1gzUnlkV1ZBTWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1lubDBaV05mTVNBdkx5QlVUVkJNWDFOVlRsTkZWRjlEUVV4TVJWSUtJQ0FnSUQwOUNpQWdJQ0JpZWlCaGRYUm9YMkp2YjJ4ZlptRnNjMlZBTXdvS1lYVjBhRjlpYjI5c1gzUnlkV1ZBTWpvS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2dwaGRYUm9YMkp2YjJ4ZmJXVnlaMlZBTkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZFc1elpYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOQzB4TndvZ0lDQWdMeThnYkc5bloyVmtRWE56WlhKMEtBb2dJQ0FnTHk4Z0lDQW9WSGh1TG5ObGJtUmxjaUE5UFQwZ1IyeHZZbUZzTG1OeVpXRjBiM0pCWkdSeVpYTnpJSHg4SUZSNGJpNXpaVzVrWlhJZ1BUMDlJSE4xYm5ObGRFTmhiR3hsY2lrc0NpQWdJQ0F2THlBZ0lFVlNVbDlPVDFSZlFVdEpWRUZmUkVGUENpQWdJQ0F2THlBcENpQWdJQ0JpYm5vZ1lYVjBhRjloWm5SbGNsOWhjM05sY25SQU5nb2dJQ0FnY0hWemFHSjVkR1Z6SUNKRlVsSTZUa1JCVHlJS0lDQWdJR3h2WndvZ0lDQWdaWEp5SUM4dklFVlNVanBPUkVGUENncGhkWFJvWDJGbWRHVnlYMkZ6YzJWeWRFQTJPZ29nSUNBZ2NtVjBjM1ZpQ2dwaGRYUm9YMkp2YjJ4ZlptRnNjMlZBTXpvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmlJR0YxZEdoZlltOXZiRjl0WlhKblpVQTBDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERUtJQ0FnSUhKbGRIVnliZ289In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFBRUNDQ1lDQUFBeEcwRUFTNEFFcTRzaE9qWWFBSTRCQURJeEdSUkVNUmhFZ2dVRW1QMWxwd1NXSmVyWkJNZllFQlFFRkJaKzV3VFpodzlkTmhvQWpnVUFWd0RPQVJvQldBR3NBREVaZ1FVU01SZ1FSRUlBTWpFWkZERVlGQkJEaWdJQmkvNVhBZ0NML2lKWmkvOGtDMHNDVEZsTEFoV0wveU1JU1NRTFN3Vk1XVThFVHdJSlRWS0pOaG9CU1JXQklCSkVpQUl4c2JJSkk3SVFJcklCc3lOREtFazJHZ0ZKSWxsSlRnSWtDMHhKRlV4WEFnQWlTVXNGREVFQUpFY0NKQXRMQTBsUEFsbEpTd2RKVGdRU1JFc0JGVklpV1NRSUNFVUZJd2hGQVVMLzFVc0RKQWhMQXhKRUlrVUhTd1pMQlF4SlJRZEJBQjlMQlVSTEJra2tDMHNEU1U4Q1dVcFpKQWhZVndJQXZFZ2pDRVVIUXYvV0kwTTJHZ0ZIQWlKWlNVNENnU2dMSkFoTUZSSkVpQUdZSWtsTEFneEJBQ3hMQWxjQ0FFc0JTVTRDZ1NnTGdTaFlTVmNBSUV5QklGdXhzaEd5RllFRXNoQWlzZ0d6SXdoRkFVTC96U05ETmhvQlJ3SWlXVWxPQWlVTEpBaE1GUkpFaUFGTklrbExBZ3hCQUIreFN3SlhBZ0JMQVVsT0FpVUxXN0loZ1FPeUVDS3lBYk1qQ0VVQlF2L2FJME0yR2dGSkZTVVNSQmMyR2dKSEFpSlpTVTRDSlFza0NFd1ZFa1NJQVFZaVNVc0NERUVBTExGTEFsY0NBRXNCU1U0Q0pRc2xXRXNGc2hpQUJJbzU1NSt5R3JJYWdRYXlFQ0t5QWJNakNFVUJRdi9OSTBNb05ob0JTUlVsRWtRWE5ob0NSd0lpV1VsT0FpUUxURWtWVEZjQ0FDSkpTd1VNUVFBeVJ3SWtDMHNEU1U4Q1dVbExCMGxPQkJKRVN3RVZVa2tWU3dFaVdVbUJFeEpFVEZJaVdZRVZDQWhGQlNNSVJRRkMvOGRMQXlRSVN3TVNSSWdBYmlKRkNFc0hTd1VNUVFCaFN3VkpTd2xKVGdPSS9mRlhBZ2hMQVVzRGlQM25Wd29JU3dKTEJJajkzWUdRQVZOT0FsQ0FBUUFpVHdOVVVJQUNBQUZNVUxGTVN3S0kvY0ZKSWxsTEFSVlNTd215R0lBRTY2OFVvTElhc2hxeUdvRUdzaEFpc2dHekl3aEZDRUwvbHlORE1RQXlDUkpBQUFjeEFDa1NRUUFSSTBBQURJQUlSVkpTT2s1RVFVK3dBSWtpUXYvcyIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjksInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7IlNVTlNFVF9DQUxMRVIiOnsidHlwZSI6ImFkZHJlc3MiLCJ2YWx1ZSI6bnVsbH19LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
