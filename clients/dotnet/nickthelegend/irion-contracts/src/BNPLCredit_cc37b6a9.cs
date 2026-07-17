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

namespace Arc56.Generated.nickthelegend.irion_contracts.BNPLCredit_cc37b6a9
{


    public class BNPLCreditProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public BNPLCreditProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class LoanData : AVMObjectType
            {
                public byte[] Borrower { get; set; }

                public byte[] Merchant { get; set; }

                public ulong Principal { get; set; }

                public ulong TotalRepaid { get; set; }

                public ulong InstallmentAmount { get; set; }

                public ulong NumInstallments { get; set; }

                public ulong InstallmentsPaid { get; set; }

                public ulong StartRound { get; set; }

                public ulong NextDueRound { get; set; }

                public ulong Status { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBorrower = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vBorrower.From(Borrower);
                    ret.AddRange(vBorrower.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMerchant = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vMerchant.From(Merchant);
                    ret.AddRange(vMerchant.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPrincipal = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vPrincipal.From(Principal);
                    ret.AddRange(vPrincipal.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalRepaid = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalRepaid.From(TotalRepaid);
                    ret.AddRange(vTotalRepaid.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vInstallmentAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vInstallmentAmount.From(InstallmentAmount);
                    ret.AddRange(vInstallmentAmount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNumInstallments = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vNumInstallments.From(NumInstallments);
                    ret.AddRange(vNumInstallments.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vInstallmentsPaid = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vInstallmentsPaid.From(InstallmentsPaid);
                    ret.AddRange(vInstallmentsPaid.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStartRound = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vStartRound.From(StartRound);
                    ret.AddRange(vStartRound.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNextDueRound = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vNextDueRound.From(NextDueRound);
                    ret.AddRange(vNextDueRound.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStatus = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vStatus.From(Status);
                    ret.AddRange(vStatus.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static LoanData Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new LoanData();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBorrower = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vBorrower.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBorrower = vBorrower.ToValue();
                    if (valueBorrower is byte[] vBorrowerValue) { ret.Borrower = vBorrowerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMerchant = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vMerchant.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueMerchant = vMerchant.ToValue();
                    if (valueMerchant is byte[] vMerchantValue) { ret.Merchant = vMerchantValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPrincipal = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vPrincipal.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePrincipal = vPrincipal.ToValue();
                    if (valuePrincipal is ulong vPrincipalValue) { ret.Principal = vPrincipalValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalRepaid = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalRepaid.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalRepaid = vTotalRepaid.ToValue();
                    if (valueTotalRepaid is ulong vTotalRepaidValue) { ret.TotalRepaid = vTotalRepaidValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vInstallmentAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vInstallmentAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueInstallmentAmount = vInstallmentAmount.ToValue();
                    if (valueInstallmentAmount is ulong vInstallmentAmountValue) { ret.InstallmentAmount = vInstallmentAmountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNumInstallments = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vNumInstallments.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueNumInstallments = vNumInstallments.ToValue();
                    if (valueNumInstallments is ulong vNumInstallmentsValue) { ret.NumInstallments = vNumInstallmentsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vInstallmentsPaid = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vInstallmentsPaid.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueInstallmentsPaid = vInstallmentsPaid.ToValue();
                    if (valueInstallmentsPaid is ulong vInstallmentsPaidValue) { ret.InstallmentsPaid = vInstallmentsPaidValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStartRound = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vStartRound.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueStartRound = vStartRound.ToValue();
                    if (valueStartRound is ulong vStartRoundValue) { ret.StartRound = vStartRoundValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNextDueRound = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vNextDueRound.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueNextDueRound = vNextDueRound.ToValue();
                    if (valueNextDueRound is ulong vNextDueRoundValue) { ret.NextDueRound = vNextDueRoundValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStatus = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vStatus.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueStatus = vStatus.ToValue();
                    if (valueStatus is ulong vStatusValue) { ret.Status = vStatusValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as LoanData);
                }
                public bool Equals(LoanData? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(LoanData left, LoanData right)
                {
                    return EqualityComparer<LoanData>.Default.Equals(left, right);
                }
                public static bool operator !=(LoanData left, LoanData right)
                {
                    return !(left == right);
                }

            }

            public class GetLoanReturn : AVMObjectType
            {
                public byte[] Field0 { get; set; }

                public byte[] Field1 { get; set; }

                public ulong Field2 { get; set; }

                public ulong Field3 { get; set; }

                public ulong Field4 { get; set; }

                public ulong Field5 { get; set; }

                public ulong Field6 { get; set; }

                public ulong Field7 { get; set; }

                public ulong Field8 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField5 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField5.From(Field5);
                    ret.AddRange(vField5.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField6 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField6.From(Field6);
                    ret.AddRange(vField6.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField7 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField7.From(Field7);
                    ret.AddRange(vField7.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField8 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField8.From(Field8);
                    ret.AddRange(vField8.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static GetLoanReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetLoanReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is byte[] vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is byte[] vField1Value) { ret.Field1 = vField1Value; }
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField5 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField5.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField5 = vField5.ToValue();
                    if (valueField5 is ulong vField5Value) { ret.Field5 = vField5Value; }
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField8 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField8.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField8 = vField8.ToValue();
                    if (valueField8 is ulong vField8Value) { ret.Field8 = vField8Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetLoanReturn);
                }
                public bool Equals(GetLoanReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetLoanReturn left, GetLoanReturn right)
                {
                    return EqualityComparer<GetLoanReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetLoanReturn left, GetLoanReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        public async Task Create(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 76, 92, 97, 186 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 76, 92, 97, 186 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="credit_score_app_id"> </param>
        /// <param name="lending_pool_app_id"> </param>
        /// <param name="asset_id"> </param>
        public async Task Bootstrap(ulong credit_score_app_id, ulong lending_pool_app_id, ulong asset_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 128, 8, 7, 252 };
            var credit_score_app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); credit_score_app_idAbi.From(credit_score_app_id);
            var lending_pool_app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); lending_pool_app_idAbi.From(lending_pool_app_id);
            var asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); asset_idAbi.From(asset_id);

            var result = await base.CallApp(new List<object> { abiHandle, credit_score_app_idAbi, lending_pool_app_idAbi, asset_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Bootstrap_Transactions(ulong credit_score_app_id, ulong lending_pool_app_id, ulong asset_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 128, 8, 7, 252 };
            var credit_score_app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); credit_score_app_idAbi.From(credit_score_app_id);
            var lending_pool_app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); lending_pool_app_idAbi.From(lending_pool_app_id);
            var asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); asset_idAbi.From(asset_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, credit_score_app_idAbi, lending_pool_app_idAbi, asset_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="asset"> </param>
        public async Task OptInToAsset(ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 223, 84, 232, 170 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            var result = await base.CallApp(new List<object> { abiHandle, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> OptInToAsset_Transactions(ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 223, 84, 232, 170 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="merchant"> </param>
        /// <param name="amount"> </param>
        /// <param name="num_installments"> </param>
        public async Task<ulong> InitiateLoan(Algorand.Address merchant, ulong amount, ulong num_installments, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 210, 96, 46, 142 };
            var merchantAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); merchantAbi.From(merchant);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var num_installmentsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); num_installmentsAbi.From(num_installments);

            var result = await base.CallApp(new List<object> { abiHandle, merchantAbi, amountAbi, num_installmentsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> InitiateLoan_Transactions(Algorand.Address merchant, ulong amount, ulong num_installments, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 210, 96, 46, 142 };
            var merchantAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); merchantAbi.From(merchant);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var num_installmentsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); num_installmentsAbi.From(num_installments);

            return await base.MakeTransactionList(new List<object> { abiHandle, merchantAbi, amountAbi, num_installmentsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="loan_id"> </param>
        /// <param name="payment"> </param>
        public async Task MakePayment(AssetTransferTransaction payment, ulong loan_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 60, 65, 54, 71 };
            var loan_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); loan_idAbi.From(loan_id);

            var result = await base.CallApp(new List<object> { abiHandle, loan_idAbi, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> MakePayment_Transactions(AssetTransferTransaction payment, ulong loan_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 60, 65, 54, 71 };
            var loan_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); loan_idAbi.From(loan_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, loan_idAbi, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="loan_id"> </param>
        public async Task DisputeLoan(ulong loan_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 0, 115, 203, 146 };
            var loan_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); loan_idAbi.From(loan_id);

            var result = await base.CallApp(new List<object> { abiHandle, loan_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DisputeLoan_Transactions(ulong loan_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 0, 115, 203, 146 };
            var loan_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); loan_idAbi.From(loan_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, loan_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="loan_id"> </param>
        public async Task LiquidateLoan(ulong loan_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 14, 75, 166, 136 };
            var loan_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); loan_idAbi.From(loan_id);

            var result = await base.CallApp(new List<object> { abiHandle, loan_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> LiquidateLoan_Transactions(ulong loan_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 14, 75, 166, 136 };
            var loan_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); loan_idAbi.From(loan_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, loan_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="loan_id"> </param>
        public async Task<Structs.GetLoanReturn> GetLoan(ulong loan_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 91, 60, 178, 28 };
            var loan_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); loan_idAbi.From(loan_id);

            var result = await base.SimApp(new List<object> { abiHandle, loan_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetLoanReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetLoan_Transactions(ulong loan_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 91, 60, 178, 28 };
            var loan_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); loan_idAbi.From(loan_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, loan_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="user"> </param>
        public async Task<ulong[]> GetUserLoans(Algorand.Address user, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 222, 74, 167, 202 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);

            var result = await base.SimApp(new List<object> { abiHandle, userAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.Value.Select(v => (ulong)v.ToValue()).ToArray();

        }

        public async Task<List<Transaction>> GetUserLoans_Transactions(Algorand.Address user, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 222, 74, 167, 202 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);

            return await base.MakeTransactionList(new List<object> { abiHandle, userAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQk5QTENyZWRpdCIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJMb2FuRGF0YSI6W3sibmFtZSI6ImJvcnJvd2VyIiwidHlwZSI6ImJ5dGVbXSJ9LHsibmFtZSI6Im1lcmNoYW50IiwidHlwZSI6ImJ5dGVbXSJ9LHsibmFtZSI6InByaW5jaXBhbCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ0b3RhbF9yZXBhaWQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiaW5zdGFsbG1lbnRfYW1vdW50IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6Im51bV9pbnN0YWxsbWVudHMiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiaW5zdGFsbG1lbnRzX3BhaWQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoic3RhcnRfcm91bmQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoibmV4dF9kdWVfcm91bmQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoic3RhdHVzIiwidHlwZSI6InVpbnQ2NCJ9XSwiR2V0TG9hblJldHVybiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJieXRlW10ifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoiYnl0ZVtdIn0seyJuYW1lIjoiZmllbGQyIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQ1IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkNiIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDciLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQ4IiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYm9vdHN0cmFwIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNyZWRpdF9zY29yZV9hcHBfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImxlbmRpbmdfcG9vbF9hcHBfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIiwiT3B0SW4iXSwiY2FsbCI6WyJOb09wIiwiT3B0SW4iXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJvcHRfaW5fdG9fYXNzZXQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaW5pdGlhdGVfbG9hbiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoibWVyY2hhbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibnVtX2luc3RhbGxtZW50cyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im1ha2VfcGF5bWVudCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJsb2FuX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJheGZlciIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheW1lbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZGlzcHV0ZV9sb2FuIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImxvYW5faWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibGlxdWlkYXRlX2xvYW4iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibG9hbl9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfbG9hbiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJsb2FuX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6IihieXRlW10sYnl0ZVtdLHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJHZXRMb2FuUmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfdXNlcl9sb2FucyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidXNlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjRbXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6NiwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzM0Ml0sImVycm9yTWVzc2FnZSI6IkFtb3VudCBtdXN0IGJlID4gMCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUzMyw2MDMsOTI4LDk4MSwxMTU2LDEzMzldLCJlcnJvck1lc3NhZ2UiOiJCb3ggbXVzdCBoYXZlIHZhbHVlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzQ0XSwiZXJyb3JNZXNzYWdlIjoiSW5zdGFsbG1lbnRzIG11c3QgYmUgPiAwIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzU1XSwiZXJyb3JNZXNzYWdlIjoiTGVuZGluZyBwb29sIG5vdCBzZXQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MTAsOTM2LDk4OV0sImVycm9yTWVzc2FnZSI6IkxvYW4gbm90IGFjdGl2ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwMDBdLCJlcnJvck1lc3NhZ2UiOiJMb2FuIG5vdCBvdmVyZHVlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzQ5XSwiZXJyb3JNZXNzYWdlIjoiTWF4IDUyIGluc3RhbGxtZW50cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY0M10sImVycm9yTWVzc2FnZSI6Ik11c3QgcGF5IHdpdGggcG9vbCBhc3NldCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzNV0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBtdXN0IGJlIE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMjFdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBvbmUgb2YgTm9PcCwgT3B0SW4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5NTddLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGJvcnJvd2VyIGNhbiBkaXNwdXRlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjMzXSwiZXJyb3JNZXNzYWdlIjoiUGF5bWVudCBtdXN0IGJlIGZyb20gYm9ycm93ZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNTMsMzkxLDQxMiw2NDEsNzE0LDc3Miw3ODgsODUyLDkwMywxMDIwXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgR2xvYmFsU3RhdGUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzIxLDEzMTVdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjMyLDI0MSwyNTAsMjkwLDMyOSwzMzgsNTcxLDkyMCw5NzMsMTA2N10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUzN10sImVycm9yTWVzc2FnZSI6Im1heCBhcnJheSBsZW5ndGggZXhjZWVkZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1ODZdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIGF4ZmVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNQ0E0SURFZ05qQUtJQ0FnSUdKNWRHVmpZbXh2WTJzZ0ltd2lJQ0oxSWlBaWJHVnVaR2x1WjE5d2IyOXNYMkZ3Y0Y5cFpDSWdJbWx1YzNSaGJHeHRaVzUwWDJsdWRHVnlkbUZzSWlBaWJHOWhibDlqYjNWdWRHVnlJaUF3ZURFMU1XWTNZemMxSUNKamNtVmthWFJmYzJOdmNtVmZZWEJ3WDJsa0lpQWlZWE56WlhSZmFXUWlJQ0pzWVhSbFgyWmxaVjlpY0hNaUlEQjRaV0pqWTJJeU5tTUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWJuQnNYMk55WldScGRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUXlDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nUWs1UVRFTnlaV1JwZENCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURnd01EZ3dOMlpqSUM4dklHMWxkR2h2WkNBaVltOXZkSE4wY21Gd0tIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBLWFp2YVdRaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQnRZV2x1WDJKdmIzUnpkSEpoY0Y5eWIzVjBaVUF5Q2dwdFlXbHVYM04zYVhSamFGOWpZWE5sWDI1bGVIUkFNem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWlibkJzWDJOeVpXUnBkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalF5Q2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1FrNVFURU55WldScGRDQmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdiWFZ6ZENCaVpTQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW5vZ2JXRnBibDlqY21WaGRHVmZUbTlQY0VBeE13b2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VHUm1OVFJsT0dGaElEQjRaREkyTURKbE9HVWdNSGd6WXpReE16WTBOeUF3ZURBd056TmpZamt5SURCNE1HVTBZbUUyT0RnZ01IZzFZak5qWWpJeFl5QXdlR1JsTkdGaE4yTmhJQzh2SUcxbGRHaHZaQ0FpYjNCMFgybHVYM1J2WDJGemMyVjBLSFZwYm5RMk5DbDJiMmxrSWl3Z2JXVjBhRzlrSUNKcGJtbDBhV0YwWlY5c2IyRnVLR0ZrWkhKbGMzTXNkV2x1ZERZMExIVnBiblEyTkNsMWFXNTBOalFpTENCdFpYUm9iMlFnSW0xaGEyVmZjR0Y1YldWdWRDaDFhVzUwTmpRc1lYaG1aWElwZG05cFpDSXNJRzFsZEdodlpDQWlaR2x6Y0hWMFpWOXNiMkZ1S0hWcGJuUTJOQ2wyYjJsa0lpd2diV1YwYUc5a0lDSnNhWEYxYVdSaGRHVmZiRzloYmloMWFXNTBOalFwZG05cFpDSXNJRzFsZEdodlpDQWlaMlYwWDJ4dllXNG9kV2x1ZERZMEtTaGllWFJsVzEwc1lubDBaVnRkTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5Da2lMQ0J0WlhSb2IyUWdJbWRsZEY5MWMyVnlYMnh2WVc1ektHRmtaSEpsYzNNcGRXbHVkRFkwVzEwaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQnZjSFJmYVc1ZmRHOWZZWE56WlhRZ2FXNXBkR2xoZEdWZmJHOWhiaUJ0WVd0bFgzQmhlVzFsYm5RZ1pHbHpjSFYwWlY5c2IyRnVJR3hwY1hWcFpHRjBaVjlzYjJGdUlHZGxkRjlzYjJGdUlHZGxkRjkxYzJWeVgyeHZZVzV6Q2lBZ0lDQmxjbklLQ20xaGFXNWZZM0psWVhSbFgwNXZUM0JBTVRNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW01d2JGOWpjbVZrYVhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME1nb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRUpPVUV4RGNtVmthWFFnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGcwWXpWak5qRmlZU0F2THlCdFpYUm9iMlFnSW1OeVpXRjBaU2dwZG05cFpDSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JRzFoYVc1ZlkzSmxZWFJsWDNKdmRYUmxRREUwQ2lBZ0lDQmxjbklLQ20xaGFXNWZZM0psWVhSbFgzSnZkWFJsUURFME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKdWNHeGZZM0psWkdsMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5UTUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJoYkd4dmQwRmpkR2x2Ym5NNklGc25UbTlQY0NkZExDQnZia055WldGMFpUb2dKM0psY1hWcGNtVW5JSDBwQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMkp2YjNSemRISmhjRjl5YjNWMFpVQXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySnVjR3hmWTNKbFpHbDBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVFlLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCaGJHeHZkMEZqZEdsdmJuTTZJRnNuVG05UGNDY3NJQ2RQY0hSSmJpZGRMQ0J2YmtOeVpXRjBaVG9nSjJGc2JHOTNKeUI5S1FvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJSE5vYkFvZ0lDQWdjSFZ6YUdsdWRDQXpJQzh2SURNS0lDQWdJQ1lLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYlhWemRDQmlaU0J2Ym1VZ2IyWWdUbTlQY0N3Z1QzQjBTVzRLSUNBZ0lHSWdZbTl2ZEhOMGNtRndDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKdWNHeGZZM0psWkdsMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rSk9VRXhEY21Wa2FYUXVZbTl2ZEhOMGNtRndXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWW05dmRITjBjbUZ3T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkp1Y0d4ZlkzSmxaR2wwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRZS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2V5QmhiR3h2ZDBGamRHbHZibk02SUZzblRtOVBjQ2NzSUNkUGNIUkpiaWRkTENCdmJrTnlaV0YwWlRvZ0oyRnNiRzkzSnlCOUtRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKdWNHeGZZM0psWkdsMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5ETUtJQ0FnSUM4dklHTnlaV1JwZEY5elkyOXlaVjloY0hCZmFXUWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0NrS0lDQWdJR0o1ZEdWaklEWWdMeThnSW1OeVpXUnBkRjl6WTI5eVpWOWhjSEJmYVdRaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW01d2JGOWpjbVZrYVhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk1nb2dJQ0FnTHk4Z2RHaHBjeTVqY21Wa2FYUmZjMk52Y21WZllYQndYMmxrTG5aaGJIVmxJRDBnWTNKbFpHbDBYM05qYjNKbFgyRndjRjlwWkFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySnVjR3hmWTNKbFpHbDBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORFFLSUNBZ0lDOHZJR3hsYm1ScGJtZGZjRzl2YkY5aGNIQmZhV1FnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tDa0tJQ0FnSUdKNWRHVmpYeklnTHk4Z0lteGxibVJwYm1kZmNHOXZiRjloY0hCZmFXUWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltNXdiRjlqY21Wa2FYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJNd29nSUNBZ0x5OGdkR2hwY3k1c1pXNWthVzVuWDNCdmIyeGZZWEJ3WDJsa0xuWmhiSFZsSUQwZ2JHVnVaR2x1WjE5d2IyOXNYMkZ3Y0Y5cFpBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkp1Y0d4ZlkzSmxaR2wwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRnS0lDQWdJQzh2SUdGemMyVjBYMmxrSUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpZ3BDaUFnSUNCaWVYUmxZeUEzSUM4dklDSmhjM05sZEY5cFpDSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWJuQnNYMk55WldScGRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWTBDaUFnSUNBdkx5QjBhR2x6TG1GemMyVjBYMmxrTG5aaGJIVmxJRDBnWVhOelpYUmZhV1FLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbTV3YkY5amNtVmthWFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTlFvZ0lDQWdMeThnYkc5aGJsOWpiM1Z1ZEdWeUlEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWdwQ2lBZ0lDQmllWFJsWXlBMElDOHZJQ0pzYjJGdVgyTnZkVzUwWlhJaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW01d2JGOWpjbVZrYVhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk5Rb2dJQ0FnTHk4Z2RHaHBjeTVzYjJGdVgyTnZkVzUwWlhJdWRtRnNkV1VnUFNCVmFXNTBOalFvTUNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkp1Y0d4ZlkzSmxaR2wwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRZS0lDQWdJQzh2SUd4aGRHVmZabVZsWDJKd2N5QTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvS1FvZ0lDQWdZbmwwWldNZ09DQXZMeUFpYkdGMFpWOW1aV1ZmWW5Ceklnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKdWNHeGZZM0psWkdsMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5qWUtJQ0FnSUM4dklIUm9hWE11YkdGMFpWOW1aV1ZmWW5CekxuWmhiSFZsSUQwZ1RFRlVSVjlHUlVWZlFsQlRDaUFnSUNCd2RYTm9hVzUwSURJd01DQXZMeUF5TURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW01d2JGOWpjbVZrYVhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME53b2dJQ0FnTHk4Z2FXNXpkR0ZzYkcxbGJuUmZhVzUwWlhKMllXd2dQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0NrS0lDQWdJR0o1ZEdWalh6TWdMeThnSW1sdWMzUmhiR3h0Wlc1MFgybHVkR1Z5ZG1Gc0lnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKdWNHeGZZM0psWkdsMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5qY0tJQ0FnSUM4dklIUm9hWE11YVc1emRHRnNiRzFsYm5SZmFXNTBaWEoyWVd3dWRtRnNkV1VnUFNCSlRsTlVRVXhNVFVWT1ZGOUpUbFJGVWxaQlRGOVNUMVZPUkZNS0lDQWdJSEIxYzJocGJuUWdNVFUzTmpnd01DQXZMeUF4TlRjMk9EQXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySnVjR3hmWTNKbFpHbDBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVFlLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCaGJHeHZkMEZqZEdsdmJuTTZJRnNuVG05UGNDY3NJQ2RQY0hSSmJpZGRMQ0J2YmtOeVpXRjBaVG9nSjJGc2JHOTNKeUI5S1FvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWlibkJzWDJOeVpXUnBkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBDVGxCTVEzSmxaR2wwTG05d2RGOXBibDkwYjE5aGMzTmxkRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q205d2RGOXBibDkwYjE5aGMzTmxkRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWlibkJzWDJOeVpXUnBkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamN3Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWJuQnNYMk55WldScGRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qY3lMVGMzQ2lBZ0lDQXZMeUJwZEhodUxtRnpjMlYwVkhKaGJuTm1aWElvZXdvZ0lDQWdMeThnSUNCNFptVnlRWE56WlhRNklHRnpjMlYwTEFvZ0lDQWdMeThnSUNCaGMzTmxkRUZ0YjNWdWREb2dWV2x1ZERZMEtEQXBMQW9nSUNBZ0x5OGdJQ0JoYzNObGRGSmxZMlZwZG1WeU9pQkhiRzlpWVd3dVkzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ1ptVmxPaUJWYVc1ME5qUW9NQ2tLSUNBZ0lDOHZJSDBwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltNXdiRjlqY21Wa2FYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNOUW9nSUNBZ0x5OGdZWE56WlhSU1pXTmxhWFpsY2pvZ1IyeHZZbUZzTG1OMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01zQ2lBZ0lDQm5iRzlpWVd3Z1EzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYzNObGRGSmxZMlZwZG1WeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW01d2JGOWpjbVZrYVhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM05Bb2dJQ0FnTHk4Z1lYTnpaWFJCYlc5MWJuUTZJRlZwYm5RMk5DZ3dLU3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnpjMlYwUVcxdmRXNTBDaUFnSUNCcGRIaHVYMlpwWld4a0lGaG1aWEpCYzNObGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKdWNHeGZZM0psWkdsMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk56SXROemNLSUNBZ0lDOHZJR2wwZUc0dVlYTnpaWFJVY21GdWMyWmxjaWg3Q2lBZ0lDQXZMeUFnSUhobVpYSkJjM05sZERvZ1lYTnpaWFFzQ2lBZ0lDQXZMeUFnSUdGemMyVjBRVzF2ZFc1ME9pQlZhVzUwTmpRb01Da3NDaUFnSUNBdkx5QWdJR0Z6YzJWMFVtVmpaV2wyWlhJNklFZHNiMkpoYkM1amRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56TEFvZ0lDQWdMeThnSUNCbVpXVTZJRlZwYm5RMk5DZ3dLUW9nSUNBZ0x5OGdmU2t1YzNWaWJXbDBLQ2tLSUNBZ0lIQjFjMmhwYm5RZ05DQXZMeUEwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltNXdiRjlqY21Wa2FYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNOZ29nSUNBZ0x5OGdabVZsT2lCVmFXNTBOalFvTUNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkp1Y0d4ZlkzSmxaR2wwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnpJdE56Y0tJQ0FnSUM4dklHbDBlRzR1WVhOelpYUlVjbUZ1YzJabGNpaDdDaUFnSUNBdkx5QWdJSGhtWlhKQmMzTmxkRG9nWVhOelpYUXNDaUFnSUNBdkx5QWdJR0Z6YzJWMFFXMXZkVzUwT2lCVmFXNTBOalFvTUNrc0NpQWdJQ0F2THlBZ0lHRnpjMlYwVW1WalpXbDJaWEk2SUVkc2IySmhiQzVqZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0JtWldVNklGVnBiblEyTkNnd0tRb2dJQ0FnTHk4Z2ZTa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW01d2JGOWpjbVZrYVhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM01Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKdWNHeGZZM0psWkdsMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rSk9VRXhEY21Wa2FYUXVhVzVwZEdsaGRHVmZiRzloYmx0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtbHVhWFJwWVhSbFgyeHZZVzQ2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbTV3YkY5amNtVmthWFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem80TUFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElETXlJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYm5Cc1gyTnlaV1JwZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pnMkNpQWdJQ0F2THlCaGMzTmxjblFvWVcxdmRXNTBJRDRnVldsdWREWTBLREFwTENBblFXMXZkVzUwSUcxMWMzUWdZbVVnUGlBd0p5a0tJQ0FnSUdScFp5QXhDaUFnSUNCaGMzTmxjblFnTHk4Z1FXMXZkVzUwSUcxMWMzUWdZbVVnUGlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW01d2JGOWpjbVZrYVhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNE53b2dJQ0FnTHk4Z1lYTnpaWEowS0c1MWJWOXBibk4wWVd4c2JXVnVkSE1nUGlCVmFXNTBOalFvTUNrc0lDZEpibk4wWVd4c2JXVnVkSE1nYlhWemRDQmlaU0ErSURBbktRb2dJQ0FnWkhWd0NpQWdJQ0JoYzNObGNuUWdMeThnU1c1emRHRnNiRzFsYm5SeklHMTFjM1FnWW1VZ1BpQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltNXdiRjlqY21Wa2FYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzRPQW9nSUNBZ0x5OGdZWE56WlhKMEtHNTFiVjlwYm5OMFlXeHNiV1Z1ZEhNZ1BEMGdWV2x1ZERZMEtEVXlLU3dnSjAxaGVDQTFNaUJwYm5OMFlXeHNiV1Z1ZEhNbktRb2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb2FXNTBJRFV5SUM4dklEVXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUUxaGVDQTFNaUJwYm5OMFlXeHNiV1Z1ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYm5Cc1gyTnlaV1JwZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2prd0NpQWdJQ0F2THlCamIyNXpkQ0JzWlc1a2FXNW5YM0J2YjJ4ZllYQndPaUIxYVc1ME5qUWdQU0IwYUdsekxteGxibVJwYm1kZmNHOXZiRjloY0hCZmFXUXVkbUZzZFdVS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbTV3YkY5amNtVmthWFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTkFvZ0lDQWdMeThnYkdWdVpHbHVaMTl3YjI5c1gyRndjRjlwWkNBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9LUW9nSUNBZ1lubDBaV05mTWlBdkx5QWliR1Z1WkdsdVoxOXdiMjlzWDJGd2NGOXBaQ0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWlibkJzWDJOeVpXUnBkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamt3Q2lBZ0lDQXZMeUJqYjI1emRDQnNaVzVrYVc1blgzQnZiMnhmWVhCd09pQjFhVzUwTmpRZ1BTQjBhR2x6TG14bGJtUnBibWRmY0c5dmJGOWhjSEJmYVdRdWRtRnNkV1VLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltNXdiRjlqY21Wa2FYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzVNUW9nSUNBZ0x5OGdZWE56WlhKMEtHeGxibVJwYm1kZmNHOXZiRjloY0hBZ1BpQlZhVzUwTmpRb01Da3NJQ2RNWlc1a2FXNW5JSEJ2YjJ3Z2JtOTBJSE5sZENjcENpQWdJQ0JrZFhBS0lDQWdJR0Z6YzJWeWRDQXZMeUJNWlc1a2FXNW5JSEJ2YjJ3Z2JtOTBJSE5sZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkp1Y0d4ZlkzSmxaR2wwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T1RRdE1UQXlDaUFnSUNBdkx5QnBkSGh1TG1Gd2NHeHBZMkYwYVc5dVEyRnNiQ2g3Q2lBZ0lDQXZMeUFnSUdGd2NFbGtPaUJzWlc1a2FXNW5YM0J2YjJ4ZllYQndMQW9nSUNBZ0x5OGdJQ0JoY0hCQmNtZHpPaUJiQ2lBZ0lDQXZMeUFnSUNBZ1ltOXljbTkzWDNObGJHVmpkRzl5TEFvZ0lDQWdMeThnSUNBZ0lFSjVkR1Z6S0dGdGIzVnVkQ2tzQ2lBZ0lDQXZMeUFnSUNBZ1ZIaHVMbk5sYm1SbGNpNWllWFJsY3l3S0lDQWdJQzh2SUNBZ1hTd0tJQ0FnSUM4dklDQWdabVZsT2lCVmFXNTBOalFvTUNrc0NpQWdJQ0F2THlCOUtTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkp1Y0d4ZlkzSmxaR2wwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T1RnS0lDQWdJQzh2SUVKNWRHVnpLR0Z0YjNWdWRDa3NDaUFnSUNCa2FXY2dNZ29nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySnVjR3hmWTNKbFpHbDBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPVGtLSUNBZ0lDOHZJRlI0Ymk1elpXNWtaWEl1WW5sMFpYTXNDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW01d2JGOWpjbVZrYVhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNU53b2dJQ0FnTHk4Z1ltOXljbTkzWDNObGJHVmpkRzl5TEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0T1RsbFkyWTFNVGtnTHk4Z2JXVjBhRzlrSUNKaWIzSnliM2NvZFdsdWREWTBMR0ZrWkhKbGMzTXBkV2x1ZERZMElnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lITjNZWEFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkp1Y0d4ZlkzSmxaR2wwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T1RRdE1UQXlDaUFnSUNBdkx5QnBkSGh1TG1Gd2NHeHBZMkYwYVc5dVEyRnNiQ2g3Q2lBZ0lDQXZMeUFnSUdGd2NFbGtPaUJzWlc1a2FXNW5YM0J2YjJ4ZllYQndMQW9nSUNBZ0x5OGdJQ0JoY0hCQmNtZHpPaUJiQ2lBZ0lDQXZMeUFnSUNBZ1ltOXljbTkzWDNObGJHVmpkRzl5TEFvZ0lDQWdMeThnSUNBZ0lFSjVkR1Z6S0dGdGIzVnVkQ2tzQ2lBZ0lDQXZMeUFnSUNBZ1ZIaHVMbk5sYm1SbGNpNWllWFJsY3l3S0lDQWdJQzh2SUNBZ1hTd0tJQ0FnSUM4dklDQWdabVZsT2lCVmFXNTBOalFvTUNrc0NpQWdJQ0F2THlCOUtTNXpkV0p0YVhRb0tRb2dJQ0FnY0hWemFHbHVkQ0EySUM4dklEWUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYm5Cc1gyTnlaV1JwZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFd01Rb2dJQ0FnTHk4Z1ptVmxPaUJWYVc1ME5qUW9NQ2tzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWlibkJzWDJOeVpXUnBkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamswTFRFd01nb2dJQ0FnTHk4Z2FYUjRiaTVoY0hCc2FXTmhkR2x2YmtOaGJHd29ld29nSUNBZ0x5OGdJQ0JoY0hCSlpEb2diR1Z1WkdsdVoxOXdiMjlzWDJGd2NDd0tJQ0FnSUM4dklDQWdZWEJ3UVhKbmN6b2dXd29nSUNBZ0x5OGdJQ0FnSUdKdmNuSnZkMTl6Wld4bFkzUnZjaXdLSUNBZ0lDOHZJQ0FnSUNCQ2VYUmxjeWhoYlc5MWJuUXBMQW9nSUNBZ0x5OGdJQ0FnSUZSNGJpNXpaVzVrWlhJdVlubDBaWE1zQ2lBZ0lDQXZMeUFnSUYwc0NpQWdJQ0F2THlBZ0lHWmxaVG9nVldsdWREWTBLREFwTEFvZ0lDQWdMeThnZlNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbTV3YkY5amNtVmthWFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TURRS0lDQWdJQzh2SUdOdmJuTjBJRzVsZDE5c2IyRnVYMmxrT2lCMWFXNTBOalFnUFNCMGFHbHpMbXh2WVc1ZlkyOTFiblJsY2k1MllXeDFaU0FySUZWcGJuUTJOQ2d4S1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWlibkJzWDJOeVpXUnBkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalExQ2lBZ0lDQXZMeUJzYjJGdVgyTnZkVzUwWlhJZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLQ2tLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJbXh2WVc1ZlkyOTFiblJsY2lJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYm5Cc1gyTnlaV1JwZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFd05Bb2dJQ0FnTHk4Z1kyOXVjM1FnYm1WM1gyeHZZVzVmYVdRNklIVnBiblEyTkNBOUlIUm9hWE11Ykc5aGJsOWpiM1Z1ZEdWeUxuWmhiSFZsSUNzZ1ZXbHVkRFkwS0RFcENpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lDc0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWJuQnNYMk55WldScGRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUTFDaUFnSUNBdkx5QnNiMkZ1WDJOdmRXNTBaWElnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tDa0tJQ0FnSUdKNWRHVmpJRFFnTHk4Z0lteHZZVzVmWTI5MWJuUmxjaUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWlibkJzWDJOeVpXUnBkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV3TlFvZ0lDQWdMeThnZEdocGN5NXNiMkZ1WDJOdmRXNTBaWEl1ZG1Gc2RXVWdQU0J1WlhkZmJHOWhibDlwWkFvZ0lDQWdaR2xuSURFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW01d2JGOWpjbVZrYVhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1EY0tJQ0FnSUM4dklHTnZibk4wSUdsdWMzUmhiR3h0Wlc1MFgyRnRiM1Z1ZERvZ2RXbHVkRFkwSUQwZ1lXMXZkVzUwSUM4Z2JuVnRYMmx1YzNSaGJHeHRaVzUwY3dvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCa2FXY2dNd29nSUNBZ0x3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKdWNHeGZZM0psWkdsMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1URXdDaUFnSUNBdkx5QmliM0p5YjNkbGNqb2dWSGh1TG5ObGJtUmxjaTVpZVhSbGN5d0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYm5Cc1gyTnlaV1JwZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeE53b2dJQ0FnTHk4Z2MzUmhjblJmY205MWJtUTZJRWRzYjJKaGJDNXliM1Z1WkN3S0lDQWdJR2RzYjJKaGJDQlNiM1Z1WkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkp1Y0d4ZlkzSmxaR2wwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRFNENpQWdJQ0F2THlCdVpYaDBYMlIxWlY5eWIzVnVaRG9nUjJ4dlltRnNMbkp2ZFc1a0lDc2dkR2hwY3k1cGJuTjBZV3hzYldWdWRGOXBiblJsY25aaGJDNTJZV3gxWlN3S0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWlibkJzWDJOeVpXUnBkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalEzQ2lBZ0lDQXZMeUJwYm5OMFlXeHNiV1Z1ZEY5cGJuUmxjblpoYkNBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9LUW9nSUNBZ1lubDBaV05mTXlBdkx5QWlhVzV6ZEdGc2JHMWxiblJmYVc1MFpYSjJZV3dpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbTV3YkY5amNtVmthWFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TVRnS0lDQWdJQzh2SUc1bGVIUmZaSFZsWDNKdmRXNWtPaUJIYkc5aVlXd3VjbTkxYm1RZ0t5QjBhR2x6TG1sdWMzUmhiR3h0Wlc1MFgybHVkR1Z5ZG1Gc0xuWmhiSFZsTEFvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDc0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWJuQnNYMk55WldScGRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXdPUzB4TWpBS0lDQWdJQzh2SUdOdmJuTjBJR3h2WVc0NklFeHZZVzVFWVhSaElEMGdld29nSUNBZ0x5OGdJQ0JpYjNKeWIzZGxjam9nVkhodUxuTmxibVJsY2k1aWVYUmxjeXdLSUNBZ0lDOHZJQ0FnYldWeVkyaGhiblE2SUcxbGNtTm9ZVzUwTG1KNWRHVnpMQW9nSUNBZ0x5OGdJQ0J3Y21sdVkybHdZV3c2SUdGdGIzVnVkQ3dLSUNBZ0lDOHZJQ0FnZEc5MFlXeGZjbVZ3WVdsa09pQlZhVzUwTmpRb01Da3NDaUFnSUNBdkx5QWdJR2x1YzNSaGJHeHRaVzUwWDJGdGIzVnVkQ3dLSUNBZ0lDOHZJQ0FnYm5WdFgybHVjM1JoYkd4dFpXNTBjeXdLSUNBZ0lDOHZJQ0FnYVc1emRHRnNiRzFsYm5SelgzQmhhV1E2SUZWcGJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNBZ2MzUmhjblJmY205MWJtUTZJRWRzYjJKaGJDNXliM1Z1WkN3S0lDQWdJQzh2SUNBZ2JtVjRkRjlrZFdWZmNtOTFibVE2SUVkc2IySmhiQzV5YjNWdVpDQXJJSFJvYVhNdWFXNXpkR0ZzYkcxbGJuUmZhVzUwWlhKMllXd3VkbUZzZFdVc0NpQWdJQ0F2THlBZ0lITjBZWFIxY3pvZ1RFOUJUbDlUVkVGVVZWTmZRVU5VU1ZaRkxBb2dJQ0FnTHk4Z2ZRb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQXlNQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRFk0SUM4dklEWTRDaUFnSUNBckNpQWdJQ0IxYm1OdmRtVnlJRGdLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCMWJtTnZkbVZ5SURrS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd05EUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBM0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWJuQnNYMk55WldScGRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXhNd29nSUNBZ0x5OGdkRzkwWVd4ZmNtVndZV2xrT2lCVmFXNTBOalFvTUNrc0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkp1Y0d4ZlkzSmxaR2wwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRBNUxURXlNQW9nSUNBZ0x5OGdZMjl1YzNRZ2JHOWhiam9nVEc5aGJrUmhkR0VnUFNCN0NpQWdJQ0F2THlBZ0lHSnZjbkp2ZDJWeU9pQlVlRzR1YzJWdVpHVnlMbUo1ZEdWekxBb2dJQ0FnTHk4Z0lDQnRaWEpqYUdGdWREb2diV1Z5WTJoaGJuUXVZbmwwWlhNc0NpQWdJQ0F2THlBZ0lIQnlhVzVqYVhCaGJEb2dZVzF2ZFc1MExBb2dJQ0FnTHk4Z0lDQjBiM1JoYkY5eVpYQmhhV1E2SUZWcGJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNBZ2FXNXpkR0ZzYkcxbGJuUmZZVzF2ZFc1MExBb2dJQ0FnTHk4Z0lDQnVkVzFmYVc1emRHRnNiRzFsYm5SekxBb2dJQ0FnTHk4Z0lDQnBibk4wWVd4c2JXVnVkSE5mY0dGcFpEb2dWV2x1ZERZMEtEQXBMQW9nSUNBZ0x5OGdJQ0J6ZEdGeWRGOXliM1Z1WkRvZ1IyeHZZbUZzTG5KdmRXNWtMQW9nSUNBZ0x5OGdJQ0J1WlhoMFgyUjFaVjl5YjNWdVpEb2dSMnh2WW1Gc0xuSnZkVzVrSUNzZ2RHaHBjeTVwYm5OMFlXeHNiV1Z1ZEY5cGJuUmxjblpoYkM1MllXeDFaU3dLSUNBZ0lDOHZJQ0FnYzNSaGRIVnpPaUJNVDBGT1gxTlVRVlJWVTE5QlExUkpWa1VzQ2lBZ0lDQXZMeUI5Q2lBZ0lDQnBkRzlpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmthV2NnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFlLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTNDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOUW9nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbTV3YkY5amNtVmthWFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TWpJS0lDQWdJQzh2SUhSb2FYTXViRzloYmw5aWIzaGxjeWh1WlhkZmJHOWhibDlwWkNrdWRtRnNkV1VnUFNCamJHOXVaU2hzYjJGdUtRb2dJQ0FnYzNkaGNBb2dJQ0FnYVhSdllnb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltNXdiRjlqY21Wa2FYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFNQW9nSUNBZ0x5OGdiRzloYmw5aWIzaGxjeUE5SUVKdmVFMWhjRHgxYVc1ME5qUXNJRXh2WVc1RVlYUmhQaWg3SUd0bGVWQnlaV1pwZURvZ0oyd25JSDBwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0pzSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW01d2JGOWpjbVZrYVhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1qSUtJQ0FnSUM4dklIUm9hWE11Ykc5aGJsOWliM2hsY3lodVpYZGZiRzloYmw5cFpDa3VkbUZzZFdVZ1BTQmpiRzl1WlNoc2IyRnVLUW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lITjNZWEFLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYm5Cc1gyTnlaV1JwZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVeENpQWdJQ0F2THlCMWMyVnlYMnh2WVc1eklEMGdRbTk0VFdGd1BFRmpZMjkxYm5Rc0lIVnBiblEyTkZ0ZFBpaDdJR3RsZVZCeVpXWnBlRG9nSjNVbklIMHBDaUFnSUNCaWVYUmxZMTh4SUM4dklDSjFJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySnVjR3hmWTNKbFpHbDBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEkwQ2lBZ0lDQXZMeUJwWmlBb0lYUm9hWE11ZFhObGNsOXNiMkZ1Y3loVWVHNHVjMlZ1WkdWeUtTNWxlR2x6ZEhNcElIc0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYm5Cc1gyTnlaV1JwZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVeENpQWdJQ0F2THlCMWMyVnlYMnh2WVc1eklEMGdRbTk0VFdGd1BFRmpZMjkxYm5Rc0lIVnBiblEyTkZ0ZFBpaDdJR3RsZVZCeVpXWnBlRG9nSjNVbklIMHBDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWlibkJzWDJOeVpXUnBkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV5TkFvZ0lDQWdMeThnYVdZZ0tDRjBhR2x6TG5WelpYSmZiRzloYm5Nb1ZIaHVMbk5sYm1SbGNpa3VaWGhwYzNSektTQjdDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0p1ZWlCcGJtbDBhV0YwWlY5c2IyRnVYMlZzYzJWZlltOWtlVUEwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbTV3YkY5amNtVmthWFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TWpVS0lDQWdJQzh2SUhSb2FYTXVkWE5sY2w5c2IyRnVjeWhVZUc0dWMyVnVaR1Z5S1M1MllXeDFaU0E5SUZ0dVpYZGZiRzloYmw5cFpGMEtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdNREVLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYm5Cc1gyTnlaV1JwZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVeENpQWdJQ0F2THlCMWMyVnlYMnh2WVc1eklEMGdRbTk0VFdGd1BFRmpZMjkxYm5Rc0lIVnBiblEyTkZ0ZFBpaDdJR3RsZVZCeVpXWnBlRG9nSjNVbklIMHBDaUFnSUNCaWVYUmxZMTh4SUM4dklDSjFJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySnVjR3hmWTNKbFpHbDBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEkxQ2lBZ0lDQXZMeUIwYUdsekxuVnpaWEpmYkc5aGJuTW9WSGh1TG5ObGJtUmxjaWt1ZG1Gc2RXVWdQU0JiYm1WM1gyeHZZVzVmYVdSZENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbTV3YkY5amNtVmthWFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xTVFvZ0lDQWdMeThnZFhObGNsOXNiMkZ1Y3lBOUlFSnZlRTFoY0R4QlkyTnZkVzUwTENCMWFXNTBOalJiWFQ0b2V5QnJaWGxRY21WbWFYZzZJQ2QxSnlCOUtRb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltNXdiRjlqY21Wa2FYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNalVLSUNBZ0lDOHZJSFJvYVhNdWRYTmxjbDlzYjJGdWN5aFVlRzR1YzJWdVpHVnlLUzUyWVd4MVpTQTlJRnR1WlhkZmJHOWhibDlwWkYwS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0J6ZDJGd0NpQWdJQ0JpYjNoZmNIVjBDZ3BwYm1sMGFXRjBaVjlzYjJGdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYm5Cc1gyTnlaV1JwZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pnd0NpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdKNWRHVmpJRFVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnWkdsbklERUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3BwYm1sMGFXRjBaVjlzYjJGdVgyVnNjMlZmWW05a2VVQTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySnVjR3hmWTNKbFpHbDBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVEVLSUNBZ0lDOHZJSFZ6WlhKZmJHOWhibk1nUFNCQ2IzaE5ZWEE4UVdOamIzVnVkQ3dnZFdsdWREWTBXMTArS0hzZ2EyVjVVSEpsWm1sNE9pQW5kU2NnZlNrS0lDQWdJR0o1ZEdWalh6RWdMeThnSW5VaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW01d2JGOWpjbVZrYVhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1qY0tJQ0FnSUM4dklHTnZibk4wSUdWNGFYTjBhVzVuWDJ4dllXNXpJRDBnWTJ4dmJtVW9kR2hwY3k1MWMyVnlYMnh2WVc1ektGUjRiaTV6Wlc1a1pYSXBMblpoYkhWbEtRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkp1Y0d4ZlkzSmxaR2wwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRFS0lDQWdJQzh2SUhWelpYSmZiRzloYm5NZ1BTQkNiM2hOWVhBOFFXTmpiM1Z1ZEN3Z2RXbHVkRFkwVzEwK0tIc2dhMlY1VUhKbFptbDRPaUFuZFNjZ2ZTa0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySnVjR3hmWTNKbFpHbDBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEkzQ2lBZ0lDQXZMeUJqYjI1emRDQmxlR2x6ZEdsdVoxOXNiMkZ1Y3lBOUlHTnNiMjVsS0hSb2FYTXVkWE5sY2w5c2IyRnVjeWhVZUc0dWMyVnVaR1Z5S1M1MllXeDFaU2tLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJDYjNnZ2JYVnpkQ0JvWVhabElIWmhiSFZsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbTV3YkY5amNtVmthWFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TWpnS0lDQWdJQzh2SUdWNGFYTjBhVzVuWDJ4dllXNXpMbkIxYzJnb2JtVjNYMnh2WVc1ZmFXUXBDaUFnSUNCa2RYQUtJQ0FnSUdScFp5QXlDaUFnSUNCamIyNWpZWFFnTHk4Z2IyNGdaWEp5YjNJNklHMWhlQ0JoY25KaGVTQnNaVzVuZEdnZ1pYaGpaV1ZrWldRS0lDQWdJSE4zWVhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lDc0tJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0J5WlhCc1lXTmxNaUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbTV3YkY5amNtVmthWFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xTVFvZ0lDQWdMeThnZFhObGNsOXNiMkZ1Y3lBOUlFSnZlRTFoY0R4QlkyTnZkVzUwTENCMWFXNTBOalJiWFQ0b2V5QnJaWGxRY21WbWFYZzZJQ2QxSnlCOUtRb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWRTSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWJuQnNYMk55WldScGRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXlPUW9nSUNBZ0x5OGdkR2hwY3k1MWMyVnlYMnh2WVc1ektGUjRiaTV6Wlc1a1pYSXBMblpoYkhWbElEMGdZMnh2Ym1Vb1pYaHBjM1JwYm1kZmJHOWhibk1wQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltNXdiRjlqY21Wa2FYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFNUW9nSUNBZ0x5OGdkWE5sY2w5c2IyRnVjeUE5SUVKdmVFMWhjRHhCWTJOdmRXNTBMQ0IxYVc1ME5qUmJYVDRvZXlCclpYbFFjbVZtYVhnNklDZDFKeUI5S1FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW01d2JGOWpjbVZrYVhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1qa0tJQ0FnSUM4dklIUm9hWE11ZFhObGNsOXNiMkZ1Y3loVWVHNHVjMlZ1WkdWeUtTNTJZV3gxWlNBOUlHTnNiMjVsS0dWNGFYTjBhVzVuWDJ4dllXNXpLUW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lITjNZWEFLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJR0lnYVc1cGRHbGhkR1ZmYkc5aGJsOWhablJsY2w5cFpsOWxiSE5sUURVS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbTV3YkY5amNtVmthWFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82UWs1UVRFTnlaV1JwZEM1dFlXdGxYM0JoZVcxbGJuUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B0WVd0bFgzQmhlVzFsYm5RNkNpQWdJQ0J3ZFhOb1lubDBaWE1nSWlJS0lDQWdJR1IxY0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkp1Y0d4ZlkzSmxaR2wwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRNMUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCa2RYQUtJQ0FnSUdkMGVHNXpJRlI1Y0dWRmJuVnRDaUFnSUNCd2RYTm9hVzUwSURRZ0x5OGdZWGhtWlhJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdkSEpoYm5OaFkzUnBiMjRnZEhsd1pTQnBjeUJoZUdabGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKdWNHeGZZM0psWkdsMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UTTNDaUFnSUNBdkx5QmpiMjV6ZENCc2IyRnVJRDBnWTJ4dmJtVW9kR2hwY3k1c2IyRnVYMkp2ZUdWektHeHZZVzVmYVdRcExuWmhiSFZsS1FvZ0lDQWdjM2RoY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkp1Y0d4ZlkzSmxaR2wwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRBS0lDQWdJQzh2SUd4dllXNWZZbTk0WlhNZ1BTQkNiM2hOWVhBOGRXbHVkRFkwTENCTWIyRnVSR0YwWVQ0b2V5QnJaWGxRY21WbWFYZzZJQ2RzSnlCOUtRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWJDSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbTV3YkY5amNtVmthWFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TXpjS0lDQWdJQzh2SUdOdmJuTjBJR3h2WVc0Z1BTQmpiRzl1WlNoMGFHbHpMbXh2WVc1ZlltOTRaWE1vYkc5aGJsOXBaQ2t1ZG1Gc2RXVXBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lITjNZWEFLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTXdvZ0lDQWdZMjkyWlhJZ05Rb2dJQ0FnWVhOelpYSjBJQzh2SUVKdmVDQnRkWE4wSUdoaGRtVWdkbUZzZFdVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYm5Cc1gyTnlaV1JwZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFek55MHhNemdLSUNBZ0lDOHZJR052Ym5OMElHeHZZVzRnUFNCamJHOXVaU2gwYUdsekxteHZZVzVmWW05NFpYTW9iRzloYmw5cFpDa3VkbUZzZFdVcENpQWdJQ0F2THlCaGMzTmxjblFvYkc5aGJpNXpkR0YwZFhNZ1BUMDlJRXhQUVU1ZlUxUkJWRlZUWDBGRFZFbFdSU3dnSjB4dllXNGdibTkwSUdGamRHbDJaU2NwQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTXlBdkx5QTJNQW9nSUNBZ2FXNTBZMTh4SUM4dklEZ0tJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW01d2JGOWpjbVZrYVhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE16Z0tJQ0FnSUM4dklHRnpjMlZ5ZENoc2IyRnVMbk4wWVhSMWN5QTlQVDBnVEU5QlRsOVRWRUZVVlZOZlFVTlVTVlpGTENBblRHOWhiaUJ1YjNRZ1lXTjBhWFpsSnlrS0lDQWdJR0owYjJrS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5Qk1iMkZ1SUc1dmRDQmhZM1JwZG1VS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYm5Cc1gyTnlaV1JwZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFME1Bb2dJQ0FnTHk4Z2NHRjViV1Z1ZEM1elpXNWtaWEl1WW5sMFpYTWdQVDA5SUd4dllXNHVZbTl5Y205M1pYSXNDaUFnSUNCa2FXY2dNZ29nSUNBZ1ozUjRibk1nVTJWdVpHVnlDaUFnSUNCa2FXY2dNZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCa2FXY2dNd29nSUNBZ2NIVnphR2x1ZENBeUlDOHZJRElLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lITjFZbk4wY21sdVp6TUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0E5UFFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkp1Y0d4ZlkzSmxaR2wwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRNNUxURTBNZ29nSUNBZ0x5OGdZWE56WlhKMEtBb2dJQ0FnTHk4Z0lDQndZWGx0Wlc1MExuTmxibVJsY2k1aWVYUmxjeUE5UFQwZ2JHOWhiaTVpYjNKeWIzZGxjaXdLSUNBZ0lDOHZJQ0FnSjFCaGVXMWxiblFnYlhWemRDQmlaU0JtY205dElHSnZjbkp2ZDJWeUp3b2dJQ0FnTHk4Z0tRb2dJQ0FnWVhOelpYSjBJQzh2SUZCaGVXMWxiblFnYlhWemRDQmlaU0JtY205dElHSnZjbkp2ZDJWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW01d2JGOWpjbVZrYVhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5EUUtJQ0FnSUM4dklHRnpjMlZ5ZENod1lYbHRaVzUwTG5obVpYSkJjM05sZEM1cFpDQTlQVDBnZEdocGN5NWhjM05sZEY5cFpDNTJZV3gxWlN3Z0owMTFjM1FnY0dGNUlIZHBkR2dnY0c5dmJDQmhjM05sZENjcENpQWdJQ0J6ZDJGd0NpQWdJQ0JuZEhodWN5QllabVZ5UVhOelpYUUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW01d2JGOWpjbVZrYVhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME9Bb2dJQ0FnTHk4Z1lYTnpaWFJmYVdRZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLQ2tLSUNBZ0lHSjVkR1ZqSURjZ0x5OGdJbUZ6YzJWMFgybGtJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySnVjR3hmWTNKbFpHbDBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFEwQ2lBZ0lDQXZMeUJoYzNObGNuUW9jR0Y1YldWdWRDNTRabVZ5UVhOelpYUXVhV1FnUFQwOUlIUm9hWE11WVhOelpYUmZhV1F1ZG1Gc2RXVXNJQ2ROZFhOMElIQmhlU0IzYVhSb0lIQnZiMndnWVhOelpYUW5LUW9nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVFhWemRDQndZWGtnZDJsMGFDQndiMjlzSUdGemMyVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltNXdiRjlqY21Wa2FYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hORFlLSUNBZ0lDOHZJR052Ym5OMElIQmhlVzFsYm5SZmNtOTFibVE2SUhWcGJuUTJOQ0E5SUVkc2IySmhiQzV5YjNWdVpBb2dJQ0FnWjJ4dlltRnNJRkp2ZFc1a0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW01d2JGOWpjbVZrYVhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5EY0tJQ0FnSUM4dklHTnZibk4wSUdselgyOXVYM1JwYldVNklHSnZiMnhsWVc0Z1BTQndZWGx0Wlc1MFgzSnZkVzVrSUR3OUlHeHZZVzR1Ym1WNGRGOWtkV1ZmY205MWJtUUtJQ0FnSUhOM1lYQUtJQ0FnSUhCMWMyaHBiblFnTlRJZ0x5OGdOVElLSUNBZ0lHbHVkR05mTVNBdkx5QTRDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnWW5SdmFRb2dJQ0FnUEQwS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYm5Cc1gyTnlaV1JwZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFME9Rb2dJQ0FnTHk4Z2FXWWdLR2x6WDI5dVgzUnBiV1VwSUhzS0lDQWdJR0o2SUcxaGEyVmZjR0Y1YldWdWRGOWxiSE5sWDJKdlpIbEFOd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySnVjR3hmWTNKbFpHbDBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFV3Q2lBZ0lDQXZMeUJzYjJGdUxuUnZkR0ZzWDNKbGNHRnBaQ0E5SUd4dllXNHVkRzkwWVd4ZmNtVndZV2xrSUNzZ2NHRjViV1Z1ZEM1aGMzTmxkRUZ0YjNWdWRBb2dJQ0FnWkdsbklESUtJQ0FnSUhCMWMyaHBiblFnTVRJZ0x5OGdNVElLSUNBZ0lHbHVkR05mTVNBdkx5QTRDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnWW5SdmFRb2dJQ0FnYzNkaGNBb2dJQ0FnWjNSNGJuTWdRWE56WlhSQmJXOTFiblFLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0EyQ2lBZ0lDQXJDaUFnSUNCcGRHOWlDaUFnSUNCa2FXY2dNUW9nSUNBZ2MzZGhjQW9nSUNBZ2NtVndiR0ZqWlRJZ01USUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWJuQnNYMk55WldScGRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTFNUW9nSUNBZ0x5OGdiRzloYmk1cGJuTjBZV3hzYldWdWRITmZjR0ZwWkNBOUlHeHZZVzR1YVc1emRHRnNiRzFsYm5SelgzQmhhV1FnS3lCVmFXNTBOalFvTVNrS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQXpOaUF2THlBek5nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0FyQ2lBZ0lDQnBkRzlpQ2lBZ0lDQnlaWEJzWVdObE1pQXpOZ29nSUNBZ1pIVndDaUFnSUNCaWRYSjVJRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWlibkJzWDJOeVpXUnBkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUxTXdvZ0lDQWdMeThnYVdZZ0tHeHZZVzR1YVc1emRHRnNiRzFsYm5SelgzQmhhV1FnUGowZ2JHOWhiaTV1ZFcxZmFXNXpkR0ZzYkcxbGJuUnpLU0I3Q2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ016WWdMeThnTXpZS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0J6ZDJGd0NpQWdJQ0J3ZFhOb2FXNTBJREk0SUM4dklESTRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1BqMEtJQ0FnSUdKNklHMWhhMlZmY0dGNWJXVnVkRjlsYkhObFgySnZaSGxBTlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkp1Y0d4ZlkzSmxaR2wwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRVMENpQWdJQ0F2THlCc2IyRnVMbk4wWVhSMWN5QTlJRXhQUVU1ZlUxUkJWRlZUWDBOUFRWQk1SVlJGUkFvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lHbDBiMklLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnlaWEJzWVdObE1pQTJNQW9nSUNBZ1pIVndDaUFnSUNCaWRYSjVJRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWlibkJzWDJOeVpXUnBkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUxTmkweE5qQUtJQ0FnSUM4dklHbDBlRzR1WVhCd2JHbGpZWFJwYjI1RFlXeHNLSHNLSUNBZ0lDOHZJQ0FnWVhCd1NXUTZJSFJvYVhNdWJHVnVaR2x1WjE5d2IyOXNYMkZ3Y0Y5cFpDNTJZV3gxWlN3S0lDQWdJQzh2SUNBZ1lYQndRWEpuY3pvZ1czSmxjR0Y1WDNObGJHVmpkRzl5TENCQ2VYUmxjeWh3WVhsdFpXNTBMbUZ6YzJWMFFXMXZkVzUwS1N3Z2JHOWhiaTVpYjNKeWIzZGxjbDBzQ2lBZ0lDQXZMeUFnSUdabFpUb2dWV2x1ZERZMEtEQXBMQW9nSUNBZ0x5OGdmU2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWJuQnNYMk55WldScGRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTFOd29nSUNBZ0x5OGdZWEJ3U1dRNklIUm9hWE11YkdWdVpHbHVaMTl3YjI5c1gyRndjRjlwWkM1MllXeDFaU3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltNXdiRjlqY21Wa2FYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBOQW9nSUNBZ0x5OGdiR1Z1WkdsdVoxOXdiMjlzWDJGd2NGOXBaQ0E5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b0tRb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWJHVnVaR2x1WjE5d2IyOXNYMkZ3Y0Y5cFpDSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWJuQnNYMk55WldScGRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTFOd29nSUNBZ0x5OGdZWEJ3U1dRNklIUm9hWE11YkdWdVpHbHVaMTl3YjI5c1gyRndjRjlwWkM1MllXeDFaU3dLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltNXdiRjlqY21Wa2FYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOVGdLSUNBZ0lDOHZJR0Z3Y0VGeVozTTZJRnR5WlhCaGVWOXpaV3hsWTNSdmNpd2dRbmwwWlhNb2NHRjViV1Z1ZEM1aGMzTmxkRUZ0YjNWdWRDa3NJR3h2WVc0dVltOXljbTkzWlhKZExBb2dJQ0FnWkdsbklEVUtJQ0FnSUdsMGIySUtJQ0FnSUdScFp5QXlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdScFp5QXpDaUFnSUNCd2RYTm9hVzUwSURJZ0x5OGdNZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJR0o1ZEdWaklEa2dMeThnYldWMGFHOWtJQ0p5WlhCaGVTaGhjM05sZEY5MGNtRnVjMlpsY2l4aFpHUnlaWE56S1NJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCemQyRndDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySnVjR3hmWTNKbFpHbDBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFUyTFRFMk1Bb2dJQ0FnTHk4Z2FYUjRiaTVoY0hCc2FXTmhkR2x2YmtOaGJHd29ld29nSUNBZ0x5OGdJQ0JoY0hCSlpEb2dkR2hwY3k1c1pXNWthVzVuWDNCdmIyeGZZWEJ3WDJsa0xuWmhiSFZsTEFvZ0lDQWdMeThnSUNCaGNIQkJjbWR6T2lCYmNtVndZWGxmYzJWc1pXTjBiM0lzSUVKNWRHVnpLSEJoZVcxbGJuUXVZWE56WlhSQmJXOTFiblFwTENCc2IyRnVMbUp2Y25KdmQyVnlYU3dLSUNBZ0lDOHZJQ0FnWm1WbE9pQlZhVzUwTmpRb01Da3NDaUFnSUNBdkx5QjlLUzV6ZFdKdGFYUW9LUW9nSUNBZ2NIVnphR2x1ZENBMklDOHZJRFlLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWJuQnNYMk55WldScGRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTFPUW9nSUNBZ0x5OGdabVZsT2lCVmFXNTBOalFvTUNrc0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYm5Cc1gyTnlaV1JwZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMU5pMHhOakFLSUNBZ0lDOHZJR2wwZUc0dVlYQndiR2xqWVhScGIyNURZV3hzS0hzS0lDQWdJQzh2SUNBZ1lYQndTV1E2SUhSb2FYTXViR1Z1WkdsdVoxOXdiMjlzWDJGd2NGOXBaQzUyWVd4MVpTd0tJQ0FnSUM4dklDQWdZWEJ3UVhKbmN6b2dXM0psY0dGNVgzTmxiR1ZqZEc5eUxDQkNlWFJsY3lod1lYbHRaVzUwTG1GemMyVjBRVzF2ZFc1MEtTd2diRzloYmk1aWIzSnliM2RsY2wwc0NpQWdJQ0F2THlBZ0lHWmxaVG9nVldsdWREWTBLREFwTEFvZ0lDQWdMeThnZlNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2dwdFlXdGxYM0JoZVcxbGJuUmZZV1owWlhKZmFXWmZaV3h6WlVBeE1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWJuQnNYMk55WldScGRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTROUW9nSUNBZ0x5OGdkR2hwY3k1c2IyRnVYMkp2ZUdWektHeHZZVzVmYVdRcExuWmhiSFZsSUQwZ1kyeHZibVVvYkc5aGJpa0tJQ0FnSUdScFp5QXhDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ1pHbG5JREVLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYm5Cc1gyTnlaV1JwZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFek5Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVd0bFgzQmhlVzFsYm5SZlpXeHpaVjlpYjJSNVFEVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltNXdiRjlqY21Wa2FYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOaklLSUNBZ0lDOHZJR3h2WVc0dWJtVjRkRjlrZFdWZmNtOTFibVFnUFNCc2IyRnVMbTVsZUhSZlpIVmxYM0p2ZFc1a0lDc2dkR2hwY3k1cGJuTjBZV3hzYldWdWRGOXBiblJsY25aaGJDNTJZV3gxWlFvZ0lDQWdaSFZ3YmlBeUNpQWdJQ0J3ZFhOb2FXNTBJRFV5SUM4dklEVXlDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWJuQnNYMk55WldScGRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUTNDaUFnSUNBdkx5QnBibk4wWVd4c2JXVnVkRjlwYm5SbGNuWmhiQ0E5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b0tRb2dJQ0FnWW5sMFpXTmZNeUF2THlBaWFXNXpkR0ZzYkcxbGJuUmZhVzUwWlhKMllXd2lDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltNXdiRjlqY21Wa2FYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOaklLSUNBZ0lDOHZJR3h2WVc0dWJtVjRkRjlrZFdWZmNtOTFibVFnUFNCc2IyRnVMbTVsZUhSZlpIVmxYM0p2ZFc1a0lDc2dkR2hwY3k1cGJuTjBZV3hzYldWdWRGOXBiblJsY25aaGJDNTJZV3gxWlFvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDc0tJQ0FnSUdsMGIySUtJQ0FnSUhKbGNHeGhZMlV5SURVeUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdJZ2JXRnJaVjl3WVhsdFpXNTBYMkZtZEdWeVgybG1YMlZzYzJWQU1USUtDbTFoYTJWZmNHRjViV1Z1ZEY5bGJITmxYMkp2WkhsQU56b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWJuQnNYMk55WldScGRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTJOUW9nSUNBZ0x5OGdZMjl1YzNRZ1cyaHBaMmdzSUd4dmQxMGdQU0J2Y0M1dGRXeDNLSEJoZVcxbGJuUXVZWE56WlhSQmJXOTFiblFzSUhSb2FYTXViR0YwWlY5bVpXVmZZbkJ6TG5aaGJIVmxLUW9nSUNBZ1ozUjRibk1nUVhOelpYUkJiVzkxYm5RS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbTV3YkY5amNtVmthWFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTmdvZ0lDQWdMeThnYkdGMFpWOW1aV1ZmWW5CeklEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWdwQ2lBZ0lDQmllWFJsWXlBNElDOHZJQ0pzWVhSbFgyWmxaVjlpY0hNaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW01d2JGOWpjbVZrYVhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5qVUtJQ0FnSUM4dklHTnZibk4wSUZ0b2FXZG9MQ0JzYjNkZElEMGdiM0F1YlhWc2R5aHdZWGx0Wlc1MExtRnpjMlYwUVcxdmRXNTBMQ0IwYUdsekxteGhkR1ZmWm1WbFgySndjeTUyWVd4MVpTa0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYlhWc2R3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKdWNHeGZZM0psWkdsMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UWTJDaUFnSUNBdkx5QmpiMjV6ZENCc1lYUmxYMlpsWlRvZ2RXbHVkRFkwSUQwZ2IzQXVaR2wyZHlob2FXZG9MQ0JzYjNjc0lGVnBiblEyTkNneE1EQXdNQ2twQ2lBZ0lDQndkWE5vYVc1MElERXdNREF3SUM4dklERXdNREF3Q2lBZ0lDQmthWFozQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbTV3YkY5amNtVmthWFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TmpjS0lDQWdJQzh2SUdOdmJuTjBJSFJ2ZEdGc1gzQmhlVzFsYm5RNklIVnBiblEyTkNBOUlIQmhlVzFsYm5RdVlYTnpaWFJCYlc5MWJuUWdLeUJzWVhSbFgyWmxaUW9nSUNBZ0t3b2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlEUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWJuQnNYMk55WldScGRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTJPUW9nSUNBZ0x5OGdiRzloYmk1MGIzUmhiRjl5WlhCaGFXUWdQU0JzYjJGdUxuUnZkR0ZzWDNKbGNHRnBaQ0FySUhSdmRHRnNYM0JoZVcxbGJuUUtJQ0FnSUdScFp5QXlDaUFnSUNCd2RYTm9hVzUwSURFeUlDOHZJREV5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdPQW9nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUdKMGIya0tJQ0FnSUNzS0lDQWdJR2wwYjJJS0lDQWdJR1JwWnlBeENpQWdJQ0J6ZDJGd0NpQWdJQ0J5WlhCc1lXTmxNaUF4TWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkp1Y0d4ZlkzSmxaR2wwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRjd0NpQWdJQ0F2THlCc2IyRnVMbWx1YzNSaGJHeHRaVzUwYzE5d1lXbGtJRDBnYkc5aGJpNXBibk4wWVd4c2JXVnVkSE5mY0dGcFpDQXJJRlZwYm5RMk5DZ3hLUW9nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURNMklDOHZJRE0yQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lDc0tJQ0FnSUdsMGIySUtJQ0FnSUhKbGNHeGhZMlV5SURNMkNpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ01nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKdWNHeGZZM0psWkdsMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UY3lDaUFnSUNBdkx5QnBaaUFvYkc5aGJpNXBibk4wWVd4c2JXVnVkSE5mY0dGcFpDQStQU0JzYjJGdUxtNTFiVjlwYm5OMFlXeHNiV1Z1ZEhNcElIc0tJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0F6TmlBdkx5QXpOZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lITjNZWEFLSUNBZ0lIQjFjMmhwYm5RZ01qZ2dMeThnTWpnS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0ErUFFvZ0lDQWdZbm9nYldGclpWOXdZWGx0Wlc1MFgyVnNjMlZmWW05a2VVQXhNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySnVjR3hmWTNKbFpHbDBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGN6Q2lBZ0lDQXZMeUJzYjJGdUxuTjBZWFIxY3lBOUlFeFBRVTVmVTFSQlZGVlRYME5QVFZCTVJWUkZSQW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUdsMGIySUtJQ0FnSUdScFp5QXhDaUFnSUNCemQyRndDaUFnSUNCeVpYQnNZV05sTWlBMk1Bb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlESUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWJuQnNYMk55WldScGRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTNOUzB4TnprS0lDQWdJQzh2SUdsMGVHNHVZWEJ3YkdsallYUnBiMjVEWVd4c0tIc0tJQ0FnSUM4dklDQWdZWEJ3U1dRNklIUm9hWE11YkdWdVpHbHVaMTl3YjI5c1gyRndjRjlwWkM1MllXeDFaU3dLSUNBZ0lDOHZJQ0FnWVhCd1FYSm5jem9nVzNKbGNHRjVYM05sYkdWamRHOXlMQ0JDZVhSbGN5aDBiM1JoYkY5d1lYbHRaVzUwS1N3Z2JHOWhiaTVpYjNKeWIzZGxjbDBzQ2lBZ0lDQXZMeUFnSUdabFpUb2dWV2x1ZERZMEtEQXBMQW9nSUNBZ0x5OGdmU2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWJuQnNYMk55WldScGRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTNOZ29nSUNBZ0x5OGdZWEJ3U1dRNklIUm9hWE11YkdWdVpHbHVaMTl3YjI5c1gyRndjRjlwWkM1MllXeDFaU3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltNXdiRjlqY21Wa2FYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBOQW9nSUNBZ0x5OGdiR1Z1WkdsdVoxOXdiMjlzWDJGd2NGOXBaQ0E5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b0tRb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWJHVnVaR2x1WjE5d2IyOXNYMkZ3Y0Y5cFpDSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWJuQnNYMk55WldScGRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTNOZ29nSUNBZ0x5OGdZWEJ3U1dRNklIUm9hWE11YkdWdVpHbHVaMTl3YjI5c1gyRndjRjlwWkM1MllXeDFaU3dLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltNXdiRjlqY21Wa2FYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOemNLSUNBZ0lDOHZJR0Z3Y0VGeVozTTZJRnR5WlhCaGVWOXpaV3hsWTNSdmNpd2dRbmwwWlhNb2RHOTBZV3hmY0dGNWJXVnVkQ2tzSUd4dllXNHVZbTl5Y205M1pYSmRMQW9nSUNBZ1pHbG5JRFFLSUNBZ0lHbDBiMklLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lHUnBaeUF6Q2lBZ0lDQndkWE5vYVc1MElESWdMeThnTWdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUdKNWRHVmpJRGtnTHk4Z2JXVjBhRzlrSUNKeVpYQmhlU2hoYzNObGRGOTBjbUZ1YzJabGNpeGhaR1J5WlhOektTSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkp1Y0d4ZlkzSmxaR2wwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRjMUxURTNPUW9nSUNBZ0x5OGdhWFI0Ymk1aGNIQnNhV05oZEdsdmJrTmhiR3dvZXdvZ0lDQWdMeThnSUNCaGNIQkpaRG9nZEdocGN5NXNaVzVrYVc1blgzQnZiMnhmWVhCd1gybGtMblpoYkhWbExBb2dJQ0FnTHk4Z0lDQmhjSEJCY21kek9pQmJjbVZ3WVhsZmMyVnNaV04wYjNJc0lFSjVkR1Z6S0hSdmRHRnNYM0JoZVcxbGJuUXBMQ0JzYjJGdUxtSnZjbkp2ZDJWeVhTd0tJQ0FnSUM4dklDQWdabVZsT2lCVmFXNTBOalFvTUNrc0NpQWdJQ0F2THlCOUtTNXpkV0p0YVhRb0tRb2dJQ0FnY0hWemFHbHVkQ0EySUM4dklEWUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYm5Cc1gyTnlaV1JwZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFM09Bb2dJQ0FnTHk4Z1ptVmxPaUJWYVc1ME5qUW9NQ2tzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWlibkJzWDJOeVpXUnBkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUzTlMweE56a0tJQ0FnSUM4dklHbDBlRzR1WVhCd2JHbGpZWFJwYjI1RFlXeHNLSHNLSUNBZ0lDOHZJQ0FnWVhCd1NXUTZJSFJvYVhNdWJHVnVaR2x1WjE5d2IyOXNYMkZ3Y0Y5cFpDNTJZV3gxWlN3S0lDQWdJQzh2SUNBZ1lYQndRWEpuY3pvZ1czSmxjR0Y1WDNObGJHVmpkRzl5TENCQ2VYUmxjeWgwYjNSaGJGOXdZWGx0Wlc1MEtTd2diRzloYmk1aWIzSnliM2RsY2wwc0NpQWdJQ0F2THlBZ0lHWmxaVG9nVldsdWREWTBLREFwTEFvZ0lDQWdMeThnZlNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQmlJRzFoYTJWZmNHRjViV1Z1ZEY5aFpuUmxjbDlwWmw5bGJITmxRREV5Q2dwdFlXdGxYM0JoZVcxbGJuUmZaV3h6WlY5aWIyUjVRREV3T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkp1Y0d4ZlkzSmxaR2wwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRneENpQWdJQ0F2THlCc2IyRnVMbTVsZUhSZlpIVmxYM0p2ZFc1a0lEMGdiRzloYmk1dVpYaDBYMlIxWlY5eWIzVnVaQ0FySUhSb2FYTXVhVzV6ZEdGc2JHMWxiblJmYVc1MFpYSjJZV3d1ZG1Gc2RXVUtJQ0FnSUdSMWNHNGdNZ29nSUNBZ2NIVnphR2x1ZENBMU1pQXZMeUExTWdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbTV3YkY5amNtVmthWFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTndvZ0lDQWdMeThnYVc1emRHRnNiRzFsYm5SZmFXNTBaWEoyWVd3Z1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLQ2tLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbWx1YzNSaGJHeHRaVzUwWDJsdWRHVnlkbUZzSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkp1Y0d4ZlkzSmxaR2wwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRneENpQWdJQ0F2THlCc2IyRnVMbTVsZUhSZlpIVmxYM0p2ZFc1a0lEMGdiRzloYmk1dVpYaDBYMlIxWlY5eWIzVnVaQ0FySUhSb2FYTXVhVzV6ZEdGc2JHMWxiblJmYVc1MFpYSjJZV3d1ZG1Gc2RXVUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0FyQ2lBZ0lDQnBkRzlpQ2lBZ0lDQnlaWEJzWVdObE1pQTFNZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmlJRzFoYTJWZmNHRjViV1Z1ZEY5aFpuUmxjbDlwWmw5bGJITmxRREV5Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySnVjR3hmWTNKbFpHbDBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPa0pPVUV4RGNtVmthWFF1WkdsemNIVjBaVjlzYjJGdVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taR2x6Y0hWMFpWOXNiMkZ1T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkp1Y0d4ZlkzSmxaR2wwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRnNENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWlibkJzWDJOeVpXUnBkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakU1TUFvZ0lDQWdMeThnWTI5dWMzUWdiRzloYmlBOUlHTnNiMjVsS0hSb2FYTXViRzloYmw5aWIzaGxjeWhzYjJGdVgybGtLUzUyWVd4MVpTa0tJQ0FnSUdsMGIySUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWJuQnNYMk55WldScGRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVXdDaUFnSUNBdkx5QnNiMkZ1WDJKdmVHVnpJRDBnUW05NFRXRndQSFZwYm5RMk5Dd2dURzloYmtSaGRHRStLSHNnYTJWNVVISmxabWw0T2lBbmJDY2dmU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbXdpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYm5Cc1gyTnlaV1JwZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFNU1Bb2dJQ0FnTHk4Z1kyOXVjM1FnYkc5aGJpQTlJR05zYjI1bEtIUm9hWE11Ykc5aGJsOWliM2hsY3loc2IyRnVYMmxrS1M1MllXeDFaU2tLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZWE56WlhKMElDOHZJRUp2ZUNCdGRYTjBJR2hoZG1VZ2RtRnNkV1VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWlibkJzWDJOeVpXUnBkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakU1TUMweE9URUtJQ0FnSUM4dklHTnZibk4wSUd4dllXNGdQU0JqYkc5dVpTaDBhR2x6TG14dllXNWZZbTk0WlhNb2JHOWhibDlwWkNrdWRtRnNkV1VwQ2lBZ0lDQXZMeUJoYzNObGNuUW9iRzloYmk1emRHRjBkWE1nUFQwOUlFeFBRVTVmVTFSQlZGVlRYMEZEVkVsV1JTd2dKMHh2WVc0Z2JtOTBJR0ZqZEdsMlpTY3BDaUFnSUNCa2FXY2dNUW9nSUNBZ2FXNTBZMTh6SUM4dklEWXdDaUFnSUNCcGJuUmpYekVnTHk4Z09Bb2dJQ0FnWW05NFgyVjRkSEpoWTNRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYm5Cc1gyTnlaV1JwZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFNU1Rb2dJQ0FnTHk4Z1lYTnpaWEowS0d4dllXNHVjM1JoZEhWeklEMDlQU0JNVDBGT1gxTlVRVlJWVTE5QlExUkpWa1VzSUNkTWIyRnVJRzV2ZENCaFkzUnBkbVVuS1FvZ0lDQWdZblJ2YVFvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFeHZZVzRnYm05MElHRmpkR2wyWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkp1Y0d4ZlkzSmxaR2wwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRrekNpQWdJQ0F2THlCVWVHNHVjMlZ1WkdWeUxtSjVkR1Z6SUQwOVBTQnNiMkZ1TG1KdmNuSnZkMlZ5TEFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1pHbG5JREVLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ1pHbG5JRElLSUNBZ0lIQjFjMmhwYm5RZ01pQXZMeUF5Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnUFQwS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYm5Cc1gyTnlaV1JwZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFNU1pMHhPVFVLSUNBZ0lDOHZJR0Z6YzJWeWRDZ0tJQ0FnSUM4dklDQWdWSGh1TG5ObGJtUmxjaTVpZVhSbGN5QTlQVDBnYkc5aGJpNWliM0p5YjNkbGNpd0tJQ0FnSUM4dklDQWdKMDl1YkhrZ1ltOXljbTkzWlhJZ1kyRnVJR1JwYzNCMWRHVW5DaUFnSUNBdkx5QXBDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNXNlU0JpYjNKeWIzZGxjaUJqWVc0Z1pHbHpjSFYwWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkp1Y0d4ZlkzSmxaR2wwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRrM0NpQWdJQ0F2THlCc2IyRnVMbk4wWVhSMWN5QTlJRXhQUVU1ZlUxUkJWRlZUWDBSSlUxQlZWRVZFQ2lBZ0lDQndkWE5vYVc1MElETWdMeThnTXdvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkp1Y0d4ZlkzSmxaR2wwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRrM0xURTVPQW9nSUNBZ0x5OGdiRzloYmk1emRHRjBkWE1nUFNCTVQwRk9YMU5VUVZSVlUxOUVTVk5RVlZSRlJBb2dJQ0FnTHk4Z2RHaHBjeTVzYjJGdVgySnZlR1Z6S0d4dllXNWZhV1FwTG5aaGJIVmxJRDBnWTJ4dmJtVW9iRzloYmlrS0lDQWdJR2x1ZEdOZk15QXZMeUEyTUFvZ0lDQWdjM2RoY0FvZ0lDQWdZbTk0WDNKbGNHeGhZMlVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWlibkJzWDJOeVpXUnBkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakU0T0FvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkp1Y0d4ZlkzSmxaR2wwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2tKT1VFeERjbVZrYVhRdWJHbHhkV2xrWVhSbFgyeHZZVzViY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwc2FYRjFhV1JoZEdWZmJHOWhiam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWlibkJzWDJOeVpXUnBkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl3TVFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltNXdiRjlqY21Wa2FYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNRE1LSUNBZ0lDOHZJR052Ym5OMElHeHZZVzRnUFNCamJHOXVaU2gwYUdsekxteHZZVzVmWW05NFpYTW9iRzloYmw5cFpDa3VkbUZzZFdVcENpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW01d2JGOWpjbVZrYVhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU1Bb2dJQ0FnTHk4Z2JHOWhibDlpYjNobGN5QTlJRUp2ZUUxaGNEeDFhVzUwTmpRc0lFeHZZVzVFWVhSaFBpaDdJR3RsZVZCeVpXWnBlRG9nSjJ3bklIMHBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnNJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbTV3YkY5amNtVmthWFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TURNS0lDQWdJQzh2SUdOdmJuTjBJR3h2WVc0Z1BTQmpiRzl1WlNoMGFHbHpMbXh2WVc1ZlltOTRaWE1vYkc5aGJsOXBaQ2t1ZG1Gc2RXVXBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QkNiM2dnYlhWemRDQm9ZWFpsSUhaaGJIVmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltNXdiRjlqY21Wa2FYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNRE10TWpBMENpQWdJQ0F2THlCamIyNXpkQ0JzYjJGdUlEMGdZMnh2Ym1Vb2RHaHBjeTVzYjJGdVgySnZlR1Z6S0d4dllXNWZhV1FwTG5aaGJIVmxLUW9nSUNBZ0x5OGdZWE56WlhKMEtHeHZZVzR1YzNSaGRIVnpJRDA5UFNCTVQwRk9YMU5VUVZSVlUxOUJRMVJKVmtVc0lDZE1iMkZ1SUc1dmRDQmhZM1JwZG1VbktRb2dJQ0FnWkdsbklERUtJQ0FnSUdsdWRHTmZNeUF2THlBMk1Bb2dJQ0FnYVc1MFkxOHhJQzh2SURnS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbTV3YkY5amNtVmthWFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TURRS0lDQWdJQzh2SUdGemMyVnlkQ2hzYjJGdUxuTjBZWFIxY3lBOVBUMGdURTlCVGw5VFZFRlVWVk5mUVVOVVNWWkZMQ0FuVEc5aGJpQnViM1FnWVdOMGFYWmxKeWtLSUNBZ0lHSjBiMmtLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCTWIyRnVJRzV2ZENCaFkzUnBkbVVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWlibkJzWDJOeVpXUnBkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl3TmdvZ0lDQWdMeThnWVhOelpYSjBLRWRzYjJKaGJDNXliM1Z1WkNBK1BTQnNiMkZ1TG01bGVIUmZaSFZsWDNKdmRXNWtMQ0FuVEc5aGJpQnViM1FnYjNabGNtUjFaU2NwQ2lBZ0lDQm5iRzlpWVd3Z1VtOTFibVFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQndkWE5vYVc1MElEVXlJQzh2SURVeUNpQWdJQ0JwYm5Salh6RWdMeThnT0FvZ0lDQWdZbTk0WDJWNGRISmhZM1FLSUNBZ0lHSjBiMmtLSUNBZ0lENDlDaUFnSUNCaGMzTmxjblFnTHk4Z1RHOWhiaUJ1YjNRZ2IzWmxjbVIxWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkp1Y0d4ZlkzSmxaR2wwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpBNENpQWdJQ0F2THlCc2IyRnVMbk4wWVhSMWN5QTlJRXhQUVU1ZlUxUkJWRlZUWDBSRlJrRlZURlJGUkFvZ0lDQWdjSFZ6YUdsdWRDQXlJQzh2SURJS0lDQWdJR2wwYjJJS0lDQWdJSE4zWVhBS0lDQWdJR1JwWnlBeENpQWdJQ0J5WlhCc1lXTmxNaUEyTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkp1Y0d4ZlkzSmxaR2wwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpBNExUSXdPUW9nSUNBZ0x5OGdiRzloYmk1emRHRjBkWE1nUFNCTVQwRk9YMU5VUVZSVlUxOUVSVVpCVlV4VVJVUUtJQ0FnSUM4dklIUm9hWE11Ykc5aGJsOWliM2hsY3loc2IyRnVYMmxrS1M1MllXeDFaU0E5SUdOc2IyNWxLR3h2WVc0cENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHbHVkR05mTXlBdkx5QTJNQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JpYjNoZmNtVndiR0ZqWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkp1Y0d4ZlkzSmxaR2wwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpFeUxUSXhOZ29nSUNBZ0x5OGdhWFI0Ymk1aGNIQnNhV05oZEdsdmJrTmhiR3dvZXdvZ0lDQWdMeThnSUNCaGNIQkpaRG9nZEdocGN5NWpjbVZrYVhSZmMyTnZjbVZmWVhCd1gybGtMblpoYkhWbExBb2dJQ0FnTHk4Z0lDQmhjSEJCY21kek9pQmJaR1ZtWVhWc2RGOXpaV3hsWTNSdmNpd2diRzloYmk1aWIzSnliM2RsY2wwc0NpQWdJQ0F2THlBZ0lHWmxaVG9nVldsdWREWTBLREFwTEFvZ0lDQWdMeThnZlNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWlibkJzWDJOeVpXUnBkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl4TXdvZ0lDQWdMeThnWVhCd1NXUTZJSFJvYVhNdVkzSmxaR2wwWDNOamIzSmxYMkZ3Y0Y5cFpDNTJZV3gxWlN3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbTV3YkY5amNtVmthWFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTXdvZ0lDQWdMeThnWTNKbFpHbDBYM05qYjNKbFgyRndjRjlwWkNBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9LUW9nSUNBZ1lubDBaV01nTmlBdkx5QWlZM0psWkdsMFgzTmpiM0psWDJGd2NGOXBaQ0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWlibkJzWDJOeVpXUnBkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl4TXdvZ0lDQWdMeThnWVhCd1NXUTZJSFJvYVhNdVkzSmxaR2wwWDNOamIzSmxYMkZ3Y0Y5cFpDNTJZV3gxWlN3S0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbTV3YkY5amNtVmthWFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TVRRS0lDQWdJQzh2SUdGd2NFRnlaM002SUZ0a1pXWmhkV3gwWDNObGJHVmpkRzl5TENCc2IyRnVMbUp2Y25KdmQyVnlYU3dLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lHUnBaeUF5Q2lBZ0lDQndkWE5vYVc1MElESWdMeThnTWdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VHUTRaalZrTURNd0lDOHZJRzFsZEdodlpDQWlkWEJrWVhSbFgzTmpiM0psWDI5dVgyUmxabUYxYkhRb1lXUmtjbVZ6Y3lraUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKdWNHeGZZM0psWkdsMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qRXlMVEl4TmdvZ0lDQWdMeThnYVhSNGJpNWhjSEJzYVdOaGRHbHZia05oYkd3b2V3b2dJQ0FnTHk4Z0lDQmhjSEJKWkRvZ2RHaHBjeTVqY21Wa2FYUmZjMk52Y21WZllYQndYMmxrTG5aaGJIVmxMQW9nSUNBZ0x5OGdJQ0JoY0hCQmNtZHpPaUJiWkdWbVlYVnNkRjl6Wld4bFkzUnZjaXdnYkc5aGJpNWliM0p5YjNkbGNsMHNDaUFnSUNBdkx5QWdJR1psWlRvZ1ZXbHVkRFkwS0RBcExBb2dJQ0FnTHk4Z2ZTa3VjM1ZpYldsMEtDa0tJQ0FnSUhCMWMyaHBiblFnTmlBdkx5QTJDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW01d2JGOWpjbVZrYVhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU1UVUtJQ0FnSUM4dklHWmxaVG9nVldsdWREWTBLREFwTEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbTV3YkY5amNtVmthWFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TVRJdE1qRTJDaUFnSUNBdkx5QnBkSGh1TG1Gd2NHeHBZMkYwYVc5dVEyRnNiQ2g3Q2lBZ0lDQXZMeUFnSUdGd2NFbGtPaUIwYUdsekxtTnlaV1JwZEY5elkyOXlaVjloY0hCZmFXUXVkbUZzZFdVc0NpQWdJQ0F2THlBZ0lHRndjRUZ5WjNNNklGdGtaV1poZFd4MFgzTmxiR1ZqZEc5eUxDQnNiMkZ1TG1KdmNuSnZkMlZ5WFN3S0lDQWdJQzh2SUNBZ1ptVmxPaUJWYVc1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUI5S1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWlibkJzWDJOeVpXUnBkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl3TVFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkp1Y0d4ZlkzSmxaR2wwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2tKT1VFeERjbVZrYVhRdVoyVjBYMnh2WVc1YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncG5aWFJmYkc5aGJqb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWJuQnNYMk55WldScGRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSXhPUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUhKbFlXUnZibXg1T2lCMGNuVmxJSDBwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW01d2JGOWpjbVZrYVhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU1qTUtJQ0FnSUM4dklHbG1JQ2doZEdocGN5NXNiMkZ1WDJKdmVHVnpLR3h2WVc1ZmFXUXBMbVY0YVhOMGN5a2dld29nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySnVjR3hmWTNKbFpHbDBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVEFLSUNBZ0lDOHZJR3h2WVc1ZlltOTRaWE1nUFNCQ2IzaE5ZWEE4ZFdsdWREWTBMQ0JNYjJGdVJHRjBZVDRvZXlCclpYbFFjbVZtYVhnNklDZHNKeUI5S1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpYkNJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW01d2JGOWpjbVZrYVhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU1qTUtJQ0FnSUM4dklHbG1JQ2doZEdocGN5NXNiMkZ1WDJKdmVHVnpLR3h2WVc1ZmFXUXBMbVY0YVhOMGN5a2dld29nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JpYm5vZ1oyVjBYMnh2WVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbTV3YkY5amNtVmthWFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TWpRdE1qTTBDaUFnSUNBdkx5QnlaWFIxY200Z1d3b2dJQ0FnTHk4Z0lDQkNlWFJsY3lnbkp5a3NDaUFnSUNBdkx5QWdJRUo1ZEdWektDY25LU3dLSUNBZ0lDOHZJQ0FnVldsdWREWTBLREFwTEFvZ0lDQWdMeThnSUNCVmFXNTBOalFvTUNrc0NpQWdJQ0F2THlBZ0lGVnBiblEyTkNnd0tTd0tJQ0FnSUM4dklDQWdWV2x1ZERZMEtEQXBMQW9nSUNBZ0x5OGdJQ0JWYVc1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFnSUZWcGJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNBZ1ZXbHVkRFkwS0RBcExBb2dJQ0FnTHk4Z1hRb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQXpZekF3TTJVd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtDbWRsZEY5c2IyRnVYMkZtZEdWeVgybHViR2x1WldSZmMyMWhjblJmWTI5dWRISmhZM1J6TDJKdWNHeGZZM0psWkdsMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rSk9VRXhEY21Wa2FYUXVaMlYwWDJ4dllXNUFORG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWlibkJzWDJOeVpXUnBkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl4T1FvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lISmxZV1J2Ym14NU9pQjBjblZsSUgwcENpQWdJQ0JpZVhSbFl5QTFJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncG5aWFJmYkc5aGJsOWhablJsY2w5cFpsOWxiSE5sUURNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW01d2JGOWpjbVZrYVhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU16Y0tJQ0FnSUM4dklHTnZibk4wSUd4dllXNGdQU0JqYkc5dVpTaDBhR2x6TG14dllXNWZZbTk0WlhNb2JHOWhibDlwWkNrdWRtRnNkV1VwQ2lBZ0lDQmtkWEJ1SURJS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdGemMyVnlkQ0F2THlCQ2IzZ2diWFZ6ZENCb1lYWmxJSFpoYkhWbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW01d2JGOWpjbVZrYVhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU16a0tJQ0FnSUM4dklHeHZZVzR1WW05eWNtOTNaWElzQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ1pHbG5JREVLSUNBZ0lIQjFjMmhwYm5RZ01pQXZMeUF5Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdaR2xuSURJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1pHbG5JRElLSUNBZ0lITjFZbk4wY21sdVp6TUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW01d2JGOWpjbVZrYVhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU5EQUtJQ0FnSUM4dklHeHZZVzR1YldWeVkyaGhiblFzQ2lBZ0lDQmthV2NnTWdvZ0lDQWdiR1Z1Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkp1Y0d4ZlkzSmxaR2wwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpReENpQWdJQ0F2THlCc2IyRnVMbkJ5YVc1amFYQmhiQ3dLSUNBZ0lHUnBaeUF5Q2lBZ0lDQndkWE5vYVc1MElEUWdMeThnTkFvZ0lDQWdhVzUwWTE4eElDOHZJRGdLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltNXdiRjlqY21Wa2FYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lORElLSUNBZ0lDOHZJR3h2WVc0dWRHOTBZV3hmY21Wd1lXbGtMQW9nSUNBZ1pHbG5JRE1LSUNBZ0lIQjFjMmhwYm5RZ01USWdMeThnTVRJS0lDQWdJR2x1ZEdOZk1TQXZMeUE0Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySnVjR3hmWTNKbFpHbDBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNalF6Q2lBZ0lDQXZMeUJzYjJGdUxtbHVjM1JoYkd4dFpXNTBYMkZ0YjNWdWRDd0tJQ0FnSUdScFp5QTBDaUFnSUNCd2RYTm9hVzUwSURJd0lDOHZJREl3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdPQW9nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWJuQnNYMk55WldScGRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTBOQW9nSUNBZ0x5OGdiRzloYmk1dWRXMWZhVzV6ZEdGc2JHMWxiblJ6TEFvZ0lDQWdaR2xuSURVS0lDQWdJSEIxYzJocGJuUWdNamdnTHk4Z01qZ0tJQ0FnSUdsdWRHTmZNU0F2THlBNENpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkp1Y0d4ZlkzSmxaR2wwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpRMUNpQWdJQ0F2THlCc2IyRnVMbWx1YzNSaGJHeHRaVzUwYzE5d1lXbGtMQW9nSUNBZ1pHbG5JRFlLSUNBZ0lIQjFjMmhwYm5RZ016WWdMeThnTXpZS0lDQWdJR2x1ZEdOZk1TQXZMeUE0Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySnVjR3hmWTNKbFpHbDBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNalEyQ2lBZ0lDQXZMeUJzYjJGdUxtNWxlSFJmWkhWbFgzSnZkVzVrTEFvZ0lDQWdaR2xuSURjS0lDQWdJSEIxYzJocGJuUWdOVElnTHk4Z05USUtJQ0FnSUdsdWRHTmZNU0F2THlBNENpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkp1Y0d4ZlkzSmxaR2wwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpRM0NpQWdJQ0F2THlCc2IyRnVMbk4wWVhSMWN5d0tJQ0FnSUhWdVkyOTJaWElnT0FvZ0lDQWdhVzUwWTE4eklDOHZJRFl3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdPQW9nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWJuQnNYMk55WldScGRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSXpPQzB5TkRnS0lDQWdJQzh2SUhKbGRIVnliaUJiQ2lBZ0lDQXZMeUFnSUd4dllXNHVZbTl5Y205M1pYSXNDaUFnSUNBdkx5QWdJR3h2WVc0dWJXVnlZMmhoYm5Rc0NpQWdJQ0F2THlBZ0lHeHZZVzR1Y0hKcGJtTnBjR0ZzTEFvZ0lDQWdMeThnSUNCc2IyRnVMblJ2ZEdGc1gzSmxjR0ZwWkN3S0lDQWdJQzh2SUNBZ2JHOWhiaTVwYm5OMFlXeHNiV1Z1ZEY5aGJXOTFiblFzQ2lBZ0lDQXZMeUFnSUd4dllXNHViblZ0WDJsdWMzUmhiR3h0Wlc1MGN5d0tJQ0FnSUM4dklDQWdiRzloYmk1cGJuTjBZV3hzYldWdWRITmZjR0ZwWkN3S0lDQWdJQzh2SUNBZ2JHOWhiaTV1WlhoMFgyUjFaVjl5YjNWdVpDd0tJQ0FnSUM4dklDQWdiRzloYmk1emRHRjBkWE1zQ2lBZ0lDQXZMeUJkQ2lBZ0lDQmthV2NnT0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2RXNWpiM1psY2lBNUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnTmpBS0lDQWdJQ3NLSUNBZ0lHUnBaeUE1Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCMWJtTnZkbVZ5SURFd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01ETmpDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ09Rb2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURnS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEzQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOZ29nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW01d2JGOWpjbVZrYVhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU1Ua0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ1lpQm5aWFJmYkc5aGJsOWhablJsY2w5cGJteHBibVZrWDNOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYm5Cc1gyTnlaV1JwZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwQ1RsQk1RM0psWkdsMExtZGxkRjlzYjJGdVFEUUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW01d2JGOWpjbVZrYVhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlFrNVFURU55WldScGRDNW5aWFJmZFhObGNsOXNiMkZ1YzF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtZGxkRjkxYzJWeVgyeHZZVzV6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkp1Y0d4ZlkzSmxaR2wwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpVeENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2djbVZoWkc5dWJIazZJSFJ5ZFdVZ2ZTa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRE15SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWlibkJzWDJOeVpXUnBkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalV4Q2lBZ0lDQXZMeUIxYzJWeVgyeHZZVzV6SUQwZ1FtOTRUV0Z3UEVGalkyOTFiblFzSUhWcGJuUTJORnRkUGloN0lHdGxlVkJ5WldacGVEb2dKM1VuSUgwcENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKMUlnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWJuQnNYMk55WldScGRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTFNd29nSUNBZ0x5OGdhV1lnS0NGMGFHbHpMblZ6WlhKZmJHOWhibk1vZFhObGNpa3VaWGhwYzNSektTQjdDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0p1ZWlCblpYUmZkWE5sY2w5c2IyRnVjMTloWm5SbGNsOXBabDlsYkhObFFETUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWJuQnNYMk55WldScGRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTFOQW9nSUNBZ0x5OGdjbVYwZFhKdUlGdGRDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNREF3Q2dwblpYUmZkWE5sY2w5c2IyRnVjMTloWm5SbGNsOXBibXhwYm1Wa1gzTnRZWEowWDJOdmJuUnlZV04wY3k5aWJuQnNYMk55WldScGRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcENUbEJNUTNKbFpHbDBMbWRsZEY5MWMyVnlYMnh2WVc1elFEUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltNXdiRjlqY21Wa2FYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lOVEVLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU0I5S1FvZ0lDQWdZbmwwWldNZ05TQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS1oyVjBYM1Z6WlhKZmJHOWhibk5mWVdaMFpYSmZhV1pmWld4elpVQXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySnVjR3hmWTNKbFpHbDBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNalUyQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdkR2hwY3k1MWMyVnlYMnh2WVc1ektIVnpaWElwTG5aaGJIVmxDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QkNiM2dnYlhWemRDQm9ZWFpsSUhaaGJIVmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltNXdiRjlqY21Wa2FYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lOVEVLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU0I5S1FvZ0lDQWdZaUJuWlhSZmRYTmxjbDlzYjJGdWMxOWhablJsY2w5cGJteHBibVZrWDNOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYm5Cc1gyTnlaV1JwZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwQ1RsQk1RM0psWkdsMExtZGxkRjkxYzJWeVgyeHZZVzV6UURRSyIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFBZ0JQQ1lLQVd3QmRSTnNaVzVrYVc1blgzQnZiMnhmWVhCd1gybGtGR2x1YzNSaGJHeHRaVzUwWDJsdWRHVnlkbUZzREd4dllXNWZZMjkxYm5SbGNnUVZIM3gxRTJOeVpXUnBkRjl6WTI5eVpWOWhjSEJmYVdRSVlYTnpaWFJmYVdRTWJHRjBaVjltWldWZlluQnpCT3ZNc215QUJJQUlCL3cyR2dDT0FRQlNNUmtVUkRFWVFRQTVnZ2NFMzFUb3FnVFNZQzZPQkR4Qk5rY0VBSFBMa2dRT1M2YUlCRnM4c2h3RTNrcW55allhQUk0SEFGWUFjd0ZzQXN3REFRTmZCRllBZ0FSTVhHRzZOaG9BamdFQUFRQWtReVF4R1pDQkF4cEVRZ0FBTmhvQlNSVWpFa1FYTmhvQ1NSVWpFa1FYTmhvRFNSVWpFa1FYSndaUEEyY3FUd0puSndkTVp5Y0VJbWNuQ0lISUFXY3JnZUNlWUdja1F6WWFBVWtWSXhKRUY3RXlDcklVSXJJU3NoR0JCTElRSXJJQnN5UkROaG9CU1JWSmdTQVNSRFlhQWtrVkl4SkVGellhQTBrVkl4SkVGMHNCUkVsRVNZRTBEa1FpS21WRVNVU3hTd0lXTVFDQUJKbnM5Um15R2tzQnNocXlHa3l5R0lFR3NoQWlzZ0d6SWljRVpVUWtDQ2NFU3dGblR3TkxBd294QURJR1NTSXJaVVFJZ0FJQUlFOERVRWtWZ1VRSVR3Z1dWd1lDVHdsUVRCWlhCZ0tBQWdCRVRGQlBCMUFpRmt4TEFWQlBCaFpRVHdjV1VFc0JVRThGRmxCUEJCWlFURkJQQWxCTVVFd1dTVTRDS0V4UVNieElUTDhwTVFCUXZVVUJRQUFZZ0FJQUFVc0JVQ2t4QUZCSnZFaE12eWNGU3dGUXNDUkRLVEVBVUw1RVNVc0NVRXdpV1NRSUZsY0dBbHdBS1RFQVVFbThTRXkvUXYvWGdBQkpOaG9CU1JVakVrUVhNUllrQ1VsT0FrazRFSUVFRWtSTUZpaE1VRWxPQTBtK1RFbE9BMDRGUkVrbEk3b1hGRVJMQWpnQVN3SWlXVXNEZ1FKWlR3Uk9BbEpYQWdBU1JFdzRFU0luQjJWRUVrUXlCa3lCTkNPNkZ3NUJBSDVMQW9FTUk3b1hURGdTU1VVR0NCWkxBVXhjREVtQkpGc2tDQlpjSkVsRkFrbUJKRnRNZ1J4YkQwRUFRQ1FXU3dGTVhEeEpSUUt4SWlwbFJFc0ZGa3NDSWxsTEE0RUNXVThFVGdKU1Z3SUFKd215R2t5eUdySWFzaGlCQnJJUUlySUJzMHNCU2J4SVN3Ry9KRU5IQW9FMFd5SXJaVVFJRmx3MFJRRkMvK1E0RWlJbkNHVkVTd0VkZ1pCT2x3aEpSUVJMQW9FTUk3b1hDQlpMQVV4Y0RFbUJKRnNrQ0JaY0pFbEZBa21CSkZ0TWdSeGJEMEVBT1NRV1N3Rk1YRHhKUlFLeElpcGxSRXNFRmtzQ0lsbExBNEVDV1U4RVRnSlNWd0lBSndteUdreXlHcklhc2hpQkJySVFJcklCczBML2MwY0NnVFJiSWl0bFJBZ1dYRFJGQVVML1lUWWFBVWtWSXhKRUZ4WW9URkJKdmtSTEFTVWp1aGNVUkRFQVN3RWlXVXNDZ1FKWlR3Tk9BbEpYQWdBU1JJRURGaVZNdXlSRE5ob0JTUlVqRWtRWEZpaE1VRW0rUkVzQkpTTzZGeFJFTWdaTEFvRTBJN29YRDBTQkFoWk1Td0ZjUEU4Q0pVOER1N0VpSndabFJFc0JJbGxMQW9FQ1dVOERUZ0pTVndJQWdBVFk5ZEF3c2hxeUdySVlnUWF5RUNLeUFiTWtRellhQVVrVkl4SkVGeFlvVEZCSnZVVUJRQUJKZ0VBQVBBQStBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUp3Vk1VTEFrUTBjQ3ZrUkpJbGxMQVlFQ1dVc0NUd0pMQWxKWEFnQkxBaFZQQTA4RFR3SlNWd0lBU3dLQkJDTzZGMHNEZ1F3anVoZExCSUVVSTdvWFN3V0JIQ082RjBzR2dTUWp1aGRMQjRFMEk3b1hUd2dsSTdvWFN3Z1ZGbGNHQWs4SlVFa1ZKUWhMQ1JVV1Z3WUNUd3BRVEJaWEJnS0FBZ0E4VEZCUENSWlFUd2dXVUU4SEZsQlBCaFpRVHdVV1VFOEVGbEJQQXhaUVR3SlFURkJDLzE4MkdnRkpGWUVnRWtRcFRGQkp2VVVCUUFBTGdBSUFBQ2NGVEZDd0pFTkp2a1JDLy9NPSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjMsInBhdGNoIjoyLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
