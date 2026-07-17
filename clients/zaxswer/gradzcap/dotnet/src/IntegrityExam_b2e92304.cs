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

namespace Arc56.Generated.zaxswer.gradzcap.IntegrityExam_b2e92304
{


    public class IntegrityExamProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public IntegrityExamProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class StudentData : AVMObjectType
            {
                public ulong StakedAmount { get; set; }

                public ulong Marks { get; set; }

                public ulong CheatCount { get; set; }

                public ulong IsExamActive { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStakedAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vStakedAmount.From(StakedAmount);
                    ret.AddRange(vStakedAmount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMarks = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vMarks.From(Marks);
                    ret.AddRange(vMarks.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCheatCount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vCheatCount.From(CheatCount);
                    ret.AddRange(vCheatCount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIsExamActive = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vIsExamActive.From(IsExamActive);
                    ret.AddRange(vIsExamActive.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static StudentData Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new StudentData();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStakedAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vStakedAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueStakedAmount = vStakedAmount.ToValue();
                    if (valueStakedAmount is ulong vStakedAmountValue) { ret.StakedAmount = vStakedAmountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMarks = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vMarks.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueMarks = vMarks.ToValue();
                    if (valueMarks is ulong vMarksValue) { ret.Marks = vMarksValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCheatCount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vCheatCount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCheatCount = vCheatCount.ToValue();
                    if (valueCheatCount is ulong vCheatCountValue) { ret.CheatCount = vCheatCountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIsExamActive = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vIsExamActive.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueIsExamActive = vIsExamActive.ToValue();
                    if (valueIsExamActive is ulong vIsExamActiveValue) { ret.IsExamActive = vIsExamActiveValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as StudentData);
                }
                public bool Equals(StudentData? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(StudentData left, StudentData right)
                {
                    return EqualityComparer<StudentData>.Default.Equals(left, right);
                }
                public static bool operator !=(StudentData left, StudentData right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="gzc_id"> </param>
        public async Task CreateApplication(ulong gzc_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 160, 59, 129, 210 };
            var gzc_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); gzc_idAbi.From(gzc_id);

            var result = await base.CallApp(new List<object> { abiHandle, gzc_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(ulong gzc_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 160, 59, 129, 210 };
            var gzc_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); gzc_idAbi.From(gzc_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, gzc_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="gzc_asset"> </param>
        public async Task OptInToAsset(ulong gzc_asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 223, 84, 232, 170 };
            var gzc_assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); gzc_assetAbi.From(gzc_asset);

            var result = await base.CallApp(new List<object> { abiHandle, gzc_assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> OptInToAsset_Transactions(ulong gzc_asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 223, 84, 232, 170 };
            var gzc_assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); gzc_assetAbi.From(gzc_asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, gzc_assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task ClaimDemoTokens(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 17, 19, 52, 24 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ClaimDemoTokens_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 17, 19, 52, 24 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="stake_pmt"> </param>
        public async Task StakeAndStart(AssetTransferTransaction stake_pmt, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { stake_pmt });
            byte[] abiHandle = { 230, 148, 94, 23 };

            var result = await base.CallApp(new List<object> { abiHandle, stake_pmt }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> StakeAndStart_Transactions(AssetTransferTransaction stake_pmt, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { stake_pmt });
            byte[] abiHandle = { 230, 148, 94, 23 };

            return await base.MakeTransactionList(new List<object> { abiHandle, stake_pmt }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="student"> </param>
        public async Task RecordCheat(Algorand.Address student, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 111, 112, 58, 81 };
            var studentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); studentAbi.From(student);

            var result = await base.CallApp(new List<object> { abiHandle, studentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RecordCheat_Transactions(Algorand.Address student, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 111, 112, 58, 81 };
            var studentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); studentAbi.From(student);

            return await base.MakeTransactionList(new List<object> { abiHandle, studentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="student"> </param>
        /// <param name="final_marks"> </param>
        public async Task CompleteExam(Algorand.Address student, ulong final_marks, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 13, 209, 24, 150 };
            var studentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); studentAbi.From(student);
            var final_marksAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); final_marksAbi.From(final_marks);

            var result = await base.CallApp(new List<object> { abiHandle, studentAbi, final_marksAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CompleteExam_Transactions(Algorand.Address student, ulong final_marks, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 13, 209, 24, 150 };
            var studentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); studentAbi.From(student);
            var final_marksAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); final_marksAbi.From(final_marks);

            return await base.MakeTransactionList(new List<object> { abiHandle, studentAbi, final_marksAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="amount"> </param>
        public async Task AdminWithdraw(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 157, 187, 74, 118 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AdminWithdraw_Transactions(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 157, 187, 74, 118 };
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiSW50ZWdyaXR5RXhhbSIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJTdHVkZW50RGF0YSI6W3sibmFtZSI6InN0YWtlZF9hbW91bnQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoibWFya3MiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiY2hlYXRfY291bnQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiaXNfZXhhbV9hY3RpdmUiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZV9hcHBsaWNhdGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJnemNfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoib3B0X2luX3RvX2Fzc2V0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Imd6Y19hc3NldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjbGFpbV9kZW1vX3Rva2VucyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzdGFrZV9hbmRfc3RhcnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYXhmZXIiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzdGFrZV9wbXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVjb3JkX2NoZWF0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzdHVkZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNvbXBsZXRlX2V4YW0iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InN0dWRlbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpbmFsX21hcmtzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFkbWluX3dpdGhkcmF3IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MiwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzIwMF0sImVycm9yTWVzc2FnZSI6IkFscmVhZHkgY2xhaW1lZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2OV0sImVycm9yTWVzc2FnZSI6IkFzc2V0IG1pc21hdGNoIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjU4XSwiZXJyb3JNZXNzYWdlIjoiRXhhbSBpbiBwcm9ncmVzcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2MSw0OThdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGNyZWF0b3IiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMjksMzk3XSwiZXJyb3JNZXNzYWdlIjoiT25seSBwcm9jdG9yIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTY1LDIwNSwyNzIsNDI3LDQ2MCw1MDNdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmd6Y19hc2FfaWQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDMxXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5zY2hvbGFyc2hpcF9hbW91bnQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzM1LDQwOV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuc3R1ZGVudF9yZWNvcmRzIGVudHJ5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMyMywzODJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTMyLDE1NCwzOTAsNDkxXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjQ5XSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBheGZlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXdJREVnTkNBNENpQWdJQ0JpZVhSbFkySnNiMk5ySUNKbmVtTmZZWE5oWDJsa0lpQXdlRGN6SUNKelkyaHZiR0Z5YzJocGNGOWhiVzkxYm5RaUNpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1ltNTZJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF5Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12U1c1MFpXZHlhWFI1UlhoaGJTNXdlVG95TlFvZ0lDQWdMeThnYzJWc1ppNW5lbU5mWVhOaFgybGtJQ0FnSUNBZ0lDQWdQU0JWU1c1ME5qUW9NQ2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbWQ2WTE5aGMyRmZhV1FpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlKYm5SbFozSnBkSGxGZUdGdExuQjVPakkyQ2lBZ0lDQXZMeUJ6Wld4bUxuTmphRzlzWVhKemFHbHdYMkZ0YjNWdWRDQTlJRlZKYm5RMk5DZ3dLUW9nSUNBZ1lubDBaV05mTWlBdkx5QWljMk5vYjJ4aGNuTm9hWEJmWVcxdmRXNTBJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDZ3B0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpvS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5SmJuUmxaM0pwZEhsRmVHRnRMbkI1T2pFNUNpQWdJQ0F2THlCamJHRnpjeUJKYm5SbFozSnBkSGxGZUdGdEtFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVpQnRZV2x1WDJOeVpXRjBaVjlPYjA5d1FERXlDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjRaR1kxTkdVNFlXRWdNSGd4TVRFek16UXhPQ0F3ZUdVMk9UUTFaVEUzSURCNE5tWTNNRE5oTlRFZ01IZ3daR1F4TVRnNU5pQXdlRGxrWW1JMFlUYzJJQzh2SUcxbGRHaHZaQ0FpYjNCMFgybHVYM1J2WDJGemMyVjBLSFZwYm5RMk5DbDJiMmxrSWl3Z2JXVjBhRzlrSUNKamJHRnBiVjlrWlcxdlgzUnZhMlZ1Y3lncGRtOXBaQ0lzSUcxbGRHaHZaQ0FpYzNSaGEyVmZZVzVrWDNOMFlYSjBLR0Y0Wm1WeUtYWnZhV1FpTENCdFpYUm9iMlFnSW5KbFkyOXlaRjlqYUdWaGRDaGhaR1J5WlhOektYWnZhV1FpTENCdFpYUm9iMlFnSW1OdmJYQnNaWFJsWDJWNFlXMG9ZV1JrY21WemN5eDFhVzUwTmpRcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWVdSdGFXNWZkMmwwYUdSeVlYY29kV2x1ZERZMEtYWnZhV1FpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCdmNIUmZhVzVmZEc5ZllYTnpaWFFnWTJ4aGFXMWZaR1Z0YjE5MGIydGxibk1nYzNSaGEyVmZZVzVrWDNOMFlYSjBJSEpsWTI5eVpGOWphR1ZoZENCamIyMXdiR1YwWlY5bGVHRnRJR0ZrYldsdVgzZHBkR2hrY21GM0NpQWdJQ0JsY25JS0NtMWhhVzVmWTNKbFlYUmxYMDV2VDNCQU1USTZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZTVzUwWldkeWFYUjVSWGhoYlM1d2VUb3hPUW9nSUNBZ0x5OGdZMnhoYzNNZ1NXNTBaV2R5YVhSNVJYaGhiU2hCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnY0hWemFHSjVkR1Z6SURCNFlUQXpZamd4WkRJZ0x5OGdiV1YwYUc5a0lDSmpjbVZoZEdWZllYQndiR2xqWVhScGIyNG9kV2x1ZERZMEtYWnZhV1FpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCamNtVmhkR1ZmWVhCd2JHbGpZWFJwYjI0S0lDQWdJR1Z5Y2dvS0NpOHZJRWx1ZEdWbmNtbDBlVVY0WVcwdVNXNTBaV2R5YVhSNVJYaGhiUzVqY21WaGRHVmZZWEJ3YkdsallYUnBiMjViY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwamNtVmhkR1ZmWVhCd2JHbGpZWFJwYjI0NkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlNXNTBaV2R5YVhSNVJYaGhiUzV3ZVRveU9Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0dOeVpXRjBaVDBpY21WeGRXbHlaU0lwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlNXNTBaV2R5YVhSNVJYaGhiUzV3ZVRvek1Bb2dJQ0FnTHk4Z2MyVnNaaTVuZW1OZllYTmhYMmxrSUNBZ0lDQWdJQ0FnUFNCbmVtTmZhV1F1YVdRS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1kNlkxOWhjMkZmYVdRaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwbHVkR1ZuY21sMGVVVjRZVzB1Y0hrNk16RUtJQ0FnSUM4dklITmxiR1l1YzJOb2IyeGhjbk5vYVhCZllXMXZkVzUwSUQwZ1ZVbHVkRFkwS0RFd1h6QXdNRjh3TURCZk1EQXdLUW9nSUNBZ1lubDBaV05mTWlBdkx5QWljMk5vYjJ4aGNuTm9hWEJmWVcxdmRXNTBJZ29nSUNBZ2NIVnphR2x1ZENBeE1EQXdNREF3TURBd01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OUpiblJsWjNKcGRIbEZlR0Z0TG5CNU9qSTRDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb1kzSmxZWFJsUFNKeVpYRjFhWEpsSWlrS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJKYm5SbFozSnBkSGxGZUdGdExrbHVkR1ZuY21sMGVVVjRZVzB1YjNCMFgybHVYM1J2WDJGemMyVjBXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYjNCMFgybHVYM1J2WDJGemMyVjBPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMGx1ZEdWbmNtbDBlVVY0WVcwdWNIazZNek1LSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMGx1ZEdWbmNtbDBlVVY0WVcwdWNIazZNelVLSUNBZ0lDOHZJR0Z6YzJWeWRDQlVlRzR1YzJWdVpHVnlJRDA5SUVkc2IySmhiQzVqY21WaGRHOXlYMkZrWkhKbGMzTXNJQ0pQYm14NUlHTnlaV0YwYjNJaUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQm5iRzlpWVd3Z1EzSmxZWFJ2Y2tGa1pISmxjM01LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNXNlU0JqY21WaGRHOXlDaUFnSUNBdkx5QmpiMjUwY21GamRITXZTVzUwWldkeWFYUjVSWGhoYlM1d2VUb3pOZ29nSUNBZ0x5OGdZWE56WlhKMElHZDZZMTloYzNObGRDNXBaQ0E5UFNCelpXeG1MbWQ2WTE5aGMyRmZhV1FzSUNKQmMzTmxkQ0J0YVhOdFlYUmphQ0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSm5lbU5mWVhOaFgybGtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1kNlkxOWhjMkZmYVdRZ1pYaHBjM1J6Q2lBZ0lDQmthV2NnTVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkJjM05sZENCdGFYTnRZWFJqYUFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDBsdWRHVm5jbWwwZVVWNFlXMHVjSGs2TXpjdE5ERUtJQ0FnSUM4dklHbDBlRzR1UVhOelpYUlVjbUZ1YzJabGNpZ0tJQ0FnSUM4dklDQWdJQ0I0Wm1WeVgyRnpjMlYwUFdkNlkxOWhjM05sZEN3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5eVpXTmxhWFpsY2oxSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDJGdGIzVnVkRDB3TEFvZ0lDQWdMeThnS1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMGx1ZEdWbmNtbDBlVVY0WVcwdWNIazZNemtLSUNBZ0lDOHZJR0Z6YzJWMFgzSmxZMlZwZG1WeVBVZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNc0NpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwbHVkR1ZuY21sMGVVVjRZVzB1Y0hrNk5EQUtJQ0FnSUM4dklHRnpjMlYwWDJGdGIzVnVkRDB3TEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWE56WlhSQmJXOTFiblFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWE56WlhSU1pXTmxhWFpsY2dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JZWm1WeVFYTnpaWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlKYm5SbFozSnBkSGxGZUdGdExuQjVPak0zQ2lBZ0lDQXZMeUJwZEhodUxrRnpjMlYwVkhKaGJuTm1aWElvQ2lBZ0lDQnBiblJqWHpJZ0x5OGdZWGhtWlhJS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMGx1ZEdWbmNtbDBlVVY0WVcwdWNIazZNemN0TkRFS0lDQWdJQzh2SUdsMGVHNHVRWE56WlhSVWNtRnVjMlpsY2lnS0lDQWdJQzh2SUNBZ0lDQjRabVZ5WDJGemMyVjBQV2Q2WTE5aGMzTmxkQ3dLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRjl5WldObGFYWmxjajFIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYMkZ0YjNWdWREMHdMQW9nSUNBZ0x5OGdLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OUpiblJsWjNKcGRIbEZlR0Z0TG5CNU9qTXpDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJKYm5SbFozSnBkSGxGZUdGdExrbHVkR1ZuY21sMGVVVjRZVzB1WTJ4aGFXMWZaR1Z0YjE5MGIydGxibk5iY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwamJHRnBiVjlrWlcxdlgzUnZhMlZ1Y3pvS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5SmJuUmxaM0pwZEhsRmVHRnRMbkI1T2pRMkNpQWdJQ0F2THlCaGMzTmxjblFnYzJWdVpHVnlYMkZrWkhKbGMzTWdibTkwSUdsdUlITmxiR1l1YUdGelgyTnNZV2x0WldSZlpHVnRieXdnSWtGc2NtVmhaSGtnWTJ4aGFXMWxaQ0lLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRFkwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12U1c1MFpXZHlhWFI1UlhoaGJTNXdlVG8wTlFvZ0lDQWdMeThnYzJWdVpHVnlYMkZrWkhKbGMzTWdQU0JoY21NMExrRmtaSEpsYzNNb1ZIaHVMbk5sYm1SbGNpa0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5SmJuUmxaM0pwZEhsRmVHRnRMbkI1T2pRMkNpQWdJQ0F2THlCaGMzTmxjblFnYzJWdVpHVnlYMkZrWkhKbGMzTWdibTkwSUdsdUlITmxiR1l1YUdGelgyTnNZV2x0WldSZlpHVnRieXdnSWtGc2NtVmhaSGtnWTJ4aGFXMWxaQ0lLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJCYkhKbFlXUjVJR05zWVdsdFpXUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OUpiblJsWjNKcGRIbEZlR0Z0TG5CNU9qUTNMVFV4Q2lBZ0lDQXZMeUJwZEhodUxrRnpjMlYwVkhKaGJuTm1aWElvQ2lBZ0lDQXZMeUFnSUNBZ2VHWmxjbDloYzNObGREMUJjM05sZENoelpXeG1MbWQ2WTE5aGMyRmZhV1FwTEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDNKbFkyVnBkbVZ5UFZSNGJpNXpaVzVrWlhJc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZllXMXZkVzUwUFZWSmJuUTJOQ2d4WHpBd01GOHdNREJmTURBd0tTd0tJQ0FnSUM4dklDa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5SmJuUmxaM0pwZEhsRmVHRnRMbkI1T2pRNENpQWdJQ0F2THlCNFptVnlYMkZ6YzJWMFBVRnpjMlYwS0hObGJHWXVaM3BqWDJGellWOXBaQ2tzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlaM3BqWDJGellWOXBaQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1bmVtTmZZWE5oWDJsa0lHVjRhWE4wY3dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDBsdWRHVm5jbWwwZVVWNFlXMHVjSGs2TkRrS0lDQWdJQzh2SUdGemMyVjBYM0psWTJWcGRtVnlQVlI0Ymk1elpXNWtaWElzQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QmpiMjUwY21GamRITXZTVzUwWldkeWFYUjVSWGhoYlM1d2VUbzFNQW9nSUNBZ0x5OGdZWE56WlhSZllXMXZkVzUwUFZWSmJuUTJOQ2d4WHpBd01GOHdNREJmTURBd0tTd0tJQ0FnSUhCMWMyaHBiblFnTVRBd01EQXdNREF3TUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYzNObGRFRnRiM1Z1ZEFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYzNObGRGSmxZMlZwZG1WeUNpQWdJQ0JwZEhodVgyWnBaV3hrSUZobVpYSkJjM05sZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDBsdWRHVm5jbWwwZVVWNFlXMHVjSGs2TkRjS0lDQWdJQzh2SUdsMGVHNHVRWE56WlhSVWNtRnVjMlpsY2lnS0lDQWdJR2x1ZEdOZk1pQXZMeUJoZUdabGNnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12U1c1MFpXZHlhWFI1UlhoaGJTNXdlVG8wTnkwMU1Rb2dJQ0FnTHk4Z2FYUjRiaTVCYzNObGRGUnlZVzV6Wm1WeUtBb2dJQ0FnTHk4Z0lDQWdJSGhtWlhKZllYTnpaWFE5UVhOelpYUW9jMlZzWmk1bmVtTmZZWE5oWDJsa0tTd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGOXlaV05sYVhabGNqMVVlRzR1YzJWdVpHVnlMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYMkZ0YjNWdWREMVZTVzUwTmpRb01WOHdNREJmTURBd1h6QXdNQ2tzQ2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMGx1ZEdWbmNtbDBlVVY0WVcwdWNIazZOVElLSUNBZ0lDOHZJSE5sYkdZdWFHRnpYMk5zWVdsdFpXUmZaR1Z0YjF0elpXNWtaWEpmWVdSa2NtVnpjMTBnUFNCaGNtTTBMbFZKYm5RMk5DZ3hLUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREF3TURBd01EQXdNREF3TURBd01Rb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMGx1ZEdWbmNtbDBlVVY0WVcwdWNIazZORE1LSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUVsdWRHVm5jbWwwZVVWNFlXMHVTVzUwWldkeWFYUjVSWGhoYlM1emRHRnJaVjloYm1SZmMzUmhjblJiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwemRHRnJaVjloYm1SZmMzUmhjblE2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12U1c1MFpXZHlhWFI1UlhoaGJTNXdlVG8xTkFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUMwS0lDQWdJR1IxY0FvZ0lDQWdaM1I0Ym5NZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1pQXZMeUJoZUdabGNnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUIwY21GdWMyRmpkR2x2YmlCMGVYQmxJR2x6SUdGNFptVnlDaUFnSUNBdkx5QmpiMjUwY21GamRITXZTVzUwWldkeWFYUjVSWGhoYlM1d2VUbzFOZ29nSUNBZ0x5OGdZWE56WlhKMElHRnlZelF1UVdSa2NtVnpjeWhVZUc0dWMyVnVaR1Z5S1NCdWIzUWdhVzRnYzJWc1ppNXpkSFZrWlc1MFgzSmxZMjl5WkhNc0lDSkZlR0Z0SUdsdUlIQnliMmR5WlhOeklnb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEY3pDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFVjRZVzBnYVc0Z2NISnZaM0psYzNNS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5SmJuUmxaM0pwZEhsRmVHRnRMbkI1T2pVM0NpQWdJQ0F2THlCaGMzTmxjblFnYzNSaGEyVmZjRzEwTG1GemMyVjBYM0psWTJWcGRtVnlJRDA5SUVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01LSUNBZ0lHUjFjQW9nSUNBZ1ozUjRibk1nUVhOelpYUlNaV05sYVhabGNnb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OUpiblJsWjNKcGRIbEZlR0Z0TG5CNU9qVTRDaUFnSUNBdkx5QmhjM05sY25RZ2MzUmhhMlZmY0cxMExuaG1aWEpmWVhOelpYUXVhV1FnUFQwZ2MyVnNaaTVuZW1OZllYTmhYMmxrQ2lBZ0lDQmtkWEFLSUNBZ0lHZDBlRzV6SUZobVpYSkJjM05sZEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbWQ2WTE5aGMyRmZhV1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVozcGpYMkZ6WVY5cFpDQmxlR2x6ZEhNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5SmJuUmxaM0pwZEhsRmVHRnRMbkI1T2pVNUNpQWdJQ0F2THlCaGMzTmxjblFnYzNSaGEyVmZjRzEwTG1GemMyVjBYMkZ0YjNWdWRDQStJREFLSUNBZ0lHZDBlRzV6SUVGemMyVjBRVzF2ZFc1MENpQWdJQ0JrZFhBS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwbHVkR1ZuY21sMGVVVjRZVzB1Y0hrNk5qRUtJQ0FnSUM4dklITjBZV3RsWkY5aGJXOTFiblE5WVhKak5DNVZTVzUwTmpRb2MzUmhhMlZmY0cxMExtRnpjMlYwWDJGdGIzVnVkQ2tzQ2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12U1c1MFpXZHlhWFI1UlhoaGJTNXdlVG8yTUMwMk5Rb2dJQ0FnTHk4Z2MyVnNaaTV6ZEhWa1pXNTBYM0psWTI5eVpITmJZWEpqTkM1QlpHUnlaWE56S0ZSNGJpNXpaVzVrWlhJcFhTQTlJRk4wZFdSbGJuUkVZWFJoS0FvZ0lDQWdMeThnSUNBZ0lITjBZV3RsWkY5aGJXOTFiblE5WVhKak5DNVZTVzUwTmpRb2MzUmhhMlZmY0cxMExtRnpjMlYwWDJGdGIzVnVkQ2tzQ2lBZ0lDQXZMeUFnSUNBZ2JXRnlhM005WVhKak5DNVZTVzUwTmpRb01Da3NDaUFnSUNBdkx5QWdJQ0FnWTJobFlYUmZZMjkxYm5ROVlYSmpOQzVWU1c1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFnSUNBZ2FYTmZaWGhoYlY5aFkzUnBkbVU5WVhKak5DNVZTVzUwTmpRb01Ta3NDaUFnSUNBdkx5QXBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDBsdWRHVm5jbWwwZVVWNFlXMHVjSGs2TmpBS0lDQWdJQzh2SUhObGJHWXVjM1IxWkdWdWRGOXlaV052Y21SelcyRnlZelF1UVdSa2NtVnpjeWhVZUc0dWMyVnVaR1Z5S1YwZ1BTQlRkSFZrWlc1MFJHRjBZU2dLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGczTXdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12U1c1MFpXZHlhWFI1UlhoaGJTNXdlVG8yTUMwMk5Rb2dJQ0FnTHk4Z2MyVnNaaTV6ZEhWa1pXNTBYM0psWTI5eVpITmJZWEpqTkM1QlpHUnlaWE56S0ZSNGJpNXpaVzVrWlhJcFhTQTlJRk4wZFdSbGJuUkVZWFJoS0FvZ0lDQWdMeThnSUNBZ0lITjBZV3RsWkY5aGJXOTFiblE5WVhKak5DNVZTVzUwTmpRb2MzUmhhMlZmY0cxMExtRnpjMlYwWDJGdGIzVnVkQ2tzQ2lBZ0lDQXZMeUFnSUNBZ2JXRnlhM005WVhKak5DNVZTVzUwTmpRb01Da3NDaUFnSUNBdkx5QWdJQ0FnWTJobFlYUmZZMjkxYm5ROVlYSmpOQzVWU1c1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFnSUNBZ2FYTmZaWGhoYlY5aFkzUnBkbVU5WVhKak5DNVZTVzUwTmpRb01Ta3NDaUFnSUNBdkx5QXBDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12U1c1MFpXZHlhWFI1UlhoaGJTNXdlVG8xTkFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z1NXNTBaV2R5YVhSNVJYaGhiUzVKYm5SbFozSnBkSGxGZUdGdExuSmxZMjl5WkY5amFHVmhkRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25KbFkyOXlaRjlqYUdWaGREb0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OUpiblJsWjNKcGRIbEZlR0Z0TG5CNU9qWTNDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlKYm5SbFozSnBkSGxGZUdGdExuQjVPalk1Q2lBZ0lDQXZMeUJoYzNObGNuUWdWSGh1TG5ObGJtUmxjaUE5UFNCSGJHOWlZV3d1WTNKbFlYUnZjbDloWkdSeVpYTnpMQ0FpVDI1c2VTQndjbTlqZEc5eUlnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdaMnh2WW1Gc0lFTnlaV0YwYjNKQlpHUnlaWE56Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFOXViSGtnY0hKdlkzUnZjZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMGx1ZEdWbmNtbDBlVVY0WVcwdWNIazZOekFLSUNBZ0lDOHZJSEpsWTI5eVpDQWdJQ0FnUFNCelpXeG1Mbk4wZFdSbGJuUmZjbVZqYjNKa2MxdHpkSFZrWlc1MFhTNWpiM0I1S0NrS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnM013b2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1Mbk4wZFdSbGJuUmZjbVZqYjNKa2N5QmxiblJ5ZVNCbGVHbHpkSE1LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlKYm5SbFozSnBkSGxGZUdGdExuQjVPamN4Q2lBZ0lDQXZMeUJ1WlhkZlkyaGxZWFJ6SUQwZ2NtVmpiM0prTG1Ob1pXRjBYMk52ZFc1MExtNWhkR2wyWlNBcklERUtJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0F4TmdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXJDaUFnSUNBdkx5QmpiMjUwY21GamRITXZTVzUwWldkeWFYUjVSWGhoYlM1d2VUbzNNZ29nSUNBZ0x5OGdjbVZqYjNKa0xtTm9aV0YwWDJOdmRXNTBJRDBnWVhKak5DNVZTVzUwTmpRb2JtVjNYMk5vWldGMGN5a0tJQ0FnSUdSMWNBb2dJQ0FnYVhSdllnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnlaWEJzWVdObE1pQXhOZ29nSUNBZ2MzZGhjQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMGx1ZEdWbmNtbDBlVVY0WVcwdWNIazZOek1LSUNBZ0lDOHZJR2xtSUc1bGQxOWphR1ZoZEhNZ1BUMGdNem9LSUNBZ0lIQjFjMmhwYm5RZ013b2dJQ0FnUFQwS0lDQWdJR0o2SUhKbFkyOXlaRjlqYUdWaGRGOWhablJsY2w5cFpsOWxiSE5sUURNS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5SmJuUmxaM0pwZEhsRmVHRnRMbkI1T2pjMENpQWdJQ0F2THlCeVpXTnZjbVF1YzNSaGEyVmtYMkZ0YjNWdWRDQTlJR0Z5WXpRdVZVbHVkRFkwS0hKbFkyOXlaQzV6ZEdGclpXUmZZVzF2ZFc1MExtNWhkR2wyWlNBdkx5QXlLUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUhCMWMyaHBiblFnTWdvZ0lDQWdMd29nSUNBZ2FYUnZZZ29nSUNBZ2NtVndiR0ZqWlRJZ01Bb0tjbVZqYjNKa1gyTm9aV0YwWDJGbWRHVnlYMmxtWDJWc2MyVkFNem9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlKYm5SbFozSnBkSGxGZUdGdExuQjVPamMxQ2lBZ0lDQXZMeUJ6Wld4bUxuTjBkV1JsYm5SZmNtVmpiM0prYzF0emRIVmtaVzUwWFNBOUlISmxZMjl5WkM1amIzQjVLQ2tLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlNXNTBaV2R5YVhSNVJYaGhiUzV3ZVRvMk53b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdTVzUwWldkeWFYUjVSWGhoYlM1SmJuUmxaM0pwZEhsRmVHRnRMbU52YlhCc1pYUmxYMlY0WVcxYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGpiMjF3YkdWMFpWOWxlR0Z0T2dvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0lpQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12U1c1MFpXZHlhWFI1UlhoaGJTNXdlVG8zTndvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQnVJRElLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12U1c1MFpXZHlhWFI1UlhoaGJTNXdlVG8zT1FvZ0lDQWdMeThnWVhOelpYSjBJRlI0Ymk1elpXNWtaWElnUFQwZ1IyeHZZbUZzTG1OeVpXRjBiM0pmWVdSa2NtVnpjeXdnSWs5dWJIa2djSEp2WTNSdmNpSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2RzYjJKaGJDQkRjbVZoZEc5eVFXUmtjbVZ6Y3dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBibXg1SUhCeWIyTjBiM0lLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlKYm5SbFozSnBkSGxGZUdGdExuQjVPamd3Q2lBZ0lDQXZMeUJ5WldOdmNtUWdQU0J6Wld4bUxuTjBkV1JsYm5SZmNtVmpiM0prYzF0emRIVmtaVzUwWFM1amIzQjVLQ2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGczTXdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVjM1IxWkdWdWRGOXlaV052Y21SeklHVnVkSEo1SUdWNGFYTjBjd29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMGx1ZEdWbmNtbDBlVVY0WVcwdWNIazZPREVLSUNBZ0lDOHZJR2xtSUdacGJtRnNYMjFoY210eklENDlJRGd3SUdGdVpDQnlaV052Y21RdVkyaGxZWFJmWTI5MWJuUXVibUYwYVhabElEMDlJREE2Q2lBZ0lDQndkWE5vYVc1MElEZ3dDaUFnSUNBK1BRb2dJQ0FnWW5vZ1kyOXRjR3hsZEdWZlpYaGhiVjloWm5SbGNsOXBabDlsYkhObFFEVUtJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0F4TmdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR0p1ZWlCamIyMXdiR1YwWlY5bGVHRnRYMkZtZEdWeVgybG1YMlZzYzJWQU5Rb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwbHVkR1ZuY21sMGVVVjRZVzB1Y0hrNk9ESXRPRFlLSUNBZ0lDOHZJR2wwZUc0dVFYTnpaWFJVY21GdWMyWmxjaWdLSUNBZ0lDOHZJQ0FnSUNCNFptVnlYMkZ6YzJWMFBVRnpjMlYwS0hObGJHWXVaM3BqWDJGellWOXBaQ2tzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJmY21WalpXbDJaWEk5YzNSMVpHVnVkQzV1WVhScGRtVXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUmZZVzF2ZFc1MFBYTmxiR1l1YzJOb2IyeGhjbk5vYVhCZllXMXZkVzUwTEFvZ0lDQWdMeThnS1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMGx1ZEdWbmNtbDBlVVY0WVcwdWNIazZPRE1LSUNBZ0lDOHZJSGhtWlhKZllYTnpaWFE5UVhOelpYUW9jMlZzWmk1bmVtTmZZWE5oWDJsa0tTd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKbmVtTmZZWE5oWDJsa0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbWQ2WTE5aGMyRmZhV1FnWlhocGMzUnpDaUFnSUNBdkx5QmpiMjUwY21GamRITXZTVzUwWldkeWFYUjVSWGhoYlM1d2VUbzROUW9nSUNBZ0x5OGdZWE56WlhSZllXMXZkVzUwUFhObGJHWXVjMk5vYjJ4aGNuTm9hWEJmWVcxdmRXNTBMQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYeklnTHk4Z0luTmphRzlzWVhKemFHbHdYMkZ0YjNWdWRDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV6WTJodmJHRnljMmhwY0Y5aGJXOTFiblFnWlhocGMzUnpDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnpjMlYwUVcxdmRXNTBDaUFnSUNCa2FXY2dNd29nSUNBZ2FYUjRibDltYVdWc1pDQkJjM05sZEZKbFkyVnBkbVZ5Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRmhtWlhKQmMzTmxkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMGx1ZEdWbmNtbDBlVVY0WVcwdWNIazZPRElLSUNBZ0lDOHZJR2wwZUc0dVFYTnpaWFJVY21GdWMyWmxjaWdLSUNBZ0lHbHVkR05mTWlBdkx5QmhlR1psY2dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNBdkx5QmpiMjUwY21GamRITXZTVzUwWldkeWFYUjVSWGhoYlM1d2VUbzRNaTA0TmdvZ0lDQWdMeThnYVhSNGJpNUJjM05sZEZSeVlXNXpabVZ5S0FvZ0lDQWdMeThnSUNBZ0lIaG1aWEpmWVhOelpYUTlRWE56WlhRb2MyVnNaaTVuZW1OZllYTmhYMmxrS1N3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5eVpXTmxhWFpsY2oxemRIVmtaVzUwTG01aGRHbDJaU3dLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRjloYlc5MWJuUTljMlZzWmk1elkyaHZiR0Z5YzJocGNGOWhiVzkxYm5Rc0NpQWdJQ0F2THlBcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvS1kyOXRjR3hsZEdWZlpYaGhiVjloWm5SbGNsOXBabDlsYkhObFFEVTZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZTVzUwWldkeWFYUjVSWGhoYlM1d2VUbzROd29nSUNBZ0x5OGdhV1lnY21WamIzSmtMbk4wWVd0bFpGOWhiVzkxYm5RdWJtRjBhWFpsSUQ0Z01Eb0tJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ05Rb2dJQ0FnWW5vZ1kyOXRjR3hsZEdWZlpYaGhiVjloWm5SbGNsOXBabDlsYkhObFFEZ0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OUpiblJsWjNKcGRIbEZlR0Z0TG5CNU9qZzRMVGt5Q2lBZ0lDQXZMeUJwZEhodUxrRnpjMlYwVkhKaGJuTm1aWElvQ2lBZ0lDQXZMeUFnSUNBZ2VHWmxjbDloYzNObGREMUJjM05sZENoelpXeG1MbWQ2WTE5aGMyRmZhV1FwTEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDNKbFkyVnBkbVZ5UFhOMGRXUmxiblF1Ym1GMGFYWmxMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYMkZ0YjNWdWREMXlaV052Y21RdWMzUmhhMlZrWDJGdGIzVnVkQzV1WVhScGRtVXNDaUFnSUNBdkx5QXBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlNXNTBaV2R5YVhSNVJYaGhiUzV3ZVRvNE9Rb2dJQ0FnTHk4Z2VHWmxjbDloYzNObGREMUJjM05sZENoelpXeG1MbWQ2WTE5aGMyRmZhV1FwTEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbWQ2WTE5aGMyRmZhV1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVozcGpYMkZ6WVY5cFpDQmxlR2x6ZEhNS0lDQWdJR1JwWnlBMENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGemMyVjBRVzF2ZFc1MENpQWdJQ0JrYVdjZ013b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmMzTmxkRkpsWTJWcGRtVnlDaUFnSUNCcGRIaHVYMlpwWld4a0lGaG1aWEpCYzNObGRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwbHVkR1ZuY21sMGVVVjRZVzB1Y0hrNk9EZ0tJQ0FnSUM4dklHbDBlRzR1UVhOelpYUlVjbUZ1YzJabGNpZ0tJQ0FnSUdsdWRHTmZNaUF2THlCaGVHWmxjZ29nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlNXNTBaV2R5YVhSNVJYaGhiUzV3ZVRvNE9DMDVNZ29nSUNBZ0x5OGdhWFI0Ymk1QmMzTmxkRlJ5WVc1elptVnlLQW9nSUNBZ0x5OGdJQ0FnSUhobVpYSmZZWE56WlhROVFYTnpaWFFvYzJWc1ppNW5lbU5mWVhOaFgybGtLU3dLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRjl5WldObGFYWmxjajF6ZEhWa1pXNTBMbTVoZEdsMlpTd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGOWhiVzkxYm5ROWNtVmpiM0prTG5OMFlXdGxaRjloYlc5MWJuUXVibUYwYVhabExBb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0NtTnZiWEJzWlhSbFgyVjRZVzFmWVdaMFpYSmZhV1pmWld4elpVQTRPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMGx1ZEdWbmNtbDBlVVY0WVcwdWNIazZPVE1LSUNBZ0lDOHZJR1JsYkNCelpXeG1Mbk4wZFdSbGJuUmZjbVZqYjNKa2MxdHpkSFZrWlc1MFhRb2dJQ0FnWkdsbklERUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMGx1ZEdWbmNtbDBlVVY0WVcwdWNIazZOemNLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUVsdWRHVm5jbWwwZVVWNFlXMHVTVzUwWldkeWFYUjVSWGhoYlM1aFpHMXBibDkzYVhSb1pISmhkMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21Ga2JXbHVYM2RwZEdoa2NtRjNPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMGx1ZEdWbmNtbDBlVVY0WVcwdWNIazZPVFVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMGx1ZEdWbmNtbDBlVVY0WVcwdWNIazZPVGNLSUNBZ0lDOHZJR0Z6YzJWeWRDQlVlRzR1YzJWdVpHVnlJRDA5SUVkc2IySmhiQzVqY21WaGRHOXlYMkZrWkhKbGMzTXNJQ0pQYm14NUlHTnlaV0YwYjNJaUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQm5iRzlpWVd3Z1EzSmxZWFJ2Y2tGa1pISmxjM01LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNXNlU0JqY21WaGRHOXlDaUFnSUNBdkx5QmpiMjUwY21GamRITXZTVzUwWldkeWFYUjVSWGhoYlM1d2VUbzVPQzB4TURJS0lDQWdJQzh2SUdsMGVHNHVRWE56WlhSVWNtRnVjMlpsY2lnS0lDQWdJQzh2SUNBZ0lDQjRabVZ5WDJGemMyVjBQVUZ6YzJWMEtITmxiR1l1WjNwalgyRnpZVjlwWkNrc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZmNtVmpaV2wyWlhJOVIyeHZZbUZzTG1OeVpXRjBiM0pmWVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRjloYlc5MWJuUTlZVzF2ZFc1MExBb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDBsdWRHVm5jbWwwZVVWNFlXMHVjSGs2T1RrS0lDQWdJQzh2SUhobVpYSmZZWE56WlhROVFYTnpaWFFvYzJWc1ppNW5lbU5mWVhOaFgybGtLU3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSm5lbU5mWVhOaFgybGtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1kNlkxOWhjMkZmYVdRZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12U1c1MFpXZHlhWFI1UlhoaGJTNXdlVG94TURBS0lDQWdJQzh2SUdGemMyVjBYM0psWTJWcGRtVnlQVWRzYjJKaGJDNWpjbVZoZEc5eVgyRmtaSEpsYzNNc0NpQWdJQ0JuYkc5aVlXd2dRM0psWVhSdmNrRmtaSEpsYzNNS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjM05sZEVGdGIzVnVkQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjM05sZEZKbFkyVnBkbVZ5Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRmhtWlhKQmMzTmxkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMGx1ZEdWbmNtbDBlVVY0WVcwdWNIazZPVGdLSUNBZ0lDOHZJR2wwZUc0dVFYTnpaWFJVY21GdWMyWmxjaWdLSUNBZ0lHbHVkR05mTWlBdkx5QmhlR1psY2dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNBdkx5QmpiMjUwY21GamRITXZTVzUwWldkeWFYUjVSWGhoYlM1d2VUbzVPQzB4TURJS0lDQWdJQzh2SUdsMGVHNHVRWE56WlhSVWNtRnVjMlpsY2lnS0lDQWdJQzh2SUNBZ0lDQjRabVZ5WDJGemMyVjBQVUZ6YzJWMEtITmxiR1l1WjNwalgyRnpZVjlwWkNrc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZmNtVmpaV2wyWlhJOVIyeHZZbUZzTG1OeVpXRjBiM0pmWVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRjloYlc5MWJuUTlZVzF2ZFc1MExBb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5SmJuUmxaM0pwZEhsRmVHRnRMbkI1T2prMUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFBRUVDQ1lEQ21kNlkxOWhjMkZmYVdRQmN4SnpZMmh2YkdGeWMyaHBjRjloYlc5MWJuUXhHRUFBQmlnaVp5b2laekVaRkVReEdFRUFNb0lHQk45VTZLb0VFUk0wR0FUbWxGNFhCRzl3T2xFRURkRVlsZ1NkdTBwMk5ob0FqZ1lBSlFCUEFJSUF6UUVGQVhZQWdBU2dPNEhTTmhvQWpnRUFBUUEyR2dGSkZTVVNSQmNvVEdjcWdZRElyNkFsWnlORE5ob0JTUlVsRWtRWE1RQXlDUkpFSWlobFJFc0JFa1N4TWdvaXNoS3lGTElSSkxJUUlySUJzeU5EZ0FGa01RQlFTYjFGQVJSRXNTSW9aVVF4QUlHQWxPdmNBN0lTc2hTeUVTU3lFQ0t5QWJPQUNBQUFBQUFBQUFBQnZ5TkRNUllqQ1VrNEVDUVNSQ2t4QUZDOVJRRVVSRWs0RkRJS0VrUkpPQkVpS0dWRUVrUTRFa2xFRm9BWUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFCVUNreEFGQk12eU5ETmhvQlNSV0JJQkpFTVFBeUNSSkVLVXhRU2I1RVNZRVFXeU1JU1JaUEFreGNFRXlCQXhKQkFBbEpJbHVCQWdvV1hBQkxBVXkvSTBPQUFEWWFBVWNDRllFZ0VrUTJHZ0pKRlNVU1JCY3hBRElKRWtRcFR3SlFTVTRDdmt4T0FrU0JVQTlCQUI5SmdSQmJRQUFZc1NJb1pVUWlLbVZFc2hKTEE3SVVzaEVrc2hBaXNnR3pTU0piU1VVRlFRQVdzU0lvWlVSTEJMSVNTd095RkxJUkpMSVFJcklCczBzQnZFZ2pRellhQVVrVkpSSkVGekVBTWdrU1JMRWlLR1ZFTWdsUEFySVNzaFN5RVNTeUVDS3lBYk1qUXc9PSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjcsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
