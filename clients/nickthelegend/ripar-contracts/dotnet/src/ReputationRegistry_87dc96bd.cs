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

namespace Arc56.Generated.nickthelegend.ripar_contracts.ReputationRegistry_87dc96bd
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
        ///Name the contract allowed to write verdicts. Once, by the creator.
        ///Separate from bootstrap purely because of deployment order: the ValidationRegistry does not exist yet when this one is bootstrapped, so it cannot be named there.
        ///</summary>
        /// <param name="validation_app"> </param>
        public async Task<bool> SetValidationApp(ulong validation_app, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 79, 102, 105, 249 };
            var validation_appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); validation_appAbi.From(validation_app);

            var result = await base.CallApp(new List<object> { abiHandle, validation_appAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> SetValidationApp_Transactions(ulong validation_app, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 79, 102, 105, 249 };
            var validation_appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); validation_appAbi.From(validation_app);

            return await base.MakeTransactionList(new List<object> { abiHandle, validation_appAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        ///Has this agent been paid inside the last `window_secs`?
        ///Deliberately a boolean, not a windowed count. A real rolling window needs per-payment timestamps, and storing one box per payment is the `pd_` ledger this contract removed for being circular and unnecessary. Returning a count that silently meant "lifetime" would be worse than returning the one fact the stored data actually supports.
        ///Reputation here does not decay, and that is a choice worth stating: a payment happened or it did not, and an agent that earned trust and then went quiet has not become untrustworthy. What a reader usually wants to know is whether it is still ACTIVE, which is this.
        ///</summary>
        /// <param name="agent_id"> </param>
        /// <param name="window_secs"> </param>
        public async Task<bool> Recent(ulong agent_id, ulong window_secs, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 179, 138, 62, 29 };
            var agent_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); agent_idAbi.From(agent_id);
            var window_secsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); window_secsAbi.From(window_secs);

            var result = await base.SimApp(new List<object> { abiHandle, agent_idAbi, window_secsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Recent_Transactions(ulong agent_id, ulong window_secs, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 179, 138, 62, 29 };
            var agent_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); agent_idAbi.From(agent_id);
            var window_secsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); window_secsAbi.From(window_secs);

            return await base.MakeTransactionList(new List<object> { abiHandle, agent_idAbi, window_secsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Record a verdict against an agent's score. ValidationRegistry only.
        ///The docstring used to say "called by the Validation Registry" and that was simply untrue on two counts: nothing called it, so `validated` and `disputed` sat at zero while jobs were being judged, and ANY address could have called it, so the two fields were writable by anyone who wanted a clean record.
        ///Both are closed here. validation_response now makes this call, and the caller is checked against the app id set at deployment — an address calling directly has a caller_application_id of 0 and is refused.
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUmVwdXRhdGlvblJlZ2lzdHJ5IiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IlNjb3JlIjpbeyJuYW1lIjoiYWdlbnRfaWQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiam9ic19wYWlkIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InZvbHVtZV9taWNybyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ2YWxpZGF0ZWQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZGlzcHV0ZWQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmlyc3RfYXQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoibGFzdF9hdCIsInR5cGUiOiJ1aW50NjQifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiYm9vdHN0cmFwIiwiZGVzYyI6IlBvaW50IGF0IHRoZSBJZGVudGl0eSBSZWdpc3RyeSBhbmQgZml4IHRoZSBzZXR0bGVtZW50IGFzc2V0LlxuVGhlIGFzc2V0IGlzIHNldCBvbmNlIGFuZCBuZXZlciBjaGFuZ2VkLCBzbyBhIHNjb3JlIGFsd2F5cyBtZWFucyB0aGUgc2FtZSB0aGluZy4gV2l0aG91dCBpdCBhY2NlcHRfZmVlZGJhY2sgd291bGQgaGF2ZSB0byB0cnVzdCB3aGF0ZXZlciBhc3NldCBhIGNhbGxlciB0cmFuc2ZlcnJlZCwgYW5kIHJlcHV0YXRpb24gY291bGQgYmUgYm91Z2h0IHdpdGggYSB3b3J0aGxlc3Mgb25lIG1pbnRlZCBmb3IgdGhlIHB1cnBvc2UuIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImlkZW50aXR5X2FwcCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidXNkY19hc3NldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRfdmFsaWRhdGlvbl9hcHAiLCJkZXNjIjoiTmFtZSB0aGUgY29udHJhY3QgYWxsb3dlZCB0byB3cml0ZSB2ZXJkaWN0cy4gT25jZSwgYnkgdGhlIGNyZWF0b3IuXG5TZXBhcmF0ZSBmcm9tIGJvb3RzdHJhcCBwdXJlbHkgYmVjYXVzZSBvZiBkZXBsb3ltZW50IG9yZGVyOiB0aGUgVmFsaWRhdGlvblJlZ2lzdHJ5IGRvZXMgbm90IGV4aXN0IHlldCB3aGVuIHRoaXMgb25lIGlzIGJvb3RzdHJhcHBlZCwgc28gaXQgY2Fubm90IGJlIG5hbWVkIHRoZXJlLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWxpZGF0aW9uX2FwcCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhY2NlcHRfZmVlZGJhY2siLCJkZXNjIjoiQ3JlZGl0IGEgc2VydmVyIGFnZW50IGZvciBvbmUgc2V0dGxlZCBwYXltZW50LiBSZXR1cm5zIGl0cyBuZXcgY291bnQuXG5UaGUgcGF5bWVudCBpcyBwYXNzZWQgYXMgYSBUUkFOU0FDVElPTiBJTiBUSElTIEdST1VQLCBub3QgYXMgYW4gaWQgYW5kIGFuIGFtb3VudCB0aGUgY2FsbGVyIHN1cHBsaWVzLiBUaGF0IGRpc3RpbmN0aW9uIGlzIHRoZSB3aG9sZSBwb2ludC5cblRoZSBwcmV2aW91cyBzaWduYXR1cmUgdG9vayBhIDMyLWJ5dGUgaWQgYW5kIGEgbnVtYmVyLCBhbmQgY2hlY2tlZCBvbmx5IHRoYXQgdGhlIGlkIHdhcyAzMiBieXRlcyBsb25nIGFuZCB1bnNlZW4uIE5vdGhpbmcgdGllZCBlaXRoZXIgdmFsdWUgdG8gYSB0cmFuc2ZlciB0aGF0IGhhZCBhY3R1YWxseSBoYXBwZW5lZCwgc28gYW55IDMyIGJ5dGVzIGJvdWdodCBhIHBvaW50IG9mIHJlcHV0YXRpb24g4oCUIGFuIGF1ZGl0IGZvdW5kIHR3byBjb3VudGVkIHBheW1lbnRzIG9uIFRlc3ROZXQgdGhhdCByZXNvbHZlIHRvIG5vIHRyYW5zYWN0aW9uIGF0IGFsbCwgb25lIG9mIHRoZW0gMzIgemVybyBieXRlcy4gVGhlIGRvY3N0cmluZyBjbGFpbWluZyBhIHNjb3JlIFwiY2Fubm90IGJlIGluZmxhdGVkIGJ5IGFueXRoaW5nIHRoYXQgZGlkIG5vdCBtb3ZlIFVTRENcIiB3YXMgc2ltcGx5IHVudHJ1ZS5cbk5vdyB0aGUgYW1vdW50IGFuZCB0aGUgaWQgYXJlIFJFQUQgT0ZGIHRoZSB0cmFuc2ZlciB0aGUgQVZNIGhhcyBhbHJlYWR5IHZhbGlkYXRlZCwgc28gdGhleSBjYW5ub3QgYmUgZmFicmljYXRlZDogdG8gZWFybiBhIHBvaW50IHlvdSBtdXN0IG1vdmUgdGhlIGFzc2V0LCBpbiB0aGUgc2FtZSBhdG9taWMgZ3JvdXAsIGluIHRoZSBzYW1lIHJvdW5kLiIsImFyZ3MiOlt7InR5cGUiOiJheGZlciIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheW1lbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNlcnZlcl9hZ2VudF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2xpZW50X2FnZW50X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVjZW50IiwiZGVzYyI6IkhhcyB0aGlzIGFnZW50IGJlZW4gcGFpZCBpbnNpZGUgdGhlIGxhc3QgYHdpbmRvd19zZWNzYD9cbkRlbGliZXJhdGVseSBhIGJvb2xlYW4sIG5vdCBhIHdpbmRvd2VkIGNvdW50LiBBIHJlYWwgcm9sbGluZyB3aW5kb3cgbmVlZHMgcGVyLXBheW1lbnQgdGltZXN0YW1wcywgYW5kIHN0b3Jpbmcgb25lIGJveCBwZXIgcGF5bWVudCBpcyB0aGUgYHBkX2AgbGVkZ2VyIHRoaXMgY29udHJhY3QgcmVtb3ZlZCBmb3IgYmVpbmcgY2lyY3VsYXIgYW5kIHVubmVjZXNzYXJ5LiBSZXR1cm5pbmcgYSBjb3VudCB0aGF0IHNpbGVudGx5IG1lYW50IFwibGlmZXRpbWVcIiB3b3VsZCBiZSB3b3JzZSB0aGFuIHJldHVybmluZyB0aGUgb25lIGZhY3QgdGhlIHN0b3JlZCBkYXRhIGFjdHVhbGx5IHN1cHBvcnRzLlxuUmVwdXRhdGlvbiBoZXJlIGRvZXMgbm90IGRlY2F5LCBhbmQgdGhhdCBpcyBhIGNob2ljZSB3b3J0aCBzdGF0aW5nOiBhIHBheW1lbnQgaGFwcGVuZWQgb3IgaXQgZGlkIG5vdCwgYW5kIGFuIGFnZW50IHRoYXQgZWFybmVkIHRydXN0IGFuZCB0aGVuIHdlbnQgcXVpZXQgaGFzIG5vdCBiZWNvbWUgdW50cnVzdHdvcnRoeS4gV2hhdCBhIHJlYWRlciB1c3VhbGx5IHdhbnRzIHRvIGtub3cgaXMgd2hldGhlciBpdCBpcyBzdGlsbCBBQ1RJVkUsIHdoaWNoIGlzIHRoaXMuIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFnZW50X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ3aW5kb3dfc2VjcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlY29yZF92YWxpZGF0aW9uIiwiZGVzYyI6IlJlY29yZCBhIHZlcmRpY3QgYWdhaW5zdCBhbiBhZ2VudCdzIHNjb3JlLiBWYWxpZGF0aW9uUmVnaXN0cnkgb25seS5cblRoZSBkb2NzdHJpbmcgdXNlZCB0byBzYXkgXCJjYWxsZWQgYnkgdGhlIFZhbGlkYXRpb24gUmVnaXN0cnlcIiBhbmQgdGhhdCB3YXMgc2ltcGx5IHVudHJ1ZSBvbiB0d28gY291bnRzOiBub3RoaW5nIGNhbGxlZCBpdCwgc28gYHZhbGlkYXRlZGAgYW5kIGBkaXNwdXRlZGAgc2F0IGF0IHplcm8gd2hpbGUgam9icyB3ZXJlIGJlaW5nIGp1ZGdlZCwgYW5kIEFOWSBhZGRyZXNzIGNvdWxkIGhhdmUgY2FsbGVkIGl0LCBzbyB0aGUgdHdvIGZpZWxkcyB3ZXJlIHdyaXRhYmxlIGJ5IGFueW9uZSB3aG8gd2FudGVkIGEgY2xlYW4gcmVjb3JkLlxuQm90aCBhcmUgY2xvc2VkIGhlcmUuIHZhbGlkYXRpb25fcmVzcG9uc2Ugbm93IG1ha2VzIHRoaXMgY2FsbCwgYW5kIHRoZSBjYWxsZXIgaXMgY2hlY2tlZCBhZ2FpbnN0IHRoZSBhcHAgaWQgc2V0IGF0IGRlcGxveW1lbnQg4oCUIGFuIGFkZHJlc3MgY2FsbGluZyBkaXJlY3RseSBoYXMgYSBjYWxsZXJfYXBwbGljYXRpb25faWQgb2YgMCBhbmQgaXMgcmVmdXNlZC4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic2VydmVyX2FnZW50X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGFzc2VkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9zY29yZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZ2VudF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IlNjb3JlIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MywiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOlsiRGVsZXRlQXBwbGljYXRpb24iXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsyODBdLCJlcnJvck1lc3NhZ2UiOiJhIHplcm8tdmFsdWUgcGF5bWVudCBlYXJucyBub3RoaW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTk5XSwiZXJyb3JNZXNzYWdlIjoiYWxyZWFkeSBib290c3RyYXBwZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMzZdLCJlcnJvck1lc3NhZ2UiOiJhbHJlYWR5IHNldCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMwMV0sImVycm9yTWVzc2FnZSI6ImFuIGFnZW50IGNhbm5vdCBwYXkgaXRzZWxmIGludG8gYSByZXB1dGF0aW9uIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzM0LDM3Nl0sImVycm9yTWVzc2FnZSI6ImFwcGxpY2F0aW9uIGxvZyB2YWx1ZSBpcyBub3QgdGhlIHJlc3VsdCBvZiBhbiBBQkkgcmV0dXJuIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTk3LDMwNl0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuaWRlbnRpdHlfYXBwIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ3Nyw2MDIsNjU4XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5zY29yZXMgZW50cnkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjg5XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi51c2RjX2Fzc2V0IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIzNCw1MTldLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnZhbGlkYXRpb25fYXBwIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE5M10sImVycm9yTWVzc2FnZSI6ImNyZWF0b3Igb25seSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUxNV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmJvb2wiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNDIsMzg0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE3OSwxODcsMjI0LDI2NiwyNzQsNDQyLDQ1Miw1MDcsNTg2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTIxXSwiZXJyb3JNZXNzYWdlIjoibm8gdmFsaWRhdGlvbiBhcHAgaXMgc2V0LCBzbyBubyB2ZXJkaWN0IGNhbiBiZSB0cnVzdGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTI1XSwiZXJyb3JNZXNzYWdlIjoib25seSB0aGUgVmFsaWRhdGlvblJlZ2lzdHJ5IG1heSByZWNvcmQgYSB2ZXJkaWN0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTY1XSwiZXJyb3JNZXNzYWdlIjoib25seSB0aGUgY3JlYXRvciBtYXkgZGVsZXRlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjMwXSwiZXJyb3JNZXNzYWdlIjoib25seSB0aGUgY3JlYXRvciBtYXkgc2V0IHRoaXMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyOTFdLCJlcnJvck1lc3NhZ2UiOiJyZXB1dGF0aW9uIGlzIGRlbm9taW5hdGVkIGluIG9uZSBhc3NldDsgdGhpcyB0cmFuc2ZlciBpcyBub3QgaXQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszOTBdLCJlcnJvck1lc3NhZ2UiOiJ0aGUgcGF5bWVudCBkaWQgbm90IGNvbWUgZnJvbSB0aGUgYWdlbnQgYmVpbmcgY3JlZGl0ZWQgYXMgdGhlIGNsaWVudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM0OF0sImVycm9yTWVzc2FnZSI6InRoZSBwYXltZW50IGRpZCBub3QgZ28gdG8gdGhlIGFnZW50IGJlaW5nIGNyZWRpdGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjAyXSwiZXJyb3JNZXNzYWdlIjoidGhlIHNldHRsZW1lbnQgYXNzZXQgbXVzdCBiZSBzZXQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNThdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIGF4ZmVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjM5XSwiZXJyb3JNZXNzYWdlIjoidmFsaWRhdGlvbiBhcHAgaWQgcmVxdWlyZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF3SURFZ09DQXpNZ29nSUNBZ1lubDBaV05pYkc5amF5QXdlREUxTVdZM1l6YzFJREI0TnpNMk16Vm1JQ0pwWkdWdWRHbDBlVjloY0hBaUlDSjJZV3hwWkdGMGFXOXVYMkZ3Y0NJZ0luVnpaR05mWVhOelpYUWlJREI0TVRVeFpqZGpOelU0TUNBd2VHTTNZamszTURZekNpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1ltNTZJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF5Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12Y21Wd2RYUmhkR2x2Ymw5eVpXZHBjM1J5ZVM1d2VUbzFNQW9nSUNBZ0x5OGdjMlZzWmk1cFpHVnVkR2wwZVY5aGNIQWdQU0JWU1c1ME5qUW9NQ2tLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbWxrWlc1MGFYUjVYMkZ3Y0NJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDNKbGNIVjBZWFJwYjI1ZmNtVm5hWE4wY25rdWNIazZOVEV0TlRNS0lDQWdJQzh2SUNNZ1YyaHBZMmdnWVhOelpYUWdZMjkxYm5SekxpQlRaWFFnWVhRZ1ltOXZkSE4wY21Gd095QmhJSFJ5WVc1elptVnlJRzltSUdGdWVYUm9hVzVuSUdWc2MyVUtJQ0FnSUM4dklDTWdhWE1nY21WbWRYTmxaQ0J5WVhSb1pYSWdkR2hoYmlCemFXeGxiblJzZVNCamNtVmthWFJsWkM0S0lDQWdJQzh2SUhObGJHWXVkWE5rWTE5aGMzTmxkQ0E5SUZWSmJuUTJOQ2d3S1FvZ0lDQWdZbmwwWldNZ05DQXZMeUFpZFhOa1kxOWhjM05sZENJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDNKbGNIVjBZWFJwYjI1ZmNtVm5hWE4wY25rdWNIazZOVFV0TlRnS0lDQWdJQzh2SUNNZ1ZHaGxJRlpoYkdsa1lYUnBiMjVTWldkcGMzUnllU3dnWVc1a0lIUm9aU0JQVGt4WklHTmhiR3hsY2lCaGJHeHZkMlZrSUhSdklIZHlhWFJsSUdFS0lDQWdJQzh2SUNNZ2RtVnlaR2xqZEM0Z1UyVjBJSE5sY0dGeVlYUmxiSGtnWm5KdmJTQmliMjkwYzNSeVlYQWdZbVZqWVhWelpTQjJZV3hwWkdGMGFXOXVJR2x6SUdSbGNHeHZlV1ZrQ2lBZ0lDQXZMeUFqSUdGbWRHVnlJSFJvYVhNZ1kyOXVkSEpoWTNRZ1lXNWtJR05oYm01dmRDQnVZVzFsSUdsMGMyVnNaaUJpWldadmNtVWdhWFFnWlhocGMzUnpMZ29nSUNBZ0x5OGdjMlZzWmk1MllXeHBaR0YwYVc5dVgyRndjQ0E5SUZWSmJuUTJOQ2d3S1FvZ0lDQWdZbmwwWldOZk15QXZMeUFpZG1Gc2FXUmhkR2x2Ymw5aGNIQWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtDbTFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF5T2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDNKbGNIVjBZWFJwYjI1ZmNtVm5hWE4wY25rdWNIazZORGdLSUNBZ0lDOHZJR05zWVhOeklGSmxjSFYwWVhScGIyNVNaV2RwYzNSeWVTaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR0o2SUcxaGFXNWZZbUZ5WlY5eWIzVjBhVzVuUURFMUNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhnMVpqQTJaVEprWlNBd2VEUm1OalkyT1dZNUlEQjRNVFF4T0RJek0ySWdNSGhpTXpoaE0yVXhaQ0F3ZUROaU5UQTFaR0UySURCNE1qUTNaVGt3WVRBZ0x5OGdiV1YwYUc5a0lDSmliMjkwYzNSeVlYQW9kV2x1ZERZMExIVnBiblEyTkNsaWIyOXNJaXdnYldWMGFHOWtJQ0p6WlhSZmRtRnNhV1JoZEdsdmJsOWhjSEFvZFdsdWREWTBLV0p2YjJ3aUxDQnRaWFJvYjJRZ0ltRmpZMlZ3ZEY5bVpXVmtZbUZqYXloaGVHWmxjaXgxYVc1ME5qUXNkV2x1ZERZMEtYVnBiblEyTkNJc0lHMWxkR2h2WkNBaWNtVmpaVzUwS0hWcGJuUTJOQ3gxYVc1ME5qUXBZbTl2YkNJc0lHMWxkR2h2WkNBaWNtVmpiM0prWDNaaGJHbGtZWFJwYjI0b2RXbHVkRFkwTEdKdmIyd3BZbTl2YkNJc0lHMWxkR2h2WkNBaVoyVjBYM05qYjNKbEtIVnBiblEyTkNrb2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBLU0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUdKdmIzUnpkSEpoY0NCelpYUmZkbUZzYVdSaGRHbHZibDloY0hBZ1lXTmpaWEIwWDJabFpXUmlZV05ySUhKbFkyVnVkQ0J5WldOdmNtUmZkbUZzYVdSaGRHbHZiaUJuWlhSZmMyTnZjbVVLSUNBZ0lHVnljZ29LYldGcGJsOWlZWEpsWDNKdmRYUnBibWRBTVRVNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmNtVndkWFJoZEdsdmJsOXlaV2RwYzNSeWVTNXdlVG8wT0FvZ0lDQWdMeThnWTJ4aGMzTWdVbVZ3ZFhSaGRHbHZibEpsWjJsemRISjVLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0JwYm5Salh6QWdMeThnVG05UGNBb2dJQ0FnY0hWemFHbHVkQ0ExSUM4dklFUmxiR1YwWlVGd2NHeHBZMkYwYVc5dUNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCdFlYUmphQ0J0WVdsdVgxOWZZV3huYjNCNVgyUmxabUYxYkhSZlkzSmxZWFJsUURFMklHMWhhVzVmWkdWc1pYUmxRREUzQ2lBZ0lDQmxjbklLQ20xaGFXNWZaR1ZzWlhSbFFERTNPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMM0psY0hWMFlYUnBiMjVmY21WbmFYTjBjbmt1Y0hrNk1Ua3pDaUFnSUNBdkx5QkFZWEpqTkM1aVlYSmxiV1YwYUc5a0tHRnNiRzkzWDJGamRHbHZibk05V3lKRVpXeGxkR1ZCY0hCc2FXTmhkR2x2YmlKZEtRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDNKbGNIVjBZWFJwYjI1ZmNtVm5hWE4wY25rdWNIazZNakF4Q2lBZ0lDQXZMeUJoYzNObGNuUWdWSGh1TG5ObGJtUmxjaUE5UFNCSGJHOWlZV3d1WTNKbFlYUnZjbDloWkdSeVpYTnpMQ0FpYjI1c2VTQjBhR1VnWTNKbFlYUnZjaUJ0WVhrZ1pHVnNaWFJsSWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1oyeHZZbUZzSUVOeVpXRjBiM0pCWkdSeVpYTnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5dWJIa2dkR2hsSUdOeVpXRjBiM0lnYldGNUlHUmxiR1YwWlFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDNKbGNIVjBZWFJwYjI1ZmNtVm5hWE4wY25rdWNIazZNVGt6Q2lBZ0lDQXZMeUJBWVhKak5DNWlZWEpsYldWMGFHOWtLR0ZzYkc5M1gyRmpkR2x2Ym5NOVd5SkVaV3hsZEdWQmNIQnNhV05oZEdsdmJpSmRLUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWZYMkZzWjI5d2VWOWtaV1poZFd4MFgyTnlaV0YwWlVBeE5qb0tJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQWhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnlaWEIxZEdGMGFXOXVYM0psWjJsemRISjVMbEpsY0hWMFlYUnBiMjVTWldkcGMzUnllUzVpYjI5MGMzUnlZWEJiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwaWIyOTBjM1J5WVhBNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmNtVndkWFJoZEdsdmJsOXlaV2RwYzNSeWVTNXdlVG8yTmdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmNtVndkWFJoZEdsdmJsOXlaV2RwYzNSeWVTNXdlVG8zTlFvZ0lDQWdMeThnWVhOelpYSjBJRlI0Ymk1elpXNWtaWElnUFQwZ1IyeHZZbUZzTG1OeVpXRjBiM0pmWVdSa2NtVnpjeXdnSW1OeVpXRjBiM0lnYjI1c2VTSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2RzYjJKaGJDQkRjbVZoZEc5eVFXUmtjbVZ6Y3dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpjbVZoZEc5eUlHOXViSGtLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl5WlhCMWRHRjBhVzl1WDNKbFoybHpkSEo1TG5CNU9qYzJDaUFnSUNBdkx5QmhjM05sY25RZ2MyVnNaaTVwWkdWdWRHbDBlVjloY0hBZ1BUMGdNQ3dnSW1Gc2NtVmhaSGtnWW05dmRITjBjbUZ3Y0dWa0lnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6SWdMeThnSW1sa1pXNTBhWFI1WDJGd2NDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVwWkdWdWRHbDBlVjloY0hBZ1pYaHBjM1J6Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1lXeHlaV0ZrZVNCaWIyOTBjM1J5WVhCd1pXUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXlaWEIxZEdGMGFXOXVYM0psWjJsemRISjVMbkI1T2pjM0NpQWdJQ0F2THlCaGMzTmxjblFnZFhOa1kxOWhjM05sZEM1dVlYUnBkbVVnSVQwZ01Dd2dJblJvWlNCelpYUjBiR1Z0Wlc1MElHRnpjMlYwSUcxMWMzUWdZbVVnYzJWMElnb2dJQ0FnWW5SdmFRb2dJQ0FnWkhWd0NpQWdJQ0JoYzNObGNuUWdMeThnZEdobElITmxkSFJzWlcxbGJuUWdZWE56WlhRZ2JYVnpkQ0JpWlNCelpYUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXlaWEIxZEdGMGFXOXVYM0psWjJsemRISjVMbkI1T2pjNENpQWdJQ0F2THlCelpXeG1MbWxrWlc1MGFYUjVYMkZ3Y0NBOUlHbGtaVzUwYVhSNVgyRndjQzV1WVhScGRtVUtJQ0FnSUhOM1lYQUtJQ0FnSUdKMGIya0tJQ0FnSUdKNWRHVmpYeklnTHk4Z0ltbGtaVzUwYVhSNVgyRndjQ0lLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12Y21Wd2RYUmhkR2x2Ymw5eVpXZHBjM1J5ZVM1d2VUbzNPUW9nSUNBZ0x5OGdjMlZzWmk1MWMyUmpYMkZ6YzJWMElEMGdkWE5rWTE5aGMzTmxkQzV1WVhScGRtVUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z0luVnpaR05mWVhOelpYUWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMM0psY0hWMFlYUnBiMjVmY21WbmFYTjBjbmt1Y0hrNk5qWUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdZbmwwWldNZ05TQXZMeUF3ZURFMU1XWTNZemMxT0RBS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSEpsY0hWMFlYUnBiMjVmY21WbmFYTjBjbmt1VW1Wd2RYUmhkR2x2YmxKbFoybHpkSEo1TG5ObGRGOTJZV3hwWkdGMGFXOXVYMkZ3Y0Z0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuTmxkRjkyWVd4cFpHRjBhVzl1WDJGd2NEb0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXlaWEIxZEdGMGFXOXVYM0psWjJsemRISjVMbkI1T2pneUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5eVpYQjFkR0YwYVc5dVgzSmxaMmx6ZEhKNUxuQjVPamt3Q2lBZ0lDQXZMeUJoYzNObGNuUWdWSGh1TG5ObGJtUmxjaUE5UFNCSGJHOWlZV3d1WTNKbFlYUnZjbDloWkdSeVpYTnpMQ0FpYjI1c2VTQjBhR1VnWTNKbFlYUnZjaUJ0WVhrZ2MyVjBJSFJvYVhNaUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQm5iRzlpWVd3Z1EzSmxZWFJ2Y2tGa1pISmxjM01LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2IyNXNlU0IwYUdVZ1kzSmxZWFJ2Y2lCdFlYa2djMlYwSUhSb2FYTUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXlaWEIxZEdGMGFXOXVYM0psWjJsemRISjVMbkI1T2preENpQWdJQ0F2THlCaGMzTmxjblFnYzJWc1ppNTJZV3hwWkdGMGFXOXVYMkZ3Y0NBOVBTQXdMQ0FpWVd4eVpXRmtlU0J6WlhRaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk15QXZMeUFpZG1Gc2FXUmhkR2x2Ymw5aGNIQWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1ZG1Gc2FXUmhkR2x2Ymw5aGNIQWdaWGhwYzNSekNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdZV3h5WldGa2VTQnpaWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl5WlhCMWRHRjBhVzl1WDNKbFoybHpkSEo1TG5CNU9qa3lDaUFnSUNBdkx5QmhjM05sY25RZ2RtRnNhV1JoZEdsdmJsOWhjSEF1Ym1GMGFYWmxJRDRnTUN3Z0luWmhiR2xrWVhScGIyNGdZWEJ3SUdsa0lISmxjWFZwY21Wa0lnb2dJQ0FnWW5SdmFRb2dJQ0FnWkhWd0NpQWdJQ0JoYzNObGNuUWdMeThnZG1Gc2FXUmhkR2x2YmlCaGNIQWdhV1FnY21WeGRXbHlaV1FLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl5WlhCMWRHRjBhVzl1WDNKbFoybHpkSEo1TG5CNU9qa3pDaUFnSUNBdkx5QnpaV3htTG5aaGJHbGtZWFJwYjI1ZllYQndJRDBnZG1Gc2FXUmhkR2x2Ymw5aGNIQXVibUYwYVhabENpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKMllXeHBaR0YwYVc5dVgyRndjQ0lLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12Y21Wd2RYUmhkR2x2Ymw5eVpXZHBjM1J5ZVM1d2VUbzRNZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0JpZVhSbFl5QTFJQzh2SURCNE1UVXhaamRqTnpVNE1Bb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnY21Wd2RYUmhkR2x2Ymw5eVpXZHBjM1J5ZVM1U1pYQjFkR0YwYVc5dVVtVm5hWE4wY25rdVlXTmpaWEIwWDJabFpXUmlZV05yVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1lXTmpaWEIwWDJabFpXUmlZV05yT2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDNKbGNIVjBZWFJwYjI1ZmNtVm5hWE4wY25rdWNIazZNVEV4Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaSFZ3Q2lBZ0lDQm5kSGh1Y3lCVWVYQmxSVzUxYlFvZ0lDQWdjSFZ6YUdsdWRDQTBJQzh2SUdGNFptVnlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUhSeVlXNXpZV04wYVc5dUlIUjVjR1VnYVhNZ1lYaG1aWElLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXlaWEIxZEdGMGFXOXVYM0psWjJsemRISjVMbkI1T2pFek5Rb2dJQ0FnTHk4Z1lYTnpaWEowSUhCaGVXMWxiblF1WVhOelpYUmZZVzF2ZFc1MElENGdNQ3dnSW1FZ2VtVnlieTEyWVd4MVpTQndZWGx0Wlc1MElHVmhjbTV6SUc1dmRHaHBibWNpQ2lBZ0lDQmthV2NnTWdvZ0lDQWdaM1I0Ym5NZ1FYTnpaWFJCYlc5MWJuUUtJQ0FnSUdSMWNBb2dJQ0FnWVhOelpYSjBJQzh2SUdFZ2VtVnlieTEyWVd4MVpTQndZWGx0Wlc1MElHVmhjbTV6SUc1dmRHaHBibWNLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl5WlhCMWRHRjBhVzl1WDNKbFoybHpkSEo1TG5CNU9qRXpOd29nSUNBZ0x5OGdjR0Y1YldWdWRDNTRabVZ5WDJGemMyVjBMbWxrSUQwOUlITmxiR1l1ZFhOa1kxOWhjM05sZEFvZ0lDQWdaR2xuSURNS0lDQWdJR2QwZUc1eklGaG1aWEpCYzNObGRBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEUWdMeThnSW5WelpHTmZZWE56WlhRaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVkWE5rWTE5aGMzTmxkQ0JsZUdsemRITUtJQ0FnSUQwOUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmNtVndkWFJoZEdsdmJsOXlaV2RwYzNSeWVTNXdlVG94TXpZdE1UTTRDaUFnSUNBdkx5QmhjM05sY25RZ0tBb2dJQ0FnTHk4Z0lDQWdJSEJoZVcxbGJuUXVlR1psY2w5aGMzTmxkQzVwWkNBOVBTQnpaV3htTG5WelpHTmZZWE56WlhRS0lDQWdJQzh2SUNrc0lDSnlaWEIxZEdGMGFXOXVJR2x6SUdSbGJtOXRhVzVoZEdWa0lHbHVJRzl1WlNCaGMzTmxkRHNnZEdocGN5QjBjbUZ1YzJabGNpQnBjeUJ1YjNRZ2FYUWlDaUFnSUNCaGMzTmxjblFnTHk4Z2NtVndkWFJoZEdsdmJpQnBjeUJrWlc1dmJXbHVZWFJsWkNCcGJpQnZibVVnWVhOelpYUTdJSFJvYVhNZ2RISmhibk5tWlhJZ2FYTWdibTkwSUdsMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmNtVndkWFJoZEdsdmJsOXlaV2RwYzNSeWVTNXdlVG94TkRBS0lDQWdJQzh2SUhObGNuWmxjbDloWjJWdWRGOXBaQzV1WVhScGRtVWdJVDBnWTJ4cFpXNTBYMkZuWlc1MFgybGtMbTVoZEdsMlpRb2dJQ0FnWkdsbklESUtJQ0FnSUdKMGIya0tJQ0FnSUdScFp5QXlDaUFnSUNCaWRHOXBDaUFnSUNCa2FXY2dNUW9nSUNBZ0lUMEtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXlaWEIxZEdGMGFXOXVYM0psWjJsemRISjVMbkI1T2pFek9TMHhOREVLSUNBZ0lDOHZJR0Z6YzJWeWRDQW9DaUFnSUNBdkx5QWdJQ0FnYzJWeWRtVnlYMkZuWlc1MFgybGtMbTVoZEdsMlpTQWhQU0JqYkdsbGJuUmZZV2RsYm5SZmFXUXVibUYwYVhabENpQWdJQ0F2THlBcExDQWlZVzRnWVdkbGJuUWdZMkZ1Ym05MElIQmhlU0JwZEhObGJHWWdhVzUwYnlCaElISmxjSFYwWVhScGIyNGlDaUFnSUNCaGMzTmxjblFnTHk4Z1lXNGdZV2RsYm5RZ1kyRnVibTkwSUhCaGVTQnBkSE5sYkdZZ2FXNTBieUJoSUhKbGNIVjBZWFJwYjI0S0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5eVpYQjFkR0YwYVc5dVgzSmxaMmx6ZEhKNUxuQjVPakUwTXkweE5Ua0tJQ0FnSUM4dklDTWdWRWhGSUcxdmJtVjVJRzExYzNRZ2FHRjJaU0JuYjI1bElIUnZJRlJJUlNCaFoyVnVkQ0JpWldsdVp5QmpjbVZrYVhSbFpDNEtJQ0FnSUM4dklDTUtJQ0FnSUM4dklDTWdVbVZoWkdsdVp5QjBhR1VnWVcxdmRXNTBJRzltWmlCaElISmxZV3dnZEhKaGJuTm1aWElnYzNSdmNIQmxaQ0J6WTI5eVpYTWdZbVZwYm1jZ2JXbHVkR1ZrSUdaeWIyMEtJQ0FnSUM4dklDTWdhVzUyWlc1MFpXUWdZbmwwWlhNc0lHSjFkQ0J2YmlCcGRITWdiM2R1SUdsMElITjBhV3hzSUdOeVpXUnBkR1ZrSUhkb2FXTm9aWFpsY2lCcFpDQjBhR1VnWTJGc2JHVnlDaUFnSUNBdkx5QWpJRzVoYldWa0xpQkJibmx2Ym1VZ1kyOTFiR1FnYlc5MlpTQnZibVVnYldsamNtOVZVMFJESUdKbGRIZGxaVzRnZEhkdklHRmtaSEpsYzNObGN5QjBhR1Y1SUc5M2JtVmtDaUFnSUNBdkx5QWpJR0Z1WkNCamNtVmthWFFnWVNCemRISmhibWRsY2lkeklHRm5aVzUwSU9LQWxDQnZjaXdnZDJsMGFDQjBkMjhnYVdSekxDQjBhR1Z0YzJWc2RtVnpMaUJVYUdVS0lDQWdJQzh2SUNNZ2FXUXRhVzVsY1hWaGJHbDBlU0JqYUdWamF5QmhZbTkyWlNCa2IyVnpJRzV2ZENCb1pXeHdPaUJwWkhNZ1lYSmxJRzV2ZENCcFpHVnVkR2wwYVdWekxnb2dJQ0FnTHk4Z0l3b2dJQ0FnTHk4Z0l5QlRieUJ5WlhOdmJIWmxJR0p2ZEdnZ1pXNWtjeUJoWjJGcGJuTjBJSFJvWlNCSlpHVnVkR2wwZVZKbFoybHpkSEo1TENCM2FHbGphQ0JwY3lCMGFHVWdiMjVzZVFvZ0lDQWdMeThnSXlCd2JHRmpaU0JoYmlCaFpHUnlaWE56TFhSdkxXbGtJR0pwYm1ScGJtY2dhWE1nWVhWMGFHVnVkR2xqWVhSbFpDQW9ibVYzWDJGblpXNTBJSFJoYTJWeklIUm9aUW9nSUNBZ0x5OGdJeUJ2ZDI1bGNpQm1jbTl0SUZSNGJpNXpaVzVrWlhJcExpQkJJR055WldScGRDQnViM2NnY21WeGRXbHlaWE1nZEdobElIQmhlVzFsYm5RZ2RHOGdhR0YyWlNCaVpXVnVDaUFnSUNBdkx5QWpJSE5sYm5RZ1Fsa2dkR2hsSUdOc2FXVnVkQ2R6SUhKbFoybHpkR1Z5WldRZ1lXUmtjbVZ6Y3lCVVR5QjBhR1VnYzJWeWRtVnlKM011Q2lBZ0lDQXZMeUJ6WlhKMlpYSmZZV1JrY2l3Z1gzUjRiaUE5SUdGeVl6UXVZV0pwWDJOaGJHeGJZWEpqTkM1QlpHUnlaWE56WFNnS0lDQWdJQzh2SUNBZ0lDQWlZV2RsYm5SZllXUmtjbVZ6Y3loMWFXNTBOalFwWVdSa2NtVnpjeUlzQ2lBZ0lDQXZMeUFnSUNBZ2MyVnlkbVZ5WDJGblpXNTBYMmxrTEFvZ0lDQWdMeThnSUNBZ0lHRndjRjlwWkQxelpXeG1MbWxrWlc1MGFYUjVYMkZ3Y0N3S0lDQWdJQzh2SUNrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl5WlhCMWRHRjBhVzl1WDNKbFoybHpkSEo1TG5CNU9qRTFPQW9nSUNBZ0x5OGdZWEJ3WDJsa1BYTmxiR1l1YVdSbGJuUnBkSGxmWVhCd0xBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6SWdMeThnSW1sa1pXNTBhWFI1WDJGd2NDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVwWkdWdWRHbDBlVjloY0hBZ1pYaHBjM1J6Q2lBZ0lDQmtkWEFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDNKbGNIVjBZWFJwYjI1ZmNtVm5hWE4wY25rdWNIazZNVFF6TFRFMU9Rb2dJQ0FnTHk4Z0l5QlVTRVVnYlc5dVpYa2diWFZ6ZENCb1lYWmxJR2R2Ym1VZ2RHOGdWRWhGSUdGblpXNTBJR0psYVc1bklHTnlaV1JwZEdWa0xnb2dJQ0FnTHk4Z0l3b2dJQ0FnTHk4Z0l5QlNaV0ZrYVc1bklIUm9aU0JoYlc5MWJuUWdiMlptSUdFZ2NtVmhiQ0IwY21GdWMyWmxjaUJ6ZEc5d2NHVmtJSE5qYjNKbGN5QmlaV2x1WnlCdGFXNTBaV1FnWm5KdmJRb2dJQ0FnTHk4Z0l5QnBiblpsYm5SbFpDQmllWFJsY3l3Z1luVjBJRzl1SUdsMGN5QnZkMjRnYVhRZ2MzUnBiR3dnWTNKbFpHbDBaV1FnZDJocFkyaGxkbVZ5SUdsa0lIUm9aU0JqWVd4c1pYSUtJQ0FnSUM4dklDTWdibUZ0WldRdUlFRnVlVzl1WlNCamIzVnNaQ0J0YjNabElHOXVaU0J0YVdOeWIxVlRSRU1nWW1WMGQyVmxiaUIwZDI4Z1lXUmtjbVZ6YzJWeklIUm9aWGtnYjNkdVpXUUtJQ0FnSUM4dklDTWdZVzVrSUdOeVpXUnBkQ0JoSUhOMGNtRnVaMlZ5SjNNZ1lXZGxiblFnNG9DVUlHOXlMQ0IzYVhSb0lIUjNieUJwWkhNc0lIUm9aVzF6Wld4MlpYTXVJRlJvWlFvZ0lDQWdMeThnSXlCcFpDMXBibVZ4ZFdGc2FYUjVJR05vWldOcklHRmliM1psSUdSdlpYTWdibTkwSUdobGJIQTZJR2xrY3lCaGNtVWdibTkwSUdsa1pXNTBhWFJwWlhNdUNpQWdJQ0F2THlBakNpQWdJQ0F2THlBaklGTnZJSEpsYzI5c2RtVWdZbTkwYUNCbGJtUnpJR0ZuWVdsdWMzUWdkR2hsSUVsa1pXNTBhWFI1VW1WbmFYTjBjbmtzSUhkb2FXTm9JR2x6SUhSb1pTQnZibXg1Q2lBZ0lDQXZMeUFqSUhCc1lXTmxJR0Z1SUdGa1pISmxjM010ZEc4dGFXUWdZbWx1WkdsdVp5QnBjeUJoZFhSb1pXNTBhV05oZEdWa0lDaHVaWGRmWVdkbGJuUWdkR0ZyWlhNZ2RHaGxDaUFnSUNBdkx5QWpJRzkzYm1WeUlHWnliMjBnVkhodUxuTmxibVJsY2lrdUlFRWdZM0psWkdsMElHNXZkeUJ5WlhGMWFYSmxjeUIwYUdVZ2NHRjViV1Z1ZENCMGJ5Qm9ZWFpsSUdKbFpXNEtJQ0FnSUM4dklDTWdjMlZ1ZENCQ1dTQjBhR1VnWTJ4cFpXNTBKM01nY21WbmFYTjBaWEpsWkNCaFpHUnlaWE56SUZSUElIUm9aU0J6WlhKMlpYSW5jeTRLSUNBZ0lDOHZJSE5sY25abGNsOWhaR1J5TENCZmRIaHVJRDBnWVhKak5DNWhZbWxmWTJGc2JGdGhjbU0wTGtGa1pISmxjM05kS0FvZ0lDQWdMeThnSUNBZ0lDSmhaMlZ1ZEY5aFpHUnlaWE56S0hWcGJuUTJOQ2xoWkdSeVpYTnpJaXdLSUNBZ0lDOHZJQ0FnSUNCelpYSjJaWEpmWVdkbGJuUmZhV1FzQ2lBZ0lDQXZMeUFnSUNBZ1lYQndYMmxrUFhObGJHWXVhV1JsYm5ScGRIbGZZWEJ3TEFvZ0lDQWdMeThnS1FvZ0lDQWdZbmwwWldNZ05pQXZMeUJ0WlhSb2IyUWdJbUZuWlc1MFgyRmtaSEpsYzNNb2RXbHVkRFkwS1dGa1pISmxjM01pQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnY0hWemFHbHVkQ0EySUM4dklHRndjR3dLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJR2wwZUc0Z1RHRnpkRXh2WndvZ0lDQWdaSFZ3Q2lBZ0lDQmxlSFJ5WVdOMElEQWdOQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdGd2NHeHBZMkYwYVc5dUlHeHZaeUIyWVd4MVpTQnBjeUJ1YjNRZ2RHaGxJSEpsYzNWc2RDQnZaaUJoYmlCQlFra2djbVYwZFhKdUNpQWdJQ0JsZUhSeVlXTjBJRFFnTUFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12Y21Wd2RYUmhkR2x2Ymw5eVpXZHBjM1J5ZVM1d2VUb3hOakVLSUNBZ0lDOHZJSEJoZVcxbGJuUXVZWE56WlhSZmNtVmpaV2wyWlhJZ1BUMGdjMlZ5ZG1WeVgyRmtaSEl1Ym1GMGFYWmxDaUFnSUNCa2FXY2dOUW9nSUNBZ1ozUjRibk1nUVhOelpYUlNaV05sYVhabGNnb2dJQ0FnUFQwS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5eVpYQjFkR0YwYVc5dVgzSmxaMmx6ZEhKNUxuQjVPakUyTUMweE5qSUtJQ0FnSUM4dklHRnpjMlZ5ZENBb0NpQWdJQ0F2THlBZ0lDQWdjR0Y1YldWdWRDNWhjM05sZEY5eVpXTmxhWFpsY2lBOVBTQnpaWEoyWlhKZllXUmtjaTV1WVhScGRtVUtJQ0FnSUM4dklDa3NJQ0owYUdVZ2NHRjViV1Z1ZENCa2FXUWdibTkwSUdkdklIUnZJSFJvWlNCaFoyVnVkQ0JpWldsdVp5QmpjbVZrYVhSbFpDSUtJQ0FnSUdGemMyVnlkQ0F2THlCMGFHVWdjR0Y1YldWdWRDQmthV1FnYm05MElHZHZJSFJ2SUhSb1pTQmhaMlZ1ZENCaVpXbHVaeUJqY21Wa2FYUmxaQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMM0psY0hWMFlYUnBiMjVmY21WbmFYTjBjbmt1Y0hrNk1UWTBMVEUyT0FvZ0lDQWdMeThnWTJ4cFpXNTBYMkZrWkhJc0lGOTBlRzR5SUQwZ1lYSmpOQzVoWW1sZlkyRnNiRnRoY21NMExrRmtaSEpsYzNOZEtBb2dJQ0FnTHk4Z0lDQWdJQ0poWjJWdWRGOWhaR1J5WlhOektIVnBiblEyTkNsaFpHUnlaWE56SWl3S0lDQWdJQzh2SUNBZ0lDQmpiR2xsYm5SZllXZGxiblJmYVdRc0NpQWdJQ0F2THlBZ0lDQWdZWEJ3WDJsa1BYTmxiR1l1YVdSbGJuUnBkSGxmWVhCd0xBb2dJQ0FnTHk4Z0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpZVhSbFl5QTJJQzh2SUcxbGRHaHZaQ0FpWVdkbGJuUmZZV1JrY21WemN5aDFhVzUwTmpRcFlXUmtjbVZ6Y3lJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCd2RYTm9hVzUwSURZZ0x5OGdZWEJ3YkFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnYVhSNGJpQk1ZWE4wVEc5bkNpQWdJQ0JrZFhBS0lDQWdJR1Y0ZEhKaFkzUWdNQ0EwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1lYQndiR2xqWVhScGIyNGdiRzluSUhaaGJIVmxJR2x6SUc1dmRDQjBhR1VnY21WemRXeDBJRzltSUdGdUlFRkNTU0J5WlhSMWNtNEtJQ0FnSUdWNGRISmhZM1FnTkNBd0NpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5eVpYQjFkR0YwYVc5dVgzSmxaMmx6ZEhKNUxuQjVPakUzTUFvZ0lDQWdMeThnY0dGNWJXVnVkQzV6Wlc1a1pYSWdQVDBnWTJ4cFpXNTBYMkZrWkhJdWJtRjBhWFpsQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdkMGVHNXpJRk5sYm1SbGNnb2dJQ0FnUFQwS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5eVpYQjFkR0YwYVc5dVgzSmxaMmx6ZEhKNUxuQjVPakUyT1MweE56RUtJQ0FnSUM4dklHRnpjMlZ5ZENBb0NpQWdJQ0F2THlBZ0lDQWdjR0Y1YldWdWRDNXpaVzVrWlhJZ1BUMGdZMnhwWlc1MFgyRmtaSEl1Ym1GMGFYWmxDaUFnSUNBdkx5QXBMQ0FpZEdobElIQmhlVzFsYm5RZ1pHbGtJRzV2ZENCamIyMWxJR1p5YjIwZ2RHaGxJR0ZuWlc1MElHSmxhVzVuSUdOeVpXUnBkR1ZrSUdGeklIUm9aU0JqYkdsbGJuUWlDaUFnSUNCaGMzTmxjblFnTHk4Z2RHaGxJSEJoZVcxbGJuUWdaR2xrSUc1dmRDQmpiMjFsSUdaeWIyMGdkR2hsSUdGblpXNTBJR0psYVc1bklHTnlaV1JwZEdWa0lHRnpJSFJvWlNCamJHbGxiblFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl5WlhCMWRHRjBhVzl1WDNKbFoybHpkSEo1TG5CNU9qRTROUW9nSUNBZ0x5OGdjeUE5SUhObGJHWXVYM1J2ZFdOb0tITnBaQ2tLSUNBZ0lHUjFjQW9nSUNBZ1kyRnNiSE4xWWlCZmRHOTFZMmdLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl5WlhCMWRHRjBhVzl1WDNKbFoybHpkSEo1TG5CNU9qRTROZ29nSUNBZ0x5OGdjeTVxYjJKelgzQmhhV1FnUFNCaGNtTTBMbFZKYm5RMk5DaHpMbXB2WW5OZmNHRnBaQzV1WVhScGRtVWdLeUF4S1FvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBckNpQWdJQ0JwZEc5aUNpQWdJQ0J5WlhCc1lXTmxNaUE0Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12Y21Wd2RYUmhkR2x2Ymw5eVpXZHBjM1J5ZVM1d2VUb3hPRGNLSUNBZ0lDOHZJSE11ZG05c2RXMWxYMjFwWTNKdklEMGdZWEpqTkM1VlNXNTBOalFvY3k1MmIyeDFiV1ZmYldsamNtOHVibUYwYVhabElDc2djR0Y1YldWdWRDNWhjM05sZEY5aGJXOTFiblFwQ2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ01UWUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJQ3NLSUNBZ0lHbDBiMklLSUNBZ0lISmxjR3hoWTJVeUlERTJDaUFnSUNBdkx5QmpiMjUwY21GamRITXZjbVZ3ZFhSaGRHbHZibDl5WldkcGMzUnllUzV3ZVRveE9EZ0tJQ0FnSUM4dklITXViR0Z6ZEY5aGRDQTlJR0Z5WXpRdVZVbHVkRFkwS0Vkc2IySmhiQzVzWVhSbGMzUmZkR2x0WlhOMFlXMXdLUW9nSUNBZ1oyeHZZbUZzSUV4aGRHVnpkRlJwYldWemRHRnRjQW9nSUNBZ2FYUnZZZ29nSUNBZ2NtVndiR0ZqWlRJZ05EZ0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXlaWEIxZEdGMGFXOXVYM0psWjJsemRISjVMbkI1T2pFNE9Rb2dJQ0FnTHk4Z2MyVnNaaTV6WTI5eVpYTmJjMmxrWFNBOUlITXVZMjl3ZVNncENpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE56TTJNelZtQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBeENpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZjbVZ3ZFhSaGRHbHZibDl5WldkcGMzUnllUzV3ZVRveE9URUtJQ0FnSUM4dklISmxkSFZ5YmlCaGNtTTBMbFZKYm5RMk5DaHpMbXB2WW5OZmNHRnBaQzV1WVhScGRtVXBDaUFnSUNCbGVIUnlZV04wSURnZ09Bb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwzSmxjSFYwWVhScGIyNWZjbVZuYVhOMGNua3VjSGs2TVRFeENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnlaWEIxZEdGMGFXOXVYM0psWjJsemRISjVMbEpsY0hWMFlYUnBiMjVTWldkcGMzUnllUzV5WldObGJuUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B5WldObGJuUTZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZjbVZ3ZFhSaGRHbHZibDl5WldkcGMzUnllUzV3ZVRveU1ETUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMM0psY0hWMFlYUnBiMjVmY21WbmFYTjBjbmt1Y0hrNk1qRTRDaUFnSUNBdkx5QmhhV1FnUFNCaFoyVnVkRjlwWkM1dVlYUnBkbVVLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl5WlhCMWRHRjBhVzl1WDNKbFoybHpkSEo1TG5CNU9qSXhPUW9nSUNBZ0x5OGdhV1lnWVdsa0lHNXZkQ0JwYmlCelpXeG1Mbk5qYjNKbGN6b0tJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZzNNell6TldZS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHSnVlaUJ5WldObGJuUmZZV1owWlhKZmFXWmZaV3h6WlVBekNpQWdJQ0J3YjNCdUlESUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXlaWEIxZEdGMGFXOXVYM0psWjJsemRISjVMbkI1T2pJeU1Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUdGeVl6UXVRbTl2YkNoR1lXeHpaU2tnSUNNZ2JtOXhZVG9nUmtKVU1EQXpDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNQW9LY21WalpXNTBYMkZtZEdWeVgybHViR2x1WldSZmNtVndkWFJoZEdsdmJsOXlaV2RwYzNSeWVTNVNaWEIxZEdGMGFXOXVVbVZuYVhOMGNua3VjbVZqWlc1MFFEUTZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZjbVZ3ZFhSaGRHbHZibDl5WldkcGMzUnllUzV3ZVRveU1ETUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LY21WalpXNTBYMkZtZEdWeVgybG1YMlZzYzJWQU16b0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXlaWEIxZEdGMGFXOXVYM0psWjJsemRISjVMbkI1T2pJeU1Rb2dJQ0FnTHk4Z2JHRnpkQ0E5SUhObGJHWXVjMk52Y21WelcyRnBaRjB1YkdGemRGOWhkQzV1WVhScGRtVUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1Mbk5qYjNKbGN5QmxiblJ5ZVNCbGVHbHpkSE1LSUNBZ0lIQjFjMmhwYm5RZ05EZ0tJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZjbVZ3ZFhSaGRHbHZibDl5WldkcGMzUnllUzV3ZVRveU1qSUtJQ0FnSUM4dklISmxkSFZ5YmlCaGNtTTBMa0p2YjJ3b1IyeHZZbUZzTG14aGRHVnpkRjkwYVcxbGMzUmhiWEFnUEQwZ2JHRnpkQ0FySUhkcGJtUnZkMTl6WldOekxtNWhkR2wyWlNrS0lDQWdJR2RzYjJKaGJDQk1ZWFJsYzNSVWFXMWxjM1JoYlhBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1luUnZhUW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0FyQ2lBZ0lDQThQUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sZEdKcGRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwzSmxjSFYwWVhScGIyNWZjbVZuYVhOMGNua3VjSGs2TWpBekNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUdJZ2NtVmpaVzUwWDJGbWRHVnlYMmx1YkdsdVpXUmZjbVZ3ZFhSaGRHbHZibDl5WldkcGMzUnllUzVTWlhCMWRHRjBhVzl1VW1WbmFYTjBjbmt1Y21WalpXNTBRRFFLQ2dvdkx5QnlaWEIxZEdGMGFXOXVYM0psWjJsemRISjVMbEpsY0hWMFlYUnBiMjVTWldkcGMzUnllUzV5WldOdmNtUmZkbUZzYVdSaGRHbHZibHR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25KbFkyOXlaRjkyWVd4cFpHRjBhVzl1T2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDNKbGNIVjBZWFJwYjI1ZmNtVm5hWE4wY25rdWNIazZNakkwQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWliMjlzQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12Y21Wd2RYUmhkR2x2Ymw5eVpXZHBjM1J5ZVM1d2VUb3lNemdLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpaV3htTG5aaGJHbGtZWFJwYjI1ZllYQndJQ0U5SURBc0lDSnVieUIyWVd4cFpHRjBhVzl1SUdGd2NDQnBjeUJ6WlhRc0lITnZJRzV2SUhabGNtUnBZM1FnWTJGdUlHSmxJSFJ5ZFhOMFpXUWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNeUF2THlBaWRtRnNhV1JoZEdsdmJsOWhjSEFpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWRtRnNhV1JoZEdsdmJsOWhjSEFnWlhocGMzUnpDaUFnSUNCa2RYQUtJQ0FnSUdGemMyVnlkQ0F2THlCdWJ5QjJZV3hwWkdGMGFXOXVJR0Z3Y0NCcGN5QnpaWFFzSUhOdklHNXZJSFpsY21ScFkzUWdZMkZ1SUdKbElIUnlkWE4wWldRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5eVpYQjFkR0YwYVc5dVgzSmxaMmx6ZEhKNUxuQjVPakkwTUFvZ0lDQWdMeThnUjJ4dlltRnNMbU5oYkd4bGNsOWhjSEJzYVdOaGRHbHZibDlwWkNBOVBTQnpaV3htTG5aaGJHbGtZWFJwYjI1ZllYQndDaUFnSUNCbmJHOWlZV3dnUTJGc2JHVnlRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdQVDBLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl5WlhCMWRHRjBhVzl1WDNKbFoybHpkSEo1TG5CNU9qSXpPUzB5TkRFS0lDQWdJQzh2SUdGemMyVnlkQ0FvQ2lBZ0lDQXZMeUFnSUNBZ1IyeHZZbUZzTG1OaGJHeGxjbDloY0hCc2FXTmhkR2x2Ymw5cFpDQTlQU0J6Wld4bUxuWmhiR2xrWVhScGIyNWZZWEJ3Q2lBZ0lDQXZMeUFwTENBaWIyNXNlU0IwYUdVZ1ZtRnNhV1JoZEdsdmJsSmxaMmx6ZEhKNUlHMWhlU0J5WldOdmNtUWdZU0IyWlhKa2FXTjBJZ29nSUNBZ1lYTnpaWEowSUM4dklHOXViSGtnZEdobElGWmhiR2xrWVhScGIyNVNaV2RwYzNSeWVTQnRZWGtnY21WamIzSmtJR0VnZG1WeVpHbGpkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMM0psY0hWMFlYUnBiMjVmY21WbmFYTjBjbmt1Y0hrNk1qUXlDaUFnSUNBdkx5QnphV1FnUFNCelpYSjJaWEpmWVdkbGJuUmZhV1F1Ym1GMGFYWmxDaUFnSUNCemQyRndDaUFnSUNCaWRHOXBDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl5WlhCMWRHRjBhVzl1WDNKbFoybHpkSEo1TG5CNU9qSTBNd29nSUNBZ0x5OGdjeUE5SUhObGJHWXVYM1J2ZFdOb0tITnBaQ2tLSUNBZ0lHTmhiR3h6ZFdJZ1gzUnZkV05vQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12Y21Wd2RYUmhkR2x2Ymw5eVpXZHBjM1J5ZVM1d2VUb3lORFFLSUNBZ0lDOHZJR2xtSUhCaGMzTmxaQzV1WVhScGRtVTZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWjJWMFltbDBDaUFnSUNCaWVpQnlaV052Y21SZmRtRnNhV1JoZEdsdmJsOWxiSE5sWDJKdlpIbEFNd29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMM0psY0hWMFlYUnBiMjVmY21WbmFYTjBjbmt1Y0hrNk1qUTFDaUFnSUNBdkx5QnpMblpoYkdsa1lYUmxaQ0E5SUdGeVl6UXVWVWx1ZERZMEtITXVkbUZzYVdSaGRHVmtMbTVoZEdsMlpTQXJJREVwQ2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ01qUUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdhWFJ2WWdvZ0lDQWdjbVZ3YkdGalpUSWdNalFLQ25KbFkyOXlaRjkyWVd4cFpHRjBhVzl1WDJGbWRHVnlYMmxtWDJWc2MyVkFORG9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl5WlhCMWRHRjBhVzl1WDNKbFoybHpkSEo1TG5CNU9qSTBPQW9nSUNBZ0x5OGdjeTVzWVhOMFgyRjBJRDBnWVhKak5DNVZTVzUwTmpRb1IyeHZZbUZzTG14aGRHVnpkRjkwYVcxbGMzUmhiWEFwQ2lBZ0lDQm5iRzlpWVd3Z1RHRjBaWE4wVkdsdFpYTjBZVzF3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQnlaWEJzWVdObE1pQTBPQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMM0psY0hWMFlYUnBiMjVmY21WbmFYTjBjbmt1Y0hrNk1qUTVDaUFnSUNBdkx5QnpaV3htTG5OamIzSmxjMXR6YVdSZElEMGdjeTVqYjNCNUtDa0tJQ0FnSUdScFp5QXhDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjROek0yTXpWbUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl5WlhCMWRHRjBhVzl1WDNKbFoybHpkSEo1TG5CNU9qSXlOQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0JpZVhSbFl5QTFJQzh2SURCNE1UVXhaamRqTnpVNE1Bb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHlaV052Y21SZmRtRnNhV1JoZEdsdmJsOWxiSE5sWDJKdlpIbEFNem9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl5WlhCMWRHRjBhVzl1WDNKbFoybHpkSEo1TG5CNU9qSTBOd29nSUNBZ0x5OGdjeTVrYVhOd2RYUmxaQ0E5SUdGeVl6UXVWVWx1ZERZMEtITXVaR2x6Y0hWMFpXUXVibUYwYVhabElDc2dNU2tLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh6SUM4dklETXlDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUNzS0lDQWdJR2wwYjJJS0lDQWdJSEpsY0d4aFkyVXlJRE15Q2lBZ0lDQmlJSEpsWTI5eVpGOTJZV3hwWkdGMGFXOXVYMkZtZEdWeVgybG1YMlZzYzJWQU5Bb0tDaTh2SUhKbGNIVjBZWFJwYjI1ZmNtVm5hWE4wY25rdVVtVndkWFJoZEdsdmJsSmxaMmx6ZEhKNUxtZGxkRjl6WTI5eVpWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWRsZEY5elkyOXlaVG9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl5WlhCMWRHRjBhVzl1WDNKbFoybHpkSEo1TG5CNU9qSTFNZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEJ1SURJS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZjbVZ3ZFhSaGRHbHZibDl5WldkcGMzUnllUzV3ZVRveU5UUUtJQ0FnSUM4dklHRnBaQ0E5SUdGblpXNTBYMmxrTG01aGRHbDJaUW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMM0psY0hWMFlYUnBiMjVmY21WbmFYTjBjbmt1Y0hrNk1qVTFDaUFnSUNBdkx5QnBaaUJoYVdRZ2FXNGdjMlZzWmk1elkyOXlaWE02Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TnpNMk16Vm1DaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JpZWlCblpYUmZjMk52Y21WZllXWjBaWEpmYVdaZlpXeHpaVUF6Q2lBZ0lDQmlkWEo1SURFS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5eVpYQjFkR0YwYVc5dVgzSmxaMmx6ZEhKNUxuQjVPakkxTmdvZ0lDQWdMeThnY21WMGRYSnVJSE5sYkdZdWMyTnZjbVZ6VzJGcFpGMEtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1Mbk5qYjNKbGN5QmxiblJ5ZVNCbGVHbHpkSE1LQ21kbGRGOXpZMjl5WlY5aFpuUmxjbDlwYm14cGJtVmtYM0psY0hWMFlYUnBiMjVmY21WbmFYTjBjbmt1VW1Wd2RYUmhkR2x2YmxKbFoybHpkSEo1TG1kbGRGOXpZMjl5WlVBME9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwzSmxjSFYwWVhScGIyNWZjbVZuYVhOMGNua3VjSGs2TWpVeUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbWRsZEY5elkyOXlaVjloWm5SbGNsOXBabDlsYkhObFFETTZDaUFnSUNCd2IzQUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXlaWEIxZEdGMGFXOXVYM0psWjJsemRISjVMbkI1T2pJMU53b2dJQ0FnTHk4Z2JtOTNJRDBnUjJ4dlltRnNMbXhoZEdWemRGOTBhVzFsYzNSaGJYQUtJQ0FnSUdkc2IySmhiQ0JNWVhSbGMzUlVhVzFsYzNSaGJYQUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXlaWEIxZEdGMGFXOXVYM0psWjJsemRISjVMbkI1T2pJMk1nb2dJQ0FnTHk4Z2FtOWljMTl3WVdsa1BXRnlZelF1VlVsdWREWTBLREFwTEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBiMklLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl5WlhCMWRHRjBhVzl1WDNKbFoybHpkSEo1TG5CNU9qSTJOZ29nSUNBZ0x5OGdabWx5YzNSZllYUTlZWEpqTkM1VlNXNTBOalFvYm05M0tTd0tJQ0FnSUhOM1lYQUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXlaWEIxZEdGMGFXOXVYM0psWjJsemRISjVMbkI1T2pJMU9DMHlOamdLSUNBZ0lDOHZJQ01nUVc0Z2RXNXJibTkzYmlCaFoyVnVkQ0J5WldGa2N5QmhjeUJoYkd3dGVtVnlieUJ5WVhSb1pYSWdkR2hoYmlCbGNuSnZjbWx1WnpvZ0ltNXZJSEpsWTI5eVpDSWdhWE1LSUNBZ0lDOHZJQ01nWVNCeVpXRnNJR0Z1YzNkbGNpQmhibVFnZEdobElHTmhiR3hsY2lCemFHOTFiR1FnY21WdVpHVnlJR2wwSUdGeklITjFZMmd1Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdVMk52Y21Vb0NpQWdJQ0F2THlBZ0lDQWdZV2RsYm5SZmFXUTlZWEpqTkM1VlNXNTBOalFvWVdsa0tTd0tJQ0FnSUM4dklDQWdJQ0JxYjJKelgzQmhhV1E5WVhKak5DNVZTVzUwTmpRb01Da3NDaUFnSUNBdkx5QWdJQ0FnZG05c2RXMWxYMjFwWTNKdlBXRnlZelF1VlVsdWREWTBLREFwTEFvZ0lDQWdMeThnSUNBZ0lIWmhiR2xrWVhSbFpEMWhjbU0wTGxWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNBZ0lDQmthWE53ZFhSbFpEMWhjbU0wTGxWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNBZ0lDQm1hWEp6ZEY5aGREMWhjbU0wTGxWSmJuUTJOQ2h1YjNjcExBb2dJQ0FnTHk4Z0lDQWdJR3hoYzNSZllYUTlZWEpqTkM1VlNXNTBOalFvYm05M0tTd0tJQ0FnSUM4dklDa0tJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdaR2xuSURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwzSmxjSFYwWVhScGIyNWZjbVZuYVhOMGNua3VjSGs2TWpVeUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUdJZ1oyVjBYM05qYjNKbFgyRm1kR1Z5WDJsdWJHbHVaV1JmY21Wd2RYUmhkR2x2Ymw5eVpXZHBjM1J5ZVM1U1pYQjFkR0YwYVc5dVVtVm5hWE4wY25rdVoyVjBYM05qYjNKbFFEUUtDZ292THlCeVpYQjFkR0YwYVc5dVgzSmxaMmx6ZEhKNUxsSmxjSFYwWVhScGIyNVNaV2RwYzNSeWVTNWZkRzkxWTJnb1lXZGxiblJmYVdRNklIVnBiblEyTkNrZ0xUNGdZbmwwWlhNNkNsOTBiM1ZqYURvS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5eVpYQjFkR0YwYVc5dVgzSmxaMmx6ZEhKNUxuQjVPamsyTFRrM0NpQWdJQ0F2THlCQWMzVmljbTkxZEdsdVpRb2dJQ0FnTHk4Z1pHVm1JRjkwYjNWamFDaHpaV3htTENCaFoyVnVkRjlwWkRvZ1ZVbHVkRFkwS1NBdFBpQlRZMjl5WlRvS0lDQWdJSEJ5YjNSdklERWdNUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMM0psY0hWMFlYUnBiMjVmY21WbmFYTjBjbmt1Y0hrNk9UZ0tJQ0FnSUM4dklHNXZkeUE5SUVkc2IySmhiQzVzWVhSbGMzUmZkR2x0WlhOMFlXMXdDaUFnSUNCbmJHOWlZV3dnVEdGMFpYTjBWR2x0WlhOMFlXMXdDaUFnSUNBdkx5QmpiMjUwY21GamRITXZjbVZ3ZFhSaGRHbHZibDl5WldkcGMzUnllUzV3ZVRvNU9Rb2dJQ0FnTHk4Z2FXWWdZV2RsYm5SZmFXUWdhVzRnYzJWc1ppNXpZMjl5WlhNNkNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2wwYjJJS0lDQWdJR1IxY0FvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURjek5qTTFaZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWW5vZ1gzUnZkV05vWDJGbWRHVnlYMmxtWDJWc2MyVkFNZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMM0psY0hWMFlYUnBiMjVmY21WbmFYTjBjbmt1Y0hrNk1UQXdDaUFnSUNBdkx5QnlaWFIxY200Z2MyVnNaaTV6WTI5eVpYTmJZV2RsYm5SZmFXUmRMbU52Y0hrb0tRb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVjMk52Y21WeklHVnVkSEo1SUdWNGFYTjBjd29nSUNBZ1puSmhiV1ZmWW5WeWVTQXdDaUFnSUNCeVpYUnpkV0lLQ2w5MGIzVmphRjloWm5SbGNsOXBabDlsYkhObFFESTZDaUFnSUNCd2IzQUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXlaWEIxZEdGMGFXOXVYM0psWjJsemRISjVMbkI1T2pFd013b2dJQ0FnTHk4Z2FtOWljMTl3WVdsa1BXRnlZelF1VlVsdWREWTBLREFwTEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBiMklLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl5WlhCMWRHRjBhVzl1WDNKbFoybHpkSEo1TG5CNU9qRXdOd29nSUNBZ0x5OGdabWx5YzNSZllYUTlZWEpqTkM1VlNXNTBOalFvYm05M0tTd0tJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDNKbGNIVjBZWFJwYjI1ZmNtVm5hWE4wY25rdWNIazZNVEF4TFRFd09Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUZOamIzSmxLQW9nSUNBZ0x5OGdJQ0FnSUdGblpXNTBYMmxrUFdGeVl6UXVWVWx1ZERZMEtHRm5aVzUwWDJsa0tTd0tJQ0FnSUM4dklDQWdJQ0JxYjJKelgzQmhhV1E5WVhKak5DNVZTVzUwTmpRb01Da3NDaUFnSUNBdkx5QWdJQ0FnZG05c2RXMWxYMjFwWTNKdlBXRnlZelF1VlVsdWREWTBLREFwTEFvZ0lDQWdMeThnSUNBZ0lIWmhiR2xrWVhSbFpEMWhjbU0wTGxWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNBZ0lDQmthWE53ZFhSbFpEMWhjbU0wTGxWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNBZ0lDQm1hWEp6ZEY5aGREMWhjbU0wTGxWSmJuUTJOQ2h1YjNjcExBb2dJQ0FnTHk4Z0lDQWdJR3hoYzNSZllYUTlZWEpqTkM1VlNXNTBOalFvYm05M0tTd0tJQ0FnSUM4dklDa0tJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdaR2xuSURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnY21WMGMzVmlDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFBRUlJQ1lIQkJVZmZIVURjMk5mREdsa1pXNTBhWFI1WDJGd2NBNTJZV3hwWkdGMGFXOXVYMkZ3Y0FwMWMyUmpYMkZ6YzJWMEJSVWZmSFdBQk1lNWNHTXhHRUFBQ2lvaVp5Y0VJbWNySW1jeEcwRUFPVEVaRkVReEdFU0NCZ1JmQnVMZUJFOW1hZmtFRkJnak93U3ppajRkQkR0UVhhWUVKSDZRb0RZYUFJNEdBQndBU1FCb0FTTUJaQUd5QUNLQkJURVpqZ0lBREFBQkFERVlSREVBTWdrU1JDTkRNUmdVUXpZYUFVa1ZKQkpFTmhvQ1NSVWtFa1F4QURJSkVrUWlLbVZFRkVRWFNVUk1GeXBNWnljRVRHY25CYkFqUXpZYUFVa1ZKQkpFTVFBeUNSSkVJaXRsUkJSRUYwbEVLMHhuSndXd0kwTXhGaU1KU1RnUWdRUVNSRFlhQVVrVkpCSkVOaG9DU1JVa0VrUkxBamdTU1VSTEF6Z1JJaWNFWlVRU1JFc0NGMHNDRjBzQkUwU3hJaXBsUkVteUdDY0dzaHBQQkxJYWdRYXlFQ0t5QWJPMFBrbFhBQVFvRWtSWEJBQkpGU1VTUkVzRk9CUVNSTEd5R0NjR3NocFBBcklhZ1FheUVDS3lBYk8wUGtsWEFBUW9Fa1JYQkFCSkZTVVNSRThET0FBU1JFbUlBUE5KSkZzakNCWmNDRW1CRUZ0UEF3Z1dYQkF5QnhaY01Fd1dLVXhRU3dHL1Z3Z0lLRXhRc0NORE5ob0JTUlVrRWtRMkdnSkpUZ0lWSkJKRUZ4WXBURkJKdlVVQlFBQUxSZ0tBQVFBb1RGQ3dJME8rUklFd1d6SUhUd0lYVHdJSURvQUJBQ0pQQWxSQy8rSTJHZ0ZKRlNRU1JEWWFBa2tWSXhKRUlpdGxSRWxFTWcwU1JFd1hTVTRDaUFCb1RDSlRRUUFiU1lFWVd5TUlGbHdZTWdjV1hEQkxBUllwVEZCTXZ5Y0ZzQ05EU1NWYkl3Z1dYQ0JDLytNMkdnRkhBaFVrRWtRWEZpbE1VRW05UlFGQkFBcEZBYjVFS0V4UXNDTkRTRElISWhaTUZrOENTd0pRU3dKUVN3SlFUd0pRU3dGUVRGQkMvOTJLQVFFeUI0di9Ga2twVEZCSnZVVUJRUUFGdmtTTUFJbElJaFpQQWhaUEFrc0NVRXNDVUVzQ1VFOENVRXNCVUV4UWlRPT0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo5LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
