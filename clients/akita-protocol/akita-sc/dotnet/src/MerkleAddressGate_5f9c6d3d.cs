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

namespace Arc56.Generated.akita_protocol.akita_sc.MerkleAddressGate_5f9c6d3d
{


    public class MerkleAddressGateProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public MerkleAddressGateProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class MerkleAddressGateRegistryInfo : AVMObjectType
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

                public static MerkleAddressGateRegistryInfo Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new MerkleAddressGateRegistryInfo();
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
                    return Equals(obj as MerkleAddressGateRegistryInfo);
                }
                public bool Equals(MerkleAddressGateRegistryInfo? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(MerkleAddressGateRegistryInfo left, MerkleAddressGateRegistryInfo right)
                {
                    return EqualityComparer<MerkleAddressGateRegistryInfo>.Default.Equals(left, right);
                }
                public static bool operator !=(MerkleAddressGateRegistryInfo left, MerkleAddressGateRegistryInfo right)
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
        /// <param name="shape"> MerkleAddressGateRegistryInfo</param>
        public async Task<Structs.MerkleAddressGateRegistryInfo> GetRegistrationShape(Structs.MerkleAddressGateRegistryInfo shape, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
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
            return Structs.MerkleAddressGateRegistryInfo.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetRegistrationShape_Transactions(Structs.MerkleAddressGateRegistryInfo shape, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
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
        /// <param name="shape"> </param>
        public async Task<byte[][]> GetCheckShape(byte[][] shape, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 180, 85, 176, 94 };
            var shapeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>>("byte[32]"); shapeAbi.From(shape);

            var result = await base.CallApp(new List<object> { abiHandle, shapeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            throw new Exception("Conversion not implemented"); // <unknown return conversion>

        }

        public async Task<List<Transaction>> GetCheckShape_Transactions(byte[][] shape, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 180, 85, 176, 94 };
            var shapeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>>("byte[32]"); shapeAbi.From(shape);

            return await base.MakeTransactionList(new List<object> { abiHandle, shapeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTWVya2xlQWRkcmVzc0dhdGUiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiTWVya2xlQWRkcmVzc0dhdGVSZWdpc3RyeUluZm8iOlt7Im5hbWUiOiJjcmVhdG9yIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJuYW1lIiwidHlwZSI6InN0cmluZyJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidmVyc2lvbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWtpdGFEQU8iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY29zdCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcmdzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVnaXN0ZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWJyUGF5bWVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXJncyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNoZWNrIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjYWxsZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlZ2lzdHJ5SUQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFyZ3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0UmVnaXN0cmF0aW9uU2hhcGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKGFkZHJlc3Msc3RyaW5nKSIsInN0cnVjdCI6Ik1lcmtsZUFkZHJlc3NHYXRlUmVnaXN0cnlJbmZvIiwibmFtZSI6InNoYXBlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6IihhZGRyZXNzLHN0cmluZykiLCJzdHJ1Y3QiOiJNZXJrbGVBZGRyZXNzR2F0ZVJlZ2lzdHJ5SW5mbyIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldENoZWNrU2hhcGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVszMl1bXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNoYXBlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJ5dGVbMzJdW10iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldEVudHJ5IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlZ2lzdHJ5SUQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InVwZGF0ZUFraXRhREFPIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFraXRhREFPIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im9wVXAiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjIsImJ5dGVzIjozfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls2MDBdLCJlcnJvck1lc3NhZ2UiOiJCb3ggbXVzdCBoYXZlIHZhbHVlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTIyXSwiZXJyb3JNZXNzYWdlIjoiQnl0ZXMgaGFzIHZhbGlkIHByZWZpeCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMzNCw0MzIsNjgzXSwiZXJyb3JNZXNzYWdlIjoiRVJSOmVycklhcmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNDgsMzY0XSwiZXJyb3JNZXNzYWdlIjoiRVJSOmVycklwYXkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2NjJdLCJlcnJvck1lc3NhZ2UiOiJFUlI6ZXJyTmRhbyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY0M10sImVycm9yTWVzc2FnZSI6ImFwcGxpY2F0aW9uIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM2OCw0NjUsNjMwXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgR2xvYmFsU3RhdGUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDM4XSwiZXJyb3JNZXNzYWdlIjoiaW5kZXggb3V0IG9mIGJvdW5kcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIzMSwyNzcsMzEzLDQxMiw1NTUsNTcyXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjM4LDI4NCwzMjAsNDE5XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU4MV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8Ynl0ZXNbMzJdPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM5Nl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNTAsNDA1LDU5Niw2MjNdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MjddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYm9vbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU2MF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBzbWFydF9jb250cmFjdHMvZ2F0ZXMvc3ViLWdhdGVzL21lcmtsZS1hZGRyZXNzL2NvbnRyYWN0LmFsZ28udHM6Ok1lcmtsZUFkZHJlc3NHYXRlUmVnaXN0cnlJbmZvIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTQ3XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCB0YWlsIHBvaW50ZXIgYXQgaW5kZXggMSBvZiAodWludDhbMzJdLChsZW4rdXRmOFtdKSkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NDJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHR1cGxlIGVuY29kaW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzA3XSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBwYXkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01TQXdJRElnTXpJS0lDQWdJR0o1ZEdWallteHZZMnNnTUhneE5URm1OMk0zTlNBaWNtVm5hWE4wY25sZlkzVnljMjl5SWlBaVlXdHBkR0ZmWkdGdklpQWlSVkpTT21WeWNrbGhjbWNpSUNKRlVsSTZaWEp5U1hCaGVTSUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmlibm9nYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZiV1Z5YTJ4bExXRmtaSEpsYzNNdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU9Rb2dJQ0FnTHk4Z2NtVm5hWE4wY25sRGRYSnpiM0lnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tIc2dhVzVwZEdsaGJGWmhiSFZsT2lBeExDQnJaWGs2SUVkaGRHVkhiRzlpWVd4VGRHRjBaVXRsZVZKbFoybHpkSEo1UTNWeWMyOXlJSDBwQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0p5WldkcGMzUnllVjlqZFhKemIzSWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12YldWeWEyeGxMV0ZrWkhKbGMzTXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pNUW9nSUNBZ0x5OGdjbVZuYVhOMGNtRjBhVzl1VTJoaGNHVWdQU0JIYkc5aVlXeFRkR0YwWlR4emRISnBibWMrS0hzZ2FXNXBkR2xoYkZaaGJIVmxPaUFuS0dGa1pISmxjM01zYzNSeWFXNW5LU2NzSUd0bGVUb2dSMkYwWlVkc2IySmhiRk4wWVhSbFMyVjVVbVZuYVhOMGNtRjBhVzl1VTJoaGNHVWdmU2tLSUNBZ0lIQjFjMmhpZVhSbGMzTWdJbkpsWjJsemRISmhkR2x2Ymw5emFHRndaU0lnSWloaFpHUnlaWE56TEhOMGNtbHVaeWtpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXRaWEpyYkdVdFlXUmtjbVZ6Y3k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNekNpQWdJQ0F2THlCamFHVmphMU5vWVhCbElEMGdSMnh2WW1Gc1UzUmhkR1U4YzNSeWFXNW5QaWg3SUdsdWFYUnBZV3hXWVd4MVpUb2dKMko1ZEdWYk16SmRXMTBuTENCclpYazZJRWRoZEdWSGJHOWlZV3hUZEdGMFpVdGxlVU5vWldOclUyaGhjR1VnZlNrS0lDQWdJSEIxYzJoaWVYUmxjM01nSW1Ob1pXTnJYM05vWVhCbElpQWlZbmwwWlZzek1sMWJYU0lLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2dwdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12YldWeWEyeGxMV0ZrWkhKbGMzTXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lOUW9nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUUxbGNtdHNaVUZrWkhKbGMzTkhZWFJsSUdWNGRHVnVaSE1nUVd0cGRHRkNZWE5sUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lub2diV0ZwYmw5amNtVmhkR1ZmVG05UGNFQXhOQW9nSUNBZ2NIVnphR0o1ZEdWemN5QXdlRE15T1dZd05HVmxJREI0TnpkaVlqYzVZamtnTUhnMlpUQXpaalV3WVNBd2VHSmlZamhoTW1GaklEQjRZalExTldJd05XVWdNSGc1TUdRMFptRTFaQ0F3ZURNelpUa3lZemswSURCNE9EVTBaR1ZrWlRBZ0x5OGdiV1YwYUc5a0lDSmpiM04wS0dKNWRHVmJYU2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbkpsWjJsemRHVnlLSEJoZVN4aWVYUmxXMTBwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0pqYUdWamF5aGhaR1J5WlhOekxIVnBiblEyTkN4aWVYUmxXMTBwWW05dmJDSXNJRzFsZEdodlpDQWlaMlYwVW1WbmFYTjBjbUYwYVc5dVUyaGhjR1VvS0dGa1pISmxjM01zYzNSeWFXNW5LU2tvWVdSa2NtVnpjeXh6ZEhKcGJtY3BJaXdnYldWMGFHOWtJQ0puWlhSRGFHVmphMU5vWVhCbEtHSjVkR1ZiTXpKZFcxMHBZbmwwWlZzek1sMWJYU0lzSUcxbGRHaHZaQ0FpWjJWMFJXNTBjbmtvZFdsdWREWTBLV0o1ZEdWYlhTSXNJRzFsZEdodlpDQWlkWEJrWVhSbFFXdHBkR0ZFUVU4b2RXbHVkRFkwS1hadmFXUWlMQ0J0WlhSb2IyUWdJbTl3VlhBb0tYWnZhV1FpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCamIzTjBJSEpsWjJsemRHVnlJR05vWldOcklHZGxkRkpsWjJsemRISmhkR2x2YmxOb1lYQmxJR2RsZEVOb1pXTnJVMmhoY0dVZ1oyVjBSVzUwY25rZ2RYQmtZWFJsUVd0cGRHRkVRVThnYldGcGJsOXZjRlZ3WDNKdmRYUmxRREV5Q2lBZ0lDQmxjbklLQ20xaGFXNWZiM0JWY0Y5eWIzVjBaVUF4TWpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OWlZWE5sTFdOdmJuUnlZV04wY3k5MWNHZHlZV1JsWVdKc1pTNTBjem96TUFvZ0lDQWdMeThnYjNCVmNDZ3BPaUIyYjJsa0lIc2dmUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWpjbVZoZEdWZlRtOVBjRUF4TkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZiV1Z5YTJ4bExXRmtaSEpsYzNNdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU5Rb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRTFsY210c1pVRmtaSEpsYzNOSFlYUmxJR1Y0ZEdWdVpITWdRV3RwZEdGQ1lYTmxRMjl1ZEhKaFkzUWdld29nSUNBZ2NIVnphR0o1ZEdWeklEQjRZMlE1WVdRMk4yVWdMeThnYldWMGFHOWtJQ0pqY21WaGRHVW9jM1J5YVc1bkxIVnBiblEyTkNsMmIybGtJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnWTNKbFlYUmxDaUFnSUNCbGNuSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMMjFsY210c1pTMWhaR1J5WlhOekwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rMWxjbXRzWlVGa1pISmxjM05IWVhSbExtTnlaV0YwWlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtTnlaV0YwWlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZiV1Z5YTJ4bExXRmtaSEpsYzNNdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME9Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJRzl1UTNKbFlYUmxPaUFuY21WeGRXbHlaU2NnZlNrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0E0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJKaGMyVXRZMjl1ZEhKaFkzUnpMM1Z3WjNKaFpHVmhZbXhsTG5Sek9qRTBDaUFnSUNBdkx5QjJaWEp6YVc5dUlEMGdSMnh2WW1Gc1UzUmhkR1U4YzNSeWFXNW5QaWg3SUd0bGVUb2dSMnh2WW1Gc1UzUmhkR1ZMWlhsV1pYSnphVzl1SUgwcENpQWdJQ0J3ZFhOb1lubDBaWE1nSW5abGNuTnBiMjRpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwyMWxjbXRzWlMxaFpHUnlaWE56TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRFS0lDQWdJQzh2SUhSb2FYTXVkbVZ5YzJsdmJpNTJZV3gxWlNBOUlIWmxjbk5wYjI0S0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5aVlYTmxMV052Ym5SeVlXTjBjeTkxY0dkeVlXUmxZV0pzWlM1MGN6b3hOZ29nSUNBZ0x5OGdZV3RwZEdGRVFVOGdQU0JIYkc5aVlXeFRkR0YwWlR4QmNIQnNhV05oZEdsdmJqNG9leUJyWlhrNklFZHNiMkpoYkZOMFlYUmxTMlY1UVd0cGRHRkVRVThnZlNrS0lDQWdJR0o1ZEdWalh6SWdMeThnSW1GcmFYUmhYMlJoYnlJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZiV1Z5YTJ4bExXRmtaSEpsYzNNdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU1nb2dJQ0FnTHk4Z2RHaHBjeTVoYTJsMFlVUkJUeTUyWVd4MVpTQTlJRUZ3Y0d4cFkyRjBhVzl1S0dGcmFYUmhSRUZQS1FvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZiV1Z5YTJ4bExXRmtaSEpsYzNNdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU9Rb2dJQ0FnTHk4Z2NtVm5hWE4wY25sRGRYSnpiM0lnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tIc2dhVzVwZEdsaGJGWmhiSFZsT2lBeExDQnJaWGs2SUVkaGRHVkhiRzlpWVd4VGRHRjBaVXRsZVZKbFoybHpkSEo1UTNWeWMyOXlJSDBwQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0p5WldkcGMzUnllVjlqZFhKemIzSWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDIxbGNtdHNaUzFoWkdSeVpYTnpMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVE1LSUNBZ0lDOHZJSFJvYVhNdWNtVm5hWE4wY25sRGRYSnpiM0l1ZG1Gc2RXVWdQU0F4Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmJXVnlhMnhsTFdGa1pISmxjM012WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wT1FvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lHOXVRM0psWVhSbE9pQW5jbVZ4ZFdseVpTY2dmU2tLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDIxbGNtdHNaUzFoWkdSeVpYTnpMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPazFsY210c1pVRmtaSEpsYzNOSFlYUmxMbU52YzNSYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGpiM04wT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXRaWEpyYkdVdFlXUmtjbVZ6Y3k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVNENpQWdJQ0F2THlCamIzTjBLR0Z5WjNNNklHSjVkR1Z6S1RvZ2RXbHVkRFkwSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCallXeHNjM1ZpSUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZiV1Z5YTJ4bExXRmtaSEpsYzNNdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlRXVnlhMnhsUVdSa2NtVnpjMGRoZEdVdVkyOXpkQW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12YldWeWEyeGxMV0ZrWkhKbGMzTXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZUV1Z5YTJ4bFFXUmtjbVZ6YzBkaGRHVXVjbVZuYVhOMFpYSmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B5WldkcGMzUmxjam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmJXVnlhMnhsTFdGa1pISmxjM012WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTXdvZ0lDQWdMeThnY21WbmFYTjBaWElvYldKeVVHRjViV1Z1ZERvZ1ozUjRiaTVRWVhsdFpXNTBWSGh1TENCaGNtZHpPaUJpZVhSbGN5azZJSFZwYm5RMk5DQjdDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUMwS0lDQWdJR1IxY0FvZ0lDQWdaM1I0Ym5NZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUJ3WVhrS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdkSEpoYm5OaFkzUnBiMjRnZEhsd1pTQnBjeUJ3WVhrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCa2RYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12YldWeWEyeGxMV0ZrWkhKbGMzTXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJOQW9nSUNBZ0x5OGdiRzluWjJWa1FYTnpaWEowS0dGeVozTXViR1Z1WjNSb0lENDlJRTFwYmxKbFoybHpkR1Z5UVhKbmMweGxibWQwYUN3Z1pYSnlTVzUyWVd4cFpFRnlaME52ZFc1MEtRb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRE0xQ2lBZ0lDQStQUW9nSUNBZ1ltNTZJSEpsWjJsemRHVnlYMkZtZEdWeVgyRnpjMlZ5ZEVBekNpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKRlVsSTZaWEp5U1dGeVp5SUtJQ0FnSUd4dlp3b2dJQ0FnWlhKeUlDOHZJRVZTVWpwbGNuSkpZWEpuQ2dweVpXZHBjM1JsY2w5aFpuUmxjbDloYzNObGNuUkFNem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmJXVnlhMnhsTFdGa1pISmxjM012WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTlFvZ0lDQWdMeThnYkc5bloyVmtRWE56WlhKMEtHMWljbEJoZVcxbGJuUXVjbVZqWldsMlpYSWdQVDA5SUVkc2IySmhiQzVqZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpMQ0JsY25KSmJuWmhiR2xrVUdGNWJXVnVkQ2tLSUNBZ0lHUnBaeUF4Q2lBZ0lDQm5kSGh1Y3lCU1pXTmxhWFpsY2dvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJRDA5Q2lBZ0lDQmlibm9nY21WbmFYTjBaWEpmWVdaMFpYSmZZWE56WlhKMFFEVUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z0lrVlNVanBsY25KSmNHRjVJZ29nSUNBZ2JHOW5DaUFnSUNCbGNuSWdMeThnUlZKU09tVnlja2x3WVhrS0NuSmxaMmx6ZEdWeVgyRm1kR1Z5WDJGemMyVnlkRUExT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXRaWEpyYkdVdFlXUmtjbVZ6Y3k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZMkNpQWdJQ0F2THlCc2IyZG5aV1JCYzNObGNuUW9iV0p5VUdGNWJXVnVkQzVoYlc5MWJuUWdQVDA5SUhSb2FYTXVZMjl6ZENoaGNtZHpLU3dnWlhKeVNXNTJZV3hwWkZCaGVXMWxiblFwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQm5kSGh1Y3lCQmJXOTFiblFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmpZV3hzYzNWaUlITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12YldWeWEyeGxMV0ZrWkhKbGMzTXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZUV1Z5YTJ4bFFXUmtjbVZ6YzBkaGRHVXVZMjl6ZEFvZ0lDQWdQVDBLSUNBZ0lHSnVlaUJ5WldkcGMzUmxjbDloWm5SbGNsOWhjM05sY25SQU53b2dJQ0FnWW5sMFpXTWdOQ0F2THlBaVJWSlNPbVZ5Y2tsd1lYa2lDaUFnSUNCc2IyY0tJQ0FnSUdWeWNpQXZMeUJGVWxJNlpYSnlTWEJoZVFvS2NtVm5hWE4wWlhKZllXWjBaWEpmWVhOelpYSjBRRGM2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwyMWxjbXRzWlMxaFpHUnlaWE56TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRJS0lDQWdJQzh2SUdOdmJuTjBJR2xrSUQwZ2RHaHBjeTV5WldkcGMzUnllVU4xY25OdmNpNTJZV3gxWlFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmJXVnlhMnhsTFdGa1pISmxjM012WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95T1FvZ0lDQWdMeThnY21WbmFYTjBjbmxEZFhKemIzSWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0hzZ2FXNXBkR2xoYkZaaGJIVmxPaUF4TENCclpYazZJRWRoZEdWSGJHOWlZV3hUZEdGMFpVdGxlVkpsWjJsemRISjVRM1Z5YzI5eUlIMHBDaUFnSUNCaWVYUmxZMTh4SUM4dklDSnlaV2RwYzNSeWVWOWpkWEp6YjNJaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMMjFsY210c1pTMWhaR1J5WlhOekwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5ESUtJQ0FnSUM4dklHTnZibk4wSUdsa0lEMGdkR2hwY3k1eVpXZHBjM1J5ZVVOMWNuTnZjaTUyWVd4MVpRb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZiV1Z5YTJ4bExXRmtaSEpsYzNNdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME13b2dJQ0FnTHk4Z2RHaHBjeTV5WldkcGMzUnllVU4xY25OdmNpNTJZV3gxWlNBclBTQXhDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0FyQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwyMWxjbXRzWlMxaFpHUnlaWE56TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWprS0lDQWdJQzh2SUhKbFoybHpkSEo1UTNWeWMyOXlJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGloN0lHbHVhWFJwWVd4V1lXeDFaVG9nTVN3Z2EyVjVPaUJIWVhSbFIyeHZZbUZzVTNSaGRHVkxaWGxTWldkcGMzUnllVU4xY25OdmNpQjlLUW9nSUNBZ1lubDBaV05mTVNBdkx5QWljbVZuYVhOMGNubGZZM1Z5YzI5eUlnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl0WlhKcmJHVXRZV1JrY21WemN5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUXpDaUFnSUNBdkx5QjBhR2x6TG5KbFoybHpkSEo1UTNWeWMyOXlMblpoYkhWbElDczlJREVLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwyMWxjbXRzWlMxaFpHUnlaWE56TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmprS0lDQWdJQzh2SUhSb2FYTXVjbVZuYVhOMGNua29hV1FwTG5aaGJIVmxJRDBnWkdWamIyUmxRWEpqTkR4TlpYSnJiR1ZCWkdSeVpYTnpSMkYwWlZKbFoybHpkSEo1U1c1bWJ6NG9ZWEpuY3lrS0lDQWdJR2wwYjJJS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0JrZFhBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXRaWEpyYkdVdFlXUmtjbVZ6Y3k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZekNpQWdJQ0F2THlCeVpXZHBjM1JsY2lodFluSlFZWGx0Wlc1ME9pQm5kSGh1TGxCaGVXMWxiblJVZUc0c0lHRnlaM002SUdKNWRHVnpLVG9nZFdsdWREWTBJSHNLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDIxbGNtdHNaUzFoWkdSeVpYTnpMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPazFsY210c1pVRmtaSEpsYzNOSFlYUmxMbU5vWldOclczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZMmhsWTJzNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMMjFsY210c1pTMWhaR1J5WlhOekwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk56TUtJQ0FnSUM4dklHTm9aV05yS0dOaGJHeGxjam9nUVdOamIzVnVkQ3dnY21WbmFYTjBjbmxKUkRvZ2RXbHVkRFkwTENCaGNtZHpPaUJpZVhSbGN5azZJR0p2YjJ4bFlXNGdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0E0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJR1IxY0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXRaWEpyYkdVdFlXUmtjbVZ6Y3k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pjMENpQWdJQ0F2THlCc2IyZG5aV1JCYzNObGNuUW9ZWEpuY3k1c1pXNW5kR2dnUGowZ1RXbHVRMmhsWTJ0QmNtZHpUR1Z1WjNSb0xDQmxjbkpKYm5aaGJHbGtRWEpuUTI5MWJuUXBDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0ErUFFvZ0lDQWdZbTU2SUdOb1pXTnJYMkZtZEdWeVgyRnpjMlZ5ZEVBekNpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKRlVsSTZaWEp5U1dGeVp5SUtJQ0FnSUd4dlp3b2dJQ0FnWlhKeUlDOHZJRVZTVWpwbGNuSkpZWEpuQ2dwamFHVmphMTloWm5SbGNsOWhjM05sY25SQU16b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12YldWeWEyeGxMV0ZrWkhKbGMzTXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNOZ29nSUNBZ0x5OGdZMjl1YzNRZ2V5QmpjbVZoZEc5eUxDQnVZVzFsSUgwZ1BTQmpiRzl1WlNoMGFHbHpMbkpsWjJsemRISjVLSEpsWjJsemRISjVTVVFwTG5aaGJIVmxLUW9nSUNBZ2MzZGhjQW9nSUNBZ2FYUnZZZ29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnYVc1MFkxOHpJQzh2SURNeUNpQWdJQ0JpYjNoZlpYaDBjbUZqZENBdkx5QnZiaUJsY25KdmNqb2dhVzVrWlhnZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ1pHbG5JREVLSUNBZ0lIQjFjMmhwYm5RZ016UUtJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdZblJ2YVFvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lDc0tJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjSFZ6YUdsdWRDQXpOQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXRaWEpyYkdVdFlXUmtjbVZ6Y3k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pjNExUZzNDaUFnSUNBdkx5QnlaWFIxY200Z1lXSnBRMkZzYkR4MGVYQmxiMllnVFdWMFlTNXdjbTkwYjNSNWNHVXVkbVZ5YVdaNVBpaDdDaUFnSUNBdkx5QWdJR0Z3Y0Vsa09pQm5aWFJCYTJsMFlVRndjRXhwYzNRb2RHaHBjeTVoYTJsMFlVUkJUeTUyWVd4MVpTa3ViV1YwWVUxbGNtdHNaWE1zQ2lBZ0lDQXZMeUFnSUdGeVozTTZJRnNLSUNBZ0lDOHZJQ0FnSUNCamNtVmhkRzl5TEFvZ0lDQWdMeThnSUNBZ0lHNWhiV1VzQ2lBZ0lDQXZMeUFnSUNBZ2MyaGhNalUyS0hOb1lUSTFOaWhqWVd4c1pYSXVZbmwwWlhNcEtTd0tJQ0FnSUM4dklDQWdJQ0J3Y205dlppd0tJQ0FnSUM4dklDQWdJQ0JOWlhKcmJHVlVjbVZsVkhsd1pWVnVjM0JsWTJsbWFXVmtMQW9nSUNBZ0x5OGdJQ0JkTEFvZ0lDQWdMeThnZlNrdWNtVjBkWEp1Vm1Gc2RXVUtJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZiV1Z5YTJ4bExXRmtaSEpsYzNNdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNE13b2dJQ0FnTHk4Z2MyaGhNalUyS0hOb1lUSTFOaWhqWVd4c1pYSXVZbmwwWlhNcEtTd0tJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdjMmhoTWpVMkNpQWdJQ0J6YUdFeU5UWUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12YldWeWEyeGxMV0ZrWkhKbGMzTXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzROUW9nSUNBZ0x5OGdUV1Z5YTJ4bFZISmxaVlI1Y0dWVmJuTndaV05wWm1sbFpDd0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMMjFsY210c1pTMWhaR1J5WlhOekwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk56a0tJQ0FnSUM4dklHRndjRWxrT2lCblpYUkJhMmwwWVVGd2NFeHBjM1FvZEdocGN5NWhhMmwwWVVSQlR5NTJZV3gxWlNrdWJXVjBZVTFsY210c1pYTXNDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMkpoYzJVdFkyOXVkSEpoWTNSekwzVndaM0poWkdWaFlteGxMblJ6T2pFMkNpQWdJQ0F2THlCaGEybDBZVVJCVHlBOUlFZHNiMkpoYkZOMFlYUmxQRUZ3Y0d4cFkyRjBhVzl1UGloN0lHdGxlVG9nUjJ4dlltRnNVM1JoZEdWTFpYbEJhMmwwWVVSQlR5QjlLUW9nSUNBZ1lubDBaV05mTWlBdkx5QWlZV3RwZEdGZlpHRnZJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5dFpYSnJiR1V0WVdSa2NtVnpjeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamM1Q2lBZ0lDQXZMeUJoY0hCSlpEb2daMlYwUVd0cGRHRkJjSEJNYVhOMEtIUm9hWE11WVd0cGRHRkVRVTh1ZG1Gc2RXVXBMbTFsZEdGTlpYSnJiR1Z6TEFvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5bWRXNWpkR2x2Ym5NdWRITTZNakEyQ2lBZ0lDQXZMeUJqYjI1emRDQmJZWEJ3VEdsemRFSjVkR1Z6WFNBOUlHOXdMa0Z3Y0Vkc2IySmhiQzVuWlhSRmVFSjVkR1Z6S0dGcmFYUmhSRUZQTENCQ2VYUmxjeWhCYTJsMFlVUkJUMGRzYjJKaGJGTjBZWFJsUzJWNWMwRnJhWFJoUVhCd1RHbHpkQ2twQ2lBZ0lDQndkWE5vWW5sMFpYTWdJbUZoYkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCd2IzQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12YldWeWEyeGxMV0ZrWkhKbGMzTXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNPUW9nSUNBZ0x5OGdZWEJ3U1dRNklHZGxkRUZyYVhSaFFYQndUR2x6ZENoMGFHbHpMbUZyYVhSaFJFRlBMblpoYkhWbEtTNXRaWFJoVFdWeWEyeGxjeXdLSUNBZ0lIQjFjMmhwYm5RZ056SUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmJXVnlhMnhsTFdGa1pISmxjM012WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zT0MwNE53b2dJQ0FnTHk4Z2NtVjBkWEp1SUdGaWFVTmhiR3c4ZEhsd1pXOW1JRTFsZEdFdWNISnZkRzkwZVhCbExuWmxjbWxtZVQ0b2V3b2dJQ0FnTHk4Z0lDQmhjSEJKWkRvZ1oyVjBRV3RwZEdGQmNIQk1hWE4wS0hSb2FYTXVZV3RwZEdGRVFVOHVkbUZzZFdVcExtMWxkR0ZOWlhKcmJHVnpMQW9nSUNBZ0x5OGdJQ0JoY21kek9pQmJDaUFnSUNBdkx5QWdJQ0FnWTNKbFlYUnZjaXdLSUNBZ0lDOHZJQ0FnSUNCdVlXMWxMQW9nSUNBZ0x5OGdJQ0FnSUhOb1lUSTFOaWh6YUdFeU5UWW9ZMkZzYkdWeUxtSjVkR1Z6S1Nrc0NpQWdJQ0F2THlBZ0lDQWdjSEp2YjJZc0NpQWdJQ0F2THlBZ0lDQWdUV1Z5YTJ4bFZISmxaVlI1Y0dWVmJuTndaV05wWm1sbFpDd0tJQ0FnSUM4dklDQWdYU3dLSUNBZ0lDOHZJSDBwTG5KbGRIVnlibFpoYkhWbENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhneVltWXpZMk0xWVNBdkx5QnRaWFJvYjJRZ0luWmxjbWxtZVNoaFpHUnlaWE56TEhOMGNtbHVaeXhpZVhSbFd6TXlYU3hpZVhSbFd6TXlYVnRkTEhWcGJuUTJOQ2xpYjI5c0lnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lITjNZWEFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJSEIxYzJocGJuUWdOaUF2THlCaGNIQnNDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQnBkSGh1SUV4aGMzUk1iMmNLSUNBZ0lHUjFjQW9nSUNBZ1pYaDBjbUZqZENBMElEQUtJQ0FnSUhOM1lYQUtJQ0FnSUdWNGRISmhZM1FnTUNBMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdRbmwwWlhNZ2FHRnpJSFpoYkdsa0lIQnlaV1pwZUFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaWIyOXNDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDIxbGNtdHNaUzFoWkdSeVpYTnpMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOek1LSUNBZ0lDOHZJR05vWldOcktHTmhiR3hsY2pvZ1FXTmpiM1Z1ZEN3Z2NtVm5hWE4wY25sSlJEb2dkV2x1ZERZMExDQmhjbWR6T2lCaWVYUmxjeWs2SUdKdmIyeGxZVzRnZXdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmJXVnlhMnhsTFdGa1pISmxjM012WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VFdWeWEyeGxRV1JrY21WemMwZGhkR1V1WjJWMFVtVm5hWE4wY21GMGFXOXVVMmhoY0dWYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncG5aWFJTWldkcGMzUnlZWFJwYjI1VGFHRndaVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmJXVnlhMnhsTFdGa1pISmxjM012WTI5dWRISmhZM1F1WVd4bmJ5NTBjem81TUFvZ0lDQWdMeThnWjJWMFVtVm5hWE4wY21GMGFXOXVVMmhoY0dVb2MyaGhjR1U2SUUxbGNtdHNaVUZrWkhKbGMzTkhZWFJsVW1WbmFYTjBjbmxKYm1adktUb2dUV1Z5YTJ4bFFXUmtjbVZ6YzBkaGRHVlNaV2RwYzNSeWVVbHVabThnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lIUjFjR3hsSUdWdVkyOWthVzVuQ2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ016UUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0IwWVdsc0lIQnZhVzUwWlhJZ1lYUWdhVzVrWlhnZ01TQnZaaUFvZFdsdWREaGJNekpkTENoc1pXNHJkWFJtT0Z0ZEtTa0tJQ0FnSUdScFp5QXlDaUFnSUNCemQyRndDaUFnSUNCa2FXY2dNZ29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lIQjFjMmhwYm5RZ016WUtJQ0FnSUNzS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmJXVnlhMnhsTFdGa1pISmxjM012WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VFdWeWEyeGxRV1JrY21WemMwZGhkR1ZTWldkcGMzUnllVWx1Wm04S0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwyMWxjbXRzWlMxaFpHUnlaWE56TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2sxbGNtdHNaVUZrWkhKbGMzTkhZWFJsTG1kbGRFTm9aV05yVTJoaGNHVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BuWlhSRGFHVmphMU5vWVhCbE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl0WlhKcmJHVXRZV1JrY21WemN5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qazBDaUFnSUNBdkx5Qm5aWFJEYUdWamExTm9ZWEJsS0hOb1lYQmxPaUJRY205dlppazZJRkJ5YjI5bUlIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTXlBdkx5QXpNZ29nSUNBZ0tnb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGllWFJsYzFzek1sMCtDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl0WlhKcmJHVXRZV1JrY21WemN5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcE5aWEpyYkdWQlpHUnlaWE56UjJGMFpTNW5aWFJGYm5SeWVWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWRsZEVWdWRISjVPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5dFpYSnJiR1V0WVdSa2NtVnpjeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPams0Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ2NtVmhaRzl1YkhrNklIUnlkV1VnZlNrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMMjFsY210c1pTMWhaR1J5WlhOekwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UQXdDaUFnSUNBdkx5QnlaWFIxY200Z1pXNWpiMlJsUVhKak5DaDBhR2x6TG5KbFoybHpkSEo1S0hKbFoybHpkSEo1U1VRcExuWmhiSFZsS1FvZ0lDQWdhWFJ2WWdvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUVKdmVDQnRkWE4wSUdoaGRtVWdkbUZzZFdVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZiV1Z5YTJ4bExXRmtaSEpsYzNNdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNU9Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJSEpsWVdSdmJteDVPaUIwY25WbElIMHBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OWlZWE5sTFdOdmJuUnlZV04wY3k5MWNHZHlZV1JsWVdKc1pTNTBjem82UVd0cGRHRkNZWE5sUTI5dWRISmhZM1F1ZFhCa1lYUmxRV3RwZEdGRVFVOWJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AxY0dSaGRHVkJhMmwwWVVSQlR6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTlpWVhObExXTnZiblJ5WVdOMGN5OTFjR2R5WVdSbFlXSnNaUzUwY3pveU5Rb2dJQ0FnTHk4Z2RYQmtZWFJsUVd0cGRHRkVRVThvWVd0cGRHRkVRVTg2SUVGd2NHeHBZMkYwYVc5dUtUb2dkbTlwWkNCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMkpoYzJVdFkyOXVkSEpoWTNSekwzVndaM0poWkdWaFlteGxMblJ6T2pJMkNpQWdJQ0F2THlCc2IyZG5aV1JCYzNObGNuUW9WSGh1TG5ObGJtUmxjaUE5UFQwZ2RHaHBjeTVuWlhSQmEybDBZVVJCVDFkaGJHeGxkQ2dwTG1Ga1pISmxjM01zSUdWeWNrNXZkRUZyYVhSaFJHRnZLUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMkpoYzJVdFkyOXVkSEpoWTNSekwzVndaM0poWkdWaFlteGxMblJ6T2pFNUNpQWdJQ0F2THlCamIyNXpkQ0JiZDJGc2JHVjBTVVJkSUQwZ2IzQXVRWEJ3UjJ4dlltRnNMbWRsZEVWNFZXbHVkRFkwS0hSb2FYTXVZV3RwZEdGRVFVOHVkbUZzZFdVc0lFSjVkR1Z6S0VGcmFYUmhSRUZQUjJ4dlltRnNVM1JoZEdWTFpYbHpWMkZzYkdWMEtTa0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZZbUZ6WlMxamIyNTBjbUZqZEhNdmRYQm5jbUZrWldGaWJHVXVkSE02TVRZS0lDQWdJQzh2SUdGcmFYUmhSRUZQSUQwZ1IyeHZZbUZzVTNSaGRHVThRWEJ3YkdsallYUnBiMjQrS0hzZ2EyVjVPaUJIYkc5aVlXeFRkR0YwWlV0bGVVRnJhWFJoUkVGUElIMHBDaUFnSUNCaWVYUmxZMTh5SUM4dklDSmhhMmwwWVY5a1lXOGlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12WW1GelpTMWpiMjUwY21GamRITXZkWEJuY21Ga1pXRmliR1V1ZEhNNk1Ua0tJQ0FnSUM4dklHTnZibk4wSUZ0M1lXeHNaWFJKUkYwZ1BTQnZjQzVCY0hCSGJHOWlZV3d1WjJWMFJYaFZhVzUwTmpRb2RHaHBjeTVoYTJsMFlVUkJUeTUyWVd4MVpTd2dRbmwwWlhNb1FXdHBkR0ZFUVU5SGJHOWlZV3hUZEdGMFpVdGxlWE5YWVd4c1pYUXBLUW9nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUhCMWMyaGllWFJsY3lBaWQyRnNiR1YwSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUhCdmNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMkpoYzJVdFkyOXVkSEpoWTNSekwzVndaM0poWkdWaFlteGxMblJ6T2pJMkNpQWdJQ0F2THlCc2IyZG5aV1JCYzNObGNuUW9WSGh1TG5ObGJtUmxjaUE5UFQwZ2RHaHBjeTVuWlhSQmEybDBZVVJCVDFkaGJHeGxkQ2dwTG1Ga1pISmxjM01zSUdWeWNrNXZkRUZyYVhSaFJHRnZLUW9nSUNBZ1lYQndYM0JoY21GdGMxOW5aWFFnUVhCd1FXUmtjbVZ6Y3dvZ0lDQWdZWE56WlhKMElDOHZJR0Z3Y0d4cFkyRjBhVzl1SUdWNGFYTjBjd29nSUNBZ1BUMEtJQ0FnSUdKdWVpQjFjR1JoZEdWQmEybDBZVVJCVDE5aFpuUmxjbDloYzNObGNuUkFNd29nSUNBZ2NIVnphR0o1ZEdWeklDSkZVbEk2WlhKeVRtUmhieUlLSUNBZ0lHeHZad29nSUNBZ1pYSnlJQzh2SUVWU1VqcGxjbkpPWkdGdkNncDFjR1JoZEdWQmEybDBZVVJCVDE5aFpuUmxjbDloYzNObGNuUkFNem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5aVlYTmxMV052Ym5SeVlXTjBjeTkxY0dkeVlXUmxZV0pzWlM1MGN6b3hOZ29nSUNBZ0x5OGdZV3RwZEdGRVFVOGdQU0JIYkc5aVlXeFRkR0YwWlR4QmNIQnNhV05oZEdsdmJqNG9leUJyWlhrNklFZHNiMkpoYkZOMFlYUmxTMlY1UVd0cGRHRkVRVThnZlNrS0lDQWdJR0o1ZEdWalh6SWdMeThnSW1GcmFYUmhYMlJoYnlJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OWlZWE5sTFdOdmJuUnlZV04wY3k5MWNHZHlZV1JsWVdKc1pTNTBjem95TndvZ0lDQWdMeThnZEdocGN5NWhhMmwwWVVSQlR5NTJZV3gxWlNBOUlHRnJhWFJoUkVGUENpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMkpoYzJVdFkyOXVkSEpoWTNSekwzVndaM0poWkdWaFlteGxMblJ6T2pJMUNpQWdJQ0F2THlCMWNHUmhkR1ZCYTJsMFlVUkJUeWhoYTJsMFlVUkJUem9nUVhCd2JHbGpZWFJwYjI0cE9pQjJiMmxrSUhzS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwyMWxjbXRzWlMxaFpHUnlaWE56TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2sxbGNtdHNaVUZrWkhKbGMzTkhZWFJsTG1OdmMzUW9ZWEpuY3pvZ1lubDBaWE1wSUMwK0lIVnBiblEyTkRvS2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl0WlhKcmJHVXRZV1JrY21WemN5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcE5aWEpyYkdWQlpHUnlaWE56UjJGMFpTNWpiM04wT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXRaWEpyYkdVdFlXUmtjbVZ6Y3k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVNENpQWdJQ0F2THlCamIzTjBLR0Z5WjNNNklHSjVkR1Z6S1RvZ2RXbHVkRFkwSUhzS0lDQWdJSEJ5YjNSdklERWdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5dFpYSnJiR1V0WVdSa2NtVnpjeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalU1Q2lBZ0lDQXZMeUJzYjJkblpXUkJjM05sY25Rb1lYSm5jeTVzWlc1bmRHZ2dQajBnVFdsdVVtVm5hWE4wWlhKQmNtZHpUR1Z1WjNSb0xDQmxjbkpKYm5aaGJHbGtRWEpuUTI5MWJuUXBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUd4bGJnb2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb2FXNTBJRE0xQ2lBZ0lDQStQUW9nSUNBZ1ltNTZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmJXVnlhMnhsTFdGa1pISmxjM012WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VFdWeWEyeGxRV1JrY21WemMwZGhkR1V1WTI5emRGOWhablJsY2w5aGMzTmxjblJBTWdvZ0lDQWdZbmwwWldOZk15QXZMeUFpUlZKU09tVnlja2xoY21jaUNpQWdJQ0JzYjJjS0lDQWdJR1Z5Y2lBdkx5QkZVbEk2WlhKeVNXRnlad29LYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXRaWEpyYkdVdFlXUmtjbVZ6Y3k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwTlpYSnJiR1ZCWkdSeVpYTnpSMkYwWlM1amIzTjBYMkZtZEdWeVgyRnpjMlZ5ZEVBeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl0WlhKcmJHVXRZV1JrY21WemN5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWXdDaUFnSUNBdkx5QnlaWFIxY200Z1RXbHVUV1YwWVUxbGNtdHNaVkpsWjJsemRISjVUVUpTSUNzZ0tFSnZlRU52YzNSUVpYSkNiM2dnS2lBb1lYSm5jeTVzWlc1bmRHZ2dMU0F6TWlrcENpQWdJQ0JwYm5Salh6TWdMeThnTXpJS0lDQWdJQzBLSUNBZ0lIQjFjMmhwYm5RZ01qVXdNQW9nSUNBZ0tnb2dJQ0FnY0hWemFHbHVkQ0F4T0RVd01Bb2dJQ0FnS3dvZ0lDQWdjbVYwYzNWaUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFS0lDQWdJSEpsZEhWeWJnbz0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQVFBQ0lDWUZCQlVmZkhVUGNtVm5hWE4wY25sZlkzVnljMjl5Q1dGcmFYUmhYMlJoYnd0RlVsSTZaWEp5U1dGeVp3dEZVbEk2WlhKeVNYQmhlVEVZUUFCRUtTSm5nZ0lTY21WbmFYTjBjbUYwYVc5dVgzTm9ZWEJsRUNoaFpHUnlaWE56TEhOMGNtbHVaeWxuZ2dJTFkyaGxZMnRmYzJoaGNHVUtZbmwwWlZzek1sMWJYV2N4R1JSRU1SaEJBRUtDQ0FReW53VHVCSGU3ZWJrRWJnUDFDZ1M3dUtLc0JMUlZzRjRFa05UNlhRUXo2U3lVQklWTjdlQTJHZ0NPQ0FBL0FGa0F0QUZGQVdZQmV3R1dBQUVBSWtPQUJNMmExbjQyR2dDT0FRQUJBRFlhQVVraldTUUlTd0VWRWtSWEFnQTJHZ0pKRllFSUVrUVhnQWQyWlhKemFXOXVUd0puS2t4bktTSm5Ja00yR2dGSkkxa2tDRXNCRlJKRVZ3SUFpQUY1RmloTVVMQWlRekVXSWdsSk9CQWlFa1EyR2dGSkkxa2tDRXNCRlJKRVZ3SUFTUldCSXc5QUFBTXJzQUJMQVRnSE1nb1NRQUFFSndTd0FFdzRDRXNCaUFFM0VrQUFCQ2NFc0FBaktXVkVTU0lJS1V4bkZrbThTRWxQQXI4b1RGQ3dJa00yR2dGSkZTVVNSRFlhQWtrVmdRZ1NSQmMyR2dOSkkxa2tDRXNCRlJKRVZ3SUFTUlVrRDBBQUF5dXdBRXdXU1NNbHVrc0JnU0lrdWhja0NFOENnU0pQQXJxeFR3TUJBU01XSXlwbFJJQURZV0ZzWlVpQlNGdXlHSUFFSy9QTVdySWFUd095R2s4Q3NocE1zaHBNc2hxeUdvRUdzaEFqc2dHenRENUpWd1FBVEZjQUJDZ1NSRWtWSWhKRUtFeFFzQ0pETmhvQlNSVkxBU1ZaU1lFaUVrUkxBa3hMQWxJaldZRWtDQkpFS0V4UXNDSkROaG9CU1NOWkpRc2tDRXNCRlJKRUtFeFFzQ0pETmhvQlNSV0JDQkpFRnhhK1JFa1ZGbGNHQWt4UUtFeFFzQ0pETmhvQlNSV0JDQkpFRnpFQUl5cGxSSUFHZDJGc2JHVjBaVWh5Q0VRU1FBQVBnQXRGVWxJNlpYSnlUbVJoYjdBQUtreG5Ja09LQVFHTC94VkpnU01QUUFBREs3QUFKUW1CeEJNTGdjU1FBUWlKIiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6MTAsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
