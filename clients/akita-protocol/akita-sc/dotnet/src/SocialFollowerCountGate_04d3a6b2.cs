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

namespace Arc56.Generated.akita_protocol.akita_sc.SocialFollowerCountGate_04d3a6b2
{


    public class SocialFollowerCountGateProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public SocialFollowerCountGateProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU29jaWFsRm9sbG93ZXJDb3VudEdhdGUiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiT3BlcmF0b3JBbmRWYWx1ZSI6W3sibmFtZSI6Im9wIiwidHlwZSI6InVpbnQ4In0seyJuYW1lIjoidmFsdWUiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2ZXJzaW9uIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJha2l0YURBTyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjb3N0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFyZ3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWdpc3RlciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtYnJQYXltZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcmdzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2hlY2siLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhbGxlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVnaXN0cnlJRCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXJncyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRSZWdpc3RyYXRpb25TaGFwZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIodWludDgsdWludDY0KSIsInN0cnVjdCI6Ik9wZXJhdG9yQW5kVmFsdWUiLCJuYW1lIjoic2hhcGUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ4LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJPcGVyYXRvckFuZFZhbHVlIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRFbnRyeSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWdpc3RyeUlEIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1cGRhdGVBa2l0YURBTyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJha2l0YURBTyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJvcFVwIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoyLCJieXRlcyI6M30sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbNDA5LDY2OF0sImVycm9yTWVzc2FnZSI6IkJveCBtdXN0IGhhdmUgdmFsdWUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NjcsNTMwXSwiZXJyb3JNZXNzYWdlIjoiQnl0ZXMgaGFzIHZhbGlkIHByZWZpeCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMxNSw0MDZdLCJlcnJvck1lc3NhZ2UiOiJFUlI6ZXJySWFyZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMyOSwzNDNdLCJlcnJvck1lc3NhZ2UiOiJFUlI6ZXJySXBheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzczMF0sImVycm9yTWVzc2FnZSI6IkVSUjplcnJOZGFvIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzExXSwiZXJyb3JNZXNzYWdlIjoiYXBwbGljYXRpb24gZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzQ3LDQyMSw2OThdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBHbG9iYWxTdGF0ZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMTIsMjU1LDI5NCwzODldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMTksMjYxLDMwMSwzOTZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzczXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIzMSwzODIsNjY0LDY5MV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ3Ml0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBib29sIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjQ5XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIHNtYXJ0X2NvbnRyYWN0cy9nYXRlcy90eXBlcy50czo6T3BlcmF0b3JBbmRWYWx1ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUzNV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBzbWFydF9jb250cmFjdHMvc29jaWFsL3R5cGVzLnRzOjpNZXRhVmFsdWUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyODhdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIHBheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTVNBd0lEUTFJRElLSUNBZ0lHSjVkR1ZqWW14dlkyc2dNSGd4TlRGbU4yTTNOU0FpWVd0cGRHRmZaR0Z2SWlBaWNtVm5hWE4wY25sZlkzVnljMjl5SWlBaVJWSlNPbVZ5Y2tsaGNtY2lJQ0pGVWxJNlpYSnlTWEJoZVNJS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWJub2diV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmMyOWphV0ZzTFdadmJHeHZkMlZ5TFdOdmRXNTBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNamdLSUNBZ0lDOHZJSEpsWjJsemRISjVRM1Z5YzI5eUlEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWg3SUdsdWFYUnBZV3hXWVd4MVpUb2dNU3dnYTJWNU9pQkhZWFJsUjJ4dlltRnNVM1JoZEdWTFpYbFNaV2RwYzNSeWVVTjFjbk52Y2lCOUtRb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWNtVm5hWE4wY25sZlkzVnljMjl5SWdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwzTnZZMmxoYkMxbWIyeHNiM2RsY2kxamIzVnVkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak14Q2lBZ0lDQXZMeUJ5WldkcGMzUnlZWFJwYjI1VGFHRndaU0E5SUVkc2IySmhiRk4wWVhSbFBITjBjbWx1Wno0b2V5QnBibWwwYVdGc1ZtRnNkV1U2SUNjb2RXbHVkRGdzZFdsdWREWTBLU2NzSUd0bGVUb2dSMkYwWlVkc2IySmhiRk4wWVhSbFMyVjVVbVZuYVhOMGNtRjBhVzl1VTJoaGNHVWdmU2tLSUNBZ0lIQjFjMmhpZVhSbGMzTWdJbkpsWjJsemRISmhkR2x2Ymw5emFHRndaU0lnSWloMWFXNTBPQ3gxYVc1ME5qUXBJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmMyOWphV0ZzTFdadmJHeHZkMlZ5TFdOdmRXNTBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNek1LSUNBZ0lDOHZJR05vWldOclUyaGhjR1VnUFNCSGJHOWlZV3hUZEdGMFpUeHpkSEpwYm1jK0tIc2dhVzVwZEdsaGJGWmhiSFZsT2lBbkp5d2dhMlY1T2lCSFlYUmxSMnh2WW1Gc1UzUmhkR1ZMWlhsRGFHVmphMU5vWVhCbElIMHBDaUFnSUNCd2RYTm9ZbmwwWlhOeklDSmphR1ZqYTE5emFHRndaU0lnSWlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENncHRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmMyOWphV0ZzTFdadmJHeHZkMlZ5TFdOdmRXNTBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNalFLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCVGIyTnBZV3hHYjJ4c2IzZGxja052ZFc1MFIyRjBaU0JsZUhSbGJtUnpJRUZyYVhSaFFtRnpaVU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKNklHMWhhVzVmWTNKbFlYUmxYMDV2VDNCQU1UTUtJQ0FnSUhCMWMyaGllWFJsYzNNZ01IZ3pNamxtTURSbFpTQXdlRGMzWW1JM09XSTVJREI0Tm1Vd00yWTFNR0VnTUhnNE1XWXhOalUwTXlBd2VEa3daRFJtWVRWa0lEQjRNek5sT1RKak9UUWdNSGc0TlRSa1pXUmxNQ0F2THlCdFpYUm9iMlFnSW1OdmMzUW9ZbmwwWlZ0ZEtYVnBiblEyTkNJc0lHMWxkR2h2WkNBaWNtVm5hWE4wWlhJb2NHRjVMR0o1ZEdWYlhTbDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0ltTm9aV05yS0dGa1pISmxjM01zZFdsdWREWTBMR0o1ZEdWYlhTbGliMjlzSWl3Z2JXVjBhRzlrSUNKblpYUlNaV2RwYzNSeVlYUnBiMjVUYUdGd1pTZ29kV2x1ZERnc2RXbHVkRFkwS1Nrb2RXbHVkRGdzZFdsdWREWTBLU0lzSUcxbGRHaHZaQ0FpWjJWMFJXNTBjbmtvZFdsdWREWTBLV0o1ZEdWYlhTSXNJRzFsZEdodlpDQWlkWEJrWVhSbFFXdHBkR0ZFUVU4b2RXbHVkRFkwS1hadmFXUWlMQ0J0WlhSb2IyUWdJbTl3VlhBb0tYWnZhV1FpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCamIzTjBJSEpsWjJsemRHVnlJR05vWldOcklHZGxkRkpsWjJsemRISmhkR2x2YmxOb1lYQmxJR2RsZEVWdWRISjVJSFZ3WkdGMFpVRnJhWFJoUkVGUElHMWhhVzVmYjNCVmNGOXliM1YwWlVBeE1Rb2dJQ0FnWlhKeUNncHRZV2x1WDI5d1ZYQmZjbTkxZEdWQU1URTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12WW1GelpTMWpiMjUwY21GamRITXZkWEJuY21Ga1pXRmliR1V1ZEhNNk16QUtJQ0FnSUM4dklHOXdWWEFvS1RvZ2RtOXBaQ0I3SUgwS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWTNKbFlYUmxYMDV2VDNCQU1UTTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDNOdlkybGhiQzFtYjJ4c2IzZGxjaTFqYjNWdWRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTBDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nVTI5amFXRnNSbTlzYkc5M1pYSkRiM1Z1ZEVkaGRHVWdaWGgwWlc1a2N5QkJhMmwwWVVKaGMyVkRiMjUwY21GamRDQjdDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IaGpaRGxoWkRZM1pTQXZMeUJ0WlhSb2IyUWdJbU55WldGMFpTaHpkSEpwYm1jc2RXbHVkRFkwS1hadmFXUWlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0JqY21WaGRHVUtJQ0FnSUdWeWNnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZjMjlqYVdGc0xXWnZiR3h2ZDJWeUxXTnZkVzUwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2xOdlkybGhiRVp2Ykd4dmQyVnlRMjkxYm5SSFlYUmxMbU55WldGMFpWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbU55WldGMFpUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12YzI5amFXRnNMV1p2Ykd4dmQyVnlMV052ZFc1MEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk56Y0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ2YmtOeVpXRjBaVG9nSjNKbGNYVnBjbVVuSUgwcENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYek1nTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5aVlYTmxMV052Ym5SeVlXTjBjeTkxY0dkeVlXUmxZV0pzWlM1MGN6b3hOQW9nSUNBZ0x5OGdkbVZ5YzJsdmJpQTlJRWRzYjJKaGJGTjBZWFJsUEhOMGNtbHVaejRvZXlCclpYazZJRWRzYjJKaGJGTjBZWFJsUzJWNVZtVnljMmx2YmlCOUtRb2dJQ0FnY0hWemFHSjVkR1Z6SUNKMlpYSnphVzl1SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXpiMk5wWVd3dFptOXNiRzkzWlhJdFkyOTFiblF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zT1FvZ0lDQWdMeThnZEdocGN5NTJaWEp6YVc5dUxuWmhiSFZsSUQwZ2RtVnljMmx2YmdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJKaGMyVXRZMjl1ZEhKaFkzUnpMM1Z3WjNKaFpHVmhZbXhsTG5Sek9qRTJDaUFnSUNBdkx5QmhhMmwwWVVSQlR5QTlJRWRzYjJKaGJGTjBZWFJsUEVGd2NHeHBZMkYwYVc5dVBpaDdJR3RsZVRvZ1IyeHZZbUZzVTNSaGRHVkxaWGxCYTJsMFlVUkJUeUI5S1FvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWVd0cGRHRmZaR0Z2SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXpiMk5wWVd3dFptOXNiRzkzWlhJdFkyOTFiblF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem80TUFvZ0lDQWdMeThnZEdocGN5NWhhMmwwWVVSQlR5NTJZV3gxWlNBOUlFRndjR3hwWTJGMGFXOXVLR0ZyYVhSaFJFRlBLUW9nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmMyOWphV0ZzTFdadmJHeHZkMlZ5TFdOdmRXNTBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOemNLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCdmJrTnlaV0YwWlRvZ0ozSmxjWFZwY21VbklIMHBDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl6YjJOcFlXd3RabTlzYkc5M1pYSXRZMjkxYm5RdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlUyOWphV0ZzUm05c2JHOTNaWEpEYjNWdWRFZGhkR1V1WTI5emRGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbU52YzNRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMM052WTJsaGJDMW1iMnhzYjNkbGNpMWpiM1Z1ZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pnMUNpQWdJQ0F2THlCamIzTjBLR0Z5WjNNNklHSjVkR1Z6S1RvZ2RXbHVkRFkwSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNeUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ2NIVnphR0o1ZEdWeklEQjRNVFV4Wmpkak56VXdNREF3TURBd01EQXdNREF5TkRVMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwzTnZZMmxoYkMxbWIyeHNiM2RsY2kxamIzVnVkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBUYjJOcFlXeEdiMnhzYjNkbGNrTnZkVzUwUjJGMFpTNXlaV2RwYzNSbGNsdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbkpsWjJsemRHVnlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5emIyTnBZV3d0Wm05c2JHOTNaWEl0WTI5MWJuUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzRPUW9nSUNBZ0x5OGdjbVZuYVhOMFpYSW9iV0p5VUdGNWJXVnVkRG9nWjNSNGJpNVFZWGx0Wlc1MFZIaHVMQ0JoY21kek9pQmllWFJsY3lrNklIVnBiblEyTkNCN0NpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQzBLSUNBZ0lHUjFjQW9nSUNBZ1ozUjRibk1nVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QndZWGtLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2RISmhibk5oWTNScGIyNGdkSGx3WlNCcGN5QndZWGtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk15QXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0JrZFhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZjMjlqYVdGc0xXWnZiR3h2ZDJWeUxXTnZkVzUwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T1RBS0lDQWdJQzh2SUd4dloyZGxaRUZ6YzJWeWRDaGhjbWR6TG14bGJtZDBhQ0E5UFQwZ1VtVm5hWE4wWlhKQ2VYUmxUR1Z1WjNSb0xDQmxjbkpKYm5aaGJHbGtRWEpuUTI5MWJuUXBDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnT1FvZ0lDQWdQVDBLSUNBZ0lHSnVlaUJ5WldkcGMzUmxjbDloWm5SbGNsOWhjM05sY25SQU13b2dJQ0FnWW5sMFpXTmZNeUF2THlBaVJWSlNPbVZ5Y2tsaGNtY2lDaUFnSUNCc2IyY0tJQ0FnSUdWeWNpQXZMeUJGVWxJNlpYSnlTV0Z5WndvS2NtVm5hWE4wWlhKZllXWjBaWEpmWVhOelpYSjBRRE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwzTnZZMmxoYkMxbWIyeHNiM2RsY2kxamIzVnVkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamt4Q2lBZ0lDQXZMeUJzYjJkblpXUkJjM05sY25Rb2JXSnlVR0Y1YldWdWRDNXlaV05sYVhabGNpQTlQVDBnUjJ4dlltRnNMbU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTXNJR1Z5Y2tsdWRtRnNhV1JRWVhsdFpXNTBLUW9nSUNBZ1pHbG5JREVLSUNBZ0lHZDBlRzV6SUZKbFkyVnBkbVZ5Q2lBZ0lDQm5iRzlpWVd3Z1EzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3dvZ0lDQWdQVDBLSUNBZ0lHSnVlaUJ5WldkcGMzUmxjbDloWm5SbGNsOWhjM05sY25SQU5Rb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaVJWSlNPbVZ5Y2tsd1lYa2lDaUFnSUNCc2IyY0tJQ0FnSUdWeWNpQXZMeUJGVWxJNlpYSnlTWEJoZVFvS2NtVm5hWE4wWlhKZllXWjBaWEpmWVhOelpYSjBRRFU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwzTnZZMmxoYkMxbWIyeHNiM2RsY2kxamIzVnVkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamt5Q2lBZ0lDQXZMeUJzYjJkblpXUkJjM05sY25Rb2JXSnlVR0Y1YldWdWRDNWhiVzkxYm5RZ1BUMDlJRTl3WlhKaGRHOXlRVzVrVm1Gc2RXVlNaV2RwYzNSeWVVMUNVaXdnWlhKeVNXNTJZV3hwWkZCaGVXMWxiblFwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQm5kSGh1Y3lCQmJXOTFiblFLSUNBZ0lIQjFjMmhwYm5RZ09UTXdNQW9nSUNBZ1BUMEtJQ0FnSUdKdWVpQnlaV2RwYzNSbGNsOWhablJsY2w5aGMzTmxjblJBTndvZ0lDQWdZbmwwWldNZ05DQXZMeUFpUlZKU09tVnlja2x3WVhraUNpQWdJQ0JzYjJjS0lDQWdJR1Z5Y2lBdkx5QkZVbEk2WlhKeVNYQmhlUW9LY21WbmFYTjBaWEpmWVdaMFpYSmZZWE56WlhKMFFEYzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDNOdlkybGhiQzFtYjJ4c2IzZGxjaTFqYjNWdWRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUXlDaUFnSUNBdkx5QmpiMjV6ZENCcFpDQTlJSFJvYVhNdWNtVm5hWE4wY25sRGRYSnpiM0l1ZG1Gc2RXVUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMM052WTJsaGJDMW1iMnhzYjNkbGNpMWpiM1Z1ZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJNENpQWdJQ0F2THlCeVpXZHBjM1J5ZVVOMWNuTnZjaUE5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b2V5QnBibWwwYVdGc1ZtRnNkV1U2SURFc0lHdGxlVG9nUjJGMFpVZHNiMkpoYkZOMFlYUmxTMlY1VW1WbmFYTjBjbmxEZFhKemIzSWdmU2tLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbkpsWjJsemRISjVYMk4xY25OdmNpSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12YzI5amFXRnNMV1p2Ykd4dmQyVnlMV052ZFc1MEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5ESUtJQ0FnSUM4dklHTnZibk4wSUdsa0lEMGdkR2hwY3k1eVpXZHBjM1J5ZVVOMWNuTnZjaTUyWVd4MVpRb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZjMjlqYVdGc0xXWnZiR3h2ZDJWeUxXTnZkVzUwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRNS0lDQWdJQzh2SUhSb2FYTXVjbVZuYVhOMGNubERkWEp6YjNJdWRtRnNkV1VnS3owZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdLd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5emIyTnBZV3d0Wm05c2JHOTNaWEl0WTI5MWJuUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lPQW9nSUNBZ0x5OGdjbVZuYVhOMGNubERkWEp6YjNJZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLSHNnYVc1cGRHbGhiRlpoYkhWbE9pQXhMQ0JyWlhrNklFZGhkR1ZIYkc5aVlXeFRkR0YwWlV0bGVWSmxaMmx6ZEhKNVEzVnljMjl5SUgwcENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKeVpXZHBjM1J5ZVY5amRYSnpiM0lpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwzTnZZMmxoYkMxbWIyeHNiM2RsY2kxamIzVnVkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalF6Q2lBZ0lDQXZMeUIwYUdsekxuSmxaMmx6ZEhKNVEzVnljMjl5TG5aaGJIVmxJQ3M5SURFS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMM052WTJsaGJDMW1iMnhzYjNkbGNpMWpiM1Z1ZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2prMUNpQWdJQ0F2THlCMGFHbHpMbkpsWjJsemRISjVLR2xrS1M1MllXeDFaU0E5SUdSbFkyOWtaVUZ5WXpROFQzQmxjbUYwYjNKQmJtUldZV3gxWlQ0b1lYSm5jeWtLSUNBZ0lHbDBiMklLSUNBZ0lHUjFjQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDNOdlkybGhiQzFtYjJ4c2IzZGxjaTFqYjNWdWRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qZzVDaUFnSUNBdkx5QnlaV2RwYzNSbGNpaHRZbkpRWVhsdFpXNTBPaUJuZEhodUxsQmhlVzFsYm5SVWVHNHNJR0Z5WjNNNklHSjVkR1Z6S1RvZ2RXbHVkRFkwSUhzS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwzTnZZMmxoYkMxbWIyeHNiM2RsY2kxamIzVnVkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBUYjJOcFlXeEdiMnhzYjNkbGNrTnZkVzUwUjJGMFpTNWphR1ZqYTF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtTm9aV05yT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXpiMk5wWVd3dFptOXNiRzkzWlhJdFkyOTFiblF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem81T1FvZ0lDQWdMeThnWTJobFkyc29ZMkZzYkdWeU9pQkJZMk52ZFc1MExDQnlaV2RwYzNSeWVVbEVPaUIxYVc1ME5qUXNJR0Z5WjNNNklHSjVkR1Z6S1RvZ1ltOXZiR1ZoYmlCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHpJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12YzI5amFXRnNMV1p2Ykd4dmQyVnlMV052ZFc1MEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UQXdDaUFnSUNBdkx5QnNiMmRuWldSQmMzTmxjblFvWVhKbmN5NXNaVzVuZEdnZ1BUMDlJREFzSUdWeWNrbHVkbUZzYVdSQmNtZERiM1Z1ZENrS0lDQWdJR3hsYmdvZ0lDQWdZbm9nWTJobFkydGZZV1owWlhKZllYTnpaWEowUURNS0lDQWdJR0o1ZEdWalh6TWdMeThnSWtWU1VqcGxjbkpKWVhKbklnb2dJQ0FnYkc5bkNpQWdJQ0JsY25JZ0x5OGdSVkpTT21WeWNrbGhjbWNLQ21Ob1pXTnJYMkZtZEdWeVgyRnpjMlZ5ZEVBek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl6YjJOcFlXd3RabTlzYkc5M1pYSXRZMjkxYm5RdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1ERUtJQ0FnSUM4dklHTnZibk4wSUhzZ2IzQXNJSFpoYkhWbElIMGdQU0JqYkc5dVpTaDBhR2x6TG5KbFoybHpkSEo1S0hKbFoybHpkSEo1U1VRcExuWmhiSFZsS1FvZ0lDQWdhWFJ2WWdvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUVKdmVDQnRkWE4wSUdoaGRtVWdkbUZzZFdVS0lDQWdJR1IxY0FvZ0lDQWdaWGgwY21GamRDQXdJREVLSUNBZ0lITjNZWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ2MzZGhjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5emIyTnBZV3d0Wm05c2JHOTNaWEl0WTI5MWJuUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFNQW9nSUNBZ0x5OGdZMjl1YzNRZ2MyOWphV0ZzSUQwZ1oyVjBRV3RwZEdGVGIyTnBZV3hCY0hCTWFYTjBLSFJvYVhNdVlXdHBkR0ZFUVU4dWRtRnNkV1VwTG5OdlkybGhiQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTlpWVhObExXTnZiblJ5WVdOMGN5OTFjR2R5WVdSbFlXSnNaUzUwY3pveE5nb2dJQ0FnTHk4Z1lXdHBkR0ZFUVU4Z1BTQkhiRzlpWVd4VGRHRjBaVHhCY0hCc2FXTmhkR2x2Ymo0b2V5QnJaWGs2SUVkc2IySmhiRk4wWVhSbFMyVjVRV3RwZEdGRVFVOGdmU2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbUZyYVhSaFgyUmhieUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmMyOWphV0ZzTFdadmJHeHZkMlZ5TFdOdmRXNTBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVEFLSUNBZ0lDOHZJR052Ym5OMElITnZZMmxoYkNBOUlHZGxkRUZyYVhSaFUyOWphV0ZzUVhCd1RHbHpkQ2gwYUdsekxtRnJhWFJoUkVGUExuWmhiSFZsS1M1emIyTnBZV3dLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Wm5WdVkzUnBiMjV6TG5Sek9qSXhNUW9nSUNBZ0x5OGdZMjl1YzNRZ1cyRndjRXhwYzNSQ2VYUmxjMTBnUFNCdmNDNUJjSEJIYkc5aVlXd3VaMlYwUlhoQ2VYUmxjeWhoYTJsMFlVUkJUeXdnUW5sMFpYTW9RV3RwZEdGRVFVOUhiRzlpWVd4VGRHRjBaVXRsZVhOQmEybDBZVk52WTJsaGJFRndjRXhwYzNRcEtRb2dJQ0FnY0hWemFHSjVkR1Z6SUNKellXd2lDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwzTnZZMmxoYkMxbWIyeHNiM2RsY2kxamIzVnVkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalV3Q2lBZ0lDQXZMeUJqYjI1emRDQnpiMk5wWVd3Z1BTQm5aWFJCYTJsMFlWTnZZMmxoYkVGd2NFeHBjM1FvZEdocGN5NWhhMmwwWVVSQlR5NTJZV3gxWlNrdWMyOWphV0ZzQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHUjFjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5emIyTnBZV3d0Wm05c2JHOTNaWEl0WTI5MWJuUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFNUzAxTkFvZ0lDQWdMeThnWTI5dWMzUWdhR0Z6VFdWMFlTQTlJR0ZpYVVOaGJHdzhkSGx3Wlc5bUlFRnJhWFJoVTI5amFXRnNMbkJ5YjNSdmRIbHdaUzVuWlhSTlpYUmhSWGhwYzNSelBpaDdDaUFnSUNBdkx5QWdJR0Z3Y0Vsa09pQnpiMk5wWVd3c0NpQWdJQ0F2THlBZ0lHRnlaM002SUZ0MWMyVnlYU3dLSUNBZ0lDOHZJSDBwTG5KbGRIVnlibFpoYkhWbENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZUdVMlpUWTNZbVJqSUM4dklHMWxkR2h2WkNBaVoyVjBUV1YwWVVWNGFYTjBjeWhoWkdSeVpYTnpLV0p2YjJ3aUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ1pHbG5JRE1LSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0J3ZFhOb2FXNTBJRFlnTHk4Z1lYQndiQW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdhWFI0YmlCTVlYTjBURzluQ2lBZ0lDQmtkWEFLSUNBZ0lHVjRkSEpoWTNRZ05DQXdDaUFnSUNCemQyRndDaUFnSUNCbGVIUnlZV04wSURBZ05Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRUo1ZEdWeklHaGhjeUIyWVd4cFpDQndjbVZtYVhnS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1ltOXZiQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdkbGRHSnBkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5emIyTnBZV3d0Wm05c2JHOTNaWEl0WTI5MWJuUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFOUW9nSUNBZ0x5OGdhV1lnS0NGb1lYTk5aWFJoS1NCN0NpQWdJQ0JpYm5vZ1kyaGxZMnRmWVdaMFpYSmZhV1pmWld4elpVQTJDaUFnSUNCd2IzQnVJRFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmMyOWphV0ZzTFdadmJHeHZkMlZ5TFdOdmRXNTBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVFlLSUNBZ0lDOHZJSEpsZEhWeWJpQm1ZV3h6WlFvZ0lDQWdhVzUwWTE4eElDOHZJREFLQ21Ob1pXTnJYMkZtZEdWeVgybHViR2x1WldSZmMyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl6YjJOcFlXd3RabTlzYkc5M1pYSXRZMjkxYm5RdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlUyOWphV0ZzUm05c2JHOTNaWEpEYjNWdWRFZGhkR1V1Wm05c2JHOTNaWEpEYjNWdWRFZGhkR1ZBTVRrNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMM052WTJsaGJDMW1iMnhzYjNkbGNpMWpiM1Z1ZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2prNUNpQWdJQ0F2THlCamFHVmpheWhqWVd4c1pYSTZJRUZqWTI5MWJuUXNJSEpsWjJsemRISjVTVVE2SUhWcGJuUTJOQ3dnWVhKbmN6b2dZbmwwWlhNcE9pQmliMjlzWldGdUlIc0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtTm9aV05yWDJGbWRHVnlYMmxtWDJWc2MyVkFOam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmMyOWphV0ZzTFdadmJHeHZkMlZ5TFdOdmRXNTBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVGt0TmpJS0lDQWdJQzh2SUdOdmJuTjBJRzFsZEdFZ1BTQmhZbWxEWVd4c1BIUjVjR1Z2WmlCQmEybDBZVk52WTJsaGJDNXdjbTkwYjNSNWNHVXVaMlYwVFdWMFlUNG9ld29nSUNBZ0x5OGdJQ0JoY0hCSlpEb2djMjlqYVdGc0xBb2dJQ0FnTHk4Z0lDQmhjbWR6T2lCYmRYTmxjbDBzQ2lBZ0lDQXZMeUI5S1M1eVpYUjFjbTVXWVd4MVpRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnM016bGxZVGN3WWlBdkx5QnRaWFJvYjJRZ0ltZGxkRTFsZEdFb1lXUmtjbVZ6Y3lrb1ltOXZiQ3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeGliMjlzTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMEtTSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQndkWE5vYVc1MElEWWdMeThnWVhCd2JBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ2FYUjRiaUJNWVhOMFRHOW5DaUFnSUNCa2RYQnVJRElLSUNBZ0lHVjRkSEpoWTNRZ05DQXdDaUFnSUNCemQyRndDaUFnSUNCbGVIUnlZV04wSURBZ05Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRUo1ZEdWeklHaGhjeUIyWVd4cFpDQndjbVZtYVhnS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQTNOQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzkwZVhCbGN5NTBjem82VFdWMFlWWmhiSFZsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwzTnZZMmxoYkMxbWIyeHNiM2RsY2kxamIzVnVkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalkxQ2lBZ0lDQXZMeUJqWVhObElFVnhkV0ZzT2lCeVpYUjFjbTRnYldWMFlTNW1iMnhzYjNkbGNrTnZkVzUwSUQwOVBTQjJZV3gxWlFvZ0lDQWdaR2xuSURFS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURCaENpQWdJQ0E5UFFvZ0lDQWdZbm9nWTJobFkydGZZV1owWlhKZmFXWmZaV3h6WlVBNENpQWdJQ0JpZFhKNUlERUtJQ0FnSUdsdWRHTmZNaUF2THlBME5Rb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUQwOUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMM052WTJsaGJDMW1iMnhzYjNkbGNpMWpiM1Z1ZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFd01nb2dJQ0FnTHk4Z2NtVjBkWEp1SUhSb2FYTXVabTlzYkc5M1pYSkRiM1Z1ZEVkaGRHVW9ZMkZzYkdWeUxDQnZjQ3dnZG1Gc2RXVXBDaUFnSUNCaUlHTm9aV05yWDJGbWRHVnlYMmx1YkdsdVpXUmZjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5emIyTnBZV3d0Wm05c2JHOTNaWEl0WTI5MWJuUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZVMjlqYVdGc1JtOXNiRzkzWlhKRGIzVnVkRWRoZEdVdVptOXNiRzkzWlhKRGIzVnVkRWRoZEdWQU1Ua0tDbU5vWldOclgyRm1kR1Z5WDJsbVgyVnNjMlZBT0RvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZjMjlqYVdGc0xXWnZiR3h2ZDJWeUxXTnZkVzUwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpZS0lDQWdJQzh2SUdOaGMyVWdUbTkwUlhGMVlXdzZJSEpsZEhWeWJpQnRaWFJoTG1admJHeHZkMlZ5UTI5MWJuUWdJVDA5SUhaaGJIVmxDaUFnSUNCa2FXY2dNUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNVFFLSUNBZ0lEMDlDaUFnSUNCaWVpQmphR1ZqYTE5aFpuUmxjbDlwWmw5bGJITmxRREV3Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR2x1ZEdOZk1pQXZMeUEwTlFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJQ0U5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwzTnZZMmxoYkMxbWIyeHNiM2RsY2kxamIzVnVkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV3TWdvZ0lDQWdMeThnY21WMGRYSnVJSFJvYVhNdVptOXNiRzkzWlhKRGIzVnVkRWRoZEdVb1kyRnNiR1Z5TENCdmNDd2dkbUZzZFdVcENpQWdJQ0JpSUdOb1pXTnJYMkZtZEdWeVgybHViR2x1WldSZmMyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl6YjJOcFlXd3RabTlzYkc5M1pYSXRZMjkxYm5RdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlUyOWphV0ZzUm05c2JHOTNaWEpEYjNWdWRFZGhkR1V1Wm05c2JHOTNaWEpEYjNWdWRFZGhkR1ZBTVRrS0NtTm9aV05yWDJGbWRHVnlYMmxtWDJWc2MyVkFNVEE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwzTnZZMmxoYkMxbWIyeHNiM2RsY2kxamIzVnVkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalkzQ2lBZ0lDQXZMeUJqWVhObElFeGxjM05VYUdGdU9pQnlaWFIxY200Z2JXVjBZUzVtYjJ4c2IzZGxja052ZFc1MElEd2dkbUZzZFdVS0lDQWdJR1JwWnlBeENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhneFpRb2dJQ0FnUFQwS0lDQWdJR0o2SUdOb1pXTnJYMkZtZEdWeVgybG1YMlZzYzJWQU1USUtJQ0FnSUdKMWNua2dNUW9nSUNBZ2FXNTBZMTh5SUM4dklEUTFDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1Bnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl6YjJOcFlXd3RabTlzYkc5M1pYSXRZMjkxYm5RdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1ESUtJQ0FnSUM4dklISmxkSFZ5YmlCMGFHbHpMbVp2Ykd4dmQyVnlRMjkxYm5SSFlYUmxLR05oYkd4bGNpd2diM0FzSUhaaGJIVmxLUW9nSUNBZ1lpQmphR1ZqYTE5aFpuUmxjbDlwYm14cGJtVmtYM050WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmMyOWphV0ZzTFdadmJHeHZkMlZ5TFdOdmRXNTBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPbE52WTJsaGJFWnZiR3h2ZDJWeVEyOTFiblJIWVhSbExtWnZiR3h2ZDJWeVEyOTFiblJIWVhSbFFERTVDZ3BqYUdWamExOWhablJsY2w5cFpsOWxiSE5sUURFeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl6YjJOcFlXd3RabTlzYkc5M1pYSXRZMjkxYm5RdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk9Bb2dJQ0FnTHk4Z1kyRnpaU0JNWlhOelZHaGhiazl5UlhGMVlXeFViem9nY21WMGRYSnVJRzFsZEdFdVptOXNiRzkzWlhKRGIzVnVkQ0E4UFNCMllXeDFaUW9nSUNBZ1pHbG5JREVLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREk0Q2lBZ0lDQTlQUW9nSUNBZ1lub2dZMmhsWTJ0ZllXWjBaWEpmYVdaZlpXeHpaVUF4TkFvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JwYm5Salh6SWdMeThnTkRVS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0ErUFFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXpiMk5wWVd3dFptOXNiRzkzWlhJdFkyOTFiblF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TURJS0lDQWdJQzh2SUhKbGRIVnliaUIwYUdsekxtWnZiR3h2ZDJWeVEyOTFiblJIWVhSbEtHTmhiR3hsY2l3Z2IzQXNJSFpoYkhWbEtRb2dJQ0FnWWlCamFHVmphMTloWm5SbGNsOXBibXhwYm1Wa1gzTnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12YzI5amFXRnNMV1p2Ykd4dmQyVnlMV052ZFc1MEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9sTnZZMmxoYkVadmJHeHZkMlZ5UTI5MWJuUkhZWFJsTG1admJHeHZkMlZ5UTI5MWJuUkhZWFJsUURFNUNncGphR1ZqYTE5aFpuUmxjbDlwWmw5bGJITmxRREUwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXpiMk5wWVd3dFptOXNiRzkzWlhJdFkyOTFiblF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yT1FvZ0lDQWdMeThnWTJGelpTQkhjbVZoZEdWeVZHaGhiam9nY21WMGRYSnVJRzFsZEdFdVptOXNiRzkzWlhKRGIzVnVkQ0ErSUhaaGJIVmxDaUFnSUNCa2FXY2dNUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNeklLSUNBZ0lEMDlDaUFnSUNCaWVpQmphR1ZqYTE5aFpuUmxjbDlwWmw5bGJITmxRREUyQ2lBZ0lDQmlkWEo1SURFS0lDQWdJR2x1ZEdOZk1pQXZMeUEwTlFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJRHdLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmMyOWphV0ZzTFdadmJHeHZkMlZ5TFdOdmRXNTBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEF5Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdkR2hwY3k1bWIyeHNiM2RsY2tOdmRXNTBSMkYwWlNoallXeHNaWElzSUc5d0xDQjJZV3gxWlNrS0lDQWdJR0lnWTJobFkydGZZV1owWlhKZmFXNXNhVzVsWkY5emJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMM052WTJsaGJDMW1iMnhzYjNkbGNpMWpiM1Z1ZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwVGIyTnBZV3hHYjJ4c2IzZGxja052ZFc1MFIyRjBaUzVtYjJ4c2IzZGxja052ZFc1MFIyRjBaVUF4T1FvS1kyaGxZMnRmWVdaMFpYSmZhV1pmWld4elpVQXhOam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmMyOWphV0ZzTFdadmJHeHZkMlZ5TFdOdmRXNTBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOekFLSUNBZ0lDOHZJR05oYzJVZ1IzSmxZWFJsY2xSb1lXNVBja1Z4ZFdGc1ZHODZJSEpsZEhWeWJpQnRaWFJoTG1admJHeHZkMlZ5UTI5MWJuUWdQajBnZG1Gc2RXVUtJQ0FnSUhOM1lYQUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VETmpDaUFnSUNBOVBRb2dJQ0FnWW5vZ1kyaGxZMnRmWVdaMFpYSmZhV1pmWld4elpVQXhPQW9nSUNBZ2FXNTBZMTh5SUM4dklEUTFDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1BEMEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12YzI5amFXRnNMV1p2Ykd4dmQyVnlMV052ZFc1MEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UQXlDaUFnSUNBdkx5QnlaWFIxY200Z2RHaHBjeTVtYjJ4c2IzZGxja052ZFc1MFIyRjBaU2hqWVd4c1pYSXNJRzl3TENCMllXeDFaU2tLSUNBZ0lHSWdZMmhsWTJ0ZllXWjBaWEpmYVc1c2FXNWxaRjl6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwzTnZZMmxoYkMxbWIyeHNiM2RsY2kxamIzVnVkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBUYjJOcFlXeEdiMnhzYjNkbGNrTnZkVzUwUjJGMFpTNW1iMnhzYjNkbGNrTnZkVzUwUjJGMFpVQXhPUW9LWTJobFkydGZZV1owWlhKZmFXWmZaV3h6WlVBeE9Eb0tJQ0FnSUhCdmNHNGdNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5emIyTnBZV3d0Wm05c2JHOTNaWEl0WTI5MWJuUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNNUW9nSUNBZ0x5OGdaR1ZtWVhWc2REb2djbVYwZFhKdUlHWmhiSE5sQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5emIyTnBZV3d0Wm05c2JHOTNaWEl0WTI5MWJuUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNRElLSUNBZ0lDOHZJSEpsZEhWeWJpQjBhR2x6TG1admJHeHZkMlZ5UTI5MWJuUkhZWFJsS0dOaGJHeGxjaXdnYjNBc0lIWmhiSFZsS1FvZ0lDQWdZaUJqYUdWamExOWhablJsY2w5cGJteHBibVZrWDNOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZjMjlqYVdGc0xXWnZiR3h2ZDJWeUxXTnZkVzUwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2xOdlkybGhiRVp2Ykd4dmQyVnlRMjkxYm5SSFlYUmxMbVp2Ykd4dmQyVnlRMjkxYm5SSFlYUmxRREU1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5emIyTnBZV3d0Wm05c2JHOTNaWEl0WTI5MWJuUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZVMjlqYVdGc1JtOXNiRzkzWlhKRGIzVnVkRWRoZEdVdVoyVjBVbVZuYVhOMGNtRjBhVzl1VTJoaGNHVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BuWlhSU1pXZHBjM1J5WVhScGIyNVRhR0Z3WlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZjMjlqYVdGc0xXWnZiR3h2ZDJWeUxXTnZkVzUwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRBMUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2djbVZoWkc5dWJIazZJSFJ5ZFdVZ2ZTa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRGtLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTkwZVhCbGN5NTBjem82VDNCbGNtRjBiM0pCYm1SV1lXeDFaUW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12YzI5amFXRnNMV1p2Ykd4dmQyVnlMV052ZFc1MEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9sTnZZMmxoYkVadmJHeHZkMlZ5UTI5MWJuUkhZWFJsTG1kbGRFVnVkSEo1VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1oyVjBSVzUwY25rNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMM052WTJsaGJDMW1iMnhzYjNkbGNpMWpiM1Z1ZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeE1Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJSEpsWVdSdmJteDVPaUIwY25WbElIMHBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0E0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5emIyTnBZV3d0Wm05c2JHOTNaWEl0WTI5MWJuUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNVElLSUNBZ0lDOHZJSEpsZEhWeWJpQmxibU52WkdWQmNtTTBLSFJvYVhNdWNtVm5hWE4wY25rb2NtVm5hWE4wY25sSlJDa3VkbUZzZFdVcENpQWdJQ0JwZEc5aUNpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaGMzTmxjblFnTHk4Z1FtOTRJRzExYzNRZ2FHRjJaU0IyWVd4MVpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl6YjJOcFlXd3RabTlzYkc5M1pYSXRZMjkxYm5RdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1UQUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZZbUZ6WlMxamIyNTBjbUZqZEhNdmRYQm5jbUZrWldGaWJHVXVkSE02T2tGcmFYUmhRbUZ6WlVOdmJuUnlZV04wTG5Wd1pHRjBaVUZyYVhSaFJFRlBXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LZFhCa1lYUmxRV3RwZEdGRVFVODZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12WW1GelpTMWpiMjUwY21GamRITXZkWEJuY21Ga1pXRmliR1V1ZEhNNk1qVUtJQ0FnSUM4dklIVndaR0YwWlVGcmFYUmhSRUZQS0dGcmFYUmhSRUZQT2lCQmNIQnNhV05oZEdsdmJpazZJSFp2YVdRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTlpWVhObExXTnZiblJ5WVdOMGN5OTFjR2R5WVdSbFlXSnNaUzUwY3pveU5nb2dJQ0FnTHk4Z2JHOW5aMlZrUVhOelpYSjBLRlI0Ymk1elpXNWtaWElnUFQwOUlIUm9hWE11WjJWMFFXdHBkR0ZFUVU5WFlXeHNaWFFvS1M1aFpHUnlaWE56TENCbGNuSk9iM1JCYTJsMFlVUmhieWtLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTlpWVhObExXTnZiblJ5WVdOMGN5OTFjR2R5WVdSbFlXSnNaUzUwY3pveE9Rb2dJQ0FnTHk4Z1kyOXVjM1FnVzNkaGJHeGxkRWxFWFNBOUlHOXdMa0Z3Y0Vkc2IySmhiQzVuWlhSRmVGVnBiblEyTkNoMGFHbHpMbUZyYVhSaFJFRlBMblpoYkhWbExDQkNlWFJsY3loQmEybDBZVVJCVDBkc2IySmhiRk4wWVhSbFMyVjVjMWRoYkd4bGRDa3BDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMkpoYzJVdFkyOXVkSEpoWTNSekwzVndaM0poWkdWaFlteGxMblJ6T2pFMkNpQWdJQ0F2THlCaGEybDBZVVJCVHlBOUlFZHNiMkpoYkZOMFlYUmxQRUZ3Y0d4cFkyRjBhVzl1UGloN0lHdGxlVG9nUjJ4dlltRnNVM1JoZEdWTFpYbEJhMmwwWVVSQlR5QjlLUW9nSUNBZ1lubDBaV05mTVNBdkx5QWlZV3RwZEdGZlpHRnZJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJKaGMyVXRZMjl1ZEhKaFkzUnpMM1Z3WjNKaFpHVmhZbXhsTG5Sek9qRTVDaUFnSUNBdkx5QmpiMjV6ZENCYmQyRnNiR1YwU1VSZElEMGdiM0F1UVhCd1IyeHZZbUZzTG1kbGRFVjRWV2x1ZERZMEtIUm9hWE11WVd0cGRHRkVRVTh1ZG1Gc2RXVXNJRUo1ZEdWektFRnJhWFJoUkVGUFIyeHZZbUZzVTNSaGRHVkxaWGx6VjJGc2JHVjBLU2tLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNCd2RYTm9ZbmwwWlhNZ0luZGhiR3hsZENJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCd2IzQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTlpWVhObExXTnZiblJ5WVdOMGN5OTFjR2R5WVdSbFlXSnNaUzUwY3pveU5nb2dJQ0FnTHk4Z2JHOW5aMlZrUVhOelpYSjBLRlI0Ymk1elpXNWtaWElnUFQwOUlIUm9hWE11WjJWMFFXdHBkR0ZFUVU5WFlXeHNaWFFvS1M1aFpHUnlaWE56TENCbGNuSk9iM1JCYTJsMFlVUmhieWtLSUNBZ0lHRndjRjl3WVhKaGJYTmZaMlYwSUVGd2NFRmtaSEpsYzNNS0lDQWdJR0Z6YzJWeWRDQXZMeUJoY0hCc2FXTmhkR2x2YmlCbGVHbHpkSE1LSUNBZ0lEMDlDaUFnSUNCaWJub2dkWEJrWVhSbFFXdHBkR0ZFUVU5ZllXWjBaWEpmWVhOelpYSjBRRE1LSUNBZ0lIQjFjMmhpZVhSbGN5QWlSVkpTT21WeWNrNWtZVzhpQ2lBZ0lDQnNiMmNLSUNBZ0lHVnljaUF2THlCRlVsSTZaWEp5VG1SaGJ3b0tkWEJrWVhSbFFXdHBkR0ZFUVU5ZllXWjBaWEpmWVhOelpYSjBRRE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlltRnpaUzFqYjI1MGNtRmpkSE12ZFhCbmNtRmtaV0ZpYkdVdWRITTZNVFlLSUNBZ0lDOHZJR0ZyYVhSaFJFRlBJRDBnUjJ4dlltRnNVM1JoZEdVOFFYQndiR2xqWVhScGIyNCtLSHNnYTJWNU9pQkhiRzlpWVd4VGRHRjBaVXRsZVVGcmFYUmhSRUZQSUgwcENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKaGEybDBZVjlrWVc4aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZZbUZ6WlMxamIyNTBjbUZqZEhNdmRYQm5jbUZrWldGaWJHVXVkSE02TWpjS0lDQWdJQzh2SUhSb2FYTXVZV3RwZEdGRVFVOHVkbUZzZFdVZ1BTQmhhMmwwWVVSQlR3b2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTlpWVhObExXTnZiblJ5WVdOMGN5OTFjR2R5WVdSbFlXSnNaUzUwY3pveU5Rb2dJQ0FnTHk4Z2RYQmtZWFJsUVd0cGRHRkVRVThvWVd0cGRHRkVRVTg2SUVGd2NHeHBZMkYwYVc5dUtUb2dkbTlwWkNCN0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFS0lDQWdJSEpsZEhWeWJnbz0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQVFBdEFpWUZCQlVmZkhVSllXdHBkR0ZmWkdGdkQzSmxaMmx6ZEhKNVgyTjFjbk52Y2d0RlVsSTZaWEp5U1dGeVp3dEZVbEk2WlhKeVNYQmhlVEVZUUFBNEtpSm5nZ0lTY21WbmFYTjBjbUYwYVc5dVgzTm9ZWEJsRGloMWFXNTBPQ3gxYVc1ME5qUXBaNElDQzJOb1pXTnJYM05vWVhCbEFHY3hHUlJFTVJoQkFEdUNCd1F5bndUdUJIZTdlYmtFYmdQMUNnU0I4V1ZEQkpEVStsMEVNK2tzbEFTRlRlM2dOaG9BamdjQVBBQlpBSzhCd3dIU0FlMEFBUUFpUTRBRXpacldmallhQUk0QkFBRUFOaG9CU1NOWkpRaExBUlVTUkZjQ0FEWWFBa2tWZ1FnU1JCZUFCM1psY25OcGIyNVBBbWNwVEdjaVF6WWFBVWtqV1NVSVRCVVNSSUFNRlI5OGRRQUFBQUFBQUNSVXNDSkRNUllpQ1VrNEVDSVNSRFlhQVVraldTVUlTd0VWRWtSWEFnQkpGWUVKRWtBQUF5dXdBRXNCT0FjeUNoSkFBQVFuQkxBQVREZ0lnZFJJRWtBQUJDY0VzQUFqS21WRVNTSUlLa3huRmtsUEFyOG9URkN3SWtNMkdnRkpGWUVnRWtRMkdnSkpGWUVJRWtRWE5ob0RTU05aSlFoTEFSVVNSRmNDQUJWQkFBTXJzQUFXdmtSSlZ3QUJUQ0piVENNcFpVU0FBM05oYkdWSUkxdEpzYklZZ0FUbTVudmNzaHBMQTdJYWdRYXlFQ095QWJPMFBrbFhCQUJNVndBRUtCSkVTUlVpRWtRalUwQUFFRVlFSTRBQkFDTlBBbFFvVEZDd0lrT3hzaGlBQkhPZXB3dXlHazhDc2hxQkJySVFJN0lCczdRK1J3SlhCQUJNVndBRUtCSkVGWUZLRWtSTEFZQUJDaEpCQUFoRkFTUmJFa0wvdUVzQmdBRVVFa0VBQ0VVQkpGc1RRdituU3dHQUFSNFNRUUFJUlFFa1d3MUMvNVpMQVlBQktCSkJBQWhGQVNSYkQwTC9oVXNCZ0FFeUVrRUFDRVVCSkZzTVF2OTBUSUFCUEJKQkFBWWtXdzVDLzJaR0FpTkMvMkEyR2dGSkZZRUpFa1FvVEZDd0lrTTJHZ0ZKRllFSUVrUVhGcjVFU1JVV1Z3WUNURkFvVEZDd0lrTTJHZ0ZKRllFSUVrUVhNUUFqS1dWRWdBWjNZV3hzWlhSbFNISUlSQkpBQUErQUMwVlNVanBsY25KT1pHRnZzQUFwVEdjaVF3PT0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjoxMCwicGF0Y2giOjEsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
