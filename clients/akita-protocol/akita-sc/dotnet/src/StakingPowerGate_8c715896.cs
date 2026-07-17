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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU3Rha2luZ1Bvd2VyR2F0ZSIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJTdGFraW5nUG93ZXJHYXRlUmVnaXN0cnlJbmZvIjpbeyJuYW1lIjoib3AiLCJ0eXBlIjoidWludDgifSx7Im5hbWUiOiJhc3NldCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJwb3dlciIsInR5cGUiOiJ1aW50NjQifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZlcnNpb24iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFraXRhREFPIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNvc3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXJncyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlZ2lzdGVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1iclBheW1lbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFyZ3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjaGVjayIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FsbGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWdpc3RyeUlEIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcmdzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFJlZ2lzdHJhdGlvblNoYXBlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6Iih1aW50OCx1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IlN0YWtpbmdQb3dlckdhdGVSZWdpc3RyeUluZm8iLCJuYW1lIjoic2hhcGUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ4LHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiU3Rha2luZ1Bvd2VyR2F0ZVJlZ2lzdHJ5SW5mbyIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0RW50cnkiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVnaXN0cnlJRCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidXBkYXRlQWtpdGFEQU8iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWtpdGFEQU8iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoib3BVcCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MiwiYnl0ZXMiOjN9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzUwOCw4MTRdLCJlcnJvck1lc3NhZ2UiOiJCb3ggbXVzdCBoYXZlIHZhbHVlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTg1XSwiZXJyb3JNZXNzYWdlIjoiQnl0ZXMgaGFzIHZhbGlkIHByZWZpeCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQzNl0sImVycm9yTWVzc2FnZSI6IkVSUjpCT1BSIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzg1LDUwNF0sImVycm9yTWVzc2FnZSI6IkVSUjpJQVJHIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzk5LDQxNF0sImVycm9yTWVzc2FnZSI6IkVSUjpJUEFZIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODcyXSwiZXJyb3JNZXNzYWdlIjoiRVJSOk5EQU8iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNDcsMjY5XSwiZXJyb3JNZXNzYWdlIjoiSVBDVCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzg1Nl0sImVycm9yTWVzc2FnZSI6ImFwcGxpY2F0aW9uIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ0MCw1MjgsODQzXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgR2xvYmFsU3RhdGUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjgxLDMyMywzNjMsNDg2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjg4LDMyOSwzNzAsNDkzXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ3MV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyOTksNDc5LDgxMCw4MzZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3OTZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3Igc21hcnRfY29udHJhY3RzL2dhdGVzL3N1Yi1nYXRlcy9zdGFraW5nLXBvd2VyL2NvbnRyYWN0LmFsZ28udHM6OlN0YWtpbmdQb3dlckdhdGVSZWdpc3RyeUluZm8iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1OTBdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3Igc21hcnRfY29udHJhY3RzL3N0YWtpbmcvdHlwZXMudHM6OlN0YWtlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzU2XSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBwYXkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01DQXhJRGdnTWlBeE1EQXdNREF3Q2lBZ0lDQmllWFJsWTJKc2IyTnJJREI0TVRVeFpqZGpOelVnSW1GcmFYUmhYMlJoYnlJZ0luSmxaMmx6ZEhKNVgyTjFjbk52Y2lJZ0lpSWdJa1ZTVWpwSlFWSkhJaUFpUlZKU09rbFFRVmtpSURCNE1EQXdNREF3TURBd01EQXdNREUyWkRBd01EQXdNREF3TURBd1pqUXlOREFLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpYm5vZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFESUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12YzNSaGEybHVaeTF3YjNkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTRDaUFnSUNBdkx5QnlaV2RwYzNSeWVVTjFjbk52Y2lBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9leUJwYm1sMGFXRnNWbUZzZFdVNklERXNJR3RsZVRvZ1IyRjBaVWRzYjJKaGJGTjBZWFJsUzJWNVVtVm5hWE4wY25sRGRYSnpiM0lnZlNrS0lDQWdJR0o1ZEdWalh6SWdMeThnSW5KbFoybHpkSEo1WDJOMWNuTnZjaUlLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5emRHRnJhVzVuTFhCdmQyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOREFLSUNBZ0lDOHZJSEpsWjJsemRISmhkR2x2YmxOb1lYQmxJRDBnUjJ4dlltRnNVM1JoZEdVOGMzUnlhVzVuUGloN0lHbHVhWFJwWVd4V1lXeDFaVG9nSnloMWFXNTBPQ3gxYVc1ME5qUXNkV2x1ZERZMEtTY3NJR3RsZVRvZ1IyRjBaVWRzYjJKaGJGTjBZWFJsUzJWNVVtVm5hWE4wY21GMGFXOXVVMmhoY0dVZ2ZTa0tJQ0FnSUhCMWMyaGllWFJsYzNNZ0luSmxaMmx6ZEhKaGRHbHZibDl6YUdGd1pTSWdJaWgxYVc1ME9DeDFhVzUwTmpRc2RXbHVkRFkwS1NJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMM04wWVd0cGJtY3RjRzkzWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME1nb2dJQ0FnTHk4Z1kyaGxZMnRUYUdGd1pTQTlJRWRzYjJKaGJGTjBZWFJsUEhOMGNtbHVaejRvZXlCcGJtbDBhV0ZzVm1Gc2RXVTZJQ2NuTENCclpYazZJRWRoZEdWSGJHOWlZV3hUZEdGMFpVdGxlVU5vWldOclUyaGhjR1VnZlNrS0lDQWdJSEIxYzJoaWVYUmxjeUFpWTJobFkydGZjMmhoY0dVaUNpQWdJQ0JpZVhSbFkxOHpJQzh2SUNJaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb0tiV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwzTjBZV3RwYm1jdGNHOTNaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TkFvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklGTjBZV3RwYm1kUWIzZGxja2RoZEdVZ1pYaDBaVzVrY3lCQmEybDBZVUpoYzJWRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmllaUJ0WVdsdVgyTnlaV0YwWlY5T2IwOXdRREV6Q2lBZ0lDQndkWE5vWW5sMFpYTnpJREI0TXpJNVpqQTBaV1VnTUhnM04ySmlOemxpT1NBd2VEWmxNRE5tTlRCaElEQjRZalZrWXpZMk16Y2dNSGc1TUdRMFptRTFaQ0F3ZURNelpUa3lZemswSURCNE9EVTBaR1ZrWlRBZ0x5OGdiV1YwYUc5a0lDSmpiM04wS0dKNWRHVmJYU2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbkpsWjJsemRHVnlLSEJoZVN4aWVYUmxXMTBwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0pqYUdWamF5aGhaR1J5WlhOekxIVnBiblEyTkN4aWVYUmxXMTBwWW05dmJDSXNJRzFsZEdodlpDQWlaMlYwVW1WbmFYTjBjbUYwYVc5dVUyaGhjR1VvS0hWcGJuUTRMSFZwYm5RMk5DeDFhVzUwTmpRcEtTaDFhVzUwT0N4MWFXNTBOalFzZFdsdWREWTBLU0lzSUcxbGRHaHZaQ0FpWjJWMFJXNTBjbmtvZFdsdWREWTBLV0o1ZEdWYlhTSXNJRzFsZEdodlpDQWlkWEJrWVhSbFFXdHBkR0ZFUVU4b2RXbHVkRFkwS1hadmFXUWlMQ0J0WlhSb2IyUWdJbTl3VlhBb0tYWnZhV1FpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCamIzTjBJSEpsWjJsemRHVnlJR05vWldOcklHZGxkRkpsWjJsemRISmhkR2x2YmxOb1lYQmxJR2RsZEVWdWRISjVJSFZ3WkdGMFpVRnJhWFJoUkVGUElHMWhhVzVmYjNCVmNGOXliM1YwWlVBeE1Rb2dJQ0FnWlhKeUNncHRZV2x1WDI5d1ZYQmZjbTkxZEdWQU1URTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12WW1GelpTMWpiMjUwY21GamRITXZZbUZ6WlM1MGN6bzBNUW9nSUNBZ0x5OGdiM0JWY0NncE9pQjJiMmxrSUhzZ2ZRb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5amNtVmhkR1ZmVG05UGNFQXhNem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmMzUmhhMmx1Wnkxd2IzZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak0wQ2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1UzUmhhMmx1WjFCdmQyVnlSMkYwWlNCbGVIUmxibVJ6SUVGcmFYUmhRbUZ6WlVOdmJuUnlZV04wSUhzS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZUdOa09XRmtOamRsSUM4dklHMWxkR2h2WkNBaVkzSmxZWFJsS0hOMGNtbHVaeXgxYVc1ME5qUXBkbTlwWkNJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHTnlaV0YwWlFvZ0lDQWdaWEp5Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJaMWJtTjBhVzl1Y3k1MGN6bzZkMmxrWlZKaGRHbHZLRzUxYldWeVlYUnZjbk02SUdKNWRHVnpMQ0JrWlc1dmJXbHVZWFJ2Y25NNklHSjVkR1Z6S1NBdFBpQjFhVzUwTmpRNkNuZHBaR1ZTWVhScGJ6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTltZFc1amRHbHZibk11ZEhNNk1URTNDaUFnSUNBdkx5QmxlSEJ2Y25RZ1puVnVZM1JwYjI0Z2QybGtaVkpoZEdsdktHNTFiV1Z5WVhSdmNuTTZJRnQxYVc1ME5qUXNJSFZwYm5RMk5GMHNJR1JsYm05dGFXNWhkRzl5Y3pvZ1czVnBiblEyTkN3Z2RXbHVkRFkwWFNrNklIVnBiblEyTkNCN0NpQWdJQ0J3Y205MGJ5QXlJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5bWRXNWpkR2x2Ym5NdWRITTZNVEU0Q2lBZ0lDQXZMeUJoYzNObGNuUW9aR1Z1YjIxcGJtRjBiM0p6V3pCZElENGdNQ0FtSmlCa1pXNXZiV2x1WVhSdmNuTmJNVjBnUGlBd0xDQkZVbEpmU1U1V1FVeEpSRjlRUlZKRFJVNVVRVWRGS1FvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHUjFjQW9nSUNBZ1lub2dkMmxrWlZKaGRHbHZYMkp2YjJ4ZlptRnNjMlZBTXdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHSjZJSGRwWkdWU1lYUnBiMTlpYjI5c1gyWmhiSE5sUURNS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2dwM2FXUmxVbUYwYVc5ZlltOXZiRjl0WlhKblpVQTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJaMWJtTjBhVzl1Y3k1MGN6b3hNVGdLSUNBZ0lDOHZJR0Z6YzJWeWRDaGtaVzV2YldsdVlYUnZjbk5iTUYwZ1BpQXdJQ1ltSUdSbGJtOXRhVzVoZEc5eWMxc3hYU0ErSURBc0lFVlNVbDlKVGxaQlRFbEVYMUJGVWtORlRsUkJSMFVwQ2lBZ0lDQmhjM05sY25RZ0x5OGdTVkJEVkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwyWjFibU4wYVc5dWN5NTBjem94TVRrS0lDQWdJQzh2SUdOdmJuTjBJRnR2ZG1WeVpteHZkeXdnY21WemRXeDBYU0E5SUc5d0xtUnBkbTF2Wkhjb0xpNHViM0F1YlhWc2R5Z3VMaTV1ZFcxbGNtRjBiM0p6S1N3Z0xpNHViM0F1YlhWc2R5Z3VMaTVrWlc1dmJXbHVZWFJ2Y25NcEtRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQnRkV3gzQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1puSmhiV1ZmWkdsbklEQUtJQ0FnSUcxMWJIY0tJQ0FnSUdScGRtMXZaSGNLSUNBZ0lIQnZjRzRnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwyWjFibU4wYVc5dWN5NTBjem94TWpBS0lDQWdJQzh2SUdGemMyVnlkQ2h2ZG1WeVpteHZkeUE5UFQwZ01Dd2dSVkpTWDBsT1ZrRk1TVVJmVUVWU1EwVk9WRUZIUlNrS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QkpVRU5VQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlpuVnVZM1JwYjI1ekxuUnpPakV5TVFvZ0lDQWdMeThnY21WMGRYSnVJSEpsYzNWc2RBb2dJQ0FnYzNkaGNBb2dJQ0FnY21WMGMzVmlDZ3AzYVdSbFVtRjBhVzlmWW05dmJGOW1ZV3h6WlVBek9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0lnZDJsa1pWSmhkR2x2WDJKdmIyeGZiV1Z5WjJWQU5Bb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZjM1JoYTJsdVp5MXdiM2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwVGRHRnJhVzVuVUc5M1pYSkhZWFJsTG1OeVpXRjBaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21OeVpXRjBaVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmMzUmhhMmx1Wnkxd2IzZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamMyQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ2IyNURjbVZoZEdVNklDZHlaWEYxYVhKbEp5QjlLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eklDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTlpWVhObExXTnZiblJ5WVdOMGN5OWlZWE5sTG5Sek9qSTFDaUFnSUNBdkx5QjJaWEp6YVc5dUlEMGdSMnh2WW1Gc1UzUmhkR1U4YzNSeWFXNW5QaWg3SUd0bGVUb2dSMnh2WW1Gc1UzUmhkR1ZMWlhsV1pYSnphVzl1SUgwcENpQWdJQ0J3ZFhOb1lubDBaWE1nSW5abGNuTnBiMjRpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwzTjBZV3RwYm1jdGNHOTNaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zT0FvZ0lDQWdMeThnZEdocGN5NTJaWEp6YVc5dUxuWmhiSFZsSUQwZ2RtVnljMmx2YmdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJKaGMyVXRZMjl1ZEhKaFkzUnpMMkpoYzJVdWRITTZNamNLSUNBZ0lDOHZJR0ZyYVhSaFJFRlBJRDBnUjJ4dlltRnNVM1JoZEdVOFFYQndiR2xqWVhScGIyNCtLSHNnYTJWNU9pQkhiRzlpWVd4VGRHRjBaVXRsZVVGcmFYUmhSRUZQSUgwcENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKaGEybDBZVjlrWVc4aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMM04wWVd0cGJtY3RjRzkzWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM09Rb2dJQ0FnTHk4Z2RHaHBjeTVoYTJsMFlVUkJUeTUyWVd4MVpTQTlJRUZ3Y0d4cFkyRjBhVzl1S0dGcmFYUmhSRUZQS1FvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZjM1JoYTJsdVp5MXdiM2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pjMkNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2diMjVEY21WaGRHVTZJQ2R5WlhGMWFYSmxKeUI5S1FvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmMzUmhhMmx1Wnkxd2IzZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBUZEdGcmFXNW5VRzkzWlhKSFlYUmxMbU52YzNSYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGpiM04wT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXpkR0ZyYVc1bkxYQnZkMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T0RRS0lDQWdJQzh2SUdOdmMzUW9ZWEpuY3pvZ1lubDBaWE1wT2lCMWFXNTBOalFnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHpJQzh2SURJS0lDQWdJQ3NLSUNBZ0lITjNZWEFLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3hOVEZtTjJNM05UQXdNREF3TURBd01EQXdNRE13WkRRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmMzUmhhMmx1Wnkxd2IzZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBUZEdGcmFXNW5VRzkzWlhKSFlYUmxMbkpsWjJsemRHVnlXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LY21WbmFYTjBaWEk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwzTjBZV3RwYm1jdGNHOTNaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem80T0FvZ0lDQWdMeThnY21WbmFYTjBaWElvYldKeVVHRjViV1Z1ZERvZ1ozUjRiaTVRWVhsdFpXNTBWSGh1TENCaGNtZHpPaUJpZVhSbGN5azZJSFZwYm5RMk5DQjdDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUMwS0lDQWdJR1IxY0FvZ0lDQWdaM1I0Ym5NZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1TQXZMeUJ3WVhrS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdkSEpoYm5OaFkzUnBiMjRnZEhsd1pTQnBjeUJ3WVhrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0c0Z01nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTXlBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQmtkWEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmMzUmhhMmx1Wnkxd2IzZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamc1Q2lBZ0lDQXZMeUJzYjJkblpXUkJjM05sY25Rb1lYSm5jeTVzWlc1bmRHZ2dQVDA5SUVOb1pXTnJRWEpuYzBKNWRHVnpUR1Z1WjNSb0xDQkZVbEpmU1U1V1FVeEpSRjlCVWtkZlEwOVZUbFFwQ2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ01UY0tJQ0FnSUQwOUNpQWdJQ0JpYm5vZ2NtVm5hWE4wWlhKZllXWjBaWEpmWVhOelpYSjBRRE1LSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJa1ZTVWpwSlFWSkhJZ29nSUNBZ2JHOW5DaUFnSUNCbGNuSWdMeThnUlZKU09rbEJVa2NLQ25KbFoybHpkR1Z5WDJGbWRHVnlYMkZ6YzJWeWRFQXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5emRHRnJhVzVuTFhCdmQyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPVEFLSUNBZ0lDOHZJR3h2WjJkbFpFRnpjMlZ5ZENodFluSlFZWGx0Wlc1MExuSmxZMlZwZG1WeUlEMDlQU0JIYkc5aVlXd3VZM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN5d2dSVkpTWDBsT1ZrRk1TVVJmVUVGWlRVVk9WQ2tLSUNBZ0lHUnBaeUF5Q2lBZ0lDQm5kSGh1Y3lCU1pXTmxhWFpsY2dvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJRDA5Q2lBZ0lDQmlibm9nY21WbmFYTjBaWEpmWVdaMFpYSmZZWE56WlhKMFFEVUtJQ0FnSUdKNWRHVmpJRFVnTHk4Z0lrVlNVanBKVUVGWklnb2dJQ0FnYkc5bkNpQWdJQ0JsY25JZ0x5OGdSVkpTT2tsUVFWa0tDbkpsWjJsemRHVnlYMkZtZEdWeVgyRnpjMlZ5ZEVBMU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl6ZEdGcmFXNW5MWEJ2ZDJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9URUtJQ0FnSUM4dklHeHZaMmRsWkVGemMyVnlkQ2h0WW5KUVlYbHRaVzUwTG1GdGIzVnVkQ0E5UFQwZ1UzUmhhMmx1WjFCdmQyVnlSMkYwWlZKbFoybHpkSEo1VFVKU0xDQkZVbEpmU1U1V1FVeEpSRjlRUVZsTlJVNVVLUW9nSUNBZ1pHbG5JRElLSUNBZ0lHZDBlRzV6SUVGdGIzVnVkQW9nSUNBZ2NIVnphR2x1ZENBeE1qVXdNQW9nSUNBZ1BUMEtJQ0FnSUdKdWVpQnlaV2RwYzNSbGNsOWhablJsY2w5aGMzTmxjblJBTndvZ0lDQWdZbmwwWldNZ05TQXZMeUFpUlZKU09rbFFRVmtpQ2lBZ0lDQnNiMmNLSUNBZ0lHVnljaUF2THlCRlVsSTZTVkJCV1FvS2NtVm5hWE4wWlhKZllXWjBaWEpmWVhOelpYSjBRRGM2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwzTjBZV3RwYm1jdGNHOTNaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem81TkFvZ0lDQWdMeThnYkc5bloyVmtRWE56WlhKMEtIQmhjbUZ0Y3k1dmNDNWhjMVZwYm5RMk5DZ3BJRHc5SURZd0xDQkZVbEpmUWtGRVgwOVFSVkpCVkVsUFRpa0tJQ0FnSUdScFp5QXhDaUFnSUNCcGJuUmpYek1nTHk4Z01nb2dJQ0FnWjJWMFlubDBaUW9nSUNBZ2NIVnphR2x1ZENBMk1Bb2dJQ0FnUEQwS0lDQWdJR0p1ZWlCeVpXZHBjM1JsY2w5aFpuUmxjbDloYzNObGNuUkFPUW9nSUNBZ2NIVnphR0o1ZEdWeklDSkZVbEk2UWs5UVVpSUtJQ0FnSUd4dlp3b2dJQ0FnWlhKeUlDOHZJRVZTVWpwQ1QxQlNDZ3B5WldkcGMzUmxjbDloWm5SbGNsOWhjM05sY25SQU9Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12YzNSaGEybHVaeTF3YjNkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVXhDaUFnSUNBdkx5QmpiMjV6ZENCcFpDQTlJSFJvYVhNdWNtVm5hWE4wY25sRGRYSnpiM0l1ZG1Gc2RXVUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMM04wWVd0cGJtY3RjRzkzWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek9Bb2dJQ0FnTHk4Z2NtVm5hWE4wY25sRGRYSnpiM0lnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tIc2dhVzVwZEdsaGJGWmhiSFZsT2lBeExDQnJaWGs2SUVkaGRHVkhiRzlpWVd4VGRHRjBaVXRsZVZKbFoybHpkSEo1UTNWeWMyOXlJSDBwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0p5WldkcGMzUnllVjlqZFhKemIzSWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDNOMFlXdHBibWN0Y0c5M1pYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFNUW9nSUNBZ0x5OGdZMjl1YzNRZ2FXUWdQU0IwYUdsekxuSmxaMmx6ZEhKNVEzVnljMjl5TG5aaGJIVmxDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl6ZEdGcmFXNW5MWEJ2ZDJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5USUtJQ0FnSUM4dklIUm9hWE11Y21WbmFYTjBjbmxEZFhKemIzSXVkbUZzZFdVZ0t6MGdNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXpkR0ZyYVc1bkxYQnZkMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpnS0lDQWdJQzh2SUhKbFoybHpkSEo1UTNWeWMyOXlJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGloN0lHbHVhWFJwWVd4V1lXeDFaVG9nTVN3Z2EyVjVPaUJIWVhSbFIyeHZZbUZzVTNSaGRHVkxaWGxTWldkcGMzUnllVU4xY25OdmNpQjlLUW9nSUNBZ1lubDBaV05mTWlBdkx5QWljbVZuYVhOMGNubGZZM1Z5YzI5eUlnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl6ZEdGcmFXNW5MWEJ2ZDJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5USUtJQ0FnSUM4dklIUm9hWE11Y21WbmFYTjBjbmxEZFhKemIzSXVkbUZzZFdVZ0t6MGdNUW9nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmMzUmhhMmx1Wnkxd2IzZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamsyQ2lBZ0lDQXZMeUIwYUdsekxuSmxaMmx6ZEhKNUtHbGtLUzUyWVd4MVpTQTlJR05zYjI1bEtIQmhjbUZ0Y3lrS0lDQWdJR2wwYjJJS0lDQWdJR1IxY0FvZ0lDQWdaR2xuSURJS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12YzNSaGEybHVaeTF3YjNkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qZzRDaUFnSUNBdkx5QnlaV2RwYzNSbGNpaHRZbkpRWVhsdFpXNTBPaUJuZEhodUxsQmhlVzFsYm5SVWVHNHNJR0Z5WjNNNklHSjVkR1Z6S1RvZ2RXbHVkRFkwSUhzS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwzTjBZV3RwYm1jdGNHOTNaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VTNSaGEybHVaMUJ2ZDJWeVIyRjBaUzVqYUdWamExdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbU5vWldOck9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1IxY0FvZ0lDQWdZbmwwWldOZk15QXZMeUFpSWdvZ0lDQWdaSFZ3YmlBekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMM04wWVd0cGJtY3RjRzkzWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1EQUtJQ0FnSUM4dklHTm9aV05yS0dOaGJHeGxjam9nUVdOamIzVnVkQ3dnY21WbmFYTjBjbmxKUkRvZ2RXbHVkRFkwTENCaGNtZHpPaUJpZVhSbGN5azZJR0p2YjJ4bFlXNGdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eklDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZjM1JoYTJsdVp5MXdiM2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFd01Rb2dJQ0FnTHk4Z2JHOW5aMlZrUVhOelpYSjBLR0Z5WjNNdWJHVnVaM1JvSUQwOVBTQXdMQ0JGVWxKZlNVNVdRVXhKUkY5QlVrZGZRMDlWVGxRcENpQWdJQ0JzWlc0S0lDQWdJR0o2SUdOb1pXTnJYMkZtZEdWeVgyRnpjMlZ5ZEVBekNpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKRlVsSTZTVUZTUnlJS0lDQWdJR3h2WndvZ0lDQWdaWEp5SUM4dklFVlNVanBKUVZKSENncGphR1ZqYTE5aFpuUmxjbDloYzNObGNuUkFNem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmMzUmhhMmx1Wnkxd2IzZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV3TWdvZ0lDQWdMeThnWTI5dWMzUWdleUJ2Y0N3Z1lYTnpaWFFzSUhCdmQyVnlJSDBnUFNCamJHOXVaU2gwYUdsekxuSmxaMmx6ZEhKNUtISmxaMmx6ZEhKNVNVUXBMblpoYkhWbEtRb2dJQ0FnWkhWd0NpQWdJQ0JwZEc5aUNpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaGMzTmxjblFnTHk4Z1FtOTRJRzExYzNRZ2FHRjJaU0IyWVd4MVpRb2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJREFnTVFvZ0lDQWdZblZ5ZVNBNENpQWdJQ0JrZFhBS0lDQWdJR1Y0ZEhKaFkzUWdNU0E0Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQndkWE5vYVc1MElEa0tJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCaWRYSjVJRGNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmMzUmhhMmx1Wnkxd2IzZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalU0Q2lBZ0lDQXZMeUJuWlhSQmEybDBZVUZ3Y0V4cGMzUW9kR2hwY3k1aGEybDBZVVJCVHk1MllXeDFaU2t1YzNSaGEybHVaeXdLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12WW1GelpTMWpiMjUwY21GamRITXZZbUZ6WlM1MGN6b3lOd29nSUNBZ0x5OGdZV3RwZEdGRVFVOGdQU0JIYkc5aVlXeFRkR0YwWlR4QmNIQnNhV05oZEdsdmJqNG9leUJyWlhrNklFZHNiMkpoYkZOMFlYUmxTMlY1UVd0cGRHRkVRVThnZlNrS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1GcmFYUmhYMlJoYnlJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZjM1JoYTJsdVp5MXdiM2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVNENpQWdJQ0F2THlCblpYUkJhMmwwWVVGd2NFeHBjM1FvZEdocGN5NWhhMmwwWVVSQlR5NTJZV3gxWlNrdWMzUmhhMmx1Wnl3S0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlpuVnVZM1JwYjI1ekxuUnpPalEwQ2lBZ0lDQXZMeUJqYjI1emRDQmJZWEJ3VEdsemRFSjVkR1Z6WFNBOUlHOXdMa0Z3Y0Vkc2IySmhiQzVuWlhSRmVFSjVkR1Z6S0dGcmFYUmhSRUZQTENCQ2VYUmxjeWhCYTJsMFlVUkJUMGRzYjJKaGJGTjBZWFJsUzJWNWMwRnJhWFJoUVhCd1RHbHpkQ2twQ2lBZ0lDQndkWE5vWW5sMFpYTWdJbUZoYkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCd2IzQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12YzNSaGEybHVaeTF3YjNkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVTRDaUFnSUNBdkx5Qm5aWFJCYTJsMFlVRndjRXhwYzNRb2RHaHBjeTVoYTJsMFlVUkJUeTUyWVd4MVpTa3VjM1JoYTJsdVp5d0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMloxYm1OMGFXOXVjeTUwY3pvME5qQXRORFk1Q2lBZ0lDQXZMeUJqYjI1emRDQnBibVp2SUQwZ1lXSnBRMkZzYkR4MGVYQmxiMllnVTNSaGEybHVaeTV3Y205MGIzUjVjR1V1WjJWMFNXNW1iejRvZXdvZ0lDQWdMeThnSUNCaGNIQkpaRG9nYzNSaGEybHVaMEZ3Y0N3S0lDQWdJQzh2SUNBZ1lYSm5jem9nV3dvZ0lDQWdMeThnSUNBZ0lIVnpaWElzQ2lBZ0lDQXZMeUFnSUNBZ2V3b2dJQ0FnTHk4Z0lDQWdJQ0FnWVhOelpYUXNDaUFnSUNBdkx5QWdJQ0FnSUNCMGVYQmxPaUJUVkVGTFNVNUhYMVJaVUVWZlRFOURTeXdLSUNBZ0lDOHZJQ0FnSUNCOUxBb2dJQ0FnTHk4Z0lDQmRMQW9nSUNBZ0x5OGdmU2t1Y21WMGRYSnVWbUZzZFdVS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5bWRXNWpkR2x2Ym5NdWRITTZORFkwTFRRMk53b2dJQ0FnTHk4Z2V3b2dJQ0FnTHk4Z0lDQmhjM05sZEN3S0lDQWdJQzh2SUNBZ2RIbHdaVG9nVTFSQlMwbE9SMTlVV1ZCRlgweFBRMHNzQ2lBZ0lDQXZMeUI5TEFvZ0lDQWdjM2RoY0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwyWjFibU4wYVc5dWN5NTBjem8wTmpZS0lDQWdJQzh2SUhSNWNHVTZJRk5VUVV0SlRrZGZWRmxRUlY5TVQwTkxMQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNamdLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5bWRXNWpkR2x2Ym5NdWRITTZORFkwTFRRMk53b2dJQ0FnTHk4Z2V3b2dJQ0FnTHk4Z0lDQmhjM05sZEN3S0lDQWdJQzh2SUNBZ2RIbHdaVG9nVTFSQlMwbE9SMTlVV1ZCRlgweFBRMHNzQ2lBZ0lDQXZMeUI5TEFvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTltZFc1amRHbHZibk11ZEhNNk5EWXdMVFEyT1FvZ0lDQWdMeThnWTI5dWMzUWdhVzVtYnlBOUlHRmlhVU5oYkd3OGRIbHdaVzltSUZOMFlXdHBibWN1Y0hKdmRHOTBlWEJsTG1kbGRFbHVabTgrS0hzS0lDQWdJQzh2SUNBZ1lYQndTV1E2SUhOMFlXdHBibWRCY0hBc0NpQWdJQ0F2THlBZ0lHRnlaM002SUZzS0lDQWdJQzh2SUNBZ0lDQjFjMlZ5TEFvZ0lDQWdMeThnSUNBZ0lIc0tJQ0FnSUM4dklDQWdJQ0FnSUdGemMyVjBMQW9nSUNBZ0x5OGdJQ0FnSUNBZ2RIbHdaVG9nVTFSQlMwbE9SMTlVV1ZCRlgweFBRMHNzQ2lBZ0lDQXZMeUFnSUNBZ2ZTd0tJQ0FnSUM4dklDQWdYU3dLSUNBZ0lDOHZJSDBwTG5KbGRIVnlibFpoYkhWbENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhoak9UQTJPRGd3T1NBdkx5QnRaWFJvYjJRZ0ltZGxkRWx1Wm04b1lXUmtjbVZ6Y3l3b2RXbHVkRFkwTEhWcGJuUTRLU2tvZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRcElnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHUnBaeUF5Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lIQjFjMmhwYm5RZ05pQXZMeUJoY0hCc0NpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCcGRIaHVJRXhoYzNSTWIyY0tJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQTVDaUFnSUNCa2RYQUtJQ0FnSUdWNGRISmhZM1FnTkNBd0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnWlhoMGNtRmpkQ0F3SURRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkNlWFJsY3lCb1lYTWdkbUZzYVdRZ2NISmxabWw0Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ01qUUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEdGcmFXNW5MM1I1Y0dWekxuUnpPanBUZEdGclpRb2dJQ0FnY0hWemFHbHVkQ0F5TUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwyWjFibU4wYVc5dWN5NTBjem8wTnpFS0lDQWdJQzh2SUdsbUlDaHBibVp2TG1WNGNHbHlZWFJwYjI0Z1BEMGdSMnh2WW1Gc0xteGhkR1Z6ZEZScGJXVnpkR0Z0Y0NrZ2V3b2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQTFDaUFnSUNCbmJHOWlZV3dnVEdGMFpYTjBWR2x0WlhOMFlXMXdDaUFnSUNBOFBRb2dJQ0FnWW5vZ1kyaGxZMnRmWVdaMFpYSmZhV1pmWld4elpVQTJDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Wm5WdVkzUnBiMjV6TG5Sek9qUTNNZ29nSUNBZ0x5OGdjbVYwZFhKdUlEQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZFhKNUlETUtDbU5vWldOclgyRm1kR1Z5WDJsdWJHbHVaV1JmYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwyWjFibU4wYVc5dWN5NTBjem82WjJWMFUzUmhhMmx1WjFCdmQyVnlRRGs2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwzTjBZV3RwYm1jdGNHOTNaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTkFvZ0lDQWdMeThnWTJGelpTQkZjWFZoYkRvZ2NtVjBkWEp1SUhWelpYSlFiM2RsY2lBOVBUMGdjRzkzWlhJS0lDQWdJR1JwWnlBMkNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd1lRb2dJQ0FnUFQwS0lDQWdJR0o2SUdOb1pXTnJYMkZtZEdWeVgybG1YMlZzYzJWQU1URUtJQ0FnSUdScFp5QXlDaUFnSUNCa2FXY2dOZ29nSUNBZ1BUMEtDbU5vWldOclgyRm1kR1Z5WDJsdWJHbHVaV1JmYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXpkR0ZyYVc1bkxYQnZkMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2xOMFlXdHBibWRRYjNkbGNrZGhkR1V1YzNSaGEybHVaMUJ2ZDJWeVIyRjBaVUF5TWpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZjM1JoYTJsdVp5MXdiM2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFd01Bb2dJQ0FnTHk4Z1kyaGxZMnNvWTJGc2JHVnlPaUJCWTJOdmRXNTBMQ0J5WldkcGMzUnllVWxFT2lCMWFXNTBOalFzSUdGeVozTTZJR0o1ZEdWektUb2dZbTl2YkdWaGJpQjdDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlYwWW1sMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncGphR1ZqYTE5aFpuUmxjbDlwWmw5bGJITmxRREV4T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXpkR0ZyYVc1bkxYQnZkMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpVS0lDQWdJQzh2SUdOaGMyVWdUbTkwUlhGMVlXdzZJSEpsZEhWeWJpQjFjMlZ5VUc5M1pYSWdJVDA5SUhCdmQyVnlDaUFnSUNCa2FXY2dOZ29nSUNBZ2NIVnphR0o1ZEdWeklEQjRNVFFLSUNBZ0lEMDlDaUFnSUNCaWVpQmphR1ZqYTE5aFpuUmxjbDlwWmw5bGJITmxRREV6Q2lBZ0lDQmthV2NnTWdvZ0lDQWdaR2xuSURZS0lDQWdJQ0U5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwzTjBZV3RwYm1jdGNHOTNaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TURNS0lDQWdJQzh2SUhKbGRIVnliaUIwYUdsekxuTjBZV3RwYm1kUWIzZGxja2RoZEdVb1kyRnNiR1Z5TENCdmNDd2dZWE56WlhRc0lIQnZkMlZ5S1FvZ0lDQWdZaUJqYUdWamExOWhablJsY2w5cGJteHBibVZrWDNOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZjM1JoYTJsdVp5MXdiM2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwVGRHRnJhVzVuVUc5M1pYSkhZWFJsTG5OMFlXdHBibWRRYjNkbGNrZGhkR1ZBTWpJS0NtTm9aV05yWDJGbWRHVnlYMmxtWDJWc2MyVkFNVE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwzTjBZV3RwYm1jdGNHOTNaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTmdvZ0lDQWdMeThnWTJGelpTQk1aWE56VkdoaGJqb2djbVYwZFhKdUlIVnpaWEpRYjNkbGNpQThJSEJ2ZDJWeUNpQWdJQ0JrYVdjZ05nb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1XVUtJQ0FnSUQwOUNpQWdJQ0JpZWlCamFHVmphMTloWm5SbGNsOXBabDlsYkhObFFERTFDaUFnSUNCa2FXY2dNZ29nSUNBZ1pHbG5JRFlLSUNBZ0lEd0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12YzNSaGEybHVaeTF3YjNkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXdNd29nSUNBZ0x5OGdjbVYwZFhKdUlIUm9hWE11YzNSaGEybHVaMUJ2ZDJWeVIyRjBaU2hqWVd4c1pYSXNJRzl3TENCaGMzTmxkQ3dnY0c5M1pYSXBDaUFnSUNCaUlHTm9aV05yWDJGbWRHVnlYMmx1YkdsdVpXUmZjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5emRHRnJhVzVuTFhCdmQyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPbE4wWVd0cGJtZFFiM2RsY2tkaGRHVXVjM1JoYTJsdVoxQnZkMlZ5UjJGMFpVQXlNZ29LWTJobFkydGZZV1owWlhKZmFXWmZaV3h6WlVBeE5Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12YzNSaGEybHVaeTF3YjNkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWTNDaUFnSUNBdkx5QmpZWE5sSUV4bGMzTlVhR0Z1VDNKRmNYVmhiRlJ2T2lCeVpYUjFjbTRnZFhObGNsQnZkMlZ5SUR3OUlIQnZkMlZ5Q2lBZ0lDQmthV2NnTmdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TWpnS0lDQWdJRDA5Q2lBZ0lDQmllaUJqYUdWamExOWhablJsY2w5cFpsOWxiSE5sUURFM0NpQWdJQ0JrYVdjZ01nb2dJQ0FnWkdsbklEWUtJQ0FnSUR3OUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMM04wWVd0cGJtY3RjRzkzWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1ETUtJQ0FnSUM4dklISmxkSFZ5YmlCMGFHbHpMbk4wWVd0cGJtZFFiM2RsY2tkaGRHVW9ZMkZzYkdWeUxDQnZjQ3dnWVhOelpYUXNJSEJ2ZDJWeUtRb2dJQ0FnWWlCamFHVmphMTloWm5SbGNsOXBibXhwYm1Wa1gzTnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12YzNSaGEybHVaeTF3YjNkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcFRkR0ZyYVc1blVHOTNaWEpIWVhSbExuTjBZV3RwYm1kUWIzZGxja2RoZEdWQU1qSUtDbU5vWldOclgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRjNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMM04wWVd0cGJtY3RjRzkzWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk9Bb2dJQ0FnTHk4Z1kyRnpaU0JIY21WaGRHVnlWR2hoYmpvZ2NtVjBkWEp1SUhWelpYSlFiM2RsY2lBK0lIQnZkMlZ5Q2lBZ0lDQmthV2NnTmdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TXpJS0lDQWdJRDA5Q2lBZ0lDQmllaUJqYUdWamExOWhablJsY2w5cFpsOWxiSE5sUURFNUNpQWdJQ0JrYVdjZ01nb2dJQ0FnWkdsbklEWUtJQ0FnSUQ0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZjM1JoYTJsdVp5MXdiM2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFd013b2dJQ0FnTHk4Z2NtVjBkWEp1SUhSb2FYTXVjM1JoYTJsdVoxQnZkMlZ5UjJGMFpTaGpZV3hzWlhJc0lHOXdMQ0JoYzNObGRDd2djRzkzWlhJcENpQWdJQ0JpSUdOb1pXTnJYMkZtZEdWeVgybHViR2x1WldSZmMyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl6ZEdGcmFXNW5MWEJ2ZDJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9sTjBZV3RwYm1kUWIzZGxja2RoZEdVdWMzUmhhMmx1WjFCdmQyVnlSMkYwWlVBeU1nb0tZMmhsWTJ0ZllXWjBaWEpmYVdaZlpXeHpaVUF4T1RvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZjM1JoYTJsdVp5MXdiM2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZNUNpQWdJQ0F2THlCallYTmxJRWR5WldGMFpYSlVhR0Z1VDNKRmNYVmhiRlJ2T2lCeVpYUjFjbTRnZFhObGNsQnZkMlZ5SUQ0OUlIQnZkMlZ5Q2lBZ0lDQmthV2NnTmdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TTJNS0lDQWdJRDA5Q2lBZ0lDQmllaUJqYUdWamExOWhablJsY2w5cFpsOWxiSE5sUURJeENpQWdJQ0JrYVdjZ01nb2dJQ0FnWkdsbklEWUtJQ0FnSUQ0OUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMM04wWVd0cGJtY3RjRzkzWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1ETUtJQ0FnSUM4dklISmxkSFZ5YmlCMGFHbHpMbk4wWVd0cGJtZFFiM2RsY2tkaGRHVW9ZMkZzYkdWeUxDQnZjQ3dnWVhOelpYUXNJSEJ2ZDJWeUtRb2dJQ0FnWWlCamFHVmphMTloWm5SbGNsOXBibXhwYm1Wa1gzTnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12YzNSaGEybHVaeTF3YjNkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcFRkR0ZyYVc1blVHOTNaWEpIWVhSbExuTjBZV3RwYm1kUWIzZGxja2RoZEdWQU1qSUtDbU5vWldOclgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpFNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMM04wWVd0cGJtY3RjRzkzWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM01Bb2dJQ0FnTHk4Z1pHVm1ZWFZzZERvZ2NtVjBkWEp1SUdaaGJITmxDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl6ZEdGcmFXNW5MWEJ2ZDJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UQXpDaUFnSUNBdkx5QnlaWFIxY200Z2RHaHBjeTV6ZEdGcmFXNW5VRzkzWlhKSFlYUmxLR05oYkd4bGNpd2diM0FzSUdGemMyVjBMQ0J3YjNkbGNpa0tJQ0FnSUdJZ1kyaGxZMnRmWVdaMFpYSmZhVzVzYVc1bFpGOXpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDNOMFlXdHBibWN0Y0c5M1pYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZVM1JoYTJsdVoxQnZkMlZ5UjJGMFpTNXpkR0ZyYVc1blVHOTNaWEpIWVhSbFFESXlDZ3BqYUdWamExOWhablJsY2w5cFpsOWxiSE5sUURZNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZablZ1WTNScGIyNXpMblJ6T2pRM05Rb2dJQ0FnTHk4Z1kyOXVjM1FnY21WdFlXbHVhVzVuVkdsdFpUb2dkV2x1ZERZMElEMGdhVzVtYnk1bGVIQnBjbUYwYVc5dUlDMGdSMnh2WW1Gc0xteGhkR1Z6ZEZScGJXVnpkR0Z0Y0FvZ0lDQWdaR2xuSURNS0lDQWdJR2RzYjJKaGJDQk1ZWFJsYzNSVWFXMWxjM1JoYlhBS0lDQWdJQzBLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0EyQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlpuVnVZM1JwYjI1ekxuUnpPalEzTndvZ0lDQWdMeThnYVdZZ0tISmxiV0ZwYm1sdVoxUnBiV1VnUENCUFRrVmZWMFZGU3lrZ2V3b2dJQ0FnY0hWemFHbHVkQ0EyTURRNE1EQUtJQ0FnSUR3S0lDQWdJR0o2SUdOb1pXTnJYMkZtZEdWeVgybG1YMlZzYzJWQU9Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMloxYm1OMGFXOXVjeTUwY3pvME56Z0tJQ0FnSUM4dklISmxkSFZ5YmlBd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZblZ5ZVNBekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMM04wWVd0cGJtY3RjRzkzWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU55MDJNUW9nSUNBZ0x5OGdZMjl1YzNRZ2RYTmxjbEJ2ZDJWeUlEMGdaMlYwVTNSaGEybHVaMUJ2ZDJWeUtBb2dJQ0FnTHk4Z0lDQm5aWFJCYTJsMFlVRndjRXhwYzNRb2RHaHBjeTVoYTJsMFlVUkJUeTUyWVd4MVpTa3VjM1JoYTJsdVp5d0tJQ0FnSUM4dklDQWdkWE5sY2l3S0lDQWdJQzh2SUNBZ1lYTnpaWFFLSUNBZ0lDOHZJQ2tLSUNBZ0lHSWdZMmhsWTJ0ZllXWjBaWEpmYVc1c2FXNWxaRjl6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlpuVnVZM1JwYjI1ekxuUnpPanBuWlhSVGRHRnJhVzVuVUc5M1pYSkFPUW9LWTJobFkydGZZV1owWlhKZmFXWmZaV3h6WlVBNE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMloxYm1OMGFXOXVjeTUwY3pvME9ERUtJQ0FnSUM4dklHTnZibk4wSUhKbGJXRnBibWx1WjBSaGVYTTZJSFZwYm5RMk5DQTlJSEpsYldGcGJtbHVaMVJwYldVZ0x5QlBUa1ZmUkVGWkNpQWdJQ0JrYVdjZ05Bb2dJQ0FnY0hWemFHbHVkQ0E0TmpRd01Bb2dJQ0FnTHdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwyWjFibU4wYVc5dWN5NTBjem8wT0RJS0lDQWdJQzh2SUhKbGRIVnliaUJ2Y0M1a2FYWjNLQzR1TG05d0xtMTFiSGNvZDJsa1pWSmhkR2x2S0Z0cGJtWnZMbUZ0YjNWdWRDd2dNVjh3TURCZk1EQXdYU3dnVzA5T1JWOVpSVUZTWDBsT1gwUkJXVk1zSURGZk1EQXdYekF3TUYwcExDQnlaVzFoYVc1cGJtZEVZWGx6S1N3Z01WOHdNREJmTURBd0tRb2dJQ0FnWkdsbklEZ0tJQ0FnSUdWNGRISmhZM1FnTkNBNENpQWdJQ0JwYm5SaklEUWdMeThnTVRBd01EQXdNQW9nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01UWmtNREF3TURBd01EQXdNREJtTkRJME1Bb2dJQ0FnWTJGc2JITjFZaUIzYVdSbFVtRjBhVzhLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnRkV3gzQ2lBZ0lDQndiM0FLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR0o1ZEdWaklEWWdMeThnTUhnd01EQXdNREF3TURBd01EQXdNVFprTURBd01EQXdNREF3TURCbU5ESTBNQW9nSUNBZ1kyRnNiSE4xWWlCM2FXUmxVbUYwYVc4S0lDQWdJRzExYkhjS0lDQWdJR0oxY25rZ01Rb2dJQ0FnYVc1MFl5QTBJQzh2SURFd01EQXdNREFLSUNBZ0lHUnBkbmNLSUNBZ0lHSjFjbmtnTXdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXpkR0ZyYVc1bkxYQnZkMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRjdE5qRUtJQ0FnSUM4dklHTnZibk4wSUhWelpYSlFiM2RsY2lBOUlHZGxkRk4wWVd0cGJtZFFiM2RsY2lnS0lDQWdJQzh2SUNBZ1oyVjBRV3RwZEdGQmNIQk1hWE4wS0hSb2FYTXVZV3RwZEdGRVFVOHVkbUZzZFdVcExuTjBZV3RwYm1jc0NpQWdJQ0F2THlBZ0lIVnpaWElzQ2lBZ0lDQXZMeUFnSUdGemMyVjBDaUFnSUNBdkx5QXBDaUFnSUNCaUlHTm9aV05yWDJGbWRHVnlYMmx1YkdsdVpXUmZjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJaMWJtTjBhVzl1Y3k1MGN6bzZaMlYwVTNSaGEybHVaMUJ2ZDJWeVFEa0tDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMM04wWVd0cGJtY3RjRzkzWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlUzUmhhMmx1WjFCdmQyVnlSMkYwWlM1blpYUlNaV2RwYzNSeVlYUnBiMjVUYUdGd1pWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWRsZEZKbFoybHpkSEpoZEdsdmJsTm9ZWEJsT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXpkR0ZyYVc1bkxYQnZkMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRBMkNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2djbVZoWkc5dWJIazZJSFJ5ZFdVZ2ZTa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJREUzQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDNOMFlXdHBibWN0Y0c5M1pYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZVM1JoYTJsdVoxQnZkMlZ5UjJGMFpWSmxaMmx6ZEhKNVNXNW1id29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12YzNSaGEybHVaeTF3YjNkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcFRkR0ZyYVc1blVHOTNaWEpIWVhSbExtZGxkRVZ1ZEhKNVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taMlYwUlc1MGNuazZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDNOMFlXdHBibWN0Y0c5M1pYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNVEVLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU0I5S1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl6ZEdGcmFXNW5MWEJ2ZDJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1URXpDaUFnSUNBdkx5QnlaWFIxY200Z1pXNWpiMlJsUVhKak5DaDBhR2x6TG5KbFoybHpkSEo1S0hKbFoybHpkSEo1U1VRcExuWmhiSFZsS1FvZ0lDQWdhWFJ2WWdvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUVKdmVDQnRkWE4wSUdoaGRtVWdkbUZzZFdVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZjM1JoYTJsdVp5MXdiM2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeE1Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJSEpsWVdSdmJteDVPaUIwY25WbElIMHBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OWlZWE5sTFdOdmJuUnlZV04wY3k5aVlYTmxMblJ6T2pwQmEybDBZVUpoYzJWRGIyNTBjbUZqZEM1MWNHUmhkR1ZCYTJsMFlVUkJUMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25Wd1pHRjBaVUZyYVhSaFJFRlBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJKaGMyVXRZMjl1ZEhKaFkzUnpMMkpoYzJVdWRITTZNellLSUNBZ0lDOHZJSFZ3WkdGMFpVRnJhWFJoUkVGUEtHRnJhWFJoUkVGUE9pQkJjSEJzYVdOaGRHbHZiaWs2SUhadmFXUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwySmhjMlV0WTI5dWRISmhZM1J6TDJKaGMyVXVkSE02TXpjS0lDQWdJQzh2SUd4dloyZGxaRUZ6YzJWeWRDaFVlRzR1YzJWdVpHVnlJRDA5UFNCMGFHbHpMbWRsZEVGcmFYUmhSRUZQVjJGc2JHVjBLQ2t1WVdSa2NtVnpjeXdnUlZKU1gwNVBWRjlCUzBsVVFWOUVRVThwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12WW1GelpTMWpiMjUwY21GamRITXZZbUZ6WlM1MGN6b3pNQW9nSUNBZ0x5OGdZMjl1YzNRZ1czZGhiR3hsZEVsRVhTQTlJRzl3TGtGd2NFZHNiMkpoYkM1blpYUkZlRlZwYm5RMk5DaDBhR2x6TG1GcmFYUmhSRUZQTG5aaGJIVmxMQ0JDZVhSbGN5aEJhMmwwWVVSQlQwZHNiMkpoYkZOMFlYUmxTMlY1YzFkaGJHeGxkQ2twQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJKaGMyVXRZMjl1ZEhKaFkzUnpMMkpoYzJVdWRITTZNamNLSUNBZ0lDOHZJR0ZyYVhSaFJFRlBJRDBnUjJ4dlltRnNVM1JoZEdVOFFYQndiR2xqWVhScGIyNCtLSHNnYTJWNU9pQkhiRzlpWVd4VGRHRjBaVXRsZVVGcmFYUmhSRUZQSUgwcENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKaGEybDBZVjlrWVc4aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZZbUZ6WlMxamIyNTBjbUZqZEhNdlltRnpaUzUwY3pvek1Bb2dJQ0FnTHk4Z1kyOXVjM1FnVzNkaGJHeGxkRWxFWFNBOUlHOXdMa0Z3Y0Vkc2IySmhiQzVuWlhSRmVGVnBiblEyTkNoMGFHbHpMbUZyYVhSaFJFRlBMblpoYkhWbExDQkNlWFJsY3loQmEybDBZVVJCVDBkc2IySmhiRk4wWVhSbFMyVjVjMWRoYkd4bGRDa3BDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnY0hWemFHSjVkR1Z6SUNKM1lXeHNaWFFpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnY0c5d0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZZbUZ6WlMxamIyNTBjbUZqZEhNdlltRnpaUzUwY3pvek53b2dJQ0FnTHk4Z2JHOW5aMlZrUVhOelpYSjBLRlI0Ymk1elpXNWtaWElnUFQwOUlIUm9hWE11WjJWMFFXdHBkR0ZFUVU5WFlXeHNaWFFvS1M1aFpHUnlaWE56TENCRlVsSmZUazlVWDBGTFNWUkJYMFJCVHlrS0lDQWdJR0Z3Y0Y5d1lYSmhiWE5mWjJWMElFRndjRUZrWkhKbGMzTUtJQ0FnSUdGemMyVnlkQ0F2THlCaGNIQnNhV05oZEdsdmJpQmxlR2x6ZEhNS0lDQWdJRDA5Q2lBZ0lDQmlibm9nZFhCa1lYUmxRV3RwZEdGRVFVOWZZV1owWlhKZllYTnpaWEowUURNS0lDQWdJSEIxYzJoaWVYUmxjeUFpUlZKU09rNUVRVThpQ2lBZ0lDQnNiMmNLSUNBZ0lHVnljaUF2THlCRlVsSTZUa1JCVHdvS2RYQmtZWFJsUVd0cGRHRkVRVTlmWVdaMFpYSmZZWE56WlhKMFFETTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12WW1GelpTMWpiMjUwY21GamRITXZZbUZ6WlM1MGN6b3lOd29nSUNBZ0x5OGdZV3RwZEdGRVFVOGdQU0JIYkc5aVlXeFRkR0YwWlR4QmNIQnNhV05oZEdsdmJqNG9leUJyWlhrNklFZHNiMkpoYkZOMFlYUmxTMlY1UVd0cGRHRkVRVThnZlNrS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1GcmFYUmhYMlJoYnlJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OWlZWE5sTFdOdmJuUnlZV04wY3k5aVlYTmxMblJ6T2pNNENpQWdJQ0F2THlCMGFHbHpMbUZyYVhSaFJFRlBMblpoYkhWbElEMGdZV3RwZEdGRVFVOEtJQ0FnSUdScFp5QXhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJKaGMyVXRZMjl1ZEhKaFkzUnpMMkpoYzJVdWRITTZNellLSUNBZ0lDOHZJSFZ3WkdGMFpVRnJhWFJoUkVGUEtHRnJhWFJoUkVGUE9pQkJjSEJzYVdOaGRHbHZiaWs2SUhadmFXUWdld29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERUtJQ0FnSUhKbGRIVnliZ289In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRkFBRUlBc0NFUFNZSEJCVWZmSFVKWVd0cGRHRmZaR0Z2RDNKbFoybHpkSEo1WDJOMWNuTnZjZ0FJUlZKU09rbEJVa2NJUlZKU09rbFFRVmtRQUFBQUFBQUFBVzBBQUFBQUFBOUNRREVZUUFBK0tpTm5nZ0lTY21WbmFYTjBjbUYwYVc5dVgzTm9ZWEJsRlNoMWFXNTBPQ3gxYVc1ME5qUXNkV2x1ZERZMEtXZUFDMk5vWldOclgzTm9ZWEJsSzJjeEdSUkVNUmhCQUR1Q0J3UXlud1R1QkhlN2Via0ViZ1AxQ2dTMTNHWTNCSkRVK2wwRU0ra3NsQVNGVGUzZ05ob0FqZ2NBYXdDSUFQY0NRUUpRQW1vQUFRQWpRNEFFelpyV2ZqWWFBSTRCQURFQWlnSUJpLzhpVzBsQkFDR0wveVJiUVFBYUkwU0wvaUpiaS80a1d4MkwveVJiaXdBZEgwWUNUQlJFVElraVF2L2pOaG9CU1NKWkpRaExBUlVTUkZjQ0FEWWFBa2tWSkJKRUY0QUhkbVZ5YzJsdmJrOENaeWxNWnlORE5ob0JTU0paSlFoTUZSSkVnQXdWSDN4MUFBQUFBQUFBTU5Td0kwTXhGaU1KU1RnUUl4SkVOaG9CUndJaVdTVUlTd0VWRWtSWEFnQkpGWUVSRWtBQUJDY0VzQUJMQWpnSE1nb1NRQUFFSndXd0FFc0NPQWlCMUdFU1FBQUVKd1d3QUVzQkpWV0JQQTVBQUF5QUNFVlNVanBDVDFCU3NBQWlLbVZFU1NNSUtreG5Ga2xMQXI4b1RGQ3dJME1pU1N0SEF6WWFBVWtWZ1NBU1JEWWFBa2tWSkJKRUZ6WWFBMGtpV1NVSVN3RVZFa1JYQWdBVlFRQUVKd1N3QUVrV3ZrUkpWd0FCUlFoSlZ3RUlUSUVKVzBVSElpbGxSSUFEWVdGc1pVZ2lXN0ZNZ0FFb1VFeXlHSUFFeVFhSUNiSWFTd0t5R3JJYWdRYXlFQ0t5QWJPMFBrbEZDVWxYQkFCTEFWY0FCQ2dTUkJXQkdCSkVnUlJiU1VVRk1nY09RUUIzSWtVRFN3YUFBUW9TUVFBU1N3SkxCaEtBQVFBaVR3SlVLRXhRc0NORFN3YUFBUlFTUVFBSVN3SkxCaE5DLytKTEJvQUJIaEpCQUFoTEFrc0dERUwvMFVzR2dBRW9Fa0VBQ0VzQ1N3WU9Rdi9BU3dhQUFUSVNRUUFJU3dKTEJnMUMvNjlMQm9BQlBCSkJBQWhMQWtzR0QwTC9uaUpDLzVwTEF6SUhDVWxGQm9HQTlTUU1RUUFHSWtVRFF2OTJTd1NCZ0tNRkNrc0lWd1FJSVFRV1VFa25Cb2o5NWtzQ0hVaE9BaWNHaVAzYkhVVUJJUVNYUlFOQy8wbzJHZ0ZKRllFUkVrUW9URkN3STBNMkdnRkpGU1FTUkJjV3ZrUkpGUlpYQmdKTVVDaE1VTEFqUXpZYUFVa1ZKQkpFRnpFQUlpbGxSSUFHZDJGc2JHVjBaVWh5Q0VRU1FBQU1nQWhGVWxJNlRrUkJUN0FBS1VzQlp5TkQiLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo5LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
