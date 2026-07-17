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

namespace Arc56.Generated.zaxswer.gradzcap.ClaimDemoTokens_96388921
{


    public class ClaimDemoTokensProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ClaimDemoTokensProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ2xhaW1EZW1vVG9rZW5zIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IlN0dWRlbnREYXRhIjpbeyJuYW1lIjoic3Rha2VkX2Ftb3VudCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJtYXJrcyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJjaGVhdF9jb3VudCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJpc19leGFtX2FjdGl2ZSIsInR5cGUiOiJ1aW50NjQifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlX2FwcGxpY2F0aW9uIiwiZGVzYyI6IkluaXRpYWxpemUgdGhlIGNvbnRyYWN0IHdpdGggdGhlIEdaQyBBc3NldCBJRC4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZ3pjX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im9wdF9pbl90b19hc3NldCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJnemNfYXNzZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2xhaW1fZGVtb190b2tlbnMiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic3Rha2VfYW5kX3N0YXJ0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImF4ZmVyIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3Rha2VfcG10IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlY29yZF9jaGVhdCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3R1ZGVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjb21wbGV0ZV9leGFtIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzdHVkZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaW5hbF9tYXJrcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MiwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzIzNF0sImVycm9yTWVzc2FnZSI6IkFscmVhZHkgY2xhaW1lZCBkZW1vIHRva2VucyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE4OF0sImVycm9yTWVzc2FnZSI6IkFzc2V0IG1pc21hdGNoIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjkyXSwiZXJyb3JNZXNzYWdlIjoiRXhhbSBpbiBwcm9ncmVzcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2MCwxODBdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGNyZWF0b3IiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNjMsNDMxXSwiZXJyb3JNZXNzYWdlIjoiT25seSBwcm9jdG9yIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTg0LDIzOSwzMDYsNDYxLDQ5NF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuZ3pjX2FzYV9pZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NjVdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnNjaG9sYXJzaGlwX2Ftb3VudCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNjksNDQzXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5zdHVkZW50X3JlY29yZHMgZW50cnkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzU3LDQxNl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTMsMTczLDQyNF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI4M10sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgYXhmZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF3SURFZ05DQTRDaUFnSUNCaWVYUmxZMkpzYjJOcklDSm5lbU5mWVhOaFgybGtJaUFpYzNSMVpHVnVkRjl5WldOdmNtUnpJaUFpYzJOb2IyeGhjbk5vYVhCZllXMXZkVzUwSWdvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKdWVpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNZ29nSUNBZ0x5OGdZMnhoYVcxZlpHVnRiMTkwYjJ0bGJuTXVjSGs2TWpJdE1qTUtJQ0FnSUM4dklDTWdSa2xZT2lCQlpHUWdkR2hsSUhSNWNHVWdhR2x1ZENBbk9pQlZTVzUwTmpRbklHaGxjbVVLSUNBZ0lDOHZJSE5sYkdZdVozcGpYMkZ6WVY5cFpEb2dWVWx1ZERZMElEMGdWVWx1ZERZMEtEYzFOak15TVRFNE9Da0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltZDZZMTloYzJGZmFXUWlDaUFnSUNCd2RYTm9hVzUwSURjMU5qTXlNVEU0T0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUdOc1lXbHRYMlJsYlc5ZmRHOXJaVzV6TG5CNU9qSTBDaUFnSUNBdkx5QnpaV3htTG5OamFHOXNZWEp6YUdsd1gyRnRiM1Z1ZERvZ1ZVbHVkRFkwSUQwZ1ZVbHVkRFkwS0RFd1h6QXdNRjh3TURCZk1EQXdLUW9nSUNBZ1lubDBaV05mTWlBdkx5QWljMk5vYjJ4aGNuTm9hWEJmWVcxdmRXNTBJZ29nSUNBZ2NIVnphR2x1ZENBeE1EQXdNREF3TURBd01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtDbTFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF5T2dvZ0lDQWdMeThnWTJ4aGFXMWZaR1Z0YjE5MGIydGxibk11Y0hrNk1Ua3RNakFLSUNBZ0lDOHZJQ01nVW1WdVlXMWxJSFJvYVhNZ1kyeGhjM01nYVdZZ2VXOTFJSGRoYm5RZ2RHaGxJQzUwWldGc0lHWnBiR1Z6SUhSdklHaGhkbVVnWVNCa2FXWm1aWEpsYm5RZ2JtRnRaUW9nSUNBZ0x5OGdZMnhoYzNNZ1EyeGhhVzFFWlcxdlZHOXJaVzV6S0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNGdUblZ0UVhCd1FYSm5jd29nSUNBZ1lub2diV0ZwYmw5ZlgyRnNaMjl3ZVY5a1pXWmhkV3gwWDJOeVpXRjBaVUF4TlFvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQndkWE5vWW5sMFpYTnpJREI0WVRBellqZ3haRElnTUhoa1pqVTBaVGhoWVNBd2VERXhNVE16TkRFNElEQjRaVFk1TkRWbE1UY2dNSGcyWmpjd00yRTFNU0F3ZURCa1pERXhPRGsySUM4dklHMWxkR2h2WkNBaVkzSmxZWFJsWDJGd2NHeHBZMkYwYVc5dUtIVnBiblEyTkNsMmIybGtJaXdnYldWMGFHOWtJQ0p2Y0hSZmFXNWZkRzlmWVhOelpYUW9kV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW1Oc1lXbHRYMlJsYlc5ZmRHOXJaVzV6S0NsMmIybGtJaXdnYldWMGFHOWtJQ0p6ZEdGclpWOWhibVJmYzNSaGNuUW9ZWGhtWlhJcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpY21WamIzSmtYMk5vWldGMEtHRmtaSEpsYzNNcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWTI5dGNHeGxkR1ZmWlhoaGJTaGhaR1J5WlhOekxIVnBiblEyTkNsMmIybGtJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnWTNKbFlYUmxYMkZ3Y0d4cFkyRjBhVzl1SUc5d2RGOXBibDkwYjE5aGMzTmxkQ0JqYkdGcGJWOWtaVzF2WDNSdmEyVnVjeUJ6ZEdGclpWOWhibVJmYzNSaGNuUWdjbVZqYjNKa1gyTm9aV0YwSUdOdmJYQnNaWFJsWDJWNFlXMEtJQ0FnSUdWeWNnb0tiV0ZwYmw5ZlgyRnNaMjl3ZVY5a1pXWmhkV3gwWDJOeVpXRjBaVUF4TlRvS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBaENpQWdJQ0FtSmdvZ0lDQWdjbVYwZFhKdUNnb0tMeThnWTJ4aGFXMWZaR1Z0YjE5MGIydGxibk11UTJ4aGFXMUVaVzF2Vkc5clpXNXpMbU55WldGMFpWOWhjSEJzYVdOaGRHbHZibHR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21OeVpXRjBaVjloY0hCc2FXTmhkR2x2YmpvS0lDQWdJQzh2SUdOc1lXbHRYMlJsYlc5ZmRHOXJaVzV6TG5CNU9qSTVDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb1lXeHNiM2RmWVdOMGFXOXVjejFiSWs1dlQzQWlYU2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJQzh2SUdOc1lXbHRYMlJsYlc5ZmRHOXJaVzV6TG5CNU9qTXlDaUFnSUNBdkx5QmhjM05sY25RZ1ZIaHVMbk5sYm1SbGNpQTlQU0JIYkc5aVlXd3VZM0psWVhSdmNsOWhaR1J5WlhOekxDQWlUMjVzZVNCamNtVmhkRzl5SWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1oyeHZZbUZzSUVOeVpXRjBiM0pCWkdSeVpYTnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dWJIa2dZM0psWVhSdmNnb2dJQ0FnTHk4Z1kyeGhhVzFmWkdWdGIxOTBiMnRsYm5NdWNIazZNek10TXpVS0lDQWdJQzh2SUNNZ1UybHVZMlVnZDJVZ2FHRnlaR052WkdWa0lHbDBJSFJ2SURjMU5qTXlNVEU0T0N3Z2RHaHBjeUJ0WlhSb2IyUWdhWE1nYm05M0lISmxaSFZ1WkdGdWRBb2dJQ0FnTHk4Z0l5QmlkWFFnYVdZZ2VXOTFJR3RsWlhBZ2FYUXNJR1Z1YzNWeVpTQjBhR1VnZEhsd1pYTWdiV0YwWTJnNkNpQWdJQ0F2THlCelpXeG1MbWQ2WTE5aGMyRmZhV1FnUFNCbmVtTmZhV1F1YVdRS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1kNlkxOWhjMkZmYVdRaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z1kyeGhhVzFmWkdWdGIxOTBiMnRsYm5NdWNIazZNamtLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaGhiR3h2ZDE5aFkzUnBiMjV6UFZzaVRtOVBjQ0pkS1FvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJR05zWVdsdFgyUmxiVzlmZEc5clpXNXpMa05zWVdsdFJHVnRiMVJ2YTJWdWN5NXZjSFJmYVc1ZmRHOWZZWE56WlhSYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHZjSFJmYVc1ZmRHOWZZWE56WlhRNkNpQWdJQ0F2THlCamJHRnBiVjlrWlcxdlgzUnZhMlZ1Y3k1d2VUb3pOd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QmpiR0ZwYlY5a1pXMXZYM1J2YTJWdWN5NXdlVG96T1FvZ0lDQWdMeThnWVhOelpYSjBJRlI0Ymk1elpXNWtaWElnUFQwZ1IyeHZZbUZzTG1OeVpXRjBiM0pmWVdSa2NtVnpjeXdnSWs5dWJIa2dZM0psWVhSdmNpSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2RzYjJKaGJDQkRjbVZoZEc5eVFXUmtjbVZ6Y3dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBibXg1SUdOeVpXRjBiM0lLSUNBZ0lDOHZJR05zWVdsdFgyUmxiVzlmZEc5clpXNXpMbkI1T2pRd0NpQWdJQ0F2THlCaGMzTmxjblFnWjNwalgyRnpjMlYwTG1sa0lEMDlJSE5sYkdZdVozcGpYMkZ6WVY5cFpDd2dJa0Z6YzJWMElHMXBjMjFoZEdOb0lnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1kNlkxOWhjMkZmYVdRaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVaM3BqWDJGellWOXBaQ0JsZUdsemRITUtJQ0FnSUdScFp5QXhDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUVGemMyVjBJRzFwYzIxaGRHTm9DaUFnSUNBdkx5QmpiR0ZwYlY5a1pXMXZYM1J2YTJWdWN5NXdlVG8wTWkwME5nb2dJQ0FnTHk4Z2FYUjRiaTVCYzNObGRGUnlZVzV6Wm1WeUtBb2dJQ0FnTHk4Z0lDQWdJSGhtWlhKZllYTnpaWFE5WjNwalgyRnpjMlYwTEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDNKbFkyVnBkbVZ5UFVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJmWVcxdmRXNTBQVEFzQ2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNBdkx5QmpiR0ZwYlY5a1pXMXZYM1J2YTJWdWN5NXdlVG8wTkFvZ0lDQWdMeThnWVhOelpYUmZjbVZqWldsMlpYSTlSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5d0tJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNBdkx5QmpiR0ZwYlY5a1pXMXZYM1J2YTJWdWN5NXdlVG8wTlFvZ0lDQWdMeThnWVhOelpYUmZZVzF2ZFc1MFBUQXNDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmMzTmxkRUZ0YjNWdWRBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmMzTmxkRkpsWTJWcGRtVnlDaUFnSUNCcGRIaHVYMlpwWld4a0lGaG1aWEpCYzNObGRBb2dJQ0FnTHk4Z1kyeGhhVzFmWkdWdGIxOTBiMnRsYm5NdWNIazZORElLSUNBZ0lDOHZJR2wwZUc0dVFYTnpaWFJVY21GdWMyWmxjaWdLSUNBZ0lHbHVkR05mTWlBdkx5QmhlR1psY2dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNBdkx5QmpiR0ZwYlY5a1pXMXZYM1J2YTJWdWN5NXdlVG8wTWkwME5nb2dJQ0FnTHk4Z2FYUjRiaTVCYzNObGRGUnlZVzV6Wm1WeUtBb2dJQ0FnTHk4Z0lDQWdJSGhtWlhKZllYTnpaWFE5WjNwalgyRnpjMlYwTEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDNKbFkyVnBkbVZ5UFVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJmWVcxdmRXNTBQVEFzQ2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ0x5OGdZMnhoYVcxZlpHVnRiMTkwYjJ0bGJuTXVjSGs2TXpjS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklHTnNZV2x0WDJSbGJXOWZkRzlyWlc1ekxrTnNZV2x0UkdWdGIxUnZhMlZ1Y3k1amJHRnBiVjlrWlcxdlgzUnZhMlZ1YzF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtTnNZV2x0WDJSbGJXOWZkRzlyWlc1ek9nb2dJQ0FnTHk4Z1kyeGhhVzFmWkdWdGIxOTBiMnRsYm5NdWNIazZOVEVLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpaVzVrWlhKZllXUmtjbVZ6Y3lCdWIzUWdhVzRnYzJWc1ppNW9ZWE5mWTJ4aGFXMWxaRjlrWlcxdkxDQWlRV3h5WldGa2VTQmpiR0ZwYldWa0lHUmxiVzhnZEc5clpXNXpJZ29nSUNBZ2NIVnphR0o1ZEdWeklDSm9ZWE5mWTJ4aGFXMWxaRjlrWlcxdklnb2dJQ0FnTHk4Z1kyeGhhVzFmWkdWdGIxOTBiMnRsYm5NdWNIazZOVEFLSUNBZ0lDOHZJSE5sYm1SbGNsOWhaR1J5WlhOeklEMGdZWEpqTkM1QlpHUnlaWE56S0ZSNGJpNXpaVzVrWlhJcENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUJqYkdGcGJWOWtaVzF2WDNSdmEyVnVjeTV3ZVRvMU1Rb2dJQ0FnTHk4Z1lYTnpaWEowSUhObGJtUmxjbDloWkdSeVpYTnpJRzV2ZENCcGJpQnpaV3htTG1oaGMxOWpiR0ZwYldWa1gyUmxiVzhzSUNKQmJISmxZV1I1SUdOc1lXbHRaV1FnWkdWdGJ5QjBiMnRsYm5NaUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1FXeHlaV0ZrZVNCamJHRnBiV1ZrSUdSbGJXOGdkRzlyWlc1ekNpQWdJQ0F2THlCamJHRnBiVjlrWlcxdlgzUnZhMlZ1Y3k1d2VUbzFOUzAxT1FvZ0lDQWdMeThnYVhSNGJpNUJjM05sZEZSeVlXNXpabVZ5S0FvZ0lDQWdMeThnSUNBZ0lIaG1aWEpmWVhOelpYUTlRWE56WlhRb2MyVnNaaTVuZW1OZllYTmhYMmxrS1N3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5eVpXTmxhWFpsY2oxVWVHNHVjMlZ1WkdWeUxBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFgyRnRiM1Z1ZEQxbmFYWmxZWGRoZVY5MllXd3NDaUFnSUNBdkx5QXBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0F2THlCamJHRnBiVjlrWlcxdlgzUnZhMlZ1Y3k1d2VUbzFOZ29nSUNBZ0x5OGdlR1psY2w5aGMzTmxkRDFCYzNObGRDaHpaV3htTG1kNlkxOWhjMkZmYVdRcExBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1kNlkxOWhjMkZmYVdRaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVaM3BqWDJGellWOXBaQ0JsZUdsemRITUtJQ0FnSUM4dklHTnNZV2x0WDJSbGJXOWZkRzlyWlc1ekxuQjVPalUzQ2lBZ0lDQXZMeUJoYzNObGRGOXlaV05sYVhabGNqMVVlRzR1YzJWdVpHVnlMQW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnTHk4Z1kyeGhhVzFmWkdWdGIxOTBiMnRsYm5NdWNIazZOVE1LSUNBZ0lDOHZJR2RwZG1WaGQyRjVYM1poYkNBOUlGVkpiblEyTkNneFh6QXdNRjh3TURCZk1EQXdLUW9nSUNBZ2NIVnphR2x1ZENBeE1EQXdNREF3TURBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVGemMyVjBRVzF2ZFc1MENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGemMyVjBVbVZqWldsMlpYSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1dHWmxja0Z6YzJWMENpQWdJQ0F2THlCamJHRnBiVjlrWlcxdlgzUnZhMlZ1Y3k1d2VUbzFOUW9nSUNBZ0x5OGdhWFI0Ymk1QmMzTmxkRlJ5WVc1elptVnlLQW9nSUNBZ2FXNTBZMTh5SUM4dklHRjRabVZ5Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUM4dklHTnNZV2x0WDJSbGJXOWZkRzlyWlc1ekxuQjVPalUxTFRVNUNpQWdJQ0F2THlCcGRIaHVMa0Z6YzJWMFZISmhibk5tWlhJb0NpQWdJQ0F2THlBZ0lDQWdlR1psY2w5aGMzTmxkRDFCYzNObGRDaHpaV3htTG1kNlkxOWhjMkZmYVdRcExBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFgzSmxZMlZwZG1WeVBWUjRiaTV6Wlc1a1pYSXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUmZZVzF2ZFc1MFBXZHBkbVZoZDJGNVgzWmhiQ3dLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNBdkx5QmpiR0ZwYlY5a1pXMXZYM1J2YTJWdWN5NXdlVG8yTVFvZ0lDQWdMeThnYzJWc1ppNW9ZWE5mWTJ4aGFXMWxaRjlrWlcxdlczTmxibVJsY2w5aFpHUnlaWE56WFNBOUlHRnlZelF1VlVsdWREWTBLREVwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TURBd01EQXdNREF3TURBd01EQXhDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJqYkdGcGJWOWtaVzF2WDNSdmEyVnVjeTV3ZVRvME9Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdZMnhoYVcxZlpHVnRiMTkwYjJ0bGJuTXVRMnhoYVcxRVpXMXZWRzlyWlc1ekxuTjBZV3RsWDJGdVpGOXpkR0Z5ZEZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuTjBZV3RsWDJGdVpGOXpkR0Z5ZERvS0lDQWdJQzh2SUdOc1lXbHRYMlJsYlc5ZmRHOXJaVzV6TG5CNU9qWXpDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1pIVndDaUFnSUNCbmRIaHVjeUJVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh5SUM4dklHRjRabVZ5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklIUnlZVzV6WVdOMGFXOXVJSFI1Y0dVZ2FYTWdZWGhtWlhJS0lDQWdJQzh2SUdOc1lXbHRYMlJsYlc5ZmRHOXJaVzV6TG5CNU9qWTFDaUFnSUNBdkx5QmhjM05sY25RZ1lYSmpOQzVCWkdSeVpYTnpLRlI0Ymk1elpXNWtaWElwSUc1dmRDQnBiaUJ6Wld4bUxuTjBkV1JsYm5SZmNtVmpiM0prY3l3Z0lrVjRZVzBnYVc0Z2NISnZaM0psYzNNaUNpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKemRIVmtaVzUwWDNKbFkyOXlaSE1pQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRVY0WVcwZ2FXNGdjSEp2WjNKbGMzTUtJQ0FnSUM4dklHTnNZV2x0WDJSbGJXOWZkRzlyWlc1ekxuQjVPalkyQ2lBZ0lDQXZMeUJoYzNObGNuUWdjM1JoYTJWZmNHMTBMbUZ6YzJWMFgzSmxZMlZwZG1WeUlEMDlJRWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTUtJQ0FnSUdSMWNBb2dJQ0FnWjNSNGJuTWdRWE56WlhSU1pXTmxhWFpsY2dvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUdOc1lXbHRYMlJsYlc5ZmRHOXJaVzV6TG5CNU9qWTNDaUFnSUNBdkx5QmhjM05sY25RZ2MzUmhhMlZmY0cxMExuaG1aWEpmWVhOelpYUXVhV1FnUFQwZ2MyVnNaaTVuZW1OZllYTmhYMmxrQ2lBZ0lDQmtkWEFLSUNBZ0lHZDBlRzV6SUZobVpYSkJjM05sZEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbWQ2WTE5aGMyRmZhV1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVozcGpYMkZ6WVY5cFpDQmxlR2x6ZEhNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUdOc1lXbHRYMlJsYlc5ZmRHOXJaVzV6TG5CNU9qWTRDaUFnSUNBdkx5QmhjM05sY25RZ2MzUmhhMlZmY0cxMExtRnpjMlYwWDJGdGIzVnVkQ0ErSURBS0lDQWdJR2QwZUc1eklFRnpjMlYwUVcxdmRXNTBDaUFnSUNCa2RYQUtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdZMnhoYVcxZlpHVnRiMTkwYjJ0bGJuTXVjSGs2TnpFS0lDQWdJQzh2SUhOMFlXdGxaRjloYlc5MWJuUTlZWEpqTkM1VlNXNTBOalFvYzNSaGEyVmZjRzEwTG1GemMyVjBYMkZ0YjNWdWRDa3NDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QmpiR0ZwYlY5a1pXMXZYM1J2YTJWdWN5NXdlVG8zTUMwM05Rb2dJQ0FnTHk4Z2MyVnNaaTV6ZEhWa1pXNTBYM0psWTI5eVpITmJZWEpqTkM1QlpHUnlaWE56S0ZSNGJpNXpaVzVrWlhJcFhTQTlJRk4wZFdSbGJuUkVZWFJoS0FvZ0lDQWdMeThnSUNBZ0lITjBZV3RsWkY5aGJXOTFiblE5WVhKak5DNVZTVzUwTmpRb2MzUmhhMlZmY0cxMExtRnpjMlYwWDJGdGIzVnVkQ2tzQ2lBZ0lDQXZMeUFnSUNBZ2JXRnlhM005WVhKak5DNVZTVzUwTmpRb01Da3NDaUFnSUNBdkx5QWdJQ0FnWTJobFlYUmZZMjkxYm5ROVlYSmpOQzVWU1c1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFnSUNBZ2FYTmZaWGhoYlY5aFkzUnBkbVU5WVhKak5DNVZTVzUwTmpRb01Ta0tJQ0FnSUM4dklDa0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJqYkdGcGJWOWtaVzF2WDNSdmEyVnVjeTV3ZVRvM01Bb2dJQ0FnTHk4Z2MyVnNaaTV6ZEhWa1pXNTBYM0psWTI5eVpITmJZWEpqTkM1QlpHUnlaWE56S0ZSNGJpNXpaVzVrWlhJcFhTQTlJRk4wZFdSbGJuUkVZWFJoS0FvZ0lDQWdZbmwwWldOZk1TQXZMeUFpYzNSMVpHVnVkRjl5WldOdmNtUnpJZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QmpiR0ZwYlY5a1pXMXZYM1J2YTJWdWN5NXdlVG8zTUMwM05Rb2dJQ0FnTHk4Z2MyVnNaaTV6ZEhWa1pXNTBYM0psWTI5eVpITmJZWEpqTkM1QlpHUnlaWE56S0ZSNGJpNXpaVzVrWlhJcFhTQTlJRk4wZFdSbGJuUkVZWFJoS0FvZ0lDQWdMeThnSUNBZ0lITjBZV3RsWkY5aGJXOTFiblE5WVhKak5DNVZTVzUwTmpRb2MzUmhhMlZmY0cxMExtRnpjMlYwWDJGdGIzVnVkQ2tzQ2lBZ0lDQXZMeUFnSUNBZ2JXRnlhM005WVhKak5DNVZTVzUwTmpRb01Da3NDaUFnSUNBdkx5QWdJQ0FnWTJobFlYUmZZMjkxYm5ROVlYSmpOQzVWU1c1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFnSUNBZ2FYTmZaWGhoYlY5aFkzUnBkbVU5WVhKak5DNVZTVzUwTmpRb01Ta0tJQ0FnSUM4dklDa0tJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJR05zWVdsdFgyUmxiVzlmZEc5clpXNXpMbkI1T2pZekNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QmpiR0ZwYlY5a1pXMXZYM1J2YTJWdWN5NURiR0ZwYlVSbGJXOVViMnRsYm5NdWNtVmpiM0prWDJOb1pXRjBXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LY21WamIzSmtYMk5vWldGME9nb2dJQ0FnTHk4Z1kyeGhhVzFmWkdWdGIxOTBiMnRsYm5NdWNIazZOemNLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdMeThnWTJ4aGFXMWZaR1Z0YjE5MGIydGxibk11Y0hrNk56a0tJQ0FnSUM4dklHRnpjMlZ5ZENCVWVHNHVjMlZ1WkdWeUlEMDlJRWRzYjJKaGJDNWpjbVZoZEc5eVgyRmtaSEpsYzNNc0lDSlBibXg1SUhCeWIyTjBiM0lpQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCbmJHOWlZV3dnUTNKbFlYUnZja0ZrWkhKbGMzTUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVDI1c2VTQndjbTlqZEc5eUNpQWdJQ0F2THlCamJHRnBiVjlrWlcxdlgzUnZhMlZ1Y3k1d2VUbzRNQW9nSUNBZ0x5OGdjbVZqYjNKa0lEMGdjMlZzWmk1emRIVmtaVzUwWDNKbFkyOXlaSE5iYzNSMVpHVnVkRjB1WTI5d2VTZ3BDaUFnSUNCaWVYUmxZMTh4SUM4dklDSnpkSFZrWlc1MFgzSmxZMjl5WkhNaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVjM1IxWkdWdWRGOXlaV052Y21SeklHVnVkSEo1SUdWNGFYTjBjd29nSUNBZ0x5OGdZMnhoYVcxZlpHVnRiMTkwYjJ0bGJuTXVjSGs2T0RFS0lDQWdJQzh2SUc1bGQxOWphR1ZoZEhNZ1BTQnlaV052Y21RdVkyaGxZWFJmWTI5MWJuUXVibUYwYVhabElDc2dNUW9nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURFMkNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQ3NLSUNBZ0lDOHZJR05zWVdsdFgyUmxiVzlmZEc5clpXNXpMbkI1T2pneUNpQWdJQ0F2THlCeVpXTnZjbVF1WTJobFlYUmZZMjkxYm5RZ1BTQmhjbU0wTGxWSmJuUTJOQ2h1WlhkZlkyaGxZWFJ6S1FvZ0lDQWdaSFZ3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhOM1lYQUtJQ0FnSUhKbGNHeGhZMlV5SURFMkNpQWdJQ0J6ZDJGd0NpQWdJQ0F2THlCamJHRnBiVjlrWlcxdlgzUnZhMlZ1Y3k1d2VUbzRNd29nSUNBZ0x5OGdhV1lnYm1WM1gyTm9aV0YwY3lBOVBTQXpPZ29nSUNBZ2NIVnphR2x1ZENBekNpQWdJQ0E5UFFvZ0lDQWdZbm9nY21WamIzSmtYMk5vWldGMFgyRm1kR1Z5WDJsbVgyVnNjMlZBTXdvZ0lDQWdMeThnWTJ4aGFXMWZaR1Z0YjE5MGIydGxibk11Y0hrNk9EUUtJQ0FnSUM4dklISmxZMjl5WkM1emRHRnJaV1JmWVcxdmRXNTBJRDBnWVhKak5DNVZTVzUwTmpRb2NtVmpiM0prTG5OMFlXdGxaRjloYlc5MWJuUXVibUYwYVhabElDOHZJRElwQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ2NIVnphR2x1ZENBeUNpQWdJQ0F2Q2lBZ0lDQnBkRzlpQ2lBZ0lDQnlaWEJzWVdObE1pQXdDZ3B5WldOdmNtUmZZMmhsWVhSZllXWjBaWEpmYVdaZlpXeHpaVUF6T2dvZ0lDQWdMeThnWTJ4aGFXMWZaR1Z0YjE5MGIydGxibk11Y0hrNk9EVUtJQ0FnSUM4dklITmxiR1l1YzNSMVpHVnVkRjl5WldOdmNtUnpXM04wZFdSbGJuUmRJRDBnY21WamIzSmtMbU52Y0hrb0tRb2dJQ0FnWkdsbklERUtJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJR05zWVdsdFgyUmxiVzlmZEc5clpXNXpMbkI1T2pjM0NpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QmpiR0ZwYlY5a1pXMXZYM1J2YTJWdWN5NURiR0ZwYlVSbGJXOVViMnRsYm5NdVkyOXRjR3hsZEdWZlpYaGhiVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21OdmJYQnNaWFJsWDJWNFlXMDZDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lpSUtJQ0FnSUM4dklHTnNZV2x0WDJSbGJXOWZkRzlyWlc1ekxuQjVPamczQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNHNGdNZ29nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJR05zWVdsdFgyUmxiVzlmZEc5clpXNXpMbkI1T2pnNUNpQWdJQ0F2THlCaGMzTmxjblFnVkhodUxuTmxibVJsY2lBOVBTQkhiRzlpWVd3dVkzSmxZWFJ2Y2w5aFpHUnlaWE56TENBaVQyNXNlU0J3Y205amRHOXlJZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWjJ4dlltRnNJRU55WldGMGIzSkJaR1J5WlhOekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRTl1YkhrZ2NISnZZM1J2Y2dvZ0lDQWdMeThnWTJ4aGFXMWZaR1Z0YjE5MGIydGxibk11Y0hrNk9UQUtJQ0FnSUM4dklISmxZMjl5WkNBOUlITmxiR1l1YzNSMVpHVnVkRjl5WldOdmNtUnpXM04wZFdSbGJuUmRMbU52Y0hrb0tRb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWMzUjFaR1Z1ZEY5eVpXTnZjbVJ6SWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVjM1IxWkdWdWRGOXlaV052Y21SeklHVnVkSEo1SUdWNGFYTjBjd29nSUNBZ0x5OGdZMnhoYVcxZlpHVnRiMTkwYjJ0bGJuTXVjSGs2T1RFS0lDQWdJQzh2SUdsbUlHWnBibUZzWDIxaGNtdHpJRDQ5SURnd0lHRnVaQ0J5WldOdmNtUXVZMmhsWVhSZlkyOTFiblF1Ym1GMGFYWmxJRDA5SURBNkNpQWdJQ0J3ZFhOb2FXNTBJRGd3Q2lBZ0lDQStQUW9nSUNBZ1lub2dZMjl0Y0d4bGRHVmZaWGhoYlY5aFpuUmxjbDlwWmw5bGJITmxRRFVLSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBeE5nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdKdWVpQmpiMjF3YkdWMFpWOWxlR0Z0WDJGbWRHVnlYMmxtWDJWc2MyVkFOUW9nSUNBZ0x5OGdZMnhoYVcxZlpHVnRiMTkwYjJ0bGJuTXVjSGs2T1RJdE9UWUtJQ0FnSUM4dklHbDBlRzR1UVhOelpYUlVjbUZ1YzJabGNpZ0tJQ0FnSUM4dklDQWdJQ0I0Wm1WeVgyRnpjMlYwUFVGemMyVjBLSE5sYkdZdVozcGpYMkZ6WVY5cFpDa3NDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUmZjbVZqWldsMlpYSTljM1IxWkdWdWRDNXVZWFJwZG1Vc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZllXMXZkVzUwUFhObGJHWXVjMk5vYjJ4aGNuTm9hWEJmWVcxdmRXNTBMQW9nSUNBZ0x5OGdLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnTHk4Z1kyeGhhVzFmWkdWdGIxOTBiMnRsYm5NdWNIazZPVE1LSUNBZ0lDOHZJSGhtWlhKZllYTnpaWFE5UVhOelpYUW9jMlZzWmk1bmVtTmZZWE5oWDJsa0tTd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKbmVtTmZZWE5oWDJsa0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbWQ2WTE5aGMyRmZhV1FnWlhocGMzUnpDaUFnSUNBdkx5QmpiR0ZwYlY5a1pXMXZYM1J2YTJWdWN5NXdlVG81TlFvZ0lDQWdMeThnWVhOelpYUmZZVzF2ZFc1MFBYTmxiR1l1YzJOb2IyeGhjbk5vYVhCZllXMXZkVzUwTEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbk5qYUc5c1lYSnphR2x3WDJGdGIzVnVkQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1elkyaHZiR0Z5YzJocGNGOWhiVzkxYm5RZ1pYaHBjM1J6Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ6YzJWMFFXMXZkVzUwQ2lBZ0lDQmthV2NnTXdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYzNObGRGSmxZMlZwZG1WeUNpQWdJQ0JwZEhodVgyWnBaV3hrSUZobVpYSkJjM05sZEFvZ0lDQWdMeThnWTJ4aGFXMWZaR1Z0YjE5MGIydGxibk11Y0hrNk9USUtJQ0FnSUM4dklHbDBlRzR1UVhOelpYUlVjbUZ1YzJabGNpZ0tJQ0FnSUdsdWRHTmZNaUF2THlCaGVHWmxjZ29nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0F2THlCamJHRnBiVjlrWlcxdlgzUnZhMlZ1Y3k1d2VUbzVNaTA1TmdvZ0lDQWdMeThnYVhSNGJpNUJjM05sZEZSeVlXNXpabVZ5S0FvZ0lDQWdMeThnSUNBZ0lIaG1aWEpmWVhOelpYUTlRWE56WlhRb2MyVnNaaTVuZW1OZllYTmhYMmxrS1N3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5eVpXTmxhWFpsY2oxemRIVmtaVzUwTG01aGRHbDJaU3dLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRjloYlc5MWJuUTljMlZzWmk1elkyaHZiR0Z5YzJocGNGOWhiVzkxYm5Rc0NpQWdJQ0F2THlBcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvS1kyOXRjR3hsZEdWZlpYaGhiVjloWm5SbGNsOXBabDlsYkhObFFEVTZDaUFnSUNBdkx5QmpiR0ZwYlY5a1pXMXZYM1J2YTJWdWN5NXdlVG81TndvZ0lDQWdMeThnYVdZZ2NtVmpiM0prTG5OMFlXdGxaRjloYlc5MWJuUXVibUYwYVhabElENGdNRG9LSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dOUW9nSUNBZ1lub2dZMjl0Y0d4bGRHVmZaWGhoYlY5aFpuUmxjbDlwWmw5bGJITmxRRGdLSUNBZ0lDOHZJR05zWVdsdFgyUmxiVzlmZEc5clpXNXpMbkI1T2prNExURXdNZ29nSUNBZ0x5OGdhWFI0Ymk1QmMzTmxkRlJ5WVc1elptVnlLQW9nSUNBZ0x5OGdJQ0FnSUhobVpYSmZZWE56WlhROVFYTnpaWFFvYzJWc1ppNW5lbU5mWVhOaFgybGtLU3dLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRjl5WldObGFYWmxjajF6ZEhWa1pXNTBMbTVoZEdsMlpTd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGOWhiVzkxYm5ROWNtVmpiM0prTG5OMFlXdGxaRjloYlc5MWJuUXVibUYwYVhabExBb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdMeThnWTJ4aGFXMWZaR1Z0YjE5MGIydGxibk11Y0hrNk9Ua0tJQ0FnSUM4dklIaG1aWEpmWVhOelpYUTlRWE56WlhRb2MyVnNaaTVuZW1OZllYTmhYMmxrS1N3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0puZW1OZllYTmhYMmxrSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtZDZZMTloYzJGZmFXUWdaWGhwYzNSekNpQWdJQ0JrYVdjZ05Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmMzTmxkRUZ0YjNWdWRBb2dJQ0FnWkdsbklETUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYTnpaWFJTWldObGFYWmxjZ29nSUNBZ2FYUjRibDltYVdWc1pDQllabVZ5UVhOelpYUUtJQ0FnSUM4dklHTnNZV2x0WDJSbGJXOWZkRzlyWlc1ekxuQjVPams0Q2lBZ0lDQXZMeUJwZEhodUxrRnpjMlYwVkhKaGJuTm1aWElvQ2lBZ0lDQnBiblJqWHpJZ0x5OGdZWGhtWlhJS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ0x5OGdZMnhoYVcxZlpHVnRiMTkwYjJ0bGJuTXVjSGs2T1RndE1UQXlDaUFnSUNBdkx5QnBkSGh1TGtGemMyVjBWSEpoYm5ObVpYSW9DaUFnSUNBdkx5QWdJQ0FnZUdabGNsOWhjM05sZEQxQmMzTmxkQ2h6Wld4bUxtZDZZMTloYzJGZmFXUXBMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYM0psWTJWcGRtVnlQWE4wZFdSbGJuUXVibUYwYVhabExBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFgyRnRiM1Z1ZEQxeVpXTnZjbVF1YzNSaGEyVmtYMkZ0YjNWdWRDNXVZWFJwZG1Vc0NpQWdJQ0F2THlBcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvS1kyOXRjR3hsZEdWZlpYaGhiVjloWm5SbGNsOXBabDlsYkhObFFEZzZDaUFnSUNBdkx5QmpiR0ZwYlY5a1pXMXZYM1J2YTJWdWN5NXdlVG94TURNS0lDQWdJQzh2SUdSbGJDQnpaV3htTG5OMGRXUmxiblJmY21WamIzSmtjMXR6ZEhWa1pXNTBYUW9nSUNBZ1pHbG5JREVLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdMeThnWTJ4aGFXMWZaR1Z0YjE5MGIydGxibk11Y0hrNk9EY0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBQUVFQ0NZRENtZDZZMTloYzJGZmFXUVBjM1IxWkdWdWRGOXlaV052Y21SekVuTmphRzlzWVhKemFHbHdYMkZ0YjNWdWRERVlRQUFRS0lHa2w5TG9BbWNxZ1lESXI2QWxaekViUVFBNU1Sa1VSREVZUklJR0JLQTdnZElFMzFUb3FnUVJFelFZQk9hVVhoY0ViM0E2VVFRTjBSaVdOaG9BamdZQUNRQWRBRWNBaVFEVUFRd0FNUmtVTVJnVUVFTTJHZ0ZKRlNVU1JCY3hBRElKRWtRb1RHY2pRellhQVVrVkpSSkVGekVBTWdrU1JDSW9aVVJMQVJKRXNUSUtJcklTc2hTeUVTU3lFQ0t5QWJNalE0QVFhR0Z6WDJOc1lXbHRaV1JmWkdWdGJ6RUFVRW05UlFFVVJMRWlLR1ZFTVFDQmdKVHIzQU95RXJJVXNoRWtzaEFpc2dHemdBZ0FBQUFBQUFBQUFiOGpRekVXSXdsSk9CQWtFa1FwTVFCUXZVVUJGRVJKT0JReUNoSkVTVGdSSWlobFJCSkVPQkpKUkJhQUdBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQVZBcE1RQlFUTDhqUXpZYUFVa1ZnU0FTUkRFQU1na1NSQ2xNVUVtK1JFbUJFRnNqQ0VrV1R3Sk1YQkJNZ1FNU1FRQUpTU0piZ1FJS0Zsd0FTd0ZNdnlORGdBQTJHZ0ZIQWhXQklCSkVOaG9DU1JVbEVrUVhNUUF5Q1JKRUtVOENVRWxPQXI1TVRnSkVnVkFQUVFBZlNZRVFXMEFBR0xFaUtHVkVJaXBsUkxJU1N3T3lGTElSSkxJUUlySUJzMGtpVzBsRkJVRUFGckVpS0dWRVN3U3lFa3NEc2hTeUVTU3lFQ0t5QWJOTEFieElJME09IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6NywicGF0Y2giOjEsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
