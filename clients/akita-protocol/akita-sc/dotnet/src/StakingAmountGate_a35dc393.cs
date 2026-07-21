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

namespace Arc56.Generated.akita_protocol.akita_sc.StakingAmountGate_a35dc393
{


    public class StakingAmountGateProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public StakingAmountGateProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class StakingAmountGateRegistryInfo : AVMObjectType
            {
                public byte Op { get; set; }

                public ulong Asset { get; set; }

                public byte Type { get; set; }

                public ulong Amount { get; set; }

                public bool IncludeEscrowed { get; set; }

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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vType = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vType.From(Type);
                    ret.AddRange(vType.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAmount.From(Amount);
                    ret.AddRange(vAmount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIncludeEscrowed = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vIncludeEscrowed.From(IncludeEscrowed);
                    ret.AddRange(vIncludeEscrowed.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static StakingAmountGateRegistryInfo Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new StakingAmountGateRegistryInfo();
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vType = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vType.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueType = vType.ToValue();
                    if (valueType is byte vTypeValue) { ret.Type = vTypeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAmount = vAmount.ToValue();
                    if (valueAmount is ulong vAmountValue) { ret.Amount = vAmountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIncludeEscrowed = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vIncludeEscrowed.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueIncludeEscrowed = vIncludeEscrowed.ToValue();
                    if (valueIncludeEscrowed is bool vIncludeEscrowedValue) { ret.IncludeEscrowed = vIncludeEscrowedValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as StakingAmountGateRegistryInfo);
                }
                public bool Equals(StakingAmountGateRegistryInfo? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(StakingAmountGateRegistryInfo left, StakingAmountGateRegistryInfo right)
                {
                    return EqualityComparer<StakingAmountGateRegistryInfo>.Default.Equals(left, right);
                }
                public static bool operator !=(StakingAmountGateRegistryInfo left, StakingAmountGateRegistryInfo right)
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
        /// <param name="shape"> StakingAmountGateRegistryInfo</param>
        public async Task<Structs.StakingAmountGateRegistryInfo> GetRegistrationShape(Structs.StakingAmountGateRegistryInfo shape, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 53, 36, 153, 20 };

            var result = await base.SimApp(new List<object> { abiHandle, shape }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.StakingAmountGateRegistryInfo.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetRegistrationShape_Transactions(Structs.StakingAmountGateRegistryInfo shape, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 53, 36, 153, 20 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU3Rha2luZ0Ftb3VudEdhdGUiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiU3Rha2luZ0Ftb3VudEdhdGVSZWdpc3RyeUluZm8iOlt7Im5hbWUiOiJvcCIsInR5cGUiOiJ1aW50OCJ9LHsibmFtZSI6ImFzc2V0IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InR5cGUiLCJ0eXBlIjoidWludDgifSx7Im5hbWUiOiJhbW91bnQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiaW5jbHVkZUVzY3Jvd2VkIiwidHlwZSI6ImJvb2wifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZlcnNpb24iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFraXRhREFPIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNvc3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXJncyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlZ2lzdGVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1iclBheW1lbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFyZ3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjaGVjayIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FsbGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWdpc3RyeUlEIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcmdzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFJlZ2lzdHJhdGlvblNoYXBlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6Iih1aW50OCx1aW50NjQsdWludDgsdWludDY0LGJvb2wpIiwic3RydWN0IjoiU3Rha2luZ0Ftb3VudEdhdGVSZWdpc3RyeUluZm8iLCJuYW1lIjoic2hhcGUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ4LHVpbnQ2NCx1aW50OCx1aW50NjQsYm9vbCkiLCJzdHJ1Y3QiOiJTdGFraW5nQW1vdW50R2F0ZVJlZ2lzdHJ5SW5mbyIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0RW50cnkiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVnaXN0cnlJRCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidXBkYXRlQWtpdGFEQU8iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWtpdGFEQU8iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoib3BVcCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MiwiYnl0ZXMiOjN9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzQ1Miw3NjVdLCJlcnJvck1lc3NhZ2UiOiJCb3ggbXVzdCBoYXZlIHZhbHVlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTU2LDcyNV0sImVycm9yTWVzc2FnZSI6IkJ5dGVzIGhhcyB2YWxpZCBwcmVmaXgiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNzldLCJlcnJvck1lc3NhZ2UiOiJFUlI6Qk9QUiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMyOCw0NDhdLCJlcnJvck1lc3NhZ2UiOiJFUlI6SUFSRyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM0MiwzNTddLCJlcnJvck1lc3NhZ2UiOiJFUlI6SVBBWSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzgyM10sImVycm9yTWVzc2FnZSI6IkVSUjpOREFPIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODA3XSwiZXJyb3JNZXNzYWdlIjoiYXBwbGljYXRpb24gZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzgzLDQ4OSw3OTRdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBHbG9iYWxTdGF0ZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMjQsMjY2LDMwNiw0MzBdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMzEsMjcyLDMxMyw0MzddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDE1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI0Miw0MjMsNzYxLDc4N10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc0N10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBzbWFydF9jb250cmFjdHMvZ2F0ZXMvc3ViLWdhdGVzL3N0YWtpbmctYW1vdW50L2NvbnRyYWN0LmFsZ28udHM6OlN0YWtpbmdBbW91bnRHYXRlUmVnaXN0cnlJbmZvIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzMwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIHNtYXJ0X2NvbnRyYWN0cy9zdGFraW5nL3R5cGVzLnRzOjpTdGFrZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU2MV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciB1aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyOTldLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIHBheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTUNBeElESWdPQW9nSUNBZ1lubDBaV05pYkc5amF5QXdlREUxTVdZM1l6YzFJQ0poYTJsMFlWOWtZVzhpSUNKeVpXZHBjM1J5ZVY5amRYSnpiM0lpSUNJaUlDSkZVbEk2U1VGU1J5SWdJa1ZTVWpwSlVFRlpJZ29nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0p1ZWlCdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl6ZEdGcmFXNW5MV0Z0YjNWdWRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTRDaUFnSUNBdkx5QnlaV2RwYzNSeWVVTjFjbk52Y2lBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9leUJwYm1sMGFXRnNWbUZzZFdVNklERXNJR3RsZVRvZ1IyRjBaVWRzYjJKaGJGTjBZWFJsUzJWNVVtVm5hWE4wY25sRGRYSnpiM0lnZlNrS0lDQWdJR0o1ZEdWalh6SWdMeThnSW5KbFoybHpkSEo1WDJOMWNuTnZjaUlLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5emRHRnJhVzVuTFdGdGIzVnVkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalF3Q2lBZ0lDQXZMeUJ5WldkcGMzUnlZWFJwYjI1VGFHRndaU0E5SUVkc2IySmhiRk4wWVhSbFBITjBjbWx1Wno0b2V5QnBibWwwYVdGc1ZtRnNkV1U2SUNjb2RXbHVkRGdzZFdsdWREWTBMSFZwYm5RNExIVnBiblEyTkN4aWIyOXNLU2NzSUd0bGVUb2dSMkYwWlVkc2IySmhiRk4wWVhSbFMyVjVVbVZuYVhOMGNtRjBhVzl1VTJoaGNHVWdmU2tLSUNBZ0lIQjFjMmhpZVhSbGMzTWdJbkpsWjJsemRISmhkR2x2Ymw5emFHRndaU0lnSWloMWFXNTBPQ3gxYVc1ME5qUXNkV2x1ZERnc2RXbHVkRFkwTEdKdmIyd3BJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmMzUmhhMmx1WnkxaGJXOTFiblF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTWdvZ0lDQWdMeThnWTJobFkydFRhR0Z3WlNBOUlFZHNiMkpoYkZOMFlYUmxQSE4wY21sdVp6NG9leUJwYm1sMGFXRnNWbUZzZFdVNklDY25MQ0JyWlhrNklFZGhkR1ZIYkc5aVlXeFRkR0YwWlV0bGVVTm9aV05yVTJoaGNHVWdmU2tLSUNBZ0lIQjFjMmhpZVhSbGN5QWlZMmhsWTJ0ZmMyaGhjR1VpQ2lBZ0lDQmllWFJsWTE4eklDOHZJQ0lpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvS2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFESTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDNOMFlXdHBibWN0WVcxdmRXNTBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNelFLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCVGRHRnJhVzVuUVcxdmRXNTBSMkYwWlNCbGVIUmxibVJ6SUVGcmFYUmhRbUZ6WlVOdmJuUnlZV04wSUhzS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSjZJRzFoYVc1ZlkzSmxZWFJsWDA1dlQzQkFNVE1LSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGd6TWpsbU1EUmxaU0F3ZURjM1ltSTNPV0k1SURCNE5tVXdNMlkxTUdFZ01IZ3pOVEkwT1RreE5DQXdlRGt3WkRSbVlUVmtJREI0TXpObE9USmpPVFFnTUhnNE5UUmtaV1JsTUNBdkx5QnRaWFJvYjJRZ0ltTnZjM1FvWW5sMFpWdGRLWFZwYm5RMk5DSXNJRzFsZEdodlpDQWljbVZuYVhOMFpYSW9jR0Y1TEdKNWRHVmJYU2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbU5vWldOcktHRmtaSEpsYzNNc2RXbHVkRFkwTEdKNWRHVmJYU2xpYjI5c0lpd2diV1YwYUc5a0lDSm5aWFJTWldkcGMzUnlZWFJwYjI1VGFHRndaU2dvZFdsdWREZ3NkV2x1ZERZMExIVnBiblE0TEhWcGJuUTJOQ3hpYjI5c0tTa29kV2x1ZERnc2RXbHVkRFkwTEhWcGJuUTRMSFZwYm5RMk5DeGliMjlzS1NJc0lHMWxkR2h2WkNBaVoyVjBSVzUwY25rb2RXbHVkRFkwS1dKNWRHVmJYU0lzSUcxbGRHaHZaQ0FpZFhCa1lYUmxRV3RwZEdGRVFVOG9kV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW05d1ZYQW9LWFp2YVdRaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQmpiM04wSUhKbFoybHpkR1Z5SUdOb1pXTnJJR2RsZEZKbFoybHpkSEpoZEdsdmJsTm9ZWEJsSUdkbGRFVnVkSEo1SUhWd1pHRjBaVUZyYVhSaFJFRlBJRzFoYVc1ZmIzQlZjRjl5YjNWMFpVQXhNUW9nSUNBZ1pYSnlDZ3B0WVdsdVgyOXdWWEJmY205MWRHVkFNVEU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlltRnpaUzFqYjI1MGNtRmpkSE12WW1GelpTNTBjem8wTVFvZ0lDQWdMeThnYjNCVmNDZ3BPaUIyYjJsa0lIc2dmUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWpjbVZoZEdWZlRtOVBjRUF4TXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZjM1JoYTJsdVp5MWhiVzkxYm5RdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek5Bb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRk4wWVd0cGJtZEJiVzkxYm5SSFlYUmxJR1Y0ZEdWdVpITWdRV3RwZEdGQ1lYTmxRMjl1ZEhKaFkzUWdld29nSUNBZ2NIVnphR0o1ZEdWeklEQjRZMlE1WVdRMk4yVWdMeThnYldWMGFHOWtJQ0pqY21WaGRHVW9jM1J5YVc1bkxIVnBiblEyTkNsMmIybGtJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnWTNKbFlYUmxDaUFnSUNCbGNuSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMM04wWVd0cGJtY3RZVzF2ZFc1MEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9sTjBZV3RwYm1kQmJXOTFiblJIWVhSbExtTnlaV0YwWlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtTnlaV0YwWlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZjM1JoYTJsdVp5MWhiVzkxYm5RdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNU5Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJRzl1UTNKbFlYUmxPaUFuY21WeGRXbHlaU2NnZlNrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlltRnpaUzFqYjI1MGNtRmpkSE12WW1GelpTNTBjem95TlFvZ0lDQWdMeThnZG1WeWMybHZiaUE5SUVkc2IySmhiRk4wWVhSbFBITjBjbWx1Wno0b2V5QnJaWGs2SUVkc2IySmhiRk4wWVhSbFMyVjVWbVZ5YzJsdmJpQjlLUW9nSUNBZ2NIVnphR0o1ZEdWeklDSjJaWEp6YVc5dUlnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl6ZEdGcmFXNW5MV0Z0YjNWdWRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qazJDaUFnSUNBdkx5QjBhR2x6TG5abGNuTnBiMjR1ZG1Gc2RXVWdQU0IyWlhKemFXOXVDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZZbUZ6WlMxamIyNTBjbUZqZEhNdlltRnpaUzUwY3pveU53b2dJQ0FnTHk4Z1lXdHBkR0ZFUVU4Z1BTQkhiRzlpWVd4VGRHRjBaVHhCY0hCc2FXTmhkR2x2Ymo0b2V5QnJaWGs2SUVkc2IySmhiRk4wWVhSbFMyVjVRV3RwZEdGRVFVOGdmU2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbUZyYVhSaFgyUmhieUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmMzUmhhMmx1WnkxaGJXOTFiblF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem81TndvZ0lDQWdMeThnZEdocGN5NWhhMmwwWVVSQlR5NTJZV3gxWlNBOUlFRndjR3hwWTJGMGFXOXVLR0ZyYVhSaFJFRlBLUW9nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmMzUmhhMmx1WnkxaGJXOTFiblF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem81TkFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lHOXVRM0psWVhSbE9pQW5jbVZ4ZFdseVpTY2dmU2tLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDNOMFlXdHBibWN0WVcxdmRXNTBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPbE4wWVd0cGJtZEJiVzkxYm5SSFlYUmxMbU52YzNSYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGpiM04wT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXpkR0ZyYVc1bkxXRnRiM1Z1ZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFd01nb2dJQ0FnTHk4Z1kyOXpkQ2hoY21kek9pQmllWFJsY3lrNklIVnBiblEyTkNCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdjM2RoY0FvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREUxTVdZM1l6YzFNREF3TURBd01EQXdNREF3TXpObU5Bb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXpkR0ZyYVc1bkxXRnRiM1Z1ZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwVGRHRnJhVzVuUVcxdmRXNTBSMkYwWlM1eVpXZHBjM1JsY2x0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuSmxaMmx6ZEdWeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl6ZEdGcmFXNW5MV0Z0YjNWdWRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXdOZ29nSUNBZ0x5OGdjbVZuYVhOMFpYSW9iV0p5VUdGNWJXVnVkRG9nWjNSNGJpNVFZWGx0Wlc1MFZIaHVMQ0JoY21kek9pQmllWFJsY3lrNklIVnBiblEyTkNCN0NpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQzBLSUNBZ0lHUjFjQW9nSUNBZ1ozUjRibk1nVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTVNBdkx5QndZWGtLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2RISmhibk5oWTNScGIyNGdkSGx3WlNCcGN5QndZWGtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjRzRnTWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCa2RYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12YzNSaGEybHVaeTFoYlc5MWJuUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNRGNLSUNBZ0lDOHZJR3h2WjJkbFpFRnpjMlZ5ZENoaGNtZHpMbXhsYm1kMGFDQTlQVDBnVW1WbmFYTjBaWEpDZVhSbFRHVnVaM1JvTENCRlVsSmZTVTVXUVV4SlJGOUJVa2RmUTA5VlRsUXBDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTVRrS0lDQWdJRDA5Q2lBZ0lDQmlibm9nY21WbmFYTjBaWEpmWVdaMFpYSmZZWE56WlhKMFFETUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z0lrVlNVanBKUVZKSElnb2dJQ0FnYkc5bkNpQWdJQ0JsY25JZ0x5OGdSVkpTT2tsQlVrY0tDbkpsWjJsemRHVnlYMkZtZEdWeVgyRnpjMlZ5ZEVBek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl6ZEdGcmFXNW5MV0Z0YjNWdWRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXdPQW9nSUNBZ0x5OGdiRzluWjJWa1FYTnpaWEowS0cxaWNsQmhlVzFsYm5RdWNtVmpaV2wyWlhJZ1BUMDlJRWRzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekxDQkZVbEpmU1U1V1FVeEpSRjlRUVZsTlJVNVVLUW9nSUNBZ1pHbG5JRElLSUNBZ0lHZDBlRzV6SUZKbFkyVnBkbVZ5Q2lBZ0lDQm5iRzlpWVd3Z1EzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3dvZ0lDQWdQVDBLSUNBZ0lHSnVlaUJ5WldkcGMzUmxjbDloWm5SbGNsOWhjM05sY25SQU5Rb2dJQ0FnWW5sMFpXTWdOU0F2THlBaVJWSlNPa2xRUVZraUNpQWdJQ0JzYjJjS0lDQWdJR1Z5Y2lBdkx5QkZVbEk2U1ZCQldRb0tjbVZuYVhOMFpYSmZZV1owWlhKZllYTnpaWEowUURVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMM04wWVd0cGJtY3RZVzF2ZFc1MEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UQTVDaUFnSUNBdkx5QnNiMmRuWldSQmMzTmxjblFvYldKeVVHRjViV1Z1ZEM1aGJXOTFiblFnUFQwOUlGTjBZV3RwYm1kQmJXOTFiblJIWVhSbFVtVm5hWE4wY25sTlFsSXNJRVZTVWw5SlRsWkJURWxFWDFCQldVMUZUbFFwQ2lBZ0lDQmthV2NnTWdvZ0lDQWdaM1I0Ym5NZ1FXMXZkVzUwQ2lBZ0lDQndkWE5vYVc1MElERXpNekF3Q2lBZ0lDQTlQUW9nSUNBZ1ltNTZJSEpsWjJsemRHVnlYMkZtZEdWeVgyRnpjMlZ5ZEVBM0NpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKRlVsSTZTVkJCV1NJS0lDQWdJR3h2WndvZ0lDQWdaWEp5SUM4dklFVlNVanBKVUVGWkNncHlaV2RwYzNSbGNsOWhablJsY2w5aGMzTmxjblJBTnpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZjM1JoYTJsdVp5MWhiVzkxYm5RdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1UTUtJQ0FnSUM4dklHeHZaMmRsWkVGemMyVnlkQ2h3WVhKaGJYTXViM0F1WVhOVmFXNTBOalFvS1NBOFBTQTJNQ3dnUlZKU1gwSkJSRjlQVUVWU1FWUkpUMDRwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lHZGxkR0o1ZEdVS0lDQWdJSEIxYzJocGJuUWdOakFLSUNBZ0lEdzlDaUFnSUNCaWJub2djbVZuYVhOMFpYSmZZV1owWlhKZllYTnpaWEowUURrS0lDQWdJSEIxYzJoaWVYUmxjeUFpUlZKU09rSlBVRklpQ2lBZ0lDQnNiMmNLSUNBZ0lHVnljaUF2THlCRlVsSTZRazlRVWdvS2NtVm5hWE4wWlhKZllXWjBaWEpmWVhOelpYSjBRRGs2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwzTjBZV3RwYm1jdFlXMXZkVzUwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRFS0lDQWdJQzh2SUdOdmJuTjBJR2xrSUQwZ2RHaHBjeTV5WldkcGMzUnllVU4xY25OdmNpNTJZV3gxWlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmMzUmhhMmx1WnkxaGJXOTFiblF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96T0FvZ0lDQWdMeThnY21WbmFYTjBjbmxEZFhKemIzSWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0hzZ2FXNXBkR2xoYkZaaGJIVmxPaUF4TENCclpYazZJRWRoZEdWSGJHOWlZV3hUZEdGMFpVdGxlVkpsWjJsemRISjVRM1Z5YzI5eUlIMHBDaUFnSUNCaWVYUmxZMTh5SUM4dklDSnlaV2RwYzNSeWVWOWpkWEp6YjNJaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMM04wWVd0cGJtY3RZVzF2ZFc1MEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5URUtJQ0FnSUM4dklHTnZibk4wSUdsa0lEMGdkR2hwY3k1eVpXZHBjM1J5ZVVOMWNuTnZjaTUyWVd4MVpRb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZjM1JoYTJsdVp5MWhiVzkxYm5RdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU1nb2dJQ0FnTHk4Z2RHaHBjeTV5WldkcGMzUnllVU4xY25OdmNpNTJZV3gxWlNBclBTQXhDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0FyQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwzTjBZV3RwYm1jdFlXMXZkVzUwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpnS0lDQWdJQzh2SUhKbFoybHpkSEo1UTNWeWMyOXlJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGloN0lHbHVhWFJwWVd4V1lXeDFaVG9nTVN3Z2EyVjVPaUJIWVhSbFIyeHZZbUZzVTNSaGRHVkxaWGxTWldkcGMzUnllVU4xY25OdmNpQjlLUW9nSUNBZ1lubDBaV05mTWlBdkx5QWljbVZuYVhOMGNubGZZM1Z5YzI5eUlnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl6ZEdGcmFXNW5MV0Z0YjNWdWRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVXlDaUFnSUNBdkx5QjBhR2x6TG5KbFoybHpkSEo1UTNWeWMyOXlMblpoYkhWbElDczlJREVLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwzTjBZV3RwYm1jdFlXMXZkVzUwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRFMUNpQWdJQ0F2THlCMGFHbHpMbkpsWjJsemRISjVLR2xrS1M1MllXeDFaU0E5SUdOc2IyNWxLSEJoY21GdGN5a0tJQ0FnSUdsMGIySUtJQ0FnSUdSMWNBb2dJQ0FnWkdsbklESUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmMzUmhhMmx1WnkxaGJXOTFiblF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TURZS0lDQWdJQzh2SUhKbFoybHpkR1Z5S0cxaWNsQmhlVzFsYm5RNklHZDBlRzR1VUdGNWJXVnVkRlI0Yml3Z1lYSm5jem9nWW5sMFpYTXBPaUIxYVc1ME5qUWdld29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12YzNSaGEybHVaeTFoYlc5MWJuUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZVM1JoYTJsdVowRnRiM1Z1ZEVkaGRHVXVZMmhsWTJ0YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGphR1ZqYXpvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmtkWEJ1SURJS0lDQWdJR0o1ZEdWalh6TWdMeThnSWlJS0lDQWdJR1IxY0c0Z01nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl6ZEdGcmFXNW5MV0Z0YjNWdWRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXhPUW9nSUNBZ0x5OGdZMmhsWTJzb1kyRnNiR1Z5T2lCQlkyTnZkVzUwTENCeVpXZHBjM1J5ZVVsRU9pQjFhVzUwTmpRc0lHRnlaM002SUdKNWRHVnpLVG9nWW05dmJHVmhiaUI3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6SWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl6ZEdGcmFXNW5MV0Z0YjNWdWRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXlNQW9nSUNBZ0x5OGdiRzluWjJWa1FYTnpaWEowS0dGeVozTXViR1Z1WjNSb0lEMDlQU0F3TENCRlVsSmZTVTVXUVV4SlJGOUJVa2RmUTA5VlRsUXBDaUFnSUNCc1pXNEtJQ0FnSUdKNklHTm9aV05yWDJGbWRHVnlYMkZ6YzJWeWRFQXpDaUFnSUNCaWVYUmxZeUEwSUM4dklDSkZVbEk2U1VGU1J5SUtJQ0FnSUd4dlp3b2dJQ0FnWlhKeUlDOHZJRVZTVWpwSlFWSkhDZ3BqYUdWamExOWhablJsY2w5aGMzTmxjblJBTXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZjM1JoYTJsdVp5MWhiVzkxYm5RdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1qRUtJQ0FnSUM4dklHTnZibk4wSUhzZ2IzQXNJR0Z6YzJWMExDQmhiVzkxYm5Rc0lIUjVjR1VzSUdsdVkyeDFaR1ZGYzJOeWIzZGxaQ0I5SUQwZ1kyeHZibVVvZEdocGN5NXlaV2RwYzNSeWVTaHlaV2RwYzNSeWVVbEVLUzUyWVd4MVpTa0tJQ0FnSUdSMWNBb2dJQ0FnYVhSdllnb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklFSnZlQ0J0ZFhOMElHaGhkbVVnZG1Gc2RXVUtJQ0FnSUdSMWNBb2dJQ0FnWlhoMGNtRmpkQ0F3SURFS0lDQWdJR0oxY25rZ09Bb2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJREVnT0FvZ0lDQWdZblZ5ZVNBNUNpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdNVEFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmlkWEo1SURZS0lDQWdJR1IxY0FvZ0lDQWdaWGgwY21GamRDQTVJREVLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdZblZ5ZVNBNENpQWdJQ0J3ZFhOb2FXNTBJREUwTkFvZ0lDQWdaMlYwWW1sMENpQWdJQ0JpZFhKNUlEVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12YzNSaGEybHVaeTFoYlc5MWJuUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJOUW9nSUNBZ0x5OGdZMjl1YzNRZ1lYQndTV1FnUFNCblpYUkJhMmwwWVVGd2NFeHBjM1FvZEdocGN5NWhhMmwwWVVSQlR5NTJZV3gxWlNrdWMzUmhhMmx1WndvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5aVlYTmxMV052Ym5SeVlXTjBjeTlpWVhObExuUnpPakkzQ2lBZ0lDQXZMeUJoYTJsMFlVUkJUeUE5SUVkc2IySmhiRk4wWVhSbFBFRndjR3hwWTJGMGFXOXVQaWg3SUd0bGVUb2dSMnh2WW1Gc1UzUmhkR1ZMWlhsQmEybDBZVVJCVHlCOUtRb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVlXdHBkR0ZmWkdGdklnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl6ZEdGcmFXNW5MV0Z0YjNWdWRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWTFDaUFnSUNBdkx5QmpiMjV6ZENCaGNIQkpaQ0E5SUdkbGRFRnJhWFJoUVhCd1RHbHpkQ2gwYUdsekxtRnJhWFJoUkVGUExuWmhiSFZsS1M1emRHRnJhVzVuQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJaMWJtTjBhVzl1Y3k1MGN6bzBOQW9nSUNBZ0x5OGdZMjl1YzNRZ1cyRndjRXhwYzNSQ2VYUmxjMTBnUFNCdmNDNUJjSEJIYkc5aVlXd3VaMlYwUlhoQ2VYUmxjeWhoYTJsMFlVUkJUeXdnUW5sMFpYTW9RV3RwZEdGRVFVOUhiRzlpWVd4VGRHRjBaVXRsZVhOQmEybDBZVUZ3Y0V4cGMzUXBLUW9nSUNBZ2NIVnphR0o1ZEdWeklDSmhZV3dpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnY0c5d0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMM04wWVd0cGJtY3RZVzF2ZFc1MEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5qVUtJQ0FnSUM4dklHTnZibk4wSUdGd2NFbGtJRDBnWjJWMFFXdHBkR0ZCY0hCTWFYTjBLSFJvYVhNdVlXdHBkR0ZFUVU4dWRtRnNkV1VwTG5OMFlXdHBibWNLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ2MzZGhjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5emRHRnJhVzVuTFdGdGIzVnVkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalkzQ2lBZ0lDQXZMeUJwWmlBb2RIbHdaU0E5UFQwZ1UxUkJTMGxPUjE5VVdWQkZYMGhGUVZKVVFrVkJWQ2tnZXdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TUdFS0lDQWdJRDA5Q2lBZ0lDQmllaUJqYUdWamExOWxiSE5sWDJKdlpIbEFOZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5emRHRnJhVzVuTFdGdGIzVnVkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalk0TFRjeENpQWdJQ0F2THlCemRHRnJaV1FnUFNCaFltbERZV3hzUEhSNWNHVnZaaUJUZEdGcmFXNW5MbkJ5YjNSdmRIbHdaUzVuWlhSSVpXRnlkR0psWVhSQmRtVnlZV2RsUGloN0NpQWdJQ0F2THlBZ0lHRndjRWxrTEFvZ0lDQWdMeThnSUNCaGNtZHpPaUJiZFhObGNpd2dZWE56WlhRc0lHbHVZMngxWkdWRmMyTnliM2RsWkYwc0NpQWdJQ0F2THlCOUtTNXlaWFIxY201V1lXeDFaUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl6ZEdGcmFXNW5MV0Z0YjNWdWRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qY3dDaUFnSUNBdkx5QmhjbWR6T2lCYmRYTmxjaXdnWVhOelpYUXNJR2x1WTJ4MVpHVkZjMk55YjNkbFpGMHNDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdScFp5QTJDaUFnSUNCelpYUmlhWFFLSUNBZ0lITjNZWEFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXpkR0ZyYVc1bkxXRnRiM1Z1ZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZNExUY3hDaUFnSUNBdkx5QnpkR0ZyWldRZ1BTQmhZbWxEWVd4c1BIUjVjR1Z2WmlCVGRHRnJhVzVuTG5CeWIzUnZkSGx3WlM1blpYUklaV0Z5ZEdKbFlYUkJkbVZ5WVdkbFBpaDdDaUFnSUNBdkx5QWdJR0Z3Y0Vsa0xBb2dJQ0FnTHk4Z0lDQmhjbWR6T2lCYmRYTmxjaXdnWVhOelpYUXNJR2x1WTJ4MVpHVkZjMk55YjNkbFpGMHNDaUFnSUNBdkx5QjlLUzV5WlhSMWNtNVdZV3gxWlFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0WXpabVpEQmpZVFVnTHk4Z2JXVjBhRzlrSUNKblpYUklaV0Z5ZEdKbFlYUkJkbVZ5WVdkbEtHRmtaSEpsYzNNc2RXbHVkRFkwTEdKdmIyd3BkV2x1ZERZMElnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHUnBaeUF5Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnWkdsbklEZ0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnY0hWemFHbHVkQ0EySUM4dklHRndjR3dLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJR2wwZUc0Z1RHRnpkRXh2WndvZ0lDQWdaSFZ3Q2lBZ0lDQmxlSFJ5WVdOMElEUWdNQW9nSUNBZ2MzZGhjQW9nSUNBZ1pYaDBjbUZqZENBd0lEUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJDZVhSbGN5Qm9ZWE1nZG1Gc2FXUWdjSEpsWm1sNENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlIVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdZblZ5ZVNBekNncGphR1ZqYTE5aFpuUmxjbDlwWmw5bGJITmxRRGM2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwzTjBZV3RwYm1jdFlXMXZkVzUwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T0RJS0lDQWdJQzh2SUdOaGMyVWdSWEYxWVd3NklISmxkSFZ5YmlCemRHRnJaV1FnUFQwOUlHRnRiM1Z1ZEFvZ0lDQWdaR2xuSURZS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURCaENpQWdJQ0E5UFFvZ0lDQWdZbm9nWTJobFkydGZZV1owWlhKZmFXWmZaV3h6WlVBNUNpQWdJQ0JrYVdjZ01nb2dJQ0FnWkdsbklEVUtJQ0FnSUQwOUNncGphR1ZqYTE5aFpuUmxjbDlwYm14cGJtVmtYM050WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmMzUmhhMmx1WnkxaGJXOTFiblF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VTNSaGEybHVaMEZ0YjNWdWRFZGhkR1V1YzNSaGEybHVaMEZ0YjNWdWRFZGhkR1ZBTWpBNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMM04wWVd0cGJtY3RZVzF2ZFc1MEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1URTVDaUFnSUNBdkx5QmphR1ZqYXloallXeHNaWEk2SUVGalkyOTFiblFzSUhKbFoybHpkSEo1U1VRNklIVnBiblEyTkN3Z1lYSm5jem9nWW5sMFpYTXBPaUJpYjI5c1pXRnVJSHNLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6WlhSaWFYUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbU5vWldOclgyRm1kR1Z5WDJsbVgyVnNjMlZBT1RvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZjM1JoYTJsdVp5MWhiVzkxYm5RdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNE13b2dJQ0FnTHk4Z1kyRnpaU0JPYjNSRmNYVmhiRG9nY21WMGRYSnVJSE4wWVd0bFpDQWhQVDBnWVcxdmRXNTBDaUFnSUNCa2FXY2dOZ29nSUNBZ2NIVnphR0o1ZEdWeklEQjRNVFFLSUNBZ0lEMDlDaUFnSUNCaWVpQmphR1ZqYTE5aFpuUmxjbDlwWmw5bGJITmxRREV4Q2lBZ0lDQmthV2NnTWdvZ0lDQWdaR2xuSURVS0lDQWdJQ0U5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwzTjBZV3RwYm1jdFlXMXZkVzUwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRJeUxURXlPUW9nSUNBZ0x5OGdjbVYwZFhKdUlIUm9hWE11YzNSaGEybHVaMEZ0YjNWdWRFZGhkR1VvQ2lBZ0lDQXZMeUFnSUdOaGJHeGxjaXdLSUNBZ0lDOHZJQ0FnYjNBc0NpQWdJQ0F2THlBZ0lHRnpjMlYwTEFvZ0lDQWdMeThnSUNCaGJXOTFiblFzQ2lBZ0lDQXZMeUFnSUhSNWNHVXNDaUFnSUNBdkx5QWdJR2x1WTJ4MVpHVkZjMk55YjNkbFpBb2dJQ0FnTHk4Z0tRb2dJQ0FnWWlCamFHVmphMTloWm5SbGNsOXBibXhwYm1Wa1gzTnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12YzNSaGEybHVaeTFoYlc5MWJuUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZVM1JoYTJsdVowRnRiM1Z1ZEVkaGRHVXVjM1JoYTJsdVowRnRiM1Z1ZEVkaGRHVkFNakFLQ21Ob1pXTnJYMkZtZEdWeVgybG1YMlZzYzJWQU1URTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDNOMFlXdHBibWN0WVcxdmRXNTBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPRFFLSUNBZ0lDOHZJR05oYzJVZ1RHVnpjMVJvWVc0NklISmxkSFZ5YmlCemRHRnJaV1FnUENCaGJXOTFiblFLSUNBZ0lHUnBaeUEyQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd4WlFvZ0lDQWdQVDBLSUNBZ0lHSjZJR05vWldOclgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRNS0lDQWdJR1JwWnlBeUNpQWdJQ0JrYVdjZ05Rb2dJQ0FnUEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXpkR0ZyYVc1bkxXRnRiM1Z1ZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeU1pMHhNamtLSUNBZ0lDOHZJSEpsZEhWeWJpQjBhR2x6TG5OMFlXdHBibWRCYlc5MWJuUkhZWFJsS0FvZ0lDQWdMeThnSUNCallXeHNaWElzQ2lBZ0lDQXZMeUFnSUc5d0xBb2dJQ0FnTHk4Z0lDQmhjM05sZEN3S0lDQWdJQzh2SUNBZ1lXMXZkVzUwTEFvZ0lDQWdMeThnSUNCMGVYQmxMQW9nSUNBZ0x5OGdJQ0JwYm1Oc2RXUmxSWE5qY205M1pXUUtJQ0FnSUM4dklDa0tJQ0FnSUdJZ1kyaGxZMnRmWVdaMFpYSmZhVzVzYVc1bFpGOXpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDNOMFlXdHBibWN0WVcxdmRXNTBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPbE4wWVd0cGJtZEJiVzkxYm5SSFlYUmxMbk4wWVd0cGJtZEJiVzkxYm5SSFlYUmxRREl3Q2dwamFHVmphMTloWm5SbGNsOXBabDlsYkhObFFERXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5emRHRnJhVzVuTFdGdGIzVnVkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamcxQ2lBZ0lDQXZMeUJqWVhObElFeGxjM05VYUdGdVQzSkZjWFZoYkZSdk9pQnlaWFIxY200Z2MzUmhhMlZrSUR3OUlHRnRiM1Z1ZEFvZ0lDQWdaR2xuSURZS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURJNENpQWdJQ0E5UFFvZ0lDQWdZbm9nWTJobFkydGZZV1owWlhKZmFXWmZaV3h6WlVBeE5Rb2dJQ0FnWkdsbklESUtJQ0FnSUdScFp5QTFDaUFnSUNBOFBRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl6ZEdGcmFXNW5MV0Z0YjNWdWRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXlNaTB4TWprS0lDQWdJQzh2SUhKbGRIVnliaUIwYUdsekxuTjBZV3RwYm1kQmJXOTFiblJIWVhSbEtBb2dJQ0FnTHk4Z0lDQmpZV3hzWlhJc0NpQWdJQ0F2THlBZ0lHOXdMQW9nSUNBZ0x5OGdJQ0JoYzNObGRDd0tJQ0FnSUM4dklDQWdZVzF2ZFc1MExBb2dJQ0FnTHk4Z0lDQjBlWEJsTEFvZ0lDQWdMeThnSUNCcGJtTnNkV1JsUlhOamNtOTNaV1FLSUNBZ0lDOHZJQ2tLSUNBZ0lHSWdZMmhsWTJ0ZllXWjBaWEpmYVc1c2FXNWxaRjl6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwzTjBZV3RwYm1jdFlXMXZkVzUwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2xOMFlXdHBibWRCYlc5MWJuUkhZWFJsTG5OMFlXdHBibWRCYlc5MWJuUkhZWFJsUURJd0NncGphR1ZqYTE5aFpuUmxjbDlwWmw5bGJITmxRREUxT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXpkR0ZyYVc1bkxXRnRiM1Z1ZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pnMkNpQWdJQ0F2THlCallYTmxJRWR5WldGMFpYSlVhR0Z1T2lCeVpYUjFjbTRnYzNSaGEyVmtJRDRnWVcxdmRXNTBDaUFnSUNCa2FXY2dOZ29nSUNBZ2NIVnphR0o1ZEdWeklEQjRNeklLSUNBZ0lEMDlDaUFnSUNCaWVpQmphR1ZqYTE5aFpuUmxjbDlwWmw5bGJITmxRREUzQ2lBZ0lDQmthV2NnTWdvZ0lDQWdaR2xuSURVS0lDQWdJRDRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmMzUmhhMmx1WnkxaGJXOTFiblF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TWpJdE1USTVDaUFnSUNBdkx5QnlaWFIxY200Z2RHaHBjeTV6ZEdGcmFXNW5RVzF2ZFc1MFIyRjBaU2dLSUNBZ0lDOHZJQ0FnWTJGc2JHVnlMQW9nSUNBZ0x5OGdJQ0J2Y0N3S0lDQWdJQzh2SUNBZ1lYTnpaWFFzQ2lBZ0lDQXZMeUFnSUdGdGIzVnVkQ3dLSUNBZ0lDOHZJQ0FnZEhsd1pTd0tJQ0FnSUM4dklDQWdhVzVqYkhWa1pVVnpZM0p2ZDJWa0NpQWdJQ0F2THlBcENpQWdJQ0JpSUdOb1pXTnJYMkZtZEdWeVgybHViR2x1WldSZmMyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl6ZEdGcmFXNW5MV0Z0YjNWdWRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcFRkR0ZyYVc1blFXMXZkVzUwUjJGMFpTNXpkR0ZyYVc1blFXMXZkVzUwUjJGMFpVQXlNQW9LWTJobFkydGZZV1owWlhKZmFXWmZaV3h6WlVBeE56b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12YzNSaGEybHVaeTFoYlc5MWJuUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzROd29nSUNBZ0x5OGdZMkZ6WlNCSGNtVmhkR1Z5VkdoaGJrOXlSWEYxWVd4VWJ6b2djbVYwZFhKdUlITjBZV3RsWkNBK1BTQmhiVzkxYm5RS0lDQWdJR1JwWnlBMkNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnell3b2dJQ0FnUFQwS0lDQWdJR0o2SUdOb1pXTnJYMkZtZEdWeVgybG1YMlZzYzJWQU1Ua0tJQ0FnSUdScFp5QXlDaUFnSUNCa2FXY2dOUW9nSUNBZ1BqMEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12YzNSaGEybHVaeTFoYlc5MWJuUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNakl0TVRJNUNpQWdJQ0F2THlCeVpYUjFjbTRnZEdocGN5NXpkR0ZyYVc1blFXMXZkVzUwUjJGMFpTZ0tJQ0FnSUM4dklDQWdZMkZzYkdWeUxBb2dJQ0FnTHk4Z0lDQnZjQ3dLSUNBZ0lDOHZJQ0FnWVhOelpYUXNDaUFnSUNBdkx5QWdJR0Z0YjNWdWRDd0tJQ0FnSUM4dklDQWdkSGx3WlN3S0lDQWdJQzh2SUNBZ2FXNWpiSFZrWlVWelkzSnZkMlZrQ2lBZ0lDQXZMeUFwQ2lBZ0lDQmlJR05vWldOclgyRm1kR1Z5WDJsdWJHbHVaV1JmYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXpkR0ZyYVc1bkxXRnRiM1Z1ZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwVGRHRnJhVzVuUVcxdmRXNTBSMkYwWlM1emRHRnJhVzVuUVcxdmRXNTBSMkYwWlVBeU1Bb0tZMmhsWTJ0ZllXWjBaWEpmYVdaZlpXeHpaVUF4T1RvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZjM1JoYTJsdVp5MWhiVzkxYm5RdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNE9Bb2dJQ0FnTHk4Z1pHVm1ZWFZzZERvZ2NtVjBkWEp1SUdaaGJITmxDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl6ZEdGcmFXNW5MV0Z0YjNWdWRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXlNaTB4TWprS0lDQWdJQzh2SUhKbGRIVnliaUIwYUdsekxuTjBZV3RwYm1kQmJXOTFiblJIWVhSbEtBb2dJQ0FnTHk4Z0lDQmpZV3hzWlhJc0NpQWdJQ0F2THlBZ0lHOXdMQW9nSUNBZ0x5OGdJQ0JoYzNObGRDd0tJQ0FnSUM4dklDQWdZVzF2ZFc1MExBb2dJQ0FnTHk4Z0lDQjBlWEJsTEFvZ0lDQWdMeThnSUNCcGJtTnNkV1JsUlhOamNtOTNaV1FLSUNBZ0lDOHZJQ2tLSUNBZ0lHSWdZMmhsWTJ0ZllXWjBaWEpmYVc1c2FXNWxaRjl6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwzTjBZV3RwYm1jdFlXMXZkVzUwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2xOMFlXdHBibWRCYlc5MWJuUkhZWFJsTG5OMFlXdHBibWRCYlc5MWJuUkhZWFJsUURJd0NncGphR1ZqYTE5bGJITmxYMkp2WkhsQU5qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12YzNSaGEybHVaeTFoYlc5MWJuUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNNeTAzTmdvZ0lDQWdMeThnWTI5dWMzUWdhVzVtYnlBOUlHRmlhVU5oYkd3OGRIbHdaVzltSUZOMFlXdHBibWN1Y0hKdmRHOTBlWEJsTG0xMWMzUkhaWFJKYm1adlBpaDdDaUFnSUNBdkx5QWdJR0Z3Y0Vsa0xBb2dJQ0FnTHk4Z0lDQmhjbWR6T2lCYmRYTmxjaXdnZXlCaGMzTmxkQ3dnZEhsd1pTQjlYU3dLSUNBZ0lDOHZJSDBwTG5KbGRIVnlibFpoYkhWbENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwzTjBZV3RwYm1jdFlXMXZkVzUwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnpVS0lDQWdJQzh2SUdGeVozTTZJRnQxYzJWeUxDQjdJR0Z6YzJWMExDQjBlWEJsSUgxZExBb2dJQ0FnWkdsbklEZ0tJQ0FnSUdScFp5QTNDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXpkR0ZyYVc1bkxXRnRiM1Z1ZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pjekxUYzJDaUFnSUNBdkx5QmpiMjV6ZENCcGJtWnZJRDBnWVdKcFEyRnNiRHgwZVhCbGIyWWdVM1JoYTJsdVp5NXdjbTkwYjNSNWNHVXViWFZ6ZEVkbGRFbHVabTgrS0hzS0lDQWdJQzh2SUNBZ1lYQndTV1FzQ2lBZ0lDQXZMeUFnSUdGeVozTTZJRnQxYzJWeUxDQjdJR0Z6YzJWMExDQjBlWEJsSUgxZExBb2dJQ0FnTHk4Z2ZTa3VjbVYwZFhKdVZtRnNkV1VLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlR1ZoTjJSaE9UVTFJQzh2SUcxbGRHaHZaQ0FpYlhWemRFZGxkRWx1Wm04b1lXUmtjbVZ6Y3l3b2RXbHVkRFkwTEhWcGJuUTRLU2tvZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwS1NJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCa2FXY2dNZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCd2RYTm9hVzUwSURZZ0x5OGdZWEJ3YkFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnYVhSNGJpQk1ZWE4wVEc5bkNpQWdJQ0JrZFhBS0lDQWdJR1Y0ZEhKaFkzUWdOQ0F3Q2lBZ0lDQmthV2NnTVFvZ0lDQWdaWGgwY21GamRDQXdJRFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCQ2VYUmxjeUJvWVhNZ2RtRnNhV1FnY0hKbFptbDRDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkR0ZyYVc1bkwzUjVjR1Z6TG5Sek9qcFRkR0ZyWlFvZ0lDQWdjSFZ6YUdsdWRDQTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDNOMFlXdHBibWN0WVcxdmRXNTBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOemdLSUNBZ0lDOHZJSE4wWVd0bFpDQTlJR2x1Wm04dVlXMXZkVzUwQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdZblZ5ZVNBekNpQWdJQ0JpSUdOb1pXTnJYMkZtZEdWeVgybG1YMlZzYzJWQU53b0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZjM1JoYTJsdVp5MWhiVzkxYm5RdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlUzUmhhMmx1WjBGdGIzVnVkRWRoZEdVdVoyVjBVbVZuYVhOMGNtRjBhVzl1VTJoaGNHVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BuWlhSU1pXZHBjM1J5WVhScGIyNVRhR0Z3WlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZjM1JoYTJsdVp5MWhiVzkxYm5RdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE16SUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTVRrS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmMzUmhhMmx1WnkxaGJXOTFiblF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VTNSaGEybHVaMEZ0YjNWdWRFZGhkR1ZTWldkcGMzUnllVWx1Wm04S0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwzTjBZV3RwYm1jdFlXMXZkVzUwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2xOMFlXdHBibWRCYlc5MWJuUkhZWFJsTG1kbGRFVnVkSEo1VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1oyVjBSVzUwY25rNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMM04wWVd0cGJtY3RZVzF2ZFc1MEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UTTNDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnY21WaFpHOXViSGs2SUhSeWRXVWdmU2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZjM1JoYTJsdVp5MWhiVzkxYm5RdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE16a0tJQ0FnSUM4dklISmxkSFZ5YmlCbGJtTnZaR1ZCY21NMEtIUm9hWE11Y21WbmFYTjBjbmtvY21WbmFYTjBjbmxKUkNrdWRtRnNkV1VwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JoYzNObGNuUWdMeThnUW05NElHMTFjM1FnYUdGMlpTQjJZV3gxWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXpkR0ZyYVc1bkxXRnRiM1Z1ZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFek53b2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJSEpsWVdSdmJteDVPaUIwY25WbElIMHBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OWlZWE5sTFdOdmJuUnlZV04wY3k5aVlYTmxMblJ6T2pwQmEybDBZVUpoYzJWRGIyNTBjbUZqZEM1MWNHUmhkR1ZCYTJsMFlVUkJUMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25Wd1pHRjBaVUZyYVhSaFJFRlBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJKaGMyVXRZMjl1ZEhKaFkzUnpMMkpoYzJVdWRITTZNellLSUNBZ0lDOHZJSFZ3WkdGMFpVRnJhWFJoUkVGUEtHRnJhWFJoUkVGUE9pQkJjSEJzYVdOaGRHbHZiaWs2SUhadmFXUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwySmhjMlV0WTI5dWRISmhZM1J6TDJKaGMyVXVkSE02TXpjS0lDQWdJQzh2SUd4dloyZGxaRUZ6YzJWeWRDaFVlRzR1YzJWdVpHVnlJRDA5UFNCMGFHbHpMbWRsZEVGcmFYUmhSRUZQVjJGc2JHVjBLQ2t1WVdSa2NtVnpjeXdnUlZKU1gwNVBWRjlCUzBsVVFWOUVRVThwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12WW1GelpTMWpiMjUwY21GamRITXZZbUZ6WlM1MGN6b3pNQW9nSUNBZ0x5OGdZMjl1YzNRZ1czZGhiR3hsZEVsRVhTQTlJRzl3TGtGd2NFZHNiMkpoYkM1blpYUkZlRlZwYm5RMk5DaDBhR2x6TG1GcmFYUmhSRUZQTG5aaGJIVmxMQ0JDZVhSbGN5aEJhMmwwWVVSQlQwZHNiMkpoYkZOMFlYUmxTMlY1YzFkaGJHeGxkQ2twQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJKaGMyVXRZMjl1ZEhKaFkzUnpMMkpoYzJVdWRITTZNamNLSUNBZ0lDOHZJR0ZyYVhSaFJFRlBJRDBnUjJ4dlltRnNVM1JoZEdVOFFYQndiR2xqWVhScGIyNCtLSHNnYTJWNU9pQkhiRzlpWVd4VGRHRjBaVXRsZVVGcmFYUmhSRUZQSUgwcENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKaGEybDBZVjlrWVc4aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZZbUZ6WlMxamIyNTBjbUZqZEhNdlltRnpaUzUwY3pvek1Bb2dJQ0FnTHk4Z1kyOXVjM1FnVzNkaGJHeGxkRWxFWFNBOUlHOXdMa0Z3Y0Vkc2IySmhiQzVuWlhSRmVGVnBiblEyTkNoMGFHbHpMbUZyYVhSaFJFRlBMblpoYkhWbExDQkNlWFJsY3loQmEybDBZVVJCVDBkc2IySmhiRk4wWVhSbFMyVjVjMWRoYkd4bGRDa3BDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnY0hWemFHSjVkR1Z6SUNKM1lXeHNaWFFpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnY0c5d0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZZbUZ6WlMxamIyNTBjbUZqZEhNdlltRnpaUzUwY3pvek53b2dJQ0FnTHk4Z2JHOW5aMlZrUVhOelpYSjBLRlI0Ymk1elpXNWtaWElnUFQwOUlIUm9hWE11WjJWMFFXdHBkR0ZFUVU5WFlXeHNaWFFvS1M1aFpHUnlaWE56TENCRlVsSmZUazlVWDBGTFNWUkJYMFJCVHlrS0lDQWdJR0Z3Y0Y5d1lYSmhiWE5mWjJWMElFRndjRUZrWkhKbGMzTUtJQ0FnSUdGemMyVnlkQ0F2THlCaGNIQnNhV05oZEdsdmJpQmxlR2x6ZEhNS0lDQWdJRDA5Q2lBZ0lDQmlibm9nZFhCa1lYUmxRV3RwZEdGRVFVOWZZV1owWlhKZllYTnpaWEowUURNS0lDQWdJSEIxYzJoaWVYUmxjeUFpUlZKU09rNUVRVThpQ2lBZ0lDQnNiMmNLSUNBZ0lHVnljaUF2THlCRlVsSTZUa1JCVHdvS2RYQmtZWFJsUVd0cGRHRkVRVTlmWVdaMFpYSmZZWE56WlhKMFFETTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12WW1GelpTMWpiMjUwY21GamRITXZZbUZ6WlM1MGN6b3lOd29nSUNBZ0x5OGdZV3RwZEdGRVFVOGdQU0JIYkc5aVlXeFRkR0YwWlR4QmNIQnNhV05oZEdsdmJqNG9leUJyWlhrNklFZHNiMkpoYkZOMFlYUmxTMlY1UVd0cGRHRkVRVThnZlNrS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1GcmFYUmhYMlJoYnlJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OWlZWE5sTFdOdmJuUnlZV04wY3k5aVlYTmxMblJ6T2pNNENpQWdJQ0F2THlCMGFHbHpMbUZyYVhSaFJFRlBMblpoYkhWbElEMGdZV3RwZEdGRVFVOEtJQ0FnSUdScFp5QXhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJKaGMyVXRZMjl1ZEhKaFkzUnpMMkpoYzJVdWRITTZNellLSUNBZ0lDOHZJSFZ3WkdGMFpVRnJhWFJoUkVGUEtHRnJhWFJoUkVGUE9pQkJjSEJzYVdOaGRHbHZiaWs2SUhadmFXUWdld29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERUtJQ0FnSUhKbGRIVnliZ289In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFBRUNDQ1lHQkJVZmZIVUpZV3RwZEdGZlpHRnZEM0psWjJsemRISjVYMk4xY25OdmNnQUlSVkpTT2tsQlVrY0lSVkpTT2tsUVFWa3hHRUFBU1Nvalo0SUNFbkpsWjJsemRISmhkR2x2Ymw5emFHRndaU0FvZFdsdWREZ3NkV2x1ZERZMExIVnBiblE0TEhWcGJuUTJOQ3hpYjI5c0tXZUFDMk5vWldOclgzTm9ZWEJsSzJjeEdSUkVNUmhCQUR1Q0J3UXlud1R1QkhlN2Via0ViZ1AxQ2dRMUpKa1VCSkRVK2wwRU0ra3NsQVNGVGUzZ05ob0FqZ2NBT3dCWUFNY0NHUUlvQWtJQUFRQWpRNEFFelpyV2ZqWWFBSTRCQUFFQU5ob0JTU0paSkFoTEFSVVNSRmNDQURZYUFra1ZKUkpFRjRBSGRtVnljMmx2Yms4Q1p5bE1aeU5ETmhvQlNTSlpKQWhNRlJKRWdBd1ZIM3gxQUFBQUFBQUFNL1N3STBNeEZpTUpTVGdRSXhKRU5ob0JSd0lpV1NRSVN3RVZFa1JYQWdCSkZZRVRFa0FBQkNjRXNBQkxBamdITWdvU1FBQUVKd1d3QUVzQ09BaUI5R2NTUUFBRUp3V3dBRXNCSkZXQlBBNUFBQXlBQ0VWU1VqcENUMUJTc0FBaUttVkVTU01JS2t4bkZrbExBcjhvVEZDd0kwTWlSd0lyUndJMkdnRkpGWUVnRWtRMkdnSkpGU1VTUkJjMkdnTkpJbGtrQ0VzQkZSSkVWd0lBRlVFQUJDY0VzQUJKRnI1RVNWY0FBVVVJU1ZjQkNFVUpTWUVLVzBVR1NWY0pBVWxPQWtVSWdaQUJVMFVGSWlsbFJJQURZV0ZzWlVnaVcweUFBUW9TUVFDdXNZQUJBQ0pMQmxSTXNoaUFCTWI5REtXeUdrc0NzaHBMQ0xJYXNocUJCcklRSXJJQnM3UStTVmNFQUV4WEFBUW9Fa1JKRlNVU1JCZEZBMHNHZ0FFS0VrRUFFa3NDU3dVU2dBRUFJazhDVkNoTVVMQWpRMHNHZ0FFVUVrRUFDRXNDU3dVVFF2L2lTd2FBQVI0U1FRQUlTd0pMQlF4Qy85RkxCb0FCS0JKQkFBaExBa3NGRGtML3dFc0dnQUV5RWtFQUNFc0NTd1VOUXYrdlN3YUFBVHdTUVFBSVN3SkxCUTlDLzU0aVF2K2FzVXNJU3dkUVRMSVlnQVRxZmFsVnNocExBcklhc2hxQkJySVFJcklCczdRK1NWY0VBRXNCVndBRUtCSkVGWUVnRWtTQkJGdEZBMEwvVWpZYUFVa1ZnUk1TUkNoTVVMQWpRellhQVVrVkpSSkVGeGErUkVrVkZsY0dBa3hRS0V4UXNDTkROaG9CU1JVbEVrUVhNUUFpS1dWRWdBWjNZV3hzWlhSbFNISUlSQkpBQUF5QUNFVlNVanBPUkVGUHNBQXBTd0ZuSTBNPSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjksInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
