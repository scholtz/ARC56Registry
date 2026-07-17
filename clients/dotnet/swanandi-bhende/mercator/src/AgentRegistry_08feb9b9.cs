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

namespace Arc56.Generated.swanandi_bhende.mercator.AgentRegistry_08feb9b9
{


    public class AgentRegistryProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public AgentRegistryProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class AgentRecord : AVMObjectType
            {
                public string AgentName { get; set; }

                public string Role { get; set; }

                public ulong RegisteredAtRound { get; set; }

                public bool Active { get; set; }

                public string SignedManifest { get; set; }

                public ulong TotalTransactions { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAgentName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vAgentName.From(AgentName);
                    stringRef[ret.Count] = vAgentName.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRole = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vRole.From(Role);
                    stringRef[ret.Count] = vRole.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRegisteredAtRound = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vRegisteredAtRound.From(RegisteredAtRound);
                    ret.AddRange(vRegisteredAtRound.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vActive = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vActive.From(Active);
                    ret.AddRange(vActive.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSignedManifest = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vSignedManifest.From(SignedManifest);
                    stringRef[ret.Count] = vSignedManifest.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalTransactions = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalTransactions.From(TotalTransactions);
                    ret.AddRange(vTotalTransactions.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static AgentRecord Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new AgentRecord();
                    uint count = 0;
                    var indexAgentName = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAgentName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vAgentName.Decode(bytes.Skip(indexAgentName + prefixOffset).ToArray());
                    var valueAgentName = vAgentName.ToValue();
                    if (valueAgentName is string vAgentNameValue) { ret.AgentName = vAgentNameValue; }
                    var indexRole = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRole = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vRole.Decode(bytes.Skip(indexRole + prefixOffset).ToArray());
                    var valueRole = vRole.ToValue();
                    if (valueRole is string vRoleValue) { ret.Role = vRoleValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRegisteredAtRound = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vRegisteredAtRound.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRegisteredAtRound = vRegisteredAtRound.ToValue();
                    if (valueRegisteredAtRound is ulong vRegisteredAtRoundValue) { ret.RegisteredAtRound = vRegisteredAtRoundValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vActive = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vActive.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueActive = vActive.ToValue();
                    if (valueActive is bool vActiveValue) { ret.Active = vActiveValue; }
                    var indexSignedManifest = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSignedManifest = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vSignedManifest.Decode(bytes.Skip(indexSignedManifest + prefixOffset).ToArray());
                    var valueSignedManifest = vSignedManifest.ToValue();
                    if (valueSignedManifest is string vSignedManifestValue) { ret.SignedManifest = vSignedManifestValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalTransactions = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalTransactions.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalTransactions = vTotalTransactions.ToValue();
                    if (valueTotalTransactions is ulong vTotalTransactionsValue) { ret.TotalTransactions = vTotalTransactionsValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as AgentRecord);
                }
                public bool Equals(AgentRecord? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(AgentRecord left, AgentRecord right)
                {
                    return EqualityComparer<AgentRecord>.Default.Equals(left, right);
                }
                public static bool operator !=(AgentRecord left, AgentRecord right)
                {
                    return !(left == right);
                }

            }

            public class GetConfigReturn : AVMObjectType
            {
                public Algorand.Address Field0 { get; set; }

                public ulong Field1 { get; set; }

                public ulong Field2 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField2.From(Field2);
                    ret.AddRange(vField2.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static GetConfigReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetConfigReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is Algorand.Address vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is ulong vField1Value) { ret.Field1 = vField1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is ulong vField2Value) { ret.Field2 = vField2Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetConfigReturn);
                }
                public bool Equals(GetConfigReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetConfigReturn left, GetConfigReturn right)
                {
                    return EqualityComparer<GetConfigReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetConfigReturn left, GetConfigReturn right)
                {
                    return !(left == right);
                }

            }

        }

        public class Events
        {
            public class AgentRegisteredEvent
            {
                public static readonly byte[] Selector = new byte[4] { 71, 5, 82, 73 };
                public const string Signature = "AgentRegistered(address,string,string)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Algorand.Address Field1 { get; set; }
                public string Field2 { get; set; }
                public string Field3 { get; set; }

                public static AgentRegisteredEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new AgentRegisteredEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is Algorand.Address vField1Value) { ret.Field1 = vField1Value; }
                    var indexField2 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField2.Decode(eventData.Skip(indexField2).ToArray());
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is string vField2Value) { ret.Field2 = vField2Value; }
                    var indexField3 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField3.Decode(eventData.Skip(indexField3).ToArray());
                    var valueField3 = vField3.ToValue();
                    if (valueField3 is string vField3Value) { ret.Field3 = vField3Value; }
                    return ret;

                }

            }

            public class AgentDeregisteredEvent
            {
                public static readonly byte[] Selector = new byte[4] { 10, 83, 104, 245 };
                public const string Signature = "AgentDeregistered(address,string,string)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Algorand.Address Field1 { get; set; }
                public string Field2 { get; set; }
                public string Field3 { get; set; }

                public static AgentDeregisteredEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new AgentDeregisteredEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is Algorand.Address vField1Value) { ret.Field1 = vField1Value; }
                    var indexField2 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField2.Decode(eventData.Skip(indexField2).ToArray());
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is string vField2Value) { ret.Field2 = vField2Value; }
                    var indexField3 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField3.Decode(eventData.Skip(indexField3).ToArray());
                    var valueField3 = vField3.ToValue();
                    if (valueField3 is string vField3Value) { ret.Field3 = vField3Value; }
                    return ret;

                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="agent_name"> </param>
        /// <param name="role"> </param>
        /// <param name="signed_manifest"> </param>
        public async Task Register(string agent_name, string role, string signed_manifest, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 3, 162, 252, 79 };
            var agent_nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); agent_nameAbi.From(agent_name);
            var roleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); roleAbi.From(role);
            var signed_manifestAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); signed_manifestAbi.From(signed_manifest);

            var result = await base.CallApp(new List<object> { abiHandle, agent_nameAbi, roleAbi, signed_manifestAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Register_Transactions(string agent_name, string role, string signed_manifest, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 3, 162, 252, 79 };
            var agent_nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); agent_nameAbi.From(agent_name);
            var roleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); roleAbi.From(role);
            var signed_manifestAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); signed_manifestAbi.From(signed_manifest);

            return await base.MakeTransactionList(new List<object> { abiHandle, agent_nameAbi, roleAbi, signed_manifestAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="wallet"> </param>
        public async Task<bool> IsRegistered(Algorand.Address wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 145, 156, 2, 223 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); walletAbi.From(wallet);

            var result = await base.SimApp(new List<object> { abiHandle, walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsRegistered_Transactions(Algorand.Address wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 145, 156, 2, 223 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); walletAbi.From(wallet);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="wallet"> </param>
        public async Task<Structs.AgentRecord> GetRecord(Algorand.Address wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 16, 217, 1, 26 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); walletAbi.From(wallet);

            var result = await base.SimApp(new List<object> { abiHandle, walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.AgentRecord.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetRecord_Transactions(Algorand.Address wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 16, 217, 1, 26 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); walletAbi.From(wallet);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.GetConfigReturn> GetConfig(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 141, 122, 23, 228 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetConfigReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetConfig_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 141, 122, 23, 228 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="wallet"> </param>
        public async Task Deregister(Algorand.Address wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 154, 162, 130, 213 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); walletAbi.From(wallet);

            var result = await base.CallApp(new List<object> { abiHandle, walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Deregister_Transactions(Algorand.Address wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 154, 162, 130, 213 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); walletAbi.From(wallet);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="wallet"> </param>
        public async Task IncrementTransactionCount(Algorand.Address wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 115, 44, 97, 62 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); walletAbi.From(wallet);

            var result = await base.CallApp(new List<object> { abiHandle, walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> IncrementTransactionCount_Transactions(Algorand.Address wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 115, 44, 97, 62 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); walletAbi.From(wallet);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQWdlbnRSZWdpc3RyeSIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJBZ2VudFJlY29yZCI6W3sibmFtZSI6ImFnZW50X25hbWUiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoicm9sZSIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJyZWdpc3RlcmVkX2F0X3JvdW5kIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImFjdGl2ZSIsInR5cGUiOiJib29sIn0seyJuYW1lIjoic2lnbmVkX21hbmlmZXN0IiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6InRvdGFsX3RyYW5zYWN0aW9ucyIsInR5cGUiOiJ1aW50NjQifV0sIkdldENvbmZpZ1JldHVybiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMiIsInR5cGUiOiJ1aW50NjQifV19LCJNZXRob2RzIjpbeyJuYW1lIjoicmVnaXN0ZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWdlbnRfbmFtZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoicm9sZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2lnbmVkX21hbmlmZXN0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJBZ2VudFJlZ2lzdGVyZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMSIsImRlc2MiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMiIsImRlc2MiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMyIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImlzX3JlZ2lzdGVyZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6IndhbGxldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9yZWNvcmQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6IndhbGxldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIoc3RyaW5nLHN0cmluZyx1aW50NjQsYm9vbCxzdHJpbmcsdWludDY0KSIsInN0cnVjdCI6IkFnZW50UmVjb3JkIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfY29uZmlnIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6IihhZGRyZXNzLHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiR2V0Q29uZmlnUmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJkZXJlZ2lzdGVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ3YWxsZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IkFnZW50RGVyZWdpc3RlcmVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDEiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDMiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJpbmNyZW1lbnRfdHJhbnNhY3Rpb25fY291bnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6IndhbGxldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjN9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzMzNF0sImVycm9yTWVzc2FnZSI6Ik1hbmlmZXN0IHNpZ25hdHVyZSB2ZXJpZmljYXRpb24gZmFpbGVkIOKAlCBlbnN1cmUgdGhlIG1hbmlmZXN0IHdhcyBzaWduZWQgd2l0aCB0aGUgY2FsbGVyJ3MgcHJpdmF0ZSBrZXkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2NTJdLCJlcnJvck1lc3NhZ2UiOiJObyByZWNvcmQgZm91bmQgZm9yIHRoaXMgd2FsbGV0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzA1XSwiZXJyb3JNZXNzYWdlIjoiT25seSB0aGUgY29udHJhY3Qgb3duZXIgY2FuIGRlcmVnaXN0ZXIgYWdlbnRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjcxXSwiZXJyb3JNZXNzYWdlIjoiUm9sZSBtdXN0IGJlIGJ1eWVyLCBjdXJhdG9yLCBvciBzZWxsZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3MTRdLCJlcnJvck1lc3NhZ2UiOiJXYWxsZXQgbm90IGZvdW5kIGluIHJlZ2lzdHJ5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODk0XSwiZXJyb3JNZXNzYWdlIjoiV2FsbGV0IG5vdCByZWdpc3RlcmVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjY2LDcwM10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYub3duZXIgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjc1XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5yZWdpc3RyeV92ZXJzaW9uIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUxMyw1NzksNjcwLDgzOV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudG90YWxfcmVnaXN0ZXJlZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNDMsMzY2LDM3Myw0NjMsNjI1LDc1NCw3ODIsOTM0LDk0MCw5NzVdLCJlcnJvck1lc3NhZ2UiOiJpbmRleCBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTgyLDE5OCwyMTddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxOTEsMjA4LDIyM10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MDIsNjQ0LDY5Niw4ODZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBeUlEQWdNU0F5TXdvZ0lDQWdZbmwwWldOaWJHOWpheUFpZEc5MFlXeGZjbVZuYVhOMFpYSmxaQ0lnTUhnd01DQXdlRGN5TmpVMk56Vm1JREI0TURBeE55QWliM2R1WlhJaUlEQjRNVFV4Wmpkak56VWdNSGd3TURBd01EQXdNREF3TURBd01EQXdJQ0p5WldkcGMzUnllVjkyWlhKemFXOXVJaUF3ZURBd01qUUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmlibm9nYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJS0lDQWdJQzh2SUdKaFkydGxibVF2WTI5dWRISmhZM1J6TDJGblpXNTBYM0psWjJsemRISjVMbkI1T2pJM0xUSTRDaUFnSUNBdkx5QWpJRk5sZENCa1pYQnNiM2xsY2lCaGN5QnZkMjVsY2lCaGJtUWdhVzVwZEdsaGJHbDZaU0JqYjNWdWRHVnljd29nSUNBZ0x5OGdjMlZzWmk1dmQyNWxjaTUyWVd4MVpTQTlJR0Z5WXpRdVFXUmtjbVZ6Y3loVWVHNHVjMlZ1WkdWeUtRb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaWIzZHVaWElpQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdZbUZqYTJWdVpDOWpiMjUwY21GamRITXZZV2RsYm5SZmNtVm5hWE4wY25rdWNIazZNamtLSUNBZ0lDOHZJSE5sYkdZdWRHOTBZV3hmY21WbmFYTjBaWEpsWkM1MllXeDFaU0E5SUdGeVl6UXVWVWx1ZERZMEtEQXBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSjBiM1JoYkY5eVpXZHBjM1JsY21Wa0lnb2dJQ0FnWW5sMFpXTWdOaUF2THlBd2VEQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCaVlXTnJaVzVrTDJOdmJuUnlZV04wY3k5aFoyVnVkRjl5WldkcGMzUnllUzV3ZVRvek1Bb2dJQ0FnTHk4Z2MyVnNaaTV5WldkcGMzUnllVjkyWlhKemFXOXVMblpoYkhWbElEMGdZWEpqTkM1VlNXNTBOalFvTVNrS0lDQWdJR0o1ZEdWaklEY2dMeThnSW5KbFoybHpkSEo1WDNabGNuTnBiMjRpQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TURBd01EQXdNREF3TURBd01EQXhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9LYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJNkNpQWdJQ0F2THlCaVlXTnJaVzVrTDJOdmJuUnlZV04wY3k5aFoyVnVkRjl5WldkcGMzUnllUzV3ZVRveE13b2dJQ0FnTHk4Z1kyeGhjM01nUVdkbGJuUlNaV2RwYzNSeWVTaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR0o2SUcxaGFXNWZYMTloYkdkdmNIbGZaR1ZtWVhWc2RGOWpjbVZoZEdWQU1UVUtJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VEQXpZVEptWXpSbUlEQjRPVEU1WXpBeVpHWWdNSGd4TUdRNU1ERXhZU0F3ZURoa04yRXhOMlUwSURCNE9XRmhNamd5WkRVZ01IZzNNekpqTmpFelpTQXZMeUJ0WlhSb2IyUWdJbkpsWjJsemRHVnlLSE4wY21sdVp5eHpkSEpwYm1jc2MzUnlhVzVuS1hadmFXUWlMQ0J0WlhSb2IyUWdJbWx6WDNKbFoybHpkR1Z5WldRb1lXUmtjbVZ6Y3lsaWIyOXNJaXdnYldWMGFHOWtJQ0puWlhSZmNtVmpiM0prS0dGa1pISmxjM01wS0hOMGNtbHVaeXh6ZEhKcGJtY3NkV2x1ZERZMExHSnZiMndzYzNSeWFXNW5MSFZwYm5RMk5Da2lMQ0J0WlhSb2IyUWdJbWRsZEY5amIyNW1hV2NvS1NoaFpHUnlaWE56TEhWcGJuUTJOQ3gxYVc1ME5qUXBJaXdnYldWMGFHOWtJQ0prWlhKbFoybHpkR1Z5S0dGa1pISmxjM01wZG05cFpDSXNJRzFsZEdodlpDQWlhVzVqY21WdFpXNTBYM1J5WVc1ellXTjBhVzl1WDJOdmRXNTBLR0ZrWkhKbGMzTXBkbTlwWkNJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lISmxaMmx6ZEdWeUlHbHpYM0psWjJsemRHVnlaV1FnWjJWMFgzSmxZMjl5WkNCblpYUmZZMjl1Wm1sbklHUmxjbVZuYVhOMFpYSWdhVzVqY21WdFpXNTBYM1J5WVc1ellXTjBhVzl1WDJOdmRXNTBDaUFnSUNCbGNuSUtDbTFoYVc1ZlgxOWhiR2R2Y0hsZlpHVm1ZWFZzZEY5amNtVmhkR1ZBTVRVNkNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0lRb2dJQ0FnSmlZS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUdGblpXNTBYM0psWjJsemRISjVMa0ZuWlc1MFVtVm5hWE4wY25rdWNtVm5hWE4wWlhKYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHlaV2RwYzNSbGNqb0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JrZFhCdUlESUtJQ0FnSUM4dklHSmhZMnRsYm1RdlkyOXVkSEpoWTNSekwyRm5aVzUwWDNKbFoybHpkSEo1TG5CNU9qTXlDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb1lXeHNiM2RmWVdOMGFXOXVjejFiSWs1dlQzQWlYU2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjRzRnTWdvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBeUNpQWdJQ0FyQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHUjFjQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0c0Z01nb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlETUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnYzNkaGNBb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJQzh2SUdKaFkydGxibVF2WTI5dWRISmhZM1J6TDJGblpXNTBYM0psWjJsemRISjVMbkI1T2pNMExUTTFDaUFnSUNBdkx5QWpJRkp2YkdVZ2RtRnNhV1JoZEdsdmJpQW9iMjR0WTJoaGFXNGdZMjl1YzNSeVlXbHVkQ2tLSUNBZ0lDOHZJR0Z6YzJWeWRDQnliMnhsSUQwOUlDSmlkWGxsY2lJZ2IzSWdjbTlzWlNBOVBTQWlZM1Z5WVhSdmNpSWdiM0lnY205c1pTQTlQU0FpYzJWc2JHVnlJaXdnSWxKdmJHVWdiWFZ6ZENCaVpTQmlkWGxsY2l3Z1kzVnlZWFJ2Y2l3Z2IzSWdjMlZzYkdWeUlnb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQXdOVFl5TnpVM09UWTFOeklLSUNBZ0lEMDlDaUFnSUNCaWJub2djbVZuYVhOMFpYSmZZbTl2YkY5MGNuVmxRRFFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TURBM05qTTNOVGN5TmpFM05EWm1OeklLSUNBZ0lEMDlDaUFnSUNCaWJub2djbVZuYVhOMFpYSmZZbTl2YkY5MGNuVmxRRFFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TURBMk56TTJOVFpqTm1NMk5UY3lDaUFnSUNBOVBRb2dJQ0FnWW5vZ2NtVm5hWE4wWlhKZlltOXZiRjltWVd4elpVQTFDZ3B5WldkcGMzUmxjbDlpYjI5c1gzUnlkV1ZBTkRvS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2dweVpXZHBjM1JsY2w5aWIyOXNYMjFsY21kbFFEWTZDaUFnSUNBdkx5QmlZV05yWlc1a0wyTnZiblJ5WVdOMGN5OWhaMlZ1ZEY5eVpXZHBjM1J5ZVM1d2VUb3pOQzB6TlFvZ0lDQWdMeThnSXlCU2IyeGxJSFpoYkdsa1lYUnBiMjRnS0c5dUxXTm9ZV2x1SUdOdmJuTjBjbUZwYm5RcENpQWdJQ0F2THlCaGMzTmxjblFnY205c1pTQTlQU0FpWW5WNVpYSWlJRzl5SUhKdmJHVWdQVDBnSW1OMWNtRjBiM0lpSUc5eUlISnZiR1VnUFQwZ0luTmxiR3hsY2lJc0lDSlNiMnhsSUcxMWMzUWdZbVVnWW5WNVpYSXNJR04xY21GMGIzSXNJRzl5SUhObGJHeGxjaUlLSUNBZ0lHRnpjMlZ5ZENBdkx5QlNiMnhsSUcxMWMzUWdZbVVnWW5WNVpYSXNJR04xY21GMGIzSXNJRzl5SUhObGJHeGxjZ29nSUNBZ0x5OGdZbUZqYTJWdVpDOWpiMjUwY21GamRITXZZV2RsYm5SZmNtVm5hWE4wY25rdWNIazZNemNLSUNBZ0lDOHZJR05oYkd4bGNpQTlJR0Z5WXpRdVFXUmtjbVZ6Y3loVWVHNHVjMlZ1WkdWeUtRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURnS0lDQWdJQzh2SUdKaFkydGxibVF2WTI5dWRISmhZM1J6TDJGblpXNTBYM0psWjJsemRISjVMbkI1T2pNNENpQWdJQ0F2THlCbGVHbHpkSE1nUFNCallXeHNaWElnYVc0Z2MyVnNaaTV5WldkcGMzUnllUW9nSUNBZ1lubDBaV05mTWlBdkx5QXdlRGN5TmpVMk56Vm1DaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0EzQ2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUM4dklHSmhZMnRsYm1RdlkyOXVkSEpoWTNSekwyRm5aVzUwWDNKbFoybHpkSEo1TG5CNU9qUXpDaUFnSUNBdkx5QXJJR0ZuWlc1MFgyNWhiV1V1Ym1GMGFYWmxMbUo1ZEdWekNpQWdJQ0JrYVdjZ05Rb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJQzh2SUdKaFkydGxibVF2WTI5dWRISmhZM1J6TDJGblpXNTBYM0psWjJsemRISjVMbkI1T2pReUNpQWdJQ0F2THlCQ2VYUmxjeWhpSW0xbGNtTmhkRzl5T25ZeGZDSXBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzJaRFkxTnpJMk16WXhOelEyWmpjeU0yRTNOak14TjJNS0lDQWdJQzh2SUdKaFkydGxibVF2WTI5dWRISmhZM1J6TDJGblpXNTBYM0psWjJsemRISjVMbkI1T2pReUxUUXpDaUFnSUNBdkx5QkNlWFJsY3loaUltMWxjbU5oZEc5eU9uWXhmQ0lwQ2lBZ0lDQXZMeUFySUdGblpXNTBYMjVoYldVdWJtRjBhWFpsTG1KNWRHVnpDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJR0poWTJ0bGJtUXZZMjl1ZEhKaFkzUnpMMkZuWlc1MFgzSmxaMmx6ZEhKNUxuQjVPalEwQ2lBZ0lDQXZMeUFySUVKNWRHVnpLR0lpZkNJcENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnM1l3b2dJQ0FnTHk4Z1ltRmphMlZ1WkM5amIyNTBjbUZqZEhNdllXZGxiblJmY21WbmFYTjBjbmt1Y0hrNk5ESXRORFFLSUNBZ0lDOHZJRUo1ZEdWektHSWliV1Z5WTJGMGIzSTZkakY4SWlrS0lDQWdJQzh2SUNzZ1lXZGxiblJmYm1GdFpTNXVZWFJwZG1VdVlubDBaWE1LSUNBZ0lDOHZJQ3NnUW5sMFpYTW9ZaUo4SWlrS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z1ltRmphMlZ1WkM5amIyNTBjbUZqZEhNdllXZGxiblJmY21WbmFYTjBjbmt1Y0hrNk5EVUtJQ0FnSUM4dklDc2dWSGh1TG5ObGJtUmxjaTVpZVhSbGN3b2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnWW1GamEyVnVaQzlqYjI1MGNtRmpkSE12WVdkbGJuUmZjbVZuYVhOMGNua3VjSGs2TkRJdE5EVUtJQ0FnSUM4dklFSjVkR1Z6S0dJaWJXVnlZMkYwYjNJNmRqRjhJaWtLSUNBZ0lDOHZJQ3NnWVdkbGJuUmZibUZ0WlM1dVlYUnBkbVV1WW5sMFpYTUtJQ0FnSUM4dklDc2dRbmwwWlhNb1lpSjhJaWtLSUNBZ0lDOHZJQ3NnVkhodUxuTmxibVJsY2k1aWVYUmxjd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJpWVdOclpXNWtMMk52Ym5SeVlXTjBjeTloWjJWdWRGOXlaV2RwYzNSeWVTNXdlVG8wTmdvZ0lDQWdMeThnS3lCQ2VYUmxjeWhpSW53aUtRb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE4yTUtJQ0FnSUM4dklHSmhZMnRsYm1RdlkyOXVkSEpoWTNSekwyRm5aVzUwWDNKbFoybHpkSEo1TG5CNU9qUXlMVFEyQ2lBZ0lDQXZMeUJDZVhSbGN5aGlJbTFsY21OaGRHOXlPbll4ZkNJcENpQWdJQ0F2THlBcklHRm5aVzUwWDI1aGJXVXVibUYwYVhabExtSjVkR1Z6Q2lBZ0lDQXZMeUFySUVKNWRHVnpLR0lpZkNJcENpQWdJQ0F2THlBcklGUjRiaTV6Wlc1a1pYSXVZbmwwWlhNS0lDQWdJQzh2SUNzZ1FubDBaWE1vWWlKOElpa0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdZbUZqYTJWdVpDOWpiMjUwY21GamRITXZZV2RsYm5SZmNtVm5hWE4wY25rdWNIazZORGNLSUNBZ0lDOHZJQ3NnY205c1pTNXVZWFJwZG1VdVlubDBaWE1LSUNBZ0lHUnBaeUEwQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ0x5OGdZbUZqYTJWdVpDOWpiMjUwY21GamRITXZZV2RsYm5SZmNtVm5hWE4wY25rdWNIazZOREl0TkRjS0lDQWdJQzh2SUVKNWRHVnpLR0lpYldWeVkyRjBiM0k2ZGpGOElpa0tJQ0FnSUM4dklDc2dZV2RsYm5SZmJtRnRaUzV1WVhScGRtVXVZbmwwWlhNS0lDQWdJQzh2SUNzZ1FubDBaWE1vWWlKOElpa0tJQ0FnSUM4dklDc2dWSGh1TG5ObGJtUmxjaTVpZVhSbGN3b2dJQ0FnTHk4Z0t5QkNlWFJsY3loaUlud2lLUW9nSUNBZ0x5OGdLeUJ5YjJ4bExtNWhkR2wyWlM1aWVYUmxjd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJpWVdOclpXNWtMMk52Ym5SeVlXTjBjeTloWjJWdWRGOXlaV2RwYzNSeWVTNXdlVG8xTUMwMU1Rb2dJQ0FnTHk4Z0l5QkVaV052WkdVZ1ltRnpaVFkwTFdWdVkyOWtaV1FnYzJsbmJtRjBkWEpsSUdsdWRHOGdjbUYzSUdKNWRHVnpJR1p2Y2lCMlpYSnBabWxqWVhScGIyNGdiMjR0WTJoaGFXNEtJQ0FnSUM4dklITnBaMjVsWkY5dFlXNXBabVZ6ZEY5aWVYUmxjeUE5SUc5d0xtSmhjMlUyTkY5a1pXTnZaR1VvYjNBdVFtRnpaVFkwTGxOMFpFVnVZMjlrYVc1bkxDQnphV2R1WldSZmJXRnVhV1psYzNRdWJtRjBhWFpsTG1KNWRHVnpLUW9nSUNBZ1pHbG5JRElLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCaVlYTmxOalJmWkdWamIyUmxJRk4wWkVWdVkyOWthVzVuQ2lBZ0lDQXZMeUJpWVdOclpXNWtMMk52Ym5SeVlXTjBjeTloWjJWdWRGOXlaV2RwYzNSeWVTNXdlVG8xTkFvZ0lDQWdMeThnWlhod1pXTjBaV1JmYldGdWFXWmxjM1FzSUhOcFoyNWxaRjl0WVc1cFptVnpkRjlpZVhSbGN5d2dWSGh1TG5ObGJtUmxjaTVpZVhSbGN3b2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnWW1GamEyVnVaQzlqYjI1MGNtRmpkSE12WVdkbGJuUmZjbVZuYVhOMGNua3VjSGs2TlRNdE5UVUtJQ0FnSUM4dklHRnpjMlZ5ZENCdmNDNWxaREkxTlRFNWRtVnlhV1o1WDJKaGNtVW9DaUFnSUNBdkx5QWdJQ0FnWlhod1pXTjBaV1JmYldGdWFXWmxjM1FzSUhOcFoyNWxaRjl0WVc1cFptVnpkRjlpZVhSbGN5d2dWSGh1TG5ObGJtUmxjaTVpZVhSbGN3b2dJQ0FnTHk4Z0tTd2dJazFoYm1sbVpYTjBJSE5wWjI1aGRIVnlaU0IyWlhKcFptbGpZWFJwYjI0Z1ptRnBiR1ZrSU9LQWxDQmxibk4xY21VZ2RHaGxJRzFoYm1sbVpYTjBJSGRoY3lCemFXZHVaV1FnZDJsMGFDQjBhR1VnWTJGc2JHVnlKM01nY0hKcGRtRjBaU0JyWlhraUNpQWdJQ0JsWkRJMU5URTVkbVZ5YVdaNVgySmhjbVVLSUNBZ0lHRnpjMlZ5ZENBdkx5Qk5ZVzVwWm1WemRDQnphV2R1WVhSMWNtVWdkbVZ5YVdacFkyRjBhVzl1SUdaaGFXeGxaQ0RpZ0pRZ1pXNXpkWEpsSUhSb1pTQnRZVzVwWm1WemRDQjNZWE1nYzJsbmJtVmtJSGRwZEdnZ2RHaGxJR05oYkd4bGNpZHpJSEJ5YVhaaGRHVWdhMlY1Q2lBZ0lDQXZMeUJpWVdOclpXNWtMMk52Ym5SeVlXTjBjeTloWjJWdWRGOXlaV2RwYzNSeWVTNXdlVG8xTndvZ0lDQWdMeThnYVdZZ1pYaHBjM1J6T2dvZ0lDQWdZbm9nY21WbmFYTjBaWEpmWld4elpWOWliMlI1UURFeENpQWdJQ0F2THlCaVlXTnJaVzVrTDJOdmJuUnlZV04wY3k5aFoyVnVkRjl5WldkcGMzUnllUzV3ZVRvMU9DMDFPUW9nSUNBZ0x5OGdjbVZqYjNKa0lEMGdjMlZzWmk1eVpXZHBjM1J5ZVZ0allXeHNaWEpkTG1OdmNIa29LUW9nSUNBZ0x5OGdhV1lnY21WamIzSmtMbUZqZEdsMlpUb0tJQ0FnSUdScFp5QTFDaUFnSUNCd2RYTm9hVzUwSURFeUNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdZbTk0WDJWNGRISmhZM1FnTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JuWlhSaWFYUUtJQ0FnSUM4dklHSmhZMnRsYm1RdlkyOXVkSEpoWTNSekwyRm5aVzUwWDNKbFoybHpkSEo1TG5CNU9qVTVDaUFnSUNBdkx5QnBaaUJ5WldOdmNtUXVZV04wYVhabE9nb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEQXdDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBNUNpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1EQUtJQ0FnSUNFOUNpQWdJQ0JpZWlCeVpXZHBjM1JsY2w5bGJITmxYMkp2WkhsQU9Rb2dJQ0FnTHk4Z1ltRmphMlZ1WkM5amIyNTBjbUZqZEhNdllXZGxiblJmY21WbmFYTjBjbmt1Y0hrNk5qQXROalVLSUNBZ0lDOHZJQ01nYVdSbGJYQnZkR1Z1ZENCeVpTMXlaV2RwYzNSeVlYUnBiMjQ2SUhWd1pHRjBaU0J1WVcxbElHRnVaQ0J5YjJ4bExDQnJaV1Z3SUhKbFoybHpkR1Z5WldSZllYUmZjbTkxYm1RS0lDQWdJQzh2SUhObGJHWXVjbVZuYVhOMGNubGJZMkZzYkdWeVhTQTlJSEpsWTI5eVpDNWZjbVZ3YkdGalpTZ0tJQ0FnSUM4dklDQWdJQ0JoWjJWdWRGOXVZVzFsUFdGblpXNTBYMjVoYldVc0NpQWdJQ0F2THlBZ0lDQWdjbTlzWlQxeWIyeGxMQW9nSUNBZ0x5OGdJQ0FnSUhOcFoyNWxaRjl0WVc1cFptVnpkRDF6YVdkdVpXUmZiV0Z1YVdabGMzUXNDaUFnSUNBdkx5QXBDaUFnSUNCa2FXY2dOUW9nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwY3lBMElEZ0tJQ0FnSUdKdmVGOWxlSFJ5WVdOMElDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQmthV2NnTVFvZ0lDQWdjSFZ6YUdsdWRITWdNVFVnT0FvZ0lDQWdZbTk0WDJWNGRISmhZM1FnTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUdsdWRHTmZNeUF2THlBeU13b2dJQ0FnWkdsbklEY0tJQ0FnSUNzS0lDQWdJR1IxY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGd3TURFM0NpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdScFp5QTJDaUFnSUNBckNpQWdJQ0J6ZDJGd0NpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURFeENpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JRFlLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURRS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JREVLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdZbTk0WDNCMWRBb0tjbVZuYVhOMFpYSmZZV1owWlhKZmFXWmZaV3h6WlVBeE1qb0tJQ0FnSUM4dklHSmhZMnRsYm1RdlkyOXVkSEpoWTNSekwyRm5aVzUwWDNKbFoybHpkSEo1TG5CNU9qZzRMVGc1Q2lBZ0lDQXZMeUFqSUVWdGFYUWdZVzRnWlhabGJuUWdabTl5SUdsdVpHVjRaWEp6SUhSdklIQnBZMnNnZFhBZ2NtVm5hWE4wY21GMGFXOXVJR05vWVc1blpYTUtJQ0FnSUM4dklHRnlZelF1WlcxcGRDZ2lRV2RsYm5SU1pXZHBjM1JsY21Wa0lpd2dZMkZzYkdWeUxDQmhaMlZ1ZEY5dVlXMWxMQ0J5YjJ4bEtRb2dJQ0FnWkdsbklEWUtJQ0FnSUdKNWRHVmpJRGdnTHk4Z01IZ3dNREkwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJocGJuUWdNellLSUNBZ0lHUnBaeUExQ2lBZ0lDQXJDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dOUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnME56QTFOVEkwT1NBdkx5QnRaWFJvYjJRZ0lrRm5aVzUwVW1WbmFYTjBaWEpsWkNoaFpHUnlaWE56TEhOMGNtbHVaeXh6ZEhKcGJtY3BJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lDOHZJR0poWTJ0bGJtUXZZMjl1ZEhKaFkzUnpMMkZuWlc1MFgzSmxaMmx6ZEhKNUxuQjVPak15Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9ZV3hzYjNkZllXTjBhVzl1Y3oxYklrNXZUM0FpWFNrS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NuSmxaMmx6ZEdWeVgyVnNjMlZmWW05a2VVQTVPZ29nSUNBZ0x5OGdZbUZqYTJWdVpDOWpiMjUwY21GamRITXZZV2RsYm5SZmNtVm5hWE4wY25rdWNIazZOeklLSUNBZ0lDOHZJSEpsWjJsemRHVnlaV1JmWVhSZmNtOTFibVE5WVhKak5DNVZTVzUwTmpRb1IyeHZZbUZzTG5KdmRXNWtLU3dLSUNBZ0lHZHNiMkpoYkNCU2IzVnVaQW9nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdZbUZqYTJWdVpDOWpiMjUwY21GamRITXZZV2RsYm5SZmNtVm5hWE4wY25rdWNIazZOamN0TnpRS0lDQWdJQzh2SUNNZ2NISmxkbWx2ZFhOc2VTQmtaWEpsWjJsemRHVnlaV1FnNG9DVUlISmxZV04wYVhaaGRHVWdZVzVrSUhWd1pHRjBaU0JtYVdWc1pITUtJQ0FnSUM4dklITmxiR1l1Y21WbmFYTjBjbmxiWTJGc2JHVnlYU0E5SUhKbFkyOXlaQzVmY21Wd2JHRmpaU2dLSUNBZ0lDOHZJQ0FnSUNCaFoyVnVkRjl1WVcxbFBXRm5aVzUwWDI1aGJXVXNDaUFnSUNBdkx5QWdJQ0FnY205c1pUMXliMnhsTEFvZ0lDQWdMeThnSUNBZ0lHRmpkR2wyWlQxaGNtTTBMa0p2YjJ3b1ZISjFaU2tzQ2lBZ0lDQXZMeUFnSUNBZ2NtVm5hWE4wWlhKbFpGOWhkRjl5YjNWdVpEMWhjbU0wTGxWSmJuUTJOQ2hIYkc5aVlXd3VjbTkxYm1RcExBb2dJQ0FnTHk4Z0lDQWdJSE5wWjI1bFpGOXRZVzVwWm1WemREMXphV2R1WldSZmJXRnVhV1psYzNRc0NpQWdJQ0F2THlBcENpQWdJQ0JrYVdjZ05nb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCd2RYTm9hVzUwY3lBeE5TQTRDaUFnSUNCaWIzaGZaWGgwY21GamRDQXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2diM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdhVzUwWTE4eklDOHZJREl6Q2lBZ0lDQmthV2NnTndvZ0lDQWdLd29nSUNBZ1pIVndDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VEQXdNVGNLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdaR2xuSURZS0lDQWdJQ3NLSUNBZ0lITjNZWEFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QmlZV05yWlc1a0wyTnZiblJ5WVdOMGN5OWhaMlZ1ZEY5eVpXZHBjM1J5ZVM1d2VUbzNNUW9nSUNBZ0x5OGdZV04wYVhabFBXRnlZelF1UW05dmJDaFVjblZsS1N3S0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURnd0NpQWdJQ0F2THlCaVlXTnJaVzVrTDJOdmJuUnlZV04wY3k5aFoyVnVkRjl5WldkcGMzUnllUzV3ZVRvMk55MDNOQW9nSUNBZ0x5OGdJeUJ3Y21WMmFXOTFjMng1SUdSbGNtVm5hWE4wWlhKbFpDRGlnSlFnY21WaFkzUnBkbUYwWlNCaGJtUWdkWEJrWVhSbElHWnBaV3hrY3dvZ0lDQWdMeThnYzJWc1ppNXlaV2RwYzNSeWVWdGpZV3hzWlhKZElEMGdjbVZqYjNKa0xsOXlaWEJzWVdObEtBb2dJQ0FnTHk4Z0lDQWdJR0ZuWlc1MFgyNWhiV1U5WVdkbGJuUmZibUZ0WlN3S0lDQWdJQzh2SUNBZ0lDQnliMnhsUFhKdmJHVXNDaUFnSUNBdkx5QWdJQ0FnWVdOMGFYWmxQV0Z5WXpRdVFtOXZiQ2hVY25WbEtTd0tJQ0FnSUM4dklDQWdJQ0J5WldkcGMzUmxjbVZrWDJGMFgzSnZkVzVrUFdGeVl6UXVWVWx1ZERZMEtFZHNiMkpoYkM1eWIzVnVaQ2tzQ2lBZ0lDQXZMeUFnSUNBZ2MybG5ibVZrWDIxaGJtbG1aWE4wUFhOcFoyNWxaRjl0WVc1cFptVnpkQ3dLSUNBZ0lDOHZJQ2tLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ05nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dOQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ01Rb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJpWVdOclpXNWtMMk52Ym5SeVlXTjBjeTloWjJWdWRGOXlaV2RwYzNSeWVTNXdlVG8zTlFvZ0lDQWdMeThnYzJWc1ppNTBiM1JoYkY5eVpXZHBjM1JsY21Wa0xuWmhiSFZsSUQwZ1lYSmpOQzVWU1c1ME5qUW9jMlZzWmk1MGIzUmhiRjl5WldkcGMzUmxjbVZrTG5aaGJIVmxMbUZ6WDNWcGJuUTJOQ2dwSUNzZ01Ta0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKMGIzUmhiRjl5WldkcGMzUmxjbVZrSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuUnZkR0ZzWDNKbFoybHpkR1Z5WldRZ1pYaHBjM1J6Q2lBZ0lDQmlkRzlwQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWRHOTBZV3hmY21WbmFYTjBaWEpsWkNJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0JpSUhKbFoybHpkR1Z5WDJGbWRHVnlYMmxtWDJWc2MyVkFNVElLQ25KbFoybHpkR1Z5WDJWc2MyVmZZbTlrZVVBeE1Ub0tJQ0FnSUM4dklHSmhZMnRsYm1RdlkyOXVkSEpoWTNSekwyRm5aVzUwWDNKbFoybHpkSEo1TG5CNU9qZ3hDaUFnSUNBdkx5QmhjbU0wTGxWSmJuUTJOQ2hIYkc5aVlXd3VjbTkxYm1RcExBb2dJQ0FnWjJ4dlltRnNJRkp2ZFc1a0NpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCaVlXTnJaVzVrTDJOdmJuUnlZV04wY3k5aFoyVnVkRjl5WldkcGMzUnllUzV3ZVRvM055MDROUW9nSUNBZ0x5OGdJeUJ1WlhjZ2NtVm5hWE4wY21GMGFXOXVPaUJqY21WaGRHVWdZbTk0SUdWdWRISjVJR0Z1WkNCcGJtTnlaVzFsYm5RZ1kyOTFiblJsY2dvZ0lDQWdMeThnYzJWc1ppNXlaV2RwYzNSeWVWdGpZV3hzWlhKZElEMGdRV2RsYm5SU1pXTnZjbVFvQ2lBZ0lDQXZMeUFnSUNBZ1lXZGxiblJmYm1GdFpTd0tJQ0FnSUM4dklDQWdJQ0J5YjJ4bExBb2dJQ0FnTHk4Z0lDQWdJR0Z5WXpRdVZVbHVkRFkwS0Vkc2IySmhiQzV5YjNWdVpDa3NDaUFnSUNBdkx5QWdJQ0FnWVhKak5DNUNiMjlzS0ZSeWRXVXBMQW9nSUNBZ0x5OGdJQ0FnSUhOcFoyNWxaRjl0WVc1cFptVnpkQ3dLSUNBZ0lDOHZJQ0FnSUNCaGNtTTBMbFZKYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ2tLSUNBZ0lHbHVkR05mTXlBdkx5QXlNd29nSUNBZ1pHbG5JRFVLSUNBZ0lDc0tJQ0FnSUdSMWNBb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhnd01ERTNDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHUnBaeUEwQ2lBZ0lDQXJDaUFnSUNCemQyRndDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z1ltRmphMlZ1WkM5amIyNTBjbUZqZEhNdllXZGxiblJmY21WbmFYTjBjbmt1Y0hrNk9ESUtJQ0FnSUM4dklHRnlZelF1UW05dmJDaFVjblZsS1N3S0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURnd0NpQWdJQ0F2THlCaVlXTnJaVzVrTDJOdmJuUnlZV04wY3k5aFoyVnVkRjl5WldkcGMzUnllUzV3ZVRvM055MDROUW9nSUNBZ0x5OGdJeUJ1WlhjZ2NtVm5hWE4wY21GMGFXOXVPaUJqY21WaGRHVWdZbTk0SUdWdWRISjVJR0Z1WkNCcGJtTnlaVzFsYm5RZ1kyOTFiblJsY2dvZ0lDQWdMeThnYzJWc1ppNXlaV2RwYzNSeWVWdGpZV3hzWlhKZElEMGdRV2RsYm5SU1pXTnZjbVFvQ2lBZ0lDQXZMeUFnSUNBZ1lXZGxiblJmYm1GdFpTd0tJQ0FnSUM4dklDQWdJQ0J5YjJ4bExBb2dJQ0FnTHk4Z0lDQWdJR0Z5WXpRdVZVbHVkRFkwS0Vkc2IySmhiQzV5YjNWdVpDa3NDaUFnSUNBdkx5QWdJQ0FnWVhKak5DNUNiMjlzS0ZSeWRXVXBMQW9nSUNBZ0x5OGdJQ0FnSUhOcFoyNWxaRjl0WVc1cFptVnpkQ3dLSUNBZ0lDOHZJQ0FnSUNCaGNtTTBMbFZKYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ2tLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnWW1GamEyVnVaQzlqYjI1MGNtRmpkSE12WVdkbGJuUmZjbVZuYVhOMGNua3VjSGs2T0RRS0lDQWdJQzh2SUdGeVl6UXVWVWx1ZERZMEtEQXBMQW9nSUNBZ1lubDBaV01nTmlBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUM4dklHSmhZMnRsYm1RdlkyOXVkSEpoWTNSekwyRm5aVzUwWDNKbFoybHpkSEo1TG5CNU9qYzNMVGcxQ2lBZ0lDQXZMeUFqSUc1bGR5QnlaV2RwYzNSeVlYUnBiMjQ2SUdOeVpXRjBaU0JpYjNnZ1pXNTBjbmtnWVc1a0lHbHVZM0psYldWdWRDQmpiM1Z1ZEdWeUNpQWdJQ0F2THlCelpXeG1MbkpsWjJsemRISjVXMk5oYkd4bGNsMGdQU0JCWjJWdWRGSmxZMjl5WkNnS0lDQWdJQzh2SUNBZ0lDQmhaMlZ1ZEY5dVlXMWxMQW9nSUNBZ0x5OGdJQ0FnSUhKdmJHVXNDaUFnSUNBdkx5QWdJQ0FnWVhKak5DNVZTVzUwTmpRb1IyeHZZbUZzTG5KdmRXNWtLU3dLSUNBZ0lDOHZJQ0FnSUNCaGNtTTBMa0p2YjJ3b1ZISjFaU2tzQ2lBZ0lDQXZMeUFnSUNBZ2MybG5ibVZrWDIxaGJtbG1aWE4wTEFvZ0lDQWdMeThnSUNBZ0lHRnlZelF1VlVsdWREWTBLREFwTEFvZ0lDQWdMeThnS1FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ05Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ05nb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJR0poWTJ0bGJtUXZZMjl1ZEhKaFkzUnpMMkZuWlc1MFgzSmxaMmx6ZEhKNUxuQjVPamcyQ2lBZ0lDQXZMeUJ6Wld4bUxuUnZkR0ZzWDNKbFoybHpkR1Z5WldRdWRtRnNkV1VnUFNCaGNtTTBMbFZKYm5RMk5DaHpaV3htTG5SdmRHRnNYM0psWjJsemRHVnlaV1F1ZG1Gc2RXVXVZWE5mZFdsdWREWTBLQ2tnS3lBeEtRb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5SdmRHRnNYM0psWjJsemRHVnlaV1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWRHOTBZV3hmY21WbmFYTjBaWEpsWkNCbGVHbHpkSE1LSUNBZ0lHSjBiMmtLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNBckNpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKMGIzUmhiRjl5WldkcGMzUmxjbVZrSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR0lnY21WbmFYTjBaWEpmWVdaMFpYSmZhV1pmWld4elpVQXhNZ29LY21WbmFYTjBaWEpmWW05dmJGOW1ZV3h6WlVBMU9nb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0lnY21WbmFYTjBaWEpmWW05dmJGOXRaWEpuWlVBMkNnb0tMeThnWVdkbGJuUmZjbVZuYVhOMGNua3VRV2RsYm5SU1pXZHBjM1J5ZVM1cGMxOXlaV2RwYzNSbGNtVmtXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYVhOZmNtVm5hWE4wWlhKbFpEb0tJQ0FnSUM4dklHSmhZMnRsYm1RdlkyOXVkSEpoWTNSekwyRm5aVzUwWDNKbFoybHpkSEo1TG5CNU9qa3hDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUM4dklHSmhZMnRsYm1RdlkyOXVkSEpoWTNSekwyRm5aVzUwWDNKbFoybHpkSEo1TG5CNU9qa3pDaUFnSUNBdkx5QmxlR2x6ZEhNZ1BTQnpaV3htTG5KbFoybHpkSEo1TG0xaGVXSmxLSGRoYkd4bGRDbGJNVjBLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGczTWpZMU5qYzFaZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnTHk4Z1ltRmphMlZ1WkM5amIyNTBjbUZqZEhNdllXZGxiblJmY21WbmFYTjBjbmt1Y0hrNk9UUUtJQ0FnSUM4dklHbG1JRzV2ZENCbGVHbHpkSE02Q2lBZ0lDQmlibm9nYVhOZmNtVm5hWE4wWlhKbFpGOWhablJsY2w5cFpsOWxiSE5sUURNS0lDQWdJQzh2SUdKaFkydGxibVF2WTI5dWRISmhZM1J6TDJGblpXNTBYM0psWjJsemRISjVMbkI1T2prMUNpQWdJQ0F2THlCeVpYUjFjbTRnWVhKak5DNUNiMjlzS0VaaGJITmxLUW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlREF3Q2dwcGMxOXlaV2RwYzNSbGNtVmtYMkZtZEdWeVgybHViR2x1WldSZllXZGxiblJmY21WbmFYTjBjbmt1UVdkbGJuUlNaV2RwYzNSeWVTNXBjMTl5WldkcGMzUmxjbVZrUURRNkNpQWdJQ0F2THlCaVlXTnJaVzVrTDJOdmJuUnlZV04wY3k5aFoyVnVkRjl5WldkcGMzUnllUzV3ZVRvNU1Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCaWVYUmxZeUExSUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3BwYzE5eVpXZHBjM1JsY21Wa1gyRm1kR1Z5WDJsbVgyVnNjMlZBTXpvS0lDQWdJQzh2SUdKaFkydGxibVF2WTI5dWRISmhZM1J6TDJGblpXNTBYM0psWjJsemRISjVMbkI1T2prMkNpQWdJQ0F2THlCeVpYUjFjbTRnYzJWc1ppNXlaV2RwYzNSeWVWdDNZV3hzWlhSZExtRmpkR2wyWlFvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElERXlDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnWW05NFgyVjRkSEpoWTNRZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCblpYUmlhWFFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd3TUFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWMFltbDBDaUFnSUNBdkx5QmlZV05yWlc1a0wyTnZiblJ5WVdOMGN5OWhaMlZ1ZEY5eVpXZHBjM1J5ZVM1d2VUbzVNUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQmlJR2x6WDNKbFoybHpkR1Z5WldSZllXWjBaWEpmYVc1c2FXNWxaRjloWjJWdWRGOXlaV2RwYzNSeWVTNUJaMlZ1ZEZKbFoybHpkSEo1TG1selgzSmxaMmx6ZEdWeVpXUkFOQW9LQ2k4dklHRm5aVzUwWDNKbFoybHpkSEo1TGtGblpXNTBVbVZuYVhOMGNua3VaMlYwWDNKbFkyOXlaRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21kbGRGOXlaV052Y21RNkNpQWdJQ0F2THlCaVlXTnJaVzVrTDJOdmJuUnlZV04wY3k5aFoyVnVkRjl5WldkcGMzUnllUzV3ZVRvNU9Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0F6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0F2THlCaVlXTnJaVzVrTDJOdmJuUnlZV04wY3k5aFoyVnVkRjl5WldkcGMzUnllUzV3ZVRveE1EQUtJQ0FnSUM4dklHVjRhWE4wY3lBOUlITmxiR1l1Y21WbmFYTjBjbmt1YldGNVltVW9kMkZzYkdWMEtWc3hYUW9nSUNBZ1lubDBaV05mTWlBdkx5QXdlRGN5TmpVMk56Vm1DaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0F2THlCaVlXTnJaVzVrTDJOdmJuUnlZV04wY3k5aFoyVnVkRjl5WldkcGMzUnllUzV3ZVRveE1ERUtJQ0FnSUM4dklHRnpjMlZ5ZENCbGVHbHpkSE1zSUNKT2J5QnlaV052Y21RZ1ptOTFibVFnWm05eUlIUm9hWE1nZDJGc2JHVjBJZ29nSUNBZ1lYTnpaWEowSUM4dklFNXZJSEpsWTI5eVpDQm1iM1Z1WkNCbWIzSWdkR2hwY3lCM1lXeHNaWFFLSUNBZ0lDOHZJR0poWTJ0bGJtUXZZMjl1ZEhKaFkzUnpMMkZuWlc1MFgzSmxaMmx6ZEhKNUxuQjVPakV3TWdvZ0lDQWdMeThnY21WMGRYSnVJSE5sYkdZdWNtVm5hWE4wY25sYmQyRnNiR1YwWFFvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnY0c5d0NpQWdJQ0F2THlCaVlXTnJaVzVrTDJOdmJuUnlZV04wY3k5aFoyVnVkRjl5WldkcGMzUnllUzV3ZVRvNU9Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCaWVYUmxZeUExSUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z1lXZGxiblJmY21WbmFYTjBjbmt1UVdkbGJuUlNaV2RwYzNSeWVTNW5aWFJmWTI5dVptbG5XM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWjJWMFgyTnZibVpwWnpvS0lDQWdJQzh2SUdKaFkydGxibVF2WTI5dWRISmhZM1J6TDJGblpXNTBYM0psWjJsemRISjVMbkI1T2pFd05nb2dJQ0FnTHk4Z2NtVjBkWEp1SUdGeVl6UXVWSFZ3YkdVb0tITmxiR1l1YjNkdVpYSXVkbUZzZFdVc0lITmxiR1l1ZEc5MFlXeGZjbVZuYVhOMFpYSmxaQzUyWVd4MVpTd2djMlZzWmk1eVpXZHBjM1J5ZVY5MlpYSnphVzl1TG5aaGJIVmxLU2tLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaWVYUmxZeUEwSUM4dklDSnZkMjVsY2lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXZkMjVsY2lCbGVHbHpkSE1LSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSjBiM1JoYkY5eVpXZHBjM1JsY21Wa0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MblJ2ZEdGc1gzSmxaMmx6ZEdWeVpXUWdaWGhwYzNSekNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZbmwwWldNZ055QXZMeUFpY21WbmFYTjBjbmxmZG1WeWMybHZiaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1eVpXZHBjM1J5ZVY5MlpYSnphVzl1SUdWNGFYTjBjd29nSUNBZ1kyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklHSmhZMnRsYm1RdlkyOXVkSEpoWTNSekwyRm5aVzUwWDNKbFoybHpkSEo1TG5CNU9qRXdOQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQmllWFJsWXlBMUlDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdZV2RsYm5SZmNtVm5hWE4wY25rdVFXZGxiblJTWldkcGMzUnllUzVrWlhKbFoybHpkR1Z5VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1pHVnlaV2RwYzNSbGNqb0tJQ0FnSUM4dklHSmhZMnRsYm1RdlkyOXVkSEpoWTNSekwyRm5aVzUwWDNKbFoybHpkSEo1TG5CNU9qRXdPQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tHRnNiRzkzWDJGamRHbHZibk05V3lKT2IwOXdJbDBwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNBdkx5QmlZV05yWlc1a0wyTnZiblJ5WVdOMGN5OWhaMlZ1ZEY5eVpXZHBjM1J5ZVM1d2VUb3hNVEF0TVRFeENpQWdJQ0F2THlBaklFOTNibVZ5TFc5dWJIa2daM1ZoY21RZ2JYVnpkQ0J5ZFc0Z1ptbHljM1FnZEc4Z1ptRnBiQ0JtWVhOMElHSmxabTl5WlNCaGJua2dRbTk0SUhKbFlXUnpDaUFnSUNBdkx5QmhjM05sY25RZ1ZIaHVMbk5sYm1SbGNpQTlQU0J6Wld4bUxtOTNibVZ5TG5aaGJIVmxMbTVoZEdsMlpTd2dJazl1YkhrZ2RHaGxJR052Ym5SeVlXTjBJRzkzYm1WeUlHTmhiaUJrWlhKbFoybHpkR1Z5SUdGblpXNTBjeUlLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKdmQyNWxjaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1dmQyNWxjaUJsZUdsemRITUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVDI1c2VTQjBhR1VnWTI5dWRISmhZM1FnYjNkdVpYSWdZMkZ1SUdSbGNtVm5hWE4wWlhJZ1lXZGxiblJ6Q2lBZ0lDQXZMeUJpWVdOclpXNWtMMk52Ym5SeVlXTjBjeTloWjJWdWRGOXlaV2RwYzNSeWVTNXdlVG94TVRRS0lDQWdJQzh2SUdWNGFYTjBjeUE5SUhObGJHWXVjbVZuYVhOMGNua3ViV0Y1WW1Vb2RHRnlaMlYwS1ZzeFhRb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VEY3lOalUyTnpWbUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdMeThnWW1GamEyVnVaQzlqYjI1MGNtRmpkSE12WVdkbGJuUmZjbVZuYVhOMGNua3VjSGs2TVRFMUNpQWdJQ0F2THlCaGMzTmxjblFnWlhocGMzUnpMQ0FpVjJGc2JHVjBJRzV2ZENCbWIzVnVaQ0JwYmlCeVpXZHBjM1J5ZVNJS0lDQWdJR0Z6YzJWeWRDQXZMeUJYWVd4c1pYUWdibTkwSUdadmRXNWtJR2x1SUhKbFoybHpkSEo1Q2lBZ0lDQXZMeUJpWVdOclpXNWtMMk52Ym5SeVlXTjBjeTloWjJWdWRGOXlaV2RwYzNSeWVTNXdlVG94TVRjdE1URTRDaUFnSUNBdkx5QnlaV052Y21RZ1BTQnpaV3htTG5KbFoybHpkSEo1VzNSaGNtZGxkRjB1WTI5d2VTZ3BDaUFnSUNBdkx5QnpaV3htTG5KbFoybHpkSEo1VzNSaGNtZGxkRjBnUFNCeVpXTnZjbVF1WDNKbGNHeGhZMlVvWVdOMGFYWmxQV0Z5WXpRdVFtOXZiQ2hHWVd4elpTa3BDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNeUF2THlBeU13b2dJQ0FnYVc1MFkxOHdJQzh2SURJS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQmlkRzlwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUdsdWRHTmZNeUF2THlBeU13b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQW9nSUNBZ1pHbG5JREVLSUNBZ0lHbHVkR05mTUNBdkx5QXlDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0JpZEc5cENpQWdJQ0JrYVdjZ01nb2dJQ0FnWkdsbklERUtJQ0FnSUdsdWRHTmZNQ0F2THlBeUNpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdZblJ2YVFvZ0lDQWdhVzUwWTE4d0lDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXpDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQW9nSUNBZ1pHbG5JRElLSUNBZ0lIQjFjMmhwYm5SeklEUWdPQW9nSUNBZ1ltOTRYMlY0ZEhKaFkzUWdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJR1JwWnlBekNpQWdJQ0J3ZFhOb2FXNTBJREV6Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNZ29nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUdKMGIya0tJQ0FnSUdScFp5QTBDaUFnSUNCa2FXY2dNUW9nSUNBZ2FXNTBZMTh3SUM4dklESUtJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0JpZEc5cENpQWdJQ0JwYm5Salh6QWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JRFVLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQmthV2NnTkFvZ0lDQWdjSFZ6YUdsdWRITWdNVFVnT0FvZ0lDQWdZbTk0WDJWNGRISmhZM1FnTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUM4dklHSmhZMnRsYm1RdlkyOXVkSEpoWTNSekwyRm5aVzUwWDNKbFoybHpkSEo1TG5CNU9qRXhPQW9nSUNBZ0x5OGdjMlZzWmk1eVpXZHBjM1J5ZVZ0MFlYSm5aWFJkSUQwZ2NtVmpiM0prTGw5eVpYQnNZV05sS0dGamRHbDJaVDFoY21NMExrSnZiMndvUm1Gc2MyVXBLUW9nSUNBZ1pHbG5JRFFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklESXpDaUFnSUNCa2FXY2dNUW9nSUNBZ0t3b2dJQ0FnWkhWd0NpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdZbmwwWldOZk15QXZMeUF3ZURBd01UY0tJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JRFlLSUNBZ0lHeGxiZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0FyQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlREF3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ013b2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklEUUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0J6ZDJGd0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QmlZV05yWlc1a0wyTnZiblJ5WVdOMGN5OWhaMlZ1ZEY5eVpXZHBjM1J5ZVM1d2VUb3hNakF0TVRJeUNpQWdJQ0F2THlBaklHUmxZM0psYldWdWRDQmhZM1JwZG1VZ1kyOTFiblFLSUNBZ0lDOHZJQ01nVG05MFpUb2dZV3hzYjNjZ2RXNWtaWEptYkc5M0lIUnZJSEpsZG1WeWRDQnVZWFIxY21Gc2JIa2dhV1lnYVc1amIzSnlaV04wT3lCa1pYQnNiM2x0Wlc1MElITm9iM1ZzWkNCbGJuTjFjbVVnWTI5dWMybHpkR1Z1WTNrS0lDQWdJQzh2SUhObGJHWXVkRzkwWVd4ZmNtVm5hWE4wWlhKbFpDNTJZV3gxWlNBOUlHRnlZelF1VlVsdWREWTBLSE5sYkdZdWRHOTBZV3hmY21WbmFYTjBaWEpsWkM1MllXeDFaUzVoYzE5MWFXNTBOalFvS1NBdElERXBDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWRHOTBZV3hmY21WbmFYTjBaWEpsWkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNTBiM1JoYkY5eVpXZHBjM1JsY21Wa0lHVjRhWE4wY3dvZ0lDQWdZblJ2YVFvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lDMEtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0luUnZkR0ZzWDNKbFoybHpkR1Z5WldRaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z1ltRmphMlZ1WkM5amIyNTBjbUZqZEhNdllXZGxiblJmY21WbmFYTjBjbmt1Y0hrNk1USTBDaUFnSUNBdkx5QmhjbU0wTG1WdGFYUW9Ja0ZuWlc1MFJHVnlaV2RwYzNSbGNtVmtJaXdnZEdGeVoyVjBMQ0J5WldOdmNtUXVZV2RsYm5SZmJtRnRaU3dnY21WamIzSmtMbkp2YkdVcENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHSjVkR1ZqSURnZ0x5OGdNSGd3TURJMENpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaHBiblFnTXpZS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ0t3b2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1HRTFNelk0WmpVZ0x5OGdiV1YwYUc5a0lDSkJaMlZ1ZEVSbGNtVm5hWE4wWlhKbFpDaGhaR1J5WlhOekxITjBjbWx1Wnl4emRISnBibWNwSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJQzh2SUdKaFkydGxibVF2WTI5dWRISmhZM1J6TDJGblpXNTBYM0psWjJsemRISjVMbkI1T2pFd09Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0dGc2JHOTNYMkZqZEdsdmJuTTlXeUpPYjA5d0lsMHBDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z1lXZGxiblJmY21WbmFYTjBjbmt1UVdkbGJuUlNaV2RwYzNSeWVTNXBibU55WlcxbGJuUmZkSEpoYm5OaFkzUnBiMjVmWTI5MWJuUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BwYm1OeVpXMWxiblJmZEhKaGJuTmhZM1JwYjI1ZlkyOTFiblE2Q2lBZ0lDQXZMeUJpWVdOclpXNWtMMk52Ym5SeVlXTjBjeTloWjJWdWRGOXlaV2RwYzNSeWVTNXdlVG94TWpZS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2hoYkd4dmQxOWhZM1JwYjI1elBWc2lUbTlQY0NKZEtRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdMeThnWW1GamEyVnVaQzlqYjI1MGNtRmpkSE12WVdkbGJuUmZjbVZuYVhOMGNua3VjSGs2TVRNeUNpQWdJQ0F2THlCbGVHbHpkSE1nUFNCelpXeG1MbkpsWjJsemRISjVMbTFoZVdKbEtIUmhjbWRsZENsYk1WMEtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZzNNalkxTmpjMVpnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdMeThnWW1GamEyVnVaQzlqYjI1MGNtRmpkSE12WVdkbGJuUmZjbVZuYVhOMGNua3VjSGs2TVRNekNpQWdJQ0F2THlCaGMzTmxjblFnWlhocGMzUnpMQ0FpVjJGc2JHVjBJRzV2ZENCeVpXZHBjM1JsY21Wa0lnb2dJQ0FnWVhOelpYSjBJQzh2SUZkaGJHeGxkQ0J1YjNRZ2NtVm5hWE4wWlhKbFpBb2dJQ0FnTHk4Z1ltRmphMlZ1WkM5amIyNTBjbUZqZEhNdllXZGxiblJmY21WbmFYTjBjbmt1Y0hrNk1UTTBMVEV6TlFvZ0lDQWdMeThnY21WamIzSmtJRDBnYzJWc1ppNXlaV2RwYzNSeWVWdDBZWEpuWlhSZExtTnZjSGtvS1FvZ0lDQWdMeThnYzJWc1ppNXlaV2RwYzNSeWVWdDBZWEpuWlhSZElEMGdjbVZqYjNKa0xsOXlaWEJzWVdObEtIUnZkR0ZzWDNSeVlXNXpZV04wYVc5dWN6MWhjbU0wTGxWSmJuUTJOQ2h5WldOdmNtUXVkRzkwWVd4ZmRISmhibk5oWTNScGIyNXpMbUZ6WDNWcGJuUTJOQ2dwSUNzZ01Ta3BDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNeUF2THlBeU13b2dJQ0FnYVc1MFkxOHdJQzh2SURJS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQmlkRzlwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUdsdWRHTmZNeUF2THlBeU13b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQW9nSUNBZ1pHbG5JREVLSUNBZ0lHbHVkR05mTUNBdkx5QXlDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0JpZEc5cENpQWdJQ0JrYVdjZ01nb2dJQ0FnWkdsbklERUtJQ0FnSUdsdWRHTmZNQ0F2THlBeUNpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdZblJ2YVFvZ0lDQWdhVzUwWTE4d0lDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXpDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQW9nSUNBZ1pHbG5JRElLSUNBZ0lIQjFjMmhwYm5SeklEUWdPQW9nSUNBZ1ltOTRYMlY0ZEhKaFkzUWdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJR1JwWnlBekNpQWdJQ0J3ZFhOb2FXNTBJREV5Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ1ltOTRYMlY0ZEhKaFkzUWdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQm5aWFJpYVhRS0lDQWdJQzh2SUdKaFkydGxibVF2WTI5dWRISmhZM1J6TDJGblpXNTBYM0psWjJsemRISjVMbkI1T2pFek5Rb2dJQ0FnTHk4Z2MyVnNaaTV5WldkcGMzUnllVnQwWVhKblpYUmRJRDBnY21WamIzSmtMbDl5WlhCc1lXTmxLSFJ2ZEdGc1gzUnlZVzV6WVdOMGFXOXVjejFoY21NMExsVkpiblEyTkNoeVpXTnZjbVF1ZEc5MFlXeGZkSEpoYm5OaFkzUnBiMjV6TG1GelgzVnBiblEyTkNncElDc2dNU2twQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TURBS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhObGRHSnBkQW9nSUNBZ0x5OGdZbUZqYTJWdVpDOWpiMjUwY21GamRITXZZV2RsYm5SZmNtVm5hWE4wY25rdWNIazZNVE0wTFRFek5Rb2dJQ0FnTHk4Z2NtVmpiM0prSUQwZ2MyVnNaaTV5WldkcGMzUnllVnQwWVhKblpYUmRMbU52Y0hrb0tRb2dJQ0FnTHk4Z2MyVnNaaTV5WldkcGMzUnllVnQwWVhKblpYUmRJRDBnY21WamIzSmtMbDl5WlhCc1lXTmxLSFJ2ZEdGc1gzUnlZVzV6WVdOMGFXOXVjejFoY21NMExsVkpiblEyTkNoeVpXTnZjbVF1ZEc5MFlXeGZkSEpoYm5OaFkzUnBiMjV6TG1GelgzVnBiblEyTkNncElDc2dNU2twQ2lBZ0lDQmthV2NnTkFvZ0lDQWdjSFZ6YUdsdWRDQXhNd29nSUNBZ2FXNTBZMTh3SUM4dklESUtJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0JpZEc5cENpQWdJQ0JrYVdjZ05Rb2dJQ0FnWkdsbklERUtJQ0FnSUdsdWRHTmZNQ0F2THlBeUNpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdZblJ2YVFvZ0lDQWdhVzUwWTE4d0lDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QTJDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQW9nSUNBZ1pHbG5JRFVLSUNBZ0lIQjFjMmhwYm5SeklERTFJRGdLSUNBZ0lHSnZlRjlsZUhSeVlXTjBJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0J2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0F2THlCaVlXTnJaVzVrTDJOdmJuUnlZV04wY3k5aFoyVnVkRjl5WldkcGMzUnllUzV3ZVRveE16VUtJQ0FnSUM4dklITmxiR1l1Y21WbmFYTjBjbmxiZEdGeVoyVjBYU0E5SUhKbFkyOXlaQzVmY21Wd2JHRmpaU2gwYjNSaGJGOTBjbUZ1YzJGamRHbHZibk05WVhKak5DNVZTVzUwTmpRb2NtVmpiM0prTG5SdmRHRnNYM1J5WVc1ellXTjBhVzl1Y3k1aGMxOTFhVzUwTmpRb0tTQXJJREVwS1FvZ0lDQWdZblJ2YVFvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lDc0tJQ0FnSUdsMGIySUtJQ0FnSUdScFp5QTFDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBeU13b2dJQ0FnS3dvZ0lDQWdaSFZ3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ1lubDBaV05mTXlBdkx5QXdlREF3TVRjS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklEWUtJQ0FnSUd4bGJnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQXJDaUFnSUNCemQyRndDaUFnSUNCMWJtTnZkbVZ5SURVS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBeENpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJR0poWTJ0bGJtUXZZMjl1ZEhKaFkzUnpMMkZuWlc1MFgzSmxaMmx6ZEhKNUxuQjVPakV5TmdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLR0ZzYkc5M1gyRmpkR2x2Ym5NOVd5Sk9iMDl3SWwwcENpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQWdBQkZ5WUpFSFJ2ZEdGc1gzSmxaMmx6ZEdWeVpXUUJBQVJ5WldkZkFnQVhCVzkzYm1WeUJCVWZmSFVJQUFBQUFBQUFBQUFRY21WbmFYTjBjbmxmZG1WeWMybHZiZ0lBSkRFWVFBQVdKd1F4QUdjb0p3Wm5Kd2VBQ0FBQUFBQUFBQUFCWnpFYlFRQTVNUmtVUkRFWVJJSUdCQU9pL0U4RWtad0Mzd1FRMlFFYUJJMTZGK1FFbXFLQzFRUnpMR0UrTmhvQWpnWUFDUUd1QWRnQjhnSU1Bc29BTVJrVU1SZ1VFRU1qUndJMkdnRkhBaU5aSWdoTUZVbFBBaEpFTmhvQ1J3SWpXU0lJU3dFVlNVNERFa1EyR2dOSlRnSkpJMWtpQ0V3VkVrU0FCd0FGWW5WNVpYSVNRQUFoU3dLQUNRQUhZM1Z5WVhSdmNoSkFBQkJMQW9BSUFBWnpaV3hzWlhJU1FRRkFKRVF4QUVsRkNDcE1VRWxGQjcxRkFVc0ZWd0lBZ0F4dFpYSmpZWFJ2Y2pwMk1YeE1VSUFCZkZBeEFGQ0FBWHhRU3dSWEFnQlFTd0pYQWdCZUFURUFoRVJCQUxwTEJZRU1KTG9qVXlralR3SlVTVVVKS1JOQkFGeExCVW1EQWdRSXVrc0Jnd0lQQ0xvbFN3Y0lTUlpYQmdJclRGQk1Td1lJVEU4RFVFc0xVRXdXVndZQ1VFeFFTd1pRU3dSUVN3SlFTd0c4U0w5TEJpY0lVSUVrU3dVSUZsY0dBbEJMQlZCTEExQ0FCRWNGVWtsTVVMQWtReklHRmtzR1NVNENnd0lQQ0xvbFN3Y0lTUlpYQmdJclRGQk1Td1lJVEU4RFVJQUJnRkJNRmxjR0FsQk1VRXNHVUVzRVVFc0NVRXNCdkVpL0l5aGxSQmNrQ0JZb1RHZEMvNWN5QmhZbFN3VUlTUlpYQmdJclRGQk1Td1FJVEU4Q1VJQUJnRkJNRmxjR0FsQW5CbEJMQlZCTEExQkxBVkJMQmttOFNFeS9JeWhsUkJja0NCWW9UR2RDLzFValF2NjlOaG9CU1JXQklCSkVLa3hRU2IxRkFVQUFDQ2tuQlV4UXNDUkRTWUVNSkxvalV5a2pUd0pVUXYvcU5ob0JTUldCSUJKRUtreFFTYjFGQVVTK1NDY0ZURkN3SkVNakp3UmxSQ01vWlVRakp3ZGxSRTRDVUV4UUp3Vk1VTEFrUXpZYUFVa1ZnU0FTUkRFQUl5Y0VaVVFTUkNwTEFWQkp2VVVCUkVrbElyb1hJZ2hMQVNWUEFycExBU0pKdWhkTEFrc0JJcm9YSWdoTEEwNEN1a3NDZ3dJRUNMcExBNEVOSXJvWFN3UkxBU0s2RnlJSVN3Vk9BcnBMQklNQ0R3aTZTd1FWSlVzQkNFa1dWd1lDSzB4UVN3WVZUd0lJVEU4RlVDbFFUQlpYQmdKUVR3SlFTd1JRU3dOUVR3SlFTd1M4U0U4RVRMOGpLR1ZFRnlRSkZpaE1aMDhESndoUWdTUlBBZ2dXVndZQ1VFOENVRXhRZ0FRS1UyajFURkN3SkVNMkdnRkpGWUVnRWtRcVRGQkp2VVVCUkVrbElyb1hJZ2hMQVNWUEFycExBU0pKdWhkTEFrc0JJcm9YSWdoTEEwNEN1a3NDZ3dJRUNMcExBNEVNSkxvalV5a2pUd0pVU3dTQkRTSzZGMHNGU3dFaXVoY2lDRXNHVGdLNlN3V0RBZzhJdWhja0NCWkxCUlVsQ0VrV1Z3WUNLMHhRU3dZVlR3SUlURThGVUU4RVVFd1dWd1lDVUV4UVR3TlFUd0pRVEZCTEFieEl2eVJEIiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OCwicGF0Y2giOjEsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbeyJuYW1lIjoiQWdlbnRSZWdpc3RlcmVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDEiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDMiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IkFnZW50RGVyZWdpc3RlcmVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDEiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDMiLCJkZXNjIjpudWxsfV19XSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
