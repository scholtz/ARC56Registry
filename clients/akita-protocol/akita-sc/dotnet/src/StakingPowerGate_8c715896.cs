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

namespace Arc56.Generated.akita_protocol.akita_sc.StakingPowerGate_8c715896
{


    public class StakingPowerGateProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public StakingPowerGateProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class StakingPowerGateRegistryInfo : AVMObjectType
            {
                public byte Op { get; set; }

                public ulong Asset { get; set; }

                public ulong Power { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vOp.From(Op);
                    ret.AddRange(vOp.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAsset = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAsset.From(Asset);
                    ret.AddRange(vAsset.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPower = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vPower.From(Power);
                    ret.AddRange(vPower.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static StakingPowerGateRegistryInfo Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new StakingPowerGateRegistryInfo();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vOp.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOp = vOp.ToValue();
                    if (valueOp is byte vOpValue) { ret.Op = vOpValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAsset = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAsset.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAsset = vAsset.ToValue();
                    if (valueAsset is ulong vAssetValue) { ret.Asset = vAssetValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPower = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vPower.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePower = vPower.ToValue();
                    if (valuePower is ulong vPowerValue) { ret.Power = vPowerValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as StakingPowerGateRegistryInfo);
                }
                public bool Equals(StakingPowerGateRegistryInfo? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(StakingPowerGateRegistryInfo left, StakingPowerGateRegistryInfo right)
                {
                    return EqualityComparer<StakingPowerGateRegistryInfo>.Default.Equals(left, right);
                }
                public static bool operator !=(StakingPowerGateRegistryInfo left, StakingPowerGateRegistryInfo right)
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
        /// <param name="shape"> StakingPowerGateRegistryInfo</param>
        public async Task<Structs.StakingPowerGateRegistryInfo> GetRegistrationShape(Structs.StakingPowerGateRegistryInfo shape, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 181, 220, 102, 55 };

            var result = await base.SimApp(new List<object> { abiHandle, shape }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.StakingPowerGateRegistryInfo.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetRegistrationShape_Transactions(Structs.StakingPowerGateRegistryInfo shape, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 181, 220, 102, 55 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU3Rha2luZ1Bvd2VyR2F0ZSIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJTdGFraW5nUG93ZXJHYXRlUmVnaXN0cnlJbmZvIjpbeyJuYW1lIjoib3AiLCJ0eXBlIjoidWludDgifSx7Im5hbWUiOiJhc3NldCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJwb3dlciIsInR5cGUiOiJ1aW50NjQifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZlcnNpb24iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFraXRhREFPIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNvc3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXJncyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlZ2lzdGVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1iclBheW1lbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFyZ3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjaGVjayIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FsbGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWdpc3RyeUlEIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcmdzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFJlZ2lzdHJhdGlvblNoYXBlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6Iih1aW50OCx1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IlN0YWtpbmdQb3dlckdhdGVSZWdpc3RyeUluZm8iLCJuYW1lIjoic2hhcGUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ4LHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiU3Rha2luZ1Bvd2VyR2F0ZVJlZ2lzdHJ5SW5mbyIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0RW50cnkiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVnaXN0cnlJRCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidXBkYXRlQWtpdGFEQU8iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWtpdGFEQU8iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoib3BVcCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MiwiYnl0ZXMiOjN9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzUwOCw4MTRdLCJlcnJvck1lc3NhZ2UiOiJCb3ggbXVzdCBoYXZlIHZhbHVlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTg1XSwiZXJyb3JNZXNzYWdlIjoiQnl0ZXMgaGFzIHZhbGlkIHByZWZpeCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQzNl0sImVycm9yTWVzc2FnZSI6IkVSUjpCT1BSIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzg1LDUwNF0sImVycm9yTWVzc2FnZSI6IkVSUjpJQVJHIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzk5LDQxNF0sImVycm9yTWVzc2FnZSI6IkVSUjpJUEFZIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODcyXSwiZXJyb3JNZXNzYWdlIjoiRVJSOk5EQU8iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNDcsMjY5XSwiZXJyb3JNZXNzYWdlIjoiSVBDVCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzg1Nl0sImVycm9yTWVzc2FnZSI6ImFwcGxpY2F0aW9uIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ0MCw1MjgsODQzXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgR2xvYmFsU3RhdGUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjgxLDMyMywzNjMsNDg2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjg4LDMyOSwzNzAsNDkzXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ3MV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyOTksNDc5LDgxMCw4MzZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3OTZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3Igc21hcnRfY29udHJhY3RzL2dhdGVzL3N1Yi1nYXRlcy9zdGFraW5nLXBvd2VyL2NvbnRyYWN0LmFsZ28udHM6OlN0YWtpbmdQb3dlckdhdGVSZWdpc3RyeUluZm8iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1OTBdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3Igc21hcnRfY29udHJhY3RzL3N0YWtpbmcvdHlwZXMudHM6OlN0YWtlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzU2XSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBwYXkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01DQXhJRGdnTWlBeE1EQXdNREF3Q2lBZ0lDQmllWFJsWTJKc2IyTnJJREI0TVRVeFpqZGpOelVnSW1GcmFYUmhYMlJoYnlJZ0luSmxaMmx6ZEhKNVgyTjFjbk52Y2lJZ0lpSWdJa1ZTVWpwSlFWSkhJaUFpUlZKU09rbFFRVmtpSURCNE1EQXdNREF3TURBd01EQXdNREUyWkRBd01EQXdNREF3TURBd1pqUXlOREFLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpYm5vZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFESUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12YzNSaGEybHVaeTF3YjNkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTRDaUFnSUNBdkx5QnlaV2RwYzNSeWVVTjFjbk52Y2lBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9leUJwYm1sMGFXRnNWbUZzZFdVNklERXNJR3RsZVRvZ1IyRjBaVWRzYjJKaGJGTjBZWFJsUzJWNVVtVm5hWE4wY25sRGRYSnpiM0lnZlNrS0lDQWdJR0o1ZEdWalh6SWdMeThnSW5KbFoybHpkSEo1WDJOMWNuTnZjaUlLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5emRHRnJhVzVuTFhCdmQyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOREFLSUNBZ0lDOHZJSEpsWjJsemRISmhkR2x2YmxOb1lYQmxJRDBnUjJ4dlltRnNVM1JoZEdVOGMzUnlhVzVuUGloN0lHbHVhWFJwWVd4V1lXeDFaVG9nSnloMWFXNTBPQ3gxYVc1ME5qUXNkV2x1ZERZMEtTY3NJR3RsZVRvZ1IyRjBaVWRzYjJKaGJGTjBZWFJsUzJWNVVtVm5hWE4wY21GMGFXOXVVMmhoY0dVZ2ZTa0tJQ0FnSUhCMWMyaGllWFJsYzNNZ0luSmxaMmx6ZEhKaGRHbHZibDl6YUdGd1pTSWdJaWgxYVc1ME9DeDFhVzUwTmpRc2RXbHVkRFkwS1NJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMM04wWVd0cGJtY3RjRzkzWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME1nb2dJQ0FnTHk4Z1kyaGxZMnRUYUdGd1pTQTlJRWRzYjJKaGJGTjBZWFJsUEhOMGNtbHVaejRvZXlCcGJtbDBhV0ZzVm1Gc2RXVTZJQ2NuTENCclpYazZJRWRoZEdWSGJHOWlZV3hUZEdGMFpVdGxlVU5vWldOclUyaGhjR1VnZlNrS0lDQWdJSEIxYzJoaWVYUmxjeUFpWTJobFkydGZjMmhoY0dVaUNpQWdJQ0JpZVhSbFkxOHpJQzh2SUNJaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb0tiV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwzTjBZV3RwYm1jdGNHOTNaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TkFvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklGTjBZV3RwYm1kUWIzZGxja2RoZEdVZ1pYaDBaVzVrY3lCQmEybDBZVUpoYzJWRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmllaUJ0WVdsdVgyTnlaV0YwWlY5T2IwOXdRREV6Q2lBZ0lDQndkWE5vWW5sMFpYTnpJREI0TXpJNVpqQTBaV1VnTUhnM04ySmlOemxpT1NBd2VEWmxNRE5tTlRCaElEQjRZalZrWXpZMk16Y2dNSGc1TUdRMFptRTFaQ0F3ZURNelpUa3lZemswSURCNE9EVTBaR1ZrWlRBZ0x5OGdiV1YwYUc5a0lDSmpiM04wS0dKNWRHVmJYU2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbkpsWjJsemRHVnlLSEJoZVN4aWVYUmxXMTBwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0pqYUdWamF5aGhaR1J5WlhOekxIVnBiblEyTkN4aWVYUmxXMTBwWW05dmJDSXNJRzFsZEdodlpDQWlaMlYwVW1WbmFYTjBjbUYwYVc5dVUyaGhjR1VvS0hWcGJuUTRMSFZwYm5RMk5DeDFhVzUwTmpRcEtTaDFhVzUwT0N4MWFXNTBOalFzZFdsdWREWTBLU0lzSUcxbGRHaHZaQ0FpWjJWMFJXNTBjbmtvZFdsdWREWTBLV0o1ZEdWYlhTSXNJRzFsZEdodlpDQWlkWEJrWVhSbFFXdHBkR0ZFUVU4b2RXbHVkRFkwS1hadmFXUWlMQ0J0WlhSb2IyUWdJbTl3VlhBb0tYWnZhV1FpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCamIzTjBJSEpsWjJsemRHVnlJR05vWldOcklHZGxkRkpsWjJsemRISmhkR2x2YmxOb1lYQmxJR2RsZEVWdWRISjVJSFZ3WkdGMFpVRnJhWFJoUkVGUElHMWhhVzVmYjNCVmNGOXliM1YwWlVBeE1Rb2dJQ0FnWlhKeUNncHRZV2x1WDI5d1ZYQmZjbTkxZEdWQU1URTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12WW1GelpTMWpiMjUwY21GamRITXZZbUZ6WlM1MGN6bzBNUW9nSUNBZ0x5OGdiM0JWY0NncE9pQjJiMmxrSUhzZ2ZRb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5amNtVmhkR1ZmVG05UGNFQXhNem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmMzUmhhMmx1Wnkxd2IzZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak0wQ2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1UzUmhhMmx1WjFCdmQyVnlSMkYwWlNCbGVIUmxibVJ6SUVGcmFYUmhRbUZ6WlVOdmJuUnlZV04wSUhzS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZUdOa09XRmtOamRsSUM4dklHMWxkR2h2WkNBaVkzSmxZWFJsS0hOMGNtbHVaeXgxYVc1ME5qUXBkbTlwWkNJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHTnlaV0YwWlFvZ0lDQWdaWEp5Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJaMWJtTjBhVzl1Y3k1MGN6bzZkMmxrWlZKaGRHbHZLRzUxYldWeVlYUnZjbk02SUdKNWRHVnpMQ0JrWlc1dmJXbHVZWFJ2Y25NNklHSjVkR1Z6S1NBdFBpQjFhVzUwTmpRNkNuZHBaR1ZTWVhScGJ6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTltZFc1amRHbHZibk11ZEhNNk1URTNDaUFnSUNBdkx5QmxlSEJ2Y25RZ1puVnVZM1JwYjI0Z2QybGtaVkpoZEdsdktHNTFiV1Z5WVhSdmNuTTZJRnQxYVc1ME5qUXNJSFZwYm5RMk5GMHNJR1JsYm05dGFXNWhkRzl5Y3pvZ1czVnBiblEyTkN3Z2RXbHVkRFkwWFNrNklIVnBiblEyTkNCN0NpQWdJQ0J3Y205MGJ5QXlJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5bWRXNWpkR2x2Ym5NdWRITTZNVEU0Q2lBZ0lDQXZMeUJoYzNObGNuUW9aR1Z1YjIxcGJtRjBiM0p6V3pCZElENGdNQ0FtSmlCa1pXNXZiV2x1WVhSdmNuTmJNVjBnUGlBd0xDQkZVbEpmU1U1V1FVeEpSRjlRUlZKRFJVNVVRVWRGS1FvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHUjFjQW9nSUNBZ1lub2dkMmxrWlZKaGRHbHZYMkp2YjJ4ZlptRnNjMlZBTXdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHSjZJSGRwWkdWU1lYUnBiMTlpYjI5c1gyWmhiSE5sUURNS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2dwM2FXUmxVbUYwYVc5ZlltOXZiRjl0WlhKblpVQTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJaMWJtTjBhVzl1Y3k1MGN6b3hNVGdLSUNBZ0lDOHZJR0Z6YzJWeWRDaGtaVzV2YldsdVlYUnZjbk5iTUYwZ1BpQXdJQ1ltSUdSbGJtOXRhVzVoZEc5eWMxc3hYU0ErSURBc0lFVlNVbDlKVGxaQlRFbEVYMUJGVWtORlRsUkJSMFVwQ2lBZ0lDQmhjM05sY25RZ0x5OGdTVkJEVkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwyWjFibU4wYVc5dWN5NTBjem94TVRrS0lDQWdJQzh2SUdOdmJuTjBJRnR2ZG1WeVpteHZkeXdnY21WemRXeDBYU0E5SUc5d0xtUnBkbTF2Wkhjb0xpNHViM0F1YlhWc2R5Z3VMaTV1ZFcxbGNtRjBiM0p6S1N3Z0xpNHViM0F1YlhWc2R5Z3VMaTVrWlc1dmJXbHVZWFJ2Y25NcEtRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQnRkV3gzQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1puSmhiV1ZmWkdsbklEQUtJQ0FnSUcxMWJIY0tJQ0FnSUdScGRtMXZaSGNLSUNBZ0lIQnZjRzRnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwyWjFibU4wYVc5dWN5NTBjem94TWpBS0lDQWdJQzh2SUdGemMyVnlkQ2h2ZG1WeVpteHZkeUE5UFQwZ01Dd2dSVkpTWDBsT1ZrRk1TVVJmVUVWU1EwVk9WRUZIUlNrS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QkpVRU5VQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlpuVnVZM1JwYjI1ekxuUnpPakV5TVFvZ0lDQWdMeThnY21WMGRYSnVJSEpsYzNWc2RBb2dJQ0FnYzNkaGNBb2dJQ0FnY21WMGMzVmlDZ3AzYVdSbFVtRjBhVzlmWW05dmJGOW1ZV3h6WlVBek9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0lnZDJsa1pWSmhkR2x2WDJKdmIyeGZiV1Z5WjJWQU5Bb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZjM1JoYTJsdVp5MXdiM2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwVGRHRnJhVzVuVUc5M1pYSkhZWFJsTG1OeVpXRjBaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21OeVpXRjBaVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmMzUmhhMmx1Wnkxd2IzZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamMyQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ2IyNURjbVZoZEdVNklDZHlaWEYxYVhKbEp5QjlLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eklDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTlpWVhObExXTnZiblJ5WVdOMGN5OWlZWE5sTG5Sek9qSTFDaUFnSUNBdkx5QjJaWEp6YVc5dUlEMGdSMnh2WW1Gc1UzUmhkR1U4YzNSeWFXNW5QaWg3SUd0bGVUb2dSMnh2WW1Gc1UzUmhkR1ZMWlhsV1pYSnphVzl1SUgwcENpQWdJQ0J3ZFhOb1lubDBaWE1nSW5abGNuTnBiMjRpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwzTjBZV3RwYm1jdGNHOTNaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zT0FvZ0lDQWdMeThnZEdocGN5NTJaWEp6YVc5dUxuWmhiSFZsSUQwZ2RtVnljMmx2YmdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJKaGMyVXRZMjl1ZEhKaFkzUnpMMkpoYzJVdWRITTZNamNLSUNBZ0lDOHZJR0ZyYVhSaFJFRlBJRDBnUjJ4dlltRnNVM1JoZEdVOFFYQndiR2xqWVhScGIyNCtLSHNnYTJWNU9pQkhiRzlpWVd4VGRHRjBaVXRsZVVGcmFYUmhSRUZQSUgwcENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKaGEybDBZVjlrWVc4aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMM04wWVd0cGJtY3RjRzkzWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM09Rb2dJQ0FnTHk4Z2RHaHBjeTVoYTJsMFlVUkJUeTUyWVd4MVpTQTlJRUZ3Y0d4cFkyRjBhVzl1S0dGcmFYUmhSRUZQS1FvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZjM1JoYTJsdVp5MXdiM2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pjMkNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2diMjVEY21WaGRHVTZJQ2R5WlhGMWFYSmxKeUI5S1FvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmMzUmhhMmx1Wnkxd2IzZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBUZEdGcmFXNW5VRzkzWlhKSFlYUmxMbU52YzNSYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGpiM04wT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXpkR0ZyYVc1bkxYQnZkMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T0RRS0lDQWdJQzh2SUdOdmMzUW9ZWEpuY3pvZ1lubDBaWE1wT2lCMWFXNTBOalFnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHpJQzh2SURJS0lDQWdJQ3NLSUNBZ0lITjNZWEFLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3hOVEZtTjJNM05UQXdNREF3TURBd01EQXdNRE13WkRRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmMzUmhhMmx1Wnkxd2IzZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBUZEdGcmFXNW5VRzkzWlhKSFlYUmxMbkpsWjJsemRHVnlXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LY21WbmFYTjBaWEk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwzTjBZV3RwYm1jdGNHOTNaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem80T0FvZ0lDQWdMeThnY21WbmFYTjBaWElvYldKeVVHRjViV1Z1ZERvZ1ozUjRiaTVRWVhsdFpXNTBWSGh1TENCaGNtZHpPaUJpZVhSbGN5azZJSFZwYm5RMk5DQjdDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUMwS0lDQWdJR1IxY0FvZ0lDQWdaM1I0Ym5NZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1TQXZMeUJ3WVhrS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdkSEpoYm5OaFkzUnBiMjRnZEhsd1pTQnBjeUJ3WVhrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0c0Z01nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTXlBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQmtkWEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmMzUmhhMmx1Wnkxd2IzZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamc1Q2lBZ0lDQXZMeUJzYjJkblpXUkJjM05sY25Rb1lYSm5jeTVzWlc1bmRHZ2dQVDA5SUVOb1pXTnJRWEpuYzBKNWRHVnpUR1Z1WjNSb0xDQkZVbEpmU1U1V1FVeEpSRjlCVWtkZlEwOVZUbFFwQ2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ01UY0tJQ0FnSUQwOUNpQWdJQ0JpYm5vZ2NtVm5hWE4wWlhKZllXWjBaWEpmWVhOelpYSjBRRE1LSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJa1ZTVWpwSlFWSkhJZ29nSUNBZ2JHOW5DaUFnSUNCbGNuSWdMeThnUlZKU09rbEJVa2NLQ25KbFoybHpkR1Z5WDJGbWRHVnlYMkZ6YzJWeWRFQXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5emRHRnJhVzVuTFhCdmQyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPVEFLSUNBZ0lDOHZJR3h2WjJkbFpFRnpjMlZ5ZENodFluSlFZWGx0Wlc1MExuSmxZMlZwZG1WeUlEMDlQU0JIYkc5aVlXd3VZM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN5d2dSVkpTWDBsT1ZrRk1TVVJmVUVGWlRVVk9WQ2tLSUNBZ0lHUnBaeUF5Q2lBZ0lDQm5kSGh1Y3lCU1pXTmxhWFpsY2dvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJRDA5Q2lBZ0lDQmlibm9nY21WbmFYTjBaWEpmWVdaMFpYSmZZWE56WlhKMFFEVUtJQ0FnSUdKNWRHVmpJRFVnTHk4Z0lrVlNVanBKVUVGWklnb2dJQ0FnYkc5bkNpQWdJQ0JsY25JZ0x5OGdSVkpTT2tsUVFWa0tDbkpsWjJsemRHVnlYMkZtZEdWeVgyRnpjMlZ5ZEVBMU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl6ZEdGcmFXNW5MWEJ2ZDJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9URUtJQ0FnSUM4dklHeHZaMmRsWkVGemMyVnlkQ2h0WW5KUVlYbHRaVzUwTG1GdGIzVnVkQ0E5UFQwZ1UzUmhhMmx1WjFCdmQyVnlSMkYwWlZKbFoybHpkSEo1VFVKU0xDQkZVbEpmU1U1V1FVeEpSRjlRUVZsTlJVNVVLUW9nSUNBZ1pHbG5JRElLSUNBZ0lHZDBlRzV6SUVGdGIzVnVkQW9nSUNBZ2NIVnphR2x1ZENBeE1qVXdNQW9nSUNBZ1BUMEtJQ0FnSUdKdWVpQnlaV2RwYzNSbGNsOWhablJsY2w5aGMzTmxjblJBTndvZ0lDQWdZbmwwWldNZ05TQXZMeUFpUlZKU09rbFFRVmtpQ2lBZ0lDQnNiMmNLSUNBZ0lHVnljaUF2THlCRlVsSTZTVkJCV1FvS2NtVm5hWE4wWlhKZllXWjBaWEpmWVhOelpYSjBRRGM2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwzTjBZV3RwYm1jdGNHOTNaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem81TkFvZ0lDQWdMeThnYkc5bloyVmtRWE56WlhKMEtIQmhjbUZ0Y3k1dmNDNWhjMVZwYm5RMk5DZ3BJRHc5SURZd0xDQkZVbEpmUWtGRVgwOVFSVkpCVkVsUFRpa0tJQ0FnSUdScFp5QXhDaUFnSUNCcGJuUmpYek1nTHk4Z01nb2dJQ0FnWjJWMFlubDBaUW9nSUNBZ2NIVnphR2x1ZENBMk1Bb2dJQ0FnUEQwS0lDQWdJR0p1ZWlCeVpXZHBjM1JsY2w5aFpuUmxjbDloYzNObGNuUkFPUW9nSUNBZ2NIVnphR0o1ZEdWeklDSkZVbEk2UWs5UVVpSUtJQ0FnSUd4dlp3b2dJQ0FnWlhKeUlDOHZJRVZTVWpwQ1QxQlNDZ3B5WldkcGMzUmxjbDloWm5SbGNsOWhjM05sY25SQU9Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12YzNSaGEybHVaeTF3YjNkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVXhDaUFnSUNBdkx5QmpiMjV6ZENCcFpDQTlJSFJvYVhNdWNtVm5hWE4wY25sRGRYSnpiM0l1ZG1Gc2RXVUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMM04wWVd0cGJtY3RjRzkzWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek9Bb2dJQ0FnTHk4Z2NtVm5hWE4wY25sRGRYSnpiM0lnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tIc2dhVzVwZEdsaGJGWmhiSFZsT2lBeExDQnJaWGs2SUVkaGRHVkhiRzlpWVd4VGRHRjBaVXRsZVZKbFoybHpkSEo1UTNWeWMyOXlJSDBwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0p5WldkcGMzUnllVjlqZFhKemIzSWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDNOMFlXdHBibWN0Y0c5M1pYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFNUW9nSUNBZ0x5OGdZMjl1YzNRZ2FXUWdQU0IwYUdsekxuSmxaMmx6ZEhKNVEzVnljMjl5TG5aaGJIVmxDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl6ZEdGcmFXNW5MWEJ2ZDJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5USUtJQ0FnSUM4dklIUm9hWE11Y21WbmFYTjBjbmxEZFhKemIzSXVkbUZzZFdVZ0t6MGdNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXpkR0ZyYVc1bkxYQnZkMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpnS0lDQWdJQzh2SUhKbFoybHpkSEo1UTNWeWMyOXlJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGloN0lHbHVhWFJwWVd4V1lXeDFaVG9nTVN3Z2EyVjVPaUJIWVhSbFIyeHZZbUZzVTNSaGRHVkxaWGxTWldkcGMzUnllVU4xY25OdmNpQjlLUW9nSUNBZ1lubDBaV05mTWlBdkx5QWljbVZuYVhOMGNubGZZM1Z5YzI5eUlnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl6ZEdGcmFXNW5MWEJ2ZDJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5USUtJQ0FnSUM4dklIUm9hWE11Y21WbmFYTjBjbmxEZFhKemIzSXVkbUZzZFdVZ0t6MGdNUW9nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmMzUmhhMmx1Wnkxd2IzZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamsyQ2lBZ0lDQXZMeUIwYUdsekxuSmxaMmx6ZEhKNUtHbGtLUzUyWVd4MVpTQTlJR05zYjI1bEtIQmhjbUZ0Y3lrS0lDQWdJR2wwYjJJS0lDQWdJR1IxY0FvZ0lDQWdaR2xuSURJS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12YzNSaGEybHVaeTF3YjNkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qZzRDaUFnSUNBdkx5QnlaV2RwYzNSbGNpaHRZbkpRWVhsdFpXNTBPaUJuZEhodUxsQmhlVzFsYm5SVWVHNHNJR0Z5WjNNNklHSjVkR1Z6S1RvZ2RXbHVkRFkwSUhzS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwzTjBZV3RwYm1jdGNHOTNaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VTNSaGEybHVaMUJ2ZDJWeVIyRjBaUzVqYUdWamExdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbU5vWldOck9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1IxY0FvZ0lDQWdZbmwwWldOZk15QXZMeUFpSWdvZ0lDQWdaSFZ3YmlBekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMM04wWVd0cGJtY3RjRzkzWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1EQUtJQ0FnSUM4dklHTm9aV05yS0dOaGJHeGxjam9nUVdOamIzVnVkQ3dnY21WbmFYTjBjbmxKUkRvZ2RXbHVkRFkwTENCaGNtZHpPaUJpZVhSbGN5azZJR0p2YjJ4bFlXNGdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eklDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZjM1JoYTJsdVp5MXdiM2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFd01Rb2dJQ0FnTHk4Z2JHOW5aMlZrUVhOelpYSjBLR0Z5WjNNdWJHVnVaM1JvSUQwOVBTQXdMQ0JGVWxKZlNVNVdRVXhKUkY5QlVrZGZRMDlWVGxRcENpQWdJQ0JzWlc0S0lDQWdJR0o2SUdOb1pXTnJYMkZtZEdWeVgyRnpjMlZ5ZEVBekNpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKRlVsSTZTVUZTUnlJS0lDQWdJR3h2WndvZ0lDQWdaWEp5SUM4dklFVlNVanBKUVZKSENncGphR1ZqYTE5aFpuUmxjbDloYzNObGNuUkFNem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmMzUmhhMmx1Wnkxd2IzZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV3TWdvZ0lDQWdMeThnWTI5dWMzUWdleUJ2Y0N3Z1lYTnpaWFFzSUhCdmQyVnlJSDBnUFNCamJHOXVaU2gwYUdsekxuSmxaMmx6ZEhKNUtISmxaMmx6ZEhKNVNVUXBMblpoYkhWbEtRb2dJQ0FnWkhWd0NpQWdJQ0JwZEc5aUNpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaGMzTmxjblFnTHk4Z1FtOTRJRzExYzNRZ2FHRjJaU0IyWVd4MVpRb2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJREFnTVFvZ0lDQWdZblZ5ZVNBNENpQWdJQ0JrZFhBS0lDQWdJR1Y0ZEhKaFkzUWdNU0E0Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQndkWE5vYVc1MElEa0tJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCaWRYSjVJRGNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmMzUmhhMmx1Wnkxd2IzZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalU0Q2lBZ0lDQXZMeUJuWlhSQmEybDBZVUZ3Y0V4cGMzUW9kR2hwY3k1aGEybDBZVVJCVHk1MllXeDFaU2t1YzNSaGEybHVaeXdLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12WW1GelpTMWpiMjUwY21GamRITXZZbUZ6WlM1MGN6b3lOd29nSUNBZ0x5OGdZV3RwZEdGRVFVOGdQU0JIYkc5aVlXeFRkR0YwWlR4QmNIQnNhV05oZEdsdmJqNG9leUJyWlhrNklFZHNiMkpoYkZOMFlYUmxTMlY1UVd0cGRHRkVRVThnZlNrS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1GcmFYUmhYMlJoYnlJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZjM1JoYTJsdVp5MXdiM2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVNENpQWdJQ0F2THlCblpYUkJhMmwwWVVGd2NFeHBjM1FvZEdocGN5NWhhMmwwWVVSQlR5NTJZV3gxWlNrdWMzUmhhMmx1Wnl3S0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlpuVnVZM1JwYjI1ekxuUnpPalEwQ2lBZ0lDQXZMeUJqYjI1emRDQmJZWEJ3VEdsemRFSjVkR1Z6WFNBOUlHOXdMa0Z3Y0Vkc2IySmhiQzVuWlhSRmVFSjVkR1Z6S0dGcmFYUmhSRUZQTENCQ2VYUmxjeWhCYTJsMFlVUkJUMGRzYjJKaGJGTjBZWFJsUzJWNWMwRnJhWFJoUVhCd1RHbHpkQ2twQ2lBZ0lDQndkWE5vWW5sMFpYTWdJbUZoYkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCd2IzQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12YzNSaGEybHVaeTF3YjNkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVTRDaUFnSUNBdkx5Qm5aWFJCYTJsMFlVRndjRXhwYzNRb2RHaHBjeTVoYTJsMFlVUkJUeTUyWVd4MVpTa3VjM1JoYTJsdVp5d0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMloxYm1OMGFXOXVjeTUwY3pvME56WXRORGcxQ2lBZ0lDQXZMeUJqYjI1emRDQnBibVp2SUQwZ1lXSnBRMkZzYkR4MGVYQmxiMllnVTNSaGEybHVaeTV3Y205MGIzUjVjR1V1WjJWMFNXNW1iejRvZXdvZ0lDQWdMeThnSUNCaGNIQkpaRG9nYzNSaGEybHVaMEZ3Y0N3S0lDQWdJQzh2SUNBZ1lYSm5jem9nV3dvZ0lDQWdMeThnSUNBZ0lIVnpaWElzQ2lBZ0lDQXZMeUFnSUNBZ2V3b2dJQ0FnTHk4Z0lDQWdJQ0FnWVhOelpYUXNDaUFnSUNBdkx5QWdJQ0FnSUNCMGVYQmxPaUJUVkVGTFNVNUhYMVJaVUVWZlRFOURTeXdLSUNBZ0lDOHZJQ0FnSUNCOUxBb2dJQ0FnTHk4Z0lDQmRMQW9nSUNBZ0x5OGdmU2t1Y21WMGRYSnVWbUZzZFdVS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5bWRXNWpkR2x2Ym5NdWRITTZORGd3TFRRNE13b2dJQ0FnTHk4Z2V3b2dJQ0FnTHk4Z0lDQmhjM05sZEN3S0lDQWdJQzh2SUNBZ2RIbHdaVG9nVTFSQlMwbE9SMTlVV1ZCRlgweFBRMHNzQ2lBZ0lDQXZMeUI5TEFvZ0lDQWdjM2RoY0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwyWjFibU4wYVc5dWN5NTBjem8wT0RJS0lDQWdJQzh2SUhSNWNHVTZJRk5VUVV0SlRrZGZWRmxRUlY5TVQwTkxMQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNamdLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5bWRXNWpkR2x2Ym5NdWRITTZORGd3TFRRNE13b2dJQ0FnTHk4Z2V3b2dJQ0FnTHk4Z0lDQmhjM05sZEN3S0lDQWdJQzh2SUNBZ2RIbHdaVG9nVTFSQlMwbE9SMTlVV1ZCRlgweFBRMHNzQ2lBZ0lDQXZMeUI5TEFvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTltZFc1amRHbHZibk11ZEhNNk5EYzJMVFE0TlFvZ0lDQWdMeThnWTI5dWMzUWdhVzVtYnlBOUlHRmlhVU5oYkd3OGRIbHdaVzltSUZOMFlXdHBibWN1Y0hKdmRHOTBlWEJsTG1kbGRFbHVabTgrS0hzS0lDQWdJQzh2SUNBZ1lYQndTV1E2SUhOMFlXdHBibWRCY0hBc0NpQWdJQ0F2THlBZ0lHRnlaM002SUZzS0lDQWdJQzh2SUNBZ0lDQjFjMlZ5TEFvZ0lDQWdMeThnSUNBZ0lIc0tJQ0FnSUM4dklDQWdJQ0FnSUdGemMyVjBMQW9nSUNBZ0x5OGdJQ0FnSUNBZ2RIbHdaVG9nVTFSQlMwbE9SMTlVV1ZCRlgweFBRMHNzQ2lBZ0lDQXZMeUFnSUNBZ2ZTd0tJQ0FnSUM4dklDQWdYU3dLSUNBZ0lDOHZJSDBwTG5KbGRIVnlibFpoYkhWbENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhoa05EQXhOakpoWmlBdkx5QnRaWFJvYjJRZ0ltZGxkRWx1Wm04b1lXUmtjbVZ6Y3l3b2RXbHVkRFkwTEhWcGJuUTRLU2tvZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwS1NJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCa2FXY2dNZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCd2RYTm9hVzUwSURZZ0x5OGdZWEJ3YkFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnYVhSNGJpQk1ZWE4wVEc5bkNpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ09Rb2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJRFFnTUFvZ0lDQWdaR2xuSURFS0lDQWdJR1Y0ZEhKaFkzUWdNQ0EwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1FubDBaWE1nYUdGeklIWmhiR2xrSUhCeVpXWnBlQW9nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1JoYTJsdVp5OTBlWEJsY3k1MGN6bzZVM1JoYTJVS0lDQWdJSEIxYzJocGJuUWdNakFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5bWRXNWpkR2x2Ym5NdWRITTZORGczQ2lBZ0lDQXZMeUJwWmlBb2FXNW1ieTVsZUhCcGNtRjBhVzl1SUR3OUlFZHNiMkpoYkM1c1lYUmxjM1JVYVcxbGMzUmhiWEFwSUhzS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ05Rb2dJQ0FnWjJ4dlltRnNJRXhoZEdWemRGUnBiV1Z6ZEdGdGNBb2dJQ0FnUEQwS0lDQWdJR0o2SUdOb1pXTnJYMkZtZEdWeVgybG1YMlZzYzJWQU5nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMloxYm1OMGFXOXVjeTUwY3pvME9EZ0tJQ0FnSUM4dklISmxkSFZ5YmlBd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZblZ5ZVNBekNncGphR1ZqYTE5aFpuUmxjbDlwYm14cGJtVmtYM050WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5bWRXNWpkR2x2Ym5NdWRITTZPbWRsZEZOMFlXdHBibWRRYjNkbGNrQTVPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5emRHRnJhVzVuTFhCdmQyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOalFLSUNBZ0lDOHZJR05oYzJVZ1JYRjFZV3c2SUhKbGRIVnliaUIxYzJWeVVHOTNaWElnUFQwOUlIQnZkMlZ5Q2lBZ0lDQmthV2NnTmdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TUdFS0lDQWdJRDA5Q2lBZ0lDQmllaUJqYUdWamExOWhablJsY2w5cFpsOWxiSE5sUURFeENpQWdJQ0JrYVdjZ01nb2dJQ0FnWkdsbklEWUtJQ0FnSUQwOUNncGphR1ZqYTE5aFpuUmxjbDlwYm14cGJtVmtYM050WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmMzUmhhMmx1Wnkxd2IzZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBUZEdGcmFXNW5VRzkzWlhKSFlYUmxMbk4wWVd0cGJtZFFiM2RsY2tkaGRHVkFNakk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwzTjBZV3RwYm1jdGNHOTNaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TURBS0lDQWdJQzh2SUdOb1pXTnJLR05oYkd4bGNqb2dRV05qYjNWdWRDd2djbVZuYVhOMGNubEpSRG9nZFdsdWREWTBMQ0JoY21kek9pQmllWFJsY3lrNklHSnZiMnhsWVc0Z2V3b2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxkR0pwZEFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS1kyaGxZMnRmWVdaMFpYSmZhV1pmWld4elpVQXhNVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmMzUmhhMmx1Wnkxd2IzZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalkxQ2lBZ0lDQXZMeUJqWVhObElFNXZkRVZ4ZFdGc09pQnlaWFIxY200Z2RYTmxjbEJ2ZDJWeUlDRTlQU0J3YjNkbGNnb2dJQ0FnWkdsbklEWUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VERTBDaUFnSUNBOVBRb2dJQ0FnWW5vZ1kyaGxZMnRmWVdaMFpYSmZhV1pmWld4elpVQXhNd29nSUNBZ1pHbG5JRElLSUNBZ0lHUnBaeUEyQ2lBZ0lDQWhQUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5emRHRnJhVzVuTFhCdmQyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEF6Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdkR2hwY3k1emRHRnJhVzVuVUc5M1pYSkhZWFJsS0dOaGJHeGxjaXdnYjNBc0lHRnpjMlYwTENCd2IzZGxjaWtLSUNBZ0lHSWdZMmhsWTJ0ZllXWjBaWEpmYVc1c2FXNWxaRjl6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwzTjBZV3RwYm1jdGNHOTNaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VTNSaGEybHVaMUJ2ZDJWeVIyRjBaUzV6ZEdGcmFXNW5VRzkzWlhKSFlYUmxRREl5Q2dwamFHVmphMTloWm5SbGNsOXBabDlsYkhObFFERXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5emRHRnJhVzVuTFhCdmQyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOallLSUNBZ0lDOHZJR05oYzJVZ1RHVnpjMVJvWVc0NklISmxkSFZ5YmlCMWMyVnlVRzkzWlhJZ1BDQndiM2RsY2dvZ0lDQWdaR2xuSURZS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURGbENpQWdJQ0E5UFFvZ0lDQWdZbm9nWTJobFkydGZZV1owWlhKZmFXWmZaV3h6WlVBeE5Rb2dJQ0FnWkdsbklESUtJQ0FnSUdScFp5QTJDaUFnSUNBOENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMM04wWVd0cGJtY3RjRzkzWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1ETUtJQ0FnSUM4dklISmxkSFZ5YmlCMGFHbHpMbk4wWVd0cGJtZFFiM2RsY2tkaGRHVW9ZMkZzYkdWeUxDQnZjQ3dnWVhOelpYUXNJSEJ2ZDJWeUtRb2dJQ0FnWWlCamFHVmphMTloWm5SbGNsOXBibXhwYm1Wa1gzTnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12YzNSaGEybHVaeTF3YjNkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcFRkR0ZyYVc1blVHOTNaWEpIWVhSbExuTjBZV3RwYm1kUWIzZGxja2RoZEdWQU1qSUtDbU5vWldOclgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMM04wWVd0cGJtY3RjRzkzWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk53b2dJQ0FnTHk4Z1kyRnpaU0JNWlhOelZHaGhiazl5UlhGMVlXeFViem9nY21WMGRYSnVJSFZ6WlhKUWIzZGxjaUE4UFNCd2IzZGxjZ29nSUNBZ1pHbG5JRFlLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREk0Q2lBZ0lDQTlQUW9nSUNBZ1lub2dZMmhsWTJ0ZllXWjBaWEpmYVdaZlpXeHpaVUF4TndvZ0lDQWdaR2xuSURJS0lDQWdJR1JwWnlBMkNpQWdJQ0E4UFFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXpkR0ZyYVc1bkxYQnZkMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRBekNpQWdJQ0F2THlCeVpYUjFjbTRnZEdocGN5NXpkR0ZyYVc1blVHOTNaWEpIWVhSbEtHTmhiR3hsY2l3Z2IzQXNJR0Z6YzJWMExDQndiM2RsY2lrS0lDQWdJR0lnWTJobFkydGZZV1owWlhKZmFXNXNhVzVsWkY5emJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMM04wWVd0cGJtY3RjRzkzWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlUzUmhhMmx1WjFCdmQyVnlSMkYwWlM1emRHRnJhVzVuVUc5M1pYSkhZWFJsUURJeUNncGphR1ZqYTE5aFpuUmxjbDlwWmw5bGJITmxRREUzT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXpkR0ZyYVc1bkxYQnZkMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpnS0lDQWdJQzh2SUdOaGMyVWdSM0psWVhSbGNsUm9ZVzQ2SUhKbGRIVnliaUIxYzJWeVVHOTNaWElnUGlCd2IzZGxjZ29nSUNBZ1pHbG5JRFlLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRE15Q2lBZ0lDQTlQUW9nSUNBZ1lub2dZMmhsWTJ0ZllXWjBaWEpmYVdaZlpXeHpaVUF4T1FvZ0lDQWdaR2xuSURJS0lDQWdJR1JwWnlBMkNpQWdJQ0ErQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwzTjBZV3RwYm1jdGNHOTNaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TURNS0lDQWdJQzh2SUhKbGRIVnliaUIwYUdsekxuTjBZV3RwYm1kUWIzZGxja2RoZEdVb1kyRnNiR1Z5TENCdmNDd2dZWE56WlhRc0lIQnZkMlZ5S1FvZ0lDQWdZaUJqYUdWamExOWhablJsY2w5cGJteHBibVZrWDNOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZjM1JoYTJsdVp5MXdiM2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwVGRHRnJhVzVuVUc5M1pYSkhZWFJsTG5OMFlXdHBibWRRYjNkbGNrZGhkR1ZBTWpJS0NtTm9aV05yWDJGbWRHVnlYMmxtWDJWc2MyVkFNVGs2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwzTjBZV3RwYm1jdGNHOTNaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yT1FvZ0lDQWdMeThnWTJGelpTQkhjbVZoZEdWeVZHaGhiazl5UlhGMVlXeFViem9nY21WMGRYSnVJSFZ6WlhKUWIzZGxjaUErUFNCd2IzZGxjZ29nSUNBZ1pHbG5JRFlLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRE5qQ2lBZ0lDQTlQUW9nSUNBZ1lub2dZMmhsWTJ0ZllXWjBaWEpmYVdaZlpXeHpaVUF5TVFvZ0lDQWdaR2xuSURJS0lDQWdJR1JwWnlBMkNpQWdJQ0ErUFFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXpkR0ZyYVc1bkxYQnZkMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRBekNpQWdJQ0F2THlCeVpYUjFjbTRnZEdocGN5NXpkR0ZyYVc1blVHOTNaWEpIWVhSbEtHTmhiR3hsY2l3Z2IzQXNJR0Z6YzJWMExDQndiM2RsY2lrS0lDQWdJR0lnWTJobFkydGZZV1owWlhKZmFXNXNhVzVsWkY5emJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMM04wWVd0cGJtY3RjRzkzWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlUzUmhhMmx1WjFCdmQyVnlSMkYwWlM1emRHRnJhVzVuVUc5M1pYSkhZWFJsUURJeUNncGphR1ZqYTE5aFpuUmxjbDlwWmw5bGJITmxRREl4T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXpkR0ZyYVc1bkxYQnZkMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnpBS0lDQWdJQzh2SUdSbFptRjFiSFE2SUhKbGRIVnliaUJtWVd4elpRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZjM1JoYTJsdVp5MXdiM2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFd013b2dJQ0FnTHk4Z2NtVjBkWEp1SUhSb2FYTXVjM1JoYTJsdVoxQnZkMlZ5UjJGMFpTaGpZV3hzWlhJc0lHOXdMQ0JoYzNObGRDd2djRzkzWlhJcENpQWdJQ0JpSUdOb1pXTnJYMkZtZEdWeVgybHViR2x1WldSZmMyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl6ZEdGcmFXNW5MWEJ2ZDJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9sTjBZV3RwYm1kUWIzZGxja2RoZEdVdWMzUmhhMmx1WjFCdmQyVnlSMkYwWlVBeU1nb0tZMmhsWTJ0ZllXWjBaWEpmYVdaZlpXeHpaVUEyT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwyWjFibU4wYVc5dWN5NTBjem8wT1RFS0lDQWdJQzh2SUdOdmJuTjBJSEpsYldGcGJtbHVaMVJwYldVNklIVnBiblEyTkNBOUlHbHVabTh1Wlhod2FYSmhkR2x2YmlBdElFZHNiMkpoYkM1c1lYUmxjM1JVYVcxbGMzUmhiWEFLSUNBZ0lHUnBaeUF6Q2lBZ0lDQm5iRzlpWVd3Z1RHRjBaWE4wVkdsdFpYTjBZVzF3Q2lBZ0lDQXRDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dOZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJaMWJtTjBhVzl1Y3k1MGN6bzBPVE1LSUNBZ0lDOHZJR2xtSUNoeVpXMWhhVzVwYm1kVWFXMWxJRHdnVDA1RlgxZEZSVXNwSUhzS0lDQWdJSEIxYzJocGJuUWdOakEwT0RBd0NpQWdJQ0E4Q2lBZ0lDQmllaUJqYUdWamExOWhablJsY2w5cFpsOWxiSE5sUURnS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OW1kVzVqZEdsdmJuTXVkSE02TkRrMENpQWdJQ0F2THlCeVpYUjFjbTRnTUFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjFjbmtnTXdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXpkR0ZyYVc1bkxYQnZkMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRjdE5qRUtJQ0FnSUM4dklHTnZibk4wSUhWelpYSlFiM2RsY2lBOUlHZGxkRk4wWVd0cGJtZFFiM2RsY2lnS0lDQWdJQzh2SUNBZ1oyVjBRV3RwZEdGQmNIQk1hWE4wS0hSb2FYTXVZV3RwZEdGRVFVOHVkbUZzZFdVcExuTjBZV3RwYm1jc0NpQWdJQ0F2THlBZ0lIVnpaWElzQ2lBZ0lDQXZMeUFnSUdGemMyVjBDaUFnSUNBdkx5QXBDaUFnSUNCaUlHTm9aV05yWDJGbWRHVnlYMmx1YkdsdVpXUmZjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJaMWJtTjBhVzl1Y3k1MGN6bzZaMlYwVTNSaGEybHVaMUJ2ZDJWeVFEa0tDbU5vWldOclgyRm1kR1Z5WDJsbVgyVnNjMlZBT0RvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OW1kVzVqZEdsdmJuTXVkSE02TkRrM0NpQWdJQ0F2THlCamIyNXpkQ0J5WlcxaGFXNXBibWRFWVhsek9pQjFhVzUwTmpRZ1BTQnlaVzFoYVc1cGJtZFVhVzFsSUM4Z1QwNUZYMFJCV1FvZ0lDQWdaR2xuSURRS0lDQWdJSEIxYzJocGJuUWdPRFkwTURBS0lDQWdJQzhLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5bWRXNWpkR2x2Ym5NdWRITTZORGs0Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdiM0F1WkdsMmR5Z3VMaTV2Y0M1dGRXeDNLSGRwWkdWU1lYUnBieWhiYVc1bWJ5NWhiVzkxYm5Rc0lERmZNREF3WHpBd01GMHNJRnRQVGtWZldVVkJVbDlKVGw5RVFWbFRMQ0F4WHpBd01GOHdNREJkS1N3Z2NtVnRZV2x1YVc1blJHRjVjeWtzSURGZk1EQXdYekF3TUNrS0lDQWdJR1JwWnlBNENpQWdJQ0JsZUhSeVlXTjBJRFFnT0FvZ0lDQWdhVzUwWXlBMElDOHZJREV3TURBd01EQUtJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCaWVYUmxZeUEySUM4dklEQjRNREF3TURBd01EQXdNREF3TURFMlpEQXdNREF3TURBd01EQXdaalF5TkRBS0lDQWdJR05oYkd4emRXSWdkMmxrWlZKaGRHbHZDaUFnSUNCa2FXY2dNZ29nSUNBZ2JYVnNkd29nSUNBZ2NHOXdDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmllWFJsWXlBMklDOHZJREI0TURBd01EQXdNREF3TURBd01ERTJaREF3TURBd01EQXdNREF3WmpReU5EQUtJQ0FnSUdOaGJHeHpkV0lnZDJsa1pWSmhkR2x2Q2lBZ0lDQnRkV3gzQ2lBZ0lDQmlkWEo1SURFS0lDQWdJR2x1ZEdNZ05DQXZMeUF4TURBd01EQXdDaUFnSUNCa2FYWjNDaUFnSUNCaWRYSjVJRE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmMzUmhhMmx1Wnkxd2IzZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalUzTFRZeENpQWdJQ0F2THlCamIyNXpkQ0IxYzJWeVVHOTNaWElnUFNCblpYUlRkR0ZyYVc1blVHOTNaWElvQ2lBZ0lDQXZMeUFnSUdkbGRFRnJhWFJoUVhCd1RHbHpkQ2gwYUdsekxtRnJhWFJoUkVGUExuWmhiSFZsS1M1emRHRnJhVzVuTEFvZ0lDQWdMeThnSUNCMWMyVnlMQW9nSUNBZ0x5OGdJQ0JoYzNObGRBb2dJQ0FnTHk4Z0tRb2dJQ0FnWWlCamFHVmphMTloWm5SbGNsOXBibXhwYm1Wa1gzTnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTltZFc1amRHbHZibk11ZEhNNk9tZGxkRk4wWVd0cGJtZFFiM2RsY2tBNUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXpkR0ZyYVc1bkxYQnZkMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2xOMFlXdHBibWRRYjNkbGNrZGhkR1V1WjJWMFVtVm5hWE4wY21GMGFXOXVVMmhoY0dWYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncG5aWFJTWldkcGMzUnlZWFJwYjI1VGFHRndaVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmMzUmhhMmx1Wnkxd2IzZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV3TmdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lISmxZV1J2Ym14NU9pQjBjblZsSUgwcENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQXhOd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl6ZEdGcmFXNW5MWEJ2ZDJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9sTjBZV3RwYm1kUWIzZGxja2RoZEdWU1pXZHBjM1J5ZVVsdVptOEtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMM04wWVd0cGJtY3RjRzkzWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlUzUmhhMmx1WjFCdmQyVnlSMkYwWlM1blpYUkZiblJ5ZVZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtZGxkRVZ1ZEhKNU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl6ZEdGcmFXNW5MWEJ2ZDJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1URXhDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnY21WaFpHOXViSGs2SUhSeWRXVWdmU2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZjM1JoYTJsdVp5MXdiM2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeE13b2dJQ0FnTHk4Z2NtVjBkWEp1SUdWdVkyOWtaVUZ5WXpRb2RHaHBjeTV5WldkcGMzUnllU2h5WldkcGMzUnllVWxFS1M1MllXeDFaU2tLSUNBZ0lHbDBiMklLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJDYjNnZ2JYVnpkQ0JvWVhabElIWmhiSFZsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwzTjBZV3RwYm1jdGNHOTNaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TVRFS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2V5QnlaV0ZrYjI1c2VUb2dkSEoxWlNCOUtRb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlltRnpaUzFqYjI1MGNtRmpkSE12WW1GelpTNTBjem82UVd0cGRHRkNZWE5sUTI5dWRISmhZM1F1ZFhCa1lYUmxRV3RwZEdGRVFVOWJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AxY0dSaGRHVkJhMmwwWVVSQlR6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTlpWVhObExXTnZiblJ5WVdOMGN5OWlZWE5sTG5Sek9qTTJDaUFnSUNBdkx5QjFjR1JoZEdWQmEybDBZVVJCVHloaGEybDBZVVJCVHpvZ1FYQndiR2xqWVhScGIyNHBPaUIyYjJsa0lIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5aVlYTmxMV052Ym5SeVlXTjBjeTlpWVhObExuUnpPak0zQ2lBZ0lDQXZMeUJzYjJkblpXUkJjM05sY25Rb1ZIaHVMbk5sYm1SbGNpQTlQVDBnZEdocGN5NW5aWFJCYTJsMFlVUkJUMWRoYkd4bGRDZ3BMbUZrWkhKbGMzTXNJRVZTVWw5T1QxUmZRVXRKVkVGZlJFRlBLUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMkpoYzJVdFkyOXVkSEpoWTNSekwySmhjMlV1ZEhNNk16QUtJQ0FnSUM4dklHTnZibk4wSUZ0M1lXeHNaWFJKUkYwZ1BTQnZjQzVCY0hCSGJHOWlZV3d1WjJWMFJYaFZhVzUwTmpRb2RHaHBjeTVoYTJsMFlVUkJUeTUyWVd4MVpTd2dRbmwwWlhNb1FXdHBkR0ZFUVU5SGJHOWlZV3hUZEdGMFpVdGxlWE5YWVd4c1pYUXBLUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTlpWVhObExXTnZiblJ5WVdOMGN5OWlZWE5sTG5Sek9qSTNDaUFnSUNBdkx5QmhhMmwwWVVSQlR5QTlJRWRzYjJKaGJGTjBZWFJsUEVGd2NHeHBZMkYwYVc5dVBpaDdJR3RsZVRvZ1IyeHZZbUZzVTNSaGRHVkxaWGxCYTJsMFlVUkJUeUI5S1FvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWVd0cGRHRmZaR0Z2SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwySmhjMlV0WTI5dWRISmhZM1J6TDJKaGMyVXVkSE02TXpBS0lDQWdJQzh2SUdOdmJuTjBJRnQzWVd4c1pYUkpSRjBnUFNCdmNDNUJjSEJIYkc5aVlXd3VaMlYwUlhoVmFXNTBOalFvZEdocGN5NWhhMmwwWVVSQlR5NTJZV3gxWlN3Z1FubDBaWE1vUVd0cGRHRkVRVTlIYkc5aVlXeFRkR0YwWlV0bGVYTlhZV3hzWlhRcEtRb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJSEIxYzJoaWVYUmxjeUFpZDJGc2JHVjBJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJSEJ2Y0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwySmhjMlV0WTI5dWRISmhZM1J6TDJKaGMyVXVkSE02TXpjS0lDQWdJQzh2SUd4dloyZGxaRUZ6YzJWeWRDaFVlRzR1YzJWdVpHVnlJRDA5UFNCMGFHbHpMbWRsZEVGcmFYUmhSRUZQVjJGc2JHVjBLQ2t1WVdSa2NtVnpjeXdnUlZKU1gwNVBWRjlCUzBsVVFWOUVRVThwQ2lBZ0lDQmhjSEJmY0dGeVlXMXpYMmRsZENCQmNIQkJaR1J5WlhOekNpQWdJQ0JoYzNObGNuUWdMeThnWVhCd2JHbGpZWFJwYjI0Z1pYaHBjM1J6Q2lBZ0lDQTlQUW9nSUNBZ1ltNTZJSFZ3WkdGMFpVRnJhWFJoUkVGUFgyRm1kR1Z5WDJGemMyVnlkRUF6Q2lBZ0lDQndkWE5vWW5sMFpYTWdJa1ZTVWpwT1JFRlBJZ29nSUNBZ2JHOW5DaUFnSUNCbGNuSWdMeThnUlZKU09rNUVRVThLQ25Wd1pHRjBaVUZyYVhSaFJFRlBYMkZtZEdWeVgyRnpjMlZ5ZEVBek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMkpoYzJVdFkyOXVkSEpoWTNSekwySmhjMlV1ZEhNNk1qY0tJQ0FnSUM4dklHRnJhWFJoUkVGUElEMGdSMnh2WW1Gc1UzUmhkR1U4UVhCd2JHbGpZWFJwYjI0K0tIc2dhMlY1T2lCSGJHOWlZV3hUZEdGMFpVdGxlVUZyYVhSaFJFRlBJSDBwQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0poYTJsMFlWOWtZVzhpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlltRnpaUzFqYjI1MGNtRmpkSE12WW1GelpTNTBjem96T0FvZ0lDQWdMeThnZEdocGN5NWhhMmwwWVVSQlR5NTJZV3gxWlNBOUlHRnJhWFJoUkVGUENpQWdJQ0JrYVdjZ01Rb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTlpWVhObExXTnZiblJ5WVdOMGN5OWlZWE5sTG5Sek9qTTJDaUFnSUNBdkx5QjFjR1JoZEdWQmEybDBZVVJCVHloaGEybDBZVVJCVHpvZ1FYQndiR2xqWVhScGIyNHBPaUIyYjJsa0lIc0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFS0lDQWdJSEpsZEhWeWJnbz0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFGQUFFSUFzQ0VQU1lIQkJVZmZIVUpZV3RwZEdGZlpHRnZEM0psWjJsemRISjVYMk4xY25OdmNnQUlSVkpTT2tsQlVrY0lSVkpTT2tsUVFWa1FBQUFBQUFBQUFXMEFBQUFBQUE5Q1FERVlRQUErS2lObmdnSVNjbVZuYVhOMGNtRjBhVzl1WDNOb1lYQmxGU2gxYVc1ME9DeDFhVzUwTmpRc2RXbHVkRFkwS1dlQUMyTm9aV05yWDNOb1lYQmxLMmN4R1JSRU1SaEJBRHVDQndReW53VHVCSGU3ZWJrRWJnUDFDZ1MxM0dZM0JKRFUrbDBFTStrc2xBU0ZUZTNnTmhvQWpnY0Fhd0NJQVBjQ1FRSlFBbW9BQVFBalE0QUV6WnJXZmpZYUFJNEJBREVBaWdJQmkvOGlXMGxCQUNHTC95UmJRUUFhSTBTTC9pSmJpLzRrV3gyTC95UmJpd0FkSDBZQ1RCUkVUSWtpUXYvak5ob0JTU0paSlFoTEFSVVNSRmNDQURZYUFra1ZKQkpFRjRBSGRtVnljMmx2Yms4Q1p5bE1aeU5ETmhvQlNTSlpKUWhNRlJKRWdBd1ZIM3gxQUFBQUFBQUFNTlN3STBNeEZpTUpTVGdRSXhKRU5ob0JSd0lpV1NVSVN3RVZFa1JYQWdCSkZZRVJFa0FBQkNjRXNBQkxBamdITWdvU1FBQUVKd1d3QUVzQ09BaUIxR0VTUUFBRUp3V3dBRXNCSlZXQlBBNUFBQXlBQ0VWU1VqcENUMUJTc0FBaUttVkVTU01JS2t4bkZrbExBcjhvVEZDd0kwTWlTU3RIQXpZYUFVa1ZnU0FTUkRZYUFra1ZKQkpFRnpZYUEwa2lXU1VJU3dFVkVrUlhBZ0FWUVFBRUp3U3dBRWtXdmtSSlZ3QUJSUWhKVndFSVRJRUpXMFVISWlsbFJJQURZV0ZzWlVnaVc3Rk1nQUVvVUV5eUdJQUUxQUZpcjdJYVN3S3lHcklhZ1FheUVDS3lBYk8wUGtsRkNVbFhCQUJMQVZjQUJDZ1NSQldCSUJKRWdSUmJTVVVGTWdjT1FRQjNJa1VEU3dhQUFRb1NRUUFTU3dKTEJoS0FBUUFpVHdKVUtFeFFzQ05EU3dhQUFSUVNRUUFJU3dKTEJoTkMvK0pMQm9BQkhoSkJBQWhMQWtzR0RFTC8wVXNHZ0FFb0VrRUFDRXNDU3dZT1F2L0FTd2FBQVRJU1FRQUlTd0pMQmcxQy82OUxCb0FCUEJKQkFBaExBa3NHRDBML25pSkMvNXBMQXpJSENVbEZCb0dBOVNRTVFRQUdJa1VEUXY5MlN3U0JnS01GQ2tzSVZ3UUlJUVFXVUVrbkJvajk1a3NDSFVoT0FpY0dpUDNiSFVVQklRU1hSUU5DLzBvMkdnRkpGWUVSRWtRb1RGQ3dJME0yR2dGSkZTUVNSQmNXdmtSSkZSWlhCZ0pNVUNoTVVMQWpRellhQVVrVkpCSkVGekVBSWlsbFJJQUdkMkZzYkdWMFpVaHlDRVFTUUFBTWdBaEZVbEk2VGtSQlQ3QUFLVXNCWnlORCIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjksInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
