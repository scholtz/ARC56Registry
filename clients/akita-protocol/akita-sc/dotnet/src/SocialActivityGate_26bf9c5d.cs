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

namespace Arc56.Generated.akita_protocol.akita_sc.SocialActivityGate_26bf9c5d
{


    public class SocialActivityGateProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public SocialActivityGateProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU29jaWFsQWN0aXZpdHlHYXRlIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7Ik9wZXJhdG9yQW5kVmFsdWUiOlt7Im5hbWUiOiJvcCIsInR5cGUiOiJ1aW50OCJ9LHsibmFtZSI6InZhbHVlIiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidmVyc2lvbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWtpdGFEQU8iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY29zdCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcmdzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVnaXN0ZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWJyUGF5bWVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXJncyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNoZWNrIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjYWxsZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlZ2lzdHJ5SUQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFyZ3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0UmVnaXN0cmF0aW9uU2hhcGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKHVpbnQ4LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJPcGVyYXRvckFuZFZhbHVlIiwibmFtZSI6InNoYXBlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50OCx1aW50NjQpIiwic3RydWN0IjoiT3BlcmF0b3JBbmRWYWx1ZSIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0RW50cnkiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVnaXN0cnlJRCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidXBkYXRlQWtpdGFEQU8iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWtpdGFEQU8iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoib3BVcCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MiwiYnl0ZXMiOjN9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzQxMSw2ODldLCJlcnJvck1lc3NhZ2UiOiJCb3ggbXVzdCBoYXZlIHZhbHVlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDcwLDUzMl0sImVycm9yTWVzc2FnZSI6IkJ5dGVzIGhhcyB2YWxpZCBwcmVmaXgiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMTUsNDA4XSwiZXJyb3JNZXNzYWdlIjoiRVJSOmVycklhcmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMjksMzQzXSwiZXJyb3JNZXNzYWdlIjoiRVJSOmVycklwYXkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3NTBdLCJlcnJvck1lc3NhZ2UiOiJFUlI6ZXJyTmRhbyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzczMV0sImVycm9yTWVzc2FnZSI6ImFwcGxpY2F0aW9uIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM0Nyw0MjQsNzE4XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgR2xvYmFsU3RhdGUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjEyLDI1NCwyOTMsMzkwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjE5LDI2MCwzMDAsMzk3XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM3NV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMzAsMzgzLDY4NSw3MTFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NzVdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYm9vbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY3MV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBzbWFydF9jb250cmFjdHMvZ2F0ZXMvdHlwZXMudHM6Ok9wZXJhdG9yQW5kVmFsdWUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MzddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3Igc21hcnRfY29udHJhY3RzL3NvY2lhbC90eXBlcy50czo6TWV0YVZhbHVlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjg3XSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBwYXkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01DQXhJRElnT0FvZ0lDQWdZbmwwWldOaWJHOWpheUF3ZURFMU1XWTNZemMxSUNKaGEybDBZVjlrWVc4aUlDSnlaV2RwYzNSeWVWOWpkWEp6YjNJaUlDSWlJQ0pGVWxJNlpYSnlTV0Z5WnlJZ0lrVlNVanBsY25KSmNHRjVJZ29nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0p1ZWlCdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl6YjJOcFlXd3RZV04wYVhacGRIa3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lPQW9nSUNBZ0x5OGdjbVZuYVhOMGNubERkWEp6YjNJZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLSHNnYVc1cGRHbGhiRlpoYkhWbE9pQXhMQ0JyWlhrNklFZGhkR1ZIYkc5aVlXeFRkR0YwWlV0bGVWSmxaMmx6ZEhKNVEzVnljMjl5SUgwcENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKeVpXZHBjM1J5ZVY5amRYSnpiM0lpQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmMyOWphV0ZzTFdGamRHbDJhWFI1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpBS0lDQWdJQzh2SUhKbFoybHpkSEpoZEdsdmJsTm9ZWEJsSUQwZ1IyeHZZbUZzVTNSaGRHVThjM1J5YVc1blBpaDdJR2x1YVhScFlXeFdZV3gxWlRvZ0p5aDFhVzUwT0N4MWFXNTBOalFwSnl3Z2EyVjVPaUJIWVhSbFIyeHZZbUZzVTNSaGRHVkxaWGxTWldkcGMzUnlZWFJwYjI1VGFHRndaU0I5S1FvZ0lDQWdjSFZ6YUdKNWRHVnpjeUFpY21WbmFYTjBjbUYwYVc5dVgzTm9ZWEJsSWlBaUtIVnBiblE0TEhWcGJuUTJOQ2tpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXpiMk5wWVd3dFlXTjBhWFpwZEhrdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek1nb2dJQ0FnTHk4Z1kyaGxZMnRUYUdGd1pTQTlJRWRzYjJKaGJGTjBZWFJsUEhOMGNtbHVaejRvZXlCcGJtbDBhV0ZzVm1Gc2RXVTZJQ2NuTENCclpYazZJRWRoZEdWSGJHOWlZV3hUZEdGMFpVdGxlVU5vWldOclUyaGhjR1VnZlNrS0lDQWdJSEIxYzJoaWVYUmxjeUFpWTJobFkydGZjMmhoY0dVaUNpQWdJQ0JpZVhSbFkxOHpJQzh2SUNJaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb0tiV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwzTnZZMmxoYkMxaFkzUnBkbWwwZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJMENpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdVMjlqYVdGc1FXTjBhWFpwZEhsSFlYUmxJR1Y0ZEdWdVpITWdRV3RwZEdGQ1lYTmxRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW5vZ2JXRnBibDlqY21WaGRHVmZUbTlQY0VBeE13b2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VETXlPV1l3TkdWbElEQjROemRpWWpjNVlqa2dNSGcyWlRBelpqVXdZU0F3ZURneFpqRTJOVFF6SURCNE9UQmtOR1poTldRZ01IZ3pNMlU1TW1NNU5DQXdlRGcxTkdSbFpHVXdJQzh2SUcxbGRHaHZaQ0FpWTI5emRDaGllWFJsVzEwcGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKeVpXZHBjM1JsY2lod1lYa3NZbmwwWlZ0ZEtYVnBiblEyTkNJc0lHMWxkR2h2WkNBaVkyaGxZMnNvWVdSa2NtVnpjeXgxYVc1ME5qUXNZbmwwWlZ0ZEtXSnZiMndpTENCdFpYUm9iMlFnSW1kbGRGSmxaMmx6ZEhKaGRHbHZibE5vWVhCbEtDaDFhVzUwT0N4MWFXNTBOalFwS1NoMWFXNTBPQ3gxYVc1ME5qUXBJaXdnYldWMGFHOWtJQ0puWlhSRmJuUnllU2gxYVc1ME5qUXBZbmwwWlZ0ZElpd2diV1YwYUc5a0lDSjFjR1JoZEdWQmEybDBZVVJCVHloMWFXNTBOalFwZG05cFpDSXNJRzFsZEdodlpDQWliM0JWY0NncGRtOXBaQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUdOdmMzUWdjbVZuYVhOMFpYSWdZMmhsWTJzZ1oyVjBVbVZuYVhOMGNtRjBhVzl1VTJoaGNHVWdaMlYwUlc1MGNua2dkWEJrWVhSbFFXdHBkR0ZFUVU4Z2JXRnBibDl2Y0ZWd1gzSnZkWFJsUURFeENpQWdJQ0JsY25JS0NtMWhhVzVmYjNCVmNGOXliM1YwWlVBeE1Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTlpWVhObExXTnZiblJ5WVdOMGN5OTFjR2R5WVdSbFlXSnNaUzUwY3pvek1Bb2dJQ0FnTHk4Z2IzQlZjQ2dwT2lCMmIybGtJSHNnZlFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlqY21WaGRHVmZUbTlQY0VBeE16b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12YzI5amFXRnNMV0ZqZEdsMmFYUjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNalFLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCVGIyTnBZV3hCWTNScGRtbDBlVWRoZEdVZ1pYaDBaVzVrY3lCQmEybDBZVUpoYzJWRGIyNTBjbUZqZENCN0NpQWdJQ0J3ZFhOb1lubDBaWE1nTUhoalpEbGhaRFkzWlNBdkx5QnRaWFJvYjJRZ0ltTnlaV0YwWlNoemRISnBibWNzZFdsdWREWTBLWFp2YVdRaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQmpjbVZoZEdVS0lDQWdJR1Z5Y2dvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmMyOWphV0ZzTFdGamRHbDJhWFI1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2xOdlkybGhiRUZqZEdsMmFYUjVSMkYwWlM1amNtVmhkR1ZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwamNtVmhkR1U2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwzTnZZMmxoYkMxaFkzUnBkbWwwZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pnekNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2diMjVEY21WaGRHVTZJQ2R5WlhGMWFYSmxKeUI5S1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5aVlYTmxMV052Ym5SeVlXTjBjeTkxY0dkeVlXUmxZV0pzWlM1MGN6b3hOQW9nSUNBZ0x5OGdkbVZ5YzJsdmJpQTlJRWRzYjJKaGJGTjBZWFJsUEhOMGNtbHVaejRvZXlCclpYazZJRWRzYjJKaGJGTjBZWFJsUzJWNVZtVnljMmx2YmlCOUtRb2dJQ0FnY0hWemFHSjVkR1Z6SUNKMlpYSnphVzl1SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXpiMk5wWVd3dFlXTjBhWFpwZEhrdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNE5Rb2dJQ0FnTHk4Z2RHaHBjeTUyWlhKemFXOXVMblpoYkhWbElEMGdkbVZ5YzJsdmJnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwySmhjMlV0WTI5dWRISmhZM1J6TDNWd1ozSmhaR1ZoWW14bExuUnpPakUyQ2lBZ0lDQXZMeUJoYTJsMFlVUkJUeUE5SUVkc2IySmhiRk4wWVhSbFBFRndjR3hwWTJGMGFXOXVQaWg3SUd0bGVUb2dSMnh2WW1Gc1UzUmhkR1ZMWlhsQmEybDBZVVJCVHlCOUtRb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVlXdHBkR0ZmWkdGdklnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl6YjJOcFlXd3RZV04wYVhacGRIa3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzROZ29nSUNBZ0x5OGdkR2hwY3k1aGEybDBZVVJCVHk1MllXeDFaU0E5SUVGd2NHeHBZMkYwYVc5dUtHRnJhWFJoUkVGUEtRb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12YzI5amFXRnNMV0ZqZEdsMmFYUjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPRE1LSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCdmJrTnlaV0YwWlRvZ0ozSmxjWFZwY21VbklIMHBDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl6YjJOcFlXd3RZV04wYVhacGRIa3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZVMjlqYVdGc1FXTjBhWFpwZEhsSFlYUmxMbU52YzNSYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGpiM04wT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXpiMk5wWVd3dFlXTjBhWFpwZEhrdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNU1Rb2dJQ0FnTHk4Z1kyOXpkQ2hoY21kek9pQmllWFJsY3lrNklIVnBiblEyTkNCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdjM2RoY0FvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREUxTVdZM1l6YzFNREF3TURBd01EQXdNREF3TWpRMU5Bb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXpiMk5wWVd3dFlXTjBhWFpwZEhrdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlUyOWphV0ZzUVdOMGFYWnBkSGxIWVhSbExuSmxaMmx6ZEdWeVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjbVZuYVhOMFpYSTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDNOdlkybGhiQzFoWTNScGRtbDBlUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamsxQ2lBZ0lDQXZMeUJ5WldkcGMzUmxjaWh0WW5KUVlYbHRaVzUwT2lCbmRIaHVMbEJoZVcxbGJuUlVlRzRzSUdGeVozTTZJR0o1ZEdWektUb2dkV2x1ZERZMElIc0tJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaSFZ3Q2lBZ0lDQm5kSGh1Y3lCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4eElDOHZJSEJoZVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QjBjbUZ1YzJGamRHbHZiaUIwZVhCbElHbHpJSEJoZVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUdSMWNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl6YjJOcFlXd3RZV04wYVhacGRIa3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzVOZ29nSUNBZ0x5OGdiRzluWjJWa1FYTnpaWEowS0dGeVozTXViR1Z1WjNSb0lEMDlQU0JTWldkcGMzUmxja0o1ZEdWTVpXNW5kR2dzSUdWeWNrbHVkbUZzYVdSQmNtZERiM1Z1ZENrS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQTVDaUFnSUNBOVBRb2dJQ0FnWW01NklISmxaMmx6ZEdWeVgyRm1kR1Z5WDJGemMyVnlkRUF6Q2lBZ0lDQmllWFJsWXlBMElDOHZJQ0pGVWxJNlpYSnlTV0Z5WnlJS0lDQWdJR3h2WndvZ0lDQWdaWEp5SUM4dklFVlNVanBsY25KSllYSm5DZ3B5WldkcGMzUmxjbDloWm5SbGNsOWhjM05sY25SQU16b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12YzI5amFXRnNMV0ZqZEdsMmFYUjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPVGNLSUNBZ0lDOHZJR3h2WjJkbFpFRnpjMlZ5ZENodFluSlFZWGx0Wlc1MExuSmxZMlZwZG1WeUlEMDlQU0JIYkc5aVlXd3VZM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN5d2daWEp5U1c1MllXeHBaRkJoZVcxbGJuUXBDaUFnSUNCa2FXY2dNUW9nSUNBZ1ozUjRibk1nVW1WalpXbDJaWElLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQTlQUW9nSUNBZ1ltNTZJSEpsWjJsemRHVnlYMkZtZEdWeVgyRnpjMlZ5ZEVBMUNpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKRlVsSTZaWEp5U1hCaGVTSUtJQ0FnSUd4dlp3b2dJQ0FnWlhKeUlDOHZJRVZTVWpwbGNuSkpjR0Y1Q2dweVpXZHBjM1JsY2w5aFpuUmxjbDloYzNObGNuUkFOVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmMyOWphV0ZzTFdGamRHbDJhWFI1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T1RnS0lDQWdJQzh2SUd4dloyZGxaRUZ6YzJWeWRDaHRZbkpRWVhsdFpXNTBMbUZ0YjNWdWRDQTlQVDBnVDNCbGNtRjBiM0pCYm1SV1lXeDFaVkpsWjJsemRISjVUVUpTTENCbGNuSkpiblpoYkdsa1VHRjViV1Z1ZENrS0lDQWdJSE4zWVhBS0lDQWdJR2QwZUc1eklFRnRiM1Z1ZEFvZ0lDQWdjSFZ6YUdsdWRDQTVNekF3Q2lBZ0lDQTlQUW9nSUNBZ1ltNTZJSEpsWjJsemRHVnlYMkZtZEdWeVgyRnpjMlZ5ZEVBM0NpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKRlVsSTZaWEp5U1hCaGVTSUtJQ0FnSUd4dlp3b2dJQ0FnWlhKeUlDOHZJRVZTVWpwbGNuSkpjR0Y1Q2dweVpXZHBjM1JsY2w5aFpuUmxjbDloYzNObGNuUkFOem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmMyOWphV0ZzTFdGamRHbDJhWFI1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRFS0lDQWdJQzh2SUdOdmJuTjBJR2xrSUQwZ2RHaHBjeTV5WldkcGMzUnllVU4xY25OdmNpNTJZV3gxWlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmMyOWphV0ZzTFdGamRHbDJhWFI1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpnS0lDQWdJQzh2SUhKbFoybHpkSEo1UTNWeWMyOXlJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGloN0lHbHVhWFJwWVd4V1lXeDFaVG9nTVN3Z2EyVjVPaUJIWVhSbFIyeHZZbUZzVTNSaGRHVkxaWGxTWldkcGMzUnllVU4xY25OdmNpQjlLUW9nSUNBZ1lubDBaV05mTWlBdkx5QWljbVZuYVhOMGNubGZZM1Z5YzI5eUlnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl6YjJOcFlXd3RZV04wYVhacGRIa3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBNUW9nSUNBZ0x5OGdZMjl1YzNRZ2FXUWdQU0IwYUdsekxuSmxaMmx6ZEhKNVEzVnljMjl5TG5aaGJIVmxDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl6YjJOcFlXd3RZV04wYVhacGRIa3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBNZ29nSUNBZ0x5OGdkR2hwY3k1eVpXZHBjM1J5ZVVOMWNuTnZjaTUyWVd4MVpTQXJQU0F4Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBckNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMM052WTJsaGJDMWhZM1JwZG1sMGVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTRDaUFnSUNBdkx5QnlaV2RwYzNSeWVVTjFjbk52Y2lBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9leUJwYm1sMGFXRnNWbUZzZFdVNklERXNJR3RsZVRvZ1IyRjBaVWRzYjJKaGJGTjBZWFJsUzJWNVVtVm5hWE4wY25sRGRYSnpiM0lnZlNrS0lDQWdJR0o1ZEdWalh6SWdMeThnSW5KbFoybHpkSEo1WDJOMWNuTnZjaUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmMyOWphV0ZzTFdGamRHbDJhWFI1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRJS0lDQWdJQzh2SUhSb2FYTXVjbVZuYVhOMGNubERkWEp6YjNJdWRtRnNkV1VnS3owZ01Rb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12YzI5amFXRnNMV0ZqZEdsMmFYUjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEF4Q2lBZ0lDQXZMeUIwYUdsekxuSmxaMmx6ZEhKNUtHbGtLUzUyWVd4MVpTQTlJR1JsWTI5a1pVRnlZelE4VDNCbGNtRjBiM0pCYm1SV1lXeDFaVDRvWVhKbmN5a0tJQ0FnSUdsMGIySUtJQ0FnSUdSMWNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMM052WTJsaGJDMWhZM1JwZG1sMGVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qazFDaUFnSUNBdkx5QnlaV2RwYzNSbGNpaHRZbkpRWVhsdFpXNTBPaUJuZEhodUxsQmhlVzFsYm5SVWVHNHNJR0Z5WjNNNklHSjVkR1Z6S1RvZ2RXbHVkRFkwSUhzS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwzTnZZMmxoYkMxaFkzUnBkbWwwZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwVGIyTnBZV3hCWTNScGRtbDBlVWRoZEdVdVkyaGxZMnRiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwamFHVmphem9LSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJaUlLSUNBZ0lHUjFjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5emIyTnBZV3d0WVdOMGFYWnBkSGt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TURVS0lDQWdJQzh2SUdOb1pXTnJLR05oYkd4bGNqb2dRV05qYjNWdWRDd2djbVZuYVhOMGNubEpSRG9nZFdsdWREWTBMQ0JoY21kek9pQmllWFJsY3lrNklHSnZiMnhsWVc0Z2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmMyOWphV0ZzTFdGamRHbDJhWFI1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRBMkNpQWdJQ0F2THlCc2IyZG5aV1JCYzNObGNuUW9ZWEpuY3k1c1pXNW5kR2dnUFQwOUlEQXNJR1Z5Y2tsdWRtRnNhV1JCY21kRGIzVnVkQ2tLSUNBZ0lHeGxiZ29nSUNBZ1lub2dZMmhsWTJ0ZllXWjBaWEpmWVhOelpYSjBRRE1LSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJa1ZTVWpwbGNuSkpZWEpuSWdvZ0lDQWdiRzluQ2lBZ0lDQmxjbklnTHk4Z1JWSlNPbVZ5Y2tsaGNtY0tDbU5vWldOclgyRm1kR1Z5WDJGemMyVnlkRUF6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXpiMk5wWVd3dFlXTjBhWFpwZEhrdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1EY0tJQ0FnSUM4dklHTnZibk4wSUhzZ2IzQXNJSFpoYkhWbElIMGdQU0JqYkc5dVpTaDBhR2x6TG5KbFoybHpkSEo1S0hKbFoybHpkSEo1U1VRcExuWmhiSFZsS1FvZ0lDQWdhWFJ2WWdvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUVKdmVDQnRkWE4wSUdoaGRtVWdkbUZzZFdVS0lDQWdJR1IxY0FvZ0lDQWdaWGgwY21GamRDQXdJREVLSUNBZ0lITjNZWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1luVnllU0F6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwzTnZZMmxoYkMxaFkzUnBkbWwwZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVeENpQWdJQ0F2THlCamIyNXpkQ0J6YjJOcFlXd2dQU0JuWlhSQmEybDBZVk52WTJsaGJFRndjRXhwYzNRb2RHaHBjeTVoYTJsMFlVUkJUeTUyWVd4MVpTa3VjMjlqYVdGc0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwySmhjMlV0WTI5dWRISmhZM1J6TDNWd1ozSmhaR1ZoWW14bExuUnpPakUyQ2lBZ0lDQXZMeUJoYTJsMFlVUkJUeUE5SUVkc2IySmhiRk4wWVhSbFBFRndjR3hwWTJGMGFXOXVQaWg3SUd0bGVUb2dSMnh2WW1Gc1UzUmhkR1ZMWlhsQmEybDBZVVJCVHlCOUtRb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVlXdHBkR0ZmWkdGdklnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl6YjJOcFlXd3RZV04wYVhacGRIa3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFNUW9nSUNBZ0x5OGdZMjl1YzNRZ2MyOWphV0ZzSUQwZ1oyVjBRV3RwZEdGVGIyTnBZV3hCY0hCTWFYTjBLSFJvYVhNdVlXdHBkR0ZFUVU4dWRtRnNkV1VwTG5OdlkybGhiQW9nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTltZFc1amRHbHZibk11ZEhNNk1qRXhDaUFnSUNBdkx5QmpiMjV6ZENCYllYQndUR2x6ZEVKNWRHVnpYU0E5SUc5d0xrRndjRWRzYjJKaGJDNW5aWFJGZUVKNWRHVnpLR0ZyYVhSaFJFRlBMQ0JDZVhSbGN5aEJhMmwwWVVSQlQwZHNiMkpoYkZOMFlYUmxTMlY1YzBGcmFYUmhVMjlqYVdGc1FYQndUR2x6ZENrcENpQWdJQ0J3ZFhOb1lubDBaWE1nSW5OaGJDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQndiM0FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmMyOWphV0ZzTFdGamRHbDJhWFI1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRFS0lDQWdJQzh2SUdOdmJuTjBJSE52WTJsaGJDQTlJR2RsZEVGcmFYUmhVMjlqYVdGc1FYQndUR2x6ZENoMGFHbHpMbUZyYVhSaFJFRlBMblpoYkhWbEtTNXpiMk5wWVd3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdaSFZ3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwzTnZZMmxoYkMxaFkzUnBkbWwwZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVeUxUVTFDaUFnSUNBdkx5QmpiMjV6ZENCb1lYTk5aWFJoSUQwZ1lXSnBRMkZzYkR4MGVYQmxiMllnUVd0cGRHRlRiMk5wWVd3dWNISnZkRzkwZVhCbExtZGxkRTFsZEdGRmVHbHpkSE0rS0hzS0lDQWdJQzh2SUNBZ1lYQndTV1E2SUhOdlkybGhiQ3dLSUNBZ0lDOHZJQ0FnWVhKbmN6b2dXM1Z6WlhKZExBb2dJQ0FnTHk4Z2ZTa3VjbVYwZFhKdVZtRnNkV1VLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRaVFpsTmpkaVpHTWdMeThnYldWMGFHOWtJQ0puWlhSTlpYUmhSWGhwYzNSektHRmtaSEpsYzNNcFltOXZiQ0lLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JrYVdjZ01nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lIQjFjMmhwYm5RZ05pQXZMeUJoY0hCc0NpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCcGRIaHVJRXhoYzNSTWIyY0tJQ0FnSUdSMWNBb2dJQ0FnWlhoMGNtRmpkQ0EwSURBS0lDQWdJSE4zWVhBS0lDQWdJR1Y0ZEhKaFkzUWdNQ0EwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1FubDBaWE1nYUdGeklIWmhiR2xrSUhCeVpXWnBlQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJpYjI5c0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaMlYwWW1sMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMM052WTJsaGJDMWhZM1JwZG1sMGVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVTJDaUFnSUNBdkx5QnBaaUFvSVdoaGMwMWxkR0VwSUhzS0lDQWdJR0p1ZWlCamFHVmphMTloWm5SbGNsOXBabDlsYkhObFFEWUtJQ0FnSUhCdmNHNGdNd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5emIyTnBZV3d0WVdOMGFYWnBkSGt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xTndvZ0lDQWdMeThnY21WMGRYSnVJR1poYkhObENpQWdJQ0JwYm5Salh6QWdMeThnTUFvS1kyaGxZMnRmWVdaMFpYSmZhVzVzYVc1bFpGOXpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDNOdlkybGhiQzFoWTNScGRtbDBlUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBUYjJOcFlXeEJZM1JwZG1sMGVVZGhkR1V1WVdOMGFYWnBkSGxIWVhSbFFESXhPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5emIyTnBZV3d0WVdOMGFYWnBkSGt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TURVS0lDQWdJQzh2SUdOb1pXTnJLR05oYkd4bGNqb2dRV05qYjNWdWRDd2djbVZuYVhOMGNubEpSRG9nZFdsdWREWTBMQ0JoY21kek9pQmllWFJsY3lrNklHSnZiMnhsWVc0Z2V3b2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxkR0pwZEFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS1kyaGxZMnRmWVdaMFpYSmZhV1pmWld4elpVQTJPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5emIyTnBZV3d0WVdOMGFYWnBkSGt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTUMwMk13b2dJQ0FnTHk4Z1kyOXVjM1FnZXlCc1lYTjBRV04wYVhabElIMGdQU0JoWW1sRFlXeHNQSFI1Y0dWdlppQkJhMmwwWVZOdlkybGhiQzV3Y205MGIzUjVjR1V1WjJWMFRXVjBZVDRvZXdvZ0lDQWdMeThnSUNCaGNIQkpaRG9nYzI5amFXRnNMQW9nSUNBZ0x5OGdJQ0JoY21kek9pQmJkWE5sY2wwc0NpQWdJQ0F2THlCOUtTNXlaWFIxY201V1lXeDFaUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzNNemxsWVRjd1lpQXZMeUJ0WlhSb2IyUWdJbWRsZEUxbGRHRW9ZV1JrY21WemN5a29ZbTl2YkN4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3hpYjI5c0xIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBLU0lLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2NIVnphR2x1ZENBMklDOHZJR0Z3Y0d3S0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUdsMGVHNGdUR0Z6ZEV4dlp3b2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJRFFnTUFvZ0lDQWdaR2xuSURFS0lDQWdJR1Y0ZEhKaFkzUWdNQ0EwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1FubDBaWE1nYUdGeklIWmhiR2xrSUhCeVpXWnBlQW9nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURjMENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wzUjVjR1Z6TG5Sek9qcE5aWFJoVm1Gc2RXVUtJQ0FnSUhCMWMyaHBiblFnTWprS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMM052WTJsaGJDMWhZM1JwZG1sMGVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWTFDaUFnSUNBdkx5QnNaWFFnYzJsdVkyVTZJSFZwYm5RMk5DQTlJREFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWRYSjVJRFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmMyOWphV0ZzTFdGamRHbDJhWFI1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpZS0lDQWdJQzh2SUdsbUlDaDJZV3gxWlNBOFBTQkhiRzlpWVd3dWJHRjBaWE4wVkdsdFpYTjBZVzF3S1NCN0NpQWdJQ0JrYVdjZ01nb2dJQ0FnWjJ4dlltRnNJRXhoZEdWemRGUnBiV1Z6ZEdGdGNBb2dJQ0FnUEQwS0lDQWdJR0o2SUdOb1pXTnJYMkZtZEdWeVgybG1YMlZzYzJWQU9Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl6YjJOcFlXd3RZV04wYVhacGRIa3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJOd29nSUNBZ0x5OGdjMmx1WTJVZ1BTQkhiRzlpWVd3dWJHRjBaWE4wVkdsdFpYTjBZVzF3SUMwZ2RtRnNkV1VLSUNBZ0lHZHNiMkpoYkNCTVlYUmxjM1JVYVcxbGMzUmhiWEFLSUNBZ0lHUnBaeUF6Q2lBZ0lDQXRDaUFnSUNCaWRYSjVJRFFLQ21Ob1pXTnJYMkZtZEdWeVgybG1YMlZzYzJWQU9Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12YzI5amFXRnNMV0ZqZEdsMmFYUjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOekVLSUNBZ0lDOHZJR05oYzJVZ1JYRjFZV3c2SUhKbGRIVnliaUJzWVhOMFFXTjBhWFpsSUQwOVBTQnphVzVqWlFvZ0lDQWdaR2xuSURFS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURCaENpQWdJQ0E5UFFvZ0lDQWdZbm9nWTJobFkydGZZV1owWlhKZmFXWmZaV3h6WlVBeE1Bb2dJQ0FnWW5WeWVTQXhDaUFnSUNCa2FXY2dNZ29nSUNBZ1BUMEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12YzI5amFXRnNMV0ZqZEdsMmFYUjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEE0Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdkR2hwY3k1aFkzUnBkbWwwZVVkaGRHVW9ZMkZzYkdWeUxDQnZjQ3dnZG1Gc2RXVXBDaUFnSUNCaUlHTm9aV05yWDJGbWRHVnlYMmx1YkdsdVpXUmZjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5emIyTnBZV3d0WVdOMGFYWnBkSGt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VTI5amFXRnNRV04wYVhacGRIbEhZWFJsTG1GamRHbDJhWFI1UjJGMFpVQXlNUW9LWTJobFkydGZZV1owWlhKZmFXWmZaV3h6WlVBeE1Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12YzI5amFXRnNMV0ZqZEdsMmFYUjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOeklLSUNBZ0lDOHZJR05oYzJVZ1RtOTBSWEYxWVd3NklISmxkSFZ5YmlCc1lYTjBRV04wYVhabElDRTlQU0J6YVc1alpRb2dJQ0FnWkdsbklERUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VERTBDaUFnSUNBOVBRb2dJQ0FnWW5vZ1kyaGxZMnRmWVdaMFpYSmZhV1pmWld4elpVQXhNZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmthV2NnTWdvZ0lDQWdJVDBLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmMyOWphV0ZzTFdGamRHbDJhWFI1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRBNENpQWdJQ0F2THlCeVpYUjFjbTRnZEdocGN5NWhZM1JwZG1sMGVVZGhkR1VvWTJGc2JHVnlMQ0J2Y0N3Z2RtRnNkV1VwQ2lBZ0lDQmlJR05vWldOclgyRm1kR1Z5WDJsdWJHbHVaV1JmYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXpiMk5wWVd3dFlXTjBhWFpwZEhrdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlUyOWphV0ZzUVdOMGFYWnBkSGxIWVhSbExtRmpkR2wyYVhSNVIyRjBaVUF5TVFvS1kyaGxZMnRmWVdaMFpYSmZhV1pmWld4elpVQXhNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmMyOWphV0ZzTFdGamRHbDJhWFI1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnpNS0lDQWdJQzh2SUdOaGMyVWdUR1Z6YzFSb1lXNDZJSEpsZEhWeWJpQnNZWE4wUVdOMGFYWmxJRHdnYzJsdVkyVUtJQ0FnSUdScFp5QXhDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3haUW9nSUNBZ1BUMEtJQ0FnSUdKNklHTm9aV05yWDJGbWRHVnlYMmxtWDJWc2MyVkFNVFFLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdaR2xuSURJS0lDQWdJRHdLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmMyOWphV0ZzTFdGamRHbDJhWFI1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRBNENpQWdJQ0F2THlCeVpYUjFjbTRnZEdocGN5NWhZM1JwZG1sMGVVZGhkR1VvWTJGc2JHVnlMQ0J2Y0N3Z2RtRnNkV1VwQ2lBZ0lDQmlJR05vWldOclgyRm1kR1Z5WDJsdWJHbHVaV1JmYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXpiMk5wWVd3dFlXTjBhWFpwZEhrdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlUyOWphV0ZzUVdOMGFYWnBkSGxIWVhSbExtRmpkR2wyYVhSNVIyRjBaVUF5TVFvS1kyaGxZMnRmWVdaMFpYSmZhV1pmWld4elpVQXhORG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmMyOWphV0ZzTFdGamRHbDJhWFI1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnpRS0lDQWdJQzh2SUdOaGMyVWdUR1Z6YzFSb1lXNVBja1Z4ZFdGc1ZHODZJSEpsZEhWeWJpQnNZWE4wUVdOMGFYWmxJRHc5SUhOcGJtTmxDaUFnSUNCa2FXY2dNUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNamdLSUNBZ0lEMDlDaUFnSUNCaWVpQmphR1ZqYTE5aFpuUmxjbDlwWmw5bGJITmxRREUyQ2lBZ0lDQmlkWEo1SURFS0lDQWdJR1JwWnlBeUNpQWdJQ0E4UFFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXpiMk5wWVd3dFlXTjBhWFpwZEhrdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1EZ0tJQ0FnSUM4dklISmxkSFZ5YmlCMGFHbHpMbUZqZEdsMmFYUjVSMkYwWlNoallXeHNaWElzSUc5d0xDQjJZV3gxWlNrS0lDQWdJR0lnWTJobFkydGZZV1owWlhKZmFXNXNhVzVsWkY5emJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMM052WTJsaGJDMWhZM1JwZG1sMGVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcFRiMk5wWVd4QlkzUnBkbWwwZVVkaGRHVXVZV04wYVhacGRIbEhZWFJsUURJeENncGphR1ZqYTE5aFpuUmxjbDlwWmw5bGJITmxRREUyT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXpiMk5wWVd3dFlXTjBhWFpwZEhrdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM05Rb2dJQ0FnTHk4Z1kyRnpaU0JIY21WaGRHVnlWR2hoYmpvZ2NtVjBkWEp1SUd4aGMzUkJZM1JwZG1VZ1BpQnphVzVqWlFvZ0lDQWdaR2xuSURFS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURNeUNpQWdJQ0E5UFFvZ0lDQWdZbm9nWTJobFkydGZZV1owWlhKZmFXWmZaV3h6WlVBeE9Bb2dJQ0FnWW5WeWVTQXhDaUFnSUNCa2FXY2dNZ29nSUNBZ1Bnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl6YjJOcFlXd3RZV04wYVhacGRIa3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNRGdLSUNBZ0lDOHZJSEpsZEhWeWJpQjBhR2x6TG1GamRHbDJhWFI1UjJGMFpTaGpZV3hzWlhJc0lHOXdMQ0IyWVd4MVpTa0tJQ0FnSUdJZ1kyaGxZMnRmWVdaMFpYSmZhVzVzYVc1bFpGOXpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDNOdlkybGhiQzFoWTNScGRtbDBlUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBUYjJOcFlXeEJZM1JwZG1sMGVVZGhkR1V1WVdOMGFYWnBkSGxIWVhSbFFESXhDZ3BqYUdWamExOWhablJsY2w5cFpsOWxiSE5sUURFNE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl6YjJOcFlXd3RZV04wYVhacGRIa3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNOZ29nSUNBZ0x5OGdZMkZ6WlNCSGNtVmhkR1Z5VkdoaGJrOXlSWEYxWVd4VWJ6b2djbVYwZFhKdUlHeGhjM1JCWTNScGRtVWdQajBnYzJsdVkyVUtJQ0FnSUhOM1lYQUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VETmpDaUFnSUNBOVBRb2dJQ0FnWW5vZ1kyaGxZMnRmWVdaMFpYSmZhV1pmWld4elpVQXlNQW9nSUNBZ1pHbG5JRElLSUNBZ0lENDlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDNOdlkybGhiQzFoWTNScGRtbDBlUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV3T0FvZ0lDQWdMeThnY21WMGRYSnVJSFJvYVhNdVlXTjBhWFpwZEhsSFlYUmxLR05oYkd4bGNpd2diM0FzSUhaaGJIVmxLUW9nSUNBZ1lpQmphR1ZqYTE5aFpuUmxjbDlwYm14cGJtVmtYM050WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmMyOWphV0ZzTFdGamRHbDJhWFI1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2xOdlkybGhiRUZqZEdsMmFYUjVSMkYwWlM1aFkzUnBkbWwwZVVkaGRHVkFNakVLQ21Ob1pXTnJYMkZtZEdWeVgybG1YMlZzYzJWQU1qQTZDaUFnSUNCd2IzQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12YzI5amFXRnNMV0ZqZEdsMmFYUjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOemNLSUNBZ0lDOHZJR1JsWm1GMWJIUTZJSEpsZEhWeWJpQm1ZV3h6WlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmMyOWphV0ZzTFdGamRHbDJhWFI1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRBNENpQWdJQ0F2THlCeVpYUjFjbTRnZEdocGN5NWhZM1JwZG1sMGVVZGhkR1VvWTJGc2JHVnlMQ0J2Y0N3Z2RtRnNkV1VwQ2lBZ0lDQmlJR05vWldOclgyRm1kR1Z5WDJsdWJHbHVaV1JmYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXpiMk5wWVd3dFlXTjBhWFpwZEhrdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlUyOWphV0ZzUVdOMGFYWnBkSGxIWVhSbExtRmpkR2wyYVhSNVIyRjBaVUF5TVFvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmMyOWphV0ZzTFdGamRHbDJhWFI1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2xOdlkybGhiRUZqZEdsMmFYUjVSMkYwWlM1blpYUlNaV2RwYzNSeVlYUnBiMjVUYUdGd1pWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWRsZEZKbFoybHpkSEpoZEdsdmJsTm9ZWEJsT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXpiMk5wWVd3dFlXTjBhWFpwZEhrdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1URUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnT1FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNSNWNHVnpMblJ6T2pwUGNHVnlZWFJ2Y2tGdVpGWmhiSFZsQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5emIyTnBZV3d0WVdOMGFYWnBkSGt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VTI5amFXRnNRV04wYVhacGRIbEhZWFJsTG1kbGRFVnVkSEo1VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1oyVjBSVzUwY25rNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMM052WTJsaGJDMWhZM1JwZG1sMGVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXhOZ29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUhKbFlXUnZibXg1T2lCMGNuVmxJSDBwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMM052WTJsaGJDMWhZM1JwZG1sMGVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXhPQW9nSUNBZ0x5OGdjbVYwZFhKdUlHVnVZMjlrWlVGeVl6UW9kR2hwY3k1eVpXZHBjM1J5ZVNoeVpXZHBjM1J5ZVVsRUtTNTJZV3gxWlNrS0lDQWdJR2wwYjJJS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdGemMyVnlkQ0F2THlCQ2IzZ2diWFZ6ZENCb1lYWmxJSFpoYkhWbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMM052WTJsaGJDMWhZM1JwZG1sMGVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXhOZ29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUhKbFlXUnZibXg1T2lCMGNuVmxJSDBwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTlpWVhObExXTnZiblJ5WVdOMGN5OTFjR2R5WVdSbFlXSnNaUzUwY3pvNlFXdHBkR0ZDWVhObFEyOXVkSEpoWTNRdWRYQmtZWFJsUVd0cGRHRkVRVTliY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMWNHUmhkR1ZCYTJsMFlVUkJUem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5aVlYTmxMV052Ym5SeVlXTjBjeTkxY0dkeVlXUmxZV0pzWlM1MGN6b3lOUW9nSUNBZ0x5OGdkWEJrWVhSbFFXdHBkR0ZFUVU4b1lXdHBkR0ZFUVU4NklFRndjR3hwWTJGMGFXOXVLVG9nZG05cFpDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlltRnpaUzFqYjI1MGNtRmpkSE12ZFhCbmNtRmtaV0ZpYkdVdWRITTZNallLSUNBZ0lDOHZJR3h2WjJkbFpFRnpjMlZ5ZENoVWVHNHVjMlZ1WkdWeUlEMDlQU0IwYUdsekxtZGxkRUZyYVhSaFJFRlBWMkZzYkdWMEtDa3VZV1JrY21WemN5d2daWEp5VG05MFFXdHBkR0ZFWVc4cENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlltRnpaUzFqYjI1MGNtRmpkSE12ZFhCbmNtRmtaV0ZpYkdVdWRITTZNVGtLSUNBZ0lDOHZJR052Ym5OMElGdDNZV3hzWlhSSlJGMGdQU0J2Y0M1QmNIQkhiRzlpWVd3dVoyVjBSWGhWYVc1ME5qUW9kR2hwY3k1aGEybDBZVVJCVHk1MllXeDFaU3dnUW5sMFpYTW9RV3RwZEdGRVFVOUhiRzlpWVd4VGRHRjBaVXRsZVhOWFlXeHNaWFFwS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5aVlYTmxMV052Ym5SeVlXTjBjeTkxY0dkeVlXUmxZV0pzWlM1MGN6b3hOZ29nSUNBZ0x5OGdZV3RwZEdGRVFVOGdQU0JIYkc5aVlXeFRkR0YwWlR4QmNIQnNhV05oZEdsdmJqNG9leUJyWlhrNklFZHNiMkpoYkZOMFlYUmxTMlY1UVd0cGRHRkVRVThnZlNrS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1GcmFYUmhYMlJoYnlJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OWlZWE5sTFdOdmJuUnlZV04wY3k5MWNHZHlZV1JsWVdKc1pTNTBjem94T1FvZ0lDQWdMeThnWTI5dWMzUWdXM2RoYkd4bGRFbEVYU0E5SUc5d0xrRndjRWRzYjJKaGJDNW5aWFJGZUZWcGJuUTJOQ2gwYUdsekxtRnJhWFJoUkVGUExuWmhiSFZsTENCQ2VYUmxjeWhCYTJsMFlVUkJUMGRzYjJKaGJGTjBZWFJsUzJWNWMxZGhiR3hsZENrcENpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0ozWVd4c1pYUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlltRnpaUzFqYjI1MGNtRmpkSE12ZFhCbmNtRmtaV0ZpYkdVdWRITTZNallLSUNBZ0lDOHZJR3h2WjJkbFpFRnpjMlZ5ZENoVWVHNHVjMlZ1WkdWeUlEMDlQU0IwYUdsekxtZGxkRUZyYVhSaFJFRlBWMkZzYkdWMEtDa3VZV1JrY21WemN5d2daWEp5VG05MFFXdHBkR0ZFWVc4cENpQWdJQ0JoY0hCZmNHRnlZVzF6WDJkbGRDQkJjSEJCWkdSeVpYTnpDaUFnSUNCaGMzTmxjblFnTHk4Z1lYQndiR2xqWVhScGIyNGdaWGhwYzNSekNpQWdJQ0E5UFFvZ0lDQWdZbTU2SUhWd1pHRjBaVUZyYVhSaFJFRlBYMkZtZEdWeVgyRnpjMlZ5ZEVBekNpQWdJQ0J3ZFhOb1lubDBaWE1nSWtWU1VqcGxjbkpPWkdGdklnb2dJQ0FnYkc5bkNpQWdJQ0JsY25JZ0x5OGdSVkpTT21WeWNrNWtZVzhLQ25Wd1pHRjBaVUZyYVhSaFJFRlBYMkZtZEdWeVgyRnpjMlZ5ZEVBek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMkpoYzJVdFkyOXVkSEpoWTNSekwzVndaM0poWkdWaFlteGxMblJ6T2pFMkNpQWdJQ0F2THlCaGEybDBZVVJCVHlBOUlFZHNiMkpoYkZOMFlYUmxQRUZ3Y0d4cFkyRjBhVzl1UGloN0lHdGxlVG9nUjJ4dlltRnNVM1JoZEdWTFpYbEJhMmwwWVVSQlR5QjlLUW9nSUNBZ1lubDBaV05mTVNBdkx5QWlZV3RwZEdGZlpHRnZJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJKaGMyVXRZMjl1ZEhKaFkzUnpMM1Z3WjNKaFpHVmhZbXhsTG5Sek9qSTNDaUFnSUNBdkx5QjBhR2x6TG1GcmFYUmhSRUZQTG5aaGJIVmxJRDBnWVd0cGRHRkVRVThLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlltRnpaUzFqYjI1MGNtRmpkSE12ZFhCbmNtRmtaV0ZpYkdVdWRITTZNalVLSUNBZ0lDOHZJSFZ3WkdGMFpVRnJhWFJoUkVGUEtHRnJhWFJoUkVGUE9pQkJjSEJzYVdOaGRHbHZiaWs2SUhadmFXUWdld29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERUtJQ0FnSUhKbGRIVnliZ289In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFBRUNDQ1lHQkJVZmZIVUpZV3RwZEdGZlpHRnZEM0psWjJsemRISjVYMk4xY25OdmNnQUxSVkpTT21WeWNrbGhjbWNMUlZKU09tVnlja2x3WVhreEdFQUFOeW9qWjRJQ0VuSmxaMmx6ZEhKaGRHbHZibDl6YUdGd1pRNG9kV2x1ZERnc2RXbHVkRFkwS1dlQUMyTm9aV05yWDNOb1lYQmxLMmN4R1JSRU1SaEJBRHVDQndReW53VHVCSGU3ZWJrRWJnUDFDZ1NCOFdWREJKRFUrbDBFTStrc2xBU0ZUZTNnTmhvQWpnY0FPd0JZQUs4QjJRSG9BZ0lBQVFBalE0QUV6WnJXZmpZYUFJNEJBQUVBTmhvQlNTSlpKQWhMQVJVU1JGY0NBRFlhQWtrVkpSSkVGNEFIZG1WeWMybHZiazhDWnlsTVp5TkROaG9CU1NKWkpBaE1GUkpFZ0F3VkgzeDFBQUFBQUFBQUpGU3dJME14RmlNSlNUZ1FJeEpFTmhvQlNTSlpKQWhMQVJVU1JGY0NBRWtWZ1FrU1FBQUVKd1N3QUVzQk9BY3lDaEpBQUFRbkJiQUFURGdJZ2RSSUVrQUFCQ2NGc0FBaUttVkVTU01JS2t4bkZrbFBBcjhvVEZDd0kwTXJTVFlhQVVrVmdTQVNSRFlhQWtrVkpSSkVGellhQTBraVdTUUlTd0VWRWtSWEFnQVZRUUFFSndTd0FCYStSRWxYQUFGTUkxdEZBeUlwWlVTQUEzTmhiR1ZJSWx0SnNiSVlnQVRtNW52Y3NocExBcklhZ1FheUVDS3lBYk8wUGtsWEJBQk1Wd0FFS0JKRVNSVWpFa1FpVTBBQUVFWURJb0FCQUNKUEFsUW9URkN3STBPeHNoaUFCSE9lcHd1eUdreXlHb0VHc2hBaXNnR3p0RDVKVndRQVN3RlhBQVFvRWtRVmdVb1NSSUVkV3lKRkJFc0NNZ2NPUVFBSE1nZExBd2xGQkVzQmdBRUtFa0VBQ0VVQlN3SVNRditrU3dHQUFSUVNRUUFJUlFGTEFoTkMvNU5MQVlBQkhoSkJBQWhGQVVzQ0RFTC9na3NCZ0FFb0VrRUFDRVVCU3dJT1F2OXhTd0dBQVRJU1FRQUlSUUZMQWcxQy8yQk1nQUU4RWtFQUJrc0NEMEwvVWtnaVF2OU5OaG9CU1JXQkNSSkVLRXhRc0NORE5ob0JTUlVsRWtRWEZyNUVTUlVXVndZQ1RGQW9URkN3STBNMkdnRkpGU1VTUkJjeEFDSXBaVVNBQm5kaGJHeGxkR1ZJY2doRUVrQUFENEFMUlZKU09tVnljazVrWVcrd0FDbE1aeU5EIiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6MTAsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
