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

namespace Arc56.Generated.m_faran.trust_vault.TrustVault_3ccf51b1
{


    //
    // 
    //    Trust Vault - A decentralized vault system for fund inheritance.
    //    
    //    Roles:
    //    - Vault User: Locks funds in a vault, sets up heir, sends heartbeats (must opt-in)
    //    - Heir: Inherits funds after vault user's inactivity period (no opt-in required)
    //    
    //    Storage Strategy:
    //    - Local State: Vault configuration (heir, interval, last heartbeat) - per vault owner
    //    - Box Storage: Vault balances and vault owners tracking - no opt-in required
    //    - Global State: Application-level counters (total vaults)
    //    
    //
    public class TrustVaultProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public TrustVaultProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class GetVaultInfoReturn : AVMObjectType
            {
                public Algorand.Address Field0 { get; set; }

                public ulong Field1 { get; set; }

                public ulong Field2 { get; set; }

                public ulong Field3 { get; set; }

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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField3.From(Field3);
                    ret.AddRange(vField3.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static GetVaultInfoReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetVaultInfoReturn();
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField3 = vField3.ToValue();
                    if (valueField3 is ulong vField3Value) { ret.Field3 = vField3Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetVaultInfoReturn);
                }
                public bool Equals(GetVaultInfoReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetVaultInfoReturn left, GetVaultInfoReturn right)
                {
                    return EqualityComparer<GetVaultInfoReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetVaultInfoReturn left, GetVaultInfoReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Set up a vault with an heir address.
        ///Vault User must opt-in to the application first (creates local state). Initial deposit can be made via payment transaction in the same group or separately.
        ///</summary>
        /// <param name="heir">The trusted address (Heir) that will inherit funds after inactivity period </param>
        /// <param name="heartbeat_interval">Time in seconds before funds can be claimed (3 months to 1 year) </param>
        public async Task SetupVault(Algorand.Address heir, ulong heartbeat_interval, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 141, 140, 163, 202 };
            var heirAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); heirAbi.From(heir);
            var heartbeat_intervalAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); heartbeat_intervalAbi.From(heartbeat_interval);

            var result = await base.CallApp(new List<object> { abiHandle, heirAbi, heartbeat_intervalAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetupVault_Transactions(Algorand.Address heir, ulong heartbeat_interval, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 141, 140, 163, 202 };
            var heirAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); heirAbi.From(heir);
            var heartbeat_intervalAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); heartbeat_intervalAbi.From(heartbeat_interval);

