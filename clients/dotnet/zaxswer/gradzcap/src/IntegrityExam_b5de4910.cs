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

namespace Arc56.Generated.zaxswer.gradzcap.IntegrityExam_b5de4910
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
            public class CertificateData : AVMObjectType
            {
                public Algorand.Address StudentAddress { get; set; }

                public ulong FinalMarks { get; set; }

                public ulong TotalQuestions { get; set; }

                public ulong Timestamp { get; set; }

                public ulong NftId { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStudentAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vStudentAddress.From(StudentAddress);
                    ret.AddRange(vStudentAddress.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFinalMarks = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vFinalMarks.From(FinalMarks);
                    ret.AddRange(vFinalMarks.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalQuestions = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalQuestions.From(TotalQuestions);
                    ret.AddRange(vTotalQuestions.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTimestamp.From(Timestamp);
                    ret.AddRange(vTimestamp.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNftId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vNftId.From(NftId);
                    ret.AddRange(vNftId.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static CertificateData Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new CertificateData();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStudentAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vStudentAddress.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueStudentAddress = vStudentAddress.ToValue();
                    if (valueStudentAddress is Algorand.Address vStudentAddressValue) { ret.StudentAddress = vStudentAddressValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFinalMarks = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vFinalMarks.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFinalMarks = vFinalMarks.ToValue();
                    if (valueFinalMarks is ulong vFinalMarksValue) { ret.FinalMarks = vFinalMarksValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalQuestions = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalQuestions.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalQuestions = vTotalQuestions.ToValue();
                    if (valueTotalQuestions is ulong vTotalQuestionsValue) { ret.TotalQuestions = vTotalQuestionsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTimestamp.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTimestamp = vTimestamp.ToValue();
                    if (valueTimestamp is ulong vTimestampValue) { ret.Timestamp = vTimestampValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNftId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vNftId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueNftId = vNftId.ToValue();
                    if (valueNftId is ulong vNftIdValue) { ret.NftId = vNftIdValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as CertificateData);
                }
                public bool Equals(CertificateData? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(CertificateData left, CertificateData right)
                {
                    return EqualityComparer<CertificateData>.Default.Equals(left, right);
                }
                public static bool operator !=(CertificateData left, CertificateData right)
                {
                    return !(left == right);
                }

            }

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
        /// <param name="total_q"> </param>
        public async Task<ulong> CompleteExam(Algorand.Address student, ulong final_marks, ulong total_q, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 38, 34, 201, 82 };
            var studentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); studentAbi.From(student);
            var final_marksAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); final_marksAbi.From(final_marks);
            var total_qAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); total_qAbi.From(total_q);

            var result = await base.CallApp(new List<object> { abiHandle, studentAbi, final_marksAbi, total_qAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CompleteExam_Transactions(Algorand.Address student, ulong final_marks, ulong total_q, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 38, 34, 201, 82 };
            var studentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); studentAbi.From(student);
            var final_marksAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); final_marksAbi.From(final_marks);
            var total_qAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); total_qAbi.From(total_q);

            return await base.MakeTransactionList(new List<object> { abiHandle, studentAbi, final_marksAbi, total_qAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        ///Get certificate data for a student
        ///</summary>
        /// <param name="student"> </param>
        public async Task<Structs.CertificateData> GetCertificate(Algorand.Address student, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 174, 119, 144, 95 };
            var studentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); studentAbi.From(student);

            var result = await base.SimApp(new List<object> { abiHandle, studentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.CertificateData.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetCertificate_Transactions(Algorand.Address student, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 174, 119, 144, 95 };
            var studentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); studentAbi.From(student);

            return await base.MakeTransactionList(new List<object> { abiHandle, studentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiSW50ZWdyaXR5RXhhbSIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJDZXJ0aWZpY2F0ZURhdGEiOlt7Im5hbWUiOiJzdHVkZW50X2FkZHJlc3MiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6ImZpbmFsX21hcmtzIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InRvdGFsX3F1ZXN0aW9ucyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ0aW1lc3RhbXAiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoibmZ0X2lkIiwidHlwZSI6InVpbnQ2NCJ9XSwiU3R1ZGVudERhdGEiOlt7Im5hbWUiOiJzdGFrZWRfYW1vdW50IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6Im1hcmtzIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImNoZWF0X2NvdW50IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImlzX2V4YW1fYWN0aXZlIiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGVfYXBwbGljYXRpb24iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZ3pjX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im9wdF9pbl90b19hc3NldCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJnemNfYXNzZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2xhaW1fZGVtb190b2tlbnMiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic3Rha2VfYW5kX3N0YXJ0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImF4ZmVyIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3Rha2VfcG10IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlY29yZF9jaGVhdCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3R1ZGVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjb21wbGV0ZV9leGFtIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzdHVkZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaW5hbF9tYXJrcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidG90YWxfcSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFkbWluX3dpdGhkcmF3IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfY2VydGlmaWNhdGUiLCJkZXNjIjoiR2V0IGNlcnRpZmljYXRlIGRhdGEgZm9yIGEgc3R1ZGVudCIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3R1ZGVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIoYWRkcmVzcyx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiQ2VydGlmaWNhdGVEYXRhIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MywiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzIzNF0sImVycm9yTWVzc2FnZSI6IkFscmVhZHkgY2xhaW1lZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIwM10sImVycm9yTWVzc2FnZSI6IkFzc2V0IG1pc21hdGNoIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjkyXSwiZXJyb3JNZXNzYWdlIjoiRXhhbSBpbiBwcm9ncmVzcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE5NSw3MDJdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGNyZWF0b3IiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNjMsNDMzXSwiZXJyb3JNZXNzYWdlIjoiT25seSBwcm9jdG9yIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzQwXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5jZXJ0aWZpY2F0ZXMgZW50cnkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTk5LDIzOSwzMDYsNjMzLDY1NSw3MDddLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmd6Y19hc2FfaWQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjU5XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5zY2hvbGFyc2hpcF9hbW91bnQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzY5LDQ0NV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuc3R1ZGVudF9yZWNvcmRzIGVudHJ5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM1Nyw0MDUsNzM1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2NiwxODgsNDE2LDQyNyw2OTVdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyODNdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIGF4ZmVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBd0lERWdOQ0E0Q2lBZ0lDQmllWFJsWTJKc2IyTnJJQ0puZW1OZllYTmhYMmxrSWlBd2VEY3pJQ0p6WTJodmJHRnljMmhwY0Y5aGJXOTFiblFpSURCNE5qTWdNSGd4TlRGbU4yTTNOUW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0p1ZWlCdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwbHVkR1ZuY21sMGVVVjRZVzB1Y0hrNk16TUtJQ0FnSUM4dklITmxiR1l1WjNwalgyRnpZVjlwWkNBZ0lDQWdJQ0FnSUQwZ1ZVbHVkRFkwS0RBcENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKbmVtTmZZWE5oWDJsa0lnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlNXNTBaV2R5YVhSNVJYaGhiUzV3ZVRvek5Bb2dJQ0FnTHk4Z2MyVnNaaTV6WTJodmJHRnljMmhwY0Y5aGJXOTFiblFnUFNCVlNXNTBOalFvTUNrS0lDQWdJR0o1ZEdWalh6SWdMeThnSW5OamFHOXNZWEp6YUdsd1gyRnRiM1Z1ZENJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDBsdWRHVm5jbWwwZVVWNFlXMHVjSGs2TXpVS0lDQWdJQzh2SUhObGJHWXVkRzkwWVd4ZmNYVmxjM1JwYjI1eklDQWdJRDBnVlVsdWREWTBLREV3S1FvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0owYjNSaGJGOXhkV1Z6ZEdsdmJuTWlDaUFnSUNCd2RYTm9hVzUwSURFd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb0tiV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREk2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12U1c1MFpXZHlhWFI1UlhoaGJTNXdlVG95TmdvZ0lDQWdMeThnWTJ4aGMzTWdTVzUwWldkeWFYUjVSWGhoYlNoQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW5vZ2JXRnBibDlqY21WaGRHVmZUbTlQY0VBeE13b2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VHUm1OVFJsT0dGaElEQjRNVEV4TXpNME1UZ2dNSGhsTmprME5XVXhOeUF3ZURabU56QXpZVFV4SURCNE1qWXlNbU01TlRJZ01IZzVaR0ppTkdFM05pQXdlR0ZsTnpjNU1EVm1JQzh2SUcxbGRHaHZaQ0FpYjNCMFgybHVYM1J2WDJGemMyVjBLSFZwYm5RMk5DbDJiMmxrSWl3Z2JXVjBhRzlrSUNKamJHRnBiVjlrWlcxdlgzUnZhMlZ1Y3lncGRtOXBaQ0lzSUcxbGRHaHZaQ0FpYzNSaGEyVmZZVzVrWDNOMFlYSjBLR0Y0Wm1WeUtYWnZhV1FpTENCdFpYUm9iMlFnSW5KbFkyOXlaRjlqYUdWaGRDaGhaR1J5WlhOektYWnZhV1FpTENCdFpYUm9iMlFnSW1OdmJYQnNaWFJsWDJWNFlXMG9ZV1JrY21WemN5eDFhVzUwTmpRc2RXbHVkRFkwS1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpWVdSdGFXNWZkMmwwYUdSeVlYY29kV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW1kbGRGOWpaWEowYVdacFkyRjBaU2hoWkdSeVpYTnpLU2hoWkdSeVpYTnpMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ2tpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCdmNIUmZhVzVmZEc5ZllYTnpaWFFnWTJ4aGFXMWZaR1Z0YjE5MGIydGxibk1nYzNSaGEyVmZZVzVrWDNOMFlYSjBJSEpsWTI5eVpGOWphR1ZoZENCamIyMXdiR1YwWlY5bGVHRnRJR0ZrYldsdVgzZHBkR2hrY21GM0lHZGxkRjlqWlhKMGFXWnBZMkYwWlFvZ0lDQWdaWEp5Q2dwdFlXbHVYMk55WldGMFpWOU9iMDl3UURFek9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwbHVkR1ZuY21sMGVVVjRZVzB1Y0hrNk1qWUtJQ0FnSUM4dklHTnNZWE56SUVsdWRHVm5jbWwwZVVWNFlXMG9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZUdFd00ySTRNV1F5SUM4dklHMWxkR2h2WkNBaVkzSmxZWFJsWDJGd2NHeHBZMkYwYVc5dUtIVnBiblEyTkNsMmIybGtJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnWTNKbFlYUmxYMkZ3Y0d4cFkyRjBhVzl1Q2lBZ0lDQmxjbklLQ2dvdkx5QkpiblJsWjNKcGRIbEZlR0Z0TGtsdWRHVm5jbWwwZVVWNFlXMHVZM0psWVhSbFgyRndjR3hwWTJGMGFXOXVXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWTNKbFlYUmxYMkZ3Y0d4cFkyRjBhVzl1T2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDBsdWRHVm5jbWwwZVVWNFlXMHVjSGs2TXpjS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2hqY21WaGRHVTlJbkpsY1hWcGNtVWlLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDBsdWRHVm5jbWwwZVVWNFlXMHVjSGs2TXprS0lDQWdJQzh2SUhObGJHWXVaM3BqWDJGellWOXBaQ0FnSUNBZ0lDQWdJRDBnWjNwalgybGtMbWxrQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0puZW1OZllYTmhYMmxrSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5SmJuUmxaM0pwZEhsRmVHRnRMbkI1T2pRd0NpQWdJQ0F2THlCelpXeG1Mbk5qYUc5c1lYSnphR2x3WDJGdGIzVnVkQ0E5SUZWSmJuUTJOQ2d4TUY4d01EQmZNREF3WHpBd01Da0tJQ0FnSUdKNWRHVmpYeklnTHk4Z0luTmphRzlzWVhKemFHbHdYMkZ0YjNWdWRDSUtJQ0FnSUhCMWMyaHBiblFnTVRBd01EQXdNREF3TURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlNXNTBaV2R5YVhSNVJYaGhiUzV3ZVRvek53b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0dOeVpXRjBaVDBpY21WeGRXbHlaU0lwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdTVzUwWldkeWFYUjVSWGhoYlM1SmJuUmxaM0pwZEhsRmVHRnRMbTl3ZEY5cGJsOTBiMTloYzNObGRGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbTl3ZEY5cGJsOTBiMTloYzNObGREb0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OUpiblJsWjNKcGRIbEZlR0Z0TG5CNU9qUXlDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OUpiblJsWjNKcGRIbEZlR0Z0TG5CNU9qUTBDaUFnSUNBdkx5QmhjM05sY25RZ1ZIaHVMbk5sYm1SbGNpQTlQU0JIYkc5aVlXd3VZM0psWVhSdmNsOWhaR1J5WlhOekxDQWlUMjVzZVNCamNtVmhkRzl5SWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1oyeHZZbUZzSUVOeVpXRjBiM0pCWkdSeVpYTnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dWJIa2dZM0psWVhSdmNnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwbHVkR1ZuY21sMGVVVjRZVzB1Y0hrNk5EVUtJQ0FnSUM4dklHRnpjMlZ5ZENCbmVtTmZZWE56WlhRdWFXUWdQVDBnYzJWc1ppNW5lbU5mWVhOaFgybGtMQ0FpUVhOelpYUWdiV2x6YldGMFkyZ2lDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVozcGpYMkZ6WVY5cFpDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVuZW1OZllYTmhYMmxrSUdWNGFYTjBjd29nSUNBZ1pHbG5JREVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1FYTnpaWFFnYldsemJXRjBZMmdLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlKYm5SbFozSnBkSGxGZUdGdExuQjVPalEyTFRVd0NpQWdJQ0F2THlCcGRIaHVMa0Z6YzJWMFZISmhibk5tWlhJb0NpQWdJQ0F2THlBZ0lDQWdlR1psY2w5aGMzTmxkRDFuZW1OZllYTnpaWFFzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJmY21WalpXbDJaWEk5UjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRjloYlc5MWJuUTlNQ3dLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OUpiblJsWjNKcGRIbEZlR0Z0TG5CNU9qUTRDaUFnSUNBdkx5QmhjM05sZEY5eVpXTmxhWFpsY2oxSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TEFvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5SmJuUmxaM0pwZEhsRmVHRnRMbkI1T2pRNUNpQWdJQ0F2THlCaGMzTmxkRjloYlc5MWJuUTlNQ3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnpjMlYwUVcxdmRXNTBDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnpjMlYwVW1WalpXbDJaWElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdXR1psY2tGemMyVjBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZTVzUwWldkeWFYUjVSWGhoYlM1d2VUbzBOZ29nSUNBZ0x5OGdhWFI0Ymk1QmMzTmxkRlJ5WVc1elptVnlLQW9nSUNBZ2FXNTBZMTh5SUM4dklHRjRabVZ5Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OUpiblJsWjNKcGRIbEZlR0Z0TG5CNU9qUTJMVFV3Q2lBZ0lDQXZMeUJwZEhodUxrRnpjMlYwVkhKaGJuTm1aWElvQ2lBZ0lDQXZMeUFnSUNBZ2VHWmxjbDloYzNObGREMW5lbU5mWVhOelpYUXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUmZjbVZqWldsMlpYSTlSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5d0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGOWhiVzkxYm5ROU1Dd0tJQ0FnSUM4dklDa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlNXNTBaV2R5YVhSNVJYaGhiUzV3ZVRvME1nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdTVzUwWldkeWFYUjVSWGhoYlM1SmJuUmxaM0pwZEhsRmVHRnRMbU5zWVdsdFgyUmxiVzlmZEc5clpXNXpXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWTJ4aGFXMWZaR1Z0YjE5MGIydGxibk02Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12U1c1MFpXZHlhWFI1UlhoaGJTNXdlVG8xTlFvZ0lDQWdMeThnWVhOelpYSjBJSE5sYm1SbGNsOWhaR1J5WlhOeklHNXZkQ0JwYmlCelpXeG1MbWhoYzE5amJHRnBiV1ZrWDJSbGJXOHNJQ0pCYkhKbFlXUjVJR05zWVdsdFpXUWlDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzJOQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMGx1ZEdWbmNtbDBlVVY0WVcwdWNIazZOVFFLSUNBZ0lDOHZJSE5sYm1SbGNsOWhaR1J5WlhOeklEMGdZWEpqTkM1QlpHUnlaWE56S0ZSNGJpNXpaVzVrWlhJcENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12U1c1MFpXZHlhWFI1UlhoaGJTNXdlVG8xTlFvZ0lDQWdMeThnWVhOelpYSjBJSE5sYm1SbGNsOWhaR1J5WlhOeklHNXZkQ0JwYmlCelpXeG1MbWhoYzE5amJHRnBiV1ZrWDJSbGJXOHNJQ0pCYkhKbFlXUjVJR05zWVdsdFpXUWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdRV3h5WldGa2VTQmpiR0ZwYldWa0NpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlNXNTBaV2R5YVhSNVJYaGhiUzV3ZVRvMU5pMDJNQW9nSUNBZ0x5OGdhWFI0Ymk1QmMzTmxkRlJ5WVc1elptVnlLQW9nSUNBZ0x5OGdJQ0FnSUhobVpYSmZZWE56WlhROVFYTnpaWFFvYzJWc1ppNW5lbU5mWVhOaFgybGtLU3dLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRjl5WldObGFYWmxjajFVZUc0dWMyVnVaR1Z5TEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDJGdGIzVnVkRDFWU1c1ME5qUW9NVjh3TURCZk1EQXdYekF3TUNrc0NpQWdJQ0F2THlBcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12U1c1MFpXZHlhWFI1UlhoaGJTNXdlVG8xTndvZ0lDQWdMeThnZUdabGNsOWhjM05sZEQxQmMzTmxkQ2h6Wld4bUxtZDZZMTloYzJGZmFXUXBMQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltZDZZMTloYzJGZmFXUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WjNwalgyRnpZVjlwWkNCbGVHbHpkSE1LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlKYm5SbFozSnBkSGxGZUdGdExuQjVPalU0Q2lBZ0lDQXZMeUJoYzNObGRGOXlaV05sYVhabGNqMVVlRzR1YzJWdVpHVnlMQW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwbHVkR1ZuY21sMGVVVjRZVzB1Y0hrNk5Ua0tJQ0FnSUM4dklHRnpjMlYwWDJGdGIzVnVkRDFWU1c1ME5qUW9NVjh3TURCZk1EQXdYekF3TUNrc0NpQWdJQ0J3ZFhOb2FXNTBJREV3TURBd01EQXdNREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWE56WlhSQmJXOTFiblFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWE56WlhSU1pXTmxhWFpsY2dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JZWm1WeVFYTnpaWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlKYm5SbFozSnBkSGxGZUdGdExuQjVPalUyQ2lBZ0lDQXZMeUJwZEhodUxrRnpjMlYwVkhKaGJuTm1aWElvQ2lBZ0lDQnBiblJqWHpJZ0x5OGdZWGhtWlhJS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMGx1ZEdWbmNtbDBlVVY0WVcwdWNIazZOVFl0TmpBS0lDQWdJQzh2SUdsMGVHNHVRWE56WlhSVWNtRnVjMlpsY2lnS0lDQWdJQzh2SUNBZ0lDQjRabVZ5WDJGemMyVjBQVUZ6YzJWMEtITmxiR1l1WjNwalgyRnpZVjlwWkNrc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZmNtVmpaV2wyWlhJOVZIaHVMbk5sYm1SbGNpd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGOWhiVzkxYm5ROVZVbHVkRFkwS0RGZk1EQXdYekF3TUY4d01EQXBMQW9nSUNBZ0x5OGdLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OUpiblJsWjNKcGRIbEZlR0Z0TG5CNU9qWXhDaUFnSUNBdkx5QnpaV3htTG1oaGMxOWpiR0ZwYldWa1gyUmxiVzliYzJWdVpHVnlYMkZrWkhKbGMzTmRJRDBnWVhKak5DNVZTVzUwTmpRb01Ta0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdNREF3TURBd01EQXdNREF3TURFS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OUpiblJsWjNKcGRIbEZlR0Z0TG5CNU9qVXlDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJKYm5SbFozSnBkSGxGZUdGdExrbHVkR1ZuY21sMGVVVjRZVzB1YzNSaGEyVmZZVzVrWDNOMFlYSjBXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYzNSaGEyVmZZVzVrWDNOMFlYSjBPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMGx1ZEdWbmNtbDBlVVY0WVcwdWNIazZOak1LSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0F0Q2lBZ0lDQmtkWEFLSUNBZ0lHZDBlRzV6SUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpJZ0x5OGdZWGhtWlhJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdkSEpoYm5OaFkzUnBiMjRnZEhsd1pTQnBjeUJoZUdabGNnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwbHVkR1ZuY21sMGVVVjRZVzB1Y0hrNk5qVUtJQ0FnSUM4dklHRnpjMlZ5ZENCaGNtTTBMa0ZrWkhKbGMzTW9WSGh1TG5ObGJtUmxjaWtnYm05MElHbHVJSE5sYkdZdWMzUjFaR1Z1ZEY5eVpXTnZjbVJ6TENBaVJYaGhiU0JwYmlCd2NtOW5jbVZ6Y3lJS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnM013b2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCRmVHRnRJR2x1SUhCeWIyZHlaWE56Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12U1c1MFpXZHlhWFI1UlhoaGJTNXdlVG8yTmdvZ0lDQWdMeThnWVhOelpYSjBJSE4wWVd0bFgzQnRkQzVoYzNObGRGOXlaV05sYVhabGNpQTlQU0JIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpDaUFnSUNCa2RYQUtJQ0FnSUdkMGVHNXpJRUZ6YzJWMFVtVmpaV2wyWlhJS0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlNXNTBaV2R5YVhSNVJYaGhiUzV3ZVRvMk53b2dJQ0FnTHk4Z1lYTnpaWEowSUhOMFlXdGxYM0J0ZEM1NFptVnlYMkZ6YzJWMExtbGtJRDA5SUhObGJHWXVaM3BqWDJGellWOXBaQW9nSUNBZ1pIVndDaUFnSUNCbmRIaHVjeUJZWm1WeVFYTnpaWFFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSm5lbU5mWVhOaFgybGtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1kNlkxOWhjMkZmYVdRZ1pYaHBjM1J6Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12U1c1MFpXZHlhWFI1UlhoaGJTNXdlVG8yT0FvZ0lDQWdMeThnWVhOelpYSjBJSE4wWVd0bFgzQnRkQzVoYzNObGRGOWhiVzkxYm5RZ1BpQXdDaUFnSUNCbmRIaHVjeUJCYzNObGRFRnRiM1Z1ZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5SmJuUmxaM0pwZEhsRmVHRnRMbkI1T2pjd0NpQWdJQ0F2THlCemRHRnJaV1JmWVcxdmRXNTBQV0Z5WXpRdVZVbHVkRFkwS0hOMFlXdGxYM0J0ZEM1aGMzTmxkRjloYlc5MWJuUXBMQW9nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMGx1ZEdWbmNtbDBlVVY0WVcwdWNIazZOamt0TnpRS0lDQWdJQzh2SUhObGJHWXVjM1IxWkdWdWRGOXlaV052Y21SelcyRnlZelF1UVdSa2NtVnpjeWhVZUc0dWMyVnVaR1Z5S1YwZ1BTQlRkSFZrWlc1MFJHRjBZU2dLSUNBZ0lDOHZJQ0FnSUNCemRHRnJaV1JmWVcxdmRXNTBQV0Z5WXpRdVZVbHVkRFkwS0hOMFlXdGxYM0J0ZEM1aGMzTmxkRjloYlc5MWJuUXBMQW9nSUNBZ0x5OGdJQ0FnSUcxaGNtdHpQV0Z5WXpRdVZVbHVkRFkwS0RBcExBb2dJQ0FnTHk4Z0lDQWdJR05vWldGMFgyTnZkVzUwUFdGeVl6UXVWVWx1ZERZMEtEQXBMQW9nSUNBZ0x5OGdJQ0FnSUdselgyVjRZVzFmWVdOMGFYWmxQV0Z5WXpRdVZVbHVkRFkwS0RFcExBb2dJQ0FnTHk4Z0tRb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlKYm5SbFozSnBkSGxGZUdGdExuQjVPalk1Q2lBZ0lDQXZMeUJ6Wld4bUxuTjBkV1JsYm5SZmNtVmpiM0prYzF0aGNtTTBMa0ZrWkhKbGMzTW9WSGh1TG5ObGJtUmxjaWxkSUQwZ1UzUjFaR1Z1ZEVSaGRHRW9DaUFnSUNCaWVYUmxZMTh4SUM4dklEQjROek1LSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMGx1ZEdWbmNtbDBlVVY0WVcwdWNIazZOamt0TnpRS0lDQWdJQzh2SUhObGJHWXVjM1IxWkdWdWRGOXlaV052Y21SelcyRnlZelF1UVdSa2NtVnpjeWhVZUc0dWMyVnVaR1Z5S1YwZ1BTQlRkSFZrWlc1MFJHRjBZU2dLSUNBZ0lDOHZJQ0FnSUNCemRHRnJaV1JmWVcxdmRXNTBQV0Z5WXpRdVZVbHVkRFkwS0hOMFlXdGxYM0J0ZEM1aGMzTmxkRjloYlc5MWJuUXBMQW9nSUNBZ0x5OGdJQ0FnSUcxaGNtdHpQV0Z5WXpRdVZVbHVkRFkwS0RBcExBb2dJQ0FnTHk4Z0lDQWdJR05vWldGMFgyTnZkVzUwUFdGeVl6UXVWVWx1ZERZMEtEQXBMQW9nSUNBZ0x5OGdJQ0FnSUdselgyVjRZVzFmWVdOMGFYWmxQV0Z5WXpRdVZVbHVkRFkwS0RFcExBb2dJQ0FnTHk4Z0tRb2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMGx1ZEdWbmNtbDBlVVY0WVcwdWNIazZOak1LSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUVsdWRHVm5jbWwwZVVWNFlXMHVTVzUwWldkeWFYUjVSWGhoYlM1eVpXTnZjbVJmWTJobFlYUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B5WldOdmNtUmZZMmhsWVhRNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlNXNTBaV2R5YVhSNVJYaGhiUzV3ZVRvM05nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNBdkx5QmpiMjUwY21GamRITXZTVzUwWldkeWFYUjVSWGhoYlM1d2VUbzNPQW9nSUNBZ0x5OGdZWE56WlhKMElGUjRiaTV6Wlc1a1pYSWdQVDBnUjJ4dlltRnNMbU55WldGMGIzSmZZV1JrY21WemN5d2dJazl1YkhrZ2NISnZZM1J2Y2lJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHZHNiMkpoYkNCRGNtVmhkRzl5UVdSa2NtVnpjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUGJteDVJSEJ5YjJOMGIzSUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OUpiblJsWjNKcGRIbEZlR0Z0TG5CNU9qYzVDaUFnSUNBdkx5QnlaV052Y21RZ1BTQnpaV3htTG5OMGRXUmxiblJmY21WamIzSmtjMXR6ZEhWa1pXNTBYUzVqYjNCNUtDa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZzNNd29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5OMGRXUmxiblJmY21WamIzSmtjeUJsYm5SeWVTQmxlR2x6ZEhNS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5SmJuUmxaM0pwZEhsRmVHRnRMbkI1T2pnd0NpQWdJQ0F2THlCdVpYZGZZMmhsWVhSeklEMGdjbVZqYjNKa0xtTm9aV0YwWDJOdmRXNTBMbTVoZEdsMlpTQXJJREVLSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBeE5nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0FyQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12U1c1MFpXZHlhWFI1UlhoaGJTNXdlVG80TVFvZ0lDQWdMeThnY21WamIzSmtMbU5vWldGMFgyTnZkVzUwSUQwZ1lYSmpOQzVWU1c1ME5qUW9ibVYzWDJOb1pXRjBjeWtLSUNBZ0lHbDBiMklLSUNBZ0lISmxjR3hoWTJVeUlERTJDaUFnSUNBdkx5QmpiMjUwY21GamRITXZTVzUwWldkeWFYUjVSWGhoYlM1d2VUbzRNaTA0TXdvZ0lDQWdMeThnSXlBeE1EQWxJSE5zWVhOb0lHOXVJRUZPV1NCamFHVmhkQ0F0SUd0bFpYQWdZV3hzSUhOMFlXdGxJR2x1SUdOdmJuUnlZV04wQ2lBZ0lDQXZMeUJ5WldOdmNtUXVjM1JoYTJWa1gyRnRiM1Z1ZENBOUlHRnlZelF1VlVsdWREWTBLREFwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCeVpYQnNZV05sTWlBd0NpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlNXNTBaV2R5YVhSNVJYaGhiUzV3ZVRvNE5Bb2dJQ0FnTHk4Z2MyVnNaaTV6ZEhWa1pXNTBYM0psWTI5eVpITmJjM1IxWkdWdWRGMGdQU0J5WldOdmNtUXVZMjl3ZVNncENpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZTVzUwWldkeWFYUjVSWGhoYlM1d2VUbzNOZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnU1c1MFpXZHlhWFI1UlhoaGJTNUpiblJsWjNKcGRIbEZlR0Z0TG1OdmJYQnNaWFJsWDJWNFlXMWJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BqYjIxd2JHVjBaVjlsZUdGdE9nb2dJQ0FnY0hWemFHSjVkR1Z6SUNJaUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlNXNTBaV2R5YVhSNVJYaGhiUzV3ZVRvNE5nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEJ1SURJS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNd29nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5SmJuUmxaM0pwZEhsRmVHRnRMbkI1T2pnNENpQWdJQ0F2THlCaGMzTmxjblFnVkhodUxuTmxibVJsY2lBOVBTQkhiRzlpWVd3dVkzSmxZWFJ2Y2w5aFpHUnlaWE56TENBaVQyNXNlU0J3Y205amRHOXlJZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWjJ4dlltRnNJRU55WldGMGIzSkJaR1J5WlhOekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRTl1YkhrZ2NISnZZM1J2Y2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDBsdWRHVm5jbWwwZVVWNFlXMHVjSGs2T0RrS0lDQWdJQzh2SUhKbFkyOXlaQ0E5SUhObGJHWXVjM1IxWkdWdWRGOXlaV052Y21SelczTjBkV1JsYm5SZExtTnZjSGtvS1FvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURjekNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JpYjNoZloyVjBDaUFnSUNCemQyRndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV6ZEhWa1pXNTBYM0psWTI5eVpITWdaVzUwY25rZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12U1c1MFpXZHlhWFI1UlhoaGJTNXdlVG81TVMwNU1nb2dJQ0FnTHk4Z0l5QlBibXg1SUdsemMzVmxJR05sY25ScFptbGpZWFJsTENCeVpYUjFjbTRnYzNSaGEyVXNJR0Z1WkNCbmFYWmxJSE5qYUc5c1lYSnphR2x3SUdsbUlIQmhjM05sWkNCM2FYUm9JRTVQSUdOb1pXRjBjd29nSUNBZ0x5OGdibVowWDJsa0lEMGdWVWx1ZERZMEtEQXBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYzNkaGNBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwbHVkR1ZuY21sMGVVVjRZVzB1Y0hrNk9UTUtJQ0FnSUM4dklHbG1JR1pwYm1Gc1gyMWhjbXR6SUQ0OUlEZ3dJR0Z1WkNCeVpXTnZjbVF1WTJobFlYUmZZMjkxYm5RdWJtRjBhWFpsSUQwOUlEQTZDaUFnSUNCd2RYTm9hVzUwSURnd0NpQWdJQ0ErUFFvZ0lDQWdZbm9nWTI5dGNHeGxkR1ZmWlhoaGJWOWhablJsY2w5cFpsOWxiSE5sUURFd0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnY0hWemFHbHVkQ0F4TmdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR0p1ZWlCamIyMXdiR1YwWlY5bGVHRnRYMkZtZEdWeVgybG1YMlZzYzJWQU1UQUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OUpiblJsWjNKcGRIbEZlR0Z0TG5CNU9qazBMVEV3TmdvZ0lDQWdMeThnSXlCTmFXNTBJSE5qYUc5c1lYSnphR2x3SUU1R1ZDQmpaWEowYVdacFkyRjBaUW9nSUNBZ0x5OGdibVowWDJsa0lEMGdhWFI0Ymk1QmMzTmxkRU52Ym1acFp5Z0tJQ0FnSUM4dklDQWdJQ0IwYjNSaGJEMHhMQW9nSUNBZ0x5OGdJQ0FnSUdSbFkybHRZV3h6UFRBc0NpQWdJQ0F2THlBZ0lDQWdaR1ZtWVhWc2RGOW1jbTk2Wlc0OVJtRnNjMlVzQ2lBZ0lDQXZMeUFnSUNBZ2RXNXBkRjl1WVcxbFBXSWlSMXBEUlZKVUlpd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGOXVZVzFsUFdJaVIzSmhaRnBEWVhBZ1UyTm9iMnhoY25Ob2FYQWdRMlZ5ZEdsbWFXTmhkR1VpTEFvZ0lDQWdMeThnSUNBZ0lIVnliRDFpSW1oMGRIQnpPaTh2WjNKaFpIcGpZWEF1WTI5dEwzWmxjbWxtZVNJc0NpQWdJQ0F2THlBZ0lDQWdiV0Z1WVdkbGNqMUhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQWdJSEpsYzJWeWRtVTlSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5d0tJQ0FnSUM4dklDQWdJQ0JtY21WbGVtVTlSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5d0tJQ0FnSUM4dklDQWdJQ0JqYkdGM1ltRmphejFIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQW9nSUNBZ0x5OGdLUzV6ZFdKdGFYUW9LUzVqY21WaGRHVmtYMkZ6YzJWMExtbGtDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlNXNTBaV2R5YVhSNVJYaGhiUzV3ZVRveE1ESUtJQ0FnSUM4dklHMWhibUZuWlhJOVIyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3l3S0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlNXNTBaV2R5YVhSNVJYaGhiUzV3ZVRveE1ETXRNVEExQ2lBZ0lDQXZMeUJ5WlhObGNuWmxQVWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNDaUFnSUNBdkx5Qm1jbVZsZW1VOVIyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3l3S0lDQWdJQzh2SUdOc1lYZGlZV05yUFVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01zQ2lBZ0lDQmtkWEJ1SURNS0lDQWdJR2wwZUc1ZlptbGxiR1FnUTI5dVptbG5RWE56WlhSRGJHRjNZbUZqYXdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JEYjI1bWFXZEJjM05sZEVaeVpXVjZaUW9nSUNBZ2FYUjRibDltYVdWc1pDQkRiMjVtYVdkQmMzTmxkRkpsYzJWeWRtVUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1EyOXVabWxuUVhOelpYUk5ZVzVoWjJWeUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlNXNTBaV2R5YVhSNVJYaGhiUzV3ZVRveE1ERUtJQ0FnSUM4dklIVnliRDFpSW1oMGRIQnpPaTh2WjNKaFpIcGpZWEF1WTI5dEwzWmxjbWxtZVNJc0NpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnMk9EYzBOelEzTURjek0yRXlaakptTmpjM01qWXhOalEzWVRZek5qRTNNREpsTmpNMlpqWmtNbVkzTmpZMU56STJPVFkyTnprS0lDQWdJR2wwZUc1ZlptbGxiR1FnUTI5dVptbG5RWE56WlhSVlVrd0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OUpiblJsWjNKcGRIbEZlR0Z0TG5CNU9qRXdNQW9nSUNBZ0x5OGdZWE56WlhSZmJtRnRaVDFpSWtkeVlXUmFRMkZ3SUZOamFHOXNZWEp6YUdsd0lFTmxjblJwWm1sallYUmxJaXdLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRFEzTnpJMk1UWTBOV0UwTXpZeE56QXlNRFV6TmpNMk9EWm1ObU0yTVRjeU56TTJPRFk1TnpBeU1EUXpOalUzTWpjME5qazJOalk1TmpNMk1UYzBOalVLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRMjl1Wm1sblFYTnpaWFJPWVcxbENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlNXNTBaV2R5YVhSNVJYaGhiUzV3ZVRvNU9Rb2dJQ0FnTHk4Z2RXNXBkRjl1WVcxbFBXSWlSMXBEUlZKVUlpd0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEUTNOV0UwTXpRMU5USTFOQW9nSUNBZ2FYUjRibDltYVdWc1pDQkRiMjVtYVdkQmMzTmxkRlZ1YVhST1lXMWxDaUFnSUNBdkx5QmpiMjUwY21GamRITXZTVzUwWldkeWFYUjVSWGhoYlM1d2VUbzVPQW9nSUNBZ0x5OGdaR1ZtWVhWc2RGOW1jbTk2Wlc0OVJtRnNjMlVzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkRiMjVtYVdkQmMzTmxkRVJsWm1GMWJIUkdjbTk2Wlc0S0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5SmJuUmxaM0pwZEhsRmVHRnRMbkI1T2prM0NpQWdJQ0F2THlCa1pXTnBiV0ZzY3owd0xBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUTI5dVptbG5RWE56WlhSRVpXTnBiV0ZzY3dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDBsdWRHVm5jbWwwZVVWNFlXMHVjSGs2T1RZS0lDQWdJQzh2SUhSdmRHRnNQVEVzQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2FYUjRibDltYVdWc1pDQkRiMjVtYVdkQmMzTmxkRlJ2ZEdGc0NpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlNXNTBaV2R5YVhSNVJYaGhiUzV3ZVRvNU5DMDVOUW9nSUNBZ0x5OGdJeUJOYVc1MElITmphRzlzWVhKemFHbHdJRTVHVkNCalpYSjBhV1pwWTJGMFpRb2dJQ0FnTHk4Z2JtWjBYMmxrSUQwZ2FYUjRiaTVCYzNObGRFTnZibVpwWnlnS0lDQWdJSEIxYzJocGJuUWdNeUF2THlCaFkyWm5DaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5SmJuUmxaM0pwZEhsRmVHRnRMbkI1T2prMExURXdOZ29nSUNBZ0x5OGdJeUJOYVc1MElITmphRzlzWVhKemFHbHdJRTVHVkNCalpYSjBhV1pwWTJGMFpRb2dJQ0FnTHk4Z2JtWjBYMmxrSUQwZ2FYUjRiaTVCYzNObGRFTnZibVpwWnlnS0lDQWdJQzh2SUNBZ0lDQjBiM1JoYkQweExBb2dJQ0FnTHk4Z0lDQWdJR1JsWTJsdFlXeHpQVEFzQ2lBZ0lDQXZMeUFnSUNBZ1pHVm1ZWFZzZEY5bWNtOTZaVzQ5Um1Gc2MyVXNDaUFnSUNBdkx5QWdJQ0FnZFc1cGRGOXVZVzFsUFdJaVIxcERSVkpVSWl3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5dVlXMWxQV0lpUjNKaFpGcERZWEFnVTJOb2IyeGhjbk5vYVhBZ1EyVnlkR2xtYVdOaGRHVWlMQW9nSUNBZ0x5OGdJQ0FnSUhWeWJEMWlJbWgwZEhCek9pOHZaM0poWkhwallYQXVZMjl0TDNabGNtbG1lU0lzQ2lBZ0lDQXZMeUFnSUNBZ2JXRnVZV2RsY2oxSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TEFvZ0lDQWdMeThnSUNBZ0lISmxjMlZ5ZG1VOVIyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ0lDQm1jbVZsZW1VOVIyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ0lDQmpiR0YzWW1GamF6MUhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxBb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tTNWpjbVZoZEdWa1gyRnpjMlYwTG1sa0NpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdhWFI0YmlCRGNtVmhkR1ZrUVhOelpYUkpSQW9nSUNBZ1pIVndDaUFnSUNCaWRYSjVJRElLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlKYm5SbFozSnBkSGxGZUdGdExuQjVPakV3T0MweE1UTUtJQ0FnSUM4dklDTWdWSEpoYm5ObVpYSWdUa1pVSUhSdklITjBkV1JsYm5RS0lDQWdJQzh2SUdsMGVHNHVRWE56WlhSVWNtRnVjMlpsY2lnS0lDQWdJQzh2SUNBZ0lDQjRabVZ5WDJGemMyVjBQVUZ6YzJWMEtHNW1kRjlwWkNrc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZmNtVmpaV2wyWlhJOWMzUjFaR1Z1ZEM1dVlYUnBkbVVzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJmWVcxdmRXNTBQVEVzQ2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNBdkx5QmpiMjUwY21GamRITXZTVzUwWldkeWFYUjVSWGhoYlM1d2VUb3hNVElLSUNBZ0lDOHZJR0Z6YzJWMFgyRnRiM1Z1ZEQweExBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhOelpYUkJiVzkxYm5RS0lDQWdJR1JwWnlBMkNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYTnpaWFJTWldObGFYWmxjZ29nSUNBZ1pIVndDaUFnSUNCcGRIaHVYMlpwWld4a0lGaG1aWEpCYzNObGRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwbHVkR1ZuY21sMGVVVjRZVzB1Y0hrNk1UQTRMVEV3T1FvZ0lDQWdMeThnSXlCVWNtRnVjMlpsY2lCT1JsUWdkRzhnYzNSMVpHVnVkQW9nSUNBZ0x5OGdhWFI0Ymk1QmMzTmxkRlJ5WVc1elptVnlLQW9nSUNBZ2FXNTBZMTh5SUM4dklHRjRabVZ5Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OUpiblJsWjNKcGRIbEZlR0Z0TG5CNU9qRXdPQzB4TVRNS0lDQWdJQzh2SUNNZ1ZISmhibk5tWlhJZ1RrWlVJSFJ2SUhOMGRXUmxiblFLSUNBZ0lDOHZJR2wwZUc0dVFYTnpaWFJVY21GdWMyWmxjaWdLSUNBZ0lDOHZJQ0FnSUNCNFptVnlYMkZ6YzJWMFBVRnpjMlYwS0c1bWRGOXBaQ2tzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJmY21WalpXbDJaWEk5YzNSMVpHVnVkQzV1WVhScGRtVXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUmZZVzF2ZFc1MFBURXNDaUFnSUNBdkx5QXBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwbHVkR1ZuY21sMGVVVjRZVzB1Y0hrNk1USXdDaUFnSUNBdkx5QjBhVzFsYzNSaGJYQTlZWEpqTkM1VlNXNTBOalFvUjJ4dlltRnNMbXhoZEdWemRGOTBhVzFsYzNSaGJYQXBMQW9nSUNBZ1oyeHZZbUZzSUV4aGRHVnpkRlJwYldWemRHRnRjQW9nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMGx1ZEdWbmNtbDBlVVY0WVcwdWNIazZNVEl4Q2lBZ0lDQXZMeUJ1Wm5SZmFXUTlZWEpqTkM1VlNXNTBOalFvYm1aMFgybGtLU3dLSUNBZ0lITjNZWEFLSUNBZ0lHbDBiMklLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlKYm5SbFozSnBkSGxGZUdGdExuQjVPakV4TlMweE1qSUtJQ0FnSUM4dklDTWdVM1J2Y21VZ1kyVnlkR2xtYVdOaGRHVWdaR0YwWVNCdmJpMWphR0ZwYmdvZ0lDQWdMeThnYzJWc1ppNWpaWEowYVdacFkyRjBaWE5iYzNSMVpHVnVkRjBnUFNCRFpYSjBhV1pwWTJGMFpVUmhkR0VvQ2lBZ0lDQXZMeUFnSUNBZ2MzUjFaR1Z1ZEY5aFpHUnlaWE56UFhOMGRXUmxiblFzQ2lBZ0lDQXZMeUFnSUNBZ1ptbHVZV3hmYldGeWEzTTlZWEpqTkM1VlNXNTBOalFvWm1sdVlXeGZiV0Z5YTNNcExBb2dJQ0FnTHk4Z0lDQWdJSFJ2ZEdGc1gzRjFaWE4wYVc5dWN6MWhjbU0wTGxWSmJuUTJOQ2gwYjNSaGJGOXhLU3dLSUNBZ0lDOHZJQ0FnSUNCMGFXMWxjM1JoYlhBOVlYSmpOQzVWU1c1ME5qUW9SMnh2WW1Gc0xteGhkR1Z6ZEY5MGFXMWxjM1JoYlhBcExBb2dJQ0FnTHk4Z0lDQWdJRzVtZEY5cFpEMWhjbU0wTGxWSmJuUTJOQ2h1Wm5SZmFXUXBMQW9nSUNBZ0x5OGdLUW9nSUNBZ1pHbG5JRElLSUNBZ0lHUnBaeUE0Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBM0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OUpiblJsWjNKcGRIbEZlR0Z0TG5CNU9qRXhOUzB4TVRZS0lDQWdJQzh2SUNNZ1UzUnZjbVVnWTJWeWRHbG1hV05oZEdVZ1pHRjBZU0J2YmkxamFHRnBiZ29nSUNBZ0x5OGdjMlZzWmk1alpYSjBhV1pwWTJGMFpYTmJjM1IxWkdWdWRGMGdQU0JEWlhKMGFXWnBZMkYwWlVSaGRHRW9DaUFnSUNCaWVYUmxZMTh6SUM4dklEQjROak1LSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZTVzUwWldkeWFYUjVSWGhoYlM1d2VUb3hNVFV0TVRJeUNpQWdJQ0F2THlBaklGTjBiM0psSUdObGNuUnBabWxqWVhSbElHUmhkR0VnYjI0dFkyaGhhVzRLSUNBZ0lDOHZJSE5sYkdZdVkyVnlkR2xtYVdOaGRHVnpXM04wZFdSbGJuUmRJRDBnUTJWeWRHbG1hV05oZEdWRVlYUmhLQW9nSUNBZ0x5OGdJQ0FnSUhOMGRXUmxiblJmWVdSa2NtVnpjejF6ZEhWa1pXNTBMQW9nSUNBZ0x5OGdJQ0FnSUdacGJtRnNYMjFoY210elBXRnlZelF1VlVsdWREWTBLR1pwYm1Gc1gyMWhjbXR6S1N3S0lDQWdJQzh2SUNBZ0lDQjBiM1JoYkY5eGRXVnpkR2x2Ym5NOVlYSmpOQzVWU1c1ME5qUW9kRzkwWVd4ZmNTa3NDaUFnSUNBdkx5QWdJQ0FnZEdsdFpYTjBZVzF3UFdGeVl6UXVWVWx1ZERZMEtFZHNiMkpoYkM1c1lYUmxjM1JmZEdsdFpYTjBZVzF3S1N3S0lDQWdJQzh2SUNBZ0lDQnVablJmYVdROVlYSmpOQzVWU1c1ME5qUW9ibVowWDJsa0tTd0tJQ0FnSUM4dklDa0tJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlKYm5SbFozSnBkSGxGZUdGdExuQjVPakV5TkMweE1qVUtJQ0FnSUM4dklDTWdVbVYwZFhKdUlITjBZV3RsQ2lBZ0lDQXZMeUJwWmlCeVpXTnZjbVF1YzNSaGEyVmtYMkZ0YjNWdWRDNXVZWFJwZG1VZ1BpQXdPZ29nSUNBZ1pHbG5JREVLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1pIVndDaUFnSUNCaWRYSjVJRGdLSUNBZ0lHSjZJR052YlhCc1pYUmxYMlY0WVcxZllXWjBaWEpmYVdaZlpXeHpaVUE0Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12U1c1MFpXZHlhWFI1UlhoaGJTNXdlVG94TWpZdE1UTXdDaUFnSUNBdkx5QnBkSGh1TGtGemMyVjBWSEpoYm5ObVpYSW9DaUFnSUNBdkx5QWdJQ0FnZUdabGNsOWhjM05sZEQxQmMzTmxkQ2h6Wld4bUxtZDZZMTloYzJGZmFXUXBMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYM0psWTJWcGRtVnlQWE4wZFdSbGJuUXVibUYwYVhabExBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFgyRnRiM1Z1ZEQxeVpXTnZjbVF1YzNSaGEyVmtYMkZ0YjNWdWRDNXVZWFJwZG1Vc0NpQWdJQ0F2THlBcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12U1c1MFpXZHlhWFI1UlhoaGJTNXdlVG94TWpjS0lDQWdJQzh2SUhobVpYSmZZWE56WlhROVFYTnpaWFFvYzJWc1ppNW5lbU5mWVhOaFgybGtLU3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSm5lbU5mWVhOaFgybGtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1kNlkxOWhjMkZmYVdRZ1pYaHBjM1J6Q2lBZ0lDQmthV2NnTndvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYzNObGRFRnRiM1Z1ZEFvZ0lDQWdaR2xuSURZS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhOelpYUlNaV05sYVhabGNnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCWVptVnlRWE56WlhRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5SmJuUmxaM0pwZEhsRmVHRnRMbkI1T2pFeU5nb2dJQ0FnTHk4Z2FYUjRiaTVCYzNObGRGUnlZVzV6Wm1WeUtBb2dJQ0FnYVc1MFkxOHlJQzh2SUdGNFptVnlDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5SmJuUmxaM0pwZEhsRmVHRnRMbkI1T2pFeU5pMHhNekFLSUNBZ0lDOHZJR2wwZUc0dVFYTnpaWFJVY21GdWMyWmxjaWdLSUNBZ0lDOHZJQ0FnSUNCNFptVnlYMkZ6YzJWMFBVRnpjMlYwS0hObGJHWXVaM3BqWDJGellWOXBaQ2tzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJmY21WalpXbDJaWEk5YzNSMVpHVnVkQzV1WVhScGRtVXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUmZZVzF2ZFc1MFBYSmxZMjl5WkM1emRHRnJaV1JmWVcxdmRXNTBMbTVoZEdsMlpTd0tJQ0FnSUM4dklDa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZjM1ZpYldsMENncGpiMjF3YkdWMFpWOWxlR0Z0WDJGbWRHVnlYMmxtWDJWc2MyVkFPRG9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlKYm5SbFozSnBkSGxGZUdGdExuQjVPakV6TWkweE16Y0tJQ0FnSUM4dklDTWdSMmwyWlNCelkyaHZiR0Z5YzJocGNDQjBiMnRsYm5NS0lDQWdJQzh2SUdsMGVHNHVRWE56WlhSVWNtRnVjMlpsY2lnS0lDQWdJQzh2SUNBZ0lDQjRabVZ5WDJGemMyVjBQVUZ6YzJWMEtITmxiR1l1WjNwalgyRnpZVjlwWkNrc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZmNtVmpaV2wyWlhJOWMzUjFaR1Z1ZEM1dVlYUnBkbVVzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJmWVcxdmRXNTBQWE5sYkdZdWMyTm9iMnhoY25Ob2FYQmZZVzF2ZFc1MExBb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDBsdWRHVm5jbWwwZVVWNFlXMHVjSGs2TVRNMENpQWdJQ0F2THlCNFptVnlYMkZ6YzJWMFBVRnpjMlYwS0hObGJHWXVaM3BqWDJGellWOXBaQ2tzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlaM3BqWDJGellWOXBaQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1bmVtTmZZWE5oWDJsa0lHVjRhWE4wY3dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDBsdWRHVm5jbWwwZVVWNFlXMHVjSGs2TVRNMkNpQWdJQ0F2THlCaGMzTmxkRjloYlc5MWJuUTljMlZzWmk1elkyaHZiR0Z5YzJocGNGOWhiVzkxYm5Rc0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1pQXZMeUFpYzJOb2IyeGhjbk5vYVhCZllXMXZkVzUwSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuTmphRzlzWVhKemFHbHdYMkZ0YjNWdWRDQmxlR2x6ZEhNS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhOelpYUkJiVzkxYm5RS0lDQWdJR1JwWnlBMkNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGemMyVjBVbVZqWldsMlpYSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1dHWmxja0Z6YzJWMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlNXNTBaV2R5YVhSNVJYaGhiUzV3ZVRveE16SXRNVE16Q2lBZ0lDQXZMeUFqSUVkcGRtVWdjMk5vYjJ4aGNuTm9hWEFnZEc5clpXNXpDaUFnSUNBdkx5QnBkSGh1TGtGemMyVjBWSEpoYm5ObVpYSW9DaUFnSUNCcGJuUmpYeklnTHk4Z1lYaG1aWElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwbHVkR1ZuY21sMGVVVjRZVzB1Y0hrNk1UTXlMVEV6TndvZ0lDQWdMeThnSXlCSGFYWmxJSE5qYUc5c1lYSnphR2x3SUhSdmEyVnVjd29nSUNBZ0x5OGdhWFI0Ymk1QmMzTmxkRlJ5WVc1elptVnlLQW9nSUNBZ0x5OGdJQ0FnSUhobVpYSmZZWE56WlhROVFYTnpaWFFvYzJWc1ppNW5lbU5mWVhOaFgybGtLU3dLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRjl5WldObGFYWmxjajF6ZEhWa1pXNTBMbTVoZEdsMlpTd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGOWhiVzkxYm5ROWMyVnNaaTV6WTJodmJHRnljMmhwY0Y5aGJXOTFiblFzQ2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9LWTI5dGNHeGxkR1ZmWlhoaGJWOWhablJsY2w5cFpsOWxiSE5sUURFd09nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwbHVkR1ZuY21sMGVVVjRZVzB1Y0hrNk1UTTVMVEUwTUFvZ0lDQWdMeThnSXlCSlppQm1ZV2xzWldRZ2IzSWdZMmhsWVhSbFpDd2dhMlZsY0NCemRHRnJaU0JwYmlCamIyNTBjbUZqZENBb1lXeHlaV0ZrZVNCemJHRnphR1ZrS1FvZ0lDQWdMeThnWkdWc0lITmxiR1l1YzNSMVpHVnVkRjl5WldOdmNtUnpXM04wZFdSbGJuUmRDaUFnSUNCa2FXY2dNZ29nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12U1c1MFpXZHlhWFI1UlhoaGJTNXdlVG94TkRFS0lDQWdJQzh2SUhKbGRIVnliaUJoY21NMExsVkpiblEyTkNodVpuUmZhV1FwQ2lBZ0lDQmtkWEFLSUNBZ0lHbDBiMklLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlKYm5SbFozSnBkSGxGZUdGdExuQjVPamcyQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCSmJuUmxaM0pwZEhsRmVHRnRMa2x1ZEdWbmNtbDBlVVY0WVcwdVlXUnRhVzVmZDJsMGFHUnlZWGRiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwaFpHMXBibDkzYVhSb1pISmhkem9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlKYm5SbFozSnBkSGxGZUdGdExuQjVPakUwTXdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12U1c1MFpXZHlhWFI1UlhoaGJTNXdlVG94TkRVS0lDQWdJQzh2SUdGemMyVnlkQ0JVZUc0dWMyVnVaR1Z5SUQwOUlFZHNiMkpoYkM1amNtVmhkRzl5WDJGa1pISmxjM01zSUNKUGJteDVJR055WldGMGIzSWlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JuYkc5aVlXd2dRM0psWVhSdmNrRmtaSEpsYzNNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVzZVNCamNtVmhkRzl5Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12U1c1MFpXZHlhWFI1UlhoaGJTNXdlVG94TkRZdE1UVXdDaUFnSUNBdkx5QnBkSGh1TGtGemMyVjBWSEpoYm5ObVpYSW9DaUFnSUNBdkx5QWdJQ0FnZUdabGNsOWhjM05sZEQxQmMzTmxkQ2h6Wld4bUxtZDZZMTloYzJGZmFXUXBMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYM0psWTJWcGRtVnlQVWRzYjJKaGJDNWpjbVZoZEc5eVgyRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZllXMXZkVzUwUFdGdGIzVnVkQ3dLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OUpiblJsWjNKcGRIbEZlR0Z0TG5CNU9qRTBOd29nSUNBZ0x5OGdlR1psY2w5aGMzTmxkRDFCYzNObGRDaHpaV3htTG1kNlkxOWhjMkZmYVdRcExBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1kNlkxOWhjMkZmYVdRaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVaM3BqWDJGellWOXBaQ0JsZUdsemRITUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OUpiblJsWjNKcGRIbEZlR0Z0TG5CNU9qRTBPQW9nSUNBZ0x5OGdZWE56WlhSZmNtVmpaV2wyWlhJOVIyeHZZbUZzTG1OeVpXRjBiM0pmWVdSa2NtVnpjeXdLSUNBZ0lHZHNiMkpoYkNCRGNtVmhkRzl5UVdSa2NtVnpjd29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGemMyVjBRVzF2ZFc1MENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGemMyVjBVbVZqWldsMlpYSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1dHWmxja0Z6YzJWMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlNXNTBaV2R5YVhSNVJYaGhiUzV3ZVRveE5EWUtJQ0FnSUM4dklHbDBlRzR1UVhOelpYUlVjbUZ1YzJabGNpZ0tJQ0FnSUdsdWRHTmZNaUF2THlCaGVHWmxjZ29nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlNXNTBaV2R5YVhSNVJYaGhiUzV3ZVRveE5EWXRNVFV3Q2lBZ0lDQXZMeUJwZEhodUxrRnpjMlYwVkhKaGJuTm1aWElvQ2lBZ0lDQXZMeUFnSUNBZ2VHWmxjbDloYzNObGREMUJjM05sZENoelpXeG1MbWQ2WTE5aGMyRmZhV1FwTEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDNKbFkyVnBkbVZ5UFVkc2IySmhiQzVqY21WaGRHOXlYMkZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUmZZVzF2ZFc1MFBXRnRiM1Z1ZEN3S0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12U1c1MFpXZHlhWFI1UlhoaGJTNXdlVG94TkRNS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklFbHVkR1ZuY21sMGVVVjRZVzB1U1c1MFpXZHlhWFI1UlhoaGJTNW5aWFJmWTJWeWRHbG1hV05oZEdWYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncG5aWFJmWTJWeWRHbG1hV05oZEdVNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlNXNTBaV2R5YVhSNVJYaGhiUzV3ZVRveE5USUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwbHVkR1ZuY21sMGVVVjRZVzB1Y0hrNk1UVTFDaUFnSUNBdkx5QnlaWFIxY200Z2MyVnNaaTVqWlhKMGFXWnBZMkYwWlhOYmMzUjFaR1Z1ZEYwdVkyOXdlU2dwQ2lBZ0lDQmllWFJsWTE4eklDOHZJREI0TmpNS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZMlZ5ZEdsbWFXTmhkR1Z6SUdWdWRISjVJR1Y0YVhOMGN3b2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwbHVkR1ZuY21sMGVVVjRZVzB1Y0hrNk1UVXlDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFBRUVDQ1lGQ21kNlkxOWhjMkZmYVdRQmN4SnpZMmh2YkdGeWMyaHBjRjloYlc5MWJuUUJZd1FWSDN4MU1SaEFBQm9vSW1jcUltZUFEM1J2ZEdGc1gzRjFaWE4wYVc5dWM0RUtaekVaRkVReEdFRUFPWUlIQk45VTZLb0VFUk0wR0FUbWxGNFhCRzl3T2xFRUppTEpVZ1NkdTBwMkJLNTNrRjgyR2dDT0J3QWxBRThBZ2dETkFQb0NJQUpIQUlBRW9EdUIwallhQUk0QkFBRUFOaG9CU1JVbEVrUVhLRXhuS29HQXlLK2dKV2NqUXpZYUFVa1ZKUkpFRnpFQU1na1NSQ0lvWlVSTEFSSkVzVElLSXJJU3NoU3lFU1N5RUNLeUFiTWpRNEFCWkRFQVVFbTlSUUVVUkxFaUtHVkVNUUNCZ0pUcjNBT3lFcklVc2hFa3NoQWlzZ0d6Z0FnQUFBQUFBQUFBQWI4alF6RVdJd2xKT0JBa0VrUXBNUUJRdlVVQkZFUkpPQlF5Q2hKRVNUZ1JJaWhsUkJKRU9CSkpSQmFBR0FBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBVkFwTVFCUVRMOGpRellhQVVrVmdTQVNSREVBTWdrU1JDbE1VRW0rUkVtQkVGc2pDQlpjRUlBSUFBQUFBQUFBQUFCY0FMOGpRNEFBTmhvQlJ3SVZnU0FTUkRZYUFrbE9Ba2tWSlJKRUZ6WWFBMGxPQXhVbEVrUXhBRElKRWtRcFR3SlFTVTRDdmt4T0FrUWlUSUZRRDBFQTNVc0JnUkJiUUFEVnNUSUtSd095TExJcnNpcXlLWUFiYUhSMGNITTZMeTluY21Ga2VtTmhjQzVqYjIwdmRtVnlhV1o1c2llQUlFZHlZV1JhUTJGd0lGTmphRzlzWVhKemFHbHdJRU5sY25ScFptbGpZWFJsc2lhQUJrZGFRMFZTVkxJbElySWtJcklqSTdJaWdRT3lFQ0t5QWJPMFBFbEZBckVqc2hKTEJrbE9BcklVU2JJUkpMSVFJcklCc3pJSEZrd1dTd0pMQ0ZCTEIxQlBBbEJNVUN0UEFsQk12MHNCSWx0SlJRaEJBQmF4SWlobFJFc0hzaEpMQnJJVXNoRWtzaEFpc2dHenNTSW9aVVFpS21WRXNoSkxCcklVc2hFa3NoQWlzZ0d6U3dLOFNFa1dKd1JNVUxBalF6WWFBVWtWSlJKRUZ6RUFNZ2tTUkxFaUtHVkVNZ2xQQXJJU3NoU3lFU1N5RUNLeUFiTWpRellhQVVrVmdTQVNSQ3RNVUw1RUp3Uk1VTEFqUXc9PSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjcsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
