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

namespace Arc56.Generated.akita_protocol.akita_sc.MerkleAssetGate_1b3dd45d
{


    public class MerkleAssetGateProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public MerkleAssetGateProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class MerkleAssetGateCheckParams : AVMObjectType
            {
                public ulong Asset { get; set; }

                public byte[][] Proof { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAsset = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAsset.From(Asset);
                    ret.AddRange(vAsset.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProof = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32][]");
                    vProof.From(Proof);
                    ret.AddRange(vProof.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static MerkleAssetGateCheckParams Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new MerkleAssetGateCheckParams();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAsset = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAsset.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAsset = vAsset.ToValue();
                    if (valueAsset is ulong vAssetValue) { ret.Asset = vAssetValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProof = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32][]");
                    count = vProof.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueProof = vProof.ToValue();
                    if (valueProof is byte[][] vProofValue) { ret.Proof = vProofValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as MerkleAssetGateCheckParams);
                }
                public bool Equals(MerkleAssetGateCheckParams? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(MerkleAssetGateCheckParams left, MerkleAssetGateCheckParams right)
                {
                    return EqualityComparer<MerkleAssetGateCheckParams>.Default.Equals(left, right);
                }
                public static bool operator !=(MerkleAssetGateCheckParams left, MerkleAssetGateCheckParams right)
                {
                    return !(left == right);
                }

            }

            public class MerkleAssetGateRegistryInfo : AVMObjectType
            {
                public Algorand.Address Creator { get; set; }

                public string Name { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreator = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vCreator.From(Creator);
                    ret.AddRange(vCreator.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vName.From(Name);
                    stringRef[ret.Count] = vName.Encode();
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

                public static MerkleAssetGateRegistryInfo Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new MerkleAssetGateRegistryInfo();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreator = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vCreator.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCreator = vCreator.ToValue();
                    if (valueCreator is Algorand.Address vCreatorValue) { ret.Creator = vCreatorValue; }
                    var indexName = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vName.Decode(bytes.Skip(indexName + prefixOffset).ToArray());
                    var valueName = vName.ToValue();
                    if (valueName is string vNameValue) { ret.Name = vNameValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as MerkleAssetGateRegistryInfo);
                }
                public bool Equals(MerkleAssetGateRegistryInfo? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(MerkleAssetGateRegistryInfo left, MerkleAssetGateRegistryInfo right)
                {
                    return EqualityComparer<MerkleAssetGateRegistryInfo>.Default.Equals(left, right);
                }
                public static bool operator !=(MerkleAssetGateRegistryInfo left, MerkleAssetGateRegistryInfo right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="version"> </param>
        /// <param name="akitaDAO"> </param>
        public async Task Create(string version, ulong akitaDAO, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 205, 154, 214, 126 };
            var versionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); versionAbi.From(version);
            var akitaDAOAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); akitaDAOAbi.From(akitaDAO);

            var result = await base.CallApp(new List<object> { abiHandle, versionAbi, akitaDAOAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(string version, ulong akitaDAO, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 205, 154, 214, 126 };
            var versionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); versionAbi.From(version);
            var akitaDAOAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); akitaDAOAbi.From(akitaDAO);

            return await base.MakeTransactionList(new List<object> { abiHandle, versionAbi, akitaDAOAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="args"> </param>
        public async Task<ulong> Cost(byte[] args, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 50, 159, 4, 238 };
            var argsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); argsAbi.From(args);

            var result = await base.CallApp(new List<object> { abiHandle, argsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Cost_Transactions(byte[] args, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 50, 159, 4, 238 };
            var argsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); argsAbi.From(args);

            return await base.MakeTransactionList(new List<object> { abiHandle, argsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="mbrPayment"> </param>
        /// <param name="args"> </param>
        public async Task<ulong> Register(PaymentTransaction mbrPayment, byte[] args, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrPayment });
            byte[] abiHandle = { 119, 187, 121, 185 };
            var argsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); argsAbi.From(args);

            var result = await base.CallApp(new List<object> { abiHandle, mbrPayment, argsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Register_Transactions(PaymentTransaction mbrPayment, byte[] args, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrPayment });
            byte[] abiHandle = { 119, 187, 121, 185 };
            var argsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); argsAbi.From(args);

            return await base.MakeTransactionList(new List<object> { abiHandle, mbrPayment, argsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="caller"> </param>
        /// <param name="registryID"> </param>
        /// <param name="args"> </param>
        public async Task<bool> Check(Algorand.Address caller, ulong registryID, byte[] args, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 110, 3, 245, 10 };
            var callerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); callerAbi.From(caller);
            var registryIDAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); registryIDAbi.From(registryID);
            var argsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); argsAbi.From(args);

            var result = await base.CallApp(new List<object> { abiHandle, callerAbi, registryIDAbi, argsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Check_Transactions(Algorand.Address caller, ulong registryID, byte[] args, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 110, 3, 245, 10 };
            var callerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); callerAbi.From(caller);
            var registryIDAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); registryIDAbi.From(registryID);
            var argsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); argsAbi.From(args);

            return await base.MakeTransactionList(new List<object> { abiHandle, callerAbi, registryIDAbi, argsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="shape"> MerkleAssetGateRegistryInfo</param>
        public async Task<Structs.MerkleAssetGateRegistryInfo> GetRegistrationShape(Structs.MerkleAssetGateRegistryInfo shape, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 187, 184, 162, 172 };

            var result = await base.CallApp(new List<object> { abiHandle, shape }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.MerkleAssetGateRegistryInfo.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetRegistrationShape_Transactions(Structs.MerkleAssetGateRegistryInfo shape, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 187, 184, 162, 172 };

            return await base.MakeTransactionList(new List<object> { abiHandle, shape }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="shape"> MerkleAssetGateCheckParams</param>
        public async Task<Structs.MerkleAssetGateCheckParams> GetCheckShape(Structs.MerkleAssetGateCheckParams shape, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 132, 27, 89, 113 };

            var result = await base.CallApp(new List<object> { abiHandle, shape }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.MerkleAssetGateCheckParams.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetCheckShape_Transactions(Structs.MerkleAssetGateCheckParams shape, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 132, 27, 89, 113 };

            return await base.MakeTransactionList(new List<object> { abiHandle, shape }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="registryID"> </param>
        public async Task<byte[]> GetEntry(ulong registryID, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 144, 212, 250, 93 };
            var registryIDAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); registryIDAbi.From(registryID);

            var result = await base.SimApp(new List<object> { abiHandle, registryIDAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> GetEntry_Transactions(ulong registryID, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 144, 212, 250, 93 };
            var registryIDAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); registryIDAbi.From(registryID);

            return await base.MakeTransactionList(new List<object> { abiHandle, registryIDAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="akitaDAO"> </param>
        public async Task UpdateAkitaDao(ulong akitaDAO, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 51, 233, 44, 148 };
            var akitaDAOAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); akitaDAOAbi.From(akitaDAO);

            var result = await base.CallApp(new List<object> { abiHandle, akitaDAOAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateAkitaDao_Transactions(ulong akitaDAO, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 51, 233, 44, 148 };
            var akitaDAOAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); akitaDAOAbi.From(akitaDAO);

            return await base.MakeTransactionList(new List<object> { abiHandle, akitaDAOAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task OpUp(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 133, 77, 237, 224 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> OpUp_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 133, 77, 237, 224 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTWVya2xlQXNzZXRHYXRlIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7Ik1lcmtsZUFzc2V0R2F0ZUNoZWNrUGFyYW1zIjpbeyJuYW1lIjoiYXNzZXQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoicHJvb2YiLCJ0eXBlIjoiYnl0ZVszMl1bXSJ9XSwiTWVya2xlQXNzZXRHYXRlUmVnaXN0cnlJbmZvIjpbeyJuYW1lIjoiY3JlYXRvciIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoibmFtZSIsInR5cGUiOiJzdHJpbmcifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZlcnNpb24iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFraXRhREFPIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNvc3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXJncyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlZ2lzdGVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1iclBheW1lbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFyZ3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjaGVjayIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FsbGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWdpc3RyeUlEIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcmdzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFJlZ2lzdHJhdGlvblNoYXBlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6IihhZGRyZXNzLHN0cmluZykiLCJzdHJ1Y3QiOiJNZXJrbGVBc3NldEdhdGVSZWdpc3RyeUluZm8iLCJuYW1lIjoic2hhcGUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKGFkZHJlc3Msc3RyaW5nKSIsInN0cnVjdCI6Ik1lcmtsZUFzc2V0R2F0ZVJlZ2lzdHJ5SW5mbyIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldENoZWNrU2hhcGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKHVpbnQ2NCxieXRlWzMyXVtdKSIsInN0cnVjdCI6Ik1lcmtsZUFzc2V0R2F0ZUNoZWNrUGFyYW1zIiwibmFtZSI6InNoYXBlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsYnl0ZVszMl1bXSkiLCJzdHJ1Y3QiOiJNZXJrbGVBc3NldEdhdGVDaGVja1BhcmFtcyIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldEVudHJ5IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlZ2lzdHJ5SUQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InVwZGF0ZUFraXRhREFPIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFraXRhREFPIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im9wVXAiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjIsImJ5dGVzIjozfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls2NzNdLCJlcnJvck1lc3NhZ2UiOiJCb3ggbXVzdCBoYXZlIHZhbHVlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTgxXSwiZXJyb3JNZXNzYWdlIjoiQnl0ZXMgaGFzIHZhbGlkIHByZWZpeCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMzOSw0NDIsNzU1XSwiZXJyb3JNZXNzYWdlIjoiRVJSOmVycklhcmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNTMsMzY5XSwiZXJyb3JNZXNzYWdlIjoiRVJSOmVycklwYXkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3MzRdLCJlcnJvck1lc3NhZ2UiOiJFUlI6ZXJyTmRhbyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzcxNV0sImVycm9yTWVzc2FnZSI6ImFwcGxpY2F0aW9uIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM3Myw1MjQsNzAyXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgR2xvYmFsU3RhdGUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDk2XSwiZXJyb3JNZXNzYWdlIjoiaW5kZXggb3V0IG9mIGJvdW5kcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI0MCwyODIsMzE4LDQyMCw2MTQsNjQ3XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjQ3LDI4OSwzMjUsNDI3XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQwNF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNTgsNDEyLDY2OSw2OTVdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1ODZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYm9vbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY1NV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBzbWFydF9jb250cmFjdHMvZ2F0ZXMvc3ViLWdhdGVzL21lcmtsZS1hc3NldC9jb250cmFjdC5hbGdvLnRzOjpNZXJrbGVBc3NldEdhdGVDaGVja1BhcmFtcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYxOV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBzbWFydF9jb250cmFjdHMvZ2F0ZXMvc3ViLWdhdGVzL21lcmtsZS1hc3NldC9jb250cmFjdC5hbGdvLnRzOjpNZXJrbGVBc3NldEdhdGVSZWdpc3RyeUluZm8iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MzldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHRhaWwgcG9pbnRlciBhdCBpbmRleCAxIG9mICh1aW50NjQsKGxlbit1aW50OFszMl1bXSkpIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjA2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCB0YWlsIHBvaW50ZXIgYXQgaW5kZXggMSBvZiAodWludDhbMzJdLChsZW4rdXRmOFtdKSkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MDEsNjM0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCB0dXBsZSBlbmNvZGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMxMl0sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgcGF5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNU0F3SURJZ09Bb2dJQ0FnWW5sMFpXTmliRzlqYXlBd2VERTFNV1kzWXpjMUlDSmhhMmwwWVY5a1lXOGlJQ0p5WldkcGMzUnllVjlqZFhKemIzSWlJQ0pGVWxJNlpYSnlTV0Z5WnlJZ0lrVlNVanBsY25KSmNHRjVJZ29nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0p1ZWlCdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl0WlhKcmJHVXRZWE56WlhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek13b2dJQ0FnTHk4Z2NtVm5hWE4wY25sRGRYSnpiM0lnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tIc2dhVzVwZEdsaGJGWmhiSFZsT2lBeExDQnJaWGs2SUVkaGRHVkhiRzlpWVd4VGRHRjBaVXRsZVZKbFoybHpkSEo1UTNWeWMyOXlJSDBwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0p5WldkcGMzUnllVjlqZFhKemIzSWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12YldWeWEyeGxMV0Z6YzJWMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16VUtJQ0FnSUM4dklISmxaMmx6ZEhKaGRHbHZibE5vWVhCbElEMGdSMnh2WW1Gc1UzUmhkR1U4YzNSeWFXNW5QaWg3SUdsdWFYUnBZV3hXWVd4MVpUb2dKeWhoWkdSeVpYTnpMSE4wY21sdVp5a25MQ0JyWlhrNklFZGhkR1ZIYkc5aVlXeFRkR0YwWlV0bGVWSmxaMmx6ZEhKaGRHbHZibE5vWVhCbElIMHBDaUFnSUNCd2RYTm9ZbmwwWlhOeklDSnlaV2RwYzNSeVlYUnBiMjVmYzJoaGNHVWlJQ0lvWVdSa2NtVnpjeXh6ZEhKcGJtY3BJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmJXVnlhMnhsTFdGemMyVjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNemNLSUNBZ0lDOHZJR05vWldOclUyaGhjR1VnUFNCSGJHOWlZV3hUZEdGMFpUeHpkSEpwYm1jK0tIc2dhVzVwZEdsaGJGWmhiSFZsT2lBbktIVnBiblEyTkN4aWVYUmxXek15WFZ0ZEtTY3NJR3RsZVRvZ1IyRjBaVWRzYjJKaGJGTjBZWFJsUzJWNVEyaGxZMnRUYUdGd1pTQjlLUW9nSUNBZ2NIVnphR0o1ZEdWemN5QWlZMmhsWTJ0ZmMyaGhjR1VpSUNJb2RXbHVkRFkwTEdKNWRHVmJNekpkVzEwcElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtDbTFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXRaWEpyYkdVdFlYTnpaWFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95T1FvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFMWxjbXRzWlVGemMyVjBSMkYwWlNCbGVIUmxibVJ6SUVGcmFYUmhRbUZ6WlVOdmJuUnlZV04wSUhzS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSjZJRzFoYVc1ZlkzSmxZWFJsWDA1dlQzQkFNVFFLSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGd6TWpsbU1EUmxaU0F3ZURjM1ltSTNPV0k1SURCNE5tVXdNMlkxTUdFZ01IaGlZbUk0WVRKaFl5QXdlRGcwTVdJMU9UY3hJREI0T1RCa05HWmhOV1FnTUhnek0yVTVNbU01TkNBd2VEZzFOR1JsWkdVd0lDOHZJRzFsZEdodlpDQWlZMjl6ZENoaWVYUmxXMTBwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0p5WldkcGMzUmxjaWh3WVhrc1lubDBaVnRkS1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpWTJobFkyc29ZV1JrY21WemN5eDFhVzUwTmpRc1lubDBaVnRkS1dKdmIyd2lMQ0J0WlhSb2IyUWdJbWRsZEZKbFoybHpkSEpoZEdsdmJsTm9ZWEJsS0NoaFpHUnlaWE56TEhOMGNtbHVaeWtwS0dGa1pISmxjM01zYzNSeWFXNW5LU0lzSUcxbGRHaHZaQ0FpWjJWMFEyaGxZMnRUYUdGd1pTZ29kV2x1ZERZMExHSjVkR1ZiTXpKZFcxMHBLU2gxYVc1ME5qUXNZbmwwWlZzek1sMWJYU2tpTENCdFpYUm9iMlFnSW1kbGRFVnVkSEo1S0hWcGJuUTJOQ2xpZVhSbFcxMGlMQ0J0WlhSb2IyUWdJblZ3WkdGMFpVRnJhWFJoUkVGUEtIVnBiblEyTkNsMmIybGtJaXdnYldWMGFHOWtJQ0p2Y0ZWd0tDbDJiMmxrSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ1kyOXpkQ0J5WldkcGMzUmxjaUJqYUdWamF5Qm5aWFJTWldkcGMzUnlZWFJwYjI1VGFHRndaU0JuWlhSRGFHVmphMU5vWVhCbElHZGxkRVZ1ZEhKNUlIVndaR0YwWlVGcmFYUmhSRUZQSUcxaGFXNWZiM0JWY0Y5eWIzVjBaVUF4TWdvZ0lDQWdaWEp5Q2dwdFlXbHVYMjl3VlhCZmNtOTFkR1ZBTVRJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZZbUZ6WlMxamIyNTBjbUZqZEhNdmRYQm5jbUZrWldGaWJHVXVkSE02TXpBS0lDQWdJQzh2SUc5d1ZYQW9LVG9nZG05cFpDQjdJSDBLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZM0psWVhSbFgwNXZUM0JBTVRRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMMjFsY210c1pTMWhjM05sZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJNUNpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdUV1Z5YTJ4bFFYTnpaWFJIWVhSbElHVjRkR1Z1WkhNZ1FXdHBkR0ZDWVhObFEyOXVkSEpoWTNRZ2V3b2dJQ0FnY0hWemFHSjVkR1Z6SURCNFkyUTVZV1EyTjJVZ0x5OGdiV1YwYUc5a0lDSmpjbVZoZEdVb2MzUnlhVzVuTEhWcGJuUTJOQ2wyYjJsa0lnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2dZM0psWVhSbENpQWdJQ0JsY25JS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwyMWxjbXRzWlMxaGMzTmxkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBOWlhKcmJHVkJjM05sZEVkaGRHVXVZM0psWVhSbFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZM0psWVhSbE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl0WlhKcmJHVXRZWE56WlhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU13b2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJRzl1UTNKbFlYUmxPaUFuY21WeGRXbHlaU2NnZlNrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlltRnpaUzFqYjI1MGNtRmpkSE12ZFhCbmNtRmtaV0ZpYkdVdWRITTZNVFFLSUNBZ0lDOHZJSFpsY25OcGIyNGdQU0JIYkc5aVlXeFRkR0YwWlR4emRISnBibWMrS0hzZ2EyVjVPaUJIYkc5aVlXeFRkR0YwWlV0bGVWWmxjbk5wYjI0Z2ZTa0tJQ0FnSUhCMWMyaGllWFJsY3lBaWRtVnljMmx2YmlJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZiV1Z5YTJ4bExXRnpjMlYwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRVS0lDQWdJQzh2SUhSb2FYTXVkbVZ5YzJsdmJpNTJZV3gxWlNBOUlIWmxjbk5wYjI0S0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5aVlYTmxMV052Ym5SeVlXTjBjeTkxY0dkeVlXUmxZV0pzWlM1MGN6b3hOZ29nSUNBZ0x5OGdZV3RwZEdGRVFVOGdQU0JIYkc5aVlXeFRkR0YwWlR4QmNIQnNhV05oZEdsdmJqNG9leUJyWlhrNklFZHNiMkpoYkZOMFlYUmxTMlY1UVd0cGRHRkVRVThnZlNrS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1GcmFYUmhYMlJoYnlJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZiV1Z5YTJ4bExXRnpjMlYwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRZS0lDQWdJQzh2SUhSb2FYTXVZV3RwZEdGRVFVOHVkbUZzZFdVZ1BTQkJjSEJzYVdOaGRHbHZiaWhoYTJsMFlVUkJUeWtLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwyMWxjbXRzWlMxaGMzTmxkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalV6Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ2IyNURjbVZoZEdVNklDZHlaWEYxYVhKbEp5QjlLUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12YldWeWEyeGxMV0Z6YzJWMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rMWxjbXRzWlVGemMyVjBSMkYwWlM1amIzTjBXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWTI5emREb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12YldWeWEyeGxMV0Z6YzJWMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5qRUtJQ0FnSUM4dklHTnZjM1FvWVhKbmN6b2dZbmwwWlhNcE9pQjFhVzUwTmpRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lHTmhiR3h6ZFdJZ2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl0WlhKcmJHVXRZWE56WlhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlRXVnlhMnhsUVhOelpYUkhZWFJsTG1OdmMzUUtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMMjFsY210c1pTMWhjM05sZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwTlpYSnJiR1ZCYzNObGRFZGhkR1V1Y21WbmFYTjBaWEpiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dweVpXZHBjM1JsY2pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZiV1Z5YTJ4bExXRnpjMlYwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpZS0lDQWdJQzh2SUhKbFoybHpkR1Z5S0cxaWNsQmhlVzFsYm5RNklHZDBlRzR1VUdGNWJXVnVkRlI0Yml3Z1lYSm5jem9nWW5sMFpYTXBPaUIxYVc1ME5qUWdld29nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBdENpQWdJQ0JrZFhBS0lDQWdJR2QwZUc1eklGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnY0dGNUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJSFJ5WVc1ellXTjBhVzl1SUhSNWNHVWdhWE1nY0dGNUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ1pIVndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDIxbGNtdHNaUzFoYzNObGRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWTNDaUFnSUNBdkx5QnNiMmRuWldSQmMzTmxjblFvWVhKbmN5NXNaVzVuZEdnZ1BqMGdUV2x1VW1WbmFYTjBaWEpCY21kelRHVnVaM1JvTENCbGNuSkpiblpoYkdsa1FYSm5RMjkxYm5RcENpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdNelVLSUNBZ0lENDlDaUFnSUNCaWJub2djbVZuYVhOMFpYSmZZV1owWlhKZllYTnpaWEowUURNS0lDQWdJR0o1ZEdWalh6TWdMeThnSWtWU1VqcGxjbkpKWVhKbklnb2dJQ0FnYkc5bkNpQWdJQ0JsY25JZ0x5OGdSVkpTT21WeWNrbGhjbWNLQ25KbFoybHpkR1Z5WDJGbWRHVnlYMkZ6YzJWeWRFQXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5dFpYSnJiR1V0WVhOelpYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJPQW9nSUNBZ0x5OGdiRzluWjJWa1FYTnpaWEowS0cxaWNsQmhlVzFsYm5RdWNtVmpaV2wyWlhJZ1BUMDlJRWRzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekxDQmxjbkpKYm5aaGJHbGtVR0Y1YldWdWRDa0tJQ0FnSUdScFp5QXhDaUFnSUNCbmRIaHVjeUJTWldObGFYWmxjZ29nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lEMDlDaUFnSUNCaWJub2djbVZuYVhOMFpYSmZZV1owWlhKZllYTnpaWEowUURVS0lDQWdJR0o1ZEdWaklEUWdMeThnSWtWU1VqcGxjbkpKY0dGNUlnb2dJQ0FnYkc5bkNpQWdJQ0JsY25JZ0x5OGdSVkpTT21WeWNrbHdZWGtLQ25KbFoybHpkR1Z5WDJGbWRHVnlYMkZ6YzJWeWRFQTFPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5dFpYSnJiR1V0WVhOelpYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJPUW9nSUNBZ0x5OGdiRzluWjJWa1FYTnpaWEowS0cxaWNsQmhlVzFsYm5RdVlXMXZkVzUwSUQwOVBTQjBhR2x6TG1OdmMzUW9ZWEpuY3lrc0lHVnlja2x1ZG1Gc2FXUlFZWGx0Wlc1MEtRb2dJQ0FnYzNkaGNBb2dJQ0FnWjNSNGJuTWdRVzF2ZFc1MENpQWdJQ0JrYVdjZ01Rb2dJQ0FnWTJGc2JITjFZaUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwyMWxjbXRzWlMxaGMzTmxkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBOWlhKcmJHVkJjM05sZEVkaGRHVXVZMjl6ZEFvZ0lDQWdQVDBLSUNBZ0lHSnVlaUJ5WldkcGMzUmxjbDloWm5SbGNsOWhjM05sY25SQU53b2dJQ0FnWW5sMFpXTWdOQ0F2THlBaVJWSlNPbVZ5Y2tsd1lYa2lDaUFnSUNCc2IyY0tJQ0FnSUdWeWNpQXZMeUJGVWxJNlpYSnlTWEJoZVFvS2NtVm5hWE4wWlhKZllXWjBaWEpmWVhOelpYSjBRRGM2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwyMWxjbXRzWlMxaGMzTmxkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalEyQ2lBZ0lDQXZMeUJqYjI1emRDQnBaQ0E5SUhSb2FYTXVjbVZuYVhOMGNubERkWEp6YjNJdWRtRnNkV1VLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDIxbGNtdHNaUzFoYzNObGRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTXpDaUFnSUNBdkx5QnlaV2RwYzNSeWVVTjFjbk52Y2lBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9leUJwYm1sMGFXRnNWbUZzZFdVNklERXNJR3RsZVRvZ1IyRjBaVWRzYjJKaGJGTjBZWFJsUzJWNVVtVm5hWE4wY25sRGRYSnpiM0lnZlNrS0lDQWdJR0o1ZEdWalh6SWdMeThnSW5KbFoybHpkSEo1WDJOMWNuTnZjaUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmJXVnlhMnhsTFdGemMyVjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORFlLSUNBZ0lDOHZJR052Ym5OMElHbGtJRDBnZEdocGN5NXlaV2RwYzNSeWVVTjFjbk52Y2k1MllXeDFaUW9nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12YldWeWEyeGxMV0Z6YzJWMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5EY0tJQ0FnSUM4dklIUm9hWE11Y21WbmFYTjBjbmxEZFhKemIzSXVkbUZzZFdVZ0t6MGdNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXRaWEpyYkdVdFlYTnpaWFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TXdvZ0lDQWdMeThnY21WbmFYTjBjbmxEZFhKemIzSWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0hzZ2FXNXBkR2xoYkZaaGJIVmxPaUF4TENCclpYazZJRWRoZEdWSGJHOWlZV3hUZEdGMFpVdGxlVkpsWjJsemRISjVRM1Z5YzI5eUlIMHBDaUFnSUNCaWVYUmxZMTh5SUM4dklDSnlaV2RwYzNSeWVWOWpkWEp6YjNJaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMMjFsY210c1pTMWhjM05sZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRM0NpQWdJQ0F2THlCMGFHbHpMbkpsWjJsemRISjVRM1Z5YzI5eUxuWmhiSFZsSUNzOUlERUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDIxbGNtdHNaUzFoYzNObGRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qY3lDaUFnSUNBdkx5QjBhR2x6TG5KbFoybHpkSEo1S0dsa0tTNTJZV3gxWlNBOUlHUmxZMjlrWlVGeVl6UThUV1Z5YTJ4bFFYTnpaWFJIWVhSbFVtVm5hWE4wY25sSmJtWnZQaWhoY21kektRb2dJQ0FnYVhSdllnb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUdSMWNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMMjFsY210c1pTMWhjM05sZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZMkNpQWdJQ0F2THlCeVpXZHBjM1JsY2lodFluSlFZWGx0Wlc1ME9pQm5kSGh1TGxCaGVXMWxiblJVZUc0c0lHRnlaM002SUdKNWRHVnpLVG9nZFdsdWREWTBJSHNLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDIxbGNtdHNaUzFoYzNObGRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcE5aWEpyYkdWQmMzTmxkRWRoZEdVdVkyaGxZMnRiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwamFHVmphem9LSUNBZ0lIQjFjMmhpZVhSbGN5QWlJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5dFpYSnJiR1V0WVhOelpYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNOZ29nSUNBZ0x5OGdZMmhsWTJzb1kyRnNiR1Z5T2lCQlkyTnZkVzUwTENCeVpXZHBjM1J5ZVVsRU9pQjFhVzUwTmpRc0lHRnlaM002SUdKNWRHVnpLVG9nWW05dmJHVmhiaUI3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmtkWEJ1SURJS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ1pIVndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDIxbGNtdHNaUzFoYzNObGRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qYzNDaUFnSUNBdkx5QnNiMmRuWldSQmMzTmxjblFvWVhKbmN5NXNaVzVuZEdnZ1BqMGdUV2x1UTJobFkydEJjbWR6VEdWdVozUm9MQ0JsY25KSmJuWmhiR2xrUVhKblEyOTFiblFwQ2lBZ0lDQnNaVzRLSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBeE1nb2dJQ0FnUGowS0lDQWdJR0p1ZWlCamFHVmphMTloWm5SbGNsOWhjM05sY25SQU13b2dJQ0FnWW5sMFpXTmZNeUF2THlBaVJWSlNPbVZ5Y2tsaGNtY2lDaUFnSUNCc2IyY0tJQ0FnSUdWeWNpQXZMeUJGVWxJNlpYSnlTV0Z5WndvS1kyaGxZMnRmWVdaMFpYSmZZWE56WlhKMFFETTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDIxbGNtdHNaUzFoYzNObGRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qYzRDaUFnSUNBdkx5QmpiMjV6ZENCN0lHRnpjMlYwTENCd2NtOXZaaUI5SUQwZ1pHVmpiMlJsUVhKak5EeE5aWEpyYkdWQmMzTmxkRWRoZEdWRGFHVmphMUJoY21GdGN6NG9ZWEpuY3lrS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCa2RYQUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdjM2RoY0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXRaWEpyYkdVdFlYTnpaWFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem80TUFvZ0lDQWdMeThnWTI5dWMzUWdXMmh2YkdScGJtZHpMQ0J2Y0hSbFpFbHVYU0E5SUVGemMyVjBTRzlzWkdsdVp5NWhjM05sZEVKaGJHRnVZMlVvWTJGc2JHVnlMQ0JoYzNObGRDa0tJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdjM2RoY0FvZ0lDQWdZWE56WlhSZmFHOXNaR2x1WjE5blpYUWdRWE56WlhSQ1lXeGhibU5sQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmlkWEo1SURVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZiV1Z5YTJ4bExXRnpjMlYwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T0RFS0lDQWdJQzh2SUdsbUlDZ2hiM0IwWldSSmJpQjhmQ0JvYjJ4a2FXNW5jeUE5UFQwZ01Da2dld29nSUNBZ1lub2dZMmhsWTJ0ZmFXWmZZbTlrZVVBMUNpQWdJQ0JrYVdjZ013b2dJQ0FnWW01NklHTm9aV05yWDJGbWRHVnlYMmxtWDJWc2MyVkFOZ29LWTJobFkydGZhV1pmWW05a2VVQTFPZ29nSUNBZ2NHOXdiaUF6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwyMWxjbXRzWlMxaGMzTmxkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamd5Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdabUZzYzJVS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2dwamFHVmphMTloWm5SbGNsOXBibXhwYm1Wa1gzTnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12YldWeWEyeGxMV0Z6YzJWMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rMWxjbXRzWlVGemMyVjBSMkYwWlM1amFHVmphMEE0T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXRaWEpyYkdVdFlYTnpaWFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zTmdvZ0lDQWdMeThnWTJobFkyc29ZMkZzYkdWeU9pQkJZMk52ZFc1MExDQnlaV2RwYzNSeWVVbEVPaUIxYVc1ME5qUXNJR0Z5WjNNNklHSjVkR1Z6S1RvZ1ltOXZiR1ZoYmlCN0NpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01Bb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVjBZbWwwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwamFHVmphMTloWm5SbGNsOXBabDlsYkhObFFEWTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDIxbGNtdHNaUzFoYzNObGRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qZzFDaUFnSUNBdkx5QmpiMjV6ZENCN0lHTnlaV0YwYjNJc0lHNWhiV1VnZlNBOUlHTnNiMjVsS0hSb2FYTXVjbVZuYVhOMGNua29jbVZuYVhOMGNubEpSQ2t1ZG1Gc2RXVXBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR2wwYjJJS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lIQjFjMmhwYm5RZ016SUtJQ0FnSUdKdmVGOWxlSFJ5WVdOMElDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQmthV2NnTVFvZ0lDQWdjSFZ6YUdsdWRDQXpOQW9nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0JpZEc5cENpQWdJQ0JwYm5Salh6SWdMeThnTWdvZ0lDQWdLd29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J3ZFhOb2FXNTBJRE0wQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMMjFsY210c1pTMWhjM05sZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pnM0xUazJDaUFnSUNBdkx5QnlaWFIxY200Z1lXSnBRMkZzYkR4MGVYQmxiMllnVFdWMFlTNXdjbTkwYjNSNWNHVXVkbVZ5YVdaNVBpaDdDaUFnSUNBdkx5QWdJR0Z3Y0Vsa09pQm5aWFJCYTJsMFlVRndjRXhwYzNRb2RHaHBjeTVoYTJsMFlVUkJUeTUyWVd4MVpTa3ViV1YwWVUxbGNtdHNaWE1zQ2lBZ0lDQXZMeUFnSUdGeVozTTZJRnNLSUNBZ0lDOHZJQ0FnSUNCamNtVmhkRzl5TEFvZ0lDQWdMeThnSUNBZ0lHNWhiV1VzQ2lBZ0lDQXZMeUFnSUNBZ2MyaGhNalUyS0hOb1lUSTFOaWhwZEc5aUtHRnpjMlYwS1NrcExBb2dJQ0FnTHk4Z0lDQWdJSEJ5YjI5bUxBb2dJQ0FnTHk4Z0lDQWdJRTFsY210c1pWUnlaV1ZVZVhCbFEyOXNiR1ZqZEdsdmJpd0tJQ0FnSUM4dklDQWdYU3dLSUNBZ0lDOHZJSDBwTG5KbGRIVnlibFpoYkhWbENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwyMWxjbXRzWlMxaGMzTmxkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamt5Q2lBZ0lDQXZMeUJ6YUdFeU5UWW9jMmhoTWpVMktHbDBiMklvWVhOelpYUXBLU2tzQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdsMGIySUtJQ0FnSUhOb1lUSTFOZ29nSUNBZ2MyaGhNalUyQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwyMWxjbXRzWlMxaGMzTmxkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamswQ2lBZ0lDQXZMeUJOWlhKcmJHVlVjbVZsVkhsd1pVTnZiR3hsWTNScGIyNHNDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl0WlhKcmJHVXRZWE56WlhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNE9Bb2dJQ0FnTHk4Z1lYQndTV1E2SUdkbGRFRnJhWFJoUVhCd1RHbHpkQ2gwYUdsekxtRnJhWFJoUkVGUExuWmhiSFZsS1M1dFpYUmhUV1Z5YTJ4bGN5d0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZZbUZ6WlMxamIyNTBjbUZqZEhNdmRYQm5jbUZrWldGaWJHVXVkSE02TVRZS0lDQWdJQzh2SUdGcmFYUmhSRUZQSUQwZ1IyeHZZbUZzVTNSaGRHVThRWEJ3YkdsallYUnBiMjQrS0hzZ2EyVjVPaUJIYkc5aVlXeFRkR0YwWlV0bGVVRnJhWFJoUkVGUElIMHBDaUFnSUNCaWVYUmxZMTh4SUM4dklDSmhhMmwwWVY5a1lXOGlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDIxbGNtdHNaUzFoYzNObGRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qZzRDaUFnSUNBdkx5QmhjSEJKWkRvZ1oyVjBRV3RwZEdGQmNIQk1hWE4wS0hSb2FYTXVZV3RwZEdGRVFVOHVkbUZzZFdVcExtMWxkR0ZOWlhKcmJHVnpMQW9nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTltZFc1amRHbHZibk11ZEhNNk1qQTJDaUFnSUNBdkx5QmpiMjV6ZENCYllYQndUR2x6ZEVKNWRHVnpYU0E5SUc5d0xrRndjRWRzYjJKaGJDNW5aWFJGZUVKNWRHVnpLR0ZyYVhSaFJFRlBMQ0JDZVhSbGN5aEJhMmwwWVVSQlQwZHNiMkpoYkZOMFlYUmxTMlY1YzBGcmFYUmhRWEJ3VEdsemRDa3BDaUFnSUNCd2RYTm9ZbmwwWlhNZ0ltRmhiQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0J3YjNBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZiV1Z5YTJ4bExXRnpjMlYwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T0RnS0lDQWdJQzh2SUdGd2NFbGtPaUJuWlhSQmEybDBZVUZ3Y0V4cGMzUW9kR2hwY3k1aGEybDBZVVJCVHk1MllXeDFaU2t1YldWMFlVMWxjbXRzWlhNc0NpQWdJQ0J3ZFhOb2FXNTBJRGN5Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMMjFsY210c1pTMWhjM05sZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pnM0xUazJDaUFnSUNBdkx5QnlaWFIxY200Z1lXSnBRMkZzYkR4MGVYQmxiMllnVFdWMFlTNXdjbTkwYjNSNWNHVXVkbVZ5YVdaNVBpaDdDaUFnSUNBdkx5QWdJR0Z3Y0Vsa09pQm5aWFJCYTJsMFlVRndjRXhwYzNRb2RHaHBjeTVoYTJsMFlVUkJUeTUyWVd4MVpTa3ViV1YwWVUxbGNtdHNaWE1zQ2lBZ0lDQXZMeUFnSUdGeVozTTZJRnNLSUNBZ0lDOHZJQ0FnSUNCamNtVmhkRzl5TEFvZ0lDQWdMeThnSUNBZ0lHNWhiV1VzQ2lBZ0lDQXZMeUFnSUNBZ2MyaGhNalUyS0hOb1lUSTFOaWhwZEc5aUtHRnpjMlYwS1NrcExBb2dJQ0FnTHk4Z0lDQWdJSEJ5YjI5bUxBb2dJQ0FnTHk4Z0lDQWdJRTFsY210c1pWUnlaV1ZVZVhCbFEyOXNiR1ZqZEdsdmJpd0tJQ0FnSUM4dklDQWdYU3dLSUNBZ0lDOHZJSDBwTG5KbGRIVnlibFpoYkhWbENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhneVltWXpZMk0xWVNBdkx5QnRaWFJvYjJRZ0luWmxjbWxtZVNoaFpHUnlaWE56TEhOMGNtbHVaeXhpZVhSbFd6TXlYU3hpZVhSbFd6TXlYVnRkTEhWcGJuUTJOQ2xpYjI5c0lnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lITjNZWEFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJSEIxYzJocGJuUWdOaUF2THlCaGNIQnNDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQnBkSGh1SUV4aGMzUk1iMmNLSUNBZ0lHUjFjQW9nSUNBZ1pYaDBjbUZqZENBMElEQUtJQ0FnSUhOM1lYQUtJQ0FnSUdWNGRISmhZM1FnTUNBMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdRbmwwWlhNZ2FHRnpJSFpoYkdsa0lIQnlaV1pwZUFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaWIyOXNDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWjJWMFltbDBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDIxbGNtdHNaUzFoYzNObGRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qYzJDaUFnSUNBdkx5QmphR1ZqYXloallXeHNaWEk2SUVGalkyOTFiblFzSUhKbFoybHpkSEo1U1VRNklIVnBiblEyTkN3Z1lYSm5jem9nWW5sMFpYTXBPaUJpYjI5c1pXRnVJSHNLSUNBZ0lHSWdZMmhsWTJ0ZllXWjBaWEpmYVc1c2FXNWxaRjl6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwyMWxjbXRzWlMxaGMzTmxkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBOWlhKcmJHVkJjM05sZEVkaGRHVXVZMmhsWTJ0QU9Bb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZiV1Z5YTJ4bExXRnpjMlYwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2sxbGNtdHNaVUZ6YzJWMFIyRjBaUzVuWlhSU1pXZHBjM1J5WVhScGIyNVRhR0Z3WlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtZGxkRkpsWjJsemRISmhkR2x2YmxOb1lYQmxPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5dFpYSnJiR1V0WVhOelpYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzVPUW9nSUNBZ0x5OGdaMlYwVW1WbmFYTjBjbUYwYVc5dVUyaGhjR1VvYzJoaGNHVTZJRTFsY210c1pVRnpjMlYwUjJGMFpWSmxaMmx6ZEhKNVNXNW1ieWs2SUUxbGNtdHNaVUZ6YzJWMFIyRjBaVkpsWjJsemRISjVTVzVtYnlCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdaR2xuSURFS0lDQWdJSEIxYzJocGJuUWdNeklLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lIUjFjR3hsSUdWdVkyOWthVzVuQ2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ016UUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0IwWVdsc0lIQnZhVzUwWlhJZ1lYUWdhVzVrWlhnZ01TQnZaaUFvZFdsdWREaGJNekpkTENoc1pXNHJkWFJtT0Z0ZEtTa0tJQ0FnSUdScFp5QXlDaUFnSUNCemQyRndDaUFnSUNCa2FXY2dNZ29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lIQjFjMmhwYm5RZ016WUtJQ0FnSUNzS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmJXVnlhMnhsTFdGemMyVjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPazFsY210c1pVRnpjMlYwUjJGMFpWSmxaMmx6ZEhKNVNXNW1id29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12YldWeWEyeGxMV0Z6YzJWMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rMWxjbXRzWlVGemMyVjBSMkYwWlM1blpYUkRhR1ZqYTFOb1lYQmxXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWjJWMFEyaGxZMnRUYUdGd1pUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12YldWeWEyeGxMV0Z6YzJWMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UQXpDaUFnSUNBdkx5Qm5aWFJEYUdWamExTm9ZWEJsS0hOb1lYQmxPaUJOWlhKcmJHVkJjM05sZEVkaGRHVkRhR1ZqYTFCaGNtRnRjeWs2SUUxbGNtdHNaVUZ6YzJWMFIyRjBaVU5vWldOclVHRnlZVzF6SUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQmthV2NnTVFvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lIUjFjR3hsSUdWdVkyOWthVzVuQ2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ01UQUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0IwWVdsc0lIQnZhVzUwWlhJZ1lYUWdhVzVrWlhnZ01TQnZaaUFvZFdsdWREWTBMQ2hzWlc0cmRXbHVkRGhiTXpKZFcxMHBLUW9nSUNBZ1pHbG5JRElLSUNBZ0lITjNZWEFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdjSFZ6YUdsdWRDQXpNZ29nSUNBZ0tnb2dJQ0FnY0hWemFHbHVkQ0F4TWdvZ0lDQWdLd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl0WlhKcmJHVXRZWE56WlhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlRXVnlhMnhsUVhOelpYUkhZWFJsUTJobFkydFFZWEpoYlhNS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwyMWxjbXRzWlMxaGMzTmxkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBOWlhKcmJHVkJjM05sZEVkaGRHVXVaMlYwUlc1MGNubGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BuWlhSRmJuUnllVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmJXVnlhMnhsTFdGemMyVjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEEzQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ2NtVmhaRzl1YkhrNklIUnlkV1VnZlNrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12YldWeWEyeGxMV0Z6YzJWMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UQTVDaUFnSUNBdkx5QnlaWFIxY200Z1pXNWpiMlJsUVhKak5DaDBhR2x6TG5KbFoybHpkSEo1S0hKbFoybHpkSEo1U1VRcExuWmhiSFZsS1FvZ0lDQWdhWFJ2WWdvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUVKdmVDQnRkWE4wSUdoaGRtVWdkbUZzZFdVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZiV1Z5YTJ4bExXRnpjMlYwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRBM0NpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2djbVZoWkc5dWJIazZJSFJ5ZFdVZ2ZTa0tJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwySmhjMlV0WTI5dWRISmhZM1J6TDNWd1ozSmhaR1ZoWW14bExuUnpPanBCYTJsMFlVSmhjMlZEYjI1MGNtRmpkQzUxY0dSaGRHVkJhMmwwWVVSQlQxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDblZ3WkdGMFpVRnJhWFJoUkVGUE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMkpoYzJVdFkyOXVkSEpoWTNSekwzVndaM0poWkdWaFlteGxMblJ6T2pJMUNpQWdJQ0F2THlCMWNHUmhkR1ZCYTJsMFlVUkJUeWhoYTJsMFlVUkJUem9nUVhCd2JHbGpZWFJwYjI0cE9pQjJiMmxrSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTlpWVhObExXTnZiblJ5WVdOMGN5OTFjR2R5WVdSbFlXSnNaUzUwY3pveU5nb2dJQ0FnTHk4Z2JHOW5aMlZrUVhOelpYSjBLRlI0Ymk1elpXNWtaWElnUFQwOUlIUm9hWE11WjJWMFFXdHBkR0ZFUVU5WFlXeHNaWFFvS1M1aFpHUnlaWE56TENCbGNuSk9iM1JCYTJsMFlVUmhieWtLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTlpWVhObExXTnZiblJ5WVdOMGN5OTFjR2R5WVdSbFlXSnNaUzUwY3pveE9Rb2dJQ0FnTHk4Z1kyOXVjM1FnVzNkaGJHeGxkRWxFWFNBOUlHOXdMa0Z3Y0Vkc2IySmhiQzVuWlhSRmVGVnBiblEyTkNoMGFHbHpMbUZyYVhSaFJFRlBMblpoYkhWbExDQkNlWFJsY3loQmEybDBZVVJCVDBkc2IySmhiRk4wWVhSbFMyVjVjMWRoYkd4bGRDa3BDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMkpoYzJVdFkyOXVkSEpoWTNSekwzVndaM0poWkdWaFlteGxMblJ6T2pFMkNpQWdJQ0F2THlCaGEybDBZVVJCVHlBOUlFZHNiMkpoYkZOMFlYUmxQRUZ3Y0d4cFkyRjBhVzl1UGloN0lHdGxlVG9nUjJ4dlltRnNVM1JoZEdWTFpYbEJhMmwwWVVSQlR5QjlLUW9nSUNBZ1lubDBaV05mTVNBdkx5QWlZV3RwZEdGZlpHRnZJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJKaGMyVXRZMjl1ZEhKaFkzUnpMM1Z3WjNKaFpHVmhZbXhsTG5Sek9qRTVDaUFnSUNBdkx5QmpiMjV6ZENCYmQyRnNiR1YwU1VSZElEMGdiM0F1UVhCd1IyeHZZbUZzTG1kbGRFVjRWV2x1ZERZMEtIUm9hWE11WVd0cGRHRkVRVTh1ZG1Gc2RXVXNJRUo1ZEdWektFRnJhWFJoUkVGUFIyeHZZbUZzVTNSaGRHVkxaWGx6VjJGc2JHVjBLU2tLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNCd2RYTm9ZbmwwWlhNZ0luZGhiR3hsZENJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCd2IzQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTlpWVhObExXTnZiblJ5WVdOMGN5OTFjR2R5WVdSbFlXSnNaUzUwY3pveU5nb2dJQ0FnTHk4Z2JHOW5aMlZrUVhOelpYSjBLRlI0Ymk1elpXNWtaWElnUFQwOUlIUm9hWE11WjJWMFFXdHBkR0ZFUVU5WFlXeHNaWFFvS1M1aFpHUnlaWE56TENCbGNuSk9iM1JCYTJsMFlVUmhieWtLSUNBZ0lHRndjRjl3WVhKaGJYTmZaMlYwSUVGd2NFRmtaSEpsYzNNS0lDQWdJR0Z6YzJWeWRDQXZMeUJoY0hCc2FXTmhkR2x2YmlCbGVHbHpkSE1LSUNBZ0lEMDlDaUFnSUNCaWJub2dkWEJrWVhSbFFXdHBkR0ZFUVU5ZllXWjBaWEpmWVhOelpYSjBRRE1LSUNBZ0lIQjFjMmhpZVhSbGN5QWlSVkpTT21WeWNrNWtZVzhpQ2lBZ0lDQnNiMmNLSUNBZ0lHVnljaUF2THlCRlVsSTZaWEp5VG1SaGJ3b0tkWEJrWVhSbFFXdHBkR0ZFUVU5ZllXWjBaWEpmWVhOelpYSjBRRE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlltRnpaUzFqYjI1MGNtRmpkSE12ZFhCbmNtRmtaV0ZpYkdVdWRITTZNVFlLSUNBZ0lDOHZJR0ZyYVhSaFJFRlBJRDBnUjJ4dlltRnNVM1JoZEdVOFFYQndiR2xqWVhScGIyNCtLSHNnYTJWNU9pQkhiRzlpWVd4VGRHRjBaVXRsZVVGcmFYUmhSRUZQSUgwcENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKaGEybDBZVjlrWVc4aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZZbUZ6WlMxamIyNTBjbUZqZEhNdmRYQm5jbUZrWldGaWJHVXVkSE02TWpjS0lDQWdJQzh2SUhSb2FYTXVZV3RwZEdGRVFVOHVkbUZzZFdVZ1BTQmhhMmwwWVVSQlR3b2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTlpWVhObExXTnZiblJ5WVdOMGN5OTFjR2R5WVdSbFlXSnNaUzUwY3pveU5Rb2dJQ0FnTHk4Z2RYQmtZWFJsUVd0cGRHRkVRVThvWVd0cGRHRkVRVTg2SUVGd2NHeHBZMkYwYVc5dUtUb2dkbTlwWkNCN0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXRaWEpyYkdVdFlYTnpaWFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VFdWeWEyeGxRWE56WlhSSFlYUmxMbU52YzNRb1lYSm5jem9nWW5sMFpYTXBJQzArSUhWcGJuUTJORG9LYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXRaWEpyYkdVdFlYTnpaWFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VFdWeWEyeGxRWE56WlhSSFlYUmxMbU52YzNRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMMjFsY210c1pTMWhjM05sZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZeENpQWdJQ0F2THlCamIzTjBLR0Z5WjNNNklHSjVkR1Z6S1RvZ2RXbHVkRFkwSUhzS0lDQWdJSEJ5YjNSdklERWdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5dFpYSnJiR1V0WVhOelpYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJNZ29nSUNBZ0x5OGdiRzluWjJWa1FYTnpaWEowS0dGeVozTXViR1Z1WjNSb0lENDlJRTFwYmxKbFoybHpkR1Z5UVhKbmMweGxibWQwYUN3Z1pYSnlTVzUyWVd4cFpFRnlaME52ZFc1MEtRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JzWlc0S0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQXpOUW9nSUNBZ1BqMEtJQ0FnSUdKdWVpQnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDIxbGNtdHNaUzFoYzNObGRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcE5aWEpyYkdWQmMzTmxkRWRoZEdVdVkyOXpkRjloWm5SbGNsOWhjM05sY25SQU1nb2dJQ0FnWW5sMFpXTmZNeUF2THlBaVJWSlNPbVZ5Y2tsaGNtY2lDaUFnSUNCc2IyY0tJQ0FnSUdWeWNpQXZMeUJGVWxJNlpYSnlTV0Z5WndvS2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl0WlhKcmJHVXRZWE56WlhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlRXVnlhMnhsUVhOelpYUkhZWFJsTG1OdmMzUmZZV1owWlhKZllYTnpaWEowUURJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMMjFsY210c1pTMWhjM05sZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZekNpQWdJQ0F2THlCeVpYUjFjbTRnVFdsdVRXVjBZVTFsY210c1pWSmxaMmx6ZEhKNVRVSlNJQ3NnS0VKdmVFTnZjM1JRWlhKQ2IzZ2dLaUFvWVhKbmN5NXNaVzVuZEdnZ0xTQXpNaWtwQ2lBZ0lDQndkWE5vYVc1MElETXlDaUFnSUNBdENpQWdJQ0J3ZFhOb2FXNTBJREkxTURBS0lDQWdJQ29LSUNBZ0lIQjFjMmhwYm5RZ01UZzFNREFLSUNBZ0lDc0tJQ0FnSUhKbGRITjFZZ289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERUtJQ0FnSUhKbGRIVnliZ289In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFRQUNDQ1lGQkJVZmZIVUpZV3RwZEdGZlpHRnZEM0psWjJsemRISjVYMk4xY25OdmNndEZVbEk2WlhKeVNXRnlad3RGVWxJNlpYSnlTWEJoZVRFWVFBQk5LaUpuZ2dJU2NtVm5hWE4wY21GMGFXOXVYM05vWVhCbEVDaGhaR1J5WlhOekxITjBjbWx1WnlsbmdnSUxZMmhsWTJ0ZmMyaGhjR1VUS0hWcGJuUTJOQ3hpZVhSbFd6TXlYVnRkS1djeEdSUkVNUmhCQUVLQ0NBUXlud1R1QkhlN2Via0ViZ1AxQ2dTN3VLS3NCSVFiV1hFRWtOVDZYUVF6NlN5VUJJVk43ZUEyR2dDT0NBQTdBRlVBc0FGMkFaZ0J2QUhXQUFFQUlrT0FCTTJhMW40MkdnQ09BUUFCQURZYUFVa2pXU1FJU3dFVkVrUlhBZ0EyR2dKSkZTVVNSQmVBQjNabGNuTnBiMjVQQW1jcFRHY2lRellhQVVraldTUUlTd0VWRWtSWEFnQ0lBYndXS0V4UXNDSkRNUllpQ1VrNEVDSVNSRFlhQVVraldTUUlTd0VWRWtSWEFnQkpGWUVqRDBBQUF5dXdBRXNCT0FjeUNoSkFBQVFuQkxBQVREZ0lTd0dJQVhvU1FBQUVKd1N3QUNNcVpVUkpJZ2dxVEdjV1NieElTVThDdnloTVVMQWlRNEFBTmhvQlNSV0JJQkpFTmhvQ1NSVWxFa1FYTmhvRFJ3SWpXU1FJU3dFVkVrUlhBZ0JKRlVtQkRBOUFBQU1yc0FCUEFpUmJTVThEU1NWWlR3UlNURThFVEhBQVRFVUZRUUFGU3dOQUFCQkdBeU9BQVFBalR3SlVLRXhRc0NKRFR3SVdTU09CSUxwTEFZRWlKTG9YSkFoUEFvRWlUd0s2c1U4REZnRUJJaFlqS1dWRWdBTmhZV3hsU0lGSVc3SVlnQVFyODh4YXNocFBBN0lhVHdLeUdreXlHa3l5R3JJYWdRYXlFQ095QWJPMFBrbFhCQUJNVndBRUtCSkVTUlVpRWtRalUwTC9qRFlhQVVrVlN3R0JJRmxKZ1NJU1JFc0NURXNDVWlOWmdTUUlFa1FvVEZDd0lrTTJHZ0ZKRlVzQkpWbEpnUW9TUkVzQ1RFc0NVaU5aZ1NBTGdRd0lFa1FvVEZDd0lrTTJHZ0ZKRlNVU1JCY1d2a1JKRlJaWEJnSk1VQ2hNVUxBaVF6WWFBVWtWSlJKRUZ6RUFJeWxsUklBR2QyRnNiR1YwWlVoeUNFUVNRQUFQZ0F0RlVsSTZaWEp5VG1SaGI3QUFLVXhuSWtPS0FRR0wveFZKZ1NNUFFBQURLN0FBZ1NBSmdjUVRDNEhFa0FFSWlRPT0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjoxMCwicGF0Y2giOjEsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
