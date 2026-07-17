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

namespace Arc56.Generated.filippofalleroni.Trait_swap_and_Loot_Box.LootBoxCommitReveal_0ff11f56
{


    public class LootBoxCommitRevealProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public LootBoxCommitRevealProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        public class Events
        {
            public class CommittedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 51, 66, 102, 115 };
                public const string Signature = "Committed(address,uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Algorand.Address Account { get; set; }
                public ulong Target { get; set; }

                public static CommittedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new CommittedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAccount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vAccount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAccount = vAccount.ToValue();
                    if (valueAccount is Algorand.Address vAccountValue) { ret.Account = vAccountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTarget = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTarget.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTarget = vTarget.ToValue();
                    if (valueTarget is ulong vTargetValue) { ret.Target = vTargetValue; }
                    return ret;

                }

            }

            public class RevealedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 189, 81, 158, 137 };
                public const string Signature = "Revealed(address,uint64,uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Algorand.Address Account { get; set; }
                public ulong Target { get; set; }
                public ulong Value { get; set; }

                public static RevealedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new RevealedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAccount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vAccount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAccount = vAccount.ToValue();
                    if (valueAccount is Algorand.Address vAccountValue) { ret.Account = vAccountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTarget = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTarget.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTarget = vTarget.ToValue();
                    if (valueTarget is ulong vTargetValue) { ret.Target = vTargetValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vValue = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vValue.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueValue = vValue.ToValue();
                    if (valueValue is ulong vValueValue) { ret.Value = vValueValue; }
                    return ret;

                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="treasury"> </param>
        /// <param name="price"> </param>
        /// <param name="beaconApp"> </param>
        /// <param name="beaconCadence"> </param>
        public async Task CreateApplication(Algorand.Address treasury, ulong price, ulong beaconApp, ulong beaconCadence, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 30, 5, 218 };
            var treasuryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); treasuryAbi.From(treasury);
            var priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); priceAbi.From(price);
            var beaconAppAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); beaconAppAbi.From(beaconApp);
            var beaconCadenceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); beaconCadenceAbi.From(beaconCadence);

            var result = await base.CallApp(new List<object> { abiHandle, treasuryAbi, priceAbi, beaconAppAbi, beaconCadenceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(Algorand.Address treasury, ulong price, ulong beaconApp, ulong beaconCadence, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 30, 5, 218 };
            var treasuryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); treasuryAbi.From(treasury);
            var priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); priceAbi.From(price);
            var beaconAppAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); beaconAppAbi.From(beaconApp);
            var beaconCadenceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); beaconCadenceAbi.From(beaconCadence);

            return await base.MakeTransactionList(new List<object> { abiHandle, treasuryAbi, priceAbi, beaconAppAbi, beaconCadenceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="treasury"> </param>
        /// <param name="price"> </param>
        /// <param name="beaconApp"> </param>
        /// <param name="beaconCadence"> </param>
        public async Task Configure(Algorand.Address treasury, ulong price, ulong beaconApp, ulong beaconCadence, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 103, 101, 43, 192 };
            var treasuryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); treasuryAbi.From(treasury);
            var priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); priceAbi.From(price);
            var beaconAppAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); beaconAppAbi.From(beaconApp);
            var beaconCadenceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); beaconCadenceAbi.From(beaconCadence);

            var result = await base.CallApp(new List<object> { abiHandle, treasuryAbi, priceAbi, beaconAppAbi, beaconCadenceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Configure_Transactions(Algorand.Address treasury, ulong price, ulong beaconApp, ulong beaconCadence, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 103, 101, 43, 192 };
            var treasuryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); treasuryAbi.From(treasury);
            var priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); priceAbi.From(price);
            var beaconAppAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); beaconAppAbi.From(beaconApp);
            var beaconCadenceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); beaconCadenceAbi.From(beaconCadence);

            return await base.MakeTransactionList(new List<object> { abiHandle, treasuryAbi, priceAbi, beaconAppAbi, beaconCadenceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="payment"> </param>
        public async Task Commit(PaymentTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 39, 163, 88, 219 };

            var result = await base.CallApp(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Commit_Transactions(PaymentTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 39, 163, 88, 219 };

            return await base.MakeTransactionList(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> Reveal(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 117, 14, 201, 181 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Reveal_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 117, 14, 201, 181 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="account"> </param>
        public async Task Reclaim(Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 122, 233, 233, 67 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            var result = await base.CallApp(new List<object> { abiHandle, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Reclaim_Transactions(Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 122, 233, 233, 67 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            return await base.MakeTransactionList(new List<object> { abiHandle, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="amount"> </param>
        public async Task Withdraw(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 33, 241, 221, 255 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Withdraw_Transactions(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 33, 241, 221, 255 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTG9vdEJveENvbW1pdFJldmVhbCIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGVBcHBsaWNhdGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidHJlYXN1cnkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByaWNlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiZWFjb25BcHAiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJlYWNvbkNhZGVuY2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY29uZmlndXJlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0cmVhc3VyeSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJpY2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJlYWNvbkFwcCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYmVhY29uQ2FkZW5jZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjb21taXQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5bWVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiQ29tbWl0dGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2NvdW50IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidGFyZ2V0IiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmV2ZWFsIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IlJldmVhbGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2NvdW50IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidGFyZ2V0IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWNsYWltIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2NvdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6IndpdGhkcmF3IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MywiYnl0ZXMiOjF9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzI0Nl0sImVycm9yTWVzc2FnZSI6IkFjdGl2ZSBjb21taXQgZXhpc3RzIOKAlCByZXZlYWwgb3IgcmVjbGFpbSBmaXJzdCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ1OV0sImVycm9yTWVzc2FnZSI6IkJlYWNvbiBhcHAgaWQgaXMgcmVxdWlyZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NjJdLCJlcnJvck1lc3NhZ2UiOiJCZWFjb24gY2FkZW5jZSBtdXN0IGJlIHBvc2l0aXZlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjk4XSwiZXJyb3JNZXNzYWdlIjoiQmVhY29uIHJvdW5kIG5vdCByZWFjaGVkIHlldCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM2MV0sImVycm9yTWVzc2FnZSI6IkJ5dGVzIGhhcyB2YWxpZCBwcmVmaXgiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMDhdLCJlcnJvck1lc3NhZ2UiOiJDb21taXQgZXhwaXJlZCDigJQgY2FsbCByZWNsYWltKCkgYW5kIHJlY29tbWl0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDE1XSwiZXJyb3JNZXNzYWdlIjoiQ29tbWl0IGhhcyBub3QgZXhwaXJlZCB5ZXQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NTZdLCJlcnJvck1lc3NhZ2UiOiJDcmF0ZSBwcmljZSBtdXN0IGJlIHBvc2l0aXZlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjg4XSwiZXJyb3JNZXNzYWdlIjoiTm8gYWN0aXZlIGNvbW1pdCB0byByZXZlYWwiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MDJdLCJlcnJvck1lc3NhZ2UiOiJObyBjb21taXQgdG8gcmVjbGFpbSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ5XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE5Ml0sImVycm9yTWVzc2FnZSI6Ik9ubHkgdGhlIGNyZWF0b3IgY2FuIGNvbmZpZ3VyZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQzNF0sImVycm9yTWVzc2FnZSI6Ik9ubHkgdGhlIGNyZWF0b3IgY2FuIHdpdGhkcmF3IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjI5XSwiZXJyb3JNZXNzYWdlIjoiUGF5bWVudCBpcyBiZWxvdyB0aGUgY3JhdGUgcHJpY2UiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMTldLCJlcnJvck1lc3NhZ2UiOiJQYXltZW50IG11c3QgZ28gdG8gdGhlIHRyZWFzdXJ5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjM2XSwiZXJyb3JNZXNzYWdlIjoiUGF5bWVudCBzZW5kZXIgbXVzdCBtYXRjaCB0aGUgY2FsbGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjE3LDIyNywyNTIsMzE3XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgR2xvYmFsU3RhdGUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTE5LDE1OSwzOTRdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTI3LDEzNiwxNDUsMTY3LDE3NiwxODUsNDI3XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjA3XSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBwYXkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01TQTRJREFnTXpJS0lDQWdJR0o1ZEdWallteHZZMnNnSW1NaUlDSjBjbVZoYzNWeWVTSWdJbkJ5YVdObElpQWlZMkZrWlc1alpTSWdJbUpsWVdOdmJpSWdNSGd4TlRGbU4yTTNOUW9nSUNBZ0x5OGdiRzl2ZEdKdmVDMWpiMjF0YVhRdGNtVjJaV0ZzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRFS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5Qk1iMjkwUW05NFEyOXRiV2wwVW1WMlpXRnNJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJ0ZFhOMElHSmxJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVpQnRZV2x1WDJOeVpXRjBaVjlPYjA5d1FEa0tJQ0FnSUhCMWMyaGllWFJsYzNNZ01IZzJOelkxTW1Kak1DQXdlREkzWVRNMU9HUmlJREI0TnpVd1pXTTVZalVnTUhnM1lXVTVaVGswTXlBd2VESXhaakZrWkdabUlDOHZJRzFsZEdodlpDQWlZMjl1Wm1sbmRYSmxLR0ZrWkhKbGMzTXNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFwZG05cFpDSXNJRzFsZEdodlpDQWlZMjl0YldsMEtIQmhlU2wyYjJsa0lpd2diV1YwYUc5a0lDSnlaWFpsWVd3b0tYVnBiblEyTkNJc0lHMWxkR2h2WkNBaWNtVmpiR0ZwYlNoaFpHUnlaWE56S1hadmFXUWlMQ0J0WlhSb2IyUWdJbmRwZEdoa2NtRjNLSFZwYm5RMk5DbDJiMmxrSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ1kyOXVabWxuZFhKbElHTnZiVzFwZENCeVpYWmxZV3dnY21WamJHRnBiU0IzYVhSb1pISmhkd29nSUNBZ1pYSnlDZ3B0WVdsdVgyTnlaV0YwWlY5T2IwOXdRRGs2Q2lBZ0lDQXZMeUJzYjI5MFltOTRMV052YlcxcGRDMXlaWFpsWVd3dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU1Rb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRXh2YjNSQ2IzaERiMjF0YVhSU1pYWmxZV3dnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGhpT0RGbE1EVmtZU0F2THlCdFpYUm9iMlFnSW1OeVpXRjBaVUZ3Y0d4cFkyRjBhVzl1S0dGa1pISmxjM01zZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRcGRtOXBaQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUdOeVpXRjBaVUZ3Y0d4cFkyRjBhVzl1Q2lBZ0lDQmxjbklLQ2dvdkx5QnNiMjkwWW05NExXTnZiVzFwZEMxeVpYWmxZV3d2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VEc5dmRFSnZlRU52YlcxcGRGSmxkbVZoYkM1amNtVmhkR1ZCY0hCc2FXTmhkR2x2Ymx0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtTnlaV0YwWlVGd2NHeHBZMkYwYVc5dU9nb2dJQ0FnTHk4Z2JHOXZkR0p2ZUMxamIyMXRhWFF0Y21WMlpXRnNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVGtLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCdmJrTnlaV0YwWlRvZ0ozSmxjWFZwY21VbklIMHBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklHeHZiM1JpYjNndFkyOXRiV2wwTFhKbGRtVmhiQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPall4Q2lBZ0lDQXZMeUIwYUdsekxuTmxkRU52Ym1acFp5aDBjbVZoYzNWeWVTd2djSEpwWTJVc0lHSmxZV052YmtGd2NDd2dZbVZoWTI5dVEyRmtaVzVqWlNrS0lDQWdJR05oYkd4emRXSWdjMlYwUTI5dVptbG5DaUFnSUNBdkx5QnNiMjkwWW05NExXTnZiVzFwZEMxeVpYWmxZV3d2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xT1FvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lHOXVRM0psWVhSbE9pQW5jbVZ4ZFdseVpTY2dmU2tLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnNiMjkwWW05NExXTnZiVzFwZEMxeVpYWmxZV3d2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VEc5dmRFSnZlRU52YlcxcGRGSmxkbVZoYkM1amIyNW1hV2QxY21WYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGpiMjVtYVdkMWNtVTZDaUFnSUNBdkx5QnNiMjkwWW05NExXTnZiVzFwZEMxeVpYWmxZV3d2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTkFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJQzh2SUd4dmIzUmliM2d0WTI5dGJXbDBMWEpsZG1WaGJDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWTJDaUFnSUNBdkx5QmhjM05sY25Rb1ZIaHVMbk5sYm1SbGNpQTlQVDBnUjJ4dlltRnNMbU55WldGMGIzSkJaR1J5WlhOekxDQW5UMjVzZVNCMGFHVWdZM0psWVhSdmNpQmpZVzRnWTI5dVptbG5kWEpsSnlrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHZHNiMkpoYkNCRGNtVmhkRzl5UVdSa2NtVnpjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUGJteDVJSFJvWlNCamNtVmhkRzl5SUdOaGJpQmpiMjVtYVdkMWNtVUtJQ0FnSUM4dklHeHZiM1JpYjNndFkyOXRiV2wwTFhKbGRtVmhiQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalkzQ2lBZ0lDQXZMeUIwYUdsekxuTmxkRU52Ym1acFp5aDBjbVZoYzNWeWVTd2djSEpwWTJVc0lHSmxZV052YmtGd2NDd2dZbVZoWTI5dVEyRmtaVzVqWlNrS0lDQWdJR05oYkd4emRXSWdjMlYwUTI5dVptbG5DaUFnSUNBdkx5QnNiMjkwWW05NExXTnZiVzFwZEMxeVpYWmxZV3d2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTkFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYkc5dmRHSnZlQzFqYjIxdGFYUXRjbVYyWldGc0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9reHZiM1JDYjNoRGIyMXRhWFJTWlhabFlXd3VZMjl0YldsMFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZMjl0YldsME9nb2dJQ0FnTHk4Z2JHOXZkR0p2ZUMxamIyMXRhWFF0Y21WMlpXRnNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOekFLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCa2RYQUtJQ0FnSUdkMGVHNXpJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z2NHRjVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUhSeVlXNXpZV04wYVc5dUlIUjVjR1VnYVhNZ2NHRjVDaUFnSUNBdkx5QnNiMjkwWW05NExXTnZiVzFwZEMxeVpYWmxZV3d2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zTWdvZ0lDQWdMeThnWTI5dWMzUWdZV05qYjNWdWRDQTlJRlI0Ymk1elpXNWtaWElLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklHeHZiM1JpYjNndFkyOXRiV2wwTFhKbGRtVmhiQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamMyQ2lBZ0lDQXZMeUJoYzNObGNuUW9jR0Y1YldWdWRDNXlaV05sYVhabGNpQTlQVDBnZEdocGN5NTBjbVZoYzNWeWVVRmtaSEpsYzNNdWRtRnNkV1VzSUNkUVlYbHRaVzUwSUcxMWMzUWdaMjhnZEc4Z2RHaGxJSFJ5WldGemRYSjVKeWtLSUNBZ0lHUnBaeUF4Q2lBZ0lDQm5kSGh1Y3lCU1pXTmxhWFpsY2dvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lDOHZJR3h2YjNSaWIzZ3RZMjl0YldsMExYSmxkbVZoYkM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVMENpQWdJQ0F2THlCMGNtVmhjM1Z5ZVVGa1pISmxjM01nUFNCSGJHOWlZV3hUZEdGMFpUeEJZMk52ZFc1MFBpaDdJR3RsZVRvZ0ozUnlaV0Z6ZFhKNUp5QjlLUW9nSUNBZ1lubDBaV05mTVNBdkx5QWlkSEpsWVhOMWNua2lDaUFnSUNBdkx5QnNiMjkwWW05NExXTnZiVzFwZEMxeVpYWmxZV3d2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zTmdvZ0lDQWdMeThnWVhOelpYSjBLSEJoZVcxbGJuUXVjbVZqWldsMlpYSWdQVDA5SUhSb2FYTXVkSEpsWVhOMWNubEJaR1J5WlhOekxuWmhiSFZsTENBblVHRjViV1Z1ZENCdGRYTjBJR2R2SUhSdklIUm9aU0IwY21WaGMzVnllU2NwQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUVlYbHRaVzUwSUcxMWMzUWdaMjhnZEc4Z2RHaGxJSFJ5WldGemRYSjVDaUFnSUNBdkx5QnNiMjkwWW05NExXTnZiVzFwZEMxeVpYWmxZV3d2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zTndvZ0lDQWdMeThnWVhOelpYSjBLSEJoZVcxbGJuUXVZVzF2ZFc1MElENDlJSFJvYVhNdVkzSmhkR1ZRY21salpTNTJZV3gxWlN3Z0oxQmhlVzFsYm5RZ2FYTWdZbVZzYjNjZ2RHaGxJR055WVhSbElIQnlhV05sSnlrS0lDQWdJR1JwWnlBeENpQWdJQ0JuZEhodWN5QkJiVzkxYm5RS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQXZMeUJzYjI5MFltOTRMV052YlcxcGRDMXlaWFpsWVd3dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU5Rb2dJQ0FnTHk4Z1kzSmhkR1ZRY21salpTQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvZXlCclpYazZJQ2R3Y21salpTY2dmU2tLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbkJ5YVdObElnb2dJQ0FnTHk4Z2JHOXZkR0p2ZUMxamIyMXRhWFF0Y21WMlpXRnNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOemNLSUNBZ0lDOHZJR0Z6YzJWeWRDaHdZWGx0Wlc1MExtRnRiM1Z1ZENBK1BTQjBhR2x6TG1OeVlYUmxVSEpwWTJVdWRtRnNkV1VzSUNkUVlYbHRaVzUwSUdseklHSmxiRzkzSUhSb1pTQmpjbUYwWlNCd2NtbGpaU2NwQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ1BqMEtJQ0FnSUdGemMyVnlkQ0F2THlCUVlYbHRaVzUwSUdseklHSmxiRzkzSUhSb1pTQmpjbUYwWlNCd2NtbGpaUW9nSUNBZ0x5OGdiRzl2ZEdKdmVDMWpiMjF0YVhRdGNtVjJaV0ZzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnpnS0lDQWdJQzh2SUdGemMyVnlkQ2h3WVhsdFpXNTBMbk5sYm1SbGNpQTlQVDBnWVdOamIzVnVkQ3dnSjFCaGVXMWxiblFnYzJWdVpHVnlJRzExYzNRZ2JXRjBZMmdnZEdobElHTmhiR3hsY2ljcENpQWdJQ0J6ZDJGd0NpQWdJQ0JuZEhodWN5QlRaVzVrWlhJS0lDQWdJR1JwWnlBeENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRkJoZVcxbGJuUWdjMlZ1WkdWeUlHMTFjM1FnYldGMFkyZ2dkR2hsSUdOaGJHeGxjZ29nSUNBZ0x5OGdiRzl2ZEdKdmVDMWpiMjF0YVhRdGNtVjJaV0ZzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRNS0lDQWdJQzh2SUdOdmJXMXBkRlJoY21kbGRDQTlJRUp2ZUUxaGNEeEJZMk52ZFc1MExDQjFhVzUwTmpRK0tIc2dhMlY1VUhKbFptbDRPaUFuWXljZ2ZTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltTWlDaUFnSUNCa2FXY2dNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJzYjI5MFltOTRMV052YlcxcGRDMXlaWFpsWVd3dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNE1nb2dJQ0FnTHk4Z1lYTnpaWEowS0NGMGFHbHpMbU52YlcxcGRGUmhjbWRsZENoaFkyTnZkVzUwS1M1bGVHbHpkSE1zSUNkQlkzUnBkbVVnWTI5dGJXbDBJR1Y0YVhOMGN5RGlnSlFnY21WMlpXRnNJRzl5SUhKbFkyeGhhVzBnWm1seWMzUW5LUW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QkJZM1JwZG1VZ1kyOXRiV2wwSUdWNGFYTjBjeURpZ0pRZ2NtVjJaV0ZzSUc5eUlISmxZMnhoYVcwZ1ptbHljM1FLSUNBZ0lDOHZJR3h2YjNSaWIzZ3RZMjl0YldsMExYSmxkbVZoYkM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pnMUNpQWdJQ0F2THlCamIyNXpkQ0IwWVhKblpYUTZJSFZwYm5RMk5DQTlJSFJvYVhNdWRHRnlaMlYwVW05MWJtUW9SMnh2WW1Gc0xuSnZkVzVrS1FvZ0lDQWdaMnh2WW1Gc0lGSnZkVzVrQ2lBZ0lDQXZMeUJzYjI5MFltOTRMV052YlcxcGRDMXlaWFpsWVd3dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5ESUtJQ0FnSUM4dklHTnZibk4wSUdOaFpHVnVZMlU2SUhWcGJuUTJOQ0E5SUhSb2FYTXVZbVZoWTI5dVEyRmtaVzVqWlM1MllXeDFaUW9nSUNBZ2FXNTBZMTh5SUM4dklEQUtJQ0FnSUM4dklHeHZiM1JpYjNndFkyOXRiV2wwTFhKbGRtVmhiQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalUzQ2lBZ0lDQXZMeUJpWldGamIyNURZV1JsYm1ObElEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWg3SUd0bGVUb2dKMk5oWkdWdVkyVW5JSDBwQ2lBZ0lDQmllWFJsWTE4eklDOHZJQ0pqWVdSbGJtTmxJZ29nSUNBZ0x5OGdiRzl2ZEdKdmVDMWpiMjF0YVhRdGNtVjJaV0ZzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRReUNpQWdJQ0F2THlCamIyNXpkQ0JqWVdSbGJtTmxPaUIxYVc1ME5qUWdQU0IwYUdsekxtSmxZV052YmtOaFpHVnVZMlV1ZG1Gc2RXVUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0F2THlCc2IyOTBZbTk0TFdOdmJXMXBkQzF5WlhabFlXd3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hORE1LSUNBZ0lDOHZJSEpsZEhWeWJpQW9ZMjl0YldsMGRHVmtVbTkxYm1RZ0x5QmpZV1JsYm1ObElDc2dUVWxPWDBSRlRFRlpYMU5NVDFSVEtTQXFJR05oWkdWdVkyVUtJQ0FnSUhOM1lYQUtJQ0FnSUdScFp5QXhDaUFnSUNBdkNpQWdJQ0J3ZFhOb2FXNTBJRElnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdLZ29nSUNBZ0x5OGdiRzl2ZEdKdmVDMWpiMjF0YVhRdGNtVjJaV0ZzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T0RZS0lDQWdJQzh2SUhSb2FYTXVZMjl0YldsMFZHRnlaMlYwS0dGalkyOTFiblFwTG5aaGJIVmxJRDBnZEdGeVoyVjBDaUFnSUNCcGRHOWlDaUFnSUNCemQyRndDaUFnSUNCa2FXY2dNUW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYkc5dmRHSnZlQzFqYjIxdGFYUXRjbVYyWldGc0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9EY0tJQ0FnSUM4dklHVnRhWFFvYm1WM0lFTnZiVzFwZEhSbFpDaDdJR0ZqWTI5MWJuUTZJRzVsZHlCaGNtTTBMa0ZrWkhKbGMzTW9ZV05qYjNWdWRDa3NJSFJoY21kbGREb2dibVYzSUdGeVl6UXVWV2x1ZERZMEtIUmhjbWRsZENrZ2ZTa3BDaUFnSUNCamIyNWpZWFFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRE16TkRJMk5qY3pJQzh2SUcxbGRHaHZaQ0FpUTI5dGJXbDBkR1ZrS0dGa1pISmxjM01zZFdsdWREWTBLU0lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQXZMeUJzYjI5MFltOTRMV052YlcxcGRDMXlaWFpsWVd3dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM01Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2JHOXZkR0p2ZUMxamIyMXRhWFF0Y21WMlpXRnNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPa3h2YjNSQ2IzaERiMjF0YVhSU1pYWmxZV3d1Y21WMlpXRnNXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LY21WMlpXRnNPZ29nSUNBZ0x5OGdiRzl2ZEdKdmVDMWpiMjF0YVhRdGNtVjJaV0ZzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T1RJS0lDQWdJQzh2SUdOdmJuTjBJR0ZqWTI5MWJuUWdQU0JVZUc0dWMyVnVaR1Z5Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QnNiMjkwWW05NExXTnZiVzFwZEMxeVpYWmxZV3d2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xTXdvZ0lDQWdMeThnWTI5dGJXbDBWR0Z5WjJWMElEMGdRbTk0VFdGd1BFRmpZMjkxYm5Rc0lIVnBiblEyTkQ0b2V5QnJaWGxRY21WbWFYZzZJQ2RqSnlCOUtRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVl5SUtJQ0FnSUdScFp5QXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJR3h2YjNSaWIzZ3RZMjl0YldsMExYSmxkbVZoYkM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2prekNpQWdJQ0F2THlCaGMzTmxjblFvZEdocGN5NWpiMjF0YVhSVVlYSm5aWFFvWVdOamIzVnVkQ2t1WlhocGMzUnpMQ0FuVG04Z1lXTjBhWFpsSUdOdmJXMXBkQ0IwYnlCeVpYWmxZV3duS1FvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdGemMyVnlkQ0F2THlCT2J5QmhZM1JwZG1VZ1kyOXRiV2wwSUhSdklISmxkbVZoYkFvZ0lDQWdMeThnYkc5dmRHSnZlQzFqYjIxdGFYUXRjbVYyWldGc0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9UUUtJQ0FnSUM4dklHTnZibk4wSUhSaGNtZGxkRG9nZFdsdWREWTBJRDBnZEdocGN5NWpiMjF0YVhSVVlYSm5aWFFvWVdOamIzVnVkQ2t1ZG1Gc2RXVUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ2NHOXdDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnNiMjkwWW05NExXTnZiVzFwZEMxeVpYWmxZV3d2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem81TmdvZ0lDQWdMeThnWVhOelpYSjBLRWRzYjJKaGJDNXliM1Z1WkNBK0lIUmhjbWRsZEN3Z0owSmxZV052YmlCeWIzVnVaQ0J1YjNRZ2NtVmhZMmhsWkNCNVpYUW5LUW9nSUNBZ1oyeHZZbUZzSUZKdmRXNWtDaUFnSUNCa2FXY2dNUW9nSUNBZ1Bnb2dJQ0FnWVhOelpYSjBJQzh2SUVKbFlXTnZiaUJ5YjNWdVpDQnViM1FnY21WaFkyaGxaQ0I1WlhRS0lDQWdJQzh2SUd4dmIzUmliM2d0WTI5dGJXbDBMWEpsZG1WaGJDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qazNDaUFnSUNBdkx5QmhjM05sY25Rb1IyeHZZbUZzTG5KdmRXNWtJRHdnZEdGeVoyVjBJQ3NnVWtWV1JVRk1YMWRKVGtSUFYxOVNUMVZPUkZNc0lDZERiMjF0YVhRZ1pYaHdhWEpsWkNEaWdKUWdZMkZzYkNCeVpXTnNZV2x0S0NrZ1lXNWtJSEpsWTI5dGJXbDBKeWtLSUNBZ0lHZHNiMkpoYkNCU2IzVnVaQW9nSUNBZ1pHbG5JREVLSUNBZ0lIQjFjMmhwYm5RZ05EQXdJQzh2SURRd01Bb2dJQ0FnS3dvZ0lDQWdQQW9nSUNBZ1lYTnpaWEowSUM4dklFTnZiVzFwZENCbGVIQnBjbVZrSU9LQWxDQmpZV3hzSUhKbFkyeGhhVzBvS1NCaGJtUWdjbVZqYjIxdGFYUUtJQ0FnSUM4dklHeHZiM1JpYjNndFkyOXRiV2wwTFhKbGRtVmhiQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV3TVFvZ0lDQWdMeThnZEdocGN5NWpiMjF0YVhSVVlYSm5aWFFvWVdOamIzVnVkQ2t1WkdWc1pYUmxLQ2tLSUNBZ0lITjNZWEFLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdMeThnYkc5dmRHSnZlQzFqYjIxdGFYUXRjbVYyWldGc0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UVXhMVEUyTVFvZ0lDQWdMeThnYVhSNGJnb2dJQ0FnTHk4Z0lDQXVZWEJ3YkdsallYUnBiMjVEWVd4c0tIc0tJQ0FnSUM4dklDQWdJQ0JoY0hCSlpEb2dkR2hwY3k1aVpXRmpiMjVCY0hBdWRtRnNkV1VzQ2lBZ0lDQXZMeUFnSUNBZ1lYQndRWEpuY3pvZ1d3b2dJQ0FnTHk4Z0lDQWdJQ0FnWVhKak5DNXRaWFJvYjJSVFpXeGxZM1J2Y2lnbmJYVnpkRjluWlhRb2RXbHVkRFkwTEdKNWRHVmJYU2xpZVhSbFcxMG5LU3dLSUNBZ0lDOHZJQ0FnSUNBZ0lHNWxkeUJoY21NMExsVnBiblEyTkNoeWIzVnVaQ2tzQ2lBZ0lDQXZMeUFnSUNBZ0lDQnVaWGNnWVhKak5DNUVlVzVoYldsalFubDBaWE1vWVdOamIzVnVkQzVpZVhSbGN5a3NDaUFnSUNBdkx5QWdJQ0FnWFN3S0lDQWdJQzh2SUNBZ0lDQm1aV1U2SURBc0NpQWdJQ0F2THlBZ0lIMHBDaUFnSUNBdkx5QWdJQzV6ZFdKdGFYUW9LUzVzWVhOMFRHOW5MQW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnTHk4Z2JHOXZkR0p2ZUMxamIyMXRhWFF0Y21WMlpXRnNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFV6Q2lBZ0lDQXZMeUJoY0hCSlpEb2dkR2hwY3k1aVpXRmpiMjVCY0hBdWRtRnNkV1VzQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNQW9nSUNBZ0x5OGdiRzl2ZEdKdmVDMWpiMjF0YVhRdGNtVjJaV0ZzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRZS0lDQWdJQzh2SUdKbFlXTnZia0Z3Y0NBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9leUJyWlhrNklDZGlaV0ZqYjI0bklIMHBDaUFnSUNCaWVYUmxZeUEwSUM4dklDSmlaV0ZqYjI0aUNpQWdJQ0F2THlCc2IyOTBZbTk0TFdOdmJXMXBkQzF5WlhabFlXd3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOVE1LSUNBZ0lDOHZJR0Z3Y0Vsa09pQjBhR2x6TG1KbFlXTnZia0Z3Y0M1MllXeDFaU3dLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QnNiMjkwWW05NExXTnZiVzFwZEMxeVpYWmxZV3d2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TlRZS0lDQWdJQzh2SUc1bGR5QmhjbU0wTGxWcGJuUTJOQ2h5YjNWdVpDa3NDaUFnSUNCemQyRndDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QnNiMjkwWW05NExXTnZiVzFwZEMxeVpYWmxZV3d2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TlRjS0lDQWdJQzh2SUc1bGR5QmhjbU0wTGtSNWJtRnRhV05DZVhSbGN5aGhZMk52ZFc1MExtSjVkR1Z6S1N3S0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd01qQUtJQ0FnSUdScFp5QXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJR3h2YjNSaWIzZ3RZMjl0YldsMExYSmxkbVZoYkM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMU5Rb2dJQ0FnTHk4Z1lYSmpOQzV0WlhSb2IyUlRaV3hsWTNSdmNpZ25iWFZ6ZEY5blpYUW9kV2x1ZERZMExHSjVkR1ZiWFNsaWVYUmxXMTBuS1N3S0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURRM1l6SXdZekl6SUM4dklHMWxkR2h2WkNBaWJYVnpkRjluWlhRb2RXbHVkRFkwTEdKNWRHVmJYU2xpZVhSbFcxMGlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdaR2xuSURFS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdjM2RoY0FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0F2THlCc2IyOTBZbTk0TFdOdmJXMXBkQzF5WlhabFlXd3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOVEV0TVRZd0NpQWdJQ0F2THlCcGRIaHVDaUFnSUNBdkx5QWdJQzVoY0hCc2FXTmhkR2x2YmtOaGJHd29ld29nSUNBZ0x5OGdJQ0FnSUdGd2NFbGtPaUIwYUdsekxtSmxZV052YmtGd2NDNTJZV3gxWlN3S0lDQWdJQzh2SUNBZ0lDQmhjSEJCY21kek9pQmJDaUFnSUNBdkx5QWdJQ0FnSUNCaGNtTTBMbTFsZEdodlpGTmxiR1ZqZEc5eUtDZHRkWE4wWDJkbGRDaDFhVzUwTmpRc1lubDBaVnRkS1dKNWRHVmJYU2NwTEFvZ0lDQWdMeThnSUNBZ0lDQWdibVYzSUdGeVl6UXVWV2x1ZERZMEtISnZkVzVrS1N3S0lDQWdJQzh2SUNBZ0lDQWdJRzVsZHlCaGNtTTBMa1I1Ym1GdGFXTkNlWFJsY3loaFkyTnZkVzUwTG1KNWRHVnpLU3dLSUNBZ0lDOHZJQ0FnSUNCZExBb2dJQ0FnTHk4Z0lDQWdJR1psWlRvZ01Dd0tJQ0FnSUM4dklDQWdmU2tLSUNBZ0lIQjFjMmhwYm5RZ05pQXZMeUEyQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNBdkx5QnNiMjkwWW05NExXTnZiVzFwZEMxeVpYWmxZV3d2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TlRrS0lDQWdJQzh2SUdabFpUb2dNQ3dLSUNBZ0lHbHVkR05mTWlBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ0x5OGdiRzl2ZEdKdmVDMWpiMjF0YVhRdGNtVjJaV0ZzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRVeExURTJNUW9nSUNBZ0x5OGdhWFI0YmdvZ0lDQWdMeThnSUNBdVlYQndiR2xqWVhScGIyNURZV3hzS0hzS0lDQWdJQzh2SUNBZ0lDQmhjSEJKWkRvZ2RHaHBjeTVpWldGamIyNUJjSEF1ZG1Gc2RXVXNDaUFnSUNBdkx5QWdJQ0FnWVhCd1FYSm5jem9nV3dvZ0lDQWdMeThnSUNBZ0lDQWdZWEpqTkM1dFpYUm9iMlJUWld4bFkzUnZjaWduYlhWemRGOW5aWFFvZFdsdWREWTBMR0o1ZEdWYlhTbGllWFJsVzEwbktTd0tJQ0FnSUM4dklDQWdJQ0FnSUc1bGR5QmhjbU0wTGxWcGJuUTJOQ2h5YjNWdVpDa3NDaUFnSUNBdkx5QWdJQ0FnSUNCdVpYY2dZWEpqTkM1RWVXNWhiV2xqUW5sMFpYTW9ZV05qYjNWdWRDNWllWFJsY3lrc0NpQWdJQ0F2THlBZ0lDQWdYU3dLSUNBZ0lDOHZJQ0FnSUNCbVpXVTZJREFzQ2lBZ0lDQXZMeUFnSUgwcENpQWdJQ0F2THlBZ0lDNXpkV0p0YVhRb0tTNXNZWE4wVEc5bkxBb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJR2wwZUc0Z1RHRnpkRXh2WndvZ0lDQWdMeThnYkc5dmRHSnZlQzFqYjIxdGFYUXRjbVYyWldGc0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UVXdMVEUyTXdvZ0lDQWdMeThnWTI5dWMzUWdkbkptSUQwZ1lYSmpOQzVrWldOdlpHVkJjbU0wUEdKNWRHVnpQaWdLSUNBZ0lDOHZJQ0FnYVhSNGJnb2dJQ0FnTHk4Z0lDQWdJQzVoY0hCc2FXTmhkR2x2YmtOaGJHd29ld29nSUNBZ0x5OGdJQ0FnSUNBZ1lYQndTV1E2SUhSb2FYTXVZbVZoWTI5dVFYQndMblpoYkhWbExBb2dJQ0FnTHk4Z0lDQWdJQ0FnWVhCd1FYSm5jem9nV3dvZ0lDQWdMeThnSUNBZ0lDQWdJQ0JoY21NMExtMWxkR2h2WkZObGJHVmpkRzl5S0NkdGRYTjBYMmRsZENoMWFXNTBOalFzWW5sMFpWdGRLV0o1ZEdWYlhTY3BMQW9nSUNBZ0x5OGdJQ0FnSUNBZ0lDQnVaWGNnWVhKak5DNVZhVzUwTmpRb2NtOTFibVFwTEFvZ0lDQWdMeThnSUNBZ0lDQWdJQ0J1WlhjZ1lYSmpOQzVFZVc1aGJXbGpRbmwwWlhNb1lXTmpiM1Z1ZEM1aWVYUmxjeWtzQ2lBZ0lDQXZMeUFnSUNBZ0lDQmRMQW9nSUNBZ0x5OGdJQ0FnSUNBZ1ptVmxPaUF3TEFvZ0lDQWdMeThnSUNBZ0lIMHBDaUFnSUNBdkx5QWdJQ0FnTG5OMVltMXBkQ2dwTG14aGMzUk1iMmNzQ2lBZ0lDQXZMeUFnSUNkc2IyY25MQW9nSUNBZ0x5OGdLUW9nSUNBZ1pIVndDaUFnSUNCbGVIUnlZV04wSURBZ05Bb2dJQ0FnTHk4Z2JHOXZkR0p2ZUMxamIyMXRhWFF0Y21WMlpXRnNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFl5Q2lBZ0lDQXZMeUFuYkc5bkp5d0tJQ0FnSUdKNWRHVmpJRFVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnTHk4Z2JHOXZkR0p2ZUMxamIyMXRhWFF0Y21WMlpXRnNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFV3TFRFMk13b2dJQ0FnTHk4Z1kyOXVjM1FnZG5KbUlEMGdZWEpqTkM1a1pXTnZaR1ZCY21NMFBHSjVkR1Z6UGlnS0lDQWdJQzh2SUNBZ2FYUjRiZ29nSUNBZ0x5OGdJQ0FnSUM1aGNIQnNhV05oZEdsdmJrTmhiR3dvZXdvZ0lDQWdMeThnSUNBZ0lDQWdZWEJ3U1dRNklIUm9hWE11WW1WaFkyOXVRWEJ3TG5aaGJIVmxMQW9nSUNBZ0x5OGdJQ0FnSUNBZ1lYQndRWEpuY3pvZ1d3b2dJQ0FnTHk4Z0lDQWdJQ0FnSUNCaGNtTTBMbTFsZEdodlpGTmxiR1ZqZEc5eUtDZHRkWE4wWDJkbGRDaDFhVzUwTmpRc1lubDBaVnRkS1dKNWRHVmJYU2NwTEFvZ0lDQWdMeThnSUNBZ0lDQWdJQ0J1WlhjZ1lYSmpOQzVWYVc1ME5qUW9jbTkxYm1RcExBb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNCdVpYY2dZWEpqTkM1RWVXNWhiV2xqUW5sMFpYTW9ZV05qYjNWdWRDNWllWFJsY3lrc0NpQWdJQ0F2THlBZ0lDQWdJQ0JkTEFvZ0lDQWdMeThnSUNBZ0lDQWdabVZsT2lBd0xBb2dJQ0FnTHk4Z0lDQWdJSDBwQ2lBZ0lDQXZMeUFnSUNBZ0xuTjFZbTFwZENncExteGhjM1JNYjJjc0NpQWdJQ0F2THlBZ0lDZHNiMmNuTEFvZ0lDQWdMeThnS1FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkNlWFJsY3lCb1lYTWdkbUZzYVdRZ2NISmxabWw0Q2lBZ0lDQXZMeUJzYjI5MFltOTRMV052YlcxcGRDMXlaWFpsWVd3dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1EUUtJQ0FnSUM4dklHVnRhWFFvYm1WM0lGSmxkbVZoYkdWa0tIc2dZV05qYjNWdWREb2dibVYzSUdGeVl6UXVRV1JrY21WemN5aGhZMk52ZFc1MEtTd2dkR0Z5WjJWME9pQnVaWGNnWVhKak5DNVZhVzUwTmpRb2RHRnlaMlYwS1N3Z2RtRnNkV1U2SUc1bGR5QmhjbU0wTGxWcGJuUTJOQ2h5WVc1a2IyMVdZV3gxWlNrZ2ZTa3BDaUFnSUNCbGVIUnlZV04wSURZZ09Bb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhoaVpEVXhPV1U0T1NBdkx5QnRaWFJvYjJRZ0lsSmxkbVZoYkdWa0tHRmtaSEpsYzNNc2RXbHVkRFkwTEhWcGJuUTJOQ2tpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdMeThnYkc5dmRHSnZlQzFqYjIxdGFYUXRjbVYyWldGc0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9UQUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ1lubDBaV01nTlNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklHeHZiM1JpYjNndFkyOXRiV2wwTFhKbGRtVmhiQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBNYjI5MFFtOTRRMjl0YldsMFVtVjJaV0ZzTG5KbFkyeGhhVzFiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dweVpXTnNZV2x0T2dvZ0lDQWdMeThnYkc5dmRHSnZlQzFqYjIxdGFYUXRjbVYyWldGc0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1URXhDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ0x5OGdiRzl2ZEdKdmVDMWpiMjF0YVhRdGNtVjJaV0ZzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRNS0lDQWdJQzh2SUdOdmJXMXBkRlJoY21kbGRDQTlJRUp2ZUUxaGNEeEJZMk52ZFc1MExDQjFhVzUwTmpRK0tIc2dhMlY1VUhKbFptbDRPaUFuWXljZ2ZTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltTWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJR3h2YjNSaWIzZ3RZMjl0YldsMExYSmxkbVZoYkM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeE13b2dJQ0FnTHk4Z1lYTnpaWEowS0hSb2FYTXVZMjl0YldsMFZHRnlaMlYwS0dGalkyOTFiblFwTG1WNGFYTjBjeXdnSjA1dklHTnZiVzFwZENCMGJ5QnlaV05zWVdsdEp5a0tJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmhjM05sY25RZ0x5OGdUbThnWTI5dGJXbDBJSFJ2SUhKbFkyeGhhVzBLSUNBZ0lDOHZJR3h2YjNSaWIzZ3RZMjl0YldsMExYSmxkbVZoYkM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeE5Bb2dJQ0FnTHk4Z1kyOXVjM1FnZEdGeVoyVjBJRDBnZEdocGN5NWpiMjF0YVhSVVlYSm5aWFFvWVdOamIzVnVkQ2t1ZG1Gc2RXVUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ2NHOXdDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnNiMjkwWW05NExXTnZiVzFwZEMxeVpYWmxZV3d2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TVRVS0lDQWdJQzh2SUdGemMyVnlkQ2hIYkc5aVlXd3VjbTkxYm1RZ1BqMGdkR0Z5WjJWMElDc2dVa1ZXUlVGTVgxZEpUa1JQVjE5U1QxVk9SRk1zSUNkRGIyMXRhWFFnYUdGeklHNXZkQ0JsZUhCcGNtVmtJSGxsZENjcENpQWdJQ0JuYkc5aVlXd2dVbTkxYm1RS0lDQWdJSE4zWVhBS0lDQWdJSEIxYzJocGJuUWdOREF3SUM4dklEUXdNQW9nSUNBZ0t3b2dJQ0FnUGowS0lDQWdJR0Z6YzJWeWRDQXZMeUJEYjIxdGFYUWdhR0Z6SUc1dmRDQmxlSEJwY21Wa0lIbGxkQW9nSUNBZ0x5OGdiRzl2ZEdKdmVDMWpiMjF0YVhRdGNtVjJaV0ZzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRFMkNpQWdJQ0F2THlCMGFHbHpMbU52YlcxcGRGUmhjbWRsZENoaFkyTnZkVzUwS1M1a1pXeGxkR1VvS1FvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0F2THlCc2IyOTBZbTk0TFdOdmJXMXBkQzF5WlhabFlXd3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNVEVLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJR3h2YjNSaWIzZ3RZMjl0YldsMExYSmxkbVZoYkM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwTWIyOTBRbTk0UTI5dGJXbDBVbVYyWldGc0xuZHBkR2hrY21GM1czSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkMmwwYUdSeVlYYzZDaUFnSUNBdkx5QnNiMjkwWW05NExXTnZiVzFwZEMxeVpYWmxZV3d2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TWpFS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdiRzl2ZEdKdmVDMWpiMjF0YVhRdGNtVjJaV0ZzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRJekNpQWdJQ0F2THlCaGMzTmxjblFvVkhodUxuTmxibVJsY2lBOVBUMGdSMnh2WW1Gc0xtTnlaV0YwYjNKQlpHUnlaWE56TENBblQyNXNlU0IwYUdVZ1kzSmxZWFJ2Y2lCallXNGdkMmwwYUdSeVlYY25LUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWjJ4dlltRnNJRU55WldGMGIzSkJaR1J5WlhOekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRTl1YkhrZ2RHaGxJR055WldGMGIzSWdZMkZ1SUhkcGRHaGtjbUYzQ2lBZ0lDQXZMeUJzYjI5MFltOTRMV052YlcxcGRDMXlaWFpsWVd3dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1qUUtJQ0FnSUM4dklHbDBlRzR1Y0dGNWJXVnVkQ2g3SUhKbFkyVnBkbVZ5T2lCSGJHOWlZV3d1WTNKbFlYUnZja0ZrWkhKbGMzTXNJR0Z0YjNWdWREb2dZVzF2ZFc1MExDQm1aV1U2SURBZ2ZTa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJR2RzYjJKaGJDQkRjbVZoZEc5eVFXUmtjbVZ6Y3dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JTWldObGFYWmxjZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJiVzkxYm5RS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0F2THlCc2IyOTBZbTk0TFdOdmJXMXBkQzF5WlhabFlXd3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNakVLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJR3h2YjNSaWIzZ3RZMjl0YldsMExYSmxkbVZoYkM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwTWIyOTBRbTk0UTI5dGJXbDBVbVYyWldGc0xuTmxkRU52Ym1acFp5aDBjbVZoYzNWeWVUb2dZbmwwWlhNc0lIQnlhV05sT2lCMWFXNTBOalFzSUdKbFlXTnZia0Z3Y0RvZ2RXbHVkRFkwTENCaVpXRmpiMjVEWVdSbGJtTmxPaUIxYVc1ME5qUXBJQzArSUhadmFXUTZDbk5sZEVOdmJtWnBaem9LSUNBZ0lDOHZJR3h2YjNSaWIzZ3RZMjl0YldsMExYSmxkbVZoYkM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeU9Rb2dJQ0FnTHk4Z2NISnBkbUYwWlNCelpYUkRiMjVtYVdjb2RISmxZWE4xY25rNklFRmpZMjkxYm5Rc0lIQnlhV05sT2lCMWFXNTBOalFzSUdKbFlXTnZia0Z3Y0RvZ2RXbHVkRFkwTENCaVpXRmpiMjVEWVdSbGJtTmxPaUIxYVc1ME5qUXBPaUIyYjJsa0lIc0tJQ0FnSUhCeWIzUnZJRFFnTUFvZ0lDQWdMeThnYkc5dmRHSnZlQzFqYjIxdGFYUXRjbVYyWldGc0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UTXdDaUFnSUNBdkx5QmhjM05sY25Rb2NISnBZMlVnUGlCVmFXNTBOalFvTUNrc0lDZERjbUYwWlNCd2NtbGpaU0J0ZFhOMElHSmxJSEJ2YzJsMGFYWmxKeWtLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1lYTnpaWEowSUM4dklFTnlZWFJsSUhCeWFXTmxJRzExYzNRZ1ltVWdjRzl6YVhScGRtVUtJQ0FnSUM4dklHeHZiM1JpYjNndFkyOXRiV2wwTFhKbGRtVmhiQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV6TVFvZ0lDQWdMeThnWVhOelpYSjBLR0psWVdOdmJrRndjQ0ErSUZWcGJuUTJOQ2d3S1N3Z0owSmxZV052YmlCaGNIQWdhV1FnYVhNZ2NtVnhkV2x5WldRbktRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JoYzNObGNuUWdMeThnUW1WaFkyOXVJR0Z3Y0NCcFpDQnBjeUJ5WlhGMWFYSmxaQW9nSUNBZ0x5OGdiRzl2ZEdKdmVDMWpiMjF0YVhRdGNtVjJaV0ZzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRNeUNpQWdJQ0F2THlCaGMzTmxjblFvWW1WaFkyOXVRMkZrWlc1alpTQStJRlZwYm5RMk5DZ3dLU3dnSjBKbFlXTnZiaUJqWVdSbGJtTmxJRzExYzNRZ1ltVWdjRzl6YVhScGRtVW5LUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaGMzTmxjblFnTHk4Z1FtVmhZMjl1SUdOaFpHVnVZMlVnYlhWemRDQmlaU0J3YjNOcGRHbDJaUW9nSUNBZ0x5OGdiRzl2ZEdKdmVDMWpiMjF0YVhRdGNtVjJaV0ZzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRRS0lDQWdJQzh2SUhSeVpXRnpkWEo1UVdSa2NtVnpjeUE5SUVkc2IySmhiRk4wWVhSbFBFRmpZMjkxYm5RK0tIc2dhMlY1T2lBbmRISmxZWE4xY25rbklIMHBDaUFnSUNCaWVYUmxZMTh4SUM4dklDSjBjbVZoYzNWeWVTSUtJQ0FnSUM4dklHeHZiM1JpYjNndFkyOXRiV2wwTFhKbGRtVmhiQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV6TXdvZ0lDQWdMeThnZEdocGN5NTBjbVZoYzNWeWVVRmtaSEpsYzNNdWRtRnNkV1VnUFNCMGNtVmhjM1Z5ZVFvZ0lDQWdabkpoYldWZlpHbG5JQzAwQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYkc5dmRHSnZlQzFqYjIxdGFYUXRjbVYyWldGc0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5UVUtJQ0FnSUM4dklHTnlZWFJsVUhKcFkyVWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0hzZ2EyVjVPaUFuY0hKcFkyVW5JSDBwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0p3Y21salpTSUtJQ0FnSUM4dklHeHZiM1JpYjNndFkyOXRiV2wwTFhKbGRtVmhiQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV6TkFvZ0lDQWdMeThnZEdocGN5NWpjbUYwWlZCeWFXTmxMblpoYkhWbElEMGdjSEpwWTJVS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUd4dmIzUmliM2d0WTI5dGJXbDBMWEpsZG1WaGJDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVTJDaUFnSUNBdkx5QmlaV0ZqYjI1QmNIQWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0hzZ2EyVjVPaUFuWW1WaFkyOXVKeUI5S1FvZ0lDQWdZbmwwWldNZ05DQXZMeUFpWW1WaFkyOXVJZ29nSUNBZ0x5OGdiRzl2ZEdKdmVDMWpiMjF0YVhRdGNtVjJaV0ZzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRNMUNpQWdJQ0F2THlCMGFHbHpMbUpsWVdOdmJrRndjQzUyWVd4MVpTQTlJR0psWVdOdmJrRndjQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdiRzl2ZEdKdmVDMWpiMjF0YVhRdGNtVjJaV0ZzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRjS0lDQWdJQzh2SUdKbFlXTnZia05oWkdWdVkyVWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0hzZ2EyVjVPaUFuWTJGa1pXNWpaU2NnZlNrS0lDQWdJR0o1ZEdWalh6TWdMeThnSW1OaFpHVnVZMlVpQ2lBZ0lDQXZMeUJzYjI5MFltOTRMV052YlcxcGRDMXlaWFpsWVd3dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE16WUtJQ0FnSUM4dklIUm9hWE11WW1WaFkyOXVRMkZrWlc1alpTNTJZV3gxWlNBOUlHSmxZV052YmtOaFpHVnVZMlVLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lISmxkSE4xWWdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFRZ0FJQ1lHQVdNSWRISmxZWE4xY25rRmNISnBZMlVIWTJGa1pXNWpaUVppWldGamIyNEVGUjk4ZFRFWkZFUXhHRUVBSzRJRkJHZGxLOEFFSjZOWTJ3UjFEc20xQkhycDZVTUVJZkhkL3pZYUFJNEZBRGNBWlFDMUFTSUJRd0NBQkxnZUJkbzJHZ0NPQVFBQkFEWWFBVWtWSlJKRU5ob0NTUlVqRWtRWE5ob0RTUlVqRWtRWE5ob0VTUlVqRWtRWGlBRXRJa00yR2dGSkZTVVNSRFlhQWtrVkl4SkVGellhQTBrVkl4SkVGellhQkVrVkl4SkVGekVBTWdrU1JJZ0EveUpETVJZaUNVazRFQ0lTUkRFQVN3RTRCeVFwWlVRU1JFc0JPQWdrS21WRUQwUk1PQUJMQVJKRUtFc0JVRW05UlFFVVJESUdKQ3RsUkV4TEFRcUJBZ2dMRmt4TEFiOVFnQVF6UW1aelRGQ3dJa014QUNoTEFWQkp2VVVCUkVtK1NCY3lCa3NCRFVReUJrc0JnWkFEQ0F4RVRMeElzU1FuQkdWRVRCYUFBZ0FnU3dOUWdBUkh3Z3dqc2hwTEFiSWFzaHBNc2hpQkJySVFKTElCczdRK1NWY0FCQ2NGRWtSWEJnaE9BbEJMQVZDQUJMMVJub2xNVUxBbkJVeFFzQ0pETmhvQlNSVWxFa1FvVEZCSnZVVUJSRW0rU0JjeUJreUJrQU1JRDBTOFNDSkROaG9CU1JVakVrUVhNUUF5Q1JKRXNUSUpzZ2V5Q0NLeUVDU3lBYk1pUTRvRUFJdjlSSXYrUkl2L1JDbUwvR2NxaS8xbkp3U0wvbWNyaS85bmlRPT0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjozLCJwYXRjaCI6MiwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOlt7Im5hbWUiOiJDb21taXR0ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjY291bnQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0YXJnZXQiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IlJldmVhbGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2NvdW50IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidGFyZ2V0IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsfV19XSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
