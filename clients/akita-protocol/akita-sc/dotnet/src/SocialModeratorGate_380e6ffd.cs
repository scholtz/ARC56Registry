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

namespace Arc56.Generated.akita_protocol.akita_sc.SocialModeratorGate_380e6ffd
{


    public class SocialModeratorGateProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public SocialModeratorGateProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class OperatorAndValue : AVMObjectType
            {
                public byte Op { get; set; }

                public ulong Value { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
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

                public static OperatorAndValue Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new OperatorAndValue();
                    uint count = 0;
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
                    return Equals(obj as OperatorAndValue);
                }
                public bool Equals(OperatorAndValue? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(OperatorAndValue left, OperatorAndValue right)
                {
                    return EqualityComparer<OperatorAndValue>.Default.Equals(left, right);
                }
                public static bool operator !=(OperatorAndValue left, OperatorAndValue right)
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
        /// <param name="shape"> OperatorAndValue</param>
        public async Task<Structs.OperatorAndValue> GetRegistrationShape(Structs.OperatorAndValue shape, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 129, 241, 101, 67 };

            var result = await base.SimApp(new List<object> { abiHandle, shape }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.OperatorAndValue.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetRegistrationShape_Transactions(Structs.OperatorAndValue shape, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 129, 241, 101, 67 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU29jaWFsTW9kZXJhdG9yR2F0ZSIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJPcGVyYXRvckFuZFZhbHVlIjpbeyJuYW1lIjoib3AiLCJ0eXBlIjoidWludDgifSx7Im5hbWUiOiJ2YWx1ZSIsInR5cGUiOiJ1aW50NjQifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZlcnNpb24iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFraXRhREFPIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNvc3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXJncyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlZ2lzdGVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1iclBheW1lbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFyZ3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjaGVjayIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FsbGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWdpc3RyeUlEIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcmdzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFJlZ2lzdHJhdGlvblNoYXBlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6Iih1aW50OCx1aW50NjQpIiwic3RydWN0IjoiT3BlcmF0b3JBbmRWYWx1ZSIsIm5hbWUiOiJzaGFwZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDgsdWludDY0KSIsInN0cnVjdCI6Ik9wZXJhdG9yQW5kVmFsdWUiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldEVudHJ5IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlZ2lzdHJ5SUQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InVwZGF0ZUFraXRhREFPIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFraXRhREFPIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im9wVXAiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjIsImJ5dGVzIjozfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls0MTEsNjUxXSwiZXJyb3JNZXNzYWdlIjoiQm94IG11c3QgaGF2ZSB2YWx1ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ3MF0sImVycm9yTWVzc2FnZSI6IkJ5dGVzIGhhcyB2YWxpZCBwcmVmaXgiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMTUsNDA4XSwiZXJyb3JNZXNzYWdlIjoiRVJSOmVycklhcmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMjksMzQzXSwiZXJyb3JNZXNzYWdlIjoiRVJSOmVycklwYXkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3MTJdLCJlcnJvck1lc3NhZ2UiOiJFUlI6ZXJyTmRhbyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY5M10sImVycm9yTWVzc2FnZSI6ImFwcGxpY2F0aW9uIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM0Nyw0MjUsNjgwXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgR2xvYmFsU3RhdGUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjEyLDI1NCwyOTMsMzkwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDc2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIE9iamVjdEFFRDFGQTkzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjE5LDI2MCwzMDAsMzk3XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM3NV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMzAsMzgzLDY0Nyw2NzNdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MzNdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3Igc21hcnRfY29udHJhY3RzL2dhdGVzL3R5cGVzLnRzOjpPcGVyYXRvckFuZFZhbHVlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjg3XSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBwYXkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01TQXdJRElnT0FvZ0lDQWdZbmwwWldOaWJHOWpheUF3ZURFMU1XWTNZemMxSUNKaGEybDBZVjlrWVc4aUlDSnlaV2RwYzNSeWVWOWpkWEp6YjNJaUlDSWlJQ0pGVWxJNlpYSnlTV0Z5WnlJZ0lrVlNVanBsY25KSmNHRjVJZ29nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0p1ZWlCdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl6YjJOcFlXd3RiVzlrWlhKaGRHOXlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNalVLSUNBZ0lDOHZJSEpsWjJsemRISjVRM1Z5YzI5eUlEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWg3SUdsdWFYUnBZV3hXWVd4MVpUb2dNU3dnYTJWNU9pQkhZWFJsUjJ4dlltRnNVM1JoZEdWTFpYbFNaV2RwYzNSeWVVTjFjbk52Y2lCOUtRb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWNtVm5hWE4wY25sZlkzVnljMjl5SWdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwzTnZZMmxoYkMxdGIyUmxjbUYwYjNJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU9Bb2dJQ0FnTHk4Z2NtVm5hWE4wY21GMGFXOXVVMmhoY0dVZ1BTQkhiRzlpWVd4VGRHRjBaVHh6ZEhKcGJtYytLSHNnYVc1cGRHbGhiRlpoYkhWbE9pQW5LSFZwYm5RNExIVnBiblEyTkNrbkxDQnJaWGs2SUVkaGRHVkhiRzlpWVd4VGRHRjBaVXRsZVZKbFoybHpkSEpoZEdsdmJsTm9ZWEJsSUgwcENpQWdJQ0J3ZFhOb1lubDBaWE56SUNKeVpXZHBjM1J5WVhScGIyNWZjMmhoY0dVaUlDSW9kV2x1ZERnc2RXbHVkRFkwS1NJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMM052WTJsaGJDMXRiMlJsY21GMGIzSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pNQW9nSUNBZ0x5OGdZMmhsWTJ0VGFHRndaU0E5SUVkc2IySmhiRk4wWVhSbFBITjBjbWx1Wno0b2V5QnBibWwwYVdGc1ZtRnNkV1U2SUNjbkxDQnJaWGs2SUVkaGRHVkhiRzlpWVd4VGRHRjBaVXRsZVVOb1pXTnJVMmhoY0dVZ2ZTa0tJQ0FnSUhCMWMyaGllWFJsY3lBaVkyaGxZMnRmYzJoaGNHVWlDaUFnSUNCaWVYUmxZMTh6SUM4dklDSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9LYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMM052WTJsaGJDMXRiMlJsY21GMGIzSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNUW9nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUZOdlkybGhiRTF2WkdWeVlYUnZja2RoZEdVZ1pYaDBaVzVrY3lCQmEybDBZVUpoYzJWRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmllaUJ0WVdsdVgyTnlaV0YwWlY5T2IwOXdRREV6Q2lBZ0lDQndkWE5vWW5sMFpYTnpJREI0TXpJNVpqQTBaV1VnTUhnM04ySmlOemxpT1NBd2VEWmxNRE5tTlRCaElEQjRPREZtTVRZMU5ETWdNSGc1TUdRMFptRTFaQ0F3ZURNelpUa3lZemswSURCNE9EVTBaR1ZrWlRBZ0x5OGdiV1YwYUc5a0lDSmpiM04wS0dKNWRHVmJYU2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbkpsWjJsemRHVnlLSEJoZVN4aWVYUmxXMTBwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0pqYUdWamF5aGhaR1J5WlhOekxIVnBiblEyTkN4aWVYUmxXMTBwWW05dmJDSXNJRzFsZEdodlpDQWlaMlYwVW1WbmFYTjBjbUYwYVc5dVUyaGhjR1VvS0hWcGJuUTRMSFZwYm5RMk5Da3BLSFZwYm5RNExIVnBiblEyTkNraUxDQnRaWFJvYjJRZ0ltZGxkRVZ1ZEhKNUtIVnBiblEyTkNsaWVYUmxXMTBpTENCdFpYUm9iMlFnSW5Wd1pHRjBaVUZyYVhSaFJFRlBLSFZwYm5RMk5DbDJiMmxrSWl3Z2JXVjBhRzlrSUNKdmNGVndLQ2wyYjJsa0lnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2dZMjl6ZENCeVpXZHBjM1JsY2lCamFHVmpheUJuWlhSU1pXZHBjM1J5WVhScGIyNVRhR0Z3WlNCblpYUkZiblJ5ZVNCMWNHUmhkR1ZCYTJsMFlVUkJUeUJ0WVdsdVgyOXdWWEJmY205MWRHVkFNVEVLSUNBZ0lHVnljZ29LYldGcGJsOXZjRlZ3WDNKdmRYUmxRREV4T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwySmhjMlV0WTI5dWRISmhZM1J6TDNWd1ozSmhaR1ZoWW14bExuUnpPak13Q2lBZ0lDQXZMeUJ2Y0ZWd0tDazZJSFp2YVdRZ2V5QjlDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyTnlaV0YwWlY5T2IwOXdRREV6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXpiMk5wWVd3dGJXOWtaWEpoZEc5eUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qRUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJUYjJOcFlXeE5iMlJsY21GMGIzSkhZWFJsSUdWNGRHVnVaSE1nUVd0cGRHRkNZWE5sUTI5dWRISmhZM1FnZXdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0WTJRNVlXUTJOMlVnTHk4Z2JXVjBhRzlrSUNKamNtVmhkR1VvYzNSeWFXNW5MSFZwYm5RMk5DbDJiMmxrSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ1kzSmxZWFJsQ2lBZ0lDQmxjbklLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDNOdlkybGhiQzF0YjJSbGNtRjBiM0l2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VTI5amFXRnNUVzlrWlhKaGRHOXlSMkYwWlM1amNtVmhkR1ZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwamNtVmhkR1U2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwzTnZZMmxoYkMxdGIyUmxjbUYwYjNJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM01nb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJRzl1UTNKbFlYUmxPaUFuY21WeGRXbHlaU2NnZlNrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlltRnpaUzFqYjI1MGNtRmpkSE12ZFhCbmNtRmtaV0ZpYkdVdWRITTZNVFFLSUNBZ0lDOHZJSFpsY25OcGIyNGdQU0JIYkc5aVlXeFRkR0YwWlR4emRISnBibWMrS0hzZ2EyVjVPaUJIYkc5aVlXeFRkR0YwWlV0bGVWWmxjbk5wYjI0Z2ZTa0tJQ0FnSUhCMWMyaGllWFJsY3lBaWRtVnljMmx2YmlJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZjMjlqYVdGc0xXMXZaR1Z5WVhSdmNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qYzBDaUFnSUNBdkx5QjBhR2x6TG5abGNuTnBiMjR1ZG1Gc2RXVWdQU0IyWlhKemFXOXVDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZZbUZ6WlMxamIyNTBjbUZqZEhNdmRYQm5jbUZrWldGaWJHVXVkSE02TVRZS0lDQWdJQzh2SUdGcmFYUmhSRUZQSUQwZ1IyeHZZbUZzVTNSaGRHVThRWEJ3YkdsallYUnBiMjQrS0hzZ2EyVjVPaUJIYkc5aVlXeFRkR0YwWlV0bGVVRnJhWFJoUkVGUElIMHBDaUFnSUNCaWVYUmxZMTh4SUM4dklDSmhhMmwwWVY5a1lXOGlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDNOdlkybGhiQzF0YjJSbGNtRjBiM0l2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zTlFvZ0lDQWdMeThnZEdocGN5NWhhMmwwWVVSQlR5NTJZV3gxWlNBOUlFRndjR3hwWTJGMGFXOXVLR0ZyYVhSaFJFRlBLUW9nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmMyOWphV0ZzTFcxdlpHVnlZWFJ2Y2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pjeUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2diMjVEY21WaGRHVTZJQ2R5WlhGMWFYSmxKeUI5S1FvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmMyOWphV0ZzTFcxdlpHVnlZWFJ2Y2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwVGIyTnBZV3hOYjJSbGNtRjBiM0pIWVhSbExtTnZjM1JiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwamIzTjBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5emIyTnBZV3d0Ylc5a1pYSmhkRzl5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T0RBS0lDQWdJQzh2SUdOdmMzUW9ZWEpuY3pvZ1lubDBaWE1wT2lCMWFXNTBOalFnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJQ3NLSUNBZ0lITjNZWEFLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3hOVEZtTjJNM05UQXdNREF3TURBd01EQXdNREkwTlRRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmMyOWphV0ZzTFcxdlpHVnlZWFJ2Y2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwVGIyTnBZV3hOYjJSbGNtRjBiM0pIWVhSbExuSmxaMmx6ZEdWeVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjbVZuYVhOMFpYSTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDNOdlkybGhiQzF0YjJSbGNtRjBiM0l2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem80TkFvZ0lDQWdMeThnY21WbmFYTjBaWElvYldKeVVHRjViV1Z1ZERvZ1ozUjRiaTVRWVhsdFpXNTBWSGh1TENCaGNtZHpPaUJpZVhSbGN5azZJSFZwYm5RMk5DQjdDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUMwS0lDQWdJR1IxY0FvZ0lDQWdaM1I0Ym5NZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUJ3WVhrS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdkSEpoYm5OaFkzUnBiMjRnZEhsd1pTQnBjeUJ3WVhrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCa2RYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12YzI5amFXRnNMVzF2WkdWeVlYUnZjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamcxQ2lBZ0lDQXZMeUJzYjJkblpXUkJjM05sY25Rb1lYSm5jeTVzWlc1bmRHZ2dQVDA5SUU5d1pYSmhkRzl5UVc1a1ZtRnNkV1ZDZVhSbFRHVnVaM1JvTENCbGNuSkpiblpoYkdsa1FYSm5RMjkxYm5RcENpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdPUW9nSUNBZ1BUMEtJQ0FnSUdKdWVpQnlaV2RwYzNSbGNsOWhablJsY2w5aGMzTmxjblJBTXdvZ0lDQWdZbmwwWldNZ05DQXZMeUFpUlZKU09tVnlja2xoY21jaUNpQWdJQ0JzYjJjS0lDQWdJR1Z5Y2lBdkx5QkZVbEk2WlhKeVNXRnlad29LY21WbmFYTjBaWEpmWVdaMFpYSmZZWE56WlhKMFFETTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDNOdlkybGhiQzF0YjJSbGNtRjBiM0l2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem80TmdvZ0lDQWdMeThnYkc5bloyVmtRWE56WlhKMEtHMWljbEJoZVcxbGJuUXVjbVZqWldsMlpYSWdQVDA5SUVkc2IySmhiQzVqZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpMQ0JsY25KSmJuWmhiR2xrVUdGNWJXVnVkQ2tLSUNBZ0lHUnBaeUF4Q2lBZ0lDQm5kSGh1Y3lCU1pXTmxhWFpsY2dvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJRDA5Q2lBZ0lDQmlibm9nY21WbmFYTjBaWEpmWVdaMFpYSmZZWE56WlhKMFFEVUtJQ0FnSUdKNWRHVmpJRFVnTHk4Z0lrVlNVanBsY25KSmNHRjVJZ29nSUNBZ2JHOW5DaUFnSUNCbGNuSWdMeThnUlZKU09tVnlja2x3WVhrS0NuSmxaMmx6ZEdWeVgyRm1kR1Z5WDJGemMyVnlkRUExT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXpiMk5wWVd3dGJXOWtaWEpoZEc5eUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9EY0tJQ0FnSUM4dklHeHZaMmRsWkVGemMyVnlkQ2h0WW5KUVlYbHRaVzUwTG1GdGIzVnVkQ0E5UFQwZ1QzQmxjbUYwYjNKQmJtUldZV3gxWlZKbFoybHpkSEo1VFVKU0xDQmxjbkpKYm5aaGJHbGtVR0Y1YldWdWRDa0tJQ0FnSUhOM1lYQUtJQ0FnSUdkMGVHNXpJRUZ0YjNWdWRBb2dJQ0FnY0hWemFHbHVkQ0E1TXpBd0NpQWdJQ0E5UFFvZ0lDQWdZbTU2SUhKbFoybHpkR1Z5WDJGbWRHVnlYMkZ6YzJWeWRFQTNDaUFnSUNCaWVYUmxZeUExSUM4dklDSkZVbEk2WlhKeVNYQmhlU0lLSUNBZ0lHeHZad29nSUNBZ1pYSnlJQzh2SUVWU1VqcGxjbkpKY0dGNUNncHlaV2RwYzNSbGNsOWhablJsY2w5aGMzTmxjblJBTnpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZjMjlqYVdGc0xXMXZaR1Z5WVhSdmNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTVDaUFnSUNBdkx5QmpiMjV6ZENCcFpDQTlJSFJvYVhNdWNtVm5hWE4wY25sRGRYSnpiM0l1ZG1Gc2RXVUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMM052WTJsaGJDMXRiMlJsY21GMGIzSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lOUW9nSUNBZ0x5OGdjbVZuYVhOMGNubERkWEp6YjNJZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLSHNnYVc1cGRHbGhiRlpoYkhWbE9pQXhMQ0JyWlhrNklFZGhkR1ZIYkc5aVlXeFRkR0YwWlV0bGVWSmxaMmx6ZEhKNVEzVnljMjl5SUgwcENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKeVpXZHBjM1J5ZVY5amRYSnpiM0lpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwzTnZZMmxoYkMxdGIyUmxjbUYwYjNJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek9Rb2dJQ0FnTHk4Z1kyOXVjM1FnYVdRZ1BTQjBhR2x6TG5KbFoybHpkSEo1UTNWeWMyOXlMblpoYkhWbENpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXpiMk5wWVd3dGJXOWtaWEpoZEc5eUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5EQUtJQ0FnSUM4dklIUm9hWE11Y21WbmFYTjBjbmxEZFhKemIzSXVkbUZzZFdVZ0t6MGdNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXpiMk5wWVd3dGJXOWtaWEpoZEc5eUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qVUtJQ0FnSUM4dklISmxaMmx6ZEhKNVEzVnljMjl5SUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpaDdJR2x1YVhScFlXeFdZV3gxWlRvZ01Td2dhMlY1T2lCSFlYUmxSMnh2WW1Gc1UzUmhkR1ZMWlhsU1pXZHBjM1J5ZVVOMWNuTnZjaUI5S1FvZ0lDQWdZbmwwWldOZk1pQXZMeUFpY21WbmFYTjBjbmxmWTNWeWMyOXlJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5emIyTnBZV3d0Ylc5a1pYSmhkRzl5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRBS0lDQWdJQzh2SUhSb2FYTXVjbVZuYVhOMGNubERkWEp6YjNJdWRtRnNkV1VnS3owZ01Rb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12YzI5amFXRnNMVzF2WkdWeVlYUnZjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamt3Q2lBZ0lDQXZMeUIwYUdsekxuSmxaMmx6ZEhKNUtHbGtLUzUyWVd4MVpTQTlJR1JsWTI5a1pVRnlZelE4VDNCbGNtRjBiM0pCYm1SV1lXeDFaVDRvWVhKbmN5a0tJQ0FnSUdsMGIySUtJQ0FnSUdSMWNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMM052WTJsaGJDMXRiMlJsY21GMGIzSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzROQW9nSUNBZ0x5OGdjbVZuYVhOMFpYSW9iV0p5VUdGNWJXVnVkRG9nWjNSNGJpNVFZWGx0Wlc1MFZIaHVMQ0JoY21kek9pQmllWFJsY3lrNklIVnBiblEyTkNCN0NpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXpiMk5wWVd3dGJXOWtaWEpoZEc5eUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9sTnZZMmxoYkUxdlpHVnlZWFJ2Y2tkaGRHVXVZMmhsWTJ0YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGphR1ZqYXpvS0lDQWdJR0o1ZEdWalh6TWdMeThnSWlJS0lDQWdJR1IxY0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXpiMk5wWVd3dGJXOWtaWEpoZEc5eUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9UUUtJQ0FnSUM4dklHTm9aV05yS0dOaGJHeGxjam9nUVdOamIzVnVkQ3dnY21WbmFYTjBjbmxKUkRvZ2RXbHVkRFkwTENCaGNtZHpPaUJpZVhSbGN5azZJR0p2YjJ4bFlXNGdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZjMjlqYVdGc0xXMXZaR1Z5WVhSdmNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qazFDaUFnSUNBdkx5QnNiMmRuWldSQmMzTmxjblFvWVhKbmN5NXNaVzVuZEdnZ1BUMDlJREFzSUdWeWNrbHVkbUZzYVdSQmNtZERiM1Z1ZENrS0lDQWdJR3hsYmdvZ0lDQWdZbm9nWTJobFkydGZZV1owWlhKZllYTnpaWEowUURNS0lDQWdJR0o1ZEdWaklEUWdMeThnSWtWU1VqcGxjbkpKWVhKbklnb2dJQ0FnYkc5bkNpQWdJQ0JsY25JZ0x5OGdSVkpTT21WeWNrbGhjbWNLQ21Ob1pXTnJYMkZtZEdWeVgyRnpjMlZ5ZEVBek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl6YjJOcFlXd3RiVzlrWlhKaGRHOXlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPVFlLSUNBZ0lDOHZJR052Ym5OMElIc2diM0FzSUhaaGJIVmxJSDBnUFNCamJHOXVaU2gwYUdsekxuSmxaMmx6ZEhKNUtISmxaMmx6ZEhKNVNVUXBMblpoYkhWbEtRb2dJQ0FnYVhSdllnb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklFSnZlQ0J0ZFhOMElHaGhkbVVnZG1Gc2RXVUtJQ0FnSUdSMWNBb2dJQ0FnWlhoMGNtRmpkQ0F3SURFS0lDQWdJSE4zWVhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdZblZ5ZVNBekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMM052WTJsaGJDMXRiMlJsY21GMGIzSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBOUzAwT0FvZ0lDQWdMeThnWTI5dWMzUWdleUJsZUdsemRITXNJR3hoYzNSQlkzUnBkbVVnZlNBOUlHRmlhVU5oYkd3OGRIbHdaVzltSUVGcmFYUmhVMjlqYVdGc1RXOWtaWEpoZEdsdmJpNXdjbTkwYjNSNWNHVXViVzlrWlhKaGRHOXlUV1YwWVQ0b2V3b2dJQ0FnTHk4Z0lDQmhjSEJKWkRvZ1oyVjBRV3RwZEdGVGIyTnBZV3hCY0hCTWFYTjBLSFJvYVhNdVlXdHBkR0ZFUVU4dWRtRnNkV1VwTG0xdlpHVnlZWFJwYjI0c0NpQWdJQ0F2THlBZ0lHRnlaM002SUZ0MWMyVnlYU3dLSUNBZ0lDOHZJSDBwTG5KbGRIVnlibFpoYkhWbENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwzTnZZMmxoYkMxdGIyUmxjbUYwYjNJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME5nb2dJQ0FnTHk4Z1lYQndTV1E2SUdkbGRFRnJhWFJoVTI5amFXRnNRWEJ3VEdsemRDaDBhR2x6TG1GcmFYUmhSRUZQTG5aaGJIVmxLUzV0YjJSbGNtRjBhVzl1TEFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5aVlYTmxMV052Ym5SeVlXTjBjeTkxY0dkeVlXUmxZV0pzWlM1MGN6b3hOZ29nSUNBZ0x5OGdZV3RwZEdGRVFVOGdQU0JIYkc5aVlXeFRkR0YwWlR4QmNIQnNhV05oZEdsdmJqNG9leUJyWlhrNklFZHNiMkpoYkZOMFlYUmxTMlY1UVd0cGRHRkVRVThnZlNrS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1GcmFYUmhYMlJoYnlJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZjMjlqYVdGc0xXMXZaR1Z5WVhSdmNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUTJDaUFnSUNBdkx5QmhjSEJKWkRvZ1oyVjBRV3RwZEdGVGIyTnBZV3hCY0hCTWFYTjBLSFJvYVhNdVlXdHBkR0ZFUVU4dWRtRnNkV1VwTG0xdlpHVnlZWFJwYjI0c0NpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwyWjFibU4wYVc5dWN5NTBjem95TVRFS0lDQWdJQzh2SUdOdmJuTjBJRnRoY0hCTWFYTjBRbmwwWlhOZElEMGdiM0F1UVhCd1IyeHZZbUZzTG1kbGRFVjRRbmwwWlhNb1lXdHBkR0ZFUVU4c0lFSjVkR1Z6S0VGcmFYUmhSRUZQUjJ4dlltRnNVM1JoZEdWTFpYbHpRV3RwZEdGVGIyTnBZV3hCY0hCTWFYTjBLU2tLSUNBZ0lIQjFjMmhpZVhSbGN5QWljMkZzSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUhCdmNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl6YjJOcFlXd3RiVzlrWlhKaGRHOXlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORFlLSUNBZ0lDOHZJR0Z3Y0Vsa09pQm5aWFJCYTJsMFlWTnZZMmxoYkVGd2NFeHBjM1FvZEdocGN5NWhhMmwwWVVSQlR5NTJZV3gxWlNrdWJXOWtaWEpoZEdsdmJpd0tJQ0FnSUhCMWMyaHBiblFnTWpRS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12YzI5amFXRnNMVzF2WkdWeVlYUnZjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalExTFRRNENpQWdJQ0F2THlCamIyNXpkQ0I3SUdWNGFYTjBjeXdnYkdGemRFRmpkR2wyWlNCOUlEMGdZV0pwUTJGc2JEeDBlWEJsYjJZZ1FXdHBkR0ZUYjJOcFlXeE5iMlJsY21GMGFXOXVMbkJ5YjNSdmRIbHdaUzV0YjJSbGNtRjBiM0pOWlhSaFBpaDdDaUFnSUNBdkx5QWdJR0Z3Y0Vsa09pQm5aWFJCYTJsMFlWTnZZMmxoYkVGd2NFeHBjM1FvZEdocGN5NWhhMmwwWVVSQlR5NTJZV3gxWlNrdWJXOWtaWEpoZEdsdmJpd0tJQ0FnSUM4dklDQWdZWEpuY3pvZ1czVnpaWEpkTEFvZ0lDQWdMeThnZlNrdWNtVjBkWEp1Vm1Gc2RXVUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VERm1NMk0yTVRoaklDOHZJRzFsZEdodlpDQWliVzlrWlhKaGRHOXlUV1YwWVNoaFpHUnlaWE56S1NoaWIyOXNMSFZwYm5RMk5Da2lDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdjM2RoY0FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUhCMWMyaHBiblFnTmlBdkx5QmhjSEJzQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0JwZEhodUlFeGhjM1JNYjJjS0lDQWdJR1IxY0FvZ0lDQWdaWGgwY21GamRDQTBJREFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmxlSFJ5WVdOMElEQWdOQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUVKNWRHVnpJR2hoY3lCMllXeHBaQ0J3Y21WbWFYZ0tJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRGtLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlFOWlhbVZqZEVGRlJERkdRVGt6Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1oyVjBZbWwwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQndkWE5vYVc1MElEVUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCemQyRndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDNOdlkybGhiQzF0YjJSbGNtRjBiM0l2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xTUFvZ0lDQWdMeThnYVdZZ0tDRmxlR2x6ZEhNcElIc0tJQ0FnSUdKdWVpQmphR1ZqYTE5aFpuUmxjbDlwWmw5bGJITmxRRFlLSUNBZ0lIQnZjRzRnTWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXpiMk5wWVd3dGJXOWtaWEpoZEc5eUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5URUtJQ0FnSUM4dklISmxkSFZ5YmlCbVlXeHpaUW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtDbU5vWldOclgyRm1kR1Z5WDJsdWJHbHVaV1JmYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXpiMk5wWVd3dGJXOWtaWEpoZEc5eUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9sTnZZMmxoYkUxdlpHVnlZWFJ2Y2tkaGRHVXViVzlrWlhKaGRHOXlSMkYwWlVBeU1Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12YzI5amFXRnNMVzF2WkdWeVlYUnZjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamswQ2lBZ0lDQXZMeUJqYUdWamF5aGpZV3hzWlhJNklFRmpZMjkxYm5Rc0lISmxaMmx6ZEhKNVNVUTZJSFZwYm5RMk5Dd2dZWEpuY3pvZ1lubDBaWE1wT2lCaWIyOXNaV0Z1SUhzS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCelpYUmlhWFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ21Ob1pXTnJYMkZtZEdWeVgybG1YMlZzYzJWQU5qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12YzI5amFXRnNMVzF2WkdWeVlYUnZjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalUwQ2lBZ0lDQXZMeUJzWlhRZ2MybHVZMlU2SUhWcGJuUTJOQ0E5SURBS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmlkWEo1SURRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZjMjlqYVdGc0xXMXZaR1Z5WVhSdmNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVTFDaUFnSUNBdkx5QnBaaUFvZG1Gc2RXVWdQRDBnUjJ4dlltRnNMbXhoZEdWemRGUnBiV1Z6ZEdGdGNDa2dld29nSUNBZ1pHbG5JRElLSUNBZ0lHZHNiMkpoYkNCTVlYUmxjM1JVYVcxbGMzUmhiWEFLSUNBZ0lEdzlDaUFnSUNCaWVpQmphR1ZqYTE5aFpuUmxjbDlwWmw5bGJITmxRRGdLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmMyOWphV0ZzTFcxdlpHVnlZWFJ2Y2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVMkNpQWdJQ0F2THlCemFXNWpaU0E5SUVkc2IySmhiQzVzWVhSbGMzUlVhVzFsYzNSaGJYQWdMU0IyWVd4MVpRb2dJQ0FnWjJ4dlltRnNJRXhoZEdWemRGUnBiV1Z6ZEdGdGNBb2dJQ0FnWkdsbklETUtJQ0FnSUMwS0lDQWdJR0oxY25rZ05Bb0tZMmhsWTJ0ZllXWjBaWEpmYVdaZlpXeHpaVUE0T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXpiMk5wWVd3dGJXOWtaWEpoZEc5eUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5qQUtJQ0FnSUM4dklHTmhjMlVnUlhGMVlXdzZJSEpsZEhWeWJpQnNZWE4wUVdOMGFYWmxJRDA5UFNCemFXNWpaUW9nSUNBZ1pHbG5JREVLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREJoQ2lBZ0lDQTlQUW9nSUNBZ1lub2dZMmhsWTJ0ZllXWjBaWEpmYVdaZlpXeHpaVUF4TUFvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JrYVdjZ01nb2dJQ0FnUFQwS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZjMjlqYVdGc0xXMXZaR1Z5WVhSdmNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qazNDaUFnSUNBdkx5QnlaWFIxY200Z2RHaHBjeTV0YjJSbGNtRjBiM0pIWVhSbEtHTmhiR3hsY2l3Z2IzQXNJSFpoYkhWbEtRb2dJQ0FnWWlCamFHVmphMTloWm5SbGNsOXBibXhwYm1Wa1gzTnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12YzI5amFXRnNMVzF2WkdWeVlYUnZjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBUYjJOcFlXeE5iMlJsY21GMGIzSkhZWFJsTG0xdlpHVnlZWFJ2Y2tkaGRHVkFNakVLQ21Ob1pXTnJYMkZtZEdWeVgybG1YMlZzYzJWQU1UQTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDNOdlkybGhiQzF0YjJSbGNtRjBiM0l2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTVFvZ0lDQWdMeThnWTJGelpTQk9iM1JGY1hWaGJEb2djbVYwZFhKdUlHeGhjM1JCWTNScGRtVWdJVDA5SUhOcGJtTmxDaUFnSUNCa2FXY2dNUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNVFFLSUNBZ0lEMDlDaUFnSUNCaWVpQmphR1ZqYTE5aFpuUmxjbDlwWmw5bGJITmxRREV5Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR1JwWnlBeUNpQWdJQ0FoUFFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXpiMk5wWVd3dGJXOWtaWEpoZEc5eUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9UY0tJQ0FnSUM4dklISmxkSFZ5YmlCMGFHbHpMbTF2WkdWeVlYUnZja2RoZEdVb1kyRnNiR1Z5TENCdmNDd2dkbUZzZFdVcENpQWdJQ0JpSUdOb1pXTnJYMkZtZEdWeVgybHViR2x1WldSZmMyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl6YjJOcFlXd3RiVzlrWlhKaGRHOXlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPbE52WTJsaGJFMXZaR1Z5WVhSdmNrZGhkR1V1Ylc5a1pYSmhkRzl5UjJGMFpVQXlNUW9LWTJobFkydGZZV1owWlhKZmFXWmZaV3h6WlVBeE1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12YzI5amFXRnNMVzF2WkdWeVlYUnZjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPall5Q2lBZ0lDQXZMeUJqWVhObElFeGxjM05VYUdGdU9pQnlaWFIxY200Z2JHRnpkRUZqZEdsMlpTQThJSE5wYm1ObENpQWdJQ0JrYVdjZ01Rb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1XVUtJQ0FnSUQwOUNpQWdJQ0JpZWlCamFHVmphMTloWm5SbGNsOXBabDlsYkhObFFERTBDaUFnSUNCaWRYSjVJREVLSUNBZ0lHUnBaeUF5Q2lBZ0lDQThDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDNOdlkybGhiQzF0YjJSbGNtRjBiM0l2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem81TndvZ0lDQWdMeThnY21WMGRYSnVJSFJvYVhNdWJXOWtaWEpoZEc5eVIyRjBaU2hqWVd4c1pYSXNJRzl3TENCMllXeDFaU2tLSUNBZ0lHSWdZMmhsWTJ0ZllXWjBaWEpmYVc1c2FXNWxaRjl6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwzTnZZMmxoYkMxdGIyUmxjbUYwYjNJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlUyOWphV0ZzVFc5a1pYSmhkRzl5UjJGMFpTNXRiMlJsY21GMGIzSkhZWFJsUURJeENncGphR1ZqYTE5aFpuUmxjbDlwWmw5bGJITmxRREUwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXpiMk5wWVd3dGJXOWtaWEpoZEc5eUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5qTUtJQ0FnSUM4dklHTmhjMlVnVEdWemMxUm9ZVzVQY2tWeGRXRnNWRzg2SUhKbGRIVnliaUJzWVhOMFFXTjBhWFpsSUR3OUlITnBibU5sQ2lBZ0lDQmthV2NnTVFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TWpnS0lDQWdJRDA5Q2lBZ0lDQmllaUJqYUdWamExOWhablJsY2w5cFpsOWxiSE5sUURFMkNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdScFp5QXlDaUFnSUNBOFBRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl6YjJOcFlXd3RiVzlrWlhKaGRHOXlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPVGNLSUNBZ0lDOHZJSEpsZEhWeWJpQjBhR2x6TG0xdlpHVnlZWFJ2Y2tkaGRHVW9ZMkZzYkdWeUxDQnZjQ3dnZG1Gc2RXVXBDaUFnSUNCaUlHTm9aV05yWDJGbWRHVnlYMmx1YkdsdVpXUmZjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5emIyTnBZV3d0Ylc5a1pYSmhkRzl5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2xOdlkybGhiRTF2WkdWeVlYUnZja2RoZEdVdWJXOWtaWEpoZEc5eVIyRjBaVUF5TVFvS1kyaGxZMnRmWVdaMFpYSmZhV1pmWld4elpVQXhOam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmMyOWphV0ZzTFcxdlpHVnlZWFJ2Y2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZMENpQWdJQ0F2THlCallYTmxJRWR5WldGMFpYSlVhR0Z1T2lCeVpYUjFjbTRnYkdGemRFRmpkR2wyWlNBK0lITnBibU5sQ2lBZ0lDQmthV2NnTVFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TXpJS0lDQWdJRDA5Q2lBZ0lDQmllaUJqYUdWamExOWhablJsY2w5cFpsOWxiSE5sUURFNENpQWdJQ0JpZFhKNUlERUtJQ0FnSUdScFp5QXlDaUFnSUNBK0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMM052WTJsaGJDMXRiMlJsY21GMGIzSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzVOd29nSUNBZ0x5OGdjbVYwZFhKdUlIUm9hWE11Ylc5a1pYSmhkRzl5UjJGMFpTaGpZV3hzWlhJc0lHOXdMQ0IyWVd4MVpTa0tJQ0FnSUdJZ1kyaGxZMnRmWVdaMFpYSmZhVzVzYVc1bFpGOXpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDNOdlkybGhiQzF0YjJSbGNtRjBiM0l2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VTI5amFXRnNUVzlrWlhKaGRHOXlSMkYwWlM1dGIyUmxjbUYwYjNKSFlYUmxRREl4Q2dwamFHVmphMTloWm5SbGNsOXBabDlsYkhObFFERTRPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5emIyTnBZV3d0Ylc5a1pYSmhkRzl5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpVS0lDQWdJQzh2SUdOaGMyVWdSM0psWVhSbGNsUm9ZVzVQY2tWeGRXRnNWRzg2SUhKbGRIVnliaUJzWVhOMFFXTjBhWFpsSUQ0OUlITnBibU5sQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd6WXdvZ0lDQWdQVDBLSUNBZ0lHSjZJR05vWldOclgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpBS0lDQWdJR1JwWnlBeUNpQWdJQ0ErUFFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXpiMk5wWVd3dGJXOWtaWEpoZEc5eUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9UY0tJQ0FnSUM4dklISmxkSFZ5YmlCMGFHbHpMbTF2WkdWeVlYUnZja2RoZEdVb1kyRnNiR1Z5TENCdmNDd2dkbUZzZFdVcENpQWdJQ0JpSUdOb1pXTnJYMkZtZEdWeVgybHViR2x1WldSZmMyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl6YjJOcFlXd3RiVzlrWlhKaGRHOXlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPbE52WTJsaGJFMXZaR1Z5WVhSdmNrZGhkR1V1Ylc5a1pYSmhkRzl5UjJGMFpVQXlNUW9LWTJobFkydGZZV1owWlhKZmFXWmZaV3h6WlVBeU1Eb0tJQ0FnSUhCdmNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl6YjJOcFlXd3RiVzlrWlhKaGRHOXlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOallLSUNBZ0lDOHZJR1JsWm1GMWJIUTZJSEpsZEhWeWJpQm1ZV3h6WlFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmMyOWphV0ZzTFcxdlpHVnlZWFJ2Y2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2prM0NpQWdJQ0F2THlCeVpYUjFjbTRnZEdocGN5NXRiMlJsY21GMGIzSkhZWFJsS0dOaGJHeGxjaXdnYjNBc0lIWmhiSFZsS1FvZ0lDQWdZaUJqYUdWamExOWhablJsY2w5cGJteHBibVZrWDNOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZjMjlqYVdGc0xXMXZaR1Z5WVhSdmNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcFRiMk5wWVd4TmIyUmxjbUYwYjNKSFlYUmxMbTF2WkdWeVlYUnZja2RoZEdWQU1qRUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMM052WTJsaGJDMXRiMlJsY21GMGIzSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZVMjlqYVdGc1RXOWtaWEpoZEc5eVIyRjBaUzVuWlhSU1pXZHBjM1J5WVhScGIyNVRhR0Z3WlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtZGxkRkpsWjJsemRISmhkR2x2YmxOb1lYQmxPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5emIyTnBZV3d0Ylc5a1pYSmhkRzl5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRBd0NpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2djbVZoWkc5dWJIazZJSFJ5ZFdVZ2ZTa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRGtLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTkwZVhCbGN5NTBjem82VDNCbGNtRjBiM0pCYm1SV1lXeDFaUW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12YzI5amFXRnNMVzF2WkdWeVlYUnZjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBUYjJOcFlXeE5iMlJsY21GMGIzSkhZWFJsTG1kbGRFVnVkSEo1VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1oyVjBSVzUwY25rNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMM052WTJsaGJDMXRiMlJsY21GMGIzSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNRFVLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU0I5S1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl6YjJOcFlXd3RiVzlrWlhKaGRHOXlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEEzQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdaVzVqYjJSbFFYSmpOQ2gwYUdsekxuSmxaMmx6ZEhKNUtISmxaMmx6ZEhKNVNVUXBMblpoYkhWbEtRb2dJQ0FnYVhSdllnb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklFSnZlQ0J0ZFhOMElHaGhkbVVnZG1Gc2RXVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12YzI5amFXRnNMVzF2WkdWeVlYUnZjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV3TlFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lISmxZV1J2Ym14NU9pQjBjblZsSUgwcENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5aVlYTmxMV052Ym5SeVlXTjBjeTkxY0dkeVlXUmxZV0pzWlM1MGN6bzZRV3RwZEdGQ1lYTmxRMjl1ZEhKaFkzUXVkWEJrWVhSbFFXdHBkR0ZFUVU5YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDFjR1JoZEdWQmEybDBZVVJCVHpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OWlZWE5sTFdOdmJuUnlZV04wY3k5MWNHZHlZV1JsWVdKc1pTNTBjem95TlFvZ0lDQWdMeThnZFhCa1lYUmxRV3RwZEdGRVFVOG9ZV3RwZEdGRVFVODZJRUZ3Y0d4cFkyRjBhVzl1S1RvZ2RtOXBaQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZZbUZ6WlMxamIyNTBjbUZqZEhNdmRYQm5jbUZrWldGaWJHVXVkSE02TWpZS0lDQWdJQzh2SUd4dloyZGxaRUZ6YzJWeWRDaFVlRzR1YzJWdVpHVnlJRDA5UFNCMGFHbHpMbWRsZEVGcmFYUmhSRUZQVjJGc2JHVjBLQ2t1WVdSa2NtVnpjeXdnWlhKeVRtOTBRV3RwZEdGRVlXOHBDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZZbUZ6WlMxamIyNTBjbUZqZEhNdmRYQm5jbUZrWldGaWJHVXVkSE02TVRrS0lDQWdJQzh2SUdOdmJuTjBJRnQzWVd4c1pYUkpSRjBnUFNCdmNDNUJjSEJIYkc5aVlXd3VaMlYwUlhoVmFXNTBOalFvZEdocGN5NWhhMmwwWVVSQlR5NTJZV3gxWlN3Z1FubDBaWE1vUVd0cGRHRkVRVTlIYkc5aVlXeFRkR0YwWlV0bGVYTlhZV3hzWlhRcEtRb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OWlZWE5sTFdOdmJuUnlZV04wY3k5MWNHZHlZV1JsWVdKc1pTNTBjem94TmdvZ0lDQWdMeThnWVd0cGRHRkVRVThnUFNCSGJHOWlZV3hUZEdGMFpUeEJjSEJzYVdOaGRHbHZiajRvZXlCclpYazZJRWRzYjJKaGJGTjBZWFJsUzJWNVFXdHBkR0ZFUVU4Z2ZTa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltRnJhWFJoWDJSaGJ5SUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTlpWVhObExXTnZiblJ5WVdOMGN5OTFjR2R5WVdSbFlXSnNaUzUwY3pveE9Rb2dJQ0FnTHk4Z1kyOXVjM1FnVzNkaGJHeGxkRWxFWFNBOUlHOXdMa0Z3Y0Vkc2IySmhiQzVuWlhSRmVGVnBiblEyTkNoMGFHbHpMbUZyYVhSaFJFRlBMblpoYkhWbExDQkNlWFJsY3loQmEybDBZVVJCVDBkc2IySmhiRk4wWVhSbFMyVjVjMWRoYkd4bGRDa3BDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnY0hWemFHSjVkR1Z6SUNKM1lXeHNaWFFpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnY0c5d0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZZbUZ6WlMxamIyNTBjbUZqZEhNdmRYQm5jbUZrWldGaWJHVXVkSE02TWpZS0lDQWdJQzh2SUd4dloyZGxaRUZ6YzJWeWRDaFVlRzR1YzJWdVpHVnlJRDA5UFNCMGFHbHpMbWRsZEVGcmFYUmhSRUZQVjJGc2JHVjBLQ2t1WVdSa2NtVnpjeXdnWlhKeVRtOTBRV3RwZEdGRVlXOHBDaUFnSUNCaGNIQmZjR0Z5WVcxelgyZGxkQ0JCY0hCQlpHUnlaWE56Q2lBZ0lDQmhjM05sY25RZ0x5OGdZWEJ3YkdsallYUnBiMjRnWlhocGMzUnpDaUFnSUNBOVBRb2dJQ0FnWW01NklIVndaR0YwWlVGcmFYUmhSRUZQWDJGbWRHVnlYMkZ6YzJWeWRFQXpDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lrVlNVanBsY25KT1pHRnZJZ29nSUNBZ2JHOW5DaUFnSUNCbGNuSWdMeThnUlZKU09tVnljazVrWVc4S0NuVndaR0YwWlVGcmFYUmhSRUZQWDJGbWRHVnlYMkZ6YzJWeWRFQXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJKaGMyVXRZMjl1ZEhKaFkzUnpMM1Z3WjNKaFpHVmhZbXhsTG5Sek9qRTJDaUFnSUNBdkx5QmhhMmwwWVVSQlR5QTlJRWRzYjJKaGJGTjBZWFJsUEVGd2NHeHBZMkYwYVc5dVBpaDdJR3RsZVRvZ1IyeHZZbUZzVTNSaGRHVkxaWGxCYTJsMFlVUkJUeUI5S1FvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWVd0cGRHRmZaR0Z2SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwySmhjMlV0WTI5dWRISmhZM1J6TDNWd1ozSmhaR1ZoWW14bExuUnpPakkzQ2lBZ0lDQXZMeUIwYUdsekxtRnJhWFJoUkVGUExuWmhiSFZsSUQwZ1lXdHBkR0ZFUVU4S0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZZbUZ6WlMxamIyNTBjbUZqZEhNdmRYQm5jbUZrWldGaWJHVXVkSE02TWpVS0lDQWdJQzh2SUhWd1pHRjBaVUZyYVhSaFJFRlBLR0ZyYVhSaFJFRlBPaUJCY0hCc2FXTmhkR2x2YmlrNklIWnZhV1FnZXdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVLSUNBZ0lISmxkSFZ5YmdvPSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBUUFDQ0NZR0JCVWZmSFVKWVd0cGRHRmZaR0Z2RDNKbFoybHpkSEo1WDJOMWNuTnZjZ0FMUlZKU09tVnlja2xoY21jTFJWSlNPbVZ5Y2tsd1lYa3hHRUFBTnlvaVo0SUNFbkpsWjJsemRISmhkR2x2Ymw5emFHRndaUTRvZFdsdWREZ3NkV2x1ZERZMEtXZUFDMk5vWldOclgzTm9ZWEJsSzJjeEdSUkVNUmhCQUR1Q0J3UXlud1R1QkhlN2Via0ViZ1AxQ2dTQjhXVkRCSkRVK2wwRU0ra3NsQVNGVGUzZ05ob0FqZ2NBT3dCWUFLOEJzd0hDQWR3QUFRQWlRNEFFelpyV2ZqWWFBSTRCQUFFQU5ob0JTU05aSkFoTEFSVVNSRmNDQURZYUFra1ZKUkpFRjRBSGRtVnljMmx2Yms4Q1p5bE1aeUpETmhvQlNTTlpKQWhNRlJKRWdBd1ZIM3gxQUFBQUFBQUFKRlN3SWtNeEZpSUpTVGdRSWhKRU5ob0JTU05aSkFoTEFSVVNSRmNDQUVrVmdRa1NRQUFFSndTd0FFc0JPQWN5Q2hKQUFBUW5CYkFBVERnSWdkUklFa0FBQkNjRnNBQWpLbVZFU1NJSUtreG5Ga2xQQXI4b1RGQ3dJa01yU1RZYUFVa1ZnU0FTUkRZYUFra1ZKUkpFRnpZYUEwa2pXU1FJU3dFVkVrUlhBZ0FWUVFBRUp3U3dBQmErUkVsWEFBRk1JbHRGQTdFaktXVkVnQU56WVd4bFNJRVlXN0lZZ0FRZlBHR01zaHBNc2hxQkJySVFJN0lCczdRK1NWY0VBRXNCVndBRUtCSkVTUldCQ1JKRUkxTk1nUVZiVEVBQUVFWUNJNEFCQUNOUEFsUW9URkN3SWtNalJRUkxBaklIRGtFQUJ6SUhTd01KUlFSTEFZQUJDaEpCQUFoRkFVc0NFa0wvMEVzQmdBRVVFa0VBQ0VVQlN3SVRRdisvU3dHQUFSNFNRUUFJUlFGTEFneEMvNjVMQVlBQktCSkJBQWhGQVVzQ0RrTC9uVXNCZ0FFeUVrRUFDRVVCU3dJTlF2K01USUFCUEJKQkFBWkxBZzlDLzM1SUkwTC9lVFlhQVVrVmdRa1NSQ2hNVUxBaVF6WWFBVWtWSlJKRUZ4YStSRWtWRmxjR0FreFFLRXhRc0NKRE5ob0JTUlVsRWtRWE1RQWpLV1ZFZ0FaM1lXeHNaWFJsU0hJSVJCSkFBQStBQzBWU1VqcGxjbkpPWkdGdnNBQXBUR2NpUXc9PSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjEwLCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
