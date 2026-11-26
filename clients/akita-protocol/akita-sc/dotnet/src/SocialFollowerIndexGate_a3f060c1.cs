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

namespace Arc56.Generated.akita_protocol.akita_sc.SocialFollowerIndexGate_a3f060c1
{


    public class SocialFollowerIndexGateProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public SocialFollowerIndexGateProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class SocialFollowerIndexGateRegistryInfo : AVMObjectType
            {
                public Algorand.Address User { get; set; }

                public byte Op { get; set; }

                public ulong Value { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUser = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vUser.From(User);
                    ret.AddRange(vUser.Encode());
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

                public static SocialFollowerIndexGateRegistryInfo Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new SocialFollowerIndexGateRegistryInfo();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUser = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vUser.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueUser = vUser.ToValue();
                    if (valueUser is Algorand.Address vUserValue) { ret.User = vUserValue; }
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
                    return Equals(obj as SocialFollowerIndexGateRegistryInfo);
                }
                public bool Equals(SocialFollowerIndexGateRegistryInfo? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(SocialFollowerIndexGateRegistryInfo left, SocialFollowerIndexGateRegistryInfo right)
                {
                    return EqualityComparer<SocialFollowerIndexGateRegistryInfo>.Default.Equals(left, right);
                }
                public static bool operator !=(SocialFollowerIndexGateRegistryInfo left, SocialFollowerIndexGateRegistryInfo right)
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
        /// <param name="shape"> SocialFollowerIndexGateRegistryInfo</param>
        public async Task<Structs.SocialFollowerIndexGateRegistryInfo> GetRegistrationShape(Structs.SocialFollowerIndexGateRegistryInfo shape, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 77, 235, 134, 21 };

            var result = await base.CallApp(new List<object> { abiHandle, shape }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.SocialFollowerIndexGateRegistryInfo.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetRegistrationShape_Transactions(Structs.SocialFollowerIndexGateRegistryInfo shape, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 77, 235, 134, 21 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU29jaWFsRm9sbG93ZXJJbmRleEdhdGUiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiU29jaWFsRm9sbG93ZXJJbmRleEdhdGVSZWdpc3RyeUluZm8iOlt7Im5hbWUiOiJ1c2VyIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJvcCIsInR5cGUiOiJ1aW50OCJ9LHsibmFtZSI6InZhbHVlIiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidmVyc2lvbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWtpdGFEQU8iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY29zdCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcmdzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVnaXN0ZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWJyUGF5bWVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXJncyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNoZWNrIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjYWxsZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlZ2lzdHJ5SUQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFyZ3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0UmVnaXN0cmF0aW9uU2hhcGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKGFkZHJlc3MsdWludDgsdWludDY0KSIsInN0cnVjdCI6IlNvY2lhbEZvbGxvd2VySW5kZXhHYXRlUmVnaXN0cnlJbmZvIiwibmFtZSI6InNoYXBlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6IihhZGRyZXNzLHVpbnQ4LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJTb2NpYWxGb2xsb3dlckluZGV4R2F0ZVJlZ2lzdHJ5SW5mbyIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldEVudHJ5IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlZ2lzdHJ5SUQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InVwZGF0ZUFraXRhREFPIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFraXRhREFPIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im9wVXAiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjIsImJ5dGVzIjozfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls0MDcsNjcyXSwiZXJyb3JNZXNzYWdlIjoiQm94IG11c3QgaGF2ZSB2YWx1ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ4MCw1NDZdLCJlcnJvck1lc3NhZ2UiOiJCeXRlcyBoYXMgdmFsaWQgcHJlZml4IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzI1XSwiZXJyb3JNZXNzYWdlIjoiRVJSOmVycklhcmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMzgsMzUyXSwiZXJyb3JNZXNzYWdlIjoiRVJSOmVycklwYXkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3MzNdLCJlcnJvck1lc3NhZ2UiOiJFUlI6ZXJyTmRhbyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzcxNF0sImVycm9yTWVzc2FnZSI6ImFwcGxpY2F0aW9uIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM1Niw0MzEsNzAxXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgR2xvYmFsU3RhdGUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjA4LDI1MywyOTIsMzk4XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjE1LDI1OSwyOTksNDA0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM4M10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMjYsMzkxLDY2OCw2OTRdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0ODVdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYm9vbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY1NF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBzbWFydF9jb250cmFjdHMvZ2F0ZXMvc3ViLWdhdGVzL3NvY2lhbC1mb2xsb3dlci1pbmRleC9jb250cmFjdC5hbGdvLnRzOjpTb2NpYWxGb2xsb3dlckluZGV4R2F0ZVJlZ2lzdHJ5SW5mbyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU1MV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciB1aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyODZdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIHBheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTVNBd0lEZ2dNZ29nSUNBZ1lubDBaV05pYkc5amF5QXdlREUxTVdZM1l6YzFJQ0p5WldkcGMzUnllVjlqZFhKemIzSWlJQ0poYTJsMFlWOWtZVzhpSUNKRlVsSTZaWEp5U1hCaGVTSUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmlibm9nYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZjMjlqYVdGc0xXWnZiR3h2ZDJWeUxXbHVaR1Y0TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpRS0lDQWdJQzh2SUhKbFoybHpkSEo1UTNWeWMyOXlJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGloN0lHbHVhWFJwWVd4V1lXeDFaVG9nTVN3Z2EyVjVPaUJIWVhSbFIyeHZZbUZzVTNSaGRHVkxaWGxTWldkcGMzUnllVU4xY25OdmNpQjlLUW9nSUNBZ1lubDBaV05mTVNBdkx5QWljbVZuYVhOMGNubGZZM1Z5YzI5eUlnb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMM052WTJsaGJDMW1iMnhzYjNkbGNpMXBibVJsZUM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNMkNpQWdJQ0F2THlCeVpXZHBjM1J5WVhScGIyNVRhR0Z3WlNBOUlFZHNiMkpoYkZOMFlYUmxQSE4wY21sdVp6NG9leUJwYm1sMGFXRnNWbUZzZFdVNklDY29ZV1JrY21WemN5eDFhVzUwT0N4MWFXNTBOalFwSnl3Z2EyVjVPaUJIWVhSbFIyeHZZbUZzVTNSaGRHVkxaWGxTWldkcGMzUnlZWFJwYjI1VGFHRndaU0I5S1FvZ0lDQWdjSFZ6YUdKNWRHVnpjeUFpY21WbmFYTjBjbUYwYVc5dVgzTm9ZWEJsSWlBaUtHRmtaSEpsYzNNc2RXbHVkRGdzZFdsdWREWTBLU0lLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwzTnZZMmxoYkMxbWIyeHNiM2RsY2kxcGJtUmxlQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak00Q2lBZ0lDQXZMeUJqYUdWamExTm9ZWEJsSUQwZ1IyeHZZbUZzVTNSaGRHVThjM1J5YVc1blBpaDdJR2x1YVhScFlXeFdZV3gxWlRvZ0p5Y3NJR3RsZVRvZ1IyRjBaVWRzYjJKaGJGTjBZWFJsUzJWNVEyaGxZMnRUYUdGd1pTQjlLUW9nSUNBZ2NIVnphR0o1ZEdWemN5QWlZMmhsWTJ0ZmMyaGhjR1VpSUNJaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb0tiV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwzTnZZMmxoYkMxbWIyeHNiM2RsY2kxcGJtUmxlQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak13Q2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1UyOWphV0ZzUm05c2JHOTNaWEpKYm1SbGVFZGhkR1VnWlhoMFpXNWtjeUJCYTJsMFlVSmhjMlZEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVpQnRZV2x1WDJOeVpXRjBaVjlPYjA5d1FERXpDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjRNekk1WmpBMFpXVWdNSGczTjJKaU56bGlPU0F3ZURabE1ETm1OVEJoSURCNE5HUmxZamcyTVRVZ01IZzVNR1EwWm1FMVpDQXdlRE16WlRreVl6azBJREI0T0RVMFpHVmtaVEFnTHk4Z2JXVjBhRzlrSUNKamIzTjBLR0o1ZEdWYlhTbDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0luSmxaMmx6ZEdWeUtIQmhlU3hpZVhSbFcxMHBkV2x1ZERZMElpd2diV1YwYUc5a0lDSmphR1ZqYXloaFpHUnlaWE56TEhWcGJuUTJOQ3hpZVhSbFcxMHBZbTl2YkNJc0lHMWxkR2h2WkNBaVoyVjBVbVZuYVhOMGNtRjBhVzl1VTJoaGNHVW9LR0ZrWkhKbGMzTXNkV2x1ZERnc2RXbHVkRFkwS1Nrb1lXUmtjbVZ6Y3l4MWFXNTBPQ3gxYVc1ME5qUXBJaXdnYldWMGFHOWtJQ0puWlhSRmJuUnllU2gxYVc1ME5qUXBZbmwwWlZ0ZElpd2diV1YwYUc5a0lDSjFjR1JoZEdWQmEybDBZVVJCVHloMWFXNTBOalFwZG05cFpDSXNJRzFsZEdodlpDQWliM0JWY0NncGRtOXBaQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUdOdmMzUWdjbVZuYVhOMFpYSWdZMmhsWTJzZ1oyVjBVbVZuYVhOMGNtRjBhVzl1VTJoaGNHVWdaMlYwUlc1MGNua2dkWEJrWVhSbFFXdHBkR0ZFUVU4Z2JXRnBibDl2Y0ZWd1gzSnZkWFJsUURFeENpQWdJQ0JsY25JS0NtMWhhVzVmYjNCVmNGOXliM1YwWlVBeE1Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTlpWVhObExXTnZiblJ5WVdOMGN5OTFjR2R5WVdSbFlXSnNaUzUwY3pvek1Bb2dJQ0FnTHk4Z2IzQlZjQ2dwT2lCMmIybGtJSHNnZlFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlqY21WaGRHVmZUbTlQY0VBeE16b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12YzI5amFXRnNMV1p2Ykd4dmQyVnlMV2x1WkdWNEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16QUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJUYjJOcFlXeEdiMnhzYjNkbGNrbHVaR1Y0UjJGMFpTQmxlSFJsYm1SeklFRnJhWFJoUW1GelpVTnZiblJ5WVdOMElIc0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VHTmtPV0ZrTmpkbElDOHZJRzFsZEdodlpDQWlZM0psWVhSbEtITjBjbWx1Wnl4MWFXNTBOalFwZG05cFpDSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JR055WldGMFpRb2dJQ0FnWlhKeUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXpiMk5wWVd3dFptOXNiRzkzWlhJdGFXNWtaWGd2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VTI5amFXRnNSbTlzYkc5M1pYSkpibVJsZUVkaGRHVXVZM0psWVhSbFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZM0psWVhSbE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl6YjJOcFlXd3RabTlzYkc5M1pYSXRhVzVrWlhndlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNE5Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJRzl1UTNKbFlYUmxPaUFuY21WeGRXbHlaU2NnZlNrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNeUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlltRnpaUzFqYjI1MGNtRmpkSE12ZFhCbmNtRmtaV0ZpYkdVdWRITTZNVFFLSUNBZ0lDOHZJSFpsY25OcGIyNGdQU0JIYkc5aVlXeFRkR0YwWlR4emRISnBibWMrS0hzZ2EyVjVPaUJIYkc5aVlXeFRkR0YwWlV0bGVWWmxjbk5wYjI0Z2ZTa0tJQ0FnSUhCMWMyaGllWFJsY3lBaWRtVnljMmx2YmlJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZjMjlqYVdGc0xXWnZiR3h2ZDJWeUxXbHVaR1Y0TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T0RZS0lDQWdJQzh2SUhSb2FYTXVkbVZ5YzJsdmJpNTJZV3gxWlNBOUlIWmxjbk5wYjI0S0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5aVlYTmxMV052Ym5SeVlXTjBjeTkxY0dkeVlXUmxZV0pzWlM1MGN6b3hOZ29nSUNBZ0x5OGdZV3RwZEdGRVFVOGdQU0JIYkc5aVlXeFRkR0YwWlR4QmNIQnNhV05oZEdsdmJqNG9leUJyWlhrNklFZHNiMkpoYkZOMFlYUmxTMlY1UVd0cGRHRkVRVThnZlNrS0lDQWdJR0o1ZEdWalh6SWdMeThnSW1GcmFYUmhYMlJoYnlJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZjMjlqYVdGc0xXWnZiR3h2ZDJWeUxXbHVaR1Y0TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T0RjS0lDQWdJQzh2SUhSb2FYTXVZV3RwZEdGRVFVOHVkbUZzZFdVZ1BTQkJjSEJzYVdOaGRHbHZiaWhoYTJsMFlVUkJUeWtLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwzTnZZMmxoYkMxbWIyeHNiM2RsY2kxcGJtUmxlQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak0wQ2lBZ0lDQXZMeUJ5WldkcGMzUnllVU4xY25OdmNpQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvZXlCcGJtbDBhV0ZzVm1Gc2RXVTZJREVzSUd0bGVUb2dSMkYwWlVkc2IySmhiRk4wWVhSbFMyVjVVbVZuYVhOMGNubERkWEp6YjNJZ2ZTa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0luSmxaMmx6ZEhKNVgyTjFjbk52Y2lJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZjMjlqYVdGc0xXWnZiR3h2ZDJWeUxXbHVaR1Y0TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T0RnS0lDQWdJQzh2SUhSb2FYTXVjbVZuYVhOMGNubERkWEp6YjNJdWRtRnNkV1VnUFNBeENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZjMjlqYVdGc0xXWnZiR3h2ZDJWeUxXbHVaR1Y0TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T0RRS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2V5QnZia055WldGMFpUb2dKM0psY1hWcGNtVW5JSDBwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5emIyTnBZV3d0Wm05c2JHOTNaWEl0YVc1a1pYZ3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZVMjlqYVdGc1JtOXNiRzkzWlhKSmJtUmxlRWRoZEdVdVkyOXpkRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21OdmMzUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDNOdlkybGhiQzFtYjJ4c2IzZGxjaTFwYm1SbGVDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qa3pDaUFnSUNBdkx5QmpiM04wS0dGeVozTTZJR0o1ZEdWektUb2dkV2x1ZERZMElIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTXlBdkx5QXlDaUFnSUNBckNpQWdJQ0J6ZDJGd0NpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TVRVeFpqZGpOelV3TURBd01EQXdNREF3TURBMU5qVTBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMM052WTJsaGJDMW1iMnhzYjNkbGNpMXBibVJsZUM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwVGIyTnBZV3hHYjJ4c2IzZGxja2x1WkdWNFIyRjBaUzV5WldkcGMzUmxjbHR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25KbFoybHpkR1Z5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXpiMk5wWVd3dFptOXNiRzkzWlhJdGFXNWtaWGd2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem81TndvZ0lDQWdMeThnY21WbmFYTjBaWElvYldKeVVHRjViV1Z1ZERvZ1ozUjRiaTVRWVhsdFpXNTBWSGh1TENCaGNtZHpPaUJpZVhSbGN5azZJSFZwYm5RMk5DQjdDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUMwS0lDQWdJR1IxY0FvZ0lDQWdaM1I0Ym5NZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUJ3WVhrS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdkSEpoYm5OaFkzUnBiMjRnZEhsd1pTQnBjeUJ3WVhrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNeUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCa2RYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12YzI5amFXRnNMV1p2Ykd4dmQyVnlMV2x1WkdWNEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9UZ0tJQ0FnSUM4dklHeHZaMmRsWkVGemMyVnlkQ2hoY21kekxteGxibWQwYUNBOVBUMGdVbVZuYVhOMFpYSkNlWFJsVEdWdVozUm9MQ0JsY25KSmJuWmhiR2xrUVhKblEyOTFiblFwQ2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ05ERUtJQ0FnSUQwOUNpQWdJQ0JpYm5vZ2NtVm5hWE4wWlhKZllXWjBaWEpmWVhOelpYSjBRRE1LSUNBZ0lIQjFjMmhpZVhSbGN5QWlSVkpTT21WeWNrbGhjbWNpQ2lBZ0lDQnNiMmNLSUNBZ0lHVnljaUF2THlCRlVsSTZaWEp5U1dGeVp3b0tjbVZuYVhOMFpYSmZZV1owWlhKZllYTnpaWEowUURNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMM052WTJsaGJDMW1iMnhzYjNkbGNpMXBibVJsZUM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2prNUNpQWdJQ0F2THlCc2IyZG5aV1JCYzNObGNuUW9iV0p5VUdGNWJXVnVkQzV5WldObGFYWmxjaUE5UFQwZ1IyeHZZbUZzTG1OMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01zSUdWeWNrbHVkbUZzYVdSUVlYbHRaVzUwS1FvZ0lDQWdaR2xuSURFS0lDQWdJR2QwZUc1eklGSmxZMlZwZG1WeUNpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b2dJQ0FnUFQwS0lDQWdJR0p1ZWlCeVpXZHBjM1JsY2w5aFpuUmxjbDloYzNObGNuUkFOUW9nSUNBZ1lubDBaV05mTXlBdkx5QWlSVkpTT21WeWNrbHdZWGtpQ2lBZ0lDQnNiMmNLSUNBZ0lHVnljaUF2THlCRlVsSTZaWEp5U1hCaGVRb0tjbVZuYVhOMFpYSmZZV1owWlhKZllYTnpaWEowUURVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMM052WTJsaGJDMW1iMnhzYjNkbGNpMXBibVJsZUM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFd01Bb2dJQ0FnTHk4Z2JHOW5aMlZrUVhOelpYSjBLRzFpY2xCaGVXMWxiblF1WVcxdmRXNTBJRDA5UFNCVmMyVnlUM0JsY21GMGIzSldZV3gxWlZKbFoybHpkSEo1VFVKU0xDQmxjbkpKYm5aaGJHbGtVR0Y1YldWdWRDa0tJQ0FnSUhOM1lYQUtJQ0FnSUdkMGVHNXpJRUZ0YjNWdWRBb2dJQ0FnY0hWemFHbHVkQ0F5TWpFd01Bb2dJQ0FnUFQwS0lDQWdJR0p1ZWlCeVpXZHBjM1JsY2w5aFpuUmxjbDloYzNObGNuUkFOd29nSUNBZ1lubDBaV05mTXlBdkx5QWlSVkpTT21WeWNrbHdZWGtpQ2lBZ0lDQnNiMmNLSUNBZ0lHVnljaUF2THlCRlVsSTZaWEp5U1hCaGVRb0tjbVZuYVhOMFpYSmZZV1owWlhKZllYTnpaWEowUURjNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMM052WTJsaGJDMW1iMnhzYjNkbGNpMXBibVJsZUM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRM0NpQWdJQ0F2THlCamIyNXpkQ0JwWkNBOUlIUm9hWE11Y21WbmFYTjBjbmxEZFhKemIzSXVkbUZzZFdVS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwzTnZZMmxoYkMxbWIyeHNiM2RsY2kxcGJtUmxlQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak0wQ2lBZ0lDQXZMeUJ5WldkcGMzUnllVU4xY25OdmNpQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvZXlCcGJtbDBhV0ZzVm1Gc2RXVTZJREVzSUd0bGVUb2dSMkYwWlVkc2IySmhiRk4wWVhSbFMyVjVVbVZuYVhOMGNubERkWEp6YjNJZ2ZTa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0luSmxaMmx6ZEhKNVgyTjFjbk52Y2lJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZjMjlqYVdGc0xXWnZiR3h2ZDJWeUxXbHVaR1Y0TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRjS0lDQWdJQzh2SUdOdmJuTjBJR2xrSUQwZ2RHaHBjeTV5WldkcGMzUnllVU4xY25OdmNpNTJZV3gxWlFvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmMyOWphV0ZzTFdadmJHeHZkMlZ5TFdsdVpHVjRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORGdLSUNBZ0lDOHZJSFJvYVhNdWNtVm5hWE4wY25sRGRYSnpiM0l1ZG1Gc2RXVWdLejBnTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl6YjJOcFlXd3RabTlzYkc5M1pYSXRhVzVrWlhndlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek5Bb2dJQ0FnTHk4Z2NtVm5hWE4wY25sRGRYSnpiM0lnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tIc2dhVzVwZEdsaGJGWmhiSFZsT2lBeExDQnJaWGs2SUVkaGRHVkhiRzlpWVd4VGRHRjBaVXRsZVZKbFoybHpkSEo1UTNWeWMyOXlJSDBwQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0p5WldkcGMzUnllVjlqZFhKemIzSWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDNOdlkybGhiQzFtYjJ4c2IzZGxjaTFwYm1SbGVDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUTRDaUFnSUNBdkx5QjBhR2x6TG5KbFoybHpkSEo1UTNWeWMyOXlMblpoYkhWbElDczlJREVLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwzTnZZMmxoYkMxbWIyeHNiM2RsY2kxcGJtUmxlQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV3TXdvZ0lDQWdMeThnZEdocGN5NXlaV2RwYzNSeWVTaHBaQ2t1ZG1Gc2RXVWdQU0JrWldOdlpHVkJjbU0wUEZOdlkybGhiRVp2Ykd4dmQyVnlTVzVrWlhoSFlYUmxVbVZuYVhOMGNubEpibVp2UGloaGNtZHpLUW9nSUNBZ2FYUnZZZ29nSUNBZ1pIVndDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12YzI5amFXRnNMV1p2Ykd4dmQyVnlMV2x1WkdWNEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9UY0tJQ0FnSUM4dklISmxaMmx6ZEdWeUtHMWljbEJoZVcxbGJuUTZJR2QwZUc0dVVHRjViV1Z1ZEZSNGJpd2dZWEpuY3pvZ1lubDBaWE1wT2lCMWFXNTBOalFnZXdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmMyOWphV0ZzTFdadmJHeHZkMlZ5TFdsdVpHVjRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPbE52WTJsaGJFWnZiR3h2ZDJWeVNXNWtaWGhIWVhSbExtTm9aV05yVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1kyaGxZMnM2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwzTnZZMmxoYkMxbWIyeHNiM2RsY2kxcGJtUmxlQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV3TndvZ0lDQWdMeThnWTJobFkyc29ZMkZzYkdWeU9pQkJZMk52ZFc1MExDQnlaV2RwYzNSeWVVbEVPaUIxYVc1ME5qUXNJR0Z5WjNNNklHSjVkR1Z6S1RvZ1ltOXZiR1ZoYmlCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhCdUlESUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0F6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnYzNkaGNBb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZjMjlqYVdGc0xXWnZiR3h2ZDJWeUxXbHVaR1Y0TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRBNUNpQWdJQ0F2THlCamIyNXpkQ0I3SUhWelpYSXNJRzl3TENCMllXeDFaU0I5SUQwZ1kyeHZibVVvZEdocGN5NXlaV2RwYzNSeWVTaHlaV2RwYzNSeWVVbEVLUzUyWVd4MVpTa0tJQ0FnSUdsMGIySUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QkNiM2dnYlhWemRDQm9ZWFpsSUhaaGJIVmxDaUFnSUNCa2RYQUtJQ0FnSUdWNGRISmhZM1FnTUNBek1nb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCamIzWmxjaUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHVjRkSEpoWTNRZ016SWdNUW9nSUNBZ1kyOTJaWElnTXdvZ0lDQWdjSFZ6YUdsdWRDQXpNd29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHTnZkbVZ5SURNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZjMjlqYVdGc0xXWnZiR3h2ZDJWeUxXbHVaR1Y0TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRNS0lDQWdJQzh2SUdOdmJuTjBJR2R5WVhCb0lEMGdaMlYwUVd0cGRHRlRiMk5wWVd4QmNIQk1hWE4wS0hSb2FYTXVZV3RwZEdGRVFVOHVkbUZzZFdVcExtZHlZWEJvQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJKaGMyVXRZMjl1ZEhKaFkzUnpMM1Z3WjNKaFpHVmhZbXhsTG5Sek9qRTJDaUFnSUNBdkx5QmhhMmwwWVVSQlR5QTlJRWRzYjJKaGJGTjBZWFJsUEVGd2NHeHBZMkYwYVc5dVBpaDdJR3RsZVRvZ1IyeHZZbUZzVTNSaGRHVkxaWGxCYTJsMFlVUkJUeUI5S1FvZ0lDQWdZbmwwWldOZk1pQXZMeUFpWVd0cGRHRmZaR0Z2SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXpiMk5wWVd3dFptOXNiRzkzWlhJdGFXNWtaWGd2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xTXdvZ0lDQWdMeThnWTI5dWMzUWdaM0poY0dnZ1BTQm5aWFJCYTJsMFlWTnZZMmxoYkVGd2NFeHBjM1FvZEdocGN5NWhhMmwwWVVSQlR5NTJZV3gxWlNrdVozSmhjR2dLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Wm5WdVkzUnBiMjV6TG5Sek9qSXhNUW9nSUNBZ0x5OGdZMjl1YzNRZ1cyRndjRXhwYzNSQ2VYUmxjMTBnUFNCdmNDNUJjSEJIYkc5aVlXd3VaMlYwUlhoQ2VYUmxjeWhoYTJsMFlVUkJUeXdnUW5sMFpYTW9RV3RwZEdGRVFVOUhiRzlpWVd4VGRHRjBaVXRsZVhOQmEybDBZVk52WTJsaGJFRndjRXhwYzNRcEtRb2dJQ0FnY0hWemFHSjVkR1Z6SUNKellXd2lDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwzTnZZMmxoYkMxbWIyeHNiM2RsY2kxcGJtUmxlQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalV6Q2lBZ0lDQXZMeUJqYjI1emRDQm5jbUZ3YUNBOUlHZGxkRUZyYVhSaFUyOWphV0ZzUVhCd1RHbHpkQ2gwYUdsekxtRnJhWFJoUkVGUExuWmhiSFZsS1M1bmNtRndhQW9nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmMyOWphV0ZzTFdadmJHeHZkMlZ5TFdsdVpHVjRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVFl0TlRrS0lDQWdJQzh2SUdOdmJuTjBJR2x6Um05c2JHOTNhVzVuSUQwZ1lXSnBRMkZzYkR4MGVYQmxiMllnUVd0cGRHRlRiMk5wWVd4SGNtRndhQzV3Y205MGIzUjVjR1V1YVhOR2IyeHNiM2RwYm1jK0tIc0tJQ0FnSUM4dklDQWdZWEJ3U1dRNklHZHlZWEJvTEFvZ0lDQWdMeThnSUNCaGNtZHpPaUJiWm05c2JHOTNaWElzSUhWelpYSmRMQW9nSUNBZ0x5OGdmU2t1Y21WMGRYSnVWbUZzZFdVS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0WldJMk1tWTFNRGdnTHk4Z2JXVjBhRzlrSUNKcGMwWnZiR3h2ZDJsdVp5aGhaR1J5WlhOekxHRmtaSEpsYzNNcFltOXZiQ0lLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJSEIxYzJocGJuUWdOaUF2THlCaGNIQnNDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQnBkSGh1SUV4aGMzUk1iMmNLSUNBZ0lHUjFjQW9nSUNBZ1pYaDBjbUZqZENBMElEQUtJQ0FnSUhOM1lYQUtJQ0FnSUdWNGRISmhZM1FnTUNBMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdRbmwwWlhNZ2FHRnpJSFpoYkdsa0lIQnlaV1pwZUFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaWIyOXNDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWjJWMFltbDBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDNOdlkybGhiQzFtYjJ4c2IzZGxjaTFwYm1SbGVDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWXhDaUFnSUNBdkx5QnBaaUFvSVdselJtOXNiRzkzYVc1bktTQjdDaUFnSUNCaWJub2dZMmhsWTJ0ZllXWjBaWEpmYVdaZlpXeHpaVUF6Q2lBZ0lDQndiM0J1SURVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZjMjlqYVdGc0xXWnZiR3h2ZDJWeUxXbHVaR1Y0TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpJS0lDQWdJQzh2SUhKbGRIVnliaUJtWVd4elpRb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0NtTm9aV05yWDJGbWRHVnlYMmx1YkdsdVpXUmZjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5emIyTnBZV3d0Wm05c2JHOTNaWEl0YVc1a1pYZ3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZVMjlqYVdGc1JtOXNiRzkzWlhKSmJtUmxlRWRoZEdVdVptOXNiRzkzWlhKSmJtUmxlRWRoZEdWQU1UWTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDNOdlkybGhiQzFtYjJ4c2IzZGxjaTFwYm1SbGVDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXdOd29nSUNBZ0x5OGdZMmhsWTJzb1kyRnNiR1Z5T2lCQlkyTnZkVzUwTENCeVpXZHBjM1J5ZVVsRU9pQjFhVzUwTmpRc0lHRnlaM002SUdKNWRHVnpLVG9nWW05dmJHVmhiaUI3Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TUFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWMFltbDBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3BqYUdWamExOWhablJsY2w5cFpsOWxiSE5sUURNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMM052WTJsaGJDMW1iMnhzYjNkbGNpMXBibVJsZUM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZMkxUWTVDaUFnSUNBdkx5QmpiMjV6ZENCcGJtUmxlQ0E5SUdGaWFVTmhiR3c4ZEhsd1pXOW1JRUZyYVhSaFUyOWphV0ZzUjNKaGNHZ3VjSEp2ZEc5MGVYQmxMbWRsZEVadmJHeHZkMGx1WkdWNFBpaDdDaUFnSUNBdkx5QWdJR0Z3Y0Vsa09pQm5jbUZ3YUN3S0lDQWdJQzh2SUNBZ1lYSm5jem9nVzJadmJHeHZkMlZ5TENCMWMyVnlYU3dLSUNBZ0lDOHZJSDBwTG5KbGRIVnlibFpoYkhWbENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBNU9ETTRNR0UwSUM4dklHMWxkR2h2WkNBaVoyVjBSbTlzYkc5M1NXNWtaWGdvWVdSa2NtVnpjeXhoWkdSeVpYTnpLWFZwYm5RMk5DSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQndkWE5vYVc1MElEWWdMeThnWVhCd2JBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ2FYUjRiaUJNWVhOMFRHOW5DaUFnSUNCa2RYQUtJQ0FnSUdWNGRISmhZM1FnTkNBd0NpQWdJQ0J6ZDJGd0NpQWdJQ0JsZUhSeVlXTjBJREFnTkFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFSjVkR1Z6SUdoaGN5QjJZV3hwWkNCd2NtVm1hWGdLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDNOdlkybGhiQzFtYjJ4c2IzZGxjaTFwYm1SbGVDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qY3lDaUFnSUNBdkx5QmpZWE5sSUVWeGRXRnNPaUJ5WlhSMWNtNGdhVzVrWlhnZ1BUMDlJSFpoYkhWbENpQWdJQ0JrYVdjZ01Rb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1HRUtJQ0FnSUQwOUNpQWdJQ0JpZWlCamFHVmphMTloWm5SbGNsOXBabDlsYkhObFFEVUtJQ0FnSUdKMWNua2dNUW9nSUNBZ1BUMEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12YzI5amFXRnNMV1p2Ykd4dmQyVnlMV2x1WkdWNEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1URXdMVEV4TlFvZ0lDQWdMeThnY21WMGRYSnVJSFJvYVhNdVptOXNiRzkzWlhKSmJtUmxlRWRoZEdVb0NpQWdJQ0F2THlBZ0lIVnpaWElzQ2lBZ0lDQXZMeUFnSUdOaGJHeGxjaXdLSUNBZ0lDOHZJQ0FnYjNBc0NpQWdJQ0F2THlBZ0lIWmhiSFZsQ2lBZ0lDQXZMeUFwQ2lBZ0lDQmlJR05vWldOclgyRm1kR1Z5WDJsdWJHbHVaV1JmYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXpiMk5wWVd3dFptOXNiRzkzWlhJdGFXNWtaWGd2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VTI5amFXRnNSbTlzYkc5M1pYSkpibVJsZUVkaGRHVXVabTlzYkc5M1pYSkpibVJsZUVkaGRHVkFNVFlLQ21Ob1pXTnJYMkZtZEdWeVgybG1YMlZzYzJWQU5Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12YzI5amFXRnNMV1p2Ykd4dmQyVnlMV2x1WkdWNEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk56TUtJQ0FnSUM4dklHTmhjMlVnVG05MFJYRjFZV3c2SUhKbGRIVnliaUJwYm1SbGVDQWhQVDBnZG1Gc2RXVUtJQ0FnSUdScFp5QXhDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3hOQW9nSUNBZ1BUMEtJQ0FnSUdKNklHTm9aV05yWDJGbWRHVnlYMmxtWDJWc2MyVkFOd29nSUNBZ1luVnllU0F4Q2lBZ0lDQWhQUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5emIyTnBZV3d0Wm05c2JHOTNaWEl0YVc1a1pYZ3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNVEF0TVRFMUNpQWdJQ0F2THlCeVpYUjFjbTRnZEdocGN5NW1iMnhzYjNkbGNrbHVaR1Y0UjJGMFpTZ0tJQ0FnSUM4dklDQWdkWE5sY2l3S0lDQWdJQzh2SUNBZ1kyRnNiR1Z5TEFvZ0lDQWdMeThnSUNCdmNDd0tJQ0FnSUM4dklDQWdkbUZzZFdVS0lDQWdJQzh2SUNrS0lDQWdJR0lnWTJobFkydGZZV1owWlhKZmFXNXNhVzVsWkY5emJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMM052WTJsaGJDMW1iMnhzYjNkbGNpMXBibVJsZUM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwVGIyTnBZV3hHYjJ4c2IzZGxja2x1WkdWNFIyRjBaUzVtYjJ4c2IzZGxja2x1WkdWNFIyRjBaVUF4TmdvS1kyaGxZMnRmWVdaMFpYSmZhV1pmWld4elpVQTNPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5emIyTnBZV3d0Wm05c2JHOTNaWEl0YVc1a1pYZ3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNOQW9nSUNBZ0x5OGdZMkZ6WlNCTVpYTnpWR2hoYmpvZ2NtVjBkWEp1SUdsdVpHVjRJRHdnZG1Gc2RXVUtJQ0FnSUdScFp5QXhDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3haUW9nSUNBZ1BUMEtJQ0FnSUdKNklHTm9aV05yWDJGbWRHVnlYMmxtWDJWc2MyVkFPUW9nSUNBZ1luVnllU0F4Q2lBZ0lDQStDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDNOdlkybGhiQzFtYjJ4c2IzZGxjaTFwYm1SbGVDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXhNQzB4TVRVS0lDQWdJQzh2SUhKbGRIVnliaUIwYUdsekxtWnZiR3h2ZDJWeVNXNWtaWGhIWVhSbEtBb2dJQ0FnTHk4Z0lDQjFjMlZ5TEFvZ0lDQWdMeThnSUNCallXeHNaWElzQ2lBZ0lDQXZMeUFnSUc5d0xBb2dJQ0FnTHk4Z0lDQjJZV3gxWlFvZ0lDQWdMeThnS1FvZ0lDQWdZaUJqYUdWamExOWhablJsY2w5cGJteHBibVZrWDNOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZjMjlqYVdGc0xXWnZiR3h2ZDJWeUxXbHVaR1Y0TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2xOdlkybGhiRVp2Ykd4dmQyVnlTVzVrWlhoSFlYUmxMbVp2Ykd4dmQyVnlTVzVrWlhoSFlYUmxRREUyQ2dwamFHVmphMTloWm5SbGNsOXBabDlsYkhObFFEazZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDNOdlkybGhiQzFtYjJ4c2IzZGxjaTFwYm1SbGVDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qYzFDaUFnSUNBdkx5QmpZWE5sSUV4bGMzTlVhR0Z1VDNKRmNYVmhiRlJ2T2lCeVpYUjFjbTRnYVc1a1pYZ2dQRDBnZG1Gc2RXVUtJQ0FnSUdScFp5QXhDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3lPQW9nSUNBZ1BUMEtJQ0FnSUdKNklHTm9aV05yWDJGbWRHVnlYMmxtWDJWc2MyVkFNVEVLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdQajBLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmMyOWphV0ZzTFdadmJHeHZkMlZ5TFdsdVpHVjRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEV3TFRFeE5Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUhSb2FYTXVabTlzYkc5M1pYSkpibVJsZUVkaGRHVW9DaUFnSUNBdkx5QWdJSFZ6WlhJc0NpQWdJQ0F2THlBZ0lHTmhiR3hsY2l3S0lDQWdJQzh2SUNBZ2IzQXNDaUFnSUNBdkx5QWdJSFpoYkhWbENpQWdJQ0F2THlBcENpQWdJQ0JpSUdOb1pXTnJYMkZtZEdWeVgybHViR2x1WldSZmMyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl6YjJOcFlXd3RabTlzYkc5M1pYSXRhVzVrWlhndlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlUyOWphV0ZzUm05c2JHOTNaWEpKYm1SbGVFZGhkR1V1Wm05c2JHOTNaWEpKYm1SbGVFZGhkR1ZBTVRZS0NtTm9aV05yWDJGbWRHVnlYMmxtWDJWc2MyVkFNVEU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwzTnZZMmxoYkMxbWIyeHNiM2RsY2kxcGJtUmxlQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamMyQ2lBZ0lDQXZMeUJqWVhObElFZHlaV0YwWlhKVWFHRnVPaUJ5WlhSMWNtNGdhVzVrWlhnZ1BpQjJZV3gxWlFvZ0lDQWdaR2xuSURFS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURNeUNpQWdJQ0E5UFFvZ0lDQWdZbm9nWTJobFkydGZZV1owWlhKZmFXWmZaV3h6WlVBeE13b2dJQ0FnWW5WeWVTQXhDaUFnSUNBOENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMM052WTJsaGJDMW1iMnhzYjNkbGNpMXBibVJsZUM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeE1DMHhNVFVLSUNBZ0lDOHZJSEpsZEhWeWJpQjBhR2x6TG1admJHeHZkMlZ5U1c1a1pYaEhZWFJsS0FvZ0lDQWdMeThnSUNCMWMyVnlMQW9nSUNBZ0x5OGdJQ0JqWVd4c1pYSXNDaUFnSUNBdkx5QWdJRzl3TEFvZ0lDQWdMeThnSUNCMllXeDFaUW9nSUNBZ0x5OGdLUW9nSUNBZ1lpQmphR1ZqYTE5aFpuUmxjbDlwYm14cGJtVmtYM050WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmMyOWphV0ZzTFdadmJHeHZkMlZ5TFdsdVpHVjRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPbE52WTJsaGJFWnZiR3h2ZDJWeVNXNWtaWGhIWVhSbExtWnZiR3h2ZDJWeVNXNWtaWGhIWVhSbFFERTJDZ3BqYUdWamExOWhablJsY2w5cFpsOWxiSE5sUURFek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl6YjJOcFlXd3RabTlzYkc5M1pYSXRhVzVrWlhndlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM053b2dJQ0FnTHk4Z1kyRnpaU0JIY21WaGRHVnlWR2hoYms5eVJYRjFZV3hVYnpvZ2NtVjBkWEp1SUdsdVpHVjRJRDQ5SUhaaGJIVmxDaUFnSUNCemQyRndDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3pZd29nSUNBZ1BUMEtJQ0FnSUdKNklHTm9aV05yWDJGbWRHVnlYMmxtWDJWc2MyVkFNVFVLSUNBZ0lEdzlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDNOdlkybGhiQzFtYjJ4c2IzZGxjaTFwYm1SbGVDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXhNQzB4TVRVS0lDQWdJQzh2SUhKbGRIVnliaUIwYUdsekxtWnZiR3h2ZDJWeVNXNWtaWGhIWVhSbEtBb2dJQ0FnTHk4Z0lDQjFjMlZ5TEFvZ0lDQWdMeThnSUNCallXeHNaWElzQ2lBZ0lDQXZMeUFnSUc5d0xBb2dJQ0FnTHk4Z0lDQjJZV3gxWlFvZ0lDQWdMeThnS1FvZ0lDQWdZaUJqYUdWamExOWhablJsY2w5cGJteHBibVZrWDNOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZjMjlqYVdGc0xXWnZiR3h2ZDJWeUxXbHVaR1Y0TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2xOdlkybGhiRVp2Ykd4dmQyVnlTVzVrWlhoSFlYUmxMbVp2Ykd4dmQyVnlTVzVrWlhoSFlYUmxRREUyQ2dwamFHVmphMTloWm5SbGNsOXBabDlsYkhObFFERTFPZ29nSUNBZ2NHOXdiaUF5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwzTnZZMmxoYkMxbWIyeHNiM2RsY2kxcGJtUmxlQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamM0Q2lBZ0lDQXZMeUJrWldaaGRXeDBPaUJ5WlhSMWNtNGdabUZzYzJVS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwzTnZZMmxoYkMxbWIyeHNiM2RsY2kxcGJtUmxlQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV4TUMweE1UVUtJQ0FnSUM4dklISmxkSFZ5YmlCMGFHbHpMbVp2Ykd4dmQyVnlTVzVrWlhoSFlYUmxLQW9nSUNBZ0x5OGdJQ0IxYzJWeUxBb2dJQ0FnTHk4Z0lDQmpZV3hzWlhJc0NpQWdJQ0F2THlBZ0lHOXdMQW9nSUNBZ0x5OGdJQ0IyWVd4MVpRb2dJQ0FnTHk4Z0tRb2dJQ0FnWWlCamFHVmphMTloWm5SbGNsOXBibXhwYm1Wa1gzTnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12YzI5amFXRnNMV1p2Ykd4dmQyVnlMV2x1WkdWNEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9sTnZZMmxoYkVadmJHeHZkMlZ5U1c1a1pYaEhZWFJsTG1admJHeHZkMlZ5U1c1a1pYaEhZWFJsUURFMkNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXpiMk5wWVd3dFptOXNiRzkzWlhJdGFXNWtaWGd2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VTI5amFXRnNSbTlzYkc5M1pYSkpibVJsZUVkaGRHVXVaMlYwVW1WbmFYTjBjbUYwYVc5dVUyaGhjR1ZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwblpYUlNaV2RwYzNSeVlYUnBiMjVUYUdGd1pUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12YzI5amFXRnNMV1p2Ykd4dmQyVnlMV2x1WkdWNEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1URTRDaUFnSUNBdkx5Qm5aWFJTWldkcGMzUnlZWFJwYjI1VGFHRndaU2h6YUdGd1pUb2dVMjlqYVdGc1JtOXNiRzkzWlhKSmJtUmxlRWRoZEdWU1pXZHBjM1J5ZVVsdVptOHBPaUJUYjJOcFlXeEdiMnhzYjNkbGNrbHVaR1Y0UjJGMFpWSmxaMmx6ZEhKNVNXNW1ieUI3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBME1Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXpiMk5wWVd3dFptOXNiRzkzWlhJdGFXNWtaWGd2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VTI5amFXRnNSbTlzYkc5M1pYSkpibVJsZUVkaGRHVlNaV2RwYzNSeWVVbHVabThLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDNOdlkybGhiQzFtYjJ4c2IzZGxjaTFwYm1SbGVDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcFRiMk5wWVd4R2IyeHNiM2RsY2tsdVpHVjRSMkYwWlM1blpYUkZiblJ5ZVZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtZGxkRVZ1ZEhKNU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl6YjJOcFlXd3RabTlzYkc5M1pYSXRhVzVrWlhndlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1qSUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXpiMk5wWVd3dFptOXNiRzkzWlhJdGFXNWtaWGd2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TWpRS0lDQWdJQzh2SUhKbGRIVnliaUJsYm1OdlpHVkJjbU0wS0hSb2FYTXVjbVZuYVhOMGNua29jbVZuYVhOMGNubEpSQ2t1ZG1Gc2RXVXBDaUFnSUNCcGRHOWlDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmhjM05sY25RZ0x5OGdRbTk0SUcxMWMzUWdhR0YyWlNCMllXeDFaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5emIyTnBZV3d0Wm05c2JHOTNaWEl0YVc1a1pYZ3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNaklLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU0I5S1FvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12WW1GelpTMWpiMjUwY21GamRITXZkWEJuY21Ga1pXRmliR1V1ZEhNNk9rRnJhWFJoUW1GelpVTnZiblJ5WVdOMExuVndaR0YwWlVGcmFYUmhSRUZQVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2RYQmtZWFJsUVd0cGRHRkVRVTg2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlltRnpaUzFqYjI1MGNtRmpkSE12ZFhCbmNtRmtaV0ZpYkdVdWRITTZNalVLSUNBZ0lDOHZJSFZ3WkdGMFpVRnJhWFJoUkVGUEtHRnJhWFJoUkVGUE9pQkJjSEJzYVdOaGRHbHZiaWs2SUhadmFXUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwySmhjMlV0WTI5dWRISmhZM1J6TDNWd1ozSmhaR1ZoWW14bExuUnpPakkyQ2lBZ0lDQXZMeUJzYjJkblpXUkJjM05sY25Rb1ZIaHVMbk5sYm1SbGNpQTlQVDBnZEdocGN5NW5aWFJCYTJsMFlVUkJUMWRoYkd4bGRDZ3BMbUZrWkhKbGMzTXNJR1Z5Y2s1dmRFRnJhWFJoUkdGdktRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwySmhjMlV0WTI5dWRISmhZM1J6TDNWd1ozSmhaR1ZoWW14bExuUnpPakU1Q2lBZ0lDQXZMeUJqYjI1emRDQmJkMkZzYkdWMFNVUmRJRDBnYjNBdVFYQndSMnh2WW1Gc0xtZGxkRVY0VldsdWREWTBLSFJvYVhNdVlXdHBkR0ZFUVU4dWRtRnNkV1VzSUVKNWRHVnpLRUZyYVhSaFJFRlBSMnh2WW1Gc1UzUmhkR1ZMWlhselYyRnNiR1YwS1NrS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlltRnpaUzFqYjI1MGNtRmpkSE12ZFhCbmNtRmtaV0ZpYkdVdWRITTZNVFlLSUNBZ0lDOHZJR0ZyYVhSaFJFRlBJRDBnUjJ4dlltRnNVM1JoZEdVOFFYQndiR2xqWVhScGIyNCtLSHNnYTJWNU9pQkhiRzlpWVd4VGRHRjBaVXRsZVVGcmFYUmhSRUZQSUgwcENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKaGEybDBZVjlrWVc4aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZZbUZ6WlMxamIyNTBjbUZqZEhNdmRYQm5jbUZrWldGaWJHVXVkSE02TVRrS0lDQWdJQzh2SUdOdmJuTjBJRnQzWVd4c1pYUkpSRjBnUFNCdmNDNUJjSEJIYkc5aVlXd3VaMlYwUlhoVmFXNTBOalFvZEdocGN5NWhhMmwwWVVSQlR5NTJZV3gxWlN3Z1FubDBaWE1vUVd0cGRHRkVRVTlIYkc5aVlXeFRkR0YwWlV0bGVYTlhZV3hzWlhRcEtRb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJSEIxYzJoaWVYUmxjeUFpZDJGc2JHVjBJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJSEJ2Y0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwySmhjMlV0WTI5dWRISmhZM1J6TDNWd1ozSmhaR1ZoWW14bExuUnpPakkyQ2lBZ0lDQXZMeUJzYjJkblpXUkJjM05sY25Rb1ZIaHVMbk5sYm1SbGNpQTlQVDBnZEdocGN5NW5aWFJCYTJsMFlVUkJUMWRoYkd4bGRDZ3BMbUZrWkhKbGMzTXNJR1Z5Y2s1dmRFRnJhWFJoUkdGdktRb2dJQ0FnWVhCd1gzQmhjbUZ0YzE5blpYUWdRWEJ3UVdSa2NtVnpjd29nSUNBZ1lYTnpaWEowSUM4dklHRndjR3hwWTJGMGFXOXVJR1Y0YVhOMGN3b2dJQ0FnUFQwS0lDQWdJR0p1ZWlCMWNHUmhkR1ZCYTJsMFlVUkJUMTloWm5SbGNsOWhjM05sY25SQU13b2dJQ0FnY0hWemFHSjVkR1Z6SUNKRlVsSTZaWEp5VG1SaGJ5SUtJQ0FnSUd4dlp3b2dJQ0FnWlhKeUlDOHZJRVZTVWpwbGNuSk9aR0Z2Q2dwMWNHUmhkR1ZCYTJsMFlVUkJUMTloWm5SbGNsOWhjM05sY25SQU16b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTlpWVhObExXTnZiblJ5WVdOMGN5OTFjR2R5WVdSbFlXSnNaUzUwY3pveE5nb2dJQ0FnTHk4Z1lXdHBkR0ZFUVU4Z1BTQkhiRzlpWVd4VGRHRjBaVHhCY0hCc2FXTmhkR2x2Ymo0b2V5QnJaWGs2SUVkc2IySmhiRk4wWVhSbFMyVjVRV3RwZEdGRVFVOGdmU2tLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbUZyYVhSaFgyUmhieUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5aVlYTmxMV052Ym5SeVlXTjBjeTkxY0dkeVlXUmxZV0pzWlM1MGN6b3lOd29nSUNBZ0x5OGdkR2hwY3k1aGEybDBZVVJCVHk1MllXeDFaU0E5SUdGcmFYUmhSRUZQQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwySmhjMlV0WTI5dWRISmhZM1J6TDNWd1ozSmhaR1ZoWW14bExuUnpPakkxQ2lBZ0lDQXZMeUIxY0dSaGRHVkJhMmwwWVVSQlR5aGhhMmwwWVVSQlR6b2dRWEJ3YkdsallYUnBiMjRwT2lCMmIybGtJSHNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERUtJQ0FnSUhKbGRIVnliZ289In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFRQUlBaVlFQkJVZmZIVVBjbVZuYVhOMGNubGZZM1Z5YzI5eUNXRnJhWFJoWDJSaGJ3dEZVbEk2WlhKeVNYQmhlVEVZUUFCQUtTSm5nZ0lTY21WbmFYTjBjbUYwYVc5dVgzTm9ZWEJsRmloaFpHUnlaWE56TEhWcGJuUTRMSFZwYm5RMk5DbG5nZ0lMWTJobFkydGZjMmhoY0dVQVp6RVpGRVF4R0VFQU80SUhCREtmQk80RWQ3dDV1UVJ1QS9VS0JFM3JoaFVFa05UNlhRUXo2U3lVQklWTjdlQTJHZ0NPQndBK0FGc0F2QUhNQWRzQjlRQUJBQ0pEZ0FUTm10WitOaG9BamdFQUFRQTJHZ0ZKSTFrbENFc0JGUkpFVndJQU5ob0NTUlVrRWtRWGdBZDJaWEp6YVc5dVR3Sm5La3huS1NKbklrTTJHZ0ZKSTFrbENFd1ZFa1NBREJVZmZIVUFBQUFBQUFCV1ZMQWlRekVXSWdsSk9CQWlFa1EyR2dGSkkxa2xDRXNCRlJKRVZ3SUFTUldCS1JKQUFBK0FDMFZTVWpwbGNuSkpZWEpuc0FCTEFUZ0hNZ29TUUFBREs3QUFURGdJZ2RTc0FSSkFBQU1yc0FBaktXVkVTU0lJS1V4bkZrbFBBcjhvVEZDd0lrTTJHZ0ZIQWhXQklCSkVOaG9DU1JVa0VrUVhOaG9EU1NOWkpRaE1GUkpFRnI1RVNWY0FJRWxPQWs0RFNWY2dBVTREZ1NGYlRnTWpLbVZFZ0FOellXeGxTQ1JiU1U0RHNiSVlnQVRyWXZVSXNocE1zaHF5R29FR3NoQWpzZ0d6dEQ1SlZ3UUFURmNBQkNnU1JFa1ZJaEpFSTFOQUFCQkdCU09BQVFBalR3SlVLRXhRc0NKRHNiSVlnQVFKZzRDa3NocFBBN0lhVHdLeUdvRUdzaEFqc2dHenRENUpWd1FBVEZjQUJDZ1NSRWtWSkJKRUYwc0JnQUVLRWtFQUJrVUJFa0wvdGtzQmdBRVVFa0VBQmtVQkUwTC9wMHNCZ0FFZUVrRUFCa1VCRFVML21Fc0JnQUVvRWtFQUJrVUJEMEwvaVVzQmdBRXlFa0VBQmtVQkRFTC9la3lBQVR3U1FRQUVEa0wvYmtZQ0kwTC9hRFlhQVVrVmdTa1NSQ2hNVUxBaVF6WWFBVWtWSkJKRUZ4YStSRWtWRmxjR0FreFFLRXhRc0NKRE5ob0JTUlVrRWtRWE1RQWpLbVZFZ0FaM1lXeHNaWFJsU0hJSVJCSkFBQStBQzBWU1VqcGxjbkpPWkdGdnNBQXFUR2NpUXc9PSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjEwLCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
