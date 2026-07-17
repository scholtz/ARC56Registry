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

namespace Arc56.Generated.harsh_mogalgiddikar.cadencia_lending_pool.RepaymentEscrow_c1bce0d7
{


    //
    // 
    //    Stateless repayment splitter.
    //
    //    Access control:
    //        - process_repayment: LoanManager only (inner app call)
    //        - set_* : admin only
    //    
    //
    public class RepaymentEscrowProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public RepaymentEscrowProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class GetStatsReturn : AVMObjectType
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

                public static GetStatsReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetStatsReturn();
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
                    return Equals(obj as GetStatsReturn);
                }
                public bool Equals(GetStatsReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetStatsReturn left, GetStatsReturn right)
                {
                    return EqualityComparer<GetStatsReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetStatsReturn left, GetStatsReturn right)
                {
                    return !(left == right);
                }

            }

            public class GetSplitPreviewReturn : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public ulong Field1 { get; set; }

                public ulong Field2 { get; set; }

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
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static GetSplitPreviewReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetSplitPreviewReturn();
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
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetSplitPreviewReturn);
                }
                public bool Equals(GetSplitPreviewReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetSplitPreviewReturn left, GetSplitPreviewReturn right)
                {
                    return EqualityComparer<GetSplitPreviewReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetSplitPreviewReturn left, GetSplitPreviewReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Initialize the escrow. Called once at deployment.
        ///</summary>
        /// <param name="admin"> </param>
        /// <param name="loan_manager_id"> </param>
        /// <param name="lending_pool_id"> </param>
        /// <param name="treasury"> </param>
        /// <param name="insurance"> </param>
        public async Task Create(Algorand.Address admin, ulong loan_manager_id, ulong lending_pool_id, Algorand.Address treasury, Algorand.Address insurance, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 2, 208, 42, 5 };
            var adminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); adminAbi.From(admin);
            var loan_manager_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); loan_manager_idAbi.From(loan_manager_id);
            var lending_pool_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); lending_pool_idAbi.From(lending_pool_id);
            var treasuryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); treasuryAbi.From(treasury);
            var insuranceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); insuranceAbi.From(insurance);

            var result = await base.CallApp(new List<object> { abiHandle, adminAbi, loan_manager_idAbi, lending_pool_idAbi, treasuryAbi, insuranceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(Algorand.Address admin, ulong loan_manager_id, ulong lending_pool_id, Algorand.Address treasury, Algorand.Address insurance, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 2, 208, 42, 5 };
            var adminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); adminAbi.From(admin);
            var loan_manager_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); loan_manager_idAbi.From(loan_manager_id);
            var lending_pool_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); lending_pool_idAbi.From(lending_pool_id);
            var treasuryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); treasuryAbi.From(treasury);
            var insuranceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); insuranceAbi.From(insurance);

            return await base.MakeTransactionList(new List<object> { abiHandle, adminAbi, loan_manager_idAbi, lending_pool_idAbi, treasuryAbi, insuranceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Update treasury address. Admin-only.
        ///</summary>
        /// <param name="new_treasury"> </param>
        public async Task SetTreasury(Algorand.Address new_treasury, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 252, 216, 202, 175 };
            var new_treasuryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); new_treasuryAbi.From(new_treasury);

            var result = await base.CallApp(new List<object> { abiHandle, new_treasuryAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetTreasury_Transactions(Algorand.Address new_treasury, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 252, 216, 202, 175 };
            var new_treasuryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); new_treasuryAbi.From(new_treasury);

            return await base.MakeTransactionList(new List<object> { abiHandle, new_treasuryAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Update insurance reserve address. Admin-only.
        ///</summary>
        /// <param name="new_insurance"> </param>
        public async Task SetInsurance(Algorand.Address new_insurance, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 22, 141, 9, 81 };
            var new_insuranceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); new_insuranceAbi.From(new_insurance);

            var result = await base.CallApp(new List<object> { abiHandle, new_insuranceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetInsurance_Transactions(Algorand.Address new_insurance, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 22, 141, 9, 81 };
            var new_insuranceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); new_insuranceAbi.From(new_insurance);

            return await base.MakeTransactionList(new List<object> { abiHandle, new_insuranceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Receive repayment and split to pool (80%), treasury (15%), insurance (5%).
        ///The caller must include a PaymentTransaction to this escrow's app address. Only callable by the LoanManager contract (inner app call).
        ///All three payouts happen atomically via inner transactions.
        ///</summary>
        /// <param name="payment"> </param>
        public async Task ProcessRepayment(PaymentTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 109, 241, 97, 131 };

            var result = await base.CallApp(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ProcessRepayment_Transactions(PaymentTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 109, 241, 97, 131 };

            return await base.MakeTransactionList(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Return (total_processed, total_to_pool, total_to_treasury, total_to_insurance).
        ///</summary>
        public async Task<Structs.GetStatsReturn> GetStats(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 223, 9, 182, 8 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetStatsReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetStats_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 223, 9, 182, 8 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Preview the split for a given amount: (pool, treasury, insurance).
        ///</summary>
        /// <param name="amount"> </param>
        public async Task<Structs.GetSplitPreviewReturn> GetSplitPreview(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 33, 171, 239, 29 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.SimApp(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetSplitPreviewReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetSplitPreview_Transactions(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 33, 171, 239, 29 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUmVwYXltZW50RXNjcm93IiwiZGVzYyI6IlxuICAgIFN0YXRlbGVzcyByZXBheW1lbnQgc3BsaXR0ZXIuXG5cbiAgICBBY2Nlc3MgY29udHJvbDpcbiAgICAgICAgLSBwcm9jZXNzX3JlcGF5bWVudDogTG9hbk1hbmFnZXIgb25seSAoaW5uZXIgYXBwIGNhbGwpXG4gICAgICAgIC0gc2V0XyogOiBhZG1pbiBvbmx5XG4gICAgIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkdldFN0YXRzUmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDIiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQzIiwidHlwZSI6InVpbnQ2NCJ9XSwiR2V0U3BsaXRQcmV2aWV3UmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDIiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZSIsImRlc2MiOiJJbml0aWFsaXplIHRoZSBlc2Nyb3cuIENhbGxlZCBvbmNlIGF0IGRlcGxveW1lbnQuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZG1pbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibG9hbl9tYW5hZ2VyX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJsZW5kaW5nX3Bvb2xfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0cmVhc3VyeSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Imluc3VyYW5jZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRfdHJlYXN1cnkiLCJkZXNjIjoiVXBkYXRlIHRyZWFzdXJ5IGFkZHJlc3MuIEFkbWluLW9ubHkuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdfdHJlYXN1cnkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0X2luc3VyYW5jZSIsImRlc2MiOiJVcGRhdGUgaW5zdXJhbmNlIHJlc2VydmUgYWRkcmVzcy4gQWRtaW4tb25seS4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld19pbnN1cmFuY2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicHJvY2Vzc19yZXBheW1lbnQiLCJkZXNjIjoiUmVjZWl2ZSByZXBheW1lbnQgYW5kIHNwbGl0IHRvIHBvb2wgKDgwJSksIHRyZWFzdXJ5ICgxNSUpLCBpbnN1cmFuY2UgKDUlKS5cblRoZSBjYWxsZXIgbXVzdCBpbmNsdWRlIGEgUGF5bWVudFRyYW5zYWN0aW9uIHRvIHRoaXMgZXNjcm93J3MgYXBwIGFkZHJlc3MuIE9ubHkgY2FsbGFibGUgYnkgdGhlIExvYW5NYW5hZ2VyIGNvbnRyYWN0IChpbm5lciBhcHAgY2FsbCkuXG5BbGwgdGhyZWUgcGF5b3V0cyBoYXBwZW4gYXRvbWljYWxseSB2aWEgaW5uZXIgdHJhbnNhY3Rpb25zLiIsImFyZ3MiOlt7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXltZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9zdGF0cyIsImRlc2MiOiJSZXR1cm4gKHRvdGFsX3Byb2Nlc3NlZCwgdG90YWxfdG9fcG9vbCwgdG90YWxfdG9fdHJlYXN1cnksIHRvdGFsX3RvX2luc3VyYW5jZSkuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiR2V0U3RhdHNSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9zcGxpdF9wcmV2aWV3IiwiZGVzYyI6IlByZXZpZXcgdGhlIHNwbGl0IGZvciBhIGdpdmVuIGFtb3VudDogKHBvb2wsIHRyZWFzdXJ5LCBpbnN1cmFuY2UpLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IkdldFNwbGl0UHJldmlld1JldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjYsImJ5dGVzIjozfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls0MDFdLCJlcnJvck1lc3NhZ2UiOiJhcHBsaWNhdGlvbiBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNTYsMjc4LDMxM10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuYWRtaW4gZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzc5XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5pbnN1cmFuY2UgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzk3XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5sZW5kaW5nX3Bvb2xfaWQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzAzXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5sb2FuX21hbmFnZXJfaWQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDE4LDQ2Ml0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudG90YWxfcHJvY2Vzc2VkIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ0Nyw0NzhdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnRvdGFsX3RvX2luc3VyYW5jZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MjgsNDY3XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi50b3RhbF90b19wb29sIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQzNiw0NzJdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnRvdGFsX3RvX3RyZWFzdXJ5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM2MF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudHJlYXN1cnkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTY4LDE5NiwyMDQsMjUwLDI3Ml0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNzcsMTg3LDUwNV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI1OCwyODBdLCJlcnJvck1lc3NhZ2UiOiJvbmx5IGFkbWluIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzI3XSwiZXJyb3JNZXNzYWdlIjoicGF5IHRvIGVzY3JvdyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI5Nl0sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgcGF5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzE5XSwiZXJyb3JNZXNzYWdlIjoidW5hdXRob3JpemVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzMxXSwiZXJyb3JNZXNzYWdlIjoiemVybyByZXBheW1lbnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF3SURFZ016SWdNVEF3TURBS0lDQWdJR0o1ZEdWallteHZZMnNnSW1Ga2JXbHVJaUFpZEc5MFlXeGZjSEp2WXlJZ0luUnZYM0J2YjJ3aUlDSjBiMTkwY21WaGN5SWdJblJ2WDJsdWMzVnlaU0lnSW5SeVpXRnpkWEo1SWlBaWFXNXpkWEpoYm1ObElpQWliRzloYmw5dFozSWlJQ0p3YjI5c1gybGtJaUF3ZURFMU1XWTNZemMxQ2lBZ0lDQXZMeUJqWVdSbGJtTnBZUzl5WlhCaGVXMWxiblJmWlhOamNtOTNMbkI1T2pNMkNpQWdJQ0F2THlCamJHRnpjeUJTWlhCaGVXMWxiblJGYzJOeWIzY29RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSjZJRzFoYVc1ZlkzSmxZWFJsWDA1dlQzQkFNVEVLSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGhtWTJRNFkyRmhaaUF3ZURFMk9HUXdPVFV4SURCNE5tUm1NVFl4T0RNZ01IaGtaakE1WWpZd09DQXdlREl4WVdKbFpqRmtJQzh2SUcxbGRHaHZaQ0FpYzJWMFgzUnlaV0Z6ZFhKNUtHRmtaSEpsYzNNcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpYzJWMFgybHVjM1Z5WVc1alpTaGhaR1J5WlhOektYWnZhV1FpTENCdFpYUm9iMlFnSW5CeWIyTmxjM05mY21Wd1lYbHRaVzUwS0hCaGVTbDJiMmxrSWl3Z2JXVjBhRzlrSUNKblpYUmZjM1JoZEhNb0tTaDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXBJaXdnYldWMGFHOWtJQ0puWlhSZmMzQnNhWFJmY0hKbGRtbGxkeWgxYVc1ME5qUXBLSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwS1NJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lITmxkRjkwY21WaGMzVnllU0J6WlhSZmFXNXpkWEpoYm1ObElIQnliMk5sYzNOZmNtVndZWGx0Wlc1MElHZGxkRjl6ZEdGMGN5Qm5aWFJmYzNCc2FYUmZjSEpsZG1sbGR3b2dJQ0FnWlhKeUNncHRZV2x1WDJOeVpXRjBaVjlPYjA5d1FERXhPZ29nSUNBZ0x5OGdZMkZrWlc1amFXRXZjbVZ3WVhsdFpXNTBYMlZ6WTNKdmR5NXdlVG96TmdvZ0lDQWdMeThnWTJ4aGMzTWdVbVZ3WVhsdFpXNTBSWE5qY205M0tFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TW1Rd01tRXdOU0F2THlCdFpYUm9iMlFnSW1OeVpXRjBaU2hoWkdSeVpYTnpMSFZwYm5RMk5DeDFhVzUwTmpRc1lXUmtjbVZ6Y3l4aFpHUnlaWE56S1hadmFXUWlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0JqY21WaGRHVUtJQ0FnSUdWeWNnb0tDaTh2SUdOaFpHVnVZMmxoTG5KbGNHRjViV1Z1ZEY5bGMyTnliM2N1VW1Wd1lYbHRaVzUwUlhOamNtOTNMbU55WldGMFpWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbU55WldGMFpUb0tJQ0FnSUM4dklHTmhaR1Z1WTJsaEwzSmxjR0Y1YldWdWRGOWxjMk55YjNjdWNIazZOakFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaGpjbVZoZEdVOUluSmxjWFZwY21VaUtRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0F2THlCallXUmxibU5wWVM5eVpYQmhlVzFsYm5SZlpYTmpjbTkzTG5CNU9qY3dDaUFnSUNBdkx5QnpaV3htTG1Ga2JXbHVMblpoYkhWbElEMGdZV1J0YVc0S0lDQWdJR0o1ZEdWalh6QWdMeThnSW1Ga2JXbHVJZ29nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z1kyRmtaVzVqYVdFdmNtVndZWGx0Wlc1MFgyVnpZM0p2ZHk1d2VUbzNNUW9nSUNBZ0x5OGdjMlZzWmk1c2IyRnVYMjFoYm1GblpYSmZhV1F1ZG1Gc2RXVWdQU0JzYjJGdVgyMWhibUZuWlhKZmFXUUtJQ0FnSUdKNWRHVmpJRGNnTHk4Z0lteHZZVzVmYldkeUlnb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnWTJGa1pXNWphV0V2Y21Wd1lYbHRaVzUwWDJWelkzSnZkeTV3ZVRvM01nb2dJQ0FnTHk4Z2MyVnNaaTVzWlc1a2FXNW5YM0J2YjJ4ZmFXUXVkbUZzZFdVZ1BTQnNaVzVrYVc1blgzQnZiMnhmYVdRS0lDQWdJR0o1ZEdWaklEZ2dMeThnSW5CdmIyeGZhV1FpQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QmpZV1JsYm1OcFlTOXlaWEJoZVcxbGJuUmZaWE5qY205M0xuQjVPamN6Q2lBZ0lDQXZMeUJ6Wld4bUxuUnlaV0Z6ZFhKNUxuWmhiSFZsSUQwZ2RISmxZWE4xY25rS0lDQWdJR0o1ZEdWaklEVWdMeThnSW5SeVpXRnpkWEo1SWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdZMkZrWlc1amFXRXZjbVZ3WVhsdFpXNTBYMlZ6WTNKdmR5NXdlVG8zTkFvZ0lDQWdMeThnYzJWc1ppNXBibk4xY21GdVkyVXVkbUZzZFdVZ1BTQnBibk4xY21GdVkyVUtJQ0FnSUdKNWRHVmpJRFlnTHk4Z0ltbHVjM1Z5WVc1alpTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QmpZV1JsYm1OcFlTOXlaWEJoZVcxbGJuUmZaWE5qY205M0xuQjVPamMxQ2lBZ0lDQXZMeUJ6Wld4bUxuUnZkR0ZzWDNCeWIyTmxjM05sWkM1MllXeDFaU0E5SUZWSmJuUTJOQ2d3S1FvZ0lDQWdZbmwwWldOZk1TQXZMeUFpZEc5MFlXeGZjSEp2WXlJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnWTJGa1pXNWphV0V2Y21Wd1lYbHRaVzUwWDJWelkzSnZkeTV3ZVRvM05nb2dJQ0FnTHk4Z2MyVnNaaTUwYjNSaGJGOTBiMTl3YjI5c0xuWmhiSFZsSUQwZ1ZVbHVkRFkwS0RBcENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKMGIxOXdiMjlzSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJqWVdSbGJtTnBZUzl5WlhCaGVXMWxiblJmWlhOamNtOTNMbkI1T2pjM0NpQWdJQ0F2THlCelpXeG1MblJ2ZEdGc1gzUnZYM1J5WldGemRYSjVMblpoYkhWbElEMGdWVWx1ZERZMEtEQXBDaUFnSUNCaWVYUmxZMTh6SUM4dklDSjBiMTkwY21WaGN5SUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z1kyRmtaVzVqYVdFdmNtVndZWGx0Wlc1MFgyVnpZM0p2ZHk1d2VUbzNPQW9nSUNBZ0x5OGdjMlZzWmk1MGIzUmhiRjkwYjE5cGJuTjFjbUZ1WTJVdWRtRnNkV1VnUFNCVlNXNTBOalFvTUNrS0lDQWdJR0o1ZEdWaklEUWdMeThnSW5SdlgybHVjM1Z5WlNJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnWTJGa1pXNWphV0V2Y21Wd1lYbHRaVzUwWDJWelkzSnZkeTV3ZVRvMk1Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0dOeVpXRjBaVDBpY21WeGRXbHlaU0lwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdZMkZrWlc1amFXRXVjbVZ3WVhsdFpXNTBYMlZ6WTNKdmR5NVNaWEJoZVcxbGJuUkZjMk55YjNjdWMyVjBYM1J5WldGemRYSjVXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYzJWMFgzUnlaV0Z6ZFhKNU9nb2dJQ0FnTHk4Z1kyRmtaVzVqYVdFdmNtVndZWGx0Wlc1MFgyVnpZM0p2ZHk1d2VUbzRNQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJQzh2SUdOaFpHVnVZMmxoTDNKbGNHRjViV1Z1ZEY5bGMyTnliM2N1Y0hrNk9ETUtJQ0FnSUM4dklHRnpjMlZ5ZENCVWVHNHVjMlZ1WkdWeUlEMDlJSE5sYkdZdVlXUnRhVzR1ZG1Gc2RXVXNJQ0p2Ym14NUlHRmtiV2x1SWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltRmtiV2x1SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtRmtiV2x1SUdWNGFYTjBjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmJteDVJR0ZrYldsdUNpQWdJQ0F2THlCallXUmxibU5wWVM5eVpYQmhlVzFsYm5SZlpYTmpjbTkzTG5CNU9qZzBDaUFnSUNBdkx5QnpaV3htTG5SeVpXRnpkWEo1TG5aaGJIVmxJRDBnYm1WM1gzUnlaV0Z6ZFhKNUNpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKMGNtVmhjM1Z5ZVNJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCallXUmxibU5wWVM5eVpYQmhlVzFsYm5SZlpYTmpjbTkzTG5CNU9qZ3dDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJqWVdSbGJtTnBZUzV5WlhCaGVXMWxiblJmWlhOamNtOTNMbEpsY0dGNWJXVnVkRVZ6WTNKdmR5NXpaWFJmYVc1emRYSmhibU5sVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2MyVjBYMmx1YzNWeVlXNWpaVG9LSUNBZ0lDOHZJR05oWkdWdVkybGhMM0psY0dGNWJXVnVkRjlsYzJOeWIzY3VjSGs2T0RZS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNBdkx5QmpZV1JsYm1OcFlTOXlaWEJoZVcxbGJuUmZaWE5qY205M0xuQjVPamc1Q2lBZ0lDQXZMeUJoYzNObGNuUWdWSGh1TG5ObGJtUmxjaUE5UFNCelpXeG1MbUZrYldsdUxuWmhiSFZsTENBaWIyNXNlU0JoWkcxcGJpSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0poWkcxcGJpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVoWkcxcGJpQmxlR2x6ZEhNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiMjVzZVNCaFpHMXBiZ29nSUNBZ0x5OGdZMkZrWlc1amFXRXZjbVZ3WVhsdFpXNTBYMlZ6WTNKdmR5NXdlVG81TUFvZ0lDQWdMeThnYzJWc1ppNXBibk4xY21GdVkyVXVkbUZzZFdVZ1BTQnVaWGRmYVc1emRYSmhibU5sQ2lBZ0lDQmllWFJsWXlBMklDOHZJQ0pwYm5OMWNtRnVZMlVpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnWTJGa1pXNWphV0V2Y21Wd1lYbHRaVzUwWDJWelkzSnZkeTV3ZVRvNE5nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdZMkZrWlc1amFXRXVjbVZ3WVhsdFpXNTBYMlZ6WTNKdmR5NVNaWEJoZVcxbGJuUkZjMk55YjNjdWNISnZZMlZ6YzE5eVpYQmhlVzFsYm5SYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHdjbTlqWlhOelgzSmxjR0Y1YldWdWREb0tJQ0FnSUM4dklHTmhaR1Z1WTJsaEwzSmxjR0Y1YldWdWRGOWxjMk55YjNjdWNIazZPVElLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0F0Q2lBZ0lDQmtkWEFLSUNBZ0lHZDBlRzV6SUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdjR0Y1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklIUnlZVzV6WVdOMGFXOXVJSFI1Y0dVZ2FYTWdjR0Y1Q2lBZ0lDQXZMeUJqWVdSbGJtTnBZUzl5WlhCaGVXMWxiblJmWlhOamNtOTNMbkI1T2pFd013b2dJQ0FnTHk4Z1IyeHZZbUZzTG1OaGJHeGxjbDloY0hCc2FXTmhkR2x2Ymw5cFpDQTlQU0J6Wld4bUxteHZZVzVmYldGdVlXZGxjbDlwWkM1MllXeDFaUW9nSUNBZ1oyeHZZbUZzSUVOaGJHeGxja0Z3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBM0lDOHZJQ0pzYjJGdVgyMW5jaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1c2IyRnVYMjFoYm1GblpYSmZhV1FnWlhocGMzUnpDaUFnSUNBOVBRb2dJQ0FnTHk4Z1kyRmtaVzVqYVdFdmNtVndZWGx0Wlc1MFgyVnpZM0p2ZHk1d2VUb3hNRE10TVRBMENpQWdJQ0F2THlCSGJHOWlZV3d1WTJGc2JHVnlYMkZ3Y0d4cFkyRjBhVzl1WDJsa0lEMDlJSE5sYkdZdWJHOWhibDl0WVc1aFoyVnlYMmxrTG5aaGJIVmxDaUFnSUNBdkx5QnZjaUJVZUc0dWMyVnVaR1Z5SUQwOUlITmxiR1l1WVdSdGFXNHVkbUZzZFdVS0lDQWdJR0p1ZWlCd2NtOWpaWE56WDNKbGNHRjViV1Z1ZEY5aWIyOXNYM1J5ZFdWQU13b2dJQ0FnTHk4Z1kyRmtaVzVqYVdFdmNtVndZWGx0Wlc1MFgyVnpZM0p2ZHk1d2VUb3hNRFFLSUNBZ0lDOHZJRzl5SUZSNGJpNXpaVzVrWlhJZ1BUMGdjMlZzWmk1aFpHMXBiaTUyWVd4MVpRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUZrYldsdUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbUZrYldsdUlHVjRhWE4wY3dvZ0lDQWdQVDBLSUNBZ0lDOHZJR05oWkdWdVkybGhMM0psY0dGNWJXVnVkRjlsYzJOeWIzY3VjSGs2TVRBekxURXdOQW9nSUNBZ0x5OGdSMnh2WW1Gc0xtTmhiR3hsY2w5aGNIQnNhV05oZEdsdmJsOXBaQ0E5UFNCelpXeG1MbXh2WVc1ZmJXRnVZV2RsY2w5cFpDNTJZV3gxWlFvZ0lDQWdMeThnYjNJZ1ZIaHVMbk5sYm1SbGNpQTlQU0J6Wld4bUxtRmtiV2x1TG5aaGJIVmxDaUFnSUNCaWVpQndjbTlqWlhOelgzSmxjR0Y1YldWdWRGOWliMjlzWDJaaGJITmxRRFFLQ25CeWIyTmxjM05mY21Wd1lYbHRaVzUwWDJKdmIyeGZkSEoxWlVBek9nb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0NuQnliMk5sYzNOZmNtVndZWGx0Wlc1MFgySnZiMnhmYldWeVoyVkFOVG9LSUNBZ0lDOHZJR05oWkdWdVkybGhMM0psY0dGNWJXVnVkRjlsYzJOeWIzY3VjSGs2TVRBeUxURXdOUW9nSUNBZ0x5OGdZWE56WlhKMElDZ0tJQ0FnSUM4dklDQWdJQ0JIYkc5aVlXd3VZMkZzYkdWeVgyRndjR3hwWTJGMGFXOXVYMmxrSUQwOUlITmxiR1l1Ykc5aGJsOXRZVzVoWjJWeVgybGtMblpoYkhWbENpQWdJQ0F2THlBZ0lDQWdiM0lnVkhodUxuTmxibVJsY2lBOVBTQnpaV3htTG1Ga2JXbHVMblpoYkhWbENpQWdJQ0F2THlBcExDQWlkVzVoZFhSb2IzSnBlbVZrSWdvZ0lDQWdZWE56WlhKMElDOHZJSFZ1WVhWMGFHOXlhWHBsWkFvZ0lDQWdMeThnWTJGa1pXNWphV0V2Y21Wd1lYbHRaVzUwWDJWelkzSnZkeTV3ZVRveE1EWUtJQ0FnSUM4dklHRnpjMlZ5ZENCd1lYbHRaVzUwTG5KbFkyVnBkbVZ5SUQwOUlFZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNc0lDSndZWGtnZEc4Z1pYTmpjbTkzSWdvZ0lDQWdaSFZ3YmlBeUNpQWdJQ0JuZEhodWN5QlNaV05sYVhabGNnb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnY0dGNUlIUnZJR1Z6WTNKdmR3b2dJQ0FnTHk4Z1kyRmtaVzVqYVdFdmNtVndZWGx0Wlc1MFgyVnpZM0p2ZHk1d2VUb3hNRGdLSUNBZ0lDOHZJSFJ2ZEdGc0lEMGdjR0Y1YldWdWRDNWhiVzkxYm5RS0lDQWdJR2QwZUc1eklFRnRiM1Z1ZEFvZ0lDQWdMeThnWTJGa1pXNWphV0V2Y21Wd1lYbHRaVzUwWDJWelkzSnZkeTV3ZVRveE1Ea0tJQ0FnSUM4dklHRnpjMlZ5ZENCMGIzUmhiQ0ErSUZWSmJuUTJOQ2d3S1N3Z0lucGxjbThnY21Wd1lYbHRaVzUwSWdvZ0lDQWdaSFZ3Q2lBZ0lDQmhjM05sY25RZ0x5OGdlbVZ5YnlCeVpYQmhlVzFsYm5RS0lDQWdJQzh2SUdOaFpHVnVZMmxoTDNKbGNHRjViV1Z1ZEY5bGMyTnliM2N1Y0hrNk1URXhMVEV4TWdvZ0lDQWdMeThnSXlCRFlXeGpkV3hoZEdVZ2MzQnNhWFJ6SUNoeWIzVnVaR2x1WnpvZ2NHOXZiQ0JuWlhSeklISmxiV0ZwYm1SbGNpa0tJQ0FnSUM4dklIUnlaV0Z6ZFhKNVgyRnRiM1Z1ZENBOUlDaDBiM1JoYkNBcUlGUlNSVUZUVlZKWlgxTklRVkpGWDBKUVV5a2dMeThnUWxCVFgwUkZUazlOU1U1QlZFOVNDaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaHBiblFnTVRVd01Bb2dJQ0FnS2dvZ0lDQWdhVzUwWTE4eklDOHZJREV3TURBd0NpQWdJQ0F2Q2lBZ0lDQXZMeUJqWVdSbGJtTnBZUzl5WlhCaGVXMWxiblJmWlhOamNtOTNMbkI1T2pFeE13b2dJQ0FnTHk4Z2FXNXpkWEpoYm1ObFgyRnRiM1Z1ZENBOUlDaDBiM1JoYkNBcUlFbE9VMVZTUVU1RFJWOVRTRUZTUlY5Q1VGTXBJQzh2SUVKUVUxOUVSVTVQVFVsT1FWUlBVZ29nSUNBZ1pHbG5JREVLSUNBZ0lIQjFjMmhwYm5RZ05UQXdDaUFnSUNBcUNpQWdJQ0JwYm5Salh6TWdMeThnTVRBd01EQUtJQ0FnSUM4S0lDQWdJQzh2SUdOaFpHVnVZMmxoTDNKbGNHRjViV1Z1ZEY5bGMyTnliM2N1Y0hrNk1URTBDaUFnSUNBdkx5QndiMjlzWDJGdGIzVnVkQ0E5SUhSdmRHRnNJQzBnZEhKbFlYTjFjbmxmWVcxdmRXNTBJQzBnYVc1emRYSmhibU5sWDJGdGIzVnVkQ0FnSXlCU1pXMWhhVzVrWlhJZ2RHOGdjRzl2YkFvZ0lDQWdaR2xuSURJS0lDQWdJR1JwWnlBeUNpQWdJQ0F0Q2lBZ0lDQmthV2NnTVFvZ0lDQWdMUW9nSUNBZ0x5OGdZMkZrWlc1amFXRXZjbVZ3WVhsdFpXNTBYMlZ6WTNKdmR5NXdlVG94TVRZdE1USXhDaUFnSUNBdkx5QWpJRUYwYjIxcFl5QnBibTVsY2lCMGNtRnVjMkZqZEdsdmJpQm5jbTkxY0RvZ1lXeHNJSFJvY21WbElIQmhlVzkxZEhNS0lDQWdJQzh2SUdsMGVHNHVVR0Y1YldWdWRDZ0tJQ0FnSUM4dklDQWdJQ0J5WldObGFYWmxjajF6Wld4bUxuUnlaV0Z6ZFhKNUxuWmhiSFZsTEFvZ0lDQWdMeThnSUNBZ0lHRnRiM1Z1ZEQxMGNtVmhjM1Z5ZVY5aGJXOTFiblFzQ2lBZ0lDQXZMeUFnSUNBZ1ptVmxQVEFzQ2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNBdkx5QmpZV1JsYm1OcFlTOXlaWEJoZVcxbGJuUmZaWE5qY205M0xuQjVPakV4T0FvZ0lDQWdMeThnY21WalpXbDJaWEk5YzJWc1ppNTBjbVZoYzNWeWVTNTJZV3gxWlN3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMUlDOHZJQ0owY21WaGMzVnllU0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1MGNtVmhjM1Z5ZVNCbGVHbHpkSE1LSUNBZ0lHUnBaeUF6Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ0YjNWdWRBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCU1pXTmxhWFpsY2dvZ0lDQWdMeThnWTJGa1pXNWphV0V2Y21Wd1lYbHRaVzUwWDJWelkzSnZkeTV3ZVRveE1UWXRNVEUzQ2lBZ0lDQXZMeUFqSUVGMGIyMXBZeUJwYm01bGNpQjBjbUZ1YzJGamRHbHZiaUJuY205MWNEb2dZV3hzSUhSb2NtVmxJSEJoZVc5MWRITUtJQ0FnSUM4dklHbDBlRzR1VUdGNWJXVnVkQ2dLSUNBZ0lHbHVkR05mTVNBdkx5QndZWGtLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUM4dklHTmhaR1Z1WTJsaEwzSmxjR0Y1YldWdWRGOWxjMk55YjNjdWNIazZNVEl3Q2lBZ0lDQXZMeUJtWldVOU1Dd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnTHk4Z1kyRmtaVzVqYVdFdmNtVndZWGx0Wlc1MFgyVnpZM0p2ZHk1d2VUb3hNVFl0TVRJeENpQWdJQ0F2THlBaklFRjBiMjFwWXlCcGJtNWxjaUIwY21GdWMyRmpkR2x2YmlCbmNtOTFjRG9nWVd4c0lIUm9jbVZsSUhCaGVXOTFkSE1LSUNBZ0lDOHZJR2wwZUc0dVVHRjViV1Z1ZENnS0lDQWdJQzh2SUNBZ0lDQnlaV05sYVhabGNqMXpaV3htTG5SeVpXRnpkWEo1TG5aaGJIVmxMQW9nSUNBZ0x5OGdJQ0FnSUdGdGIzVnVkRDEwY21WaGMzVnllVjloYlc5MWJuUXNDaUFnSUNBdkx5QWdJQ0FnWm1WbFBUQXNDaUFnSUNBdkx5QXBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnTHk4Z1kyRmtaVzVqYVdFdmNtVndZWGx0Wlc1MFgyVnpZM0p2ZHk1d2VUb3hNak10TVRJM0NpQWdJQ0F2THlCcGRIaHVMbEJoZVcxbGJuUW9DaUFnSUNBdkx5QWdJQ0FnY21WalpXbDJaWEk5YzJWc1ppNXBibk4xY21GdVkyVXVkbUZzZFdVc0NpQWdJQ0F2THlBZ0lDQWdZVzF2ZFc1MFBXbHVjM1Z5WVc1alpWOWhiVzkxYm5Rc0NpQWdJQ0F2THlBZ0lDQWdabVZsUFRBc0NpQWdJQ0F2THlBcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUJqWVdSbGJtTnBZUzl5WlhCaGVXMWxiblJmWlhOamNtOTNMbkI1T2pFeU5Bb2dJQ0FnTHk4Z2NtVmpaV2wyWlhJOWMyVnNaaTVwYm5OMWNtRnVZMlV1ZG1Gc2RXVXNDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOaUF2THlBaWFXNXpkWEpoYm1ObElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbWx1YzNWeVlXNWpaU0JsZUdsemRITUtJQ0FnSUdScFp5QXlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnRiM1Z1ZEFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JTWldObGFYWmxjZ29nSUNBZ0x5OGdZMkZrWlc1amFXRXZjbVZ3WVhsdFpXNTBYMlZ6WTNKdmR5NXdlVG94TWpNS0lDQWdJQzh2SUdsMGVHNHVVR0Y1YldWdWRDZ0tJQ0FnSUdsdWRHTmZNU0F2THlCd1lYa0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJQzh2SUdOaFpHVnVZMmxoTDNKbGNHRjViV1Z1ZEY5bGMyTnliM2N1Y0hrNk1USTJDaUFnSUNBdkx5Qm1aV1U5TUN3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdMeThnWTJGa1pXNWphV0V2Y21Wd1lYbHRaVzUwWDJWelkzSnZkeTV3ZVRveE1qTXRNVEkzQ2lBZ0lDQXZMeUJwZEhodUxsQmhlVzFsYm5Rb0NpQWdJQ0F2THlBZ0lDQWdjbVZqWldsMlpYSTljMlZzWmk1cGJuTjFjbUZ1WTJVdWRtRnNkV1VzQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwUFdsdWMzVnlZVzVqWlY5aGJXOTFiblFzQ2lBZ0lDQXZMeUFnSUNBZ1ptVmxQVEFzQ2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ0x5OGdZMkZrWlc1amFXRXZjbVZ3WVhsdFpXNTBYMlZ6WTNKdmR5NXdlVG94TWprdE1UTXdDaUFnSUNBdkx5QWpJRkpsZEhWeWJpQndiMjlzSUhOb1lYSmxJT0tBbENCelpXNWtJRUZNUjA4Z1pHbHlaV04wYkhrZ2RHOGdjRzl2YkNCaGNIQWdZV1JrY21WemN3b2dJQ0FnTHk4Z2NHOXZiRjloY0hBZ1BTQkJjSEJzYVdOaGRHbHZiaWh6Wld4bUxteGxibVJwYm1kZmNHOXZiRjlwWkM1MllXeDFaU2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUE0SUM4dklDSndiMjlzWDJsa0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbXhsYm1ScGJtZGZjRzl2YkY5cFpDQmxlR2x6ZEhNS0lDQWdJQzh2SUdOaFpHVnVZMmxoTDNKbGNHRjViV1Z1ZEY5bGMyTnliM2N1Y0hrNk1UTXlMVEV6TmdvZ0lDQWdMeThnYVhSNGJpNVFZWGx0Wlc1MEtBb2dJQ0FnTHk4Z0lDQWdJSEpsWTJWcGRtVnlQWEJ2YjJ4ZllYQndMbUZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBQWEJ2YjJ4ZllXMXZkVzUwTEFvZ0lDQWdMeThnSUNBZ0lHWmxaVDB3TEFvZ0lDQWdMeThnS1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ0x5OGdZMkZrWlc1amFXRXZjbVZ3WVhsdFpXNTBYMlZ6WTNKdmR5NXdlVG94TXpNS0lDQWdJQzh2SUhKbFkyVnBkbVZ5UFhCdmIyeGZZWEJ3TG1Ga1pISmxjM01zQ2lBZ0lDQmhjSEJmY0dGeVlXMXpYMmRsZENCQmNIQkJaR1J5WlhOekNpQWdJQ0JoYzNObGNuUWdMeThnWVhCd2JHbGpZWFJwYjI0Z1pYaHBjM1J6Q2lBZ0lDQmthV2NnTVFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYlc5MWJuUUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1VtVmpaV2wyWlhJS0lDQWdJQzh2SUdOaFpHVnVZMmxoTDNKbGNHRjViV1Z1ZEY5bGMyTnliM2N1Y0hrNk1UTXlDaUFnSUNBdkx5QnBkSGh1TGxCaGVXMWxiblFvQ2lBZ0lDQnBiblJqWHpFZ0x5OGdjR0Y1Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNBdkx5QmpZV1JsYm1OcFlTOXlaWEJoZVcxbGJuUmZaWE5qY205M0xuQjVPakV6TlFvZ0lDQWdMeThnWm1WbFBUQXNDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUM4dklHTmhaR1Z1WTJsaEwzSmxjR0Y1YldWdWRGOWxjMk55YjNjdWNIazZNVE15TFRFek5nb2dJQ0FnTHk4Z2FYUjRiaTVRWVhsdFpXNTBLQW9nSUNBZ0x5OGdJQ0FnSUhKbFkyVnBkbVZ5UFhCdmIyeGZZWEJ3TG1Ga1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwUFhCdmIyeGZZVzF2ZFc1MExBb2dJQ0FnTHk4Z0lDQWdJR1psWlQwd0xBb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJQzh2SUdOaFpHVnVZMmxoTDNKbGNHRjViV1Z1ZEY5bGMyTnliM2N1Y0hrNk1UTTRMVEV6T1FvZ0lDQWdMeThnSXlCVmNHUmhkR1VnYzNSaGRITUtJQ0FnSUM4dklITmxiR1l1ZEc5MFlXeGZjSEp2WTJWemMyVmtMblpoYkhWbElDczlJSFJ2ZEdGc0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpZEc5MFlXeGZjSEp2WXlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNTBiM1JoYkY5d2NtOWpaWE56WldRZ1pYaHBjM1J6Q2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUNzS0lDQWdJR0o1ZEdWalh6RWdMeThnSW5SdmRHRnNYM0J5YjJNaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z1kyRmtaVzVqYVdFdmNtVndZWGx0Wlc1MFgyVnpZM0p2ZHk1d2VUb3hOREFLSUNBZ0lDOHZJSE5sYkdZdWRHOTBZV3hmZEc5ZmNHOXZiQzUyWVd4MVpTQXJQU0J3YjI5c1gyRnRiM1Z1ZEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJblJ2WDNCdmIyd2lDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1ZEc5MFlXeGZkRzlmY0c5dmJDQmxlR2x6ZEhNS0lDQWdJQ3NLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJblJ2WDNCdmIyd2lDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdZMkZrWlc1amFXRXZjbVZ3WVhsdFpXNTBYMlZ6WTNKdmR5NXdlVG94TkRFS0lDQWdJQzh2SUhObGJHWXVkRzkwWVd4ZmRHOWZkSEpsWVhOMWNua3VkbUZzZFdVZ0t6MGdkSEpsWVhOMWNubGZZVzF2ZFc1MENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk15QXZMeUFpZEc5ZmRISmxZWE1pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWRHOTBZV3hmZEc5ZmRISmxZWE4xY25rZ1pYaHBjM1J6Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUNzS0lDQWdJR0o1ZEdWalh6TWdMeThnSW5SdlgzUnlaV0Z6SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUdOaFpHVnVZMmxoTDNKbGNHRjViV1Z1ZEY5bGMyTnliM2N1Y0hrNk1UUXlDaUFnSUNBdkx5QnpaV3htTG5SdmRHRnNYM1J2WDJsdWMzVnlZVzVqWlM1MllXeDFaU0FyUFNCcGJuTjFjbUZ1WTJWZllXMXZkVzUwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTkNBdkx5QWlkRzlmYVc1emRYSmxJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5SdmRHRnNYM1J2WDJsdWMzVnlZVzVqWlNCbGVHbHpkSE1LSUNBZ0lDc0tJQ0FnSUdKNWRHVmpJRFFnTHk4Z0luUnZYMmx1YzNWeVpTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QmpZV1JsYm1OcFlTOXlaWEJoZVcxbGJuUmZaWE5qY205M0xuQjVPamt5Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbkJ5YjJObGMzTmZjbVZ3WVhsdFpXNTBYMkp2YjJ4ZlptRnNjMlZBTkRvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmlJSEJ5YjJObGMzTmZjbVZ3WVhsdFpXNTBYMkp2YjJ4ZmJXVnlaMlZBTlFvS0NpOHZJR05oWkdWdVkybGhMbkpsY0dGNWJXVnVkRjlsYzJOeWIzY3VVbVZ3WVhsdFpXNTBSWE5qY205M0xtZGxkRjl6ZEdGMGMxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWRsZEY5emRHRjBjem9LSUNBZ0lDOHZJR05oWkdWdVkybGhMM0psY0dGNWJXVnVkRjlsYzJOeWIzY3VjSGs2TVRVekNpQWdJQ0F2THlCaGNtTTBMbFZKYm5RMk5DaHpaV3htTG5SdmRHRnNYM0J5YjJObGMzTmxaQzUyWVd4MVpTa3NDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWRHOTBZV3hmY0hKdll5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTUwYjNSaGJGOXdjbTlqWlhOelpXUWdaWGhwYzNSekNpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCallXUmxibU5wWVM5eVpYQmhlVzFsYm5SZlpYTmpjbTkzTG5CNU9qRTFOQW9nSUNBZ0x5OGdZWEpqTkM1VlNXNTBOalFvYzJWc1ppNTBiM1JoYkY5MGIxOXdiMjlzTG5aaGJIVmxLU3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh5SUM4dklDSjBiMTl3YjI5c0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MblJ2ZEdGc1gzUnZYM0J2YjJ3Z1pYaHBjM1J6Q2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJqWVdSbGJtTnBZUzl5WlhCaGVXMWxiblJmWlhOamNtOTNMbkI1T2pFMU5Rb2dJQ0FnTHk4Z1lYSmpOQzVWU1c1ME5qUW9jMlZzWmk1MGIzUmhiRjkwYjE5MGNtVmhjM1Z5ZVM1MllXeDFaU2tzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTXlBdkx5QWlkRzlmZEhKbFlYTWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1ZEc5MFlXeGZkRzlmZEhKbFlYTjFjbmtnWlhocGMzUnpDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QmpZV1JsYm1OcFlTOXlaWEJoZVcxbGJuUmZaWE5qY205M0xuQjVPakUxTmdvZ0lDQWdMeThnWVhKak5DNVZTVzUwTmpRb2MyVnNaaTUwYjNSaGJGOTBiMTlwYm5OMWNtRnVZMlV1ZG1Gc2RXVXBMQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z0luUnZYMmx1YzNWeVpTSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTUwYjNSaGJGOTBiMTlwYm5OMWNtRnVZMlVnWlhocGMzUnpDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QmpZV1JsYm1OcFlTOXlaWEJoZVcxbGJuUmZaWE5qY205M0xuQjVPakUxTVMweE5UZ0tJQ0FnSUM4dklISmxkSFZ5YmlCaGNtTTBMbFIxY0d4bEtBb2dJQ0FnTHk4Z0lDQWdJQ2dLSUNBZ0lDOHZJQ0FnSUNBZ0lDQWdZWEpqTkM1VlNXNTBOalFvYzJWc1ppNTBiM1JoYkY5d2NtOWpaWE56WldRdWRtRnNkV1VwTEFvZ0lDQWdMeThnSUNBZ0lDQWdJQ0JoY21NMExsVkpiblEyTkNoelpXeG1MblJ2ZEdGc1gzUnZYM0J2YjJ3dWRtRnNkV1VwTEFvZ0lDQWdMeThnSUNBZ0lDQWdJQ0JoY21NMExsVkpiblEyTkNoelpXeG1MblJ2ZEdGc1gzUnZYM1J5WldGemRYSjVMblpoYkhWbEtTd0tJQ0FnSUM4dklDQWdJQ0FnSUNBZ1lYSmpOQzVWU1c1ME5qUW9jMlZzWmk1MGIzUmhiRjkwYjE5cGJuTjFjbUZ1WTJVdWRtRnNkV1VwTEFvZ0lDQWdMeThnSUNBZ0lDa0tJQ0FnSUM4dklDa0tJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJR05oWkdWdVkybGhMM0psY0dGNWJXVnVkRjlsYzJOeWIzY3VjSGs2TVRRMkNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUdKNWRHVmpJRGtnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCallXUmxibU5wWVM1eVpYQmhlVzFsYm5SZlpYTmpjbTkzTGxKbGNHRjViV1Z1ZEVWelkzSnZkeTVuWlhSZmMzQnNhWFJmY0hKbGRtbGxkMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21kbGRGOXpjR3hwZEY5d2NtVjJhV1YzT2dvZ0lDQWdMeThnWTJGa1pXNWphV0V2Y21Wd1lYbHRaVzUwWDJWelkzSnZkeTV3ZVRveE5qQUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJR05oWkdWdVkybGhMM0psY0dGNWJXVnVkRjlsYzJOeWIzY3VjSGs2TVRZMUNpQWdJQ0F2THlCMGNtVmhjM1Z5ZVY5aGJXOTFiblFnUFNBb1lXMXZkVzUwSUNvZ1ZGSkZRVk5WVWxsZlUwaEJVa1ZmUWxCVEtTQXZMeUJDVUZOZlJFVk9UMDFKVGtGVVQxSUtJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0F4TlRBd0NpQWdJQ0FxQ2lBZ0lDQnBiblJqWHpNZ0x5OGdNVEF3TURBS0lDQWdJQzhLSUNBZ0lDOHZJR05oWkdWdVkybGhMM0psY0dGNWJXVnVkRjlsYzJOeWIzY3VjSGs2TVRZMkNpQWdJQ0F2THlCcGJuTjFjbUZ1WTJWZllXMXZkVzUwSUQwZ0tHRnRiM1Z1ZENBcUlFbE9VMVZTUVU1RFJWOVRTRUZTUlY5Q1VGTXBJQzh2SUVKUVUxOUVSVTVQVFVsT1FWUlBVZ29nSUNBZ1pHbG5JREVLSUNBZ0lIQjFjMmhwYm5RZ05UQXdDaUFnSUNBcUNpQWdJQ0JwYm5Salh6TWdMeThnTVRBd01EQUtJQ0FnSUM4S0lDQWdJQzh2SUdOaFpHVnVZMmxoTDNKbGNHRjViV1Z1ZEY5bGMyTnliM2N1Y0hrNk1UWTNDaUFnSUNBdkx5QndiMjlzWDJGdGIzVnVkQ0E5SUdGdGIzVnVkQ0F0SUhSeVpXRnpkWEo1WDJGdGIzVnVkQ0F0SUdsdWMzVnlZVzVqWlY5aGJXOTFiblFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWkdsbklESUtJQ0FnSUMwS0lDQWdJR1JwWnlBeENpQWdJQ0F0Q2lBZ0lDQXZMeUJqWVdSbGJtTnBZUzl5WlhCaGVXMWxiblJmWlhOamNtOTNMbkI1T2pFM01Bb2dJQ0FnTHk4Z1lYSmpOQzVWU1c1ME5qUW9jRzl2YkY5aGJXOTFiblFwTEFvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnWTJGa1pXNWphV0V2Y21Wd1lYbHRaVzUwWDJWelkzSnZkeTV3ZVRveE56RUtJQ0FnSUM4dklHRnlZelF1VlVsdWREWTBLSFJ5WldGemRYSjVYMkZ0YjNWdWRDa3NDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUdOaFpHVnVZMmxoTDNKbGNHRjViV1Z1ZEY5bGMyTnliM2N1Y0hrNk1UY3lDaUFnSUNBdkx5QmhjbU0wTGxWSmJuUTJOQ2hwYm5OMWNtRnVZMlZmWVcxdmRXNTBLU3dLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z1kyRmtaVzVqYVdFdmNtVndZWGx0Wlc1MFgyVnpZM0p2ZHk1d2VUb3hOamd0TVRjMENpQWdJQ0F2THlCeVpYUjFjbTRnWVhKak5DNVVkWEJzWlNnS0lDQWdJQzh2SUNBZ0lDQW9DaUFnSUNBdkx5QWdJQ0FnSUNBZ0lHRnlZelF1VlVsdWREWTBLSEJ2YjJ4ZllXMXZkVzUwS1N3S0lDQWdJQzh2SUNBZ0lDQWdJQ0FnWVhKak5DNVZTVzUwTmpRb2RISmxZWE4xY25sZllXMXZkVzUwS1N3S0lDQWdJQzh2SUNBZ0lDQWdJQ0FnWVhKak5DNVZTVzUwTmpRb2FXNXpkWEpoYm1ObFgyRnRiM1Z1ZENrc0NpQWdJQ0F2THlBZ0lDQWdLUW9nSUNBZ0x5OGdLUW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklHTmhaR1Z1WTJsaEwzSmxjR0Y1YldWdWRGOWxjMk55YjNjdWNIazZNVFl3Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJR0o1ZEdWaklEa2dMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200SyIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBQUVna0U0bUNnVmhaRzFwYmdwMGIzUmhiRjl3Y205akIzUnZYM0J2YjJ3SWRHOWZkSEpsWVhNSmRHOWZhVzV6ZFhKbENIUnlaV0Z6ZFhKNUNXbHVjM1Z5WVc1alpRaHNiMkZ1WDIxbmNnZHdiMjlzWDJsa0JCVWZmSFV4R1JSRU1SaEJBQ3VDQlFUODJNcXZCQmFOQ1ZFRWJmRmhnd1RmQ2JZSUJDR3I3eDAyR2dDT0JRQmhBSGNBalFFNUFWOEFnQVFDMENvRk5ob0FqZ0VBQVFBMkdnRkpGU1FTUkRZYUFra1ZnUWdTUkJjMkdnTkpGWUVJRWtRWE5ob0VTUlVrRWtRMkdnVkpGU1FTUkNoUEJXY25CMDhFWnljSVR3Tm5Kd1ZQQW1jbkJreG5LU0puS2lKbkt5Sm5Kd1FpWnlORE5ob0JTUlVrRWtReEFDSW9aVVFTUkNjRlRHY2pRellhQVVrVkpCSkVNUUFpS0dWRUVrUW5Ca3huSTBNeEZpTUpTVGdRSXhKRU1nMGlKd2RsUkJKQUFBb3hBQ0lvWlVRU1FRQ0pJMFJIQWpnSE1nb1NSRGdJU1VSSmdkd0xDeVVLU3dHQjlBTUxKUXBMQWtzQ0NVc0JDYkVpSndWbFJFc0RzZ2l5QnlPeUVDS3lBYk94SWljR1pVUkxBcklJc2djanNoQWlzZ0d6SWljSVpVU3hjZ2hFU3dHeUNMSUhJN0lRSXJJQnN5SXBaVVJQQkFncFRHY2lLbVZFQ0NwTVp5SXJaVVJQQWdnclRHY2lKd1JsUkFnbkJFeG5JME1pUXY5MElpbGxSQllpS21WRUZpSXJaVVFXSWljRVpVUVdUd05QQTFCUEFsQk1VQ2NKVEZDd0kwTTJHZ0ZKRllFSUVrUVhTWUhjQ3dzbENrc0JnZlFEQ3lVS1R3SkxBZ2xMQVFrV1R3SVdUd0lXVGdKUVRGQW5DVXhRc0NORCIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjgsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
