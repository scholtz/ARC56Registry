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

namespace Arc56.Generated.Falcon0516.CleverFyre.PolicyVault_ae4a3700
{


    public class PolicyVaultProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public PolicyVaultProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class PolicyRecord : AVMObjectType
            {
                public ulong ExpiryRound { get; set; }

                public ulong MissedRenewals { get; set; }

                public ulong SpendCapTier { get; set; }

                public byte[] OperatorPubkey { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExpiryRound = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vExpiryRound.From(ExpiryRound);
                    ret.AddRange(vExpiryRound.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMissedRenewals = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vMissedRenewals.From(MissedRenewals);
                    ret.AddRange(vMissedRenewals.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSpendCapTier = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vSpendCapTier.From(SpendCapTier);
                    ret.AddRange(vSpendCapTier.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOperatorPubkey = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vOperatorPubkey.From(OperatorPubkey);
                    ret.AddRange(vOperatorPubkey.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static PolicyRecord Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new PolicyRecord();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExpiryRound = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vExpiryRound.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueExpiryRound = vExpiryRound.ToValue();
                    if (valueExpiryRound is ulong vExpiryRoundValue) { ret.ExpiryRound = vExpiryRoundValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMissedRenewals = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vMissedRenewals.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueMissedRenewals = vMissedRenewals.ToValue();
                    if (valueMissedRenewals is ulong vMissedRenewalsValue) { ret.MissedRenewals = vMissedRenewalsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSpendCapTier = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vSpendCapTier.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSpendCapTier = vSpendCapTier.ToValue();
                    if (valueSpendCapTier is ulong vSpendCapTierValue) { ret.SpendCapTier = vSpendCapTierValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOperatorPubkey = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vOperatorPubkey.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOperatorPubkey = vOperatorPubkey.ToValue();
                    if (valueOperatorPubkey is byte[] vOperatorPubkeyValue) { ret.OperatorPubkey = vOperatorPubkeyValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as PolicyRecord);
                }
                public bool Equals(PolicyRecord? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(PolicyRecord left, PolicyRecord right)
                {
                    return EqualityComparer<PolicyRecord>.Default.Equals(left, right);
                }
                public static bool operator !=(PolicyRecord left, PolicyRecord right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="agent"> </param>
        /// <param name="window_rounds"> </param>
        /// <param name="operator_pubkey"> </param>
        public async Task InitPolicy(Algorand.Address agent, ulong window_rounds, byte[] operator_pubkey, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 167, 61, 95, 60 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);
            var window_roundsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); window_roundsAbi.From(window_rounds);
            var operator_pubkeyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); operator_pubkeyAbi.From(operator_pubkey);

            var result = await base.CallApp(new List<object> { abiHandle, agentAbi, window_roundsAbi, operator_pubkeyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> InitPolicy_Transactions(Algorand.Address agent, ulong window_rounds, byte[] operator_pubkey, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 167, 61, 95, 60 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);
            var window_roundsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); window_roundsAbi.From(window_rounds);
            var operator_pubkeyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); operator_pubkeyAbi.From(operator_pubkey);

            return await base.MakeTransactionList(new List<object> { abiHandle, agentAbi, window_roundsAbi, operator_pubkeyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="agent"> </param>
        /// <param name="challenge"> </param>
        /// <param name="challenge_sig"> </param>
        /// <param name="extension_rounds"> </param>
        public async Task RenewWithProof(Algorand.Address agent, byte[] challenge, byte[] challenge_sig, ulong extension_rounds, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 149, 114, 173, 187 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);
            var challengeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); challengeAbi.From(challenge);
            var challenge_sigAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); challenge_sigAbi.From(challenge_sig);
            var extension_roundsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); extension_roundsAbi.From(extension_rounds);

            var result = await base.CallApp(new List<object> { abiHandle, agentAbi, challengeAbi, challenge_sigAbi, extension_roundsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RenewWithProof_Transactions(Algorand.Address agent, byte[] challenge, byte[] challenge_sig, ulong extension_rounds, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 149, 114, 173, 187 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);
            var challengeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); challengeAbi.From(challenge);
            var challenge_sigAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); challenge_sigAbi.From(challenge_sig);
            var extension_roundsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); extension_roundsAbi.From(extension_rounds);

            return await base.MakeTransactionList(new List<object> { abiHandle, agentAbi, challengeAbi, challenge_sigAbi, extension_roundsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="agent"> </param>
        /// <param name="amount"> </param>
        public async Task<ulong> CheckAndEnforce(Algorand.Address agent, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 193, 140, 107, 50 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, agentAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CheckAndEnforce_Transactions(Algorand.Address agent, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 193, 140, 107, 50 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, agentAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="agent"> </param>
        public async Task TickMissedRenewal(Algorand.Address agent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 249, 159, 118, 150 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);

            var result = await base.CallApp(new List<object> { abiHandle, agentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TickMissedRenewal_Transactions(Algorand.Address agent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 249, 159, 118, 150 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);

            return await base.MakeTransactionList(new List<object> { abiHandle, agentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="agent"> </param>
        public async Task<ulong> GetPolicyStatus(Algorand.Address agent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 189, 183, 89, 235 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);

            var result = await base.CallApp(new List<object> { abiHandle, agentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetPolicyStatus_Transactions(Algorand.Address agent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 189, 183, 89, 235 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);

            return await base.MakeTransactionList(new List<object> { abiHandle, agentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUG9saWN5VmF1bHQiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiUG9saWN5UmVjb3JkIjpbeyJuYW1lIjoiZXhwaXJ5X3JvdW5kIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6Im1pc3NlZF9yZW5ld2FscyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJzcGVuZF9jYXBfdGllciIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJvcGVyYXRvcl9wdWJrZXkiLCJ0eXBlIjoiYnl0ZVtdIn1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImluaXRfcG9saWN5IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZ2VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoid2luZG93X3JvdW5kcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3BlcmF0b3JfcHVia2V5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlbmV3X3dpdGhfcHJvb2YiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFnZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjaGFsbGVuZ2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNoYWxsZW5nZV9zaWciLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImV4dGVuc2lvbl9yb3VuZHMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2hlY2tfYW5kX2VuZm9yY2UiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFnZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0aWNrX21pc3NlZF9yZW5ld2FsIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZ2VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfcG9saWN5X3N0YXR1cyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWdlbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzI0N10sImVycm9yTWVzc2FnZSI6IkludmFsaWQgcmVuZXdhbCBzaWduYXR1cmUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszODBdLCJlcnJvck1lc3NhZ2UiOiJhZ2VudCBmdWxseSBmcm96ZW4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNzBdLCJlcnJvck1lc3NhZ2UiOiJjYXBwZWQgYXQgMC4xIEFMR08iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNTBdLCJlcnJvck1lc3NhZ2UiOiJjYXBwZWQgYXQgMSBBTEdPIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzE0LDMzMywzOTksNDE5LDUxOCw1MzddLCJlcnJvck1lc3NhZ2UiOiJpbmRleCBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTEyLDE4MiwxOThdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTksMTg5LDIwNV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5NywxNzYsMjk0LDM5Miw1MDhdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTA1LDIxNiwzMDJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjldLCJlcnJvck1lc3NhZ2UiOiJvcGVyYXRvcl9wdWJrZXkgbXVzdCBiZSAzMiBieXRlcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXlJRGdnTUNBeENpQWdJQ0JpZVhSbFkySnNiMk5ySUNKd2IyeHBZMmxsY3lJZ01IZ3dNREZoSURCNE1UVXhaamRqTnpVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4cFkzbGZkbUYxYkhRdlkyOXVkSEpoWTNRdWNIazZNVEFLSUNBZ0lDOHZJR05zWVhOeklGQnZiR2xqZVZaaGRXeDBLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnWW5vZ2JXRnBibDlmWDJGc1oyOXdlVjlrWldaaGRXeDBYMk55WldGMFpVQXhOQW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjRZVGN6WkRWbU0yTWdNSGc1TlRjeVlXUmlZaUF3ZUdNeE9HTTJZak15SURCNFpqazVaamMyT1RZZ01IaGlaR0kzTlRsbFlpQXZMeUJ0WlhSb2IyUWdJbWx1YVhSZmNHOXNhV041S0dGa1pISmxjM01zZFdsdWREWTBMR0o1ZEdWYlhTbDJiMmxrSWl3Z2JXVjBhRzlrSUNKeVpXNWxkMTkzYVhSb1gzQnliMjltS0dGa1pISmxjM01zWW5sMFpWdGRMR0o1ZEdWYlhTeDFhVzUwTmpRcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWTJobFkydGZZVzVrWDJWdVptOXlZMlVvWVdSa2NtVnpjeXgxYVc1ME5qUXBkV2x1ZERZMElpd2diV1YwYUc5a0lDSjBhV05yWDIxcGMzTmxaRjl5Wlc1bGQyRnNLR0ZrWkhKbGMzTXBkbTlwWkNJc0lHMWxkR2h2WkNBaVoyVjBYM0J2YkdsamVWOXpkR0YwZFhNb1lXUmtjbVZ6Y3lsMWFXNTBOalFpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCcGJtbDBYM0J2YkdsamVTQnlaVzVsZDE5M2FYUm9YM0J5YjI5bUlHTm9aV05yWDJGdVpGOWxibVp2Y21ObElIUnBZMnRmYldsemMyVmtYM0psYm1WM1lXd2daMlYwWDNCdmJHbGplVjl6ZEdGMGRYTUtJQ0FnSUdWeWNnb0tiV0ZwYmw5ZlgyRnNaMjl3ZVY5a1pXWmhkV3gwWDJOeVpXRjBaVUF4TkRvS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBaENpQWdJQ0FtSmdvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbkJ2YkdsamVWOTJZWFZzZEM1amIyNTBjbUZqZEM1UWIyeHBZM2xXWVhWc2RDNXBibWwwWDNCdmJHbGplVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21sdWFYUmZjRzlzYVdONU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJHbGplVjkyWVhWc2RDOWpiMjUwY21GamRDNXdlVG94TkFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYekFnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiR2xqZVY5MllYVnNkQzlqYjI1MGNtRmpkQzV3ZVRveE55MHhPQW9nSUNBZ0x5OGdJeUJEY21WaGRHVWdibVYzSUhCdmJHbGplU0JsYm5SeWVTNGdUMjVzZVNCallXeHNZV0pzWlNCaWVTQnZjbWNnWVdSdGFXNHVDaUFnSUNBdkx5QmhjM05sY25RZ2IzQmxjbUYwYjNKZmNIVmlhMlY1TG14bGJtZDBhQ0E5UFNBek1pd2dJbTl3WlhKaGRHOXlYM0IxWW10bGVTQnRkWE4wSUdKbElETXlJR0o1ZEdWeklnb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmNHVnlZWFJ2Y2w5d2RXSnJaWGtnYlhWemRDQmlaU0F6TWlCaWVYUmxjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiR2xqZVY5MllYVnNkQzlqYjI1MGNtRmpkQzV3ZVRveU1Rb2dJQ0FnTHk4Z1pYaHdhWEo1WDNKdmRXNWtQVWRzYjJKaGJDNXliM1Z1WkNBcklIZHBibVJ2ZDE5eWIzVnVaSE1zQ2lBZ0lDQm5iRzlpWVd3Z1VtOTFibVFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnS3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkdsamVWOTJZWFZzZEM5amIyNTBjbUZqZEM1d2VUb3lNQzB5TlFvZ0lDQWdMeThnYzJWc1ppNXdiMnhwWTJsbGMxdGhaMlZ1ZEYwZ1BTQlFiMnhwWTNsU1pXTnZjbVFvQ2lBZ0lDQXZMeUFnSUNBZ1pYaHdhWEo1WDNKdmRXNWtQVWRzYjJKaGJDNXliM1Z1WkNBcklIZHBibVJ2ZDE5eWIzVnVaSE1zQ2lBZ0lDQXZMeUFnSUNBZ2JXbHpjMlZrWDNKbGJtVjNZV3h6UFZWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNBZ0lDQnpjR1Z1WkY5allYQmZkR2xsY2oxVlNXNTBOalFvTUNrc0NpQWdJQ0F2THlBZ0lDQWdiM0JsY21GMGIzSmZjSFZpYTJWNVBXOXdaWEpoZEc5eVgzQjFZbXRsZVFvZ0lDQWdMeThnS1FvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkdsamVWOTJZWFZzZEM5amIyNTBjbUZqZEM1d2VUb3lNZ29nSUNBZ0x5OGdiV2x6YzJWa1gzSmxibVYzWVd4elBWVkpiblEyTkNnd0tTd0tJQ0FnSUdsdWRHTmZNaUF2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2FXTjVYM1poZFd4MEwyTnZiblJ5WVdOMExuQjVPakl3TFRJMUNpQWdJQ0F2THlCelpXeG1MbkJ2YkdsamFXVnpXMkZuWlc1MFhTQTlJRkJ2YkdsamVWSmxZMjl5WkNnS0lDQWdJQzh2SUNBZ0lDQmxlSEJwY25sZmNtOTFibVE5UjJ4dlltRnNMbkp2ZFc1a0lDc2dkMmx1Wkc5M1gzSnZkVzVrY3l3S0lDQWdJQzh2SUNBZ0lDQnRhWE56WldSZmNtVnVaWGRoYkhNOVZVbHVkRFkwS0RBcExBb2dJQ0FnTHk4Z0lDQWdJSE53Wlc1a1gyTmhjRjkwYVdWeVBWVkpiblEyTkNnd0tTd0tJQ0FnSUM4dklDQWdJQ0J2Y0dWeVlYUnZjbDl3ZFdKclpYazliM0JsY21GMGIzSmZjSFZpYTJWNUNpQWdJQ0F2THlBcENpQWdJQ0JwZEc5aUNpQWdJQ0J6ZDJGd0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEQXdNV0VLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2FXTjVYM1poZFd4MEwyTnZiblJ5WVdOMExuQjVPakl3Q2lBZ0lDQXZMeUJ6Wld4bUxuQnZiR2xqYVdWelcyRm5aVzUwWFNBOUlGQnZiR2xqZVZKbFkyOXlaQ2dLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbkJ2YkdsamFXVnpJZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeHBZM2xmZG1GMWJIUXZZMjl1ZEhKaFkzUXVjSGs2TWpBdE1qVUtJQ0FnSUM4dklITmxiR1l1Y0c5c2FXTnBaWE5iWVdkbGJuUmRJRDBnVUc5c2FXTjVVbVZqYjNKa0tBb2dJQ0FnTHk4Z0lDQWdJR1Y0Y0dseWVWOXliM1Z1WkQxSGJHOWlZV3d1Y205MWJtUWdLeUIzYVc1a2IzZGZjbTkxYm1SekxBb2dJQ0FnTHk4Z0lDQWdJRzFwYzNObFpGOXlaVzVsZDJGc2N6MVZTVzUwTmpRb01Da3NDaUFnSUNBdkx5QWdJQ0FnYzNCbGJtUmZZMkZ3WDNScFpYSTlWVWx1ZERZMEtEQXBMQW9nSUNBZ0x5OGdJQ0FnSUc5d1pYSmhkRzl5WDNCMVltdGxlVDF2Y0dWeVlYUnZjbDl3ZFdKclpYa0tJQ0FnSUM4dklDa0tJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzYVdONVgzWmhkV3gwTDJOdmJuUnlZV04wTG5CNU9qRTBDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHbHVkR05mTXlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWNHOXNhV041WDNaaGRXeDBMbU52Ym5SeVlXTjBMbEJ2YkdsamVWWmhkV3gwTG5KbGJtVjNYM2RwZEdoZmNISnZiMlpiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dweVpXNWxkMTkzYVhSb1gzQnliMjltT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkdsamVWOTJZWFZzZEM5amIyNTBjbUZqZEM1d2VUb3lOd29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNaUF2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMnhwWTNsZmRtRjFiSFF2WTI5dWRISmhZM1F1Y0hrNk1qa3RNekVLSUNBZ0lDOHZJQ01nVm1WeWFXWjVJR1ZrTWpVMU1Ua2djMmxuSUc5bUlISmxibVYzWVd4ZlkyaGhiR3hsYm1kbElHUmxjbWwyWldRZ1puSnZiU0JzWVhOMElETWdjR0Y1YldWdWRDQm9ZWE5vWlhNdUNpQWdJQ0F2THlBaklGSmxjMlYwSUcxcGMzTmxaRjl5Wlc1bGQyRnNjeUE5SURBdUlFVjRkR1Z1WkNCbGVIQnBjbmxmY205MWJtUWdZbmtnZDJsdVpHOTNMZ29nSUNBZ0x5OGdjRzlzYVdONUlEMGdjMlZzWmk1d2IyeHBZMmxsYzF0aFoyVnVkRjB1WTI5d2VTZ3BDaUFnSUNCaWVYUmxZMTh3SUM4dklDSndiMnhwWTJsbGN5SUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2FXTjVYM1poZFd4MEwyTnZiblJ5WVdOMExuQjVPakk1TFRNeUNpQWdJQ0F2THlBaklGWmxjbWxtZVNCbFpESTFOVEU1SUhOcFp5QnZaaUJ5Wlc1bGQyRnNYMk5vWVd4c1pXNW5aU0JrWlhKcGRtVmtJR1p5YjIwZ2JHRnpkQ0F6SUhCaGVXMWxiblFnYUdGemFHVnpMZ29nSUNBZ0x5OGdJeUJTWlhObGRDQnRhWE56WldSZmNtVnVaWGRoYkhNZ1BTQXdMaUJGZUhSbGJtUWdaWGh3YVhKNVgzSnZkVzVrSUdKNUlIZHBibVJ2ZHk0S0lDQWdJQzh2SUhCdmJHbGplU0E5SUhObGJHWXVjRzlzYVdOcFpYTmJZV2RsYm5SZExtTnZjSGtvS1FvZ0lDQWdMeThnY0hWaWEyVjVJRDBnY0c5c2FXTjVMbTl3WlhKaGRHOXlYM0IxWW10bGVRb2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb2FXNTBJREkyQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNZ29nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUdKMGIya0tJQ0FnSUdsdWRHTmZNQ0F2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdjSFZ6YUdsdWRDQXlOZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkdsamVWOTJZWFZzZEM5amIyNTBjbUZqZEM1d2VUb3pNZ29nSUNBZ0x5OGdjSFZpYTJWNUlEMGdjRzlzYVdONUxtOXdaWEpoZEc5eVgzQjFZbXRsZVFvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMnhwWTNsZmRtRjFiSFF2WTI5dWRISmhZM1F1Y0hrNk16UUtJQ0FnSUM4dklHRnpjMlZ5ZENCdmNDNWxaREkxTlRFNWRtVnlhV1o1S0dOb1lXeHNaVzVuWlN3Z1kyaGhiR3hsYm1kbFgzTnBaeXdnY0hWaWEyVjVLU3dnSWtsdWRtRnNhV1FnY21WdVpYZGhiQ0J6YVdkdVlYUjFjbVVpQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdaR2xuSURJS0lDQWdJR1ZrTWpVMU1UbDJaWEpwWm5rS0lDQWdJR0Z6YzJWeWRDQXZMeUJKYm5aaGJHbGtJSEpsYm1WM1lXd2djMmxuYm1GMGRYSmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNhV041WDNaaGRXeDBMMk52Ym5SeVlXTjBMbkI1T2pNM0NpQWdJQ0F2THlCbGVIQnBjbmxmY205MWJtUTlSMnh2WW1Gc0xuSnZkVzVrSUNzZ1pYaDBaVzV6YVc5dVgzSnZkVzVrY3l3S0lDQWdJR2RzYjJKaGJDQlNiM1Z1WkFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNBckNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2FXTjVYM1poZFd4MEwyTnZiblJ5WVdOMExuQjVPak0yTFRReENpQWdJQ0F2THlCelpXeG1MbkJ2YkdsamFXVnpXMkZuWlc1MFhTQTlJRkJ2YkdsamVWSmxZMjl5WkNnS0lDQWdJQzh2SUNBZ0lDQmxlSEJwY25sZmNtOTFibVE5UjJ4dlltRnNMbkp2ZFc1a0lDc2daWGgwWlc1emFXOXVYM0p2ZFc1a2N5d0tJQ0FnSUM4dklDQWdJQ0J0YVhOelpXUmZjbVZ1WlhkaGJITTlWVWx1ZERZMEtEQXBMQW9nSUNBZ0x5OGdJQ0FnSUhOd1pXNWtYMk5oY0Y5MGFXVnlQVlZKYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ0FnSUNCdmNHVnlZWFJ2Y2w5d2RXSnJaWGs5Y0hWaWEyVjVDaUFnSUNBdkx5QXBDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNhV041WDNaaGRXeDBMMk52Ym5SeVlXTjBMbkI1T2pNNENpQWdJQ0F2THlCdGFYTnpaV1JmY21WdVpYZGhiSE05VlVsdWREWTBLREFwTEFvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMnhwWTNsZmRtRjFiSFF2WTI5dWRISmhZM1F1Y0hrNk16WXROREVLSUNBZ0lDOHZJSE5sYkdZdWNHOXNhV05wWlhOYllXZGxiblJkSUQwZ1VHOXNhV041VW1WamIzSmtLQW9nSUNBZ0x5OGdJQ0FnSUdWNGNHbHllVjl5YjNWdVpEMUhiRzlpWVd3dWNtOTFibVFnS3lCbGVIUmxibk5wYjI1ZmNtOTFibVJ6TEFvZ0lDQWdMeThnSUNBZ0lHMXBjM05sWkY5eVpXNWxkMkZzY3oxVlNXNTBOalFvTUNrc0NpQWdJQ0F2THlBZ0lDQWdjM0JsYm1SZlkyRndYM1JwWlhJOVZVbHVkRFkwS0RBcExBb2dJQ0FnTHk4Z0lDQWdJRzl3WlhKaGRHOXlYM0IxWW10bGVUMXdkV0pyWlhrS0lDQWdJQzh2SUNrS0lDQWdJR2wwYjJJS0lDQWdJSE4zWVhBS0lDQWdJR1JwWnlBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1EQXhZUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBeENpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMnhwWTNsZmRtRjFiSFF2WTI5dWRISmhZM1F1Y0hrNk1qY0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ2FXNTBZMTh6SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1d2IyeHBZM2xmZG1GMWJIUXVZMjl1ZEhKaFkzUXVVRzlzYVdONVZtRjFiSFF1WTJobFkydGZZVzVrWDJWdVptOXlZMlZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwamFHVmphMTloYm1SZlpXNW1iM0pqWlRvS0lDQWdJSEIxYzJoaWVYUmxjeUFpSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkdsamVWOTJZWFZzZEM5amIyNTBjbUZqZEM1d2VUbzBNd29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzYVdONVgzWmhkV3gwTDJOdmJuUnlZV04wTG5CNU9qUTFMVFEzQ2lBZ0lDQXZMeUFqSUZKbGRIVnlibk02SURBOVlXeHNiM2RsWkN3Z01UMTNZWEp1S0dOaGNIQmxaQ0F4SUVGTVIwOHBMQ0F5UFdOaGNIQmxaQ2d3TGpFZ1FVeEhUeWtzSURNOVpuVnNiSGtnWm5KdmVtVnVDaUFnSUNBdkx5QWpJRWR5WVdSMVlYUmxaRG9nYldsemMyVmtYM0psYm1WM1lXeHpJREVnTFQ0Z2RHbGxjaUF4TENBeUlDMCtJSFJwWlhJZ01pd2dNeXNnTFQ0Z2RHbGxjaUF6Q2lBZ0lDQXZMeUJ3YjJ4cFkza2dQU0J6Wld4bUxuQnZiR2xqYVdWelcyRm5aVzUwWFM1amIzQjVLQ2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbkJ2YkdsamFXVnpJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMnhwWTNsZmRtRjFiSFF2WTI5dWRISmhZM1F1Y0hrNk5Ea0tJQ0FnSUM4dklHbG1JRWRzYjJKaGJDNXliM1Z1WkNBK1BTQndiMnhwWTNrdVpYaHdhWEo1WDNKdmRXNWtPZ29nSUNBZ1oyeHZZbUZzSUZKdmRXNWtDaUFnSUNCemQyRndDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnYVc1MFkxOHhJQzh2SURnS0lDQWdJR0p2ZUY5bGVIUnlZV04wSUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCaWRHOXBDaUFnSUNBK1BRb2dJQ0FnWW5vZ1kyaGxZMnRmWVc1a1gyVnVabTl5WTJWZllXWjBaWEpmYVdaZlpXeHpaVUF6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzYVdONVgzWmhkV3gwTDJOdmJuUnlZV04wTG5CNU9qVXdDaUFnSUNBdkx5QnlaWFIxY200Z1ZVbHVkRFkwS0RNcENpQWdJQ0J3ZFhOb2FXNTBJRE1LQ21Ob1pXTnJYMkZ1WkY5bGJtWnZjbU5sWDJGbWRHVnlYMmx1YkdsdVpXUmZjMjFoY25SZlkyOXVkSEpoWTNSekxuQnZiR2xqZVY5MllYVnNkQzVqYjI1MGNtRmpkQzVRYjJ4cFkzbFdZWFZzZEM1amFHVmphMTloYm1SZlpXNW1iM0pqWlVBeE1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeHBZM2xmZG1GMWJIUXZZMjl1ZEhKaFkzUXVjSGs2TkRNS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHpJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tZMmhsWTJ0ZllXNWtYMlZ1Wm05eVkyVmZZV1owWlhKZmFXWmZaV3h6WlVBek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJHbGplVjkyWVhWc2RDOWpiMjUwY21GamRDNXdlVG8xTWdvZ0lDQWdMeThnZEdsbGNpQTlJSEJ2YkdsamVTNXpjR1Z1WkY5allYQmZkR2xsY2dvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElERTJDaUFnSUNCcGJuUmpYekVnTHk4Z09Bb2dJQ0FnWW05NFgyVjRkSEpoWTNRZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lHSjBiMmtLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0EwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzYVdONVgzWmhkV3gwTDJOdmJuUnlZV04wTG5CNU9qVXpDaUFnSUNBdkx5QnBaaUIwYVdWeUlEMDlJRlZKYm5RMk5DZ3hLVG9LSUNBZ0lHbHVkR05mTXlBdkx5QXhDaUFnSUNBOVBRb2dJQ0FnWW5vZ1kyaGxZMnRmWVc1a1gyVnVabTl5WTJWZlpXeHpaVjlpYjJSNVFEVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeHBZM2xmZG1GMWJIUXZZMjl1ZEhKaFkzUXVjSGs2TlRRS0lDQWdJQzh2SUdGemMyVnlkQ0JoYlc5MWJuUWdQRDBnVlVsdWREWTBLREZmTURBd1h6QXdNQ2tzSUNKallYQndaV1FnWVhRZ01TQkJURWRQSWdvZ0lDQWdaR2xuSURFS0lDQWdJSEIxYzJocGJuUWdNVEF3TURBd01Bb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVhCd1pXUWdZWFFnTVNCQlRFZFBDZ3BqYUdWamExOWhibVJmWlc1bWIzSmpaVjloWm5SbGNsOXBabDlsYkhObFFERXhPZ29nSUNBZ1pHbG5JRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMnhwWTNsZmRtRjFiSFF2WTI5dWRISmhZM1F1Y0hrNk5ETUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ1lpQmphR1ZqYTE5aGJtUmZaVzVtYjNKalpWOWhablJsY2w5cGJteHBibVZrWDNOdFlYSjBYMk52Ym5SeVlXTjBjeTV3YjJ4cFkzbGZkbUYxYkhRdVkyOXVkSEpoWTNRdVVHOXNhV041Vm1GMWJIUXVZMmhsWTJ0ZllXNWtYMlZ1Wm05eVkyVkFNVElLQ21Ob1pXTnJYMkZ1WkY5bGJtWnZjbU5sWDJWc2MyVmZZbTlrZVVBMU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJHbGplVjkyWVhWc2RDOWpiMjUwY21GamRDNXdlVG8xTlFvZ0lDQWdMeThnWld4cFppQjBhV1Z5SUQwOUlGVkpiblEyTkNneUtUb0tJQ0FnSUdScFp5QXlDaUFnSUNCcGJuUmpYekFnTHk4Z01nb2dJQ0FnUFQwS0lDQWdJR0o2SUdOb1pXTnJYMkZ1WkY5bGJtWnZjbU5sWDJWc2MyVmZZbTlrZVVBM0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2FXTjVYM1poZFd4MEwyTnZiblJ5WVdOMExuQjVPalUyQ2lBZ0lDQXZMeUJoYzNObGNuUWdZVzF2ZFc1MElEdzlJRlZKYm5RMk5DZ3hNREJmTURBd0tTd2dJbU5oY0hCbFpDQmhkQ0F3TGpFZ1FVeEhUeUlLSUNBZ0lHUnBaeUF4Q2lBZ0lDQndkWE5vYVc1MElERXdNREF3TUFvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZWEJ3WldRZ1lYUWdNQzR4SUVGTVIwOEtJQ0FnSUdJZ1kyaGxZMnRmWVc1a1gyVnVabTl5WTJWZllXWjBaWEpmYVdaZlpXeHpaVUF4TVFvS1kyaGxZMnRmWVc1a1gyVnVabTl5WTJWZlpXeHpaVjlpYjJSNVFEYzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNhV041WDNaaGRXeDBMMk52Ym5SeVlXTjBMbkI1T2pVM0NpQWdJQ0F2THlCbGJHbG1JSFJwWlhJZ1BqMGdWVWx1ZERZMEtETXBPZ29nSUNBZ1pHbG5JRElLSUNBZ0lIQjFjMmhwYm5RZ013b2dJQ0FnUGowS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QmhaMlZ1ZENCbWRXeHNlU0JtY205NlpXNEtJQ0FnSUdJZ1kyaGxZMnRmWVc1a1gyVnVabTl5WTJWZllXWjBaWEpmYVdaZlpXeHpaVUF4TVFvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXdiMnhwWTNsZmRtRjFiSFF1WTI5dWRISmhZM1F1VUc5c2FXTjVWbUYxYkhRdWRHbGphMTl0YVhOelpXUmZjbVZ1WlhkaGJGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDblJwWTJ0ZmJXbHpjMlZrWDNKbGJtVjNZV3c2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzYVdONVgzWmhkV3gwTDJOdmJuUnlZV04wTG5CNU9qWXlDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeHBZM2xmZG1GMWJIUXZZMjl1ZEhKaFkzUXVjSGs2TmpRdE5qWUtJQ0FnSUM4dklDTWdRMkZzYkdWa0lHSjVJR0poWTJ0bGJtUWdZM0p2YmlCbFlXTm9JR1Z3YjJOb0lHbG1JRzV2SUhKbGJtVjNZV3dnYzJWbGJpNEtJQ0FnSUM4dklDTWdTVzVqY21WdFpXNTBjeUJ0YVhOelpXUmZjbVZ1WlhkaGJITXVJRlZ3WkdGMFpYTWdjM0JsYm1SZlkyRndYM1JwWlhJdUNpQWdJQ0F2THlCd2IyeHBZM2tnUFNCelpXeG1MbkJ2YkdsamFXVnpXMkZuWlc1MFhTNWpiM0I1S0NrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5CdmJHbGphV1Z6SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4cFkzbGZkbUYxYkhRdlkyOXVkSEpoWTNRdWNIazZOalF0TmpjS0lDQWdJQzh2SUNNZ1EyRnNiR1ZrSUdKNUlHSmhZMnRsYm1RZ1kzSnZiaUJsWVdOb0lHVndiMk5vSUdsbUlHNXZJSEpsYm1WM1lXd2djMlZsYmk0S0lDQWdJQzh2SUNNZ1NXNWpjbVZ0Wlc1MGN5QnRhWE56WldSZmNtVnVaWGRoYkhNdUlGVndaR0YwWlhNZ2MzQmxibVJmWTJGd1gzUnBaWEl1Q2lBZ0lDQXZMeUJ3YjJ4cFkza2dQU0J6Wld4bUxuQnZiR2xqYVdWelcyRm5aVzUwWFM1amIzQjVLQ2tLSUNBZ0lDOHZJRzFwYzNObFpDQTlJSEJ2YkdsamVTNXRhWE56WldSZmNtVnVaWGRoYkhNZ0t5QXhDaUFnSUNCcGJuUmpYekVnTHk4Z09Bb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZlpYaDBjbUZqZENBdkx5QnZiaUJsY25KdmNqb2dhVzVrWlhnZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiR2xqZVY5MllYVnNkQzlqYjI1MGNtRmpkQzV3ZVRvMk53b2dJQ0FnTHk4Z2JXbHpjMlZrSUQwZ2NHOXNhV041TG0xcGMzTmxaRjl5Wlc1bGQyRnNjeUFySURFS0lDQWdJR0owYjJrS0lDQWdJR2x1ZEdOZk15QXZMeUF4Q2lBZ0lDQXJDaUFnSUNCa2RYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeHBZM2xmZG1GMWJIUXZZMjl1ZEhKaFkzUXVjSGs2TmpnS0lDQWdJQzh2SUhScFpYSWdQU0JWU1c1ME5qUW9NQ2tLSUNBZ0lHbHVkR05mTWlBdkx5QXdDaUFnSUNCemQyRndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNhV041WDNaaGRXeDBMMk52Ym5SeVlXTjBMbkI1T2pjd0NpQWdJQ0F2THlCcFppQnRhWE56WldRZ1BUMGdWVWx1ZERZMEtERXBPZ29nSUNBZ2FXNTBZMTh6SUM4dklERUtJQ0FnSUQwOUNpQWdJQ0JpZWlCMGFXTnJYMjFwYzNObFpGOXlaVzVsZDJGc1gyVnNjMlZmWW05a2VVQXpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNhV041WDNaaGRXeDBMMk52Ym5SeVlXTjBMbkI1T2pjeENpQWdJQ0F2THlCMGFXVnlJRDBnVlVsdWREWTBLREVwQ2lBZ0lDQnBiblJqWHpNZ0x5OGdNUW9nSUNBZ1luVnllU0F4Q2dwMGFXTnJYMjFwYzNObFpGOXlaVzVsZDJGc1gyRm1kR1Z5WDJsbVgyVnNjMlZBT1RvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4cFkzbGZkbUYxYkhRdlkyOXVkSEpoWTNRdWNIazZOemdLSUNBZ0lDOHZJR1Y0Y0dseWVWOXliM1Z1WkQxd2IyeHBZM2t1Wlhod2FYSjVYM0p2ZFc1a0xBb2dJQ0FnWkdsbklESUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJR2x1ZEdOZk1TQXZMeUE0Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQ0F2THlCdmJpQmxjbkp2Y2pvZ2FXNWtaWGdnYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJHbGplVjkyWVhWc2RDOWpiMjUwY21GamRDNXdlVG80TVFvZ0lDQWdMeThnYjNCbGNtRjBiM0pmY0hWaWEyVjVQWEJ2YkdsamVTNXZjR1Z5WVhSdmNsOXdkV0pyWlhrS0lDQWdJR1JwWnlBeENpQWdJQ0J3ZFhOb2FXNTBJREkyQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNZ29nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUdKMGIya0tJQ0FnSUdsdWRHTmZNQ0F2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTWdvZ0lDQWdjSFZ6YUdsdWRDQXlOZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMnhwWTNsZmRtRjFiSFF2WTI5dWRISmhZM1F1Y0hrNk56Y3RPRElLSUNBZ0lDOHZJSE5sYkdZdWNHOXNhV05wWlhOYllXZGxiblJkSUQwZ1VHOXNhV041VW1WamIzSmtLQW9nSUNBZ0x5OGdJQ0FnSUdWNGNHbHllVjl5YjNWdVpEMXdiMnhwWTNrdVpYaHdhWEo1WDNKdmRXNWtMQW9nSUNBZ0x5OGdJQ0FnSUcxcGMzTmxaRjl5Wlc1bGQyRnNjejF0YVhOelpXUXNDaUFnSUNBdkx5QWdJQ0FnYzNCbGJtUmZZMkZ3WDNScFpYSTlkR2xsY2l3S0lDQWdJQzh2SUNBZ0lDQnZjR1Z5WVhSdmNsOXdkV0pyWlhrOWNHOXNhV041TG05d1pYSmhkRzl5WDNCMVltdGxlUW9nSUNBZ0x5OGdLUW9nSUNBZ2MzZGhjQW9nSUNBZ2FYUnZZZ29nSUNBZ1pHbG5JRFFLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURNS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TURBeFlRb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeHBZM2xmZG1GMWJIUXZZMjl1ZEhKaFkzUXVjSGs2TmpJS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnYVc1MFkxOHpJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tkR2xqYTE5dGFYTnpaV1JmY21WdVpYZGhiRjlsYkhObFgySnZaSGxBTXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4cFkzbGZkbUYxYkhRdlkyOXVkSEpoWTNRdWNIazZOeklLSUNBZ0lDOHZJR1ZzYVdZZ2JXbHpjMlZrSUQwOUlGVkpiblEyTkNneUtUb0tJQ0FnSUdScFp5QXhDaUFnSUNCcGJuUmpYekFnTHk4Z01nb2dJQ0FnUFQwS0lDQWdJR0o2SUhScFkydGZiV2x6YzJWa1gzSmxibVYzWVd4ZlpXeHpaVjlpYjJSNVFEVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeHBZM2xmZG1GMWJIUXZZMjl1ZEhKaFkzUXVjSGs2TnpNS0lDQWdJQzh2SUhScFpYSWdQU0JWU1c1ME5qUW9NaWtLSUNBZ0lHbHVkR05mTUNBdkx5QXlDaUFnSUNCaWRYSjVJREVLSUNBZ0lHSWdkR2xqYTE5dGFYTnpaV1JmY21WdVpYZGhiRjloWm5SbGNsOXBabDlsYkhObFFEa0tDblJwWTJ0ZmJXbHpjMlZrWDNKbGJtVjNZV3hmWld4elpWOWliMlI1UURVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2FXTjVYM1poZFd4MEwyTnZiblJ5WVdOMExuQjVPamMwQ2lBZ0lDQXZMeUJsYkdsbUlHMXBjM05sWkNBK1BTQlZTVzUwTmpRb015azZDaUFnSUNCa2FXY2dNUW9nSUNBZ2NIVnphR2x1ZENBekNpQWdJQ0ErUFFvZ0lDQWdZbm9nZEdsamExOXRhWE56WldSZmNtVnVaWGRoYkY5aFpuUmxjbDlwWmw5bGJITmxRRGtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMnhwWTNsZmRtRjFiSFF2WTI5dWRISmhZM1F1Y0hrNk56VUtJQ0FnSUM4dklIUnBaWElnUFNCVlNXNTBOalFvTXlrS0lDQWdJSEIxYzJocGJuUWdNd29nSUNBZ1luVnllU0F4Q2lBZ0lDQmlJSFJwWTJ0ZmJXbHpjMlZrWDNKbGJtVjNZV3hmWVdaMFpYSmZhV1pmWld4elpVQTVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG5CdmJHbGplVjkyWVhWc2RDNWpiMjUwY21GamRDNVFiMnhwWTNsV1lYVnNkQzVuWlhSZmNHOXNhV041WDNOMFlYUjFjMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21kbGRGOXdiMnhwWTNsZmMzUmhkSFZ6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkdsamVWOTJZWFZzZEM5amIyNTBjbUZqZEM1d2VUbzROQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNhV041WDNaaGRXeDBMMk52Ym5SeVlXTjBMbkI1T2pnMkxUZzNDaUFnSUNBdkx5QWpJRkpsZEhWeWJuTWdZM1Z5Y21WdWRDQjBhV1Z5SUdadmNpQjBhR2x6SUdGblpXNTBMZ29nSUNBZ0x5OGdjRzlzYVdONUlEMGdjMlZzWmk1d2IyeHBZMmxsYzF0aFoyVnVkRjB1WTI5d2VTZ3BDaUFnSUNCaWVYUmxZMTh3SUM4dklDSndiMnhwWTJsbGN5SUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNhV041WDNaaGRXeDBMMk52Ym5SeVlXTjBMbkI1T2pnNUNpQWdJQ0F2THlCcFppQkhiRzlpWVd3dWNtOTFibVFnUGowZ2NHOXNhV041TG1WNGNHbHllVjl5YjNWdVpEb0tJQ0FnSUdkc2IySmhiQ0JTYjNWdVpBb2dJQ0FnYzNkaGNBb2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJR2x1ZEdOZk1TQXZMeUE0Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQ0F2THlCdmJpQmxjbkp2Y2pvZ2FXNWtaWGdnYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnWW5SdmFRb2dJQ0FnUGowS0lDQWdJR0o2SUdkbGRGOXdiMnhwWTNsZmMzUmhkSFZ6WDJGbWRHVnlYMmxtWDJWc2MyVkFNd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiR2xqZVY5MllYVnNkQzlqYjI1MGNtRmpkQzV3ZVRvNU1Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUZWSmJuUTJOQ2d6S1FvZ0lDQWdjSFZ6YUdsdWRDQXpDZ3BuWlhSZmNHOXNhV041WDNOMFlYUjFjMTloWm5SbGNsOXBibXhwYm1Wa1gzTnRZWEowWDJOdmJuUnlZV04wY3k1d2IyeHBZM2xmZG1GMWJIUXVZMjl1ZEhKaFkzUXVVRzlzYVdONVZtRjFiSFF1WjJWMFgzQnZiR2xqZVY5emRHRjBkWE5BTkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4cFkzbGZkbUYxYkhRdlkyOXVkSEpoWTNRdWNIazZPRFFLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eklDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS1oyVjBYM0J2YkdsamVWOXpkR0YwZFhOZllXWjBaWEpmYVdaZlpXeHpaVUF6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkdsamVWOTJZWFZzZEM5amIyNTBjbUZqZEM1d2VUbzVNZ29nSUNBZ0x5OGdjbVYwZFhKdUlIQnZiR2xqZVM1emNHVnVaRjlqWVhCZmRHbGxjZ29nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURFMkNpQWdJQ0JwYm5Salh6RWdMeThnT0FvZ0lDQWdZbTk0WDJWNGRISmhZM1FnTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeHBZM2xmZG1GMWJIUXZZMjl1ZEhKaFkzUXVjSGs2T0RRS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnWWlCblpYUmZjRzlzYVdONVgzTjBZWFIxYzE5aFpuUmxjbDlwYm14cGJtVmtYM050WVhKMFgyTnZiblJ5WVdOMGN5NXdiMnhwWTNsZmRtRjFiSFF1WTI5dWRISmhZM1F1VUc5c2FXTjVWbUYxYkhRdVoyVjBYM0J2YkdsamVWOXpkR0YwZFhOQU5Bbz0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQWdnQUFTWURDSEJ2YkdsamFXVnpBZ0FhQkJVZmZIVXhHMEVBTWpFWkZFUXhHRVNDQlFTblBWODhCSlZ5cmJzRXdZeHJNZ1Q1bjNhV0JMMjNXZXMyR2dDT0JRQUpBRmdBekFFd0FhUUFNUmtVTVJnVUVFTTJHZ0ZKRllFZ0VrUTJHZ0pKRlNNU1JCYzJHZ05KSkZraUNFc0JGUkpFVndJQVNSVkpnU0FTUkRJR1R3TUlGaVFXVEVzQlVFeFFUQlpYQmdKUEFsQk1LVkJNVUNoUEFsQkp2RWhNdnlWRE5ob0JTUldCSUJKRU5ob0NTU1JaSWdoTEFSVVNSRmNDQURZYUEwa2tXU0lJU3dFVkVrUlhBZ0EyR2dSSkZTTVNSQmNvVHdSUVNZRWFJcm9YSWdoTEFZRWFUd0s2VndJQVR3UlBCRXNDQkVReUJrOERDQllrRmt4TEFWQk1VRXNCRlJaWEJnSlBBbEJNS1ZCTVVFc0J2RWkvSlVPQUFEWWFBVWtWZ1NBU1JEWWFBa2tWSXhKRUYwd29URkJKTWdaTUpDTzZGdzlCQUFtQkF4WXFURkN3SlVOSmdSQWp1aGRKUlFRbEVrRUFEVXNCZ2NDRVBRNUVTd0pDLzk1TEFpSVNRUUFMU3dHQm9JMEdEa1JDLytsTEFvRUREeFJFUXYvZk5ob0JTUldCSUJKRUtFeFFTU05KdWhjbENFa2tUQ1VTUVFBOUpVVUJTd0pKSkNPNkYwc0JnUm9pdWhjaUNFc0NnUnBQQXJwWEFnQk1Ga3NFRmxCTEF4WlFTd0VWRmxjR0FrOENVRXdwVUV4UVN3RzhTTDhsUTBzQkloSkJBQVlpUlFGQy83bExBWUVERDBIL3NZRURSUUZDLzZvMkdnRkpGWUVnRWtRb1RGQkpNZ1pNSkNPNkZ3OUJBQW1CQXhZcVRGQ3dKVU5KZ1JBanVoZEMvL0E9IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OCwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
