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

namespace Arc56.Generated.nickthelegend.puya_algo_ts_smartcontracts.SingleAgentContract_262dc54b
{


    public class SingleAgentContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public SingleAgentContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class Task : AVMObjectType
            {
                public ulong Id { get; set; }

                public bool Success { get; set; }

                public ulong Timestamp { get; set; }

                public string Details { get; set; }

                public Algorand.Address Executor { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vId.From(Id);
                    ret.AddRange(vId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSuccess = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vSuccess.From(Success);
                    ret.AddRange(vSuccess.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTimestamp.From(Timestamp);
                    ret.AddRange(vTimestamp.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDetails = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vDetails.From(Details);
                    stringRef[ret.Count] = vDetails.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExecutor = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vExecutor.From(Executor);
                    ret.AddRange(vExecutor.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Task Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new Task();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueId = vId.ToValue();
                    if (valueId is ulong vIdValue) { ret.Id = vIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSuccess = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vSuccess.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSuccess = vSuccess.ToValue();
                    if (valueSuccess is bool vSuccessValue) { ret.Success = vSuccessValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTimestamp.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTimestamp = vTimestamp.ToValue();
                    if (valueTimestamp is ulong vTimestampValue) { ret.Timestamp = vTimestampValue; }
                    var indexDetails = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDetails = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vDetails.Decode(bytes.Skip(indexDetails + prefixOffset).ToArray());
                    var valueDetails = vDetails.ToValue();
                    if (valueDetails is string vDetailsValue) { ret.Details = vDetailsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExecutor = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vExecutor.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueExecutor = vExecutor.ToValue();
                    if (valueExecutor is Algorand.Address vExecutorValue) { ret.Executor = vExecutorValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Task);
                }
                public bool Equals(Task? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Task left, Task right)
                {
                    return EqualityComparer<Task>.Default.Equals(left, right);
                }
                public static bool operator !=(Task left, Task right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="agentName"> </param>
        /// <param name="agentDetails"> </param>
        /// <param name="pricing"> </param>
        public async Task CreateApplication(string agentName, string agentDetails, ulong pricing, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 192, 75, 117, 244 };
            var agentNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); agentNameAbi.From(agentName);
            var agentDetailsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); agentDetailsAbi.From(agentDetails);
            var pricingAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); pricingAbi.From(pricing);

            var result = await base.CallApp(new List<object> { abiHandle, agentNameAbi, agentDetailsAbi, pricingAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(string agentName, string agentDetails, ulong pricing, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 192, 75, 117, 244 };
            var agentNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); agentNameAbi.From(agentName);
            var agentDetailsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); agentDetailsAbi.From(agentDetails);
            var pricingAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); pricingAbi.From(pricing);

            return await base.MakeTransactionList(new List<object> { abiHandle, agentNameAbi, agentDetailsAbi, pricingAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task BootStrap(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 213, 211, 35, 71 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> BootStrap_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 213, 211, 35, 71 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="payTxn"> </param>
        public async Task Pay(PaymentTransaction payTxn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payTxn });
            byte[] abiHandle = { 107, 104, 3, 24 };

            var result = await base.CallApp(new List<object> { abiHandle, payTxn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Pay_Transactions(PaymentTransaction payTxn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payTxn });
            byte[] abiHandle = { 107, 104, 3, 24 };

            return await base.MakeTransactionList(new List<object> { abiHandle, payTxn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="idx"> </param>
        /// <param name="updateSuccess"> </param>
        /// <param name="updateDetails"> </param>
        /// <param name="updateExecutor"> </param>
        /// <param name="success"> </param>
        /// <param name="details"> </param>
        /// <param name="executor"> </param>
        public async Task UpdateTask(ulong idx, bool updateSuccess, bool updateDetails, bool updateExecutor, bool success, string details, Algorand.Address executor, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 197, 70, 62, 234 };
            var idxAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); idxAbi.From(idx);
            var updateSuccessAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); updateSuccessAbi.From(updateSuccess);
            var updateDetailsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); updateDetailsAbi.From(updateDetails);
            var updateExecutorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); updateExecutorAbi.From(updateExecutor);
            var successAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); successAbi.From(success);
            var detailsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); detailsAbi.From(details);
            var executorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); executorAbi.From(executor);

            var result = await base.CallApp(new List<object> { abiHandle, idxAbi, updateSuccessAbi, updateDetailsAbi, updateExecutorAbi, successAbi, detailsAbi, executorAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateTask_Transactions(ulong idx, bool updateSuccess, bool updateDetails, bool updateExecutor, bool success, string details, Algorand.Address executor, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 197, 70, 62, 234 };
            var idxAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); idxAbi.From(idx);
            var updateSuccessAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); updateSuccessAbi.From(updateSuccess);
            var updateDetailsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); updateDetailsAbi.From(updateDetails);
            var updateExecutorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); updateExecutorAbi.From(updateExecutor);
            var successAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); successAbi.From(success);
            var detailsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); detailsAbi.From(details);
            var executorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); executorAbi.From(executor);

            return await base.MakeTransactionList(new List<object> { abiHandle, idxAbi, updateSuccessAbi, updateDetailsAbi, updateExecutorAbi, successAbi, detailsAbi, executorAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="to"> </param>
        /// <param name="amount"> </param>
        public async Task Withdraw(Address to, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { to });
            byte toRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 238, 51, 145, 47 };
            var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); toAbi.From(to);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, toRefIndex, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Withdraw_Transactions(Address to, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { to });
            byte toRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 238, 51, 145, 47 };
            var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); toAbi.From(to);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, toRefIndex, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="newOwner"> </param>
        public async Task TransferOwnership(Address newOwner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { newOwner });
            byte newOwnerRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 243, 186, 162, 112 };
            var newOwnerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); newOwnerAbi.From(newOwner);

            var result = await base.CallApp(new List<object> { abiHandle, newOwnerRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TransferOwnership_Transactions(Address newOwner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { newOwner });
            byte newOwnerRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 243, 186, 162, 112 };
            var newOwnerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); newOwnerAbi.From(newOwner);

            return await base.MakeTransactionList(new List<object> { abiHandle, newOwnerRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task TestLog(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 228, 115, 199, 10 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestLog_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 228, 115, 199, 10 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU2luZ2xlQWdlbnRDb250cmFjdCIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJUYXNrIjpbeyJuYW1lIjoiaWQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoic3VjY2VzcyIsInR5cGUiOiJib29sIn0seyJuYW1lIjoidGltZXN0YW1wIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImRldGFpbHMiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoiZXhlY3V0b3IiLCJ0eXBlIjoiYWRkcmVzcyJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGVBcHBsaWNhdGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZ2VudE5hbWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFnZW50RGV0YWlscyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJpY2luZyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJib290U3RyYXAiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicGF5IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheVR4biIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1cGRhdGVUYXNrIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImlkeCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVwZGF0ZVN1Y2Nlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1cGRhdGVEZXRhaWxzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoidXBkYXRlRXhlY3V0b3IiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzdWNjZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkZXRhaWxzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZXhlY3V0b3IiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoid2l0aGRyYXciLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWNjb3VudCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidHJhbnNmZXJPd25lcnNoaXAiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWNjb3VudCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld093bmVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3RfbG9nIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjo0LCJieXRlcyI6M30sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbNTIzXSwiZXJyb3JNZXNzYWdlIjoiQm94IG11c3QgaGF2ZSB2YWx1ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQwOV0sImVycm9yTWVzc2FnZSI6IkluY29ycmVjdCBwYXltZW50IGFtb3VudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU4NF0sImVycm9yTWVzc2FnZSI6IkluZGV4IGFjY2VzcyBpcyBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTM4LDE1MCwxNjgsMTkwLDIyNCwyNDYsMjU4XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIGlzIG5vdCBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjYyXSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQxLDE1MywxNzEsMTkzLDIyNywyNDldLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gbm90IGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzQwLDQwNyw0MTMsNjMwLDY5M10sImVycm9yTWVzc2FnZSI6ImNoZWNrIEdsb2JhbFN0YXRlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYzMiw2OTVdLCJlcnJvck1lc3NhZ2UiOiJvbmx5IG93bmVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzk4XSwiZXJyb3JNZXNzYWdlIjoicGF5bWVudCBtdXN0IGJlIHRvIGFwcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIzN10sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgcGF5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNQ0F4SURjME9UTTNPRFV5TWlBMkNpQWdJQ0JpZVhSbFkySnNiMk5ySUNKdmQyNWxja0ZrWkhKbGMzTWlJQ0owWVhOclEyOTFiblFpSURCNFpEZzVaR0poTkRrZ0ltNWhiV1VpSUNKbWFYaGxaRkJ5YVdOcGJtY2lJREI0TURBek15QXdlREF3TURjM016YzFOak0yTXpZMU56TTNNd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwRm5aVzUwTG1Gc1oyOHVkSE02TXpNS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QlRhVzVuYkdWQloyVnVkRU52Ym5SeVlXTjBJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lHSjZJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF4TXdvZ0lDQWdjSFZ6YUdKNWRHVnpjeUF3ZUdNd05HSTNOV1kwSURCNFpEVmtNekl6TkRjZ01IZzJZalk0TURNeE9DQXdlR00xTkRZelpXVmhJREI0WldVek16a3hNbVlnTUhobU0ySmhZVEkzTUNBd2VHVTBOek5qTnpCaElDOHZJRzFsZEdodlpDQWlZM0psWVhSbFFYQndiR2xqWVhScGIyNG9jM1J5YVc1bkxITjBjbWx1Wnl4MWFXNTBOalFwZG05cFpDSXNJRzFsZEdodlpDQWlZbTl2ZEZOMGNtRndLQ2wyYjJsa0lpd2diV1YwYUc5a0lDSndZWGtvY0dGNUtYWnZhV1FpTENCdFpYUm9iMlFnSW5Wd1pHRjBaVlJoYzJzb2RXbHVkRFkwTEdKdmIyd3NZbTl2YkN4aWIyOXNMR0p2YjJ3c2MzUnlhVzVuTEdGa1pISmxjM01wZG05cFpDSXNJRzFsZEdodlpDQWlkMmwwYUdSeVlYY29ZV05qYjNWdWRDeDFhVzUwTmpRcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpZEhKaGJuTm1aWEpQZDI1bGNuTm9hWEFvWVdOamIzVnVkQ2wyYjJsa0lpd2diV1YwYUc5a0lDSjBaWE4wWDJ4dlp5Z3BkbTlwWkNJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHMWhhVzVmWTNKbFlYUmxRWEJ3YkdsallYUnBiMjVmY205MWRHVkFNeUJ0WVdsdVgySnZiM1JUZEhKaGNGOXliM1YwWlVBMElHMWhhVzVmY0dGNVgzSnZkWFJsUURVZ2JXRnBibDkxY0dSaGRHVlVZWE5yWDNKdmRYUmxRRFlnYldGcGJsOTNhWFJvWkhKaGQxOXliM1YwWlVBM0lHMWhhVzVmZEhKaGJuTm1aWEpQZDI1bGNuTm9hWEJmY205MWRHVkFPQ0J0WVdsdVgzUmxjM1JmYkc5blgzSnZkWFJsUURrS0NtMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXhNem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OUJaMlZ1ZEM1aGJHZHZMblJ6T2pNekNpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdVMmx1WjJ4bFFXZGxiblJEYjI1MGNtRmpkQ0JsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZkR1Z6ZEY5c2IyZGZjbTkxZEdWQU9Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5QloyVnVkQzVoYkdkdkxuUnpPakUzTXdvZ0lDQWdMeThnZEdWemRGOXNiMmNvS1RvZ2RtOXBaSHNLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ1kyRnNiSE4xWWlCMFpYTjBYMnh2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDkwY21GdWMyWmxjazkzYm1WeWMyaHBjRjl5YjNWMFpVQTRPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwRm5aVzUwTG1Gc1oyOHVkSE02TVRZNENpQWdJQ0F2THlCMGNtRnVjMlpsY2s5M2JtVnljMmhwY0NodVpYZFBkMjVsY2pvZ1FXTmpiM1Z1ZENrNklIWnZhV1FnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZRV2RsYm5RdVlXeG5ieTUwY3pvek13b2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRk5wYm1kc1pVRm5aVzUwUTI5dWRISmhZM1FnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoY3lCQlkyTnZkVzUwY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMEZuWlc1MExtRnNaMjh1ZEhNNk1UWTRDaUFnSUNBdkx5QjBjbUZ1YzJabGNrOTNibVZ5YzJocGNDaHVaWGRQZDI1bGNqb2dRV05qYjNWdWRDazZJSFp2YVdRZ2V3b2dJQ0FnWTJGc2JITjFZaUIwY21GdWMyWmxjazkzYm1WeWMyaHBjQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOTNhWFJvWkhKaGQxOXliM1YwWlVBM09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDBGblpXNTBMbUZzWjI4dWRITTZNVE00Q2lBZ0lDQXZMeUIzYVhSb1pISmhkeWgwYnpvZ1FXTmpiM1Z1ZEN3Z1lXMXZkVzUwT2lCMWFXNTBOalFwT2lCMmIybGtJSHNLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwRm5aVzUwTG1Gc1oyOHVkSE02TXpNS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QlRhVzVuYkdWQloyVnVkRU52Ym5SeVlXTjBJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZWE1nUVdOamIzVnVkSE1LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OUJaMlZ1ZEM1aGJHZHZMblJ6T2pFek9Bb2dJQ0FnTHk4Z2QybDBhR1J5WVhjb2RHODZJRUZqWTI5MWJuUXNJR0Z0YjNWdWREb2dkV2x1ZERZMEtUb2dkbTlwWkNCN0NpQWdJQ0JqWVd4c2MzVmlJSGRwZEdoa2NtRjNDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzVndaR0YwWlZSaGMydGZjbTkxZEdWQU5qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5QloyVnVkQzVoYkdkdkxuUnpPakV4TlMweE1qTUtJQ0FnSUM4dklIVndaR0YwWlZSaGMyc29DaUFnSUNBdkx5QWdJR2xrZURvZ2RXbHVkRFkwTEFvZ0lDQWdMeThnSUNCMWNHUmhkR1ZUZFdOalpYTnpPaUJoY21NMExrSnZiMndzQ2lBZ0lDQXZMeUFnSUhWd1pHRjBaVVJsZEdGcGJITTZJR0Z5WXpRdVFtOXZiQ3dLSUNBZ0lDOHZJQ0FnZFhCa1lYUmxSWGhsWTNWMGIzSTZJR0Z5WXpRdVFtOXZiQ3dLSUNBZ0lDOHZJQ0FnYzNWalkyVnpjem9nWVhKak5DNUNiMjlzTEFvZ0lDQWdMeThnSUNCa1pYUmhhV3h6T2lCaGNtTTBMbE4wY2l3S0lDQWdJQzh2SUNBZ1pYaGxZM1YwYjNJNklFRmtaSEpsYzNNS0lDQWdJQzh2SUNrNklIWnZhV1FnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZRV2RsYm5RdVlXeG5ieTUwY3pvek13b2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRk5wYm1kc1pVRm5aVzUwUTI5dWRISmhZM1FnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUEwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUExQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUEyQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUEzQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZRV2RsYm5RdVlXeG5ieTUwY3pveE1UVXRNVEl6Q2lBZ0lDQXZMeUIxY0dSaGRHVlVZWE5yS0FvZ0lDQWdMeThnSUNCcFpIZzZJSFZwYm5RMk5Dd0tJQ0FnSUM4dklDQWdkWEJrWVhSbFUzVmpZMlZ6Y3pvZ1lYSmpOQzVDYjI5c0xBb2dJQ0FnTHk4Z0lDQjFjR1JoZEdWRVpYUmhhV3h6T2lCaGNtTTBMa0p2YjJ3c0NpQWdJQ0F2THlBZ0lIVndaR0YwWlVWNFpXTjFkRzl5T2lCaGNtTTBMa0p2YjJ3c0NpQWdJQ0F2THlBZ0lITjFZMk5sYzNNNklHRnlZelF1UW05dmJDd0tJQ0FnSUM4dklDQWdaR1YwWVdsc2N6b2dZWEpqTkM1VGRISXNDaUFnSUNBdkx5QWdJR1Y0WldOMWRHOXlPaUJCWkdSeVpYTnpDaUFnSUNBdkx5QXBPaUIyYjJsa0lIc0tJQ0FnSUdOaGJHeHpkV0lnZFhCa1lYUmxWR0Z6YXdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDl3WVhsZmNtOTFkR1ZBTlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlCWjJWdWRDNWhiR2R2TG5Sek9qYzRDaUFnSUNBdkx5QndZWGtvY0dGNVZIaHVPaUJuZEhodUxsQmhlVzFsYm5SVWVHNHBPaUIyYjJsa0lIc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDBGblpXNTBMbUZzWjI4dWRITTZNek1LSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCVGFXNW5iR1ZCWjJWdWRFTnZiblJ5WVdOMElHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0F0Q2lBZ0lDQmtkWEFLSUNBZ0lHZDBlRzV6SUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdjR0Y1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklIUnlZVzV6WVdOMGFXOXVJSFI1Y0dVZ2FYTWdjR0Y1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZRV2RsYm5RdVlXeG5ieTUwY3pvM09Bb2dJQ0FnTHk4Z2NHRjVLSEJoZVZSNGJqb2daM1I0Ymk1UVlYbHRaVzUwVkhodUtUb2dkbTlwWkNCN0NpQWdJQ0JqWVd4c2MzVmlJSEJoZVFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlpYjI5MFUzUnlZWEJmY205MWRHVkFORG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OUJaMlZ1ZEM1aGJHZHZMblJ6T2pZeUNpQWdJQ0F2THlCaWIyOTBVM1J5WVhBb0tYc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnWTJGc2JITjFZaUJpYjI5MFUzUnlZWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZM0psWVhSbFFYQndiR2xqWVhScGIyNWZjbTkxZEdWQU16b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5QloyVnVkQzVoYkdkdkxuUnpPalV5Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12UVdkbGJuUXVZV3huYnk1MGN6b3pNd29nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUZOcGJtZHNaVUZuWlc1MFEyOXVkSEpoWTNRZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OUJaMlZ1ZEM1aGJHZHZMblJ6T2pVeUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdOaGJHeHpkV0lnWTNKbFlYUmxRWEJ3YkdsallYUnBiMjRLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlFXZGxiblF1WVd4bmJ5NTBjem82VTJsdVoyeGxRV2RsYm5SRGIyNTBjbUZqZEM1amNtVmhkR1ZCY0hCc2FXTmhkR2x2YmloaFoyVnVkRTVoYldVNklHSjVkR1Z6TENCaFoyVnVkRVJsZEdGcGJITTZJR0o1ZEdWekxDQndjbWxqYVc1bk9pQjFhVzUwTmpRcElDMCtJSFp2YVdRNkNtTnlaV0YwWlVGd2NHeHBZMkYwYVc5dU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDBGblpXNTBMbUZzWjI4dWRITTZOVEl0TlRNS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnTHk4Z1kzSmxZWFJsUVhCd2JHbGpZWFJwYjI0b1lXZGxiblJPWVcxbE9pQnpkSEpwYm1jc0lHRm5aVzUwUkdWMFlXbHNjem9nYzNSeWFXNW5MQ0J3Y21samFXNW5PaUIxYVc1ME5qUXBPaUIyYjJsa0lIc0tJQ0FnSUhCeWIzUnZJRE1nTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMEZuWlc1MExtRnNaMjh1ZEhNNk5ESUtJQ0FnSUM4dklHOTNibVZ5UVdSa2NtVnpjeUE5SUVkc2IySmhiRk4wWVhSbFBFRmpZMjkxYm5RK0tDazdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnZkMjVsY2tGa1pISmxjM01pQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZRV2RsYm5RdVlXeG5ieTUwY3pvMU5Rb2dJQ0FnTHk4Z2RHaHBjeTV2ZDI1bGNrRmtaSEpsYzNNdWRtRnNkV1VnUFNCVWVHNHVjMlZ1WkdWeUlEc0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12UVdkbGJuUXVZV3huYnk1MGN6b3pOUW9nSUNBZ0x5OGdibUZ0WlNBOUlFZHNiMkpoYkZOMFlYUmxQSE4wY21sdVp6NG9LVHNLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbTVoYldVaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12UVdkbGJuUXVZV3huYnk1MGN6bzFOZ29nSUNBZ0x5OGdkR2hwY3k1dVlXMWxMblpoYkhWbElEMGdZV2RsYm5ST1lXMWxPd29nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwRm5aVzUwTG1Gc1oyOHVkSE02TXpZS0lDQWdJQzh2SUdSbGRHRnBiSE1nUFNCSGJHOWlZV3hUZEdGMFpUeHpkSEpwYm1jK0tDazdDaUFnSUNCd2RYTm9ZbmwwWlhNZ0ltUmxkR0ZwYkhNaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12UVdkbGJuUXVZV3huYnk1MGN6bzFOd29nSUNBZ0x5OGdkR2hwY3k1a1pYUmhhV3h6TG5aaGJIVmxJRDBnWVdkbGJuUkVaWFJoYVd4ek93b2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDBGblpXNTBMbUZzWjI4dWRITTZOVGdLSUNBZ0lDOHZJSFJvYVhNdVptbDRaV1JRY21samFXNW5MblpoYkhWbElEMGdWV2x1ZERZMEtIQnlhV05wYm1jZ0tpQXhYekF3TUY4d01EQXBPd29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCd2RYTm9hVzUwSURFd01EQXdNREFnTHk4Z01UQXdNREF3TUFvZ0lDQWdLZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwRm5aVzUwTG1Gc1oyOHVkSE02TXpjS0lDQWdJQzh2SUdacGVHVmtVSEpwWTJsdVp5QTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvS1RzS0lDQWdJR0o1ZEdWaklEUWdMeThnSW1acGVHVmtVSEpwWTJsdVp5SUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5QloyVnVkQzVoYkdkdkxuUnpPalU0Q2lBZ0lDQXZMeUIwYUdsekxtWnBlR1ZrVUhKcFkybHVaeTUyWVd4MVpTQTlJRlZwYm5RMk5DaHdjbWxqYVc1bklDb2dNVjh3TURCZk1EQXdLVHNLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZRV2RsYm5RdVlXeG5ieTUwY3pvME1Bb2dJQ0FnTHk4Z1kzSmxZWFJsWkVGMElEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWdwT3dvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pqY21WaGRHVmtRWFFpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZRV2RsYm5RdVlXeG5ieTUwY3pvMU9Rb2dJQ0FnTHk4Z2RHaHBjeTVqY21WaGRHVmtRWFF1ZG1Gc2RXVWdQU0JIYkc5aVlXd3ViR0YwWlhOMFZHbHRaWE4wWVcxd093b2dJQ0FnWjJ4dlltRnNJRXhoZEdWemRGUnBiV1Z6ZEdGdGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5QloyVnVkQzVoYkdkdkxuUnpPalEwQ2lBZ0lDQXZMeUIwWVhOclEyOTFiblFnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tDazdDaUFnSUNCaWVYUmxZMTh4SUM4dklDSjBZWE5yUTI5MWJuUWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlFXZGxiblF1WVd4bmJ5NTBjem8yTUFvZ0lDQWdMeThnZEdocGN5NTBZWE5yUTI5MWJuUXVkbUZzZFdVZ1BTQXhPd29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlFXZGxiblF1WVd4bmJ5NTBjem82VTJsdVoyeGxRV2RsYm5SRGIyNTBjbUZqZEM1aWIyOTBVM1J5WVhBb0tTQXRQaUIyYjJsa09ncGliMjkwVTNSeVlYQTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlFXZGxiblF1WVd4bmJ5NTBjem8yTXkwM01Bb2dJQ0FnTHk4Z1kyOXVjM1FnYVhSNGJsSmxjM1ZzZENBOUlHbDBlRzRLSUNBZ0lDOHZJQ0FnTG1GemMyVjBRMjl1Wm1sbktIc0tJQ0FnSUM4dklDQWdJQ0IwYjNSaGJEb2dNVEF3WHpBd01GOHdNREJmTURBd0xBb2dJQ0FnTHk4Z0lDQWdJR1JsWTJsdFlXeHpPaUF5TEFvZ0lDQWdMeThnSUNBZ0lIVnVhWFJPWVcxbE9pQW5VbEFuTEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwVG1GdFpUb2dkR2hwY3k1dVlXMWxMblpoYkhWbExBb2dJQ0FnTHk4Z0lDQjlLUW9nSUNBZ0x5OGdJQ0F1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5QloyVnVkQzVoYkdkdkxuUnpPak0xQ2lBZ0lDQXZMeUJ1WVcxbElEMGdSMnh2WW1Gc1UzUmhkR1U4YzNSeWFXNW5QaWdwT3dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbTVoYldVaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JEYjI1bWFXZEJjM05sZEU1aGJXVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5QloyVnVkQzVoYkdkdkxuUnpPalkzQ2lBZ0lDQXZMeUIxYm1sMFRtRnRaVG9nSjFKUUp5d0tJQ0FnSUhCMWMyaGllWFJsY3lBaVVsQWlDaUFnSUNCcGRIaHVYMlpwWld4a0lFTnZibVpwWjBGemMyVjBWVzVwZEU1aGJXVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5QloyVnVkQzVoYkdkdkxuUnpPalkyQ2lBZ0lDQXZMeUJrWldOcGJXRnNjem9nTWl3S0lDQWdJSEIxYzJocGJuUWdNaUF2THlBeUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVOdmJtWnBaMEZ6YzJWMFJHVmphVzFoYkhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlCWjJWdWRDNWhiR2R2TG5Sek9qWTFDaUFnSUNBdkx5QjBiM1JoYkRvZ01UQXdYekF3TUY4d01EQmZNREF3TEFvZ0lDQWdjSFZ6YUdsdWRDQXhNREF3TURBd01EQXdNREFnTHk4Z01UQXdNREF3TURBd01EQXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFTnZibVpwWjBGemMyVjBWRzkwWVd3S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlCWjJWdWRDNWhiR2R2TG5Sek9qWXpMVFk1Q2lBZ0lDQXZMeUJqYjI1emRDQnBkSGh1VW1WemRXeDBJRDBnYVhSNGJnb2dJQ0FnTHk4Z0lDQXVZWE56WlhSRGIyNW1hV2NvZXdvZ0lDQWdMeThnSUNBZ0lIUnZkR0ZzT2lBeE1EQmZNREF3WHpBd01GOHdNREFzQ2lBZ0lDQXZMeUFnSUNBZ1pHVmphVzFoYkhNNklESXNDaUFnSUNBdkx5QWdJQ0FnZFc1cGRFNWhiV1U2SUNkU1VDY3NDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUk9ZVzFsT2lCMGFHbHpMbTVoYldVdWRtRnNkV1VzQ2lBZ0lDQXZMeUFnSUgwcENpQWdJQ0J3ZFhOb2FXNTBJRE1nTHk4Z013b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZRV2RsYm5RdVlXeG5ieTUwY3pvMk15MDNNQW9nSUNBZ0x5OGdZMjl1YzNRZ2FYUjRibEpsYzNWc2RDQTlJR2wwZUc0S0lDQWdJQzh2SUNBZ0xtRnpjMlYwUTI5dVptbG5LSHNLSUNBZ0lDOHZJQ0FnSUNCMGIzUmhiRG9nTVRBd1h6QXdNRjh3TURCZk1EQXdMQW9nSUNBZ0x5OGdJQ0FnSUdSbFkybHRZV3h6T2lBeUxBb2dJQ0FnTHk4Z0lDQWdJSFZ1YVhST1lXMWxPaUFuVWxBbkxBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFRtRnRaVG9nZEdocGN5NXVZVzFsTG5aaGJIVmxMQW9nSUNBZ0x5OGdJQ0I5S1FvZ0lDQWdMeThnSUNBdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZRV2RsYm5RdVlXeG5ieTUwY3pvek9Bb2dJQ0FnTHk4Z1lXZGxiblJCYzNObGRFbEVJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGlncE93b2dJQ0FnY0hWemFHSjVkR1Z6SUNKaFoyVnVkRUZ6YzJWMFNVUWlDaUFnSUNCcGRIaHVJRU55WldGMFpXUkJjM05sZEVsRUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12UVdkbGJuUXVZV3huYnk1MGN6bzNNd29nSUNBZ0x5OGdkR2hwY3k1aFoyVnVkRUZ6YzJWMFNVUXVkbUZzZFdVZ1BTQnBkSGh1VW1WemRXeDBMbU55WldGMFpXUkJjM05sZEM1cFpEc0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlFXZGxiblF1WVd4bmJ5NTBjem82VTJsdVoyeGxRV2RsYm5SRGIyNTBjbUZqZEM1d1lYa29jR0Y1VkhodU9pQjFhVzUwTmpRcElDMCtJSFp2YVdRNkNuQmhlVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OUJaMlZ1ZEM1aGJHZHZMblJ6T2pjNENpQWdJQ0F2THlCd1lYa29jR0Y1VkhodU9pQm5kSGh1TGxCaGVXMWxiblJVZUc0cE9pQjJiMmxrSUhzS0lDQWdJSEJ5YjNSdklERWdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwRm5aVzUwTG1Gc1oyOHVkSE02T0RFS0lDQWdJQzh2SUdGemMyVnlkQ2h3WVhsVWVHNHVjbVZqWldsMlpYSWdQVDA5SUVkc2IySmhiQzVqZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpMQ0FuY0dGNWJXVnVkQ0J0ZFhOMElHSmxJSFJ2SUdGd2NDY3BPd29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCbmRIaHVjeUJTWldObGFYWmxjZ29nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2NHRjViV1Z1ZENCdGRYTjBJR0psSUhSdklHRndjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwRm5aVzUwTG1Gc1oyOHVkSE02T0RJS0lDQWdJQzh2SUdGemMyVnlkQ2h3WVhsVWVHNHVZVzF2ZFc1MElEMDlQU0IwYUdsekxtWnBlR1ZrVUhKcFkybHVaeTUyWVd4MVpTd2dKMGx1WTI5eWNtVmpkQ0J3WVhsdFpXNTBJR0Z0YjNWdWRDY3BPd29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCbmRIaHVjeUJCYlc5MWJuUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5QloyVnVkQzVoYkdkdkxuUnpPak0zQ2lBZ0lDQXZMeUJtYVhobFpGQnlhV05wYm1jZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLQ2s3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTkNBdkx5QWlabWw0WldSUWNtbGphVzVuSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OUJaMlZ1ZEM1aGJHZHZMblJ6T2pneUNpQWdJQ0F2THlCaGMzTmxjblFvY0dGNVZIaHVMbUZ0YjNWdWRDQTlQVDBnZEdocGN5NW1hWGhsWkZCeWFXTnBibWN1ZG1Gc2RXVXNJQ2RKYm1OdmNuSmxZM1FnY0dGNWJXVnVkQ0JoYlc5MWJuUW5LVHNLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1NXNWpiM0p5WldOMElIQmhlVzFsYm5RZ1lXMXZkVzUwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZRV2RsYm5RdVlXeG5ieTUwY3pvME5Bb2dJQ0FnTHk4Z2RHRnphME52ZFc1MElEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWdwT3dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJblJoYzJ0RGIzVnVkQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlFXZGxiblF1WVd4bmJ5NTBjem80T1FvZ0lDQWdMeThnYVdRNklHNWxkeUJoY21NMExsVnBiblJPTmpRb2FXUjRLU3dLSUNBZ0lHUjFjQW9nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwRm5aVzUwTG1Gc1oyOHVkSE02T1RFS0lDQWdJQzh2SUhScGJXVnpkR0Z0Y0RvZ2JtVjNJR0Z5WXpRdVZXbHVkRTQyTkNoSGJHOWlZV3d1YkdGMFpYTjBWR2x0WlhOMFlXMXdLU3dLSUNBZ0lHZHNiMkpoYkNCTVlYUmxjM1JVYVcxbGMzUmhiWEFLSUNBZ0lHbDBiMklLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OUJaMlZ1ZEM1aGJHZHZMblJ6T2prekNpQWdJQ0F2THlCbGVHVmpkWFJ2Y2pvZ2JtVjNJRUZrWkhKbGMzTW9jR0Y1VkhodUxuTmxibVJsY2lrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdaM1I0Ym5NZ1UyVnVaR1Z5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZRV2RsYm5RdVlXeG5ieTUwY3pvNE9DMDVOQW9nSUNBZ0x5OGdZMjl1YzNRZ2RHRnpheUE5SUc1bGR5QlVZWE5yS0hzS0lDQWdJQzh2SUNBZ2FXUTZJRzVsZHlCaGNtTTBMbFZwYm5ST05qUW9hV1I0S1N3S0lDQWdJQzh2SUNBZ2MzVmpZMlZ6Y3pvZ2JtVjNJR0Z5WXpRdVFtOXZiQ2htWVd4elpTa3NDaUFnSUNBdkx5QWdJSFJwYldWemRHRnRjRG9nYm1WM0lHRnlZelF1VldsdWRFNDJOQ2hIYkc5aVlXd3ViR0YwWlhOMFZHbHRaWE4wWVcxd0tTd0tJQ0FnSUM4dklDQWdaR1YwWVdsc2N6b2dibVYzSUdGeVl6UXVVM1J5S0NKUVlYbHRaVzUwSUVSdmJtVWhJU3dnVkdGemF5QkRjbVZoZEdWa0lpa3NDaUFnSUNBdkx5QWdJR1Y0WldOMWRHOXlPaUJ1WlhjZ1FXUmtjbVZ6Y3lod1lYbFVlRzR1YzJWdVpHVnlLUW9nSUNBZ0x5OGdmU2s3Q2lBZ0lDQmthV2NnTWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMEZuWlc1MExtRnNaMjh1ZEhNNk9UQUtJQ0FnSUM4dklITjFZMk5sYzNNNklHNWxkeUJoY21NMExrSnZiMndvWm1Gc2MyVXBMQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OUJaMlZ1ZEM1aGJHZHZMblJ6T2pnNExUazBDaUFnSUNBdkx5QmpiMjV6ZENCMFlYTnJJRDBnYm1WM0lGUmhjMnNvZXdvZ0lDQWdMeThnSUNCcFpEb2dibVYzSUdGeVl6UXVWV2x1ZEU0Mk5DaHBaSGdwTEFvZ0lDQWdMeThnSUNCemRXTmpaWE56T2lCdVpYY2dZWEpqTkM1Q2IyOXNLR1poYkhObEtTd0tJQ0FnSUM4dklDQWdkR2x0WlhOMFlXMXdPaUJ1WlhjZ1lYSmpOQzVWYVc1MFRqWTBLRWRzYjJKaGJDNXNZWFJsYzNSVWFXMWxjM1JoYlhBcExBb2dJQ0FnTHk4Z0lDQmtaWFJoYVd4ek9pQnVaWGNnWVhKak5DNVRkSElvSWxCaGVXMWxiblFnUkc5dVpTRWhMQ0JVWVhOcklFTnlaV0YwWldRaUtTd0tJQ0FnSUM4dklDQWdaWGhsWTNWMGIzSTZJRzVsZHlCQlpHUnlaWE56S0hCaGVWUjRiaTV6Wlc1a1pYSXBDaUFnSUNBdkx5QjlLVHNLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdNSGd3TURNekNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwRm5aVzUwTG1Gc1oyOHVkSE02T1RJS0lDQWdJQzh2SUdSbGRHRnBiSE02SUc1bGR5QmhjbU0wTGxOMGNpZ2lVR0Y1YldWdWRDQkViMjVsSVNFc0lGUmhjMnNnUTNKbFlYUmxaQ0lwTEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBeFl6VXdOakUzT1Raa05qVTJaVGMwTWpBME5EWm1ObVUyTlRJeE1qRXlZekl3TlRRMk1UY3pObUl5TURRek56STJOVFl4TnpRMk5UWTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlFXZGxiblF1WVd4bmJ5NTBjem80T0MwNU5Bb2dJQ0FnTHk4Z1kyOXVjM1FnZEdGemF5QTlJRzVsZHlCVVlYTnJLSHNLSUNBZ0lDOHZJQ0FnYVdRNklHNWxkeUJoY21NMExsVnBiblJPTmpRb2FXUjRLU3dLSUNBZ0lDOHZJQ0FnYzNWalkyVnpjem9nYm1WM0lHRnlZelF1UW05dmJDaG1ZV3h6WlNrc0NpQWdJQ0F2THlBZ0lIUnBiV1Z6ZEdGdGNEb2dibVYzSUdGeVl6UXVWV2x1ZEU0Mk5DaEhiRzlpWVd3dWJHRjBaWE4wVkdsdFpYTjBZVzF3S1N3S0lDQWdJQzh2SUNBZ1pHVjBZV2xzY3pvZ2JtVjNJR0Z5WXpRdVUzUnlLQ0pRWVhsdFpXNTBJRVJ2Ym1VaElTd2dWR0Z6YXlCRGNtVmhkR1ZrSWlrc0NpQWdJQ0F2THlBZ0lHVjRaV04xZEc5eU9pQnVaWGNnUVdSa2NtVnpjeWh3WVhsVWVHNHVjMlZ1WkdWeUtRb2dJQ0FnTHk4Z2ZTazdDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OUJaMlZ1ZEM1aGJHZHZMblJ6T2prMkNpQWdJQ0F2THlCMGFHbHpMblJoYzJ0Q2IzZ29hV1I0S1M1MllXeDFaU0E5SUhSaGMyc3VZMjl3ZVNncE93b2dJQ0FnWkdsbklERUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMEZuWlc1MExtRnNaMjh1ZEhNNk9Ua0tJQ0FnSUM4dklIUm9hWE11ZEdGemEwTnZkVzUwTG5aaGJIVmxJRDBnS0dsa2VDQXJJQ2d4SUdGeklIVnBiblEyTkNrcElHRnpJSFZwYm5RMk5Ec0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0FyQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZRV2RsYm5RdVlXeG5ieTUwY3pvME5Bb2dJQ0FnTHk4Z2RHRnphME52ZFc1MElEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWdwT3dvZ0lDQWdZbmwwWldOZk1TQXZMeUFpZEdGemEwTnZkVzUwSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMEZuWlc1MExtRnNaMjh1ZEhNNk9Ua0tJQ0FnSUM4dklIUm9hWE11ZEdGemEwTnZkVzUwTG5aaGJIVmxJRDBnS0dsa2VDQXJJQ2d4SUdGeklIVnBiblEyTkNrcElHRnpJSFZwYm5RMk5Ec0tJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlFXZGxiblF1WVd4bmJ5NTBjem94TURNdE1UQTVDaUFnSUNBdkx5QmpiMjV6ZENCallXeHNWSGh1SUQwZ2FYUjRiZ29nSUNBZ0x5OGdJQ0FnSUNBZ0xtRndjR3hwWTJGMGFXOXVRMkZzYkNoN0NpQWdJQ0F2THlBZ1lYQndTV1E2WVhCd1NVUXNDaUFnSUNBdkx5QWdJQ0FnWm1WbE9pQXdMQW9nSUNBZ0x5OGdJQ0FnSUdGd2NFRnlaM002SUZ0aGNtTTBMbTFsZEdodlpGTmxiR1ZqZEc5eUtDZGxiV2wwWDJ4dlp5aHpkSEpwYm1jc2MzUnlhVzVuTEhOMGNtbHVaeWtuS1N3Z2JtVjNJR0Z5WXpRdVUzUnlLQ2R3WVhrbktTd2dSMnh2WW1Gc0xtTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrbGtMbWxrTENCdVpYY2dZWEpqTkM1VGRISW9Jbk4xWTJObGMzTWlLU0JkTEFvZ0lDQWdMeThnSUNBZ0lDQWdmU2tLSUNBZ0lDOHZJQ0FnSUNBZ0lDNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMEZuWlc1MExtRnNaMjh1ZEhNNk1UQTNDaUFnSUNBdkx5QmhjSEJCY21kek9pQmJZWEpqTkM1dFpYUm9iMlJUWld4bFkzUnZjaWduWlcxcGRGOXNiMmNvYzNSeWFXNW5MSE4wY21sdVp5eHpkSEpwYm1jcEp5a3NJRzVsZHlCaGNtTTBMbE4wY2lnbmNHRjVKeWtzSUVkc2IySmhiQzVqZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVKWkM1cFpDd2dibVYzSUdGeVl6UXVVM1J5S0NKemRXTmpaWE56SWlrZ1hTd0tJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1pQXZMeUJ0WlhSb2IyUWdJbVZ0YVhSZmJHOW5LSE4wY21sdVp5eHpkSEpwYm1jc2MzUnlhVzVuS1NJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNREF6TnpBMk1UYzVDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdKNWRHVmpJRFlnTHk4Z01IZ3dNREEzTnpNM05UWXpOak0yTlRjek56TUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZRV2RsYm5RdVlXeG5ieTUwY3pveE1ERUtJQ0FnSUM4dklHTnZibk4wSUdGd2NFbEVJRDBnSUVGd2NHeHBZMkYwYVc5dUtEYzBPVE0zT0RVeU1pazdDaUFnSUNCcGJuUmpYeklnTHk4Z056UTVNemM0TlRJeUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5QloyVnVkQzVoYkdkdkxuUnpPakV3TXkweE1EZ0tJQ0FnSUM4dklHTnZibk4wSUdOaGJHeFVlRzRnUFNCcGRIaHVDaUFnSUNBdkx5QWdJQ0FnSUNBdVlYQndiR2xqWVhScGIyNURZV3hzS0hzS0lDQWdJQzh2SUNCaGNIQkpaRHBoY0hCSlJDd0tJQ0FnSUM4dklDQWdJQ0JtWldVNklEQXNDaUFnSUNBdkx5QWdJQ0FnWVhCd1FYSm5jem9nVzJGeVl6UXViV1YwYUc5a1UyVnNaV04wYjNJb0oyVnRhWFJmYkc5bktITjBjbWx1Wnl4emRISnBibWNzYzNSeWFXNW5LU2NwTENCdVpYY2dZWEpqTkM1VGRISW9KM0JoZVNjcExDQkhiRzlpWVd3dVkzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVNXUXVhV1FzSUc1bGR5QmhjbU0wTGxOMGNpZ2ljM1ZqWTJWemN5SXBJRjBzQ2lBZ0lDQXZMeUFnSUNBZ0lDQjlLUW9nSUNBZ2FXNTBZMTh6SUM4dklEWUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlCWjJWdWRDNWhiR2R2TG5Sek9qRXdOZ29nSUNBZ0x5OGdabVZsT2lBd0xBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12UVdkbGJuUXVZV3huYnk1MGN6b3hNRE10TVRBNUNpQWdJQ0F2THlCamIyNXpkQ0JqWVd4c1ZIaHVJRDBnYVhSNGJnb2dJQ0FnTHk4Z0lDQWdJQ0FnTG1Gd2NHeHBZMkYwYVc5dVEyRnNiQ2g3Q2lBZ0lDQXZMeUFnWVhCd1NXUTZZWEJ3U1VRc0NpQWdJQ0F2THlBZ0lDQWdabVZsT2lBd0xBb2dJQ0FnTHk4Z0lDQWdJR0Z3Y0VGeVozTTZJRnRoY21NMExtMWxkR2h2WkZObGJHVmpkRzl5S0NkbGJXbDBYMnh2WnloemRISnBibWNzYzNSeWFXNW5MSE4wY21sdVp5a25LU3dnYm1WM0lHRnlZelF1VTNSeUtDZHdZWGtuS1N3Z1IyeHZZbUZzTG1OMWNuSmxiblJCY0hCc2FXTmhkR2x2Ymtsa0xtbGtMQ0J1WlhjZ1lYSmpOQzVUZEhJb0luTjFZMk5sYzNNaUtTQmRMQW9nSUNBZ0x5OGdJQ0FnSUNBZ2ZTa0tJQ0FnSUM4dklDQWdJQ0FnSUM1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OUJaMlZ1ZEM1aGJHZHZMblJ6T2pwVGFXNW5iR1ZCWjJWdWRFTnZiblJ5WVdOMExuVndaR0YwWlZSaGMyc29hV1I0T2lCMWFXNTBOalFzSUhWd1pHRjBaVk4xWTJObGMzTTZJR0o1ZEdWekxDQjFjR1JoZEdWRVpYUmhhV3h6T2lCaWVYUmxjeXdnZFhCa1lYUmxSWGhsWTNWMGIzSTZJR0o1ZEdWekxDQnpkV05qWlhOek9pQmllWFJsY3l3Z1pHVjBZV2xzY3pvZ1lubDBaWE1zSUdWNFpXTjFkRzl5T2lCaWVYUmxjeWtnTFQ0Z2RtOXBaRG9LZFhCa1lYUmxWR0Z6YXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlCWjJWdWRDNWhiR2R2TG5Sek9qRXhOUzB4TWpNS0lDQWdJQzh2SUhWd1pHRjBaVlJoYzJzb0NpQWdJQ0F2THlBZ0lHbGtlRG9nZFdsdWREWTBMQW9nSUNBZ0x5OGdJQ0IxY0dSaGRHVlRkV05qWlhOek9pQmhjbU0wTGtKdmIyd3NDaUFnSUNBdkx5QWdJSFZ3WkdGMFpVUmxkR0ZwYkhNNklHRnlZelF1UW05dmJDd0tJQ0FnSUM4dklDQWdkWEJrWVhSbFJYaGxZM1YwYjNJNklHRnlZelF1UW05dmJDd0tJQ0FnSUM4dklDQWdjM1ZqWTJWemN6b2dZWEpqTkM1Q2IyOXNMQW9nSUNBZ0x5OGdJQ0JrWlhSaGFXeHpPaUJoY21NMExsTjBjaXdLSUNBZ0lDOHZJQ0FnWlhobFkzVjBiM0k2SUVGa1pISmxjM01LSUNBZ0lDOHZJQ2s2SUhadmFXUWdld29nSUNBZ2NISnZkRzhnTnlBd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaSFZ3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZRV2RsYm5RdVlXeG5ieTUwY3pveE1qUUtJQ0FnSUM4dklHTnZibk4wSUdOMWNuSmxiblJVWVhOcklEMGdkR2hwY3k1MFlYTnJRbTk0S0dsa2VDa3VkbUZzZFdVdVkyOXdlU2dwT3dvZ0lDQWdabkpoYldWZlpHbG5JQzAzQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJDYjNnZ2JYVnpkQ0JvWVhabElIWmhiSFZsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZRV2RsYm5RdVlXeG5ieTUwY3pveE1qa0tJQ0FnSUM4dklIUnBiV1Z6ZEdGdGNEb2dibVYzSUdGeVl6UXVWV2x1ZEU0Mk5DaEhiRzlpWVd3dWJHRjBaWE4wVkdsdFpYTjBZVzF3S1N3S0lDQWdJR2RzYjJKaGJDQk1ZWFJsYzNSVWFXMWxjM1JoYlhBS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlCWjJWdWRDNWhiR2R2TG5Sek9qRXpNQW9nSUNBZ0x5OGdjM1ZqWTJWemN6b2dkWEJrWVhSbFUzVmpZMlZ6Y3k1dVlYUnBkbVVnUHlCemRXTmpaWE56SURvZ1kzVnljbVZ1ZEZSaGMyc3VjM1ZqWTJWemN5d0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE5nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2RsZEdKcGRBb2dJQ0FnWW5vZ2RYQmtZWFJsVkdGemExOTBaWEp1WVhKNVgyWmhiSE5sUURJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdabkpoYldWZlluVnllU0F3Q2dwMWNHUmhkR1ZVWVhOclgzUmxjbTVoY25sZmJXVnlaMlZBTXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlCWjJWdWRDNWhiR2R2TG5Sek9qRXpNUW9nSUNBZ0x5OGdaR1YwWVdsc2N6b2dkWEJrWVhSbFJHVjBZV2xzY3k1dVlYUnBkbVVnUHlCa1pYUmhhV3h6SURvZ1kzVnljbVZ1ZEZSaGMyc3VaR1YwWVdsc2N5d0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE5Rb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2RsZEdKcGRBb2dJQ0FnWW5vZ2RYQmtZWFJsVkdGemExOTBaWEp1WVhKNVgyWmhiSE5sUURVS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdabkpoYldWZlluVnllU0F4Q2dwMWNHUmhkR1ZVWVhOclgzUmxjbTVoY25sZmJXVnlaMlZBTmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlCWjJWdWRDNWhiR2R2TG5Sek9qRXpNZ29nSUNBZ0x5OGdaWGhsWTNWMGIzSTZJSFZ3WkdGMFpVVjRaV04xZEc5eUxtNWhkR2wyWlNBL0lHVjRaV04xZEc5eUlEb2dZM1Z5Y21WdWRGUmhjMnN1WlhobFkzVjBiM0lzQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCblpYUmlhWFFLSUNBZ0lHSjZJSFZ3WkdGMFpWUmhjMnRmZEdWeWJtRnllVjltWVd4elpVQTRDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtDblZ3WkdGMFpWUmhjMnRmZEdWeWJtRnllVjl0WlhKblpVQTVPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwRm5aVzUwTG1Gc1oyOHVkSE02TVRJM0xURXpNd29nSUNBZ0x5OGdJQ0FnSUdOdmJuTjBJSFZ3WkdGMFpXUlVZWE5ySUQwZ2JtVjNJRlJoYzJzb2V3b2dJQ0FnTHk4Z0lDQnBaRG9nYm1WM0lHRnlZelF1VldsdWRFNDJOQ2hwWkhncExBb2dJQ0FnTHk4Z0lDQjBhVzFsYzNSaGJYQTZJRzVsZHlCaGNtTTBMbFZwYm5ST05qUW9SMnh2WW1Gc0xteGhkR1Z6ZEZScGJXVnpkR0Z0Y0Nrc0NpQWdJQ0F2THlBZ0lITjFZMk5sYzNNNklIVndaR0YwWlZOMVkyTmxjM011Ym1GMGFYWmxJRDhnYzNWalkyVnpjeUE2SUdOMWNuSmxiblJVWVhOckxuTjFZMk5sYzNNc0NpQWdJQ0F2THlBZ0lHUmxkR0ZwYkhNNklIVndaR0YwWlVSbGRHRnBiSE11Ym1GMGFYWmxJRDhnWkdWMFlXbHNjeUE2SUdOMWNuSmxiblJVWVhOckxtUmxkR0ZwYkhNc0NpQWdJQ0F2THlBZ0lHVjRaV04xZEc5eU9pQjFjR1JoZEdWRmVHVmpkWFJ2Y2k1dVlYUnBkbVVnUHlCbGVHVmpkWFJ2Y2lBNklHTjFjbkpsYm5SVVlYTnJMbVY0WldOMWRHOXlMQW9nSUNBZ0x5OGdmU2s3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNZ29nSUNBZ1pIVndDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlrYVdjZ05Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZeUExSUM4dklEQjRNREF6TXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlpHbG5JREVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMEZuWlc1MExtRnNaMjh1ZEhNNk1UTTFDaUFnSUNBdkx5QjBhR2x6TG5SaGMydENiM2dvYVdSNEtTNTJZV3gxWlNBOUlIVndaR0YwWldSVVlYTnJMbU52Y0hrb0tUc0tJQ0FnSUdScFp5QXhDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJSEpsZEhOMVlnb0tkWEJrWVhSbFZHRnphMTkwWlhKdVlYSjVYMlpoYkhObFFEZzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlFXZGxiblF1WVd4bmJ5NTBjem94TXpJS0lDQWdJQzh2SUdWNFpXTjFkRzl5T2lCMWNHUmhkR1ZGZUdWamRYUnZjaTV1WVhScGRtVWdQeUJsZUdWamRYUnZjaUE2SUdOMWNuSmxiblJVWVhOckxtVjRaV04xZEc5eUxBb2dJQ0FnWm5KaGJXVmZaR2xuSURNS0lDQWdJR1Y0ZEhKaFkzUWdNVGtnTXpJZ0x5OGdiMjRnWlhKeWIzSTZJRWx1WkdWNElHRmpZMlZ6Y3lCcGN5QnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQmlJSFZ3WkdGMFpWUmhjMnRmZEdWeWJtRnllVjl0WlhKblpVQTVDZ3AxY0dSaGRHVlVZWE5yWDNSbGNtNWhjbmxmWm1Gc2MyVkFOVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OUJaMlZ1ZEM1aGJHZHZMblJ6T2pFek1Rb2dJQ0FnTHk4Z1pHVjBZV2xzY3pvZ2RYQmtZWFJsUkdWMFlXbHNjeTV1WVhScGRtVWdQeUJrWlhSaGFXeHpJRG9nWTNWeWNtVnVkRlJoYzJzdVpHVjBZV2xzY3l3S0lDQWdJR1p5WVcxbFgyUnBaeUF6Q2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ01UY2dMeThnTVRjS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREVLSUNBZ0lHSWdkWEJrWVhSbFZHRnphMTkwWlhKdVlYSjVYMjFsY21kbFFEWUtDblZ3WkdGMFpWUmhjMnRmZEdWeWJtRnllVjltWVd4elpVQXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwRm5aVzUwTG1Gc1oyOHVkSE02TVRNd0NpQWdJQ0F2THlCemRXTmpaWE56T2lCMWNHUmhkR1ZUZFdOalpYTnpMbTVoZEdsMlpTQS9JSE4xWTJObGMzTWdPaUJqZFhKeVpXNTBWR0Z6YXk1emRXTmpaWE56TEFvZ0lDQWdabkpoYldWZlpHbG5JRE1LSUNBZ0lIQjFjMmhwYm5RZ05qUWdMeThnTmpRS0lDQWdJR2RsZEdKcGRBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxkR0pwZEFvZ0lDQWdabkpoYldWZlluVnllU0F3Q2lBZ0lDQmlJSFZ3WkdGMFpWUmhjMnRmZEdWeWJtRnllVjl0WlhKblpVQXpDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDBGblpXNTBMbUZzWjI4dWRITTZPbE5wYm1kc1pVRm5aVzUwUTI5dWRISmhZM1F1ZDJsMGFHUnlZWGNvZEc4NklHSjVkR1Z6TENCaGJXOTFiblE2SUhWcGJuUTJOQ2tnTFQ0Z2RtOXBaRG9LZDJsMGFHUnlZWGM2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZRV2RsYm5RdVlXeG5ieTUwY3pveE16Z0tJQ0FnSUM4dklIZHBkR2hrY21GM0tIUnZPaUJCWTJOdmRXNTBMQ0JoYlc5MWJuUTZJSFZwYm5RMk5DazZJSFp2YVdRZ2V3b2dJQ0FnY0hKdmRHOGdNaUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZRV2RsYm5RdVlXeG5ieTUwY3pveE16a0tJQ0FnSUM4dklHRnpjMlZ5ZENoVWVHNHVjMlZ1WkdWeUlEMDlQU0IwYUdsekxtOTNibVZ5UVdSa2NtVnpjeTUyWVd4MVpTd2dKMjl1YkhrZ2IzZHVaWEluS1RzS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OUJaMlZ1ZEM1aGJHZHZMblJ6T2pReUNpQWdJQ0F2THlCdmQyNWxja0ZrWkhKbGMzTWdQU0JIYkc5aVlXeFRkR0YwWlR4QlkyTnZkVzUwUGlncE93b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6QWdMeThnSW05M2JtVnlRV1JrY21WemN5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12UVdkbGJuUXVZV3huYnk1MGN6b3hNemtLSUNBZ0lDOHZJR0Z6YzJWeWRDaFVlRzR1YzJWdVpHVnlJRDA5UFNCMGFHbHpMbTkzYm1WeVFXUmtjbVZ6Y3k1MllXeDFaU3dnSjI5dWJIa2diM2R1WlhJbktUc0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYjI1c2VTQnZkMjVsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMEZuWlc1MExtRnNaMjh1ZEhNNk1UUXhMVEUwTndvZ0lDQWdMeThnYVhSNGJnb2dJQ0FnTHk4Z0lDQXVjR0Y1YldWdWRDaDdDaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBPaUJoYlc5MWJuUXNDaUFnSUNBdkx5QWdJQ0FnY21WalpXbDJaWEk2SUhSdkxBb2dJQ0FnTHk4Z0lDQWdJR1psWlRvZ01Dd0tJQ0FnSUM4dklDQWdmU2tLSUNBZ0lDOHZJQ0FnTG5OMVltMXBkQ2dwT3dvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCcGRIaHVYMlpwWld4a0lGSmxZMlZwZG1WeUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVcxdmRXNTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlFXZGxiblF1WVd4bmJ5NTBjem94TkRFdE1UUTJDaUFnSUNBdkx5QnBkSGh1Q2lBZ0lDQXZMeUFnSUM1d1lYbHRaVzUwS0hzS0lDQWdJQzh2SUNBZ0lDQmhiVzkxYm5RNklHRnRiM1Z1ZEN3S0lDQWdJQzh2SUNBZ0lDQnlaV05sYVhabGNqb2dkRzhzQ2lBZ0lDQXZMeUFnSUNBZ1ptVmxPaUF3TEFvZ0lDQWdMeThnSUNCOUtRb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OUJaMlZ1ZEM1aGJHZHZMblJ6T2pFME5Rb2dJQ0FnTHk4Z1ptVmxPaUF3TEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZRV2RsYm5RdVlXeG5ieTUwY3pveE5ERXRNVFEzQ2lBZ0lDQXZMeUJwZEhodUNpQWdJQ0F2THlBZ0lDNXdZWGx0Wlc1MEtIc0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUTZJR0Z0YjNWdWRDd0tJQ0FnSUM4dklDQWdJQ0J5WldObGFYWmxjam9nZEc4c0NpQWdJQ0F2THlBZ0lDQWdabVZsT2lBd0xBb2dJQ0FnTHk4Z0lDQjlLUW9nSUNBZ0x5OGdJQ0F1YzNWaWJXbDBLQ2s3Q2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwRm5aVzUwTG1Gc1oyOHVkSE02TVRVMUxURTJNUW9nSUNBZ0x5OGdZMjl1YzNRZ1kyRnNiRlI0YmlBOUlHbDBlRzRLSUNBZ0lDOHZJQ0FnSUNBZ0lDNWhjSEJzYVdOaGRHbHZia05oYkd3b2V3b2dJQ0FnTHk4Z0lHRndjRWxrT21Gd2NFbEVMQW9nSUNBZ0x5OGdJQ0FnSUdabFpUb2dNQ3dLSUNBZ0lDOHZJQ0FnSUNCaGNIQkJjbWR6T2lCYllYSmpOQzV0WlhSb2IyUlRaV3hsWTNSdmNpZ25aVzFwZEY5c2IyY29jM1J5YVc1bkxITjBjbWx1Wnl4emRISnBibWNwSnlrc0lDSjNhWFJvWkhKaGR5SXNJRWRzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUpaQzVwWkN3Z2JtVjNJR0Z5WXpRdVUzUnlLQ0p6ZFdOalpYTnpJaWtnWFN3S0lDQWdJQzh2SUNBZ0lDQWdJSDBwQ2lBZ0lDQXZMeUFnSUNBZ0lDQXVjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlCWjJWdWRDNWhiR2R2TG5Sek9qRTFPUW9nSUNBZ0x5OGdZWEJ3UVhKbmN6b2dXMkZ5WXpRdWJXVjBhRzlrVTJWc1pXTjBiM0lvSjJWdGFYUmZiRzluS0hOMGNtbHVaeXh6ZEhKcGJtY3NjM1J5YVc1bktTY3BMQ0FpZDJsMGFHUnlZWGNpTENCSGJHOWlZV3d1WTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1U1dRdWFXUXNJRzVsZHlCaGNtTTBMbE4wY2lnaWMzVmpZMlZ6Y3lJcElGMHNDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6SWdMeThnYldWMGFHOWtJQ0psYldsMFgyeHZaeWh6ZEhKcGJtY3NjM1J5YVc1bkxITjBjbWx1WnlraUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2NIVnphR0o1ZEdWeklDSjNhWFJvWkhKaGR5SUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnWW5sMFpXTWdOaUF2THlBd2VEQXdNRGMzTXpjMU5qTTJNelkxTnpNM013b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OUJaMlZ1ZEM1aGJHZHZMblJ6T2pFME9Bb2dJQ0FnTHk4Z1kyOXVjM1FnWVhCd1NVUWdQU0FnUVhCd2JHbGpZWFJwYjI0b056UTVNemM0TlRJeUtUc0tJQ0FnSUdsdWRHTmZNaUF2THlBM05Ea3pOemcxTWpJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDBGblpXNTBMbUZzWjI4dWRITTZNVFUxTFRFMk1Bb2dJQ0FnTHk4Z1kyOXVjM1FnWTJGc2JGUjRiaUE5SUdsMGVHNEtJQ0FnSUM4dklDQWdJQ0FnSUM1aGNIQnNhV05oZEdsdmJrTmhiR3dvZXdvZ0lDQWdMeThnSUdGd2NFbGtPbUZ3Y0VsRUxBb2dJQ0FnTHk4Z0lDQWdJR1psWlRvZ01Dd0tJQ0FnSUM4dklDQWdJQ0JoY0hCQmNtZHpPaUJiWVhKak5DNXRaWFJvYjJSVFpXeGxZM1J2Y2lnblpXMXBkRjlzYjJjb2MzUnlhVzVuTEhOMGNtbHVaeXh6ZEhKcGJtY3BKeWtzSUNKM2FYUm9aSEpoZHlJc0lFZHNiMkpoYkM1amRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1SlpDNXBaQ3dnYm1WM0lHRnlZelF1VTNSeUtDSnpkV05qWlhOeklpa2dYU3dLSUNBZ0lDOHZJQ0FnSUNBZ0lIMHBDaUFnSUNCcGJuUmpYek1nTHk4Z05nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMEZuWlc1MExtRnNaMjh1ZEhNNk1UVTRDaUFnSUNBdkx5Qm1aV1U2SURBc0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlCWjJWdWRDNWhiR2R2TG5Sek9qRTFOUzB4TmpFS0lDQWdJQzh2SUdOdmJuTjBJR05oYkd4VWVHNGdQU0JwZEhodUNpQWdJQ0F2THlBZ0lDQWdJQ0F1WVhCd2JHbGpZWFJwYjI1RFlXeHNLSHNLSUNBZ0lDOHZJQ0JoY0hCSlpEcGhjSEJKUkN3S0lDQWdJQzh2SUNBZ0lDQm1aV1U2SURBc0NpQWdJQ0F2THlBZ0lDQWdZWEJ3UVhKbmN6b2dXMkZ5WXpRdWJXVjBhRzlrVTJWc1pXTjBiM0lvSjJWdGFYUmZiRzluS0hOMGNtbHVaeXh6ZEhKcGJtY3NjM1J5YVc1bktTY3BMQ0FpZDJsMGFHUnlZWGNpTENCSGJHOWlZV3d1WTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1U1dRdWFXUXNJRzVsZHlCaGNtTTBMbE4wY2lnaWMzVmpZMlZ6Y3lJcElGMHNDaUFnSUNBdkx5QWdJQ0FnSUNCOUtRb2dJQ0FnTHk4Z0lDQWdJQ0FnTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwRm5aVzUwTG1Gc1oyOHVkSE02T2xOcGJtZHNaVUZuWlc1MFEyOXVkSEpoWTNRdWRISmhibk5tWlhKUGQyNWxjbk5vYVhBb2JtVjNUM2R1WlhJNklHSjVkR1Z6S1NBdFBpQjJiMmxrT2dwMGNtRnVjMlpsY2s5M2JtVnljMmhwY0RvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlCWjJWdWRDNWhiR2R2TG5Sek9qRTJPQW9nSUNBZ0x5OGdkSEpoYm5ObVpYSlBkMjVsY25Ob2FYQW9ibVYzVDNkdVpYSTZJRUZqWTI5MWJuUXBPaUIyYjJsa0lIc0tJQ0FnSUhCeWIzUnZJREVnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMEZuWlc1MExtRnNaMjh1ZEhNNk1UWTVDaUFnSUNBdkx5QmhjM05sY25Rb1ZIaHVMbk5sYm1SbGNpQTlQVDBnZEdocGN5NXZkMjVsY2tGa1pISmxjM011ZG1Gc2RXVXNJQ2R2Ym14NUlHOTNibVZ5SnlrN0NpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZRV2RsYm5RdVlXeG5ieTUwY3pvME1nb2dJQ0FnTHk4Z2IzZHVaWEpCWkdSeVpYTnpJRDBnUjJ4dlltRnNVM1JoZEdVOFFXTmpiM1Z1ZEQ0b0tUc0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKdmQyNWxja0ZrWkhKbGMzTWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDBGblpXNTBMbUZzWjI4dWRITTZNVFk1Q2lBZ0lDQXZMeUJoYzNObGNuUW9WSGh1TG5ObGJtUmxjaUE5UFQwZ2RHaHBjeTV2ZDI1bGNrRmtaSEpsYzNNdWRtRnNkV1VzSUNkdmJteDVJRzkzYm1WeUp5azdDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5dWJIa2diM2R1WlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlCWjJWdWRDNWhiR2R2TG5Sek9qUXlDaUFnSUNBdkx5QnZkMjVsY2tGa1pISmxjM01nUFNCSGJHOWlZV3hUZEdGMFpUeEJZMk52ZFc1MFBpZ3BPd29nSUNBZ1lubDBaV05mTUNBdkx5QWliM2R1WlhKQlpHUnlaWE56SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMEZuWlc1MExtRnNaMjh1ZEhNNk1UY3dDaUFnSUNBdkx5QjBhR2x6TG05M2JtVnlRV1JrY21WemN5NTJZV3gxWlNBOUlHNWxkMDkzYm1WeU93b2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDBGblpXNTBMbUZzWjI4dWRITTZPbE5wYm1kc1pVRm5aVzUwUTI5dWRISmhZM1F1ZEdWemRGOXNiMmNvS1NBdFBpQjJiMmxrT2dwMFpYTjBYMnh2WnpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlCWjJWdWRDNWhiR2R2TG5Sek9qRTNOaTB4T0RJS0lDQWdJQzh2SUdOdmJuTjBJR05oYkd4VWVHNGdQU0JwZEhodUNpQWdJQ0F2THlBZ0lDQWdJQ0F1WVhCd2JHbGpZWFJwYjI1RFlXeHNLSHNLSUNBZ0lDOHZJQ0JoY0hCSlpEcGhjSEJKUkN3S0lDQWdJQzh2SUNBZ0lDQm1aV1U2SURBc0NpQWdJQ0F2THlBZ0lDQWdZWEJ3UVhKbmN6b2dXMkZ5WXpRdWJXVjBhRzlrVTJWc1pXTjBiM0lvSjJWdGFYUmZiRzluS0hOMGNtbHVaeXh6ZEhKcGJtY3NjM1J5YVc1bktTY3BMQ0FpY0dGNUlpd2dJQ0FnSUNBZ2JtVjNJR0Z5WXpRdVZXbHVkRTQyTkNoSGJHOWlZV3d1WTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1U1dRdWFXUXBMbUo1ZEdWekxDQWljM1ZqWTJWemN5SWdYU3dLSUNBZ0lDOHZJQ0FnSUNBZ0lIMHBDaUFnSUNBdkx5QWdJQ0FnSUNBdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OUJaMlZ1ZEM1aGJHZHZMblJ6T2pFNE1Bb2dJQ0FnTHk4Z1lYQndRWEpuY3pvZ1cyRnlZelF1YldWMGFHOWtVMlZzWldOMGIzSW9KMlZ0YVhSZmJHOW5LSE4wY21sdVp5eHpkSEpwYm1jc2MzUnlhVzVuS1NjcExDQWljR0Y1SWl3Z0lDQWdJQ0FnYm1WM0lHRnlZelF1VldsdWRFNDJOQ2hIYkc5aVlXd3VZM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVTV1F1YVdRcExtSjVkR1Z6TENBaWMzVmpZMlZ6Y3lJZ1hTd0tJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1pQXZMeUJ0WlhSb2IyUWdJbVZ0YVhSZmJHOW5LSE4wY21sdVp5eHpkSEpwYm1jc2MzUnlhVzVuS1NJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCd2RYTm9ZbmwwWlhNZ0luQmhlU0lLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2NIVnphR0o1ZEdWeklDSnpkV05qWlhOeklnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OUJaMlZ1ZEM1aGJHZHZMblJ6T2pFM05Bb2dJQ0FnTHk4Z1kyOXVjM1FnWVhCd1NVUWdQU0FnUVhCd2JHbGpZWFJwYjI0b056UTVNemM0TlRJeUtUc0tJQ0FnSUdsdWRHTmZNaUF2THlBM05Ea3pOemcxTWpJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDBGblpXNTBMbUZzWjI4dWRITTZNVGMyTFRFNE1Rb2dJQ0FnTHk4Z1kyOXVjM1FnWTJGc2JGUjRiaUE5SUdsMGVHNEtJQ0FnSUM4dklDQWdJQ0FnSUM1aGNIQnNhV05oZEdsdmJrTmhiR3dvZXdvZ0lDQWdMeThnSUdGd2NFbGtPbUZ3Y0VsRUxBb2dJQ0FnTHk4Z0lDQWdJR1psWlRvZ01Dd0tJQ0FnSUM4dklDQWdJQ0JoY0hCQmNtZHpPaUJiWVhKak5DNXRaWFJvYjJSVFpXeGxZM1J2Y2lnblpXMXBkRjlzYjJjb2MzUnlhVzVuTEhOMGNtbHVaeXh6ZEhKcGJtY3BKeWtzSUNKd1lYa2lMQ0FnSUNBZ0lDQnVaWGNnWVhKak5DNVZhVzUwVGpZMEtFZHNiMkpoYkM1amRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1SlpDNXBaQ2t1WW5sMFpYTXNJQ0p6ZFdOalpYTnpJaUJkTEFvZ0lDQWdMeThnSUNBZ0lDQWdmU2tLSUNBZ0lHbHVkR05mTXlBdkx5QTJDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12UVdkbGJuUXVZV3huYnk1MGN6b3hOemtLSUNBZ0lDOHZJR1psWlRvZ01Dd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDBGblpXNTBMbUZzWjI4dWRITTZNVGMyTFRFNE1nb2dJQ0FnTHk4Z1kyOXVjM1FnWTJGc2JGUjRiaUE5SUdsMGVHNEtJQ0FnSUM4dklDQWdJQ0FnSUM1aGNIQnNhV05oZEdsdmJrTmhiR3dvZXdvZ0lDQWdMeThnSUdGd2NFbGtPbUZ3Y0VsRUxBb2dJQ0FnTHk4Z0lDQWdJR1psWlRvZ01Dd0tJQ0FnSUM4dklDQWdJQ0JoY0hCQmNtZHpPaUJiWVhKak5DNXRaWFJvYjJSVFpXeGxZM1J2Y2lnblpXMXBkRjlzYjJjb2MzUnlhVzVuTEhOMGNtbHVaeXh6ZEhKcGJtY3BKeWtzSUNKd1lYa2lMQ0FnSUNBZ0lDQnVaWGNnWVhKak5DNVZhVzUwVGpZMEtFZHNiMkpoYkM1amRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1SlpDNXBaQ2t1WW5sMFpYTXNJQ0p6ZFdOalpYTnpJaUJkTEFvZ0lDQWdMeThnSUNBZ0lDQWdmU2tLSUNBZ0lDOHZJQ0FnSUNBZ0lDNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJSEpsZEhOMVlnbz0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQUVBQUhhdDZybEFnWW1Cd3h2ZDI1bGNrRmtaSEpsYzNNSmRHRnphME52ZFc1MEJOaWR1a2tFYm1GdFpReG1hWGhsWkZCeWFXTnBibWNDQURNSkFBZHpkV05qWlhOek1SdEJBRGlDQndUQVMzWDBCTlhUSTBjRWEyZ0RHQVRGUmo3cUJPNHprUzhFODdxaWNBVGtjOGNLTmhvQWpnY0FlZ0J1QUZnQU5nQWdBQTRBQWlKRE1Sa1VSREVZUklnQ0xDTkRNUmtVUkRFWVJEWWFBUmZBSElnQ0NpTkRNUmtVUkRFWVJEWWFBUmZBSERZYUFoZUlBYlVqUXpFWkZFUXhHRVEyR2dFWE5ob0NOaG9ETmhvRU5ob0ZOaG9HTmhvSGlBRW1JME14R1JSRU1SaEVNUllqQ1VrNEVDTVNSSWdBa3lORE1Sa1VSREVZUklnQVV5TkRNUmtVUkRFWUZFUTJHZ0ZYQWdBMkdnSlhBZ0EyR2dNWGlBQUNJME9LQXdBb01RQm5LNHY5WjRBSFpHVjBZV2xzYzR2K1o0di9nY0NFUFFzbkJFeG5nQWxqY21WaGRHVmtRWFF5QjJjcEkyZUpzU0lyWlVTeUpvQUNVbEN5SllFQ3NpT0JnTkRidy9RQ3NpS0JBN0lRSXJJQnM0QU1ZV2RsYm5SQmMzTmxkRWxFdER4bmlZb0JBSXYvT0FjeUNoSkVpLzg0Q0NJbkJHVkVFa1FpS1dWRVNSWXlCeGFML3pnQVN3S0FBUUJRVHdKUUp3VlFURkNBSGdBY1VHRjViV1Z1ZENCRWIyNWxJU0VzSUZSaGMyc2dRM0psWVhSbFpGQkxBYnhJdnlNSUtVeG5zVElJRmlxeUdvQUZBQU53WVhteUdySWFKd2F5R2lTeUdDV3lFQ0t5QWJPSmlnY0FJa21MK1JaSnZrUXlCeGFMK2lKVFFRQkhpLzJNQUl2N0lsTkJBQzJML293Qmkvd2lVMEVBR292L2l3Skppd0JRaXdSUUp3VlFUd0pRaXdGUVN3RzhTTCtKaXdOWEV5QkMvK0NMQTBtQkVWbExBUlZTakFGQy84aUxBNEZBVTRBQkFDSlBBbFNNQUVML3JJb0NBREVBSWlobFJCSkVzWXYrc2dlTC83SUlJN0lRSXJJQnM3RXlDQllxc2hxQUNIZHBkR2hrY21GM3NocXlHaWNHc2hva3NoZ2xzaEFpc2dHemlZb0JBREVBSWlobFJCSkVLSXYvWjRteE1nZ1dLcklhZ0FOd1lYbXlHcklhZ0FkemRXTmpaWE56c2hva3NoZ2xzaEFpc2dHemlRPT0iLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjQsIm1pbm9yIjo3LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
