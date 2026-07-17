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

namespace Arc56.Generated.VihaShomikha.Kizuna.SolverRegistry_9cf7c9ed
{


    //
    // Manages the decentralized solver network — registration, staking, reputation, and slashing.
    //
    public class SolverRegistryProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public SolverRegistryProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class SolverProfile : AVMObjectType
            {
                public Algorand.Address Wallet { get; set; }

                public ulong StakeAmount { get; set; }

                public ulong TotalSettled { get; set; }

                public ulong TotalDisputes { get; set; }

                public ulong ReputationScore { get; set; }

                public bool IsOnline { get; set; }

                public ulong RegisteredAt { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWallet = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vWallet.From(Wallet);
                    ret.AddRange(vWallet.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStakeAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vStakeAmount.From(StakeAmount);
                    ret.AddRange(vStakeAmount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalSettled = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalSettled.From(TotalSettled);
                    ret.AddRange(vTotalSettled.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalDisputes = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalDisputes.From(TotalDisputes);
                    ret.AddRange(vTotalDisputes.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReputationScore = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vReputationScore.From(ReputationScore);
                    ret.AddRange(vReputationScore.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIsOnline = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vIsOnline.From(IsOnline);
                    ret.AddRange(vIsOnline.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRegisteredAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vRegisteredAt.From(RegisteredAt);
                    ret.AddRange(vRegisteredAt.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static SolverProfile Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new SolverProfile();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWallet = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vWallet.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueWallet = vWallet.ToValue();
                    if (valueWallet is Algorand.Address vWalletValue) { ret.Wallet = vWalletValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStakeAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vStakeAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueStakeAmount = vStakeAmount.ToValue();
                    if (valueStakeAmount is ulong vStakeAmountValue) { ret.StakeAmount = vStakeAmountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalSettled = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalSettled.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalSettled = vTotalSettled.ToValue();
                    if (valueTotalSettled is ulong vTotalSettledValue) { ret.TotalSettled = vTotalSettledValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalDisputes = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalDisputes.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalDisputes = vTotalDisputes.ToValue();
                    if (valueTotalDisputes is ulong vTotalDisputesValue) { ret.TotalDisputes = vTotalDisputesValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReputationScore = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vReputationScore.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueReputationScore = vReputationScore.ToValue();
                    if (valueReputationScore is ulong vReputationScoreValue) { ret.ReputationScore = vReputationScoreValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIsOnline = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vIsOnline.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueIsOnline = vIsOnline.ToValue();
                    if (valueIsOnline is bool vIsOnlineValue) { ret.IsOnline = vIsOnlineValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRegisteredAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vRegisteredAt.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRegisteredAt = vRegisteredAt.ToValue();
                    if (valueRegisteredAt is ulong vRegisteredAtValue) { ret.RegisteredAt = vRegisteredAtValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as SolverProfile);
                }
                public bool Equals(SolverProfile? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(SolverProfile left, SolverProfile right)
                {
                    return EqualityComparer<SolverProfile>.Default.Equals(left, right);
                }
                public static bool operator !=(SolverProfile left, SolverProfile right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="min_stake"> </param>
        public async Task Create(ulong min_stake, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 13, 47, 103 };
            var min_stakeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); min_stakeAbi.From(min_stake);

            var result = await base.CallApp(new List<object> { abiHandle, min_stakeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(ulong min_stake, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 13, 47, 103 };
            var min_stakeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); min_stakeAbi.From(min_stake);

            return await base.MakeTransactionList(new List<object> { abiHandle, min_stakeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="min_stake"> </param>
        public async Task SetMinStake(ulong min_stake, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 247, 198, 212, 188 };
            var min_stakeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); min_stakeAbi.From(min_stake);

            var result = await base.CallApp(new List<object> { abiHandle, min_stakeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetMinStake_Transactions(ulong min_stake, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 247, 198, 212, 188 };
            var min_stakeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); min_stakeAbi.From(min_stake);

            return await base.MakeTransactionList(new List<object> { abiHandle, min_stakeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Register as a solver by staking ALGO.
        ///</summary>
        /// <param name="mbr_pay"> </param>
        /// <param name="stake_pay"> </param>
        public async Task RegisterSolver(PaymentTransaction mbr_pay, PaymentTransaction stake_pay, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbr_pay, stake_pay });
            byte[] abiHandle = { 205, 96, 43, 38 };

            var result = await base.CallApp(new List<object> { abiHandle, mbr_pay, stake_pay }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RegisterSolver_Transactions(PaymentTransaction mbr_pay, PaymentTransaction stake_pay, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbr_pay, stake_pay });
            byte[] abiHandle = { 205, 96, 43, 38 };

            return await base.MakeTransactionList(new List<object> { abiHandle, mbr_pay, stake_pay }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Withdraw stake and deregister. Solver must have no active disputes.
        ///</summary>
        public async Task DeregisterSolver(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 125, 12, 248, 169 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DeregisterSolver_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 125, 12, 248, 169 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="is_online"> </param>
        public async Task UpdateAvailability(bool is_online, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 247, 210, 187, 142 };
            var is_onlineAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); is_onlineAbi.From(is_online);

            var result = await base.CallApp(new List<object> { abiHandle, is_onlineAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateAvailability_Transactions(bool is_online, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 247, 210, 187, 142 };
            var is_onlineAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); is_onlineAbi.From(is_online);

            return await base.MakeTransactionList(new List<object> { abiHandle, is_onlineAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Record a successful settlement for a solver. Admin only.
        ///</summary>
        /// <param name="solver"> </param>
        public async Task RecordSettlement(Algorand.Address solver, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 175, 229, 108, 146 };
            var solverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); solverAbi.From(solver);

            var result = await base.CallApp(new List<object> { abiHandle, solverAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RecordSettlement_Transactions(Algorand.Address solver, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 175, 229, 108, 146 };
            var solverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); solverAbi.From(solver);

            return await base.MakeTransactionList(new List<object> { abiHandle, solverAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Record a dispute against a solver. Admin only.
        ///</summary>
        /// <param name="solver"> </param>
        public async Task RecordDispute(Algorand.Address solver, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 131, 172, 28, 128 };
            var solverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); solverAbi.From(solver);

            var result = await base.CallApp(new List<object> { abiHandle, solverAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RecordDispute_Transactions(Algorand.Address solver, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 131, 172, 28, 128 };
            var solverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); solverAbi.From(solver);

            return await base.MakeTransactionList(new List<object> { abiHandle, solverAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Slash a solver's stake. Admin only. Slashed funds go to admin.
        ///</summary>
        /// <param name="solver"> </param>
        /// <param name="amount"> </param>
        public async Task SlashSolver(Algorand.Address solver, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 84, 78, 76, 123 };
            var solverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); solverAbi.From(solver);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, solverAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SlashSolver_Transactions(Algorand.Address solver, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 84, 78, 76, 123 };
            var solverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); solverAbi.From(solver);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, solverAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="solver"> </param>
        public async Task<Structs.SolverProfile> GetSolver(Algorand.Address solver, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 252, 19, 4, 30 };
            var solverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); solverAbi.From(solver);

            var result = await base.SimApp(new List<object> { abiHandle, solverAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.SolverProfile.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetSolver_Transactions(Algorand.Address solver, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 252, 19, 4, 30 };
            var solverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); solverAbi.From(solver);

            return await base.MakeTransactionList(new List<object> { abiHandle, solverAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="solver"> </param>
        public async Task<bool> IsSolverRegistered(Algorand.Address solver, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 65, 37, 143, 171 };
            var solverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); solverAbi.From(solver);

            var result = await base.SimApp(new List<object> { abiHandle, solverAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsSolverRegistered_Transactions(Algorand.Address solver, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 65, 37, 143, 171 };
            var solverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); solverAbi.From(solver);

            return await base.MakeTransactionList(new List<object> { abiHandle, solverAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="solver"> </param>
        public async Task<ulong> GetReputation(Algorand.Address solver, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 178, 55, 89, 214 };
            var solverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); solverAbi.From(solver);

            var result = await base.SimApp(new List<object> { abiHandle, solverAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetReputation_Transactions(Algorand.Address solver, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 178, 55, 89, 214 };
            var solverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); solverAbi.From(solver);

            return await base.MakeTransactionList(new List<object> { abiHandle, solverAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU29sdmVyUmVnaXN0cnkiLCJkZXNjIjoiTWFuYWdlcyB0aGUgZGVjZW50cmFsaXplZCBzb2x2ZXIgbmV0d29yayDigJQgcmVnaXN0cmF0aW9uLCBzdGFraW5nLCByZXB1dGF0aW9uLCBhbmQgc2xhc2hpbmcuIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IlNvbHZlclByb2ZpbGUiOlt7Im5hbWUiOiJ3YWxsZXQiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6InN0YWtlX2Ftb3VudCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ0b3RhbF9zZXR0bGVkIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InRvdGFsX2Rpc3B1dGVzIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InJlcHV0YXRpb25fc2NvcmUiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiaXNfb25saW5lIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJyZWdpc3RlcmVkX2F0IiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWluX3N0YWtlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldF9taW5fc3Rha2UiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWluX3N0YWtlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlZ2lzdGVyX3NvbHZlciIsImRlc2MiOiJSZWdpc3RlciBhcyBhIHNvbHZlciBieSBzdGFraW5nIEFMR08uIiwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1icl9wYXkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InN0YWtlX3BheSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJkZXJlZ2lzdGVyX3NvbHZlciIsImRlc2MiOiJXaXRoZHJhdyBzdGFrZSBhbmQgZGVyZWdpc3Rlci4gU29sdmVyIG11c3QgaGF2ZSBubyBhY3RpdmUgZGlzcHV0ZXMuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InVwZGF0ZV9hdmFpbGFiaWxpdHkiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImlzX29ubGluZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWNvcmRfc2V0dGxlbWVudCIsImRlc2MiOiJSZWNvcmQgYSBzdWNjZXNzZnVsIHNldHRsZW1lbnQgZm9yIGEgc29sdmVyLiBBZG1pbiBvbmx5LiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoic29sdmVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlY29yZF9kaXNwdXRlIiwiZGVzYyI6IlJlY29yZCBhIGRpc3B1dGUgYWdhaW5zdCBhIHNvbHZlci4gQWRtaW4gb25seS4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNvbHZlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzbGFzaF9zb2x2ZXIiLCJkZXNjIjoiU2xhc2ggYSBzb2x2ZXIncyBzdGFrZS4gQWRtaW4gb25seS4gU2xhc2hlZCBmdW5kcyBnbyB0byBhZG1pbi4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNvbHZlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9zb2x2ZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNvbHZlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIoYWRkcmVzcyx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsYm9vbCx1aW50NjQpIiwic3RydWN0IjoiU29sdmVyUHJvZmlsZSIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaXNfc29sdmVyX3JlZ2lzdGVyZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNvbHZlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9yZXB1dGF0aW9uIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzb2x2ZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoyLCJieXRlcyI6MX0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMjM4XSwiZXJyb3JNZXNzYWdlIjoiQWxyZWFkeSByZWdpc3RlcmVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjQ1XSwiZXJyb3JNZXNzYWdlIjoiTUJSIHBheSB0byBhcHAiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMjcsMzg4XSwiZXJyb3JNZXNzYWdlIjoiTm90IHJlZ2lzdGVyZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDMsNDY2LDU3Nyw3MDJdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGFkbWluIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDc0LDU4Niw3MTRdLCJlcnJvck1lc3NhZ2UiOiJTb2x2ZXIgbm90IHJlZ2lzdGVyZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNTJdLCJlcnJvck1lc3NhZ2UiOiJTdGFrZSBwYXkgdG8gYXBwIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjYyXSwiZXJyb3JNZXNzYWdlIjoiU3Rha2UgdG9vIGxvdyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIwMSw0NjQsNTc1LDcwMCw3MzldLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmFkbWluIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI1OF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYubWluX3N0YWtlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMzMywzOTQsODMzLDg4OF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuc29sdmVycyBlbnRyeSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMTIsMzY1XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi50b3RhbF9zb2x2ZXJzIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM4MF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmJvb2wiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NTgsNTY5LDY4NSw4MjgsODQ4LDg3NV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNzYsMTk0LDY5M10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIxOSwyMjldLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIHBheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXhJREFnTXpJZ09DQTFNVElLSUNBZ0lHSjVkR1ZqWW14dlkyc2dNSGczTXpaak56WTFaaUFpWVdSdGFXNGlJQ0owYjNSaGJGOXpiMngyWlhKeklpQWliV2x1WDNOMFlXdGxJaUF3ZURBd0lEQjRNVFV4Wmpkak56VUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmlibm9nYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJ4MlpYSmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TXpBS0lDQWdJQzh2SUhObGJHWXViV2x1WDNOMFlXdGxJRDBnVlVsdWREWTBLREV3WHpBd01GOHdNREFwQ2lBZ0lDQmllWFJsWTE4eklDOHZJQ0p0YVc1ZmMzUmhhMlVpQ2lBZ0lDQndkWE5vYVc1MElERXdNREF3TURBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdmJIWmxjbDl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRvek1Rb2dJQ0FnTHk4Z2MyVnNaaTUwYjNSaGJGOXpiMngyWlhKeklEMGdWVWx1ZERZMEtEQXBDaUFnSUNCaWVYUmxZMTh5SUM4dklDSjBiM1JoYkY5emIyeDJaWEp6SWdvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2dwdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyeDJaWEpmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk1qVUtJQ0FnSUM4dklHTnNZWE56SUZOdmJIWmxjbEpsWjJsemRISjVLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmllaUJ0WVdsdVgyTnlaV0YwWlY5T2IwOXdRREUyQ2lBZ0lDQndkWE5vWW5sMFpYTnpJREI0Wmpkak5tUTBZbU1nTUhoalpEWXdNbUl5TmlBd2VEZGtNR05tT0dFNUlEQjRaamRrTW1KaU9HVWdNSGhoWm1VMU5tTTVNaUF3ZURnellXTXhZemd3SURCNE5UUTBaVFJqTjJJZ01IaG1ZekV6TURReFpTQXdlRFF4TWpVNFptRmlJREI0WWpJek56VTVaRFlnTHk4Z2JXVjBhRzlrSUNKelpYUmZiV2x1WDNOMFlXdGxLSFZwYm5RMk5DbDJiMmxrSWl3Z2JXVjBhRzlrSUNKeVpXZHBjM1JsY2w5emIyeDJaWElvY0dGNUxIQmhlU2wyYjJsa0lpd2diV1YwYUc5a0lDSmtaWEpsWjJsemRHVnlYM052YkhabGNpZ3BkbTlwWkNJc0lHMWxkR2h2WkNBaWRYQmtZWFJsWDJGMllXbHNZV0pwYkdsMGVTaGliMjlzS1hadmFXUWlMQ0J0WlhSb2IyUWdJbkpsWTI5eVpGOXpaWFIwYkdWdFpXNTBLR0ZrWkhKbGMzTXBkbTlwWkNJc0lHMWxkR2h2WkNBaWNtVmpiM0prWDJScGMzQjFkR1VvWVdSa2NtVnpjeWwyYjJsa0lpd2diV1YwYUc5a0lDSnpiR0Z6YUY5emIyeDJaWElvWVdSa2NtVnpjeXgxYVc1ME5qUXBkbTlwWkNJc0lHMWxkR2h2WkNBaVoyVjBYM052YkhabGNpaGhaR1J5WlhOektTaGhaR1J5WlhOekxIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeGliMjlzTEhWcGJuUTJOQ2tpTENCdFpYUm9iMlFnSW1selgzTnZiSFpsY2w5eVpXZHBjM1JsY21Wa0tHRmtaSEpsYzNNcFltOXZiQ0lzSUcxbGRHaHZaQ0FpWjJWMFgzSmxjSFYwWVhScGIyNG9ZV1JrY21WemN5bDFhVzUwTmpRaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQnpaWFJmYldsdVgzTjBZV3RsSUhKbFoybHpkR1Z5WDNOdmJIWmxjaUJrWlhKbFoybHpkR1Z5WDNOdmJIWmxjaUIxY0dSaGRHVmZZWFpoYVd4aFltbHNhWFI1SUhKbFkyOXlaRjl6WlhSMGJHVnRaVzUwSUhKbFkyOXlaRjlrYVhOd2RYUmxJSE5zWVhOb1gzTnZiSFpsY2lCblpYUmZjMjlzZG1WeUlHbHpYM052YkhabGNsOXlaV2RwYzNSbGNtVmtJR2RsZEY5eVpYQjFkR0YwYVc5dUNpQWdJQ0JsY25JS0NtMWhhVzVmWTNKbFlYUmxYMDV2VDNCQU1UWTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOXNkbVZ5WDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qSTFDaUFnSUNBdkx5QmpiR0Z6Y3lCVGIyeDJaWEpTWldkcGMzUnllU2hCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1qUXdaREptTmpjZ0x5OGdiV1YwYUc5a0lDSmpjbVZoZEdVb2RXbHVkRFkwS1hadmFXUWlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0JqY21WaGRHVUtJQ0FnSUdWeWNnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTV6YjJ4MlpYSmZjbVZuYVhOMGNua3VZMjl1ZEhKaFkzUXVVMjlzZG1WeVVtVm5hWE4wY25rdVkzSmxZWFJsVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1kzSmxZWFJsT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052YkhabGNsOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG96TkFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLR055WldGMFpUMGljbVZ4ZFdseVpTSXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlzZG1WeVgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPak0yQ2lBZ0lDQXZMeUJ6Wld4bUxtRmtiV2x1TG5aaGJIVmxJRDBnVkhodUxuTmxibVJsY2dvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWVdSdGFXNGlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdmJIWmxjbDl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRvek53b2dJQ0FnTHk4Z2MyVnNaaTV0YVc1ZmMzUmhhMlVnUFNCdGFXNWZjM1JoYTJVS0lDQWdJR0o1ZEdWalh6TWdMeThnSW0xcGJsOXpkR0ZyWlNJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5c2RtVnlYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pNMENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvWTNKbFlYUmxQU0p5WlhGMWFYSmxJaWtLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWMyOXNkbVZ5WDNKbFoybHpkSEo1TG1OdmJuUnlZV04wTGxOdmJIWmxjbEpsWjJsemRISjVMbk5sZEY5dGFXNWZjM1JoYTJWYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHpaWFJmYldsdVgzTjBZV3RsT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052YkhabGNsOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG96T1FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJ4MlpYSmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TkRFS0lDQWdJQzh2SUdGemMyVnlkQ0JVZUc0dWMyVnVaR1Z5SUQwOUlITmxiR1l1WVdSdGFXNHVkbUZzZFdVc0lDSlBibXg1SUdGa2JXbHVJZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1Ga2JXbHVJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1Ga2JXbHVJR1Y0YVhOMGN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYm14NUlHRmtiV2x1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlzZG1WeVgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPalF5Q2lBZ0lDQXZMeUJ6Wld4bUxtMXBibDl6ZEdGclpTQTlJRzFwYmw5emRHRnJaUW9nSUNBZ1lubDBaV05mTXlBdkx5QWliV2x1WDNOMFlXdGxJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMngyWlhKZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZNemtLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG5OdmJIWmxjbDl5WldkcGMzUnllUzVqYjI1MGNtRmpkQzVUYjJ4MlpYSlNaV2RwYzNSeWVTNXlaV2RwYzNSbGNsOXpiMngyWlhKYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHlaV2RwYzNSbGNsOXpiMngyWlhJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5c2RtVnlYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pRMENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJSEIxYzJocGJuUWdNZ29nSUNBZ0xRb2dJQ0FnWkhWd0NpQWdJQ0JuZEhodWN5QlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SUhCaGVRb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUIwY21GdWMyRmpkR2x2YmlCMGVYQmxJR2x6SUhCaGVRb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0F0Q2lBZ0lDQmtkWEFLSUNBZ0lHZDBlRzV6SUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdjR0Y1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklIUnlZVzV6WVdOMGFXOXVJSFI1Y0dVZ2FYTWdjR0Y1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlzZG1WeVgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPalV4Q2lBZ0lDQXZMeUJoYzNObGNuUWdWSGh1TG5ObGJtUmxjaUJ1YjNRZ2FXNGdjMlZzWmk1emIyeDJaWEp6TENBaVFXeHlaV0ZrZVNCeVpXZHBjM1JsY21Wa0lnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEY3pObU0zTmpWbUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUVGc2NtVmhaSGtnY21WbmFYTjBaWEpsWkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052YkhabGNsOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG8xTWdvZ0lDQWdMeThnWVhOelpYSjBJRzFpY2w5d1lYa3VjbVZqWldsMlpYSWdQVDBnUjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjeXdnSWsxQ1VpQndZWGtnZEc4Z1lYQndJZ29nSUNBZ2MzZGhjQW9nSUNBZ1ozUjRibk1nVW1WalpXbDJaWElLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFMUNVaUJ3WVhrZ2RHOGdZWEJ3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlzZG1WeVgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPalV6Q2lBZ0lDQXZMeUJoYzNObGNuUWdjM1JoYTJWZmNHRjVMbkpsWTJWcGRtVnlJRDA5SUVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01zSUNKVGRHRnJaU0J3WVhrZ2RHOGdZWEJ3SWdvZ0lDQWdaSFZ3Q2lBZ0lDQm5kSGh1Y3lCU1pXTmxhWFpsY2dvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdVM1JoYTJVZ2NHRjVJSFJ2SUdGd2NBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdmJIWmxjbDl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRvMU5Bb2dJQ0FnTHk4Z1lYTnpaWEowSUhOMFlXdGxYM0JoZVM1aGJXOTFiblFnUGowZ2MyVnNaaTV0YVc1ZmMzUmhhMlVzSUNKVGRHRnJaU0IwYjI4Z2JHOTNJZ29nSUNBZ1ozUjRibk1nUVcxdmRXNTBDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNeUF2THlBaWJXbHVYM04wWVd0bElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbTFwYmw5emRHRnJaU0JsZUdsemRITUtJQ0FnSUdScFp5QXhDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUZOMFlXdGxJSFJ2YnlCc2IzY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyeDJaWEpmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk5UY0tJQ0FnSUM4dklIZGhiR3hsZEQxaGNtTTBMa0ZrWkhKbGMzTW9WSGh1TG5ObGJtUmxjaWtzQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOXNkbVZ5WDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qVTRDaUFnSUNBdkx5QnpkR0ZyWlY5aGJXOTFiblE5WVhKak5DNVZTVzUwTmpRb2MzUmhhMlZmY0dGNUxtRnRiM1Z1ZENrc0NpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5c2RtVnlYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pZekNpQWdJQ0F2THlCeVpXZHBjM1JsY21Wa1gyRjBQV0Z5WXpRdVZVbHVkRFkwS0Vkc2IySmhiQzVzWVhSbGMzUmZkR2x0WlhOMFlXMXdLU3dLSUNBZ0lHZHNiMkpoYkNCTVlYUmxjM1JVYVcxbGMzUmhiWEFLSUNBZ0lHbDBiMklLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMngyWlhKZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZOVFl0TmpRS0lDQWdJQzh2SUhObGJHWXVjMjlzZG1WeWMxdFVlRzR1YzJWdVpHVnlYU0E5SUZOdmJIWmxjbEJ5YjJacGJHVW9DaUFnSUNBdkx5QWdJQ0FnZDJGc2JHVjBQV0Z5WXpRdVFXUmtjbVZ6Y3loVWVHNHVjMlZ1WkdWeUtTd0tJQ0FnSUM4dklDQWdJQ0J6ZEdGclpWOWhiVzkxYm5ROVlYSmpOQzVWU1c1ME5qUW9jM1JoYTJWZmNHRjVMbUZ0YjNWdWRDa3NDaUFnSUNBdkx5QWdJQ0FnZEc5MFlXeGZjMlYwZEd4bFpEMWhjbU0wTGxWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNBZ0lDQjBiM1JoYkY5a2FYTndkWFJsY3oxaGNtTTBMbFZKYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ0FnSUNCeVpYQjFkR0YwYVc5dVgzTmpiM0psUFdGeVl6UXVWVWx1ZERZMEtERXdNQ2tzQ2lBZ0lDQXZMeUFnSUNBZ2FYTmZiMjVzYVc1bFBXRnlZelF1UW05dmJDaEdZV3h6WlNrc0NpQWdJQ0F2THlBZ0lDQWdjbVZuYVhOMFpYSmxaRjloZEQxaGNtTTBMbFZKYm5RMk5DaEhiRzlpWVd3dWJHRjBaWE4wWDNScGJXVnpkR0Z0Y0Nrc0NpQWdJQ0F2THlBcENpQWdJQ0JqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREEyTkRBd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZiSFpsY2w5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUbzFOZ29nSUNBZ0x5OGdjMlZzWmk1emIyeDJaWEp6VzFSNGJpNXpaVzVrWlhKZElEMGdVMjlzZG1WeVVISnZabWxzWlNnS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnM016WmpOelkxWmdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlzZG1WeVgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPalUyTFRZMENpQWdJQ0F2THlCelpXeG1Mbk52YkhabGNuTmJWSGh1TG5ObGJtUmxjbDBnUFNCVGIyeDJaWEpRY205bWFXeGxLQW9nSUNBZ0x5OGdJQ0FnSUhkaGJHeGxkRDFoY21NMExrRmtaSEpsYzNNb1ZIaHVMbk5sYm1SbGNpa3NDaUFnSUNBdkx5QWdJQ0FnYzNSaGEyVmZZVzF2ZFc1MFBXRnlZelF1VlVsdWREWTBLSE4wWVd0bFgzQmhlUzVoYlc5MWJuUXBMQW9nSUNBZ0x5OGdJQ0FnSUhSdmRHRnNYM05sZEhSc1pXUTlZWEpqTkM1VlNXNTBOalFvTUNrc0NpQWdJQ0F2THlBZ0lDQWdkRzkwWVd4ZlpHbHpjSFYwWlhNOVlYSmpOQzVWU1c1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFnSUNBZ2NtVndkWFJoZEdsdmJsOXpZMjl5WlQxaGNtTTBMbFZKYm5RMk5DZ3hNREFwTEFvZ0lDQWdMeThnSUNBZ0lHbHpYMjl1YkdsdVpUMWhjbU0wTGtKdmIyd29SbUZzYzJVcExBb2dJQ0FnTHk4Z0lDQWdJSEpsWjJsemRHVnlaV1JmWVhROVlYSmpOQzVWU1c1ME5qUW9SMnh2WW1Gc0xteGhkR1Z6ZEY5MGFXMWxjM1JoYlhBcExBb2dJQ0FnTHk4Z0tRb2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZiSFpsY2w5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUbzJOUW9nSUNBZ0x5OGdjMlZzWmk1MGIzUmhiRjl6YjJ4MlpYSnpJQ3M5SURFS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0owYjNSaGJGOXpiMngyWlhKeklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MblJ2ZEdGc1gzTnZiSFpsY25NZ1pYaHBjM1J6Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnWW5sMFpXTmZNaUF2THlBaWRHOTBZV3hmYzI5c2RtVnljeUlLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlzZG1WeVgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPalEwQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1emIyeDJaWEpmY21WbmFYTjBjbmt1WTI5dWRISmhZM1F1VTI5c2RtVnlVbVZuYVhOMGNua3VaR1Z5WldkcGMzUmxjbDl6YjJ4MlpYSmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BrWlhKbFoybHpkR1Z5WDNOdmJIWmxjam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMngyWlhKZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZOekFLSUNBZ0lDOHZJR0Z6YzJWeWRDQlVlRzR1YzJWdVpHVnlJR2x1SUhObGJHWXVjMjlzZG1WeWN5d2dJazV2ZENCeVpXZHBjM1JsY21Wa0lnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEY3pObU0zTmpWbUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lYTnpaWEowSUM4dklFNXZkQ0J5WldkcGMzUmxjbVZrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlzZG1WeVgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPamN4Q2lBZ0lDQXZMeUJ3Y205bWFXeGxJRDBnYzJWc1ppNXpiMngyWlhKelcxUjRiaTV6Wlc1a1pYSmRMbU52Y0hrb0tRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEY3pObU0zTmpWbUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuTnZiSFpsY25NZ1pXNTBjbmtnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOXNkbVZ5WDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qY3pDaUFnSUNBdkx5QnpkR0ZyWlNBOUlIQnliMlpwYkdVdWMzUmhhMlZmWVcxdmRXNTBMbTVoZEdsMlpRb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnWkhWd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5c2RtVnlYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pjMENpQWdJQ0F2THlCcFppQnpkR0ZyWlNBK0lGVkpiblEyTkNnd0tUb0tJQ0FnSUdKNklHUmxjbVZuYVhOMFpYSmZjMjlzZG1WeVgyRm1kR1Z5WDJsbVgyVnNjMlZBTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052YkhabGNsOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG8zTlMwM09Rb2dJQ0FnTHk4Z2FYUjRiaTVRWVhsdFpXNTBLQW9nSUNBZ0x5OGdJQ0FnSUhKbFkyVnBkbVZ5UFZSNGJpNXpaVzVrWlhJc0NpQWdJQ0F2THlBZ0lDQWdZVzF2ZFc1MFBYTjBZV3RsTEFvZ0lDQWdMeThnSUNBZ0lHWmxaVDB3TEFvZ0lDQWdMeThnS1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZiSFpsY2w5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUbzNOZ29nSUNBZ0x5OGdjbVZqWldsMlpYSTlWSGh1TG5ObGJtUmxjaXdLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdScFp5QXhDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnRiM1Z1ZEFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JTWldObGFYWmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZiSFpsY2w5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUbzNOUW9nSUNBZ0x5OGdhWFI0Ymk1UVlYbHRaVzUwS0FvZ0lDQWdhVzUwWTE4d0lDOHZJSEJoZVFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZiSFpsY2w5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUbzNPQW9nSUNBZ0x5OGdabVZsUFRBc0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJ4MlpYSmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TnpVdE56a0tJQ0FnSUM4dklHbDBlRzR1VUdGNWJXVnVkQ2dLSUNBZ0lDOHZJQ0FnSUNCeVpXTmxhWFpsY2oxVWVHNHVjMlZ1WkdWeUxBb2dJQ0FnTHk4Z0lDQWdJR0Z0YjNWdWREMXpkR0ZyWlN3S0lDQWdJQzh2SUNBZ0lDQm1aV1U5TUN3S0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2dwa1pYSmxaMmx6ZEdWeVgzTnZiSFpsY2w5aFpuUmxjbDlwWmw5bGJITmxRRFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlzZG1WeVgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPamd4Q2lBZ0lDQXZMeUJrWld3Z2MyVnNaaTV6YjJ4MlpYSnpXMVI0Ymk1elpXNWtaWEpkQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TnpNMll6YzJOV1lLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlzZG1WeVgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPamd5Q2lBZ0lDQXZMeUJ6Wld4bUxuUnZkR0ZzWDNOdmJIWmxjbk1nTFQwZ01Rb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0o1ZEdWalh6SWdMeThnSW5SdmRHRnNYM052YkhabGNuTWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1ZEc5MFlXeGZjMjlzZG1WeWN5QmxlR2x6ZEhNS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCaWVYUmxZMTh5SUM4dklDSjBiM1JoYkY5emIyeDJaWEp6SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJ4MlpYSmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TmpjS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxuTnZiSFpsY2w5eVpXZHBjM1J5ZVM1amIyNTBjbUZqZEM1VGIyeDJaWEpTWldkcGMzUnllUzUxY0dSaGRHVmZZWFpoYVd4aFltbHNhWFI1VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2RYQmtZWFJsWDJGMllXbHNZV0pwYkdsMGVUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyeDJaWEpmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk9EUUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WW05dmJBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdmJIWmxjbDl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRvNE5nb2dJQ0FnTHk4Z1lYTnpaWEowSUZSNGJpNXpaVzVrWlhJZ2FXNGdjMlZzWmk1emIyeDJaWEp6TENBaVRtOTBJSEpsWjJsemRHVnlaV1FpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TnpNMll6YzJOV1lLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JoYzNObGNuUWdMeThnVG05MElISmxaMmx6ZEdWeVpXUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyeDJaWEpmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk9EY0tJQ0FnSUM4dklIQnliMlpwYkdVZ1BTQnpaV3htTG5OdmJIWmxjbk5iVkhodUxuTmxibVJsY2wwdVkyOXdlU2dwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TnpNMll6YzJOV1lLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1YzI5c2RtVnljeUJsYm5SeWVTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJ4MlpYSmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2T1RBS0lDQWdJQzh2SUhkaGJHeGxkRDF3Y205bWFXeGxMbmRoYkd4bGRDd0tJQ0FnSUdSMWNBb2dJQ0FnWlhoMGNtRmpkQ0F3SURNeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5c2RtVnlYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2preENpQWdJQ0F2THlCemRHRnJaVjloYlc5MWJuUTljSEp2Wm1sc1pTNXpkR0ZyWlY5aGJXOTFiblFzQ2lBZ0lDQmthV2NnTVFvZ0lDQWdaWGgwY21GamRDQXpNaUE0Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlzZG1WeVgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPamt5Q2lBZ0lDQXZMeUIwYjNSaGJGOXpaWFIwYkdWa1BYQnliMlpwYkdVdWRHOTBZV3hmYzJWMGRHeGxaQ3dLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmxlSFJ5WVdOMElEUXdJRGdLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMngyWlhKZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZPVE1LSUNBZ0lDOHZJSFJ2ZEdGc1gyUnBjM0IxZEdWelBYQnliMlpwYkdVdWRHOTBZV3hmWkdsemNIVjBaWE1zQ2lBZ0lDQmthV2NnTXdvZ0lDQWdaWGgwY21GamRDQTBPQ0E0Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlzZG1WeVgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPamswQ2lBZ0lDQXZMeUJ5WlhCMWRHRjBhVzl1WDNOamIzSmxQWEJ5YjJacGJHVXVjbVZ3ZFhSaGRHbHZibDl6WTI5eVpTd0tJQ0FnSUdScFp5QTBDaUFnSUNCbGVIUnlZV04wSURVMklEZ0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyeDJaWEpmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk9UWUtJQ0FnSUM4dklISmxaMmx6ZEdWeVpXUmZZWFE5Y0hKdlptbHNaUzV5WldkcGMzUmxjbVZrWDJGMExBb2dJQ0FnZFc1amIzWmxjaUExQ2lBZ0lDQmxlSFJ5WVdOMElEWTFJRGdLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMngyWlhKZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZPRGt0T1RjS0lDQWdJQzh2SUhObGJHWXVjMjlzZG1WeWMxdFVlRzR1YzJWdVpHVnlYU0E5SUZOdmJIWmxjbEJ5YjJacGJHVW9DaUFnSUNBdkx5QWdJQ0FnZDJGc2JHVjBQWEJ5YjJacGJHVXVkMkZzYkdWMExBb2dJQ0FnTHk4Z0lDQWdJSE4wWVd0bFgyRnRiM1Z1ZEQxd2NtOW1hV3hsTG5OMFlXdGxYMkZ0YjNWdWRDd0tJQ0FnSUM4dklDQWdJQ0IwYjNSaGJGOXpaWFIwYkdWa1BYQnliMlpwYkdVdWRHOTBZV3hmYzJWMGRHeGxaQ3dLSUNBZ0lDOHZJQ0FnSUNCMGIzUmhiRjlrYVhOd2RYUmxjejF3Y205bWFXeGxMblJ2ZEdGc1gyUnBjM0IxZEdWekxBb2dJQ0FnTHk4Z0lDQWdJSEpsY0hWMFlYUnBiMjVmYzJOdmNtVTljSEp2Wm1sc1pTNXlaWEIxZEdGMGFXOXVYM05qYjNKbExBb2dJQ0FnTHk4Z0lDQWdJR2x6WDI5dWJHbHVaVDFoY21NMExrSnZiMndvYVhOZmIyNXNhVzVsS1N3S0lDQWdJQzh2SUNBZ0lDQnlaV2RwYzNSbGNtVmtYMkYwUFhCeWIyWnBiR1V1Y21WbmFYTjBaWEpsWkY5aGRDd0tJQ0FnSUM4dklDa0tJQ0FnSUhWdVkyOTJaWElnTlFvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJ4MlpYSmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2T0RrS0lDQWdJQzh2SUhObGJHWXVjMjlzZG1WeWMxdFVlRzR1YzJWdVpHVnlYU0E5SUZOdmJIWmxjbEJ5YjJacGJHVW9DaUFnSUNCaWVYUmxZMTh3SUM4dklEQjROek0yWXpjMk5XWUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdmJIWmxjbDl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRvNE9TMDVOd29nSUNBZ0x5OGdjMlZzWmk1emIyeDJaWEp6VzFSNGJpNXpaVzVrWlhKZElEMGdVMjlzZG1WeVVISnZabWxzWlNnS0lDQWdJQzh2SUNBZ0lDQjNZV3hzWlhROWNISnZabWxzWlM1M1lXeHNaWFFzQ2lBZ0lDQXZMeUFnSUNBZ2MzUmhhMlZmWVcxdmRXNTBQWEJ5YjJacGJHVXVjM1JoYTJWZllXMXZkVzUwTEFvZ0lDQWdMeThnSUNBZ0lIUnZkR0ZzWDNObGRIUnNaV1E5Y0hKdlptbHNaUzUwYjNSaGJGOXpaWFIwYkdWa0xBb2dJQ0FnTHk4Z0lDQWdJSFJ2ZEdGc1gyUnBjM0IxZEdWelBYQnliMlpwYkdVdWRHOTBZV3hmWkdsemNIVjBaWE1zQ2lBZ0lDQXZMeUFnSUNBZ2NtVndkWFJoZEdsdmJsOXpZMjl5WlQxd2NtOW1hV3hsTG5KbGNIVjBZWFJwYjI1ZmMyTnZjbVVzQ2lBZ0lDQXZMeUFnSUNBZ2FYTmZiMjVzYVc1bFBXRnlZelF1UW05dmJDaHBjMTl2Ym14cGJtVXBMQW9nSUNBZ0x5OGdJQ0FnSUhKbFoybHpkR1Z5WldSZllYUTljSEp2Wm1sc1pTNXlaV2RwYzNSbGNtVmtYMkYwTEFvZ0lDQWdMeThnS1FvZ0lDQWdjM2RoY0FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdmJIWmxjbDl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRvNE5Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVjMjlzZG1WeVgzSmxaMmx6ZEhKNUxtTnZiblJ5WVdOMExsTnZiSFpsY2xKbFoybHpkSEo1TG5KbFkyOXlaRjl6WlhSMGJHVnRaVzUwVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2NtVmpiM0prWDNObGRIUnNaVzFsYm5RNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5c2RtVnlYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2prNUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlzZG1WeVgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPakV3TWdvZ0lDQWdMeThnWVhOelpYSjBJRlI0Ymk1elpXNWtaWElnUFQwZ2MyVnNaaTVoWkcxcGJpNTJZV3gxWlN3Z0lrOXViSGtnWVdSdGFXNGlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWVdSdGFXNGlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WVdSdGFXNGdaWGhwYzNSekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRTl1YkhrZ1lXUnRhVzRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMngyWlhKZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZNVEF6Q2lBZ0lDQXZMeUJoYzNObGNuUWdjMjlzZG1WeUlHbHVJSE5sYkdZdWMyOXNkbVZ5Y3l3Z0lsTnZiSFpsY2lCdWIzUWdjbVZuYVhOMFpYSmxaQ0lLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGczTXpaak56WTFaZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWVhOelpYSjBJQzh2SUZOdmJIWmxjaUJ1YjNRZ2NtVm5hWE4wWlhKbFpBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdmJIWmxjbDl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRveE1EUUtJQ0FnSUM4dklIQnliMlpwYkdVZ1BTQnpaV3htTG5OdmJIWmxjbk5iYzI5c2RtVnlYUzVqYjNCNUtDa0tJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ2NHOXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOXNkbVZ5WDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qRXdOZ29nSUNBZ0x5OGdibVYzWDNObGRIUnNaV1FnUFNCd2NtOW1hV3hsTG5SdmRHRnNYM05sZEhSc1pXUXVibUYwYVhabElDc2dWVWx1ZERZMEtERXBDaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaHBiblFnTkRBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdLd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZiSFpsY2w5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUb3hNRGNLSUNBZ0lDOHZJRzVsZDE5eVpYQWdQU0J3Y205bWFXeGxMbkpsY0hWMFlYUnBiMjVmYzJOdmNtVXVibUYwYVhabElDc2dWVWx1ZERZMEtESXBDaUFnSUNCa2FXY2dNUW9nSUNBZ2NIVnphR2x1ZENBMU5nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUhCMWMyaHBiblFnTWdvZ0lDQWdLd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZiSFpsY2w5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUb3hNRGdLSUNBZ0lDOHZJR05oY0hCbFpGOXlaWEFnUFNCdVpYZGZjbVZ3SUdsbUlHNWxkMTl5WlhBZ1BEMGdWVWx1ZERZMEtERXdNREFwSUdWc2MyVWdWVWx1ZERZMEtERXdNREFwQ2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ01UQXdNQW9nSUNBZ1BEMEtJQ0FnSUhCMWMyaHBiblFnTVRBd01Bb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlzZG1WeVgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPakV4TVFvZ0lDQWdMeThnZDJGc2JHVjBQWEJ5YjJacGJHVXVkMkZzYkdWMExBb2dJQ0FnWkdsbklESUtJQ0FnSUdWNGRISmhZM1FnTUNBek1nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdmJIWmxjbDl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRveE1USUtJQ0FnSUM4dklITjBZV3RsWDJGdGIzVnVkRDF3Y205bWFXeGxMbk4wWVd0bFgyRnRiM1Z1ZEN3S0lDQWdJR1JwWnlBekNpQWdJQ0JsZUhSeVlXTjBJRE15SURnS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJ4MlpYSmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TVRFekNpQWdJQ0F2THlCMGIzUmhiRjl6WlhSMGJHVmtQV0Z5WXpRdVZVbHVkRFkwS0c1bGQxOXpaWFIwYkdWa0tTd0tJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052YkhabGNsOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG94TVRRS0lDQWdJQzh2SUhSdmRHRnNYMlJwYzNCMWRHVnpQWEJ5YjJacGJHVXVkRzkwWVd4ZlpHbHpjSFYwWlhNc0NpQWdJQ0JrYVdjZ05Bb2dJQ0FnWlhoMGNtRmpkQ0EwT0NBNENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5c2RtVnlYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pFeE5Rb2dJQ0FnTHk4Z2NtVndkWFJoZEdsdmJsOXpZMjl5WlQxaGNtTTBMbFZKYm5RMk5DaGpZWEJ3WldSZmNtVndLU3dLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdmJIWmxjbDl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRveE1UWUtJQ0FnSUM4dklHbHpYMjl1YkdsdVpUMXdjbTltYVd4bExtbHpYMjl1YkdsdVpTd0tJQ0FnSUdScFp5QTFDaUFnSUNCcGJuUmpJRFFnTHk4Z05URXlDaUFnSUNCblpYUmlhWFFLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdNSGd3TUFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWMFltbDBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOXNkbVZ5WDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qRXhOd29nSUNBZ0x5OGdjbVZuYVhOMFpYSmxaRjloZEQxd2NtOW1hV3hsTG5KbFoybHpkR1Z5WldSZllYUXNDaUFnSUNCMWJtTnZkbVZ5SURZS0lDQWdJR1Y0ZEhKaFkzUWdOalVnT0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052YkhabGNsOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG94TVRBdE1URTRDaUFnSUNBdkx5QnpaV3htTG5OdmJIWmxjbk5iYzI5c2RtVnlYU0E5SUZOdmJIWmxjbEJ5YjJacGJHVW9DaUFnSUNBdkx5QWdJQ0FnZDJGc2JHVjBQWEJ5YjJacGJHVXVkMkZzYkdWMExBb2dJQ0FnTHk4Z0lDQWdJSE4wWVd0bFgyRnRiM1Z1ZEQxd2NtOW1hV3hsTG5OMFlXdGxYMkZ0YjNWdWRDd0tJQ0FnSUM4dklDQWdJQ0IwYjNSaGJGOXpaWFIwYkdWa1BXRnlZelF1VlVsdWREWTBLRzVsZDE5elpYUjBiR1ZrS1N3S0lDQWdJQzh2SUNBZ0lDQjBiM1JoYkY5a2FYTndkWFJsY3oxd2NtOW1hV3hsTG5SdmRHRnNYMlJwYzNCMWRHVnpMQW9nSUNBZ0x5OGdJQ0FnSUhKbGNIVjBZWFJwYjI1ZmMyTnZjbVU5WVhKak5DNVZTVzUwTmpRb1kyRndjR1ZrWDNKbGNDa3NDaUFnSUNBdkx5QWdJQ0FnYVhOZmIyNXNhVzVsUFhCeWIyWnBiR1V1YVhOZmIyNXNhVzVsTEFvZ0lDQWdMeThnSUNBZ0lISmxaMmx6ZEdWeVpXUmZZWFE5Y0hKdlptbHNaUzV5WldkcGMzUmxjbVZrWDJGMExBb2dJQ0FnTHk4Z0tRb2dJQ0FnZFc1amIzWmxjaUEyQ2lBZ0lDQjFibU52ZG1WeUlEWUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdmJIWmxjbDl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRvNU9Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVjMjlzZG1WeVgzSmxaMmx6ZEhKNUxtTnZiblJ5WVdOMExsTnZiSFpsY2xKbFoybHpkSEo1TG5KbFkyOXlaRjlrYVhOd2RYUmxXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LY21WamIzSmtYMlJwYzNCMWRHVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOXNkbVZ5WDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qRXlNQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdmJIWmxjbDl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRveE1qTUtJQ0FnSUM4dklHRnpjMlZ5ZENCVWVHNHVjMlZ1WkdWeUlEMDlJSE5sYkdZdVlXUnRhVzR1ZG1Gc2RXVXNJQ0pQYm14NUlHRmtiV2x1SWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltRmtiV2x1SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtRmtiV2x1SUdWNGFYTjBjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUGJteDVJR0ZrYldsdUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5c2RtVnlYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pFeU5Bb2dJQ0FnTHk4Z1lYTnpaWEowSUhOdmJIWmxjaUJwYmlCelpXeG1Mbk52YkhabGNuTXNJQ0pUYjJ4MlpYSWdibTkwSUhKbFoybHpkR1Z5WldRaUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE56TTJZemMyTldZS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd2JpQXlDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0Z6YzJWeWRDQXZMeUJUYjJ4MlpYSWdibTkwSUhKbFoybHpkR1Z5WldRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJ4MlpYSmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TVRJMUNpQWdJQ0F2THlCd2NtOW1hV3hsSUQwZ2MyVnNaaTV6YjJ4MlpYSnpXM052YkhabGNsMHVZMjl3ZVNncENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCd2IzQUtJQ0FnSUdSMWNHNGdNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZiSFpsY2w5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUb3hNamNLSUNBZ0lDOHZJRzVsZDE5a2FYTndkWFJsY3lBOUlIQnliMlpwYkdVdWRHOTBZV3hmWkdsemNIVjBaWE11Ym1GMGFYWmxJQ3NnVlVsdWREWTBLREVwQ2lBZ0lDQndkWE5vYVc1MElEUTRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUNzS0lDQWdJSE4zWVhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJ4MlpYSmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TVRJNUNpQWdJQ0F2THlCamRYSnlaVzUwWDNKbGNDQTlJSEJ5YjJacGJHVXVjbVZ3ZFhSaGRHbHZibDl6WTI5eVpTNXVZWFJwZG1VS0lDQWdJSEIxYzJocGJuUWdOVFlLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmtkWEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMngyWlhKZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZNVEk0Q2lBZ0lDQXZMeUJ3Wlc1aGJIUjVJRDBnVlVsdWREWTBLREV3S1FvZ0lDQWdjSFZ6YUdsdWRDQXhNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZiSFpsY2w5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUb3hNekFLSUNBZ0lDOHZJRzVsZDE5eVpYQWdQU0JqZFhKeVpXNTBYM0psY0NBdElIQmxibUZzZEhrZ2FXWWdZM1Z5Y21WdWRGOXlaWEFnUGlCd1pXNWhiSFI1SUdWc2MyVWdWVWx1ZERZMEtEQXBDaUFnSUNBK0NpQWdJQ0JpZWlCeVpXTnZjbVJmWkdsemNIVjBaVjkwWlhKdVlYSjVYMlpoYkhObFFETUtJQ0FnSUdSMWNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdmJIWmxjbDl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRveE1qZ0tJQ0FnSUM4dklIQmxibUZzZEhrZ1BTQlZTVzUwTmpRb01UQXBDaUFnSUNCd2RYTm9hVzUwSURFd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5c2RtVnlYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pFek1Bb2dJQ0FnTHk4Z2JtVjNYM0psY0NBOUlHTjFjbkpsYm5SZmNtVndJQzBnY0dWdVlXeDBlU0JwWmlCamRYSnlaVzUwWDNKbGNDQStJSEJsYm1Gc2RIa2daV3h6WlNCVlNXNTBOalFvTUNrS0lDQWdJQzBLQ25KbFkyOXlaRjlrYVhOd2RYUmxYM1JsY201aGNubGZiV1Z5WjJWQU5Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyeDJaWEpmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk1UTXpDaUFnSUNBdkx5QjNZV3hzWlhROWNISnZabWxzWlM1M1lXeHNaWFFzQ2lBZ0lDQmthV2NnTXdvZ0lDQWdaSFZ3Q2lBZ0lDQmxlSFJ5WVdOMElEQWdNeklLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMngyWlhKZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZNVE0wQ2lBZ0lDQXZMeUJ6ZEdGclpWOWhiVzkxYm5ROWNISnZabWxzWlM1emRHRnJaVjloYlc5MWJuUXNDaUFnSUNCa2FXY2dNUW9nSUNBZ1pYaDBjbUZqZENBek1pQTRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOXNkbVZ5WDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qRXpOUW9nSUNBZ0x5OGdkRzkwWVd4ZmMyVjBkR3hsWkQxd2NtOW1hV3hsTG5SdmRHRnNYM05sZEhSc1pXUXNDaUFnSUNCa2FXY2dNZ29nSUNBZ1pYaDBjbUZqZENBME1DQTRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOXNkbVZ5WDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qRXpOZ29nSUNBZ0x5OGdkRzkwWVd4ZlpHbHpjSFYwWlhNOVlYSmpOQzVWU1c1ME5qUW9ibVYzWDJScGMzQjFkR1Z6S1N3S0lDQWdJR1JwWnlBMkNpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5c2RtVnlYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pFek53b2dJQ0FnTHk4Z2NtVndkWFJoZEdsdmJsOXpZMjl5WlQxaGNtTTBMbFZKYm5RMk5DaHVaWGRmY21Wd0tTd0tJQ0FnSUhWdVkyOTJaWElnTlFvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052YkhabGNsOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG94TXpnS0lDQWdJQzh2SUdselgyOXViR2x1WlQxd2NtOW1hV3hsTG1selgyOXViR2x1WlN3S0lDQWdJR1JwWnlBMUNpQWdJQ0JwYm5SaklEUWdMeThnTlRFeUNpQWdJQ0JuWlhSaWFYUUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z01IZ3dNQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlYwWW1sMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5c2RtVnlYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pFek9Rb2dJQ0FnTHk4Z2NtVm5hWE4wWlhKbFpGOWhkRDF3Y205bWFXeGxMbkpsWjJsemRHVnlaV1JmWVhRc0NpQWdJQ0IxYm1OdmRtVnlJRFlLSUNBZ0lHVjRkSEpoWTNRZ05qVWdPQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZiSFpsY2w5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUb3hNekl0TVRRd0NpQWdJQ0F2THlCelpXeG1Mbk52YkhabGNuTmJjMjlzZG1WeVhTQTlJRk52YkhabGNsQnliMlpwYkdVb0NpQWdJQ0F2THlBZ0lDQWdkMkZzYkdWMFBYQnliMlpwYkdVdWQyRnNiR1YwTEFvZ0lDQWdMeThnSUNBZ0lITjBZV3RsWDJGdGIzVnVkRDF3Y205bWFXeGxMbk4wWVd0bFgyRnRiM1Z1ZEN3S0lDQWdJQzh2SUNBZ0lDQjBiM1JoYkY5elpYUjBiR1ZrUFhCeWIyWnBiR1V1ZEc5MFlXeGZjMlYwZEd4bFpDd0tJQ0FnSUM4dklDQWdJQ0IwYjNSaGJGOWthWE53ZFhSbGN6MWhjbU0wTGxWSmJuUTJOQ2h1WlhkZlpHbHpjSFYwWlhNcExBb2dJQ0FnTHk4Z0lDQWdJSEpsY0hWMFlYUnBiMjVmYzJOdmNtVTlZWEpqTkM1VlNXNTBOalFvYm1WM1gzSmxjQ2tzQ2lBZ0lDQXZMeUFnSUNBZ2FYTmZiMjVzYVc1bFBYQnliMlpwYkdVdWFYTmZiMjVzYVc1bExBb2dJQ0FnTHk4Z0lDQWdJSEpsWjJsemRHVnlaV1JmWVhROWNISnZabWxzWlM1eVpXZHBjM1JsY21Wa1gyRjBMQW9nSUNBZ0x5OGdLUW9nSUNBZ2RXNWpiM1psY2lBMkNpQWdJQ0IxYm1OdmRtVnlJRFlLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklEUUtJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMngyWlhKZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZNVEl3Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LY21WamIzSmtYMlJwYzNCMWRHVmZkR1Z5Ym1GeWVWOW1ZV3h6WlVBek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdmJIWmxjbDl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRveE16QUtJQ0FnSUM4dklHNWxkMTl5WlhBZ1BTQmpkWEp5Wlc1MFgzSmxjQ0F0SUhCbGJtRnNkSGtnYVdZZ1kzVnljbVZ1ZEY5eVpYQWdQaUJ3Wlc1aGJIUjVJR1ZzYzJVZ1ZVbHVkRFkwS0RBcENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZaUJ5WldOdmNtUmZaR2x6Y0hWMFpWOTBaWEp1WVhKNVgyMWxjbWRsUURRS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVjMjlzZG1WeVgzSmxaMmx6ZEhKNUxtTnZiblJ5WVdOMExsTnZiSFpsY2xKbFoybHpkSEo1TG5Oc1lYTm9YM052YkhabGNsdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbk5zWVhOb1gzTnZiSFpsY2pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJ4MlpYSmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TVRReUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5c2RtVnlYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pFME5Rb2dJQ0FnTHk4Z1lYTnpaWEowSUZSNGJpNXpaVzVrWlhJZ1BUMGdjMlZzWmk1aFpHMXBiaTUyWVd4MVpTd2dJazl1YkhrZ1lXUnRhVzRpQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVlXUnRhVzRpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVlXUnRhVzRnWlhocGMzUnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dWJIa2dZV1J0YVc0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJ4MlpYSmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TVRRMkNpQWdJQ0F2THlCaGMzTmxjblFnYzI5c2RtVnlJR2x1SUhObGJHWXVjMjlzZG1WeWN5d2dJbE52YkhabGNpQnViM1FnY21WbmFYTjBaWEpsWkNJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnM016WmpOelkxWmdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdGemMyVnlkQ0F2THlCVGIyeDJaWElnYm05MElISmxaMmx6ZEdWeVpXUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyeDJaWEpmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk1UUTNDaUFnSUNBdkx5QndjbTltYVd4bElEMGdjMlZzWmk1emIyeDJaWEp6VzNOdmJIWmxjbDB1WTI5d2VTZ3BDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQndiM0FLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052YkhabGNsOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG94TkRrS0lDQWdJQzh2SUdOMWNuSmxiblJmYzNSaGEyVWdQU0J3Y205bWFXeGxMbk4wWVd0bFgyRnRiM1Z1ZEM1dVlYUnBkbVVLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052YkhabGNsOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG94TlRBS0lDQWdJQzh2SUhOc1lYTm9YMkZ0YjNWdWRDQTlJR0Z0YjNWdWRDQnBaaUJoYlc5MWJuUWdQRDBnWTNWeWNtVnVkRjl6ZEdGclpTQmxiSE5sSUdOMWNuSmxiblJmYzNSaGEyVUtJQ0FnSUdSMWNESUtJQ0FnSUR3OUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lHUjFjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZiSFpsY2w5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUb3hOVElLSUNBZ0lDOHZJR2xtSUhOc1lYTm9YMkZ0YjNWdWRDQStJRlZKYm5RMk5DZ3dLVG9LSUNBZ0lHSjZJSE5zWVhOb1gzTnZiSFpsY2w5aFpuUmxjbDlwWmw5bGJITmxRRFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMngyWlhKZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZNVFV6TFRFMU53b2dJQ0FnTHk4Z2FYUjRiaTVRWVhsdFpXNTBLQW9nSUNBZ0x5OGdJQ0FnSUhKbFkyVnBkbVZ5UFhObGJHWXVZV1J0YVc0dWRtRnNkV1VzQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwUFhOc1lYTm9YMkZ0YjNWdWRDd0tJQ0FnSUM4dklDQWdJQ0JtWldVOU1Dd0tJQ0FnSUM4dklDa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJ4MlpYSmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TVRVMENpQWdJQ0F2THlCeVpXTmxhWFpsY2oxelpXeG1MbUZrYldsdUxuWmhiSFZsTEFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbUZrYldsdUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbUZrYldsdUlHVjRhWE4wY3dvZ0lDQWdaR2xuSURFS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVcxdmRXNTBDaUFnSUNCcGRIaHVYMlpwWld4a0lGSmxZMlZwZG1WeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5c2RtVnlYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pFMU13b2dJQ0FnTHk4Z2FYUjRiaTVRWVhsdFpXNTBLQW9nSUNBZ2FXNTBZMTh3SUM4dklIQmhlUW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdmJIWmxjbDl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRveE5UWUtJQ0FnSUM4dklHWmxaVDB3TEFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlzZG1WeVgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPakUxTXkweE5UY0tJQ0FnSUM4dklHbDBlRzR1VUdGNWJXVnVkQ2dLSUNBZ0lDOHZJQ0FnSUNCeVpXTmxhWFpsY2oxelpXeG1MbUZrYldsdUxuWmhiSFZsTEFvZ0lDQWdMeThnSUNBZ0lHRnRiM1Z1ZEQxemJHRnphRjloYlc5MWJuUXNDaUFnSUNBdkx5QWdJQ0FnWm1WbFBUQXNDaUFnSUNBdkx5QXBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYM04xWW0xcGRBb0tjMnhoYzJoZmMyOXNkbVZ5WDJGbWRHVnlYMmxtWDJWc2MyVkFORG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMngyWlhKZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZNVFl3Q2lBZ0lDQXZMeUIzWVd4c1pYUTljSEp2Wm1sc1pTNTNZV3hzWlhRc0NpQWdJQ0JrYVdjZ01nb2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJREFnTXpJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJ4MlpYSmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TVRZeENpQWdJQ0F2THlCemRHRnJaVjloYlc5MWJuUTlZWEpqTkM1VlNXNTBOalFvWTNWeWNtVnVkRjl6ZEdGclpTQXRJSE5zWVhOb1gyRnRiM1Z1ZENrc0NpQWdJQ0JrYVdjZ013b2dJQ0FnWkdsbklETUtJQ0FnSUMwS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJ4MlpYSmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TVRZeUNpQWdJQ0F2THlCMGIzUmhiRjl6WlhSMGJHVmtQWEJ5YjJacGJHVXVkRzkwWVd4ZmMyVjBkR3hsWkN3S0lDQWdJR1JwWnlBeUNpQWdJQ0JsZUhSeVlXTjBJRFF3SURnS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJ4MlpYSmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TVRZekNpQWdJQ0F2THlCMGIzUmhiRjlrYVhOd2RYUmxjejF3Y205bWFXeGxMblJ2ZEdGc1gyUnBjM0IxZEdWekxBb2dJQ0FnWkdsbklETUtJQ0FnSUdWNGRISmhZM1FnTkRnZ09Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdmJIWmxjbDl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRveE5qUUtJQ0FnSUM4dklISmxjSFYwWVhScGIyNWZjMk52Y21VOWNISnZabWxzWlM1eVpYQjFkR0YwYVc5dVgzTmpiM0psTEFvZ0lDQWdaR2xuSURRS0lDQWdJR1Y0ZEhKaFkzUWdOVFlnT0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052YkhabGNsOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG94TmpVS0lDQWdJQzh2SUdselgyOXViR2x1WlQxd2NtOW1hV3hsTG1selgyOXViR2x1WlN3S0lDQWdJR1JwWnlBMUNpQWdJQ0JwYm5SaklEUWdMeThnTlRFeUNpQWdJQ0JuWlhSaWFYUUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z01IZ3dNQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlYwWW1sMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5c2RtVnlYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pFMk5nb2dJQ0FnTHk4Z2NtVm5hWE4wWlhKbFpGOWhkRDF3Y205bWFXeGxMbkpsWjJsemRHVnlaV1JmWVhRc0NpQWdJQ0IxYm1OdmRtVnlJRFlLSUNBZ0lHVjRkSEpoWTNRZ05qVWdPQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZiSFpsY2w5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUb3hOVGt0TVRZM0NpQWdJQ0F2THlCelpXeG1Mbk52YkhabGNuTmJjMjlzZG1WeVhTQTlJRk52YkhabGNsQnliMlpwYkdVb0NpQWdJQ0F2THlBZ0lDQWdkMkZzYkdWMFBYQnliMlpwYkdVdWQyRnNiR1YwTEFvZ0lDQWdMeThnSUNBZ0lITjBZV3RsWDJGdGIzVnVkRDFoY21NMExsVkpiblEyTkNoamRYSnlaVzUwWDNOMFlXdGxJQzBnYzJ4aGMyaGZZVzF2ZFc1MEtTd0tJQ0FnSUM4dklDQWdJQ0IwYjNSaGJGOXpaWFIwYkdWa1BYQnliMlpwYkdVdWRHOTBZV3hmYzJWMGRHeGxaQ3dLSUNBZ0lDOHZJQ0FnSUNCMGIzUmhiRjlrYVhOd2RYUmxjejF3Y205bWFXeGxMblJ2ZEdGc1gyUnBjM0IxZEdWekxBb2dJQ0FnTHk4Z0lDQWdJSEpsY0hWMFlYUnBiMjVmYzJOdmNtVTljSEp2Wm1sc1pTNXlaWEIxZEdGMGFXOXVYM05qYjNKbExBb2dJQ0FnTHk4Z0lDQWdJR2x6WDI5dWJHbHVaVDF3Y205bWFXeGxMbWx6WDI5dWJHbHVaU3dLSUNBZ0lDOHZJQ0FnSUNCeVpXZHBjM1JsY21Wa1gyRjBQWEJ5YjJacGJHVXVjbVZuYVhOMFpYSmxaRjloZEN3S0lDQWdJQzh2SUNrS0lDQWdJSFZ1WTI5MlpYSWdOZ29nSUNBZ2RXNWpiM1psY2lBMkNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTlFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUEwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5c2RtVnlYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pFME1nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVjMjlzZG1WeVgzSmxaMmx6ZEhKNUxtTnZiblJ5WVdOMExsTnZiSFpsY2xKbFoybHpkSEo1TG1kbGRGOXpiMngyWlhKYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncG5aWFJmYzI5c2RtVnlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZiSFpsY2w5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUb3hOamtLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlzZG1WeVgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPakUzTVFvZ0lDQWdMeThnY21WMGRYSnVJSE5sYkdZdWMyOXNkbVZ5YzF0emIyeDJaWEpkQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TnpNMll6YzJOV1lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWMyOXNkbVZ5Y3lCbGJuUnllU0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyeDJaWEpmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk1UWTVDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWMyOXNkbVZ5WDNKbFoybHpkSEo1TG1OdmJuUnlZV04wTGxOdmJIWmxjbEpsWjJsemRISjVMbWx6WDNOdmJIWmxjbDl5WldkcGMzUmxjbVZrVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2FYTmZjMjlzZG1WeVgzSmxaMmx6ZEdWeVpXUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOXNkbVZ5WDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qRTNNd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMngyWlhKZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZNVGMxQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdjMjlzZG1WeUlHbHVJSE5sYkdZdWMyOXNkbVZ5Y3dvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURjek5tTTNOalZtQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZiSFpsY2w5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUb3hOek1LSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdZbmwwWldNZ05DQXZMeUF3ZURBd0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCelpYUmlhWFFLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWMyOXNkbVZ5WDNKbFoybHpkSEo1TG1OdmJuUnlZV04wTGxOdmJIWmxjbEpsWjJsemRISjVMbWRsZEY5eVpYQjFkR0YwYVc5dVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taMlYwWDNKbGNIVjBZWFJwYjI0NkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5c2RtVnlYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pFM053b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyeDJaWEpmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk1UYzVDaUFnSUNBdkx5QnBaaUJ6YjJ4MlpYSWdhVzRnYzJWc1ppNXpiMngyWlhKek9nb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEY3pObU0zTmpWbUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmllaUJuWlhSZmNtVndkWFJoZEdsdmJsOWhablJsY2w5cFpsOWxiSE5sUURNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJ4MlpYSmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TVRnd0NpQWdJQ0F2THlCeVpYUjFjbTRnYzJWc1ppNXpiMngyWlhKelczTnZiSFpsY2wwdWNtVndkWFJoZEdsdmJsOXpZMjl5WlM1dVlYUnBkbVVLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1YzI5c2RtVnljeUJsYm5SeWVTQmxlR2x6ZEhNS0lDQWdJSEIxYzJocGJuUWdOVFlLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2dwblpYUmZjbVZ3ZFhSaGRHbHZibDloWm5SbGNsOXBibXhwYm1Wa1gzTnRZWEowWDJOdmJuUnlZV04wY3k1emIyeDJaWEpmY21WbmFYTjBjbmt1WTI5dWRISmhZM1F1VTI5c2RtVnlVbVZuYVhOMGNua3VaMlYwWDNKbGNIVjBZWFJwYjI1QU5Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyeDJaWEpmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk1UYzNDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ21kbGRGOXlaWEIxZEdGMGFXOXVYMkZtZEdWeVgybG1YMlZzYzJWQU16b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyeDJaWEpmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk1UZ3hDaUFnSUNBdkx5QnlaWFIxY200Z1ZVbHVkRFkwS0RBcENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052YkhabGNsOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG94TnpjS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnWWlCblpYUmZjbVZ3ZFhSaGRHbHZibDloWm5SbGNsOXBibXhwYm1Wa1gzTnRZWEowWDJOdmJuUnlZV04wY3k1emIyeDJaWEpmY21WbmFYTjBjbmt1WTI5dWRISmhZM1F1VTI5c2RtVnlVbVZuYVhOMGNua3VaMlYwWDNKbGNIVjBZWFJwYjI1QU5Bbz0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFGQVFBZ0NJQUVKZ1lFYzJ4Mlh3VmhaRzFwYmcxMGIzUmhiRjl6YjJ4MlpYSnpDVzFwYmw5emRHRnJaUUVBQkJVZmZIVXhHRUFBQ2l1QmdLM2lCR2NxSTJjeEdSUkVNUmhCQUU2Q0NnVDN4dFM4Qk0xZ0t5WUVmUXo0cVFUMzBydU9CSy9sYkpJRWc2d2NnQVJVVGt4N0JQd1RCQjRFUVNXUHF3U3lOMW5XTmhvQWpnb0FJUUEzQUtZQTJ3RXBBWmdDREFLYkFxOEN5Z0NBQkNRTkwyYzJHZ0NPQVFBQkFEWWFBVWtWSlJKRUZ5a3hBR2NyVEdjaVF6WWFBVWtWSlJKRUZ6RUFJeWxsUkJKRUsweG5Ja014Rm9FQ0NVazRFQ0lTUkRFV0lnbEpPQkFpRWtRb01RQlF2VVVCRkVSTU9BY3lDaEpFU1RnSE1nb1NSRGdJSXl0bFJFc0JEa1F4QUV3V01nY1dUZ0pRZ0JrQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBR1FBVUV4UUtERUFVRXkvSXlwbFJDSUlLa3huSWtNb01RQlF2VVVCUkNneEFGQytSQ1JiU1VFQUVMRXhBRXNCc2dpeUJ5S3lFQ095QWJNb01RQlF2RWdqS21WRUlna3FUR2NpUXpZYUFVa1ZJaEpFS0RFQVVMMUZBVVFvTVFCUXZrUkpWd0FnU3dGWElBaExBbGNvQ0VzRFZ6QUlTd1JYT0FoUEJWZEJDRThGVHdWUVR3UlFUd05RVHdKUVR3SlFURkFvTVFCUVRMOGlRellhQVVrVkpCSkVNUUFqS1dWRUVrUW9URkJKdlVVQlJFbStTRW1CS0ZzaUNFc0JnVGhiZ1FJSVNZSG9CdzZCNkFkT0FrMUxBbGNBSUVzRFZ5QUlUd01XU3dSWE1BaFBCQlpMQlNFRVV5Y0VJMDhDVkU4R1YwRUlUd1pQQmxCUEJWQlBCRkJQQTFCUEFsQk1VTDhpUXpZYUFVa1ZKQkpFTVFBaktXVkVFa1FvVEZCSEFyMUZBVVMrU0VjQ2dUQmJJZ2hNZ1RoYlNZRUtEVUVBUTBtQkNnbExBMGxYQUNCTEFWY2dDRXNDVnlnSVN3WVdUd1VXU3dVaEJGTW5CQ05QQWxSUEJsZEJDRThHVHdaUVR3VlFUd1JRVHdOUVR3SlFURkJMQkV5L0lrTWpRdis5TmhvQlNSVWtFa1EyR2dKSkZTVVNSQmN4QUNNcFpVUVNSQ2hQQWxCSlRnSkp2VVVCUkw1SVNVNENKRnRKVGdKS0RreE9BazFKUVFBU3NTTXBaVVJMQWJJSXNnY2lzaEFqc2dHelN3SkpWd0FnU3dOTEF3a1dTd0pYS0FoTEExY3dDRXNFVnpnSVN3VWhCRk1uQkNOUEFsUlBCbGRCQ0U4R1R3WlFUd1ZRVHdSUVR3TlFUd0pRVEZCTEJFeS9Ja00yR2dGSkZTUVNSQ2hNVUw1RUp3Vk1VTEFpUXpZYUFVa1ZKQkpFS0V4UXZVVUJKd1FqVHdKVUp3Vk1VTEFpUXpZYUFVa1ZKQkpFS0V4UVNiMUZBVUVBRGttK1JJRTRXeFluQlV4UXNDSkRJMEwvOUE9PSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjcsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