            return await base.MakeTransactionList(new List<object> { abiHandle, heirAbi, heartbeat_intervalAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Deposit funds into an existing vault.
        ///Vault User must send a payment transaction in the same transaction group. The payment must be from the vault owner to the contract address.
        ///Payment transaction is verified: - payment.sender == vault_owner (Txn.sender) - payment.receiver == Global.current_application_address - payment.amount > 0
        ///</summary>
        /// <param name="payment">Payment transaction from the transaction group (must be gtxn[i] where i is the payment transaction index) </param>
        public async Task DepositFunds(PaymentTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 253, 198, 149, 194 };

            var result = await base.CallApp(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DepositFunds_Transactions(PaymentTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 253, 198, 149, 194 };

            return await base.MakeTransactionList(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Update the heir address for an existing vault.
        ///Only the Vault User (vault owner) can update their heir.
        ///</summary>
        /// <param name="new_heir">New trusted address (Heir) to inherit funds </param>
        public async Task UpdateHeir(Algorand.Address new_heir, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 233, 230, 223, 162 };
            var new_heirAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); new_heirAbi.From(new_heir);

            var result = await base.CallApp(new List<object> { abiHandle, new_heirAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateHeir_Transactions(Algorand.Address new_heir, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 233, 230, 223, 162 };
            var new_heirAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); new_heirAbi.From(new_heir);

            return await base.MakeTransactionList(new List<object> { abiHandle, new_heirAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Update the heartbeat interval for an existing vault.
        ///Only the Vault User can update their heartbeat interval.
        ///</summary>
        /// <param name="new_interval">New heartbeat interval in seconds (3 months to 1 year) </param>
        public async Task UpdateHeartbeatInterval(ulong new_interval, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 88, 140, 115, 9 };
            var new_intervalAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); new_intervalAbi.From(new_interval);

            var result = await base.CallApp(new List<object> { abiHandle, new_intervalAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateHeartbeatInterval_Transactions(ulong new_interval, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 88, 140, 115, 9 };
            var new_intervalAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); new_intervalAbi.From(new_interval);

            return await base.MakeTransactionList(new List<object> { abiHandle, new_intervalAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Update the last heartbeat timestamp to indicate Vault User activity.
        ///This resets the inactivity timer and prevents funds from being transferred to the Heir. Only the Vault User can send heartbeats.
        ///</summary>
        public async Task Heartbeat(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 72, 147, 67, 93 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Heartbeat_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 72, 147, 67, 93 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Transfer funds to the Heir if the Vault User has been inactive beyond the heartbeat interval.
        ///Only the designated Heir can claim funds for a specific vault. This can be called by anyone, but only the Heir will receive the funds.
        ///</summary>
        /// <param name="vault_owner">The Vault User account whose vault funds should be claimed </param>
        public async Task ClaimFunds(Algorand.Address vault_owner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 178, 5, 185, 198 };
            var vault_ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); vault_ownerAbi.From(vault_owner);

            var result = await base.CallApp(new List<object> { abiHandle, vault_ownerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ClaimFunds_Transactions(Algorand.Address vault_owner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 178, 5, 185, 198 };
            var vault_ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); vault_ownerAbi.From(vault_owner);

            return await base.MakeTransactionList(new List<object> { abiHandle, vault_ownerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Allow the Vault User to withdraw funds from their vault.
        ///Only the Vault User (vault owner) can withdraw their funds.
        ///</summary>
        /// <param name="amount">Amount to withdraw from the vault </param>
        public async Task WithdrawFunds(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 186, 144, 171, 84 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> WithdrawFunds_Transactions(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 186, 144, 171, 84 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get vault information for a Vault User.
        ///Can be called by anyone to query vault information.
        ///</summary>
        /// <param name="vault_owner">The Vault User account to query vault information for </param>
        public async Task<Structs.GetVaultInfoReturn> GetVaultInfo(Algorand.Address vault_owner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 85, 34, 98, 59 };
            var vault_ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); vault_ownerAbi.From(vault_owner);

            var result = await base.CallApp(new List<object> { abiHandle, vault_ownerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetVaultInfoReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetVaultInfo_Transactions(Algorand.Address vault_owner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 85, 34, 98, 59 };
            var vault_ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); vault_ownerAbi.From(vault_owner);

            return await base.MakeTransactionList(new List<object> { abiHandle, vault_ownerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get the total number of active vaults.
        ///</summary>
        public async Task<ulong> GetTotalVaults(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 163, 252, 122, 205 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetTotalVaults_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 163, 252, 122, 205 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiVHJ1c3RWYXVsdCIsImRlc2MiOiJcbiAgICBUcnVzdCBWYXVsdCAtIEEgZGVjZW50cmFsaXplZCB2YXVsdCBzeXN0ZW0gZm9yIGZ1bmQgaW5oZXJpdGFuY2UuXG4gICAgXG4gICAgUm9sZXM6XG4gICAgLSBWYXVsdCBVc2VyOiBMb2NrcyBmdW5kcyBpbiBhIHZhdWx0LCBzZXRzIHVwIGhlaXIsIHNlbmRzIGhlYXJ0YmVhdHMgKG11c3Qgb3B0LWluKVxuICAgIC0gSGVpcjogSW5oZXJpdHMgZnVuZHMgYWZ0ZXIgdmF1bHQgdXNlcidzIGluYWN0aXZpdHkgcGVyaW9kIChubyBvcHQtaW4gcmVxdWlyZWQpXG4gICAgXG4gICAgU3RvcmFnZSBTdHJhdGVneTpcbiAgICAtIExvY2FsIFN0YXRlOiBWYXVsdCBjb25maWd1cmF0aW9uIChoZWlyLCBpbnRlcnZhbCwgbGFzdCBoZWFydGJlYXQpIC0gcGVyIHZhdWx0IG93bmVyXG4gICAgLSBCb3ggU3RvcmFnZTogVmF1bHQgYmFsYW5jZXMgYW5kIHZhdWx0IG93bmVycyB0cmFja2luZyAtIG5vIG9wdC1pbiByZXF1aXJlZFxuICAgIC0gR2xvYmFsIFN0YXRlOiBBcHBsaWNhdGlvbi1sZXZlbCBjb3VudGVycyAodG90YWwgdmF1bHRzKVxuICAgICIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJHZXRWYXVsdEluZm9SZXR1cm4iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDIiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQzIiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJzZXR1cF92YXVsdCIsImRlc2MiOiJTZXQgdXAgYSB2YXVsdCB3aXRoIGFuIGhlaXIgYWRkcmVzcy5cblZhdWx0IFVzZXIgbXVzdCBvcHQtaW4gdG8gdGhlIGFwcGxpY2F0aW9uIGZpcnN0IChjcmVhdGVzIGxvY2FsIHN0YXRlKS4gSW5pdGlhbCBkZXBvc2l0IGNhbiBiZSBtYWRlIHZpYSBwYXltZW50IHRyYW5zYWN0aW9uIGluIHRoZSBzYW1lIGdyb3VwIG9yIHNlcGFyYXRlbHkuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJoZWlyIiwiZGVzYyI6IlRoZSB0cnVzdGVkIGFkZHJlc3MgKEhlaXIpIHRoYXQgd2lsbCBpbmhlcml0IGZ1bmRzIGFmdGVyIGluYWN0aXZpdHkgcGVyaW9kIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJoZWFydGJlYXRfaW50ZXJ2YWwiLCJkZXNjIjoiVGltZSBpbiBzZWNvbmRzIGJlZm9yZSBmdW5kcyBjYW4gYmUgY2xhaW1lZCAoMyBtb250aHMgdG8gMSB5ZWFyKSIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJkZXBvc2l0X2Z1bmRzIiwiZGVzYyI6IkRlcG9zaXQgZnVuZHMgaW50byBhbiBleGlzdGluZyB2YXVsdC5cblZhdWx0IFVzZXIgbXVzdCBzZW5kIGEgcGF5bWVudCB0cmFuc2FjdGlvbiBpbiB0aGUgc2FtZSB0cmFuc2FjdGlvbiBncm91cC4gVGhlIHBheW1lbnQgbXVzdCBiZSBmcm9tIHRoZSB2YXVsdCBvd25lciB0byB0aGUgY29udHJhY3QgYWRkcmVzcy5cblBheW1lbnQgdHJhbnNhY3Rpb24gaXMgdmVyaWZpZWQ6IC0gcGF5bWVudC5zZW5kZXIgPT0gdmF1bHRfb3duZXIgKFR4bi5zZW5kZXIpIC0gcGF5bWVudC5yZWNlaXZlciA9PSBHbG9iYWwuY3VycmVudF9hcHBsaWNhdGlvbl9hZGRyZXNzIC0gcGF5bWVudC5hbW91bnQgPiAwIiwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheW1lbnQiLCJkZXNjIjoiUGF5bWVudCB0cmFuc2FjdGlvbiBmcm9tIHRoZSB0cmFuc2FjdGlvbiBncm91cCAobXVzdCBiZSBndHhuW2ldIHdoZXJlIGkgaXMgdGhlIHBheW1lbnQgdHJhbnNhY3Rpb24gaW5kZXgpIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InVwZGF0ZV9oZWlyIiwiZGVzYyI6IlVwZGF0ZSB0aGUgaGVpciBhZGRyZXNzIGZvciBhbiBleGlzdGluZyB2YXVsdC5cbk9ubHkgdGhlIFZhdWx0IFVzZXIgKHZhdWx0IG93bmVyKSBjYW4gdXBkYXRlIHRoZWlyIGhlaXIuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdfaGVpciIsImRlc2MiOiJOZXcgdHJ1c3RlZCBhZGRyZXNzIChIZWlyKSB0byBpbmhlcml0IGZ1bmRzIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InVwZGF0ZV9oZWFydGJlYXRfaW50ZXJ2YWwiLCJkZXNjIjoiVXBkYXRlIHRoZSBoZWFydGJlYXQgaW50ZXJ2YWwgZm9yIGFuIGV4aXN0aW5nIHZhdWx0LlxuT25seSB0aGUgVmF1bHQgVXNlciBjYW4gdXBkYXRlIHRoZWlyIGhlYXJ0YmVhdCBpbnRlcnZhbC4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3X2ludGVydmFsIiwiZGVzYyI6Ik5ldyBoZWFydGJlYXQgaW50ZXJ2YWwgaW4gc2Vjb25kcyAoMyBtb250aHMgdG8gMSB5ZWFyKSIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJoZWFydGJlYXQiLCJkZXNjIjoiVXBkYXRlIHRoZSBsYXN0IGhlYXJ0YmVhdCB0aW1lc3RhbXAgdG8gaW5kaWNhdGUgVmF1bHQgVXNlciBhY3Rpdml0eS5cblRoaXMgcmVzZXRzIHRoZSBpbmFjdGl2aXR5IHRpbWVyIGFuZCBwcmV2ZW50cyBmdW5kcyBmcm9tIGJlaW5nIHRyYW5zZmVycmVkIHRvIHRoZSBIZWlyLiBPbmx5IHRoZSBWYXVsdCBVc2VyIGNhbiBzZW5kIGhlYXJ0YmVhdHMuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNsYWltX2Z1bmRzIiwiZGVzYyI6IlRyYW5zZmVyIGZ1bmRzIHRvIHRoZSBIZWlyIGlmIHRoZSBWYXVsdCBVc2VyIGhhcyBiZWVuIGluYWN0aXZlIGJleW9uZCB0aGUgaGVhcnRiZWF0IGludGVydmFsLlxuT25seSB0aGUgZGVzaWduYXRlZCBIZWlyIGNhbiBjbGFpbSBmdW5kcyBmb3IgYSBzcGVjaWZpYyB2YXVsdC4gVGhpcyBjYW4gYmUgY2FsbGVkIGJ5IGFueW9uZSwgYnV0IG9ubHkgdGhlIEhlaXIgd2lsbCByZWNlaXZlIHRoZSBmdW5kcy4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhdWx0X293bmVyIiwiZGVzYyI6IlRoZSBWYXVsdCBVc2VyIGFjY291bnQgd2hvc2UgdmF1bHQgZnVuZHMgc2hvdWxkIGJlIGNsYWltZWQiLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoid2l0aGRyYXdfZnVuZHMiLCJkZXNjIjoiQWxsb3cgdGhlIFZhdWx0IFVzZXIgdG8gd2l0aGRyYXcgZnVuZHMgZnJvbSB0aGVpciB2YXVsdC5cbk9ubHkgdGhlIFZhdWx0IFVzZXIgKHZhdWx0IG93bmVyKSBjYW4gd2l0aGRyYXcgdGhlaXIgZnVuZHMuIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOiJBbW91bnQgdG8gd2l0aGRyYXcgZnJvbSB0aGUgdmF1bHQiLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3ZhdWx0X2luZm8iLCJkZXNjIjoiR2V0IHZhdWx0IGluZm9ybWF0aW9uIGZvciBhIFZhdWx0IFVzZXIuXG5DYW4gYmUgY2FsbGVkIGJ5IGFueW9uZSB0byBxdWVyeSB2YXVsdCBpbmZvcm1hdGlvbi4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhdWx0X293bmVyIiwiZGVzYyI6IlRoZSBWYXVsdCBVc2VyIGFjY291bnQgdG8gcXVlcnkgdmF1bHQgaW5mb3JtYXRpb24gZm9yIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6IihhZGRyZXNzLHVpbnQ2NCx1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IkdldFZhdWx0SW5mb1JldHVybiIsImRlc2MiOiJUdXBsZSBvZiAoaGVpcl9hZGRyZXNzLCBsYXN0X2hlYXJ0YmVhdF90aW1lc3RhbXAsIGhlYXJ0YmVhdF9pbnRlcnZhbCwgdmF1bHRfYmFsYW5jZSkifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfdG90YWxfdmF1bHRzIiwiZGVzYyI6IkdldCB0aGUgdG90YWwgbnVtYmVyIG9mIGFjdGl2ZSB2YXVsdHMuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IlRvdGFsIG51bWJlciBvZiBhY3RpdmUgdmF1bHRzIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjEsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MiwiYnl0ZXMiOjF9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls1NDVdLCJlcnJvck1lc3NhZ2UiOiJBbW91bnQgbXVzdCBiZSBncmVhdGVyIHRoYW4gemVybyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ0Ml0sImVycm9yTWVzc2FnZSI6IkhlYXJ0YmVhdCBkYXRhIG1pc3NpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxOTIsMzY3XSwiZXJyb3JNZXNzYWdlIjoiSGVhcnRiZWF0IGludGVydmFsIHRvbyBsb25nIChtYXggMSB5ZWFyKSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE4NywzNjJdLCJlcnJvck1lc3NhZ2UiOiJIZWFydGJlYXQgaW50ZXJ2YWwgdG9vIHNob3J0IChtaW4gMyBtb250aHMpIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDc3XSwiZXJyb3JNZXNzYWdlIjoiSW5hY3Rpdml0eSBwZXJpb2Qgbm90IHlldCByZWFjaGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTgxXSwiZXJyb3JNZXNzYWdlIjoiSW5zdWZmaWNpZW50IGJhbGFuY2UgaW4gdmF1bHQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NDhdLCJlcnJvck1lc3NhZ2UiOiJJbnRlcnZhbCBkYXRhIG1pc3NpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NzldLCJlcnJvck1lc3NhZ2UiOiJObyBmdW5kcyB0byB0cmFuc2ZlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzgxXSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2M10sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBtdXN0IGJlIE5vT3AgJiYgY2FuIG9ubHkgY2FsbCB3aGVuIGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDY4XSwiZXJyb3JNZXNzYWdlIjoiT25seSB0aGUgZGVzaWduYXRlZCBoZWlyIGNhbiBjbGFpbSBmdW5kcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMwM10sImVycm9yTWVzc2FnZSI6IlBheW1lbnQgYW1vdW50IG11c3QgYmUgZ3JlYXRlciB0aGFuIHplcm8iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyOTBdLCJlcnJvck1lc3NhZ2UiOiJQYXltZW50IG11c3QgYmUgZnJvbSB2YXVsdCBvd25lciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI5OF0sImVycm9yTWVzc2FnZSI6IlBheW1lbnQgbXVzdCBiZSB0byBjb250cmFjdCBhZGRyZXNzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjA5XSwiZXJyb3JNZXNzYWdlIjoiVmF1bHQgYWxyZWFkeSBleGlzdHMgZm9yIHRoaXMgdXNlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ1OCw1NzJdLCJlcnJvck1lc3NhZ2UiOiJWYXVsdCBiYWxhbmNlIG5vdCBmb3VuZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM4NCw0MDcsNDM2LDU2Miw2MzBdLCJlcnJvck1lc3NhZ2UiOiJWYXVsdCBjb25maWd1cmF0aW9uIG5vdCBmb3VuZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMzNywzNzcsNDAwLDU1NV0sImVycm9yTWVzc2FnZSI6IlZhdWx0IGRvZXMgbm90IGV4aXN0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDMwLDYyMl0sImVycm9yTWVzc2FnZSI6IlZhdWx0IGRvZXMgbm90IGV4aXN0IGZvciB0aGlzIHVzZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyODJdLCJlcnJvck1lc3NhZ2UiOiJWYXVsdCBkb2VzIG5vdCBleGlzdC4gQ2FsbCBzZXR1cF92YXVsdCBmaXJzdCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE5OSwzNDJdLCJlcnJvck1lc3NhZ2UiOiJWYXVsdCBvd25lciBjYW5ub3QgYmUgdGhlaXIgb3duIGhlaXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2NDZdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmhlYXJ0YmVhdF9pbnRlcnZhbCBleGlzdHMgZm9yIGFjY291bnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MzhdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmxhc3RfaGVhcnRiZWF0IGV4aXN0cyBmb3IgYWNjb3VudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMxMSw2NjBdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnZhdWx0X2JhbGFuY2VzIGVudHJ5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE3MywzMjcsNDIxLDYxNF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxODEsMzU2LDU0Ml0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI3Ml0sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgcGF5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBeElEQWdNeklnT0NBM056YzJNREF3SURNeE5UTTJNREF3Q2lBZ0lDQmllWFJsWTJKc2IyTnJJREI0Tm1ZM056WmxOalUzTWpWbUlDSm9aV2x5SWlBaWFXNTBaWEoyWVd3aUlDSnNZWE4wWDJoaUlpQWlkRzkwWVd4ZmRtRjFiSFJ6SWlBd2VEWXlOakUyWXpZeE5tVTJNelkxTldZZ01IZ3hOVEZtTjJNM05Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSeWRYTjBYM1poZFd4MEwyTnZiblJ5WVdOMExuQjVPamtLSUNBZ0lDOHZJR05zWVhOeklGUnlkWE4wVm1GMWJIUW9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0JpZWlCdFlXbHVYMTlmWVd4bmIzQjVYMlJsWm1GMWJIUmZZM0psWVhSbFFERTRDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJRzExYzNRZ1ltVWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2NIVnphR0o1ZEdWemN5QXdlRGhrT0dOaE0yTmhJREI0Wm1Sak5qazFZeklnTUhobE9XVTJaR1poTWlBd2VEVTRPR00zTXpBNUlEQjRORGc1TXpRek5XUWdNSGhpTWpBMVlqbGpOaUF3ZUdKaE9UQmhZalUwSURCNE5UVXlNall5TTJJZ01IaGhNMlpqTjJGalpDQXZMeUJ0WlhSb2IyUWdJbk5sZEhWd1gzWmhkV3gwS0dGa1pISmxjM01zZFdsdWREWTBLWFp2YVdRaUxDQnRaWFJvYjJRZ0ltUmxjRzl6YVhSZlpuVnVaSE1vY0dGNUtYWnZhV1FpTENCdFpYUm9iMlFnSW5Wd1pHRjBaVjlvWldseUtHRmtaSEpsYzNNcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpZFhCa1lYUmxYMmhsWVhKMFltVmhkRjlwYm5SbGNuWmhiQ2gxYVc1ME5qUXBkbTlwWkNJc0lHMWxkR2h2WkNBaWFHVmhjblJpWldGMEtDbDJiMmxrSWl3Z2JXVjBhRzlrSUNKamJHRnBiVjltZFc1a2N5aGhaR1J5WlhOektYWnZhV1FpTENCdFpYUm9iMlFnSW5kcGRHaGtjbUYzWDJaMWJtUnpLSFZwYm5RMk5DbDJiMmxrSWl3Z2JXVjBhRzlrSUNKblpYUmZkbUYxYkhSZmFXNW1ieWhoWkdSeVpYTnpLU2hoWkdSeVpYTnpMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwS1NJc0lHMWxkR2h2WkNBaVoyVjBYM1J2ZEdGc1gzWmhkV3gwY3lncGRXbHVkRFkwSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ2MyVjBkWEJmZG1GMWJIUWdaR1Z3YjNOcGRGOW1kVzVrY3lCMWNHUmhkR1ZmYUdWcGNpQjFjR1JoZEdWZmFHVmhjblJpWldGMFgybHVkR1Z5ZG1Gc0lHaGxZWEowWW1WaGRDQmpiR0ZwYlY5bWRXNWtjeUIzYVhSb1pISmhkMTltZFc1a2N5Qm5aWFJmZG1GMWJIUmZhVzVtYnlCblpYUmZkRzkwWVd4ZmRtRjFiSFJ6Q2lBZ0lDQmxjbklLQ20xaGFXNWZYMTloYkdkdmNIbGZaR1ZtWVhWc2RGOWpjbVZoZEdWQU1UZzZDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdJUW9nSUNBZ0ppWUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdiWFZ6ZENCaVpTQk9iMDl3SUNZbUlHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQmpjbVZoZEdsdVp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTUwY25WemRGOTJZWFZzZEM1amIyNTBjbUZqZEM1VWNuVnpkRlpoZFd4MExuTmxkSFZ3WDNaaGRXeDBXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYzJWMGRYQmZkbUYxYkhRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKMWMzUmZkbUYxYkhRdlkyOXVkSEpoWTNRdWNIazZORE1LSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKMWMzUmZkbUYxYkhRdlkyOXVkSEpoWTNRdWNIazZOVGd0TlRrS0lDQWdJQzh2SUNNZ1ZtRnNhV1JoZEdVZ2FHVmhjblJpWldGMElHbHVkR1Z5ZG1Gc0lHbHpJSGRwZEdocGJpQmhiR3h2ZDJWa0lISmhibWRsSUNneklHMXZiblJvY3lCMGJ5QXhJSGxsWVhJcENpQWdJQ0F2THlCaGMzTmxjblFnYUdWaGNuUmlaV0YwWDJsdWRHVnlkbUZzSUQ0OUlGVkpiblEyTkNoTlNVNWZTRVZCVWxSQ1JVRlVYMGxPVkVWU1ZrRk1YMU5GUTA5T1JGTXBMQ0FpU0dWaGNuUmlaV0YwSUdsdWRHVnlkbUZzSUhSdmJ5QnphRzl5ZENBb2JXbHVJRE1nYlc5dWRHaHpLU0lLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZeUEwSUM4dklEYzNOell3TURBS0lDQWdJRDQ5Q2lBZ0lDQmhjM05sY25RZ0x5OGdTR1ZoY25SaVpXRjBJR2x1ZEdWeWRtRnNJSFJ2YnlCemFHOXlkQ0FvYldsdUlETWdiVzl1ZEdoektRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSeWRYTjBYM1poZFd4MEwyTnZiblJ5WVdOMExuQjVPall3Q2lBZ0lDQXZMeUJoYzNObGNuUWdhR1ZoY25SaVpXRjBYMmx1ZEdWeWRtRnNJRHc5SUZWSmJuUTJOQ2hOUVZoZlNFVkJVbFJDUlVGVVgwbE9WRVZTVmtGTVgxTkZRMDlPUkZNcExDQWlTR1ZoY25SaVpXRjBJR2x1ZEdWeWRtRnNJSFJ2YnlCc2IyNW5JQ2h0WVhnZ01TQjVaV0Z5S1NJS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWXlBMUlDOHZJRE14TlRNMk1EQXdDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUVobFlYSjBZbVZoZENCcGJuUmxjblpoYkNCMGIyOGdiRzl1WnlBb2JXRjRJREVnZVdWaGNpa0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGNuVnpkRjkyWVhWc2RDOWpiMjUwY21GamRDNXdlVG8yTWdvZ0lDQWdMeThnZG1GMWJIUmZiM2R1WlhJZ1BTQlVlRzR1YzJWdVpHVnlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKMWMzUmZkbUYxYkhRdlkyOXVkSEpoWTNRdWNIazZOalF0TmpVS0lDQWdJQzh2SUNNZ1EzSnBkR2xqWVd3NklGWmhkV3gwSUc5M2JtVnlJR05oYm01dmRDQmlaU0IwYUdWcGNpQnZkMjRnYUdWcGNnb2dJQ0FnTHk4Z1lYTnpaWEowSUhaaGRXeDBYMjkzYm1WeUlDRTlJR2hsYVhJc0lDSldZWFZzZENCdmQyNWxjaUJqWVc1dWIzUWdZbVVnZEdobGFYSWdiM2R1SUdobGFYSWlDaUFnSUNCa2RYQUtJQ0FnSUdScFp5QXpDaUFnSUNBaFBRb2dJQ0FnWVhOelpYSjBJQzh2SUZaaGRXeDBJRzkzYm1WeUlHTmhibTV2ZENCaVpTQjBhR1ZwY2lCdmQyNGdhR1ZwY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J5ZFhOMFgzWmhkV3gwTDJOdmJuUnlZV04wTG5CNU9qWTNMVFk0Q2lBZ0lDQXZMeUFqSUZabGNtbG1lU0IyWVhWc2RDQmtiMlZ6YmlkMElHRnNjbVZoWkhrZ1pYaHBjM1FnWW5rZ1kyaGxZMnRwYm1jZ2RtRjFiSFJmYjNkdVpYSnpJRUp2ZUUxaGNBb2dJQ0FnTHk4Z1lYTnpaWEowSUhaaGRXeDBYMjkzYm1WeUlHNXZkQ0JwYmlCelpXeG1MblpoZFd4MFgyOTNibVZ5Y3l3Z0lsWmhkV3gwSUdGc2NtVmhaSGtnWlhocGMzUnpJR1p2Y2lCMGFHbHpJSFZ6WlhJaUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE5tWTNOelpsTmpVM01qVm1DaUFnSUNCa2FXY2dNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRlpoZFd4MElHRnNjbVZoWkhrZ1pYaHBjM1J6SUdadmNpQjBhR2x6SUhWelpYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGNuVnpkRjkyWVhWc2RDOWpiMjUwY21GamRDNXdlVG8zTUMwM01nb2dJQ0FnTHk4Z0l5QlRkRzl5WlNCMllYVnNkQ0JqYjI1bWFXZDFjbUYwYVc5dUlHbHVJR3h2WTJGc0lITjBZWFJsSUNoMllYVnNkQ0J2ZDI1bGNpZHpJR1JoZEdFcENpQWdJQ0F2THlBaklGUm9hWE1nY21WeGRXbHlaWE1nZEdobElIWmhkV3gwSUc5M2JtVnlJSFJ2SUdoaGRtVWdiM0IwWldRZ2FXNGdkRzhnZEdobElHRndjR3hwWTJGMGFXOXVDaUFnSUNBdkx5QnpaV3htTG1obGFYSmJkbUYxYkhSZmIzZHVaWEpkSUQwZ2FHVnBjZ29nSUNBZ1pHbG5JREVLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbWhsYVhJaUNpQWdJQ0IxYm1OdmRtVnlJRFVLSUNBZ0lHRndjRjlzYjJOaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjblZ6ZEY5MllYVnNkQzlqYjI1MGNtRmpkQzV3ZVRvM013b2dJQ0FnTHk4Z2MyVnNaaTVvWldGeWRHSmxZWFJmYVc1MFpYSjJZV3hiZG1GMWJIUmZiM2R1WlhKZElEMGdhR1ZoY25SaVpXRjBYMmx1ZEdWeWRtRnNDaUFnSUNCa2FXY2dNUW9nSUNBZ1lubDBaV05mTWlBdkx5QWlhVzUwWlhKMllXd2lDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR0Z3Y0Y5c2IyTmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwY25WemRGOTJZWFZzZEM5amIyNTBjbUZqZEM1d2VUbzNOQW9nSUNBZ0x5OGdjMlZzWmk1c1lYTjBYMmhsWVhKMFltVmhkRnQyWVhWc2RGOXZkMjVsY2wwZ1BTQkhiRzlpWVd3dWJHRjBaWE4wWDNScGJXVnpkR0Z0Y0FvZ0lDQWdaMnh2WW1Gc0lFeGhkR1Z6ZEZScGJXVnpkR0Z0Y0FvZ0lDQWdaR2xuSURJS0lDQWdJR0o1ZEdWalh6TWdMeThnSW14aGMzUmZhR0lpQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdGd2NGOXNiMk5oYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGNuVnpkRjkyWVhWc2RDOWpiMjUwY21GamRDNXdlVG8zTmkwM053b2dJQ0FnTHk4Z0l5Qk5ZWEpySUhSb2FYTWdZV05qYjNWdWRDQmhjeUJoSUhaaGRXeDBJRzkzYm1WeUlHbHVJR0p2ZUNCemRHOXlZV2RsQ2lBZ0lDQXZMeUJ6Wld4bUxuWmhkV3gwWDI5M2JtVnljMXQyWVhWc2RGOXZkMjVsY2wwZ1BTQlZTVzUwTmpRb01Ta2dJQ01nTVNBOUlIWmhkV3gwSUdWNGFYTjBjd29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUdsMGIySUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjblZ6ZEY5MllYVnNkQzlqYjI1MGNtRmpkQzV3ZVRvM09TMDRNQW9nSUNBZ0x5OGdJeUJKYm1sMGFXRnNhWHBsSUhaaGRXeDBJR0poYkdGdVkyVWdhVzRnWW05NElITjBiM0poWjJVZ0tITjBZWEowSUhkcGRHZ2dNQ3dnZFhObGNpQmtaWEJ2YzJsMGN5QnpaWEJoY21GMFpXeDVLUW9nSUNBZ0x5OGdjMlZzWmk1MllYVnNkRjlpWVd4aGJtTmxjMXQyWVhWc2RGOXZkMjVsY2wwZ1BTQlZTVzUwTmpRb01Da0tJQ0FnSUdKNWRHVmpJRFVnTHk4Z01IZzJNall4Tm1NMk1UWmxOak0yTlRWbUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JwZEc5aUNpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRISjFjM1JmZG1GMWJIUXZZMjl1ZEhKaFkzUXVjSGs2T0RJdE9ETUtJQ0FnSUM4dklDTWdWWEJrWVhSbElHZHNiMkpoYkNCamIzVnVkR1Z5Q2lBZ0lDQXZMeUJqZFhKeVpXNTBYM1J2ZEdGc0xDQmxlR2x6ZEhNZ1BTQnpaV3htTG5SdmRHRnNYM1poZFd4MGN5NXRZWGxpWlNncENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZbmwwWldNZ05DQXZMeUFpZEc5MFlXeGZkbUYxYkhSeklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjblZ6ZEY5MllYVnNkQzlqYjI1MGNtRmpkQzV3ZVRvNE5Bb2dJQ0FnTHk4Z2FXWWdaWGhwYzNSek9nb2dJQ0FnWW5vZ2MyVjBkWEJmZG1GMWJIUmZaV3h6WlY5aWIyUjVRRE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjblZ6ZEY5MllYVnNkQzlqYjI1MGNtRmpkQzV3ZVRvNE5Rb2dJQ0FnTHk4Z2MyVnNaaTUwYjNSaGJGOTJZWFZzZEhNdWRtRnNkV1VnUFNCamRYSnlaVzUwWDNSdmRHRnNJQ3NnVlVsdWREWTBLREVwQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBckNpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKMGIzUmhiRjkyWVhWc2RITWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9LYzJWMGRYQmZkbUYxYkhSZllXWjBaWEpmYVdaZlpXeHpaVUEwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J5ZFhOMFgzWmhkV3gwTDJOdmJuUnlZV04wTG5CNU9qUXpDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ25ObGRIVndYM1poZFd4MFgyVnNjMlZmWW05a2VVQXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnlkWE4wWDNaaGRXeDBMMk52Ym5SeVlXTjBMbkI1T2pnM0NpQWdJQ0F2THlCelpXeG1MblJ2ZEdGc1gzWmhkV3gwY3k1MllXeDFaU0E5SUZWSmJuUTJOQ2d4S1FvZ0lDQWdZbmwwWldNZ05DQXZMeUFpZEc5MFlXeGZkbUYxYkhSeklnb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0JpSUhObGRIVndYM1poZFd4MFgyRm1kR1Z5WDJsbVgyVnNjMlZBTkFvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NTBjblZ6ZEY5MllYVnNkQzVqYjI1MGNtRmpkQzVVY25WemRGWmhkV3gwTG1SbGNHOXphWFJmWm5WdVpITmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BrWlhCdmMybDBYMloxYm1Sek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSeWRYTjBYM1poZFd4MEwyTnZiblJ5WVdOMExuQjVPamc1Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1pIVndDaUFnSUNCbmRIaHVjeUJVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklIQmhlUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCMGNtRnVjMkZqZEdsdmJpQjBlWEJsSUdseklIQmhlUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnlkWE4wWDNaaGRXeDBMMk52Ym5SeVlXTjBMbkI1T2pFd05Bb2dJQ0FnTHk4Z2RtRjFiSFJmYjNkdVpYSWdQU0JVZUc0dWMyVnVaR1Z5Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRISjFjM1JmZG1GMWJIUXZZMjl1ZEhKaFkzUXVjSGs2TVRBMkxURXdOd29nSUNBZ0x5OGdJeUJXWlhKcFpua2dkbUYxYkhRZ1pYaHBjM1J6SUdKNUlHTm9aV05yYVc1bklIWmhkV3gwWDI5M2JtVnljeUJDYjNoTllYQUtJQ0FnSUM4dklHRnpjMlZ5ZENCMllYVnNkRjl2ZDI1bGNpQnBiaUJ6Wld4bUxuWmhkV3gwWDI5M2JtVnljeXdnSWxaaGRXeDBJR1J2WlhNZ2JtOTBJR1Y0YVhOMExpQkRZV3hzSUhObGRIVndYM1poZFd4MElHWnBjbk4wSWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURabU56YzJaVFkxTnpJMVpnb2dJQ0FnWkdsbklERUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JoYzNObGNuUWdMeThnVm1GMWJIUWdaRzlsY3lCdWIzUWdaWGhwYzNRdUlFTmhiR3dnYzJWMGRYQmZkbUYxYkhRZ1ptbHljM1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjblZ6ZEY5MllYVnNkQzlqYjI1MGNtRmpkQzV3ZVRveE1Ea3RNVEV3Q2lBZ0lDQXZMeUFqSUZabGNtbG1lU0J3WVhsdFpXNTBJSFJ5WVc1ellXTjBhVzl1SUhCeWIzQmxjblJwWlhNS0lDQWdJQzh2SUdGemMyVnlkQ0J3WVhsdFpXNTBMbk5sYm1SbGNpQTlQU0IyWVhWc2RGOXZkMjVsY2l3Z0lsQmhlVzFsYm5RZ2JYVnpkQ0JpWlNCbWNtOXRJSFpoZFd4MElHOTNibVZ5SWdvZ0lDQWdaR2xuSURFS0lDQWdJR2QwZUc1eklGTmxibVJsY2dvZ0lDQWdaR2xuSURFS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdVR0Y1YldWdWRDQnRkWE4wSUdKbElHWnliMjBnZG1GMWJIUWdiM2R1WlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwY25WemRGOTJZWFZzZEM5amIyNTBjbUZqZEM1d2VUb3hNVEVLSUNBZ0lDOHZJR0Z6YzJWeWRDQndZWGx0Wlc1MExuSmxZMlZwZG1WeUlEMDlJRWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNJQ0pRWVhsdFpXNTBJRzExYzNRZ1ltVWdkRzhnWTI5dWRISmhZM1FnWVdSa2NtVnpjeUlLSUNBZ0lHUnBaeUF4Q2lBZ0lDQm5kSGh1Y3lCU1pXTmxhWFpsY2dvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdVR0Y1YldWdWRDQnRkWE4wSUdKbElIUnZJR052Ym5SeVlXTjBJR0ZrWkhKbGMzTUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGNuVnpkRjkyWVhWc2RDOWpiMjUwY21GamRDNXdlVG94TVRJS0lDQWdJQzh2SUdGemMyVnlkQ0J3WVhsdFpXNTBMbUZ0YjNWdWRDQStJRlZKYm5RMk5DZ3dLU3dnSWxCaGVXMWxiblFnWVcxdmRXNTBJRzExYzNRZ1ltVWdaM0psWVhSbGNpQjBhR0Z1SUhwbGNtOGlDaUFnSUNCemQyRndDaUFnSUNCbmRIaHVjeUJCYlc5MWJuUUtJQ0FnSUdSMWNBb2dJQ0FnWVhOelpYSjBJQzh2SUZCaGVXMWxiblFnWVcxdmRXNTBJRzExYzNRZ1ltVWdaM0psWVhSbGNpQjBhR0Z1SUhwbGNtOEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGNuVnpkRjkyWVhWc2RDOWpiMjUwY21GamRDNXdlVG94TVRRdE1URTFDaUFnSUNBdkx5QWpJRlZ3WkdGMFpTQjJZWFZzZENCaVlXeGhibU5sSUdsdUlHSnZlQ0J6ZEc5eVlXZGxDaUFnSUNBdkx5QmpkWEp5Wlc1MFgySmhiR0Z1WTJVZ1BTQnpaV3htTG5aaGRXeDBYMkpoYkdGdVkyVnpXM1poZFd4MFgyOTNibVZ5WFFvZ0lDQWdZbmwwWldNZ05TQXZMeUF3ZURZeU5qRTJZell4Tm1VMk16WTFOV1lLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MblpoZFd4MFgySmhiR0Z1WTJWeklHVnVkSEo1SUdWNGFYTjBjd29nSUNBZ1luUnZhUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnlkWE4wWDNaaGRXeDBMMk52Ym5SeVlXTjBMbkI1T2pFeE5nb2dJQ0FnTHk4Z2MyVnNaaTUyWVhWc2RGOWlZV3hoYm1ObGMxdDJZWFZzZEY5dmQyNWxjbDBnUFNCamRYSnlaVzUwWDJKaGJHRnVZMlVnS3lCd1lYbHRaVzUwTG1GdGIzVnVkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0FyQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKMWMzUmZkbUYxYkhRdlkyOXVkSEpoWTNRdWNIazZPRGtLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NTBjblZ6ZEY5MllYVnNkQzVqYjI1MGNtRmpkQzVVY25WemRGWmhkV3gwTG5Wd1pHRjBaVjlvWldseVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkWEJrWVhSbFgyaGxhWEk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEoxYzNSZmRtRjFiSFF2WTI5dWRISmhZM1F1Y0hrNk1URTRDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnlkWE4wWDNaaGRXeDBMMk52Ym5SeVlXTjBMbkI1T2pFeU53b2dJQ0FnTHk4Z2RtRjFiSFJmYjNkdVpYSWdQU0JVZUc0dWMyVnVaR1Z5Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRISjFjM1JmZG1GMWJIUXZZMjl1ZEhKaFkzUXVjSGs2TVRJNUxURXpNQW9nSUNBZ0x5OGdJeUJXWlhKcFpua2dkbUYxYkhRZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJoYzNObGNuUWdkbUYxYkhSZmIzZHVaWElnYVc0Z2MyVnNaaTUyWVhWc2RGOXZkMjVsY25Nc0lDSldZWFZzZENCa2IyVnpJRzV2ZENCbGVHbHpkQ0lLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGcyWmpjM05tVTJOVGN5TldZS0lDQWdJR1JwWnlBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZWE56WlhKMElDOHZJRlpoZFd4MElHUnZaWE1nYm05MElHVjRhWE4wQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEoxYzNSZmRtRjFiSFF2WTI5dWRISmhZM1F1Y0hrNk1UTXlMVEV6TXdvZ0lDQWdMeThnSXlCRGNtbDBhV05oYkRvZ1ZtRjFiSFFnYjNkdVpYSWdZMkZ1Ym05MElHSmxJSFJvWldseUlHOTNiaUJvWldseUNpQWdJQ0F2THlCaGMzTmxjblFnZG1GMWJIUmZiM2R1WlhJZ0lUMGdibVYzWDJobGFYSXNJQ0pXWVhWc2RDQnZkMjVsY2lCallXNXViM1FnWW1VZ2RHaGxhWElnYjNkdUlHaGxhWElpQ2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQWhQUW9nSUNBZ1lYTnpaWEowSUM4dklGWmhkV3gwSUc5M2JtVnlJR05oYm01dmRDQmlaU0IwYUdWcGNpQnZkMjRnYUdWcGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSeWRYTjBYM1poZFd4MEwyTnZiblJ5WVdOMExuQjVPakV6TlMweE16WUtJQ0FnSUM4dklDTWdWWEJrWVhSbElHaGxhWElnYVc0Z2JHOWpZV3dnYzNSaGRHVUtJQ0FnSUM4dklITmxiR1l1YUdWcGNsdDJZWFZzZEY5dmQyNWxjbDBnUFNCdVpYZGZhR1ZwY2dvZ0lDQWdZbmwwWldOZk1TQXZMeUFpYUdWcGNpSUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZWEJ3WDJ4dlkyRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J5ZFhOMFgzWmhkV3gwTDJOdmJuUnlZV04wTG5CNU9qRXhPQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxuUnlkWE4wWDNaaGRXeDBMbU52Ym5SeVlXTjBMbFJ5ZFhOMFZtRjFiSFF1ZFhCa1lYUmxYMmhsWVhKMFltVmhkRjlwYm5SbGNuWmhiRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25Wd1pHRjBaVjlvWldGeWRHSmxZWFJmYVc1MFpYSjJZV3c2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEoxYzNSZmRtRjFiSFF2WTI5dWRISmhZM1F1Y0hrNk1UTTRDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwY25WemRGOTJZWFZzZEM5amIyNTBjbUZqZEM1d2VUb3hORGN0TVRRNENpQWdJQ0F2THlBaklGWmhiR2xrWVhSbElHaGxZWEowWW1WaGRDQnBiblJsY25aaGJDQnBjeUIzYVhSb2FXNGdZV3hzYjNkbFpDQnlZVzVuWlNBb015QnRiMjUwYUhNZ2RHOGdNU0I1WldGeUtRb2dJQ0FnTHk4Z1lYTnpaWEowSUc1bGQxOXBiblJsY25aaGJDQStQU0JWU1c1ME5qUW9UVWxPWDBoRlFWSlVRa1ZCVkY5SlRsUkZVbFpCVEY5VFJVTlBUa1JUS1N3Z0lraGxZWEowWW1WaGRDQnBiblJsY25aaGJDQjBiMjhnYzJodmNuUWdLRzFwYmlBeklHMXZiblJvY3lraUNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdNZ05DQXZMeUEzTnpjMk1EQXdDaUFnSUNBK1BRb2dJQ0FnWVhOelpYSjBJQzh2SUVobFlYSjBZbVZoZENCcGJuUmxjblpoYkNCMGIyOGdjMmh2Y25RZ0tHMXBiaUF6SUcxdmJuUm9jeWtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjblZ6ZEY5MllYVnNkQzlqYjI1MGNtRmpkQzV3ZVRveE5Ea0tJQ0FnSUM4dklHRnpjMlZ5ZENCdVpYZGZhVzUwWlhKMllXd2dQRDBnVlVsdWREWTBLRTFCV0Y5SVJVRlNWRUpGUVZSZlNVNVVSVkpXUVV4ZlUwVkRUMDVFVXlrc0lDSklaV0Z5ZEdKbFlYUWdhVzUwWlhKMllXd2dkRzl2SUd4dmJtY2dLRzFoZUNBeElIbGxZWElwSWdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqSURVZ0x5OGdNekUxTXpZd01EQUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnU0dWaGNuUmlaV0YwSUdsdWRHVnlkbUZzSUhSdmJ5QnNiMjVuSUNodFlYZ2dNU0I1WldGeUtRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSeWRYTjBYM1poZFd4MEwyTnZiblJ5WVdOMExuQjVPakUxTVFvZ0lDQWdMeThnZG1GMWJIUmZiM2R1WlhJZ1BTQlVlRzR1YzJWdVpHVnlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKMWMzUmZkbUYxYkhRdlkyOXVkSEpoWTNRdWNIazZNVFV6TFRFMU5Bb2dJQ0FnTHk4Z0l5QldaWEpwWm5rZ2RtRjFiSFFnWlhocGMzUnpDaUFnSUNBdkx5QmhjM05sY25RZ2RtRjFiSFJmYjNkdVpYSWdhVzRnYzJWc1ppNTJZWFZzZEY5dmQyNWxjbk1zSUNKV1lYVnNkQ0JrYjJWeklHNXZkQ0JsZUdsemRDSUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZzJaamMzTm1VMk5UY3lOV1lLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lYTnpaWEowSUM4dklGWmhkV3gwSUdSdlpYTWdibTkwSUdWNGFYTjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRISjFjM1JmZG1GMWJIUXZZMjl1ZEhKaFkzUXVjSGs2TVRVMUNpQWdJQ0F2THlCaGMzTmxjblFnZG1GMWJIUmZiM2R1WlhJZ2FXNGdjMlZzWmk1b1pXRnlkR0psWVhSZmFXNTBaWEoyWVd3c0lDSldZWFZzZENCamIyNW1hV2QxY21GMGFXOXVJRzV2ZENCbWIzVnVaQ0lLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdKNWRHVmpYeklnTHk4Z0ltbHVkR1Z5ZG1Gc0lnb2dJQ0FnWVhCd1gyeHZZMkZzWDJkbGRGOWxlQW9nSUNBZ1luVnllU0F4Q2lBZ0lDQmhjM05sY25RZ0x5OGdWbUYxYkhRZ1kyOXVabWxuZFhKaGRHbHZiaUJ1YjNRZ1ptOTFibVFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjblZ6ZEY5MllYVnNkQzlqYjI1MGNtRmpkQzV3ZVRveE5UY3RNVFU0Q2lBZ0lDQXZMeUFqSUZWd1pHRjBaU0JwYm5SbGNuWmhiQ0JwYmlCc2IyTmhiQ0J6ZEdGMFpRb2dJQ0FnTHk4Z2MyVnNaaTVvWldGeWRHSmxZWFJmYVc1MFpYSjJZV3hiZG1GMWJIUmZiM2R1WlhKZElEMGdibVYzWDJsdWRHVnlkbUZzQ2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0pwYm5SbGNuWmhiQ0lLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWVhCd1gyeHZZMkZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSeWRYTjBYM1poZFd4MEwyTnZiblJ5WVdOMExuQjVPakV6T0FvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMblJ5ZFhOMFgzWmhkV3gwTG1OdmJuUnlZV04wTGxSeWRYTjBWbUYxYkhRdWFHVmhjblJpWldGMFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0thR1ZoY25SaVpXRjBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnlkWE4wWDNaaGRXeDBMMk52Ym5SeVlXTjBMbkI1T2pFMk53b2dJQ0FnTHk4Z2RtRjFiSFJmYjNkdVpYSWdQU0JVZUc0dWMyVnVaR1Z5Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRISjFjM1JmZG1GMWJIUXZZMjl1ZEhKaFkzUXVjSGs2TVRZNUxURTNNQW9nSUNBZ0x5OGdJeUJXWlhKcFpua2dkbUYxYkhRZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJoYzNObGNuUWdkbUYxYkhSZmIzZHVaWElnYVc0Z2MyVnNaaTUyWVhWc2RGOXZkMjVsY25Nc0lDSldZWFZzZENCa2IyVnpJRzV2ZENCbGVHbHpkQ0lLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGcyWmpjM05tVTJOVGN5TldZS0lDQWdJR1JwWnlBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZWE56WlhKMElDOHZJRlpoZFd4MElHUnZaWE1nYm05MElHVjRhWE4wQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEoxYzNSZmRtRjFiSFF2WTI5dWRISmhZM1F1Y0hrNk1UY3hDaUFnSUNBdkx5QmhjM05sY25RZ2RtRjFiSFJmYjNkdVpYSWdhVzRnYzJWc1ppNXNZWE4wWDJobFlYSjBZbVZoZEN3Z0lsWmhkV3gwSUdOdmJtWnBaM1Z5WVhScGIyNGdibTkwSUdadmRXNWtJZ29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNeUF2THlBaWJHRnpkRjlvWWlJS0lDQWdJR0Z3Y0Y5c2IyTmhiRjluWlhSZlpYZ0tJQ0FnSUdKMWNua2dNUW9nSUNBZ1lYTnpaWEowSUM4dklGWmhkV3gwSUdOdmJtWnBaM1Z5WVhScGIyNGdibTkwSUdadmRXNWtDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRISjFjM1JmZG1GMWJIUXZZMjl1ZEhKaFkzUXVjSGs2TVRjekxURTNOQW9nSUNBZ0x5OGdJeUJWY0dSaGRHVWdiR0Z6ZENCb1pXRnlkR0psWVhRZ2RHbHRaWE4wWVcxd0lHbHVJR3h2WTJGc0lITjBZWFJsQ2lBZ0lDQXZMeUJ6Wld4bUxteGhjM1JmYUdWaGNuUmlaV0YwVzNaaGRXeDBYMjkzYm1WeVhTQTlJRWRzYjJKaGJDNXNZWFJsYzNSZmRHbHRaWE4wWVcxd0NpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKc1lYTjBYMmhpSWdvZ0lDQWdaMnh2WW1Gc0lFeGhkR1Z6ZEZScGJXVnpkR0Z0Y0FvZ0lDQWdZWEJ3WDJ4dlkyRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J5ZFhOMFgzWmhkV3gwTDJOdmJuUnlZV04wTG5CNU9qRTJNQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxuUnlkWE4wWDNaaGRXeDBMbU52Ym5SeVlXTjBMbFJ5ZFhOMFZtRjFiSFF1WTJ4aGFXMWZablZ1WkhOYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGpiR0ZwYlY5bWRXNWtjem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjblZ6ZEY5MllYVnNkQzlqYjI1MGNtRmpkQzV3ZVRveE56WUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRISjFjM1JmZG1GMWJIUXZZMjl1ZEhKaFkzUXVjSGs2TVRnMkxURTROd29nSUNBZ0x5OGdJeUJXWlhKcFpua2dkbUYxYkhRZ1pYaHBjM1J6SUNoamFHVmpheUIyWVhWc2RGOXZkMjVsY25NZ1FtOTRUV0Z3SUdacGNuTjBLUW9nSUNBZ0x5OGdZWE56WlhKMElIWmhkV3gwWDI5M2JtVnlJR2x1SUhObGJHWXVkbUYxYkhSZmIzZHVaWEp6TENBaVZtRjFiSFFnWkc5bGN5QnViM1FnWlhocGMzUWdabTl5SUhSb2FYTWdkWE5sY2lJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnMlpqYzNObVUyTlRjeU5XWUtJQ0FnSUdScFp5QXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JoYzNObGNuUWdMeThnVm1GMWJIUWdaRzlsY3lCdWIzUWdaWGhwYzNRZ1ptOXlJSFJvYVhNZ2RYTmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnlkWE4wWDNaaGRXeDBMMk52Ym5SeVlXTjBMbkI1T2pFNE9TMHhPVEFLSUNBZ0lDOHZJQ01nVm1WeWFXWjVJSFpoZFd4MElHTnZibVpwWjNWeVlYUnBiMjRnWlhocGMzUnpJR2x1SUd4dlkyRnNJSE4wWVhSbENpQWdJQ0F2THlCaGMzTmxjblFnZG1GMWJIUmZiM2R1WlhJZ2FXNGdjMlZzWmk1b1pXbHlMQ0FpVm1GMWJIUWdZMjl1Wm1sbmRYSmhkR2x2YmlCdWIzUWdabTkxYm1RaUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1obGFYSWlDaUFnSUNCaGNIQmZiRzlqWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdWbUYxYkhRZ1kyOXVabWxuZFhKaGRHbHZiaUJ1YjNRZ1ptOTFibVFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjblZ6ZEY5MllYVnNkQzlqYjI1MGNtRmpkQzV3ZVRveE9URUtJQ0FnSUM4dklHRnpjMlZ5ZENCMllYVnNkRjl2ZDI1bGNpQnBiaUJ6Wld4bUxteGhjM1JmYUdWaGNuUmlaV0YwTENBaVNHVmhjblJpWldGMElHUmhkR0VnYldsemMybHVaeUlLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1lubDBaV05mTXlBdkx5QWliR0Z6ZEY5b1lpSUtJQ0FnSUdGd2NGOXNiMk5oYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QklaV0Z5ZEdKbFlYUWdaR0YwWVNCdGFYTnphVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEoxYzNSZmRtRjFiSFF2WTI5dWRISmhZM1F1Y0hrNk1Ua3lDaUFnSUNBdkx5QmhjM05sY25RZ2RtRjFiSFJmYjNkdVpYSWdhVzRnYzJWc1ppNW9aV0Z5ZEdKbFlYUmZhVzUwWlhKMllXd3NJQ0pKYm5SbGNuWmhiQ0JrWVhSaElHMXBjM05wYm1jaUNpQWdJQ0JrYVdjZ013b2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0o1ZEdWalh6SWdMeThnSW1sdWRHVnlkbUZzSWdvZ0lDQWdZWEJ3WDJ4dlkyRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUVsdWRHVnlkbUZzSUdSaGRHRWdiV2x6YzJsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSeWRYTjBYM1poZFd4MEwyTnZiblJ5WVdOMExuQjVPakU1T1MweU1EQUtJQ0FnSUM4dklDTWdSMlYwSUhaaGRXeDBJR0poYkdGdVkyVWdabkp2YlNCaWIzZ2djM1J2Y21GblpRb2dJQ0FnTHk4Z1lYTnpaWEowSUhaaGRXeDBYMjkzYm1WeUlHbHVJSE5sYkdZdWRtRjFiSFJmWW1Gc1lXNWpaWE1zSUNKV1lYVnNkQ0JpWVd4aGJtTmxJRzV2ZENCbWIzVnVaQ0lLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdNSGcyTWpZeE5tTTJNVFpsTmpNMk5UVm1DaUFnSUNCa2FXY2dOUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWVhOelpYSjBJQzh2SUZaaGRXeDBJR0poYkdGdVkyVWdibTkwSUdadmRXNWtDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRISjFjM1JmZG1GMWJIUXZZMjl1ZEhKaFkzUXVjSGs2TWpBeENpQWdJQ0F2THlCMllYVnNkRjlpWVd4aGJtTmxJRDBnYzJWc1ppNTJZWFZzZEY5aVlXeGhibU5sYzF0MllYVnNkRjl2ZDI1bGNsMEtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ2NHOXdDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRISjFjM1JmZG1GMWJIUXZZMjl1ZEhKaFkzUXVjSGs2TWpBekxUSXdOQW9nSUNBZ0x5OGdJeUJXWlhKcFpua2dZMkZzYkdWeUlHbHpJSFJvWlNCa1pYTnBaMjVoZEdWa0lFaGxhWElLSUNBZ0lDOHZJR0Z6YzJWeWRDQlVlRzR1YzJWdVpHVnlJRDA5SUdobGFYSXNJQ0pQYm14NUlIUm9aU0JrWlhOcFoyNWhkR1ZrSUdobGFYSWdZMkZ1SUdOc1lXbHRJR1oxYm1Seklnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdaR2xuSURVS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVzZVNCMGFHVWdaR1Z6YVdkdVlYUmxaQ0JvWldseUlHTmhiaUJqYkdGcGJTQm1kVzVrY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J5ZFhOMFgzWmhkV3gwTDJOdmJuUnlZV04wTG5CNU9qSXdOaTB5TURjS0lDQWdJQzh2SUNNZ1EyaGxZMnNnYVdZZ1ZtRjFiSFFnVlhObGNpQm9ZWE1nWW1WbGJpQnBibUZqZEdsMlpTQmlaWGx2Ym1RZ2RHaGxJR2hsWVhKMFltVmhkQ0JwYm5SbGNuWmhiQW9nSUNBZ0x5OGdkR2x0WlY5emFXNWpaVjlvWldGeWRHSmxZWFFnUFNCSGJHOWlZV3d1YkdGMFpYTjBYM1JwYldWemRHRnRjQ0F0SUd4aGMzUmZhR1ZoY25SaVpXRjBDaUFnSUNCbmJHOWlZV3dnVEdGMFpYTjBWR2x0WlhOMFlXMXdDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJQzBLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjblZ6ZEY5MllYVnNkQzlqYjI1MGNtRmpkQzV3ZVRveU1EZ0tJQ0FnSUM4dklHRnpjMlZ5ZENCMGFXMWxYM05wYm1ObFgyaGxZWEowWW1WaGRDQStQU0JvWldGeWRHSmxZWFJmYVc1MFpYSjJZV3dzSUNKSmJtRmpkR2wyYVhSNUlIQmxjbWx2WkNCdWIzUWdlV1YwSUhKbFlXTm9aV1FpQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUQ0OUNpQWdJQ0JoYzNObGNuUWdMeThnU1c1aFkzUnBkbWwwZVNCd1pYSnBiMlFnYm05MElIbGxkQ0J5WldGamFHVmtDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRISjFjM1JmZG1GMWJIUXZZMjl1ZEhKaFkzUXVjSGs2TWpFd0xUSXhNUW9nSUNBZ0x5OGdJeUJXWlhKcFpua2dkR2hsY21VZ1lYSmxJR1oxYm1SeklIUnZJSFJ5WVc1elptVnlDaUFnSUNBdkx5QmhjM05sY25RZ2RtRjFiSFJmWW1Gc1lXNWpaU0ErSUZWSmJuUTJOQ2d3S1N3Z0lrNXZJR1oxYm1SeklIUnZJSFJ5WVc1elptVnlJZ29nSUNBZ1pIVndDaUFnSUNCaGMzTmxjblFnTHk4Z1RtOGdablZ1WkhNZ2RHOGdkSEpoYm5ObVpYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGNuVnpkRjkyWVhWc2RDOWpiMjUwY21GamRDNXdlVG95TVRNdE1qRTVDaUFnSUNBdkx5QWpJRlJ5WVc1elptVnlJR1oxYm1SeklIUnZJRWhsYVhJZ2RtbGhJR2x1Ym1WeUlIUnlZVzV6WVdOMGFXOXVDaUFnSUNBdkx5QnBkSGh1TGxCaGVXMWxiblFvQ2lBZ0lDQXZMeUFnSUNBZ2MyVnVaR1Z5UFVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ2NtVmpaV2wyWlhJOWFHVnBjaXdLSUNBZ0lDOHZJQ0FnSUNCaGJXOTFiblE5ZG1GMWJIUmZZbUZzWVc1alpTd0tJQ0FnSUM4dklDQWdJQ0JtWldVOU1Dd2dJQ01nUm1WbElIQmhhV1FnWW5rZ2IzVjBaWElnZEhKaGJuTmhZM1JwYjI0S0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjblZ6ZEY5MllYVnNkQzlqYjI1MGNtRmpkQzV3ZVRveU1UVUtJQ0FnSUM4dklITmxibVJsY2oxSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TEFvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJSE4zWVhBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVcxdmRXNTBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR2wwZUc1ZlptbGxiR1FnVW1WalpXbDJaWElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKMWMzUmZkbUYxYkhRdlkyOXVkSEpoWTNRdWNIazZNakV6TFRJeE5Bb2dJQ0FnTHk4Z0l5QlVjbUZ1YzJabGNpQm1kVzVrY3lCMGJ5QklaV2x5SUhacFlTQnBibTVsY2lCMGNtRnVjMkZqZEdsdmJnb2dJQ0FnTHk4Z2FYUjRiaTVRWVhsdFpXNTBLQW9nSUNBZ2FXNTBZMTh3SUM4dklIQmhlUW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSeWRYTjBYM1poZFd4MEwyTnZiblJ5WVdOMExuQjVPakl4T0FvZ0lDQWdMeThnWm1WbFBUQXNJQ0FqSUVabFpTQndZV2xrSUdKNUlHOTFkR1Z5SUhSeVlXNXpZV04wYVc5dUNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwY25WemRGOTJZWFZzZEM5amIyNTBjbUZqZEM1d2VUb3lNVE10TWpFNUNpQWdJQ0F2THlBaklGUnlZVzV6Wm1WeUlHWjFibVJ6SUhSdklFaGxhWElnZG1saElHbHVibVZ5SUhSeVlXNXpZV04wYVc5dUNpQWdJQ0F2THlCcGRIaHVMbEJoZVcxbGJuUW9DaUFnSUNBdkx5QWdJQ0FnYzJWdVpHVnlQVWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJQ0FnY21WalpXbDJaWEk5YUdWcGNpd0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUTlkbUYxYkhSZlltRnNZVzVqWlN3S0lDQWdJQzh2SUNBZ0lDQm1aV1U5TUN3Z0lDTWdSbVZsSUhCaGFXUWdZbmtnYjNWMFpYSWdkSEpoYm5OaFkzUnBiMjRLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRISjFjM1JmZG1GMWJIUXZZMjl1ZEhKaFkzUXVjSGs2TWpJeExUSXlNd29nSUNBZ0x5OGdJeUJEYkdWaGNpQjJZWFZzZENCa1lYUmhJR0ZtZEdWeUlITjFZMk5sYzNObWRXd2dkSEpoYm5ObVpYSUtJQ0FnSUM4dklDTWdRMnhsWVhJZ2JHOWpZV3dnYzNSaGRHVWdLSFpoZFd4MElHOTNibVZ5SUdOaGJpQnZjSFF0YjNWMElITmxjR0Z5WVhSbGJIa2dhV1lnWkdWemFYSmxaQ2tLSUNBZ0lDOHZJR1JsYkNCelpXeG1MbWhsYVhKYmRtRjFiSFJmYjNkdVpYSmRDaUFnSUNCa2FXY2dNZ29nSUNBZ1lubDBaV05mTVNBdkx5QWlhR1ZwY2lJS0lDQWdJR0Z3Y0Y5c2IyTmhiRjlrWld3S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwY25WemRGOTJZWFZzZEM5amIyNTBjbUZqZEM1d2VUb3lNalFLSUNBZ0lDOHZJR1JsYkNCelpXeG1MbXhoYzNSZmFHVmhjblJpWldGMFczWmhkV3gwWDI5M2JtVnlYUW9nSUNBZ1pHbG5JRElLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbXhoYzNSZmFHSWlDaUFnSUNCaGNIQmZiRzlqWVd4ZlpHVnNDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRISjFjM1JmZG1GMWJIUXZZMjl1ZEhKaFkzUXVjSGs2TWpJMUNpQWdJQ0F2THlCa1pXd2djMlZzWmk1b1pXRnlkR0psWVhSZmFXNTBaWEoyWVd4YmRtRjFiSFJmYjNkdVpYSmRDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0o1ZEdWalh6SWdMeThnSW1sdWRHVnlkbUZzSWdvZ0lDQWdZWEJ3WDJ4dlkyRnNYMlJsYkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J5ZFhOMFgzWmhkV3gwTDJOdmJuUnlZV04wTG5CNU9qSXlOeTB5TWpnS0lDQWdJQzh2SUNNZ1EyeGxZWElnWW05NElITjBiM0poWjJVS0lDQWdJQzh2SUdSbGJDQnpaV3htTG5aaGRXeDBYMkpoYkdGdVkyVnpXM1poZFd4MFgyOTNibVZ5WFFvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKMWMzUmZkbUYxYkhRdlkyOXVkSEpoWTNRdWNIazZNakk1Q2lBZ0lDQXZMeUJrWld3Z2MyVnNaaTUyWVhWc2RGOXZkMjVsY25OYmRtRjFiSFJmYjNkdVpYSmRDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjblZ6ZEY5MllYVnNkQzlqYjI1MGNtRmpkQzV3ZVRveU16RXRNak15Q2lBZ0lDQXZMeUFqSUZWd1pHRjBaU0JuYkc5aVlXd2dZMjkxYm5SbGNnb2dJQ0FnTHk4Z1kzVnljbVZ1ZEY5MGIzUmhiQ3dnWlhocGMzUnpJRDBnYzJWc1ppNTBiM1JoYkY5MllYVnNkSE11YldGNVltVW9LUW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z0luUnZkR0ZzWDNaaGRXeDBjeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKMWMzUmZkbUYxYkhRdlkyOXVkSEpoWTNRdWNIazZNak16Q2lBZ0lDQXZMeUJwWmlCbGVHbHpkSE1nWVc1a0lHTjFjbkpsYm5SZmRHOTBZV3dnUGlCVlNXNTBOalFvTUNrNkNpQWdJQ0JpZWlCamJHRnBiVjltZFc1a2MxOWhablJsY2w5cFpsOWxiSE5sUURVS0lDQWdJR1IxY0FvZ0lDQWdZbm9nWTJ4aGFXMWZablZ1WkhOZllXWjBaWEpmYVdaZlpXeHpaVUExQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEoxYzNSZmRtRjFiSFF2WTI5dWRISmhZM1F1Y0hrNk1qTTBDaUFnSUNBdkx5QnpaV3htTG5SdmRHRnNYM1poZFd4MGN5NTJZV3gxWlNBOUlHTjFjbkpsYm5SZmRHOTBZV3dnTFNCVlNXNTBOalFvTVNrS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDMEtJQ0FnSUdKNWRHVmpJRFFnTHk4Z0luUnZkR0ZzWDNaaGRXeDBjeUlLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2dwamJHRnBiVjltZFc1a2MxOWhablJsY2w5cFpsOWxiSE5sUURVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKMWMzUmZkbUYxYkhRdlkyOXVkSEpoWTNRdWNIazZNVGMyQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVkSEoxYzNSZmRtRjFiSFF1WTI5dWRISmhZM1F1VkhKMWMzUldZWFZzZEM1M2FYUm9aSEpoZDE5bWRXNWtjMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25kcGRHaGtjbUYzWDJaMWJtUnpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnlkWE4wWDNaaGRXeDBMMk52Ym5SeVlXTjBMbkI1T2pJek5nb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEoxYzNSZmRtRjFiSFF2WTI5dWRISmhZM1F1Y0hrNk1qUTFDaUFnSUNBdkx5QmhjM05sY25RZ1lXMXZkVzUwSUQ0Z1ZVbHVkRFkwS0RBcExDQWlRVzF2ZFc1MElHMTFjM1FnWW1VZ1ozSmxZWFJsY2lCMGFHRnVJSHBsY204aUNpQWdJQ0JrZFhBS0lDQWdJR0Z6YzJWeWRDQXZMeUJCYlc5MWJuUWdiWFZ6ZENCaVpTQm5jbVZoZEdWeUlIUm9ZVzRnZW1WeWJ3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSeWRYTjBYM1poZFd4MEwyTnZiblJ5WVdOMExuQjVPakkwTndvZ0lDQWdMeThnZG1GMWJIUmZiM2R1WlhJZ1BTQlVlRzR1YzJWdVpHVnlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKMWMzUmZkbUYxYkhRdlkyOXVkSEpoWTNRdWNIazZNalE1TFRJMU1Bb2dJQ0FnTHk4Z0l5QldaWEpwWm5rZ2RtRjFiSFFnWlhocGMzUnpDaUFnSUNBdkx5QmhjM05sY25RZ2RtRjFiSFJmYjNkdVpYSWdhVzRnYzJWc1ppNTJZWFZzZEY5dmQyNWxjbk1zSUNKV1lYVnNkQ0JrYjJWeklHNXZkQ0JsZUdsemRDSUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZzJaamMzTm1VMk5UY3lOV1lLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lYTnpaWEowSUM4dklGWmhkV3gwSUdSdlpYTWdibTkwSUdWNGFYTjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRISjFjM1JmZG1GMWJIUXZZMjl1ZEhKaFkzUXVjSGs2TWpVeENpQWdJQ0F2THlCaGMzTmxjblFnZG1GMWJIUmZiM2R1WlhJZ2FXNGdjMlZzWmk1b1pXbHlMQ0FpVm1GMWJIUWdZMjl1Wm1sbmRYSmhkR2x2YmlCdWIzUWdabTkxYm1RaUNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0pvWldseUlnb2dJQ0FnWVhCd1gyeHZZMkZzWDJkbGRGOWxlQW9nSUNBZ1luVnllU0F4Q2lBZ0lDQmhjM05sY25RZ0x5OGdWbUYxYkhRZ1kyOXVabWxuZFhKaGRHbHZiaUJ1YjNRZ1ptOTFibVFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjblZ6ZEY5MllYVnNkQzlqYjI1MGNtRmpkQzV3ZVRveU5USUtJQ0FnSUM4dklHRnpjMlZ5ZENCMllYVnNkRjl2ZDI1bGNpQnBiaUJ6Wld4bUxuWmhkV3gwWDJKaGJHRnVZMlZ6TENBaVZtRjFiSFFnWW1Gc1lXNWpaU0J1YjNRZ1ptOTFibVFpQ2lBZ0lDQmllWFJsWXlBMUlDOHZJREI0TmpJMk1UWmpOakUyWlRZek5qVTFaZ29nSUNBZ1pHbG5JREVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdGemMyVnlkQ0F2THlCV1lYVnNkQ0JpWVd4aGJtTmxJRzV2ZENCbWIzVnVaQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnlkWE4wWDNaaGRXeDBMMk52Ym5SeVlXTjBMbkI1T2pJMU5DMHlOVFVLSUNBZ0lDOHZJQ01nUjJWMElHTjFjbkpsYm5RZ1ltRnNZVzVqWlNCbWNtOXRJR0p2ZUNCemRHOXlZV2RsQ2lBZ0lDQXZMeUJqZFhKeVpXNTBYMkpoYkdGdVkyVWdQU0J6Wld4bUxuWmhkV3gwWDJKaGJHRnVZMlZ6VzNaaGRXeDBYMjkzYm1WeVhRb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZloyVjBDaUFnSUNCd2IzQUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGNuVnpkRjkyWVhWc2RDOWpiMjUwY21GamRDNXdlVG95TlRjdE1qVTRDaUFnSUNBdkx5QWpJRlpsY21sbWVTQnpkV1ptYVdOcFpXNTBJR0poYkdGdVkyVUtJQ0FnSUM4dklHRnpjMlZ5ZENCamRYSnlaVzUwWDJKaGJHRnVZMlVnUGowZ1lXMXZkVzUwTENBaVNXNXpkV1ptYVdOcFpXNTBJR0poYkdGdVkyVWdhVzRnZG1GMWJIUWlDaUFnSUNCa2RYQUtJQ0FnSUdScFp5QTBDaUFnSUNBK1BRb2dJQ0FnWVhOelpYSjBJQzh2SUVsdWMzVm1abWxqYVdWdWRDQmlZV3hoYm1ObElHbHVJSFpoZFd4MENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKMWMzUmZkbUYxYkhRdlkyOXVkSEpoWTNRdWNIazZNall3TFRJMk1Rb2dJQ0FnTHk4Z0l5QlZjR1JoZEdVZ2RtRjFiSFFnWW1Gc1lXNWpaU0JwYmlCaWIzZ2djM1J2Y21GblpRb2dJQ0FnTHk4Z2JtVjNYMkpoYkdGdVkyVWdQU0JqZFhKeVpXNTBYMkpoYkdGdVkyVWdMU0JoYlc5MWJuUUtJQ0FnSUdScFp5QXpDaUFnSUNBdENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKMWMzUmZkbUYxYkhRdlkyOXVkSEpoWTNRdWNIazZNall5Q2lBZ0lDQXZMeUJ6Wld4bUxuWmhkV3gwWDJKaGJHRnVZMlZ6VzNaaGRXeDBYMjkzYm1WeVhTQTlJRzVsZDE5aVlXeGhibU5sQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKMWMzUmZkbUYxYkhRdlkyOXVkSEpoWTNRdWNIazZNalkwTFRJM01Bb2dJQ0FnTHk4Z0l5QlVjbUZ1YzJabGNpQm1kVzVrY3lCaVlXTnJJSFJ2SUZaaGRXeDBJRlZ6WlhJZ2RtbGhJR2x1Ym1WeUlIUnlZVzV6WVdOMGFXOXVDaUFnSUNBdkx5QnBkSGh1TGxCaGVXMWxiblFvQ2lBZ0lDQXZMeUFnSUNBZ2MyVnVaR1Z5UFVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ2NtVmpaV2wyWlhJOWRtRjFiSFJmYjNkdVpYSXNDaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBQV0Z0YjNWdWRDd0tJQ0FnSUM4dklDQWdJQ0JtWldVOU1Dd2dJQ01nUm1WbElIQmhhV1FnWW5rZ2IzVjBaWElnZEhKaGJuTmhZM1JwYjI0S0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjblZ6ZEY5MllYVnNkQzlqYjI1MGNtRmpkQzV3ZVRveU5qWUtJQ0FnSUM4dklITmxibVJsY2oxSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TEFvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJiVzkxYm5RS0lDQWdJR2wwZUc1ZlptbGxiR1FnVTJWdVpHVnlDaUFnSUNCcGRIaHVYMlpwWld4a0lGSmxZMlZwZG1WeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKMWMzUmZkbUYxYkhRdlkyOXVkSEpoWTNRdWNIazZNalkwTFRJMk5Rb2dJQ0FnTHk4Z0l5QlVjbUZ1YzJabGNpQm1kVzVrY3lCaVlXTnJJSFJ2SUZaaGRXeDBJRlZ6WlhJZ2RtbGhJR2x1Ym1WeUlIUnlZVzV6WVdOMGFXOXVDaUFnSUNBdkx5QnBkSGh1TGxCaGVXMWxiblFvQ2lBZ0lDQnBiblJqWHpBZ0x5OGdjR0Y1Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRISjFjM1JmZG1GMWJIUXZZMjl1ZEhKaFkzUXVjSGs2TWpZNUNpQWdJQ0F2THlCbVpXVTlNQ3dnSUNNZ1JtVmxJSEJoYVdRZ1lua2diM1YwWlhJZ2RISmhibk5oWTNScGIyNEtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSeWRYTjBYM1poZFd4MEwyTnZiblJ5WVdOMExuQjVPakkyTkMweU56QUtJQ0FnSUM4dklDTWdWSEpoYm5ObVpYSWdablZ1WkhNZ1ltRmpheUIwYnlCV1lYVnNkQ0JWYzJWeUlIWnBZU0JwYm01bGNpQjBjbUZ1YzJGamRHbHZiZ29nSUNBZ0x5OGdhWFI0Ymk1UVlYbHRaVzUwS0FvZ0lDQWdMeThnSUNBZ0lITmxibVJsY2oxSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TEFvZ0lDQWdMeThnSUNBZ0lISmxZMlZwZG1WeVBYWmhkV3gwWDI5M2JtVnlMQW9nSUNBZ0x5OGdJQ0FnSUdGdGIzVnVkRDFoYlc5MWJuUXNDaUFnSUNBdkx5QWdJQ0FnWm1WbFBUQXNJQ0FqSUVabFpTQndZV2xrSUdKNUlHOTFkR1Z5SUhSeVlXNXpZV04wYVc5dUNpQWdJQ0F2THlBcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J5ZFhOMFgzWmhkV3gwTDJOdmJuUnlZV04wTG5CNU9qSXpOZ29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxuUnlkWE4wWDNaaGRXeDBMbU52Ym5SeVlXTjBMbFJ5ZFhOMFZtRjFiSFF1WjJWMFgzWmhkV3gwWDJsdVptOWJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BuWlhSZmRtRjFiSFJmYVc1bWJ6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGNuVnpkRjkyWVhWc2RDOWpiMjUwY21GamRDNXdlVG95TnpJS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKMWMzUmZkbUYxYkhRdlkyOXVkSEpoWTNRdWNIazZNamcwTFRJNE5Rb2dJQ0FnTHk4Z0l5QldaWEpwWm5rZ2RtRjFiSFFnWlhocGMzUnpDaUFnSUNBdkx5QmhjM05sY25RZ2RtRjFiSFJmYjNkdVpYSWdhVzRnYzJWc1ppNTJZWFZzZEY5dmQyNWxjbk1zSUNKV1lYVnNkQ0JrYjJWeklHNXZkQ0JsZUdsemRDQm1iM0lnZEdocGN5QjFjMlZ5SWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURabU56YzJaVFkxTnpJMVpnb2dJQ0FnWkdsbklERUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JoYzNObGNuUWdMeThnVm1GMWJIUWdaRzlsY3lCdWIzUWdaWGhwYzNRZ1ptOXlJSFJvYVhNZ2RYTmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnlkWE4wWDNaaGRXeDBMMk52Ym5SeVlXTjBMbkI1T2pJNE5nb2dJQ0FnTHk4Z1lYTnpaWEowSUhaaGRXeDBYMjkzYm1WeUlHbHVJSE5sYkdZdWFHVnBjaXdnSWxaaGRXeDBJR052Ym1acFozVnlZWFJwYjI0Z2JtOTBJR1p2ZFc1a0lnb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpYUdWcGNpSUtJQ0FnSUdGd2NGOXNiMk5oYkY5blpYUmZaWGdLSUNBZ0lITjNZWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR0Z6YzJWeWRDQXZMeUJXWVhWc2RDQmpiMjVtYVdkMWNtRjBhVzl1SUc1dmRDQm1iM1Z1WkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J5ZFhOMFgzWmhkV3gwTDJOdmJuUnlZV04wTG5CNU9qSTVNQW9nSUNBZ0x5OGdiR0Z6ZEY5b1pXRnlkR0psWVhRZ1BTQnpaV3htTG14aGMzUmZhR1ZoY25SaVpXRjBXM1poZFd4MFgyOTNibVZ5WFFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1lubDBaV05mTXlBdkx5QWliR0Z6ZEY5b1lpSUtJQ0FnSUdGd2NGOXNiMk5oYkY5blpYUmZaWGdLSUNBZ0lITjNZWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG14aGMzUmZhR1ZoY25SaVpXRjBJR1Y0YVhOMGN5Qm1iM0lnWVdOamIzVnVkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnlkWE4wWDNaaGRXeDBMMk52Ym5SeVlXTjBMbkI1T2pJNU1Rb2dJQ0FnTHk4Z2FHVmhjblJpWldGMFgybHVkR1Z5ZG1Gc0lEMGdjMlZzWmk1b1pXRnlkR0psWVhSZmFXNTBaWEoyWVd4YmRtRjFiSFJmYjNkdVpYSmRDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKcGJuUmxjblpoYkNJS0lDQWdJR0Z3Y0Y5c2IyTmhiRjluWlhSZlpYZ0tJQ0FnSUhOM1lYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbWhsWVhKMFltVmhkRjlwYm5SbGNuWmhiQ0JsZUdsemRITWdabTl5SUdGalkyOTFiblFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjblZ6ZEY5MllYVnNkQzlqYjI1MGNtRmpkQzV3ZVRveU9UTXRNamswQ2lBZ0lDQXZMeUFqSUVkbGRDQmlZV3hoYm1ObElHWnliMjBnWW05NElITjBiM0poWjJVS0lDQWdJQzh2SUdsbUlIWmhkV3gwWDI5M2JtVnlJR2x1SUhObGJHWXVkbUYxYkhSZlltRnNZVzVqWlhNNkNpQWdJQ0JpZVhSbFl5QTFJQzh2SURCNE5qSTJNVFpqTmpFMlpUWXpOalUxWmdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lub2daMlYwWDNaaGRXeDBYMmx1Wm05ZlpXeHpaVjlpYjJSNVFETUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGNuVnpkRjkyWVhWc2RDOWpiMjUwY21GamRDNXdlVG95T1RVS0lDQWdJQzh2SUhaaGRXeDBYMkpoYkdGdVkyVWdQU0J6Wld4bUxuWmhkV3gwWDJKaGJHRnVZMlZ6VzNaaGRXeDBYMjkzYm1WeVhRb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNTJZWFZzZEY5aVlXeGhibU5sY3lCbGJuUnllU0JsZUdsemRITUtJQ0FnSUdKMGIya0tDbWRsZEY5MllYVnNkRjlwYm1adlgyRm1kR1Z5WDJsbVgyVnNjMlZBTkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwY25WemRGOTJZWFZzZEM5amIyNTBjbUZqZEM1d2VUb3lOeklLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdaR2xuSURNS0lDQWdJR2wwYjJJS0lDQWdJR1JwWnlBMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXpDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldNZ05pQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS1oyVjBYM1poZFd4MFgybHVabTlmWld4elpWOWliMlI1UURNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKMWMzUmZkbUYxYkhRdlkyOXVkSEpoWTNRdWNIazZNamszQ2lBZ0lDQXZMeUIyWVhWc2RGOWlZV3hoYm1ObElEMGdWVWx1ZERZMEtEQXBDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWWlCblpYUmZkbUYxYkhSZmFXNW1iMTloWm5SbGNsOXBabDlsYkhObFFEUUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11ZEhKMWMzUmZkbUYxYkhRdVkyOXVkSEpoWTNRdVZISjFjM1JXWVhWc2RDNW5aWFJmZEc5MFlXeGZkbUYxYkhSelczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taMlYwWDNSdmRHRnNYM1poZFd4MGN6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGNuVnpkRjkyWVhWc2RDOWpiMjUwY21GamRDNXdlVG96TVRRS0lDQWdJQzh2SUhSdmRHRnNMQ0JsZUdsemRITWdQU0J6Wld4bUxuUnZkR0ZzWDNaaGRXeDBjeTV0WVhsaVpTZ3BDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaWRHOTBZV3hmZG1GMWJIUnpJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwY25WemRGOTJZWFZzZEM5amIyNTBjbUZqZEM1d2VUb3pNVFVLSUNBZ0lDOHZJR2xtSUdWNGFYTjBjem9LSUNBZ0lHSjZJR2RsZEY5MGIzUmhiRjkyWVhWc2RITmZaV3h6WlY5aWIyUjVRRE1LSUNBZ0lHUjFjQW9LWjJWMFgzUnZkR0ZzWDNaaGRXeDBjMTloWm5SbGNsOXBibXhwYm1Wa1gzTnRZWEowWDJOdmJuUnlZV04wY3k1MGNuVnpkRjkyWVhWc2RDNWpiMjUwY21GamRDNVVjblZ6ZEZaaGRXeDBMbWRsZEY5MGIzUmhiRjkyWVhWc2RITkFORG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjblZ6ZEY5MllYVnNkQzlqYjI1MGNtRmpkQzV3ZVRvek1EWUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV01nTmlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LWjJWMFgzUnZkR0ZzWDNaaGRXeDBjMTlsYkhObFgySnZaSGxBTXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwY25WemRGOTJZWFZzZEM5amIyNTBjbUZqZEM1d2VUb3pNVGdLSUNBZ0lDOHZJSEpsZEhWeWJpQlZTVzUwTmpRb01Da0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKMWMzUmZkbUYxYkhRdlkyOXVkSEpoWTNRdWNIazZNekEyQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJR0lnWjJWMFgzUnZkR0ZzWDNaaGRXeDBjMTloWm5SbGNsOXBibXhwYm1Wa1gzTnRZWEowWDJOdmJuUnlZV04wY3k1MGNuVnpkRjkyWVhWc2RDNWpiMjUwY21GamRDNVVjblZ6ZEZaaGRXeDBMbWRsZEY5MGIzUmhiRjkyWVhWc2RITkFOQW89IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01TQXZMeUF4Q2lBZ0lDQnlaWFIxY200SyJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUdBUUFnQ0lETzJnT0E1NFFQSmdjR2IzZHVaWEpmQkdobGFYSUlhVzUwWlhKMllXd0hiR0Z6ZEY5b1lneDBiM1JoYkY5MllYVnNkSE1JWW1Gc1lXNWpaVjhFRlI5OGRURWJRUUJPTVJrVVJERVlSSUlKQkkyTW84b0UvY2FWd2dUcDV0K2lCRmlNY3drRVNKTkRYUVN5QmJuR0JMcVFxMVFFVlNKaU93U2ovSHJOTmhvQWpna0FDd0JzQUtVQXdnRHNBUU1CZkFIRUFoUUFNUmtVTVJnVUVFUWlRellhQVVrVkpCSkVOaG9DU1JVbEVrUVhTU0VFRDBSSklRVU9SREVBU1VzREUwUW9Td0ZRU2IxRkFSUkVTd0VwVHdWbVN3RXFUd1JtTWdkTEFpdFBBbVlpRnI4bkJVeFFJeGEvSXljRVpVRUFDVWtpQ0NjRVRHY2lReWNFSW1kQy8vY3hGaUlKU1RnUUloSkVNUUFvU3dGUXZVVUJSRXNCT0FCTEFSSkVTd0U0QnpJS0VrUk1PQWhKUkNjRlR3SlFTYjVFRjA4Q0NCYS9Ja00yR2dGSkZTUVNSREVBS0VzQlVMMUZBVVJKU3dJVFJDbFBBbVlpUXpZYUFVa1ZKUkpFRjBraEJBOUVTU0VGRGtReEFDaExBVkM5UlFGRVNTTXFZMFVCUkNwUEFtWWlRekVBS0VzQlVMMUZBVVJKSXl0alJRRkVLeklIWmlKRE5ob0JTUlVrRWtRb1N3RlFTYjFGQVVSTEFTTXBZMFJMQWlNclkwUkxBeU1xWTBRbkJVc0ZVRW05UlFGRVNiNUlGekVBU3dVU1JESUhUd1FKVHdNUFJFbEVzVElLVExJSVR3S3lCN0lBSXJJUUk3SUJzMHNDS1doTEFpdG9Ud0lxYUx4SXZFZ2pKd1JsUVFBTFNVRUFCMGtpQ1NjRVRHY2lRellhQVVrVkpSSkVGMGxFTVFBb1N3RlF2VVVCUkVraktXTkZBVVFuQlVzQlVFbTlSUUZFU2I1SUYwbExCQTlFU3dNSkZyK3hNZ3BQQXJJSXNnQ3lCeUt5RUNPeUFiTWlRellhQVVrVkpCSkVLRXNCVUwxRkFVUkpJeWxqVEU0Q1JFa2pLMk5NVGdKRVNTTXFZMHhPQWtRbkJVeFFTYjFGQVVFQUdVbStSQmRMQXhaTEJVeFFTd01XVUV3V1VDY0dURkN3SWtNalF2L25JeWNFWlVFQUNVa1dKd1pNVUxBaVF5TkMvL1E9IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6NCwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
