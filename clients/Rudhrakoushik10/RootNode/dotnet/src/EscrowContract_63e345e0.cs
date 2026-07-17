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

namespace Arc56.Generated.Rudhrakoushik10.RootNode.EscrowContract_63e345e0
{


    public class EscrowContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public EscrowContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class GetEscrowInfoReturn : AVMObjectType
            {
                public Algorand.Address Field0 { get; set; }

                public Algorand.Address Field1 { get; set; }

                public ulong Field2 { get; set; }

                public ulong Field3 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
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

                public static GetEscrowInfoReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetEscrowInfoReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is Algorand.Address vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is Algorand.Address vField1Value) { ret.Field1 = vField1Value; }
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
                    return Equals(obj as GetEscrowInfoReturn);
                }
                public bool Equals(GetEscrowInfoReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetEscrowInfoReturn left, GetEscrowInfoReturn right)
                {
                    return EqualityComparer<GetEscrowInfoReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetEscrowInfoReturn left, GetEscrowInfoReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="agent"> </param>
        /// <param name="provider"> </param>
        /// <param name="serviceId"> </param>
        /// <param name="amount"> </param>
        /// <param name="timeoutSecs"> </param>
        public async Task Initialize(Algorand.Address agent, Algorand.Address provider, string serviceId, ulong amount, ulong timeoutSecs, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 231, 247, 33, 116 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);
            var providerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); providerAbi.From(provider);
            var serviceIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); serviceIdAbi.From(serviceId);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var timeoutSecsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); timeoutSecsAbi.From(timeoutSecs);

            var result = await base.CallApp(new List<object> { abiHandle, agentAbi, providerAbi, serviceIdAbi, amountAbi, timeoutSecsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Initialize_Transactions(Algorand.Address agent, Algorand.Address provider, string serviceId, ulong amount, ulong timeoutSecs, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 231, 247, 33, 116 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);
            var providerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); providerAbi.From(provider);
            var serviceIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); serviceIdAbi.From(serviceId);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var timeoutSecsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); timeoutSecsAbi.From(timeoutSecs);

            return await base.MakeTransactionList(new List<object> { abiHandle, agentAbi, providerAbi, serviceIdAbi, amountAbi, timeoutSecsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="payment"> </param>
        public async Task LockFunds(PaymentTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 76, 157, 46, 167 };

            var result = await base.CallApp(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> LockFunds_Transactions(PaymentTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 76, 157, 46, 167 };

            return await base.MakeTransactionList(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="serviceResult"> </param>
        public async Task ConfirmService(byte[] serviceResult, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 127, 239, 63, 183 };
            var serviceResultAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); serviceResultAbi.From(serviceResult);

            var result = await base.CallApp(new List<object> { abiHandle, serviceResultAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ConfirmService_Transactions(byte[] serviceResult, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 127, 239, 63, 183 };
            var serviceResultAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); serviceResultAbi.From(serviceResult);

            return await base.MakeTransactionList(new List<object> { abiHandle, serviceResultAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="newStatus"> </param>
        public async Task UpdateStatus(ulong newStatus, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 121, 253, 199, 115 };
            var newStatusAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); newStatusAbi.From(newStatus);

            var result = await base.CallApp(new List<object> { abiHandle, newStatusAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateStatus_Transactions(ulong newStatus, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 121, 253, 199, 115 };
            var newStatusAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); newStatusAbi.From(newStatus);

            return await base.MakeTransactionList(new List<object> { abiHandle, newStatusAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task ReleaseFunds(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 91, 114, 1, 213 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ReleaseFunds_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 91, 114, 1, 213 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="reason"> </param>
        public async Task RejectAndRefund(string reason, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 84, 122, 43, 127 };
            var reasonAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); reasonAbi.From(reason);

            var result = await base.CallApp(new List<object> { abiHandle, reasonAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RejectAndRefund_Transactions(string reason, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 84, 122, 43, 127 };
            var reasonAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); reasonAbi.From(reason);

            return await base.MakeTransactionList(new List<object> { abiHandle, reasonAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task ExpireAndRefund(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 141, 12, 242, 92 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ExpireAndRefund_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 141, 12, 242, 92 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.GetEscrowInfoReturn> GetEscrowInfo(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 178, 239, 13, 77 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetEscrowInfoReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetEscrowInfo_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 178, 239, 13, 77 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> GetStatus(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 153, 42, 195, 190 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetStatus_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 153, 42, 195, 190 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRXNjcm93Q29udHJhY3QiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiR2V0RXNjcm93SW5mb1JldHVybiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJmaWVsZDIiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQzIiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJpbml0aWFsaXplIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZ2VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByb3ZpZGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzZXJ2aWNlSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidGltZW91dFNlY3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibG9ja0Z1bmRzIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheW1lbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY29uZmlybVNlcnZpY2UiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2VydmljZVJlc3VsdCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1cGRhdGVTdGF0dXMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3U3RhdHVzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlbGVhc2VGdW5kcyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWplY3RBbmRSZWZ1bmQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVhc29uIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImV4cGlyZUFuZFJlZnVuZCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRFc2Nyb3dJbmZvIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6IihhZGRyZXNzLGFkZHJlc3MsdWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJHZXRFc2Nyb3dJbmZvUmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRTdGF0dXMiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjo0LCJieXRlcyI6NH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbNDg3XSwiZXJyb3JNZXNzYWdlIjoiQWxyZWFkeSByZXNvbHZlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI5MywzNDAsNDM3XSwiZXJyb3JNZXNzYWdlIjoiRXNjcm93IG5vdCBpbiBwZW5kaW5nIHN0YXRlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDgxXSwiZXJyb3JNZXNzYWdlIjoiTm90IGV4cGlyZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4OF0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBtdXN0IGJlIE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNzBdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBOb09wICYmIGNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI4N10sImVycm9yTWVzc2FnZSI6Ik9ubHkgYWdlbnQgY2FuIGxvY2sgZnVuZHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNjVdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGFnZW50IGNhbiByZWxlYXNlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzM0XSwiZXJyb3JNZXNzYWdlIjoiT25seSBwcm92aWRlciBjYW4gY29uZmlybSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQzMV0sImVycm9yTWVzc2FnZSI6Ik9ubHkgcHJvdmlkZXIgb3IgYWdlbnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMDhdLCJlcnJvck1lc3NhZ2UiOiJQYXltZW50IGFtb3VudCBtdXN0IG1hdGNoIGxvY2tlZCBhbW91bnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMDBdLCJlcnJvck1lc3NhZ2UiOiJQYXltZW50IG11c3QgZ28gdG8gZXNjcm93IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzcyXSwiZXJyb3JNZXNzYWdlIjoiU2VydmljZSBub3QgY29uZmlybWVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjg1LDI5MSwzMDYsMzMyLDMzOCwzNjMsMzY5LDM3NywzODEsNDE1LDQyNSw0MzUsNDQyLDQ0Niw0NzMsNDc4LDQ4NSw0OTIsNDk2LDUxNyw1MjEsNTI1LDUyOSw1NTJdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBHbG9iYWxTdGF0ZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxOTYsMzE2LDQwM10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIwMywzMjMsNDA5XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE4MSwxOTBdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjE0LDIyMywzNTZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNzldLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIHBheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM1N10sImVycm9yTWVzc2FnZSI6InVwZGF0ZVN0YXR1cyBpcyBkZXByZWNhdGVkIGFuZCBzaG91bGQgbm90IGJlIHVzZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01DQXhJRElnT0FvZ0lDQWdZbmwwWldOaWJHOWpheUFpYzNSaGRIVnpJaUFpWVdkbGJuUWlJQ0poYlc5MWJuUk1iMk5yWldRaUlDSndjbTkyYVdSbGNpSWdJbXh2WTJ0VWFXMWxJaUFpZEdsdFpXOTFkQ0lnSW5ObGNuWnBZMlZTWlhOMWJIUWlJREI0TVRVeFpqZGpOelVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNjdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1Bb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRVZ6WTNKdmQwTnZiblJ5WVdOMElHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUdKNklHMWhhVzVmWDE5aGJHZHZkSE5mWHk1a1pXWmhkV3gwUTNKbFlYUmxRREUyQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUcxMWMzUWdZbVVnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdjSFZ6YUdKNWRHVnpjeUF3ZUdVM1pqY3lNVGMwSURCNE5HTTVaREpsWVRjZ01IZzNabVZtTTJaaU55QXdlRGM1Wm1Sak56Y3pJREI0TldJM01qQXhaRFVnTUhnMU5EZGhNbUkzWmlBd2VEaGtNR05tTWpWaklEQjRZakpsWmpCa05HUWdNSGc1T1RKaFl6TmlaU0F2THlCdFpYUm9iMlFnSW1sdWFYUnBZV3hwZW1Vb1lXUmtjbVZ6Y3l4aFpHUnlaWE56TEhOMGNtbHVaeXgxYVc1ME5qUXNkV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW14dlkydEdkVzVrY3lod1lYa3BkbTlwWkNJc0lHMWxkR2h2WkNBaVkyOXVabWx5YlZObGNuWnBZMlVvWW5sMFpWdGRLWFp2YVdRaUxDQnRaWFJvYjJRZ0luVndaR0YwWlZOMFlYUjFjeWgxYVc1ME5qUXBkbTlwWkNJc0lHMWxkR2h2WkNBaWNtVnNaV0Z6WlVaMWJtUnpLQ2wyYjJsa0lpd2diV1YwYUc5a0lDSnlaV3BsWTNSQmJtUlNaV1oxYm1Rb2MzUnlhVzVuS1hadmFXUWlMQ0J0WlhSb2IyUWdJbVY0Y0dseVpVRnVaRkpsWm5WdVpDZ3BkbTlwWkNJc0lHMWxkR2h2WkNBaVoyVjBSWE5qY205M1NXNW1ieWdwS0dGa1pISmxjM01zWVdSa2NtVnpjeXgxYVc1ME5qUXNkV2x1ZERZMEtTSXNJRzFsZEdodlpDQWlaMlYwVTNSaGRIVnpLQ2wxYVc1ME5qUWlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0JwYm1sMGFXRnNhWHBsSUd4dlkydEdkVzVrY3lCamIyNW1hWEp0VTJWeWRtbGpaU0IxY0dSaGRHVlRkR0YwZFhNZ2NtVnNaV0Z6WlVaMWJtUnpJSEpsYW1WamRFRnVaRkpsWm5WdVpDQmxlSEJwY21WQmJtUlNaV1oxYm1RZ1oyVjBSWE5qY205M1NXNW1ieUJuWlhSVGRHRjBkWE1LSUNBZ0lHVnljZ29LYldGcGJsOWZYMkZzWjI5MGMxOWZMbVJsWm1GMWJIUkRjbVZoZEdWQU1UWTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRBS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QkZjMk55YjNkRGIyNTBjbUZqZENCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBaENpQWdJQ0FtSmdvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCdGRYTjBJR0psSUU1dlQzQWdKaVlnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUdOeVpXRjBhVzVuQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwRmMyTnliM2REYjI1MGNtRmpkQzVwYm1sMGFXRnNhWHBsVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2FXNXBkR2xoYkdsNlpUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2N2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TUFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lHRnNiRzkzUVdOMGFXOXVjem9nSjA1dlQzQW5JSDBwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBek1pQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQXpNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTkFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeENpQWdJQ0F2THlCaFoyVnVkQ0E5SUVkc2IySmhiRk4wWVhSbFBFRmpZMjkxYm5RK0tDa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltRm5aVzUwSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmR5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSXlDaUFnSUNBdkx5QjBhR2x6TG1GblpXNTBMblpoYkhWbElEMGdZV2RsYm5RS0lDQWdJSFZ1WTI5MlpYSWdOUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNjdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1nb2dJQ0FnTHk4Z2NISnZkbWxrWlhJZ1BTQkhiRzlpWVd4VGRHRjBaVHhCWTJOdmRXNTBQaWdwQ2lBZ0lDQmllWFJsWTE4eklDOHZJQ0p3Y205MmFXUmxjaUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNjdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU13b2dJQ0FnTHk4Z2RHaHBjeTV3Y205MmFXUmxjaTUyWVd4MVpTQTlJSEJ5YjNacFpHVnlDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFVLSUNBZ0lDOHZJSE5sY25acFkyVkpaQ0E5SUVkc2IySmhiRk4wWVhSbFBITjBjbWx1Wno0b0tRb2dJQ0FnY0hWemFHSjVkR1Z6SUNKelpYSjJhV05sU1dRaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNalFLSUNBZ0lDOHZJSFJvYVhNdWMyVnlkbWxqWlVsa0xuWmhiSFZsSUQwZ2MyVnlkbWxqWlVsa0NpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UTUtJQ0FnSUM4dklHRnRiM1Z1ZEV4dlkydGxaQ0E5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b0tRb2dJQ0FnWW5sMFpXTmZNaUF2THlBaVlXMXZkVzUwVEc5amEyVmtJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJMUNpQWdJQ0F2THlCMGFHbHpMbUZ0YjNWdWRFeHZZMnRsWkM1MllXeDFaU0E5SUdGdGIzVnVkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUwQ2lBZ0lDQXZMeUJ6ZEdGMGRYTWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0NrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5OMFlYUjFjeUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNjdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU5nb2dJQ0FnTHk4Z2RHaHBjeTV6ZEdGMGRYTXVkbUZzZFdVZ1BTQlRWRUZVVlZOZlVFVk9SRWxPUndvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UY0tJQ0FnSUM4dklHeHZZMnRVYVcxbElEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWdwQ2lBZ0lDQmllWFJsWXlBMElDOHZJQ0pzYjJOclZHbHRaU0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNjdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU53b2dJQ0FnTHk4Z2RHaHBjeTVzYjJOclZHbHRaUzUyWVd4MVpTQTlJRWRzYjJKaGJDNXNZWFJsYzNSVWFXMWxjM1JoYlhBS0lDQWdJR2RzYjJKaGJDQk1ZWFJsYzNSVWFXMWxjM1JoYlhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGdLSUNBZ0lDOHZJSFJwYldWdmRYUWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0NrS0lDQWdJR0o1ZEdWaklEVWdMeThnSW5ScGJXVnZkWFFpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qZ0tJQ0FnSUM4dklIUm9hWE11ZEdsdFpXOTFkQzUyWVd4MVpTQTlJSFJwYldWdmRYUlRaV056Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmR5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTJDaUFnSUNBdkx5QnpaWEoyYVdObFVtVnpkV3gwSUQwZ1IyeHZZbUZzVTNSaGRHVThZbmwwWlhNK0tDa0tJQ0FnSUdKNWRHVmpJRFlnTHk4Z0luTmxjblpwWTJWU1pYTjFiSFFpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qa0tJQ0FnSUM4dklIUm9hWE11YzJWeWRtbGpaVkpsYzNWc2RDNTJZV3gxWlNBOUlFZHNiMkpoYkM1NlpYSnZRV1JrY21WemN5NWllWFJsY3dvZ0lDQWdaMnh2WW1Gc0lGcGxjbTlCWkdSeVpYTnpDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJd0NpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2dZV3hzYjNkQlkzUnBiMjV6T2lBblRtOVBjQ2NnZlNrS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rVnpZM0p2ZDBOdmJuUnlZV04wTG14dlkydEdkVzVrYzF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNteHZZMnRHZFc1a2N6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2N2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TWdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lHRnNiRzkzUVdOMGFXOXVjem9nSjA1dlQzQW5JSDBwQ2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDMEtJQ0FnSUdSMWNBb2dJQ0FnWjNSNGJuTWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNU0F2THlCd1lYa0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnZEhKaGJuTmhZM1JwYjI0Z2RIbHdaU0JwY3lCd1lYa0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2N2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TkFvZ0lDQWdMeThnWVhOelpYSjBLRlI0Ymk1elpXNWtaWElnUFQwOUlIUm9hWE11WVdkbGJuUXVkbUZzZFdVc0lDZFBibXg1SUdGblpXNTBJR05oYmlCc2IyTnJJR1oxYm1Sekp5a0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1URUtJQ0FnSUM4dklHRm5aVzUwSUQwZ1IyeHZZbUZzVTNSaGRHVThRV05qYjNWdWRENG9LUW9nSUNBZ1lubDBaV05mTVNBdkx5QWlZV2RsYm5RaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNelFLSUNBZ0lDOHZJR0Z6YzJWeWRDaFVlRzR1YzJWdVpHVnlJRDA5UFNCMGFHbHpMbUZuWlc1MExuWmhiSFZsTENBblQyNXNlU0JoWjJWdWRDQmpZVzRnYkc5amF5Qm1kVzVrY3ljcENpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBibXg1SUdGblpXNTBJR05oYmlCc2IyTnJJR1oxYm1SekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNelVLSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG5OMFlYUjFjeTUyWVd4MVpTQTlQVDBnVTFSQlZGVlRYMUJGVGtSSlRrY3NJQ2RGYzJOeWIzY2dibTkwSUdsdUlIQmxibVJwYm1jZ2MzUmhkR1VuS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNjdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5Bb2dJQ0FnTHk4Z2MzUmhkSFZ6SUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpZ3BDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnpkR0YwZFhNaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNelVLSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG5OMFlYUjFjeTUyWVd4MVpTQTlQVDBnVTFSQlZGVlRYMUJGVGtSSlRrY3NJQ2RGYzJOeWIzY2dibTkwSUdsdUlIQmxibVJwYm1jZ2MzUmhkR1VuS1FvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCRmMyTnliM2NnYm05MElHbHVJSEJsYm1ScGJtY2djM1JoZEdVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pOd29nSUNBZ0x5OGdjR0Y1YldWdWRDNXlaV05sYVhabGNpQTlQVDBnUjJ4dlltRnNMbU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTXNDaUFnSUNCa2RYQUtJQ0FnSUdkMGVHNXpJRkpsWTJWcGRtVnlDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29nSUNBZ1BUMEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2N2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96Tmkwek9Rb2dJQ0FnTHk4Z1lYTnpaWEowS0FvZ0lDQWdMeThnSUNCd1lYbHRaVzUwTG5KbFkyVnBkbVZ5SUQwOVBTQkhiRzlpWVd3dVkzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ0oxQmhlVzFsYm5RZ2JYVnpkQ0JuYnlCMGJ5QmxjMk55YjNjbkNpQWdJQ0F2THlBcENpQWdJQ0JoYzNObGNuUWdMeThnVUdGNWJXVnVkQ0J0ZFhOMElHZHZJSFJ2SUdWelkzSnZkd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pReENpQWdJQ0F2THlCd1lYbHRaVzUwTG1GdGIzVnVkQ0E5UFQwZ2RHaHBjeTVoYlc5MWJuUk1iMk5yWldRdWRtRnNkV1VzQ2lBZ0lDQm5kSGh1Y3lCQmJXOTFiblFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRNS0lDQWdJQzh2SUdGdGIzVnVkRXh2WTJ0bFpDQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvS1FvZ0lDQWdZbmwwWldOZk1pQXZMeUFpWVcxdmRXNTBURzlqYTJWa0lnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalF4Q2lBZ0lDQXZMeUJ3WVhsdFpXNTBMbUZ0YjNWdWRDQTlQVDBnZEdocGN5NWhiVzkxYm5STWIyTnJaV1F1ZG1Gc2RXVXNDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnUFQwS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBNQzAwTXdvZ0lDQWdMeThnWVhOelpYSjBLQW9nSUNBZ0x5OGdJQ0J3WVhsdFpXNTBMbUZ0YjNWdWRDQTlQVDBnZEdocGN5NWhiVzkxYm5STWIyTnJaV1F1ZG1Gc2RXVXNDaUFnSUNBdkx5QWdJQ2RRWVhsdFpXNTBJR0Z0YjNWdWRDQnRkWE4wSUcxaGRHTm9JR3h2WTJ0bFpDQmhiVzkxYm5RbkNpQWdJQ0F2THlBcENpQWdJQ0JoYzNObGNuUWdMeThnVUdGNWJXVnVkQ0JoYlc5MWJuUWdiWFZ6ZENCdFlYUmphQ0JzYjJOclpXUWdZVzF2ZFc1MENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNeklLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCaGJHeHZkMEZqZEdsdmJuTTZJQ2RPYjA5d0p5QjlLUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2N2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82UlhOamNtOTNRMjl1ZEhKaFkzUXVZMjl1Wm1seWJWTmxjblpwWTJWYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGpiMjVtYVhKdFUyVnlkbWxqWlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBOZ29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUdGc2JHOTNRV04wYVc5dWN6b2dKMDV2VDNBbklIMHBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmR5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUTRDaUFnSUNBdkx5QmhjM05sY25Rb1ZIaHVMbk5sYm1SbGNpQTlQVDBnZEdocGN5NXdjbTkyYVdSbGNpNTJZV3gxWlN3Z0owOXViSGtnY0hKdmRtbGtaWElnWTJGdUlHTnZibVpwY20wbktRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNjdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1nb2dJQ0FnTHk4Z2NISnZkbWxrWlhJZ1BTQkhiRzlpWVd4VGRHRjBaVHhCWTJOdmRXNTBQaWdwQ2lBZ0lDQmllWFJsWTE4eklDOHZJQ0p3Y205MmFXUmxjaUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNjdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME9Bb2dJQ0FnTHk4Z1lYTnpaWEowS0ZSNGJpNXpaVzVrWlhJZ1BUMDlJSFJvYVhNdWNISnZkbWxrWlhJdWRtRnNkV1VzSUNkUGJteDVJSEJ5YjNacFpHVnlJR05oYmlCamIyNW1hWEp0SnlrS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFOXViSGtnY0hKdmRtbGtaWElnWTJGdUlHTnZibVpwY20wS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBPUW9nSUNBZ0x5OGdZWE56WlhKMEtIUm9hWE11YzNSaGRIVnpMblpoYkhWbElEMDlQU0JUVkVGVVZWTmZVRVZPUkVsT1J5d2dKMFZ6WTNKdmR5QnViM1FnYVc0Z2NHVnVaR2x1WnlCemRHRjBaU2NwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMENpQWdJQ0F2THlCemRHRjBkWE1nUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tDa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0luTjBZWFIxY3lJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBPUW9nSUNBZ0x5OGdZWE56WlhKMEtIUm9hWE11YzNSaGRIVnpMblpoYkhWbElEMDlQU0JUVkVGVVZWTmZVRVZPUkVsT1J5d2dKMFZ6WTNKdmR5QnViM1FnYVc0Z2NHVnVaR2x1WnlCemRHRjBaU2NwQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUVWelkzSnZkeUJ1YjNRZ2FXNGdjR1Z1WkdsdVp5QnpkR0YwWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmR5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTJDaUFnSUNBdkx5QnpaWEoyYVdObFVtVnpkV3gwSUQwZ1IyeHZZbUZzVTNSaGRHVThZbmwwWlhNK0tDa0tJQ0FnSUdKNWRHVmpJRFlnTHk4Z0luTmxjblpwWTJWU1pYTjFiSFFpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5UQUtJQ0FnSUM4dklIUm9hWE11YzJWeWRtbGpaVkpsYzNWc2RDNTJZV3gxWlNBOUlITmxjblpwWTJWU1pYTjFiSFFLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UUUtJQ0FnSUM4dklITjBZWFIxY3lBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9LUW9nSUNBZ1lubDBaV05mTUNBdkx5QWljM1JoZEhWeklnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalV4Q2lBZ0lDQXZMeUIwYUdsekxuTjBZWFIxY3k1MllXeDFaU0E5SUZOVVFWUlZVMTlEVDAxUVRFVlVSVVFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRMkNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2dZV3hzYjNkQlkzUnBiMjV6T2lBblRtOVBjQ2NnZlNrS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rVnpZM0p2ZDBOdmJuUnlZV04wTG5Wd1pHRjBaVk4wWVhSMWMxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDblZ3WkdGMFpWTjBZWFIxY3pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFOQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUdGc2JHOTNRV04wYVc5dWN6b2dKMDV2VDNBbklIMHBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmR5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVTJDaUFnSUNBdkx5QmhjM05sY25Rb1ptRnNjMlVzSUNkMWNHUmhkR1ZUZEdGMGRYTWdhWE1nWkdWd2NtVmpZWFJsWkNCaGJtUWdjMmh2ZFd4a0lHNXZkQ0JpWlNCMWMyVmtKeWs3Q2lBZ0lDQmxjbklnTHk4Z2RYQmtZWFJsVTNSaGRIVnpJR2x6SUdSbGNISmxZMkYwWldRZ1lXNWtJSE5vYjNWc1pDQnViM1FnWW1VZ2RYTmxaQW9LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2N2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82UlhOamNtOTNRMjl1ZEhKaFkzUXVjbVZzWldGelpVWjFibVJ6VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2NtVnNaV0Z6WlVaMWJtUnpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZeENpQWdJQ0F2THlCaGMzTmxjblFvVkhodUxuTmxibVJsY2lBOVBUMGdkR2hwY3k1aFoyVnVkQzUyWVd4MVpTd2dKMDl1YkhrZ1lXZGxiblFnWTJGdUlISmxiR1ZoYzJVbktRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNjdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1Rb2dJQ0FnTHk4Z1lXZGxiblFnUFNCSGJHOWlZV3hUZEdGMFpUeEJZMk52ZFc1MFBpZ3BDaUFnSUNCaWVYUmxZMTh4SUM4dklDSmhaMlZ1ZENJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJNUW9nSUNBZ0x5OGdZWE56WlhKMEtGUjRiaTV6Wlc1a1pYSWdQVDA5SUhSb2FYTXVZV2RsYm5RdWRtRnNkV1VzSUNkUGJteDVJR0ZuWlc1MElHTmhiaUJ5Wld4bFlYTmxKeWtLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dWJIa2dZV2RsYm5RZ1kyRnVJSEpsYkdWaGMyVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2N2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTWdvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdWMzUmhkSFZ6TG5aaGJIVmxJRDA5UFNCVFZFRlVWVk5mUTA5TlVFeEZWRVZFTENBblUyVnlkbWxqWlNCdWIzUWdZMjl1Wm1seWJXVmtKeWtLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRRS0lDQWdJQzh2SUhOMFlYUjFjeUE5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b0tRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWMzUmhkSFZ6SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmR5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWXlDaUFnSUNBdkx5QmhjM05sY25Rb2RHaHBjeTV6ZEdGMGRYTXVkbUZzZFdVZ1BUMDlJRk5VUVZSVlUxOURUMDFRVEVWVVJVUXNJQ2RUWlhKMmFXTmxJRzV2ZENCamIyNW1hWEp0WldRbktRb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklGTmxjblpwWTJVZ2JtOTBJR052Ym1acGNtMWxaQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZMExUWTRDaUFnSUNBdkx5QnBkSGh1TG5CaGVXMWxiblFvZXdvZ0lDQWdMeThnSUNCeVpXTmxhWFpsY2pvZ2RHaHBjeTV3Y205MmFXUmxjaTUyWVd4MVpTd0tJQ0FnSUM4dklDQWdZVzF2ZFc1ME9pQjBhR2x6TG1GdGIzVnVkRXh2WTJ0bFpDNTJZV3gxWlN3S0lDQWdJQzh2SUNBZ1ptVmxPaUJWYVc1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUI5S1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZMUNpQWdJQ0F2THlCeVpXTmxhWFpsY2pvZ2RHaHBjeTV3Y205MmFXUmxjaTUyWVd4MVpTd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVElLSUNBZ0lDOHZJSEJ5YjNacFpHVnlJRDBnUjJ4dlltRnNVM1JoZEdVOFFXTmpiM1Z1ZEQ0b0tRb2dJQ0FnWW5sMFpXTmZNeUF2THlBaWNISnZkbWxrWlhJaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOalVLSUNBZ0lDOHZJSEpsWTJWcGRtVnlPaUIwYUdsekxuQnliM1pwWkdWeUxuWmhiSFZsTEFvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNjdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk5nb2dJQ0FnTHk4Z1lXMXZkVzUwT2lCMGFHbHpMbUZ0YjNWdWRFeHZZMnRsWkM1MllXeDFaU3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRNS0lDQWdJQzh2SUdGdGIzVnVkRXh2WTJ0bFpDQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvS1FvZ0lDQWdZbmwwWldOZk1pQXZMeUFpWVcxdmRXNTBURzlqYTJWa0lnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalkyQ2lBZ0lDQXZMeUJoYlc5MWJuUTZJSFJvYVhNdVlXMXZkVzUwVEc5amEyVmtMblpoYkhWbExBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVcxdmRXNTBDaUFnSUNCcGRIaHVYMlpwWld4a0lGSmxZMlZwZG1WeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOalF0TmpnS0lDQWdJQzh2SUdsMGVHNHVjR0Y1YldWdWRDaDdDaUFnSUNBdkx5QWdJSEpsWTJWcGRtVnlPaUIwYUdsekxuQnliM1pwWkdWeUxuWmhiSFZsTEFvZ0lDQWdMeThnSUNCaGJXOTFiblE2SUhSb2FYTXVZVzF2ZFc1MFRHOWphMlZrTG5aaGJIVmxMQW9nSUNBZ0x5OGdJQ0JtWldVNklGVnBiblEyTkNnd0tTd0tJQ0FnSUM4dklIMHBMbk4xWW0xcGRDZ3BDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmR5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWTNDaUFnSUNBdkx5Qm1aV1U2SUZWcGJuUTJOQ2d3S1N3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmR5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWTBMVFk0Q2lBZ0lDQXZMeUJwZEhodUxuQmhlVzFsYm5Rb2V3b2dJQ0FnTHk4Z0lDQnlaV05sYVhabGNqb2dkR2hwY3k1d2NtOTJhV1JsY2k1MllXeDFaU3dLSUNBZ0lDOHZJQ0FnWVcxdmRXNTBPaUIwYUdsekxtRnRiM1Z1ZEV4dlkydGxaQzUyWVd4MVpTd0tJQ0FnSUM4dklDQWdabVZsT2lCVmFXNTBOalFvTUNrc0NpQWdJQ0F2THlCOUtTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOQW9nSUNBZ0x5OGdjM1JoZEhWeklEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWdwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0p6ZEdGMGRYTWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnpFS0lDQWdJQzh2SUhSb2FYTXVjM1JoZEhWekxuWmhiSFZsSUQwZ1UxUkJWRlZUWDBOUFRWQk1SVlJGUkFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5Ua0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJoYkd4dmQwRmpkR2x2Ym5NNklDZE9iMDl3SnlCOUtRb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZSWE5qY205M1EyOXVkSEpoWTNRdWNtVnFaV04wUVc1a1VtVm1kVzVrVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2NtVnFaV04wUVc1a1VtVm1kVzVrT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmR5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qYzBDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnWVd4c2IzZEJZM1JwYjI1ek9pQW5UbTlQY0NjZ2ZTa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNBckNpQWdJQ0J6ZDJGd0NpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmR5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qYzJDaUFnSUNBdkx5QmhjM05sY25Rb1ZIaHVMbk5sYm1SbGNpQTlQVDBnZEdocGN5NXdjbTkyYVdSbGNpNTJZV3gxWlNCOGZDQlVlRzR1YzJWdVpHVnlJRDA5UFNCMGFHbHpMbUZuWlc1MExuWmhiSFZsTENBblQyNXNlU0J3Y205MmFXUmxjaUJ2Y2lCaFoyVnVkQ2NwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV5Q2lBZ0lDQXZMeUJ3Y205MmFXUmxjaUE5SUVkc2IySmhiRk4wWVhSbFBFRmpZMjkxYm5RK0tDa0tJQ0FnSUdKNWRHVmpYek1nTHk4Z0luQnliM1pwWkdWeUlnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamMyQ2lBZ0lDQXZMeUJoYzNObGNuUW9WSGh1TG5ObGJtUmxjaUE5UFQwZ2RHaHBjeTV3Y205MmFXUmxjaTUyWVd4MVpTQjhmQ0JVZUc0dWMyVnVaR1Z5SUQwOVBTQjBhR2x6TG1GblpXNTBMblpoYkhWbExDQW5UMjVzZVNCd2NtOTJhV1JsY2lCdmNpQmhaMlZ1ZENjcENpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdQVDBLSUNBZ0lHSnVlaUJ5WldwbFkzUkJibVJTWldaMWJtUmZZbTl2YkY5MGNuVmxRRE1LSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEVLSUNBZ0lDOHZJR0ZuWlc1MElEMGdSMnh2WW1Gc1UzUmhkR1U4UVdOamIzVnVkRDRvS1FvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWVdkbGJuUWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnpZS0lDQWdJQzh2SUdGemMyVnlkQ2hVZUc0dWMyVnVaR1Z5SUQwOVBTQjBhR2x6TG5CeWIzWnBaR1Z5TG5aaGJIVmxJSHg4SUZSNGJpNXpaVzVrWlhJZ1BUMDlJSFJvYVhNdVlXZGxiblF1ZG1Gc2RXVXNJQ2RQYm14NUlIQnliM1pwWkdWeUlHOXlJR0ZuWlc1MEp5a0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0E5UFFvZ0lDQWdZbm9nY21WcVpXTjBRVzVrVW1WbWRXNWtYMkp2YjJ4ZlptRnNjMlZBTkFvS2NtVnFaV04wUVc1a1VtVm1kVzVrWDJKdmIyeGZkSEoxWlVBek9nb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0NuSmxhbVZqZEVGdVpGSmxablZ1WkY5aWIyOXNYMjFsY21kbFFEVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnpZS0lDQWdJQzh2SUdGemMyVnlkQ2hVZUc0dWMyVnVaR1Z5SUQwOVBTQjBhR2x6TG5CeWIzWnBaR1Z5TG5aaGJIVmxJSHg4SUZSNGJpNXpaVzVrWlhJZ1BUMDlJSFJvYVhNdVlXZGxiblF1ZG1Gc2RXVXNJQ2RQYm14NUlIQnliM1pwWkdWeUlHOXlJR0ZuWlc1MEp5a0tJQ0FnSUdGemMyVnlkQ0F2THlCUGJteDVJSEJ5YjNacFpHVnlJRzl5SUdGblpXNTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnpjS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxuTjBZWFIxY3k1MllXeDFaU0E5UFQwZ1UxUkJWRlZUWDFCRlRrUkpUa2NzSUNkRmMyTnliM2NnYm05MElHbHVJSEJsYm1ScGJtY2djM1JoZEdVbktRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOQW9nSUNBZ0x5OGdjM1JoZEhWeklEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWdwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0p6ZEdGMGRYTWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnpjS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxuTjBZWFIxY3k1MllXeDFaU0E5UFQwZ1UxUkJWRlZUWDFCRlRrUkpUa2NzSUNkRmMyTnliM2NnYm05MElHbHVJSEJsYm1ScGJtY2djM1JoZEdVbktRb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QkZjMk55YjNjZ2JtOTBJR2x1SUhCbGJtUnBibWNnYzNSaGRHVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2N2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zT1MwNE13b2dJQ0FnTHk4Z2FYUjRiaTV3WVhsdFpXNTBLSHNLSUNBZ0lDOHZJQ0FnY21WalpXbDJaWEk2SUhSb2FYTXVZV2RsYm5RdWRtRnNkV1VzQ2lBZ0lDQXZMeUFnSUdGdGIzVnVkRG9nZEdocGN5NWhiVzkxYm5STWIyTnJaV1F1ZG1Gc2RXVXNDaUFnSUNBdkx5QWdJR1psWlRvZ1ZXbHVkRFkwS0RBcExBb2dJQ0FnTHk4Z2ZTa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzRNQW9nSUNBZ0x5OGdjbVZqWldsMlpYSTZJSFJvYVhNdVlXZGxiblF1ZG1Gc2RXVXNDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV4Q2lBZ0lDQXZMeUJoWjJWdWRDQTlJRWRzYjJKaGJGTjBZWFJsUEVGalkyOTFiblErS0NrS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1GblpXNTBJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pnd0NpQWdJQ0F2THlCeVpXTmxhWFpsY2pvZ2RHaHBjeTVoWjJWdWRDNTJZV3gxWlN3S0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9ERUtJQ0FnSUM4dklHRnRiM1Z1ZERvZ2RHaHBjeTVoYlc5MWJuUk1iMk5yWldRdWRtRnNkV1VzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFekNpQWdJQ0F2THlCaGJXOTFiblJNYjJOclpXUWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0NrS0lDQWdJR0o1ZEdWalh6SWdMeThnSW1GdGIzVnVkRXh2WTJ0bFpDSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2N2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem80TVFvZ0lDQWdMeThnWVcxdmRXNTBPaUIwYUdsekxtRnRiM1Z1ZEV4dlkydGxaQzUyWVd4MVpTd0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGdGIzVnVkQW9nSUNBZ2FYUjRibDltYVdWc1pDQlNaV05sYVhabGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamM1TFRnekNpQWdJQ0F2THlCcGRIaHVMbkJoZVcxbGJuUW9ld29nSUNBZ0x5OGdJQ0J5WldObGFYWmxjam9nZEdocGN5NWhaMlZ1ZEM1MllXeDFaU3dLSUNBZ0lDOHZJQ0FnWVcxdmRXNTBPaUIwYUdsekxtRnRiM1Z1ZEV4dlkydGxaQzUyWVd4MVpTd0tJQ0FnSUM4dklDQWdabVZsT2lCVmFXNTBOalFvTUNrc0NpQWdJQ0F2THlCOUtTNXpkV0p0YVhRb0tRb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNjdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNE1nb2dJQ0FnTHk4Z1ptVmxPaUJWYVc1ME5qUW9NQ2tzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNjdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM09TMDRNd29nSUNBZ0x5OGdhWFI0Ymk1d1lYbHRaVzUwS0hzS0lDQWdJQzh2SUNBZ2NtVmpaV2wyWlhJNklIUm9hWE11WVdkbGJuUXVkbUZzZFdVc0NpQWdJQ0F2THlBZ0lHRnRiM1Z1ZERvZ2RHaHBjeTVoYlc5MWJuUk1iMk5yWldRdWRtRnNkV1VzQ2lBZ0lDQXZMeUFnSUdabFpUb2dWV2x1ZERZMEtEQXBMQW9nSUNBZ0x5OGdmU2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRRS0lDQWdJQzh2SUhOMFlYUjFjeUE5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b0tRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWMzUmhkSFZ6SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmR5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qZzFDaUFnSUNBdkx5QjBhR2x6TG5OMFlYUjFjeTUyWVd4MVpTQTlJRk5VUVZSVlUxOVNSVVpWVGtSRlJBb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOelFLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCaGJHeHZkMEZqZEdsdmJuTTZJQ2RPYjA5d0p5QjlLUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LY21WcVpXTjBRVzVrVW1WbWRXNWtYMkp2YjJ4ZlptRnNjMlZBTkRvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmlJSEpsYW1WamRFRnVaRkpsWm5WdVpGOWliMjlzWDIxbGNtZGxRRFVLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2tWelkzSnZkME52Ym5SeVlXTjBMbVY0Y0dseVpVRnVaRkpsWm5WdVpGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbVY0Y0dseVpVRnVaRkpsWm5WdVpEb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2N2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem81TUFvZ0lDQWdMeThnWVhOelpYSjBLRWRzYjJKaGJDNXNZWFJsYzNSVWFXMWxjM1JoYlhBZ1BpQjBhR2x6TG14dlkydFVhVzFsTG5aaGJIVmxJQ3NnZEdocGN5NTBhVzFsYjNWMExuWmhiSFZsTENBblRtOTBJR1Y0Y0dseVpXUW5LUW9nSUNBZ1oyeHZZbUZzSUV4aGRHVnpkRlJwYldWemRHRnRjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2N2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TndvZ0lDQWdMeThnYkc5amExUnBiV1VnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tDa0tJQ0FnSUdKNWRHVmpJRFFnTHk4Z0lteHZZMnRVYVcxbElnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamt3Q2lBZ0lDQXZMeUJoYzNObGNuUW9SMnh2WW1Gc0xteGhkR1Z6ZEZScGJXVnpkR0Z0Y0NBK0lIUm9hWE11Ykc5amExUnBiV1V1ZG1Gc2RXVWdLeUIwYUdsekxuUnBiV1Z2ZFhRdWRtRnNkV1VzSUNkT2IzUWdaWGh3YVhKbFpDY3BDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hPQW9nSUNBZ0x5OGdkR2x0Wlc5MWRDQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvS1FvZ0lDQWdZbmwwWldNZ05TQXZMeUFpZEdsdFpXOTFkQ0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNjdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNU1Bb2dJQ0FnTHk4Z1lYTnpaWEowS0Vkc2IySmhiQzVzWVhSbGMzUlVhVzFsYzNSaGJYQWdQaUIwYUdsekxteHZZMnRVYVcxbExuWmhiSFZsSUNzZ2RHaHBjeTUwYVcxbGIzVjBMblpoYkhWbExDQW5UbTkwSUdWNGNHbHlaV1FuS1FvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDc0tJQ0FnSUQ0S0lDQWdJR0Z6YzJWeWRDQXZMeUJPYjNRZ1pYaHdhWEpsWkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmR5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qa3hDaUFnSUNBdkx5QmhjM05sY25Rb2RHaHBjeTV6ZEdGMGRYTXVkbUZzZFdVZ1BUMDlJRk5VUVZSVlUxOVFSVTVFU1U1SExDQW5RV3h5WldGa2VTQnlaWE52YkhabFpDY3BDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUwQ2lBZ0lDQXZMeUJ6ZEdGMGRYTWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0NrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5OMFlYUjFjeUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNjdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNU1Rb2dJQ0FnTHk4Z1lYTnpaWEowS0hSb2FYTXVjM1JoZEhWekxuWmhiSFZsSUQwOVBTQlRWRUZVVlZOZlVFVk9SRWxPUnl3Z0owRnNjbVZoWkhrZ2NtVnpiMngyWldRbktRb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QkJiSEpsWVdSNUlISmxjMjlzZG1Wa0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPVE10T1RjS0lDQWdJQzh2SUdsMGVHNHVjR0Y1YldWdWRDaDdDaUFnSUNBdkx5QWdJSEpsWTJWcGRtVnlPaUIwYUdsekxtRm5aVzUwTG5aaGJIVmxMQW9nSUNBZ0x5OGdJQ0JoYlc5MWJuUTZJSFJvYVhNdVlXMXZkVzUwVEc5amEyVmtMblpoYkhWbExBb2dJQ0FnTHk4Z0lDQm1aV1U2SUZWcGJuUTJOQ2d3S1N3S0lDQWdJQzh2SUgwcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9UUUtJQ0FnSUM4dklISmxZMlZwZG1WeU9pQjBhR2x6TG1GblpXNTBMblpoYkhWbExBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNUW9nSUNBZ0x5OGdZV2RsYm5RZ1BTQkhiRzlpWVd4VGRHRjBaVHhCWTJOdmRXNTBQaWdwQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0poWjJWdWRDSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2N2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem81TkFvZ0lDQWdMeThnY21WalpXbDJaWEk2SUhSb2FYTXVZV2RsYm5RdWRtRnNkV1VzQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2prMUNpQWdJQ0F2THlCaGJXOTFiblE2SUhSb2FYTXVZVzF2ZFc1MFRHOWphMlZrTG5aaGJIVmxMQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2N2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TXdvZ0lDQWdMeThnWVcxdmRXNTBURzlqYTJWa0lEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWdwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0poYlc5MWJuUk1iMk5yWldRaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPVFVLSUNBZ0lDOHZJR0Z0YjNWdWREb2dkR2hwY3k1aGJXOTFiblJNYjJOclpXUXVkbUZzZFdVc0NpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYlc5MWJuUUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1VtVmpaV2wyWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzVNeTA1TndvZ0lDQWdMeThnYVhSNGJpNXdZWGx0Wlc1MEtIc0tJQ0FnSUM4dklDQWdjbVZqWldsMlpYSTZJSFJvYVhNdVlXZGxiblF1ZG1Gc2RXVXNDaUFnSUNBdkx5QWdJR0Z0YjNWdWREb2dkR2hwY3k1aGJXOTFiblJNYjJOclpXUXVkbUZzZFdVc0NpQWdJQ0F2THlBZ0lHWmxaVG9nVldsdWREWTBLREFwTEFvZ0lDQWdMeThnZlNrdWMzVmliV2wwS0NrS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T1RZS0lDQWdJQzh2SUdabFpUb2dWV2x1ZERZMEtEQXBMQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T1RNdE9UY0tJQ0FnSUM4dklHbDBlRzR1Y0dGNWJXVnVkQ2g3Q2lBZ0lDQXZMeUFnSUhKbFkyVnBkbVZ5T2lCMGFHbHpMbUZuWlc1MExuWmhiSFZsTEFvZ0lDQWdMeThnSUNCaGJXOTFiblE2SUhSb2FYTXVZVzF2ZFc1MFRHOWphMlZrTG5aaGJIVmxMQW9nSUNBZ0x5OGdJQ0JtWldVNklGVnBiblEyTkNnd0tTd0tJQ0FnSUM4dklIMHBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUwQ2lBZ0lDQXZMeUJ6ZEdGMGRYTWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0NrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5OMFlYUjFjeUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNjdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNU9Rb2dJQ0FnTHk4Z2RHaHBjeTV6ZEdGMGRYTXVkbUZzZFdVZ1BTQlRWRUZVVlZOZlJWaFFTVkpGUkFvZ0lDQWdjSFZ6YUdsdWRDQXpJQzh2SURNS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPRGdLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCaGJHeHZkMEZqZEdsdmJuTTZJQ2RPYjA5d0p5QjlLUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2N2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82UlhOamNtOTNRMjl1ZEhKaFkzUXVaMlYwUlhOamNtOTNTVzVtYjF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtZGxkRVZ6WTNKdmQwbHVabTg2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UQTFDaUFnSUNBdkx5QjBhR2x6TG1GblpXNTBMblpoYkhWbExBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNUW9nSUNBZ0x5OGdZV2RsYm5RZ1BTQkhiRzlpWVd4VGRHRjBaVHhCWTJOdmRXNTBQaWdwQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0poWjJWdWRDSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2N2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TURVS0lDQWdJQzh2SUhSb2FYTXVZV2RsYm5RdWRtRnNkV1VzQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFd05nb2dJQ0FnTHk4Z2RHaHBjeTV3Y205MmFXUmxjaTUyWVd4MVpTd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVElLSUNBZ0lDOHZJSEJ5YjNacFpHVnlJRDBnUjJ4dlltRnNVM1JoZEdVOFFXTmpiM1Z1ZEQ0b0tRb2dJQ0FnWW5sMFpXTmZNeUF2THlBaWNISnZkbWxrWlhJaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEEyQ2lBZ0lDQXZMeUIwYUdsekxuQnliM1pwWkdWeUxuWmhiSFZsTEFvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNjdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1EY0tJQ0FnSUM4dklIUm9hWE11WVcxdmRXNTBURzlqYTJWa0xuWmhiSFZsTEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNjdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE13b2dJQ0FnTHk4Z1lXMXZkVzUwVEc5amEyVmtJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGlncENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKaGJXOTFiblJNYjJOclpXUWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRBM0NpQWdJQ0F2THlCMGFHbHpMbUZ0YjNWdWRFeHZZMnRsWkM1MllXeDFaU3dLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRBNENpQWdJQ0F2THlCMGFHbHpMbk4wWVhSMWN5NTJZV3gxWlN3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UUUtJQ0FnSUM4dklITjBZWFIxY3lBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9LUW9nSUNBZ1lubDBaV05mTUNBdkx5QWljM1JoZEhWeklnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV3T0FvZ0lDQWdMeThnZEdocGN5NXpkR0YwZFhNdWRtRnNkV1VzQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFd05DMHhNRGtLSUNBZ0lDOHZJSEpsZEhWeWJpQmJDaUFnSUNBdkx5QWdJSFJvYVhNdVlXZGxiblF1ZG1Gc2RXVXNDaUFnSUNBdkx5QWdJSFJvYVhNdWNISnZkbWxrWlhJdWRtRnNkV1VzQ2lBZ0lDQXZMeUFnSUhSb2FYTXVZVzF2ZFc1MFRHOWphMlZrTG5aaGJIVmxMQW9nSUNBZ0x5OGdJQ0IwYUdsekxuTjBZWFIxY3k1MllXeDFaU3dLSUNBZ0lDOHZJRjBLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNRElLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCaGJHeHZkMEZqZEdsdmJuTTZJQ2RPYjA5d0p5d2djbVZoWkc5dWJIazZJSFJ5ZFdVZ2ZTa0tJQ0FnSUdKNWRHVmpJRGNnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPa1Z6WTNKdmQwTnZiblJ5WVdOMExtZGxkRk4wWVhSMWMxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWRsZEZOMFlYUjFjem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNjdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1UUUtJQ0FnSUM4dklISmxkSFZ5YmlCMGFHbHpMbk4wWVhSMWN5NTJZV3gxWlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNjdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5Bb2dJQ0FnTHk4Z2MzUmhkSFZ6SUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpZ3BDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnpkR0YwZFhNaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEUwQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdkR2hwY3k1emRHRjBkWE11ZG1Gc2RXVUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEV5Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ1lXeHNiM2RCWTNScGIyNXpPaUFuVG05UGNDY3NJSEpsWVdSdmJteDVPaUIwY25WbElIMHBDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZeUEzSUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQUFFQ0NDWUlCbk4wWVhSMWN3VmhaMlZ1ZEF4aGJXOTFiblJNYjJOclpXUUljSEp2ZG1sa1pYSUliRzlqYTFScGJXVUhkR2x0Wlc5MWRBMXpaWEoyYVdObFVtVnpkV3gwQkJVZmZIVXhHMEVBVGpFWkZFUXhHRVNDQ1FUbjl5RjBCRXlkTHFjRWYrOC90d1I1L2NkekJGdHlBZFVFVkhvcmZ3U05EUEpjQkxMdkRVMEVtU3JEdmpZYUFJNEpBQXNBYkFDVkFMd0F4QURzQVRFQllBR0RBREVaRkRFWUZCQkVJME0yR2dGSkZZRWdFa1EyR2dKSkZZRWdFa1EyR2dOSklsa2tDRXNCRlJKRVZ3SUFOaG9FU1JVbEVrUVhOaG9GU1JVbEVrUVhLVThGWnl0UEJHZUFDWE5sY25acFkyVkpaRThEWnlwUEFtY29JbWNuQkRJSFp5Y0ZUR2NuQmpJRFp5TkRNUllqQ1VrNEVDTVNSREVBSWlsbFJCSkVJaWhsUkJSRVNUZ0hNZ29TUkRnSUlpcGxSQkpFSTBNMkdnRkpJbGtrQ0VzQkZSSkVWd0lBTVFBaUsyVkVFa1FpS0dWRUZFUW5Ca3huS0NObkkwTTJHZ0VWSlJKRUFERUFJaWxsUkJKRUlpaGxSQ01TUkxFaUsyVkVJaXBsUkxJSXNnY2pzaEFpc2dHektDTm5JME0yR2dGSklsa2tDRXdWRWtReEFDSXJaVVFTUUFBS01RQWlLV1ZFRWtFQUlTTkVJaWhsUkJSRXNTSXBaVVFpS21WRXNnaXlCeU95RUNLeUFiTW9KR2NqUXlKQy85d3lCeUluQkdWRUlpY0ZaVVFJRFVRaUtHVkVGRVN4SWlsbFJDSXFaVVN5Q0xJSEk3SVFJcklCc3lpQkEyY2pReUlwWlVRaUsyVkVJaXBsUkNJb1pVUlBBMDhEVUU4Q0ZsQk1GbEFuQjB4UXNDTkRJaWhsUkJZbkIweFFzQ05EIiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6MywicGF0Y2giOjIsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
