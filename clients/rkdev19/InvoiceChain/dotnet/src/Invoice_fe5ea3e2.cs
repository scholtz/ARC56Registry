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

namespace Arc56.Generated.rkdev19.InvoiceChain.Invoice_fe5ea3e2
{


    public class InvoiceProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public InvoiceProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class GetInvoiceInfoReturn : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public ulong Field1 { get; set; }

                public ulong Field2 { get; set; }

                public string Field3 { get; set; }

                public ulong Field4 { get; set; }

                public bool Field5 { get; set; }

                public ulong Field6 { get; set; }

                public ulong Field7 { get; set; }

                public bool Field8 { get; set; }

                public string Field9 { get; set; }

                public ulong Field10 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField2.From(Field2);
                    ret.AddRange(vField2.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField3.From(Field3);
                    stringRef[ret.Count] = vField3.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField4.From(Field4);
                    ret.AddRange(vField4.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField5 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vField5.From(Field5);
                    ret.AddRange(vField5.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField6 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField6.From(Field6);
                    ret.AddRange(vField6.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField7 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField7.From(Field7);
                    ret.AddRange(vField7.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField8 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vField8.From(Field8);
                    ret.AddRange(vField8.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField9 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField9.From(Field9);
                    stringRef[ret.Count] = vField9.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField10 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField10.From(Field10);
                    ret.AddRange(vField10.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static GetInvoiceInfoReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new GetInvoiceInfoReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is ulong vField0Value) { ret.Field0 = vField0Value; }
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
                    var indexField3 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField3.Decode(bytes.Skip(indexField3 + prefixOffset).ToArray());
                    var valueField3 = vField3.ToValue();
                    if (valueField3 is string vField3Value) { ret.Field3 = vField3Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField4.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField4 = vField4.ToValue();
                    if (valueField4 is ulong vField4Value) { ret.Field4 = vField4Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField5 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField5.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField5 = vField5.ToValue();
                    if (valueField5 is bool vField5Value) { ret.Field5 = vField5Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField6 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField6.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField6 = vField6.ToValue();
                    if (valueField6 is ulong vField6Value) { ret.Field6 = vField6Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField7 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField7.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField7 = vField7.ToValue();
                    if (valueField7 is ulong vField7Value) { ret.Field7 = vField7Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField8 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField8.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField8 = vField8.ToValue();
                    if (valueField8 is bool vField8Value) { ret.Field8 = vField8Value; }
                    var indexField9 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField9 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField9.Decode(bytes.Skip(indexField9 + prefixOffset).ToArray());
                    var valueField9 = vField9.ToValue();
                    if (valueField9 is string vField9Value) { ret.Field9 = vField9Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField10 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField10.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField10 = vField10.ToValue();
                    if (valueField10 is ulong vField10Value) { ret.Field10 = vField10Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetInvoiceInfoReturn);
                }
                public bool Equals(GetInvoiceInfoReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetInvoiceInfoReturn left, GetInvoiceInfoReturn right)
                {
                    return EqualityComparer<GetInvoiceInfoReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetInvoiceInfoReturn left, GetInvoiceInfoReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Mint the InvoiceChain Credit (ICC) ASA.
        ///Must be called once by the deployer immediately after contract creation. The contract account holds the full supply and distributes via borrow().
        ///</summary>
        public async Task<ulong> SetupIcc(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 29, 86, 167, 106 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> SetupIcc_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 29, 86, 167, 106 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Deployer sends ALGO to the contract to cover minimum balances and inner
        ///transaction fees. ICC supply is already held by the contract after setup_icc.
        ///</summary>
        /// <param name="payment"> </param>
        public async Task SeedPool(PaymentTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 136, 160, 255, 173 };

            var result = await base.CallApp(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SeedPool_Transactions(PaymentTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 136, 160, 255, 173 };

            return await base.MakeTransactionList(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Return the ICC balance held by the contract (available for lending).
        ///</summary>
        public async Task<ulong> GetPoolBalance(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 198, 221, 56, 239 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetPoolBalance_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 198, 221, 56, 239 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Mint an ARC-3 Invoice NFT.
        ///The NFT is held by the contract as implicit collateral until repayment. Returns the new ASA ID.
        ///</summary>
        /// <param name="amount"> </param>
        /// <param name="due_date"> </param>
        /// <param name="trust_score"> </param>
        public async Task<ulong> CreateInvoice(ulong amount, ulong due_date, ulong trust_score, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 172, 210, 17, 218 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var due_dateAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); due_dateAbi.From(due_date);
            var trust_scoreAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); trust_scoreAbi.From(trust_score);

            var result = await base.CallApp(new List<object> { abiHandle, amountAbi, due_dateAbi, trust_scoreAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CreateInvoice_Transactions(ulong amount, ulong due_date, ulong trust_score, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 172, 210, 17, 218 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var due_dateAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); due_dateAbi.From(due_date);
            var trust_scoreAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); trust_scoreAbi.From(trust_score);

            return await base.MakeTransactionList(new List<object> { abiHandle, amountAbi, due_dateAbi, trust_scoreAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Lock the invoice NFT as collateral (held by contract) and transfer
        ///borrow_amount ICC to Txn.sender.
        ///The NFT is already held by the contract since create_invoice — locking is enforced via collateral_locked state. The ICC transfer is the on-chain proof of the loan.
        ///Caller must have opted in to the ICC ASA before calling this method.
        ///</summary>
        /// <param name="borrow_amount"> </param>
        public async Task Borrow(ulong borrow_amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 219, 215, 185, 221 };
            var borrow_amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); borrow_amountAbi.From(borrow_amount);

            var result = await base.CallApp(new List<object> { abiHandle, borrow_amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Borrow_Transactions(ulong borrow_amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 219, 215, 185, 221 };
            var borrow_amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); borrow_amountAbi.From(borrow_amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, borrow_amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///SME repays the loan by sending ICC back.
        ///gtxn[0] must be an ICC asset transfer to this contract. On success the collateral lock is released.
        ///</summary>
        /// <param name="icc_transfer"> </param>
        public async Task Repay(AssetTransferTransaction icc_transfer, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { icc_transfer });
            byte[] abiHandle = { 232, 17, 213, 184 };

            var result = await base.CallApp(new List<object> { abiHandle, icc_transfer }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Repay_Transactions(AssetTransferTransaction icc_transfer, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { icc_transfer });
            byte[] abiHandle = { 232, 17, 213, 184 };

            return await base.MakeTransactionList(new List<object> { abiHandle, icc_transfer }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Creator liquidates an overdue position.
        ///Callable only after due_date has passed and a borrow is active. The NFT remains in the contract — it is not returned to the borrower.
        ///</summary>
        public async Task Liquidate(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 54, 218, 223, 4 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Liquidate_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 54, 218, 223, 4 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.GetInvoiceInfoReturn> GetInvoiceInfo(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 212, 207, 146, 148 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetInvoiceInfoReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetInvoiceInfo_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 212, 207, 146, 148 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiSW52b2ljZSIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJHZXRJbnZvaWNlSW5mb1JldHVybiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQyIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMyIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJmaWVsZDQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQ1IiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJmaWVsZDYiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQ3IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkOCIsInR5cGUiOiJib29sIn0seyJuYW1lIjoiZmllbGQ5IiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6ImZpZWxkMTAiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6InNldHVwX2ljYyIsImRlc2MiOiJNaW50IHRoZSBJbnZvaWNlQ2hhaW4gQ3JlZGl0IChJQ0MpIEFTQS5cbk11c3QgYmUgY2FsbGVkIG9uY2UgYnkgdGhlIGRlcGxveWVyIGltbWVkaWF0ZWx5IGFmdGVyIGNvbnRyYWN0IGNyZWF0aW9uLiBUaGUgY29udHJhY3QgYWNjb3VudCBob2xkcyB0aGUgZnVsbCBzdXBwbHkgYW5kIGRpc3RyaWJ1dGVzIHZpYSBib3Jyb3coKS4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZWVkX3Bvb2wiLCJkZXNjIjoiRGVwbG95ZXIgc2VuZHMgQUxHTyB0byB0aGUgY29udHJhY3QgdG8gY292ZXIgbWluaW11bSBiYWxhbmNlcyBhbmQgaW5uZXJcbnRyYW5zYWN0aW9uIGZlZXMuIElDQyBzdXBwbHkgaXMgYWxyZWFkeSBoZWxkIGJ5IHRoZSBjb250cmFjdCBhZnRlciBzZXR1cF9pY2MuIiwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheW1lbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3Bvb2xfYmFsYW5jZSIsImRlc2MiOiJSZXR1cm4gdGhlIElDQyBiYWxhbmNlIGhlbGQgYnkgdGhlIGNvbnRyYWN0IChhdmFpbGFibGUgZm9yIGxlbmRpbmcpLiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY3JlYXRlX2ludm9pY2UiLCJkZXNjIjoiTWludCBhbiBBUkMtMyBJbnZvaWNlIE5GVC5cblRoZSBORlQgaXMgaGVsZCBieSB0aGUgY29udHJhY3QgYXMgaW1wbGljaXQgY29sbGF0ZXJhbCB1bnRpbCByZXBheW1lbnQuIFJldHVybnMgdGhlIG5ldyBBU0EgSUQuIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZHVlX2RhdGUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRydXN0X3Njb3JlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYm9ycm93IiwiZGVzYyI6IkxvY2sgdGhlIGludm9pY2UgTkZUIGFzIGNvbGxhdGVyYWwgKGhlbGQgYnkgY29udHJhY3QpIGFuZCB0cmFuc2ZlclxuYm9ycm93X2Ftb3VudCBJQ0MgdG8gVHhuLnNlbmRlci5cblRoZSBORlQgaXMgYWxyZWFkeSBoZWxkIGJ5IHRoZSBjb250cmFjdCBzaW5jZSBjcmVhdGVfaW52b2ljZSDigJQgbG9ja2luZyBpcyBlbmZvcmNlZCB2aWEgY29sbGF0ZXJhbF9sb2NrZWQgc3RhdGUuIFRoZSBJQ0MgdHJhbnNmZXIgaXMgdGhlIG9uLWNoYWluIHByb29mIG9mIHRoZSBsb2FuLlxuQ2FsbGVyIG11c3QgaGF2ZSBvcHRlZCBpbiB0byB0aGUgSUNDIEFTQSBiZWZvcmUgY2FsbGluZyB0aGlzIG1ldGhvZC4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYm9ycm93X2Ftb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZXBheSIsImRlc2MiOiJTTUUgcmVwYXlzIHRoZSBsb2FuIGJ5IHNlbmRpbmcgSUNDIGJhY2suXG5ndHhuWzBdIG11c3QgYmUgYW4gSUNDIGFzc2V0IHRyYW5zZmVyIHRvIHRoaXMgY29udHJhY3QuIE9uIHN1Y2Nlc3MgdGhlIGNvbGxhdGVyYWwgbG9jayBpcyByZWxlYXNlZC4iLCJhcmdzIjpbeyJ0eXBlIjoiYXhmZXIiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpY2NfdHJhbnNmZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibGlxdWlkYXRlIiwiZGVzYyI6IkNyZWF0b3IgbGlxdWlkYXRlcyBhbiBvdmVyZHVlIHBvc2l0aW9uLlxuQ2FsbGFibGUgb25seSBhZnRlciBkdWVfZGF0ZSBoYXMgcGFzc2VkIGFuZCBhIGJvcnJvdyBpcyBhY3RpdmUuIFRoZSBORlQgcmVtYWlucyBpbiB0aGUgY29udHJhY3Qg4oCUIGl0IGlzIG5vdCByZXR1cm5lZCB0byB0aGUgYm9ycm93ZXIuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9pbnZvaWNlX2luZm8iLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQsdWludDY0LHN0cmluZyx1aW50NjQsYm9vbCx1aW50NjQsdWludDY0LGJvb2wsc3RyaW5nLHVpbnQ2NCkiLCJzdHJ1Y3QiOiJHZXRJbnZvaWNlSW5mb1JldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjksImJ5dGVzIjoyfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls3MDZdLCJlcnJvck1lc3NhZ2UiOiJDb2xsYXRlcmFsIGFscmVhZHkgbG9ja2VkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzE1XSwiZXJyb3JNZXNzYWdlIjoiRXhjZWVkcyBib3Jyb3cgbGltaXQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyOTRdLCJlcnJvck1lc3NhZ2UiOiJJQ0MgYWxyZWFkeSBjcmVhdGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzk3XSwiZXJyb3JNZXNzYWdlIjoiSUNDIG11c3QgZ28gdG8gY29udHJhY3QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2ODhdLCJlcnJvck1lc3NhZ2UiOiJJQ0Mgbm90IGluaXRpYWxpc2VkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzM1XSwiZXJyb3JNZXNzYWdlIjoiSW5zdWZmaWNpZW50IElDQyBpbiBwb29sIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODA1XSwiZXJyb3JNZXNzYWdlIjoiSW5zdWZmaWNpZW50IHJlcGF5bWVudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzcwMF0sImVycm9yTWVzc2FnZSI6Ikludm9pY2UgYWxyZWFkeSBib3Jyb3dlZCBhZ2FpbnN0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzI0XSwiZXJyb3JNZXNzYWdlIjoiSW52b2ljZSBub3QgYWN0aXZlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODM2XSwiZXJyb3JNZXNzYWdlIjoiSW52b2ljZSBub3QgeWV0IG92ZXJkdWUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3OTBdLCJlcnJvck1lc3NhZ2UiOiJNdXN0IHJlcGF5IHdpdGggSUNDIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzgxXSwiZXJyb3JNZXNzYWdlIjoiTm8gYWN0aXZlIGJvcnJvdyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzgyN10sImVycm9yTWVzc2FnZSI6Ik5vIGFjdGl2ZSBib3Jyb3cgdG8gbGlxdWlkYXRlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjk0XSwiZXJyb3JNZXNzYWdlIjoiTm8gaW52b2ljZSBtaW50ZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4MjJdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGNyZWF0b3IgY2FuIGxpcXVpZGF0ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI4OF0sImVycm9yTWVzc2FnZSI6Ik9ubHkgZGVwbG95ZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MTJdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGRlcGxveWVyIGNhbiBzZWVkIHBvb2wiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MjJdLCJlcnJvck1lc3NhZ2UiOiJQYXltZW50IG11c3QgYmUgcG9zaXRpdmUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MTldLCJlcnJvck1lc3NhZ2UiOiJQYXltZW50IG11c3QgZ28gdG8gY29udHJhY3QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NDksNzMxXSwiZXJyb3JNZXNzYWdlIjoiYWNjb3VudCBvcHRlZCBpbnRvIGFzc2V0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODY0XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5hbW91bnQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzExLDg4NF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuYm9ycm93X2xpbWl0IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzgwMyw4OTJdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmJvcnJvd2VkX2Ftb3VudCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3MDQsOTAxXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5jb2xsYXRlcmFsX2xvY2tlZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4MzQsODY5XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5kdWVfZGF0ZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyOTIsNDI4LDQ0Niw2ODYsNzg4LDkxMF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuaWNjX2Fzc2V0X2lkIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY5OCw3ODAsODI2LDg4OF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuaXNfYm9ycm93ZWQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjkzLDg5N10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYubmZ0X2Fzc2V0X2lkIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzg3OV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYucmlza19sZXZlbCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3MjAsOTA2XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5zdGF0dXMgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODc0XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi50cnVzdF9zY29yZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NjAsNDcwLDQ4MCw2ODFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3NzZdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIGF4ZmVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDA2XSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBwYXkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0ODldLCJlcnJvck1lc3NhZ2UiOiJ0cnVzdF9zY29yZSBtdXN0IGJlIDAtMTAwIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBd0lERWdPQ0F6Q2lBZ0lDQmllWFJsWTJKc2IyTnJJQ0pwYzE5aWIzSnliM2RsWkNJZ0ltbGpZMTloYzNObGRGOXBaQ0lnSW1OdmJHeGhkR1Z5WVd4ZmJHOWphMlZrSWlBaVltOXljbTkzWldSZllXMXZkVzUwSWlBaWMzUmhkSFZ6SWlBaVpIVmxYMlJoZEdVaUlDSmliM0p5YjNkZmJHbHRhWFFpSUNKdVpuUmZZWE56WlhSZmFXUWlJREI0TVRVeFpqZGpOelVnSW1GdGIzVnVkQ0lnSW5SeWRYTjBYM05qYjNKbElpQWljbWx6YTE5c1pYWmxiQ0lnSWtGRFZFbFdSU0lLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpYm5vZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFESUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cGJuWnZhV05sTDJOdmJuUnlZV04wTG5CNU9qa3RNVEFLSUNBZ0lDOHZJQ01nU1VORElIUnZhMlZ1Q2lBZ0lDQXZMeUJ6Wld4bUxtbGpZMTloYzNObGRGOXBaQ0E5SUZWSmJuUTJOQ2d3S1FvZ0lDQWdZbmwwWldOZk1TQXZMeUFpYVdOalgyRnpjMlYwWDJsa0lnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1MmIybGpaUzlqYjI1MGNtRmpkQzV3ZVRveE1TMHhNZ29nSUNBZ0x5OGdJeUJKYm5admFXTmxJR1pwWld4a2N3b2dJQ0FnTHk4Z2MyVnNaaTVoYlc5MWJuUWdQU0JWU1c1ME5qUW9NQ2tLSUNBZ0lHSjVkR1ZqSURrZ0x5OGdJbUZ0YjNWdWRDSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsdWRtOXBZMlV2WTI5dWRISmhZM1F1Y0hrNk1UTUtJQ0FnSUM4dklITmxiR1l1WkhWbFgyUmhkR1VnUFNCVlNXNTBOalFvTUNrS0lDQWdJR0o1ZEdWaklEVWdMeThnSW1SMVpWOWtZWFJsSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhVzUyYjJsalpTOWpiMjUwY21GamRDNXdlVG94TkFvZ0lDQWdMeThnYzJWc1ppNTBjblZ6ZEY5elkyOXlaU0E5SUZWSmJuUTJOQ2d3S1FvZ0lDQWdZbmwwWldNZ01UQWdMeThnSW5SeWRYTjBYM05qYjNKbElnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1MmIybGpaUzlqYjI1MGNtRmpkQzV3ZVRveE5Rb2dJQ0FnTHk4Z2MyVnNaaTV5YVhOclgyeGxkbVZzSUQwZ1UzUnlhVzVuS0NJaUtRb2dJQ0FnWW5sMFpXTWdNVEVnTHk4Z0luSnBjMnRmYkdWMlpXd2lDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNTJiMmxqWlM5amIyNTBjbUZqZEM1d2VUb3hOZ29nSUNBZ0x5OGdjMlZzWmk1aWIzSnliM2RmYkdsdGFYUWdQU0JWU1c1ME5qUW9NQ2tLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdJbUp2Y25KdmQxOXNhVzFwZENJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmx1ZG05cFkyVXZZMjl1ZEhKaFkzUXVjSGs2TVRjS0lDQWdJQzh2SUhObGJHWXVibVowWDJGemMyVjBYMmxrSUQwZ1ZVbHVkRFkwS0RBcENpQWdJQ0JpZVhSbFl5QTNJQzh2SUNKdVpuUmZZWE56WlhSZmFXUWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cGJuWnZhV05sTDJOdmJuUnlZV04wTG5CNU9qRTRMVEU1Q2lBZ0lDQXZMeUFqSUV4dllXNGdjM1JoZEdVS0lDQWdJQzh2SUhObGJHWXVhWE5mWW05eWNtOTNaV1FnUFNCR1lXeHpaUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlhWE5mWW05eWNtOTNaV1FpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBiblp2YVdObEwyTnZiblJ5WVdOMExuQjVPakl3Q2lBZ0lDQXZMeUJ6Wld4bUxtSnZjbkp2ZDJWa1gyRnRiM1Z1ZENBOUlGVkpiblEyTkNnd0tRb2dJQ0FnWW5sMFpXTmZNeUF2THlBaVltOXljbTkzWldSZllXMXZkVzUwSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhVzUyYjJsalpTOWpiMjUwY21GamRDNXdlVG95TVFvZ0lDQWdMeThnYzJWc1ppNWpiMnhzWVhSbGNtRnNYMnh2WTJ0bFpDQTlJRVpoYkhObENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKamIyeHNZWFJsY21Gc1gyeHZZMnRsWkNJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmx1ZG05cFkyVXZZMjl1ZEhKaFkzUXVjSGs2TWpJS0lDQWdJQzh2SUhObGJHWXVjM1JoZEhWeklEMGdVM1J5YVc1bktDSkJRMVJKVmtVaUtRb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaWMzUmhkSFZ6SWdvZ0lDQWdZbmwwWldNZ01USWdMeThnSWtGRFZFbFdSU0lLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2dwdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cGJuWnZhV05sTDJOdmJuUnlZV04wTG5CNU9qY0tJQ0FnSUM4dklHTnNZWE56SUVsdWRtOXBZMlVvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCaWVpQnRZV2x1WDE5ZllXeG5iM0I1WDJSbFptRjFiSFJmWTNKbFlYUmxRREUzQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFLSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGd4WkRVMllUYzJZU0F3ZURnNFlUQm1abUZrSURCNFl6WmtaRE00WldZZ01IaGhZMlF5TVRGa1lTQXdlR1JpWkRkaU9XUmtJREI0WlRneE1XUTFZamdnTUhnek5tUmhaR1l3TkNBd2VHUTBZMlk1TWprMElDOHZJRzFsZEdodlpDQWljMlYwZFhCZmFXTmpLQ2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbk5sWldSZmNHOXZiQ2h3WVhrcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWjJWMFgzQnZiMnhmWW1Gc1lXNWpaU2dwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0pqY21WaGRHVmZhVzUyYjJsalpTaDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbUp2Y25KdmR5aDFhVzUwTmpRcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpY21Wd1lYa29ZWGhtWlhJcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpYkdseGRXbGtZWFJsS0NsMmIybGtJaXdnYldWMGFHOWtJQ0puWlhSZmFXNTJiMmxqWlY5cGJtWnZLQ2tvZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc2MzUnlhVzVuTEhWcGJuUTJOQ3hpYjI5c0xIVnBiblEyTkN4MWFXNTBOalFzWW05dmJDeHpkSEpwYm1jc2RXbHVkRFkwS1NJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lITmxkSFZ3WDJsall5QnpaV1ZrWDNCdmIyd2daMlYwWDNCdmIyeGZZbUZzWVc1alpTQmpjbVZoZEdWZmFXNTJiMmxqWlNCaWIzSnliM2NnY21Wd1lYa2diR2x4ZFdsa1lYUmxJR2RsZEY5cGJuWnZhV05sWDJsdVptOEtJQ0FnSUdWeWNnb0tiV0ZwYmw5ZlgyRnNaMjl3ZVY5a1pXWmhkV3gwWDJOeVpXRjBaVUF4TnpvS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBaENpQWdJQ0FtSmdvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbWx1ZG05cFkyVXVZMjl1ZEhKaFkzUXVTVzUyYjJsalpTNXpaWFIxY0Y5cFkyTmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B6WlhSMWNGOXBZMk02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhVzUyYjJsalpTOWpiMjUwY21GamRDNXdlVG96TlFvZ0lDQWdMeThnWVhOelpYSjBJRlI0Ymk1elpXNWtaWElnUFQwZ1IyeHZZbUZzTG1OeVpXRjBiM0pmWVdSa2NtVnpjeXdnSWs5dWJIa2daR1Z3Ykc5NVpYSWlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JuYkc5aVlXd2dRM0psWVhSdmNrRmtaSEpsYzNNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVzZVNCa1pYQnNiM2xsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmx1ZG05cFkyVXZZMjl1ZEhKaFkzUXVjSGs2TXpZS0lDQWdJQzh2SUdGemMyVnlkQ0J6Wld4bUxtbGpZMTloYzNObGRGOXBaQ0E5UFNCVlNXNTBOalFvTUNrc0lDSkpRME1nWVd4eVpXRmtlU0JqY21WaGRHVmtJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltbGpZMTloYzNObGRGOXBaQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1cFkyTmZZWE56WlhSZmFXUWdaWGhwYzNSekNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdTVU5ESUdGc2NtVmhaSGtnWTNKbFlYUmxaQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwybHVkbTlwWTJVdlkyOXVkSEpoWTNRdWNIazZNemd0TkRnS0lDQWdJQzh2SUhKbGMzVnNkQ0E5SUdsMGVHNHVRWE56WlhSRGIyNW1hV2NvQ2lBZ0lDQXZMeUFnSUNBZ2RHOTBZV3c5TVY4d01EQmZNREF3TEFvZ0lDQWdMeThnSUNBZ0lHUmxZMmx0WVd4elBUSXNDaUFnSUNBdkx5QWdJQ0FnZFc1cGRGOXVZVzFsUFNKSlEwTWlMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYMjVoYldVOUlrbHVkbTlwWTJWRGFHRnBiaUJEY21Wa2FYUWlMQW9nSUNBZ0x5OGdJQ0FnSUhWeWJEMGlhSFIwY0hNNkx5OXBiblp2YVdObFkyaGhhVzR1WVhCd0lpd0tJQ0FnSUM4dklDQWdJQ0J0WVc1aFoyVnlQVWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJQ0FnY21WelpYSjJaVDFIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0FnSUdaeVpXVjZaVDFIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0FnSUdOc1lYZGlZV05yUFVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01zQ2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNTJiMmxqWlM5amIyNTBjbUZqZEM1d2VUbzBOQW9nSUNBZ0x5OGdiV0Z1WVdkbGNqMUhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxBb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cGJuWnZhV05sTDJOdmJuUnlZV04wTG5CNU9qUTFMVFEzQ2lBZ0lDQXZMeUJ5WlhObGNuWmxQVWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNDaUFnSUNBdkx5Qm1jbVZsZW1VOVIyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3l3S0lDQWdJQzh2SUdOc1lYZGlZV05yUFVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01zQ2lBZ0lDQmtkWEJ1SURNS0lDQWdJR2wwZUc1ZlptbGxiR1FnUTI5dVptbG5RWE56WlhSRGJHRjNZbUZqYXdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JEYjI1bWFXZEJjM05sZEVaeVpXVjZaUW9nSUNBZ2FYUjRibDltYVdWc1pDQkRiMjVtYVdkQmMzTmxkRkpsYzJWeWRtVUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1EyOXVabWxuUVhOelpYUk5ZVzVoWjJWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1MmIybGpaUzlqYjI1MGNtRmpkQzV3ZVRvME13b2dJQ0FnTHk4Z2RYSnNQU0pvZEhSd2N6b3ZMMmx1ZG05cFkyVmphR0ZwYmk1aGNIQWlMQW9nSUNBZ2NIVnphR0o1ZEdWeklDSm9kSFJ3Y3pvdkwybHVkbTlwWTJWamFHRnBiaTVoY0hBaUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVOdmJtWnBaMEZ6YzJWMFZWSk1DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNTJiMmxqWlM5amIyNTBjbUZqZEM1d2VUbzBNZ29nSUNBZ0x5OGdZWE56WlhSZmJtRnRaVDBpU1c1MmIybGpaVU5vWVdsdUlFTnlaV1JwZENJc0NpQWdJQ0J3ZFhOb1lubDBaWE1nSWtsdWRtOXBZMlZEYUdGcGJpQkRjbVZrYVhRaUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVOdmJtWnBaMEZ6YzJWMFRtRnRaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwybHVkbTlwWTJVdlkyOXVkSEpoWTNRdWNIazZOREVLSUNBZ0lDOHZJSFZ1YVhSZmJtRnRaVDBpU1VORElpd0tJQ0FnSUhCMWMyaGllWFJsY3lBaVNVTkRJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkRiMjVtYVdkQmMzTmxkRlZ1YVhST1lXMWxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNTJiMmxqWlM5amIyNTBjbUZqZEM1d2VUbzBNQW9nSUNBZ0x5OGdaR1ZqYVcxaGJITTlNaXdLSUNBZ0lIQjFjMmhwYm5RZ01nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCRGIyNW1hV2RCYzNObGRFUmxZMmx0WVd4ekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1MmIybGpaUzlqYjI1MGNtRmpkQzV3ZVRvek9Rb2dJQ0FnTHk4Z2RHOTBZV3c5TVY4d01EQmZNREF3TEFvZ0lDQWdjSFZ6YUdsdWRDQXhNREF3TURBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVOdmJtWnBaMEZ6YzJWMFZHOTBZV3dLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBiblp2YVdObEwyTnZiblJ5WVdOMExuQjVPak00Q2lBZ0lDQXZMeUJ5WlhOMWJIUWdQU0JwZEhodUxrRnpjMlYwUTI5dVptbG5LQW9nSUNBZ2FXNTBZMTh6SUM4dklHRmpabWNLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsdWRtOXBZMlV2WTI5dWRISmhZM1F1Y0hrNk16Z3RORGdLSUNBZ0lDOHZJSEpsYzNWc2RDQTlJR2wwZUc0dVFYTnpaWFJEYjI1bWFXY29DaUFnSUNBdkx5QWdJQ0FnZEc5MFlXdzlNVjh3TURCZk1EQXdMQW9nSUNBZ0x5OGdJQ0FnSUdSbFkybHRZV3h6UFRJc0NpQWdJQ0F2THlBZ0lDQWdkVzVwZEY5dVlXMWxQU0pKUTBNaUxBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFgyNWhiV1U5SWtsdWRtOXBZMlZEYUdGcGJpQkRjbVZrYVhRaUxBb2dJQ0FnTHk4Z0lDQWdJSFZ5YkQwaWFIUjBjSE02THk5cGJuWnZhV05sWTJoaGFXNHVZWEJ3SWl3S0lDQWdJQzh2SUNBZ0lDQnRZVzVoWjJWeVBVZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lDQWdjbVZ6WlhKMlpUMUhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQWdJR1p5WldWNlpUMUhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQWdJR05zWVhkaVlXTnJQVWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNDaUFnSUNBdkx5QXBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnYVhSNGJpQkRjbVZoZEdWa1FYTnpaWFJKUkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmx1ZG05cFkyVXZZMjl1ZEhKaFkzUXVjSGs2TlRBS0lDQWdJQzh2SUhObGJHWXVhV05qWDJGemMyVjBYMmxrSUQwZ2NtVnpkV3gwTG1OeVpXRjBaV1JmWVhOelpYUXVhV1FLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbWxqWTE5aGMzTmxkRjlwWkNJS0lDQWdJR1JwWnlBeENpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsdWRtOXBZMlV2WTI5dWRISmhZM1F1Y0hrNk1qZ0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUUtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpJRGdnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11YVc1MmIybGpaUzVqYjI1MGNtRmpkQzVKYm5admFXTmxMbk5sWldSZmNHOXZiRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25ObFpXUmZjRzl2YkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwYm5admFXTmxMMk52Ym5SeVlXTjBMbkI1T2pVM0NpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQzBLSUNBZ0lHUjFjQW9nSUNBZ1ozUjRibk1nVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTVNBdkx5QndZWGtLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2RISmhibk5oWTNScGIyNGdkSGx3WlNCcGN5QndZWGtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBiblp2YVdObEwyTnZiblJ5WVdOMExuQjVPall6Q2lBZ0lDQXZMeUJoYzNObGNuUWdWSGh1TG5ObGJtUmxjaUE5UFNCSGJHOWlZV3d1WTNKbFlYUnZjbDloWkdSeVpYTnpMQ0FpVDI1c2VTQmtaWEJzYjNsbGNpQmpZVzRnYzJWbFpDQndiMjlzSWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1oyeHZZbUZzSUVOeVpXRjBiM0pCWkdSeVpYTnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dWJIa2daR1Z3Ykc5NVpYSWdZMkZ1SUhObFpXUWdjRzl2YkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmx1ZG05cFkyVXZZMjl1ZEhKaFkzUXVjSGs2TmpVS0lDQWdJQzh2SUhCaGVXMWxiblF1Y21WalpXbDJaWElnUFQwZ1IyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3dvZ0lDQWdaSFZ3Q2lBZ0lDQm5kSGh1Y3lCU1pXTmxhWFpsY2dvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJRDA5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhVzUyYjJsalpTOWpiMjUwY21GamRDNXdlVG8yTkMwMk5nb2dJQ0FnTHk4Z1lYTnpaWEowSUNnS0lDQWdJQzh2SUNBZ0lDQndZWGx0Wlc1MExuSmxZMlZwZG1WeUlEMDlJRWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTUtJQ0FnSUM4dklDa3NJQ0pRWVhsdFpXNTBJRzExYzNRZ1oyOGdkRzhnWTI5dWRISmhZM1FpQ2lBZ0lDQmhjM05sY25RZ0x5OGdVR0Y1YldWdWRDQnRkWE4wSUdkdklIUnZJR052Ym5SeVlXTjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNTJiMmxqWlM5amIyNTBjbUZqZEM1d2VUbzJOd29nSUNBZ0x5OGdZWE56WlhKMElIQmhlVzFsYm5RdVlXMXZkVzUwSUQ0Z1ZVbHVkRFkwS0RBcExDQWlVR0Y1YldWdWRDQnRkWE4wSUdKbElIQnZjMmwwYVhabElnb2dJQ0FnWjNSNGJuTWdRVzF2ZFc1MENpQWdJQ0JoYzNObGNuUWdMeThnVUdGNWJXVnVkQ0J0ZFhOMElHSmxJSEJ2YzJsMGFYWmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNTJiMmxqWlM5amIyNTBjbUZqZEM1d2VUbzFOd29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1cGJuWnZhV05sTG1OdmJuUnlZV04wTGtsdWRtOXBZMlV1WjJWMFgzQnZiMnhmWW1Gc1lXNWpaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21kbGRGOXdiMjlzWDJKaGJHRnVZMlU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhVzUyYjJsalpTOWpiMjUwY21GamRDNXdlVG8zTWdvZ0lDQWdMeThnYVdZZ2MyVnNaaTVwWTJOZllYTnpaWFJmYVdRZ1BUMGdWVWx1ZERZMEtEQXBPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltbGpZMTloYzNObGRGOXBaQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1cFkyTmZZWE56WlhSZmFXUWdaWGhwYzNSekNpQWdJQ0JpYm5vZ1oyVjBYM0J2YjJ4ZlltRnNZVzVqWlY5aFpuUmxjbDlwWmw5bGJITmxRRE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBiblp2YVdObEwyTnZiblJ5WVdOMExuQjVPamN6Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdWVWx1ZERZMEtEQXBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb0taMlYwWDNCdmIyeGZZbUZzWVc1alpWOWhablJsY2w5cGJteHBibVZrWDNOdFlYSjBYMk52Ym5SeVlXTjBjeTVwYm5admFXTmxMbU52Ym5SeVlXTjBMa2x1ZG05cFkyVXVaMlYwWDNCdmIyeGZZbUZzWVc1alpVQTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwybHVkbTlwWTJVdlkyOXVkSEpoWTNRdWNIazZOamtLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpJRGdnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbWRsZEY5d2IyOXNYMkpoYkdGdVkyVmZZV1owWlhKZmFXWmZaV3h6WlVBek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsdWRtOXBZMlV2WTI5dWRISmhZM1F1Y0hrNk56UUtJQ0FnSUM4dklISmxkSFZ5YmlCQmMzTmxkQ2h6Wld4bUxtbGpZMTloYzNObGRGOXBaQ2t1WW1Gc1lXNWpaU2hIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpLUW9nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh4SUM4dklDSnBZMk5mWVhOelpYUmZhV1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWFXTmpYMkZ6YzJWMFgybGtJR1Y0YVhOMGN3b2dJQ0FnWVhOelpYUmZhRzlzWkdsdVoxOW5aWFFnUVhOelpYUkNZV3hoYm1ObENpQWdJQ0JoYzNObGNuUWdMeThnWVdOamIzVnVkQ0J2Y0hSbFpDQnBiblJ2SUdGemMyVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNTJiMmxqWlM5amIyNTBjbUZqZEM1d2VUbzJPUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnWWlCblpYUmZjRzl2YkY5aVlXeGhibU5sWDJGbWRHVnlYMmx1YkdsdVpXUmZjMjFoY25SZlkyOXVkSEpoWTNSekxtbHVkbTlwWTJVdVkyOXVkSEpoWTNRdVNXNTJiMmxqWlM1blpYUmZjRzl2YkY5aVlXeGhibU5sUURRS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVhVzUyYjJsalpTNWpiMjUwY21GamRDNUpiblp2YVdObExtTnlaV0YwWlY5cGJuWnZhV05sVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1kzSmxZWFJsWDJsdWRtOXBZMlU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhVzUyYjJsalpTOWpiMjUwY21GamRDNXdlVG80TUFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnWkhWd0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCemQyRndDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwYm5admFXTmxMMk52Ym5SeVlXTjBMbkI1T2pnNUNpQWdJQ0F2THlCaGMzTmxjblFnZEhKMWMzUmZjMk52Y21VZ1BEMGdWVWx1ZERZMEtGTkRRVXhGS1N3Z0luUnlkWE4wWDNOamIzSmxJRzExYzNRZ1ltVWdNQzB4TURBaUNpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdNVEF3Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklIUnlkWE4wWDNOamIzSmxJRzExYzNRZ1ltVWdNQzB4TURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwYm5admFXTmxMMk52Ym5SeVlXTjBMbkI1T2preENpQWdJQ0F2THlCaWIzSnliM2RmYkdsdGFYUWdQU0JoYlc5MWJuUWdLaUIwY25WemRGOXpZMjl5WlNBdkx5QlZTVzUwTmpRb1UwTkJURVVwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmthV2NnTVFvZ0lDQWdLZ29nSUNBZ2NIVnphR2x1ZENBeE1EQUtJQ0FnSUM4S0lDQWdJSE4zWVhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwYm5admFXTmxMMk52Ym5SeVlXTjBMbkI1T2prekNpQWdJQ0F2THlCeWFYTnJJRDBnVTNSeWFXNW5LQ0pJU1VkSUlpa0tJQ0FnSUhCMWMyaGllWFJsY3lBaVNFbEhTQ0lLSUNBZ0lITjNZWEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBiblp2YVdObEwyTnZiblJ5WVdOMExuQjVPamswQ2lBZ0lDQXZMeUJwWmlCMGNuVnpkRjl6WTI5eVpTQStQU0JWU1c1ME5qUW9PREFwT2dvZ0lDQWdjSFZ6YUdsdWRDQTRNQW9nSUNBZ1BqMEtJQ0FnSUdKNklHTnlaV0YwWlY5cGJuWnZhV05sWDJWc2MyVmZZbTlrZVVBekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1MmIybGpaUzlqYjI1MGNtRmpkQzV3ZVRvNU5Rb2dJQ0FnTHk4Z2NtbHpheUE5SUZOMGNtbHVaeWdpVEU5WElpa0tJQ0FnSUhCMWMyaGllWFJsY3lBaVRFOVhJZ29nSUNBZ1luVnllU0F4Q2dwamNtVmhkR1ZmYVc1MmIybGpaVjloWm5SbGNsOXBabDlsYkhObFFEWTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNTJiMmxqWlM5amIyNTBjbUZqZEM1d2VUbzVPUzB4TURZS0lDQWdJQzh2SUhKbGMzVnNkQ0E5SUdsMGVHNHVRWE56WlhSRGIyNW1hV2NvQ2lBZ0lDQXZMeUFnSUNBZ2RHOTBZV3c5TVN3S0lDQWdJQzh2SUNBZ0lDQmtaV05wYldGc2N6MHdMQW9nSUNBZ0x5OGdJQ0FnSUhWdWFYUmZibUZ0WlQwaVNVNVdJaXdLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRjl1WVcxbFBTSkpiblp2YVdObFRrWlVJaXdLSUNBZ0lDOHZJQ0FnSUNCMWNtdzlJbWgwZEhCek9pOHZhVzUyYjJsalpXTm9ZV2x1TG1Gd2NDOXRaWFJoWkdGMFlTTmhjbU16SWl3S0lDQWdJQzh2SUNBZ0lDQnRZVzVoWjJWeVBVZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNc0NpQWdJQ0F2THlBcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhVzUyYjJsalpTOWpiMjUwY21GamRDNXdlVG94TURVS0lDQWdJQzh2SUcxaGJtRm5aWEk5UjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjeXdLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRU52Ym1acFowRnpjMlYwVFdGdVlXZGxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwybHVkbTlwWTJVdlkyOXVkSEpoWTNRdWNIazZNVEEwQ2lBZ0lDQXZMeUIxY213OUltaDBkSEJ6T2k4dmFXNTJiMmxqWldOb1lXbHVMbUZ3Y0M5dFpYUmhaR0YwWVNOaGNtTXpJaXdLSUNBZ0lIQjFjMmhpZVhSbGN5QWlhSFIwY0hNNkx5OXBiblp2YVdObFkyaGhhVzR1WVhCd0wyMWxkR0ZrWVhSaEkyRnlZek1pQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRU52Ym1acFowRnpjMlYwVlZKTUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1MmIybGpaUzlqYjI1MGNtRmpkQzV3ZVRveE1ETUtJQ0FnSUM4dklHRnpjMlYwWDI1aGJXVTlJa2x1ZG05cFkyVk9SbFFpTEFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pKYm5admFXTmxUa1pVSWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JEYjI1bWFXZEJjM05sZEU1aGJXVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cGJuWnZhV05sTDJOdmJuUnlZV04wTG5CNU9qRXdNZ29nSUNBZ0x5OGdkVzVwZEY5dVlXMWxQU0pKVGxZaUxBb2dJQ0FnY0hWemFHSjVkR1Z6SUNKSlRsWWlDaUFnSUNCcGRIaHVYMlpwWld4a0lFTnZibVpwWjBGemMyVjBWVzVwZEU1aGJXVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cGJuWnZhV05sTDJOdmJuUnlZV04wTG5CNU9qRXdNUW9nSUNBZ0x5OGdaR1ZqYVcxaGJITTlNQ3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFTnZibVpwWjBGemMyVjBSR1ZqYVcxaGJITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cGJuWnZhV05sTDJOdmJuUnlZV04wTG5CNU9qRXdNQW9nSUNBZ0x5OGdkRzkwWVd3OU1Td0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0JwZEhodVgyWnBaV3hrSUVOdmJtWnBaMEZ6YzJWMFZHOTBZV3dLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBiblp2YVdObEwyTnZiblJ5WVdOMExuQjVPams1Q2lBZ0lDQXZMeUJ5WlhOMWJIUWdQU0JwZEhodUxrRnpjMlYwUTI5dVptbG5LQW9nSUNBZ2FXNTBZMTh6SUM4dklHRmpabWNLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsdWRtOXBZMlV2WTI5dWRISmhZM1F1Y0hrNk9Ua3RNVEEyQ2lBZ0lDQXZMeUJ5WlhOMWJIUWdQU0JwZEhodUxrRnpjMlYwUTI5dVptbG5LQW9nSUNBZ0x5OGdJQ0FnSUhSdmRHRnNQVEVzQ2lBZ0lDQXZMeUFnSUNBZ1pHVmphVzFoYkhNOU1Dd0tJQ0FnSUM4dklDQWdJQ0IxYm1sMFgyNWhiV1U5SWtsT1ZpSXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUmZibUZ0WlQwaVNXNTJiMmxqWlU1R1ZDSXNDaUFnSUNBdkx5QWdJQ0FnZFhKc1BTSm9kSFJ3Y3pvdkwybHVkbTlwWTJWamFHRnBiaTVoY0hBdmJXVjBZV1JoZEdFallYSmpNeUlzQ2lBZ0lDQXZMeUFnSUNBZ2JXRnVZV2RsY2oxSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TEFvZ0lDQWdMeThnS1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lHbDBlRzRnUTNKbFlYUmxaRUZ6YzJWMFNVUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cGJuWnZhV05sTDJOdmJuUnlZV04wTG5CNU9qRXdPQW9nSUNBZ0x5OGdjMlZzWmk1aGJXOTFiblFnUFNCaGJXOTFiblFLSUNBZ0lHSjVkR1ZqSURrZ0x5OGdJbUZ0YjNWdWRDSUtJQ0FnSUdScFp5QTJDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwybHVkbTlwWTJVdlkyOXVkSEpoWTNRdWNIazZNVEE1Q2lBZ0lDQXZMeUJ6Wld4bUxtUjFaVjlrWVhSbElEMGdaSFZsWDJSaGRHVUtJQ0FnSUdKNWRHVmpJRFVnTHk4Z0ltUjFaVjlrWVhSbElnb2dJQ0FnWkdsbklEVUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNTJiMmxqWlM5amIyNTBjbUZqZEM1d2VUb3hNVEFLSUNBZ0lDOHZJSE5sYkdZdWRISjFjM1JmYzJOdmNtVWdQU0IwY25WemRGOXpZMjl5WlFvZ0lDQWdZbmwwWldNZ01UQWdMeThnSW5SeWRYTjBYM05qYjNKbElnb2dJQ0FnWkdsbklEUUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNTJiMmxqWlM5amIyNTBjbUZqZEM1d2VUb3hNVEVLSUNBZ0lDOHZJSE5sYkdZdWNtbHphMTlzWlhabGJDQTlJSEpwYzJzS0lDQWdJR0o1ZEdWaklERXhJQzh2SUNKeWFYTnJYMnhsZG1Wc0lnb2dJQ0FnWkdsbklESUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNTJiMmxqWlM5amIyNTBjbUZqZEM1d2VUb3hNVElLSUNBZ0lDOHZJSE5sYkdZdVltOXljbTkzWDJ4cGJXbDBJRDBnWW05eWNtOTNYMnhwYldsMENpQWdJQ0JpZVhSbFl5QTJJQzh2SUNKaWIzSnliM2RmYkdsdGFYUWlDaUFnSUNCa2FXY2dNd29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBiblp2YVdObEwyTnZiblJ5WVdOMExuQjVPakV4TXdvZ0lDQWdMeThnYzJWc1ppNXVablJmWVhOelpYUmZhV1FnUFNCeVpYTjFiSFF1WTNKbFlYUmxaRjloYzNObGRDNXBaQW9nSUNBZ1lubDBaV01nTnlBdkx5QWlibVowWDJGemMyVjBYMmxrSWdvZ0lDQWdaR2xuSURFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1MmIybGpaUzlqYjI1MGNtRmpkQzV3ZVRveE1UUUtJQ0FnSUM4dklITmxiR1l1YVhOZlltOXljbTkzWldRZ1BTQkdZV3h6WlFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpYVhOZlltOXljbTkzWldRaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwYm5admFXTmxMMk52Ym5SeVlXTjBMbkI1T2pFeE5Rb2dJQ0FnTHk4Z2MyVnNaaTVpYjNKeWIzZGxaRjloYlc5MWJuUWdQU0JWU1c1ME5qUW9NQ2tLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbUp2Y25KdmQyVmtYMkZ0YjNWdWRDSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsdWRtOXBZMlV2WTI5dWRISmhZM1F1Y0hrNk1URTJDaUFnSUNBdkx5QnpaV3htTG1OdmJHeGhkR1Z5WVd4ZmJHOWphMlZrSUQwZ1JtRnNjMlVLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbU52Ykd4aGRHVnlZV3hmYkc5amEyVmtJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNTJiMmxqWlM5amIyNTBjbUZqZEM1d2VUb3hNVGNLSUNBZ0lDOHZJSE5sYkdZdWMzUmhkSFZ6SUQwZ1UzUnlhVzVuS0NKQlExUkpWa1VpS1FvZ0lDQWdZbmwwWldNZ05DQXZMeUFpYzNSaGRIVnpJZ29nSUNBZ1lubDBaV01nTVRJZ0x5OGdJa0ZEVkVsV1JTSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNTJiMmxqWlM5amIyNTBjbUZqZEM1d2VUbzRNQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV01nT0NBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LWTNKbFlYUmxYMmx1ZG05cFkyVmZaV3h6WlY5aWIyUjVRRE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhVzUyYjJsalpTOWpiMjUwY21GamRDNXdlVG81TmdvZ0lDQWdMeThnWld4cFppQjBjblZ6ZEY5elkyOXlaU0ErUFNCVlNXNTBOalFvTmpBcE9nb2dJQ0FnWkdsbklESUtJQ0FnSUhCMWMyaHBiblFnTmpBS0lDQWdJRDQ5Q2lBZ0lDQmllaUJqY21WaGRHVmZhVzUyYjJsalpWOWhablJsY2w5cFpsOWxiSE5sUURZS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwYm5admFXTmxMMk52Ym5SeVlXTjBMbkI1T2prM0NpQWdJQ0F2THlCeWFYTnJJRDBnVTNSeWFXNW5LQ0pOUlVSSlZVMGlLUW9nSUNBZ2NIVnphR0o1ZEdWeklDSk5SVVJKVlUwaUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdJZ1kzSmxZWFJsWDJsdWRtOXBZMlZmWVdaMFpYSmZhV1pmWld4elpVQTJDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1sdWRtOXBZMlV1WTI5dWRISmhZM1F1U1c1MmIybGpaUzVpYjNKeWIzZGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BpYjNKeWIzYzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNTJiMmxqWlM5amIyNTBjbUZqZEM1d2VUb3hNakVLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwYm5admFXTmxMMk52Ym5SeVlXTjBMbkI1T2pFek13b2dJQ0FnTHk4Z1lYTnpaWEowSUhObGJHWXVhV05qWDJGemMyVjBYMmxrSUQ0Z1ZVbHVkRFkwS0RBcExDQWlTVU5ESUc1dmRDQnBibWwwYVdGc2FYTmxaQ0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh4SUM4dklDSnBZMk5mWVhOelpYUmZhV1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWFXTmpYMkZ6YzJWMFgybGtJR1Y0YVhOMGN3b2dJQ0FnWkhWd0NpQWdJQ0JoYzNObGNuUWdMeThnU1VORElHNXZkQ0JwYm1sMGFXRnNhWE5sWkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmx1ZG05cFkyVXZZMjl1ZEhKaFkzUXVjSGs2TVRNMENpQWdJQ0F2THlCaGMzTmxjblFnYzJWc1ppNXVablJmWVhOelpYUmZhV1FnUGlCVlNXNTBOalFvTUNrc0lDSk9ieUJwYm5admFXTmxJRzFwYm5SbFpDSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTNJQzh2SUNKdVpuUmZZWE56WlhSZmFXUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1Ym1aMFgyRnpjMlYwWDJsa0lHVjRhWE4wY3dvZ0lDQWdZWE56WlhKMElDOHZJRTV2SUdsdWRtOXBZMlVnYldsdWRHVmtDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNTJiMmxqWlM5amIyNTBjbUZqZEM1d2VUb3hNelVLSUNBZ0lDOHZJR0Z6YzJWeWRDQnViM1FnYzJWc1ppNXBjMTlpYjNKeWIzZGxaQ3dnSWtsdWRtOXBZMlVnWVd4eVpXRmtlU0JpYjNKeWIzZGxaQ0JoWjJGcGJuTjBJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltbHpYMkp2Y25KdmQyVmtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1selgySnZjbkp2ZDJWa0lHVjRhWE4wY3dvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFbHVkbTlwWTJVZ1lXeHlaV0ZrZVNCaWIzSnliM2RsWkNCaFoyRnBibk4wQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhVzUyYjJsalpTOWpiMjUwY21GamRDNXdlVG94TXpZS0lDQWdJQzh2SUdGemMyVnlkQ0J1YjNRZ2MyVnNaaTVqYjJ4c1lYUmxjbUZzWDJ4dlkydGxaQ3dnSWtOdmJHeGhkR1Z5WVd3Z1lXeHlaV0ZrZVNCc2IyTnJaV1FpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTWlBdkx5QWlZMjlzYkdGMFpYSmhiRjlzYjJOclpXUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WTI5c2JHRjBaWEpoYkY5c2IyTnJaV1FnWlhocGMzUnpDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnUTI5c2JHRjBaWEpoYkNCaGJISmxZV1I1SUd4dlkydGxaQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwybHVkbTlwWTJVdlkyOXVkSEpoWTNRdWNIazZNVE0zQ2lBZ0lDQXZMeUJoYzNObGNuUWdZbTl5Y205M1gyRnRiM1Z1ZENBOFBTQnpaV3htTG1KdmNuSnZkMTlzYVcxcGRDd2dJa1Y0WTJWbFpITWdZbTl5Y205M0lHeHBiV2wwSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdJbUp2Y25KdmQxOXNhVzFwZENJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWliM0p5YjNkZmJHbHRhWFFnWlhocGMzUnpDaUFnSUNCa2FXY2dNZ29nSUNBZ1BqMEtJQ0FnSUdGemMyVnlkQ0F2THlCRmVHTmxaV1J6SUdKdmNuSnZkeUJzYVcxcGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsdWRtOXBZMlV2WTI5dWRISmhZM1F1Y0hrNk1UTTRDaUFnSUNBdkx5QmhjM05sY25RZ2MyVnNaaTV6ZEdGMGRYTWdQVDBnVTNSeWFXNW5LQ0pCUTFSSlZrVWlLU3dnSWtsdWRtOXBZMlVnYm05MElHRmpkR2wyWlNJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMElDOHZJQ0p6ZEdGMGRYTWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1YzNSaGRIVnpJR1Y0YVhOMGN3b2dJQ0FnWW5sMFpXTWdNVElnTHk4Z0lrRkRWRWxXUlNJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdTVzUyYjJsalpTQnViM1FnWVdOMGFYWmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNTJiMmxqWlM5amIyNTBjbUZqZEM1d2VUb3hOREFLSUNBZ0lDOHZJSEJ2YjJ4ZmFXTmpJRDBnUVhOelpYUW9jMlZzWmk1cFkyTmZZWE56WlhSZmFXUXBMbUpoYkdGdVkyVW9SMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5a0tJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNCa2FXY2dNUW9nSUNBZ1lYTnpaWFJmYUc5c1pHbHVaMTluWlhRZ1FYTnpaWFJDWVd4aGJtTmxDaUFnSUNCaGMzTmxjblFnTHk4Z1lXTmpiM1Z1ZENCdmNIUmxaQ0JwYm5SdklHRnpjMlYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhVzUyYjJsalpTOWpiMjUwY21GamRDNXdlVG94TkRFS0lDQWdJQzh2SUdGemMyVnlkQ0J3YjI5c1gybGpZeUErUFNCaWIzSnliM2RmWVcxdmRXNTBMQ0FpU1c1emRXWm1hV05wWlc1MElFbERReUJwYmlCd2IyOXNJZ29nSUNBZ1pHbG5JRElLSUNBZ0lENDlDaUFnSUNCaGMzTmxjblFnTHk4Z1NXNXpkV1ptYVdOcFpXNTBJRWxEUXlCcGJpQndiMjlzQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhVzUyYjJsalpTOWpiMjUwY21GamRDNXdlVG94TkRNdE1UUTRDaUFnSUNBdkx5QWpJRWx1Ym1WeUlIUjRiam9nYzJWdVpDQkpRME1nZEc4Z2RHaGxJR0p2Y25KdmQyVnlDaUFnSUNBdkx5QnBkSGh1TGtGemMyVjBWSEpoYm5ObVpYSW9DaUFnSUNBdkx5QWdJQ0FnZUdabGNsOWhjM05sZEQxelpXeG1MbWxqWTE5aGMzTmxkRjlwWkN3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5eVpXTmxhWFpsY2oxVWVHNHVjMlZ1WkdWeUxBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFgyRnRiM1Z1ZEQxaWIzSnliM2RmWVcxdmRXNTBMQW9nSUNBZ0x5OGdLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsdWRtOXBZMlV2WTI5dWRISmhZM1F1Y0hrNk1UUTJDaUFnSUNBdkx5QmhjM05sZEY5eVpXTmxhWFpsY2oxVWVHNHVjMlZ1WkdWeUxBb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdaR2xuSURJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhOelpYUkJiVzkxYm5RS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhOelpYUlNaV05sYVhabGNnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCWVptVnlRWE56WlhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwYm5admFXTmxMMk52Ym5SeVlXTjBMbkI1T2pFME15MHhORFFLSUNBZ0lDOHZJQ01nU1c1dVpYSWdkSGh1T2lCelpXNWtJRWxEUXlCMGJ5QjBhR1VnWW05eWNtOTNaWElLSUNBZ0lDOHZJR2wwZUc0dVFYTnpaWFJVY21GdWMyWmxjaWdLSUNBZ0lIQjFjMmhwYm5RZ05DQXZMeUJoZUdabGNnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhVzUyYjJsalpTOWpiMjUwY21GamRDNXdlVG94TkRNdE1UUTRDaUFnSUNBdkx5QWpJRWx1Ym1WeUlIUjRiam9nYzJWdVpDQkpRME1nZEc4Z2RHaGxJR0p2Y25KdmQyVnlDaUFnSUNBdkx5QnBkSGh1TGtGemMyVjBWSEpoYm5ObVpYSW9DaUFnSUNBdkx5QWdJQ0FnZUdabGNsOWhjM05sZEQxelpXeG1MbWxqWTE5aGMzTmxkRjlwWkN3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5eVpXTmxhWFpsY2oxVWVHNHVjMlZ1WkdWeUxBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFgyRnRiM1Z1ZEQxaWIzSnliM2RmWVcxdmRXNTBMQW9nSUNBZ0x5OGdLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cGJuWnZhV05sTDJOdmJuUnlZV04wTG5CNU9qRTFNQW9nSUNBZ0x5OGdjMlZzWmk1cGMxOWliM0p5YjNkbFpDQTlJRlJ5ZFdVS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1selgySnZjbkp2ZDJWa0lnb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1MmIybGpaUzlqYjI1MGNtRmpkQzV3ZVRveE5URUtJQ0FnSUM4dklITmxiR1l1WW05eWNtOTNaV1JmWVcxdmRXNTBJRDBnWW05eWNtOTNYMkZ0YjNWdWRBb2dJQ0FnWW5sMFpXTmZNeUF2THlBaVltOXljbTkzWldSZllXMXZkVzUwSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwYm5admFXTmxMMk52Ym5SeVlXTjBMbkI1T2pFMU1nb2dJQ0FnTHk4Z2MyVnNaaTVqYjJ4c1lYUmxjbUZzWDJ4dlkydGxaQ0E5SUZSeWRXVUtJQ0FnSUdKNWRHVmpYeklnTHk4Z0ltTnZiR3hoZEdWeVlXeGZiRzlqYTJWa0lnb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1MmIybGpaUzlqYjI1MGNtRmpkQzV3ZVRveE1qRUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11YVc1MmIybGpaUzVqYjI1MGNtRmpkQzVKYm5admFXTmxMbkpsY0dGNVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjbVZ3WVhrNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1MmIybGpaUzlqYjI1MGNtRmpkQzV3ZVRveE5UUUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaSFZ3Q2lBZ0lDQm5kSGh1Y3lCVWVYQmxSVzUxYlFvZ0lDQWdjSFZ6YUdsdWRDQTBJQzh2SUdGNFptVnlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUhSeVlXNXpZV04wYVc5dUlIUjVjR1VnYVhNZ1lYaG1aWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBiblp2YVdObEwyTnZiblJ5WVdOMExuQjVPakUyTVFvZ0lDQWdMeThnWVhOelpYSjBJSE5sYkdZdWFYTmZZbTl5Y205M1pXUXNJQ0pPYnlCaFkzUnBkbVVnWW05eWNtOTNJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltbHpYMkp2Y25KdmQyVmtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1selgySnZjbkp2ZDJWa0lHVjRhWE4wY3dvZ0lDQWdZWE56WlhKMElDOHZJRTV2SUdGamRHbDJaU0JpYjNKeWIzY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cGJuWnZhV05sTDJOdmJuUnlZV04wTG5CNU9qRTJNZ29nSUNBZ0x5OGdZWE56WlhKMElHbGpZMTkwY21GdWMyWmxjaTU0Wm1WeVgyRnpjMlYwTG1sa0lEMDlJSE5sYkdZdWFXTmpYMkZ6YzJWMFgybGtMQ0FpVFhWemRDQnlaWEJoZVNCM2FYUm9JRWxEUXlJS0lDQWdJR1IxY0FvZ0lDQWdaM1I0Ym5NZ1dHWmxja0Z6YzJWMENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpYVdOalgyRnpjMlYwWDJsa0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbWxqWTE5aGMzTmxkRjlwWkNCbGVHbHpkSE1LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1RYVnpkQ0J5WlhCaGVTQjNhWFJvSUVsRFF3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsdWRtOXBZMlV2WTI5dWRISmhZM1F1Y0hrNk1UWTBDaUFnSUNBdkx5QnBZMk5mZEhKaGJuTm1aWEl1WVhOelpYUmZjbVZqWldsMlpYSWdQVDBnUjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjd29nSUNBZ1pIVndDaUFnSUNCbmRIaHVjeUJCYzNObGRGSmxZMlZwZG1WeUNpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b2dJQ0FnUFQwS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwYm5admFXTmxMMk52Ym5SeVlXTjBMbkI1T2pFMk15MHhOalVLSUNBZ0lDOHZJR0Z6YzJWeWRDQW9DaUFnSUNBdkx5QWdJQ0FnYVdOalgzUnlZVzV6Wm1WeUxtRnpjMlYwWDNKbFkyVnBkbVZ5SUQwOUlFZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNS0lDQWdJQzh2SUNrc0lDSkpRME1nYlhWemRDQm5ieUIwYnlCamIyNTBjbUZqZENJS0lDQWdJR0Z6YzJWeWRDQXZMeUJKUTBNZ2JYVnpkQ0JuYnlCMGJ5QmpiMjUwY21GamRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsdWRtOXBZMlV2WTI5dWRISmhZM1F1Y0hrNk1UWTJDaUFnSUNBdkx5QmhjM05sY25RZ2FXTmpYM1J5WVc1elptVnlMbUZ6YzJWMFgyRnRiM1Z1ZENBK1BTQnpaV3htTG1KdmNuSnZkMlZrWDJGdGIzVnVkQ3dnSWtsdWMzVm1abWxqYVdWdWRDQnlaWEJoZVcxbGJuUWlDaUFnSUNCbmRIaHVjeUJCYzNObGRFRnRiM1Z1ZEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbUp2Y25KdmQyVmtYMkZ0YjNWdWRDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVpYjNKeWIzZGxaRjloYlc5MWJuUWdaWGhwYzNSekNpQWdJQ0ErUFFvZ0lDQWdZWE56WlhKMElDOHZJRWx1YzNWbVptbGphV1Z1ZENCeVpYQmhlVzFsYm5RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwYm5admFXTmxMMk52Ym5SeVlXTjBMbkI1T2pFMk9Bb2dJQ0FnTHk4Z2MyVnNaaTVwYzE5aWIzSnliM2RsWkNBOUlFWmhiSE5sQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0pwYzE5aWIzSnliM2RsWkNJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmx1ZG05cFkyVXZZMjl1ZEhKaFkzUXVjSGs2TVRZNUNpQWdJQ0F2THlCelpXeG1MbUp2Y25KdmQyVmtYMkZ0YjNWdWRDQTlJRlZKYm5RMk5DZ3dLUW9nSUNBZ1lubDBaV05mTXlBdkx5QWlZbTl5Y205M1pXUmZZVzF2ZFc1MElnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1MmIybGpaUzlqYjI1MGNtRmpkQzV3ZVRveE56QUtJQ0FnSUM4dklITmxiR1l1WTI5c2JHRjBaWEpoYkY5c2IyTnJaV1FnUFNCR1lXeHpaUW9nSUNBZ1lubDBaV05mTWlBdkx5QWlZMjlzYkdGMFpYSmhiRjlzYjJOclpXUWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cGJuWnZhV05sTDJOdmJuUnlZV04wTG5CNU9qRTFOQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1cGJuWnZhV05sTG1OdmJuUnlZV04wTGtsdWRtOXBZMlV1YkdseGRXbGtZWFJsVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2JHbHhkV2xrWVhSbE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsdWRtOXBZMlV2WTI5dWRISmhZM1F1Y0hrNk1UYzVDaUFnSUNBdkx5QmhjM05sY25RZ1ZIaHVMbk5sYm1SbGNpQTlQU0JIYkc5aVlXd3VZM0psWVhSdmNsOWhaR1J5WlhOekxDQWlUMjVzZVNCamNtVmhkRzl5SUdOaGJpQnNhWEYxYVdSaGRHVWlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JuYkc5aVlXd2dRM0psWVhSdmNrRmtaSEpsYzNNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVzZVNCamNtVmhkRzl5SUdOaGJpQnNhWEYxYVdSaGRHVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cGJuWnZhV05sTDJOdmJuUnlZV04wTG5CNU9qRTRNQW9nSUNBZ0x5OGdZWE56WlhKMElITmxiR1l1YVhOZlltOXljbTkzWldRc0lDSk9ieUJoWTNScGRtVWdZbTl5Y205M0lIUnZJR3hwY1hWcFpHRjBaU0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnBjMTlpYjNKeWIzZGxaQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1cGMxOWliM0p5YjNkbFpDQmxlR2x6ZEhNS0lDQWdJR0Z6YzJWeWRDQXZMeUJPYnlCaFkzUnBkbVVnWW05eWNtOTNJSFJ2SUd4cGNYVnBaR0YwWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmx1ZG05cFkyVXZZMjl1ZEhKaFkzUXVjSGs2TVRneENpQWdJQ0F2THlCaGMzTmxjblFnUjJ4dlltRnNMbXhoZEdWemRGOTBhVzFsYzNSaGJYQWdQaUJ6Wld4bUxtUjFaVjlrWVhSbExDQWlTVzUyYjJsalpTQnViM1FnZVdWMElHOTJaWEprZFdVaUNpQWdJQ0JuYkc5aVlXd2dUR0YwWlhOMFZHbHRaWE4wWVcxd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05TQXZMeUFpWkhWbFgyUmhkR1VpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVpIVmxYMlJoZEdVZ1pYaHBjM1J6Q2lBZ0lDQStDaUFnSUNCaGMzTmxjblFnTHk4Z1NXNTJiMmxqWlNCdWIzUWdlV1YwSUc5MlpYSmtkV1VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBiblp2YVdObEwyTnZiblJ5WVdOMExuQjVPakU0TXdvZ0lDQWdMeThnYzJWc1ppNXBjMTlpYjNKeWIzZGxaQ0E5SUVaaGJITmxDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnBjMTlpYjNKeWIzZGxaQ0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwybHVkbTlwWTJVdlkyOXVkSEpoWTNRdWNIazZNVGcwQ2lBZ0lDQXZMeUJ6Wld4bUxtTnZiR3hoZEdWeVlXeGZiRzlqYTJWa0lEMGdSbUZzYzJVS0lDQWdJR0o1ZEdWalh6SWdMeThnSW1OdmJHeGhkR1Z5WVd4ZmJHOWphMlZrSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhVzUyYjJsalpTOWpiMjUwY21GamRDNXdlVG94T0RVS0lDQWdJQzh2SUhObGJHWXVjM1JoZEhWeklEMGdVM1J5YVc1bktDSk1TVkZWU1VSQlZFVkVJaWtLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJbk4wWVhSMWN5SUtJQ0FnSUhCMWMyaGllWFJsY3lBaVRFbFJWVWxFUVZSRlJDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNTJiMmxqWlM5amIyNTBjbUZqZEM1d2VUb3hOeklLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWFXNTJiMmxqWlM1amIyNTBjbUZqZEM1SmJuWnZhV05sTG1kbGRGOXBiblp2YVdObFgybHVabTliY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwblpYUmZhVzUyYjJsalpWOXBibVp2T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmx1ZG05cFkyVXZZMjl1ZEhKaFkzUXVjSGs2TVRrMkNpQWdJQ0F2THlCelpXeG1MbUZ0YjNWdWRDd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTVJQzh2SUNKaGJXOTFiblFpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVlXMXZkVzUwSUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwybHVkbTlwWTJVdlkyOXVkSEpoWTNRdWNIazZNVGszQ2lBZ0lDQXZMeUJ6Wld4bUxtUjFaVjlrWVhSbExBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEVWdMeThnSW1SMVpWOWtZWFJsSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtUjFaVjlrWVhSbElHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmx1ZG05cFkyVXZZMjl1ZEhKaFkzUXVjSGs2TVRrNENpQWdJQ0F2THlCelpXeG1MblJ5ZFhOMFgzTmpiM0psTEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURFd0lDOHZJQ0owY25WemRGOXpZMjl5WlNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNTBjblZ6ZEY5elkyOXlaU0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cGJuWnZhV05sTDJOdmJuUnlZV04wTG5CNU9qRTVPUW9nSUNBZ0x5OGdjMlZzWmk1eWFYTnJYMnhsZG1Wc0xBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklERXhJQzh2SUNKeWFYTnJYMnhsZG1Wc0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbkpwYzJ0ZmJHVjJaV3dnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNTJiMmxqWlM5amIyNTBjbUZqZEM1d2VUb3lNREFLSUNBZ0lDOHZJSE5sYkdZdVltOXljbTkzWDJ4cGJXbDBMQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFlnTHk4Z0ltSnZjbkp2ZDE5c2FXMXBkQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1aWIzSnliM2RmYkdsdGFYUWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1MmIybGpaUzlqYjI1MGNtRmpkQzV3ZVRveU1ERUtJQ0FnSUM4dklITmxiR1l1YVhOZlltOXljbTkzWldRc0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpYVhOZlltOXljbTkzWldRaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVhWE5mWW05eWNtOTNaV1FnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNTJiMmxqWlM5amIyNTBjbUZqZEM1d2VUb3lNRElLSUNBZ0lDOHZJSE5sYkdZdVltOXljbTkzWldSZllXMXZkVzUwTEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbUp2Y25KdmQyVmtYMkZ0YjNWdWRDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVpYjNKeWIzZGxaRjloYlc5MWJuUWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1MmIybGpaUzlqYjI1MGNtRmpkQzV3ZVRveU1ETUtJQ0FnSUM4dklITmxiR1l1Ym1aMFgyRnpjMlYwWDJsa0xBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEY2dMeThnSW01bWRGOWhjM05sZEY5cFpDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV1Wm5SZllYTnpaWFJmYVdRZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhVzUyYjJsalpTOWpiMjUwY21GamRDNXdlVG95TURRS0lDQWdJQzh2SUhObGJHWXVZMjlzYkdGMFpYSmhiRjlzYjJOclpXUXNDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNaUF2THlBaVkyOXNiR0YwWlhKaGJGOXNiMk5yWldRaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZMjlzYkdGMFpYSmhiRjlzYjJOclpXUWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1MmIybGpaUzlqYjI1MGNtRmpkQzV3ZVRveU1EVUtJQ0FnSUM4dklITmxiR1l1YzNSaGRIVnpMQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z0luTjBZWFIxY3lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXpkR0YwZFhNZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhVzUyYjJsalpTOWpiMjUwY21GamRDNXdlVG95TURZS0lDQWdJQzh2SUhObGJHWXVhV05qWDJGemMyVjBYMmxrTEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbWxqWTE5aGMzTmxkRjlwWkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXBZMk5mWVhOelpYUmZhV1FnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNTJiMmxqWlM5amIyNTBjbUZqZEM1d2VUb3hPVEVLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUhWdVkyOTJaWElnTVRBS0lDQWdJR2wwYjJJS0lDQWdJSFZ1WTI5MlpYSWdNVEFLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTVDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUE0Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCMWJtTnZkbVZ5SURrS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQXpaUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElEWXlDaUFnSUNBckNpQWdJQ0IxYm1OdmRtVnlJRGtLSUNBZ0lHbDBiMklLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTVRBS0lDQWdJSE5sZEdKcGRBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURjS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEyQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdkVzVqYjNabGNpQTNDaUFnSUNCelpYUmlhWFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURRS0lDQWdJR3hsYmdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpJRGdnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQUFFSUF5WU5DMmx6WDJKdmNuSnZkMlZrREdsalkxOWhjM05sZEY5cFpCRmpiMnhzWVhSbGNtRnNYMnh2WTJ0bFpBOWliM0p5YjNkbFpGOWhiVzkxYm5RR2MzUmhkSFZ6Q0dSMVpWOWtZWFJsREdKdmNuSnZkMTlzYVcxcGRBeHVablJmWVhOelpYUmZhV1FFRlI5OGRRWmhiVzkxYm5RTGRISjFjM1JmYzJOdmNtVUtjbWx6YTE5c1pYWmxiQVpCUTFSSlZrVXhHRUFBS2lraVp5Y0pJbWNuQlNKbkp3b2laeWNMZ0FCbkp3WWlaeWNISW1jb0ltY3JJbWNxSW1jbkJDY01aekViUVFCSE1Sa1VSREVZUklJSUJCMVdwMm9FaUtEL3JRVEczVGp2Qkt6U0Vkb0UyOWU1M1FUb0VkVzRCRGJhM3dRRTFNK1NsRFlhQUk0SUFBa0Fld0NYQUxNQmtBSHNBaDhDU2dBeEdSUXhHQlFRUXpFQU1na1NSQ0lwWlVRVVJMRXlDa2NEc2l5eUs3SXFzaW1BR0doMGRIQnpPaTh2YVc1MmIybGpaV05vWVdsdUxtRndjTEluZ0JOSmJuWnZhV05sUTJoaGFXNGdRM0psWkdsMHNpYUFBMGxEUTdJbGdRS3lJNEhBaEQyeUlpV3lFQ0t5QWJPMFBDbExBV2NXSndoTVVMQWpRekVXSXdsSk9CQWpFa1F4QURJSkVrUkpPQWN5Q2hKRU9BaEVJME1pS1dWRVFBQUpJaFluQ0V4UXNDTkRNZ29pS1dWRWNBQkVRdi9zTmhvQlNSVWtFa1FYU1RZYUFra1ZKQkpFRjB3MkdnTkpGU1FTUkJkSlRnSkpnV1FPUkV4TEFRdUJaQXBNZ0FSSVNVZElUSUZRRDBFQWpvQURURTlYUlFHeE1ncXlLWUFtYUhSMGNITTZMeTlwYm5admFXTmxZMmhoYVc0dVlYQndMMjFsZEdGa1lYUmhJMkZ5WXpPeUo0QUtTVzUyYjJsalpVNUdWTEltZ0FOSlRsYXlKU0t5SXlPeUlpV3lFQ0t5QWJPMFBDY0pTd1puSndWTEJXY25Da3NFWnljTFN3Sm5Kd1pMQTJjbkIwc0JaeWdpWnlzaVp5b2laeWNFSnd4bkZpY0lURkN3STBOTEFvRThEMEgvY1lBR1RVVkVTVlZOUlFGQy8yUTJHZ0ZKRlNRU1JCY2lLV1ZFU1VRaUp3ZGxSRVFpS0dWRUZFUWlLbVZFRkVRaUp3WmxSRXNDRDBRaUp3UmxSQ2NNRWtReUNrc0JjQUJFU3dJUFJMRXhBRXNDc2hLeUZMSVJnUVN5RUNLeUFiTW9JMmNyVEdjcUkyY2pRekVXSXdsSk9CQ0JCQkpFSWlobFJFUkpPQkVpS1dWRUVrUkpPQlF5Q2hKRU9CSWlLMlZFRDBRb0ltY3JJbWNxSW1jalF6RUFNZ2tTUkNJb1pVUkVNZ2NpSndWbFJBMUVLQ0puS2lKbkp3U0FDa3hKVVZWSlJFRlVSVVJuSTBNaUp3bGxSQ0luQldWRUlpY0taVVFpSnd0bFJDSW5CbVZFSWlobFJDSXJaVVFpSndkbFJDSXFaVVFpSndSbFJDSXBaVVJQQ2haUENoWlFUd2tXVUVzSUZSWlhCZ0pQQ1ZCTWdBSUFQbEJMQVJXQlBnaFBDUlpQQWt4UWdBRUFJazhLVkZCUEJ4WlFUd1lXVUlBQkFDSlBCMVJRU3dRVkZsY0dBazhGVUU4Q0ZsY0dBazhDVEZCUEF4WlFUd0pRVEZBbkNFeFFzQ05EIiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OCwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
