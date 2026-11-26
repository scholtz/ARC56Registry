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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU3Rha2luZ1Bvd2VyR2F0ZSIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJTdGFraW5nUG93ZXJHYXRlUmVnaXN0cnlJbmZvIjpbeyJuYW1lIjoib3AiLCJ0eXBlIjoidWludDgifSx7Im5hbWUiOiJhc3NldCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJwb3dlciIsInR5cGUiOiJ1aW50NjQifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZlcnNpb24iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFraXRhREFPIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNvc3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXJncyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlZ2lzdGVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1iclBheW1lbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFyZ3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjaGVjayIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FsbGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWdpc3RyeUlEIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcmdzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFJlZ2lzdHJhdGlvblNoYXBlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6Iih1aW50OCx1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IlN0YWtpbmdQb3dlckdhdGVSZWdpc3RyeUluZm8iLCJuYW1lIjoic2hhcGUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ4LHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiU3Rha2luZ1Bvd2VyR2F0ZVJlZ2lzdHJ5SW5mbyIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0RW50cnkiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVnaXN0cnlJRCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidXBkYXRlQWtpdGFEQU8iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWtpdGFEQU8iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoib3BVcCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MiwiYnl0ZXMiOjN9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzUwNyw3OTVdLCJlcnJvck1lc3NhZ2UiOiJCb3ggbXVzdCBoYXZlIHZhbHVlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTg3XSwiZXJyb3JNZXNzYWdlIjoiQnl0ZXMgaGFzIHZhbGlkIHByZWZpeCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ0Ml0sImVycm9yTWVzc2FnZSI6IkVSUjplcnJCb3ByIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzg5LDUwNF0sImVycm9yTWVzc2FnZSI6IkVSUjplcnJJYXJnIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDAzLDQxOF0sImVycm9yTWVzc2FnZSI6IkVSUjplcnJJcGF5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODU2XSwiZXJyb3JNZXNzYWdlIjoiRVJSOmVyck5kYW8iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4MzddLCJlcnJvck1lc3NhZ2UiOiJhcHBsaWNhdGlvbiBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NDYsNTI2LDgyNF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIEdsb2JhbFN0YXRlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI1MywyNzVdLCJlcnJvck1lc3NhZ2UiOiJlcnJJcGN0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjg2LDMyOCwzNjgsNDg3XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjkzLDMzNCwzNzUsNDk0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ3Ml0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMDQsNDgwLDc5MSw4MTddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3NzddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3Igc21hcnRfY29udHJhY3RzL2dhdGVzL3N1Yi1nYXRlcy9zdGFraW5nLXBvd2VyL2NvbnRyYWN0LmFsZ28udHM6OlN0YWtpbmdQb3dlckdhdGVSZWdpc3RyeUluZm8iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1OTJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3Igc21hcnRfY29udHJhY3RzL3N0YWtpbmcvdHlwZXMudHM6OlN0YWtlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzYxXSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBwYXkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01DQXhJRGdnTWlBeE1EQXdNREF3Q2lBZ0lDQmllWFJsWTJKc2IyTnJJREI0TVRVeFpqZGpOelVnSW1GcmFYUmhYMlJoYnlJZ0luSmxaMmx6ZEhKNVgyTjFjbk52Y2lJZ0lrVlNVanBsY25KSllYSm5JaUFpUlZKU09tVnlja2x3WVhraUlEQjRNREF3TURBd01EQXdNREF3TURFMlpEQXdNREF3TURBd01EQXdaalF5TkRBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWJub2diV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmMzUmhhMmx1Wnkxd2IzZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak00Q2lBZ0lDQXZMeUJ5WldkcGMzUnllVU4xY25OdmNpQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvZXlCcGJtbDBhV0ZzVm1Gc2RXVTZJREVzSUd0bGVUb2dSMkYwWlVkc2IySmhiRk4wWVhSbFMyVjVVbVZuYVhOMGNubERkWEp6YjNJZ2ZTa0tJQ0FnSUdKNWRHVmpYeklnTHk4Z0luSmxaMmx6ZEhKNVgyTjFjbk52Y2lJS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXpkR0ZyYVc1bkxYQnZkMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRBS0lDQWdJQzh2SUhKbFoybHpkSEpoZEdsdmJsTm9ZWEJsSUQwZ1IyeHZZbUZzVTNSaGRHVThjM1J5YVc1blBpaDdJR2x1YVhScFlXeFdZV3gxWlRvZ0p5aDFhVzUwT0N4MWFXNTBOalFzZFdsdWREWTBLU2NzSUd0bGVUb2dSMkYwWlVkc2IySmhiRk4wWVhSbFMyVjVVbVZuYVhOMGNtRjBhVzl1VTJoaGNHVWdmU2tLSUNBZ0lIQjFjMmhpZVhSbGMzTWdJbkpsWjJsemRISmhkR2x2Ymw5emFHRndaU0lnSWloMWFXNTBPQ3gxYVc1ME5qUXNkV2x1ZERZMEtTSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDNOMFlXdHBibWN0Y0c5M1pYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBNZ29nSUNBZ0x5OGdZMmhsWTJ0VGFHRndaU0E5SUVkc2IySmhiRk4wWVhSbFBITjBjbWx1Wno0b2V5QnBibWwwYVdGc1ZtRnNkV1U2SUNjbkxDQnJaWGs2SUVkaGRHVkhiRzlpWVd4VGRHRjBaVXRsZVVOb1pXTnJVMmhoY0dVZ2ZTa0tJQ0FnSUhCMWMyaGllWFJsYzNNZ0ltTm9aV05yWDNOb1lYQmxJaUFpSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0NtMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5emRHRnJhVzVuTFhCdmQyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNelFLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCVGRHRnJhVzVuVUc5M1pYSkhZWFJsSUdWNGRHVnVaSE1nUVd0cGRHRkNZWE5sUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lub2diV0ZwYmw5amNtVmhkR1ZmVG05UGNFQXhNd29nSUNBZ2NIVnphR0o1ZEdWemN5QXdlRE15T1dZd05HVmxJREI0TnpkaVlqYzVZamtnTUhnMlpUQXpaalV3WVNBd2VHSTFaR00yTmpNM0lEQjRPVEJrTkdaaE5XUWdNSGd6TTJVNU1tTTVOQ0F3ZURnMU5HUmxaR1V3SUM4dklHMWxkR2h2WkNBaVkyOXpkQ2hpZVhSbFcxMHBkV2x1ZERZMElpd2diV1YwYUc5a0lDSnlaV2RwYzNSbGNpaHdZWGtzWW5sMFpWdGRLWFZwYm5RMk5DSXNJRzFsZEdodlpDQWlZMmhsWTJzb1lXUmtjbVZ6Y3l4MWFXNTBOalFzWW5sMFpWdGRLV0p2YjJ3aUxDQnRaWFJvYjJRZ0ltZGxkRkpsWjJsemRISmhkR2x2YmxOb1lYQmxLQ2gxYVc1ME9DeDFhVzUwTmpRc2RXbHVkRFkwS1Nrb2RXbHVkRGdzZFdsdWREWTBMSFZwYm5RMk5Da2lMQ0J0WlhSb2IyUWdJbWRsZEVWdWRISjVLSFZwYm5RMk5DbGllWFJsVzEwaUxDQnRaWFJvYjJRZ0luVndaR0YwWlVGcmFYUmhSRUZQS0hWcGJuUTJOQ2wyYjJsa0lpd2diV1YwYUc5a0lDSnZjRlZ3S0NsMmIybGtJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnWTI5emRDQnlaV2RwYzNSbGNpQmphR1ZqYXlCblpYUlNaV2RwYzNSeVlYUnBiMjVUYUdGd1pTQm5aWFJGYm5SeWVTQjFjR1JoZEdWQmEybDBZVVJCVHlCdFlXbHVYMjl3VlhCZmNtOTFkR1ZBTVRFS0lDQWdJR1Z5Y2dvS2JXRnBibDl2Y0ZWd1gzSnZkWFJsUURFeE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMkpoYzJVdFkyOXVkSEpoWTNSekwzVndaM0poWkdWaFlteGxMblJ6T2pNd0NpQWdJQ0F2THlCdmNGVndLQ2s2SUhadmFXUWdleUI5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMk55WldGMFpWOU9iMDl3UURFek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl6ZEdGcmFXNW5MWEJ2ZDJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16UUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJUZEdGcmFXNW5VRzkzWlhKSFlYUmxJR1Y0ZEdWdVpITWdRV3RwZEdGQ1lYTmxRMjl1ZEhKaFkzUWdld29nSUNBZ2NIVnphR0o1ZEdWeklEQjRZMlE1WVdRMk4yVWdMeThnYldWMGFHOWtJQ0pqY21WaGRHVW9jM1J5YVc1bkxIVnBiblEyTkNsMmIybGtJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnWTNKbFlYUmxDaUFnSUNCbGNuSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZablZ1WTNScGIyNXpMblJ6T2pwM2FXUmxVbUYwYVc4b2JuVnRaWEpoZEc5eWN6b2dZbmwwWlhNc0lHUmxibTl0YVc1aGRHOXljem9nWW5sMFpYTXBJQzArSUhWcGJuUTJORG9LZDJsa1pWSmhkR2x2T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwyWjFibU4wYVc5dWN5NTBjem95TnprS0lDQWdJQzh2SUdWNGNHOXlkQ0JtZFc1amRHbHZiaUIzYVdSbFVtRjBhVzhvYm5WdFpYSmhkRzl5Y3pvZ1czVnBiblEyTkN3Z2RXbHVkRFkwWFN3Z1pHVnViMjFwYm1GMGIzSnpPaUJiZFdsdWREWTBMQ0IxYVc1ME5qUmRLVG9nZFdsdWREWTBJSHNLSUNBZ0lIQnliM1J2SURJZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMloxYm1OMGFXOXVjeTUwY3pveU9EQUtJQ0FnSUM4dklHRnpjMlZ5ZENoa1pXNXZiV2x1WVhSdmNuTmJNRjBnUGlBd0lDWW1JR1JsYm05dGFXNWhkRzl5YzFzeFhTQStJREFzSUdWeWNrbHVkbUZzYVdSUVpYSmpaVzUwWVdkbEtRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR1IxY0FvZ0lDQWdZbm9nZDJsa1pWSmhkR2x2WDJKdmIyeGZabUZzYzJWQU13b2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR0o2SUhkcFpHVlNZWFJwYjE5aWIyOXNYMlpoYkhObFFETUtJQ0FnSUdsdWRHTmZNU0F2THlBeENncDNhV1JsVW1GMGFXOWZZbTl2YkY5dFpYSm5aVUEwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwyWjFibU4wYVc5dWN5NTBjem95T0RBS0lDQWdJQzh2SUdGemMyVnlkQ2hrWlc1dmJXbHVZWFJ2Y25OYk1GMGdQaUF3SUNZbUlHUmxibTl0YVc1aGRHOXljMXN4WFNBK0lEQXNJR1Z5Y2tsdWRtRnNhV1JRWlhKalpXNTBZV2RsS1FvZ0lDQWdZWE56WlhKMElDOHZJR1Z5Y2tsd1kzUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTltZFc1amRHbHZibk11ZEhNNk1qZ3hDaUFnSUNBdkx5QmpiMjV6ZENCYmIzWmxjbVpzYjNjc0lISmxjM1ZzZEYwZ1BTQnZjQzVrYVhadGIyUjNLQzR1TG05d0xtMTFiSGNvTGk0dWJuVnRaWEpoZEc5eWN5a3NJQzR1TG05d0xtMTFiSGNvTGk0dVpHVnViMjFwYm1GMGIzSnpLU2tLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnYlhWc2R3b2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2JYVnNkd29nSUNBZ1pHbDJiVzlrZHdvZ0lDQWdjRzl3YmlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZablZ1WTNScGIyNXpMblJ6T2pJNE1nb2dJQ0FnTHk4Z1lYTnpaWEowS0c5MlpYSm1iRzkzSUQwOVBTQXdMQ0JsY25KSmJuWmhiR2xrVUdWeVkyVnVkR0ZuWlNrS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QmxjbkpKY0dOMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZablZ1WTNScGIyNXpMblJ6T2pJNE13b2dJQ0FnTHk4Z2NtVjBkWEp1SUhKbGMzVnNkQW9nSUNBZ2NtVjBjM1ZpQ2dwM2FXUmxVbUYwYVc5ZlltOXZiRjltWVd4elpVQXpPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdJZ2QybGtaVkpoZEdsdlgySnZiMnhmYldWeVoyVkFOQW9LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12YzNSaGEybHVaeTF3YjNkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcFRkR0ZyYVc1blVHOTNaWEpIWVhSbExtTnlaV0YwWlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtTnlaV0YwWlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZjM1JoYTJsdVp5MXdiM2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pjMkNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2diMjVEY21WaGRHVTZJQ2R5WlhGMWFYSmxKeUI5S1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHpJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5aVlYTmxMV052Ym5SeVlXTjBjeTkxY0dkeVlXUmxZV0pzWlM1MGN6b3hOQW9nSUNBZ0x5OGdkbVZ5YzJsdmJpQTlJRWRzYjJKaGJGTjBZWFJsUEhOMGNtbHVaejRvZXlCclpYazZJRWRzYjJKaGJGTjBZWFJsUzJWNVZtVnljMmx2YmlCOUtRb2dJQ0FnY0hWemFHSjVkR1Z6SUNKMlpYSnphVzl1SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXpkR0ZyYVc1bkxYQnZkMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnpnS0lDQWdJQzh2SUhSb2FYTXVkbVZ5YzJsdmJpNTJZV3gxWlNBOUlIWmxjbk5wYjI0S0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5aVlYTmxMV052Ym5SeVlXTjBjeTkxY0dkeVlXUmxZV0pzWlM1MGN6b3hOZ29nSUNBZ0x5OGdZV3RwZEdGRVFVOGdQU0JIYkc5aVlXeFRkR0YwWlR4QmNIQnNhV05oZEdsdmJqNG9leUJyWlhrNklFZHNiMkpoYkZOMFlYUmxTMlY1UVd0cGRHRkVRVThnZlNrS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1GcmFYUmhYMlJoYnlJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZjM1JoYTJsdVp5MXdiM2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pjNUNpQWdJQ0F2THlCMGFHbHpMbUZyYVhSaFJFRlBMblpoYkhWbElEMGdRWEJ3YkdsallYUnBiMjRvWVd0cGRHRkVRVThwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXpkR0ZyYVc1bkxYQnZkMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnpZS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2V5QnZia055WldGMFpUb2dKM0psY1hWcGNtVW5JSDBwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5emRHRnJhVzVuTFhCdmQyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPbE4wWVd0cGJtZFFiM2RsY2tkaGRHVXVZMjl6ZEZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtTnZjM1E2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwzTjBZV3RwYm1jdGNHOTNaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem80TkFvZ0lDQWdMeThnWTI5emRDaGhjbWR6T2lCaWVYUmxjeWs2SUhWcGJuUTJOQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6TWdMeThnTWdvZ0lDQWdLd29nSUNBZ2MzZGhjQW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUhCMWMyaGllWFJsY3lBd2VERTFNV1kzWXpjMU1EQXdNREF3TURBd01EQXdNekJrTkFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5emRHRnJhVzVuTFhCdmQyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPbE4wWVd0cGJtZFFiM2RsY2tkaGRHVXVjbVZuYVhOMFpYSmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B5WldkcGMzUmxjam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmMzUmhhMmx1Wnkxd2IzZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamc0Q2lBZ0lDQXZMeUJ5WldkcGMzUmxjaWh0WW5KUVlYbHRaVzUwT2lCbmRIaHVMbEJoZVcxbGJuUlVlRzRzSUdGeVozTTZJR0o1ZEdWektUb2dkV2x1ZERZMElIc0tJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaSFZ3Q2lBZ0lDQm5kSGh1Y3lCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4eElDOHZJSEJoZVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QjBjbUZ1YzJGamRHbHZiaUIwZVhCbElHbHpJSEJoZVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3YmlBeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh6SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lHUjFjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5emRHRnJhVzVuTFhCdmQyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPRGtLSUNBZ0lDOHZJR3h2WjJkbFpFRnpjMlZ5ZENoaGNtZHpMbXhsYm1kMGFDQTlQVDBnUTJobFkydEJjbWR6UW5sMFpYTk1aVzVuZEdnc0lHVnlja2x1ZG1Gc2FXUkJjbWREYjNWdWRDa0tJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0F4TndvZ0lDQWdQVDBLSUNBZ0lHSnVlaUJ5WldkcGMzUmxjbDloWm5SbGNsOWhjM05sY25SQU13b2dJQ0FnWW5sMFpXTmZNeUF2THlBaVJWSlNPbVZ5Y2tsaGNtY2lDaUFnSUNCc2IyY0tJQ0FnSUdWeWNpQXZMeUJGVWxJNlpYSnlTV0Z5WndvS2NtVm5hWE4wWlhKZllXWjBaWEpmWVhOelpYSjBRRE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwzTjBZV3RwYm1jdGNHOTNaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem81TUFvZ0lDQWdMeThnYkc5bloyVmtRWE56WlhKMEtHMWljbEJoZVcxbGJuUXVjbVZqWldsMlpYSWdQVDA5SUVkc2IySmhiQzVqZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpMQ0JsY25KSmJuWmhiR2xrVUdGNWJXVnVkQ2tLSUNBZ0lHUnBaeUF5Q2lBZ0lDQm5kSGh1Y3lCU1pXTmxhWFpsY2dvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJRDA5Q2lBZ0lDQmlibm9nY21WbmFYTjBaWEpmWVdaMFpYSmZZWE56WlhKMFFEVUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z0lrVlNVanBsY25KSmNHRjVJZ29nSUNBZ2JHOW5DaUFnSUNCbGNuSWdMeThnUlZKU09tVnlja2x3WVhrS0NuSmxaMmx6ZEdWeVgyRm1kR1Z5WDJGemMyVnlkRUExT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXpkR0ZyYVc1bkxYQnZkMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T1RFS0lDQWdJQzh2SUd4dloyZGxaRUZ6YzJWeWRDaHRZbkpRWVhsdFpXNTBMbUZ0YjNWdWRDQTlQVDBnVTNSaGEybHVaMUJ2ZDJWeVIyRjBaVkpsWjJsemRISjVUVUpTTENCbGNuSkpiblpoYkdsa1VHRjViV1Z1ZENrS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1ozUjRibk1nUVcxdmRXNTBDaUFnSUNCd2RYTm9hVzUwSURFeU5UQXdDaUFnSUNBOVBRb2dJQ0FnWW01NklISmxaMmx6ZEdWeVgyRm1kR1Z5WDJGemMyVnlkRUEzQ2lBZ0lDQmllWFJsWXlBMElDOHZJQ0pGVWxJNlpYSnlTWEJoZVNJS0lDQWdJR3h2WndvZ0lDQWdaWEp5SUM4dklFVlNVanBsY25KSmNHRjVDZ3B5WldkcGMzUmxjbDloWm5SbGNsOWhjM05sY25SQU56b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12YzNSaGEybHVaeTF3YjNkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qazBDaUFnSUNBdkx5QnNiMmRuWldSQmMzTmxjblFvY0dGeVlXMXpMbTl3TG1GelZXbHVkRFkwS0NrZ1BEMGdOakFzSUdWeWNrSmhaRTl3WlhKaGRHbHZiaWtLSUNBZ0lITjNZWEFLSUNBZ0lHbHVkR05mTXlBdkx5QXlDaUFnSUNCblpYUmllWFJsQ2lBZ0lDQndkWE5vYVc1MElEWXdDaUFnSUNBOFBRb2dJQ0FnWW01NklISmxaMmx6ZEdWeVgyRm1kR1Z5WDJGemMyVnlkRUE1Q2lBZ0lDQndkWE5vWW5sMFpYTWdJa1ZTVWpwbGNuSkNiM0J5SWdvZ0lDQWdiRzluQ2lBZ0lDQmxjbklnTHk4Z1JWSlNPbVZ5Y2tKdmNISUtDbkpsWjJsemRHVnlYMkZtZEdWeVgyRnpjMlZ5ZEVBNU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl6ZEdGcmFXNW5MWEJ2ZDJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5URUtJQ0FnSUM4dklHTnZibk4wSUdsa0lEMGdkR2hwY3k1eVpXZHBjM1J5ZVVOMWNuTnZjaTUyWVd4MVpRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZjM1JoYTJsdVp5MXdiM2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNNENpQWdJQ0F2THlCeVpXZHBjM1J5ZVVOMWNuTnZjaUE5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b2V5QnBibWwwYVdGc1ZtRnNkV1U2SURFc0lHdGxlVG9nUjJGMFpVZHNiMkpoYkZOMFlYUmxTMlY1VW1WbmFYTjBjbmxEZFhKemIzSWdmU2tLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbkpsWjJsemRISjVYMk4xY25OdmNpSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12YzNSaGEybHVaeTF3YjNkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVXhDaUFnSUNBdkx5QmpiMjV6ZENCcFpDQTlJSFJvYVhNdWNtVm5hWE4wY25sRGRYSnpiM0l1ZG1Gc2RXVUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMM04wWVd0cGJtY3RjRzkzWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU1nb2dJQ0FnTHk4Z2RHaHBjeTV5WldkcGMzUnllVU4xY25OdmNpNTJZV3gxWlNBclBTQXhDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0FyQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwzTjBZV3RwYm1jdGNHOTNaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96T0FvZ0lDQWdMeThnY21WbmFYTjBjbmxEZFhKemIzSWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0hzZ2FXNXBkR2xoYkZaaGJIVmxPaUF4TENCclpYazZJRWRoZEdWSGJHOWlZV3hUZEdGMFpVdGxlVkpsWjJsemRISjVRM1Z5YzI5eUlIMHBDaUFnSUNCaWVYUmxZMTh5SUM4dklDSnlaV2RwYzNSeWVWOWpkWEp6YjNJaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMM04wWVd0cGJtY3RjRzkzWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU1nb2dJQ0FnTHk4Z2RHaHBjeTV5WldkcGMzUnllVU4xY25OdmNpNTJZV3gxWlNBclBTQXhDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5emRHRnJhVzVuTFhCdmQyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPVFlLSUNBZ0lDOHZJSFJvYVhNdWNtVm5hWE4wY25rb2FXUXBMblpoYkhWbElEMGdZMnh2Ym1Vb2NHRnlZVzF6S1FvZ0lDQWdhWFJ2WWdvZ0lDQWdaSFZ3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmMzUmhhMmx1Wnkxd2IzZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamc0Q2lBZ0lDQXZMeUJ5WldkcGMzUmxjaWh0WW5KUVlYbHRaVzUwT2lCbmRIaHVMbEJoZVcxbGJuUlVlRzRzSUdGeVozTTZJR0o1ZEdWektUb2dkV2x1ZERZMElIc0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMM04wWVd0cGJtY3RjRzkzWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlUzUmhhMmx1WjFCdmQyVnlSMkYwWlM1amFHVmphMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21Ob1pXTnJPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5emRHRnJhVzVuTFhCdmQyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEF3Q2lBZ0lDQXZMeUJqYUdWamF5aGpZV3hzWlhJNklFRmpZMjkxYm5Rc0lISmxaMmx6ZEhKNVNVUTZJSFZwYm5RMk5Dd2dZWEpuY3pvZ1lubDBaWE1wT2lCaWIyOXNaV0Z1SUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNeUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDNOMFlXdHBibWN0Y0c5M1pYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNREVLSUNBZ0lDOHZJR3h2WjJkbFpFRnpjMlZ5ZENoaGNtZHpMbXhsYm1kMGFDQTlQVDBnTUN3Z1pYSnlTVzUyWVd4cFpFRnlaME52ZFc1MEtRb2dJQ0FnYkdWdUNpQWdJQ0JpZWlCamFHVmphMTloWm5SbGNsOWhjM05sY25SQU13b2dJQ0FnWW5sMFpXTmZNeUF2THlBaVJWSlNPbVZ5Y2tsaGNtY2lDaUFnSUNCc2IyY0tJQ0FnSUdWeWNpQXZMeUJGVWxJNlpYSnlTV0Z5WndvS1kyaGxZMnRmWVdaMFpYSmZZWE56WlhKMFFETTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDNOMFlXdHBibWN0Y0c5M1pYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNRElLSUNBZ0lDOHZJR052Ym5OMElIc2diM0FzSUdGemMyVjBMQ0J3YjNkbGNpQjlJRDBnWTJ4dmJtVW9kR2hwY3k1eVpXZHBjM1J5ZVNoeVpXZHBjM1J5ZVVsRUtTNTJZV3gxWlNrS0lDQWdJR2wwYjJJS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdGemMyVnlkQ0F2THlCQ2IzZ2diWFZ6ZENCb1lYWmxJSFpoYkhWbENpQWdJQ0JrZFhBS0lDQWdJR1Y0ZEhKaFkzUWdNQ0F4Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmtkWEFLSUNBZ0lHVjRkSEpoWTNRZ01TQTRDaUFnSUNCemQyRndDaUFnSUNCd2RYTm9hVzUwSURrS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JqYjNabGNpQXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDNOMFlXdHBibWN0Y0c5M1pYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFPQW9nSUNBZ0x5OGdaMlYwUVd0cGRHRkJjSEJNYVhOMEtIUm9hWE11WVd0cGRHRkVRVTh1ZG1Gc2RXVXBMbk4wWVd0cGJtY3NDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMkpoYzJVdFkyOXVkSEpoWTNSekwzVndaM0poWkdWaFlteGxMblJ6T2pFMkNpQWdJQ0F2THlCaGEybDBZVVJCVHlBOUlFZHNiMkpoYkZOMFlYUmxQRUZ3Y0d4cFkyRjBhVzl1UGloN0lHdGxlVG9nUjJ4dlltRnNVM1JoZEdWTFpYbEJhMmwwWVVSQlR5QjlLUW9nSUNBZ1lubDBaV05mTVNBdkx5QWlZV3RwZEdGZlpHRnZJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5emRHRnJhVzVuTFhCdmQyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVGdLSUNBZ0lDOHZJR2RsZEVGcmFYUmhRWEJ3VEdsemRDaDBhR2x6TG1GcmFYUmhSRUZQTG5aaGJIVmxLUzV6ZEdGcmFXNW5MQW9nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTltZFc1amRHbHZibk11ZEhNNk1qQTJDaUFnSUNBdkx5QmpiMjV6ZENCYllYQndUR2x6ZEVKNWRHVnpYU0E5SUc5d0xrRndjRWRzYjJKaGJDNW5aWFJGZUVKNWRHVnpLR0ZyYVhSaFJFRlBMQ0JDZVhSbGN5aEJhMmwwWVVSQlQwZHNiMkpoYkZOMFlYUmxTMlY1YzBGcmFYUmhRWEJ3VEdsemRDa3BDaUFnSUNCd2RYTm9ZbmwwWlhNZ0ltRmhiQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0J3YjNBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZjM1JoYTJsdVp5MXdiM2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVNENpQWdJQ0F2THlCblpYUkJhMmwwWVVGd2NFeHBjM1FvZEdocGN5NWhhMmwwWVVSQlR5NTJZV3gxWlNrdWMzUmhhMmx1Wnl3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwyWjFibU4wYVc5dWN5NTBjem8zTXpFS0lDQWdJQzh2SUhKbGRIVnliaUJuWlhSVGRHRnJhVzVuVUc5M1pYSlVhSEp2ZFdkb0tITjBZV3RwYm1kQmNIQXNJSFZ6WlhJc0lHRnpjMlYwTENCSGJHOWlZV3d1YkdGMFpYTjBWR2x0WlhOMFlXMXdLUW9nSUNBZ1oyeHZZbUZzSUV4aGRHVnpkRlJwYldWemRHRnRjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJaMWJtTjBhVzl1Y3k1MGN6bzNNRFV0TnpFMENpQWdJQ0F2THlCamIyNXpkQ0JwYm1adklEMGdZV0pwUTJGc2JEeDBlWEJsYjJZZ1UzUmhhMmx1Wnk1d2NtOTBiM1I1Y0dVdVoyVjBTVzVtYno0b2V3b2dJQ0FnTHk4Z0lDQmhjSEJKWkRvZ2MzUmhhMmx1WjBGd2NDd0tJQ0FnSUM4dklDQWdZWEpuY3pvZ1d3b2dJQ0FnTHk4Z0lDQWdJSFZ6WlhJc0NpQWdJQ0F2THlBZ0lDQWdld29nSUNBZ0x5OGdJQ0FnSUNBZ1lYTnpaWFFzQ2lBZ0lDQXZMeUFnSUNBZ0lDQjBlWEJsT2lCVFZFRkxTVTVIWDFSWlVFVmZURTlEU3l3S0lDQWdJQzh2SUNBZ0lDQjlMQW9nSUNBZ0x5OGdJQ0JkTEFvZ0lDQWdMeThnZlNrdWNtVjBkWEp1Vm1Gc2RXVUtJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OW1kVzVqZEdsdmJuTXVkSE02TnpBNUxUY3hNZ29nSUNBZ0x5OGdld29nSUNBZ0x5OGdJQ0JoYzNObGRDd0tJQ0FnSUM4dklDQWdkSGx3WlRvZ1UxUkJTMGxPUjE5VVdWQkZYMHhQUTBzc0NpQWdJQ0F2THlCOUxBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlpuVnVZM1JwYjI1ekxuUnpPamN4TVFvZ0lDQWdMeThnZEhsd1pUb2dVMVJCUzBsT1IxOVVXVkJGWDB4UFEwc3NDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3lPQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJaMWJtTjBhVzl1Y3k1MGN6bzNNRGt0TnpFeUNpQWdJQ0F2THlCN0NpQWdJQ0F2THlBZ0lHRnpjMlYwTEFvZ0lDQWdMeThnSUNCMGVYQmxPaUJUVkVGTFNVNUhYMVJaVUVWZlRFOURTeXdLSUNBZ0lDOHZJSDBzQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlpuVnVZM1JwYjI1ekxuUnpPamN3TlMwM01UUUtJQ0FnSUM4dklHTnZibk4wSUdsdVptOGdQU0JoWW1sRFlXeHNQSFI1Y0dWdlppQlRkR0ZyYVc1bkxuQnliM1J2ZEhsd1pTNW5aWFJKYm1adlBpaDdDaUFnSUNBdkx5QWdJR0Z3Y0Vsa09pQnpkR0ZyYVc1blFYQndMQW9nSUNBZ0x5OGdJQ0JoY21kek9pQmJDaUFnSUNBdkx5QWdJQ0FnZFhObGNpd0tJQ0FnSUM4dklDQWdJQ0I3Q2lBZ0lDQXZMeUFnSUNBZ0lDQmhjM05sZEN3S0lDQWdJQzh2SUNBZ0lDQWdJSFI1Y0dVNklGTlVRVXRKVGtkZlZGbFFSVjlNVDBOTExBb2dJQ0FnTHk4Z0lDQWdJSDBzQ2lBZ0lDQXZMeUFnSUYwc0NpQWdJQ0F2THlCOUtTNXlaWFIxY201V1lXeDFaUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRaRFF3TVRZeVlXWWdMeThnYldWMGFHOWtJQ0puWlhSSmJtWnZLR0ZrWkhKbGMzTXNLSFZwYm5RMk5DeDFhVzUwT0NrcEtIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5Da2lDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUhCMWMyaHBiblFnTmlBdkx5QmhjSEJzQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0JwZEhodUlFeGhjM1JNYjJjS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ013b2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJRFFnTUFvZ0lDQWdaR2xuSURFS0lDQWdJR1Y0ZEhKaFkzUWdNQ0EwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1FubDBaWE1nYUdGeklIWmhiR2xrSUhCeVpXWnBlQW9nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1JoYTJsdVp5OTBlWEJsY3k1MGN6bzZVM1JoYTJVS0lDQWdJSEIxYzJocGJuUWdNakFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5bWRXNWpkR2x2Ym5NdWRITTZOekUyQ2lBZ0lDQXZMeUJwWmlBb2FXNW1ieTVsZUhCcGNtRjBhVzl1SUR3OUlISmxjWFZwY21Wa1ZHaHliM1ZuYUNrZ2V3b2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdSMWNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQThQUW9nSUNBZ1lub2dZMmhsWTJ0ZllXWjBaWEpmYVdaZlpXeHpaVUEyQ2lBZ0lDQndiM0FLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwyWjFibU4wYVc5dWN5NTBjem8zTVRjS0lDQWdJQzh2SUhKbGRIVnliaUF3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9LWTJobFkydGZZV1owWlhKZmFXNXNhVzVsWkY5emJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZablZ1WTNScGIyNXpMblJ6T2pwblpYUlRkR0ZyYVc1blVHOTNaWEpVYUhKdmRXZG9RRGs2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwzTjBZV3RwYm1jdGNHOTNaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTkFvZ0lDQWdMeThnWTJGelpTQkZjWFZoYkRvZ2NtVjBkWEp1SUhWelpYSlFiM2RsY2lBOVBUMGdjRzkzWlhJS0lDQWdJR1JwWnlBeENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd1lRb2dJQ0FnUFQwS0lDQWdJR0o2SUdOb1pXTnJYMkZtZEdWeVgybG1YMlZzYzJWQU1URUtJQ0FnSUdKMWNua2dNUW9nSUNBZ1BUMEtDbU5vWldOclgyRm1kR1Z5WDJsdWJHbHVaV1JmYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXpkR0ZyYVc1bkxYQnZkMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2xOMFlXdHBibWRRYjNkbGNrZGhkR1V1YzNSaGEybHVaMUJ2ZDJWeVIyRjBaVUF5TWpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZjM1JoYTJsdVp5MXdiM2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFd01Bb2dJQ0FnTHk4Z1kyaGxZMnNvWTJGc2JHVnlPaUJCWTJOdmRXNTBMQ0J5WldkcGMzUnllVWxFT2lCMWFXNTBOalFzSUdGeVozTTZJR0o1ZEdWektUb2dZbTl2YkdWaGJpQjdDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlYwWW1sMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncGphR1ZqYTE5aFpuUmxjbDlwWmw5bGJITmxRREV4T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXpkR0ZyYVc1bkxYQnZkMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpVS0lDQWdJQzh2SUdOaGMyVWdUbTkwUlhGMVlXdzZJSEpsZEhWeWJpQjFjMlZ5VUc5M1pYSWdJVDA5SUhCdmQyVnlDaUFnSUNCa2FXY2dNUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNVFFLSUNBZ0lEMDlDaUFnSUNCaWVpQmphR1ZqYTE5aFpuUmxjbDlwWmw5bGJITmxRREV6Q2lBZ0lDQmlkWEo1SURFS0lDQWdJQ0U5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwzTjBZV3RwYm1jdGNHOTNaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TURNS0lDQWdJQzh2SUhKbGRIVnliaUIwYUdsekxuTjBZV3RwYm1kUWIzZGxja2RoZEdVb1kyRnNiR1Z5TENCdmNDd2dZWE56WlhRc0lIQnZkMlZ5S1FvZ0lDQWdZaUJqYUdWamExOWhablJsY2w5cGJteHBibVZrWDNOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZjM1JoYTJsdVp5MXdiM2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwVGRHRnJhVzVuVUc5M1pYSkhZWFJsTG5OMFlXdHBibWRRYjNkbGNrZGhkR1ZBTWpJS0NtTm9aV05yWDJGbWRHVnlYMmxtWDJWc2MyVkFNVE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwzTjBZV3RwYm1jdGNHOTNaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTmdvZ0lDQWdMeThnWTJGelpTQk1aWE56VkdoaGJqb2djbVYwZFhKdUlIVnpaWEpRYjNkbGNpQThJSEJ2ZDJWeUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1XVUtJQ0FnSUQwOUNpQWdJQ0JpZWlCamFHVmphMTloWm5SbGNsOXBabDlsYkhObFFERTFDaUFnSUNCaWRYSjVJREVLSUNBZ0lENEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12YzNSaGEybHVaeTF3YjNkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXdNd29nSUNBZ0x5OGdjbVYwZFhKdUlIUm9hWE11YzNSaGEybHVaMUJ2ZDJWeVIyRjBaU2hqWVd4c1pYSXNJRzl3TENCaGMzTmxkQ3dnY0c5M1pYSXBDaUFnSUNCaUlHTm9aV05yWDJGbWRHVnlYMmx1YkdsdVpXUmZjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5emRHRnJhVzVuTFhCdmQyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPbE4wWVd0cGJtZFFiM2RsY2tkaGRHVXVjM1JoYTJsdVoxQnZkMlZ5UjJGMFpVQXlNZ29LWTJobFkydGZZV1owWlhKZmFXWmZaV3h6WlVBeE5Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12YzNSaGEybHVaeTF3YjNkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWTNDaUFnSUNBdkx5QmpZWE5sSUV4bGMzTlVhR0Z1VDNKRmNYVmhiRlJ2T2lCeVpYUjFjbTRnZFhObGNsQnZkMlZ5SUR3OUlIQnZkMlZ5Q2lBZ0lDQmthV2NnTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwyWjFibU4wYVc5dWN5NTBjem8zTVRFS0lDQWdJQzh2SUhSNWNHVTZJRk5VUVV0SlRrZGZWRmxRUlY5TVQwTkxMQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNamdLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmMzUmhhMmx1Wnkxd2IzZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalkzQ2lBZ0lDQXZMeUJqWVhObElFeGxjM05VYUdGdVQzSkZjWFZoYkZSdk9pQnlaWFIxY200Z2RYTmxjbEJ2ZDJWeUlEdzlJSEJ2ZDJWeUNpQWdJQ0E5UFFvZ0lDQWdZbm9nWTJobFkydGZZV1owWlhKZmFXWmZaV3h6WlVBeE53b2dJQ0FnWW5WeWVTQXhDaUFnSUNBK1BRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl6ZEdGcmFXNW5MWEJ2ZDJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UQXpDaUFnSUNBdkx5QnlaWFIxY200Z2RHaHBjeTV6ZEdGcmFXNW5VRzkzWlhKSFlYUmxLR05oYkd4bGNpd2diM0FzSUdGemMyVjBMQ0J3YjNkbGNpa0tJQ0FnSUdJZ1kyaGxZMnRmWVdaMFpYSmZhVzVzYVc1bFpGOXpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDNOMFlXdHBibWN0Y0c5M1pYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZVM1JoYTJsdVoxQnZkMlZ5UjJGMFpTNXpkR0ZyYVc1blVHOTNaWEpIWVhSbFFESXlDZ3BqYUdWamExOWhablJsY2w5cFpsOWxiSE5sUURFM09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl6ZEdGcmFXNW5MWEJ2ZDJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5qZ0tJQ0FnSUM4dklHTmhjMlVnUjNKbFlYUmxjbFJvWVc0NklISmxkSFZ5YmlCMWMyVnlVRzkzWlhJZ1BpQndiM2RsY2dvZ0lDQWdaR2xuSURFS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURNeUNpQWdJQ0E5UFFvZ0lDQWdZbm9nWTJobFkydGZZV1owWlhKZmFXWmZaV3h6WlVBeE9Rb2dJQ0FnWW5WeWVTQXhDaUFnSUNBOENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMM04wWVd0cGJtY3RjRzkzWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1ETUtJQ0FnSUM4dklISmxkSFZ5YmlCMGFHbHpMbk4wWVd0cGJtZFFiM2RsY2tkaGRHVW9ZMkZzYkdWeUxDQnZjQ3dnWVhOelpYUXNJSEJ2ZDJWeUtRb2dJQ0FnWWlCamFHVmphMTloWm5SbGNsOXBibXhwYm1Wa1gzTnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12YzNSaGEybHVaeTF3YjNkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcFRkR0ZyYVc1blVHOTNaWEpIWVhSbExuTjBZV3RwYm1kUWIzZGxja2RoZEdWQU1qSUtDbU5vWldOclgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRrNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMM04wWVd0cGJtY3RjRzkzWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk9Rb2dJQ0FnTHk4Z1kyRnpaU0JIY21WaGRHVnlWR2hoYms5eVJYRjFZV3hVYnpvZ2NtVjBkWEp1SUhWelpYSlFiM2RsY2lBK1BTQndiM2RsY2dvZ0lDQWdjM2RoY0FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TTJNS0lDQWdJRDA5Q2lBZ0lDQmllaUJqYUdWamExOWhablJsY2w5cFpsOWxiSE5sUURJeENpQWdJQ0E4UFFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXpkR0ZyYVc1bkxYQnZkMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRBekNpQWdJQ0F2THlCeVpYUjFjbTRnZEdocGN5NXpkR0ZyYVc1blVHOTNaWEpIWVhSbEtHTmhiR3hsY2l3Z2IzQXNJR0Z6YzJWMExDQndiM2RsY2lrS0lDQWdJR0lnWTJobFkydGZZV1owWlhKZmFXNXNhVzVsWkY5emJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMM04wWVd0cGJtY3RjRzkzWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlUzUmhhMmx1WjFCdmQyVnlSMkYwWlM1emRHRnJhVzVuVUc5M1pYSkhZWFJsUURJeUNncGphR1ZqYTE5aFpuUmxjbDlwWmw5bGJITmxRREl4T2dvZ0lDQWdjRzl3YmlBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMM04wWVd0cGJtY3RjRzkzWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM01Bb2dJQ0FnTHk4Z1pHVm1ZWFZzZERvZ2NtVjBkWEp1SUdaaGJITmxDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl6ZEdGcmFXNW5MWEJ2ZDJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UQXpDaUFnSUNBdkx5QnlaWFIxY200Z2RHaHBjeTV6ZEdGcmFXNW5VRzkzWlhKSFlYUmxLR05oYkd4bGNpd2diM0FzSUdGemMyVjBMQ0J3YjNkbGNpa0tJQ0FnSUdJZ1kyaGxZMnRmWVdaMFpYSmZhVzVzYVc1bFpGOXpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDNOMFlXdHBibWN0Y0c5M1pYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZVM1JoYTJsdVoxQnZkMlZ5UjJGMFpTNXpkR0ZyYVc1blVHOTNaWEpIWVhSbFFESXlDZ3BqYUdWamExOWhablJsY2w5cFpsOWxiSE5sUURZNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZablZ1WTNScGIyNXpMblJ6T2pjeU1Bb2dJQ0FnTHk4Z1kyOXVjM1FnY21WdFlXbHVhVzVuVkdsdFpUb2dkV2x1ZERZMElEMGdhVzVtYnk1bGVIQnBjbUYwYVc5dUlDMGdSMnh2WW1Gc0xteGhkR1Z6ZEZScGJXVnpkR0Z0Y0FvZ0lDQWdaMnh2WW1Gc0lFeGhkR1Z6ZEZScGJXVnpkR0Z0Y0FvZ0lDQWdMUW9nSUNBZ1pIVndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Wm5WdVkzUnBiMjV6TG5Sek9qY3lNZ29nSUNBZ0x5OGdhV1lnS0hKbGJXRnBibWx1WjFScGJXVWdQQ0JQVGtWZlYwVkZTeWtnZXdvZ0lDQWdjSFZ6YUdsdWRDQTJNRFE0TURBS0lDQWdJRHdLSUNBZ0lHSjZJR05vWldOclgyRm1kR1Z5WDJsbVgyVnNjMlZBT0FvZ0lDQWdjRzl3Q2lBZ0lDQmlkWEo1SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OW1kVzVqZEdsdmJuTXVkSE02TnpJekNpQWdJQ0F2THlCeVpYUjFjbTRnTUFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5bWRXNWpkR2x2Ym5NdWRITTZOek14Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdaMlYwVTNSaGEybHVaMUJ2ZDJWeVZHaHliM1ZuYUNoemRHRnJhVzVuUVhCd0xDQjFjMlZ5TENCaGMzTmxkQ3dnUjJ4dlltRnNMbXhoZEdWemRGUnBiV1Z6ZEdGdGNDa0tJQ0FnSUdJZ1kyaGxZMnRmWVdaMFpYSmZhVzVzYVc1bFpGOXpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Wm5WdVkzUnBiMjV6TG5Sek9qcG5aWFJUZEdGcmFXNW5VRzkzWlhKVWFISnZkV2RvUURrS0NtTm9aV05yWDJGbWRHVnlYMmxtWDJWc2MyVkFPRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5bWRXNWpkR2x2Ym5NdWRITTZOekkyQ2lBZ0lDQXZMeUJqYjI1emRDQnlaVzFoYVc1cGJtZEVZWGx6T2lCMWFXNTBOalFnUFNCeVpXMWhhVzVwYm1kVWFXMWxJQzhnVDA1RlgwUkJXUW9nSUNBZ2NIVnphR2x1ZENBNE5qUXdNQW9nSUNBZ0x3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMloxYm1OMGFXOXVjeTUwY3pvM01qY0tJQ0FnSUM4dklISmxkSFZ5YmlCdmNDNWthWFozS0M0dUxtOXdMbTExYkhjb2QybGtaVkpoZEdsdktGdHBibVp2TG1GdGIzVnVkQ3dnTVY4d01EQmZNREF3WFN3Z1cwOU9SVjlaUlVGU1gwbE9YMFJCV1ZNc0lERmZNREF3WHpBd01GMHBMQ0J5WlcxaGFXNXBibWRFWVhsektTd2dNVjh3TURCZk1EQXdLUW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JsZUhSeVlXTjBJRFFnT0FvZ0lDQWdhVzUwWXlBMElDOHZJREV3TURBd01EQUtJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCaWVYUmxZeUExSUM4dklEQjRNREF3TURBd01EQXdNREF3TURFMlpEQXdNREF3TURBd01EQXdaalF5TkRBS0lDQWdJR05oYkd4emRXSWdkMmxrWlZKaGRHbHZDaUFnSUNCa2FXY2dNZ29nSUNBZ2JYVnNkd29nSUNBZ2NHOXdDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmllWFJsWXlBMUlDOHZJREI0TURBd01EQXdNREF3TURBd01ERTJaREF3TURBd01EQXdNREF3WmpReU5EQUtJQ0FnSUdOaGJHeHpkV0lnZDJsa1pWSmhkR2x2Q2lBZ0lDQnRkV3gzQ2lBZ0lDQmlkWEo1SURFS0lDQWdJR2x1ZEdNZ05DQXZMeUF4TURBd01EQXdDaUFnSUNCa2FYWjNDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Wm5WdVkzUnBiMjV6TG5Sek9qY3pNUW9nSUNBZ0x5OGdjbVYwZFhKdUlHZGxkRk4wWVd0cGJtZFFiM2RsY2xSb2NtOTFaMmdvYzNSaGEybHVaMEZ3Y0N3Z2RYTmxjaXdnWVhOelpYUXNJRWRzYjJKaGJDNXNZWFJsYzNSVWFXMWxjM1JoYlhBcENpQWdJQ0JpSUdOb1pXTnJYMkZtZEdWeVgybHViR2x1WldSZmMyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMloxYm1OMGFXOXVjeTUwY3pvNloyVjBVM1JoYTJsdVoxQnZkMlZ5VkdoeWIzVm5hRUE1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5emRHRnJhVzVuTFhCdmQyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPbE4wWVd0cGJtZFFiM2RsY2tkaGRHVXVaMlYwVW1WbmFYTjBjbUYwYVc5dVUyaGhjR1ZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwblpYUlNaV2RwYzNSeVlYUnBiMjVUYUdGd1pUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12YzNSaGEybHVaeTF3YjNkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXdOZ29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUhKbFlXUnZibXg1T2lCMGNuVmxJSDBwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBeE53b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXpkR0ZyYVc1bkxYQnZkMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2xOMFlXdHBibWRRYjNkbGNrZGhkR1ZTWldkcGMzUnllVWx1Wm04S0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwzTjBZV3RwYm1jdGNHOTNaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VTNSaGEybHVaMUJ2ZDJWeVIyRjBaUzVuWlhSRmJuUnllVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21kbGRFVnVkSEo1T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXpkR0ZyYVc1bkxYQnZkMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRFeENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2djbVZoWkc5dWJIazZJSFJ5ZFdVZ2ZTa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmMzUmhhMmx1Wnkxd2IzZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV4TXdvZ0lDQWdMeThnY21WMGRYSnVJR1Z1WTI5a1pVRnlZelFvZEdocGN5NXlaV2RwYzNSeWVTaHlaV2RwYzNSeWVVbEVLUzUyWVd4MVpTa0tJQ0FnSUdsMGIySUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QkNiM2dnYlhWemRDQm9ZWFpsSUhaaGJIVmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDNOMFlXdHBibWN0Y0c5M1pYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNVEVLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU0I5S1FvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12WW1GelpTMWpiMjUwY21GamRITXZkWEJuY21Ga1pXRmliR1V1ZEhNNk9rRnJhWFJoUW1GelpVTnZiblJ5WVdOMExuVndaR0YwWlVGcmFYUmhSRUZQVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2RYQmtZWFJsUVd0cGRHRkVRVTg2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlltRnpaUzFqYjI1MGNtRmpkSE12ZFhCbmNtRmtaV0ZpYkdVdWRITTZNalVLSUNBZ0lDOHZJSFZ3WkdGMFpVRnJhWFJoUkVGUEtHRnJhWFJoUkVGUE9pQkJjSEJzYVdOaGRHbHZiaWs2SUhadmFXUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwySmhjMlV0WTI5dWRISmhZM1J6TDNWd1ozSmhaR1ZoWW14bExuUnpPakkyQ2lBZ0lDQXZMeUJzYjJkblpXUkJjM05sY25Rb1ZIaHVMbk5sYm1SbGNpQTlQVDBnZEdocGN5NW5aWFJCYTJsMFlVUkJUMWRoYkd4bGRDZ3BMbUZrWkhKbGMzTXNJR1Z5Y2s1dmRFRnJhWFJoUkdGdktRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwySmhjMlV0WTI5dWRISmhZM1J6TDNWd1ozSmhaR1ZoWW14bExuUnpPakU1Q2lBZ0lDQXZMeUJqYjI1emRDQmJkMkZzYkdWMFNVUmRJRDBnYjNBdVFYQndSMnh2WW1Gc0xtZGxkRVY0VldsdWREWTBLSFJvYVhNdVlXdHBkR0ZFUVU4dWRtRnNkV1VzSUVKNWRHVnpLRUZyYVhSaFJFRlBSMnh2WW1Gc1UzUmhkR1ZMWlhselYyRnNiR1YwS1NrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlltRnpaUzFqYjI1MGNtRmpkSE12ZFhCbmNtRmtaV0ZpYkdVdWRITTZNVFlLSUNBZ0lDOHZJR0ZyYVhSaFJFRlBJRDBnUjJ4dlltRnNVM1JoZEdVOFFYQndiR2xqWVhScGIyNCtLSHNnYTJWNU9pQkhiRzlpWVd4VGRHRjBaVXRsZVVGcmFYUmhSRUZQSUgwcENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKaGEybDBZVjlrWVc4aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZZbUZ6WlMxamIyNTBjbUZqZEhNdmRYQm5jbUZrWldGaWJHVXVkSE02TVRrS0lDQWdJQzh2SUdOdmJuTjBJRnQzWVd4c1pYUkpSRjBnUFNCdmNDNUJjSEJIYkc5aVlXd3VaMlYwUlhoVmFXNTBOalFvZEdocGN5NWhhMmwwWVVSQlR5NTJZV3gxWlN3Z1FubDBaWE1vUVd0cGRHRkVRVTlIYkc5aVlXeFRkR0YwWlV0bGVYTlhZV3hzWlhRcEtRb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJSEIxYzJoaWVYUmxjeUFpZDJGc2JHVjBJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJSEJ2Y0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwySmhjMlV0WTI5dWRISmhZM1J6TDNWd1ozSmhaR1ZoWW14bExuUnpPakkyQ2lBZ0lDQXZMeUJzYjJkblpXUkJjM05sY25Rb1ZIaHVMbk5sYm1SbGNpQTlQVDBnZEdocGN5NW5aWFJCYTJsMFlVUkJUMWRoYkd4bGRDZ3BMbUZrWkhKbGMzTXNJR1Z5Y2s1dmRFRnJhWFJoUkdGdktRb2dJQ0FnWVhCd1gzQmhjbUZ0YzE5blpYUWdRWEJ3UVdSa2NtVnpjd29nSUNBZ1lYTnpaWEowSUM4dklHRndjR3hwWTJGMGFXOXVJR1Y0YVhOMGN3b2dJQ0FnUFQwS0lDQWdJR0p1ZWlCMWNHUmhkR1ZCYTJsMFlVUkJUMTloWm5SbGNsOWhjM05sY25SQU13b2dJQ0FnY0hWemFHSjVkR1Z6SUNKRlVsSTZaWEp5VG1SaGJ5SUtJQ0FnSUd4dlp3b2dJQ0FnWlhKeUlDOHZJRVZTVWpwbGNuSk9aR0Z2Q2dwMWNHUmhkR1ZCYTJsMFlVUkJUMTloWm5SbGNsOWhjM05sY25SQU16b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTlpWVhObExXTnZiblJ5WVdOMGN5OTFjR2R5WVdSbFlXSnNaUzUwY3pveE5nb2dJQ0FnTHk4Z1lXdHBkR0ZFUVU4Z1BTQkhiRzlpWVd4VGRHRjBaVHhCY0hCc2FXTmhkR2x2Ymo0b2V5QnJaWGs2SUVkc2IySmhiRk4wWVhSbFMyVjVRV3RwZEdGRVFVOGdmU2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbUZyYVhSaFgyUmhieUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5aVlYTmxMV052Ym5SeVlXTjBjeTkxY0dkeVlXUmxZV0pzWlM1MGN6b3lOd29nSUNBZ0x5OGdkR2hwY3k1aGEybDBZVVJCVHk1MllXeDFaU0E5SUdGcmFYUmhSRUZQQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwySmhjMlV0WTI5dWRISmhZM1J6TDNWd1ozSmhaR1ZoWW14bExuUnpPakkxQ2lBZ0lDQXZMeUIxY0dSaGRHVkJhMmwwWVVSQlR5aGhhMmwwWVVSQlR6b2dRWEJ3YkdsallYUnBiMjRwT2lCMmIybGtJSHNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERUtJQ0FnSUhKbGRIVnliZ289In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRkFBRUlBc0NFUFNZR0JCVWZmSFVKWVd0cGRHRmZaR0Z2RDNKbFoybHpkSEo1WDJOMWNuTnZjZ3RGVWxJNlpYSnlTV0Z5Wnd0RlVsSTZaWEp5U1hCaGVSQUFBQUFBQUFBQmJRQUFBQUFBRDBKQU1SaEFBRDhxSTJlQ0FoSnlaV2RwYzNSeVlYUnBiMjVmYzJoaGNHVVZLSFZwYm5RNExIVnBiblEyTkN4MWFXNTBOalFwWjRJQ0MyTm9aV05yWDNOb1lYQmxBR2N4R1JSRU1SaEJBRHVDQndReW53VHVCSGU3ZWJrRWJnUDFDZ1MxM0dZM0JKRFUrbDBFTStrc2xBU0ZUZTNnTmhvQWpnY0FhZ0NIQVBjQ0tBSTNBbEVBQVFBalE0QUV6WnJXZmpZYUFJNEJBREFBaWdJQmkvOGlXMGxCQUNDTC95UmJRUUFaSTBTTC9pSmJpLzRrV3gyTC95UmJUd01kSDBZQ1RCUkVpU0pDLytRMkdnRkpJbGtsQ0VzQkZSSkVWd0lBTmhvQ1NSVWtFa1FYZ0FkMlpYSnphVzl1VHdKbktVeG5JME0yR2dGSklsa2xDRXdWRWtTQURCVWZmSFVBQUFBQUFBQXcxTEFqUXpFV0l3bEpPQkFqRWtRMkdnRkhBaUpaSlFoTEFSVVNSRmNDQUVrVmdSRVNRQUFESzdBQVN3STRCeklLRWtBQUJDY0VzQUJQQWpnSWdkUmhFa0FBQkNjRXNBQk1KVldCUEE1QUFBK0FDMFZTVWpwbGNuSkNiM0J5c0FBaUttVkVTU01JS2t4bkZrbFBBcjhvVEZDd0kwTTJHZ0ZKRllFZ0VrUTJHZ0pKRlNRU1JCYzJHZ05KSWxrbENFc0JGUkpFVndJQUZVRUFBeXV3QUJhK1JFbFhBQUZNU1ZjQkNFeUJDVnRPQWlJcFpVU0FBMkZoYkdWSUlsc3lCN0ZQQW9BQktGQlBBcklZZ0FUVUFXS3ZzaHBQQkxJYXNocUJCcklRSXJJQnM3UStTVTREU1ZjRUFFc0JWd0FFS0JKRUZZRWdFa1NCRkZ0SlR3SU9RUUJyU0VVQklrc0JnQUVLRWtFQUVFVUJFb0FCQUNKUEFsUW9URkN3STBOTEFZQUJGQkpCQUFaRkFSTkMvK1JMQVlBQkhoSkJBQVpGQVExQy85VkxBWUFCS0JKQkFBWkZBUTlDLzhaTEFZQUJNaEpCQUFaRkFReEMvN2RNZ0FFOEVrRUFCQTVDLzZ0R0FpSkMvNlV5QndsSmdZRDFKQXhCQUFkSVJRRWlRditHZ1lDakJRcFBBbGNFQ0NFRUZsQkpKd1dJL2YxTEFoMUlUZ0luQllqOThoMUZBU0VFbDBML1hqWWFBVWtWZ1JFU1JDaE1VTEFqUXpZYUFVa1ZKQkpFRnhhK1JFa1ZGbGNHQWt4UUtFeFFzQ05ETmhvQlNSVWtFa1FYTVFBaUtXVkVnQVozWVd4c1pYUmxTSElJUkJKQUFBK0FDMFZTVWpwbGNuSk9aR0Z2c0FBcFRHY2pRdz09IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6MTAsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
