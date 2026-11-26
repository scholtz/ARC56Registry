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

namespace Arc56.Generated.akita_protocol.akita_sc.AssetGate_a1dea6e2
{


    public class AssetGateProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public AssetGateProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class AssetGateRegistryInfo : AVMObjectType
            {
                public ulong Asset { get; set; }

                public byte Op { get; set; }

                public ulong Value { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAsset = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAsset.From(Asset);
                    ret.AddRange(vAsset.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vOp.From(Op);
                    ret.AddRange(vOp.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vValue = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vValue.From(Value);
                    ret.AddRange(vValue.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static AssetGateRegistryInfo Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new AssetGateRegistryInfo();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAsset = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAsset.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAsset = vAsset.ToValue();
                    if (valueAsset is ulong vAssetValue) { ret.Asset = vAssetValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vOp.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOp = vOp.ToValue();
                    if (valueOp is byte vOpValue) { ret.Op = vOpValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vValue = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vValue.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueValue = vValue.ToValue();
                    if (valueValue is ulong vValueValue) { ret.Value = vValueValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as AssetGateRegistryInfo);
                }
                public bool Equals(AssetGateRegistryInfo? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(AssetGateRegistryInfo left, AssetGateRegistryInfo right)
                {
                    return EqualityComparer<AssetGateRegistryInfo>.Default.Equals(left, right);
                }
                public static bool operator !=(AssetGateRegistryInfo left, AssetGateRegistryInfo right)
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
        /// <param name="shape"> AssetGateRegistryInfo</param>
        public async Task<Structs.AssetGateRegistryInfo> GetRegistrationShape(Structs.AssetGateRegistryInfo shape, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 180, 212, 22, 114 };

            var result = await base.CallApp(new List<object> { abiHandle, shape }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.AssetGateRegistryInfo.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetRegistrationShape_Transactions(Structs.AssetGateRegistryInfo shape, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 180, 212, 22, 114 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQXNzZXRHYXRlIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkFzc2V0R2F0ZVJlZ2lzdHJ5SW5mbyI6W3sibmFtZSI6ImFzc2V0IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6Im9wIiwidHlwZSI6InVpbnQ4In0seyJuYW1lIjoidmFsdWUiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2ZXJzaW9uIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJha2l0YURBTyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjb3N0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFyZ3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWdpc3RlciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtYnJQYXltZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcmdzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2hlY2siLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhbGxlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVnaXN0cnlJRCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXJncyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRSZWdpc3RyYXRpb25TaGFwZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIodWludDY0LHVpbnQ4LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJBc3NldEdhdGVSZWdpc3RyeUluZm8iLCJuYW1lIjoic2hhcGUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50OCx1aW50NjQpIiwic3RydWN0IjoiQXNzZXRHYXRlUmVnaXN0cnlJbmZvIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0RW50cnkiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVnaXN0cnlJRCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidXBkYXRlQWtpdGFEQU8iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWtpdGFEQU8iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoib3BVcCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MiwiYnl0ZXMiOjN9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzQ2Myw2NDVdLCJlcnJvck1lc3NhZ2UiOiJCb3ggbXVzdCBoYXZlIHZhbHVlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzkzXSwiZXJyb3JNZXNzYWdlIjoiRVJSOmVyckJvcHIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMjQsNDYwXSwiZXJyb3JNZXNzYWdlIjoiRVJSOmVycklhcmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMzgsMzUzXSwiZXJyb3JNZXNzYWdlIjoiRVJSOmVycklwYXkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3MDZdLCJlcnJvck1lc3NhZ2UiOiJFUlI6ZXJyTmRhbyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY4N10sImVycm9yTWVzc2FnZSI6ImFwcGxpY2F0aW9uIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM5Nyw2NzRdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBHbG9iYWxTdGF0ZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMTksMjYxLDMwMiw0NDJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMjYsMjY3LDMwOSw0NDldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDI3XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIzNyw0MzUsNjQxLDY2N10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYyN10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBzbWFydF9jb250cmFjdHMvZ2F0ZXMvc3ViLWdhdGVzL2Fzc2V0L2NvbnRyYWN0LmFsZ28udHM6OkFzc2V0R2F0ZVJlZ2lzdHJ5SW5mbyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI5NV0sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgcGF5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNU0F3SURJZ09Bb2dJQ0FnWW5sMFpXTmliRzlqYXlBd2VERTFNV1kzWXpjMUlDSnlaV2RwYzNSeWVWOWpkWEp6YjNJaUlDSmhhMmwwWVY5a1lXOGlJQ0lpSUNKRlVsSTZaWEp5U1dGeVp5SWdJa1ZTVWpwbGNuSkpjR0Y1SWdvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKdWVpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5aGMzTmxkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakkzQ2lBZ0lDQXZMeUJ5WldkcGMzUnllVU4xY25OdmNpQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvZXlCcGJtbDBhV0ZzVm1Gc2RXVTZJREVzSUd0bGVUb2dSMkYwWlVkc2IySmhiRk4wWVhSbFMyVjVVbVZuYVhOMGNubERkWEp6YjNJZ2ZTa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0luSmxaMmx6ZEhKNVgyTjFjbk52Y2lJS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OWhjM05sZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNd0NpQWdJQ0F2THlCeVpXZHBjM1J5WVhScGIyNVRhR0Z3WlNBOUlFZHNiMkpoYkZOMFlYUmxQSE4wY21sdVp6NG9leUJwYm1sMGFXRnNWbUZzZFdVNklDY29kV2x1ZERZMExIVnBiblE0TEhWcGJuUTJOQ2tuTENCclpYazZJRWRoZEdWSGJHOWlZV3hUZEdGMFpVdGxlVkpsWjJsemRISmhkR2x2YmxOb1lYQmxJSDBwQ2lBZ0lDQndkWE5vWW5sMFpYTnpJQ0p5WldkcGMzUnlZWFJwYjI1ZmMyaGhjR1VpSUNJb2RXbHVkRFkwTEhWcGJuUTRMSFZwYm5RMk5Da2lDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5aGMzTmxkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak15Q2lBZ0lDQXZMeUJqYUdWamExTm9ZWEJsSUQwZ1IyeHZZbUZzVTNSaGRHVThjM1J5YVc1blBpaDdJR2x1YVhScFlXeFdZV3gxWlRvZ0p5Y3NJR3RsZVRvZ1IyRjBaVWRzYjJKaGJGTjBZWFJsUzJWNVEyaGxZMnRUYUdGd1pTQjlLUW9nSUNBZ2NIVnphR0o1ZEdWeklDSmphR1ZqYTE5emFHRndaU0lLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2dwdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12WVhOelpYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNd29nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUVGemMyVjBSMkYwWlNCbGVIUmxibVJ6SUVGcmFYUmhRbUZ6WlVOdmJuUnlZV04wSUhzS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSjZJRzFoYVc1ZlkzSmxZWFJsWDA1dlQzQkFNVE1LSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGd6TWpsbU1EUmxaU0F3ZURjM1ltSTNPV0k1SURCNE5tVXdNMlkxTUdFZ01IaGlOR1EwTVRZM01pQXdlRGt3WkRSbVlUVmtJREI0TXpObE9USmpPVFFnTUhnNE5UUmtaV1JsTUNBdkx5QnRaWFJvYjJRZ0ltTnZjM1FvWW5sMFpWdGRLWFZwYm5RMk5DSXNJRzFsZEdodlpDQWljbVZuYVhOMFpYSW9jR0Y1TEdKNWRHVmJYU2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbU5vWldOcktHRmtaSEpsYzNNc2RXbHVkRFkwTEdKNWRHVmJYU2xpYjI5c0lpd2diV1YwYUc5a0lDSm5aWFJTWldkcGMzUnlZWFJwYjI1VGFHRndaU2dvZFdsdWREWTBMSFZwYm5RNExIVnBiblEyTkNrcEtIVnBiblEyTkN4MWFXNTBPQ3gxYVc1ME5qUXBJaXdnYldWMGFHOWtJQ0puWlhSRmJuUnllU2gxYVc1ME5qUXBZbmwwWlZ0ZElpd2diV1YwYUc5a0lDSjFjR1JoZEdWQmEybDBZVVJCVHloMWFXNTBOalFwZG05cFpDSXNJRzFsZEdodlpDQWliM0JWY0NncGRtOXBaQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUdOdmMzUWdjbVZuYVhOMFpYSWdZMmhsWTJzZ1oyVjBVbVZuYVhOMGNtRjBhVzl1VTJoaGNHVWdaMlYwUlc1MGNua2dkWEJrWVhSbFFXdHBkR0ZFUVU4Z2JXRnBibDl2Y0ZWd1gzSnZkWFJsUURFeENpQWdJQ0JsY25JS0NtMWhhVzVmYjNCVmNGOXliM1YwWlVBeE1Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTlpWVhObExXTnZiblJ5WVdOMGN5OTFjR2R5WVdSbFlXSnNaUzUwY3pvek1Bb2dJQ0FnTHk4Z2IzQlZjQ2dwT2lCMmIybGtJSHNnZlFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlqY21WaGRHVmZUbTlQY0VBeE16b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12WVhOelpYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNd29nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUVGemMyVjBSMkYwWlNCbGVIUmxibVJ6SUVGcmFYUmhRbUZ6WlVOdmJuUnlZV04wSUhzS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZUdOa09XRmtOamRsSUM4dklHMWxkR2h2WkNBaVkzSmxZWFJsS0hOMGNtbHVaeXgxYVc1ME5qUXBkbTlwWkNJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHTnlaV0YwWlFvZ0lDQWdaWEp5Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5aGMzTmxkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBCYzNObGRFZGhkR1V1WTNKbFlYUmxXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWTNKbFlYUmxPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5aGMzTmxkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamMwQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ2IyNURjbVZoZEdVNklDZHlaWEYxYVhKbEp5QjlLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTlpWVhObExXTnZiblJ5WVdOMGN5OTFjR2R5WVdSbFlXSnNaUzUwY3pveE5Bb2dJQ0FnTHk4Z2RtVnljMmx2YmlBOUlFZHNiMkpoYkZOMFlYUmxQSE4wY21sdVp6NG9leUJyWlhrNklFZHNiMkpoYkZOMFlYUmxTMlY1Vm1WeWMybHZiaUI5S1FvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0oyWlhKemFXOXVJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5aGMzTmxkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamMyQ2lBZ0lDQXZMeUIwYUdsekxuWmxjbk5wYjI0dWRtRnNkV1VnUFNCMlpYSnphVzl1Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12WW1GelpTMWpiMjUwY21GamRITXZkWEJuY21Ga1pXRmliR1V1ZEhNNk1UWUtJQ0FnSUM4dklHRnJhWFJoUkVGUElEMGdSMnh2WW1Gc1UzUmhkR1U4UVhCd2JHbGpZWFJwYjI0K0tIc2dhMlY1T2lCSGJHOWlZV3hUZEdGMFpVdGxlVUZyYVhSaFJFRlBJSDBwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0poYTJsMFlWOWtZVzhpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwyRnpjMlYwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnpjS0lDQWdJQzh2SUhSb2FYTXVZV3RwZEdGRVFVOHVkbUZzZFdVZ1BTQkJjSEJzYVdOaGRHbHZiaWhoYTJsMFlVUkJUeWtLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwyRnpjMlYwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnpRS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2V5QnZia055WldGMFpUb2dKM0psY1hWcGNtVW5JSDBwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5aGMzTmxkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBCYzNObGRFZGhkR1V1WTI5emRGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbU52YzNRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMMkZ6YzJWMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9ESUtJQ0FnSUM4dklHTnZjM1FvWVhKbmN6b2dZbmwwWlhNcE9pQjFhVzUwTmpRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUNzS0lDQWdJSE4zWVhBS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd4TlRGbU4yTTNOVEF3TURBd01EQXdNREF3TURNd1pEUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZZWE56WlhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlFYTnpaWFJIWVhSbExuSmxaMmx6ZEdWeVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjbVZuYVhOMFpYSTZDaUFnSUNCaWVYUmxZMTh6SUM4dklDSWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDJGemMyVjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPRFlLSUNBZ0lDOHZJSEpsWjJsemRHVnlLRzFpY2xCaGVXMWxiblE2SUdkMGVHNHVVR0Y1YldWdWRGUjRiaXdnWVhKbmN6b2dZbmwwWlhNcE9pQjFhVzUwTmpRZ2V3b2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0F0Q2lBZ0lDQmtkWEFLSUNBZ0lHZDBlRzV6SUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdjR0Y1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklIUnlZVzV6WVdOMGFXOXVJSFI1Y0dVZ2FYTWdjR0Y1Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEJ1SURJS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ1pIVndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDJGemMyVjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPRGNLSUNBZ0lDOHZJR3h2WjJkbFpFRnpjMlZ5ZENoaGNtZHpMbXhsYm1kMGFDQTlQVDBnUVhOelpYUkhZWFJsVW1WbmFYTjBjbmxKYm1adlFubDBaVXhsYm1kMGFDd2daWEp5U1c1MllXeHBaRUZ5WjBOdmRXNTBLUW9nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURFM0NpQWdJQ0E5UFFvZ0lDQWdZbTU2SUhKbFoybHpkR1Z5WDJGbWRHVnlYMkZ6YzJWeWRFQXpDaUFnSUNCaWVYUmxZeUEwSUM4dklDSkZVbEk2WlhKeVNXRnlaeUlLSUNBZ0lHeHZad29nSUNBZ1pYSnlJQzh2SUVWU1VqcGxjbkpKWVhKbkNncHlaV2RwYzNSbGNsOWhablJsY2w5aGMzTmxjblJBTXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZZWE56WlhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNE9Bb2dJQ0FnTHk4Z2JHOW5aMlZrUVhOelpYSjBLRzFpY2xCaGVXMWxiblF1Y21WalpXbDJaWElnUFQwOUlFZHNiMkpoYkM1amRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56TENCbGNuSkpiblpoYkdsa1VHRjViV1Z1ZENrS0lDQWdJR1JwWnlBeUNpQWdJQ0JuZEhodWN5QlNaV05sYVhabGNnb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUQwOUNpQWdJQ0JpYm5vZ2NtVm5hWE4wWlhKZllXWjBaWEpmWVhOelpYSjBRRFVLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdJa1ZTVWpwbGNuSkpjR0Y1SWdvZ0lDQWdiRzluQ2lBZ0lDQmxjbklnTHk4Z1JWSlNPbVZ5Y2tsd1lYa0tDbkpsWjJsemRHVnlYMkZtZEdWeVgyRnpjMlZ5ZEVBMU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTloYzNObGRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qZzVDaUFnSUNBdkx5QnNiMmRuWldSQmMzTmxjblFvYldKeVVHRjViV1Z1ZEM1aGJXOTFiblFnUFQwOUlFRnpjMlYwUjJGMFpWSmxaMmx6ZEhKNVRVSlNMQ0JsY25KSmJuWmhiR2xrVUdGNWJXVnVkQ2tLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWjNSNGJuTWdRVzF2ZFc1MENpQWdJQ0J3ZFhOb2FXNTBJREV5TlRBd0NpQWdJQ0E5UFFvZ0lDQWdZbTU2SUhKbFoybHpkR1Z5WDJGbWRHVnlYMkZ6YzJWeWRFQTNDaUFnSUNCaWVYUmxZeUExSUM4dklDSkZVbEk2WlhKeVNYQmhlU0lLSUNBZ0lHeHZad29nSUNBZ1pYSnlJQzh2SUVWU1VqcGxjbkpKY0dGNUNncHlaV2RwYzNSbGNsOWhablJsY2w5aGMzTmxjblJBTnpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZZWE56WlhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNU1nb2dJQ0FnTHk4Z2JHOW5aMlZrUVhOelpYSjBLSEJoY21GdGN5NXZjQzVoYzFWcGJuUTJOQ2dwSUQ0OUlFVnhkV0ZzTG1GelZXbHVkRFkwS0NrZ0ppWWdjR0Z5WVcxekxtOXdMbUZ6VldsdWREWTBLQ2tnUEQwZ1IzSmxZWFJsY2xSb1lXNVBja1Z4ZFdGc1ZHOHVZWE5WYVc1ME5qUW9LU3dnWlhKeVFtRmtUM0JsY21GMGFXOXVLUW9nSUNBZ2MzZGhjQW9nSUNBZ2NIVnphR2x1ZENBeE1Bb2dJQ0FnWjJWMFlubDBaUW9nSUNBZ1pIVndDaUFnSUNCaWRYSjVJRE1LSUNBZ0lIQjFjMmhwYm5RZ01UQUtJQ0FnSUQ0OUNpQWdJQ0JpZWlCeVpXZHBjM1JsY2w5aWIyOXNYMlpoYkhObFFERXdDaUFnSUNCa2FXY2dNUW9nSUNBZ2NIVnphR2x1ZENBMk1Bb2dJQ0FnUEQwS0lDQWdJR0o2SUhKbFoybHpkR1Z5WDJKdmIyeGZabUZzYzJWQU1UQUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENncHlaV2RwYzNSbGNsOWliMjlzWDIxbGNtZGxRREV4T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OWhjM05sZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2preUNpQWdJQ0F2THlCc2IyZG5aV1JCYzNObGNuUW9jR0Z5WVcxekxtOXdMbUZ6VldsdWREWTBLQ2tnUGowZ1JYRjFZV3d1WVhOVmFXNTBOalFvS1NBbUppQndZWEpoYlhNdWIzQXVZWE5WYVc1ME5qUW9LU0E4UFNCSGNtVmhkR1Z5VkdoaGJrOXlSWEYxWVd4VWJ5NWhjMVZwYm5RMk5DZ3BMQ0JsY25KQ1lXUlBjR1Z5WVhScGIyNHBDaUFnSUNCaWJub2djbVZuYVhOMFpYSmZZV1owWlhKZllYTnpaWEowUURFekNpQWdJQ0J3ZFhOb1lubDBaWE1nSWtWU1VqcGxjbkpDYjNCeUlnb2dJQ0FnYkc5bkNpQWdJQ0JsY25JZ0x5OGdSVkpTT21WeWNrSnZjSElLQ25KbFoybHpkR1Z5WDJGbWRHVnlYMkZ6YzJWeWRFQXhNem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdllYTnpaWFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTVFvZ0lDQWdMeThnWTI5dWMzUWdhV1FnUFNCMGFHbHpMbkpsWjJsemRISjVRM1Z5YzI5eUxuWmhiSFZsQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5aGMzTmxkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakkzQ2lBZ0lDQXZMeUJ5WldkcGMzUnllVU4xY25OdmNpQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvZXlCcGJtbDBhV0ZzVm1Gc2RXVTZJREVzSUd0bGVUb2dSMkYwWlVkc2IySmhiRk4wWVhSbFMyVjVVbVZuYVhOMGNubERkWEp6YjNJZ2ZTa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0luSmxaMmx6ZEhKNVgyTjFjbk52Y2lJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZZWE56WlhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME1Rb2dJQ0FnTHk4Z1kyOXVjM1FnYVdRZ1BTQjBhR2x6TG5KbFoybHpkSEo1UTNWeWMyOXlMblpoYkhWbENpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OWhjM05sZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pReUNpQWdJQ0F2THlCMGFHbHpMbkpsWjJsemRISjVRM1Z5YzI5eUxuWmhiSFZsSUNzOUlERUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQ3NLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdllYTnpaWFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TndvZ0lDQWdMeThnY21WbmFYTjBjbmxEZFhKemIzSWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0hzZ2FXNXBkR2xoYkZaaGJIVmxPaUF4TENCclpYazZJRWRoZEdWSGJHOWlZV3hUZEdGMFpVdGxlVkpsWjJsemRISjVRM1Z5YzI5eUlIMHBDaUFnSUNCaWVYUmxZMTh4SUM4dklDSnlaV2RwYzNSeWVWOWpkWEp6YjNJaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMMkZ6YzJWMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5ESUtJQ0FnSUM4dklIUm9hWE11Y21WbmFYTjBjbmxEZFhKemIzSXVkbUZzZFdVZ0t6MGdNUW9nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdllYTnpaWFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem81TkFvZ0lDQWdMeThnZEdocGN5NXlaV2RwYzNSeWVTaHBaQ2t1ZG1Gc2RXVWdQU0JqYkc5dVpTaHdZWEpoYlhNcENpQWdJQ0JwZEc5aUNpQWdJQ0JrZFhBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OWhjM05sZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pnMkNpQWdJQ0F2THlCeVpXZHBjM1JsY2lodFluSlFZWGx0Wlc1ME9pQm5kSGh1TGxCaGVXMWxiblJVZUc0c0lHRnlaM002SUdKNWRHVnpLVG9nZFdsdWREWTBJSHNLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ25KbFoybHpkR1Z5WDJKdmIyeGZabUZzYzJWQU1UQTZDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWWlCeVpXZHBjM1JsY2w5aWIyOXNYMjFsY21kbFFERXhDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTloYzNObGRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcEJjM05sZEVkaGRHVXVZMmhsWTJ0YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGphR1ZqYXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZZWE56WlhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNU9Bb2dJQ0FnTHk4Z1kyaGxZMnNvWTJGc2JHVnlPaUJCWTJOdmRXNTBMQ0J5WldkcGMzUnllVWxFT2lCMWFXNTBOalFzSUdGeVozTTZJR0o1ZEdWektUb2dZbTl2YkdWaGJpQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0F6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OWhjM05sZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2prNUNpQWdJQ0F2THlCc2IyZG5aV1JCYzNObGNuUW9ZWEpuY3k1c1pXNW5kR2dnUFQwOUlEQXNJR1Z5Y2tsdWRtRnNhV1JCY21kRGIzVnVkQ2tLSUNBZ0lHeGxiZ29nSUNBZ1lub2dZMmhsWTJ0ZllXWjBaWEpmWVhOelpYSjBRRE1LSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJa1ZTVWpwbGNuSkpZWEpuSWdvZ0lDQWdiRzluQ2lBZ0lDQmxjbklnTHk4Z1JWSlNPbVZ5Y2tsaGNtY0tDbU5vWldOclgyRm1kR1Z5WDJGemMyVnlkRUF6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OWhjM05sZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFd01Bb2dJQ0FnTHk4Z1kyOXVjM1FnZXlCaGMzTmxkQ3dnYjNBc0lIWmhiSFZsSUgwZ1BTQmpiRzl1WlNoMGFHbHpMbkpsWjJsemRISjVLSEpsWjJsemRISjVTVVFwTG5aaGJIVmxLUW9nSUNBZ2FYUnZZZ29nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZWE56WlhKMElDOHZJRUp2ZUNCdGRYTjBJR2hoZG1VZ2RtRnNkV1VLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHTnZkbVZ5SURNS0lDQWdJR1IxY0FvZ0lDQWdaWGgwY21GamRDQTRJREVLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSEIxYzJocGJuUWdPUW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHTnZkbVZ5SURNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZZWE56WlhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU1Rb2dJQ0FnTHk4Z1kyOXVjM1FnVzJGc1oyOWRJRDBnUVdOamRGQmhjbUZ0Y3k1aFkyTjBRbUZzWVc1alpTaDFjMlZ5S1FvZ0lDQWdaR2xuSURJS0lDQWdJR0ZqWTNSZmNHRnlZVzF6WDJkbGRDQkJZMk4wUW1Gc1lXNWpaUW9nSUNBZ2NHOXdDaUFnSUNCemQyRndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDJGemMyVjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVE1LSUNBZ0lDOHZJR2xtSUNoaGMzTmxkQ0FoUFQwZ01Da2dld29nSUNBZ1ltNTZJR05vWldOclgybG1YMkp2WkhsQU5Rb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQndiM0FLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnY0c5d0NncGphR1ZqYTE5aFpuUmxjbDlwWmw5bGJITmxRRGc2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwyRnpjMlYwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpJS0lDQWdJQzh2SUdOaGMyVWdSWEYxWVd3NklISmxkSFZ5YmlCaVlXeGhibU5sSUQwOVBTQjJZV3gxWlFvZ0lDQWdaR2xuSURFS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURCaENpQWdJQ0E5UFFvZ0lDQWdZbm9nWTJobFkydGZZV1owWlhKZmFXWmZaV3h6WlVBeE1Bb2dJQ0FnWW5WeWVTQXhDaUFnSUNBOVBRb0tZMmhsWTJ0ZllXWjBaWEpmYVc1c2FXNWxaRjl6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwyRnpjMlYwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2tGemMyVjBSMkYwWlM1aGMzTmxkRWRoZEdWQU1qRTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDJGemMyVjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPVGdLSUNBZ0lDOHZJR05vWldOcktHTmhiR3hsY2pvZ1FXTmpiM1Z1ZEN3Z2NtVm5hWE4wY25sSlJEb2dkV2x1ZERZMExDQmhjbWR6T2lCaWVYUmxjeWs2SUdKdmIyeGxZVzRnZXdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhObGRHSnBkQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LWTJobFkydGZZV1owWlhKZmFXWmZaV3h6WlVBeE1Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12WVhOelpYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJNd29nSUNBZ0x5OGdZMkZ6WlNCT2IzUkZjWFZoYkRvZ2NtVjBkWEp1SUdKaGJHRnVZMlVnSVQwOUlIWmhiSFZsQ2lBZ0lDQmthV2NnTVFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TVRRS0lDQWdJRDA5Q2lBZ0lDQmllaUJqYUdWamExOWhablJsY2w5cFpsOWxiSE5sUURFeUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUNFOUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMMkZ6YzJWMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UQXhDaUFnSUNBdkx5QnlaWFIxY200Z2RHaHBjeTVoYzNObGRFZGhkR1VvWTJGc2JHVnlMQ0JoYzNObGRDd2diM0FzSUhaaGJIVmxLUW9nSUNBZ1lpQmphR1ZqYTE5aFpuUmxjbDlwYm14cGJtVmtYM050WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdllYTnpaWFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82UVhOelpYUkhZWFJsTG1GemMyVjBSMkYwWlVBeU1Rb0tZMmhsWTJ0ZllXWjBaWEpmYVdaZlpXeHpaVUF4TWpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZZWE56WlhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk5Bb2dJQ0FnTHk4Z1kyRnpaU0JNWlhOelZHaGhiam9nY21WMGRYSnVJR0poYkdGdVkyVWdQQ0IyWVd4MVpRb2dJQ0FnWkdsbklERUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VERmxDaUFnSUNBOVBRb2dJQ0FnWW5vZ1kyaGxZMnRmWVdaMFpYSmZhV1pmWld4elpVQXhOQW9nSUNBZ1luVnllU0F4Q2lBZ0lDQStDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDJGemMyVjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEF4Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdkR2hwY3k1aGMzTmxkRWRoZEdVb1kyRnNiR1Z5TENCaGMzTmxkQ3dnYjNBc0lIWmhiSFZsS1FvZ0lDQWdZaUJqYUdWamExOWhablJsY2w5cGJteHBibVZrWDNOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZZWE56WlhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlFYTnpaWFJIWVhSbExtRnpjMlYwUjJGMFpVQXlNUW9LWTJobFkydGZZV1owWlhKZmFXWmZaV3h6WlVBeE5Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12WVhOelpYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJOUW9nSUNBZ0x5OGdZMkZ6WlNCTVpYTnpWR2hoYms5eVJYRjFZV3hVYnpvZ2NtVjBkWEp1SUdKaGJHRnVZMlVnUEQwZ2RtRnNkV1VLSUNBZ0lHUnBaeUF4Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd5T0FvZ0lDQWdQVDBLSUNBZ0lHSjZJR05vWldOclgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRZS0lDQWdJR0oxY25rZ01Rb2dJQ0FnUGowS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZZWE56WlhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1ERUtJQ0FnSUM4dklISmxkSFZ5YmlCMGFHbHpMbUZ6YzJWMFIyRjBaU2hqWVd4c1pYSXNJR0Z6YzJWMExDQnZjQ3dnZG1Gc2RXVXBDaUFnSUNCaUlHTm9aV05yWDJGbWRHVnlYMmx1YkdsdVpXUmZjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5aGMzTmxkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBCYzNObGRFZGhkR1V1WVhOelpYUkhZWFJsUURJeENncGphR1ZqYTE5aFpuUmxjbDlwWmw5bGJITmxRREUyT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OWhjM05sZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZMkNpQWdJQ0F2THlCallYTmxJRWR5WldGMFpYSlVhR0Z1T2lCeVpYUjFjbTRnWW1Gc1lXNWpaU0ErSUhaaGJIVmxDaUFnSUNCa2FXY2dNUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNeklLSUNBZ0lEMDlDaUFnSUNCaWVpQmphR1ZqYTE5aFpuUmxjbDlwWmw5bGJITmxRREU0Q2lBZ0lDQmlkWEo1SURFS0lDQWdJRHdLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdllYTnpaWFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TURFS0lDQWdJQzh2SUhKbGRIVnliaUIwYUdsekxtRnpjMlYwUjJGMFpTaGpZV3hzWlhJc0lHRnpjMlYwTENCdmNDd2dkbUZzZFdVcENpQWdJQ0JpSUdOb1pXTnJYMkZtZEdWeVgybHViR2x1WldSZmMyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTloYzNObGRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcEJjM05sZEVkaGRHVXVZWE56WlhSSFlYUmxRREl4Q2dwamFHVmphMTloWm5SbGNsOXBabDlsYkhObFFERTRPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5aGMzTmxkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalkzQ2lBZ0lDQXZMeUJqWVhObElFZHlaV0YwWlhKVWFHRnVUM0pGY1hWaGJGUnZPaUJ5WlhSMWNtNGdZbUZzWVc1alpTQStQU0IyWVd4MVpRb2dJQ0FnYzNkaGNBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE0yTUtJQ0FnSUQwOUNpQWdJQ0JpZWlCamFHVmphMTloWm5SbGNsOXBabDlsYkhObFFESXdDaUFnSUNBOFBRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTloYzNObGRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXdNUW9nSUNBZ0x5OGdjbVYwZFhKdUlIUm9hWE11WVhOelpYUkhZWFJsS0dOaGJHeGxjaXdnWVhOelpYUXNJRzl3TENCMllXeDFaU2tLSUNBZ0lHSWdZMmhsWTJ0ZllXWjBaWEpmYVc1c2FXNWxaRjl6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwyRnpjMlYwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2tGemMyVjBSMkYwWlM1aGMzTmxkRWRoZEdWQU1qRUtDbU5vWldOclgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpBNkNpQWdJQ0J3YjNCdUlESUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12WVhOelpYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJPQW9nSUNBZ0x5OGdaR1ZtWVhWc2REb2djbVYwZFhKdUlHWmhiSE5sQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5aGMzTmxkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV3TVFvZ0lDQWdMeThnY21WMGRYSnVJSFJvYVhNdVlYTnpaWFJIWVhSbEtHTmhiR3hsY2l3Z1lYTnpaWFFzSUc5d0xDQjJZV3gxWlNrS0lDQWdJR0lnWTJobFkydGZZV1owWlhKZmFXNXNhVzVsWkY5emJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMMkZ6YzJWMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rRnpjMlYwUjJGMFpTNWhjM05sZEVkaGRHVkFNakVLQ21Ob1pXTnJYMmxtWDJKdlpIbEFOVG9LSUNBZ0lIQnZjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5aGMzTmxkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalUwQ2lBZ0lDQXZMeUJqYjI1emRDQmJhRzlzWkdsdVp5d2diM0IwWldSSmJsMGdQU0JCYzNObGRFaHZiR1JwYm1jdVlYTnpaWFJDWVd4aGJtTmxLSFZ6WlhJc0lHRnpjMlYwS1FvZ0lDQWdjM2RoY0FvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCaGMzTmxkRjlvYjJ4a2FXNW5YMmRsZENCQmMzTmxkRUpoYkdGdVkyVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12WVhOelpYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFOUW9nSUNBZ0x5OGdhV1lnS0NGdmNIUmxaRWx1S1NCN0NpQWdJQ0JpYm5vZ1kyaGxZMnRmWVdaMFpYSmZhV1pmWld4elpVQTNDaUFnSUNCd2IzQnVJRE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdllYTnpaWFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xTmdvZ0lDQWdMeThnY21WMGRYSnVJR1poYkhObENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OWhjM05sZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFd01Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUhSb2FYTXVZWE56WlhSSFlYUmxLR05oYkd4bGNpd2dZWE56WlhRc0lHOXdMQ0IyWVd4MVpTa0tJQ0FnSUdJZ1kyaGxZMnRmWVdaMFpYSmZhVzVzYVc1bFpGOXpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDJGemMyVjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPa0Z6YzJWMFIyRjBaUzVoYzNObGRFZGhkR1ZBTWpFS0NtTm9aV05yWDJGbWRHVnlYMmxtWDJWc2MyVkFOem9LSUNBZ0lHSWdZMmhsWTJ0ZllXWjBaWEpmYVdaZlpXeHpaVUE0Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5aGMzTmxkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBCYzNObGRFZGhkR1V1WjJWMFVtVm5hWE4wY21GMGFXOXVVMmhoY0dWYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncG5aWFJTWldkcGMzUnlZWFJwYjI1VGFHRndaVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdllYTnpaWFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TURRS0lDQWdJQzh2SUdkbGRGSmxaMmx6ZEhKaGRHbHZibE5vWVhCbEtITm9ZWEJsT2lCQmMzTmxkRWRoZEdWU1pXZHBjM1J5ZVVsdVptOHBPaUJCYzNObGRFZGhkR1ZTWldkcGMzUnllVWx1Wm04Z2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdNVGNLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12WVhOelpYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZRWE56WlhSSFlYUmxVbVZuYVhOMGNubEpibVp2Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5aGMzTmxkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBCYzNObGRFZGhkR1V1WjJWMFJXNTBjbmxiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwblpYUkZiblJ5ZVRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZZWE56WlhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1EZ0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OWhjM05sZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeE1Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUdWdVkyOWtaVUZ5WXpRb2RHaHBjeTV5WldkcGMzUnllU2h5WldkcGMzUnllVWxFS1M1MllXeDFaU2tLSUNBZ0lHbDBiMklLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJDYjNnZ2JYVnpkQ0JvWVhabElIWmhiSFZsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwyRnpjMlYwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRBNENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2djbVZoWkc5dWJIazZJSFJ5ZFdVZ2ZTa0tJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwySmhjMlV0WTI5dWRISmhZM1J6TDNWd1ozSmhaR1ZoWW14bExuUnpPanBCYTJsMFlVSmhjMlZEYjI1MGNtRmpkQzUxY0dSaGRHVkJhMmwwWVVSQlQxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDblZ3WkdGMFpVRnJhWFJoUkVGUE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMkpoYzJVdFkyOXVkSEpoWTNSekwzVndaM0poWkdWaFlteGxMblJ6T2pJMUNpQWdJQ0F2THlCMWNHUmhkR1ZCYTJsMFlVUkJUeWhoYTJsMFlVUkJUem9nUVhCd2JHbGpZWFJwYjI0cE9pQjJiMmxrSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTlpWVhObExXTnZiblJ5WVdOMGN5OTFjR2R5WVdSbFlXSnNaUzUwY3pveU5nb2dJQ0FnTHk4Z2JHOW5aMlZrUVhOelpYSjBLRlI0Ymk1elpXNWtaWElnUFQwOUlIUm9hWE11WjJWMFFXdHBkR0ZFUVU5WFlXeHNaWFFvS1M1aFpHUnlaWE56TENCbGNuSk9iM1JCYTJsMFlVUmhieWtLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTlpWVhObExXTnZiblJ5WVdOMGN5OTFjR2R5WVdSbFlXSnNaUzUwY3pveE9Rb2dJQ0FnTHk4Z1kyOXVjM1FnVzNkaGJHeGxkRWxFWFNBOUlHOXdMa0Z3Y0Vkc2IySmhiQzVuWlhSRmVGVnBiblEyTkNoMGFHbHpMbUZyYVhSaFJFRlBMblpoYkhWbExDQkNlWFJsY3loQmEybDBZVVJCVDBkc2IySmhiRk4wWVhSbFMyVjVjMWRoYkd4bGRDa3BDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMkpoYzJVdFkyOXVkSEpoWTNSekwzVndaM0poWkdWaFlteGxMblJ6T2pFMkNpQWdJQ0F2THlCaGEybDBZVVJCVHlBOUlFZHNiMkpoYkZOMFlYUmxQRUZ3Y0d4cFkyRjBhVzl1UGloN0lHdGxlVG9nUjJ4dlltRnNVM1JoZEdWTFpYbEJhMmwwWVVSQlR5QjlLUW9nSUNBZ1lubDBaV05mTWlBdkx5QWlZV3RwZEdGZlpHRnZJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJKaGMyVXRZMjl1ZEhKaFkzUnpMM1Z3WjNKaFpHVmhZbXhsTG5Sek9qRTVDaUFnSUNBdkx5QmpiMjV6ZENCYmQyRnNiR1YwU1VSZElEMGdiM0F1UVhCd1IyeHZZbUZzTG1kbGRFVjRWV2x1ZERZMEtIUm9hWE11WVd0cGRHRkVRVTh1ZG1Gc2RXVXNJRUo1ZEdWektFRnJhWFJoUkVGUFIyeHZZbUZzVTNSaGRHVkxaWGx6VjJGc2JHVjBLU2tLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNCd2RYTm9ZbmwwWlhNZ0luZGhiR3hsZENJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCd2IzQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTlpWVhObExXTnZiblJ5WVdOMGN5OTFjR2R5WVdSbFlXSnNaUzUwY3pveU5nb2dJQ0FnTHk4Z2JHOW5aMlZrUVhOelpYSjBLRlI0Ymk1elpXNWtaWElnUFQwOUlIUm9hWE11WjJWMFFXdHBkR0ZFUVU5WFlXeHNaWFFvS1M1aFpHUnlaWE56TENCbGNuSk9iM1JCYTJsMFlVUmhieWtLSUNBZ0lHRndjRjl3WVhKaGJYTmZaMlYwSUVGd2NFRmtaSEpsYzNNS0lDQWdJR0Z6YzJWeWRDQXZMeUJoY0hCc2FXTmhkR2x2YmlCbGVHbHpkSE1LSUNBZ0lEMDlDaUFnSUNCaWJub2dkWEJrWVhSbFFXdHBkR0ZFUVU5ZllXWjBaWEpmWVhOelpYSjBRRE1LSUNBZ0lIQjFjMmhpZVhSbGN5QWlSVkpTT21WeWNrNWtZVzhpQ2lBZ0lDQnNiMmNLSUNBZ0lHVnljaUF2THlCRlVsSTZaWEp5VG1SaGJ3b0tkWEJrWVhSbFFXdHBkR0ZFUVU5ZllXWjBaWEpmWVhOelpYSjBRRE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlltRnpaUzFqYjI1MGNtRmpkSE12ZFhCbmNtRmtaV0ZpYkdVdWRITTZNVFlLSUNBZ0lDOHZJR0ZyYVhSaFJFRlBJRDBnUjJ4dlltRnNVM1JoZEdVOFFYQndiR2xqWVhScGIyNCtLSHNnYTJWNU9pQkhiRzlpWVd4VGRHRjBaVXRsZVVGcmFYUmhSRUZQSUgwcENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKaGEybDBZVjlrWVc4aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZZbUZ6WlMxamIyNTBjbUZqZEhNdmRYQm5jbUZrWldGaWJHVXVkSE02TWpjS0lDQWdJQzh2SUhSb2FYTXVZV3RwZEdGRVFVOHVkbUZzZFdVZ1BTQmhhMmwwWVVSQlR3b2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTlpWVhObExXTnZiblJ5WVdOMGN5OTFjR2R5WVdSbFlXSnNaUzUwY3pveU5Rb2dJQ0FnTHk4Z2RYQmtZWFJsUVd0cGRHRkVRVThvWVd0cGRHRkVRVTg2SUVGd2NHeHBZMkYwYVc5dUtUb2dkbTlwWkNCN0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFS0lDQWdJSEpsZEhWeWJnbz0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQVFBQ0NDWUdCQlVmZkhVUGNtVm5hWE4wY25sZlkzVnljMjl5Q1dGcmFYUmhYMlJoYndBTFJWSlNPbVZ5Y2tsaGNtY0xSVkpTT21WeWNrbHdZWGt4R0VBQVBpa2laNElDRW5KbFoybHpkSEpoZEdsdmJsOXphR0Z3WlJVb2RXbHVkRFkwTEhWcGJuUTRMSFZwYm5RMk5DbG5nQXRqYUdWamExOXphR0Z3WlN0bk1Sa1VSREVZUVFBN2dnY0VNcDhFN2dSM3UzbTVCRzREOVFvRXROUVdjZ1NRMVBwZEJEUHBMSlFFaFUzdDREWWFBSTRIQURzQVdBRGVBYVlCdFFIUEFBRUFJa09BQk0yYTFuNDJHZ0NPQVFBQkFEWWFBVWtqV1NRSVN3RVZFa1JYQWdBMkdnSkpGU1VTUkJlQUIzWmxjbk5wYjI1UEFtY3FUR2NpUXpZYUFVa2pXU1FJVEJVU1JJQU1GUjk4ZFFBQUFBQUFBRERVc0NKREt6RVdJZ2xKT0JBaUVrUTJHZ0ZIQWlOWkpBaExBUlVTUkZjQ0FFa1ZnUkVTUUFBRUp3U3dBRXNDT0FjeUNoSkFBQVFuQmJBQVR3STRDSUhVWVJKQUFBUW5CYkFBVElFS1ZVbEZBNEVLRDBFQU1Fc0JnVHdPUVFBb0lrQUFENEFMUlZKU09tVnlja0p2Y0hLd0FDTXBaVVJKSWdncFRHY1dTVThDdnloTVVMQWlReU5DLzlVMkdnRkpGWUVnRWtRMkdnSkpGU1VTUkJjMkdnTkpJMWtrQ0VzQkZSSkVWd0lBRlVFQUJDY0VzQUFXdmtSSkkxdEpUZ0pPQTBsWENBRk9Bb0VKVzA0RFN3SnpBRWhNUUFCdFR3SklUd05JU3dHQUFRb1NRUUFRUlFFU2dBRUFJMDhDVkNoTVVMQWlRMHNCZ0FFVUVrRUFCa1VCRTBMLzVFc0JnQUVlRWtFQUJrVUJEVUwvMVVzQmdBRW9Fa0VBQmtVQkQwTC94a3NCZ0FFeUVrRUFCa1VCREVML3QweUFBVHdTUVFBRURrTC9xMFlDSTBML3BVaE1Ud053QUVBQUJrWURJMEwvbGtML2h6WWFBVWtWZ1JFU1JDaE1VTEFpUXpZYUFVa1ZKUkpFRnhhK1JFa1ZGbGNHQWt4UUtFeFFzQ0pETmhvQlNSVWxFa1FYTVFBakttVkVnQVozWVd4c1pYUmxTSElJUkJKQUFBK0FDMFZTVWpwbGNuSk9aR0Z2c0FBcVRHY2lRdz09IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6MTAsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
