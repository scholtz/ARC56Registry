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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU3Rha2luZ0Ftb3VudEdhdGUiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiU3Rha2luZ0Ftb3VudEdhdGVSZWdpc3RyeUluZm8iOlt7Im5hbWUiOiJvcCIsInR5cGUiOiJ1aW50OCJ9LHsibmFtZSI6ImFzc2V0IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InR5cGUiLCJ0eXBlIjoidWludDgifSx7Im5hbWUiOiJhbW91bnQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiaW5jbHVkZUVzY3Jvd2VkIiwidHlwZSI6ImJvb2wifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZlcnNpb24iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFraXRhREFPIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNvc3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXJncyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlZ2lzdGVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1iclBheW1lbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFyZ3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjaGVjayIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FsbGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWdpc3RyeUlEIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcmdzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFJlZ2lzdHJhdGlvblNoYXBlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6Iih1aW50OCx1aW50NjQsdWludDgsdWludDY0LGJvb2wpIiwic3RydWN0IjoiU3Rha2luZ0Ftb3VudEdhdGVSZWdpc3RyeUluZm8iLCJuYW1lIjoic2hhcGUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ4LHVpbnQ2NCx1aW50OCx1aW50NjQsYm9vbCkiLCJzdHJ1Y3QiOiJTdGFraW5nQW1vdW50R2F0ZVJlZ2lzdHJ5SW5mbyIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0RW50cnkiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVnaXN0cnlJRCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidXBkYXRlQWtpdGFEQU8iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWtpdGFEQU8iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoib3BVcCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MiwiYnl0ZXMiOjN9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzUzNSw5MTVdLCJlcnJvck1lc3NhZ2UiOiJCb3ggbXVzdCBoYXZlIHZhbHVlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjQxLDgwMCw4NjRdLCJlcnJvck1lc3NhZ2UiOiJCeXRlcyBoYXMgdmFsaWQgcHJlZml4IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDEwLDQ1N10sImVycm9yTWVzc2FnZSI6IkVSUjplcnJCb3ByIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzUyLDUzMl0sImVycm9yTWVzc2FnZSI6IkVSUjplcnJJYXJnIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzY2LDM4MV0sImVycm9yTWVzc2FnZSI6IkVSUjplcnJJcGF5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTc2XSwiZXJyb3JNZXNzYWdlIjoiRVJSOmVyck5kYW8iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5NTddLCJlcnJvck1lc3NhZ2UiOiJhcHBsaWNhdGlvbiBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NjEsNTcwLDk0NF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIEdsb2JhbFN0YXRlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI0NiwyODgsMzMwLDUxNF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI1MywyOTQsMzM3LDUyMV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0OTldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjY0LDUwNyw5MTEsOTM3XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODk3XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIHNtYXJ0X2NvbnRyYWN0cy9nYXRlcy9zdWItZ2F0ZXMvc3Rha2luZy1hbW91bnQvY29udHJhY3QuYWxnby50czo6U3Rha2luZ0Ftb3VudEdhdGVSZWdpc3RyeUluZm8iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4MDVdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3Igc21hcnRfY29udHJhY3RzL3N0YWtpbmcvdHlwZXMudHM6OlN0YWtlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODY5XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIHNtYXJ0X2NvbnRyYWN0cy9zdGFraW5nL3R5cGVzLnRzOjpTdGFrZUNoZWNrIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjQ2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIHVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMyM10sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgcGF5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNQ0F4SURJZ09Bb2dJQ0FnWW5sMFpXTmliRzlqYXlBd2VERTFNV1kzWXpjMUlDSmhhMmwwWVY5a1lXOGlJQ0p5WldkcGMzUnllVjlqZFhKemIzSWlJQ0lpSURCNE1HRWdNSGd4TkNBaVJWSlNPbVZ5Y2tsaGNtY2lJQ0pGVWxJNlpYSnlTWEJoZVNJZ0lrVlNVanBsY25KQ2IzQnlJZ29nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0p1ZWlCdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl6ZEdGcmFXNW5MV0Z0YjNWdWRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTRDaUFnSUNBdkx5QnlaV2RwYzNSeWVVTjFjbk52Y2lBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9leUJwYm1sMGFXRnNWbUZzZFdVNklERXNJR3RsZVRvZ1IyRjBaVWRzYjJKaGJGTjBZWFJsUzJWNVVtVm5hWE4wY25sRGRYSnpiM0lnZlNrS0lDQWdJR0o1ZEdWalh6SWdMeThnSW5KbFoybHpkSEo1WDJOMWNuTnZjaUlLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5emRHRnJhVzVuTFdGdGIzVnVkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalF3Q2lBZ0lDQXZMeUJ5WldkcGMzUnlZWFJwYjI1VGFHRndaU0E5SUVkc2IySmhiRk4wWVhSbFBITjBjbWx1Wno0b2V5QnBibWwwYVdGc1ZtRnNkV1U2SUNjb2RXbHVkRGdzZFdsdWREWTBMSFZwYm5RNExIVnBiblEyTkN4aWIyOXNLU2NzSUd0bGVUb2dSMkYwWlVkc2IySmhiRk4wWVhSbFMyVjVVbVZuYVhOMGNtRjBhVzl1VTJoaGNHVWdmU2tLSUNBZ0lIQjFjMmhpZVhSbGMzTWdJbkpsWjJsemRISmhkR2x2Ymw5emFHRndaU0lnSWloMWFXNTBPQ3gxYVc1ME5qUXNkV2x1ZERnc2RXbHVkRFkwTEdKdmIyd3BJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmMzUmhhMmx1WnkxaGJXOTFiblF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTWdvZ0lDQWdMeThnWTJobFkydFRhR0Z3WlNBOUlFZHNiMkpoYkZOMFlYUmxQSE4wY21sdVp6NG9leUJwYm1sMGFXRnNWbUZzZFdVNklDY25MQ0JyWlhrNklFZGhkR1ZIYkc5aVlXeFRkR0YwWlV0bGVVTm9aV05yVTJoaGNHVWdmU2tLSUNBZ0lIQjFjMmhpZVhSbGN5QWlZMmhsWTJ0ZmMyaGhjR1VpQ2lBZ0lDQmllWFJsWTE4eklDOHZJQ0lpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvS2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFESTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDNOMFlXdHBibWN0WVcxdmRXNTBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNelFLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCVGRHRnJhVzVuUVcxdmRXNTBSMkYwWlNCbGVIUmxibVJ6SUVGcmFYUmhRbUZ6WlVOdmJuUnlZV04wSUhzS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSjZJRzFoYVc1ZlkzSmxZWFJsWDA1dlQzQkFNVE1LSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGd6TWpsbU1EUmxaU0F3ZURjM1ltSTNPV0k1SURCNE5tVXdNMlkxTUdFZ01IZ3pOVEkwT1RreE5DQXdlRGt3WkRSbVlUVmtJREI0TXpObE9USmpPVFFnTUhnNE5UUmtaV1JsTUNBdkx5QnRaWFJvYjJRZ0ltTnZjM1FvWW5sMFpWdGRLWFZwYm5RMk5DSXNJRzFsZEdodlpDQWljbVZuYVhOMFpYSW9jR0Y1TEdKNWRHVmJYU2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbU5vWldOcktHRmtaSEpsYzNNc2RXbHVkRFkwTEdKNWRHVmJYU2xpYjI5c0lpd2diV1YwYUc5a0lDSm5aWFJTWldkcGMzUnlZWFJwYjI1VGFHRndaU2dvZFdsdWREZ3NkV2x1ZERZMExIVnBiblE0TEhWcGJuUTJOQ3hpYjI5c0tTa29kV2x1ZERnc2RXbHVkRFkwTEhWcGJuUTRMSFZwYm5RMk5DeGliMjlzS1NJc0lHMWxkR2h2WkNBaVoyVjBSVzUwY25rb2RXbHVkRFkwS1dKNWRHVmJYU0lzSUcxbGRHaHZaQ0FpZFhCa1lYUmxRV3RwZEdGRVFVOG9kV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW05d1ZYQW9LWFp2YVdRaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQmpiM04wSUhKbFoybHpkR1Z5SUdOb1pXTnJJR2RsZEZKbFoybHpkSEpoZEdsdmJsTm9ZWEJsSUdkbGRFVnVkSEo1SUhWd1pHRjBaVUZyYVhSaFJFRlBJRzFoYVc1ZmIzQlZjRjl5YjNWMFpVQXhNUW9nSUNBZ1pYSnlDZ3B0WVdsdVgyOXdWWEJmY205MWRHVkFNVEU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlltRnpaUzFqYjI1MGNtRmpkSE12ZFhCbmNtRmtaV0ZpYkdVdWRITTZNekFLSUNBZ0lDOHZJRzl3VlhBb0tUb2dkbTlwWkNCN0lIMEtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZlkzSmxZWFJsWDA1dlQzQkFNVE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwzTjBZV3RwYm1jdFlXMXZkVzUwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpRS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QlRkR0ZyYVc1blFXMXZkVzUwUjJGMFpTQmxlSFJsYm1SeklFRnJhWFJoUW1GelpVTnZiblJ5WVdOMElIc0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VHTmtPV0ZrTmpkbElDOHZJRzFsZEdodlpDQWlZM0psWVhSbEtITjBjbWx1Wnl4MWFXNTBOalFwZG05cFpDSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JR055WldGMFpRb2dJQ0FnWlhKeUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXpkR0ZyYVc1bkxXRnRiM1Z1ZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwVGRHRnJhVzVuUVcxdmRXNTBSMkYwWlM1amNtVmhkR1ZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwamNtVmhkR1U2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwzTjBZV3RwYm1jdFlXMXZkVzUwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRBMkNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2diMjVEY21WaGRHVTZJQ2R5WlhGMWFYSmxKeUI5S1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5aVlYTmxMV052Ym5SeVlXTjBjeTkxY0dkeVlXUmxZV0pzWlM1MGN6b3hOQW9nSUNBZ0x5OGdkbVZ5YzJsdmJpQTlJRWRzYjJKaGJGTjBZWFJsUEhOMGNtbHVaejRvZXlCclpYazZJRWRzYjJKaGJGTjBZWFJsUzJWNVZtVnljMmx2YmlCOUtRb2dJQ0FnY0hWemFHSjVkR1Z6SUNKMlpYSnphVzl1SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXpkR0ZyYVc1bkxXRnRiM1Z1ZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFd09Bb2dJQ0FnTHk4Z2RHaHBjeTUyWlhKemFXOXVMblpoYkhWbElEMGdkbVZ5YzJsdmJnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwySmhjMlV0WTI5dWRISmhZM1J6TDNWd1ozSmhaR1ZoWW14bExuUnpPakUyQ2lBZ0lDQXZMeUJoYTJsMFlVUkJUeUE5SUVkc2IySmhiRk4wWVhSbFBFRndjR3hwWTJGMGFXOXVQaWg3SUd0bGVUb2dSMnh2WW1Gc1UzUmhkR1ZMWlhsQmEybDBZVVJCVHlCOUtRb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVlXdHBkR0ZmWkdGdklnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl6ZEdGcmFXNW5MV0Z0YjNWdWRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXdPUW9nSUNBZ0x5OGdkR2hwY3k1aGEybDBZVVJCVHk1MllXeDFaU0E5SUVGd2NHeHBZMkYwYVc5dUtHRnJhWFJoUkVGUEtRb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12YzNSaGEybHVaeTFoYlc5MWJuUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNRFlLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCdmJrTnlaV0YwWlRvZ0ozSmxjWFZwY21VbklIMHBDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl6ZEdGcmFXNW5MV0Z0YjNWdWRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcFRkR0ZyYVc1blFXMXZkVzUwUjJGMFpTNWpiM04wVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1kyOXpkRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmMzUmhhMmx1WnkxaGJXOTFiblF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TVRRS0lDQWdJQzh2SUdOdmMzUW9ZWEpuY3pvZ1lubDBaWE1wT2lCMWFXNTBOalFnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJQ3NLSUNBZ0lITjNZWEFLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3hOVEZtTjJNM05UQXdNREF3TURBd01EQXdNRE16WmpRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmMzUmhhMmx1WnkxaGJXOTFiblF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VTNSaGEybHVaMEZ0YjNWdWRFZGhkR1V1Y21WbmFYTjBaWEpiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dweVpXZHBjM1JsY2pvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eklDOHZJQ0lpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwzTjBZV3RwYm1jdFlXMXZkVzUwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRFNENpQWdJQ0F2THlCeVpXZHBjM1JsY2lodFluSlFZWGx0Wlc1ME9pQm5kSGh1TGxCaGVXMWxiblJVZUc0c0lHRnlaM002SUdKNWRHVnpLVG9nZFdsdWREWTBJSHNLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWkhWd0NpQWdJQ0JuZEhodWN5QlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHhJQzh2SUhCaGVRb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUIwY21GdWMyRmpkR2x2YmlCMGVYQmxJR2x6SUhCaGVRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd2JpQXlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJR1IxY0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXpkR0ZyYVc1bkxXRnRiM1Z1ZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeE9Rb2dJQ0FnTHk4Z2JHOW5aMlZrUVhOelpYSjBLR0Z5WjNNdWJHVnVaM1JvSUQwOVBTQlNaV2RwYzNSbGNrSjVkR1ZNWlc1bmRHZ3NJR1Z5Y2tsdWRtRnNhV1JCY21kRGIzVnVkQ2tLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBeE9Rb2dJQ0FnUFQwS0lDQWdJR0p1ZWlCeVpXZHBjM1JsY2w5aFpuUmxjbDloYzNObGNuUkFNd29nSUNBZ1lubDBaV01nTmlBdkx5QWlSVkpTT21WeWNrbGhjbWNpQ2lBZ0lDQnNiMmNLSUNBZ0lHVnljaUF2THlCRlVsSTZaWEp5U1dGeVp3b0tjbVZuYVhOMFpYSmZZV1owWlhKZllYTnpaWEowUURNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMM04wWVd0cGJtY3RZVzF2ZFc1MEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1USXdDaUFnSUNBdkx5QnNiMmRuWldSQmMzTmxjblFvYldKeVVHRjViV1Z1ZEM1eVpXTmxhWFpsY2lBOVBUMGdSMnh2WW1Gc0xtTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNc0lHVnlja2x1ZG1Gc2FXUlFZWGx0Wlc1MEtRb2dJQ0FnWkdsbklESUtJQ0FnSUdkMGVHNXpJRkpsWTJWcGRtVnlDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29nSUNBZ1BUMEtJQ0FnSUdKdWVpQnlaV2RwYzNSbGNsOWhablJsY2w5aGMzTmxjblJBTlFvZ0lDQWdZbmwwWldNZ055QXZMeUFpUlZKU09tVnlja2x3WVhraUNpQWdJQ0JzYjJjS0lDQWdJR1Z5Y2lBdkx5QkZVbEk2WlhKeVNYQmhlUW9LY21WbmFYTjBaWEpmWVdaMFpYSmZZWE56WlhKMFFEVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDNOMFlXdHBibWN0WVcxdmRXNTBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEl4Q2lBZ0lDQXZMeUJzYjJkblpXUkJjM05sY25Rb2JXSnlVR0Y1YldWdWRDNWhiVzkxYm5RZ1BUMDlJRk4wWVd0cGJtZEJiVzkxYm5SSFlYUmxVbVZuYVhOMGNubE5RbElzSUdWeWNrbHVkbUZzYVdSUVlYbHRaVzUwS1FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCbmRIaHVjeUJCYlc5MWJuUUtJQ0FnSUhCMWMyaHBiblFnTVRNek1EQUtJQ0FnSUQwOUNpQWdJQ0JpYm5vZ2NtVm5hWE4wWlhKZllXWjBaWEpmWVhOelpYSjBRRGNLSUNBZ0lHSjVkR1ZqSURjZ0x5OGdJa1ZTVWpwbGNuSkpjR0Y1SWdvZ0lDQWdiRzluQ2lBZ0lDQmxjbklnTHk4Z1JWSlNPbVZ5Y2tsd1lYa0tDbkpsWjJsemRHVnlYMkZtZEdWeVgyRnpjMlZ5ZEVBM09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl6ZEdGcmFXNW5MV0Z0YjNWdWRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXlOUW9nSUNBZ0x5OGdiRzluWjJWa1FYTnpaWEowS0hCaGNtRnRjeTV2Y0M1aGMxVnBiblEyTkNncElENDlJRVZ4ZFdGc0xtRnpWV2x1ZERZMEtDa2dKaVlnY0dGeVlXMXpMbTl3TG1GelZXbHVkRFkwS0NrZ1BEMGdSM0psWVhSbGNsUm9ZVzVQY2tWeGRXRnNWRzh1WVhOVmFXNTBOalFvS1N3Z1pYSnlRbUZrVDNCbGNtRjBhVzl1S1FvZ0lDQWdaR2xuSURFS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQm5aWFJpZVhSbENpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ05Bb2dJQ0FnY0hWemFHbHVkQ0F4TUFvZ0lDQWdQajBLSUNBZ0lHSjZJSEpsWjJsemRHVnlYMkp2YjJ4ZlptRnNjMlZBTVRBS0lDQWdJR1JwWnlBeUNpQWdJQ0J3ZFhOb2FXNTBJRFl3Q2lBZ0lDQThQUW9nSUNBZ1lub2djbVZuYVhOMFpYSmZZbTl2YkY5bVlXeHpaVUF4TUFvZ0lDQWdhVzUwWTE4eElDOHZJREVLQ25KbFoybHpkR1Z5WDJKdmIyeGZiV1Z5WjJWQU1URTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDNOMFlXdHBibWN0WVcxdmRXNTBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEkxQ2lBZ0lDQXZMeUJzYjJkblpXUkJjM05sY25Rb2NHRnlZVzF6TG05d0xtRnpWV2x1ZERZMEtDa2dQajBnUlhGMVlXd3VZWE5WYVc1ME5qUW9LU0FtSmlCd1lYSmhiWE11YjNBdVlYTlZhVzUwTmpRb0tTQThQU0JIY21WaGRHVnlWR2hoYms5eVJYRjFZV3hVYnk1aGMxVnBiblEyTkNncExDQmxjbkpDWVdSUGNHVnlZWFJwYjI0cENpQWdJQ0JpYm5vZ2NtVm5hWE4wWlhKZllXWjBaWEpmWVhOelpYSjBRREV6Q2lBZ0lDQmllWFJsWXlBNElDOHZJQ0pGVWxJNlpYSnlRbTl3Y2lJS0lDQWdJR3h2WndvZ0lDQWdaWEp5SUM4dklFVlNVanBsY25KQ2IzQnlDZ3B5WldkcGMzUmxjbDloWm5SbGNsOWhjM05sY25SQU1UTTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDNOMFlXdHBibWN0WVcxdmRXNTBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEkzQ2lBZ0lDQXZMeUJ3WVhKaGJYTXVkSGx3WlNBOVBUMGdVMVJCUzBsT1IxOVVXVkJGWDBoRlFWSlVRa1ZCVkNCOGZBb2dJQ0FnYzNkaGNBb2dJQ0FnWlhoMGNtRmpkQ0F4TVNBeENpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ05Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl6ZEdGcmFXNW5MV0Z0YjNWdWRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXlOUW9nSUNBZ0x5OGdiRzluWjJWa1FYTnpaWEowS0hCaGNtRnRjeTV2Y0M1aGMxVnBiblEyTkNncElENDlJRVZ4ZFdGc0xtRnpWV2x1ZERZMEtDa2dKaVlnY0dGeVlXMXpMbTl3TG1GelZXbHVkRFkwS0NrZ1BEMGdSM0psWVhSbGNsUm9ZVzVQY2tWeGRXRnNWRzh1WVhOVmFXNTBOalFvS1N3Z1pYSnlRbUZrVDNCbGNtRjBhVzl1S1FvZ0lDQWdZbmwwWldNZ05DQXZMeUF3ZURCaENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMM04wWVd0cGJtY3RZVzF2ZFc1MEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1USTNDaUFnSUNBdkx5QndZWEpoYlhNdWRIbHdaU0E5UFQwZ1UxUkJTMGxPUjE5VVdWQkZYMGhGUVZKVVFrVkJWQ0I4ZkFvZ0lDQWdQVDBLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmMzUmhhMmx1WnkxaGJXOTFiblF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TWpjdE1USTRDaUFnSUNBdkx5QndZWEpoYlhNdWRIbHdaU0E5UFQwZ1UxUkJTMGxPUjE5VVdWQkZYMGhGUVZKVVFrVkJWQ0I4ZkFvZ0lDQWdMeThnY0dGeVlXMXpMblI1Y0dVZ1BUMDlJRk5VUVV0SlRrZGZWRmxRUlY5VFQwWlVJSHg4Q2lBZ0lDQmlibm9nY21WbmFYTjBaWEpmWW05dmJGOTBjblZsUURFM0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMM04wWVd0cGJtY3RZVzF2ZFc1MEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1USTRDaUFnSUNBdkx5QndZWEpoYlhNdWRIbHdaU0E5UFQwZ1UxUkJTMGxPUjE5VVdWQkZYMU5QUmxRZ2ZId0tJQ0FnSUdScFp5QXlDaUFnSUNCaWVYUmxZeUExSUM4dklEQjRNVFFLSUNBZ0lEMDlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDNOMFlXdHBibWN0WVcxdmRXNTBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEkzTFRFeU9Bb2dJQ0FnTHk4Z2NHRnlZVzF6TG5SNWNHVWdQVDA5SUZOVVFVdEpUa2RmVkZsUVJWOUlSVUZTVkVKRlFWUWdmSHdLSUNBZ0lDOHZJSEJoY21GdGN5NTBlWEJsSUQwOVBTQlRWRUZMU1U1SFgxUlpVRVZmVTA5R1ZDQjhmQW9nSUNBZ1ltNTZJSEpsWjJsemRHVnlYMkp2YjJ4ZmRISjFaVUF4TndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXpkR0ZyYVc1bkxXRnRiM1Z1ZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeU9Rb2dJQ0FnTHk4Z2NHRnlZVzF6TG5SNWNHVWdQVDA5SUZOVVFVdEpUa2RmVkZsUVJWOUlRVkpFSUh4OENpQWdJQ0JrYVdjZ01nb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1XVUtJQ0FnSUQwOUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMM04wWVd0cGJtY3RZVzF2ZFc1MEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1USTNMVEV5T1FvZ0lDQWdMeThnY0dGeVlXMXpMblI1Y0dVZ1BUMDlJRk5VUVV0SlRrZGZWRmxRUlY5SVJVRlNWRUpGUVZRZ2ZId0tJQ0FnSUM4dklIQmhjbUZ0Y3k1MGVYQmxJRDA5UFNCVFZFRkxTVTVIWDFSWlVFVmZVMDlHVkNCOGZBb2dJQ0FnTHk4Z2NHRnlZVzF6TG5SNWNHVWdQVDA5SUZOVVFVdEpUa2RmVkZsUVJWOUlRVkpFSUh4OENpQWdJQ0JpYm5vZ2NtVm5hWE4wWlhKZlltOXZiRjkwY25WbFFERTNDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDNOMFlXdHBibWN0WVcxdmRXNTBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVE13Q2lBZ0lDQXZMeUJ3WVhKaGJYTXVkSGx3WlNBOVBUMGdVMVJCUzBsT1IxOVVXVkJGWDB4UFEwc3NDaUFnSUNCa2FXY2dNZ29nSUNBZ2NIVnphR0o1ZEdWeklEQjRNamdLSUNBZ0lEMDlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDNOMFlXdHBibWN0WVcxdmRXNTBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEkzTFRFek1Bb2dJQ0FnTHk4Z2NHRnlZVzF6TG5SNWNHVWdQVDA5SUZOVVFVdEpUa2RmVkZsUVJWOUlSVUZTVkVKRlFWUWdmSHdLSUNBZ0lDOHZJSEJoY21GdGN5NTBlWEJsSUQwOVBTQlRWRUZMU1U1SFgxUlpVRVZmVTA5R1ZDQjhmQW9nSUNBZ0x5OGdjR0Z5WVcxekxuUjVjR1VnUFQwOUlGTlVRVXRKVGtkZlZGbFFSVjlJUVZKRUlIeDhDaUFnSUNBdkx5QndZWEpoYlhNdWRIbHdaU0E5UFQwZ1UxUkJTMGxPUjE5VVdWQkZYMHhQUTBzc0NpQWdJQ0JpZWlCeVpXZHBjM1JsY2w5aWIyOXNYMlpoYkhObFFERTRDZ3B5WldkcGMzUmxjbDlpYjI5c1gzUnlkV1ZBTVRjNkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvS2NtVm5hWE4wWlhKZlltOXZiRjl0WlhKblpVQXhPVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmMzUmhhMmx1WnkxaGJXOTFiblF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TWpZdE1UTXlDaUFnSUNBdkx5QnNiMmRuWldSQmMzTmxjblFvQ2lBZ0lDQXZMeUFnSUhCaGNtRnRjeTUwZVhCbElEMDlQU0JUVkVGTFNVNUhYMVJaVUVWZlNFVkJVbFJDUlVGVUlIeDhDaUFnSUNBdkx5QWdJSEJoY21GdGN5NTBlWEJsSUQwOVBTQlRWRUZMU1U1SFgxUlpVRVZmVTA5R1ZDQjhmQW9nSUNBZ0x5OGdJQ0J3WVhKaGJYTXVkSGx3WlNBOVBUMGdVMVJCUzBsT1IxOVVXVkJGWDBoQlVrUWdmSHdLSUNBZ0lDOHZJQ0FnY0dGeVlXMXpMblI1Y0dVZ1BUMDlJRk5VUVV0SlRrZGZWRmxRUlY5TVQwTkxMQW9nSUNBZ0x5OGdJQ0JsY25KQ1lXUlBjR1Z5WVhScGIyNEtJQ0FnSUM4dklDa0tJQ0FnSUdKdWVpQnlaV2RwYzNSbGNsOWhablJsY2w5aGMzTmxjblJBTWpFS0lDQWdJR0o1ZEdWaklEZ2dMeThnSWtWU1VqcGxjbkpDYjNCeUlnb2dJQ0FnYkc5bkNpQWdJQ0JsY25JZ0x5OGdSVkpTT21WeWNrSnZjSElLQ25KbFoybHpkR1Z5WDJGbWRHVnlYMkZ6YzJWeWRFQXlNVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmMzUmhhMmx1WnkxaGJXOTFiblF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xTVFvZ0lDQWdMeThnWTI5dWMzUWdhV1FnUFNCMGFHbHpMbkpsWjJsemRISjVRM1Z5YzI5eUxuWmhiSFZsQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5emRHRnJhVzVuTFdGdGIzVnVkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak00Q2lBZ0lDQXZMeUJ5WldkcGMzUnllVU4xY25OdmNpQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvZXlCcGJtbDBhV0ZzVm1Gc2RXVTZJREVzSUd0bGVUb2dSMkYwWlVkc2IySmhiRk4wWVhSbFMyVjVVbVZuYVhOMGNubERkWEp6YjNJZ2ZTa0tJQ0FnSUdKNWRHVmpYeklnTHk4Z0luSmxaMmx6ZEhKNVgyTjFjbk52Y2lJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZjM1JoYTJsdVp5MWhiVzkxYm5RdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU1Rb2dJQ0FnTHk4Z1kyOXVjM1FnYVdRZ1BTQjBhR2x6TG5KbFoybHpkSEo1UTNWeWMyOXlMblpoYkhWbENpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXpkR0ZyYVc1bkxXRnRiM1Z1ZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVeUNpQWdJQ0F2THlCMGFHbHpMbkpsWjJsemRISjVRM1Z5YzI5eUxuWmhiSFZsSUNzOUlERUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQ3NLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmMzUmhhMmx1WnkxaGJXOTFiblF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96T0FvZ0lDQWdMeThnY21WbmFYTjBjbmxEZFhKemIzSWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0hzZ2FXNXBkR2xoYkZaaGJIVmxPaUF4TENCclpYazZJRWRoZEdWSGJHOWlZV3hUZEdGMFpVdGxlVkpsWjJsemRISjVRM1Z5YzI5eUlIMHBDaUFnSUNCaWVYUmxZMTh5SUM4dklDSnlaV2RwYzNSeWVWOWpkWEp6YjNJaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMM04wWVd0cGJtY3RZVzF2ZFc1MEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5USUtJQ0FnSUM4dklIUm9hWE11Y21WbmFYTjBjbmxEZFhKemIzSXVkbUZzZFdVZ0t6MGdNUW9nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmMzUmhhMmx1WnkxaGJXOTFiblF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TXpRS0lDQWdJQzh2SUhSb2FYTXVjbVZuYVhOMGNua29hV1FwTG5aaGJIVmxJRDBnWTJ4dmJtVW9jR0Z5WVcxektRb2dJQ0FnYVhSdllnb2dJQ0FnWkhWd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZjM1JoYTJsdVp5MWhiVzkxYm5RdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1UZ0tJQ0FnSUM4dklISmxaMmx6ZEdWeUtHMWljbEJoZVcxbGJuUTZJR2QwZUc0dVVHRjViV1Z1ZEZSNGJpd2dZWEpuY3pvZ1lubDBaWE1wT2lCMWFXNTBOalFnZXdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2NtVm5hWE4wWlhKZlltOXZiRjltWVd4elpVQXhPRG9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaUlISmxaMmx6ZEdWeVgySnZiMnhmYldWeVoyVkFNVGtLQ25KbFoybHpkR1Z5WDJKdmIyeGZabUZzYzJWQU1UQTZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWWlCeVpXZHBjM1JsY2w5aWIyOXNYMjFsY21kbFFERXhDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl6ZEdGcmFXNW5MV0Z0YjNWdWRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcFRkR0ZyYVc1blFXMXZkVzUwUjJGMFpTNWphR1ZqYTF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtTm9aV05yT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJaUlLSUNBZ0lHUjFjRzRnTWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXpkR0ZyYVc1bkxXRnRiM1Z1ZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFek9Bb2dJQ0FnTHk4Z1kyaGxZMnNvWTJGc2JHVnlPaUJCWTJOdmRXNTBMQ0J5WldkcGMzUnllVWxFT2lCMWFXNTBOalFzSUdGeVozTTZJR0o1ZEdWektUb2dZbTl2YkdWaGJpQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0F6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXpkR0ZyYVc1bkxXRnRiM1Z1ZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFek9Rb2dJQ0FnTHk4Z2JHOW5aMlZrUVhOelpYSjBLR0Z5WjNNdWJHVnVaM1JvSUQwOVBTQXdMQ0JsY25KSmJuWmhiR2xrUVhKblEyOTFiblFwQ2lBZ0lDQnNaVzRLSUNBZ0lHSjZJR05vWldOclgyRm1kR1Z5WDJGemMyVnlkRUF6Q2lBZ0lDQmllWFJsWXlBMklDOHZJQ0pGVWxJNlpYSnlTV0Z5WnlJS0lDQWdJR3h2WndvZ0lDQWdaWEp5SUM4dklFVlNVanBsY25KSllYSm5DZ3BqYUdWamExOWhablJsY2w5aGMzTmxjblJBTXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZjM1JoYTJsdVp5MWhiVzkxYm5RdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5EQUtJQ0FnSUM4dklHTnZibk4wSUhzZ2IzQXNJR0Z6YzJWMExDQmhiVzkxYm5Rc0lIUjVjR1VzSUdsdVkyeDFaR1ZGYzJOeWIzZGxaQ0I5SUQwZ1kyeHZibVVvZEdocGN5NXlaV2RwYzNSeWVTaHlaV2RwYzNSeWVVbEVLUzUyWVd4MVpTa0tJQ0FnSUdsMGIySUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QkNiM2dnYlhWemRDQm9ZWFpsSUhaaGJIVmxDaUFnSUNCa2RYQUtJQ0FnSUdWNGRISmhZM1FnTUNBeENpQWdJQ0J6ZDJGd0NpQWdJQ0JrZFhBS0lDQWdJR1Y0ZEhKaFkzUWdNU0E0Q2lBZ0lDQmlkWEo1SURjS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQXhNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR1IxY0FvZ0lDQWdaWGgwY21GamRDQTVJREVLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdZMjkyWlhJZ05Bb2dJQ0FnY0hWemFHbHVkQ0F4TkRRS0lDQWdJR2RsZEdKcGRBb2dJQ0FnYzNkaGNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl6ZEdGcmFXNW5MV0Z0YjNWdWRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWTFDaUFnSUNBdkx5QmpiMjV6ZENCaGNIQkpaQ0E5SUdkbGRFRnJhWFJoUVhCd1RHbHpkQ2gwYUdsekxtRnJhWFJoUkVGUExuWmhiSFZsS1M1emRHRnJhVzVuQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJKaGMyVXRZMjl1ZEhKaFkzUnpMM1Z3WjNKaFpHVmhZbXhsTG5Sek9qRTJDaUFnSUNBdkx5QmhhMmwwWVVSQlR5QTlJRWRzYjJKaGJGTjBZWFJsUEVGd2NHeHBZMkYwYVc5dVBpaDdJR3RsZVRvZ1IyeHZZbUZzVTNSaGRHVkxaWGxCYTJsMFlVUkJUeUI5S1FvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWVd0cGRHRmZaR0Z2SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXpkR0ZyYVc1bkxXRnRiM1Z1ZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZMUNpQWdJQ0F2THlCamIyNXpkQ0JoY0hCSlpDQTlJR2RsZEVGcmFYUmhRWEJ3VEdsemRDaDBhR2x6TG1GcmFYUmhSRUZQTG5aaGJIVmxLUzV6ZEdGcmFXNW5DaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMloxYm1OMGFXOXVjeTUwY3pveU1EWUtJQ0FnSUM4dklHTnZibk4wSUZ0aGNIQk1hWE4wUW5sMFpYTmRJRDBnYjNBdVFYQndSMnh2WW1Gc0xtZGxkRVY0UW5sMFpYTW9ZV3RwZEdGRVFVOHNJRUo1ZEdWektFRnJhWFJoUkVGUFIyeHZZbUZzVTNSaGRHVkxaWGx6UVd0cGRHRkJjSEJNYVhOMEtTa0tJQ0FnSUhCMWMyaGllWFJsY3lBaVlXRnNJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJSEJ2Y0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXpkR0ZyYVc1bkxXRnRiM1Z1ZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZMUNpQWdJQ0F2THlCamIyNXpkQ0JoY0hCSlpDQTlJR2RsZEVGcmFYUmhRWEJ3VEdsemRDaDBhR2x6TG1GcmFYUmhSRUZQTG5aaGJIVmxLUzV6ZEdGcmFXNW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdKMWNua2dPUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5emRHRnJhVzVuTFdGdGIzVnVkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalkzQ2lBZ0lDQXZMeUJwWmlBb2RIbHdaU0E5UFQwZ1UxUkJTMGxPUjE5VVdWQkZYMGhGUVZKVVFrVkJWQ2tnZXdvZ0lDQWdZbmwwWldNZ05DQXZMeUF3ZURCaENpQWdJQ0E5UFFvZ0lDQWdZbm9nWTJobFkydGZaV3h6WlY5aWIyUjVRRFlLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnY0c5d0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMM04wWVd0cGJtY3RZVzF2ZFc1MEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5qZ3ROekVLSUNBZ0lDOHZJSE4wWVd0bFpDQTlJR0ZpYVVOaGJHdzhkSGx3Wlc5bUlGTjBZV3RwYm1jdWNISnZkRzkwZVhCbExtZGxkRWhsWVhKMFltVmhkRUYyWlhKaFoyVStLSHNLSUNBZ0lDOHZJQ0FnWVhCd1NXUXNDaUFnSUNBdkx5QWdJR0Z5WjNNNklGdDFjMlZ5TENCaGMzTmxkQ3dnYVc1amJIVmtaVVZ6WTNKdmQyVmtYU3dLSUNBZ0lDOHZJSDBwTG5KbGRIVnlibFpoYkhWbENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwzTjBZV3RwYm1jdFlXMXZkVzUwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnpBS0lDQWdJQzh2SUdGeVozTTZJRnQxYzJWeUxDQmhjM05sZEN3Z2FXNWpiSFZrWlVWelkzSnZkMlZrWFN3S0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCelpYUmlhWFFLSUNBZ0lHUnBaeUEyQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZjM1JoYTJsdVp5MWhiVzkxYm5RdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk9DMDNNUW9nSUNBZ0x5OGdjM1JoYTJWa0lEMGdZV0pwUTJGc2JEeDBlWEJsYjJZZ1UzUmhhMmx1Wnk1d2NtOTBiM1I1Y0dVdVoyVjBTR1ZoY25SaVpXRjBRWFpsY21GblpUNG9ld29nSUNBZ0x5OGdJQ0JoY0hCSlpDd0tJQ0FnSUM4dklDQWdZWEpuY3pvZ1czVnpaWElzSUdGemMyVjBMQ0JwYm1Oc2RXUmxSWE5qY205M1pXUmRMQW9nSUNBZ0x5OGdmU2t1Y21WMGRYSnVWbUZzZFdVS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZUdNMlptUXdZMkUxSUM4dklHMWxkR2h2WkNBaVoyVjBTR1ZoY25SaVpXRjBRWFpsY21GblpTaGhaR1J5WlhOekxIVnBiblEyTkN4aWIyOXNLWFZwYm5RMk5DSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQmthV2NnTXdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdScFp5QTNDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUhCMWMyaHBiblFnTmlBdkx5QmhjSEJzQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0JwZEhodUlFeGhjM1JNYjJjS0lDQWdJR1IxY0FvZ0lDQWdaWGgwY21GamRDQTBJREFLSUNBZ0lITjNZWEFLSUNBZ0lHVjRkSEpoWTNRZ01DQTBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnUW5sMFpYTWdhR0Z6SUhaaGJHbGtJSEJ5WldacGVBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQjFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJR0oxY25rZ05Bb0tZMmhsWTJ0ZllXWjBaWEpmYVdaZlpXeHpaVUF4TWpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZjM1JoYTJsdVp5MWhiVzkxYm5RdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNU5Bb2dJQ0FnTHk4Z1kyRnpaU0JGY1hWaGJEb2djbVYwZFhKdUlITjBZV3RsWkNBOVBUMGdZVzF2ZFc1MENpQWdJQ0JrZFhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZjM1JoYTJsdVp5MWhiVzkxYm5RdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk53b2dJQ0FnTHk4Z2FXWWdLSFI1Y0dVZ1BUMDlJRk5VUVV0SlRrZGZWRmxRUlY5SVJVRlNWRUpGUVZRcElIc0tJQ0FnSUdKNWRHVmpJRFFnTHk4Z01IZ3dZUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5emRHRnJhVzVuTFdGdGIzVnVkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamswQ2lBZ0lDQXZMeUJqWVhObElFVnhkV0ZzT2lCeVpYUjFjbTRnYzNSaGEyVmtJRDA5UFNCaGJXOTFiblFLSUNBZ0lEMDlDaUFnSUNCaWVpQmphR1ZqYTE5aFpuUmxjbDlwWmw5bGJITmxRREUwQ2lBZ0lDQndiM0FLSUNBZ0lHUnBaeUF5Q2lBZ0lDQTlQUW9LWTJobFkydGZZV1owWlhKZmFXNXNhVzVsWkY5emJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMM04wWVd0cGJtY3RZVzF2ZFc1MEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9sTjBZV3RwYm1kQmJXOTFiblJIWVhSbExuTjBZV3RwYm1kQmJXOTFiblJIWVhSbFFESTFPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5emRHRnJhVzVuTFdGdGIzVnVkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV6T0FvZ0lDQWdMeThnWTJobFkyc29ZMkZzYkdWeU9pQkJZMk52ZFc1MExDQnlaV2RwYzNSeWVVbEVPaUIxYVc1ME5qUXNJR0Z5WjNNNklHSjVkR1Z6S1RvZ1ltOXZiR1ZoYmlCN0NpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVjBZbWwwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwamFHVmphMTloWm5SbGNsOXBabDlsYkhObFFERTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5emRHRnJhVzVuTFdGdGIzVnVkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamsxQ2lBZ0lDQXZMeUJqWVhObElFNXZkRVZ4ZFdGc09pQnlaWFIxY200Z2MzUmhhMlZrSUNFOVBTQmhiVzkxYm5RS0lDQWdJR1IxY0FvZ0lDQWdZbmwwWldNZ05TQXZMeUF3ZURFMENpQWdJQ0E5UFFvZ0lDQWdZbm9nWTJobFkydGZZV1owWlhKZmFXWmZaV3h6WlVBeE5nb2dJQ0FnY0c5d0NpQWdJQ0JrYVdjZ01nb2dJQ0FnSVQwS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZjM1JoYTJsdVp5MWhiVzkxYm5RdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5ERXRNVFE0Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdkR2hwY3k1emRHRnJhVzVuUVcxdmRXNTBSMkYwWlNnS0lDQWdJQzh2SUNBZ1kyRnNiR1Z5TEFvZ0lDQWdMeThnSUNCdmNDd0tJQ0FnSUM4dklDQWdZWE56WlhRc0NpQWdJQ0F2THlBZ0lHRnRiM1Z1ZEN3S0lDQWdJQzh2SUNBZ2RIbHdaU3dLSUNBZ0lDOHZJQ0FnYVc1amJIVmtaVVZ6WTNKdmQyVmtDaUFnSUNBdkx5QXBDaUFnSUNCaUlHTm9aV05yWDJGbWRHVnlYMmx1YkdsdVpXUmZjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5emRHRnJhVzVuTFdGdGIzVnVkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBUZEdGcmFXNW5RVzF2ZFc1MFIyRjBaUzV6ZEdGcmFXNW5RVzF2ZFc1MFIyRjBaVUF5TlFvS1kyaGxZMnRmWVdaMFpYSmZhV1pmWld4elpVQXhOam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmMzUmhhMmx1WnkxaGJXOTFiblF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem81TmdvZ0lDQWdMeThnWTJGelpTQk1aWE56VkdoaGJqb2djbVYwZFhKdUlITjBZV3RsWkNBOElHRnRiM1Z1ZEFvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd4WlFvZ0lDQWdQVDBLSUNBZ0lHSjZJR05vWldOclgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRnS0lDQWdJSEJ2Y0FvZ0lDQWdaR2xuSURJS0lDQWdJRDRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmMzUmhhMmx1WnkxaGJXOTFiblF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TkRFdE1UUTRDaUFnSUNBdkx5QnlaWFIxY200Z2RHaHBjeTV6ZEdGcmFXNW5RVzF2ZFc1MFIyRjBaU2dLSUNBZ0lDOHZJQ0FnWTJGc2JHVnlMQW9nSUNBZ0x5OGdJQ0J2Y0N3S0lDQWdJQzh2SUNBZ1lYTnpaWFFzQ2lBZ0lDQXZMeUFnSUdGdGIzVnVkQ3dLSUNBZ0lDOHZJQ0FnZEhsd1pTd0tJQ0FnSUM4dklDQWdhVzVqYkhWa1pVVnpZM0p2ZDJWa0NpQWdJQ0F2THlBcENpQWdJQ0JpSUdOb1pXTnJYMkZtZEdWeVgybHViR2x1WldSZmMyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl6ZEdGcmFXNW5MV0Z0YjNWdWRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcFRkR0ZyYVc1blFXMXZkVzUwUjJGMFpTNXpkR0ZyYVc1blFXMXZkVzUwUjJGMFpVQXlOUW9LWTJobFkydGZZV1owWlhKZmFXWmZaV3h6WlVBeE9Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12YzNSaGEybHVaeTFoYlc5MWJuUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzVOd29nSUNBZ0x5OGdZMkZ6WlNCTVpYTnpWR2hoYms5eVJYRjFZV3hVYnpvZ2NtVjBkWEp1SUhOMFlXdGxaQ0E4UFNCaGJXOTFiblFLSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNamdLSUNBZ0lEMDlDaUFnSUNCaWVpQmphR1ZqYTE5aFpuUmxjbDlwWmw5bGJITmxRREl3Q2lBZ0lDQndiM0FLSUNBZ0lHUnBaeUF5Q2lBZ0lDQStQUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5emRHRnJhVzVuTFdGdGIzVnVkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUwTVMweE5EZ0tJQ0FnSUM4dklISmxkSFZ5YmlCMGFHbHpMbk4wWVd0cGJtZEJiVzkxYm5SSFlYUmxLQW9nSUNBZ0x5OGdJQ0JqWVd4c1pYSXNDaUFnSUNBdkx5QWdJRzl3TEFvZ0lDQWdMeThnSUNCaGMzTmxkQ3dLSUNBZ0lDOHZJQ0FnWVcxdmRXNTBMQW9nSUNBZ0x5OGdJQ0IwZVhCbExBb2dJQ0FnTHk4Z0lDQnBibU5zZFdSbFJYTmpjbTkzWldRS0lDQWdJQzh2SUNrS0lDQWdJR0lnWTJobFkydGZZV1owWlhKZmFXNXNhVzVsWkY5emJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMM04wWVd0cGJtY3RZVzF2ZFc1MEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9sTjBZV3RwYm1kQmJXOTFiblJIWVhSbExuTjBZV3RwYm1kQmJXOTFiblJIWVhSbFFESTFDZ3BqYUdWamExOWhablJsY2w5cFpsOWxiSE5sUURJd09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl6ZEdGcmFXNW5MV0Z0YjNWdWRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qazRDaUFnSUNBdkx5QmpZWE5sSUVkeVpXRjBaWEpVYUdGdU9pQnlaWFIxY200Z2MzUmhhMlZrSUQ0Z1lXMXZkVzUwQ2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRE15Q2lBZ0lDQTlQUW9nSUNBZ1lub2dZMmhsWTJ0ZllXWjBaWEpmYVdaZlpXeHpaVUF5TWdvZ0lDQWdjRzl3Q2lBZ0lDQmthV2NnTWdvZ0lDQWdQQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5emRHRnJhVzVuTFdGdGIzVnVkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUwTVMweE5EZ0tJQ0FnSUM4dklISmxkSFZ5YmlCMGFHbHpMbk4wWVd0cGJtZEJiVzkxYm5SSFlYUmxLQW9nSUNBZ0x5OGdJQ0JqWVd4c1pYSXNDaUFnSUNBdkx5QWdJRzl3TEFvZ0lDQWdMeThnSUNCaGMzTmxkQ3dLSUNBZ0lDOHZJQ0FnWVcxdmRXNTBMQW9nSUNBZ0x5OGdJQ0IwZVhCbExBb2dJQ0FnTHk4Z0lDQnBibU5zZFdSbFJYTmpjbTkzWldRS0lDQWdJQzh2SUNrS0lDQWdJR0lnWTJobFkydGZZV1owWlhKZmFXNXNhVzVsWkY5emJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMM04wWVd0cGJtY3RZVzF2ZFc1MEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9sTjBZV3RwYm1kQmJXOTFiblJIWVhSbExuTjBZV3RwYm1kQmJXOTFiblJIWVhSbFFESTFDZ3BqYUdWamExOWhablJsY2w5cFpsOWxiSE5sUURJeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl6ZEdGcmFXNW5MV0Z0YjNWdWRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qazVDaUFnSUNBdkx5QmpZWE5sSUVkeVpXRjBaWEpVYUdGdVQzSkZjWFZoYkZSdk9pQnlaWFIxY200Z2MzUmhhMlZrSUQ0OUlHRnRiM1Z1ZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TTJNS0lDQWdJRDA5Q2lBZ0lDQmllaUJqYUdWamExOWhablJsY2w5cFpsOWxiSE5sUURJMENpQWdJQ0JrYVdjZ01nb2dJQ0FnUEQwS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZjM1JoYTJsdVp5MWhiVzkxYm5RdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5ERXRNVFE0Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdkR2hwY3k1emRHRnJhVzVuUVcxdmRXNTBSMkYwWlNnS0lDQWdJQzh2SUNBZ1kyRnNiR1Z5TEFvZ0lDQWdMeThnSUNCdmNDd0tJQ0FnSUM4dklDQWdZWE56WlhRc0NpQWdJQ0F2THlBZ0lHRnRiM1Z1ZEN3S0lDQWdJQzh2SUNBZ2RIbHdaU3dLSUNBZ0lDOHZJQ0FnYVc1amJIVmtaVVZ6WTNKdmQyVmtDaUFnSUNBdkx5QXBDaUFnSUNCaUlHTm9aV05yWDJGbWRHVnlYMmx1YkdsdVpXUmZjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5emRHRnJhVzVuTFdGdGIzVnVkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBUZEdGcmFXNW5RVzF2ZFc1MFIyRjBaUzV6ZEdGcmFXNW5RVzF2ZFc1MFIyRjBaVUF5TlFvS1kyaGxZMnRmWVdaMFpYSmZhV1pmWld4elpVQXlORG9LSUNBZ0lIQnZjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5emRHRnJhVzVuTFdGdGIzVnVkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV3TUFvZ0lDQWdMeThnWkdWbVlYVnNkRG9nY21WMGRYSnVJR1poYkhObENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXpkR0ZyYVc1bkxXRnRiM1Z1ZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFME1TMHhORGdLSUNBZ0lDOHZJSEpsZEhWeWJpQjBhR2x6TG5OMFlXdHBibWRCYlc5MWJuUkhZWFJsS0FvZ0lDQWdMeThnSUNCallXeHNaWElzQ2lBZ0lDQXZMeUFnSUc5d0xBb2dJQ0FnTHk4Z0lDQmhjM05sZEN3S0lDQWdJQzh2SUNBZ1lXMXZkVzUwTEFvZ0lDQWdMeThnSUNCMGVYQmxMQW9nSUNBZ0x5OGdJQ0JwYm1Oc2RXUmxSWE5qY205M1pXUUtJQ0FnSUM4dklDa0tJQ0FnSUdJZ1kyaGxZMnRmWVdaMFpYSmZhVzVzYVc1bFpGOXpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDNOMFlXdHBibWN0WVcxdmRXNTBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPbE4wWVd0cGJtZEJiVzkxYm5SSFlYUmxMbk4wWVd0cGJtZEJiVzkxYm5SSFlYUmxRREkxQ2dwamFHVmphMTlsYkhObFgySnZaSGxBTmpvS0lDQWdJSEJ2Y0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXpkR0ZyYVc1bkxXRnRiM1Z1ZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pjMExUYzNDaUFnSUNBdkx5QmpiMjV6ZENCcGJtWnZJRDBnWVdKcFEyRnNiRHgwZVhCbGIyWWdVM1JoYTJsdVp5NXdjbTkwYjNSNWNHVXVaMlYwU1c1bWJ6NG9ld29nSUNBZ0x5OGdJQ0JoY0hCSlpDd0tJQ0FnSUM4dklDQWdZWEpuY3pvZ1czVnpaWElzSUhzZ1lYTnpaWFFzSUhSNWNHVWdmVjBzQ2lBZ0lDQXZMeUI5S1M1eVpYUjFjbTVXWVd4MVpRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXpkR0ZyYVc1bkxXRnRiM1Z1ZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pjMkNpQWdJQ0F2THlCaGNtZHpPaUJiZFhObGNpd2dleUJoYzNObGRDd2dkSGx3WlNCOVhTd0tJQ0FnSUdScFp5QTNDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dOd29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwzTjBZV3RwYm1jdFlXMXZkVzUwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnpRdE56Y0tJQ0FnSUM4dklHTnZibk4wSUdsdVptOGdQU0JoWW1sRFlXeHNQSFI1Y0dWdlppQlRkR0ZyYVc1bkxuQnliM1J2ZEhsd1pTNW5aWFJKYm1adlBpaDdDaUFnSUNBdkx5QWdJR0Z3Y0Vsa0xBb2dJQ0FnTHk4Z0lDQmhjbWR6T2lCYmRYTmxjaXdnZXlCaGMzTmxkQ3dnZEhsd1pTQjlYU3dLSUNBZ0lDOHZJSDBwTG5KbGRIVnlibFpoYkhWbENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhoa05EQXhOakpoWmlBdkx5QnRaWFJvYjJRZ0ltZGxkRWx1Wm04b1lXUmtjbVZ6Y3l3b2RXbHVkRFkwTEhWcGJuUTRLU2tvZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwS1NJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCa2FXY2dOQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCd2RYTm9hVzUwSURZZ0x5OGdZWEJ3YkFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnYVhSNGJpQk1ZWE4wVEc5bkNpQWdJQ0JrZFhBS0lDQWdJR1Y0ZEhKaFkzUWdOQ0F3Q2lBZ0lDQmthV2NnTVFvZ0lDQWdaWGgwY21GamRDQXdJRFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCQ2VYUmxjeUJvWVhNZ2RtRnNhV1FnY0hKbFptbDRDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkR0ZyYVc1bkwzUjVjR1Z6TG5Sek9qcFRkR0ZyWlFvZ0lDQWdjSFZ6YUdsdWRDQTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDNOMFlXdHBibWN0WVcxdmRXNTBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOemtLSUNBZ0lDOHZJSE4wWVd0bFpDQTlJR2x1Wm04dVlXMXZkVzUwQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdZblZ5ZVNBMUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMM04wWVd0cGJtY3RZVzF2ZFc1MEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9ESUtJQ0FnSUM4dklHbG1JQ2gwZVhCbElEMDlQU0JUVkVGTFNVNUhYMVJaVUVWZlUwOUdWQ0FtSmlCemRHRnJaV1FnUGlBd0tTQjdDaUFnSUNCaWVYUmxZeUExSUM4dklEQjRNVFFLSUNBZ0lEMDlDaUFnSUNCaWVpQmphR1ZqYTE5aFpuUmxjbDlwWmw5bGJITmxRREV5Q2lBZ0lDQmthV2NnTXdvZ0lDQWdZbm9nWTJobFkydGZZV1owWlhKZmFXWmZaV3h6WlVBeE1nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl6ZEdGcmFXNW5MV0Z0YjNWdWRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qZ3pMVGcyQ2lBZ0lDQXZMeUJqYjI1emRDQjdJR0poYkdGdVkyVWdmU0E5SUdGaWFVTmhiR3c4ZEhsd1pXOW1JRk4wWVd0cGJtY3VjSEp2ZEc5MGVYQmxMbk52Wm5SRGFHVmphejRvZXdvZ0lDQWdMeThnSUNCaGNIQkpaQ3dLSUNBZ0lDOHZJQ0FnWVhKbmN6b2dXM1Z6WlhJc0lHRnpjMlYwWFN3S0lDQWdJQzh2SUgwcExuSmxkSFZ5YmxaaGJIVmxDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0JrYVdjZ05Rb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzBPRGN4Tm1ZeFlTQXZMeUJ0WlhSb2IyUWdJbk52Wm5SRGFHVmpheWhoWkdSeVpYTnpMSFZwYm5RMk5Da29ZbTl2YkN4MWFXNTBOalFwSWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdScFp5QXlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdaR2xuSURZS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCd2RYTm9hVzUwSURZZ0x5OGdZWEJ3YkFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnYVhSNGJpQk1ZWE4wVEc5bkNpQWdJQ0JrZFhBS0lDQWdJR1Y0ZEhKaFkzUWdOQ0F3Q2lBZ0lDQmthV2NnTVFvZ0lDQWdaWGgwY21GamRDQXdJRFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCQ2VYUmxjeUJvWVhNZ2RtRnNhV1FnY0hKbFptbDRDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnT1FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBZV3RwYm1jdmRIbHdaWE11ZEhNNk9sTjBZV3RsUTJobFkyc0tJQ0FnSUhCMWMyaHBiblFnTlFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBMkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMM04wWVd0cGJtY3RZVzF2ZFc1MEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9EY0tJQ0FnSUM4dklHbG1JQ2hpWVd4aGJtTmxJRHdnYzNSaGEyVmtLU0I3Q2lBZ0lDQmthV2NnTkFvZ0lDQWdQQW9nSUNBZ1lub2dZMmhsWTJ0ZllXWjBaWEpmYVdaZlpXeHpaVUF4TWdvZ0lDQWdaR2xuSURRS0lDQWdJR0oxY25rZ05Bb2dJQ0FnWWlCamFHVmphMTloWm5SbGNsOXBabDlsYkhObFFERXlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl6ZEdGcmFXNW5MV0Z0YjNWdWRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcFRkR0ZyYVc1blFXMXZkVzUwUjJGMFpTNW5aWFJTWldkcGMzUnlZWFJwYjI1VGFHRndaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21kbGRGSmxaMmx6ZEhKaGRHbHZibE5vWVhCbE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl6ZEdGcmFXNW5MV0Z0YjNWdWRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTFNUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUhKbFlXUnZibXg1T2lCMGNuVmxJSDBwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBeE9Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXpkR0ZyYVc1bkxXRnRiM1Z1ZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwVGRHRnJhVzVuUVcxdmRXNTBSMkYwWlZKbFoybHpkSEo1U1c1bWJ3b2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZjM1JoYTJsdVp5MWhiVzkxYm5RdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlUzUmhhMmx1WjBGdGIzVnVkRWRoZEdVdVoyVjBSVzUwY25sYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncG5aWFJGYm5SeWVUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12YzNSaGEybHVaeTFoYlc5MWJuUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOVFlLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU0I5S1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl6ZEdGcmFXNW5MV0Z0YjNWdWRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTFPQW9nSUNBZ0x5OGdjbVYwZFhKdUlHVnVZMjlrWlVGeVl6UW9kR2hwY3k1eVpXZHBjM1J5ZVNoeVpXZHBjM1J5ZVVsRUtTNTJZV3gxWlNrS0lDQWdJR2wwYjJJS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdGemMyVnlkQ0F2THlCQ2IzZ2diWFZ6ZENCb1lYWmxJSFpoYkhWbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMM04wWVd0cGJtY3RZVzF2ZFc1MEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UVTJDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnY21WaFpHOXViSGs2SUhSeWRXVWdmU2tLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMkpoYzJVdFkyOXVkSEpoWTNSekwzVndaM0poWkdWaFlteGxMblJ6T2pwQmEybDBZVUpoYzJWRGIyNTBjbUZqZEM1MWNHUmhkR1ZCYTJsMFlVUkJUMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25Wd1pHRjBaVUZyYVhSaFJFRlBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJKaGMyVXRZMjl1ZEhKaFkzUnpMM1Z3WjNKaFpHVmhZbXhsTG5Sek9qSTFDaUFnSUNBdkx5QjFjR1JoZEdWQmEybDBZVVJCVHloaGEybDBZVVJCVHpvZ1FYQndiR2xqWVhScGIyNHBPaUIyYjJsa0lIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5aVlYTmxMV052Ym5SeVlXTjBjeTkxY0dkeVlXUmxZV0pzWlM1MGN6b3lOZ29nSUNBZ0x5OGdiRzluWjJWa1FYTnpaWEowS0ZSNGJpNXpaVzVrWlhJZ1BUMDlJSFJvYVhNdVoyVjBRV3RwZEdGRVFVOVhZV3hzWlhRb0tTNWhaR1J5WlhOekxDQmxjbkpPYjNSQmEybDBZVVJoYnlrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5aVlYTmxMV052Ym5SeVlXTjBjeTkxY0dkeVlXUmxZV0pzWlM1MGN6b3hPUW9nSUNBZ0x5OGdZMjl1YzNRZ1czZGhiR3hsZEVsRVhTQTlJRzl3TGtGd2NFZHNiMkpoYkM1blpYUkZlRlZwYm5RMk5DaDBhR2x6TG1GcmFYUmhSRUZQTG5aaGJIVmxMQ0JDZVhSbGN5aEJhMmwwWVVSQlQwZHNiMkpoYkZOMFlYUmxTMlY1YzFkaGJHeGxkQ2twQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJKaGMyVXRZMjl1ZEhKaFkzUnpMM1Z3WjNKaFpHVmhZbXhsTG5Sek9qRTJDaUFnSUNBdkx5QmhhMmwwWVVSQlR5QTlJRWRzYjJKaGJGTjBZWFJsUEVGd2NHeHBZMkYwYVc5dVBpaDdJR3RsZVRvZ1IyeHZZbUZzVTNSaGRHVkxaWGxCYTJsMFlVUkJUeUI5S1FvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWVd0cGRHRmZaR0Z2SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwySmhjMlV0WTI5dWRISmhZM1J6TDNWd1ozSmhaR1ZoWW14bExuUnpPakU1Q2lBZ0lDQXZMeUJqYjI1emRDQmJkMkZzYkdWMFNVUmRJRDBnYjNBdVFYQndSMnh2WW1Gc0xtZGxkRVY0VldsdWREWTBLSFJvYVhNdVlXdHBkR0ZFUVU4dWRtRnNkV1VzSUVKNWRHVnpLRUZyYVhSaFJFRlBSMnh2WW1Gc1UzUmhkR1ZMWlhselYyRnNiR1YwS1NrS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQndkWE5vWW5sMFpYTWdJbmRoYkd4bGRDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQndiM0FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5aVlYTmxMV052Ym5SeVlXTjBjeTkxY0dkeVlXUmxZV0pzWlM1MGN6b3lOZ29nSUNBZ0x5OGdiRzluWjJWa1FYTnpaWEowS0ZSNGJpNXpaVzVrWlhJZ1BUMDlJSFJvYVhNdVoyVjBRV3RwZEdGRVFVOVhZV3hzWlhRb0tTNWhaR1J5WlhOekxDQmxjbkpPYjNSQmEybDBZVVJoYnlrS0lDQWdJR0Z3Y0Y5d1lYSmhiWE5mWjJWMElFRndjRUZrWkhKbGMzTUtJQ0FnSUdGemMyVnlkQ0F2THlCaGNIQnNhV05oZEdsdmJpQmxlR2x6ZEhNS0lDQWdJRDA5Q2lBZ0lDQmlibm9nZFhCa1lYUmxRV3RwZEdGRVFVOWZZV1owWlhKZllYTnpaWEowUURNS0lDQWdJSEIxYzJoaWVYUmxjeUFpUlZKU09tVnljazVrWVc4aUNpQWdJQ0JzYjJjS0lDQWdJR1Z5Y2lBdkx5QkZVbEk2WlhKeVRtUmhid29LZFhCa1lYUmxRV3RwZEdGRVFVOWZZV1owWlhKZllYTnpaWEowUURNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZZbUZ6WlMxamIyNTBjbUZqZEhNdmRYQm5jbUZrWldGaWJHVXVkSE02TVRZS0lDQWdJQzh2SUdGcmFYUmhSRUZQSUQwZ1IyeHZZbUZzVTNSaGRHVThRWEJ3YkdsallYUnBiMjQrS0hzZ2EyVjVPaUJIYkc5aVlXeFRkR0YwWlV0bGVVRnJhWFJoUkVGUElIMHBDaUFnSUNCaWVYUmxZMTh4SUM4dklDSmhhMmwwWVY5a1lXOGlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12WW1GelpTMWpiMjUwY21GamRITXZkWEJuY21Ga1pXRmliR1V1ZEhNNk1qY0tJQ0FnSUM4dklIUm9hWE11WVd0cGRHRkVRVTh1ZG1Gc2RXVWdQU0JoYTJsMFlVUkJUd29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5aVlYTmxMV052Ym5SeVlXTjBjeTkxY0dkeVlXUmxZV0pzWlM1MGN6b3lOUW9nSUNBZ0x5OGdkWEJrWVhSbFFXdHBkR0ZFUVU4b1lXdHBkR0ZFUVU4NklFRndjR3hwWTJGMGFXOXVLVG9nZG05cFpDQjdDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERUtJQ0FnSUhKbGRIVnliZ289In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFBRUNDQ1lKQkJVZmZIVUpZV3RwZEdGZlpHRnZEM0psWjJsemRISjVYMk4xY25OdmNnQUJDZ0VVQzBWU1VqcGxjbkpKWVhKbkMwVlNVanBsY25KSmNHRjVDMFZTVWpwbGNuSkNiM0J5TVJoQUFFa3FJMmVDQWhKeVpXZHBjM1J5WVhScGIyNWZjMmhoY0dVZ0tIVnBiblE0TEhWcGJuUTJOQ3gxYVc1ME9DeDFhVzUwTmpRc1ltOXZiQ2xuZ0F0amFHVmphMTl6YUdGd1pTdG5NUmtVUkRFWVFRQTdnZ2NFTXA4RTdnUjN1M201Qkc0RDlRb0VOU1NaRkFTUTFQcGRCRFBwTEpRRWhVM3Q0RFlhQUk0SEFEc0FXQUVIQXBrQ3FBTENBQUVBSTBPQUJNMmExbjQyR2dDT0FRQUJBRFlhQVVraVdTUUlTd0VWRWtSWEFnQTJHZ0pKRlNVU1JCZUFCM1psY25OcGIyNVBBbWNwVEdjalF6WWFBVWtpV1NRSVRCVVNSSUFNRlI5OGRRQUFBQUFBQURQMHNDTkRJaXN4RmlNSlNUZ1FJeEpFTmhvQlJ3SWlXU1FJU3dFVkVrUlhBZ0JKRllFVEVrQUFCQ2NHc0FCTEFqZ0hNZ29TUUFBRUp3ZXdBRThDT0FpQjlHY1NRQUFFSndld0FFc0JKRlZKUlFTQkNnOUJBRmhMQW9FOERrRUFVQ05BQUFRbkNMQUFURmNMQVVsRkJDY0VFa0FBR2tzQ0p3VVNRQUFTU3dLQUFSNFNRQUFKU3dLQUFTZ1NRUUFkSTBBQUJDY0lzQUFpS21WRVNTTUlLa3huRmtsUEFyOG9URkN3STBNaVF2L2dJa0wvclNJclJ3STJHZ0ZKRllFZ0VrUTJHZ0pKRlNVU1JCYzJHZ05KSWxra0NFc0JGUkpFVndJQUZVRUFCQ2NHc0FBV3ZrUkpWd0FCVEVsWEFRaEZCMG1CQ2x0T0FrbFhDUUZKVGdKT0JJR1FBVk5NSWlsbFJJQURZV0ZzWlVnaVcwVUpKd1FTUVFDalR3TklzWUFCQUNKUEFsUkxCcklZZ0FURy9ReWxzaHBMQTdJYVN3ZXlHcklhZ1FheUVDS3lBYk8wUGtsWEJBQk1Wd0FFS0JKRVNSVWxFa1FYUlFSSkp3UVNRUUFSU0VzQ0VvQUJBQ0pQQWxRb1RGQ3dJME5KSndVU1FRQUhTRXNDRTBMLzVVbUFBUjRTUVFBSFNFc0NEVUwvMWttQUFTZ1NRUUFIU0VzQ0QwTC94MG1BQVRJU1FRQUhTRXNDREVML3VJQUJQQkpCQUFaTEFnNUMvNnRJSWtML3BraXhTd2RQQTBsT0FsQkxCN0lZZ0FUVUFXS3ZzaHBMQkxJYXNocUJCcklRSXJJQnM3UStTVmNFQUVzQlZ3QUVLQkpFRllFZ0VrU0JCRnRGQlNjRkVrSC9XVXNEUWY5VXNVc0ZzaGlBQkVoeGJ4cXlHa3NDc2hwTEJySWFnUWF5RUNLeUFiTzBQa2xYQkFCTEFWY0FCQ2dTUkJXQkNSSkVnUVZiU1VVR1N3UU1RZjhZU3dSRkJFTC9FVFlhQVVrVmdSTVNSQ2hNVUxBalF6WWFBVWtWSlJKRUZ4YStSRWtWRmxjR0FreFFLRXhRc0NORE5ob0JTUlVsRWtRWE1RQWlLV1ZFZ0FaM1lXeHNaWFJsU0hJSVJCSkFBQStBQzBWU1VqcGxjbkpPWkdGdnNBQXBUR2NqUXc9PSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjEwLCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
