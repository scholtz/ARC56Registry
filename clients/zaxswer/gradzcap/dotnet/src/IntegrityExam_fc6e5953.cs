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

namespace Arc56.Generated.zaxswer.gradzcap.IntegrityExam_fc6e5953
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
        ///Initialize the contract with the GZC Asset ID.
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
        ///Allow the contract to hold GZC tokens.
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
        ///Giveaway 1000 GZC for demo users.
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
        ///Student stakes GZC to start the exam.
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
        ///Proctor slashes 50% stake on 3rd strike.
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
        ///Grading and refunds.
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiSW50ZWdyaXR5RXhhbSIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJTdHVkZW50RGF0YSI6W3sibmFtZSI6InN0YWtlZF9hbW91bnQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoibWFya3MiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiY2hlYXRfY291bnQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiaXNfZXhhbV9hY3RpdmUiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZV9hcHBsaWNhdGlvbiIsImRlc2MiOiJJbml0aWFsaXplIHRoZSBjb250cmFjdCB3aXRoIHRoZSBHWkMgQXNzZXQgSUQuIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Imd6Y19pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJvcHRfaW5fdG9fYXNzZXQiLCJkZXNjIjoiQWxsb3cgdGhlIGNvbnRyYWN0IHRvIGhvbGQgR1pDIHRva2Vucy4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZ3pjX2Fzc2V0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNsYWltX2RlbW9fdG9rZW5zIiwiZGVzYyI6IkdpdmVhd2F5IDEwMDAgR1pDIGZvciBkZW1vIHVzZXJzLiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzdGFrZV9hbmRfc3RhcnQiLCJkZXNjIjoiU3R1ZGVudCBzdGFrZXMgR1pDIHRvIHN0YXJ0IHRoZSBleGFtLiIsImFyZ3MiOlt7InR5cGUiOiJheGZlciIsInN0cnVjdCI6bnVsbCwibmFtZSI6InN0YWtlX3BtdCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWNvcmRfY2hlYXQiLCJkZXNjIjoiUHJvY3RvciBzbGFzaGVzIDUwJSBzdGFrZSBvbiAzcmQgc3RyaWtlLiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3R1ZGVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjb21wbGV0ZV9leGFtIiwiZGVzYyI6IkdyYWRpbmcgYW5kIHJlZnVuZHMuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzdHVkZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaW5hbF9tYXJrcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MiwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzI0MF0sImVycm9yTWVzc2FnZSI6IkFscmVhZHkgY2xhaW1lZCBkZW1vIHRva2VucyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2Nl0sImVycm9yTWVzc2FnZSI6IkFzc2V0IElEIGFscmVhZHkgc2V0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTk0XSwiZXJyb3JNZXNzYWdlIjoiQXNzZXQgbWlzbWF0Y2giLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyOThdLCJlcnJvck1lc3NhZ2UiOiJFeGFtIGluIHByb2dyZXNzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTYwLDE4Nl0sImVycm9yTWVzc2FnZSI6Ik9ubHkgY3JlYXRvciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM2OSw0MzddLCJlcnJvck1lc3NhZ2UiOiJPbmx5IHByb2N0b3IiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjQsMTkwLDI0NSwzMTIsNDY3LDUwMF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuZ3pjX2FzYV9pZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NzFdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnNjaG9sYXJzaGlwX2Ftb3VudCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNzUsNDQ5XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5zdHVkZW50X3JlY29yZHMgZW50cnkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzYzLDQyMl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTMsMTc5LDQzMF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI4OV0sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgYXhmZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF3SURFZ05DQTRDaUFnSUNCaWVYUmxZMkpzYjJOcklDSm5lbU5mWVhOaFgybGtJaUFpYzNSMVpHVnVkRjl5WldOdmNtUnpJaUFpYzJOb2IyeGhjbk5vYVhCZllXMXZkVzUwSWdvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKdWVpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNZ29nSUNBZ0x5OGdTVzUwWldkeWFYUjVSWGhoYlM1d2VUb3lNaTB5TXdvZ0lDQWdMeThnSXlCSGJHOWlZV3dnVTNSaGRHVUtJQ0FnSUM4dklITmxiR1l1WjNwalgyRnpZVjlwWkNBOUlGVkpiblEyTkNnM05UWXpNakV4T0RncENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKbmVtTmZZWE5oWDJsa0lnb2dJQ0FnY0hWemFHbHVkQ0EzTlRZek1qRXhPRGdLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJKYm5SbFozSnBkSGxGZUdGdExuQjVPakkwQ2lBZ0lDQXZMeUJ6Wld4bUxuTmphRzlzWVhKemFHbHdYMkZ0YjNWdWRDQTlJRlZKYm5RMk5DZ3hNRjh3TURCZk1EQXdYekF3TUNrS0lDQWdJR0o1ZEdWalh6SWdMeThnSW5OamFHOXNZWEp6YUdsd1gyRnRiM1Z1ZENJS0lDQWdJSEIxYzJocGJuUWdNVEF3TURBd01EQXdNREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2dwdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1qb0tJQ0FnSUM4dklFbHVkR1ZuY21sMGVVVjRZVzB1Y0hrNk1qQUtJQ0FnSUM4dklHTnNZWE56SUVsdWRHVm5jbWwwZVVWNFlXMG9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0JpZWlCdFlXbHVYMTlmWVd4bmIzQjVYMlJsWm1GMWJIUmZZM0psWVhSbFFERTFDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUhCMWMyaGllWFJsYzNNZ01IaGhNRE5pT0RGa01pQXdlR1JtTlRSbE9HRmhJREI0TVRFeE16TTBNVGdnTUhobE5qazBOV1V4TnlBd2VEWm1OekF6WVRVeElEQjRNR1JrTVRFNE9UWWdMeThnYldWMGFHOWtJQ0pqY21WaGRHVmZZWEJ3YkdsallYUnBiMjRvZFdsdWREWTBLWFp2YVdRaUxDQnRaWFJvYjJRZ0ltOXdkRjlwYmw5MGIxOWhjM05sZENoMWFXNTBOalFwZG05cFpDSXNJRzFsZEdodlpDQWlZMnhoYVcxZlpHVnRiMTkwYjJ0bGJuTW9LWFp2YVdRaUxDQnRaWFJvYjJRZ0luTjBZV3RsWDJGdVpGOXpkR0Z5ZENoaGVHWmxjaWwyYjJsa0lpd2diV1YwYUc5a0lDSnlaV052Y21SZlkyaGxZWFFvWVdSa2NtVnpjeWwyYjJsa0lpd2diV1YwYUc5a0lDSmpiMjF3YkdWMFpWOWxlR0Z0S0dGa1pISmxjM01zZFdsdWREWTBLWFp2YVdRaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQmpjbVZoZEdWZllYQndiR2xqWVhScGIyNGdiM0IwWDJsdVgzUnZYMkZ6YzJWMElHTnNZV2x0WDJSbGJXOWZkRzlyWlc1eklITjBZV3RsWDJGdVpGOXpkR0Z5ZENCeVpXTnZjbVJmWTJobFlYUWdZMjl0Y0d4bGRHVmZaWGhoYlFvZ0lDQWdaWEp5Q2dwdFlXbHVYMTlmWVd4bmIzQjVYMlJsWm1GMWJIUmZZM0psWVhSbFFERTFPZ29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQ0VLSUNBZ0lDWW1DaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QkpiblJsWjNKcGRIbEZlR0Z0TGtsdWRHVm5jbWwwZVVWNFlXMHVZM0psWVhSbFgyRndjR3hwWTJGMGFXOXVXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWTNKbFlYUmxYMkZ3Y0d4cFkyRjBhVzl1T2dvZ0lDQWdMeThnU1c1MFpXZHlhWFI1UlhoaGJTNXdlVG96TUFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLR0ZzYkc5M1gyRmpkR2x2Ym5NOVd5Sk9iMDl3SWwwcENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QkpiblJsWjNKcGRIbEZlR0Z0TG5CNU9qTXpDaUFnSUNBdkx5QmhjM05sY25RZ1ZIaHVMbk5sYm1SbGNpQTlQU0JIYkc5aVlXd3VZM0psWVhSdmNsOWhaR1J5WlhOekxDQWlUMjVzZVNCamNtVmhkRzl5SWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1oyeHZZbUZzSUVOeVpXRjBiM0pCWkdSeVpYTnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dWJIa2dZM0psWVhSdmNnb2dJQ0FnTHk4Z1NXNTBaV2R5YVhSNVJYaGhiUzV3ZVRvek5Bb2dJQ0FnTHk4Z1lYTnpaWEowSUhObGJHWXVaM3BqWDJGellWOXBaQ0E5UFNBd0xDQWlRWE56WlhRZ1NVUWdZV3h5WldGa2VTQnpaWFFpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlaM3BqWDJGellWOXBaQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1bmVtTmZZWE5oWDJsa0lHVjRhWE4wY3dvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFRnpjMlYwSUVsRUlHRnNjbVZoWkhrZ2MyVjBDaUFnSUNBdkx5QkpiblJsWjNKcGRIbEZlR0Z0TG5CNU9qTTFDaUFnSUNBdkx5QnpaV3htTG1kNlkxOWhjMkZmYVdRZ1BTQm5lbU5mYVdRdWFXUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltZDZZMTloYzJGZmFXUWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdTVzUwWldkeWFYUjVSWGhoYlM1d2VUb3pNQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tHRnNiRzkzWDJGamRHbHZibk05V3lKT2IwOXdJbDBwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdTVzUwWldkeWFYUjVSWGhoYlM1SmJuUmxaM0pwZEhsRmVHRnRMbTl3ZEY5cGJsOTBiMTloYzNObGRGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbTl3ZEY5cGJsOTBiMTloYzNObGREb0tJQ0FnSUM4dklFbHVkR1ZuY21sMGVVVjRZVzB1Y0hrNk16Y0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z1NXNTBaV2R5YVhSNVJYaGhiUzV3ZVRvME1Bb2dJQ0FnTHk4Z1lYTnpaWEowSUZSNGJpNXpaVzVrWlhJZ1BUMGdSMnh2WW1Gc0xtTnlaV0YwYjNKZllXUmtjbVZ6Y3l3Z0lrOXViSGtnWTNKbFlYUnZjaUlLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdkc2IySmhiQ0JEY21WaGRHOXlRV1JrY21WemN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYm14NUlHTnlaV0YwYjNJS0lDQWdJQzh2SUVsdWRHVm5jbWwwZVVWNFlXMHVjSGs2TkRFS0lDQWdJQzh2SUdGemMyVnlkQ0JuZW1OZllYTnpaWFF1YVdRZ1BUMGdjMlZzWmk1bmVtTmZZWE5oWDJsa0xDQWlRWE56WlhRZ2JXbHpiV0YwWTJnaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWjNwalgyRnpZVjlwWkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNW5lbU5mWVhOaFgybGtJR1Y0YVhOMGN3b2dJQ0FnWkdsbklERUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnUVhOelpYUWdiV2x6YldGMFkyZ0tJQ0FnSUM4dklFbHVkR1ZuY21sMGVVVjRZVzB1Y0hrNk5ETXRORGNLSUNBZ0lDOHZJR2wwZUc0dVFYTnpaWFJVY21GdWMyWmxjaWdLSUNBZ0lDOHZJQ0FnSUNCNFptVnlYMkZ6YzJWMFBXZDZZMTloYzNObGRDd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGOXlaV05sYVhabGNqMUhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFgyRnRiM1Z1ZEQwd0xBb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdMeThnU1c1MFpXZHlhWFI1UlhoaGJTNXdlVG8wTlFvZ0lDQWdMeThnWVhOelpYUmZjbVZqWldsMlpYSTlSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5d0tJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNBdkx5QkpiblJsWjNKcGRIbEZlR0Z0TG5CNU9qUTJDaUFnSUNBdkx5QmhjM05sZEY5aGJXOTFiblE5TUN3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ6YzJWMFFXMXZkVzUwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ6YzJWMFVtVmpaV2wyWlhJS0lDQWdJR2wwZUc1ZlptbGxiR1FnV0dabGNrRnpjMlYwQ2lBZ0lDQXZMeUJKYm5SbFozSnBkSGxGZUdGdExuQjVPalF6Q2lBZ0lDQXZMeUJwZEhodUxrRnpjMlYwVkhKaGJuTm1aWElvQ2lBZ0lDQnBiblJqWHpJZ0x5OGdZWGhtWlhJS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ0x5OGdTVzUwWldkeWFYUjVSWGhoYlM1d2VUbzBNeTAwTndvZ0lDQWdMeThnYVhSNGJpNUJjM05sZEZSeVlXNXpabVZ5S0FvZ0lDQWdMeThnSUNBZ0lIaG1aWEpmWVhOelpYUTlaM3BqWDJGemMyVjBMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYM0psWTJWcGRtVnlQVWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUmZZVzF2ZFc1MFBUQXNDaUFnSUNBdkx5QXBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnTHk4Z1NXNTBaV2R5YVhSNVJYaGhiUzV3ZVRvek53b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdTVzUwWldkeWFYUjVSWGhoYlM1SmJuUmxaM0pwZEhsRmVHRnRMbU5zWVdsdFgyUmxiVzlmZEc5clpXNXpXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWTJ4aGFXMWZaR1Z0YjE5MGIydGxibk02Q2lBZ0lDQXZMeUJKYm5SbFozSnBkSGxGZUdGdExuQjVPalUxTFRVMkNpQWdJQ0F2THlBaklGTjVZbWxzSUhCeWIzUmxZM1JwYjI0NklHTm9aV05ySUdsbUlHRnNjbVZoWkhrZ1kyeGhhVzFsWkFvZ0lDQWdMeThnWVhOelpYSjBJSE5sYm1SbGNsOWhaR1J5WlhOeklHNXZkQ0JwYmlCelpXeG1MbWhoYzE5amJHRnBiV1ZrWDJSbGJXOHNJQ0pCYkhKbFlXUjVJR05zWVdsdFpXUWdaR1Z0YnlCMGIydGxibk1pQ2lBZ0lDQndkWE5vWW5sMFpYTWdJbWhoYzE5amJHRnBiV1ZrWDJSbGJXOGlDaUFnSUNBdkx5QkpiblJsWjNKcGRIbEZlR0Z0TG5CNU9qVXpDaUFnSUNBdkx5QnpaVzVrWlhKZllXUmtjbVZ6Y3lBOUlHRnlZelF1UVdSa2NtVnpjeWhVZUc0dWMyVnVaR1Z5S1FvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ0x5OGdTVzUwWldkeWFYUjVSWGhoYlM1d2VUbzFOUzAxTmdvZ0lDQWdMeThnSXlCVGVXSnBiQ0J3Y205MFpXTjBhVzl1T2lCamFHVmpheUJwWmlCaGJISmxZV1I1SUdOc1lXbHRaV1FLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpaVzVrWlhKZllXUmtjbVZ6Y3lCdWIzUWdhVzRnYzJWc1ppNW9ZWE5mWTJ4aGFXMWxaRjlrWlcxdkxDQWlRV3h5WldGa2VTQmpiR0ZwYldWa0lHUmxiVzhnZEc5clpXNXpJZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRUZzY21WaFpIa2dZMnhoYVcxbFpDQmtaVzF2SUhSdmEyVnVjd29nSUNBZ0x5OGdTVzUwWldkeWFYUjVSWGhoYlM1d2VUbzJNUzAyTlFvZ0lDQWdMeThnYVhSNGJpNUJjM05sZEZSeVlXNXpabVZ5S0FvZ0lDQWdMeThnSUNBZ0lIaG1aWEpmWVhOelpYUTlRWE56WlhRb2MyVnNaaTVuZW1OZllYTmhYMmxrS1N3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5eVpXTmxhWFpsY2oxVWVHNHVjMlZ1WkdWeUxBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFgyRnRiM1Z1ZEQxbmFYWmxZWGRoZVY5MllXd3NDaUFnSUNBdkx5QXBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0F2THlCSmJuUmxaM0pwZEhsRmVHRnRMbkI1T2pZeUNpQWdJQ0F2THlCNFptVnlYMkZ6YzJWMFBVRnpjMlYwS0hObGJHWXVaM3BqWDJGellWOXBaQ2tzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlaM3BqWDJGellWOXBaQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1bmVtTmZZWE5oWDJsa0lHVjRhWE4wY3dvZ0lDQWdMeThnU1c1MFpXZHlhWFI1UlhoaGJTNXdlVG8yTXdvZ0lDQWdMeThnWVhOelpYUmZjbVZqWldsMlpYSTlWSGh1TG5ObGJtUmxjaXdLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklFbHVkR1ZuY21sMGVVVjRZVzB1Y0hrNk5UZ3ROVGtLSUNBZ0lDOHZJQ01nTVRBd01DQkhXa01nS0VGemMzVnRhVzVuSURZZ1pHVmphVzFoYkhNNklERXNNREF3SUNvZ01Td3dNREFzTURBd0tRb2dJQ0FnTHk4Z1oybDJaV0YzWVhsZmRtRnNJRDBnVlVsdWREWTBLREZmTURBd1h6QXdNRjh3TURBcENpQWdJQ0J3ZFhOb2FXNTBJREV3TURBd01EQXdNREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWE56WlhSQmJXOTFiblFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWE56WlhSU1pXTmxhWFpsY2dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JZWm1WeVFYTnpaWFFLSUNBZ0lDOHZJRWx1ZEdWbmNtbDBlVVY0WVcwdWNIazZOakVLSUNBZ0lDOHZJR2wwZUc0dVFYTnpaWFJVY21GdWMyWmxjaWdLSUNBZ0lHbHVkR05mTWlBdkx5QmhlR1psY2dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNBdkx5QkpiblJsWjNKcGRIbEZlR0Z0TG5CNU9qWXhMVFkxQ2lBZ0lDQXZMeUJwZEhodUxrRnpjMlYwVkhKaGJuTm1aWElvQ2lBZ0lDQXZMeUFnSUNBZ2VHWmxjbDloYzNObGREMUJjM05sZENoelpXeG1MbWQ2WTE5aGMyRmZhV1FwTEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDNKbFkyVnBkbVZ5UFZSNGJpNXpaVzVrWlhJc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZllXMXZkVzUwUFdkcGRtVmhkMkY1WDNaaGJDd0tJQ0FnSUM4dklDa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0F2THlCSmJuUmxaM0pwZEhsRmVHRnRMbkI1T2pZM0NpQWdJQ0F2THlCelpXeG1MbWhoYzE5amJHRnBiV1ZrWDJSbGJXOWJjMlZ1WkdWeVgyRmtaSEpsYzNOZElEMGdZWEpqTkM1VlNXNTBOalFvTVNrS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd01EQXdNREF3TURBd01EQXdNREVLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUVsdWRHVm5jbWwwZVVWNFlXMHVjSGs2TkRrdE5UQUtJQ0FnSUM4dklDTWdMUzB0SUVkSlZrVkJWMEZaSUV4UFIwbERJQzB0TFFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z1NXNTBaV2R5YVhSNVJYaGhiUzVKYm5SbFozSnBkSGxGZUdGdExuTjBZV3RsWDJGdVpGOXpkR0Z5ZEZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuTjBZV3RsWDJGdVpGOXpkR0Z5ZERvS0lDQWdJQzh2SUVsdWRHVm5jbWwwZVVWNFlXMHVjSGs2TmprdE56QUtJQ0FnSUM4dklDTWdMUzB0SUVWWVFVMGdURTlIU1VNZ0xTMHRDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1pIVndDaUFnSUNCbmRIaHVjeUJVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh5SUM4dklHRjRabVZ5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklIUnlZVzV6WVdOMGFXOXVJSFI1Y0dVZ2FYTWdZWGhtWlhJS0lDQWdJQzh2SUVsdWRHVm5jbWwwZVVWNFlXMHVjSGs2TnpNS0lDQWdJQzh2SUdGemMyVnlkQ0JoY21NMExrRmtaSEpsYzNNb1ZIaHVMbk5sYm1SbGNpa2dibTkwSUdsdUlITmxiR1l1YzNSMVpHVnVkRjl5WldOdmNtUnpMQ0FpUlhoaGJTQnBiaUJ3Y205bmNtVnpjeUlLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbk4wZFdSbGJuUmZjbVZqYjNKa2N5SUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1JYaGhiU0JwYmlCd2NtOW5jbVZ6Y3dvZ0lDQWdMeThnU1c1MFpXZHlhWFI1UlhoaGJTNXdlVG8zTkFvZ0lDQWdMeThnWVhOelpYSjBJSE4wWVd0bFgzQnRkQzVoYzNObGRGOXlaV05sYVhabGNpQTlQU0JIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpDaUFnSUNCa2RYQUtJQ0FnSUdkMGVHNXpJRUZ6YzJWMFVtVmpaV2wyWlhJS0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCSmJuUmxaM0pwZEhsRmVHRnRMbkI1T2pjMUNpQWdJQ0F2THlCaGMzTmxjblFnYzNSaGEyVmZjRzEwTG5obVpYSmZZWE56WlhRdWFXUWdQVDBnYzJWc1ppNW5lbU5mWVhOaFgybGtDaUFnSUNCa2RYQUtJQ0FnSUdkMGVHNXpJRmhtWlhKQmMzTmxkQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltZDZZMTloYzJGZmFXUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WjNwalgyRnpZVjlwWkNCbGVHbHpkSE1LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJRWx1ZEdWbmNtbDBlVVY0WVcwdWNIazZOellLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpkR0ZyWlY5d2JYUXVZWE56WlhSZllXMXZkVzUwSUQ0Z01Bb2dJQ0FnWjNSNGJuTWdRWE56WlhSQmJXOTFiblFLSUNBZ0lHUjFjQW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUJKYm5SbFozSnBkSGxGZUdGdExuQjVPamM1Q2lBZ0lDQXZMeUJ6ZEdGclpXUmZZVzF2ZFc1MFBXRnlZelF1VlVsdWREWTBLSE4wWVd0bFgzQnRkQzVoYzNObGRGOWhiVzkxYm5RcExBb2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z1NXNTBaV2R5YVhSNVJYaGhiUzV3ZVRvM09DMDRNd29nSUNBZ0x5OGdjMlZzWmk1emRIVmtaVzUwWDNKbFkyOXlaSE5iWVhKak5DNUJaR1J5WlhOektGUjRiaTV6Wlc1a1pYSXBYU0E5SUZOMGRXUmxiblJFWVhSaEtBb2dJQ0FnTHk4Z0lDQWdJSE4wWVd0bFpGOWhiVzkxYm5ROVlYSmpOQzVWU1c1ME5qUW9jM1JoYTJWZmNHMTBMbUZ6YzJWMFgyRnRiM1Z1ZENrc0NpQWdJQ0F2THlBZ0lDQWdiV0Z5YTNNOVlYSmpOQzVWU1c1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFnSUNBZ1kyaGxZWFJmWTI5MWJuUTlZWEpqTkM1VlNXNTBOalFvTUNrc0NpQWdJQ0F2THlBZ0lDQWdhWE5mWlhoaGJWOWhZM1JwZG1VOVlYSmpOQzVWU1c1ME5qUW9NU2tLSUNBZ0lDOHZJQ2tLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCSmJuUmxaM0pwZEhsRmVHRnRMbkI1T2pjNENpQWdJQ0F2THlCelpXeG1Mbk4wZFdSbGJuUmZjbVZqYjNKa2MxdGhjbU0wTGtGa1pISmxjM01vVkhodUxuTmxibVJsY2lsZElEMGdVM1IxWkdWdWRFUmhkR0VvQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0p6ZEhWa1pXNTBYM0psWTI5eVpITWlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklFbHVkR1ZuY21sMGVVVjRZVzB1Y0hrNk56Z3RPRE1LSUNBZ0lDOHZJSE5sYkdZdWMzUjFaR1Z1ZEY5eVpXTnZjbVJ6VzJGeVl6UXVRV1JrY21WemN5aFVlRzR1YzJWdVpHVnlLVjBnUFNCVGRIVmtaVzUwUkdGMFlTZ0tJQ0FnSUM4dklDQWdJQ0J6ZEdGclpXUmZZVzF2ZFc1MFBXRnlZelF1VlVsdWREWTBLSE4wWVd0bFgzQnRkQzVoYzNObGRGOWhiVzkxYm5RcExBb2dJQ0FnTHk4Z0lDQWdJRzFoY210elBXRnlZelF1VlVsdWREWTBLREFwTEFvZ0lDQWdMeThnSUNBZ0lHTm9aV0YwWDJOdmRXNTBQV0Z5WXpRdVZVbHVkRFkwS0RBcExBb2dJQ0FnTHk4Z0lDQWdJR2x6WDJWNFlXMWZZV04wYVhabFBXRnlZelF1VlVsdWREWTBLREVwQ2lBZ0lDQXZMeUFwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCSmJuUmxaM0pwZEhsRmVHRnRMbkI1T2pZNUxUY3dDaUFnSUNBdkx5QWpJQzB0TFNCRldFRk5JRXhQUjBsRElDMHRMUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnU1c1MFpXZHlhWFI1UlhoaGJTNUpiblJsWjNKcGRIbEZlR0Z0TG5KbFkyOXlaRjlqYUdWaGRGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbkpsWTI5eVpGOWphR1ZoZERvS0lDQWdJQzh2SUVsdWRHVm5jbWwwZVVWNFlXMHVjSGs2T0RVS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnTHk4Z1NXNTBaV2R5YVhSNVJYaGhiUzV3ZVRvNE9Bb2dJQ0FnTHk4Z1lYTnpaWEowSUZSNGJpNXpaVzVrWlhJZ1BUMGdSMnh2WW1Gc0xtTnlaV0YwYjNKZllXUmtjbVZ6Y3l3Z0lrOXViSGtnY0hKdlkzUnZjaUlLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdkc2IySmhiQ0JEY21WaGRHOXlRV1JrY21WemN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYm14NUlIQnliMk4wYjNJS0lDQWdJQzh2SUVsdWRHVm5jbWwwZVVWNFlXMHVjSGs2T1RBS0lDQWdJQzh2SUhKbFkyOXlaQ0E5SUhObGJHWXVjM1IxWkdWdWRGOXlaV052Y21SelczTjBkV1JsYm5SZExtTnZjSGtvS1FvZ0lDQWdZbmwwWldOZk1TQXZMeUFpYzNSMVpHVnVkRjl5WldOdmNtUnpJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5OMGRXUmxiblJmY21WamIzSmtjeUJsYm5SeWVTQmxlR2x6ZEhNS0lDQWdJQzh2SUVsdWRHVm5jbWwwZVVWNFlXMHVjSGs2T1RFS0lDQWdJQzh2SUc1bGQxOWphR1ZoZEhNZ1BTQnlaV052Y21RdVkyaGxZWFJmWTI5MWJuUXVibUYwYVhabElDc2dNUW9nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURFMkNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQ3NLSUNBZ0lDOHZJRWx1ZEdWbmNtbDBlVVY0WVcwdWNIazZPVElLSUNBZ0lDOHZJSEpsWTI5eVpDNWphR1ZoZEY5amIzVnVkQ0E5SUdGeVl6UXVWVWx1ZERZMEtHNWxkMTlqYUdWaGRITXBDaUFnSUNCa2RYQUtJQ0FnSUdsMGIySUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdjbVZ3YkdGalpUSWdNVFlLSUNBZ0lITjNZWEFLSUNBZ0lDOHZJRWx1ZEdWbmNtbDBlVVY0WVcwdWNIazZPVFFLSUNBZ0lDOHZJR2xtSUc1bGQxOWphR1ZoZEhNZ1BUMGdNem9LSUNBZ0lIQjFjMmhwYm5RZ013b2dJQ0FnUFQwS0lDQWdJR0o2SUhKbFkyOXlaRjlqYUdWaGRGOWhablJsY2w5cFpsOWxiSE5sUURNS0lDQWdJQzh2SUVsdWRHVm5jbWwwZVVWNFlXMHVjSGs2T1RVS0lDQWdJQzh2SUhKbFkyOXlaQzV6ZEdGclpXUmZZVzF2ZFc1MElEMGdZWEpqTkM1VlNXNTBOalFvY21WamIzSmtMbk4wWVd0bFpGOWhiVzkxYm5RdWJtRjBhWFpsSUM4dklESXBDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnY0hWemFHbHVkQ0F5Q2lBZ0lDQXZDaUFnSUNCcGRHOWlDaUFnSUNCeVpYQnNZV05sTWlBd0NncHlaV052Y21SZlkyaGxZWFJmWVdaMFpYSmZhV1pmWld4elpVQXpPZ29nSUNBZ0x5OGdTVzUwWldkeWFYUjVSWGhoYlM1d2VUbzVOd29nSUNBZ0x5OGdjMlZzWmk1emRIVmtaVzUwWDNKbFkyOXlaSE5iYzNSMVpHVnVkRjBnUFNCeVpXTnZjbVF1WTI5d2VTZ3BDaUFnSUNCa2FXY2dNUW9nSUNBZ2MzZGhjQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnU1c1MFpXZHlhWFI1UlhoaGJTNXdlVG80TlFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z1NXNTBaV2R5YVhSNVJYaGhiUzVKYm5SbFozSnBkSGxGZUdGdExtTnZiWEJzWlhSbFgyVjRZVzFiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwamIyMXdiR1YwWlY5bGVHRnRPZ29nSUNBZ2NIVnphR0o1ZEdWeklDSWlDaUFnSUNBdkx5QkpiblJsWjNKcGRIbEZlR0Z0TG5CNU9qazVDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0c0Z01nb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklFbHVkR1ZuY21sMGVVVjRZVzB1Y0hrNk1UQXlDaUFnSUNBdkx5QmhjM05sY25RZ1ZIaHVMbk5sYm1SbGNpQTlQU0JIYkc5aVlXd3VZM0psWVhSdmNsOWhaR1J5WlhOekxDQWlUMjVzZVNCd2NtOWpkRzl5SWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1oyeHZZbUZzSUVOeVpXRjBiM0pCWkdSeVpYTnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dWJIa2djSEp2WTNSdmNnb2dJQ0FnTHk4Z1NXNTBaV2R5YVhSNVJYaGhiUzV3ZVRveE1EUUtJQ0FnSUM4dklISmxZMjl5WkNBOUlITmxiR1l1YzNSMVpHVnVkRjl5WldOdmNtUnpXM04wZFdSbGJuUmRMbU52Y0hrb0tRb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWMzUjFaR1Z1ZEY5eVpXTnZjbVJ6SWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVjM1IxWkdWdWRGOXlaV052Y21SeklHVnVkSEo1SUdWNGFYTjBjd29nSUNBZ0x5OGdTVzUwWldkeWFYUjVSWGhoYlM1d2VUb3hNRFl0TVRBM0NpQWdJQ0F2THlBaklGSmxkMkZ5WkNBeE1Hc2dSMXBESUdsbUlEZ3dLeUJ0WVhKcmN5QmhibVFnTUNCamFHVmhkSE1LSUNBZ0lDOHZJR2xtSUdacGJtRnNYMjFoY210eklENDlJRGd3SUdGdVpDQnlaV052Y21RdVkyaGxZWFJmWTI5MWJuUXVibUYwYVhabElEMDlJREE2Q2lBZ0lDQndkWE5vYVc1MElEZ3dDaUFnSUNBK1BRb2dJQ0FnWW5vZ1kyOXRjR3hsZEdWZlpYaGhiVjloWm5SbGNsOXBabDlsYkhObFFEVUtJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0F4TmdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR0p1ZWlCamIyMXdiR1YwWlY5bGVHRnRYMkZtZEdWeVgybG1YMlZzYzJWQU5Rb2dJQ0FnTHk4Z1NXNTBaV2R5YVhSNVJYaGhiUzV3ZVRveE1EZ3RNVEV5Q2lBZ0lDQXZMeUJwZEhodUxrRnpjMlYwVkhKaGJuTm1aWElvQ2lBZ0lDQXZMeUFnSUNBZ2VHWmxjbDloYzNObGREMUJjM05sZENoelpXeG1MbWQ2WTE5aGMyRmZhV1FwTEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDNKbFkyVnBkbVZ5UFhOMGRXUmxiblF1Ym1GMGFYWmxMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYMkZ0YjNWdWREMXpaV3htTG5OamFHOXNZWEp6YUdsd1gyRnRiM1Z1ZEN3S0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJRWx1ZEdWbmNtbDBlVVY0WVcwdWNIazZNVEE1Q2lBZ0lDQXZMeUI0Wm1WeVgyRnpjMlYwUFVGemMyVjBLSE5sYkdZdVozcGpYMkZ6WVY5cFpDa3NDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVozcGpYMkZ6WVY5cFpDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVuZW1OZllYTmhYMmxrSUdWNGFYTjBjd29nSUNBZ0x5OGdTVzUwWldkeWFYUjVSWGhoYlM1d2VUb3hNVEVLSUNBZ0lDOHZJR0Z6YzJWMFgyRnRiM1Z1ZEQxelpXeG1Mbk5qYUc5c1lYSnphR2x3WDJGdGIzVnVkQ3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh5SUM4dklDSnpZMmh2YkdGeWMyaHBjRjloYlc5MWJuUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1YzJOb2IyeGhjbk5vYVhCZllXMXZkVzUwSUdWNGFYTjBjd29nSUNBZ2FYUjRibDltYVdWc1pDQkJjM05sZEVGdGIzVnVkQW9nSUNBZ1pHbG5JRE1LSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWE56WlhSU1pXTmxhWFpsY2dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JZWm1WeVFYTnpaWFFLSUNBZ0lDOHZJRWx1ZEdWbmNtbDBlVVY0WVcwdWNIazZNVEE0Q2lBZ0lDQXZMeUJwZEhodUxrRnpjMlYwVkhKaGJuTm1aWElvQ2lBZ0lDQnBiblJqWHpJZ0x5OGdZWGhtWlhJS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ0x5OGdTVzUwWldkeWFYUjVSWGhoYlM1d2VUb3hNRGd0TVRFeUNpQWdJQ0F2THlCcGRIaHVMa0Z6YzJWMFZISmhibk5tWlhJb0NpQWdJQ0F2THlBZ0lDQWdlR1psY2w5aGMzTmxkRDFCYzNObGRDaHpaV3htTG1kNlkxOWhjMkZmYVdRcExBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFgzSmxZMlZwZG1WeVBYTjBkV1JsYm5RdWJtRjBhWFpsTEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDJGdGIzVnVkRDF6Wld4bUxuTmphRzlzWVhKemFHbHdYMkZ0YjNWdWRDd0tJQ0FnSUM4dklDa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZjM1ZpYldsMENncGpiMjF3YkdWMFpWOWxlR0Z0WDJGbWRHVnlYMmxtWDJWc2MyVkFOVG9LSUNBZ0lDOHZJRWx1ZEdWbmNtbDBlVVY0WVcwdWNIazZNVEUwTFRFeE5Rb2dJQ0FnTHk4Z0l5QlNaV1oxYm1RZ2NtVnRZV2x1YVc1bklITjBZV3RsQ2lBZ0lDQXZMeUJwWmlCeVpXTnZjbVF1YzNSaGEyVmtYMkZ0YjNWdWRDNXVZWFJwZG1VZ1BpQXdPZ29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQTFDaUFnSUNCaWVpQmpiMjF3YkdWMFpWOWxlR0Z0WDJGbWRHVnlYMmxtWDJWc2MyVkFPQW9nSUNBZ0x5OGdTVzUwWldkeWFYUjVSWGhoYlM1d2VUb3hNVFl0TVRJd0NpQWdJQ0F2THlCcGRIaHVMa0Z6YzJWMFZISmhibk5tWlhJb0NpQWdJQ0F2THlBZ0lDQWdlR1psY2w5aGMzTmxkRDFCYzNObGRDaHpaV3htTG1kNlkxOWhjMkZmYVdRcExBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFgzSmxZMlZwZG1WeVBYTjBkV1JsYm5RdWJtRjBhWFpsTEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDJGdGIzVnVkRDF5WldOdmNtUXVjM1JoYTJWa1gyRnRiM1Z1ZEM1dVlYUnBkbVVzQ2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNBdkx5QkpiblJsWjNKcGRIbEZlR0Z0TG5CNU9qRXhOd29nSUNBZ0x5OGdlR1psY2w5aGMzTmxkRDFCYzNObGRDaHpaV3htTG1kNlkxOWhjMkZmYVdRcExBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1kNlkxOWhjMkZmYVdRaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVaM3BqWDJGellWOXBaQ0JsZUdsemRITUtJQ0FnSUdScFp5QTBDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnpjMlYwUVcxdmRXNTBDaUFnSUNCa2FXY2dNd29nSUNBZ2FYUjRibDltYVdWc1pDQkJjM05sZEZKbFkyVnBkbVZ5Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRmhtWlhKQmMzTmxkQW9nSUNBZ0x5OGdTVzUwWldkeWFYUjVSWGhoYlM1d2VUb3hNVFlLSUNBZ0lDOHZJR2wwZUc0dVFYTnpaWFJVY21GdWMyWmxjaWdLSUNBZ0lHbHVkR05mTWlBdkx5QmhlR1psY2dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNBdkx5QkpiblJsWjNKcGRIbEZlR0Z0TG5CNU9qRXhOaTB4TWpBS0lDQWdJQzh2SUdsMGVHNHVRWE56WlhSVWNtRnVjMlpsY2lnS0lDQWdJQzh2SUNBZ0lDQjRabVZ5WDJGemMyVjBQVUZ6YzJWMEtITmxiR1l1WjNwalgyRnpZVjlwWkNrc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZmNtVmpaV2wyWlhJOWMzUjFaR1Z1ZEM1dVlYUnBkbVVzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJmWVcxdmRXNTBQWEpsWTI5eVpDNXpkR0ZyWldSZllXMXZkVzUwTG01aGRHbDJaU3dLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDZ3BqYjIxd2JHVjBaVjlsZUdGdFgyRm1kR1Z5WDJsbVgyVnNjMlZBT0RvS0lDQWdJQzh2SUVsdWRHVm5jbWwwZVVWNFlXMHVjSGs2TVRJeUNpQWdJQ0F2THlCa1pXd2djMlZzWmk1emRIVmtaVzUwWDNKbFkyOXlaSE5iYzNSMVpHVnVkRjBLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJQzh2SUVsdWRHVm5jbWwwZVVWNFlXMHVjSGs2T1RrS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFBRUVDQ1lEQ21kNlkxOWhjMkZmYVdRUGMzUjFaR1Z1ZEY5eVpXTnZjbVJ6RW5OamFHOXNZWEp6YUdsd1gyRnRiM1Z1ZERFWVFBQVFLSUdrbDlMb0FtY3FnWURJcjZBbFp6RWJRUUE1TVJrVVJERVlSSUlHQktBN2dkSUUzMVRvcWdRUkV6UVlCT2FVWGhjRWIzQTZVUVFOMFJpV05ob0FqZ1lBQ1FBakFFMEFqd0RhQVJJQU1Sa1VNUmdVRUVNMkdnRkpGU1VTUkJjeEFESUpFa1FpS0dWRUZFUW9UR2NqUXpZYUFVa1ZKUkpFRnpFQU1na1NSQ0lvWlVSTEFSSkVzVElLSXJJU3NoU3lFU1N5RUNLeUFiTWpRNEFRYUdGelgyTnNZV2x0WldSZlpHVnRiekVBVUVtOVJRRVVSTEVpS0dWRU1RQ0JnSlRyM0FPeUVySVVzaEVrc2hBaXNnR3pnQWdBQUFBQUFBQUFBYjhqUXpFV0l3bEpPQkFrRWtRcE1RQlF2VVVCRkVSSk9CUXlDaEpFU1RnUklpaGxSQkpFT0JKSlJCYUFHQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFWQXBNUUJRVEw4alF6WWFBVWtWZ1NBU1JERUFNZ2tTUkNsTVVFbStSRW1CRUZzakNFa1dUd0pNWEJCTWdRTVNRUUFKU1NKYmdRSUtGbHdBU3dGTXZ5TkRnQUEyR2dGSEFoV0JJQkpFTmhvQ1NSVWxFa1FYTVFBeUNSSkVLVThDVUVsT0FyNU1UZ0pFZ1ZBUFFRQWZTWUVRVzBBQUdMRWlLR1ZFSWlwbFJMSVNTd095RkxJUkpMSVFJcklCczBraVcwbEZCVUVBRnJFaUtHVkVTd1N5RWtzRHNoU3lFU1N5RUNLeUFiTkxBYnhJSTBNPSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjcsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
