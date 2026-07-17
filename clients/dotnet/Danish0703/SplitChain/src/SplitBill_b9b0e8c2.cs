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

namespace Arc56.Generated.Danish0703.SplitChain.SplitBill_b9b0e8c2
{


    public class SplitBillProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public SplitBillProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class GetStatusReturn : AVMObjectType
            {
                public bool Field0 { get; set; }

                public bool Field1 { get; set; }

                public ulong Field2 { get; set; }

                public ulong Field3 { get; set; }

                public ulong Field4 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField2.From(Field2);
                    ret.AddRange(vField2.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField3.From(Field3);
                    ret.AddRange(vField3.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField4.From(Field4);
                    ret.AddRange(vField4.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static GetStatusReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetStatusReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is bool vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is bool vField1Value) { ret.Field1 = vField1Value; }
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField4.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField4 = vField4.ToValue();
                    if (valueField4 is ulong vField4Value) { ret.Field4 = vField4Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetStatusReturn);
                }
                public bool Equals(GetStatusReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetStatusReturn left, GetStatusReturn right)
                {
                    return EqualityComparer<GetStatusReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetStatusReturn left, GetStatusReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="billIdHash"> </param>
        /// <param name="payerAddress"> </param>
        /// <param name="assetId"> </param>
        /// <param name="totalAtomic"> </param>
        /// <param name="deadline"> </param>
        public async Task CreateBill(string billIdHash, string payerAddress, ulong assetId, ulong totalAtomic, ulong deadline, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 254, 144, 32, 35 };
            var billIdHashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); billIdHashAbi.From(billIdHash);
            var payerAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); payerAddressAbi.From(payerAddress);
            var assetIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetIdAbi.From(assetId);
            var totalAtomicAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); totalAtomicAbi.From(totalAtomic);
            var deadlineAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); deadlineAbi.From(deadline);

            var result = await base.CallApp(new List<object> { abiHandle, billIdHashAbi, payerAddressAbi, assetIdAbi, totalAtomicAbi, deadlineAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateBill_Transactions(string billIdHash, string payerAddress, ulong assetId, ulong totalAtomic, ulong deadline, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 254, 144, 32, 35 };
            var billIdHashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); billIdHashAbi.From(billIdHash);
            var payerAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); payerAddressAbi.From(payerAddress);
            var assetIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetIdAbi.From(assetId);
            var totalAtomicAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); totalAtomicAbi.From(totalAtomic);
            var deadlineAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); deadlineAbi.From(deadline);

            return await base.MakeTransactionList(new List<object> { abiHandle, billIdHashAbi, payerAddressAbi, assetIdAbi, totalAtomicAbi, deadlineAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="participantAddress"> </param>
        /// <param name="shareBps"> </param>
        public async Task RegisterParticipant(string participantAddress, ulong shareBps, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 56, 20, 113, 0 };
            var participantAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); participantAddressAbi.From(participantAddress);
            var shareBpsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); shareBpsAbi.From(shareBps);

            var result = await base.CallApp(new List<object> { abiHandle, participantAddressAbi, shareBpsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RegisterParticipant_Transactions(string participantAddress, ulong shareBps, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 56, 20, 113, 0 };
            var participantAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); participantAddressAbi.From(participantAddress);
            var shareBpsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); shareBpsAbi.From(shareBps);

            return await base.MakeTransactionList(new List<object> { abiHandle, participantAddressAbi, shareBpsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task LockBill(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 50, 60, 98, 247 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> LockBill_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 50, 60, 98, 247 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="participantAddress"> </param>
        /// <param name="amountAtomic"> </param>
        /// <param name="paymentTxIdHash"> </param>
        public async Task SubmitPayment(string participantAddress, ulong amountAtomic, string paymentTxIdHash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 158, 190, 220, 49 };
            var participantAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); participantAddressAbi.From(participantAddress);
            var amountAtomicAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAtomicAbi.From(amountAtomic);
            var paymentTxIdHashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); paymentTxIdHashAbi.From(paymentTxIdHash);

            var result = await base.CallApp(new List<object> { abiHandle, participantAddressAbi, amountAtomicAbi, paymentTxIdHashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SubmitPayment_Transactions(string participantAddress, ulong amountAtomic, string paymentTxIdHash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 158, 190, 220, 49 };
            var participantAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); participantAddressAbi.From(participantAddress);
            var amountAtomicAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAtomicAbi.From(amountAtomic);
            var paymentTxIdHashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); paymentTxIdHashAbi.From(paymentTxIdHash);

            return await base.MakeTransactionList(new List<object> { abiHandle, participantAddressAbi, amountAtomicAbi, paymentTxIdHashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task MarkSettled(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 236, 169, 252, 223 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> MarkSettled_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 236, 169, 252, 223 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.GetStatusReturn> GetStatus(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 183, 102, 146, 28 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetStatusReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetStatus_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 183, 102, 146, 28 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU3BsaXRCaWxsIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkdldFN0YXR1c1JldHVybiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJib29sIn0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJmaWVsZDIiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQzIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkNCIsInR5cGUiOiJ1aW50NjQifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlQmlsbCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiaWxsSWRIYXNoIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXllckFkZHJlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0SWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvdGFsQXRvbWljIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkZWFkbGluZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWdpc3RlclBhcnRpY2lwYW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBhcnRpY2lwYW50QWRkcmVzcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic2hhcmVCcHMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibG9ja0JpbGwiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic3VibWl0UGF5bWVudCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXJ0aWNpcGFudEFkZHJlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudEF0b21pYyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5bWVudFR4SWRIYXNoIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im1hcmtTZXR0bGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFN0YXR1cyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiIoYm9vbCxib29sLHVpbnQ2NCx1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IkdldFN0YXR1c1JldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoyNTYsImJ5dGVzIjozMn0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMjcyXSwiZXJyb3JNZXNzYWdlIjoiQmlsbCBhbHJlYWR5IGluaXRpYWxpemVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzUyLDQwNl0sImVycm9yTWVzc2FnZSI6IkJpbGwgYWxyZWFkeSBsb2NrZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NzJdLCJlcnJvck1lc3NhZ2UiOiJCaWxsIGFscmVhZHkgc2V0dGxlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ2Nl0sImVycm9yTWVzc2FnZSI6IkJpbGwgbXVzdCBiZSBsb2NrZWQgZmlyc3QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MzRdLCJlcnJvck1lc3NhZ2UiOiJDYW5ub3Qgc2V0dGxlIGJlZm9yZSBmdWxsIHBheW1lbnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0OThdLCJlcnJvck1lc3NhZ2UiOiJEdXBsaWNhdGUgcGF5bWVudCBwcm9vZiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0Ml0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBtdXN0IGJlIE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDNdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBOb09wICYmIGNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM3Nl0sImVycm9yTWVzc2FnZSI6IlBhcnRpY2lwYW50IGFscmVhZHkgcmVnaXN0ZXJlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM2M10sImVycm9yTWVzc2FnZSI6IlBhcnRpY2lwYW50IGNhcCByZWFjaGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDgzXSwiZXJyb3JNZXNzYWdlIjoiUGFydGljaXBhbnQgaXMgbm90IHJlZ2lzdGVyZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNTRdLCJlcnJvck1lc3NhZ2UiOiJTaGFyZSBtdXN0IGJlIHBvc2l0aXZlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjc1XSwiZXJyb3JNZXNzYWdlIjoiVG90YWwgYW1vdW50IG11c3QgYmUgPiAwIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDE1XSwiZXJyb3JNZXNzYWdlIjoiVG90YWwgc2hhcmVzIG11c3QgZXF1YWwgMTAwMDAgYnBzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzUwLDM1OSwzODMsMzkyLDQwNCw0MTAsNDY1LDQ3MCw1MDQsNTE0LDUyNyw1MzIsNTQzLDU0Nyw1NTIsNTU2LDU2MF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIEdsb2JhbFN0YXRlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIxMSwyMjcsMzI3LDQyNiw0NTFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMTgsMjM0LDMzNCw0MzMsNDU4XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI0NSwyNTQsMjYzLDM0NSw0NDRdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01DQXhJRElnT0FvZ0lDQWdZbmwwWldOaWJHOWpheUFpYVhOTWIyTnJaV1FpSUNKMGIzUmhiRk5vWVhKbFFuQnpJaUFpZEc5MFlXeFFZV2xrUVhSdmJXbGpJaUFpYVhOVFpYUjBiR1ZrSWlBaWNHRnlkR2xqYVhCaGJuUkRiM1Z1ZENJZ0luUnZkR0ZzUVhSdmJXbGpJaUFpWVhOelpYUkpaQ0lnSW1KcGJHeEpaRWhoYzJnaUlDSndYeUlLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpYm5vZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFESUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emNHeHBkRjlpYVd4c0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9Bb2dJQ0FnTHk4Z1lYTnpaWFJKWkNBOUlFZHNiMkpoYkZOMFlYUmxLSHNnYVc1cGRHbGhiRlpoYkhWbE9pQlZhVzUwTmpRb01Da2dmU2tLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdJbUZ6YzJWMFNXUWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emNHeHBkRjlpYVd4c0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1URUtJQ0FnSUM4dklIUnZkR0ZzVTJoaGNtVkNjSE1nUFNCSGJHOWlZV3hUZEdGMFpTaDdJR2x1YVhScFlXeFdZV3gxWlRvZ1ZXbHVkRFkwS0RBcElIMHBDaUFnSUNCaWVYUmxZMTh4SUM4dklDSjBiM1JoYkZOb1lYSmxRbkJ6SWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM0JzYVhSZlltbHNiQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV5Q2lBZ0lDQXZMeUJ3WVhKMGFXTnBjR0Z1ZEVOdmRXNTBJRDBnUjJ4dlltRnNVM1JoZEdVb2V5QnBibWwwYVdGc1ZtRnNkV1U2SUZWcGJuUTJOQ2d3S1NCOUtRb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaWNHRnlkR2xqYVhCaGJuUkRiM1Z1ZENJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM053YkdsMFgySnBiR3d2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TXdvZ0lDQWdMeThnZEc5MFlXeFFZV2xrUVhSdmJXbGpJRDBnUjJ4dlltRnNVM1JoZEdVb2V5QnBibWwwYVdGc1ZtRnNkV1U2SUZWcGJuUTJOQ2d3S1NCOUtRb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWRHOTBZV3hRWVdsa1FYUnZiV2xqSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM0JzYVhSZlltbHNiQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUwQ2lBZ0lDQXZMeUJwYzB4dlkydGxaQ0E5SUVkc2IySmhiRk4wWVhSbEtIc2dhVzVwZEdsaGJGWmhiSFZsT2lCbVlXeHpaU0I5S1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpYVhOTWIyTnJaV1FpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpjR3hwZEY5aWFXeHNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFVLSUNBZ0lDOHZJR2x6VTJWMGRHeGxaQ0E5SUVkc2IySmhiRk4wWVhSbEtIc2dhVzVwZEdsaGJGWmhiSFZsT2lCbVlXeHpaU0I5S1FvZ0lDQWdZbmwwWldOZk15QXZMeUFpYVhOVFpYUjBiR1ZrSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2dwdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emNHeHBkRjlpYVd4c0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5DMDFDaUFnSUNBdkx5QkFZMjl1ZEhKaFkzUW9leUJ6ZEdGMFpWUnZkR0ZzY3pvZ2V5Qm5iRzlpWVd4VmFXNTBjem9nTWpVMkxDQm5iRzlpWVd4Q2VYUmxjem9nTXpJZ2ZTQjlLUW9nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUZOd2JHbDBRbWxzYkNCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0JpZWlCdFlXbHVYMTlmWVd4bmIzUnpYMTh1WkdWbVlYVnNkRU55WldGMFpVQXhOUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJ0ZFhOMElHSmxJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFLSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGhtWlRrd01qQXlNeUF3ZURNNE1UUTNNVEF3SURCNE16SXpZell5WmpjZ01IZzVaV0psWkdNek1TQXdlR1ZqWVRsbVkyUm1JREI0WWpjMk5qa3lNV01nTHk4Z2JXVjBhRzlrSUNKamNtVmhkR1ZDYVd4c0tITjBjbWx1Wnl4emRISnBibWNzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpY21WbmFYTjBaWEpRWVhKMGFXTnBjR0Z1ZENoemRISnBibWNzZFdsdWREWTBLWFp2YVdRaUxDQnRaWFJvYjJRZ0lteHZZMnRDYVd4c0tDbDJiMmxrSWl3Z2JXVjBhRzlrSUNKemRXSnRhWFJRWVhsdFpXNTBLSE4wY21sdVp5eDFhVzUwTmpRc2MzUnlhVzVuS1hadmFXUWlMQ0J0WlhSb2IyUWdJbTFoY210VFpYUjBiR1ZrS0NsMmIybGtJaXdnYldWMGFHOWtJQ0puWlhSVGRHRjBkWE1vS1NoaWIyOXNMR0p2YjJ3c2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXBJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnWTNKbFlYUmxRbWxzYkNCeVpXZHBjM1JsY2xCaGNuUnBZMmx3WVc1MElHeHZZMnRDYVd4c0lITjFZbTFwZEZCaGVXMWxiblFnYldGeWExTmxkSFJzWldRZ1oyVjBVM1JoZEhWekNpQWdJQ0JsY25JS0NtMWhhVzVmWDE5aGJHZHZkSE5mWHk1a1pXWmhkV3gwUTNKbFlYUmxRREUxT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM053YkdsMFgySnBiR3d2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTFRVS0lDQWdJQzh2SUVCamIyNTBjbUZqZENoN0lITjBZWFJsVkc5MFlXeHpPaUI3SUdkc2IySmhiRlZwYm5Sek9pQXlOVFlzSUdkc2IySmhiRUo1ZEdWek9pQXpNaUI5SUgwcENpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdVM0JzYVhSQ2FXeHNJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQ0VLSUNBZ0lDWW1DaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJRzExYzNRZ1ltVWdUbTlQY0NBbUppQmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdZM0psWVhScGJtY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNCc2FYUmZZbWxzYkM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwVGNHeHBkRUpwYkd3dVkzSmxZWFJsUW1sc2JGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbU55WldGMFpVSnBiR3c2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM0JzYVhSZlltbHNiQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUzQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdZM0psWVhSbFFtbHNiQ2hpYVd4c1NXUklZWE5vT2lCemRISnBibWNzSUhCaGVXVnlRV1JrY21WemN6b2djM1J5YVc1bkxDQmhjM05sZEVsa09pQjFhVzUwTmpRc0lIUnZkR0ZzUVhSdmJXbGpPaUIxYVc1ME5qUXNJR1JsWVdSc2FXNWxPaUIxYVc1ME5qUXBPaUIyYjJsa0lIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6SWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTlFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOd2JHbDBYMkpwYkd3dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE9Bb2dJQ0FnTHk4Z1lYTnpaWEowS0NGMGFHbHpMbUpwYkd4SlpFaGhjMmd1YUdGelZtRnNkV1VzSUNkQ2FXeHNJR0ZzY21WaFpIa2dhVzVwZEdsaGJHbDZaV1FuS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpjR3hwZEY5aWFXeHNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOZ29nSUNBZ0x5OGdZbWxzYkVsa1NHRnphQ0E5SUVkc2IySmhiRk4wWVhSbFBITjBjbWx1Wno0b0tRb2dJQ0FnWW5sMFpXTWdOeUF2THlBaVltbHNiRWxrU0dGemFDSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emNHeHBkRjlpYVd4c0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UZ0tJQ0FnSUM4dklHRnpjMlZ5ZENnaGRHaHBjeTVpYVd4c1NXUklZWE5vTG1oaGMxWmhiSFZsTENBblFtbHNiQ0JoYkhKbFlXUjVJR2x1YVhScFlXeHBlbVZrSnlrS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaWRYSjVJREVLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCQ2FXeHNJR0ZzY21WaFpIa2dhVzVwZEdsaGJHbDZaV1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpjR3hwZEY5aWFXeHNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGtLSUNBZ0lDOHZJR0Z6YzJWeWRDaDBiM1JoYkVGMGIyMXBZeUErSURBc0lDZFViM1JoYkNCaGJXOTFiblFnYlhWemRDQmlaU0ErSURBbktRb2dJQ0FnWkdsbklERUtJQ0FnSUdGemMyVnlkQ0F2THlCVWIzUmhiQ0JoYlc5MWJuUWdiWFZ6ZENCaVpTQStJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpjR3hwZEY5aWFXeHNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOZ29nSUNBZ0x5OGdZbWxzYkVsa1NHRnphQ0E5SUVkc2IySmhiRk4wWVhSbFBITjBjbWx1Wno0b0tRb2dJQ0FnWW5sMFpXTWdOeUF2THlBaVltbHNiRWxrU0dGemFDSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emNHeHBkRjlpYVd4c0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qRUtJQ0FnSUM4dklIUm9hWE11WW1sc2JFbGtTR0Z6YUM1MllXeDFaU0E5SUdKcGJHeEpaRWhoYzJnS0lDQWdJSFZ1WTI5MlpYSWdOUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpjR3hwZEY5aWFXeHNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOd29nSUNBZ0x5OGdjR0Y1WlhKQlpHUnlaWE56SUQwZ1IyeHZZbUZzVTNSaGRHVThjM1J5YVc1blBpZ3BDaUFnSUNCd2RYTm9ZbmwwWlhNZ0luQmhlV1Z5UVdSa2NtVnpjeUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpjR3hwZEY5aWFXeHNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNaklLSUNBZ0lDOHZJSFJvYVhNdWNHRjVaWEpCWkdSeVpYTnpMblpoYkhWbElEMGdjR0Y1WlhKQlpHUnlaWE56Q2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzQnNhWFJmWW1sc2JDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qZ0tJQ0FnSUM4dklHRnpjMlYwU1dRZ1BTQkhiRzlpWVd4VGRHRjBaU2g3SUdsdWFYUnBZV3hXWVd4MVpUb2dWV2x1ZERZMEtEQXBJSDBwQ2lBZ0lDQmllWFJsWXlBMklDOHZJQ0poYzNObGRFbGtJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTndiR2wwWDJKcGJHd3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNd29nSUNBZ0x5OGdkR2hwY3k1aGMzTmxkRWxrTG5aaGJIVmxJRDBnWVhOelpYUkpaQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOd2JHbDBYMkpwYkd3dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNUNpQWdJQ0F2THlCMGIzUmhiRUYwYjIxcFl5QTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvS1FvZ0lDQWdZbmwwWldNZ05TQXZMeUFpZEc5MFlXeEJkRzl0YVdNaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNCc2FYUmZZbWxzYkM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJMENpQWdJQ0F2THlCMGFHbHpMblJ2ZEdGc1FYUnZiV2xqTG5aaGJIVmxJRDBnZEc5MFlXeEJkRzl0YVdNS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpjR3hwZEY5aWFXeHNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEFLSUNBZ0lDOHZJR1JsWVdSc2FXNWxJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGlncENpQWdJQ0J3ZFhOb1lubDBaWE1nSW1SbFlXUnNhVzVsSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM053YkdsMFgySnBiR3d2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TlFvZ0lDQWdMeThnZEdocGN5NWtaV0ZrYkdsdVpTNTJZV3gxWlNBOUlHUmxZV1JzYVc1bENpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOd2JHbDBYMkpwYkd3dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE53b2dJQ0FnTHk4Z2NIVmliR2xqSUdOeVpXRjBaVUpwYkd3b1ltbHNiRWxrU0dGemFEb2djM1J5YVc1bkxDQndZWGxsY2tGa1pISmxjM002SUhOMGNtbHVaeXdnWVhOelpYUkpaRG9nZFdsdWREWTBMQ0IwYjNSaGJFRjBiMjFwWXpvZ2RXbHVkRFkwTENCa1pXRmtiR2x1WlRvZ2RXbHVkRFkwS1RvZ2RtOXBaQ0I3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTndiR2wwWDJKcGJHd3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZVM0JzYVhSQ2FXeHNMbkpsWjJsemRHVnlVR0Z5ZEdsamFYQmhiblJiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dweVpXZHBjM1JsY2xCaGNuUnBZMmx3WVc1ME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOd2JHbDBYMkpwYkd3dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU9Bb2dJQ0FnTHk4Z2NIVmliR2xqSUhKbFoybHpkR1Z5VUdGeWRHbGphWEJoYm5Rb2NHRnlkR2xqYVhCaGJuUkJaR1J5WlhOek9pQnpkSEpwYm1jc0lITm9ZWEpsUW5Cek9pQjFhVzUwTmpRcE9pQjJiMmxrSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM0JzYVhSZlltbHNiQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakk1Q2lBZ0lDQXZMeUJoYzNObGNuUW9JWFJvYVhNdWFYTk1iMk5yWldRdWRtRnNkV1VzSUNkQ2FXeHNJR0ZzY21WaFpIa2diRzlqYTJWa0p5a0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNCc2FYUmZZbWxzYkM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMENpQWdJQ0F2THlCcGMweHZZMnRsWkNBOUlFZHNiMkpoYkZOMFlYUmxLSHNnYVc1cGRHbGhiRlpoYkhWbE9pQm1ZV3h6WlNCOUtRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWFYTk1iMk5yWldRaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNCc2FYUmZZbWxzYkM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJNUNpQWdJQ0F2THlCaGMzTmxjblFvSVhSb2FYTXVhWE5NYjJOclpXUXVkbUZzZFdVc0lDZENhV3hzSUdGc2NtVmhaSGtnYkc5amEyVmtKeWtLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnUW1sc2JDQmhiSEpsWVdSNUlHeHZZMnRsWkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM053YkdsMFgySnBiR3d2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TUFvZ0lDQWdMeThnWVhOelpYSjBLSE5vWVhKbFFuQnpJRDRnTUN3Z0oxTm9ZWEpsSUcxMWMzUWdZbVVnY0c5emFYUnBkbVVuS1FvZ0lDQWdaSFZ3Q2lBZ0lDQmhjM05sY25RZ0x5OGdVMmhoY21VZ2JYVnpkQ0JpWlNCd2IzTnBkR2wyWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM053YkdsMFgySnBiR3d2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TVFvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdWNHRnlkR2xqYVhCaGJuUkRiM1Z1ZEM1MllXeDFaU0E4SURJd0xDQW5VR0Z5ZEdsamFYQmhiblFnWTJGd0lISmxZV05vWldRbktRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6Y0d4cGRGOWlhV3hzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRJS0lDQWdJQzh2SUhCaGNuUnBZMmx3WVc1MFEyOTFiblFnUFNCSGJHOWlZV3hUZEdGMFpTaDdJR2x1YVhScFlXeFdZV3gxWlRvZ1ZXbHVkRFkwS0RBcElIMHBDaUFnSUNCaWVYUmxZeUEwSUM4dklDSndZWEowYVdOcGNHRnVkRU52ZFc1MElnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOd2JHbDBYMkpwYkd3dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek1Rb2dJQ0FnTHk4Z1lYTnpaWEowS0hSb2FYTXVjR0Z5ZEdsamFYQmhiblJEYjNWdWRDNTJZV3gxWlNBOElESXdMQ0FuVUdGeWRHbGphWEJoYm5RZ1kyRndJSEpsWVdOb1pXUW5LUW9nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUhCMWMyaHBiblFnTWpBZ0x5OGdNakFLSUNBZ0lEd0tJQ0FnSUdGemMyVnlkQ0F2THlCUVlYSjBhV05wY0dGdWRDQmpZWEFnY21WaFkyaGxaQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTndiR2wwWDJKcGJHd3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pNd29nSUNBZ0x5OGdZMjl1YzNRZ2NHRnlkR2xqYVhCaGJuUlRhR0Z5WlNBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9leUJyWlhrNklHQndYeVI3Y0dGeWRHbGphWEJoYm5SQlpHUnlaWE56ZldBZ2ZTa0tJQ0FnSUdKNWRHVmpJRGdnTHk4Z0luQmZJZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emNHeHBkRjlpYVd4c0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16UUtJQ0FnSUM4dklHRnpjMlZ5ZENnaGNHRnlkR2xqYVhCaGJuUlRhR0Z5WlM1b1lYTldZV3gxWlN3Z0oxQmhjblJwWTJsd1lXNTBJR0ZzY21WaFpIa2djbVZuYVhOMFpYSmxaQ2NwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pHbG5JREVLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JpZFhKNUlERUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJRWVhKMGFXTnBjR0Z1ZENCaGJISmxZV1I1SUhKbFoybHpkR1Z5WldRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6Y0d4cGRGOWlhV3hzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpZS0lDQWdJQzh2SUhCaGNuUnBZMmx3WVc1MFUyaGhjbVV1ZG1Gc2RXVWdQU0J6YUdGeVpVSndjd29nSUNBZ1pHbG5JREVLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM0JzYVhSZlltbHNiQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak0zQ2lBZ0lDQXZMeUIwYUdsekxuUnZkR0ZzVTJoaGNtVkNjSE11ZG1Gc2RXVWdQU0IwYUdsekxuUnZkR0ZzVTJoaGNtVkNjSE11ZG1Gc2RXVWdLeUJ6YUdGeVpVSndjd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emNHeHBkRjlpYVd4c0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1URUtJQ0FnSUM4dklIUnZkR0ZzVTJoaGNtVkNjSE1nUFNCSGJHOWlZV3hUZEdGMFpTaDdJR2x1YVhScFlXeFdZV3gxWlRvZ1ZXbHVkRFkwS0RBcElIMHBDaUFnSUNCaWVYUmxZMTh4SUM4dklDSjBiM1JoYkZOb1lYSmxRbkJ6SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM053YkdsMFgySnBiR3d2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TndvZ0lDQWdMeThnZEdocGN5NTBiM1JoYkZOb1lYSmxRbkJ6TG5aaGJIVmxJRDBnZEdocGN5NTBiM1JoYkZOb1lYSmxRbkJ6TG5aaGJIVmxJQ3NnYzJoaGNtVkNjSE1LSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBckNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNCc2FYUmZZbWxzYkM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeENpQWdJQ0F2THlCMGIzUmhiRk5vWVhKbFFuQnpJRDBnUjJ4dlltRnNVM1JoZEdVb2V5QnBibWwwYVdGc1ZtRnNkV1U2SUZWcGJuUTJOQ2d3S1NCOUtRb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWRHOTBZV3hUYUdGeVpVSndjeUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpjR3hwZEY5aWFXeHNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNemNLSUNBZ0lDOHZJSFJvYVhNdWRHOTBZV3hUYUdGeVpVSndjeTUyWVd4MVpTQTlJSFJvYVhNdWRHOTBZV3hUYUdGeVpVSndjeTUyWVd4MVpTQXJJSE5vWVhKbFFuQnpDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTndiR2wwWDJKcGJHd3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pPQW9nSUNBZ0x5OGdkR2hwY3k1d1lYSjBhV05wY0dGdWRFTnZkVzUwTG5aaGJIVmxJRDBnZEdocGN5NXdZWEowYVdOcGNHRnVkRU52ZFc1MExuWmhiSFZsSUNzZ01Rb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6Y0d4cGRGOWlhV3hzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRJS0lDQWdJQzh2SUhCaGNuUnBZMmx3WVc1MFEyOTFiblFnUFNCSGJHOWlZV3hUZEdGMFpTaDdJR2x1YVhScFlXeFdZV3gxWlRvZ1ZXbHVkRFkwS0RBcElIMHBDaUFnSUNCaWVYUmxZeUEwSUM4dklDSndZWEowYVdOcGNHRnVkRU52ZFc1MElnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOd2JHbDBYMkpwYkd3dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek9Bb2dJQ0FnTHk4Z2RHaHBjeTV3WVhKMGFXTnBjR0Z1ZEVOdmRXNTBMblpoYkhWbElEMGdkR2hwY3k1d1lYSjBhV05wY0dGdWRFTnZkVzUwTG5aaGJIVmxJQ3NnTVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBckNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNCc2FYUmZZbWxzYkM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeUNpQWdJQ0F2THlCd1lYSjBhV05wY0dGdWRFTnZkVzUwSUQwZ1IyeHZZbUZzVTNSaGRHVW9leUJwYm1sMGFXRnNWbUZzZFdVNklGVnBiblEyTkNnd0tTQjlLUW9nSUNBZ1lubDBaV01nTkNBdkx5QWljR0Z5ZEdsamFYQmhiblJEYjNWdWRDSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emNHeHBkRjlpYVd4c0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16Z0tJQ0FnSUM4dklIUm9hWE11Y0dGeWRHbGphWEJoYm5SRGIzVnVkQzUyWVd4MVpTQTlJSFJvYVhNdWNHRnlkR2xqYVhCaGJuUkRiM1Z1ZEM1MllXeDFaU0FySURFS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNCc2FYUmZZbWxzYkM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJNENpQWdJQ0F2THlCd2RXSnNhV01nY21WbmFYTjBaWEpRWVhKMGFXTnBjR0Z1ZENod1lYSjBhV05wY0dGdWRFRmtaSEpsYzNNNklITjBjbWx1Wnl3Z2MyaGhjbVZDY0hNNklIVnBiblEyTkNrNklIWnZhV1FnZXdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpjR3hwZEY5aWFXeHNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPbE53YkdsMFFtbHNiQzVzYjJOclFtbHNiRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q214dlkydENhV3hzT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM053YkdsMFgySnBiR3d2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTWdvZ0lDQWdMeThnWVhOelpYSjBLQ0YwYUdsekxtbHpURzlqYTJWa0xuWmhiSFZsTENBblFtbHNiQ0JoYkhKbFlXUjVJR3h2WTJ0bFpDY3BDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOd2JHbDBYMkpwYkd3dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5Bb2dJQ0FnTHk4Z2FYTk1iMk5yWldRZ1BTQkhiRzlpWVd4VGRHRjBaU2g3SUdsdWFYUnBZV3hXWVd4MVpUb2dabUZzYzJVZ2ZTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltbHpURzlqYTJWa0lnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOd2JHbDBYMkpwYkd3dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME1nb2dJQ0FnTHk4Z1lYTnpaWEowS0NGMGFHbHpMbWx6VEc5amEyVmtMblpoYkhWbExDQW5RbWxzYkNCaGJISmxZV1I1SUd4dlkydGxaQ2NwQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUVKcGJHd2dZV3h5WldGa2VTQnNiMk5yWldRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6Y0d4cGRGOWlhV3hzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRNS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxuUnZkR0ZzVTJoaGNtVkNjSE11ZG1Gc2RXVWdQVDA5SURFd1h6QXdNQ3dnSjFSdmRHRnNJSE5vWVhKbGN5QnRkWE4wSUdWeGRXRnNJREV3TURBd0lHSndjeWNwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTndiR2wwWDJKcGJHd3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNUW9nSUNBZ0x5OGdkRzkwWVd4VGFHRnlaVUp3Y3lBOUlFZHNiMkpoYkZOMFlYUmxLSHNnYVc1cGRHbGhiRlpoYkhWbE9pQlZhVzUwTmpRb01Da2dmU2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJblJ2ZEdGc1UyaGhjbVZDY0hNaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNCc2FYUmZZbWxzYkM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRekNpQWdJQ0F2THlCaGMzTmxjblFvZEdocGN5NTBiM1JoYkZOb1lYSmxRbkJ6TG5aaGJIVmxJRDA5UFNBeE1GOHdNREFzSUNkVWIzUmhiQ0J6YUdGeVpYTWdiWFZ6ZENCbGNYVmhiQ0F4TURBd01DQmljSE1uS1FvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lIQjFjMmhwYm5RZ01UQXdNREFnTHk4Z01UQXdNREFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1ZHOTBZV3dnYzJoaGNtVnpJRzExYzNRZ1pYRjFZV3dnTVRBd01EQWdZbkJ6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM0JzYVhSZlltbHNiQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUwQ2lBZ0lDQXZMeUJwYzB4dlkydGxaQ0E5SUVkc2IySmhiRk4wWVhSbEtIc2dhVzVwZEdsaGJGWmhiSFZsT2lCbVlXeHpaU0I5S1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpYVhOTWIyTnJaV1FpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM0JzYVhSZlltbHNiQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalExQ2lBZ0lDQXZMeUIwYUdsekxtbHpURzlqYTJWa0xuWmhiSFZsSUQwZ2RISjFaUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzQnNhWFJmWW1sc2JDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUXhDaUFnSUNBdkx5QndkV0pzYVdNZ2JHOWphMEpwYkd3b0tUb2dkbTlwWkNCN0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM053YkdsMFgySnBiR3d2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VTNCc2FYUkNhV3hzTG5OMVltMXBkRkJoZVcxbGJuUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B6ZFdKdGFYUlFZWGx0Wlc1ME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOd2JHbDBYMkpwYkd3dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME9Bb2dJQ0FnTHk4Z2NIVmliR2xqSUhOMVltMXBkRkJoZVcxbGJuUW9jR0Z5ZEdsamFYQmhiblJCWkdSeVpYTnpPaUJ6ZEhKcGJtY3NJR0Z0YjNWdWRFRjBiMjFwWXpvZ2RXbHVkRFkwTENCd1lYbHRaVzUwVkhoSlpFaGhjMmc2SUhOMGNtbHVaeWs2SUhadmFXUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM0JzYVhSZlltbHNiQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalE1Q2lBZ0lDQXZMeUJoYzNObGNuUW9kR2hwY3k1cGMweHZZMnRsWkM1MllXeDFaU3dnSjBKcGJHd2diWFZ6ZENCaVpTQnNiMk5yWldRZ1ptbHljM1FuS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpjR3hwZEY5aWFXeHNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFFLSUNBZ0lDOHZJR2x6VEc5amEyVmtJRDBnUjJ4dlltRnNVM1JoZEdVb2V5QnBibWwwYVdGc1ZtRnNkV1U2SUdaaGJITmxJSDBwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0pwYzB4dlkydGxaQ0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpjR3hwZEY5aWFXeHNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORGtLSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG1selRHOWphMlZrTG5aaGJIVmxMQ0FuUW1sc2JDQnRkWE4wSUdKbElHeHZZMnRsWkNCbWFYSnpkQ2NwQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ1lYTnpaWEowSUM4dklFSnBiR3dnYlhWemRDQmlaU0JzYjJOclpXUWdabWx5YzNRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6Y0d4cGRGOWlhV3hzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRBS0lDQWdJQzh2SUdGemMyVnlkQ2doZEdocGN5NXBjMU5sZEhSc1pXUXVkbUZzZFdVc0lDZENhV3hzSUdGc2NtVmhaSGtnYzJWMGRHeGxaQ2NwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTndiR2wwWDJKcGJHd3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOUW9nSUNBZ0x5OGdhWE5UWlhSMGJHVmtJRDBnUjJ4dlltRnNVM1JoZEdVb2V5QnBibWwwYVdGc1ZtRnNkV1U2SUdaaGJITmxJSDBwQ2lBZ0lDQmllWFJsWTE4eklDOHZJQ0pwYzFObGRIUnNaV1FpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM0JzYVhSZlltbHNiQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalV3Q2lBZ0lDQXZMeUJoYzNObGNuUW9JWFJvYVhNdWFYTlRaWFIwYkdWa0xuWmhiSFZsTENBblFtbHNiQ0JoYkhKbFlXUjVJSE5sZEhSc1pXUW5LUW9nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJDYVd4c0lHRnNjbVZoWkhrZ2MyVjBkR3hsWkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM053YkdsMFgySnBiR3d2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xTWdvZ0lDQWdMeThnWTI5dWMzUWdjR0Z5ZEdsamFYQmhiblJUYUdGeVpTQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvZXlCclpYazZJR0J3WHlSN2NHRnlkR2xqYVhCaGJuUkJaR1J5WlhOemZXQWdmU2tLSUNBZ0lHSjVkR1ZqSURnZ0x5OGdJbkJmSWdvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpjR3hwZEY5aWFXeHNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVE1LSUNBZ0lDOHZJR0Z6YzJWeWRDaHdZWEowYVdOcGNHRnVkRk5vWVhKbExtaGhjMVpoYkhWbExDQW5VR0Z5ZEdsamFYQmhiblFnYVhNZ2JtOTBJSEpsWjJsemRHVnlaV1FuS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JpZFhKNUlERUtJQ0FnSUdGemMyVnlkQ0F2THlCUVlYSjBhV05wY0dGdWRDQnBjeUJ1YjNRZ2NtVm5hWE4wWlhKbFpBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOd2JHbDBYMkpwYkd3dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU5Rb2dJQ0FnTHk4Z1kyOXVjM1FnY0dGNWJXVnVkRkJ5YjI5bUlEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWg3SUd0bGVUb2dZSFI0WHlSN2NHRjViV1Z1ZEZSNFNXUklZWE5vZldBZ2ZTa0tJQ0FnSUhCMWMyaGllWFJsY3lBaWRIaGZJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM0JzYVhSZlltbHNiQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalUyQ2lBZ0lDQXZMeUJoYzNObGNuUW9JWEJoZVcxbGJuUlFjbTl2Wmk1b1lYTldZV3gxWlN3Z0owUjFjR3hwWTJGMFpTQndZWGx0Wlc1MElIQnliMjltSnlrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmthV2NnTVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdKMWNua2dNUW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUVSMWNHeHBZMkYwWlNCd1lYbHRaVzUwSUhCeWIyOW1DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzQnNhWFJmWW1sc2JDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVTRDaUFnSUNBdkx5QndZWGx0Wlc1MFVISnZiMll1ZG1Gc2RXVWdQU0F4Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpjR3hwZEY5aWFXeHNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVGtLSUNBZ0lDOHZJSFJvYVhNdWRHOTBZV3hRWVdsa1FYUnZiV2xqTG5aaGJIVmxJRDBnZEdocGN5NTBiM1JoYkZCaGFXUkJkRzl0YVdNdWRtRnNkV1VnS3lCaGJXOTFiblJCZEc5dGFXTUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNCc2FYUmZZbWxzYkM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFekNpQWdJQ0F2THlCMGIzUmhiRkJoYVdSQmRHOXRhV01nUFNCSGJHOWlZV3hUZEdGMFpTaDdJR2x1YVhScFlXeFdZV3gxWlRvZ1ZXbHVkRFkwS0RBcElIMHBDaUFnSUNCaWVYUmxZMTh5SUM4dklDSjBiM1JoYkZCaGFXUkJkRzl0YVdNaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNCc2FYUmZZbWxzYkM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVNUNpQWdJQ0F2THlCMGFHbHpMblJ2ZEdGc1VHRnBaRUYwYjIxcFl5NTJZV3gxWlNBOUlIUm9hWE11ZEc5MFlXeFFZV2xrUVhSdmJXbGpMblpoYkhWbElDc2dZVzF2ZFc1MFFYUnZiV2xqQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0t3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOd2JHbDBYMkpwYkd3dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE13b2dJQ0FnTHk4Z2RHOTBZV3hRWVdsa1FYUnZiV2xqSUQwZ1IyeHZZbUZzVTNSaGRHVW9leUJwYm1sMGFXRnNWbUZzZFdVNklGVnBiblEyTkNnd0tTQjlLUW9nSUNBZ1lubDBaV05mTWlBdkx5QWlkRzkwWVd4UVlXbGtRWFJ2Yldsaklnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOd2JHbDBYMkpwYkd3dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU9Rb2dJQ0FnTHk4Z2RHaHBjeTUwYjNSaGJGQmhhV1JCZEc5dGFXTXVkbUZzZFdVZ1BTQjBhR2x6TG5SdmRHRnNVR0ZwWkVGMGIyMXBZeTUyWVd4MVpTQXJJR0Z0YjNWdWRFRjBiMjFwWXdvZ0lDQWdaR2xuSURFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNCc2FYUmZZbWxzYkM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZeENpQWdJQ0F2THlCcFppQW9kR2hwY3k1MGIzUmhiRkJoYVdSQmRHOXRhV011ZG1Gc2RXVWdQVDA5SUhSb2FYTXVkRzkwWVd4QmRHOXRhV011ZG1Gc2RXVXBJSHNLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzQnNhWFJmWW1sc2JDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qa0tJQ0FnSUM4dklIUnZkR0ZzUVhSdmJXbGpJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGlncENpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKMGIzUmhiRUYwYjIxcFl5SUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emNHeHBkRjlpYVd4c0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5qRUtJQ0FnSUM4dklHbG1JQ2gwYUdsekxuUnZkR0ZzVUdGcFpFRjBiMjFwWXk1MllXeDFaU0E5UFQwZ2RHaHBjeTUwYjNSaGJFRjBiMjFwWXk1MllXeDFaU2tnZXdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lEMDlDaUFnSUNCaWVpQnpkV0p0YVhSUVlYbHRaVzUwWDJGbWRHVnlYMmxtWDJWc2MyVkFNd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTndiR2wwWDJKcGJHd3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOUW9nSUNBZ0x5OGdhWE5UWlhSMGJHVmtJRDBnUjJ4dlltRnNVM1JoZEdVb2V5QnBibWwwYVdGc1ZtRnNkV1U2SUdaaGJITmxJSDBwQ2lBZ0lDQmllWFJsWTE4eklDOHZJQ0pwYzFObGRIUnNaV1FpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM0JzYVhSZlltbHNiQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPall5Q2lBZ0lDQXZMeUIwYUdsekxtbHpVMlYwZEd4bFpDNTJZV3gxWlNBOUlIUnlkV1VLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9LYzNWaWJXbDBVR0Y1YldWdWRGOWhablJsY2w5cFpsOWxiSE5sUURNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNCc2FYUmZZbWxzYkM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRNENpQWdJQ0F2THlCd2RXSnNhV01nYzNWaWJXbDBVR0Y1YldWdWRDaHdZWEowYVdOcGNHRnVkRUZrWkhKbGMzTTZJSE4wY21sdVp5d2dZVzF2ZFc1MFFYUnZiV2xqT2lCMWFXNTBOalFzSUhCaGVXMWxiblJVZUVsa1NHRnphRG9nYzNSeWFXNW5LVG9nZG05cFpDQjdDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOd2JHbDBYMkpwYkd3dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlUzQnNhWFJDYVd4c0xtMWhjbXRUWlhSMGJHVmtXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYldGeWExTmxkSFJzWldRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNCc2FYUmZZbWxzYkM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZM0NpQWdJQ0F2THlCaGMzTmxjblFvZEdocGN5NTBiM1JoYkZCaGFXUkJkRzl0YVdNdWRtRnNkV1VnUFQwOUlIUm9hWE11ZEc5MFlXeEJkRzl0YVdNdWRtRnNkV1VzSUNkRFlXNXViM1FnYzJWMGRHeGxJR0psWm05eVpTQm1kV3hzSUhCaGVXMWxiblFuS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpjR3hwZEY5aWFXeHNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVE1LSUNBZ0lDOHZJSFJ2ZEdGc1VHRnBaRUYwYjIxcFl5QTlJRWRzYjJKaGJGTjBZWFJsS0hzZ2FXNXBkR2xoYkZaaGJIVmxPaUJWYVc1ME5qUW9NQ2tnZlNrS0lDQWdJR0o1ZEdWalh6SWdMeThnSW5SdmRHRnNVR0ZwWkVGMGIyMXBZeUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpjR3hwZEY5aWFXeHNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOamNLSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG5SdmRHRnNVR0ZwWkVGMGIyMXBZeTUyWVd4MVpTQTlQVDBnZEdocGN5NTBiM1JoYkVGMGIyMXBZeTUyWVd4MVpTd2dKME5oYm01dmRDQnpaWFIwYkdVZ1ltVm1iM0psSUdaMWJHd2djR0Y1YldWdWRDY3BDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6Y0d4cGRGOWlhV3hzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T1FvZ0lDQWdMeThnZEc5MFlXeEJkRzl0YVdNZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLQ2tLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdJblJ2ZEdGc1FYUnZiV2xqSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM053YkdsMFgySnBiR3d2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTndvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdWRHOTBZV3hRWVdsa1FYUnZiV2xqTG5aaGJIVmxJRDA5UFNCMGFHbHpMblJ2ZEdGc1FYUnZiV2xqTG5aaGJIVmxMQ0FuUTJGdWJtOTBJSE5sZEhSc1pTQmlaV1p2Y21VZ1puVnNiQ0J3WVhsdFpXNTBKeWtLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUVOaGJtNXZkQ0J6WlhSMGJHVWdZbVZtYjNKbElHWjFiR3dnY0dGNWJXVnVkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTndiR2wwWDJKcGJHd3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOUW9nSUNBZ0x5OGdhWE5UWlhSMGJHVmtJRDBnUjJ4dlltRnNVM1JoZEdVb2V5QnBibWwwYVdGc1ZtRnNkV1U2SUdaaGJITmxJSDBwQ2lBZ0lDQmllWFJsWTE4eklDOHZJQ0pwYzFObGRIUnNaV1FpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM0JzYVhSZlltbHNiQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalk0Q2lBZ0lDQXZMeUIwYUdsekxtbHpVMlYwZEd4bFpDNTJZV3gxWlNBOUlIUnlkV1VLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTndiR2wwWDJKcGJHd3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJOZ29nSUNBZ0x5OGdjSFZpYkdsaklHMWhjbXRUWlhSMGJHVmtLQ2s2SUhadmFXUWdld29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emNHeHBkRjlpYVd4c0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9sTndiR2wwUW1sc2JDNW5aWFJUZEdGMGRYTmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BuWlhSVGRHRjBkWE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM0JzYVhSZlltbHNiQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamN6Q2lBZ0lDQXZMeUIwYUdsekxtbHpURzlqYTJWa0xuWmhiSFZsTEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpjR3hwZEY5aWFXeHNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFFLSUNBZ0lDOHZJR2x6VEc5amEyVmtJRDBnUjJ4dlltRnNVM1JoZEdVb2V5QnBibWwwYVdGc1ZtRnNkV1U2SUdaaGJITmxJSDBwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0pwYzB4dlkydGxaQ0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpjR3hwZEY5aWFXeHNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOek1LSUNBZ0lDOHZJSFJvYVhNdWFYTk1iMk5yWldRdWRtRnNkV1VzQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTndiR2wwWDJKcGJHd3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNOQW9nSUNBZ0x5OGdkR2hwY3k1cGMxTmxkSFJzWldRdWRtRnNkV1VzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTndiR2wwWDJKcGJHd3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOUW9nSUNBZ0x5OGdhWE5UWlhSMGJHVmtJRDBnUjJ4dlltRnNVM1JoZEdVb2V5QnBibWwwYVdGc1ZtRnNkV1U2SUdaaGJITmxJSDBwQ2lBZ0lDQmllWFJsWTE4eklDOHZJQ0pwYzFObGRIUnNaV1FpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM0JzYVhSZlltbHNiQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamMwQ2lBZ0lDQXZMeUIwYUdsekxtbHpVMlYwZEd4bFpDNTJZV3gxWlN3S0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM0JzYVhSZlltbHNiQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamMxQ2lBZ0lDQXZMeUIwYUdsekxuUnZkR0ZzUVhSdmJXbGpMblpoYkhWbExBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6Y0d4cGRGOWlhV3hzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T1FvZ0lDQWdMeThnZEc5MFlXeEJkRzl0YVdNZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLQ2tLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdJblJ2ZEdGc1FYUnZiV2xqSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM053YkdsMFgySnBiR3d2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zTlFvZ0lDQWdMeThnZEdocGN5NTBiM1JoYkVGMGIyMXBZeTUyWVd4MVpTd0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNCc2FYUmZZbWxzYkM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pjMkNpQWdJQ0F2THlCMGFHbHpMblJ2ZEdGc1VHRnBaRUYwYjIxcFl5NTJZV3gxWlN3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM0JzYVhSZlltbHNiQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV6Q2lBZ0lDQXZMeUIwYjNSaGJGQmhhV1JCZEc5dGFXTWdQU0JIYkc5aVlXeFRkR0YwWlNoN0lHbHVhWFJwWVd4V1lXeDFaVG9nVldsdWREWTBLREFwSUgwcENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKMGIzUmhiRkJoYVdSQmRHOXRhV01pQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM0JzYVhSZlltbHNiQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamMyQ2lBZ0lDQXZMeUIwYUdsekxuUnZkR0ZzVUdGcFpFRjBiMjFwWXk1MllXeDFaU3dLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzQnNhWFJmWW1sc2JDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qYzNDaUFnSUNBdkx5QjBhR2x6TG5SdmRHRnNVMmhoY21WQ2NITXVkbUZzZFdVc0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM053YkdsMFgySnBiR3d2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TVFvZ0lDQWdMeThnZEc5MFlXeFRhR0Z5WlVKd2N5QTlJRWRzYjJKaGJGTjBZWFJsS0hzZ2FXNXBkR2xoYkZaaGJIVmxPaUJWYVc1ME5qUW9NQ2tnZlNrS0lDQWdJR0o1ZEdWalh6RWdMeThnSW5SdmRHRnNVMmhoY21WQ2NITWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzQnNhWFJmWW1sc2JDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qYzNDaUFnSUNBdkx5QjBhR2x6TG5SdmRHRnNVMmhoY21WQ2NITXVkbUZzZFdVc0NpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM053YkdsMFgySnBiR3d2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zTWkwM09Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUZzS0lDQWdJQzh2SUNBZ2RHaHBjeTVwYzB4dlkydGxaQzUyWVd4MVpTd0tJQ0FnSUM4dklDQWdkR2hwY3k1cGMxTmxkSFJzWldRdWRtRnNkV1VzQ2lBZ0lDQXZMeUFnSUhSb2FYTXVkRzkwWVd4QmRHOXRhV011ZG1Gc2RXVXNDaUFnSUNBdkx5QWdJSFJvYVhNdWRHOTBZV3hRWVdsa1FYUnZiV2xqTG5aaGJIVmxMQW9nSUNBZ0x5OGdJQ0IwYUdsekxuUnZkR0ZzVTJoaGNtVkNjSE11ZG1Gc2RXVXNDaUFnSUNBdkx5QmRDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTmdvZ0lDQWdjMlYwWW1sMENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNCelpYUmlhWFFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzQnNhWFJmWW1sc2JDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qY3hDaUFnSUNBdkx5QndkV0pzYVdNZ1oyVjBVM1JoZEhWektDazZJRnRpYjI5c1pXRnVMQ0JpYjI5c1pXRnVMQ0IxYVc1ME5qUXNJSFZwYm5RMk5Dd2dkV2x1ZERZMFhTQjdDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBQUVDQ0NZSkNHbHpURzlqYTJWa0RYUnZkR0ZzVTJoaGNtVkNjSE1QZEc5MFlXeFFZV2xrUVhSdmJXbGpDV2x6VTJWMGRHeGxaQkJ3WVhKMGFXTnBjR0Z1ZEVOdmRXNTBDM1J2ZEdGc1FYUnZiV2xqQjJGemMyVjBTV1FLWW1sc2JFbGtTR0Z6YUFKd1h6RVlRQUFVSndZaVp5a2laeWNFSW1jcUltY29JbWNySW1jeEcwRUFPVEVaRkVReEdFU0NCZ1Qra0NBakJEZ1VjUUFFTWp4aTl3U2V2dHd4Qk95cC9OOEV0MmFTSERZYUFJNEdBQXNBZndET0FPSUJTUUZaQURFWkZERVlGQkJFSTBNMkdnRkpJbGtrQ0VzQkZSSkVWd0lBTmhvQ1NTSlpKQWhMQVJVU1JGY0NBRFlhQTBrVkpSSkVGellhQkVrVkpSSkVGellhQlVrVkpSSkVGeUluQjJWRkFSUkVTd0ZFSndkUEJXZUFESEJoZVdWeVFXUmtjbVZ6YzA4RVp5Y0dUd05uSndWUEFtZUFDR1JsWVdSc2FXNWxUR2NqUXpZYUFVa2lXU1FJU3dFVkVrUlhBZ0EyR2dKSkZTVVNSQmNpS0dWRUZFUkpSQ0luQkdWRWdSUU1SQ2NJVHdKUUlrc0JaVVVCRkVSTEFXY2lLV1ZFQ0NsTVp5SW5CR1ZFSXdnbkJFeG5JME1pS0dWRUZFUWlLV1ZFZ1pCT0VrUW9JMmNqUXpZYUFVa2lXU1FJU3dFVkVrUlhBZ0EyR2dKSkZTVVNSQmMyR2dOSklsa2tDRXNCRlJKRVZ3SUFJaWhsUkVRaUsyVkVGRVFuQ0U4RFVDSk1aVVVCUklBRGRIaGZURkFpU3dGbFJRRVVSQ05uSWlwbFJBZ3FTd0ZuSWljRlpVUVNRUUFES3lObkkwTWlLbVZFSWljRlpVUVNSQ3NqWnlORElpaGxSQ0lyWlVRaUp3VmxSQ0lxWlVRaUtXVkVnQUVBSWs4R1ZDTlBCVlJQQXhaUVR3SVdVRXdXVUlBRUZSOThkVXhRc0NORCIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjMsInBhdGNoIjoyLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
