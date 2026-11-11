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

namespace Arc56.Generated.d13co.nfd_ghost_sdk.NfdReader_05a85298
{


    public class NfdReaderProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public NfdReaderProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class ObjectBee64Df8 : AVMObjectType
            {
                public bool[] HasVerifiedCaAlgoBox { get; set; }

                public bool[] HasUnverifiedCaAlgoBox { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vHasVerifiedCaAlgoBox = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool[]");
                    vHasVerifiedCaAlgoBox.From(HasVerifiedCaAlgoBox);
                    ret.AddRange(vHasVerifiedCaAlgoBox.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vHasUnverifiedCaAlgoBox = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool[]");
                    vHasUnverifiedCaAlgoBox.From(HasUnverifiedCaAlgoBox);
                    ret.AddRange(vHasUnverifiedCaAlgoBox.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ObjectBee64Df8 Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new ObjectBee64Df8();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vHasVerifiedCaAlgoBox = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool[]");
                    count = vHasVerifiedCaAlgoBox.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueHasVerifiedCaAlgoBox = vHasVerifiedCaAlgoBox.ToValue();
                    if (valueHasVerifiedCaAlgoBox is bool[] vHasVerifiedCaAlgoBoxValue) { ret.HasVerifiedCaAlgoBox = vHasVerifiedCaAlgoBoxValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vHasUnverifiedCaAlgoBox = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool[]");
                    count = vHasUnverifiedCaAlgoBox.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueHasUnverifiedCaAlgoBox = vHasUnverifiedCaAlgoBox.ToValue();
                    if (valueHasUnverifiedCaAlgoBox is bool[] vHasUnverifiedCaAlgoBoxValue) { ret.HasUnverifiedCaAlgoBox = vHasUnverifiedCaAlgoBoxValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ObjectBee64Df8);
                }
                public bool Equals(ObjectBee64Df8? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ObjectBee64Df8 left, ObjectBee64Df8 right)
                {
                    return EqualityComparer<ObjectBee64Df8>.Default.Equals(left, right);
                }
                public static bool operator !=(ObjectBee64Df8 left, ObjectBee64Df8 right)
                {
                    return !(left == right);
                }

            }

            public class AppWithCaBoxHints : AVMObjectType
            {
                public ulong[] AppIds { get; set; }

                public Structs.ObjectBee64Df8 BoxHints { get; set; } = new Structs.ObjectBee64Df8();

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAppIds = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64[]");
                    vAppIds.From(AppIds);
                    ret.AddRange(vAppIds.Encode());
                    stringRef[ret.Count] = BoxHints.ToByteArray();
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

                public static AppWithCaBoxHints Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new AppWithCaBoxHints();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAppIds = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64[]");
                    count = vAppIds.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAppIds = vAppIds.ToValue();
                    if (valueAppIds is ulong[] vAppIdsValue) { ret.AppIds = vAppIdsValue; }
                    var indexBoxHints = queue.Dequeue() * 256 + queue.Dequeue();
                    ret.BoxHints = Structs.ObjectBee64Df8.Parse(bytes.Skip(indexBoxHints + prefixOffset).ToArray());
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as AppWithCaBoxHints);
                }
                public bool Equals(AppWithCaBoxHints? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(AppWithCaBoxHints left, AppWithCaBoxHints right)
                {
                    return EqualityComparer<AppWithCaBoxHints>.Default.Equals(left, right);
                }
                public static bool operator !=(AppWithCaBoxHints left, AppWithCaBoxHints right)
                {
                    return !(left == right);
                }

            }

            public class NfdNano : AVMObjectType
            {
                public string Name { get; set; }

                public ulong AsaId { get; set; }

                public Algorand.Address Owner { get; set; }

                public string Version { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vName.From(Name);
                    stringRef[ret.Count] = vName.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAsaId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAsaId.From(AsaId);
                    ret.AddRange(vAsaId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vOwner.From(Owner);
                    ret.AddRange(vOwner.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVersion = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vVersion.From(Version);
                    stringRef[ret.Count] = vVersion.Encode();
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

                public static NfdNano Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new NfdNano();
                    uint count = 0;
                    var indexName = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vName.Decode(bytes.Skip(indexName + prefixOffset).ToArray());
                    var valueName = vName.ToValue();
                    if (valueName is string vNameValue) { ret.Name = vNameValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAsaId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAsaId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAsaId = vAsaId.ToValue();
                    if (valueAsaId is ulong vAsaIdValue) { ret.AsaId = vAsaIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vOwner.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOwner = vOwner.ToValue();
                    if (valueOwner is Algorand.Address vOwnerValue) { ret.Owner = vOwnerValue; }
                    var indexVersion = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVersion = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vVersion.Decode(bytes.Skip(indexVersion + prefixOffset).ToArray());
                    var valueVersion = vVersion.ToValue();
                    if (valueVersion is string vVersionValue) { ret.Version = vVersionValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as NfdNano);
                }
                public bool Equals(NfdNano? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(NfdNano left, NfdNano right)
                {
                    return EqualityComparer<NfdNano>.Default.Equals(left, right);
                }
                public static bool operator !=(NfdNano left, NfdNano right)
                {
                    return !(left == right);
                }

            }

            public class NfdTiny : AVMObjectType
            {
                public string Name { get; set; }

                public Algorand.Address Owner { get; set; }

                public Algorand.Address[] CaAlgo { get; set; }

                public Algorand.Address[] UnverifiedCaAlgo { get; set; }

                public string Version { get; set; }

                public bool Expired { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vName.From(Name);
                    stringRef[ret.Count] = vName.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vOwner.From(Owner);
                    ret.AddRange(vOwner.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCaAlgo = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address[]");
                    vCaAlgo.From(CaAlgo);
                    ret.AddRange(vCaAlgo.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUnverifiedCaAlgo = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address[]");
                    vUnverifiedCaAlgo.From(UnverifiedCaAlgo);
                    ret.AddRange(vUnverifiedCaAlgo.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVersion = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vVersion.From(Version);
                    stringRef[ret.Count] = vVersion.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExpired = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vExpired.From(Expired);
                    ret.AddRange(vExpired.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static NfdTiny Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new NfdTiny();
                    uint count = 0;
                    var indexName = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vName.Decode(bytes.Skip(indexName + prefixOffset).ToArray());
                    var valueName = vName.ToValue();
                    if (valueName is string vNameValue) { ret.Name = vNameValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vOwner.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOwner = vOwner.ToValue();
                    if (valueOwner is Algorand.Address vOwnerValue) { ret.Owner = vOwnerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCaAlgo = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address[]");
                    count = vCaAlgo.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCaAlgo = vCaAlgo.ToValue();
                    if (valueCaAlgo is Algorand.Address[] vCaAlgoValue) { ret.CaAlgo = vCaAlgoValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUnverifiedCaAlgo = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address[]");
                    count = vUnverifiedCaAlgo.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueUnverifiedCaAlgo = vUnverifiedCaAlgo.ToValue();
                    if (valueUnverifiedCaAlgo is Algorand.Address[] vUnverifiedCaAlgoValue) { ret.UnverifiedCaAlgo = vUnverifiedCaAlgoValue; }
                    var indexVersion = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVersion = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vVersion.Decode(bytes.Skip(indexVersion + prefixOffset).ToArray());
                    var valueVersion = vVersion.ToValue();
                    if (valueVersion is string vVersionValue) { ret.Version = vVersionValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExpired = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vExpired.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueExpired = vExpired.ToValue();
                    if (valueExpired is bool vExpiredValue) { ret.Expired = vExpiredValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as NfdTiny);
                }
                public bool Equals(NfdTiny? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(NfdTiny left, NfdTiny right)
                {
                    return EqualityComparer<NfdTiny>.Default.Equals(left, right);
                }
                public static bool operator !=(NfdTiny left, NfdTiny right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="appIds"> </param>
        public async Task<string> GetVersionsFromAppIds(ulong[] appIds, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 160, 162, 200, 170 };
            var appIdsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); appIdsAbi.From(appIds);

            var result = await base.SimApp(new List<object> { abiHandle, appIdsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetVersionsFromAppIds_Transactions(ulong[] appIds, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 160, 162, 200, 170 };
            var appIdsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); appIdsAbi.From(appIds);

            return await base.MakeTransactionList(new List<object> { abiHandle, appIdsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="appIds"> </param>
        public async Task<Structs.NfdNano> GetNanoViewFromAppIds(ulong[] appIds, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 13, 253, 62, 43 };
            var appIdsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); appIdsAbi.From(appIds);

            var result = await base.SimApp(new List<object> { abiHandle, appIdsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.NfdNano.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetNanoViewFromAppIds_Transactions(ulong[] appIds, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 13, 253, 62, 43 };
            var appIdsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); appIdsAbi.From(appIds);

            return await base.MakeTransactionList(new List<object> { abiHandle, appIdsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="appIds"> </param>
        public async Task<Structs.NfdTiny> GetTinyViewFromAppIds(ulong[] appIds, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 201, 11, 226, 24 };
            var appIdsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); appIdsAbi.From(appIds);

            var result = await base.SimApp(new List<object> { abiHandle, appIdsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.NfdTiny.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetTinyViewFromAppIds_Transactions(ulong[] appIds, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 201, 11, 226, 24 };
            var appIdsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); appIdsAbi.From(appIds);

            return await base.MakeTransactionList(new List<object> { abiHandle, appIdsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="arg"> AppWithCaBoxHints</param>
        public async Task<Structs.NfdTiny> GetTinyViewFromAppIdsV2(Structs.AppWithCaBoxHints arg, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 151, 182, 175, 175 };

            var result = await base.SimApp(new List<object> { abiHandle, arg }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.NfdTiny.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetTinyViewFromAppIdsV2_Transactions(Structs.AppWithCaBoxHints arg, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 151, 182, 175, 175 };

            return await base.MakeTransactionList(new List<object> { abiHandle, arg }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTmZkUmVhZGVyIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7Ik9iamVjdEJFRTY0REY4IjpbeyJuYW1lIjoiaGFzVmVyaWZpZWRDYUFsZ29Cb3giLCJ0eXBlIjoiYm9vbFtdIn0seyJuYW1lIjoiaGFzVW52ZXJpZmllZENhQWxnb0JveCIsInR5cGUiOiJib29sW10ifV0sIkFwcFdpdGhDYUJveEhpbnRzIjpbeyJuYW1lIjoiYXBwSWRzIiwidHlwZSI6InVpbnQ2NFtdIn0seyJuYW1lIjoiYm94SGludHMiLCJ0eXBlIjoiT2JqZWN0QkVFNjRERjgifV0sIk5mZE5hbm8iOlt7Im5hbWUiOiJuYW1lIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6ImFzYUlEIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6Im93bmVyIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJ2ZXJzaW9uIiwidHlwZSI6InN0cmluZyJ9XSwiTmZkVGlueSI6W3sibmFtZSI6Im5hbWUiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoib3duZXIiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6ImNhQWxnbyIsInR5cGUiOiJhZGRyZXNzW10ifSx7Im5hbWUiOiJ1bnZlcmlmaWVkQ2FBbGdvIiwidHlwZSI6ImFkZHJlc3NbXSJ9LHsibmFtZSI6InZlcnNpb24iLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoiZXhwaXJlZCIsInR5cGUiOiJib29sIn1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImdldFZlcnNpb25zRnJvbUFwcElkcyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjRbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFwcElkcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0TmFub1ZpZXdGcm9tQXBwSWRzIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NFtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXBwSWRzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6IihzdHJpbmcsdWludDY0LGFkZHJlc3Msc3RyaW5nKSIsInN0cnVjdCI6Ik5mZE5hbm8iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFRpbnlWaWV3RnJvbUFwcElkcyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjRbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFwcElkcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIoc3RyaW5nLGFkZHJlc3MsYWRkcmVzc1tdLGFkZHJlc3NbXSxzdHJpbmcsYm9vbCkiLCJzdHJ1Y3QiOiJOZmRUaW55IiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRUaW55Vmlld0Zyb21BcHBJZHNWMiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIodWludDY0W10sKGJvb2xbXSxib29sW10pKSIsInN0cnVjdCI6IkFwcFdpdGhDYUJveEhpbnRzIiwibmFtZSI6ImFyZyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIoc3RyaW5nLGFkZHJlc3MsYWRkcmVzc1tdLGFkZHJlc3NbXSxzdHJpbmcsYm9vbCkiLCJzdHJ1Y3QiOiJOZmRUaW55IiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzE1MzVdLCJlcnJvck1lc3NhZ2UiOiJCeXRlcyBoYXMgdmFsaWQgcHJlZml4IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjRdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTA2NSwxMDgxXSwiZXJyb3JNZXNzYWdlIjoiaW5kZXggYWNjZXNzIGlzIG91dCBvZiBib3VuZHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDUsMjc3LDUzNiw5MjEsOTY5LDEwMDAsMTAyNywxMDYxLDE1MzhdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMTYsMjg4LDU0N10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXBwbGljYXRpb24+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTU0NF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDE0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIHNtYXJ0X2NvbnRyYWN0cy9uZmRfcmVhZGVyL2NvbnRyYWN0LmFsZ28udHM6OkFwcFdpdGhDYUJveEhpbnRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTYxXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCB0YWlsIHBvaW50ZXIgYXQgaW5kZXggMCBvZiAoKGxlbitib29sMVtdKSwobGVuK2Jvb2wxW10pKSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzkxM10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdGFpbCBwb2ludGVyIGF0IGluZGV4IDAgb2YgKChsZW4rdWludDY0W10pLCgobGVuK2Jvb2wxW10pLChsZW4rYm9vbDFbXSkpKSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk4OV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdGFpbCBwb2ludGVyIGF0IGluZGV4IDEgb2YgKChsZW4rYm9vbDFbXSksKGxlbitib29sMVtdKSkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5MzhdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHRhaWwgcG9pbnRlciBhdCBpbmRleCAxIG9mICgobGVuK3VpbnQ2NFtdKSwoKGxlbitib29sMVtdKSwobGVuK2Jvb2wxW10pKSkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5MDUsOTMwLDk1Myw5ODFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHR1cGxlIGVuY29kaW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTc3XSwiZXJyb3JNZXNzYWdlIjoibWF4IGFycmF5IGxlbmd0aCBleGNlZWRlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTUNBeUlERWdPQW9nSUNBZ1lubDBaV05pYkc5amF5QWlJaUFpTUNJZ01IZ3dNREF3SUNKcExtNWhiV1VpSURCNE1EQXlPU0F3ZURBd0lEQjRNVFV4Wmpkak56VWdJbll1WTJGQmJHZHZMakF1WVhNaUlDSjFMbU5oWVd4bmJ5SWdJbWt1ZG1WeUlnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI1bVpGOXlaV0ZrWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME13b2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRTVtWkZKbFlXUmxjaUJsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYlhWemRDQmlaU0JPYjA5d0NpQWdJQ0J3ZFhOb1lubDBaWE56SURCNFlUQmhNbU00WVdFZ01IZ3daR1prTTJVeVlpQXdlR001TUdKbE1qRTRJREI0T1RkaU5tRm1ZV1lnTHk4Z2JXVjBhRzlrSUNKblpYUldaWEp6YVc5dWMwWnliMjFCY0hCSlpITW9kV2x1ZERZMFcxMHBjM1J5YVc1bklpd2diV1YwYUc5a0lDSm5aWFJPWVc1dlZtbGxkMFp5YjIxQmNIQkpaSE1vZFdsdWREWTBXMTBwS0hOMGNtbHVaeXgxYVc1ME5qUXNZV1JrY21WemN5eHpkSEpwYm1jcElpd2diV1YwYUc5a0lDSm5aWFJVYVc1NVZtbGxkMFp5YjIxQmNIQkpaSE1vZFdsdWREWTBXMTBwS0hOMGNtbHVaeXhoWkdSeVpYTnpMR0ZrWkhKbGMzTmJYU3hoWkdSeVpYTnpXMTBzYzNSeWFXNW5MR0p2YjJ3cElpd2diV1YwYUc5a0lDSm5aWFJVYVc1NVZtbGxkMFp5YjIxQmNIQkpaSE5XTWlnb2RXbHVkRFkwVzEwc0tHSnZiMnhiWFN4aWIyOXNXMTBwS1Nrb2MzUnlhVzVuTEdGa1pISmxjM01zWVdSa2NtVnpjMXRkTEdGa1pISmxjM05iWFN4emRISnBibWNzWW05dmJDa2lDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0JuWlhSV1pYSnphVzl1YzBaeWIyMUJjSEJKWkhNZ1oyVjBUbUZ1YjFacFpYZEdjbTl0UVhCd1NXUnpJR2RsZEZScGJubFdhV1YzUm5KdmJVRndjRWxrY3lCblpYUlVhVzU1Vm1sbGQwWnliMjFCY0hCSlpITldNZ29nSUNBZ1pYSnlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI1bVpGOXlaV0ZrWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNmMyeHBZMlZCWTJOdmRXNTBjeWh5WVhjNklHSjVkR1Z6S1NBdFBpQmllWFJsY3pvS2MyeHBZMlZCWTJOdmRXNTBjem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXVabVJmY21WaFpHVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNakl5Q2lBZ0lDQXZMeUJtZFc1amRHbHZiaUJ6YkdsalpVRmpZMjkxYm5SektISmhkem9nWW5sMFpYTXBPaUJCWTJOdmRXNTBXMTBnZXdvZ0lDQWdjSEp2ZEc4Z01TQXhDaUFnSUNCaWVYUmxZMTh3SUM4dklDSWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJtWmtYM0psWVdSbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSXlNd29nSUNBZ0x5OGdZMjl1YzNRZ1lXTmpiM1Z1ZEhNNklFRmpZMjkxYm5SYlhTQTlJRnRkT3dvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURBd01EQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dVptUmZjbVZoWkdWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qSTBDaUFnSUNBdkx5Qm1iM0lnS0d4bGRDQnBPaUIxYVc1ME5qUWdQU0F3T3lCcElEd2djbUYzTG14bGJtZDBhQ0F2SURNeU95QnBLeXNwSUhzS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2dwemJHbGpaVUZqWTI5MWJuUnpYM2RvYVd4bFgzUnZjRUF4T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjVtWkY5eVpXRmtaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TWpRS0lDQWdJQzh2SUdadmNpQW9iR1YwSUdrNklIVnBiblEyTkNBOUlEQTdJR2tnUENCeVlYY3ViR1Z1WjNSb0lDOGdNekk3SUdrckt5a2dld29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCc1pXNEtJQ0FnSUdSMWNBb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NpQWdJQ0J3ZFhOb2FXNTBJRE15SUM4dklETXlDaUFnSUNBdkNpQWdJQ0JtY21GdFpWOWthV2NnTWdvZ0lDQWdQZ29nSUNBZ1lub2djMnhwWTJWQlkyTnZkVzUwYzE5aFpuUmxjbDkzYUdsc1pVQXpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJtWmtYM0psWVdSbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSXlOUW9nSUNBZ0x5OGdZV05qYjNWdWRITXVjSFZ6YUNoQlkyTnZkVzUwS0hKaGR5NXpiR2xqWlNocElDb2dNeklzSUNocElDc2dNU2tnS2lBek1pa3BLVHNLSUNBZ0lHWnlZVzFsWDJScFp5QXlDaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaHBiblFnTXpJZ0x5OGdNeklLSUNBZ0lDb0tJQ0FnSUdSMWNBb2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ013b2dJQ0FnUGowS0lDQWdJR1JwWnlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0J6Wld4bFkzUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lDc0tJQ0FnSUdSMWNBb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBeUNpQWdJQ0J3ZFhOb2FXNTBJRE15SUM4dklETXlDaUFnSUNBcUNpQWdJQ0JrZFhBS0lDQWdJR1JwWnlBekNpQWdJQ0ErUFFvZ0lDQWdjM2RoY0FvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnWkhWd0NpQWdJQ0JrYVdjZ01nb2dJQ0FnUEFvZ0lDQWdaR2xuSURJS0lDQWdJSE4zWVhBS0lDQWdJSE5sYkdWamRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqYjNabGNpQXlDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0JtY21GdFpWOWthV2NnTVFvZ0lDQWdaSFZ3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQ0F2THlCdmJpQmxjbkp2Y2pvZ2JXRjRJR0Z5Y21GNUlHeGxibWQwYUNCbGVHTmxaV1JsWkFvZ0lDQWdjM2RoY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSEpsY0d4aFkyVXlJREFLSUNBZ0lHWnlZVzFsWDJKMWNua2dNUW9nSUNBZ1lpQnpiR2xqWlVGalkyOTFiblJ6WDNkb2FXeGxYM1J2Y0VBeENncHpiR2xqWlVGalkyOTFiblJ6WDJGbWRHVnlYM2RvYVd4bFFETTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJtWmtYM0psWVdSbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSXlOd29nSUNBZ0x5OGdjbVYwZFhKdUlHRmpZMjkxYm5Sek93b2dJQ0FnWm5KaGJXVmZaR2xuSURFS0lDQWdJR1p5WVcxbFgySjFjbmtnTUFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjVtWkY5eVpXRmtaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VG1aa1VtVmhaR1Z5TG1kbGRGWmxjbk5wYjI1elJuSnZiVUZ3Y0Vsa2MxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWRsZEZabGNuTnBiMjV6Um5KdmJVRndjRWxrY3pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl1Wm1SZmNtVmhaR1Z5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRRS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2V5QnlaV0ZrYjI1c2VUb2dkSEoxWlN3Z2IyNURjbVZoZEdVNklDSmhiR3h2ZHlJZ2ZTa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNHNGdNZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJQ29LSUNBZ0lHbHVkR05mTVNBdkx5QXlDaUFnSUNBckNpQWdJQ0J6ZDJGd0NpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY0hCc2FXTmhkR2x2Ymo0S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2dwblpYUldaWEp6YVc5dWMwWnliMjFCY0hCSlpITmZabTl5WDJobFlXUmxja0F5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjVtWkY5eVpXRmtaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTmdvZ0lDQWdMeThnWm05eUlDaGpiMjV6ZENCaGNIQkpaQ0J2WmlCaGNIQkpaSE1wSUhzS0lDQWdJR1IxY0FvZ0lDQWdaR2xuSURJS0lDQWdJRHdLSUNBZ0lHSjZJR2RsZEZabGNuTnBiMjV6Um5KdmJVRndjRWxrYzE5aFpuUmxjbDltYjNKQU5Rb2dJQ0FnWkdsbklESUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnS2dvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl1Wm1SZmNtVmhaR1Z5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRjS0lDQWdJQzh2SUd4dlp5aGxibU52WkdWQmNtTTBLSFJvYVhNdVoyVjBWbVZ5YzJsdmJpaGhjSEJKWkNrcEtUc0tJQ0FnSUdOaGJHeHpkV0lnWjJWMFZtVnljMmx2YmdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUNzS0lDQWdJR0oxY25rZ01Rb2dJQ0FnWWlCblpYUldaWEp6YVc5dWMwWnliMjFCY0hCSlpITmZabTl5WDJobFlXUmxja0F5Q2dwblpYUldaWEp6YVc5dWMwWnliMjFCY0hCSlpITmZZV1owWlhKZlptOXlRRFU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZibVprWDNKbFlXUmxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalEwQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ2NtVmhaRzl1YkhrNklIUnlkV1VzSUc5dVEzSmxZWFJsT2lBaVlXeHNiM2NpSUgwcENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhneE5URm1OMk0zTlRBd01EQUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl1Wm1SZmNtVmhaR1Z5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2s1bVpGSmxZV1JsY2k1blpYUk9ZVzV2Vm1sbGQwWnliMjFCY0hCSlpITmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BuWlhST1lXNXZWbWxsZDBaeWIyMUJjSEJKWkhNNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaSFZ3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0lpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZibVprWDNKbFlXUmxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalV5Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ2NtVmhaRzl1YkhrNklIUnlkV1VzSUc5dVEzSmxZWFJsT2lBaVlXeHNiM2NpSUgwcENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhCdUlESUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQXFDaUFnSUNCcGJuUmpYekVnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdjM2RoY0FvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEJ3YkdsallYUnBiMjQrQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9LWjJWMFRtRnViMVpwWlhkR2NtOXRRWEJ3U1dSelgyWnZjbDlvWldGa1pYSkFNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXVabVJmY21WaFpHVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVFFLSUNBZ0lDOHZJR1p2Y2lBb1kyOXVjM1FnWVhCd1NXUWdiMllnWVhCd1NXUnpLU0I3Q2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQThDaUFnSUNCaWVpQm5aWFJPWVc1dlZtbGxkMFp5YjIxQmNIQkpaSE5mWVdaMFpYSmZabTl5UURnS0lDQWdJR1JwWnlBeUNpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdaR2xuSURFS0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQXFDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1pIVndDaUFnSUNCaWRYSjVJRFVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXVabVJmY21WaFpHVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPREVLSUNBZ0lDOHZJSEpsZEhWeWJpQnZjQzVCY0hCSGJHOWlZV3d1WjJWMFJYaENlWFJsY3loaGNIQkpaQ3dnUW5sMFpYTmdhUzV1WVcxbFlDazdDaUFnSUNCaWVYUmxZMTh6SUM4dklDSnBMbTVoYldVaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ2MzZGhjQW9nSUNBZ1luVnllU0EyQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZibVprWDNKbFlXUmxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalUyQ2lBZ0lDQXZMeUJwWmlBb1pYaHBjM1J6S1NCN0NpQWdJQ0JpZWlCblpYUk9ZVzV2Vm1sbGQwWnliMjFCY0hCSlpITmZaV3h6WlY5aWIyUjVRRFVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXVabVJmY21WaFpHVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPRFVLSUNBZ0lDOHZJR052Ym5OMElGdGhjMkZKWkVKNWRHVnpMQ0JsZUdsemRITmRJRDBnYjNBdVFYQndSMnh2WW1Gc0xtZGxkRVY0UW5sMFpYTW9ZWEJ3U1dRc0lFSjVkR1Z6WUdrdVlYTmhhV1JnS1RzS0lDQWdJR1JwWnlBekNpQWdJQ0J3ZFhOb1lubDBaWE1nSW1rdVlYTmhhV1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnYzNkaGNBb2dJQ0FnWW5WeWVTQTNDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJtWmtYM0psWVdSbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qZzJDaUFnSUNBdkx5QnlaWFIxY200Z1pYaHBjM1J6SUQ4Z2IzQXVZblJ2YVNoaGMyRkpaRUo1ZEdWektTQTZJREE3Q2lBZ0lDQmllaUJuWlhST1lXNXZWbWxsZDBaeWIyMUJjSEJKWkhOZmRHVnlibUZ5ZVY5bVlXeHpaVUF4TVFvZ0lDQWdaR2xuSURVS0lDQWdJR0owYjJrS0NtZGxkRTVoYm05V2FXVjNSbkp2YlVGd2NFbGtjMTkwWlhKdVlYSjVYMjFsY21kbFFERXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyNW1aRjl5WldGa1pYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJNQW9nSUNBZ0x5OGdiM2R1WlhJNklIUm9hWE11WjJWMFQzZHVaWElvWVhCd1NXUXBMQW9nSUNBZ1pHbG5JRFFLSUNBZ0lHUjFjQW9nSUNBZ1kyRnNiSE4xWWlCblpYUlBkMjVsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjVtWkY5eVpXRmtaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTVFvZ0lDQWdMeThnZG1WeWMybHZiam9nZEdocGN5NW5aWFJXWlhKemFXOXVLR0Z3Y0Vsa0tTd0tJQ0FnSUhOM1lYQUtJQ0FnSUdOaGJHeHpkV0lnWjJWMFZtVnljMmx2YmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjVtWkY5eVpXRmtaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xTnkwMk1nb2dJQ0FnTHk4Z1kyOXVjM1FnYm1GdWIxWnBaWGM2SUU1bVpFNWhibThnUFNCN0NpQWdJQ0F2THlBZ0lHNWhiV1U2SUc1aGJXVXVkRzlUZEhKcGJtY29LU3dLSUNBZ0lDOHZJQ0FnWVhOaFNVUTZJSFJvYVhNdVoyVjBRWE5oU1dRb1lYQndTV1FwTEFvZ0lDQWdMeThnSUNCdmQyNWxjam9nZEdocGN5NW5aWFJQZDI1bGNpaGhjSEJKWkNrc0NpQWdJQ0F2THlBZ0lIWmxjbk5wYjI0NklIUm9hWE11WjJWMFZtVnljMmx2YmloaGNIQkpaQ2tzQ2lBZ0lDQXZMeUI5T3dvZ0lDQWdaR2xuSURjS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBME5DQXZMeUEwTkFvZ0lDQWdLd29nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JwZEc5aUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01ESmpDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dNd29nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ym1aa1gzSmxZV1JsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZekNpQWdJQ0F2THlCc2IyY29aVzVqYjJSbFFYSmpOQ2h1WVc1dlZtbGxkeWtwT3dvZ0lDQWdiRzluQ2dwblpYUk9ZVzV2Vm1sbGQwWnliMjFCY0hCSlpITmZZV1owWlhKZmFXWmZaV3h6WlVBMk9nb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdLd29nSUNBZ1luVnllU0F4Q2lBZ0lDQmlJR2RsZEU1aGJtOVdhV1YzUm5KdmJVRndjRWxrYzE5bWIzSmZhR1ZoWkdWeVFESUtDbWRsZEU1aGJtOVdhV1YzUm5KdmJVRndjRWxrYzE5MFpYSnVZWEo1WDJaaGJITmxRREV4T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjVtWkY5eVpXRmtaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem80TmdvZ0lDQWdMeThnY21WMGRYSnVJR1Y0YVhOMGN5QS9JRzl3TG1KMGIya29ZWE5oU1dSQ2VYUmxjeWtnT2lBd093b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0lnWjJWMFRtRnViMVpwWlhkR2NtOXRRWEJ3U1dSelgzUmxjbTVoY25sZmJXVnlaMlZBTVRJS0NtZGxkRTVoYm05V2FXVjNSbkp2YlVGd2NFbGtjMTlsYkhObFgySnZaSGxBTlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl1Wm1SZmNtVmhaR1Z5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnpJdE56Y0tJQ0FnSUM4dklISmxkSFZ5YmlCN0NpQWdJQ0F2THlBZ0lHNWhiV1U2SUNJaUxBb2dJQ0FnTHk4Z0lDQmhjMkZKUkRvZ01Dd0tJQ0FnSUM4dklDQWdiM2R1WlhJNklFZHNiMkpoYkM1NlpYSnZRV1JrY21WemN5d0tJQ0FnSUM4dklDQWdkbVZ5YzJsdmJqb2dJaUlzQ2lBZ0lDQXZMeUI5SUhOaGRHbHpabWxsY3lCT1ptUk9ZVzV2T3dvZ0lDQWdjSFZ6YUdKNWRHVnpJR0poYzJVek1paEJRVmRCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGTVVVRkJRVUZCUVNrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl1Wm1SZmNtVmhaR1Z5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpVS0lDQWdJQzh2SUd4dlp5aGxibU52WkdWQmNtTTBLSFJvYVhNdVoyVjBSVzF3ZEhsT1ptUk9ZVzV2S0NrcEtUc0tJQ0FnSUd4dlp3b2dJQ0FnWWlCblpYUk9ZVzV2Vm1sbGQwWnliMjFCY0hCSlpITmZZV1owWlhKZmFXWmZaV3h6WlVBMkNncG5aWFJPWVc1dlZtbGxkMFp5YjIxQmNIQkpaSE5mWVdaMFpYSmZabTl5UURnNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ym1aa1gzSmxZV1JsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVeUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2djbVZoWkc5dWJIazZJSFJ5ZFdVc0lHOXVRM0psWVhSbE9pQWlZV3hzYjNjaUlIMHBDaUFnSUNCd2RYTm9ZbmwwWlhNZ1ltRnpaVE15S0VOVlVGaFpOVWxCUmxGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVTTBRVUZCUVVGQlFTa0tJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl1Wm1SZmNtVmhaR1Z5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2s1bVpGSmxZV1JsY2k1blpYUlVhVzU1Vm1sbGQwWnliMjFCY0hCSlpITmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BuWlhSVWFXNTVWbWxsZDBaeWIyMUJjSEJKWkhNNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaSFZ3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0lpQ2lBZ0lDQmtkWEJ1SURNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl1Wm1SZmNtVmhaR1Z5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRBMENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2djbVZoWkc5dWJIazZJSFJ5ZFdVc0lHOXVRM0psWVhSbE9pQWlZV3hzYjNjaUlIMHBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQnVJRElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0FxQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnYzNkaGNBb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhCd2JHbGpZWFJwYjI0K0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvS1oyVjBWR2x1ZVZacFpYZEdjbTl0UVhCd1NXUnpYMlp2Y2w5b1pXRmtaWEpBTWpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl1Wm1SZmNtVmhaR1Z5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRBMkNpQWdJQ0F2THlCbWIzSWdLR052Ym5OMElHRndjRWxrSUc5bUlHRndjRWxrY3lrZ2V3b2dJQ0FnWkhWd0NpQWdJQ0JrYVdjZ01nb2dJQ0FnUEFvZ0lDQWdZbm9nWjJWMFZHbHVlVlpwWlhkR2NtOXRRWEJ3U1dSelgyRm1kR1Z5WDJadmNrQXhOUW9nSUNBZ1pHbG5JRElLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCa2FXY2dNUW9nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUNvS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ05nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI1bVpGOXlaV0ZrWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNE1Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUc5d0xrRndjRWRzYjJKaGJDNW5aWFJGZUVKNWRHVnpLR0Z3Y0Vsa0xDQkNlWFJsYzJCcExtNWhiV1ZnS1RzS0lDQWdJR0o1ZEdWalh6TWdMeThnSW1rdWJtRnRaU0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0J6ZDJGd0NpQWdJQ0JpZFhKNUlEa0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dVptUmZjbVZoWkdWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UQTRDaUFnSUNBdkx5QnBaaUFvWlhocGMzUnpLU0I3Q2lBZ0lDQmllaUJuWlhSVWFXNTVWbWxsZDBaeWIyMUJjSEJKWkhOZlpXeHpaVjlpYjJSNVFERXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJtWmtYM0psWVdSbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXdPUW9nSUNBZ0x5OGdZMjl1YzNRZ2JXRnFiM0pXWlhKemFXOXVJRDBnZEdocGN5NW5aWFJOWVdwdmNsWmxjbk5wYjI0b1lYQndTV1FwT3dvZ0lDQWdaR2xuSURRS0lDQWdJR05oYkd4emRXSWdaMlYwVFdGcWIzSldaWEp6YVc5dUNpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ053b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI1bVpGOXlaV0ZrWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1UQUtJQ0FnSUM4dklHTnZibk4wSUdWNGNHbHlaV1FnUFNCdFlXcHZjbFpsY25OcGIyNGdQVDA5SURNZ1B5QjBhR2x6TG1kbGRFVjRjR2x5WldRb1lYQndTV1FwSURvZ1ptRnNjMlU3Q2lBZ0lDQndkWE5vYVc1MElETWdMeThnTXdvZ0lDQWdQVDBLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0ExQ2lBZ0lDQmllaUJuWlhSVWFXNTVWbWxsZDBaeWIyMUJjSEJKWkhOZmRHVnlibUZ5ZVY5bVlXeHpaVUEyQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZibVprWDNKbFlXUmxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUwTWdvZ0lDQWdMeThnWTI5dWMzUWdXMlY0Y0dseVpXUkNlWFJsY3l3Z1pYaHBjM1J6WFNBOUlHOXdMa0Z3Y0Vkc2IySmhiQzVuWlhSRmVFSjVkR1Z6S0dGd2NFbGtMQ0JDZVhSbGMyQnBMbVY0Y0dseVlYUnBiMjVVYVcxbFlDazdDaUFnSUNCa2FXY2dOQW9nSUNBZ2NIVnphR0o1ZEdWeklDSnBMbVY0Y0dseVlYUnBiMjVVYVcxbElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lITjNZWEFLSUNBZ0lHSjFjbmtnTVRBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl1Wm1SZmNtVmhaR1Z5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRRekNpQWdJQ0F2THlCcFppQW9aWGhwYzNSektTQjdDaUFnSUNCaWVpQm5aWFJVYVc1NVZtbGxkMFp5YjIxQmNIQkpaSE5mWVdaMFpYSmZhV1pmWld4elpVQXhPQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyNW1aRjl5WldGa1pYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hORFFLSUNBZ0lDOHZJR052Ym5OMElHVjRjR2x5WVhScGIyNVVhVzFsSUQwZ2IzQXVZblJ2YVNobGVIQnBjbVZrUW5sMFpYTXBPd29nSUNBZ1pHbG5JRGdLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXVabVJmY21WaFpHVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFExQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdSMnh2WW1Gc0xteGhkR1Z6ZEZScGJXVnpkR0Z0Y0NBK1BTQmxlSEJwY21GMGFXOXVWR2x0WlRzS0lDQWdJR2RzYjJKaGJDQk1ZWFJsYzNSVWFXMWxjM1JoYlhBS0lDQWdJRHc5Q2dwblpYUlVhVzU1Vm1sbGQwWnliMjFCY0hCSlpITmZZV1owWlhKZmFXNXNhVzVsWkY5emJXRnlkRjlqYjI1MGNtRmpkSE12Ym1aa1gzSmxZV1JsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwT1ptUlNaV0ZrWlhJdVoyVjBSWGh3YVhKbFpFQXhPVG9LSUNBZ0lHSjFjbmtnTndvS1oyVjBWR2x1ZVZacFpYZEdjbTl0UVhCd1NXUnpYM1JsY201aGNubGZiV1Z5WjJWQU56b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dVptUmZjbVZoWkdWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1URXhDaUFnSUNBdkx5QnBaaUFvYldGcWIzSldaWEp6YVc5dUlEMDlQU0F6SUNZbUlDRmxlSEJwY21Wa0tTQjdDaUFnSUNCa2FXY2dNd29nSUNBZ1lub2daMlYwVkdsdWVWWnBaWGRHY205dFFYQndTV1J6WDJWc2MyVmZZbTlrZVVBeE1Bb2dJQ0FnWkdsbklEWUtJQ0FnSUdKdWVpQm5aWFJVYVc1NVZtbGxkMFp5YjIxQmNIQkpaSE5mWld4elpWOWliMlI1UURFd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ym1aa1gzSmxZV1JsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeE5Rb2dJQ0FnTHk4Z2IzZHVaWEk2SUhSb2FYTXVaMlYwVDNkdVpYSW9ZWEJ3U1dRcExBb2dJQ0FnWkdsbklEUUtJQ0FnSUdSMWNBb2dJQ0FnWTJGc2JITjFZaUJuWlhSUGQyNWxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyNW1aRjl5WldGa1pYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hPVElLSUNBZ0lDOHZJSEpsZEhWeWJpQnpiR2xqWlVGalkyOTFiblJ6S0hSb2FYTXVjbVZoWkVacFpXeGtLR0Z3Y0Vsa0xDQkNlWFJsYzJCMkxtTmhRV3huYnk0d0xtRnpZQ3dnYldGcWIzSldaWEp6YVc5dUtTazdDaUFnSUNCa2FXY2dNUW9nSUNBZ1lubDBaV01nTnlBdkx5QWlkaTVqWVVGc1oyOHVNQzVoY3lJS0lDQWdJR1JwWnlBNUNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlEUUtJQ0FnSUdOaGJHeHpkV0lnY21WaFpFWnBaV3hrQ2lBZ0lDQmpZV3hzYzNWaUlITnNhV05sUVdOamIzVnVkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXVabVJmY21WaFpHVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGsyQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdjMnhwWTJWQlkyTnZkVzUwY3loMGFHbHpMbkpsWVdSR2FXVnNaQ2hoY0hCSlpDd2dRbmwwWlhOZ2RTNWpZV0ZzWjI5Z0xDQnRZV3B2Y2xabGNuTnBiMjRwS1RzS0lDQWdJR1JwWnlBekNpQWdJQ0JpZVhSbFl5QTRJQzh2SUNKMUxtTmhZV3huYnlJS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ1kyRnNiSE4xWWlCeVpXRmtSbWxsYkdRS0lDQWdJR05oYkd4emRXSWdjMnhwWTJWQlkyTnZkVzUwY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjVtWkY5eVpXRmtaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TVRnS0lDQWdJQzh2SUhabGNuTnBiMjQ2SUhSb2FYTXVaMlYwVm1WeWMybHZiaWhoY0hCSlpDa3NDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR05oYkd4emRXSWdaMlYwVm1WeWMybHZiZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyNW1aRjl5WldGa1pYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNVE10TVRJd0NpQWdJQ0F2THlCbGJtTnZaR1ZCY21NMEtIc0tJQ0FnSUM4dklDQWdibUZ0WlRvZ2JtRnRaUzUwYjFOMGNtbHVaeWdwTEFvZ0lDQWdMeThnSUNCdmQyNWxjam9nZEdocGN5NW5aWFJQZDI1bGNpaGhjSEJKWkNrc0NpQWdJQ0F2THlBZ0lHTmhRV3huYnpvZ2RHaHBjeTVuWlhSRFlVRnNaMjhvWVhCd1NXUXNJRzFoYW05eVZtVnljMmx2Ymlrc0NpQWdJQ0F2THlBZ0lIVnVkbVZ5YVdacFpXUkRZVUZzWjI4NklIUm9hWE11WjJWMFZXNTJaWEpwWm1sbFpFTmhRV3huYnloaGNIQkpaQ3dnYldGcWIzSldaWEp6YVc5dUtTd0tJQ0FnSUM4dklDQWdkbVZ5YzJsdmJqb2dkR2hwY3k1blpYUldaWEp6YVc5dUtHRndjRWxrS1N3S0lDQWdJQzh2SUNBZ1pYaHdhWEpsWkRvZ1ptRnNjMlVzQ2lBZ0lDQXZMeUI5SUhOaGRHbHpabWxsY3lCT1ptUlVhVzU1S1FvZ0lDQWdaR2xuSURFeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ05ERWdMeThnTkRFS0lDQWdJQ3NLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdNSGd3TURJNUNpQWdJQ0IxYm1OdmRtVnlJRFlLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURFS0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBMUNpQWdJQ0JzWlc0S0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ0t3b2dJQ0FnWkhWd0NpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUEwQ2lBZ0lDQnNaVzRLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURNS0lDQWdJR3hsYmdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWaklEVWdMeThnTUhnd01Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl1Wm1SZmNtVmhaR1Z5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRFeUxURXlNUW9nSUNBZ0x5OGdiRzluS0FvZ0lDQWdMeThnSUNCbGJtTnZaR1ZCY21NMEtIc0tJQ0FnSUM4dklDQWdJQ0J1WVcxbE9pQnVZVzFsTG5SdlUzUnlhVzVuS0Nrc0NpQWdJQ0F2THlBZ0lDQWdiM2R1WlhJNklIUm9hWE11WjJWMFQzZHVaWElvWVhCd1NXUXBMQW9nSUNBZ0x5OGdJQ0FnSUdOaFFXeG5iem9nZEdocGN5NW5aWFJEWVVGc1oyOG9ZWEJ3U1dRc0lHMWhhbTl5Vm1WeWMybHZiaWtzQ2lBZ0lDQXZMeUFnSUNBZ2RXNTJaWEpwWm1sbFpFTmhRV3huYnpvZ2RHaHBjeTVuWlhSVmJuWmxjbWxtYVdWa1EyRkJiR2R2S0dGd2NFbGtMQ0J0WVdwdmNsWmxjbk5wYjI0cExBb2dJQ0FnTHk4Z0lDQWdJSFpsY25OcGIyNDZJSFJvYVhNdVoyVjBWbVZ5YzJsdmJpaGhjSEJKWkNrc0NpQWdJQ0F2THlBZ0lDQWdaWGh3YVhKbFpEb2dabUZzYzJVc0NpQWdJQ0F2THlBZ0lIMGdjMkYwYVhObWFXVnpJRTVtWkZScGJua3BDaUFnSUNBdkx5QXBPd29nSUNBZ2JHOW5DZ3BuWlhSVWFXNTVWbWxsZDBaeWIyMUJjSEJKWkhOZllXWjBaWEpmYVdaZlpXeHpaVUF4TXpvS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lDc0tJQ0FnSUdKMWNua2dNUW9nSUNBZ1lpQm5aWFJVYVc1NVZtbGxkMFp5YjIxQmNIQkpaSE5mWm05eVgyaGxZV1JsY2tBeUNncG5aWFJVYVc1NVZtbGxkMFp5YjIxQmNIQkpaSE5mWld4elpWOWliMlI1UURFd09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI1bVpGOXlaV0ZrWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1qWUtJQ0FnSUM4dklHOTNibVZ5T2lCMGFHbHpMbWRsZEU5M2JtVnlLR0Z3Y0Vsa0tTd0tJQ0FnSUdScFp5QTBDaUFnSUNCa2RYQUtJQ0FnSUdOaGJHeHpkV0lnWjJWMFQzZHVaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXVabVJmY21WaFpHVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEk1Q2lBZ0lDQXZMeUIyWlhKemFXOXVPaUIwYUdsekxtZGxkRlpsY25OcGIyNG9ZWEJ3U1dRcExBb2dJQ0FnYzNkaGNBb2dJQ0FnWTJGc2JITjFZaUJuWlhSV1pYSnphVzl1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZibVprWDNKbFlXUmxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV5TkMweE16RUtJQ0FnSUM4dklHVnVZMjlrWlVGeVl6UW9ld29nSUNBZ0x5OGdJQ0J1WVcxbE9pQnVZVzFsTG5SdlUzUnlhVzVuS0Nrc0NpQWdJQ0F2THlBZ0lHOTNibVZ5T2lCMGFHbHpMbWRsZEU5M2JtVnlLR0Z3Y0Vsa0tTd0tJQ0FnSUM4dklDQWdZMkZCYkdkdk9pQmJYU0JoY3lCQlkyTnZkVzUwVzEwc0NpQWdJQ0F2THlBZ0lIVnVkbVZ5YVdacFpXUkRZVUZzWjI4NklGdGRJR0Z6SUVGalkyOTFiblJiWFN3S0lDQWdJQzh2SUNBZ2RtVnljMmx2YmpvZ2RHaHBjeTVuWlhSV1pYSnphVzl1S0dGd2NFbGtLU3dLSUNBZ0lDOHZJQ0FnWlhod2FYSmxaQ3dLSUNBZ0lDOHZJSDBnYzJGMGFYTm1hV1Z6SUU1bVpGUnBibmtwQ2lBZ0lDQmthV2NnT1FvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURReElDOHZJRFF4Q2lBZ0lDQXJDaUFnSUNCaWVYUmxZeUEwSUM4dklEQjRNREF5T1FvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkhWd0NpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ013b2dJQ0FnYkdWdUNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTWdOU0F2THlBd2VEQXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWkdsbklERXhDaUFnSUNCelpYUmlhWFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TURBd01EQXdDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjVtWkY5eVpXRmtaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TWpNdE1UTXlDaUFnSUNBdkx5QnNiMmNvQ2lBZ0lDQXZMeUFnSUdWdVkyOWtaVUZ5WXpRb2V3b2dJQ0FnTHk4Z0lDQWdJRzVoYldVNklHNWhiV1V1ZEc5VGRISnBibWNvS1N3S0lDQWdJQzh2SUNBZ0lDQnZkMjVsY2pvZ2RHaHBjeTVuWlhSUGQyNWxjaWhoY0hCSlpDa3NDaUFnSUNBdkx5QWdJQ0FnWTJGQmJHZHZPaUJiWFNCaGN5QkJZMk52ZFc1MFcxMHNDaUFnSUNBdkx5QWdJQ0FnZFc1MlpYSnBabWxsWkVOaFFXeG5iem9nVzEwZ1lYTWdRV05qYjNWdWRGdGRMQW9nSUNBZ0x5OGdJQ0FnSUhabGNuTnBiMjQ2SUhSb2FYTXVaMlYwVm1WeWMybHZiaWhoY0hCSlpDa3NDaUFnSUNBdkx5QWdJQ0FnWlhod2FYSmxaQ3dLSUNBZ0lDOHZJQ0FnZlNCellYUnBjMlpwWlhNZ1RtWmtWR2x1ZVNrS0lDQWdJQzh2SUNrN0NpQWdJQ0JzYjJjS0lDQWdJR0lnWjJWMFZHbHVlVlpwWlhkR2NtOXRRWEJ3U1dSelgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRNS0NtZGxkRlJwYm5sV2FXVjNSbkp2YlVGd2NFbGtjMTloWm5SbGNsOXBabDlsYkhObFFERTRPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyNW1aRjl5WldGa1pYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hORGNLSUNBZ0lDOHZJSEpsZEhWeWJpQm1ZV3h6WlRzS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZibVprWDNKbFlXUmxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV4TUFvZ0lDQWdMeThnWTI5dWMzUWdaWGh3YVhKbFpDQTlJRzFoYW05eVZtVnljMmx2YmlBOVBUMGdNeUEvSUhSb2FYTXVaMlYwUlhod2FYSmxaQ2hoY0hCSlpDa2dPaUJtWVd4elpUc0tJQ0FnSUdJZ1oyVjBWR2x1ZVZacFpYZEdjbTl0UVhCd1NXUnpYMkZtZEdWeVgybHViR2x1WldSZmMyMWhjblJmWTI5dWRISmhZM1J6TDI1bVpGOXlaV0ZrWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlRtWmtVbVZoWkdWeUxtZGxkRVY0Y0dseVpXUkFNVGtLQ21kbGRGUnBibmxXYVdWM1JuSnZiVUZ3Y0Vsa2MxOTBaWEp1WVhKNVgyWmhiSE5sUURZNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ym1aa1gzSmxZV1JsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeE1Bb2dJQ0FnTHk4Z1kyOXVjM1FnWlhod2FYSmxaQ0E5SUcxaGFtOXlWbVZ5YzJsdmJpQTlQVDBnTXlBL0lIUm9hWE11WjJWMFJYaHdhWEpsWkNoaGNIQkpaQ2tnT2lCbVlXeHpaVHNLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWRYSjVJRGNLSUNBZ0lHSWdaMlYwVkdsdWVWWnBaWGRHY205dFFYQndTV1J6WDNSbGNtNWhjbmxmYldWeVoyVkFOd29LWjJWMFZHbHVlVlpwWlhkR2NtOXRRWEJ3U1dSelgyVnNjMlZmWW05a2VVQXhNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXVabVJmY21WaFpHVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVE0xQ2lBZ0lDQXZMeUJzYjJjb1pXNWpiMlJsUVhKak5DaDBhR2x6TG1kbGRFVnRjSFI1VG1aa1ZHbHVlU2dpTUNJcEtTazdDaUFnSUNCaWVYUmxZMTh4SUM4dklDSXdJZ29nSUNBZ1kyRnNiSE4xWWlCblpYUkZiWEIwZVU1bVpGUnBibmtLSUNBZ0lHeHZad29nSUNBZ1lpQm5aWFJVYVc1NVZtbGxkMFp5YjIxQmNIQkpaSE5mWVdaMFpYSmZhV1pmWld4elpVQXhNd29LWjJWMFZHbHVlVlpwWlhkR2NtOXRRWEJ3U1dSelgyRm1kR1Z5WDJadmNrQXhOVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXVabVJmY21WaFpHVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVE00Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdkR2hwY3k1blpYUkZiWEIwZVU1bVpGUnBibmtvSWpBaUtUc0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0lqQWlDaUFnSUNCallXeHNjM1ZpSUdkbGRFVnRjSFI1VG1aa1ZHbHVlUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyNW1aRjl5WldGa1pYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNRFFLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU3dnYjI1RGNtVmhkR1U2SUNKaGJHeHZkeUlnZlNrS0lDQWdJR0o1ZEdWaklEWWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZibVprWDNKbFlXUmxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBPWm1SU1pXRmtaWEl1WjJWMFZHbHVlVlpwWlhkR2NtOXRRWEJ3U1dSelZqSmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BuWlhSVWFXNTVWbWxsZDBaeWIyMUJjSEJKWkhOV01qb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JrZFhCdUlETUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0lpSUtJQ0FnSUdSMWNHNGdNd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyNW1aRjl5WldGa1pYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOVEFLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU3dnYjI1RGNtVmhkR1U2SUNKaGJHeHZkeUlnZlNrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0c0Z01nb2dJQ0FnYkdWdUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJSFIxY0d4bElHVnVZMjlrYVc1bkNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlETUtJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0EwSUM4dklEUUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0IwWVdsc0lIQnZhVzUwWlhJZ1lYUWdhVzVrWlhnZ01DQnZaaUFvS0d4bGJpdDFhVzUwTmpSYlhTa3NLQ2hzWlc0clltOXZiREZiWFNrc0tHeGxiaXRpYjI5c01WdGRLU2twQ2lBZ0lDQmthV2NnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdaR2xuSURJS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdLZ29nSUNBZ2NIVnphR2x1ZENBMklDOHZJRFlLSUNBZ0lDc0tJQ0FnSUdScFp5QXlDaUFnSUNCcGJuUmpYekVnTHk4Z01nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnZEhWd2JHVWdaVzVqYjJScGJtY0tJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdOQW9nSUNBZ1pIVndDaUFnSUNCa2FXY2dNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUhSaGFXd2djRzlwYm5SbGNpQmhkQ0JwYm1SbGVDQXhJRzltSUNnb2JHVnVLM1ZwYm5RMk5GdGRLU3dvS0d4bGJpdGliMjlzTVZ0ZEtTd29iR1Z1SzJKdmIyd3hXMTBwS1NrS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2MzZGhjQW9nSUNBZ1pHbG5JRE1LSUNBZ0lITjFZbk4wY21sdVp6TUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNd29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdScFp5QXhDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnZEhWd2JHVWdaVzVqYjJScGJtY0tJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdOUW9nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURRZ0x5OGdOQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUhSaGFXd2djRzlwYm5SbGNpQmhkQ0JwYm1SbGVDQXdJRzltSUNnb2JHVnVLMkp2YjJ3eFcxMHBMQ2hzWlc0clltOXZiREZiWFNrcENpQWdJQ0JrYVdjZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWkdsbklESUtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCd2RYTm9hVzUwSURjZ0x5OGdOd29nSUNBZ0t3b2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJQzhLSUNBZ0lIQjFjMmhwYm5RZ05pQXZMeUEyQ2lBZ0lDQXJDaUFnSUNCa2FXY2dNZ29nSUNBZ2FXNTBZMTh4SUM4dklESUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUhSMWNHeGxJR1Z1WTI5a2FXNW5DaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRFlLSUNBZ0lHUjFjQW9nSUNBZ1pHbG5JRElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCMFlXbHNJSEJ2YVc1MFpYSWdZWFFnYVc1a1pYZ2dNU0J2WmlBb0tHeGxiaXRpYjI5c01WdGRLU3dvYkdWdUsySnZiMnd4VzEwcEtRb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ05Bb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTkFvZ0lDQWdjSFZ6YUdsdWRDQTNJQzh2SURjS0lDQWdJQ3NLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNBdkNpQWdJQ0JwYm5Salh6RWdMeThnTWdvZ0lDQWdLd29nSUNBZ0t3b2dJQ0FnS3dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdjMjFoY25SZlkyOXVkSEpoWTNSekwyNW1aRjl5WldGa1pYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZRWEJ3VjJsMGFFTmhRbTk0U0dsdWRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dVptUmZjbVZoWkdWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UVXlDaUFnSUNBdkx5Qm1iM0lnS0d4bGRDQnBPaUIxYVc1ME5qUWdQU0F3T3lCcElEd2dZWEpuTG1Gd2NFbGtjeTVzWlc1bmRHZzdJR2tyS3lrZ2V3b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0NtZGxkRlJwYm5sV2FXVjNSbkp2YlVGd2NFbGtjMVl5WDNkb2FXeGxYM1J2Y0VBeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI1bVpGOXlaV0ZrWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5USUtJQ0FnSUM4dklHWnZjaUFvYkdWMElHazZJSFZwYm5RMk5DQTlJREE3SUdrZ1BDQmhjbWN1WVhCd1NXUnpMbXhsYm1kMGFEc2dhU3NyS1NCN0NpQWdJQ0JrYVdjZ09Bb2dJQ0FnWkdsbklEZ0tJQ0FnSUdScFp5QTRDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ01UZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQmthV2NnTVFvZ0lDQWdQZ29nSUNBZ1lub2daMlYwVkdsdWVWWnBaWGRHY205dFFYQndTV1J6VmpKZllXWjBaWEpmZDJocGJHVkFNVFVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXVabVJmY21WaFpHVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFV5TFRFMU13b2dJQ0FnTHk4Z1ptOXlJQ2hzWlhRZ2FUb2dkV2x1ZERZMElEMGdNRHNnYVNBOElHRnlaeTVoY0hCSlpITXViR1Z1WjNSb095QnBLeXNwSUhzS0lDQWdJQzh2SUNBZ1kyOXVjM1FnWVhCd1NXUWdQU0JoY21jdVlYQndTV1J6VzJsZE93b2dJQ0FnWkdsbklERTJDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnWkdsbklERUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUNvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl1Wm1SZmNtVmhaR1Z5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRVekNpQWdJQ0F2THlCamIyNXpkQ0JoY0hCSlpDQTlJR0Z5Wnk1aGNIQkpaSE5iYVYwN0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCaWRYSjVJREUxQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZibVprWDNKbFlXUmxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUxTkFvZ0lDQWdMeThnWTI5dWMzUWdhR0Z6Vm1WeWFXWnBaV1JEWVVGc1oyOUNiM2dnUFNCaGNtY3VZbTk0U0dsdWRITXVhR0Z6Vm1WeWFXWnBaV1JEWVVGc1oyOUNiM2hiYVYwN0NpQWdJQ0JrYVdjZ053b2dJQ0FnWkdsbklEY0tJQ0FnSUdScFp5QTNDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCa2FXY2dNZ29nSUNBZ1Bnb2dJQ0FnWVhOelpYSjBJQzh2SUdsdVpHVjRJR0ZqWTJWemN5QnBjeUJ2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0JrYVdjZ01Rb2dJQ0FnY0hWemFHbHVkQ0F4TmlBdkx5QXhOZ29nSUNBZ0t3b2dJQ0FnYzNkaGNBb2dJQ0FnWkdsbklERUtJQ0FnSUdkbGRHSnBkQW9nSUNBZ1luVnllU0F4TkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjVtWkY5eVpXRmtaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TlRRdE1UVTFDaUFnSUNBdkx5QmpiMjV6ZENCb1lYTldaWEpwWm1sbFpFTmhRV3huYjBKdmVDQTlJR0Z5Wnk1aWIzaElhVzUwY3k1b1lYTldaWEpwWm1sbFpFTmhRV3huYjBKdmVGdHBYVHNLSUNBZ0lDOHZJR052Ym5OMElHaGhjMVZ1ZG1WeWFXWnBaV1JEWVVGc1oyOUNiM2dnUFNCaGNtY3VZbTk0U0dsdWRITXVhR0Z6Vlc1MlpYSnBabWxsWkVOaFFXeG5iMEp2ZUZ0cFhUc0tJQ0FnSUhOM1lYQUtJQ0FnSUdScFp5QTBDaUFnSUNBOENpQWdJQ0JoYzNObGNuUWdMeThnYVc1a1pYZ2dZV05qWlhOeklHbHpJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJR1JwWnlBMENpQWdJQ0J6ZDJGd0NpQWdJQ0JuWlhSaWFYUUtJQ0FnSUdKMWNua2dNVE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXVabVJmY21WaFpHVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPREVLSUNBZ0lDOHZJSEpsZEhWeWJpQnZjQzVCY0hCSGJHOWlZV3d1WjJWMFJYaENlWFJsY3loaGNIQkpaQ3dnUW5sMFpYTmdhUzV1WVcxbFlDazdDaUFnSUNCaWVYUmxZMTh6SUM4dklDSnBMbTVoYldVaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ2MzZGhjQW9nSUNBZ1luVnllU0F4TndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjVtWkY5eVpXRmtaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TlRnS0lDQWdJQzh2SUdsbUlDaGxlR2x6ZEhNcElIc0tJQ0FnSUdKNklHZGxkRlJwYm5sV2FXVjNSbkp2YlVGd2NFbGtjMVl5WDJWc2MyVmZZbTlrZVVBeE13b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI1bVpGOXlaV0ZrWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5Ua0tJQ0FnSUM4dklHTnZibk4wSUcxaGFtOXlWbVZ5YzJsdmJpQTlJSFJvYVhNdVoyVjBUV0ZxYjNKV1pYSnphVzl1S0dGd2NFbGtLVHNLSUNBZ0lHUnBaeUF4TWdvZ0lDQWdZMkZzYkhOMVlpQm5aWFJOWVdwdmNsWmxjbk5wYjI0S0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBeE1Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI1bVpGOXlaV0ZrWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5qQUtJQ0FnSUM4dklHbG1JQ2h0WVdwdmNsWmxjbk5wYjI0Z0lUMDlJRElwSUhzS0lDQWdJR2x1ZEdOZk1TQXZMeUF5Q2lBZ0lDQWhQUW9nSUNBZ1lub2daMlYwVkdsdWVWWnBaWGRHY205dFFYQndTV1J6VmpKZllXWjBaWEpmYVdaZlpXeHpaVUEyQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZibVprWDNKbFlXUmxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUyTVFvZ0lDQWdMeThnYkc5bktDSkZVbEk2VGxZeUlpazdDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lrVlNVanBPVmpJaUNpQWdJQ0JzYjJjS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl1Wm1SZmNtVmhaR1Z5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRZeUNpQWdJQ0F2THlCbGNuSW9LVHNLSUNBZ0lHVnljZ29LWjJWMFZHbHVlVlpwWlhkR2NtOXRRWEJ3U1dSelZqSmZZV1owWlhKZmFXWmZaV3h6WlVBMk9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI1bVpGOXlaV0ZrWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5qWUtJQ0FnSUM4dklHOTNibVZ5T2lCMGFHbHpMbWRsZEU5M2JtVnlLR0Z3Y0Vsa0tTd0tJQ0FnSUdScFp5QXhNZ29nSUNBZ1kyRnNiSE4xWWlCblpYUlBkMjVsY2dvZ0lDQWdZblZ5ZVNBeE5Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI1bVpGOXlaV0ZrWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5qY0tJQ0FnSUM4dklHTmhRV3huYnpvZ2FHRnpWbVZ5YVdacFpXUkRZVUZzWjI5Q2IzZ2dQeUIwYUdsekxtZGxkRU5oUVd4bmJ5aGhjSEJKWkN3Z2JXRnFiM0pXWlhKemFXOXVLU0E2SUZ0ZExBb2dJQ0FnWkdsbklERXdDaUFnSUNCaWVpQm5aWFJVYVc1NVZtbGxkMFp5YjIxQmNIQkpaSE5XTWw5MFpYSnVZWEo1WDJaaGJITmxRRGdLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXVabVJmY21WaFpHVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGt5Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdjMnhwWTJWQlkyTnZkVzUwY3loMGFHbHpMbkpsWVdSR2FXVnNaQ2hoY0hCSlpDd2dRbmwwWlhOZ2RpNWpZVUZzWjI4dU1DNWhjMkFzSUcxaGFtOXlWbVZ5YzJsdmJpa3BPd29nSUNBZ1pHbG5JREV5Q2lBZ0lDQmllWFJsWXlBM0lDOHZJQ0oyTG1OaFFXeG5ieTR3TG1Geklnb2dJQ0FnWkdsbklERXhDaUFnSUNCallXeHNjM1ZpSUhKbFlXUkdhV1ZzWkFvZ0lDQWdZMkZzYkhOMVlpQnpiR2xqWlVGalkyOTFiblJ6Q2lBZ0lDQmlkWEo1SURFMUNncG5aWFJVYVc1NVZtbGxkMFp5YjIxQmNIQkpaSE5XTWw5MFpYSnVZWEo1WDIxbGNtZGxRRGs2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZibVprWDNKbFlXUmxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUyT0FvZ0lDQWdMeThnZFc1MlpYSnBabWxsWkVOaFFXeG5iem9nYUdGelZXNTJaWEpwWm1sbFpFTmhRV3huYjBKdmVDQS9JSFJvYVhNdVoyVjBWVzUyWlhKcFptbGxaRU5oUVd4bmJ5aGhjSEJKWkN3Z2JXRnFiM0pXWlhKemFXOXVLU0E2SUZ0ZExBb2dJQ0FnWkdsbklERXhDaUFnSUNCaWVpQm5aWFJVYVc1NVZtbGxkMFp5YjIxQmNIQkpaSE5XTWw5MFpYSnVZWEo1WDJaaGJITmxRREV4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZibVprWDNKbFlXUmxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakU1TmdvZ0lDQWdMeThnY21WMGRYSnVJSE5zYVdObFFXTmpiM1Z1ZEhNb2RHaHBjeTV5WldGa1JtbGxiR1FvWVhCd1NXUXNJRUo1ZEdWellIVXVZMkZoYkdkdllDd2diV0ZxYjNKV1pYSnphVzl1S1NrN0NpQWdJQ0JrYVdjZ01USUtJQ0FnSUdKNWRHVmpJRGdnTHk4Z0luVXVZMkZoYkdkdklnb2dJQ0FnWkdsbklERXhDaUFnSUNCallXeHNjM1ZpSUhKbFlXUkdhV1ZzWkFvZ0lDQWdZMkZzYkhOMVlpQnpiR2xqWlVGalkyOTFiblJ6Q2dwblpYUlVhVzU1Vm1sbGQwWnliMjFCY0hCSlpITldNbDkwWlhKdVlYSjVYMjFsY21kbFFERXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyNW1aRjl5WldGa1pYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOamtLSUNBZ0lDOHZJSFpsY25OcGIyNDZJSFJvYVhNdVoyVjBWbVZ5YzJsdmJpaGhjSEJKWkNrc0NpQWdJQ0JrYVdjZ01UTUtJQ0FnSUdOaGJHeHpkV0lnWjJWMFZtVnljMmx2YmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjVtWkY5eVpXRmtaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TmpRdE1UY3hDaUFnSUNBdkx5QmpiMjV6ZENCMGFXNTVWbWxsZHpvZ1RtWmtWR2x1ZVNBOUlIc0tJQ0FnSUM4dklDQWdibUZ0WlRvZ2JtRnRaUzUwYjFOMGNtbHVaeWdwTEFvZ0lDQWdMeThnSUNCdmQyNWxjam9nZEdocGN5NW5aWFJQZDI1bGNpaGhjSEJKWkNrc0NpQWdJQ0F2THlBZ0lHTmhRV3huYnpvZ2FHRnpWbVZ5YVdacFpXUkRZVUZzWjI5Q2IzZ2dQeUIwYUdsekxtZGxkRU5oUVd4bmJ5aGhjSEJKWkN3Z2JXRnFiM0pXWlhKemFXOXVLU0E2SUZ0ZExBb2dJQ0FnTHk4Z0lDQjFiblpsY21sbWFXVmtRMkZCYkdkdk9pQm9ZWE5WYm5abGNtbG1hV1ZrUTJGQmJHZHZRbTk0SUQ4Z2RHaHBjeTVuWlhSVmJuWmxjbWxtYVdWa1EyRkJiR2R2S0dGd2NFbGtMQ0J0WVdwdmNsWmxjbk5wYjI0cElEb2dXMTBzQ2lBZ0lDQXZMeUFnSUhabGNuTnBiMjQ2SUhSb2FYTXVaMlYwVm1WeWMybHZiaWhoY0hCSlpDa3NDaUFnSUNBdkx5QWdJR1Y0Y0dseVpXUTZJR1poYkhObExBb2dJQ0FnTHk4Z2ZUc0tJQ0FnSUdScFp5QXhOd29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRFF4SUM4dklEUXhDaUFnSUNBckNpQWdJQ0JpZVhSbFl5QTBJQzh2SURCNE1EQXlPUW9nSUNBZ1pHbG5JREU0Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBeENpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ01Ua0tJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNd29nSUNBZ2JHVnVDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJQ3NLSUNBZ0lHUjFjQW9nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFVLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTXdvZ0lDQWdiR1Z1Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUNzS0lDQWdJR1JwWnlBMUNpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQjFibU52ZG1WeUlEWUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFl5QTFJQzh2SURCNE1EQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ym1aa1gzSmxZV1JsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFM01nb2dJQ0FnTHk4Z2JHOW5LR1Z1WTI5a1pVRnlZelFvZEdsdWVWWnBaWGNwS1RzS0lDQWdJR3h2WndvS1oyVjBWR2x1ZVZacFpYZEdjbTl0UVhCd1NXUnpWakpmWVdaMFpYSmZhV1pmWld4elpVQXhORG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXVabVJmY21WaFpHVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFV5Q2lBZ0lDQXZMeUJtYjNJZ0tHeGxkQ0JwT2lCMWFXNTBOalFnUFNBd095QnBJRHdnWVhKbkxtRndjRWxrY3k1c1pXNW5kR2c3SUdrckt5a2dld29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JpSUdkbGRGUnBibmxXYVdWM1JuSnZiVUZ3Y0Vsa2MxWXlYM2RvYVd4bFgzUnZjRUF5Q2dwblpYUlVhVzU1Vm1sbGQwWnliMjFCY0hCSlpITldNbDkwWlhKdVlYSjVYMlpoYkhObFFERXhPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyNW1aRjl5WldGa1pYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOamdLSUNBZ0lDOHZJSFZ1ZG1WeWFXWnBaV1JEWVVGc1oyODZJR2hoYzFWdWRtVnlhV1pwWldSRFlVRnNaMjlDYjNnZ1B5QjBhR2x6TG1kbGRGVnVkbVZ5YVdacFpXUkRZVUZzWjI4b1lYQndTV1FzSUcxaGFtOXlWbVZ5YzJsdmJpa2dPaUJiWFN3S0lDQWdJR0o1ZEdWalh6SWdMeThnTUhnd01EQXdDaUFnSUNCaUlHZGxkRlJwYm5sV2FXVjNSbkp2YlVGd2NFbGtjMVl5WDNSbGNtNWhjbmxmYldWeVoyVkFNVElLQ21kbGRGUnBibmxXYVdWM1JuSnZiVUZ3Y0Vsa2MxWXlYM1JsY201aGNubGZabUZzYzJWQU9Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dVptUmZjbVZoWkdWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UWTNDaUFnSUNBdkx5QmpZVUZzWjI4NklHaGhjMVpsY21sbWFXVmtRMkZCYkdkdlFtOTRJRDhnZEdocGN5NW5aWFJEWVVGc1oyOG9ZWEJ3U1dRc0lHMWhhbTl5Vm1WeWMybHZiaWtnT2lCYlhTd0tJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3dNREF3Q2lBZ0lDQmlkWEo1SURFMUNpQWdJQ0JpSUdkbGRGUnBibmxXYVdWM1JuSnZiVUZ3Y0Vsa2MxWXlYM1JsY201aGNubGZiV1Z5WjJWQU9Rb0taMlYwVkdsdWVWWnBaWGRHY205dFFYQndTV1J6VmpKZlpXeHpaVjlpYjJSNVFERXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyNW1aRjl5WldGa1pYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOelFLSUNBZ0lDOHZJR3h2WnlobGJtTnZaR1ZCY21NMEtIUm9hWE11WjJWMFJXMXdkSGxPWm1SVWFXNTVLQ0l3SWlrcEtUc0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0lqQWlDaUFnSUNCallXeHNjM1ZpSUdkbGRFVnRjSFI1VG1aa1ZHbHVlUW9nSUNBZ2JHOW5DaUFnSUNCaUlHZGxkRlJwYm5sV2FXVjNSbkp2YlVGd2NFbGtjMVl5WDJGbWRHVnlYMmxtWDJWc2MyVkFNVFFLQ21kbGRGUnBibmxXYVdWM1JuSnZiVUZ3Y0Vsa2MxWXlYMkZtZEdWeVgzZG9hV3hsUURFMU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI1bVpGOXlaV0ZrWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE56Y0tJQ0FnSUM4dklISmxkSFZ5YmlCMGFHbHpMbWRsZEVWdGNIUjVUbVprVkdsdWVTZ2lNQ0lwT3dvZ0lDQWdZbmwwWldOZk1TQXZMeUFpTUNJS0lDQWdJR05oYkd4emRXSWdaMlYwUlcxd2RIbE9abVJVYVc1NUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ym1aa1gzSmxZV1JsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMU1Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJSEpsWVdSdmJteDVPaUIwY25WbExDQnZia055WldGMFpUb2dJbUZzYkc5M0lpQjlLUW9nSUNBZ1lubDBaV01nTmlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dVptUmZjbVZoWkdWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rNW1aRkpsWVdSbGNpNW5aWFJQZDI1bGNpaGhjSEJKWkRvZ2RXbHVkRFkwS1NBdFBpQmllWFJsY3pvS1oyVjBUM2R1WlhJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ym1aa1gzSmxZV1JsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pnNUNpQWdJQ0F2THlCd2NtbDJZWFJsSUdkbGRFOTNibVZ5S0dGd2NFbGtPaUJCY0hCc2FXTmhkR2x2YmlrNklFRmpZMjkxYm5RZ2V3b2dJQ0FnY0hKdmRHOGdNU0F4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZibVprWDNKbFlXUmxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamt3Q2lBZ0lDQXZMeUJqYjI1emRDQmJiM2R1WlhKQ2VYUmxjeXdnWlhocGMzUnpYU0E5SUc5d0xrRndjRWRzYjJKaGJDNW5aWFJGZUVKNWRHVnpLR0Z3Y0Vsa0xDQkNlWFJsYzJCcExtOTNibVZ5TG1GZ0tUc0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnY0hWemFHSjVkR1Z6SUNKcExtOTNibVZ5TG1FaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyNW1aRjl5WldGa1pYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzVNUW9nSUNBZ0x5OGdjbVYwZFhKdUlHVjRhWE4wY3lBL0lFRmpZMjkxYm5Rb2IzZHVaWEpDZVhSbGN5a2dPaUJIYkc5aVlXd3VlbVZ5YjBGa1pISmxjM003Q2lBZ0lDQmllaUJuWlhSUGQyNWxjbDkwWlhKdVlYSjVYMlpoYkhObFFESUtJQ0FnSUdaeVlXMWxYMlJwWnlBd0NncG5aWFJQZDI1bGNsOTBaWEp1WVhKNVgyMWxjbWRsUURNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ym1aa1gzSmxZV1JsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2preENpQWdJQ0F2THlCeVpYUjFjbTRnWlhocGMzUnpJRDhnUVdOamIzVnVkQ2h2ZDI1bGNrSjVkR1Z6S1NBNklFZHNiMkpoYkM1NlpYSnZRV1JrY21WemN6c0tJQ0FnSUhOM1lYQUtJQ0FnSUhKbGRITjFZZ29LWjJWMFQzZHVaWEpmZEdWeWJtRnllVjltWVd4elpVQXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyNW1aRjl5WldGa1pYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzVNUW9nSUNBZ0x5OGdjbVYwZFhKdUlHVjRhWE4wY3lBL0lFRmpZMjkxYm5Rb2IzZHVaWEpDZVhSbGN5a2dPaUJIYkc5aVlXd3VlbVZ5YjBGa1pISmxjM003Q2lBZ0lDQm5iRzlpWVd3Z1dtVnliMEZrWkhKbGMzTUtJQ0FnSUdJZ1oyVjBUM2R1WlhKZmRHVnlibUZ5ZVY5dFpYSm5aVUF6Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyNW1aRjl5WldGa1pYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZUbVprVW1WaFpHVnlMbWRsZEZabGNuTnBiMjRvWVhCd1NXUTZJSFZwYm5RMk5Da2dMVDRnWW5sMFpYTTZDbWRsZEZabGNuTnBiMjQ2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZibVprWDNKbFlXUmxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamswQ2lBZ0lDQXZMeUJ3Y21sMllYUmxJR2RsZEZabGNuTnBiMjRvWVhCd1NXUTZJRUZ3Y0d4cFkyRjBhVzl1S1RvZ2MzUnlhVzVuSUhzS0lDQWdJSEJ5YjNSdklERWdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyNW1aRjl5WldGa1pYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzVOUW9nSUNBZ0x5OGdZMjl1YzNRZ1czWmxjbk5wYjI1Q2VYUmxjeXdnWlhocGMzUnpYU0E5SUc5d0xrRndjRWRzYjJKaGJDNW5aWFJGZUVKNWRHVnpLR0Z3Y0Vsa0xDQkNlWFJsYzJCcExuWmxjbUFwT3dvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmllWFJsWXlBNUlDOHZJQ0pwTG5abGNpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZibVprWDNKbFlXUmxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamsyQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdaWGhwYzNSeklEOGdkbVZ5YzJsdmJrSjVkR1Z6TG5SdlUzUnlhVzVuS0NrZ09pQWlJanNLSUNBZ0lHSjZJR2RsZEZabGNuTnBiMjVmZEdWeWJtRnllVjltWVd4elpVQXlDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb0taMlYwVm1WeWMybHZibDkwWlhKdVlYSjVYMjFsY21kbFFETTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJtWmtYM0psWVdSbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qazJDaUFnSUNBdkx5QnlaWFIxY200Z1pYaHBjM1J6SUQ4Z2RtVnljMmx2YmtKNWRHVnpMblJ2VTNSeWFXNW5LQ2tnT2lBaUlqc0tJQ0FnSUhOM1lYQUtJQ0FnSUhKbGRITjFZZ29LWjJWMFZtVnljMmx2Ymw5MFpYSnVZWEo1WDJaaGJITmxRREk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZibVprWDNKbFlXUmxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamsyQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdaWGhwYzNSeklEOGdkbVZ5YzJsdmJrSjVkR1Z6TG5SdlUzUnlhVzVuS0NrZ09pQWlJanNLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJaUlLSUNBZ0lHSWdaMlYwVm1WeWMybHZibDkwWlhKdVlYSjVYMjFsY21kbFFETUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ym1aa1gzSmxZV1JsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwT1ptUlNaV0ZrWlhJdVoyVjBUV0ZxYjNKV1pYSnphVzl1S0dGd2NFbGtPaUIxYVc1ME5qUXBJQzArSUhWcGJuUTJORG9LWjJWMFRXRnFiM0pXWlhKemFXOXVPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyNW1aRjl5WldGa1pYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzVPUW9nSUNBZ0x5OGdjSEpwZG1GMFpTQm5aWFJOWVdwdmNsWmxjbk5wYjI0b1lYQndTV1E2SUVGd2NHeHBZMkYwYVc5dUtUb2dkV2x1ZERZMElIc0tJQ0FnSUhCeWIzUnZJREVnTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjVtWkY5eVpXRmtaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TURBS0lDQWdJQzh2SUdOdmJuTjBJRnQyWlhKemFXOXVRbmwwWlhNc0lHVjRhWE4wYzEwZ1BTQnZjQzVCY0hCSGJHOWlZV3d1WjJWMFJYaENlWFJsY3loaGNIQkpaQ3dnUW5sMFpYTmdhUzUyWlhKZ0tUc0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWW5sMFpXTWdPU0F2THlBaWFTNTJaWElpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI1bVpGOXlaV0ZrWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1ERUtJQ0FnSUM4dklISmxkSFZ5YmlCbGVHbHpkSE1nUHlCdmNDNWlkRzlwS0habGNuTnBiMjVDZVhSbGN5NWhkQ2d3S1NrZ0xTQTBPQ0E2SURBN0NpQWdJQ0JpZWlCblpYUk5ZV3B2Y2xabGNuTnBiMjVmZEdWeWJtRnllVjltWVd4elpVQXlDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2RsZEdKNWRHVUtJQ0FnSUhCMWMyaHBiblFnTkRnZ0x5OGdORGdLSUNBZ0lDMEtDbWRsZEUxaGFtOXlWbVZ5YzJsdmJsOTBaWEp1WVhKNVgyMWxjbWRsUURNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ym1aa1gzSmxZV1JsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFd01Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUdWNGFYTjBjeUEvSUc5d0xtSjBiMmtvZG1WeWMybHZia0o1ZEdWekxtRjBLREFwS1NBdElEUTRJRG9nTURzS0lDQWdJSE4zWVhBS0lDQWdJSEpsZEhOMVlnb0taMlYwVFdGcWIzSldaWEp6YVc5dVgzUmxjbTVoY25sZlptRnNjMlZBTWpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl1Wm1SZmNtVmhaR1Z5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRBeENpQWdJQ0F2THlCeVpYUjFjbTRnWlhocGMzUnpJRDhnYjNBdVluUnZhU2gyWlhKemFXOXVRbmwwWlhNdVlYUW9NQ2twSUMwZ05EZ2dPaUF3T3dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSWdaMlYwVFdGcWIzSldaWEp6YVc5dVgzUmxjbTVoY25sZmJXVnlaMlZBTXdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXVabVJmY21WaFpHVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPazVtWkZKbFlXUmxjaTVuWlhSRmJYQjBlVTVtWkZScGJua29kbVZ5YzJsdmJqb2dZbmwwWlhNcElDMCtJR0o1ZEdWek9ncG5aWFJGYlhCMGVVNW1aRlJwYm5rNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ym1aa1gzSmxZV1JsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFNE1Bb2dJQ0FnTHk4Z2NISnBkbUYwWlNCblpYUkZiWEIwZVU1bVpGUnBibmtvZG1WeWMybHZiam9nYzNSeWFXNW5LVG9nVG1aa1ZHbHVlU0I3Q2lBZ0lDQndjbTkwYnlBeElERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dVptUmZjbVZoWkdWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UZ3hMVEU0T0FvZ0lDQWdMeThnY21WMGRYSnVJSHNLSUNBZ0lDOHZJQ0FnYm1GdFpUb2dJaUlzQ2lBZ0lDQXZMeUFnSUc5M2JtVnlPaUJIYkc5aVlXd3VlbVZ5YjBGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUdOaFFXeG5iem9nVzEwc0NpQWdJQ0F2THlBZ0lIVnVkbVZ5YVdacFpXUkRZVUZzWjI4NklGdGRMQW9nSUNBZ0x5OGdJQ0IyWlhKemFXOXVMQW9nSUNBZ0x5OGdJQ0JsZUhCcGNtVmtPaUJtWVd4elpTd0tJQ0FnSUM4dklIMGdjMkYwYVhObWFXVnpJRTVtWkZScGJuazdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUd4bGJnb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0J3ZFhOb1lubDBaWE1nWW1GelpUTXlLRUZCVlZGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUmsxQlF6SkJRbEJCUVVGQlFVRkJRVUZCUVVFcENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dVptUmZjbVZoWkdWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rNW1aRkpsWVdSbGNpNXlaV0ZrUm1sbGJHUW9ZWEJ3U1dRNklIVnBiblEyTkN3Z1ptbGxiR1JPWVcxbE9pQmllWFJsY3l3Z2JXRnFiM0pXWlhKemFXOXVPaUIxYVc1ME5qUXBJQzArSUdKNWRHVnpPZ3B5WldGa1JtbGxiR1E2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZibVprWDNKbFlXUmxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakU1T1FvZ0lDQWdMeThnY0hKcGRtRjBaU0J5WldGa1JtbGxiR1FvWVhCd1NXUTZJRUZ3Y0d4cFkyRjBhVzl1TENCbWFXVnNaRTVoYldVNklHSjVkR1Z6TENCdFlXcHZjbFpsY25OcGIyNDZJSFZwYm5RMk5DazZJR0o1ZEdWeklIc0tJQ0FnSUhCeWIzUnZJRE1nTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjVtWkY5eVpXRmtaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TURBS0lDQWdJQzh2SUdsbUlDaHRZV3B2Y2xabGNuTnBiMjRnUFQwOUlESXBJSEpsZEhWeWJpQjBhR2x6TG5KbFlXUkdhV1ZzWkhZeUtHRndjRWxrTENCbWFXVnNaRTVoYldVcE93b2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JwYm5Salh6RWdMeThnTWdvZ0lDQWdQVDBLSUNBZ0lHSjZJSEpsWVdSR2FXVnNaRjloWm5SbGNsOXBabDlsYkhObFFESUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dVptUmZjbVZoWkdWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qQTJMVEl4TVFvZ0lDQWdMeThnY21WMGRYSnVJR2wwZUc0S0lDQWdJQzh2SUNBZ0xtRndjR3hwWTJGMGFXOXVRMkZzYkNoN0NpQWdJQ0F2THlBZ0lDQWdZWEJ3U1dRNklHRndjRWxrTEFvZ0lDQWdMeThnSUNBZ0lHRndjRUZ5WjNNNklGdENlWFJsYzJCeVpXRmtYM0J5YjNCbGNuUjVZQ3dnWm1sbGJHUk9ZVzFsWFN3S0lDQWdJQzh2SUNBZ2ZTa0tJQ0FnSUM4dklDQWdMbk4xWW0xcGRDZ3BMbXhoYzNSTWIyYzdDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ym1aa1gzSmxZV1JsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJd09Rb2dJQ0FnTHk4Z1lYQndRWEpuY3pvZ1cwSjVkR1Z6WUhKbFlXUmZjSEp2Y0dWeWRIbGdMQ0JtYVdWc1pFNWhiV1ZkTEFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0p5WldGa1gzQnliM0JsY25SNUlnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ym1aa1gzSmxZV1JsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJd05pMHlNVEFLSUNBZ0lDOHZJSEpsZEhWeWJpQnBkSGh1Q2lBZ0lDQXZMeUFnSUM1aGNIQnNhV05oZEdsdmJrTmhiR3dvZXdvZ0lDQWdMeThnSUNBZ0lHRndjRWxrT2lCaGNIQkpaQ3dLSUNBZ0lDOHZJQ0FnSUNCaGNIQkJjbWR6T2lCYlFubDBaWE5nY21WaFpGOXdjbTl3WlhKMGVXQXNJR1pwWld4a1RtRnRaVjBzQ2lBZ0lDQXZMeUFnSUgwcENpQWdJQ0J3ZFhOb2FXNTBJRFlnTHk4Z05nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZibVprWDNKbFlXUmxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl3TmkweU1URUtJQ0FnSUM4dklISmxkSFZ5YmlCcGRIaHVDaUFnSUNBdkx5QWdJQzVoY0hCc2FXTmhkR2x2YmtOaGJHd29ld29nSUNBZ0x5OGdJQ0FnSUdGd2NFbGtPaUJoY0hCSlpDd0tJQ0FnSUM4dklDQWdJQ0JoY0hCQmNtZHpPaUJiUW5sMFpYTmdjbVZoWkY5d2NtOXdaWEowZVdBc0lHWnBaV3hrVG1GdFpWMHNDaUFnSUNBdkx5QWdJSDBwQ2lBZ0lDQXZMeUFnSUM1emRXSnRhWFFvS1M1c1lYTjBURzluT3dvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lHbDBlRzRnVEdGemRFeHZad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyNW1aRjl5WldGa1pYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNREFLSUNBZ0lDOHZJR2xtSUNodFlXcHZjbFpsY25OcGIyNGdQVDA5SURJcElISmxkSFZ5YmlCMGFHbHpMbkpsWVdSR2FXVnNaSFl5S0dGd2NFbGtMQ0JtYVdWc1pFNWhiV1VwT3dvZ0lDQWdjbVYwYzNWaUNncHlaV0ZrUm1sbGJHUmZZV1owWlhKZmFXWmZaV3h6WlVBeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI1bVpGOXlaV0ZrWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU1ERUtJQ0FnSUM4dklHbG1JQ2h0WVdwdmNsWmxjbk5wYjI0Z1BUMDlJRE1wSUhKbGRIVnliaUIwYUdsekxuSmxZV1JHYVdWc1pIWXpLR0Z3Y0Vsa0xDQm1hV1ZzWkU1aGJXVXBPd29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCd2RYTm9hVzUwSURNZ0x5OGdNd29nSUNBZ1BUMEtJQ0FnSUdKNklISmxZV1JHYVdWc1pGOWhablJsY2w5cFpsOWxiSE5sUURRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl1Wm1SZmNtVmhaR1Z5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpFMUxUSXhPQW9nSUNBZ0x5OGdjbVYwZFhKdUlHTnZiWEJwYkdWQmNtTTBLRTVtWkVsdWMzUmhibU5sVm5Sb2NtVmxLUzVqWVd4c0xuSmxZV1JHYVdWc1pDaDdDaUFnSUNBdkx5QWdJR0Z3Y0Vsa0xBb2dJQ0FnTHk4Z0lDQmhjbWR6T2lCYlptbGxiR1JPWVcxbFhTd0tJQ0FnSUM4dklIMHBMbkpsZEhWeWJsWmhiSFZsT3dvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyNW1aRjl5WldGa1pYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNVGNLSUNBZ0lDOHZJR0Z5WjNNNklGdG1hV1ZzWkU1aGJXVmRMQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI1bVpGOXlaV0ZrWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU1UVXRNakU0Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdZMjl0Y0dsc1pVRnlZelFvVG1aa1NXNXpkR0Z1WTJWV2RHaHlaV1VwTG1OaGJHd3VjbVZoWkVacFpXeGtLSHNLSUNBZ0lDOHZJQ0FnWVhCd1NXUXNDaUFnSUNBdkx5QWdJR0Z5WjNNNklGdG1hV1ZzWkU1aGJXVmRMQW9nSUNBZ0x5OGdmU2t1Y21WMGRYSnVWbUZzZFdVN0NpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnMll6RXpaV1JsTkNBdkx5QnRaWFJvYjJRZ0luSmxZV1JHYVdWc1pDaGllWFJsVzEwcFlubDBaVnRkSWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQlBia052YlhCc1pYUnBiMjRLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQndkWE5vYVc1MElEWWdMeThnWVhCd2JBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ2FYUjRiaUJNWVhOMFRHOW5DaUFnSUNCa2RYQUtJQ0FnSUdWNGRISmhZM1FnTkNBd0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnWlhoMGNtRmpkQ0F3SURRS0lDQWdJR0o1ZEdWaklEWWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkNlWFJsY3lCb1lYTWdkbUZzYVdRZ2NISmxabWw0Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6RWdMeThnTWdvZ0lDQWdLd29nSUNBZ2MzZGhjQW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUdWNGRISmhZM1FnTmlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ym1aa1gzSmxZV1JsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJd01Rb2dJQ0FnTHk4Z2FXWWdLRzFoYW05eVZtVnljMmx2YmlBOVBUMGdNeWtnY21WMGRYSnVJSFJvYVhNdWNtVmhaRVpwWld4a2RqTW9ZWEJ3U1dRc0lHWnBaV3hrVG1GdFpTazdDaUFnSUNCeVpYUnpkV0lLQ25KbFlXUkdhV1ZzWkY5aFpuUmxjbDlwWmw5bGJITmxRRFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZibVprWDNKbFlXUmxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl3TWdvZ0lDQWdMeThnY21WMGRYSnVJRUo1ZEdWellHQTdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSWlDaUFnSUNCeVpYUnpkV0lLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQUFJQkNDWUtBQUV3QWdBQUJta3VibUZ0WlFJQUtRRUFCQlVmZkhVTmRpNWpZVUZzWjI4dU1DNWhjd2gxTG1OaFlXeG5id1ZwTG5abGNqRVpGRVNDQkFTZ29zaXFCQTM5UGlzRXlRdmlHQVNYdHErdk5ob0FqZ1FBWXdDb0Fha0RGZ0NLQVFFb0tpS0wveFZKakFDQklBcUxBZzFCQUVpTEFrbUJJQXRKaXdCSlRnTVBTd0pNVFU4Q0pBaEpqQUtCSUF0SlN3TVBURThEVHdKTlNVc0NERXNDVEUyTC8wNENVb3NCU1U4Q1VFd2lXU1FJRmxjR0Fsd0FqQUZDLzZtTEFZd0FpVFlhQVVjQ0lsbEpUZ0lsQ3lNSVRCVVNSQ0pKU3dJTVFRQWdTd0pYQWdCTEFVbE9BaVVMVzRnRU9Va1ZGbGNHQWt4UXNDUUlSUUZDLzltQUJoVWZmSFVBQUxBa1F5SkpLRFlhQVVjQ0lsbEpUZ0lsQ3lNSVRCVVNSQ0pKU3dJTVFRQ3JTd0pYQWdCTEFTVUxXMGxGQlN0bFRFVUdRUUJnU3dPQUIya3VZWE5oYVdSbFRFVUhRUUJLU3dVWFN3UkppQU8wVElnRHpVc0hTUlVXVndZQ1RGQkpGWUVzQ0U4RUZvQUNBQ3hNVUU4RVVFc0RGUlpYQmdKUEJGQlBBaFpYQmdKUEFreFFUd0pRVEZDd1NTUUlSUUZDLzRnaVF2KzFnREFBTEFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFMZ0FBQUFDd1F2KytnRFFWSDN4MUFDd0FBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUM0QUFBQUFzQ1JESWtrb1J3TTJHZ0ZIQWlKWlNVNENKUXNqQ0V3VkVrUWlTVXNDREVFQlEwc0NWd0lBU3dFbEMxdEpSUVlyWlV4RkNVRUJKa3NFaUFMM1NVVUhnUU1TU1VVRlFRRVBTd1NBRUdrdVpYaHdhWEpoZEdsdmJsUnBiV1ZsVEVVS1FRRHdTd2dYTWdjT1JRZExBMEVBaFVzR1FBQ0FTd1JKaUFLSVN3RW5CMHNKU1U0RWlBTUZpUDNSU3dNbkNFOEVpQUw1aVAzRlR3T0lBb1ZMQzBrVkZsY0dBa3hRU1JXQktRZ25CRThHVUVzQkZsY0dBbEJMQlJWUEFnaEpGbGNHQWs4Q1RGQkxCQlZQQWdoTEF4VVdWd1lDVHdSUVRCWlhCZ0pQQWt4UUp3VlFUd0pRVHdOUVR3SlFURkN3U1NRSVJRRkMveVpMQkVtSUFnaE1pQUloU3dsSkZSWlhCZ0pNVUVrVmdTa0lKd1JQQkZCTEFSWlhCZ0pRVENNSVNSWlhCZ0pQQWt4UVRDTUlTd01WRmxjR0FrOEVVRXdXVndZQ1R3Sk1VQ2NGSWtzTFZGQlBBbENBQkFBQUFBQlFURkN3UXYrYUlrTC9FaUpGQjBML0RpbUlBZXF3UXYrSUtZZ0I0aWNHVEZDd0pFTWlSd01vUndNMkdnRkhBaFZMQVNKWlNVNERTWUVFRWtSTEFreExBbElpV1NVTGdRWUlTd0lqV1VsT0JFbExBaEpFVHdOTVN3TlNTVTREU1JWTEFTSlpTVTRGU1lFRUVrUkxBa3hMQWxJaVdZRUhDQ1VLZ1FZSVN3SWpXVWxPQmtsTEFoSkVUd05NVHdOU1NVNEVJbGxKVGdTQkJ3Z2xDaU1JQ0FnU1JDSkxDRXNJU3doU1NVVVNJbGxMQVExQkFQaExFRmNDQUVzQlNVNENKUXRiU1U0Q1JROUxCMHNIU3dkU1NTSlpTd0lOUkVzQmdSQUlURXNCVTBVT1RFc0VERVJMQkV4VFJRMHJaVXhGRVVFQXNrc01pQUR3U1VVTEl4TkJBQXVBQjBWU1VqcE9Wakt3QUVzTWlBQ29SUTVMQ2tFQWlFc01Kd2RMQzRnQklZajc3VVVQU3d0QkFIRkxEQ2NJU3d1SUFRNkkrOXBMRFlnQW1rc1JTUlVXVndZQ1RGQkpGWUVwQ0NjRVN4SlFTd0VXVndZQ1VFc1RTVTRERlU4Q0NFa1dWd1lDVHdKTVVFOEZTVTRERlU4Q0NFc0ZGUlpYQmdKUEJsQk1GbGNHQWs4Q1RGQW5CVkJQQkZCUEExQlBBbEJNVUxCSkpBaEZBVUwvQ0NwQy81Y3FSUTlDLzRBcGlBQlhzRUwvNWltSUFFOG5Ca3hRc0NSRGlnRUJpLytBQ1drdWIzZHVaWEl1WVdWQkFBU0xBRXlKTWdOQy8vbUtBUUdML3ljSlpVRUFCSXNBVElrb1F2LzZpZ0VCaS84bkNXVkJBQW1MQUNKVmdUQUpUSWtpUXYvNmlnRUJpLzhWRmxjR0Fvdi9VSUF2QUNrQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFyQUMwQUx3QUFBQUFBQUFCTVVJbUtBd0dML3lNU1FRQWxzWUFOY21WaFpGOXdjbTl3WlhKMGViSWFpLzZ5R292OXNoaUJCcklRSXJJQnM3UStpWXYvZ1FNU1FRQkFzWXYrRlJaWEJnS0wvbENBQkd3VDdlU3lHcklhSXJJWmkvMnlHSUVHc2hBaXNnR3p0RDVKVndRQVN3RlhBQVFuQmhKRVNTSlpJd2hNRlJKRVZ3WUFpU2lKIiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6MywicGF0Y2giOjIsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
