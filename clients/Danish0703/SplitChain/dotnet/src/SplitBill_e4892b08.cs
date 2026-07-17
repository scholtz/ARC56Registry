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

namespace Arc56.Generated.Danish0703.SplitChain.SplitBill_e4892b08
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU3BsaXRCaWxsIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkdldFN0YXR1c1JldHVybiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJib29sIn0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJmaWVsZDIiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQzIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkNCIsInR5cGUiOiJ1aW50NjQifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlQmlsbCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiaWxsSWRIYXNoIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXllckFkZHJlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0SWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvdGFsQXRvbWljIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkZWFkbGluZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWdpc3RlclBhcnRpY2lwYW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBhcnRpY2lwYW50QWRkcmVzcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic2hhcmVCcHMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibG9ja0JpbGwiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic3VibWl0UGF5bWVudCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXJ0aWNpcGFudEFkZHJlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudEF0b21pYyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5bWVudFR4SWRIYXNoIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im1hcmtTZXR0bGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFN0YXR1cyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiIoYm9vbCxib29sLHVpbnQ2NCx1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IkdldFN0YXR1c1JldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjo2MiwiYnl0ZXMiOjJ9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzI3Ml0sImVycm9yTWVzc2FnZSI6IkJpbGwgYWxyZWFkeSBpbml0aWFsaXplZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM1Miw0MDZdLCJlcnJvck1lc3NhZ2UiOiJCaWxsIGFscmVhZHkgbG9ja2VkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDcyXSwiZXJyb3JNZXNzYWdlIjoiQmlsbCBhbHJlYWR5IHNldHRsZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NjZdLCJlcnJvck1lc3NhZ2UiOiJCaWxsIG11c3QgYmUgbG9ja2VkIGZpcnN0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTM0XSwiZXJyb3JNZXNzYWdlIjoiQ2Fubm90IHNldHRsZSBiZWZvcmUgZnVsbCBwYXltZW50IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDk4XSwiZXJyb3JNZXNzYWdlIjoiRHVwbGljYXRlIHBheW1lbnQgcHJvb2YiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDJdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjAzXSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgTm9PcCAmJiBjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNzZdLCJlcnJvck1lc3NhZ2UiOiJQYXJ0aWNpcGFudCBhbHJlYWR5IHJlZ2lzdGVyZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNjNdLCJlcnJvck1lc3NhZ2UiOiJQYXJ0aWNpcGFudCBjYXAgcmVhY2hlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ4M10sImVycm9yTWVzc2FnZSI6IlBhcnRpY2lwYW50IGlzIG5vdCByZWdpc3RlcmVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzU0XSwiZXJyb3JNZXNzYWdlIjoiU2hhcmUgbXVzdCBiZSBwb3NpdGl2ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI3NV0sImVycm9yTWVzc2FnZSI6IlRvdGFsIGFtb3VudCBtdXN0IGJlID4gMCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQxNV0sImVycm9yTWVzc2FnZSI6IlRvdGFsIHNoYXJlcyBtdXN0IGVxdWFsIDEwMDAwIGJwcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM1MCwzNTksMzgzLDM5Miw0MDQsNDEwLDQ2NSw0NzAsNTA0LDUxNCw1MjcsNTMyLDU0Myw1NDcsNTUyLDU1Niw1NjBdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBHbG9iYWxTdGF0ZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMTEsMjI3LDMyNyw0MjYsNDUxXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjE4LDIzNCwzMzQsNDMzLDQ1OF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNDUsMjU0LDI2MywzNDUsNDQ0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNQ0F4SURJZ09Bb2dJQ0FnWW5sMFpXTmliRzlqYXlBaWFYTk1iMk5yWldRaUlDSjBiM1JoYkZOb1lYSmxRbkJ6SWlBaWRHOTBZV3hRWVdsa1FYUnZiV2xqSWlBaWFYTlRaWFIwYkdWa0lpQWljR0Z5ZEdsamFYQmhiblJEYjNWdWRDSWdJblJ2ZEdGc1FYUnZiV2xqSWlBaVlYTnpaWFJKWkNJZ0ltSnBiR3hKWkVoaGMyZ2lJQ0p3WHlJS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWJub2diV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpjR3hwZEY5aWFXeHNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPQW9nSUNBZ0x5OGdZWE56WlhSSlpDQTlJRWRzYjJKaGJGTjBZWFJsS0hzZ2FXNXBkR2xoYkZaaGJIVmxPaUJWYVc1ME5qUW9NQ2tnZlNrS0lDQWdJR0o1ZEdWaklEWWdMeThnSW1GemMyVjBTV1FpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpjR3hwZEY5aWFXeHNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEVLSUNBZ0lDOHZJSFJ2ZEdGc1UyaGhjbVZDY0hNZ1BTQkhiRzlpWVd4VGRHRjBaU2g3SUdsdWFYUnBZV3hXWVd4MVpUb2dWV2x1ZERZMEtEQXBJSDBwQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0owYjNSaGJGTm9ZWEpsUW5Ceklnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNCc2FYUmZZbWxzYkM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeUNpQWdJQ0F2THlCd1lYSjBhV05wY0dGdWRFTnZkVzUwSUQwZ1IyeHZZbUZzVTNSaGRHVW9leUJwYm1sMGFXRnNWbUZzZFdVNklGVnBiblEyTkNnd0tTQjlLUW9nSUNBZ1lubDBaV01nTkNBdkx5QWljR0Z5ZEdsamFYQmhiblJEYjNWdWRDSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOd2JHbDBYMkpwYkd3dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE13b2dJQ0FnTHk4Z2RHOTBZV3hRWVdsa1FYUnZiV2xqSUQwZ1IyeHZZbUZzVTNSaGRHVW9leUJwYm1sMGFXRnNWbUZzZFdVNklGVnBiblEyTkNnd0tTQjlLUW9nSUNBZ1lubDBaV05mTWlBdkx5QWlkRzkwWVd4UVlXbGtRWFJ2Yldsaklnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNCc2FYUmZZbWxzYkM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMENpQWdJQ0F2THlCcGMweHZZMnRsWkNBOUlFZHNiMkpoYkZOMFlYUmxLSHNnYVc1cGRHbGhiRlpoYkhWbE9pQm1ZV3h6WlNCOUtRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWFYTk1iMk5yWldRaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6Y0d4cGRGOWlhV3hzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRVS0lDQWdJQzh2SUdselUyVjBkR3hsWkNBOUlFZHNiMkpoYkZOMFlYUmxLSHNnYVc1cGRHbGhiRlpoYkhWbE9pQm1ZV3h6WlNCOUtRb2dJQ0FnWW5sMFpXTmZNeUF2THlBaWFYTlRaWFIwYkdWa0lnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENncHRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpjR3hwZEY5aWFXeHNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOQzAxQ2lBZ0lDQXZMeUJBWTI5dWRISmhZM1FvZXlCemRHRjBaVlJ2ZEdGc2N6b2dleUJuYkc5aVlXeFZhVzUwY3pvZ05qSXNJR2RzYjJKaGJFSjVkR1Z6T2lBeUlIMGdmU2tLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCVGNHeHBkRUpwYkd3Z1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnWW5vZ2JXRnBibDlmWDJGc1oyOTBjMTlmTG1SbFptRjFiSFJEY21WaGRHVkFNVFVLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYlhWemRDQmlaU0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQndkWE5vWW5sMFpYTnpJREI0Wm1VNU1ESXdNak1nTUhnek9ERTBOekV3TUNBd2VETXlNMk0yTW1ZM0lEQjRPV1ZpWldSak16RWdNSGhsWTJFNVptTmtaaUF3ZUdJM05qWTVNakZqSUM4dklHMWxkR2h2WkNBaVkzSmxZWFJsUW1sc2JDaHpkSEpwYm1jc2MzUnlhVzVuTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW5KbFoybHpkR1Z5VUdGeWRHbGphWEJoYm5Rb2MzUnlhVzVuTEhWcGJuUTJOQ2wyYjJsa0lpd2diV1YwYUc5a0lDSnNiMk5yUW1sc2JDZ3BkbTlwWkNJc0lHMWxkR2h2WkNBaWMzVmliV2wwVUdGNWJXVnVkQ2h6ZEhKcGJtY3NkV2x1ZERZMExITjBjbWx1WnlsMmIybGtJaXdnYldWMGFHOWtJQ0p0WVhKclUyVjBkR3hsWkNncGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWjJWMFUzUmhkSFZ6S0Nrb1ltOXZiQ3hpYjI5c0xIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBLU0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUdOeVpXRjBaVUpwYkd3Z2NtVm5hWE4wWlhKUVlYSjBhV05wY0dGdWRDQnNiMk5yUW1sc2JDQnpkV0p0YVhSUVlYbHRaVzUwSUcxaGNtdFRaWFIwYkdWa0lHZGxkRk4wWVhSMWN3b2dJQ0FnWlhKeUNncHRZV2x1WDE5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaVUF4TlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6Y0d4cGRGOWlhV3hzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkMwMUNpQWdJQ0F2THlCQVkyOXVkSEpoWTNRb2V5QnpkR0YwWlZSdmRHRnNjem9nZXlCbmJHOWlZV3hWYVc1MGN6b2dOaklzSUdkc2IySmhiRUo1ZEdWek9pQXlJSDBnZlNrS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QlRjR3hwZEVKcGJHd2daWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdJUW9nSUNBZ0ppWUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdiWFZ6ZENCaVpTQk9iMDl3SUNZbUlHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQmpjbVZoZEdsdVp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6Y0d4cGRGOWlhV3hzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2xOd2JHbDBRbWxzYkM1amNtVmhkR1ZDYVd4c1czSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZM0psWVhSbFFtbHNiRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpjR3hwZEY5aWFXeHNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGNLSUNBZ0lDOHZJSEIxWW14cFl5QmpjbVZoZEdWQ2FXeHNLR0pwYkd4SlpFaGhjMmc2SUhOMGNtbHVaeXdnY0dGNVpYSkJaR1J5WlhOek9pQnpkSEpwYm1jc0lHRnpjMlYwU1dRNklIVnBiblEyTkN3Z2RHOTBZV3hCZEc5dGFXTTZJSFZwYm5RMk5Dd2daR1ZoWkd4cGJtVTZJSFZwYm5RMk5DazZJSFp2YVdRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUExQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNCc2FYUmZZbWxzYkM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFNENpQWdJQ0F2THlCaGMzTmxjblFvSVhSb2FYTXVZbWxzYkVsa1NHRnphQzVvWVhOV1lXeDFaU3dnSjBKcGJHd2dZV3h5WldGa2VTQnBibWwwYVdGc2FYcGxaQ2NwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTndiR2wwWDJKcGJHd3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJDaUFnSUNBdkx5QmlhV3hzU1dSSVlYTm9JRDBnUjJ4dlltRnNVM1JoZEdVOGMzUnlhVzVuUGlncENpQWdJQ0JpZVhSbFl5QTNJQzh2SUNKaWFXeHNTV1JJWVhOb0lnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOd2JHbDBYMkpwYkd3dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE9Bb2dJQ0FnTHk4Z1lYTnpaWEowS0NGMGFHbHpMbUpwYkd4SlpFaGhjMmd1YUdGelZtRnNkV1VzSUNkQ2FXeHNJR0ZzY21WaFpIa2dhVzVwZEdsaGJHbDZaV1FuS1FvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdKMWNua2dNUW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUVKcGJHd2dZV3h5WldGa2VTQnBibWwwYVdGc2FYcGxaQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTndiR2wwWDJKcGJHd3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hPUW9nSUNBZ0x5OGdZWE56WlhKMEtIUnZkR0ZzUVhSdmJXbGpJRDRnTUN3Z0oxUnZkR0ZzSUdGdGIzVnVkQ0J0ZFhOMElHSmxJRDRnTUNjcENpQWdJQ0JrYVdjZ01Rb2dJQ0FnWVhOelpYSjBJQzh2SUZSdmRHRnNJR0Z0YjNWdWRDQnRkWE4wSUdKbElENGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTndiR2wwWDJKcGJHd3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJDaUFnSUNBdkx5QmlhV3hzU1dSSVlYTm9JRDBnUjJ4dlltRnNVM1JoZEdVOGMzUnlhVzVuUGlncENpQWdJQ0JpZVhSbFl5QTNJQzh2SUNKaWFXeHNTV1JJWVhOb0lnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOd2JHbDBYMkpwYkd3dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU1Rb2dJQ0FnTHk4Z2RHaHBjeTVpYVd4c1NXUklZWE5vTG5aaGJIVmxJRDBnWW1sc2JFbGtTR0Z6YUFvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTndiR2wwWDJKcGJHd3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNDaUFnSUNBdkx5QndZWGxsY2tGa1pISmxjM01nUFNCSGJHOWlZV3hUZEdGMFpUeHpkSEpwYm1jK0tDa0tJQ0FnSUhCMWMyaGllWFJsY3lBaWNHRjVaWEpCWkdSeVpYTnpJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTndiR2wwWDJKcGJHd3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNZ29nSUNBZ0x5OGdkR2hwY3k1d1lYbGxja0ZrWkhKbGMzTXVkbUZzZFdVZ1BTQndZWGxsY2tGa1pISmxjM01LSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emNHeHBkRjlpYVd4c0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9Bb2dJQ0FnTHk4Z1lYTnpaWFJKWkNBOUlFZHNiMkpoYkZOMFlYUmxLSHNnYVc1cGRHbGhiRlpoYkhWbE9pQlZhVzUwTmpRb01Da2dmU2tLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdJbUZ6YzJWMFNXUWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzQnNhWFJmWW1sc2JDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSXpDaUFnSUNBdkx5QjBhR2x6TG1GemMyVjBTV1F1ZG1Gc2RXVWdQU0JoYzNObGRFbGtDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNCc2FYUmZZbWxzYkM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2prS0lDQWdJQzh2SUhSdmRHRnNRWFJ2YldsaklEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWdwQ2lBZ0lDQmllWFJsWXlBMUlDOHZJQ0owYjNSaGJFRjBiMjFwWXlJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6Y0d4cGRGOWlhV3hzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpRS0lDQWdJQzh2SUhSb2FYTXVkRzkwWVd4QmRHOXRhV011ZG1Gc2RXVWdQU0IwYjNSaGJFRjBiMjFwWXdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTndiR2wwWDJKcGJHd3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNQW9nSUNBZ0x5OGdaR1ZoWkd4cGJtVWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0NrS0lDQWdJSEIxYzJoaWVYUmxjeUFpWkdWaFpHeHBibVVpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM0JzYVhSZlltbHNiQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakkxQ2lBZ0lDQXZMeUIwYUdsekxtUmxZV1JzYVc1bExuWmhiSFZsSUQwZ1pHVmhaR3hwYm1VS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNCc2FYUmZZbWxzYkM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFM0NpQWdJQ0F2THlCd2RXSnNhV01nWTNKbFlYUmxRbWxzYkNoaWFXeHNTV1JJWVhOb09pQnpkSEpwYm1jc0lIQmhlV1Z5UVdSa2NtVnpjem9nYzNSeWFXNW5MQ0JoYzNObGRFbGtPaUIxYVc1ME5qUXNJSFJ2ZEdGc1FYUnZiV2xqT2lCMWFXNTBOalFzSUdSbFlXUnNhVzVsT2lCMWFXNTBOalFwT2lCMmIybGtJSHNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzQnNhWFJmWW1sc2JDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcFRjR3hwZEVKcGJHd3VjbVZuYVhOMFpYSlFZWEowYVdOcGNHRnVkRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25KbFoybHpkR1Z5VUdGeWRHbGphWEJoYm5RNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNCc2FYUmZZbWxzYkM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJNENpQWdJQ0F2THlCd2RXSnNhV01nY21WbmFYTjBaWEpRWVhKMGFXTnBjR0Z1ZENod1lYSjBhV05wY0dGdWRFRmtaSEpsYzNNNklITjBjbWx1Wnl3Z2MyaGhjbVZDY0hNNklIVnBiblEyTkNrNklIWnZhV1FnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpjR3hwZEY5aWFXeHNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNamtLSUNBZ0lDOHZJR0Z6YzJWeWRDZ2hkR2hwY3k1cGMweHZZMnRsWkM1MllXeDFaU3dnSjBKcGJHd2dZV3h5WldGa2VTQnNiMk5yWldRbktRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6Y0d4cGRGOWlhV3hzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRRS0lDQWdJQzh2SUdselRHOWphMlZrSUQwZ1IyeHZZbUZzVTNSaGRHVW9leUJwYm1sMGFXRnNWbUZzZFdVNklHWmhiSE5sSUgwcENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKcGMweHZZMnRsWkNJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6Y0d4cGRGOWlhV3hzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWprS0lDQWdJQzh2SUdGemMyVnlkQ2doZEdocGN5NXBjMHh2WTJ0bFpDNTJZV3gxWlN3Z0owSnBiR3dnWVd4eVpXRmtlU0JzYjJOclpXUW5LUW9nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJDYVd4c0lHRnNjbVZoWkhrZ2JHOWphMlZrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM0JzYVhSZlltbHNiQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak13Q2lBZ0lDQXZMeUJoYzNObGNuUW9jMmhoY21WQ2NITWdQaUF3TENBblUyaGhjbVVnYlhWemRDQmlaU0J3YjNOcGRHbDJaU2NwQ2lBZ0lDQmtkWEFLSUNBZ0lHRnpjMlZ5ZENBdkx5QlRhR0Z5WlNCdGRYTjBJR0psSUhCdmMybDBhWFpsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM0JzYVhSZlltbHNiQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak14Q2lBZ0lDQXZMeUJoYzNObGNuUW9kR2hwY3k1d1lYSjBhV05wY0dGdWRFTnZkVzUwTG5aaGJIVmxJRHdnTWpBc0lDZFFZWEowYVdOcGNHRnVkQ0JqWVhBZ2NtVmhZMmhsWkNjcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM053YkdsMFgySnBiR3d2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TWdvZ0lDQWdMeThnY0dGeWRHbGphWEJoYm5SRGIzVnVkQ0E5SUVkc2IySmhiRk4wWVhSbEtIc2dhVzVwZEdsaGJGWmhiSFZsT2lCVmFXNTBOalFvTUNrZ2ZTa0tJQ0FnSUdKNWRHVmpJRFFnTHk4Z0luQmhjblJwWTJsd1lXNTBRMjkxYm5RaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNCc2FYUmZZbWxzYkM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNeENpQWdJQ0F2THlCaGMzTmxjblFvZEdocGN5NXdZWEowYVdOcGNHRnVkRU52ZFc1MExuWmhiSFZsSUR3Z01qQXNJQ2RRWVhKMGFXTnBjR0Z1ZENCallYQWdjbVZoWTJobFpDY3BDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnY0hWemFHbHVkQ0F5TUNBdkx5QXlNQW9nSUNBZ1BBb2dJQ0FnWVhOelpYSjBJQzh2SUZCaGNuUnBZMmx3WVc1MElHTmhjQ0J5WldGamFHVmtDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzQnNhWFJmWW1sc2JDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTXpDaUFnSUNBdkx5QmpiMjV6ZENCd1lYSjBhV05wY0dGdWRGTm9ZWEpsSUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpaDdJR3RsZVRvZ1lIQmZKSHR3WVhKMGFXTnBjR0Z1ZEVGa1pISmxjM045WUNCOUtRb2dJQ0FnWW5sMFpXTWdPQ0F2THlBaWNGOGlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOd2JHbDBYMkpwYkd3dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek5Bb2dJQ0FnTHk4Z1lYTnpaWEowS0NGd1lYSjBhV05wY0dGdWRGTm9ZWEpsTG1oaGMxWmhiSFZsTENBblVHRnlkR2xqYVhCaGJuUWdZV3h5WldGa2VTQnlaV2RwYzNSbGNtVmtKeWtLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCa2FXY2dNUW9nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0oxY25rZ01Rb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRkJoY25ScFkybHdZVzUwSUdGc2NtVmhaSGtnY21WbmFYTjBaWEpsWkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM053YkdsMFgySnBiR3d2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TmdvZ0lDQWdMeThnY0dGeWRHbGphWEJoYm5SVGFHRnlaUzUyWVd4MVpTQTlJSE5vWVhKbFFuQnpDaUFnSUNCa2FXY2dNUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpjR3hwZEY5aWFXeHNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNemNLSUNBZ0lDOHZJSFJvYVhNdWRHOTBZV3hUYUdGeVpVSndjeTUyWVd4MVpTQTlJSFJvYVhNdWRHOTBZV3hUYUdGeVpVSndjeTUyWVd4MVpTQXJJSE5vWVhKbFFuQnpDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOd2JHbDBYMkpwYkd3dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1Rb2dJQ0FnTHk4Z2RHOTBZV3hUYUdGeVpVSndjeUE5SUVkc2IySmhiRk4wWVhSbEtIc2dhVzVwZEdsaGJGWmhiSFZsT2lCVmFXNTBOalFvTUNrZ2ZTa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0luUnZkR0ZzVTJoaGNtVkNjSE1pQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM0JzYVhSZlltbHNiQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak0zQ2lBZ0lDQXZMeUIwYUdsekxuUnZkR0ZzVTJoaGNtVkNjSE11ZG1Gc2RXVWdQU0IwYUdsekxuUnZkR0ZzVTJoaGNtVkNjSE11ZG1Gc2RXVWdLeUJ6YUdGeVpVSndjd29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUNzS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6Y0d4cGRGOWlhV3hzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRFS0lDQWdJQzh2SUhSdmRHRnNVMmhoY21WQ2NITWdQU0JIYkc5aVlXeFRkR0YwWlNoN0lHbHVhWFJwWVd4V1lXeDFaVG9nVldsdWREWTBLREFwSUgwcENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKMGIzUmhiRk5vWVhKbFFuQnpJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTndiR2wwWDJKcGJHd3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pOd29nSUNBZ0x5OGdkR2hwY3k1MGIzUmhiRk5vWVhKbFFuQnpMblpoYkhWbElEMGdkR2hwY3k1MGIzUmhiRk5vWVhKbFFuQnpMblpoYkhWbElDc2djMmhoY21WQ2NITUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzQnNhWFJmWW1sc2JDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTRDaUFnSUNBdkx5QjBhR2x6TG5CaGNuUnBZMmx3WVc1MFEyOTFiblF1ZG1Gc2RXVWdQU0IwYUdsekxuQmhjblJwWTJsd1lXNTBRMjkxYm5RdWRtRnNkV1VnS3lBeENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM053YkdsMFgySnBiR3d2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TWdvZ0lDQWdMeThnY0dGeWRHbGphWEJoYm5SRGIzVnVkQ0E5SUVkc2IySmhiRk4wWVhSbEtIc2dhVzVwZEdsaGJGWmhiSFZsT2lCVmFXNTBOalFvTUNrZ2ZTa0tJQ0FnSUdKNWRHVmpJRFFnTHk4Z0luQmhjblJwWTJsd1lXNTBRMjkxYm5RaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNCc2FYUmZZbWxzYkM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNNENpQWdJQ0F2THlCMGFHbHpMbkJoY25ScFkybHdZVzUwUTI5MWJuUXVkbUZzZFdVZ1BTQjBhR2x6TG5CaGNuUnBZMmx3WVc1MFEyOTFiblF1ZG1Gc2RXVWdLeUF4Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUNzS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6Y0d4cGRGOWlhV3hzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRJS0lDQWdJQzh2SUhCaGNuUnBZMmx3WVc1MFEyOTFiblFnUFNCSGJHOWlZV3hUZEdGMFpTaDdJR2x1YVhScFlXeFdZV3gxWlRvZ1ZXbHVkRFkwS0RBcElIMHBDaUFnSUNCaWVYUmxZeUEwSUM4dklDSndZWEowYVdOcGNHRnVkRU52ZFc1MElnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOd2JHbDBYMkpwYkd3dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek9Bb2dJQ0FnTHk4Z2RHaHBjeTV3WVhKMGFXTnBjR0Z1ZEVOdmRXNTBMblpoYkhWbElEMGdkR2hwY3k1d1lYSjBhV05wY0dGdWRFTnZkVzUwTG5aaGJIVmxJQ3NnTVFvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6Y0d4cGRGOWlhV3hzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpnS0lDQWdJQzh2SUhCMVlteHBZeUJ5WldkcGMzUmxjbEJoY25ScFkybHdZVzUwS0hCaGNuUnBZMmx3WVc1MFFXUmtjbVZ6Y3pvZ2MzUnlhVzVuTENCemFHRnlaVUp3Y3pvZ2RXbHVkRFkwS1RvZ2RtOXBaQ0I3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTndiR2wwWDJKcGJHd3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZVM0JzYVhSQ2FXeHNMbXh2WTJ0Q2FXeHNXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYkc5amEwSnBiR3c2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM0JzYVhSZlltbHNiQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalF5Q2lBZ0lDQXZMeUJoYzNObGNuUW9JWFJvYVhNdWFYTk1iMk5yWldRdWRtRnNkV1VzSUNkQ2FXeHNJR0ZzY21WaFpIa2diRzlqYTJWa0p5a0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNCc2FYUmZZbWxzYkM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMENpQWdJQ0F2THlCcGMweHZZMnRsWkNBOUlFZHNiMkpoYkZOMFlYUmxLSHNnYVc1cGRHbGhiRlpoYkhWbE9pQm1ZV3h6WlNCOUtRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWFYTk1iMk5yWldRaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNCc2FYUmZZbWxzYkM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pReUNpQWdJQ0F2THlCaGMzTmxjblFvSVhSb2FYTXVhWE5NYjJOclpXUXVkbUZzZFdVc0lDZENhV3hzSUdGc2NtVmhaSGtnYkc5amEyVmtKeWtLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnUW1sc2JDQmhiSEpsWVdSNUlHeHZZMnRsWkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM053YkdsMFgySnBiR3d2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTXdvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdWRHOTBZV3hUYUdGeVpVSndjeTUyWVd4MVpTQTlQVDBnTVRCZk1EQXdMQ0FuVkc5MFlXd2djMmhoY21WeklHMTFjM1FnWlhGMVlXd2dNVEF3TURBZ1luQnpKeWtLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzQnNhWFJmWW1sc2JDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXhDaUFnSUNBdkx5QjBiM1JoYkZOb1lYSmxRbkJ6SUQwZ1IyeHZZbUZzVTNSaGRHVW9leUJwYm1sMGFXRnNWbUZzZFdVNklGVnBiblEyTkNnd0tTQjlLUW9nSUNBZ1lubDBaV05mTVNBdkx5QWlkRzkwWVd4VGFHRnlaVUp3Y3lJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6Y0d4cGRGOWlhV3hzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRNS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxuUnZkR0ZzVTJoaGNtVkNjSE11ZG1Gc2RXVWdQVDA5SURFd1h6QXdNQ3dnSjFSdmRHRnNJSE5vWVhKbGN5QnRkWE4wSUdWeGRXRnNJREV3TURBd0lHSndjeWNwQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ2NIVnphR2x1ZENBeE1EQXdNQ0F2THlBeE1EQXdNQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCVWIzUmhiQ0J6YUdGeVpYTWdiWFZ6ZENCbGNYVmhiQ0F4TURBd01DQmljSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpjR3hwZEY5aWFXeHNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFFLSUNBZ0lDOHZJR2x6VEc5amEyVmtJRDBnUjJ4dlltRnNVM1JoZEdVb2V5QnBibWwwYVdGc1ZtRnNkV1U2SUdaaGJITmxJSDBwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0pwYzB4dlkydGxaQ0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpjR3hwZEY5aWFXeHNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORFVLSUNBZ0lDOHZJSFJvYVhNdWFYTk1iMk5yWldRdWRtRnNkV1VnUFNCMGNuVmxDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emNHeHBkRjlpYVd4c0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5ERUtJQ0FnSUM4dklIQjFZbXhwWXlCc2IyTnJRbWxzYkNncE9pQjJiMmxrSUhzS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM0JzYVhSZlltbHNiQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBUY0d4cGRFSnBiR3d1YzNWaWJXbDBVR0Y1YldWdWRGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbk4xWW0xcGRGQmhlVzFsYm5RNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNCc2FYUmZZbWxzYkM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRNENpQWdJQ0F2THlCd2RXSnNhV01nYzNWaWJXbDBVR0Y1YldWdWRDaHdZWEowYVdOcGNHRnVkRUZrWkhKbGMzTTZJSE4wY21sdVp5d2dZVzF2ZFc1MFFYUnZiV2xqT2lCMWFXNTBOalFzSUhCaGVXMWxiblJVZUVsa1NHRnphRG9nYzNSeWFXNW5LVG9nZG05cFpDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpjR3hwZEY5aWFXeHNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORGtLSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG1selRHOWphMlZrTG5aaGJIVmxMQ0FuUW1sc2JDQnRkWE4wSUdKbElHeHZZMnRsWkNCbWFYSnpkQ2NwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTndiR2wwWDJKcGJHd3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOQW9nSUNBZ0x5OGdhWE5NYjJOclpXUWdQU0JIYkc5aVlXeFRkR0YwWlNoN0lHbHVhWFJwWVd4V1lXeDFaVG9nWm1Gc2MyVWdmU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbWx6VEc5amEyVmtJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTndiR2wwWDJKcGJHd3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBPUW9nSUNBZ0x5OGdZWE56WlhKMEtIUm9hWE11YVhOTWIyTnJaV1F1ZG1Gc2RXVXNJQ2RDYVd4c0lHMTFjM1FnWW1VZ2JHOWphMlZrSUdacGNuTjBKeWtLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNCaGMzTmxjblFnTHk4Z1FtbHNiQ0J0ZFhOMElHSmxJR3h2WTJ0bFpDQm1hWEp6ZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM053YkdsMFgySnBiR3d2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xTUFvZ0lDQWdMeThnWVhOelpYSjBLQ0YwYUdsekxtbHpVMlYwZEd4bFpDNTJZV3gxWlN3Z0owSnBiR3dnWVd4eVpXRmtlU0J6WlhSMGJHVmtKeWtLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzQnNhWFJmWW1sc2JDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTFDaUFnSUNBdkx5QnBjMU5sZEhSc1pXUWdQU0JIYkc5aVlXeFRkR0YwWlNoN0lHbHVhWFJwWVd4V1lXeDFaVG9nWm1Gc2MyVWdmU2tLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbWx6VTJWMGRHeGxaQ0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpjR3hwZEY5aWFXeHNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVEFLSUNBZ0lDOHZJR0Z6YzJWeWRDZ2hkR2hwY3k1cGMxTmxkSFJzWldRdWRtRnNkV1VzSUNkQ2FXeHNJR0ZzY21WaFpIa2djMlYwZEd4bFpDY3BDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRUpwYkd3Z1lXeHlaV0ZrZVNCelpYUjBiR1ZrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM0JzYVhSZlltbHNiQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalV5Q2lBZ0lDQXZMeUJqYjI1emRDQndZWEowYVdOcGNHRnVkRk5vWVhKbElEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWg3SUd0bGVUb2dZSEJmSkh0d1lYSjBhV05wY0dGdWRFRmtaSEpsYzNOOVlDQjlLUW9nSUNBZ1lubDBaV01nT0NBdkx5QWljRjhpQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTndiR2wwWDJKcGJHd3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFNd29nSUNBZ0x5OGdZWE56WlhKMEtIQmhjblJwWTJsd1lXNTBVMmhoY21VdWFHRnpWbUZzZFdVc0lDZFFZWEowYVdOcGNHRnVkQ0JwY3lCdWIzUWdjbVZuYVhOMFpYSmxaQ2NwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0oxY25rZ01Rb2dJQ0FnWVhOelpYSjBJQzh2SUZCaGNuUnBZMmx3WVc1MElHbHpJRzV2ZENCeVpXZHBjM1JsY21Wa0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNCc2FYUmZZbWxzYkM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVMUNpQWdJQ0F2THlCamIyNXpkQ0J3WVhsdFpXNTBVSEp2YjJZZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLSHNnYTJWNU9pQmdkSGhmSkh0d1lYbHRaVzUwVkhoSlpFaGhjMmg5WUNCOUtRb2dJQ0FnY0hWemFHSjVkR1Z6SUNKMGVGOGlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpjR3hwZEY5aWFXeHNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVFlLSUNBZ0lDOHZJR0Z6YzJWeWRDZ2hjR0Y1YldWdWRGQnliMjltTG1oaGMxWmhiSFZsTENBblJIVndiR2xqWVhSbElIQmhlVzFsYm5RZ2NISnZiMlluS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWW5WeWVTQXhDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnUkhWd2JHbGpZWFJsSUhCaGVXMWxiblFnY0hKdmIyWUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emNHeHBkRjlpYVd4c0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5UZ0tJQ0FnSUM4dklIQmhlVzFsYm5SUWNtOXZaaTUyWVd4MVpTQTlJREVLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTndiR2wwWDJKcGJHd3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFPUW9nSUNBZ0x5OGdkR2hwY3k1MGIzUmhiRkJoYVdSQmRHOXRhV011ZG1Gc2RXVWdQU0IwYUdsekxuUnZkR0ZzVUdGcFpFRjBiMjFwWXk1MllXeDFaU0FySUdGdGIzVnVkRUYwYjIxcFl3b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6Y0d4cGRGOWlhV3hzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRNS0lDQWdJQzh2SUhSdmRHRnNVR0ZwWkVGMGIyMXBZeUE5SUVkc2IySmhiRk4wWVhSbEtIc2dhVzVwZEdsaGJGWmhiSFZsT2lCVmFXNTBOalFvTUNrZ2ZTa0tJQ0FnSUdKNWRHVmpYeklnTHk4Z0luUnZkR0ZzVUdGcFpFRjBiMjFwWXlJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6Y0d4cGRGOWlhV3hzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRrS0lDQWdJQzh2SUhSb2FYTXVkRzkwWVd4UVlXbGtRWFJ2YldsakxuWmhiSFZsSUQwZ2RHaHBjeTUwYjNSaGJGQmhhV1JCZEc5dGFXTXVkbUZzZFdVZ0t5QmhiVzkxYm5SQmRHOXRhV01LSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBckNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNCc2FYUmZZbWxzYkM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFekNpQWdJQ0F2THlCMGIzUmhiRkJoYVdSQmRHOXRhV01nUFNCSGJHOWlZV3hUZEdGMFpTaDdJR2x1YVhScFlXeFdZV3gxWlRvZ1ZXbHVkRFkwS0RBcElIMHBDaUFnSUNCaWVYUmxZMTh5SUM4dklDSjBiM1JoYkZCaGFXUkJkRzl0YVdNaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNCc2FYUmZZbWxzYkM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVNUNpQWdJQ0F2THlCMGFHbHpMblJ2ZEdGc1VHRnBaRUYwYjIxcFl5NTJZV3gxWlNBOUlIUm9hWE11ZEc5MFlXeFFZV2xrUVhSdmJXbGpMblpoYkhWbElDc2dZVzF2ZFc1MFFYUnZiV2xqQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6Y0d4cGRGOWlhV3hzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpFS0lDQWdJQzh2SUdsbUlDaDBhR2x6TG5SdmRHRnNVR0ZwWkVGMGIyMXBZeTUyWVd4MVpTQTlQVDBnZEdocGN5NTBiM1JoYkVGMGIyMXBZeTUyWVd4MVpTa2dld29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emNHeHBkRjlpYVd4c0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9Rb2dJQ0FnTHk4Z2RHOTBZV3hCZEc5dGFXTWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0NrS0lDQWdJR0o1ZEdWaklEVWdMeThnSW5SdmRHRnNRWFJ2Yldsaklnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOd2JHbDBYMkpwYkd3dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk1Rb2dJQ0FnTHk4Z2FXWWdLSFJvYVhNdWRHOTBZV3hRWVdsa1FYUnZiV2xqTG5aaGJIVmxJRDA5UFNCMGFHbHpMblJ2ZEdGc1FYUnZiV2xqTG5aaGJIVmxLU0I3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ1BUMEtJQ0FnSUdKNklITjFZbTFwZEZCaGVXMWxiblJmWVdaMFpYSmZhV1pmWld4elpVQXpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzQnNhWFJmWW1sc2JDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTFDaUFnSUNBdkx5QnBjMU5sZEhSc1pXUWdQU0JIYkc5aVlXeFRkR0YwWlNoN0lHbHVhWFJwWVd4V1lXeDFaVG9nWm1Gc2MyVWdmU2tLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbWx6VTJWMGRHeGxaQ0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpjR3hwZEY5aWFXeHNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOaklLSUNBZ0lDOHZJSFJvYVhNdWFYTlRaWFIwYkdWa0xuWmhiSFZsSUQwZ2RISjFaUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDZ3B6ZFdKdGFYUlFZWGx0Wlc1MFgyRm1kR1Z5WDJsbVgyVnNjMlZBTXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6Y0d4cGRGOWlhV3hzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRnS0lDQWdJQzh2SUhCMVlteHBZeUJ6ZFdKdGFYUlFZWGx0Wlc1MEtIQmhjblJwWTJsd1lXNTBRV1JrY21WemN6b2djM1J5YVc1bkxDQmhiVzkxYm5SQmRHOXRhV002SUhWcGJuUTJOQ3dnY0dGNWJXVnVkRlI0U1dSSVlYTm9PaUJ6ZEhKcGJtY3BPaUIyYjJsa0lIc0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNCc2FYUmZZbWxzYkM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwVGNHeHBkRUpwYkd3dWJXRnlhMU5sZEhSc1pXUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B0WVhKclUyVjBkR3hsWkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6Y0d4cGRGOWlhV3hzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpjS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxuUnZkR0ZzVUdGcFpFRjBiMjFwWXk1MllXeDFaU0E5UFQwZ2RHaHBjeTUwYjNSaGJFRjBiMjFwWXk1MllXeDFaU3dnSjBOaGJtNXZkQ0J6WlhSMGJHVWdZbVZtYjNKbElHWjFiR3dnY0dGNWJXVnVkQ2NwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTndiR2wwWDJKcGJHd3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNd29nSUNBZ0x5OGdkRzkwWVd4UVlXbGtRWFJ2YldsaklEMGdSMnh2WW1Gc1UzUmhkR1VvZXlCcGJtbDBhV0ZzVm1Gc2RXVTZJRlZwYm5RMk5DZ3dLU0I5S1FvZ0lDQWdZbmwwWldOZk1pQXZMeUFpZEc5MFlXeFFZV2xrUVhSdmJXbGpJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTndiR2wwWDJKcGJHd3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJOd29nSUNBZ0x5OGdZWE56WlhKMEtIUm9hWE11ZEc5MFlXeFFZV2xrUVhSdmJXbGpMblpoYkhWbElEMDlQU0IwYUdsekxuUnZkR0ZzUVhSdmJXbGpMblpoYkhWbExDQW5RMkZ1Ym05MElITmxkSFJzWlNCaVpXWnZjbVVnWm5Wc2JDQndZWGx0Wlc1MEp5a0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM053YkdsMFgySnBiR3d2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem81Q2lBZ0lDQXZMeUIwYjNSaGJFRjBiMjFwWXlBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9LUW9nSUNBZ1lubDBaV01nTlNBdkx5QWlkRzkwWVd4QmRHOXRhV01pQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM0JzYVhSZlltbHNiQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalkzQ2lBZ0lDQXZMeUJoYzNObGNuUW9kR2hwY3k1MGIzUmhiRkJoYVdSQmRHOXRhV011ZG1Gc2RXVWdQVDA5SUhSb2FYTXVkRzkwWVd4QmRHOXRhV011ZG1Gc2RXVXNJQ2REWVc1dWIzUWdjMlYwZEd4bElHSmxabTl5WlNCbWRXeHNJSEJoZVcxbGJuUW5LUW9nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnUTJGdWJtOTBJSE5sZEhSc1pTQmlaV1p2Y21VZ1puVnNiQ0J3WVhsdFpXNTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzQnNhWFJmWW1sc2JDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTFDaUFnSUNBdkx5QnBjMU5sZEhSc1pXUWdQU0JIYkc5aVlXeFRkR0YwWlNoN0lHbHVhWFJwWVd4V1lXeDFaVG9nWm1Gc2MyVWdmU2tLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbWx6VTJWMGRHeGxaQ0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpjR3hwZEY5aWFXeHNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOamdLSUNBZ0lDOHZJSFJvYVhNdWFYTlRaWFIwYkdWa0xuWmhiSFZsSUQwZ2RISjFaUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzQnNhWFJmWW1sc2JDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWTJDaUFnSUNBdkx5QndkV0pzYVdNZ2JXRnlhMU5sZEhSc1pXUW9LVG9nZG05cFpDQjdDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOd2JHbDBYMkpwYkd3dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlUzQnNhWFJDYVd4c0xtZGxkRk4wWVhSMWMxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWRsZEZOMFlYUjFjem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpjR3hwZEY5aWFXeHNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOek1LSUNBZ0lDOHZJSFJvYVhNdWFYTk1iMk5yWldRdWRtRnNkV1VzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTndiR2wwWDJKcGJHd3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOQW9nSUNBZ0x5OGdhWE5NYjJOclpXUWdQU0JIYkc5aVlXeFRkR0YwWlNoN0lHbHVhWFJwWVd4V1lXeDFaVG9nWm1Gc2MyVWdmU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbWx6VEc5amEyVmtJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTndiR2wwWDJKcGJHd3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNNd29nSUNBZ0x5OGdkR2hwY3k1cGMweHZZMnRsWkM1MllXeDFaU3dLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzQnNhWFJmWW1sc2JDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qYzBDaUFnSUNBdkx5QjBhR2x6TG1selUyVjBkR3hsWkM1MllXeDFaU3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzQnNhWFJmWW1sc2JDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTFDaUFnSUNBdkx5QnBjMU5sZEhSc1pXUWdQU0JIYkc5aVlXeFRkR0YwWlNoN0lHbHVhWFJwWVd4V1lXeDFaVG9nWm1Gc2MyVWdmU2tLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbWx6VTJWMGRHeGxaQ0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpjR3hwZEY5aWFXeHNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOelFLSUNBZ0lDOHZJSFJvYVhNdWFYTlRaWFIwYkdWa0xuWmhiSFZsTEFvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpjR3hwZEY5aWFXeHNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOelVLSUNBZ0lDOHZJSFJvYVhNdWRHOTBZV3hCZEc5dGFXTXVkbUZzZFdVc0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM053YkdsMFgySnBiR3d2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem81Q2lBZ0lDQXZMeUIwYjNSaGJFRjBiMjFwWXlBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9LUW9nSUNBZ1lubDBaV01nTlNBdkx5QWlkRzkwWVd4QmRHOXRhV01pQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM0JzYVhSZlltbHNiQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamMxQ2lBZ0lDQXZMeUIwYUdsekxuUnZkR0ZzUVhSdmJXbGpMblpoYkhWbExBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6Y0d4cGRGOWlhV3hzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnpZS0lDQWdJQzh2SUhSb2FYTXVkRzkwWVd4UVlXbGtRWFJ2YldsakxuWmhiSFZsTEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpjR3hwZEY5aWFXeHNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVE1LSUNBZ0lDOHZJSFJ2ZEdGc1VHRnBaRUYwYjIxcFl5QTlJRWRzYjJKaGJGTjBZWFJsS0hzZ2FXNXBkR2xoYkZaaGJIVmxPaUJWYVc1ME5qUW9NQ2tnZlNrS0lDQWdJR0o1ZEdWalh6SWdMeThnSW5SdmRHRnNVR0ZwWkVGMGIyMXBZeUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpjR3hwZEY5aWFXeHNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOellLSUNBZ0lDOHZJSFJvYVhNdWRHOTBZV3hRWVdsa1FYUnZiV2xqTG5aaGJIVmxMQW9nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emNHeHBkRjlpYVd4c0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk56Y0tJQ0FnSUM4dklIUm9hWE11ZEc5MFlXeFRhR0Z5WlVKd2N5NTJZV3gxWlN3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM0JzYVhSZlltbHNiQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV4Q2lBZ0lDQXZMeUIwYjNSaGJGTm9ZWEpsUW5CeklEMGdSMnh2WW1Gc1UzUmhkR1VvZXlCcGJtbDBhV0ZzVm1Gc2RXVTZJRlZwYm5RMk5DZ3dLU0I5S1FvZ0lDQWdZbmwwWldOZk1TQXZMeUFpZEc5MFlXeFRhR0Z5WlVKd2N5SUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emNHeHBkRjlpYVd4c0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk56Y0tJQ0FnSUM4dklIUm9hWE11ZEc5MFlXeFRhR0Z5WlVKd2N5NTJZV3gxWlN3S0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM0JzYVhSZlltbHNiQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamN5TFRjNENpQWdJQ0F2THlCeVpYUjFjbTRnV3dvZ0lDQWdMeThnSUNCMGFHbHpMbWx6VEc5amEyVmtMblpoYkhWbExBb2dJQ0FnTHk4Z0lDQjBhR2x6TG1selUyVjBkR3hsWkM1MllXeDFaU3dLSUNBZ0lDOHZJQ0FnZEdocGN5NTBiM1JoYkVGMGIyMXBZeTUyWVd4MVpTd0tJQ0FnSUM4dklDQWdkR2hwY3k1MGIzUmhiRkJoYVdSQmRHOXRhV011ZG1Gc2RXVXNDaUFnSUNBdkx5QWdJSFJvYVhNdWRHOTBZV3hUYUdGeVpVSndjeTUyWVd4MVpTd0tJQ0FnSUM4dklGMEtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnZFc1amIzWmxjaUEyQ2lBZ0lDQnpaWFJpYVhRS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUhObGRHSnBkQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emNHeHBkRjlpYVd4c0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk56RUtJQ0FnSUM4dklIQjFZbXhwWXlCblpYUlRkR0YwZFhNb0tUb2dXMkp2YjJ4bFlXNHNJR0p2YjJ4bFlXNHNJSFZwYm5RMk5Dd2dkV2x1ZERZMExDQjFhVzUwTmpSZElIc0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnbz0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBQUVDQ0NZSkNHbHpURzlqYTJWa0RYUnZkR0ZzVTJoaGNtVkNjSE1QZEc5MFlXeFFZV2xrUVhSdmJXbGpDV2x6VTJWMGRHeGxaQkJ3WVhKMGFXTnBjR0Z1ZEVOdmRXNTBDM1J2ZEdGc1FYUnZiV2xqQjJGemMyVjBTV1FLWW1sc2JFbGtTR0Z6YUFKd1h6RVlRQUFVSndZaVp5a2laeWNFSW1jcUltY29JbWNySW1jeEcwRUFPVEVaRkVReEdFU0NCZ1Qra0NBakJEZ1VjUUFFTWp4aTl3U2V2dHd4Qk95cC9OOEV0MmFTSERZYUFJNEdBQXNBZndET0FPSUJTUUZaQURFWkZERVlGQkJFSTBNMkdnRkpJbGtrQ0VzQkZSSkVWd0lBTmhvQ1NTSlpKQWhMQVJVU1JGY0NBRFlhQTBrVkpSSkVGellhQkVrVkpSSkVGellhQlVrVkpSSkVGeUluQjJWRkFSUkVTd0ZFSndkUEJXZUFESEJoZVdWeVFXUmtjbVZ6YzA4RVp5Y0dUd05uSndWUEFtZUFDR1JsWVdSc2FXNWxUR2NqUXpZYUFVa2lXU1FJU3dFVkVrUlhBZ0EyR2dKSkZTVVNSQmNpS0dWRUZFUkpSQ0luQkdWRWdSUU1SQ2NJVHdKUUlrc0JaVVVCRkVSTEFXY2lLV1ZFQ0NsTVp5SW5CR1ZFSXdnbkJFeG5JME1pS0dWRUZFUWlLV1ZFZ1pCT0VrUW9JMmNqUXpZYUFVa2lXU1FJU3dFVkVrUlhBZ0EyR2dKSkZTVVNSQmMyR2dOSklsa2tDRXNCRlJKRVZ3SUFJaWhsUkVRaUsyVkVGRVFuQ0U4RFVDSk1aVVVCUklBRGRIaGZURkFpU3dGbFJRRVVSQ05uSWlwbFJBZ3FTd0ZuSWljRlpVUVNRUUFES3lObkkwTWlLbVZFSWljRlpVUVNSQ3NqWnlORElpaGxSQ0lyWlVRaUp3VmxSQ0lxWlVRaUtXVkVnQUVBSWs4R1ZDTlBCVlJQQXhaUVR3SVdVRXdXVUlBRUZSOThkVXhRc0NORCIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjMsInBhdGNoIjoyLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
