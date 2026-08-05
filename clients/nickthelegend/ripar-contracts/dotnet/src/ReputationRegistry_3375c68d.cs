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

namespace Arc56.Generated.nickthelegend.ripar_contracts.ReputationRegistry_3375c68d
{


    public class ReputationRegistryProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ReputationRegistryProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class Score : AVMObjectType
            {
                public ulong AgentId { get; set; }

                public ulong JobsPaid { get; set; }

                public ulong VolumeMicro { get; set; }

                public ulong Validated { get; set; }

                public ulong Disputed { get; set; }

                public ulong FirstAt { get; set; }

                public ulong LastAt { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAgentId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAgentId.From(AgentId);
                    ret.AddRange(vAgentId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vJobsPaid = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vJobsPaid.From(JobsPaid);
                    ret.AddRange(vJobsPaid.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVolumeMicro = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vVolumeMicro.From(VolumeMicro);
                    ret.AddRange(vVolumeMicro.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vValidated = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vValidated.From(Validated);
                    ret.AddRange(vValidated.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDisputed = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vDisputed.From(Disputed);
                    ret.AddRange(vDisputed.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFirstAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vFirstAt.From(FirstAt);
                    ret.AddRange(vFirstAt.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLastAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vLastAt.From(LastAt);
                    ret.AddRange(vLastAt.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Score Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Score();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAgentId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAgentId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAgentId = vAgentId.ToValue();
                    if (valueAgentId is ulong vAgentIdValue) { ret.AgentId = vAgentIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vJobsPaid = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vJobsPaid.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueJobsPaid = vJobsPaid.ToValue();
                    if (valueJobsPaid is ulong vJobsPaidValue) { ret.JobsPaid = vJobsPaidValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVolumeMicro = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vVolumeMicro.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueVolumeMicro = vVolumeMicro.ToValue();
                    if (valueVolumeMicro is ulong vVolumeMicroValue) { ret.VolumeMicro = vVolumeMicroValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vValidated = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vValidated.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueValidated = vValidated.ToValue();
                    if (valueValidated is ulong vValidatedValue) { ret.Validated = vValidatedValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDisputed = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vDisputed.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDisputed = vDisputed.ToValue();
                    if (valueDisputed is ulong vDisputedValue) { ret.Disputed = vDisputedValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFirstAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vFirstAt.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFirstAt = vFirstAt.ToValue();
                    if (valueFirstAt is ulong vFirstAtValue) { ret.FirstAt = vFirstAtValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLastAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vLastAt.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueLastAt = vLastAt.ToValue();
                    if (valueLastAt is ulong vLastAtValue) { ret.LastAt = vLastAtValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Score);
                }
                public bool Equals(Score? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Score left, Score right)
                {
                    return EqualityComparer<Score>.Default.Equals(left, right);
                }
                public static bool operator !=(Score left, Score right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Point at the Identity Registry and fix the settlement asset.
        ///The asset is set once and never changed, so a score always means the same thing. Without it accept_feedback would have to trust whatever asset a caller transferred, and reputation could be bought with a worthless one minted for the purpose.
        ///</summary>
        /// <param name="identity_app"> </param>
        /// <param name="usdc_asset"> </param>
        public async Task<bool> Bootstrap(ulong identity_app, ulong usdc_asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 95, 6, 226, 222 };
            var identity_appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); identity_appAbi.From(identity_app);
            var usdc_assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); usdc_assetAbi.From(usdc_asset);

            var result = await base.CallApp(new List<object> { abiHandle, identity_appAbi, usdc_assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Bootstrap_Transactions(ulong identity_app, ulong usdc_asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 95, 6, 226, 222 };
            var identity_appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); identity_appAbi.From(identity_app);
            var usdc_assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); usdc_assetAbi.From(usdc_asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, identity_appAbi, usdc_assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Credit a server agent for one settled payment. Returns its new count.
        ///The payment is passed as a TRANSACTION IN THIS GROUP, not as an id and an amount the caller supplies. That distinction is the whole point.
        ///The previous signature took a 32-byte id and a number, and checked only that the id was 32 bytes long and unseen. Nothing tied either value to a transfer that had actually happened, so any 32 bytes bought a point of reputation — an audit found two counted payments on TestNet that resolve to no transaction at all, one of them 32 zero bytes. The docstring claiming a score "cannot be inflated by anything that did not move USDC" was simply untrue.
        ///Now the amount and the id are READ OFF the transfer the AVM has already validated, so they cannot be fabricated: to earn a point you must move the asset, in the same atomic group, in the same round.
        ///</summary>
        /// <param name="payment"> </param>
        /// <param name="server_agent_id"> </param>
        /// <param name="client_agent_id"> </param>
        public async Task<ulong> AcceptFeedback(AssetTransferTransaction payment, ulong server_agent_id, ulong client_agent_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 20, 24, 35, 59 };
            var server_agent_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); server_agent_idAbi.From(server_agent_id);
            var client_agent_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); client_agent_idAbi.From(client_agent_id);

            var result = await base.CallApp(new List<object> { abiHandle, payment, server_agent_idAbi, client_agent_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> AcceptFeedback_Transactions(AssetTransferTransaction payment, ulong server_agent_id, ulong client_agent_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 20, 24, 35, 59 };
            var server_agent_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); server_agent_idAbi.From(server_agent_id);
            var client_agent_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); client_agent_idAbi.From(client_agent_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, payment, server_agent_idAbi, client_agent_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Called by the Validation Registry once a result is judged.
        ///</summary>
        /// <param name="server_agent_id"> </param>
        /// <param name="passed"> </param>
        public async Task<bool> RecordValidation(ulong server_agent_id, bool passed, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 59, 80, 93, 166 };
            var server_agent_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); server_agent_idAbi.From(server_agent_id);
            var passedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); passedAbi.From(passed);

            var result = await base.CallApp(new List<object> { abiHandle, server_agent_idAbi, passedAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> RecordValidation_Transactions(ulong server_agent_id, bool passed, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 59, 80, 93, 166 };
            var server_agent_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); server_agent_idAbi.From(server_agent_id);
            var passedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); passedAbi.From(passed);

            return await base.MakeTransactionList(new List<object> { abiHandle, server_agent_idAbi, passedAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="agent_id"> </param>
        public async Task<Structs.Score> GetScore(ulong agent_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 126, 144, 160 };
            var agent_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); agent_idAbi.From(agent_id);

            var result = await base.SimApp(new List<object> { abiHandle, agent_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.Score.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetScore_Transactions(ulong agent_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 126, 144, 160 };
            var agent_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); agent_idAbi.From(agent_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, agent_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Which agent a payment was credited to, or 0 if never counted.
        ///</summary>
        /// <param name="payment_txid"> </param>
        public async Task<ulong> WasCounted(byte[] payment_txid, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 77, 15, 98, 165 };
            var payment_txidAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); payment_txidAbi.From(payment_txid);

            var result = await base.SimApp(new List<object> { abiHandle, payment_txidAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> WasCounted_Transactions(byte[] payment_txid, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 77, 15, 98, 165 };
            var payment_txidAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); payment_txidAbi.From(payment_txid);

            return await base.MakeTransactionList(new List<object> { abiHandle, payment_txidAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUmVwdXRhdGlvblJlZ2lzdHJ5IiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IlNjb3JlIjpbeyJuYW1lIjoiYWdlbnRfaWQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiam9ic19wYWlkIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InZvbHVtZV9taWNybyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ2YWxpZGF0ZWQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZGlzcHV0ZWQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmlyc3RfYXQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoibGFzdF9hdCIsInR5cGUiOiJ1aW50NjQifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiYm9vdHN0cmFwIiwiZGVzYyI6IlBvaW50IGF0IHRoZSBJZGVudGl0eSBSZWdpc3RyeSBhbmQgZml4IHRoZSBzZXR0bGVtZW50IGFzc2V0LlxuVGhlIGFzc2V0IGlzIHNldCBvbmNlIGFuZCBuZXZlciBjaGFuZ2VkLCBzbyBhIHNjb3JlIGFsd2F5cyBtZWFucyB0aGUgc2FtZSB0aGluZy4gV2l0aG91dCBpdCBhY2NlcHRfZmVlZGJhY2sgd291bGQgaGF2ZSB0byB0cnVzdCB3aGF0ZXZlciBhc3NldCBhIGNhbGxlciB0cmFuc2ZlcnJlZCwgYW5kIHJlcHV0YXRpb24gY291bGQgYmUgYm91Z2h0IHdpdGggYSB3b3J0aGxlc3Mgb25lIG1pbnRlZCBmb3IgdGhlIHB1cnBvc2UuIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImlkZW50aXR5X2FwcCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidXNkY19hc3NldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhY2NlcHRfZmVlZGJhY2siLCJkZXNjIjoiQ3JlZGl0IGEgc2VydmVyIGFnZW50IGZvciBvbmUgc2V0dGxlZCBwYXltZW50LiBSZXR1cm5zIGl0cyBuZXcgY291bnQuXG5UaGUgcGF5bWVudCBpcyBwYXNzZWQgYXMgYSBUUkFOU0FDVElPTiBJTiBUSElTIEdST1VQLCBub3QgYXMgYW4gaWQgYW5kIGFuIGFtb3VudCB0aGUgY2FsbGVyIHN1cHBsaWVzLiBUaGF0IGRpc3RpbmN0aW9uIGlzIHRoZSB3aG9sZSBwb2ludC5cblRoZSBwcmV2aW91cyBzaWduYXR1cmUgdG9vayBhIDMyLWJ5dGUgaWQgYW5kIGEgbnVtYmVyLCBhbmQgY2hlY2tlZCBvbmx5IHRoYXQgdGhlIGlkIHdhcyAzMiBieXRlcyBsb25nIGFuZCB1bnNlZW4uIE5vdGhpbmcgdGllZCBlaXRoZXIgdmFsdWUgdG8gYSB0cmFuc2ZlciB0aGF0IGhhZCBhY3R1YWxseSBoYXBwZW5lZCwgc28gYW55IDMyIGJ5dGVzIGJvdWdodCBhIHBvaW50IG9mIHJlcHV0YXRpb24g4oCUIGFuIGF1ZGl0IGZvdW5kIHR3byBjb3VudGVkIHBheW1lbnRzIG9uIFRlc3ROZXQgdGhhdCByZXNvbHZlIHRvIG5vIHRyYW5zYWN0aW9uIGF0IGFsbCwgb25lIG9mIHRoZW0gMzIgemVybyBieXRlcy4gVGhlIGRvY3N0cmluZyBjbGFpbWluZyBhIHNjb3JlIFwiY2Fubm90IGJlIGluZmxhdGVkIGJ5IGFueXRoaW5nIHRoYXQgZGlkIG5vdCBtb3ZlIFVTRENcIiB3YXMgc2ltcGx5IHVudHJ1ZS5cbk5vdyB0aGUgYW1vdW50IGFuZCB0aGUgaWQgYXJlIFJFQUQgT0ZGIHRoZSB0cmFuc2ZlciB0aGUgQVZNIGhhcyBhbHJlYWR5IHZhbGlkYXRlZCwgc28gdGhleSBjYW5ub3QgYmUgZmFicmljYXRlZDogdG8gZWFybiBhIHBvaW50IHlvdSBtdXN0IG1vdmUgdGhlIGFzc2V0LCBpbiB0aGUgc2FtZSBhdG9taWMgZ3JvdXAsIGluIHRoZSBzYW1lIHJvdW5kLiIsImFyZ3MiOlt7InR5cGUiOiJheGZlciIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheW1lbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNlcnZlcl9hZ2VudF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2xpZW50X2FnZW50X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVjb3JkX3ZhbGlkYXRpb24iLCJkZXNjIjoiQ2FsbGVkIGJ5IHRoZSBWYWxpZGF0aW9uIFJlZ2lzdHJ5IG9uY2UgYSByZXN1bHQgaXMganVkZ2VkLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzZXJ2ZXJfYWdlbnRfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXNzZWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3Njb3JlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFnZW50X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiU2NvcmUiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Indhc19jb3VudGVkIiwiZGVzYyI6IldoaWNoIGFnZW50IGEgcGF5bWVudCB3YXMgY3JlZGl0ZWQgdG8sIG9yIDAgaWYgbmV2ZXIgY291bnRlZC4iLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5bWVudF90eGlkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MiwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzE5N10sImVycm9yTWVzc2FnZSI6ImEgemVyby12YWx1ZSBwYXltZW50IGVhcm5zIG5vdGhpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDhdLCJlcnJvck1lc3NhZ2UiOiJhbHJlYWR5IGJvb3RzdHJhcHBlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIxN10sImVycm9yTWVzc2FnZSI6ImFuIGFnZW50IGNhbm5vdCBwYXkgaXRzZWxmIGludG8gYSByZXB1dGF0aW9uIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQ2XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5pZGVudGl0eV9hcHAgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzU1LDQ1OF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuc2NvcmVzIGVudHJ5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQyM10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuc2VlbiBlbnRyeSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDVdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnVzZGNfYXNzZXQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQyXSwiZXJyb3JNZXNzYWdlIjoiY3JlYXRvciBvbmx5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzk2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjc3XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuYm9vbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQwNF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjgsMTM2LDE4MywxOTEsMjY5LDMzOV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIwN10sImVycm9yTWVzc2FnZSI6InJlcHV0YXRpb24gaXMgZGVub21pbmF0ZWQgaW4gb25lIGFzc2V0OyB0aGlzIHRyYW5zZmVyIGlzIG5vdCBpdCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1MV0sImVycm9yTWVzc2FnZSI6InRoZSBzZXR0bGVtZW50IGFzc2V0IG11c3QgYmUgc2V0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTc1XSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBheGZlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXhJREFnT0FvZ0lDQWdZbmwwWldOaWJHOWpheUF3ZURjek5qTTFaaUFpYVdSbGJuUnBkSGxmWVhCd0lpQWlkWE5rWTE5aGMzTmxkQ0lnTUhneE5URm1OMk0zTlNBd2VERTFNV1kzWXpjMU9EQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmlibm9nYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5eVpYQjFkR0YwYVc5dVgzSmxaMmx6ZEhKNUxuQjVPalV3Q2lBZ0lDQXZMeUJ6Wld4bUxtbGtaVzUwYVhSNVgyRndjQ0E5SUZWSmJuUTJOQ2d3S1FvZ0lDQWdZbmwwWldOZk1TQXZMeUFpYVdSbGJuUnBkSGxmWVhCd0lnb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmNtVndkWFJoZEdsdmJsOXlaV2RwYzNSeWVTNXdlVG8xTVMwMU13b2dJQ0FnTHk4Z0l5QlhhR2xqYUNCaGMzTmxkQ0JqYjNWdWRITXVJRk5sZENCaGRDQmliMjkwYzNSeVlYQTdJR0VnZEhKaGJuTm1aWElnYjJZZ1lXNTVkR2hwYm1jZ1pXeHpaUW9nSUNBZ0x5OGdJeUJwY3lCeVpXWjFjMlZrSUhKaGRHaGxjaUIwYUdGdUlITnBiR1Z1ZEd4NUlHTnlaV1JwZEdWa0xnb2dJQ0FnTHk4Z2MyVnNaaTUxYzJSalgyRnpjMlYwSUQwZ1ZVbHVkRFkwS0RBcENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKMWMyUmpYMkZ6YzJWMElnb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENncHRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNam9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl5WlhCMWRHRjBhVzl1WDNKbFoybHpkSEo1TG5CNU9qUTRDaUFnSUNBdkx5QmpiR0Z6Y3lCU1pYQjFkR0YwYVc5dVVtVm5hWE4wY25rb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQmllaUJ0WVdsdVgxOWZZV3huYjNCNVgyUmxabUYxYkhSZlkzSmxZWFJsUURFMENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhnMVpqQTJaVEprWlNBd2VERTBNVGd5TXpOaUlEQjRNMkkxTURWa1lUWWdNSGd5TkRkbE9UQmhNQ0F3ZURSa01HWTJNbUUxSUM4dklHMWxkR2h2WkNBaVltOXZkSE4wY21Gd0tIVnBiblEyTkN4MWFXNTBOalFwWW05dmJDSXNJRzFsZEdodlpDQWlZV05qWlhCMFgyWmxaV1JpWVdOcktHRjRabVZ5TEhWcGJuUTJOQ3gxYVc1ME5qUXBkV2x1ZERZMElpd2diV1YwYUc5a0lDSnlaV052Y21SZmRtRnNhV1JoZEdsdmJpaDFhVzUwTmpRc1ltOXZiQ2xpYjI5c0lpd2diV1YwYUc5a0lDSm5aWFJmYzJOdmNtVW9kV2x1ZERZMEtTaDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFwSWl3Z2JXVjBhRzlrSUNKM1lYTmZZMjkxYm5SbFpDaGllWFJsVzEwcGRXbHVkRFkwSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ1ltOXZkSE4wY21Gd0lHRmpZMlZ3ZEY5bVpXVmtZbUZqYXlCeVpXTnZjbVJmZG1Gc2FXUmhkR2x2YmlCblpYUmZjMk52Y21VZ2QyRnpYMk52ZFc1MFpXUUtJQ0FnSUdWeWNnb0tiV0ZwYmw5ZlgyRnNaMjl3ZVY5a1pXWmhkV3gwWDJOeVpXRjBaVUF4TkRvS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBaENpQWdJQ0FtSmdvZ0lDQWdjbVYwZFhKdUNnb0tMeThnY21Wd2RYUmhkR2x2Ymw5eVpXZHBjM1J5ZVM1U1pYQjFkR0YwYVc5dVVtVm5hWE4wY25rdVltOXZkSE4wY21Gd1czSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZbTl2ZEhOMGNtRndPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMM0psY0hWMFlYUnBiMjVmY21WbmFYTjBjbmt1Y0hrNk5qRUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMM0psY0hWMFlYUnBiMjVmY21WbmFYTjBjbmt1Y0hrNk56QUtJQ0FnSUM4dklHRnpjMlZ5ZENCVWVHNHVjMlZ1WkdWeUlEMDlJRWRzYjJKaGJDNWpjbVZoZEc5eVgyRmtaSEpsYzNNc0lDSmpjbVZoZEc5eUlHOXViSGtpQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCbmJHOWlZV3dnUTNKbFlYUnZja0ZrWkhKbGMzTUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnWTNKbFlYUnZjaUJ2Ym14NUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmNtVndkWFJoZEdsdmJsOXlaV2RwYzNSeWVTNXdlVG8zTVFvZ0lDQWdMeThnWVhOelpYSjBJSE5sYkdZdWFXUmxiblJwZEhsZllYQndJRDA5SURBc0lDSmhiSEpsWVdSNUlHSnZiM1J6ZEhKaGNIQmxaQ0lLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaWVYUmxZMTh4SUM4dklDSnBaR1Z1ZEdsMGVWOWhjSEFpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWFXUmxiblJwZEhsZllYQndJR1Y0YVhOMGN3b2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJR0ZzY21WaFpIa2dZbTl2ZEhOMGNtRndjR1ZrQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12Y21Wd2RYUmhkR2x2Ymw5eVpXZHBjM1J5ZVM1d2VUbzNNZ29nSUNBZ0x5OGdZWE56WlhKMElIVnpaR05mWVhOelpYUXVibUYwYVhabElDRTlJREFzSUNKMGFHVWdjMlYwZEd4bGJXVnVkQ0JoYzNObGRDQnRkWE4wSUdKbElITmxkQ0lLSUNBZ0lHSjBiMmtLSUNBZ0lHUjFjQW9nSUNBZ1lYTnpaWEowSUM4dklIUm9aU0J6WlhSMGJHVnRaVzUwSUdGemMyVjBJRzExYzNRZ1ltVWdjMlYwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12Y21Wd2RYUmhkR2x2Ymw5eVpXZHBjM1J5ZVM1d2VUbzNNd29nSUNBZ0x5OGdjMlZzWmk1cFpHVnVkR2wwZVY5aGNIQWdQU0JwWkdWdWRHbDBlVjloY0hBdWJtRjBhWFpsQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmlkRzlwQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0pwWkdWdWRHbDBlVjloY0hBaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwzSmxjSFYwWVhScGIyNWZjbVZuYVhOMGNua3VjSGs2TnpRS0lDQWdJQzh2SUhObGJHWXVkWE5rWTE5aGMzTmxkQ0E5SUhWelpHTmZZWE56WlhRdWJtRjBhWFpsQ2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0oxYzJSalgyRnpjMlYwSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5eVpYQjFkR0YwYVc5dVgzSmxaMmx6ZEhKNUxuQjVPall4Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z01IZ3hOVEZtTjJNM05UZ3dDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCeVpYQjFkR0YwYVc5dVgzSmxaMmx6ZEhKNUxsSmxjSFYwWVhScGIyNVNaV2RwYzNSeWVTNWhZMk5sY0hSZlptVmxaR0poWTJ0YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGhZMk5sY0hSZlptVmxaR0poWTJzNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmNtVndkWFJoZEdsdmJsOXlaV2RwYzNSeWVTNXdlVG81TWdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUMwS0lDQWdJR1IxY0FvZ0lDQWdaM1I0Ym5NZ1ZIbHdaVVZ1ZFcwS0lDQWdJSEIxYzJocGJuUWdOQ0F2THlCaGVHWmxjZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCMGNtRnVjMkZqZEdsdmJpQjBlWEJsSUdseklHRjRabVZ5Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZjbVZ3ZFhSaGRHbHZibDl5WldkcGMzUnllUzV3ZVRveE1UWUtJQ0FnSUM4dklHRnpjMlZ5ZENCd1lYbHRaVzUwTG1GemMyVjBYMkZ0YjNWdWRDQStJREFzSUNKaElIcGxjbTh0ZG1Gc2RXVWdjR0Y1YldWdWRDQmxZWEp1Y3lCdWIzUm9hVzVuSWdvZ0lDQWdaR2xuSURJS0lDQWdJR2QwZUc1eklFRnpjMlYwUVcxdmRXNTBDaUFnSUNCa2RYQUtJQ0FnSUdGemMyVnlkQ0F2THlCaElIcGxjbTh0ZG1Gc2RXVWdjR0Y1YldWdWRDQmxZWEp1Y3lCdWIzUm9hVzVuQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12Y21Wd2RYUmhkR2x2Ymw5eVpXZHBjM1J5ZVM1d2VUb3hNVGdLSUNBZ0lDOHZJSEJoZVcxbGJuUXVlR1psY2w5aGMzTmxkQzVwWkNBOVBTQnpaV3htTG5WelpHTmZZWE56WlhRS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1ozUjRibk1nV0dabGNrRnpjMlYwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1lubDBaV05mTWlBdkx5QWlkWE5rWTE5aGMzTmxkQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1MWMyUmpYMkZ6YzJWMElHVjRhWE4wY3dvZ0lDQWdQVDBLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl5WlhCMWRHRjBhVzl1WDNKbFoybHpkSEo1TG5CNU9qRXhOeTB4TVRrS0lDQWdJQzh2SUdGemMyVnlkQ0FvQ2lBZ0lDQXZMeUFnSUNBZ2NHRjViV1Z1ZEM1NFptVnlYMkZ6YzJWMExtbGtJRDA5SUhObGJHWXVkWE5rWTE5aGMzTmxkQW9nSUNBZ0x5OGdLU3dnSW5KbGNIVjBZWFJwYjI0Z2FYTWdaR1Z1YjIxcGJtRjBaV1FnYVc0Z2IyNWxJR0Z6YzJWME95QjBhR2x6SUhSeVlXNXpabVZ5SUdseklHNXZkQ0JwZENJS0lDQWdJR0Z6YzJWeWRDQXZMeUJ5WlhCMWRHRjBhVzl1SUdseklHUmxibTl0YVc1aGRHVmtJR2x1SUc5dVpTQmhjM05sZERzZ2RHaHBjeUIwY21GdWMyWmxjaUJwY3lCdWIzUWdhWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl5WlhCMWRHRjBhVzl1WDNKbFoybHpkSEo1TG5CNU9qRXlNUW9nSUNBZ0x5OGdjMlZ5ZG1WeVgyRm5aVzUwWDJsa0xtNWhkR2wyWlNBaFBTQmpiR2xsYm5SZllXZGxiblJmYVdRdWJtRjBhWFpsQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdKMGIya0tJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZblJ2YVFvZ0lDQWdaR2xuSURFS0lDQWdJQ0U5Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12Y21Wd2RYUmhkR2x2Ymw5eVpXZHBjM1J5ZVM1d2VUb3hNakF0TVRJeUNpQWdJQ0F2THlCaGMzTmxjblFnS0FvZ0lDQWdMeThnSUNBZ0lITmxjblpsY2w5aFoyVnVkRjlwWkM1dVlYUnBkbVVnSVQwZ1kyeHBaVzUwWDJGblpXNTBYMmxrTG01aGRHbDJaUW9nSUNBZ0x5OGdLU3dnSW1GdUlHRm5aVzUwSUdOaGJtNXZkQ0J3WVhrZ2FYUnpaV3htSUdsdWRHOGdZU0J5WlhCMWRHRjBhVzl1SWdvZ0lDQWdZWE56WlhKMElDOHZJR0Z1SUdGblpXNTBJR05oYm01dmRDQndZWGtnYVhSelpXeG1JR2x1ZEc4Z1lTQnlaWEIxZEdGMGFXOXVDaUFnSUNBdkx5QmpiMjUwY21GamRITXZjbVZ3ZFhSaGRHbHZibDl5WldkcGMzUnllUzV3ZVRveE16WUtJQ0FnSUM4dklITWdQU0J6Wld4bUxsOTBiM1ZqYUNoemFXUXBDaUFnSUNCa2RYQUtJQ0FnSUdOaGJHeHpkV0lnWDNSdmRXTm9DaUFnSUNBdkx5QmpiMjUwY21GamRITXZjbVZ3ZFhSaGRHbHZibDl5WldkcGMzUnllUzV3ZVRveE16Y0tJQ0FnSUM4dklITXVhbTlpYzE5d1lXbGtJRDBnWVhKak5DNVZTVzUwTmpRb2N5NXFiMkp6WDNCaGFXUXVibUYwYVhabElDc2dNU2tLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdhWFJ2WWdvZ0lDQWdjbVZ3YkdGalpUSWdPQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMM0psY0hWMFlYUnBiMjVmY21WbmFYTjBjbmt1Y0hrNk1UTTRDaUFnSUNBdkx5QnpMblp2YkhWdFpWOXRhV055YnlBOUlHRnlZelF1VlVsdWREWTBLSE11ZG05c2RXMWxYMjFwWTNKdkxtNWhkR2wyWlNBcklIQmhlVzFsYm5RdVlYTnpaWFJmWVcxdmRXNTBLUW9nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURFMkNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQXJDaUFnSUNCcGRHOWlDaUFnSUNCeVpYQnNZV05sTWlBeE5nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwzSmxjSFYwWVhScGIyNWZjbVZuYVhOMGNua3VjSGs2TVRNNUNpQWdJQ0F2THlCekxteGhjM1JmWVhRZ1BTQmhjbU0wTGxWSmJuUTJOQ2hIYkc5aVlXd3ViR0YwWlhOMFgzUnBiV1Z6ZEdGdGNDa0tJQ0FnSUdkc2IySmhiQ0JNWVhSbGMzUlVhVzFsYzNSaGJYQUtJQ0FnSUdsMGIySUtJQ0FnSUhKbGNHeGhZMlV5SURRNENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmNtVndkWFJoZEdsdmJsOXlaV2RwYzNSeWVTNXdlVG94TkRBS0lDQWdJQzh2SUhObGJHWXVjMk52Y21WelczTnBaRjBnUFNCekxtTnZjSGtvS1FvZ0lDQWdjM2RoY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURjek5qTTFaZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwzSmxjSFYwWVhScGIyNWZjbVZuYVhOMGNua3VjSGs2TVRReUNpQWdJQ0F2THlCeVpYUjFjbTRnWVhKak5DNVZTVzUwTmpRb2N5NXFiMkp6WDNCaGFXUXVibUYwYVhabEtRb2dJQ0FnWlhoMGNtRmpkQ0E0SURnS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5eVpYQjFkR0YwYVc5dVgzSmxaMmx6ZEhKNUxuQjVPamt5Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdKNWRHVmpYek1nTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCeVpYQjFkR0YwYVc5dVgzSmxaMmx6ZEhKNUxsSmxjSFYwWVhScGIyNVNaV2RwYzNSeWVTNXlaV052Y21SZmRtRnNhV1JoZEdsdmJsdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbkpsWTI5eVpGOTJZV3hwWkdGMGFXOXVPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMM0psY0hWMFlYUnBiMjVmY21WbmFYTjBjbmt1Y0hrNk1UUTBDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1aWIyOXNDaUFnSUNBdkx5QmpiMjUwY21GamRITXZjbVZ3ZFhSaGRHbHZibDl5WldkcGMzUnllUzV3ZVRveE5EY0tJQ0FnSUM4dklITnBaQ0E5SUhObGNuWmxjbDloWjJWdWRGOXBaQzV1WVhScGRtVUtJQ0FnSUhOM1lYQUtJQ0FnSUdKMGIya0tJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMM0psY0hWMFlYUnBiMjVmY21WbmFYTjBjbmt1Y0hrNk1UUTRDaUFnSUNBdkx5QnpJRDBnYzJWc1ppNWZkRzkxWTJnb2MybGtLUW9nSUNBZ1kyRnNiSE4xWWlCZmRHOTFZMmdLSUNBZ0lITjNZWEFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl5WlhCMWRHRjBhVzl1WDNKbFoybHpkSEo1TG5CNU9qRTBPUW9nSUNBZ0x5OGdhV1lnY0dGemMyVmtMbTVoZEdsMlpUb0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JuWlhSaWFYUUtJQ0FnSUdKNklISmxZMjl5WkY5MllXeHBaR0YwYVc5dVgyVnNjMlZmWW05a2VVQXpDaUFnSUNBdkx5QmpiMjUwY21GamRITXZjbVZ3ZFhSaGRHbHZibDl5WldkcGMzUnllUzV3ZVRveE5UQUtJQ0FnSUM4dklITXVkbUZzYVdSaGRHVmtJRDBnWVhKak5DNVZTVzUwTmpRb2N5NTJZV3hwWkdGMFpXUXVibUYwYVhabElDc2dNU2tLSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBeU5Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0FyQ2lBZ0lDQnBkRzlpQ2lBZ0lDQnlaWEJzWVdObE1pQXlOQW9LY21WamIzSmtYM1poYkdsa1lYUnBiMjVmWVdaMFpYSmZhV1pmWld4elpVQTBPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMM0psY0hWMFlYUnBiMjVmY21WbmFYTjBjbmt1Y0hrNk1UVXpDaUFnSUNBdkx5QnpMbXhoYzNSZllYUWdQU0JoY21NMExsVkpiblEyTkNoSGJHOWlZV3d1YkdGMFpYTjBYM1JwYldWemRHRnRjQ2tLSUNBZ0lHZHNiMkpoYkNCTVlYUmxjM1JVYVcxbGMzUmhiWEFLSUNBZ0lHbDBiMklLSUNBZ0lISmxjR3hoWTJVeUlEUTRDaUFnSUNBdkx5QmpiMjUwY21GamRITXZjbVZ3ZFhSaGRHbHZibDl5WldkcGMzUnllUzV3ZVRveE5UUUtJQ0FnSUM4dklITmxiR1l1YzJOdmNtVnpXM05wWkYwZ1BTQnpMbU52Y0hrb0tRb2dJQ0FnWkdsbklERUtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZzNNell6TldZS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMM0psY0hWMFlYUnBiMjVmY21WbmFYTjBjbmt1Y0hrNk1UUTBDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJR0o1ZEdWaklEUWdMeThnTUhneE5URm1OMk0zTlRnd0NpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NuSmxZMjl5WkY5MllXeHBaR0YwYVc5dVgyVnNjMlZmWW05a2VVQXpPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMM0psY0hWMFlYUnBiMjVmY21WbmFYTjBjbmt1Y0hrNk1UVXlDaUFnSUNBdkx5QnpMbVJwYzNCMWRHVmtJRDBnWVhKak5DNVZTVzUwTmpRb2N5NWthWE53ZFhSbFpDNXVZWFJwZG1VZ0t5QXhLUW9nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURNeUNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHbDBiMklLSUNBZ0lISmxjR3hoWTJVeUlETXlDaUFnSUNCaUlISmxZMjl5WkY5MllXeHBaR0YwYVc5dVgyRm1kR1Z5WDJsbVgyVnNjMlZBTkFvS0NpOHZJSEpsY0hWMFlYUnBiMjVmY21WbmFYTjBjbmt1VW1Wd2RYUmhkR2x2YmxKbFoybHpkSEo1TG1kbGRGOXpZMjl5WlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtZGxkRjl6WTI5eVpUb0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXlaWEIxZEdGMGFXOXVYM0psWjJsemRISjVMbkI1T2pFMU53b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQnVJRElLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmNtVndkWFJoZEdsdmJsOXlaV2RwYzNSeWVTNXdlVG94TlRrS0lDQWdJQzh2SUdGcFpDQTlJR0ZuWlc1MFgybGtMbTVoZEdsMlpRb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwzSmxjSFYwWVhScGIyNWZjbVZuYVhOMGNua3VjSGs2TVRZd0NpQWdJQ0F2THlCcFppQmhhV1FnYVc0Z2MyVnNaaTV6WTI5eVpYTTZDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjROek0yTXpWbUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmllaUJuWlhSZmMyTnZjbVZmWVdaMFpYSmZhV1pmWld4elpVQXpDaUFnSUNCaWRYSjVJREVLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl5WlhCMWRHRjBhVzl1WDNKbFoybHpkSEo1TG5CNU9qRTJNUW9nSUNBZ0x5OGdjbVYwZFhKdUlITmxiR1l1YzJOdmNtVnpXMkZwWkYwS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuTmpiM0psY3lCbGJuUnllU0JsZUdsemRITUtDbWRsZEY5elkyOXlaVjloWm5SbGNsOXBibXhwYm1Wa1gzSmxjSFYwWVhScGIyNWZjbVZuYVhOMGNua3VVbVZ3ZFhSaGRHbHZibEpsWjJsemRISjVMbWRsZEY5elkyOXlaVUEwT2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDNKbGNIVjBZWFJwYjI1ZmNtVm5hWE4wY25rdWNIazZNVFUzQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtZGxkRjl6WTI5eVpWOWhablJsY2w5cFpsOWxiSE5sUURNNkNpQWdJQ0J3YjNBS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5eVpYQjFkR0YwYVc5dVgzSmxaMmx6ZEhKNUxuQjVPakUyTWdvZ0lDQWdMeThnYm05M0lEMGdSMnh2WW1Gc0xteGhkR1Z6ZEY5MGFXMWxjM1JoYlhBS0lDQWdJR2RzYjJKaGJDQk1ZWFJsYzNSVWFXMWxjM1JoYlhBS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5eVpYQjFkR0YwYVc5dVgzSmxaMmx6ZEhKNUxuQjVPakUyTndvZ0lDQWdMeThnYW05aWMxOXdZV2xrUFdGeVl6UXVWVWx1ZERZMEtEQXBMQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXlaWEIxZEdGMGFXOXVYM0psWjJsemRISjVMbkI1T2pFM01Rb2dJQ0FnTHk4Z1ptbHljM1JmWVhROVlYSmpOQzVWU1c1ME5qUW9ibTkzS1N3S0lDQWdJSE4zWVhBS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5eVpYQjFkR0YwYVc5dVgzSmxaMmx6ZEhKNUxuQjVPakUyTXkweE56TUtJQ0FnSUM4dklDTWdRVzRnZFc1cmJtOTNiaUJoWjJWdWRDQnlaV0ZrY3lCaGN5QmhiR3d0ZW1WeWJ5QnlZWFJvWlhJZ2RHaGhiaUJsY25KdmNtbHVaem9nSW01dklISmxZMjl5WkNJZ2FYTUtJQ0FnSUM4dklDTWdZU0J5WldGc0lHRnVjM2RsY2lCaGJtUWdkR2hsSUdOaGJHeGxjaUJ6YUc5MWJHUWdjbVZ1WkdWeUlHbDBJR0Z6SUhOMVkyZ3VDaUFnSUNBdkx5QnlaWFIxY200Z1UyTnZjbVVvQ2lBZ0lDQXZMeUFnSUNBZ1lXZGxiblJmYVdROVlYSmpOQzVWU1c1ME5qUW9ZV2xrS1N3S0lDQWdJQzh2SUNBZ0lDQnFiMkp6WDNCaGFXUTlZWEpqTkM1VlNXNTBOalFvTUNrc0NpQWdJQ0F2THlBZ0lDQWdkbTlzZFcxbFgyMXBZM0p2UFdGeVl6UXVWVWx1ZERZMEtEQXBMQW9nSUNBZ0x5OGdJQ0FnSUhaaGJHbGtZWFJsWkQxaGNtTTBMbFZKYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ0FnSUNCa2FYTndkWFJsWkQxaGNtTTBMbFZKYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ0FnSUNCbWFYSnpkRjloZEQxaGNtTTBMbFZKYm5RMk5DaHViM2NwTEFvZ0lDQWdMeThnSUNBZ0lHeGhjM1JmWVhROVlYSmpOQzVWU1c1ME5qUW9ibTkzS1N3S0lDQWdJQzh2SUNrS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1pHbG5JRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDNKbGNIVjBZWFJwYjI1ZmNtVm5hWE4wY25rdWNIazZNVFUzQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJR0lnWjJWMFgzTmpiM0psWDJGbWRHVnlYMmx1YkdsdVpXUmZjbVZ3ZFhSaGRHbHZibDl5WldkcGMzUnllUzVTWlhCMWRHRjBhVzl1VW1WbmFYTjBjbmt1WjJWMFgzTmpiM0psUURRS0Nnb3ZMeUJ5WlhCMWRHRjBhVzl1WDNKbFoybHpkSEo1TGxKbGNIVjBZWFJwYjI1U1pXZHBjM1J5ZVM1M1lYTmZZMjkxYm5SbFpGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbmRoYzE5amIzVnVkR1ZrT2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDNKbGNIVjBZWFJwYjI1ZmNtVm5hWE4wY25rdWNIazZNVGMxQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUhCMWMyaHBiblFnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNBdkx5QmpiMjUwY21GamRITXZjbVZ3ZFhSaGRHbHZibDl5WldkcGMzUnllUzV3ZVRveE56Z0tJQ0FnSUM4dklIUWdQU0J3WVhsdFpXNTBYM1I0YVdRdWJtRjBhWFpsQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMM0psY0hWMFlYUnBiMjVmY21WbmFYTjBjbmt1Y0hrNk1UYzVDaUFnSUNBdkx5QnBaaUIwSUdsdUlITmxiR1l1YzJWbGJqb0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEY3dOalExWmdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lub2dkMkZ6WDJOdmRXNTBaV1JmWVdaMFpYSmZhV1pmWld4elpVQXpDaUFnSUNBdkx5QmpiMjUwY21GamRITXZjbVZ3ZFhSaGRHbHZibDl5WldkcGMzUnllUzV3ZVRveE9EQUtJQ0FnSUM4dklISmxkSFZ5YmlCaGNtTTBMbFZKYm5RMk5DaHpaV3htTG5ObFpXNWJkRjBwQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1elpXVnVJR1Z1ZEhKNUlHVjRhWE4wY3dvZ0lDQWdZblJ2YVFvZ0lDQWdhWFJ2WWdvS2QyRnpYMk52ZFc1MFpXUmZZV1owWlhKZmFXNXNhVzVsWkY5eVpYQjFkR0YwYVc5dVgzSmxaMmx6ZEhKNUxsSmxjSFYwWVhScGIyNVNaV2RwYzNSeWVTNTNZWE5mWTI5MWJuUmxaRUEwT2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDNKbGNIVjBZWFJwYjI1ZmNtVm5hWE4wY25rdWNIazZNVGMxQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NuZGhjMTlqYjNWdWRHVmtYMkZtZEdWeVgybG1YMlZzYzJWQU16b0tJQ0FnSUhCdmNBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwzSmxjSFYwWVhScGIyNWZjbVZuYVhOMGNua3VjSGs2TVRneENpQWdJQ0F2THlCeVpYUjFjbTRnWVhKak5DNVZTVzUwTmpRb01Da0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmNtVndkWFJoZEdsdmJsOXlaV2RwYzNSeWVTNXdlVG94TnpVS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnWWlCM1lYTmZZMjkxYm5SbFpGOWhablJsY2w5cGJteHBibVZrWDNKbGNIVjBZWFJwYjI1ZmNtVm5hWE4wY25rdVVtVndkWFJoZEdsdmJsSmxaMmx6ZEhKNUxuZGhjMTlqYjNWdWRHVmtRRFFLQ2dvdkx5QnlaWEIxZEdGMGFXOXVYM0psWjJsemRISjVMbEpsY0hWMFlYUnBiMjVTWldkcGMzUnllUzVmZEc5MVkyZ29ZV2RsYm5SZmFXUTZJSFZwYm5RMk5Da2dMVDRnWW5sMFpYTTZDbDkwYjNWamFEb0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXlaWEIxZEdGMGFXOXVYM0psWjJsemRISjVMbkI1T2pjM0xUYzRDaUFnSUNBdkx5QkFjM1ZpY205MWRHbHVaUW9nSUNBZ0x5OGdaR1ZtSUY5MGIzVmphQ2h6Wld4bUxDQmhaMlZ1ZEY5cFpEb2dWVWx1ZERZMEtTQXRQaUJUWTI5eVpUb0tJQ0FnSUhCeWIzUnZJREVnTVFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDNKbGNIVjBZWFJwYjI1ZmNtVm5hWE4wY25rdWNIazZOemtLSUNBZ0lDOHZJRzV2ZHlBOUlFZHNiMkpoYkM1c1lYUmxjM1JmZEdsdFpYTjBZVzF3Q2lBZ0lDQm5iRzlpWVd3Z1RHRjBaWE4wVkdsdFpYTjBZVzF3Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12Y21Wd2RYUmhkR2x2Ymw5eVpXZHBjM1J5ZVM1d2VUbzRNQW9nSUNBZ0x5OGdhV1lnWVdkbGJuUmZhV1FnYVc0Z2MyVnNaaTV6WTI5eVpYTTZDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdsMGIySUtJQ0FnSUdSMWNBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEY3pOak0xWmdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lub2dYM1J2ZFdOb1gyRm1kR1Z5WDJsbVgyVnNjMlZBTWdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDNKbGNIVjBZWFJwYjI1ZmNtVm5hWE4wY25rdWNIazZPREVLSUNBZ0lDOHZJSEpsZEhWeWJpQnpaV3htTG5OamIzSmxjMXRoWjJWdWRGOXBaRjB1WTI5d2VTZ3BDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV6WTI5eVpYTWdaVzUwY25rZ1pYaHBjM1J6Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREFLSUNBZ0lISmxkSE4xWWdvS1gzUnZkV05vWDJGbWRHVnlYMmxtWDJWc2MyVkFNam9LSUNBZ0lIQnZjQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMM0psY0hWMFlYUnBiMjVmY21WbmFYTjBjbmt1Y0hrNk9EUUtJQ0FnSUM4dklHcHZZbk5mY0dGcFpEMWhjbU0wTGxWSmJuUTJOQ2d3S1N3S0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12Y21Wd2RYUmhkR2x2Ymw5eVpXZHBjM1J5ZVM1d2VUbzRPQW9nSUNBZ0x5OGdabWx5YzNSZllYUTlZWEpqTkM1VlNXNTBOalFvYm05M0tTd0tJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDNKbGNIVjBZWFJwYjI1ZmNtVm5hWE4wY25rdWNIazZPREl0T1RBS0lDQWdJQzh2SUhKbGRIVnliaUJUWTI5eVpTZ0tJQ0FnSUM4dklDQWdJQ0JoWjJWdWRGOXBaRDFoY21NMExsVkpiblEyTkNoaFoyVnVkRjlwWkNrc0NpQWdJQ0F2THlBZ0lDQWdhbTlpYzE5d1lXbGtQV0Z5WXpRdVZVbHVkRFkwS0RBcExBb2dJQ0FnTHk4Z0lDQWdJSFp2YkhWdFpWOXRhV055YnoxaGNtTTBMbFZKYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ0FnSUNCMllXeHBaR0YwWldROVlYSmpOQzVWU1c1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFnSUNBZ1pHbHpjSFYwWldROVlYSmpOQzVWU1c1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFnSUNBZ1ptbHljM1JmWVhROVlYSmpOQzVWU1c1ME5qUW9ibTkzS1N3S0lDQWdJQzh2SUNBZ0lDQnNZWE4wWDJGMFBXRnlZelF1VlVsdWREWTBLRzV2ZHlrc0NpQWdJQ0F2THlBcENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEpsZEhOMVlnbz0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFEQVFBSUpnVURjMk5mREdsa1pXNTBhWFI1WDJGd2NBcDFjMlJqWDJGemMyVjBCQlVmZkhVRkZSOThkWUF4R0VBQUJpa2paeW9qWnpFYlFRQXlNUmtVUkRFWVJJSUZCRjhHNHQ0RUZCZ2pPd1E3VUYybUJDUitrS0FFVFE5aXBUWWFBSTRGQUFrQU5RQ1dBTnNCRndBeEdSUXhHQlFRUXpZYUFVa1ZKQkpFTmhvQ1NSVWtFa1F4QURJSkVrUWpLV1ZFRkVRWFNVUk1GeWxNWnlwTVp5Y0VzQ0pETVJZaUNVazRFSUVFRWtRMkdnRkpGU1FTUkRZYUFra1ZKQkpFU3dJNEVrbEVUd000RVNNcVpVUVNSRThDRjA4Q0Ywc0JFMFJKaUFEWVNTUmJJZ2dXWEFoSmdSQmJUd01JRmx3UU1nY1dYREJNRmloTVVFc0J2MWNJQ0N0TVVMQWlRellhQVVrVkpCSkVOaG9DU1JVaUVrUk1GMGxPQW9nQW1Fd2pVMEVBRzBtQkdGc2lDQlpjR0RJSEZsd3dTd0VXS0V4UVRMOG5CTEFpUTBtQklGc2lDQlpjSUVMLzRqWWFBVWNDRlNRU1JCY1dLRXhRU2IxRkFVRUFDa1VCdmtRclRGQ3dJa05JTWdjakZrd1dUd0pMQWxCTEFsQkxBbEJQQWxCTEFWQk1VRUwvM1RZYUFVa2pXWUVDQ0VzQkZSSkVWd0lBZ0FOd1pGOU1VRW05UlFGQkFBcStSQmNXSzB4UXNDSkRTQ01XUXYvMGlnRUJNZ2VML3haSktFeFFTYjFGQVVFQUJiNUVqQUNKU0NNV1R3SVdUd0pMQWxCTEFsQkxBbEJQQWxCTEFWQk1VSWs9IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OSwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
