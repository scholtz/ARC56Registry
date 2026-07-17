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

namespace Arc56.Generated.Krishna050305.parity_squad.LoanContract_958c243f
{


    public class LoanContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public LoanContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class GetLoanInfoReturn : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public ulong Field1 { get; set; }

                public ulong Field2 { get; set; }

                public ulong Field3 { get; set; }

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

                public static GetLoanInfoReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetLoanInfoReturn();
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
                    return Equals(obj as GetLoanInfoReturn);
                }
                public bool Equals(GetLoanInfoReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetLoanInfoReturn left, GetLoanInfoReturn right)
                {
                    return EqualityComparer<GetLoanInfoReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetLoanInfoReturn left, GetLoanInfoReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="goal_amount"> </param>
        /// <param name="duration_days"> </param>
        /// <param name="tier_required"> </param>
        /// <param name="badge_asset"> </param>
        public async Task CreateLoan(ulong goal_amount, ulong duration_days, ulong tier_required, ulong badge_asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 220, 133, 240, 118 };
            var goal_amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); goal_amountAbi.From(goal_amount);
            var duration_daysAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); duration_daysAbi.From(duration_days);
            var tier_requiredAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tier_requiredAbi.From(tier_required);
            var badge_assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); badge_assetAbi.From(badge_asset);

            var result = await base.CallApp(new List<object> { abiHandle, goal_amountAbi, duration_daysAbi, tier_requiredAbi, badge_assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateLoan_Transactions(ulong goal_amount, ulong duration_days, ulong tier_required, ulong badge_asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 220, 133, 240, 118 };
            var goal_amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); goal_amountAbi.From(goal_amount);
            var duration_daysAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); duration_daysAbi.From(duration_days);
            var tier_requiredAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tier_requiredAbi.From(tier_required);
            var badge_assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); badge_assetAbi.From(badge_asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, goal_amountAbi, duration_daysAbi, tier_requiredAbi, badge_assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task OptInToLoan(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 136, 65, 3, 245 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> OptInToLoan_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 136, 65, 3, 245 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="payment"> </param>
        public async Task FundLoan(PaymentTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 74, 205, 147, 157 };

            var result = await base.CallApp(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> FundLoan_Transactions(PaymentTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 74, 205, 147, 157 };

            return await base.MakeTransactionList(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="payment"> </param>
        public async Task RepayLoan(PaymentTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 227, 25, 212, 35 };

            var result = await base.CallApp(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RepayLoan_Transactions(PaymentTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 227, 25, 212, 35 };

            return await base.MakeTransactionList(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task ClaimRepayment(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 251, 32, 105, 122 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ClaimRepayment_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 251, 32, 105, 122 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="guarantor"> </param>
        public async Task AddGuarantor(Algorand.Address guarantor, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 197, 224, 249, 55 };
            var guarantorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); guarantorAbi.From(guarantor);

            var result = await base.CallApp(new List<object> { abiHandle, guarantorAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AddGuarantor_Transactions(Algorand.Address guarantor, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 197, 224, 249, 55 };
            var guarantorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); guarantorAbi.From(guarantor);

            return await base.MakeTransactionList(new List<object> { abiHandle, guarantorAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task MarkDefault(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 86, 174, 110, 203 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> MarkDefault_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 86, 174, 110, 203 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.GetLoanInfoReturn> GetLoanInfo(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 245, 180, 9, 93 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetLoanInfoReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetLoanInfo_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 245, 180, 9, 93 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTG9hbkNvbnRyYWN0IiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkdldExvYW5JbmZvUmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDIiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQzIiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGVfbG9hbiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJnb2FsX2Ftb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZHVyYXRpb25fZGF5cyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidGllcl9yZXF1aXJlZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYmFkZ2VfYXNzZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoib3B0X2luX3RvX2xvYW4iLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJPcHRJbiJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImZ1bmRfbG9hbiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXltZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCIsIk9wdEluIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVwYXlfbG9hbiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXltZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNsYWltX3JlcGF5bWVudCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhZGRfZ3VhcmFudG9yIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJndWFyYW50b3IiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibWFya19kZWZhdWx0IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9sb2FuX2luZm8iLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJHZXRMb2FuSW5mb1JldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjcsImJ5dGVzIjoyfSwibG9jYWwiOnsiaW50cyI6MiwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls2MjddLCJlcnJvck1lc3NhZ2UiOiJBbHJlYWR5IGNsYWltZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyODNdLCJlcnJvck1lc3NhZ2UiOiJCb3Jyb3dlciBkb2VzIG5vdCBob2xkIHRoZSByZXF1aXJlZCB0aWVyIGJhZGdlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjgyXSwiZXJyb3JNZXNzYWdlIjoiQm9ycm93ZXIgbm90IG9wdGVkIGludG8gYmFkZ2UiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3MDhdLCJlcnJvck1lc3NhZ2UiOiJEZWFkbGluZSBub3QgcGFzc2VkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDU5XSwiZXJyb3JNZXNzYWdlIjoiRnVuZGluZyBkZWFkbGluZSBwYXNzZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNTddLCJlcnJvck1lc3NhZ2UiOiJJbnZhbGlkIHRpZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MDJdLCJlcnJvck1lc3NhZ2UiOiJMb2FuIGlzIG5vdCBDTE9TRUQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NTBdLCJlcnJvck1lc3NhZ2UiOiJMb2FuIGlzIG5vdCBPUEVOIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTUzXSwiZXJyb3JNZXNzYWdlIjoiTG9hbiBpcyBub3QgUkVQQVlJTkciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2NzhdLCJlcnJvck1lc3NhZ2UiOiJMb2FuIG11c3QgYmUgT1BFTiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY5OV0sImVycm9yTWVzc2FnZSI6IkxvYW4gbXVzdCBiZSBSRVBBWUlORyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYyNV0sImVycm9yTWVzc2FnZSI6Ik5vIGNvbnRyaWJ1dGlvbiBmb3VuZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY4Nl0sImVycm9yTWVzc2FnZSI6Ik9ubHkgYm9ycm93ZXIgY2FuIGFkZCBndWFyYW50b3IiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NjFdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGJvcnJvd2VyIGNhbiByZXBheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ2Nl0sImVycm9yTWVzc2FnZSI6IlBheW1lbnQgbXVzdCBiZSBzZW50IHRvIHRoZSBzbWFydCBjb250cmFjdCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU2OF0sImVycm9yTWVzc2FnZSI6IlBheW1lbnQgdG8gY29udHJhY3QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNzBdLCJlcnJvck1lc3NhZ2UiOiJUaWVyIDAgbGltaXQgaXMgNTAwIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzc1XSwiZXJyb3JNZXNzYWdlIjoiVGllciAxIGxpbWl0IGlzIDIwMDAiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszOTZdLCJlcnJvck1lc3NhZ2UiOiJUaWVyIDIgbGltaXQgaXMgNTAwMCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQxNl0sImVycm9yTWVzc2FnZSI6IlRpZXIgMyBsaW1pdCBpcyAyMDAwMCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUxNiw1NTksNjg0XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5ib3Jyb3dlciBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NTcsNzA2XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5kZWFkbGluZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NzEsNzIzXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5mdW5kZWRfYW1vdW50IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUwNyw1MjAsNTg0LDYzNiw3MThdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmdvYWxfYW1vdW50IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU3Miw2MzEsNzI3XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5yZXBhaWRfYW1vdW50IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ0Nyw1NTAsNTk4LDY3NSw2OTYsNzMxXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5zdGF0dXMgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjcxXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIyMywyMzIsMjQxLDI1MV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ0Myw1NDZdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIHBheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXdJREVnTXlBNENpQWdJQ0JpZVhSbFkySnNiMk5ySUNKemRHRjBkWE1pSUNKbmIyRnNYMkZ0YjNWdWRDSWdJbkpsY0dGcFpGOWhiVzkxYm5RaUlDSmliM0p5YjNkbGNpSWdJbVoxYm1SbFpGOWhiVzkxYm5RaUlDSmpiMjUwY21saWRYUnBiMjRpSUNKa1pXRmtiR2x1WlNJZ0ltTnNZV2x0WldRaUlDSm5kV0Z5WVc1MGIzSWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJHOWhibDlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvMUNpQWdJQ0F2THlCamJHRnpjeUJNYjJGdVEyOXVkSEpoWTNRb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGc0T0RReE1ETm1OU0F3ZURSaFkyUTVNemxrSUM4dklHMWxkR2h2WkNBaWIzQjBYMmx1WDNSdlgyeHZZVzRvS1hadmFXUWlMQ0J0WlhSb2IyUWdJbVoxYm1SZmJHOWhiaWh3WVhrcGRtOXBaQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUcxaGFXNWZiM0IwWDJsdVgzUnZYMnh2WVc1ZmNtOTFkR1ZBTkNCdFlXbHVYMloxYm1SZmJHOWhibDl5YjNWMFpVQTFDZ3B0WVdsdVgzTjNhWFJqYUY5allYTmxYMjVsZUhSQU5qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5c2IyRnVYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pVS0lDQWdJQzh2SUdOc1lYTnpJRXh2WVc1RGIyNTBjbUZqZENoQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW5vZ2JXRnBibDlqY21WaGRHVmZUbTlQY0VBeE5Bb2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VHVXpNVGxrTkRJeklEQjRabUl5TURZNU4yRWdNSGhqTldVd1pqa3pOeUF3ZURVMllXVTJaV05pSURCNFpqVmlOREE1TldRZ0x5OGdiV1YwYUc5a0lDSnlaWEJoZVY5c2IyRnVLSEJoZVNsMmIybGtJaXdnYldWMGFHOWtJQ0pqYkdGcGJWOXlaWEJoZVcxbGJuUW9LWFp2YVdRaUxDQnRaWFJvYjJRZ0ltRmtaRjluZFdGeVlXNTBiM0lvWVdSa2NtVnpjeWwyYjJsa0lpd2diV1YwYUc5a0lDSnRZWEpyWDJSbFptRjFiSFFvS1hadmFXUWlMQ0J0WlhSb2IyUWdJbWRsZEY5c2IyRnVYMmx1Wm04b0tTaDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXBJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnY21Wd1lYbGZiRzloYmlCamJHRnBiVjl5WlhCaGVXMWxiblFnWVdSa1gyZDFZWEpoYm5SdmNpQnRZWEpyWDJSbFptRjFiSFFnWjJWMFgyeHZZVzVmYVc1bWJ3b2dJQ0FnWlhKeUNncHRZV2x1WDJOeVpXRjBaVjlPYjA5d1FERTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyeHZZVzVmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk5Rb2dJQ0FnTHk4Z1kyeGhjM01nVEc5aGJrTnZiblJ5WVdOMEtFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGhrWXpnMVpqQTNOaUF2THlCdFpYUm9iMlFnSW1OeVpXRjBaVjlzYjJGdUtIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DbDJiMmxrSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ1kzSmxZWFJsWDJ4dllXNEtJQ0FnSUdWeWNnb0tiV0ZwYmw5bWRXNWtYMnh2WVc1ZmNtOTFkR1ZBTlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlzYjJGdVgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPalU1Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0dGc2JHOTNYMkZqZEdsdmJuTTlXeUpPYjA5d0lpd2dJazl3ZEVsdUlsMHBDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ2MyaHNDaUFnSUNCcGJuUmpYeklnTHk4Z013b2dJQ0FnSmdvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNZbUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUdJZ1puVnVaRjlzYjJGdUNncHRZV2x1WDI5d2RGOXBibDkwYjE5c2IyRnVYM0p2ZFhSbFFEUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJHOWhibDlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvMU5Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaGhiR3h2ZDE5aFkzUnBiMjV6UFZzaVQzQjBTVzRpWFNrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUdsdWRHTmZNU0F2THlCUGNIUkpiZ29nSUNBZ1BUMEtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQW1KZ29nSUNBZ1lYTnpaWEowQ2lBZ0lDQmlJRzl3ZEY5cGJsOTBiMTlzYjJGdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbXh2WVc1ZlkyOXVkSEpoWTNRdVkyOXVkSEpoWTNRdVRHOWhia052Ym5SeVlXTjBMbU55WldGMFpWOXNiMkZ1VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1kzSmxZWFJsWDJ4dllXNDZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJHOWhibDlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRveU1Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaGhiR3h2ZDE5aFkzUnBiMjV6UFZzaVRtOVBjQ0pkTENCamNtVmhkR1U5SW5KbGNYVnBjbVVpS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdaSFZ3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUEwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0J6ZDJGd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ykc5aGJsOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG95T0FvZ0lDQWdMeThnWVhOelpYSjBJSFJwWlhKZmNtVnhkV2x5WldRZ1BEMGdWVWx1ZERZMEtETXBMQ0FpU1c1MllXeHBaQ0IwYVdWeUlnb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6SWdMeThnTXdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkpiblpoYkdsa0lIUnBaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXNiMkZ1WDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qTXdDaUFnSUNBdkx5QnBaaUIwYVdWeVgzSmxjWFZwY21Wa0lEMDlJRlZKYm5RMk5DZ3dLVG9LSUNBZ0lHSnVlaUJqY21WaGRHVmZiRzloYmw5bGJITmxYMkp2WkhsQU13b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ4dllXNWZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TXpFS0lDQWdJQzh2SUdGemMyVnlkQ0JuYjJGc1gyRnRiM1Z1ZENBOFBTQlZTVzUwTmpRb05UQXdYekF3TUY4d01EQXBMQ0FpVkdsbGNpQXdJR3hwYldsMElHbHpJRFV3TUNJS0lDQWdJR1JwWnlBekNpQWdJQ0J3ZFhOb2FXNTBJRFV3TURBd01EQXdNQW9nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCVWFXVnlJREFnYkdsdGFYUWdhWE1nTlRBd0NncGpjbVZoZEdWZmJHOWhibDloWm5SbGNsOXBabDlsYkhObFFERXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyeHZZVzVmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk16a0tJQ0FnSUM4dklHbG1JSFJwWlhKZmNtVnhkV2x5WldRZ1BpQlZTVzUwTmpRb01DazZDaUFnSUNCa2FXY2dNUW9nSUNBZ1lub2dZM0psWVhSbFgyeHZZVzVmWVdaMFpYSmZhV1pmWld4elpVQXhOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyeHZZVzVmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk5EQUtJQ0FnSUM4dklHSmhiR0Z1WTJVc0lHOXdkR1ZrWDJsdUlEMGdiM0F1UVhOelpYUkliMnhrYVc1blIyVjBMbUZ6YzJWMFgySmhiR0Z1WTJVb1ZIaHVMbk5sYm1SbGNpd2dZbUZrWjJWZllYTnpaWFFwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCa2FXY2dNUW9nSUNBZ1lYTnpaWFJmYUc5c1pHbHVaMTluWlhRZ1FYTnpaWFJDWVd4aGJtTmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJHOWhibDlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvME1Rb2dJQ0FnTHk4Z1lYTnpaWEowSUc5d2RHVmtYMmx1TENBaVFtOXljbTkzWlhJZ2JtOTBJRzl3ZEdWa0lHbHVkRzhnWW1Ga1oyVWlDaUFnSUNCaGMzTmxjblFnTHk4Z1FtOXljbTkzWlhJZ2JtOTBJRzl3ZEdWa0lHbHVkRzhnWW1Ga1oyVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5c2IyRnVYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pReUNpQWdJQ0F2THlCaGMzTmxjblFnWW1Gc1lXNWpaU0ErSUZWSmJuUTJOQ2d3S1N3Z0lrSnZjbkp2ZDJWeUlHUnZaWE1nYm05MElHaHZiR1FnZEdobElISmxjWFZwY21Wa0lIUnBaWElnWW1Ga1oyVWlDaUFnSUNCaGMzTmxjblFnTHk4Z1FtOXljbTkzWlhJZ1pHOWxjeUJ1YjNRZ2FHOXNaQ0IwYUdVZ2NtVnhkV2x5WldRZ2RHbGxjaUJpWVdSblpRb0tZM0psWVhSbFgyeHZZVzVmWVdaMFpYSmZhV1pmWld4elpVQXhORG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXNiMkZ1WDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qUTBDaUFnSUNBdkx5QnpaV3htTG1KdmNuSnZkMlZ5TG5aaGJIVmxJRDBnVkhodUxuTmxibVJsY2dvZ0lDQWdZbmwwWldOZk15QXZMeUFpWW05eWNtOTNaWElpQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyeHZZVzVmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk5EVUtJQ0FnSUM4dklITmxiR1l1WjI5aGJGOWhiVzkxYm5RdWRtRnNkV1VnUFNCbmIyRnNYMkZ0YjNWdWRBb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVoyOWhiRjloYlc5MWJuUWlDaUFnSUNCa2FXY2dOQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXNiMkZ1WDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qUTJDaUFnSUNBdkx5QnpaV3htTG1aMWJtUmxaRjloYlc5MWJuUXVkbUZzZFdVZ1BTQlZTVzUwTmpRb01Da0tJQ0FnSUdKNWRHVmpJRFFnTHk4Z0ltWjFibVJsWkY5aGJXOTFiblFpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXNiMkZ1WDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qUTNDaUFnSUNBdkx5QnpaV3htTG5KbGNHRnBaRjloYlc5MWJuUXVkbUZzZFdVZ1BTQlZTVzUwTmpRb01Da0tJQ0FnSUdKNWRHVmpYeklnTHk4Z0luSmxjR0ZwWkY5aGJXOTFiblFpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXNiMkZ1WDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qUTRDaUFnSUNBdkx5QnpaV3htTG5OMFlYUjFjeTUyWVd4MVpTQTlJRlZKYm5RMk5DZ3hLU0FnSXlBeFBVOVFSVTRLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbk4wWVhSMWN5SUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ4dllXNWZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TkRrS0lDQWdJQzh2SUhObGJHWXVaR1ZoWkd4cGJtVXVkbUZzZFdVZ1BTQkhiRzlpWVd3dWJHRjBaWE4wWDNScGJXVnpkR0Z0Y0NBcklDaGtkWEpoZEdsdmJsOWtZWGx6SUNvZ09EWTBNREFwQ2lBZ0lDQm5iRzlpWVd3Z1RHRjBaWE4wVkdsdFpYTjBZVzF3Q2lBZ0lDQmthV2NnTXdvZ0lDQWdjSFZ6YUdsdWRDQTROalF3TUFvZ0lDQWdLZ29nSUNBZ0t3b2dJQ0FnWW5sMFpXTWdOaUF2THlBaVpHVmhaR3hwYm1VaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ4dllXNWZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TlRBS0lDQWdJQzh2SUhObGJHWXVaM1ZoY21GdWRHOXlMblpoYkhWbElEMGdSMnh2WW1Gc0xucGxjbTlmWVdSa2NtVnpjd29nSUNBZ1lubDBaV01nT0NBdkx5QWlaM1ZoY21GdWRHOXlJZ29nSUNBZ1oyeHZZbUZzSUZwbGNtOUJaR1J5WlhOekNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ4dllXNWZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TlRFS0lDQWdJQzh2SUhObGJHWXVkR2xsY2w5eVpYRjFhWEpsWkM1MllXeDFaU0E5SUhScFpYSmZjbVZ4ZFdseVpXUUtJQ0FnSUhCMWMyaGllWFJsY3lBaWRHbGxjbDl5WlhGMWFYSmxaQ0lLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMnh2WVc1ZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZOVElLSUNBZ0lDOHZJSE5sYkdZdWRHbGxjbDlpWVdSblpWOXBaQzUyWVd4MVpTQTlJR0poWkdkbFgyRnpjMlYwTG1sa0NpQWdJQ0J3ZFhOb1lubDBaWE1nSW5ScFpYSmZZbUZrWjJWZmFXUWlDaUFnSUNCa2FXY2dNUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXNiMkZ1WDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qSXdDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLR0ZzYkc5M1gyRmpkR2x2Ym5NOVd5Sk9iMDl3SWwwc0lHTnlaV0YwWlQwaWNtVnhkV2x5WlNJcENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncGpjbVZoZEdWZmJHOWhibDlsYkhObFgySnZaSGxBTXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlzYjJGdVgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPak15Q2lBZ0lDQXZMeUJsYkdsbUlIUnBaWEpmY21WeGRXbHlaV1FnUFQwZ1ZVbHVkRFkwS0RFcE9nb2dJQ0FnWkdsbklERUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0E5UFFvZ0lDQWdZbm9nWTNKbFlYUmxYMnh2WVc1ZlpXeHpaVjlpYjJSNVFEVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5c2IyRnVYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pNekNpQWdJQ0F2THlCaGMzTmxjblFnWjI5aGJGOWhiVzkxYm5RZ1BEMGdWVWx1ZERZMEtESXdNREJmTURBd1h6QXdNQ2tzSUNKVWFXVnlJREVnYkdsdGFYUWdhWE1nTWpBd01DSUtJQ0FnSUdScFp5QXpDaUFnSUNCd2RYTm9hVzUwSURJd01EQXdNREF3TURBS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdWR2xsY2lBeElHeHBiV2wwSUdseklESXdNREFLSUNBZ0lHSWdZM0psWVhSbFgyeHZZVzVmWVdaMFpYSmZhV1pmWld4elpVQXhNZ29LWTNKbFlYUmxYMnh2WVc1ZlpXeHpaVjlpYjJSNVFEVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJHOWhibDlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvek5Bb2dJQ0FnTHk4Z1pXeHBaaUIwYVdWeVgzSmxjWFZwY21Wa0lEMDlJRlZKYm5RMk5DZ3lLVG9LSUNBZ0lHUnBaeUF4Q2lBZ0lDQndkWE5vYVc1MElESUtJQ0FnSUQwOUNpQWdJQ0JpZWlCamNtVmhkR1ZmYkc5aGJsOWxiSE5sWDJKdlpIbEFOd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyeHZZVzVmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk16VUtJQ0FnSUM4dklHRnpjMlZ5ZENCbmIyRnNYMkZ0YjNWdWRDQThQU0JWU1c1ME5qUW9OVEF3TUY4d01EQmZNREF3S1N3Z0lsUnBaWElnTWlCc2FXMXBkQ0JwY3lBMU1EQXdJZ29nSUNBZ1pHbG5JRE1LSUNBZ0lIQjFjMmhwYm5RZ05UQXdNREF3TURBd01Bb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJVYVdWeUlESWdiR2x0YVhRZ2FYTWdOVEF3TUFvZ0lDQWdZaUJqY21WaGRHVmZiRzloYmw5aFpuUmxjbDlwWmw5bGJITmxRREV5Q2dwamNtVmhkR1ZmYkc5aGJsOWxiSE5sWDJKdlpIbEFOem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXNiMkZ1WDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qTTJDaUFnSUNBdkx5QmxiR2xtSUhScFpYSmZjbVZ4ZFdseVpXUWdQVDBnVlVsdWREWTBLRE1wT2dvZ0lDQWdaR2xuSURFS0lDQWdJR2x1ZEdOZk1pQXZMeUF6Q2lBZ0lDQTlQUW9nSUNBZ1lub2dZM0psWVhSbFgyeHZZVzVmWVdaMFpYSmZhV1pmWld4elpVQXhNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyeHZZVzVmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk16Y0tJQ0FnSUM4dklHRnpjMlZ5ZENCbmIyRnNYMkZ0YjNWdWRDQThQU0JWU1c1ME5qUW9NakF3TURCZk1EQXdYekF3TUNrc0lDSlVhV1Z5SURNZ2JHbHRhWFFnYVhNZ01qQXdNREFpQ2lBZ0lDQmthV2NnTXdvZ0lDQWdjSFZ6YUdsdWRDQXlNREF3TURBd01EQXdNQW9nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCVWFXVnlJRE1nYkdsdGFYUWdhWE1nTWpBd01EQUtJQ0FnSUdJZ1kzSmxZWFJsWDJ4dllXNWZZV1owWlhKZmFXWmZaV3h6WlVBeE1nb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVzYjJGdVgyTnZiblJ5WVdOMExtTnZiblJ5WVdOMExreHZZVzVEYjI1MGNtRmpkQzV2Y0hSZmFXNWZkRzlmYkc5aGJsdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbTl3ZEY5cGJsOTBiMTlzYjJGdU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ4dllXNWZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TlRZS0lDQWdJQzh2SUhObGJHWXVZMjl1ZEhKcFluVjBhVzl1VzFSNGJpNXpaVzVrWlhKZElEMGdWVWx1ZERZMEtEQXBDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKamIyNTBjbWxpZFhScGIyNGlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyeHZZMkZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ4dllXNWZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TlRjS0lDQWdJQzh2SUhObGJHWXVZMnhoYVcxbFpGdFVlRzR1YzJWdVpHVnlYU0E5SUZWSmJuUTJOQ2d3S1FvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1lubDBaV01nTnlBdkx5QWlZMnhoYVcxbFpDSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JoY0hCZmJHOWpZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ykc5aGJsOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG8xTkFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoaGJHeHZkMTloWTNScGIyNXpQVnNpVDNCMFNXNGlYU2tLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWJHOWhibDlqYjI1MGNtRmpkQzVqYjI1MGNtRmpkQzVNYjJGdVEyOXVkSEpoWTNRdVpuVnVaRjlzYjJGdVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tablZ1WkY5c2IyRnVPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyeHZZVzVmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk5Ua0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9ZV3hzYjNkZllXTjBhVzl1Y3oxYklrNXZUM0FpTENBaVQzQjBTVzRpWFNrS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1pIVndDaUFnSUNCbmRIaHVjeUJVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh4SUM4dklIQmhlUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCMGNtRnVjMkZqZEdsdmJpQjBlWEJsSUdseklIQmhlUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyeHZZVzVmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk5qRUtJQ0FnSUM4dklHRnpjMlZ5ZENCelpXeG1Mbk4wWVhSMWN5NTJZV3gxWlNBOVBTQXhMQ0FpVEc5aGJpQnBjeUJ1YjNRZ1QxQkZUaUlLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnpkR0YwZFhNaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVjM1JoZEhWeklHVjRhWE4wY3dvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1RHOWhiaUJwY3lCdWIzUWdUMUJGVGdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMnh2WVc1ZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZOaklLSUNBZ0lDOHZJR0Z6YzJWeWRDQkhiRzlpWVd3dWJHRjBaWE4wWDNScGJXVnpkR0Z0Y0NBOElITmxiR1l1WkdWaFpHeHBibVV1ZG1Gc2RXVXNJQ0pHZFc1a2FXNW5JR1JsWVdSc2FXNWxJSEJoYzNObFpDSUtJQ0FnSUdkc2IySmhiQ0JNWVhSbGMzUlVhVzFsYzNSaGJYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTJJQzh2SUNKa1pXRmtiR2x1WlNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWtaV0ZrYkdsdVpTQmxlR2x6ZEhNS0lDQWdJRHdLSUNBZ0lHRnpjMlZ5ZENBdkx5QkdkVzVrYVc1bklHUmxZV1JzYVc1bElIQmhjM05sWkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMnh2WVc1ZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZOak1LSUNBZ0lDOHZJR0Z6YzJWeWRDQndZWGx0Wlc1MExuSmxZMlZwZG1WeUlEMDlJRWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNJQ0pRWVhsdFpXNTBJRzExYzNRZ1ltVWdjMlZ1ZENCMGJ5QjBhR1VnYzIxaGNuUWdZMjl1ZEhKaFkzUWlDaUFnSUNCa2RYQUtJQ0FnSUdkMGVHNXpJRkpsWTJWcGRtVnlDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUVlYbHRaVzUwSUcxMWMzUWdZbVVnYzJWdWRDQjBieUIwYUdVZ2MyMWhjblFnWTI5dWRISmhZM1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXNiMkZ1WDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qWTFDaUFnSUNBdkx5QnpaV3htTG1aMWJtUmxaRjloYlc5MWJuUXVkbUZzZFdVZ0t6MGdjR0Y1YldWdWRDNWhiVzkxYm5RS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMElDOHZJQ0ptZFc1a1pXUmZZVzF2ZFc1MElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbVoxYm1SbFpGOWhiVzkxYm5RZ1pYaHBjM1J6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQm5kSGh1Y3lCQmJXOTFiblFLSUNBZ0lITjNZWEFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQXJDaUFnSUNCaWVYUmxZeUEwSUM4dklDSm1kVzVrWldSZllXMXZkVzUwSWdvZ0lDQWdaR2xuSURFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ykc5aGJsOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG8yTndvZ0lDQWdMeThnWTNWeWNtVnVkRjlqYjI1MGNtbGlJRDBnYzJWc1ppNWpiMjUwY21saWRYUnBiMjR1WjJWMEtGUjRiaTV6Wlc1a1pYSXNJR1JsWm1GMWJIUTlWVWx1ZERZMEtEQXBLUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEVWdMeThnSW1OdmJuUnlhV0oxZEdsdmJpSUtJQ0FnSUdGd2NGOXNiMk5oYkY5blpYUmZaWGdLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlzYjJGdVgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPalk0Q2lBZ0lDQXZMeUJ6Wld4bUxtTnZiblJ5YVdKMWRHbHZibHRVZUc0dWMyVnVaR1Z5WFNBOUlHTjFjbkpsYm5SZlkyOXVkSEpwWWlBcklIQmhlVzFsYm5RdVlXMXZkVzUwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUNzS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdJbU52Ym5SeWFXSjFkR2x2YmlJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1lYQndYMnh2WTJGc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyeHZZVzVmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk56QUtJQ0FnSUM4dklHbG1JSE5sYkdZdVpuVnVaR1ZrWDJGdGIzVnVkQzUyWVd4MVpTQStQU0J6Wld4bUxtZHZZV3hmWVcxdmRXNTBMblpoYkhWbE9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1kdllXeGZZVzF2ZFc1MElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbWR2WVd4ZllXMXZkVzUwSUdWNGFYTjBjd29nSUNBZ1BqMEtJQ0FnSUdKNklHWjFibVJmYkc5aGJsOWhablJsY2w5cFpsOWxiSE5sUURNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlzYjJGdVgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPamMxTFRjNUNpQWdJQ0F2THlCcGRIaHVMbEJoZVcxbGJuUW9DaUFnSUNBdkx5QWdJQ0FnY21WalpXbDJaWEk5YzJWc1ppNWliM0p5YjNkbGNpNTJZV3gxWlN3S0lDQWdJQzh2SUNBZ0lDQmhiVzkxYm5ROWMyVnNaaTVuYjJGc1gyRnRiM1Z1ZEM1MllXeDFaU3dLSUNBZ0lDOHZJQ0FnSUNCbVpXVTlNQW9nSUNBZ0x5OGdLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ4dllXNWZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TnpZS0lDQWdJQzh2SUhKbFkyVnBkbVZ5UFhObGJHWXVZbTl5Y205M1pYSXVkbUZzZFdVc0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk15QXZMeUFpWW05eWNtOTNaWElpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVltOXljbTkzWlhJZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiRzloYmw5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzNOd29nSUNBZ0x5OGdZVzF2ZFc1MFBYTmxiR1l1WjI5aGJGOWhiVzkxYm5RdWRtRnNkV1VzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTVNBdkx5QWlaMjloYkY5aGJXOTFiblFpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVoyOWhiRjloYlc5MWJuUWdaWGhwYzNSekNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGdGIzVnVkQW9nSUNBZ2FYUjRibDltYVdWc1pDQlNaV05sYVhabGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ4dllXNWZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TnpVS0lDQWdJQzh2SUdsMGVHNHVVR0Y1YldWdWRDZ0tJQ0FnSUdsdWRHTmZNU0F2THlCd1lYa0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlzYjJGdVgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPamM0Q2lBZ0lDQXZMeUJtWldVOU1Bb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ykc5aGJsOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG8zTlMwM09Rb2dJQ0FnTHk4Z2FYUjRiaTVRWVhsdFpXNTBLQW9nSUNBZ0x5OGdJQ0FnSUhKbFkyVnBkbVZ5UFhObGJHWXVZbTl5Y205M1pYSXVkbUZzZFdVc0NpQWdJQ0F2THlBZ0lDQWdZVzF2ZFc1MFBYTmxiR1l1WjI5aGJGOWhiVzkxYm5RdWRtRnNkV1VzQ2lBZ0lDQXZMeUFnSUNBZ1ptVmxQVEFLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJHOWhibDlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvNE1Bb2dJQ0FnTHk4Z2MyVnNaaTV6ZEdGMGRYTXVkbUZzZFdVZ1BTQlZTVzUwTmpRb015a2dJQ01nVWtWUVFWbEpUa2NLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbk4wWVhSMWN5SUtJQ0FnSUdsdWRHTmZNaUF2THlBekNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb0tablZ1WkY5c2IyRnVYMkZtZEdWeVgybG1YMlZzYzJWQU16b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5c2IyRnVYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pVNUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tHRnNiRzkzWDJGamRHbHZibk05V3lKT2IwOXdJaXdnSWs5d2RFbHVJbDBwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxteHZZVzVmWTI5dWRISmhZM1F1WTI5dWRISmhZM1F1VEc5aGJrTnZiblJ5WVdOMExuSmxjR0Y1WDJ4dllXNWJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B5WlhCaGVWOXNiMkZ1T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMnh2WVc1ZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZPRElLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWkhWd0NpQWdJQ0JuZEhodWN5QlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHhJQzh2SUhCaGVRb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUIwY21GdWMyRmpkR2x2YmlCMGVYQmxJR2x6SUhCaGVRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ4dllXNWZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2T0RRS0lDQWdJQzh2SUdGemMyVnlkQ0J6Wld4bUxuTjBZWFIxY3k1MllXeDFaU0E5UFNBekxDQWlURzloYmlCcGN5QnViM1FnVWtWUVFWbEpUa2NpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWljM1JoZEhWeklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1Mbk4wWVhSMWN5QmxlR2x6ZEhNS0lDQWdJR2x1ZEdOZk1pQXZMeUF6Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFeHZZVzRnYVhNZ2JtOTBJRkpGVUVGWlNVNUhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJHOWhibDlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvNE5Rb2dJQ0FnTHk4Z1lYTnpaWEowSUZSNGJpNXpaVzVrWlhJZ1BUMGdjMlZzWmk1aWIzSnliM2RsY2k1MllXeDFaU3dnSWs5dWJIa2dZbTl5Y205M1pYSWdZMkZ1SUhKbGNHRjVJZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6TWdMeThnSW1KdmNuSnZkMlZ5SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtSnZjbkp2ZDJWeUlHVjRhWE4wY3dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBibXg1SUdKdmNuSnZkMlZ5SUdOaGJpQnlaWEJoZVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMnh2WVc1ZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZPRFlLSUNBZ0lDOHZJR0Z6YzJWeWRDQndZWGx0Wlc1MExuSmxZMlZwZG1WeUlEMDlJRWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNJQ0pRWVhsdFpXNTBJSFJ2SUdOdmJuUnlZV04wSWdvZ0lDQWdaSFZ3Q2lBZ0lDQm5kSGh1Y3lCU1pXTmxhWFpsY2dvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdVR0Y1YldWdWRDQjBieUJqYjI1MGNtRmpkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyeHZZVzVmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk9EZ0tJQ0FnSUM4dklITmxiR1l1Y21Wd1lXbGtYMkZ0YjNWdWRDNTJZV3gxWlNBclBTQndZWGx0Wlc1MExtRnRiM1Z1ZEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbkpsY0dGcFpGOWhiVzkxYm5RaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVjbVZ3WVdsa1gyRnRiM1Z1ZENCbGVHbHpkSE1LSUNBZ0lITjNZWEFLSUNBZ0lHZDBlRzV6SUVGdGIzVnVkQW9nSUNBZ0t3b2dJQ0FnWW5sMFpXTmZNaUF2THlBaWNtVndZV2xrWDJGdGIzVnVkQ0lLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMnh2WVc1ZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZPVEFLSUNBZ0lDOHZJR2xtSUhObGJHWXVjbVZ3WVdsa1gyRnRiM1Z1ZEM1MllXeDFaU0ErUFNCelpXeG1MbWR2WVd4ZllXMXZkVzUwTG5aaGJIVmxPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltZHZZV3hmWVcxdmRXNTBJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1kdllXeGZZVzF2ZFc1MElHVjRhWE4wY3dvZ0lDQWdQajBLSUNBZ0lHSjZJSEpsY0dGNVgyeHZZVzVmWVdaMFpYSmZhV1pmWld4elpVQXpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJHOWhibDlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvNU1Rb2dJQ0FnTHk4Z2MyVnNaaTV6ZEdGMGRYTXVkbUZzZFdVZ1BTQlZTVzUwTmpRb05Da2dJQ01nUTB4UFUwVkVDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnpkR0YwZFhNaUNpQWdJQ0J3ZFhOb2FXNTBJRFFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2dweVpYQmhlVjlzYjJGdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlzYjJGdVgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPamd5Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxteHZZVzVmWTI5dWRISmhZM1F1WTI5dWRISmhZM1F1VEc5aGJrTnZiblJ5WVdOMExtTnNZV2x0WDNKbGNHRjViV1Z1ZEZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtTnNZV2x0WDNKbGNHRjViV1Z1ZERvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlzYjJGdVgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPamsxQ2lBZ0lDQXZMeUJoYzNObGNuUWdjMlZzWmk1emRHRjBkWE11ZG1Gc2RXVWdQVDBnTkN3Z0lreHZZVzRnYVhNZ2JtOTBJRU5NVDFORlJDSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKemRHRjBkWE1pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWMzUmhkSFZ6SUdWNGFYTjBjd29nSUNBZ2NIVnphR2x1ZENBMENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRXh2WVc0Z2FYTWdibTkwSUVOTVQxTkZSQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyeHZZVzVmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk9UY0tJQ0FnSUM4dklHTnZiblJ5YVdJZ1BTQnpaV3htTG1OdmJuUnlhV0oxZEdsdmJpNW5aWFFvVkhodUxuTmxibVJsY2l3Z1pHVm1ZWFZzZEQxVlNXNTBOalFvTUNrcENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTlNBdkx5QWlZMjl1ZEhKcFluVjBhVzl1SWdvZ0lDQWdZWEJ3WDJ4dlkyRnNYMmRsZEY5bGVBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyeHZZVzVmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk9UZ0tJQ0FnSUM4dklHTnNZV2x0WldRZ1BTQnpaV3htTG1Oc1lXbHRaV1F1WjJWMEtGUjRiaTV6Wlc1a1pYSXNJR1JsWm1GMWJIUTlWVWx1ZERZMEtEQXBLUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEY2dMeThnSW1Oc1lXbHRaV1FpQ2lBZ0lDQmhjSEJmYkc5allXeGZaMlYwWDJWNENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYzJWc1pXTjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJHOWhibDlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRveE1EQUtJQ0FnSUM4dklHRnpjMlZ5ZENCamIyNTBjbWxpSUQ0Z01Dd2dJazV2SUdOdmJuUnlhV0oxZEdsdmJpQm1iM1Z1WkNJS0lDQWdJR1JwWnlBeENpQWdJQ0JoYzNObGNuUWdMeThnVG04Z1kyOXVkSEpwWW5WMGFXOXVJR1p2ZFc1a0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ykc5aGJsOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG94TURFS0lDQWdJQzh2SUdGemMyVnlkQ0JqYkdGcGJXVmtJRDA5SURBc0lDSkJiSEpsWVdSNUlHTnNZV2x0WldRaUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdRV3h5WldGa2VTQmpiR0ZwYldWa0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ykc5aGJsOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG94TURNS0lDQWdJQzh2SUhOb1lYSmxJRDBnS0dOdmJuUnlhV0lnS2lCelpXeG1MbkpsY0dGcFpGOWhiVzkxYm5RdWRtRnNkV1VwSUM4dklITmxiR1l1WjI5aGJGOWhiVzkxYm5RdWRtRnNkV1VLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh5SUM4dklDSnlaWEJoYVdSZllXMXZkVzUwSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuSmxjR0ZwWkY5aGJXOTFiblFnWlhocGMzUnpDaUFnSUNBcUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWjI5aGJGOWhiVzkxYm5RaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVaMjloYkY5aGJXOTFiblFnWlhocGMzUnpDaUFnSUNBdkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ykc5aGJsOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG94TURVdE1UQTVDaUFnSUNBdkx5QnBkSGh1TGxCaGVXMWxiblFvQ2lBZ0lDQXZMeUFnSUNBZ2NtVmpaV2wyWlhJOVZIaHVMbk5sYm1SbGNpd0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUTljMmhoY21Vc0NpQWdJQ0F2THlBZ0lDQWdabVZsUFRBS0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXNiMkZ1WDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qRXdOZ29nSUNBZ0x5OGdjbVZqWldsMlpYSTlWSGh1TG5ObGJtUmxjaXdLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdScFp5QXhDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnRiM1Z1ZEFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JTWldObGFYWmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyeHZZVzVmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk1UQTFDaUFnSUNBdkx5QnBkSGh1TGxCaGVXMWxiblFvQ2lBZ0lDQnBiblJqWHpFZ0x5OGdjR0Y1Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJHOWhibDlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRveE1EZ0tJQ0FnSUM4dklHWmxaVDB3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXNiMkZ1WDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qRXdOUzB4TURrS0lDQWdJQzh2SUdsMGVHNHVVR0Y1YldWdWRDZ0tJQ0FnSUM4dklDQWdJQ0J5WldObGFYWmxjajFVZUc0dWMyVnVaR1Z5TEFvZ0lDQWdMeThnSUNBZ0lHRnRiM1Z1ZEQxemFHRnlaU3dLSUNBZ0lDOHZJQ0FnSUNCbVpXVTlNQW9nSUNBZ0x5OGdLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5c2IyRnVYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pFeE1Rb2dJQ0FnTHk4Z2MyVnNaaTVqYkdGcGJXVmtXMVI0Ymk1elpXNWtaWEpkSUQwZ2MyaGhjbVVLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdKNWRHVmpJRGNnTHk4Z0ltTnNZV2x0WldRaUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHRndjRjlzYjJOaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXNiMkZ1WDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qa3pDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG14dllXNWZZMjl1ZEhKaFkzUXVZMjl1ZEhKaFkzUXVURzloYmtOdmJuUnlZV04wTG1Ga1pGOW5kV0Z5WVc1MGIzSmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BoWkdSZlozVmhjbUZ1ZEc5eU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ4dllXNWZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TVRFekNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiRzloYmw5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3hNVFVLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpaV3htTG5OMFlYUjFjeTUyWVd4MVpTQTlQU0F4TENBaVRHOWhiaUJ0ZFhOMElHSmxJRTlRUlU0aUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpYzNSaGRIVnpJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5OMFlYUjFjeUJsZUdsemRITUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRXh2WVc0Z2JYVnpkQ0JpWlNCUFVFVk9DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJHOWhibDlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRveE1UWUtJQ0FnSUM4dklHRnpjMlZ5ZENCVWVHNHVjMlZ1WkdWeUlEMDlJSE5sYkdZdVltOXljbTkzWlhJdWRtRnNkV1VzSUNKUGJteDVJR0p2Y25KdmQyVnlJR05oYmlCaFpHUWdaM1ZoY21GdWRHOXlJZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6TWdMeThnSW1KdmNuSnZkMlZ5SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtSnZjbkp2ZDJWeUlHVjRhWE4wY3dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBibXg1SUdKdmNuSnZkMlZ5SUdOaGJpQmhaR1FnWjNWaGNtRnVkRzl5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiRzloYmw5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3hNVGNLSUNBZ0lDOHZJSE5sYkdZdVozVmhjbUZ1ZEc5eUxuWmhiSFZsSUQwZ1ozVmhjbUZ1ZEc5eUNpQWdJQ0JpZVhSbFl5QTRJQzh2SUNKbmRXRnlZVzUwYjNJaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ4dllXNWZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TVRFekNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbXh2WVc1ZlkyOXVkSEpoWTNRdVkyOXVkSEpoWTNRdVRHOWhia052Ym5SeVlXTjBMbTFoY210ZlpHVm1ZWFZzZEZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtMWhjbXRmWkdWbVlYVnNkRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXNiMkZ1WDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qRXlNUW9nSUNBZ0x5OGdZWE56WlhKMElITmxiR1l1YzNSaGRIVnpMblpoYkhWbElEMDlJRE1zSUNKTWIyRnVJRzExYzNRZ1ltVWdVa1ZRUVZsSlRrY2lDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWMzUmhkSFZ6SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuTjBZWFIxY3lCbGVHbHpkSE1LSUNBZ0lHbHVkR05mTWlBdkx5QXpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUV4dllXNGdiWFZ6ZENCaVpTQlNSVkJCV1VsT1J3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ4dllXNWZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TVRJeUNpQWdJQ0F2THlCaGMzTmxjblFnUjJ4dlltRnNMbXhoZEdWemRGOTBhVzFsYzNSaGJYQWdQaUJ6Wld4bUxtUmxZV1JzYVc1bExuWmhiSFZsTENBaVJHVmhaR3hwYm1VZ2JtOTBJSEJoYzNObFpDSUtJQ0FnSUdkc2IySmhiQ0JNWVhSbGMzUlVhVzFsYzNSaGJYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTJJQzh2SUNKa1pXRmtiR2x1WlNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWtaV0ZrYkdsdVpTQmxlR2x6ZEhNS0lDQWdJRDRLSUNBZ0lHRnpjMlZ5ZENBdkx5QkVaV0ZrYkdsdVpTQnViM1FnY0dGemMyVmtDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJHOWhibDlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRveE1qTUtJQ0FnSUM4dklITmxiR1l1YzNSaGRIVnpMblpoYkhWbElEMGdWVWx1ZERZMEtEVXBJQ0FqSUVSRlJrRlZURlJGUkFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpYzNSaGRIVnpJZ29nSUNBZ2NIVnphR2x1ZENBMUNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ4dllXNWZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TVRFNUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbXh2WVc1ZlkyOXVkSEpoWTNRdVkyOXVkSEpoWTNRdVRHOWhia052Ym5SeVlXTjBMbWRsZEY5c2IyRnVYMmx1Wm05YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncG5aWFJmYkc5aGJsOXBibVp2T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMnh2WVc1ZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNVEkzQ2lBZ0lDQXZMeUJuYjJGc0lEMGdjMlZzWmk1bmIyRnNYMkZ0YjNWdWRDNTJZV3gxWlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbWR2WVd4ZllXMXZkVzUwSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtZHZZV3hmWVcxdmRXNTBJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ4dllXNWZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TVRJNENpQWdJQ0F2THlCbWRXNWtaV1FnUFNCelpXeG1MbVoxYm1SbFpGOWhiVzkxYm5RdWRtRnNkV1VLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUEwSUM4dklDSm1kVzVrWldSZllXMXZkVzUwSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtWjFibVJsWkY5aGJXOTFiblFnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJHOWhibDlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRveE1qa0tJQ0FnSUM4dklISmxjR0ZwWkNBOUlITmxiR1l1Y21Wd1lXbGtYMkZ0YjNWdWRDNTJZV3gxWlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbkpsY0dGcFpGOWhiVzkxYm5RaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVjbVZ3WVdsa1gyRnRiM1Z1ZENCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXNiMkZ1WDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qRXpNQW9nSUNBZ0x5OGdjM1JoZEhWeklEMGdjMlZzWmk1emRHRjBkWE11ZG1Gc2RXVUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKemRHRjBkWE1pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWMzUmhkSFZ6SUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyeHZZVzVmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk1USTFDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHbDBiMklLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQUFFRENDWUpCbk4wWVhSMWN3dG5iMkZzWDJGdGIzVnVkQTF5WlhCaGFXUmZZVzF2ZFc1MENHSnZjbkp2ZDJWeURXWjFibVJsWkY5aGJXOTFiblFNWTI5dWRISnBZblYwYVc5dUNHUmxZV1JzYVc1bEIyTnNZV2x0WldRSlozVmhjbUZ1ZEc5eWdnSUVpRUVEOVFSS3paT2ROaG9BamdJQVR3QkNNUmtVUkRFWVFRQXJnZ1VFNHhuVUl3VDdJR2w2Qk1YZytUY0VWcTV1eXdUMXRBbGROaG9BamdVQmFBR2lBZVlDQkFJYUFJQUUzSVh3ZGpZYUFJNEJBQmtBSXpFWmtDUWFNUmdRUkVJQTVURVpJeEl4R0JCRVFnRE1OaG9CU1JVbEVrUVhOaG9DU1JVbEVrUVhOaG9EU1JVbEVrUVhTVFlhQkVrVkpSSkVGMHhKSkE1RVFBQmlTd09CZ01xMTdnRU9SRXNCUVFBSU1RQkxBWEFBUkVRck1RQm5LVXNFWnljRUltY3FJbWNvSTJjeUIwc0RnWUNqQlFzSUp3Wk1aeWNJTWdObmdBMTBhV1Z5WDNKbGNYVnBjbVZrU3dKbmdBMTBhV1Z5WDJKaFpHZGxYMmxrU3dGbkkwTkxBU01TUVFBTlN3T0JnS2pXdVFjT1JFTC9sRXNCZ1FJU1FRQU5Td09CZ09TWDBCSU9SRUwvZjBzQkpCSkIvM2hMQTRHQWtOL0FTZzVFUXY5ck1RQW5CU0ptTVFBbkJ5Sm1JME14RmlNSlNUZ1FJeEpFSWlobFJDTVNSRElISWljR1pVUU1SRWs0QnpJS0VrUWlKd1JsUkV3NENFeExBUWduQkVzQlp6RUFJaWNGWXlKT0FrMVBBZ2d4QUNjRlR3Sm1JaWxsUkE5QkFCZXhJaXRsUkNJcFpVU3lDTElISTdJUUlySUJzeWdrWnlORE1SWWpDVWs0RUNNU1JDSW9aVVFrRWtReEFDSXJaVVFTUkVrNEJ6SUtFa1FpS21WRVREZ0lDQ3BMQVdjaUtXVkVEMEVBQkNpQkJHY2pReUlvWlVTQkJCSkVNUUFpSndWaklrNENUVEVBSWljSFl5Sk9BazFMQVVRVVJDSXFaVVFMSWlsbFJBcXhNUUJMQWJJSXNnY2pzaEFpc2dHek1RQW5CMDhDWmlORE5ob0JTUldCSUJKRUlpaGxSQ01TUkRFQUlpdGxSQkpFSndoTVp5TkRJaWhsUkNRU1JESUhJaWNHWlVRTlJDaUJCV2NqUXlJcFpVUWlKd1JsUkNJcVpVUWlLR1ZFVHdNV1R3TVdVRThDRmxCTUZsQ0FCQlVmZkhWTVVMQWpRdz09IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6NywicGF0Y2giOjEsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
