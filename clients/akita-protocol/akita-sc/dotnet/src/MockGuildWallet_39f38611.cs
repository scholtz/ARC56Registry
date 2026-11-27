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

namespace Arc56.Generated.akita_protocol.akita_sc.MockGuildWallet_39f38611
{


    //
    // Minimal ARC-58 administration surface used only by Guild integration tests.
    //
    public class MockGuildWalletProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public MockGuildWalletProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class EscrowInfo : AVMObjectType
            {
                public ulong Id { get; set; }

                public Algorand.Address Address { get; set; }

                public bool Locked { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vId.From(Id);
                    ret.AddRange(vId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vAddress.From(Address);
                    ret.AddRange(vAddress.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLocked = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vLocked.From(Locked);
                    ret.AddRange(vLocked.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static EscrowInfo Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new EscrowInfo();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueId = vId.ToValue();
                    if (valueId is ulong vIdValue) { ret.Id = vIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vAddress.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAddress = vAddress.ToValue();
                    if (valueAddress is Algorand.Address vAddressValue) { ret.Address = vAddressValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLocked = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vLocked.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueLocked = vLocked.ToValue();
                    if (valueLocked is bool vLockedValue) { ret.Locked = vLockedValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as EscrowInfo);
                }
                public bool Equals(EscrowInfo? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(EscrowInfo left, EscrowInfo right)
                {
                    return EqualityComparer<EscrowInfo>.Default.Equals(left, right);
                }
                public static bool operator !=(EscrowInfo left, EscrowInfo right)
                {
                    return !(left == right);
                }

            }

            public class PluginKey : AVMObjectType
            {
                public ulong Plugin { get; set; }

                public Algorand.Address Caller { get; set; }

                public string Escrow { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPlugin = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vPlugin.From(Plugin);
                    ret.AddRange(vPlugin.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCaller = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vCaller.From(Caller);
                    ret.AddRange(vCaller.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEscrow = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vEscrow.From(Escrow);
                    stringRef[ret.Count] = vEscrow.Encode();
                    ret.AddRange(new byte[2]);
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static PluginKey Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new PluginKey();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPlugin = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vPlugin.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePlugin = vPlugin.ToValue();
                    if (valuePlugin is ulong vPluginValue) { ret.Plugin = vPluginValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCaller = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vCaller.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCaller = vCaller.ToValue();
                    if (valueCaller is Algorand.Address vCallerValue) { ret.Caller = vCallerValue; }
                    var indexEscrow = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEscrow = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vEscrow.Decode(bytes.Skip(indexEscrow + prefixOffset).ToArray());
                    var valueEscrow = vEscrow.ToValue();
                    if (valueEscrow is string vEscrowValue) { ret.Escrow = vEscrowValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as PluginKey);
                }
                public bool Equals(PluginKey? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(PluginKey left, PluginKey right)
                {
                    return EqualityComparer<PluginKey>.Default.Equals(left, right);
                }
                public static bool operator !=(PluginKey left, PluginKey right)
                {
                    return !(left == right);
                }

            }

            public class Arc58AddPluginArgMethods : AVMObjectType
            {
                public byte[] Field0 { get; set; }

                public ulong Field1 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[4]");
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

                public static Arc58AddPluginArgMethods Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Arc58AddPluginArgMethods();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[4]");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is byte[] vField0Value) { ret.Field0 = vField0Value; }
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
                    return Equals(obj as Arc58AddPluginArgMethods);
                }
                public bool Equals(Arc58AddPluginArgMethods? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Arc58AddPluginArgMethods left, Arc58AddPluginArgMethods right)
                {
                    return EqualityComparer<Arc58AddPluginArgMethods>.Default.Equals(left, right);
                }
                public static bool operator !=(Arc58AddPluginArgMethods left, Arc58AddPluginArgMethods right)
                {
                    return !(left == right);
                }

            }

            public class Arc58ReclaimArgReclaims : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public ulong Field1 { get; set; }

                public bool Field2 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vField2.From(Field2);
                    ret.AddRange(vField2.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Arc58ReclaimArgReclaims Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Arc58ReclaimArgReclaims();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is ulong vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is ulong vField1Value) { ret.Field1 = vField1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is bool vField2Value) { ret.Field2 = vField2Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Arc58ReclaimArgReclaims);
                }
                public bool Equals(Arc58ReclaimArgReclaims? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Arc58ReclaimArgReclaims left, Arc58ReclaimArgReclaims right)
                {
                    return EqualityComparer<Arc58ReclaimArgReclaims>.Default.Equals(left, right);
                }
                public static bool operator !=(Arc58ReclaimArgReclaims left, Arc58ReclaimArgReclaims right)
                {
                    return !(left == right);
                }

            }

            public class Arc58AddAllowancesArgAllowances : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public byte Field1 { get; set; }

                public ulong Field2 { get; set; }

                public ulong Field3 { get; set; }

                public ulong Field4 { get; set; }

                public bool Field5 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField2.From(Field2);
                    ret.AddRange(vField2.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField3.From(Field3);
                    ret.AddRange(vField3.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField4.From(Field4);
                    ret.AddRange(vField4.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField5 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vField5.From(Field5);
                    ret.AddRange(vField5.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Arc58AddAllowancesArgAllowances Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Arc58AddAllowancesArgAllowances();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is ulong vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is byte vField1Value) { ret.Field1 = vField1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is ulong vField2Value) { ret.Field2 = vField2Value; }
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField5 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField5.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField5 = vField5.ToValue();
                    if (valueField5 is bool vField5Value) { ret.Field5 = vField5Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Arc58AddAllowancesArgAllowances);
                }
                public bool Equals(Arc58AddAllowancesArgAllowances? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Arc58AddAllowancesArgAllowances left, Arc58AddAllowancesArgAllowances right)
                {
                    return EqualityComparer<Arc58AddAllowancesArgAllowances>.Default.Equals(left, right);
                }
                public static bool operator !=(Arc58AddAllowancesArgAllowances left, Arc58AddAllowancesArgAllowances right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="admin"> </param>
        public async Task Create(Algorand.Address admin, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 204, 105, 78, 170 };
            var adminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); adminAbi.From(admin);

            var result = await base.CallApp(new List<object> { abiHandle, adminAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(Algorand.Address admin, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 204, 105, 78, 170 };
            var adminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); adminAbi.From(admin);

            return await base.MakeTransactionList(new List<object> { abiHandle, adminAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="admin"> </param>
        public async Task SetAdmin(Algorand.Address admin, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 23, 134, 105, 18 };
            var adminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); adminAbi.From(admin);

            var result = await base.CallApp(new List<object> { abiHandle, adminAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetAdmin_Transactions(Algorand.Address admin, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 23, 134, 105, 18 };
            var adminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); adminAbi.From(admin);

            return await base.MakeTransactionList(new List<object> { abiHandle, adminAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="plugin"> </param>
        /// <param name="caller"> </param>
        /// <param name="escrow"> </param>
        /// <param name="admin"> </param>
        /// <param name="delegationType"> </param>
        /// <param name="lastValid"> </param>
        /// <param name="cooldown"> </param>
        /// <param name="methods"> Arc58AddPluginArgMethods</param>
        /// <param name="useRounds"> </param>
        /// <param name="useExecutionKey"> </param>
        /// <param name="coverFees"> </param>
        /// <param name="canReclaim"> </param>
        /// <param name="defaultToEscrow"> </param>
        public async Task Arc58AddPlugin(ulong plugin, Algorand.Address caller, string escrow, bool admin, byte delegationType, ulong lastValid, ulong cooldown, Structs.Arc58AddPluginArgMethods[] methods, bool useRounds, bool useExecutionKey, bool coverFees, bool canReclaim, bool defaultToEscrow, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 86, 114, 70, 46 };
            var pluginAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); pluginAbi.From(plugin);
            var callerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); callerAbi.From(caller);
            var escrowAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); escrowAbi.From(escrow);
            var adminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); adminAbi.From(admin);
            var delegationTypeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); delegationTypeAbi.From(delegationType);
            var lastValidAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); lastValidAbi.From(lastValid);
            var cooldownAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); cooldownAbi.From(cooldown);
            var methodsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.Arc58AddPluginArgMethods>(x => Structs.Arc58AddPluginArgMethods.Parse(x)) { IsFixedLength = false, FixedLength = 0 }; methodsAbi.From(methods);
            var useRoundsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); useRoundsAbi.From(useRounds);
            var useExecutionKeyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); useExecutionKeyAbi.From(useExecutionKey);
            var coverFeesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); coverFeesAbi.From(coverFees);
            var canReclaimAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); canReclaimAbi.From(canReclaim);
            var defaultToEscrowAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); defaultToEscrowAbi.From(defaultToEscrow);

            var result = await base.CallApp(new List<object> { abiHandle, pluginAbi, callerAbi, escrowAbi, adminAbi, delegationTypeAbi, lastValidAbi, cooldownAbi, methodsAbi, useRoundsAbi, useExecutionKeyAbi, coverFeesAbi, canReclaimAbi, defaultToEscrowAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Arc58AddPlugin_Transactions(ulong plugin, Algorand.Address caller, string escrow, bool admin, byte delegationType, ulong lastValid, ulong cooldown, Structs.Arc58AddPluginArgMethods[] methods, bool useRounds, bool useExecutionKey, bool coverFees, bool canReclaim, bool defaultToEscrow, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 86, 114, 70, 46 };
            var pluginAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); pluginAbi.From(plugin);
            var callerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); callerAbi.From(caller);
            var escrowAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); escrowAbi.From(escrow);
            var adminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); adminAbi.From(admin);
            var delegationTypeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); delegationTypeAbi.From(delegationType);
            var lastValidAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); lastValidAbi.From(lastValid);
            var cooldownAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); cooldownAbi.From(cooldown);
            var methodsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.Arc58AddPluginArgMethods>(x => Structs.Arc58AddPluginArgMethods.Parse(x)) { IsFixedLength = false, FixedLength = 0 }; methodsAbi.From(methods);
            var useRoundsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); useRoundsAbi.From(useRounds);
            var useExecutionKeyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); useExecutionKeyAbi.From(useExecutionKey);
            var coverFeesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); coverFeesAbi.From(coverFees);
            var canReclaimAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); canReclaimAbi.From(canReclaim);
            var defaultToEscrowAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); defaultToEscrowAbi.From(defaultToEscrow);

            return await base.MakeTransactionList(new List<object> { abiHandle, pluginAbi, callerAbi, escrowAbi, adminAbi, delegationTypeAbi, lastValidAbi, cooldownAbi, methodsAbi, useRoundsAbi, useExecutionKeyAbi, coverFeesAbi, canReclaimAbi, defaultToEscrowAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="name"> </param>
        /// <param name="plugin"> </param>
        /// <param name="caller"> </param>
        /// <param name="escrow"> </param>
        /// <param name="admin"> </param>
        /// <param name="delegationType"> </param>
        /// <param name="lastValid"> </param>
        /// <param name="cooldown"> </param>
        /// <param name="methods"> Arc58AddPluginArgMethods</param>
        /// <param name="useRounds"> </param>
        /// <param name="useExecutionKey"> </param>
        /// <param name="coverFees"> </param>
        /// <param name="canReclaim"> </param>
        /// <param name="defaultToEscrow"> </param>
        public async Task Arc58AddNamedPlugin(string name, ulong plugin, Algorand.Address caller, string escrow, bool admin, byte delegationType, ulong lastValid, ulong cooldown, Structs.Arc58AddPluginArgMethods[] methods, bool useRounds, bool useExecutionKey, bool coverFees, bool canReclaim, bool defaultToEscrow, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 87, 47, 209, 234 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);
            var pluginAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); pluginAbi.From(plugin);
            var callerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); callerAbi.From(caller);
            var escrowAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); escrowAbi.From(escrow);
            var adminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); adminAbi.From(admin);
            var delegationTypeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); delegationTypeAbi.From(delegationType);
            var lastValidAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); lastValidAbi.From(lastValid);
            var cooldownAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); cooldownAbi.From(cooldown);
            var methodsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.Arc58AddPluginArgMethods>(x => Structs.Arc58AddPluginArgMethods.Parse(x)) { IsFixedLength = false, FixedLength = 0 }; methodsAbi.From(methods);
            var useRoundsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); useRoundsAbi.From(useRounds);
            var useExecutionKeyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); useExecutionKeyAbi.From(useExecutionKey);
            var coverFeesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); coverFeesAbi.From(coverFees);
            var canReclaimAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); canReclaimAbi.From(canReclaim);
            var defaultToEscrowAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); defaultToEscrowAbi.From(defaultToEscrow);

            var result = await base.CallApp(new List<object> { abiHandle, nameAbi, pluginAbi, callerAbi, escrowAbi, adminAbi, delegationTypeAbi, lastValidAbi, cooldownAbi, methodsAbi, useRoundsAbi, useExecutionKeyAbi, coverFeesAbi, canReclaimAbi, defaultToEscrowAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Arc58AddNamedPlugin_Transactions(string name, ulong plugin, Algorand.Address caller, string escrow, bool admin, byte delegationType, ulong lastValid, ulong cooldown, Structs.Arc58AddPluginArgMethods[] methods, bool useRounds, bool useExecutionKey, bool coverFees, bool canReclaim, bool defaultToEscrow, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 87, 47, 209, 234 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);
            var pluginAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); pluginAbi.From(plugin);
            var callerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); callerAbi.From(caller);
            var escrowAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); escrowAbi.From(escrow);
            var adminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); adminAbi.From(admin);
            var delegationTypeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); delegationTypeAbi.From(delegationType);
            var lastValidAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); lastValidAbi.From(lastValid);
            var cooldownAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); cooldownAbi.From(cooldown);
            var methodsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.Arc58AddPluginArgMethods>(x => Structs.Arc58AddPluginArgMethods.Parse(x)) { IsFixedLength = false, FixedLength = 0 }; methodsAbi.From(methods);
            var useRoundsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); useRoundsAbi.From(useRounds);
            var useExecutionKeyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); useExecutionKeyAbi.From(useExecutionKey);
            var coverFeesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); coverFeesAbi.From(coverFees);
            var canReclaimAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); canReclaimAbi.From(canReclaim);
            var defaultToEscrowAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); defaultToEscrowAbi.From(defaultToEscrow);

            return await base.MakeTransactionList(new List<object> { abiHandle, nameAbi, pluginAbi, callerAbi, escrowAbi, adminAbi, delegationTypeAbi, lastValidAbi, cooldownAbi, methodsAbi, useRoundsAbi, useExecutionKeyAbi, coverFeesAbi, canReclaimAbi, defaultToEscrowAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="name"> </param>
        public async Task<Structs.PluginKey> Arc58GetNamedPluginKey(string name, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 119, 39, 248, 81 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);

            var result = await base.SimApp(new List<object> { abiHandle, nameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.PluginKey.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> Arc58GetNamedPluginKey_Transactions(string name, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 119, 39, 248, 81 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);

            return await base.MakeTransactionList(new List<object> { abiHandle, nameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="plugin"> </param>
        /// <param name="caller"> </param>
        /// <param name="escrow"> </param>
        public async Task Arc58RemovePlugin(ulong plugin, Algorand.Address caller, string escrow, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 238, 244, 72, 253 };
            var pluginAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); pluginAbi.From(plugin);
            var callerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); callerAbi.From(caller);
            var escrowAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); escrowAbi.From(escrow);

            var result = await base.CallApp(new List<object> { abiHandle, pluginAbi, callerAbi, escrowAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Arc58RemovePlugin_Transactions(ulong plugin, Algorand.Address caller, string escrow, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 238, 244, 72, 253 };
            var pluginAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); pluginAbi.From(plugin);
            var callerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); callerAbi.From(caller);
            var escrowAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); escrowAbi.From(escrow);

            return await base.MakeTransactionList(new List<object> { abiHandle, pluginAbi, callerAbi, escrowAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="name"> </param>
        public async Task Arc58RemoveNamedPlugin(string name, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 227, 80, 185, 212 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);

            var result = await base.CallApp(new List<object> { abiHandle, nameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Arc58RemoveNamedPlugin_Transactions(string name, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 227, 80, 185, 212 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);

            return await base.MakeTransactionList(new List<object> { abiHandle, nameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="escrow"> </param>
        /// <param name="address"> </param>
        public async Task<ulong> Arc58NewEscrow(string escrow, Algorand.Address address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 223, 73, 180, 253 };
            var escrowAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); escrowAbi.From(escrow);
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);

            var result = await base.CallApp(new List<object> { abiHandle, escrowAbi, addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Arc58NewEscrow_Transactions(string escrow, Algorand.Address address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 223, 73, 180, 253 };
            var escrowAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); escrowAbi.From(escrow);
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);

            return await base.MakeTransactionList(new List<object> { abiHandle, escrowAbi, addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="escrow"> </param>
        public async Task<Structs.EscrowInfo> Arc58ToggleEscrowLock(string escrow, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 9, 67, 186, 185 };
            var escrowAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); escrowAbi.From(escrow);

            var result = await base.CallApp(new List<object> { abiHandle, escrowAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.EscrowInfo.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> Arc58ToggleEscrowLock_Transactions(string escrow, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 9, 67, 186, 185 };
            var escrowAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); escrowAbi.From(escrow);

            return await base.MakeTransactionList(new List<object> { abiHandle, escrowAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="escrow"> </param>
        /// <param name="reclaims"> Arc58ReclaimArgReclaims</param>
        public async Task Arc58Reclaim(string escrow, Structs.Arc58ReclaimArgReclaims[] reclaims, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 235, 175, 20, 160 };
            var escrowAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); escrowAbi.From(escrow);
            var reclaimsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.Arc58ReclaimArgReclaims>(x => Structs.Arc58ReclaimArgReclaims.Parse(x)) { IsFixedLength = false, FixedLength = 0 }; reclaimsAbi.From(reclaims);

            var result = await base.CallApp(new List<object> { abiHandle, escrowAbi, reclaimsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Arc58Reclaim_Transactions(string escrow, Structs.Arc58ReclaimArgReclaims[] reclaims, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 235, 175, 20, 160 };
            var escrowAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); escrowAbi.From(escrow);
            var reclaimsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.Arc58ReclaimArgReclaims>(x => Structs.Arc58ReclaimArgReclaims.Parse(x)) { IsFixedLength = false, FixedLength = 0 }; reclaimsAbi.From(reclaims);

            return await base.MakeTransactionList(new List<object> { abiHandle, escrowAbi, reclaimsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="newAdmin"> </param>
        public async Task Arc58ChangeAdmin(Algorand.Address newAdmin, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 210, 75, 117, 86 };
            var newAdminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); newAdminAbi.From(newAdmin);

            var result = await base.CallApp(new List<object> { abiHandle, newAdminAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Arc58ChangeAdmin_Transactions(Algorand.Address newAdmin, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 210, 75, 117, 86 };
            var newAdminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); newAdminAbi.From(newAdmin);

            return await base.MakeTransactionList(new List<object> { abiHandle, newAdminAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="escrow"> </param>
        /// <param name="allowances"> Arc58AddAllowancesArgAllowances</param>
        public async Task Arc58AddAllowances(string escrow, Structs.Arc58AddAllowancesArgAllowances[] allowances, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 191, 77, 124, 87 };
            var escrowAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); escrowAbi.From(escrow);
            var allowancesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.Arc58AddAllowancesArgAllowances>(x => Structs.Arc58AddAllowancesArgAllowances.Parse(x)) { IsFixedLength = false, FixedLength = 0 }; allowancesAbi.From(allowances);

            var result = await base.CallApp(new List<object> { abiHandle, escrowAbi, allowancesAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Arc58AddAllowances_Transactions(string escrow, Structs.Arc58AddAllowancesArgAllowances[] allowances, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 191, 77, 124, 87 };
            var escrowAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); escrowAbi.From(escrow);
            var allowancesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.Arc58AddAllowancesArgAllowances>(x => Structs.Arc58AddAllowancesArgAllowances.Parse(x)) { IsFixedLength = false, FixedLength = 0 }; allowancesAbi.From(allowances);

            return await base.MakeTransactionList(new List<object> { abiHandle, escrowAbi, allowancesAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="escrow"> </param>
        /// <param name="assets"> </param>
        public async Task Arc58RemoveAllowances(string escrow, ulong[] assets, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 213, 221, 56, 43 };
            var escrowAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); escrowAbi.From(escrow);
            var assetsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); assetsAbi.From(assets);

            var result = await base.CallApp(new List<object> { abiHandle, escrowAbi, assetsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Arc58RemoveAllowances_Transactions(string escrow, ulong[] assets, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 213, 221, 56, 43 };
            var escrowAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); escrowAbi.From(escrow);
            var assetsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); assetsAbi.From(assets);

            return await base.MakeTransactionList(new List<object> { abiHandle, escrowAbi, assetsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="lease"> </param>
        /// <param name="groups"> </param>
        /// <param name="firstValid"> </param>
        /// <param name="lastValid"> </param>
        public async Task Arc58AddExecutionKey(byte[] lease, byte[][] groups, ulong firstValid, ulong lastValid, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 92, 235, 237, 67 };
            var leaseAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); leaseAbi.From(lease);
            var groupsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>>("byte[32]"); groupsAbi.From(groups);
            var firstValidAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); firstValidAbi.From(firstValid);
            var lastValidAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); lastValidAbi.From(lastValid);

            var result = await base.CallApp(new List<object> { abiHandle, leaseAbi, groupsAbi, firstValidAbi, lastValidAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Arc58AddExecutionKey_Transactions(byte[] lease, byte[][] groups, ulong firstValid, ulong lastValid, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 92, 235, 237, 67 };
            var leaseAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); leaseAbi.From(lease);
            var groupsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>>("byte[32]"); groupsAbi.From(groups);
            var firstValidAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); firstValidAbi.From(firstValid);
            var lastValidAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); lastValidAbi.From(lastValid);

            return await base.MakeTransactionList(new List<object> { abiHandle, leaseAbi, groupsAbi, firstValidAbi, lastValidAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="lease"> </param>
        public async Task Arc58RemoveExecutionKey(byte[] lease, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 213, 134, 133, 175 };
            var leaseAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); leaseAbi.From(lease);

            var result = await base.CallApp(new List<object> { abiHandle, leaseAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Arc58RemoveExecutionKey_Transactions(byte[] lease, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 213, 134, 133, 175 };
            var leaseAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); leaseAbi.From(lease);

            return await base.MakeTransactionList(new List<object> { abiHandle, leaseAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Submit an app update from the wallet application address for Guild update-path tests.
        ///</summary>
        /// <param name="guild"> </param>
        /// <param name="approvalProgramFirst"> </param>
        /// <param name="approvalProgramSecond"> </param>
        /// <param name="clearStateProgram"> </param>
        /// <param name="version"> </param>
        public async Task UpdateGuild(ulong guild, byte[] approvalProgramFirst, byte[] approvalProgramSecond, byte[] clearStateProgram, string version, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 159, 174, 116, 208 };
            var guildAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); guildAbi.From(guild);
            var approvalProgramFirstAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); approvalProgramFirstAbi.From(approvalProgramFirst);
            var approvalProgramSecondAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); approvalProgramSecondAbi.From(approvalProgramSecond);
            var clearStateProgramAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); clearStateProgramAbi.From(clearStateProgram);
            var versionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); versionAbi.From(version);

            var result = await base.CallApp(new List<object> { abiHandle, guildAbi, approvalProgramFirstAbi, approvalProgramSecondAbi, clearStateProgramAbi, versionAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateGuild_Transactions(ulong guild, byte[] approvalProgramFirst, byte[] approvalProgramSecond, byte[] clearStateProgram, string version, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 159, 174, 116, 208 };
            var guildAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); guildAbi.From(guild);
            var approvalProgramFirstAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); approvalProgramFirstAbi.From(approvalProgramFirst);
            var approvalProgramSecondAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); approvalProgramSecondAbi.From(approvalProgramSecond);
            var clearStateProgramAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); clearStateProgramAbi.From(clearStateProgram);
            var versionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); versionAbi.From(version);

            return await base.MakeTransactionList(new List<object> { abiHandle, guildAbi, approvalProgramFirstAbi, approvalProgramSecondAbi, clearStateProgramAbi, versionAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Algorand.Address> Arc58GetAdmin(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 19, 188, 68, 228 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> Arc58GetAdmin_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 19, 188, 68, 228 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTW9ja0d1aWxkV2FsbGV0IiwiZGVzYyI6Ik1pbmltYWwgQVJDLTU4IGFkbWluaXN0cmF0aW9uIHN1cmZhY2UgdXNlZCBvbmx5IGJ5IEd1aWxkIGludGVncmF0aW9uIHRlc3RzLiIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJFc2Nyb3dJbmZvIjpbeyJuYW1lIjoiaWQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiYWRkcmVzcyIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoibG9ja2VkIiwidHlwZSI6ImJvb2wifV0sIlBsdWdpbktleSI6W3sibmFtZSI6InBsdWdpbiIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJjYWxsZXIiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6ImVzY3JvdyIsInR5cGUiOiJzdHJpbmcifV0sIkFyYzU4QWRkUGx1Z2luQXJnTWV0aG9kcyI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJieXRlWzRdIn0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InVpbnQ2NCJ9XSwiQXJjNThSZWNsYWltQXJnUmVjbGFpbXMiOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMiIsInR5cGUiOiJib29sIn1dLCJBcmM1OEFkZEFsbG93YW5jZXNBcmdBbGxvd2FuY2VzIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJ1aW50OCJ9LHsibmFtZSI6ImZpZWxkMiIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDMiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQ0IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkNSIsInR5cGUiOiJib29sIn1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWRtaW4iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0QWRtaW4iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFkbWluIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFyYzU4X2FkZFBsdWdpbiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwbHVnaW4iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjYWxsZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImVzY3JvdyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFkbWluIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50OCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRlbGVnYXRpb25UeXBlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJsYXN0VmFsaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNvb2xkb3duIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiIoYnl0ZVs0XSx1aW50NjQpW10iLCJzdHJ1Y3QiOiJBcmM1OEFkZFBsdWdpbkFyZ01ldGhvZHMiLCJuYW1lIjoibWV0aG9kcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVzZVJvdW5kcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVzZUV4ZWN1dGlvbktleSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNvdmVyRmVlcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhblJlY2xhaW0iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkZWZhdWx0VG9Fc2Nyb3ciLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXJjNThfYWRkTmFtZWRQbHVnaW4iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmFtZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGx1Z2luIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FsbGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJlc2Nyb3ciLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZG1pbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDgiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkZWxlZ2F0aW9uVHlwZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibGFzdFZhbGlkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjb29sZG93biIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiKGJ5dGVbNF0sdWludDY0KVtdIiwic3RydWN0IjoiQXJjNThBZGRQbHVnaW5BcmdNZXRob2RzIiwibmFtZSI6Im1ldGhvZHMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1c2VSb3VuZHMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1c2VFeGVjdXRpb25LZXkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjb3ZlckZlZXMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjYW5SZWNsYWltIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGVmYXVsdFRvRXNjcm93IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFyYzU4X2dldE5hbWVkUGx1Z2luS2V5IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5hbWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCxhZGRyZXNzLHN0cmluZykiLCJzdHJ1Y3QiOiJQbHVnaW5LZXkiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFyYzU4X3JlbW92ZVBsdWdpbiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwbHVnaW4iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjYWxsZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImVzY3JvdyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcmM1OF9yZW1vdmVOYW1lZFBsdWdpbiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuYW1lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFyYzU4X25ld0VzY3JvdyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJlc2Nyb3ciLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXJjNThfdG9nZ2xlRXNjcm93TG9jayIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJlc2Nyb3ciLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCxhZGRyZXNzLGJvb2wpIiwic3RydWN0IjoiRXNjcm93SW5mbyIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFyYzU4X3JlY2xhaW0iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZXNjcm93IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiIodWludDY0LHVpbnQ2NCxib29sKVtdIiwic3RydWN0IjoiQXJjNThSZWNsYWltQXJnUmVjbGFpbXMiLCJuYW1lIjoicmVjbGFpbXMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXJjNThfY2hhbmdlQWRtaW4iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld0FkbWluIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFyYzU4X2FkZEFsbG93YW5jZXMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZXNjcm93IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiIodWludDY0LHVpbnQ4LHVpbnQ2NCx1aW50NjQsdWludDY0LGJvb2wpW10iLCJzdHJ1Y3QiOiJBcmM1OEFkZEFsbG93YW5jZXNBcmdBbGxvd2FuY2VzIiwibmFtZSI6ImFsbG93YW5jZXMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXJjNThfcmVtb3ZlQWxsb3dhbmNlcyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJlc2Nyb3ciLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NFtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXRzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFyYzU4X2FkZEV4ZWN1dGlvbktleSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlWzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImxlYXNlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlWzMyXVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZ3JvdXBzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaXJzdFZhbGlkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJsYXN0VmFsaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXJjNThfcmVtb3ZlRXhlY3V0aW9uS2V5IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImJ5dGVbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoibGVhc2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidXBkYXRlR3VpbGQiLCJkZXNjIjoiU3VibWl0IGFuIGFwcCB1cGRhdGUgZnJvbSB0aGUgd2FsbGV0IGFwcGxpY2F0aW9uIGFkZHJlc3MgZm9yIEd1aWxkIHVwZGF0ZS1wYXRoIHRlc3RzLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJndWlsZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXBwcm92YWxQcm9ncmFtRmlyc3QiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFwcHJvdmFsUHJvZ3JhbVNlY29uZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2xlYXJTdGF0ZVByb2dyYW0iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZlcnNpb24iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXJjNThfZ2V0QWRtaW4iLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MywiYnl0ZXMiOjJ9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzU4Ml0sImVycm9yTWVzc2FnZSI6IkJveCBtdXN0IGhhdmUgdmFsdWUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3MDUsMTA1OSwxMDczXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgR2xvYmFsU3RhdGUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjg3LDMyNywzODQsNDE4LDQ2Miw1NjUsNjEwLDYyOSw2NDgsNjkwLDc3NCw3ODYsODI3LDgzOSw4NjEsODczLDkwMiw5NjIsOTc4LDk5NCwxMDEwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzAwLDM0MywzNTAsMzU3LDM2NCwzNzEsNDM1LDQ3OCw0ODUsNDkyLDQ5OSw1MDddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5ib29sIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjkzLDM5MSw0MjUsNTcyLDYxNiw2MzUsNjU0LDY5Niw3ODAsODMzLDg2Nyw5NjksOTg1LDEwMDEsMTAxN10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5MTFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGJ5dGVzWzMyXT4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4NDhdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PHNtYXJ0X2NvbnRyYWN0cy9hcmM1OC9hY2NvdW50L3R5cGVzLnRzOjpBZGRBbGxvd2FuY2VJbmZvPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc5NV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8c21hcnRfY29udHJhY3RzL2FyYzU4L2FjY291bnQvdHlwZXMudHM6OkVzY3Jvd1JlY2xhaW0+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzM2LDQ3MV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8c21hcnRfY29udHJhY3RzL2FyYzU4L2FjY291bnQvdHlwZXMudHM6Ok1ldGhvZFJlc3RyaWN0aW9uPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzg4MV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8dWludDY0PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIyNCwyNjEsMjgxLDQxMiw2MDQsNjYyLDgxMSw4OTYsOTQwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI3MywzMTQsMzIxLDQwMiw0NDksNDU2LDU5Niw5MTgsOTI1LDk1NV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMwNyw0NDJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50OCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTVNBd0lESWdPQW9nSUNBZ1lubDBaV05pYkc5amF5QWlZV1J0YVc0aUlDSmhZM1JwYjI1ZlkyOTFiblFpSUNKbGMyTnliM2RmYkc5amEyVmtJaUFpYkdGemRGOWhZM1JwYjI0aUlEQjRNVFV4Wmpkak56VUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmlibm9nYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOW5kV2xzWkhNdmRHVnpkSE12Ylc5amF5MTNZV3hzWlhRdVlXeG5ieTUwY3pveU9Rb2dJQ0FnTHk4Z1lXTjBhVzl1UTI5MWJuUWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0hzZ2FXNXBkR2xoYkZaaGJIVmxPaUF3TENCclpYazZJRTF2WTJ0SGRXbHNaRmRoYkd4bGRFZHNiMkpoYkZOMFlYUmxTMlY1UVdOMGFXOXVRMjkxYm5RZ2ZTa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltRmpkR2x2Ymw5amIzVnVkQ0lLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDJkMWFXeGtjeTkwWlhOMGN5OXRiMk5yTFhkaGJHeGxkQzVoYkdkdkxuUnpPak13Q2lBZ0lDQXZMeUJzWVhOMFFXTjBhVzl1SUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpaDdJR2x1YVhScFlXeFdZV3gxWlRvZ01Dd2dhMlY1T2lCTmIyTnJSM1ZwYkdSWFlXeHNaWFJIYkc5aVlXeFRkR0YwWlV0bGVVeGhjM1JCWTNScGIyNGdmU2tLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbXhoYzNSZllXTjBhVzl1SWdvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndlozVnBiR1J6TDNSbGMzUnpMMjF2WTJzdGQyRnNiR1YwTG1Gc1oyOHVkSE02TXpFS0lDQWdJQzh2SUdWelkzSnZkMHh2WTJ0bFpDQTlJRWRzYjJKaGJGTjBZWFJsUEdKdmIyeGxZVzQrS0hzZ2FXNXBkR2xoYkZaaGJIVmxPaUJtWVd4elpTd2dhMlY1T2lCTmIyTnJSM1ZwYkdSWFlXeHNaWFJIYkc5aVlXeFRkR0YwWlV0bGVVVnpZM0p2ZDB4dlkydGxaQ0I5S1FvZ0lDQWdZbmwwWldOZk1pQXZMeUFpWlhOamNtOTNYMnh2WTJ0bFpDSUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb0tiV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndlozVnBiR1J6TDNSbGMzUnpMMjF2WTJzdGQyRnNiR1YwTG1Gc1oyOHVkSE02TWpRS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5Qk5iMk5yUjNWcGJHUlhZV3hzWlhRZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmllaUJ0WVdsdVgyTnlaV0YwWlY5T2IwOXdRREl5Q2lBZ0lDQndkWE5vWW5sMFpYTnpJREI0TVRjNE5qWTVNVElnTUhnMU5qY3lORFl5WlNBd2VEVTNNbVprTVdWaElEQjROemN5TjJZNE5URWdNSGhsWldZME5EaG1aQ0F3ZUdVek5UQmlPV1EwSURCNFpHWTBPV0kwWm1RZ01IZ3dPVFF6WW1GaU9TQXdlR1ZpWVdZeE5HRXdJREI0WkRJMFlqYzFOVFlnTUhoaVpqUmtOMk0xTnlBd2VHUTFaR1F6T0RKaUlEQjROV05sWW1Wa05ETWdNSGhrTlRnMk9EVmhaaUF3ZURsbVlXVTNOR1F3SURCNE1UTmlZelEwWlRRZ0x5OGdiV1YwYUc5a0lDSnpaWFJCWkcxcGJpaGhaR1J5WlhOektYWnZhV1FpTENCdFpYUm9iMlFnSW1GeVl6VTRYMkZrWkZCc2RXZHBiaWgxYVc1ME5qUXNZV1JrY21WemN5eHpkSEpwYm1jc1ltOXZiQ3gxYVc1ME9DeDFhVzUwTmpRc2RXbHVkRFkwTENoaWVYUmxXelJkTEhWcGJuUTJOQ2xiWFN4aWIyOXNMR0p2YjJ3c1ltOXZiQ3hpYjI5c0xHSnZiMndwZG05cFpDSXNJRzFsZEdodlpDQWlZWEpqTlRoZllXUmtUbUZ0WldSUWJIVm5hVzRvYzNSeWFXNW5MSFZwYm5RMk5DeGhaR1J5WlhOekxITjBjbWx1Wnl4aWIyOXNMSFZwYm5RNExIVnBiblEyTkN4MWFXNTBOalFzS0dKNWRHVmJORjBzZFdsdWREWTBLVnRkTEdKdmIyd3NZbTl2YkN4aWIyOXNMR0p2YjJ3c1ltOXZiQ2wyYjJsa0lpd2diV1YwYUc5a0lDSmhjbU0xT0Y5blpYUk9ZVzFsWkZCc2RXZHBia3RsZVNoemRISnBibWNwS0hWcGJuUTJOQ3hoWkdSeVpYTnpMSE4wY21sdVp5a2lMQ0J0WlhSb2IyUWdJbUZ5WXpVNFgzSmxiVzkyWlZCc2RXZHBiaWgxYVc1ME5qUXNZV1JrY21WemN5eHpkSEpwYm1jcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWVhKak5UaGZjbVZ0YjNabFRtRnRaV1JRYkhWbmFXNG9jM1J5YVc1bktYWnZhV1FpTENCdFpYUm9iMlFnSW1GeVl6VTRYMjVsZDBWelkzSnZkeWh6ZEhKcGJtY3NZV1JrY21WemN5bDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0ltRnlZelU0WDNSdloyZHNaVVZ6WTNKdmQweHZZMnNvYzNSeWFXNW5LU2gxYVc1ME5qUXNZV1JrY21WemN5eGliMjlzS1NJc0lHMWxkR2h2WkNBaVlYSmpOVGhmY21WamJHRnBiU2h6ZEhKcGJtY3NLSFZwYm5RMk5DeDFhVzUwTmpRc1ltOXZiQ2xiWFNsMmIybGtJaXdnYldWMGFHOWtJQ0poY21NMU9GOWphR0Z1WjJWQlpHMXBiaWhoWkdSeVpYTnpLWFp2YVdRaUxDQnRaWFJvYjJRZ0ltRnlZelU0WDJGa1pFRnNiRzkzWVc1alpYTW9jM1J5YVc1bkxDaDFhVzUwTmpRc2RXbHVkRGdzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc1ltOXZiQ2xiWFNsMmIybGtJaXdnYldWMGFHOWtJQ0poY21NMU9GOXlaVzF2ZG1WQmJHeHZkMkZ1WTJWektITjBjbWx1Wnl4MWFXNTBOalJiWFNsMmIybGtJaXdnYldWMGFHOWtJQ0poY21NMU9GOWhaR1JGZUdWamRYUnBiMjVMWlhrb1lubDBaVnN6TWwwc1lubDBaVnN6TWwxYlhTeDFhVzUwTmpRc2RXbHVkRFkwS1hadmFXUWlMQ0J0WlhSb2IyUWdJbUZ5WXpVNFgzSmxiVzkyWlVWNFpXTjFkR2x2Ymt0bGVTaGllWFJsV3pNeVhTbDJiMmxrSWl3Z2JXVjBhRzlrSUNKMWNHUmhkR1ZIZFdsc1pDaDFhVzUwTmpRc1lubDBaVnRkTEdKNWRHVmJYU3hpZVhSbFcxMHNjM1J5YVc1bktYWnZhV1FpTENCdFpYUm9iMlFnSW1GeVl6VTRYMmRsZEVGa2JXbHVLQ2xoWkdSeVpYTnpJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnYzJWMFFXUnRhVzRnWVhKak5UaGZZV1JrVUd4MVoybHVJR0Z5WXpVNFgyRmtaRTVoYldWa1VHeDFaMmx1SUdGeVl6VTRYMmRsZEU1aGJXVmtVR3gxWjJsdVMyVjVJR0Z5WXpVNFgzSmxiVzkyWlZCc2RXZHBiaUJoY21NMU9GOXlaVzF2ZG1WT1lXMWxaRkJzZFdkcGJpQmhjbU0xT0Y5dVpYZEZjMk55YjNjZ1lYSmpOVGhmZEc5bloyeGxSWE5qY205M1RHOWpheUJoY21NMU9GOXlaV05zWVdsdElHRnlZelU0WDJOb1lXNW5aVUZrYldsdUlHRnlZelU0WDJGa1pFRnNiRzkzWVc1alpYTWdZWEpqTlRoZmNtVnRiM1psUVd4c2IzZGhibU5sY3lCaGNtTTFPRjloWkdSRmVHVmpkWFJwYjI1TFpYa2dZWEpqTlRoZmNtVnRiM1psUlhobFkzVjBhVzl1UzJWNUlIVndaR0YwWlVkMWFXeGtJR0Z5WXpVNFgyZGxkRUZrYldsdUNpQWdJQ0JsY25JS0NtMWhhVzVmWTNKbFlYUmxYMDV2VDNCQU1qSTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2WjNWcGJHUnpMM1JsYzNSekwyMXZZMnN0ZDJGc2JHVjBMbUZzWjI4dWRITTZNalFLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCTmIyTnJSM1ZwYkdSWFlXeHNaWFFnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGhqWXpZNU5HVmhZU0F2THlCdFpYUm9iMlFnSW1OeVpXRjBaU2hoWkdSeVpYTnpLWFp2YVdRaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQmpjbVZoZEdVS0lDQWdJR1Z5Y2dvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5bmRXbHNaSE12ZEdWemRITXZiVzlqYXkxM1lXeHNaWFF1WVd4bmJ5NTBjem82VFc5amEwZDFhV3hrVjJGc2JHVjBMbU55WldGMFpWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbU55WldGMFpUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzluZFdsc1pITXZkR1Z6ZEhNdmJXOWpheTEzWVd4c1pYUXVZV3huYnk1MGN6b3pPQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUc5dVEzSmxZWFJsT2lBbmNtVnhkV2x5WlNjZ2ZTa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOW5kV2xzWkhNdmRHVnpkSE12Ylc5amF5MTNZV3hzWlhRdVlXeG5ieTUwY3pveU5nb2dJQ0FnTHk4Z1lXUnRhVzRnUFNCSGJHOWlZV3hUZEdGMFpUeEJZMk52ZFc1MFBpaDdJR3RsZVRvZ1RXOWphMGQxYVd4a1YyRnNiR1YwUjJ4dlltRnNVM1JoZEdWTFpYbEJaRzFwYmlCOUtRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVlXUnRhVzRpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndlozVnBiR1J6TDNSbGMzUnpMMjF2WTJzdGQyRnNiR1YwTG1Gc1oyOHVkSE02TkRBS0lDQWdJQzh2SUhSb2FYTXVZV1J0YVc0dWRtRnNkV1VnUFNCaFpHMXBiZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5bmRXbHNaSE12ZEdWemRITXZiVzlqYXkxM1lXeHNaWFF1WVd4bmJ5NTBjem95T0FvZ0lDQWdMeThnWTI5dWRISnZiR3hsWkVGa1pISmxjM01nUFNCSGJHOWlZV3hUZEdGMFpUeEJZMk52ZFc1MFBpaDdJR3RsZVRvZ1FXSnpkSEpoWTNSQlkyTnZkVzUwUjJ4dlltRnNVM1JoZEdWTFpYbHpRMjl1ZEhKdmJHeGxaRUZrWkhKbGMzTWdmU2tLSUNBZ0lIQjFjMmhpZVhSbGN5QWlZMjl1ZEhKdmJHeGxaRjloWkdSeVpYTnpJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDJkMWFXeGtjeTkwWlhOMGN5OXRiMk5yTFhkaGJHeGxkQzVoYkdkdkxuUnpPalF4Q2lBZ0lDQXZMeUIwYUdsekxtTnZiblJ5YjJ4c1pXUkJaR1J5WlhOekxuWmhiSFZsSUQwZ1IyeHZZbUZzTG1OMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyZDFhV3hrY3k5MFpYTjBjeTl0YjJOckxYZGhiR3hsZEM1aGJHZHZMblJ6T2pNNENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2diMjVEY21WaGRHVTZJQ2R5WlhGMWFYSmxKeUI5S1FvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5bmRXbHNaSE12ZEdWemRITXZiVzlqYXkxM1lXeHNaWFF1WVd4bmJ5NTBjem82VFc5amEwZDFhV3hrVjJGc2JHVjBMbk5sZEVGa2JXbHVXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYzJWMFFXUnRhVzQ2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndlozVnBiR1J6TDNSbGMzUnpMMjF2WTJzdGQyRnNiR1YwTG1Gc1oyOHVkSE02TkRRS0lDQWdJQzh2SUhObGRFRmtiV2x1S0dGa2JXbHVPaUJCWTJOdmRXNTBLVG9nZG05cFpDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0F6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZaM1ZwYkdSekwzUmxjM1J6TDIxdlkyc3RkMkZzYkdWMExtRnNaMjh1ZEhNNk1qWUtJQ0FnSUM4dklHRmtiV2x1SUQwZ1IyeHZZbUZzVTNSaGRHVThRV05qYjNWdWRENG9leUJyWlhrNklFMXZZMnRIZFdsc1pGZGhiR3hsZEVkc2IySmhiRk4wWVhSbFMyVjVRV1J0YVc0Z2ZTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltRmtiV2x1SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyZDFhV3hrY3k5MFpYTjBjeTl0YjJOckxYZGhiR3hsZEM1aGJHZHZMblJ6T2pRMUNpQWdJQ0F2THlCMGFHbHpMbUZrYldsdUxuWmhiSFZsSUQwZ1lXUnRhVzRLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndlozVnBiR1J6TDNSbGMzUnpMMjF2WTJzdGQyRnNiR1YwTG1Gc1oyOHVkSE02TkRRS0lDQWdJQzh2SUhObGRFRmtiV2x1S0dGa2JXbHVPaUJCWTJOdmRXNTBLVG9nZG05cFpDQjdDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMMmQxYVd4a2N5OTBaWE4wY3k5dGIyTnJMWGRoYkd4bGRDNWhiR2R2TG5Sek9qcE5iMk5yUjNWcGJHUlhZV3hzWlhRdVlYSmpOVGhmWVdSa1VHeDFaMmx1VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1lYSmpOVGhmWVdSa1VHeDFaMmx1T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyZDFhV3hrY3k5MFpYTjBjeTl0YjJOckxYZGhiR3hsZEM1aGJHZHZMblJ6T2pRNExUWXlDaUFnSUNBdkx5QmhjbU0xT0Y5aFpHUlFiSFZuYVc0b0NpQWdJQ0F2THlBZ0lIQnNkV2RwYmpvZ2RXbHVkRFkwTEFvZ0lDQWdMeThnSUNCallXeHNaWEk2SUVGalkyOTFiblFzQ2lBZ0lDQXZMeUFnSUdWelkzSnZkem9nYzNSeWFXNW5MQW9nSUNBZ0x5OGdJQ0JoWkcxcGJqb2dZbTl2YkdWaGJpd0tJQ0FnSUM4dklDQWdaR1ZzWldkaGRHbHZibFI1Y0dVNklGVnBiblE0TEFvZ0lDQWdMeThnSUNCc1lYTjBWbUZzYVdRNklIVnBiblEyTkN3S0lDQWdJQzh2SUNBZ1kyOXZiR1J2ZDI0NklIVnBiblEyTkN3S0lDQWdJQzh2SUNBZ2JXVjBhRzlrY3pvZ1RXVjBhRzlrVW1WemRISnBZM1JwYjI1YlhTd0tJQ0FnSUM4dklDQWdkWE5sVW05MWJtUnpPaUJpYjI5c1pXRnVMQW9nSUNBZ0x5OGdJQ0IxYzJWRmVHVmpkWFJwYjI1TFpYazZJR0p2YjJ4bFlXNHNDaUFnSUNBdkx5QWdJR052ZG1WeVJtVmxjem9nWW05dmJHVmhiaXdLSUNBZ0lDOHZJQ0FnWTJGdVVtVmpiR0ZwYlRvZ1ltOXZiR1ZoYml3S0lDQWdJQzh2SUNBZ1pHVm1ZWFZzZEZSdlJYTmpjbTkzT2lCaWIyOXNaV0Z1TEFvZ0lDQWdMeThnS1RvZ2RtOXBaQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWliMjlzQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUExQ2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RNENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMkNpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOd29nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURnS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUhCMWMyaHBiblFnTVRJS0lDQWdJQ29LSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNBckNpQWdJQ0J6ZDJGd0NpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHh6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndllXTmpiM1Z1ZEM5MGVYQmxjeTUwY3pvNlRXVjBhRzlrVW1WemRISnBZM1JwYjI0K0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBNUNpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1KdmIyd0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERXdDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtSnZiMndLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREV4Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbUp2YjJ3S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFeUNpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1KdmIyd0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERXpDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtSnZiMndLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5bmRXbHNaSE12ZEdWemRITXZiVzlqYXkxM1lXeHNaWFF1WVd4bmJ5NTBjem8yTXdvZ0lDQWdMeThnZEdocGN5NXlaV052Y21Rb01qQXBDaUFnSUNCd2RYTm9hVzUwSURJd0NpQWdJQ0JqWVd4c2MzVmlJSEpsWTI5eVpBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMMmQxYVd4a2N5OTBaWE4wY3k5dGIyTnJMWGRoYkd4bGRDNWhiR2R2TG5Sek9qUTRMVFl5Q2lBZ0lDQXZMeUJoY21NMU9GOWhaR1JRYkhWbmFXNG9DaUFnSUNBdkx5QWdJSEJzZFdkcGJqb2dkV2x1ZERZMExBb2dJQ0FnTHk4Z0lDQmpZV3hzWlhJNklFRmpZMjkxYm5Rc0NpQWdJQ0F2THlBZ0lHVnpZM0p2ZHpvZ2MzUnlhVzVuTEFvZ0lDQWdMeThnSUNCaFpHMXBiam9nWW05dmJHVmhiaXdLSUNBZ0lDOHZJQ0FnWkdWc1pXZGhkR2x2YmxSNWNHVTZJRlZwYm5RNExBb2dJQ0FnTHk4Z0lDQnNZWE4wVm1Gc2FXUTZJSFZwYm5RMk5Dd0tJQ0FnSUM4dklDQWdZMjl2YkdSdmQyNDZJSFZwYm5RMk5Dd0tJQ0FnSUM4dklDQWdiV1YwYUc5a2N6b2dUV1YwYUc5a1VtVnpkSEpwWTNScGIyNWJYU3dLSUNBZ0lDOHZJQ0FnZFhObFVtOTFibVJ6T2lCaWIyOXNaV0Z1TEFvZ0lDQWdMeThnSUNCMWMyVkZlR1ZqZFhScGIyNUxaWGs2SUdKdmIyeGxZVzRzQ2lBZ0lDQXZMeUFnSUdOdmRtVnlSbVZsY3pvZ1ltOXZiR1ZoYml3S0lDQWdJQzh2SUNBZ1kyRnVVbVZqYkdGcGJUb2dZbTl2YkdWaGJpd0tJQ0FnSUM4dklDQWdaR1ZtWVhWc2RGUnZSWE5qY205M09pQmliMjlzWldGdUxBb2dJQ0FnTHk4Z0tUb2dkbTlwWkNCN0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyZDFhV3hrY3k5MFpYTjBjeTl0YjJOckxYZGhiR3hsZEM1aGJHZHZMblJ6T2pwTmIyTnJSM1ZwYkdSWFlXeHNaWFF1WVhKak5UaGZZV1JrVG1GdFpXUlFiSFZuYVc1YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGhjbU0xT0Y5aFpHUk9ZVzFsWkZCc2RXZHBiam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5bmRXbHNaSE12ZEdWemRITXZiVzlqYXkxM1lXeHNaWFF1WVd4bmJ5NTBjem8yTmkwNE1Rb2dJQ0FnTHk4Z1lYSmpOVGhmWVdSa1RtRnRaV1JRYkhWbmFXNG9DaUFnSUNBdkx5QWdJRzVoYldVNklITjBjbWx1Wnl3S0lDQWdJQzh2SUNBZ2NHeDFaMmx1T2lCMWFXNTBOalFzQ2lBZ0lDQXZMeUFnSUdOaGJHeGxjam9nUVdOamIzVnVkQ3dLSUNBZ0lDOHZJQ0FnWlhOamNtOTNPaUJ6ZEhKcGJtY3NDaUFnSUNBdkx5QWdJR0ZrYldsdU9pQmliMjlzWldGdUxBb2dJQ0FnTHk4Z0lDQmtaV3hsWjJGMGFXOXVWSGx3WlRvZ1ZXbHVkRGdzQ2lBZ0lDQXZMeUFnSUd4aGMzUldZV3hwWkRvZ2RXbHVkRFkwTEFvZ0lDQWdMeThnSUNCamIyOXNaRzkzYmpvZ2RXbHVkRFkwTEFvZ0lDQWdMeThnSUNCdFpYUm9iMlJ6T2lCTlpYUm9iMlJTWlhOMGNtbGpkR2x2Ymx0ZExBb2dJQ0FnTHk4Z0lDQjFjMlZTYjNWdVpITTZJR0p2YjJ4bFlXNHNDaUFnSUNBdkx5QWdJSFZ6WlVWNFpXTjFkR2x2Ymt0bGVUb2dZbTl2YkdWaGJpd0tJQ0FnSUM4dklDQWdZMjkyWlhKR1pXVnpPaUJpYjI5c1pXRnVMQW9nSUNBZ0x5OGdJQ0JqWVc1U1pXTnNZV2x0T2lCaWIyOXNaV0Z1TEFvZ0lDQWdMeThnSUNCa1pXWmhkV3gwVkc5RmMyTnliM2M2SUdKdmIyeGxZVzRzQ2lBZ0lDQXZMeUFwT2lCMmIybGtJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0F6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOUW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWliMjlzQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUEyQ2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RNENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBM0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdPQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURrS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUhCMWMyaHBiblFnTVRJS0lDQWdJQ29LSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNBckNpQWdJQ0J6ZDJGd0NpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHh6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndllXTmpiM1Z1ZEM5MGVYQmxjeTUwY3pvNlRXVjBhRzlrVW1WemRISnBZM1JwYjI0K0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeE1Bb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1aWIyOXNDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhNUW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWliMjlzQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4TWdvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVpYjI5c0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeE13b2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1aWIyOXNDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhOQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtSnZiMndLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCblpYUmlhWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5bmRXbHNaSE12ZEdWemRITXZiVzlqYXkxM1lXeHNaWFF1WVd4bmJ5NTBjem80TWdvZ0lDQWdMeThnZEdocGN5NXVZVzFsWkZCc2RXZHBibk1vYm1GdFpTa3VkbUZzZFdVZ1BTQjdJSEJzZFdkcGJpd2dZMkZzYkdWeUxDQmxjMk55YjNjNklHUmxabUYxYkhSVWIwVnpZM0p2ZHlBL0lDY25JRG9nWlhOamNtOTNJSDBLSUNBZ0lHSjZJR0Z5WXpVNFgyRmtaRTVoYldWa1VHeDFaMmx1WDNSbGNtNWhjbmxmWm1Gc2MyVkFNd29nSUNBZ2NHOXdDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lpSUtDbUZ5WXpVNFgyRmtaRTVoYldWa1VHeDFaMmx1WDNSbGNtNWhjbmxmYldWeVoyVkFORG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5bmRXbHNaSE12ZEdWemRITXZiVzlqYXkxM1lXeHNaWFF1WVd4bmJ5NTBjem80TWdvZ0lDQWdMeThnZEdocGN5NXVZVzFsWkZCc2RXZHBibk1vYm1GdFpTa3VkbUZzZFdVZ1BTQjdJSEJzZFdkcGJpd2dZMkZzYkdWeUxDQmxjMk55YjNjNklHUmxabUYxYkhSVWIwVnpZM0p2ZHlBL0lDY25JRG9nWlhOamNtOTNJSDBLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYVhSdllnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TURKaENpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDJkMWFXeGtjeTkwWlhOMGN5OXRiMk5yTFhkaGJHeGxkQzVoYkdkdkxuUnpPakkxQ2lBZ0lDQXZMeUJ1WVcxbFpGQnNkV2RwYm5NZ1BTQkNiM2hOWVhBOGMzUnlhVzVuTENCUWJIVm5hVzVMWlhrK0tIc2dhMlY1VUhKbFptbDRPaUFuYmljZ2ZTa0tJQ0FnSUhCMWMyaGllWFJsY3lBaWJpSUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZaM1ZwYkdSekwzUmxjM1J6TDIxdlkyc3RkMkZzYkdWMExtRnNaMjh1ZEhNNk9ESUtJQ0FnSUM4dklIUm9hWE11Ym1GdFpXUlFiSFZuYVc1ektHNWhiV1VwTG5aaGJIVmxJRDBnZXlCd2JIVm5hVzRzSUdOaGJHeGxjaXdnWlhOamNtOTNPaUJrWldaaGRXeDBWRzlGYzJOeWIzY2dQeUFuSnlBNklHVnpZM0p2ZHlCOUNpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDJkMWFXeGtjeTkwWlhOMGN5OXRiMk5yTFhkaGJHeGxkQzVoYkdkdkxuUnpPamd6Q2lBZ0lDQXZMeUIwYUdsekxuSmxZMjl5WkNneU1Ta0tJQ0FnSUhCMWMyaHBiblFnTWpFS0lDQWdJR05oYkd4emRXSWdjbVZqYjNKa0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZaM1ZwYkdSekwzUmxjM1J6TDIxdlkyc3RkMkZzYkdWMExtRnNaMjh1ZEhNNk5qWXRPREVLSUNBZ0lDOHZJR0Z5WXpVNFgyRmtaRTVoYldWa1VHeDFaMmx1S0FvZ0lDQWdMeThnSUNCdVlXMWxPaUJ6ZEhKcGJtY3NDaUFnSUNBdkx5QWdJSEJzZFdkcGJqb2dkV2x1ZERZMExBb2dJQ0FnTHk4Z0lDQmpZV3hzWlhJNklFRmpZMjkxYm5Rc0NpQWdJQ0F2THlBZ0lHVnpZM0p2ZHpvZ2MzUnlhVzVuTEFvZ0lDQWdMeThnSUNCaFpHMXBiam9nWW05dmJHVmhiaXdLSUNBZ0lDOHZJQ0FnWkdWc1pXZGhkR2x2YmxSNWNHVTZJRlZwYm5RNExBb2dJQ0FnTHk4Z0lDQnNZWE4wVm1Gc2FXUTZJSFZwYm5RMk5Dd0tJQ0FnSUM4dklDQWdZMjl2YkdSdmQyNDZJSFZwYm5RMk5Dd0tJQ0FnSUM4dklDQWdiV1YwYUc5a2N6b2dUV1YwYUc5a1VtVnpkSEpwWTNScGIyNWJYU3dLSUNBZ0lDOHZJQ0FnZFhObFVtOTFibVJ6T2lCaWIyOXNaV0Z1TEFvZ0lDQWdMeThnSUNCMWMyVkZlR1ZqZFhScGIyNUxaWGs2SUdKdmIyeGxZVzRzQ2lBZ0lDQXZMeUFnSUdOdmRtVnlSbVZsY3pvZ1ltOXZiR1ZoYml3S0lDQWdJQzh2SUNBZ1kyRnVVbVZqYkdGcGJUb2dZbTl2YkdWaGJpd0tJQ0FnSUM4dklDQWdaR1ZtWVhWc2RGUnZSWE5qY205M09pQmliMjlzWldGdUxBb2dJQ0FnTHk4Z0tUb2dkbTlwWkNCN0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncGhjbU0xT0Y5aFpHUk9ZVzFsWkZCc2RXZHBibDkwWlhKdVlYSjVYMlpoYkhObFFETTZDaUFnSUNCaUlHRnlZelU0WDJGa1pFNWhiV1ZrVUd4MVoybHVYM1JsY201aGNubGZiV1Z5WjJWQU5Bb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOW5kV2xzWkhNdmRHVnpkSE12Ylc5amF5MTNZV3hzWlhRdVlXeG5ieTUwY3pvNlRXOWphMGQxYVd4a1YyRnNiR1YwTG1GeVl6VTRYMmRsZEU1aGJXVmtVR3gxWjJsdVMyVjVXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWVhKak5UaGZaMlYwVG1GdFpXUlFiSFZuYVc1TFpYazZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2WjNWcGJHUnpMM1JsYzNSekwyMXZZMnN0ZDJGc2JHVjBMbUZzWjI4dWRITTZPRFlLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU0I5S1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzluZFdsc1pITXZkR1Z6ZEhNdmJXOWpheTEzWVd4c1pYUXVZV3huYnk1MGN6b3lOUW9nSUNBZ0x5OGdibUZ0WldSUWJIVm5hVzV6SUQwZ1FtOTRUV0Z3UEhOMGNtbHVaeXdnVUd4MVoybHVTMlY1UGloN0lHdGxlVkJ5WldacGVEb2dKMjRuSUgwcENpQWdJQ0J3ZFhOb1lubDBaWE1nSW00aUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzluZFdsc1pITXZkR1Z6ZEhNdmJXOWpheTEzWVd4c1pYUXVZV3huYnk1MGN6bzRPQW9nSUNBZ0x5OGdjbVYwZFhKdUlIUm9hWE11Ym1GdFpXUlFiSFZuYVc1ektHNWhiV1VwTG5aaGJIVmxDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmhjM05sY25RZ0x5OGdRbTk0SUcxMWMzUWdhR0YyWlNCMllXeDFaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDJkMWFXeGtjeTkwWlhOMGN5OXRiMk5yTFhkaGJHeGxkQzVoYkdkdkxuUnpPamcyQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ2NtVmhaRzl1YkhrNklIUnlkV1VnZlNrS0lDQWdJR0o1ZEdWaklEUWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndlozVnBiR1J6TDNSbGMzUnpMMjF2WTJzdGQyRnNiR1YwTG1Gc1oyOHVkSE02T2sxdlkydEhkV2xzWkZkaGJHeGxkQzVoY21NMU9GOXlaVzF2ZG1WUWJIVm5hVzViY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwaGNtTTFPRjl5WlcxdmRtVlFiSFZuYVc0NkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZaM1ZwYkdSekwzUmxjM1J6TDIxdlkyc3RkMkZzYkdWMExtRnNaMjh1ZEhNNk9URUtJQ0FnSUM4dklHRnlZelU0WDNKbGJXOTJaVkJzZFdkcGJpaHdiSFZuYVc0NklIVnBiblEyTkN3Z1kyRnNiR1Z5T2lCQlkyTnZkVzUwTENCbGMyTnliM2M2SUhOMGNtbHVaeWs2SUhadmFXUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6SWdMeThnTWdvZ0lDQWdLd29nSUNBZ2MzZGhjQW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzluZFdsc1pITXZkR1Z6ZEhNdmJXOWpheTEzWVd4c1pYUXVZV3huYnk1MGN6bzVNZ29nSUNBZ0x5OGdkR2hwY3k1eVpXTnZjbVFvTkRBcENpQWdJQ0J3ZFhOb2FXNTBJRFF3Q2lBZ0lDQmpZV3hzYzNWaUlISmxZMjl5WkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyZDFhV3hrY3k5MFpYTjBjeTl0YjJOckxYZGhiR3hsZEM1aGJHZHZMblJ6T2preENpQWdJQ0F2THlCaGNtTTFPRjl5WlcxdmRtVlFiSFZuYVc0b2NHeDFaMmx1T2lCMWFXNTBOalFzSUdOaGJHeGxjam9nUVdOamIzVnVkQ3dnWlhOamNtOTNPaUJ6ZEhKcGJtY3BPaUIyYjJsa0lIc0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZaM1ZwYkdSekwzUmxjM1J6TDIxdlkyc3RkMkZzYkdWMExtRnNaMjh1ZEhNNk9rMXZZMnRIZFdsc1pGZGhiR3hsZEM1aGNtTTFPRjl5WlcxdmRtVk9ZVzFsWkZCc2RXZHBibHR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21GeVl6VTRYM0psYlc5MlpVNWhiV1ZrVUd4MVoybHVPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDJkMWFXeGtjeTkwWlhOMGN5OXRiMk5yTFhkaGJHeGxkQzVoYkdkdkxuUnpPamsxQ2lBZ0lDQXZMeUJoY21NMU9GOXlaVzF2ZG1WT1lXMWxaRkJzZFdkcGJpaHVZVzFsT2lCemRISnBibWNwT2lCMmIybGtJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCemQyRndDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMMmQxYVd4a2N5OTBaWE4wY3k5dGIyTnJMWGRoYkd4bGRDNWhiR2R2TG5Sek9qazJDaUFnSUNBdkx5QjBhR2x6TG5KbFkyOXlaQ2cwTVNrS0lDQWdJSEIxYzJocGJuUWdOREVLSUNBZ0lHTmhiR3h6ZFdJZ2NtVmpiM0prQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndlozVnBiR1J6TDNSbGMzUnpMMjF2WTJzdGQyRnNiR1YwTG1Gc1oyOHVkSE02T1RVS0lDQWdJQzh2SUdGeVl6VTRYM0psYlc5MlpVNWhiV1ZrVUd4MVoybHVLRzVoYldVNklITjBjbWx1WnlrNklIWnZhV1FnZXdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5bmRXbHNaSE12ZEdWemRITXZiVzlqYXkxM1lXeHNaWFF1WVd4bmJ5NTBjem82VFc5amEwZDFhV3hrVjJGc2JHVjBMbUZ5WXpVNFgyNWxkMFZ6WTNKdmQxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbUZ5WXpVNFgyNWxkMFZ6WTNKdmR6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzluZFdsc1pITXZkR1Z6ZEhNdmJXOWpheTEzWVd4c1pYUXVZV3huYnk1MGN6bzVPUW9nSUNBZ0x5OGdZWEpqTlRoZmJtVjNSWE5qY205M0tHVnpZM0p2ZHpvZ2MzUnlhVzVuTENCaFpHUnlaWE56T2lCQlkyTnZkVzUwS1RvZ2RXbHVkRFkwSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzluZFdsc1pITXZkR1Z6ZEhNdmJXOWpheTEzWVd4c1pYUXVZV3huYnk1MGN6b3hNREFLSUNBZ0lDOHZJSFJvYVhNdWNtVmpiM0prS0Rjd0tRb2dJQ0FnY0hWemFHbHVkQ0EzTUFvZ0lDQWdZMkZzYkhOMVlpQnlaV052Y21RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOW5kV2xzWkhNdmRHVnpkSE12Ylc5amF5MTNZV3hzWlhRdVlXeG5ieTUwY3pvNU9Rb2dJQ0FnTHk4Z1lYSmpOVGhmYm1WM1JYTmpjbTkzS0dWelkzSnZkem9nYzNSeWFXNW5MQ0JoWkdSeVpYTnpPaUJCWTJOdmRXNTBLVG9nZFdsdWREWTBJSHNLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREUxTVdZM1l6YzFNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyZDFhV3hrY3k5MFpYTjBjeTl0YjJOckxYZGhiR3hsZEM1aGJHZHZMblJ6T2pwTmIyTnJSM1ZwYkdSWFlXeHNaWFF1WVhKak5UaGZkRzluWjJ4bFJYTmpjbTkzVEc5amExdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbUZ5WXpVNFgzUnZaMmRzWlVWelkzSnZkMHh2WTJzNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZaM1ZwYkdSekwzUmxjM1J6TDIxdlkyc3RkMkZzYkdWMExtRnNaMjh1ZEhNNk1UQTBDaUFnSUNBdkx5QmhjbU0xT0Y5MGIyZG5iR1ZGYzJOeWIzZE1iMk5yS0dWelkzSnZkem9nYzNSeWFXNW5LVG9nUlhOamNtOTNTVzVtYnlCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdjM2RoY0FvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5bmRXbHNaSE12ZEdWemRITXZiVzlqYXkxM1lXeHNaWFF1WVd4bmJ5NTBjem94TURVS0lDQWdJQzh2SUhSb2FYTXVjbVZqYjNKa0tEY3hLUW9nSUNBZ2NIVnphR2x1ZENBM01Rb2dJQ0FnWTJGc2JITjFZaUJ5WldOdmNtUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzluZFdsc1pITXZkR1Z6ZEhNdmJXOWpheTEzWVd4c1pYUXVZV3huYnk1MGN6b3hNRFlLSUNBZ0lDOHZJSFJvYVhNdVpYTmpjbTkzVEc5amEyVmtMblpoYkhWbElEMGdJWFJvYVhNdVpYTmpjbTkzVEc5amEyVmtMblpoYkhWbENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyZDFhV3hrY3k5MFpYTjBjeTl0YjJOckxYZGhiR3hsZEM1aGJHZHZMblJ6T2pNeENpQWdJQ0F2THlCbGMyTnliM2RNYjJOclpXUWdQU0JIYkc5aVlXeFRkR0YwWlR4aWIyOXNaV0Z1UGloN0lHbHVhWFJwWVd4V1lXeDFaVG9nWm1Gc2MyVXNJR3RsZVRvZ1RXOWphMGQxYVd4a1YyRnNiR1YwUjJ4dlltRnNVM1JoZEdWTFpYbEZjMk55YjNkTWIyTnJaV1FnZlNrS0lDQWdJR0o1ZEdWalh6SWdMeThnSW1WelkzSnZkMTlzYjJOclpXUWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2WjNWcGJHUnpMM1JsYzNSekwyMXZZMnN0ZDJGc2JHVjBMbUZzWjI4dWRITTZNVEEyQ2lBZ0lDQXZMeUIwYUdsekxtVnpZM0p2ZDB4dlkydGxaQzUyWVd4MVpTQTlJQ0YwYUdsekxtVnpZM0p2ZDB4dlkydGxaQzUyWVd4MVpRb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJQ0VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5bmRXbHNaSE12ZEdWemRITXZiVzlqYXkxM1lXeHNaWFF1WVd4bmJ5NTBjem96TVFvZ0lDQWdMeThnWlhOamNtOTNURzlqYTJWa0lEMGdSMnh2WW1Gc1UzUmhkR1U4WW05dmJHVmhiajRvZXlCcGJtbDBhV0ZzVm1Gc2RXVTZJR1poYkhObExDQnJaWGs2SUUxdlkydEhkV2xzWkZkaGJHeGxkRWRzYjJKaGJGTjBZWFJsUzJWNVJYTmpjbTkzVEc5amEyVmtJSDBwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0psYzJOeWIzZGZiRzlqYTJWa0lnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMMmQxYVd4a2N5OTBaWE4wY3k5dGIyTnJMWGRoYkd4bGRDNWhiR2R2TG5Sek9qRXdOZ29nSUNBZ0x5OGdkR2hwY3k1bGMyTnliM2RNYjJOclpXUXVkbUZzZFdVZ1BTQWhkR2hwY3k1bGMyTnliM2RNYjJOclpXUXVkbUZzZFdVS0lDQWdJR1JwWnlBeENpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMMmQxYVd4a2N5OTBaWE4wY3k5dGIyTnJMWGRoYkd4bGRDNWhiR2R2TG5Sek9qRXdOd29nSUNBZ0x5OGdjbVYwZFhKdUlIc2dhV1E2SURBc0lHRmtaSEpsYzNNNklFZHNiMkpoYkM1NlpYSnZRV1JrY21WemN5d2diRzlqYTJWa09pQjBhR2x6TG1WelkzSnZkMHh2WTJ0bFpDNTJZV3gxWlNCOUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01Bb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVjBZbWwwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndlozVnBiR1J6TDNSbGMzUnpMMjF2WTJzdGQyRnNiR1YwTG1Gc1oyOHVkSE02TVRBMENpQWdJQ0F2THlCaGNtTTFPRjkwYjJkbmJHVkZjMk55YjNkTWIyTnJLR1Z6WTNKdmR6b2djM1J5YVc1bktUb2dSWE5qY205M1NXNW1ieUI3Q2lBZ0lDQndkWE5vWW5sMFpYTWdZbUZ6WlRNeUtFTlZVRmhaTlVsQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQktRb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZaM1ZwYkdSekwzUmxjM1J6TDIxdlkyc3RkMkZzYkdWMExtRnNaMjh1ZEhNNk9rMXZZMnRIZFdsc1pGZGhiR3hsZEM1aGNtTTFPRjl5WldOc1lXbHRXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWVhKak5UaGZjbVZqYkdGcGJUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzluZFdsc1pITXZkR1Z6ZEhNdmJXOWpheTEzWVd4c1pYUXVZV3huYnk1MGN6b3hNVEFLSUNBZ0lDOHZJR0Z5WXpVNFgzSmxZMnhoYVcwb1pYTmpjbTkzT2lCemRISnBibWNzSUhKbFkyeGhhVzF6T2lCRmMyTnliM2RTWldOc1lXbHRXMTBwT2lCMmIybGtJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCemQyRndDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2NIVnphR2x1ZENBeE53b2dJQ0FnS2dvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lDc0tJQ0FnSUhOM1lYQUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOWhZMk52ZFc1MEwzUjVjR1Z6TG5Sek9qcEZjMk55YjNkU1pXTnNZV2x0UGdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyZDFhV3hrY3k5MFpYTjBjeTl0YjJOckxYZGhiR3hsZEM1aGJHZHZMblJ6T2pFeE1Rb2dJQ0FnTHk4Z2RHaHBjeTV5WldOdmNtUW9OeklwQ2lBZ0lDQndkWE5vYVc1MElEY3lDaUFnSUNCallXeHNjM1ZpSUhKbFkyOXlaQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDJkMWFXeGtjeTkwWlhOMGN5OXRiMk5yTFhkaGJHeGxkQzVoYkdkdkxuUnpPakV4TUFvZ0lDQWdMeThnWVhKak5UaGZjbVZqYkdGcGJTaGxjMk55YjNjNklITjBjbWx1Wnl3Z2NtVmpiR0ZwYlhNNklFVnpZM0p2ZDFKbFkyeGhhVzFiWFNrNklIWnZhV1FnZXdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5bmRXbHNaSE12ZEdWemRITXZiVzlqYXkxM1lXeHNaWFF1WVd4bmJ5NTBjem82VFc5amEwZDFhV3hrVjJGc2JHVjBMbUZ5WXpVNFgyTm9ZVzVuWlVGa2JXbHVXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWVhKak5UaGZZMmhoYm1kbFFXUnRhVzQ2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndlozVnBiR1J6TDNSbGMzUnpMMjF2WTJzdGQyRnNiR1YwTG1Gc1oyOHVkSE02TVRFMENpQWdJQ0F2THlCaGNtTTFPRjlqYUdGdVoyVkJaRzFwYmlodVpYZEJaRzFwYmpvZ1FXTmpiM1Z1ZENrNklIWnZhV1FnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDJkMWFXeGtjeTkwWlhOMGN5OXRiMk5yTFhkaGJHeGxkQzVoYkdkdkxuUnpPakkyQ2lBZ0lDQXZMeUJoWkcxcGJpQTlJRWRzYjJKaGJGTjBZWFJsUEVGalkyOTFiblErS0hzZ2EyVjVPaUJOYjJOclIzVnBiR1JYWVd4c1pYUkhiRzlpWVd4VGRHRjBaVXRsZVVGa2JXbHVJSDBwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0poWkcxcGJpSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzluZFdsc1pITXZkR1Z6ZEhNdmJXOWpheTEzWVd4c1pYUXVZV3huYnk1MGN6b3hNVFVLSUNBZ0lDOHZJSFJvYVhNdVlXUnRhVzR1ZG1Gc2RXVWdQU0J1WlhkQlpHMXBiZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5bmRXbHNaSE12ZEdWemRITXZiVzlqYXkxM1lXeHNaWFF1WVd4bmJ5NTBjem94TVRZS0lDQWdJQzh2SUhSb2FYTXVjbVZqYjNKa0tEa3hLUW9nSUNBZ2NIVnphR2x1ZENBNU1Rb2dJQ0FnWTJGc2JITjFZaUJ5WldOdmNtUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzluZFdsc1pITXZkR1Z6ZEhNdmJXOWpheTEzWVd4c1pYUXVZV3huYnk1MGN6b3hNVFFLSUNBZ0lDOHZJR0Z5WXpVNFgyTm9ZVzVuWlVGa2JXbHVLRzVsZDBGa2JXbHVPaUJCWTJOdmRXNTBLVG9nZG05cFpDQjdDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMMmQxYVd4a2N5OTBaWE4wY3k5dGIyTnJMWGRoYkd4bGRDNWhiR2R2TG5Sek9qcE5iMk5yUjNWcGJHUlhZV3hzWlhRdVlYSmpOVGhmWVdSa1FXeHNiM2RoYm1ObGMxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbUZ5WXpVNFgyRmtaRUZzYkc5M1lXNWpaWE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndlozVnBiR1J6TDNSbGMzUnpMMjF2WTJzdGQyRnNiR1YwTG1Gc1oyOHVkSE02TVRFNUNpQWdJQ0F2THlCaGNtTTFPRjloWkdSQmJHeHZkMkZ1WTJWektHVnpZM0p2ZHpvZ2MzUnlhVzVuTENCaGJHeHZkMkZ1WTJWek9pQkJaR1JCYkd4dmQyRnVZMlZKYm1adlcxMHBPaUIyYjJsa0lIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNBckNpQWdJQ0J6ZDJGd0NpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnY0hWemFHbHVkQ0F6TkFvZ0lDQWdLZ29nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUNzS0lDQWdJSE4zWVhBS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5aFkyTnZkVzUwTDNSNWNHVnpMblJ6T2pwQlpHUkJiR3h2ZDJGdVkyVkpibVp2UGdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyZDFhV3hrY3k5MFpYTjBjeTl0YjJOckxYZGhiR3hsZEM1aGJHZHZMblJ6T2pFeU1Bb2dJQ0FnTHk4Z2RHaHBjeTV5WldOdmNtUW9OVEFwQ2lBZ0lDQndkWE5vYVc1MElEVXdDaUFnSUNCallXeHNjM1ZpSUhKbFkyOXlaQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDJkMWFXeGtjeTkwWlhOMGN5OXRiMk5yTFhkaGJHeGxkQzVoYkdkdkxuUnpPakV4T1FvZ0lDQWdMeThnWVhKak5UaGZZV1JrUVd4c2IzZGhibU5sY3lobGMyTnliM2M2SUhOMGNtbHVaeXdnWVd4c2IzZGhibU5sY3pvZ1FXUmtRV3hzYjNkaGJtTmxTVzVtYjF0ZEtUb2dkbTlwWkNCN0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyZDFhV3hrY3k5MFpYTjBjeTl0YjJOckxYZGhiR3hsZEM1aGJHZHZMblJ6T2pwTmIyTnJSM1ZwYkdSWFlXeHNaWFF1WVhKak5UaGZjbVZ0YjNabFFXeHNiM2RoYm1ObGMxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbUZ5WXpVNFgzSmxiVzkyWlVGc2JHOTNZVzVqWlhNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZaM1ZwYkdSekwzUmxjM1J6TDIxdlkyc3RkMkZzYkdWMExtRnNaMjh1ZEhNNk1USXpDaUFnSUNBdkx5QmhjbU0xT0Y5eVpXMXZkbVZCYkd4dmQyRnVZMlZ6S0dWelkzSnZkem9nYzNSeWFXNW5MQ0JoYzNObGRITTZJSFZwYm5RMk5GdGRLVG9nZG05cFpDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnYzNkaGNBb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0FxQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnYzNkaGNBb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4ZFdsdWREWTBQZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDJkMWFXeGtjeTkwWlhOMGN5OXRiMk5yTFhkaGJHeGxkQzVoYkdkdkxuUnpPakV5TkFvZ0lDQWdMeThnZEdocGN5NXlaV052Y21Rb05qQXBDaUFnSUNCd2RYTm9hVzUwSURZd0NpQWdJQ0JqWVd4c2MzVmlJSEpsWTI5eVpBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMMmQxYVd4a2N5OTBaWE4wY3k5dGIyTnJMWGRoYkd4bGRDNWhiR2R2TG5Sek9qRXlNd29nSUNBZ0x5OGdZWEpqTlRoZmNtVnRiM1psUVd4c2IzZGhibU5sY3lobGMyTnliM2M2SUhOMGNtbHVaeXdnWVhOelpYUnpPaUIxYVc1ME5qUmJYU2s2SUhadmFXUWdld29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzluZFdsc1pITXZkR1Z6ZEhNdmJXOWpheTEzWVd4c1pYUXVZV3huYnk1MGN6bzZUVzlqYTBkMWFXeGtWMkZzYkdWMExtRnlZelU0WDJGa1pFVjRaV04xZEdsdmJrdGxlVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21GeVl6VTRYMkZrWkVWNFpXTjFkR2x2Ymt0bGVUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzluZFdsc1pITXZkR1Z6ZEhNdmJXOWpheTEzWVd4c1pYUXVZV3huYnk1MGN6b3hNamNLSUNBZ0lDOHZJR0Z5WXpVNFgyRmtaRVY0WldOMWRHbHZia3RsZVNoc1pXRnpaVG9nWW5sMFpYTThNekkrTENCbmNtOTFjSE02SUdKNWRHVnpQRE15UGx0ZExDQm1hWEp6ZEZaaGJHbGtPaUIxYVc1ME5qUXNJR3hoYzNSV1lXeHBaRG9nZFdsdWREWTBLVG9nZG05cFpDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2NIVnphR2x1ZENBek1nb2dJQ0FnS2dvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lDc0tJQ0FnSUhOM1lYQUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdKNWRHVnpXek15WFQ0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTBDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyZDFhV3hrY3k5MFpYTjBjeTl0YjJOckxYZGhiR3hsZEM1aGJHZHZMblJ6T2pFeU9Bb2dJQ0FnTHk4Z2RHaHBjeTV5WldOdmNtUW9NekFwQ2lBZ0lDQndkWE5vYVc1MElETXdDaUFnSUNCallXeHNjM1ZpSUhKbFkyOXlaQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDJkMWFXeGtjeTkwWlhOMGN5OXRiMk5yTFhkaGJHeGxkQzVoYkdkdkxuUnpPakV5TndvZ0lDQWdMeThnWVhKak5UaGZZV1JrUlhobFkzVjBhVzl1UzJWNUtHeGxZWE5sT2lCaWVYUmxjend6TWo0c0lHZHliM1Z3Y3pvZ1lubDBaWE04TXpJK1cxMHNJR1pwY25OMFZtRnNhV1E2SUhWcGJuUTJOQ3dnYkdGemRGWmhiR2xrT2lCMWFXNTBOalFwT2lCMmIybGtJSHNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2WjNWcGJHUnpMM1JsYzNSekwyMXZZMnN0ZDJGc2JHVjBMbUZzWjI4dWRITTZPazF2WTJ0SGRXbHNaRmRoYkd4bGRDNWhjbU0xT0Y5eVpXMXZkbVZGZUdWamRYUnBiMjVMWlhsYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGhjbU0xT0Y5eVpXMXZkbVZGZUdWamRYUnBiMjVMWlhrNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZaM1ZwYkdSekwzUmxjM1J6TDIxdlkyc3RkMkZzYkdWMExtRnNaMjh1ZEhNNk1UTXhDaUFnSUNBdkx5QmhjbU0xT0Y5eVpXMXZkbVZGZUdWamRYUnBiMjVMWlhrb2JHVmhjMlU2SUdKNWRHVnpQRE15UGlrNklIWnZhV1FnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5bmRXbHNaSE12ZEdWemRITXZiVzlqYXkxM1lXeHNaWFF1WVd4bmJ5NTBjem94TXpJS0lDQWdJQzh2SUhSb2FYTXVjbVZqYjNKa0tETXhLUW9nSUNBZ2NIVnphR2x1ZENBek1Rb2dJQ0FnWTJGc2JITjFZaUJ5WldOdmNtUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzluZFdsc1pITXZkR1Z6ZEhNdmJXOWpheTEzWVd4c1pYUXVZV3huYnk1MGN6b3hNekVLSUNBZ0lDOHZJR0Z5WXpVNFgzSmxiVzkyWlVWNFpXTjFkR2x2Ymt0bGVTaHNaV0Z6WlRvZ1lubDBaWE04TXpJK0tUb2dkbTlwWkNCN0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyZDFhV3hrY3k5MFpYTjBjeTl0YjJOckxYZGhiR3hsZEM1aGJHZHZMblJ6T2pwTmIyTnJSM1ZwYkdSWFlXeHNaWFF1ZFhCa1lYUmxSM1ZwYkdSYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDFjR1JoZEdWSGRXbHNaRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5bmRXbHNaSE12ZEdWemRITXZiVzlqYXkxM1lXeHNaWFF1WVd4bmJ5NTBjem94TXpZdE1UUXlDaUFnSUNBdkx5QjFjR1JoZEdWSGRXbHNaQ2dLSUNBZ0lDOHZJQ0FnWjNWcGJHUTZJRUZ3Y0d4cFkyRjBhVzl1TEFvZ0lDQWdMeThnSUNCaGNIQnliM1poYkZCeWIyZHlZVzFHYVhKemREb2dZbmwwWlhNc0NpQWdJQ0F2THlBZ0lHRndjSEp2ZG1Gc1VISnZaM0poYlZObFkyOXVaRG9nWW5sMFpYTXNDaUFnSUNBdkx5QWdJR05zWldGeVUzUmhkR1ZRY205bmNtRnRPaUJpZVhSbGN5d0tJQ0FnSUM4dklDQWdkbVZ5YzJsdmJqb2djM1J5YVc1bkxBb2dJQ0FnTHk4Z0tUb2dkbTlwWkNCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEUUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUExQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6SWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2WjNWcGJHUnpMM1JsYzNSekwyMXZZMnN0ZDJGc2JHVjBMbUZzWjI4dWRITTZNVFF6TFRFME9Rb2dJQ0FnTHk4Z1lXSnBRMkZzYkR4MGVYQmxiMllnUjNWcGJHUXVjSEp2ZEc5MGVYQmxMblZ3WkdGMFpUNG9ld29nSUNBZ0x5OGdJQ0JoY0hCSlpEb2daM1ZwYkdRc0NpQWdJQ0F2THlBZ0lHRnlaM002SUZ0MlpYSnphVzl1WFN3S0lDQWdJQzh2SUNBZ2IyNURiMjF3YkdWMGFXOXVPaUJQYmtOdmJYQnNaWFJsUVdOMGFXOXVMbFZ3WkdGMFpVRndjR3hwWTJGMGFXOXVMQW9nSUNBZ0x5OGdJQ0JoY0hCeWIzWmhiRkJ5YjJkeVlXMDZJRnRoY0hCeWIzWmhiRkJ5YjJkeVlXMUdhWEp6ZEN3Z1lYQndjbTkyWVd4UWNtOW5jbUZ0VTJWamIyNWtYU3dLSUNBZ0lDOHZJQ0FnWTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBzQ2lBZ0lDQXZMeUI5S1FvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ2MzZGhjQW9nSUNBZ2FYUjRibDltYVdWc1pDQkRiR1ZoY2xOMFlYUmxVSEp2WjNKaGJWQmhaMlZ6Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndjbTkyWVd4UWNtOW5jbUZ0VUdGblpYTUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndjbTkyWVd4UWNtOW5jbUZ0VUdGblpYTUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzluZFdsc1pITXZkR1Z6ZEhNdmJXOWpheTEzWVd4c1pYUXVZV3huYnk1MGN6b3hORFlLSUNBZ0lDOHZJRzl1UTI5dGNHeGxkR2x2YmpvZ1QyNURiMjF3YkdWMFpVRmpkR2x2Ymk1VmNHUmhkR1ZCY0hCc2FXTmhkR2x2Yml3S0lDQWdJSEIxYzJocGJuUWdOQW9nSUNBZ2FYUjRibDltYVdWc1pDQlBia052YlhCc1pYUnBiMjRLSUNBZ0lITjNZWEFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyZDFhV3hrY3k5MFpYTjBjeTl0YjJOckxYZGhiR3hsZEM1aGJHZHZMblJ6T2pFME15MHhORGtLSUNBZ0lDOHZJR0ZpYVVOaGJHdzhkSGx3Wlc5bUlFZDFhV3hrTG5CeWIzUnZkSGx3WlM1MWNHUmhkR1UrS0hzS0lDQWdJQzh2SUNBZ1lYQndTV1E2SUdkMWFXeGtMQW9nSUNBZ0x5OGdJQ0JoY21kek9pQmJkbVZ5YzJsdmJsMHNDaUFnSUNBdkx5QWdJRzl1UTI5dGNHeGxkR2x2YmpvZ1QyNURiMjF3YkdWMFpVRmpkR2x2Ymk1VmNHUmhkR1ZCY0hCc2FXTmhkR2x2Yml3S0lDQWdJQzh2SUNBZ1lYQndjbTkyWVd4UWNtOW5jbUZ0T2lCYllYQndjbTkyWVd4UWNtOW5jbUZ0Um1seWMzUXNJR0Z3Y0hKdmRtRnNVSEp2WjNKaGJWTmxZMjl1WkYwc0NpQWdJQ0F2THlBZ0lHTnNaV0Z5VTNSaGRHVlFjbTluY21GdExBb2dJQ0FnTHk4Z2ZTa0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VHVmhPVEU0TUdSa0lDOHZJRzFsZEdodlpDQWlkWEJrWVhSbEtITjBjbWx1WnlsMmIybGtJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCd2RYTm9hVzUwSURZZ0x5OGdZWEJ3YkFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMMmQxYVd4a2N5OTBaWE4wY3k5dGIyTnJMWGRoYkd4bGRDNWhiR2R2TG5Sek9qRXpOaTB4TkRJS0lDQWdJQzh2SUhWd1pHRjBaVWQxYVd4a0tBb2dJQ0FnTHk4Z0lDQm5kV2xzWkRvZ1FYQndiR2xqWVhScGIyNHNDaUFnSUNBdkx5QWdJR0Z3Y0hKdmRtRnNVSEp2WjNKaGJVWnBjbk4wT2lCaWVYUmxjeXdLSUNBZ0lDOHZJQ0FnWVhCd2NtOTJZV3hRY205bmNtRnRVMlZqYjI1a09pQmllWFJsY3l3S0lDQWdJQzh2SUNBZ1kyeGxZWEpUZEdGMFpWQnliMmR5WVcwNklHSjVkR1Z6TEFvZ0lDQWdMeThnSUNCMlpYSnphVzl1T2lCemRISnBibWNzQ2lBZ0lDQXZMeUFwT2lCMmIybGtJSHNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2WjNWcGJHUnpMM1JsYzNSekwyMXZZMnN0ZDJGc2JHVjBMbUZzWjI4dWRITTZPazF2WTJ0SGRXbHNaRmRoYkd4bGRDNWhjbU0xT0Y5blpYUkJaRzFwYmx0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtRnlZelU0WDJkbGRFRmtiV2x1T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyZDFhV3hrY3k5MFpYTjBjeTl0YjJOckxYZGhiR3hsZEM1aGJHZHZMblJ6T2pFMU5Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUhSb2FYTXVZV1J0YVc0dWRtRnNkV1VLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2WjNWcGJHUnpMM1JsYzNSekwyMXZZMnN0ZDJGc2JHVjBMbUZzWjI4dWRITTZNallLSUNBZ0lDOHZJR0ZrYldsdUlEMGdSMnh2WW1Gc1UzUmhkR1U4UVdOamIzVnVkRDRvZXlCclpYazZJRTF2WTJ0SGRXbHNaRmRoYkd4bGRFZHNiMkpoYkZOMFlYUmxTMlY1UVdSdGFXNGdmU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUZrYldsdUlnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMMmQxYVd4a2N5OTBaWE4wY3k5dGIyTnJMWGRoYkd4bGRDNWhiR2R2TG5Sek9qRTFOQW9nSUNBZ0x5OGdjbVYwZFhKdUlIUm9hWE11WVdSdGFXNHVkbUZzZFdVS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndlozVnBiR1J6TDNSbGMzUnpMMjF2WTJzdGQyRnNiR1YwTG1Gc1oyOHVkSE02TVRVeUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2djbVZoWkc5dWJIazZJSFJ5ZFdVZ2ZTa0tJQ0FnSUdKNWRHVmpJRFFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZaM1ZwYkdSekwzUmxjM1J6TDIxdlkyc3RkMkZzYkdWMExtRnNaMjh1ZEhNNk9rMXZZMnRIZFdsc1pGZGhiR3hsZEM1eVpXTnZjbVFvWVdOMGFXOXVPaUIxYVc1ME5qUXBJQzArSUhadmFXUTZDbkpsWTI5eVpEb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzluZFdsc1pITXZkR1Z6ZEhNdmJXOWpheTEzWVd4c1pYUXVZV3huYnk1MGN6b3pNd29nSUNBZ0x5OGdjSEpwZG1GMFpTQnlaV052Y21Rb1lXTjBhVzl1T2lCMWFXNTBOalFwT2lCMmIybGtJSHNLSUNBZ0lIQnliM1J2SURFZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMMmQxYVd4a2N5OTBaWE4wY3k5dGIyTnJMWGRoYkd4bGRDNWhiR2R2TG5Sek9qTTBDaUFnSUNBdkx5QjBhR2x6TG1GamRHbHZia052ZFc1MExuWmhiSFZsSUNzOUlERUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZaM1ZwYkdSekwzUmxjM1J6TDIxdlkyc3RkMkZzYkdWMExtRnNaMjh1ZEhNNk1qa0tJQ0FnSUM4dklHRmpkR2x2YmtOdmRXNTBJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGloN0lHbHVhWFJwWVd4V1lXeDFaVG9nTUN3Z2EyVjVPaUJOYjJOclIzVnBiR1JYWVd4c1pYUkhiRzlpWVd4VGRHRjBaVXRsZVVGamRHbHZia052ZFc1MElIMHBDaUFnSUNCaWVYUmxZMTh4SUM4dklDSmhZM1JwYjI1ZlkyOTFiblFpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndlozVnBiR1J6TDNSbGMzUnpMMjF2WTJzdGQyRnNiR1YwTG1Gc1oyOHVkSE02TXpRS0lDQWdJQzh2SUhSb2FYTXVZV04wYVc5dVEyOTFiblF1ZG1Gc2RXVWdLejBnTVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBckNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZaM1ZwYkdSekwzUmxjM1J6TDIxdlkyc3RkMkZzYkdWMExtRnNaMjh1ZEhNNk1qa0tJQ0FnSUM4dklHRmpkR2x2YmtOdmRXNTBJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGloN0lHbHVhWFJwWVd4V1lXeDFaVG9nTUN3Z2EyVjVPaUJOYjJOclIzVnBiR1JYWVd4c1pYUkhiRzlpWVd4VGRHRjBaVXRsZVVGamRHbHZia052ZFc1MElIMHBDaUFnSUNCaWVYUmxZMTh4SUM4dklDSmhZM1JwYjI1ZlkyOTFiblFpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndlozVnBiR1J6TDNSbGMzUnpMMjF2WTJzdGQyRnNiR1YwTG1Gc1oyOHVkSE02TXpRS0lDQWdJQzh2SUhSb2FYTXVZV04wYVc5dVEyOTFiblF1ZG1Gc2RXVWdLejBnTVFvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOW5kV2xzWkhNdmRHVnpkSE12Ylc5amF5MTNZV3hzWlhRdVlXeG5ieTUwY3pvek1Bb2dJQ0FnTHk4Z2JHRnpkRUZqZEdsdmJpQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvZXlCcGJtbDBhV0ZzVm1Gc2RXVTZJREFzSUd0bGVUb2dUVzlqYTBkMWFXeGtWMkZzYkdWMFIyeHZZbUZzVTNSaGRHVkxaWGxNWVhOMFFXTjBhVzl1SUgwcENpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKc1lYTjBYMkZqZEdsdmJpSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzluZFdsc1pITXZkR1Z6ZEhNdmJXOWpheTEzWVd4c1pYUXVZV3huYnk1MGN6b3pOUW9nSUNBZ0x5OGdkR2hwY3k1c1lYTjBRV04wYVc5dUxuWmhiSFZsSUQwZ1lXTjBhVzl1Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQnlaWFJ6ZFdJSyIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVLSUNBZ0lISmxkSFZ5YmdvPSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBUUFDQ0NZRkJXRmtiV2x1REdGamRHbHZibDlqYjNWdWRBMWxjMk55YjNkZmJHOWphMlZrQzJ4aGMzUmZZV04wYVc5dUJCVWZmSFV4R0VBQUNTa2paeXNqWnlvalp6RVpGRVF4R0VFQWVJSVFCQmVHYVJJRVZuSkdMZ1JYTDlIcUJIY24rRkVFN3ZSSS9RVGpVTG5VQk45SnRQMEVDVU82dVFUcnJ4U2dCTkpMZFZZRXYwMThWd1RWM1RnckJGenI3VU1FMVlhRnJ3U2ZyblRRQkJPOFJPUTJHZ0NPRUFBMEFFSUFzZ0ZuQVlVQnB3RzZBZVFDT0FKYUFtMENqd0t3QXR3QzZ3TlhBSUFFekdsT3FqWWFBSTRCQUFFQU5ob0JTUldCSUJKRUtFeG5nQkpqYjI1MGNtOXNiR1ZrWDJGa1pISmxjM015Q21jaVF6WWFBVWtWZ1NBU1JDaE1aeUpETmhvQkZTVVNSRFlhQWhXQklCSkVOaG9EU1NOWkpBaE1GUkpFTmhvRUZTSVNSRFlhQlJVaUVrUTJHZ1lWSlJKRU5ob0hGU1VTUkRZYUNFa2pXWUVNQ3lRSVRCVVNSRFlhQ1JVaUVrUTJHZ29WSWhKRU5ob0xGU0lTUkRZYURCVWlFa1EyR2cwVkloSkVnUlNJQXJJaVF6WWFBVWtqV1NRSVN3RVZFa1JYQWdBMkdnSkpGU1VTUkJjMkdnTkpGWUVnRWtRMkdnUkpJMWtrQ0VzQkZSSkVWd0lBTmhvRkZTSVNSRFlhQmhVaUVrUTJHZ2NWSlJKRU5ob0lGU1VTUkRZYUNVa2pXWUVNQ3lRSVRCVVNSRFlhQ2hVaUVrUTJHZ3NWSWhKRU5ob01GU0lTUkRZYURSVWlFa1EyR2c1SkZTSVNSQ05UUVFBc1NJQUFUd0lXVHdKUVRFa1ZGbGNHQWt4UVRJQUNBQ3BRVEZDQUFXNVBBbEJKdkVoTXY0RVZpQUlBSWtOQy85UTJHZ0ZKSTFra0NFc0JGUkpFVndJQWdBRnVURkMrUkNjRVRGQ3dJa00yR2dFVkpSSkVOaG9DRllFZ0VrUTJHZ05KSTFra0NFd1ZFa1NCS0lnQnZTSkROaG9CU1NOWkpBaE1GUkpFZ1NtSUFhb2lRellhQVVraldTUUlUQlVTUkRZYUFoV0JJQkpFZ1VhSUFZK0FEQlVmZkhVQUFBQUFBQUFBQUxBaVF6WWFBVWtqV1NRSVRCVVNSSUZIaUFGdEl5cGxSQlFxU3dGbmdBRUFJMDhDVklBc0ZSOThkUUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFCTVVMQWlRellhQVVraldTUUlUQlVTUkRZYUFra2pXWUVSQ3lRSVRCVVNSSUZJaUFFS0lrTTJHZ0ZKRllFZ0VrUW9UR2VCVzRnQTl5SkROaG9CU1NOWkpBaE1GUkpFTmhvQ1NTTlpnU0lMSkFoTUZSSkVnVEtJQU5VaVF6WWFBVWtqV1NRSVRCVVNSRFlhQWtraldTVUxKQWhNRlJKRWdUeUlBTFFpUXpZYUFSV0JJQkpFTmhvQ1NTTlpnU0FMSkFoTUZSSkVOaG9ERlNVU1JEWWFCQlVsRWtTQkhvZ0FpQ0pETmhvQkZZRWdFa1NCSDRnQWVTSkROaG9CU1JVbEVrUVhOaG9DU1NOWkpBaExBUlVTUkZjQ0FEWWFBMGtqV1NRSVN3RVZFa1JYQWdBMkdnUkpJMWtrQ0VzQkZSSkVWd0lBTmhvRlNTTlpKQWhMQVJVU1JMRk1za0pQQXJKQVRMSkFnUVN5R1V5eUdJQUU2cEdBM2JJYXNocUJCcklRSTdJQnN5SkRJeWhsUkNjRVRGQ3dJa09LQVFBaktXVkVJZ2dwVEdjcmkvOW5pUT09IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6MTAsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
